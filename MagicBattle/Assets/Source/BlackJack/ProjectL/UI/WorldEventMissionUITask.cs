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
	// Token: 0x02001020 RID: 4128
	[HotFix]
	public class WorldEventMissionUITask : UITask
	{
		// Token: 0x06014E41 RID: 85569 RVA: 0x0054A964 File Offset: 0x00548B64
		public WorldEventMissionUITask(string name) : base(name)
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

		// Token: 0x06014E42 RID: 85570 RVA: 0x0054AA58 File Offset: 0x00548C58
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

		// Token: 0x06014E43 RID: 85571 RVA: 0x0054AAE4 File Offset: 0x00548CE4
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

		// Token: 0x06014E44 RID: 85572 RVA: 0x0054AB70 File Offset: 0x00548D70
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
			this.m_eventInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_eventInfo = uiintentCustom.GetClassParam<ConfigDataEventInfo>("EventInfo");
			}
		}

		// Token: 0x06014E45 RID: 85573 RVA: 0x0054AC08 File Offset: 0x00548E08
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
			if (this.m_eventInfo != null && this.m_eventInfo.CharImage_ID != 0)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataCharImageInfo configDataCharImageInfo = configDataLoader.GetConfigDataCharImageInfo(this.m_eventInfo.CharImage_ID);
				if (configDataCharImageInfo != null)
				{
					base.CollectAsset(configDataCharImageInfo.Spine);
					base.CollectSpriteAsset(configDataCharImageInfo.Image);
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014E46 RID: 85574 RVA: 0x0054ACDC File Offset: 0x00548EDC
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
			this.InitWorldEventMissionUIController();
		}

		// Token: 0x06014E47 RID: 85575 RVA: 0x0054AD48 File Offset: 0x00548F48
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
			this.UninitEventMissionUIController();
		}

		// Token: 0x06014E48 RID: 85576 RVA: 0x0054ADB4 File Offset: 0x00548FB4
		private void InitWorldEventMissionUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitWorldEventMissionUIController_hotfix != null)
			{
				this.m_InitWorldEventMissionUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_worldEventMissionUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_worldEventMissionUIController = (this.m_uiCtrlArray[0] as WorldEventMissionUIController);
				}
				if (!(this.m_worldEventMissionUIController != null))
				{
					Debug.LogError("WorldEventMissionUIController is null");
					return;
				}
				this.m_worldEventMissionUIController.EventOnEnterMission += this.WorldEventMissionUIController_OnEnterMission;
				this.m_worldEventMissionUIController.EventOnClose += this.WorldEventMissionUIController_OnClose;
			}
		}

		// Token: 0x06014E49 RID: 85577 RVA: 0x0054AE98 File Offset: 0x00549098
		private void UninitEventMissionUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitEventMissionUIController_hotfix != null)
			{
				this.m_UninitEventMissionUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_worldEventMissionUIController != null)
			{
				this.m_worldEventMissionUIController.EventOnEnterMission -= this.WorldEventMissionUIController_OnEnterMission;
				this.m_worldEventMissionUIController.EventOnClose -= this.WorldEventMissionUIController_OnClose;
				this.m_worldEventMissionUIController = null;
			}
		}

		// Token: 0x06014E4A RID: 85578 RVA: 0x0054AF40 File Offset: 0x00549140
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
				this.m_worldEventMissionUIController.Open();
			}
			if (this.m_eventInfo != null)
			{
				List<Goods> list = new List<Goods>();
				list.AddRange(this.m_eventInfo.Reward);
				UIUtility.AppendRandomDropRewardGoodsToList(this.m_eventInfo.Drop_ID, list);
				if (list.Count > 3)
				{
					list.RemoveRange(3, list.Count - 3);
				}
				this.m_worldEventMissionUIController.SetEvent(this.m_eventInfo);
				this.m_worldEventMissionUIController.SetRewards(list);
			}
		}

		// Token: 0x06014E4B RID: 85579 RVA: 0x0054B024 File Offset: 0x00549224
		private void WorldEventMissionUIController_OnEnterMission()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldEventMissionUIController_OnEnterMission_hotfix != null)
			{
				this.m_WorldEventMissionUIController_OnEnterMission_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			if (this.EventOnEnterMission != null)
			{
				this.EventOnEnterMission();
			}
		}

		// Token: 0x06014E4C RID: 85580 RVA: 0x0054B0A0 File Offset: 0x005492A0
		private void WorldEventMissionUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldEventMissionUIController_OnClose_hotfix != null)
			{
				this.m_WorldEventMissionUIController_OnClose_hotfix.call(new object[]
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

		// Token: 0x1400049B RID: 1179
		// (add) Token: 0x06014E4D RID: 85581 RVA: 0x0054B11C File Offset: 0x0054931C
		// (remove) Token: 0x06014E4E RID: 85582 RVA: 0x0054B1B8 File Offset: 0x005493B8
		public event Action EventOnEnterMission
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEnterMissionAction_hotfix != null)
				{
					this.m_add_EventOnEnterMissionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEnterMission;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEnterMission, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEnterMissionAction_hotfix != null)
				{
					this.m_remove_EventOnEnterMissionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEnterMission;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEnterMission, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400049C RID: 1180
		// (add) Token: 0x06014E4F RID: 85583 RVA: 0x0054B254 File Offset: 0x00549454
		// (remove) Token: 0x06014E50 RID: 85584 RVA: 0x0054B2F0 File Offset: 0x005494F0
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

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x06014E51 RID: 85585 RVA: 0x0054B38C File Offset: 0x0054958C
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

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x06014E52 RID: 85586 RVA: 0x0054B400 File Offset: 0x00549600
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

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x06014E53 RID: 85587 RVA: 0x0054B474 File Offset: 0x00549674
		// (set) Token: 0x06014E54 RID: 85588 RVA: 0x0054B494 File Offset: 0x00549694
		[DoNotToLua]
		public new WorldEventMissionUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldEventMissionUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014E55 RID: 85589 RVA: 0x0054B4A0 File Offset: 0x005496A0
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06014E56 RID: 85590 RVA: 0x0054B4AC File Offset: 0x005496AC
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06014E57 RID: 85591 RVA: 0x0054B4B4 File Offset: 0x005496B4
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06014E58 RID: 85592 RVA: 0x0054B4BC File Offset: 0x005496BC
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06014E59 RID: 85593 RVA: 0x0054B4C8 File Offset: 0x005496C8
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06014E5A RID: 85594 RVA: 0x0054B4D4 File Offset: 0x005496D4
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06014E5B RID: 85595 RVA: 0x0054B4E0 File Offset: 0x005496E0
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014E5C RID: 85596 RVA: 0x0054B4E8 File Offset: 0x005496E8
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06014E5D RID: 85597 RVA: 0x0054B4F0 File Offset: 0x005496F0
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06014E5E RID: 85598 RVA: 0x0054B4F8 File Offset: 0x005496F8
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06014E5F RID: 85599 RVA: 0x0054B500 File Offset: 0x00549700
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06014E60 RID: 85600 RVA: 0x0054B508 File Offset: 0x00549708
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06014E61 RID: 85601 RVA: 0x0054B510 File Offset: 0x00549710
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06014E62 RID: 85602 RVA: 0x0054B518 File Offset: 0x00549718
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06014E63 RID: 85603 RVA: 0x0054B524 File Offset: 0x00549724
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06014E64 RID: 85604 RVA: 0x0054B530 File Offset: 0x00549730
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06014E65 RID: 85605 RVA: 0x0054B53C File Offset: 0x0054973C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06014E66 RID: 85606 RVA: 0x0054B548 File Offset: 0x00549748
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06014E67 RID: 85607 RVA: 0x0054B550 File Offset: 0x00549750
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06014E68 RID: 85608 RVA: 0x0054B558 File Offset: 0x00549758
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06014E69 RID: 85609 RVA: 0x0054B560 File Offset: 0x00549760
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06014E6A RID: 85610 RVA: 0x0054B568 File Offset: 0x00549768
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06014E6B RID: 85611 RVA: 0x0054B570 File Offset: 0x00549770
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06014E6C RID: 85612 RVA: 0x0054B578 File Offset: 0x00549778
		private void __callDele_EventOnEnterMission()
		{
			Action eventOnEnterMission = this.EventOnEnterMission;
			if (eventOnEnterMission != null)
			{
				eventOnEnterMission();
			}
		}

		// Token: 0x06014E6D RID: 85613 RVA: 0x0054B598 File Offset: 0x00549798
		private void __clearDele_EventOnEnterMission()
		{
			this.EventOnEnterMission = null;
		}

		// Token: 0x06014E6E RID: 85614 RVA: 0x0054B5A4 File Offset: 0x005497A4
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06014E6F RID: 85615 RVA: 0x0054B5C4 File Offset: 0x005497C4
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06014E70 RID: 85616 RVA: 0x0054B5D0 File Offset: 0x005497D0
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
					this.m_InitWorldEventMissionUIController_hotfix = (luaObj.RawGet("InitWorldEventMissionUIController") as LuaFunction);
					this.m_UninitEventMissionUIController_hotfix = (luaObj.RawGet("UninitEventMissionUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_WorldEventMissionUIController_OnEnterMission_hotfix = (luaObj.RawGet("WorldEventMissionUIController_OnEnterMission") as LuaFunction);
					this.m_WorldEventMissionUIController_OnClose_hotfix = (luaObj.RawGet("WorldEventMissionUIController_OnClose") as LuaFunction);
					this.m_add_EventOnEnterMissionAction_hotfix = (luaObj.RawGet("add_EventOnEnterMission") as LuaFunction);
					this.m_remove_EventOnEnterMissionAction_hotfix = (luaObj.RawGet("remove_EventOnEnterMission") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014E71 RID: 85617 RVA: 0x0054B844 File Offset: 0x00549A44
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldEventMissionUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B6C9 RID: 46793
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "WorldEventMissionUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/World_ABS/Prefab/WorldEventMissionUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B6CA RID: 46794
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "WorldEventMissionUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.WorldEventMissionUIController"),
				m_ctrlName = "WorldEventMissionUIController"
			}
		};

		// Token: 0x0400B6CB RID: 46795
		private WorldEventMissionUIController m_worldEventMissionUIController;

		// Token: 0x0400B6CC RID: 46796
		private ConfigDataEventInfo m_eventInfo;

		// Token: 0x0400B6CD RID: 46797
		[DoNotToLua]
		private WorldEventMissionUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B6CE RID: 46798
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B6CF RID: 46799
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B6D0 RID: 46800
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B6D1 RID: 46801
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400B6D2 RID: 46802
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400B6D3 RID: 46803
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400B6D4 RID: 46804
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400B6D5 RID: 46805
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B6D6 RID: 46806
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B6D7 RID: 46807
		private LuaFunction m_InitWorldEventMissionUIController_hotfix;

		// Token: 0x0400B6D8 RID: 46808
		private LuaFunction m_UninitEventMissionUIController_hotfix;

		// Token: 0x0400B6D9 RID: 46809
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B6DA RID: 46810
		private LuaFunction m_WorldEventMissionUIController_OnEnterMission_hotfix;

		// Token: 0x0400B6DB RID: 46811
		private LuaFunction m_WorldEventMissionUIController_OnClose_hotfix;

		// Token: 0x0400B6DC RID: 46812
		private LuaFunction m_add_EventOnEnterMissionAction_hotfix;

		// Token: 0x0400B6DD RID: 46813
		private LuaFunction m_remove_EventOnEnterMissionAction_hotfix;

		// Token: 0x0400B6DE RID: 46814
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400B6DF RID: 46815
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400B6E0 RID: 46816
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B6E1 RID: 46817
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02001021 RID: 4129
		public new class LuaExportHelper
		{
			// Token: 0x06014E72 RID: 85618 RVA: 0x0054B8AC File Offset: 0x00549AAC
			public LuaExportHelper(WorldEventMissionUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014E73 RID: 85619 RVA: 0x0054B8BC File Offset: 0x00549ABC
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06014E74 RID: 85620 RVA: 0x0054B8CC File Offset: 0x00549ACC
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06014E75 RID: 85621 RVA: 0x0054B8DC File Offset: 0x00549ADC
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06014E76 RID: 85622 RVA: 0x0054B8EC File Offset: 0x00549AEC
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06014E77 RID: 85623 RVA: 0x0054B8FC File Offset: 0x00549AFC
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06014E78 RID: 85624 RVA: 0x0054B90C File Offset: 0x00549B0C
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06014E79 RID: 85625 RVA: 0x0054B91C File Offset: 0x00549B1C
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06014E7A RID: 85626 RVA: 0x0054B92C File Offset: 0x00549B2C
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06014E7B RID: 85627 RVA: 0x0054B93C File Offset: 0x00549B3C
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06014E7C RID: 85628 RVA: 0x0054B94C File Offset: 0x00549B4C
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06014E7D RID: 85629 RVA: 0x0054B95C File Offset: 0x00549B5C
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06014E7E RID: 85630 RVA: 0x0054B96C File Offset: 0x00549B6C
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06014E7F RID: 85631 RVA: 0x0054B97C File Offset: 0x00549B7C
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06014E80 RID: 85632 RVA: 0x0054B98C File Offset: 0x00549B8C
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06014E81 RID: 85633 RVA: 0x0054B99C File Offset: 0x00549B9C
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06014E82 RID: 85634 RVA: 0x0054B9AC File Offset: 0x00549BAC
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06014E83 RID: 85635 RVA: 0x0054B9BC File Offset: 0x00549BBC
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06014E84 RID: 85636 RVA: 0x0054B9CC File Offset: 0x00549BCC
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06014E85 RID: 85637 RVA: 0x0054B9DC File Offset: 0x00549BDC
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06014E86 RID: 85638 RVA: 0x0054B9EC File Offset: 0x00549BEC
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06014E87 RID: 85639 RVA: 0x0054B9FC File Offset: 0x00549BFC
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06014E88 RID: 85640 RVA: 0x0054BA0C File Offset: 0x00549C0C
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06014E89 RID: 85641 RVA: 0x0054BA1C File Offset: 0x00549C1C
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x06014E8A RID: 85642 RVA: 0x0054BA2C File Offset: 0x00549C2C
			public void __callDele_EventOnEnterMission()
			{
				this.m_owner.__callDele_EventOnEnterMission();
			}

			// Token: 0x06014E8B RID: 85643 RVA: 0x0054BA3C File Offset: 0x00549C3C
			public void __clearDele_EventOnEnterMission()
			{
				this.m_owner.__clearDele_EventOnEnterMission();
			}

			// Token: 0x06014E8C RID: 85644 RVA: 0x0054BA4C File Offset: 0x00549C4C
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06014E8D RID: 85645 RVA: 0x0054BA5C File Offset: 0x00549C5C
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17003DA4 RID: 15780
			// (get) Token: 0x06014E8E RID: 85646 RVA: 0x0054BA6C File Offset: 0x00549C6C
			// (set) Token: 0x06014E8F RID: 85647 RVA: 0x0054BA7C File Offset: 0x00549C7C
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

			// Token: 0x17003DA5 RID: 15781
			// (get) Token: 0x06014E90 RID: 85648 RVA: 0x0054BA8C File Offset: 0x00549C8C
			// (set) Token: 0x06014E91 RID: 85649 RVA: 0x0054BA9C File Offset: 0x00549C9C
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

			// Token: 0x17003DA6 RID: 15782
			// (get) Token: 0x06014E92 RID: 85650 RVA: 0x0054BAAC File Offset: 0x00549CAC
			// (set) Token: 0x06014E93 RID: 85651 RVA: 0x0054BABC File Offset: 0x00549CBC
			public WorldEventMissionUIController m_worldEventMissionUIController
			{
				get
				{
					return this.m_owner.m_worldEventMissionUIController;
				}
				set
				{
					this.m_owner.m_worldEventMissionUIController = value;
				}
			}

			// Token: 0x17003DA7 RID: 15783
			// (get) Token: 0x06014E94 RID: 85652 RVA: 0x0054BACC File Offset: 0x00549CCC
			// (set) Token: 0x06014E95 RID: 85653 RVA: 0x0054BADC File Offset: 0x00549CDC
			public ConfigDataEventInfo m_eventInfo
			{
				get
				{
					return this.m_owner.m_eventInfo;
				}
				set
				{
					this.m_owner.m_eventInfo = value;
				}
			}

			// Token: 0x17003DA8 RID: 15784
			// (get) Token: 0x06014E96 RID: 85654 RVA: 0x0054BAEC File Offset: 0x00549CEC
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003DA9 RID: 15785
			// (get) Token: 0x06014E97 RID: 85655 RVA: 0x0054BAFC File Offset: 0x00549CFC
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06014E98 RID: 85656 RVA: 0x0054BB0C File Offset: 0x00549D0C
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06014E99 RID: 85657 RVA: 0x0054BB1C File Offset: 0x00549D1C
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06014E9A RID: 85658 RVA: 0x0054BB2C File Offset: 0x00549D2C
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x06014E9B RID: 85659 RVA: 0x0054BB3C File Offset: 0x00549D3C
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06014E9C RID: 85660 RVA: 0x0054BB4C File Offset: 0x00549D4C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06014E9D RID: 85661 RVA: 0x0054BB5C File Offset: 0x00549D5C
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06014E9E RID: 85662 RVA: 0x0054BB6C File Offset: 0x00549D6C
			public void InitWorldEventMissionUIController()
			{
				this.m_owner.InitWorldEventMissionUIController();
			}

			// Token: 0x06014E9F RID: 85663 RVA: 0x0054BB7C File Offset: 0x00549D7C
			public void UninitEventMissionUIController()
			{
				this.m_owner.UninitEventMissionUIController();
			}

			// Token: 0x06014EA0 RID: 85664 RVA: 0x0054BB8C File Offset: 0x00549D8C
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06014EA1 RID: 85665 RVA: 0x0054BB9C File Offset: 0x00549D9C
			public void WorldEventMissionUIController_OnEnterMission()
			{
				this.m_owner.WorldEventMissionUIController_OnEnterMission();
			}

			// Token: 0x06014EA2 RID: 85666 RVA: 0x0054BBAC File Offset: 0x00549DAC
			public void WorldEventMissionUIController_OnClose()
			{
				this.m_owner.WorldEventMissionUIController_OnClose();
			}

			// Token: 0x0400B6E2 RID: 46818
			private WorldEventMissionUITask m_owner;
		}
	}
}
