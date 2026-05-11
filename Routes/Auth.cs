using MongoDB.Driver;
using Stella.Models;
using Stella.Routes.API;
using System.Text;
using System.Text.Json;

namespace Stella.Routes
{
    public static class AuthTokenErrors
    {
        public const string InvalidRequest = "invalid_request";

        public const string InvalidClient = "invalid_client";

        public const string InvalidGrant = "invalid_grant";

        public const string UnauthorizedClient = "unauthorized_client";

        public const string UnsupportedGrantType = "unsupported_grant_type";

        public const string UnsupportedResponseType = "unsupported_response_type";

        public const string InvalidScope = "invalid_scope";

        public const string AuthorizationPending = "authorization_pending";

        public const string AccessDenied = "access_denied";

        public const string SlowDown = "slow_down";

        public const string ExpiredToken = "expired_token";

        public static class InvalidGrantErrorDescriptions
        {
            public const string InvalidUsernameOrPassword = "invalid_username_or_password";

            public const string InvalidTime = "invalid time";

            public const string PlatformVerificationFailed = "platform verification failed";

            public const string InvalidPlatform = "invalid platform";

            public const string InvalidDeviceClass = "invalid device class";
        }
    }

    public class Auth
    {
        [ServerAPI.POST("/api/player/photon")]
        [ServerAPI.GET("/api/player/photon")]
        public async Task<dynamic> ReturnPhoton(HttpContext ctx)
        {
            if (ctx.Request.Method == "GET")
            {
                return new
                {
                    ResultCode = 1,
                    Message = ""
                };
            }

            using var reader = new StreamReader(ctx.Request.Body, Encoding.UTF8);
            var body = await reader.ReadToEndAsync();

            var jsonDoc = JsonDocument.Parse(body);
            var root = jsonDoc.RootElement;

            string accountId = root.GetProperty("accountId").GetString()!;
            string accessToken = root.GetProperty("accessToken").GetString()!;
            MongoDB.User user = MongoDB.usersCollection.Find(u => u.AccountId == long.Parse(accountId)).FirstOrDefault();

            IDictionary<string, object>? claims = JsonWebToken.VerifyAndDecode(accessToken);

            if (claims == null)
            {
                return new
                {
                    ResultCode = 0,
                    Message = ""
                };
            }

            if (!claims.TryGetValue("sub", out var subValue))
            {
                return new
                {
                    ResultCode = 0,
                    Message = ""
                };
            }

            if ((string)subValue != accountId)
            {
                return new
                {
                    ResultCode = 0,
                    Message = ""
                };
            }

            return new
            {
                UserId = accountId,
                Nickname = user.Username,
                ResultCode = 1,
                Message = ""
            };
        }

