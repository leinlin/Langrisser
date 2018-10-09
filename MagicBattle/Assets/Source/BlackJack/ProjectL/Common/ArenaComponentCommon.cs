using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200042E RID: 1070
	[HotFix]
	public class ArenaComponentCommon : IComponentBase
	{
		// Token: 0x06003DA6 RID: 15782 RVA: 0x00116928 File Offset: 0x00114B28
		public ArenaComponentCommon()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00116990 File Offset: 0x00114B90
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "Arena";
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00116A04 File Offset: 0x00114C04
		public virtual void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDS = new DataSectionArena();
			this.m_arenaBattleReportDS = new DataSectionArenaBattleReport();
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00116A7C File Offset: 0x00114C7C
		public virtual void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushVictoryPointsEvent;
			this.m_basicInfo.PlayerActionFlushEvent += this.OnArenaGiveTicketsEvent;
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x00116B94 File Offset: 0x00114D94
		public virtual void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x00116BF4 File Offset: 0x00114DF4
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsArenaInited())
			{
				return;
			}
			if (this.m_battle.IsAttackingArenaOpponent())
			{
				ArenaOpponentDefensiveBattleInfo arenaDefensiveBattleInfo = this.GetArenaDefensiveBattleInfo();
				if (arenaDefensiveBattleInfo != null && this.m_basicInfo.GetCurrentTime().Ticks >= arenaDefensiveBattleInfo.BattleExpiredTime)
				{
					this.OnBattleTimeOut();
				}
			}
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x00116CB4 File Offset: 0x00114EB4
		protected virtual void OnBattleTimeOut()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleTimeOut_hotfix != null)
			{
				this.m_OnBattleTimeOut_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaOpponentDefensiveBattleInfo arenaDefensiveBattleInfo = this.GetArenaDefensiveBattleInfo();
			this.OnFinishedArenaBattle(arenaDefensiveBattleInfo, false);
			this.ArenaBattleFinish(GameFunctionStatus.FightOutTime);
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x00116D2C File Offset: 0x00114F2C
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x00116DAC File Offset: 0x00114FAC
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00116E1C File Offset: 0x0011501C
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x00116E7C File Offset: 0x0011507C
		// (set) Token: 0x06003DB1 RID: 15793 RVA: 0x00116EF0 File Offset: 0x001150F0
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x00116F68 File Offset: 0x00115168
		protected void OnFinishedArenaBattle(ArenaOpponentDefensiveBattleInfo defensivBattleInfo, bool isWin)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFinishedArenaBattleArenaOpponentDefensiveBattleInfoBoolean_hotfix != null)
			{
				this.m_OnFinishedArenaBattleArenaOpponentDefensiveBattleInfoBoolean_hotfix.call(new object[]
				{
					this,
					defensivBattleInfo,
					isWin
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetThisWeekBattleInfo(isWin);
			if (defensivBattleInfo.Status == ArenaBattleReportStatus.Attack)
			{
				int consecutiveVictoryNums = 0;
				if (isWin)
				{
					consecutiveVictoryNums = this.m_arenaDS.AddConsecutiveVictoryNums();
				}
				else
				{
					this.m_arenaDS.ResetConsecutiveVictoryNums();
				}
				this.ArenaConsecutiveSuccess(consecutiveVictoryNums);
				if (this.ArenaFightEvent != null)
				{
					this.ArenaFightEvent();
				}
			}
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x0011703C File Offset: 0x0011523C
		private void SetThisWeekBattleInfo(bool isWin)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetThisWeekBattleInfoBoolean_hotfix != null)
			{
				this.m_SetThisWeekBattleInfoBoolean_hotfix.call(new object[]
				{
					this,
					isWin
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isWin)
			{
				this.ArenaPlayerInfo.ThisWeekVictoryNums++;
			}
			this.ArenaPlayerInfo.ThisWeekTotalBattleNums++;
			this.m_arenaDS.SetDirty(true);
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x001170E4 File Offset: 0x001152E4
		protected void ResetThisWeekBattleInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetThisWeekBattleInfo_hotfix != null)
			{
				this.m_ResetThisWeekBattleInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaPlayerInfo arenaPlayerInfo = this.ArenaPlayerInfo;
			int num = 0;
			this.ArenaPlayerInfo.ThisWeekTotalBattleNums = num;
			arenaPlayerInfo.ThisWeekVictoryNums = num;
			this.m_arenaDS.SetDirty(true);
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x0011716C File Offset: 0x0011536C
		protected void InitArenaPlayerInfo(ArenaPlayerInfo info)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitArenaPlayerInfoArenaPlayerInfo_hotfix != null)
			{
				this.m_InitArenaPlayerInfoArenaPlayerInfo_hotfix.call(new object[]
				{
					this,
					info
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDS.InitArenaPlayerInfo(info);
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x001171E8 File Offset: 0x001153E8
		protected void AddReceivedVictoryPointsRewardIndex(int victoryPointsIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddReceivedVictoryPointsRewardIndexInt32_hotfix != null)
			{
				this.m_AddReceivedVictoryPointsRewardIndexInt32_hotfix.call(new object[]
				{
					this,
					victoryPointsIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDS.AddReceivedVictoryPointsRewardIndex(victoryPointsIndex);
			int num = this.m_configDataLoader.GetAllConfigDataArenaVictoryPointsRewardInfo().Count<KeyValuePair<int, ConfigDataArenaVictoryPointsRewardInfo>>();
			if (this.m_arenaDS.ArenaPlayerInfo.ReceivedVictoryPointsRewardIndexs.Count != num)
			{
				return;
			}
			this.m_arenaDS.AddVictoryPoints(-this.m_configDataLoader.ConfigableConstId_ArenaVictoryPointsRewardMaxVictionaryPoints);
			this.m_arenaDS.ResetReceivedVictoryPointsRewardedIndexs();
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x001172B4 File Offset: 0x001154B4
		protected void OnFlushVictoryPointsEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushVictoryPointsEvent_hotfix != null)
			{
				this.m_OnFlushVictoryPointsEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsArenaInited())
			{
				return;
			}
			this.m_arenaDS.ResetVictoryPoints();
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x0011732C File Offset: 0x0011552C
		protected void OnArenaGiveTicketsEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnArenaGiveTicketsEvent_hotfix != null)
			{
				this.m_OnArenaGiveTicketsEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsArenaOpen())
			{
				return;
			}
			this.SystemGiveArenaTickets();
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x001173A0 File Offset: 0x001155A0
		private void SystemGiveArenaTickets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SystemGiveArenaTickets_hotfix != null)
			{
				this.m_SystemGiveArenaTickets_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo.AddArenaTickets(this.m_configDataLoader.ConfigableConstId_ArenaOneTimeGiveTicketsNums, true, GameFunctionType.GameFunctionType_SystemGiveArenaTicket, null);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x0011741C File Offset: 0x0011561C
		public ArenaOpponentDefensiveBattleInfo GetArenaDefensiveBattleInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetArenaDefensiveBattleInfo_hotfix != null)
			{
				return (ArenaOpponentDefensiveBattleInfo)this.m_GetArenaDefensiveBattleInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_arenaDS.GetArenaDefensiveBattleInfo();
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00117494 File Offset: 0x00115694
		protected void SetSuccessArenaBattle(int arenaOpponentPointZoneId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessArenaBattleInt32_hotfix != null)
			{
				this.m_SetSuccessArenaBattleInt32_hotfix.call(new object[]
				{
					this,
					arenaOpponentPointZoneId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> team = this.m_battle.GetTeam(BattleType.ArenaAttack);
			this.m_basicInfo.AddPlayerExp(this.m_configDataLoader.ConfigableConstId_ArenaAddPlayerExp);
			this.m_arenaDS.AddVictoryPoints(this.m_configDataLoader.GetConfigDataArenaOpponentPointZoneInfo(arenaOpponentPointZoneId).VictoryPoint);
			this.m_battle.AddFightHeroFightNumsAndExp(team, this.m_configDataLoader.ConfigableConstId_ArenaAddHeroExp);
			if (this.ArenaAttackMissionEvent != null)
			{
				this.ArenaAttackMissionEvent(BattleType.ArenaAttack, 0, team);
			}
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00117574 File Offset: 0x00115774
		public void AddArenaBattleReport(ArenaBattleReport arenaBattleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddArenaBattleReportArenaBattleReport_hotfix != null)
			{
				this.m_AddArenaBattleReportArenaBattleReport_hotfix.call(new object[]
				{
					this,
					arenaBattleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			byte nextBattleReportIndex = this.m_arenaBattleReportDS.NextBattleReportIndex;
			if (this.IsFullBattleReportNums())
			{
				this.m_arenaBattleReportDS.SetArenaBattleReport((int)nextBattleReportIndex, arenaBattleReport);
			}
			else
			{
				this.m_arenaBattleReportDS.AddArenaBattleReport(arenaBattleReport);
			}
			nextBattleReportIndex = ArenaComponentCommon.GetNextBattleReportIndex(nextBattleReportIndex, this.m_configDataLoader.ConfigableConstId_ArenaBattleReportMaxNums);
			this.m_arenaBattleReportDS.SetNextBattleReportIndex(nextBattleReportIndex);
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x00117638 File Offset: 0x00115838
		public void SetArenaLevelIdAndPoints(int arenaLevelId, ushort arenaPoints)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaLevelIdAndPointsInt32UInt16_hotfix != null)
			{
				this.m_SetArenaLevelIdAndPointsInt32UInt16_hotfix.call(new object[]
				{
					this,
					arenaLevelId,
					arenaPoints
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDS.SetArenaLevelId(arenaLevelId);
			this.m_arenaDS.SetArenaPoints(arenaPoints);
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x001176D0 File Offset: 0x001158D0
		public static byte GetNextBattleReportIndex(byte currentNextBattleReportIndex, int arenaBattleReportMaxNums)
		{
			if (currentNextBattleReportIndex == (byte)(arenaBattleReportMaxNums - 1))
			{
				return 0;
			}
			return currentNextBattleReportIndex + 1;
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x001176E4 File Offset: 0x001158E4
		public int CanGetVictoryPointsReward(int victoryPointsRewardIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGetVictoryPointsRewardInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGetVictoryPointsRewardInt32_hotfix.call(new object[]
				{
					this,
					victoryPointsRewardIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsArenaInited())
			{
				return -2004;
			}
			ConfigDataArenaVictoryPointsRewardInfo configDataArenaVictoryPointsRewardInfo = this.m_configDataLoader.GetConfigDataArenaVictoryPointsRewardInfo(victoryPointsRewardIndex);
			if (configDataArenaVictoryPointsRewardInfo == null)
			{
				return -2013;
			}
			if (this.m_arenaDS.HasReceivedVictoryPointsRewardedIndex(victoryPointsRewardIndex))
			{
				return -2012;
			}
			if (this.m_arenaDS.GetCurrentVictoryPoints() < configDataArenaVictoryPointsRewardInfo.VictoryPoints)
			{
				return -2014;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x001177D4 File Offset: 0x001159D4
		private bool IsFullBattleReportNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFullBattleReportNums_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFullBattleReportNums_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_arenaBattleReportDS.BattleReportNums == this.m_configDataLoader.ConfigableConstId_ArenaBattleReportMaxNums;
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x00117858 File Offset: 0x00115A58
		public int CanViewOpponent(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanViewOpponentInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanViewOpponentInt32_hotfix.call(new object[]
				{
					this,
					index
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsArenaInited())
			{
				return -2004;
			}
			if (this.m_arenaDS.FindOpponent(index) == null)
			{
				return -2002;
			}
			if (this.m_battle.IsFighting())
			{
				return -900;
			}
			if (this.IsInSettleCacheTime())
			{
				return -2017;
			}
			return 0;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00117928 File Offset: 0x00115B28
		protected int CanAttackOpponent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackOpponent_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackOpponent_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackOpponentByClient();
			if (num != 0)
			{
				return num;
			}
			if (this.GetArenaDefensiveBattleInfo() == null)
			{
				return -2006;
			}
			if (this.ArenaPlayerInfo.RevengeBattleReportInstanceId != 0UL)
			{
				return -2019;
			}
			return 0;
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x001179D0 File Offset: 0x00115BD0
		public int CanAttackOpponentByClient()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackOpponentByClient_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackOpponentByClient_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsArenaInited())
			{
				return -2004;
			}
			if (!this.m_basicInfo.IsArenaTicketsEnough(this.m_configDataLoader.ConfigableConstId_ArenaOneTimeAttackUseTicketsNums))
			{
				return -2000;
			}
			if (this.m_battle.IsFighting())
			{
				return -900;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			if (this.m_arenaDS.ArenaPlayerInfo.AttackedOpponent)
			{
				return -2003;
			}
			if (this.IsInSettleCacheTime())
			{
				return -2017;
			}
			return 0;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00117AC8 File Offset: 0x00115CC8
		public int CanRevengeOpponent(ulong battleReportInstanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanRevengeOpponentUInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanRevengeOpponentUInt64_hotfix.call(new object[]
				{
					this,
					battleReportInstanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaBattleReport arenaBattleReport = this.m_arenaBattleReportDS.FindArenaBattleReportByInstanceId(battleReportInstanceId);
			if (arenaBattleReport == null)
			{
				return -2007;
			}
			if (arenaBattleReport.Status == ArenaBattleReportStatus.Attack)
			{
				return -2009;
			}
			if (arenaBattleReport.Status == ArenaBattleReportStatus.Revenged || arenaBattleReport.Status == ArenaBattleReportStatus.RevengeDefend)
			{
				return -2010;
			}
			if (!this.m_basicInfo.IsArenaTicketsEnough(this.m_configDataLoader.ConfigableConstId_ArenaOneTimeAttackUseTicketsNums))
			{
				return -2000;
			}
			if (this.m_battle.IsFighting())
			{
				return -900;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			if (this.IsInSettleCacheTime())
			{
				return -2017;
			}
			return 0;
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x00117BEC File Offset: 0x00115DEC
		protected void SetBattleReportRevenged(ArenaBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleReportRevengedArenaBattleReport_hotfix != null)
			{
				this.m_SetBattleReportRevengedArenaBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			battleReport.Status = ArenaBattleReportStatus.Revenged;
			this.m_arenaBattleReportDS.DirtyArenaBattleReport(battleReport.InstanceId);
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x00117C74 File Offset: 0x00115E74
		public int CanFlushOpponents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanFlushOpponents_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanFlushOpponents_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsArenaInited())
			{
				return -2004;
			}
			if (this.m_battle.IsAttackingArenaOpponent())
			{
				return -900;
			}
			if (this.IsInSettleCacheTime())
			{
				return -2017;
			}
			ArenaPlayerInfo arenaPlayerInfo = this.m_arenaDS.ArenaPlayerInfo;
			if (arenaPlayerInfo.AttackedOpponent)
			{
				return 0;
			}
			if (DateTime.Now.Ticks >= arenaPlayerInfo.NextFlushOpponentTime)
			{
				return 0;
			}
			return -2016;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x00117D50 File Offset: 0x00115F50
		public bool IsInSettleCacheTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInSettleCacheTime_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInSettleCacheTime_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return ArenaComponentCommon.IsInSettleTime(this.m_configDataLoader, 0, this.m_basicInfo.GetCurrentTime());
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x00117DD4 File Offset: 0x00115FD4
		protected bool IsInRealWeekSettleTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInRealWeekSettleTime_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInRealWeekSettleTime_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return ArenaComponentCommon.IsInSettleTime(this.m_configDataLoader, this.m_configDataLoader.ConfigableConstId_ArenaRealWeekSettleDeltaTime, this.m_basicInfo.GetCurrentTime());
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x00117E64 File Offset: 0x00116064
		public static bool IsInSettleTime(IConfigDataLoader configDataLoader, int offsetSeconds, DateTime currentTime)
		{
			DayOfWeek dayOfWeek = currentTime.DayOfWeek;
			if (dayOfWeek != DayOfWeek.Sunday)
			{
				return false;
			}
			ConfigDataArenaSettleTimeInfo configDataArenaSettleTimeInfo = configDataLoader.GetConfigDataArenaSettleTimeInfo(1);
			int relativeSecondsInOneDay = TimeCaculate.GetRelativeSecondsInOneDay(currentTime);
			return relativeSecondsInOneDay >= configDataArenaSettleTimeInfo.SettleStartTime + offsetSeconds && relativeSecondsInOneDay < configDataArenaSettleTimeInfo.SettleEndTime;
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x00117EAC File Offset: 0x001160AC
		public static bool CanFlushArenaByWeek(DateTime current, DateTime lastFlushTime, int relativeSeconds)
		{
			return current >= ArenaComponentCommon.CalculateWeekNextFlushTime(lastFlushTime, relativeSeconds);
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x00117EBC File Offset: 0x001160BC
		private static DateTime CalculateWeekNextFlushTime(DateTime lastFlushTime, int relativeSeconds)
		{
			int deltaDays = (int)(-(int)lastFlushTime.DayOfWeek + 7);
			return TimeCaculate.GetNextFlushTimeFromSpecificTime(lastFlushTime, relativeSeconds, deltaDays);
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x00117EE0 File Offset: 0x001160E0
		public bool IsArenaOpen()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsArenaOpen_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsArenaOpen_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ArenaBattle);
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x00117F58 File Offset: 0x00116158
		public bool IsEmptyArenaPlayerInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEmptyArenaPlayerInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEmptyArenaPlayerInfo_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_arenaDS.IsEmptyArenaPlayerInfo();
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x00117FD0 File Offset: 0x001161D0
		public bool IsArenaInited()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsArenaInited_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsArenaInited_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsArenaOpen() && !this.IsEmptyArenaPlayerInfo();
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00118054 File Offset: 0x00116254
		public bool IsVictoryPointsRewardGot(int victoryPointsRewardIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsVictoryPointsRewardGotInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsVictoryPointsRewardGotInt32_hotfix.call(new object[]
				{
					this,
					victoryPointsRewardIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_arenaDS.HasReceivedVictoryPointsRewardedIndex(victoryPointsRewardIndex);
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x001180DC File Offset: 0x001162DC
		public int AttackOpponentFighting()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackOpponentFighting_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackOpponentFighting_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_battle.IsArenaBattleInReady())
			{
				this.ArenaBattleFinish(GameFunctionStatus.Error);
				return -2018;
			}
			this.m_battle.SetArenaBattleFighting();
			return 0;
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00118174 File Offset: 0x00116374
		public void ArenaBattleFinish(GameFunctionStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaBattleFinishGameFunctionStatus_hotfix != null)
			{
				this.m_ArenaBattleFinishGameFunctionStatus_hotfix.call(new object[]
				{
					this,
					status
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ArenaPlayerInfo.OpponentDefensiveBattleInfo = null;
			this.ArenaPlayerInfo.RevengeOpponent = null;
			this.ArenaPlayerInfo.RevengeBattleReportInstanceId = 0UL;
			this.m_battle.FightFinished(status, false, true);
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06003DD2 RID: 15826 RVA: 0x00118218 File Offset: 0x00116418
		protected bool IsFirstFindOpponents
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsFirstFindOpponents_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsFirstFindOpponents_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_arenaDS.IsFirstFindOpponents();
			}
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00118290 File Offset: 0x00116490
		protected void SetUpFirstDefensiveTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUpFirstDefensiveTeam_hotfix != null)
			{
				this.m_SetUpFirstDefensiveTeam_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ArenaPlayerDefensiveTeam arenaPlayerDefensiveTeam = new ArenaPlayerDefensiveTeam();
			arenaPlayerDefensiveTeam.BattleId = (byte)this.m_configDataLoader.GetAllConfigDataArenaBattleInfo().First<KeyValuePair<int, ConfigDataArenaBattleInfo>>().Key;
			arenaPlayerDefensiveTeam.ArenaDefenderRuleId = (byte)this.m_configDataLoader.GetAllConfigDataArenaDefendRuleInfo().First<KeyValuePair<int, ConfigDataArenaDefendRuleInfo>>().Key;
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = this.m_configDataLoader.GetConfigDataArenaBattleInfo((int)arenaPlayerDefensiveTeam.BattleId);
			LinkedList<Hero> linkedList = this.m_hero.FindTopLevelHeroes(configDataArenaBattleInfo.DefendNumber);
			int actionPositionIndex = 0;
			foreach (Hero hero in linkedList)
			{
				ArenaPlayerDefensiveHero arenaPlayerDefensiveHero = ArenaPlayerDefensiveHero.HeroToArenaDefensiveHero(hero);
				arenaPlayerDefensiveHero.ActionPositionIndex = actionPositionIndex;
				arenaPlayerDefensiveHero.ActionValue = actionPositionIndex++ + 1;
				arenaPlayerDefensiveTeam.Heroes.Add(arenaPlayerDefensiveHero);
			}
			this.m_arenaDS.SetDefensiveTeam(arenaPlayerDefensiveTeam);
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x001183E0 File Offset: 0x001165E0
		public void SetMineRank(int rank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMineRankInt32_hotfix != null)
			{
				this.m_SetMineRankInt32_hotfix.call(new object[]
				{
					this,
					rank
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ArenaPlayerInfo.MineRank = rank;
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x0011845C File Offset: 0x0011665C
		public int GetMineRank()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMineRank_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMineRank_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.ArenaPlayerInfo.MineRank;
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06003DD6 RID: 15830 RVA: 0x001184D4 File Offset: 0x001166D4
		public ArenaPlayerInfo ArenaPlayerInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ArenaPlayerInfo_hotfix != null)
				{
					return (ArenaPlayerInfo)this.m_get_ArenaPlayerInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_arenaDS.ArenaPlayerInfo;
			}
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x0011854C File Offset: 0x0011674C
		public List<ArenaBattleReport> GetAllArenaBattleReports()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllArenaBattleReports_hotfix != null)
			{
				return (List<ArenaBattleReport>)this.m_GetAllArenaBattleReports_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_arenaBattleReportDS.GetAllArenaBattleReports();
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x001185C4 File Offset: 0x001167C4
		protected void ArenaConsecutiveSuccess(int consecutiveVictoryNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaConsecutiveSuccessInt32_hotfix != null)
			{
				this.m_ArenaConsecutiveSuccessInt32_hotfix.call(new object[]
				{
					this,
					consecutiveVictoryNums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.ArenaConsecutiveVictoryEvent != null)
			{
				this.ArenaConsecutiveVictoryEvent(consecutiveVictoryNums);
			}
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x0011864C File Offset: 0x0011684C
		public int CanGetArenaTopRankPlayers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGetArenaTopRankPlayers_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGetArenaTopRankPlayers_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsArenaInited())
			{
				return -2004;
			}
			if (this.IsInRealWeekSettleTime())
			{
				return -2017;
			}
			return 0;
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x001186DC File Offset: 0x001168DC
		public int CanGetArenaPlayerInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGetArenaPlayerInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGetArenaPlayerInfo_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsArenaOpen())
			{
				return -2004;
			}
			if (this.IsInRealWeekSettleTime())
			{
				return -2017;
			}
			return 0;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x0011876C File Offset: 0x0011696C
		public int CanReconnectArenaBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanReconnectArenaBattle_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanReconnectArenaBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_battle.IsAttackingArenaOpponent())
			{
				return -2015;
			}
			return 0;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x001187F0 File Offset: 0x001169F0
		public int ReconnectArenaBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReconnectArenaBattle_hotfix != null)
			{
				return Convert.ToInt32(this.m_ReconnectArenaBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanReconnectArenaBattle();
			if (num != 0)
			{
				return num;
			}
			return 0;
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06003DDD RID: 15837 RVA: 0x0011886C File Offset: 0x00116A6C
		// (set) Token: 0x06003DDE RID: 15838 RVA: 0x001188E0 File Offset: 0x00116AE0
		public DataSectionArenaBattleReport m_arenaBattleReportDS
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_m_arenaBattleReportDS_hotfix != null)
				{
					return (DataSectionArenaBattleReport)this.m_get_m_arenaBattleReportDS_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<m_arenaBattleReportDS>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_m_arenaBattleReportDSDataSectionArenaBattleReport_hotfix != null)
				{
					this.m_set_m_arenaBattleReportDSDataSectionArenaBattleReport_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<m_arenaBattleReportDS>k__BackingField = value;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06003DDF RID: 15839 RVA: 0x00118958 File Offset: 0x00116B58
		// (set) Token: 0x06003DE0 RID: 15840 RVA: 0x00118978 File Offset: 0x00116B78
		[DoNotToLua]
		public ArenaComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00118984 File Offset: 0x00116B84
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_OnBattleTimeOut_hotfix = (luaObj.RawGet("OnBattleTimeOut") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_OnFinishedArenaBattleArenaOpponentDefensiveBattleInfoBoolean_hotfix = (luaObj.RawGet("OnFinishedArenaBattle") as LuaFunction);
					this.m_SetThisWeekBattleInfoBoolean_hotfix = (luaObj.RawGet("SetThisWeekBattleInfo") as LuaFunction);
					this.m_ResetThisWeekBattleInfo_hotfix = (luaObj.RawGet("ResetThisWeekBattleInfo") as LuaFunction);
					this.m_InitArenaPlayerInfoArenaPlayerInfo_hotfix = (luaObj.RawGet("InitArenaPlayerInfo") as LuaFunction);
					this.m_AddReceivedVictoryPointsRewardIndexInt32_hotfix = (luaObj.RawGet("AddReceivedVictoryPointsRewardIndex") as LuaFunction);
					this.m_OnFlushVictoryPointsEvent_hotfix = (luaObj.RawGet("OnFlushVictoryPointsEvent") as LuaFunction);
					this.m_OnArenaGiveTicketsEvent_hotfix = (luaObj.RawGet("OnArenaGiveTicketsEvent") as LuaFunction);
					this.m_SystemGiveArenaTickets_hotfix = (luaObj.RawGet("SystemGiveArenaTickets") as LuaFunction);
					this.m_GetArenaDefensiveBattleInfo_hotfix = (luaObj.RawGet("GetArenaDefensiveBattleInfo") as LuaFunction);
					this.m_SetSuccessArenaBattleInt32_hotfix = (luaObj.RawGet("SetSuccessArenaBattle") as LuaFunction);
					this.m_AddArenaBattleReportArenaBattleReport_hotfix = (luaObj.RawGet("AddArenaBattleReport") as LuaFunction);
					this.m_SetArenaLevelIdAndPointsInt32UInt16_hotfix = (luaObj.RawGet("SetArenaLevelIdAndPoints") as LuaFunction);
					this.m_CanGetVictoryPointsRewardInt32_hotfix = (luaObj.RawGet("CanGetVictoryPointsReward") as LuaFunction);
					this.m_IsFullBattleReportNums_hotfix = (luaObj.RawGet("IsFullBattleReportNums") as LuaFunction);
					this.m_CanViewOpponentInt32_hotfix = (luaObj.RawGet("CanViewOpponent") as LuaFunction);
					this.m_CanAttackOpponent_hotfix = (luaObj.RawGet("CanAttackOpponent") as LuaFunction);
					this.m_CanAttackOpponentByClient_hotfix = (luaObj.RawGet("CanAttackOpponentByClient") as LuaFunction);
					this.m_CanRevengeOpponentUInt64_hotfix = (luaObj.RawGet("CanRevengeOpponent") as LuaFunction);
					this.m_SetBattleReportRevengedArenaBattleReport_hotfix = (luaObj.RawGet("SetBattleReportRevenged") as LuaFunction);
					this.m_CanFlushOpponents_hotfix = (luaObj.RawGet("CanFlushOpponents") as LuaFunction);
					this.m_IsInSettleCacheTime_hotfix = (luaObj.RawGet("IsInSettleCacheTime") as LuaFunction);
					this.m_IsInRealWeekSettleTime_hotfix = (luaObj.RawGet("IsInRealWeekSettleTime") as LuaFunction);
					this.m_IsArenaOpen_hotfix = (luaObj.RawGet("IsArenaOpen") as LuaFunction);
					this.m_IsEmptyArenaPlayerInfo_hotfix = (luaObj.RawGet("IsEmptyArenaPlayerInfo") as LuaFunction);
					this.m_IsArenaInited_hotfix = (luaObj.RawGet("IsArenaInited") as LuaFunction);
					this.m_IsVictoryPointsRewardGotInt32_hotfix = (luaObj.RawGet("IsVictoryPointsRewardGot") as LuaFunction);
					this.m_AttackOpponentFighting_hotfix = (luaObj.RawGet("AttackOpponentFighting") as LuaFunction);
					this.m_ArenaBattleFinishGameFunctionStatus_hotfix = (luaObj.RawGet("ArenaBattleFinish") as LuaFunction);
					this.m_get_IsFirstFindOpponents_hotfix = (luaObj.RawGet("get_IsFirstFindOpponents") as LuaFunction);
					this.m_SetUpFirstDefensiveTeam_hotfix = (luaObj.RawGet("SetUpFirstDefensiveTeam") as LuaFunction);
					this.m_SetMineRankInt32_hotfix = (luaObj.RawGet("SetMineRank") as LuaFunction);
					this.m_GetMineRank_hotfix = (luaObj.RawGet("GetMineRank") as LuaFunction);
					this.m_get_ArenaPlayerInfo_hotfix = (luaObj.RawGet("get_ArenaPlayerInfo") as LuaFunction);
					this.m_GetAllArenaBattleReports_hotfix = (luaObj.RawGet("GetAllArenaBattleReports") as LuaFunction);
					this.m_ArenaConsecutiveSuccessInt32_hotfix = (luaObj.RawGet("ArenaConsecutiveSuccess") as LuaFunction);
					this.m_CanGetArenaTopRankPlayers_hotfix = (luaObj.RawGet("CanGetArenaTopRankPlayers") as LuaFunction);
					this.m_CanGetArenaPlayerInfo_hotfix = (luaObj.RawGet("CanGetArenaPlayerInfo") as LuaFunction);
					this.m_CanReconnectArenaBattle_hotfix = (luaObj.RawGet("CanReconnectArenaBattle") as LuaFunction);
					this.m_ReconnectArenaBattle_hotfix = (luaObj.RawGet("ReconnectArenaBattle") as LuaFunction);
					this.m_get_m_arenaBattleReportDS_hotfix = (luaObj.RawGet("get_m_arenaBattleReportDS") as LuaFunction);
					this.m_set_m_arenaBattleReportDSDataSectionArenaBattleReport_hotfix = (luaObj.RawGet("set_m_arenaBattleReportDS") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x00118F64 File Offset: 0x00117164
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002E91 RID: 11921
		protected DataSectionArena m_arenaDS;

		// Token: 0x04002E93 RID: 11923
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04002E94 RID: 11924
		protected BattleComponentCommon m_battle;

		// Token: 0x04002E95 RID: 11925
		protected HeroComponentCommon m_hero;

		// Token: 0x04002E96 RID: 11926
		protected BagComponentCommon m_bag;

		// Token: 0x04002E97 RID: 11927
		protected RiftComponentCommon m_rift;

		// Token: 0x04002E98 RID: 11928
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04002E99 RID: 11929
		public Action<int> ArenaConsecutiveVictoryEvent;

		// Token: 0x04002E9A RID: 11930
		public Action<BattleType, int, List<int>> ArenaAttackMissionEvent;

		// Token: 0x04002E9B RID: 11931
		public Action ArenaFightEvent;

		// Token: 0x04002E9C RID: 11932
		[DoNotToLua]
		private ArenaComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04002E9D RID: 11933
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002E9E RID: 11934
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002E9F RID: 11935
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002EA0 RID: 11936
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04002EA1 RID: 11937
		private LuaFunction m_Init_hotfix;

		// Token: 0x04002EA2 RID: 11938
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04002EA3 RID: 11939
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04002EA4 RID: 11940
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04002EA5 RID: 11941
		private LuaFunction m_OnBattleTimeOut_hotfix;

		// Token: 0x04002EA6 RID: 11942
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04002EA7 RID: 11943
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04002EA8 RID: 11944
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04002EA9 RID: 11945
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04002EAA RID: 11946
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04002EAB RID: 11947
		private LuaFunction m_OnFinishedArenaBattleArenaOpponentDefensiveBattleInfoBoolean_hotfix;

		// Token: 0x04002EAC RID: 11948
		private LuaFunction m_SetThisWeekBattleInfoBoolean_hotfix;

		// Token: 0x04002EAD RID: 11949
		private LuaFunction m_ResetThisWeekBattleInfo_hotfix;

		// Token: 0x04002EAE RID: 11950
		private LuaFunction m_InitArenaPlayerInfoArenaPlayerInfo_hotfix;

		// Token: 0x04002EAF RID: 11951
		private LuaFunction m_AddReceivedVictoryPointsRewardIndexInt32_hotfix;

		// Token: 0x04002EB0 RID: 11952
		private LuaFunction m_OnFlushVictoryPointsEvent_hotfix;

		// Token: 0x04002EB1 RID: 11953
		private LuaFunction m_OnArenaGiveTicketsEvent_hotfix;

		// Token: 0x04002EB2 RID: 11954
		private LuaFunction m_SystemGiveArenaTickets_hotfix;

		// Token: 0x04002EB3 RID: 11955
		private LuaFunction m_GetArenaDefensiveBattleInfo_hotfix;

		// Token: 0x04002EB4 RID: 11956
		private LuaFunction m_SetSuccessArenaBattleInt32_hotfix;

		// Token: 0x04002EB5 RID: 11957
		private LuaFunction m_AddArenaBattleReportArenaBattleReport_hotfix;

		// Token: 0x04002EB6 RID: 11958
		private LuaFunction m_SetArenaLevelIdAndPointsInt32UInt16_hotfix;

		// Token: 0x04002EB7 RID: 11959
		private LuaFunction m_CanGetVictoryPointsRewardInt32_hotfix;

		// Token: 0x04002EB8 RID: 11960
		private LuaFunction m_IsFullBattleReportNums_hotfix;

		// Token: 0x04002EB9 RID: 11961
		private LuaFunction m_CanViewOpponentInt32_hotfix;

		// Token: 0x04002EBA RID: 11962
		private LuaFunction m_CanAttackOpponent_hotfix;

		// Token: 0x04002EBB RID: 11963
		private LuaFunction m_CanAttackOpponentByClient_hotfix;

		// Token: 0x04002EBC RID: 11964
		private LuaFunction m_CanRevengeOpponentUInt64_hotfix;

		// Token: 0x04002EBD RID: 11965
		private LuaFunction m_SetBattleReportRevengedArenaBattleReport_hotfix;

		// Token: 0x04002EBE RID: 11966
		private LuaFunction m_CanFlushOpponents_hotfix;

		// Token: 0x04002EBF RID: 11967
		private LuaFunction m_IsInSettleCacheTime_hotfix;

		// Token: 0x04002EC0 RID: 11968
		private LuaFunction m_IsInRealWeekSettleTime_hotfix;

		// Token: 0x04002EC1 RID: 11969
		private LuaFunction m_IsArenaOpen_hotfix;

		// Token: 0x04002EC2 RID: 11970
		private LuaFunction m_IsEmptyArenaPlayerInfo_hotfix;

		// Token: 0x04002EC3 RID: 11971
		private LuaFunction m_IsArenaInited_hotfix;

		// Token: 0x04002EC4 RID: 11972
		private LuaFunction m_IsVictoryPointsRewardGotInt32_hotfix;

		// Token: 0x04002EC5 RID: 11973
		private LuaFunction m_AttackOpponentFighting_hotfix;

		// Token: 0x04002EC6 RID: 11974
		private LuaFunction m_ArenaBattleFinishGameFunctionStatus_hotfix;

		// Token: 0x04002EC7 RID: 11975
		private LuaFunction m_get_IsFirstFindOpponents_hotfix;

		// Token: 0x04002EC8 RID: 11976
		private LuaFunction m_SetUpFirstDefensiveTeam_hotfix;

		// Token: 0x04002EC9 RID: 11977
		private LuaFunction m_SetMineRankInt32_hotfix;

		// Token: 0x04002ECA RID: 11978
		private LuaFunction m_GetMineRank_hotfix;

		// Token: 0x04002ECB RID: 11979
		private LuaFunction m_get_ArenaPlayerInfo_hotfix;

		// Token: 0x04002ECC RID: 11980
		private LuaFunction m_GetAllArenaBattleReports_hotfix;

		// Token: 0x04002ECD RID: 11981
		private LuaFunction m_ArenaConsecutiveSuccessInt32_hotfix;

		// Token: 0x04002ECE RID: 11982
		private LuaFunction m_CanGetArenaTopRankPlayers_hotfix;

		// Token: 0x04002ECF RID: 11983
		private LuaFunction m_CanGetArenaPlayerInfo_hotfix;

		// Token: 0x04002ED0 RID: 11984
		private LuaFunction m_CanReconnectArenaBattle_hotfix;

		// Token: 0x04002ED1 RID: 11985
		private LuaFunction m_ReconnectArenaBattle_hotfix;

		// Token: 0x04002ED2 RID: 11986
		private LuaFunction m_get_m_arenaBattleReportDS_hotfix;

		// Token: 0x04002ED3 RID: 11987
		private LuaFunction m_set_m_arenaBattleReportDSDataSectionArenaBattleReport_hotfix;

		// Token: 0x0200042F RID: 1071
		public class LuaExportHelper
		{
			// Token: 0x06003DE3 RID: 15843 RVA: 0x00118FCC File Offset: 0x001171CC
			public LuaExportHelper(ArenaComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170010CD RID: 4301
			// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x00118FDC File Offset: 0x001171DC
			// (set) Token: 0x06003DE5 RID: 15845 RVA: 0x00118FEC File Offset: 0x001171EC
			public DataSectionArena m_arenaDS
			{
				get
				{
					return this.m_owner.m_arenaDS;
				}
				set
				{
					this.m_owner.m_arenaDS = value;
				}
			}

			// Token: 0x170010CE RID: 4302
			// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x00118FFC File Offset: 0x001171FC
			// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x0011900C File Offset: 0x0011720C
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x170010CF RID: 4303
			// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x0011901C File Offset: 0x0011721C
			// (set) Token: 0x06003DE9 RID: 15849 RVA: 0x0011902C File Offset: 0x0011722C
			public BattleComponentCommon m_battle
			{
				get
				{
					return this.m_owner.m_battle;
				}
				set
				{
					this.m_owner.m_battle = value;
				}
			}

			// Token: 0x170010D0 RID: 4304
			// (get) Token: 0x06003DEA RID: 15850 RVA: 0x0011903C File Offset: 0x0011723C
			// (set) Token: 0x06003DEB RID: 15851 RVA: 0x0011904C File Offset: 0x0011724C
			public HeroComponentCommon m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x170010D1 RID: 4305
			// (get) Token: 0x06003DEC RID: 15852 RVA: 0x0011905C File Offset: 0x0011725C
			// (set) Token: 0x06003DED RID: 15853 RVA: 0x0011906C File Offset: 0x0011726C
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x170010D2 RID: 4306
			// (get) Token: 0x06003DEE RID: 15854 RVA: 0x0011907C File Offset: 0x0011727C
			// (set) Token: 0x06003DEF RID: 15855 RVA: 0x0011908C File Offset: 0x0011728C
			public RiftComponentCommon m_rift
			{
				get
				{
					return this.m_owner.m_rift;
				}
				set
				{
					this.m_owner.m_rift = value;
				}
			}

			// Token: 0x170010D3 RID: 4307
			// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x0011909C File Offset: 0x0011729C
			// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x001190AC File Offset: 0x001172AC
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x170010D4 RID: 4308
			// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x001190BC File Offset: 0x001172BC
			public bool IsFirstFindOpponents
			{
				get
				{
					return this.m_owner.IsFirstFindOpponents;
				}
			}

			// Token: 0x170010D5 RID: 4309
			// (set) Token: 0x06003DF3 RID: 15859 RVA: 0x001190CC File Offset: 0x001172CC
			public DataSectionArenaBattleReport m_arenaBattleReportDS
			{
				set
				{
					this.m_owner.m_arenaBattleReportDS = value;
				}
			}

			// Token: 0x06003DF4 RID: 15860 RVA: 0x001190DC File Offset: 0x001172DC
			public void OnBattleTimeOut()
			{
				this.m_owner.OnBattleTimeOut();
			}

			// Token: 0x06003DF5 RID: 15861 RVA: 0x001190EC File Offset: 0x001172EC
			public void OnFinishedArenaBattle(ArenaOpponentDefensiveBattleInfo defensivBattleInfo, bool isWin)
			{
				this.m_owner.OnFinishedArenaBattle(defensivBattleInfo, isWin);
			}

			// Token: 0x06003DF6 RID: 15862 RVA: 0x001190FC File Offset: 0x001172FC
			public void SetThisWeekBattleInfo(bool isWin)
			{
				this.m_owner.SetThisWeekBattleInfo(isWin);
			}

			// Token: 0x06003DF7 RID: 15863 RVA: 0x0011910C File Offset: 0x0011730C
			public void ResetThisWeekBattleInfo()
			{
				this.m_owner.ResetThisWeekBattleInfo();
			}

			// Token: 0x06003DF8 RID: 15864 RVA: 0x0011911C File Offset: 0x0011731C
			public void InitArenaPlayerInfo(ArenaPlayerInfo info)
			{
				this.m_owner.InitArenaPlayerInfo(info);
			}

			// Token: 0x06003DF9 RID: 15865 RVA: 0x0011912C File Offset: 0x0011732C
			public void AddReceivedVictoryPointsRewardIndex(int victoryPointsIndex)
			{
				this.m_owner.AddReceivedVictoryPointsRewardIndex(victoryPointsIndex);
			}

			// Token: 0x06003DFA RID: 15866 RVA: 0x0011913C File Offset: 0x0011733C
			public void OnFlushVictoryPointsEvent()
			{
				this.m_owner.OnFlushVictoryPointsEvent();
			}

			// Token: 0x06003DFB RID: 15867 RVA: 0x0011914C File Offset: 0x0011734C
			public void OnArenaGiveTicketsEvent()
			{
				this.m_owner.OnArenaGiveTicketsEvent();
			}

			// Token: 0x06003DFC RID: 15868 RVA: 0x0011915C File Offset: 0x0011735C
			public void SystemGiveArenaTickets()
			{
				this.m_owner.SystemGiveArenaTickets();
			}

			// Token: 0x06003DFD RID: 15869 RVA: 0x0011916C File Offset: 0x0011736C
			public void SetSuccessArenaBattle(int arenaOpponentPointZoneId)
			{
				this.m_owner.SetSuccessArenaBattle(arenaOpponentPointZoneId);
			}

			// Token: 0x06003DFE RID: 15870 RVA: 0x0011917C File Offset: 0x0011737C
			public bool IsFullBattleReportNums()
			{
				return this.m_owner.IsFullBattleReportNums();
			}

			// Token: 0x06003DFF RID: 15871 RVA: 0x0011918C File Offset: 0x0011738C
			public int CanAttackOpponent()
			{
				return this.m_owner.CanAttackOpponent();
			}

			// Token: 0x06003E00 RID: 15872 RVA: 0x0011919C File Offset: 0x0011739C
			public void SetBattleReportRevenged(ArenaBattleReport battleReport)
			{
				this.m_owner.SetBattleReportRevenged(battleReport);
			}

			// Token: 0x06003E01 RID: 15873 RVA: 0x001191AC File Offset: 0x001173AC
			public bool IsInRealWeekSettleTime()
			{
				return this.m_owner.IsInRealWeekSettleTime();
			}

			// Token: 0x06003E02 RID: 15874 RVA: 0x001191BC File Offset: 0x001173BC
			public static DateTime CalculateWeekNextFlushTime(DateTime lastFlushTime, int relativeSeconds)
			{
				return ArenaComponentCommon.CalculateWeekNextFlushTime(lastFlushTime, relativeSeconds);
			}

			// Token: 0x06003E03 RID: 15875 RVA: 0x001191C8 File Offset: 0x001173C8
			public void SetUpFirstDefensiveTeam()
			{
				this.m_owner.SetUpFirstDefensiveTeam();
			}

			// Token: 0x06003E04 RID: 15876 RVA: 0x001191D8 File Offset: 0x001173D8
			public void ArenaConsecutiveSuccess(int consecutiveVictoryNums)
			{
				this.m_owner.ArenaConsecutiveSuccess(consecutiveVictoryNums);
			}

			// Token: 0x04002ED4 RID: 11988
			private ArenaComponentCommon m_owner;
		}
	}
}
