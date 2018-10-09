using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E1A RID: 3610
	[HotFix]
	public class HeroDungeonUITask : UITask
	{
		// Token: 0x060115EE RID: 71150 RVA: 0x00480E78 File Offset: 0x0047F078
		public HeroDungeonUITask(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060115EF RID: 71151 RVA: 0x00480FD0 File Offset: 0x0047F1D0
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x060115F0 RID: 71152 RVA: 0x0048105C File Offset: 0x0047F25C
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnResume(intent);
		}

		// Token: 0x060115F1 RID: 71153 RVA: 0x004810E8 File Offset: 0x0047F2E8
		private void InitDataFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDataFromUIIntentUIIntent_hotfix != null)
			{
				this.m_InitDataFromUIIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroDungeonLevelInfo = null;
			this.m_heroInformationInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_heroDungeonLevelInfo = uiintentCustom.GetClassParam<ConfigDataHeroDungeonLevelInfo>("HeroDungeonLevelInfo");
				this.m_heroInformationInfo = uiintentCustom.GetClassParam<ConfigDataHeroInformationInfo>("HeroInformationInfo");
			}
		}

		// Token: 0x060115F2 RID: 71154 RVA: 0x00481198 File Offset: 0x0047F398
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (this.m_heroDungeonUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_heroDungeonUIController = (this.m_uiCtrlArray[0] as HeroDungeonUIController);
				}
				if (!(this.m_heroDungeonUIController != null))
				{
					Debug.LogError("HeroDungeonUIController is null");
					return;
				}
				this.m_heroDungeonUIController.EventOnReturn += this.HeroDungeonUIController_OnReturn;
				this.m_heroDungeonUIController.EventOnShowHelp += this.HeroDungeonUIController_OnShowHelp;
				this.m_heroDungeonUIController.EventOnSelectDungeonLevel += this.HeroDungeonUIController_OnSelectDungeonLevel;
				this.m_heroDungeonUIController.EventOnGetStarReward += this.HeroDungeonUIController_OnGetStarReward;
			}
			if (this.m_playerResourceUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_playerResourceUIController = (this.m_uiCtrlArray[1] as PlayerResourceUIController);
				}
				if (!(this.m_playerResourceUIController != null))
				{
					Debug.LogError("PlayerResourceUIController is null");
					return;
				}
				this.m_playerResourceUIController.EventOnAddCrystal += this.PlayerResourceUIController_OnAddCrystal;
			}
		}

		// Token: 0x060115F3 RID: 71155 RVA: 0x00481318 File Offset: 0x0047F518
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_heroDungeonUIController != null)
			{
				this.m_heroDungeonUIController.EventOnReturn -= this.HeroDungeonUIController_OnReturn;
				this.m_heroDungeonUIController.EventOnShowHelp -= this.HeroDungeonUIController_OnShowHelp;
				this.m_heroDungeonUIController.EventOnSelectDungeonLevel -= this.HeroDungeonUIController_OnSelectDungeonLevel;
				this.m_heroDungeonUIController.EventOnGetStarReward -= this.HeroDungeonUIController_OnGetStarReward;
				this.m_heroDungeonUIController = null;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController.EventOnAddCrystal -= this.PlayerResourceUIController_OnAddCrystal;
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x060115F4 RID: 71156 RVA: 0x00481424 File Offset: 0x0047F624
		protected override void OnMemoryWarning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryWarning_hotfix != null)
			{
				this.m_OnMemoryWarning_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060115F5 RID: 71157 RVA: 0x0048148C File Offset: 0x0047F68C
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = false;
			this.m_heroDungeonUIController.ClearHeroDungeonLevelListItems();
			if (this.m_heroDungeonLevelInfo != null)
			{
				ConfigDataHeroInformationInfo configDataHeroInformationInfo = this.m_configDataLoader.GetConfigDataHeroInformationInfo(this.m_heroDungeonLevelInfo.m_chapterId);
				if (configDataHeroInformationInfo != null)
				{
					foreach (int key in configDataHeroInformationInfo.DungeonLevels_ID)
					{
						ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(key);
						if (configDataHeroDungeonLevelInfo != null)
						{
							this.m_heroDungeonUIController.AddHeroDungeonLevelListItem(configDataHeroDungeonLevelInfo);
						}
					}
					this.m_heroInformationInfo = configDataHeroInformationInfo;
				}
				this.m_heroDungeonUIController.SetCurrentDungeonLevel(this.m_heroDungeonLevelInfo);
				this.HeroDungeonUIController_OnSelectDungeonLevel(this.m_heroDungeonLevelInfo);
			}
			else if (this.m_heroInformationInfo != null)
			{
				foreach (int key2 in this.m_heroInformationInfo.DungeonLevels_ID)
				{
					ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo2 = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(key2);
					if (configDataHeroDungeonLevelInfo2 != null)
					{
						this.m_heroDungeonUIController.AddHeroDungeonLevelListItem(configDataHeroDungeonLevelInfo2);
					}
				}
				flag = true;
			}
			if (this.m_heroInformationInfo != null)
			{
				this.m_heroDungeonUIController.SetHeroChar(this.m_heroInformationInfo.m_heroInfo.ID);
				this.m_heroDungeonUIController.SetDungeonStarsProgress(this.m_heroInformationInfo);
			}
			this.m_playerResourceUIController.UpdatePlayerResource();
			int heroDungeonDailyChallengeMaxNums = this.m_playerContext.GetHeroDungeonDailyChallengeMaxNums();
			this.m_heroDungeonUIController.SetChallengeCountValueText(heroDungeonDailyChallengeMaxNums);
			if (base.IsOpeningUI())
			{
				this.m_heroDungeonUIController.Open();
			}
			if (flag)
			{
				this.AutoGetStarReward();
			}
		}

		// Token: 0x060115F6 RID: 71158 RVA: 0x004816B8 File Offset: 0x0047F8B8
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			if (this.m_heroInformationInfo != null)
			{
				Hero hero = this.m_playerContext.GetHero(this.m_heroInformationInfo.m_heroInfo.ID);
				if (hero != null)
				{
					string heroCharAssetPath = UIUtility.GetHeroCharAssetPath(hero);
					if (!string.IsNullOrEmpty(heroCharAssetPath))
					{
						base.CollectAsset(heroCharAssetPath);
					}
					else
					{
						ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
						if (charImageInfo != null)
						{
							base.CollectSpriteAsset(charImageInfo.Image);
						}
					}
				}
				foreach (int key in this.m_heroInformationInfo.DungeonLevels_ID)
				{
					ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(key);
					if (configDataHeroDungeonLevelInfo != null)
					{
						foreach (Goods goods in configDataHeroDungeonLevelInfo.FirstReward)
						{
							base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
						}
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060115F7 RID: 71159 RVA: 0x00481864 File Offset: 0x0047FA64
		private void AutoGetStarReward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoGetStarReward_hotfix != null)
			{
				this.m_AutoGetStarReward_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroInformationInfo == null)
			{
				return;
			}
			for (int i = 1; i <= 3; i++)
			{
				if (this.m_playerContext.GetHeroDungeonStarRewardStatus(this.m_heroInformationInfo.ID, i) == GainRewardStatus.CanGet)
				{
					this.HeroDungeonUIController_OnGetStarReward(i);
					break;
				}
			}
		}

		// Token: 0x060115F8 RID: 71160 RVA: 0x0048190C File Offset: 0x0047FB0C
		private void PlayerResourceUIController_OnAddCrystal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerResourceUIController_OnAddCrystal_hotfix != null)
			{
				this.m_PlayerResourceUIController_OnAddCrystal_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
		}

		// Token: 0x060115F9 RID: 71161 RVA: 0x00481984 File Offset: 0x0047FB84
		private void HeroDungeonUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDungeonUIController_OnReturn_hotfix != null)
			{
				this.m_HeroDungeonUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
				if (uiintentReturnable != null)
				{
					UIManager.Instance.ReturnUITask(uiintentReturnable.PrevTaskIntent);
				}
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x060115FA RID: 71162 RVA: 0x00481A08 File Offset: 0x0047FC08
		private void HeroDungeonUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDungeonUIController_OnShowHelp_hotfix != null)
			{
				this.m_HeroDungeonUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_HeroDungeon);
		}

		// Token: 0x060115FB RID: 71163 RVA: 0x00481A74 File Offset: 0x0047FC74
		private void HeroDungeonUIController_OnGetStarReward(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDungeonUIController_OnGetStarRewardInt32_hotfix != null)
			{
				this.m_HeroDungeonUIController_OnGetStarRewardInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroInformationInfo == null)
			{
				return;
			}
			int num = this.m_playerContext.CanGainHeroDungeonStarReward(this.m_heroInformationInfo.ID, index);
			if (num == 0)
			{
				HeroDungeonRewardGainNetTask heroDungeonRewardGainNetTask = new HeroDungeonRewardGainNetTask(this.m_heroInformationInfo.ID, index);
				heroDungeonRewardGainNetTask.EventOnStop += delegate(Task task)
				{
					HeroDungeonRewardGainNetTask heroDungeonRewardGainNetTask2 = task as HeroDungeonRewardGainNetTask;
					if (heroDungeonRewardGainNetTask2.Result == 0)
					{
						ChestUITask chestUITask = ChestUITask.StartUITask(heroDungeonRewardGainNetTask2.Reward, false, false);
						if (this.m_chestUITask == null)
						{
							this.m_chestUITask = chestUITask;
							this.m_chestUITask.EventOnStop += this.ChestUITask_OnStop;
							this.m_chestUITask.EventOnClose += this.ChestUITask_OnClose;
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(heroDungeonRewardGainNetTask2.Result, 2f, null, true);
					}
				};
				heroDungeonRewardGainNetTask.Start(null);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x060115FC RID: 71164 RVA: 0x00481B54 File Offset: 0x0047FD54
		private void HeroDungeonUIController_OnSelectDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDungeonUIController_OnSelectDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				this.m_HeroDungeonUIController_OnSelectDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (levelInfo == null)
			{
				return;
			}
			this.m_heroDungeonLevelInfo = levelInfo;
			int num = this.m_playerContext.CanUnLockHeroDungeonLevel(levelInfo.ID);
			if (num == 0)
			{
				this.StartHeroDungeonLevelInfoUITask(levelInfo);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x060115FD RID: 71165 RVA: 0x00481C08 File Offset: 0x0047FE08
		private void StartHeroDungeonLevelInfoUITask(ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroDungeonLevelInfoUITaskConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				this.m_StartHeroDungeonLevelInfoUITaskConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					heroDungeonLevelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroDungeonLevelInfo == null)
			{
				return;
			}
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(BattleLevelInfoUITask).Name, null);
			uiintentCustom.SetParam("HeroDungeonLevelInfo", heroDungeonLevelInfo);
			uiintentCustom.SetParam("BattleType", BattleType.HeroDungeon);
			BattleLevelInfoUITask battleLevelInfoUITask = UIManager.Instance.StartUITask(uiintentCustom, true, false, null) as BattleLevelInfoUITask;
			if (this.m_battleLevelInfoUITask == null)
			{
				this.m_battleLevelInfoUITask = battleLevelInfoUITask;
				this.m_battleLevelInfoUITask.EventOnClose += this.BattleLevelInfoUITask_OnClose;
				this.m_battleLevelInfoUITask.EventOnHeroDungeonRaidComplete += this.BattleLevelInfoUITask_OnHeroDungeonRaidComplete;
			}
		}

		// Token: 0x060115FE RID: 71166 RVA: 0x00481D08 File Offset: 0x0047FF08
		private void BattleLevelInfoUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleLevelInfoUITask_OnClose_hotfix != null)
			{
				this.m_BattleLevelInfoUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleLevelInfoUITask != null)
			{
				this.m_battleLevelInfoUITask.EventOnClose -= this.BattleLevelInfoUITask_OnClose;
				this.m_battleLevelInfoUITask.EventOnHeroDungeonRaidComplete -= this.BattleLevelInfoUITask_OnHeroDungeonRaidComplete;
				this.m_battleLevelInfoUITask = null;
			}
		}

		// Token: 0x060115FF RID: 71167 RVA: 0x00481DA8 File Offset: 0x0047FFA8
		private void BattleLevelInfoUITask_OnHeroDungeonRaidComplete(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleLevelInfoUITask_OnHeroDungeonRaidCompleteInt32_hotfix != null)
			{
				this.m_BattleLevelInfoUITask_OnHeroDungeonRaidCompleteInt32_hotfix.call(new object[]
				{
					this,
					levelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerResourceUIController.UpdatePlayerResource();
			this.m_heroDungeonUIController.UpdateDungeonLevelListItem(levelId);
			int heroDungeonDailyChallengeMaxNums = this.m_playerContext.GetHeroDungeonDailyChallengeMaxNums();
			this.m_heroDungeonUIController.SetChallengeCountValueText(heroDungeonDailyChallengeMaxNums);
		}

		// Token: 0x06011600 RID: 71168 RVA: 0x00481E48 File Offset: 0x00480048
		private void ChestUITask_OnStop(Task task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChestUITask_OnStopTask_hotfix != null)
			{
				this.m_ChestUITask_OnStopTask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chestUITask == task)
			{
				this.m_chestUITask.EventOnStop -= this.ChestUITask_OnStop;
				this.m_chestUITask.EventOnClose -= this.ChestUITask_OnClose;
				this.m_chestUITask = null;
			}
		}

		// Token: 0x06011601 RID: 71169 RVA: 0x00481EFC File Offset: 0x004800FC
		private void ChestUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChestUITask_OnClose_hotfix != null)
			{
				this.m_ChestUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chestUITask != null)
			{
				this.ChestUITask_OnStop(this.m_chestUITask);
			}
			if (this.m_heroInformationInfo != null)
			{
				this.m_heroDungeonUIController.SetDungeonStarsProgress(this.m_heroInformationInfo);
			}
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x06011602 RID: 71170 RVA: 0x00481F90 File Offset: 0x00480190
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x06011603 RID: 71171 RVA: 0x00482004 File Offset: 0x00480204
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x06011604 RID: 71172 RVA: 0x00482078 File Offset: 0x00480278
		// (set) Token: 0x06011605 RID: 71173 RVA: 0x00482098 File Offset: 0x00480298
		[DoNotToLua]
		public new HeroDungeonUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDungeonUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011606 RID: 71174 RVA: 0x004820A4 File Offset: 0x004802A4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06011607 RID: 71175 RVA: 0x004820B0 File Offset: 0x004802B0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06011608 RID: 71176 RVA: 0x004820B8 File Offset: 0x004802B8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06011609 RID: 71177 RVA: 0x004820C0 File Offset: 0x004802C0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0601160A RID: 71178 RVA: 0x004820CC File Offset: 0x004802CC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0601160B RID: 71179 RVA: 0x004820D8 File Offset: 0x004802D8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0601160C RID: 71180 RVA: 0x004820E4 File Offset: 0x004802E4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601160D RID: 71181 RVA: 0x004820EC File Offset: 0x004802EC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0601160E RID: 71182 RVA: 0x004820F4 File Offset: 0x004802F4
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0601160F RID: 71183 RVA: 0x004820FC File Offset: 0x004802FC
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06011610 RID: 71184 RVA: 0x00482104 File Offset: 0x00480304
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06011611 RID: 71185 RVA: 0x0048210C File Offset: 0x0048030C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06011612 RID: 71186 RVA: 0x00482114 File Offset: 0x00480314
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06011613 RID: 71187 RVA: 0x0048211C File Offset: 0x0048031C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06011614 RID: 71188 RVA: 0x00482128 File Offset: 0x00480328
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06011615 RID: 71189 RVA: 0x00482134 File Offset: 0x00480334
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06011616 RID: 71190 RVA: 0x00482140 File Offset: 0x00480340
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06011617 RID: 71191 RVA: 0x0048214C File Offset: 0x0048034C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06011618 RID: 71192 RVA: 0x00482154 File Offset: 0x00480354
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06011619 RID: 71193 RVA: 0x0048215C File Offset: 0x0048035C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0601161A RID: 71194 RVA: 0x00482164 File Offset: 0x00480364
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0601161B RID: 71195 RVA: 0x0048216C File Offset: 0x0048036C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0601161C RID: 71196 RVA: 0x00482174 File Offset: 0x00480374
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0601161F RID: 71199 RVA: 0x00482248 File Offset: 0x00480448
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_AutoGetStarReward_hotfix = (luaObj.RawGet("AutoGetStarReward") as LuaFunction);
					this.m_PlayerResourceUIController_OnAddCrystal_hotfix = (luaObj.RawGet("PlayerResourceUIController_OnAddCrystal") as LuaFunction);
					this.m_HeroDungeonUIController_OnReturn_hotfix = (luaObj.RawGet("HeroDungeonUIController_OnReturn") as LuaFunction);
					this.m_HeroDungeonUIController_OnShowHelp_hotfix = (luaObj.RawGet("HeroDungeonUIController_OnShowHelp") as LuaFunction);
					this.m_HeroDungeonUIController_OnGetStarRewardInt32_hotfix = (luaObj.RawGet("HeroDungeonUIController_OnGetStarReward") as LuaFunction);
					this.m_HeroDungeonUIController_OnSelectDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("HeroDungeonUIController_OnSelectDungeonLevel") as LuaFunction);
					this.m_StartHeroDungeonLevelInfoUITaskConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("StartHeroDungeonLevelInfoUITask") as LuaFunction);
					this.m_BattleLevelInfoUITask_OnClose_hotfix = (luaObj.RawGet("BattleLevelInfoUITask_OnClose") as LuaFunction);
					this.m_BattleLevelInfoUITask_OnHeroDungeonRaidCompleteInt32_hotfix = (luaObj.RawGet("BattleLevelInfoUITask_OnHeroDungeonRaidComplete") as LuaFunction);
					this.m_ChestUITask_OnStopTask_hotfix = (luaObj.RawGet("ChestUITask_OnStop") as LuaFunction);
					this.m_ChestUITask_OnClose_hotfix = (luaObj.RawGet("ChestUITask_OnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011620 RID: 71200 RVA: 0x00482520 File Offset: 0x00480720
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009F02 RID: 40706
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroDungeonUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Fetters_ABS/Prefab/FettersHeroDungeonUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04009F03 RID: 40707
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroDungeonUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroDungeonUIController"),
				m_ctrlName = "HeroDungeonUIContrller"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroDungeonUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "PlayerResourceUIController"
			}
		};

		// Token: 0x04009F04 RID: 40708
		private HeroDungeonUIController m_heroDungeonUIController;

		// Token: 0x04009F05 RID: 40709
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x04009F06 RID: 40710
		private BattleLevelInfoUITask m_battleLevelInfoUITask;

		// Token: 0x04009F07 RID: 40711
		private ChestUITask m_chestUITask;

		// Token: 0x04009F08 RID: 40712
		private ConfigDataHeroInformationInfo m_heroInformationInfo;

		// Token: 0x04009F09 RID: 40713
		private ConfigDataHeroDungeonLevelInfo m_heroDungeonLevelInfo;

		// Token: 0x04009F0A RID: 40714
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04009F0B RID: 40715
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04009F0C RID: 40716
		[DoNotToLua]
		private HeroDungeonUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009F0D RID: 40717
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009F0E RID: 40718
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009F0F RID: 40719
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04009F10 RID: 40720
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04009F11 RID: 40721
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04009F12 RID: 40722
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04009F13 RID: 40723
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04009F14 RID: 40724
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04009F15 RID: 40725
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04009F16 RID: 40726
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009F17 RID: 40727
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04009F18 RID: 40728
		private LuaFunction m_AutoGetStarReward_hotfix;

		// Token: 0x04009F19 RID: 40729
		private LuaFunction m_PlayerResourceUIController_OnAddCrystal_hotfix;

		// Token: 0x04009F1A RID: 40730
		private LuaFunction m_HeroDungeonUIController_OnReturn_hotfix;

		// Token: 0x04009F1B RID: 40731
		private LuaFunction m_HeroDungeonUIController_OnShowHelp_hotfix;

		// Token: 0x04009F1C RID: 40732
		private LuaFunction m_HeroDungeonUIController_OnGetStarRewardInt32_hotfix;

		// Token: 0x04009F1D RID: 40733
		private LuaFunction m_HeroDungeonUIController_OnSelectDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x04009F1E RID: 40734
		private LuaFunction m_StartHeroDungeonLevelInfoUITaskConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x04009F1F RID: 40735
		private LuaFunction m_BattleLevelInfoUITask_OnClose_hotfix;

		// Token: 0x04009F20 RID: 40736
		private LuaFunction m_BattleLevelInfoUITask_OnHeroDungeonRaidCompleteInt32_hotfix;

		// Token: 0x04009F21 RID: 40737
		private LuaFunction m_ChestUITask_OnStopTask_hotfix;

		// Token: 0x04009F22 RID: 40738
		private LuaFunction m_ChestUITask_OnClose_hotfix;

		// Token: 0x04009F23 RID: 40739
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04009F24 RID: 40740
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E1B RID: 3611
		public new class LuaExportHelper
		{
			// Token: 0x06011621 RID: 71201 RVA: 0x00482588 File Offset: 0x00480788
			public LuaExportHelper(HeroDungeonUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011622 RID: 71202 RVA: 0x00482598 File Offset: 0x00480798
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06011623 RID: 71203 RVA: 0x004825A8 File Offset: 0x004807A8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06011624 RID: 71204 RVA: 0x004825B8 File Offset: 0x004807B8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06011625 RID: 71205 RVA: 0x004825C8 File Offset: 0x004807C8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06011626 RID: 71206 RVA: 0x004825D8 File Offset: 0x004807D8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06011627 RID: 71207 RVA: 0x004825E8 File Offset: 0x004807E8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06011628 RID: 71208 RVA: 0x004825F8 File Offset: 0x004807F8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06011629 RID: 71209 RVA: 0x00482608 File Offset: 0x00480808
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0601162A RID: 71210 RVA: 0x00482618 File Offset: 0x00480818
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0601162B RID: 71211 RVA: 0x00482628 File Offset: 0x00480828
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0601162C RID: 71212 RVA: 0x00482638 File Offset: 0x00480838
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0601162D RID: 71213 RVA: 0x00482648 File Offset: 0x00480848
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0601162E RID: 71214 RVA: 0x00482658 File Offset: 0x00480858
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0601162F RID: 71215 RVA: 0x00482668 File Offset: 0x00480868
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06011630 RID: 71216 RVA: 0x00482678 File Offset: 0x00480878
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06011631 RID: 71217 RVA: 0x00482688 File Offset: 0x00480888
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06011632 RID: 71218 RVA: 0x00482698 File Offset: 0x00480898
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06011633 RID: 71219 RVA: 0x004826A8 File Offset: 0x004808A8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06011634 RID: 71220 RVA: 0x004826B8 File Offset: 0x004808B8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06011635 RID: 71221 RVA: 0x004826C8 File Offset: 0x004808C8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06011636 RID: 71222 RVA: 0x004826D8 File Offset: 0x004808D8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06011637 RID: 71223 RVA: 0x004826E8 File Offset: 0x004808E8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06011638 RID: 71224 RVA: 0x004826F8 File Offset: 0x004808F8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003589 RID: 13705
			// (get) Token: 0x06011639 RID: 71225 RVA: 0x00482708 File Offset: 0x00480908
			// (set) Token: 0x0601163A RID: 71226 RVA: 0x00482718 File Offset: 0x00480918
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x1700358A RID: 13706
			// (get) Token: 0x0601163B RID: 71227 RVA: 0x00482728 File Offset: 0x00480928
			// (set) Token: 0x0601163C RID: 71228 RVA: 0x00482738 File Offset: 0x00480938
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x1700358B RID: 13707
			// (get) Token: 0x0601163D RID: 71229 RVA: 0x00482748 File Offset: 0x00480948
			// (set) Token: 0x0601163E RID: 71230 RVA: 0x00482758 File Offset: 0x00480958
			public HeroDungeonUIController m_heroDungeonUIController
			{
				get
				{
					return this.m_owner.m_heroDungeonUIController;
				}
				set
				{
					this.m_owner.m_heroDungeonUIController = value;
				}
			}

			// Token: 0x1700358C RID: 13708
			// (get) Token: 0x0601163F RID: 71231 RVA: 0x00482768 File Offset: 0x00480968
			// (set) Token: 0x06011640 RID: 71232 RVA: 0x00482778 File Offset: 0x00480978
			public PlayerResourceUIController m_playerResourceUIController
			{
				get
				{
					return this.m_owner.m_playerResourceUIController;
				}
				set
				{
					this.m_owner.m_playerResourceUIController = value;
				}
			}

			// Token: 0x1700358D RID: 13709
			// (get) Token: 0x06011641 RID: 71233 RVA: 0x00482788 File Offset: 0x00480988
			// (set) Token: 0x06011642 RID: 71234 RVA: 0x00482798 File Offset: 0x00480998
			public BattleLevelInfoUITask m_battleLevelInfoUITask
			{
				get
				{
					return this.m_owner.m_battleLevelInfoUITask;
				}
				set
				{
					this.m_owner.m_battleLevelInfoUITask = value;
				}
			}

			// Token: 0x1700358E RID: 13710
			// (get) Token: 0x06011643 RID: 71235 RVA: 0x004827A8 File Offset: 0x004809A8
			// (set) Token: 0x06011644 RID: 71236 RVA: 0x004827B8 File Offset: 0x004809B8
			public ChestUITask m_chestUITask
			{
				get
				{
					return this.m_owner.m_chestUITask;
				}
				set
				{
					this.m_owner.m_chestUITask = value;
				}
			}

			// Token: 0x1700358F RID: 13711
			// (get) Token: 0x06011645 RID: 71237 RVA: 0x004827C8 File Offset: 0x004809C8
			// (set) Token: 0x06011646 RID: 71238 RVA: 0x004827D8 File Offset: 0x004809D8
			public ConfigDataHeroInformationInfo m_heroInformationInfo
			{
				get
				{
					return this.m_owner.m_heroInformationInfo;
				}
				set
				{
					this.m_owner.m_heroInformationInfo = value;
				}
			}

			// Token: 0x17003590 RID: 13712
			// (get) Token: 0x06011647 RID: 71239 RVA: 0x004827E8 File Offset: 0x004809E8
			// (set) Token: 0x06011648 RID: 71240 RVA: 0x004827F8 File Offset: 0x004809F8
			public ConfigDataHeroDungeonLevelInfo m_heroDungeonLevelInfo
			{
				get
				{
					return this.m_owner.m_heroDungeonLevelInfo;
				}
				set
				{
					this.m_owner.m_heroDungeonLevelInfo = value;
				}
			}

			// Token: 0x17003591 RID: 13713
			// (get) Token: 0x06011649 RID: 71241 RVA: 0x00482808 File Offset: 0x00480A08
			// (set) Token: 0x0601164A RID: 71242 RVA: 0x00482818 File Offset: 0x00480A18
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

			// Token: 0x17003592 RID: 13714
			// (get) Token: 0x0601164B RID: 71243 RVA: 0x00482828 File Offset: 0x00480A28
			// (set) Token: 0x0601164C RID: 71244 RVA: 0x00482838 File Offset: 0x00480A38
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17003593 RID: 13715
			// (get) Token: 0x0601164D RID: 71245 RVA: 0x00482848 File Offset: 0x00480A48
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003594 RID: 13716
			// (get) Token: 0x0601164E RID: 71246 RVA: 0x00482858 File Offset: 0x00480A58
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0601164F RID: 71247 RVA: 0x00482868 File Offset: 0x00480A68
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06011650 RID: 71248 RVA: 0x00482878 File Offset: 0x00480A78
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06011651 RID: 71249 RVA: 0x00482888 File Offset: 0x00480A88
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x06011652 RID: 71250 RVA: 0x00482898 File Offset: 0x00480A98
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06011653 RID: 71251 RVA: 0x004828A8 File Offset: 0x00480AA8
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06011654 RID: 71252 RVA: 0x004828B8 File Offset: 0x00480AB8
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x06011655 RID: 71253 RVA: 0x004828C8 File Offset: 0x00480AC8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06011656 RID: 71254 RVA: 0x004828D8 File Offset: 0x00480AD8
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06011657 RID: 71255 RVA: 0x004828E8 File Offset: 0x00480AE8
			public void AutoGetStarReward()
			{
				this.m_owner.AutoGetStarReward();
			}

			// Token: 0x06011658 RID: 71256 RVA: 0x004828F8 File Offset: 0x00480AF8
			public void PlayerResourceUIController_OnAddCrystal()
			{
				this.m_owner.PlayerResourceUIController_OnAddCrystal();
			}

			// Token: 0x06011659 RID: 71257 RVA: 0x00482908 File Offset: 0x00480B08
			public void HeroDungeonUIController_OnReturn()
			{
				this.m_owner.HeroDungeonUIController_OnReturn();
			}

			// Token: 0x0601165A RID: 71258 RVA: 0x00482918 File Offset: 0x00480B18
			public void HeroDungeonUIController_OnShowHelp()
			{
				this.m_owner.HeroDungeonUIController_OnShowHelp();
			}

			// Token: 0x0601165B RID: 71259 RVA: 0x00482928 File Offset: 0x00480B28
			public void HeroDungeonUIController_OnGetStarReward(int index)
			{
				this.m_owner.HeroDungeonUIController_OnGetStarReward(index);
			}

			// Token: 0x0601165C RID: 71260 RVA: 0x00482938 File Offset: 0x00480B38
			public void HeroDungeonUIController_OnSelectDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo)
			{
				this.m_owner.HeroDungeonUIController_OnSelectDungeonLevel(levelInfo);
			}

			// Token: 0x0601165D RID: 71261 RVA: 0x00482948 File Offset: 0x00480B48
			public void StartHeroDungeonLevelInfoUITask(ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo)
			{
				this.m_owner.StartHeroDungeonLevelInfoUITask(heroDungeonLevelInfo);
			}

			// Token: 0x0601165E RID: 71262 RVA: 0x00482958 File Offset: 0x00480B58
			public void BattleLevelInfoUITask_OnClose()
			{
				this.m_owner.BattleLevelInfoUITask_OnClose();
			}

			// Token: 0x0601165F RID: 71263 RVA: 0x00482968 File Offset: 0x00480B68
			public void BattleLevelInfoUITask_OnHeroDungeonRaidComplete(int levelId)
			{
				this.m_owner.BattleLevelInfoUITask_OnHeroDungeonRaidComplete(levelId);
			}

			// Token: 0x06011660 RID: 71264 RVA: 0x00482978 File Offset: 0x00480B78
			public void ChestUITask_OnStop(Task task)
			{
				this.m_owner.ChestUITask_OnStop(task);
			}

			// Token: 0x06011661 RID: 71265 RVA: 0x00482988 File Offset: 0x00480B88
			public void ChestUITask_OnClose()
			{
				this.m_owner.ChestUITask_OnClose();
			}

			// Token: 0x04009F25 RID: 40741
			private HeroDungeonUITask m_owner;
		}
	}
}
