using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003DE RID: 990
	[CustomLuaClass]
	public class BattleRoomPlayer
	{
		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x0010D3A0 File Offset: 0x0010B5A0
		// (set) Token: 0x06003AF1 RID: 15089 RVA: 0x0010D3A8 File Offset: 0x0010B5A8
		public string UserId { get; set; }

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x0010D3B4 File Offset: 0x0010B5B4
		// (set) Token: 0x06003AF3 RID: 15091 RVA: 0x0010D3BC File Offset: 0x0010B5BC
		public ulong SessionId { get; set; }

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x0010D3C8 File Offset: 0x0010B5C8
		// (set) Token: 0x06003AF5 RID: 15093 RVA: 0x0010D3D0 File Offset: 0x0010B5D0
		public int ChannelId { get; set; }

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x0010D3DC File Offset: 0x0010B5DC
		// (set) Token: 0x06003AF7 RID: 15095 RVA: 0x0010D3E4 File Offset: 0x0010B5E4
		public string Name { get; set; }

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x0010D3F0 File Offset: 0x0010B5F0
		// (set) Token: 0x06003AF9 RID: 15097 RVA: 0x0010D3F8 File Offset: 0x0010B5F8
		public int HeadIcon { get; set; }

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06003AFA RID: 15098 RVA: 0x0010D404 File Offset: 0x0010B604
		// (set) Token: 0x06003AFB RID: 15099 RVA: 0x0010D40C File Offset: 0x0010B60C
		public int Level { get; set; }

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x0010D418 File Offset: 0x0010B618
		// (set) Token: 0x06003AFD RID: 15101 RVA: 0x0010D420 File Offset: 0x0010B620
		public RealTimePVPInfo RTPVPInfo { get; set; }

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x0010D42C File Offset: 0x0010B62C
		// (set) Token: 0x06003AFF RID: 15103 RVA: 0x0010D434 File Offset: 0x0010B634
		public bool IsOffline { get; set; }

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x0010D440 File Offset: 0x0010B640
		// (set) Token: 0x06003B01 RID: 15105 RVA: 0x0010D448 File Offset: 0x0010B648
		public PlayerBattleStatus PlayerBattleStatus { get; set; }

		// Token: 0x06003B02 RID: 15106 RVA: 0x0010D454 File Offset: 0x0010B654
		public BattleHero FindBattleHero(int heroId)
		{
			return this.Heroes.Find((BattleHero m) => m.HeroId == heroId);
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x0010D488 File Offset: 0x0010B688
		public static ProBattleRoomPlayer BattleRoomPlayerToPbBattleRoomPlayer(BattleRoomPlayer player)
		{
			ProBattleRoomPlayer proBattleRoomPlayer = new ProBattleRoomPlayer
			{
				UserId = player.UserId,
				SessionId = player.SessionId,
				ChannelId = player.ChannelId,
				Name = player.Name,
				HeadIcon = player.HeadIcon,
				Level = player.Level,
				PlayerBattleStatus = (int)player.PlayerBattleStatus,
				Offline = player.IsOffline
			};
			if (player.RTPVPInfo != null)
			{
				proBattleRoomPlayer.RealTimePVPInfo = new ProRealTimePVPUserInfo
				{
					Dan = player.RTPVPInfo.Dan,
					LocalRank = player.RTPVPInfo.LocalRank,
					GlobalRank = player.RTPVPInfo.GlobalRank,
					Score = player.RTPVPInfo.Score,
					UserId = player.RTPVPInfo.UserId
				};
			}
			foreach (TrainingTech trainingTech in player.Techs)
			{
				proBattleRoomPlayer.Techs.Add(trainingTech.ToPro());
			}
			return proBattleRoomPlayer;
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x0010D5C8 File Offset: 0x0010B7C8
		public static BattleRoomPlayer PbBattleRoomPlayerToBattleRoomPlayer(ProBattleRoomPlayer pbPlayer)
		{
			BattleRoomPlayer battleRoomPlayer = new BattleRoomPlayer
			{
				UserId = pbPlayer.UserId,
				SessionId = pbPlayer.SessionId,
				ChannelId = pbPlayer.ChannelId,
				Name = pbPlayer.Name,
				HeadIcon = pbPlayer.HeadIcon,
				Level = pbPlayer.Level,
				PlayerBattleStatus = (PlayerBattleStatus)pbPlayer.PlayerBattleStatus,
				IsOffline = pbPlayer.Offline
			};
			foreach (ProTrainingTech tech in pbPlayer.Techs)
			{
				battleRoomPlayer.Techs.Add(TrainingTech.FromDataSection(tech));
			}
			if (pbPlayer.RealTimePVPInfo != null)
			{
				battleRoomPlayer.RTPVPInfo = new RealTimePVPInfo
				{
					Dan = pbPlayer.RealTimePVPInfo.Dan,
					LocalRank = pbPlayer.RealTimePVPInfo.LocalRank,
					GlobalRank = pbPlayer.RealTimePVPInfo.GlobalRank,
					Score = pbPlayer.RealTimePVPInfo.Score,
					UserId = pbPlayer.UserId,
					IsBot = false
				};
			}
			return battleRoomPlayer;
		}

		// Token: 0x04002D01 RID: 11521
		public List<BattleHero> Heroes = new List<BattleHero>();

		// Token: 0x04002D02 RID: 11522
		public List<TrainingTech> Techs = new List<TrainingTech>();
	}
}
