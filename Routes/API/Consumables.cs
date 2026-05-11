namespace Stella.Routes.API
{
    public class Consumables
    {
        [ServerAPI.GET("/api/consumables/v1/getUnlocked")]
        public List<object> ReturnGetUnlockedConsumables()
        {
            return [];
        }
    }
}