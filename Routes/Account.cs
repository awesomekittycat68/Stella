using System.Text.Json;
using Microsoft.Extensions.Primitives;
using MongoDB.Driver;
using Stella.Models;
using Stella.Routes.API;

namespace Stella.Routes
{
    public class Account
    {
        [ServerAPI.GET("/account/me")]
        [ServerAPI.UseAuthorization]
        public dynamic AccountInfo(MongoDB.User user)
        {
            return new AccountDTO
            {
                AccountId = user.AccountId,
                CreatedAt = user.CreatedAt,
                DisplayName = user.DisplayName,
                Username = user.Username,
                ProfileImage = user.ProfileImage,
                IsJunior = user.IsJunior,
                PlatformMask = PlatformMask.None
            };
        }
        
        [ServerAPI.GET("/account/bulk")]
        public List<AccountDTO> BulkAccountInfo(HttpContext ctx)
        {
            StringValues idStrings = ctx.Request.Query["id"];
            if (idStrings.Count == 0) return [];

            List<long> ids = [];

            for (int i = 0; i < idStrings.Count; i++)
            {
                if (int.TryParse(idStrings[i], out int val))
                {
                    ids.Add(val);
                }
            }

            if (ids.Count == 0) return [];

            List<MongoDB.User> users = MongoDB.usersCollection.Find(u => ids.Contains(u.AccountId)).ToList();

            return [.. users.Select(u => new AccountDTO
            {
                AccountId = u.AccountId,
                Username = u.Username,
                DisplayName = u.DisplayName,
                CreatedAt = u.CreatedAt,
                ProfileImage = u.ProfileImage,
                IsJunior = u.IsJunior,
                PlatformMask = PlatformMask.None
            })];
        }
        
        [ServerAPI.GET("/account/{accountId}")]
        public dynamic ReturnGetAccount(long accountId)
        {
            MongoDB.User user = MongoDB.usersCollection.Find(u => u.AccountId == accountId).FirstOrDefault();

            return new AccountDTO
            {
                AccountId = accountId,
                CreatedAt = user.CreatedAt,
                DisplayName = user.DisplayName,
                Username = user.Username,
                ProfileImage = user.ProfileImage,
                IsJunior = user.IsJunior,
                PlatformMask = PlatformMask.None
            };
        }
        
        [ServerAPI.PUT("/account/me/bio")]
        [ServerAPI.UseAuthorization]
        public async Task<RecNetResult> ReturnBio(HttpContext ctx, MongoDB.User user)
        {
            string? bio = (ctx.Request.Form["bio"]);
            var bannedJson = await File.ReadAllTextAsync("Data/bannednames.json");
            var bannedObj = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(bannedJson);
            var bannedWords = bannedObj?["banned"] ?? new List<string>();

            if (!string.IsNullOrWhiteSpace(bio) && bannedWords.Any(word => bio.Contains(word, StringComparison.OrdinalIgnoreCase)))
            {
                return new RecNetResult
                {
                    Success = false,
                    Error = "no"
                };
            }
            MongoDB.usersCollection.UpdateOne(
                u => u.AccountId == user.AccountId,
                Builders<MongoDB.User>.Update.Set(u => u.Bio, bio)
            );


            return new RecNetResult
            {
                Success = true,
                Error = ""
            };
        }
        
        [ServerAPI.PUT("/account/me/profileimage")]
        [ServerAPI.UseAuthorization]
        public async Task<RecNetResult> ReturnProfileImage(HttpContext ctx, MongoDB.User user)
        {
            MongoDB.usersCollection.UpdateOne(
                u => u.AccountId == user.AccountId,
                Builders<MongoDB.User>.Update.Set(u => u.ProfileImage, (string?)ctx.Request.Form["imageName"])
            );
            
            await NotificationHub.SendWebsocket(user.AccountId, new
            {
                Id = "AccountUpdate",
                Msg = new AccountDTO
                {
                    AccountId = user.AccountId,
                    CreatedAt = user.CreatedAt,
                    DisplayName = user.DisplayName,
                    Username = user.Username,
                    ProfileImage = (string?)ctx.Request.Form["imageName"],
                    IsJunior = user.IsJunior,
                    PlatformMask = PlatformMask.None
                }
            });

            return new RecNetResult
            {
                Success = true,
                Error = ""
            };
        }
        
