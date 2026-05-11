using Stella.Models;

namespace Stella.Routes.API
{
    public class Config
    {
        [ServerAPI.GET("/api/config/v1/amplitude")]
        public dynamic Amplitude()
        {
            return new AmplitudeConfig
            {
                AmplitudeKey = "98b7a8604b19f3c703ddf09d3427fd0a"
            };
        }

        [ServerAPI.GET("/api/config/v2")]
        [ServerAPI.UseAuthorization]
        public dynamic ConfigV2()
        {
            var config = new ConfigDTO
            {
                ShareBaseUrl = "https://stellaonline.org/",
                LevelProgressionMaps = [],
                DailyObjectives = [
                    [
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        }
                    ],
                    [
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        }
                    ],
                    [
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        }
                    ],
                    [
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        }
                    ],
                    [
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        }
                    ],
                    [
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        }
                    ],
                    [
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        },
                        new OldObjectiveDTO
                        {
                            Type = ObjectiveType.StuntRunnerWins,
                            Score = 1,
                        }
                    ]
                ],
                AutoMicMutingConfig = new AutoMicMutingConfigDTO
                {
                    MicSpamVolumeThreshold = 0,
                    MicVolumeSampleInterval = 0,
                    MicVolumeSampleRollingWindowLength = 0,
                    MicSpamSamplePercentageForWarning = 0,
                    MicSpamSamplePercentageForWarningToEnd = 0,
                    MicSpamSamplePercentageForForceMute = 0,
                    MicSpamSamplePercentageForForceMuteToEnd = 0,
                    MicSpamWarningStateVolumeMultiplier = 0
                },
            };

            return config;
        }
    }
}
