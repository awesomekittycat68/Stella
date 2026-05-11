using MongoDB.Driver;
using Stella.Models;

namespace Stella.Routes.API
{
    public class GetProgression
    {
        [ServerAPI.GET("/api/players/v1/progression/{accountId}")]
        public ProgressionDTO Progression(int accountId)
        {
            MongoDB.User user = MongoDB.usersCollection.Find(u => u.AccountId == accountId).FirstOrDefault();

            return new ProgressionDTO
            {
                AccountId = accountId,
                Level = 1,
                XP = 0
            };
        }
    }
}