using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002CC RID: 716
	[ProtoContract(Name = "StringTableId")]
	public enum StringTableId
	{
		// Token: 0x04001DE2 RID: 7650
		[ProtoEnum(Name = "StringTableId_GiftCDKey_ParamError", Value = 10)]
		StringTableId_GiftCDKey_ParamError = 10,
		// Token: 0x04001DE3 RID: 7651
		[ProtoEnum(Name = "StringTableId_GiftCDKey_Exception1", Value = 11)]
		StringTableId_GiftCDKey_Exception1,
		// Token: 0x04001DE4 RID: 7652
		[ProtoEnum(Name = "StringTableId_GiftCDKey_SignError", Value = 17)]
		StringTableId_GiftCDKey_SignError = 17,
		// Token: 0x04001DE5 RID: 7653
		[ProtoEnum(Name = "StringTableId_GiftCDKey_Useable", Value = 100)]
		StringTableId_GiftCDKey_Useable = 100,
		// Token: 0x04001DE6 RID: 7654
		[ProtoEnum(Name = "StringTableId_GiftCDKey_NotExist1", Value = 101)]
		StringTableId_GiftCDKey_NotExist1,
		// Token: 0x04001DE7 RID: 7655
		[ProtoEnum(Name = "StringTableId_GiftCDKey_NotExist2", Value = 102)]
		StringTableId_GiftCDKey_NotExist2,
		// Token: 0x04001DE8 RID: 7656
		[ProtoEnum(Name = "StringTableId_GiftCDKey_UnUsed1", Value = 103)]
		StringTableId_GiftCDKey_UnUsed1,
		// Token: 0x04001DE9 RID: 7657
		[ProtoEnum(Name = "StringTableId_GiftCDKey_Used", Value = 104)]
		StringTableId_GiftCDKey_Used,
		// Token: 0x04001DEA RID: 7658
		[ProtoEnum(Name = "StringTableId_GiftCDKey_NotExist3", Value = 105)]
		StringTableId_GiftCDKey_NotExist3,
		// Token: 0x04001DEB RID: 7659
		[ProtoEnum(Name = "StringTableId_GiftCDKey_UnUsed2", Value = 106)]
		StringTableId_GiftCDKey_UnUsed2,
		// Token: 0x04001DEC RID: 7660
		[ProtoEnum(Name = "StringTableId_GiftCDKey_NotOpen", Value = 107)]
		StringTableId_GiftCDKey_NotOpen,
		// Token: 0x04001DED RID: 7661
		[ProtoEnum(Name = "StringTableId_GiftCDKey_Invalid", Value = 108)]
		StringTableId_GiftCDKey_Invalid,
		// Token: 0x04001DEE RID: 7662
		[ProtoEnum(Name = "StringTableId_GiftCDKey_TypeError", Value = 109)]
		StringTableId_GiftCDKey_TypeError,
		// Token: 0x04001DEF RID: 7663
		[ProtoEnum(Name = "StringTableId_GiftCDKey_TypeUnUsed", Value = 110)]
		StringTableId_GiftCDKey_TypeUnUsed,
		// Token: 0x04001DF0 RID: 7664
		[ProtoEnum(Name = "StringTableId_GiftCDKey_SubTypeLimmited1", Value = 111)]
		StringTableId_GiftCDKey_SubTypeLimmited1,
		// Token: 0x04001DF1 RID: 7665
		[ProtoEnum(Name = "StringTableId_GiftCDKey_SubTypeLimmited2", Value = 112)]
		StringTableId_GiftCDKey_SubTypeLimmited2,
		// Token: 0x04001DF2 RID: 7666
		[ProtoEnum(Name = "StringTableId_GiftCDKey_UnUsed3", Value = 113)]
		StringTableId_GiftCDKey_UnUsed3,
		// Token: 0x04001DF3 RID: 7667
		[ProtoEnum(Name = "StringTableId_GiftCDKey_UnUsed4", Value = 114)]
		StringTableId_GiftCDKey_UnUsed4,
		// Token: 0x04001DF4 RID: 7668
		[ProtoEnum(Name = "StringTableId_GiftCDKey_OK", Value = 115)]
		StringTableId_GiftCDKey_OK,
		// Token: 0x04001DF5 RID: 7669
		[ProtoEnum(Name = "StringTableId_GiftCDKey_Exception2", Value = 116)]
		StringTableId_GiftCDKey_Exception2,
		// Token: 0x04001DF6 RID: 7670
		[ProtoEnum(Name = "StringTableId_ActorInfo_SkillCount", Value = 117)]
		StringTableId_ActorInfo_SkillCount,
		// Token: 0x04001DF7 RID: 7671
		[ProtoEnum(Name = "StringTableId_Bag_ItemCount", Value = 118)]
		StringTableId_Bag_ItemCount,
		// Token: 0x04001DF8 RID: 7672
		[ProtoEnum(Name = "StringTableId_JobMaterial_ItemCount", Value = 119)]
		StringTableId_JobMaterial_ItemCount,
		// Token: 0x04001DF9 RID: 7673
		[ProtoEnum(Name = "StringTableId_JobMaterial_RequireHeroLevel", Value = 120)]
		StringTableId_JobMaterial_RequireHeroLevel,
		// Token: 0x04001DFA RID: 7674
		[ProtoEnum(Name = "StringTableId_Melee", Value = 125)]
		StringTableId_Melee = 125,
		// Token: 0x04001DFB RID: 7675
		[ProtoEnum(Name = "StringTableId_NotMelee", Value = 126)]
		StringTableId_NotMelee,
		// Token: 0x04001DFC RID: 7676
		[ProtoEnum(Name = "StringTableId_Property", Value = 127)]
		StringTableId_Property,
		// Token: 0x04001DFD RID: 7677
		[ProtoEnum(Name = "StringTableId_Close", Value = 128)]
		StringTableId_Close,
		// Token: 0x04001DFE RID: 7678
		[ProtoEnum(Name = "StringTableId_ItemDesc_Count", Value = 132)]
		StringTableId_ItemDesc_Count = 132,
		// Token: 0x04001DFF RID: 7679
		[ProtoEnum(Name = "StringTableId_ItemDesc_Gold", Value = 133)]
		StringTableId_ItemDesc_Gold,
		// Token: 0x04001E00 RID: 7680
		[ProtoEnum(Name = "StringTableId_ItemDesc_Crystal", Value = 134)]
		StringTableId_ItemDesc_Crystal,
		// Token: 0x04001E01 RID: 7681
		[ProtoEnum(Name = "StringTableId_ItemDesc_Energy", Value = 135)]
		StringTableId_ItemDesc_Energy,
		// Token: 0x04001E02 RID: 7682
		[ProtoEnum(Name = "StringTableId_ItemDesc_ArenaTicket", Value = 136)]
		StringTableId_ItemDesc_ArenaTicket,
		// Token: 0x04001E03 RID: 7683
		[ProtoEnum(Name = "StringTableId_ItemDesc_ArenaHonour", Value = 137)]
		StringTableId_ItemDesc_ArenaHonour,
		// Token: 0x04001E04 RID: 7684
		[ProtoEnum(Name = "StringTableId_ItemDesc_PlayerExp", Value = 138)]
		StringTableId_ItemDesc_PlayerExp,
		// Token: 0x04001E05 RID: 7685
		[ProtoEnum(Name = "StringTableId_Resource_Gold", Value = 139)]
		StringTableId_Resource_Gold,
		// Token: 0x04001E06 RID: 7686
		[ProtoEnum(Name = "StringTableId_Resource_Crystal", Value = 140)]
		StringTableId_Resource_Crystal,
		// Token: 0x04001E07 RID: 7687
		[ProtoEnum(Name = "StringTableId_Resource_Energy", Value = 141)]
		StringTableId_Resource_Energy,
		// Token: 0x04001E08 RID: 7688
		[ProtoEnum(Name = "StringTableId_Resource_ArenaTicket", Value = 142)]
		StringTableId_Resource_ArenaTicket,
		// Token: 0x04001E09 RID: 7689
		[ProtoEnum(Name = "StringTableId_Resource_ArenaHonour", Value = 143)]
		StringTableId_Resource_ArenaHonour,
		// Token: 0x04001E0A RID: 7690
		[ProtoEnum(Name = "StringTableId_Resource_PlayerExp", Value = 144)]
		StringTableId_Resource_PlayerExp,
		// Token: 0x04001E0B RID: 7691
		[ProtoEnum(Name = "StringTableId_Time_Day", Value = 145)]
		StringTableId_Time_Day,
		// Token: 0x04001E0C RID: 7692
		[ProtoEnum(Name = "StringTableId_Time_Hour", Value = 146)]
		StringTableId_Time_Hour,
		// Token: 0x04001E0D RID: 7693
		[ProtoEnum(Name = "StringTableId_Time_Minute", Value = 147)]
		StringTableId_Time_Minute,
		// Token: 0x04001E0E RID: 7694
		[ProtoEnum(Name = "StringTableId_Time_Second", Value = 148)]
		StringTableId_Time_Second,
		// Token: 0x04001E0F RID: 7695
		[ProtoEnum(Name = "StringTableId_Time_Point", Value = 149)]
		StringTableId_Time_Point,
		// Token: 0x04001E10 RID: 7696
		[ProtoEnum(Name = "StringTableId_Time_InOneHour", Value = 150)]
		StringTableId_Time_InOneHour,
		// Token: 0x04001E11 RID: 7697
		[ProtoEnum(Name = "StringTableId_Time_HoursAgo", Value = 151)]
		StringTableId_Time_HoursAgo,
		// Token: 0x04001E12 RID: 7698
		[ProtoEnum(Name = "StringTableId_Time_DaysAgo", Value = 152)]
		StringTableId_Time_DaysAgo,
		// Token: 0x04001E13 RID: 7699
		[ProtoEnum(Name = "StringTableId_Equipment_SkillOwner", Value = 153)]
		StringTableId_Equipment_SkillOwner,
		// Token: 0x04001E14 RID: 7700
		[ProtoEnum(Name = "StringTableId_ItemDesc_FriendshipPoints", Value = 154)]
		StringTableId_ItemDesc_FriendshipPoints,
		// Token: 0x04001E15 RID: 7701
		[ProtoEnum(Name = "StringTableId_Resource_FriendshipPoints", Value = 155)]
		StringTableId_Resource_FriendshipPoints,
		// Token: 0x04001E16 RID: 7702
		[ProtoEnum(Name = "StringTableId_ItemDesc_SkinTicket", Value = 156)]
		StringTableId_ItemDesc_SkinTicket,
		// Token: 0x04001E17 RID: 7703
		[ProtoEnum(Name = "StringTableId_Resource_SkinTicket", Value = 157)]
		StringTableId_Resource_SkinTicket,
		// Token: 0x04001E18 RID: 7704
		[ProtoEnum(Name = "StringTableId_ItemDesc_MemoryEssence", Value = 158)]
		StringTableId_ItemDesc_MemoryEssence,
		// Token: 0x04001E19 RID: 7705
		[ProtoEnum(Name = "StringTableId_Resource_MemoryEssence", Value = 159)]
		StringTableId_Resource_MemoryEssence,
		// Token: 0x04001E1A RID: 7706
		[ProtoEnum(Name = "StringTableId_Time_Online", Value = 160)]
		StringTableId_Time_Online,
		// Token: 0x04001E1B RID: 7707
		[ProtoEnum(Name = "StringTableId_Time_MinutesAgo", Value = 161)]
		StringTableId_Time_MinutesAgo,
		// Token: 0x04001E1C RID: 7708
		[ProtoEnum(Name = "StringTableId_ItemDesc_MithralStone", Value = 162)]
		StringTableId_ItemDesc_MithralStone,
		// Token: 0x04001E1D RID: 7709
		[ProtoEnum(Name = "StringTableId_Resource_MithralStone", Value = 163)]
		StringTableId_Resource_MithralStone,
		// Token: 0x04001E1E RID: 7710
		[ProtoEnum(Name = "StringTableId_ItemDesc_BrillianceMithralStone", Value = 164)]
		StringTableId_ItemDesc_BrillianceMithralStone,
		// Token: 0x04001E1F RID: 7711
		[ProtoEnum(Name = "StringTableId_Resource_BrillianceMithralStone", Value = 165)]
		StringTableId_Resource_BrillianceMithralStone,
		// Token: 0x04001E20 RID: 7712
		[ProtoEnum(Name = "StringTableId_Sign_NDay", Value = 166)]
		StringTableId_Sign_NDay,
		// Token: 0x04001E21 RID: 7713
		[ProtoEnum(Name = "StringTableId_Resource_GuildMedal", Value = 167)]
		StringTableId_Resource_GuildMedal,
		// Token: 0x04001E22 RID: 7714
		[ProtoEnum(Name = "StringTableId_ItemDesc_GuildMedal", Value = 168)]
		StringTableId_ItemDesc_GuildMedal,
		// Token: 0x04001E23 RID: 7715
		[ProtoEnum(Name = "StringTableId_World_OpenScenario", Value = 200)]
		StringTableId_World_OpenScenario = 200,
		// Token: 0x04001E24 RID: 7716
		[ProtoEnum(Name = "StringTableId_UnlockScenario_PlayerLevel", Value = 201)]
		StringTableId_UnlockScenario_PlayerLevel,
		// Token: 0x04001E25 RID: 7717
		[ProtoEnum(Name = "StringTableId_UnlockScenario_RiftLevel", Value = 202)]
		StringTableId_UnlockScenario_RiftLevel,
		// Token: 0x04001E26 RID: 7718
		[ProtoEnum(Name = "StringTableId_UnlockScenario_Title", Value = 203)]
		StringTableId_UnlockScenario_Title,
		// Token: 0x04001E27 RID: 7719
		[ProtoEnum(Name = "StringTableId_UnlockCondition_PlayerLevel", Value = 210)]
		StringTableId_UnlockCondition_PlayerLevel = 210,
		// Token: 0x04001E28 RID: 7720
		[ProtoEnum(Name = "StringTableId_UnlockCondition_Scenario", Value = 211)]
		StringTableId_UnlockCondition_Scenario,
		// Token: 0x04001E29 RID: 7721
		[ProtoEnum(Name = "StringTableId_UnlockCondition_Achievement", Value = 212)]
		StringTableId_UnlockCondition_Achievement,
		// Token: 0x04001E2A RID: 7722
		[ProtoEnum(Name = "StringTableId_UnlockCondition_Hero", Value = 213)]
		StringTableId_UnlockCondition_Hero,
		// Token: 0x04001E2B RID: 7723
		[ProtoEnum(Name = "StringTableId_UnlockCondition_RiftLevel", Value = 214)]
		StringTableId_UnlockCondition_RiftLevel,
		// Token: 0x04001E2C RID: 7724
		[ProtoEnum(Name = "StringTableId_UnlockCondition_HeroDungeonLevel", Value = 215)]
		StringTableId_UnlockCondition_HeroDungeonLevel,
		// Token: 0x04001E2D RID: 7725
		[ProtoEnum(Name = "StringTableId_Reward_First", Value = 220)]
		StringTableId_Reward_First = 220,
		// Token: 0x04001E2E RID: 7726
		[ProtoEnum(Name = "StringTableId_Reward_Drop", Value = 221)]
		StringTableId_Reward_Drop,
		// Token: 0x04001E2F RID: 7727
		[ProtoEnum(Name = "StringTableId_BattleWin_StarTurnMax", Value = 230)]
		StringTableId_BattleWin_StarTurnMax = 230,
		// Token: 0x04001E30 RID: 7728
		[ProtoEnum(Name = "StringTableId_BattleWin_RiftStarDeadMax", Value = 231)]
		StringTableId_BattleWin_RiftStarDeadMax,
		// Token: 0x04001E31 RID: 7729
		[ProtoEnum(Name = "StringTableId_BattleWin_HeroDungeonStarDeadMax", Value = 232)]
		StringTableId_BattleWin_HeroDungeonStarDeadMax,
		// Token: 0x04001E32 RID: 7730
		[ProtoEnum(Name = "StringTableId_BattleWin_NoStarCondition", Value = 233)]
		StringTableId_BattleWin_NoStarCondition,
		// Token: 0x04001E33 RID: 7731
		[ProtoEnum(Name = "StringTableId_BattleWin_StarNoDead", Value = 234)]
		StringTableId_BattleWin_StarNoDead,
		// Token: 0x04001E34 RID: 7732
		[ProtoEnum(Name = "StringTableId_Arena_Guard", Value = 240)]
		StringTableId_Arena_Guard = 240,
		// Token: 0x04001E35 RID: 7733
		[ProtoEnum(Name = "StringTableId_Arena_Attack", Value = 241)]
		StringTableId_Arena_Attack,
		// Token: 0x04001E36 RID: 7734
		[ProtoEnum(Name = "StringTableId_Arena_Defend", Value = 242)]
		StringTableId_Arena_Defend,
		// Token: 0x04001E37 RID: 7735
		[ProtoEnum(Name = "StringTableId_Arena_Revenge", Value = 243)]
		StringTableId_Arena_Revenge,
		// Token: 0x04001E38 RID: 7736
		[ProtoEnum(Name = "StringTableId_Arena_Win", Value = 244)]
		StringTableId_Arena_Win,
		// Token: 0x04001E39 RID: 7737
		[ProtoEnum(Name = "StringTableId_Arena_Lose", Value = 245)]
		StringTableId_Arena_Lose,
		// Token: 0x04001E3A RID: 7738
		[ProtoEnum(Name = "StringTableId_Arena_WeekWin", Value = 246)]
		StringTableId_Arena_WeekWin,
		// Token: 0x04001E3B RID: 7739
		[ProtoEnum(Name = "StringTableId_Arena_TicketCount", Value = 247)]
		StringTableId_Arena_TicketCount,
		// Token: 0x04001E3C RID: 7740
		[ProtoEnum(Name = "StringTableId_Arena_PromoteBattleTips", Value = 248)]
		StringTableId_Arena_PromoteBattleTips,
		// Token: 0x04001E3D RID: 7741
		[ProtoEnum(Name = "StringTableId_Arena_HaveRevenge", Value = 249)]
		StringTableId_Arena_HaveRevenge,
		// Token: 0x04001E3E RID: 7742
		[ProtoEnum(Name = "StringTableId_Arena_OpponentFlushTime", Value = 250)]
		StringTableId_Arena_OpponentFlushTime,
		// Token: 0x04001E3F RID: 7743
		[ProtoEnum(Name = "StringTableId_Arena_ArenaPointLessThan", Value = 251)]
		StringTableId_Arena_ArenaPointLessThan,
		// Token: 0x04001E40 RID: 7744
		[ProtoEnum(Name = "StringTableId_Arena_WinRate0", Value = 252)]
		StringTableId_Arena_WinRate0,
		// Token: 0x04001E41 RID: 7745
		[ProtoEnum(Name = "StringTableId_Arena_WinRate1", Value = 253)]
		StringTableId_Arena_WinRate1,
		// Token: 0x04001E42 RID: 7746
		[ProtoEnum(Name = "StringTableId_Arena_WinRate2", Value = 254)]
		StringTableId_Arena_WinRate2,
		// Token: 0x04001E43 RID: 7747
		[ProtoEnum(Name = "StringTableId_Arena_NoArenaDefensiveHero", Value = 255)]
		StringTableId_Arena_NoArenaDefensiveHero,
		// Token: 0x04001E44 RID: 7748
		[ProtoEnum(Name = "StringTableId_Arena_MatchingTimeUnknown", Value = 256)]
		StringTableId_Arena_MatchingTimeUnknown,
		// Token: 0x04001E45 RID: 7749
		[ProtoEnum(Name = "StringTableId_Arena_PromoteSucceed", Value = 257)]
		StringTableId_Arena_PromoteSucceed,
		// Token: 0x04001E46 RID: 7750
		[ProtoEnum(Name = "StringTableId_Arena_NoRanking", Value = 258)]
		StringTableId_Arena_NoRanking,
		// Token: 0x04001E47 RID: 7751
		[ProtoEnum(Name = "StringTableId_Arena_CanNotStartArenaBattle", Value = 259)]
		StringTableId_Arena_CanNotStartArenaBattle,
		// Token: 0x04001E48 RID: 7752
		[ProtoEnum(Name = "StringTableId_Team_ExitMatch", Value = 300)]
		StringTableId_Team_ExitMatch = 300,
		// Token: 0x04001E49 RID: 7753
		[ProtoEnum(Name = "StringTableId_Team_MatchWaitCount", Value = 301)]
		StringTableId_Team_MatchWaitCount,
		// Token: 0x04001E4A RID: 7754
		[ProtoEnum(Name = "StringTableId_Team_AllGameFunctionType", Value = 302)]
		StringTableId_Team_AllGameFunctionType,
		// Token: 0x04001E4B RID: 7755
		[ProtoEnum(Name = "StringTableId_Team_AllLocation", Value = 303)]
		StringTableId_Team_AllLocation,
		// Token: 0x04001E4C RID: 7756
		[ProtoEnum(Name = "StringTableId_Team_Authority_Public", Value = 304)]
		StringTableId_Team_Authority_Public,
		// Token: 0x04001E4D RID: 7757
		[ProtoEnum(Name = "StringTableId_Team_Authority_FriendAndGuild", Value = 305)]
		StringTableId_Team_Authority_FriendAndGuild,
		// Token: 0x04001E4E RID: 7758
		[ProtoEnum(Name = "StringTableId_Team_Authority_NonPublic", Value = 306)]
		StringTableId_Team_Authority_NonPublic,
		// Token: 0x04001E4F RID: 7759
		[ProtoEnum(Name = "StringTableId_Team_CanNotChangeAuthority", Value = 307)]
		StringTableId_Team_CanNotChangeAuthority,
		// Token: 0x04001E50 RID: 7760
		[ProtoEnum(Name = "StringTableId_Team_StartAutoMatch", Value = 308)]
		StringTableId_Team_StartAutoMatch,
		// Token: 0x04001E51 RID: 7761
		[ProtoEnum(Name = "StringTableId_Team_OnlineFriend", Value = 309)]
		StringTableId_Team_OnlineFriend,
		// Token: 0x04001E52 RID: 7762
		[ProtoEnum(Name = "StringTableId_Team_OnlineRecent", Value = 310)]
		StringTableId_Team_OnlineRecent,
		// Token: 0x04001E53 RID: 7763
		[ProtoEnum(Name = "StringTableId_Team_InvitationRefused", Value = 311)]
		StringTableId_Team_InvitationRefused,
		// Token: 0x04001E54 RID: 7764
		[ProtoEnum(Name = "StringTableId_Team_InvitationAgain", Value = 312)]
		StringTableId_Team_InvitationAgain,
		// Token: 0x04001E55 RID: 7765
		[ProtoEnum(Name = "StringTableId_Team_CanOnlyReplaceHero", Value = 313)]
		StringTableId_Team_CanOnlyReplaceHero,
		// Token: 0x04001E56 RID: 7766
		[ProtoEnum(Name = "StringTableId_Team_CanNotChangeTeammate", Value = 314)]
		StringTableId_Team_CanNotChangeTeammate,
		// Token: 0x04001E57 RID: 7767
		[ProtoEnum(Name = "StringTableId_Team_RoomCountdown", Value = 315)]
		StringTableId_Team_RoomCountdown,
		// Token: 0x04001E58 RID: 7768
		[ProtoEnum(Name = "StringTableId_Team_InviteTeammateAgain", Value = 316)]
		StringTableId_Team_InviteTeammateAgain,
		// Token: 0x04001E59 RID: 7769
		[ProtoEnum(Name = "StringTableId_Team_GameFunctionNotOpen", Value = 317)]
		StringTableId_Team_GameFunctionNotOpen,
		// Token: 0x04001E5A RID: 7770
		[ProtoEnum(Name = "StringTableId_Team_LocationNotOpen", Value = 318)]
		StringTableId_Team_LocationNotOpen,
		// Token: 0x04001E5B RID: 7771
		[ProtoEnum(Name = "StringTableId_Team_NoTeamRoom", Value = 319)]
		StringTableId_Team_NoTeamRoom,
		// Token: 0x04001E5C RID: 7772
		[ProtoEnum(Name = "StringTableId_Team_LocationLock", Value = 320)]
		StringTableId_Team_LocationLock,
		// Token: 0x04001E5D RID: 7773
		[ProtoEnum(Name = "StringTableId_Team_CanNotChangeEnemy", Value = 321)]
		StringTableId_Team_CanNotChangeEnemy,
		// Token: 0x04001E5E RID: 7774
		[ProtoEnum(Name = "StringTableId_Team_PlayerBattleNotOpen", Value = 322)]
		StringTableId_Team_PlayerBattleNotOpen,
		// Token: 0x04001E5F RID: 7775
		[ProtoEnum(Name = "StringTableId_Team_PlayerQuitBattle", Value = 323)]
		StringTableId_Team_PlayerQuitBattle,
		// Token: 0x04001E60 RID: 7776
		[ProtoEnum(Name = "StringTableId_Team_PlayerLevelNotOpen", Value = 324)]
		StringTableId_Team_PlayerLevelNotOpen,
		// Token: 0x04001E61 RID: 7777
		[ProtoEnum(Name = "StringTableId_Team_PlayerTodayHasNoHero", Value = 325)]
		StringTableId_Team_PlayerTodayHasNoHero,
		// Token: 0x04001E62 RID: 7778
		[ProtoEnum(Name = "StringTableId_PVP_OpponentQuitBattle", Value = 330)]
		StringTableId_PVP_OpponentQuitBattle = 330,
		// Token: 0x04001E63 RID: 7779
		[ProtoEnum(Name = "StringTableId_PVP_CanOnlyReplaceHero", Value = 331)]
		StringTableId_PVP_CanOnlyReplaceHero,
		// Token: 0x04001E64 RID: 7780
		[ProtoEnum(Name = "StringTableId_Friend_SearchFriendNameEmpty", Value = 400)]
		StringTableId_Friend_SearchFriendNameEmpty = 400,
		// Token: 0x04001E65 RID: 7781
		[ProtoEnum(Name = "StringTableId_Friend_SelectServerError", Value = 401)]
		StringTableId_Friend_SelectServerError,
		// Token: 0x04001E66 RID: 7782
		[ProtoEnum(Name = "StringTableId_Friend_InviteFriendSuccess", Value = 402)]
		StringTableId_Friend_InviteFriendSuccess,
		// Token: 0x04001E67 RID: 7783
		[ProtoEnum(Name = "StringTableId_Friend_ConfirmDeleteFriend", Value = 403)]
		StringTableId_Friend_ConfirmDeleteFriend,
		// Token: 0x04001E68 RID: 7784
		[ProtoEnum(Name = "StringTableId_Friend_DeleteFriendSuccess", Value = 404)]
		StringTableId_Friend_DeleteFriendSuccess,
		// Token: 0x04001E69 RID: 7785
		[ProtoEnum(Name = "StringTableId_Friend_ConfirmUnblockPlayer", Value = 405)]
		StringTableId_Friend_ConfirmUnblockPlayer,
		// Token: 0x04001E6A RID: 7786
		[ProtoEnum(Name = "StringTableId_Friend_UnblockPlayerSuccess", Value = 406)]
		StringTableId_Friend_UnblockPlayerSuccess,
		// Token: 0x04001E6B RID: 7787
		[ProtoEnum(Name = "StringTableId_Friend_PVPInviteNotify", Value = 407)]
		StringTableId_Friend_PVPInviteNotify,
		// Token: 0x04001E6C RID: 7788
		[ProtoEnum(Name = "StringTableId_Friend_PVPInviteFail", Value = 408)]
		StringTableId_Friend_PVPInviteFail,
		// Token: 0x04001E6D RID: 7789
		[ProtoEnum(Name = "StringTableId_Friend_InvitePlayerAtLeastTwo", Value = 409)]
		StringTableId_Friend_InvitePlayerAtLeastTwo,
		// Token: 0x04001E6E RID: 7790
		[ProtoEnum(Name = "StringTableId_Friend_InvitePlayerCountZero", Value = 410)]
		StringTableId_Friend_InvitePlayerCountZero,
		// Token: 0x04001E6F RID: 7791
		[ProtoEnum(Name = "StringTableId_Friend_SendFriendShipPointTopLimit", Value = 411)]
		StringTableId_Friend_SendFriendShipPointTopLimit,
		// Token: 0x04001E70 RID: 7792
		[ProtoEnum(Name = "StringTableId_Friend_AlreadySendFriendShipPoint", Value = 412)]
		StringTableId_Friend_AlreadySendFriendShipPoint,
		// Token: 0x04001E71 RID: 7793
		[ProtoEnum(Name = "StringTableId_Friend_AlreadyMaxInviteCount", Value = 413)]
		StringTableId_Friend_AlreadyMaxInviteCount,
		// Token: 0x04001E72 RID: 7794
		[ProtoEnum(Name = "StringTableId_Friend_AlreadyInGroup", Value = 414)]
		StringTableId_Friend_AlreadyInGroup,
		// Token: 0x04001E73 RID: 7795
		[ProtoEnum(Name = "StringTableId_Friend_OnlineCount", Value = 415)]
		StringTableId_Friend_OnlineCount,
		// Token: 0x04001E74 RID: 7796
		[ProtoEnum(Name = "StringTableId_Friend_BlockSuccess", Value = 416)]
		StringTableId_Friend_BlockSuccess,
		// Token: 0x04001E75 RID: 7797
		[ProtoEnum(Name = "StringTableId_Friend_ConfirmLeaveGroup", Value = 417)]
		StringTableId_Friend_ConfirmLeaveGroup,
		// Token: 0x04001E76 RID: 7798
		[ProtoEnum(Name = "StringTableId_Friend_LeaveGroupSuccess", Value = 418)]
		StringTableId_Friend_LeaveGroupSuccess,
		// Token: 0x04001E77 RID: 7799
		[ProtoEnum(Name = "StringTableId_Friend_ConfirmKickGroup", Value = 419)]
		StringTableId_Friend_ConfirmKickGroup,
		// Token: 0x04001E78 RID: 7800
		[ProtoEnum(Name = "StringTableId_Friend_KickGroupSuccess", Value = 420)]
		StringTableId_Friend_KickGroupSuccess,
		// Token: 0x04001E79 RID: 7801
		[ProtoEnum(Name = "StringTableId_Friend_SendFriendShipPointSuccess", Value = 421)]
		StringTableId_Friend_SendFriendShipPointSuccess,
		// Token: 0x04001E7A RID: 7802
		[ProtoEnum(Name = "StringTableId_Friend_ReceiveFriendShipPoint", Value = 422)]
		StringTableId_Friend_ReceiveFriendShipPoint,
		// Token: 0x04001E7B RID: 7803
		[ProtoEnum(Name = "StringTableId_Friend_FriendInviteAccept", Value = 423)]
		StringTableId_Friend_FriendInviteAccept,
		// Token: 0x04001E7C RID: 7804
		[ProtoEnum(Name = "StringTableId_Friend_CreateGroupSuccess", Value = 424)]
		StringTableId_Friend_CreateGroupSuccess,
		// Token: 0x04001E7D RID: 7805
		[ProtoEnum(Name = "StringTableId_Friend_GroupDissolved", Value = 425)]
		StringTableId_Friend_GroupDissolved,
		// Token: 0x04001E7E RID: 7806
		[ProtoEnum(Name = "StringTableId_Friend_FriendIsFull", Value = 426)]
		StringTableId_Friend_FriendIsFull,
		// Token: 0x04001E7F RID: 7807
		[ProtoEnum(Name = "StringTableId_Friend_AlreadyIsFriend", Value = 427)]
		StringTableId_Friend_AlreadyIsFriend,
		// Token: 0x04001E80 RID: 7808
		[ProtoEnum(Name = "StringTableId_Friend_AlreadyBlock", Value = 428)]
		StringTableId_Friend_AlreadyBlock,
		// Token: 0x04001E81 RID: 7809
		[ProtoEnum(Name = "StringTableId_Friend_BeBlockedInvite", Value = 429)]
		StringTableId_Friend_BeBlockedInvite,
		// Token: 0x04001E82 RID: 7810
		[ProtoEnum(Name = "StringTableId_Friend_BeInvited", Value = 430)]
		StringTableId_Friend_BeInvited,
		// Token: 0x04001E83 RID: 7811
		[ProtoEnum(Name = "StringTableId_Friend_BeBlockedFriend", Value = 431)]
		StringTableId_Friend_BeBlockedFriend,
		// Token: 0x04001E84 RID: 7812
		[ProtoEnum(Name = "StringTableId_Friend_GroupMemberHaveRestCount", Value = 432)]
		StringTableId_Friend_GroupMemberHaveRestCount,
		// Token: 0x04001E85 RID: 7813
		[ProtoEnum(Name = "StringTableId_Friend_GroupIsFull", Value = 433)]
		StringTableId_Friend_GroupIsFull,
		// Token: 0x04001E86 RID: 7814
		[ProtoEnum(Name = "StringTableId_Friend_DefaultGroupName", Value = 434)]
		StringTableId_Friend_DefaultGroupName,
		// Token: 0x04001E87 RID: 7815
		[ProtoEnum(Name = "StringTableId_Uncharted_LimitTime", Value = 500)]
		StringTableId_Uncharted_LimitTime = 500,
		// Token: 0x04001E88 RID: 7816
		[ProtoEnum(Name = "StringTableId_Uncharted_RestTimeDay", Value = 501)]
		StringTableId_Uncharted_RestTimeDay,
		// Token: 0x04001E89 RID: 7817
		[ProtoEnum(Name = "StringTableId_Uncharted_RestTimeHour", Value = 502)]
		StringTableId_Uncharted_RestTimeHour,
		// Token: 0x04001E8A RID: 7818
		[ProtoEnum(Name = "StringTableId_Uncharted_RestTimeMinute", Value = 503)]
		StringTableId_Uncharted_RestTimeMinute,
		// Token: 0x04001E8B RID: 7819
		[ProtoEnum(Name = "StringTableId_Uncharted_NotOpenTime", Value = 504)]
		StringTableId_Uncharted_NotOpenTime,
		// Token: 0x04001E8C RID: 7820
		[ProtoEnum(Name = "StringTableId_Uncharted_TodayRemainCount", Value = 505)]
		StringTableId_Uncharted_TodayRemainCount,
		// Token: 0x04001E8D RID: 7821
		[ProtoEnum(Name = "StringTableId_Regret_Count0", Value = 600)]
		StringTableId_Regret_Count0 = 600,
		// Token: 0x04001E8E RID: 7822
		[ProtoEnum(Name = "StringTableId_Regret_Count", Value = 601)]
		StringTableId_Regret_Count,
		// Token: 0x04001E8F RID: 7823
		[ProtoEnum(Name = "StringTableId_Regret_NoCount", Value = 602)]
		StringTableId_Regret_NoCount,
		// Token: 0x04001E90 RID: 7824
		[ProtoEnum(Name = "StringTableId_Regret_Turn", Value = 603)]
		StringTableId_Regret_Turn,
		// Token: 0x04001E91 RID: 7825
		[ProtoEnum(Name = "StringTableId_Regret_MyAction", Value = 604)]
		StringTableId_Regret_MyAction,
		// Token: 0x04001E92 RID: 7826
		[ProtoEnum(Name = "StringTableId_Regret_TeammateAction", Value = 605)]
		StringTableId_Regret_TeammateAction,
		// Token: 0x04001E93 RID: 7827
		[ProtoEnum(Name = "StringTableId_Regret_EnemyAction", Value = 606)]
		StringTableId_Regret_EnemyAction,
		// Token: 0x04001E94 RID: 7828
		[ProtoEnum(Name = "StringTableId_Login_Logining", Value = 700)]
		StringTableId_Login_Logining = 700,
		// Token: 0x04001E95 RID: 7829
		[ProtoEnum(Name = "StringTableId_Login_Login_Fail", Value = 701)]
		StringTableId_Login_Login_Fail,
		// Token: 0x04001E96 RID: 7830
		[ProtoEnum(Name = "StringTableId_Login_CanNotSelectMaintainServer", Value = 702)]
		StringTableId_Login_CanNotSelectMaintainServer,
		// Token: 0x04001E97 RID: 7831
		[ProtoEnum(Name = "StringTableId_ServerOpenTimeFormatString", Value = 703)]
		StringTableId_ServerOpenTimeFormatString,
		// Token: 0x04001E98 RID: 7832
		[ProtoEnum(Name = "StringTableId_Msg_ServerWillOpenAtTime", Value = 704)]
		StringTableId_Msg_ServerWillOpenAtTime,
		// Token: 0x04001E99 RID: 7833
		[ProtoEnum(Name = "StringTableId_ServerIsFull", Value = 705)]
		StringTableId_ServerIsFull,
		// Token: 0x04001E9A RID: 7834
		[ProtoEnum(Name = "StringTableId_ServerRefuseNewPlayer", Value = 706)]
		StringTableId_ServerRefuseNewPlayer,
		// Token: 0x04001E9B RID: 7835
		[ProtoEnum(Name = "StringTableId_LastLogin_LessOndDay", Value = 707)]
		StringTableId_LastLogin_LessOndDay,
		// Token: 0x04001E9C RID: 7836
		[ProtoEnum(Name = "StringTableId_LastLogin_LessOneMonth", Value = 708)]
		StringTableId_LastLogin_LessOneMonth,
		// Token: 0x04001E9D RID: 7837
		[ProtoEnum(Name = "StringTableId_LastLogin_MoreThenOneMonth", Value = 709)]
		StringTableId_LastLogin_MoreThenOneMonth,
		// Token: 0x04001E9E RID: 7838
		[ProtoEnum(Name = "StringTableId_QRLogin_Success", Value = 710)]
		StringTableId_QRLogin_Success,
		// Token: 0x04001E9F RID: 7839
		[ProtoEnum(Name = "StringTableId_QRLogin_Failed", Value = 711)]
		StringTableId_QRLogin_Failed,
		// Token: 0x04001EA0 RID: 7840
		[ProtoEnum(Name = "StringTableId_QRLogin_Cancel", Value = 712)]
		StringTableId_QRLogin_Cancel,
		// Token: 0x04001EA1 RID: 7841
		[ProtoEnum(Name = "StringTableId_World_NoEvent", Value = 800)]
		StringTableId_World_NoEvent = 800,
		// Token: 0x04001EA2 RID: 7842
		[ProtoEnum(Name = "StringTableId_World_NoSurvey", Value = 801)]
		StringTableId_World_NoSurvey,
		// Token: 0x04001EA3 RID: 7843
		[ProtoEnum(Name = "StringTableId_World_HadFinishedSurvey", Value = 802)]
		StringTableId_World_HadFinishedSurvey,
		// Token: 0x04001EA4 RID: 7844
		[ProtoEnum(Name = "StringTableId_World_SurveyLimit", Value = 803)]
		StringTableId_World_SurveyLimit,
		// Token: 0x04001EA5 RID: 7845
		[ProtoEnum(Name = "StringTableId_Msg_SkillPointNotEnough", Value = 1014)]
		StringTableId_Msg_SkillPointNotEnough = 1014,
		// Token: 0x04001EA6 RID: 7846
		[ProtoEnum(Name = "StringTableId_Dialog_SkipDialog", Value = 1016)]
		StringTableId_Dialog_SkipDialog = 1016,
		// Token: 0x04001EA7 RID: 7847
		[ProtoEnum(Name = "StringTableId_Msg_AddExp_ExpMax", Value = 1017)]
		StringTableId_Msg_AddExp_ExpMax,
		// Token: 0x04001EA8 RID: 7848
		[ProtoEnum(Name = "StringTableId_Msg_ComposeHero", Value = 1018)]
		StringTableId_Msg_ComposeHero,
		// Token: 0x04001EA9 RID: 7849
		[ProtoEnum(Name = "StringTableId_Msg_AnikiGymNotOpen", Value = 1020)]
		StringTableId_Msg_AnikiGymNotOpen = 1020,
		// Token: 0x04001EAA RID: 7850
		[ProtoEnum(Name = "StringTableId_Msg_AnikiLevelNotOpen", Value = 1021)]
		StringTableId_Msg_AnikiLevelNotOpen,
		// Token: 0x04001EAB RID: 7851
		[ProtoEnum(Name = "StringTableId_Msg_ThearchyLevelNotOpen", Value = 1022)]
		StringTableId_Msg_ThearchyLevelNotOpen,
		// Token: 0x04001EAC RID: 7852
		[ProtoEnum(Name = "StringTableId_Msg_SkillEquipNumMax", Value = 1023)]
		StringTableId_Msg_SkillEquipNumMax,
		// Token: 0x04001EAD RID: 7853
		[ProtoEnum(Name = "StringTableId_Msg_JobCantEquipSkill", Value = 1024)]
		StringTableId_Msg_JobCantEquipSkill,
		// Token: 0x04001EAE RID: 7854
		[ProtoEnum(Name = "StringTableId_Msg_BreakToMax", Value = 1025)]
		StringTableId_Msg_BreakToMax,
		// Token: 0x04001EAF RID: 7855
		[ProtoEnum(Name = "StringTableId_Msg_NextBreakLvPreview", Value = 1026)]
		StringTableId_Msg_NextBreakLvPreview,
		// Token: 0x04001EB0 RID: 7856
		[ProtoEnum(Name = "StringTableId_Msg_DontHaveSoldier", Value = 1027)]
		StringTableId_Msg_DontHaveSoldier,
		// Token: 0x04001EB1 RID: 7857
		[ProtoEnum(Name = "StringTableId_Msg_FragmentCondition", Value = 1028)]
		StringTableId_Msg_FragmentCondition,
		// Token: 0x04001EB2 RID: 7858
		[ProtoEnum(Name = "StringTableId_Msg_TransferJobIsCurJob", Value = 1029)]
		StringTableId_Msg_TransferJobIsCurJob,
		// Token: 0x04001EB3 RID: 7859
		[ProtoEnum(Name = "StringTableId_Msg_NoAchievement", Value = 1030)]
		StringTableId_Msg_NoAchievement,
		// Token: 0x04001EB4 RID: 7860
		[ProtoEnum(Name = "StringTableId_Msg_CantAddMoreEnhanceItem", Value = 1035)]
		StringTableId_Msg_CantAddMoreEnhanceItem = 1035,
		// Token: 0x04001EB5 RID: 7861
		[ProtoEnum(Name = "StringTableId_Msg_CantForge", Value = 1036)]
		StringTableId_Msg_CantForge,
		// Token: 0x04001EB6 RID: 7862
		[ProtoEnum(Name = "StringTableId_Msg_NoEquipmentCanBeUse", Value = 1037)]
		StringTableId_Msg_NoEquipmentCanBeUse,
		// Token: 0x04001EB7 RID: 7863
		[ProtoEnum(Name = "StringTableId_Msg_UpdateEquipmentSucceed", Value = 1042)]
		StringTableId_Msg_UpdateEquipmentSucceed = 1042,
		// Token: 0x04001EB8 RID: 7864
		[ProtoEnum(Name = "StringTableId_Msg_QuitApplicationOrNot", Value = 1044)]
		StringTableId_Msg_QuitApplicationOrNot = 1044,
		// Token: 0x04001EB9 RID: 7865
		[ProtoEnum(Name = "StringTableId_Msg_FavorabilityLimit", Value = 1050)]
		StringTableId_Msg_FavorabilityLimit = 1050,
		// Token: 0x04001EBA RID: 7866
		[ProtoEnum(Name = "StringTableId_Msg_HeroFettersUnlockEventType_Life", Value = 1051)]
		StringTableId_Msg_HeroFettersUnlockEventType_Life,
		// Token: 0x04001EBB RID: 7867
		[ProtoEnum(Name = "StringTableId_Msg_HeroFettersUnlockEventType_Voice", Value = 1052)]
		StringTableId_Msg_HeroFettersUnlockEventType_Voice,
		// Token: 0x04001EBC RID: 7868
		[ProtoEnum(Name = "StringTableId_Msg_HeroFettersUnlockEventType_Memory", Value = 1053)]
		StringTableId_Msg_HeroFettersUnlockEventType_Memory,
		// Token: 0x04001EBD RID: 7869
		[ProtoEnum(Name = "StringTableId_Msg_HeroFettersUnlockEventType_Fetters", Value = 1054)]
		StringTableId_Msg_HeroFettersUnlockEventType_Fetters,
		// Token: 0x04001EBE RID: 7870
		[ProtoEnum(Name = "StringTableId_Msg_PreLevelCompleteOpen", Value = 1055)]
		StringTableId_Msg_PreLevelCompleteOpen,
		// Token: 0x04001EBF RID: 7871
		[ProtoEnum(Name = "StringTableId_Msg_AchieveLevelOpen", Value = 1056)]
		StringTableId_Msg_AchieveLevelOpen,
		// Token: 0x04001EC0 RID: 7872
		[ProtoEnum(Name = "StringTableId_Msg_HeroCommentCantBeEmpty", Value = 1057)]
		StringTableId_Msg_HeroCommentCantBeEmpty,
		// Token: 0x04001EC1 RID: 7873
		[ProtoEnum(Name = "StringTableId_Msg_FetterFavorabilityLevelLimit", Value = 1058)]
		StringTableId_Msg_FetterFavorabilityLevelLimit,
		// Token: 0x04001EC2 RID: 7874
		[ProtoEnum(Name = "StringTableId_Msg_TrainingNeedLevel", Value = 1059)]
		StringTableId_Msg_TrainingNeedLevel,
		// Token: 0x04001EC3 RID: 7875
		[ProtoEnum(Name = "StringTableId_Msg_NotOpenNow", Value = 1060)]
		StringTableId_Msg_NotOpenNow,
		// Token: 0x04001EC4 RID: 7876
		[ProtoEnum(Name = "StringTableId_Msg_EnchantToLevel", Value = 1061)]
		StringTableId_Msg_EnchantToLevel,
		// Token: 0x04001EC5 RID: 7877
		[ProtoEnum(Name = "StringTableId_Msg_Like_Success", Value = 1062)]
		StringTableId_Msg_Like_Success,
		// Token: 0x04001EC6 RID: 7878
		[ProtoEnum(Name = "StringTableId_Msg_DrillNotOpen", Value = 1063)]
		StringTableId_Msg_DrillNotOpen,
		// Token: 0x04001EC7 RID: 7879
		[ProtoEnum(Name = "StringTableId_Msg_AlreadyHaveThreeHero", Value = 1064)]
		StringTableId_Msg_AlreadyHaveThreeHero,
		// Token: 0x04001EC8 RID: 7880
		[ProtoEnum(Name = "StringTableId_Msg_AlreadyInAssistant", Value = 1065)]
		StringTableId_Msg_AlreadyInAssistant,
		// Token: 0x04001EC9 RID: 7881
		[ProtoEnum(Name = "StringTableId_Msg_PlayerLevelUnlock", Value = 1066)]
		StringTableId_Msg_PlayerLevelUnlock,
		// Token: 0x04001ECA RID: 7882
		[ProtoEnum(Name = "StringTableId_Msg_LevelFinishUnlock", Value = 1067)]
		StringTableId_Msg_LevelFinishUnlock,
		// Token: 0x04001ECB RID: 7883
		[ProtoEnum(Name = "StringTableId_Msg_PutInEnchantStone", Value = 1068)]
		StringTableId_Msg_PutInEnchantStone,
		// Token: 0x04001ECC RID: 7884
		[ProtoEnum(Name = "StringTableId_Msg_EnchantStoneNotEnough", Value = 1069)]
		StringTableId_Msg_EnchantStoneNotEnough,
		// Token: 0x04001ECD RID: 7885
		[ProtoEnum(Name = "StringTableId_Msg_AddExpTitleTip", Value = 1070)]
		StringTableId_Msg_AddExpTitleTip,
		// Token: 0x04001ECE RID: 7886
		[ProtoEnum(Name = "StringTableId_Msg_AddExpContentTip", Value = 1071)]
		StringTableId_Msg_AddExpContentTip,
		// Token: 0x04001ECF RID: 7887
		[ProtoEnum(Name = "StringTableId_Msg_MissionNotOpen", Value = 1072)]
		StringTableId_Msg_MissionNotOpen,
		// Token: 0x04001ED0 RID: 7888
		[ProtoEnum(Name = "StringTableId_Msg_OpenServiceActivityClosed", Value = 1073)]
		StringTableId_Msg_OpenServiceActivityClosed,
		// Token: 0x04001ED1 RID: 7889
		[ProtoEnum(Name = "StringTableId_Msg_HeroAssistantTaskStop", Value = 1074)]
		StringTableId_Msg_HeroAssistantTaskStop,
		// Token: 0x04001ED2 RID: 7890
		[ProtoEnum(Name = "StringTableId_Msg_ConfessionFeatureClosed", Value = 1075)]
		StringTableId_Msg_ConfessionFeatureClosed,
		// Token: 0x04001ED3 RID: 7891
		[ProtoEnum(Name = "StringTableId_Msg_HeroDungeonNotOpenNow", Value = 1077)]
		StringTableId_Msg_HeroDungeonNotOpenNow = 1077,
		// Token: 0x04001ED4 RID: 7892
		[ProtoEnum(Name = "StringTableId_Msg_HeroFavorabilityLimit", Value = 1078)]
		StringTableId_Msg_HeroFavorabilityLimit,
		// Token: 0x04001ED5 RID: 7893
		[ProtoEnum(Name = "StringTableId_Msg_EnhanceItemsHaveSR", Value = 1079)]
		StringTableId_Msg_EnhanceItemsHaveSR,
		// Token: 0x04001ED6 RID: 7894
		[ProtoEnum(Name = "StringTableId_Msg_EnhanceItemsExpOverFlow1", Value = 1080)]
		StringTableId_Msg_EnhanceItemsExpOverFlow1,
		// Token: 0x04001ED7 RID: 7895
		[ProtoEnum(Name = "StringTableId_Msg_EnhanceItemsExpOverFlow2", Value = 1081)]
		StringTableId_Msg_EnhanceItemsExpOverFlow2,
		// Token: 0x04001ED8 RID: 7896
		[ProtoEnum(Name = "StringTableId_Msg_ChangeCrystalToTicketTip", Value = 1082)]
		StringTableId_Msg_ChangeCrystalToTicketTip,
		// Token: 0x04001ED9 RID: 7897
		[ProtoEnum(Name = "StringTableId_Msg_CrystalAndTicketNotEnoughTip", Value = 1083)]
		StringTableId_Msg_CrystalAndTicketNotEnoughTip,
		// Token: 0x04001EDA RID: 7898
		[ProtoEnum(Name = "StringTableId_Msg_SkinTicketNotEnough", Value = 1084)]
		StringTableId_Msg_SkinTicketNotEnough,
		// Token: 0x04001EDB RID: 7899
		[ProtoEnum(Name = "StringTableId_Msg_AllJobCanUse", Value = 1085)]
		StringTableId_Msg_AllJobCanUse,
		// Token: 0x04001EDC RID: 7900
		[ProtoEnum(Name = "StringTableId_Msg_AlchemyNoticeText", Value = 1086)]
		StringTableId_Msg_AlchemyNoticeText,
		// Token: 0x04001EDD RID: 7901
		[ProtoEnum(Name = "StringTableId_Battle_SelectTarget", Value = 1100)]
		StringTableId_Battle_SelectTarget = 1100,
		// Token: 0x04001EDE RID: 7902
		[ProtoEnum(Name = "StringTableId_Battle_SelectPosition", Value = 1101)]
		StringTableId_Battle_SelectPosition,
		// Token: 0x04001EDF RID: 7903
		[ProtoEnum(Name = "StringTableId_Battle_ConfirmSkill", Value = 1102)]
		StringTableId_Battle_ConfirmSkill,
		// Token: 0x04001EE0 RID: 7904
		[ProtoEnum(Name = "StringTableId_Battle_SelectTeleport", Value = 1103)]
		StringTableId_Battle_SelectTeleport,
		// Token: 0x04001EE1 RID: 7905
		[ProtoEnum(Name = "StringTableId_Battle_SkillIsCooldown", Value = 1104)]
		StringTableId_Battle_SkillIsCooldown,
		// Token: 0x04001EE2 RID: 7906
		[ProtoEnum(Name = "StringTableId_Battle_NoBattleHero", Value = 1105)]
		StringTableId_Battle_NoBattleHero,
		// Token: 0x04001EE3 RID: 7907
		[ProtoEnum(Name = "StringTableId_Battle_BattleHeroNotFull", Value = 1106)]
		StringTableId_Battle_BattleHeroNotFull,
		// Token: 0x04001EE4 RID: 7908
		[ProtoEnum(Name = "StringTableId_Battle_EndAllAction", Value = 1107)]
		StringTableId_Battle_EndAllAction,
		// Token: 0x04001EE5 RID: 7909
		[ProtoEnum(Name = "StringTableId_Battle_ConfirmExitBattle", Value = 1108)]
		StringTableId_Battle_ConfirmExitBattle,
		// Token: 0x04001EE6 RID: 7910
		[ProtoEnum(Name = "StringTableId_Battle_SkillIsBanned", Value = 1109)]
		StringTableId_Battle_SkillIsBanned,
		// Token: 0x04001EE7 RID: 7911
		[ProtoEnum(Name = "StringTableId_Battle_CanNotDragNPC", Value = 1110)]
		StringTableId_Battle_CanNotDragNPC,
		// Token: 0x04001EE8 RID: 7912
		[ProtoEnum(Name = "StringTableId_Battle_CanNotDragEnforceHero", Value = 1111)]
		StringTableId_Battle_CanNotDragEnforceHero,
		// Token: 0x04001EE9 RID: 7913
		[ProtoEnum(Name = "StringTableId_Battle_CanNotUsePassiveSkill", Value = 1112)]
		StringTableId_Battle_CanNotUsePassiveSkill,
		// Token: 0x04001EEA RID: 7914
		[ProtoEnum(Name = "StringTableId_Battle_ConfirmExitArenaBattleCostTicket", Value = 1113)]
		StringTableId_Battle_ConfirmExitArenaBattleCostTicket,
		// Token: 0x04001EEB RID: 7915
		[ProtoEnum(Name = "StringTableId_Battle_StageHeroCountMax", Value = 1114)]
		StringTableId_Battle_StageHeroCountMax,
		// Token: 0x04001EEC RID: 7916
		[ProtoEnum(Name = "StringTableId_Battle_ArenaAutoBattle", Value = 1115)]
		StringTableId_Battle_ArenaAutoBattle,
		// Token: 0x04001EED RID: 7917
		[ProtoEnum(Name = "StringTableId_Battle_ArenaAttackerGiveup", Value = 1116)]
		StringTableId_Battle_ArenaAttackerGiveup,
		// Token: 0x04001EEE RID: 7918
		[ProtoEnum(Name = "StringTableId_Battle_NoStrategy", Value = 1117)]
		StringTableId_Battle_NoStrategy,
		// Token: 0x04001EEF RID: 7919
		[ProtoEnum(Name = "StringTableId_Battle_ConfirmExitBattleCostEnergy", Value = 1118)]
		StringTableId_Battle_ConfirmExitBattleCostEnergy,
		// Token: 0x04001EF0 RID: 7920
		[ProtoEnum(Name = "StringTableId_Battle_ConfirmExitPVPBattleCostScore", Value = 1119)]
		StringTableId_Battle_ConfirmExitPVPBattleCostScore,
		// Token: 0x04001EF1 RID: 7921
		[ProtoEnum(Name = "StringTableId_Battle_CanNotStageHero", Value = 1120)]
		StringTableId_Battle_CanNotStageHero,
		// Token: 0x04001EF2 RID: 7922
		[ProtoEnum(Name = "StringTableId_Battle_RealTimePVPPlayerGiveup", Value = 1121)]
		StringTableId_Battle_RealTimePVPPlayerGiveup,
		// Token: 0x04001EF3 RID: 7923
		[ProtoEnum(Name = "StringTableId_Battle_CanNotBanProtectedHero", Value = 1122)]
		StringTableId_Battle_CanNotBanProtectedHero,
		// Token: 0x04001EF4 RID: 7924
		[ProtoEnum(Name = "StringTableId_Battle_Reconnect", Value = 1123)]
		StringTableId_Battle_Reconnect,
		// Token: 0x04001EF5 RID: 7925
		[ProtoEnum(Name = "StringTableId_Battle_ConfirmExitTreasureMapBattleCostEnergy", Value = 1124)]
		StringTableId_Battle_ConfirmExitTreasureMapBattleCostEnergy,
		// Token: 0x04001EF6 RID: 7926
		[ProtoEnum(Name = "StringTableId_Battle_SelfQuitBattle", Value = 1125)]
		StringTableId_Battle_SelfQuitBattle,
		// Token: 0x04001EF7 RID: 7927
		[ProtoEnum(Name = "StringTableId_Battle_ScoreHeroBonus", Value = 1126)]
		StringTableId_Battle_ScoreHeroBonus,
		// Token: 0x04001EF8 RID: 7928
		[ProtoEnum(Name = "StringTableId_Battle_ScoreDailyBonus", Value = 1127)]
		StringTableId_Battle_ScoreDailyBonus,
		// Token: 0x04001EF9 RID: 7929
		[ProtoEnum(Name = "StringTableId_Battle_ScoreDailyHeroBonus", Value = 1128)]
		StringTableId_Battle_ScoreDailyHeroBonus,
		// Token: 0x04001EFA RID: 7930
		[ProtoEnum(Name = "StringTableId_Battle_AtLeastOneHero", Value = 1129)]
		StringTableId_Battle_AtLeastOneHero,
		// Token: 0x04001EFB RID: 7931
		[ProtoEnum(Name = "StringTableId_Battle_ConfirmExitGuildMassiveCombatBattle", Value = 1130)]
		StringTableId_Battle_ConfirmExitGuildMassiveCombatBattle,
		// Token: 0x04001EFC RID: 7932
		[ProtoEnum(Name = "StringTableId_DialogBox_Ok", Value = 1200)]
		StringTableId_DialogBox_Ok = 1200,
		// Token: 0x04001EFD RID: 7933
		[ProtoEnum(Name = "StringTableId_DialogBox_Cancel", Value = 1201)]
		StringTableId_DialogBox_Cancel,
		// Token: 0x04001EFE RID: 7934
		[ProtoEnum(Name = "StringTableId_UnchartedScore_RecommendHeroDesc", Value = 1300)]
		StringTableId_UnchartedScore_RecommendHeroDesc = 1300,
		// Token: 0x04001EFF RID: 7935
		[ProtoEnum(Name = "StringTableId_UnchartedScore_LevelComplete", Value = 1301)]
		StringTableId_UnchartedScore_LevelComplete,
		// Token: 0x04001F00 RID: 7936
		[ProtoEnum(Name = "StringTableId_UnchartedScore_LevelOpenDay", Value = 1302)]
		StringTableId_UnchartedScore_LevelOpenDay,
		// Token: 0x04001F01 RID: 7937
		[ProtoEnum(Name = "StringTableId_UnchartedScore_NeedCompletePrevLevel", Value = 1303)]
		StringTableId_UnchartedScore_NeedCompletePrevLevel,
		// Token: 0x04001F02 RID: 7938
		[ProtoEnum(Name = "StringTableId_UnchartedScore_MonsterLevel", Value = 1304)]
		StringTableId_UnchartedScore_MonsterLevel,
		// Token: 0x04001F03 RID: 7939
		[ProtoEnum(Name = "StringTableId_ClimbTower_RewardPreviewDesc", Value = 1400)]
		StringTableId_ClimbTower_RewardPreviewDesc = 1400,
		// Token: 0x04001F04 RID: 7940
		[ProtoEnum(Name = "StringTableId_ClimbTower_RaidReachFloorMax", Value = 1401)]
		StringTableId_ClimbTower_RaidReachFloorMax,
		// Token: 0x04001F05 RID: 7941
		[ProtoEnum(Name = "StringTableId_ClimbTower_Flush", Value = 1402)]
		StringTableId_ClimbTower_Flush,
		// Token: 0x04001F06 RID: 7942
		[ProtoEnum(Name = "StringTableId_ClimbTower_RaidFloor", Value = 1403)]
		StringTableId_ClimbTower_RaidFloor,
		// Token: 0x04001F07 RID: 7943
		[ProtoEnum(Name = "StringTableId_Chat_Banned", Value = 2001)]
		StringTableId_Chat_Banned = 2001,
		// Token: 0x04001F08 RID: 7944
		[ProtoEnum(Name = "StringTableId_Chat_ChatChannelNotPermission", Value = 2002)]
		StringTableId_Chat_ChatChannelNotPermission,
		// Token: 0x04001F09 RID: 7945
		[ProtoEnum(Name = "StringTableId_Chat_PlayerNotEnoughLevel", Value = 2003)]
		StringTableId_Chat_PlayerNotEnoughLevel,
		// Token: 0x04001F0A RID: 7946
		[ProtoEnum(Name = "StringTableId_Chat_SendTooOften", Value = 2004)]
		StringTableId_Chat_SendTooOften,
		// Token: 0x04001F0B RID: 7947
		[ProtoEnum(Name = "StringTableId_Chat_TimeSpanLessThanAnHour", Value = 2005)]
		StringTableId_Chat_TimeSpanLessThanAnHour,
		// Token: 0x04001F0C RID: 7948
		[ProtoEnum(Name = "StringTableId_Chat_TimeSpanLessThanADay", Value = 2006)]
		StringTableId_Chat_TimeSpanLessThanADay,
		// Token: 0x04001F0D RID: 7949
		[ProtoEnum(Name = "StringTableId_Chat_TimeSpanMoreThanADay", Value = 2007)]
		StringTableId_Chat_TimeSpanMoreThanADay,
		// Token: 0x04001F0E RID: 7950
		[ProtoEnum(Name = "StringTableId_Chat_MicrophoneNotFound", Value = 2008)]
		StringTableId_Chat_MicrophoneNotFound,
		// Token: 0x04001F0F RID: 7951
		[ProtoEnum(Name = "StringTableId_Chat_UserInBlacklist", Value = 2009)]
		StringTableId_Chat_UserInBlacklist,
		// Token: 0x04001F10 RID: 7952
		[ProtoEnum(Name = "StringTableId_Chat_NoIOSMicrophonePermission", Value = 2010)]
		StringTableId_Chat_NoIOSMicrophonePermission,
		// Token: 0x04001F11 RID: 7953
		[ProtoEnum(Name = "StringTableId_Chat_NoAndroidMicrophonePermission", Value = 2011)]
		StringTableId_Chat_NoAndroidMicrophonePermission,
		// Token: 0x04001F12 RID: 7954
		[ProtoEnum(Name = "StringTableId_Chat_RequireJoinGuild", Value = 2012)]
		StringTableId_Chat_RequireJoinGuild,
		// Token: 0x04001F13 RID: 7955
		[ProtoEnum(Name = "StringTableId_Mail_IsExpired", Value = 2101)]
		StringTableId_Mail_IsExpired = 2101,
		// Token: 0x04001F14 RID: 7956
		[ProtoEnum(Name = "StringTableId_Mail_AttachmentHadGot", Value = 2102)]
		StringTableId_Mail_AttachmentHadGot,
		// Token: 0x04001F15 RID: 7957
		[ProtoEnum(Name = "StringTableId_Mail_NoMail", Value = 2103)]
		StringTableId_Mail_NoMail,
		// Token: 0x04001F16 RID: 7958
		[ProtoEnum(Name = "StringTableId_AppScore_DialogBoxTips", Value = 2201)]
		StringTableId_AppScore_DialogBoxTips = 2201,
		// Token: 0x04001F17 RID: 7959
		[ProtoEnum(Name = "StringTableId_AppScore_EnterSuggest", Value = 2202)]
		StringTableId_AppScore_EnterSuggest,
		// Token: 0x04001F18 RID: 7960
		[ProtoEnum(Name = "StringTableId_Store_ItemCount", Value = 3001)]
		StringTableId_Store_ItemCount = 3001,
		// Token: 0x04001F19 RID: 7961
		[ProtoEnum(Name = "StringTableId_Store_Limit_Week", Value = 3002)]
		StringTableId_Store_Limit_Week,
		// Token: 0x04001F1A RID: 7962
		[ProtoEnum(Name = "StringTableId_Store_Limit_Fixed", Value = 3003)]
		StringTableId_Store_Limit_Fixed,
		// Token: 0x04001F1B RID: 7963
		[ProtoEnum(Name = "StringTableId_Store_Limit_Month", Value = 3004)]
		StringTableId_Store_Limit_Month,
		// Token: 0x04001F1C RID: 7964
		[ProtoEnum(Name = "StringTableId_Store_Limit_Once", Value = 3005)]
		StringTableId_Store_Limit_Once,
		// Token: 0x04001F1D RID: 7965
		[ProtoEnum(Name = "StringTableId_Store_TimeOut", Value = 3006)]
		StringTableId_Store_TimeOut,
		// Token: 0x04001F1E RID: 7966
		[ProtoEnum(Name = "StringTableId_Store_Limit_Forever", Value = 3007)]
		StringTableId_Store_Limit_Forever,
		// Token: 0x04001F1F RID: 7967
		[ProtoEnum(Name = "StringTableId_Store_RefreshTime", Value = 3008)]
		StringTableId_Store_RefreshTime,
		// Token: 0x04001F20 RID: 7968
		[ProtoEnum(Name = "StringTableId_Store_ApplePrivacyLink", Value = 3009)]
		StringTableId_Store_ApplePrivacyLink,
		// Token: 0x04001F21 RID: 7969
		[ProtoEnum(Name = "StringTableId_Store_AppleSubcribeCancelLink", Value = 3010)]
		StringTableId_Store_AppleSubcribeCancelLink,
		// Token: 0x04001F22 RID: 7970
		[ProtoEnum(Name = "StringTableId_TrainingHouse_CoachFavorability", Value = 4001)]
		StringTableId_TrainingHouse_CoachFavorability = 4001,
		// Token: 0x04001F23 RID: 7971
		[ProtoEnum(Name = "StringTableId_TrainingHouse_InstrumentUnlockFavorability", Value = 4002)]
		StringTableId_TrainingHouse_InstrumentUnlockFavorability,
		// Token: 0x04001F24 RID: 7972
		[ProtoEnum(Name = "StringTableId_ClientVersionFormatString", Value = 5001)]
		StringTableId_ClientVersionFormatString = 5001,
		// Token: 0x04001F25 RID: 7973
		[ProtoEnum(Name = "StringTableId_ConnectServerFailed", Value = 5002)]
		StringTableId_ConnectServerFailed,
		// Token: 0x04001F26 RID: 7974
		[ProtoEnum(Name = "StringTableId_AccountNameOrPasswordWrong", Value = 5003)]
		StringTableId_AccountNameOrPasswordWrong,
		// Token: 0x04001F27 RID: 7975
		[ProtoEnum(Name = "StringTableId_AccountBan", Value = 5004)]
		StringTableId_AccountBan,
		// Token: 0x04001F28 RID: 7976
		[ProtoEnum(Name = "StringTableId_InvalidClientVersion", Value = 5005)]
		StringTableId_InvalidClientVersion,
		// Token: 0x04001F29 RID: 7977
		[ProtoEnum(Name = "StringTableId_DownloadAnnounceFailed", Value = 5006)]
		StringTableId_DownloadAnnounceFailed,
		// Token: 0x04001F2A RID: 7978
		[ProtoEnum(Name = "StringTableId_DownloadServerListFailed", Value = 5007)]
		StringTableId_DownloadServerListFailed,
		// Token: 0x04001F2B RID: 7979
		[ProtoEnum(Name = "StringTableId_DisconnectedByServerForCheat", Value = 5008)]
		StringTableId_DisconnectedByServerForCheat,
		// Token: 0x04001F2C RID: 7980
		[ProtoEnum(Name = "StringTableId_DisconnectedByServer", Value = 5009)]
		StringTableId_DisconnectedByServer,
		// Token: 0x04001F2D RID: 7981
		[ProtoEnum(Name = "StringTableId_PleaseUpdateClient", Value = 5010)]
		StringTableId_PleaseUpdateClient,
		// Token: 0x04001F2E RID: 7982
		[ProtoEnum(Name = "StringTableId_DisconnectedBySameAccountLogin", Value = 5011)]
		StringTableId_DisconnectedBySameAccountLogin,
		// Token: 0x04001F2F RID: 7983
		[ProtoEnum(Name = "StringTableId_MakingBigAccount", Value = 5020)]
		StringTableId_MakingBigAccount = 5020,
		// Token: 0x04001F30 RID: 7984
		[ProtoEnum(Name = "StringTableId_MakeBigAccountFinished", Value = 5021)]
		StringTableId_MakeBigAccountFinished,
		// Token: 0x04001F31 RID: 7985
		[ProtoEnum(Name = "StringTableId_ReportingBug", Value = 5022)]
		StringTableId_ReportingBug,
		// Token: 0x04001F32 RID: 7986
		[ProtoEnum(Name = "StringTableId_ReportBugFinished", Value = 5023)]
		StringTableId_ReportBugFinished,
		// Token: 0x04001F33 RID: 7987
		[ProtoEnum(Name = "StringTableId_PlayerInfo_PlayerCrystalNotEnough", Value = 6001)]
		StringTableId_PlayerInfo_PlayerCrystalNotEnough = 6001,
		// Token: 0x04001F34 RID: 7988
		[ProtoEnum(Name = "StringTableId_PlayerInfo_PlayerNameInvalid", Value = 6002)]
		StringTableId_PlayerInfo_PlayerNameInvalid,
		// Token: 0x04001F35 RID: 7989
		[ProtoEnum(Name = "StringTableId_PlayerInfo_IsAlreadyTheHeadIcon", Value = 6003)]
		StringTableId_PlayerInfo_IsAlreadyTheHeadIcon,
		// Token: 0x04001F36 RID: 7990
		[ProtoEnum(Name = "StringTableId_PlayerSimpleInfo_PlayerNotOnlineCanNotPVP", Value = 6101)]
		StringTableId_PlayerSimpleInfo_PlayerNotOnlineCanNotPVP = 6101,
		// Token: 0x04001F37 RID: 7991
		[ProtoEnum(Name = "StringTableId_PlayerSimpleInfo_InBattleCanNotPVP", Value = 6102)]
		StringTableId_PlayerSimpleInfo_InBattleCanNotPVP,
		// Token: 0x04001F38 RID: 7992
		[ProtoEnum(Name = "StringTableId_PlayerSimpleInfo_InTeamRoomCanNotPVP", Value = 6103)]
		StringTableId_PlayerSimpleInfo_InTeamRoomCanNotPVP,
		// Token: 0x04001F39 RID: 7993
		[ProtoEnum(Name = "StringTableId_PlayerInfo_PreviewHeadPortrait", Value = 6004)]
		StringTableId_PlayerInfo_PreviewHeadPortrait = 6004,
		// Token: 0x04001F3A RID: 7994
		[ProtoEnum(Name = "StringTableId_Rift_NormalMode", Value = 7001)]
		StringTableId_Rift_NormalMode = 7001,
		// Token: 0x04001F3B RID: 7995
		[ProtoEnum(Name = "StringTableId_Rift_HardMode", Value = 7002)]
		StringTableId_Rift_HardMode,
		// Token: 0x04001F3C RID: 7996
		[ProtoEnum(Name = "StringTableId_Rift_HardModeUnlock", Value = 7003)]
		StringTableId_Rift_HardModeUnlock,
		// Token: 0x04001F3D RID: 7997
		[ProtoEnum(Name = "StringTableId_Rift_LevelUnlock", Value = 7004)]
		StringTableId_Rift_LevelUnlock,
		// Token: 0x04001F3E RID: 7998
		[ProtoEnum(Name = "StringTableId_Rift_Close", Value = 7005)]
		StringTableId_Rift_Close,
		// Token: 0x04001F3F RID: 7999
		[ProtoEnum(Name = "StringTableId_Rift_ChapterOpen", Value = 7006)]
		StringTableId_Rift_ChapterOpen,
		// Token: 0x04001F40 RID: 8000
		[ProtoEnum(Name = "StringTableId_Raid_LackGoods", Value = 7007)]
		StringTableId_Raid_LackGoods,
		// Token: 0x04001F41 RID: 8001
		[ProtoEnum(Name = "StringTableId_Raid_EnoughGoods", Value = 7008)]
		StringTableId_Raid_EnoughGoods,
		// Token: 0x04001F42 RID: 8002
		[ProtoEnum(Name = "StringTableId_Raid_GainGoods", Value = 7009)]
		StringTableId_Raid_GainGoods,
		// Token: 0x04001F43 RID: 8003
		[ProtoEnum(Name = "StringTableId_PlayerInfo_VoicePackage", Value = 9001)]
		StringTableId_PlayerInfo_VoicePackage = 9001,
		// Token: 0x04001F44 RID: 8004
		[ProtoEnum(Name = "StringTableId_PlayerInfo_RedeemCode", Value = 9002)]
		StringTableId_PlayerInfo_RedeemCode,
		// Token: 0x04001F45 RID: 8005
		[ProtoEnum(Name = "StringTableId_PlayerInfo_Share", Value = 9003)]
		StringTableId_PlayerInfo_Share,
		// Token: 0x04001F46 RID: 8006
		[ProtoEnum(Name = "StringTableId_PlayerInfo_Forum", Value = 9004)]
		StringTableId_PlayerInfo_Forum,
		// Token: 0x04001F47 RID: 8007
		[ProtoEnum(Name = "StringTableId_PlayerInfo_Version", Value = 9005)]
		StringTableId_PlayerInfo_Version,
		// Token: 0x04001F48 RID: 8008
		[ProtoEnum(Name = "StringTableId_CanNotShareOnWindows", Value = 9006)]
		StringTableId_CanNotShareOnWindows,
		// Token: 0x04001F49 RID: 8009
		[ProtoEnum(Name = "StringTableId_TrainingHouse_AnikiGymUnlock", Value = 10001)]
		StringTableId_TrainingHouse_AnikiGymUnlock = 10001,
		// Token: 0x04001F4A RID: 8010
		[ProtoEnum(Name = "StringTableId_Activity_LevelUpGoal", Value = 12001)]
		StringTableId_Activity_LevelUpGoal = 12001,
		// Token: 0x04001F4B RID: 8011
		[ProtoEnum(Name = "StringTableId_Activity_LevelUpProgress", Value = 12002)]
		StringTableId_Activity_LevelUpProgress,
		// Token: 0x04001F4C RID: 8012
		[ProtoEnum(Name = "StringTableId_Activity_AccumulateDaysGoal", Value = 12003)]
		StringTableId_Activity_AccumulateDaysGoal,
		// Token: 0x04001F4D RID: 8013
		[ProtoEnum(Name = "StringTableId_Activity_AccumulateDaysProgress", Value = 12004)]
		StringTableId_Activity_AccumulateDaysProgress,
		// Token: 0x04001F4E RID: 8014
		[ProtoEnum(Name = "StringTableId_Activity_SpecificDaysGoal", Value = 12005)]
		StringTableId_Activity_SpecificDaysGoal,
		// Token: 0x04001F4F RID: 8015
		[ProtoEnum(Name = "StringTableId_Activity_HaveExchangeTimes", Value = 12006)]
		StringTableId_Activity_HaveExchangeTimes,
		// Token: 0x04001F50 RID: 8016
		[ProtoEnum(Name = "StringTableId_Activity_HaveNoExchangeTimes", Value = 12007)]
		StringTableId_Activity_HaveNoExchangeTimes,
		// Token: 0x04001F51 RID: 8017
		[ProtoEnum(Name = "StringTableId_Ranking_HeroPowerWithoutName", Value = 13001)]
		StringTableId_Ranking_HeroPowerWithoutName = 13001,
		// Token: 0x04001F52 RID: 8018
		[ProtoEnum(Name = "StringTableId_Ranking_HeroPowerWithName", Value = 13002)]
		StringTableId_Ranking_HeroPowerWithName,
		// Token: 0x04001F53 RID: 8019
		[ProtoEnum(Name = "StringTableId_Ranking_UnReach", Value = 13003)]
		StringTableId_Ranking_UnReach,
		// Token: 0x04001F54 RID: 8020
		[ProtoEnum(Name = "StringTableId_BusinessCardInitialDesc", Value = 13004)]
		StringTableId_BusinessCardInitialDesc,
		// Token: 0x04001F55 RID: 8021
		[ProtoEnum(Name = "StringTableId_Chat_EnterWorldRoom", Value = 13005)]
		StringTableId_Chat_EnterWorldRoom,
		// Token: 0x04001F56 RID: 8022
		[ProtoEnum(Name = "StringTableId_Chat_ChooseGroupTip", Value = 13006)]
		StringTableId_Chat_ChooseGroupTip,
		// Token: 0x04001F57 RID: 8023
		[ProtoEnum(Name = "StringTableId_Chat_ChoosePrivatePlayerTip", Value = 13007)]
		StringTableId_Chat_ChoosePrivatePlayerTip,
		// Token: 0x04001F58 RID: 8024
		[ProtoEnum(Name = "StringTableId_Chat_VoiceRecordCountDownTip", Value = 13008)]
		StringTableId_Chat_VoiceRecordCountDownTip,
		// Token: 0x04001F59 RID: 8025
		[ProtoEnum(Name = "StringTableId_Chat_CurrentWorldRoom", Value = 13009)]
		StringTableId_Chat_CurrentWorldRoom,
		// Token: 0x04001F5A RID: 8026
		[ProtoEnum(Name = "StringTableId_Chat_VoiceTranslateToTextFail", Value = 13010)]
		StringTableId_Chat_VoiceTranslateToTextFail,
		// Token: 0x04001F5B RID: 8027
		[ProtoEnum(Name = "StringTableId_XunfeiAppIdAndroid", Value = 13011)]
		StringTableId_XunfeiAppIdAndroid,
		// Token: 0x04001F5C RID: 8028
		[ProtoEnum(Name = "StringTableId_XunfeiAppIdIOS", Value = 13012)]
		StringTableId_XunfeiAppIdIOS,
		// Token: 0x04001F5D RID: 8029
		[ProtoEnum(Name = "StringTableId_ClientPauseReloginTimeout", Value = 13013)]
		StringTableId_ClientPauseReloginTimeout,
		// Token: 0x04001F5E RID: 8030
		[ProtoEnum(Name = "StringTableId_RechargePayCancel", Value = 13014)]
		StringTableId_RechargePayCancel,
		// Token: 0x04001F5F RID: 8031
		[ProtoEnum(Name = "StringTableId_RechargePayFailed", Value = 13015)]
		StringTableId_RechargePayFailed,
		// Token: 0x04001F60 RID: 8032
		[ProtoEnum(Name = "StringTableId_RechargePaySuccess", Value = 13016)]
		StringTableId_RechargePaySuccess,
		// Token: 0x04001F61 RID: 8033
		[ProtoEnum(Name = "StringTableId_FirstBuyPresent", Value = 13017)]
		StringTableId_FirstBuyPresent,
		// Token: 0x04001F62 RID: 8034
		[ProtoEnum(Name = "StringTableId_ExtraBuyPresent", Value = 13018)]
		StringTableId_ExtraBuyPresent,
		// Token: 0x04001F63 RID: 8035
		[ProtoEnum(Name = "StringTableId_Store_LeftDay", Value = 13019)]
		StringTableId_Store_LeftDay,
		// Token: 0x04001F64 RID: 8036
		[ProtoEnum(Name = "StringTableId_Raffle_NotEnoughCrystal", Value = 13020)]
		StringTableId_Raffle_NotEnoughCrystal,
		// Token: 0x04001F65 RID: 8037
		[ProtoEnum(Name = "StringTableId_Raffle_NotEnoughCrystalRechargeConfirm", Value = 13021)]
		StringTableId_Raffle_NotEnoughCrystalRechargeConfirm,
		// Token: 0x04001F66 RID: 8038
		[ProtoEnum(Name = "StringTableId_Raffle_NotEnoughItem", Value = 13022)]
		StringTableId_Raffle_NotEnoughItem,
		// Token: 0x04001F67 RID: 8039
		[ProtoEnum(Name = "StringTableId_Raffle_Level0", Value = 13023)]
		StringTableId_Raffle_Level0,
		// Token: 0x04001F68 RID: 8040
		[ProtoEnum(Name = "StringTableId_Raffle_Level1", Value = 13024)]
		StringTableId_Raffle_Level1,
		// Token: 0x04001F69 RID: 8041
		[ProtoEnum(Name = "StringTableId_Raffle_Level2", Value = 13025)]
		StringTableId_Raffle_Level2,
		// Token: 0x04001F6A RID: 8042
		[ProtoEnum(Name = "StringTableId_Raffle_Level3", Value = 13026)]
		StringTableId_Raffle_Level3,
		// Token: 0x04001F6B RID: 8043
		[ProtoEnum(Name = "StringTableId_Raffle_Level4", Value = 13027)]
		StringTableId_Raffle_Level4,
		// Token: 0x04001F6C RID: 8044
		[ProtoEnum(Name = "StringTableId_Raffle_Level5", Value = 13028)]
		StringTableId_Raffle_Level5,
		// Token: 0x04001F6D RID: 8045
		[ProtoEnum(Name = "StringTableId_Raffle_Level6", Value = 13029)]
		StringTableId_Raffle_Level6,
		// Token: 0x04001F6E RID: 8046
		[ProtoEnum(Name = "StringTableId_Raffle_CostTitle", Value = 13030)]
		StringTableId_Raffle_CostTitle,
		// Token: 0x04001F6F RID: 8047
		[ProtoEnum(Name = "StringTableId_Raffle_FreeCountTitle", Value = 13031)]
		StringTableId_Raffle_FreeCountTitle,
		// Token: 0x04001F70 RID: 8048
		[ProtoEnum(Name = "StringTableId_Chat_AboveHistoryMessage", Value = 13032)]
		StringTableId_Chat_AboveHistoryMessage,
		// Token: 0x04001F71 RID: 8049
		[ProtoEnum(Name = "StringTableId_Chat_InputLengthLimit", Value = 13033)]
		StringTableId_Chat_InputLengthLimit,
		// Token: 0x04001F72 RID: 8050
		[ProtoEnum(Name = "StringTableId_StoreSkin_BuySuccess", Value = 13034)]
		StringTableId_StoreSkin_BuySuccess,
		// Token: 0x04001F73 RID: 8051
		[ProtoEnum(Name = "StringTableId_Activity_AccumulateRechargeGoal", Value = 13035)]
		StringTableId_Activity_AccumulateRechargeGoal,
		// Token: 0x04001F74 RID: 8052
		[ProtoEnum(Name = "StringTableId_Activity_AccumulateRechargeProgress", Value = 13036)]
		StringTableId_Activity_AccumulateRechargeProgress,
		// Token: 0x04001F75 RID: 8053
		[ProtoEnum(Name = "StringTableId_Activity_AccumulateConsumeCrystalGoal", Value = 13037)]
		StringTableId_Activity_AccumulateConsumeCrystalGoal,
		// Token: 0x04001F76 RID: 8054
		[ProtoEnum(Name = "StringTableId_Activity_AccumulateConsumeCrystalProgress", Value = 13038)]
		StringTableId_Activity_AccumulateConsumeCrystalProgress,
		// Token: 0x04001F77 RID: 8055
		[ProtoEnum(Name = "StringTableId_HeadIconChangeSuccess", Value = 13039)]
		StringTableId_HeadIconChangeSuccess,
		// Token: 0x04001F78 RID: 8056
		[ProtoEnum(Name = "StringTableId_RechargeItemTitle", Value = 13040)]
		StringTableId_RechargeItemTitle,
		// Token: 0x04001F79 RID: 8057
		[ProtoEnum(Name = "StringTableId_HeroDefaultCharSkinDesc", Value = 13041)]
		StringTableId_HeroDefaultCharSkinDesc,
		// Token: 0x04001F7A RID: 8058
		[ProtoEnum(Name = "StringTableId_SoldierDefaultDesc", Value = 13042)]
		StringTableId_SoldierDefaultDesc,
		// Token: 0x04001F7B RID: 8059
		[ProtoEnum(Name = "StringTableId_SoldierDefaultPathDesc", Value = 13043)]
		StringTableId_SoldierDefaultPathDesc,
		// Token: 0x04001F7C RID: 8060
		[ProtoEnum(Name = "StringTableId_DefaultName", Value = 13044)]
		StringTableId_DefaultName,
		// Token: 0x04001F7D RID: 8061
		[ProtoEnum(Name = "StringTableId_ActivityCardPoolStopTime", Value = 13045)]
		StringTableId_ActivityCardPoolStopTime,
		// Token: 0x04001F7E RID: 8062
		[ProtoEnum(Name = "StringTableId_Msg_CrystalNotEnough", Value = 13046)]
		StringTableId_Msg_CrystalNotEnough,
		// Token: 0x04001F7F RID: 8063
		[ProtoEnum(Name = "StringTableId_Summon_LastDays", Value = 13047)]
		StringTableId_Summon_LastDays,
		// Token: 0x04001F80 RID: 8064
		[ProtoEnum(Name = "StringTableId_CurrentJobCantWearSkin", Value = 13048)]
		StringTableId_CurrentJobCantWearSkin,
		// Token: 0x04001F81 RID: 8065
		[ProtoEnum(Name = "StringTableId_NoEnchaneItemCanAdd", Value = 13049)]
		StringTableId_NoEnchaneItemCanAdd,
		// Token: 0x04001F82 RID: 8066
		[ProtoEnum(Name = "StringTableId_HeroNotHaveThisSoldierCantWearSkin", Value = 13050)]
		StringTableId_HeroNotHaveThisSoldierCantWearSkin,
		// Token: 0x04001F83 RID: 8067
		[ProtoEnum(Name = "StringTableId_Common_LessThan", Value = 13051)]
		StringTableId_Common_LessThan,
		// Token: 0x04001F84 RID: 8068
		[ProtoEnum(Name = "StringTableId_Common_Remain", Value = 13052)]
		StringTableId_Common_Remain,
		// Token: 0x04001F85 RID: 8069
		[ProtoEnum(Name = "StringTableId_ARTeamShowTip", Value = 13054)]
		StringTableId_ARTeamShowTip = 13054,
		// Token: 0x04001F86 RID: 8070
		[ProtoEnum(Name = "StringTableId_CommitMemoryEssenceTip", Value = 13055)]
		StringTableId_CommitMemoryEssenceTip,
		// Token: 0x04001F87 RID: 8071
		[ProtoEnum(Name = "StringTableId_StillInSubscribeTime", Value = 13056)]
		StringTableId_StillInSubscribeTime,
		// Token: 0x04001F88 RID: 8072
		[ProtoEnum(Name = "StringTableId_ExtractionFragmentNotEnough", Value = 13057)]
		StringTableId_ExtractionFragmentNotEnough,
		// Token: 0x04001F89 RID: 8073
		[ProtoEnum(Name = "StringTableId_XunfeiAppIdWindows", Value = 13058)]
		StringTableId_XunfeiAppIdWindows,
		// Token: 0x04001F8A RID: 8074
		[ProtoEnum(Name = "StringTableId_IOSPromotingPayTip", Value = 13059)]
		StringTableId_IOSPromotingPayTip,
		// Token: 0x04001F8B RID: 8075
		[ProtoEnum(Name = "StringTableId_Guild_RequireItem", Value = 14001)]
		StringTableId_Guild_RequireItem = 14001,
		// Token: 0x04001F8C RID: 8076
		[ProtoEnum(Name = "StringTableId_Guild_CreateGuild", Value = 14002)]
		StringTableId_Guild_CreateGuild,
		// Token: 0x04001F8D RID: 8077
		[ProtoEnum(Name = "StringTableId_Guild_SearchNameCantNull", Value = 14003)]
		StringTableId_Guild_SearchNameCantNull,
		// Token: 0x04001F8E RID: 8078
		[ProtoEnum(Name = "StringTableId_Guild_GuildUnlockLevel", Value = 14004)]
		StringTableId_Guild_GuildUnlockLevel,
		// Token: 0x04001F8F RID: 8079
		[ProtoEnum(Name = "StringTableId_Guild_SaveAnnouncementSucceed", Value = 14005)]
		StringTableId_Guild_SaveAnnouncementSucceed,
		// Token: 0x04001F90 RID: 8080
		[ProtoEnum(Name = "StringTableId_Guild_QuitTipTitle", Value = 14006)]
		StringTableId_Guild_QuitTipTitle,
		// Token: 0x04001F91 RID: 8081
		[ProtoEnum(Name = "StringTableId_Guild_QuitTipContent", Value = 14007)]
		StringTableId_Guild_QuitTipContent,
		// Token: 0x04001F92 RID: 8082
		[ProtoEnum(Name = "StringTableId_Guild_QuitSucceed", Value = 14008)]
		StringTableId_Guild_QuitSucceed,
		// Token: 0x04001F93 RID: 8083
		[ProtoEnum(Name = "StringTableId_Guild_InviteSucceed", Value = 14009)]
		StringTableId_Guild_InviteSucceed,
		// Token: 0x04001F94 RID: 8084
		[ProtoEnum(Name = "StringTableId_Guild_ChangeNameSucceed", Value = 14010)]
		StringTableId_Guild_ChangeNameSucceed,
		// Token: 0x04001F95 RID: 8085
		[ProtoEnum(Name = "StringTableId_Guild_TitlePresident", Value = 14011)]
		StringTableId_Guild_TitlePresident,
		// Token: 0x04001F96 RID: 8086
		[ProtoEnum(Name = "StringTableId_Guild_TitleVP", Value = 14012)]
		StringTableId_Guild_TitleVP,
		// Token: 0x04001F97 RID: 8087
		[ProtoEnum(Name = "StringTableId_Guild_TitleElite", Value = 14013)]
		StringTableId_Guild_TitleElite,
		// Token: 0x04001F98 RID: 8088
		[ProtoEnum(Name = "StringTableId_Guild_TitleNormal", Value = 14014)]
		StringTableId_Guild_TitleNormal,
		// Token: 0x04001F99 RID: 8089
		[ProtoEnum(Name = "StringTableId_Guild_RefreshGuildSuccess", Value = 14015)]
		StringTableId_Guild_RefreshGuildSuccess,
		// Token: 0x04001F9A RID: 8090
		[ProtoEnum(Name = "StringTableId_Guild_JoinGuildSuccess", Value = 14016)]
		StringTableId_Guild_JoinGuildSuccess,
		// Token: 0x04001F9B RID: 8091
		[ProtoEnum(Name = "StringTableId_Guild_ApprovalByPresident", Value = 14017)]
		StringTableId_Guild_ApprovalByPresident,
		// Token: 0x04001F9C RID: 8092
		[ProtoEnum(Name = "StringTableId_Guild_ApprovalAuto", Value = 14018)]
		StringTableId_Guild_ApprovalAuto,
		// Token: 0x04001F9D RID: 8093
		[ProtoEnum(Name = "StringTableId_Guild_SetVPSucceed", Value = 14019)]
		StringTableId_Guild_SetVPSucceed,
		// Token: 0x04001F9E RID: 8094
		[ProtoEnum(Name = "StringTableId_Guild_AppointPresidentSuccess", Value = 14020)]
		StringTableId_Guild_AppointPresidentSuccess,
		// Token: 0x04001F9F RID: 8095
		[ProtoEnum(Name = "StringTableId_Guild_KickOutMemberSucceed", Value = 14021)]
		StringTableId_Guild_KickOutMemberSucceed,
		// Token: 0x04001FA0 RID: 8096
		[ProtoEnum(Name = "StringTableId_Guild_RelievePresidentSucceed", Value = 14022)]
		StringTableId_Guild_RelievePresidentSucceed,
		// Token: 0x04001FA1 RID: 8097
		[ProtoEnum(Name = "StringTableId_Guild_RelieveVPSucceed", Value = 14023)]
		StringTableId_Guild_RelieveVPSucceed,
		// Token: 0x04001FA2 RID: 8098
		[ProtoEnum(Name = "StringTableId_Guild_ConfirmMoveChairman", Value = 14024)]
		StringTableId_Guild_ConfirmMoveChairman,
		// Token: 0x04001FA3 RID: 8099
		[ProtoEnum(Name = "StringTableId_Guild_ConfirmRemoveMember", Value = 14025)]
		StringTableId_Guild_ConfirmRemoveMember,
		// Token: 0x04001FA4 RID: 8100
		[ProtoEnum(Name = "StringTableId_Guild_OnlineGuildMember", Value = 14026)]
		StringTableId_Guild_OnlineGuildMember,
		// Token: 0x04001FA5 RID: 8101
		[ProtoEnum(Name = "StringTableId_Guild_JoinGuildCD", Value = 14027)]
		StringTableId_Guild_JoinGuildCD,
		// Token: 0x04001FA6 RID: 8102
		[ProtoEnum(Name = "StringTableId_Guild_GuildTeamInviteUnopen", Value = 14028)]
		StringTableId_Guild_GuildTeamInviteUnopen,
		// Token: 0x04001FA7 RID: 8103
		[ProtoEnum(Name = "StringTableId_Guild_GuildMassiveCombatCountZero", Value = 14029)]
		StringTableId_Guild_GuildMassiveCombatCountZero,
		// Token: 0x04001FA8 RID: 8104
		[ProtoEnum(Name = "StringTableId_Guild_WaitOpenGuildMassiveCombat", Value = 14030)]
		StringTableId_Guild_WaitOpenGuildMassiveCombat,
		// Token: 0x04001FA9 RID: 8105
		[ProtoEnum(Name = "StringTableId_Guild_GuildMassiveCombatStrongHoldComplete", Value = 14031)]
		StringTableId_Guild_GuildMassiveCombatStrongHoldComplete,
		// Token: 0x04001FAA RID: 8106
		[ProtoEnum(Name = "StringTableId_Guild_GuildMassiveCombatPowerUpDesc", Value = 14032)]
		StringTableId_Guild_GuildMassiveCombatPowerUpDesc,
		// Token: 0x04001FAB RID: 8107
		[ProtoEnum(Name = "StringTableId_Guild_GuildRaidLevelUnlockDesc", Value = 14033)]
		StringTableId_Guild_GuildRaidLevelUnlockDesc,
		// Token: 0x04001FAC RID: 8108
		[ProtoEnum(Name = "StringTableId_Guild_MassiveCombatScoreName", Value = 14034)]
		StringTableId_Guild_MassiveCombatScoreName,
		// Token: 0x04001FAD RID: 8109
		[ProtoEnum(Name = "StringTableId_Activity_Redeem_Desc0", Value = 15001)]
		StringTableId_Activity_Redeem_Desc0 = 15001,
		// Token: 0x04001FAE RID: 8110
		[ProtoEnum(Name = "StringTableId_Activity_Redeem_Desc1", Value = 15002)]
		StringTableId_Activity_Redeem_Desc1,
		// Token: 0x04001FAF RID: 8111
		[ProtoEnum(Name = "StringTableId_Activity_Redeem_Desc2", Value = 15003)]
		StringTableId_Activity_Redeem_Desc2,
		// Token: 0x04001FB0 RID: 8112
		[ProtoEnum(Name = "StringTableId_Activity_Redeem_Desc3", Value = 15004)]
		StringTableId_Activity_Redeem_Desc3,
		// Token: 0x04001FB1 RID: 8113
		[ProtoEnum(Name = "StringTableId_Activity_Redeem_Desc4", Value = 15005)]
		StringTableId_Activity_Redeem_Desc4,
		// Token: 0x04001FB2 RID: 8114
		[ProtoEnum(Name = "StringTableId_Activity_Redeem_Desc5", Value = 15006)]
		StringTableId_Activity_Redeem_Desc5,
		// Token: 0x04001FB3 RID: 8115
		[ProtoEnum(Name = "StringTableId_Activity_Redeem_CostSet", Value = 15007)]
		StringTableId_Activity_Redeem_CostSet,
		// Token: 0x04001FB4 RID: 8116
		[ProtoEnum(Name = "StringTableId_Activity_Redeem_BundleSet", Value = 15008)]
		StringTableId_Activity_Redeem_BundleSet,
		// Token: 0x04001FB5 RID: 8117
		[ProtoEnum(Name = "StringTableId_DefaultGuildAnnouncement", Value = 15009)]
		StringTableId_DefaultGuildAnnouncement,
		// Token: 0x04001FB6 RID: 8118
		[ProtoEnum(Name = "StringTableId_DefaultGuildHiringDeclaration", Value = 15010)]
		StringTableId_DefaultGuildHiringDeclaration,
		// Token: 0x04001FB7 RID: 8119
		[ProtoEnum(Name = "StringTableId_GuildAnnouncementSetNotify", Value = 15011)]
		StringTableId_GuildAnnouncementSetNotify,
		// Token: 0x04001FB8 RID: 8120
		[ProtoEnum(Name = "StringTableId_Activity_Redeem_Error", Value = 15012)]
		StringTableId_Activity_Redeem_Error,
		// Token: 0x04001FB9 RID: 8121
		[ProtoEnum(Name = "StringTableId_MemoryStoreNotOpen", Value = 15013)]
		StringTableId_MemoryStoreNotOpen,
		// Token: 0x04001FBA RID: 8122
		[ProtoEnum(Name = "StringTableId_SendCommentMinLevelTip", Value = 15014)]
		StringTableId_SendCommentMinLevelTip,
		// Token: 0x04001FBB RID: 8123
		[ProtoEnum(Name = "StringTableId_JoinGuildLogId", Value = 20000)]
		StringTableId_JoinGuildLogId = 20000,
		// Token: 0x04001FBC RID: 8124
		[ProtoEnum(Name = "StringTableId_QuitGuildLogId", Value = 20001)]
		StringTableId_QuitGuildLogId,
		// Token: 0x04001FBD RID: 8125
		[ProtoEnum(Name = "StringTableId_KickOutGuildLogId", Value = 20002)]
		StringTableId_KickOutGuildLogId,
		// Token: 0x04001FBE RID: 8126
		[ProtoEnum(Name = "StringTableId_ChangeGuildNameLogId", Value = 20003)]
		StringTableId_ChangeGuildNameLogId,
		// Token: 0x04001FBF RID: 8127
		[ProtoEnum(Name = "StringTableId_AppointGuildVpLogId", Value = 20004)]
		StringTableId_AppointGuildVpLogId,
		// Token: 0x04001FC0 RID: 8128
		[ProtoEnum(Name = "StringTableId_RelieveGuildVpLogId", Value = 20005)]
		StringTableId_RelieveGuildVpLogId,
		// Token: 0x04001FC1 RID: 8129
		[ProtoEnum(Name = "StringTableId_UpToEliteLogId", Value = 20006)]
		StringTableId_UpToEliteLogId,
		// Token: 0x04001FC2 RID: 8130
		[ProtoEnum(Name = "StringTableId_AppointPresidentLogId", Value = 20007)]
		StringTableId_AppointPresidentLogId,
		// Token: 0x04001FC3 RID: 8131
		[ProtoEnum(Name = "StringTableId_RelievePresidentLogId", Value = 20008)]
		StringTableId_RelievePresidentLogId,
		// Token: 0x04001FC4 RID: 8132
		[ProtoEnum(Name = "StringTableId_BuyUnionStoreGoodsLogId", Value = 20009)]
		StringTableId_BuyUnionStoreGoodsLogId,
		// Token: 0x04001FC5 RID: 8133
		[ProtoEnum(Name = "StringTableId_JoinGuildAnnouncementId", Value = 20010)]
		StringTableId_JoinGuildAnnouncementId,
		// Token: 0x04001FC6 RID: 8134
		[ProtoEnum(Name = "StringTableId_KickOutGuildAnnouncementId", Value = 20011)]
		StringTableId_KickOutGuildAnnouncementId,
		// Token: 0x04001FC7 RID: 8135
		[ProtoEnum(Name = "StringTableId_AppointGuildVpAnnouncementId", Value = 20012)]
		StringTableId_AppointGuildVpAnnouncementId,
		// Token: 0x04001FC8 RID: 8136
		[ProtoEnum(Name = "StringTableId_RelieveGuildVpAnnouncementId", Value = 20013)]
		StringTableId_RelieveGuildVpAnnouncementId,
		// Token: 0x04001FC9 RID: 8137
		[ProtoEnum(Name = "StringTableId_UpToEliteAnnouncementId", Value = 20014)]
		StringTableId_UpToEliteAnnouncementId,
		// Token: 0x04001FCA RID: 8138
		[ProtoEnum(Name = "StringTableId_AppointPresidentAnnouncementId", Value = 20015)]
		StringTableId_AppointPresidentAnnouncementId,
		// Token: 0x04001FCB RID: 8139
		[ProtoEnum(Name = "StringTableId_CreateGuildLogId", Value = 20016)]
		StringTableId_CreateGuildLogId,
		// Token: 0x04001FCC RID: 8140
		[ProtoEnum(Name = "StringTableId_ChangeGuildAnnouncementLogId", Value = 20017)]
		StringTableId_ChangeGuildAnnouncementLogId,
		// Token: 0x04001FCD RID: 8141
		[ProtoEnum(Name = "StringTableId_GuildMassiveCombatStart", Value = 20018)]
		StringTableId_GuildMassiveCombatStart,
		// Token: 0x04001FCE RID: 8142
		[ProtoEnum(Name = "StringTableId_GuildMassiveCombatSurrender", Value = 20019)]
		StringTableId_GuildMassiveCombatSurrender,
		// Token: 0x04001FCF RID: 8143
		[ProtoEnum(Name = "StringTableId_GuildMassiveCombatStrongholdTaken", Value = 20020)]
		StringTableId_GuildMassiveCombatStrongholdTaken
	}
}
