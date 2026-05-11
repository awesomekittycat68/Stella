namespace Stella.Routes.API
{
    public class GetRelationships
    {
        [ServerAPI.GET("/api/relationships/v2/get")]
        public List<object> RelationshipsGet()
        {
            return [];
        }

        [ServerAPI.POST("/api/relationships/v1/bulkignoreplatformusers")]
        public List<object> BulkIgnorePlatformUsers()
        {
            return [];
        }
    }
}