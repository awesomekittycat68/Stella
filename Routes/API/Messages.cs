namespace Stella.Routes.API
{
    public class GetMessages
    {
        [ServerAPI.GET("/api/messages/v2/get")]
        public List<object> MessagesGet()
        {
            return [];
        }
    }
}
