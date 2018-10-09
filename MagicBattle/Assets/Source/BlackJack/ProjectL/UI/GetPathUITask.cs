using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BBD RID: 3005
	[HotFix]
	public class GetPathUITask : UITask
	{
		// Token: 0x0600CE91 RID: 52881 RVA: 0x0038CB90 File Offset: 0x0038AD90
		public GetPathUITask(string name) : base(name)
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

		// Token: 0x0600CE92 RID: 52882 RVA: 0x0038CC84 File Offset: 0x0038AE84
		public static GetPathUITask StartUITask(GoodsType goodsType, int goodsId, Action<GetPathData, NeedGoods> onGotoGetPath, int goodsNeedCount = 0)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(GetPathUITask).Name, null);
			uiintentCustom.SetParam("Type", goodsType);
			uiintentCustom.SetParam("Id", goodsId);
			uiintentCustom.SetParam("Count", goodsNeedCount);
			uiintentCustom.SetParam("OnGotoGetPath", onGotoGetPath);
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as GetPathUITask;
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x0038CCFC File Offset: 0x0038AEFC
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
			if (this.m_getPathUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_getPathUIController = (this.m_uiCtrlArray[0] as GetPathUIController);
				}
				if (this.m_getPathUIController != null)
				{
					this.m_getPathUIController.EventOnClose += this.GetPathUIController_OnClose;
					this.m_getPathUIController.EventOnGotoButtonClick += this.GetPathUIController_OnGotoButtonClick;
				}
			}
		}

		// Token: 0x0600CE94 RID: 52884 RVA: 0x0038CDD4 File Offset: 0x0038AFD4
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
			if (this.m_getPathUIController != null)
			{
				this.m_getPathUIController.EventOnClose -= this.GetPathUIController_OnClose;
				this.m_getPathUIController.EventOnGotoButtonClick -= this.GetPathUIController_OnGotoButtonClick;
				this.m_getPathUIController = null;
			}
		}

		// Token: 0x0600CE95 RID: 52885 RVA: 0x0038CE80 File Offset: 0x0038B080
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

		// Token: 0x0600CE96 RID: 52886 RVA: 0x0038CF0C File Offset: 0x0038B10C
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

		// Token: 0x0600CE97 RID: 52887 RVA: 0x0038CF98 File Offset: 0x0038B198
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
				this.m_goodsType = uiintentCustom.GetStructParam<GoodsType>("Type");
				this.m_goodsID = uiintentCustom.GetStructParam<int>("Id");
				this.m_goodsNeedCount = uiintentCustom.GetStructParam<int>("Count");
				this.m_onGotoGetPathAction = uiintentCustom.GetClassParam<Action<GetPathData, NeedGoods>>("OnGotoGetPath");
			}
		}

		// Token: 0x0600CE98 RID: 52888 RVA: 0x0038D05C File Offset: 0x0038B25C
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
				this.m_getPathUIController.Open();
			}
			this.m_getPathUIController.UpdateViewInGetPathPanel(this.m_goodsType, this.m_goodsID);
		}

		// Token: 0x0600CE99 RID: 52889 RVA: 0x0038D0EC File Offset: 0x0038B2EC
		private void GetPathUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPathUIController_OnClose_hotfix != null)
			{
				this.m_GetPathUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
		}

		// Token: 0x0600CE9A RID: 52890 RVA: 0x0038D154 File Offset: 0x0038B354
		private void GetPathUIController_OnGotoButtonClick(GetPathData getPathInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPathUIController_OnGotoButtonClickGetPathData_hotfix != null)
			{
				this.m_GetPathUIController_OnGotoButtonClickGetPathData_hotfix.call(new object[]
				{
					this,
					getPathInfo2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetPathData getPathInfo = getPathInfo2;
			GetPathUITask $this = this;
			int? num = new int?(0);
			FadeStyle style = FadeStyle.Black;
			int num2 = WorldUITask.CanGotoGetPath(getPathInfo, ref style);
			if (num2 <= 0)
			{
				num = new int?(num2);
				if (num == 0 || num == -402)
				{
					CommonUIController.Instance.StartFadeOut(delegate
					{
						$this.Pause();
						if ($this.m_onGotoGetPathAction != null)
						{
							NeedGoods arg = null;
							if ($this.m_goodsNeedCount > 0)
							{
								arg = new NeedGoods($this.m_goodsType, $this.m_goodsID, $this.m_goodsNeedCount);
							}
							$this.m_onGotoGetPathAction(getPathInfo, arg);
						}
					}, style, -1f);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num.Value, 2f, null, true);
				}
				return;
			}
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x0600CE9B RID: 52891 RVA: 0x0038D274 File Offset: 0x0038B474
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

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x0600CE9C RID: 52892 RVA: 0x0038D2E8 File Offset: 0x0038B4E8
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

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x0600CE9D RID: 52893 RVA: 0x0038D35C File Offset: 0x0038B55C
		// (set) Token: 0x0600CE9E RID: 52894 RVA: 0x0038D37C File Offset: 0x0038B57C
		[DoNotToLua]
		public new GetPathUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GetPathUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CE9F RID: 52895 RVA: 0x0038D388 File Offset: 0x0038B588
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600CEA0 RID: 52896 RVA: 0x0038D394 File Offset: 0x0038B594
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600CEA1 RID: 52897 RVA: 0x0038D39C File Offset: 0x0038B59C
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600CEA2 RID: 52898 RVA: 0x0038D3A4 File Offset: 0x0038B5A4
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600CEA3 RID: 52899 RVA: 0x0038D3B0 File Offset: 0x0038B5B0
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600CEA4 RID: 52900 RVA: 0x0038D3BC File Offset: 0x0038B5BC
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600CEA5 RID: 52901 RVA: 0x0038D3C8 File Offset: 0x0038B5C8
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CEA6 RID: 52902 RVA: 0x0038D3D0 File Offset: 0x0038B5D0
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600CEA7 RID: 52903 RVA: 0x0038D3D8 File Offset: 0x0038B5D8
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600CEA8 RID: 52904 RVA: 0x0038D3E0 File Offset: 0x0038B5E0
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600CEA9 RID: 52905 RVA: 0x0038D3E8 File Offset: 0x0038B5E8
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600CEAA RID: 52906 RVA: 0x0038D3F0 File Offset: 0x0038B5F0
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600CEAB RID: 52907 RVA: 0x0038D3F8 File Offset: 0x0038B5F8
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600CEAC RID: 52908 RVA: 0x0038D400 File Offset: 0x0038B600
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600CEAD RID: 52909 RVA: 0x0038D40C File Offset: 0x0038B60C
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600CEAE RID: 52910 RVA: 0x0038D418 File Offset: 0x0038B618
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600CEAF RID: 52911 RVA: 0x0038D424 File Offset: 0x0038B624
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600CEB0 RID: 52912 RVA: 0x0038D430 File Offset: 0x0038B630
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600CEB1 RID: 52913 RVA: 0x0038D438 File Offset: 0x0038B638
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600CEB2 RID: 52914 RVA: 0x0038D440 File Offset: 0x0038B640
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600CEB3 RID: 52915 RVA: 0x0038D448 File Offset: 0x0038B648
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600CEB4 RID: 52916 RVA: 0x0038D450 File Offset: 0x0038B650
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600CEB5 RID: 52917 RVA: 0x0038D458 File Offset: 0x0038B658
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600CEB6 RID: 52918 RVA: 0x0038D460 File Offset: 0x0038B660
		private void __callDele_m_onGotoGetPathAction(GetPathData arg1, NeedGoods arg2)
		{
			Action<GetPathData, NeedGoods> onGotoGetPathAction = this.m_onGotoGetPathAction;
			if (onGotoGetPathAction != null)
			{
				onGotoGetPathAction(arg1, arg2);
			}
		}

		// Token: 0x0600CEB7 RID: 52919 RVA: 0x0038D484 File Offset: 0x0038B684
		private void __clearDele_m_onGotoGetPathAction(GetPathData arg1, NeedGoods arg2)
		{
			this.m_onGotoGetPathAction = null;
		}

		// Token: 0x0600CEB8 RID: 52920 RVA: 0x0038D490 File Offset: 0x0038B690
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_GetPathUIController_OnClose_hotfix = (luaObj.RawGet("GetPathUIController_OnClose") as LuaFunction);
					this.m_GetPathUIController_OnGotoButtonClickGetPathData_hotfix = (luaObj.RawGet("GetPathUIController_OnGotoButtonClick") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CEB9 RID: 52921 RVA: 0x0038D658 File Offset: 0x0038B858
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetPathUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008129 RID: 33065
		private const string ParamKey_Type = "Type";

		// Token: 0x0400812A RID: 33066
		private const string ParamKey_Id = "Id";

		// Token: 0x0400812B RID: 33067
		private const string ParamKey_Count = "Count";

		// Token: 0x0400812C RID: 33068
		private const string ParamKey_OnGotoGetPath = "OnGotoGetPath";

		// Token: 0x0400812D RID: 33069
		private GoodsType m_goodsType;

		// Token: 0x0400812E RID: 33070
		private int m_goodsID;

		// Token: 0x0400812F RID: 33071
		private int m_goodsNeedCount;

		// Token: 0x04008130 RID: 33072
		private Action<GetPathData, NeedGoods> m_onGotoGetPathAction;

		// Token: 0x04008131 RID: 33073
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "GetPathUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/GetPathUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04008132 RID: 33074
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "GetPathUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.GetPathUIController"),
				m_ctrlName = "GetPathUIController"
			}
		};

		// Token: 0x04008133 RID: 33075
		private GetPathUIController m_getPathUIController;

		// Token: 0x04008134 RID: 33076
		[DoNotToLua]
		private GetPathUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04008135 RID: 33077
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008136 RID: 33078
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008137 RID: 33079
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04008138 RID: 33080
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04008139 RID: 33081
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400813A RID: 33082
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400813B RID: 33083
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400813C RID: 33084
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400813D RID: 33085
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400813E RID: 33086
		private LuaFunction m_GetPathUIController_OnClose_hotfix;

		// Token: 0x0400813F RID: 33087
		private LuaFunction m_GetPathUIController_OnGotoButtonClickGetPathData_hotfix;

		// Token: 0x04008140 RID: 33088
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04008141 RID: 33089
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000BBE RID: 3006
		public new class LuaExportHelper
		{
			// Token: 0x0600CEBA RID: 52922 RVA: 0x0038D6C0 File Offset: 0x0038B8C0
			public LuaExportHelper(GetPathUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CEBB RID: 52923 RVA: 0x0038D6D0 File Offset: 0x0038B8D0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600CEBC RID: 52924 RVA: 0x0038D6E0 File Offset: 0x0038B8E0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600CEBD RID: 52925 RVA: 0x0038D6F0 File Offset: 0x0038B8F0
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600CEBE RID: 52926 RVA: 0x0038D700 File Offset: 0x0038B900
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600CEBF RID: 52927 RVA: 0x0038D710 File Offset: 0x0038B910
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600CEC0 RID: 52928 RVA: 0x0038D720 File Offset: 0x0038B920
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600CEC1 RID: 52929 RVA: 0x0038D730 File Offset: 0x0038B930
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600CEC2 RID: 52930 RVA: 0x0038D740 File Offset: 0x0038B940
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600CEC3 RID: 52931 RVA: 0x0038D750 File Offset: 0x0038B950
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600CEC4 RID: 52932 RVA: 0x0038D760 File Offset: 0x0038B960
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600CEC5 RID: 52933 RVA: 0x0038D770 File Offset: 0x0038B970
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600CEC6 RID: 52934 RVA: 0x0038D780 File Offset: 0x0038B980
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600CEC7 RID: 52935 RVA: 0x0038D790 File Offset: 0x0038B990
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600CEC8 RID: 52936 RVA: 0x0038D7A0 File Offset: 0x0038B9A0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600CEC9 RID: 52937 RVA: 0x0038D7B0 File Offset: 0x0038B9B0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600CECA RID: 52938 RVA: 0x0038D7C0 File Offset: 0x0038B9C0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600CECB RID: 52939 RVA: 0x0038D7D0 File Offset: 0x0038B9D0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600CECC RID: 52940 RVA: 0x0038D7E0 File Offset: 0x0038B9E0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600CECD RID: 52941 RVA: 0x0038D7F0 File Offset: 0x0038B9F0
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600CECE RID: 52942 RVA: 0x0038D800 File Offset: 0x0038BA00
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600CECF RID: 52943 RVA: 0x0038D810 File Offset: 0x0038BA10
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600CED0 RID: 52944 RVA: 0x0038D820 File Offset: 0x0038BA20
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600CED1 RID: 52945 RVA: 0x0038D830 File Offset: 0x0038BA30
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600CED2 RID: 52946 RVA: 0x0038D840 File Offset: 0x0038BA40
			public void __callDele_m_onGotoGetPathAction(GetPathData arg1, NeedGoods arg2)
			{
				this.m_owner.__callDele_m_onGotoGetPathAction(arg1, arg2);
			}

			// Token: 0x0600CED3 RID: 52947 RVA: 0x0038D850 File Offset: 0x0038BA50
			public void __clearDele_m_onGotoGetPathAction(GetPathData arg1, NeedGoods arg2)
			{
				this.m_owner.__clearDele_m_onGotoGetPathAction(arg1, arg2);
			}

			// Token: 0x170028D6 RID: 10454
			// (get) Token: 0x0600CED4 RID: 52948 RVA: 0x0038D860 File Offset: 0x0038BA60
			public static string ParamKey_Type
			{
				get
				{
					return "Type";
				}
			}

			// Token: 0x170028D7 RID: 10455
			// (get) Token: 0x0600CED5 RID: 52949 RVA: 0x0038D868 File Offset: 0x0038BA68
			public static string ParamKey_Id
			{
				get
				{
					return "Id";
				}
			}

			// Token: 0x170028D8 RID: 10456
			// (get) Token: 0x0600CED6 RID: 52950 RVA: 0x0038D870 File Offset: 0x0038BA70
			public static string ParamKey_Count
			{
				get
				{
					return "Count";
				}
			}

			// Token: 0x170028D9 RID: 10457
			// (get) Token: 0x0600CED7 RID: 52951 RVA: 0x0038D878 File Offset: 0x0038BA78
			public static string ParamKey_OnGotoGetPath
			{
				get
				{
					return "OnGotoGetPath";
				}
			}

			// Token: 0x170028DA RID: 10458
			// (get) Token: 0x0600CED8 RID: 52952 RVA: 0x0038D880 File Offset: 0x0038BA80
			// (set) Token: 0x0600CED9 RID: 52953 RVA: 0x0038D890 File Offset: 0x0038BA90
			public GoodsType m_goodsType
			{
				get
				{
					return this.m_owner.m_goodsType;
				}
				set
				{
					this.m_owner.m_goodsType = value;
				}
			}

			// Token: 0x170028DB RID: 10459
			// (get) Token: 0x0600CEDA RID: 52954 RVA: 0x0038D8A0 File Offset: 0x0038BAA0
			// (set) Token: 0x0600CEDB RID: 52955 RVA: 0x0038D8B0 File Offset: 0x0038BAB0
			public int m_goodsID
			{
				get
				{
					return this.m_owner.m_goodsID;
				}
				set
				{
					this.m_owner.m_goodsID = value;
				}
			}

			// Token: 0x170028DC RID: 10460
			// (get) Token: 0x0600CEDC RID: 52956 RVA: 0x0038D8C0 File Offset: 0x0038BAC0
			// (set) Token: 0x0600CEDD RID: 52957 RVA: 0x0038D8D0 File Offset: 0x0038BAD0
			public int m_goodsNeedCount
			{
				get
				{
					return this.m_owner.m_goodsNeedCount;
				}
				set
				{
					this.m_owner.m_goodsNeedCount = value;
				}
			}

			// Token: 0x170028DD RID: 10461
			// (get) Token: 0x0600CEDE RID: 52958 RVA: 0x0038D8E0 File Offset: 0x0038BAE0
			// (set) Token: 0x0600CEDF RID: 52959 RVA: 0x0038D8F0 File Offset: 0x0038BAF0
			public Action<GetPathData, NeedGoods> m_onGotoGetPathAction
			{
				get
				{
					return this.m_owner.m_onGotoGetPathAction;
				}
				set
				{
					this.m_owner.m_onGotoGetPathAction = value;
				}
			}

			// Token: 0x170028DE RID: 10462
			// (get) Token: 0x0600CEE0 RID: 52960 RVA: 0x0038D900 File Offset: 0x0038BB00
			// (set) Token: 0x0600CEE1 RID: 52961 RVA: 0x0038D910 File Offset: 0x0038BB10
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

			// Token: 0x170028DF RID: 10463
			// (get) Token: 0x0600CEE2 RID: 52962 RVA: 0x0038D920 File Offset: 0x0038BB20
			// (set) Token: 0x0600CEE3 RID: 52963 RVA: 0x0038D930 File Offset: 0x0038BB30
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

			// Token: 0x170028E0 RID: 10464
			// (get) Token: 0x0600CEE4 RID: 52964 RVA: 0x0038D940 File Offset: 0x0038BB40
			// (set) Token: 0x0600CEE5 RID: 52965 RVA: 0x0038D950 File Offset: 0x0038BB50
			public GetPathUIController m_getPathUIController
			{
				get
				{
					return this.m_owner.m_getPathUIController;
				}
				set
				{
					this.m_owner.m_getPathUIController = value;
				}
			}

			// Token: 0x170028E1 RID: 10465
			// (get) Token: 0x0600CEE6 RID: 52966 RVA: 0x0038D960 File Offset: 0x0038BB60
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170028E2 RID: 10466
			// (get) Token: 0x0600CEE7 RID: 52967 RVA: 0x0038D970 File Offset: 0x0038BB70
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600CEE8 RID: 52968 RVA: 0x0038D980 File Offset: 0x0038BB80
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600CEE9 RID: 52969 RVA: 0x0038D990 File Offset: 0x0038BB90
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600CEEA RID: 52970 RVA: 0x0038D9A0 File Offset: 0x0038BBA0
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600CEEB RID: 52971 RVA: 0x0038D9B0 File Offset: 0x0038BBB0
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600CEEC RID: 52972 RVA: 0x0038D9C0 File Offset: 0x0038BBC0
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600CEED RID: 52973 RVA: 0x0038D9D0 File Offset: 0x0038BBD0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600CEEE RID: 52974 RVA: 0x0038D9E0 File Offset: 0x0038BBE0
			public void GetPathUIController_OnClose()
			{
				this.m_owner.GetPathUIController_OnClose();
			}

			// Token: 0x0600CEEF RID: 52975 RVA: 0x0038D9F0 File Offset: 0x0038BBF0
			public void GetPathUIController_OnGotoButtonClick(GetPathData getPathInfo)
			{
				this.m_owner.GetPathUIController_OnGotoButtonClick(getPathInfo);
			}

			// Token: 0x04008142 RID: 33090
			private GetPathUITask m_owner;
		}
	}
}
