using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EEC RID: 3820
	[HotFix]
	public class RiftUITask : UITask
	{
		// Token: 0x06012D21 RID: 77089 RVA: 0x004CF30C File Offset: 0x004CD50C
		public RiftUITask(string name) : base(name)
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

		// Token: 0x06012D22 RID: 77090 RVA: 0x004CF540 File Offset: 0x004CD740
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
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				ConfigDataRiftChapterInfo classParam = uiintentCustom.GetClassParam<ConfigDataRiftChapterInfo>("ChapterInfo");
				this.m_needReturnToChapter = uiintentCustom.GetStructParam<bool>("RiftNeedReturnToChapter");
				if (classParam != null)
				{
					this.m_chapterInfo = classParam;
					this.m_viewState = RiftUITask.ViewState.RiftLevel;
					this.m_needPlayRiftLevelOpenAnimation = true;
					uiintentCustom.SetParam("ChapterInfo", null);
				}
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			base.ClearAssetList();
			if (this.m_viewState == RiftUITask.ViewState.Chapter)
			{
				foreach (KeyValuePair<int, ConfigDataRiftChapterInfo> keyValuePair in configDataLoader.GetAllConfigDataRiftChapterInfo())
				{
					base.CollectSpriteAsset(keyValuePair.Value.Image);
				}
			}
			else if (this.m_viewState == RiftUITask.ViewState.RiftLevel && this.m_chapterInfo != null)
			{
				foreach (ConfigDataRiftLevelInfo configDataRiftLevelInfo in this.m_chapterInfo.m_levelInfos)
				{
					base.CollectSpriteAsset(configDataRiftLevelInfo.Icon);
				}
				base.CollectAsset(this.m_chapterInfo.ChapterBGPrefabName);
				foreach (Goods goods in this.m_chapterInfo.Reward1)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
				}
				foreach (Goods goods2 in this.m_chapterInfo.Reward2)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods2.GoodsType, goods2.Id));
				}
				foreach (Goods goods3 in this.m_chapterInfo.Reward3)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods3.GoodsType, goods3.Id));
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06012D23 RID: 77091 RVA: 0x004CF81C File Offset: 0x004CDA1C
		protected override void InitLayerStateOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLayerStateOnLoadAllResCompleted_hotfix != null)
			{
				this.m_InitLayerStateOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitLayerStateOnLoadAllResCompleted();
			foreach (SceneLayerBase sceneLayerBase in this.m_layerArray)
			{
				if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase);
				}
			}
		}

		// Token: 0x06012D24 RID: 77092 RVA: 0x004CF8BC File Offset: 0x004CDABC
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
			this.InitRiftBackgroundUIController();
			this.InitRiftChapterUIController();
			this.InitRiftLevelUIController();
			UIUtility.ActivateLayer(this.m_riftLevelUIController, false);
		}

		// Token: 0x06012D25 RID: 77093 RVA: 0x004CF940 File Offset: 0x004CDB40
		private void InitRiftBackgroundUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRiftBackgroundUIController_hotfix != null)
			{
				this.m_InitRiftBackgroundUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_riftBackgroundUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_riftBackgroundUIController = (this.m_uiCtrlArray[0] as RiftBackgroundUIController);
				}
				if (!(this.m_riftBackgroundUIController != null))
				{
					Debug.LogError("RiftBackgroundController is null");
					return;
				}
			}
		}

		// Token: 0x06012D26 RID: 77094 RVA: 0x004CF9F4 File Offset: 0x004CDBF4
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
			this.UninitRiftChapterUIController();
			this.UninitRiftLevelUIController();
		}

		// Token: 0x06012D27 RID: 77095 RVA: 0x004CFA68 File Offset: 0x004CDC68
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

		// Token: 0x06012D28 RID: 77096 RVA: 0x004CFAD0 File Offset: 0x004CDCD0
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
			if (this.m_viewState == RiftUITask.ViewState.Chapter)
			{
				UIUtility.ActivateLayer(this.m_riftChapterUIController, true);
				UIUtility.ActivateLayer(this.m_riftLevelUIController, false);
				this.UpdateChapters();
				this.m_riftBackgroundUIController.SetHardMode(false);
			}
			else if (this.m_viewState == RiftUITask.ViewState.RiftLevel && this.m_chapterInfo != null)
			{
				UIUtility.ActivateLayer(this.m_riftChapterUIController, false);
				UIUtility.ActivateLayer(this.m_riftLevelUIController, true);
				this.UpdateRiftLevels();
				flag = true;
				this.m_riftBackgroundUIController.SetHardMode(this.m_chapterInfo.Hard != 1);
			}
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				ConfigDataRiftLevelInfo classParam = uiintentCustom.GetClassParam<ConfigDataRiftLevelInfo>("RiftLevelInfo");
				NeedGoods classParam2 = uiintentCustom.GetClassParam<NeedGoods>("RaidNeedGoods");
				if (classParam != null)
				{
					uiintentCustom.SetParam("RiftLevelInfo", null);
					flag = false;
					this.RiftLevelUIController_OnSelectRiftLevel(classParam, classParam2);
				}
			}
			if (flag)
			{
				this.AutoGetStarReward();
			}
		}

		// Token: 0x06012D29 RID: 77097 RVA: 0x004CFC14 File Offset: 0x004CDE14
		private void PlayerResourceUIController_OnAddGold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerResourceUIController_OnAddGold_hotfix != null)
			{
				this.m_PlayerResourceUIController_OnAddGold_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Crystal, null, false);
		}

		// Token: 0x06012D2A RID: 77098 RVA: 0x004CFC8C File Offset: 0x004CDE8C
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

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x06012D2B RID: 77099 RVA: 0x004CFD04 File Offset: 0x004CDF04
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

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x06012D2C RID: 77100 RVA: 0x004CFD78 File Offset: 0x004CDF78
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

		// Token: 0x06012D2D RID: 77101 RVA: 0x004CFDEC File Offset: 0x004CDFEC
		private void InitRiftChapterUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRiftChapterUIController_hotfix != null)
			{
				this.m_InitRiftChapterUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_riftChapterUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_riftChapterUIController = (this.m_uiCtrlArray[1] as RiftChapterUIController);
				}
				if (!(this.m_riftChapterUIController != null))
				{
					Debug.LogError("RiftChapterUIController is null");
					return;
				}
				this.m_riftChapterUIController.EventOnReturn += this.RiftChapterUIController_OnReturn;
				this.m_riftChapterUIController.EventOnShowHelp += this.RiftChapterUIController_OnShowHelp;
				this.m_riftChapterUIController.EventOnReturnToWorld += this.RiftChapterUIController_OnReturnToWorld;
				this.m_riftChapterUIController.EventOnSelectChapter += this.RiftChapterUIController_OnSelectChapter;
				this.m_riftChapterUIController.EventOnSwitchChapter += this.RiftChapterUIController_OnSwitchChapter;
				this.m_riftChapterUIController.EventOnGoToScenario += this.RiftChapterUIController_OnGoToScenario;
			}
			if (this.m_riftChapterPlayerResourceUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 3)
				{
					this.m_riftChapterPlayerResourceUIController = (this.m_uiCtrlArray[3] as PlayerResourceUIController);
				}
				if (!(this.m_riftChapterPlayerResourceUIController != null))
				{
					Debug.LogError("PlayerResourceUIController is null");
					return;
				}
				this.m_riftChapterPlayerResourceUIController.EventOnAddGold += this.PlayerResourceUIController_OnAddGold;
				this.m_riftChapterPlayerResourceUIController.EventOnAddCrystal += this.PlayerResourceUIController_OnAddCrystal;
			}
		}

		// Token: 0x06012D2E RID: 77102 RVA: 0x004CFFAC File Offset: 0x004CE1AC
		private void UninitRiftChapterUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitRiftChapterUIController_hotfix != null)
			{
				this.m_UninitRiftChapterUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_riftChapterUIController != null)
			{
				this.m_riftChapterUIController.EventOnReturn -= this.RiftChapterUIController_OnReturn;
				this.m_riftChapterUIController.EventOnShowHelp -= this.RiftChapterUIController_OnShowHelp;
				this.m_riftChapterUIController.EventOnSelectChapter -= this.RiftChapterUIController_OnSelectChapter;
				this.m_riftChapterUIController.EventOnSwitchChapter -= this.RiftChapterUIController_OnSwitchChapter;
				this.m_riftChapterUIController.EventOnGoToScenario -= this.RiftChapterUIController_OnGoToScenario;
				this.m_riftChapterUIController = null;
			}
			if (this.m_riftChapterPlayerResourceUIController != null)
			{
				this.m_riftChapterPlayerResourceUIController.EventOnAddGold -= this.PlayerResourceUIController_OnAddGold;
				this.m_riftChapterPlayerResourceUIController.EventOnAddCrystal -= this.PlayerResourceUIController_OnAddCrystal;
				this.m_riftChapterPlayerResourceUIController = null;
			}
		}

		// Token: 0x06012D2F RID: 77103 RVA: 0x004D00E0 File Offset: 0x004CE2E0
		private void UpdateChapters()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateChapters_hotfix != null)
			{
				this.m_UpdateChapters_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_riftChapterUIController.Open();
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = null;
			ConfigDataRiftChapterInfo configDataRiftChapterInfo2 = null;
			this.m_riftChapterUIController.ClearChapterButtons();
			foreach (KeyValuePair<int, ConfigDataRiftChapterInfo> keyValuePair in configDataLoader.GetAllConfigDataRiftChapterInfo())
			{
				if (keyValuePair.Value.Hard == 1)
				{
					bool flag = projectLPlayerContext.CanUnlockRiftChapter(keyValuePair.Value.ID) != 0;
					bool newChapter = true;
					if (configDataRiftChapterInfo == null)
					{
						configDataRiftChapterInfo = keyValuePair.Value;
					}
					if (flag)
					{
						newChapter = false;
					}
					else
					{
						if (configDataRiftChapterInfo2 == null)
						{
							configDataRiftChapterInfo2 = keyValuePair.Value;
						}
						foreach (int levelId in keyValuePair.Value.RiftLevels_ID)
						{
							if (projectLPlayerContext.IsRiftLevelChallenged(levelId))
							{
								newChapter = false;
								configDataRiftChapterInfo2 = keyValuePair.Value;
								break;
							}
						}
					}
					this.m_riftChapterUIController.AddChapterButton(keyValuePair.Value, flag, newChapter);
				}
			}
			ConfigDataRiftChapterInfo configDataRiftChapterInfo3 = null;
			if (this.m_chapterInfo != null)
			{
				if (this.m_chapterInfo.Hard == 1)
				{
					configDataRiftChapterInfo3 = this.m_chapterInfo;
				}
				else
				{
					configDataRiftChapterInfo3 = this.m_chapterInfo.m_hardChapterInfo;
				}
			}
			if (configDataRiftChapterInfo3 == null)
			{
				configDataRiftChapterInfo3 = configDataRiftChapterInfo2;
			}
			if (configDataRiftChapterInfo3 == null)
			{
				configDataRiftChapterInfo3 = configDataRiftChapterInfo;
			}
			if (configDataRiftChapterInfo3 != null)
			{
				this.m_riftChapterUIController.SetCurrentChapter(configDataRiftChapterInfo3);
				this.RiftChapterUIController_OnSwitchChapter(configDataRiftChapterInfo3);
			}
			this.m_riftChapterPlayerResourceUIController.UpdatePlayerResource();
		}

		// Token: 0x06012D30 RID: 77104 RVA: 0x004D0318 File Offset: 0x004CE518
		private void ShowChapterProgress(ConfigDataRiftChapterInfo chapterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChapterProgressConfigDataRiftChapterInfo_hotfix != null)
			{
				this.m_ShowChapterProgressConfigDataRiftChapterInfo_hotfix.call(new object[]
				{
					this,
					chapterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int normalStarCount = 0;
			int normalStarCountMax = 0;
			int normalAchivementCount = 0;
			int normalAchievementCountMax = 0;
			int normalTreasureCount = 0;
			int normalTreasureCountMax = 0;
			int hardStarCount = 0;
			int hardStarCountMax = 0;
			int hardAchivementCount = 0;
			int hardAchievementCountMax = 0;
			int hardTreasureCount = 0;
			int hardTreasureCountMax = 0;
			ConfigDataRiftChapterInfo configDataRiftChapterInfo;
			ConfigDataRiftChapterInfo configDataRiftChapterInfo2;
			if (chapterInfo.Hard == 1)
			{
				configDataRiftChapterInfo = chapterInfo;
				configDataRiftChapterInfo2 = chapterInfo.m_hardChapterInfo;
			}
			else
			{
				configDataRiftChapterInfo = chapterInfo.m_hardChapterInfo;
				configDataRiftChapterInfo2 = chapterInfo;
			}
			if (configDataRiftChapterInfo != null)
			{
				normalStarCount = projectLPlayerContext.GetRiftChapterTotalStars(chapterInfo.ID);
				normalStarCountMax = projectLPlayerContext.GetRiftChapterTotalStarsMax(chapterInfo.ID);
				normalAchivementCount = projectLPlayerContext.GetRiftChapterTotalAchievementCount(chapterInfo.ID);
				normalAchievementCountMax = projectLPlayerContext.GetRiftChapterTotalAchievementCountMax(chapterInfo.ID);
				normalTreasureCount = projectLPlayerContext.GetRiftChapterTotalBattleTreasureCount(chapterInfo.ID);
				normalTreasureCountMax = projectLPlayerContext.GetRiftChapterTotalBattleTreasureCountMax(chapterInfo.ID);
			}
			if (configDataRiftChapterInfo2 != null)
			{
				hardStarCount = projectLPlayerContext.GetRiftChapterTotalStars(configDataRiftChapterInfo2.ID);
				hardStarCountMax = projectLPlayerContext.GetRiftChapterTotalStarsMax(configDataRiftChapterInfo2.ID);
				hardAchivementCount = projectLPlayerContext.GetRiftChapterTotalAchievementCount(configDataRiftChapterInfo2.ID);
				hardAchievementCountMax = projectLPlayerContext.GetRiftChapterTotalAchievementCountMax(configDataRiftChapterInfo2.ID);
				hardTreasureCount = projectLPlayerContext.GetRiftChapterTotalBattleTreasureCount(configDataRiftChapterInfo2.ID);
				hardTreasureCountMax = projectLPlayerContext.GetRiftChapterTotalBattleTreasureCountMax(configDataRiftChapterInfo2.ID);
			}
			this.m_riftChapterUIController.ShowChapterProgress(chapterInfo, normalStarCount, normalStarCountMax, normalAchivementCount, normalAchievementCountMax, normalTreasureCount, normalTreasureCountMax, hardStarCount, hardStarCountMax, hardAchivementCount, hardAchievementCountMax, hardTreasureCount, hardTreasureCountMax);
		}

		// Token: 0x06012D31 RID: 77105 RVA: 0x004D04BC File Offset: 0x004CE6BC
		private void HideChapterProgress(ConfigDataRiftChapterInfo chapterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideChapterProgressConfigDataRiftChapterInfo_hotfix != null)
			{
				this.m_HideChapterProgressConfigDataRiftChapterInfo_hotfix.call(new object[]
				{
					this,
					chapterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_riftChapterUIController.HideChapterProgress();
		}

		// Token: 0x06012D32 RID: 77106 RVA: 0x004D0538 File Offset: 0x004CE738
		private void SelectChapter(ConfigDataRiftChapterInfo chapterInfo, bool playOpenAnim)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectChapterConfigDataRiftChapterInfoBoolean_hotfix != null)
			{
				this.m_SelectChapterConfigDataRiftChapterInfoBoolean_hotfix.call(new object[]
				{
					this,
					chapterInfo,
					playOpenAnim
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanUnlockRiftChapter(chapterInfo.ID);
			if (num == 0)
			{
				this.m_chapterInfo = chapterInfo;
				this.m_viewState = RiftUITask.ViewState.RiftLevel;
				this.m_needReturnToChapter = true;
				this.m_needPlayRiftLevelOpenAnimation = playOpenAnim;
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else if (num == -826)
			{
				this.m_chapterInfo = null;
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_NotOpenNow, 2f, null, true);
			}
			else
			{
				this.m_chapterInfo = null;
				this.m_riftChapterUIController.ShowChapterUnlockConditions(chapterInfo);
			}
		}

		// Token: 0x06012D33 RID: 77107 RVA: 0x004D0648 File Offset: 0x004CE848
		private void RiftChapterUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftChapterUIController_OnReturn_hotfix != null)
			{
				this.m_RiftChapterUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_viewState = RiftUITask.ViewState.Chapter;
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x06012D34 RID: 77108 RVA: 0x004D06CC File Offset: 0x004CE8CC
		private void RiftChapterUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftChapterUIController_OnShowHelp_hotfix != null)
			{
				this.m_RiftChapterUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Rift);
		}

		// Token: 0x06012D35 RID: 77109 RVA: 0x004D0738 File Offset: 0x004CE938
		private void RiftChapterUIController_OnReturnToWorld()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftChapterUIController_OnReturnToWorld_hotfix != null)
			{
				this.m_RiftChapterUIController_OnReturnToWorld_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_viewState = RiftUITask.ViewState.Chapter;
				base.Pause();
				UIManager.Instance.ReturnUITaskWithTaskName(typeof(WorldUITask).Name);
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x06012D36 RID: 77110 RVA: 0x004D07BC File Offset: 0x004CE9BC
		protected void RiftChapterUIController_OnSelectChapter(ConfigDataRiftChapterInfo chapterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftChapterUIController_OnSelectChapterConfigDataRiftChapterInfo_hotfix != null)
			{
				this.m_RiftChapterUIController_OnSelectChapterConfigDataRiftChapterInfo_hotfix.call(new object[]
				{
					this,
					chapterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SelectChapter(chapterInfo, true);
		}

		// Token: 0x06012D37 RID: 77111 RVA: 0x004D0834 File Offset: 0x004CEA34
		private void RiftChapterUIController_OnSwitchChapter(ConfigDataRiftChapterInfo chapterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftChapterUIController_OnSwitchChapterConfigDataRiftChapterInfo_hotfix != null)
			{
				this.m_RiftChapterUIController_OnSwitchChapterConfigDataRiftChapterInfo_hotfix.call(new object[]
				{
					this,
					chapterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CanUnlockRiftChapter(chapterInfo.ID) == 0)
			{
				this.ShowChapterProgress(chapterInfo);
			}
			else
			{
				this.HideChapterProgress(chapterInfo);
			}
		}

		// Token: 0x06012D38 RID: 77112 RVA: 0x004D08D8 File Offset: 0x004CEAD8
		private void RiftChapterUIController_OnGoToScenario(int scenarioID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftChapterUIController_OnGoToScenarioInt32_hotfix != null)
			{
				this.m_RiftChapterUIController_OnGoToScenarioInt32_hotfix.call(new object[]
				{
					this,
					scenarioID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanUnlockScenario(scenarioID);
			if (num == 0)
			{
				this.m_riftChapterUIController.SetChapterUnlockConditionClose();
				this.RiftChapterUIController_OnReturn();
				if (this.EventOnGoToScenario != null)
				{
					this.EventOnGoToScenario(scenarioID);
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06012D39 RID: 77113 RVA: 0x004D09A8 File Offset: 0x004CEBA8
		private void InitRiftLevelUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRiftLevelUIController_hotfix != null)
			{
				this.m_InitRiftLevelUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_riftLevelUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 2)
				{
					this.m_riftLevelUIController = (this.m_uiCtrlArray[2] as RiftLevelUIController);
				}
				if (!(this.m_riftLevelUIController != null))
				{
					Debug.LogError("RiftLevelUIController is null");
					return;
				}
				this.m_riftLevelUIController.EventOnReturn += this.RiftLevelUIController_OnReturn;
				this.m_riftLevelUIController.EventOnShowHelp += this.RiftLevelUIController_OnShowHelp;
				this.m_riftLevelUIController.EventOnReturnToWorld += this.RiftLevelUIController_OnReturnToWorld;
				this.m_riftLevelUIController.EventOnChangeHard += this.RiftLevelUIController_OnChangeHard;
				this.m_riftLevelUIController.EventOnSelectRiftLevel += this.RiftLevelUIController_OnSelectRiftLevel;
				this.m_riftLevelUIController.EventOnGetStarReward += this.RiftLevelUIController_OnGetStarReward;
				this.m_riftLevelUIController.EventOnGoToScenario += this.RiftLevelUIController_OnGoToScenario;
				this.m_riftLevelUIController.EventOnSelectChapter += this.RiftChapterUIController_OnSelectChapter;
			}
			if (this.m_riftLevelPlayerResourceUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 4)
				{
					this.m_riftLevelPlayerResourceUIController = (this.m_uiCtrlArray[4] as PlayerResourceUIController);
				}
				if (!(this.m_riftLevelPlayerResourceUIController != null))
				{
					Debug.LogError("PlayerResourceUIController is null");
					return;
				}
				this.m_riftLevelPlayerResourceUIController.EventOnAddGold += this.PlayerResourceUIController_OnAddGold;
				this.m_riftLevelPlayerResourceUIController.EventOnAddCrystal += this.PlayerResourceUIController_OnAddCrystal;
			}
		}

		// Token: 0x06012D3A RID: 77114 RVA: 0x004D0B94 File Offset: 0x004CED94
		private void UninitRiftLevelUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitRiftLevelUIController_hotfix != null)
			{
				this.m_UninitRiftLevelUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_riftLevelUIController != null)
			{
				this.m_riftLevelUIController.EventOnReturn -= this.RiftLevelUIController_OnReturn;
				this.m_riftLevelUIController.EventOnShowHelp -= this.RiftLevelUIController_OnShowHelp;
				this.m_riftLevelUIController.EventOnReturnToWorld -= this.RiftLevelUIController_OnReturnToWorld;
				this.m_riftLevelUIController.EventOnChangeHard -= this.RiftLevelUIController_OnChangeHard;
				this.m_riftLevelUIController.EventOnSelectRiftLevel -= this.RiftLevelUIController_OnSelectRiftLevel;
				this.m_riftLevelUIController.EventOnGetStarReward -= this.RiftLevelUIController_OnGetStarReward;
				this.m_riftLevelUIController.EventOnGoToScenario -= this.RiftLevelUIController_OnGoToScenario;
				this.m_riftLevelUIController.EventOnSelectChapter -= this.RiftChapterUIController_OnSelectChapter;
				this.m_riftLevelUIController = null;
			}
			if (this.m_riftLevelPlayerResourceUIController != null)
			{
				this.m_riftLevelPlayerResourceUIController.EventOnAddGold -= this.PlayerResourceUIController_OnAddGold;
				this.m_riftLevelPlayerResourceUIController.EventOnAddCrystal -= this.PlayerResourceUIController_OnAddCrystal;
				this.m_riftLevelPlayerResourceUIController = null;
			}
		}

		// Token: 0x06012D3B RID: 77115 RVA: 0x004D0D0C File Offset: 0x004CEF0C
		private void UpdateRiftLevels()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRiftLevels_hotfix != null)
			{
				this.m_UpdateRiftLevels_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chapterInfo == null)
			{
				return;
			}
			if (this.m_needPlayRiftLevelOpenAnimation)
			{
				this.m_riftLevelUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool canSwitchHard = this.m_chapterInfo.m_hardChapterInfo != null && projectLPlayerContext.CanUnlockRiftChapter(this.m_chapterInfo.m_hardChapterInfo.ID) == 0;
			this.m_riftLevelUIController.SetChapter(this.m_chapterInfo, canSwitchHard);
			this.UpdateStarReward(this.m_chapterInfo);
			this.m_riftLevelUIController.ClearRiftLevelButtons();
			this.m_riftLevelUIController.ClearEventRiftLevelButtons();
			foreach (ConfigDataRiftLevelInfo configDataRiftLevelInfo in this.m_chapterInfo.m_levelInfos)
			{
				if (configDataRiftLevelInfo.LevelType == RiftLevelType.RiftLevelType_Scenario)
				{
					RiftLevelStatus riftLevelStatus = projectLPlayerContext.GetRiftLevelStatus(configDataRiftLevelInfo.ID);
					int riftLevelCanChallengeNums = projectLPlayerContext.GetRiftLevelCanChallengeNums(configDataRiftLevelInfo);
					int riftLevelCanChallengeMaxNums = projectLPlayerContext.GetRiftLevelCanChallengeMaxNums(configDataRiftLevelInfo);
					bool challenged = projectLPlayerContext.IsRiftLevelChallenged(configDataRiftLevelInfo.ID);
					int riftLevelStars = projectLPlayerContext.GetRiftLevelStars(configDataRiftLevelInfo.ID);
					int riftLevelAchievementCount = projectLPlayerContext.GetRiftLevelAchievementCount(configDataRiftLevelInfo.ID);
					int gainBattleTreasureCount = projectLPlayerContext.GetGainBattleTreasureCount(configDataRiftLevelInfo.m_battleInfo);
					int count = configDataRiftLevelInfo.m_battleInfo.BattleTreasures_ID.Count;
					this.m_riftLevelUIController.AddRiftLevelButton(configDataRiftLevelInfo, riftLevelStatus, riftLevelCanChallengeMaxNums - riftLevelCanChallengeNums, riftLevelCanChallengeMaxNums, challenged, riftLevelStars, riftLevelAchievementCount, gainBattleTreasureCount, count);
				}
				else if (configDataRiftLevelInfo.LevelType == RiftLevelType.RiftLevelType_Event)
				{
					RiftLevelStatus eventRiftLevelStatus = projectLPlayerContext.GetEventRiftLevelStatus(configDataRiftLevelInfo.ID);
					this.m_riftLevelUIController.AddEventRiftLevelButton(configDataRiftLevelInfo, eventRiftLevelStatus);
				}
			}
			if (this.m_chapterInfo.Hard == 2)
			{
				this.m_riftLevelUIController.AddEventRiftLevelDummys();
			}
			this.m_riftLevelPlayerResourceUIController.UpdatePlayerResource();
		}

		// Token: 0x06012D3C RID: 77116 RVA: 0x004D0F14 File Offset: 0x004CF114
		private void UpdateStarReward(ConfigDataRiftChapterInfo chapterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateStarRewardConfigDataRiftChapterInfo_hotfix != null)
			{
				this.m_UpdateStarRewardConfigDataRiftChapterInfo_hotfix.call(new object[]
				{
					this,
					chapterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			for (int i = 0; i < 3; i++)
			{
				int index = i + 1;
				this.m_riftLevelUIController.SetStarRewardStatus(i, projectLPlayerContext.GetRiftChapterStarRewardStatus(chapterInfo.ID, index));
			}
			this.m_riftLevelUIController.SetStarRewardProress(projectLPlayerContext.GetRiftChapterTotalStars(chapterInfo.ID), chapterInfo.Reward3Star);
		}

		// Token: 0x06012D3D RID: 77117 RVA: 0x004D0FE0 File Offset: 0x004CF1E0
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
			if (this.m_chapterInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			for (int i = 1; i <= 3; i++)
			{
				if (projectLPlayerContext.GetRiftChapterStarRewardStatus(this.m_chapterInfo.ID, i) == GainRewardStatus.CanGet)
				{
					this.RiftLevelUIController_OnGetStarReward(i);
					return;
				}
			}
			this.CheckOpenRiftChapterHard(this.m_chapterInfo);
		}

		// Token: 0x06012D3E RID: 77118 RVA: 0x004D109C File Offset: 0x004CF29C
		private bool CheckOpenRiftChapterHard(ConfigDataRiftChapterInfo chapterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckOpenRiftChapterHardConfigDataRiftChapterInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckOpenRiftChapterHardConfigDataRiftChapterInfo_hotfix.call(new object[]
				{
					this,
					chapterInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chapterInfo == null)
			{
				return false;
			}
			if (chapterInfo.Hard != 1)
			{
				return false;
			}
			if (chapterInfo.m_hardChapterInfo == null)
			{
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CheckChangeOpenedRiftChapter(chapterInfo.HardChapter))
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				string txt = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Rift_ChapterOpen), chapterInfo.m_hardChapterInfo.Desc);
				CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
				return true;
			}
			return false;
		}

		// Token: 0x06012D3F RID: 77119 RVA: 0x004D11A0 File Offset: 0x004CF3A0
		private void StartBattleLevelInfoUITask(ConfigDataRiftLevelInfo riftLevelInfo, NeedGoods needGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleLevelInfoUITaskConfigDataRiftLevelInfoNeedGoods_hotfix != null)
			{
				this.m_StartBattleLevelInfoUITaskConfigDataRiftLevelInfoNeedGoods_hotfix.call(new object[]
				{
					this,
					riftLevelInfo,
					needGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (riftLevelInfo == null)
			{
				return;
			}
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(BattleLevelInfoUITask).Name, null);
			uiintentCustom.SetParam("RiftLevelInfo", riftLevelInfo);
			uiintentCustom.SetParam("RaidNeedGoods", needGoods);
			uiintentCustom.SetParam("BattleType", BattleType.Rift);
			BattleLevelInfoUITask battleLevelInfoUITask = UIManager.Instance.StartUITask(uiintentCustom, true, false, null) as BattleLevelInfoUITask;
			if (this.m_battleLevelInfoUITask == null)
			{
				this.m_battleLevelInfoUITask = battleLevelInfoUITask;
				this.m_battleLevelInfoUITask.EventOnClose += this.BattleLevelInfoUITask_OnClose;
				this.m_battleLevelInfoUITask.EventOnRiftRaidComplete += this.BattleLevelInfoUITask_OnRiftRaidComplete;
			}
		}

		// Token: 0x06012D40 RID: 77120 RVA: 0x004D12BC File Offset: 0x004CF4BC
		private void RiftLevelUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftLevelUIController_OnReturn_hotfix != null)
			{
				this.m_RiftLevelUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_needReturnToChapter)
			{
				this.m_viewState = RiftUITask.ViewState.Chapter;
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else
			{
				this.RiftChapterUIController_OnReturn();
			}
		}

		// Token: 0x06012D41 RID: 77121 RVA: 0x004D1344 File Offset: 0x004CF544
		private void RiftLevelUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftLevelUIController_OnShowHelp_hotfix != null)
			{
				this.m_RiftLevelUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Rift);
		}

		// Token: 0x06012D42 RID: 77122 RVA: 0x004D13B0 File Offset: 0x004CF5B0
		private void RiftLevelUIController_OnReturnToWorld()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftLevelUIController_OnReturnToWorld_hotfix != null)
			{
				this.m_RiftLevelUIController_OnReturnToWorld_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RiftChapterUIController_OnReturnToWorld();
		}

		// Token: 0x06012D43 RID: 77123 RVA: 0x004D1418 File Offset: 0x004CF618
		private void RiftLevelUIController_OnChangeHard()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftLevelUIController_OnChangeHard_hotfix != null)
			{
				this.m_RiftLevelUIController_OnChangeHard_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chapterInfo != null && this.m_chapterInfo.m_hardChapterInfo != null)
			{
				this.SelectChapter(this.m_chapterInfo.m_hardChapterInfo, false);
			}
		}

		// Token: 0x06012D44 RID: 77124 RVA: 0x004D14A8 File Offset: 0x004CF6A8
		private void RiftLevelUIController_OnSelectRiftLevel(ConfigDataRiftLevelInfo riftLevelInfo, NeedGoods needGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftLevelUIController_OnSelectRiftLevelConfigDataRiftLevelInfoNeedGoods_hotfix != null)
			{
				this.m_RiftLevelUIController_OnSelectRiftLevelConfigDataRiftLevelInfoNeedGoods_hotfix.call(new object[]
				{
					this,
					riftLevelInfo,
					needGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartBattleLevelInfoUITask(riftLevelInfo, needGoods);
		}

		// Token: 0x06012D45 RID: 77125 RVA: 0x004D1530 File Offset: 0x004CF730
		private void RiftLevelUIController_OnGetStarReward(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftLevelUIController_OnGetStarRewardInt32_hotfix != null)
			{
				this.m_RiftLevelUIController_OnGetStarRewardInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chapterInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanGainRiftChapterStarReward(this.m_chapterInfo.ID, idx);
			if (num == 0)
			{
				RiftChapterRewardGainNetTask riftChapterRewardGainNetTask = new RiftChapterRewardGainNetTask(this.m_chapterInfo.ID, idx);
				riftChapterRewardGainNetTask.EventOnStop += delegate(Task task)
				{
					RiftChapterRewardGainNetTask riftChapterRewardGainNetTask2 = task as RiftChapterRewardGainNetTask;
					if (riftChapterRewardGainNetTask2.Result == 0)
					{
						ChestUITask chestUITask = ChestUITask.StartUITask(riftChapterRewardGainNetTask2.Reward, false, false);
						if (this.m_chestUITask == null)
						{
							this.m_chestUITask = chestUITask;
							this.m_chestUITask.EventOnStop += this.ChestUITask_OnStop;
							this.m_chestUITask.EventOnClose += this.ChestUITask_OnClose;
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(riftChapterRewardGainNetTask2.Result, 2f, null, true);
					}
				};
				riftChapterRewardGainNetTask.Start(null);
			}
			else if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_currIntent);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06012D46 RID: 77126 RVA: 0x004D1634 File Offset: 0x004CF834
		private void RiftLevelUIController_OnGoToScenario(int scenarioID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RiftLevelUIController_OnGoToScenarioInt32_hotfix != null)
			{
				this.m_RiftLevelUIController_OnGoToScenarioInt32_hotfix.call(new object[]
				{
					this,
					scenarioID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanUnlockScenario(scenarioID);
			if (num == 0)
			{
				this.m_riftLevelUIController.SetUnlockConditionClose();
				this.RiftLevelUIController_OnReturnToWorld();
				if (this.EventOnGoToScenario != null)
				{
					this.EventOnGoToScenario(scenarioID);
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06012D47 RID: 77127 RVA: 0x004D1704 File Offset: 0x004CF904
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

		// Token: 0x06012D48 RID: 77128 RVA: 0x004D17B8 File Offset: 0x004CF9B8
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
			if (this.m_chapterInfo != null)
			{
				this.UpdateStarReward(this.m_chapterInfo);
			}
			this.AutoGetStarReward();
		}

		// Token: 0x06012D49 RID: 77129 RVA: 0x004D184C File Offset: 0x004CFA4C
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
				this.m_battleLevelInfoUITask.EventOnRiftRaidComplete -= this.BattleLevelInfoUITask_OnRiftRaidComplete;
				this.m_battleLevelInfoUITask = null;
			}
		}

		// Token: 0x06012D4A RID: 77130 RVA: 0x004D18EC File Offset: 0x004CFAEC
		private void BattleLevelInfoUITask_OnRiftRaidComplete(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleLevelInfoUITask_OnRiftRaidCompleteInt32_hotfix != null)
			{
				this.m_BattleLevelInfoUITask_OnRiftRaidCompleteInt32_hotfix.call(new object[]
				{
					this,
					levelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_riftLevelPlayerResourceUIController.UpdatePlayerResource();
		}

		// Token: 0x14000417 RID: 1047
		// (add) Token: 0x06012D4B RID: 77131 RVA: 0x004D1968 File Offset: 0x004CFB68
		// (remove) Token: 0x06012D4C RID: 77132 RVA: 0x004D1A04 File Offset: 0x004CFC04
		public event Action<int> EventOnGoToScenario
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoToScenarioAction`1_hotfix != null)
				{
					this.m_add_EventOnGoToScenarioAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGoToScenario;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGoToScenario, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoToScenarioAction`1_hotfix != null)
				{
					this.m_remove_EventOnGoToScenarioAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGoToScenario;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGoToScenario, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x06012D4D RID: 77133 RVA: 0x004D1AA0 File Offset: 0x004CFCA0
		// (set) Token: 0x06012D4E RID: 77134 RVA: 0x004D1AC0 File Offset: 0x004CFCC0
		[DoNotToLua]
		public new RiftUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RiftUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012D4F RID: 77135 RVA: 0x004D1ACC File Offset: 0x004CFCCC
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06012D50 RID: 77136 RVA: 0x004D1AD8 File Offset: 0x004CFCD8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06012D51 RID: 77137 RVA: 0x004D1AE0 File Offset: 0x004CFCE0
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06012D52 RID: 77138 RVA: 0x004D1AE8 File Offset: 0x004CFCE8
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06012D53 RID: 77139 RVA: 0x004D1AF4 File Offset: 0x004CFCF4
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06012D54 RID: 77140 RVA: 0x004D1B00 File Offset: 0x004CFD00
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06012D55 RID: 77141 RVA: 0x004D1B0C File Offset: 0x004CFD0C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06012D56 RID: 77142 RVA: 0x004D1B14 File Offset: 0x004CFD14
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06012D57 RID: 77143 RVA: 0x004D1B1C File Offset: 0x004CFD1C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06012D58 RID: 77144 RVA: 0x004D1B24 File Offset: 0x004CFD24
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06012D59 RID: 77145 RVA: 0x004D1B2C File Offset: 0x004CFD2C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06012D5A RID: 77146 RVA: 0x004D1B34 File Offset: 0x004CFD34
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06012D5B RID: 77147 RVA: 0x004D1B3C File Offset: 0x004CFD3C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06012D5C RID: 77148 RVA: 0x004D1B44 File Offset: 0x004CFD44
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06012D5D RID: 77149 RVA: 0x004D1B50 File Offset: 0x004CFD50
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06012D5E RID: 77150 RVA: 0x004D1B5C File Offset: 0x004CFD5C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06012D5F RID: 77151 RVA: 0x004D1B68 File Offset: 0x004CFD68
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06012D60 RID: 77152 RVA: 0x004D1B74 File Offset: 0x004CFD74
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06012D61 RID: 77153 RVA: 0x004D1B7C File Offset: 0x004CFD7C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06012D62 RID: 77154 RVA: 0x004D1B84 File Offset: 0x004CFD84
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06012D63 RID: 77155 RVA: 0x004D1B8C File Offset: 0x004CFD8C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06012D64 RID: 77156 RVA: 0x004D1B94 File Offset: 0x004CFD94
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06012D65 RID: 77157 RVA: 0x004D1B9C File Offset: 0x004CFD9C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06012D66 RID: 77158 RVA: 0x004D1BA4 File Offset: 0x004CFDA4
		private void __callDele_EventOnGoToScenario(int obj)
		{
			Action<int> eventOnGoToScenario = this.EventOnGoToScenario;
			if (eventOnGoToScenario != null)
			{
				eventOnGoToScenario(obj);
			}
		}

		// Token: 0x06012D67 RID: 77159 RVA: 0x004D1BC8 File Offset: 0x004CFDC8
		private void __clearDele_EventOnGoToScenario(int obj)
		{
			this.EventOnGoToScenario = null;
		}

		// Token: 0x06012D6B RID: 77163 RVA: 0x004D1CB4 File Offset: 0x004CFEB4
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
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_InitRiftBackgroundUIController_hotfix = (luaObj.RawGet("InitRiftBackgroundUIController") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PlayerResourceUIController_OnAddGold_hotfix = (luaObj.RawGet("PlayerResourceUIController_OnAddGold") as LuaFunction);
					this.m_PlayerResourceUIController_OnAddCrystal_hotfix = (luaObj.RawGet("PlayerResourceUIController_OnAddCrystal") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					this.m_InitRiftChapterUIController_hotfix = (luaObj.RawGet("InitRiftChapterUIController") as LuaFunction);
					this.m_UninitRiftChapterUIController_hotfix = (luaObj.RawGet("UninitRiftChapterUIController") as LuaFunction);
					this.m_UpdateChapters_hotfix = (luaObj.RawGet("UpdateChapters") as LuaFunction);
					this.m_ShowChapterProgressConfigDataRiftChapterInfo_hotfix = (luaObj.RawGet("ShowChapterProgress") as LuaFunction);
					this.m_HideChapterProgressConfigDataRiftChapterInfo_hotfix = (luaObj.RawGet("HideChapterProgress") as LuaFunction);
					this.m_SelectChapterConfigDataRiftChapterInfoBoolean_hotfix = (luaObj.RawGet("SelectChapter") as LuaFunction);
					this.m_RiftChapterUIController_OnReturn_hotfix = (luaObj.RawGet("RiftChapterUIController_OnReturn") as LuaFunction);
					this.m_RiftChapterUIController_OnShowHelp_hotfix = (luaObj.RawGet("RiftChapterUIController_OnShowHelp") as LuaFunction);
					this.m_RiftChapterUIController_OnReturnToWorld_hotfix = (luaObj.RawGet("RiftChapterUIController_OnReturnToWorld") as LuaFunction);
					this.m_RiftChapterUIController_OnSelectChapterConfigDataRiftChapterInfo_hotfix = (luaObj.RawGet("RiftChapterUIController_OnSelectChapter") as LuaFunction);
					this.m_RiftChapterUIController_OnSwitchChapterConfigDataRiftChapterInfo_hotfix = (luaObj.RawGet("RiftChapterUIController_OnSwitchChapter") as LuaFunction);
					this.m_RiftChapterUIController_OnGoToScenarioInt32_hotfix = (luaObj.RawGet("RiftChapterUIController_OnGoToScenario") as LuaFunction);
					this.m_InitRiftLevelUIController_hotfix = (luaObj.RawGet("InitRiftLevelUIController") as LuaFunction);
					this.m_UninitRiftLevelUIController_hotfix = (luaObj.RawGet("UninitRiftLevelUIController") as LuaFunction);
					this.m_UpdateRiftLevels_hotfix = (luaObj.RawGet("UpdateRiftLevels") as LuaFunction);
					this.m_UpdateStarRewardConfigDataRiftChapterInfo_hotfix = (luaObj.RawGet("UpdateStarReward") as LuaFunction);
					this.m_AutoGetStarReward_hotfix = (luaObj.RawGet("AutoGetStarReward") as LuaFunction);
					this.m_CheckOpenRiftChapterHardConfigDataRiftChapterInfo_hotfix = (luaObj.RawGet("CheckOpenRiftChapterHard") as LuaFunction);
					this.m_StartBattleLevelInfoUITaskConfigDataRiftLevelInfoNeedGoods_hotfix = (luaObj.RawGet("StartBattleLevelInfoUITask") as LuaFunction);
					this.m_RiftLevelUIController_OnReturn_hotfix = (luaObj.RawGet("RiftLevelUIController_OnReturn") as LuaFunction);
					this.m_RiftLevelUIController_OnShowHelp_hotfix = (luaObj.RawGet("RiftLevelUIController_OnShowHelp") as LuaFunction);
					this.m_RiftLevelUIController_OnReturnToWorld_hotfix = (luaObj.RawGet("RiftLevelUIController_OnReturnToWorld") as LuaFunction);
					this.m_RiftLevelUIController_OnChangeHard_hotfix = (luaObj.RawGet("RiftLevelUIController_OnChangeHard") as LuaFunction);
					this.m_RiftLevelUIController_OnSelectRiftLevelConfigDataRiftLevelInfoNeedGoods_hotfix = (luaObj.RawGet("RiftLevelUIController_OnSelectRiftLevel") as LuaFunction);
					this.m_RiftLevelUIController_OnGetStarRewardInt32_hotfix = (luaObj.RawGet("RiftLevelUIController_OnGetStarReward") as LuaFunction);
					this.m_RiftLevelUIController_OnGoToScenarioInt32_hotfix = (luaObj.RawGet("RiftLevelUIController_OnGoToScenario") as LuaFunction);
					this.m_ChestUITask_OnStopTask_hotfix = (luaObj.RawGet("ChestUITask_OnStop") as LuaFunction);
					this.m_ChestUITask_OnClose_hotfix = (luaObj.RawGet("ChestUITask_OnClose") as LuaFunction);
					this.m_BattleLevelInfoUITask_OnClose_hotfix = (luaObj.RawGet("BattleLevelInfoUITask_OnClose") as LuaFunction);
					this.m_BattleLevelInfoUITask_OnRiftRaidCompleteInt32_hotfix = (luaObj.RawGet("BattleLevelInfoUITask_OnRiftRaidComplete") as LuaFunction);
					this.m_add_EventOnGoToScenarioAction`1_hotfix = (luaObj.RawGet("add_EventOnGoToScenario") as LuaFunction);
					this.m_remove_EventOnGoToScenarioAction`1_hotfix = (luaObj.RawGet("remove_EventOnGoToScenario") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012D6C RID: 77164 RVA: 0x004D21B4 File Offset: 0x004D03B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A84A RID: 43082
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "RiftBackgroundUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Rift_ABS/Prefab/RiftBackgroundUIPrefab.prefab",
				m_isUILayer = false
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "RiftChapterUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Rift_ABS/Prefab/RiftChapterUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "RiftLevelUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Rift_ABS/Prefab/RiftLevelUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A84B RID: 43083
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RiftBackgroundUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.RiftBackgroundUIController"),
				m_ctrlName = "RiftBackgroundUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RiftChapterUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.RiftChapterUIController"),
				m_ctrlName = "RiftChapterUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RiftLevelUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.RiftLevelUIController"),
				m_ctrlName = "RiftLevelUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RiftChapterUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "RiftChapterPlayerResourceUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RiftLevelUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "RiftLevelPlayerResourceUIController"
			}
		};

		// Token: 0x0400A84C RID: 43084
		private RiftBackgroundUIController m_riftBackgroundUIController;

		// Token: 0x0400A84D RID: 43085
		private RiftChapterUIController m_riftChapterUIController;

		// Token: 0x0400A84E RID: 43086
		private RiftLevelUIController m_riftLevelUIController;

		// Token: 0x0400A84F RID: 43087
		private PlayerResourceUIController m_riftChapterPlayerResourceUIController;

		// Token: 0x0400A850 RID: 43088
		private PlayerResourceUIController m_riftLevelPlayerResourceUIController;

		// Token: 0x0400A851 RID: 43089
		private ConfigDataRiftChapterInfo m_chapterInfo;

		// Token: 0x0400A852 RID: 43090
		private bool m_needReturnToChapter;

		// Token: 0x0400A853 RID: 43091
		private bool m_needPlayRiftLevelOpenAnimation;

		// Token: 0x0400A854 RID: 43092
		private BattleLevelInfoUITask m_battleLevelInfoUITask;

		// Token: 0x0400A855 RID: 43093
		private ChestUITask m_chestUITask;

		// Token: 0x0400A856 RID: 43094
		private RiftUITask.ViewState m_viewState = RiftUITask.ViewState.Chapter;

		// Token: 0x0400A858 RID: 43096
		[DoNotToLua]
		private RiftUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A859 RID: 43097
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A85A RID: 43098
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A85B RID: 43099
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A85C RID: 43100
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A85D RID: 43101
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x0400A85E RID: 43102
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A85F RID: 43103
		private LuaFunction m_InitRiftBackgroundUIController_hotfix;

		// Token: 0x0400A860 RID: 43104
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A861 RID: 43105
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x0400A862 RID: 43106
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A863 RID: 43107
		private LuaFunction m_PlayerResourceUIController_OnAddGold_hotfix;

		// Token: 0x0400A864 RID: 43108
		private LuaFunction m_PlayerResourceUIController_OnAddCrystal_hotfix;

		// Token: 0x0400A865 RID: 43109
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A866 RID: 43110
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x0400A867 RID: 43111
		private LuaFunction m_InitRiftChapterUIController_hotfix;

		// Token: 0x0400A868 RID: 43112
		private LuaFunction m_UninitRiftChapterUIController_hotfix;

		// Token: 0x0400A869 RID: 43113
		private LuaFunction m_UpdateChapters_hotfix;

		// Token: 0x0400A86A RID: 43114
		private LuaFunction m_ShowChapterProgressConfigDataRiftChapterInfo_hotfix;

		// Token: 0x0400A86B RID: 43115
		private LuaFunction m_HideChapterProgressConfigDataRiftChapterInfo_hotfix;

		// Token: 0x0400A86C RID: 43116
		private LuaFunction m_SelectChapterConfigDataRiftChapterInfoBoolean_hotfix;

		// Token: 0x0400A86D RID: 43117
		private LuaFunction m_RiftChapterUIController_OnReturn_hotfix;

		// Token: 0x0400A86E RID: 43118
		private LuaFunction m_RiftChapterUIController_OnShowHelp_hotfix;

		// Token: 0x0400A86F RID: 43119
		private LuaFunction m_RiftChapterUIController_OnReturnToWorld_hotfix;

		// Token: 0x0400A870 RID: 43120
		private LuaFunction m_RiftChapterUIController_OnSelectChapterConfigDataRiftChapterInfo_hotfix;

		// Token: 0x0400A871 RID: 43121
		private LuaFunction m_RiftChapterUIController_OnSwitchChapterConfigDataRiftChapterInfo_hotfix;

		// Token: 0x0400A872 RID: 43122
		private LuaFunction m_RiftChapterUIController_OnGoToScenarioInt32_hotfix;

		// Token: 0x0400A873 RID: 43123
		private LuaFunction m_InitRiftLevelUIController_hotfix;

		// Token: 0x0400A874 RID: 43124
		private LuaFunction m_UninitRiftLevelUIController_hotfix;

		// Token: 0x0400A875 RID: 43125
		private LuaFunction m_UpdateRiftLevels_hotfix;

		// Token: 0x0400A876 RID: 43126
		private LuaFunction m_UpdateStarRewardConfigDataRiftChapterInfo_hotfix;

		// Token: 0x0400A877 RID: 43127
		private LuaFunction m_AutoGetStarReward_hotfix;

		// Token: 0x0400A878 RID: 43128
		private LuaFunction m_CheckOpenRiftChapterHardConfigDataRiftChapterInfo_hotfix;

		// Token: 0x0400A879 RID: 43129
		private LuaFunction m_StartBattleLevelInfoUITaskConfigDataRiftLevelInfoNeedGoods_hotfix;

		// Token: 0x0400A87A RID: 43130
		private LuaFunction m_RiftLevelUIController_OnReturn_hotfix;

		// Token: 0x0400A87B RID: 43131
		private LuaFunction m_RiftLevelUIController_OnShowHelp_hotfix;

		// Token: 0x0400A87C RID: 43132
		private LuaFunction m_RiftLevelUIController_OnReturnToWorld_hotfix;

		// Token: 0x0400A87D RID: 43133
		private LuaFunction m_RiftLevelUIController_OnChangeHard_hotfix;

		// Token: 0x0400A87E RID: 43134
		private LuaFunction m_RiftLevelUIController_OnSelectRiftLevelConfigDataRiftLevelInfoNeedGoods_hotfix;

		// Token: 0x0400A87F RID: 43135
		private LuaFunction m_RiftLevelUIController_OnGetStarRewardInt32_hotfix;

		// Token: 0x0400A880 RID: 43136
		private LuaFunction m_RiftLevelUIController_OnGoToScenarioInt32_hotfix;

		// Token: 0x0400A881 RID: 43137
		private LuaFunction m_ChestUITask_OnStopTask_hotfix;

		// Token: 0x0400A882 RID: 43138
		private LuaFunction m_ChestUITask_OnClose_hotfix;

		// Token: 0x0400A883 RID: 43139
		private LuaFunction m_BattleLevelInfoUITask_OnClose_hotfix;

		// Token: 0x0400A884 RID: 43140
		private LuaFunction m_BattleLevelInfoUITask_OnRiftRaidCompleteInt32_hotfix;

		// Token: 0x0400A885 RID: 43141
		private LuaFunction m_add_EventOnGoToScenarioAction;

		// Token: 0x0400A886 RID: 43142
		private LuaFunction m_remove_EventOnGoToScenarioAction;

		// Token: 0x02000EED RID: 3821
		public enum ViewState
		{
			// Token: 0x0400A888 RID: 43144
			None,
			// Token: 0x0400A889 RID: 43145
			Chapter,
			// Token: 0x0400A88A RID: 43146
			RiftLevel
		}

		// Token: 0x02000EEE RID: 3822
		public new class LuaExportHelper
		{
			// Token: 0x06012D6D RID: 77165 RVA: 0x004D221C File Offset: 0x004D041C
			public LuaExportHelper(RiftUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012D6E RID: 77166 RVA: 0x004D222C File Offset: 0x004D042C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06012D6F RID: 77167 RVA: 0x004D223C File Offset: 0x004D043C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06012D70 RID: 77168 RVA: 0x004D224C File Offset: 0x004D044C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06012D71 RID: 77169 RVA: 0x004D225C File Offset: 0x004D045C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06012D72 RID: 77170 RVA: 0x004D226C File Offset: 0x004D046C
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06012D73 RID: 77171 RVA: 0x004D227C File Offset: 0x004D047C
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06012D74 RID: 77172 RVA: 0x004D228C File Offset: 0x004D048C
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06012D75 RID: 77173 RVA: 0x004D229C File Offset: 0x004D049C
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06012D76 RID: 77174 RVA: 0x004D22AC File Offset: 0x004D04AC
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06012D77 RID: 77175 RVA: 0x004D22BC File Offset: 0x004D04BC
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06012D78 RID: 77176 RVA: 0x004D22CC File Offset: 0x004D04CC
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06012D79 RID: 77177 RVA: 0x004D22DC File Offset: 0x004D04DC
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06012D7A RID: 77178 RVA: 0x004D22EC File Offset: 0x004D04EC
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06012D7B RID: 77179 RVA: 0x004D22FC File Offset: 0x004D04FC
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06012D7C RID: 77180 RVA: 0x004D230C File Offset: 0x004D050C
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06012D7D RID: 77181 RVA: 0x004D231C File Offset: 0x004D051C
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06012D7E RID: 77182 RVA: 0x004D232C File Offset: 0x004D052C
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06012D7F RID: 77183 RVA: 0x004D233C File Offset: 0x004D053C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06012D80 RID: 77184 RVA: 0x004D234C File Offset: 0x004D054C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06012D81 RID: 77185 RVA: 0x004D235C File Offset: 0x004D055C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06012D82 RID: 77186 RVA: 0x004D236C File Offset: 0x004D056C
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06012D83 RID: 77187 RVA: 0x004D237C File Offset: 0x004D057C
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06012D84 RID: 77188 RVA: 0x004D238C File Offset: 0x004D058C
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x06012D85 RID: 77189 RVA: 0x004D239C File Offset: 0x004D059C
			public void __callDele_EventOnGoToScenario(int obj)
			{
				this.m_owner.__callDele_EventOnGoToScenario(obj);
			}

			// Token: 0x06012D86 RID: 77190 RVA: 0x004D23AC File Offset: 0x004D05AC
			public void __clearDele_EventOnGoToScenario(int obj)
			{
				this.m_owner.__clearDele_EventOnGoToScenario(obj);
			}

			// Token: 0x170038C2 RID: 14530
			// (get) Token: 0x06012D87 RID: 77191 RVA: 0x004D23BC File Offset: 0x004D05BC
			// (set) Token: 0x06012D88 RID: 77192 RVA: 0x004D23CC File Offset: 0x004D05CC
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

			// Token: 0x170038C3 RID: 14531
			// (get) Token: 0x06012D89 RID: 77193 RVA: 0x004D23DC File Offset: 0x004D05DC
			// (set) Token: 0x06012D8A RID: 77194 RVA: 0x004D23EC File Offset: 0x004D05EC
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

			// Token: 0x170038C4 RID: 14532
			// (get) Token: 0x06012D8B RID: 77195 RVA: 0x004D23FC File Offset: 0x004D05FC
			// (set) Token: 0x06012D8C RID: 77196 RVA: 0x004D240C File Offset: 0x004D060C
			public RiftBackgroundUIController m_riftBackgroundUIController
			{
				get
				{
					return this.m_owner.m_riftBackgroundUIController;
				}
				set
				{
					this.m_owner.m_riftBackgroundUIController = value;
				}
			}

			// Token: 0x170038C5 RID: 14533
			// (get) Token: 0x06012D8D RID: 77197 RVA: 0x004D241C File Offset: 0x004D061C
			// (set) Token: 0x06012D8E RID: 77198 RVA: 0x004D242C File Offset: 0x004D062C
			public RiftChapterUIController m_riftChapterUIController
			{
				get
				{
					return this.m_owner.m_riftChapterUIController;
				}
				set
				{
					this.m_owner.m_riftChapterUIController = value;
				}
			}

			// Token: 0x170038C6 RID: 14534
			// (get) Token: 0x06012D8F RID: 77199 RVA: 0x004D243C File Offset: 0x004D063C
			// (set) Token: 0x06012D90 RID: 77200 RVA: 0x004D244C File Offset: 0x004D064C
			public RiftLevelUIController m_riftLevelUIController
			{
				get
				{
					return this.m_owner.m_riftLevelUIController;
				}
				set
				{
					this.m_owner.m_riftLevelUIController = value;
				}
			}

			// Token: 0x170038C7 RID: 14535
			// (get) Token: 0x06012D91 RID: 77201 RVA: 0x004D245C File Offset: 0x004D065C
			// (set) Token: 0x06012D92 RID: 77202 RVA: 0x004D246C File Offset: 0x004D066C
			public PlayerResourceUIController m_riftChapterPlayerResourceUIController
			{
				get
				{
					return this.m_owner.m_riftChapterPlayerResourceUIController;
				}
				set
				{
					this.m_owner.m_riftChapterPlayerResourceUIController = value;
				}
			}

			// Token: 0x170038C8 RID: 14536
			// (get) Token: 0x06012D93 RID: 77203 RVA: 0x004D247C File Offset: 0x004D067C
			// (set) Token: 0x06012D94 RID: 77204 RVA: 0x004D248C File Offset: 0x004D068C
			public PlayerResourceUIController m_riftLevelPlayerResourceUIController
			{
				get
				{
					return this.m_owner.m_riftLevelPlayerResourceUIController;
				}
				set
				{
					this.m_owner.m_riftLevelPlayerResourceUIController = value;
				}
			}

			// Token: 0x170038C9 RID: 14537
			// (get) Token: 0x06012D95 RID: 77205 RVA: 0x004D249C File Offset: 0x004D069C
			// (set) Token: 0x06012D96 RID: 77206 RVA: 0x004D24AC File Offset: 0x004D06AC
			public ConfigDataRiftChapterInfo m_chapterInfo
			{
				get
				{
					return this.m_owner.m_chapterInfo;
				}
				set
				{
					this.m_owner.m_chapterInfo = value;
				}
			}

			// Token: 0x170038CA RID: 14538
			// (get) Token: 0x06012D97 RID: 77207 RVA: 0x004D24BC File Offset: 0x004D06BC
			// (set) Token: 0x06012D98 RID: 77208 RVA: 0x004D24CC File Offset: 0x004D06CC
			public bool m_needReturnToChapter
			{
				get
				{
					return this.m_owner.m_needReturnToChapter;
				}
				set
				{
					this.m_owner.m_needReturnToChapter = value;
				}
			}

			// Token: 0x170038CB RID: 14539
			// (get) Token: 0x06012D99 RID: 77209 RVA: 0x004D24DC File Offset: 0x004D06DC
			// (set) Token: 0x06012D9A RID: 77210 RVA: 0x004D24EC File Offset: 0x004D06EC
			public bool m_needPlayRiftLevelOpenAnimation
			{
				get
				{
					return this.m_owner.m_needPlayRiftLevelOpenAnimation;
				}
				set
				{
					this.m_owner.m_needPlayRiftLevelOpenAnimation = value;
				}
			}

			// Token: 0x170038CC RID: 14540
			// (get) Token: 0x06012D9B RID: 77211 RVA: 0x004D24FC File Offset: 0x004D06FC
			// (set) Token: 0x06012D9C RID: 77212 RVA: 0x004D250C File Offset: 0x004D070C
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

			// Token: 0x170038CD RID: 14541
			// (get) Token: 0x06012D9D RID: 77213 RVA: 0x004D251C File Offset: 0x004D071C
			// (set) Token: 0x06012D9E RID: 77214 RVA: 0x004D252C File Offset: 0x004D072C
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

			// Token: 0x170038CE RID: 14542
			// (get) Token: 0x06012D9F RID: 77215 RVA: 0x004D253C File Offset: 0x004D073C
			// (set) Token: 0x06012DA0 RID: 77216 RVA: 0x004D254C File Offset: 0x004D074C
			public RiftUITask.ViewState m_viewState
			{
				get
				{
					return this.m_owner.m_viewState;
				}
				set
				{
					this.m_owner.m_viewState = value;
				}
			}

			// Token: 0x170038CF RID: 14543
			// (get) Token: 0x06012DA1 RID: 77217 RVA: 0x004D255C File Offset: 0x004D075C
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170038D0 RID: 14544
			// (get) Token: 0x06012DA2 RID: 77218 RVA: 0x004D256C File Offset: 0x004D076C
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06012DA3 RID: 77219 RVA: 0x004D257C File Offset: 0x004D077C
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06012DA4 RID: 77220 RVA: 0x004D258C File Offset: 0x004D078C
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x06012DA5 RID: 77221 RVA: 0x004D259C File Offset: 0x004D079C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06012DA6 RID: 77222 RVA: 0x004D25AC File Offset: 0x004D07AC
			public void InitRiftBackgroundUIController()
			{
				this.m_owner.InitRiftBackgroundUIController();
			}

			// Token: 0x06012DA7 RID: 77223 RVA: 0x004D25BC File Offset: 0x004D07BC
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06012DA8 RID: 77224 RVA: 0x004D25CC File Offset: 0x004D07CC
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x06012DA9 RID: 77225 RVA: 0x004D25DC File Offset: 0x004D07DC
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06012DAA RID: 77226 RVA: 0x004D25EC File Offset: 0x004D07EC
			public void PlayerResourceUIController_OnAddGold()
			{
				this.m_owner.PlayerResourceUIController_OnAddGold();
			}

			// Token: 0x06012DAB RID: 77227 RVA: 0x004D25FC File Offset: 0x004D07FC
			public void PlayerResourceUIController_OnAddCrystal()
			{
				this.m_owner.PlayerResourceUIController_OnAddCrystal();
			}

			// Token: 0x06012DAC RID: 77228 RVA: 0x004D260C File Offset: 0x004D080C
			public void InitRiftChapterUIController()
			{
				this.m_owner.InitRiftChapterUIController();
			}

			// Token: 0x06012DAD RID: 77229 RVA: 0x004D261C File Offset: 0x004D081C
			public void UninitRiftChapterUIController()
			{
				this.m_owner.UninitRiftChapterUIController();
			}

			// Token: 0x06012DAE RID: 77230 RVA: 0x004D262C File Offset: 0x004D082C
			public void UpdateChapters()
			{
				this.m_owner.UpdateChapters();
			}

			// Token: 0x06012DAF RID: 77231 RVA: 0x004D263C File Offset: 0x004D083C
			public void ShowChapterProgress(ConfigDataRiftChapterInfo chapterInfo)
			{
				this.m_owner.ShowChapterProgress(chapterInfo);
			}

			// Token: 0x06012DB0 RID: 77232 RVA: 0x004D264C File Offset: 0x004D084C
			public void HideChapterProgress(ConfigDataRiftChapterInfo chapterInfo)
			{
				this.m_owner.HideChapterProgress(chapterInfo);
			}

			// Token: 0x06012DB1 RID: 77233 RVA: 0x004D265C File Offset: 0x004D085C
			public void SelectChapter(ConfigDataRiftChapterInfo chapterInfo, bool playOpenAnim)
			{
				this.m_owner.SelectChapter(chapterInfo, playOpenAnim);
			}

			// Token: 0x06012DB2 RID: 77234 RVA: 0x004D266C File Offset: 0x004D086C
			public void RiftChapterUIController_OnReturn()
			{
				this.m_owner.RiftChapterUIController_OnReturn();
			}

			// Token: 0x06012DB3 RID: 77235 RVA: 0x004D267C File Offset: 0x004D087C
			public void RiftChapterUIController_OnShowHelp()
			{
				this.m_owner.RiftChapterUIController_OnShowHelp();
			}

			// Token: 0x06012DB4 RID: 77236 RVA: 0x004D268C File Offset: 0x004D088C
			public void RiftChapterUIController_OnReturnToWorld()
			{
				this.m_owner.RiftChapterUIController_OnReturnToWorld();
			}

			// Token: 0x06012DB5 RID: 77237 RVA: 0x004D269C File Offset: 0x004D089C
			public void RiftChapterUIController_OnSelectChapter(ConfigDataRiftChapterInfo chapterInfo)
			{
				this.m_owner.RiftChapterUIController_OnSelectChapter(chapterInfo);
			}

			// Token: 0x06012DB6 RID: 77238 RVA: 0x004D26AC File Offset: 0x004D08AC
			public void RiftChapterUIController_OnSwitchChapter(ConfigDataRiftChapterInfo chapterInfo)
			{
				this.m_owner.RiftChapterUIController_OnSwitchChapter(chapterInfo);
			}

			// Token: 0x06012DB7 RID: 77239 RVA: 0x004D26BC File Offset: 0x004D08BC
			public void RiftChapterUIController_OnGoToScenario(int scenarioID)
			{
				this.m_owner.RiftChapterUIController_OnGoToScenario(scenarioID);
			}

			// Token: 0x06012DB8 RID: 77240 RVA: 0x004D26CC File Offset: 0x004D08CC
			public void InitRiftLevelUIController()
			{
				this.m_owner.InitRiftLevelUIController();
			}

			// Token: 0x06012DB9 RID: 77241 RVA: 0x004D26DC File Offset: 0x004D08DC
			public void UninitRiftLevelUIController()
			{
				this.m_owner.UninitRiftLevelUIController();
			}

			// Token: 0x06012DBA RID: 77242 RVA: 0x004D26EC File Offset: 0x004D08EC
			public void UpdateRiftLevels()
			{
				this.m_owner.UpdateRiftLevels();
			}

			// Token: 0x06012DBB RID: 77243 RVA: 0x004D26FC File Offset: 0x004D08FC
			public void UpdateStarReward(ConfigDataRiftChapterInfo chapterInfo)
			{
				this.m_owner.UpdateStarReward(chapterInfo);
			}

			// Token: 0x06012DBC RID: 77244 RVA: 0x004D270C File Offset: 0x004D090C
			public void AutoGetStarReward()
			{
				this.m_owner.AutoGetStarReward();
			}

			// Token: 0x06012DBD RID: 77245 RVA: 0x004D271C File Offset: 0x004D091C
			public bool CheckOpenRiftChapterHard(ConfigDataRiftChapterInfo chapterInfo)
			{
				return this.m_owner.CheckOpenRiftChapterHard(chapterInfo);
			}

			// Token: 0x06012DBE RID: 77246 RVA: 0x004D272C File Offset: 0x004D092C
			public void StartBattleLevelInfoUITask(ConfigDataRiftLevelInfo riftLevelInfo, NeedGoods needGoods)
			{
				this.m_owner.StartBattleLevelInfoUITask(riftLevelInfo, needGoods);
			}

			// Token: 0x06012DBF RID: 77247 RVA: 0x004D273C File Offset: 0x004D093C
			public void RiftLevelUIController_OnReturn()
			{
				this.m_owner.RiftLevelUIController_OnReturn();
			}

			// Token: 0x06012DC0 RID: 77248 RVA: 0x004D274C File Offset: 0x004D094C
			public void RiftLevelUIController_OnShowHelp()
			{
				this.m_owner.RiftLevelUIController_OnShowHelp();
			}

			// Token: 0x06012DC1 RID: 77249 RVA: 0x004D275C File Offset: 0x004D095C
			public void RiftLevelUIController_OnReturnToWorld()
			{
				this.m_owner.RiftLevelUIController_OnReturnToWorld();
			}

			// Token: 0x06012DC2 RID: 77250 RVA: 0x004D276C File Offset: 0x004D096C
			public void RiftLevelUIController_OnChangeHard()
			{
				this.m_owner.RiftLevelUIController_OnChangeHard();
			}

			// Token: 0x06012DC3 RID: 77251 RVA: 0x004D277C File Offset: 0x004D097C
			public void RiftLevelUIController_OnSelectRiftLevel(ConfigDataRiftLevelInfo riftLevelInfo, NeedGoods needGoods)
			{
				this.m_owner.RiftLevelUIController_OnSelectRiftLevel(riftLevelInfo, needGoods);
			}

			// Token: 0x06012DC4 RID: 77252 RVA: 0x004D278C File Offset: 0x004D098C
			public void RiftLevelUIController_OnGetStarReward(int idx)
			{
				this.m_owner.RiftLevelUIController_OnGetStarReward(idx);
			}

			// Token: 0x06012DC5 RID: 77253 RVA: 0x004D279C File Offset: 0x004D099C
			public void RiftLevelUIController_OnGoToScenario(int scenarioID)
			{
				this.m_owner.RiftLevelUIController_OnGoToScenario(scenarioID);
			}

			// Token: 0x06012DC6 RID: 77254 RVA: 0x004D27AC File Offset: 0x004D09AC
			public void ChestUITask_OnStop(Task task)
			{
				this.m_owner.ChestUITask_OnStop(task);
			}

			// Token: 0x06012DC7 RID: 77255 RVA: 0x004D27BC File Offset: 0x004D09BC
			public void ChestUITask_OnClose()
			{
				this.m_owner.ChestUITask_OnClose();
			}

			// Token: 0x06012DC8 RID: 77256 RVA: 0x004D27CC File Offset: 0x004D09CC
			public void BattleLevelInfoUITask_OnClose()
			{
				this.m_owner.BattleLevelInfoUITask_OnClose();
			}

			// Token: 0x06012DC9 RID: 77257 RVA: 0x004D27DC File Offset: 0x004D09DC
			public void BattleLevelInfoUITask_OnRiftRaidComplete(int levelId)
			{
				this.m_owner.BattleLevelInfoUITask_OnRiftRaidComplete(levelId);
			}

			// Token: 0x0400A88B RID: 43147
			private RiftUITask m_owner;
		}
	}
}
