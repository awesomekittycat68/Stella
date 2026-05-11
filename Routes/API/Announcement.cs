using Stella.Models;

namespace Stella.Routes.API
{
    public class GetAnnouncement
    {
        [ServerAPI.GET("/api/announcement/v1/get")]
        public List<AnnouncementDTO> ReturnGetAnnouncement()
        {
            return [];
        }
    }
}