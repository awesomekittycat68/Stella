using Stella.Routes.API;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace Stella.Models
{
    public class UnlockedAvatarItem
    {
        public AvatarItemType AvatarItemType { get; set; }

        public string? AvatarItemDesc { get; set; }

        public string? FriendlyName { get; set; }

        public string? Tooltip { get; set; }

        public GiftRarity Rarity { get; set; }
    }

    public class AmplitudeConfig
    {
        public string? AmplitudeKey { get; set; }
    }

    public class AccountDTO
    {
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("profileImage")]
        public string? ProfileImage { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("isJunior")]
        public bool IsJunior { get; set; }

        [JsonPropertyName("platforms")] // ??? wtf did recroom name it platforms with a "s"
        public PlatformMask PlatformMask { get; set; }
    }

    public class ValueResponse : RecNetResult
    {
        [JsonPropertyName("value")]
        public object? Value { get; set; }
    }

    public class ConfigDTO
    {
        public string? MessageOfTheDay { get; set; }

        public string? CdnBaseUri { get; set; }

        public string? ShareBaseUrl { get; set; }

        public List<int>? LevelProgressionMaps { get; set; }

        public MatchmakingParamsDTO? MatchmakingParams { get; set; }

        public List<List<OldObjectiveDTO>>? DailyObjectives { get; set; }

        public AutoMicMutingConfigDTO? AutoMicMutingConfig { get; set; }

        public List<Dictionary<string, string>>? ConfigTable { get; set; }

        public Dictionary<string, object>? PhotonConfig { get; set; }
    }

    public class GameConfig
    {
        public string? Key { get; set; }

        public string? Value { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }
    }

    public class CommunityBoardAnnouncementDTO
    {
        public string? Message { get; set; }

        public string? MoreInfoUrl { get; set; }
    }

    public class CommunityBoardVideoData
    {
        public string? BlobName { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? ThumbnailBlobName { get; set; }

        public string? SourceUrl { get; set; }
    }

    public class AutoMicMutingConfigDTO
    {
        public float MicSpamVolumeThreshold { get; set; } = 0.75f;

        public float MicVolumeSampleInterval { get; set; } = 0.25f;

        public float MicVolumeSampleRollingWindowLength { get; set; } = 10f;

        public float MicSpamSamplePercentageForWarning { get; set; } = 0.8f;

        public float MicSpamSamplePercentageForWarningToEnd { get; set; } = 0.2f;

        public float MicSpamSamplePercentageForForceMute { get; set; } = 0.8f;

        public float MicSpamSamplePercentageForForceMuteToEnd { get; set; } = 0.2f;

        public float MicSpamWarningStateVolumeMultiplier { get; set; } = 0.25f;
    }

    public class AvatarDTO
    {
        public string? OutfitSelections { get; set; }

        public string? FaceFeatures { get; set; }

        public string? SkinColor { get; set; }

        public string? HairColor { get; set; }
    }

    public class CachedLoginDTO
    {
        [JsonPropertyName("platform")]
        public PlatformType Platform { get; set; }

        [JsonPropertyName("platformId")]
        public ulong PlatformId { get; set; }

        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        [JsonPropertyName("lastLoginTime")]
        public DateTime LastLoginTime { get; set; }

        [JsonPropertyName("requirePassword")]
        public bool RequirePassword { get; set; }

        [JsonPropertyName("account")]
        public AccountDTO? Account { get; set; }
    }

    public class BioDTO
    {
        [JsonPropertyName("accountId")]
        public long AccountId { get; set; }

        [JsonPropertyName("bio")]
        public string? Bio { get; set; }
    }

    public class CommunityBoardFeaturedPlayerData
    {
        public int Id { get; set; }

        public string? TitleOverride { get; set; }

        public string? UrlOverride { get; set; }
    }

    public class CommunityBoardDTO
    {
        public CommunityBoardFeaturedPlayerData? FeaturedPlayer { get; set; }

        public FeaturedRoomGroupDTO? FeaturedRoomGroup { get; set; }

        public CommunityBoardAnnouncementDTO? CurrentAnnouncement { get; set; }

        public List<InstagramImageDTO>? InstagramImages { get; set; }

        public List<CommunityBoardVideoData>? Videos { get; set; }
    }

    public class AnnouncementDTO
    {
        public long AnnouncementId { get; set; }

        public AnnouncementType AnnouncementType { get; set; }

        public string? Title { get; set; }

        public string? Body { get; set; }

        public string? ImageName { get; set; }

        public AnnouncementLinkType LinkType { get; set; }

        public string? LinkName { get; set; }

        public string? LinkUri { get; set; }

        public PlatformType Platform { get; set; }

        public DateTime CreatedAt { get; set; }

        public AnnouncementStatus AnnouncementStatus { get; set; } = (AnnouncementStatus)((ulong)1L);
    }

    public class LoginResponseDTO
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }

        [JsonPropertyName("error_description")]
        public string? ErrorDescription { get; set; }

        [JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }
    }

    public class LocalPlayerEventInfo
    {
        public List<PlayerEvent>? Created { get; set; }

        public List<PlayerEventInformation>? Responses { get; set; }
    }

    public class InstagramImageDTO
    {
        public string? ImageName { get; set; }

        public string? ImageUrl { get; set; }
    }

    public class SavedImageMetaDTO
    {
        public List<int>? playerIds { get; set; }

        public SavedImageType savedImageType { get; set; }

        public long? roomId { get; set; }

        public long? playerEventId { get; set; }

        public Accessibility accessibility { get; set; }
    }

    public class ImageNameDTO
    {
        public string? ImageName { get; set; }
    }

    public class FeaturedRoomGroupDTO
    {
        public string? Name { get; set; }

        public List<FeaturedRoom>? FeaturedRooms { get; set; }
    }

    public class FeaturedRoom
    {
        public string? RoomName { get; set; }

        public long RoomId { get; set; }

        public string? ImageName { get; set; }
    }

    public class OldObjectiveDTO
    {
        [JsonPropertyName("type")]
        public ObjectiveType Type { get; set; } = ObjectiveType.Default;

        [JsonPropertyName("score")]
        public int Score { get; set; }
    }

    public class ObjectiveDTO
    {
        public ObjectiveType ObjectiveType { get; set; } = ObjectiveType.Default;

        public int RequiredScore { get; set; }
    }

    public class NamedImageDTO
    {
        public string? FriendlyImageName { get; set; }

        public string? ImageName { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }

    public class ModerationBlockDetailDTO
    {
        public ReportCategory ReportCategory { get; set; }

        public int Duration { get; set; }

        public long GameSessionId { get; set; }

        public bool IsHostKick { get; set; }

        public string? Message { get; set; }

        public int? PlayerIdReporter { get; set; }

        public bool IsBan { get; set; }
    }

    public class MatchmakingResponseDTO
    {
        [JsonPropertyName("errorCode")]
        public MatchmakingErrorCode ErrorCode { get; set; }

        [JsonPropertyName("roomInstance")]
        public RoomInstance? RoomInstance { get; set; }
    }

    public class MatchmakingParamsDTO
    {
        public int PreferFullRoomsFrequency { get; set; }

        public int PreferEmptyRoomsFrequency { get; set; }
    }

    public class ServerMaintenanceDTO
    {
        public int StartsInMinutes { get; set; }
    }

    public class SubscriptionDTO
    {
        [JsonPropertyName("subscriptionId")]
        public long SubscriptionId { get; set; }

        [JsonPropertyName("recNetPlayerId")]
        public int RecNetPlayerId { get; set; }

        [JsonPropertyName("platformType")]
        public PlatformType? PlatformType { get; set; }

        [JsonPropertyName("platformId")]
        public string? PlatformId { get; set; }

        [JsonPropertyName("platformPurchaseId")]
        public string? PlatformPurchaseId { get; set; }

        [JsonPropertyName("level")]
        public SubscriptionLevel Level { get; set; }

        [JsonPropertyName("period")]
        public SubscriptionPeriod Period { get; set; }

        [JsonPropertyName("expirationDate")]
        public DateTime ExpirationDate { get; set; }

        [JsonPropertyName("isAutoRenewing")]
        public bool IsAutoRenewing { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("modifiedAt")]
        public DateTime ModifiedAt { get; set; }
    }

    public class SingleLeaderboard
    {
        [JsonPropertyName("rows")]
        public List<LeaderboardEntry>? Rows { get; set; }
    }

    public class LeaderboardEntry
    {
        [JsonPropertyName("playerId")]
        public int PlayerId { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }
    }

    public class SubscriptionInfoDTO
    {
        [JsonPropertyName("subscription")]
        public SubscriptionDTO? Subscription { get; set; }

        [JsonPropertyName("platformAccountSubscribedPlayerId")]
        public int? PlatformAccountSubscribedPlayerId { get; set; }
    }

    public class TagDTO
    {
        public string? Tag { get; set; }

        public TagType Type { get; set; }
    }

    public class VersionCheckV4ResponseDTO
    {
        public VersionStatus VersionStatus { get; set; } = VersionStatus.ValidForMenu;
    }

    public class VersionCheckV3ResponseDTO
    {
        public bool ValidVersion { get; set; } = true;
    }

    public class VersionCheckV2ResponseDTO
    {
        public bool ValidVersion { get; set; } = true;
    }

    public class RoomInstance
    {
        [JsonPropertyName("roomInstanceId")]
        public long RoomInstanceId { get; set; }

        [JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        [JsonPropertyName("subRoomId")]
        public long SubRoomId { get; set; }

        [JsonPropertyName("location")]
        public string? Location { get; set; }

        [JsonPropertyName("dataBlob")]
        public string? DataBlob { get; set; }

        [JsonPropertyName("photonRegionId")]
        public string? PhotonRegionId { get; set; }

        [JsonPropertyName("photonRoomId")]
        public string? PhotonRoomId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("maxCapacity")]
        public int MaxCapacity { get; set; }

        [JsonPropertyName("isFull")]
        public bool IsFull { get; set; }

        [JsonPropertyName("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonPropertyName("isInProgress")]
        public bool IsInProgress { get; set; }
    }

    public class PlayerEvent
    {
        public long PlayerEventId { get; set; }

        public int CreatorPlayerId { get; set; }

        public long RoomId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int AttendeeCount { get; set; }

        public string? ImageName { get; set; }

        public Accessibility Accessibility { get; set; }
    }

    public class ParentalControl
    {
        public long? AccountId { get; set; }

        public bool? DisallowInAppPurchase { get; set; }
    }

    public class PlayerQuickPlayDTO
    {
        public long? TargetPlayerId { get; set; }

        public string? RoomName { get; set; }
    }

    public class PlayerPresence
    {
        [JsonPropertyName("playerId")]
        public long PlayerId { get; set; }

        [JsonPropertyName("statusVisibility")]
        public PlayerStatusVisibility StatusVisibility { get; set; }

        [JsonPropertyName("deviceClass")]
        public DeviceClass DeviceClass { get; set; }

        [JsonPropertyName("vrMovementMode")]
        public VRMovementMode VRMovementMode { get; set; }

        [JsonPropertyName("roomInstance")]
        public RoomInstance? RoomInstance { get; set; }

        [JsonPropertyName("isOnline")]
        public bool IsOnline { get; set; }

        [JsonPropertyName("appVersion")]
        public string? AppVersion { get; set; }
    }

    public class PlayerEventResponse
    {
        public long PlayerEventResponseId { get; set; }

        public long PlayerEventId { get; set; }

        public int PlayerId { get; set; }

        public DateTime CreatedAt { get; set; }

        public PlayerEventResponseType Type { get; set; }
    }

    public class PlayerEventInformation
    {
        public PlayerEvent? PlayerEvent { get; set; }

        public PlayerEventResponse? PlayerEventResponse { get; set; }
    }

    public class RefreshLoginResponseDTO
    {
        [JsonPropertyName("token")]
        public string? Token { get; set; }
    }

    public class ReputationDTO
    {
        public int AccountId { get; set; }

        public float Notoriety { get; set; }

        public CheerCategory? SelectedCheer { get; set; }

        public int CheerCredit { get; set; }

        public float Noteriety { get; set; }

        public int CheerGeneral { get; set; }

        public int CheerHelpful { get; set; }

        public int CheerCreative { get; set; }

        public int CheerGreatHost { get; set; }

        public int CheerSportsman { get; set; }

        public int SubscriberCount { get; set; }

        public int SubscribedCount { get; set; }
    }

    public class RoomDetailsDTO
    {
        public string? Id { get; set; }

        public RoomDTO? Room { get; set; }

        public List<SceneDTO>? Scenes { get; set; }

        public List<int>? CoOwners { get; set; }

        public List<int>? InvitedCoOwners { get; set; }

        public List<int>? Moderators { get; set; }

        public List<int>? InvitedModerators { get; set; }

        public List<int>? Hosts { get; set; }

        public List<int>? InvitedHosts { get; set; }

        public int CheerCount { get; set; }

        public int FavoriteCount { get; set; }

        public int VisitCount { get; set; }

        public List<TagDTO>? Tags { get; set; }
    }

    public class SceneDTO
    {
        public int? RoomSceneId { get; set; }

        public long RoomId { get; set; }

        public string? RoomSceneLocationId { get; set; }

        public string? Name { get; set; }

        public bool IsSandbox { get; set; }

        public string? DataBlobName { get; set; }

        public int MaxPlayers { get; set; }

        public bool CanMatchmakeInto { get; set; }

        public DateTime DataModifiedAt { get; set; }
    }

    public class RoomDTO
    {
        public long RoomId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImageName { get; set; }

        public long CreatorPlayerId { get; set; }

        public RoomState State { get; set; }

        public Accessibility Accessibility { get; set; }

        public bool SupportsLevelVoting { get; set; }

        public bool IsAGRoom { get; set; }

        public bool IsDormRoom { get; set; }

        public bool CloningAllowed { get; set; }

        public bool SupportsVRLow { get; set; }

        public bool SupportsMobile { get; set; }

        public bool SupportsScreens { get; set; }

        public bool SupportsWalkVR { get; set; }

        public bool SupportsTeleportVR { get; set; }

        public bool AllowsJuniors { get; set; }

        public RoomWarningMask WarningMask { get; set; }

        public RoomWarningMask RoomWarningMask { get; set; }

        public string? CustomRoomWarning { get; set; }

        public bool DisableMicAutoMute { get; set; }
    }

    public class ProgressionDTO
    {
        [JsonPropertyName("PlayerId")]
        public int AccountId { get; set; }

        public int Level { get; set; }

        public int XP { get; set; }
    }

    public class RawObjectiveDTO
    {
        public int Type { get; set; }

        public int Score { get; set; }

        public int XP { get; set; }
    }

    public class RecNetResult
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }

    public class ReferralDTO
    {
        [JsonPropertyName("info")]
        public string? Info;

        [JsonPropertyName("referrerId")]
        public int ReferrerId;
    }

    public class SettingDTO
    {
        public string? Key { get; set; }

        public string? Value { get; set; }
    }


    public class RoomOrPlaylist
    {
        public long RoomOrPlaylistId { get; set; }

        public RoomOrPlaylistType Type { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ImageName { get; set; }

        public long CreatorPlayerId { get; set; }

        public RoomState State { get; set; }

        public Accessibility Accessibility { get; set; }

        public bool SupportsLevelVoting { get; set; }

        public bool IsAGRoom { get; set; }

        public bool IsDormRoom { get; set; }

        public bool CloningAllowed { get; set; }

        public bool SupportsVRLow { get; set; }

        public bool SupportsMobile { get; set; }

        public bool SupportsScreens { get; set; }

        public bool SupportsWalkVR { get; set; }

        public bool SupportsTeleportVR { get; set; }

        public bool AllowsJuniors { get; set; }

        public RoomWarningMask RoomWarningMask { get; set; }

        public string? CustomRoomWarning { get; set; }

        public bool DisableMicAutoMute { get; set; }
    }

    public class RoomRolePermissionValidationDTO
    {
        [JsonPropertyName("roomId")]
        public long RoomId = -1;

        [JsonPropertyName("creatorPlayerRole")]
        public int CreatorPlayerRole;

        [JsonPropertyName("creatorPlayerCoOwnerRoomPermission")]
        public RoomPermissionValue CreatorPlayerCoOwnerRoomPermission;

        [JsonPropertyName("creatorPlayerModeratorRoomPermission")]
        public RoomPermissionValue CreatorPlayerModeratorRoomPermission;

        [JsonPropertyName("creatorPlayerHostRoomPermission")]
        public RoomPermissionValue CreatorPlayerHostRoomPermission;

        [JsonPropertyName("context")]
        public string? Context;
    }

    public class NameServerResponse
    {
        public string? Auth { get; set; }

        public string? API { get; set; }

        public string? WWW { get; set; }

        public string? Notifications { get; set; }

        public string? Images { get; set; }

        public string? CDN { get; set; }

        public string? Commerce { get; set; }

        public string? Matchmaking { get; set; }

        public string? Storage { get; set; }

        public string? Chat { get; set; }

        public string? Leaderboard { get; set; }

        public string? Accounts { get; set; }

        public string? Link { get; set; }

        public string? RoomComments { get; set; }

        public string? Clubs { get; set; }

        public string? Rooms { get; set; }

        public string? PlatformNotifications { get; set; }

        public string? Moderation { get; set; }

        public string? DataCollection { get; set; }
    }

    public class LoginResponse
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }

        [JsonPropertyName("error_description")]
        public string? ErrorDescription { get; set; }

        [JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }
    }

    public class RelationshipDTO
    {
        public long PlayerID { get; set; }

        public RelationshipType RelationshipType { get; set; }

        public ReciprocalStatus Muted { get; set; }

        public ReciprocalStatus Ignored { get; set; }

        public ReciprocalStatus Favorited { get; set; }

        public bool IsFriend { get; set; }

        public bool IsFavorited { get; set; }

        public bool IsFriendOrPendingFriend { get; set; }

        public bool IsBlocked { get; set; }
    }
}