using MongoDB.Driver;
using Stella.Models;

namespace Stella.Routes.API
{
    public class Settings
    {
        [ServerAPI.GET("/api/settings/v2/")]
        [ServerAPI.UseAuthorization]
        public List<SettingDTO> ReturnGetSettings(MongoDB.User user)
        {
            return user.OtherData.Settings;
        }

        [ServerAPI.POST("/api/settings/v2/set")]
        [ServerAPI.UseAuthorization]
        public async Task<IResult> ReturnSetSettings(HttpContext ctx, MongoDB.User user)
        {
            SettingDTO? incoming = await ctx.Request.GetJson<SettingDTO>();

            var updateResult = await MongoDB.usersCollection.UpdateOneAsync(
                u => u.AccountId == user.AccountId && u.OtherData.Settings.Any(s => s.Key == incoming.Key),
                Builders<MongoDB.User>.Update.Set("OtherData.Settings.$.Value", incoming.Value)
            );

            if (updateResult.MatchedCount == 0)
            {
                await MongoDB.usersCollection.UpdateOneAsync(
                    u => u.AccountId == user.AccountId,
                    Builders<MongoDB.User>.Update.Push("OtherData.Settings", incoming)
                );
            }

            return Results.Ok();
        }
    }
}