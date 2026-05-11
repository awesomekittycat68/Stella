namespace Stella.Routes.API
{
    public class GetCurrentChecklist
    {
        [ServerAPI.GET("/api/checklist/v1/current")]
        public List<object> ReturnGetCurrentChecklist()
        {
            return [];
        }
    }
}