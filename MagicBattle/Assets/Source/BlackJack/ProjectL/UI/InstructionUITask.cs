using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BCA RID: 3018
	[HotFix]
	public class InstructionUITask : UITask
	{
		// Token: 0x0600CFDA RID: 53210 RVA: 0x0038FFA4 File Offset: 0x0038E1A4
		public InstructionUITask(string name) : base(name)
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

		// Token: 0x0600CFDB RID: 53211 RVA: 0x00390098 File Offset: 0x0038E298
		public static InstructionUITask StartUITask(string prefabName)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(InstructionUITask).Name, null);
			uiintentCustom.SetParam("PrefabName", prefabName);
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as InstructionUITask;
		}

		// Token: 0x0600CFDC RID: 53212 RVA: 0x003900DC File Offset: 0x0038E2DC
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

		// Token: 0x0600CFDD RID: 53213 RVA: 0x00390168 File Offset: 0x0038E368
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

		// Token: 0x0600CFDE RID: 53214 RVA: 0x003901F4 File Offset: 0x0038E3F4
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
			this.m_prefabName = string.Empty;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_prefabName = uiintentCustom.GetClassParam<string>("PrefabName");
			}
		}

		// Token: 0x0600CFDF RID: 53215 RVA: 0x00390290 File Offset: 0x0038E490
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
			base.CollectAsset(this.m_prefabName);
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CFE0 RID: 53216 RVA: 0x00390314 File Offset: 0x0038E514
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
			if (this.m_instructionUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_instructionUIController = (this.m_uiCtrlArray[0] as InstructionUIController);
				}
				if (this.m_instructionUIController != null)
				{
					this.m_instructionUIController.EventOnClose += this.InstructionUIController_OnClose;
				}
				else
				{
					Debug.LogError("InstructionUIController is null");
				}
			}
		}

		// Token: 0x0600CFE1 RID: 53217 RVA: 0x003903E4 File Offset: 0x0038E5E4
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
			if (this.m_instructionUIController != null)
			{
				this.m_instructionUIController.EventOnClose -= this.InstructionUIController_OnClose;
				this.m_instructionUIController = null;
			}
		}

		// Token: 0x0600CFE2 RID: 53218 RVA: 0x0039047C File Offset: 0x0038E67C
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
			this.m_instructionUIController.Show(this.m_prefabName);
		}

		// Token: 0x0600CFE3 RID: 53219 RVA: 0x003904F0 File Offset: 0x0038E6F0
		private void InstructionUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InstructionUIController_OnClose_hotfix != null)
			{
				this.m_InstructionUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Stop();
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x0600CFE4 RID: 53220 RVA: 0x00390558 File Offset: 0x0038E758
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

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x0600CFE5 RID: 53221 RVA: 0x003905CC File Offset: 0x0038E7CC
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

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x0600CFE6 RID: 53222 RVA: 0x00390640 File Offset: 0x0038E840
		// (set) Token: 0x0600CFE7 RID: 53223 RVA: 0x00390660 File Offset: 0x0038E860
		[DoNotToLua]
		public new InstructionUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new InstructionUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CFE8 RID: 53224 RVA: 0x0039066C File Offset: 0x0038E86C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600CFE9 RID: 53225 RVA: 0x00390678 File Offset: 0x0038E878
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600CFEA RID: 53226 RVA: 0x00390680 File Offset: 0x0038E880
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600CFEB RID: 53227 RVA: 0x00390688 File Offset: 0x0038E888
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600CFEC RID: 53228 RVA: 0x00390694 File Offset: 0x0038E894
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600CFED RID: 53229 RVA: 0x003906A0 File Offset: 0x0038E8A0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600CFEE RID: 53230 RVA: 0x003906AC File Offset: 0x0038E8AC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CFEF RID: 53231 RVA: 0x003906B4 File Offset: 0x0038E8B4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600CFF0 RID: 53232 RVA: 0x003906BC File Offset: 0x0038E8BC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600CFF1 RID: 53233 RVA: 0x003906C4 File Offset: 0x0038E8C4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600CFF2 RID: 53234 RVA: 0x003906CC File Offset: 0x0038E8CC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600CFF3 RID: 53235 RVA: 0x003906D4 File Offset: 0x0038E8D4
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600CFF4 RID: 53236 RVA: 0x003906DC File Offset: 0x0038E8DC
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600CFF5 RID: 53237 RVA: 0x003906E4 File Offset: 0x0038E8E4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600CFF6 RID: 53238 RVA: 0x003906F0 File Offset: 0x0038E8F0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600CFF7 RID: 53239 RVA: 0x003906FC File Offset: 0x0038E8FC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600CFF8 RID: 53240 RVA: 0x00390708 File Offset: 0x0038E908
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600CFF9 RID: 53241 RVA: 0x00390714 File Offset: 0x0038E914
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600CFFA RID: 53242 RVA: 0x0039071C File Offset: 0x0038E91C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600CFFB RID: 53243 RVA: 0x00390724 File Offset: 0x0038E924
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600CFFC RID: 53244 RVA: 0x0039072C File Offset: 0x0038E92C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600CFFD RID: 53245 RVA: 0x00390734 File Offset: 0x0038E934
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600CFFE RID: 53246 RVA: 0x0039073C File Offset: 0x0038E93C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600CFFF RID: 53247 RVA: 0x00390744 File Offset: 0x0038E944
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
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_InstructionUIController_OnClose_hotfix = (luaObj.RawGet("InstructionUIController_OnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D000 RID: 53248 RVA: 0x0039090C File Offset: 0x0038EB0C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(InstructionUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008192 RID: 33170
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "InstructionUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/InstructionUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04008193 RID: 33171
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "InstructionUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.InstructionUIController"),
				m_ctrlName = "InstructionUIController"
			}
		};

		// Token: 0x04008194 RID: 33172
		private InstructionUIController m_instructionUIController;

		// Token: 0x04008195 RID: 33173
		private string m_prefabName;

		// Token: 0x04008196 RID: 33174
		[DoNotToLua]
		private InstructionUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04008197 RID: 33175
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008198 RID: 33176
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008199 RID: 33177
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400819A RID: 33178
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400819B RID: 33179
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400819C RID: 33180
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400819D RID: 33181
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400819E RID: 33182
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400819F RID: 33183
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040081A0 RID: 33184
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040081A1 RID: 33185
		private LuaFunction m_InstructionUIController_OnClose_hotfix;

		// Token: 0x040081A2 RID: 33186
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040081A3 RID: 33187
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000BCB RID: 3019
		public new class LuaExportHelper
		{
			// Token: 0x0600D001 RID: 53249 RVA: 0x00390974 File Offset: 0x0038EB74
			public LuaExportHelper(InstructionUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D002 RID: 53250 RVA: 0x00390984 File Offset: 0x0038EB84
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600D003 RID: 53251 RVA: 0x00390994 File Offset: 0x0038EB94
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600D004 RID: 53252 RVA: 0x003909A4 File Offset: 0x0038EBA4
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600D005 RID: 53253 RVA: 0x003909B4 File Offset: 0x0038EBB4
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600D006 RID: 53254 RVA: 0x003909C4 File Offset: 0x0038EBC4
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600D007 RID: 53255 RVA: 0x003909D4 File Offset: 0x0038EBD4
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600D008 RID: 53256 RVA: 0x003909E4 File Offset: 0x0038EBE4
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D009 RID: 53257 RVA: 0x003909F4 File Offset: 0x0038EBF4
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600D00A RID: 53258 RVA: 0x00390A04 File Offset: 0x0038EC04
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600D00B RID: 53259 RVA: 0x00390A14 File Offset: 0x0038EC14
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600D00C RID: 53260 RVA: 0x00390A24 File Offset: 0x0038EC24
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600D00D RID: 53261 RVA: 0x00390A34 File Offset: 0x0038EC34
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600D00E RID: 53262 RVA: 0x00390A44 File Offset: 0x0038EC44
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600D00F RID: 53263 RVA: 0x00390A54 File Offset: 0x0038EC54
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600D010 RID: 53264 RVA: 0x00390A64 File Offset: 0x0038EC64
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600D011 RID: 53265 RVA: 0x00390A74 File Offset: 0x0038EC74
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600D012 RID: 53266 RVA: 0x00390A84 File Offset: 0x0038EC84
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600D013 RID: 53267 RVA: 0x00390A94 File Offset: 0x0038EC94
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600D014 RID: 53268 RVA: 0x00390AA4 File Offset: 0x0038ECA4
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600D015 RID: 53269 RVA: 0x00390AB4 File Offset: 0x0038ECB4
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600D016 RID: 53270 RVA: 0x00390AC4 File Offset: 0x0038ECC4
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600D017 RID: 53271 RVA: 0x00390AD4 File Offset: 0x0038ECD4
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600D018 RID: 53272 RVA: 0x00390AE4 File Offset: 0x0038ECE4
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002902 RID: 10498
			// (get) Token: 0x0600D019 RID: 53273 RVA: 0x00390AF4 File Offset: 0x0038ECF4
			// (set) Token: 0x0600D01A RID: 53274 RVA: 0x00390B04 File Offset: 0x0038ED04
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

			// Token: 0x17002903 RID: 10499
			// (get) Token: 0x0600D01B RID: 53275 RVA: 0x00390B14 File Offset: 0x0038ED14
			// (set) Token: 0x0600D01C RID: 53276 RVA: 0x00390B24 File Offset: 0x0038ED24
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

			// Token: 0x17002904 RID: 10500
			// (get) Token: 0x0600D01D RID: 53277 RVA: 0x00390B34 File Offset: 0x0038ED34
			// (set) Token: 0x0600D01E RID: 53278 RVA: 0x00390B44 File Offset: 0x0038ED44
			public InstructionUIController m_instructionUIController
			{
				get
				{
					return this.m_owner.m_instructionUIController;
				}
				set
				{
					this.m_owner.m_instructionUIController = value;
				}
			}

			// Token: 0x17002905 RID: 10501
			// (get) Token: 0x0600D01F RID: 53279 RVA: 0x00390B54 File Offset: 0x0038ED54
			// (set) Token: 0x0600D020 RID: 53280 RVA: 0x00390B64 File Offset: 0x0038ED64
			public string m_prefabName
			{
				get
				{
					return this.m_owner.m_prefabName;
				}
				set
				{
					this.m_owner.m_prefabName = value;
				}
			}

			// Token: 0x17002906 RID: 10502
			// (get) Token: 0x0600D021 RID: 53281 RVA: 0x00390B74 File Offset: 0x0038ED74
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002907 RID: 10503
			// (get) Token: 0x0600D022 RID: 53282 RVA: 0x00390B84 File Offset: 0x0038ED84
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600D023 RID: 53283 RVA: 0x00390B94 File Offset: 0x0038ED94
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600D024 RID: 53284 RVA: 0x00390BA4 File Offset: 0x0038EDA4
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600D025 RID: 53285 RVA: 0x00390BB4 File Offset: 0x0038EDB4
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600D026 RID: 53286 RVA: 0x00390BC4 File Offset: 0x0038EDC4
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D027 RID: 53287 RVA: 0x00390BD4 File Offset: 0x0038EDD4
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600D028 RID: 53288 RVA: 0x00390BE4 File Offset: 0x0038EDE4
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600D029 RID: 53289 RVA: 0x00390BF4 File Offset: 0x0038EDF4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600D02A RID: 53290 RVA: 0x00390C04 File Offset: 0x0038EE04
			public void InstructionUIController_OnClose()
			{
				this.m_owner.InstructionUIController_OnClose();
			}

			// Token: 0x040081A4 RID: 33188
			private InstructionUITask m_owner;
		}
	}
}
