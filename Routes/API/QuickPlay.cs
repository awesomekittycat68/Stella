using Stella.Models;

namespace Stella.Routes.API
{
    public class QuickPlay
    {
        [ServerAPI.GET("/api/quickPlay/v1/getandclear")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnGetAndClear(MongoDB.User user)
        {
            return new PlayerQuickPlayDTO
            {
                RoomName = null,
                TargetPlayerId = user.AccountId
            };
        }
    }
}