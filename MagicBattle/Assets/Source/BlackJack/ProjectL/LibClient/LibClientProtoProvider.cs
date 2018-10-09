using System;
using System.Collections.Generic;
using BlackJack.LibClient;
using BlackJack.LibClient.Protocol;
using BlackJack.ProjectL.Protocol;
using BlackJack.ServerFramework.Protocol;

namespace BlackJack.ProjectL.LibClient
{
	// Token: 0x02000803 RID: 2051
	public class LibClientProtoProvider : IProtoProvider
	{
		// Token: 0x060067D7 RID: 26583 RVA: 0x001CDEB8 File Offset: 0x001CC0B8
		public LibClientProtoProvider()
		{
			this._idDic = new Dictionary<int, Type>();
			this._typeDic = new Dictionary<Type, int>();
			this._idDic[9001] = typeof(CCMSGConnectionReady);
			this._typeDic[typeof(CCMSGConnectionReady)] = 9001;
			this._idDic[9002] = typeof(CCMSGConnectionBreak);
			this._typeDic[typeof(CCMSGConnectionBreak)] = 9002;
			this._idDic[9003] = typeof(CCMSGConnectionFailure);
			this._typeDic[typeof(CCMSGConnectionFailure)] = 9003;
			this._idDic[9004] = typeof(CCMSGConnectionSendFailure);
			this._typeDic[typeof(CCMSGConnectionSendFailure)] = 9004;
			this._idDic[9005] = typeof(CCMSGConnectionRecvFailure);
			this._typeDic[typeof(CCMSGConnectionRecvFailure)] = 9005;
			this._idDic[1] = typeof(LoginByAuthTokenAck);
			this._typeDic[typeof(LoginByAuthTokenAck)] = 1;
			this._idDic[2] = typeof(LoginByAuthTokenReq);
			this._typeDic[typeof(LoginByAuthTokenReq)] = 2;
			this._idDic[3] = typeof(LoginBySessionTokenAck);
			this._typeDic[typeof(LoginBySessionTokenAck)] = 3;
			this._idDic[4] = typeof(LoginBySessionTokenReq);
			this._typeDic[typeof(LoginBySessionTokenReq)] = 4;
			this._idDic[5] = typeof(ServerDisconnectNtf);
			this._typeDic[typeof(ServerDisconnectNtf)] = 5;
			this._idDic[6] = typeof(ServerHeartBeatNtf);
			this._typeDic[typeof(ServerHeartBeatNtf)] = 6;
			this._idDic[1002] = typeof(AnikiGymLevelAttackAck);
			this._typeDic[typeof(AnikiGymLevelAttackAck)] = 1002;
			this._idDic[1003] = typeof(AnikiGymLevelAttackReq);
			this._typeDic[typeof(AnikiGymLevelAttackReq)] = 1003;
			this._idDic[1004] = typeof(AnikiGymLevelBattleFinishedAck);
			this._typeDic[typeof(AnikiGymLevelBattleFinishedAck)] = 1004;
			this._idDic[1005] = typeof(AnikiGymLevelBattleFinishedReq);
			this._typeDic[typeof(AnikiGymLevelBattleFinishedReq)] = 1005;
			this._idDic[1006] = typeof(ArenaBattleFinishedAck);
			this._typeDic[typeof(ArenaBattleFinishedAck)] = 1006;
			this._idDic[1007] = typeof(ArenaBattleFinishedReq);
			this._typeDic[typeof(ArenaBattleFinishedReq)] = 1007;
			this._idDic[1008] = typeof(ArenaBattleReconnectAck);
			this._typeDic[typeof(ArenaBattleReconnectAck)] = 1008;
			this._idDic[1009] = typeof(ArenaBattleReconnectReq);
			this._typeDic[typeof(ArenaBattleReconnectReq)] = 1009;
			this._idDic[1010] = typeof(ArenaBattleReportBasicDataGetAck);
			this._typeDic[typeof(ArenaBattleReportBasicDataGetAck)] = 1010;
			this._idDic[1011] = typeof(ArenaBattleReportBasicDataGetReq);
			this._typeDic[typeof(ArenaBattleReportBasicDataGetReq)] = 1011;
			this._idDic[1012] = typeof(ArenaBattleReportNtf);
			this._typeDic[typeof(ArenaBattleReportNtf)] = 1012;
			this._idDic[1013] = typeof(ArenaBattleReportPlayBackDataGetAck);
			this._typeDic[typeof(ArenaBattleReportPlayBackDataGetAck)] = 1013;
			this._idDic[1014] = typeof(ArenaBattleReportPlayBackDataGetReq);
			this._typeDic[typeof(ArenaBattleReportPlayBackDataGetReq)] = 1014;
			this._idDic[1015] = typeof(ArenaOpponentAttackAck);
			this._typeDic[typeof(ArenaOpponentAttackAck)] = 1015;
			this._idDic[1016] = typeof(ArenaOpponentAttackFightingAck);
			this._typeDic[typeof(ArenaOpponentAttackFightingAck)] = 1016;
			this._idDic[1017] = typeof(ArenaOpponentAttackFightingReq);
			this._typeDic[typeof(ArenaOpponentAttackFightingReq)] = 1017;
			this._idDic[1018] = typeof(ArenaOpponentAttackReq);
			this._typeDic[typeof(ArenaOpponentAttackReq)] = 1018;
			this._idDic[1019] = typeof(ArenaOpponentRevengeAck);
			this._typeDic[typeof(ArenaOpponentRevengeAck)] = 1019;
			this._idDic[1020] = typeof(ArenaOpponentRevengeReq);
			this._typeDic[typeof(ArenaOpponentRevengeReq)] = 1020;
			this._idDic[1023] = typeof(ArenaOpponentViewAck);
			this._typeDic[typeof(ArenaOpponentViewAck)] = 1023;
			this._idDic[1024] = typeof(ArenaOpponentViewReq);
			this._typeDic[typeof(ArenaOpponentViewReq)] = 1024;
			this._idDic[1025] = typeof(ArenaPlayerInfoGetAck);
			this._typeDic[typeof(ArenaPlayerInfoGetAck)] = 1025;
			this._idDic[1026] = typeof(ArenaPlayerInfoGetReq);
			this._typeDic[typeof(ArenaPlayerInfoGetReq)] = 1026;
			this._idDic[1027] = typeof(ArenaPlayerSetDefensiveTeamAck);
			this._typeDic[typeof(ArenaPlayerSetDefensiveTeamAck)] = 1027;
			this._idDic[1028] = typeof(ArenaPlayerSetDefensiveTeamReq);
			this._typeDic[typeof(ArenaPlayerSetDefensiveTeamReq)] = 1028;
			this._idDic[1029] = typeof(ArenaRevengeOpponentGetAck);
			this._typeDic[typeof(ArenaRevengeOpponentGetAck)] = 1029;
			this._idDic[1030] = typeof(ArenaRevengeOpponentGetReq);
			this._typeDic[typeof(ArenaRevengeOpponentGetReq)] = 1030;
			this._idDic[1031] = typeof(ArenaTicketsBuyAck);
			this._typeDic[typeof(ArenaTicketsBuyAck)] = 1031;
			this._idDic[1032] = typeof(ArenaTicketsBuyReq);
			this._typeDic[typeof(ArenaTicketsBuyReq)] = 1032;
			this._idDic[1033] = typeof(ArenaTopRankPlayersGetAck);
			this._typeDic[typeof(ArenaTopRankPlayersGetAck)] = 1033;
			this._idDic[1034] = typeof(ArenaTopRankPlayersGetReq);
			this._typeDic[typeof(ArenaTopRankPlayersGetReq)] = 1034;
			this._idDic[1035] = typeof(ArenaVictoryPointsRewardGainAck);
			this._typeDic[typeof(ArenaVictoryPointsRewardGainAck)] = 1035;
			this._idDic[1036] = typeof(ArenaVictoryPointsRewardGainReq);
			this._typeDic[typeof(ArenaVictoryPointsRewardGainReq)] = 1036;
			this._idDic[1037] = typeof(BattleArmyRandomSeedGetAck);
			this._typeDic[typeof(BattleArmyRandomSeedGetAck)] = 1037;
			this._idDic[1038] = typeof(BattleArmyRandomSeedGetReq);
			this._typeDic[typeof(BattleArmyRandomSeedGetReq)] = 1038;
			this._idDic[1039] = typeof(BattleCancelAck);
			this._typeDic[typeof(BattleCancelAck)] = 1039;
			this._idDic[1040] = typeof(BattleCancelReq);
			this._typeDic[typeof(BattleCancelReq)] = 1040;
			this._idDic[1041] = typeof(BattleTeamSetAck);
			this._typeDic[typeof(BattleTeamSetAck)] = 1041;
			this._idDic[1042] = typeof(BattleTeamSetReq);
			this._typeDic[typeof(BattleTeamSetReq)] = 1042;
			this._idDic[1043] = typeof(BuyEnergyAck);
			this._typeDic[typeof(BuyEnergyAck)] = 1043;
			this._idDic[1044] = typeof(BuyEnergyReq);
			this._typeDic[typeof(BuyEnergyReq)] = 1044;
			this._idDic[1045] = typeof(ChatBannedNtf);
			this._typeDic[typeof(ChatBannedNtf)] = 1045;
			this._idDic[1046] = typeof(ChatMessageNtf);
			this._typeDic[typeof(ChatMessageNtf)] = 1046;
			this._idDic[1047] = typeof(ChatMessageSendAck);
			this._typeDic[typeof(ChatMessageSendAck)] = 1047;
			this._idDic[1048] = typeof(ChatMessageSendReq);
			this._typeDic[typeof(ChatMessageSendReq)] = 1048;
			this._idDic[1049] = typeof(ChatVoiceContentAck);
			this._typeDic[typeof(ChatVoiceContentAck)] = 1049;
			this._idDic[1050] = typeof(ChatVoiceContentReq);
			this._typeDic[typeof(ChatVoiceContentReq)] = 1050;
			this._idDic[1051] = typeof(ChatWorldChannelRoomEnterAck);
			this._typeDic[typeof(ChatWorldChannelRoomEnterAck)] = 1051;
			this._idDic[1052] = typeof(ChatWorldChannelRoomEnterReq);
			this._typeDic[typeof(ChatWorldChannelRoomEnterReq)] = 1052;
			this._idDic[1053] = typeof(CommenterHeroViewAck);
			this._typeDic[typeof(CommenterHeroViewAck)] = 1053;
			this._idDic[1054] = typeof(CommenterHeroViewReq);
			this._typeDic[typeof(CommenterHeroViewReq)] = 1054;
			this._idDic[1055] = typeof(CreateCharactorAck);
			this._typeDic[typeof(CreateCharactorAck)] = 1055;
			this._idDic[1056] = typeof(CreateCharactorReq);
			this._typeDic[typeof(CreateCharactorReq)] = 1056;
			this._idDic[1057] = typeof(DSAnikiGymNtf);
			this._typeDic[typeof(DSAnikiGymNtf)] = 1057;
			this._idDic[1058] = typeof(DSAnnouncementNtf);
			this._typeDic[typeof(DSAnnouncementNtf)] = 1058;
			this._idDic[1059] = typeof(DSArenaNtf);
			this._typeDic[typeof(DSArenaNtf)] = 1059;
			this._idDic[1060] = typeof(DSBagNtf);
			this._typeDic[typeof(DSBagNtf)] = 1060;
			this._idDic[1061] = typeof(DSBattleNtf);
			this._typeDic[typeof(DSBattleNtf)] = 1061;
			this._idDic[1062] = typeof(DSChatNtf);
			this._typeDic[typeof(DSChatNtf)] = 1062;
			this._idDic[1063] = typeof(DSFixedStoreNtf);
			this._typeDic[typeof(DSFixedStoreNtf)] = 1063;
			this._idDic[1064] = typeof(DSHeroDungeonNtf);
			this._typeDic[typeof(DSHeroDungeonNtf)] = 1064;
			this._idDic[1065] = typeof(DSHeroNtf);
			this._typeDic[typeof(DSHeroNtf)] = 1065;
			this._idDic[1066] = typeof(DSHeroTrainningNtf);
			this._typeDic[typeof(DSHeroTrainningNtf)] = 1066;
			this._idDic[1067] = typeof(DSLevelNtf);
			this._typeDic[typeof(DSLevelNtf)] = 1067;
			this._idDic[1068] = typeof(DSMailNtf);
			this._typeDic[typeof(DSMailNtf)] = 1068;
			this._idDic[1069] = typeof(DSMemoryCorridorNtf);
			this._typeDic[typeof(DSMemoryCorridorNtf)] = 1069;
			this._idDic[1070] = typeof(DSMissionNtf);
			this._typeDic[typeof(DSMissionNtf)] = 1070;
			this._idDic[1071] = typeof(DSOperationalActivityNtf);
			this._typeDic[typeof(DSOperationalActivityNtf)] = 1071;
			this._idDic[1072] = typeof(DSPlayerBasicNtf);
			this._typeDic[typeof(DSPlayerBasicNtf)] = 1072;
			this._idDic[1073] = typeof(DSRandomStoreNtf);
			this._typeDic[typeof(DSRandomStoreNtf)] = 1073;
			this._idDic[1074] = typeof(DSRiftNtf);
			this._typeDic[typeof(DSRiftNtf)] = 1074;
			this._idDic[1075] = typeof(DSSelectCardNtf);
			this._typeDic[typeof(DSSelectCardNtf)] = 1075;
			this._idDic[1076] = typeof(DSSurveyNtf);
			this._typeDic[typeof(DSSurveyNtf)] = 1076;
			this._idDic[1077] = typeof(DSTeamNtf);
			this._typeDic[typeof(DSTeamNtf)] = 1077;
			this._idDic[1078] = typeof(DSThearchyTrialNtf);
			this._typeDic[typeof(DSThearchyTrialNtf)] = 1078;
			this._idDic[1079] = typeof(DSTreasureMapNtf);
			this._typeDic[typeof(DSTreasureMapNtf)] = 1079;
			this._idDic[1080] = typeof(EquipmentAutoAck);
			this._typeDic[typeof(EquipmentAutoAck)] = 1080;
			this._idDic[1081] = typeof(EquipmentAutoReq);
			this._typeDic[typeof(EquipmentAutoReq)] = 1081;
			this._idDic[1082] = typeof(EquipmentEnhanceAck);
			this._typeDic[typeof(EquipmentEnhanceAck)] = 1082;
			this._idDic[1083] = typeof(EquipmentEnhanceReq);
			this._typeDic[typeof(EquipmentEnhanceReq)] = 1083;
			this._idDic[1084] = typeof(EquipmentLockAndUnLockAck);
			this._typeDic[typeof(EquipmentLockAndUnLockAck)] = 1084;
			this._idDic[1085] = typeof(EquipmentLockAndUnLockReq);
			this._typeDic[typeof(EquipmentLockAndUnLockReq)] = 1085;
			this._idDic[1086] = typeof(EquipmentStarLevelUpAck);
			this._typeDic[typeof(EquipmentStarLevelUpAck)] = 1086;
			this._idDic[1087] = typeof(EquipmentStarLevelUpReq);
			this._typeDic[typeof(EquipmentStarLevelUpReq)] = 1087;
			this._idDic[1088] = typeof(EquipmentTakeOffAck);
			this._typeDic[typeof(EquipmentTakeOffAck)] = 1088;
			this._idDic[1089] = typeof(EquipmentTakeOffReq);
			this._typeDic[typeof(EquipmentTakeOffReq)] = 1089;
			this._idDic[1090] = typeof(EquipmentWearAck);
			this._typeDic[typeof(EquipmentWearAck)] = 1090;
			this._idDic[1091] = typeof(EquipmentWearReq);
			this._typeDic[typeof(EquipmentWearReq)] = 1091;
			this._idDic[1092] = typeof(EverydaySignAck);
			this._typeDic[typeof(EverydaySignAck)] = 1092;
			this._idDic[1093] = typeof(EverydaySignReq);
			this._typeDic[typeof(EverydaySignReq)] = 1093;
			this._idDic[1094] = typeof(ExchangeGiftCDKeyAck);
			this._typeDic[typeof(ExchangeGiftCDKeyAck)] = 1094;
			this._idDic[1095] = typeof(ExchangeGiftCDKeyReq);
			this._typeDic[typeof(ExchangeGiftCDKeyReq)] = 1095;
			this._idDic[1096] = typeof(FixedStoreBuyStoreItemAck);
			this._typeDic[typeof(FixedStoreBuyStoreItemAck)] = 1096;
			this._idDic[1097] = typeof(FixedStoreBuyStoreItemReq);
			this._typeDic[typeof(FixedStoreBuyStoreItemReq)] = 1097;
			this._idDic[1100] = typeof(FlushConfigNtf);
			this._typeDic[typeof(FlushConfigNtf)] = 1100;
			this._idDic[1101] = typeof(FriendBlockAck);
			this._typeDic[typeof(FriendBlockAck)] = 1101;
			this._idDic[1102] = typeof(FriendBlockReq);
			this._typeDic[typeof(FriendBlockReq)] = 1102;
			this._idDic[1103] = typeof(FriendDeleteAck);
			this._typeDic[typeof(FriendDeleteAck)] = 1103;
			this._idDic[1104] = typeof(FriendDeleteReq);
			this._typeDic[typeof(FriendDeleteReq)] = 1104;
			this._idDic[1105] = typeof(FriendFindAck);
			this._typeDic[typeof(FriendFindAck)] = 1105;
			this._idDic[1106] = typeof(FriendFindReq);
			this._typeDic[typeof(FriendFindReq)] = 1106;
			this._idDic[1108] = typeof(FriendGetSocialRelationReq);
			this._typeDic[typeof(FriendGetSocialRelationReq)] = 1108;
			this._idDic[1109] = typeof(FriendInviteAcceptAck);
			this._typeDic[typeof(FriendInviteAcceptAck)] = 1109;
			this._idDic[1110] = typeof(FriendInviteAcceptNtf);
			this._typeDic[typeof(FriendInviteAcceptNtf)] = 1110;
			this._idDic[1111] = typeof(FriendInviteAcceptReq);
			this._typeDic[typeof(FriendInviteAcceptReq)] = 1111;
			this._idDic[1112] = typeof(FriendInviteAck);
			this._typeDic[typeof(FriendInviteAck)] = 1112;
			this._idDic[1113] = typeof(FriendInviteDeclineAck);
			this._typeDic[typeof(FriendInviteDeclineAck)] = 1113;
			this._idDic[1114] = typeof(FriendInviteDeclineNtf);
			this._typeDic[typeof(FriendInviteDeclineNtf)] = 1114;
			this._idDic[1115] = typeof(FriendInviteDeclineReq);
			this._typeDic[typeof(FriendInviteDeclineReq)] = 1115;
			this._idDic[1116] = typeof(FriendInviteNtf);
			this._typeDic[typeof(FriendInviteNtf)] = 1116;
			this._idDic[1117] = typeof(FriendInviteReq);
			this._typeDic[typeof(FriendInviteReq)] = 1117;
			this._idDic[1118] = typeof(FriendSuggestedAck);
			this._typeDic[typeof(FriendSuggestedAck)] = 1118;
			this._idDic[1119] = typeof(FriendSuggestedReq);
			this._typeDic[typeof(FriendSuggestedReq)] = 1119;
			this._idDic[1120] = typeof(FriendSummaryUpdateNtf);
			this._typeDic[typeof(FriendSummaryUpdateNtf)] = 1120;
			this._idDic[1121] = typeof(FriendUnblockAck);
			this._typeDic[typeof(FriendUnblockAck)] = 1121;
			this._idDic[1122] = typeof(FriendUnblockReq);
			this._typeDic[typeof(FriendUnblockReq)] = 1122;
			this._idDic[1123] = typeof(GetMissionRewardAck);
			this._typeDic[typeof(GetMissionRewardAck)] = 1123;
			this._idDic[1124] = typeof(GetMissionRewardReq);
			this._typeDic[typeof(GetMissionRewardReq)] = 1124;
			this._idDic[1125] = typeof(GetSurveyRewardAck);
			this._typeDic[typeof(GetSurveyRewardAck)] = 1125;
			this._idDic[1126] = typeof(GetSurveyRewardReq);
			this._typeDic[typeof(GetSurveyRewardReq)] = 1126;
			this._idDic[1127] = typeof(GmCommandAck);
			this._typeDic[typeof(GmCommandAck)] = 1127;
			this._idDic[1128] = typeof(GmCommandReq);
			this._typeDic[typeof(GmCommandReq)] = 1128;
			this._idDic[1131] = typeof(HeroCommentAck);
			this._typeDic[typeof(HeroCommentAck)] = 1131;
			this._idDic[1132] = typeof(HeroCommentEntryPraiseAck);
			this._typeDic[typeof(HeroCommentEntryPraiseAck)] = 1132;
			this._idDic[1133] = typeof(HeroCommentEntryPraiseReq);
			this._typeDic[typeof(HeroCommentEntryPraiseReq)] = 1133;
			this._idDic[1134] = typeof(HeroCommentGetAck);
			this._typeDic[typeof(HeroCommentGetAck)] = 1134;
			this._idDic[1135] = typeof(HeroCommentGetReq);
			this._typeDic[typeof(HeroCommentGetReq)] = 1135;
			this._idDic[1136] = typeof(HeroCommentReq);
			this._typeDic[typeof(HeroCommentReq)] = 1136;
			this._idDic[1137] = typeof(HeroComposeAck);
			this._typeDic[typeof(HeroComposeAck)] = 1137;
			this._idDic[1138] = typeof(HeroComposeReq);
			this._typeDic[typeof(HeroComposeReq)] = 1138;
			this._idDic[1139] = typeof(HeroConfessAck);
			this._typeDic[typeof(HeroConfessAck)] = 1139;
			this._idDic[1140] = typeof(HeroConfessReq);
			this._typeDic[typeof(HeroConfessReq)] = 1140;
			this._idDic[1141] = typeof(HeroDungeonChapterStarRewardGainAck);
			this._typeDic[typeof(HeroDungeonChapterStarRewardGainAck)] = 1141;
			this._idDic[1142] = typeof(HeroDungeonChapterStarRewardGainReq);
			this._typeDic[typeof(HeroDungeonChapterStarRewardGainReq)] = 1142;
			this._idDic[1143] = typeof(HeroDungeonLevelAttackAck);
			this._typeDic[typeof(HeroDungeonLevelAttackAck)] = 1143;
			this._idDic[1144] = typeof(HeroDungeonLevelAttackReq);
			this._typeDic[typeof(HeroDungeonLevelAttackReq)] = 1144;
			this._idDic[1145] = typeof(HeroDungeonLevelBattleFinishedAck);
			this._typeDic[typeof(HeroDungeonLevelBattleFinishedAck)] = 1145;
			this._idDic[1146] = typeof(HeroDungeonLevelBattleFinishedReq);
			this._typeDic[typeof(HeroDungeonLevelBattleFinishedReq)] = 1146;
			this._idDic[1147] = typeof(HeroDungeonLevelRaidAck);
			this._typeDic[typeof(HeroDungeonLevelRaidAck)] = 1147;
			this._idDic[1148] = typeof(HeroDungeonLevelRaidReq);
			this._typeDic[typeof(HeroDungeonLevelRaidReq)] = 1148;
			this._idDic[1149] = typeof(HeroExpAddAck);
			this._typeDic[typeof(HeroExpAddAck)] = 1149;
			this._idDic[1150] = typeof(HeroExpAddReq);
			this._typeDic[typeof(HeroExpAddReq)] = 1150;
			this._idDic[1151] = typeof(HeroFavorabilityExpAddAck);
			this._typeDic[typeof(HeroFavorabilityExpAddAck)] = 1151;
			this._idDic[1152] = typeof(HeroFavorabilityExpAddReq);
			this._typeDic[typeof(HeroFavorabilityExpAddReq)] = 1152;
			this._idDic[1153] = typeof(HeroFetterLevelUpAck);
			this._typeDic[typeof(HeroFetterLevelUpAck)] = 1153;
			this._idDic[1154] = typeof(HeroFetterLevelUpReq);
			this._typeDic[typeof(HeroFetterLevelUpReq)] = 1154;
			this._idDic[1155] = typeof(HeroFetterUnlockAck);
			this._typeDic[typeof(HeroFetterUnlockAck)] = 1155;
			this._idDic[1156] = typeof(HeroFetterUnlockReq);
			this._typeDic[typeof(HeroFetterUnlockReq)] = 1156;
			this._idDic[1157] = typeof(HeroInteractAck);
			this._typeDic[typeof(HeroInteractAck)] = 1157;
			this._idDic[1158] = typeof(HeroInteractReq);
			this._typeDic[typeof(HeroInteractReq)] = 1158;
			this._idDic[1159] = typeof(HeroJobLevelUpAck);
			this._typeDic[typeof(HeroJobLevelUpAck)] = 1159;
			this._idDic[1160] = typeof(HeroJobLevelUpReq);
			this._typeDic[typeof(HeroJobLevelUpReq)] = 1160;
			this._idDic[1161] = typeof(HeroJobTransferAck);
			this._typeDic[typeof(HeroJobTransferAck)] = 1161;
			this._idDic[1162] = typeof(HeroJobTransferReq);
			this._typeDic[typeof(HeroJobTransferReq)] = 1162;
			this._idDic[1163] = typeof(HeroJobUnlockAck);
			this._typeDic[typeof(HeroJobUnlockAck)] = 1163;
			this._idDic[1164] = typeof(HeroJobUnlockReq);
			this._typeDic[typeof(HeroJobUnlockReq)] = 1164;
			this._idDic[1165] = typeof(HeroSkillsSelectAck);
			this._typeDic[typeof(HeroSkillsSelectAck)] = 1165;
			this._idDic[1166] = typeof(HeroSkillsSelectReq);
			this._typeDic[typeof(HeroSkillsSelectReq)] = 1166;
			this._idDic[1167] = typeof(HeroSoldierSelectAck);
			this._typeDic[typeof(HeroSoldierSelectAck)] = 1167;
			this._idDic[1168] = typeof(HeroSoldierSelectReq);
			this._typeDic[typeof(HeroSoldierSelectReq)] = 1168;
			this._idDic[1169] = typeof(HeroStarLevelLevelUpAck);
			this._typeDic[typeof(HeroStarLevelLevelUpAck)] = 1169;
			this._idDic[1170] = typeof(HeroStarLevelLevelUpReq);
			this._typeDic[typeof(HeroStarLevelLevelUpReq)] = 1170;
			this._idDic[1171] = typeof(HeroTrainningLevelAttackAck);
			this._typeDic[typeof(HeroTrainningLevelAttackAck)] = 1171;
			this._idDic[1172] = typeof(HeroTrainningLevelAttackReq);
			this._typeDic[typeof(HeroTrainningLevelAttackReq)] = 1172;
			this._idDic[1173] = typeof(HeroTrainningLevelBattleFinishedAck);
			this._typeDic[typeof(HeroTrainningLevelBattleFinishedAck)] = 1173;
			this._idDic[1174] = typeof(HeroTrainningLevelBattleFinishedReq);
			this._typeDic[typeof(HeroTrainningLevelBattleFinishedReq)] = 1174;
			this._idDic[1175] = typeof(LevelDanmakuGetAck);
			this._typeDic[typeof(LevelDanmakuGetAck)] = 1175;
			this._idDic[1176] = typeof(LevelDanmakuGetReq);
			this._typeDic[typeof(LevelDanmakuGetReq)] = 1176;
			this._idDic[1177] = typeof(LevelDanmakuPostAck);
			this._typeDic[typeof(LevelDanmakuPostAck)] = 1177;
			this._idDic[1178] = typeof(LevelDanmakuPostReq);
			this._typeDic[typeof(LevelDanmakuPostReq)] = 1178;
			this._idDic[1179] = typeof(LevelScenarioHandleAck);
			this._typeDic[typeof(LevelScenarioHandleAck)] = 1179;
			this._idDic[1180] = typeof(LevelScenarioHandleReq);
			this._typeDic[typeof(LevelScenarioHandleReq)] = 1180;
			this._idDic[1181] = typeof(LevelWayPointBattleFinishAck);
			this._typeDic[typeof(LevelWayPointBattleFinishAck)] = 1181;
			this._idDic[1182] = typeof(LevelWayPointBattleFinishReq);
			this._typeDic[typeof(LevelWayPointBattleFinishReq)] = 1182;
			this._idDic[1183] = typeof(LevelWayPointMoveAck);
			this._typeDic[typeof(LevelWayPointMoveAck)] = 1183;
			this._idDic[1184] = typeof(LevelWayPointMoveReq);
			this._typeDic[typeof(LevelWayPointMoveReq)] = 1184;
			this._idDic[1185] = typeof(MailAttachmentsGetAck);
			this._typeDic[typeof(MailAttachmentsGetAck)] = 1185;
			this._idDic[1186] = typeof(MailAttachmentsGetReq);
			this._typeDic[typeof(MailAttachmentsGetReq)] = 1186;
			this._idDic[1187] = typeof(MailReadAck);
			this._typeDic[typeof(MailReadAck)] = 1187;
			this._idDic[1188] = typeof(MailReadReq);
			this._typeDic[typeof(MailReadReq)] = 1188;
			this._idDic[1189] = typeof(MailsChangedNtf);
			this._typeDic[typeof(MailsChangedNtf)] = 1189;
			this._idDic[1190] = typeof(MailsGetAck);
			this._typeDic[typeof(MailsGetAck)] = 1190;
			this._idDic[1191] = typeof(MailsGetReq);
			this._typeDic[typeof(MailsGetReq)] = 1191;
			this._idDic[1192] = typeof(MemoryCorridorLevelAttackAck);
			this._typeDic[typeof(MemoryCorridorLevelAttackAck)] = 1192;
			this._idDic[1193] = typeof(MemoryCorridorLevelAttackReq);
			this._typeDic[typeof(MemoryCorridorLevelAttackReq)] = 1193;
			this._idDic[1194] = typeof(MemoryCorridorLevelBattleFinishedAck);
			this._typeDic[typeof(MemoryCorridorLevelBattleFinishedAck)] = 1194;
			this._idDic[1195] = typeof(MemoryCorridorLevelBattleFinishedReq);
			this._typeDic[typeof(MemoryCorridorLevelBattleFinishedReq)] = 1195;
			this._idDic[1196] = typeof(NewAnnouncementNtf);
			this._typeDic[typeof(NewAnnouncementNtf)] = 1196;
			this._idDic[1197] = typeof(NewMarqueeNtf);
			this._typeDic[typeof(NewMarqueeNtf)] = 1197;
			this._idDic[1198] = typeof(NewOperationalActivityNtf);
			this._typeDic[typeof(NewOperationalActivityNtf)] = 1198;
			this._idDic[1199] = typeof(NewSurveyNtf);
			this._typeDic[typeof(NewSurveyNtf)] = 1199;
			this._idDic[1200] = typeof(OpenSurveyAck);
			this._typeDic[typeof(OpenSurveyAck)] = 1200;
			this._idDic[1201] = typeof(OpenSurveyReq);
			this._typeDic[typeof(OpenSurveyReq)] = 1201;
			this._idDic[1202] = typeof(OperationalActivityExchangeItemGroupAck);
			this._typeDic[typeof(OperationalActivityExchangeItemGroupAck)] = 1202;
			this._idDic[1203] = typeof(OperationalActivityExchangeItemGroupReq);
			this._typeDic[typeof(OperationalActivityExchangeItemGroupReq)] = 1203;
			this._idDic[1204] = typeof(OperationalActivityGainRewardAck);
			this._typeDic[typeof(OperationalActivityGainRewardAck)] = 1204;
			this._idDic[1205] = typeof(OperationalActivityGainRewardReq);
			this._typeDic[typeof(OperationalActivityGainRewardReq)] = 1205;
			this._idDic[1206] = typeof(PlayerInfoInitAck);
			this._typeDic[typeof(PlayerInfoInitAck)] = 1206;
			this._idDic[1207] = typeof(PlayerInfoInitEndNtf);
			this._typeDic[typeof(PlayerInfoInitEndNtf)] = 1207;
			this._idDic[1208] = typeof(PlayerInfoInitReq);
			this._typeDic[typeof(PlayerInfoInitReq)] = 1208;
			this._idDic[1209] = typeof(PlayerNameChangeAck);
			this._typeDic[typeof(PlayerNameChangeAck)] = 1209;
			this._idDic[1210] = typeof(PlayerNameChangeReq);
			this._typeDic[typeof(PlayerNameChangeReq)] = 1210;
			this._idDic[1211] = typeof(ProChangedGoodsNtf);
			this._typeDic[typeof(ProChangedGoodsNtf)] = 1211;
			this._idDic[1212] = typeof(RandomEventNtf);
			this._typeDic[typeof(RandomEventNtf)] = 1212;
			this._idDic[1213] = typeof(RandomStoreBuyStoreItemAck);
			this._typeDic[typeof(RandomStoreBuyStoreItemAck)] = 1213;
			this._idDic[1214] = typeof(RandomStoreBuyStoreItemReq);
			this._typeDic[typeof(RandomStoreBuyStoreItemReq)] = 1214;
			this._idDic[1215] = typeof(RandomStoreFlushAck);
			this._typeDic[typeof(RandomStoreFlushAck)] = 1215;
			this._idDic[1216] = typeof(RandomStoreFlushReq);
			this._typeDic[typeof(RandomStoreFlushReq)] = 1216;
			this._idDic[1217] = typeof(RandomStoreGetAck);
			this._typeDic[typeof(RandomStoreGetAck)] = 1217;
			this._idDic[1218] = typeof(RandomStoreGetReq);
			this._typeDic[typeof(RandomStoreGetReq)] = 1218;
			this._idDic[1219] = typeof(RankingListInfoQueryAck);
			this._typeDic[typeof(RankingListInfoQueryAck)] = 1219;
			this._idDic[1220] = typeof(RankingListInfoQueryReq);
			this._typeDic[typeof(RankingListInfoQueryReq)] = 1220;
			this._idDic[1221] = typeof(RemoveAnnouncementNtf);
			this._typeDic[typeof(RemoveAnnouncementNtf)] = 1221;
			this._idDic[1222] = typeof(RiftChapterRewardGainAck);
			this._typeDic[typeof(RiftChapterRewardGainAck)] = 1222;
			this._idDic[1223] = typeof(RiftChapterRewardGainReq);
			this._typeDic[typeof(RiftChapterRewardGainReq)] = 1223;
			this._idDic[1224] = typeof(RiftLevelAttackAck);
			this._typeDic[typeof(RiftLevelAttackAck)] = 1224;
			this._idDic[1225] = typeof(RiftLevelAttackReq);
			this._typeDic[typeof(RiftLevelAttackReq)] = 1225;
			this._idDic[1226] = typeof(RiftLevelBattleFinishedAck);
			this._typeDic[typeof(RiftLevelBattleFinishedAck)] = 1226;
			this._idDic[1227] = typeof(RiftLevelBattleFinishedReq);
			this._typeDic[typeof(RiftLevelBattleFinishedReq)] = 1227;
			this._idDic[1228] = typeof(RiftLevelRaidAck);
			this._typeDic[typeof(RiftLevelRaidAck)] = 1228;
			this._idDic[1229] = typeof(RiftLevelRaidReq);
			this._typeDic[typeof(RiftLevelRaidReq)] = 1229;
			this._idDic[1230] = typeof(SelectCardAck);
			this._typeDic[typeof(SelectCardAck)] = 1230;
			this._idDic[1231] = typeof(SelectCardReq);
			this._typeDic[typeof(SelectCardReq)] = 1231;
			this._idDic[1232] = typeof(SellBagItemAck);
			this._typeDic[typeof(SellBagItemAck)] = 1232;
			this._idDic[1233] = typeof(SellBagItemReq);
			this._typeDic[typeof(SellBagItemReq)] = 1233;
			this._idDic[1234] = typeof(SetProtagonistAck);
			this._typeDic[typeof(SetProtagonistAck)] = 1234;
			this._idDic[1235] = typeof(SetProtagonistReq);
			this._typeDic[typeof(SetProtagonistReq)] = 1235;
			this._idDic[1236] = typeof(TeamRoomAuthorityChangeAck);
			this._typeDic[typeof(TeamRoomAuthorityChangeAck)] = 1236;
			this._idDic[1237] = typeof(TeamRoomAuthorityChangeNtf);
			this._typeDic[typeof(TeamRoomAuthorityChangeNtf)] = 1237;
			this._idDic[1238] = typeof(TeamRoomAuthorityChangeReq);
			this._typeDic[typeof(TeamRoomAuthorityChangeReq)] = 1238;
			this._idDic[1239] = typeof(TeamRoomAutoMatchAck);
			this._typeDic[typeof(TeamRoomAutoMatchAck)] = 1239;
			this._idDic[1240] = typeof(TeamRoomAutoMatchCancelAck);
			this._typeDic[typeof(TeamRoomAutoMatchCancelAck)] = 1240;
			this._idDic[1241] = typeof(TeamRoomAutoMatchCancelReq);
			this._typeDic[typeof(TeamRoomAutoMatchCancelReq)] = 1241;
			this._idDic[1242] = typeof(TeamRoomAutoMatchInfoNtf);
			this._typeDic[typeof(TeamRoomAutoMatchInfoNtf)] = 1242;
			this._idDic[1243] = typeof(TeamRoomAutoMatchReq);
			this._typeDic[typeof(TeamRoomAutoMatchReq)] = 1243;
			this._idDic[1244] = typeof(TeamRoomCreateAck);
			this._typeDic[typeof(TeamRoomCreateAck)] = 1244;
			this._idDic[1245] = typeof(TeamRoomCreateReq);
			this._typeDic[typeof(TeamRoomCreateReq)] = 1245;
			this._idDic[1246] = typeof(TeamRoomGetAck);
			this._typeDic[typeof(TeamRoomGetAck)] = 1246;
			this._idDic[1247] = typeof(TeamRoomGetReq);
			this._typeDic[typeof(TeamRoomGetReq)] = 1247;
			this._idDic[1248] = typeof(TeamRoomInvitationRefusedAck);
			this._typeDic[typeof(TeamRoomInvitationRefusedAck)] = 1248;
			this._idDic[1249] = typeof(TeamRoomInvitationRefusedNtf);
			this._typeDic[typeof(TeamRoomInvitationRefusedNtf)] = 1249;
			this._idDic[1250] = typeof(TeamRoomInvitationRefusedReq);
			this._typeDic[typeof(TeamRoomInvitationRefusedReq)] = 1250;
			this._idDic[1251] = typeof(TeamRoomInviteAck);
			this._typeDic[typeof(TeamRoomInviteAck)] = 1251;
			this._idDic[1252] = typeof(TeamRoomInviteNtf);
			this._typeDic[typeof(TeamRoomInviteNtf)] = 1252;
			this._idDic[1253] = typeof(TeamRoomInviteReq);
			this._typeDic[typeof(TeamRoomInviteReq)] = 1253;
			this._idDic[1254] = typeof(TeamRoomJoinAck);
			this._typeDic[typeof(TeamRoomJoinAck)] = 1254;
			this._idDic[1255] = typeof(TeamRoomJoinReq);
			this._typeDic[typeof(TeamRoomJoinReq)] = 1255;
			this._idDic[1256] = typeof(TeamRoomPlayerJoinNtf);
			this._typeDic[typeof(TeamRoomPlayerJoinNtf)] = 1256;
			this._idDic[1257] = typeof(TeamRoomPlayerLeaveWaitingListAndJoinRoomNtf);
			this._typeDic[typeof(TeamRoomPlayerLeaveWaitingListAndJoinRoomNtf)] = 1257;
			this._idDic[1258] = typeof(TeamRoomPlayerQuitNtf);
			this._typeDic[typeof(TeamRoomPlayerQuitNtf)] = 1258;
			this._idDic[1259] = typeof(TeamRoomQuitAck);
			this._typeDic[typeof(TeamRoomQuitAck)] = 1259;
			this._idDic[1260] = typeof(TeamRoomQuitReq);
			this._typeDic[typeof(TeamRoomQuitReq)] = 1260;
			this._idDic[1261] = typeof(TeamRoomViewAck);
			this._typeDic[typeof(TeamRoomViewAck)] = 1261;
			this._idDic[1262] = typeof(TeamRoomViewReq);
			this._typeDic[typeof(TeamRoomViewReq)] = 1262;
			this._idDic[1263] = typeof(ThearchyTrialLevelAttackAck);
			this._typeDic[typeof(ThearchyTrialLevelAttackAck)] = 1263;
			this._idDic[1264] = typeof(ThearchyTrialLevelAttackReq);
			this._typeDic[typeof(ThearchyTrialLevelAttackReq)] = 1264;
			this._idDic[1265] = typeof(ThearchyTrialLevelBattleFinishedAck);
			this._typeDic[typeof(ThearchyTrialLevelBattleFinishedAck)] = 1265;
			this._idDic[1266] = typeof(ThearchyTrialLevelBattleFinishedReq);
			this._typeDic[typeof(ThearchyTrialLevelBattleFinishedReq)] = 1266;
			this._idDic[1267] = typeof(TreasureLevelAttackAck);
			this._typeDic[typeof(TreasureLevelAttackAck)] = 1267;
			this._idDic[1268] = typeof(TreasureLevelAttackReq);
			this._typeDic[typeof(TreasureLevelAttackReq)] = 1268;
			this._idDic[1269] = typeof(TreasureLevelBattleFinishedAck);
			this._typeDic[typeof(TreasureLevelBattleFinishedAck)] = 1269;
			this._idDic[1270] = typeof(TreasureLevelBattleFinishedReq);
			this._typeDic[typeof(TreasureLevelBattleFinishedReq)] = 1270;
			this._idDic[1271] = typeof(UpdateOperationalActivityNtf);
			this._typeDic[typeof(UpdateOperationalActivityNtf)] = 1271;
			this._idDic[1272] = typeof(UpdateSurveyNtf);
			this._typeDic[typeof(UpdateSurveyNtf)] = 1272;
			this._idDic[1273] = typeof(UseBagItemAck);
			this._typeDic[typeof(UseBagItemAck)] = 1273;
			this._idDic[1274] = typeof(UseBagItemReq);
			this._typeDic[typeof(UseBagItemReq)] = 1274;
			this._idDic[1275] = typeof(UserGuideSetAck);
			this._typeDic[typeof(UserGuideSetAck)] = 1275;
			this._idDic[1276] = typeof(UserGuideSetReq);
			this._typeDic[typeof(UserGuideSetReq)] = 1276;
			this._idDic[1277] = typeof(DSHeroAssistantNtf);
			this._typeDic[typeof(DSHeroAssistantNtf)] = 1277;
			this._idDic[1278] = typeof(DSTrainingGroundNtf);
			this._typeDic[typeof(DSTrainingGroundNtf)] = 1278;
			this._idDic[1279] = typeof(TrainingGroundTechLevelupAck);
			this._typeDic[typeof(TrainingGroundTechLevelupAck)] = 1279;
			this._idDic[1280] = typeof(TrainingGroundTechLevelupReq);
			this._typeDic[typeof(TrainingGroundTechLevelupReq)] = 1280;
			this._idDic[1282] = typeof(TeamRoomSelfKickOutNtf);
			this._typeDic[typeof(TeamRoomSelfKickOutNtf)] = 1282;
			this._idDic[1283] = typeof(BusinessCardSelectAck);
			this._typeDic[typeof(BusinessCardSelectAck)] = 1283;
			this._idDic[1284] = typeof(BusinessCardSelectReq);
			this._typeDic[typeof(BusinessCardSelectReq)] = 1284;
			this._idDic[1285] = typeof(DSFriendNtf);
			this._typeDic[typeof(DSFriendNtf)] = 1285;
			this._idDic[1286] = typeof(FriendInfoUpdateNtf);
			this._typeDic[typeof(FriendInfoUpdateNtf)] = 1286;
			this._idDic[1287] = typeof(BusinessCardDescUpdateAck);
			this._typeDic[typeof(BusinessCardDescUpdateAck)] = 1287;
			this._idDic[1288] = typeof(BusinessCardDescUpdateReq);
			this._typeDic[typeof(BusinessCardDescUpdateReq)] = 1288;
			this._idDic[1289] = typeof(BusinessCardHeroSetUpdateAck);
			this._typeDic[typeof(BusinessCardHeroSetUpdateAck)] = 1289;
			this._idDic[1290] = typeof(BusinessCardHeroSetUpdateReq);
			this._typeDic[typeof(BusinessCardHeroSetUpdateReq)] = 1290;
			this._idDic[1291] = typeof(LikesSendAck);
			this._typeDic[typeof(LikesSendAck)] = 1291;
			this._idDic[1292] = typeof(LikesSendReq);
			this._typeDic[typeof(LikesSendReq)] = 1292;
			this._idDic[1295] = typeof(HeroAssistantAssignToTaskAck);
			this._typeDic[typeof(HeroAssistantAssignToTaskAck)] = 1295;
			this._idDic[1296] = typeof(HeroAssistantAssignToTaskReq);
			this._typeDic[typeof(HeroAssistantAssignToTaskReq)] = 1296;
			this._idDic[1297] = typeof(HeroAssistantCancelTaskAck);
			this._typeDic[typeof(HeroAssistantCancelTaskAck)] = 1297;
			this._idDic[1298] = typeof(HeroAssistantCancelTaskReq);
			this._typeDic[typeof(HeroAssistantCancelTaskReq)] = 1298;
			this._idDic[1299] = typeof(HeroAssistantClaimRewardAck);
			this._typeDic[typeof(HeroAssistantClaimRewardAck)] = 1299;
			this._idDic[1300] = typeof(HeroAssistantClaimRewardReq);
			this._typeDic[typeof(HeroAssistantClaimRewardReq)] = 1300;
			this._idDic[1302] = typeof(BattleRoomCreateAck);
			this._typeDic[typeof(BattleRoomCreateAck)] = 1302;
			this._idDic[1305] = typeof(TeamBattleRoomCreateReq);
			this._typeDic[typeof(TeamBattleRoomCreateReq)] = 1305;
			this._idDic[1312] = typeof(ChatGroupChangeOwnerAck);
			this._typeDic[typeof(ChatGroupChangeOwnerAck)] = 1312;
			this._idDic[1313] = typeof(ChatGroupChangeOwnerReq);
			this._typeDic[typeof(ChatGroupChangeOwnerReq)] = 1313;
			this._idDic[1314] = typeof(ChatGroupCreateChatGroupAck);
			this._typeDic[typeof(ChatGroupCreateChatGroupAck)] = 1314;
			this._idDic[1315] = typeof(ChatGroupCreateChatGroupReq);
			this._typeDic[typeof(ChatGroupCreateChatGroupReq)] = 1315;
			this._idDic[1316] = typeof(ChatGroupGetChatGroupAck);
			this._typeDic[typeof(ChatGroupGetChatGroupAck)] = 1316;
			this._idDic[1317] = typeof(ChatGroupGetChatGroupMemberAck);
			this._typeDic[typeof(ChatGroupGetChatGroupMemberAck)] = 1317;
			this._idDic[1318] = typeof(ChatGroupGetChatGroupMemberReq);
			this._typeDic[typeof(ChatGroupGetChatGroupMemberReq)] = 1318;
			this._idDic[1319] = typeof(ChatGroupGetChatGroupReq);
			this._typeDic[typeof(ChatGroupGetChatGroupReq)] = 1319;
			this._idDic[1320] = typeof(ChatGroupInviteToChatGroupAck);
			this._typeDic[typeof(ChatGroupInviteToChatGroupAck)] = 1320;
			this._idDic[1321] = typeof(ChatGroupInviteToChatGroupReq);
			this._typeDic[typeof(ChatGroupInviteToChatGroupReq)] = 1321;
			this._idDic[1322] = typeof(ChatGroupLeaveChatGroupAck);
			this._typeDic[typeof(ChatGroupLeaveChatGroupAck)] = 1322;
			this._idDic[1323] = typeof(ChatGroupLeaveChatGroupReq);
			this._typeDic[typeof(ChatGroupLeaveChatGroupReq)] = 1323;
			this._idDic[1324] = typeof(ChatGroupUpdateNtf);
			this._typeDic[typeof(ChatGroupUpdateNtf)] = 1324;
			this._idDic[1331] = typeof(BattleRoomHeroSetupAck);
			this._typeDic[typeof(BattleRoomHeroSetupAck)] = 1331;
			this._idDic[1332] = typeof(BattleRoomHeroSetupNtf);
			this._typeDic[typeof(BattleRoomHeroSetupNtf)] = 1332;
			this._idDic[1333] = typeof(BattleRoomHeroSetupReq);
			this._typeDic[typeof(BattleRoomHeroSetupReq)] = 1333;
			this._idDic[1334] = typeof(BattleRoomHeroSwapAck);
			this._typeDic[typeof(BattleRoomHeroSwapAck)] = 1334;
			this._idDic[1335] = typeof(BattleRoomHeroSwapReq);
			this._typeDic[typeof(BattleRoomHeroSwapReq)] = 1335;
			this._idDic[1339] = typeof(BattleRoomPlayerStatusChangedNtf);
			this._typeDic[typeof(BattleRoomPlayerStatusChangedNtf)] = 1339;
			this._idDic[1340] = typeof(BattleRoomPlayerStatusChangeAck);
			this._typeDic[typeof(BattleRoomPlayerStatusChangeAck)] = 1340;
			this._idDic[1341] = typeof(BattleRoomPlayerStatusChangeReq);
			this._typeDic[typeof(BattleRoomPlayerStatusChangeReq)] = 1341;
			this._idDic[1342] = typeof(HeroRandomActionSetAck);
			this._typeDic[typeof(HeroRandomActionSetAck)] = 1342;
			this._idDic[1343] = typeof(HeroRandomActionSetReq);
			this._typeDic[typeof(HeroRandomActionSetReq)] = 1343;
			this._idDic[1344] = typeof(BagItemDecomposeAck);
			this._typeDic[typeof(BagItemDecomposeAck)] = 1344;
			this._idDic[1345] = typeof(BagItemDecomposeReq);
			this._typeDic[typeof(BagItemDecomposeReq)] = 1345;
			this._idDic[1349] = typeof(BattleRoomBattleCommandExecuteAck);
			this._typeDic[typeof(BattleRoomBattleCommandExecuteAck)] = 1349;
			this._idDic[1350] = typeof(BattleRoomBattleCommandExecuteNtf);
			this._typeDic[typeof(BattleRoomBattleCommandExecuteNtf)] = 1350;
			this._idDic[1351] = typeof(BattleRoomBattleCommandExecuteReq);
			this._typeDic[typeof(BattleRoomBattleCommandExecuteReq)] = 1351;
			this._idDic[1353] = typeof(BattlePracticeAcceptAck);
			this._typeDic[typeof(BattlePracticeAcceptAck)] = 1353;
			this._idDic[1354] = typeof(BattlePracticeAcceptReq);
			this._typeDic[typeof(BattlePracticeAcceptReq)] = 1354;
			this._idDic[1355] = typeof(BattlePracticeCancelAck);
			this._typeDic[typeof(BattlePracticeCancelAck)] = 1355;
			this._idDic[1356] = typeof(BattlePracticeCancelReq);
			this._typeDic[typeof(BattlePracticeCancelReq)] = 1356;
			this._idDic[1357] = typeof(BattlePracticeDeclineAck);
			this._typeDic[typeof(BattlePracticeDeclineAck)] = 1357;
			this._idDic[1358] = typeof(BattlePracticeDeclinedNtf);
			this._typeDic[typeof(BattlePracticeDeclinedNtf)] = 1358;
			this._idDic[1359] = typeof(BattlePracticeDeclineReq);
			this._typeDic[typeof(BattlePracticeDeclineReq)] = 1359;
			this._idDic[1360] = typeof(BattlePracticeFailNtf);
			this._typeDic[typeof(BattlePracticeFailNtf)] = 1360;
			this._idDic[1361] = typeof(BattlePracticeInviteAck);
			this._typeDic[typeof(BattlePracticeInviteAck)] = 1361;
			this._idDic[1362] = typeof(BattlePracticeInvitedNtf);
			this._typeDic[typeof(BattlePracticeInvitedNtf)] = 1362;
			this._idDic[1363] = typeof(BattlePracticeInviteReq);
			this._typeDic[typeof(BattlePracticeInviteReq)] = 1363;
			this._idDic[1366] = typeof(BattleRoomQuitAck);
			this._typeDic[typeof(BattleRoomQuitAck)] = 1366;
			this._idDic[1367] = typeof(BattleRoomQuitReq);
			this._typeDic[typeof(BattleRoomQuitReq)] = 1367;
			this._idDic[1368] = typeof(ChatGroupKickUserAck);
			this._typeDic[typeof(ChatGroupKickUserAck)] = 1368;
			this._idDic[1369] = typeof(ChatGroupKickUserReq);
			this._typeDic[typeof(ChatGroupKickUserReq)] = 1369;
			this._idDic[1370] = typeof(FriendGetUserSummaryAck);
			this._typeDic[typeof(FriendGetUserSummaryAck)] = 1370;
			this._idDic[1371] = typeof(FriendGetUserSummaryReq);
			this._typeDic[typeof(FriendGetUserSummaryReq)] = 1371;
			this._idDic[1372] = typeof(BattleRoomPlayerActionBeginAck);
			this._typeDic[typeof(BattleRoomPlayerActionBeginAck)] = 1372;
			this._idDic[1373] = typeof(BattleRoomPlayerActionBeginReq);
			this._typeDic[typeof(BattleRoomPlayerActionBeginReq)] = 1373;
			this._idDic[1374] = typeof(BattleRoomTeamBattleFinishNtf);
			this._typeDic[typeof(BattleRoomTeamBattleFinishNtf)] = 1374;
			this._idDic[1375] = typeof(BattleRoomTeamBattleJoinNtf);
			this._typeDic[typeof(BattleRoomTeamBattleJoinNtf)] = 1375;
			this._idDic[1376] = typeof(BattleRoomTeamBattleStartNtf);
			this._typeDic[typeof(BattleRoomTeamBattleStartNtf)] = 1376;
			this._idDic[1377] = typeof(FriendshipPointsClaimAck);
			this._typeDic[typeof(FriendshipPointsClaimAck)] = 1377;
			this._idDic[1378] = typeof(FriendshipPointsClaimReq);
			this._typeDic[typeof(FriendshipPointsClaimReq)] = 1378;
			this._idDic[1379] = typeof(FriendshipPointsSendAck);
			this._typeDic[typeof(FriendshipPointsSendAck)] = 1379;
			this._idDic[1380] = typeof(FriendshipPointsSendReq);
			this._typeDic[typeof(FriendshipPointsSendReq)] = 1380;
			this._idDic[1381] = typeof(ChatGroupChangeNameAck);
			this._typeDic[typeof(ChatGroupChangeNameAck)] = 1381;
			this._idDic[1382] = typeof(ChatGroupChangeNameReq);
			this._typeDic[typeof(ChatGroupChangeNameReq)] = 1382;
			this._idDic[1383] = typeof(BattleRoomPVPBattleFinishNtf);
			this._typeDic[typeof(BattleRoomPVPBattleFinishNtf)] = 1383;
			this._idDic[1384] = typeof(BattleRoomPVPBattleJoinNtf);
			this._typeDic[typeof(BattleRoomPVPBattleJoinNtf)] = 1384;
			this._idDic[1385] = typeof(BattleRoomPVPBattleStartNtf);
			this._typeDic[typeof(BattleRoomPVPBattleStartNtf)] = 1385;
			this._idDic[1386] = typeof(DSHeroPhantomNtf);
			this._typeDic[typeof(DSHeroPhantomNtf)] = 1386;
			this._idDic[1387] = typeof(HeroPhantomAttackAck);
			this._typeDic[typeof(HeroPhantomAttackAck)] = 1387;
			this._idDic[1388] = typeof(HeroPhantomAttackReq);
			this._typeDic[typeof(HeroPhantomAttackReq)] = 1388;
			this._idDic[1389] = typeof(HeroPhantomBattleFinishedAck);
			this._typeDic[typeof(HeroPhantomBattleFinishedAck)] = 1389;
			this._idDic[1390] = typeof(HeroPhantomBattleFinishedReq);
			this._typeDic[typeof(HeroPhantomBattleFinishedReq)] = 1390;
			this._idDic[1395] = typeof(BattleRoomGetAck);
			this._typeDic[typeof(BattleRoomGetAck)] = 1395;
			this._idDic[1396] = typeof(BattleRoomGetReq);
			this._typeDic[typeof(BattleRoomGetReq)] = 1396;
			this._idDic[1397] = typeof(ChatContactUserSummaryInfoAck);
			this._typeDic[typeof(ChatContactUserSummaryInfoAck)] = 1397;
			this._idDic[1398] = typeof(ChatContactUserSummaryInfoReq);
			this._typeDic[typeof(ChatContactUserSummaryInfoReq)] = 1398;
			this._idDic[1399] = typeof(DSCooperateBattleNtf);
			this._typeDic[typeof(DSCooperateBattleNtf)] = 1399;
			this._idDic[1400] = typeof(EquipmentEnchantAck);
			this._typeDic[typeof(EquipmentEnchantAck)] = 1400;
			this._idDic[1401] = typeof(EquipmentEnchantReq);
			this._typeDic[typeof(EquipmentEnchantReq)] = 1401;
			this._idDic[1402] = typeof(EquipmentEnchantSaveAck);
			this._typeDic[typeof(EquipmentEnchantSaveAck)] = 1402;
			this._idDic[1403] = typeof(EquipmentEnchantSaveReq);
			this._typeDic[typeof(EquipmentEnchantSaveReq)] = 1403;
			this._idDic[1404] = typeof(BattleRoomPlayerBattleInfoInitNtf);
			this._typeDic[typeof(BattleRoomPlayerBattleInfoInitNtf)] = 1404;
			this._idDic[1405] = typeof(BattleRoomQuitNtf);
			this._typeDic[typeof(BattleRoomQuitNtf)] = 1405;
			this._idDic[1406] = typeof(MailAttachmentAutoGetAck);
			this._typeDic[typeof(MailAttachmentAutoGetAck)] = 1406;
			this._idDic[1407] = typeof(MailAttachmentAutoGetReq);
			this._typeDic[typeof(MailAttachmentAutoGetReq)] = 1407;
			this._idDic[1408] = typeof(DSNoviceNtf);
			this._typeDic[typeof(DSNoviceNtf)] = 1408;
			this._idDic[1409] = typeof(NoviceClaimRewardAck);
			this._typeDic[typeof(NoviceClaimRewardAck)] = 1409;
			this._idDic[1410] = typeof(NoviceClaimRewardReq);
			this._typeDic[typeof(NoviceClaimRewardReq)] = 1410;
			this._idDic[1411] = typeof(ClientHeartBeatNtf);
			this._typeDic[typeof(ClientHeartBeatNtf)] = 1411;
			this._idDic[1412] = typeof(ClientCheatNtf);
			this._typeDic[typeof(ClientCheatNtf)] = 1412;
			this._idDic[1414] = typeof(FriendSocialRelationUpdateNtf);
			this._typeDic[typeof(FriendSocialRelationUpdateNtf)] = 1414;
			this._idDic[1415] = typeof(ClientAppPauseNtf);
			this._typeDic[typeof(ClientAppPauseNtf)] = 1415;
			this._idDic[1416] = typeof(ClientAppResumeNtf);
			this._typeDic[typeof(ClientAppResumeNtf)] = 1416;
			this._idDic[1419] = typeof(TeamRoomInviteeLevelInfoNtf);
			this._typeDic[typeof(TeamRoomInviteeLevelInfoNtf)] = 1419;
			this._idDic[1420] = typeof(GameRatingOpenAck);
			this._typeDic[typeof(GameRatingOpenAck)] = 1420;
			this._idDic[1421] = typeof(GameRatingOpenReq);
			this._typeDic[typeof(GameRatingOpenReq)] = 1421;
			this._idDic[1422] = typeof(RealTimePVPWaitingForOpponentAck);
			this._typeDic[typeof(RealTimePVPWaitingForOpponentAck)] = 1422;
			this._idDic[1423] = typeof(RealTimePVPWaitingForOpponentReq);
			this._typeDic[typeof(RealTimePVPWaitingForOpponentReq)] = 1423;
			this._idDic[1424] = typeof(ArenaFlushOpponentsNtf);
			this._typeDic[typeof(ArenaFlushOpponentsNtf)] = 1424;
			this._idDic[1425] = typeof(RealTimePVPMatchupNtf);
			this._typeDic[typeof(RealTimePVPMatchupNtf)] = 1425;
			this._idDic[1426] = typeof(BoughtRechargeStoreItemNtf);
			this._typeDic[typeof(BoughtRechargeStoreItemNtf)] = 1426;
			this._idDic[1427] = typeof(DSRechargeStoreNtf);
			this._typeDic[typeof(DSRechargeStoreNtf)] = 1427;
			this._idDic[1428] = typeof(BattleRoomRealTimePVPBattleJoinNtf);
			this._typeDic[typeof(BattleRoomRealTimePVPBattleJoinNtf)] = 1428;
			this._idDic[1429] = typeof(HeadPortraitSetAck);
			this._typeDic[typeof(HeadPortraitSetAck)] = 1429;
			this._idDic[1430] = typeof(HeadPortraitSetReq);
			this._typeDic[typeof(HeadPortraitSetReq)] = 1430;
			this._idDic[1431] = typeof(DSResourceNtf);
			this._typeDic[typeof(DSResourceNtf)] = 1431;
			this._idDic[1432] = typeof(HeadFrameSetAck);
			this._typeDic[typeof(HeadFrameSetAck)] = 1432;
			this._idDic[1433] = typeof(HeadFrameSetReq);
			this._typeDic[typeof(HeadFrameSetReq)] = 1433;
			this._idDic[1434] = typeof(BattleRoomRealTimePVPBattleFinishNtf);
			this._typeDic[typeof(BattleRoomRealTimePVPBattleFinishNtf)] = 1434;
			this._idDic[1435] = typeof(DSRealTimePVPNtf);
			this._typeDic[typeof(DSRealTimePVPNtf)] = 1435;
			this._idDic[1436] = typeof(DSRaffleNtf);
			this._typeDic[typeof(DSRaffleNtf)] = 1436;
			this._idDic[1437] = typeof(RaffleDrawAck);
			this._typeDic[typeof(RaffleDrawAck)] = 1437;
			this._idDic[1438] = typeof(RaffleDrawReq);
			this._typeDic[typeof(RaffleDrawReq)] = 1438;
			this._idDic[1439] = typeof(RealTimePVPCancelWaitingForOpponentAck);
			this._typeDic[typeof(RealTimePVPCancelWaitingForOpponentAck)] = 1439;
			this._idDic[1440] = typeof(RealTimePVPCancelWaitingForOpponentReq);
			this._typeDic[typeof(RealTimePVPCancelWaitingForOpponentReq)] = 1440;
			this._idDic[1441] = typeof(RealTimePVPGetInfoAck);
			this._typeDic[typeof(RealTimePVPGetInfoAck)] = 1441;
			this._idDic[1442] = typeof(RealTimePVPGetInfoReq);
			this._typeDic[typeof(RealTimePVPGetInfoReq)] = 1442;
			this._idDic[1443] = typeof(RealTimePVPGetTopPlayersAck);
			this._typeDic[typeof(RealTimePVPGetTopPlayersAck)] = 1443;
			this._idDic[1444] = typeof(RealTimePVPGetTopPlayersReq);
			this._typeDic[typeof(RealTimePVPGetTopPlayersReq)] = 1444;
			this._idDic[1445] = typeof(GiftStoreBuyGoodsNtf);
			this._typeDic[typeof(GiftStoreBuyGoodsNtf)] = 1445;
			this._idDic[1446] = typeof(GiftStoreItemBuyAck);
			this._typeDic[typeof(GiftStoreItemBuyAck)] = 1446;
			this._idDic[1447] = typeof(GiftStoreItemBuyReq);
			this._typeDic[typeof(GiftStoreItemBuyReq)] = 1447;
			this._idDic[1448] = typeof(CharSkinTakeOffAck);
			this._typeDic[typeof(CharSkinTakeOffAck)] = 1448;
			this._idDic[1449] = typeof(CharSkinTakeOffReq);
			this._typeDic[typeof(CharSkinTakeOffReq)] = 1449;
			this._idDic[1450] = typeof(CharSkinWearAck);
			this._typeDic[typeof(CharSkinWearAck)] = 1450;
			this._idDic[1451] = typeof(CharSkinWearReq);
			this._typeDic[typeof(CharSkinWearReq)] = 1451;
			this._idDic[1452] = typeof(ModelSkinTakeOffAck);
			this._typeDic[typeof(ModelSkinTakeOffAck)] = 1452;
			this._idDic[1453] = typeof(ModelSkinTakeOffReq);
			this._typeDic[typeof(ModelSkinTakeOffReq)] = 1453;
			this._idDic[1454] = typeof(ModelSkinWearAck);
			this._typeDic[typeof(ModelSkinWearAck)] = 1454;
			this._idDic[1455] = typeof(ModelSkinWearReq);
			this._typeDic[typeof(ModelSkinWearReq)] = 1455;
			this._idDic[1456] = typeof(SoldierSkinTakeOffAck);
			this._typeDic[typeof(SoldierSkinTakeOffAck)] = 1456;
			this._idDic[1457] = typeof(SoldierSkinTakeOffReq);
			this._typeDic[typeof(SoldierSkinTakeOffReq)] = 1457;
			this._idDic[1458] = typeof(SoldierSkinWearAck);
			this._typeDic[typeof(SoldierSkinWearAck)] = 1458;
			this._idDic[1459] = typeof(SoldierSkinWearReq);
			this._typeDic[typeof(SoldierSkinWearReq)] = 1459;
			this._idDic[1460] = typeof(BattleRoomHeroBanAck);
			this._typeDic[typeof(BattleRoomHeroBanAck)] = 1460;
			this._idDic[1461] = typeof(BattleRoomHeroBanReq);
			this._typeDic[typeof(BattleRoomHeroBanReq)] = 1461;
			this._idDic[1462] = typeof(BattleRoomHeroProtectAck);
			this._typeDic[typeof(BattleRoomHeroProtectAck)] = 1462;
			this._idDic[1463] = typeof(BattleRoomHeroProtectReq);
			this._typeDic[typeof(BattleRoomHeroProtectReq)] = 1463;
			this._idDic[1464] = typeof(DSGiftStoreNtf);
			this._typeDic[typeof(DSGiftStoreNtf)] = 1464;
			this._idDic[1465] = typeof(MonthCardUpdateNtf);
			this._typeDic[typeof(MonthCardUpdateNtf)] = 1465;
			this._idDic[1466] = typeof(BattleRoomDataChangeNtf);
			this._typeDic[typeof(BattleRoomDataChangeNtf)] = 1466;
			this._idDic[1467] = typeof(BattleRoomEndCurrentBPTurnAck);
			this._typeDic[typeof(BattleRoomEndCurrentBPTurnAck)] = 1467;
			this._idDic[1468] = typeof(BattleRoomEndCurrentBPTurnReq);
			this._typeDic[typeof(BattleRoomEndCurrentBPTurnReq)] = 1468;
			this._idDic[1469] = typeof(RMBUpdateNtf);
			this._typeDic[typeof(RMBUpdateNtf)] = 1469;
			this._idDic[1470] = typeof(GiftStoreOperationalGoodsUpdateNtf);
			this._typeDic[typeof(GiftStoreOperationalGoodsUpdateNtf)] = 1470;
			this._idDic[1471] = typeof(GiftStoreAppleSubscribeAck);
			this._typeDic[typeof(GiftStoreAppleSubscribeAck)] = 1471;
			this._idDic[1472] = typeof(GiftStoreAppleSubscribeReq);
			this._typeDic[typeof(GiftStoreAppleSubscribeReq)] = 1472;
			this._idDic[1473] = typeof(BattleRoomRealTimePVPBattleStartNtf);
			this._typeDic[typeof(BattleRoomRealTimePVPBattleStartNtf)] = 1473;
			this._idDic[1474] = typeof(AdvertisementFlowLayoutUpdateNtf);
			this._typeDic[typeof(AdvertisementFlowLayoutUpdateNtf)] = 1474;
			this._idDic[1475] = typeof(RealTimePVPAcquireWinsBonusAck);
			this._typeDic[typeof(RealTimePVPAcquireWinsBonusAck)] = 1475;
			this._idDic[1476] = typeof(RealTimePVPAcquireWinsBonusReq);
			this._typeDic[typeof(RealTimePVPAcquireWinsBonusReq)] = 1476;
			this._idDic[1477] = typeof(HeadPortraitAndHeadFrameSetAck);
			this._typeDic[typeof(HeadPortraitAndHeadFrameSetAck)] = 1477;
			this._idDic[1478] = typeof(HeadPortraitAndHeadFrameSetReq);
			this._typeDic[typeof(HeadPortraitAndHeadFrameSetReq)] = 1478;
			this._idDic[1479] = typeof(RealTimePVPLeaderboardInfoNtf);
			this._typeDic[typeof(RealTimePVPLeaderboardInfoNtf)] = 1479;
			this._idDic[1480] = typeof(RechargeStoreBuyGoodsAck);
			this._typeDic[typeof(RechargeStoreBuyGoodsAck)] = 1480;
			this._idDic[1481] = typeof(RechargeStoreBuyGoodsReq);
			this._typeDic[typeof(RechargeStoreBuyGoodsReq)] = 1481;
			this._idDic[1482] = typeof(DSBagExtraNtf);
			this._typeDic[typeof(DSBagExtraNtf)] = 1482;
			this._idDic[1483] = typeof(GiftStoreCancelBuyAck);
			this._typeDic[typeof(GiftStoreCancelBuyAck)] = 1483;
			this._idDic[1484] = typeof(GiftStoreCancelBuyReq);
			this._typeDic[typeof(GiftStoreCancelBuyReq)] = 1484;
			this._idDic[1486] = typeof(CheckOnlineAck);
			this._typeDic[typeof(CheckOnlineAck)] = 1486;
			this._idDic[1487] = typeof(CheckOnlineReq);
			this._typeDic[typeof(CheckOnlineReq)] = 1487;
			this._idDic[1488] = typeof(RechargeStoreCancelBuyAck);
			this._typeDic[typeof(RechargeStoreCancelBuyAck)] = 1488;
			this._idDic[1489] = typeof(RechargeStoreCancelBuyReq);
			this._typeDic[typeof(RechargeStoreCancelBuyReq)] = 1489;
			this._idDic[1490] = typeof(BattleRoomBattleLogReq);
			this._typeDic[typeof(BattleRoomBattleLogReq)] = 1490;
			this._idDic[1491] = typeof(PullOrderRewardAck);
			this._typeDic[typeof(PullOrderRewardAck)] = 1491;
			this._idDic[1492] = typeof(PullOrderRewardReq);
			this._typeDic[typeof(PullOrderRewardReq)] = 1492;
			this._idDic[1493] = typeof(ShareAck);
			this._typeDic[typeof(ShareAck)] = 1493;
			this._idDic[1494] = typeof(ShareReq);
			this._typeDic[typeof(ShareReq)] = 1494;
			this._idDic[1495] = typeof(DSRealTimePVPBattleReportNtf);
			this._typeDic[typeof(DSRealTimePVPBattleReportNtf)] = 1495;
			this._idDic[1496] = typeof(DSRealTimePVPPromotionBattleReportNtf);
			this._typeDic[typeof(DSRealTimePVPPromotionBattleReportNtf)] = 1496;
			this._idDic[1497] = typeof(DirectelyActivitedMissionUpdateNtf);
			this._typeDic[typeof(DirectelyActivitedMissionUpdateNtf)] = 1497;
			this._idDic[1500] = typeof(ExchangeHeroFragmentAck);
			this._typeDic[typeof(ExchangeHeroFragmentAck)] = 1500;
			this._idDic[1501] = typeof(ExchangeHeroFragmentReq);
			this._typeDic[typeof(ExchangeHeroFragmentReq)] = 1501;
			this._idDic[1502] = typeof(AutoTakeOffEquipmentsAck);
			this._typeDic[typeof(AutoTakeOffEquipmentsAck)] = 1502;
			this._idDic[1503] = typeof(AutoTakeOffEquipmentsReq);
			this._typeDic[typeof(AutoTakeOffEquipmentsReq)] = 1503;
			this._idDic[1504] = typeof(GuildCreateAck);
			this._typeDic[typeof(GuildCreateAck)] = 1504;
			this._idDic[1505] = typeof(GuildCreateReq);
			this._typeDic[typeof(GuildCreateReq)] = 1505;
			this._idDic[1508] = typeof(GuildJoinApplyAck);
			this._typeDic[typeof(GuildJoinApplyAck)] = 1508;
			this._idDic[1509] = typeof(GuildJoinApplyReq);
			this._typeDic[typeof(GuildJoinApplyReq)] = 1509;
			this._idDic[1512] = typeof(ChatGuildHistoryMessageNtf);
			this._typeDic[typeof(ChatGuildHistoryMessageNtf)] = 1512;
			this._idDic[1513] = typeof(GuildInvitePlayerListAck);
			this._typeDic[typeof(GuildInvitePlayerListAck)] = 1513;
			this._idDic[1514] = typeof(GuildInvitePlayerListReq);
			this._typeDic[typeof(GuildInvitePlayerListReq)] = 1514;
			this._idDic[1515] = typeof(GuildRandomListAck);
			this._typeDic[typeof(GuildRandomListAck)] = 1515;
			this._idDic[1516] = typeof(GuildRandomListReq);
			this._typeDic[typeof(GuildRandomListReq)] = 1516;
			this._idDic[1517] = typeof(GuildSearchAck);
			this._typeDic[typeof(GuildSearchAck)] = 1517;
			this._idDic[1518] = typeof(GuildSearchReq);
			this._typeDic[typeof(GuildSearchReq)] = 1518;
			this._idDic[1519] = typeof(GuildHiringDeclarationSetAck);
			this._typeDic[typeof(GuildHiringDeclarationSetAck)] = 1519;
			this._idDic[1520] = typeof(GuildHiringDeclarationSetReq);
			this._typeDic[typeof(GuildHiringDeclarationSetReq)] = 1520;
			this._idDic[1523] = typeof(GuildGetAck);
			this._typeDic[typeof(GuildGetAck)] = 1523;
			this._idDic[1524] = typeof(GuildGetReq);
			this._typeDic[typeof(GuildGetReq)] = 1524;
			this._idDic[1525] = typeof(GuildVicePresidentAppointAck);
			this._typeDic[typeof(GuildVicePresidentAppointAck)] = 1525;
			this._idDic[1526] = typeof(GuildVicePresidentAppointReq);
			this._typeDic[typeof(GuildVicePresidentAppointReq)] = 1526;
			this._idDic[1527] = typeof(GuildKickOutAck);
			this._typeDic[typeof(GuildKickOutAck)] = 1527;
			this._idDic[1528] = typeof(GuildKickOutReq);
			this._typeDic[typeof(GuildKickOutReq)] = 1528;
			this._idDic[1529] = typeof(GuildQuitAck);
			this._typeDic[typeof(GuildQuitAck)] = 1529;
			this._idDic[1530] = typeof(GuildQuitReq);
			this._typeDic[typeof(GuildQuitReq)] = 1530;
			this._idDic[1531] = typeof(GuildPresidentAppointAck);
			this._typeDic[typeof(GuildPresidentAppointAck)] = 1531;
			this._idDic[1532] = typeof(GuildPresidentAppointReq);
			this._typeDic[typeof(GuildPresidentAppointReq)] = 1532;
			this._idDic[1533] = typeof(GuildPresidentRelieveAck);
			this._typeDic[typeof(GuildPresidentRelieveAck)] = 1533;
			this._idDic[1534] = typeof(GuildPresidentRelieveReq);
			this._typeDic[typeof(GuildPresidentRelieveReq)] = 1534;
			this._idDic[1535] = typeof(DSGuildNtf);
			this._typeDic[typeof(DSGuildNtf)] = 1535;
			this._idDic[1536] = typeof(GuildAnnouncementSetAck);
			this._typeDic[typeof(GuildAnnouncementSetAck)] = 1536;
			this._idDic[1537] = typeof(GuildAnnouncementSetReq);
			this._typeDic[typeof(GuildAnnouncementSetReq)] = 1537;
			this._idDic[1538] = typeof(GuildJoinApplyConfirmAck);
			this._typeDic[typeof(GuildJoinApplyConfirmAck)] = 1538;
			this._idDic[1539] = typeof(GuildJoinApplyConfirmReq);
			this._typeDic[typeof(GuildJoinApplyConfirmReq)] = 1539;
			this._idDic[1540] = typeof(GuildJoinInvitationConfirmAck);
			this._typeDic[typeof(GuildJoinInvitationConfirmAck)] = 1540;
			this._idDic[1541] = typeof(GuildJoinInvitationConfirmReq);
			this._typeDic[typeof(GuildJoinInvitationConfirmReq)] = 1541;
			this._idDic[1542] = typeof(AllGuildJoinInvitationRefuseAck);
			this._typeDic[typeof(AllGuildJoinInvitationRefuseAck)] = 1542;
			this._idDic[1543] = typeof(AllGuildJoinInvitationRefuseReq);
			this._typeDic[typeof(AllGuildJoinInvitationRefuseReq)] = 1543;
			this._idDic[1544] = typeof(GuildJoinInvitationRefuseAck);
			this._typeDic[typeof(GuildJoinInvitationRefuseAck)] = 1544;
			this._idDic[1545] = typeof(GuildJoinInvitationRefuseReq);
			this._typeDic[typeof(GuildJoinInvitationRefuseReq)] = 1545;
			this._idDic[1548] = typeof(GuildJoinInvitationGetAck);
			this._typeDic[typeof(GuildJoinInvitationGetAck)] = 1548;
			this._idDic[1549] = typeof(GuildJoinInvitationGetReq);
			this._typeDic[typeof(GuildJoinInvitationGetReq)] = 1549;
			this._idDic[1550] = typeof(DSUnchartedScoreNtf);
			this._typeDic[typeof(DSUnchartedScoreNtf)] = 1550;
			this._idDic[1551] = typeof(UnchartedScoreChallengeLevelAttackAck);
			this._typeDic[typeof(UnchartedScoreChallengeLevelAttackAck)] = 1551;
			this._idDic[1552] = typeof(UnchartedScoreChallengeLevelAttackReq);
			this._typeDic[typeof(UnchartedScoreChallengeLevelAttackReq)] = 1552;
			this._idDic[1553] = typeof(UnchartedScoreChallengeLevelBattleFinishedAck);
			this._typeDic[typeof(UnchartedScoreChallengeLevelBattleFinishedAck)] = 1553;
			this._idDic[1554] = typeof(UnchartedScoreChallengeLevelBattleFinishedReq);
			this._typeDic[typeof(UnchartedScoreChallengeLevelBattleFinishedReq)] = 1554;
			this._idDic[1555] = typeof(UnchartedScoreRewardGainAck);
			this._typeDic[typeof(UnchartedScoreRewardGainAck)] = 1555;
			this._idDic[1556] = typeof(UnchartedScoreRewardGainReq);
			this._typeDic[typeof(UnchartedScoreRewardGainReq)] = 1556;
			this._idDic[1557] = typeof(UnchartedScoreScoreLevelAttackAck);
			this._typeDic[typeof(UnchartedScoreScoreLevelAttackAck)] = 1557;
			this._idDic[1558] = typeof(UnchartedScoreScoreLevelAttackReq);
			this._typeDic[typeof(UnchartedScoreScoreLevelAttackReq)] = 1558;
			this._idDic[1559] = typeof(UnchartedScoreScoreLevelBattleFinishedAck);
			this._typeDic[typeof(UnchartedScoreScoreLevelBattleFinishedAck)] = 1559;
			this._idDic[1560] = typeof(UnchartedScoreScoreLevelBattleFinishedReq);
			this._typeDic[typeof(UnchartedScoreScoreLevelBattleFinishedReq)] = 1560;
			this._idDic[1561] = typeof(AllGuildJoinApplyRefuseAck);
			this._typeDic[typeof(AllGuildJoinApplyRefuseAck)] = 1561;
			this._idDic[1562] = typeof(AllGuildJoinApplyRefuseReq);
			this._typeDic[typeof(AllGuildJoinApplyRefuseReq)] = 1562;
			this._idDic[1563] = typeof(GuildJoinApplyGetAck);
			this._typeDic[typeof(GuildJoinApplyGetAck)] = 1563;
			this._idDic[1564] = typeof(GuildJoinApplyGetReq);
			this._typeDic[typeof(GuildJoinApplyGetReq)] = 1564;
			this._idDic[1565] = typeof(GuildJoinApplyRefuseAck);
			this._typeDic[typeof(GuildJoinApplyRefuseAck)] = 1565;
			this._idDic[1566] = typeof(GuildJoinApplyRefuseReq);
			this._typeDic[typeof(GuildJoinApplyRefuseReq)] = 1566;
			this._idDic[1567] = typeof(GuildNameChangeAck);
			this._typeDic[typeof(GuildNameChangeAck)] = 1567;
			this._idDic[1568] = typeof(GuildNameChangeReq);
			this._typeDic[typeof(GuildNameChangeReq)] = 1568;
			this._idDic[1569] = typeof(GuildLogGetAck);
			this._typeDic[typeof(GuildLogGetAck)] = 1569;
			this._idDic[1570] = typeof(GuildLogGetReq);
			this._typeDic[typeof(GuildLogGetReq)] = 1570;
			this._idDic[1571] = typeof(GuildJoinInviteAck);
			this._typeDic[typeof(GuildJoinInviteAck)] = 1571;
			this._idDic[1572] = typeof(GuildJoinInviteReq);
			this._typeDic[typeof(GuildJoinInviteReq)] = 1572;
			this._idDic[1575] = typeof(ClimbTowerGetAck);
			this._typeDic[typeof(ClimbTowerGetAck)] = 1575;
			this._idDic[1576] = typeof(ClimbTowerGetReq);
			this._typeDic[typeof(ClimbTowerGetReq)] = 1576;
			this._idDic[1577] = typeof(ClimbTowerLevelAttackAck);
			this._typeDic[typeof(ClimbTowerLevelAttackAck)] = 1577;
			this._idDic[1578] = typeof(ClimbTowerLevelAttackReq);
			this._typeDic[typeof(ClimbTowerLevelAttackReq)] = 1578;
			this._idDic[1579] = typeof(ClimbTowerLevelBattleFinishedAck);
			this._typeDic[typeof(ClimbTowerLevelBattleFinishedAck)] = 1579;
			this._idDic[1580] = typeof(ClimbTowerLevelBattleFinishedReq);
			this._typeDic[typeof(ClimbTowerLevelBattleFinishedReq)] = 1580;
			this._idDic[1581] = typeof(ClimbTowerRaidAck);
			this._typeDic[typeof(ClimbTowerRaidAck)] = 1581;
			this._idDic[1582] = typeof(ClimbTowerRaidReq);
			this._typeDic[typeof(ClimbTowerRaidReq)] = 1582;
			this._idDic[1583] = typeof(DSClimbTowerNtf);
			this._typeDic[typeof(DSClimbTowerNtf)] = 1583;
			this._idDic[1584] = typeof(RedeemClaimAck);
			this._typeDic[typeof(RedeemClaimAck)] = 1584;
			this._idDic[1585] = typeof(RedeemClaimReq);
			this._typeDic[typeof(RedeemClaimReq)] = 1585;
			this._idDic[1586] = typeof(RedeemInfoAck);
			this._typeDic[typeof(RedeemInfoAck)] = 1586;
			this._idDic[1587] = typeof(RedeemInfoReq);
			this._typeDic[typeof(RedeemInfoReq)] = 1587;
			this._idDic[1588] = typeof(TeamRoomPlayerPositionChangeAck);
			this._typeDic[typeof(TeamRoomPlayerPositionChangeAck)] = 1588;
			this._idDic[1589] = typeof(TeamRoomPlayerPositionChangeReq);
			this._typeDic[typeof(TeamRoomPlayerPositionChangeReq)] = 1589;
			this._idDic[1590] = typeof(TeamRoomPlayerPositionChangeNtf);
			this._typeDic[typeof(TeamRoomPlayerPositionChangeNtf)] = 1590;
			this._idDic[1592] = typeof(GuildUpdateAnnouncementNtf);
			this._typeDic[typeof(GuildUpdateAnnouncementNtf)] = 1592;
			this._idDic[1593] = typeof(GuildJoinApplyAdminNtf);
			this._typeDic[typeof(GuildJoinApplyAdminNtf)] = 1593;
			this._idDic[1594] = typeof(GuildJoinInvitationNtf);
			this._typeDic[typeof(GuildJoinInvitationNtf)] = 1594;
			this._idDic[1595] = typeof(DailyFlushNtf);
			this._typeDic[typeof(DailyFlushNtf)] = 1595;
			this._idDic[1597] = typeof(UpdateServerTimeNtf);
			this._typeDic[typeof(UpdateServerTimeNtf)] = 1597;
			this._idDic[1598] = typeof(FansRewardsFromPBTCBTClaimAck);
			this._typeDic[typeof(FansRewardsFromPBTCBTClaimAck)] = 1598;
			this._idDic[1599] = typeof(FansRewardsFromPBTCBTClaimReq);
			this._typeDic[typeof(FansRewardsFromPBTCBTClaimReq)] = 1599;
			this._idDic[1600] = typeof(FansRewardsFromPBTCBTInfoAck);
			this._typeDic[typeof(FansRewardsFromPBTCBTInfoAck)] = 1600;
			this._idDic[1601] = typeof(FansRewardsFromPBTCBTInfoReq);
			this._typeDic[typeof(FansRewardsFromPBTCBTInfoReq)] = 1601;
			this._idDic[1602] = typeof(GuildBasicSetAck);
			this._typeDic[typeof(GuildBasicSetAck)] = 1602;
			this._idDic[1603] = typeof(GuildBasicSetReq);
			this._typeDic[typeof(GuildBasicSetReq)] = 1603;
			this._idDic[1604] = typeof(GuildMassiveCombatAttackAck);
			this._typeDic[typeof(GuildMassiveCombatAttackAck)] = 1604;
			this._idDic[1605] = typeof(GuildMassiveCombatAttackReq);
			this._typeDic[typeof(GuildMassiveCombatAttackReq)] = 1605;
			this._idDic[1606] = typeof(GuildMassiveCombatDataAck);
			this._typeDic[typeof(GuildMassiveCombatDataAck)] = 1606;
			this._idDic[1607] = typeof(GuildMassiveCombatDataReq);
			this._typeDic[typeof(GuildMassiveCombatDataReq)] = 1607;
			this._idDic[1608] = typeof(GuildMassiveCombatNtf);
			this._typeDic[typeof(GuildMassiveCombatNtf)] = 1608;
			this._idDic[1611] = typeof(GuildMassiveCombatStartAck);
			this._typeDic[typeof(GuildMassiveCombatStartAck)] = 1611;
			this._idDic[1612] = typeof(GuildMassiveCombatStartReq);
			this._typeDic[typeof(GuildMassiveCombatStartReq)] = 1612;
			this._idDic[1613] = typeof(GuildMassiveCombatSurrenderAck);
			this._typeDic[typeof(GuildMassiveCombatSurrenderAck)] = 1613;
			this._idDic[1614] = typeof(GuildMassiveCombatSurrenderReq);
			this._typeDic[typeof(GuildMassiveCombatSurrenderReq)] = 1614;
			this._idDic[1615] = typeof(OpenMemoryStoreAck);
			this._typeDic[typeof(OpenMemoryStoreAck)] = 1615;
			this._idDic[1616] = typeof(OpenMemoryStoreReq);
			this._typeDic[typeof(OpenMemoryStoreReq)] = 1616;
			this._idDic[1617] = typeof(BattleRoomGuildMassiveCombatBattleJoinNtf);
			this._typeDic[typeof(BattleRoomGuildMassiveCombatBattleJoinNtf)] = 1617;
			this._idDic[1618] = typeof(BattleGuildMassiveCombatBattleFinishNtf);
			this._typeDic[typeof(BattleGuildMassiveCombatBattleFinishNtf)] = 1618;
			this._idDic[1620] = typeof(GuildMassiveCombatPlayerNtf);
			this._typeDic[typeof(GuildMassiveCombatPlayerNtf)] = 1620;
			this._idDic[1621] = typeof(GuildMassiveCombatAttackFinishedAck);
			this._typeDic[typeof(GuildMassiveCombatAttackFinishedAck)] = 1621;
			this._idDic[1622] = typeof(GuildMassiveCombatAttackFinishedReq);
			this._typeDic[typeof(GuildMassiveCombatAttackFinishedReq)] = 1622;
			this._idDic[1623] = typeof(BattleRoomHeroPutdownAck);
			this._typeDic[typeof(BattleRoomHeroPutdownAck)] = 1623;
			this._idDic[1624] = typeof(BattleRoomHeroPutdownReq);
			this._typeDic[typeof(BattleRoomHeroPutdownReq)] = 1624;
			this._idDic[1625] = typeof(TeamRoomInviteeInfoGetAck);
			this._typeDic[typeof(TeamRoomInviteeInfoGetAck)] = 1625;
			this._idDic[1626] = typeof(TeamRoomInviteeInfoGetReq);
			this._typeDic[typeof(TeamRoomInviteeInfoGetReq)] = 1626;
			this._idDic[1628] = typeof(ProGuildMassiveCombatAttackResultNtf);
			this._typeDic[typeof(ProGuildMassiveCombatAttackResultNtf)] = 1628;
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x001D541C File Offset: 0x001D361C
		public Type GetTypeById(int vId)
		{
			Type result;
			if (this._idDic.TryGetValue(vId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x001D5440 File Offset: 0x001D3640
		public int GetIdByType(Type vType)
		{
			int result;
			if (this._typeDic.TryGetValue(vType, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x060067DA RID: 26586 RVA: 0x001D5464 File Offset: 0x001D3664
		public Dictionary<Type, int> GetTypeIDMap()
		{
			return this._typeDic;
		}

		// Token: 0x04004DCA RID: 19914
		public const int MsgId_CCMSGConnectionReady = 9001;

		// Token: 0x04004DCB RID: 19915
		public const int MsgId_CCMSGConnectionBreak = 9002;

		// Token: 0x04004DCC RID: 19916
		public const int MsgId_CCMSGConnectionFailure = 9003;

		// Token: 0x04004DCD RID: 19917
		public const int MsgId_CCMSGConnectionSendFailure = 9004;

		// Token: 0x04004DCE RID: 19918
		public const int MsgId_CCMSGConnectionRecvFailure = 9005;

		// Token: 0x04004DCF RID: 19919
		public const int MsgId_LoginByAuthTokenAck = 1;

		// Token: 0x04004DD0 RID: 19920
		public const int MsgId_LoginByAuthTokenReq = 2;

		// Token: 0x04004DD1 RID: 19921
		public const int MsgId_LoginBySessionTokenAck = 3;

		// Token: 0x04004DD2 RID: 19922
		public const int MsgId_LoginBySessionTokenReq = 4;

		// Token: 0x04004DD3 RID: 19923
		public const int MsgId_ServerDisconnectNtf = 5;

		// Token: 0x04004DD4 RID: 19924
		public const int MsgId_ServerHeartBeatNtf = 6;

		// Token: 0x04004DD5 RID: 19925
		public const int MsgId_AnikiGymLevelAttackAck = 1002;

		// Token: 0x04004DD6 RID: 19926
		public const int MsgId_AnikiGymLevelAttackReq = 1003;

		// Token: 0x04004DD7 RID: 19927
		public const int MsgId_AnikiGymLevelBattleFinishedAck = 1004;

		// Token: 0x04004DD8 RID: 19928
		public const int MsgId_AnikiGymLevelBattleFinishedReq = 1005;

		// Token: 0x04004DD9 RID: 19929
		public const int MsgId_ArenaBattleFinishedAck = 1006;

		// Token: 0x04004DDA RID: 19930
		public const int MsgId_ArenaBattleFinishedReq = 1007;

		// Token: 0x04004DDB RID: 19931
		public const int MsgId_ArenaBattleReconnectAck = 1008;

		// Token: 0x04004DDC RID: 19932
		public const int MsgId_ArenaBattleReconnectReq = 1009;

		// Token: 0x04004DDD RID: 19933
		public const int MsgId_ArenaBattleReportBasicDataGetAck = 1010;

		// Token: 0x04004DDE RID: 19934
		public const int MsgId_ArenaBattleReportBasicDataGetReq = 1011;

		// Token: 0x04004DDF RID: 19935
		public const int MsgId_ArenaBattleReportNtf = 1012;

		// Token: 0x04004DE0 RID: 19936
		public const int MsgId_ArenaBattleReportPlayBackDataGetAck = 1013;

		// Token: 0x04004DE1 RID: 19937
		public const int MsgId_ArenaBattleReportPlayBackDataGetReq = 1014;

		// Token: 0x04004DE2 RID: 19938
		public const int MsgId_ArenaOpponentAttackAck = 1015;

		// Token: 0x04004DE3 RID: 19939
		public const int MsgId_ArenaOpponentAttackFightingAck = 1016;

		// Token: 0x04004DE4 RID: 19940
		public const int MsgId_ArenaOpponentAttackFightingReq = 1017;

		// Token: 0x04004DE5 RID: 19941
		public const int MsgId_ArenaOpponentAttackReq = 1018;

		// Token: 0x04004DE6 RID: 19942
		public const int MsgId_ArenaOpponentRevengeAck = 1019;

		// Token: 0x04004DE7 RID: 19943
		public const int MsgId_ArenaOpponentRevengeReq = 1020;

		// Token: 0x04004DE8 RID: 19944
		public const int MsgId_ArenaOpponentViewAck = 1023;

		// Token: 0x04004DE9 RID: 19945
		public const int MsgId_ArenaOpponentViewReq = 1024;

		// Token: 0x04004DEA RID: 19946
		public const int MsgId_ArenaPlayerInfoGetAck = 1025;

		// Token: 0x04004DEB RID: 19947
		public const int MsgId_ArenaPlayerInfoGetReq = 1026;

		// Token: 0x04004DEC RID: 19948
		public const int MsgId_ArenaPlayerSetDefensiveTeamAck = 1027;

		// Token: 0x04004DED RID: 19949
		public const int MsgId_ArenaPlayerSetDefensiveTeamReq = 1028;

		// Token: 0x04004DEE RID: 19950
		public const int MsgId_ArenaRevengeOpponentGetAck = 1029;

		// Token: 0x04004DEF RID: 19951
		public const int MsgId_ArenaRevengeOpponentGetReq = 1030;

		// Token: 0x04004DF0 RID: 19952
		public const int MsgId_ArenaTicketsBuyAck = 1031;

		// Token: 0x04004DF1 RID: 19953
		public const int MsgId_ArenaTicketsBuyReq = 1032;

		// Token: 0x04004DF2 RID: 19954
		public const int MsgId_ArenaTopRankPlayersGetAck = 1033;

		// Token: 0x04004DF3 RID: 19955
		public const int MsgId_ArenaTopRankPlayersGetReq = 1034;

		// Token: 0x04004DF4 RID: 19956
		public const int MsgId_ArenaVictoryPointsRewardGainAck = 1035;

		// Token: 0x04004DF5 RID: 19957
		public const int MsgId_ArenaVictoryPointsRewardGainReq = 1036;

		// Token: 0x04004DF6 RID: 19958
		public const int MsgId_BattleArmyRandomSeedGetAck = 1037;

		// Token: 0x04004DF7 RID: 19959
		public const int MsgId_BattleArmyRandomSeedGetReq = 1038;

		// Token: 0x04004DF8 RID: 19960
		public const int MsgId_BattleCancelAck = 1039;

		// Token: 0x04004DF9 RID: 19961
		public const int MsgId_BattleCancelReq = 1040;

		// Token: 0x04004DFA RID: 19962
		public const int MsgId_BattleTeamSetAck = 1041;

		// Token: 0x04004DFB RID: 19963
		public const int MsgId_BattleTeamSetReq = 1042;

		// Token: 0x04004DFC RID: 19964
		public const int MsgId_BuyEnergyAck = 1043;

		// Token: 0x04004DFD RID: 19965
		public const int MsgId_BuyEnergyReq = 1044;

		// Token: 0x04004DFE RID: 19966
		public const int MsgId_ChatBannedNtf = 1045;

		// Token: 0x04004DFF RID: 19967
		public const int MsgId_ChatMessageNtf = 1046;

		// Token: 0x04004E00 RID: 19968
		public const int MsgId_ChatMessageSendAck = 1047;

		// Token: 0x04004E01 RID: 19969
		public const int MsgId_ChatMessageSendReq = 1048;

		// Token: 0x04004E02 RID: 19970
		public const int MsgId_ChatVoiceContentAck = 1049;

		// Token: 0x04004E03 RID: 19971
		public const int MsgId_ChatVoiceContentReq = 1050;

		// Token: 0x04004E04 RID: 19972
		public const int MsgId_ChatWorldChannelRoomEnterAck = 1051;

		// Token: 0x04004E05 RID: 19973
		public const int MsgId_ChatWorldChannelRoomEnterReq = 1052;

		// Token: 0x04004E06 RID: 19974
		public const int MsgId_CommenterHeroViewAck = 1053;

		// Token: 0x04004E07 RID: 19975
		public const int MsgId_CommenterHeroViewReq = 1054;

		// Token: 0x04004E08 RID: 19976
		public const int MsgId_CreateCharactorAck = 1055;

		// Token: 0x04004E09 RID: 19977
		public const int MsgId_CreateCharactorReq = 1056;

		// Token: 0x04004E0A RID: 19978
		public const int MsgId_DSAnikiGymNtf = 1057;

		// Token: 0x04004E0B RID: 19979
		public const int MsgId_DSAnnouncementNtf = 1058;

		// Token: 0x04004E0C RID: 19980
		public const int MsgId_DSArenaNtf = 1059;

		// Token: 0x04004E0D RID: 19981
		public const int MsgId_DSBagNtf = 1060;

		// Token: 0x04004E0E RID: 19982
		public const int MsgId_DSBattleNtf = 1061;

		// Token: 0x04004E0F RID: 19983
		public const int MsgId_DSChatNtf = 1062;

		// Token: 0x04004E10 RID: 19984
		public const int MsgId_DSFixedStoreNtf = 1063;

		// Token: 0x04004E11 RID: 19985
		public const int MsgId_DSHeroDungeonNtf = 1064;

		// Token: 0x04004E12 RID: 19986
		public const int MsgId_DSHeroNtf = 1065;

		// Token: 0x04004E13 RID: 19987
		public const int MsgId_DSHeroTrainningNtf = 1066;

		// Token: 0x04004E14 RID: 19988
		public const int MsgId_DSLevelNtf = 1067;

		// Token: 0x04004E15 RID: 19989
		public const int MsgId_DSMailNtf = 1068;

		// Token: 0x04004E16 RID: 19990
		public const int MsgId_DSMemoryCorridorNtf = 1069;

		// Token: 0x04004E17 RID: 19991
		public const int MsgId_DSMissionNtf = 1070;

		// Token: 0x04004E18 RID: 19992
		public const int MsgId_DSOperationalActivityNtf = 1071;

		// Token: 0x04004E19 RID: 19993
		public const int MsgId_DSPlayerBasicNtf = 1072;

		// Token: 0x04004E1A RID: 19994
		public const int MsgId_DSRandomStoreNtf = 1073;

		// Token: 0x04004E1B RID: 19995
		public const int MsgId_DSRiftNtf = 1074;

		// Token: 0x04004E1C RID: 19996
		public const int MsgId_DSSelectCardNtf = 1075;

		// Token: 0x04004E1D RID: 19997
		public const int MsgId_DSSurveyNtf = 1076;

		// Token: 0x04004E1E RID: 19998
		public const int MsgId_DSTeamNtf = 1077;

		// Token: 0x04004E1F RID: 19999
		public const int MsgId_DSThearchyTrialNtf = 1078;

		// Token: 0x04004E20 RID: 20000
		public const int MsgId_DSTreasureMapNtf = 1079;

		// Token: 0x04004E21 RID: 20001
		public const int MsgId_EquipmentAutoAck = 1080;

		// Token: 0x04004E22 RID: 20002
		public const int MsgId_EquipmentAutoReq = 1081;

		// Token: 0x04004E23 RID: 20003
		public const int MsgId_EquipmentEnhanceAck = 1082;

		// Token: 0x04004E24 RID: 20004
		public const int MsgId_EquipmentEnhanceReq = 1083;

		// Token: 0x04004E25 RID: 20005
		public const int MsgId_EquipmentLockAndUnLockAck = 1084;

		// Token: 0x04004E26 RID: 20006
		public const int MsgId_EquipmentLockAndUnLockReq = 1085;

		// Token: 0x04004E27 RID: 20007
		public const int MsgId_EquipmentStarLevelUpAck = 1086;

		// Token: 0x04004E28 RID: 20008
		public const int MsgId_EquipmentStarLevelUpReq = 1087;

		// Token: 0x04004E29 RID: 20009
		public const int MsgId_EquipmentTakeOffAck = 1088;

		// Token: 0x04004E2A RID: 20010
		public const int MsgId_EquipmentTakeOffReq = 1089;

		// Token: 0x04004E2B RID: 20011
		public const int MsgId_EquipmentWearAck = 1090;

		// Token: 0x04004E2C RID: 20012
		public const int MsgId_EquipmentWearReq = 1091;

		// Token: 0x04004E2D RID: 20013
		public const int MsgId_EverydaySignAck = 1092;

		// Token: 0x04004E2E RID: 20014
		public const int MsgId_EverydaySignReq = 1093;

		// Token: 0x04004E2F RID: 20015
		public const int MsgId_ExchangeGiftCDKeyAck = 1094;

		// Token: 0x04004E30 RID: 20016
		public const int MsgId_ExchangeGiftCDKeyReq = 1095;

		// Token: 0x04004E31 RID: 20017
		public const int MsgId_FixedStoreBuyStoreItemAck = 1096;

		// Token: 0x04004E32 RID: 20018
		public const int MsgId_FixedStoreBuyStoreItemReq = 1097;

		// Token: 0x04004E33 RID: 20019
		public const int MsgId_FlushConfigNtf = 1100;

		// Token: 0x04004E34 RID: 20020
		public const int MsgId_FriendBlockAck = 1101;

		// Token: 0x04004E35 RID: 20021
		public const int MsgId_FriendBlockReq = 1102;

		// Token: 0x04004E36 RID: 20022
		public const int MsgId_FriendDeleteAck = 1103;

		// Token: 0x04004E37 RID: 20023
		public const int MsgId_FriendDeleteReq = 1104;

		// Token: 0x04004E38 RID: 20024
		public const int MsgId_FriendFindAck = 1105;

		// Token: 0x04004E39 RID: 20025
		public const int MsgId_FriendFindReq = 1106;

		// Token: 0x04004E3A RID: 20026
		public const int MsgId_FriendGetSocialRelationReq = 1108;

		// Token: 0x04004E3B RID: 20027
		public const int MsgId_FriendInviteAcceptAck = 1109;

		// Token: 0x04004E3C RID: 20028
		public const int MsgId_FriendInviteAcceptNtf = 1110;

		// Token: 0x04004E3D RID: 20029
		public const int MsgId_FriendInviteAcceptReq = 1111;

		// Token: 0x04004E3E RID: 20030
		public const int MsgId_FriendInviteAck = 1112;

		// Token: 0x04004E3F RID: 20031
		public const int MsgId_FriendInviteDeclineAck = 1113;

		// Token: 0x04004E40 RID: 20032
		public const int MsgId_FriendInviteDeclineNtf = 1114;

		// Token: 0x04004E41 RID: 20033
		public const int MsgId_FriendInviteDeclineReq = 1115;

		// Token: 0x04004E42 RID: 20034
		public const int MsgId_FriendInviteNtf = 1116;

		// Token: 0x04004E43 RID: 20035
		public const int MsgId_FriendInviteReq = 1117;

		// Token: 0x04004E44 RID: 20036
		public const int MsgId_FriendSuggestedAck = 1118;

		// Token: 0x04004E45 RID: 20037
		public const int MsgId_FriendSuggestedReq = 1119;

		// Token: 0x04004E46 RID: 20038
		public const int MsgId_FriendSummaryUpdateNtf = 1120;

		// Token: 0x04004E47 RID: 20039
		public const int MsgId_FriendUnblockAck = 1121;

		// Token: 0x04004E48 RID: 20040
		public const int MsgId_FriendUnblockReq = 1122;

		// Token: 0x04004E49 RID: 20041
		public const int MsgId_GetMissionRewardAck = 1123;

		// Token: 0x04004E4A RID: 20042
		public const int MsgId_GetMissionRewardReq = 1124;

		// Token: 0x04004E4B RID: 20043
		public const int MsgId_GetSurveyRewardAck = 1125;

		// Token: 0x04004E4C RID: 20044
		public const int MsgId_GetSurveyRewardReq = 1126;

		// Token: 0x04004E4D RID: 20045
		public const int MsgId_GmCommandAck = 1127;

		// Token: 0x04004E4E RID: 20046
		public const int MsgId_GmCommandReq = 1128;

		// Token: 0x04004E4F RID: 20047
		public const int MsgId_HeroCommentAck = 1131;

		// Token: 0x04004E50 RID: 20048
		public const int MsgId_HeroCommentEntryPraiseAck = 1132;

		// Token: 0x04004E51 RID: 20049
		public const int MsgId_HeroCommentEntryPraiseReq = 1133;

		// Token: 0x04004E52 RID: 20050
		public const int MsgId_HeroCommentGetAck = 1134;

		// Token: 0x04004E53 RID: 20051
		public const int MsgId_HeroCommentGetReq = 1135;

		// Token: 0x04004E54 RID: 20052
		public const int MsgId_HeroCommentReq = 1136;

		// Token: 0x04004E55 RID: 20053
		public const int MsgId_HeroComposeAck = 1137;

		// Token: 0x04004E56 RID: 20054
		public const int MsgId_HeroComposeReq = 1138;

		// Token: 0x04004E57 RID: 20055
		public const int MsgId_HeroConfessAck = 1139;

		// Token: 0x04004E58 RID: 20056
		public const int MsgId_HeroConfessReq = 1140;

		// Token: 0x04004E59 RID: 20057
		public const int MsgId_HeroDungeonChapterStarRewardGainAck = 1141;

		// Token: 0x04004E5A RID: 20058
		public const int MsgId_HeroDungeonChapterStarRewardGainReq = 1142;

		// Token: 0x04004E5B RID: 20059
		public const int MsgId_HeroDungeonLevelAttackAck = 1143;

		// Token: 0x04004E5C RID: 20060
		public const int MsgId_HeroDungeonLevelAttackReq = 1144;

		// Token: 0x04004E5D RID: 20061
		public const int MsgId_HeroDungeonLevelBattleFinishedAck = 1145;

		// Token: 0x04004E5E RID: 20062
		public const int MsgId_HeroDungeonLevelBattleFinishedReq = 1146;

		// Token: 0x04004E5F RID: 20063
		public const int MsgId_HeroDungeonLevelRaidAck = 1147;

		// Token: 0x04004E60 RID: 20064
		public const int MsgId_HeroDungeonLevelRaidReq = 1148;

		// Token: 0x04004E61 RID: 20065
		public const int MsgId_HeroExpAddAck = 1149;

		// Token: 0x04004E62 RID: 20066
		public const int MsgId_HeroExpAddReq = 1150;

		// Token: 0x04004E63 RID: 20067
		public const int MsgId_HeroFavorabilityExpAddAck = 1151;

		// Token: 0x04004E64 RID: 20068
		public const int MsgId_HeroFavorabilityExpAddReq = 1152;

		// Token: 0x04004E65 RID: 20069
		public const int MsgId_HeroFetterLevelUpAck = 1153;

		// Token: 0x04004E66 RID: 20070
		public const int MsgId_HeroFetterLevelUpReq = 1154;

		// Token: 0x04004E67 RID: 20071
		public const int MsgId_HeroFetterUnlockAck = 1155;

		// Token: 0x04004E68 RID: 20072
		public const int MsgId_HeroFetterUnlockReq = 1156;

		// Token: 0x04004E69 RID: 20073
		public const int MsgId_HeroInteractAck = 1157;

		// Token: 0x04004E6A RID: 20074
		public const int MsgId_HeroInteractReq = 1158;

		// Token: 0x04004E6B RID: 20075
		public const int MsgId_HeroJobLevelUpAck = 1159;

		// Token: 0x04004E6C RID: 20076
		public const int MsgId_HeroJobLevelUpReq = 1160;

		// Token: 0x04004E6D RID: 20077
		public const int MsgId_HeroJobTransferAck = 1161;

		// Token: 0x04004E6E RID: 20078
		public const int MsgId_HeroJobTransferReq = 1162;

		// Token: 0x04004E6F RID: 20079
		public const int MsgId_HeroJobUnlockAck = 1163;

		// Token: 0x04004E70 RID: 20080
		public const int MsgId_HeroJobUnlockReq = 1164;

		// Token: 0x04004E71 RID: 20081
		public const int MsgId_HeroSkillsSelectAck = 1165;

		// Token: 0x04004E72 RID: 20082
		public const int MsgId_HeroSkillsSelectReq = 1166;

		// Token: 0x04004E73 RID: 20083
		public const int MsgId_HeroSoldierSelectAck = 1167;

		// Token: 0x04004E74 RID: 20084
		public const int MsgId_HeroSoldierSelectReq = 1168;

		// Token: 0x04004E75 RID: 20085
		public const int MsgId_HeroStarLevelLevelUpAck = 1169;

		// Token: 0x04004E76 RID: 20086
		public const int MsgId_HeroStarLevelLevelUpReq = 1170;

		// Token: 0x04004E77 RID: 20087
		public const int MsgId_HeroTrainningLevelAttackAck = 1171;

		// Token: 0x04004E78 RID: 20088
		public const int MsgId_HeroTrainningLevelAttackReq = 1172;

		// Token: 0x04004E79 RID: 20089
		public const int MsgId_HeroTrainningLevelBattleFinishedAck = 1173;

		// Token: 0x04004E7A RID: 20090
		public const int MsgId_HeroTrainningLevelBattleFinishedReq = 1174;

		// Token: 0x04004E7B RID: 20091
		public const int MsgId_LevelDanmakuGetAck = 1175;

		// Token: 0x04004E7C RID: 20092
		public const int MsgId_LevelDanmakuGetReq = 1176;

		// Token: 0x04004E7D RID: 20093
		public const int MsgId_LevelDanmakuPostAck = 1177;

		// Token: 0x04004E7E RID: 20094
		public const int MsgId_LevelDanmakuPostReq = 1178;

		// Token: 0x04004E7F RID: 20095
		public const int MsgId_LevelScenarioHandleAck = 1179;

		// Token: 0x04004E80 RID: 20096
		public const int MsgId_LevelScenarioHandleReq = 1180;

		// Token: 0x04004E81 RID: 20097
		public const int MsgId_LevelWayPointBattleFinishAck = 1181;

		// Token: 0x04004E82 RID: 20098
		public const int MsgId_LevelWayPointBattleFinishReq = 1182;

		// Token: 0x04004E83 RID: 20099
		public const int MsgId_LevelWayPointMoveAck = 1183;

		// Token: 0x04004E84 RID: 20100
		public const int MsgId_LevelWayPointMoveReq = 1184;

		// Token: 0x04004E85 RID: 20101
		public const int MsgId_MailAttachmentsGetAck = 1185;

		// Token: 0x04004E86 RID: 20102
		public const int MsgId_MailAttachmentsGetReq = 1186;

		// Token: 0x04004E87 RID: 20103
		public const int MsgId_MailReadAck = 1187;

		// Token: 0x04004E88 RID: 20104
		public const int MsgId_MailReadReq = 1188;

		// Token: 0x04004E89 RID: 20105
		public const int MsgId_MailsChangedNtf = 1189;

		// Token: 0x04004E8A RID: 20106
		public const int MsgId_MailsGetAck = 1190;

		// Token: 0x04004E8B RID: 20107
		public const int MsgId_MailsGetReq = 1191;

		// Token: 0x04004E8C RID: 20108
		public const int MsgId_MemoryCorridorLevelAttackAck = 1192;

		// Token: 0x04004E8D RID: 20109
		public const int MsgId_MemoryCorridorLevelAttackReq = 1193;

		// Token: 0x04004E8E RID: 20110
		public const int MsgId_MemoryCorridorLevelBattleFinishedAck = 1194;

		// Token: 0x04004E8F RID: 20111
		public const int MsgId_MemoryCorridorLevelBattleFinishedReq = 1195;

		// Token: 0x04004E90 RID: 20112
		public const int MsgId_NewAnnouncementNtf = 1196;

		// Token: 0x04004E91 RID: 20113
		public const int MsgId_NewMarqueeNtf = 1197;

		// Token: 0x04004E92 RID: 20114
		public const int MsgId_NewOperationalActivityNtf = 1198;

		// Token: 0x04004E93 RID: 20115
		public const int MsgId_NewSurveyNtf = 1199;

		// Token: 0x04004E94 RID: 20116
		public const int MsgId_OpenSurveyAck = 1200;

		// Token: 0x04004E95 RID: 20117
		public const int MsgId_OpenSurveyReq = 1201;

		// Token: 0x04004E96 RID: 20118
		public const int MsgId_OperationalActivityExchangeItemGroupAck = 1202;

		// Token: 0x04004E97 RID: 20119
		public const int MsgId_OperationalActivityExchangeItemGroupReq = 1203;

		// Token: 0x04004E98 RID: 20120
		public const int MsgId_OperationalActivityGainRewardAck = 1204;

		// Token: 0x04004E99 RID: 20121
		public const int MsgId_OperationalActivityGainRewardReq = 1205;

		// Token: 0x04004E9A RID: 20122
		public const int MsgId_PlayerInfoInitAck = 1206;

		// Token: 0x04004E9B RID: 20123
		public const int MsgId_PlayerInfoInitEndNtf = 1207;

		// Token: 0x04004E9C RID: 20124
		public const int MsgId_PlayerInfoInitReq = 1208;

		// Token: 0x04004E9D RID: 20125
		public const int MsgId_PlayerNameChangeAck = 1209;

		// Token: 0x04004E9E RID: 20126
		public const int MsgId_PlayerNameChangeReq = 1210;

		// Token: 0x04004E9F RID: 20127
		public const int MsgId_ProChangedGoodsNtf = 1211;

		// Token: 0x04004EA0 RID: 20128
		public const int MsgId_RandomEventNtf = 1212;

		// Token: 0x04004EA1 RID: 20129
		public const int MsgId_RandomStoreBuyStoreItemAck = 1213;

		// Token: 0x04004EA2 RID: 20130
		public const int MsgId_RandomStoreBuyStoreItemReq = 1214;

		// Token: 0x04004EA3 RID: 20131
		public const int MsgId_RandomStoreFlushAck = 1215;

		// Token: 0x04004EA4 RID: 20132
		public const int MsgId_RandomStoreFlushReq = 1216;

		// Token: 0x04004EA5 RID: 20133
		public const int MsgId_RandomStoreGetAck = 1217;

		// Token: 0x04004EA6 RID: 20134
		public const int MsgId_RandomStoreGetReq = 1218;

		// Token: 0x04004EA7 RID: 20135
		public const int MsgId_RankingListInfoQueryAck = 1219;

		// Token: 0x04004EA8 RID: 20136
		public const int MsgId_RankingListInfoQueryReq = 1220;

		// Token: 0x04004EA9 RID: 20137
		public const int MsgId_RemoveAnnouncementNtf = 1221;

		// Token: 0x04004EAA RID: 20138
		public const int MsgId_RiftChapterRewardGainAck = 1222;

		// Token: 0x04004EAB RID: 20139
		public const int MsgId_RiftChapterRewardGainReq = 1223;

		// Token: 0x04004EAC RID: 20140
		public const int MsgId_RiftLevelAttackAck = 1224;

		// Token: 0x04004EAD RID: 20141
		public const int MsgId_RiftLevelAttackReq = 1225;

		// Token: 0x04004EAE RID: 20142
		public const int MsgId_RiftLevelBattleFinishedAck = 1226;

		// Token: 0x04004EAF RID: 20143
		public const int MsgId_RiftLevelBattleFinishedReq = 1227;

		// Token: 0x04004EB0 RID: 20144
		public const int MsgId_RiftLevelRaidAck = 1228;

		// Token: 0x04004EB1 RID: 20145
		public const int MsgId_RiftLevelRaidReq = 1229;

		// Token: 0x04004EB2 RID: 20146
		public const int MsgId_SelectCardAck = 1230;

		// Token: 0x04004EB3 RID: 20147
		public const int MsgId_SelectCardReq = 1231;

		// Token: 0x04004EB4 RID: 20148
		public const int MsgId_SellBagItemAck = 1232;

		// Token: 0x04004EB5 RID: 20149
		public const int MsgId_SellBagItemReq = 1233;

		// Token: 0x04004EB6 RID: 20150
		public const int MsgId_SetProtagonistAck = 1234;

		// Token: 0x04004EB7 RID: 20151
		public const int MsgId_SetProtagonistReq = 1235;

		// Token: 0x04004EB8 RID: 20152
		public const int MsgId_TeamRoomAuthorityChangeAck = 1236;

		// Token: 0x04004EB9 RID: 20153
		public const int MsgId_TeamRoomAuthorityChangeNtf = 1237;

		// Token: 0x04004EBA RID: 20154
		public const int MsgId_TeamRoomAuthorityChangeReq = 1238;

		// Token: 0x04004EBB RID: 20155
		public const int MsgId_TeamRoomAutoMatchAck = 1239;

		// Token: 0x04004EBC RID: 20156
		public const int MsgId_TeamRoomAutoMatchCancelAck = 1240;

		// Token: 0x04004EBD RID: 20157
		public const int MsgId_TeamRoomAutoMatchCancelReq = 1241;

		// Token: 0x04004EBE RID: 20158
		public const int MsgId_TeamRoomAutoMatchInfoNtf = 1242;

		// Token: 0x04004EBF RID: 20159
		public const int MsgId_TeamRoomAutoMatchReq = 1243;

		// Token: 0x04004EC0 RID: 20160
		public const int MsgId_TeamRoomCreateAck = 1244;

		// Token: 0x04004EC1 RID: 20161
		public const int MsgId_TeamRoomCreateReq = 1245;

		// Token: 0x04004EC2 RID: 20162
		public const int MsgId_TeamRoomGetAck = 1246;

		// Token: 0x04004EC3 RID: 20163
		public const int MsgId_TeamRoomGetReq = 1247;

		// Token: 0x04004EC4 RID: 20164
		public const int MsgId_TeamRoomInvitationRefusedAck = 1248;

		// Token: 0x04004EC5 RID: 20165
		public const int MsgId_TeamRoomInvitationRefusedNtf = 1249;

		// Token: 0x04004EC6 RID: 20166
		public const int MsgId_TeamRoomInvitationRefusedReq = 1250;

		// Token: 0x04004EC7 RID: 20167
		public const int MsgId_TeamRoomInviteAck = 1251;

		// Token: 0x04004EC8 RID: 20168
		public const int MsgId_TeamRoomInviteNtf = 1252;

		// Token: 0x04004EC9 RID: 20169
		public const int MsgId_TeamRoomInviteReq = 1253;

		// Token: 0x04004ECA RID: 20170
		public const int MsgId_TeamRoomJoinAck = 1254;

		// Token: 0x04004ECB RID: 20171
		public const int MsgId_TeamRoomJoinReq = 1255;

		// Token: 0x04004ECC RID: 20172
		public const int MsgId_TeamRoomPlayerJoinNtf = 1256;

		// Token: 0x04004ECD RID: 20173
		public const int MsgId_TeamRoomPlayerLeaveWaitingListAndJoinRoomNtf = 1257;

		// Token: 0x04004ECE RID: 20174
		public const int MsgId_TeamRoomPlayerQuitNtf = 1258;

		// Token: 0x04004ECF RID: 20175
		public const int MsgId_TeamRoomQuitAck = 1259;

		// Token: 0x04004ED0 RID: 20176
		public const int MsgId_TeamRoomQuitReq = 1260;

		// Token: 0x04004ED1 RID: 20177
		public const int MsgId_TeamRoomViewAck = 1261;

		// Token: 0x04004ED2 RID: 20178
		public const int MsgId_TeamRoomViewReq = 1262;

		// Token: 0x04004ED3 RID: 20179
		public const int MsgId_ThearchyTrialLevelAttackAck = 1263;

		// Token: 0x04004ED4 RID: 20180
		public const int MsgId_ThearchyTrialLevelAttackReq = 1264;

		// Token: 0x04004ED5 RID: 20181
		public const int MsgId_ThearchyTrialLevelBattleFinishedAck = 1265;

		// Token: 0x04004ED6 RID: 20182
		public const int MsgId_ThearchyTrialLevelBattleFinishedReq = 1266;

		// Token: 0x04004ED7 RID: 20183
		public const int MsgId_TreasureLevelAttackAck = 1267;

		// Token: 0x04004ED8 RID: 20184
		public const int MsgId_TreasureLevelAttackReq = 1268;

		// Token: 0x04004ED9 RID: 20185
		public const int MsgId_TreasureLevelBattleFinishedAck = 1269;

		// Token: 0x04004EDA RID: 20186
		public const int MsgId_TreasureLevelBattleFinishedReq = 1270;

		// Token: 0x04004EDB RID: 20187
		public const int MsgId_UpdateOperationalActivityNtf = 1271;

		// Token: 0x04004EDC RID: 20188
		public const int MsgId_UpdateSurveyNtf = 1272;

		// Token: 0x04004EDD RID: 20189
		public const int MsgId_UseBagItemAck = 1273;

		// Token: 0x04004EDE RID: 20190
		public const int MsgId_UseBagItemReq = 1274;

		// Token: 0x04004EDF RID: 20191
		public const int MsgId_UserGuideSetAck = 1275;

		// Token: 0x04004EE0 RID: 20192
		public const int MsgId_UserGuideSetReq = 1276;

		// Token: 0x04004EE1 RID: 20193
		public const int MsgId_DSHeroAssistantNtf = 1277;

		// Token: 0x04004EE2 RID: 20194
		public const int MsgId_DSTrainingGroundNtf = 1278;

		// Token: 0x04004EE3 RID: 20195
		public const int MsgId_TrainingGroundTechLevelupAck = 1279;

		// Token: 0x04004EE4 RID: 20196
		public const int MsgId_TrainingGroundTechLevelupReq = 1280;

		// Token: 0x04004EE5 RID: 20197
		public const int MsgId_TeamRoomSelfKickOutNtf = 1282;

		// Token: 0x04004EE6 RID: 20198
		public const int MsgId_BusinessCardSelectAck = 1283;

		// Token: 0x04004EE7 RID: 20199
		public const int MsgId_BusinessCardSelectReq = 1284;

		// Token: 0x04004EE8 RID: 20200
		public const int MsgId_DSFriendNtf = 1285;

		// Token: 0x04004EE9 RID: 20201
		public const int MsgId_FriendInfoUpdateNtf = 1286;

		// Token: 0x04004EEA RID: 20202
		public const int MsgId_BusinessCardDescUpdateAck = 1287;

		// Token: 0x04004EEB RID: 20203
		public const int MsgId_BusinessCardDescUpdateReq = 1288;

		// Token: 0x04004EEC RID: 20204
		public const int MsgId_BusinessCardHeroSetUpdateAck = 1289;

		// Token: 0x04004EED RID: 20205
		public const int MsgId_BusinessCardHeroSetUpdateReq = 1290;

		// Token: 0x04004EEE RID: 20206
		public const int MsgId_LikesSendAck = 1291;

		// Token: 0x04004EEF RID: 20207
		public const int MsgId_LikesSendReq = 1292;

		// Token: 0x04004EF0 RID: 20208
		public const int MsgId_HeroAssistantAssignToTaskAck = 1295;

		// Token: 0x04004EF1 RID: 20209
		public const int MsgId_HeroAssistantAssignToTaskReq = 1296;

		// Token: 0x04004EF2 RID: 20210
		public const int MsgId_HeroAssistantCancelTaskAck = 1297;

		// Token: 0x04004EF3 RID: 20211
		public const int MsgId_HeroAssistantCancelTaskReq = 1298;

		// Token: 0x04004EF4 RID: 20212
		public const int MsgId_HeroAssistantClaimRewardAck = 1299;

		// Token: 0x04004EF5 RID: 20213
		public const int MsgId_HeroAssistantClaimRewardReq = 1300;

		// Token: 0x04004EF6 RID: 20214
		public const int MsgId_BattleRoomCreateAck = 1302;

		// Token: 0x04004EF7 RID: 20215
		public const int MsgId_TeamBattleRoomCreateReq = 1305;

		// Token: 0x04004EF8 RID: 20216
		public const int MsgId_ChatGroupChangeOwnerAck = 1312;

		// Token: 0x04004EF9 RID: 20217
		public const int MsgId_ChatGroupChangeOwnerReq = 1313;

		// Token: 0x04004EFA RID: 20218
		public const int MsgId_ChatGroupCreateChatGroupAck = 1314;

		// Token: 0x04004EFB RID: 20219
		public const int MsgId_ChatGroupCreateChatGroupReq = 1315;

		// Token: 0x04004EFC RID: 20220
		public const int MsgId_ChatGroupGetChatGroupAck = 1316;

		// Token: 0x04004EFD RID: 20221
		public const int MsgId_ChatGroupGetChatGroupMemberAck = 1317;

		// Token: 0x04004EFE RID: 20222
		public const int MsgId_ChatGroupGetChatGroupMemberReq = 1318;

		// Token: 0x04004EFF RID: 20223
		public const int MsgId_ChatGroupGetChatGroupReq = 1319;

		// Token: 0x04004F00 RID: 20224
		public const int MsgId_ChatGroupInviteToChatGroupAck = 1320;

		// Token: 0x04004F01 RID: 20225
		public const int MsgId_ChatGroupInviteToChatGroupReq = 1321;

		// Token: 0x04004F02 RID: 20226
		public const int MsgId_ChatGroupLeaveChatGroupAck = 1322;

		// Token: 0x04004F03 RID: 20227
		public const int MsgId_ChatGroupLeaveChatGroupReq = 1323;

		// Token: 0x04004F04 RID: 20228
		public const int MsgId_ChatGroupUpdateNtf = 1324;

		// Token: 0x04004F05 RID: 20229
		public const int MsgId_BattleRoomHeroSetupAck = 1331;

		// Token: 0x04004F06 RID: 20230
		public const int MsgId_BattleRoomHeroSetupNtf = 1332;

		// Token: 0x04004F07 RID: 20231
		public const int MsgId_BattleRoomHeroSetupReq = 1333;

		// Token: 0x04004F08 RID: 20232
		public const int MsgId_BattleRoomHeroSwapAck = 1334;

		// Token: 0x04004F09 RID: 20233
		public const int MsgId_BattleRoomHeroSwapReq = 1335;

		// Token: 0x04004F0A RID: 20234
		public const int MsgId_BattleRoomPlayerStatusChangedNtf = 1339;

		// Token: 0x04004F0B RID: 20235
		public const int MsgId_BattleRoomPlayerStatusChangeAck = 1340;

		// Token: 0x04004F0C RID: 20236
		public const int MsgId_BattleRoomPlayerStatusChangeReq = 1341;

		// Token: 0x04004F0D RID: 20237
		public const int MsgId_HeroRandomActionSetAck = 1342;

		// Token: 0x04004F0E RID: 20238
		public const int MsgId_HeroRandomActionSetReq = 1343;

		// Token: 0x04004F0F RID: 20239
		public const int MsgId_BagItemDecomposeAck = 1344;

		// Token: 0x04004F10 RID: 20240
		public const int MsgId_BagItemDecomposeReq = 1345;

		// Token: 0x04004F11 RID: 20241
		public const int MsgId_BattleRoomBattleCommandExecuteAck = 1349;

		// Token: 0x04004F12 RID: 20242
		public const int MsgId_BattleRoomBattleCommandExecuteNtf = 1350;

		// Token: 0x04004F13 RID: 20243
		public const int MsgId_BattleRoomBattleCommandExecuteReq = 1351;

		// Token: 0x04004F14 RID: 20244
		public const int MsgId_BattlePracticeAcceptAck = 1353;

		// Token: 0x04004F15 RID: 20245
		public const int MsgId_BattlePracticeAcceptReq = 1354;

		// Token: 0x04004F16 RID: 20246
		public const int MsgId_BattlePracticeCancelAck = 1355;

		// Token: 0x04004F17 RID: 20247
		public const int MsgId_BattlePracticeCancelReq = 1356;

		// Token: 0x04004F18 RID: 20248
		public const int MsgId_BattlePracticeDeclineAck = 1357;

		// Token: 0x04004F19 RID: 20249
		public const int MsgId_BattlePracticeDeclinedNtf = 1358;

		// Token: 0x04004F1A RID: 20250
		public const int MsgId_BattlePracticeDeclineReq = 1359;

		// Token: 0x04004F1B RID: 20251
		public const int MsgId_BattlePracticeFailNtf = 1360;

		// Token: 0x04004F1C RID: 20252
		public const int MsgId_BattlePracticeInviteAck = 1361;

		// Token: 0x04004F1D RID: 20253
		public const int MsgId_BattlePracticeInvitedNtf = 1362;

		// Token: 0x04004F1E RID: 20254
		public const int MsgId_BattlePracticeInviteReq = 1363;

		// Token: 0x04004F1F RID: 20255
		public const int MsgId_BattleRoomQuitAck = 1366;

		// Token: 0x04004F20 RID: 20256
		public const int MsgId_BattleRoomQuitReq = 1367;

		// Token: 0x04004F21 RID: 20257
		public const int MsgId_ChatGroupKickUserAck = 1368;

		// Token: 0x04004F22 RID: 20258
		public const int MsgId_ChatGroupKickUserReq = 1369;

		// Token: 0x04004F23 RID: 20259
		public const int MsgId_FriendGetUserSummaryAck = 1370;

		// Token: 0x04004F24 RID: 20260
		public const int MsgId_FriendGetUserSummaryReq = 1371;

		// Token: 0x04004F25 RID: 20261
		public const int MsgId_BattleRoomPlayerActionBeginAck = 1372;

		// Token: 0x04004F26 RID: 20262
		public const int MsgId_BattleRoomPlayerActionBeginReq = 1373;

		// Token: 0x04004F27 RID: 20263
		public const int MsgId_BattleRoomTeamBattleFinishNtf = 1374;

		// Token: 0x04004F28 RID: 20264
		public const int MsgId_BattleRoomTeamBattleJoinNtf = 1375;

		// Token: 0x04004F29 RID: 20265
		public const int MsgId_BattleRoomTeamBattleStartNtf = 1376;

		// Token: 0x04004F2A RID: 20266
		public const int MsgId_FriendshipPointsClaimAck = 1377;

		// Token: 0x04004F2B RID: 20267
		public const int MsgId_FriendshipPointsClaimReq = 1378;

		// Token: 0x04004F2C RID: 20268
		public const int MsgId_FriendshipPointsSendAck = 1379;

		// Token: 0x04004F2D RID: 20269
		public const int MsgId_FriendshipPointsSendReq = 1380;

		// Token: 0x04004F2E RID: 20270
		public const int MsgId_ChatGroupChangeNameAck = 1381;

		// Token: 0x04004F2F RID: 20271
		public const int MsgId_ChatGroupChangeNameReq = 1382;

		// Token: 0x04004F30 RID: 20272
		public const int MsgId_BattleRoomPVPBattleFinishNtf = 1383;

		// Token: 0x04004F31 RID: 20273
		public const int MsgId_BattleRoomPVPBattleJoinNtf = 1384;

		// Token: 0x04004F32 RID: 20274
		public const int MsgId_BattleRoomPVPBattleStartNtf = 1385;

		// Token: 0x04004F33 RID: 20275
		public const int MsgId_DSHeroPhantomNtf = 1386;

		// Token: 0x04004F34 RID: 20276
		public const int MsgId_HeroPhantomAttackAck = 1387;

		// Token: 0x04004F35 RID: 20277
		public const int MsgId_HeroPhantomAttackReq = 1388;

		// Token: 0x04004F36 RID: 20278
		public const int MsgId_HeroPhantomBattleFinishedAck = 1389;

		// Token: 0x04004F37 RID: 20279
		public const int MsgId_HeroPhantomBattleFinishedReq = 1390;

		// Token: 0x04004F38 RID: 20280
		public const int MsgId_BattleRoomGetAck = 1395;

		// Token: 0x04004F39 RID: 20281
		public const int MsgId_BattleRoomGetReq = 1396;

		// Token: 0x04004F3A RID: 20282
		public const int MsgId_ChatContactUserSummaryInfoAck = 1397;

		// Token: 0x04004F3B RID: 20283
		public const int MsgId_ChatContactUserSummaryInfoReq = 1398;

		// Token: 0x04004F3C RID: 20284
		public const int MsgId_DSCooperateBattleNtf = 1399;

		// Token: 0x04004F3D RID: 20285
		public const int MsgId_EquipmentEnchantAck = 1400;

		// Token: 0x04004F3E RID: 20286
		public const int MsgId_EquipmentEnchantReq = 1401;

		// Token: 0x04004F3F RID: 20287
		public const int MsgId_EquipmentEnchantSaveAck = 1402;

		// Token: 0x04004F40 RID: 20288
		public const int MsgId_EquipmentEnchantSaveReq = 1403;

		// Token: 0x04004F41 RID: 20289
		public const int MsgId_BattleRoomPlayerBattleInfoInitNtf = 1404;

		// Token: 0x04004F42 RID: 20290
		public const int MsgId_BattleRoomQuitNtf = 1405;

		// Token: 0x04004F43 RID: 20291
		public const int MsgId_MailAttachmentAutoGetAck = 1406;

		// Token: 0x04004F44 RID: 20292
		public const int MsgId_MailAttachmentAutoGetReq = 1407;

		// Token: 0x04004F45 RID: 20293
		public const int MsgId_DSNoviceNtf = 1408;

		// Token: 0x04004F46 RID: 20294
		public const int MsgId_NoviceClaimRewardAck = 1409;

		// Token: 0x04004F47 RID: 20295
		public const int MsgId_NoviceClaimRewardReq = 1410;

		// Token: 0x04004F48 RID: 20296
		public const int MsgId_ClientHeartBeatNtf = 1411;

		// Token: 0x04004F49 RID: 20297
		public const int MsgId_ClientCheatNtf = 1412;

		// Token: 0x04004F4A RID: 20298
		public const int MsgId_FriendSocialRelationUpdateNtf = 1414;

		// Token: 0x04004F4B RID: 20299
		public const int MsgId_ClientAppPauseNtf = 1415;

		// Token: 0x04004F4C RID: 20300
		public const int MsgId_ClientAppResumeNtf = 1416;

		// Token: 0x04004F4D RID: 20301
		public const int MsgId_TeamRoomInviteeLevelInfoNtf = 1419;

		// Token: 0x04004F4E RID: 20302
		public const int MsgId_GameRatingOpenAck = 1420;

		// Token: 0x04004F4F RID: 20303
		public const int MsgId_GameRatingOpenReq = 1421;

		// Token: 0x04004F50 RID: 20304
		public const int MsgId_RealTimePVPWaitingForOpponentAck = 1422;

		// Token: 0x04004F51 RID: 20305
		public const int MsgId_RealTimePVPWaitingForOpponentReq = 1423;

		// Token: 0x04004F52 RID: 20306
		public const int MsgId_ArenaFlushOpponentsNtf = 1424;

		// Token: 0x04004F53 RID: 20307
		public const int MsgId_RealTimePVPMatchupNtf = 1425;

		// Token: 0x04004F54 RID: 20308
		public const int MsgId_BoughtRechargeStoreItemNtf = 1426;

		// Token: 0x04004F55 RID: 20309
		public const int MsgId_DSRechargeStoreNtf = 1427;

		// Token: 0x04004F56 RID: 20310
		public const int MsgId_BattleRoomRealTimePVPBattleJoinNtf = 1428;

		// Token: 0x04004F57 RID: 20311
		public const int MsgId_HeadPortraitSetAck = 1429;

		// Token: 0x04004F58 RID: 20312
		public const int MsgId_HeadPortraitSetReq = 1430;

		// Token: 0x04004F59 RID: 20313
		public const int MsgId_DSResourceNtf = 1431;

		// Token: 0x04004F5A RID: 20314
		public const int MsgId_HeadFrameSetAck = 1432;

		// Token: 0x04004F5B RID: 20315
		public const int MsgId_HeadFrameSetReq = 1433;

		// Token: 0x04004F5C RID: 20316
		public const int MsgId_BattleRoomRealTimePVPBattleFinishNtf = 1434;

		// Token: 0x04004F5D RID: 20317
		public const int MsgId_DSRealTimePVPNtf = 1435;

		// Token: 0x04004F5E RID: 20318
		public const int MsgId_DSRaffleNtf = 1436;

		// Token: 0x04004F5F RID: 20319
		public const int MsgId_RaffleDrawAck = 1437;

		// Token: 0x04004F60 RID: 20320
		public const int MsgId_RaffleDrawReq = 1438;

		// Token: 0x04004F61 RID: 20321
		public const int MsgId_RealTimePVPCancelWaitingForOpponentAck = 1439;

		// Token: 0x04004F62 RID: 20322
		public const int MsgId_RealTimePVPCancelWaitingForOpponentReq = 1440;

		// Token: 0x04004F63 RID: 20323
		public const int MsgId_RealTimePVPGetInfoAck = 1441;

		// Token: 0x04004F64 RID: 20324
		public const int MsgId_RealTimePVPGetInfoReq = 1442;

		// Token: 0x04004F65 RID: 20325
		public const int MsgId_RealTimePVPGetTopPlayersAck = 1443;

		// Token: 0x04004F66 RID: 20326
		public const int MsgId_RealTimePVPGetTopPlayersReq = 1444;

		// Token: 0x04004F67 RID: 20327
		public const int MsgId_GiftStoreBuyGoodsNtf = 1445;

		// Token: 0x04004F68 RID: 20328
		public const int MsgId_GiftStoreItemBuyAck = 1446;

		// Token: 0x04004F69 RID: 20329
		public const int MsgId_GiftStoreItemBuyReq = 1447;

		// Token: 0x04004F6A RID: 20330
		public const int MsgId_CharSkinTakeOffAck = 1448;

		// Token: 0x04004F6B RID: 20331
		public const int MsgId_CharSkinTakeOffReq = 1449;

		// Token: 0x04004F6C RID: 20332
		public const int MsgId_CharSkinWearAck = 1450;

		// Token: 0x04004F6D RID: 20333
		public const int MsgId_CharSkinWearReq = 1451;

		// Token: 0x04004F6E RID: 20334
		public const int MsgId_ModelSkinTakeOffAck = 1452;

		// Token: 0x04004F6F RID: 20335
		public const int MsgId_ModelSkinTakeOffReq = 1453;

		// Token: 0x04004F70 RID: 20336
		public const int MsgId_ModelSkinWearAck = 1454;

		// Token: 0x04004F71 RID: 20337
		public const int MsgId_ModelSkinWearReq = 1455;

		// Token: 0x04004F72 RID: 20338
		public const int MsgId_SoldierSkinTakeOffAck = 1456;

		// Token: 0x04004F73 RID: 20339
		public const int MsgId_SoldierSkinTakeOffReq = 1457;

		// Token: 0x04004F74 RID: 20340
		public const int MsgId_SoldierSkinWearAck = 1458;

		// Token: 0x04004F75 RID: 20341
		public const int MsgId_SoldierSkinWearReq = 1459;

		// Token: 0x04004F76 RID: 20342
		public const int MsgId_BattleRoomHeroBanAck = 1460;

		// Token: 0x04004F77 RID: 20343
		public const int MsgId_BattleRoomHeroBanReq = 1461;

		// Token: 0x04004F78 RID: 20344
		public const int MsgId_BattleRoomHeroProtectAck = 1462;

		// Token: 0x04004F79 RID: 20345
		public const int MsgId_BattleRoomHeroProtectReq = 1463;

		// Token: 0x04004F7A RID: 20346
		public const int MsgId_DSGiftStoreNtf = 1464;

		// Token: 0x04004F7B RID: 20347
		public const int MsgId_MonthCardUpdateNtf = 1465;

		// Token: 0x04004F7C RID: 20348
		public const int MsgId_BattleRoomDataChangeNtf = 1466;

		// Token: 0x04004F7D RID: 20349
		public const int MsgId_BattleRoomEndCurrentBPTurnAck = 1467;

		// Token: 0x04004F7E RID: 20350
		public const int MsgId_BattleRoomEndCurrentBPTurnReq = 1468;

		// Token: 0x04004F7F RID: 20351
		public const int MsgId_RMBUpdateNtf = 1469;

		// Token: 0x04004F80 RID: 20352
		public const int MsgId_GiftStoreOperationalGoodsUpdateNtf = 1470;

		// Token: 0x04004F81 RID: 20353
		public const int MsgId_GiftStoreAppleSubscribeAck = 1471;

		// Token: 0x04004F82 RID: 20354
		public const int MsgId_GiftStoreAppleSubscribeReq = 1472;

		// Token: 0x04004F83 RID: 20355
		public const int MsgId_BattleRoomRealTimePVPBattleStartNtf = 1473;

		// Token: 0x04004F84 RID: 20356
		public const int MsgId_AdvertisementFlowLayoutUpdateNtf = 1474;

		// Token: 0x04004F85 RID: 20357
		public const int MsgId_RealTimePVPAcquireWinsBonusAck = 1475;

		// Token: 0x04004F86 RID: 20358
		public const int MsgId_RealTimePVPAcquireWinsBonusReq = 1476;

		// Token: 0x04004F87 RID: 20359
		public const int MsgId_HeadPortraitAndHeadFrameSetAck = 1477;

		// Token: 0x04004F88 RID: 20360
		public const int MsgId_HeadPortraitAndHeadFrameSetReq = 1478;

		// Token: 0x04004F89 RID: 20361
		public const int MsgId_RealTimePVPLeaderboardInfoNtf = 1479;

		// Token: 0x04004F8A RID: 20362
		public const int MsgId_RechargeStoreBuyGoodsAck = 1480;

		// Token: 0x04004F8B RID: 20363
		public const int MsgId_RechargeStoreBuyGoodsReq = 1481;

		// Token: 0x04004F8C RID: 20364
		public const int MsgId_DSBagExtraNtf = 1482;

		// Token: 0x04004F8D RID: 20365
		public const int MsgId_GiftStoreCancelBuyAck = 1483;

		// Token: 0x04004F8E RID: 20366
		public const int MsgId_GiftStoreCancelBuyReq = 1484;

		// Token: 0x04004F8F RID: 20367
		public const int MsgId_CheckOnlineAck = 1486;

		// Token: 0x04004F90 RID: 20368
		public const int MsgId_CheckOnlineReq = 1487;

		// Token: 0x04004F91 RID: 20369
		public const int MsgId_RechargeStoreCancelBuyAck = 1488;

		// Token: 0x04004F92 RID: 20370
		public const int MsgId_RechargeStoreCancelBuyReq = 1489;

		// Token: 0x04004F93 RID: 20371
		public const int MsgId_BattleRoomBattleLogReq = 1490;

		// Token: 0x04004F94 RID: 20372
		public const int MsgId_PullOrderRewardAck = 1491;

		// Token: 0x04004F95 RID: 20373
		public const int MsgId_PullOrderRewardReq = 1492;

		// Token: 0x04004F96 RID: 20374
		public const int MsgId_ShareAck = 1493;

		// Token: 0x04004F97 RID: 20375
		public const int MsgId_ShareReq = 1494;

		// Token: 0x04004F98 RID: 20376
		public const int MsgId_DSRealTimePVPBattleReportNtf = 1495;

		// Token: 0x04004F99 RID: 20377
		public const int MsgId_DSRealTimePVPPromotionBattleReportNtf = 1496;

		// Token: 0x04004F9A RID: 20378
		public const int MsgId_DirectelyActivitedMissionUpdateNtf = 1497;

		// Token: 0x04004F9B RID: 20379
		public const int MsgId_ExchangeHeroFragmentAck = 1500;

		// Token: 0x04004F9C RID: 20380
		public const int MsgId_ExchangeHeroFragmentReq = 1501;

		// Token: 0x04004F9D RID: 20381
		public const int MsgId_AutoTakeOffEquipmentsAck = 1502;

		// Token: 0x04004F9E RID: 20382
		public const int MsgId_AutoTakeOffEquipmentsReq = 1503;

		// Token: 0x04004F9F RID: 20383
		public const int MsgId_GuildCreateAck = 1504;

		// Token: 0x04004FA0 RID: 20384
		public const int MsgId_GuildCreateReq = 1505;

		// Token: 0x04004FA1 RID: 20385
		public const int MsgId_GuildJoinApplyAck = 1508;

		// Token: 0x04004FA2 RID: 20386
		public const int MsgId_GuildJoinApplyReq = 1509;

		// Token: 0x04004FA3 RID: 20387
		public const int MsgId_ChatGuildHistoryMessageNtf = 1512;

		// Token: 0x04004FA4 RID: 20388
		public const int MsgId_GuildInvitePlayerListAck = 1513;

		// Token: 0x04004FA5 RID: 20389
		public const int MsgId_GuildInvitePlayerListReq = 1514;

		// Token: 0x04004FA6 RID: 20390
		public const int MsgId_GuildRandomListAck = 1515;

		// Token: 0x04004FA7 RID: 20391
		public const int MsgId_GuildRandomListReq = 1516;

		// Token: 0x04004FA8 RID: 20392
		public const int MsgId_GuildSearchAck = 1517;

		// Token: 0x04004FA9 RID: 20393
		public const int MsgId_GuildSearchReq = 1518;

		// Token: 0x04004FAA RID: 20394
		public const int MsgId_GuildHiringDeclarationSetAck = 1519;

		// Token: 0x04004FAB RID: 20395
		public const int MsgId_GuildHiringDeclarationSetReq = 1520;

		// Token: 0x04004FAC RID: 20396
		public const int MsgId_GuildGetAck = 1523;

		// Token: 0x04004FAD RID: 20397
		public const int MsgId_GuildGetReq = 1524;

		// Token: 0x04004FAE RID: 20398
		public const int MsgId_GuildVicePresidentAppointAck = 1525;

		// Token: 0x04004FAF RID: 20399
		public const int MsgId_GuildVicePresidentAppointReq = 1526;

		// Token: 0x04004FB0 RID: 20400
		public const int MsgId_GuildKickOutAck = 1527;

		// Token: 0x04004FB1 RID: 20401
		public const int MsgId_GuildKickOutReq = 1528;

		// Token: 0x04004FB2 RID: 20402
		public const int MsgId_GuildQuitAck = 1529;

		// Token: 0x04004FB3 RID: 20403
		public const int MsgId_GuildQuitReq = 1530;

		// Token: 0x04004FB4 RID: 20404
		public const int MsgId_GuildPresidentAppointAck = 1531;

		// Token: 0x04004FB5 RID: 20405
		public const int MsgId_GuildPresidentAppointReq = 1532;

		// Token: 0x04004FB6 RID: 20406
		public const int MsgId_GuildPresidentRelieveAck = 1533;

		// Token: 0x04004FB7 RID: 20407
		public const int MsgId_GuildPresidentRelieveReq = 1534;

		// Token: 0x04004FB8 RID: 20408
		public const int MsgId_DSGuildNtf = 1535;

		// Token: 0x04004FB9 RID: 20409
		public const int MsgId_GuildAnnouncementSetAck = 1536;

		// Token: 0x04004FBA RID: 20410
		public const int MsgId_GuildAnnouncementSetReq = 1537;

		// Token: 0x04004FBB RID: 20411
		public const int MsgId_GuildJoinApplyConfirmAck = 1538;

		// Token: 0x04004FBC RID: 20412
		public const int MsgId_GuildJoinApplyConfirmReq = 1539;

		// Token: 0x04004FBD RID: 20413
		public const int MsgId_GuildJoinInvitationConfirmAck = 1540;

		// Token: 0x04004FBE RID: 20414
		public const int MsgId_GuildJoinInvitationConfirmReq = 1541;

		// Token: 0x04004FBF RID: 20415
		public const int MsgId_AllGuildJoinInvitationRefuseAck = 1542;

		// Token: 0x04004FC0 RID: 20416
		public const int MsgId_AllGuildJoinInvitationRefuseReq = 1543;

		// Token: 0x04004FC1 RID: 20417
		public const int MsgId_GuildJoinInvitationRefuseAck = 1544;

		// Token: 0x04004FC2 RID: 20418
		public const int MsgId_GuildJoinInvitationRefuseReq = 1545;

		// Token: 0x04004FC3 RID: 20419
		public const int MsgId_GuildJoinInvitationGetAck = 1548;

		// Token: 0x04004FC4 RID: 20420
		public const int MsgId_GuildJoinInvitationGetReq = 1549;

		// Token: 0x04004FC5 RID: 20421
		public const int MsgId_DSUnchartedScoreNtf = 1550;

		// Token: 0x04004FC6 RID: 20422
		public const int MsgId_UnchartedScoreChallengeLevelAttackAck = 1551;

		// Token: 0x04004FC7 RID: 20423
		public const int MsgId_UnchartedScoreChallengeLevelAttackReq = 1552;

		// Token: 0x04004FC8 RID: 20424
		public const int MsgId_UnchartedScoreChallengeLevelBattleFinishedAck = 1553;

		// Token: 0x04004FC9 RID: 20425
		public const int MsgId_UnchartedScoreChallengeLevelBattleFinishedReq = 1554;

		// Token: 0x04004FCA RID: 20426
		public const int MsgId_UnchartedScoreRewardGainAck = 1555;

		// Token: 0x04004FCB RID: 20427
		public const int MsgId_UnchartedScoreRewardGainReq = 1556;

		// Token: 0x04004FCC RID: 20428
		public const int MsgId_UnchartedScoreScoreLevelAttackAck = 1557;

		// Token: 0x04004FCD RID: 20429
		public const int MsgId_UnchartedScoreScoreLevelAttackReq = 1558;

		// Token: 0x04004FCE RID: 20430
		public const int MsgId_UnchartedScoreScoreLevelBattleFinishedAck = 1559;

		// Token: 0x04004FCF RID: 20431
		public const int MsgId_UnchartedScoreScoreLevelBattleFinishedReq = 1560;

		// Token: 0x04004FD0 RID: 20432
		public const int MsgId_AllGuildJoinApplyRefuseAck = 1561;

		// Token: 0x04004FD1 RID: 20433
		public const int MsgId_AllGuildJoinApplyRefuseReq = 1562;

		// Token: 0x04004FD2 RID: 20434
		public const int MsgId_GuildJoinApplyGetAck = 1563;

		// Token: 0x04004FD3 RID: 20435
		public const int MsgId_GuildJoinApplyGetReq = 1564;

		// Token: 0x04004FD4 RID: 20436
		public const int MsgId_GuildJoinApplyRefuseAck = 1565;

		// Token: 0x04004FD5 RID: 20437
		public const int MsgId_GuildJoinApplyRefuseReq = 1566;

		// Token: 0x04004FD6 RID: 20438
		public const int MsgId_GuildNameChangeAck = 1567;

		// Token: 0x04004FD7 RID: 20439
		public const int MsgId_GuildNameChangeReq = 1568;

		// Token: 0x04004FD8 RID: 20440
		public const int MsgId_GuildLogGetAck = 1569;

		// Token: 0x04004FD9 RID: 20441
		public const int MsgId_GuildLogGetReq = 1570;

		// Token: 0x04004FDA RID: 20442
		public const int MsgId_GuildJoinInviteAck = 1571;

		// Token: 0x04004FDB RID: 20443
		public const int MsgId_GuildJoinInviteReq = 1572;

		// Token: 0x04004FDC RID: 20444
		public const int MsgId_ClimbTowerGetAck = 1575;

		// Token: 0x04004FDD RID: 20445
		public const int MsgId_ClimbTowerGetReq = 1576;

		// Token: 0x04004FDE RID: 20446
		public const int MsgId_ClimbTowerLevelAttackAck = 1577;

		// Token: 0x04004FDF RID: 20447
		public const int MsgId_ClimbTowerLevelAttackReq = 1578;

		// Token: 0x04004FE0 RID: 20448
		public const int MsgId_ClimbTowerLevelBattleFinishedAck = 1579;

		// Token: 0x04004FE1 RID: 20449
		public const int MsgId_ClimbTowerLevelBattleFinishedReq = 1580;

		// Token: 0x04004FE2 RID: 20450
		public const int MsgId_ClimbTowerRaidAck = 1581;

		// Token: 0x04004FE3 RID: 20451
		public const int MsgId_ClimbTowerRaidReq = 1582;

		// Token: 0x04004FE4 RID: 20452
		public const int MsgId_DSClimbTowerNtf = 1583;

		// Token: 0x04004FE5 RID: 20453
		public const int MsgId_RedeemClaimAck = 1584;

		// Token: 0x04004FE6 RID: 20454
		public const int MsgId_RedeemClaimReq = 1585;

		// Token: 0x04004FE7 RID: 20455
		public const int MsgId_RedeemInfoAck = 1586;

		// Token: 0x04004FE8 RID: 20456
		public const int MsgId_RedeemInfoReq = 1587;

		// Token: 0x04004FE9 RID: 20457
		public const int MsgId_TeamRoomPlayerPositionChangeAck = 1588;

		// Token: 0x04004FEA RID: 20458
		public const int MsgId_TeamRoomPlayerPositionChangeReq = 1589;

		// Token: 0x04004FEB RID: 20459
		public const int MsgId_TeamRoomPlayerPositionChangeNtf = 1590;

		// Token: 0x04004FEC RID: 20460
		public const int MsgId_GuildUpdateAnnouncementNtf = 1592;

		// Token: 0x04004FED RID: 20461
		public const int MsgId_GuildJoinApplyAdminNtf = 1593;

		// Token: 0x04004FEE RID: 20462
		public const int MsgId_GuildJoinInvitationNtf = 1594;

		// Token: 0x04004FEF RID: 20463
		public const int MsgId_DailyFlushNtf = 1595;

		// Token: 0x04004FF0 RID: 20464
		public const int MsgId_UpdateServerTimeNtf = 1597;

		// Token: 0x04004FF1 RID: 20465
		public const int MsgId_FansRewardsFromPBTCBTClaimAck = 1598;

		// Token: 0x04004FF2 RID: 20466
		public const int MsgId_FansRewardsFromPBTCBTClaimReq = 1599;

		// Token: 0x04004FF3 RID: 20467
		public const int MsgId_FansRewardsFromPBTCBTInfoAck = 1600;

		// Token: 0x04004FF4 RID: 20468
		public const int MsgId_FansRewardsFromPBTCBTInfoReq = 1601;

		// Token: 0x04004FF5 RID: 20469
		public const int MsgId_GuildBasicSetAck = 1602;

		// Token: 0x04004FF6 RID: 20470
		public const int MsgId_GuildBasicSetReq = 1603;

		// Token: 0x04004FF7 RID: 20471
		public const int MsgId_GuildMassiveCombatAttackAck = 1604;

		// Token: 0x04004FF8 RID: 20472
		public const int MsgId_GuildMassiveCombatAttackReq = 1605;

		// Token: 0x04004FF9 RID: 20473
		public const int MsgId_GuildMassiveCombatDataAck = 1606;

		// Token: 0x04004FFA RID: 20474
		public const int MsgId_GuildMassiveCombatDataReq = 1607;

		// Token: 0x04004FFB RID: 20475
		public const int MsgId_GuildMassiveCombatNtf = 1608;

		// Token: 0x04004FFC RID: 20476
		public const int MsgId_GuildMassiveCombatStartAck = 1611;

		// Token: 0x04004FFD RID: 20477
		public const int MsgId_GuildMassiveCombatStartReq = 1612;

		// Token: 0x04004FFE RID: 20478
		public const int MsgId_GuildMassiveCombatSurrenderAck = 1613;

		// Token: 0x04004FFF RID: 20479
		public const int MsgId_GuildMassiveCombatSurrenderReq = 1614;

		// Token: 0x04005000 RID: 20480
		public const int MsgId_OpenMemoryStoreAck = 1615;

		// Token: 0x04005001 RID: 20481
		public const int MsgId_OpenMemoryStoreReq = 1616;

		// Token: 0x04005002 RID: 20482
		public const int MsgId_BattleRoomGuildMassiveCombatBattleJoinNtf = 1617;

		// Token: 0x04005003 RID: 20483
		public const int MsgId_BattleGuildMassiveCombatBattleFinishNtf = 1618;

		// Token: 0x04005004 RID: 20484
		public const int MsgId_GuildMassiveCombatPlayerNtf = 1620;

		// Token: 0x04005005 RID: 20485
		public const int MsgId_GuildMassiveCombatAttackFinishedAck = 1621;

		// Token: 0x04005006 RID: 20486
		public const int MsgId_GuildMassiveCombatAttackFinishedReq = 1622;

		// Token: 0x04005007 RID: 20487
		public const int MsgId_BattleRoomHeroPutdownAck = 1623;

		// Token: 0x04005008 RID: 20488
		public const int MsgId_BattleRoomHeroPutdownReq = 1624;

		// Token: 0x04005009 RID: 20489
		public const int MsgId_TeamRoomInviteeInfoGetAck = 1625;

		// Token: 0x0400500A RID: 20490
		public const int MsgId_TeamRoomInviteeInfoGetReq = 1626;

		// Token: 0x0400500B RID: 20491
		public const int MsgId_ProGuildMassiveCombatAttackResultNtf = 1628;

		// Token: 0x0400500C RID: 20492
		private Dictionary<int, Type> _idDic;

		// Token: 0x0400500D RID: 20493
		private Dictionary<Type, int> _typeDic;
	}
}
