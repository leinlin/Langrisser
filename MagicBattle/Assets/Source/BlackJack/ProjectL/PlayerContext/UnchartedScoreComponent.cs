using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008F0 RID: 2288
	[HotFix]
	public class UnchartedScoreComponent : UnchartedScoreComponentCommon
	{
		// Token: 0x06007821 RID: 30753 RVA: 0x0020B910 File Offset: 0x00209B10
		public UnchartedScoreComponent()
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

		// Token: 0x06007822 RID: 30754 RVA: 0x0020B978 File Offset: 0x00209B78
		public override void Init()
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x0020B9F4 File Offset: 0x00209BF4
		public override void PostInit()
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
			base.PostInit();
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x0020BA5C File Offset: 0x00209C5C
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_UnchartedScoreDS.ClientVersion;
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x0020BAD4 File Offset: 0x00209CD4
		public void DeSerialize(DSUnchartedScoreNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSUnchartedScoreNtf_hotfix != null)
			{
				this.m_DeSerializeDSUnchartedScoreNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_UnchartedScoreDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			this.m_UnchartedScoreDS.ClearInitedData();
			foreach (ProUnchartedScore proUnchartedScore in msg.UnchartedScores)
			{
				UnchartedScore unchartedScore = UnchartedScore.PbUnchartedScoreToUnchartedScore(proUnchartedScore);
				unchartedScore.Config = this.m_configDataLoader.GetConfigDataUnchartedScoreInfo(proUnchartedScore.Id);
				if (unchartedScore.Config != null)
				{
					this.m_UnchartedScoreDS.UnchartedScores.Add(proUnchartedScore.Id, unchartedScore);
				}
			}
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x0020BBF0 File Offset: 0x00209DF0
		public bool IsUnchartedScoreOpened(int unchartedScoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsUnchartedScoreOpenedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsUnchartedScoreOpenedInt32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			OperationalActivityBase operationalActivityBase = base.FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
			return operationalActivityBase != null;
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x0020BC7C File Offset: 0x00209E7C
		public void GetUnchartedScoreOpenTime(int unchartedScoreId, out DateTime startTime, out DateTime endTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUnchartedScoreOpenTimeInt32DateTime_DateTime__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent_GetUnchartedScoreOpenTime_Int32_DateTime_DateTime(this, this.m_GetUnchartedScoreOpenTimeInt32DateTime_DateTime__hotfix, unchartedScoreId, out startTime, out endTime);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			startTime = (endTime = DateTime.MinValue);
			OperationalActivityBase operationalActivityBase = base.FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
			if (operationalActivityBase != null)
			{
				startTime = operationalActivityBase.OperationStartTime;
				endTime = operationalActivityBase.OperationEndTime;
				return;
			}
			OperationalActivityBase operationalActivityBase2 = this.m_operationalActivity.FindShowActivityByUnchartedScoreId(unchartedScoreId);
			if (operationalActivityBase2 != null)
			{
				startTime = operationalActivityBase2.OperationStartTime;
				endTime = operationalActivityBase2.OperationEndTime;
				return;
			}
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x0020BD38 File Offset: 0x00209F38
		public bool IsUnchartedScoreDisplay(int unchartedScoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsUnchartedScoreDisplayInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsUnchartedScoreDisplayInt32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			OperationalActivityBase operationalActivityBase = base.FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
			if (operationalActivityBase != null)
			{
				return true;
			}
			OperationalActivityBase operationalActivityBase2 = this.m_operationalActivity.FindShowActivityByUnchartedScoreId(unchartedScoreId);
			return operationalActivityBase2 != null;
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x0020BDD8 File Offset: 0x00209FD8
		public int IsUnchartedScoreLevelTimeUnlock(int unchartedScoreId, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsUnchartedScoreLevelTimeUnlockInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsUnchartedScoreLevelTimeUnlockInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.IsUnchartedScoreExist(unchartedScoreId);
			if (num != 0)
			{
				return num;
			}
			UnchartedScore unchartedScore = base.GetUnchartedScore(unchartedScoreId);
			if (!unchartedScore.Config.Id2ScoreLevelInfos.ContainsKey(levelId))
			{
				return -5307;
			}
			OperationalActivityBase operationalActivityBase = base.FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
			if (operationalActivityBase == null)
			{
				return -2213;
			}
			ConfigDataScoreLevelInfo levelInfo = unchartedScore.Config.Id2ScoreLevelInfos[levelId];
			if (!base.IsScoreLevelTimeUnlock(operationalActivityBase, levelInfo, this.m_basicInfo.GetCurrentTime()))
			{
				return -5311;
			}
			return 0;
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x0020BEE0 File Offset: 0x0020A0E0
		public int GetChallengeLevelTimeUnlockDay(int unchartedScoreId, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChallengeLevelTimeUnlockDayInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetChallengeLevelTimeUnlockDayInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			OperationalActivityBase operationalActivityBase = base.FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
			if (operationalActivityBase == null)
			{
				return -1;
			}
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = this.m_configDataLoader.GetConfigDataChallengeLevelInfo(levelId);
			if (configDataChallengeLevelInfo == null)
			{
				return -1;
			}
			return operationalActivityBase.OperationStartTime.DayOfYear + configDataChallengeLevelInfo.UnlockDaysDelay - this.m_basicInfo.GetCurrentTime().DayOfYear;
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x0020BFBC File Offset: 0x0020A1BC
		public bool IsScoreLevelComplete(int unchartedScoreId, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScoreLevelCompleteInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScoreLevelCompleteInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScore unchartedScore = base.GetUnchartedScore(unchartedScoreId);
			return unchartedScore != null && base.IsScoreLevelComplete(unchartedScore, levelId);
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x0020C060 File Offset: 0x0020A260
		public bool IsChallengeLevelComplete(int unchartedScoreId, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsChallengeLevelCompleteInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsChallengeLevelCompleteInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScore unchartedScore = base.GetUnchartedScore(unchartedScoreId);
			return unchartedScore != null && base.IsChallengeLevelComplete(unchartedScore, levelId);
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x0020C104 File Offset: 0x0020A304
		public bool IsChallengePrevLevelComplete(int unchartedScoreId, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsChallengePrevLevelCompleteInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsChallengePrevLevelCompleteInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScore unchartedScore = base.GetUnchartedScore(unchartedScoreId);
			if (unchartedScore == null)
			{
				return false;
			}
			ConfigDataChallengeLevelInfo levelInfo = unchartedScore.Config.Id2ChallengeLevelInfos[levelId];
			return base.IsChallengePrevLevelComplete(unchartedScore, levelInfo);
		}

		// Token: 0x0600782E RID: 30766 RVA: 0x0020C1BC File Offset: 0x0020A3BC
		public bool IsRewardGot(int unchartedScoreId, int unchartedScoreRewardGroupId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRewardGotInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRewardGotInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					unchartedScoreRewardGroupId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataUnchartedScoreRewardGroupInfo configDataUnchartedScoreRewardGroupInfo = this.m_configDataLoader.GetConfigDataUnchartedScoreRewardGroupInfo(unchartedScoreRewardGroupId);
			return configDataUnchartedScoreRewardGroupInfo != null && base.CanRewardGain(unchartedScoreId, configDataUnchartedScoreRewardGroupInfo.Score) == -5314;
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x0020C274 File Offset: 0x0020A474
		public int GetScore(int unchartedScoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetScoreInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetScoreInt32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScore unchartedScore = base.GetUnchartedScore(unchartedScoreId);
			if (unchartedScore == null)
			{
				return 0;
			}
			return unchartedScore.Score;
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x0020C308 File Offset: 0x0020A508
		public int GetDailyRewardRestCount(int unchartedScoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDailyRewardRestCountInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDailyRewardRestCountInt32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScore unchartedScore = base.GetUnchartedScore(unchartedScoreId);
			if (unchartedScore == null)
			{
				return 0;
			}
			return unchartedScore.Config.ScoreLevelBonusCount - unchartedScore.BonusCount;
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x0020C3A8 File Offset: 0x0020A5A8
		public int FinishedChallengeLevel(int unchartedScoreId, int levelId, bool isWin, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedChallengeLevelInt32Int32BooleanList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishedChallengeLevelInt32Int32BooleanList`1_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId,
					isWin,
					battleTreasures
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = this.m_configDataLoader.GetConfigDataChallengeLevelInfo(levelId);
			if (configDataChallengeLevelInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -5303;
			}
			if (isWin)
			{
				List<int> pveTeam = this.m_battle.GetPveTeam();
				this.SetSuccessChallengeLevelLevel(unchartedScoreId, configDataChallengeLevelInfo, battleTreasures, pveTeam, false);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, isWin, true);
			return 0;
		}

		// Token: 0x06007832 RID: 30770 RVA: 0x0020C4A8 File Offset: 0x0020A6A8
		public int FinishedScoreLevel(int unchartedScoreId, int levelId, bool isWin, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedScoreLevelInt32Int32BooleanList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishedScoreLevelInt32Int32BooleanList`1_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId,
					isWin,
					battleTreasures
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = this.m_configDataLoader.GetConfigDataScoreLevelInfo(levelId);
			if (configDataScoreLevelInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -5308;
			}
			if (isWin)
			{
				List<int> pveTeam = this.m_battle.GetPveTeam();
				this.SetSuccessScoreLevelLevel(unchartedScoreId, configDataScoreLevelInfo, battleTreasures, pveTeam, pveTeam, false);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, isWin, true);
			return 0;
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x0020C5AC File Offset: 0x0020A7AC
		public void SetSuccessChallengeLevelLevel(int unchartedScoreId, ConfigDataChallengeLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessChallengeLevelLevelInt32ConfigDataChallengeLevelInfoList`1List`1Boolean_hotfix != null)
			{
				this.m_SetSuccessChallengeLevelLevelInt32ConfigDataChallengeLevelInfoList`1List`1Boolean_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelInfo,
					battleTreasures,
					heroes,
					isTeamBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScore unchartedScore = base.GetUnchartedScore(unchartedScoreId);
			if (unchartedScore == null)
			{
				return;
			}
			int energyCost = 0;
			if (!isTeamBattle)
			{
				energyCost = levelInfo.EnergySuccess - levelInfo.EnergyFail;
			}
			base.SetCommonSuccessChallengeLevel(unchartedScore, levelInfo, battleTreasures, heroes, energyCost, isTeamBattle);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = levelInfo.PlayerExp;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(levelInfo.HeroExp);
			battleReward.Gold = levelInfo.Gold;
			battleReward.Score = base.CalcChallengeLevelScore(unchartedScore, levelInfo, heroes);
			battleReward.DailyScoreBonus = 0;
			battleReward.HeroScoreBonus = base.CalcAllHeroBonus(unchartedScore, heroes);
		}

		// Token: 0x06007834 RID: 30772 RVA: 0x0020C6F8 File Offset: 0x0020A8F8
		public void SetSuccessScoreLevelLevel(int unchartedScoreId, ConfigDataScoreLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, List<int> allHeroes, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessScoreLevelLevelInt32ConfigDataScoreLevelInfoList`1List`1List`1Boolean_hotfix != null)
			{
				this.m_SetSuccessScoreLevelLevelInt32ConfigDataScoreLevelInfoList`1List`1List`1Boolean_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelInfo,
					battleTreasures,
					heroes,
					allHeroes,
					isTeamBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScore unchartedScore = base.GetUnchartedScore(unchartedScoreId);
			if (unchartedScore == null)
			{
				return;
			}
			int energyCost = 0;
			if (!isTeamBattle)
			{
				energyCost = levelInfo.EnergySuccess - levelInfo.EnergyFail;
			}
			bool flag = unchartedScore.BonusCount < unchartedScore.Config.ScoreLevelBonusCount;
			base.SetCommonSuccessScoreLevel(unchartedScore, levelInfo, battleTreasures, heroes, allHeroes, energyCost, isTeamBattle);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = levelInfo.PlayerExp;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(levelInfo.HeroExp);
			battleReward.Gold = levelInfo.GoldReward;
			battleReward.Score = base.CalcScoreLevelScore(unchartedScore, levelInfo, allHeroes, flag);
			if (flag)
			{
				battleReward.DailyScoreBonus = unchartedScore.Config.ScoreLevelBonus;
			}
			else
			{
				battleReward.DailyScoreBonus = 0;
			}
			battleReward.HeroScoreBonus = base.CalcAllHeroBonus(unchartedScore, allHeroes);
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06007835 RID: 30773 RVA: 0x0020C888 File Offset: 0x0020AA88
		// (set) Token: 0x06007836 RID: 30774 RVA: 0x0020C8A8 File Offset: 0x0020AAA8
		[DoNotToLua]
		public new UnchartedScoreComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnchartedScoreComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x0020C8B4 File Offset: 0x0020AAB4
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x0020C8BC File Offset: 0x0020AABC
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x0020C8C4 File Offset: 0x0020AAC4
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x0020C8CC File Offset: 0x0020AACC
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x0020C8D4 File Offset: 0x0020AAD4
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x0020C8E0 File Offset: 0x0020AAE0
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x0020C8E8 File Offset: 0x0020AAE8
		private int __callBase_IsUnchartedScoreOnActivityTime(int UnchartedScoreId)
		{
			return base.IsUnchartedScoreOnActivityTime(UnchartedScoreId);
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x0020C8F4 File Offset: 0x0020AAF4
		private List<int> __callBase_GetAllOpenActivityUnchartedScore()
		{
			return base.GetAllOpenActivityUnchartedScore();
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x0020C8FC File Offset: 0x0020AAFC
		private OperationalActivityBase __callBase_FindOperationalActivityByUnchartedScoreId(int UnchartedScoreId)
		{
			return base.FindOperationalActivityByUnchartedScoreId(UnchartedScoreId);
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x0020C908 File Offset: 0x0020AB08
		private bool __callBase_IsChallengeLevelContains(UnchartedScore unchartedScore, int levelId)
		{
			return base.IsChallengeLevelContains(unchartedScore, levelId);
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x0020C914 File Offset: 0x0020AB14
		private bool __callBase_IsChallengeLevelExist(UnchartedScore unchartedScore, int levelId)
		{
			return base.IsChallengeLevelExist(unchartedScore, levelId);
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x0020C920 File Offset: 0x0020AB20
		private bool __callBase_IsChallengeLevelTimeUnlock(OperationalActivityBase operationalActivity, ConfigDataChallengeLevelInfo levelInfo, DateTime curDateTime)
		{
			return base.IsChallengeLevelTimeUnlock(operationalActivity, levelInfo, curDateTime);
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x0020C92C File Offset: 0x0020AB2C
		private bool __callBase_IsChallengePrevLevelComplete(UnchartedScore unchartedScore, ConfigDataChallengeLevelInfo levelInfo)
		{
			return base.IsChallengePrevLevelComplete(unchartedScore, levelInfo);
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x0020C938 File Offset: 0x0020AB38
		private bool __callBase_IsScoreLevelContains(UnchartedScore unchartedScore, int levelId)
		{
			return base.IsScoreLevelContains(unchartedScore, levelId);
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x0020C944 File Offset: 0x0020AB44
		private bool __callBase_IsScoreLevelExist(UnchartedScore unchartedScore, int levelId)
		{
			return base.IsScoreLevelExist(unchartedScore, levelId);
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x0020C950 File Offset: 0x0020AB50
		private bool __callBase_IsScoreLevelTimeUnlock(OperationalActivityBase operationalActivity, ConfigDataScoreLevelInfo levelInfo, DateTime curDateTime)
		{
			return base.IsScoreLevelTimeUnlock(operationalActivity, levelInfo, curDateTime);
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x0020C95C File Offset: 0x0020AB5C
		private bool __callBase_IsPlayerLevelVaild(ConfigDataScoreLevelInfo levelInfo)
		{
			return base.IsPlayerLevelVaild(levelInfo);
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x0020C968 File Offset: 0x0020AB68
		private int __callBase_CalcScoreLevelScore(UnchartedScore unchartedScore, ConfigDataScoreLevelInfo levelInfo, List<int> heroIdList, bool levelBonus)
		{
			return base.CalcScoreLevelScore(unchartedScore, levelInfo, heroIdList, levelBonus);
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x0020C978 File Offset: 0x0020AB78
		private int __callBase_CalcChallengeLevelScore(UnchartedScore unchartedScore, ConfigDataChallengeLevelInfo levelInfo, List<int> heroIdList)
		{
			return base.CalcChallengeLevelScore(unchartedScore, levelInfo, heroIdList);
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x0020C984 File Offset: 0x0020AB84
		private int __callBase_CalcAllHeroBonus(UnchartedScore unchartedScore, List<int> heroIdList)
		{
			return base.CalcAllHeroBonus(unchartedScore, heroIdList);
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x0020C990 File Offset: 0x0020AB90
		private bool __callBase_IsChallengeLevelUnlock(UnchartedScore unchartedScore, int levelId, DateTime curDateTime)
		{
			return base.IsChallengeLevelUnlock(unchartedScore, levelId, curDateTime);
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x0020C99C File Offset: 0x0020AB9C
		private bool __callBase_IsScoreLevelUnlock(UnchartedScore unchartedScore, int levelId, DateTime curDateTime)
		{
			return base.IsScoreLevelUnlock(unchartedScore, levelId, curDateTime);
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x0020C9A8 File Offset: 0x0020ABA8
		private bool __callBase_IsScoreLevelUnlock(int levelId)
		{
			return base.IsScoreLevelUnlock(levelId);
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x0020C9B4 File Offset: 0x0020ABB4
		private List<int> __callBase_GetAllUnlockedScoreLevels()
		{
			return base.GetAllUnlockedScoreLevels();
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x0020C9BC File Offset: 0x0020ABBC
		private bool __callBase_IsChallengeLevelComplete(UnchartedScore unchartedScore, int levelId)
		{
			return base.IsChallengeLevelComplete(unchartedScore, levelId);
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x0020C9C8 File Offset: 0x0020ABC8
		private bool __callBase_IsScoreLevelComplete(UnchartedScore unchartedScore, int levelId)
		{
			return base.IsScoreLevelComplete(unchartedScore, levelId);
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x0020C9D4 File Offset: 0x0020ABD4
		private int __callBase_IsUnchartedScoreExist(int unchartedScoreId)
		{
			return base.IsUnchartedScoreExist(unchartedScoreId);
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x0020C9E0 File Offset: 0x0020ABE0
		private List<Goods> __callBase_GetReward(int unchartedScoreId, int score)
		{
			return base.GetReward(unchartedScoreId, score);
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x0020C9EC File Offset: 0x0020ABEC
		private int __callBase_CanRewardGain(int unchartedScoreId, int score)
		{
			return base.CanRewardGain(unchartedScoreId, score);
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x0020C9F8 File Offset: 0x0020ABF8
		private void __callBase_RemoveUnchartedScore(int unchartedScoreId)
		{
			base.RemoveUnchartedScore(unchartedScoreId);
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x0020CA04 File Offset: 0x0020AC04
		private int __callBase_CheckChallengeLevelEnergy(ConfigDataChallengeLevelInfo levelInfo)
		{
			return base.CheckChallengeLevelEnergy(levelInfo);
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x0020CA10 File Offset: 0x0020AC10
		private int __callBase_CheckScoreLevelEnergy(ConfigDataScoreLevelInfo levelInfo, bool isTeamBattle)
		{
			return base.CheckScoreLevelEnergy(levelInfo, isTeamBattle);
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x0020CA1C File Offset: 0x0020AC1C
		private int __callBase_CanAttackChallengeLevel(int unchartedScoreId, int levelId)
		{
			return base.CanAttackChallengeLevel(unchartedScoreId, levelId);
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x0020CA28 File Offset: 0x0020AC28
		private int __callBase_AttackChallengeLevel(int unchartedScoreId, int levelId)
		{
			return base.AttackChallengeLevel(unchartedScoreId, levelId);
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x0020CA34 File Offset: 0x0020AC34
		private void __callBase_SetCommonSuccessChallengeLevel(UnchartedScore unchartedScore, ConfigDataChallengeLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
		{
			base.SetCommonSuccessChallengeLevel(unchartedScore, levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x0020CA48 File Offset: 0x0020AC48
		private void __callBase_SetCommonSuccessScoreLevel(UnchartedScore unchartedScore, ConfigDataScoreLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, List<int> allHeroes, int energyCost, bool isBattleTeam)
		{
			base.SetCommonSuccessScoreLevel(unchartedScore, levelInfo, battleTreasures, heroes, allHeroes, energyCost, isBattleTeam);
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x0020CA5C File Offset: 0x0020AC5C
		private int __callBase_CanAttackScoreLevel(int unchartedScoreId, int levelId, bool isTeamBattle)
		{
			return base.CanAttackScoreLevel(unchartedScoreId, levelId, isTeamBattle);
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x0020CA68 File Offset: 0x0020AC68
		private int __callBase_AttackScoreLevel(int unchartedScoreId, int levelId)
		{
			return base.AttackScoreLevel(unchartedScoreId, levelId);
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x0020CA74 File Offset: 0x0020AC74
		private void __callBase_CheckScoreReward(UnchartedScore unchartedScore)
		{
			base.CheckScoreReward(unchartedScore);
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x0020CA80 File Offset: 0x0020AC80
		private void __callBase_FlushBounsCount()
		{
			base.FlushBounsCount();
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x0020CA88 File Offset: 0x0020AC88
		private void __callBase_SetScoreRewardGain(UnchartedScore unchartedScore, int score)
		{
			base.SetScoreRewardGain(unchartedScore, score);
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x0020CA94 File Offset: 0x0020AC94
		private UnchartedScore __callBase_GetUnchartedScore(int id)
		{
			return base.GetUnchartedScore(id);
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x0020CAA0 File Offset: 0x0020ACA0
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_DeSerializeDSUnchartedScoreNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_IsUnchartedScoreOpenedInt32_hotfix = (luaObj.RawGet("IsUnchartedScoreOpened") as LuaFunction);
					this.m_GetUnchartedScoreOpenTimeInt32DateTime_DateTime__hotfix = (luaObj.RawGet("GetUnchartedScoreOpenTime") as LuaFunction);
					this.m_IsUnchartedScoreDisplayInt32_hotfix = (luaObj.RawGet("IsUnchartedScoreDisplay") as LuaFunction);
					this.m_IsUnchartedScoreLevelTimeUnlockInt32Int32_hotfix = (luaObj.RawGet("IsUnchartedScoreLevelTimeUnlock") as LuaFunction);
					this.m_GetChallengeLevelTimeUnlockDayInt32Int32_hotfix = (luaObj.RawGet("GetChallengeLevelTimeUnlockDay") as LuaFunction);
					this.m_IsScoreLevelCompleteInt32Int32_hotfix = (luaObj.RawGet("IsScoreLevelComplete") as LuaFunction);
					this.m_IsChallengeLevelCompleteInt32Int32_hotfix = (luaObj.RawGet("IsChallengeLevelComplete") as LuaFunction);
					this.m_IsChallengePrevLevelCompleteInt32Int32_hotfix = (luaObj.RawGet("IsChallengePrevLevelComplete") as LuaFunction);
					this.m_IsRewardGotInt32Int32_hotfix = (luaObj.RawGet("IsRewardGot") as LuaFunction);
					this.m_GetScoreInt32_hotfix = (luaObj.RawGet("GetScore") as LuaFunction);
					this.m_GetDailyRewardRestCountInt32_hotfix = (luaObj.RawGet("GetDailyRewardRestCount") as LuaFunction);
					this.m_FinishedChallengeLevelInt32Int32BooleanList`1_hotfix = (luaObj.RawGet("FinishedChallengeLevel") as LuaFunction);
					this.m_FinishedScoreLevelInt32Int32BooleanList`1_hotfix = (luaObj.RawGet("FinishedScoreLevel") as LuaFunction);
					this.m_SetSuccessChallengeLevelLevelInt32ConfigDataChallengeLevelInfoList`1List`1Boolean_hotfix = (luaObj.RawGet("SetSuccessChallengeLevelLevel") as LuaFunction);
					this.m_SetSuccessScoreLevelLevelInt32ConfigDataScoreLevelInfoList`1List`1List`1Boolean_hotfix = (luaObj.RawGet("SetSuccessScoreLevelLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x0020CD48 File Offset: 0x0020AF48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005685 RID: 22149
		[DoNotToLua]
		private UnchartedScoreComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005686 RID: 22150
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005687 RID: 22151
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005688 RID: 22152
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005689 RID: 22153
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400568A RID: 22154
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400568B RID: 22155
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x0400568C RID: 22156
		private LuaFunction m_DeSerializeDSUnchartedScoreNtf_hotfix;

		// Token: 0x0400568D RID: 22157
		private LuaFunction m_IsUnchartedScoreOpenedInt32_hotfix;

		// Token: 0x0400568E RID: 22158
		private LuaFunction m_GetUnchartedScoreOpenTimeInt32DateTime_DateTime__hotfix;

		// Token: 0x0400568F RID: 22159
		private LuaFunction m_IsUnchartedScoreDisplayInt32_hotfix;

		// Token: 0x04005690 RID: 22160
		private LuaFunction m_IsUnchartedScoreLevelTimeUnlockInt32Int32_hotfix;

		// Token: 0x04005691 RID: 22161
		private LuaFunction m_GetChallengeLevelTimeUnlockDayInt32Int32_hotfix;

		// Token: 0x04005692 RID: 22162
		private LuaFunction m_IsScoreLevelCompleteInt32Int32_hotfix;

		// Token: 0x04005693 RID: 22163
		private LuaFunction m_IsChallengeLevelCompleteInt32Int32_hotfix;

		// Token: 0x04005694 RID: 22164
		private LuaFunction m_IsChallengePrevLevelCompleteInt32Int32_hotfix;

		// Token: 0x04005695 RID: 22165
		private LuaFunction m_IsRewardGotInt32Int32_hotfix;

		// Token: 0x04005696 RID: 22166
		private LuaFunction m_GetScoreInt32_hotfix;

		// Token: 0x04005697 RID: 22167
		private LuaFunction m_GetDailyRewardRestCountInt32_hotfix;

		// Token: 0x04005698 RID: 22168
		private LuaFunction m_FinishedChallengeLevelInt32Int32BooleanList;

		// Token: 0x04005699 RID: 22169
		private LuaFunction m_FinishedScoreLevelInt32Int32BooleanList;

		// Token: 0x0400569A RID: 22170
		private LuaFunction m_SetSuccessChallengeLevelLevelInt32ConfigDataChallengeLevelInfoList`1List;

		// Token: 0x0400569B RID: 22171
		private LuaFunction m_SetSuccessScoreLevelLevelInt32ConfigDataScoreLevelInfoList`1List`1List;

		// Token: 0x020008F1 RID: 2289
		public new class LuaExportHelper
		{
			// Token: 0x06007863 RID: 30819 RVA: 0x0020CDB0 File Offset: 0x0020AFB0
			public LuaExportHelper(UnchartedScoreComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007864 RID: 30820 RVA: 0x0020CDC0 File Offset: 0x0020AFC0
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007865 RID: 30821 RVA: 0x0020CDD0 File Offset: 0x0020AFD0
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007866 RID: 30822 RVA: 0x0020CDE0 File Offset: 0x0020AFE0
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06007867 RID: 30823 RVA: 0x0020CDF0 File Offset: 0x0020AFF0
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007868 RID: 30824 RVA: 0x0020CE00 File Offset: 0x0020B000
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007869 RID: 30825 RVA: 0x0020CE10 File Offset: 0x0020B010
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600786A RID: 30826 RVA: 0x0020CE20 File Offset: 0x0020B020
			public int __callBase_IsUnchartedScoreOnActivityTime(int UnchartedScoreId)
			{
				return this.m_owner.__callBase_IsUnchartedScoreOnActivityTime(UnchartedScoreId);
			}

			// Token: 0x0600786B RID: 30827 RVA: 0x0020CE30 File Offset: 0x0020B030
			public List<int> __callBase_GetAllOpenActivityUnchartedScore()
			{
				return this.m_owner.__callBase_GetAllOpenActivityUnchartedScore();
			}

			// Token: 0x0600786C RID: 30828 RVA: 0x0020CE40 File Offset: 0x0020B040
			public OperationalActivityBase __callBase_FindOperationalActivityByUnchartedScoreId(int UnchartedScoreId)
			{
				return this.m_owner.__callBase_FindOperationalActivityByUnchartedScoreId(UnchartedScoreId);
			}

			// Token: 0x0600786D RID: 30829 RVA: 0x0020CE50 File Offset: 0x0020B050
			public bool __callBase_IsChallengeLevelContains(UnchartedScore unchartedScore, int levelId)
			{
				return this.m_owner.__callBase_IsChallengeLevelContains(unchartedScore, levelId);
			}

			// Token: 0x0600786E RID: 30830 RVA: 0x0020CE60 File Offset: 0x0020B060
			public bool __callBase_IsChallengeLevelExist(UnchartedScore unchartedScore, int levelId)
			{
				return this.m_owner.__callBase_IsChallengeLevelExist(unchartedScore, levelId);
			}

			// Token: 0x0600786F RID: 30831 RVA: 0x0020CE70 File Offset: 0x0020B070
			public bool __callBase_IsChallengeLevelTimeUnlock(OperationalActivityBase operationalActivity, ConfigDataChallengeLevelInfo levelInfo, DateTime curDateTime)
			{
				return this.m_owner.__callBase_IsChallengeLevelTimeUnlock(operationalActivity, levelInfo, curDateTime);
			}

			// Token: 0x06007870 RID: 30832 RVA: 0x0020CE80 File Offset: 0x0020B080
			public bool __callBase_IsChallengePrevLevelComplete(UnchartedScore unchartedScore, ConfigDataChallengeLevelInfo levelInfo)
			{
				return this.m_owner.__callBase_IsChallengePrevLevelComplete(unchartedScore, levelInfo);
			}

			// Token: 0x06007871 RID: 30833 RVA: 0x0020CE90 File Offset: 0x0020B090
			public bool __callBase_IsScoreLevelContains(UnchartedScore unchartedScore, int levelId)
			{
				return this.m_owner.__callBase_IsScoreLevelContains(unchartedScore, levelId);
			}

			// Token: 0x06007872 RID: 30834 RVA: 0x0020CEA0 File Offset: 0x0020B0A0
			public bool __callBase_IsScoreLevelExist(UnchartedScore unchartedScore, int levelId)
			{
				return this.m_owner.__callBase_IsScoreLevelExist(unchartedScore, levelId);
			}

			// Token: 0x06007873 RID: 30835 RVA: 0x0020CEB0 File Offset: 0x0020B0B0
			public bool __callBase_IsScoreLevelTimeUnlock(OperationalActivityBase operationalActivity, ConfigDataScoreLevelInfo levelInfo, DateTime curDateTime)
			{
				return this.m_owner.__callBase_IsScoreLevelTimeUnlock(operationalActivity, levelInfo, curDateTime);
			}

			// Token: 0x06007874 RID: 30836 RVA: 0x0020CEC0 File Offset: 0x0020B0C0
			public bool __callBase_IsPlayerLevelVaild(ConfigDataScoreLevelInfo levelInfo)
			{
				return this.m_owner.__callBase_IsPlayerLevelVaild(levelInfo);
			}

			// Token: 0x06007875 RID: 30837 RVA: 0x0020CED0 File Offset: 0x0020B0D0
			public int __callBase_CalcScoreLevelScore(UnchartedScore unchartedScore, ConfigDataScoreLevelInfo levelInfo, List<int> heroIdList, bool levelBonus)
			{
				return this.m_owner.__callBase_CalcScoreLevelScore(unchartedScore, levelInfo, heroIdList, levelBonus);
			}

			// Token: 0x06007876 RID: 30838 RVA: 0x0020CEE4 File Offset: 0x0020B0E4
			public int __callBase_CalcChallengeLevelScore(UnchartedScore unchartedScore, ConfigDataChallengeLevelInfo levelInfo, List<int> heroIdList)
			{
				return this.m_owner.__callBase_CalcChallengeLevelScore(unchartedScore, levelInfo, heroIdList);
			}

			// Token: 0x06007877 RID: 30839 RVA: 0x0020CEF4 File Offset: 0x0020B0F4
			public int __callBase_CalcAllHeroBonus(UnchartedScore unchartedScore, List<int> heroIdList)
			{
				return this.m_owner.__callBase_CalcAllHeroBonus(unchartedScore, heroIdList);
			}

			// Token: 0x06007878 RID: 30840 RVA: 0x0020CF04 File Offset: 0x0020B104
			public bool __callBase_IsChallengeLevelUnlock(UnchartedScore unchartedScore, int levelId, DateTime curDateTime)
			{
				return this.m_owner.__callBase_IsChallengeLevelUnlock(unchartedScore, levelId, curDateTime);
			}

			// Token: 0x06007879 RID: 30841 RVA: 0x0020CF14 File Offset: 0x0020B114
			public bool __callBase_IsScoreLevelUnlock(UnchartedScore unchartedScore, int levelId, DateTime curDateTime)
			{
				return this.m_owner.__callBase_IsScoreLevelUnlock(unchartedScore, levelId, curDateTime);
			}

			// Token: 0x0600787A RID: 30842 RVA: 0x0020CF24 File Offset: 0x0020B124
			public bool __callBase_IsScoreLevelUnlock(int levelId)
			{
				return this.m_owner.__callBase_IsScoreLevelUnlock(levelId);
			}

			// Token: 0x0600787B RID: 30843 RVA: 0x0020CF34 File Offset: 0x0020B134
			public List<int> __callBase_GetAllUnlockedScoreLevels()
			{
				return this.m_owner.__callBase_GetAllUnlockedScoreLevels();
			}

			// Token: 0x0600787C RID: 30844 RVA: 0x0020CF44 File Offset: 0x0020B144
			public bool __callBase_IsChallengeLevelComplete(UnchartedScore unchartedScore, int levelId)
			{
				return this.m_owner.__callBase_IsChallengeLevelComplete(unchartedScore, levelId);
			}

			// Token: 0x0600787D RID: 30845 RVA: 0x0020CF54 File Offset: 0x0020B154
			public bool __callBase_IsScoreLevelComplete(UnchartedScore unchartedScore, int levelId)
			{
				return this.m_owner.__callBase_IsScoreLevelComplete(unchartedScore, levelId);
			}

			// Token: 0x0600787E RID: 30846 RVA: 0x0020CF64 File Offset: 0x0020B164
			public int __callBase_IsUnchartedScoreExist(int unchartedScoreId)
			{
				return this.m_owner.__callBase_IsUnchartedScoreExist(unchartedScoreId);
			}

			// Token: 0x0600787F RID: 30847 RVA: 0x0020CF74 File Offset: 0x0020B174
			public List<Goods> __callBase_GetReward(int unchartedScoreId, int score)
			{
				return this.m_owner.__callBase_GetReward(unchartedScoreId, score);
			}

			// Token: 0x06007880 RID: 30848 RVA: 0x0020CF84 File Offset: 0x0020B184
			public int __callBase_CanRewardGain(int unchartedScoreId, int score)
			{
				return this.m_owner.__callBase_CanRewardGain(unchartedScoreId, score);
			}

			// Token: 0x06007881 RID: 30849 RVA: 0x0020CF94 File Offset: 0x0020B194
			public void __callBase_RemoveUnchartedScore(int unchartedScoreId)
			{
				this.m_owner.__callBase_RemoveUnchartedScore(unchartedScoreId);
			}

			// Token: 0x06007882 RID: 30850 RVA: 0x0020CFA4 File Offset: 0x0020B1A4
			public int __callBase_CheckChallengeLevelEnergy(ConfigDataChallengeLevelInfo levelInfo)
			{
				return this.m_owner.__callBase_CheckChallengeLevelEnergy(levelInfo);
			}

			// Token: 0x06007883 RID: 30851 RVA: 0x0020CFB4 File Offset: 0x0020B1B4
			public int __callBase_CheckScoreLevelEnergy(ConfigDataScoreLevelInfo levelInfo, bool isTeamBattle)
			{
				return this.m_owner.__callBase_CheckScoreLevelEnergy(levelInfo, isTeamBattle);
			}

			// Token: 0x06007884 RID: 30852 RVA: 0x0020CFC4 File Offset: 0x0020B1C4
			public int __callBase_CanAttackChallengeLevel(int unchartedScoreId, int levelId)
			{
				return this.m_owner.__callBase_CanAttackChallengeLevel(unchartedScoreId, levelId);
			}

			// Token: 0x06007885 RID: 30853 RVA: 0x0020CFD4 File Offset: 0x0020B1D4
			public int __callBase_AttackChallengeLevel(int unchartedScoreId, int levelId)
			{
				return this.m_owner.__callBase_AttackChallengeLevel(unchartedScoreId, levelId);
			}

			// Token: 0x06007886 RID: 30854 RVA: 0x0020CFE4 File Offset: 0x0020B1E4
			public void __callBase_SetCommonSuccessChallengeLevel(UnchartedScore unchartedScore, ConfigDataChallengeLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
			{
				this.m_owner.__callBase_SetCommonSuccessChallengeLevel(unchartedScore, levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			}

			// Token: 0x06007887 RID: 30855 RVA: 0x0020CFFC File Offset: 0x0020B1FC
			public void __callBase_SetCommonSuccessScoreLevel(UnchartedScore unchartedScore, ConfigDataScoreLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, List<int> allHeroes, int energyCost, bool isBattleTeam)
			{
				this.m_owner.__callBase_SetCommonSuccessScoreLevel(unchartedScore, levelInfo, battleTreasures, heroes, allHeroes, energyCost, isBattleTeam);
			}

			// Token: 0x06007888 RID: 30856 RVA: 0x0020D014 File Offset: 0x0020B214
			public int __callBase_CanAttackScoreLevel(int unchartedScoreId, int levelId, bool isTeamBattle)
			{
				return this.m_owner.__callBase_CanAttackScoreLevel(unchartedScoreId, levelId, isTeamBattle);
			}

			// Token: 0x06007889 RID: 30857 RVA: 0x0020D024 File Offset: 0x0020B224
			public int __callBase_AttackScoreLevel(int unchartedScoreId, int levelId)
			{
				return this.m_owner.__callBase_AttackScoreLevel(unchartedScoreId, levelId);
			}

			// Token: 0x0600788A RID: 30858 RVA: 0x0020D034 File Offset: 0x0020B234
			public void __callBase_CheckScoreReward(UnchartedScore unchartedScore)
			{
				this.m_owner.__callBase_CheckScoreReward(unchartedScore);
			}

			// Token: 0x0600788B RID: 30859 RVA: 0x0020D044 File Offset: 0x0020B244
			public void __callBase_FlushBounsCount()
			{
				this.m_owner.__callBase_FlushBounsCount();
			}

			// Token: 0x0600788C RID: 30860 RVA: 0x0020D054 File Offset: 0x0020B254
			public void __callBase_SetScoreRewardGain(UnchartedScore unchartedScore, int score)
			{
				this.m_owner.__callBase_SetScoreRewardGain(unchartedScore, score);
			}

			// Token: 0x0600788D RID: 30861 RVA: 0x0020D064 File Offset: 0x0020B264
			public UnchartedScore __callBase_GetUnchartedScore(int id)
			{
				return this.m_owner.__callBase_GetUnchartedScore(id);
			}

			// Token: 0x0400569C RID: 22172
			private UnchartedScoreComponent m_owner;
		}
	}
}
