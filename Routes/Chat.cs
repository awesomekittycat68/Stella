namespace Stella.Routes
{
    public class Chat
    {
        [ServerAPI.GET("/chat/thread")]
        public List<object> ThreadGet()
        {
            return [];
        }
    }
}