using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D59 RID: 3417
	[HotFix]
	public class EquipmentDepotUITask : UITask
	{
		// Token: 0x0600FBAF RID: 64431 RVA: 0x00422944 File Offset: 0x00420B44
		public EquipmentDepotUITask(string name) : base(name)
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

		// Token: 0x0600FBB0 RID: 64432 RVA: 0x00422A3C File Offset: 0x00420C3C
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
			if (this.m_equipmentDepotUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_equipmentDepotUIController = (this.m_uiCtrlArray[0] as EquipmentDepotUIController);
				}
				if (!(this.m_equipmentDepotUIController != null))
				{
					Debug.LogError("EquipmentDepotUITask is null");
					return;
				}
				this.m_equipmentDepotUIController.EventOnReturn += this.EquipmentDepotUIController_OnReturn;
				this.m_equipmentDepotUIController.EventOnEquipButtonClick += this.EquipmentDepotUIController_OnEquipmentWear;
				this.m_equipmentDepotUIController.EventOnLockButtonClick += this.EquipmentDepotUIController_OnEquipmentLockAndUnLock;
				this.m_equipmentDepotUIController.EventOnTakeOffEquipment += this.EquipmentDepotUIController_OnEquipmentTakeOff;
				this.m_equipmentDepotUIController.EventOnGoldAddButtonClick += this.EquipmentDepotUIController_OnGoldAddButtonClick;
			}
		}

		// Token: 0x0600FBB1 RID: 64433 RVA: 0x00422B68 File Offset: 0x00420D68
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
			if (this.m_equipmentDepotUIController != null)
			{
				this.m_equipmentDepotUIController.EventOnReturn -= this.EquipmentDepotUIController_OnReturn;
				this.m_equipmentDepotUIController.EventOnEquipButtonClick -= this.EquipmentDepotUIController_OnEquipmentWear;
				this.m_equipmentDepotUIController.EventOnLockButtonClick -= this.EquipmentDepotUIController_OnEquipmentLockAndUnLock;
				this.m_equipmentDepotUIController.EventOnTakeOffEquipment -= this.EquipmentDepotUIController_OnEquipmentTakeOff;
				this.m_equipmentDepotUIController.EventOnGoldAddButtonClick -= this.EquipmentDepotUIController_OnGoldAddButtonClick;
				this.m_equipmentDepotUIController = null;
			}
		}

		// Token: 0x0600FBB2 RID: 64434 RVA: 0x00422C5C File Offset: 0x00420E5C
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

		// Token: 0x0600FBB3 RID: 64435 RVA: 0x00422CE8 File Offset: 0x00420EE8
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

		// Token: 0x0600FBB4 RID: 64436 RVA: 0x00422D74 File Offset: 0x00420F74
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
			if (uiintentCustom != null && this.m_hero == null)
			{
				object obj = 0;
				object obj2 = 0;
				object obj3 = 0;
				uiintentCustom.TryGetParam("slot", out obj2);
				uiintentCustom.TryGetParam("id", out obj3);
				Hero classParam = uiintentCustom.GetClassParam<Hero>("hero");
				if (this.m_hero != classParam)
				{
					this.m_hero = classParam;
				}
				this.m_state = (int)obj;
				this.m_slot = (int)obj2;
				this.m_instanceId = (ulong)obj3;
			}
		}

		// Token: 0x0600FBB5 RID: 64437 RVA: 0x00422E74 File Offset: 0x00421074
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
			this.m_equipmentDepotUIController.UpdateEquipmentDepotView(this.m_hero, this.m_slot, this.m_instanceId);
			base.ExecAfterTicks(delegate
			{
				if (this.m_isAlreadyEnter)
				{
					this.m_isAlreadyEnter = false;
				}
			}, 5UL);
		}

		// Token: 0x0600FBB6 RID: 64438 RVA: 0x00422F08 File Offset: 0x00421108
		private void EquipmentDepotUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentDepotUIController_OnReturn_hotfix != null)
			{
				this.m_EquipmentDepotUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_isAlreadyEnter = true;
				base.Pause();
				base.ReturnPrevUITask();
				this.m_hero = null;
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600FBB7 RID: 64439 RVA: 0x00422F8C File Offset: 0x0042118C
		private void EquipmentDepotUIController_OnEquipmentWear(int heroId, ulong instanceId, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentDepotUIController_OnEquipmentWearInt32UInt64Int32_hotfix != null)
			{
				this.m_EquipmentDepotUIController_OnEquipmentWearInt32UInt64Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					instanceId2,
					slot2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int slot = slot2;
			ulong instanceId = instanceId2;
			EquipmentDepotUITask $this = this;
			EquipmentWearNetTask equipmentWearNetTask = new EquipmentWearNetTask(heroId, instanceId);
			equipmentWearNetTask.EventOnStop += delegate(Task task)
			{
				EquipmentWearNetTask equipmentWearNetTask2 = task as EquipmentWearNetTask;
				if (equipmentWearNetTask2.Result == 0)
				{
					$this.m_slot = slot;
					$this.m_instanceId = instanceId;
					$this.EquipmentDepotUIController_OnReturn();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(equipmentWearNetTask2.Result, 2f, null, true);
				}
			};
			equipmentWearNetTask.Start(null);
		}

		// Token: 0x0600FBB8 RID: 64440 RVA: 0x00423060 File Offset: 0x00421260
		private void EquipmentDepotUIController_OnEquipmentLockAndUnLock(ulong instanceId, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentDepotUIController_OnEquipmentLockAndUnLockUInt64Int32_hotfix != null)
			{
				this.m_EquipmentDepotUIController_OnEquipmentLockAndUnLockUInt64Int32_hotfix.call(new object[]
				{
					this,
					instanceId2,
					slot2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int slot = slot2;
			ulong instanceId = instanceId2;
			EquipmentDepotUITask $this = this;
			EquipmentLockAndUnLockNetTask equipmentLockAndUnLockNetTask = new EquipmentLockAndUnLockNetTask(instanceId);
			equipmentLockAndUnLockNetTask.EventOnStop += delegate(Task task)
			{
				EquipmentLockAndUnLockNetTask equipmentLockAndUnLockNetTask2 = task as EquipmentLockAndUnLockNetTask;
				if (equipmentLockAndUnLockNetTask2.Result == 0)
				{
					$this.m_state = 0;
					$this.m_slot = slot;
					$this.m_instanceId = instanceId;
					$this.UpdateView();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(equipmentLockAndUnLockNetTask2.Result, 2f, null, true);
				}
			};
			equipmentLockAndUnLockNetTask.Start(null);
		}

		// Token: 0x0600FBB9 RID: 64441 RVA: 0x00423124 File Offset: 0x00421324
		private void EquipmentDepotUIController_OnEquipmentTakeOff(int heroId, int slot, Action OnEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentDepotUIController_OnEquipmentTakeOffInt32Int32Action_hotfix != null)
			{
				this.m_EquipmentDepotUIController_OnEquipmentTakeOffInt32Int32Action_hotfix.call(new object[]
				{
					this,
					heroId,
					slot,
					OnEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnEnd = OnEnd2;
			EquipmentDepotUITask $this = this;
			EquipmentTakeOffNetTask equipmentTakeOffNetTask = new EquipmentTakeOffNetTask(heroId, slot);
			equipmentTakeOffNetTask.EventOnStop += delegate(Task task)
			{
				EquipmentTakeOffNetTask equipmentTakeOffNetTask2 = task as EquipmentTakeOffNetTask;
				if (equipmentTakeOffNetTask2.Result == 0)
				{
					if (OnEnd != null)
					{
						OnEnd();
					}
					else
					{
						$this.EquipmentDepotUIController_OnReturn();
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(equipmentTakeOffNetTask2.Result, 2f, null, true);
				}
			};
			equipmentTakeOffNetTask.Start(null);
		}

		// Token: 0x0600FBBA RID: 64442 RVA: 0x004231EC File Offset: 0x004213EC
		private void EquipmentDepotUIController_OnGoldAddButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentDepotUIController_OnGoldAddButtonClick_hotfix != null)
			{
				this.m_EquipmentDepotUIController_OnGoldAddButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Crystal, null, false);
		}

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x0600FBBB RID: 64443 RVA: 0x00423264 File Offset: 0x00421464
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

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x0600FBBC RID: 64444 RVA: 0x004232D8 File Offset: 0x004214D8
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

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x0600FBBD RID: 64445 RVA: 0x0042334C File Offset: 0x0042154C
		// (set) Token: 0x0600FBBE RID: 64446 RVA: 0x0042336C File Offset: 0x0042156C
		[DoNotToLua]
		public new EquipmentDepotUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EquipmentDepotUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600FBBF RID: 64447 RVA: 0x00423378 File Offset: 0x00421578
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600FBC0 RID: 64448 RVA: 0x00423384 File Offset: 0x00421584
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600FBC1 RID: 64449 RVA: 0x0042338C File Offset: 0x0042158C
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600FBC2 RID: 64450 RVA: 0x00423394 File Offset: 0x00421594
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600FBC3 RID: 64451 RVA: 0x004233A0 File Offset: 0x004215A0
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600FBC4 RID: 64452 RVA: 0x004233AC File Offset: 0x004215AC
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600FBC5 RID: 64453 RVA: 0x004233B8 File Offset: 0x004215B8
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600FBC6 RID: 64454 RVA: 0x004233C0 File Offset: 0x004215C0
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600FBC7 RID: 64455 RVA: 0x004233C8 File Offset: 0x004215C8
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600FBC8 RID: 64456 RVA: 0x004233D0 File Offset: 0x004215D0
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600FBC9 RID: 64457 RVA: 0x004233D8 File Offset: 0x004215D8
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600FBCA RID: 64458 RVA: 0x004233E0 File Offset: 0x004215E0
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600FBCB RID: 64459 RVA: 0x004233E8 File Offset: 0x004215E8
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600FBCC RID: 64460 RVA: 0x004233F0 File Offset: 0x004215F0
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600FBCD RID: 64461 RVA: 0x004233FC File Offset: 0x004215FC
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600FBCE RID: 64462 RVA: 0x00423408 File Offset: 0x00421608
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600FBCF RID: 64463 RVA: 0x00423414 File Offset: 0x00421614
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600FBD0 RID: 64464 RVA: 0x00423420 File Offset: 0x00421620
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600FBD1 RID: 64465 RVA: 0x00423428 File Offset: 0x00421628
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600FBD2 RID: 64466 RVA: 0x00423430 File Offset: 0x00421630
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600FBD3 RID: 64467 RVA: 0x00423438 File Offset: 0x00421638
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600FBD4 RID: 64468 RVA: 0x00423440 File Offset: 0x00421640
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600FBD5 RID: 64469 RVA: 0x00423448 File Offset: 0x00421648
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600FBD8 RID: 64472 RVA: 0x0042348C File Offset: 0x0042168C
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
					this.m_EquipmentDepotUIController_OnReturn_hotfix = (luaObj.RawGet("EquipmentDepotUIController_OnReturn") as LuaFunction);
					this.m_EquipmentDepotUIController_OnEquipmentWearInt32UInt64Int32_hotfix = (luaObj.RawGet("EquipmentDepotUIController_OnEquipmentWear") as LuaFunction);
					this.m_EquipmentDepotUIController_OnEquipmentLockAndUnLockUInt64Int32_hotfix = (luaObj.RawGet("EquipmentDepotUIController_OnEquipmentLockAndUnLock") as LuaFunction);
					this.m_EquipmentDepotUIController_OnEquipmentTakeOffInt32Int32Action_hotfix = (luaObj.RawGet("EquipmentDepotUIController_OnEquipmentTakeOff") as LuaFunction);
					this.m_EquipmentDepotUIController_OnGoldAddButtonClick_hotfix = (luaObj.RawGet("EquipmentDepotUIController_OnGoldAddButtonClick") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600FBD9 RID: 64473 RVA: 0x0042369C File Offset: 0x0042189C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentDepotUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400939C RID: 37788
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "EquipmentDepotUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/EquipmentDepotUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400939D RID: 37789
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "EquipmentDepotUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.EquipmentDepotUIController"),
				m_ctrlName = "EquipmentDepotUIController"
			}
		};

		// Token: 0x0400939E RID: 37790
		private Hero m_hero;

		// Token: 0x0400939F RID: 37791
		private int m_slot;

		// Token: 0x040093A0 RID: 37792
		private int m_state;

		// Token: 0x040093A1 RID: 37793
		private ulong m_instanceId;

		// Token: 0x040093A2 RID: 37794
		private bool m_isAlreadyEnter = true;

		// Token: 0x040093A3 RID: 37795
		private EquipmentDepotUIController m_equipmentDepotUIController;

		// Token: 0x040093A4 RID: 37796
		[DoNotToLua]
		private EquipmentDepotUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040093A5 RID: 37797
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040093A6 RID: 37798
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040093A7 RID: 37799
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040093A8 RID: 37800
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040093A9 RID: 37801
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040093AA RID: 37802
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x040093AB RID: 37803
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x040093AC RID: 37804
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x040093AD RID: 37805
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040093AE RID: 37806
		private LuaFunction m_EquipmentDepotUIController_OnReturn_hotfix;

		// Token: 0x040093AF RID: 37807
		private LuaFunction m_EquipmentDepotUIController_OnEquipmentWearInt32UInt64Int32_hotfix;

		// Token: 0x040093B0 RID: 37808
		private LuaFunction m_EquipmentDepotUIController_OnEquipmentLockAndUnLockUInt64Int32_hotfix;

		// Token: 0x040093B1 RID: 37809
		private LuaFunction m_EquipmentDepotUIController_OnEquipmentTakeOffInt32Int32Action_hotfix;

		// Token: 0x040093B2 RID: 37810
		private LuaFunction m_EquipmentDepotUIController_OnGoldAddButtonClick_hotfix;

		// Token: 0x040093B3 RID: 37811
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040093B4 RID: 37812
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000D5A RID: 3418
		public new class LuaExportHelper
		{
			// Token: 0x0600FBDA RID: 64474 RVA: 0x00423704 File Offset: 0x00421904
			public LuaExportHelper(EquipmentDepotUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600FBDB RID: 64475 RVA: 0x00423714 File Offset: 0x00421914
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600FBDC RID: 64476 RVA: 0x00423724 File Offset: 0x00421924
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600FBDD RID: 64477 RVA: 0x00423734 File Offset: 0x00421934
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600FBDE RID: 64478 RVA: 0x00423744 File Offset: 0x00421944
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600FBDF RID: 64479 RVA: 0x00423754 File Offset: 0x00421954
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600FBE0 RID: 64480 RVA: 0x00423764 File Offset: 0x00421964
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600FBE1 RID: 64481 RVA: 0x00423774 File Offset: 0x00421974
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600FBE2 RID: 64482 RVA: 0x00423784 File Offset: 0x00421984
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600FBE3 RID: 64483 RVA: 0x00423794 File Offset: 0x00421994
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600FBE4 RID: 64484 RVA: 0x004237A4 File Offset: 0x004219A4
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600FBE5 RID: 64485 RVA: 0x004237B4 File Offset: 0x004219B4
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600FBE6 RID: 64486 RVA: 0x004237C4 File Offset: 0x004219C4
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600FBE7 RID: 64487 RVA: 0x004237D4 File Offset: 0x004219D4
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600FBE8 RID: 64488 RVA: 0x004237E4 File Offset: 0x004219E4
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600FBE9 RID: 64489 RVA: 0x004237F4 File Offset: 0x004219F4
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600FBEA RID: 64490 RVA: 0x00423804 File Offset: 0x00421A04
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600FBEB RID: 64491 RVA: 0x00423814 File Offset: 0x00421A14
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600FBEC RID: 64492 RVA: 0x00423824 File Offset: 0x00421A24
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600FBED RID: 64493 RVA: 0x00423834 File Offset: 0x00421A34
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600FBEE RID: 64494 RVA: 0x00423844 File Offset: 0x00421A44
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600FBEF RID: 64495 RVA: 0x00423854 File Offset: 0x00421A54
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600FBF0 RID: 64496 RVA: 0x00423864 File Offset: 0x00421A64
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600FBF1 RID: 64497 RVA: 0x00423874 File Offset: 0x00421A74
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x1700300A RID: 12298
			// (get) Token: 0x0600FBF2 RID: 64498 RVA: 0x00423884 File Offset: 0x00421A84
			// (set) Token: 0x0600FBF3 RID: 64499 RVA: 0x00423894 File Offset: 0x00421A94
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

			// Token: 0x1700300B RID: 12299
			// (get) Token: 0x0600FBF4 RID: 64500 RVA: 0x004238A4 File Offset: 0x00421AA4
			// (set) Token: 0x0600FBF5 RID: 64501 RVA: 0x004238B4 File Offset: 0x00421AB4
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

			// Token: 0x1700300C RID: 12300
			// (get) Token: 0x0600FBF6 RID: 64502 RVA: 0x004238C4 File Offset: 0x00421AC4
			// (set) Token: 0x0600FBF7 RID: 64503 RVA: 0x004238D4 File Offset: 0x00421AD4
			public Hero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x1700300D RID: 12301
			// (get) Token: 0x0600FBF8 RID: 64504 RVA: 0x004238E4 File Offset: 0x00421AE4
			// (set) Token: 0x0600FBF9 RID: 64505 RVA: 0x004238F4 File Offset: 0x00421AF4
			public int m_slot
			{
				get
				{
					return this.m_owner.m_slot;
				}
				set
				{
					this.m_owner.m_slot = value;
				}
			}

			// Token: 0x1700300E RID: 12302
			// (get) Token: 0x0600FBFA RID: 64506 RVA: 0x00423904 File Offset: 0x00421B04
			// (set) Token: 0x0600FBFB RID: 64507 RVA: 0x00423914 File Offset: 0x00421B14
			public int m_state
			{
				get
				{
					return this.m_owner.m_state;
				}
				set
				{
					this.m_owner.m_state = value;
				}
			}

			// Token: 0x1700300F RID: 12303
			// (get) Token: 0x0600FBFC RID: 64508 RVA: 0x00423924 File Offset: 0x00421B24
			// (set) Token: 0x0600FBFD RID: 64509 RVA: 0x00423934 File Offset: 0x00421B34
			public ulong m_instanceId
			{
				get
				{
					return this.m_owner.m_instanceId;
				}
				set
				{
					this.m_owner.m_instanceId = value;
				}
			}

			// Token: 0x17003010 RID: 12304
			// (get) Token: 0x0600FBFE RID: 64510 RVA: 0x00423944 File Offset: 0x00421B44
			// (set) Token: 0x0600FBFF RID: 64511 RVA: 0x00423954 File Offset: 0x00421B54
			public bool m_isAlreadyEnter
			{
				get
				{
					return this.m_owner.m_isAlreadyEnter;
				}
				set
				{
					this.m_owner.m_isAlreadyEnter = value;
				}
			}

			// Token: 0x17003011 RID: 12305
			// (get) Token: 0x0600FC00 RID: 64512 RVA: 0x00423964 File Offset: 0x00421B64
			// (set) Token: 0x0600FC01 RID: 64513 RVA: 0x00423974 File Offset: 0x00421B74
			public EquipmentDepotUIController m_equipmentDepotUIController
			{
				get
				{
					return this.m_owner.m_equipmentDepotUIController;
				}
				set
				{
					this.m_owner.m_equipmentDepotUIController = value;
				}
			}

			// Token: 0x17003012 RID: 12306
			// (get) Token: 0x0600FC02 RID: 64514 RVA: 0x00423984 File Offset: 0x00421B84
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003013 RID: 12307
			// (get) Token: 0x0600FC03 RID: 64515 RVA: 0x00423994 File Offset: 0x00421B94
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600FC04 RID: 64516 RVA: 0x004239A4 File Offset: 0x00421BA4
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600FC05 RID: 64517 RVA: 0x004239B4 File Offset: 0x00421BB4
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600FC06 RID: 64518 RVA: 0x004239C4 File Offset: 0x00421BC4
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600FC07 RID: 64519 RVA: 0x004239D4 File Offset: 0x00421BD4
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600FC08 RID: 64520 RVA: 0x004239E4 File Offset: 0x00421BE4
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600FC09 RID: 64521 RVA: 0x004239F4 File Offset: 0x00421BF4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600FC0A RID: 64522 RVA: 0x00423A04 File Offset: 0x00421C04
			public void EquipmentDepotUIController_OnReturn()
			{
				this.m_owner.EquipmentDepotUIController_OnReturn();
			}

			// Token: 0x0600FC0B RID: 64523 RVA: 0x00423A14 File Offset: 0x00421C14
			public void EquipmentDepotUIController_OnEquipmentWear(int heroId, ulong instanceId, int slot)
			{
				this.m_owner.EquipmentDepotUIController_OnEquipmentWear(heroId, instanceId, slot);
			}

			// Token: 0x0600FC0C RID: 64524 RVA: 0x00423A24 File Offset: 0x00421C24
			public void EquipmentDepotUIController_OnEquipmentLockAndUnLock(ulong instanceId, int slot)
			{
				this.m_owner.EquipmentDepotUIController_OnEquipmentLockAndUnLock(instanceId, slot);
			}

			// Token: 0x0600FC0D RID: 64525 RVA: 0x00423A34 File Offset: 0x00421C34
			public void EquipmentDepotUIController_OnEquipmentTakeOff(int heroId, int slot, Action OnEnd)
			{
				this.m_owner.EquipmentDepotUIController_OnEquipmentTakeOff(heroId, slot, OnEnd);
			}

			// Token: 0x0600FC0E RID: 64526 RVA: 0x00423A44 File Offset: 0x00421C44
			public void EquipmentDepotUIController_OnGoldAddButtonClick()
			{
				this.m_owner.EquipmentDepotUIController_OnGoldAddButtonClick();
			}

			// Token: 0x040093B5 RID: 37813
			private EquipmentDepotUITask m_owner;
		}
	}
}
