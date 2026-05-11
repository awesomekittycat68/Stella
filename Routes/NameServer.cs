using Stella.Models;

namespace Stella.Routes
{
    public class NS
    {
        [ServerAPI.GET("/")]
        public NameServerResponse NameServer()
        {
            return new NameServerResponse
            {
                Accounts = "http://ns.stellaonline.org",
                API = "http://ns.stellaonline.org", // dont add /api because every call to this service to this already does
                Auth = "http://ns.stellaonline.org/auth",
                CDN = "http://ns.stellaonline.org/cdn",
                Chat = "http://ns.stellaonline.org/chat",
                Clubs = "http://ns.stellaonline.org/clubs",
                Commerce = "http://ns.stellaonline.org/commerce",
                DataCollection = "http://ns.stellaonline.org/datacollection",
                Images = "http://ns.stellaonline.org/img",
                Leaderboard = "http://ns.stellaonline.org",
                Link = "http://ns.stellaonline.org/link",
                Matchmaking = "http://ns.stellaonline.org/match",
                Moderation = "http://ns.stellaonline.org/moderation",
                Notifications = "http://ns.stellaonline.org/notify",
                PlatformNotifications = "http://ns.stellaonline.org/platformnotifications",
                RoomComments = "http://ns.stellaonline.org/roomcomments",
                Rooms = "http://ns.stellaonline.org/rooms",
                Storage = "http://ns.stellaonline.org/storage",
                WWW = "http://stellaonline.org"
            };
        }
    }
}