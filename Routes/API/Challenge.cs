namespace Stella.Routes.API
{
    public class Challenge
    {
        [ServerAPI.GET("/api/challenge/v2/getCurrent")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnGetCurrentChallenges()
        {
            return new
            {
                ChallengeMapId = 0,
                StartAt = "2022-12-27T21:27:38.188Z",
                EndAt = "2028-12-27T21:27:38.188Z",
                ServerTime = DateTime.UtcNow,
                Challenges = Array.Empty<object>(),
                Gift = new
                {
                    EquipmentModificationGuid = "bc4254be-60e0-4cc5-a233-6a0bd4137118",
                    UnlockedLevel = 0,
                    Favorited = true,
                    GiftDropId = 1,
                    AvatarItemDesc = "",
                    Xp = 2,
                    Level = 0,
                    EquipmentPrefabName = "[PaintballGun]"
                },
                ChallengeThemeString = "PaintballGun"
            };
        }
    }
}