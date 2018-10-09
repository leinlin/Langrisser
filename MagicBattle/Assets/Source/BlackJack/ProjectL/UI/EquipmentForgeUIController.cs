using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D5E RID: 3422
	[HotFix]
	public class EquipmentForgeUIController : UIControllerBase
	{
		// Token: 0x0600FC16 RID: 64534 RVA: 0x00423C0C File Offset: 0x00421E0C
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_helpButton.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_enhanceButton.onClick.AddListener(new UnityAction(this.OnEnhanceButtonClick));
			this.m_breakButton.onClick.AddListener(new UnityAction(this.OnBreakButtonClick));
			this.m_enchantmentButton.onClick.AddListener(new UnityAction(this.OnEnchantmentButtonClick));
			this.m_breakSuccessPanelBlackButton.onClick.AddListener(new UnityAction(this.OnBreakSuccessPanelContinueButtonClick));
			this.m_enhanceCancelButton.onClick.AddListener(new UnityAction(this.OnEnhanceCancelButtonClick));
			this.m_enhanceConfirmButton.onClick.AddListener(new UnityAction(this.OnEnhanceConfirmButtonClick));
			this.m_goldAddButton.onClick.AddListener(new UnityAction(this.OnGoldAddButtonClick));
			this.m_enhanceItemSRConfirmButton.onClick.AddListener(new UnityAction(this.OnEnhanceItemSRConfirmButtonClick));
			this.m_enhanceItemSRCancelButton.onClick.AddListener(new UnityAction(this.OnEnhanceItemSRCancelButtonClick));
			this.m_enhanceFastAddButton.onClick.AddListener(new UnityAction(this.OnEnhanceFastAddButtonClick));
			this.m_enhanceToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnEnhanceToggleValueChanged));
			this.m_breakToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnBreakToggleValueChanged));
			this.m_enchantmentToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnEnchantmentToggleValueChanged));
			this.m_enchantLockMaskButton.onClick.AddListener(new UnityAction(this.OnEnchantLockMaskButtonClick));
			this.m_filterSortButton.onClick.AddListener(new UnityAction(this.OnFilterSortButtonClick));
			this.m_filterSortOrderButton.onClick.AddListener(new UnityAction(this.OnFilterSortOrderButtonClick));
			this.m_enchantmentfilterSortButton.onClick.AddListener(new UnityAction(this.OnEnchantmentFilterSortButtonClick));
			this.m_enchantmentResultPanelCloseButton.onClick.AddListener(new UnityAction(this.OnCloseEnchantResultPanelButtonClick));
			this.m_enchantmentResultPanelEnchantmentAgainButton.onClick.AddListener(new UnityAction(this.OnEnchantmentAgainButtonClick));
			this.m_enchantmentResultPanelSavePropretyButton.onClick.AddListener(new UnityAction(this.OnEnchantmentResultSaveButtonClick));
			this.m_enchantmentResultPanelContinueButton.onClick.AddListener(new UnityAction(this.OnEnchantmentResultPanelContinueButtonClick));
			this.m_enhanceSuccessEffectPanelCloseButton.onClick.AddListener(new UnityAction(this.StopEnhanceSucceedEffect));
			this.m_intensifySuccessPanelBlackButton.onClick.AddListener(new UnityAction(this.OnIntensifySuccessPanelBlackButtonClick));
			this.m_savePropretyPanelCancelButton.onClick.AddListener(new UnityAction(this.CloseSavePanel));
			this.m_savePropretyPanelComfirmButton.onClick.AddListener(new UnityAction(this.OnSavePanlConfirmClick));
			this.m_cancelPanelCancelButton.onClick.AddListener(new UnityAction(this.CloseCancelPanel));
			this.m_cancelPanelComfirmButton.onClick.AddListener(new UnityAction(this.OnCancelPanlConfirmClick));
			this.m_savePropretyPanelToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSavePropertyToggleValueChanged));
			this.m_cancelPanelToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnCancelPanelToggleValueChanged));
			this.InitSortTypePanel();
			this.InitLoopScrollRect();
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600FC17 RID: 64535 RVA: 0x00424018 File Offset: 0x00422218
		private void InitSortTypePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSortTypePanel_hotfix != null)
			{
				this.m_InitSortTypePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_filterSortTypesGo.gameObject.GetComponent<PointDescComponent>() == null)
			{
				PointDescComponent pointDescComponent = this.m_filterSortTypesGo.gameObject.AddComponent<PointDescComponent>();
				pointDescComponent.SetGameObject(this.m_filterSortTypesGo, false, null, null);
				pointDescComponent.EventOnClose += this.OnCloseFilterSortTypeGo;
			}
			for (int i = 0; i < this.m_filterSortTypesGridLayout.transform.childCount; i++)
			{
				GameObject gameObject = this.m_filterSortTypesGridLayout.transform.GetChild(i).gameObject;
				EquipmentSortItemUIController equipmentSortItemUIController = GameObjectUtility.AddControllerToGameObject<EquipmentSortItemUIController>(gameObject);
				equipmentSortItemUIController.InitEquipmentFilterItem(i);
				equipmentSortItemUIController.EventOnClick += this.OnFilterTypeButtonClick;
			}
			if (this.m_enchantmentfilterSortTypesGo.gameObject.GetComponent<PointDescComponent>() == null)
			{
				PointDescComponent pointDescComponent2 = this.m_enchantmentfilterSortTypesGo.gameObject.AddComponent<PointDescComponent>();
				pointDescComponent2.SetGameObject(this.m_enchantmentfilterSortTypesGo, false, null, null);
				pointDescComponent2.EventOnClose += this.OnCloseEnchantmentFilterSortTypeGo;
			}
			for (int j = 0; j < this.m_enchantmentfilterSortTypesGridLayout.transform.childCount; j++)
			{
				GameObject gameObject2 = this.m_enchantmentfilterSortTypesGridLayout.transform.GetChild(j).gameObject;
				EquipmentSortItemUIController equipmentSortItemUIController2 = GameObjectUtility.AddControllerToGameObject<EquipmentSortItemUIController>(gameObject2);
				equipmentSortItemUIController2.InitEquipmentFilterItem(j + 1);
				equipmentSortItemUIController2.EventOnClick += this.OnEnchantmentFilterTypeButtonClick;
			}
			EquipmentSortItemUIController equipmentSortItemUIController3 = GameObjectUtility.AddControllerToGameObject<EquipmentSortItemUIController>(this.m_enchantmentfilterSortTypesAllToggle);
			equipmentSortItemUIController3.InitEquipmentFilterItem(0);
			equipmentSortItemUIController3.EventOnClick += this.OnEnchantmentFilterTypeButtonClick;
		}

		// Token: 0x0600FC18 RID: 64536 RVA: 0x004241FC File Offset: 0x004223FC
		private void InitLoopScrollRect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLoopScrollRect_hotfix != null)
			{
				this.m_InitLoopScrollRect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("EquipmentDepotListItem");
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
			gameObject.transform.SetParent(this.m_listScrollViewItemRoot.transform, false);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			PoolInfo poolInfoByName = this.m_listItemPool.GetPoolInfoByName("EquipmentDepotListItem");
			poolInfoByName.prefab = gameObject;
			this.m_listItemPool.CreatePools();
			Stack<PoolObject> objectPoolByName = this.m_listItemPool.GetObjectPoolByName("EquipmentDepotListItem");
			foreach (PoolObject poolObject in objectPoolByName)
			{
				EquipmentDepotListItemUIController component = poolObject.gameObject.GetComponent<EquipmentDepotListItemUIController>();
				component.Init();
				component.RegisterItemClickEvent(new Action<UIControllerBase>(this.OnEquipmentListItemClick));
				component.RegisterItemNeedFillEvent(new Action<UIControllerBase>(this.OnEquipmentListItemNeedFill));
				component.RegisterItem3DTouchEvent(new Action<UIControllerBase>(this.OnEquipmentListItem3DTouch));
			}
			this.m_equipmentItemCache.Clear();
			this.m_enchantStoneItemCache.Clear();
			this.m_loopScrollView.m_functionGetItemIndex = delegate(string itemName)
			{
				for (int i = 0; i < this.m_equipmentItemCache.Count; i++)
				{
					if (this.m_equipmentItemCache[i].ListItemName == itemName)
					{
						return i;
					}
				}
				return -1;
			};
		}

		// Token: 0x0600FC19 RID: 64537 RVA: 0x00424384 File Offset: 0x00422584
		public void UpdateEquipmentForgeView(EquipmentForgeUIController.ForgeState forgeState, int slot, ulong equipmentId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateEquipmentForgeViewForgeStateInt32UInt64_hotfix != null)
			{
				this.m_UpdateEquipmentForgeViewForgeStateInt32UInt64_hotfix.call(new object[]
				{
					this,
					forgeState,
					slot,
					equipmentId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_slot = slot;
			this.m_curEquipmentInstanceId = equipmentId;
			this.m_curForgeState = forgeState;
			switch (this.m_curForgeState)
			{
			case EquipmentForgeUIController.ForgeState.Enhance:
				this.m_enhanceToggle.isOn = true;
				this.m_curBreakMaterialEquipmentId = 0UL;
				this.m_curSelectEnchantStoneItem = null;
				this.CreateEquipmentList();
				this.UpdateViewInEnhanceState();
				break;
			case EquipmentForgeUIController.ForgeState.Break:
				this.m_breakToggle.isOn = true;
				this.m_enhanceEquipmentInstanceIds.Clear();
				this.m_curSelectEnchantStoneItem = null;
				this.CreateEquipmentList();
				this.UpdateViewInBreakState();
				break;
			case EquipmentForgeUIController.ForgeState.Enchantment:
				this.m_enchantmentToggle.isOn = true;
				this.m_curBreakMaterialEquipmentId = 0UL;
				this.m_enhanceEquipmentInstanceIds.Clear();
				this.CreateEquipmentList();
				this.UpdateViewInEnchantmentState();
				break;
			}
			this.m_enhanceAndBreakFilter.SetActive(this.m_curForgeState != EquipmentForgeUIController.ForgeState.Enchantment);
			this.m_enchantmentFilter.SetActive(this.m_curForgeState == EquipmentForgeUIController.ForgeState.Enchantment);
			this.m_listLongPressTipGo.SetActive(this.m_curForgeState == EquipmentForgeUIController.ForgeState.Enhance);
			if (this.m_curForgeState != EquipmentForgeUIController.ForgeState.Enchantment)
			{
				this.m_listTitleStateCtrl.SetToUIState("Equip", false, true);
			}
			else
			{
				this.m_listTitleStateCtrl.SetToUIState("Enchantment", false, true);
			}
			bool flag = this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Enchant);
			this.m_enchantLockMaskButton.gameObject.SetActive(!flag);
			Canvas.ForceUpdateCanvases();
			this.SetPlayerResourceGold();
		}

		// Token: 0x0600FC1A RID: 64538 RVA: 0x00424578 File Offset: 0x00422778
		private void CreateEquipmentList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateEquipmentList_hotfix != null)
			{
				this.m_CreateEquipmentList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curForgeState == EquipmentForgeUIController.ForgeState.Enchantment)
			{
				List<EnchantStoneBagItem> list = new List<EnchantStoneBagItem>();
				foreach (BagItemBase bagItemBase in this.m_playerContext.GetBagItems())
				{
					if (bagItemBase.GoodsTypeId == GoodsType.GoodsType_EnchantStone)
					{
						EnchantStoneBagItem enchantStoneBagItem = (EnchantStoneBagItem)bagItemBase;
						if (enchantStoneBagItem.EnchantStoneInfo.Resonance_ID != 0)
						{
							if (this.m_curEnchantmentSortTypeId == 0 || enchantStoneBagItem.EnchantStoneInfo.Resonance_ID == this.m_curEnchantmentSortTypeId)
							{
								list.Add(enchantStoneBagItem);
							}
						}
					}
				}
				list.Sort((EnchantStoneBagItem a, EnchantStoneBagItem b) => b.EnchantStoneInfo.Rank - a.EnchantStoneInfo.Rank);
				this.m_enchantStoneItemCache.Clear();
				this.m_enchantStoneItemCache.AddRange(list);
				this.m_listNoEnchantmentItemGo.SetActive(this.m_enchantStoneItemCache.Count == 0);
				this.m_listNoBreakItemGo.SetActive(false);
			}
			else
			{
				List<EquipmentBagItem> list2 = new List<EquipmentBagItem>();
				List<EquipmentBagItem> list3 = new List<EquipmentBagItem>();
				foreach (BagItemBase bagItemBase2 in this.m_playerContext.GetBagItems())
				{
					if (bagItemBase2.EquipmentInfo != null)
					{
						EquipmentBagItem equipmentBagItem = (EquipmentBagItem)bagItemBase2;
						EquipmentForgeUIController.ForgeState curForgeState = this.m_curForgeState;
						if (curForgeState != EquipmentForgeUIController.ForgeState.Enhance)
						{
							if (curForgeState == EquipmentForgeUIController.ForgeState.Break)
							{
								EquipmentBagItem equipmentBagItem2 = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
								if ((equipmentBagItem.InstanceId != this.m_curEquipmentInstanceId && equipmentBagItem.EquipmentInfo.EquipmentType != EquipmentType.EquipmentType_Enhancement && !equipmentBagItem.Locked && equipmentBagItem.ContentId == equipmentBagItem2.ContentId && !this.m_playerContext.IsEquipmentWeared(equipmentBagItem.InstanceId)) || (equipmentBagItem.EquipmentInfo.Rank == equipmentBagItem2.EquipmentInfo.Rank && equipmentBagItem.EquipmentInfo.EquipmentType == EquipmentType.EquipmentType_LevelUpStar))
								{
									if (equipmentBagItem.EquipmentInfo.EquipmentType == EquipmentType.EquipmentType_LevelUpStar)
									{
										list2.Add((EquipmentBagItem)bagItemBase2);
									}
									else
									{
										list3.Add((EquipmentBagItem)bagItemBase2);
									}
								}
							}
						}
						else if ((equipmentBagItem.InstanceId != this.m_curEquipmentInstanceId && equipmentBagItem.EquipmentInfo.EquipmentType != EquipmentType.EquipmentType_LevelUpStar && !equipmentBagItem.IsEquipmentEnhanced() && !equipmentBagItem.IsEquipmentLevelUped(equipmentBagItem.EquipmentInfo.BornStarLevel) && !equipmentBagItem.Locked && !this.m_playerContext.IsEquipmentWeared(equipmentBagItem.InstanceId)) || equipmentBagItem.EquipmentInfo.EquipmentType == EquipmentType.EquipmentType_Enhancement)
						{
							if (equipmentBagItem.EquipmentInfo.EquipmentType == EquipmentType.EquipmentType_Enhancement)
							{
								list2.Add((EquipmentBagItem)bagItemBase2);
							}
							else
							{
								list3.Add((EquipmentBagItem)bagItemBase2);
							}
						}
					}
				}
				this.SortEquipmentListByType(list2);
				this.SortEquipmentListByType(list3);
				this.m_equipmentItemCache.Clear();
				this.m_equipmentItemCache.AddRange(list2);
				this.m_equipmentItemCache.AddRange(list3);
				this.m_listNoBreakItemGo.SetActive(this.m_equipmentItemCache.Count == 0);
				this.m_listNoEnchantmentItemGo.SetActive(false);
			}
			int num = 0;
			GameObject firstGameObjectInViewRect = this.m_loopScrollView.GetFirstGameObjectInViewRect();
			if (firstGameObjectInViewRect != null && !this.m_isToggleChanged)
			{
				num = firstGameObjectInViewRect.GetComponent<ScrollItemBaseUIController>().ItemIndex;
				if (this.m_curForgeState == EquipmentForgeUIController.ForgeState.Enchantment && num >= this.m_enchantStoneItemCache.Count)
				{
					num = 0;
				}
			}
			this.m_loopScrollView.totalCount = ((this.m_curForgeState != EquipmentForgeUIController.ForgeState.Enchantment) ? this.m_equipmentItemCache.Count : this.m_enchantStoneItemCache.Count);
			this.m_loopScrollView.RefillCells(num);
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = this.m_equipmentForgeCtrlList.Find((EquipmentDepotListItemUIController a) => a.EquipmentInstanceId == this.m_curEquipmentInstanceId);
			if (equipmentDepotListItemUIController != null)
			{
				equipmentDepotListItemUIController.ShowSelectFrame(true);
			}
			if (this.m_descGo.activeSelf)
			{
				EquipmentBagItem equipmentItemDesc = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
				this.SetEquipmentItemDesc(equipmentItemDesc);
			}
		}

		// Token: 0x0600FC1B RID: 64539 RVA: 0x00424A70 File Offset: 0x00422C70
		private void SortEquipmentListByType(List<EquipmentBagItem> list)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortEquipmentListByTypeList`1_hotfix != null)
			{
				this.m_SortEquipmentListByTypeList`1_hotfix.call(new object[]
				{
					this,
					list
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			list.Sort(new Comparison<EquipmentBagItem>(this.DefaultEquipmentItemComparer));
			switch (this.m_curEquipmentSortType)
			{
			case EquipmentDepotUIController.EquipmentSortTypeState.Lv:
				list.Sort(delegate(EquipmentBagItem a, EquipmentBagItem b)
				{
					int num;
					if (a.Level - b.Level == 0)
					{
						num = this.DefaultEquipmentItemComparer(a, b);
					}
					else
					{
						num = a.Level - b.Level;
					}
					return num * this.m_isAscend;
				});
				break;
			case EquipmentDepotUIController.EquipmentSortTypeState.StarLv:
				list.Sort(delegate(EquipmentBagItem a, EquipmentBagItem b)
				{
					int num;
					if (a.StarLevel - b.StarLevel == 0)
					{
						num = this.DefaultEquipmentItemComparer(a, b);
					}
					else
					{
						num = a.StarLevel - b.StarLevel;
					}
					return num * this.m_isAscend;
				});
				break;
			case EquipmentDepotUIController.EquipmentSortTypeState.Rank:
				list.Sort(delegate(EquipmentBagItem a, EquipmentBagItem b)
				{
					int num;
					if (a.EquipmentInfo.Rank - b.EquipmentInfo.Rank == 0)
					{
						num = this.DefaultEquipmentItemComparer(a, b);
					}
					else
					{
						num = a.EquipmentInfo.Rank - b.EquipmentInfo.Rank;
					}
					return num * this.m_isAscend;
				});
				break;
			case EquipmentDepotUIController.EquipmentSortTypeState.Hp:
				this.CollectEquipmentPropValueAndSort(list, PropertyModifyType.PropertyModifyType_Hero1_HPAdd);
				break;
			case EquipmentDepotUIController.EquipmentSortTypeState.AT:
				this.CollectEquipmentPropValueAndSort(list, PropertyModifyType.PropertyModifyType_Hero1_ATAdd);
				break;
			case EquipmentDepotUIController.EquipmentSortTypeState.DF:
				this.CollectEquipmentPropValueAndSort(list, PropertyModifyType.PropertyModifyType_Hero1_DFAdd);
				break;
			case EquipmentDepotUIController.EquipmentSortTypeState.MagicAT:
				this.CollectEquipmentPropValueAndSort(list, PropertyModifyType.PropertyModifyType_Hero1_MagicAdd);
				break;
			case EquipmentDepotUIController.EquipmentSortTypeState.MagicDF:
				this.CollectEquipmentPropValueAndSort(list, PropertyModifyType.PropertyModifyType_Hero1_MagicDFAdd);
				break;
			case EquipmentDepotUIController.EquipmentSortTypeState.Dex:
				this.CollectEquipmentPropValueAndSort(list, PropertyModifyType.PropertyModifyType_Hero1_DEXAdd);
				break;
			}
		}

		// Token: 0x0600FC1C RID: 64540 RVA: 0x00424BC0 File Offset: 0x00422DC0
		private int DefaultEquipmentItemComparer(EquipmentBagItem e1, EquipmentBagItem e2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DefaultEquipmentItemComparerEquipmentBagItemEquipmentBagItem_hotfix != null)
			{
				return Convert.ToInt32(this.m_DefaultEquipmentItemComparerEquipmentBagItemEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					e1,
					e2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (e1.EquipmentInfo.Rank == e2.EquipmentInfo.Rank)
			{
				return e1.ContentId - e2.ContentId;
			}
			return e1.EquipmentInfo.Rank - e2.EquipmentInfo.Rank;
		}

		// Token: 0x0600FC1D RID: 64541 RVA: 0x00424C8C File Offset: 0x00422E8C
		private void CollectEquipmentPropValueAndSort(List<EquipmentBagItem> list, PropertyModifyType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectEquipmentPropValueAndSortList`1PropertyModifyType_hotfix != null)
			{
				this.m_CollectEquipmentPropValueAndSortList`1PropertyModifyType_hotfix.call(new object[]
				{
					this,
					list,
					type
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Dictionary<ulong, int> dictIDToPropValue = new Dictionary<ulong, int>();
			foreach (EquipmentBagItem equipmentBagItem in list)
			{
				if (equipmentBagItem.EquipmentInfo.Property1_ID == type)
				{
					dictIDToPropValue[equipmentBagItem.InstanceId] = equipmentBagItem.EquipmentInfo.Property1_Value + equipmentBagItem.Level * equipmentBagItem.EquipmentInfo.Property1_LevelUpValue / 10;
				}
				else if (equipmentBagItem.EquipmentInfo.Property2_ID == type)
				{
					dictIDToPropValue[equipmentBagItem.InstanceId] = equipmentBagItem.EquipmentInfo.Property2_Value + equipmentBagItem.Level * equipmentBagItem.EquipmentInfo.Property2_LevelUpValue / 10;
				}
				else
				{
					dictIDToPropValue[equipmentBagItem.InstanceId] = 0;
				}
			}
			list.Sort(delegate(EquipmentBagItem a, EquipmentBagItem b)
			{
				int num;
				if (dictIDToPropValue[a.InstanceId] - dictIDToPropValue[b.InstanceId] == 0)
				{
					num = this.DefaultEquipmentItemComparer(a, b);
				}
				else
				{
					num = dictIDToPropValue[a.InstanceId] - dictIDToPropValue[b.InstanceId];
				}
				return num * this.m_isAscend;
			});
		}

		// Token: 0x0600FC1E RID: 64542 RVA: 0x00424E1C File Offset: 0x0042301C
		private void OnEquipmentListItemClick(UIControllerBase itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentListItemClickUIControllerBase_hotfix != null)
			{
				this.m_OnEquipmentListItemClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = itemCtrl as EquipmentDepotListItemUIController;
			if (equipmentDepotListItemUIController == null)
			{
				return;
			}
			if (equipmentDepotListItemUIController.BagItem.EquipmentInfo != null)
			{
				this.m_slot = (int)equipmentDepotListItemUIController.BagItem.EquipmentInfo.EquipmentType;
			}
			switch (this.m_curForgeState)
			{
			case EquipmentForgeUIController.ForgeState.Enhance:
				this.OnEquipmentItemClickInEnhance(equipmentDepotListItemUIController);
				break;
			case EquipmentForgeUIController.ForgeState.Break:
				this.OnEquipmentItemClickInBreak(equipmentDepotListItemUIController);
				break;
			case EquipmentForgeUIController.ForgeState.Enchantment:
				this.OnEquipmentItemClickInEnchantment(equipmentDepotListItemUIController);
				break;
			}
		}

		// Token: 0x0600FC1F RID: 64543 RVA: 0x00424F10 File Offset: 0x00423110
		private void OnEquipmentItemClickInEnhance(EquipmentDepotListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentItemClickInEnhanceEquipmentDepotListItemUIController_hotfix != null)
			{
				this.m_OnEquipmentItemClickInEnhanceEquipmentDepotListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isAfter3DTouch)
			{
				this.m_isAfter3DTouch = false;
				return;
			}
			if (this.m_descGo.activeSelf)
			{
				return;
			}
			ulong instanceId = ctrl.BagItem.InstanceId;
			if (this.m_enhanceEquipmentInstanceIds.Contains(instanceId))
			{
				this.m_enhanceEquipmentInstanceIds.Remove(instanceId);
				ctrl.ShowCheckImage(false);
			}
			else
			{
				this.m_enhanceEquipmentInstanceIds.Add(instanceId);
				if (this.m_enhanceEquipmentInstanceIds.Count <= 5)
				{
					EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
					int levelLimit = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentBagItem.StarLevel).LevelLimit;
					int enhanceExp = this.m_playerContext.CalculateEnhanceEquipmentExp(this.m_enhanceEquipmentInstanceIds);
					int num = this.CalculateEquipmentEnhanceAddLvByExp(equipmentBagItem, enhanceExp, equipmentBagItem.Level);
					if (equipmentBagItem.Level + num > levelLimit)
					{
						this.m_enhanceEquipmentInstanceIds.Remove(instanceId);
						if (equipmentBagItem.Level == levelLimit && equipmentBagItem.Exp >= this.m_configDataLoader.GetConfigDataEquipmentLevelInfo(equipmentBagItem.Level).RankEquipmentNextExps[equipmentBagItem.EquipmentInfo.Rank - 1])
						{
							CommonUIController.Instance.ShowErrorMessage(-514, 2f, null, true);
							return;
						}
						this.m_curAddEnhanceEquipmentInstanceId = instanceId;
						this.ShowEnhanceItemsConfirmPanel();
						return;
					}
					else
					{
						ctrl.ShowCheckImage(true);
					}
				}
				else
				{
					this.m_enhanceEquipmentInstanceIds.Remove(instanceId);
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_CantAddMoreEnhanceItem, 2f, null, true);
				}
			}
			this.UpdateViewInEnhanceState();
		}

		// Token: 0x0600FC20 RID: 64544 RVA: 0x004250FC File Offset: 0x004232FC
		private void OnEquipmentItemClickInBreak(EquipmentDepotListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentItemClickInBreakEquipmentDepotListItemUIController_hotfix != null)
			{
				this.m_OnEquipmentItemClickInBreakEquipmentDepotListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = this.m_equipmentForgeCtrlList.Find((EquipmentDepotListItemUIController a) => a.EquipmentInstanceId == this.m_curBreakMaterialEquipmentId);
			if (equipmentDepotListItemUIController != null)
			{
				equipmentDepotListItemUIController.ShowSelectFrame(false);
			}
			this.m_curBreakMaterialEquipmentId = ctrl.BagItem.InstanceId;
			ctrl.ShowSelectFrame(true);
			this.UpdateViewInBreakState();
		}

		// Token: 0x0600FC21 RID: 64545 RVA: 0x004251B8 File Offset: 0x004233B8
		private void OnEquipmentItemClickInEnchantment(EquipmentDepotListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentItemClickInEnchantmentEquipmentDepotListItemUIController_hotfix != null)
			{
				this.m_OnEquipmentItemClickInEnchantmentEquipmentDepotListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = null;
			if (this.m_curSelectEnchantStoneItem != null)
			{
				equipmentDepotListItemUIController = this.m_equipmentForgeCtrlList.Find((EquipmentDepotListItemUIController c) => c.BagItem == this.m_curSelectEnchantStoneItem);
				if (equipmentDepotListItemUIController != null)
				{
					equipmentDepotListItemUIController.ShowSelectFrame(false);
				}
			}
			if (equipmentDepotListItemUIController != null && equipmentDepotListItemUIController.BagItem == ctrl.BagItem)
			{
				this.m_curSelectEnchantStoneItem = null;
			}
			else
			{
				this.m_curSelectEnchantStoneItem = ctrl.BagItem;
				ctrl.ShowSelectFrame(true);
				if (ctrl.BagItem.EnchantStoneInfo != null)
				{
					this.m_lastSelectEnchantStoneInfo = ctrl.BagItem.EnchantStoneInfo;
				}
			}
			this.UpdateViewInEnchantmentState();
		}

		// Token: 0x0600FC22 RID: 64546 RVA: 0x004252C4 File Offset: 0x004234C4
		private void OnEquipmentListItemNeedFill(UIControllerBase itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentListItemNeedFillUIControllerBase_hotfix != null)
			{
				this.m_OnEquipmentListItemNeedFillUIControllerBase_hotfix.call(new object[]
				{
					this,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentDepotListItemUIController goCtrl = itemCtrl as EquipmentDepotListItemUIController;
			if (goCtrl == null)
			{
				return;
			}
			int itemIndex = goCtrl.ScrollItemBaseUICtrl.ItemIndex;
			if (this.m_curForgeState != EquipmentForgeUIController.ForgeState.Enchantment)
			{
				if (itemIndex < this.m_equipmentItemCache.Count)
				{
					goCtrl.InitEquipmentDepotListItemInfo(this.m_equipmentItemCache[itemIndex], true);
					goCtrl.ShowCheckImage(this.m_enhanceEquipmentInstanceIds.Contains(goCtrl.BagItem.InstanceId));
					goCtrl.ShowSelectFrame(false);
					if (!this.m_equipmentForgeCtrlList.Contains(goCtrl))
					{
						this.m_equipmentForgeCtrlList.Add(goCtrl);
					}
					Animator component = goCtrl.gameObject.GetComponent<Animator>();
					component.Play("Normal");
				}
				LongPressComponent component2 = goCtrl.gameObject.GetComponent<LongPressComponent>();
				if (this.m_curForgeState == EquipmentForgeUIController.ForgeState.Enhance)
				{
					if (component2 == null)
					{
						CommonUIStateController descStateCtrl = this.m_descGo.GetComponent<CommonUIStateController>();
						goCtrl.gameObject.AddComponent<LongPressComponent>().SetBasicParam(0.3f, 0f, delegate
						{
							if (this.m_isAfter3DTouch)
							{
								return;
							}
							this.SetEquipmentItemDesc((EquipmentBagItem)goCtrl.BagItem);
							this.m_descGo.SetActive(true);
							descStateCtrl.SetToUIState("Show", false, true);
						}, null, delegate
						{
							if (this.m_isAfter3DTouch && !this.m_descGo.activeSelf)
							{
								return;
							}
							if (UIUtility.GetUIStateCurrentStateName(descStateCtrl) == "Show")
							{
								descStateCtrl.SetActionForUIStateFinshed("Close", delegate
								{
									this.m_descGo.SetActive(false);
								});
								descStateCtrl.SetToUIState("Close", false, true);
							}
						}, false);
					}
				}
				else if (component2 != null)
				{
					UnityEngine.Object.Destroy(component2);
				}
			}
			else
			{
				if (itemIndex < this.m_enchantStoneItemCache.Count)
				{
					goCtrl.InitEquipmentDepotListItemInfo(this.m_enchantStoneItemCache[itemIndex], true);
					goCtrl.ShowSelectFrame(false);
					if (!this.m_equipmentForgeCtrlList.Contains(goCtrl))
					{
						this.m_equipmentForgeCtrlList.Add(goCtrl);
					}
					Animator component3 = goCtrl.gameObject.GetComponent<Animator>();
					component3.Play("Normal");
				}
				LongPressComponent component4 = goCtrl.gameObject.GetComponent<LongPressComponent>();
				if (component4 != null)
				{
					UnityEngine.Object.Destroy(component4);
				}
			}
		}

		// Token: 0x0600FC23 RID: 64547 RVA: 0x0042555C File Offset: 0x0042375C
		private void OnEquipmentListItem3DTouch(UIControllerBase itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentListItem3DTouchUIControllerBase_hotfix != null)
			{
				this.m_OnEquipmentListItem3DTouchUIControllerBase_hotfix.call(new object[]
				{
					this,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = itemCtrl as EquipmentDepotListItemUIController;
			if (equipmentDepotListItemUIController == null)
			{
				return;
			}
			int itemIndex = equipmentDepotListItemUIController.ScrollItemBaseUICtrl.ItemIndex;
			if (this.m_curForgeState == EquipmentForgeUIController.ForgeState.Enhance)
			{
				this.m_isAfter3DTouch = true;
				List<ulong> list = new List<ulong>();
				List<ulong> instanceBagItemInstanceIdsByContentId = this.m_playerContext.GetInstanceBagItemInstanceIdsByContentId(equipmentDepotListItemUIController.BagItem.ContentId);
				foreach (ulong num in instanceBagItemInstanceIdsByContentId)
				{
					EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(num) as EquipmentBagItem;
					if ((equipmentBagItem.InstanceId != this.m_curEquipmentInstanceId && equipmentBagItem.EquipmentInfo.EquipmentType != EquipmentType.EquipmentType_LevelUpStar && !equipmentBagItem.IsEquipmentEnhanced() && !equipmentBagItem.IsEquipmentLevelUped(equipmentBagItem.EquipmentInfo.BornStarLevel) && !equipmentBagItem.Locked && !this.m_playerContext.IsEquipmentWeared(equipmentBagItem.InstanceId)) || equipmentBagItem.EquipmentInfo.EquipmentType == EquipmentType.EquipmentType_Enhancement)
					{
						list.Add(num);
					}
				}
				ulong instanceId = equipmentDepotListItemUIController.BagItem.InstanceId;
				list.Remove(instanceId);
				list.Insert(0, instanceId);
				if (this.m_enhanceEquipmentInstanceIds.Contains(instanceId))
				{
					List<ulong> list2 = new List<ulong>(this.m_enhanceEquipmentInstanceIds);
					using (List<ulong>.Enumerator enumerator2 = list2.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ulong id = enumerator2.Current;
							if (list.Contains(id))
							{
								this.m_enhanceEquipmentInstanceIds.Remove(id);
								EquipmentDepotListItemUIController equipmentDepotListItemUIController2 = this.m_equipmentForgeCtrlList.Find((EquipmentDepotListItemUIController c) => c.BagItem.InstanceId == id);
								if (equipmentDepotListItemUIController2 != null)
								{
									equipmentDepotListItemUIController2.ShowCheckImage(false);
								}
							}
						}
					}
					this.UpdateViewInEnhanceState();
				}
				else
				{
					int count = this.m_enhanceEquipmentInstanceIds.Count;
					using (List<ulong>.Enumerator enumerator3 = list.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							ulong id = enumerator3.Current;
							if (!this.m_enhanceEquipmentInstanceIds.Contains(id))
							{
								this.m_enhanceEquipmentInstanceIds.Add(id);
								if (this.m_enhanceEquipmentInstanceIds.Count <= 5)
								{
									EquipmentBagItem equipmentBagItem2 = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
									int levelLimit = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentBagItem2.StarLevel).LevelLimit;
									int enhanceExp = this.m_playerContext.CalculateEnhanceEquipmentExp(this.m_enhanceEquipmentInstanceIds);
									int num2 = this.CalculateEquipmentEnhanceAddLvByExp(equipmentBagItem2, enhanceExp, equipmentBagItem2.Level);
									if (equipmentBagItem2.Level + num2 > levelLimit)
									{
										this.m_enhanceEquipmentInstanceIds.Remove(id);
										if (equipmentBagItem2.Level == levelLimit && equipmentBagItem2.Exp >= this.m_configDataLoader.GetConfigDataEquipmentLevelInfo(equipmentBagItem2.Level).RankEquipmentNextExps[equipmentBagItem2.EquipmentInfo.Rank - 1])
										{
											CommonUIController.Instance.ShowErrorMessage(-514, 2f, null, true);
											break;
										}
										this.m_curAddEnhanceEquipmentInstanceId = id;
										this.ShowEnhanceItemsConfirmPanel();
										break;
									}
									else
									{
										EquipmentDepotListItemUIController equipmentDepotListItemUIController3 = this.m_equipmentForgeCtrlList.Find((EquipmentDepotListItemUIController c) => c.BagItem.InstanceId == id);
										if (equipmentDepotListItemUIController3 != null)
										{
											equipmentDepotListItemUIController3.ShowCheckImage(true);
										}
									}
								}
								else
								{
									this.m_enhanceEquipmentInstanceIds.Remove(id);
									if (count == this.m_enhanceEquipmentInstanceIds.Count)
									{
										CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_CantAddMoreEnhanceItem, 2f, null, true);
									}
								}
								this.UpdateViewInEnhanceState();
								if (this.m_enhanceEquipmentInstanceIds.Count >= 5)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600FC24 RID: 64548 RVA: 0x00425A20 File Offset: 0x00423C20
		private void OnFilterSortButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFilterSortButtonClick_hotfix != null)
			{
				this.m_OnFilterSortButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_filterSortTypesGo.SetActive(true);
			CommonUIStateController component = this.m_filterSortTypesGo.GetComponent<CommonUIStateController>();
			if (component != null)
			{
				component.SetToUIState("Show", false, true);
			}
		}

		// Token: 0x0600FC25 RID: 64549 RVA: 0x00425AB4 File Offset: 0x00423CB4
		private void OnEnchantmentFilterSortButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantmentFilterSortButtonClick_hotfix != null)
			{
				this.m_OnEnchantmentFilterSortButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enchantmentfilterSortTypesGo.SetActive(true);
			CommonUIStateController component = this.m_enchantmentfilterSortTypesGo.GetComponent<CommonUIStateController>();
			if (component != null)
			{
				component.SetToUIState("Show", false, true);
			}
		}

		// Token: 0x0600FC26 RID: 64550 RVA: 0x00425B48 File Offset: 0x00423D48
		private void OnCloseFilterSortTypeGo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseFilterSortTypeGo_hotfix != null)
			{
				this.m_OnCloseFilterSortTypeGo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_filterSortTypesGo.SetActive(false);
		}

		// Token: 0x0600FC27 RID: 64551 RVA: 0x00425BB4 File Offset: 0x00423DB4
		private void OnCloseEnchantmentFilterSortTypeGo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseEnchantmentFilterSortTypeGo_hotfix != null)
			{
				this.m_OnCloseEnchantmentFilterSortTypeGo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enchantmentfilterSortTypesGo.SetActive(false);
		}

		// Token: 0x0600FC28 RID: 64552 RVA: 0x00425C20 File Offset: 0x00423E20
		private void OnFilterSortOrderButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFilterSortOrderButtonClick_hotfix != null)
			{
				this.m_OnFilterSortOrderButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isAscend = -this.m_isAscend;
			CommonUIStateController component = this.m_filterSortOrderButton.GetComponent<CommonUIStateController>();
			if (this.m_isAscend > 0)
			{
				component.SetToUIState("Up", false, true);
			}
			else
			{
				component.SetToUIState("Down", false, true);
			}
			this.CreateEquipmentList();
		}

		// Token: 0x0600FC29 RID: 64553 RVA: 0x00425CCC File Offset: 0x00423ECC
		private void OnFilterTypeButtonClick(EquipmentSortItemUIController ctrl, bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFilterTypeButtonClickEquipmentSortItemUIControllerBoolean_hotfix != null)
			{
				this.m_OnFilterTypeButtonClickEquipmentSortItemUIControllerBoolean_hotfix.call(new object[]
				{
					this,
					ctrl,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_filterSortTypeText.text = ctrl.FilterText;
				this.m_curEquipmentSortType = (EquipmentDepotUIController.EquipmentSortTypeState)ctrl.m_sortTypeInt;
				this.OnCloseFilterSortTypeGo();
				this.CreateEquipmentList();
			}
		}

		// Token: 0x0600FC2A RID: 64554 RVA: 0x00425D7C File Offset: 0x00423F7C
		private void OnEnchantmentFilterTypeButtonClick(EquipmentSortItemUIController ctrl, bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantmentFilterTypeButtonClickEquipmentSortItemUIControllerBoolean_hotfix != null)
			{
				this.m_OnEnchantmentFilterTypeButtonClickEquipmentSortItemUIControllerBoolean_hotfix.call(new object[]
				{
					this,
					ctrl,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_enchantmentfilterSortTypeText.text = ctrl.FilterText;
				this.m_curEnchantmentSortTypeId = ctrl.m_sortTypeInt;
				this.m_curSelectEnchantStoneItem = null;
				this.OnCloseEnchantmentFilterSortTypeGo();
				this.CreateEquipmentList();
				this.UpdateViewInEnchantmentState();
			}
		}

		// Token: 0x0600FC2B RID: 64555 RVA: 0x00425E38 File Offset: 0x00424038
		private void SetEquipmentItemDesc(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentItemDescEquipmentBagItem_hotfix != null)
			{
				this.m_SetEquipmentItemDescEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_descTitleText.text = equipment.EquipmentInfo.Name;
			this.m_descLvText.text = "Lv. " + equipment.Level;
			this.m_descIcon.sprite = AssetUtility.Instance.GetSprite(equipment.EquipmentInfo.Icon);
			this.m_descIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(equipment.EquipmentInfo.Rank));
			this.m_descSSREffect.SetActive(UIUtility.IsRankSSR(equipment.EquipmentInfo.Rank));
			int num = this.m_playerContext.CaculateEquipmentNextLevelExp(equipment);
			this.m_descExpText.text = (num - equipment.Exp).ToString();
			this.m_descProgressImage.fillAmount = (float)equipment.Exp / (float)num;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_descStarGroup, equipment.StarLevel);
			CommonUIStateController component = this.m_descEquipLimitContent.GetComponent<CommonUIStateController>();
			if (equipment.EquipmentInfo.EquipCoditionDesc != string.Empty)
			{
				component.SetToUIState("Unlimit", false, true);
				this.m_descEquipUnlimitText.text = equipment.EquipmentInfo.EquipCoditionDesc;
			}
			else
			{
				List<int> armyIds = equipment.EquipmentInfo.ArmyIds;
				if (armyIds.Count == 0)
				{
					this.m_descEquipUnlimitText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AllJobCanUse);
					component.SetToUIState("Unlimit", false, true);
				}
				else if (armyIds[0] == -1)
				{
					component.SetToUIState("CanNotUse", false, true);
				}
				else
				{
					component.SetToUIState("EquipLimit", false, true);
					for (int i = 0; i < this.m_descEquipLimitContent.transform.childCount; i++)
					{
						Transform child = this.m_descEquipLimitContent.transform.GetChild(i);
						child.gameObject.SetActive(false);
					}
					for (int j = 0; j < armyIds.Count; j++)
					{
						ConfigDataArmyInfo configDataArmyInfo = this.m_configDataLoader.GetConfigDataArmyInfo(armyIds[j]);
						if (j < this.m_descEquipLimitContent.transform.childCount)
						{
							Transform child2 = this.m_descEquipLimitContent.transform.GetChild(j);
							child2.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
							child2.gameObject.SetActive(true);
						}
						else
						{
							GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_descEquipLimitContent.transform.GetChild(0).gameObject, this.m_descEquipLimitContent.transform, true);
							gameObject.transform.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
							gameObject.SetActive(true);
						}
					}
				}
			}
			for (int k = 0; k < this.m_descPropContent.transform.childCount; k++)
			{
				Transform child3 = this.m_descPropContent.transform.GetChild(k);
				child3.gameObject.SetActive(false);
			}
			this.SetPropItems(equipment.EquipmentInfo.Property1_ID, equipment.EquipmentInfo.Property1_Value, equipment.EquipmentInfo.Property1_LevelUpValue, equipment.Level);
			this.SetPropItems(equipment.EquipmentInfo.Property2_ID, equipment.EquipmentInfo.Property2_Value, equipment.EquipmentInfo.Property2_LevelUpValue, equipment.Level);
			if (equipment.IsEnchant())
			{
				int equipmentResonanceNums = this.m_playerContext.GetEquipmentResonanceNums(equipment.InstanceId);
				if (equipmentResonanceNums < 2)
				{
					this.m_descPropEnchantmentGroupRuneStateCtrl.SetToUIState("1", false, true);
				}
				else
				{
					this.m_descPropEnchantmentGroupRuneStateCtrl.SetToUIState("2", false, true);
				}
				ConfigDataResonanceInfo configDataResonanceInfo = this.m_configDataLoader.GetConfigDataResonanceInfo(equipment.ResonanceId);
				this.m_descPropEnchantmentGroupRuneIconImage.sprite = AssetUtility.Instance.GetSprite(configDataResonanceInfo.SmallIcon);
				this.m_descPropEnchantmentGroupRuneNameText.text = string.Concat(new object[]
				{
					configDataResonanceInfo.Name,
					"(",
					equipmentResonanceNums,
					"/4)"
				});
				this.m_descPropGroupStateCtrl.SetToUIState("Resonance", false, true);
				List<CommonBattleProperty> enchantProperties = equipment.EnchantProperties;
				UIUtility.SetGameObjectChildrenActiveCount(this.m_descPropEnchantmentGroup, enchantProperties.Count);
				if (enchantProperties.Count != 0)
				{
					Transform transform = this.m_descPropEnchantmentGroup.transform;
					for (int l = 0; l < enchantProperties.Count; l++)
					{
						ConfigDataPropertyModifyInfo configDataPropertyModifyInfo = this.m_configDataLoader.GetConfigDataPropertyModifyInfo((int)enchantProperties[l].Id);
						GameObject gameObject2;
						if (l < transform.childCount)
						{
							gameObject2 = transform.GetChild(l).gameObject;
						}
						else
						{
							gameObject2 = UnityEngine.Object.Instantiate<GameObject>(transform.GetChild(0).gameObject);
							gameObject2.transform.SetParent(transform, false);
						}
						for (int m = 0; m < gameObject2.transform.childCount; m++)
						{
							Transform child4 = gameObject2.transform.GetChild(m);
							if (child4.name == "NameText")
							{
								child4.GetComponent<Text>().text = configDataPropertyModifyInfo.Name;
							}
							else if (child4.name == "ValueText")
							{
								if (configDataPropertyModifyInfo.IsAddType)
								{
									child4.GetComponent<Text>().text = enchantProperties[l].Value.ToString();
								}
								else
								{
									child4.GetComponent<Text>().text = enchantProperties[l].Value / 100 + "%";
								}
							}
						}
					}
				}
			}
			else
			{
				this.m_descPropGroupStateCtrl.SetToUIState("Unresonance", false, true);
			}
			this.m_descSkillContent.SetActive(equipment.EquipmentInfo.SkillIds.Count != 0);
			this.m_descNotEquipSkillTip.SetActive(equipment.EquipmentInfo.SkillIds.Count == 0);
			if (equipment.EquipmentInfo.SkillIds.Count != 0)
			{
				string text = null;
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(UIUtility.GetSkillIdFromEquipment(equipment.EquipmentInfo, equipment.Level, ref text));
				if (configDataSkillInfo != null)
				{
					if (text == null)
					{
						this.m_descSkillContentStateCtrl.SetToUIState("Grey", false, true);
						this.m_descUnlockCoditionText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_EnchantToLevel), equipment.EquipmentInfo.SkillLevels[0]);
					}
					else
					{
						this.m_descSkillContentStateCtrl.SetToUIState("Normal", false, true);
						this.m_descSkillLvText.text = "Lv." + text;
					}
					this.m_descSkillNameText.text = configDataSkillInfo.Name;
					ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(equipment.EquipmentInfo.SkillHero);
					this.m_descSkillOwnerText.gameObject.SetActive(configDataHeroInfo != null);
					this.m_descSkillOwnerBGImage.SetActive(configDataHeroInfo != null);
					if (configDataHeroInfo != null)
					{
						this.m_descSkillOwnerText.text = configDataHeroInfo.Name + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Equipment_SkillOwner);
					}
					this.m_descSkillDescText.text = configDataSkillInfo.Desc;
				}
			}
		}

		// Token: 0x0600FC2C RID: 64556 RVA: 0x00426620 File Offset: 0x00424820
		private void SetPropItemColor(Text oldText, Text newText)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPropItemColorTextText_hotfix != null)
			{
				this.m_SetPropItemColorTextText_hotfix.call(new object[]
				{
					this,
					oldText,
					newText
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = int.Parse(oldText.text);
			int num2 = int.Parse(newText.text);
			if (num == num2)
			{
				newText.gameObject.SetActive(false);
			}
			else
			{
				newText.gameObject.SetActive(true);
				if (num2 > num)
				{
					newText.color = UIUtility.MyGreenColor;
				}
				else
				{
					newText.color = Color.red;
				}
			}
		}

		// Token: 0x0600FC2D RID: 64557 RVA: 0x00426700 File Offset: 0x00424900
		private void SetPropItems(PropertyModifyType type, int value, int addValue, int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix != null)
			{
				this.m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					type,
					value,
					addValue,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			value += (int)Math.Round((double)((float)(addValue * (level - 1)) / 10f));
			string text = "+" + value;
			switch (type)
			{
			case PropertyModifyType.PropertyModifyType_Hero1_HPAdd:
				this.m_descPropHPGo.SetActive(true);
				this.m_descPropHPValueText.text = text;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_ATAdd:
				this.m_descPropATGo.SetActive(true);
				this.m_descPropATValueText.text = text;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DFAdd:
				this.m_descPropDFGo.SetActive(true);
				this.m_descPropDFValueText.text = text;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicAdd:
				this.m_descPropMagiccGo.SetActive(true);
				this.m_descPropMagicValueText.text = text;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicDFAdd:
				this.m_descPropMagicDFGo.SetActive(true);
				this.m_descPropMagicDFValueText.text = text;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DEXAdd:
				this.m_descPropDexGo.SetActive(true);
				this.m_descPropDexValueText.text = text;
				break;
			}
		}

		// Token: 0x0600FC2E RID: 64558 RVA: 0x0042689C File Offset: 0x00424A9C
		private void UpdateViewInEnhanceState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInEnhanceState_hotfix != null)
			{
				this.m_UpdateViewInEnhanceState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curEquipmentInstanceId == 0UL)
			{
				return;
			}
			EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
			if (equipmentBagItem == null)
			{
				if (this.EventOnReturn != null)
				{
					this.EventOnReturn();
				}
				return;
			}
			this.m_enhanceTitleText.text = equipmentBagItem.EquipmentInfo.Name;
			this.m_enhanceIcon.sprite = AssetUtility.Instance.GetSprite(equipmentBagItem.EquipmentInfo.Icon);
			int rank = equipmentBagItem.EquipmentInfo.Rank;
			this.m_enhanceIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(rank));
			this.m_enhanceIconSSREffect.SetActive(UIUtility.IsRankSSR(rank));
			UIUtility.ReverseShowGameObjectChildrenByActive(this.m_enhanceStarGroup, equipmentBagItem.StarLevel);
			this.m_enhanceCurLv.text = equipmentBagItem.Level.ToString();
			int levelLimit = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentBagItem.StarLevel).LevelLimit;
			this.m_enhanceMaxLV.text = levelLimit.ToString();
			int num = this.m_playerContext.CaculateEquipmentNextLevelExp(equipmentBagItem);
			this.m_enhanceProgressImage.fillAmount = (float)equipmentBagItem.Exp / (float)num;
			this.m_enhanceExpCurValueText.text = equipmentBagItem.Exp.ToString();
			this.m_enhanceExpNextLvText.text = num.ToString();
			int num2 = this.m_playerContext.CalculateEnhanceEquipmentExp(this.m_enhanceEquipmentInstanceIds);
			int num3 = this.m_playerContext.CalculateEnhanceEquipmentGold(num2);
			this.m_enhanceGoldText.text = num3.ToString();
			if (num3 <= this.m_playerContext.GetGold())
			{
				this.m_enhanceGoldText.color = Color.white;
			}
			else
			{
				this.m_enhanceGoldText.color = Color.red;
			}
			this.m_enhanceWillGetExpImage.fillAmount = (float)(equipmentBagItem.Exp + num2) / (float)num;
			this.m_enhanceWillGetExpImage.gameObject.SetActive(num2 > 0);
			int num4 = this.CalculateEquipmentEnhanceAddLvByExp(equipmentBagItem, num2, equipmentBagItem.Level);
			if (equipmentBagItem.Level + num4 <= levelLimit)
			{
				this.m_enhanceCurLv1.text = (equipmentBagItem.Level + num4).ToString();
			}
			else
			{
				this.m_enhanceCurLv1.text = levelLimit.ToString();
				num4 = levelLimit - equipmentBagItem.Level;
			}
			this.m_enhanceCurLv.gameObject.SetActive(num4 == 0);
			this.m_enhanceCurLv1.gameObject.SetActive(num4 != 0);
			this.m_enhanceExpCurValueText.gameObject.SetActive(num2 == 0);
			this.m_enhanceExpAddValueText.gameObject.SetActive(num2 > 0);
			this.m_enhanceExpAddValueText.text = (equipmentBagItem.Exp + num2).ToString();
			UIUtility.SetGameObjectChildrenActiveCount(this.m_enhancePropGroupGo, 0);
			this.ResetEnhancePropItemActive();
			this.SetEnhancePropItems(equipmentBagItem.EquipmentInfo.Property1_ID, equipmentBagItem.EquipmentInfo.Property1_Value, equipmentBagItem.EquipmentInfo.Property1_LevelUpValue, equipmentBagItem.Level, num4);
			this.SetEnhancePropItems(equipmentBagItem.EquipmentInfo.Property2_ID, equipmentBagItem.EquipmentInfo.Property2_Value, equipmentBagItem.EquipmentInfo.Property2_LevelUpValue, equipmentBagItem.Level, num4);
			if (equipmentBagItem.EquipmentInfo.SkillIds.Count == 0)
			{
				this.m_enhancePropSkillStateCtrl.SetToUIState("NoSkill", false, true);
			}
			else
			{
				string text = null;
				string text2 = null;
				int skillIdFromEquipment = UIUtility.GetSkillIdFromEquipment(equipmentBagItem.EquipmentInfo, equipmentBagItem.Level, ref text2);
				UIUtility.GetSkillIdFromEquipment(equipmentBagItem.EquipmentInfo, equipmentBagItem.Level + num4, ref text);
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(skillIdFromEquipment);
				if (text2 == null)
				{
					text2 = "0";
				}
				if (text == null)
				{
					text = "0";
				}
				if (text2 != text)
				{
					this.m_enhancePropSkillStateCtrl.SetToUIState("Normal", false, true);
					this.m_enhancePropSkillNameText.text = configDataSkillInfo.Name;
					this.m_enhancePropSkillOldValueText.text = "Lv." + text2;
					this.m_enhancePropSkillNewValueText.text = "Lv." + text;
				}
				else if (text2 == "Max")
				{
					this.m_enhancePropSkillStateCtrl.SetToUIState("MaxLv", false, true);
					this.m_enhancePropSkillNameText.text = configDataSkillInfo.Name;
					this.m_enhancePropSkillNewValueText.text = "Lv." + text;
				}
				else
				{
					this.m_enhancePropSkillStateCtrl.SetToUIState("Condition", false, true);
					int index = int.Parse(text);
					int num5 = equipmentBagItem.EquipmentInfo.SkillLevels[index];
					this.m_enhancePropSkillConditionText.text = num5.ToString();
				}
			}
			for (int i = 0; i < this.m_enhanceMaterialsContent.transform.childCount; i++)
			{
				Transform child = this.m_enhanceMaterialsContent.transform.GetChild(i);
				if (i < this.m_enhanceEquipmentInstanceIds.Count)
				{
					ConfigDataEquipmentInfo equipmentInfo = this.m_playerContext.GetBagItemByInstanceId(this.m_enhanceEquipmentInstanceIds[i]).EquipmentInfo;
					child.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(equipmentInfo.Rank));
					child.GetChild(1).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(equipmentInfo.Icon);
				}
				child.GetChild(0).gameObject.SetActive(i < this.m_enhanceEquipmentInstanceIds.Count);
				child.GetChild(1).gameObject.SetActive(i < this.m_enhanceEquipmentInstanceIds.Count);
			}
			if (this.m_isFirstIn)
			{
				this.m_curEquipmentSortType = EquipmentDepotUIController.EquipmentSortTypeState.Rank;
				this.m_isAscend = -1;
				this.OnFilterSortOrderButtonClick();
				this.m_isFirstIn = false;
			}
		}

		// Token: 0x0600FC2F RID: 64559 RVA: 0x00426F00 File Offset: 0x00425100
		private void SetEnhancePropItems(PropertyModifyType type, int originValue, int perAddValue, int curLv, int addLv)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnhancePropItemsPropertyModifyTypeInt32Int32Int32Int32_hotfix != null)
			{
				this.m_SetEnhancePropItemsPropertyModifyTypeInt32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					type,
					originValue,
					perAddValue,
					curLv,
					addLv
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = originValue + (int)Math.Round((double)((float)(perAddValue * (curLv - 1)) / 10f));
			int num2 = originValue + (int)Math.Round((double)((float)(perAddValue * (curLv + addLv - 1)) / 10f));
			switch (type)
			{
			case PropertyModifyType.PropertyModifyType_Hero1_HPAdd:
				this.m_enhancePropHpGo.SetActive(true);
				this.m_enhancePropHpOldValueText.text = num.ToString();
				this.m_enhancePropHpNewValueText.text = num2.ToString();
				this.m_enhancePropHpNewValueText.gameObject.SetActive(num2 != num);
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_ATAdd:
				this.m_enhancePropATGo.SetActive(true);
				this.m_enhancePropATOldValueText.text = num.ToString();
				this.m_enhancePropATNewValueText.text = num2.ToString();
				this.m_enhancePropATNewValueText.gameObject.SetActive(num2 != num);
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DFAdd:
				this.m_enhancePropDFGo.SetActive(true);
				this.m_enhancePropDFOldValueText.text = num.ToString();
				this.m_enhancePropDFNewValueText.text = num2.ToString();
				this.m_enhancePropDFNewValueText.gameObject.SetActive(num2 != num);
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicAdd:
				this.m_enhancePropMagicGo.SetActive(true);
				this.m_enhancePropMagicOldValueText.text = num.ToString();
				this.m_enhancePropMagicNewValueText.text = num2.ToString();
				this.m_enhancePropMagicNewValueText.gameObject.SetActive(num2 != num);
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicDFAdd:
				this.m_enhancePropMagicDFGo.SetActive(true);
				this.m_enhancePropMagicDFOldValueText.text = num.ToString();
				this.m_enhancePropMagicDFNewValueText.text = num2.ToString();
				this.m_enhancePropMagicDFNewValueText.gameObject.SetActive(num2 != num);
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DEXAdd:
				this.m_enhancePropDEXGo.SetActive(true);
				this.m_enhancePropDEXOldValueText.text = num.ToString();
				this.m_enhancePropDEXNewValueText.text = num2.ToString();
				this.m_enhancePropDEXNewValueText.gameObject.SetActive(num2 != num);
				break;
			}
		}

		// Token: 0x0600FC30 RID: 64560 RVA: 0x00427218 File Offset: 0x00425418
		private void ResetEnhancePropItemActive()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetEnhancePropItemActive_hotfix != null)
			{
				this.m_ResetEnhancePropItemActive_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enhancePropHpNewValueText.gameObject.SetActive(false);
			this.m_enhancePropATNewValueText.gameObject.SetActive(false);
			this.m_enhancePropDFNewValueText.gameObject.SetActive(false);
			this.m_enhancePropMagicNewValueText.gameObject.SetActive(false);
			this.m_enhancePropMagicDFNewValueText.gameObject.SetActive(false);
			this.m_enhancePropDEXNewValueText.gameObject.SetActive(false);
		}

		// Token: 0x0600FC31 RID: 64561 RVA: 0x004272E0 File Offset: 0x004254E0
		private int CalculateEquipmentEnhanceAddLvByExp(EquipmentBagItem equipment, int enhanceExp, int curLv)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalculateEquipmentEnhanceAddLvByExpEquipmentBagItemInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalculateEquipmentEnhanceAddLvByExpEquipmentBagItemInt32Int32_hotfix.call(new object[]
				{
					this,
					equipment,
					enhanceExp,
					curLv
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int levelLimit = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipment.StarLevel).LevelLimit;
			int num = 0;
			enhanceExp += equipment.Exp;
			while (enhanceExp > 0)
			{
				int num2 = this.m_configDataLoader.GetConfigDataEquipmentLevelInfo(curLv).RankEquipmentNextExps[equipment.EquipmentInfo.Rank - 1];
				enhanceExp -= num2;
				if (enhanceExp >= 0)
				{
					num++;
					curLv++;
					if (curLv > levelLimit)
					{
						break;
					}
				}
			}
			return num;
		}

		// Token: 0x0600FC32 RID: 64562 RVA: 0x004273F4 File Offset: 0x004255F4
		private void OnEnhanceButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnhanceButtonClick_hotfix != null)
			{
				this.m_OnEnhanceButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ulong instanceId in this.m_enhanceEquipmentInstanceIds)
			{
				EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(instanceId) as EquipmentBagItem;
				if (equipmentBagItem.EquipmentInfo.EquipmentType != EquipmentType.EquipmentType_Enhancement && equipmentBagItem.EquipmentInfo.Rank >= 3)
				{
					this.ShowEnhanceItemSRConfirmPanel();
					return;
				}
			}
			this.SendEnhanceEquipmentMsg();
		}

		// Token: 0x0600FC33 RID: 64563 RVA: 0x004274E4 File Offset: 0x004256E4
		private void SendEnhanceEquipmentMsg()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendEnhanceEquipmentMsg_hotfix != null)
			{
				this.m_SendEnhanceEquipmentMsg_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanEnhanceEquipment(this.m_curEquipmentInstanceId, this.m_enhanceEquipmentInstanceIds);
			if (num == 0)
			{
				EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
				string curSkillLvStr = null;
				UIUtility.GetSkillIdFromEquipment(equipmentBagItem.EquipmentInfo, equipmentBagItem.Level, ref curSkillLvStr);
				if (this.EventOnEnhanceButtonClick != null)
				{
					this.EventOnEnhanceButtonClick(this.m_curEquipmentInstanceId, this.m_enhanceEquipmentInstanceIds, delegate
					{
						this.OnEnhanceSucceed(curSkillLvStr);
					}, this.m_slot);
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600FC34 RID: 64564 RVA: 0x004275F0 File Offset: 0x004257F0
		private void OnEnhanceSucceed(string oldSkillLevelStr)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnhanceSucceedString_hotfix != null)
			{
				this.m_OnEnhanceSucceedString_hotfix.call(new object[]
				{
					this,
					oldSkillLevelStr2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string oldSkillLevelStr = oldSkillLevelStr2;
			EquipmentForgeUIController $this = this;
			this.m_enhanceEquipmentInstanceIds.Clear();
			CommonUIStateController component = this.m_enhanceSuccessEffectPanel.GetComponent<CommonUIStateController>();
			this.m_enhanceSuccessEffectPanel.SetActive(true);
			this.m_oldSkillLevelStr = oldSkillLevelStr;
			component.SetActionForUIStateFinshed("Show", delegate
			{
				$this.m_enhanceSuccessEffectPanel.SetActive(false);
				EquipmentBagItem equipmentBagItem = $this.m_playerContext.GetBagItemByInstanceId($this.m_curEquipmentInstanceId) as EquipmentBagItem;
				string text = null;
				int skillIdFromEquipment = UIUtility.GetSkillIdFromEquipment(equipmentBagItem.EquipmentInfo, equipmentBagItem.Level, ref text);
				if (oldSkillLevelStr != text)
				{
					$this.SetSkillLevelUpEffect(equipmentBagItem, oldSkillLevelStr, text, skillIdFromEquipment);
					$this.m_intensifySuccessPanelStateCtrl.gameObject.SetActive(true);
					$this.m_intensifySuccessPanelStateCtrl.SetToUIState("Show", false, true);
				}
			});
			component.SetToUIState("Show", false, true);
		}

		// Token: 0x0600FC35 RID: 64565 RVA: 0x004276C8 File Offset: 0x004258C8
		private void StopEnhanceSucceedEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopEnhanceSucceedEffect_hotfix != null)
			{
				this.m_StopEnhanceSucceedEffect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enhanceSuccessEffectPanel.SetActive(false);
			EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
			string text = null;
			int skillIdFromEquipment = UIUtility.GetSkillIdFromEquipment(equipmentBagItem.EquipmentInfo, equipmentBagItem.Level, ref text);
			if (this.m_oldSkillLevelStr != text)
			{
				this.SetSkillLevelUpEffect(equipmentBagItem, this.m_oldSkillLevelStr, text, skillIdFromEquipment);
				this.m_intensifySuccessPanelStateCtrl.gameObject.SetActive(true);
				this.m_intensifySuccessPanelStateCtrl.SetToUIState("Show", false, true);
			}
		}

		// Token: 0x0600FC36 RID: 64566 RVA: 0x004277A4 File Offset: 0x004259A4
		private void SetSkillLevelUpEffect(EquipmentBagItem equipment, string oldLv, string newLv, int newSkillId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkillLevelUpEffectEquipmentBagItemStringStringInt32_hotfix != null)
			{
				this.m_SetSkillLevelUpEffectEquipmentBagItemStringStringInt32_hotfix.call(new object[]
				{
					this,
					equipment,
					oldLv,
					newLv,
					newSkillId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (oldLv == null)
			{
				this.m_intensifySuccessPanelInfoStateCtrl.SetToUIState("Active", false, true);
			}
			else
			{
				this.m_intensifySuccessPanelInfoStateCtrl.SetToUIState("Upgrade", false, true);
			}
			this.m_intensifySuccessPanelInfoIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(equipment.EquipmentInfo.Rank));
			this.m_intensifySuccessPanelInfoIcon.sprite = AssetUtility.Instance.GetSprite(equipment.EquipmentInfo.Icon);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_intensifySuccessPanelInfoStarGroup, equipment.StarLevel);
			this.m_intensifySuccessPanelCurLvText.text = ((oldLv == null) ? newLv : oldLv);
			this.m_intensifySuccessPanelNextLvText.text = newLv;
			ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(newSkillId);
			if (configDataSkillInfo != null)
			{
				this.m_intensifySuccessPanelSkillNameText.text = configDataSkillInfo.Name;
				this.m_intensifySuccessPanelSkillDescText.text = configDataSkillInfo.Desc;
			}
			else
			{
				this.m_intensifySuccessPanelSkillNameText.text = string.Empty;
				this.m_intensifySuccessPanelSkillDescText.text = string.Empty;
			}
			base.StartCoroutine(this.DelayActiveIntensifyContinueButton());
		}

		// Token: 0x0600FC37 RID: 64567 RVA: 0x00427958 File Offset: 0x00425B58
		[DebuggerHidden]
		private IEnumerator DelayActiveIntensifyContinueButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DelayActiveIntensifyContinueButton_hotfix != null)
			{
				return (IEnumerator)this.m_DelayActiveIntensifyContinueButton_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentForgeUIController.<DelayActiveIntensifyContinueButton>c__Iterator0 <DelayActiveIntensifyContinueButton>c__Iterator = new EquipmentForgeUIController.<DelayActiveIntensifyContinueButton>c__Iterator0();
			<DelayActiveIntensifyContinueButton>c__Iterator.$this = this;
			return <DelayActiveIntensifyContinueButton>c__Iterator;
		}

		// Token: 0x0600FC38 RID: 64568 RVA: 0x004279D4 File Offset: 0x00425BD4
		private void OnIntensifySuccessPanelBlackButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnIntensifySuccessPanelBlackButtonClick_hotfix != null)
			{
				this.m_OnIntensifySuccessPanelBlackButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_intensifySuccessPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_intensifySuccessPanelStateCtrl.gameObject.SetActive(false);
			});
			this.m_intensifySuccessPanelStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x0600FC39 RID: 64569 RVA: 0x00427A64 File Offset: 0x00425C64
		private void ShowEnhanceItemSRConfirmPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnhanceItemSRConfirmPanel_hotfix != null)
			{
				this.m_ShowEnhanceItemSRConfirmPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enhanceItemSRConfirmPanel.SetActive(true);
			CommonUIStateController component = this.m_enhanceItemSRConfirmPanel.GetComponent<CommonUIStateController>();
			component.SetToUIState("Show", false, true);
			this.m_enhanceItemSRTip.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_EnhanceItemsHaveSR);
		}

		// Token: 0x0600FC3A RID: 64570 RVA: 0x00427B04 File Offset: 0x00425D04
		private void ShowEnhanceItemsConfirmPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnhanceItemsConfirmPanel_hotfix != null)
			{
				this.m_ShowEnhanceItemsConfirmPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_enhanceConfirmPanel.GetComponent<CommonUIStateController>();
			this.m_enhanceConfirmPanel.SetActive(true);
			component.SetToUIState("Show", false, true);
			this.m_enhanceConfirmPanelTip1.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_EnhanceItemsExpOverFlow1);
			this.m_enhanceConfirmPanelTip2.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_EnhanceItemsExpOverFlow2);
			if (this.m_isAfter3DTouch)
			{
				this.m_isAfter3DTouch = false;
			}
		}

		// Token: 0x0600FC3B RID: 64571 RVA: 0x00427BD4 File Offset: 0x00425DD4
		private void OnEnhanceItemSRConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnhanceItemSRConfirmButtonClick_hotfix != null)
			{
				this.m_OnEnhanceItemSRConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SendEnhanceEquipmentMsg();
			this.OnEnhanceItemSRCancelButtonClick();
		}

		// Token: 0x0600FC3C RID: 64572 RVA: 0x00427C40 File Offset: 0x00425E40
		private void OnEnhanceItemSRCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnhanceItemSRCancelButtonClick_hotfix != null)
			{
				this.m_OnEnhanceItemSRCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_enhanceItemSRConfirmPanel.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_enhanceItemSRConfirmPanel.SetActive(false);
			});
			component.SetToUIState("Close", false, true);
		}

		// Token: 0x0600FC3D RID: 64573 RVA: 0x00427CD4 File Offset: 0x00425ED4
		private void OnEnhanceConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnhanceConfirmButtonClick_hotfix != null)
			{
				this.m_OnEnhanceConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enhanceEquipmentInstanceIds.Add(this.m_curAddEnhanceEquipmentInstanceId);
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = this.m_equipmentForgeCtrlList.Find((EquipmentDepotListItemUIController equipment) => equipment.EquipmentInstanceId == this.m_curAddEnhanceEquipmentInstanceId);
			if (equipmentDepotListItemUIController != null)
			{
				equipmentDepotListItemUIController.ShowCheckImage(true);
			}
			this.m_enhanceConfirmPanel.SetActive(false);
			this.UpdateViewInEnhanceState();
		}

		// Token: 0x0600FC3E RID: 64574 RVA: 0x00427D84 File Offset: 0x00425F84
		private void OnEnhanceCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnhanceCancelButtonClick_hotfix != null)
			{
				this.m_OnEnhanceCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enhanceConfirmPanel.SetActive(false);
		}

		// Token: 0x0600FC3F RID: 64575 RVA: 0x00427DF0 File Offset: 0x00425FF0
		public void OnEnhanceFastAddButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnhanceFastAddButtonClick_hotfix != null)
			{
				this.m_OnEnhanceFastAddButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_enhanceEquipmentInstanceIds.Count == 5)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_CantAddMoreEnhanceItem, 2f, null, true);
				return;
			}
			EquipmentBagItem equipmentBagItem3 = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
			int levelLimit = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentBagItem3.StarLevel).LevelLimit;
			int num = this.m_configDataLoader.GetConfigDataEquipmentLevelInfo(equipmentBagItem3.Level).RankEquipmentNextExps[equipmentBagItem3.EquipmentInfo.Rank - 1];
			if (equipmentBagItem3.Level == levelLimit && equipmentBagItem3.Exp >= num)
			{
				CommonUIController.Instance.ShowErrorMessage(-514, 2f, null, true);
				return;
			}
			int num2 = this.m_playerContext.CalculateEnhanceEquipmentExp(this.m_enhanceEquipmentInstanceIds);
			int num3 = this.CalculateEquipmentEnhanceAddLvByExp(equipmentBagItem3, num2, equipmentBagItem3.Level);
			if (equipmentBagItem3.Level + num3 > levelLimit || this.IsEquipmentAddExpAtMaxLevelMaxExp(equipmentBagItem3, num3, num2))
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_CantAddMoreEnhanceItem, 2f, null, true);
				return;
			}
			List<EquipmentBagItem> list = new List<EquipmentBagItem>();
			List<EquipmentBagItem> list2 = new List<EquipmentBagItem>();
			List<EquipmentBagItem> list3 = new List<EquipmentBagItem>();
			foreach (BagItemBase bagItemBase in this.m_playerContext.GetBagItems())
			{
				if (bagItemBase.EquipmentInfo != null)
				{
					EquipmentBagItem equipmentBagItem2 = (EquipmentBagItem)bagItemBase;
					if (this.m_curForgeState == EquipmentForgeUIController.ForgeState.Enhance && ((equipmentBagItem2.InstanceId != this.m_curEquipmentInstanceId && equipmentBagItem2.EquipmentInfo.EquipmentType != EquipmentType.EquipmentType_LevelUpStar && !equipmentBagItem2.IsEquipmentEnhanced() && !equipmentBagItem2.IsEquipmentLevelUped(equipmentBagItem2.EquipmentInfo.BornStarLevel) && !equipmentBagItem2.Locked && !this.m_playerContext.IsEquipmentWeared(equipmentBagItem2.InstanceId)) || equipmentBagItem2.EquipmentInfo.EquipmentType == EquipmentType.EquipmentType_Enhancement))
					{
						if (equipmentBagItem2.EquipmentInfo.EquipmentType == EquipmentType.EquipmentType_Enhancement)
						{
							list2.Add(equipmentBagItem2);
						}
						else
						{
							list3.Add(equipmentBagItem2);
						}
					}
				}
			}
			EquipmentDepotUIController.EquipmentSortTypeState curEquipmentSortType = this.m_curEquipmentSortType;
			int isAscend = this.m_isAscend;
			this.m_curEquipmentSortType = EquipmentDepotUIController.EquipmentSortTypeState.Rank;
			this.m_isAscend = 1;
			this.SortEquipmentListByType(list2);
			this.SortEquipmentListByType(list3);
			this.m_curEquipmentSortType = curEquipmentSortType;
			this.m_isAscend = isAscend;
			list.AddRange(list2);
			list.AddRange(list3);
			this.m_curAddEnhanceEquipmentInstanceId = 0UL;
			int count = this.m_enhanceEquipmentInstanceIds.Count;
			bool flag = false;
			using (List<EquipmentBagItem>.Enumerator enumerator2 = list.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					EquipmentBagItem equipmentBagItem = enumerator2.Current;
					if (!this.m_enhanceEquipmentInstanceIds.Contains(equipmentBagItem.InstanceId))
					{
						this.m_enhanceEquipmentInstanceIds.Add(equipmentBagItem.InstanceId);
						int num4 = this.m_playerContext.CalculateEnhanceEquipmentExp(this.m_enhanceEquipmentInstanceIds);
						int num5 = this.CalculateEquipmentEnhanceAddLvByExp(equipmentBagItem3, num4, equipmentBagItem3.Level);
						if (equipmentBagItem3.Level + num5 >= levelLimit)
						{
							if (equipmentBagItem3.Level + num5 > levelLimit || this.IsEquipmentAddExpAtMaxLevelMaxExp(equipmentBagItem3, num5, num4))
							{
								this.m_enhanceEquipmentInstanceIds.Remove(equipmentBagItem.InstanceId);
								int num6 = this.m_playerContext.CalculateEnhanceEquipmentExp(new List<ulong>
								{
									this.m_curAddEnhanceEquipmentInstanceId
								});
								int num7 = this.m_playerContext.CalculateEnhanceEquipmentExp(new List<ulong>
								{
									equipmentBagItem.InstanceId
								});
								if (num7 < num6 || this.m_curAddEnhanceEquipmentInstanceId == 0UL)
								{
									this.m_curAddEnhanceEquipmentInstanceId = equipmentBagItem.InstanceId;
								}
								flag = true;
								continue;
							}
							EquipmentDepotListItemUIController equipmentDepotListItemUIController = this.m_equipmentForgeCtrlList.Find((EquipmentDepotListItemUIController c) => c.BagItem.InstanceId == equipmentBagItem.InstanceId);
							if (equipmentDepotListItemUIController != null)
							{
								equipmentDepotListItemUIController.ShowCheckImage(true);
							}
							this.m_curAddEnhanceEquipmentInstanceId = equipmentBagItem.InstanceId;
							flag = false;
						}
						else
						{
							EquipmentDepotListItemUIController equipmentDepotListItemUIController2 = this.m_equipmentForgeCtrlList.Find((EquipmentDepotListItemUIController c) => c.BagItem.InstanceId == equipmentBagItem.InstanceId);
							if (equipmentDepotListItemUIController2 != null)
							{
								equipmentDepotListItemUIController2.ShowCheckImage(true);
							}
							this.m_curAddEnhanceEquipmentInstanceId = equipmentBagItem.InstanceId;
							flag = false;
						}
						if (this.m_enhanceEquipmentInstanceIds.Count == 5)
						{
							break;
						}
					}
				}
			}
			if (this.m_enhanceEquipmentInstanceIds.Count != count)
			{
				this.UpdateViewInEnhanceState();
			}
			if (this.m_enhanceEquipmentInstanceIds.Count == count && flag)
			{
				this.ShowEnhanceItemsConfirmPanel();
				return;
			}
			if (this.m_enhanceEquipmentInstanceIds.Count == count)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_NoEnchaneItemCanAdd, 2f, null, true);
				return;
			}
		}

		// Token: 0x0600FC40 RID: 64576 RVA: 0x00428370 File Offset: 0x00426570
		private bool IsEquipmentAddExpAtMaxLevelMaxExp(EquipmentBagItem equipment, int addLv, int addExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEquipmentAddExpAtMaxLevelMaxExpEquipmentBagItemInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEquipmentAddExpAtMaxLevelMaxExpEquipmentBagItemInt32Int32_hotfix.call(new object[]
				{
					this,
					equipment,
					addLv,
					addExp
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int levelLimit = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipment.StarLevel).LevelLimit;
			if (equipment.Level + addLv != levelLimit)
			{
				return false;
			}
			for (int i = 0; i <= addLv; i++)
			{
				int num = this.m_configDataLoader.GetConfigDataEquipmentLevelInfo(equipment.Level + i).RankEquipmentNextExps[equipment.EquipmentInfo.Rank - 1];
				if (i == 0)
				{
					addExp -= num - equipment.Exp;
				}
				else
				{
					addExp -= num;
				}
				if (addExp < 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600FC41 RID: 64577 RVA: 0x00428498 File Offset: 0x00426698
		private void UpdateViewInBreakState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInBreakState_hotfix != null)
			{
				this.m_UpdateViewInBreakState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curEquipmentInstanceId == 0UL)
			{
				return;
			}
			EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
			if (equipmentBagItem == null)
			{
				if (this.EventOnReturn != null)
				{
					this.EventOnReturn();
				}
				return;
			}
			int configableConstId_HeroStarLevelMax = this.m_configDataLoader.ConfigableConstId_HeroStarLevelMax;
			CommonUIStateController component = this.m_breakGo.GetComponent<CommonUIStateController>();
			if (equipmentBagItem.StarLevel != configableConstId_HeroStarLevelMax)
			{
				component.SetToUIState("CanBreak", false, true);
				this.m_breakTitleText.text = equipmentBagItem.EquipmentInfo.Name;
				Image breakCurLvEquipmentIcon = this.m_breakCurLvEquipmentIcon;
				Sprite sprite = AssetUtility.Instance.GetSprite(equipmentBagItem.EquipmentInfo.Icon);
				this.m_breakNextLvEquipmentIcon.sprite = sprite;
				breakCurLvEquipmentIcon.sprite = sprite;
				int rank = equipmentBagItem.EquipmentInfo.Rank;
				Image breakCurLvEquipmentIconBg = this.m_breakCurLvEquipmentIconBg;
				sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(rank));
				this.m_breakNextLvEquipmentIconBg.sprite = sprite;
				breakCurLvEquipmentIconBg.sprite = sprite;
				this.m_breakCurLvEquipmentIconSSREffect.SetActive(UIUtility.IsRankSSR(rank));
				this.m_breakNextLvEquipmentIconSSREffect.SetActive(UIUtility.IsRankSSR(rank));
				UIUtility.SetGameObjectChildrenActiveCount(this.m_breakCurLvEquipmentStarGroup, equipmentBagItem.StarLevel);
				UIUtility.SetGameObjectChildrenActiveCount(this.m_breakNextLvEquipmentStarGroup, equipmentBagItem.StarLevel + 1);
				Text breakCurLvEquipmentOldLvText = this.m_breakCurLvEquipmentOldLvText;
				string text = equipmentBagItem.Level.ToString();
				this.m_breakNextLvEquipmentOldLvText.text = text;
				breakCurLvEquipmentOldLvText.text = text;
				this.m_breakCurLvEquipmentMaxLvText.text = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentBagItem.StarLevel).LevelLimit.ToString();
				this.m_breakNextLvEquipmentMaxLvText.text = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentBagItem.StarLevel + 1).LevelLimit.ToString();
				CommonUIStateController component2 = this.m_breakMaterialIconGo.GetComponent<CommonUIStateController>();
				if (this.m_equipmentItemCache.Count == 0)
				{
					component2.SetToUIState("NoItem", false, true);
					this.m_breakMaterialIcon.sprite = AssetUtility.Instance.GetSprite(equipmentBagItem.EquipmentInfo.Icon);
					int rank2 = equipmentBagItem.EquipmentInfo.Rank;
					this.m_breakMaterialIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(rank2));
					this.m_breakMaterialSSREffect.SetActive(UIUtility.IsRankSSR(rank2));
				}
				else
				{
					BagItemBase bagItemByInstanceId = this.m_playerContext.GetBagItemByInstanceId(this.m_curBreakMaterialEquipmentId);
					if (bagItemByInstanceId == null)
					{
						component2.SetToUIState("Add", false, true);
						this.m_breakMaterialSSREffect.SetActive(false);
					}
					else
					{
						component2.SetToUIState("Normal", false, true);
						this.m_breakMaterialIcon.sprite = AssetUtility.Instance.GetSprite(bagItemByInstanceId.EquipmentInfo.Icon);
						int rank3 = bagItemByInstanceId.EquipmentInfo.Rank;
						this.m_breakMaterialIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(rank3));
						this.m_breakMaterialSSREffect.SetActive(UIUtility.IsRankSSR(rank3));
					}
				}
				List<Goods> list = null;
				switch (equipmentBagItem.StarLevel)
				{
				case 1:
					list = equipmentBagItem.EquipmentInfo.LevelUpGoods1;
					break;
				case 2:
					list = equipmentBagItem.EquipmentInfo.LevelUpGoods2;
					break;
				case 3:
					list = equipmentBagItem.EquipmentInfo.LevelUpGoods3;
					break;
				case 4:
					list = equipmentBagItem.EquipmentInfo.LevelUpGoods4;
					break;
				case 5:
					list = equipmentBagItem.EquipmentInfo.LevelUpGoods5;
					break;
				}
				for (int i = 0; i < this.m_breakItemsContent.transform.childCount; i++)
				{
					GameObject gameObject = this.m_breakItemsContent.transform.GetChild(i).gameObject;
					EquipmentBreakNeedItemUIController component3 = gameObject.GetComponent<EquipmentBreakNeedItemUIController>();
					if (component3 == null)
					{
						PrefabControllerCreater.CreateAllControllers(gameObject);
						component3 = gameObject.GetComponent<EquipmentBreakNeedItemUIController>();
						component3.EventOnClick += this.OnEquipmentBreakNeedItemClick;
					}
					Goods goods = (i < list.Count) ? list[i] : null;
					component3.InitEquipmentBreakNeedItem(goods);
				}
				int num = equipmentBagItem.StarLevel * this.m_configDataLoader.ConfigableConstId_LevelUpEquipmentStarConsumeGoldPerStar;
				this.m_breakGoldText.text = num.ToString();
				CommonUIStateController component4 = this.m_breakGoldText.gameObject.GetComponent<CommonUIStateController>();
				int gold = this.m_playerContext.GetGold();
				if (num > gold)
				{
					component4.SetToUIState("Red", false, true);
				}
				else
				{
					component4.SetToUIState("Normal", false, true);
				}
				return;
			}
			component.SetToUIState("CanNotBreak", false, true);
			this.m_breakCantTitleText.text = equipmentBagItem.EquipmentInfo.Name;
			this.m_breakCantIcon.sprite = AssetUtility.Instance.GetSprite(equipmentBagItem.EquipmentInfo.Icon);
			this.m_breakCantIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(equipmentBagItem.EquipmentInfo.Rank));
			UIUtility.SetGameObjectChildrenActiveCount(this.m_breakCantStarGroup, equipmentBagItem.StarLevel);
		}

		// Token: 0x0600FC42 RID: 64578 RVA: 0x00428A10 File Offset: 0x00426C10
		private void OnBreakButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBreakButtonClick_hotfix != null)
			{
				this.m_OnBreakButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanLevelUpEquipmentStar(this.m_curEquipmentInstanceId, this.m_curBreakMaterialEquipmentId);
			if (num == 0)
			{
				if (this.EventOnBreakButtonClick != null)
				{
					this.EventOnBreakButtonClick(this.m_curEquipmentInstanceId, this.m_curBreakMaterialEquipmentId, new Action(this.OnBreakSucceed), this.m_slot);
				}
			}
			else if (num == -401)
			{
				if (this.EventOnCrystalNotEnough != null)
				{
					this.EventOnCrystalNotEnough();
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600FC43 RID: 64579 RVA: 0x00428B00 File Offset: 0x00426D00
		private void OnBreakSucceed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBreakSucceed_hotfix != null)
			{
				this.m_OnBreakSucceed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curBreakMaterialEquipmentId = 0UL;
			EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
			this.m_breakSuccessInfoIcon.sprite = AssetUtility.Instance.GetSprite(equipmentBagItem.EquipmentInfo.Icon);
			this.m_breakSuccessInfoIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(equipmentBagItem.EquipmentInfo.Rank));
			UIUtility.SetGameObjectChildrenActiveCount(this.m_breakSuccessInfoStarGroup, equipmentBagItem.StarLevel);
			Text breakSuccessInfoCurOldLvText = this.m_breakSuccessInfoCurOldLvText;
			string text = equipmentBagItem.Level.ToString();
			this.m_breakSuccessInfoNextOldLvText.text = text;
			breakSuccessInfoCurOldLvText.text = text;
			this.m_breakSuccessInfoCurMaxLvText.text = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentBagItem.StarLevel - 1).LevelLimit.ToString();
			this.m_breakSuccessInfoNextMaxLvText.text = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentBagItem.StarLevel).LevelLimit.ToString();
			base.StartCoroutine(this.DelayActiveBreakContinueButton());
			CommonUIStateController component = this.m_breakSuccessPanel.GetComponent<CommonUIStateController>();
			this.m_breakSuccessPanel.SetActive(true);
			component.SetToUIState("Show", false, true);
		}

		// Token: 0x0600FC44 RID: 64580 RVA: 0x00428C98 File Offset: 0x00426E98
		[DebuggerHidden]
		private IEnumerator DelayActiveBreakContinueButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DelayActiveBreakContinueButton_hotfix != null)
			{
				return (IEnumerator)this.m_DelayActiveBreakContinueButton_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentForgeUIController.<DelayActiveBreakContinueButton>c__Iterator1 <DelayActiveBreakContinueButton>c__Iterator = new EquipmentForgeUIController.<DelayActiveBreakContinueButton>c__Iterator1();
			<DelayActiveBreakContinueButton>c__Iterator.$this = this;
			return <DelayActiveBreakContinueButton>c__Iterator;
		}

		// Token: 0x0600FC45 RID: 64581 RVA: 0x00428D14 File Offset: 0x00426F14
		private void OnBreakSuccessPanelContinueButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBreakSuccessPanelContinueButtonClick_hotfix != null)
			{
				this.m_OnBreakSuccessPanelContinueButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_breakSuccessPanel.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_breakSuccessPanel.SetActive(false);
			});
			component.SetToUIState("Close", false, true);
		}

		// Token: 0x0600FC46 RID: 64582 RVA: 0x00428DA8 File Offset: 0x00426FA8
		private void OnEquipmentBreakNeedItemClick(GoodsType type, int id, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentBreakNeedItemClickGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_OnEquipmentBreakNeedItemClickGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					type,
					id,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnBreakNeedItemClick != null)
			{
				this.EventOnBreakNeedItemClick(type, id, count);
			}
		}

		// Token: 0x0600FC47 RID: 64583 RVA: 0x00428E54 File Offset: 0x00427054
		private void UpdateViewInEnchantmentState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInEnchantmentState_hotfix != null)
			{
				this.m_UpdateViewInEnchantmentState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curEquipmentInstanceId == 0UL)
			{
				return;
			}
			EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
			if (equipmentBagItem == null)
			{
				if (this.EventOnReturn != null)
				{
					this.EventOnReturn();
				}
				return;
			}
			this.m_enchantmentItemNameText.text = equipmentBagItem.EquipmentInfo.Name;
			this.m_enchantmentIcon.sprite = AssetUtility.Instance.GetSprite(equipmentBagItem.EquipmentInfo.Icon);
			int rank = equipmentBagItem.EquipmentInfo.Rank;
			this.m_enchantmentIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(rank));
			this.m_enchantmentIconSSREffect.SetActive(UIUtility.IsRankSSR(rank));
			UIUtility.SetGameObjectChildrenActiveCount(this.m_enchantmentStarGroup, equipmentBagItem.StarLevel);
			int levelLimit = this.m_configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentBagItem.StarLevel).LevelLimit;
			this.m_enchantmentItemLevelValueText.text = equipmentBagItem.Level + "/" + levelLimit;
			List<CommonBattleProperty> enchantProperties = equipmentBagItem.EnchantProperties;
			Transform transform = this.m_enchantmentEnchantPropertyGroup.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				Text text = null;
				Text text2 = null;
				Transform child = transform.GetChild(i);
				for (int j = 0; j < child.childCount; j++)
				{
					Transform child2 = child.GetChild(j);
					if (child2.name == "NameText")
					{
						text = child2.GetComponent<Text>();
					}
					else if (child2.name == "ValueText")
					{
						text2 = child2.GetComponent<Text>();
					}
				}
				if (i < enchantProperties.Count)
				{
					ConfigDataPropertyModifyInfo configDataPropertyModifyInfo = this.m_configDataLoader.GetConfigDataPropertyModifyInfo((int)enchantProperties[i].Id);
					text.text = configDataPropertyModifyInfo.Name;
					text.gameObject.SetActive(true);
					if (configDataPropertyModifyInfo.IsAddType)
					{
						text2.text = enchantProperties[i].Value.ToString();
					}
					else
					{
						text2.text = enchantProperties[i].Value / 100 + "%";
					}
				}
				else
				{
					text.gameObject.SetActive(false);
					text2.text = "--";
				}
			}
			if (equipmentBagItem.IsEnchant())
			{
				ConfigDataResonanceInfo configDataResonanceInfo = this.m_configDataLoader.GetConfigDataResonanceInfo(equipmentBagItem.ResonanceId);
				this.m_enchantmentSuitInfoStateCtrl.SetToUIState("HaveEffect", false, true);
				int equipmentResonanceNums = this.m_playerContext.GetEquipmentResonanceNums(equipmentBagItem.InstanceId);
				if (equipmentResonanceNums >= 2)
				{
					this.m_enchantmentSuitInfoNowEffectRuneIconStateCtrl.SetToUIState("Active", false, true);
					this.m_enchantmentSuitInfoNowEffectRuneActiveIcon.sprite = AssetUtility.Instance.GetSprite(configDataResonanceInfo.ActiveIcon);
				}
				else
				{
					this.m_enchantmentSuitInfoNowEffectRuneIconStateCtrl.SetToUIState("Inactive", false, true);
					this.m_enchantmentSuitInfoNowEffectRuneUnactiveIcon.sprite = AssetUtility.Instance.GetSprite(configDataResonanceInfo.InactiveIcon);
				}
				this.m_enchantmentSuitInfoNowEffectRuneNameText.text = configDataResonanceInfo.Name;
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect1);
				this.m_enchantmentSuitInfoNowEffectRune2SuitInfoText.text = configDataSkillInfo.Desc;
				configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect2);
				this.m_enchantmentSuitInfoNowEffectRune4SuitInfoText.text = configDataSkillInfo.Desc;
			}
			else if (this.m_curSelectEnchantStoneItem != null)
			{
				this.m_enchantmentSuitInfoStateCtrl.SetToUIState("HaveEffect", false, true);
			}
			else
			{
				this.m_enchantmentSuitInfoStateCtrl.SetToUIState("NoEffect", false, true);
			}
			if (this.m_curSelectEnchantStoneItem != null)
			{
				this.m_enchantmentEnchantPropertyGroupStateCtrl.SetToUIState("Show", false, true);
				ConfigDataResonanceInfo configDataResonanceInfo2 = this.m_configDataLoader.GetConfigDataResonanceInfo(this.m_curSelectEnchantStoneItem.EnchantStoneInfo.Resonance_ID);
				this.m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon.sprite = AssetUtility.Instance.GetSprite(configDataResonanceInfo2.InactiveIcon);
				this.m_enchantmentSuitInfoAfterEffectRuneNameText.text = configDataResonanceInfo2.Name;
				ConfigDataSkillInfo configDataSkillInfo2 = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo2.Effect1);
				this.m_enchantmentSuitInfoAfterEffectRune2SuitInfoText.text = configDataSkillInfo2.Desc;
				configDataSkillInfo2 = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo2.Effect2);
				this.m_enchantmentSuitInfoAfterEffectRune4SuitInfoText.text = configDataSkillInfo2.Desc;
				this.m_enchantmentSuitInfoGroupStateCtrl.SetToUIState("Both", false, true);
				if (equipmentBagItem.IsEnchant())
				{
					this.m_enchantmentSuitInfoNowEffectStateCtrl.SetToUIState("HaveEffect", false, true);
				}
				else
				{
					this.m_enchantmentSuitInfoNowEffectStateCtrl.SetToUIState("NoEffect", false, true);
				}
				this.m_enchantmentSuitInfoAfterEffectStateCtrl.SetToUIState("Show", false, true);
				this.m_enchantmentMaterialGroupStateCtrl.SetToUIState("Have", false, true);
				ConfigDataEnchantStoneInfo enchantStoneInfo = this.m_curSelectEnchantStoneItem.EnchantStoneInfo;
				this.m_enchantmentStoneIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(enchantStoneInfo.Rank));
				this.m_enchantmentStoneIcon.sprite = AssetUtility.Instance.GetSprite(enchantStoneInfo.Icon);
				this.m_enchantmentStoneNameText.text = enchantStoneInfo.Name;
				this.m_enchantmentStoneDescText.text = enchantStoneInfo.Desc;
				this.m_enchantmentGoldenValueText.text = enchantStoneInfo.CostGold.ToString();
				if (enchantStoneInfo.CostGold <= this.m_playerContext.GetGold())
				{
					this.m_enchantmentGoldenValueTextStateCtrl.SetToUIState("Normal", false, true);
				}
				else
				{
					this.m_enchantmentGoldenValueTextStateCtrl.SetToUIState("Red", false, true);
				}
				int goodsCount = UIUtility.GetGoodsCount(this.m_curSelectEnchantStoneItem.GoodsTypeId, this.m_curSelectEnchantStoneItem.ContentId);
				if (goodsCount >= 1)
				{
					this.m_enchantmentStoneValueGroupStateCtrl.SetToUIState("White", false, true);
				}
				else
				{
					this.m_enchantmentStoneValueGroupStateCtrl.SetToUIState("Red", false, true);
				}
				this.m_enchantmentStoneHaveCount.text = goodsCount.ToString();
			}
			else
			{
				this.m_enchantmentEnchantPropertyGroupStateCtrl.SetToUIState("Close", false, true);
				this.m_enchantmentSuitInfoGroupStateCtrl.SetToUIState("Left", false, true);
				if (equipmentBagItem.IsEnchant())
				{
					this.m_enchantmentSuitInfoNowEffectStateCtrl.SetToUIState("HaveEffect", false, true);
				}
				else
				{
					this.m_enchantmentSuitInfoNowEffectStateCtrl.SetToUIState("NoEffect", false, true);
				}
				this.m_enchantmentSuitInfoAfterEffectStateCtrl.SetToUIState("Show", false, true);
				this.m_enchantmentMaterialGroupStateCtrl.SetToUIState("Empty", false, true);
				this.m_enchantmentGoldenValueText.text = "0";
			}
		}

		// Token: 0x0600FC48 RID: 64584 RVA: 0x00429540 File Offset: 0x00427740
		private void OnEnchantmentButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantmentButtonClick_hotfix != null)
			{
				this.m_OnEnchantmentButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curSelectEnchantStoneItem == null)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_PutInEnchantStone, 2f, null, true);
				return;
			}
			int num = this.m_playerContext.CanEnchantEquipment(this.m_curEquipmentInstanceId, this.m_curSelectEnchantStoneItem.InstanceId);
			if (num == 0)
			{
				if (this.EventOnEnchantButtonClick != null)
				{
					this.EventOnEnchantButtonClick(this.m_curEquipmentInstanceId, this.m_curSelectEnchantStoneItem.InstanceId, delegate(int id, List<CommonBattleProperty> properties)
					{
						this.ShowEnchantmentResultPanel(id, properties, true);
					});
				}
				int goodsCount = UIUtility.GetGoodsCount(this.m_curSelectEnchantStoneItem.GoodsTypeId, this.m_curSelectEnchantStoneItem.ContentId);
				if (goodsCount == 1)
				{
					this.m_curSelectEnchantStoneItem = null;
				}
				this.SetPlayerResourceGold();
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600FC49 RID: 64585 RVA: 0x00429660 File Offset: 0x00427860
		private void ShowEnchantmentResultPanel(int newResonanceId, List<CommonBattleProperty> properties, bool isFirstShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnchantmentResultPanelInt32List`1Boolean_hotfix != null)
			{
				this.m_ShowEnchantmentResultPanelInt32List`1Boolean_hotfix.call(new object[]
				{
					this,
					newResonanceId,
					properties,
					isFirstShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isFirstShow)
			{
				this.m_enchantmentResultPanelStateCtrl.gameObject.SetActive(true);
				this.m_enchantmentResultPanelStateCtrl.SetToUIState("Show", false, true);
			}
			this.SetEnchantmentResultPanelInfo(newResonanceId, properties);
		}

		// Token: 0x0600FC4A RID: 64586 RVA: 0x00429724 File Offset: 0x00427924
		private void SetEnchantmentResultPanelInfo(int newResonanceId, List<CommonBattleProperty> properties)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnchantmentResultPanelInfoInt32List`1_hotfix != null)
			{
				this.m_SetEnchantmentResultPanelInfoInt32List`1_hotfix.call(new object[]
				{
					this,
					newResonanceId,
					properties
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
			List<CommonBattleProperty> enchantProperties = equipmentBagItem.EnchantProperties;
			Transform transform = this.m_enchantmentResultPanelOldPropretyGroup.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				Text text = null;
				Text text2 = null;
				Image image = null;
				for (int j = 0; j < child.childCount; j++)
				{
					Transform child2 = child.GetChild(j);
					if (child2.name == "NameText")
					{
						text = child2.GetComponent<Text>();
					}
					else if (child2.name == "ValueText")
					{
						text2 = child2.GetComponent<Text>();
					}
					else if (child2.name == "ProgressBar")
					{
						image = child2.GetComponent<Image>();
					}
				}
				CommonUIStateController component = child.GetComponent<CommonUIStateController>();
				if (i < enchantProperties.Count)
				{
					ConfigDataPropertyModifyInfo configDataPropertyModifyInfo = this.m_configDataLoader.GetConfigDataPropertyModifyInfo((int)enchantProperties[i].Id);
					text.text = configDataPropertyModifyInfo.Name;
					if (configDataPropertyModifyInfo.IsAddType)
					{
						text2.text = enchantProperties[i].Value.ToString();
					}
					else
					{
						text2.text = enchantProperties[i].Value / 100 + "%";
					}
					image.fillAmount = this.CalcPropertyPercent(enchantProperties[i].Id, enchantProperties[i].Value);
					component.SetToUIState("Normal", false, true);
				}
				else
				{
					text2.text = "--";
					component.SetToUIState("Grey", false, true);
				}
			}
			if (enchantProperties.Count > 0)
			{
				this.m_enchantmentResultPanelOldSuitInfoStateCtrl.SetToUIState("HaveEffect", false, true);
				ConfigDataResonanceInfo configDataResonanceInfo = this.m_configDataLoader.GetConfigDataResonanceInfo(equipmentBagItem.ResonanceId);
				this.m_enchantmentResultPanelOldSuitInfoNameText.text = configDataResonanceInfo.Name;
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect1);
				this.m_enchantmentResultPanelOld2SuitInfoText.text = configDataSkillInfo.Desc;
				configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect2);
				this.m_enchantmentResultPanelOld4SuitInfoText.text = configDataSkillInfo.Desc;
			}
			else
			{
				this.m_enchantmentResultPanelOldSuitInfoStateCtrl.SetToUIState("NoEffect", false, true);
			}
			this.m_properties.Clear();
			this.m_properties.AddRange(properties);
			base.StartCoroutine(this.Co_PlayNewPropertyEffect(properties));
			if (properties.Count > 0)
			{
				ConfigDataResonanceInfo configDataResonanceInfo2 = this.m_configDataLoader.GetConfigDataResonanceInfo(newResonanceId);
				this.m_enchantmentResultPanelNewSuitInfoNameText.text = configDataResonanceInfo2.Name;
				ConfigDataSkillInfo configDataSkillInfo2 = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo2.Effect1);
				this.m_enchantmentResultPanelNew2SuitInfoText.text = configDataSkillInfo2.Desc;
				configDataSkillInfo2 = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo2.Effect2);
				this.m_enchantmentResultPanelNew4SuitInfoText.text = configDataSkillInfo2.Desc;
			}
			if (this.m_curSelectEnchantStoneItem != null)
			{
				BagItemBase curSelectEnchantStoneItem = this.m_curSelectEnchantStoneItem;
				int goodsCount = UIUtility.GetGoodsCount(curSelectEnchantStoneItem.GoodsTypeId, curSelectEnchantStoneItem.ContentId);
				this.m_enchantmentResultPanelNumberText.text = 1 + "/" + goodsCount;
				this.m_enchantmentResultPanelGoldenNumberText.text = curSelectEnchantStoneItem.EnchantStoneInfo.CostGold.ToString();
				if (curSelectEnchantStoneItem.EnchantStoneInfo.CostGold < this.m_playerContext.GetGold())
				{
					this.m_enchantmentResultPanelGoldenNumberStateCtrl.SetToUIState("Normal", false, true);
				}
				else
				{
					this.m_enchantmentResultPanelGoldenNumberStateCtrl.SetToUIState("Red", false, true);
				}
				this.m_enchantmentResultPanelItemImage.sprite = AssetUtility.Instance.GetSprite(curSelectEnchantStoneItem.EnchantStoneInfo.Icon);
				this.m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_enchantmentResultPanelNumberText.text = 1 + "/0";
				this.m_enchantmentResultPanelGoldenNumberText.text = "0";
				this.m_enchantmentResultPanelGoldenNumberStateCtrl.SetToUIState("Normal", false, true);
				if (this.m_lastSelectEnchantStoneInfo != null)
				{
					this.m_enchantmentResultPanelItemImage.sprite = AssetUtility.Instance.GetSprite(this.m_lastSelectEnchantStoneInfo.Icon);
				}
				this.m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl.SetToUIState("Grey", false, true);
			}
		}

		// Token: 0x0600FC4B RID: 64587 RVA: 0x00429C18 File Offset: 0x00427E18
		[DebuggerHidden]
		private IEnumerator Co_PlayNewPropertyEffect(List<CommonBattleProperty> properties)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_PlayNewPropertyEffectList`1_hotfix != null)
			{
				return (IEnumerator)this.m_Co_PlayNewPropertyEffectList`1_hotfix.call(new object[]
				{
					this,
					properties
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentForgeUIController.<Co_PlayNewPropertyEffect>c__Iterator2 <Co_PlayNewPropertyEffect>c__Iterator = new EquipmentForgeUIController.<Co_PlayNewPropertyEffect>c__Iterator2();
			<Co_PlayNewPropertyEffect>c__Iterator.properties = properties;
			<Co_PlayNewPropertyEffect>c__Iterator.$this = this;
			return <Co_PlayNewPropertyEffect>c__Iterator;
		}

		// Token: 0x0600FC4C RID: 64588 RVA: 0x00429CAC File Offset: 0x00427EAC
		[DebuggerHidden]
		private IEnumerator Co_DynamicSetPropertyValue(Text valueText, Image progressBar, int value, PropertyModifyType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_DynamicSetPropertyValueTextImageInt32PropertyModifyType_hotfix != null)
			{
				return (IEnumerator)this.m_Co_DynamicSetPropertyValueTextImageInt32PropertyModifyType_hotfix.call(new object[]
				{
					this,
					valueText,
					progressBar,
					value,
					type
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentForgeUIController.<Co_DynamicSetPropertyValue>c__Iterator3 <Co_DynamicSetPropertyValue>c__Iterator = new EquipmentForgeUIController.<Co_DynamicSetPropertyValue>c__Iterator3();
			<Co_DynamicSetPropertyValue>c__Iterator.type = type;
			<Co_DynamicSetPropertyValue>c__Iterator.value = value;
			<Co_DynamicSetPropertyValue>c__Iterator.valueText = valueText;
			<Co_DynamicSetPropertyValue>c__Iterator.progressBar = progressBar;
			<Co_DynamicSetPropertyValue>c__Iterator.$this = this;
			return <Co_DynamicSetPropertyValue>c__Iterator;
		}

		// Token: 0x0600FC4D RID: 64589 RVA: 0x00429D84 File Offset: 0x00427F84
		private float CalcPropertyPercent(PropertyModifyType propertyTypeId, int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcPropertyPercentPropertyModifyTypeInt32_hotfix != null)
			{
				return Convert.ToSingle(this.m_CalcPropertyPercentPropertyModifyTypeInt32_hotfix.call(new object[]
				{
					this,
					propertyTypeId2,
					value
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PropertyModifyType propertyTypeId = propertyTypeId2;
			Dictionary<int, List<EnchantPropertyProbabilityInfo>> enchantPropertyProbabilityInfos = ((ClientConfigDataLoader)this.m_configDataLoader).EnchantPropertyProbabilityInfos;
			EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
			List<int> enchantTemplateIds = equipmentBagItem.EquipmentInfo.EnchantTemplateIds;
			int num = 0;
			int num2 = int.MaxValue;
			foreach (int key in enchantTemplateIds)
			{
				List<EnchantPropertyProbabilityInfo> list = new List<EnchantPropertyProbabilityInfo>();
				if (enchantPropertyProbabilityInfos.ContainsKey(key))
				{
					list.AddRange(enchantPropertyProbabilityInfos[key]);
					EnchantPropertyProbabilityInfo enchantPropertyProbabilityInfo = list.Find((EnchantPropertyProbabilityInfo info) => info.Id == propertyTypeId);
					foreach (EnchantPropertyValueInfo enchantPropertyValueInfo in enchantPropertyProbabilityInfo.PropertyValues)
					{
						if (num < enchantPropertyValueInfo.Max)
						{
							num = enchantPropertyValueInfo.Max;
						}
						if (num2 > enchantPropertyValueInfo.Min)
						{
							num2 = enchantPropertyValueInfo.Min;
						}
					}
				}
			}
			return (float)(value - num2) / (float)(num - 1 - num2);
		}

		// Token: 0x0600FC4E RID: 64590 RVA: 0x00429F60 File Offset: 0x00428160
		private void OnEnchantmentResultPanelContinueButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantmentResultPanelContinueButtonClick_hotfix != null)
			{
				this.m_OnEnchantmentResultPanelContinueButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StopAllCoroutines();
			List<Text> list = new List<Text>
			{
				this.m_enchantmentResultPanelNewProprety1NameText,
				this.m_enchantmentResultPanelNewProprety2NameText,
				this.m_enchantmentResultPanelNewProprety3NameText
			};
			List<Text> list2 = new List<Text>
			{
				this.m_enchantmentResultPanelNewProprety1ValueText,
				this.m_enchantmentResultPanelNewProprety2ValueText,
				this.m_enchantmentResultPanelNewProprety3ValueText
			};
			List<Image> list3 = new List<Image>
			{
				this.m_enchantmentResultPanelNewProprety1ProgressBar,
				this.m_enchantmentResultPanelNewProprety2ProgressBar,
				this.m_enchantmentResultPanelNewProprety3ProgressBar
			};
			List<CommonUIStateController> list4 = new List<CommonUIStateController>
			{
				this.m_enchantmentResultPanelNewProprety1StateCtrl,
				this.m_enchantmentResultPanelNewProprety2StateCtrl,
				this.m_enchantmentResultPanelNewProprety3StateCtrl
			};
			for (int i = 0; i < list2.Count; i++)
			{
				if (i < this.m_properties.Count)
				{
					ConfigDataPropertyModifyInfo configDataPropertyModifyInfo = this.m_configDataLoader.GetConfigDataPropertyModifyInfo((int)this.m_properties[i].Id);
					if (configDataPropertyModifyInfo.IsAddType)
					{
						list2[i].text = this.m_properties[i].Value.ToString();
					}
					else
					{
						list2[i].text = this.m_properties[i].Value / 100 + "%";
					}
					list3[i].fillAmount = this.CalcPropertyPercent(this.m_properties[i].Id, this.m_properties[i].Value);
					list[i].text = configDataPropertyModifyInfo.Name;
					CommonUIStateController component = list2[i].GetComponent<CommonUIStateController>();
					component.SetToUIState("Change", false, true);
					list4[i].SetToUIState("Change", false, true);
				}
				else
				{
					list4[i].SetToUIState("Grey", false, true);
				}
			}
			this.m_enchantmentResultPanelContinueButton.gameObject.SetActive(false);
			this.m_enchantmentResultPanelEnchantmentAgainButton.gameObject.SetActive(true);
			this.m_enchantmentResultPanelSavePropretyButton.gameObject.SetActive(true);
		}

		// Token: 0x0600FC4F RID: 64591 RVA: 0x0042A208 File Offset: 0x00428408
		private void CloseEnchantmentResultPanel(Action succeedEffectEvent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseEnchantmentResultPanelAction_hotfix != null)
			{
				this.m_CloseEnchantmentResultPanelAction_hotfix.call(new object[]
				{
					this,
					succeedEffectEvent2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action succeedEffectEvent = succeedEffectEvent2;
			EquipmentForgeUIController $this = this;
			this.m_enchantmentResultPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				$this.m_enchantmentResultPanelStateCtrl.gameObject.SetActive(false);
				if (succeedEffectEvent != null)
				{
					succeedEffectEvent();
				}
			});
			this.m_enchantmentResultPanelStateCtrl.SetToUIState("Close", false, true);
			this.m_curSelectEnchantStoneItem = null;
			this.UpdateEquipmentForgeView(EquipmentForgeUIController.ForgeState.Enchantment, this.m_slot, this.m_curEquipmentInstanceId);
		}

		// Token: 0x0600FC50 RID: 64592 RVA: 0x0042A2D8 File Offset: 0x004284D8
		private void OnEnchantmentResultSaveButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantmentResultSaveButtonClick_hotfix != null)
			{
				this.m_OnEnchantmentResultSaveButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_playerContext.IsShowEnchantSaveConfirmPanel();
			if (flag)
			{
				this.ShowSavePanel();
			}
			else if (this.EventOnEnchantSaveButtonClick != null)
			{
				this.EventOnEnchantSaveButtonClick(delegate
				{
					this.CloseEnchantmentResultPanel(new Action(this.PlaySucceedEffect));
				});
			}
		}

		// Token: 0x0600FC51 RID: 64593 RVA: 0x0042A378 File Offset: 0x00428578
		private void OnEnchantmentAgainButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantmentAgainButtonClick_hotfix != null)
			{
				this.m_OnEnchantmentAgainButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StopAllCoroutines();
			if (this.m_curSelectEnchantStoneItem == null)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_EnchantStoneNotEnough, 2f, null, true);
				return;
			}
			int num = this.m_playerContext.CanEnchantEquipment(this.m_curEquipmentInstanceId, this.m_curSelectEnchantStoneItem.InstanceId);
			if (num == 0)
			{
				if (this.EventOnEnchantButtonClick != null)
				{
					this.EventOnEnchantButtonClick(this.m_curEquipmentInstanceId, this.m_curSelectEnchantStoneItem.InstanceId, delegate(int id, List<CommonBattleProperty> properties)
					{
						this.ShowEnchantmentResultPanel(id, properties, false);
					});
				}
				int goodsCount = UIUtility.GetGoodsCount(this.m_curSelectEnchantStoneItem.GoodsTypeId, this.m_curSelectEnchantStoneItem.ContentId);
				if (goodsCount == 1)
				{
					this.m_curSelectEnchantStoneItem = null;
				}
				this.SetPlayerResourceGold();
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600FC52 RID: 64594 RVA: 0x0042A4A0 File Offset: 0x004286A0
		private void ShowSavePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSavePanel_hotfix != null)
			{
				this.m_ShowSavePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_savePropretyPanelStateCtrl.gameObject.SetActive(true);
			this.m_savePropretyPanelStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x0600FC53 RID: 64595 RVA: 0x0042A524 File Offset: 0x00428724
		private void CloseSavePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseSavePanel_hotfix != null)
			{
				this.m_CloseSavePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_savePropretyPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_savePropretyPanelStateCtrl.gameObject.SetActive(false);
			});
			this.m_savePropretyPanelStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x0600FC54 RID: 64596 RVA: 0x0042A5B4 File Offset: 0x004287B4
		private void OnSavePanlConfirmClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSavePanlConfirmClick_hotfix != null)
			{
				this.m_OnSavePanlConfirmClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnEnchantSaveButtonClick != null)
			{
				this.EventOnEnchantSaveButtonClick(delegate
				{
					this.CloseSavePanel();
					this.CloseEnchantmentResultPanel(new Action(this.PlaySucceedEffect));
				});
			}
		}

		// Token: 0x0600FC55 RID: 64597 RVA: 0x0042A638 File Offset: 0x00428838
		private void PlaySucceedEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySucceedEffect_hotfix != null)
			{
				this.m_PlaySucceedEffect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.EnableInput(false);
			this.m_enchantKeepPropertyGroup.gameObject.SetActive(true);
			this.m_enchantKeepPropertyGroup.SetActionForUIStateFinshed("Show", delegate
			{
				this.m_enchantKeepPropertyGroup.gameObject.SetActive(false);
			});
			this.m_enchantKeepPropertyGroup.SetToUIState("Show", false, true);
			this.m_enchantSuccessEffectPanel.gameObject.SetActive(true);
			this.m_enchantSuccessEffectPanel.SetActionForUIStateFinshed("Show", delegate
			{
				CommonUIController.Instance.EnableInput(true);
				this.m_enchantSuccessEffectPanel.gameObject.SetActive(false);
			});
			this.m_enchantSuccessEffectPanel.SetToUIState("Show", false, true);
		}

		// Token: 0x0600FC56 RID: 64598 RVA: 0x0042A724 File Offset: 0x00428924
		private void OnCloseEnchantResultPanelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseEnchantResultPanelButtonClick_hotfix != null)
			{
				this.m_OnCloseEnchantResultPanelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_playerContext.IsShowEnchantCancelConfirmPanel();
			if (flag)
			{
				this.ShowCancelPanel();
			}
			else
			{
				this.CloseEnchantmentResultPanel(null);
			}
		}

		// Token: 0x0600FC57 RID: 64599 RVA: 0x0042A7A8 File Offset: 0x004289A8
		private void ShowCancelPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCancelPanel_hotfix != null)
			{
				this.m_ShowCancelPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cancelPanelStateCtrl.gameObject.SetActive(true);
			this.m_cancelPanelStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x0600FC58 RID: 64600 RVA: 0x0042A82C File Offset: 0x00428A2C
		private void CloseCancelPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseCancelPanel_hotfix != null)
			{
				this.m_CloseCancelPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cancelPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_cancelPanelStateCtrl.gameObject.SetActive(false);
			});
			this.m_cancelPanelStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x0600FC59 RID: 64601 RVA: 0x0042A8BC File Offset: 0x00428ABC
		private void OnCancelPanlConfirmClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelPanlConfirmClick_hotfix != null)
			{
				this.m_OnCancelPanlConfirmClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseCancelPanel();
			this.CloseEnchantmentResultPanel(null);
		}

		// Token: 0x0600FC5A RID: 64602 RVA: 0x0042A92C File Offset: 0x00428B2C
		private void OnSavePropertyToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSavePropertyToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSavePropertyToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerContext.SetEnchantSaveConfirmFlag(!isOn);
		}

		// Token: 0x0600FC5B RID: 64603 RVA: 0x0042A9AC File Offset: 0x00428BAC
		private void OnCancelPanelToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelPanelToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnCancelPanelToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerContext.SetEnchantCancelConfirmFlag(!isOn);
		}

		// Token: 0x0600FC5C RID: 64604 RVA: 0x0042AA2C File Offset: 0x00428C2C
		private void OnEnhanceToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnhanceToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnEnhanceToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_isToggleChanged = true;
				this.m_equipmentForgeCtrlList.Clear();
				this.UpdateEquipmentForgeView(EquipmentForgeUIController.ForgeState.Enhance, this.m_slot, this.m_curEquipmentInstanceId);
				this.m_isToggleChanged = false;
			}
		}

		// Token: 0x0600FC5D RID: 64605 RVA: 0x0042AAD0 File Offset: 0x00428CD0
		private void OnBreakToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBreakToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnBreakToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_isToggleChanged = true;
				this.m_equipmentForgeCtrlList.Clear();
				this.UpdateEquipmentForgeView(EquipmentForgeUIController.ForgeState.Break, this.m_slot, this.m_curEquipmentInstanceId);
				this.m_isToggleChanged = false;
			}
		}

		// Token: 0x0600FC5E RID: 64606 RVA: 0x0042AB74 File Offset: 0x00428D74
		private void OnEnchantmentToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantmentToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnEnchantmentToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_isToggleChanged = true;
				this.m_equipmentForgeCtrlList.Clear();
				this.UpdateEquipmentForgeView(EquipmentForgeUIController.ForgeState.Enchantment, this.m_slot, this.m_curEquipmentInstanceId);
				this.m_isToggleChanged = false;
			}
		}

		// Token: 0x0600FC5F RID: 64607 RVA: 0x0042AC18 File Offset: 0x00428E18
		private void OnEnchantLockMaskButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnchantLockMaskButtonClick_hotfix != null)
			{
				this.m_OnEnchantLockMaskButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Enchant))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_Enchant), 2f, null, true);
			}
			else
			{
				this.m_enchantLockMaskButton.gameObject.SetActive(false);
			}
		}

		// Token: 0x0600FC60 RID: 64608 RVA: 0x0042ACB8 File Offset: 0x00428EB8
		private void OnGoldAddButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGoldAddButtonClick_hotfix != null)
			{
				this.m_OnGoldAddButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGoldAddButtonClick != null)
			{
				this.EventOnGoldAddButtonClick(this.m_curEquipmentInstanceId, this.m_slot, this.m_curForgeState);
			}
		}

		// Token: 0x0600FC61 RID: 64609 RVA: 0x0042AD40 File Offset: 0x00428F40
		public void SetPlayerResourceGold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerResourceGold_hotfix != null)
			{
				this.m_SetPlayerResourceGold_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_goldText.text = this.m_playerContext.GetGold().ToString();
		}

		// Token: 0x0600FC62 RID: 64610 RVA: 0x0042ADC4 File Offset: 0x00428FC4
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curEquipmentInstanceId = 0UL;
			this.m_curAddEnhanceEquipmentInstanceId = 0UL;
			this.m_curBreakMaterialEquipmentId = 0UL;
			this.m_enhanceEquipmentInstanceIds.Clear();
			this.m_equipmentForgeCtrlList.Clear();
			this.m_curSelectEnchantStoneItem = null;
			this.m_isToggleChanged = true;
			this.m_isFirstIn = true;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x0600FC63 RID: 64611 RVA: 0x0042AE80 File Offset: 0x00429080
		private void OnHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHelpButtonClick_hotfix != null)
			{
				this.m_OnHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelp != null)
			{
				this.EventOnShowHelp();
			}
		}

		// Token: 0x0600FC64 RID: 64612 RVA: 0x0042AEF8 File Offset: 0x004290F8
		public GameObject GetFirstEquipmentGoInListForUserGuide()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFirstEquipmentGoInListForUserGuide_hotfix != null)
			{
				return (GameObject)this.m_GetFirstEquipmentGoInListForUserGuide_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_loopScrollView.GetFirstGameObjectInViewRect();
		}

		// Token: 0x14000354 RID: 852
		// (add) Token: 0x0600FC65 RID: 64613 RVA: 0x0042AF74 File Offset: 0x00429174
		// (remove) Token: 0x0600FC66 RID: 64614 RVA: 0x0042B010 File Offset: 0x00429210
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000355 RID: 853
		// (add) Token: 0x0600FC67 RID: 64615 RVA: 0x0042B0AC File Offset: 0x004292AC
		// (remove) Token: 0x0600FC68 RID: 64616 RVA: 0x0042B148 File Offset: 0x00429348
		public event Action EventOnShowHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000356 RID: 854
		// (add) Token: 0x0600FC69 RID: 64617 RVA: 0x0042B1E4 File Offset: 0x004293E4
		// (remove) Token: 0x0600FC6A RID: 64618 RVA: 0x0042B280 File Offset: 0x00429480
		public event Action<ulong, int, EquipmentForgeUIController.ForgeState> EventOnGoldAddButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoldAddButtonClickAction`3_hotfix != null)
				{
					this.m_add_EventOnGoldAddButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, EquipmentForgeUIController.ForgeState> action = this.EventOnGoldAddButtonClick;
				Action<ulong, int, EquipmentForgeUIController.ForgeState> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, EquipmentForgeUIController.ForgeState>>(ref this.EventOnGoldAddButtonClick, (Action<ulong, int, EquipmentForgeUIController.ForgeState>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoldAddButtonClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnGoldAddButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, EquipmentForgeUIController.ForgeState> action = this.EventOnGoldAddButtonClick;
				Action<ulong, int, EquipmentForgeUIController.ForgeState> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, EquipmentForgeUIController.ForgeState>>(ref this.EventOnGoldAddButtonClick, (Action<ulong, int, EquipmentForgeUIController.ForgeState>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000357 RID: 855
		// (add) Token: 0x0600FC6B RID: 64619 RVA: 0x0042B31C File Offset: 0x0042951C
		// (remove) Token: 0x0600FC6C RID: 64620 RVA: 0x0042B3B8 File Offset: 0x004295B8
		public event Action<ulong, List<ulong>, Action, int> EventOnEnhanceButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEnhanceButtonClickAction`4_hotfix != null)
				{
					this.m_add_EventOnEnhanceButtonClickAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, List<ulong>, Action, int> action = this.EventOnEnhanceButtonClick;
				Action<ulong, List<ulong>, Action, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, List<ulong>, Action, int>>(ref this.EventOnEnhanceButtonClick, (Action<ulong, List<ulong>, Action, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEnhanceButtonClickAction`4_hotfix != null)
				{
					this.m_remove_EventOnEnhanceButtonClickAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, List<ulong>, Action, int> action = this.EventOnEnhanceButtonClick;
				Action<ulong, List<ulong>, Action, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, List<ulong>, Action, int>>(ref this.EventOnEnhanceButtonClick, (Action<ulong, List<ulong>, Action, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000358 RID: 856
		// (add) Token: 0x0600FC6D RID: 64621 RVA: 0x0042B454 File Offset: 0x00429654
		// (remove) Token: 0x0600FC6E RID: 64622 RVA: 0x0042B4F0 File Offset: 0x004296F0
		public event Action<ulong, ulong, Action, int> EventOnBreakButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBreakButtonClickAction`4_hotfix != null)
				{
					this.m_add_EventOnBreakButtonClickAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, ulong, Action, int> action = this.EventOnBreakButtonClick;
				Action<ulong, ulong, Action, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, ulong, Action, int>>(ref this.EventOnBreakButtonClick, (Action<ulong, ulong, Action, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBreakButtonClickAction`4_hotfix != null)
				{
					this.m_remove_EventOnBreakButtonClickAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, ulong, Action, int> action = this.EventOnBreakButtonClick;
				Action<ulong, ulong, Action, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, ulong, Action, int>>(ref this.EventOnBreakButtonClick, (Action<ulong, ulong, Action, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000359 RID: 857
		// (add) Token: 0x0600FC6F RID: 64623 RVA: 0x0042B58C File Offset: 0x0042978C
		// (remove) Token: 0x0600FC70 RID: 64624 RVA: 0x0042B628 File Offset: 0x00429828
		public event Action<ulong, ulong, Action<int, List<CommonBattleProperty>>> EventOnEnchantButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEnchantButtonClickAction`3_hotfix != null)
				{
					this.m_add_EventOnEnchantButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, ulong, Action<int, List<CommonBattleProperty>>> action = this.EventOnEnchantButtonClick;
				Action<ulong, ulong, Action<int, List<CommonBattleProperty>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, ulong, Action<int, List<CommonBattleProperty>>>>(ref this.EventOnEnchantButtonClick, (Action<ulong, ulong, Action<int, List<CommonBattleProperty>>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEnchantButtonClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnEnchantButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, ulong, Action<int, List<CommonBattleProperty>>> action = this.EventOnEnchantButtonClick;
				Action<ulong, ulong, Action<int, List<CommonBattleProperty>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, ulong, Action<int, List<CommonBattleProperty>>>>(ref this.EventOnEnchantButtonClick, (Action<ulong, ulong, Action<int, List<CommonBattleProperty>>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400035A RID: 858
		// (add) Token: 0x0600FC71 RID: 64625 RVA: 0x0042B6C4 File Offset: 0x004298C4
		// (remove) Token: 0x0600FC72 RID: 64626 RVA: 0x0042B760 File Offset: 0x00429960
		public event Action<GoodsType, int, int> EventOnBreakNeedItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBreakNeedItemClickAction`3_hotfix != null)
				{
					this.m_add_EventOnBreakNeedItemClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnBreakNeedItemClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnBreakNeedItemClick, (Action<GoodsType, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBreakNeedItemClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnBreakNeedItemClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnBreakNeedItemClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnBreakNeedItemClick, (Action<GoodsType, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400035B RID: 859
		// (add) Token: 0x0600FC73 RID: 64627 RVA: 0x0042B7FC File Offset: 0x004299FC
		// (remove) Token: 0x0600FC74 RID: 64628 RVA: 0x0042B898 File Offset: 0x00429A98
		public event Action<Action> EventOnEnchantSaveButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEnchantSaveButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnEnchantSaveButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action> action = this.EventOnEnchantSaveButtonClick;
				Action<Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action>>(ref this.EventOnEnchantSaveButtonClick, (Action<Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEnchantSaveButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnEnchantSaveButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action> action = this.EventOnEnchantSaveButtonClick;
				Action<Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action>>(ref this.EventOnEnchantSaveButtonClick, (Action<Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400035C RID: 860
		// (add) Token: 0x0600FC75 RID: 64629 RVA: 0x0042B934 File Offset: 0x00429B34
		// (remove) Token: 0x0600FC76 RID: 64630 RVA: 0x0042B9D0 File Offset: 0x00429BD0
		public event Action EventOnCrystalNotEnough
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCrystalNotEnoughAction_hotfix != null)
				{
					this.m_add_EventOnCrystalNotEnoughAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCrystalNotEnough;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCrystalNotEnough, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCrystalNotEnoughAction_hotfix != null)
				{
					this.m_remove_EventOnCrystalNotEnoughAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCrystalNotEnough;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCrystalNotEnough, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x0600FC77 RID: 64631 RVA: 0x0042BA6C File Offset: 0x00429C6C
		// (set) Token: 0x0600FC78 RID: 64632 RVA: 0x0042BA8C File Offset: 0x00429C8C
		[DoNotToLua]
		public new EquipmentForgeUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EquipmentForgeUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600FC79 RID: 64633 RVA: 0x0042BA98 File Offset: 0x00429C98
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600FC7A RID: 64634 RVA: 0x0042BAA4 File Offset: 0x00429CA4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600FC7B RID: 64635 RVA: 0x0042BAAC File Offset: 0x00429CAC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600FC7C RID: 64636 RVA: 0x0042BAB4 File Offset: 0x00429CB4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600FC7D RID: 64637 RVA: 0x0042BAC8 File Offset: 0x00429CC8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600FC7E RID: 64638 RVA: 0x0042BAD0 File Offset: 0x00429CD0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600FC7F RID: 64639 RVA: 0x0042BADC File Offset: 0x00429CDC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600FC80 RID: 64640 RVA: 0x0042BAE8 File Offset: 0x00429CE8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600FC81 RID: 64641 RVA: 0x0042BAF4 File Offset: 0x00429CF4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600FC82 RID: 64642 RVA: 0x0042BB00 File Offset: 0x00429D00
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600FC83 RID: 64643 RVA: 0x0042BB0C File Offset: 0x00429D0C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600FC84 RID: 64644 RVA: 0x0042BB18 File Offset: 0x00429D18
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600FC85 RID: 64645 RVA: 0x0042BB24 File Offset: 0x00429D24
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600FC86 RID: 64646 RVA: 0x0042BB30 File Offset: 0x00429D30
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600FC87 RID: 64647 RVA: 0x0042BB3C File Offset: 0x00429D3C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600FC88 RID: 64648 RVA: 0x0042BB44 File Offset: 0x00429D44
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600FC89 RID: 64649 RVA: 0x0042BB64 File Offset: 0x00429D64
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600FC8A RID: 64650 RVA: 0x0042BB70 File Offset: 0x00429D70
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600FC8B RID: 64651 RVA: 0x0042BB90 File Offset: 0x00429D90
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600FC8C RID: 64652 RVA: 0x0042BB9C File Offset: 0x00429D9C
		private void __callDele_EventOnGoldAddButtonClick(ulong arg1, int arg2, EquipmentForgeUIController.ForgeState arg3)
		{
			Action<ulong, int, EquipmentForgeUIController.ForgeState> eventOnGoldAddButtonClick = this.EventOnGoldAddButtonClick;
			if (eventOnGoldAddButtonClick != null)
			{
				eventOnGoldAddButtonClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600FC8D RID: 64653 RVA: 0x0042BBC0 File Offset: 0x00429DC0
		private void __clearDele_EventOnGoldAddButtonClick(ulong arg1, int arg2, EquipmentForgeUIController.ForgeState arg3)
		{
			this.EventOnGoldAddButtonClick = null;
		}

		// Token: 0x0600FC8E RID: 64654 RVA: 0x0042BBCC File Offset: 0x00429DCC
		private void __callDele_EventOnEnhanceButtonClick(ulong arg1, List<ulong> arg2, Action arg3, int arg4)
		{
			Action<ulong, List<ulong>, Action, int> eventOnEnhanceButtonClick = this.EventOnEnhanceButtonClick;
			if (eventOnEnhanceButtonClick != null)
			{
				eventOnEnhanceButtonClick(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x0600FC8F RID: 64655 RVA: 0x0042BBF4 File Offset: 0x00429DF4
		private void __clearDele_EventOnEnhanceButtonClick(ulong arg1, List<ulong> arg2, Action arg3, int arg4)
		{
			this.EventOnEnhanceButtonClick = null;
		}

		// Token: 0x0600FC90 RID: 64656 RVA: 0x0042BC00 File Offset: 0x00429E00
		private void __callDele_EventOnBreakButtonClick(ulong arg1, ulong arg2, Action arg3, int arg4)
		{
			Action<ulong, ulong, Action, int> eventOnBreakButtonClick = this.EventOnBreakButtonClick;
			if (eventOnBreakButtonClick != null)
			{
				eventOnBreakButtonClick(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x0600FC91 RID: 64657 RVA: 0x0042BC28 File Offset: 0x00429E28
		private void __clearDele_EventOnBreakButtonClick(ulong arg1, ulong arg2, Action arg3, int arg4)
		{
			this.EventOnBreakButtonClick = null;
		}

		// Token: 0x0600FC92 RID: 64658 RVA: 0x0042BC34 File Offset: 0x00429E34
		private void __callDele_EventOnEnchantButtonClick(ulong arg1, ulong arg2, Action<int, List<CommonBattleProperty>> arg3)
		{
			Action<ulong, ulong, Action<int, List<CommonBattleProperty>>> eventOnEnchantButtonClick = this.EventOnEnchantButtonClick;
			if (eventOnEnchantButtonClick != null)
			{
				eventOnEnchantButtonClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600FC93 RID: 64659 RVA: 0x0042BC58 File Offset: 0x00429E58
		private void __clearDele_EventOnEnchantButtonClick(ulong arg1, ulong arg2, Action<int, List<CommonBattleProperty>> arg3)
		{
			this.EventOnEnchantButtonClick = null;
		}

		// Token: 0x0600FC94 RID: 64660 RVA: 0x0042BC64 File Offset: 0x00429E64
		private void __callDele_EventOnBreakNeedItemClick(GoodsType arg1, int arg2, int arg3)
		{
			Action<GoodsType, int, int> eventOnBreakNeedItemClick = this.EventOnBreakNeedItemClick;
			if (eventOnBreakNeedItemClick != null)
			{
				eventOnBreakNeedItemClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600FC95 RID: 64661 RVA: 0x0042BC88 File Offset: 0x00429E88
		private void __clearDele_EventOnBreakNeedItemClick(GoodsType arg1, int arg2, int arg3)
		{
			this.EventOnBreakNeedItemClick = null;
		}

		// Token: 0x0600FC96 RID: 64662 RVA: 0x0042BC94 File Offset: 0x00429E94
		private void __callDele_EventOnEnchantSaveButtonClick(Action obj)
		{
			Action<Action> eventOnEnchantSaveButtonClick = this.EventOnEnchantSaveButtonClick;
			if (eventOnEnchantSaveButtonClick != null)
			{
				eventOnEnchantSaveButtonClick(obj);
			}
		}

		// Token: 0x0600FC97 RID: 64663 RVA: 0x0042BCB8 File Offset: 0x00429EB8
		private void __clearDele_EventOnEnchantSaveButtonClick(Action obj)
		{
			this.EventOnEnchantSaveButtonClick = null;
		}

		// Token: 0x0600FC98 RID: 64664 RVA: 0x0042BCC4 File Offset: 0x00429EC4
		private void __callDele_EventOnCrystalNotEnough()
		{
			Action eventOnCrystalNotEnough = this.EventOnCrystalNotEnough;
			if (eventOnCrystalNotEnough != null)
			{
				eventOnCrystalNotEnough();
			}
		}

		// Token: 0x0600FC99 RID: 64665 RVA: 0x0042BCE4 File Offset: 0x00429EE4
		private void __clearDele_EventOnCrystalNotEnough()
		{
			this.EventOnCrystalNotEnough = null;
		}

		// Token: 0x0600FCAE RID: 64686 RVA: 0x0042BF58 File Offset: 0x0042A158
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
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_InitSortTypePanel_hotfix = (luaObj.RawGet("InitSortTypePanel") as LuaFunction);
					this.m_InitLoopScrollRect_hotfix = (luaObj.RawGet("InitLoopScrollRect") as LuaFunction);
					this.m_UpdateEquipmentForgeViewForgeStateInt32UInt64_hotfix = (luaObj.RawGet("UpdateEquipmentForgeView") as LuaFunction);
					this.m_CreateEquipmentList_hotfix = (luaObj.RawGet("CreateEquipmentList") as LuaFunction);
					this.m_SortEquipmentListByTypeList`1_hotfix = (luaObj.RawGet("SortEquipmentListByType") as LuaFunction);
					this.m_DefaultEquipmentItemComparerEquipmentBagItemEquipmentBagItem_hotfix = (luaObj.RawGet("DefaultEquipmentItemComparer") as LuaFunction);
					this.m_CollectEquipmentPropValueAndSortList`1PropertyModifyType_hotfix = (luaObj.RawGet("CollectEquipmentPropValueAndSort") as LuaFunction);
					this.m_OnEquipmentListItemClickUIControllerBase_hotfix = (luaObj.RawGet("OnEquipmentListItemClick") as LuaFunction);
					this.m_OnEquipmentItemClickInEnhanceEquipmentDepotListItemUIController_hotfix = (luaObj.RawGet("OnEquipmentItemClickInEnhance") as LuaFunction);
					this.m_OnEquipmentItemClickInBreakEquipmentDepotListItemUIController_hotfix = (luaObj.RawGet("OnEquipmentItemClickInBreak") as LuaFunction);
					this.m_OnEquipmentItemClickInEnchantmentEquipmentDepotListItemUIController_hotfix = (luaObj.RawGet("OnEquipmentItemClickInEnchantment") as LuaFunction);
					this.m_OnEquipmentListItemNeedFillUIControllerBase_hotfix = (luaObj.RawGet("OnEquipmentListItemNeedFill") as LuaFunction);
					this.m_OnEquipmentListItem3DTouchUIControllerBase_hotfix = (luaObj.RawGet("OnEquipmentListItem3DTouch") as LuaFunction);
					this.m_OnFilterSortButtonClick_hotfix = (luaObj.RawGet("OnFilterSortButtonClick") as LuaFunction);
					this.m_OnEnchantmentFilterSortButtonClick_hotfix = (luaObj.RawGet("OnEnchantmentFilterSortButtonClick") as LuaFunction);
					this.m_OnCloseFilterSortTypeGo_hotfix = (luaObj.RawGet("OnCloseFilterSortTypeGo") as LuaFunction);
					this.m_OnCloseEnchantmentFilterSortTypeGo_hotfix = (luaObj.RawGet("OnCloseEnchantmentFilterSortTypeGo") as LuaFunction);
					this.m_OnFilterSortOrderButtonClick_hotfix = (luaObj.RawGet("OnFilterSortOrderButtonClick") as LuaFunction);
					this.m_OnFilterTypeButtonClickEquipmentSortItemUIControllerBoolean_hotfix = (luaObj.RawGet("OnFilterTypeButtonClick") as LuaFunction);
					this.m_OnEnchantmentFilterTypeButtonClickEquipmentSortItemUIControllerBoolean_hotfix = (luaObj.RawGet("OnEnchantmentFilterTypeButtonClick") as LuaFunction);
					this.m_SetEquipmentItemDescEquipmentBagItem_hotfix = (luaObj.RawGet("SetEquipmentItemDesc") as LuaFunction);
					this.m_SetPropItemColorTextText_hotfix = (luaObj.RawGet("SetPropItemColor") as LuaFunction);
					this.m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix = (luaObj.RawGet("SetPropItems") as LuaFunction);
					this.m_UpdateViewInEnhanceState_hotfix = (luaObj.RawGet("UpdateViewInEnhanceState") as LuaFunction);
					this.m_SetEnhancePropItemsPropertyModifyTypeInt32Int32Int32Int32_hotfix = (luaObj.RawGet("SetEnhancePropItems") as LuaFunction);
					this.m_ResetEnhancePropItemActive_hotfix = (luaObj.RawGet("ResetEnhancePropItemActive") as LuaFunction);
					this.m_CalculateEquipmentEnhanceAddLvByExpEquipmentBagItemInt32Int32_hotfix = (luaObj.RawGet("CalculateEquipmentEnhanceAddLvByExp") as LuaFunction);
					this.m_OnEnhanceButtonClick_hotfix = (luaObj.RawGet("OnEnhanceButtonClick") as LuaFunction);
					this.m_SendEnhanceEquipmentMsg_hotfix = (luaObj.RawGet("SendEnhanceEquipmentMsg") as LuaFunction);
					this.m_OnEnhanceSucceedString_hotfix = (luaObj.RawGet("OnEnhanceSucceed") as LuaFunction);
					this.m_StopEnhanceSucceedEffect_hotfix = (luaObj.RawGet("StopEnhanceSucceedEffect") as LuaFunction);
					this.m_SetSkillLevelUpEffectEquipmentBagItemStringStringInt32_hotfix = (luaObj.RawGet("SetSkillLevelUpEffect") as LuaFunction);
					this.m_DelayActiveIntensifyContinueButton_hotfix = (luaObj.RawGet("DelayActiveIntensifyContinueButton") as LuaFunction);
					this.m_OnIntensifySuccessPanelBlackButtonClick_hotfix = (luaObj.RawGet("OnIntensifySuccessPanelBlackButtonClick") as LuaFunction);
					this.m_ShowEnhanceItemSRConfirmPanel_hotfix = (luaObj.RawGet("ShowEnhanceItemSRConfirmPanel") as LuaFunction);
					this.m_ShowEnhanceItemsConfirmPanel_hotfix = (luaObj.RawGet("ShowEnhanceItemsConfirmPanel") as LuaFunction);
					this.m_OnEnhanceItemSRConfirmButtonClick_hotfix = (luaObj.RawGet("OnEnhanceItemSRConfirmButtonClick") as LuaFunction);
					this.m_OnEnhanceItemSRCancelButtonClick_hotfix = (luaObj.RawGet("OnEnhanceItemSRCancelButtonClick") as LuaFunction);
					this.m_OnEnhanceConfirmButtonClick_hotfix = (luaObj.RawGet("OnEnhanceConfirmButtonClick") as LuaFunction);
					this.m_OnEnhanceCancelButtonClick_hotfix = (luaObj.RawGet("OnEnhanceCancelButtonClick") as LuaFunction);
					this.m_OnEnhanceFastAddButtonClick_hotfix = (luaObj.RawGet("OnEnhanceFastAddButtonClick") as LuaFunction);
					this.m_IsEquipmentAddExpAtMaxLevelMaxExpEquipmentBagItemInt32Int32_hotfix = (luaObj.RawGet("IsEquipmentAddExpAtMaxLevelMaxExp") as LuaFunction);
					this.m_UpdateViewInBreakState_hotfix = (luaObj.RawGet("UpdateViewInBreakState") as LuaFunction);
					this.m_OnBreakButtonClick_hotfix = (luaObj.RawGet("OnBreakButtonClick") as LuaFunction);
					this.m_OnBreakSucceed_hotfix = (luaObj.RawGet("OnBreakSucceed") as LuaFunction);
					this.m_DelayActiveBreakContinueButton_hotfix = (luaObj.RawGet("DelayActiveBreakContinueButton") as LuaFunction);
					this.m_OnBreakSuccessPanelContinueButtonClick_hotfix = (luaObj.RawGet("OnBreakSuccessPanelContinueButtonClick") as LuaFunction);
					this.m_OnEquipmentBreakNeedItemClickGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("OnEquipmentBreakNeedItemClick") as LuaFunction);
					this.m_UpdateViewInEnchantmentState_hotfix = (luaObj.RawGet("UpdateViewInEnchantmentState") as LuaFunction);
					this.m_OnEnchantmentButtonClick_hotfix = (luaObj.RawGet("OnEnchantmentButtonClick") as LuaFunction);
					this.m_ShowEnchantmentResultPanelInt32List`1Boolean_hotfix = (luaObj.RawGet("ShowEnchantmentResultPanel") as LuaFunction);
					this.m_SetEnchantmentResultPanelInfoInt32List`1_hotfix = (luaObj.RawGet("SetEnchantmentResultPanelInfo") as LuaFunction);
					this.m_Co_PlayNewPropertyEffectList`1_hotfix = (luaObj.RawGet("Co_PlayNewPropertyEffect") as LuaFunction);
					this.m_Co_DynamicSetPropertyValueTextImageInt32PropertyModifyType_hotfix = (luaObj.RawGet("Co_DynamicSetPropertyValue") as LuaFunction);
					this.m_CalcPropertyPercentPropertyModifyTypeInt32_hotfix = (luaObj.RawGet("CalcPropertyPercent") as LuaFunction);
					this.m_OnEnchantmentResultPanelContinueButtonClick_hotfix = (luaObj.RawGet("OnEnchantmentResultPanelContinueButtonClick") as LuaFunction);
					this.m_CloseEnchantmentResultPanelAction_hotfix = (luaObj.RawGet("CloseEnchantmentResultPanel") as LuaFunction);
					this.m_OnEnchantmentResultSaveButtonClick_hotfix = (luaObj.RawGet("OnEnchantmentResultSaveButtonClick") as LuaFunction);
					this.m_OnEnchantmentAgainButtonClick_hotfix = (luaObj.RawGet("OnEnchantmentAgainButtonClick") as LuaFunction);
					this.m_ShowSavePanel_hotfix = (luaObj.RawGet("ShowSavePanel") as LuaFunction);
					this.m_CloseSavePanel_hotfix = (luaObj.RawGet("CloseSavePanel") as LuaFunction);
					this.m_OnSavePanlConfirmClick_hotfix = (luaObj.RawGet("OnSavePanlConfirmClick") as LuaFunction);
					this.m_PlaySucceedEffect_hotfix = (luaObj.RawGet("PlaySucceedEffect") as LuaFunction);
					this.m_OnCloseEnchantResultPanelButtonClick_hotfix = (luaObj.RawGet("OnCloseEnchantResultPanelButtonClick") as LuaFunction);
					this.m_ShowCancelPanel_hotfix = (luaObj.RawGet("ShowCancelPanel") as LuaFunction);
					this.m_CloseCancelPanel_hotfix = (luaObj.RawGet("CloseCancelPanel") as LuaFunction);
					this.m_OnCancelPanlConfirmClick_hotfix = (luaObj.RawGet("OnCancelPanlConfirmClick") as LuaFunction);
					this.m_OnSavePropertyToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSavePropertyToggleValueChanged") as LuaFunction);
					this.m_OnCancelPanelToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnCancelPanelToggleValueChanged") as LuaFunction);
					this.m_OnEnhanceToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnEnhanceToggleValueChanged") as LuaFunction);
					this.m_OnBreakToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnBreakToggleValueChanged") as LuaFunction);
					this.m_OnEnchantmentToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnEnchantmentToggleValueChanged") as LuaFunction);
					this.m_OnEnchantLockMaskButtonClick_hotfix = (luaObj.RawGet("OnEnchantLockMaskButtonClick") as LuaFunction);
					this.m_OnGoldAddButtonClick_hotfix = (luaObj.RawGet("OnGoldAddButtonClick") as LuaFunction);
					this.m_SetPlayerResourceGold_hotfix = (luaObj.RawGet("SetPlayerResourceGold") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_GetFirstEquipmentGoInListForUserGuide_hotfix = (luaObj.RawGet("GetFirstEquipmentGoInListForUserGuide") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnGoldAddButtonClickAction`3_hotfix = (luaObj.RawGet("add_EventOnGoldAddButtonClick") as LuaFunction);
					this.m_remove_EventOnGoldAddButtonClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnGoldAddButtonClick") as LuaFunction);
					this.m_add_EventOnEnhanceButtonClickAction`4_hotfix = (luaObj.RawGet("add_EventOnEnhanceButtonClick") as LuaFunction);
					this.m_remove_EventOnEnhanceButtonClickAction`4_hotfix = (luaObj.RawGet("remove_EventOnEnhanceButtonClick") as LuaFunction);
					this.m_add_EventOnBreakButtonClickAction`4_hotfix = (luaObj.RawGet("add_EventOnBreakButtonClick") as LuaFunction);
					this.m_remove_EventOnBreakButtonClickAction`4_hotfix = (luaObj.RawGet("remove_EventOnBreakButtonClick") as LuaFunction);
					this.m_add_EventOnEnchantButtonClickAction`3_hotfix = (luaObj.RawGet("add_EventOnEnchantButtonClick") as LuaFunction);
					this.m_remove_EventOnEnchantButtonClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnEnchantButtonClick") as LuaFunction);
					this.m_add_EventOnBreakNeedItemClickAction`3_hotfix = (luaObj.RawGet("add_EventOnBreakNeedItemClick") as LuaFunction);
					this.m_remove_EventOnBreakNeedItemClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnBreakNeedItemClick") as LuaFunction);
					this.m_add_EventOnEnchantSaveButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnEnchantSaveButtonClick") as LuaFunction);
					this.m_remove_EventOnEnchantSaveButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnEnchantSaveButtonClick") as LuaFunction);
					this.m_add_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("add_EventOnCrystalNotEnough") as LuaFunction);
					this.m_remove_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("remove_EventOnCrystalNotEnough") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600FCAF RID: 64687 RVA: 0x0042C984 File Offset: 0x0042AB84
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentForgeUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040093C7 RID: 37831
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x040093C8 RID: 37832
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x040093C9 RID: 37833
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x040093CA RID: 37834
		[AutoBind("./Margin/FilterToggles/EnhanceToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_enhanceToggle;

		// Token: 0x040093CB RID: 37835
		[AutoBind("./Margin/FilterToggles/BreakToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_breakToggle;

		// Token: 0x040093CC RID: 37836
		[AutoBind("./Margin/FilterToggles/EnchantmentToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_enchantmentToggle;

		// Token: 0x040093CD RID: 37837
		[AutoBind("./Margin/FilterToggles/EnchantmentToggle/EnchantLockMask", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enchantLockMaskButton;

		// Token: 0x040093CE RID: 37838
		[AutoBind("./PlayerResource/Gold/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_goldText;

		// Token: 0x040093CF RID: 37839
		[AutoBind("./PlayerResource/Gold/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_goldAddButton;

		// Token: 0x040093D0 RID: 37840
		[AutoBind("./EquipmentList/ListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private LoopVerticalScrollRect m_loopScrollView;

		// Token: 0x040093D1 RID: 37841
		[AutoBind("./EquipmentList/ListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private EasyObjectPool m_listItemPool;

		// Token: 0x040093D2 RID: 37842
		[AutoBind("./EquipmentList/ListScrollView/ItemRoot", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_listScrollViewItemRoot;

		// Token: 0x040093D3 RID: 37843
		[AutoBind("./EquipmentList/EnchantmentFilter", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enchantmentFilter;

		// Token: 0x040093D4 RID: 37844
		[AutoBind("./EquipmentList/EnchantmentFilter/SortButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enchantmentfilterSortButton;

		// Token: 0x040093D5 RID: 37845
		[AutoBind("./EquipmentList/EnchantmentFilter/SortButton/SortTypeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentfilterSortTypeText;

		// Token: 0x040093D6 RID: 37846
		[AutoBind("./EquipmentList/EnchantmentFilter/SortTypes", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enchantmentfilterSortTypesGo;

		// Token: 0x040093D7 RID: 37847
		[AutoBind("./EquipmentList/EnchantmentFilter/SortTypes/GridLayout", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enchantmentfilterSortTypesGridLayout;

		// Token: 0x040093D8 RID: 37848
		[AutoBind("./EquipmentList/EnchantmentFilter/SortTypes/AllButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enchantmentfilterSortTypesAllToggle;

		// Token: 0x040093D9 RID: 37849
		[AutoBind("./EquipmentList/EnhanceAndBreakFilter", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhanceAndBreakFilter;

		// Token: 0x040093DA RID: 37850
		[AutoBind("./EquipmentList/EnhanceAndBreakFilter/SortButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_filterSortButton;

		// Token: 0x040093DB RID: 37851
		[AutoBind("./EquipmentList/EnhanceAndBreakFilter/SortButton/SortTypeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_filterSortTypeText;

		// Token: 0x040093DC RID: 37852
		[AutoBind("./EquipmentList/EnhanceAndBreakFilter/SortOrderButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_filterSortOrderButton;

		// Token: 0x040093DD RID: 37853
		[AutoBind("./EquipmentList/EnhanceAndBreakFilter/SortTypes", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_filterSortTypesGo;

		// Token: 0x040093DE RID: 37854
		[AutoBind("./EquipmentList/EnhanceAndBreakFilter/SortTypes/GridLayout", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_filterSortTypesGridLayout;

		// Token: 0x040093DF RID: 37855
		[AutoBind("./EquipmentList/NotBreakItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_listNoBreakItemGo;

		// Token: 0x040093E0 RID: 37856
		[AutoBind("./EquipmentList/NoEnchantmentText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_listNoEnchantmentItemGo;

		// Token: 0x040093E1 RID: 37857
		[AutoBind("./EquipmentList/Title", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_listTitleStateCtrl;

		// Token: 0x040093E2 RID: 37858
		[AutoBind("./EquipmentList/Text", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_listLongPressTipGo;

		// Token: 0x040093E3 RID: 37859
		[AutoBind("./Desc", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descGo;

		// Token: 0x040093E4 RID: 37860
		[AutoBind("./Desc/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descTitleText;

		// Token: 0x040093E5 RID: 37861
		[AutoBind("./Desc/Lay/FrameImage/Top/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_descIcon;

		// Token: 0x040093E6 RID: 37862
		[AutoBind("./Desc/Lay/FrameImage/Top/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_descIconBg;

		// Token: 0x040093E7 RID: 37863
		[AutoBind("./Desc/Lay/FrameImage/Top/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descSSREffect;

		// Token: 0x040093E8 RID: 37864
		[AutoBind("./Desc/Lay/FrameImage/Top/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descStarGroup;

		// Token: 0x040093E9 RID: 37865
		[AutoBind("./Desc/Lay/FrameImage/Top/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descLvText;

		// Token: 0x040093EA RID: 37866
		[AutoBind("./Desc/Lay/FrameImage/Top/ExpText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descExpText;

		// Token: 0x040093EB RID: 37867
		[AutoBind("./Desc/Lay/FrameImage/Top/ProgressImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_descProgressImage;

		// Token: 0x040093EC RID: 37868
		[AutoBind("./Desc/Lay/FrameImage/Top/EquipLimitContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descEquipLimitContent;

		// Token: 0x040093ED RID: 37869
		[AutoBind("./Desc/Lay/FrameImage/Top/EquipUnlimitText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descEquipUnlimitText;

		// Token: 0x040093EE RID: 37870
		[AutoBind("./Desc/Lay/FrameImage/Button/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descSkillContent;

		// Token: 0x040093EF RID: 37871
		[AutoBind("./Desc/Lay/FrameImage/Button/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_descSkillContentStateCtrl;

		// Token: 0x040093F0 RID: 37872
		[AutoBind("./Desc/Lay/FrameImage/Button/SkillContent/Top/UnlockCoditionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descUnlockCoditionText;

		// Token: 0x040093F1 RID: 37873
		[AutoBind("./Desc/Lay/FrameImage/Button/SkillContent/Top/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descSkillNameText;

		// Token: 0x040093F2 RID: 37874
		[AutoBind("./Desc/Lay/FrameImage/Button/SkillContent/Top/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descSkillLvText;

		// Token: 0x040093F3 RID: 37875
		[AutoBind("./Desc/Lay/FrameImage/Button/SkillContent/Top/Owner", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descSkillOwnerText;

		// Token: 0x040093F4 RID: 37876
		[AutoBind("./Desc/Lay/FrameImage/Button/SkillContent/Top/BelongBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descSkillOwnerBGImage;

		// Token: 0x040093F5 RID: 37877
		[AutoBind("./Desc/Lay/FrameImage/Button/SkillContent/Desc", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descSkillDescText;

		// Token: 0x040093F6 RID: 37878
		[AutoBind("./Desc/Lay/FrameImage/Button/NotEquipSkillTip", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descNotEquipSkillTip;

		// Token: 0x040093F7 RID: 37879
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropContent;

		// Token: 0x040093F8 RID: 37880
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/AT", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropATGo;

		// Token: 0x040093F9 RID: 37881
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropATValueText;

		// Token: 0x040093FA RID: 37882
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/DF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropDFGo;

		// Token: 0x040093FB RID: 37883
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropDFValueText;

		// Token: 0x040093FC RID: 37884
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/HP", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropHPGo;

		// Token: 0x040093FD RID: 37885
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropHPValueText;

		// Token: 0x040093FE RID: 37886
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropMagiccGo;

		// Token: 0x040093FF RID: 37887
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/Magic/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropMagicValueText;

		// Token: 0x04009400 RID: 37888
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/MagicDF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropMagicDFGo;

		// Token: 0x04009401 RID: 37889
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropMagicDFValueText;

		// Token: 0x04009402 RID: 37890
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/Dex", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropDexGo;

		// Token: 0x04009403 RID: 37891
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/PropContent/Dex/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropDexValueText;

		// Token: 0x04009404 RID: 37892
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_descPropGroupStateCtrl;

		// Token: 0x04009405 RID: 37893
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/EnchantmentGroup/PropertyGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropEnchantmentGroup;

		// Token: 0x04009406 RID: 37894
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/EnchantmentGroup/Resonance", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_descPropEnchantmentGroupRuneStateCtrl;

		// Token: 0x04009407 RID: 37895
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/EnchantmentGroup/Resonance/RuneIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_descPropEnchantmentGroupRuneIconImage;

		// Token: 0x04009408 RID: 37896
		[AutoBind("./Desc/Lay/FrameImage/Top/PropGroup/EnchantmentGroup/Resonance/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropEnchantmentGroupRuneNameText;

		// Token: 0x04009409 RID: 37897
		[AutoBind("./EquipmentInfo/EquipmentEnhance/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceTitleText;

		// Token: 0x0400940A RID: 37898
		[AutoBind("./EquipmentInfo/EquipmentEnhance/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enhanceIcon;

		// Token: 0x0400940B RID: 37899
		[AutoBind("./EquipmentInfo/EquipmentEnhance/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enhanceIconBg;

		// Token: 0x0400940C RID: 37900
		[AutoBind("./EquipmentInfo/EquipmentEnhance/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhanceIconSSREffect;

		// Token: 0x0400940D RID: 37901
		[AutoBind("./EquipmentInfo/EquipmentEnhance/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhanceStarGroup;

		// Token: 0x0400940E RID: 37902
		[AutoBind("./EquipmentInfo/EquipmentEnhance/ProgressGroup/Lv/CurLv", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceCurLv;

		// Token: 0x0400940F RID: 37903
		[AutoBind("./EquipmentInfo/EquipmentEnhance/ProgressGroup/Lv/CurLv1", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceCurLv1;

		// Token: 0x04009410 RID: 37904
		[AutoBind("./EquipmentInfo/EquipmentEnhance/ProgressGroup/Lv/MaxLV", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceMaxLV;

		// Token: 0x04009411 RID: 37905
		[AutoBind("./EquipmentInfo/EquipmentEnhance/ProgressGroup/ProgressImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enhanceProgressImage;

		// Token: 0x04009412 RID: 37906
		[AutoBind("./EquipmentInfo/EquipmentEnhance/ProgressGroup/WillGetExpImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enhanceWillGetExpImage;

		// Token: 0x04009413 RID: 37907
		[AutoBind("./EquipmentInfo/EquipmentEnhance/ExpValueText/CurValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceExpCurValueText;

		// Token: 0x04009414 RID: 37908
		[AutoBind("./EquipmentInfo/EquipmentEnhance/ExpValueText/AddValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceExpAddValueText;

		// Token: 0x04009415 RID: 37909
		[AutoBind("./EquipmentInfo/EquipmentEnhance/ExpValueText/NextLvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceExpNextLvText;

		// Token: 0x04009416 RID: 37910
		[AutoBind("./EquipmentInfo/EquipmentEnhance/MaterialsContent/MaterialsGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhanceMaterialsContent;

		// Token: 0x04009417 RID: 37911
		[AutoBind("./EquipmentInfo/EquipmentEnhance/EnhanceGold/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceGoldText;

		// Token: 0x04009418 RID: 37912
		[AutoBind("./EquipmentInfo/EquipmentEnhance/EnhanceButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enhanceButton;

		// Token: 0x04009419 RID: 37913
		[AutoBind("./EnhanceSuccessEffectPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhanceSuccessEffectPanel;

		// Token: 0x0400941A RID: 37914
		[AutoBind("./EnhanceSuccessEffectPanel/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enhanceSuccessEffectPanelCloseButton;

		// Token: 0x0400941B RID: 37915
		[AutoBind("./ConfirmPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhanceConfirmPanel;

		// Token: 0x0400941C RID: 37916
		[AutoBind("./ConfirmPanel/Detail/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enhanceConfirmButton;

		// Token: 0x0400941D RID: 37917
		[AutoBind("./ConfirmPanel/Detail/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enhanceCancelButton;

		// Token: 0x0400941E RID: 37918
		[AutoBind("./ConfirmPanel/Detail/Tip1", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceConfirmPanelTip1;

		// Token: 0x0400941F RID: 37919
		[AutoBind("./ConfirmPanel/Detail/Tip2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceConfirmPanelTip2;

		// Token: 0x04009420 RID: 37920
		[AutoBind("./EnhaneConfirmPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhanceItemSRConfirmPanel;

		// Token: 0x04009421 RID: 37921
		[AutoBind("./EnhaneConfirmPanel/Detail/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enhanceItemSRConfirmButton;

		// Token: 0x04009422 RID: 37922
		[AutoBind("./EnhaneConfirmPanel/Detail/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enhanceItemSRCancelButton;

		// Token: 0x04009423 RID: 37923
		[AutoBind("./EnhaneConfirmPanel/Detail/Tip2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhanceItemSRTip;

		// Token: 0x04009424 RID: 37924
		[AutoBind("./IntensifySuccessPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_intensifySuccessPanelStateCtrl;

		// Token: 0x04009425 RID: 37925
		[AutoBind("./IntensifySuccessPanel/BreakInfoGroup/LvGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_intensifySuccessPanelInfoStateCtrl;

		// Token: 0x04009426 RID: 37926
		[AutoBind("./IntensifySuccessPanel/BreakInfoGroup/Equipment/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_intensifySuccessPanelInfoIconBg;

		// Token: 0x04009427 RID: 37927
		[AutoBind("./IntensifySuccessPanel/BreakInfoGroup/Equipment/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_intensifySuccessPanelInfoIcon;

		// Token: 0x04009428 RID: 37928
		[AutoBind("./IntensifySuccessPanel/BreakInfoGroup/Equipment/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_intensifySuccessPanelInfoStarGroup;

		// Token: 0x04009429 RID: 37929
		[AutoBind("./IntensifySuccessPanel/BreakInfoGroup/LvGroup/CurLvGroup/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_intensifySuccessPanelCurLvText;

		// Token: 0x0400942A RID: 37930
		[AutoBind("./IntensifySuccessPanel/BreakInfoGroup/LvGroup/NextLvGroup/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_intensifySuccessPanelNextLvText;

		// Token: 0x0400942B RID: 37931
		[AutoBind("./IntensifySuccessPanel/BreakInfoGroup/LvGroup/SkillNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_intensifySuccessPanelSkillNameText;

		// Token: 0x0400942C RID: 37932
		[AutoBind("./IntensifySuccessPanel/BreakInfoGroup/DescTextScrollView/Mask/Content/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_intensifySuccessPanelSkillDescText;

		// Token: 0x0400942D RID: 37933
		[AutoBind("./IntensifySuccessPanel/BlackButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_intensifySuccessPanelBlackButton;

		// Token: 0x0400942E RID: 37934
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhancePropGroupGo;

		// Token: 0x0400942F RID: 37935
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/HP", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhancePropHpGo;

		// Token: 0x04009430 RID: 37936
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/HP/OldValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropHpOldValueText;

		// Token: 0x04009431 RID: 37937
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/HP/NewValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropHpNewValueText;

		// Token: 0x04009432 RID: 37938
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/AT", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhancePropATGo;

		// Token: 0x04009433 RID: 37939
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/AT/OldValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropATOldValueText;

		// Token: 0x04009434 RID: 37940
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/AT/NewValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropATNewValueText;

		// Token: 0x04009435 RID: 37941
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/DF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhancePropDFGo;

		// Token: 0x04009436 RID: 37942
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/DF/OldValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropDFOldValueText;

		// Token: 0x04009437 RID: 37943
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/DF/NewValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropDFNewValueText;

		// Token: 0x04009438 RID: 37944
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhancePropMagicGo;

		// Token: 0x04009439 RID: 37945
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/Magic/OldValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropMagicOldValueText;

		// Token: 0x0400943A RID: 37946
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/Magic/NewValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropMagicNewValueText;

		// Token: 0x0400943B RID: 37947
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/MagicDF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhancePropMagicDFGo;

		// Token: 0x0400943C RID: 37948
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/MagicDF/OldValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropMagicDFOldValueText;

		// Token: 0x0400943D RID: 37949
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/MagicDF/NewValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropMagicDFNewValueText;

		// Token: 0x0400943E RID: 37950
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/DEX", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enhancePropDEXGo;

		// Token: 0x0400943F RID: 37951
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/DEX/OldValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropDEXOldValueText;

		// Token: 0x04009440 RID: 37952
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/PropGroup/DEX/NewValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropDEXNewValueText;

		// Token: 0x04009441 RID: 37953
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/SkillGroup/SkillChangeItem", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enhancePropSkillStateCtrl;

		// Token: 0x04009442 RID: 37954
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/SkillGroup/SkillChangeItem/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropSkillNameText;

		// Token: 0x04009443 RID: 37955
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/SkillGroup/SkillChangeItem/OldValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropSkillOldValueText;

		// Token: 0x04009444 RID: 37956
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/SkillGroup/SkillChangeItem/NewValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropSkillNewValueText;

		// Token: 0x04009445 RID: 37957
		[AutoBind("./EquipmentInfo/EquipmentEnhance/PropContent/SkillGroup/SkillChangeItem/ConditionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enhancePropSkillConditionText;

		// Token: 0x04009446 RID: 37958
		[AutoBind("./EquipmentInfo/EquipmentEnhance/FastAddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enhanceFastAddButton;

		// Token: 0x04009447 RID: 37959
		[AutoBind("./EquipmentInfo/EquipmentBreak", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakGo;

		// Token: 0x04009448 RID: 37960
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakTitleText;

		// Token: 0x04009449 RID: 37961
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/CurLvEquipment/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakCurLvEquipmentIcon;

		// Token: 0x0400944A RID: 37962
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/CurLvEquipment/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakCurLvEquipmentIconBg;

		// Token: 0x0400944B RID: 37963
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/CurLvEquipment/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakCurLvEquipmentIconSSREffect;

		// Token: 0x0400944C RID: 37964
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/CurLvEquipment/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakCurLvEquipmentStarGroup;

		// Token: 0x0400944D RID: 37965
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/CurLvEquipment/LvGroup/OldLvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakCurLvEquipmentOldLvText;

		// Token: 0x0400944E RID: 37966
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/CurLvEquipment/LvGroup/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakCurLvEquipmentMaxLvText;

		// Token: 0x0400944F RID: 37967
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/NextLvEquipment/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakNextLvEquipmentIcon;

		// Token: 0x04009450 RID: 37968
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/NextLvEquipment/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakNextLvEquipmentIconBg;

		// Token: 0x04009451 RID: 37969
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/NextLvEquipment/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakNextLvEquipmentIconSSREffect;

		// Token: 0x04009452 RID: 37970
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/NextLvEquipment/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakNextLvEquipmentStarGroup;

		// Token: 0x04009453 RID: 37971
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/NextLvEquipment/LvGroup/OldLvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakNextLvEquipmentOldLvText;

		// Token: 0x04009454 RID: 37972
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/NextLvEquipment/LvGroup/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakNextLvEquipmentMaxLvText;

		// Token: 0x04009455 RID: 37973
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/MaterialIcon", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakMaterialIconGo;

		// Token: 0x04009456 RID: 37974
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/MaterialIcon/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakMaterialIcon;

		// Token: 0x04009457 RID: 37975
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/MaterialIcon/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakMaterialIconBg;

		// Token: 0x04009458 RID: 37976
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/MaterialIcon/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakMaterialSSREffect;

		// Token: 0x04009459 RID: 37977
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/ItemsContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakItemsContent;

		// Token: 0x0400945A RID: 37978
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/BreakGold/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakGoldText;

		// Token: 0x0400945B RID: 37979
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanBreak/BreakButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_breakButton;

		// Token: 0x0400945C RID: 37980
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanNotBreak/CurLvEquipment/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakCantIcon;

		// Token: 0x0400945D RID: 37981
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanNotBreak/CurLvEquipment/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakCantIconBg;

		// Token: 0x0400945E RID: 37982
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanNotBreak/CurLvEquipment/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakCantStarGroup;

		// Token: 0x0400945F RID: 37983
		[AutoBind("./EquipmentInfo/EquipmentBreak/CanNotBreak/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakCantTitleText;

		// Token: 0x04009460 RID: 37984
		[AutoBind("./BreakSuccessPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakSuccessPanel;

		// Token: 0x04009461 RID: 37985
		[AutoBind("./BreakSuccessPanel/BlackButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_breakSuccessPanelBlackButton;

		// Token: 0x04009462 RID: 37986
		[AutoBind("./BreakSuccessPanel/BreakInfoGroup/Equipment/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakSuccessInfoIconBg;

		// Token: 0x04009463 RID: 37987
		[AutoBind("./BreakSuccessPanel/BreakInfoGroup/Equipment/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakSuccessInfoIcon;

		// Token: 0x04009464 RID: 37988
		[AutoBind("./BreakSuccessPanel/BreakInfoGroup/Equipment/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakSuccessInfoStarGroup;

		// Token: 0x04009465 RID: 37989
		[AutoBind("./BreakSuccessPanel/BreakInfoGroup/LvGroup/CurLvGroup/OldLvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakSuccessInfoCurOldLvText;

		// Token: 0x04009466 RID: 37990
		[AutoBind("./BreakSuccessPanel/BreakInfoGroup/LvGroup/CurLvGroup/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakSuccessInfoCurMaxLvText;

		// Token: 0x04009467 RID: 37991
		[AutoBind("./BreakSuccessPanel/BreakInfoGroup/LvGroup/NextLvGroup/OldLvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakSuccessInfoNextOldLvText;

		// Token: 0x04009468 RID: 37992
		[AutoBind("./BreakSuccessPanel/BreakInfoGroup/LvGroup/NextLvGroup/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakSuccessInfoNextMaxLvText;

		// Token: 0x04009469 RID: 37993
		[AutoBind("./EquipmentInfo/Enchantment/ItemNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentItemNameText;

		// Token: 0x0400946A RID: 37994
		[AutoBind("./EquipmentInfo/Enchantment/LevelGroup/LevelValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentItemLevelValueText;

		// Token: 0x0400946B RID: 37995
		[AutoBind("./EquipmentInfo/Enchantment/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentIcon;

		// Token: 0x0400946C RID: 37996
		[AutoBind("./EquipmentInfo/Enchantment/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentIconBg;

		// Token: 0x0400946D RID: 37997
		[AutoBind("./EquipmentInfo/Enchantment/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enchantmentIconSSREffect;

		// Token: 0x0400946E RID: 37998
		[AutoBind("./EquipmentInfo/Enchantment/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enchantmentStarGroup;

		// Token: 0x0400946F RID: 37999
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/EnchantPropertyGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enchantmentEnchantPropertyGroup;

		// Token: 0x04009470 RID: 38000
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/EnchantPropertyGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentEnchantPropertyGroupStateCtrl;

		// Token: 0x04009471 RID: 38001
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentSuitInfoStateCtrl;

		// Token: 0x04009472 RID: 38002
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentSuitInfoGroupStateCtrl;

		// Token: 0x04009473 RID: 38003
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/NowEffect", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentSuitInfoNowEffectStateCtrl;

		// Token: 0x04009474 RID: 38004
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/NowEffect/RuneIcon", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentSuitInfoNowEffectRuneIconStateCtrl;

		// Token: 0x04009475 RID: 38005
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/NowEffect/RuneIcon/Active", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentSuitInfoNowEffectRuneActiveIcon;

		// Token: 0x04009476 RID: 38006
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/NowEffect/RuneIcon/Unactive", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentSuitInfoNowEffectRuneUnactiveIcon;

		// Token: 0x04009477 RID: 38007
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/NowEffect/EffectTitleText/EffectNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentSuitInfoNowEffectRuneNameText;

		// Token: 0x04009478 RID: 38008
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/NowEffect/SuitInfoGroup/2Suit/2SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentSuitInfoNowEffectRune2SuitInfoText;

		// Token: 0x04009479 RID: 38009
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/NowEffect/SuitInfoGroup/4Suit/4SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentSuitInfoNowEffectRune4SuitInfoText;

		// Token: 0x0400947A RID: 38010
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/AfterEffect", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentSuitInfoAfterEffectStateCtrl;

		// Token: 0x0400947B RID: 38011
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/AfterEffect/RuneIcon/Unactive", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon;

		// Token: 0x0400947C RID: 38012
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/AfterEffect/EffectTitleText/EffectNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentSuitInfoAfterEffectRuneNameText;

		// Token: 0x0400947D RID: 38013
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/AfterEffect/SuitInfoGroup/2Suit/2SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentSuitInfoAfterEffectRune2SuitInfoText;

		// Token: 0x0400947E RID: 38014
		[AutoBind("./EquipmentInfo/Enchantment/ItemPropertyGroup/SuitInfo/InfoGroup/AfterEffect/SuitInfoGroup/4Suit/4SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentSuitInfoAfterEffectRune4SuitInfoText;

		// Token: 0x0400947F RID: 38015
		[AutoBind("./EquipmentInfo/Enchantment/MaterialGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentMaterialGroupStateCtrl;

		// Token: 0x04009480 RID: 38016
		[AutoBind("./EquipmentInfo/Enchantment/MaterialGroup/ItemIcon/IconBG", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentStoneIconBg;

		// Token: 0x04009481 RID: 38017
		[AutoBind("./EquipmentInfo/Enchantment/MaterialGroup/ItemIcon/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentStoneIcon;

		// Token: 0x04009482 RID: 38018
		[AutoBind("./EquipmentInfo/Enchantment/MaterialGroup/StoneNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentStoneNameText;

		// Token: 0x04009483 RID: 38019
		[AutoBind("./EquipmentInfo/Enchantment/MaterialGroup/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentStoneDescText;

		// Token: 0x04009484 RID: 38020
		[AutoBind("./EquipmentInfo/Enchantment/MaterialGroup/ItemIcon/ValueGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentStoneValueGroupStateCtrl;

		// Token: 0x04009485 RID: 38021
		[AutoBind("./EquipmentInfo/Enchantment/MaterialGroup/ItemIcon/ValueGroup/HaveCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentStoneHaveCount;

		// Token: 0x04009486 RID: 38022
		[AutoBind("./EquipmentInfo/Enchantment/GoldenValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentGoldenValueText;

		// Token: 0x04009487 RID: 38023
		[AutoBind("./EquipmentInfo/Enchantment/GoldenValueText", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentGoldenValueTextStateCtrl;

		// Token: 0x04009488 RID: 38024
		[AutoBind("./EquipmentInfo/Enchantment/EnchantmentButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enchantmentButton;

		// Token: 0x04009489 RID: 38025
		[AutoBind("./EquipmentInfo/Enchantment/KeepPropertyGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantKeepPropertyGroup;

		// Token: 0x0400948A RID: 38026
		[AutoBind("./EquipmentInfo/Enchantment/EnchantSuccessEffectPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantSuccessEffectPanel;

		// Token: 0x0400948B RID: 38027
		[AutoBind("./EnchantmentResultPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentResultPanelStateCtrl;

		// Token: 0x0400948C RID: 38028
		[AutoBind("./EnchantmentResultPanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enchantmentResultPanelCloseButton;

		// Token: 0x0400948D RID: 38029
		[AutoBind("./EnchantmentResultPanel/Detail/OldPropretyGroup/PropretyGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enchantmentResultPanelOldPropretyGroup;

		// Token: 0x0400948E RID: 38030
		[AutoBind("./EnchantmentResultPanel/Detail/OldPropretyGroup/SuitInfoGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentResultPanelOldSuitInfoStateCtrl;

		// Token: 0x0400948F RID: 38031
		[AutoBind("./EnchantmentResultPanel/Detail/OldPropretyGroup/SuitInfoGroup/EffectTitleText/EffectNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelOldSuitInfoNameText;

		// Token: 0x04009490 RID: 38032
		[AutoBind("./EnchantmentResultPanel/Detail/OldPropretyGroup/SuitInfoGroup/2Suit/2SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelOld2SuitInfoText;

		// Token: 0x04009491 RID: 38033
		[AutoBind("./EnchantmentResultPanel/Detail/OldPropretyGroup/SuitInfoGroup/4Suit/4SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelOld4SuitInfoText;

		// Token: 0x04009492 RID: 38034
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety1", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentResultPanelNewProprety1StateCtrl;

		// Token: 0x04009493 RID: 38035
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety1/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentResultPanelNewProprety1ProgressBar;

		// Token: 0x04009494 RID: 38036
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety1/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelNewProprety1NameText;

		// Token: 0x04009495 RID: 38037
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety1/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelNewProprety1ValueText;

		// Token: 0x04009496 RID: 38038
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety2", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentResultPanelNewProprety2StateCtrl;

		// Token: 0x04009497 RID: 38039
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety2/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentResultPanelNewProprety2ProgressBar;

		// Token: 0x04009498 RID: 38040
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety2/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelNewProprety2NameText;

		// Token: 0x04009499 RID: 38041
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety2/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelNewProprety2ValueText;

		// Token: 0x0400949A RID: 38042
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety3", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentResultPanelNewProprety3StateCtrl;

		// Token: 0x0400949B RID: 38043
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety3/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentResultPanelNewProprety3ProgressBar;

		// Token: 0x0400949C RID: 38044
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety3/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelNewProprety3NameText;

		// Token: 0x0400949D RID: 38045
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/PropretyGroup/Proprety3/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelNewProprety3ValueText;

		// Token: 0x0400949E RID: 38046
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/SuitInfoGroup/EffectTitleText/EffectNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelNewSuitInfoNameText;

		// Token: 0x0400949F RID: 38047
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/SuitInfoGroup/2Suit/2SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelNew2SuitInfoText;

		// Token: 0x040094A0 RID: 38048
		[AutoBind("./EnchantmentResultPanel/Detail/NewPropretyGroup/SuitInfoGroup/4Suit/4SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelNew4SuitInfoText;

		// Token: 0x040094A1 RID: 38049
		[AutoBind("./EnchantmentResultPanel/Detail/EnchantmentAgain/EnchantmentButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enchantmentResultPanelEnchantmentAgainButton;

		// Token: 0x040094A2 RID: 38050
		[AutoBind("./EnchantmentResultPanel/Detail/EnchantmentAgain/EnchantmentButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl;

		// Token: 0x040094A3 RID: 38051
		[AutoBind("./EnchantmentResultPanel/Detail/EnchantmentAgain/ItemNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelNumberText;

		// Token: 0x040094A4 RID: 38052
		[AutoBind("./EnchantmentResultPanel/Detail/EnchantmentAgain/GoldenNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enchantmentResultPanelGoldenNumberText;

		// Token: 0x040094A5 RID: 38053
		[AutoBind("./EnchantmentResultPanel/Detail/EnchantmentAgain/GoldenNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enchantmentResultPanelGoldenNumberStateCtrl;

		// Token: 0x040094A6 RID: 38054
		[AutoBind("./EnchantmentResultPanel/Detail/EnchantmentAgain/ItemImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_enchantmentResultPanelItemImage;

		// Token: 0x040094A7 RID: 38055
		[AutoBind("./EnchantmentResultPanel/Detail/SaveProprety/SavePropretyButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enchantmentResultPanelSavePropretyButton;

		// Token: 0x040094A8 RID: 38056
		[AutoBind("./EnchantmentResultPanel/ContinueButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enchantmentResultPanelContinueButton;

		// Token: 0x040094A9 RID: 38057
		[AutoBind("./SavePropretyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_savePropretyPanelStateCtrl;

		// Token: 0x040094AA RID: 38058
		[AutoBind("./SavePropretyPanel/Detail/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_savePropretyPanelCancelButton;

		// Token: 0x040094AB RID: 38059
		[AutoBind("./SavePropretyPanel/Detail/ComfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_savePropretyPanelComfirmButton;

		// Token: 0x040094AC RID: 38060
		[AutoBind("./SavePropretyPanel/Detail/ToggleGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_savePropretyPanelToggle;

		// Token: 0x040094AD RID: 38061
		[AutoBind("./CancelPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_cancelPanelStateCtrl;

		// Token: 0x040094AE RID: 38062
		[AutoBind("./CancelPanel/Detail/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cancelPanelCancelButton;

		// Token: 0x040094AF RID: 38063
		[AutoBind("./CancelPanel/Detail/ComfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cancelPanelComfirmButton;

		// Token: 0x040094B0 RID: 38064
		[AutoBind("./CancelPanel/Detail/ToggleGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_cancelPanelToggle;

		// Token: 0x040094B1 RID: 38065
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040094B2 RID: 38066
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040094B3 RID: 38067
		private int m_slot;

		// Token: 0x040094B4 RID: 38068
		private int m_isAscend = -1;

		// Token: 0x040094B5 RID: 38069
		private bool m_isFirstIn = true;

		// Token: 0x040094B6 RID: 38070
		private bool m_isToggleChanged;

		// Token: 0x040094B7 RID: 38071
		private EquipmentForgeUIController.ForgeState m_curForgeState;

		// Token: 0x040094B8 RID: 38072
		private ulong m_curEquipmentInstanceId;

		// Token: 0x040094B9 RID: 38073
		private ulong m_curBreakMaterialEquipmentId;

		// Token: 0x040094BA RID: 38074
		private ulong m_curAddEnhanceEquipmentInstanceId;

		// Token: 0x040094BB RID: 38075
		private BagItemBase m_curSelectEnchantStoneItem;

		// Token: 0x040094BC RID: 38076
		private ConfigDataEnchantStoneInfo m_lastSelectEnchantStoneInfo;

		// Token: 0x040094BD RID: 38077
		private List<ulong> m_enhanceEquipmentInstanceIds = new List<ulong>();

		// Token: 0x040094BE RID: 38078
		private List<EquipmentBagItem> m_equipmentItemCache = new List<EquipmentBagItem>();

		// Token: 0x040094BF RID: 38079
		private List<EnchantStoneBagItem> m_enchantStoneItemCache = new List<EnchantStoneBagItem>();

		// Token: 0x040094C0 RID: 38080
		private List<EquipmentDepotListItemUIController> m_equipmentForgeCtrlList = new List<EquipmentDepotListItemUIController>();

		// Token: 0x040094C1 RID: 38081
		private EquipmentDepotUIController.EquipmentSortTypeState m_curEquipmentSortType = EquipmentDepotUIController.EquipmentSortTypeState.Rank;

		// Token: 0x040094C2 RID: 38082
		private int m_curEnchantmentSortTypeId;

		// Token: 0x040094C3 RID: 38083
		private List<CommonBattleProperty> m_properties = new List<CommonBattleProperty>();

		// Token: 0x040094C4 RID: 38084
		private bool m_isAfter3DTouch;

		// Token: 0x040094C5 RID: 38085
		private string m_oldSkillLevelStr;

		// Token: 0x040094C6 RID: 38086
		[DoNotToLua]
		private EquipmentForgeUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040094C8 RID: 38088
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040094C9 RID: 38089
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040094CA RID: 38090
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040094CB RID: 38091
		private LuaFunction m_InitSortTypePanel_hotfix;

		// Token: 0x040094CC RID: 38092
		private LuaFunction m_InitLoopScrollRect_hotfix;

		// Token: 0x040094CD RID: 38093
		private LuaFunction m_UpdateEquipmentForgeViewForgeStateInt32UInt64_hotfix;

		// Token: 0x040094CE RID: 38094
		private LuaFunction m_CreateEquipmentList_hotfix;

		// Token: 0x040094CF RID: 38095
		private LuaFunction m_SortEquipmentListByTypeList;

		// Token: 0x040094D0 RID: 38096
		private LuaFunction m_DefaultEquipmentItemComparerEquipmentBagItemEquipmentBagItem_hotfix;

		// Token: 0x040094D1 RID: 38097
		private LuaFunction m_CollectEquipmentPropValueAndSortList;

		// Token: 0x040094D2 RID: 38098
		private LuaFunction m_OnEquipmentListItemClickUIControllerBase_hotfix;

		// Token: 0x040094D3 RID: 38099
		private LuaFunction m_OnEquipmentItemClickInEnhanceEquipmentDepotListItemUIController_hotfix;

		// Token: 0x040094D4 RID: 38100
		private LuaFunction m_OnEquipmentItemClickInBreakEquipmentDepotListItemUIController_hotfix;

		// Token: 0x040094D5 RID: 38101
		private LuaFunction m_OnEquipmentItemClickInEnchantmentEquipmentDepotListItemUIController_hotfix;

		// Token: 0x040094D6 RID: 38102
		private LuaFunction m_OnEquipmentListItemNeedFillUIControllerBase_hotfix;

		// Token: 0x040094D7 RID: 38103
		private LuaFunction m_OnEquipmentListItem3DTouchUIControllerBase_hotfix;

		// Token: 0x040094D8 RID: 38104
		private LuaFunction m_OnFilterSortButtonClick_hotfix;

		// Token: 0x040094D9 RID: 38105
		private LuaFunction m_OnEnchantmentFilterSortButtonClick_hotfix;

		// Token: 0x040094DA RID: 38106
		private LuaFunction m_OnCloseFilterSortTypeGo_hotfix;

		// Token: 0x040094DB RID: 38107
		private LuaFunction m_OnCloseEnchantmentFilterSortTypeGo_hotfix;

		// Token: 0x040094DC RID: 38108
		private LuaFunction m_OnFilterSortOrderButtonClick_hotfix;

		// Token: 0x040094DD RID: 38109
		private LuaFunction m_OnFilterTypeButtonClickEquipmentSortItemUIControllerBoolean_hotfix;

		// Token: 0x040094DE RID: 38110
		private LuaFunction m_OnEnchantmentFilterTypeButtonClickEquipmentSortItemUIControllerBoolean_hotfix;

		// Token: 0x040094DF RID: 38111
		private LuaFunction m_SetEquipmentItemDescEquipmentBagItem_hotfix;

		// Token: 0x040094E0 RID: 38112
		private LuaFunction m_SetPropItemColorTextText_hotfix;

		// Token: 0x040094E1 RID: 38113
		private LuaFunction m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix;

		// Token: 0x040094E2 RID: 38114
		private LuaFunction m_UpdateViewInEnhanceState_hotfix;

		// Token: 0x040094E3 RID: 38115
		private LuaFunction m_SetEnhancePropItemsPropertyModifyTypeInt32Int32Int32Int32_hotfix;

		// Token: 0x040094E4 RID: 38116
		private LuaFunction m_ResetEnhancePropItemActive_hotfix;

		// Token: 0x040094E5 RID: 38117
		private LuaFunction m_CalculateEquipmentEnhanceAddLvByExpEquipmentBagItemInt32Int32_hotfix;

		// Token: 0x040094E6 RID: 38118
		private LuaFunction m_OnEnhanceButtonClick_hotfix;

		// Token: 0x040094E7 RID: 38119
		private LuaFunction m_SendEnhanceEquipmentMsg_hotfix;

		// Token: 0x040094E8 RID: 38120
		private LuaFunction m_OnEnhanceSucceedString_hotfix;

		// Token: 0x040094E9 RID: 38121
		private LuaFunction m_StopEnhanceSucceedEffect_hotfix;

		// Token: 0x040094EA RID: 38122
		private LuaFunction m_SetSkillLevelUpEffectEquipmentBagItemStringStringInt32_hotfix;

		// Token: 0x040094EB RID: 38123
		private LuaFunction m_DelayActiveIntensifyContinueButton_hotfix;

		// Token: 0x040094EC RID: 38124
		private LuaFunction m_OnIntensifySuccessPanelBlackButtonClick_hotfix;

		// Token: 0x040094ED RID: 38125
		private LuaFunction m_ShowEnhanceItemSRConfirmPanel_hotfix;

		// Token: 0x040094EE RID: 38126
		private LuaFunction m_ShowEnhanceItemsConfirmPanel_hotfix;

		// Token: 0x040094EF RID: 38127
		private LuaFunction m_OnEnhanceItemSRConfirmButtonClick_hotfix;

		// Token: 0x040094F0 RID: 38128
		private LuaFunction m_OnEnhanceItemSRCancelButtonClick_hotfix;

		// Token: 0x040094F1 RID: 38129
		private LuaFunction m_OnEnhanceConfirmButtonClick_hotfix;

		// Token: 0x040094F2 RID: 38130
		private LuaFunction m_OnEnhanceCancelButtonClick_hotfix;

		// Token: 0x040094F3 RID: 38131
		private LuaFunction m_OnEnhanceFastAddButtonClick_hotfix;

		// Token: 0x040094F4 RID: 38132
		private LuaFunction m_IsEquipmentAddExpAtMaxLevelMaxExpEquipmentBagItemInt32Int32_hotfix;

		// Token: 0x040094F5 RID: 38133
		private LuaFunction m_UpdateViewInBreakState_hotfix;

		// Token: 0x040094F6 RID: 38134
		private LuaFunction m_OnBreakButtonClick_hotfix;

		// Token: 0x040094F7 RID: 38135
		private LuaFunction m_OnBreakSucceed_hotfix;

		// Token: 0x040094F8 RID: 38136
		private LuaFunction m_DelayActiveBreakContinueButton_hotfix;

		// Token: 0x040094F9 RID: 38137
		private LuaFunction m_OnBreakSuccessPanelContinueButtonClick_hotfix;

		// Token: 0x040094FA RID: 38138
		private LuaFunction m_OnEquipmentBreakNeedItemClickGoodsTypeInt32Int32_hotfix;

		// Token: 0x040094FB RID: 38139
		private LuaFunction m_UpdateViewInEnchantmentState_hotfix;

		// Token: 0x040094FC RID: 38140
		private LuaFunction m_OnEnchantmentButtonClick_hotfix;

		// Token: 0x040094FD RID: 38141
		private LuaFunction m_ShowEnchantmentResultPanelInt32List;

		// Token: 0x040094FE RID: 38142
		private LuaFunction m_SetEnchantmentResultPanelInfoInt32List;

		// Token: 0x040094FF RID: 38143
		private LuaFunction m_Co_PlayNewPropertyEffectList;

		// Token: 0x04009500 RID: 38144
		private LuaFunction m_Co_DynamicSetPropertyValueTextImageInt32PropertyModifyType_hotfix;

		// Token: 0x04009501 RID: 38145
		private LuaFunction m_CalcPropertyPercentPropertyModifyTypeInt32_hotfix;

		// Token: 0x04009502 RID: 38146
		private LuaFunction m_OnEnchantmentResultPanelContinueButtonClick_hotfix;

		// Token: 0x04009503 RID: 38147
		private LuaFunction m_CloseEnchantmentResultPanelAction_hotfix;

		// Token: 0x04009504 RID: 38148
		private LuaFunction m_OnEnchantmentResultSaveButtonClick_hotfix;

		// Token: 0x04009505 RID: 38149
		private LuaFunction m_OnEnchantmentAgainButtonClick_hotfix;

		// Token: 0x04009506 RID: 38150
		private LuaFunction m_ShowSavePanel_hotfix;

		// Token: 0x04009507 RID: 38151
		private LuaFunction m_CloseSavePanel_hotfix;

		// Token: 0x04009508 RID: 38152
		private LuaFunction m_OnSavePanlConfirmClick_hotfix;

		// Token: 0x04009509 RID: 38153
		private LuaFunction m_PlaySucceedEffect_hotfix;

		// Token: 0x0400950A RID: 38154
		private LuaFunction m_OnCloseEnchantResultPanelButtonClick_hotfix;

		// Token: 0x0400950B RID: 38155
		private LuaFunction m_ShowCancelPanel_hotfix;

		// Token: 0x0400950C RID: 38156
		private LuaFunction m_CloseCancelPanel_hotfix;

		// Token: 0x0400950D RID: 38157
		private LuaFunction m_OnCancelPanlConfirmClick_hotfix;

		// Token: 0x0400950E RID: 38158
		private LuaFunction m_OnSavePropertyToggleValueChangedBoolean_hotfix;

		// Token: 0x0400950F RID: 38159
		private LuaFunction m_OnCancelPanelToggleValueChangedBoolean_hotfix;

		// Token: 0x04009510 RID: 38160
		private LuaFunction m_OnEnhanceToggleValueChangedBoolean_hotfix;

		// Token: 0x04009511 RID: 38161
		private LuaFunction m_OnBreakToggleValueChangedBoolean_hotfix;

		// Token: 0x04009512 RID: 38162
		private LuaFunction m_OnEnchantmentToggleValueChangedBoolean_hotfix;

		// Token: 0x04009513 RID: 38163
		private LuaFunction m_OnEnchantLockMaskButtonClick_hotfix;

		// Token: 0x04009514 RID: 38164
		private LuaFunction m_OnGoldAddButtonClick_hotfix;

		// Token: 0x04009515 RID: 38165
		private LuaFunction m_SetPlayerResourceGold_hotfix;

		// Token: 0x04009516 RID: 38166
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04009517 RID: 38167
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04009518 RID: 38168
		private LuaFunction m_GetFirstEquipmentGoInListForUserGuide_hotfix;

		// Token: 0x04009519 RID: 38169
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400951A RID: 38170
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400951B RID: 38171
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x0400951C RID: 38172
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x0400951D RID: 38173
		private LuaFunction m_add_EventOnGoldAddButtonClickAction;

		// Token: 0x0400951E RID: 38174
		private LuaFunction m_remove_EventOnGoldAddButtonClickAction;

		// Token: 0x0400951F RID: 38175
		private LuaFunction m_add_EventOnEnhanceButtonClickAction;

		// Token: 0x04009520 RID: 38176
		private LuaFunction m_remove_EventOnEnhanceButtonClickAction;

		// Token: 0x04009521 RID: 38177
		private LuaFunction m_add_EventOnBreakButtonClickAction;

		// Token: 0x04009522 RID: 38178
		private LuaFunction m_remove_EventOnBreakButtonClickAction;

		// Token: 0x04009523 RID: 38179
		private LuaFunction m_add_EventOnEnchantButtonClickAction;

		// Token: 0x04009524 RID: 38180
		private LuaFunction m_remove_EventOnEnchantButtonClickAction;

		// Token: 0x04009525 RID: 38181
		private LuaFunction m_add_EventOnBreakNeedItemClickAction;

		// Token: 0x04009526 RID: 38182
		private LuaFunction m_remove_EventOnBreakNeedItemClickAction;

		// Token: 0x04009527 RID: 38183
		private LuaFunction m_add_EventOnEnchantSaveButtonClickAction;

		// Token: 0x04009528 RID: 38184
		private LuaFunction m_remove_EventOnEnchantSaveButtonClickAction;

		// Token: 0x04009529 RID: 38185
		private LuaFunction m_add_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x0400952A RID: 38186
		private LuaFunction m_remove_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x02000D5F RID: 3423
		public enum ForgeState
		{
			// Token: 0x0400952C RID: 38188
			Enhance,
			// Token: 0x0400952D RID: 38189
			Break,
			// Token: 0x0400952E RID: 38190
			Enchantment
		}

		// Token: 0x02000D60 RID: 3424
		public new class LuaExportHelper
		{
			// Token: 0x0600FCB0 RID: 64688 RVA: 0x0042C9EC File Offset: 0x0042ABEC
			public LuaExportHelper(EquipmentForgeUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600FCB1 RID: 64689 RVA: 0x0042C9FC File Offset: 0x0042ABFC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600FCB2 RID: 64690 RVA: 0x0042CA0C File Offset: 0x0042AC0C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600FCB3 RID: 64691 RVA: 0x0042CA1C File Offset: 0x0042AC1C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600FCB4 RID: 64692 RVA: 0x0042CA2C File Offset: 0x0042AC2C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600FCB5 RID: 64693 RVA: 0x0042CA44 File Offset: 0x0042AC44
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600FCB6 RID: 64694 RVA: 0x0042CA54 File Offset: 0x0042AC54
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600FCB7 RID: 64695 RVA: 0x0042CA64 File Offset: 0x0042AC64
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600FCB8 RID: 64696 RVA: 0x0042CA74 File Offset: 0x0042AC74
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600FCB9 RID: 64697 RVA: 0x0042CA84 File Offset: 0x0042AC84
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600FCBA RID: 64698 RVA: 0x0042CA94 File Offset: 0x0042AC94
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600FCBB RID: 64699 RVA: 0x0042CAA4 File Offset: 0x0042ACA4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600FCBC RID: 64700 RVA: 0x0042CAB4 File Offset: 0x0042ACB4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600FCBD RID: 64701 RVA: 0x0042CAC4 File Offset: 0x0042ACC4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600FCBE RID: 64702 RVA: 0x0042CAD4 File Offset: 0x0042ACD4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600FCBF RID: 64703 RVA: 0x0042CAE4 File Offset: 0x0042ACE4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600FCC0 RID: 64704 RVA: 0x0042CAF4 File Offset: 0x0042ACF4
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600FCC1 RID: 64705 RVA: 0x0042CB04 File Offset: 0x0042AD04
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600FCC2 RID: 64706 RVA: 0x0042CB14 File Offset: 0x0042AD14
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600FCC3 RID: 64707 RVA: 0x0042CB24 File Offset: 0x0042AD24
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600FCC4 RID: 64708 RVA: 0x0042CB34 File Offset: 0x0042AD34
			public void __callDele_EventOnGoldAddButtonClick(ulong arg1, int arg2, EquipmentForgeUIController.ForgeState arg3)
			{
				this.m_owner.__callDele_EventOnGoldAddButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x0600FCC5 RID: 64709 RVA: 0x0042CB44 File Offset: 0x0042AD44
			public void __clearDele_EventOnGoldAddButtonClick(ulong arg1, int arg2, EquipmentForgeUIController.ForgeState arg3)
			{
				this.m_owner.__clearDele_EventOnGoldAddButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x0600FCC6 RID: 64710 RVA: 0x0042CB54 File Offset: 0x0042AD54
			public void __callDele_EventOnEnhanceButtonClick(ulong arg1, List<ulong> arg2, Action arg3, int arg4)
			{
				this.m_owner.__callDele_EventOnEnhanceButtonClick(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600FCC7 RID: 64711 RVA: 0x0042CB68 File Offset: 0x0042AD68
			public void __clearDele_EventOnEnhanceButtonClick(ulong arg1, List<ulong> arg2, Action arg3, int arg4)
			{
				this.m_owner.__clearDele_EventOnEnhanceButtonClick(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600FCC8 RID: 64712 RVA: 0x0042CB7C File Offset: 0x0042AD7C
			public void __callDele_EventOnBreakButtonClick(ulong arg1, ulong arg2, Action arg3, int arg4)
			{
				this.m_owner.__callDele_EventOnBreakButtonClick(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600FCC9 RID: 64713 RVA: 0x0042CB90 File Offset: 0x0042AD90
			public void __clearDele_EventOnBreakButtonClick(ulong arg1, ulong arg2, Action arg3, int arg4)
			{
				this.m_owner.__clearDele_EventOnBreakButtonClick(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600FCCA RID: 64714 RVA: 0x0042CBA4 File Offset: 0x0042ADA4
			public void __callDele_EventOnEnchantButtonClick(ulong arg1, ulong arg2, Action<int, List<CommonBattleProperty>> arg3)
			{
				this.m_owner.__callDele_EventOnEnchantButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x0600FCCB RID: 64715 RVA: 0x0042CBB4 File Offset: 0x0042ADB4
			public void __clearDele_EventOnEnchantButtonClick(ulong arg1, ulong arg2, Action<int, List<CommonBattleProperty>> arg3)
			{
				this.m_owner.__clearDele_EventOnEnchantButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x0600FCCC RID: 64716 RVA: 0x0042CBC4 File Offset: 0x0042ADC4
			public void __callDele_EventOnBreakNeedItemClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnBreakNeedItemClick(arg1, arg2, arg3);
			}

			// Token: 0x0600FCCD RID: 64717 RVA: 0x0042CBD4 File Offset: 0x0042ADD4
			public void __clearDele_EventOnBreakNeedItemClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnBreakNeedItemClick(arg1, arg2, arg3);
			}

			// Token: 0x0600FCCE RID: 64718 RVA: 0x0042CBE4 File Offset: 0x0042ADE4
			public void __callDele_EventOnEnchantSaveButtonClick(Action obj)
			{
				this.m_owner.__callDele_EventOnEnchantSaveButtonClick(obj);
			}

			// Token: 0x0600FCCF RID: 64719 RVA: 0x0042CBF4 File Offset: 0x0042ADF4
			public void __clearDele_EventOnEnchantSaveButtonClick(Action obj)
			{
				this.m_owner.__clearDele_EventOnEnchantSaveButtonClick(obj);
			}

			// Token: 0x0600FCD0 RID: 64720 RVA: 0x0042CC04 File Offset: 0x0042AE04
			public void __callDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__callDele_EventOnCrystalNotEnough();
			}

			// Token: 0x0600FCD1 RID: 64721 RVA: 0x0042CC14 File Offset: 0x0042AE14
			public void __clearDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__clearDele_EventOnCrystalNotEnough();
			}

			// Token: 0x17003015 RID: 12309
			// (get) Token: 0x0600FCD2 RID: 64722 RVA: 0x0042CC24 File Offset: 0x0042AE24
			// (set) Token: 0x0600FCD3 RID: 64723 RVA: 0x0042CC34 File Offset: 0x0042AE34
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x17003016 RID: 12310
			// (get) Token: 0x0600FCD4 RID: 64724 RVA: 0x0042CC44 File Offset: 0x0042AE44
			// (set) Token: 0x0600FCD5 RID: 64725 RVA: 0x0042CC54 File Offset: 0x0042AE54
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17003017 RID: 12311
			// (get) Token: 0x0600FCD6 RID: 64726 RVA: 0x0042CC64 File Offset: 0x0042AE64
			// (set) Token: 0x0600FCD7 RID: 64727 RVA: 0x0042CC74 File Offset: 0x0042AE74
			public Button m_helpButton
			{
				get
				{
					return this.m_owner.m_helpButton;
				}
				set
				{
					this.m_owner.m_helpButton = value;
				}
			}

			// Token: 0x17003018 RID: 12312
			// (get) Token: 0x0600FCD8 RID: 64728 RVA: 0x0042CC84 File Offset: 0x0042AE84
			// (set) Token: 0x0600FCD9 RID: 64729 RVA: 0x0042CC94 File Offset: 0x0042AE94
			public Toggle m_enhanceToggle
			{
				get
				{
					return this.m_owner.m_enhanceToggle;
				}
				set
				{
					this.m_owner.m_enhanceToggle = value;
				}
			}

			// Token: 0x17003019 RID: 12313
			// (get) Token: 0x0600FCDA RID: 64730 RVA: 0x0042CCA4 File Offset: 0x0042AEA4
			// (set) Token: 0x0600FCDB RID: 64731 RVA: 0x0042CCB4 File Offset: 0x0042AEB4
			public Toggle m_breakToggle
			{
				get
				{
					return this.m_owner.m_breakToggle;
				}
				set
				{
					this.m_owner.m_breakToggle = value;
				}
			}

			// Token: 0x1700301A RID: 12314
			// (get) Token: 0x0600FCDC RID: 64732 RVA: 0x0042CCC4 File Offset: 0x0042AEC4
			// (set) Token: 0x0600FCDD RID: 64733 RVA: 0x0042CCD4 File Offset: 0x0042AED4
			public Toggle m_enchantmentToggle
			{
				get
				{
					return this.m_owner.m_enchantmentToggle;
				}
				set
				{
					this.m_owner.m_enchantmentToggle = value;
				}
			}

			// Token: 0x1700301B RID: 12315
			// (get) Token: 0x0600FCDE RID: 64734 RVA: 0x0042CCE4 File Offset: 0x0042AEE4
			// (set) Token: 0x0600FCDF RID: 64735 RVA: 0x0042CCF4 File Offset: 0x0042AEF4
			public Button m_enchantLockMaskButton
			{
				get
				{
					return this.m_owner.m_enchantLockMaskButton;
				}
				set
				{
					this.m_owner.m_enchantLockMaskButton = value;
				}
			}

			// Token: 0x1700301C RID: 12316
			// (get) Token: 0x0600FCE0 RID: 64736 RVA: 0x0042CD04 File Offset: 0x0042AF04
			// (set) Token: 0x0600FCE1 RID: 64737 RVA: 0x0042CD14 File Offset: 0x0042AF14
			public Text m_goldText
			{
				get
				{
					return this.m_owner.m_goldText;
				}
				set
				{
					this.m_owner.m_goldText = value;
				}
			}

			// Token: 0x1700301D RID: 12317
			// (get) Token: 0x0600FCE2 RID: 64738 RVA: 0x0042CD24 File Offset: 0x0042AF24
			// (set) Token: 0x0600FCE3 RID: 64739 RVA: 0x0042CD34 File Offset: 0x0042AF34
			public Button m_goldAddButton
			{
				get
				{
					return this.m_owner.m_goldAddButton;
				}
				set
				{
					this.m_owner.m_goldAddButton = value;
				}
			}

			// Token: 0x1700301E RID: 12318
			// (get) Token: 0x0600FCE4 RID: 64740 RVA: 0x0042CD44 File Offset: 0x0042AF44
			// (set) Token: 0x0600FCE5 RID: 64741 RVA: 0x0042CD54 File Offset: 0x0042AF54
			public LoopVerticalScrollRect m_loopScrollView
			{
				get
				{
					return this.m_owner.m_loopScrollView;
				}
				set
				{
					this.m_owner.m_loopScrollView = value;
				}
			}

			// Token: 0x1700301F RID: 12319
			// (get) Token: 0x0600FCE6 RID: 64742 RVA: 0x0042CD64 File Offset: 0x0042AF64
			// (set) Token: 0x0600FCE7 RID: 64743 RVA: 0x0042CD74 File Offset: 0x0042AF74
			public EasyObjectPool m_listItemPool
			{
				get
				{
					return this.m_owner.m_listItemPool;
				}
				set
				{
					this.m_owner.m_listItemPool = value;
				}
			}

			// Token: 0x17003020 RID: 12320
			// (get) Token: 0x0600FCE8 RID: 64744 RVA: 0x0042CD84 File Offset: 0x0042AF84
			// (set) Token: 0x0600FCE9 RID: 64745 RVA: 0x0042CD94 File Offset: 0x0042AF94
			public GameObject m_listScrollViewItemRoot
			{
				get
				{
					return this.m_owner.m_listScrollViewItemRoot;
				}
				set
				{
					this.m_owner.m_listScrollViewItemRoot = value;
				}
			}

			// Token: 0x17003021 RID: 12321
			// (get) Token: 0x0600FCEA RID: 64746 RVA: 0x0042CDA4 File Offset: 0x0042AFA4
			// (set) Token: 0x0600FCEB RID: 64747 RVA: 0x0042CDB4 File Offset: 0x0042AFB4
			public GameObject m_enchantmentFilter
			{
				get
				{
					return this.m_owner.m_enchantmentFilter;
				}
				set
				{
					this.m_owner.m_enchantmentFilter = value;
				}
			}

			// Token: 0x17003022 RID: 12322
			// (get) Token: 0x0600FCEC RID: 64748 RVA: 0x0042CDC4 File Offset: 0x0042AFC4
			// (set) Token: 0x0600FCED RID: 64749 RVA: 0x0042CDD4 File Offset: 0x0042AFD4
			public Button m_enchantmentfilterSortButton
			{
				get
				{
					return this.m_owner.m_enchantmentfilterSortButton;
				}
				set
				{
					this.m_owner.m_enchantmentfilterSortButton = value;
				}
			}

			// Token: 0x17003023 RID: 12323
			// (get) Token: 0x0600FCEE RID: 64750 RVA: 0x0042CDE4 File Offset: 0x0042AFE4
			// (set) Token: 0x0600FCEF RID: 64751 RVA: 0x0042CDF4 File Offset: 0x0042AFF4
			public Text m_enchantmentfilterSortTypeText
			{
				get
				{
					return this.m_owner.m_enchantmentfilterSortTypeText;
				}
				set
				{
					this.m_owner.m_enchantmentfilterSortTypeText = value;
				}
			}

			// Token: 0x17003024 RID: 12324
			// (get) Token: 0x0600FCF0 RID: 64752 RVA: 0x0042CE04 File Offset: 0x0042B004
			// (set) Token: 0x0600FCF1 RID: 64753 RVA: 0x0042CE14 File Offset: 0x0042B014
			public GameObject m_enchantmentfilterSortTypesGo
			{
				get
				{
					return this.m_owner.m_enchantmentfilterSortTypesGo;
				}
				set
				{
					this.m_owner.m_enchantmentfilterSortTypesGo = value;
				}
			}

			// Token: 0x17003025 RID: 12325
			// (get) Token: 0x0600FCF2 RID: 64754 RVA: 0x0042CE24 File Offset: 0x0042B024
			// (set) Token: 0x0600FCF3 RID: 64755 RVA: 0x0042CE34 File Offset: 0x0042B034
			public GameObject m_enchantmentfilterSortTypesGridLayout
			{
				get
				{
					return this.m_owner.m_enchantmentfilterSortTypesGridLayout;
				}
				set
				{
					this.m_owner.m_enchantmentfilterSortTypesGridLayout = value;
				}
			}

			// Token: 0x17003026 RID: 12326
			// (get) Token: 0x0600FCF4 RID: 64756 RVA: 0x0042CE44 File Offset: 0x0042B044
			// (set) Token: 0x0600FCF5 RID: 64757 RVA: 0x0042CE54 File Offset: 0x0042B054
			public GameObject m_enchantmentfilterSortTypesAllToggle
			{
				get
				{
					return this.m_owner.m_enchantmentfilterSortTypesAllToggle;
				}
				set
				{
					this.m_owner.m_enchantmentfilterSortTypesAllToggle = value;
				}
			}

			// Token: 0x17003027 RID: 12327
			// (get) Token: 0x0600FCF6 RID: 64758 RVA: 0x0042CE64 File Offset: 0x0042B064
			// (set) Token: 0x0600FCF7 RID: 64759 RVA: 0x0042CE74 File Offset: 0x0042B074
			public GameObject m_enhanceAndBreakFilter
			{
				get
				{
					return this.m_owner.m_enhanceAndBreakFilter;
				}
				set
				{
					this.m_owner.m_enhanceAndBreakFilter = value;
				}
			}

			// Token: 0x17003028 RID: 12328
			// (get) Token: 0x0600FCF8 RID: 64760 RVA: 0x0042CE84 File Offset: 0x0042B084
			// (set) Token: 0x0600FCF9 RID: 64761 RVA: 0x0042CE94 File Offset: 0x0042B094
			public Button m_filterSortButton
			{
				get
				{
					return this.m_owner.m_filterSortButton;
				}
				set
				{
					this.m_owner.m_filterSortButton = value;
				}
			}

			// Token: 0x17003029 RID: 12329
			// (get) Token: 0x0600FCFA RID: 64762 RVA: 0x0042CEA4 File Offset: 0x0042B0A4
			// (set) Token: 0x0600FCFB RID: 64763 RVA: 0x0042CEB4 File Offset: 0x0042B0B4
			public Text m_filterSortTypeText
			{
				get
				{
					return this.m_owner.m_filterSortTypeText;
				}
				set
				{
					this.m_owner.m_filterSortTypeText = value;
				}
			}

			// Token: 0x1700302A RID: 12330
			// (get) Token: 0x0600FCFC RID: 64764 RVA: 0x0042CEC4 File Offset: 0x0042B0C4
			// (set) Token: 0x0600FCFD RID: 64765 RVA: 0x0042CED4 File Offset: 0x0042B0D4
			public Button m_filterSortOrderButton
			{
				get
				{
					return this.m_owner.m_filterSortOrderButton;
				}
				set
				{
					this.m_owner.m_filterSortOrderButton = value;
				}
			}

			// Token: 0x1700302B RID: 12331
			// (get) Token: 0x0600FCFE RID: 64766 RVA: 0x0042CEE4 File Offset: 0x0042B0E4
			// (set) Token: 0x0600FCFF RID: 64767 RVA: 0x0042CEF4 File Offset: 0x0042B0F4
			public GameObject m_filterSortTypesGo
			{
				get
				{
					return this.m_owner.m_filterSortTypesGo;
				}
				set
				{
					this.m_owner.m_filterSortTypesGo = value;
				}
			}

			// Token: 0x1700302C RID: 12332
			// (get) Token: 0x0600FD00 RID: 64768 RVA: 0x0042CF04 File Offset: 0x0042B104
			// (set) Token: 0x0600FD01 RID: 64769 RVA: 0x0042CF14 File Offset: 0x0042B114
			public GameObject m_filterSortTypesGridLayout
			{
				get
				{
					return this.m_owner.m_filterSortTypesGridLayout;
				}
				set
				{
					this.m_owner.m_filterSortTypesGridLayout = value;
				}
			}

			// Token: 0x1700302D RID: 12333
			// (get) Token: 0x0600FD02 RID: 64770 RVA: 0x0042CF24 File Offset: 0x0042B124
			// (set) Token: 0x0600FD03 RID: 64771 RVA: 0x0042CF34 File Offset: 0x0042B134
			public GameObject m_listNoBreakItemGo
			{
				get
				{
					return this.m_owner.m_listNoBreakItemGo;
				}
				set
				{
					this.m_owner.m_listNoBreakItemGo = value;
				}
			}

			// Token: 0x1700302E RID: 12334
			// (get) Token: 0x0600FD04 RID: 64772 RVA: 0x0042CF44 File Offset: 0x0042B144
			// (set) Token: 0x0600FD05 RID: 64773 RVA: 0x0042CF54 File Offset: 0x0042B154
			public GameObject m_listNoEnchantmentItemGo
			{
				get
				{
					return this.m_owner.m_listNoEnchantmentItemGo;
				}
				set
				{
					this.m_owner.m_listNoEnchantmentItemGo = value;
				}
			}

			// Token: 0x1700302F RID: 12335
			// (get) Token: 0x0600FD06 RID: 64774 RVA: 0x0042CF64 File Offset: 0x0042B164
			// (set) Token: 0x0600FD07 RID: 64775 RVA: 0x0042CF74 File Offset: 0x0042B174
			public CommonUIStateController m_listTitleStateCtrl
			{
				get
				{
					return this.m_owner.m_listTitleStateCtrl;
				}
				set
				{
					this.m_owner.m_listTitleStateCtrl = value;
				}
			}

			// Token: 0x17003030 RID: 12336
			// (get) Token: 0x0600FD08 RID: 64776 RVA: 0x0042CF84 File Offset: 0x0042B184
			// (set) Token: 0x0600FD09 RID: 64777 RVA: 0x0042CF94 File Offset: 0x0042B194
			public GameObject m_listLongPressTipGo
			{
				get
				{
					return this.m_owner.m_listLongPressTipGo;
				}
				set
				{
					this.m_owner.m_listLongPressTipGo = value;
				}
			}

			// Token: 0x17003031 RID: 12337
			// (get) Token: 0x0600FD0A RID: 64778 RVA: 0x0042CFA4 File Offset: 0x0042B1A4
			// (set) Token: 0x0600FD0B RID: 64779 RVA: 0x0042CFB4 File Offset: 0x0042B1B4
			public GameObject m_descGo
			{
				get
				{
					return this.m_owner.m_descGo;
				}
				set
				{
					this.m_owner.m_descGo = value;
				}
			}

			// Token: 0x17003032 RID: 12338
			// (get) Token: 0x0600FD0C RID: 64780 RVA: 0x0042CFC4 File Offset: 0x0042B1C4
			// (set) Token: 0x0600FD0D RID: 64781 RVA: 0x0042CFD4 File Offset: 0x0042B1D4
			public Text m_descTitleText
			{
				get
				{
					return this.m_owner.m_descTitleText;
				}
				set
				{
					this.m_owner.m_descTitleText = value;
				}
			}

			// Token: 0x17003033 RID: 12339
			// (get) Token: 0x0600FD0E RID: 64782 RVA: 0x0042CFE4 File Offset: 0x0042B1E4
			// (set) Token: 0x0600FD0F RID: 64783 RVA: 0x0042CFF4 File Offset: 0x0042B1F4
			public Image m_descIcon
			{
				get
				{
					return this.m_owner.m_descIcon;
				}
				set
				{
					this.m_owner.m_descIcon = value;
				}
			}

			// Token: 0x17003034 RID: 12340
			// (get) Token: 0x0600FD10 RID: 64784 RVA: 0x0042D004 File Offset: 0x0042B204
			// (set) Token: 0x0600FD11 RID: 64785 RVA: 0x0042D014 File Offset: 0x0042B214
			public Image m_descIconBg
			{
				get
				{
					return this.m_owner.m_descIconBg;
				}
				set
				{
					this.m_owner.m_descIconBg = value;
				}
			}

			// Token: 0x17003035 RID: 12341
			// (get) Token: 0x0600FD12 RID: 64786 RVA: 0x0042D024 File Offset: 0x0042B224
			// (set) Token: 0x0600FD13 RID: 64787 RVA: 0x0042D034 File Offset: 0x0042B234
			public GameObject m_descSSREffect
			{
				get
				{
					return this.m_owner.m_descSSREffect;
				}
				set
				{
					this.m_owner.m_descSSREffect = value;
				}
			}

			// Token: 0x17003036 RID: 12342
			// (get) Token: 0x0600FD14 RID: 64788 RVA: 0x0042D044 File Offset: 0x0042B244
			// (set) Token: 0x0600FD15 RID: 64789 RVA: 0x0042D054 File Offset: 0x0042B254
			public GameObject m_descStarGroup
			{
				get
				{
					return this.m_owner.m_descStarGroup;
				}
				set
				{
					this.m_owner.m_descStarGroup = value;
				}
			}

			// Token: 0x17003037 RID: 12343
			// (get) Token: 0x0600FD16 RID: 64790 RVA: 0x0042D064 File Offset: 0x0042B264
			// (set) Token: 0x0600FD17 RID: 64791 RVA: 0x0042D074 File Offset: 0x0042B274
			public Text m_descLvText
			{
				get
				{
					return this.m_owner.m_descLvText;
				}
				set
				{
					this.m_owner.m_descLvText = value;
				}
			}

			// Token: 0x17003038 RID: 12344
			// (get) Token: 0x0600FD18 RID: 64792 RVA: 0x0042D084 File Offset: 0x0042B284
			// (set) Token: 0x0600FD19 RID: 64793 RVA: 0x0042D094 File Offset: 0x0042B294
			public Text m_descExpText
			{
				get
				{
					return this.m_owner.m_descExpText;
				}
				set
				{
					this.m_owner.m_descExpText = value;
				}
			}

			// Token: 0x17003039 RID: 12345
			// (get) Token: 0x0600FD1A RID: 64794 RVA: 0x0042D0A4 File Offset: 0x0042B2A4
			// (set) Token: 0x0600FD1B RID: 64795 RVA: 0x0042D0B4 File Offset: 0x0042B2B4
			public Image m_descProgressImage
			{
				get
				{
					return this.m_owner.m_descProgressImage;
				}
				set
				{
					this.m_owner.m_descProgressImage = value;
				}
			}

			// Token: 0x1700303A RID: 12346
			// (get) Token: 0x0600FD1C RID: 64796 RVA: 0x0042D0C4 File Offset: 0x0042B2C4
			// (set) Token: 0x0600FD1D RID: 64797 RVA: 0x0042D0D4 File Offset: 0x0042B2D4
			public GameObject m_descEquipLimitContent
			{
				get
				{
					return this.m_owner.m_descEquipLimitContent;
				}
				set
				{
					this.m_owner.m_descEquipLimitContent = value;
				}
			}

			// Token: 0x1700303B RID: 12347
			// (get) Token: 0x0600FD1E RID: 64798 RVA: 0x0042D0E4 File Offset: 0x0042B2E4
			// (set) Token: 0x0600FD1F RID: 64799 RVA: 0x0042D0F4 File Offset: 0x0042B2F4
			public Text m_descEquipUnlimitText
			{
				get
				{
					return this.m_owner.m_descEquipUnlimitText;
				}
				set
				{
					this.m_owner.m_descEquipUnlimitText = value;
				}
			}

			// Token: 0x1700303C RID: 12348
			// (get) Token: 0x0600FD20 RID: 64800 RVA: 0x0042D104 File Offset: 0x0042B304
			// (set) Token: 0x0600FD21 RID: 64801 RVA: 0x0042D114 File Offset: 0x0042B314
			public GameObject m_descSkillContent
			{
				get
				{
					return this.m_owner.m_descSkillContent;
				}
				set
				{
					this.m_owner.m_descSkillContent = value;
				}
			}

			// Token: 0x1700303D RID: 12349
			// (get) Token: 0x0600FD22 RID: 64802 RVA: 0x0042D124 File Offset: 0x0042B324
			// (set) Token: 0x0600FD23 RID: 64803 RVA: 0x0042D134 File Offset: 0x0042B334
			public CommonUIStateController m_descSkillContentStateCtrl
			{
				get
				{
					return this.m_owner.m_descSkillContentStateCtrl;
				}
				set
				{
					this.m_owner.m_descSkillContentStateCtrl = value;
				}
			}

			// Token: 0x1700303E RID: 12350
			// (get) Token: 0x0600FD24 RID: 64804 RVA: 0x0042D144 File Offset: 0x0042B344
			// (set) Token: 0x0600FD25 RID: 64805 RVA: 0x0042D154 File Offset: 0x0042B354
			public Text m_descUnlockCoditionText
			{
				get
				{
					return this.m_owner.m_descUnlockCoditionText;
				}
				set
				{
					this.m_owner.m_descUnlockCoditionText = value;
				}
			}

			// Token: 0x1700303F RID: 12351
			// (get) Token: 0x0600FD26 RID: 64806 RVA: 0x0042D164 File Offset: 0x0042B364
			// (set) Token: 0x0600FD27 RID: 64807 RVA: 0x0042D174 File Offset: 0x0042B374
			public Text m_descSkillNameText
			{
				get
				{
					return this.m_owner.m_descSkillNameText;
				}
				set
				{
					this.m_owner.m_descSkillNameText = value;
				}
			}

			// Token: 0x17003040 RID: 12352
			// (get) Token: 0x0600FD28 RID: 64808 RVA: 0x0042D184 File Offset: 0x0042B384
			// (set) Token: 0x0600FD29 RID: 64809 RVA: 0x0042D194 File Offset: 0x0042B394
			public Text m_descSkillLvText
			{
				get
				{
					return this.m_owner.m_descSkillLvText;
				}
				set
				{
					this.m_owner.m_descSkillLvText = value;
				}
			}

			// Token: 0x17003041 RID: 12353
			// (get) Token: 0x0600FD2A RID: 64810 RVA: 0x0042D1A4 File Offset: 0x0042B3A4
			// (set) Token: 0x0600FD2B RID: 64811 RVA: 0x0042D1B4 File Offset: 0x0042B3B4
			public Text m_descSkillOwnerText
			{
				get
				{
					return this.m_owner.m_descSkillOwnerText;
				}
				set
				{
					this.m_owner.m_descSkillOwnerText = value;
				}
			}

			// Token: 0x17003042 RID: 12354
			// (get) Token: 0x0600FD2C RID: 64812 RVA: 0x0042D1C4 File Offset: 0x0042B3C4
			// (set) Token: 0x0600FD2D RID: 64813 RVA: 0x0042D1D4 File Offset: 0x0042B3D4
			public GameObject m_descSkillOwnerBGImage
			{
				get
				{
					return this.m_owner.m_descSkillOwnerBGImage;
				}
				set
				{
					this.m_owner.m_descSkillOwnerBGImage = value;
				}
			}

			// Token: 0x17003043 RID: 12355
			// (get) Token: 0x0600FD2E RID: 64814 RVA: 0x0042D1E4 File Offset: 0x0042B3E4
			// (set) Token: 0x0600FD2F RID: 64815 RVA: 0x0042D1F4 File Offset: 0x0042B3F4
			public Text m_descSkillDescText
			{
				get
				{
					return this.m_owner.m_descSkillDescText;
				}
				set
				{
					this.m_owner.m_descSkillDescText = value;
				}
			}

			// Token: 0x17003044 RID: 12356
			// (get) Token: 0x0600FD30 RID: 64816 RVA: 0x0042D204 File Offset: 0x0042B404
			// (set) Token: 0x0600FD31 RID: 64817 RVA: 0x0042D214 File Offset: 0x0042B414
			public GameObject m_descNotEquipSkillTip
			{
				get
				{
					return this.m_owner.m_descNotEquipSkillTip;
				}
				set
				{
					this.m_owner.m_descNotEquipSkillTip = value;
				}
			}

			// Token: 0x17003045 RID: 12357
			// (get) Token: 0x0600FD32 RID: 64818 RVA: 0x0042D224 File Offset: 0x0042B424
			// (set) Token: 0x0600FD33 RID: 64819 RVA: 0x0042D234 File Offset: 0x0042B434
			public GameObject m_descPropContent
			{
				get
				{
					return this.m_owner.m_descPropContent;
				}
				set
				{
					this.m_owner.m_descPropContent = value;
				}
			}

			// Token: 0x17003046 RID: 12358
			// (get) Token: 0x0600FD34 RID: 64820 RVA: 0x0042D244 File Offset: 0x0042B444
			// (set) Token: 0x0600FD35 RID: 64821 RVA: 0x0042D254 File Offset: 0x0042B454
			public GameObject m_descPropATGo
			{
				get
				{
					return this.m_owner.m_descPropATGo;
				}
				set
				{
					this.m_owner.m_descPropATGo = value;
				}
			}

			// Token: 0x17003047 RID: 12359
			// (get) Token: 0x0600FD36 RID: 64822 RVA: 0x0042D264 File Offset: 0x0042B464
			// (set) Token: 0x0600FD37 RID: 64823 RVA: 0x0042D274 File Offset: 0x0042B474
			public Text m_descPropATValueText
			{
				get
				{
					return this.m_owner.m_descPropATValueText;
				}
				set
				{
					this.m_owner.m_descPropATValueText = value;
				}
			}

			// Token: 0x17003048 RID: 12360
			// (get) Token: 0x0600FD38 RID: 64824 RVA: 0x0042D284 File Offset: 0x0042B484
			// (set) Token: 0x0600FD39 RID: 64825 RVA: 0x0042D294 File Offset: 0x0042B494
			public GameObject m_descPropDFGo
			{
				get
				{
					return this.m_owner.m_descPropDFGo;
				}
				set
				{
					this.m_owner.m_descPropDFGo = value;
				}
			}

			// Token: 0x17003049 RID: 12361
			// (get) Token: 0x0600FD3A RID: 64826 RVA: 0x0042D2A4 File Offset: 0x0042B4A4
			// (set) Token: 0x0600FD3B RID: 64827 RVA: 0x0042D2B4 File Offset: 0x0042B4B4
			public Text m_descPropDFValueText
			{
				get
				{
					return this.m_owner.m_descPropDFValueText;
				}
				set
				{
					this.m_owner.m_descPropDFValueText = value;
				}
			}

			// Token: 0x1700304A RID: 12362
			// (get) Token: 0x0600FD3C RID: 64828 RVA: 0x0042D2C4 File Offset: 0x0042B4C4
			// (set) Token: 0x0600FD3D RID: 64829 RVA: 0x0042D2D4 File Offset: 0x0042B4D4
			public GameObject m_descPropHPGo
			{
				get
				{
					return this.m_owner.m_descPropHPGo;
				}
				set
				{
					this.m_owner.m_descPropHPGo = value;
				}
			}

			// Token: 0x1700304B RID: 12363
			// (get) Token: 0x0600FD3E RID: 64830 RVA: 0x0042D2E4 File Offset: 0x0042B4E4
			// (set) Token: 0x0600FD3F RID: 64831 RVA: 0x0042D2F4 File Offset: 0x0042B4F4
			public Text m_descPropHPValueText
			{
				get
				{
					return this.m_owner.m_descPropHPValueText;
				}
				set
				{
					this.m_owner.m_descPropHPValueText = value;
				}
			}

			// Token: 0x1700304C RID: 12364
			// (get) Token: 0x0600FD40 RID: 64832 RVA: 0x0042D304 File Offset: 0x0042B504
			// (set) Token: 0x0600FD41 RID: 64833 RVA: 0x0042D314 File Offset: 0x0042B514
			public GameObject m_descPropMagiccGo
			{
				get
				{
					return this.m_owner.m_descPropMagiccGo;
				}
				set
				{
					this.m_owner.m_descPropMagiccGo = value;
				}
			}

			// Token: 0x1700304D RID: 12365
			// (get) Token: 0x0600FD42 RID: 64834 RVA: 0x0042D324 File Offset: 0x0042B524
			// (set) Token: 0x0600FD43 RID: 64835 RVA: 0x0042D334 File Offset: 0x0042B534
			public Text m_descPropMagicValueText
			{
				get
				{
					return this.m_owner.m_descPropMagicValueText;
				}
				set
				{
					this.m_owner.m_descPropMagicValueText = value;
				}
			}

			// Token: 0x1700304E RID: 12366
			// (get) Token: 0x0600FD44 RID: 64836 RVA: 0x0042D344 File Offset: 0x0042B544
			// (set) Token: 0x0600FD45 RID: 64837 RVA: 0x0042D354 File Offset: 0x0042B554
			public GameObject m_descPropMagicDFGo
			{
				get
				{
					return this.m_owner.m_descPropMagicDFGo;
				}
				set
				{
					this.m_owner.m_descPropMagicDFGo = value;
				}
			}

			// Token: 0x1700304F RID: 12367
			// (get) Token: 0x0600FD46 RID: 64838 RVA: 0x0042D364 File Offset: 0x0042B564
			// (set) Token: 0x0600FD47 RID: 64839 RVA: 0x0042D374 File Offset: 0x0042B574
			public Text m_descPropMagicDFValueText
			{
				get
				{
					return this.m_owner.m_descPropMagicDFValueText;
				}
				set
				{
					this.m_owner.m_descPropMagicDFValueText = value;
				}
			}

			// Token: 0x17003050 RID: 12368
			// (get) Token: 0x0600FD48 RID: 64840 RVA: 0x0042D384 File Offset: 0x0042B584
			// (set) Token: 0x0600FD49 RID: 64841 RVA: 0x0042D394 File Offset: 0x0042B594
			public GameObject m_descPropDexGo
			{
				get
				{
					return this.m_owner.m_descPropDexGo;
				}
				set
				{
					this.m_owner.m_descPropDexGo = value;
				}
			}

			// Token: 0x17003051 RID: 12369
			// (get) Token: 0x0600FD4A RID: 64842 RVA: 0x0042D3A4 File Offset: 0x0042B5A4
			// (set) Token: 0x0600FD4B RID: 64843 RVA: 0x0042D3B4 File Offset: 0x0042B5B4
			public Text m_descPropDexValueText
			{
				get
				{
					return this.m_owner.m_descPropDexValueText;
				}
				set
				{
					this.m_owner.m_descPropDexValueText = value;
				}
			}

			// Token: 0x17003052 RID: 12370
			// (get) Token: 0x0600FD4C RID: 64844 RVA: 0x0042D3C4 File Offset: 0x0042B5C4
			// (set) Token: 0x0600FD4D RID: 64845 RVA: 0x0042D3D4 File Offset: 0x0042B5D4
			public CommonUIStateController m_descPropGroupStateCtrl
			{
				get
				{
					return this.m_owner.m_descPropGroupStateCtrl;
				}
				set
				{
					this.m_owner.m_descPropGroupStateCtrl = value;
				}
			}

			// Token: 0x17003053 RID: 12371
			// (get) Token: 0x0600FD4E RID: 64846 RVA: 0x0042D3E4 File Offset: 0x0042B5E4
			// (set) Token: 0x0600FD4F RID: 64847 RVA: 0x0042D3F4 File Offset: 0x0042B5F4
			public GameObject m_descPropEnchantmentGroup
			{
				get
				{
					return this.m_owner.m_descPropEnchantmentGroup;
				}
				set
				{
					this.m_owner.m_descPropEnchantmentGroup = value;
				}
			}

			// Token: 0x17003054 RID: 12372
			// (get) Token: 0x0600FD50 RID: 64848 RVA: 0x0042D404 File Offset: 0x0042B604
			// (set) Token: 0x0600FD51 RID: 64849 RVA: 0x0042D414 File Offset: 0x0042B614
			public CommonUIStateController m_descPropEnchantmentGroupRuneStateCtrl
			{
				get
				{
					return this.m_owner.m_descPropEnchantmentGroupRuneStateCtrl;
				}
				set
				{
					this.m_owner.m_descPropEnchantmentGroupRuneStateCtrl = value;
				}
			}

			// Token: 0x17003055 RID: 12373
			// (get) Token: 0x0600FD52 RID: 64850 RVA: 0x0042D424 File Offset: 0x0042B624
			// (set) Token: 0x0600FD53 RID: 64851 RVA: 0x0042D434 File Offset: 0x0042B634
			public Image m_descPropEnchantmentGroupRuneIconImage
			{
				get
				{
					return this.m_owner.m_descPropEnchantmentGroupRuneIconImage;
				}
				set
				{
					this.m_owner.m_descPropEnchantmentGroupRuneIconImage = value;
				}
			}

			// Token: 0x17003056 RID: 12374
			// (get) Token: 0x0600FD54 RID: 64852 RVA: 0x0042D444 File Offset: 0x0042B644
			// (set) Token: 0x0600FD55 RID: 64853 RVA: 0x0042D454 File Offset: 0x0042B654
			public Text m_descPropEnchantmentGroupRuneNameText
			{
				get
				{
					return this.m_owner.m_descPropEnchantmentGroupRuneNameText;
				}
				set
				{
					this.m_owner.m_descPropEnchantmentGroupRuneNameText = value;
				}
			}

			// Token: 0x17003057 RID: 12375
			// (get) Token: 0x0600FD56 RID: 64854 RVA: 0x0042D464 File Offset: 0x0042B664
			// (set) Token: 0x0600FD57 RID: 64855 RVA: 0x0042D474 File Offset: 0x0042B674
			public Text m_enhanceTitleText
			{
				get
				{
					return this.m_owner.m_enhanceTitleText;
				}
				set
				{
					this.m_owner.m_enhanceTitleText = value;
				}
			}

			// Token: 0x17003058 RID: 12376
			// (get) Token: 0x0600FD58 RID: 64856 RVA: 0x0042D484 File Offset: 0x0042B684
			// (set) Token: 0x0600FD59 RID: 64857 RVA: 0x0042D494 File Offset: 0x0042B694
			public Image m_enhanceIcon
			{
				get
				{
					return this.m_owner.m_enhanceIcon;
				}
				set
				{
					this.m_owner.m_enhanceIcon = value;
				}
			}

			// Token: 0x17003059 RID: 12377
			// (get) Token: 0x0600FD5A RID: 64858 RVA: 0x0042D4A4 File Offset: 0x0042B6A4
			// (set) Token: 0x0600FD5B RID: 64859 RVA: 0x0042D4B4 File Offset: 0x0042B6B4
			public Image m_enhanceIconBg
			{
				get
				{
					return this.m_owner.m_enhanceIconBg;
				}
				set
				{
					this.m_owner.m_enhanceIconBg = value;
				}
			}

			// Token: 0x1700305A RID: 12378
			// (get) Token: 0x0600FD5C RID: 64860 RVA: 0x0042D4C4 File Offset: 0x0042B6C4
			// (set) Token: 0x0600FD5D RID: 64861 RVA: 0x0042D4D4 File Offset: 0x0042B6D4
			public GameObject m_enhanceIconSSREffect
			{
				get
				{
					return this.m_owner.m_enhanceIconSSREffect;
				}
				set
				{
					this.m_owner.m_enhanceIconSSREffect = value;
				}
			}

			// Token: 0x1700305B RID: 12379
			// (get) Token: 0x0600FD5E RID: 64862 RVA: 0x0042D4E4 File Offset: 0x0042B6E4
			// (set) Token: 0x0600FD5F RID: 64863 RVA: 0x0042D4F4 File Offset: 0x0042B6F4
			public GameObject m_enhanceStarGroup
			{
				get
				{
					return this.m_owner.m_enhanceStarGroup;
				}
				set
				{
					this.m_owner.m_enhanceStarGroup = value;
				}
			}

			// Token: 0x1700305C RID: 12380
			// (get) Token: 0x0600FD60 RID: 64864 RVA: 0x0042D504 File Offset: 0x0042B704
			// (set) Token: 0x0600FD61 RID: 64865 RVA: 0x0042D514 File Offset: 0x0042B714
			public Text m_enhanceCurLv
			{
				get
				{
					return this.m_owner.m_enhanceCurLv;
				}
				set
				{
					this.m_owner.m_enhanceCurLv = value;
				}
			}

			// Token: 0x1700305D RID: 12381
			// (get) Token: 0x0600FD62 RID: 64866 RVA: 0x0042D524 File Offset: 0x0042B724
			// (set) Token: 0x0600FD63 RID: 64867 RVA: 0x0042D534 File Offset: 0x0042B734
			public Text m_enhanceCurLv1
			{
				get
				{
					return this.m_owner.m_enhanceCurLv1;
				}
				set
				{
					this.m_owner.m_enhanceCurLv1 = value;
				}
			}

			// Token: 0x1700305E RID: 12382
			// (get) Token: 0x0600FD64 RID: 64868 RVA: 0x0042D544 File Offset: 0x0042B744
			// (set) Token: 0x0600FD65 RID: 64869 RVA: 0x0042D554 File Offset: 0x0042B754
			public Text m_enhanceMaxLV
			{
				get
				{
					return this.m_owner.m_enhanceMaxLV;
				}
				set
				{
					this.m_owner.m_enhanceMaxLV = value;
				}
			}

			// Token: 0x1700305F RID: 12383
			// (get) Token: 0x0600FD66 RID: 64870 RVA: 0x0042D564 File Offset: 0x0042B764
			// (set) Token: 0x0600FD67 RID: 64871 RVA: 0x0042D574 File Offset: 0x0042B774
			public Image m_enhanceProgressImage
			{
				get
				{
					return this.m_owner.m_enhanceProgressImage;
				}
				set
				{
					this.m_owner.m_enhanceProgressImage = value;
				}
			}

			// Token: 0x17003060 RID: 12384
			// (get) Token: 0x0600FD68 RID: 64872 RVA: 0x0042D584 File Offset: 0x0042B784
			// (set) Token: 0x0600FD69 RID: 64873 RVA: 0x0042D594 File Offset: 0x0042B794
			public Image m_enhanceWillGetExpImage
			{
				get
				{
					return this.m_owner.m_enhanceWillGetExpImage;
				}
				set
				{
					this.m_owner.m_enhanceWillGetExpImage = value;
				}
			}

			// Token: 0x17003061 RID: 12385
			// (get) Token: 0x0600FD6A RID: 64874 RVA: 0x0042D5A4 File Offset: 0x0042B7A4
			// (set) Token: 0x0600FD6B RID: 64875 RVA: 0x0042D5B4 File Offset: 0x0042B7B4
			public Text m_enhanceExpCurValueText
			{
				get
				{
					return this.m_owner.m_enhanceExpCurValueText;
				}
				set
				{
					this.m_owner.m_enhanceExpCurValueText = value;
				}
			}

			// Token: 0x17003062 RID: 12386
			// (get) Token: 0x0600FD6C RID: 64876 RVA: 0x0042D5C4 File Offset: 0x0042B7C4
			// (set) Token: 0x0600FD6D RID: 64877 RVA: 0x0042D5D4 File Offset: 0x0042B7D4
			public Text m_enhanceExpAddValueText
			{
				get
				{
					return this.m_owner.m_enhanceExpAddValueText;
				}
				set
				{
					this.m_owner.m_enhanceExpAddValueText = value;
				}
			}

			// Token: 0x17003063 RID: 12387
			// (get) Token: 0x0600FD6E RID: 64878 RVA: 0x0042D5E4 File Offset: 0x0042B7E4
			// (set) Token: 0x0600FD6F RID: 64879 RVA: 0x0042D5F4 File Offset: 0x0042B7F4
			public Text m_enhanceExpNextLvText
			{
				get
				{
					return this.m_owner.m_enhanceExpNextLvText;
				}
				set
				{
					this.m_owner.m_enhanceExpNextLvText = value;
				}
			}

			// Token: 0x17003064 RID: 12388
			// (get) Token: 0x0600FD70 RID: 64880 RVA: 0x0042D604 File Offset: 0x0042B804
			// (set) Token: 0x0600FD71 RID: 64881 RVA: 0x0042D614 File Offset: 0x0042B814
			public GameObject m_enhanceMaterialsContent
			{
				get
				{
					return this.m_owner.m_enhanceMaterialsContent;
				}
				set
				{
					this.m_owner.m_enhanceMaterialsContent = value;
				}
			}

			// Token: 0x17003065 RID: 12389
			// (get) Token: 0x0600FD72 RID: 64882 RVA: 0x0042D624 File Offset: 0x0042B824
			// (set) Token: 0x0600FD73 RID: 64883 RVA: 0x0042D634 File Offset: 0x0042B834
			public Text m_enhanceGoldText
			{
				get
				{
					return this.m_owner.m_enhanceGoldText;
				}
				set
				{
					this.m_owner.m_enhanceGoldText = value;
				}
			}

			// Token: 0x17003066 RID: 12390
			// (get) Token: 0x0600FD74 RID: 64884 RVA: 0x0042D644 File Offset: 0x0042B844
			// (set) Token: 0x0600FD75 RID: 64885 RVA: 0x0042D654 File Offset: 0x0042B854
			public Button m_enhanceButton
			{
				get
				{
					return this.m_owner.m_enhanceButton;
				}
				set
				{
					this.m_owner.m_enhanceButton = value;
				}
			}

			// Token: 0x17003067 RID: 12391
			// (get) Token: 0x0600FD76 RID: 64886 RVA: 0x0042D664 File Offset: 0x0042B864
			// (set) Token: 0x0600FD77 RID: 64887 RVA: 0x0042D674 File Offset: 0x0042B874
			public GameObject m_enhanceSuccessEffectPanel
			{
				get
				{
					return this.m_owner.m_enhanceSuccessEffectPanel;
				}
				set
				{
					this.m_owner.m_enhanceSuccessEffectPanel = value;
				}
			}

			// Token: 0x17003068 RID: 12392
			// (get) Token: 0x0600FD78 RID: 64888 RVA: 0x0042D684 File Offset: 0x0042B884
			// (set) Token: 0x0600FD79 RID: 64889 RVA: 0x0042D694 File Offset: 0x0042B894
			public Button m_enhanceSuccessEffectPanelCloseButton
			{
				get
				{
					return this.m_owner.m_enhanceSuccessEffectPanelCloseButton;
				}
				set
				{
					this.m_owner.m_enhanceSuccessEffectPanelCloseButton = value;
				}
			}

			// Token: 0x17003069 RID: 12393
			// (get) Token: 0x0600FD7A RID: 64890 RVA: 0x0042D6A4 File Offset: 0x0042B8A4
			// (set) Token: 0x0600FD7B RID: 64891 RVA: 0x0042D6B4 File Offset: 0x0042B8B4
			public GameObject m_enhanceConfirmPanel
			{
				get
				{
					return this.m_owner.m_enhanceConfirmPanel;
				}
				set
				{
					this.m_owner.m_enhanceConfirmPanel = value;
				}
			}

			// Token: 0x1700306A RID: 12394
			// (get) Token: 0x0600FD7C RID: 64892 RVA: 0x0042D6C4 File Offset: 0x0042B8C4
			// (set) Token: 0x0600FD7D RID: 64893 RVA: 0x0042D6D4 File Offset: 0x0042B8D4
			public Button m_enhanceConfirmButton
			{
				get
				{
					return this.m_owner.m_enhanceConfirmButton;
				}
				set
				{
					this.m_owner.m_enhanceConfirmButton = value;
				}
			}

			// Token: 0x1700306B RID: 12395
			// (get) Token: 0x0600FD7E RID: 64894 RVA: 0x0042D6E4 File Offset: 0x0042B8E4
			// (set) Token: 0x0600FD7F RID: 64895 RVA: 0x0042D6F4 File Offset: 0x0042B8F4
			public Button m_enhanceCancelButton
			{
				get
				{
					return this.m_owner.m_enhanceCancelButton;
				}
				set
				{
					this.m_owner.m_enhanceCancelButton = value;
				}
			}

			// Token: 0x1700306C RID: 12396
			// (get) Token: 0x0600FD80 RID: 64896 RVA: 0x0042D704 File Offset: 0x0042B904
			// (set) Token: 0x0600FD81 RID: 64897 RVA: 0x0042D714 File Offset: 0x0042B914
			public Text m_enhanceConfirmPanelTip1
			{
				get
				{
					return this.m_owner.m_enhanceConfirmPanelTip1;
				}
				set
				{
					this.m_owner.m_enhanceConfirmPanelTip1 = value;
				}
			}

			// Token: 0x1700306D RID: 12397
			// (get) Token: 0x0600FD82 RID: 64898 RVA: 0x0042D724 File Offset: 0x0042B924
			// (set) Token: 0x0600FD83 RID: 64899 RVA: 0x0042D734 File Offset: 0x0042B934
			public Text m_enhanceConfirmPanelTip2
			{
				get
				{
					return this.m_owner.m_enhanceConfirmPanelTip2;
				}
				set
				{
					this.m_owner.m_enhanceConfirmPanelTip2 = value;
				}
			}

			// Token: 0x1700306E RID: 12398
			// (get) Token: 0x0600FD84 RID: 64900 RVA: 0x0042D744 File Offset: 0x0042B944
			// (set) Token: 0x0600FD85 RID: 64901 RVA: 0x0042D754 File Offset: 0x0042B954
			public GameObject m_enhanceItemSRConfirmPanel
			{
				get
				{
					return this.m_owner.m_enhanceItemSRConfirmPanel;
				}
				set
				{
					this.m_owner.m_enhanceItemSRConfirmPanel = value;
				}
			}

			// Token: 0x1700306F RID: 12399
			// (get) Token: 0x0600FD86 RID: 64902 RVA: 0x0042D764 File Offset: 0x0042B964
			// (set) Token: 0x0600FD87 RID: 64903 RVA: 0x0042D774 File Offset: 0x0042B974
			public Button m_enhanceItemSRConfirmButton
			{
				get
				{
					return this.m_owner.m_enhanceItemSRConfirmButton;
				}
				set
				{
					this.m_owner.m_enhanceItemSRConfirmButton = value;
				}
			}

			// Token: 0x17003070 RID: 12400
			// (get) Token: 0x0600FD88 RID: 64904 RVA: 0x0042D784 File Offset: 0x0042B984
			// (set) Token: 0x0600FD89 RID: 64905 RVA: 0x0042D794 File Offset: 0x0042B994
			public Button m_enhanceItemSRCancelButton
			{
				get
				{
					return this.m_owner.m_enhanceItemSRCancelButton;
				}
				set
				{
					this.m_owner.m_enhanceItemSRCancelButton = value;
				}
			}

			// Token: 0x17003071 RID: 12401
			// (get) Token: 0x0600FD8A RID: 64906 RVA: 0x0042D7A4 File Offset: 0x0042B9A4
			// (set) Token: 0x0600FD8B RID: 64907 RVA: 0x0042D7B4 File Offset: 0x0042B9B4
			public Text m_enhanceItemSRTip
			{
				get
				{
					return this.m_owner.m_enhanceItemSRTip;
				}
				set
				{
					this.m_owner.m_enhanceItemSRTip = value;
				}
			}

			// Token: 0x17003072 RID: 12402
			// (get) Token: 0x0600FD8C RID: 64908 RVA: 0x0042D7C4 File Offset: 0x0042B9C4
			// (set) Token: 0x0600FD8D RID: 64909 RVA: 0x0042D7D4 File Offset: 0x0042B9D4
			public CommonUIStateController m_intensifySuccessPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_intensifySuccessPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_intensifySuccessPanelStateCtrl = value;
				}
			}

			// Token: 0x17003073 RID: 12403
			// (get) Token: 0x0600FD8E RID: 64910 RVA: 0x0042D7E4 File Offset: 0x0042B9E4
			// (set) Token: 0x0600FD8F RID: 64911 RVA: 0x0042D7F4 File Offset: 0x0042B9F4
			public CommonUIStateController m_intensifySuccessPanelInfoStateCtrl
			{
				get
				{
					return this.m_owner.m_intensifySuccessPanelInfoStateCtrl;
				}
				set
				{
					this.m_owner.m_intensifySuccessPanelInfoStateCtrl = value;
				}
			}

			// Token: 0x17003074 RID: 12404
			// (get) Token: 0x0600FD90 RID: 64912 RVA: 0x0042D804 File Offset: 0x0042BA04
			// (set) Token: 0x0600FD91 RID: 64913 RVA: 0x0042D814 File Offset: 0x0042BA14
			public Image m_intensifySuccessPanelInfoIconBg
			{
				get
				{
					return this.m_owner.m_intensifySuccessPanelInfoIconBg;
				}
				set
				{
					this.m_owner.m_intensifySuccessPanelInfoIconBg = value;
				}
			}

			// Token: 0x17003075 RID: 12405
			// (get) Token: 0x0600FD92 RID: 64914 RVA: 0x0042D824 File Offset: 0x0042BA24
			// (set) Token: 0x0600FD93 RID: 64915 RVA: 0x0042D834 File Offset: 0x0042BA34
			public Image m_intensifySuccessPanelInfoIcon
			{
				get
				{
					return this.m_owner.m_intensifySuccessPanelInfoIcon;
				}
				set
				{
					this.m_owner.m_intensifySuccessPanelInfoIcon = value;
				}
			}

			// Token: 0x17003076 RID: 12406
			// (get) Token: 0x0600FD94 RID: 64916 RVA: 0x0042D844 File Offset: 0x0042BA44
			// (set) Token: 0x0600FD95 RID: 64917 RVA: 0x0042D854 File Offset: 0x0042BA54
			public GameObject m_intensifySuccessPanelInfoStarGroup
			{
				get
				{
					return this.m_owner.m_intensifySuccessPanelInfoStarGroup;
				}
				set
				{
					this.m_owner.m_intensifySuccessPanelInfoStarGroup = value;
				}
			}

			// Token: 0x17003077 RID: 12407
			// (get) Token: 0x0600FD96 RID: 64918 RVA: 0x0042D864 File Offset: 0x0042BA64
			// (set) Token: 0x0600FD97 RID: 64919 RVA: 0x0042D874 File Offset: 0x0042BA74
			public Text m_intensifySuccessPanelCurLvText
			{
				get
				{
					return this.m_owner.m_intensifySuccessPanelCurLvText;
				}
				set
				{
					this.m_owner.m_intensifySuccessPanelCurLvText = value;
				}
			}

			// Token: 0x17003078 RID: 12408
			// (get) Token: 0x0600FD98 RID: 64920 RVA: 0x0042D884 File Offset: 0x0042BA84
			// (set) Token: 0x0600FD99 RID: 64921 RVA: 0x0042D894 File Offset: 0x0042BA94
			public Text m_intensifySuccessPanelNextLvText
			{
				get
				{
					return this.m_owner.m_intensifySuccessPanelNextLvText;
				}
				set
				{
					this.m_owner.m_intensifySuccessPanelNextLvText = value;
				}
			}

			// Token: 0x17003079 RID: 12409
			// (get) Token: 0x0600FD9A RID: 64922 RVA: 0x0042D8A4 File Offset: 0x0042BAA4
			// (set) Token: 0x0600FD9B RID: 64923 RVA: 0x0042D8B4 File Offset: 0x0042BAB4
			public Text m_intensifySuccessPanelSkillNameText
			{
				get
				{
					return this.m_owner.m_intensifySuccessPanelSkillNameText;
				}
				set
				{
					this.m_owner.m_intensifySuccessPanelSkillNameText = value;
				}
			}

			// Token: 0x1700307A RID: 12410
			// (get) Token: 0x0600FD9C RID: 64924 RVA: 0x0042D8C4 File Offset: 0x0042BAC4
			// (set) Token: 0x0600FD9D RID: 64925 RVA: 0x0042D8D4 File Offset: 0x0042BAD4
			public Text m_intensifySuccessPanelSkillDescText
			{
				get
				{
					return this.m_owner.m_intensifySuccessPanelSkillDescText;
				}
				set
				{
					this.m_owner.m_intensifySuccessPanelSkillDescText = value;
				}
			}

			// Token: 0x1700307B RID: 12411
			// (get) Token: 0x0600FD9E RID: 64926 RVA: 0x0042D8E4 File Offset: 0x0042BAE4
			// (set) Token: 0x0600FD9F RID: 64927 RVA: 0x0042D8F4 File Offset: 0x0042BAF4
			public Button m_intensifySuccessPanelBlackButton
			{
				get
				{
					return this.m_owner.m_intensifySuccessPanelBlackButton;
				}
				set
				{
					this.m_owner.m_intensifySuccessPanelBlackButton = value;
				}
			}

			// Token: 0x1700307C RID: 12412
			// (get) Token: 0x0600FDA0 RID: 64928 RVA: 0x0042D904 File Offset: 0x0042BB04
			// (set) Token: 0x0600FDA1 RID: 64929 RVA: 0x0042D914 File Offset: 0x0042BB14
			public GameObject m_enhancePropGroupGo
			{
				get
				{
					return this.m_owner.m_enhancePropGroupGo;
				}
				set
				{
					this.m_owner.m_enhancePropGroupGo = value;
				}
			}

			// Token: 0x1700307D RID: 12413
			// (get) Token: 0x0600FDA2 RID: 64930 RVA: 0x0042D924 File Offset: 0x0042BB24
			// (set) Token: 0x0600FDA3 RID: 64931 RVA: 0x0042D934 File Offset: 0x0042BB34
			public GameObject m_enhancePropHpGo
			{
				get
				{
					return this.m_owner.m_enhancePropHpGo;
				}
				set
				{
					this.m_owner.m_enhancePropHpGo = value;
				}
			}

			// Token: 0x1700307E RID: 12414
			// (get) Token: 0x0600FDA4 RID: 64932 RVA: 0x0042D944 File Offset: 0x0042BB44
			// (set) Token: 0x0600FDA5 RID: 64933 RVA: 0x0042D954 File Offset: 0x0042BB54
			public Text m_enhancePropHpOldValueText
			{
				get
				{
					return this.m_owner.m_enhancePropHpOldValueText;
				}
				set
				{
					this.m_owner.m_enhancePropHpOldValueText = value;
				}
			}

			// Token: 0x1700307F RID: 12415
			// (get) Token: 0x0600FDA6 RID: 64934 RVA: 0x0042D964 File Offset: 0x0042BB64
			// (set) Token: 0x0600FDA7 RID: 64935 RVA: 0x0042D974 File Offset: 0x0042BB74
			public Text m_enhancePropHpNewValueText
			{
				get
				{
					return this.m_owner.m_enhancePropHpNewValueText;
				}
				set
				{
					this.m_owner.m_enhancePropHpNewValueText = value;
				}
			}

			// Token: 0x17003080 RID: 12416
			// (get) Token: 0x0600FDA8 RID: 64936 RVA: 0x0042D984 File Offset: 0x0042BB84
			// (set) Token: 0x0600FDA9 RID: 64937 RVA: 0x0042D994 File Offset: 0x0042BB94
			public GameObject m_enhancePropATGo
			{
				get
				{
					return this.m_owner.m_enhancePropATGo;
				}
				set
				{
					this.m_owner.m_enhancePropATGo = value;
				}
			}

			// Token: 0x17003081 RID: 12417
			// (get) Token: 0x0600FDAA RID: 64938 RVA: 0x0042D9A4 File Offset: 0x0042BBA4
			// (set) Token: 0x0600FDAB RID: 64939 RVA: 0x0042D9B4 File Offset: 0x0042BBB4
			public Text m_enhancePropATOldValueText
			{
				get
				{
					return this.m_owner.m_enhancePropATOldValueText;
				}
				set
				{
					this.m_owner.m_enhancePropATOldValueText = value;
				}
			}

			// Token: 0x17003082 RID: 12418
			// (get) Token: 0x0600FDAC RID: 64940 RVA: 0x0042D9C4 File Offset: 0x0042BBC4
			// (set) Token: 0x0600FDAD RID: 64941 RVA: 0x0042D9D4 File Offset: 0x0042BBD4
			public Text m_enhancePropATNewValueText
			{
				get
				{
					return this.m_owner.m_enhancePropATNewValueText;
				}
				set
				{
					this.m_owner.m_enhancePropATNewValueText = value;
				}
			}

			// Token: 0x17003083 RID: 12419
			// (get) Token: 0x0600FDAE RID: 64942 RVA: 0x0042D9E4 File Offset: 0x0042BBE4
			// (set) Token: 0x0600FDAF RID: 64943 RVA: 0x0042D9F4 File Offset: 0x0042BBF4
			public GameObject m_enhancePropDFGo
			{
				get
				{
					return this.m_owner.m_enhancePropDFGo;
				}
				set
				{
					this.m_owner.m_enhancePropDFGo = value;
				}
			}

			// Token: 0x17003084 RID: 12420
			// (get) Token: 0x0600FDB0 RID: 64944 RVA: 0x0042DA04 File Offset: 0x0042BC04
			// (set) Token: 0x0600FDB1 RID: 64945 RVA: 0x0042DA14 File Offset: 0x0042BC14
			public Text m_enhancePropDFOldValueText
			{
				get
				{
					return this.m_owner.m_enhancePropDFOldValueText;
				}
				set
				{
					this.m_owner.m_enhancePropDFOldValueText = value;
				}
			}

			// Token: 0x17003085 RID: 12421
			// (get) Token: 0x0600FDB2 RID: 64946 RVA: 0x0042DA24 File Offset: 0x0042BC24
			// (set) Token: 0x0600FDB3 RID: 64947 RVA: 0x0042DA34 File Offset: 0x0042BC34
			public Text m_enhancePropDFNewValueText
			{
				get
				{
					return this.m_owner.m_enhancePropDFNewValueText;
				}
				set
				{
					this.m_owner.m_enhancePropDFNewValueText = value;
				}
			}

			// Token: 0x17003086 RID: 12422
			// (get) Token: 0x0600FDB4 RID: 64948 RVA: 0x0042DA44 File Offset: 0x0042BC44
			// (set) Token: 0x0600FDB5 RID: 64949 RVA: 0x0042DA54 File Offset: 0x0042BC54
			public GameObject m_enhancePropMagicGo
			{
				get
				{
					return this.m_owner.m_enhancePropMagicGo;
				}
				set
				{
					this.m_owner.m_enhancePropMagicGo = value;
				}
			}

			// Token: 0x17003087 RID: 12423
			// (get) Token: 0x0600FDB6 RID: 64950 RVA: 0x0042DA64 File Offset: 0x0042BC64
			// (set) Token: 0x0600FDB7 RID: 64951 RVA: 0x0042DA74 File Offset: 0x0042BC74
			public Text m_enhancePropMagicOldValueText
			{
				get
				{
					return this.m_owner.m_enhancePropMagicOldValueText;
				}
				set
				{
					this.m_owner.m_enhancePropMagicOldValueText = value;
				}
			}

			// Token: 0x17003088 RID: 12424
			// (get) Token: 0x0600FDB8 RID: 64952 RVA: 0x0042DA84 File Offset: 0x0042BC84
			// (set) Token: 0x0600FDB9 RID: 64953 RVA: 0x0042DA94 File Offset: 0x0042BC94
			public Text m_enhancePropMagicNewValueText
			{
				get
				{
					return this.m_owner.m_enhancePropMagicNewValueText;
				}
				set
				{
					this.m_owner.m_enhancePropMagicNewValueText = value;
				}
			}

			// Token: 0x17003089 RID: 12425
			// (get) Token: 0x0600FDBA RID: 64954 RVA: 0x0042DAA4 File Offset: 0x0042BCA4
			// (set) Token: 0x0600FDBB RID: 64955 RVA: 0x0042DAB4 File Offset: 0x0042BCB4
			public GameObject m_enhancePropMagicDFGo
			{
				get
				{
					return this.m_owner.m_enhancePropMagicDFGo;
				}
				set
				{
					this.m_owner.m_enhancePropMagicDFGo = value;
				}
			}

			// Token: 0x1700308A RID: 12426
			// (get) Token: 0x0600FDBC RID: 64956 RVA: 0x0042DAC4 File Offset: 0x0042BCC4
			// (set) Token: 0x0600FDBD RID: 64957 RVA: 0x0042DAD4 File Offset: 0x0042BCD4
			public Text m_enhancePropMagicDFOldValueText
			{
				get
				{
					return this.m_owner.m_enhancePropMagicDFOldValueText;
				}
				set
				{
					this.m_owner.m_enhancePropMagicDFOldValueText = value;
				}
			}

			// Token: 0x1700308B RID: 12427
			// (get) Token: 0x0600FDBE RID: 64958 RVA: 0x0042DAE4 File Offset: 0x0042BCE4
			// (set) Token: 0x0600FDBF RID: 64959 RVA: 0x0042DAF4 File Offset: 0x0042BCF4
			public Text m_enhancePropMagicDFNewValueText
			{
				get
				{
					return this.m_owner.m_enhancePropMagicDFNewValueText;
				}
				set
				{
					this.m_owner.m_enhancePropMagicDFNewValueText = value;
				}
			}

			// Token: 0x1700308C RID: 12428
			// (get) Token: 0x0600FDC0 RID: 64960 RVA: 0x0042DB04 File Offset: 0x0042BD04
			// (set) Token: 0x0600FDC1 RID: 64961 RVA: 0x0042DB14 File Offset: 0x0042BD14
			public GameObject m_enhancePropDEXGo
			{
				get
				{
					return this.m_owner.m_enhancePropDEXGo;
				}
				set
				{
					this.m_owner.m_enhancePropDEXGo = value;
				}
			}

			// Token: 0x1700308D RID: 12429
			// (get) Token: 0x0600FDC2 RID: 64962 RVA: 0x0042DB24 File Offset: 0x0042BD24
			// (set) Token: 0x0600FDC3 RID: 64963 RVA: 0x0042DB34 File Offset: 0x0042BD34
			public Text m_enhancePropDEXOldValueText
			{
				get
				{
					return this.m_owner.m_enhancePropDEXOldValueText;
				}
				set
				{
					this.m_owner.m_enhancePropDEXOldValueText = value;
				}
			}

			// Token: 0x1700308E RID: 12430
			// (get) Token: 0x0600FDC4 RID: 64964 RVA: 0x0042DB44 File Offset: 0x0042BD44
			// (set) Token: 0x0600FDC5 RID: 64965 RVA: 0x0042DB54 File Offset: 0x0042BD54
			public Text m_enhancePropDEXNewValueText
			{
				get
				{
					return this.m_owner.m_enhancePropDEXNewValueText;
				}
				set
				{
					this.m_owner.m_enhancePropDEXNewValueText = value;
				}
			}

			// Token: 0x1700308F RID: 12431
			// (get) Token: 0x0600FDC6 RID: 64966 RVA: 0x0042DB64 File Offset: 0x0042BD64
			// (set) Token: 0x0600FDC7 RID: 64967 RVA: 0x0042DB74 File Offset: 0x0042BD74
			public CommonUIStateController m_enhancePropSkillStateCtrl
			{
				get
				{
					return this.m_owner.m_enhancePropSkillStateCtrl;
				}
				set
				{
					this.m_owner.m_enhancePropSkillStateCtrl = value;
				}
			}

			// Token: 0x17003090 RID: 12432
			// (get) Token: 0x0600FDC8 RID: 64968 RVA: 0x0042DB84 File Offset: 0x0042BD84
			// (set) Token: 0x0600FDC9 RID: 64969 RVA: 0x0042DB94 File Offset: 0x0042BD94
			public Text m_enhancePropSkillNameText
			{
				get
				{
					return this.m_owner.m_enhancePropSkillNameText;
				}
				set
				{
					this.m_owner.m_enhancePropSkillNameText = value;
				}
			}

			// Token: 0x17003091 RID: 12433
			// (get) Token: 0x0600FDCA RID: 64970 RVA: 0x0042DBA4 File Offset: 0x0042BDA4
			// (set) Token: 0x0600FDCB RID: 64971 RVA: 0x0042DBB4 File Offset: 0x0042BDB4
			public Text m_enhancePropSkillOldValueText
			{
				get
				{
					return this.m_owner.m_enhancePropSkillOldValueText;
				}
				set
				{
					this.m_owner.m_enhancePropSkillOldValueText = value;
				}
			}

			// Token: 0x17003092 RID: 12434
			// (get) Token: 0x0600FDCC RID: 64972 RVA: 0x0042DBC4 File Offset: 0x0042BDC4
			// (set) Token: 0x0600FDCD RID: 64973 RVA: 0x0042DBD4 File Offset: 0x0042BDD4
			public Text m_enhancePropSkillNewValueText
			{
				get
				{
					return this.m_owner.m_enhancePropSkillNewValueText;
				}
				set
				{
					this.m_owner.m_enhancePropSkillNewValueText = value;
				}
			}

			// Token: 0x17003093 RID: 12435
			// (get) Token: 0x0600FDCE RID: 64974 RVA: 0x0042DBE4 File Offset: 0x0042BDE4
			// (set) Token: 0x0600FDCF RID: 64975 RVA: 0x0042DBF4 File Offset: 0x0042BDF4
			public Text m_enhancePropSkillConditionText
			{
				get
				{
					return this.m_owner.m_enhancePropSkillConditionText;
				}
				set
				{
					this.m_owner.m_enhancePropSkillConditionText = value;
				}
			}

			// Token: 0x17003094 RID: 12436
			// (get) Token: 0x0600FDD0 RID: 64976 RVA: 0x0042DC04 File Offset: 0x0042BE04
			// (set) Token: 0x0600FDD1 RID: 64977 RVA: 0x0042DC14 File Offset: 0x0042BE14
			public Button m_enhanceFastAddButton
			{
				get
				{
					return this.m_owner.m_enhanceFastAddButton;
				}
				set
				{
					this.m_owner.m_enhanceFastAddButton = value;
				}
			}

			// Token: 0x17003095 RID: 12437
			// (get) Token: 0x0600FDD2 RID: 64978 RVA: 0x0042DC24 File Offset: 0x0042BE24
			// (set) Token: 0x0600FDD3 RID: 64979 RVA: 0x0042DC34 File Offset: 0x0042BE34
			public GameObject m_breakGo
			{
				get
				{
					return this.m_owner.m_breakGo;
				}
				set
				{
					this.m_owner.m_breakGo = value;
				}
			}

			// Token: 0x17003096 RID: 12438
			// (get) Token: 0x0600FDD4 RID: 64980 RVA: 0x0042DC44 File Offset: 0x0042BE44
			// (set) Token: 0x0600FDD5 RID: 64981 RVA: 0x0042DC54 File Offset: 0x0042BE54
			public Text m_breakTitleText
			{
				get
				{
					return this.m_owner.m_breakTitleText;
				}
				set
				{
					this.m_owner.m_breakTitleText = value;
				}
			}

			// Token: 0x17003097 RID: 12439
			// (get) Token: 0x0600FDD6 RID: 64982 RVA: 0x0042DC64 File Offset: 0x0042BE64
			// (set) Token: 0x0600FDD7 RID: 64983 RVA: 0x0042DC74 File Offset: 0x0042BE74
			public Image m_breakCurLvEquipmentIcon
			{
				get
				{
					return this.m_owner.m_breakCurLvEquipmentIcon;
				}
				set
				{
					this.m_owner.m_breakCurLvEquipmentIcon = value;
				}
			}

			// Token: 0x17003098 RID: 12440
			// (get) Token: 0x0600FDD8 RID: 64984 RVA: 0x0042DC84 File Offset: 0x0042BE84
			// (set) Token: 0x0600FDD9 RID: 64985 RVA: 0x0042DC94 File Offset: 0x0042BE94
			public Image m_breakCurLvEquipmentIconBg
			{
				get
				{
					return this.m_owner.m_breakCurLvEquipmentIconBg;
				}
				set
				{
					this.m_owner.m_breakCurLvEquipmentIconBg = value;
				}
			}

			// Token: 0x17003099 RID: 12441
			// (get) Token: 0x0600FDDA RID: 64986 RVA: 0x0042DCA4 File Offset: 0x0042BEA4
			// (set) Token: 0x0600FDDB RID: 64987 RVA: 0x0042DCB4 File Offset: 0x0042BEB4
			public GameObject m_breakCurLvEquipmentIconSSREffect
			{
				get
				{
					return this.m_owner.m_breakCurLvEquipmentIconSSREffect;
				}
				set
				{
					this.m_owner.m_breakCurLvEquipmentIconSSREffect = value;
				}
			}

			// Token: 0x1700309A RID: 12442
			// (get) Token: 0x0600FDDC RID: 64988 RVA: 0x0042DCC4 File Offset: 0x0042BEC4
			// (set) Token: 0x0600FDDD RID: 64989 RVA: 0x0042DCD4 File Offset: 0x0042BED4
			public GameObject m_breakCurLvEquipmentStarGroup
			{
				get
				{
					return this.m_owner.m_breakCurLvEquipmentStarGroup;
				}
				set
				{
					this.m_owner.m_breakCurLvEquipmentStarGroup = value;
				}
			}

			// Token: 0x1700309B RID: 12443
			// (get) Token: 0x0600FDDE RID: 64990 RVA: 0x0042DCE4 File Offset: 0x0042BEE4
			// (set) Token: 0x0600FDDF RID: 64991 RVA: 0x0042DCF4 File Offset: 0x0042BEF4
			public Text m_breakCurLvEquipmentOldLvText
			{
				get
				{
					return this.m_owner.m_breakCurLvEquipmentOldLvText;
				}
				set
				{
					this.m_owner.m_breakCurLvEquipmentOldLvText = value;
				}
			}

			// Token: 0x1700309C RID: 12444
			// (get) Token: 0x0600FDE0 RID: 64992 RVA: 0x0042DD04 File Offset: 0x0042BF04
			// (set) Token: 0x0600FDE1 RID: 64993 RVA: 0x0042DD14 File Offset: 0x0042BF14
			public Text m_breakCurLvEquipmentMaxLvText
			{
				get
				{
					return this.m_owner.m_breakCurLvEquipmentMaxLvText;
				}
				set
				{
					this.m_owner.m_breakCurLvEquipmentMaxLvText = value;
				}
			}

			// Token: 0x1700309D RID: 12445
			// (get) Token: 0x0600FDE2 RID: 64994 RVA: 0x0042DD24 File Offset: 0x0042BF24
			// (set) Token: 0x0600FDE3 RID: 64995 RVA: 0x0042DD34 File Offset: 0x0042BF34
			public Image m_breakNextLvEquipmentIcon
			{
				get
				{
					return this.m_owner.m_breakNextLvEquipmentIcon;
				}
				set
				{
					this.m_owner.m_breakNextLvEquipmentIcon = value;
				}
			}

			// Token: 0x1700309E RID: 12446
			// (get) Token: 0x0600FDE4 RID: 64996 RVA: 0x0042DD44 File Offset: 0x0042BF44
			// (set) Token: 0x0600FDE5 RID: 64997 RVA: 0x0042DD54 File Offset: 0x0042BF54
			public Image m_breakNextLvEquipmentIconBg
			{
				get
				{
					return this.m_owner.m_breakNextLvEquipmentIconBg;
				}
				set
				{
					this.m_owner.m_breakNextLvEquipmentIconBg = value;
				}
			}

			// Token: 0x1700309F RID: 12447
			// (get) Token: 0x0600FDE6 RID: 64998 RVA: 0x0042DD64 File Offset: 0x0042BF64
			// (set) Token: 0x0600FDE7 RID: 64999 RVA: 0x0042DD74 File Offset: 0x0042BF74
			public GameObject m_breakNextLvEquipmentIconSSREffect
			{
				get
				{
					return this.m_owner.m_breakNextLvEquipmentIconSSREffect;
				}
				set
				{
					this.m_owner.m_breakNextLvEquipmentIconSSREffect = value;
				}
			}

			// Token: 0x170030A0 RID: 12448
			// (get) Token: 0x0600FDE8 RID: 65000 RVA: 0x0042DD84 File Offset: 0x0042BF84
			// (set) Token: 0x0600FDE9 RID: 65001 RVA: 0x0042DD94 File Offset: 0x0042BF94
			public GameObject m_breakNextLvEquipmentStarGroup
			{
				get
				{
					return this.m_owner.m_breakNextLvEquipmentStarGroup;
				}
				set
				{
					this.m_owner.m_breakNextLvEquipmentStarGroup = value;
				}
			}

			// Token: 0x170030A1 RID: 12449
			// (get) Token: 0x0600FDEA RID: 65002 RVA: 0x0042DDA4 File Offset: 0x0042BFA4
			// (set) Token: 0x0600FDEB RID: 65003 RVA: 0x0042DDB4 File Offset: 0x0042BFB4
			public Text m_breakNextLvEquipmentOldLvText
			{
				get
				{
					return this.m_owner.m_breakNextLvEquipmentOldLvText;
				}
				set
				{
					this.m_owner.m_breakNextLvEquipmentOldLvText = value;
				}
			}

			// Token: 0x170030A2 RID: 12450
			// (get) Token: 0x0600FDEC RID: 65004 RVA: 0x0042DDC4 File Offset: 0x0042BFC4
			// (set) Token: 0x0600FDED RID: 65005 RVA: 0x0042DDD4 File Offset: 0x0042BFD4
			public Text m_breakNextLvEquipmentMaxLvText
			{
				get
				{
					return this.m_owner.m_breakNextLvEquipmentMaxLvText;
				}
				set
				{
					this.m_owner.m_breakNextLvEquipmentMaxLvText = value;
				}
			}

			// Token: 0x170030A3 RID: 12451
			// (get) Token: 0x0600FDEE RID: 65006 RVA: 0x0042DDE4 File Offset: 0x0042BFE4
			// (set) Token: 0x0600FDEF RID: 65007 RVA: 0x0042DDF4 File Offset: 0x0042BFF4
			public GameObject m_breakMaterialIconGo
			{
				get
				{
					return this.m_owner.m_breakMaterialIconGo;
				}
				set
				{
					this.m_owner.m_breakMaterialIconGo = value;
				}
			}

			// Token: 0x170030A4 RID: 12452
			// (get) Token: 0x0600FDF0 RID: 65008 RVA: 0x0042DE04 File Offset: 0x0042C004
			// (set) Token: 0x0600FDF1 RID: 65009 RVA: 0x0042DE14 File Offset: 0x0042C014
			public Image m_breakMaterialIcon
			{
				get
				{
					return this.m_owner.m_breakMaterialIcon;
				}
				set
				{
					this.m_owner.m_breakMaterialIcon = value;
				}
			}

			// Token: 0x170030A5 RID: 12453
			// (get) Token: 0x0600FDF2 RID: 65010 RVA: 0x0042DE24 File Offset: 0x0042C024
			// (set) Token: 0x0600FDF3 RID: 65011 RVA: 0x0042DE34 File Offset: 0x0042C034
			public Image m_breakMaterialIconBg
			{
				get
				{
					return this.m_owner.m_breakMaterialIconBg;
				}
				set
				{
					this.m_owner.m_breakMaterialIconBg = value;
				}
			}

			// Token: 0x170030A6 RID: 12454
			// (get) Token: 0x0600FDF4 RID: 65012 RVA: 0x0042DE44 File Offset: 0x0042C044
			// (set) Token: 0x0600FDF5 RID: 65013 RVA: 0x0042DE54 File Offset: 0x0042C054
			public GameObject m_breakMaterialSSREffect
			{
				get
				{
					return this.m_owner.m_breakMaterialSSREffect;
				}
				set
				{
					this.m_owner.m_breakMaterialSSREffect = value;
				}
			}

			// Token: 0x170030A7 RID: 12455
			// (get) Token: 0x0600FDF6 RID: 65014 RVA: 0x0042DE64 File Offset: 0x0042C064
			// (set) Token: 0x0600FDF7 RID: 65015 RVA: 0x0042DE74 File Offset: 0x0042C074
			public GameObject m_breakItemsContent
			{
				get
				{
					return this.m_owner.m_breakItemsContent;
				}
				set
				{
					this.m_owner.m_breakItemsContent = value;
				}
			}

			// Token: 0x170030A8 RID: 12456
			// (get) Token: 0x0600FDF8 RID: 65016 RVA: 0x0042DE84 File Offset: 0x0042C084
			// (set) Token: 0x0600FDF9 RID: 65017 RVA: 0x0042DE94 File Offset: 0x0042C094
			public Text m_breakGoldText
			{
				get
				{
					return this.m_owner.m_breakGoldText;
				}
				set
				{
					this.m_owner.m_breakGoldText = value;
				}
			}

			// Token: 0x170030A9 RID: 12457
			// (get) Token: 0x0600FDFA RID: 65018 RVA: 0x0042DEA4 File Offset: 0x0042C0A4
			// (set) Token: 0x0600FDFB RID: 65019 RVA: 0x0042DEB4 File Offset: 0x0042C0B4
			public Button m_breakButton
			{
				get
				{
					return this.m_owner.m_breakButton;
				}
				set
				{
					this.m_owner.m_breakButton = value;
				}
			}

			// Token: 0x170030AA RID: 12458
			// (get) Token: 0x0600FDFC RID: 65020 RVA: 0x0042DEC4 File Offset: 0x0042C0C4
			// (set) Token: 0x0600FDFD RID: 65021 RVA: 0x0042DED4 File Offset: 0x0042C0D4
			public Image m_breakCantIcon
			{
				get
				{
					return this.m_owner.m_breakCantIcon;
				}
				set
				{
					this.m_owner.m_breakCantIcon = value;
				}
			}

			// Token: 0x170030AB RID: 12459
			// (get) Token: 0x0600FDFE RID: 65022 RVA: 0x0042DEE4 File Offset: 0x0042C0E4
			// (set) Token: 0x0600FDFF RID: 65023 RVA: 0x0042DEF4 File Offset: 0x0042C0F4
			public Image m_breakCantIconBg
			{
				get
				{
					return this.m_owner.m_breakCantIconBg;
				}
				set
				{
					this.m_owner.m_breakCantIconBg = value;
				}
			}

			// Token: 0x170030AC RID: 12460
			// (get) Token: 0x0600FE00 RID: 65024 RVA: 0x0042DF04 File Offset: 0x0042C104
			// (set) Token: 0x0600FE01 RID: 65025 RVA: 0x0042DF14 File Offset: 0x0042C114
			public GameObject m_breakCantStarGroup
			{
				get
				{
					return this.m_owner.m_breakCantStarGroup;
				}
				set
				{
					this.m_owner.m_breakCantStarGroup = value;
				}
			}

			// Token: 0x170030AD RID: 12461
			// (get) Token: 0x0600FE02 RID: 65026 RVA: 0x0042DF24 File Offset: 0x0042C124
			// (set) Token: 0x0600FE03 RID: 65027 RVA: 0x0042DF34 File Offset: 0x0042C134
			public Text m_breakCantTitleText
			{
				get
				{
					return this.m_owner.m_breakCantTitleText;
				}
				set
				{
					this.m_owner.m_breakCantTitleText = value;
				}
			}

			// Token: 0x170030AE RID: 12462
			// (get) Token: 0x0600FE04 RID: 65028 RVA: 0x0042DF44 File Offset: 0x0042C144
			// (set) Token: 0x0600FE05 RID: 65029 RVA: 0x0042DF54 File Offset: 0x0042C154
			public GameObject m_breakSuccessPanel
			{
				get
				{
					return this.m_owner.m_breakSuccessPanel;
				}
				set
				{
					this.m_owner.m_breakSuccessPanel = value;
				}
			}

			// Token: 0x170030AF RID: 12463
			// (get) Token: 0x0600FE06 RID: 65030 RVA: 0x0042DF64 File Offset: 0x0042C164
			// (set) Token: 0x0600FE07 RID: 65031 RVA: 0x0042DF74 File Offset: 0x0042C174
			public Button m_breakSuccessPanelBlackButton
			{
				get
				{
					return this.m_owner.m_breakSuccessPanelBlackButton;
				}
				set
				{
					this.m_owner.m_breakSuccessPanelBlackButton = value;
				}
			}

			// Token: 0x170030B0 RID: 12464
			// (get) Token: 0x0600FE08 RID: 65032 RVA: 0x0042DF84 File Offset: 0x0042C184
			// (set) Token: 0x0600FE09 RID: 65033 RVA: 0x0042DF94 File Offset: 0x0042C194
			public Image m_breakSuccessInfoIconBg
			{
				get
				{
					return this.m_owner.m_breakSuccessInfoIconBg;
				}
				set
				{
					this.m_owner.m_breakSuccessInfoIconBg = value;
				}
			}

			// Token: 0x170030B1 RID: 12465
			// (get) Token: 0x0600FE0A RID: 65034 RVA: 0x0042DFA4 File Offset: 0x0042C1A4
			// (set) Token: 0x0600FE0B RID: 65035 RVA: 0x0042DFB4 File Offset: 0x0042C1B4
			public Image m_breakSuccessInfoIcon
			{
				get
				{
					return this.m_owner.m_breakSuccessInfoIcon;
				}
				set
				{
					this.m_owner.m_breakSuccessInfoIcon = value;
				}
			}

			// Token: 0x170030B2 RID: 12466
			// (get) Token: 0x0600FE0C RID: 65036 RVA: 0x0042DFC4 File Offset: 0x0042C1C4
			// (set) Token: 0x0600FE0D RID: 65037 RVA: 0x0042DFD4 File Offset: 0x0042C1D4
			public GameObject m_breakSuccessInfoStarGroup
			{
				get
				{
					return this.m_owner.m_breakSuccessInfoStarGroup;
				}
				set
				{
					this.m_owner.m_breakSuccessInfoStarGroup = value;
				}
			}

			// Token: 0x170030B3 RID: 12467
			// (get) Token: 0x0600FE0E RID: 65038 RVA: 0x0042DFE4 File Offset: 0x0042C1E4
			// (set) Token: 0x0600FE0F RID: 65039 RVA: 0x0042DFF4 File Offset: 0x0042C1F4
			public Text m_breakSuccessInfoCurOldLvText
			{
				get
				{
					return this.m_owner.m_breakSuccessInfoCurOldLvText;
				}
				set
				{
					this.m_owner.m_breakSuccessInfoCurOldLvText = value;
				}
			}

			// Token: 0x170030B4 RID: 12468
			// (get) Token: 0x0600FE10 RID: 65040 RVA: 0x0042E004 File Offset: 0x0042C204
			// (set) Token: 0x0600FE11 RID: 65041 RVA: 0x0042E014 File Offset: 0x0042C214
			public Text m_breakSuccessInfoCurMaxLvText
			{
				get
				{
					return this.m_owner.m_breakSuccessInfoCurMaxLvText;
				}
				set
				{
					this.m_owner.m_breakSuccessInfoCurMaxLvText = value;
				}
			}

			// Token: 0x170030B5 RID: 12469
			// (get) Token: 0x0600FE12 RID: 65042 RVA: 0x0042E024 File Offset: 0x0042C224
			// (set) Token: 0x0600FE13 RID: 65043 RVA: 0x0042E034 File Offset: 0x0042C234
			public Text m_breakSuccessInfoNextOldLvText
			{
				get
				{
					return this.m_owner.m_breakSuccessInfoNextOldLvText;
				}
				set
				{
					this.m_owner.m_breakSuccessInfoNextOldLvText = value;
				}
			}

			// Token: 0x170030B6 RID: 12470
			// (get) Token: 0x0600FE14 RID: 65044 RVA: 0x0042E044 File Offset: 0x0042C244
			// (set) Token: 0x0600FE15 RID: 65045 RVA: 0x0042E054 File Offset: 0x0042C254
			public Text m_breakSuccessInfoNextMaxLvText
			{
				get
				{
					return this.m_owner.m_breakSuccessInfoNextMaxLvText;
				}
				set
				{
					this.m_owner.m_breakSuccessInfoNextMaxLvText = value;
				}
			}

			// Token: 0x170030B7 RID: 12471
			// (get) Token: 0x0600FE16 RID: 65046 RVA: 0x0042E064 File Offset: 0x0042C264
			// (set) Token: 0x0600FE17 RID: 65047 RVA: 0x0042E074 File Offset: 0x0042C274
			public Text m_enchantmentItemNameText
			{
				get
				{
					return this.m_owner.m_enchantmentItemNameText;
				}
				set
				{
					this.m_owner.m_enchantmentItemNameText = value;
				}
			}

			// Token: 0x170030B8 RID: 12472
			// (get) Token: 0x0600FE18 RID: 65048 RVA: 0x0042E084 File Offset: 0x0042C284
			// (set) Token: 0x0600FE19 RID: 65049 RVA: 0x0042E094 File Offset: 0x0042C294
			public Text m_enchantmentItemLevelValueText
			{
				get
				{
					return this.m_owner.m_enchantmentItemLevelValueText;
				}
				set
				{
					this.m_owner.m_enchantmentItemLevelValueText = value;
				}
			}

			// Token: 0x170030B9 RID: 12473
			// (get) Token: 0x0600FE1A RID: 65050 RVA: 0x0042E0A4 File Offset: 0x0042C2A4
			// (set) Token: 0x0600FE1B RID: 65051 RVA: 0x0042E0B4 File Offset: 0x0042C2B4
			public Image m_enchantmentIcon
			{
				get
				{
					return this.m_owner.m_enchantmentIcon;
				}
				set
				{
					this.m_owner.m_enchantmentIcon = value;
				}
			}

			// Token: 0x170030BA RID: 12474
			// (get) Token: 0x0600FE1C RID: 65052 RVA: 0x0042E0C4 File Offset: 0x0042C2C4
			// (set) Token: 0x0600FE1D RID: 65053 RVA: 0x0042E0D4 File Offset: 0x0042C2D4
			public Image m_enchantmentIconBg
			{
				get
				{
					return this.m_owner.m_enchantmentIconBg;
				}
				set
				{
					this.m_owner.m_enchantmentIconBg = value;
				}
			}

			// Token: 0x170030BB RID: 12475
			// (get) Token: 0x0600FE1E RID: 65054 RVA: 0x0042E0E4 File Offset: 0x0042C2E4
			// (set) Token: 0x0600FE1F RID: 65055 RVA: 0x0042E0F4 File Offset: 0x0042C2F4
			public GameObject m_enchantmentIconSSREffect
			{
				get
				{
					return this.m_owner.m_enchantmentIconSSREffect;
				}
				set
				{
					this.m_owner.m_enchantmentIconSSREffect = value;
				}
			}

			// Token: 0x170030BC RID: 12476
			// (get) Token: 0x0600FE20 RID: 65056 RVA: 0x0042E104 File Offset: 0x0042C304
			// (set) Token: 0x0600FE21 RID: 65057 RVA: 0x0042E114 File Offset: 0x0042C314
			public GameObject m_enchantmentStarGroup
			{
				get
				{
					return this.m_owner.m_enchantmentStarGroup;
				}
				set
				{
					this.m_owner.m_enchantmentStarGroup = value;
				}
			}

			// Token: 0x170030BD RID: 12477
			// (get) Token: 0x0600FE22 RID: 65058 RVA: 0x0042E124 File Offset: 0x0042C324
			// (set) Token: 0x0600FE23 RID: 65059 RVA: 0x0042E134 File Offset: 0x0042C334
			public GameObject m_enchantmentEnchantPropertyGroup
			{
				get
				{
					return this.m_owner.m_enchantmentEnchantPropertyGroup;
				}
				set
				{
					this.m_owner.m_enchantmentEnchantPropertyGroup = value;
				}
			}

			// Token: 0x170030BE RID: 12478
			// (get) Token: 0x0600FE24 RID: 65060 RVA: 0x0042E144 File Offset: 0x0042C344
			// (set) Token: 0x0600FE25 RID: 65061 RVA: 0x0042E154 File Offset: 0x0042C354
			public CommonUIStateController m_enchantmentEnchantPropertyGroupStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentEnchantPropertyGroupStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentEnchantPropertyGroupStateCtrl = value;
				}
			}

			// Token: 0x170030BF RID: 12479
			// (get) Token: 0x0600FE26 RID: 65062 RVA: 0x0042E164 File Offset: 0x0042C364
			// (set) Token: 0x0600FE27 RID: 65063 RVA: 0x0042E174 File Offset: 0x0042C374
			public CommonUIStateController m_enchantmentSuitInfoStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoStateCtrl = value;
				}
			}

			// Token: 0x170030C0 RID: 12480
			// (get) Token: 0x0600FE28 RID: 65064 RVA: 0x0042E184 File Offset: 0x0042C384
			// (set) Token: 0x0600FE29 RID: 65065 RVA: 0x0042E194 File Offset: 0x0042C394
			public CommonUIStateController m_enchantmentSuitInfoGroupStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoGroupStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoGroupStateCtrl = value;
				}
			}

			// Token: 0x170030C1 RID: 12481
			// (get) Token: 0x0600FE2A RID: 65066 RVA: 0x0042E1A4 File Offset: 0x0042C3A4
			// (set) Token: 0x0600FE2B RID: 65067 RVA: 0x0042E1B4 File Offset: 0x0042C3B4
			public CommonUIStateController m_enchantmentSuitInfoNowEffectStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoNowEffectStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoNowEffectStateCtrl = value;
				}
			}

			// Token: 0x170030C2 RID: 12482
			// (get) Token: 0x0600FE2C RID: 65068 RVA: 0x0042E1C4 File Offset: 0x0042C3C4
			// (set) Token: 0x0600FE2D RID: 65069 RVA: 0x0042E1D4 File Offset: 0x0042C3D4
			public CommonUIStateController m_enchantmentSuitInfoNowEffectRuneIconStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoNowEffectRuneIconStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoNowEffectRuneIconStateCtrl = value;
				}
			}

			// Token: 0x170030C3 RID: 12483
			// (get) Token: 0x0600FE2E RID: 65070 RVA: 0x0042E1E4 File Offset: 0x0042C3E4
			// (set) Token: 0x0600FE2F RID: 65071 RVA: 0x0042E1F4 File Offset: 0x0042C3F4
			public Image m_enchantmentSuitInfoNowEffectRuneActiveIcon
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoNowEffectRuneActiveIcon;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoNowEffectRuneActiveIcon = value;
				}
			}

			// Token: 0x170030C4 RID: 12484
			// (get) Token: 0x0600FE30 RID: 65072 RVA: 0x0042E204 File Offset: 0x0042C404
			// (set) Token: 0x0600FE31 RID: 65073 RVA: 0x0042E214 File Offset: 0x0042C414
			public Image m_enchantmentSuitInfoNowEffectRuneUnactiveIcon
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoNowEffectRuneUnactiveIcon;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoNowEffectRuneUnactiveIcon = value;
				}
			}

			// Token: 0x170030C5 RID: 12485
			// (get) Token: 0x0600FE32 RID: 65074 RVA: 0x0042E224 File Offset: 0x0042C424
			// (set) Token: 0x0600FE33 RID: 65075 RVA: 0x0042E234 File Offset: 0x0042C434
			public Text m_enchantmentSuitInfoNowEffectRuneNameText
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoNowEffectRuneNameText;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoNowEffectRuneNameText = value;
				}
			}

			// Token: 0x170030C6 RID: 12486
			// (get) Token: 0x0600FE34 RID: 65076 RVA: 0x0042E244 File Offset: 0x0042C444
			// (set) Token: 0x0600FE35 RID: 65077 RVA: 0x0042E254 File Offset: 0x0042C454
			public Text m_enchantmentSuitInfoNowEffectRune2SuitInfoText
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoNowEffectRune2SuitInfoText;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoNowEffectRune2SuitInfoText = value;
				}
			}

			// Token: 0x170030C7 RID: 12487
			// (get) Token: 0x0600FE36 RID: 65078 RVA: 0x0042E264 File Offset: 0x0042C464
			// (set) Token: 0x0600FE37 RID: 65079 RVA: 0x0042E274 File Offset: 0x0042C474
			public Text m_enchantmentSuitInfoNowEffectRune4SuitInfoText
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoNowEffectRune4SuitInfoText;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoNowEffectRune4SuitInfoText = value;
				}
			}

			// Token: 0x170030C8 RID: 12488
			// (get) Token: 0x0600FE38 RID: 65080 RVA: 0x0042E284 File Offset: 0x0042C484
			// (set) Token: 0x0600FE39 RID: 65081 RVA: 0x0042E294 File Offset: 0x0042C494
			public CommonUIStateController m_enchantmentSuitInfoAfterEffectStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoAfterEffectStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoAfterEffectStateCtrl = value;
				}
			}

			// Token: 0x170030C9 RID: 12489
			// (get) Token: 0x0600FE3A RID: 65082 RVA: 0x0042E2A4 File Offset: 0x0042C4A4
			// (set) Token: 0x0600FE3B RID: 65083 RVA: 0x0042E2B4 File Offset: 0x0042C4B4
			public Image m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoAfterEffectRuneUnactiveIcon = value;
				}
			}

			// Token: 0x170030CA RID: 12490
			// (get) Token: 0x0600FE3C RID: 65084 RVA: 0x0042E2C4 File Offset: 0x0042C4C4
			// (set) Token: 0x0600FE3D RID: 65085 RVA: 0x0042E2D4 File Offset: 0x0042C4D4
			public Text m_enchantmentSuitInfoAfterEffectRuneNameText
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoAfterEffectRuneNameText;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoAfterEffectRuneNameText = value;
				}
			}

			// Token: 0x170030CB RID: 12491
			// (get) Token: 0x0600FE3E RID: 65086 RVA: 0x0042E2E4 File Offset: 0x0042C4E4
			// (set) Token: 0x0600FE3F RID: 65087 RVA: 0x0042E2F4 File Offset: 0x0042C4F4
			public Text m_enchantmentSuitInfoAfterEffectRune2SuitInfoText
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoAfterEffectRune2SuitInfoText;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoAfterEffectRune2SuitInfoText = value;
				}
			}

			// Token: 0x170030CC RID: 12492
			// (get) Token: 0x0600FE40 RID: 65088 RVA: 0x0042E304 File Offset: 0x0042C504
			// (set) Token: 0x0600FE41 RID: 65089 RVA: 0x0042E314 File Offset: 0x0042C514
			public Text m_enchantmentSuitInfoAfterEffectRune4SuitInfoText
			{
				get
				{
					return this.m_owner.m_enchantmentSuitInfoAfterEffectRune4SuitInfoText;
				}
				set
				{
					this.m_owner.m_enchantmentSuitInfoAfterEffectRune4SuitInfoText = value;
				}
			}

			// Token: 0x170030CD RID: 12493
			// (get) Token: 0x0600FE42 RID: 65090 RVA: 0x0042E324 File Offset: 0x0042C524
			// (set) Token: 0x0600FE43 RID: 65091 RVA: 0x0042E334 File Offset: 0x0042C534
			public CommonUIStateController m_enchantmentMaterialGroupStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentMaterialGroupStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentMaterialGroupStateCtrl = value;
				}
			}

			// Token: 0x170030CE RID: 12494
			// (get) Token: 0x0600FE44 RID: 65092 RVA: 0x0042E344 File Offset: 0x0042C544
			// (set) Token: 0x0600FE45 RID: 65093 RVA: 0x0042E354 File Offset: 0x0042C554
			public Image m_enchantmentStoneIconBg
			{
				get
				{
					return this.m_owner.m_enchantmentStoneIconBg;
				}
				set
				{
					this.m_owner.m_enchantmentStoneIconBg = value;
				}
			}

			// Token: 0x170030CF RID: 12495
			// (get) Token: 0x0600FE46 RID: 65094 RVA: 0x0042E364 File Offset: 0x0042C564
			// (set) Token: 0x0600FE47 RID: 65095 RVA: 0x0042E374 File Offset: 0x0042C574
			public Image m_enchantmentStoneIcon
			{
				get
				{
					return this.m_owner.m_enchantmentStoneIcon;
				}
				set
				{
					this.m_owner.m_enchantmentStoneIcon = value;
				}
			}

			// Token: 0x170030D0 RID: 12496
			// (get) Token: 0x0600FE48 RID: 65096 RVA: 0x0042E384 File Offset: 0x0042C584
			// (set) Token: 0x0600FE49 RID: 65097 RVA: 0x0042E394 File Offset: 0x0042C594
			public Text m_enchantmentStoneNameText
			{
				get
				{
					return this.m_owner.m_enchantmentStoneNameText;
				}
				set
				{
					this.m_owner.m_enchantmentStoneNameText = value;
				}
			}

			// Token: 0x170030D1 RID: 12497
			// (get) Token: 0x0600FE4A RID: 65098 RVA: 0x0042E3A4 File Offset: 0x0042C5A4
			// (set) Token: 0x0600FE4B RID: 65099 RVA: 0x0042E3B4 File Offset: 0x0042C5B4
			public Text m_enchantmentStoneDescText
			{
				get
				{
					return this.m_owner.m_enchantmentStoneDescText;
				}
				set
				{
					this.m_owner.m_enchantmentStoneDescText = value;
				}
			}

			// Token: 0x170030D2 RID: 12498
			// (get) Token: 0x0600FE4C RID: 65100 RVA: 0x0042E3C4 File Offset: 0x0042C5C4
			// (set) Token: 0x0600FE4D RID: 65101 RVA: 0x0042E3D4 File Offset: 0x0042C5D4
			public CommonUIStateController m_enchantmentStoneValueGroupStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentStoneValueGroupStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentStoneValueGroupStateCtrl = value;
				}
			}

			// Token: 0x170030D3 RID: 12499
			// (get) Token: 0x0600FE4E RID: 65102 RVA: 0x0042E3E4 File Offset: 0x0042C5E4
			// (set) Token: 0x0600FE4F RID: 65103 RVA: 0x0042E3F4 File Offset: 0x0042C5F4
			public Text m_enchantmentStoneHaveCount
			{
				get
				{
					return this.m_owner.m_enchantmentStoneHaveCount;
				}
				set
				{
					this.m_owner.m_enchantmentStoneHaveCount = value;
				}
			}

			// Token: 0x170030D4 RID: 12500
			// (get) Token: 0x0600FE50 RID: 65104 RVA: 0x0042E404 File Offset: 0x0042C604
			// (set) Token: 0x0600FE51 RID: 65105 RVA: 0x0042E414 File Offset: 0x0042C614
			public Text m_enchantmentGoldenValueText
			{
				get
				{
					return this.m_owner.m_enchantmentGoldenValueText;
				}
				set
				{
					this.m_owner.m_enchantmentGoldenValueText = value;
				}
			}

			// Token: 0x170030D5 RID: 12501
			// (get) Token: 0x0600FE52 RID: 65106 RVA: 0x0042E424 File Offset: 0x0042C624
			// (set) Token: 0x0600FE53 RID: 65107 RVA: 0x0042E434 File Offset: 0x0042C634
			public CommonUIStateController m_enchantmentGoldenValueTextStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentGoldenValueTextStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentGoldenValueTextStateCtrl = value;
				}
			}

			// Token: 0x170030D6 RID: 12502
			// (get) Token: 0x0600FE54 RID: 65108 RVA: 0x0042E444 File Offset: 0x0042C644
			// (set) Token: 0x0600FE55 RID: 65109 RVA: 0x0042E454 File Offset: 0x0042C654
			public Button m_enchantmentButton
			{
				get
				{
					return this.m_owner.m_enchantmentButton;
				}
				set
				{
					this.m_owner.m_enchantmentButton = value;
				}
			}

			// Token: 0x170030D7 RID: 12503
			// (get) Token: 0x0600FE56 RID: 65110 RVA: 0x0042E464 File Offset: 0x0042C664
			// (set) Token: 0x0600FE57 RID: 65111 RVA: 0x0042E474 File Offset: 0x0042C674
			public CommonUIStateController m_enchantKeepPropertyGroup
			{
				get
				{
					return this.m_owner.m_enchantKeepPropertyGroup;
				}
				set
				{
					this.m_owner.m_enchantKeepPropertyGroup = value;
				}
			}

			// Token: 0x170030D8 RID: 12504
			// (get) Token: 0x0600FE58 RID: 65112 RVA: 0x0042E484 File Offset: 0x0042C684
			// (set) Token: 0x0600FE59 RID: 65113 RVA: 0x0042E494 File Offset: 0x0042C694
			public CommonUIStateController m_enchantSuccessEffectPanel
			{
				get
				{
					return this.m_owner.m_enchantSuccessEffectPanel;
				}
				set
				{
					this.m_owner.m_enchantSuccessEffectPanel = value;
				}
			}

			// Token: 0x170030D9 RID: 12505
			// (get) Token: 0x0600FE5A RID: 65114 RVA: 0x0042E4A4 File Offset: 0x0042C6A4
			// (set) Token: 0x0600FE5B RID: 65115 RVA: 0x0042E4B4 File Offset: 0x0042C6B4
			public CommonUIStateController m_enchantmentResultPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelStateCtrl = value;
				}
			}

			// Token: 0x170030DA RID: 12506
			// (get) Token: 0x0600FE5C RID: 65116 RVA: 0x0042E4C4 File Offset: 0x0042C6C4
			// (set) Token: 0x0600FE5D RID: 65117 RVA: 0x0042E4D4 File Offset: 0x0042C6D4
			public Button m_enchantmentResultPanelCloseButton
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelCloseButton;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelCloseButton = value;
				}
			}

			// Token: 0x170030DB RID: 12507
			// (get) Token: 0x0600FE5E RID: 65118 RVA: 0x0042E4E4 File Offset: 0x0042C6E4
			// (set) Token: 0x0600FE5F RID: 65119 RVA: 0x0042E4F4 File Offset: 0x0042C6F4
			public GameObject m_enchantmentResultPanelOldPropretyGroup
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelOldPropretyGroup;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelOldPropretyGroup = value;
				}
			}

			// Token: 0x170030DC RID: 12508
			// (get) Token: 0x0600FE60 RID: 65120 RVA: 0x0042E504 File Offset: 0x0042C704
			// (set) Token: 0x0600FE61 RID: 65121 RVA: 0x0042E514 File Offset: 0x0042C714
			public CommonUIStateController m_enchantmentResultPanelOldSuitInfoStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelOldSuitInfoStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelOldSuitInfoStateCtrl = value;
				}
			}

			// Token: 0x170030DD RID: 12509
			// (get) Token: 0x0600FE62 RID: 65122 RVA: 0x0042E524 File Offset: 0x0042C724
			// (set) Token: 0x0600FE63 RID: 65123 RVA: 0x0042E534 File Offset: 0x0042C734
			public Text m_enchantmentResultPanelOldSuitInfoNameText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelOldSuitInfoNameText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelOldSuitInfoNameText = value;
				}
			}

			// Token: 0x170030DE RID: 12510
			// (get) Token: 0x0600FE64 RID: 65124 RVA: 0x0042E544 File Offset: 0x0042C744
			// (set) Token: 0x0600FE65 RID: 65125 RVA: 0x0042E554 File Offset: 0x0042C754
			public Text m_enchantmentResultPanelOld2SuitInfoText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelOld2SuitInfoText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelOld2SuitInfoText = value;
				}
			}

			// Token: 0x170030DF RID: 12511
			// (get) Token: 0x0600FE66 RID: 65126 RVA: 0x0042E564 File Offset: 0x0042C764
			// (set) Token: 0x0600FE67 RID: 65127 RVA: 0x0042E574 File Offset: 0x0042C774
			public Text m_enchantmentResultPanelOld4SuitInfoText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelOld4SuitInfoText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelOld4SuitInfoText = value;
				}
			}

			// Token: 0x170030E0 RID: 12512
			// (get) Token: 0x0600FE68 RID: 65128 RVA: 0x0042E584 File Offset: 0x0042C784
			// (set) Token: 0x0600FE69 RID: 65129 RVA: 0x0042E594 File Offset: 0x0042C794
			public CommonUIStateController m_enchantmentResultPanelNewProprety1StateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety1StateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety1StateCtrl = value;
				}
			}

			// Token: 0x170030E1 RID: 12513
			// (get) Token: 0x0600FE6A RID: 65130 RVA: 0x0042E5A4 File Offset: 0x0042C7A4
			// (set) Token: 0x0600FE6B RID: 65131 RVA: 0x0042E5B4 File Offset: 0x0042C7B4
			public Image m_enchantmentResultPanelNewProprety1ProgressBar
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety1ProgressBar;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety1ProgressBar = value;
				}
			}

			// Token: 0x170030E2 RID: 12514
			// (get) Token: 0x0600FE6C RID: 65132 RVA: 0x0042E5C4 File Offset: 0x0042C7C4
			// (set) Token: 0x0600FE6D RID: 65133 RVA: 0x0042E5D4 File Offset: 0x0042C7D4
			public Text m_enchantmentResultPanelNewProprety1NameText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety1NameText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety1NameText = value;
				}
			}

			// Token: 0x170030E3 RID: 12515
			// (get) Token: 0x0600FE6E RID: 65134 RVA: 0x0042E5E4 File Offset: 0x0042C7E4
			// (set) Token: 0x0600FE6F RID: 65135 RVA: 0x0042E5F4 File Offset: 0x0042C7F4
			public Text m_enchantmentResultPanelNewProprety1ValueText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety1ValueText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety1ValueText = value;
				}
			}

			// Token: 0x170030E4 RID: 12516
			// (get) Token: 0x0600FE70 RID: 65136 RVA: 0x0042E604 File Offset: 0x0042C804
			// (set) Token: 0x0600FE71 RID: 65137 RVA: 0x0042E614 File Offset: 0x0042C814
			public CommonUIStateController m_enchantmentResultPanelNewProprety2StateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety2StateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety2StateCtrl = value;
				}
			}

			// Token: 0x170030E5 RID: 12517
			// (get) Token: 0x0600FE72 RID: 65138 RVA: 0x0042E624 File Offset: 0x0042C824
			// (set) Token: 0x0600FE73 RID: 65139 RVA: 0x0042E634 File Offset: 0x0042C834
			public Image m_enchantmentResultPanelNewProprety2ProgressBar
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety2ProgressBar;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety2ProgressBar = value;
				}
			}

			// Token: 0x170030E6 RID: 12518
			// (get) Token: 0x0600FE74 RID: 65140 RVA: 0x0042E644 File Offset: 0x0042C844
			// (set) Token: 0x0600FE75 RID: 65141 RVA: 0x0042E654 File Offset: 0x0042C854
			public Text m_enchantmentResultPanelNewProprety2NameText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety2NameText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety2NameText = value;
				}
			}

			// Token: 0x170030E7 RID: 12519
			// (get) Token: 0x0600FE76 RID: 65142 RVA: 0x0042E664 File Offset: 0x0042C864
			// (set) Token: 0x0600FE77 RID: 65143 RVA: 0x0042E674 File Offset: 0x0042C874
			public Text m_enchantmentResultPanelNewProprety2ValueText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety2ValueText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety2ValueText = value;
				}
			}

			// Token: 0x170030E8 RID: 12520
			// (get) Token: 0x0600FE78 RID: 65144 RVA: 0x0042E684 File Offset: 0x0042C884
			// (set) Token: 0x0600FE79 RID: 65145 RVA: 0x0042E694 File Offset: 0x0042C894
			public CommonUIStateController m_enchantmentResultPanelNewProprety3StateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety3StateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety3StateCtrl = value;
				}
			}

			// Token: 0x170030E9 RID: 12521
			// (get) Token: 0x0600FE7A RID: 65146 RVA: 0x0042E6A4 File Offset: 0x0042C8A4
			// (set) Token: 0x0600FE7B RID: 65147 RVA: 0x0042E6B4 File Offset: 0x0042C8B4
			public Image m_enchantmentResultPanelNewProprety3ProgressBar
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety3ProgressBar;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety3ProgressBar = value;
				}
			}

			// Token: 0x170030EA RID: 12522
			// (get) Token: 0x0600FE7C RID: 65148 RVA: 0x0042E6C4 File Offset: 0x0042C8C4
			// (set) Token: 0x0600FE7D RID: 65149 RVA: 0x0042E6D4 File Offset: 0x0042C8D4
			public Text m_enchantmentResultPanelNewProprety3NameText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety3NameText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety3NameText = value;
				}
			}

			// Token: 0x170030EB RID: 12523
			// (get) Token: 0x0600FE7E RID: 65150 RVA: 0x0042E6E4 File Offset: 0x0042C8E4
			// (set) Token: 0x0600FE7F RID: 65151 RVA: 0x0042E6F4 File Offset: 0x0042C8F4
			public Text m_enchantmentResultPanelNewProprety3ValueText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewProprety3ValueText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewProprety3ValueText = value;
				}
			}

			// Token: 0x170030EC RID: 12524
			// (get) Token: 0x0600FE80 RID: 65152 RVA: 0x0042E704 File Offset: 0x0042C904
			// (set) Token: 0x0600FE81 RID: 65153 RVA: 0x0042E714 File Offset: 0x0042C914
			public Text m_enchantmentResultPanelNewSuitInfoNameText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNewSuitInfoNameText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNewSuitInfoNameText = value;
				}
			}

			// Token: 0x170030ED RID: 12525
			// (get) Token: 0x0600FE82 RID: 65154 RVA: 0x0042E724 File Offset: 0x0042C924
			// (set) Token: 0x0600FE83 RID: 65155 RVA: 0x0042E734 File Offset: 0x0042C934
			public Text m_enchantmentResultPanelNew2SuitInfoText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNew2SuitInfoText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNew2SuitInfoText = value;
				}
			}

			// Token: 0x170030EE RID: 12526
			// (get) Token: 0x0600FE84 RID: 65156 RVA: 0x0042E744 File Offset: 0x0042C944
			// (set) Token: 0x0600FE85 RID: 65157 RVA: 0x0042E754 File Offset: 0x0042C954
			public Text m_enchantmentResultPanelNew4SuitInfoText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNew4SuitInfoText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNew4SuitInfoText = value;
				}
			}

			// Token: 0x170030EF RID: 12527
			// (get) Token: 0x0600FE86 RID: 65158 RVA: 0x0042E764 File Offset: 0x0042C964
			// (set) Token: 0x0600FE87 RID: 65159 RVA: 0x0042E774 File Offset: 0x0042C974
			public Button m_enchantmentResultPanelEnchantmentAgainButton
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelEnchantmentAgainButton;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelEnchantmentAgainButton = value;
				}
			}

			// Token: 0x170030F0 RID: 12528
			// (get) Token: 0x0600FE88 RID: 65160 RVA: 0x0042E784 File Offset: 0x0042C984
			// (set) Token: 0x0600FE89 RID: 65161 RVA: 0x0042E794 File Offset: 0x0042C994
			public CommonUIStateController m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelEnchantmentAgainButtonStateCtrl = value;
				}
			}

			// Token: 0x170030F1 RID: 12529
			// (get) Token: 0x0600FE8A RID: 65162 RVA: 0x0042E7A4 File Offset: 0x0042C9A4
			// (set) Token: 0x0600FE8B RID: 65163 RVA: 0x0042E7B4 File Offset: 0x0042C9B4
			public Text m_enchantmentResultPanelNumberText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelNumberText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelNumberText = value;
				}
			}

			// Token: 0x170030F2 RID: 12530
			// (get) Token: 0x0600FE8C RID: 65164 RVA: 0x0042E7C4 File Offset: 0x0042C9C4
			// (set) Token: 0x0600FE8D RID: 65165 RVA: 0x0042E7D4 File Offset: 0x0042C9D4
			public Text m_enchantmentResultPanelGoldenNumberText
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelGoldenNumberText;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelGoldenNumberText = value;
				}
			}

			// Token: 0x170030F3 RID: 12531
			// (get) Token: 0x0600FE8E RID: 65166 RVA: 0x0042E7E4 File Offset: 0x0042C9E4
			// (set) Token: 0x0600FE8F RID: 65167 RVA: 0x0042E7F4 File Offset: 0x0042C9F4
			public CommonUIStateController m_enchantmentResultPanelGoldenNumberStateCtrl
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelGoldenNumberStateCtrl;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelGoldenNumberStateCtrl = value;
				}
			}

			// Token: 0x170030F4 RID: 12532
			// (get) Token: 0x0600FE90 RID: 65168 RVA: 0x0042E804 File Offset: 0x0042CA04
			// (set) Token: 0x0600FE91 RID: 65169 RVA: 0x0042E814 File Offset: 0x0042CA14
			public Image m_enchantmentResultPanelItemImage
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelItemImage;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelItemImage = value;
				}
			}

			// Token: 0x170030F5 RID: 12533
			// (get) Token: 0x0600FE92 RID: 65170 RVA: 0x0042E824 File Offset: 0x0042CA24
			// (set) Token: 0x0600FE93 RID: 65171 RVA: 0x0042E834 File Offset: 0x0042CA34
			public Button m_enchantmentResultPanelSavePropretyButton
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelSavePropretyButton;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelSavePropretyButton = value;
				}
			}

			// Token: 0x170030F6 RID: 12534
			// (get) Token: 0x0600FE94 RID: 65172 RVA: 0x0042E844 File Offset: 0x0042CA44
			// (set) Token: 0x0600FE95 RID: 65173 RVA: 0x0042E854 File Offset: 0x0042CA54
			public Button m_enchantmentResultPanelContinueButton
			{
				get
				{
					return this.m_owner.m_enchantmentResultPanelContinueButton;
				}
				set
				{
					this.m_owner.m_enchantmentResultPanelContinueButton = value;
				}
			}

			// Token: 0x170030F7 RID: 12535
			// (get) Token: 0x0600FE96 RID: 65174 RVA: 0x0042E864 File Offset: 0x0042CA64
			// (set) Token: 0x0600FE97 RID: 65175 RVA: 0x0042E874 File Offset: 0x0042CA74
			public CommonUIStateController m_savePropretyPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_savePropretyPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_savePropretyPanelStateCtrl = value;
				}
			}

			// Token: 0x170030F8 RID: 12536
			// (get) Token: 0x0600FE98 RID: 65176 RVA: 0x0042E884 File Offset: 0x0042CA84
			// (set) Token: 0x0600FE99 RID: 65177 RVA: 0x0042E894 File Offset: 0x0042CA94
			public Button m_savePropretyPanelCancelButton
			{
				get
				{
					return this.m_owner.m_savePropretyPanelCancelButton;
				}
				set
				{
					this.m_owner.m_savePropretyPanelCancelButton = value;
				}
			}

			// Token: 0x170030F9 RID: 12537
			// (get) Token: 0x0600FE9A RID: 65178 RVA: 0x0042E8A4 File Offset: 0x0042CAA4
			// (set) Token: 0x0600FE9B RID: 65179 RVA: 0x0042E8B4 File Offset: 0x0042CAB4
			public Button m_savePropretyPanelComfirmButton
			{
				get
				{
					return this.m_owner.m_savePropretyPanelComfirmButton;
				}
				set
				{
					this.m_owner.m_savePropretyPanelComfirmButton = value;
				}
			}

			// Token: 0x170030FA RID: 12538
			// (get) Token: 0x0600FE9C RID: 65180 RVA: 0x0042E8C4 File Offset: 0x0042CAC4
			// (set) Token: 0x0600FE9D RID: 65181 RVA: 0x0042E8D4 File Offset: 0x0042CAD4
			public Toggle m_savePropretyPanelToggle
			{
				get
				{
					return this.m_owner.m_savePropretyPanelToggle;
				}
				set
				{
					this.m_owner.m_savePropretyPanelToggle = value;
				}
			}

			// Token: 0x170030FB RID: 12539
			// (get) Token: 0x0600FE9E RID: 65182 RVA: 0x0042E8E4 File Offset: 0x0042CAE4
			// (set) Token: 0x0600FE9F RID: 65183 RVA: 0x0042E8F4 File Offset: 0x0042CAF4
			public CommonUIStateController m_cancelPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_cancelPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_cancelPanelStateCtrl = value;
				}
			}

			// Token: 0x170030FC RID: 12540
			// (get) Token: 0x0600FEA0 RID: 65184 RVA: 0x0042E904 File Offset: 0x0042CB04
			// (set) Token: 0x0600FEA1 RID: 65185 RVA: 0x0042E914 File Offset: 0x0042CB14
			public Button m_cancelPanelCancelButton
			{
				get
				{
					return this.m_owner.m_cancelPanelCancelButton;
				}
				set
				{
					this.m_owner.m_cancelPanelCancelButton = value;
				}
			}

			// Token: 0x170030FD RID: 12541
			// (get) Token: 0x0600FEA2 RID: 65186 RVA: 0x0042E924 File Offset: 0x0042CB24
			// (set) Token: 0x0600FEA3 RID: 65187 RVA: 0x0042E934 File Offset: 0x0042CB34
			public Button m_cancelPanelComfirmButton
			{
				get
				{
					return this.m_owner.m_cancelPanelComfirmButton;
				}
				set
				{
					this.m_owner.m_cancelPanelComfirmButton = value;
				}
			}

			// Token: 0x170030FE RID: 12542
			// (get) Token: 0x0600FEA4 RID: 65188 RVA: 0x0042E944 File Offset: 0x0042CB44
			// (set) Token: 0x0600FEA5 RID: 65189 RVA: 0x0042E954 File Offset: 0x0042CB54
			public Toggle m_cancelPanelToggle
			{
				get
				{
					return this.m_owner.m_cancelPanelToggle;
				}
				set
				{
					this.m_owner.m_cancelPanelToggle = value;
				}
			}

			// Token: 0x170030FF RID: 12543
			// (get) Token: 0x0600FEA6 RID: 65190 RVA: 0x0042E964 File Offset: 0x0042CB64
			// (set) Token: 0x0600FEA7 RID: 65191 RVA: 0x0042E974 File Offset: 0x0042CB74
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17003100 RID: 12544
			// (get) Token: 0x0600FEA8 RID: 65192 RVA: 0x0042E984 File Offset: 0x0042CB84
			// (set) Token: 0x0600FEA9 RID: 65193 RVA: 0x0042E994 File Offset: 0x0042CB94
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17003101 RID: 12545
			// (get) Token: 0x0600FEAA RID: 65194 RVA: 0x0042E9A4 File Offset: 0x0042CBA4
			// (set) Token: 0x0600FEAB RID: 65195 RVA: 0x0042E9B4 File Offset: 0x0042CBB4
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

			// Token: 0x17003102 RID: 12546
			// (get) Token: 0x0600FEAC RID: 65196 RVA: 0x0042E9C4 File Offset: 0x0042CBC4
			// (set) Token: 0x0600FEAD RID: 65197 RVA: 0x0042E9D4 File Offset: 0x0042CBD4
			public int m_isAscend
			{
				get
				{
					return this.m_owner.m_isAscend;
				}
				set
				{
					this.m_owner.m_isAscend = value;
				}
			}

			// Token: 0x17003103 RID: 12547
			// (get) Token: 0x0600FEAE RID: 65198 RVA: 0x0042E9E4 File Offset: 0x0042CBE4
			// (set) Token: 0x0600FEAF RID: 65199 RVA: 0x0042E9F4 File Offset: 0x0042CBF4
			public bool m_isFirstIn
			{
				get
				{
					return this.m_owner.m_isFirstIn;
				}
				set
				{
					this.m_owner.m_isFirstIn = value;
				}
			}

			// Token: 0x17003104 RID: 12548
			// (get) Token: 0x0600FEB0 RID: 65200 RVA: 0x0042EA04 File Offset: 0x0042CC04
			// (set) Token: 0x0600FEB1 RID: 65201 RVA: 0x0042EA14 File Offset: 0x0042CC14
			public bool m_isToggleChanged
			{
				get
				{
					return this.m_owner.m_isToggleChanged;
				}
				set
				{
					this.m_owner.m_isToggleChanged = value;
				}
			}

			// Token: 0x17003105 RID: 12549
			// (get) Token: 0x0600FEB2 RID: 65202 RVA: 0x0042EA24 File Offset: 0x0042CC24
			// (set) Token: 0x0600FEB3 RID: 65203 RVA: 0x0042EA34 File Offset: 0x0042CC34
			public EquipmentForgeUIController.ForgeState m_curForgeState
			{
				get
				{
					return this.m_owner.m_curForgeState;
				}
				set
				{
					this.m_owner.m_curForgeState = value;
				}
			}

			// Token: 0x17003106 RID: 12550
			// (get) Token: 0x0600FEB4 RID: 65204 RVA: 0x0042EA44 File Offset: 0x0042CC44
			// (set) Token: 0x0600FEB5 RID: 65205 RVA: 0x0042EA54 File Offset: 0x0042CC54
			public ulong m_curEquipmentInstanceId
			{
				get
				{
					return this.m_owner.m_curEquipmentInstanceId;
				}
				set
				{
					this.m_owner.m_curEquipmentInstanceId = value;
				}
			}

			// Token: 0x17003107 RID: 12551
			// (get) Token: 0x0600FEB6 RID: 65206 RVA: 0x0042EA64 File Offset: 0x0042CC64
			// (set) Token: 0x0600FEB7 RID: 65207 RVA: 0x0042EA74 File Offset: 0x0042CC74
			public ulong m_curBreakMaterialEquipmentId
			{
				get
				{
					return this.m_owner.m_curBreakMaterialEquipmentId;
				}
				set
				{
					this.m_owner.m_curBreakMaterialEquipmentId = value;
				}
			}

			// Token: 0x17003108 RID: 12552
			// (get) Token: 0x0600FEB8 RID: 65208 RVA: 0x0042EA84 File Offset: 0x0042CC84
			// (set) Token: 0x0600FEB9 RID: 65209 RVA: 0x0042EA94 File Offset: 0x0042CC94
			public ulong m_curAddEnhanceEquipmentInstanceId
			{
				get
				{
					return this.m_owner.m_curAddEnhanceEquipmentInstanceId;
				}
				set
				{
					this.m_owner.m_curAddEnhanceEquipmentInstanceId = value;
				}
			}

			// Token: 0x17003109 RID: 12553
			// (get) Token: 0x0600FEBA RID: 65210 RVA: 0x0042EAA4 File Offset: 0x0042CCA4
			// (set) Token: 0x0600FEBB RID: 65211 RVA: 0x0042EAB4 File Offset: 0x0042CCB4
			public BagItemBase m_curSelectEnchantStoneItem
			{
				get
				{
					return this.m_owner.m_curSelectEnchantStoneItem;
				}
				set
				{
					this.m_owner.m_curSelectEnchantStoneItem = value;
				}
			}

			// Token: 0x1700310A RID: 12554
			// (get) Token: 0x0600FEBC RID: 65212 RVA: 0x0042EAC4 File Offset: 0x0042CCC4
			// (set) Token: 0x0600FEBD RID: 65213 RVA: 0x0042EAD4 File Offset: 0x0042CCD4
			public ConfigDataEnchantStoneInfo m_lastSelectEnchantStoneInfo
			{
				get
				{
					return this.m_owner.m_lastSelectEnchantStoneInfo;
				}
				set
				{
					this.m_owner.m_lastSelectEnchantStoneInfo = value;
				}
			}

			// Token: 0x1700310B RID: 12555
			// (get) Token: 0x0600FEBE RID: 65214 RVA: 0x0042EAE4 File Offset: 0x0042CCE4
			// (set) Token: 0x0600FEBF RID: 65215 RVA: 0x0042EAF4 File Offset: 0x0042CCF4
			public List<ulong> m_enhanceEquipmentInstanceIds
			{
				get
				{
					return this.m_owner.m_enhanceEquipmentInstanceIds;
				}
				set
				{
					this.m_owner.m_enhanceEquipmentInstanceIds = value;
				}
			}

			// Token: 0x1700310C RID: 12556
			// (get) Token: 0x0600FEC0 RID: 65216 RVA: 0x0042EB04 File Offset: 0x0042CD04
			// (set) Token: 0x0600FEC1 RID: 65217 RVA: 0x0042EB14 File Offset: 0x0042CD14
			public List<EquipmentBagItem> m_equipmentItemCache
			{
				get
				{
					return this.m_owner.m_equipmentItemCache;
				}
				set
				{
					this.m_owner.m_equipmentItemCache = value;
				}
			}

			// Token: 0x1700310D RID: 12557
			// (get) Token: 0x0600FEC2 RID: 65218 RVA: 0x0042EB24 File Offset: 0x0042CD24
			// (set) Token: 0x0600FEC3 RID: 65219 RVA: 0x0042EB34 File Offset: 0x0042CD34
			public List<EnchantStoneBagItem> m_enchantStoneItemCache
			{
				get
				{
					return this.m_owner.m_enchantStoneItemCache;
				}
				set
				{
					this.m_owner.m_enchantStoneItemCache = value;
				}
			}

			// Token: 0x1700310E RID: 12558
			// (get) Token: 0x0600FEC4 RID: 65220 RVA: 0x0042EB44 File Offset: 0x0042CD44
			// (set) Token: 0x0600FEC5 RID: 65221 RVA: 0x0042EB54 File Offset: 0x0042CD54
			public List<EquipmentDepotListItemUIController> m_equipmentForgeCtrlList
			{
				get
				{
					return this.m_owner.m_equipmentForgeCtrlList;
				}
				set
				{
					this.m_owner.m_equipmentForgeCtrlList = value;
				}
			}

			// Token: 0x1700310F RID: 12559
			// (get) Token: 0x0600FEC6 RID: 65222 RVA: 0x0042EB64 File Offset: 0x0042CD64
			// (set) Token: 0x0600FEC7 RID: 65223 RVA: 0x0042EB74 File Offset: 0x0042CD74
			public EquipmentDepotUIController.EquipmentSortTypeState m_curEquipmentSortType
			{
				get
				{
					return this.m_owner.m_curEquipmentSortType;
				}
				set
				{
					this.m_owner.m_curEquipmentSortType = value;
				}
			}

			// Token: 0x17003110 RID: 12560
			// (get) Token: 0x0600FEC8 RID: 65224 RVA: 0x0042EB84 File Offset: 0x0042CD84
			// (set) Token: 0x0600FEC9 RID: 65225 RVA: 0x0042EB94 File Offset: 0x0042CD94
			public int m_curEnchantmentSortTypeId
			{
				get
				{
					return this.m_owner.m_curEnchantmentSortTypeId;
				}
				set
				{
					this.m_owner.m_curEnchantmentSortTypeId = value;
				}
			}

			// Token: 0x17003111 RID: 12561
			// (get) Token: 0x0600FECA RID: 65226 RVA: 0x0042EBA4 File Offset: 0x0042CDA4
			// (set) Token: 0x0600FECB RID: 65227 RVA: 0x0042EBB4 File Offset: 0x0042CDB4
			public List<CommonBattleProperty> m_properties
			{
				get
				{
					return this.m_owner.m_properties;
				}
				set
				{
					this.m_owner.m_properties = value;
				}
			}

			// Token: 0x17003112 RID: 12562
			// (get) Token: 0x0600FECC RID: 65228 RVA: 0x0042EBC4 File Offset: 0x0042CDC4
			// (set) Token: 0x0600FECD RID: 65229 RVA: 0x0042EBD4 File Offset: 0x0042CDD4
			public bool m_isAfter3DTouch
			{
				get
				{
					return this.m_owner.m_isAfter3DTouch;
				}
				set
				{
					this.m_owner.m_isAfter3DTouch = value;
				}
			}

			// Token: 0x17003113 RID: 12563
			// (get) Token: 0x0600FECE RID: 65230 RVA: 0x0042EBE4 File Offset: 0x0042CDE4
			// (set) Token: 0x0600FECF RID: 65231 RVA: 0x0042EBF4 File Offset: 0x0042CDF4
			public string m_oldSkillLevelStr
			{
				get
				{
					return this.m_owner.m_oldSkillLevelStr;
				}
				set
				{
					this.m_owner.m_oldSkillLevelStr = value;
				}
			}

			// Token: 0x0600FED0 RID: 65232 RVA: 0x0042EC04 File Offset: 0x0042CE04
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600FED1 RID: 65233 RVA: 0x0042EC14 File Offset: 0x0042CE14
			public void InitSortTypePanel()
			{
				this.m_owner.InitSortTypePanel();
			}

			// Token: 0x0600FED2 RID: 65234 RVA: 0x0042EC24 File Offset: 0x0042CE24
			public void InitLoopScrollRect()
			{
				this.m_owner.InitLoopScrollRect();
			}

			// Token: 0x0600FED3 RID: 65235 RVA: 0x0042EC34 File Offset: 0x0042CE34
			public void CreateEquipmentList()
			{
				this.m_owner.CreateEquipmentList();
			}

			// Token: 0x0600FED4 RID: 65236 RVA: 0x0042EC44 File Offset: 0x0042CE44
			public void SortEquipmentListByType(List<EquipmentBagItem> list)
			{
				this.m_owner.SortEquipmentListByType(list);
			}

			// Token: 0x0600FED5 RID: 65237 RVA: 0x0042EC54 File Offset: 0x0042CE54
			public int DefaultEquipmentItemComparer(EquipmentBagItem e1, EquipmentBagItem e2)
			{
				return this.m_owner.DefaultEquipmentItemComparer(e1, e2);
			}

			// Token: 0x0600FED6 RID: 65238 RVA: 0x0042EC64 File Offset: 0x0042CE64
			public void CollectEquipmentPropValueAndSort(List<EquipmentBagItem> list, PropertyModifyType type)
			{
				this.m_owner.CollectEquipmentPropValueAndSort(list, type);
			}

			// Token: 0x0600FED7 RID: 65239 RVA: 0x0042EC74 File Offset: 0x0042CE74
			public void OnEquipmentListItemClick(UIControllerBase itemCtrl)
			{
				this.m_owner.OnEquipmentListItemClick(itemCtrl);
			}

			// Token: 0x0600FED8 RID: 65240 RVA: 0x0042EC84 File Offset: 0x0042CE84
			public void OnEquipmentItemClickInEnhance(EquipmentDepotListItemUIController ctrl)
			{
				this.m_owner.OnEquipmentItemClickInEnhance(ctrl);
			}

			// Token: 0x0600FED9 RID: 65241 RVA: 0x0042EC94 File Offset: 0x0042CE94
			public void OnEquipmentItemClickInBreak(EquipmentDepotListItemUIController ctrl)
			{
				this.m_owner.OnEquipmentItemClickInBreak(ctrl);
			}

			// Token: 0x0600FEDA RID: 65242 RVA: 0x0042ECA4 File Offset: 0x0042CEA4
			public void OnEquipmentItemClickInEnchantment(EquipmentDepotListItemUIController ctrl)
			{
				this.m_owner.OnEquipmentItemClickInEnchantment(ctrl);
			}

			// Token: 0x0600FEDB RID: 65243 RVA: 0x0042ECB4 File Offset: 0x0042CEB4
			public void OnEquipmentListItemNeedFill(UIControllerBase itemCtrl)
			{
				this.m_owner.OnEquipmentListItemNeedFill(itemCtrl);
			}

			// Token: 0x0600FEDC RID: 65244 RVA: 0x0042ECC4 File Offset: 0x0042CEC4
			public void OnEquipmentListItem3DTouch(UIControllerBase itemCtrl)
			{
				this.m_owner.OnEquipmentListItem3DTouch(itemCtrl);
			}

			// Token: 0x0600FEDD RID: 65245 RVA: 0x0042ECD4 File Offset: 0x0042CED4
			public void OnFilterSortButtonClick()
			{
				this.m_owner.OnFilterSortButtonClick();
			}

			// Token: 0x0600FEDE RID: 65246 RVA: 0x0042ECE4 File Offset: 0x0042CEE4
			public void OnEnchantmentFilterSortButtonClick()
			{
				this.m_owner.OnEnchantmentFilterSortButtonClick();
			}

			// Token: 0x0600FEDF RID: 65247 RVA: 0x0042ECF4 File Offset: 0x0042CEF4
			public void OnCloseFilterSortTypeGo()
			{
				this.m_owner.OnCloseFilterSortTypeGo();
			}

			// Token: 0x0600FEE0 RID: 65248 RVA: 0x0042ED04 File Offset: 0x0042CF04
			public void OnCloseEnchantmentFilterSortTypeGo()
			{
				this.m_owner.OnCloseEnchantmentFilterSortTypeGo();
			}

			// Token: 0x0600FEE1 RID: 65249 RVA: 0x0042ED14 File Offset: 0x0042CF14
			public void OnFilterSortOrderButtonClick()
			{
				this.m_owner.OnFilterSortOrderButtonClick();
			}

			// Token: 0x0600FEE2 RID: 65250 RVA: 0x0042ED24 File Offset: 0x0042CF24
			public void OnFilterTypeButtonClick(EquipmentSortItemUIController ctrl, bool isOn)
			{
				this.m_owner.OnFilterTypeButtonClick(ctrl, isOn);
			}

			// Token: 0x0600FEE3 RID: 65251 RVA: 0x0042ED34 File Offset: 0x0042CF34
			public void OnEnchantmentFilterTypeButtonClick(EquipmentSortItemUIController ctrl, bool isOn)
			{
				this.m_owner.OnEnchantmentFilterTypeButtonClick(ctrl, isOn);
			}

			// Token: 0x0600FEE4 RID: 65252 RVA: 0x0042ED44 File Offset: 0x0042CF44
			public void SetEquipmentItemDesc(EquipmentBagItem equipment)
			{
				this.m_owner.SetEquipmentItemDesc(equipment);
			}

			// Token: 0x0600FEE5 RID: 65253 RVA: 0x0042ED54 File Offset: 0x0042CF54
			public void SetPropItemColor(Text oldText, Text newText)
			{
				this.m_owner.SetPropItemColor(oldText, newText);
			}

			// Token: 0x0600FEE6 RID: 65254 RVA: 0x0042ED64 File Offset: 0x0042CF64
			public void SetPropItems(PropertyModifyType type, int value, int addValue, int level)
			{
				this.m_owner.SetPropItems(type, value, addValue, level);
			}

			// Token: 0x0600FEE7 RID: 65255 RVA: 0x0042ED78 File Offset: 0x0042CF78
			public void UpdateViewInEnhanceState()
			{
				this.m_owner.UpdateViewInEnhanceState();
			}

			// Token: 0x0600FEE8 RID: 65256 RVA: 0x0042ED88 File Offset: 0x0042CF88
			public void SetEnhancePropItems(PropertyModifyType type, int originValue, int perAddValue, int curLv, int addLv)
			{
				this.m_owner.SetEnhancePropItems(type, originValue, perAddValue, curLv, addLv);
			}

			// Token: 0x0600FEE9 RID: 65257 RVA: 0x0042ED9C File Offset: 0x0042CF9C
			public void ResetEnhancePropItemActive()
			{
				this.m_owner.ResetEnhancePropItemActive();
			}

			// Token: 0x0600FEEA RID: 65258 RVA: 0x0042EDAC File Offset: 0x0042CFAC
			public int CalculateEquipmentEnhanceAddLvByExp(EquipmentBagItem equipment, int enhanceExp, int curLv)
			{
				return this.m_owner.CalculateEquipmentEnhanceAddLvByExp(equipment, enhanceExp, curLv);
			}

			// Token: 0x0600FEEB RID: 65259 RVA: 0x0042EDBC File Offset: 0x0042CFBC
			public void OnEnhanceButtonClick()
			{
				this.m_owner.OnEnhanceButtonClick();
			}

			// Token: 0x0600FEEC RID: 65260 RVA: 0x0042EDCC File Offset: 0x0042CFCC
			public void SendEnhanceEquipmentMsg()
			{
				this.m_owner.SendEnhanceEquipmentMsg();
			}

			// Token: 0x0600FEED RID: 65261 RVA: 0x0042EDDC File Offset: 0x0042CFDC
			public void OnEnhanceSucceed(string oldSkillLevelStr)
			{
				this.m_owner.OnEnhanceSucceed(oldSkillLevelStr);
			}

			// Token: 0x0600FEEE RID: 65262 RVA: 0x0042EDEC File Offset: 0x0042CFEC
			public void StopEnhanceSucceedEffect()
			{
				this.m_owner.StopEnhanceSucceedEffect();
			}

			// Token: 0x0600FEEF RID: 65263 RVA: 0x0042EDFC File Offset: 0x0042CFFC
			public void SetSkillLevelUpEffect(EquipmentBagItem equipment, string oldLv, string newLv, int newSkillId)
			{
				this.m_owner.SetSkillLevelUpEffect(equipment, oldLv, newLv, newSkillId);
			}

			// Token: 0x0600FEF0 RID: 65264 RVA: 0x0042EE10 File Offset: 0x0042D010
			public IEnumerator DelayActiveIntensifyContinueButton()
			{
				return this.m_owner.DelayActiveIntensifyContinueButton();
			}

			// Token: 0x0600FEF1 RID: 65265 RVA: 0x0042EE20 File Offset: 0x0042D020
			public void OnIntensifySuccessPanelBlackButtonClick()
			{
				this.m_owner.OnIntensifySuccessPanelBlackButtonClick();
			}

			// Token: 0x0600FEF2 RID: 65266 RVA: 0x0042EE30 File Offset: 0x0042D030
			public void ShowEnhanceItemSRConfirmPanel()
			{
				this.m_owner.ShowEnhanceItemSRConfirmPanel();
			}

			// Token: 0x0600FEF3 RID: 65267 RVA: 0x0042EE40 File Offset: 0x0042D040
			public void ShowEnhanceItemsConfirmPanel()
			{
				this.m_owner.ShowEnhanceItemsConfirmPanel();
			}

			// Token: 0x0600FEF4 RID: 65268 RVA: 0x0042EE50 File Offset: 0x0042D050
			public void OnEnhanceItemSRConfirmButtonClick()
			{
				this.m_owner.OnEnhanceItemSRConfirmButtonClick();
			}

			// Token: 0x0600FEF5 RID: 65269 RVA: 0x0042EE60 File Offset: 0x0042D060
			public void OnEnhanceItemSRCancelButtonClick()
			{
				this.m_owner.OnEnhanceItemSRCancelButtonClick();
			}

			// Token: 0x0600FEF6 RID: 65270 RVA: 0x0042EE70 File Offset: 0x0042D070
			public void OnEnhanceConfirmButtonClick()
			{
				this.m_owner.OnEnhanceConfirmButtonClick();
			}

			// Token: 0x0600FEF7 RID: 65271 RVA: 0x0042EE80 File Offset: 0x0042D080
			public void OnEnhanceCancelButtonClick()
			{
				this.m_owner.OnEnhanceCancelButtonClick();
			}

			// Token: 0x0600FEF8 RID: 65272 RVA: 0x0042EE90 File Offset: 0x0042D090
			public bool IsEquipmentAddExpAtMaxLevelMaxExp(EquipmentBagItem equipment, int addLv, int addExp)
			{
				return this.m_owner.IsEquipmentAddExpAtMaxLevelMaxExp(equipment, addLv, addExp);
			}

			// Token: 0x0600FEF9 RID: 65273 RVA: 0x0042EEA0 File Offset: 0x0042D0A0
			public void UpdateViewInBreakState()
			{
				this.m_owner.UpdateViewInBreakState();
			}

			// Token: 0x0600FEFA RID: 65274 RVA: 0x0042EEB0 File Offset: 0x0042D0B0
			public void OnBreakButtonClick()
			{
				this.m_owner.OnBreakButtonClick();
			}

			// Token: 0x0600FEFB RID: 65275 RVA: 0x0042EEC0 File Offset: 0x0042D0C0
			public void OnBreakSucceed()
			{
				this.m_owner.OnBreakSucceed();
			}

			// Token: 0x0600FEFC RID: 65276 RVA: 0x0042EED0 File Offset: 0x0042D0D0
			public IEnumerator DelayActiveBreakContinueButton()
			{
				return this.m_owner.DelayActiveBreakContinueButton();
			}

			// Token: 0x0600FEFD RID: 65277 RVA: 0x0042EEE0 File Offset: 0x0042D0E0
			public void OnBreakSuccessPanelContinueButtonClick()
			{
				this.m_owner.OnBreakSuccessPanelContinueButtonClick();
			}

			// Token: 0x0600FEFE RID: 65278 RVA: 0x0042EEF0 File Offset: 0x0042D0F0
			public void OnEquipmentBreakNeedItemClick(GoodsType type, int id, int count)
			{
				this.m_owner.OnEquipmentBreakNeedItemClick(type, id, count);
			}

			// Token: 0x0600FEFF RID: 65279 RVA: 0x0042EF00 File Offset: 0x0042D100
			public void UpdateViewInEnchantmentState()
			{
				this.m_owner.UpdateViewInEnchantmentState();
			}

			// Token: 0x0600FF00 RID: 65280 RVA: 0x0042EF10 File Offset: 0x0042D110
			public void OnEnchantmentButtonClick()
			{
				this.m_owner.OnEnchantmentButtonClick();
			}

			// Token: 0x0600FF01 RID: 65281 RVA: 0x0042EF20 File Offset: 0x0042D120
			public void ShowEnchantmentResultPanel(int newResonanceId, List<CommonBattleProperty> properties, bool isFirstShow)
			{
				this.m_owner.ShowEnchantmentResultPanel(newResonanceId, properties, isFirstShow);
			}

			// Token: 0x0600FF02 RID: 65282 RVA: 0x0042EF30 File Offset: 0x0042D130
			public void SetEnchantmentResultPanelInfo(int newResonanceId, List<CommonBattleProperty> properties)
			{
				this.m_owner.SetEnchantmentResultPanelInfo(newResonanceId, properties);
			}

			// Token: 0x0600FF03 RID: 65283 RVA: 0x0042EF40 File Offset: 0x0042D140
			public IEnumerator Co_PlayNewPropertyEffect(List<CommonBattleProperty> properties)
			{
				return this.m_owner.Co_PlayNewPropertyEffect(properties);
			}

			// Token: 0x0600FF04 RID: 65284 RVA: 0x0042EF50 File Offset: 0x0042D150
			public IEnumerator Co_DynamicSetPropertyValue(Text valueText, Image progressBar, int value, PropertyModifyType type)
			{
				return this.m_owner.Co_DynamicSetPropertyValue(valueText, progressBar, value, type);
			}

			// Token: 0x0600FF05 RID: 65285 RVA: 0x0042EF64 File Offset: 0x0042D164
			public float CalcPropertyPercent(PropertyModifyType propertyTypeId, int value)
			{
				return this.m_owner.CalcPropertyPercent(propertyTypeId, value);
			}

			// Token: 0x0600FF06 RID: 65286 RVA: 0x0042EF74 File Offset: 0x0042D174
			public void OnEnchantmentResultPanelContinueButtonClick()
			{
				this.m_owner.OnEnchantmentResultPanelContinueButtonClick();
			}

			// Token: 0x0600FF07 RID: 65287 RVA: 0x0042EF84 File Offset: 0x0042D184
			public void CloseEnchantmentResultPanel(Action succeedEffectEvent)
			{
				this.m_owner.CloseEnchantmentResultPanel(succeedEffectEvent);
			}

			// Token: 0x0600FF08 RID: 65288 RVA: 0x0042EF94 File Offset: 0x0042D194
			public void OnEnchantmentResultSaveButtonClick()
			{
				this.m_owner.OnEnchantmentResultSaveButtonClick();
			}

			// Token: 0x0600FF09 RID: 65289 RVA: 0x0042EFA4 File Offset: 0x0042D1A4
			public void OnEnchantmentAgainButtonClick()
			{
				this.m_owner.OnEnchantmentAgainButtonClick();
			}

			// Token: 0x0600FF0A RID: 65290 RVA: 0x0042EFB4 File Offset: 0x0042D1B4
			public void ShowSavePanel()
			{
				this.m_owner.ShowSavePanel();
			}

			// Token: 0x0600FF0B RID: 65291 RVA: 0x0042EFC4 File Offset: 0x0042D1C4
			public void CloseSavePanel()
			{
				this.m_owner.CloseSavePanel();
			}

			// Token: 0x0600FF0C RID: 65292 RVA: 0x0042EFD4 File Offset: 0x0042D1D4
			public void OnSavePanlConfirmClick()
			{
				this.m_owner.OnSavePanlConfirmClick();
			}

			// Token: 0x0600FF0D RID: 65293 RVA: 0x0042EFE4 File Offset: 0x0042D1E4
			public void PlaySucceedEffect()
			{
				this.m_owner.PlaySucceedEffect();
			}

			// Token: 0x0600FF0E RID: 65294 RVA: 0x0042EFF4 File Offset: 0x0042D1F4
			public void OnCloseEnchantResultPanelButtonClick()
			{
				this.m_owner.OnCloseEnchantResultPanelButtonClick();
			}

			// Token: 0x0600FF0F RID: 65295 RVA: 0x0042F004 File Offset: 0x0042D204
			public void ShowCancelPanel()
			{
				this.m_owner.ShowCancelPanel();
			}

			// Token: 0x0600FF10 RID: 65296 RVA: 0x0042F014 File Offset: 0x0042D214
			public void CloseCancelPanel()
			{
				this.m_owner.CloseCancelPanel();
			}

			// Token: 0x0600FF11 RID: 65297 RVA: 0x0042F024 File Offset: 0x0042D224
			public void OnCancelPanlConfirmClick()
			{
				this.m_owner.OnCancelPanlConfirmClick();
			}

			// Token: 0x0600FF12 RID: 65298 RVA: 0x0042F034 File Offset: 0x0042D234
			public void OnSavePropertyToggleValueChanged(bool isOn)
			{
				this.m_owner.OnSavePropertyToggleValueChanged(isOn);
			}

			// Token: 0x0600FF13 RID: 65299 RVA: 0x0042F044 File Offset: 0x0042D244
			public void OnCancelPanelToggleValueChanged(bool isOn)
			{
				this.m_owner.OnCancelPanelToggleValueChanged(isOn);
			}

			// Token: 0x0600FF14 RID: 65300 RVA: 0x0042F054 File Offset: 0x0042D254
			public void OnEnhanceToggleValueChanged(bool isOn)
			{
				this.m_owner.OnEnhanceToggleValueChanged(isOn);
			}

			// Token: 0x0600FF15 RID: 65301 RVA: 0x0042F064 File Offset: 0x0042D264
			public void OnBreakToggleValueChanged(bool isOn)
			{
				this.m_owner.OnBreakToggleValueChanged(isOn);
			}

			// Token: 0x0600FF16 RID: 65302 RVA: 0x0042F074 File Offset: 0x0042D274
			public void OnEnchantmentToggleValueChanged(bool isOn)
			{
				this.m_owner.OnEnchantmentToggleValueChanged(isOn);
			}

			// Token: 0x0600FF17 RID: 65303 RVA: 0x0042F084 File Offset: 0x0042D284
			public void OnEnchantLockMaskButtonClick()
			{
				this.m_owner.OnEnchantLockMaskButtonClick();
			}

			// Token: 0x0600FF18 RID: 65304 RVA: 0x0042F094 File Offset: 0x0042D294
			public void OnGoldAddButtonClick()
			{
				this.m_owner.OnGoldAddButtonClick();
			}

			// Token: 0x0600FF19 RID: 65305 RVA: 0x0042F0A4 File Offset: 0x0042D2A4
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600FF1A RID: 65306 RVA: 0x0042F0B4 File Offset: 0x0042D2B4
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0400952F RID: 38191
			private EquipmentForgeUIController m_owner;
		}
	}
}
