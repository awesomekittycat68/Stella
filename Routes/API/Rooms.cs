using System.Linq;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using Stella.Models;

namespace Stella.Routes.API
{
    public class Rooms
    {
        [ServerAPI.GET("/api/rooms/v4/details/{RoomId}")]
        public RoomDetailsDTO ReturnGetRoomInfoById(long RoomId)
        {
            var room = MongoDB.roomsCollection.Find(u => u.Room.RoomId == RoomId).FirstOrDefault();

            return new RoomDetailsDTO
            {
                Room = room.Room,
                Scenes = room.Scenes,
                CoOwners = room.CoOwners,
                InvitedCoOwners = room.InvitedCoOwners,
                Moderators = room.Moderators,
                InvitedModerators = room.InvitedModerators,
                Hosts = room.Hosts,
                InvitedHosts = room.InvitedHosts,
                CheerCount = room.CheerCount,
                FavoriteCount = room.FavoriteCount,
                VisitCount = room.VisitCount,
                Tags = room.Tags
            };
        }

        [ServerAPI.GET("/api/rooms/v2/baserooms")]
        public async Task<List<RoomDTO>> GetBaseRooms(int id)
        {
            var roomDoc = await MongoDB.roomsCollection
                .Find(u => u.Room.RoomId == 29)
                .FirstOrDefaultAsync();

            return new List<RoomDTO> { roomDoc.Room };
        }



        [ServerAPI.GET("/api/rooms/v2/{RoomId}")]
        public RoomDTO ReturnGetRoomById(long RoomId)
        {
            var room = MongoDB.roomsCollection.Find(u => u.Room.RoomId == RoomId).FirstOrDefault();

            return room.Room;
        }

        [ServerAPI.GET("/api/rooms/v2/myrooms")]
        [ServerAPI.UseAuthorization]
        public async Task<List<RoomDTO>> ReturnMyRooms(MongoDB.User user)
        {
            int userIdInt = (int)user.AccountId;

            var myRooms = await MongoDB.roomsCollection.Find(r => (r.Room.CreatorPlayerId == userIdInt || r.CoOwners.Contains(userIdInt)) && !r.Room.IsDormRoom).ToListAsync();

            return myRooms.Select(r => r.Room).ToList();
        }




        [ServerAPI.GET("/api/rooms/v2/hot")]
        public async Task<dynamic> GetHotRooms(string? roomScoreType, string? tags)
        {
            var filter = Builders<MongoDB.RoomDetailsMongoDB>.Filter.Empty;

            var rooms = await MongoDB.roomsCollection.Find(filter).Limit(50).ToListAsync();

            if (rooms.Count == 0)
            {
                return new {};
            }

            var filtered = rooms.Where(r => r != null && r.Room.Accessibility == Accessibility.Public).Select(r => r.Room).ToList();

            if (filtered.Count == 0)
            {
                return new {};
            }

            return filtered.Select(r => new RoomOrPlaylist
            {
                RoomOrPlaylistId = r.RoomId,
                Name = r.Name,
                State = r.State,
                SupportsLevelVoting = r.SupportsLevelVoting,
                SupportsMobile = r.SupportsMobile,
                SupportsScreens = r.SupportsScreens,
                SupportsTeleportVR = r.SupportsTeleportVR,
                SupportsVRLow = r.SupportsVRLow,
                SupportsWalkVR = r.SupportsWalkVR,
                Accessibility = r.Accessibility,
                AllowsJuniors = r.AllowsJuniors,
                CloningAllowed = r.CloningAllowed,
                CreatorPlayerId = r.CreatorPlayerId,
                CustomRoomWarning = r.CustomRoomWarning,
                Description = r.Description,
                DisableMicAutoMute = r.DisableMicAutoMute,
                ImageName = r.ImageName,
                IsAGRoom = r.IsAGRoom,
                IsDormRoom = r.IsDormRoom,
                RoomWarningMask = r.WarningMask,
                Type = RoomOrPlaylistType.Room
            });
        }

        [ServerAPI.GET("/api/rooms/v2/name/{RoomName}")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnGetRoomInfoByName(string RoomName, MongoDB.User user)
        {
            RoomName = RoomName.Replace("+", " ");

            MongoDB.RoomDetailsMongoDB room;
            if (RoomName.Equals("dormroom", StringComparison.CurrentCultureIgnoreCase))
            {
                room = MongoDB.roomsCollection.Find(u => u.Room.RoomId == user.OtherData.DormRoomId).FirstOrDefault();
                room.Room.Name = "DormRoom";
            }
            else
            {
                room = MongoDB.roomsCollection.Find(u => u.Room.Name == RoomName).FirstOrDefault();
            }

            return room.Room;
        }

        [ServerAPI.POST("/api/rooms/v1/clone")]
        [ServerAPI.UseAuthorization]
        public async Task<object> CloneRoom(HttpContext ctx, MongoDB.User user)
        {
            using var reader = new StreamReader(ctx.Request.Body);
            var body = await reader.ReadToEndAsync();

            var json1 = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(body);

            var roomName = json1?["Name"].GetString();

            var original = await MongoDB.roomsCollection.Find(u => u.Room.RoomId == 29).FirstOrDefaultAsync();

            var bannedJson = await File.ReadAllTextAsync("Data/bannednames.json");
            var bannedObj = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(bannedJson);
            var bannedWords = bannedObj?["banned"] ?? new List<string>();

            if (!string.IsNullOrWhiteSpace(roomName) && bannedWords.Any(word => roomName.Contains(word, StringComparison.OrdinalIgnoreCase)))
            {
                return new
                {
                    Result = 1
                };
            }

            if (original == null)
            {
                throw new Exception("couldnt find maker room");
            }

            var max = await MongoDB.roomsCollection.Find(_ => true).SortByDescending(r => r.Room.RoomId).FirstOrDefaultAsync();

            int newId = (int)((max?.Room.RoomId ?? 29) + 1);

            string json = JsonSerializer.Serialize(original);
            var newRoomDoc = JsonSerializer.Deserialize<MongoDB.RoomDetailsMongoDB>(json)!;

            newRoomDoc.Id = ObjectId.GenerateNewId().ToString();

            newRoomDoc.Room.RoomId = newId;
            newRoomDoc.Room.CreatorPlayerId = (int)user.AccountId;
            newRoomDoc.Room.Name = roomName;

            foreach (var scene in newRoomDoc.Scenes)
            {
                scene.RoomId = newId;
                scene.DataModifiedAt = DateTime.UtcNow;
            }

            newRoomDoc.VisitCount = 0;
            newRoomDoc.CheerCount = 0;
            newRoomDoc.FavoriteCount = 0;

            await MongoDB.roomsCollection.InsertOneAsync(newRoomDoc);

            return new
            {
                Result = 0,
                RoomDetails = newRoomDoc
            };
        }

        [ServerAPI.POST("/api/rooms/v1/roomRolePermissions")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnRoomRolePermissions(MongoDB.User user)
        {
            return Results.Ok();
        }
    }
}