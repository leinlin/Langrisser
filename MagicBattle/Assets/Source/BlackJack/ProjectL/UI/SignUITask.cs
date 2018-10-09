using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F12 RID: 3858
	[HotFix]
	public class SignUITask : UITask
	{
		// Token: 0x06013223 RID: 78371 RVA: 0x004E0B74 File Offset: 0x004DED74
		public SignUITask(string name) : base(name)
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

		// Token: 0x06013224 RID: 78372 RVA: 0x004E0C84 File Offset: 0x004DEE84
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
			List<Goods> signRewardMonthList = projectLPlayerContext.GetSignRewardMonthList(this.m_playerContext.GetServerTime().Month);
			foreach (Goods goods in signRewardMonthList)
			{
				base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
				if (goods.GoodsType == GoodsType.GoodsType_Item)
				{
					ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goods.Id);
					if (configDataItemInfo != null && configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox)
					{
						ConfigDataStaticBoxInfo configDataStaticBoxInfo = configDataLoader.GetConfigDataStaticBoxInfo(configDataItemInfo.FuncTypeParam1);
						if (configDataStaticBoxInfo != null)
						{
							foreach (Goods goods2 in configDataStaticBoxInfo.Reward)
							{
								base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods2.GoodsType, goods2.Id));
							}
						}
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06013225 RID: 78373 RVA: 0x004E0E3C File Offset: 0x004DF03C
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
			if (this.m_signRewardListUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_signRewardListUIController = (this.m_uiCtrlArray[0] as SignRewardListUIController);
				}
				if (!(this.m_signRewardListUIController != null))
				{
					Debug.LogError("SignRewardListUIController is null");
					return;
				}
				this.m_signRewardListUIController.EventOnSignCloseButtonClick += this.OnSignCloseButtonClick;
				this.m_signRewardListUIController.EventOnSignTodayListClick += this.OnTodaySignItemClick;
				this.m_signRewardListUIController.EventOnSignTodayBoxListClick += this.OnTodaySignBoxClick;
			}
		}

		// Token: 0x06013226 RID: 78374 RVA: 0x004E0F3C File Offset: 0x004DF13C
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
			if (this.m_signRewardListUIController != null)
			{
				this.m_signRewardListUIController.EventOnSignCloseButtonClick -= this.OnSignCloseButtonClick;
				this.m_signRewardListUIController.EventOnSignTodayListClick -= this.OnTodaySignItemClick;
				this.m_signRewardListUIController.EventOnSignTodayBoxListClick -= this.OnTodaySignBoxClick;
				this.m_signRewardListUIController = null;
			}
		}

		// Token: 0x06013227 RID: 78375 RVA: 0x004E1000 File Offset: 0x004DF200
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
				this.m_signRewardListUIController.SignOpenTween(null);
			}
			this.m_signRewardListUIController.SetSignDays();
			this.m_signRewardListUIController.InitSignRewardItem();
			if (this.m_isAutoSign)
			{
				this.m_signRewardListUIController.AutoSign();
			}
		}

		// Token: 0x06013228 RID: 78376 RVA: 0x004E10A4 File Offset: 0x004DF2A4
		private void OnTodaySignItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTodaySignItemClick_hotfix != null)
			{
				this.m_OnTodaySignItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanSignToday();
			if (num == 0)
			{
				EverydaySignNetTask everydaySignNetTask = new EverydaySignNetTask();
				everydaySignNetTask.EventOnStop += delegate(Task task)
				{
					EverydaySignNetTask returnTask = task as EverydaySignNetTask;
					if (returnTask.Result == 0)
					{
						if (returnTask.Rewards != null && returnTask.Rewards.Count != 0)
						{
							this.m_signRewardListUIController.PlaySignAnimation(delegate
							{
								this.m_signRewardListUIController.EnableCloseButton(true);
								GetRewardGoodsUITask.StartUITask(returnTask.Rewards);
								this.UpdateView();
							});
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(returnTask.Result, 2f, null, true);
					}
				};
				everydaySignNetTask.Start(null);
			}
			else
			{
				this.m_signRewardListUIController.EnableCloseButton(true);
				if (num == -500)
				{
					BagFullUITask.StartUITask(this.m_currIntent);
					this.m_isAutoSign = false;
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				}
			}
		}

		// Token: 0x06013229 RID: 78377 RVA: 0x004E117C File Offset: 0x004DF37C
		private void OnTodaySignBoxClick(GoodsType type, int id, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTodaySignBoxClickGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_OnTodaySignBoxClickGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					type2,
					id2,
					count2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoodsType type = type2;
			int id = id2;
			int count = count2;
			SignUITask $this = this;
			int num = this.m_playerContext.CanSignToday();
			if (num == 0)
			{
				EverydaySignNetTask everydaySignNetTask = new EverydaySignNetTask();
				everydaySignNetTask.EventOnStop += delegate(Task task)
				{
					EverydaySignNetTask everydaySignNetTask2 = task as EverydaySignNetTask;
					if (everydaySignNetTask2.Result == 0)
					{
						$this.m_signRewardListUIController.PlaySignAnimation(delegate
						{
							$this.m_signRewardListUIController.EnableCloseButton(true);
							$this.UpdateView();
							$this.HandleBoxOpenNetTask(type, id, count);
						});
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(everydaySignNetTask2.Result, 2f, null, true);
					}
				};
				everydaySignNetTask.Start(null);
			}
			else
			{
				this.m_signRewardListUIController.EnableCloseButton(true);
				if (num == -500)
				{
					BagFullUITask.StartUITask(this.m_currIntent);
					this.m_isAutoSign = false;
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				}
			}
		}

		// Token: 0x0601322A RID: 78378 RVA: 0x004E12A8 File Offset: 0x004DF4A8
		private void HandleBoxOpenNetTask(GoodsType type, int id, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleBoxOpenNetTaskGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_HandleBoxOpenNetTaskGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					type,
					id,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemUseNetTask bagItemUseNetTask = new BagItemUseNetTask(type, id, count);
			bagItemUseNetTask.EventOnStop += delegate(Task task)
			{
				BagItemUseNetTask bagItemUseNetTask2 = task as BagItemUseNetTask;
				if (bagItemUseNetTask2.Result == 0)
				{
					if (bagItemUseNetTask2.Reward != null && bagItemUseNetTask2.Reward.Count > 0)
					{
						GetRewardGoodsUITask.StartUITask(bagItemUseNetTask2.Reward);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(bagItemUseNetTask2.Result, 2f, null, true);
				}
			};
			bagItemUseNetTask.Start(null);
		}

		// Token: 0x0601322B RID: 78379 RVA: 0x004E136C File Offset: 0x004DF56C
		private void OnSignCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSignCloseButtonClick_hotfix != null)
			{
				this.m_OnSignCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			this.m_isAutoSign = true;
			base.ReturnPrevUITask();
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x14000429 RID: 1065
		// (add) Token: 0x0601322C RID: 78380 RVA: 0x004E13F8 File Offset: 0x004DF5F8
		// (remove) Token: 0x0601322D RID: 78381 RVA: 0x004E1494 File Offset: 0x004DF694
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

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0601322E RID: 78382 RVA: 0x004E1530 File Offset: 0x004DF730
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

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0601322F RID: 78383 RVA: 0x004E15A4 File Offset: 0x004DF7A4
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

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x06013230 RID: 78384 RVA: 0x004E1618 File Offset: 0x004DF818
		// (set) Token: 0x06013231 RID: 78385 RVA: 0x004E1638 File Offset: 0x004DF838
		[DoNotToLua]
		public new SignUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SignUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013232 RID: 78386 RVA: 0x004E1644 File Offset: 0x004DF844
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06013233 RID: 78387 RVA: 0x004E1650 File Offset: 0x004DF850
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06013234 RID: 78388 RVA: 0x004E1658 File Offset: 0x004DF858
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06013235 RID: 78389 RVA: 0x004E1660 File Offset: 0x004DF860
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06013236 RID: 78390 RVA: 0x004E166C File Offset: 0x004DF86C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06013237 RID: 78391 RVA: 0x004E1678 File Offset: 0x004DF878
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06013238 RID: 78392 RVA: 0x004E1684 File Offset: 0x004DF884
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06013239 RID: 78393 RVA: 0x004E168C File Offset: 0x004DF88C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0601323A RID: 78394 RVA: 0x004E1694 File Offset: 0x004DF894
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0601323B RID: 78395 RVA: 0x004E169C File Offset: 0x004DF89C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0601323C RID: 78396 RVA: 0x004E16A4 File Offset: 0x004DF8A4
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0601323D RID: 78397 RVA: 0x004E16AC File Offset: 0x004DF8AC
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0601323E RID: 78398 RVA: 0x004E16B4 File Offset: 0x004DF8B4
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0601323F RID: 78399 RVA: 0x004E16BC File Offset: 0x004DF8BC
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06013240 RID: 78400 RVA: 0x004E16C8 File Offset: 0x004DF8C8
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06013241 RID: 78401 RVA: 0x004E16D4 File Offset: 0x004DF8D4
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06013242 RID: 78402 RVA: 0x004E16E0 File Offset: 0x004DF8E0
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06013243 RID: 78403 RVA: 0x004E16EC File Offset: 0x004DF8EC
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06013244 RID: 78404 RVA: 0x004E16F4 File Offset: 0x004DF8F4
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06013245 RID: 78405 RVA: 0x004E16FC File Offset: 0x004DF8FC
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06013246 RID: 78406 RVA: 0x004E1704 File Offset: 0x004DF904
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06013247 RID: 78407 RVA: 0x004E170C File Offset: 0x004DF90C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06013248 RID: 78408 RVA: 0x004E1714 File Offset: 0x004DF914
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06013249 RID: 78409 RVA: 0x004E171C File Offset: 0x004DF91C
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0601324A RID: 78410 RVA: 0x004E173C File Offset: 0x004DF93C
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0601324D RID: 78413 RVA: 0x004E1840 File Offset: 0x004DFA40
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
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnTodaySignItemClick_hotfix = (luaObj.RawGet("OnTodaySignItemClick") as LuaFunction);
					this.m_OnTodaySignBoxClickGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("OnTodaySignBoxClick") as LuaFunction);
					this.m_HandleBoxOpenNetTaskGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("HandleBoxOpenNetTask") as LuaFunction);
					this.m_OnSignCloseButtonClick_hotfix = (luaObj.RawGet("OnSignCloseButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601324E RID: 78414 RVA: 0x004E1A38 File Offset: 0x004DFC38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SignUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AA71 RID: 43633
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "SignRewardListUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Sign_ABS/Prefab/SignUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400AA72 RID: 43634
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "SignRewardListUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.SignRewardListUIController"),
				m_ctrlName = "SignRewardListUIController"
			}
		};

		// Token: 0x0400AA73 RID: 43635
		private SignRewardListUIController m_signRewardListUIController;

		// Token: 0x0400AA74 RID: 43636
		private bool m_isAutoSign = true;

		// Token: 0x0400AA75 RID: 43637
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400AA76 RID: 43638
		[DoNotToLua]
		private SignUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400AA78 RID: 43640
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AA79 RID: 43641
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AA7A RID: 43642
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400AA7B RID: 43643
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400AA7C RID: 43644
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400AA7D RID: 43645
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400AA7E RID: 43646
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400AA7F RID: 43647
		private LuaFunction m_OnTodaySignItemClick_hotfix;

		// Token: 0x0400AA80 RID: 43648
		private LuaFunction m_OnTodaySignBoxClickGoodsTypeInt32Int32_hotfix;

		// Token: 0x0400AA81 RID: 43649
		private LuaFunction m_HandleBoxOpenNetTaskGoodsTypeInt32Int32_hotfix;

		// Token: 0x0400AA82 RID: 43650
		private LuaFunction m_OnSignCloseButtonClick_hotfix;

		// Token: 0x0400AA83 RID: 43651
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400AA84 RID: 43652
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400AA85 RID: 43653
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400AA86 RID: 43654
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000F13 RID: 3859
		public new class LuaExportHelper
		{
			// Token: 0x0601324F RID: 78415 RVA: 0x004E1AA0 File Offset: 0x004DFCA0
			public LuaExportHelper(SignUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013250 RID: 78416 RVA: 0x004E1AB0 File Offset: 0x004DFCB0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06013251 RID: 78417 RVA: 0x004E1AC0 File Offset: 0x004DFCC0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06013252 RID: 78418 RVA: 0x004E1AD0 File Offset: 0x004DFCD0
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06013253 RID: 78419 RVA: 0x004E1AE0 File Offset: 0x004DFCE0
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06013254 RID: 78420 RVA: 0x004E1AF0 File Offset: 0x004DFCF0
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06013255 RID: 78421 RVA: 0x004E1B00 File Offset: 0x004DFD00
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06013256 RID: 78422 RVA: 0x004E1B10 File Offset: 0x004DFD10
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06013257 RID: 78423 RVA: 0x004E1B20 File Offset: 0x004DFD20
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06013258 RID: 78424 RVA: 0x004E1B30 File Offset: 0x004DFD30
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06013259 RID: 78425 RVA: 0x004E1B40 File Offset: 0x004DFD40
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0601325A RID: 78426 RVA: 0x004E1B50 File Offset: 0x004DFD50
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0601325B RID: 78427 RVA: 0x004E1B60 File Offset: 0x004DFD60
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0601325C RID: 78428 RVA: 0x004E1B70 File Offset: 0x004DFD70
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0601325D RID: 78429 RVA: 0x004E1B80 File Offset: 0x004DFD80
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601325E RID: 78430 RVA: 0x004E1B90 File Offset: 0x004DFD90
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0601325F RID: 78431 RVA: 0x004E1BA0 File Offset: 0x004DFDA0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06013260 RID: 78432 RVA: 0x004E1BB0 File Offset: 0x004DFDB0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06013261 RID: 78433 RVA: 0x004E1BC0 File Offset: 0x004DFDC0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06013262 RID: 78434 RVA: 0x004E1BD0 File Offset: 0x004DFDD0
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06013263 RID: 78435 RVA: 0x004E1BE0 File Offset: 0x004DFDE0
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06013264 RID: 78436 RVA: 0x004E1BF0 File Offset: 0x004DFDF0
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06013265 RID: 78437 RVA: 0x004E1C00 File Offset: 0x004DFE00
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06013266 RID: 78438 RVA: 0x004E1C10 File Offset: 0x004DFE10
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x06013267 RID: 78439 RVA: 0x004E1C20 File Offset: 0x004DFE20
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06013268 RID: 78440 RVA: 0x004E1C30 File Offset: 0x004DFE30
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170039B1 RID: 14769
			// (get) Token: 0x06013269 RID: 78441 RVA: 0x004E1C40 File Offset: 0x004DFE40
			// (set) Token: 0x0601326A RID: 78442 RVA: 0x004E1C50 File Offset: 0x004DFE50
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

			// Token: 0x170039B2 RID: 14770
			// (get) Token: 0x0601326B RID: 78443 RVA: 0x004E1C60 File Offset: 0x004DFE60
			// (set) Token: 0x0601326C RID: 78444 RVA: 0x004E1C70 File Offset: 0x004DFE70
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

			// Token: 0x170039B3 RID: 14771
			// (get) Token: 0x0601326D RID: 78445 RVA: 0x004E1C80 File Offset: 0x004DFE80
			// (set) Token: 0x0601326E RID: 78446 RVA: 0x004E1C90 File Offset: 0x004DFE90
			public SignRewardListUIController m_signRewardListUIController
			{
				get
				{
					return this.m_owner.m_signRewardListUIController;
				}
				set
				{
					this.m_owner.m_signRewardListUIController = value;
				}
			}

			// Token: 0x170039B4 RID: 14772
			// (get) Token: 0x0601326F RID: 78447 RVA: 0x004E1CA0 File Offset: 0x004DFEA0
			// (set) Token: 0x06013270 RID: 78448 RVA: 0x004E1CB0 File Offset: 0x004DFEB0
			public bool m_isAutoSign
			{
				get
				{
					return this.m_owner.m_isAutoSign;
				}
				set
				{
					this.m_owner.m_isAutoSign = value;
				}
			}

			// Token: 0x170039B5 RID: 14773
			// (get) Token: 0x06013271 RID: 78449 RVA: 0x004E1CC0 File Offset: 0x004DFEC0
			// (set) Token: 0x06013272 RID: 78450 RVA: 0x004E1CD0 File Offset: 0x004DFED0
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

			// Token: 0x170039B6 RID: 14774
			// (get) Token: 0x06013273 RID: 78451 RVA: 0x004E1CE0 File Offset: 0x004DFEE0
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170039B7 RID: 14775
			// (get) Token: 0x06013274 RID: 78452 RVA: 0x004E1CF0 File Offset: 0x004DFEF0
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06013275 RID: 78453 RVA: 0x004E1D00 File Offset: 0x004DFF00
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06013276 RID: 78454 RVA: 0x004E1D10 File Offset: 0x004DFF10
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06013277 RID: 78455 RVA: 0x004E1D20 File Offset: 0x004DFF20
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06013278 RID: 78456 RVA: 0x004E1D30 File Offset: 0x004DFF30
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06013279 RID: 78457 RVA: 0x004E1D40 File Offset: 0x004DFF40
			public void OnTodaySignItemClick()
			{
				this.m_owner.OnTodaySignItemClick();
			}

			// Token: 0x0601327A RID: 78458 RVA: 0x004E1D50 File Offset: 0x004DFF50
			public void OnTodaySignBoxClick(GoodsType type, int id, int count)
			{
				this.m_owner.OnTodaySignBoxClick(type, id, count);
			}

			// Token: 0x0601327B RID: 78459 RVA: 0x004E1D60 File Offset: 0x004DFF60
			public void HandleBoxOpenNetTask(GoodsType type, int id, int count)
			{
				this.m_owner.HandleBoxOpenNetTask(type, id, count);
			}

			// Token: 0x0601327C RID: 78460 RVA: 0x004E1D70 File Offset: 0x004DFF70
			public void OnSignCloseButtonClick()
			{
				this.m_owner.OnSignCloseButtonClick();
			}

			// Token: 0x0400AA87 RID: 43655
			private SignUITask m_owner;
		}
	}
}
