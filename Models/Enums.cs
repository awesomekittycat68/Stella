namespace Stella.Models
{
    public enum DeviceClass
    {
        Unknown,
        VR,
        Screen,
        Mobile,
        VRLow
    }

    public enum GiftRarity
    {
        None = -1,
        Common,
        Uncommon = 10,
        Rare = 20,
        Epic = 30,
        Legendary = 50
    }

    public enum AvatarItemType
    {
        Outfit,
        HairDye
    }

    public enum CheerCategory
    {
        General = 0,
        Helpful = 10,
        Sportmanship = 20,
        GreatHost = 30,
        Creative = 40
    }

    public enum FileType
    {
        Unknown,
        RoomSave,
        Holotar,
        Image,
        Video,
        Invention
    }

    public enum SavedImageType
    {
        None,
        ShareCamera,
        OutfitThumbnail,
        RoomThumbnail,
        ProfileThumbnail,
        InventionThumbnail
    }

    public enum Accessibility
    {
        Private,
        Public,
        Unlisted
    }

    public enum AnnouncementType
    {
        Update,
        Contest,
        Store,
        Event,
        Warning
    }

    public enum AnnouncementStatus
    {
        Read,
        Unread
    }

    public enum AnnouncementLinkType
    {
        Url,
        AccountId,
        EventId,
        RoomName,
        Storefront
    }

    public enum PushNotificationId
    {
        RelationshipChanged = 1,
        MessageReceived,
        MessageDeleted,
        PresenceHeartbeatResponse,
        RefreshLogin,
        Logout,
        SubscriptionUpdateProfile = 11,
        SubscriptionUpdatePresence,
        SubscriptionUpdateGameSession,
        SubscriptionUpdateRoom = 15,
        SubscriptionUpdateRoomPlaylist,
        ModerationQuitGame = 20,
        ModerationUpdateRequired,
        ModerationKick,
        ModerationKickAttemptFailed,
        ModerationRoomBan,
        ServerMaintenance,
        GiftPackageReceived = 30, // recive gift pacakage on switch rooms 
        GiftPackageReceivedImmediate, // recive gift pacakage NOW 
        ProfileJuniorStatusUpdate = 40,
        RelationshipsInvalid = 50,
        StorefrontBalanceAdd = 60,
        StorefrontBalanceUpdate,
        StorefrontBalancePurchase,
        ConsumableMappingAdded = 70,
        ConsumableMappingRemoved,
        PlayerEventCreated = 80,
        PlayerEventUpdated,
        PlayerEventDeleted,
        PlayerEventResponseChanged,
        PlayerEventResponseDeleted,
        PlayerEventStateChanged,
        ChatMessageReceived = 90,
        CommunityBoardUpdate = 95,
        CommunityBoardAnnouncementUpdate,
        InventionModerationStateChanged = 100
    }

    public enum RoomState
    {
        Active = 0,
        PendingJunior = 11,
        Moderation_PendingReview = 100,
        Moderation_Closed = 101,
        MarkedForDelete = 1000
    }

    public enum PlatformType
    {
        All = -1,
        Steam,
        Oculus,
        PlayStation,
        Microsoft,
        HeadlessBot,
        IOS
    }

    public enum PlatformMask
    {
        All = -1,
        None = 0,
        Steam = 1,
        Oculus = 2,
        PlayStation = 4,
        Microsoft = 8,
        HeadlessBot = 16,
        IOS = 32
    }

    public enum ObjectiveType
    {
        Default = -1,
        FirstSessionOfDay = 1,
        AddAFriend,
        PartyUp,
        AllOtherChallenges,
        LevelUp,
        CheerAPlayer,
        PointedAtPlayer,
        CheerARoom,
        SubscribeToPlayer,
        DailyObjective1,
        DailyObjective2,
        DailyObjective3,
        AllDailyObjectives,
        CompleteAnyDaily,
        CompleteAnyWeekly,
        OOBE_GoToLockerRoom = 20,
        OOBE_GoToActivity,
        OOBE_FinishActivity,
        NUX_PunchcardObjective = 25,
        NUX_AllPunchcardObjectives,
        GoToRecCenter = 30,
        FinishActivity,
        VisitACustomRoom,
        CreateACustomRoom,
        ScoreBasketInRecCenter = 35,
        UploadPhotoToRecNet,
        UpdatePlayerBio,
        SaveOutfitSlot,
        PurchaseClothingItem,
        PurchaseNonClothingItem,
        CharadesGames = 100,
        CharadesWinsPerformer,
        CharadesWinsGuesser,
        DiscGolfWins = 200,
        DiscGolfGames,
        DiscGolfHolesUnderPar,
        DodgeballWins = 300,
        DodgeballGames,
        DodgeballHits,
        PaddleballGames = 400,
        PaddleballWins,
        PaddleballScores,
        PaintballAnyModeGames = 500,
        PaintballAnyModeWins,
        PaintballAnyModeHits,
        PaintballCTFWins = 600,
        PaintballCTFGames,
        PaintballCTFHits,
        PaintballFlagCaptures,
        PaintballTeamBattleWins = 700,
        PaintballTeamBattleGames,
        PaintballTeamBattleHits,
        PaintballFreeForAllWins = 710,
        PaintballFreeForAllGames,
        PaintballFreeForAllHits,
        SoccerWins = 800,
        SoccerGames,
        SoccerGoals,
        BowlingGames = 900,
        BowlingWins,
        BowlingStrike,
        QuestGames = 1000,
        QuestWins,
        QuestPlayerRevives,
        QuestEnemyKills,
        QuestGames_Goblin1 = 1010,
        QuestWins_Goblin1,
        QuestPlayerRevives_Goblin1,
        QuestEnemyKills_Goblin1,
        QuestGames_Goblin2 = 1020,
        QuestWins_Goblin2,
        QuestPlayerRevives_Goblin2,
        QuestEnemyKills_Goblin2,
        QuestGames_Scifi1 = 1030,
        QuestWins_Scifi1,
        QuestPlayerRevives_Scifi1,
        QuestEnemyKills_Scifi1,
        QuestGames_Pirate1 = 1040,
        QuestWins_Pirate1,
        QuestPlayerRevives_Pirate1,
        QuestEnemyKills_Pirate1,
        QuestGames_Dracula1 = 1050,
        QuestWins_Dracula1,
        QuestPlayerRevives_Dracula1,
        QuestEnemyKills_Dracula1,
        ArenaGames = 2000,
        ArenaWins,
        ArenaPlayerRevives,
        ArenaHeroTags,
        ArenaBotTags,
        RecRoyaleGames = 3000,
        RecRoyaleWins,
        RecRoyaleTags,
        StuntRunnerGames = 4000,
        StuntRunnerWins
    }

    public enum TagType
    {
        General,
        Auto,
        AGOnly,
        Banned
    }

    public enum VersionStatus
    {
        ValidForPlay,
        ValidForMenu,
        UpdateRequired
    }

    public enum VRMovementMode
    {
        TELEPORT,
        WALK
    }

    public enum ReportCategory
    {
        Moderator = -1,
        Unknown,
        DEPRECATED_MicrophoneAbuse,
        Harassment,
        Cheating,
        DEPRECATED_ImmatureBehavior,
        AFK,
        Misc,
        Underage,
        VoteKick = 10,
        CoC_Underage = 100,
        CoC_Sexual,
        CoC_Discrimination,
        CoC_Trolling,
        CoC_NameOrProfile,
        IssuingInaccurateReports = 1000
    }

    public enum PlayerEventResponseType
    {
        None = -1,
        Yes,
        Interested,
        No,
        Pending
    }

    public enum MatchmakingErrorCode
    {
        Success,
        NoSuchGame,
        PlayerNotOnline,
        InsufficientSpace,
        EventNotStarted,
        EventAlreadyFinished,
        EventCreatorNotReady,
        BlockedFromRoom,
        ProfileLocked,
        NoBirthday,
        MarkedForDelete,
        JuniorNotAllowed,
        Banned,
        AlreadyInBestInstance,
        InsufficientRelationship,
        UpdateRequired = 16,
        AlreadyInTargetInstance,
        RegistrationRequired,
        UGCNotAllowed,
        NoSuchRoom,
        RoomCreatorNotReady,
        RoomIsNotActive,
        RoomBlockedByCreator,
        RoomBlockingCreator,
        RoomIsPrivate,
        RoomInstanceIsPrivate,
        DeviceClassNotSupported = 30,
        DeviceClassNotSupportedByRoomOwner,
        VRMovementModeNotSupportedByRoomOwner,
        EventIsPrivate = 35,
        RoomInviteExpired = 40,
        NoAvailableRegion = 45,
        NotorietyTooPoor = 50,
        BannedFromRoom = 55,
        NoSuchRoomPlaylist = 60,
        RoomPlaylistIsNotActive,
        RoomPlaylistIsPrivate
    }

    public enum SubscriptionPeriod
    {
        Month,
        Year
    }

    public enum SubscriptionLevel
    {
        Gold,
        Platinum
    }

    public enum RoomWarningMask
    {
        None = 0,
        Scary = 1,
        Mature = 2,
        FlashingLights = 4,
        IntenseMotion = 8,
        Violence = 16,
        Custom = 32
    }

    public enum PlayerStatusVisibility
    {
        Public,
        FriendsOnly,
        FavoriteFriendsOnly,
        Offline
    }

    public enum RoomOrPlaylistType
    {
        Room,
        Playlist
    }

    public enum RoomPermissionValue
    {
        False,
        True,
        Invited
    }

    public enum RelationshipType
    {
        None,
        FriendRequestSent,
        FriendRequestReceived,
        Friend
    }

    public enum ReciprocalStatus
    {
        None,
        Local,
        Remote,
        Mutual
    }
}