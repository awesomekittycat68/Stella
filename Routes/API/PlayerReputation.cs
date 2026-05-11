using MongoDB.Driver;
using Stella.Models;

namespace Stella.Routes.API
{
    public class GetPlayerReputation
    {
        [ServerAPI.GET("/api/playerReputation/v1/{accountId}")]
        public ReputationDTO ReturnGetPlayerReputation(int accountId)
        {
            MongoDB.User user = MongoDB.usersCollection.Find(u => u.AccountId == accountId).FirstOrDefault();

            return new ReputationDTO
            {
                AccountId = accountId,
                Noteriety = 0,
                CheerGeneral = 0,
                CheerHelpful = 1,
                CheerGreatHost = 1,
                CheerSportsman = 1,
                CheerCreative = 1,
                CheerCredit = 0,
                SubscriberCount = 0,
                SubscribedCount = 0,
                SelectedCheer = CheerCategory.General
            };
        }
    }
}