        [ServerAPI.PUT("/account/me/displayname")]
        [ServerAPI.UseAuthorization]
        public async Task<RecNetResult> ReturnDisplayName(HttpContext ctx, MongoDB.User user)
        {
            string? displayName = (string?)ctx.Request.Form["displayName"];

            var bannedJson = await File.ReadAllTextAsync("Data/bannednames.json");
            var bannedObj = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(bannedJson);
            var bannedWords = bannedObj?["banned"] ?? new List<string>();

            if (!string.IsNullOrWhiteSpace(displayName) && bannedWords.Any(word => displayName.Contains(word, StringComparison.OrdinalIgnoreCase)))
            {
                return new RecNetResult
                {
                    Success = false,
                    Error = "no"
                };
            }

            MongoDB.usersCollection.UpdateOne(
                u => u.AccountId == user.AccountId,
                Builders<MongoDB.User>.Update
                .Set(u => u.DisplayName, displayName)
                .Set(u => u.Username, displayName)
            );

            await NotificationHub.SendWebsocket(user.AccountId, new
            {
                Id = "AccountUpdate",
                Msg = new AccountDTO
                {
                    AccountId = user.AccountId,
                    CreatedAt = user.CreatedAt,
                    DisplayName = displayName,
                    Username = displayName,
                    ProfileImage = user.ProfileImage,
                    IsJunior = user.IsJunior,
                    PlatformMask = PlatformMask.None
                }
            });
            
            await NotificationHub.SendWebsocket(user.AccountId, new
            {
                Id = "SelfAccountUpdate",
                Msg = new AccountDTO
                {
                    AccountId = user.AccountId,
                    CreatedAt = user.CreatedAt,
                    DisplayName = displayName,
                    Username = displayName,
                    ProfileImage = user.ProfileImage,
                    IsJunior = user.IsJunior,
                    PlatformMask = PlatformMask.None
                }
            });

            return new RecNetResult
            {
                Success = true,
                Error = ""
            };
        }
        
