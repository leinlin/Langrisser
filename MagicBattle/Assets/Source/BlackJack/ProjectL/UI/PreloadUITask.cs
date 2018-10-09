using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using PD.SDK;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E9B RID: 3739
	[HotFix]
	public class PreloadUITask : UITask
	{
		// Token: 0x06012444 RID: 74820 RVA: 0x004B1C78 File Offset: 0x004AFE78
		public PreloadUITask(string name) : base(name)
		{
			AssetUtility.Instance = new AssetUtility();
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

		// Token: 0x06012445 RID: 74821 RVA: 0x004B1D74 File Offset: 0x004AFF74
		protected override void OnLoadDynamicResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoadDynamicResCompleted_hotfix != null)
			{
				this.m_OnLoadDynamicResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnLoadDynamicResCompleted();
			PDSDK.Instance.printGameEventLog("51", string.Empty);
		}

		// Token: 0x06012446 RID: 74822 RVA: 0x004B1DF0 File Offset: 0x004AFFF0
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
			PDSDK.Instance.printGameEventLog("50", string.Empty);
			if (!PDSDK.IsIosReview && this.m_viewState == PreloadUITask.ViewState.Loading)
			{
				base.CollectPreloadResourceList();
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06012447 RID: 74823 RVA: 0x004B1E94 File Offset: 0x004B0094
		protected override void PostOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostOnLoadAllResCompleted_hotfix != null)
			{
				this.m_PostOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			base.PostOnLoadAllResCompleted();
		}

		// Token: 0x06012448 RID: 74824 RVA: 0x004B1F00 File Offset: 0x004B0100
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
			if (this.m_preloadUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_preloadUIController = (this.m_uiCtrlArray[0] as PreloadUIController);
				}
				if (this.m_preloadUIController == null)
				{
					Debug.LogError("PreloadUIController is null");
					return;
				}
			}
		}

		// Token: 0x06012449 RID: 74825 RVA: 0x004B1FB4 File Offset: 0x004B01B4
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
			if (this.m_preloadUIController != null)
			{
				this.m_preloadUIController = null;
			}
		}

		// Token: 0x0601244A RID: 74826 RVA: 0x004B2034 File Offset: 0x004B0234
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
			this.m_viewState = PreloadUITask.ViewState.Init;
			return base.OnStart(intent);
		}

		// Token: 0x0601244B RID: 74827 RVA: 0x004B20C0 File Offset: 0x004B02C0
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
			this.m_viewState = PreloadUITask.ViewState.Init;
			return base.OnResume(intent);
		}

		// Token: 0x0601244C RID: 74828 RVA: 0x004B214C File Offset: 0x004B034C
		public override bool OnNewIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNewIntentUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnNewIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_viewState = PreloadUITask.ViewState.Init;
			return base.StartUpdatePipeLine(intent, false, false, true);
		}

		// Token: 0x0601244D RID: 74829 RVA: 0x004B21DC File Offset: 0x004B03DC
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
		}

		// Token: 0x0601244E RID: 74830 RVA: 0x004B2244 File Offset: 0x004B0444
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
		}

		// Token: 0x0601244F RID: 74831 RVA: 0x004B22AC File Offset: 0x004B04AC
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

		// Token: 0x06012450 RID: 74832 RVA: 0x004B230C File Offset: 0x004B050C
		protected override void PostUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostUpdateView_hotfix != null)
			{
				this.m_PostUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_viewState == PreloadUITask.ViewState.Init)
			{
				this.m_viewState = PreloadUITask.ViewState.Loading;
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else if (this.m_viewState == PreloadUITask.ViewState.Loading)
			{
				this.m_viewState = PreloadUITask.ViewState.End;
				this.StartLoginUITask();
			}
			base.PostUpdateView();
		}

		// Token: 0x06012451 RID: 74833 RVA: 0x004B23B0 File Offset: 0x004B05B0
		private void StartLoginUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLoginUITask_hotfix != null)
			{
				this.m_StartLoginUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Utility.LogMemorySize("PreloadUITask.StartLoginUITask");
			UIIntent intent = new UIIntent(typeof(LoginUITask).Name, null);
			UIManager.Instance.StartUITask(intent, false, false, delegate
			{
				base.Pause();
				UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(LoginUITask));
				if (uitaskBase != null)
				{
					uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
				}
			});
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x06012452 RID: 74834 RVA: 0x004B244C File Offset: 0x004B064C
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

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x06012453 RID: 74835 RVA: 0x004B24C0 File Offset: 0x004B06C0
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

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x06012454 RID: 74836 RVA: 0x004B2534 File Offset: 0x004B0734
		// (set) Token: 0x06012455 RID: 74837 RVA: 0x004B2554 File Offset: 0x004B0754
		[DoNotToLua]
		public new PreloadUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PreloadUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012456 RID: 74838 RVA: 0x004B2560 File Offset: 0x004B0760
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06012457 RID: 74839 RVA: 0x004B256C File Offset: 0x004B076C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06012458 RID: 74840 RVA: 0x004B2574 File Offset: 0x004B0774
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06012459 RID: 74841 RVA: 0x004B257C File Offset: 0x004B077C
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0601245A RID: 74842 RVA: 0x004B2588 File Offset: 0x004B0788
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0601245B RID: 74843 RVA: 0x004B2594 File Offset: 0x004B0794
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0601245C RID: 74844 RVA: 0x004B25A0 File Offset: 0x004B07A0
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601245D RID: 74845 RVA: 0x004B25A8 File Offset: 0x004B07A8
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0601245E RID: 74846 RVA: 0x004B25B0 File Offset: 0x004B07B0
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0601245F RID: 74847 RVA: 0x004B25B8 File Offset: 0x004B07B8
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06012460 RID: 74848 RVA: 0x004B25C0 File Offset: 0x004B07C0
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06012461 RID: 74849 RVA: 0x004B25C8 File Offset: 0x004B07C8
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06012462 RID: 74850 RVA: 0x004B25D0 File Offset: 0x004B07D0
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06012463 RID: 74851 RVA: 0x004B25D8 File Offset: 0x004B07D8
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06012464 RID: 74852 RVA: 0x004B25E4 File Offset: 0x004B07E4
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06012465 RID: 74853 RVA: 0x004B25F0 File Offset: 0x004B07F0
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06012466 RID: 74854 RVA: 0x004B25FC File Offset: 0x004B07FC
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06012467 RID: 74855 RVA: 0x004B2608 File Offset: 0x004B0808
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06012468 RID: 74856 RVA: 0x004B2610 File Offset: 0x004B0810
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06012469 RID: 74857 RVA: 0x004B2618 File Offset: 0x004B0818
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0601246A RID: 74858 RVA: 0x004B2620 File Offset: 0x004B0820
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0601246B RID: 74859 RVA: 0x004B2628 File Offset: 0x004B0828
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0601246C RID: 74860 RVA: 0x004B2630 File Offset: 0x004B0830
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0601246E RID: 74862 RVA: 0x004B2668 File Offset: 0x004B0868
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
					this.m_OnLoadDynamicResCompleted_hotfix = (luaObj.RawGet("OnLoadDynamicResCompleted") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_PostOnLoadAllResCompleted_hotfix = (luaObj.RawGet("PostOnLoadAllResCompleted") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnNewIntentUIIntent_hotfix = (luaObj.RawGet("OnNewIntent") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PostUpdateView_hotfix = (luaObj.RawGet("PostUpdateView") as LuaFunction);
					this.m_StartLoginUITask_hotfix = (luaObj.RawGet("StartLoginUITask") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601246F RID: 74863 RVA: 0x004B28AC File Offset: 0x004B0AAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PreloadUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A498 RID: 42136
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "PreloadUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/PreloadUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A499 RID: 42137
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "PreloadUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PreloadUIController"),
				m_ctrlName = "PreloadUIController"
			}
		};

		// Token: 0x0400A49A RID: 42138
		private PreloadUIController m_preloadUIController;

		// Token: 0x0400A49B RID: 42139
		private PreloadUITask.ViewState m_viewState;

		// Token: 0x0400A49C RID: 42140
		[DoNotToLua]
		private PreloadUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A49D RID: 42141
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A49E RID: 42142
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A49F RID: 42143
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A4A0 RID: 42144
		private LuaFunction m_OnLoadDynamicResCompleted_hotfix;

		// Token: 0x0400A4A1 RID: 42145
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A4A2 RID: 42146
		private LuaFunction m_PostOnLoadAllResCompleted_hotfix;

		// Token: 0x0400A4A3 RID: 42147
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A4A4 RID: 42148
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A4A5 RID: 42149
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A4A6 RID: 42150
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400A4A7 RID: 42151
		private LuaFunction m_OnNewIntentUIIntent_hotfix;

		// Token: 0x0400A4A8 RID: 42152
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x0400A4A9 RID: 42153
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400A4AA RID: 42154
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A4AB RID: 42155
		private LuaFunction m_PostUpdateView_hotfix;

		// Token: 0x0400A4AC RID: 42156
		private LuaFunction m_StartLoginUITask_hotfix;

		// Token: 0x0400A4AD RID: 42157
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A4AE RID: 42158
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E9C RID: 3740
		public enum ViewState
		{
			// Token: 0x0400A4B0 RID: 42160
			None,
			// Token: 0x0400A4B1 RID: 42161
			Init,
			// Token: 0x0400A4B2 RID: 42162
			Loading,
			// Token: 0x0400A4B3 RID: 42163
			End
		}

		// Token: 0x02000E9D RID: 3741
		public new class LuaExportHelper
		{
			// Token: 0x06012470 RID: 74864 RVA: 0x004B2914 File Offset: 0x004B0B14
			public LuaExportHelper(PreloadUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012471 RID: 74865 RVA: 0x004B2924 File Offset: 0x004B0B24
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06012472 RID: 74866 RVA: 0x004B2934 File Offset: 0x004B0B34
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06012473 RID: 74867 RVA: 0x004B2944 File Offset: 0x004B0B44
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06012474 RID: 74868 RVA: 0x004B2954 File Offset: 0x004B0B54
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06012475 RID: 74869 RVA: 0x004B2964 File Offset: 0x004B0B64
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06012476 RID: 74870 RVA: 0x004B2974 File Offset: 0x004B0B74
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06012477 RID: 74871 RVA: 0x004B2984 File Offset: 0x004B0B84
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06012478 RID: 74872 RVA: 0x004B2994 File Offset: 0x004B0B94
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06012479 RID: 74873 RVA: 0x004B29A4 File Offset: 0x004B0BA4
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0601247A RID: 74874 RVA: 0x004B29B4 File Offset: 0x004B0BB4
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0601247B RID: 74875 RVA: 0x004B29C4 File Offset: 0x004B0BC4
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0601247C RID: 74876 RVA: 0x004B29D4 File Offset: 0x004B0BD4
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0601247D RID: 74877 RVA: 0x004B29E4 File Offset: 0x004B0BE4
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0601247E RID: 74878 RVA: 0x004B29F4 File Offset: 0x004B0BF4
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601247F RID: 74879 RVA: 0x004B2A04 File Offset: 0x004B0C04
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06012480 RID: 74880 RVA: 0x004B2A14 File Offset: 0x004B0C14
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06012481 RID: 74881 RVA: 0x004B2A24 File Offset: 0x004B0C24
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06012482 RID: 74882 RVA: 0x004B2A34 File Offset: 0x004B0C34
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06012483 RID: 74883 RVA: 0x004B2A44 File Offset: 0x004B0C44
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06012484 RID: 74884 RVA: 0x004B2A54 File Offset: 0x004B0C54
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06012485 RID: 74885 RVA: 0x004B2A64 File Offset: 0x004B0C64
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06012486 RID: 74886 RVA: 0x004B2A74 File Offset: 0x004B0C74
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06012487 RID: 74887 RVA: 0x004B2A84 File Offset: 0x004B0C84
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x1700379B RID: 14235
			// (get) Token: 0x06012488 RID: 74888 RVA: 0x004B2A94 File Offset: 0x004B0C94
			// (set) Token: 0x06012489 RID: 74889 RVA: 0x004B2AA4 File Offset: 0x004B0CA4
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

			// Token: 0x1700379C RID: 14236
			// (get) Token: 0x0601248A RID: 74890 RVA: 0x004B2AB4 File Offset: 0x004B0CB4
			// (set) Token: 0x0601248B RID: 74891 RVA: 0x004B2AC4 File Offset: 0x004B0CC4
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

			// Token: 0x1700379D RID: 14237
			// (get) Token: 0x0601248C RID: 74892 RVA: 0x004B2AD4 File Offset: 0x004B0CD4
			// (set) Token: 0x0601248D RID: 74893 RVA: 0x004B2AE4 File Offset: 0x004B0CE4
			public PreloadUIController m_preloadUIController
			{
				get
				{
					return this.m_owner.m_preloadUIController;
				}
				set
				{
					this.m_owner.m_preloadUIController = value;
				}
			}

			// Token: 0x1700379E RID: 14238
			// (get) Token: 0x0601248E RID: 74894 RVA: 0x004B2AF4 File Offset: 0x004B0CF4
			// (set) Token: 0x0601248F RID: 74895 RVA: 0x004B2B04 File Offset: 0x004B0D04
			public PreloadUITask.ViewState m_viewState
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

			// Token: 0x1700379F RID: 14239
			// (get) Token: 0x06012490 RID: 74896 RVA: 0x004B2B14 File Offset: 0x004B0D14
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170037A0 RID: 14240
			// (get) Token: 0x06012491 RID: 74897 RVA: 0x004B2B24 File Offset: 0x004B0D24
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06012492 RID: 74898 RVA: 0x004B2B34 File Offset: 0x004B0D34
			public void OnLoadDynamicResCompleted()
			{
				this.m_owner.OnLoadDynamicResCompleted();
			}

			// Token: 0x06012493 RID: 74899 RVA: 0x004B2B44 File Offset: 0x004B0D44
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06012494 RID: 74900 RVA: 0x004B2B54 File Offset: 0x004B0D54
			public void PostOnLoadAllResCompleted()
			{
				this.m_owner.PostOnLoadAllResCompleted();
			}

			// Token: 0x06012495 RID: 74901 RVA: 0x004B2B64 File Offset: 0x004B0D64
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06012496 RID: 74902 RVA: 0x004B2B74 File Offset: 0x004B0D74
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06012497 RID: 74903 RVA: 0x004B2B84 File Offset: 0x004B0D84
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06012498 RID: 74904 RVA: 0x004B2B94 File Offset: 0x004B0D94
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06012499 RID: 74905 RVA: 0x004B2BA4 File Offset: 0x004B0DA4
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0601249A RID: 74906 RVA: 0x004B2BB4 File Offset: 0x004B0DB4
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0601249B RID: 74907 RVA: 0x004B2BC4 File Offset: 0x004B0DC4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0601249C RID: 74908 RVA: 0x004B2BD4 File Offset: 0x004B0DD4
			public void PostUpdateView()
			{
				this.m_owner.PostUpdateView();
			}

			// Token: 0x0601249D RID: 74909 RVA: 0x004B2BE4 File Offset: 0x004B0DE4
			public void StartLoginUITask()
			{
				this.m_owner.StartLoginUITask();
			}

			// Token: 0x0400A4B4 RID: 42164
			private PreloadUITask m_owner;
		}
	}
}
