using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectLBasic;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D71 RID: 3441
	[HotFix]
	public class EquipmentForgeUITask : UITask
	{
		// Token: 0x0600FF86 RID: 65414 RVA: 0x00430658 File Offset: 0x0042E858
		public EquipmentForgeUITask(string name) : base(name)
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

		// Token: 0x0600FF87 RID: 65415 RVA: 0x0043074C File Offset: 0x0042E94C
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
			if (this.m_equipmentForgeUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_equipmentForgeUIController = (this.m_uiCtrlArray[0] as EquipmentForgeUIController);
				}
				if (!(this.m_equipmentForgeUIController != null))
				{
					Debug.LogError("EquipmentForgeUITask is null");
					return;
				}
				this.m_equipmentForgeUIController.EventOnReturn += this.EquipmentForgeUIController_OnReturn;
				this.m_equipmentForgeUIController.EventOnShowHelp += this.EquipmentForgeUIController_OnShowHelp;
				this.m_equipmentForgeUIController.EventOnBreakButtonClick += this.EquipmentForgeUIController_OnEquipmentStarLevelUp;
				this.m_equipmentForgeUIController.EventOnEnhanceButtonClick += this.EquipmentForgeUIController_OnEquipmentEnhance;
				this.m_equipmentForgeUIController.EventOnGoldAddButtonClick += this.EquipmentForgeUIController_OnGoldAddButtonClick;
				this.m_equipmentForgeUIController.EventOnBreakNeedItemClick += this.EquipmentForgeUIController_OnEnhanceNeedItemClick;
				this.m_equipmentForgeUIController.EventOnEnchantButtonClick += this.EquipmentForgeUIController_OnEnchantButtonClick;
				this.m_equipmentForgeUIController.EventOnEnchantSaveButtonClick += this.EquipmentForgeUIController_OnEnchantSaveButtonClick;
				this.m_equipmentForgeUIController.EventOnCrystalNotEnough += this.EquipmentForgeUIController_OnCrystalNotEnough;
			}
		}

		// Token: 0x0600FF88 RID: 65416 RVA: 0x004308D4 File Offset: 0x0042EAD4
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
			if (this.m_equipmentForgeUIController != null)
			{
				this.m_equipmentForgeUIController.EventOnReturn -= this.EquipmentForgeUIController_OnReturn;
				this.m_equipmentForgeUIController.EventOnShowHelp -= this.EquipmentForgeUIController_OnShowHelp;
				this.m_equipmentForgeUIController.EventOnBreakButtonClick -= this.EquipmentForgeUIController_OnEquipmentStarLevelUp;
				this.m_equipmentForgeUIController.EventOnEnhanceButtonClick -= this.EquipmentForgeUIController_OnEquipmentEnhance;
				this.m_equipmentForgeUIController.EventOnGoldAddButtonClick -= this.EquipmentForgeUIController_OnGoldAddButtonClick;
				this.m_equipmentForgeUIController.EventOnBreakNeedItemClick -= this.EquipmentForgeUIController_OnEnhanceNeedItemClick;
				this.m_equipmentForgeUIController.EventOnEnchantButtonClick -= this.EquipmentForgeUIController_OnEnchantButtonClick;
				this.m_equipmentForgeUIController.EventOnEnchantSaveButtonClick -= this.EquipmentForgeUIController_OnEnchantSaveButtonClick;
				this.m_equipmentForgeUIController.EventOnCrystalNotEnough -= this.EquipmentForgeUIController_OnCrystalNotEnough;
				this.m_equipmentForgeUIController = null;
			}
		}

		// Token: 0x0600FF89 RID: 65417 RVA: 0x00430A24 File Offset: 0x0042EC24
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

		// Token: 0x0600FF8A RID: 65418 RVA: 0x00430AB0 File Offset: 0x0042ECB0
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

		// Token: 0x0600FF8B RID: 65419 RVA: 0x00430B3C File Offset: 0x0042ED3C
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
				uiintentCustom.TryGetParam("slot", out obj);
				uiintentCustom.TryGetParam("id", out obj2);
				object obj3;
				uiintentCustom.TryGetParam("state", out obj3);
				this.m_forgeState = (EquipmentForgeUIController.ForgeState)obj3;
				this.m_slot = (int)obj;
				this.m_instanceId = (ulong)obj2;
			}
		}

		// Token: 0x0600FF8C RID: 65420 RVA: 0x00430C20 File Offset: 0x0042EE20
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
			this.m_equipmentForgeUIController.UpdateEquipmentForgeView(this.m_forgeState, this.m_slot, this.m_instanceId);
		}

		// Token: 0x0600FF8D RID: 65421 RVA: 0x00430CA0 File Offset: 0x0042EEA0
		private void EquipmentForgeUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUIController_OnReturn_hotfix != null)
			{
				this.m_EquipmentForgeUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				base.ReturnPrevUITask();
				this.m_hero = null;
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600FF8E RID: 65422 RVA: 0x00430D24 File Offset: 0x0042EF24
		private void EquipmentForgeUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUIController_OnShowHelp_hotfix != null)
			{
				this.m_EquipmentForgeUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_EquipmentForge);
		}

		// Token: 0x0600FF8F RID: 65423 RVA: 0x00430D90 File Offset: 0x0042EF90
		private void EquipmentForgeUIController_OnEquipmentEnhance(ulong instanceId, List<ulong> materialIds, Action OnSucceed, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUIController_OnEquipmentEnhanceUInt64List`1ActionInt32_hotfix != null)
			{
				this.m_EquipmentForgeUIController_OnEquipmentEnhanceUInt64List`1ActionInt32_hotfix.call(new object[]
				{
					this,
					instanceId2,
					materialIds,
					OnSucceed2,
					slot2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int slot = slot2;
			ulong instanceId = instanceId2;
			Action OnSucceed = OnSucceed2;
			EquipmentForgeUITask $this = this;
			EquipmentEnhanceNetTask equipmentEnhanceNetTask = new EquipmentEnhanceNetTask(instanceId, materialIds);
			equipmentEnhanceNetTask.EventOnStop += delegate(Task task)
			{
				EquipmentEnhanceNetTask equipmentEnhanceNetTask2 = task as EquipmentEnhanceNetTask;
				if (equipmentEnhanceNetTask2.Result == 0)
				{
					$this.m_forgeState = EquipmentForgeUIController.ForgeState.Enhance;
					$this.m_slot = slot;
					$this.m_instanceId = instanceId;
					OnSucceed();
					$this.UpdateView();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(equipmentEnhanceNetTask2.Result, 2f, null, true);
				}
			};
			equipmentEnhanceNetTask.Start(null);
		}

		// Token: 0x0600FF90 RID: 65424 RVA: 0x00430E7C File Offset: 0x0042F07C
		private void EquipmentForgeUIController_OnEquipmentStarLevelUp(ulong instanceId, ulong materialId, Action OnSucceed, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUIController_OnEquipmentStarLevelUpUInt64UInt64ActionInt32_hotfix != null)
			{
				this.m_EquipmentForgeUIController_OnEquipmentStarLevelUpUInt64UInt64ActionInt32_hotfix.call(new object[]
				{
					this,
					instanceId2,
					materialId,
					OnSucceed2,
					slot2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int slot = slot2;
			ulong instanceId = instanceId2;
			Action OnSucceed = OnSucceed2;
			EquipmentForgeUITask $this = this;
			EquipmentStarLevelUpNetTask equipmentStarLevelUpNetTask = new EquipmentStarLevelUpNetTask(instanceId, materialId);
			equipmentStarLevelUpNetTask.EventOnStop += delegate(Task task)
			{
				EquipmentStarLevelUpNetTask equipmentStarLevelUpNetTask2 = task as EquipmentStarLevelUpNetTask;
				if (equipmentStarLevelUpNetTask2.Result == 0)
				{
					$this.m_forgeState = EquipmentForgeUIController.ForgeState.Break;
					$this.m_slot = slot;
					$this.m_instanceId = instanceId;
					$this.UpdateView();
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(equipmentStarLevelUpNetTask2.Result, 2f, null, true);
				}
			};
			equipmentStarLevelUpNetTask.Start(null);
		}

		// Token: 0x0600FF91 RID: 65425 RVA: 0x00430F68 File Offset: 0x0042F168
		private void EquipmentForgeUIController_OnGoldAddButtonClick(ulong instanceId, int slot, EquipmentForgeUIController.ForgeState forgeState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUIController_OnGoldAddButtonClickUInt64Int32ForgeState_hotfix != null)
			{
				this.m_EquipmentForgeUIController_OnGoldAddButtonClickUInt64Int32ForgeState_hotfix.call(new object[]
				{
					this,
					instanceId,
					slot,
					forgeState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_instanceId = instanceId;
			this.m_slot = slot;
			this.m_forgeState = forgeState;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Crystal, null, false);
		}

		// Token: 0x0600FF92 RID: 65426 RVA: 0x00431024 File Offset: 0x0042F224
		private void EquipmentForgeUIController_OnEnhanceNeedItemClick(GoodsType goodsType, int goodsId, int needCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUIController_OnEnhanceNeedItemClickGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_EquipmentForgeUIController_OnEnhanceNeedItemClickGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					goodsType,
					goodsId,
					needCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetPathUITask.StartUITask(goodsType, goodsId, new Action<GetPathData, NeedGoods>(this.EquipmentForge_OnGotoGetPath), needCount);
		}

		// Token: 0x0600FF93 RID: 65427 RVA: 0x004310CC File Offset: 0x0042F2CC
		private void EquipmentForge_OnGotoGetPath(GetPathData getPath, NeedGoods needGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForge_OnGotoGetPathGetPathDataNeedGoods_hotfix != null)
			{
				this.m_EquipmentForge_OnGotoGetPathGetPathDataNeedGoods_hotfix.call(new object[]
				{
					this,
					getPath,
					needGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			WorldUITask.StartGetPathTargetUITask(getPath, this.m_currIntent, needGoods);
		}

		// Token: 0x0600FF94 RID: 65428 RVA: 0x00431160 File Offset: 0x0042F360
		private void EquipmentForgeUIController_OnEnchantButtonClick(ulong instanceId, ulong stoneInstanceId, Action<int, List<CommonBattleProperty>> OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUIController_OnEnchantButtonClickUInt64UInt64Action`2_hotfix != null)
			{
				this.m_EquipmentForgeUIController_OnEnchantButtonClickUInt64UInt64Action`2_hotfix.call(new object[]
				{
					this,
					instanceId2,
					stoneInstanceId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ulong instanceId = instanceId2;
			Action<int, List<CommonBattleProperty>> OnSucceed = OnSucceed2;
			EquipmentForgeUITask $this = this;
			EquipmentEnchantNetTask equipmentEnchantNetTask = new EquipmentEnchantNetTask(instanceId, stoneInstanceId);
			equipmentEnchantNetTask.EventOnStop += delegate(Task task)
			{
				EquipmentEnchantNetTask equipmentEnchantNetTask2 = task as EquipmentEnchantNetTask;
				if (equipmentEnchantNetTask2.Result == 0)
				{
					$this.m_forgeState = EquipmentForgeUIController.ForgeState.Enchantment;
					$this.m_instanceId = instanceId;
					OnSucceed(equipmentEnchantNetTask2.NewResonanceId, equipmentEnchantNetTask2.Properties);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(equipmentEnchantNetTask2.Result, 2f, null, true);
				}
			};
			equipmentEnchantNetTask.Start(null);
		}

		// Token: 0x0600FF95 RID: 65429 RVA: 0x00431234 File Offset: 0x0042F434
		private void EquipmentForgeUIController_OnEnchantSaveButtonClick(Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUIController_OnEnchantSaveButtonClickAction_hotfix != null)
			{
				this.m_EquipmentForgeUIController_OnEnchantSaveButtonClickAction_hotfix.call(new object[]
				{
					this,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			EquipmentForgeUITask $this = this;
			EquipmentEnchantSaveNetTask equipmentEnchantSaveNetTask = new EquipmentEnchantSaveNetTask();
			equipmentEnchantSaveNetTask.EventOnStop += delegate(Task task)
			{
				EquipmentEnchantSaveNetTask equipmentEnchantSaveNetTask2 = task as EquipmentEnchantSaveNetTask;
				if (equipmentEnchantSaveNetTask2.Result == 0)
				{
					$this.StartUpdatePipeLine(null, false, false, true);
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(equipmentEnchantSaveNetTask2.Result, 2f, null, true);
				}
			};
			equipmentEnchantSaveNetTask.Start(null);
		}

		// Token: 0x0600FF96 RID: 65430 RVA: 0x004312D8 File Offset: 0x0042F4D8
		private void EquipmentForgeUIController_OnCrystalNotEnough()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUIController_OnCrystalNotEnough_hotfix != null)
			{
				this.m_EquipmentForgeUIController_OnCrystalNotEnough_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_CrystalNotEnough, delegate(DialogBoxResult dialogResult)
			{
				if (dialogResult == DialogBoxResult.Ok)
				{
					StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
				}
			}, (StringTableId)0, (StringTableId)0);
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x0600FF97 RID: 65431 RVA: 0x00431358 File Offset: 0x0042F558
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

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x0600FF98 RID: 65432 RVA: 0x004313CC File Offset: 0x0042F5CC
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

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x0600FF99 RID: 65433 RVA: 0x00431440 File Offset: 0x0042F640
		// (set) Token: 0x0600FF9A RID: 65434 RVA: 0x00431460 File Offset: 0x0042F660
		[DoNotToLua]
		public new EquipmentForgeUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EquipmentForgeUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600FF9B RID: 65435 RVA: 0x0043146C File Offset: 0x0042F66C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600FF9C RID: 65436 RVA: 0x00431478 File Offset: 0x0042F678
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600FF9D RID: 65437 RVA: 0x00431480 File Offset: 0x0042F680
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600FF9E RID: 65438 RVA: 0x00431488 File Offset: 0x0042F688
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600FF9F RID: 65439 RVA: 0x00431494 File Offset: 0x0042F694
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600FFA0 RID: 65440 RVA: 0x004314A0 File Offset: 0x0042F6A0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600FFA1 RID: 65441 RVA: 0x004314AC File Offset: 0x0042F6AC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600FFA2 RID: 65442 RVA: 0x004314B4 File Offset: 0x0042F6B4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600FFA3 RID: 65443 RVA: 0x004314BC File Offset: 0x0042F6BC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600FFA4 RID: 65444 RVA: 0x004314C4 File Offset: 0x0042F6C4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600FFA5 RID: 65445 RVA: 0x004314CC File Offset: 0x0042F6CC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600FFA6 RID: 65446 RVA: 0x004314D4 File Offset: 0x0042F6D4
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600FFA7 RID: 65447 RVA: 0x004314DC File Offset: 0x0042F6DC
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600FFA8 RID: 65448 RVA: 0x004314E4 File Offset: 0x0042F6E4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600FFA9 RID: 65449 RVA: 0x004314F0 File Offset: 0x0042F6F0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600FFAA RID: 65450 RVA: 0x004314FC File Offset: 0x0042F6FC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600FFAB RID: 65451 RVA: 0x00431508 File Offset: 0x0042F708
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600FFAC RID: 65452 RVA: 0x00431514 File Offset: 0x0042F714
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600FFAD RID: 65453 RVA: 0x0043151C File Offset: 0x0042F71C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600FFAE RID: 65454 RVA: 0x00431524 File Offset: 0x0042F724
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600FFAF RID: 65455 RVA: 0x0043152C File Offset: 0x0042F72C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600FFB0 RID: 65456 RVA: 0x00431534 File Offset: 0x0042F734
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600FFB1 RID: 65457 RVA: 0x0043153C File Offset: 0x0042F73C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600FFB4 RID: 65460 RVA: 0x00431590 File Offset: 0x0042F790
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
					this.m_EquipmentForgeUIController_OnReturn_hotfix = (luaObj.RawGet("EquipmentForgeUIController_OnReturn") as LuaFunction);
					this.m_EquipmentForgeUIController_OnShowHelp_hotfix = (luaObj.RawGet("EquipmentForgeUIController_OnShowHelp") as LuaFunction);
					this.m_EquipmentForgeUIController_OnEquipmentEnhanceUInt64List`1ActionInt32_hotfix = (luaObj.RawGet("EquipmentForgeUIController_OnEquipmentEnhance") as LuaFunction);
					this.m_EquipmentForgeUIController_OnEquipmentStarLevelUpUInt64UInt64ActionInt32_hotfix = (luaObj.RawGet("EquipmentForgeUIController_OnEquipmentStarLevelUp") as LuaFunction);
					this.m_EquipmentForgeUIController_OnGoldAddButtonClickUInt64Int32ForgeState_hotfix = (luaObj.RawGet("EquipmentForgeUIController_OnGoldAddButtonClick") as LuaFunction);
					this.m_EquipmentForgeUIController_OnEnhanceNeedItemClickGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("EquipmentForgeUIController_OnEnhanceNeedItemClick") as LuaFunction);
					this.m_EquipmentForge_OnGotoGetPathGetPathDataNeedGoods_hotfix = (luaObj.RawGet("EquipmentForge_OnGotoGetPath") as LuaFunction);
					this.m_EquipmentForgeUIController_OnEnchantButtonClickUInt64UInt64Action`2_hotfix = (luaObj.RawGet("EquipmentForgeUIController_OnEnchantButtonClick") as LuaFunction);
					this.m_EquipmentForgeUIController_OnEnchantSaveButtonClickAction_hotfix = (luaObj.RawGet("EquipmentForgeUIController_OnEnchantSaveButtonClick") as LuaFunction);
					this.m_EquipmentForgeUIController_OnCrystalNotEnough_hotfix = (luaObj.RawGet("EquipmentForgeUIController_OnCrystalNotEnough") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600FFB5 RID: 65461 RVA: 0x00431820 File Offset: 0x0042FA20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentForgeUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009571 RID: 38257
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "EquipmentForgeUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/EquipmentForgeUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04009572 RID: 38258
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "EquipmentForgeUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.EquipmentForgeUIController"),
				m_ctrlName = "EquipmentForgeUIController"
			}
		};

		// Token: 0x04009573 RID: 38259
		private Hero m_hero;

		// Token: 0x04009574 RID: 38260
		private int m_slot;

		// Token: 0x04009575 RID: 38261
		private ulong m_instanceId;

		// Token: 0x04009576 RID: 38262
		private EquipmentForgeUIController.ForgeState m_forgeState;

		// Token: 0x04009577 RID: 38263
		private EquipmentForgeUIController m_equipmentForgeUIController;

		// Token: 0x04009578 RID: 38264
		[DoNotToLua]
		private EquipmentForgeUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009579 RID: 38265
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400957A RID: 38266
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400957B RID: 38267
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400957C RID: 38268
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400957D RID: 38269
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400957E RID: 38270
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400957F RID: 38271
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04009580 RID: 38272
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04009581 RID: 38273
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009582 RID: 38274
		private LuaFunction m_EquipmentForgeUIController_OnReturn_hotfix;

		// Token: 0x04009583 RID: 38275
		private LuaFunction m_EquipmentForgeUIController_OnShowHelp_hotfix;

		// Token: 0x04009584 RID: 38276
		private LuaFunction m_EquipmentForgeUIController_OnEquipmentEnhanceUInt64List;

		// Token: 0x04009585 RID: 38277
		private LuaFunction m_EquipmentForgeUIController_OnEquipmentStarLevelUpUInt64UInt64ActionInt32_hotfix;

		// Token: 0x04009586 RID: 38278
		private LuaFunction m_EquipmentForgeUIController_OnGoldAddButtonClickUInt64Int32ForgeState_hotfix;

		// Token: 0x04009587 RID: 38279
		private LuaFunction m_EquipmentForgeUIController_OnEnhanceNeedItemClickGoodsTypeInt32Int32_hotfix;

		// Token: 0x04009588 RID: 38280
		private LuaFunction m_EquipmentForge_OnGotoGetPathGetPathDataNeedGoods_hotfix;

		// Token: 0x04009589 RID: 38281
		private LuaFunction m_EquipmentForgeUIController_OnEnchantButtonClickUInt64UInt64Action;

		// Token: 0x0400958A RID: 38282
		private LuaFunction m_EquipmentForgeUIController_OnEnchantSaveButtonClickAction_hotfix;

		// Token: 0x0400958B RID: 38283
		private LuaFunction m_EquipmentForgeUIController_OnCrystalNotEnough_hotfix;

		// Token: 0x0400958C RID: 38284
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400958D RID: 38285
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000D72 RID: 3442
		public new class LuaExportHelper
		{
			// Token: 0x0600FFB6 RID: 65462 RVA: 0x00431888 File Offset: 0x0042FA88
			public LuaExportHelper(EquipmentForgeUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600FFB7 RID: 65463 RVA: 0x00431898 File Offset: 0x0042FA98
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600FFB8 RID: 65464 RVA: 0x004318A8 File Offset: 0x0042FAA8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600FFB9 RID: 65465 RVA: 0x004318B8 File Offset: 0x0042FAB8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600FFBA RID: 65466 RVA: 0x004318C8 File Offset: 0x0042FAC8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600FFBB RID: 65467 RVA: 0x004318D8 File Offset: 0x0042FAD8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600FFBC RID: 65468 RVA: 0x004318E8 File Offset: 0x0042FAE8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600FFBD RID: 65469 RVA: 0x004318F8 File Offset: 0x0042FAF8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600FFBE RID: 65470 RVA: 0x00431908 File Offset: 0x0042FB08
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600FFBF RID: 65471 RVA: 0x00431918 File Offset: 0x0042FB18
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600FFC0 RID: 65472 RVA: 0x00431928 File Offset: 0x0042FB28
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600FFC1 RID: 65473 RVA: 0x00431938 File Offset: 0x0042FB38
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600FFC2 RID: 65474 RVA: 0x00431948 File Offset: 0x0042FB48
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600FFC3 RID: 65475 RVA: 0x00431958 File Offset: 0x0042FB58
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600FFC4 RID: 65476 RVA: 0x00431968 File Offset: 0x0042FB68
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600FFC5 RID: 65477 RVA: 0x00431978 File Offset: 0x0042FB78
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600FFC6 RID: 65478 RVA: 0x00431988 File Offset: 0x0042FB88
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600FFC7 RID: 65479 RVA: 0x00431998 File Offset: 0x0042FB98
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600FFC8 RID: 65480 RVA: 0x004319A8 File Offset: 0x0042FBA8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600FFC9 RID: 65481 RVA: 0x004319B8 File Offset: 0x0042FBB8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600FFCA RID: 65482 RVA: 0x004319C8 File Offset: 0x0042FBC8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600FFCB RID: 65483 RVA: 0x004319D8 File Offset: 0x0042FBD8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600FFCC RID: 65484 RVA: 0x004319E8 File Offset: 0x0042FBE8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600FFCD RID: 65485 RVA: 0x004319F8 File Offset: 0x0042FBF8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003127 RID: 12583
			// (get) Token: 0x0600FFCE RID: 65486 RVA: 0x00431A08 File Offset: 0x0042FC08
			// (set) Token: 0x0600FFCF RID: 65487 RVA: 0x00431A18 File Offset: 0x0042FC18
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

			// Token: 0x17003128 RID: 12584
			// (get) Token: 0x0600FFD0 RID: 65488 RVA: 0x00431A28 File Offset: 0x0042FC28
			// (set) Token: 0x0600FFD1 RID: 65489 RVA: 0x00431A38 File Offset: 0x0042FC38
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

			// Token: 0x17003129 RID: 12585
			// (get) Token: 0x0600FFD2 RID: 65490 RVA: 0x00431A48 File Offset: 0x0042FC48
			// (set) Token: 0x0600FFD3 RID: 65491 RVA: 0x00431A58 File Offset: 0x0042FC58
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

			// Token: 0x1700312A RID: 12586
			// (get) Token: 0x0600FFD4 RID: 65492 RVA: 0x00431A68 File Offset: 0x0042FC68
			// (set) Token: 0x0600FFD5 RID: 65493 RVA: 0x00431A78 File Offset: 0x0042FC78
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

			// Token: 0x1700312B RID: 12587
			// (get) Token: 0x0600FFD6 RID: 65494 RVA: 0x00431A88 File Offset: 0x0042FC88
			// (set) Token: 0x0600FFD7 RID: 65495 RVA: 0x00431A98 File Offset: 0x0042FC98
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

			// Token: 0x1700312C RID: 12588
			// (get) Token: 0x0600FFD8 RID: 65496 RVA: 0x00431AA8 File Offset: 0x0042FCA8
			// (set) Token: 0x0600FFD9 RID: 65497 RVA: 0x00431AB8 File Offset: 0x0042FCB8
			public EquipmentForgeUIController.ForgeState m_forgeState
			{
				get
				{
					return this.m_owner.m_forgeState;
				}
				set
				{
					this.m_owner.m_forgeState = value;
				}
			}

			// Token: 0x1700312D RID: 12589
			// (get) Token: 0x0600FFDA RID: 65498 RVA: 0x00431AC8 File Offset: 0x0042FCC8
			// (set) Token: 0x0600FFDB RID: 65499 RVA: 0x00431AD8 File Offset: 0x0042FCD8
			public EquipmentForgeUIController m_equipmentForgeUIController
			{
				get
				{
					return this.m_owner.m_equipmentForgeUIController;
				}
				set
				{
					this.m_owner.m_equipmentForgeUIController = value;
				}
			}

			// Token: 0x1700312E RID: 12590
			// (get) Token: 0x0600FFDC RID: 65500 RVA: 0x00431AE8 File Offset: 0x0042FCE8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x1700312F RID: 12591
			// (get) Token: 0x0600FFDD RID: 65501 RVA: 0x00431AF8 File Offset: 0x0042FCF8
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600FFDE RID: 65502 RVA: 0x00431B08 File Offset: 0x0042FD08
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600FFDF RID: 65503 RVA: 0x00431B18 File Offset: 0x0042FD18
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600FFE0 RID: 65504 RVA: 0x00431B28 File Offset: 0x0042FD28
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600FFE1 RID: 65505 RVA: 0x00431B38 File Offset: 0x0042FD38
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600FFE2 RID: 65506 RVA: 0x00431B48 File Offset: 0x0042FD48
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600FFE3 RID: 65507 RVA: 0x00431B58 File Offset: 0x0042FD58
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600FFE4 RID: 65508 RVA: 0x00431B68 File Offset: 0x0042FD68
			public void EquipmentForgeUIController_OnReturn()
			{
				this.m_owner.EquipmentForgeUIController_OnReturn();
			}

			// Token: 0x0600FFE5 RID: 65509 RVA: 0x00431B78 File Offset: 0x0042FD78
			public void EquipmentForgeUIController_OnShowHelp()
			{
				this.m_owner.EquipmentForgeUIController_OnShowHelp();
			}

			// Token: 0x0600FFE6 RID: 65510 RVA: 0x00431B88 File Offset: 0x0042FD88
			public void EquipmentForgeUIController_OnEquipmentEnhance(ulong instanceId, List<ulong> materialIds, Action OnSucceed, int slot)
			{
				this.m_owner.EquipmentForgeUIController_OnEquipmentEnhance(instanceId, materialIds, OnSucceed, slot);
			}

			// Token: 0x0600FFE7 RID: 65511 RVA: 0x00431B9C File Offset: 0x0042FD9C
			public void EquipmentForgeUIController_OnEquipmentStarLevelUp(ulong instanceId, ulong materialId, Action OnSucceed, int slot)
			{
				this.m_owner.EquipmentForgeUIController_OnEquipmentStarLevelUp(instanceId, materialId, OnSucceed, slot);
			}

			// Token: 0x0600FFE8 RID: 65512 RVA: 0x00431BB0 File Offset: 0x0042FDB0
			public void EquipmentForgeUIController_OnGoldAddButtonClick(ulong instanceId, int slot, EquipmentForgeUIController.ForgeState forgeState)
			{
				this.m_owner.EquipmentForgeUIController_OnGoldAddButtonClick(instanceId, slot, forgeState);
			}

			// Token: 0x0600FFE9 RID: 65513 RVA: 0x00431BC0 File Offset: 0x0042FDC0
			public void EquipmentForgeUIController_OnEnhanceNeedItemClick(GoodsType goodsType, int goodsId, int needCount)
			{
				this.m_owner.EquipmentForgeUIController_OnEnhanceNeedItemClick(goodsType, goodsId, needCount);
			}

			// Token: 0x0600FFEA RID: 65514 RVA: 0x00431BD0 File Offset: 0x0042FDD0
			public void EquipmentForge_OnGotoGetPath(GetPathData getPath, NeedGoods needGoods)
			{
				this.m_owner.EquipmentForge_OnGotoGetPath(getPath, needGoods);
			}

			// Token: 0x0600FFEB RID: 65515 RVA: 0x00431BE0 File Offset: 0x0042FDE0
			public void EquipmentForgeUIController_OnEnchantButtonClick(ulong instanceId, ulong stoneInstanceId, Action<int, List<CommonBattleProperty>> OnSucceed)
			{
				this.m_owner.EquipmentForgeUIController_OnEnchantButtonClick(instanceId, stoneInstanceId, OnSucceed);
			}

			// Token: 0x0600FFEC RID: 65516 RVA: 0x00431BF0 File Offset: 0x0042FDF0
			public void EquipmentForgeUIController_OnEnchantSaveButtonClick(Action OnSucceed)
			{
				this.m_owner.EquipmentForgeUIController_OnEnchantSaveButtonClick(OnSucceed);
			}

			// Token: 0x0600FFED RID: 65517 RVA: 0x00431C00 File Offset: 0x0042FE00
			public void EquipmentForgeUIController_OnCrystalNotEnough()
			{
				this.m_owner.EquipmentForgeUIController_OnCrystalNotEnough();
			}

			// Token: 0x0400958E RID: 38286
			private EquipmentForgeUITask m_owner;
		}
	}
}
