using Stella.Models;

namespace Stella.Routes.API
{
    public class GameConfigs
    {
        [ServerAPI.GET("/api/gameconfigs/v1/all")]
        public List<GameConfig> ReturnGameConfigs()
        {
            return [
                new GameConfig { Key = "VR.ForceVerification", Value = "1" },
                new GameConfig { Key = "Door.Creative.Title", Value = "PUZZLE" },
                new GameConfig { Key = "Door.Creative.Query", Value = "#puzzle" },
                new GameConfig { Key = "Door.Featured.Title", Value = "FEATURED" },
                new GameConfig { Key = "Door.Featured.Query", Value = "#featured" },
                new GameConfig { Key = "Door.Quests.Title", Value = "QUESTS" },
                new GameConfig { Key = "Door.Quests.Query", Value = "#rro #quest" },
                new GameConfig { Key = "Door.Shooters.Title", Value = "PVP" },
                new GameConfig { Key = "Door.Shooters.Query", Value = "#rro #pvp" },
                new GameConfig { Key = "Door.Sports.Title", Value = "Sports and Rec" },
                new GameConfig { Key = "Door.Sports.Query", Value = "#rro #sport" },
                new GameConfig { Key = "splitTestHardOverrides", Value = "" },
                new GameConfig { Key = "splitTestSoftOverrides", Value = "" }
            ];
        }
    }
}