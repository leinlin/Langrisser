using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B8F RID: 2959
	[HotFix]
	public class ClimbTowerRaidUITask : UITask
	{
		// Token: 0x0600C9AB RID: 51627 RVA: 0x0037B1B8 File Offset: 0x003793B8
		public ClimbTowerRaidUITask(string name) : base(name)
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

		// Token: 0x0600C9AC RID: 51628 RVA: 0x0037B2AC File Offset: 0x003794AC
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

		// Token: 0x0600C9AD RID: 51629 RVA: 0x0037B338 File Offset: 0x00379538
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

		// Token: 0x0600C9AE RID: 51630 RVA: 0x0037B3C4 File Offset: 0x003795C4
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
			this.m_battleReward = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_battleReward = uiintentCustom.GetClassParam<BattleReward>("BattleReward");
			}
		}

		// Token: 0x0600C9AF RID: 51631 RVA: 0x0037B45C File Offset: 0x0037965C
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
			if (this.m_climbTowerRaidUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_climbTowerRaidUIController = (this.m_uiCtrlArray[0] as ClimbTowerRaidUIController);
				}
				if (!(this.m_climbTowerRaidUIController != null))
				{
					Debug.LogError("ClimbTowerRaidUIController is null");
					return;
				}
				this.m_climbTowerRaidUIController.EventOnClose += this.ClimbTowerRaidInfoUIController_OnClose;
			}
		}

		// Token: 0x0600C9B0 RID: 51632 RVA: 0x0037B52C File Offset: 0x0037972C
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
			if (this.m_climbTowerRaidUIController != null)
			{
				this.m_climbTowerRaidUIController.EventOnClose -= this.ClimbTowerRaidInfoUIController_OnClose;
				this.m_climbTowerRaidUIController = null;
			}
		}

		// Token: 0x0600C9B1 RID: 51633 RVA: 0x0037B5C4 File Offset: 0x003797C4
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
			if (this.m_battleReward != null)
			{
				this.m_climbTowerRaidUIController.ShowRaidResult(this.m_battleReward);
			}
		}

		// Token: 0x0600C9B2 RID: 51634 RVA: 0x0037B640 File Offset: 0x00379840
		private void ClimbTowerRaidInfoUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerRaidInfoUIController_OnClose_hotfix != null)
			{
				this.m_ClimbTowerRaidInfoUIController_OnClose_hotfix.call(new object[]
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

		// Token: 0x1400026F RID: 623
		// (add) Token: 0x0600C9B3 RID: 51635 RVA: 0x0037B6BC File Offset: 0x003798BC
		// (remove) Token: 0x0600C9B4 RID: 51636 RVA: 0x0037B758 File Offset: 0x00379958
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

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x0600C9B5 RID: 51637 RVA: 0x0037B7F4 File Offset: 0x003799F4
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

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x0600C9B6 RID: 51638 RVA: 0x0037B868 File Offset: 0x00379A68
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

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x0600C9B7 RID: 51639 RVA: 0x0037B8DC File Offset: 0x00379ADC
		// (set) Token: 0x0600C9B8 RID: 51640 RVA: 0x0037B8FC File Offset: 0x00379AFC
		[DoNotToLua]
		public new ClimbTowerRaidUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClimbTowerRaidUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C9B9 RID: 51641 RVA: 0x0037B908 File Offset: 0x00379B08
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600C9BA RID: 51642 RVA: 0x0037B914 File Offset: 0x00379B14
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600C9BB RID: 51643 RVA: 0x0037B91C File Offset: 0x00379B1C
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600C9BC RID: 51644 RVA: 0x0037B924 File Offset: 0x00379B24
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600C9BD RID: 51645 RVA: 0x0037B930 File Offset: 0x00379B30
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600C9BE RID: 51646 RVA: 0x0037B93C File Offset: 0x00379B3C
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600C9BF RID: 51647 RVA: 0x0037B948 File Offset: 0x00379B48
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600C9C0 RID: 51648 RVA: 0x0037B950 File Offset: 0x00379B50
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600C9C1 RID: 51649 RVA: 0x0037B958 File Offset: 0x00379B58
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600C9C2 RID: 51650 RVA: 0x0037B960 File Offset: 0x00379B60
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600C9C3 RID: 51651 RVA: 0x0037B968 File Offset: 0x00379B68
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600C9C4 RID: 51652 RVA: 0x0037B970 File Offset: 0x00379B70
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600C9C5 RID: 51653 RVA: 0x0037B978 File Offset: 0x00379B78
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600C9C6 RID: 51654 RVA: 0x0037B980 File Offset: 0x00379B80
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600C9C7 RID: 51655 RVA: 0x0037B98C File Offset: 0x00379B8C
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600C9C8 RID: 51656 RVA: 0x0037B998 File Offset: 0x00379B98
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600C9C9 RID: 51657 RVA: 0x0037B9A4 File Offset: 0x00379BA4
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600C9CA RID: 51658 RVA: 0x0037B9B0 File Offset: 0x00379BB0
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600C9CB RID: 51659 RVA: 0x0037B9B8 File Offset: 0x00379BB8
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600C9CC RID: 51660 RVA: 0x0037B9C0 File Offset: 0x00379BC0
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600C9CD RID: 51661 RVA: 0x0037B9C8 File Offset: 0x00379BC8
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600C9CE RID: 51662 RVA: 0x0037B9D0 File Offset: 0x00379BD0
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600C9CF RID: 51663 RVA: 0x0037B9D8 File Offset: 0x00379BD8
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600C9D0 RID: 51664 RVA: 0x0037B9E0 File Offset: 0x00379BE0
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600C9D1 RID: 51665 RVA: 0x0037BA00 File Offset: 0x00379C00
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600C9D2 RID: 51666 RVA: 0x0037BA0C File Offset: 0x00379C0C
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
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_ClimbTowerRaidInfoUIController_OnClose_hotfix = (luaObj.RawGet("ClimbTowerRaidInfoUIController_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C9D3 RID: 51667 RVA: 0x0037BBEC File Offset: 0x00379DEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerRaidUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007F20 RID: 32544
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ClimbTowerRaidUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/ClimbTower_ABS/Prefab/ClimbTowerRaidUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04007F21 RID: 32545
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ClimbTowerRaidUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ClimbTowerRaidUIController"),
				m_ctrlName = "ClimbTowerRaidUIController"
			}
		};

		// Token: 0x04007F22 RID: 32546
		private ClimbTowerRaidUIController m_climbTowerRaidUIController;

		// Token: 0x04007F23 RID: 32547
		private BattleReward m_battleReward;

		// Token: 0x04007F24 RID: 32548
		[DoNotToLua]
		private ClimbTowerRaidUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04007F25 RID: 32549
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007F26 RID: 32550
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007F27 RID: 32551
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04007F28 RID: 32552
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04007F29 RID: 32553
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04007F2A RID: 32554
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04007F2B RID: 32555
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04007F2C RID: 32556
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04007F2D RID: 32557
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04007F2E RID: 32558
		private LuaFunction m_ClimbTowerRaidInfoUIController_OnClose_hotfix;

		// Token: 0x04007F2F RID: 32559
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04007F30 RID: 32560
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04007F31 RID: 32561
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04007F32 RID: 32562
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000B90 RID: 2960
		public new class LuaExportHelper
		{
			// Token: 0x0600C9D4 RID: 51668 RVA: 0x0037BC54 File Offset: 0x00379E54
			public LuaExportHelper(ClimbTowerRaidUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C9D5 RID: 51669 RVA: 0x0037BC64 File Offset: 0x00379E64
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600C9D6 RID: 51670 RVA: 0x0037BC74 File Offset: 0x00379E74
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600C9D7 RID: 51671 RVA: 0x0037BC84 File Offset: 0x00379E84
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600C9D8 RID: 51672 RVA: 0x0037BC94 File Offset: 0x00379E94
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600C9D9 RID: 51673 RVA: 0x0037BCA4 File Offset: 0x00379EA4
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600C9DA RID: 51674 RVA: 0x0037BCB4 File Offset: 0x00379EB4
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600C9DB RID: 51675 RVA: 0x0037BCC4 File Offset: 0x00379EC4
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600C9DC RID: 51676 RVA: 0x0037BCD4 File Offset: 0x00379ED4
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600C9DD RID: 51677 RVA: 0x0037BCE4 File Offset: 0x00379EE4
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600C9DE RID: 51678 RVA: 0x0037BCF4 File Offset: 0x00379EF4
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600C9DF RID: 51679 RVA: 0x0037BD04 File Offset: 0x00379F04
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600C9E0 RID: 51680 RVA: 0x0037BD14 File Offset: 0x00379F14
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600C9E1 RID: 51681 RVA: 0x0037BD24 File Offset: 0x00379F24
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600C9E2 RID: 51682 RVA: 0x0037BD34 File Offset: 0x00379F34
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600C9E3 RID: 51683 RVA: 0x0037BD44 File Offset: 0x00379F44
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600C9E4 RID: 51684 RVA: 0x0037BD54 File Offset: 0x00379F54
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600C9E5 RID: 51685 RVA: 0x0037BD64 File Offset: 0x00379F64
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600C9E6 RID: 51686 RVA: 0x0037BD74 File Offset: 0x00379F74
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600C9E7 RID: 51687 RVA: 0x0037BD84 File Offset: 0x00379F84
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600C9E8 RID: 51688 RVA: 0x0037BD94 File Offset: 0x00379F94
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600C9E9 RID: 51689 RVA: 0x0037BDA4 File Offset: 0x00379FA4
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600C9EA RID: 51690 RVA: 0x0037BDB4 File Offset: 0x00379FB4
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600C9EB RID: 51691 RVA: 0x0037BDC4 File Offset: 0x00379FC4
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600C9EC RID: 51692 RVA: 0x0037BDD4 File Offset: 0x00379FD4
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600C9ED RID: 51693 RVA: 0x0037BDE4 File Offset: 0x00379FE4
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002810 RID: 10256
			// (get) Token: 0x0600C9EE RID: 51694 RVA: 0x0037BDF4 File Offset: 0x00379FF4
			// (set) Token: 0x0600C9EF RID: 51695 RVA: 0x0037BE04 File Offset: 0x0037A004
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

			// Token: 0x17002811 RID: 10257
			// (get) Token: 0x0600C9F0 RID: 51696 RVA: 0x0037BE14 File Offset: 0x0037A014
			// (set) Token: 0x0600C9F1 RID: 51697 RVA: 0x0037BE24 File Offset: 0x0037A024
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

			// Token: 0x17002812 RID: 10258
			// (get) Token: 0x0600C9F2 RID: 51698 RVA: 0x0037BE34 File Offset: 0x0037A034
			// (set) Token: 0x0600C9F3 RID: 51699 RVA: 0x0037BE44 File Offset: 0x0037A044
			public ClimbTowerRaidUIController m_climbTowerRaidUIController
			{
				get
				{
					return this.m_owner.m_climbTowerRaidUIController;
				}
				set
				{
					this.m_owner.m_climbTowerRaidUIController = value;
				}
			}

			// Token: 0x17002813 RID: 10259
			// (get) Token: 0x0600C9F4 RID: 51700 RVA: 0x0037BE54 File Offset: 0x0037A054
			// (set) Token: 0x0600C9F5 RID: 51701 RVA: 0x0037BE64 File Offset: 0x0037A064
			public BattleReward m_battleReward
			{
				get
				{
					return this.m_owner.m_battleReward;
				}
				set
				{
					this.m_owner.m_battleReward = value;
				}
			}

			// Token: 0x17002814 RID: 10260
			// (get) Token: 0x0600C9F6 RID: 51702 RVA: 0x0037BE74 File Offset: 0x0037A074
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002815 RID: 10261
			// (get) Token: 0x0600C9F7 RID: 51703 RVA: 0x0037BE84 File Offset: 0x0037A084
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600C9F8 RID: 51704 RVA: 0x0037BE94 File Offset: 0x0037A094
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600C9F9 RID: 51705 RVA: 0x0037BEA4 File Offset: 0x0037A0A4
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600C9FA RID: 51706 RVA: 0x0037BEB4 File Offset: 0x0037A0B4
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600C9FB RID: 51707 RVA: 0x0037BEC4 File Offset: 0x0037A0C4
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600C9FC RID: 51708 RVA: 0x0037BED4 File Offset: 0x0037A0D4
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600C9FD RID: 51709 RVA: 0x0037BEE4 File Offset: 0x0037A0E4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600C9FE RID: 51710 RVA: 0x0037BEF4 File Offset: 0x0037A0F4
			public void ClimbTowerRaidInfoUIController_OnClose()
			{
				this.m_owner.ClimbTowerRaidInfoUIController_OnClose();
			}

			// Token: 0x04007F33 RID: 32563
			private ClimbTowerRaidUITask m_owner;
		}
	}
}
