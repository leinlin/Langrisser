using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using PD.SDK;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BE2 RID: 3042
	[HotFix]
	public class PlayerLevelUpUITask : UITask
	{
		// Token: 0x0600D225 RID: 53797 RVA: 0x00396C44 File Offset: 0x00394E44
		public PlayerLevelUpUITask(string name) : base(name)
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

		// Token: 0x0600D226 RID: 53798 RVA: 0x00396D38 File Offset: 0x00394F38
		public static PlayerLevelUpUITask StartUITask(int oldLevel, int newLevel)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(PlayerLevelUpUITask).Name, null);
			uiintentCustom.SetParam("OldPlayerLevel", oldLevel);
			uiintentCustom.SetParam("NewPlayerLevel", newLevel);
			if (PDSDK.Instance != null && PDSDK.IsInit)
			{
				PDSDK.Instance.doSetExtData(LoginUITask.PDSDKGameRoleJsonString, "RoleLevelUp");
			}
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as PlayerLevelUpUITask;
		}

		// Token: 0x0600D227 RID: 53799 RVA: 0x00396DC0 File Offset: 0x00394FC0
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
			bool flag = base.OnStart(intent);
			if (!flag)
			{
				Debug.LogError("PlayerLevelUpUITask base.OnStart fail");
				return flag;
			}
			return flag;
		}

		// Token: 0x0600D228 RID: 53800 RVA: 0x00396E60 File Offset: 0x00395060
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

		// Token: 0x0600D229 RID: 53801 RVA: 0x00396EEC File Offset: 0x003950EC
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
			if (this.m_playerLevelUpUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_playerLevelUpUIController = (this.m_uiCtrlArray[0] as PlayerLevelUpUIController);
				}
				if (!(this.m_playerLevelUpUIController != null))
				{
					Debug.LogError("PlayerLevelUpUIController is null");
					return;
				}
				this.m_playerLevelUpUIController.EventOnClose += this.OnClose;
			}
		}

		// Token: 0x0600D22A RID: 53802 RVA: 0x00396FBC File Offset: 0x003951BC
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
			if (this.m_playerLevelUpUIController != null)
			{
				this.m_playerLevelUpUIController.EventOnClose -= this.OnClose;
				this.m_playerLevelUpUIController = null;
			}
		}

		// Token: 0x0600D22B RID: 53803 RVA: 0x00397054 File Offset: 0x00395254
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
			this.m_playerLevelUpUIController.ShowPlayerLevelUp(this.m_oldPlayerLevel, this.m_newPlayerLevel);
		}

		// Token: 0x0600D22C RID: 53804 RVA: 0x003970CC File Offset: 0x003952CC
		private void OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClose_hotfix != null)
			{
				this.m_OnClose_hotfix.call(new object[]
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

		// Token: 0x0600D22D RID: 53805 RVA: 0x00397148 File Offset: 0x00395348
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
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_oldPlayerLevel = uiintentCustom.GetStructParam<int>("OldPlayerLevel");
				this.m_newPlayerLevel = uiintentCustom.GetStructParam<int>("NewPlayerLevel");
			}
		}

		// Token: 0x14000289 RID: 649
		// (add) Token: 0x0600D22E RID: 53806 RVA: 0x003971E8 File Offset: 0x003953E8
		// (remove) Token: 0x0600D22F RID: 53807 RVA: 0x00397284 File Offset: 0x00395484
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

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x0600D230 RID: 53808 RVA: 0x00397320 File Offset: 0x00395520
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

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x0600D231 RID: 53809 RVA: 0x00397394 File Offset: 0x00395594
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

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x0600D232 RID: 53810 RVA: 0x00397408 File Offset: 0x00395608
		// (set) Token: 0x0600D233 RID: 53811 RVA: 0x00397428 File Offset: 0x00395628
		[DoNotToLua]
		public new PlayerLevelUpUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerLevelUpUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D234 RID: 53812 RVA: 0x00397434 File Offset: 0x00395634
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600D235 RID: 53813 RVA: 0x00397440 File Offset: 0x00395640
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600D236 RID: 53814 RVA: 0x00397448 File Offset: 0x00395648
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600D237 RID: 53815 RVA: 0x00397450 File Offset: 0x00395650
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600D238 RID: 53816 RVA: 0x0039745C File Offset: 0x0039565C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600D239 RID: 53817 RVA: 0x00397468 File Offset: 0x00395668
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600D23A RID: 53818 RVA: 0x00397474 File Offset: 0x00395674
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600D23B RID: 53819 RVA: 0x0039747C File Offset: 0x0039567C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600D23C RID: 53820 RVA: 0x00397484 File Offset: 0x00395684
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600D23D RID: 53821 RVA: 0x0039748C File Offset: 0x0039568C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600D23E RID: 53822 RVA: 0x00397494 File Offset: 0x00395694
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600D23F RID: 53823 RVA: 0x0039749C File Offset: 0x0039569C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600D240 RID: 53824 RVA: 0x003974A4 File Offset: 0x003956A4
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600D241 RID: 53825 RVA: 0x003974AC File Offset: 0x003956AC
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600D242 RID: 53826 RVA: 0x003974B8 File Offset: 0x003956B8
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600D243 RID: 53827 RVA: 0x003974C4 File Offset: 0x003956C4
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600D244 RID: 53828 RVA: 0x003974D0 File Offset: 0x003956D0
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600D245 RID: 53829 RVA: 0x003974DC File Offset: 0x003956DC
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600D246 RID: 53830 RVA: 0x003974E4 File Offset: 0x003956E4
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600D247 RID: 53831 RVA: 0x003974EC File Offset: 0x003956EC
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600D248 RID: 53832 RVA: 0x003974F4 File Offset: 0x003956F4
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600D249 RID: 53833 RVA: 0x003974FC File Offset: 0x003956FC
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600D24A RID: 53834 RVA: 0x00397504 File Offset: 0x00395704
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600D24B RID: 53835 RVA: 0x0039750C File Offset: 0x0039570C
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D24C RID: 53836 RVA: 0x0039752C File Offset: 0x0039572C
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D24D RID: 53837 RVA: 0x00397538 File Offset: 0x00395738
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
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnClose_hotfix = (luaObj.RawGet("OnClose") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D24E RID: 53838 RVA: 0x00397718 File Offset: 0x00395918
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerLevelUpUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008265 RID: 33381
		private const string ParamKey_OldPlayerLevel = "OldPlayerLevel";

		// Token: 0x04008266 RID: 33382
		private const string ParamKey_NewPlayerLevel = "NewPlayerLevel";

		// Token: 0x04008267 RID: 33383
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "PlayerLevelUpUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/PlayerLevelUpUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04008268 RID: 33384
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "PlayerLevelUpUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerLevelUpUIController"),
				m_ctrlName = "PlayerLevelUpUIController"
			}
		};

		// Token: 0x04008269 RID: 33385
		private PlayerLevelUpUIController m_playerLevelUpUIController;

		// Token: 0x0400826A RID: 33386
		private int m_oldPlayerLevel;

		// Token: 0x0400826B RID: 33387
		private int m_newPlayerLevel;

		// Token: 0x0400826C RID: 33388
		[DoNotToLua]
		private PlayerLevelUpUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400826D RID: 33389
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400826E RID: 33390
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400826F RID: 33391
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04008270 RID: 33392
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04008271 RID: 33393
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04008272 RID: 33394
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04008273 RID: 33395
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04008274 RID: 33396
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008275 RID: 33397
		private LuaFunction m_OnClose_hotfix;

		// Token: 0x04008276 RID: 33398
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04008277 RID: 33399
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04008278 RID: 33400
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04008279 RID: 33401
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400827A RID: 33402
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000BE3 RID: 3043
		public new class LuaExportHelper
		{
			// Token: 0x0600D24F RID: 53839 RVA: 0x00397780 File Offset: 0x00395980
			public LuaExportHelper(PlayerLevelUpUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D250 RID: 53840 RVA: 0x00397790 File Offset: 0x00395990
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600D251 RID: 53841 RVA: 0x003977A0 File Offset: 0x003959A0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600D252 RID: 53842 RVA: 0x003977B0 File Offset: 0x003959B0
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600D253 RID: 53843 RVA: 0x003977C0 File Offset: 0x003959C0
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600D254 RID: 53844 RVA: 0x003977D0 File Offset: 0x003959D0
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600D255 RID: 53845 RVA: 0x003977E0 File Offset: 0x003959E0
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600D256 RID: 53846 RVA: 0x003977F0 File Offset: 0x003959F0
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D257 RID: 53847 RVA: 0x00397800 File Offset: 0x00395A00
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600D258 RID: 53848 RVA: 0x00397810 File Offset: 0x00395A10
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600D259 RID: 53849 RVA: 0x00397820 File Offset: 0x00395A20
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600D25A RID: 53850 RVA: 0x00397830 File Offset: 0x00395A30
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600D25B RID: 53851 RVA: 0x00397840 File Offset: 0x00395A40
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600D25C RID: 53852 RVA: 0x00397850 File Offset: 0x00395A50
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600D25D RID: 53853 RVA: 0x00397860 File Offset: 0x00395A60
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600D25E RID: 53854 RVA: 0x00397870 File Offset: 0x00395A70
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600D25F RID: 53855 RVA: 0x00397880 File Offset: 0x00395A80
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600D260 RID: 53856 RVA: 0x00397890 File Offset: 0x00395A90
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600D261 RID: 53857 RVA: 0x003978A0 File Offset: 0x00395AA0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600D262 RID: 53858 RVA: 0x003978B0 File Offset: 0x00395AB0
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600D263 RID: 53859 RVA: 0x003978C0 File Offset: 0x00395AC0
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600D264 RID: 53860 RVA: 0x003978D0 File Offset: 0x00395AD0
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600D265 RID: 53861 RVA: 0x003978E0 File Offset: 0x00395AE0
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600D266 RID: 53862 RVA: 0x003978F0 File Offset: 0x00395AF0
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600D267 RID: 53863 RVA: 0x00397900 File Offset: 0x00395B00
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D268 RID: 53864 RVA: 0x00397910 File Offset: 0x00395B10
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x1700294E RID: 10574
			// (get) Token: 0x0600D269 RID: 53865 RVA: 0x00397920 File Offset: 0x00395B20
			public static string ParamKey_OldPlayerLevel
			{
				get
				{
					return "OldPlayerLevel";
				}
			}

			// Token: 0x1700294F RID: 10575
			// (get) Token: 0x0600D26A RID: 53866 RVA: 0x00397928 File Offset: 0x00395B28
			public static string ParamKey_NewPlayerLevel
			{
				get
				{
					return "NewPlayerLevel";
				}
			}

			// Token: 0x17002950 RID: 10576
			// (get) Token: 0x0600D26B RID: 53867 RVA: 0x00397930 File Offset: 0x00395B30
			// (set) Token: 0x0600D26C RID: 53868 RVA: 0x00397940 File Offset: 0x00395B40
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

			// Token: 0x17002951 RID: 10577
			// (get) Token: 0x0600D26D RID: 53869 RVA: 0x00397950 File Offset: 0x00395B50
			// (set) Token: 0x0600D26E RID: 53870 RVA: 0x00397960 File Offset: 0x00395B60
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

			// Token: 0x17002952 RID: 10578
			// (get) Token: 0x0600D26F RID: 53871 RVA: 0x00397970 File Offset: 0x00395B70
			// (set) Token: 0x0600D270 RID: 53872 RVA: 0x00397980 File Offset: 0x00395B80
			public PlayerLevelUpUIController m_playerLevelUpUIController
			{
				get
				{
					return this.m_owner.m_playerLevelUpUIController;
				}
				set
				{
					this.m_owner.m_playerLevelUpUIController = value;
				}
			}

			// Token: 0x17002953 RID: 10579
			// (get) Token: 0x0600D271 RID: 53873 RVA: 0x00397990 File Offset: 0x00395B90
			// (set) Token: 0x0600D272 RID: 53874 RVA: 0x003979A0 File Offset: 0x00395BA0
			public int m_oldPlayerLevel
			{
				get
				{
					return this.m_owner.m_oldPlayerLevel;
				}
				set
				{
					this.m_owner.m_oldPlayerLevel = value;
				}
			}

			// Token: 0x17002954 RID: 10580
			// (get) Token: 0x0600D273 RID: 53875 RVA: 0x003979B0 File Offset: 0x00395BB0
			// (set) Token: 0x0600D274 RID: 53876 RVA: 0x003979C0 File Offset: 0x00395BC0
			public int m_newPlayerLevel
			{
				get
				{
					return this.m_owner.m_newPlayerLevel;
				}
				set
				{
					this.m_owner.m_newPlayerLevel = value;
				}
			}

			// Token: 0x17002955 RID: 10581
			// (get) Token: 0x0600D275 RID: 53877 RVA: 0x003979D0 File Offset: 0x00395BD0
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002956 RID: 10582
			// (get) Token: 0x0600D276 RID: 53878 RVA: 0x003979E0 File Offset: 0x00395BE0
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600D277 RID: 53879 RVA: 0x003979F0 File Offset: 0x00395BF0
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600D278 RID: 53880 RVA: 0x00397A00 File Offset: 0x00395C00
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600D279 RID: 53881 RVA: 0x00397A10 File Offset: 0x00395C10
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600D27A RID: 53882 RVA: 0x00397A20 File Offset: 0x00395C20
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600D27B RID: 53883 RVA: 0x00397A30 File Offset: 0x00395C30
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600D27C RID: 53884 RVA: 0x00397A40 File Offset: 0x00395C40
			public void OnClose()
			{
				this.m_owner.OnClose();
			}

			// Token: 0x0600D27D RID: 53885 RVA: 0x00397A50 File Offset: 0x00395C50
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0400827B RID: 33403
			private PlayerLevelUpUITask m_owner;
		}
	}
}
