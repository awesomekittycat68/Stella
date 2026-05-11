namespace Stella.Routes.API
{
    public class Equipment
    {
        [ServerAPI.GET("/api/equipment/v2/getUnlocked")]
        public List<object> ReturnGetUnlockedEquipment()
        {
            return [];
        }
    }
}