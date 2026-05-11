using Stella.Models;

namespace Stella.Routes.API
{
    public class GetCampusCard
    {
        [ServerAPI.POST("/api/CampusCard/v1/UpdateAndGetSubscription")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnGetCampusCard()
        {
            return new SubscriptionInfoDTO
            {
                PlatformAccountSubscribedPlayerId = 1,
                Subscription = new SubscriptionDTO
                {
                    SubscriptionId = 0,
                    RecNetPlayerId = 1,
                    PlatformType = 0,
                    PlatformId = "1",
                    PlatformPurchaseId = "0",
                    Level = SubscriptionLevel.Platinum,
                    Period = SubscriptionPeriod.Year,
                    ExpirationDate = DateTime.MinValue,
                    IsAutoRenewing = false,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow
                }
            };
        }
    }
}