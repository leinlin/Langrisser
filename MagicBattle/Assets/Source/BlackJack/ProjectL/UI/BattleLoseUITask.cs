using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A78 RID: 2680
	[HotFix]
	public class BattleLoseUITask : UITask
	{
		// Token: 0x0600A8A8 RID: 43176 RVA: 0x002F1688 File Offset: 0x002EF888
		public BattleLoseUITask(string name) : base(name)
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

		// Token: 0x0600A8A9 RID: 43177 RVA: 0x002F177C File Offset: 0x002EF97C
		public static BattleLoseUITask StartUITask()
		{
			UIIntent intent = new UIIntent(typeof(BattleLoseUITask).Name, null);
			return UIManager.Instance.StartUITask(intent, false, false, null) as BattleLoseUITask;
		}

		// Token: 0x0600A8AA RID: 43178 RVA: 0x002F17B4 File Offset: 0x002EF9B4
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
			if (this.m_battleLoseUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_battleLoseUIController = (this.m_uiCtrlArray[0] as BattleLoseUIController);
				}
				if (!(this.m_battleLoseUIController != null))
				{
					Debug.LogError("BattleLoseUIController is null");
					return;
				}
				this.m_battleLoseUIController.EventOnClose += this.BattleLoseUIController_OnClose;
			}
		}

		// Token: 0x0600A8AB RID: 43179 RVA: 0x002F1884 File Offset: 0x002EFA84
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
			if (this.m_battleLoseUIController != null)
			{
				this.m_battleLoseUIController.EventOnClose -= this.BattleLoseUIController_OnClose;
				this.m_battleLoseUIController = null;
			}
		}

		// Token: 0x0600A8AC RID: 43180 RVA: 0x002F191C File Offset: 0x002EFB1C
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
		}

		// Token: 0x0600A8AD RID: 43181 RVA: 0x002F197C File Offset: 0x002EFB7C
		private void BattleLoseUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleLoseUIController_OnClose_hotfix != null)
			{
				this.m_BattleLoseUIController_OnClose_hotfix.call(new object[]
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

		// Token: 0x140001F5 RID: 501
		// (add) Token: 0x0600A8AE RID: 43182 RVA: 0x002F19F8 File Offset: 0x002EFBF8
		// (remove) Token: 0x0600A8AF RID: 43183 RVA: 0x002F1A94 File Offset: 0x002EFC94
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

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x0600A8B0 RID: 43184 RVA: 0x002F1B30 File Offset: 0x002EFD30
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

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x0600A8B1 RID: 43185 RVA: 0x002F1BA4 File Offset: 0x002EFDA4
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

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x0600A8B2 RID: 43186 RVA: 0x002F1C18 File Offset: 0x002EFE18
		// (set) Token: 0x0600A8B3 RID: 43187 RVA: 0x002F1C38 File Offset: 0x002EFE38
		[DoNotToLua]
		public new BattleLoseUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleLoseUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A8B4 RID: 43188 RVA: 0x002F1C44 File Offset: 0x002EFE44
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600A8B5 RID: 43189 RVA: 0x002F1C50 File Offset: 0x002EFE50
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600A8B6 RID: 43190 RVA: 0x002F1C58 File Offset: 0x002EFE58
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x002F1C60 File Offset: 0x002EFE60
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x002F1C6C File Offset: 0x002EFE6C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x002F1C78 File Offset: 0x002EFE78
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600A8BA RID: 43194 RVA: 0x002F1C84 File Offset: 0x002EFE84
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600A8BB RID: 43195 RVA: 0x002F1C8C File Offset: 0x002EFE8C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600A8BC RID: 43196 RVA: 0x002F1C94 File Offset: 0x002EFE94
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600A8BD RID: 43197 RVA: 0x002F1C9C File Offset: 0x002EFE9C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600A8BE RID: 43198 RVA: 0x002F1CA4 File Offset: 0x002EFEA4
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600A8BF RID: 43199 RVA: 0x002F1CAC File Offset: 0x002EFEAC
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x002F1CB4 File Offset: 0x002EFEB4
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x002F1CBC File Offset: 0x002EFEBC
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600A8C2 RID: 43202 RVA: 0x002F1CC8 File Offset: 0x002EFEC8
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600A8C3 RID: 43203 RVA: 0x002F1CD4 File Offset: 0x002EFED4
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600A8C4 RID: 43204 RVA: 0x002F1CE0 File Offset: 0x002EFEE0
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600A8C5 RID: 43205 RVA: 0x002F1CEC File Offset: 0x002EFEEC
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x002F1CF4 File Offset: 0x002EFEF4
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x002F1CFC File Offset: 0x002EFEFC
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600A8C8 RID: 43208 RVA: 0x002F1D04 File Offset: 0x002EFF04
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600A8C9 RID: 43209 RVA: 0x002F1D0C File Offset: 0x002EFF0C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600A8CA RID: 43210 RVA: 0x002F1D14 File Offset: 0x002EFF14
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600A8CB RID: 43211 RVA: 0x002F1D1C File Offset: 0x002EFF1C
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600A8CC RID: 43212 RVA: 0x002F1D3C File Offset: 0x002EFF3C
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600A8CD RID: 43213 RVA: 0x002F1D48 File Offset: 0x002EFF48
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
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_BattleLoseUIController_OnClose_hotfix = (luaObj.RawGet("BattleLoseUIController_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A8CE RID: 43214 RVA: 0x002F1EDC File Offset: 0x002F00DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleLoseUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006F47 RID: 28487
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleLoseUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleLoseUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04006F48 RID: 28488
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleLoseUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleLoseUIController"),
				m_ctrlName = "BattleLoseUIController"
			}
		};

		// Token: 0x04006F49 RID: 28489
		private BattleLoseUIController m_battleLoseUIController;

		// Token: 0x04006F4A RID: 28490
		[DoNotToLua]
		private BattleLoseUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04006F4B RID: 28491
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006F4C RID: 28492
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006F4D RID: 28493
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04006F4E RID: 28494
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04006F4F RID: 28495
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04006F50 RID: 28496
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04006F51 RID: 28497
		private LuaFunction m_BattleLoseUIController_OnClose_hotfix;

		// Token: 0x04006F52 RID: 28498
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04006F53 RID: 28499
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04006F54 RID: 28500
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04006F55 RID: 28501
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000A79 RID: 2681
		public new class LuaExportHelper
		{
			// Token: 0x0600A8CF RID: 43215 RVA: 0x002F1F44 File Offset: 0x002F0144
			public LuaExportHelper(BattleLoseUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A8D0 RID: 43216 RVA: 0x002F1F54 File Offset: 0x002F0154
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600A8D1 RID: 43217 RVA: 0x002F1F64 File Offset: 0x002F0164
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600A8D2 RID: 43218 RVA: 0x002F1F74 File Offset: 0x002F0174
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600A8D3 RID: 43219 RVA: 0x002F1F84 File Offset: 0x002F0184
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600A8D4 RID: 43220 RVA: 0x002F1F94 File Offset: 0x002F0194
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600A8D5 RID: 43221 RVA: 0x002F1FA4 File Offset: 0x002F01A4
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600A8D6 RID: 43222 RVA: 0x002F1FB4 File Offset: 0x002F01B4
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600A8D7 RID: 43223 RVA: 0x002F1FC4 File Offset: 0x002F01C4
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600A8D8 RID: 43224 RVA: 0x002F1FD4 File Offset: 0x002F01D4
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600A8D9 RID: 43225 RVA: 0x002F1FE4 File Offset: 0x002F01E4
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600A8DA RID: 43226 RVA: 0x002F1FF4 File Offset: 0x002F01F4
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600A8DB RID: 43227 RVA: 0x002F2004 File Offset: 0x002F0204
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600A8DC RID: 43228 RVA: 0x002F2014 File Offset: 0x002F0214
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600A8DD RID: 43229 RVA: 0x002F2024 File Offset: 0x002F0224
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600A8DE RID: 43230 RVA: 0x002F2034 File Offset: 0x002F0234
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600A8DF RID: 43231 RVA: 0x002F2044 File Offset: 0x002F0244
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600A8E0 RID: 43232 RVA: 0x002F2054 File Offset: 0x002F0254
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600A8E1 RID: 43233 RVA: 0x002F2064 File Offset: 0x002F0264
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600A8E2 RID: 43234 RVA: 0x002F2074 File Offset: 0x002F0274
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600A8E3 RID: 43235 RVA: 0x002F2084 File Offset: 0x002F0284
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600A8E4 RID: 43236 RVA: 0x002F2094 File Offset: 0x002F0294
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600A8E5 RID: 43237 RVA: 0x002F20A4 File Offset: 0x002F02A4
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600A8E6 RID: 43238 RVA: 0x002F20B4 File Offset: 0x002F02B4
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600A8E7 RID: 43239 RVA: 0x002F20C4 File Offset: 0x002F02C4
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600A8E8 RID: 43240 RVA: 0x002F20D4 File Offset: 0x002F02D4
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002229 RID: 8745
			// (get) Token: 0x0600A8E9 RID: 43241 RVA: 0x002F20E4 File Offset: 0x002F02E4
			// (set) Token: 0x0600A8EA RID: 43242 RVA: 0x002F20F4 File Offset: 0x002F02F4
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

			// Token: 0x1700222A RID: 8746
			// (get) Token: 0x0600A8EB RID: 43243 RVA: 0x002F2104 File Offset: 0x002F0304
			// (set) Token: 0x0600A8EC RID: 43244 RVA: 0x002F2114 File Offset: 0x002F0314
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

			// Token: 0x1700222B RID: 8747
			// (get) Token: 0x0600A8ED RID: 43245 RVA: 0x002F2124 File Offset: 0x002F0324
			// (set) Token: 0x0600A8EE RID: 43246 RVA: 0x002F2134 File Offset: 0x002F0334
			public BattleLoseUIController m_battleLoseUIController
			{
				get
				{
					return this.m_owner.m_battleLoseUIController;
				}
				set
				{
					this.m_owner.m_battleLoseUIController = value;
				}
			}

			// Token: 0x1700222C RID: 8748
			// (get) Token: 0x0600A8EF RID: 43247 RVA: 0x002F2144 File Offset: 0x002F0344
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x1700222D RID: 8749
			// (get) Token: 0x0600A8F0 RID: 43248 RVA: 0x002F2154 File Offset: 0x002F0354
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600A8F1 RID: 43249 RVA: 0x002F2164 File Offset: 0x002F0364
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600A8F2 RID: 43250 RVA: 0x002F2174 File Offset: 0x002F0374
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600A8F3 RID: 43251 RVA: 0x002F2184 File Offset: 0x002F0384
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600A8F4 RID: 43252 RVA: 0x002F2194 File Offset: 0x002F0394
			public void BattleLoseUIController_OnClose()
			{
				this.m_owner.BattleLoseUIController_OnClose();
			}

			// Token: 0x04006F56 RID: 28502
			private BattleLoseUITask m_owner;
		}
	}
}
