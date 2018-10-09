using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine.Events;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F3F RID: 3903
	[HotFix]
	public class StoreSoldierSkinDetailUITask : UITask
	{
		// Token: 0x060136D4 RID: 79572 RVA: 0x004F3690 File Offset: 0x004F1890
		public StoreSoldierSkinDetailUITask(string name) : base(name)
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

		// Token: 0x060136D5 RID: 79573 RVA: 0x004F3788 File Offset: 0x004F1988
		public static StoreSoldierSkinDetailUITask StartSoldierSkinDetailPanel(int soldierSkinId, StoreSoldierSkinDetailUITask.StartTaskFromType startType = StoreSoldierSkinDetailUITask.StartTaskFromType.StartTaskFromStore, UIIntent preUIIntent = null)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(StoreSoldierSkinDetailUITask).Name, null);
			if (preUIIntent != null)
			{
				uiintentCustom = new UIIntentReturnable(preUIIntent, typeof(StoreSoldierSkinDetailUITask).Name, null);
			}
			uiintentCustom.SetParam("StartTaskFromType", startType);
			uiintentCustom.SetParam("SoldierSkinFixedStoreID", soldierSkinId);
			return UIManager.Instance.StartUITask(uiintentCustom, true, false, null) as StoreSoldierSkinDetailUITask;
		}

		// Token: 0x060136D6 RID: 79574 RVA: 0x004F3800 File Offset: 0x004F1A00
		protected override void OnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPause_hotfix != null)
			{
				this.m_OnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnPause();
			this.EventOnClose = null;
			this.EventOnBuySuccessEnd = null;
		}

		// Token: 0x060136D7 RID: 79575 RVA: 0x004F3874 File Offset: 0x004F1A74
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnStop();
			this.EventOnClose = null;
			this.EventOnBuySuccessEnd = null;
		}

		// Token: 0x060136D8 RID: 79576 RVA: 0x004F38E8 File Offset: 0x004F1AE8
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
			if (this.m_uiCtrlArray != null && this.m_uiCtrlArray.Length != 0)
			{
				this.m_soldierSkinDetailPanelCtrl = (this.m_uiCtrlArray[0] as StoreSoldierSkinDetailUIController);
				this.m_soldierSkinDetailPanelCtrl.m_buyButton.onClick.AddListener(new UnityAction(this.OnBuyButtonClick));
				this.m_soldierSkinDetailPanelCtrl.m_panelBgButton.onClick.AddListener(new UnityAction(this.OnBgButtonClick));
			}
		}

		// Token: 0x060136D9 RID: 79577 RVA: 0x004F39BC File Offset: 0x004F1BBC
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
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = configDataLoader.GetConfigDataSoldierSkinInfo(this.m_soldierSkinConfigId);
			base.CollectSpriteAsset(configDataSoldierSkinInfo.Icon);
			foreach (Soldier2SkinResource soldier2SkinResource in configDataSoldierSkinInfo.SpecifiedSoldier)
			{
				ConfigDataSoldierInfo configDataSoldierInfo = configDataLoader.GetConfigDataSoldierInfo(soldier2SkinResource.SoldierId);
				base.CollectAsset(configDataSoldierInfo.Model);
				ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = configDataLoader.GetConfigDataModelSkinResourceInfo(soldier2SkinResource.SkinResourceId);
				base.CollectAsset(configDataModelSkinResourceInfo.Model);
			}
			return this.m_assets.Count > 0;
		}

		// Token: 0x060136DA RID: 79578 RVA: 0x004F3AE4 File Offset: 0x004F1CE4
		protected override bool IsNeedUpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedUpdateDataCache_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedUpdateDataCache_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return true;
		}

		// Token: 0x060136DB RID: 79579 RVA: 0x004F3B54 File Offset: 0x004F1D54
		protected override void UpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDataCache_hotfix != null)
			{
				this.m_UpdateDataCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_currPipeLineCtx.m_isInitPipeLine || this.m_currPipeLineCtx.m_isTaskResume)
			{
				UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
				if (uiintentCustom != null)
				{
					this.m_soldierSkinConfigId = uiintentCustom.GetStructParam<int>("SoldierSkinFixedStoreID");
					this.m_startFormType = uiintentCustom.GetStructParam<StoreSoldierSkinDetailUITask.StartTaskFromType>("StartTaskFromType");
				}
			}
		}

		// Token: 0x060136DC RID: 79580 RVA: 0x004F3C08 File Offset: 0x004F1E08
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
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = configDataLoader.GetConfigDataSoldierSkinInfo(this.m_soldierSkinConfigId);
			switch (this.m_startFormType)
			{
			case StoreSoldierSkinDetailUITask.StartTaskFromType.StartTaskFromGift:
				this.m_soldierSkinDetailPanelCtrl.UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfo(configDataSoldierSkinInfo, false);
				break;
			case StoreSoldierSkinDetailUITask.StartTaskFromType.StartTaskFromHeroDetail:
				this.m_soldierSkinDetailPanelCtrl.UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfo(configDataSoldierSkinInfo, true);
				break;
			case StoreSoldierSkinDetailUITask.StartTaskFromType.StartTaskFromStore:
			{
				ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = configDataLoader.GetConfigDataFixedStoreItemInfo(configDataSoldierSkinInfo.FixedStoreItemId);
				this.m_soldierSkinDetailPanelCtrl.UpdateSoldierSkinDetailPanelByFixedStoreItemConfigInfo(configDataFixedStoreItemInfo, true);
				break;
			}
			}
			if (this.m_currPipeLineCtx.m_isInitPipeLine || this.m_currPipeLineCtx.m_isTaskResume)
			{
				this.m_soldierSkinDetailPanelCtrl.PlayPanelOpenAnim();
			}
		}

		// Token: 0x060136DD RID: 79581 RVA: 0x004F3D18 File Offset: 0x004F1F18
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
			if (this.m_soldierSkinDetailPanelCtrl != null)
			{
				this.m_soldierSkinDetailPanelCtrl.m_buyButton.onClick.RemoveListener(new UnityAction(this.OnBuyButtonClick));
				this.m_soldierSkinDetailPanelCtrl.m_panelBgButton.onClick.RemoveListener(new UnityAction(this.OnBgButtonClick));
			}
		}

		// Token: 0x060136DE RID: 79582 RVA: 0x004F3DD4 File Offset: 0x004F1FD4
		public void OnBgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBgButtonClick_hotfix != null)
			{
				this.m_OnBgButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_soldierSkinDetailPanelCtrl.PlayPanelCloseAnim(delegate
			{
				base.Pause();
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			});
		}

		// Token: 0x060136DF RID: 79583 RVA: 0x004F3E4C File Offset: 0x004F204C
		public void OnBuyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyButtonClick_hotfix != null)
			{
				this.m_OnBuyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_startFormType == StoreSoldierSkinDetailUITask.StartTaskFromType.StartTaskFromGift)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (projectLPlayerContext.HasOwn(GoodsType.GoodsType_SoldierSkin, this.m_soldierSkinConfigId))
			{
				return;
			}
			ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = configDataLoader.GetConfigDataSoldierSkinInfo(this.m_soldierSkinConfigId);
			int num = projectLPlayerContext.CanBuyFixedStoreGoods(6, configDataSoldierSkinInfo.FixedStoreItemId, -1);
			if (num == 0)
			{
				FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask = new FixedStoreBuyStoreItemNetTask(6, configDataSoldierSkinInfo.FixedStoreItemId, -1);
				fixedStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
				{
					FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask2 = task as FixedStoreBuyStoreItemNetTask;
					if (fixedStoreBuyStoreItemNetTask2.Result == 0)
					{
						this.m_soldierSkinDetailPanelCtrl.SetBuyButtonToHasBuyMode();
						List<Goods> list = new List<Goods>();
						Goods item = new Goods
						{
							GoodsType = GoodsType.GoodsType_SoldierSkin,
							Id = this.m_soldierSkinConfigId,
							Count = 1
						};
						list.Add(item);
						GetRewardGoodsUITask.StartUITask(list);
						if (this.EventOnBuySuccessEnd != null)
						{
							this.EventOnBuySuccessEnd();
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(fixedStoreBuyStoreItemNetTask2.Result, 2f, null, true);
					}
				};
				fixedStoreBuyStoreItemNetTask.Start(null);
			}
			else if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_currIntent);
			}
			else if (num == -416)
			{
				CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_SkinTicketNotEnough, delegate(DialogBoxResult dialogResult)
				{
					if (dialogResult == DialogBoxResult.Ok)
					{
						base.Pause();
						UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
						if (uiintentReturnable != null && SystemUtility.IsLowSystemMemory())
						{
							while (uiintentReturnable.TargetTaskName != typeof(HeroListUITask).Name)
							{
								uiintentReturnable = (uiintentReturnable.PrevTaskIntent as UIIntentReturnable);
								if (uiintentReturnable == null)
								{
									uiintentReturnable = (this.m_currIntent as UIIntentReturnable);
									break;
								}
							}
						}
						StoreUITask.SpecialStartStoreUITask(uiintentReturnable, StoreId.StoreId_Gift);
					}
				}, (StringTableId)0, (StringTableId)0);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x1400043E RID: 1086
		// (add) Token: 0x060136E0 RID: 79584 RVA: 0x004F3F98 File Offset: 0x004F2198
		// (remove) Token: 0x060136E1 RID: 79585 RVA: 0x004F4034 File Offset: 0x004F2234
		public event Action EventOnBuySuccessEnd
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBuySuccessEndAction_hotfix != null)
				{
					this.m_add_EventOnBuySuccessEndAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBuySuccessEnd;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBuySuccessEnd, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBuySuccessEndAction_hotfix != null)
				{
					this.m_remove_EventOnBuySuccessEndAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBuySuccessEnd;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBuySuccessEnd, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400043F RID: 1087
		// (add) Token: 0x060136E2 RID: 79586 RVA: 0x004F40D0 File Offset: 0x004F22D0
		// (remove) Token: 0x060136E3 RID: 79587 RVA: 0x004F416C File Offset: 0x004F236C
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x060136E4 RID: 79588 RVA: 0x004F4208 File Offset: 0x004F2408
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

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x060136E5 RID: 79589 RVA: 0x004F427C File Offset: 0x004F247C
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

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x060136E6 RID: 79590 RVA: 0x004F42F0 File Offset: 0x004F24F0
		// (set) Token: 0x060136E7 RID: 79591 RVA: 0x004F4310 File Offset: 0x004F2510
		[DoNotToLua]
		public new StoreSoldierSkinDetailUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new StoreSoldierSkinDetailUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060136E8 RID: 79592 RVA: 0x004F431C File Offset: 0x004F251C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x060136E9 RID: 79593 RVA: 0x004F4328 File Offset: 0x004F2528
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060136EA RID: 79594 RVA: 0x004F4330 File Offset: 0x004F2530
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060136EB RID: 79595 RVA: 0x004F4338 File Offset: 0x004F2538
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x060136EC RID: 79596 RVA: 0x004F4344 File Offset: 0x004F2544
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x060136ED RID: 79597 RVA: 0x004F4350 File Offset: 0x004F2550
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x060136EE RID: 79598 RVA: 0x004F435C File Offset: 0x004F255C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060136EF RID: 79599 RVA: 0x004F4364 File Offset: 0x004F2564
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060136F0 RID: 79600 RVA: 0x004F436C File Offset: 0x004F256C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x060136F1 RID: 79601 RVA: 0x004F4374 File Offset: 0x004F2574
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x060136F2 RID: 79602 RVA: 0x004F437C File Offset: 0x004F257C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060136F3 RID: 79603 RVA: 0x004F4384 File Offset: 0x004F2584
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x060136F4 RID: 79604 RVA: 0x004F438C File Offset: 0x004F258C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x060136F5 RID: 79605 RVA: 0x004F4394 File Offset: 0x004F2594
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x060136F6 RID: 79606 RVA: 0x004F43A0 File Offset: 0x004F25A0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060136F7 RID: 79607 RVA: 0x004F43AC File Offset: 0x004F25AC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060136F8 RID: 79608 RVA: 0x004F43B8 File Offset: 0x004F25B8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060136F9 RID: 79609 RVA: 0x004F43C4 File Offset: 0x004F25C4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060136FA RID: 79610 RVA: 0x004F43CC File Offset: 0x004F25CC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060136FB RID: 79611 RVA: 0x004F43D4 File Offset: 0x004F25D4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060136FC RID: 79612 RVA: 0x004F43DC File Offset: 0x004F25DC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060136FD RID: 79613 RVA: 0x004F43E4 File Offset: 0x004F25E4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060136FE RID: 79614 RVA: 0x004F43EC File Offset: 0x004F25EC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060136FF RID: 79615 RVA: 0x004F43F4 File Offset: 0x004F25F4
		private void __callDele_EventOnBuySuccessEnd()
		{
			Action eventOnBuySuccessEnd = this.EventOnBuySuccessEnd;
			if (eventOnBuySuccessEnd != null)
			{
				eventOnBuySuccessEnd();
			}
		}

		// Token: 0x06013700 RID: 79616 RVA: 0x004F4414 File Offset: 0x004F2614
		private void __clearDele_EventOnBuySuccessEnd()
		{
			this.EventOnBuySuccessEnd = null;
		}

		// Token: 0x06013701 RID: 79617 RVA: 0x004F4420 File Offset: 0x004F2620
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06013702 RID: 79618 RVA: 0x004F4440 File Offset: 0x004F2640
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06013706 RID: 79622 RVA: 0x004F4584 File Offset: 0x004F2784
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
					this.m_OnPause_hotfix = (luaObj.RawGet("OnPause") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_IsNeedUpdateDataCache_hotfix = (luaObj.RawGet("IsNeedUpdateDataCache") as LuaFunction);
					this.m_UpdateDataCache_hotfix = (luaObj.RawGet("UpdateDataCache") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnBgButtonClick_hotfix = (luaObj.RawGet("OnBgButtonClick") as LuaFunction);
					this.m_OnBuyButtonClick_hotfix = (luaObj.RawGet("OnBuyButtonClick") as LuaFunction);
					this.m_add_EventOnBuySuccessEndAction_hotfix = (luaObj.RawGet("add_EventOnBuySuccessEnd") as LuaFunction);
					this.m_remove_EventOnBuySuccessEndAction_hotfix = (luaObj.RawGet("remove_EventOnBuySuccessEnd") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013707 RID: 79623 RVA: 0x004F47E0 File Offset: 0x004F29E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(StoreSoldierSkinDetailUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AC9C RID: 44188
		public int m_soldierSkinConfigId;

		// Token: 0x0400AC9D RID: 44189
		public StoreSoldierSkinDetailUITask.StartTaskFromType m_startFormType = StoreSoldierSkinDetailUITask.StartTaskFromType.StartTaskFromStore;

		// Token: 0x0400AC9E RID: 44190
		public StoreSoldierSkinDetailUIController m_soldierSkinDetailPanelCtrl;

		// Token: 0x0400AC9F RID: 44191
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "StoreSoldierSkinDetailUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Store_ABS/Prefab/StoreSoldierSkinDetailPanel.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400ACA0 RID: 44192
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "StoreSoldierSkinDetailUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.StoreSoldierSkinDetailUIController"),
				m_ctrlName = "StoreSoldierSkinDetailUIController"
			}
		};

		// Token: 0x0400ACA1 RID: 44193
		public const string ParamKey_SoldierSkinConfigID = "SoldierSkinFixedStoreID";

		// Token: 0x0400ACA2 RID: 44194
		public const string ParamKey_StartTaskFromType = "StartTaskFromType";

		// Token: 0x0400ACA3 RID: 44195
		[DoNotToLua]
		private StoreSoldierSkinDetailUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400ACA4 RID: 44196
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400ACA5 RID: 44197
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400ACA6 RID: 44198
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400ACA7 RID: 44199
		private LuaFunction m_OnPause_hotfix;

		// Token: 0x0400ACA8 RID: 44200
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x0400ACA9 RID: 44201
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400ACAA RID: 44202
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400ACAB RID: 44203
		private LuaFunction m_IsNeedUpdateDataCache_hotfix;

		// Token: 0x0400ACAC RID: 44204
		private LuaFunction m_UpdateDataCache_hotfix;

		// Token: 0x0400ACAD RID: 44205
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400ACAE RID: 44206
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400ACAF RID: 44207
		private LuaFunction m_OnBgButtonClick_hotfix;

		// Token: 0x0400ACB0 RID: 44208
		private LuaFunction m_OnBuyButtonClick_hotfix;

		// Token: 0x0400ACB1 RID: 44209
		private LuaFunction m_add_EventOnBuySuccessEndAction_hotfix;

		// Token: 0x0400ACB2 RID: 44210
		private LuaFunction m_remove_EventOnBuySuccessEndAction_hotfix;

		// Token: 0x0400ACB3 RID: 44211
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400ACB4 RID: 44212
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400ACB5 RID: 44213
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400ACB6 RID: 44214
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000F40 RID: 3904
		public enum StartTaskFromType
		{
			// Token: 0x0400ACB8 RID: 44216
			StartTaskFromGift,
			// Token: 0x0400ACB9 RID: 44217
			StartTaskFromHeroDetail,
			// Token: 0x0400ACBA RID: 44218
			StartTaskFromStore
		}

		// Token: 0x02000F41 RID: 3905
		public new class LuaExportHelper
		{
			// Token: 0x06013708 RID: 79624 RVA: 0x004F4848 File Offset: 0x004F2A48
			public LuaExportHelper(StoreSoldierSkinDetailUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013709 RID: 79625 RVA: 0x004F4858 File Offset: 0x004F2A58
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0601370A RID: 79626 RVA: 0x004F4868 File Offset: 0x004F2A68
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0601370B RID: 79627 RVA: 0x004F4878 File Offset: 0x004F2A78
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0601370C RID: 79628 RVA: 0x004F4888 File Offset: 0x004F2A88
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0601370D RID: 79629 RVA: 0x004F4898 File Offset: 0x004F2A98
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0601370E RID: 79630 RVA: 0x004F48A8 File Offset: 0x004F2AA8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0601370F RID: 79631 RVA: 0x004F48B8 File Offset: 0x004F2AB8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06013710 RID: 79632 RVA: 0x004F48C8 File Offset: 0x004F2AC8
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06013711 RID: 79633 RVA: 0x004F48D8 File Offset: 0x004F2AD8
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06013712 RID: 79634 RVA: 0x004F48E8 File Offset: 0x004F2AE8
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06013713 RID: 79635 RVA: 0x004F48F8 File Offset: 0x004F2AF8
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06013714 RID: 79636 RVA: 0x004F4908 File Offset: 0x004F2B08
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06013715 RID: 79637 RVA: 0x004F4918 File Offset: 0x004F2B18
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06013716 RID: 79638 RVA: 0x004F4928 File Offset: 0x004F2B28
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06013717 RID: 79639 RVA: 0x004F4938 File Offset: 0x004F2B38
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06013718 RID: 79640 RVA: 0x004F4948 File Offset: 0x004F2B48
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06013719 RID: 79641 RVA: 0x004F4958 File Offset: 0x004F2B58
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0601371A RID: 79642 RVA: 0x004F4968 File Offset: 0x004F2B68
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0601371B RID: 79643 RVA: 0x004F4978 File Offset: 0x004F2B78
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0601371C RID: 79644 RVA: 0x004F4988 File Offset: 0x004F2B88
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0601371D RID: 79645 RVA: 0x004F4998 File Offset: 0x004F2B98
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0601371E RID: 79646 RVA: 0x004F49A8 File Offset: 0x004F2BA8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0601371F RID: 79647 RVA: 0x004F49B8 File Offset: 0x004F2BB8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x06013720 RID: 79648 RVA: 0x004F49C8 File Offset: 0x004F2BC8
			public void __callDele_EventOnBuySuccessEnd()
			{
				this.m_owner.__callDele_EventOnBuySuccessEnd();
			}

			// Token: 0x06013721 RID: 79649 RVA: 0x004F49D8 File Offset: 0x004F2BD8
			public void __clearDele_EventOnBuySuccessEnd()
			{
				this.m_owner.__clearDele_EventOnBuySuccessEnd();
			}

			// Token: 0x06013722 RID: 79650 RVA: 0x004F49E8 File Offset: 0x004F2BE8
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06013723 RID: 79651 RVA: 0x004F49F8 File Offset: 0x004F2BF8
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17003A93 RID: 14995
			// (get) Token: 0x06013724 RID: 79652 RVA: 0x004F4A08 File Offset: 0x004F2C08
			// (set) Token: 0x06013725 RID: 79653 RVA: 0x004F4A18 File Offset: 0x004F2C18
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

			// Token: 0x17003A94 RID: 14996
			// (get) Token: 0x06013726 RID: 79654 RVA: 0x004F4A28 File Offset: 0x004F2C28
			// (set) Token: 0x06013727 RID: 79655 RVA: 0x004F4A38 File Offset: 0x004F2C38
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

			// Token: 0x17003A95 RID: 14997
			// (get) Token: 0x06013728 RID: 79656 RVA: 0x004F4A48 File Offset: 0x004F2C48
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003A96 RID: 14998
			// (get) Token: 0x06013729 RID: 79657 RVA: 0x004F4A58 File Offset: 0x004F2C58
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0601372A RID: 79658 RVA: 0x004F4A68 File Offset: 0x004F2C68
			public void OnPause()
			{
				this.m_owner.OnPause();
			}

			// Token: 0x0601372B RID: 79659 RVA: 0x004F4A78 File Offset: 0x004F2C78
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0601372C RID: 79660 RVA: 0x004F4A88 File Offset: 0x004F2C88
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0601372D RID: 79661 RVA: 0x004F4A98 File Offset: 0x004F2C98
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0601372E RID: 79662 RVA: 0x004F4AA8 File Offset: 0x004F2CA8
			public bool IsNeedUpdateDataCache()
			{
				return this.m_owner.IsNeedUpdateDataCache();
			}

			// Token: 0x0601372F RID: 79663 RVA: 0x004F4AB8 File Offset: 0x004F2CB8
			public void UpdateDataCache()
			{
				this.m_owner.UpdateDataCache();
			}

			// Token: 0x06013730 RID: 79664 RVA: 0x004F4AC8 File Offset: 0x004F2CC8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06013731 RID: 79665 RVA: 0x004F4AD8 File Offset: 0x004F2CD8
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0400ACBB RID: 44219
			private StoreSoldierSkinDetailUITask m_owner;
		}
	}
}
