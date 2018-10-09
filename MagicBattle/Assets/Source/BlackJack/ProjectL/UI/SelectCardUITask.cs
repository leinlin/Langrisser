using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F05 RID: 3845
	[HotFix]
	public class SelectCardUITask : UITask
	{
		// Token: 0x0601309D RID: 77981 RVA: 0x004DBBB4 File Offset: 0x004D9DB4
		public SelectCardUITask(string name) : base(name)
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

		// Token: 0x0601309E RID: 77982 RVA: 0x004DBD80 File Offset: 0x004D9F80
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
			for (int i = 0; i < this.m_layerArray.Length; i++)
			{
				if (this.m_layerArray[i].State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(this.m_layerArray[i]);
				}
			}
		}

		// Token: 0x0601309F RID: 77983 RVA: 0x004DBE28 File Offset: 0x004DA028
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
			if (this.m_selectCardUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_selectCardUIController = (this.m_uiCtrlArray[0] as SelectCardUIController);
					this.m_selectCardBackground3DController = (this.m_uiCtrlArray[1] as SelectCardBackground3DController);
					this.m_shareTenSelectCardUIController = (this.m_uiCtrlArray[2] as ShareTenSelectCardUIController);
					this.m_shareTenSelectCardUIController.gameObject.SetActive(false);
					this.m_selectCardUIController.SetShareTenSelectCardUIController(this.m_shareTenSelectCardUIController);
				}
				if (!(this.m_selectCardUIController != null))
				{
					Debug.LogError("SelectCardUIController is null");
					return;
				}
				this.m_selectCardUIController.EventOnReturn += this.SelectCardUIController_OnReturn;
				this.m_selectCardUIController.EventOnSelectCard += this.SelectCardUIController_OnCardSelect;
				this.m_selectCardUIController.EventOnArchive += this.SelectCardUIController_OnArvhive;
				this.m_selectCardUIController.EventOnShowSelectCardHelp += this.SelectCardUIController_OnShowSelectCardHelp;
				this.m_selectCardUIController.EventOnShowActivityDetail += this.SelectCardUIController_OnShowActivityDetail;
				this.m_selectCardUIController.EventOnWeiBoShareTen += this.OnWeiBoShareTenClick;
				this.m_selectCardUIController.EventOnWeChatShareTen += this.OnWeChatShareTenClick;
				this.m_selectCardUIController.EventOnBagCapcityNotEnough += this.SelectCardUIController_OnBagCapcityNotEnough;
				this.m_selectCardUIController.EventOnCrystalNotEnough += this.SelectCardUIController_OnCrystalNotEnough;
				this.m_selectCardUIController.EventOnAddCrystal += this.SelectCardUIController_OnAddCrystal;
			}
		}

		// Token: 0x060130A0 RID: 77984 RVA: 0x004DC010 File Offset: 0x004DA210
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
			if (this.m_selectCardUIController != null)
			{
				this.m_selectCardUIController.EventOnReturn -= this.SelectCardUIController_OnReturn;
				this.m_selectCardUIController.EventOnSelectCard -= this.SelectCardUIController_OnCardSelect;
				this.m_selectCardUIController.EventOnArchive -= this.SelectCardUIController_OnArvhive;
				this.m_selectCardUIController.EventOnShowSelectCardHelp -= this.SelectCardUIController_OnShowSelectCardHelp;
				this.m_selectCardUIController.EventOnBagCapcityNotEnough -= this.SelectCardUIController_OnBagCapcityNotEnough;
				this.m_selectCardUIController.EventOnShowActivityDetail -= this.SelectCardUIController_OnShowActivityDetail;
				this.m_selectCardUIController.EventOnWeiBoShareTen -= this.OnWeiBoShareTenClick;
				this.m_selectCardUIController.EventOnWeChatShareTen -= this.OnWeChatShareTenClick;
				this.m_selectCardUIController.EventOnCrystalNotEnough -= this.SelectCardUIController_OnCrystalNotEnough;
				this.m_selectCardUIController.EventOnAddCrystal -= this.SelectCardUIController_OnAddCrystal;
				this.m_selectCardUIController = null;
			}
		}

		// Token: 0x060130A1 RID: 77985 RVA: 0x004DC174 File Offset: 0x004DA374
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
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (KeyValuePair<int, ConfigDataCardPoolInfo> keyValuePair in configDataLoader.GetAllConfigDataCardPoolInfo())
			{
				ConfigDataCardPoolInfo value = keyValuePair.Value;
				if (value.PoolType != CardPoolType.CardPoolType_ActivityCardPool || projectLPlayerContext.FindOperationalActivityByActivityCardPoolId(value.ID) != null)
				{
					base.CollectSpriteAsset(value.AdsImage);
					base.CollectSpriteAsset(value.Icon);
					base.CollectSpriteAsset(value.ToggleClickImage);
					base.CollectSpriteAsset(value.ToggleUnClickImage);
				}
			}
			foreach (int key in this.m_heroIdList)
			{
				ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(key);
				if (configDataHeroInfo != null)
				{
					ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star);
					if (charImageInfo != null)
					{
						base.CollectAsset(charImageInfo.Spine);
						base.CollectAsset(charImageInfo.HeroPainting);
						base.CollectSpriteAsset(charImageInfo.Image);
						base.CollectAsset(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060130A2 RID: 77986 RVA: 0x004DC364 File Offset: 0x004DA564
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

		// Token: 0x060130A3 RID: 77987 RVA: 0x004DC3CC File Offset: 0x004DA5CC
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
			if (base.IsOpeningUI())
			{
				this.m_selectCardUIController.Open();
			}
			this.m_selectCardUIController.UpdateSharePlayerInfo();
			UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
			int structParam = uiintentReturnable.GetStructParam<int>("CardPoolID");
			uiintentReturnable.SetParam("CardPoolID", 0);
			this.m_selectCardUIController.UpdateViewInSelectCard(structParam);
			if (this.m_isShowRewardsPanel)
			{
				this.m_selectCardUIController.ShowSelectCardRewards(this.m_rewards, this.m_selectCardBackground3DController);
				this.m_isShowRewardsPanel = false;
			}
			if (this.m_isRefresShareTenPanel)
			{
				this.m_shareTenSelectCardUIController.Refresh(this.m_heroIdList);
				this.m_isRefresShareTenPanel = false;
			}
		}

		// Token: 0x060130A4 RID: 77988 RVA: 0x004DC4D0 File Offset: 0x004DA6D0
		private void SelectCardUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUIController_OnReturn_hotfix != null)
			{
				this.m_SelectCardUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearUnusedDynamicResourceCache();
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x060130A5 RID: 77989 RVA: 0x004DC558 File Offset: 0x004DA758
		private void SelectCardUIController_OnArvhive()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUIController_OnArvhive_hotfix != null)
			{
				this.m_SelectCardUIController_OnArvhive_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				base.Stop();
				UIIntentReturnable intent = new UIIntentReturnable(base.CurrentIntent, typeof(ArchiveUITask).Name, null);
				UIManager.Instance.StartUITask(intent, true, false, delegate
				{
					CommonUIController.Instance.HideFadeOutLoadingFadeIn();
					UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ArchiveUITask));
					uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
				});
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x060130A6 RID: 77990 RVA: 0x004DC5DC File Offset: 0x004DA7DC
		private void SelectCardUIController_OnShowSelectCardHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUIController_OnShowSelectCardHelp_hotfix != null)
			{
				this.m_SelectCardUIController_OnShowSelectCardHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_SelectCard);
		}

		// Token: 0x060130A7 RID: 77991 RVA: 0x004DC648 File Offset: 0x004DA848
		private void SelectCardUIController_OnShowActivityDetail(CardPool pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUIController_OnShowActivityDetailCardPool_hotfix != null)
			{
				this.m_SelectCardUIController_OnShowActivityDetailCardPool_hotfix.call(new object[]
				{
					this,
					pool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!string.IsNullOrEmpty(pool.Config.CardPoolDetailDesc))
			{
				CommonUIController.Instance.ShowExplanation(pool.Config.CardPoolDetailDesc);
			}
		}

		// Token: 0x060130A8 RID: 77992 RVA: 0x004DC6E4 File Offset: 0x004DA8E4
		private void SelectCardUIController_OnBagCapcityNotEnough()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUIController_OnBagCapcityNotEnough_hotfix != null)
			{
				this.m_SelectCardUIController_OnBagCapcityNotEnough_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagFullUITask.StartUITask(this.m_currIntent);
		}

		// Token: 0x060130A9 RID: 77993 RVA: 0x004DC750 File Offset: 0x004DA950
		private void SelectCardUIController_OnCrystalNotEnough()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUIController_OnCrystalNotEnough_hotfix != null)
			{
				this.m_SelectCardUIController_OnCrystalNotEnough_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_CrystalNotEnough, delegate(DialogBoxResult dialogResult)
			{
				if (dialogResult == DialogBoxResult.Ok)
				{
					StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
				}
			}, (StringTableId)0, (StringTableId)0);
		}

		// Token: 0x060130AA RID: 77994 RVA: 0x004DC7D0 File Offset: 0x004DA9D0
		private void SelectCardUIController_OnAddCrystal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUIController_OnAddCrystal_hotfix != null)
			{
				this.m_SelectCardUIController_OnAddCrystal_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
		}

		// Token: 0x060130AB RID: 77995 RVA: 0x004DC848 File Offset: 0x004DAA48
		private void SelectCardUIController_OnCardSelect(int cardPoolId, bool isSingleSlect)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUIController_OnCardSelectInt32Boolean_hotfix != null)
			{
				this.m_SelectCardUIController_OnCardSelectInt32Boolean_hotfix.call(new object[]
				{
					this,
					cardPoolId,
					isSingleSlect
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearUnusedDynamicResourceCache();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanSelectCard(cardPoolId, isSingleSlect, true);
			if (num != -1515 && num != -1514 && num != 0)
			{
				if (num == -500)
				{
					BagFullUITask.StartUITask(this.m_currIntent);
				}
				else if (num == -401)
				{
					CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_CrystalNotEnough, delegate(DialogBoxResult dialogResult)
					{
						if (dialogResult == DialogBoxResult.Ok)
						{
							StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
						}
					}, (StringTableId)0, (StringTableId)0);
				}
				else if (num == -1500)
				{
					base.StartUpdatePipeLine(null, false, false, true);
					CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				}
				return;
			}
			CardSelectNetTask cardSelectNetTask = new CardSelectNetTask(cardPoolId, isSingleSlect, true);
			cardSelectNetTask.EventOnStop += delegate(Task task)
			{
				CardSelectNetTask cardSelectNetTask2 = task as CardSelectNetTask;
				if (cardSelectNetTask2.Result == 0)
				{
					this.m_selectCardUIController.CloseTenSelectPanel(null);
					this.m_heroIdList.Clear();
					if (cardSelectNetTask2.Rewards != null && cardSelectNetTask2.Rewards.Count != 0)
					{
						foreach (Goods goods in cardSelectNetTask2.Rewards)
						{
							if (goods.GoodsType == GoodsType.GoodsType_Hero)
							{
								this.m_heroIdList.Add(goods.Id);
							}
						}
						this.m_rewards = cardSelectNetTask2.Rewards;
					}
					this.m_isShowRewardsPanel = true;
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					NoticeUIController.IsForceHide = false;
					CommonUIController.Instance.ShowErrorMessage(cardSelectNetTask2.Result, 2f, null, true);
				}
			};
			cardSelectNetTask.Start(null);
			NoticeUIController.IsForceHide = true;
		}

		// Token: 0x060130AC RID: 77996 RVA: 0x004DC9B8 File Offset: 0x004DABB8
		private void OnWeiBoShareTenClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWeiBoShareTenClick_hotfix != null)
			{
				this.m_OnWeiBoShareTenClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isRefresShareTenPanel = true;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x060130AD RID: 77997 RVA: 0x004DCA2C File Offset: 0x004DAC2C
		private void OnWeChatShareTenClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWeChatShareTenClick_hotfix != null)
			{
				this.m_OnWeChatShareTenClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isRefresShareTenPanel = true;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x060130AE RID: 77998 RVA: 0x004DCAA0 File Offset: 0x004DACA0
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

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x060130AF RID: 77999 RVA: 0x004DCB14 File Offset: 0x004DAD14
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

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x060130B0 RID: 78000 RVA: 0x004DCB88 File Offset: 0x004DAD88
		// (set) Token: 0x060130B1 RID: 78001 RVA: 0x004DCBA8 File Offset: 0x004DADA8
		[DoNotToLua]
		public new SelectCardUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SelectCardUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060130B2 RID: 78002 RVA: 0x004DCBB4 File Offset: 0x004DADB4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x060130B3 RID: 78003 RVA: 0x004DCBC0 File Offset: 0x004DADC0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060130B4 RID: 78004 RVA: 0x004DCBC8 File Offset: 0x004DADC8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060130B5 RID: 78005 RVA: 0x004DCBD0 File Offset: 0x004DADD0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x060130B6 RID: 78006 RVA: 0x004DCBDC File Offset: 0x004DADDC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x060130B7 RID: 78007 RVA: 0x004DCBE8 File Offset: 0x004DADE8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x060130B8 RID: 78008 RVA: 0x004DCBF4 File Offset: 0x004DADF4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060130B9 RID: 78009 RVA: 0x004DCBFC File Offset: 0x004DADFC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060130BA RID: 78010 RVA: 0x004DCC04 File Offset: 0x004DAE04
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x060130BB RID: 78011 RVA: 0x004DCC0C File Offset: 0x004DAE0C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x060130BC RID: 78012 RVA: 0x004DCC14 File Offset: 0x004DAE14
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060130BD RID: 78013 RVA: 0x004DCC1C File Offset: 0x004DAE1C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x060130BE RID: 78014 RVA: 0x004DCC24 File Offset: 0x004DAE24
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x060130BF RID: 78015 RVA: 0x004DCC2C File Offset: 0x004DAE2C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x060130C0 RID: 78016 RVA: 0x004DCC38 File Offset: 0x004DAE38
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060130C1 RID: 78017 RVA: 0x004DCC44 File Offset: 0x004DAE44
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060130C2 RID: 78018 RVA: 0x004DCC50 File Offset: 0x004DAE50
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060130C3 RID: 78019 RVA: 0x004DCC5C File Offset: 0x004DAE5C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060130C4 RID: 78020 RVA: 0x004DCC64 File Offset: 0x004DAE64
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060130C5 RID: 78021 RVA: 0x004DCC6C File Offset: 0x004DAE6C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060130C6 RID: 78022 RVA: 0x004DCC74 File Offset: 0x004DAE74
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060130C7 RID: 78023 RVA: 0x004DCC7C File Offset: 0x004DAE7C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060130C8 RID: 78024 RVA: 0x004DCC84 File Offset: 0x004DAE84
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060130CF RID: 78031 RVA: 0x004DCE84 File Offset: 0x004DB084
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
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_SelectCardUIController_OnReturn_hotfix = (luaObj.RawGet("SelectCardUIController_OnReturn") as LuaFunction);
					this.m_SelectCardUIController_OnArvhive_hotfix = (luaObj.RawGet("SelectCardUIController_OnArvhive") as LuaFunction);
					this.m_SelectCardUIController_OnShowSelectCardHelp_hotfix = (luaObj.RawGet("SelectCardUIController_OnShowSelectCardHelp") as LuaFunction);
					this.m_SelectCardUIController_OnShowActivityDetailCardPool_hotfix = (luaObj.RawGet("SelectCardUIController_OnShowActivityDetail") as LuaFunction);
					this.m_SelectCardUIController_OnBagCapcityNotEnough_hotfix = (luaObj.RawGet("SelectCardUIController_OnBagCapcityNotEnough") as LuaFunction);
					this.m_SelectCardUIController_OnCrystalNotEnough_hotfix = (luaObj.RawGet("SelectCardUIController_OnCrystalNotEnough") as LuaFunction);
					this.m_SelectCardUIController_OnAddCrystal_hotfix = (luaObj.RawGet("SelectCardUIController_OnAddCrystal") as LuaFunction);
					this.m_SelectCardUIController_OnCardSelectInt32Boolean_hotfix = (luaObj.RawGet("SelectCardUIController_OnCardSelect") as LuaFunction);
					this.m_OnWeiBoShareTenClick_hotfix = (luaObj.RawGet("OnWeiBoShareTenClick") as LuaFunction);
					this.m_OnWeChatShareTenClick_hotfix = (luaObj.RawGet("OnWeChatShareTenClick") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060130D0 RID: 78032 RVA: 0x004DD114 File Offset: 0x004DB314
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SelectCardUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A9E2 RID: 43490
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "SelectCardBackground3DLayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/SelectCard_ABS/Prefab/SelectCardBackground3DPrefab_New.prefab",
				m_isUILayer = false
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "SelectCardUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/SelectCard_ABS/Prefab/SelectCardUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "ShareTenSeclectCardUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Share_ABS/Prefab/ShareTenSeclectCardUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A9E3 RID: 43491
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "SelectCardUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.SelectCardUIController"),
				m_ctrlName = "SelectCardUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "SelectCardBackground3DLayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.SelectCardBackground3DController"),
				m_ctrlName = "SelectCardBackground3DController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ShareTenSeclectCardUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ShareTenSelectCardUIController"),
				m_ctrlName = "ShareTenSelectCardUIController"
			}
		};

		// Token: 0x0400A9E4 RID: 43492
		private List<int> m_heroIdList = new List<int>();

		// Token: 0x0400A9E5 RID: 43493
		private List<Goods> m_rewards = new List<Goods>();

		// Token: 0x0400A9E6 RID: 43494
		private bool m_isShowRewardsPanel;

		// Token: 0x0400A9E7 RID: 43495
		private bool m_isRefresShareTenPanel;

		// Token: 0x0400A9E8 RID: 43496
		private SelectCardUIController m_selectCardUIController;

		// Token: 0x0400A9E9 RID: 43497
		private SelectCardBackground3DController m_selectCardBackground3DController;

		// Token: 0x0400A9EA RID: 43498
		private ShareTenSelectCardUIController m_shareTenSelectCardUIController;

		// Token: 0x0400A9EB RID: 43499
		[DoNotToLua]
		private SelectCardUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A9ED RID: 43501
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A9EE RID: 43502
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A9EF RID: 43503
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A9F0 RID: 43504
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x0400A9F1 RID: 43505
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A9F2 RID: 43506
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A9F3 RID: 43507
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A9F4 RID: 43508
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x0400A9F5 RID: 43509
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A9F6 RID: 43510
		private LuaFunction m_SelectCardUIController_OnReturn_hotfix;

		// Token: 0x0400A9F7 RID: 43511
		private LuaFunction m_SelectCardUIController_OnArvhive_hotfix;

		// Token: 0x0400A9F8 RID: 43512
		private LuaFunction m_SelectCardUIController_OnShowSelectCardHelp_hotfix;

		// Token: 0x0400A9F9 RID: 43513
		private LuaFunction m_SelectCardUIController_OnShowActivityDetailCardPool_hotfix;

		// Token: 0x0400A9FA RID: 43514
		private LuaFunction m_SelectCardUIController_OnBagCapcityNotEnough_hotfix;

		// Token: 0x0400A9FB RID: 43515
		private LuaFunction m_SelectCardUIController_OnCrystalNotEnough_hotfix;

		// Token: 0x0400A9FC RID: 43516
		private LuaFunction m_SelectCardUIController_OnAddCrystal_hotfix;

		// Token: 0x0400A9FD RID: 43517
		private LuaFunction m_SelectCardUIController_OnCardSelectInt32Boolean_hotfix;

		// Token: 0x0400A9FE RID: 43518
		private LuaFunction m_OnWeiBoShareTenClick_hotfix;

		// Token: 0x0400A9FF RID: 43519
		private LuaFunction m_OnWeChatShareTenClick_hotfix;

		// Token: 0x0400AA00 RID: 43520
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400AA01 RID: 43521
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000F06 RID: 3846
		public new class LuaExportHelper
		{
			// Token: 0x060130D1 RID: 78033 RVA: 0x004DD17C File Offset: 0x004DB37C
			public LuaExportHelper(SelectCardUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060130D2 RID: 78034 RVA: 0x004DD18C File Offset: 0x004DB38C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060130D3 RID: 78035 RVA: 0x004DD19C File Offset: 0x004DB39C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060130D4 RID: 78036 RVA: 0x004DD1AC File Offset: 0x004DB3AC
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060130D5 RID: 78037 RVA: 0x004DD1BC File Offset: 0x004DB3BC
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060130D6 RID: 78038 RVA: 0x004DD1CC File Offset: 0x004DB3CC
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060130D7 RID: 78039 RVA: 0x004DD1DC File Offset: 0x004DB3DC
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060130D8 RID: 78040 RVA: 0x004DD1EC File Offset: 0x004DB3EC
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060130D9 RID: 78041 RVA: 0x004DD1FC File Offset: 0x004DB3FC
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060130DA RID: 78042 RVA: 0x004DD20C File Offset: 0x004DB40C
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060130DB RID: 78043 RVA: 0x004DD21C File Offset: 0x004DB41C
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060130DC RID: 78044 RVA: 0x004DD22C File Offset: 0x004DB42C
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060130DD RID: 78045 RVA: 0x004DD23C File Offset: 0x004DB43C
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060130DE RID: 78046 RVA: 0x004DD24C File Offset: 0x004DB44C
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060130DF RID: 78047 RVA: 0x004DD25C File Offset: 0x004DB45C
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060130E0 RID: 78048 RVA: 0x004DD26C File Offset: 0x004DB46C
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060130E1 RID: 78049 RVA: 0x004DD27C File Offset: 0x004DB47C
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060130E2 RID: 78050 RVA: 0x004DD28C File Offset: 0x004DB48C
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060130E3 RID: 78051 RVA: 0x004DD29C File Offset: 0x004DB49C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060130E4 RID: 78052 RVA: 0x004DD2AC File Offset: 0x004DB4AC
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060130E5 RID: 78053 RVA: 0x004DD2BC File Offset: 0x004DB4BC
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060130E6 RID: 78054 RVA: 0x004DD2CC File Offset: 0x004DB4CC
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060130E7 RID: 78055 RVA: 0x004DD2DC File Offset: 0x004DB4DC
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060130E8 RID: 78056 RVA: 0x004DD2EC File Offset: 0x004DB4EC
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x1700397D RID: 14717
			// (get) Token: 0x060130E9 RID: 78057 RVA: 0x004DD2FC File Offset: 0x004DB4FC
			// (set) Token: 0x060130EA RID: 78058 RVA: 0x004DD30C File Offset: 0x004DB50C
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

			// Token: 0x1700397E RID: 14718
			// (get) Token: 0x060130EB RID: 78059 RVA: 0x004DD31C File Offset: 0x004DB51C
			// (set) Token: 0x060130EC RID: 78060 RVA: 0x004DD32C File Offset: 0x004DB52C
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

			// Token: 0x1700397F RID: 14719
			// (get) Token: 0x060130ED RID: 78061 RVA: 0x004DD33C File Offset: 0x004DB53C
			// (set) Token: 0x060130EE RID: 78062 RVA: 0x004DD34C File Offset: 0x004DB54C
			public List<int> m_heroIdList
			{
				get
				{
					return this.m_owner.m_heroIdList;
				}
				set
				{
					this.m_owner.m_heroIdList = value;
				}
			}

			// Token: 0x17003980 RID: 14720
			// (get) Token: 0x060130EF RID: 78063 RVA: 0x004DD35C File Offset: 0x004DB55C
			// (set) Token: 0x060130F0 RID: 78064 RVA: 0x004DD36C File Offset: 0x004DB56C
			public List<Goods> m_rewards
			{
				get
				{
					return this.m_owner.m_rewards;
				}
				set
				{
					this.m_owner.m_rewards = value;
				}
			}

			// Token: 0x17003981 RID: 14721
			// (get) Token: 0x060130F1 RID: 78065 RVA: 0x004DD37C File Offset: 0x004DB57C
			// (set) Token: 0x060130F2 RID: 78066 RVA: 0x004DD38C File Offset: 0x004DB58C
			public bool m_isShowRewardsPanel
			{
				get
				{
					return this.m_owner.m_isShowRewardsPanel;
				}
				set
				{
					this.m_owner.m_isShowRewardsPanel = value;
				}
			}

			// Token: 0x17003982 RID: 14722
			// (get) Token: 0x060130F3 RID: 78067 RVA: 0x004DD39C File Offset: 0x004DB59C
			// (set) Token: 0x060130F4 RID: 78068 RVA: 0x004DD3AC File Offset: 0x004DB5AC
			public bool m_isRefresShareTenPanel
			{
				get
				{
					return this.m_owner.m_isRefresShareTenPanel;
				}
				set
				{
					this.m_owner.m_isRefresShareTenPanel = value;
				}
			}

			// Token: 0x17003983 RID: 14723
			// (get) Token: 0x060130F5 RID: 78069 RVA: 0x004DD3BC File Offset: 0x004DB5BC
			// (set) Token: 0x060130F6 RID: 78070 RVA: 0x004DD3CC File Offset: 0x004DB5CC
			public SelectCardUIController m_selectCardUIController
			{
				get
				{
					return this.m_owner.m_selectCardUIController;
				}
				set
				{
					this.m_owner.m_selectCardUIController = value;
				}
			}

			// Token: 0x17003984 RID: 14724
			// (get) Token: 0x060130F7 RID: 78071 RVA: 0x004DD3DC File Offset: 0x004DB5DC
			// (set) Token: 0x060130F8 RID: 78072 RVA: 0x004DD3EC File Offset: 0x004DB5EC
			public SelectCardBackground3DController m_selectCardBackground3DController
			{
				get
				{
					return this.m_owner.m_selectCardBackground3DController;
				}
				set
				{
					this.m_owner.m_selectCardBackground3DController = value;
				}
			}

			// Token: 0x17003985 RID: 14725
			// (get) Token: 0x060130F9 RID: 78073 RVA: 0x004DD3FC File Offset: 0x004DB5FC
			// (set) Token: 0x060130FA RID: 78074 RVA: 0x004DD40C File Offset: 0x004DB60C
			public ShareTenSelectCardUIController m_shareTenSelectCardUIController
			{
				get
				{
					return this.m_owner.m_shareTenSelectCardUIController;
				}
				set
				{
					this.m_owner.m_shareTenSelectCardUIController = value;
				}
			}

			// Token: 0x17003986 RID: 14726
			// (get) Token: 0x060130FB RID: 78075 RVA: 0x004DD41C File Offset: 0x004DB61C
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003987 RID: 14727
			// (get) Token: 0x060130FC RID: 78076 RVA: 0x004DD42C File Offset: 0x004DB62C
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060130FD RID: 78077 RVA: 0x004DD43C File Offset: 0x004DB63C
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x060130FE RID: 78078 RVA: 0x004DD44C File Offset: 0x004DB64C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060130FF RID: 78079 RVA: 0x004DD45C File Offset: 0x004DB65C
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06013100 RID: 78080 RVA: 0x004DD46C File Offset: 0x004DB66C
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06013101 RID: 78081 RVA: 0x004DD47C File Offset: 0x004DB67C
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x06013102 RID: 78082 RVA: 0x004DD48C File Offset: 0x004DB68C
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06013103 RID: 78083 RVA: 0x004DD49C File Offset: 0x004DB69C
			public void SelectCardUIController_OnReturn()
			{
				this.m_owner.SelectCardUIController_OnReturn();
			}

			// Token: 0x06013104 RID: 78084 RVA: 0x004DD4AC File Offset: 0x004DB6AC
			public void SelectCardUIController_OnArvhive()
			{
				this.m_owner.SelectCardUIController_OnArvhive();
			}

			// Token: 0x06013105 RID: 78085 RVA: 0x004DD4BC File Offset: 0x004DB6BC
			public void SelectCardUIController_OnShowSelectCardHelp()
			{
				this.m_owner.SelectCardUIController_OnShowSelectCardHelp();
			}

			// Token: 0x06013106 RID: 78086 RVA: 0x004DD4CC File Offset: 0x004DB6CC
			public void SelectCardUIController_OnShowActivityDetail(CardPool pool)
			{
				this.m_owner.SelectCardUIController_OnShowActivityDetail(pool);
			}

			// Token: 0x06013107 RID: 78087 RVA: 0x004DD4DC File Offset: 0x004DB6DC
			public void SelectCardUIController_OnBagCapcityNotEnough()
			{
				this.m_owner.SelectCardUIController_OnBagCapcityNotEnough();
			}

			// Token: 0x06013108 RID: 78088 RVA: 0x004DD4EC File Offset: 0x004DB6EC
			public void SelectCardUIController_OnCrystalNotEnough()
			{
				this.m_owner.SelectCardUIController_OnCrystalNotEnough();
			}

			// Token: 0x06013109 RID: 78089 RVA: 0x004DD4FC File Offset: 0x004DB6FC
			public void SelectCardUIController_OnAddCrystal()
			{
				this.m_owner.SelectCardUIController_OnAddCrystal();
			}

			// Token: 0x0601310A RID: 78090 RVA: 0x004DD50C File Offset: 0x004DB70C
			public void SelectCardUIController_OnCardSelect(int cardPoolId, bool isSingleSlect)
			{
				this.m_owner.SelectCardUIController_OnCardSelect(cardPoolId, isSingleSlect);
			}

			// Token: 0x0601310B RID: 78091 RVA: 0x004DD51C File Offset: 0x004DB71C
			public void OnWeiBoShareTenClick()
			{
				this.m_owner.OnWeiBoShareTenClick();
			}

			// Token: 0x0601310C RID: 78092 RVA: 0x004DD52C File Offset: 0x004DB72C
			public void OnWeChatShareTenClick()
			{
				this.m_owner.OnWeChatShareTenClick();
			}

			// Token: 0x0400AA02 RID: 43522
			private SelectCardUITask m_owner;
		}
	}
}
