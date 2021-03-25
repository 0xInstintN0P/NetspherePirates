﻿namespace Netsphere.Network
{
    public enum AuthOpCode : ushort
    {
        CAuthInReq = 5001,
        CAuthInEuReq = 5002,
        CServerListReq = 5003,

        SAuthInAck = 5101,
        SAuthInEuAck = 5102,
        SServerListAck = 5103
    }

    public enum ChatOpCode : ushort
    {
        CLoginReq = 15001,
        CDenyChatReq = 15002,
        CFriendReq = 15003,
        CCheckCombiNameReq = 15004,
        CCombiReq = 15005,
        CGetUserDataReq = 15006,
        CSetUserDataReq = 15007,
        CChatMessageReq = 15008,
        CWhisperChatMessageReq = 15009,
        CInvitationPlayerReq = 15010,
        CNoteListReq = 15011,
        CSendNoteReq = 15012,
        CReadNoteReq = 15013,
        CDeleteNoteReq = 15014,
        CNoteReminderInfoReq = 15015,

        SLoginAck = 16001,
        SFriendAck = 16002,
        SFriendListAck = 16003,
        SCombiAck = 16004,
        SCombiListAck = 16005,
        SCheckCombiNameAck = 16006,
        SDenyChatAck = 16007,
        SDenyChatListAck = 16008,
        SUserDataAck = 16009,
        SUserDataListAck = 16010,
        SChannelPlayerListAck = 16011,
        SChannelEnterPlayerAck = 16012,
        SChannelLeavePlayerAck = 16013,
        SChatMessageAck = 16014,
        SWhisperChatMessageAck = 16015,
        SInvitationPlayerAck = 16016,
        SClanMemberListAck = 16017,
        SNoteListAck = 16018,
        SSendNoteAck = 16019,
        SReadNoteAck = 16020,
        SDeleteNoteAck = 16021,
        SNoteErrorAck = 16022,
        SNoteReminderInfoAck = 16023
    }

    public enum GameOpCode : ushort
    {
        #region GameServerC2S

        CCreateCharacterReq = 50001,
        CSelectCharacterReq = 50002,
        CDeleteCharacterReq = 50003,
        CLoginReq = 50004,
        CQuickStartReq = 50005,
        CMakeRoomReq = 50006,
        CCreateNickReq = 50007,
        CCheckNickReq = 50008,
        CUseItemReq = 50009,
        CJoinTunnelInfoReq = 50010,
        CTimeSyncReq = 50011,
        CGameArgPingReq = 50012,
        CAdminShowWindowReq = 50013,
        CClubInfoReq = 50014,
        CIngameEquipCheckReq = 50015,
        CUseCoinRandomShopChanceReq = 50016,
        CChannelEnterReq = 50017,
        CChannelLeaveReq = 50018,
        CGetChannelInfoReq = 50019,
        CGameRoomEnterReq = 50020,
        CGetPlayerInfoReq = 50021,
        CBuyItemReq = 50022,
        CRepairItemReq = 50023,
        CRefundItemReq = 50024,
        CAdminActionReq = 50025,
        CGameGuardAuthReq = 50026,
        CHShieldMakeResponseReq = 50027,
        CActiveEquipPresetReq = 50028,
        CLicensedReq = 50029,
        CClubNoticeChangeReq = 50030,
        CGetClubInfoReq = 50031,
        CGetClubInfoByNameReq = 50032,
        CGetInventoryItemReq = 50033,
        CTaskNotifyReq = 50034,
        CTaskRequestReq = 50035,
        CRandomShopRollingStartReq = 50036,
        CRandomShopItemGetReq = 50037,
        CRandomShopItemSaleReq = 50038,
        CExerciseLicenceReq = 50039,
        CUseCoinReq = 50040,
        CApplyEsperChipItemReq = 50041,
        CBadUserReq = 50042,
        CClubJoinReq = 50043,
        CClubUnJoinReq = 50044,
        CNewShopUpdateCheckReq = 50045,
        CUseChangeNickNameItemReq = 50046,
        CUseResetRecordItemReq = 50047,
        CUseCoinFillingItemReq = 50048,
        CGetUserInfoListReq = 50049,
        CFindUserReq = 50050,
        CDiscardItemReq = 50051,
        CUseCapsuleReq = 50052,
        CSaveConfigPermissionNotifyReq = 50053,
        CClubAddressReq = 50054,
        CSmallLoudSpeakerReq = 50055,
        CClubHistoryReq = 50056,
        CChangeNickCancelReq = 50057,
        CEnableAccountStatusAck = 50058,

        #endregion

        #region GameServerS2C

        SLoginAck = 60001,
        SBeginAccountInfoAck = 60002,
        SOpenCharacterInfoAck = 60003,
        SCharacterEquipInfoAck = 60004,
        SInventoryInfoAck = 60005,
        SSuccessDeleteCharacterAck = 60006,
        SSuccessSelectCharacterAck = 60007,
        SSuccessCreateCharacterAck = 60008,
        SServerResultInfoAck = 60009,
        SCreateNickAck = 60010,
        SCheckNickAck = 60011,
        SUseItemAck = 60012,
        SInventoryActionAck = 60013,
        SIdsInfoAck = 60014,
        SEnteredPlayerAck = 60015,
        SEnteredPlayerClubInfoAck = 60016,
        SEnteredPlayerListAck = 60017,
        SEnteredPlayerClubInfoListAck = 60018,
        SSuccessEnterRoomAck = 60019,
        SLeavePlayerAck = 60020,
        SJoinTunnelPlayerAck = 60021,
        STimeSyncAck = 60022,
        SPlayTogetherSignAck = 60023,
        SPlayTogetherInfoAck = 60024,
        SPlayTogetherSignInfoAck = 60025,
        SPlayTogetherCancelAck = 60026,
        SChangeGameRoomAck = 60027,
        SNewShopUpdateRequestAck = 60028,
        SLogoutAck = 60029,
        SPlayTogetherKickAck = 60030,
        SChannelListInfoAck = 60031,
        SChannelDeployPlayerAck = 60032,
        SChannelDisposePlayerAck = 60033,
        SGameRoomListAck = 60034,
        SDeployGameRoomAck = 60035,
        SDisposeGameRoomAck = 60036,
        SGamePingAverageAck = 60037,
        SGetPlayerInfoAck = 60038, // ToDo
        SBuyItemAck = 60039,
        SRepairItemAck = 60040,
        SItemDurabilityInfoAck = 60041,
        SRefundItemAck = 60042,
        SRefreshCashInfoAck = 60043,
        SAdminActionAck = 60044,
        SAdminShowWindowAck = 60045,
        SNoticeMessageAck = 60046,
        SCharacterSlotInfoAck = 60047,
        SGameGuardAuthAck = 60048,
        SHShieldMakeResponseAck = 60049,
        SRefreshInvalidEquipItemAck = 60050,
        SClearInvalidateItemAck = 60051,
        SRefreshItemTimeInfoAck = 60052,
        SActiveEquipPresetAck = 60054,
        SMyLicenseInfoAck = 60055,
        SLicensedAck = 60056,
        SCoinEventAck = 60057,
        SCombiCompensationAck = 60058,
        SClubInfoAck = 60059,
        SClubHistoryAck = 60060,
        SEquipedBoostItemAck = 60061,
        SGetClubInfoAck = 60062,
        STaskInfoAck = 60063,
        STaskUpdateAck = 60064,
        STaskRequestAck = 60065,
        SExchangeItemAck = 60066,
        STaskIngameUpdateAck = 60067,
        STaskRemoveAck = 60068,
        SRandomShopChanceInfoAck = 60069,
        SRandomShopItemInfoAck = 60070,
        SRandomShopInfoAck = 60071,
        SSetCoinAck = 60072,
        SApplyEsperChipItemAck = 60073,
        SArcadeRewardInfoAck = 60074,
        SArcadeMapScoreAck = 60075,
        SArcadeStageScoreAck = 60076,
        SMixedTeamBriefingInfoAck = 60077,
        SSetGameMoneyAck = 60078,
        SUseCapsuleAck = 60079,
        SHGWKickAck = 60080,
        SClubJoinAck = 60081,
        SClubUnJoinAck = 60082,
        SNewShopUpdateCheckAck = 60083,
        SNewShopUpdateInfoAck = 60084,
        SUseChangeNickItemAck = 60085,
        SUseResetRecordItemAck = 60086,
        SUseCoinFillingItemAck = 60087,
        SFindUserAck = 60088, // ToDo
        SDiscardItemAck = 60089,
        SDeleteItemInventoryAck = 60090,
        SClubAddressAck = 60091,
        SSmallLoudSpeakerAck = 60092,
        SIngameEquipCheckAck = 60093,
        SUseCoinRandomShopChanceAck = 60094,
        SChangeNickCancelAck = 60095,
        SEventRewardAck = 60096

        #endregion
    }

    public enum GameRuleOpCode : ushort
    {
        #region C2S

        CEnterPlayerReq = 20001,
        CLeavePlayerRequestReq = 20002,
        CChangeTeamReq = 20003,
        CAutoAssingTeamReq = 20004,
        CAutoMixingTeamReq = 20005,
        CMixChangeTeamReq = 20006,
        CEventMessageReq = 20007,
        CReadyRoundReq = 20008,
        CBeginRoundReq = 20009,
        CAvatarDurabilityDecreaseReq = 20010,
        CAvatarChangeReq = 20011,
        CChangeRuleNotifyReq = 20012,
        CMissionScoreReq = 20013,
        CScoreKillReq = 20014,
        CScoreKillAssistReq = 20015,
        CScoreOffenseReq = 20016,
        CScoreOffenseAssistReq = 20017,
        CScoreDefenseReq = 20018,
        CScoreDefenseAssistReq = 20019,
        CScoreHealAssistReq = 20020,
        CScoreGoalReq = 20021,
        CScoreReboundReq = 20022,
        CScoreSuicideReq = 20023,
        CScoreTeamKillReq = 20024,
        CItemsChangeReq = 20025,
        CPlayerGameModeChangeReq = 20026,
        CArcadeAttackPointReq = 20027,
        CArcadeScoreSyncReq = 20028,
        CArcadeBeginRoundReq = 20029,
        CArcadeStageClearReq = 20030,
        CArcadeStageFailedReq = 20031,
        CArcadeStageInfoReq = 20032,
        CArcadeEnablePlayTimeReq = 20033,
        CArcadeRespawnReq = 20034,
        CArcadeStageReadyReq = 20035,
        CArcadeStageSelectReq = 20036,
        CSlaughterAttackPointReq = 20037,
        CSlaughterHealPointReq = 20038,
        CArcadeLoadingSucceesReq = 20039,
        CUseCoinReq = 20040,
        CBeginResponeReq = 20041,
        CWeaponFireReq = 20042,
        CCompulsionLeaveRequestReq = 20043,
        CCompulsionLeaveVoteReq = 20044,

        #endregion

        #region S2C

        SEnterPlayerAck = 21001,
        SLeavePlayerAck = 21002,
        SLeavePlayerRequestAck = 21003,
        SChangeTeamAck = 21004,
        SChangeTeamFailAck = 21005,
        SMixChangeTeamAck = 21006,
        SMixChangeTeamFailAck = 21007,
        SAutoAssignTeamAck = 21008,
        SEventMessageAck = 21009,
        SBriefingAck = 21010,
        SChangeStateAck = 21011,
        SChangeSubStateAck = 21012,
        SDestroyGameRuleAck = 21013,
        SChangeMasterAck = 21014,
        SChangeRefeReeAck = 21015,
        SChangeTheFirstAck = 21016,
        SChangeSlaughtererAck = 21017,
        SReadyRoundAck = 21018,
        SBeginRoundAck = 21019,
        SAvatarChangeAck = 21020,
        SChangeRuleNotifyAck = 21021,
        SChangeRuleAck = 21022,
        SChangeRuleResultMsgAck = 21023,
        SMissionNotifyAck = 21024,
        SMissionScoreAck = 21025,
        SScoreKillAck = 21026,
        SScoreKillAssistAck = 21027,
        SScoreOffenseAck = 21028,
        SScoreOffenseAssistAck = 21029,
        SScoreDefenseAck = 21030,
        SScoreDefenseAssistAck = 21031,
        SScoreHealAssistAck = 21032,
        SScoreGoalAck = 21033,
        SScoreGoalAssistAck = 21034,
        SScoreReboundAck = 21035,
        SScoreSuicideAck = 21036,
        SScoreTeamKillAck = 21037,
        SScoreRoundWinAck = 21038,
        SScoreSLRoundWinAck = 21039,
        SItemsChangeAck = 21040,
        SPlayerGameModeChangeAck = 21041,
        SRefreshGameRuleInfoAck = 21042,
        SArcadeScoreSyncAck = 21043,
        SArcadeBeginRoundAck = 21044,
        SArcadeStageBriefingAck = 21045,
        SArcadeEnablePlayeTimeAck = 21046,
        SArcadeStageInfoAck = 21047,
        SArcadeRespawnAck = 21048,
        SArcadeDeathPlayerInfoAck = 21049,
        SArcadeStageReadyAck = 21050,
        SArcadeRespawnFailAck = 21051,
        SChangeHPAck = 21052,
        SChangeMPAck = 21053,
        SArcadeChangeStageAck = 21054,
        SArcadeStageSelectAck = 21055,
        SArcadeSaveDataInfAck = 21056,
        SSlaughterAttackPointAck = 21057,
        SSlaughterHealPointAck = 21058,
        SChangeBonusTargetAck = 21059,
        SArcadeLoadingSucceedAck = 21060,
        SArcadeAllLoadingSucceedAck = 21061,
        SUseCoinAck = 21062,
        SLuckyShotAck = 21063,
        SGameRuleChangeTheFirstAck = 21064,
        SDevLogStartAck = 21065,
        SCompulsionLeaveRequestAck = 21066,
        SCompulsionLeaveResultAck = 21067,
        SCompulsionLeaveActionAck = 21068,
        SCaptainLifeRoundSetUpAck = 21069,
        SCaptainSubRoundEndReasonAck = 21070,
        SCurrentRoundInformationAck = 21071

        #endregion
    }

    public enum RelayOpCode : ushort
    {
        CRequestLogin = 10001,
        CNotifyP2PLog = 10002,

        SNotifyLoginResult = 11001,
        SEnterLoginPlayer = 11002
    }

    public enum EventOpCode : ushort
    {
        Chat = 12001,
        // 20001 ??? no string inside clietn
        EventMessage = 20002,
        ChangeTarget = 20003,
        ArcadeSync = 20004,
        ArcadeSyncReq = 20005,
        Packet = 20006
    }

    public enum P2POpCode : byte
    {
        PlayerSpawnReq = 1,
        PlayerSpawnAck = 2,

        AbilitySync = 3,
        EquippingItemSync = 4,
        DamageInfo = 5,
        DamageRemoteInfo = 6,
        SnapShot = 7,
        StateSync = 8,

        BGEffect = 10,
        DefensivePower = 11,
        BlastObjectDestroy = 12,
        BlastObjectRespawn = 13,
        MindEnergy = 15,
        DamageShield = 16,
        AimedPoint = 17,
        OnOff = 18,
        SentryGunSpawn = 19,
        SentryGunState = 20,
        SentryGunDestruction = 21,
        SentryGunDestruction2 = 22,
        GrenadeSpawn = 23,
        GrenadeSnapShot = 24,
        GrenadeSnapShot2 = 25,
        ObstructionSpawn = 26,
        ObstructionDestroy = 27,
        ObstructionDamage = 28,
        SyncObjectObstruction = 29,
        BlastObjectSync = 30,
        BallSync = 31,
        BallSnapShot = 32,
        ArcadeFin = 34,
        AttachArcadeItem = 36,
        HPSync = 37,
        Unk38 = 38, // something with arcade
        ExposeClubMark = 39,
        ReflectRate = 40,
        ConditionInfo = 41,
        AbilityChangeSync = 42,
        HealHP = 43
    }
}