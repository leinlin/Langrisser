using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BF7 RID: 3063
	[HotFix]
	public class RewardGoodsDescUITask : UITask
	{
		// Token: 0x0600D5F0 RID: 54768 RVA: 0x003A5454 File Offset: 0x003A3654
		public RewardGoodsDescUITask(string name) : base(name)
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

		// Token: 0x0600D5F1 RID: 54769 RVA: 0x003A554C File Offset: 0x003A374C
		public static RewardGoodsDescUITask StartUITask(PrefabControllerBase ctrl, GoodsType goodsType, int goodsId, int alignType = 0, GameObject gameObjectForPosCalc = null, bool isNeedAutoClose = true)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(RewardGoodsDescUITask).Name, null);
			uiintentCustom.SetParam("Ctrl", ctrl);
			uiintentCustom.SetParam("Type", goodsType);
			uiintentCustom.SetParam("Id", goodsId);
			uiintentCustom.SetParam("AlignType", alignType);
			uiintentCustom.SetParam("GameObjectForPosScale", gameObjectForPosCalc);
			uiintentCustom.SetParam("IsNeedAutoClose ", isNeedAutoClose);
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as RewardGoodsDescUITask;
		}

		// Token: 0x0600D5F2 RID: 54770 RVA: 0x003A55E0 File Offset: 0x003A37E0
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
			base.CollectSpriteAsset(UIUtility.GetGoodsIconName(this.m_goodsType, this.m_goodsId));
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600D5F3 RID: 54771 RVA: 0x003A5670 File Offset: 0x003A3870
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
			if (this.m_rewardGoodsDescUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_rewardGoodsDescUIController = (this.m_uiCtrlArray[0] as RewardGoodsDescUIController);
				}
				if (this.m_rewardGoodsDescUIController != null)
				{
					this.m_rewardGoodsDescUIController.EventOnClose += this.RewardGoodsDescUIController_OnClose;
				}
			}
		}

		// Token: 0x0600D5F4 RID: 54772 RVA: 0x003A5730 File Offset: 0x003A3930
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
			if (this.m_rewardGoodsDescUIController != null)
			{
				this.m_rewardGoodsDescUIController.EventOnClose -= this.RewardGoodsDescUIController_OnClose;
				this.m_rewardGoodsDescUIController = null;
			}
		}

		// Token: 0x0600D5F5 RID: 54773 RVA: 0x003A57C8 File Offset: 0x003A39C8
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

		// Token: 0x0600D5F6 RID: 54774 RVA: 0x003A5854 File Offset: 0x003A3A54
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

		// Token: 0x0600D5F7 RID: 54775 RVA: 0x003A58E0 File Offset: 0x003A3AE0
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
				this.m_controller = uiintentCustom.GetClassParam<PrefabControllerBase>("Ctrl");
				this.m_goodsType = uiintentCustom.GetStructParam<GoodsType>("Type");
				this.m_goodsId = uiintentCustom.GetStructParam<int>("Id");
				this.m_alignType = uiintentCustom.GetStructParam<int>("AlignType");
				this.m_gameObjectForPosCalc = uiintentCustom.GetClassParam<GameObject>("GameObjectForPosScale");
				this.m_isNeedAutoClose = uiintentCustom.GetStructParam<bool>("IsNeedAutoClose ");
			}
		}

		// Token: 0x0600D5F8 RID: 54776 RVA: 0x003A59C4 File Offset: 0x003A3BC4
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
			this.m_rewardGoodsDescUIController.ShowRewardGoodsDesc(this.m_controller, this.m_goodsType, this.m_goodsId, this.m_alignType, this.m_gameObjectForPosCalc, this.m_isNeedAutoClose);
		}

		// Token: 0x0600D5F9 RID: 54777 RVA: 0x003A5A54 File Offset: 0x003A3C54
		private void RewardGoodsDescUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RewardGoodsDescUIController_OnClose_hotfix != null)
			{
				this.m_RewardGoodsDescUIController_OnClose_hotfix.call(new object[]
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
			this.ResetData();
		}

		// Token: 0x0600D5FA RID: 54778 RVA: 0x003A5AD8 File Offset: 0x003A3CD8
		private void ResetData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetData_hotfix != null)
			{
				this.m_ResetData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_controller = null;
			this.m_goodsType = GoodsType.GoodsType_None;
			this.m_goodsId = 0;
			this.m_alignType = 0;
			this.m_gameObjectForPosCalc = null;
			this.m_isNeedAutoClose = true;
		}

		// Token: 0x140002A9 RID: 681
		// (add) Token: 0x0600D5FB RID: 54779 RVA: 0x003A5B64 File Offset: 0x003A3D64
		// (remove) Token: 0x0600D5FC RID: 54780 RVA: 0x003A5C00 File Offset: 0x003A3E00
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

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x0600D5FD RID: 54781 RVA: 0x003A5C9C File Offset: 0x003A3E9C
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

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x0600D5FE RID: 54782 RVA: 0x003A5D10 File Offset: 0x003A3F10
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

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x0600D5FF RID: 54783 RVA: 0x003A5D84 File Offset: 0x003A3F84
		// (set) Token: 0x0600D600 RID: 54784 RVA: 0x003A5DA4 File Offset: 0x003A3FA4
		[DoNotToLua]
		public new RewardGoodsDescUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RewardGoodsDescUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D601 RID: 54785 RVA: 0x003A5DB0 File Offset: 0x003A3FB0
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600D602 RID: 54786 RVA: 0x003A5DBC File Offset: 0x003A3FBC
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600D603 RID: 54787 RVA: 0x003A5DC4 File Offset: 0x003A3FC4
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600D604 RID: 54788 RVA: 0x003A5DCC File Offset: 0x003A3FCC
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600D605 RID: 54789 RVA: 0x003A5DD8 File Offset: 0x003A3FD8
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600D606 RID: 54790 RVA: 0x003A5DE4 File Offset: 0x003A3FE4
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600D607 RID: 54791 RVA: 0x003A5DF0 File Offset: 0x003A3FF0
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600D608 RID: 54792 RVA: 0x003A5DF8 File Offset: 0x003A3FF8
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600D609 RID: 54793 RVA: 0x003A5E00 File Offset: 0x003A4000
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600D60A RID: 54794 RVA: 0x003A5E08 File Offset: 0x003A4008
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600D60B RID: 54795 RVA: 0x003A5E10 File Offset: 0x003A4010
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600D60C RID: 54796 RVA: 0x003A5E18 File Offset: 0x003A4018
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600D60D RID: 54797 RVA: 0x003A5E20 File Offset: 0x003A4020
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600D60E RID: 54798 RVA: 0x003A5E28 File Offset: 0x003A4028
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600D60F RID: 54799 RVA: 0x003A5E34 File Offset: 0x003A4034
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600D610 RID: 54800 RVA: 0x003A5E40 File Offset: 0x003A4040
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600D611 RID: 54801 RVA: 0x003A5E4C File Offset: 0x003A404C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600D612 RID: 54802 RVA: 0x003A5E58 File Offset: 0x003A4058
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600D613 RID: 54803 RVA: 0x003A5E60 File Offset: 0x003A4060
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600D614 RID: 54804 RVA: 0x003A5E68 File Offset: 0x003A4068
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600D615 RID: 54805 RVA: 0x003A5E70 File Offset: 0x003A4070
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600D616 RID: 54806 RVA: 0x003A5E78 File Offset: 0x003A4078
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600D617 RID: 54807 RVA: 0x003A5E80 File Offset: 0x003A4080
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600D618 RID: 54808 RVA: 0x003A5E88 File Offset: 0x003A4088
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D619 RID: 54809 RVA: 0x003A5EA8 File Offset: 0x003A40A8
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D61A RID: 54810 RVA: 0x003A5EB4 File Offset: 0x003A40B4
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_RewardGoodsDescUIController_OnClose_hotfix = (luaObj.RawGet("RewardGoodsDescUIController_OnClose") as LuaFunction);
					this.m_ResetData_hotfix = (luaObj.RawGet("ResetData") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D61B RID: 54811 RVA: 0x003A60C4 File Offset: 0x003A42C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RewardGoodsDescUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040083F4 RID: 33780
		private const string ParamKey_Type = "Type";

		// Token: 0x040083F5 RID: 33781
		private const string ParamKey_Id = "Id";

		// Token: 0x040083F6 RID: 33782
		private const string ParamKey_Ctrl = "Ctrl";

		// Token: 0x040083F7 RID: 33783
		private const string ParamKey_AlignType = "AlignType";

		// Token: 0x040083F8 RID: 33784
		private const string ParamKey_GameObjectForPosScale = "GameObjectForPosScale";

		// Token: 0x040083F9 RID: 33785
		private const string ParamKey_IsNeedAutoClose = "IsNeedAutoClose ";

		// Token: 0x040083FA RID: 33786
		private PrefabControllerBase m_controller;

		// Token: 0x040083FB RID: 33787
		private GoodsType m_goodsType;

		// Token: 0x040083FC RID: 33788
		private int m_goodsId;

		// Token: 0x040083FD RID: 33789
		private int m_alignType;

		// Token: 0x040083FE RID: 33790
		private GameObject m_gameObjectForPosCalc;

		// Token: 0x040083FF RID: 33791
		private bool m_isNeedAutoClose = true;

		// Token: 0x04008401 RID: 33793
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "RewardGoodsDescUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/RewardGoodsDesc.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04008402 RID: 33794
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RewardGoodsDescUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.RewardGoodsDescUIController"),
				m_ctrlName = "RewardGoodsDescUIController"
			}
		};

		// Token: 0x04008403 RID: 33795
		private RewardGoodsDescUIController m_rewardGoodsDescUIController;

		// Token: 0x04008404 RID: 33796
		[DoNotToLua]
		private RewardGoodsDescUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04008405 RID: 33797
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008406 RID: 33798
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008407 RID: 33799
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04008408 RID: 33800
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04008409 RID: 33801
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400840A RID: 33802
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400840B RID: 33803
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400840C RID: 33804
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400840D RID: 33805
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400840E RID: 33806
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400840F RID: 33807
		private LuaFunction m_RewardGoodsDescUIController_OnClose_hotfix;

		// Token: 0x04008410 RID: 33808
		private LuaFunction m_ResetData_hotfix;

		// Token: 0x04008411 RID: 33809
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04008412 RID: 33810
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04008413 RID: 33811
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04008414 RID: 33812
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000BF8 RID: 3064
		public new class LuaExportHelper
		{
			// Token: 0x0600D61C RID: 54812 RVA: 0x003A612C File Offset: 0x003A432C
			public LuaExportHelper(RewardGoodsDescUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D61D RID: 54813 RVA: 0x003A613C File Offset: 0x003A433C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600D61E RID: 54814 RVA: 0x003A614C File Offset: 0x003A434C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600D61F RID: 54815 RVA: 0x003A615C File Offset: 0x003A435C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600D620 RID: 54816 RVA: 0x003A616C File Offset: 0x003A436C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600D621 RID: 54817 RVA: 0x003A617C File Offset: 0x003A437C
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600D622 RID: 54818 RVA: 0x003A618C File Offset: 0x003A438C
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600D623 RID: 54819 RVA: 0x003A619C File Offset: 0x003A439C
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D624 RID: 54820 RVA: 0x003A61AC File Offset: 0x003A43AC
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600D625 RID: 54821 RVA: 0x003A61BC File Offset: 0x003A43BC
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600D626 RID: 54822 RVA: 0x003A61CC File Offset: 0x003A43CC
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600D627 RID: 54823 RVA: 0x003A61DC File Offset: 0x003A43DC
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600D628 RID: 54824 RVA: 0x003A61EC File Offset: 0x003A43EC
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600D629 RID: 54825 RVA: 0x003A61FC File Offset: 0x003A43FC
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600D62A RID: 54826 RVA: 0x003A620C File Offset: 0x003A440C
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600D62B RID: 54827 RVA: 0x003A621C File Offset: 0x003A441C
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600D62C RID: 54828 RVA: 0x003A622C File Offset: 0x003A442C
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600D62D RID: 54829 RVA: 0x003A623C File Offset: 0x003A443C
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600D62E RID: 54830 RVA: 0x003A624C File Offset: 0x003A444C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600D62F RID: 54831 RVA: 0x003A625C File Offset: 0x003A445C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600D630 RID: 54832 RVA: 0x003A626C File Offset: 0x003A446C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600D631 RID: 54833 RVA: 0x003A627C File Offset: 0x003A447C
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600D632 RID: 54834 RVA: 0x003A628C File Offset: 0x003A448C
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600D633 RID: 54835 RVA: 0x003A629C File Offset: 0x003A449C
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600D634 RID: 54836 RVA: 0x003A62AC File Offset: 0x003A44AC
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D635 RID: 54837 RVA: 0x003A62BC File Offset: 0x003A44BC
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170029BD RID: 10685
			// (get) Token: 0x0600D636 RID: 54838 RVA: 0x003A62CC File Offset: 0x003A44CC
			public static string ParamKey_Type
			{
				get
				{
					return "Type";
				}
			}

			// Token: 0x170029BE RID: 10686
			// (get) Token: 0x0600D637 RID: 54839 RVA: 0x003A62D4 File Offset: 0x003A44D4
			public static string ParamKey_Id
			{
				get
				{
					return "Id";
				}
			}

			// Token: 0x170029BF RID: 10687
			// (get) Token: 0x0600D638 RID: 54840 RVA: 0x003A62DC File Offset: 0x003A44DC
			public static string ParamKey_Ctrl
			{
				get
				{
					return "Ctrl";
				}
			}

			// Token: 0x170029C0 RID: 10688
			// (get) Token: 0x0600D639 RID: 54841 RVA: 0x003A62E4 File Offset: 0x003A44E4
			public static string ParamKey_AlignType
			{
				get
				{
					return "AlignType";
				}
			}

			// Token: 0x170029C1 RID: 10689
			// (get) Token: 0x0600D63A RID: 54842 RVA: 0x003A62EC File Offset: 0x003A44EC
			public static string ParamKey_GameObjectForPosScale
			{
				get
				{
					return "GameObjectForPosScale";
				}
			}

			// Token: 0x170029C2 RID: 10690
			// (get) Token: 0x0600D63B RID: 54843 RVA: 0x003A62F4 File Offset: 0x003A44F4
			public static string ParamKey_IsNeedAutoClose
			{
				get
				{
					return "IsNeedAutoClose ";
				}
			}

			// Token: 0x170029C3 RID: 10691
			// (get) Token: 0x0600D63C RID: 54844 RVA: 0x003A62FC File Offset: 0x003A44FC
			// (set) Token: 0x0600D63D RID: 54845 RVA: 0x003A630C File Offset: 0x003A450C
			public PrefabControllerBase m_controller
			{
				get
				{
					return this.m_owner.m_controller;
				}
				set
				{
					this.m_owner.m_controller = value;
				}
			}

			// Token: 0x170029C4 RID: 10692
			// (get) Token: 0x0600D63E RID: 54846 RVA: 0x003A631C File Offset: 0x003A451C
			// (set) Token: 0x0600D63F RID: 54847 RVA: 0x003A632C File Offset: 0x003A452C
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

			// Token: 0x170029C5 RID: 10693
			// (get) Token: 0x0600D640 RID: 54848 RVA: 0x003A633C File Offset: 0x003A453C
			// (set) Token: 0x0600D641 RID: 54849 RVA: 0x003A634C File Offset: 0x003A454C
			public int m_goodsId
			{
				get
				{
					return this.m_owner.m_goodsId;
				}
				set
				{
					this.m_owner.m_goodsId = value;
				}
			}

			// Token: 0x170029C6 RID: 10694
			// (get) Token: 0x0600D642 RID: 54850 RVA: 0x003A635C File Offset: 0x003A455C
			// (set) Token: 0x0600D643 RID: 54851 RVA: 0x003A636C File Offset: 0x003A456C
			public int m_alignType
			{
				get
				{
					return this.m_owner.m_alignType;
				}
				set
				{
					this.m_owner.m_alignType = value;
				}
			}

			// Token: 0x170029C7 RID: 10695
			// (get) Token: 0x0600D644 RID: 54852 RVA: 0x003A637C File Offset: 0x003A457C
			// (set) Token: 0x0600D645 RID: 54853 RVA: 0x003A638C File Offset: 0x003A458C
			public GameObject m_gameObjectForPosCalc
			{
				get
				{
					return this.m_owner.m_gameObjectForPosCalc;
				}
				set
				{
					this.m_owner.m_gameObjectForPosCalc = value;
				}
			}

			// Token: 0x170029C8 RID: 10696
			// (get) Token: 0x0600D646 RID: 54854 RVA: 0x003A639C File Offset: 0x003A459C
			// (set) Token: 0x0600D647 RID: 54855 RVA: 0x003A63AC File Offset: 0x003A45AC
			public bool m_isNeedAutoClose
			{
				get
				{
					return this.m_owner.m_isNeedAutoClose;
				}
				set
				{
					this.m_owner.m_isNeedAutoClose = value;
				}
			}

			// Token: 0x170029C9 RID: 10697
			// (get) Token: 0x0600D648 RID: 54856 RVA: 0x003A63BC File Offset: 0x003A45BC
			// (set) Token: 0x0600D649 RID: 54857 RVA: 0x003A63CC File Offset: 0x003A45CC
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

			// Token: 0x170029CA RID: 10698
			// (get) Token: 0x0600D64A RID: 54858 RVA: 0x003A63DC File Offset: 0x003A45DC
			// (set) Token: 0x0600D64B RID: 54859 RVA: 0x003A63EC File Offset: 0x003A45EC
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

			// Token: 0x170029CB RID: 10699
			// (get) Token: 0x0600D64C RID: 54860 RVA: 0x003A63FC File Offset: 0x003A45FC
			// (set) Token: 0x0600D64D RID: 54861 RVA: 0x003A640C File Offset: 0x003A460C
			public RewardGoodsDescUIController m_rewardGoodsDescUIController
			{
				get
				{
					return this.m_owner.m_rewardGoodsDescUIController;
				}
				set
				{
					this.m_owner.m_rewardGoodsDescUIController = value;
				}
			}

			// Token: 0x170029CC RID: 10700
			// (get) Token: 0x0600D64E RID: 54862 RVA: 0x003A641C File Offset: 0x003A461C
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170029CD RID: 10701
			// (get) Token: 0x0600D64F RID: 54863 RVA: 0x003A642C File Offset: 0x003A462C
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600D650 RID: 54864 RVA: 0x003A643C File Offset: 0x003A463C
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D651 RID: 54865 RVA: 0x003A644C File Offset: 0x003A464C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600D652 RID: 54866 RVA: 0x003A645C File Offset: 0x003A465C
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600D653 RID: 54867 RVA: 0x003A646C File Offset: 0x003A466C
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600D654 RID: 54868 RVA: 0x003A647C File Offset: 0x003A467C
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600D655 RID: 54869 RVA: 0x003A648C File Offset: 0x003A468C
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600D656 RID: 54870 RVA: 0x003A649C File Offset: 0x003A469C
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600D657 RID: 54871 RVA: 0x003A64AC File Offset: 0x003A46AC
			public void RewardGoodsDescUIController_OnClose()
			{
				this.m_owner.RewardGoodsDescUIController_OnClose();
			}

			// Token: 0x0600D658 RID: 54872 RVA: 0x003A64BC File Offset: 0x003A46BC
			public void ResetData()
			{
				this.m_owner.ResetData();
			}

			// Token: 0x04008415 RID: 33813
			private RewardGoodsDescUITask m_owner;
		}
	}
}
