using Stella.Models;

namespace Stella.Routes.API
{
    public class GetCommunityBoard
    {
        [ServerAPI.GET("/api/communityboard/v1/current")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnGetCommunityBoard()
        {
            return new CommunityBoardDTO
            {
                CurrentAnnouncement = new CommunityBoardAnnouncementDTO
                {
                    Message = "Welcome to Stella!!!!!11!!!1!1",
                    MoreInfoUrl = ""
                },
                FeaturedPlayer = new CommunityBoardFeaturedPlayerData
                {
                    Id = 1,
                    TitleOverride = "bxt",
                    UrlOverride = ""
                },
                FeaturedRoomGroup = new FeaturedRoomGroupDTO
                {
                    FeaturedRooms = [],
                    Name = "stella"
                },
                InstagramImages = [],
                Videos = []
            };
        }
    }
}