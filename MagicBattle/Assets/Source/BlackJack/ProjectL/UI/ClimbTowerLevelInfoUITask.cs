using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B82 RID: 2946
	[HotFix]
	public class ClimbTowerLevelInfoUITask : UITask
	{
		// Token: 0x0600C8CA RID: 51402 RVA: 0x00378C90 File Offset: 0x00376E90
		public ClimbTowerLevelInfoUITask(string name) : base(name)
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

		// Token: 0x0600C8CB RID: 51403 RVA: 0x00378D84 File Offset: 0x00376F84
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

		// Token: 0x0600C8CC RID: 51404 RVA: 0x00378E10 File Offset: 0x00377010
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

		// Token: 0x0600C8CD RID: 51405 RVA: 0x00378E9C File Offset: 0x0037709C
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
			this.m_towerFloorInfo = null;
			this.m_towerLevelInfo = null;
			this.m_towerBonusHeroGroupInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_towerFloorInfo = uiintentCustom.GetClassParam<ConfigDataTowerFloorInfo>("TowerFloorInfo");
				this.m_towerLevelInfo = uiintentCustom.GetClassParam<ConfigDataTowerLevelInfo>("TowerLevelInfo");
				this.m_towerBattleRuleInfo = uiintentCustom.GetClassParam<ConfigDataTowerBattleRuleInfo>("TowerBattleRuleInfo");
				this.m_towerBonusHeroGroupInfo = uiintentCustom.GetClassParam<ConfigDataTowerBonusHeroGroupInfo>("TowerBonusHeroGroupInfo");
			}
		}

		// Token: 0x0600C8CE RID: 51406 RVA: 0x00378F74 File Offset: 0x00377174
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
			if (this.m_towerLevelInfo != null)
			{
				base.CollectSpriteAsset(this.m_towerLevelInfo.ThumbImage);
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600C8CF RID: 51407 RVA: 0x00379008 File Offset: 0x00377208
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
			if (this.m_climbTowerLevelInfoUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_climbTowerLevelInfoUIController = (this.m_uiCtrlArray[0] as ClimbTowerLevelInfoUIController);
				}
				if (!(this.m_climbTowerLevelInfoUIController != null))
				{
					Debug.LogError("ClimbTowerLevelInfoUIController is null");
					return;
				}
				this.m_climbTowerLevelInfoUIController.EventOnStartBattle += this.ClimbTowerLevelInfoUIController_OnStartBattle;
				this.m_climbTowerLevelInfoUIController.EventOnClose += this.ClimbTowerLevelInfoUIController_OnClose;
			}
		}

		// Token: 0x0600C8D0 RID: 51408 RVA: 0x003790F0 File Offset: 0x003772F0
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
			if (this.m_climbTowerLevelInfoUIController != null)
			{
				this.m_climbTowerLevelInfoUIController.EventOnStartBattle -= this.ClimbTowerLevelInfoUIController_OnStartBattle;
				this.m_climbTowerLevelInfoUIController.EventOnClose -= this.ClimbTowerLevelInfoUIController_OnClose;
				this.m_climbTowerLevelInfoUIController = null;
			}
		}

		// Token: 0x0600C8D1 RID: 51409 RVA: 0x0037919C File Offset: 0x0037739C
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
				this.m_climbTowerLevelInfoUIController.Open(this.m_towerBonusHeroGroupInfo != null);
			}
			this.m_climbTowerLevelInfoUIController.SetTowerLevel(this.m_towerFloorInfo, this.m_towerLevelInfo, this.m_towerBattleRuleInfo, this.m_towerBonusHeroGroupInfo);
		}

		// Token: 0x0600C8D2 RID: 51410 RVA: 0x00379244 File Offset: 0x00377444
		private void ClimbTowerLevelInfoUIController_OnStartBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerLevelInfoUIController_OnStartBattle_hotfix != null)
			{
				this.m_ClimbTowerLevelInfoUIController_OnStartBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_towerFloorInfo == null || this.m_towerLevelInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackClimbTowerFloor(this.m_towerFloorInfo.ID);
			if (num == 0)
			{
				WorldUITask.StartBattleHappening(BattleType.ClimbTower, this.m_towerFloorInfo.ID);
			}
			else if (num == -5403)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_ClimbTower_Flush, 2f, null, true);
				ClimbTowerGetNetTask climbTowerGetNetTask = new ClimbTowerGetNetTask();
				climbTowerGetNetTask.EventOnStop += delegate(Task task)
				{
					ClimbTowerGetNetTask climbTowerGetNetTask2 = task as ClimbTowerGetNetTask;
					if (climbTowerGetNetTask2.Result == 0)
					{
						this.ClimbTowerLevelInfoUIController_OnClose();
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(climbTowerGetNetTask2.Result, 2f, null, true);
					}
				};
				climbTowerGetNetTask.Start(null);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x0600C8D3 RID: 51411 RVA: 0x0037934C File Offset: 0x0037754C
		private void ClimbTowerLevelInfoUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerLevelInfoUIController_OnClose_hotfix != null)
			{
				this.m_ClimbTowerLevelInfoUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_climbTowerLevelInfoUIController.Close(delegate
			{
				base.Pause();
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			});
		}

		// Token: 0x1400026D RID: 621
		// (add) Token: 0x0600C8D4 RID: 51412 RVA: 0x003793C4 File Offset: 0x003775C4
		// (remove) Token: 0x0600C8D5 RID: 51413 RVA: 0x00379460 File Offset: 0x00377660
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

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x0600C8D6 RID: 51414 RVA: 0x003794FC File Offset: 0x003776FC
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

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x0600C8D7 RID: 51415 RVA: 0x00379570 File Offset: 0x00377770
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

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x0600C8D8 RID: 51416 RVA: 0x003795E4 File Offset: 0x003777E4
		// (set) Token: 0x0600C8D9 RID: 51417 RVA: 0x00379604 File Offset: 0x00377804
		[DoNotToLua]
		public new ClimbTowerLevelInfoUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClimbTowerLevelInfoUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C8DA RID: 51418 RVA: 0x00379610 File Offset: 0x00377810
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600C8DB RID: 51419 RVA: 0x0037961C File Offset: 0x0037781C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600C8DC RID: 51420 RVA: 0x00379624 File Offset: 0x00377824
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600C8DD RID: 51421 RVA: 0x0037962C File Offset: 0x0037782C
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600C8DE RID: 51422 RVA: 0x00379638 File Offset: 0x00377838
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600C8DF RID: 51423 RVA: 0x00379644 File Offset: 0x00377844
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600C8E0 RID: 51424 RVA: 0x00379650 File Offset: 0x00377850
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600C8E1 RID: 51425 RVA: 0x00379658 File Offset: 0x00377858
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600C8E2 RID: 51426 RVA: 0x00379660 File Offset: 0x00377860
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600C8E3 RID: 51427 RVA: 0x00379668 File Offset: 0x00377868
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600C8E4 RID: 51428 RVA: 0x00379670 File Offset: 0x00377870
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600C8E5 RID: 51429 RVA: 0x00379678 File Offset: 0x00377878
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600C8E6 RID: 51430 RVA: 0x00379680 File Offset: 0x00377880
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600C8E7 RID: 51431 RVA: 0x00379688 File Offset: 0x00377888
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600C8E8 RID: 51432 RVA: 0x00379694 File Offset: 0x00377894
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600C8E9 RID: 51433 RVA: 0x003796A0 File Offset: 0x003778A0
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600C8EA RID: 51434 RVA: 0x003796AC File Offset: 0x003778AC
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600C8EB RID: 51435 RVA: 0x003796B8 File Offset: 0x003778B8
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600C8EC RID: 51436 RVA: 0x003796C0 File Offset: 0x003778C0
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600C8ED RID: 51437 RVA: 0x003796C8 File Offset: 0x003778C8
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600C8EE RID: 51438 RVA: 0x003796D0 File Offset: 0x003778D0
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600C8EF RID: 51439 RVA: 0x003796D8 File Offset: 0x003778D8
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600C8F0 RID: 51440 RVA: 0x003796E0 File Offset: 0x003778E0
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600C8F1 RID: 51441 RVA: 0x003796E8 File Offset: 0x003778E8
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600C8F2 RID: 51442 RVA: 0x00379708 File Offset: 0x00377908
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600C8F5 RID: 51445 RVA: 0x00379778 File Offset: 0x00377978
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
					this.m_ClimbTowerLevelInfoUIController_OnStartBattle_hotfix = (luaObj.RawGet("ClimbTowerLevelInfoUIController_OnStartBattle") as LuaFunction);
					this.m_ClimbTowerLevelInfoUIController_OnClose_hotfix = (luaObj.RawGet("ClimbTowerLevelInfoUIController_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C8F6 RID: 51446 RVA: 0x00379988 File Offset: 0x00377B88
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerLevelInfoUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007ECB RID: 32459
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ClimbTowerLevelInfoUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/ClimbTower_ABS/Prefab/ClimbTowerLevelInfoUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04007ECC RID: 32460
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ClimbTowerLevelInfoUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ClimbTowerLevelInfoUIController"),
				m_ctrlName = "ClimbTowerLevelInfoUIController"
			}
		};

		// Token: 0x04007ECD RID: 32461
		private ClimbTowerLevelInfoUIController m_climbTowerLevelInfoUIController;

		// Token: 0x04007ECE RID: 32462
		private ConfigDataTowerFloorInfo m_towerFloorInfo;

		// Token: 0x04007ECF RID: 32463
		private ConfigDataTowerLevelInfo m_towerLevelInfo;

		// Token: 0x04007ED0 RID: 32464
		private ConfigDataTowerBattleRuleInfo m_towerBattleRuleInfo;

		// Token: 0x04007ED1 RID: 32465
		private ConfigDataTowerBonusHeroGroupInfo m_towerBonusHeroGroupInfo;

		// Token: 0x04007ED2 RID: 32466
		[DoNotToLua]
		private ClimbTowerLevelInfoUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04007ED3 RID: 32467
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007ED4 RID: 32468
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007ED5 RID: 32469
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04007ED6 RID: 32470
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04007ED7 RID: 32471
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04007ED8 RID: 32472
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04007ED9 RID: 32473
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04007EDA RID: 32474
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04007EDB RID: 32475
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04007EDC RID: 32476
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04007EDD RID: 32477
		private LuaFunction m_ClimbTowerLevelInfoUIController_OnStartBattle_hotfix;

		// Token: 0x04007EDE RID: 32478
		private LuaFunction m_ClimbTowerLevelInfoUIController_OnClose_hotfix;

		// Token: 0x04007EDF RID: 32479
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04007EE0 RID: 32480
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04007EE1 RID: 32481
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04007EE2 RID: 32482
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000B83 RID: 2947
		public new class LuaExportHelper
		{
			// Token: 0x0600C8F7 RID: 51447 RVA: 0x003799F0 File Offset: 0x00377BF0
			public LuaExportHelper(ClimbTowerLevelInfoUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C8F8 RID: 51448 RVA: 0x00379A00 File Offset: 0x00377C00
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600C8F9 RID: 51449 RVA: 0x00379A10 File Offset: 0x00377C10
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600C8FA RID: 51450 RVA: 0x00379A20 File Offset: 0x00377C20
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600C8FB RID: 51451 RVA: 0x00379A30 File Offset: 0x00377C30
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600C8FC RID: 51452 RVA: 0x00379A40 File Offset: 0x00377C40
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600C8FD RID: 51453 RVA: 0x00379A50 File Offset: 0x00377C50
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600C8FE RID: 51454 RVA: 0x00379A60 File Offset: 0x00377C60
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600C8FF RID: 51455 RVA: 0x00379A70 File Offset: 0x00377C70
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600C900 RID: 51456 RVA: 0x00379A80 File Offset: 0x00377C80
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600C901 RID: 51457 RVA: 0x00379A90 File Offset: 0x00377C90
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600C902 RID: 51458 RVA: 0x00379AA0 File Offset: 0x00377CA0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600C903 RID: 51459 RVA: 0x00379AB0 File Offset: 0x00377CB0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600C904 RID: 51460 RVA: 0x00379AC0 File Offset: 0x00377CC0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600C905 RID: 51461 RVA: 0x00379AD0 File Offset: 0x00377CD0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600C906 RID: 51462 RVA: 0x00379AE0 File Offset: 0x00377CE0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600C907 RID: 51463 RVA: 0x00379AF0 File Offset: 0x00377CF0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600C908 RID: 51464 RVA: 0x00379B00 File Offset: 0x00377D00
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600C909 RID: 51465 RVA: 0x00379B10 File Offset: 0x00377D10
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600C90A RID: 51466 RVA: 0x00379B20 File Offset: 0x00377D20
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600C90B RID: 51467 RVA: 0x00379B30 File Offset: 0x00377D30
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600C90C RID: 51468 RVA: 0x00379B40 File Offset: 0x00377D40
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600C90D RID: 51469 RVA: 0x00379B50 File Offset: 0x00377D50
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600C90E RID: 51470 RVA: 0x00379B60 File Offset: 0x00377D60
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600C90F RID: 51471 RVA: 0x00379B70 File Offset: 0x00377D70
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600C910 RID: 51472 RVA: 0x00379B80 File Offset: 0x00377D80
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170027EE RID: 10222
			// (get) Token: 0x0600C911 RID: 51473 RVA: 0x00379B90 File Offset: 0x00377D90
			// (set) Token: 0x0600C912 RID: 51474 RVA: 0x00379BA0 File Offset: 0x00377DA0
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

			// Token: 0x170027EF RID: 10223
			// (get) Token: 0x0600C913 RID: 51475 RVA: 0x00379BB0 File Offset: 0x00377DB0
			// (set) Token: 0x0600C914 RID: 51476 RVA: 0x00379BC0 File Offset: 0x00377DC0
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

			// Token: 0x170027F0 RID: 10224
			// (get) Token: 0x0600C915 RID: 51477 RVA: 0x00379BD0 File Offset: 0x00377DD0
			// (set) Token: 0x0600C916 RID: 51478 RVA: 0x00379BE0 File Offset: 0x00377DE0
			public ClimbTowerLevelInfoUIController m_climbTowerLevelInfoUIController
			{
				get
				{
					return this.m_owner.m_climbTowerLevelInfoUIController;
				}
				set
				{
					this.m_owner.m_climbTowerLevelInfoUIController = value;
				}
			}

			// Token: 0x170027F1 RID: 10225
			// (get) Token: 0x0600C917 RID: 51479 RVA: 0x00379BF0 File Offset: 0x00377DF0
			// (set) Token: 0x0600C918 RID: 51480 RVA: 0x00379C00 File Offset: 0x00377E00
			public ConfigDataTowerFloorInfo m_towerFloorInfo
			{
				get
				{
					return this.m_owner.m_towerFloorInfo;
				}
				set
				{
					this.m_owner.m_towerFloorInfo = value;
				}
			}

			// Token: 0x170027F2 RID: 10226
			// (get) Token: 0x0600C919 RID: 51481 RVA: 0x00379C10 File Offset: 0x00377E10
			// (set) Token: 0x0600C91A RID: 51482 RVA: 0x00379C20 File Offset: 0x00377E20
			public ConfigDataTowerLevelInfo m_towerLevelInfo
			{
				get
				{
					return this.m_owner.m_towerLevelInfo;
				}
				set
				{
					this.m_owner.m_towerLevelInfo = value;
				}
			}

			// Token: 0x170027F3 RID: 10227
			// (get) Token: 0x0600C91B RID: 51483 RVA: 0x00379C30 File Offset: 0x00377E30
			// (set) Token: 0x0600C91C RID: 51484 RVA: 0x00379C40 File Offset: 0x00377E40
			public ConfigDataTowerBattleRuleInfo m_towerBattleRuleInfo
			{
				get
				{
					return this.m_owner.m_towerBattleRuleInfo;
				}
				set
				{
					this.m_owner.m_towerBattleRuleInfo = value;
				}
			}

			// Token: 0x170027F4 RID: 10228
			// (get) Token: 0x0600C91D RID: 51485 RVA: 0x00379C50 File Offset: 0x00377E50
			// (set) Token: 0x0600C91E RID: 51486 RVA: 0x00379C60 File Offset: 0x00377E60
			public ConfigDataTowerBonusHeroGroupInfo m_towerBonusHeroGroupInfo
			{
				get
				{
					return this.m_owner.m_towerBonusHeroGroupInfo;
				}
				set
				{
					this.m_owner.m_towerBonusHeroGroupInfo = value;
				}
			}

			// Token: 0x170027F5 RID: 10229
			// (get) Token: 0x0600C91F RID: 51487 RVA: 0x00379C70 File Offset: 0x00377E70
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170027F6 RID: 10230
			// (get) Token: 0x0600C920 RID: 51488 RVA: 0x00379C80 File Offset: 0x00377E80
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600C921 RID: 51489 RVA: 0x00379C90 File Offset: 0x00377E90
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600C922 RID: 51490 RVA: 0x00379CA0 File Offset: 0x00377EA0
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600C923 RID: 51491 RVA: 0x00379CB0 File Offset: 0x00377EB0
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600C924 RID: 51492 RVA: 0x00379CC0 File Offset: 0x00377EC0
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600C925 RID: 51493 RVA: 0x00379CD0 File Offset: 0x00377ED0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600C926 RID: 51494 RVA: 0x00379CE0 File Offset: 0x00377EE0
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600C927 RID: 51495 RVA: 0x00379CF0 File Offset: 0x00377EF0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600C928 RID: 51496 RVA: 0x00379D00 File Offset: 0x00377F00
			public void ClimbTowerLevelInfoUIController_OnStartBattle()
			{
				this.m_owner.ClimbTowerLevelInfoUIController_OnStartBattle();
			}

			// Token: 0x0600C929 RID: 51497 RVA: 0x00379D10 File Offset: 0x00377F10
			public void ClimbTowerLevelInfoUIController_OnClose()
			{
				this.m_owner.ClimbTowerLevelInfoUIController_OnClose();
			}

			// Token: 0x04007EE3 RID: 32483
			private ClimbTowerLevelInfoUITask m_owner;
		}
	}
}
