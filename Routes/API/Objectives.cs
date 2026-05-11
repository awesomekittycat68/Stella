namespace Stella.Routes.API
{
    public class Objectives
    {
        [ServerAPI.GET("/api/objectives/v1/myprogress")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnGetObjectivesProgress()
        {
            return new
            {
                Objectives = new[]
                {
                    new { Index = 2, Group = 0, Progress = 0, VisualProgress = 0, IsCompleted = false, IsRewarded = false, HasClaimedReward = false },
                    new { Index = 1, Group = 0, Progress = 0, VisualProgress = 0, IsCompleted = false, IsRewarded = false, HasClaimedReward = false },
                    new { Index = 0, Group = 0, Progress = 0, VisualProgress = 0, IsCompleted = false, IsRewarded = false, HasClaimedReward = false },
                    new { Index = 6, Group = 2, Progress = 0, VisualProgress = 0, IsCompleted = false, IsRewarded = false, HasClaimedReward = false }
                },
                ObjectiveGroups = new[]
                {
                    new { Group = 0, IsCompleted = false, ClearedAt = "2025-11-08T00:00:00Z" },
                    new { Group = 2, IsCompleted = false, ClearedAt = "2025-11-08T00:00:00Z" }
                }
            };
        }
    }
}