        [ServerAPI.POST("/auth/connect/token")]
        public dynamic ReturnLoginAccount(HttpContext ctx)
        {
            /* 
                {
                    "grant_type": "cached_login",
                    "account_id": "1",
                    "client_id": "recroom",
                    "client_secret": "VxZ53kgbbEaRoZAeMe00MagtgD12GLL2",
                    "platform": "0",
                    "platform_id": "76561199373121011",
                    "device_id": "29b97dab367c6d2be33552ca86adf5a21a17021a",
                    "device_class": "2",
                    "time": "2025-11-11T13:24:30.5873414Z",
                    "ver": "20200320",
                    "asid": "1762867470568",
                    "device_id2": "BA\u002B8j5stFzJjA4lttE3KPOzpp7sd2jYPnYgu8JE\u002B2Pw=",
                    "device_id3": "\u002B0Btqnu5U51gRQdjVZ2H2ntHjxRu3bYo7TYWVCkaHdY=",
                    "platform_auth": "{\u0022Ticket\u0022:\u0022140000006D248F3F3B6E70FEF3753654010010012C361369180000000100000002000000ED5C071BD8F4E79D4CC7AD0431000000B20000003200000004000000F3753654010010019E32070068C91C686F28A8C000000000A8C40B69287427690100DF97010000000000C6E58775B58789FDC0B2A299243F9AD743022B1D22D3921AD997EBACE9708C45DE6A93C68C1C913002C97D905AEC75ACAF25052DCC2534418B5A3BCF5A4EBE9ED48D6B5AAB0831A918ADA3782005B6929F9C1BA21E9B8BC63970B5FADE6CF8387CD42D86B7D0C36E3843B0057A60E03E5C59CCF0438DA058E54D9D1F326ABC08\u0022,\u0022AppId\u0022:\u0022471710\u0022}"
                }
            */
            
            string? grantType = ctx.Request.Form["grant_type"];
            string? clientId = ctx.Request.Form["client_id"];

            long authTime = DateTime.UtcNow.ToUnixTime();
            MongoDB.User user = MongoDB.usersCollection.Find(u => u.AccountId == long.Parse(ctx.Request.Form["account_id"])).FirstOrDefault();

            if (user.PlatformId != ulong.Parse(ctx.Request.Form["platform_id"].ToString()))
            {
                return Results.Forbid();
            }
            if (user.OtherData.DormRoomId == null)
            {
                long id = MongoDB.roomsCollection.CountDocuments(_ => true) + 1;

                MongoDB.RoomDetailsMongoDB roomDetails = new()
                {
                    Room = new()
                    {
                        RoomId = id,
                        Name = $"@{user.Username}'s Dorm",
                        Description = "A private room.",
                        CreatorPlayerId = user.AccountId,
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
                            RoomId = id,
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

                MongoDB.usersCollection.UpdateOne(
                    u => u.AccountId == user.AccountId,
                    Builders<MongoDB.User>.Update.Set(u => u.OtherData.DormRoomId, id)
                );
            }

            if (grantType == "cached_login")
            {
                return new LoginResponseDTO
                {
                    AccessToken = JsonWebToken.Generate(new Dictionary<string, object?>
                    {
                        { "iss", "https://auth.stellaonline.org" }, // Issuer
                        { "client_id", clientId }, // Client Application reciving events
                        { "role", user.IsDeveloper ? "developer" : "player" }, // Role
                        { "sub", ctx.Request.Form["account_id"].ToString() }, // Subject
                        { "auth_time", authTime }, // Authentication Time
                        { "idp", "local" }, // Identity Provider
                        { "jti", Guid.NewGuid().ToString("N").ToUpper() }, // JWT ID
                        { "sid", Guid.NewGuid().ToString("N").ToUpper() }, // Session ID
                        { "iat", DateTime.UtcNow.ToUnixTime() }, // Issued At
                        { "scope", new List<string> { "screenshare" } }, // a grouping of claims 
                        { "amr", new List<string> { "pwd" } } // Authentication Methods References (pwd=password, mfa=multi-factor authentication)
                    }, TimeSpan.FromHours(6)),
                    RefreshToken = JsonWebToken.Generate(new Dictionary<string, object?>
                    {
                        { "iss", "https://auth.stellaonline.org" }, // Issuer
                        { "client_id", clientId }, // Client Application reciving events
                        { "role", user.IsDeveloper ? "developer" : "player" }, // Role
                        { "sub", ctx.Request.Form["account_id"].ToString() }, // Subject
                        { "auth_time", authTime }, // Authentication Time
                        { "idp", "local" }, // Identity Provider
                        { "jti", Guid.NewGuid().ToString("N").ToUpper() }, // JWT ID
                        { "sid", Guid.NewGuid().ToString("N").ToUpper() }, // Session ID
                        { "iat", DateTime.UtcNow.ToUnixTime() }, // Issued At
                        { "scope", new List<string> { "screenshare" } }, // a grouping of claims 
                        { "amr", new List<string> { "pwd" } } // Authentication Methods References (pwd=password, mfa=multi-factor authentication)
                    }, TimeSpan.FromHours(6))
                };
            }
            else if (grantType == "refresh_token")
            {
                var decoded = JsonWebToken.VerifyAndDecode(ctx.Request.Form["refresh_token"]);
                return new RefreshLoginResponseDTO
                {
                    Token = JsonWebToken.Generate(new Dictionary<string, object?>
                    {
                        { "iss", "https://auth.stellaonline.org" }, // Issuer
                        { "client_id", "recnet" }, // Client Application reciving events
                        { "role", user.IsDeveloper ? "developer" : "player" }, // Role
                        { "sub", ctx.Request.Form["account_id"].ToString() }, // Subject
                        { "auth_time", authTime }, // Authentication Time
                        { "idp", "local" }, // Identity Provider
                        { "jti", Guid.NewGuid().ToString("N").ToUpper() }, // JWT ID
                        { "sid", Guid.NewGuid().ToString("N").ToUpper() }, // Session ID
                        { "iat", DateTime.UtcNow.ToUnixTime() }, // Issued At
                        { "scope", new List<string> { "screenshare" } }, // a grouping of claims 
                        { "amr", new List<string> { "pwd" } } // Authentication Methods References (pwd=password, mfa=multi-factor authentication)
                    }, TimeSpan.FromHours(6))
                };
            }

            return new
            {
            };
        }

        [ServerAPI.GET("/auth/cachedlogin/forplatformid/{platformType}/{platformId}")]
        public List<CachedLoginDTO> CachedLogins(PlatformType platformType, ulong platformId)
        {
            List<MongoDB.User> users = MongoDB.usersCollection.Find(u => u.PlatformId == platformId).ToList();

            var cachedLogins = users.Select(u => new CachedLoginDTO
            {
                AccountId = u.AccountId,
                Account = new AccountDTO
                {
                    AccountId = u.AccountId,
                    CreatedAt = u.CreatedAt,
                    DisplayName = u.DisplayName,
                    Username = u.Username,
                    ProfileImage = u.ProfileImage ?? "DefaultProfileImage",
                    IsJunior = u.IsJunior,
                    PlatformMask = 0
                },
                LastLoginTime = DateTime.MinValue,
                Platform = platformType,
                PlatformId = platformId,
                RequirePassword = false
            }).ToList();

            return cachedLogins;
        }

        [ServerAPI.GET("/auth/account/me/haspassword")]
        [ServerAPI.UseAuthorization]
        public IResult ReturnHasPassword(MongoDB.User user)
        {
            return Results.Json(user.Password != null);
        }

        [ServerAPI.GET("/auth/role/developer/{accountId}")]
        public IResult ReturnHasDeveloper(long accountId)
        {
            MongoDB.User user = MongoDB.usersCollection.Find(u => u.AccountId == accountId).FirstOrDefault();

            return Results.Json(user.IsDeveloper);
        }  

        [ServerAPI.POST("/auth/account/me/changepassword")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnChangePassword(MongoDB.User user, HttpContext ctx)
        {
            if (user.Password == null)
            {
                MongoDB.usersCollection.UpdateOne(
                    u => u.AccountId == user.AccountId,
                    Builders<MongoDB.User>.Update.Set(u => u.Password, ((string?)ctx.Request.Form["newPassword"]).ToSHA256())
                );
            }
            else
            {
                if (user.Password != ((string?)ctx.Request.Form["oldPassword"]).ToSHA256())
                {
                    return Results.Forbid();
                }

                MongoDB.usersCollection.UpdateOne(
                    u => u.AccountId == user.AccountId,
                    Builders<MongoDB.User>.Update.Set(u => u.Password, ((string?)ctx.Request.Form["newPassword"]).ToSHA256())
                );
            }

            return new ValueResponse
            {
                Value = null,
                Error = "",
                Success = true
            };
        }
    }
}