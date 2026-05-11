using Stella.Models;

namespace Stella.Routes.API
{
    public class GetPlayerEvents
    {
        [ServerAPI.GET("/api/playerevents/v1/all")]
        public LocalPlayerEventInfo ReturnGetPlayerEvents()
        {
            return new LocalPlayerEventInfo
            {
                Created = [],
                Responses = []
            };
        }
    }
}