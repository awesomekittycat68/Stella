namespace Stella.Routes.API
{
    public class MySubscriptions
    {
        [ServerAPI.GET("/api/playersubscriptions/v1/my")]
        public List<object> PlayerSubscriptions()
        {
            return [];
        }
    }
}
