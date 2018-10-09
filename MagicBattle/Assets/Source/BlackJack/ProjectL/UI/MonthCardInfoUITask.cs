using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BDA RID: 3034
	[HotFix]
	public class MonthCardInfoUITask : UITask
	{
		// Token: 0x0600D174 RID: 53620 RVA: 0x00394FF8 File Offset: 0x003931F8
		public MonthCardInfoUITask(string name) : base(name)
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

		// Token: 0x0600D175 RID: 53621 RVA: 0x003950EC File Offset: 0x003932EC
		public static MonthCardInfoUITask StartUITask(int cardId, UIIntent returnIntent = null)
		{
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(returnIntent, typeof(MonthCardInfoUITask).Name, null);
			uiintentReturnable.SetParam("MonthCardId", cardId);
			return UIManager.Instance.StartUITask(uiintentReturnable, false, false, null) as MonthCardInfoUITask;
		}

		// Token: 0x0600D176 RID: 53622 RVA: 0x00395134 File Offset: 0x00393334
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

		// Token: 0x0600D177 RID: 53623 RVA: 0x003951C0 File Offset: 0x003933C0
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

		// Token: 0x0600D178 RID: 53624 RVA: 0x0039524C File Offset: 0x0039344C
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
			this.m_monthCardId = 0;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_monthCardId = uiintentCustom.GetStructParam<int>("MonthCardId");
			}
		}

		// Token: 0x0600D179 RID: 53625 RVA: 0x003952E4 File Offset: 0x003934E4
		protected override List<string> CollectAllDynamicResForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAllDynamicResForLoad_hotfix != null)
			{
				return (List<string>)this.m_CollectAllDynamicResForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.CollectSpriteAsset(UIUtility.GetGoodsIconName(GoodsType.GoodsType_MonthCard, this.m_monthCardId));
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600D17A RID: 53626 RVA: 0x0039536C File Offset: 0x0039356C
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
			return true;
		}

		// Token: 0x0600D17B RID: 53627 RVA: 0x003953DC File Offset: 0x003935DC
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
			if (this.m_mainCtrl == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_mainCtrl = (this.m_uiCtrlArray[0] as MonthCardInfoUIController);
				}
				if (this.m_mainCtrl != null)
				{
					this.m_mainCtrl.EventOnClose += this.MainCtrlOnClose;
				}
				else
				{
					Debug.LogError("GetRewardGoodsUIController is null");
				}
			}
		}

		// Token: 0x0600D17C RID: 53628 RVA: 0x003954AC File Offset: 0x003936AC
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
			if (this.m_mainCtrl != null)
			{
				this.m_mainCtrl.EventOnClose -= this.MainCtrlOnClose;
				this.m_mainCtrl = null;
			}
		}

		// Token: 0x0600D17D RID: 53629 RVA: 0x00395544 File Offset: 0x00393744
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
			this.m_mainCtrl.ShowReward(this.m_monthCardId);
		}

		// Token: 0x0600D17E RID: 53630 RVA: 0x003955B8 File Offset: 0x003937B8
		private void MainCtrlOnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MainCtrlOnClose_hotfix != null)
			{
				this.m_MainCtrlOnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x14000287 RID: 647
		// (add) Token: 0x0600D17F RID: 53631 RVA: 0x00395634 File Offset: 0x00393834
		// (remove) Token: 0x0600D180 RID: 53632 RVA: 0x003956D0 File Offset: 0x003938D0
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

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x0600D181 RID: 53633 RVA: 0x0039576C File Offset: 0x0039396C
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

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600D182 RID: 53634 RVA: 0x003957E0 File Offset: 0x003939E0
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

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x0600D183 RID: 53635 RVA: 0x00395854 File Offset: 0x00393A54
		// (set) Token: 0x0600D184 RID: 53636 RVA: 0x00395874 File Offset: 0x00393A74
		[DoNotToLua]
		public new MonthCardInfoUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MonthCardInfoUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D185 RID: 53637 RVA: 0x00395880 File Offset: 0x00393A80
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600D186 RID: 53638 RVA: 0x0039588C File Offset: 0x00393A8C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600D187 RID: 53639 RVA: 0x00395894 File Offset: 0x00393A94
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600D188 RID: 53640 RVA: 0x0039589C File Offset: 0x00393A9C
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600D189 RID: 53641 RVA: 0x003958A8 File Offset: 0x00393AA8
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600D18A RID: 53642 RVA: 0x003958B4 File Offset: 0x00393AB4
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600D18B RID: 53643 RVA: 0x003958C0 File Offset: 0x00393AC0
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600D18C RID: 53644 RVA: 0x003958C8 File Offset: 0x00393AC8
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600D18D RID: 53645 RVA: 0x003958D0 File Offset: 0x00393AD0
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600D18E RID: 53646 RVA: 0x003958D8 File Offset: 0x00393AD8
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600D18F RID: 53647 RVA: 0x003958E0 File Offset: 0x00393AE0
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600D190 RID: 53648 RVA: 0x003958E8 File Offset: 0x00393AE8
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600D191 RID: 53649 RVA: 0x003958F0 File Offset: 0x00393AF0
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600D192 RID: 53650 RVA: 0x003958F8 File Offset: 0x00393AF8
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600D193 RID: 53651 RVA: 0x00395904 File Offset: 0x00393B04
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600D194 RID: 53652 RVA: 0x00395910 File Offset: 0x00393B10
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600D195 RID: 53653 RVA: 0x0039591C File Offset: 0x00393B1C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600D196 RID: 53654 RVA: 0x00395928 File Offset: 0x00393B28
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600D197 RID: 53655 RVA: 0x00395930 File Offset: 0x00393B30
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600D198 RID: 53656 RVA: 0x00395938 File Offset: 0x00393B38
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600D199 RID: 53657 RVA: 0x00395940 File Offset: 0x00393B40
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600D19A RID: 53658 RVA: 0x00395948 File Offset: 0x00393B48
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600D19B RID: 53659 RVA: 0x00395950 File Offset: 0x00393B50
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600D19C RID: 53660 RVA: 0x00395958 File Offset: 0x00393B58
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D19D RID: 53661 RVA: 0x00395978 File Offset: 0x00393B78
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D19E RID: 53662 RVA: 0x00395984 File Offset: 0x00393B84
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
					this.m_CollectAllDynamicResForLoad_hotfix = (luaObj.RawGet("CollectAllDynamicResForLoad") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_MainCtrlOnClose_hotfix = (luaObj.RawGet("MainCtrlOnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D19F RID: 53663 RVA: 0x00395B94 File Offset: 0x00393D94
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MonthCardInfoUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008224 RID: 33316
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "MonthCardInfoUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/MonthCardUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04008225 RID: 33317
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "MonthCardInfoUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.MonthCardInfoUIController"),
				m_ctrlName = "MonthCardInfoUIController"
			}
		};

		// Token: 0x04008226 RID: 33318
		private const string ParamKey_MonthCardId = "MonthCardId";

		// Token: 0x04008227 RID: 33319
		private MonthCardInfoUIController m_mainCtrl;

		// Token: 0x04008228 RID: 33320
		private int m_monthCardId;

		// Token: 0x04008229 RID: 33321
		[DoNotToLua]
		private MonthCardInfoUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400822A RID: 33322
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400822B RID: 33323
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400822C RID: 33324
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400822D RID: 33325
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400822E RID: 33326
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400822F RID: 33327
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04008230 RID: 33328
		private LuaFunction m_CollectAllDynamicResForLoad_hotfix;

		// Token: 0x04008231 RID: 33329
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04008232 RID: 33330
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04008233 RID: 33331
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04008234 RID: 33332
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008235 RID: 33333
		private LuaFunction m_MainCtrlOnClose_hotfix;

		// Token: 0x04008236 RID: 33334
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04008237 RID: 33335
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04008238 RID: 33336
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04008239 RID: 33337
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000BDB RID: 3035
		public new class LuaExportHelper
		{
			// Token: 0x0600D1A0 RID: 53664 RVA: 0x00395BFC File Offset: 0x00393DFC
			public LuaExportHelper(MonthCardInfoUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D1A1 RID: 53665 RVA: 0x00395C0C File Offset: 0x00393E0C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600D1A2 RID: 53666 RVA: 0x00395C1C File Offset: 0x00393E1C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600D1A3 RID: 53667 RVA: 0x00395C2C File Offset: 0x00393E2C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600D1A4 RID: 53668 RVA: 0x00395C3C File Offset: 0x00393E3C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600D1A5 RID: 53669 RVA: 0x00395C4C File Offset: 0x00393E4C
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600D1A6 RID: 53670 RVA: 0x00395C5C File Offset: 0x00393E5C
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600D1A7 RID: 53671 RVA: 0x00395C6C File Offset: 0x00393E6C
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D1A8 RID: 53672 RVA: 0x00395C7C File Offset: 0x00393E7C
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600D1A9 RID: 53673 RVA: 0x00395C8C File Offset: 0x00393E8C
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600D1AA RID: 53674 RVA: 0x00395C9C File Offset: 0x00393E9C
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600D1AB RID: 53675 RVA: 0x00395CAC File Offset: 0x00393EAC
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600D1AC RID: 53676 RVA: 0x00395CBC File Offset: 0x00393EBC
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600D1AD RID: 53677 RVA: 0x00395CCC File Offset: 0x00393ECC
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600D1AE RID: 53678 RVA: 0x00395CDC File Offset: 0x00393EDC
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600D1AF RID: 53679 RVA: 0x00395CEC File Offset: 0x00393EEC
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600D1B0 RID: 53680 RVA: 0x00395CFC File Offset: 0x00393EFC
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600D1B1 RID: 53681 RVA: 0x00395D0C File Offset: 0x00393F0C
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600D1B2 RID: 53682 RVA: 0x00395D1C File Offset: 0x00393F1C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600D1B3 RID: 53683 RVA: 0x00395D2C File Offset: 0x00393F2C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600D1B4 RID: 53684 RVA: 0x00395D3C File Offset: 0x00393F3C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600D1B5 RID: 53685 RVA: 0x00395D4C File Offset: 0x00393F4C
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600D1B6 RID: 53686 RVA: 0x00395D5C File Offset: 0x00393F5C
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600D1B7 RID: 53687 RVA: 0x00395D6C File Offset: 0x00393F6C
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600D1B8 RID: 53688 RVA: 0x00395D7C File Offset: 0x00393F7C
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D1B9 RID: 53689 RVA: 0x00395D8C File Offset: 0x00393F8C
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002936 RID: 10550
			// (get) Token: 0x0600D1BA RID: 53690 RVA: 0x00395D9C File Offset: 0x00393F9C
			// (set) Token: 0x0600D1BB RID: 53691 RVA: 0x00395DAC File Offset: 0x00393FAC
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

			// Token: 0x17002937 RID: 10551
			// (get) Token: 0x0600D1BC RID: 53692 RVA: 0x00395DBC File Offset: 0x00393FBC
			// (set) Token: 0x0600D1BD RID: 53693 RVA: 0x00395DCC File Offset: 0x00393FCC
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

			// Token: 0x17002938 RID: 10552
			// (get) Token: 0x0600D1BE RID: 53694 RVA: 0x00395DDC File Offset: 0x00393FDC
			public static string ParamKey_MonthCardId
			{
				get
				{
					return "MonthCardId";
				}
			}

			// Token: 0x17002939 RID: 10553
			// (get) Token: 0x0600D1BF RID: 53695 RVA: 0x00395DE4 File Offset: 0x00393FE4
			// (set) Token: 0x0600D1C0 RID: 53696 RVA: 0x00395DF4 File Offset: 0x00393FF4
			public MonthCardInfoUIController m_mainCtrl
			{
				get
				{
					return this.m_owner.m_mainCtrl;
				}
				set
				{
					this.m_owner.m_mainCtrl = value;
				}
			}

			// Token: 0x1700293A RID: 10554
			// (get) Token: 0x0600D1C1 RID: 53697 RVA: 0x00395E04 File Offset: 0x00394004
			// (set) Token: 0x0600D1C2 RID: 53698 RVA: 0x00395E14 File Offset: 0x00394014
			public int m_monthCardId
			{
				get
				{
					return this.m_owner.m_monthCardId;
				}
				set
				{
					this.m_owner.m_monthCardId = value;
				}
			}

			// Token: 0x1700293B RID: 10555
			// (get) Token: 0x0600D1C3 RID: 53699 RVA: 0x00395E24 File Offset: 0x00394024
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x1700293C RID: 10556
			// (get) Token: 0x0600D1C4 RID: 53700 RVA: 0x00395E34 File Offset: 0x00394034
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600D1C5 RID: 53701 RVA: 0x00395E44 File Offset: 0x00394044
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600D1C6 RID: 53702 RVA: 0x00395E54 File Offset: 0x00394054
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600D1C7 RID: 53703 RVA: 0x00395E64 File Offset: 0x00394064
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600D1C8 RID: 53704 RVA: 0x00395E74 File Offset: 0x00394074
			public List<string> CollectAllDynamicResForLoad()
			{
				return this.m_owner.CollectAllDynamicResForLoad();
			}

			// Token: 0x0600D1C9 RID: 53705 RVA: 0x00395E84 File Offset: 0x00394084
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D1CA RID: 53706 RVA: 0x00395E94 File Offset: 0x00394094
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600D1CB RID: 53707 RVA: 0x00395EA4 File Offset: 0x003940A4
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600D1CC RID: 53708 RVA: 0x00395EB4 File Offset: 0x003940B4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600D1CD RID: 53709 RVA: 0x00395EC4 File Offset: 0x003940C4
			public void MainCtrlOnClose()
			{
				this.m_owner.MainCtrlOnClose();
			}

			// Token: 0x0400823A RID: 33338
			private MonthCardInfoUITask m_owner;
		}
	}
}
