using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004B8 RID: 1208
	[HotFix]
	public class UnchartedScoreComponentCommon : IComponentBase
	{
		// Token: 0x060049D3 RID: 18899 RVA: 0x00170C7C File Offset: 0x0016EE7C
		public UnchartedScoreComponentCommon()
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

		// Token: 0x060049D4 RID: 18900 RVA: 0x00170CF0 File Offset: 0x0016EEF0
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
			return "UnchartedScore";
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x00170D64 File Offset: 0x0016EF64
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

		// Token: 0x060049D6 RID: 18902 RVA: 0x00170DC4 File Offset: 0x0016EFC4
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
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_operationalActivity = (this.Owner.GetOwnerComponent("OperationalActivity") as OperationalActivityCompomentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.FlushBounsCount;
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x00170EC4 File Offset: 0x0016F0C4
		public void DeInit()
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

		// Token: 0x060049D8 RID: 18904 RVA: 0x00170F24 File Offset: 0x0016F124
		public void Tick(uint deltaMillisecond)
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

		// Token: 0x060049D9 RID: 18905 RVA: 0x00170F94 File Offset: 0x0016F194
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

		// Token: 0x060049DA RID: 18906 RVA: 0x00171014 File Offset: 0x0016F214
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

		// Token: 0x060049DB RID: 18907 RVA: 0x00171084 File Offset: 0x0016F284
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

		// Token: 0x060049DC RID: 18908 RVA: 0x001710E4 File Offset: 0x0016F2E4
		public int IsUnchartedScoreOnActivityTime(int UnchartedScoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsUnchartedScoreOnActivityTimeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsUnchartedScoreOnActivityTimeInt32_hotfix.call(new object[]
				{
					this,
					UnchartedScoreId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_operationalActivity.FindOperationalActivityByUnchartedScoreId(UnchartedScoreId) == null)
			{
				return -5300;
			}
			return 0;
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x0017117C File Offset: 0x0016F37C
		public List<int> GetAllOpenActivityUnchartedScore()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllOpenActivityUnchartedScore_hotfix != null)
			{
				return (List<int>)this.m_GetAllOpenActivityUnchartedScore_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			List<OperationalActivityBase> list2 = this.m_operationalActivity.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_UnchartedScore);
			foreach (OperationalActivityBase operationalActivityBase in list2)
			{
				foreach (ActivityParam activityParam in operationalActivityBase.Config.OperationalActivityParms)
				{
					if (!list.Contains(activityParam.Parm1))
					{
						list.Add(activityParam.Parm1);
					}
				}
			}
			return list;
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x001712AC File Offset: 0x0016F4AC
		public OperationalActivityBase FindOperationalActivityByUnchartedScoreId(int UnchartedScoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindOperationalActivityByUnchartedScoreIdInt32_hotfix != null)
			{
				return (OperationalActivityBase)this.m_FindOperationalActivityByUnchartedScoreIdInt32_hotfix.call(new object[]
				{
					this,
					UnchartedScoreId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_operationalActivity.FindOperationalActivityByUnchartedScoreId(UnchartedScoreId);
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00171334 File Offset: 0x0016F534
		public bool IsChallengeLevelContains(UnchartedScore unchartedScore, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsChallengeLevelContainsUnchartedScoreInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsChallengeLevelContainsUnchartedScoreInt32_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return unchartedScore.ChallengeLevelCompleteIds.Contains(levelId);
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x001713CC File Offset: 0x0016F5CC
		public bool IsChallengeLevelExist(UnchartedScore unchartedScore, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsChallengeLevelExistUnchartedScoreInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsChallengeLevelExistUnchartedScoreInt32_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_configDataLoader.GetConfigDataChallengeLevelInfo(levelId) != null;
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x00171470 File Offset: 0x0016F670
		public bool IsChallengeLevelTimeUnlock(OperationalActivityBase operationalActivity, ConfigDataChallengeLevelInfo levelInfo, DateTime curDateTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsChallengeLevelTimeUnlockOperationalActivityBaseConfigDataChallengeLevelInfoDateTime_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsChallengeLevelTimeUnlockOperationalActivityBaseConfigDataChallengeLevelInfoDateTime_hotfix.call(new object[]
				{
					this,
					operationalActivity,
					levelInfo,
					curDateTime
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return TimeCaculate.GetInitialTimeInOneDay(curDateTime).Subtract(TimeCaculate.GetInitialTimeInOneDay(operationalActivity.OperationStartTime)).Days >= levelInfo.UnlockDaysDelay;
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x0017153C File Offset: 0x0016F73C
		public bool IsChallengePrevLevelComplete(UnchartedScore unchartedScore, ConfigDataChallengeLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsChallengePrevLevelCompleteUnchartedScoreConfigDataChallengeLevelInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsChallengePrevLevelCompleteUnchartedScoreConfigDataChallengeLevelInfo_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return levelInfo.PrevLevelId == 0 || unchartedScore.ChallengeLevelCompleteIds.Contains(levelInfo.PrevLevelId);
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x001715E8 File Offset: 0x0016F7E8
		public bool IsScoreLevelContains(UnchartedScore unchartedScore, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScoreLevelContainsUnchartedScoreInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScoreLevelContainsUnchartedScoreInt32_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return unchartedScore.SocreLevelCompleteIds.Contains(levelId);
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x00171680 File Offset: 0x0016F880
		public bool IsScoreLevelExist(UnchartedScore unchartedScore, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScoreLevelExistUnchartedScoreInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScoreLevelExistUnchartedScoreInt32_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_configDataLoader.GetConfigDataScoreLevelInfo(levelId) != null;
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x00171724 File Offset: 0x0016F924
		public bool IsScoreLevelTimeUnlock(OperationalActivityBase operationalActivity, ConfigDataScoreLevelInfo levelInfo, DateTime curDateTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScoreLevelTimeUnlockOperationalActivityBaseConfigDataScoreLevelInfoDateTime_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScoreLevelTimeUnlockOperationalActivityBaseConfigDataScoreLevelInfoDateTime_hotfix.call(new object[]
				{
					this,
					operationalActivity,
					levelInfo,
					curDateTime
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int days = TimeCaculate.GetInitialTimeInOneDay(curDateTime).Subtract(TimeCaculate.GetInitialTimeInOneDay(operationalActivity.OperationStartTime)).Days;
			return levelInfo.UnlockDaysDelayGroupSet.Contains(days);
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x001717F0 File Offset: 0x0016F9F0
		public bool IsPlayerLevelVaild(ConfigDataScoreLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPlayerLevelVaildConfigDataScoreLevelInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPlayerLevelVaildConfigDataScoreLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_basicInfo.GetLevel() >= levelInfo.PlayerLevelMin;
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x00171884 File Offset: 0x0016FA84
		public int CalcScoreLevelScore(UnchartedScore unchartedScore, ConfigDataScoreLevelInfo levelInfo, List<int> heroIdList, bool levelBonus)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcScoreLevelScoreUnchartedScoreConfigDataScoreLevelInfoList`1Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalcScoreLevelScoreUnchartedScoreConfigDataScoreLevelInfoList`1Boolean_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelInfo,
					heroIdList,
					levelBonus
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CalcAllHeroBonus(unchartedScore, heroIdList);
			if (levelBonus)
			{
				return levelInfo.ScoreBase * (100 + unchartedScore.Config.ScoreLevelBonus + num) / 100;
			}
			return levelInfo.ScoreBase * (100 + num) / 100;
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x0017196C File Offset: 0x0016FB6C
		public int CalcChallengeLevelScore(UnchartedScore unchartedScore, ConfigDataChallengeLevelInfo levelInfo, List<int> heroIdList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcChallengeLevelScoreUnchartedScoreConfigDataChallengeLevelInfoList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalcChallengeLevelScoreUnchartedScoreConfigDataChallengeLevelInfoList`1_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelInfo,
					heroIdList
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CalcAllHeroBonus(unchartedScore, heroIdList);
			return levelInfo.ScoreBase * (100 + num) / 100;
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x00171A20 File Offset: 0x0016FC20
		public int CalcAllHeroBonus(UnchartedScore unchartedScore, List<int> heroIdList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcAllHeroBonusUnchartedScoreList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalcAllHeroBonusUnchartedScoreList`1_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					heroIdList
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (int key in heroIdList)
			{
				if (unchartedScore.Config.HeroId2Bonus.ContainsKey(key))
				{
					num += unchartedScore.Config.HeroId2Bonus[key];
				}
			}
			return num;
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x00171B1C File Offset: 0x0016FD1C
		public bool IsChallengeLevelUnlock(UnchartedScore unchartedScore, int levelId, DateTime curDateTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsChallengeLevelUnlockUnchartedScoreInt32DateTime_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsChallengeLevelUnlockUnchartedScoreInt32DateTime_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelId,
					curDateTime
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!unchartedScore.Config.ChallengeLevelIdList.Contains(levelId))
			{
				return false;
			}
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = this.m_configDataLoader.GetConfigDataChallengeLevelInfo(levelId);
			if (configDataChallengeLevelInfo == null)
			{
				return false;
			}
			OperationalActivityBase operationalActivityBase = this.FindOperationalActivityByUnchartedScoreId(unchartedScore.Id);
			return operationalActivityBase != null && this.IsChallengeLevelTimeUnlock(operationalActivityBase, configDataChallengeLevelInfo, curDateTime) && (configDataChallengeLevelInfo.PrevLevelId == 0 || unchartedScore.ChallengeLevelCompleteIds.Contains(configDataChallengeLevelInfo.PrevLevelId));
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x00171C30 File Offset: 0x0016FE30
		public bool IsScoreLevelUnlock(UnchartedScore unchartedScore, int levelId, DateTime curDateTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScoreLevelUnlockUnchartedScoreInt32DateTime_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScoreLevelUnlockUnchartedScoreInt32DateTime_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelId,
					curDateTime
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!unchartedScore.Config.ScoreLevelIdList.Contains(levelId))
			{
				return false;
			}
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = this.m_configDataLoader.GetConfigDataScoreLevelInfo(levelId);
			if (configDataScoreLevelInfo == null)
			{
				return false;
			}
			OperationalActivityBase operationalActivityBase = this.FindOperationalActivityByUnchartedScoreId(unchartedScore.Id);
			return operationalActivityBase != null && this.IsScoreLevelTimeUnlock(operationalActivityBase, configDataScoreLevelInfo, curDateTime) && this.IsPlayerLevelVaild(configDataScoreLevelInfo);
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x00171D30 File Offset: 0x0016FF30
		public bool IsScoreLevelUnlock(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScoreLevelUnlockInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScoreLevelUnlockInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = this.m_configDataLoader.GetConfigDataScoreLevelInfo(levelId);
			if (configDataScoreLevelInfo == null)
			{
				return false;
			}
			UnchartedScore unchartedScore = this.GetUnchartedScore(configDataScoreLevelInfo.UnchartedScoreInfo.ID);
			return unchartedScore != null && this.IsScoreLevelUnlock(unchartedScore, levelId, this.m_basicInfo.GetCurrentTime());
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x00171DF0 File Offset: 0x0016FFF0
		public List<int> GetAllUnlockedScoreLevels()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllUnlockedScoreLevels_hotfix != null)
			{
				return (List<int>)this.m_GetAllUnlockedScoreLevels_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<int> list = new List<int>();
			foreach (UnchartedScore unchartedScore in this.m_UnchartedScoreDS.UnchartedScores.Values)
			{
				foreach (int num in unchartedScore.Config.Id2ScoreLevelInfos.Keys)
				{
					if (this.IsScoreLevelUnlock(unchartedScore, num, currentTime))
					{
						list.Add(num);
					}
				}
			}
			return list;
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x00171F28 File Offset: 0x00170128
		public bool IsChallengeLevelComplete(UnchartedScore unchartedScore, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsChallengeLevelCompleteUnchartedScoreInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsChallengeLevelCompleteUnchartedScoreInt32_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return unchartedScore.ChallengeLevelCompleteIds.Contains(levelId);
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x00171FC0 File Offset: 0x001701C0
		public bool IsScoreLevelComplete(UnchartedScore unchartedScore, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScoreLevelCompleteUnchartedScoreInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScoreLevelCompleteUnchartedScoreInt32_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return unchartedScore.SocreLevelCompleteIds.Contains(levelId);
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x00172058 File Offset: 0x00170258
		public int IsUnchartedScoreExist(int unchartedScoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsUnchartedScoreExistInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsUnchartedScoreExistInt32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.GetUnchartedScore(unchartedScoreId) == null)
			{
				return -5301;
			}
			return 0;
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x001720E8 File Offset: 0x001702E8
		public List<Goods> GetReward(int unchartedScoreId, int score)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRewardInt32Int32_hotfix != null)
			{
				return (List<Goods>)this.m_GetRewardInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					score
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_UnchartedScoreDS.UnchartedScores[unchartedScoreId].Config.Score2GoodsList[score];
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x00172198 File Offset: 0x00170398
		protected int CanRewardGain(int unchartedScoreId, int score)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanRewardGainInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanRewardGainInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					score
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.IsUnchartedScoreExist(unchartedScoreId);
			if (num == 0)
			{
				UnchartedScore unchartedScore = this.m_UnchartedScoreDS.UnchartedScores[unchartedScoreId];
				if (!unchartedScore.Config.Score2GoodsList.ContainsKey(score))
				{
					num = -5312;
				}
				else if (unchartedScore.RewardGains.Contains(score))
				{
					num = -5314;
				}
				else if (unchartedScore.Score <= score)
				{
					num = -5313;
				}
			}
			return num;
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x001722A0 File Offset: 0x001704A0
		public void RemoveUnchartedScore(int unchartedScoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveUnchartedScoreInt32_hotfix != null)
			{
				this.m_RemoveUnchartedScoreInt32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_UnchartedScoreDS.RemoveUnchartedScore(unchartedScoreId);
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x0017231C File Offset: 0x0017051C
		public int CheckChallengeLevelEnergy(ConfigDataChallengeLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckChallengeLevelEnergyConfigDataChallengeLevelInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckChallengeLevelEnergyConfigDataChallengeLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_basicInfo.IsEnergyEnough(levelInfo.EnergySuccess))
			{
				return -402;
			}
			return 0;
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x001723B8 File Offset: 0x001705B8
		public int CheckScoreLevelEnergy(ConfigDataScoreLevelInfo levelInfo, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckScoreLevelEnergyConfigDataScoreLevelInfoBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckScoreLevelEnergyConfigDataScoreLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelInfo,
					isTeamBattle
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int consumeEnergy = levelInfo.EnergySuccess;
			if (isTeamBattle)
			{
				consumeEnergy = levelInfo.EnergyTeam;
			}
			if (!this.m_basicInfo.IsEnergyEnough(consumeEnergy))
			{
				return -402;
			}
			return 0;
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x00172470 File Offset: 0x00170670
		public virtual int CanAttackChallengeLevel(int unchartedScoreId, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackChallengeLevelInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackChallengeLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.IsUnchartedScoreExist(unchartedScoreId);
			if (num == 0)
			{
				UnchartedScore unchartedScore = this.GetUnchartedScore(unchartedScoreId);
				if (!unchartedScore.Config.Id2ChallengeLevelInfos.ContainsKey(levelId))
				{
					num = -5302;
				}
				else if (unchartedScore.ChallengeLevelCompleteIds.Contains(levelId))
				{
					num = -5305;
				}
				else
				{
					ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = unchartedScore.Config.Id2ChallengeLevelInfos[levelId];
					int prevLevelId = configDataChallengeLevelInfo.PrevLevelId;
					if (prevLevelId != 0 && !unchartedScore.ChallengeLevelCompleteIds.Contains(prevLevelId))
					{
						num = -5306;
					}
					else
					{
						OperationalActivityBase operationalActivityBase = this.FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
						if (operationalActivityBase == null)
						{
							num = -2213;
						}
						else
						{
							num = this.CheckChallengeLevelEnergy(configDataChallengeLevelInfo);
							if (num == 0)
							{
								if (!this.IsChallengeLevelTimeUnlock(operationalActivityBase, configDataChallengeLevelInfo, this.m_basicInfo.GetCurrentTime()))
								{
									num = -5304;
								}
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x001725E4 File Offset: 0x001707E4
		public int AttackChallengeLevel(int unchartedScoreId, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackChallengeLevelInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackChallengeLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackChallengeLevel(unchartedScoreId, levelId);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = this.GetUnchartedScore(unchartedScoreId).Config.Id2ChallengeLevelInfos[levelId];
			this.m_basicInfo.DecreaseEnergy(configDataChallengeLevelInfo.EnergyFail, GameFunctionType.GameFunctionType_UnchartedScoreChallengeLevel, levelId.ToString());
			this.m_battle.SetProcessingBattleInfo(BattleType.UnchartedScore_ChallengeLevel, levelId);
			return 0;
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x001726E4 File Offset: 0x001708E4
		public void SetCommonSuccessChallengeLevel(UnchartedScore unchartedScore, ConfigDataChallengeLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonSuccessChallengeLevelUnchartedScoreConfigDataChallengeLevelInfoList`1List`1Int32Boolean_hotfix != null)
			{
				this.m_SetCommonSuccessChallengeLevelUnchartedScoreConfigDataChallengeLevelInfoList`1List`1Int32Boolean_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelInfo,
					battleTreasures,
					heroes,
					energyCost,
					isBattleTeam
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CalcChallengeLevelScore(unchartedScore, levelInfo, heroes);
			unchartedScore.Score += num;
			unchartedScore.ChallengeLevelCompleteIds.Add(levelInfo.ID);
			this.CheckScoreReward(unchartedScore);
			this.m_battle.AddBattleTreasures(battleTreasures);
			this.m_basicInfo.AddPlayerExp(levelInfo.PlayerExp);
			this.m_battle.AddFightHeroFightNumsAndExp(heroes, levelInfo.HeroExp);
			this.m_basicInfo.AddGold(levelInfo.Gold, GameFunctionType.GameFunctionType_UnchartedScoreChallengeLevel, levelInfo.ID.ToString());
			if (energyCost > 0)
			{
				this.m_basicInfo.DecreaseEnergy(energyCost, GameFunctionType.GameFunctionType_UnchartedScoreChallengeLevel, levelInfo.ID.ToString());
			}
			this.m_battle.WinPveBattle(levelInfo.Battle_ID);
			this.m_UnchartedScoreDS.SetDirty(true);
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x00172878 File Offset: 0x00170A78
		public void SetCommonSuccessScoreLevel(UnchartedScore unchartedScore, ConfigDataScoreLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, List<int> allHeroes, int energyCost, bool isBattleTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonSuccessScoreLevelUnchartedScoreConfigDataScoreLevelInfoList`1List`1List`1Int32Boolean_hotfix != null)
			{
				this.m_SetCommonSuccessScoreLevelUnchartedScoreConfigDataScoreLevelInfoList`1List`1List`1Int32Boolean_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					levelInfo,
					battleTreasures,
					heroes,
					allHeroes,
					energyCost,
					isBattleTeam
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = unchartedScore.BonusCount < unchartedScore.Config.ScoreLevelBonusCount;
			int num = this.CalcScoreLevelScore(unchartedScore, levelInfo, allHeroes, flag);
			unchartedScore.Score += num;
			if (flag)
			{
				unchartedScore.BonusCount++;
			}
			unchartedScore.SocreLevelCompleteIds.Add(levelInfo.ID);
			this.CheckScoreReward(unchartedScore);
			this.m_battle.AddBattleTreasures(battleTreasures);
			this.m_basicInfo.AddPlayerExp(levelInfo.PlayerExp);
			this.m_battle.AddFightHeroFightNumsAndExp(heroes, levelInfo.HeroExp);
			this.m_basicInfo.AddGold(levelInfo.GoldReward, GameFunctionType.GameFunctionType_UnchartedScoreChallengeLevel, levelInfo.ID.ToString());
			if (energyCost > 0)
			{
				this.m_basicInfo.DecreaseEnergy(energyCost, GameFunctionType.GameFunctionType_UnchartedScoreChallengeLevel, levelInfo.ID.ToString());
			}
			this.m_battle.WinPveBattle(levelInfo.Battle_ID);
			this.m_UnchartedScoreDS.SetDirty(true);
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x00172A48 File Offset: 0x00170C48
		public virtual int CanAttackScoreLevel(int unchartedScoreId, int levelId, bool isTeamBattle = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackScoreLevelInt32Int32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackScoreLevelInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId,
					isTeamBattle
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.IsUnchartedScoreExist(unchartedScoreId);
			if (num == 0)
			{
				UnchartedScore unchartedScore = this.GetUnchartedScore(unchartedScoreId);
				if (!unchartedScore.Config.Id2ScoreLevelInfos.ContainsKey(levelId))
				{
					num = -5307;
				}
				else
				{
					OperationalActivityBase operationalActivityBase = this.FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
					if (operationalActivityBase == null)
					{
						num = -2213;
					}
					else
					{
						ConfigDataScoreLevelInfo levelInfo = unchartedScore.Config.Id2ScoreLevelInfos[levelId];
						num = this.CheckScoreLevelEnergy(levelInfo, isTeamBattle);
						if (num == 0)
						{
							if (!this.IsScoreLevelTimeUnlock(operationalActivityBase, levelInfo, this.m_basicInfo.GetCurrentTime()))
							{
								num = -5311;
							}
							else if (!this.IsPlayerLevelVaild(levelInfo))
							{
								num = -5309;
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x00172B9C File Offset: 0x00170D9C
		public int AttackScoreLevel(int unchartedScoreId, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackScoreLevelInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackScoreLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					unchartedScoreId,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackScoreLevel(unchartedScoreId, levelId, false);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = this.GetUnchartedScore(unchartedScoreId).Config.Id2ScoreLevelInfos[levelId];
			this.m_basicInfo.DecreaseEnergy(configDataScoreLevelInfo.EnergyFail, GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel, levelId.ToString());
			this.m_battle.SetProcessingBattleInfo(BattleType.UnchartedScore_ScoreLevel, levelId);
			return 0;
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x00172C9C File Offset: 0x00170E9C
		public virtual void CheckScoreReward(UnchartedScore unchartedScore)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckScoreRewardUnchartedScore_hotfix != null)
			{
				this.m_CheckScoreRewardUnchartedScore_hotfix.call(new object[]
				{
					this,
					unchartedScore
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (int num in unchartedScore.Config.Score2GoodsList.Keys)
			{
				if (!unchartedScore.RewardGains.Contains(num) && unchartedScore.Score >= num)
				{
					this.SetScoreRewardGain(unchartedScore, num);
				}
			}
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x00172D84 File Offset: 0x00170F84
		public void FlushBounsCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushBounsCount_hotfix != null)
			{
				this.m_FlushBounsCount_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (UnchartedScore unchartedScore in this.m_UnchartedScoreDS.UnchartedScores.Values)
			{
				unchartedScore.BonusCount = 0;
			}
			this.m_UnchartedScoreDS.SetDirty(true);
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x00172E4C File Offset: 0x0017104C
		public void SetScoreRewardGain(UnchartedScore unchartedScore, int score)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetScoreRewardGainUnchartedScoreInt32_hotfix != null)
			{
				this.m_SetScoreRewardGainUnchartedScoreInt32_hotfix.call(new object[]
				{
					this,
					unchartedScore,
					score
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			unchartedScore.RewardGains.Add(score);
			this.m_UnchartedScoreDS.SetDirty(true);
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x00172EE8 File Offset: 0x001710E8
		public UnchartedScore GetUnchartedScore(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUnchartedScoreInt32_hotfix != null)
			{
				return (UnchartedScore)this.m_GetUnchartedScoreInt32_hotfix.call(new object[]
				{
					this,
					id
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScore unchartedScore;
			this.m_UnchartedScoreDS.UnchartedScores.TryGetValue(id, out unchartedScore);
			if (unchartedScore == null)
			{
				ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = this.m_configDataLoader.GetConfigDataUnchartedScoreInfo(id);
				if (configDataUnchartedScoreInfo == null)
				{
					return null;
				}
				OperationalActivityBase operationalActivityBase = this.m_operationalActivity.FindOperationalActivityByUnchartedScoreId(id);
				if (operationalActivityBase == null)
				{
					return null;
				}
				unchartedScore = new UnchartedScore(id)
				{
					Config = configDataUnchartedScoreInfo
				};
				unchartedScore.ActivityInstanceId = operationalActivityBase.InstanceId;
				this.m_UnchartedScoreDS.UnchartedScores.Add(unchartedScore.Id, unchartedScore);
				this.m_UnchartedScoreDS.SetDirty(true);
			}
			return unchartedScore;
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06004A00 RID: 18944 RVA: 0x00172FE8 File Offset: 0x001711E8
		// (set) Token: 0x06004A01 RID: 18945 RVA: 0x0017305C File Offset: 0x0017125C
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

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06004A02 RID: 18946 RVA: 0x001730D4 File Offset: 0x001712D4
		// (set) Token: 0x06004A03 RID: 18947 RVA: 0x001730F4 File Offset: 0x001712F4
		[DoNotToLua]
		public UnchartedScoreComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnchartedScoreComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00173100 File Offset: 0x00171300
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
					this.m_IsUnchartedScoreOnActivityTimeInt32_hotfix = (luaObj.RawGet("IsUnchartedScoreOnActivityTime") as LuaFunction);
					this.m_GetAllOpenActivityUnchartedScore_hotfix = (luaObj.RawGet("GetAllOpenActivityUnchartedScore") as LuaFunction);
					this.m_FindOperationalActivityByUnchartedScoreIdInt32_hotfix = (luaObj.RawGet("FindOperationalActivityByUnchartedScoreId") as LuaFunction);
					this.m_IsChallengeLevelContainsUnchartedScoreInt32_hotfix = (luaObj.RawGet("IsChallengeLevelContains") as LuaFunction);
					this.m_IsChallengeLevelExistUnchartedScoreInt32_hotfix = (luaObj.RawGet("IsChallengeLevelExist") as LuaFunction);
					this.m_IsChallengeLevelTimeUnlockOperationalActivityBaseConfigDataChallengeLevelInfoDateTime_hotfix = (luaObj.RawGet("IsChallengeLevelTimeUnlock") as LuaFunction);
					this.m_IsChallengePrevLevelCompleteUnchartedScoreConfigDataChallengeLevelInfo_hotfix = (luaObj.RawGet("IsChallengePrevLevelComplete") as LuaFunction);
					this.m_IsScoreLevelContainsUnchartedScoreInt32_hotfix = (luaObj.RawGet("IsScoreLevelContains") as LuaFunction);
					this.m_IsScoreLevelExistUnchartedScoreInt32_hotfix = (luaObj.RawGet("IsScoreLevelExist") as LuaFunction);
					this.m_IsScoreLevelTimeUnlockOperationalActivityBaseConfigDataScoreLevelInfoDateTime_hotfix = (luaObj.RawGet("IsScoreLevelTimeUnlock") as LuaFunction);
					this.m_IsPlayerLevelVaildConfigDataScoreLevelInfo_hotfix = (luaObj.RawGet("IsPlayerLevelVaild") as LuaFunction);
					this.m_CalcScoreLevelScoreUnchartedScoreConfigDataScoreLevelInfoList`1Boolean_hotfix = (luaObj.RawGet("CalcScoreLevelScore") as LuaFunction);
					this.m_CalcChallengeLevelScoreUnchartedScoreConfigDataChallengeLevelInfoList`1_hotfix = (luaObj.RawGet("CalcChallengeLevelScore") as LuaFunction);
					this.m_CalcAllHeroBonusUnchartedScoreList`1_hotfix = (luaObj.RawGet("CalcAllHeroBonus") as LuaFunction);
					this.m_IsChallengeLevelUnlockUnchartedScoreInt32DateTime_hotfix = (luaObj.RawGet("IsChallengeLevelUnlock") as LuaFunction);
					this.m_IsScoreLevelUnlockUnchartedScoreInt32DateTime_hotfix = (luaObj.RawGet("IsScoreLevelUnlock") as LuaFunction);
					this.m_IsScoreLevelUnlockInt32_hotfix = (luaObj.RawGet("IsScoreLevelUnlock") as LuaFunction);
					this.m_GetAllUnlockedScoreLevels_hotfix = (luaObj.RawGet("GetAllUnlockedScoreLevels") as LuaFunction);
					this.m_IsChallengeLevelCompleteUnchartedScoreInt32_hotfix = (luaObj.RawGet("IsChallengeLevelComplete") as LuaFunction);
					this.m_IsScoreLevelCompleteUnchartedScoreInt32_hotfix = (luaObj.RawGet("IsScoreLevelComplete") as LuaFunction);
					this.m_IsUnchartedScoreExistInt32_hotfix = (luaObj.RawGet("IsUnchartedScoreExist") as LuaFunction);
					this.m_GetRewardInt32Int32_hotfix = (luaObj.RawGet("GetReward") as LuaFunction);
					this.m_CanRewardGainInt32Int32_hotfix = (luaObj.RawGet("CanRewardGain") as LuaFunction);
					this.m_RemoveUnchartedScoreInt32_hotfix = (luaObj.RawGet("RemoveUnchartedScore") as LuaFunction);
					this.m_CheckChallengeLevelEnergyConfigDataChallengeLevelInfo_hotfix = (luaObj.RawGet("CheckChallengeLevelEnergy") as LuaFunction);
					this.m_CheckScoreLevelEnergyConfigDataScoreLevelInfoBoolean_hotfix = (luaObj.RawGet("CheckScoreLevelEnergy") as LuaFunction);
					this.m_CanAttackChallengeLevelInt32Int32_hotfix = (luaObj.RawGet("CanAttackChallengeLevel") as LuaFunction);
					this.m_AttackChallengeLevelInt32Int32_hotfix = (luaObj.RawGet("AttackChallengeLevel") as LuaFunction);
					this.m_SetCommonSuccessChallengeLevelUnchartedScoreConfigDataChallengeLevelInfoList`1List`1Int32Boolean_hotfix = (luaObj.RawGet("SetCommonSuccessChallengeLevel") as LuaFunction);
					this.m_SetCommonSuccessScoreLevelUnchartedScoreConfigDataScoreLevelInfoList`1List`1List`1Int32Boolean_hotfix = (luaObj.RawGet("SetCommonSuccessScoreLevel") as LuaFunction);
					this.m_CanAttackScoreLevelInt32Int32Boolean_hotfix = (luaObj.RawGet("CanAttackScoreLevel") as LuaFunction);
					this.m_AttackScoreLevelInt32Int32_hotfix = (luaObj.RawGet("AttackScoreLevel") as LuaFunction);
					this.m_CheckScoreRewardUnchartedScore_hotfix = (luaObj.RawGet("CheckScoreReward") as LuaFunction);
					this.m_FlushBounsCount_hotfix = (luaObj.RawGet("FlushBounsCount") as LuaFunction);
					this.m_SetScoreRewardGainUnchartedScoreInt32_hotfix = (luaObj.RawGet("SetScoreRewardGain") as LuaFunction);
					this.m_GetUnchartedScoreInt32_hotfix = (luaObj.RawGet("GetUnchartedScore") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x0017364C File Offset: 0x0017184C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040037E3 RID: 14307
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040037E4 RID: 14308
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x040037E5 RID: 14309
		protected BattleComponentCommon m_battle;

		// Token: 0x040037E6 RID: 14310
		protected BagComponentCommon m_bag;

		// Token: 0x040037E7 RID: 14311
		protected HeroComponentCommon m_hero;

		// Token: 0x040037E8 RID: 14312
		protected OperationalActivityCompomentCommon m_operationalActivity;

		// Token: 0x040037E9 RID: 14313
		protected DataSectionUnchartedScore m_UnchartedScoreDS = new DataSectionUnchartedScore();

		// Token: 0x040037EA RID: 14314
		[DoNotToLua]
		private UnchartedScoreComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040037EB RID: 14315
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040037EC RID: 14316
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040037ED RID: 14317
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040037EE RID: 14318
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040037EF RID: 14319
		private LuaFunction m_Init_hotfix;

		// Token: 0x040037F0 RID: 14320
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040037F1 RID: 14321
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040037F2 RID: 14322
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040037F3 RID: 14323
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040037F4 RID: 14324
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040037F5 RID: 14325
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040037F6 RID: 14326
		private LuaFunction m_IsUnchartedScoreOnActivityTimeInt32_hotfix;

		// Token: 0x040037F7 RID: 14327
		private LuaFunction m_GetAllOpenActivityUnchartedScore_hotfix;

		// Token: 0x040037F8 RID: 14328
		private LuaFunction m_FindOperationalActivityByUnchartedScoreIdInt32_hotfix;

		// Token: 0x040037F9 RID: 14329
		private LuaFunction m_IsChallengeLevelContainsUnchartedScoreInt32_hotfix;

		// Token: 0x040037FA RID: 14330
		private LuaFunction m_IsChallengeLevelExistUnchartedScoreInt32_hotfix;

		// Token: 0x040037FB RID: 14331
		private LuaFunction m_IsChallengeLevelTimeUnlockOperationalActivityBaseConfigDataChallengeLevelInfoDateTime_hotfix;

		// Token: 0x040037FC RID: 14332
		private LuaFunction m_IsChallengePrevLevelCompleteUnchartedScoreConfigDataChallengeLevelInfo_hotfix;

		// Token: 0x040037FD RID: 14333
		private LuaFunction m_IsScoreLevelContainsUnchartedScoreInt32_hotfix;

		// Token: 0x040037FE RID: 14334
		private LuaFunction m_IsScoreLevelExistUnchartedScoreInt32_hotfix;

		// Token: 0x040037FF RID: 14335
		private LuaFunction m_IsScoreLevelTimeUnlockOperationalActivityBaseConfigDataScoreLevelInfoDateTime_hotfix;

		// Token: 0x04003800 RID: 14336
		private LuaFunction m_IsPlayerLevelVaildConfigDataScoreLevelInfo_hotfix;

		// Token: 0x04003801 RID: 14337
		private LuaFunction m_CalcScoreLevelScoreUnchartedScoreConfigDataScoreLevelInfoList;

		// Token: 0x04003802 RID: 14338
		private LuaFunction m_CalcChallengeLevelScoreUnchartedScoreConfigDataChallengeLevelInfoList;

		// Token: 0x04003803 RID: 14339
		private LuaFunction m_CalcAllHeroBonusUnchartedScoreList;

		// Token: 0x04003804 RID: 14340
		private LuaFunction m_IsChallengeLevelUnlockUnchartedScoreInt32DateTime_hotfix;

		// Token: 0x04003805 RID: 14341
		private LuaFunction m_IsScoreLevelUnlockUnchartedScoreInt32DateTime_hotfix;

		// Token: 0x04003806 RID: 14342
		private LuaFunction m_IsScoreLevelUnlockInt32_hotfix;

		// Token: 0x04003807 RID: 14343
		private LuaFunction m_GetAllUnlockedScoreLevels_hotfix;

		// Token: 0x04003808 RID: 14344
		private LuaFunction m_IsChallengeLevelCompleteUnchartedScoreInt32_hotfix;

		// Token: 0x04003809 RID: 14345
		private LuaFunction m_IsScoreLevelCompleteUnchartedScoreInt32_hotfix;

		// Token: 0x0400380A RID: 14346
		private LuaFunction m_IsUnchartedScoreExistInt32_hotfix;

		// Token: 0x0400380B RID: 14347
		private LuaFunction m_GetRewardInt32Int32_hotfix;

		// Token: 0x0400380C RID: 14348
		private LuaFunction m_CanRewardGainInt32Int32_hotfix;

		// Token: 0x0400380D RID: 14349
		private LuaFunction m_RemoveUnchartedScoreInt32_hotfix;

		// Token: 0x0400380E RID: 14350
		private LuaFunction m_CheckChallengeLevelEnergyConfigDataChallengeLevelInfo_hotfix;

		// Token: 0x0400380F RID: 14351
		private LuaFunction m_CheckScoreLevelEnergyConfigDataScoreLevelInfoBoolean_hotfix;

		// Token: 0x04003810 RID: 14352
		private LuaFunction m_CanAttackChallengeLevelInt32Int32_hotfix;

		// Token: 0x04003811 RID: 14353
		private LuaFunction m_AttackChallengeLevelInt32Int32_hotfix;

		// Token: 0x04003812 RID: 14354
		private LuaFunction m_SetCommonSuccessChallengeLevelUnchartedScoreConfigDataChallengeLevelInfoList`1List;

		// Token: 0x04003813 RID: 14355
		private LuaFunction m_SetCommonSuccessScoreLevelUnchartedScoreConfigDataScoreLevelInfoList`1List`1List;

		// Token: 0x04003814 RID: 14356
		private LuaFunction m_CanAttackScoreLevelInt32Int32Boolean_hotfix;

		// Token: 0x04003815 RID: 14357
		private LuaFunction m_AttackScoreLevelInt32Int32_hotfix;

		// Token: 0x04003816 RID: 14358
		private LuaFunction m_CheckScoreRewardUnchartedScore_hotfix;

		// Token: 0x04003817 RID: 14359
		private LuaFunction m_FlushBounsCount_hotfix;

		// Token: 0x04003818 RID: 14360
		private LuaFunction m_SetScoreRewardGainUnchartedScoreInt32_hotfix;

		// Token: 0x04003819 RID: 14361
		private LuaFunction m_GetUnchartedScoreInt32_hotfix;

		// Token: 0x0400381A RID: 14362
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x0400381B RID: 14363
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x020004B9 RID: 1209
		public class LuaExportHelper
		{
			// Token: 0x06004A06 RID: 18950 RVA: 0x001736B4 File Offset: 0x001718B4
			public LuaExportHelper(UnchartedScoreComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001254 RID: 4692
			// (get) Token: 0x06004A07 RID: 18951 RVA: 0x001736C4 File Offset: 0x001718C4
			// (set) Token: 0x06004A08 RID: 18952 RVA: 0x001736D4 File Offset: 0x001718D4
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

			// Token: 0x17001255 RID: 4693
			// (get) Token: 0x06004A09 RID: 18953 RVA: 0x001736E4 File Offset: 0x001718E4
			// (set) Token: 0x06004A0A RID: 18954 RVA: 0x001736F4 File Offset: 0x001718F4
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

			// Token: 0x17001256 RID: 4694
			// (get) Token: 0x06004A0B RID: 18955 RVA: 0x00173704 File Offset: 0x00171904
			// (set) Token: 0x06004A0C RID: 18956 RVA: 0x00173714 File Offset: 0x00171914
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

			// Token: 0x17001257 RID: 4695
			// (get) Token: 0x06004A0D RID: 18957 RVA: 0x00173724 File Offset: 0x00171924
			// (set) Token: 0x06004A0E RID: 18958 RVA: 0x00173734 File Offset: 0x00171934
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

			// Token: 0x17001258 RID: 4696
			// (get) Token: 0x06004A0F RID: 18959 RVA: 0x00173744 File Offset: 0x00171944
			// (set) Token: 0x06004A10 RID: 18960 RVA: 0x00173754 File Offset: 0x00171954
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

			// Token: 0x17001259 RID: 4697
			// (get) Token: 0x06004A11 RID: 18961 RVA: 0x00173764 File Offset: 0x00171964
			// (set) Token: 0x06004A12 RID: 18962 RVA: 0x00173774 File Offset: 0x00171974
			public OperationalActivityCompomentCommon m_operationalActivity
			{
				get
				{
					return this.m_owner.m_operationalActivity;
				}
				set
				{
					this.m_owner.m_operationalActivity = value;
				}
			}

			// Token: 0x1700125A RID: 4698
			// (get) Token: 0x06004A13 RID: 18963 RVA: 0x00173784 File Offset: 0x00171984
			// (set) Token: 0x06004A14 RID: 18964 RVA: 0x00173794 File Offset: 0x00171994
			public DataSectionUnchartedScore m_UnchartedScoreDS
			{
				get
				{
					return this.m_owner.m_UnchartedScoreDS;
				}
				set
				{
					this.m_owner.m_UnchartedScoreDS = value;
				}
			}

			// Token: 0x06004A15 RID: 18965 RVA: 0x001737A4 File Offset: 0x001719A4
			public int CanRewardGain(int unchartedScoreId, int score)
			{
				return this.m_owner.CanRewardGain(unchartedScoreId, score);
			}

			// Token: 0x0400381C RID: 14364
			private UnchartedScoreComponentCommon m_owner;
		}
	}
}
