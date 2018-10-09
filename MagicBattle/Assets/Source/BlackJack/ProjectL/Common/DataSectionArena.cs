using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004BE RID: 1214
	[CustomLuaClass]
	public class DataSectionArena : DataSection
	{
		// Token: 0x06004A32 RID: 18994 RVA: 0x00173ACC File Offset: 0x00171CCC
		public DataSectionArena()
		{
			this.ArenaPlayerInfo = null;
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x00173ADC File Offset: 0x00171CDC
		public void InitArenaPlayerInfo(ArenaPlayerInfo info)
		{
			this.ArenaPlayerInfo = info;
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x00173AE8 File Offset: 0x00171CE8
		public override void ClearInitedData()
		{
			this.ArenaPlayerInfo = null;
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00173AF4 File Offset: 0x00171CF4
		public override object SerializeToClient()
		{
			return new DSArenaNtf
			{
				Version = (uint)base.Version,
				ArenaPlayerData = ArenaPlayerInfo.ArenaPlayerInfoToPBArenaPlayerInfo(this.ArenaPlayerInfo)
			};
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00173B28 File Offset: 0x00171D28
		public bool IsEmptyArenaPlayerInfo()
		{
			return this.ArenaPlayerInfo == null;
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00173B34 File Offset: 0x00171D34
		public void SetDefensiveTeam(ArenaPlayerDefensiveTeam team)
		{
			this.ArenaPlayerInfo.DefensiveTeam = team;
			base.SetDirty(true);
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x00173B4C File Offset: 0x00171D4C
		public void SetWeekLastFlushTime(DateTime weekLastFlushTime)
		{
			this.ArenaPlayerInfo.WeekLastFlushTime = weekLastFlushTime;
			base.SetDirty(true);
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x00173B64 File Offset: 0x00171D64
		public void SetThisWeekBattleIds(List<int> battleIds)
		{
			this.ArenaPlayerInfo.ThisWeekBattleIds = battleIds;
			base.SetDirty(true);
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x00173B7C File Offset: 0x00171D7C
		public void SetDefensiveBattleId(byte battleId)
		{
			this.ArenaPlayerInfo.DefensiveTeam.BattleId = battleId;
			base.SetDirty(true);
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x00173B98 File Offset: 0x00171D98
		public void SetDefensiveRuleId(byte ruleId)
		{
			this.ArenaPlayerInfo.DefensiveTeam.ArenaDefenderRuleId = ruleId;
			base.SetDirty(true);
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x00173BB4 File Offset: 0x00171DB4
		public void AddVictoryPoints(int points)
		{
			this.ArenaPlayerInfo.VictoryPoints += points;
			base.SetDirty(true);
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x00173BD0 File Offset: 0x00171DD0
		public int GetCurrentVictoryPoints()
		{
			return this.ArenaPlayerInfo.VictoryPoints;
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x00173BE0 File Offset: 0x00171DE0
		public void ResetVictoryPoints()
		{
			this.ArenaPlayerInfo.VictoryPoints = 0;
			this.ArenaPlayerInfo.ReceivedVictoryPointsRewardIndexs.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x00173C08 File Offset: 0x00171E08
		public void ResetReceivedVictoryPointsRewardedIndexs()
		{
			this.ArenaPlayerInfo.ReceivedVictoryPointsRewardIndexs.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x00173C24 File Offset: 0x00171E24
		public bool HasReceivedVictoryPointsRewardedIndex(int index)
		{
			return this.ArenaPlayerInfo.ReceivedVictoryPointsRewardIndexs.Contains(index);
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x00173C38 File Offset: 0x00171E38
		public void AddReceivedVictoryPointsRewardIndex(int victoryPointsIndex)
		{
			this.ArenaPlayerInfo.ReceivedVictoryPointsRewardIndexs.Add(victoryPointsIndex);
			base.SetDirty(true);
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x00173C54 File Offset: 0x00171E54
		public ArenaOpponent FindOpponent(int index)
		{
			List<ArenaOpponent> opponents = this.ArenaPlayerInfo.Opponents;
			if (index < 0 || index >= opponents.Count)
			{
				return null;
			}
			return this.ArenaPlayerInfo.Opponents[index];
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x00173C94 File Offset: 0x00171E94
		public void SetAttackedOpponent(bool autoBattle)
		{
			this.ArenaPlayerInfo.AttackedOpponent = true;
			this.ArenaPlayerInfo.IsAutoBattle = autoBattle;
			base.SetDirty(true);
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x00173CB8 File Offset: 0x00171EB8
		public void SetOpponents(List<ArenaOpponent> opponents)
		{
			this.ArenaPlayerInfo.Opponents = opponents;
			this.ArenaPlayerInfo.AttackedOpponent = false;
			base.SetDirty(true);
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x00173CDC File Offset: 0x00171EDC
		public void SetArenaDefensiveBattleInfo(ArenaOpponentDefensiveBattleInfo info)
		{
			this.ArenaPlayerInfo.OpponentDefensiveBattleInfo = info;
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x00173CEC File Offset: 0x00171EEC
		public ArenaOpponentDefensiveBattleInfo GetArenaDefensiveBattleInfo()
		{
			return this.ArenaPlayerInfo.OpponentDefensiveBattleInfo;
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x00173CFC File Offset: 0x00171EFC
		public string GetOpponentUserId()
		{
			if (this.ArenaPlayerInfo == null || this.ArenaPlayerInfo.OpponentDefensiveBattleInfo == null)
			{
				return null;
			}
			return this.ArenaPlayerInfo.OpponentDefensiveBattleInfo.OpponentUserId;
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x00173D2C File Offset: 0x00171F2C
		public void SetArenaLevelId(int arenaLevelId)
		{
			this.ArenaPlayerInfo.ArenaLevelId = arenaLevelId;
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x00173D3C File Offset: 0x00171F3C
		public void SetArenaPoints(ushort ArenaPoints)
		{
			this.ArenaPlayerInfo.ArenaPoints = ArenaPoints;
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x00173D4C File Offset: 0x00171F4C
		public void SetArenaPlayerInfo(ArenaPlayerInfo info)
		{
			this.ArenaPlayerInfo = info;
			base.SetDirty(true);
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x00173D5C File Offset: 0x00171F5C
		public bool IsFirstFindOpponents()
		{
			return this.ArenaPlayerInfo.Opponents.Count == 0;
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x00173D74 File Offset: 0x00171F74
		public void ResetConsecutiveVictoryNums()
		{
			this.ArenaPlayerInfo.ConsecutiveVictoryNums = 0;
			base.SetDirty(true);
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x00173D8C File Offset: 0x00171F8C
		public int AddConsecutiveVictoryNums()
		{
			this.ArenaPlayerInfo.ConsecutiveVictoryNums++;
			base.SetDirty(true);
			return this.ArenaPlayerInfo.ConsecutiveVictoryNums;
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x00173DB4 File Offset: 0x00171FB4
		// (set) Token: 0x06004A4F RID: 19023 RVA: 0x00173DBC File Offset: 0x00171FBC
		public ArenaPlayerInfo ArenaPlayerInfo { get; private set; }
	}
}
