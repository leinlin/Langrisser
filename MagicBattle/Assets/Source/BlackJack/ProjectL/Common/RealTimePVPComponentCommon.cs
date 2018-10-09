using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200049D RID: 1181
	[HotFix]
	public class RealTimePVPComponentCommon : IComponentBase
	{
		// Token: 0x0600477C RID: 18300 RVA: 0x00160A44 File Offset: 0x0015EC44
		public RealTimePVPComponentCommon()
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

		// Token: 0x0600477D RID: 18301 RVA: 0x00160AB8 File Offset: 0x0015ECB8
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
			return "RealTimePVP";
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x00160B2C File Offset: 0x0015ED2C
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
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x00160B8C File Offset: 0x0015ED8C
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
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushRealTimePVP;
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x00160C54 File Offset: 0x0015EE54
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

		// Token: 0x06004781 RID: 18305 RVA: 0x00160CB4 File Offset: 0x0015EEB4
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
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x00160D24 File Offset: 0x0015EF24
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

		// Token: 0x06004783 RID: 18307 RVA: 0x00160DA4 File Offset: 0x0015EFA4
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

		// Token: 0x06004784 RID: 18308 RVA: 0x00160E14 File Offset: 0x0015F014
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

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x06004785 RID: 18309 RVA: 0x00160E74 File Offset: 0x0015F074
		// (set) Token: 0x06004786 RID: 18310 RVA: 0x00160EE8 File Offset: 0x0015F0E8
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

		// Token: 0x06004787 RID: 18311 RVA: 0x00160F60 File Offset: 0x0015F160
		public void RealTimeArenaDanUpdate(int dan)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RealTimeArenaDanUpdateInt32_hotfix != null)
			{
				this.m_RealTimeArenaDanUpdateInt32_hotfix.call(new object[]
				{
					this,
					dan
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.RealTimeArenaDanUpdateMissionEvent != null)
			{
				this.RealTimeArenaDanUpdateMissionEvent(dan);
			}
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x00160FE8 File Offset: 0x0015F1E8
		public void RealTimeArenaBattleFinish(BattleMode mode, bool win)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RealTimeArenaBattleFinishBattleModeBoolean_hotfix != null)
			{
				this.m_RealTimeArenaBattleFinishBattleModeBoolean_hotfix.call(new object[]
				{
					this,
					mode,
					win
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.RealTimeArenaBattleFinishMissionEvent != null)
			{
				this.RealTimeArenaBattleFinishMissionEvent(mode, win);
			}
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x00161080 File Offset: 0x0015F280
		public void RealTimeArenaBattleStart(BattleMode mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RealTimeArenaBattleStartBattleMode_hotfix != null)
			{
				this.m_RealTimeArenaBattleStartBattleMode_hotfix.call(new object[]
				{
					this,
					mode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.RealTimeArenaBattleStartMissionEvent != null)
			{
				this.RealTimeArenaBattleStartMissionEvent(mode);
			}
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x00161108 File Offset: 0x0015F308
		public int IsRealTimePVPUnlocked()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRealTimePVPUnlocked_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsRealTimePVPUnlocked_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_RealTimePVP))
			{
				return -4705;
			}
			return 0;
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00161190 File Offset: 0x0015F390
		public int IsRealTimePVPArenaAvailable(BattleMode Mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRealTimePVPArenaAvailableBattleMode_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsRealTimePVPArenaAvailableBattleMode_hotfix.call(new object[]
				{
					this,
					Mode
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.IsRealTimePVPUnlocked();
			if (num != 0)
			{
				return num;
			}
			if (Mode == BattleMode.Friendly)
			{
				return 0;
			}
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			DateTime date = currentTime.Date;
			TimeSpan TS = currentTime - date;
			bool flag = Array.Exists<RealTimePVPAvailableTime>(this.m_configDataLoader.RealTimePVPAvailableTime, (RealTimePVPAvailableTime t) => t.Start < TS && TS < t.End);
			return (!flag) ? -4706 : 0;
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x0016127C File Offset: 0x0015F47C
		protected void OnFlushRealTimePVP()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushRealTimePVP_hotfix != null)
			{
				this.m_OnFlushRealTimePVP_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_RealTimePVP))
			{
				return;
			}
			DateTime nextFlushPlayerActionTime = this.m_basicInfo.GetNextFlushPlayerActionTime();
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			if (nextFlushPlayerActionTime.DayOfWeek != DayOfWeek.Monday && currentTime.StartOfWeek(DayOfWeek.Monday) < nextFlushPlayerActionTime)
			{
				return;
			}
			this.StartNewSeason();
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x00161330 File Offset: 0x0015F530
		protected virtual void StartNewSeason()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartNewSeason_hotfix != null)
			{
				this.m_StartNewSeason_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_realTimePVP.StartNewSeason();
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x0016139C File Offset: 0x0015F59C
		public bool IsPromotion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPromotion_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPromotion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_realTimePVP.IsPromotion;
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x00161414 File Offset: 0x0015F614
		public LinkedList<RealTimePVPBattleReport> GetPromotionBattleReports()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPromotionBattleReports_hotfix != null)
			{
				return (LinkedList<RealTimePVPBattleReport>)this.m_GetPromotionBattleReports_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_realTimePVP.PromotionReports;
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x0016148C File Offset: 0x0015F68C
		public LinkedList<RealTimePVPBattleReport> GetBattleReports()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleReports_hotfix != null)
			{
				return (LinkedList<RealTimePVPBattleReport>)this.m_GetBattleReports_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_realTimePVP.Reports;
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x00161504 File Offset: 0x0015F704
		public void StartPromotion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartPromotion_hotfix != null)
			{
				this.m_StartPromotion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_realTimePVP.IsPromotion = true;
			this.m_realTimePVP.StartPromotion();
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x0016157C File Offset: 0x0015F77C
		public void EndPromotion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EndPromotion_hotfix != null)
			{
				this.m_EndPromotion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_realTimePVP.IsPromotion = false;
			this.m_realTimePVP.EndPromotion();
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x001615F4 File Offset: 0x0015F7F4
		public void SavePromotionReport(RealTimePVPBattleReport Report)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SavePromotionReportRealTimePVPBattleReport_hotfix != null)
			{
				this.m_SavePromotionReportRealTimePVPBattleReport_hotfix.call(new object[]
				{
					this,
					Report
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_realTimePVP.SavePromotionReport(Report);
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x00161670 File Offset: 0x0015F870
		public void SaveReport(RealTimePVPBattleReport Report)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SaveReportRealTimePVPBattleReport_hotfix != null)
			{
				this.m_SaveReportRealTimePVPBattleReport_hotfix.call(new object[]
				{
					this,
					Report
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_realTimePVP.SaveReport(Report);
			while (this.m_realTimePVP.Reports.Count > this.m_configDataLoader.ConfigableConstId_RealTimePVPBattleReportMaxNums)
			{
				this.m_realTimePVP.Reports.RemoveLast();
			}
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x00161724 File Offset: 0x0015F924
		public int CheckAcquireWinsBonus(int BonusId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckAcquireWinsBonusInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckAcquireWinsBonusInt32_hotfix.call(new object[]
				{
					this,
					BonusId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int BonusId = BonusId2;
			ConfigDataRealTimePVPWinsBonusInfo configDataRealTimePVPWinsBonusInfo = this.m_configDataLoader.GetConfigDataRealTimePVPWinsBonusInfo(BonusId);
			if (configDataRealTimePVPWinsBonusInfo == null)
			{
				return -4702;
			}
			if (this.m_realTimePVP.LadderMatchStats.Wins + this.m_realTimePVP.FriendlyMatchStats.Wins < configDataRealTimePVPWinsBonusInfo.Wins)
			{
				return -4704;
			}
			if (this.m_realTimePVP.WinsBonusIdAcquired.Exists((int id) => id == BonusId))
			{
				return -4703;
			}
			return 0;
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x00161828 File Offset: 0x0015FA28
		public virtual int AcquireWinsBonus(int BonusId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AcquireWinsBonusInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AcquireWinsBonusInt32_hotfix.call(new object[]
				{
					this,
					BonusId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_realTimePVP.AcquireWinsBonus(BonusId);
			return 0;
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x001618B4 File Offset: 0x0015FAB4
		public int GetConsecutiveWins(BattleMode Mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetConsecutiveWinsBattleMode_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetConsecutiveWinsBattleMode_hotfix.call(new object[]
				{
					this,
					Mode
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Mode == BattleMode.Friendly)
			{
				return this.m_realTimePVP.FriendlyCareerMatchStats.ConsecutiveWins;
			}
			if (Mode != BattleMode.Default)
			{
				return 0;
			}
			return this.m_realTimePVP.LadderMatchStats.ConsecutiveWins;
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x00161968 File Offset: 0x0015FB68
		public int GetConsecutiveLosses(BattleMode Mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetConsecutiveLossesBattleMode_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetConsecutiveLossesBattleMode_hotfix.call(new object[]
				{
					this,
					Mode
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Mode == BattleMode.Friendly)
			{
				return this.m_realTimePVP.FriendlyCareerMatchStats.ConsecutiveLosses;
			}
			if (Mode != BattleMode.Default)
			{
				return 0;
			}
			return this.m_realTimePVP.LadderMatchStats.ConsecutiveLosses;
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x00161A1C File Offset: 0x0015FC1C
		public RealTimePVPMatchStats GetLadderCareerMatchStats()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLadderCareerMatchStats_hotfix != null)
			{
				return (RealTimePVPMatchStats)this.m_GetLadderCareerMatchStats_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_realTimePVP.LadderCareerMatchStats;
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x00161A94 File Offset: 0x0015FC94
		public bool TryGetBotParamsForNovice(BattleMode Mode, int MyScore, out int LevelMin, out int LevelMax, out int ScoreMin, out int ScoreMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TryGetBotParamsForNoviceBattleModeInt32Int32_Int32_Int32_Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon_TryGetBotParamsForNovice_BattleMode_Int32_Int32_Int32_Int32_Int32(this, this.m_TryGetBotParamsForNoviceBattleModeInt32Int32_Int32_Int32_Int32__hotfix, Mode, MyScore, out LevelMin, out LevelMax, out ScoreMin, out ScoreMax);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LevelMin = int.MaxValue;
			LevelMax = int.MinValue;
			ScoreMin = int.MaxValue;
			ScoreMax = int.MinValue;
			if (Mode == BattleMode.Friendly)
			{
				return false;
			}
			int level = this.m_basicInfo.GetLevel();
			RealTimePVPMatchStats ladderCareerMatchStats = this.GetLadderCareerMatchStats();
			if (ladderCareerMatchStats.Matches <= this.m_configDataLoader.RealTimeArenaNewPlayerMatchCount)
			{
				IEnumerable<KeyValuePair<int, ConfigDataRealTimePVPNoviceMatchmakingInfo>> allConfigDataRealTimePVPNoviceMatchmakingInfo = this.m_configDataLoader.GetAllConfigDataRealTimePVPNoviceMatchmakingInfo();
				foreach (KeyValuePair<int, ConfigDataRealTimePVPNoviceMatchmakingInfo> keyValuePair in allConfigDataRealTimePVPNoviceMatchmakingInfo)
				{
					if (ladderCareerMatchStats.Matches == keyValuePair.Value.Battles)
					{
						LevelMin = Math.Min(level, level + keyValuePair.Value.LevelAdjustment);
						LevelMax = Math.Max(level, level + keyValuePair.Value.LevelAdjustment) + 1;
						ScoreMin = (int)((double)MyScore * 0.9);
						ScoreMax = (int)((double)MyScore * 1.1);
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x00161C0C File Offset: 0x0015FE0C
		public bool TryGetBotParamsForLoser(BattleMode Mode, int MyScore, int Dan, out int LevelMin, out int LevelMax, out int ScoreMin, out int ScoreMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TryGetBotParamsForLoserBattleModeInt32Int32Int32_Int32_Int32_Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon_TryGetBotParamsForLoser_BattleMode_Int32_Int32_Int32_Int32_Int32_Int32(this, this.m_TryGetBotParamsForLoserBattleModeInt32Int32Int32_Int32_Int32_Int32__hotfix, Mode, MyScore, Dan, out LevelMin, out LevelMax, out ScoreMin, out ScoreMax);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LevelMin = int.MaxValue;
			LevelMax = int.MinValue;
			ScoreMin = int.MaxValue;
			ScoreMax = int.MinValue;
			if (Mode == BattleMode.Friendly)
			{
				return false;
			}
			int ConsecutiveLosses = this.GetConsecutiveLosses(Mode);
			if (ConsecutiveLosses == 0)
			{
				return false;
			}
			ConfigDataRealTimePVPDanInfo configDataRealTimePVPDanInfo = this.m_configDataLoader.GetConfigDataRealTimePVPDanInfo(Dan);
			RealTimePVPConsecutiveLossesMatchmakingInfo realTimePVPConsecutiveLossesMatchmakingInfo = configDataRealTimePVPDanInfo.ConsecutiveLossesMatchmakingAdjustment.FindLast((RealTimePVPConsecutiveLossesMatchmakingInfo a) => ConsecutiveLosses >= a.Count && a.IsBot);
			if (realTimePVPConsecutiveLossesMatchmakingInfo == null)
			{
				return false;
			}
			int level = this.m_basicInfo.GetLevel();
			LevelMin = Math.Min(level, level + realTimePVPConsecutiveLossesMatchmakingInfo.BotLevelAdjustment);
			LevelMax = Math.Max(level, level + realTimePVPConsecutiveLossesMatchmakingInfo.BotLevelAdjustment) + 1;
			IEnumerable<KeyValuePair<int, ConfigDataRealTimePVPDanInfo>> allConfigDataRealTimePVPDanInfo = this.m_configDataLoader.GetAllConfigDataRealTimePVPDanInfo();
			foreach (KeyValuePair<int, ConfigDataRealTimePVPDanInfo> keyValuePair in allConfigDataRealTimePVPDanInfo)
			{
				if (keyValuePair.Value.ID == realTimePVPConsecutiveLossesMatchmakingInfo.DanMin)
				{
					ScoreMin = keyValuePair.Value.RelegationScore;
				}
				if (keyValuePair.Value.ID == realTimePVPConsecutiveLossesMatchmakingInfo.DanMax)
				{
					ScoreMax = keyValuePair.Value.PromotionScore;
				}
			}
			return true;
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x00161DB8 File Offset: 0x0015FFB8
		// (set) Token: 0x0600479D RID: 18333 RVA: 0x00161E2C File Offset: 0x0016002C
		protected IConfigDataLoader m_configDataLoader
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_m_configDataLoader_hotfix != null)
				{
					return (IConfigDataLoader)this.m_get_m_configDataLoader_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this._configDataLoader;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_m_configDataLoaderIConfigDataLoader_hotfix != null)
				{
					this.m_set_m_configDataLoaderIConfigDataLoader_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this._configDataLoader = value;
			}
		}

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x0600479E RID: 18334 RVA: 0x00161EA4 File Offset: 0x001600A4
		// (remove) Token: 0x0600479F RID: 18335 RVA: 0x00161F40 File Offset: 0x00160140
		public event Action<BattleMode> RealTimeArenaBattleStartMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_RealTimeArenaBattleStartMissionEventAction`1_hotfix != null)
				{
					this.m_add_RealTimeArenaBattleStartMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleMode> action = this.RealTimeArenaBattleStartMissionEvent;
				Action<BattleMode> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleMode>>(ref this.RealTimeArenaBattleStartMissionEvent, (Action<BattleMode>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_RealTimeArenaBattleStartMissionEventAction`1_hotfix != null)
				{
					this.m_remove_RealTimeArenaBattleStartMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleMode> action = this.RealTimeArenaBattleStartMissionEvent;
				Action<BattleMode> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleMode>>(ref this.RealTimeArenaBattleStartMissionEvent, (Action<BattleMode>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x060047A0 RID: 18336 RVA: 0x00161FDC File Offset: 0x001601DC
		// (remove) Token: 0x060047A1 RID: 18337 RVA: 0x00162078 File Offset: 0x00160278
		public event Action<BattleMode, bool> RealTimeArenaBattleFinishMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_RealTimeArenaBattleFinishMissionEventAction`2_hotfix != null)
				{
					this.m_add_RealTimeArenaBattleFinishMissionEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleMode, bool> action = this.RealTimeArenaBattleFinishMissionEvent;
				Action<BattleMode, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleMode, bool>>(ref this.RealTimeArenaBattleFinishMissionEvent, (Action<BattleMode, bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_RealTimeArenaBattleFinishMissionEventAction`2_hotfix != null)
				{
					this.m_remove_RealTimeArenaBattleFinishMissionEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleMode, bool> action = this.RealTimeArenaBattleFinishMissionEvent;
				Action<BattleMode, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleMode, bool>>(ref this.RealTimeArenaBattleFinishMissionEvent, (Action<BattleMode, bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x060047A2 RID: 18338 RVA: 0x00162114 File Offset: 0x00160314
		// (remove) Token: 0x060047A3 RID: 18339 RVA: 0x001621B0 File Offset: 0x001603B0
		public event Action<int> RealTimeArenaDanUpdateMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_RealTimeArenaDanUpdateMissionEventAction`1_hotfix != null)
				{
					this.m_add_RealTimeArenaDanUpdateMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.RealTimeArenaDanUpdateMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.RealTimeArenaDanUpdateMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_RealTimeArenaDanUpdateMissionEventAction`1_hotfix != null)
				{
					this.m_remove_RealTimeArenaDanUpdateMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.RealTimeArenaDanUpdateMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.RealTimeArenaDanUpdateMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060047A4 RID: 18340 RVA: 0x0016224C File Offset: 0x0016044C
		// (set) Token: 0x060047A5 RID: 18341 RVA: 0x0016226C File Offset: 0x0016046C
		[DoNotToLua]
		public RealTimePVPComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RealTimePVPComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x00162278 File Offset: 0x00160478
		private void __callDele_RealTimeArenaBattleStartMissionEvent(BattleMode obj)
		{
			Action<BattleMode> realTimeArenaBattleStartMissionEvent = this.RealTimeArenaBattleStartMissionEvent;
			if (realTimeArenaBattleStartMissionEvent != null)
			{
				realTimeArenaBattleStartMissionEvent(obj);
			}
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x0016229C File Offset: 0x0016049C
		private void __clearDele_RealTimeArenaBattleStartMissionEvent(BattleMode obj)
		{
			this.RealTimeArenaBattleStartMissionEvent = null;
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x001622A8 File Offset: 0x001604A8
		private void __callDele_RealTimeArenaBattleFinishMissionEvent(BattleMode arg1, bool arg2)
		{
			Action<BattleMode, bool> realTimeArenaBattleFinishMissionEvent = this.RealTimeArenaBattleFinishMissionEvent;
			if (realTimeArenaBattleFinishMissionEvent != null)
			{
				realTimeArenaBattleFinishMissionEvent(arg1, arg2);
			}
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x001622CC File Offset: 0x001604CC
		private void __clearDele_RealTimeArenaBattleFinishMissionEvent(BattleMode arg1, bool arg2)
		{
			this.RealTimeArenaBattleFinishMissionEvent = null;
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x001622D8 File Offset: 0x001604D8
		private void __callDele_RealTimeArenaDanUpdateMissionEvent(int obj)
		{
			Action<int> realTimeArenaDanUpdateMissionEvent = this.RealTimeArenaDanUpdateMissionEvent;
			if (realTimeArenaDanUpdateMissionEvent != null)
			{
				realTimeArenaDanUpdateMissionEvent(obj);
			}
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x001622FC File Offset: 0x001604FC
		private void __clearDele_RealTimeArenaDanUpdateMissionEvent(int obj)
		{
			this.RealTimeArenaDanUpdateMissionEvent = null;
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x00162308 File Offset: 0x00160508
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
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_RealTimeArenaDanUpdateInt32_hotfix = (luaObj.RawGet("RealTimeArenaDanUpdate") as LuaFunction);
					this.m_RealTimeArenaBattleFinishBattleModeBoolean_hotfix = (luaObj.RawGet("RealTimeArenaBattleFinish") as LuaFunction);
					this.m_RealTimeArenaBattleStartBattleMode_hotfix = (luaObj.RawGet("RealTimeArenaBattleStart") as LuaFunction);
					this.m_IsRealTimePVPUnlocked_hotfix = (luaObj.RawGet("IsRealTimePVPUnlocked") as LuaFunction);
					this.m_IsRealTimePVPArenaAvailableBattleMode_hotfix = (luaObj.RawGet("IsRealTimePVPArenaAvailable") as LuaFunction);
					this.m_OnFlushRealTimePVP_hotfix = (luaObj.RawGet("OnFlushRealTimePVP") as LuaFunction);
					this.m_StartNewSeason_hotfix = (luaObj.RawGet("StartNewSeason") as LuaFunction);
					this.m_IsPromotion_hotfix = (luaObj.RawGet("IsPromotion") as LuaFunction);
					this.m_GetPromotionBattleReports_hotfix = (luaObj.RawGet("GetPromotionBattleReports") as LuaFunction);
					this.m_GetBattleReports_hotfix = (luaObj.RawGet("GetBattleReports") as LuaFunction);
					this.m_StartPromotion_hotfix = (luaObj.RawGet("StartPromotion") as LuaFunction);
					this.m_EndPromotion_hotfix = (luaObj.RawGet("EndPromotion") as LuaFunction);
					this.m_SavePromotionReportRealTimePVPBattleReport_hotfix = (luaObj.RawGet("SavePromotionReport") as LuaFunction);
					this.m_SaveReportRealTimePVPBattleReport_hotfix = (luaObj.RawGet("SaveReport") as LuaFunction);
					this.m_CheckAcquireWinsBonusInt32_hotfix = (luaObj.RawGet("CheckAcquireWinsBonus") as LuaFunction);
					this.m_AcquireWinsBonusInt32_hotfix = (luaObj.RawGet("AcquireWinsBonus") as LuaFunction);
					this.m_GetConsecutiveWinsBattleMode_hotfix = (luaObj.RawGet("GetConsecutiveWins") as LuaFunction);
					this.m_GetConsecutiveLossesBattleMode_hotfix = (luaObj.RawGet("GetConsecutiveLosses") as LuaFunction);
					this.m_GetLadderCareerMatchStats_hotfix = (luaObj.RawGet("GetLadderCareerMatchStats") as LuaFunction);
					this.m_TryGetBotParamsForNoviceBattleModeInt32Int32_Int32_Int32_Int32__hotfix = (luaObj.RawGet("TryGetBotParamsForNovice") as LuaFunction);
					this.m_TryGetBotParamsForLoserBattleModeInt32Int32Int32_Int32_Int32_Int32__hotfix = (luaObj.RawGet("TryGetBotParamsForLoser") as LuaFunction);
					this.m_get_m_configDataLoader_hotfix = (luaObj.RawGet("get_m_configDataLoader") as LuaFunction);
					this.m_set_m_configDataLoaderIConfigDataLoader_hotfix = (luaObj.RawGet("set_m_configDataLoader") as LuaFunction);
					this.m_add_RealTimeArenaBattleStartMissionEventAction`1_hotfix = (luaObj.RawGet("add_RealTimeArenaBattleStartMissionEvent") as LuaFunction);
					this.m_remove_RealTimeArenaBattleStartMissionEventAction`1_hotfix = (luaObj.RawGet("remove_RealTimeArenaBattleStartMissionEvent") as LuaFunction);
					this.m_add_RealTimeArenaBattleFinishMissionEventAction`2_hotfix = (luaObj.RawGet("add_RealTimeArenaBattleFinishMissionEvent") as LuaFunction);
					this.m_remove_RealTimeArenaBattleFinishMissionEventAction`2_hotfix = (luaObj.RawGet("remove_RealTimeArenaBattleFinishMissionEvent") as LuaFunction);
					this.m_add_RealTimeArenaDanUpdateMissionEventAction`1_hotfix = (luaObj.RawGet("add_RealTimeArenaDanUpdateMissionEvent") as LuaFunction);
					this.m_remove_RealTimeArenaDanUpdateMissionEventAction`1_hotfix = (luaObj.RawGet("remove_RealTimeArenaDanUpdateMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x001627A4 File Offset: 0x001609A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400361C RID: 13852
		private IConfigDataLoader _configDataLoader;

		// Token: 0x0400361D RID: 13853
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x0400361E RID: 13854
		protected BagComponentCommon m_bag;

		// Token: 0x0400361F RID: 13855
		protected BattleComponentCommon m_battle;

		// Token: 0x04003620 RID: 13856
		public DataSectionRealTimePVP m_realTimePVP = new DataSectionRealTimePVP();

		// Token: 0x04003624 RID: 13860
		[DoNotToLua]
		private RealTimePVPComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04003625 RID: 13861
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003626 RID: 13862
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003627 RID: 13863
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003628 RID: 13864
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003629 RID: 13865
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400362A RID: 13866
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400362B RID: 13867
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400362C RID: 13868
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x0400362D RID: 13869
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x0400362E RID: 13870
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x0400362F RID: 13871
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003630 RID: 13872
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003631 RID: 13873
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003632 RID: 13874
		private LuaFunction m_RealTimeArenaDanUpdateInt32_hotfix;

		// Token: 0x04003633 RID: 13875
		private LuaFunction m_RealTimeArenaBattleFinishBattleModeBoolean_hotfix;

		// Token: 0x04003634 RID: 13876
		private LuaFunction m_RealTimeArenaBattleStartBattleMode_hotfix;

		// Token: 0x04003635 RID: 13877
		private LuaFunction m_IsRealTimePVPUnlocked_hotfix;

		// Token: 0x04003636 RID: 13878
		private LuaFunction m_IsRealTimePVPArenaAvailableBattleMode_hotfix;

		// Token: 0x04003637 RID: 13879
		private LuaFunction m_OnFlushRealTimePVP_hotfix;

		// Token: 0x04003638 RID: 13880
		private LuaFunction m_StartNewSeason_hotfix;

		// Token: 0x04003639 RID: 13881
		private LuaFunction m_IsPromotion_hotfix;

		// Token: 0x0400363A RID: 13882
		private LuaFunction m_GetPromotionBattleReports_hotfix;

		// Token: 0x0400363B RID: 13883
		private LuaFunction m_GetBattleReports_hotfix;

		// Token: 0x0400363C RID: 13884
		private LuaFunction m_StartPromotion_hotfix;

		// Token: 0x0400363D RID: 13885
		private LuaFunction m_EndPromotion_hotfix;

		// Token: 0x0400363E RID: 13886
		private LuaFunction m_SavePromotionReportRealTimePVPBattleReport_hotfix;

		// Token: 0x0400363F RID: 13887
		private LuaFunction m_SaveReportRealTimePVPBattleReport_hotfix;

		// Token: 0x04003640 RID: 13888
		private LuaFunction m_CheckAcquireWinsBonusInt32_hotfix;

		// Token: 0x04003641 RID: 13889
		private LuaFunction m_AcquireWinsBonusInt32_hotfix;

		// Token: 0x04003642 RID: 13890
		private LuaFunction m_GetConsecutiveWinsBattleMode_hotfix;

		// Token: 0x04003643 RID: 13891
		private LuaFunction m_GetConsecutiveLossesBattleMode_hotfix;

		// Token: 0x04003644 RID: 13892
		private LuaFunction m_GetLadderCareerMatchStats_hotfix;

		// Token: 0x04003645 RID: 13893
		private LuaFunction m_TryGetBotParamsForNoviceBattleModeInt32Int32_Int32_Int32_Int32__hotfix;

		// Token: 0x04003646 RID: 13894
		private LuaFunction m_TryGetBotParamsForLoserBattleModeInt32Int32Int32_Int32_Int32_Int32__hotfix;

		// Token: 0x04003647 RID: 13895
		private LuaFunction m_get_m_configDataLoader_hotfix;

		// Token: 0x04003648 RID: 13896
		private LuaFunction m_set_m_configDataLoaderIConfigDataLoader_hotfix;

		// Token: 0x04003649 RID: 13897
		private LuaFunction m_add_RealTimeArenaBattleStartMissionEventAction;

		// Token: 0x0400364A RID: 13898
		private LuaFunction m_remove_RealTimeArenaBattleStartMissionEventAction;

		// Token: 0x0400364B RID: 13899
		private LuaFunction m_add_RealTimeArenaBattleFinishMissionEventAction;

		// Token: 0x0400364C RID: 13900
		private LuaFunction m_remove_RealTimeArenaBattleFinishMissionEventAction;

		// Token: 0x0400364D RID: 13901
		private LuaFunction m_add_RealTimeArenaDanUpdateMissionEventAction;

		// Token: 0x0400364E RID: 13902
		private LuaFunction m_remove_RealTimeArenaDanUpdateMissionEventAction;

		// Token: 0x0200049E RID: 1182
		public class LuaExportHelper
		{
			// Token: 0x060047AE RID: 18350 RVA: 0x0016280C File Offset: 0x00160A0C
			public LuaExportHelper(RealTimePVPComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060047AF RID: 18351 RVA: 0x0016281C File Offset: 0x00160A1C
			public void __callDele_RealTimeArenaBattleStartMissionEvent(BattleMode obj)
			{
				this.m_owner.__callDele_RealTimeArenaBattleStartMissionEvent(obj);
			}

			// Token: 0x060047B0 RID: 18352 RVA: 0x0016282C File Offset: 0x00160A2C
			public void __clearDele_RealTimeArenaBattleStartMissionEvent(BattleMode obj)
			{
				this.m_owner.__clearDele_RealTimeArenaBattleStartMissionEvent(obj);
			}

			// Token: 0x060047B1 RID: 18353 RVA: 0x0016283C File Offset: 0x00160A3C
			public void __callDele_RealTimeArenaBattleFinishMissionEvent(BattleMode arg1, bool arg2)
			{
				this.m_owner.__callDele_RealTimeArenaBattleFinishMissionEvent(arg1, arg2);
			}

			// Token: 0x060047B2 RID: 18354 RVA: 0x0016284C File Offset: 0x00160A4C
			public void __clearDele_RealTimeArenaBattleFinishMissionEvent(BattleMode arg1, bool arg2)
			{
				this.m_owner.__clearDele_RealTimeArenaBattleFinishMissionEvent(arg1, arg2);
			}

			// Token: 0x060047B3 RID: 18355 RVA: 0x0016285C File Offset: 0x00160A5C
			public void __callDele_RealTimeArenaDanUpdateMissionEvent(int obj)
			{
				this.m_owner.__callDele_RealTimeArenaDanUpdateMissionEvent(obj);
			}

			// Token: 0x060047B4 RID: 18356 RVA: 0x0016286C File Offset: 0x00160A6C
			public void __clearDele_RealTimeArenaDanUpdateMissionEvent(int obj)
			{
				this.m_owner.__clearDele_RealTimeArenaDanUpdateMissionEvent(obj);
			}

			// Token: 0x170011FD RID: 4605
			// (get) Token: 0x060047B5 RID: 18357 RVA: 0x0016287C File Offset: 0x00160A7C
			// (set) Token: 0x060047B6 RID: 18358 RVA: 0x0016288C File Offset: 0x00160A8C
			public IConfigDataLoader _configDataLoader
			{
				get
				{
					return this.m_owner._configDataLoader;
				}
				set
				{
					this.m_owner._configDataLoader = value;
				}
			}

			// Token: 0x170011FE RID: 4606
			// (get) Token: 0x060047B7 RID: 18359 RVA: 0x0016289C File Offset: 0x00160A9C
			// (set) Token: 0x060047B8 RID: 18360 RVA: 0x001628AC File Offset: 0x00160AAC
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

			// Token: 0x170011FF RID: 4607
			// (get) Token: 0x060047B9 RID: 18361 RVA: 0x001628BC File Offset: 0x00160ABC
			// (set) Token: 0x060047BA RID: 18362 RVA: 0x001628CC File Offset: 0x00160ACC
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

			// Token: 0x17001200 RID: 4608
			// (get) Token: 0x060047BB RID: 18363 RVA: 0x001628DC File Offset: 0x00160ADC
			// (set) Token: 0x060047BC RID: 18364 RVA: 0x001628EC File Offset: 0x00160AEC
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

			// Token: 0x17001201 RID: 4609
			// (get) Token: 0x060047BD RID: 18365 RVA: 0x001628FC File Offset: 0x00160AFC
			// (set) Token: 0x060047BE RID: 18366 RVA: 0x0016290C File Offset: 0x00160B0C
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

			// Token: 0x060047BF RID: 18367 RVA: 0x0016291C File Offset: 0x00160B1C
			public void OnFlushRealTimePVP()
			{
				this.m_owner.OnFlushRealTimePVP();
			}

			// Token: 0x060047C0 RID: 18368 RVA: 0x0016292C File Offset: 0x00160B2C
			public void StartNewSeason()
			{
				this.m_owner.StartNewSeason();
			}

			// Token: 0x0400364F RID: 13903
			private RealTimePVPComponentCommon m_owner;
		}
	}
}