        [ServerAPI.GET("/account/{accountId}/bio")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnGetBio(long accountId)
        {
            MongoDB.User user = MongoDB.usersCollection.Find(u => u.AccountId == accountId).FirstOrDefault();

            return new BioDTO
            {
                AccountId = accountId,
                Bio = user.Bio
            };
        }
        
        [ServerAPI.GET("/parentalcontrol/me")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnParentalControl(MongoDB.User user)
        {
            return new ParentalControl
            {
                AccountId = user.AccountId,
                DisallowInAppPurchase = true
            };
        }

        [ServerAPI.POST("/account/create")]
        public async Task<dynamic> ReturnCreateAccount(HttpContext ctx)
        {
            long newAccountId = MongoDB.usersCollection.CountDocuments(_ => true) + 1;
            ulong platformId = ulong.Parse(ctx.Request.Form["platformId"]!);

            if (!int.TryParse(ctx.Request.Form["platform"], out int platformValue) || !Enum.IsDefined(typeof(PlatformType), platformValue))
            {
                return Results.Forbid();
            }

            PlatformType platform = (PlatformType)platformValue;

            OculusServer.User? user = await OculusServer.GetUserAsync(platformId);

            if (user == null)
            {
                return Results.Forbid();
            }
            
            MongoDB.RoomDetailsMongoDB roomDetails = new()
            {
                Room = new()
                {
                    RoomId = MongoDB.roomsCollection.CountDocuments(_ => true) + 1,
                    Name = $"@{user.Alias}'s Dorm",
                    Description = "A private room.",
                    CreatorPlayerId = newAccountId,
                    ImageName = "ca673ff19c054158a15ff00f0b844ba7",
                    State = 0,
                    Accessibility = Accessibility.Unlisted,
                    SupportsLevelVoting = false,
                    IsAGRoom = false,
                    IsDormRoom = true,
                    CloningAllowed = false,
                    SupportsScreens = true,
                    SupportsWalkVR = true,
                    SupportsTeleportVR = true,
                    AllowsJuniors = true,
                    WarningMask = 0,
                    RoomWarningMask = 0,
                    CustomRoomWarning = null,
                    DisableMicAutoMute = true
                },
                Scenes = [
                    new()
                    {
                        RoomSceneId = 1,
                        RoomId = 1,
                        RoomSceneLocationId = "76d98498-60a1-430c-ab76-b54a29b7a163",
                        Name = "Home",
                        IsSandbox = true,
                        DataBlobName = "",
                        MaxPlayers = 4,
                        CanMatchmakeInto = true,
                        DataModifiedAt = DateTime.UtcNow
                    }
                ],
                CoOwners = [],
                InvitedCoOwners = [],
                Moderators = [],
                InvitedModerators = [],
                Hosts = [],
                InvitedHosts = [],
                CheerCount = 0,
                FavoriteCount = 0,
                VisitCount = 0,
                Tags = []
            };

            MongoDB.roomsCollection.InsertOne(roomDetails);

            MongoDB.User newUser = new()
            {
                AccountId = newAccountId,
                Username = user.Alias,
                DisplayName = user.Alias,
                CreatedAt = DateTime.UtcNow,
                ProfileImage = "DefaultProfilePicture",
                IsJunior = false,
                Email = null,
                Password = null,
                DateOfBirth = DateTime.UtcNow,
                PlatformId = platformId,
                Platform = platform,
                OtherData = new()
                {
                    RoomInstance = null,
                    Avatar = new()
                    {
                        OutfitSelections = $"{AvatarHelper.FemaleTShirt},,,,1",
                        FaceFeatures = "{\"ver\":3,\"eyeId\":\"AjGMoJhEcEehacRZjUMuDg\",\"eyePos\":{\"x\":-0.009999999776482582,\"y\":-0.03999999910593033},\"eyeScl\":0.05000000074505806,\"mouthId\":\"FrZBRanXEEK29yKJ4jiMjg\",\"mouthPos\":{\"x\":0.0,\"y\":0.07999999821186066},\"mouthScl\":0.05000000074505806,\"beardColorId\":\"81_c6R0my0qK9hYM_0a7LQ\"}",
                        SkinColor = "4fb0fdbd-b10a-492e-8df2-b43f981b2ce6",
                        HairColor = "81_c6R0my0qK9hYM_0a7LQ"
                    },
                    AvatarItems = [
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_AngledBob},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Angled Bob", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Fonzie},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Fonzie", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_FlatTop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Flat Top", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Emo},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Emo", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Shagg},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Shagg", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Afro},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Afro", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Ponytail},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Ponytail", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Lori},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Lori", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_HalfUp},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Half Up", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_ManBun},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Man Bun", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Mullet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mullet", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_PunkGirl},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Punk Girl", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Pompadour},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pompadour", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Jazzercise},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Jazzercise", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Spiky},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Spiky", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_PigTails},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pig Tails", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_WavyShort},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Wavy Short", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Bob},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bob", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_PulpFiction},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Pulp Fiction", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Part},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Part", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_GordonGekko},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Gordon Gekko", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_MeatballBuns},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Meatball Buns", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Undercut},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Undercut", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_BaldTop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bald Top", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_ChunkyAfro},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Chunky Afro", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Bishop},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bishop", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_FemaleCheerleader},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Female Cheerleader", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_ManPony},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Man Pony", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_DutchBraid},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Dutch Braid", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Malibu},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Malibu", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Punk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Punk", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_RecedingHairline},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Receding Hairline", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Rhianna},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Rhianna", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_GiantAfro},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Giant Afro", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Buzz},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Buzz", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_FauxHawk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Faux Hawk", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Bob_Bangs},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bob Bangs", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Mohawk},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Mohawk", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_WavyLong},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Wavy Long", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_DreadsLong},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Dreads Long", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Scientist},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Scientist", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_UnderCutSheet},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Under Cut Sheet", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_JackFrostNoCrystalsHair},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Jack Frost No Crystals Hair", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_Bun},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Bun", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.Hair_LongBangs},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "Long Bangs", Rarity = GiftRarity.Common, Tooltip = "" },
                        new() { AvatarItemDesc = $"{AvatarHelper.FemaleTShirt},,,", AvatarItemType = AvatarItemType.Outfit, FriendlyName = "RecRoom Shirt", Rarity = GiftRarity.Common, Tooltip = "" }
                    ],
                    LoginLockCode = null,
                    DormRoomId = roomDetails.Room.RoomId
                }
            };

            MongoDB.usersCollection.InsertOne(newUser);

            AccountDTO accountDto = new()
            {
                AccountId = newUser.AccountId,
                Username = newUser.Username,
                DisplayName = newUser.DisplayName,
                CreatedAt = newUser.CreatedAt,
                ProfileImage = newUser.ProfileImage,
                IsJunior = newUser.IsJunior,
                PlatformMask = 0
            };

            return Results.Ok(new ValueResponse
            {
                Value = accountDto,
                Success = true,
                Error = ""
            });
        }
        [ServerAPI.POST("/account/me/email")]
        [ServerAPI.UseAuthorization]
        public RecNetResult ReturnChangePassword(MongoDB.User user, HttpContext ctx)
        {
            MongoDB.usersCollection.UpdateOne(
                u => u.AccountId == user.AccountId,
                Builders<MongoDB.User>.Update.Set(u => u.Email, (string?)ctx.Request.Form["email"])
            );

            return new RecNetResult
            {
                Error = "",
                Success = true
            };
        }
    }
}