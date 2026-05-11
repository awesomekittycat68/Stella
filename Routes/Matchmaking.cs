using MongoDB.Driver;
using Stella.Models;
using Stella.Routes.API;

namespace Stella.Routes
{
    public class Matchmaking
    {
        [ServerAPI.PUT("/match/player/vrmovementmode")]
        public IResult ReturnVRMovementMode()
        {
            return Results.Ok();
        }

        [ServerAPI.PUT("/match/player/statusvisibility")]
        public IResult ReturnStatusVisibility()
        {
            return Results.Ok();
        }

        [ServerAPI.PUT("/match/player/photonregionpings")]
        public IResult ReturnPhotonRegionPings()
        {
            return Results.Ok();
        }

        [ServerAPI.POST("/match/player/login")] // return 409 for "This account is already logged in somewhere else!" error
        public IResult ReturnLogin()
        {
            return Results.Ok();
        }

        [ServerAPI.POST("/match/roominstance/{roomInstanceId}/reportjoinresult")] // return 409 for "This account is already logged in somewhere else!" error
        public IResult ReturnReportJoinResult(long roomInstanceId)
        {
            return Results.Ok();
        }

        [ServerAPI.POST("/match/player/heartbeat")]
        [ServerAPI.UseAuthorization]
        public async Task<dynamic> ReturnHeartbeat(MongoDB.User user)
        {
            PlayerPresence presence = new()
            {
                StatusVisibility = PlayerStatusVisibility.Public,
                AppVersion = BuildConstants.Version,
                DeviceClass = DeviceClass.VR,
                IsOnline = true,
                PlayerId = user.AccountId,
                RoomInstance = user.OtherData.RoomInstance,
                VRMovementMode = VRMovementMode.WALK
            };

            await NotificationHub.SendWebsocket(user.AccountId, new
            {
                Id = PushNotificationId.PresenceHeartbeatResponse,
                Msg = presence
            });

            return presence;
        }

        [ServerAPI.POST("/match/goto/room/{roomName}")]
        [ServerAPI.UseAuthorization]
        public async Task<dynamic> ReturnGotoRoom(string roomName, MongoDB.User user)
        {
            MongoDB.RoomDetailsMongoDB room;
            if (roomName.Equals("dormroom", StringComparison.CurrentCultureIgnoreCase))
            {
                room = MongoDB.roomsCollection.Find(u => u.Room.RoomId == user.OtherData.DormRoomId).FirstOrDefault();
            }
            else
            {

                room = MongoDB.roomsCollection.Find(u => u.Room.Name == roomName).FirstOrDefault();
            }

            RoomInstance roomInstance = new()
            {
                RoomId = room.Room.RoomId,
                Name = room.Room.Name.StartsWith("@") ? room.Room.Name : "^" + room.Room.Name,
                DataBlob = "",
                IsFull = false,
                IsInProgress = false,
                IsPrivate = false,
                Location = room.Scenes[0].RoomSceneLocationId,
                MaxCapacity = room.Scenes[0].MaxPlayers,
                PhotonRegionId = "us",
                PhotonRoomId = $"stella.{"" + room.Room.Name}",
                RoomInstanceId = room.Room.RoomId,
                SubRoomId = 1
            };

            MatchmakingResponseDTO response = new()
            {
                ErrorCode = MatchmakingErrorCode.Success,
                RoomInstance = roomInstance
            };

            MongoDB.usersCollection.UpdateOne(
                u => u.AccountId == user.AccountId,
                Builders<MongoDB.User>.Update.Set(u => u.OtherData.RoomInstance, roomInstance)
            );
            
            await NotificationHub.SendWebsocket(user.AccountId, new
            {
                Id = "PresenceUpdate",
                Msg = response
            });

            await NotificationHub.SendWebsocket(user.AccountId, new
            {
                Id = "RoomInstanceUpdate",
                Msg = response
            });

            return response;
        }

        [ServerAPI.POST("/match/goto/room/{roomName}/{roomScene}")]
        [ServerAPI.UseAuthorization]
        public async Task<dynamic> ReturnGotoRoomScene(string roomName, string roomScene, MongoDB.User user)
        {
            MongoDB.RoomDetailsMongoDB room = MongoDB.roomsCollection.Find(u => u.Room.Name == roomName).FirstOrDefault();

            int sceneIndex = room.Scenes.FindIndex(s => s.Name.Equals(roomScene, StringComparison.CurrentCultureIgnoreCase));

            RoomInstance roomInstance = new()
            {
                RoomId = room.Room.RoomId,
                Name = "^" + room.Room.Name,
                DataBlob = "",
                IsFull = false,
                IsInProgress = false,
                IsPrivate = false,
                Location = room.Scenes[sceneIndex].RoomSceneLocationId,
                MaxCapacity = room.Scenes[sceneIndex].MaxPlayers,
                PhotonRegionId = "us",
                PhotonRoomId = $"stella.{"^" + room.Room.Name}",
                RoomInstanceId = room.Room.RoomId + (sceneIndex + 10000),
                SubRoomId = 1
            };

            MatchmakingResponseDTO response = new()
            {
                ErrorCode = MatchmakingErrorCode.Success,
                RoomInstance = roomInstance
            };

            MongoDB.usersCollection.UpdateOne(
                u => u.AccountId == user.AccountId,
                Builders<MongoDB.User>.Update.Set(u => u.OtherData.RoomInstance, roomInstance)
            );
            
            await NotificationHub.SendWebsocket(user.AccountId, new
            {
                Id = "PresenceUpdate",
                Msg = response
            });

            await NotificationHub.SendWebsocket(user.AccountId, new
            {
                Id = "RoomInstanceUpdate",
                Msg = response
            });

            return response;
        }

        [ServerAPI.POST("/match/goto/none")]
        [ServerAPI.UseAuthorization]
        public async Task<dynamic> ReturnNone(MongoDB.User user)
        {
            MatchmakingResponseDTO response = new()
            {
                ErrorCode = MatchmakingErrorCode.Success,
                RoomInstance = new RoomInstance
                {
                    RoomId = 1,
                    Name = $"^@{user.Username}'s Dorm",
                    DataBlob = "",
                    IsFull = false,
                    IsInProgress = false,
                    IsPrivate = false,
                    Location = "76d98498-60a1-430c-ab76-b54a29b7a163",
                    MaxCapacity = 20,
                    PhotonRegionId = "us",
                    PhotonRoomId = $"stella.{$"^@{user.Username}'s Dorm"}",
                    RoomInstanceId = 1,
                    SubRoomId = 1
                }
            };

            MongoDB.usersCollection.UpdateOne(
                u => u.AccountId == user.AccountId,
                Builders<MongoDB.User>.Update.Set(u => u.OtherData.RoomInstance, response.RoomInstance)
            );

            await NotificationHub.SendWebsocket(user.AccountId, new
            {
                Id = "PresenceUpdate",
                Msg = response
            });

            await NotificationHub.SendWebsocket(user.AccountId, new
            {
                Id = "RoomInstanceUpdate",
                Msg = response
            });

            return response;
        }
    }
}