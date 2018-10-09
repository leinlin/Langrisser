using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.PlayerContext;
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
	// Token: 0x02000D51 RID: 3409
	[HotFix]
	public class EquipmentDepotUIController : UIControllerBase
	{
		// Token: 0x0600FA21 RID: 64033 RVA: 0x0041D494 File Offset: 0x0041B694
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
			this.m_goldAddButton.onClick.AddListener(new UnityAction(this.OnGoldAddButtonClick));
			this.m_descEquipButton.onClick.AddListener(new UnityAction(this.OnDescEquipButtonClick));
			this.m_descUnloadButton.onClick.AddListener(new UnityAction(this.OnDescUnloadButtonClick));
			this.m_descLockButton.onClick.AddListener(new UnityAction(this.OnDescLockButtonClick));
			this.m_filterSortButton.onClick.AddListener(new UnityAction(this.OnFilterSortButtonClick));
			this.m_filterSortOrderButton.onClick.AddListener(new UnityAction(this.OnFilterSortOrderButtonClick));
			this.m_confirmPanelCancelButton.onClick.AddListener(new UnityAction(this.OnConfirmPanelCancelButtonClick));
			this.m_confirmPanelConfirmButton.onClick.AddListener(new UnityAction(this.OnConfirmPanelConfirmButtonClick));
			this.InitSortTypePanel();
			this.InitLoopScrollRect();
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x0600FA22 RID: 64034 RVA: 0x0041D638 File Offset: 0x0041B838
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
		}

		// Token: 0x0600FA23 RID: 64035 RVA: 0x0041D740 File Offset: 0x0041B940
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
			}
			this.m_equipItemCache.Clear();
			this.m_loopScrollView.m_functionGetItemIndex = delegate(string itemName)
			{
				for (int i = 0; i < this.m_equipItemCache.Count; i++)
				{
					if (this.m_equipItemCache[i].ListItemName == itemName)
					{
						return i;
					}
				}
				return -1;
			};
		}

		// Token: 0x0600FA24 RID: 64036 RVA: 0x0041D8A8 File Offset: 0x0041BAA8
		public void UpdateEquipmentDepotView(Hero hero, int slot, ulong equipmentId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateEquipmentDepotViewHeroInt32UInt64_hotfix != null)
			{
				this.m_UpdateEquipmentDepotViewHeroInt32UInt64_hotfix.call(new object[]
				{
					this,
					hero,
					slot,
					equipmentId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_slot = slot;
			this.m_curEquipmentInstanceId = equipmentId;
			this.CreateEquipmentList();
			Canvas.ForceUpdateCanvases();
			this.m_goldText.text = this.m_playerContext.GetGold().ToString();
		}

		// Token: 0x0600FA25 RID: 64037 RVA: 0x0041D97C File Offset: 0x0041BB7C
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
			List<EquipmentBagItem> list = new List<EquipmentBagItem>();
			List<EquipmentBagItem> list2 = new List<EquipmentBagItem>();
			foreach (BagItemBase bagItemBase in this.m_playerContext.GetBagItems())
			{
				if (bagItemBase.EquipmentInfo != null && bagItemBase.EquipmentInfo.EquipmentType == (EquipmentType)this.m_slot)
				{
					if (this.m_playerContext.CanWearEquipment(this.m_hero.HeroId, bagItemBase.InstanceId) == 0)
					{
						list.Add((EquipmentBagItem)bagItemBase);
					}
					else
					{
						list2.Add((EquipmentBagItem)bagItemBase);
					}
				}
			}
			this.m_canUseEquipmentCount = list.Count;
			EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(this.m_hero.EquipmentIds[this.m_slot]) as EquipmentBagItem;
			if (equipmentBagItem != null)
			{
				list.Remove(equipmentBagItem);
			}
			this.SortEquipmentListByType(list);
			this.SortEquipmentListByType(list2);
			this.m_equipItemCache.Clear();
			if (equipmentBagItem != null)
			{
				this.m_equipItemCache.Add(equipmentBagItem);
			}
			this.m_equipItemCache.AddRange(list);
			this.m_equipItemCache.AddRange(list2);
			int startIdx = 0;
			if (this.m_curEquipmentInstanceId != 0UL && !this.m_isFirstIn)
			{
				GameObject firstGameObjectInViewRect = this.m_loopScrollView.GetFirstGameObjectInViewRect();
				if (firstGameObjectInViewRect != null)
				{
					startIdx = firstGameObjectInViewRect.GetComponent<ScrollItemBaseUIController>().ItemIndex;
				}
			}
			if (this.m_curEquipmentInstanceId == 0UL && this.m_equipItemCache.Count > 0)
			{
				this.m_curEquipmentInstanceId = this.m_equipItemCache[0].InstanceId;
			}
			this.m_loopScrollView.totalCount = this.m_equipItemCache.Count;
			this.m_loopScrollView.RefillCells(startIdx);
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = this.m_equipmentDepotCtrlList.Find((EquipmentDepotListItemUIController a) => a.EquipmentInstanceId == this.m_curEquipmentInstanceId);
			if (equipmentDepotListItemUIController != null)
			{
				equipmentDepotListItemUIController.ShowSelectFrame(true);
			}
			EquipmentBagItem equipmentBagItem2 = this.m_playerContext.GetBagItemByInstanceId(this.m_curEquipmentInstanceId) as EquipmentBagItem;
			if (equipmentBagItem2 != null)
			{
				this.SetEquipmentItemDesc(equipmentBagItem2);
			}
			this.m_listNotItemGo.SetActive(this.m_equipItemCache.Count == 0);
			this.m_isFirstIn = false;
		}

		// Token: 0x0600FA26 RID: 64038 RVA: 0x0041DC2C File Offset: 0x0041BE2C
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

		// Token: 0x0600FA27 RID: 64039 RVA: 0x0041DD6C File Offset: 0x0041BF6C
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

		// Token: 0x0600FA28 RID: 64040 RVA: 0x0041DE38 File Offset: 0x0041C038
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

		// Token: 0x0600FA29 RID: 64041 RVA: 0x0041DFC8 File Offset: 0x0041C1C8
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
			this.m_slot = (int)equipmentDepotListItemUIController.BagItem.EquipmentInfo.EquipmentType;
			this.SetEquipmentItemDesc((EquipmentBagItem)equipmentDepotListItemUIController.BagItem);
			EquipmentDepotListItemUIController equipmentDepotListItemUIController2 = this.m_equipmentDepotCtrlList.Find((EquipmentDepotListItemUIController a) => a.EquipmentInstanceId == this.m_curEquipmentInstanceId);
			if (equipmentDepotListItemUIController2 != null)
			{
				equipmentDepotListItemUIController2.ShowSelectFrame(false);
			}
			this.m_curEquipmentInstanceId = equipmentDepotListItemUIController.BagItem.InstanceId;
			equipmentDepotListItemUIController.ShowSelectFrame(true);
		}

		// Token: 0x0600FA2A RID: 64042 RVA: 0x0041E0B8 File Offset: 0x0041C2B8
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
			EquipmentDepotListItemUIController equipmentDepotListItemUIController = itemCtrl as EquipmentDepotListItemUIController;
			if (equipmentDepotListItemUIController == null)
			{
				return;
			}
			int itemIndex = equipmentDepotListItemUIController.ScrollItemBaseUICtrl.ItemIndex;
			if (itemIndex < this.m_equipItemCache.Count)
			{
				equipmentDepotListItemUIController.InitEquipmentDepotListItemInfo(this.m_equipItemCache[itemIndex], itemIndex < this.m_canUseEquipmentCount);
				if (equipmentDepotListItemUIController.EquipmentInstanceId == this.m_curEquipmentInstanceId)
				{
					equipmentDepotListItemUIController.ShowSelectFrame(true);
				}
				else
				{
					equipmentDepotListItemUIController.ShowSelectFrame(false);
				}
				if (!this.m_equipmentDepotCtrlList.Contains(equipmentDepotListItemUIController))
				{
					this.m_equipmentDepotCtrlList.Add(equipmentDepotListItemUIController);
				}
				Animator component = equipmentDepotListItemUIController.gameObject.GetComponent<Animator>();
				component.Play("Normal");
			}
		}

		// Token: 0x0600FA2B RID: 64043 RVA: 0x0041E1CC File Offset: 0x0041C3CC
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

		// Token: 0x0600FA2C RID: 64044 RVA: 0x0041E260 File Offset: 0x0041C460
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

		// Token: 0x0600FA2D RID: 64045 RVA: 0x0041E2CC File Offset: 0x0041C4CC
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

		// Token: 0x0600FA2E RID: 64046 RVA: 0x0041E378 File Offset: 0x0041C578
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

		// Token: 0x0600FA2F RID: 64047 RVA: 0x0041E428 File Offset: 0x0041C628
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
			PlayerContextBase playerContext = GameManager.Instance.PlayerContext;
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
			UIUtility.SetGameObjectChildrenActiveCount(this.m_descPropContent, 0);
			this.SetPropItems(equipment.EquipmentInfo.Property1_ID, equipment.EquipmentInfo.Property1_Value, equipment.EquipmentInfo.Property1_LevelUpValue, equipment.Level);
			this.SetPropItems(equipment.EquipmentInfo.Property2_ID, equipment.EquipmentInfo.Property2_Value, equipment.EquipmentInfo.Property2_LevelUpValue, equipment.Level);
			if (equipment.IsEnchant())
			{
				int equipmentResonanceNumsByHeroId = this.m_playerContext.GetEquipmentResonanceNumsByHeroId(equipment.InstanceId, this.m_hero.HeroId);
				if (equipmentResonanceNumsByHeroId < 2)
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
					equipmentResonanceNumsByHeroId,
					"/4)"
				});
				this.m_descPropGroupStateCtrl.SetToUIState("Resonance", false, true);
				List<CommonBattleProperty> enchantProperties = equipment.EnchantProperties;
				Transform transform = this.m_descPropEnchantmentGroup.transform;
				for (int k = 0; k < transform.childCount; k++)
				{
					Text text = null;
					Text text2 = null;
					Transform child3 = transform.GetChild(k);
					for (int l = 0; l < child3.childCount; l++)
					{
						Transform child4 = child3.GetChild(l);
						if (child4.name == "NameText")
						{
							text = child4.GetComponent<Text>();
						}
						else if (child4.name == "ValueText")
						{
							text2 = child4.GetComponent<Text>();
						}
					}
					if (k < enchantProperties.Count)
					{
						ConfigDataPropertyModifyInfo configDataPropertyModifyInfo = this.m_configDataLoader.GetConfigDataPropertyModifyInfo((int)enchantProperties[k].Id);
						text.text = configDataPropertyModifyInfo.Name;
						text.gameObject.SetActive(true);
						if (configDataPropertyModifyInfo.IsAddType)
						{
							text2.text = enchantProperties[k].Value.ToString();
						}
						else
						{
							text2.text = enchantProperties[k].Value / 100 + "%";
						}
					}
					else
					{
						text.gameObject.SetActive(false);
						text2.text = "--";
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
				string text3 = null;
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(UIUtility.GetSkillIdFromEquipment(equipment.EquipmentInfo, equipment.Level, ref text3));
				if (configDataSkillInfo != null)
				{
					if (text3 == null)
					{
						this.m_descSkillContentStateCtrl.SetToUIState("Grey", false, true);
						this.m_descUnlockCoditionText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_EnchantToLevel), equipment.EquipmentInfo.SkillLevels[0]);
					}
					else
					{
						this.m_descSkillContentStateCtrl.SetToUIState("Normal", false, true);
						this.m_descSkillLvText.text = "Lv." + text3;
					}
					this.m_descSkillNameText.text = configDataSkillInfo.Name;
					this.m_descSkillDescText.text = configDataSkillInfo.Desc;
					ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(equipment.EquipmentInfo.SkillHero);
					this.m_descSkillOwnerText.gameObject.SetActive(configDataHeroInfo != null);
					this.m_descSkillOwnerBGImage.SetActive(configDataHeroInfo != null);
					if (configDataHeroInfo != null)
					{
						this.m_descSkillOwnerText.text = configDataHeroInfo.Name + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Equipment_SkillOwner);
					}
				}
			}
			CommonUIStateController component2 = this.m_descLockButton.GetComponent<CommonUIStateController>();
			if (equipment.Locked)
			{
				component2.SetToUIState("Lock", false, false);
			}
			else
			{
				component2.SetToUIState("Unlock", false, false);
			}
			bool flag = this.m_playerContext.CanWearEquipment(this.m_hero.HeroId, equipment.InstanceId) == 0;
			bool flag2 = this.m_playerContext.GetWearedEquipmentHeroIdByEquipmentId(equipment.InstanceId) == this.m_hero.HeroId;
			this.m_descEquipButton.gameObject.SetActive(!flag2 && flag);
			this.m_descUnloadButton.gameObject.SetActive(flag2);
			this.SetEquipmentComparison(equipment);
		}

		// Token: 0x0600FA30 RID: 64048 RVA: 0x0041EC7C File Offset: 0x0041CE7C
		private void SetEquipmentComparison(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentComparisonEquipmentBagItem_hotfix != null)
			{
				this.m_SetEquipmentComparisonEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int equipmentType = (int)equipment.EquipmentInfo.EquipmentType;
			if (equipmentType >= this.m_hero.EquipmentIds.Length)
			{
				this.m_PropertyComparisonGo.SetActive(false);
				return;
			}
			for (int i = 0; i < this.m_allDescPropGo.transform.childCount; i++)
			{
				Transform child = this.m_allDescPropGo.transform.GetChild(i);
				child.gameObject.SetActive(false);
			}
			this.ResetEquipmentComparisonPropValue();
			ulong num = this.m_hero.EquipmentIds[equipmentType];
			if (num != 0UL)
			{
				EquipmentBagItem equipmentBagItem = this.m_playerContext.GetBagItemByInstanceId(num) as EquipmentBagItem;
				this.SetEquipmentComparisonProp(equipmentBagItem.EquipmentInfo.Property1_ID, equipmentBagItem.EquipmentInfo.Property1_Value + equipmentBagItem.EquipmentInfo.Property1_LevelUpValue * (equipmentBagItem.Level - 1) / 10, true);
				this.SetEquipmentComparisonProp(equipmentBagItem.EquipmentInfo.Property2_ID, equipmentBagItem.EquipmentInfo.Property2_Value + equipmentBagItem.EquipmentInfo.Property2_LevelUpValue * (equipmentBagItem.Level - 1) / 10, true);
			}
			this.SetEquipmentComparisonProp(equipment.EquipmentInfo.Property1_ID, equipment.EquipmentInfo.Property1_Value + equipment.EquipmentInfo.Property1_LevelUpValue * (equipment.Level - 1) / 10, false);
			this.SetEquipmentComparisonProp(equipment.EquipmentInfo.Property2_ID, equipment.EquipmentInfo.Property2_Value + equipment.EquipmentInfo.Property2_LevelUpValue * (equipment.Level - 1) / 10, false);
		}

		// Token: 0x0600FA31 RID: 64049 RVA: 0x0041EE64 File Offset: 0x0041D064
		private void ResetEquipmentComparisonPropValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetEquipmentComparisonPropValue_hotfix != null)
			{
				this.m_ResetEquipmentComparisonPropValue_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_allDescHpOldText.text = "0";
			this.m_allDescHpNewText.text = "0";
			this.m_allDescATOldText.text = "0";
			this.m_allDescATNewText.text = "0";
			this.m_allDescDFOldText.text = "0";
			this.m_allDescDFNewText.text = "0";
			this.m_allDescMagicOldText.text = "0";
			this.m_allDescMagicNewText.text = "0";
			this.m_allDescMagicDFOldText.text = "0";
			this.m_allDescMagicDFNewText.text = "0";
			this.m_allDescDexOldText.text = "0";
			this.m_allDescDexNewText.text = "0";
		}

		// Token: 0x0600FA32 RID: 64050 RVA: 0x0041EF84 File Offset: 0x0041D184
		private void SetEquipmentComparisonProp(PropertyModifyType type, int value, bool isDressed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentComparisonPropPropertyModifyTypeInt32Boolean_hotfix != null)
			{
				this.m_SetEquipmentComparisonPropPropertyModifyTypeInt32Boolean_hotfix.call(new object[]
				{
					this,
					type,
					value,
					isDressed
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (type)
			{
			case PropertyModifyType.PropertyModifyType_Hero1_HPAdd:
				this.m_allDescHpGo.SetActive(true);
				if (isDressed)
				{
					this.m_allDescHpOldText.text = value.ToString();
				}
				else
				{
					this.m_allDescHpNewText.text = value.ToString();
				}
				this.SetPropItemColor(this.m_allDescHpOldText, this.m_allDescHpNewText);
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_ATAdd:
				this.m_allDescATGo.SetActive(true);
				if (isDressed)
				{
					this.m_allDescATOldText.text = value.ToString();
				}
				else
				{
					this.m_allDescATNewText.text = value.ToString();
				}
				this.SetPropItemColor(this.m_allDescATOldText, this.m_allDescATNewText);
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DFAdd:
				this.m_allDescDFGo.SetActive(true);
				if (isDressed)
				{
					this.m_allDescDFOldText.text = value.ToString();
				}
				else
				{
					this.m_allDescDFNewText.text = value.ToString();
				}
				this.SetPropItemColor(this.m_allDescDFOldText, this.m_allDescDFNewText);
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicAdd:
				this.m_allDescMagicGo.SetActive(true);
				if (isDressed)
				{
					this.m_allDescMagicOldText.text = value.ToString();
				}
				else
				{
					this.m_allDescMagicNewText.text = value.ToString();
				}
				this.SetPropItemColor(this.m_allDescMagicOldText, this.m_allDescMagicNewText);
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicDFAdd:
				this.m_allDescMagicDFGo.SetActive(true);
				if (isDressed)
				{
					this.m_allDescMagicDFOldText.text = value.ToString();
				}
				else
				{
					this.m_allDescMagicDFNewText.text = value.ToString();
				}
				this.SetPropItemColor(this.m_allDescMagicDFOldText, this.m_allDescMagicDFNewText);
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DEXAdd:
				this.m_allDescDexGo.SetActive(true);
				if (isDressed)
				{
					this.m_allDescDexOldText.text = value.ToString();
				}
				else
				{
					this.m_allDescDexNewText.text = value.ToString();
				}
				this.SetPropItemColor(this.m_allDescDexOldText, this.m_allDescDexNewText);
				break;
			}
		}

		// Token: 0x0600FA33 RID: 64051 RVA: 0x0041F270 File Offset: 0x0041D470
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

		// Token: 0x0600FA34 RID: 64052 RVA: 0x0041F350 File Offset: 0x0041D550
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

		// Token: 0x0600FA35 RID: 64053 RVA: 0x0041F4EC File Offset: 0x0041D6EC
		private void OnDescEquipButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDescEquipButtonClick_hotfix != null)
			{
				this.m_OnDescEquipButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanWearEquipment(this.m_hero.HeroId, this.m_curEquipmentInstanceId);
			if (num == 0)
			{
				bool flag = this.m_playerContext.IsEquipmentWeared(this.m_curEquipmentInstanceId);
				if (flag)
				{
					this.m_confirmPanelStateCtrl.gameObject.SetActive(true);
					this.m_confirmPanelStateCtrl.SetToUIState("Show", false, true);
				}
				else
				{
					this.m_isFirstIn = true;
					if (this.EventOnEquipButtonClick != null)
					{
						this.EventOnEquipButtonClick(this.m_hero.HeroId, this.m_curEquipmentInstanceId, this.m_slot);
					}
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600FA36 RID: 64054 RVA: 0x0041F5FC File Offset: 0x0041D7FC
		private void OnConfirmPanelConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfirmPanelConfirmButtonClick_hotfix != null)
			{
				this.m_OnConfirmPanelConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isFirstIn = true;
			if (this.EventOnTakeOffEquipment != null)
			{
				this.EventOnTakeOffEquipment(this.m_playerContext.GetWearedEquipmentHeroIdByEquipmentId(this.m_curEquipmentInstanceId), this.m_slot, delegate
				{
					if (this.EventOnEquipButtonClick != null)
					{
						this.EventOnEquipButtonClick(this.m_hero.HeroId, this.m_curEquipmentInstanceId, this.m_slot);
					}
				});
			}
			this.OnConfirmPanelCancelButtonClick();
		}

		// Token: 0x0600FA37 RID: 64055 RVA: 0x0041F6A4 File Offset: 0x0041D8A4
		private void OnConfirmPanelCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfirmPanelCancelButtonClick_hotfix != null)
			{
				this.m_OnConfirmPanelCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_confirmPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_confirmPanelStateCtrl.gameObject.SetActive(false);
			});
			this.m_confirmPanelStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x0600FA38 RID: 64056 RVA: 0x0041F734 File Offset: 0x0041D934
		private void OnDescUnloadButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDescUnloadButtonClick_hotfix != null)
			{
				this.m_OnDescUnloadButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanTakeOffEquipment(this.m_hero.HeroId, this.m_slot);
			if (num == 0)
			{
				this.m_isFirstIn = true;
				if (this.EventOnTakeOffEquipment != null)
				{
					this.EventOnTakeOffEquipment(this.m_hero.HeroId, this.m_slot, null);
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600FA39 RID: 64057 RVA: 0x0041F800 File Offset: 0x0041DA00
		private void OnDescLockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDescLockButtonClick_hotfix != null)
			{
				this.m_OnDescLockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnLockButtonClick != null)
			{
				this.EventOnLockButtonClick(this.m_curEquipmentInstanceId, this.m_slot);
			}
		}

		// Token: 0x0600FA3A RID: 64058 RVA: 0x0041F884 File Offset: 0x0041DA84
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
			this.ResetScrollViewToTop();
			this.m_isFirstIn = true;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x0600FA3B RID: 64059 RVA: 0x0041F908 File Offset: 0x0041DB08
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
				this.EventOnGoldAddButtonClick();
			}
		}

		// Token: 0x0600FA3C RID: 64060 RVA: 0x0041F980 File Offset: 0x0041DB80
		private void ResetScrollViewToTop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetScrollViewToTop_hotfix != null)
			{
				this.m_ResetScrollViewToTop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loopScrollView.normalizedPosition = Vector2.one;
		}

		// Token: 0x0600FA3D RID: 64061 RVA: 0x0041F9F0 File Offset: 0x0041DBF0
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

		// Token: 0x0600FA3E RID: 64062 RVA: 0x0041FA6C File Offset: 0x0041DC6C
		public void ClickEquipmentListItemForUserGuide(UIControllerBase itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClickEquipmentListItemForUserGuideUIControllerBase_hotfix != null)
			{
				this.m_ClickEquipmentListItemForUserGuideUIControllerBase_hotfix.call(new object[]
				{
					this,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (itemCtrl != null)
			{
				this.OnEquipmentListItemClick(itemCtrl);
			}
		}

		// Token: 0x1400034E RID: 846
		// (add) Token: 0x0600FA3F RID: 64063 RVA: 0x0041FAF0 File Offset: 0x0041DCF0
		// (remove) Token: 0x0600FA40 RID: 64064 RVA: 0x0041FB8C File Offset: 0x0041DD8C
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

		// Token: 0x1400034F RID: 847
		// (add) Token: 0x0600FA41 RID: 64065 RVA: 0x0041FC28 File Offset: 0x0041DE28
		// (remove) Token: 0x0600FA42 RID: 64066 RVA: 0x0041FCC4 File Offset: 0x0041DEC4
		public event Action EventOnGoldAddButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoldAddButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnGoldAddButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGoldAddButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGoldAddButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoldAddButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnGoldAddButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGoldAddButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGoldAddButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000350 RID: 848
		// (add) Token: 0x0600FA43 RID: 64067 RVA: 0x0041FD60 File Offset: 0x0041DF60
		// (remove) Token: 0x0600FA44 RID: 64068 RVA: 0x0041FDFC File Offset: 0x0041DFFC
		public event Action<int, int, Action> EventOnTakeOffEquipment
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTakeOffEquipmentAction`3_hotfix != null)
				{
					this.m_add_EventOnTakeOffEquipmentAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnTakeOffEquipment;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnTakeOffEquipment, (Action<int, int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTakeOffEquipmentAction`3_hotfix != null)
				{
					this.m_remove_EventOnTakeOffEquipmentAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnTakeOffEquipment;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnTakeOffEquipment, (Action<int, int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000351 RID: 849
		// (add) Token: 0x0600FA45 RID: 64069 RVA: 0x0041FE98 File Offset: 0x0041E098
		// (remove) Token: 0x0600FA46 RID: 64070 RVA: 0x0041FF34 File Offset: 0x0041E134
		public event Action<ulong, int> EventOnLockButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLockButtonClickAction`2_hotfix != null)
				{
					this.m_add_EventOnLockButtonClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int> action = this.EventOnLockButtonClick;
				Action<ulong, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int>>(ref this.EventOnLockButtonClick, (Action<ulong, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLockButtonClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnLockButtonClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int> action = this.EventOnLockButtonClick;
				Action<ulong, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int>>(ref this.EventOnLockButtonClick, (Action<ulong, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000352 RID: 850
		// (add) Token: 0x0600FA47 RID: 64071 RVA: 0x0041FFD0 File Offset: 0x0041E1D0
		// (remove) Token: 0x0600FA48 RID: 64072 RVA: 0x0042006C File Offset: 0x0041E26C
		public event Action<int, ulong, int> EventOnEquipButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEquipButtonClickAction`3_hotfix != null)
				{
					this.m_add_EventOnEquipButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong, int> action = this.EventOnEquipButtonClick;
				Action<int, ulong, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong, int>>(ref this.EventOnEquipButtonClick, (Action<int, ulong, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEquipButtonClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnEquipButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong, int> action = this.EventOnEquipButtonClick;
				Action<int, ulong, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong, int>>(ref this.EventOnEquipButtonClick, (Action<int, ulong, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x0600FA49 RID: 64073 RVA: 0x00420108 File Offset: 0x0041E308
		// (set) Token: 0x0600FA4A RID: 64074 RVA: 0x00420128 File Offset: 0x0041E328
		[DoNotToLua]
		public new EquipmentDepotUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EquipmentDepotUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600FA4B RID: 64075 RVA: 0x00420134 File Offset: 0x0041E334
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600FA4C RID: 64076 RVA: 0x00420140 File Offset: 0x0041E340
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600FA4D RID: 64077 RVA: 0x00420148 File Offset: 0x0041E348
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600FA4E RID: 64078 RVA: 0x00420150 File Offset: 0x0041E350
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600FA4F RID: 64079 RVA: 0x00420164 File Offset: 0x0041E364
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600FA50 RID: 64080 RVA: 0x0042016C File Offset: 0x0041E36C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600FA51 RID: 64081 RVA: 0x00420178 File Offset: 0x0041E378
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600FA52 RID: 64082 RVA: 0x00420184 File Offset: 0x0041E384
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600FA53 RID: 64083 RVA: 0x00420190 File Offset: 0x0041E390
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600FA54 RID: 64084 RVA: 0x0042019C File Offset: 0x0041E39C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600FA55 RID: 64085 RVA: 0x004201A8 File Offset: 0x0041E3A8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600FA56 RID: 64086 RVA: 0x004201B4 File Offset: 0x0041E3B4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600FA57 RID: 64087 RVA: 0x004201C0 File Offset: 0x0041E3C0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600FA58 RID: 64088 RVA: 0x004201CC File Offset: 0x0041E3CC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600FA59 RID: 64089 RVA: 0x004201D8 File Offset: 0x0041E3D8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600FA5A RID: 64090 RVA: 0x004201E0 File Offset: 0x0041E3E0
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600FA5B RID: 64091 RVA: 0x00420200 File Offset: 0x0041E400
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600FA5C RID: 64092 RVA: 0x0042020C File Offset: 0x0041E40C
		private void __callDele_EventOnGoldAddButtonClick()
		{
			Action eventOnGoldAddButtonClick = this.EventOnGoldAddButtonClick;
			if (eventOnGoldAddButtonClick != null)
			{
				eventOnGoldAddButtonClick();
			}
		}

		// Token: 0x0600FA5D RID: 64093 RVA: 0x0042022C File Offset: 0x0041E42C
		private void __clearDele_EventOnGoldAddButtonClick()
		{
			this.EventOnGoldAddButtonClick = null;
		}

		// Token: 0x0600FA5E RID: 64094 RVA: 0x00420238 File Offset: 0x0041E438
		private void __callDele_EventOnTakeOffEquipment(int arg1, int arg2, Action arg3)
		{
			Action<int, int, Action> eventOnTakeOffEquipment = this.EventOnTakeOffEquipment;
			if (eventOnTakeOffEquipment != null)
			{
				eventOnTakeOffEquipment(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600FA5F RID: 64095 RVA: 0x0042025C File Offset: 0x0041E45C
		private void __clearDele_EventOnTakeOffEquipment(int arg1, int arg2, Action arg3)
		{
			this.EventOnTakeOffEquipment = null;
		}

		// Token: 0x0600FA60 RID: 64096 RVA: 0x00420268 File Offset: 0x0041E468
		private void __callDele_EventOnLockButtonClick(ulong arg1, int arg2)
		{
			Action<ulong, int> eventOnLockButtonClick = this.EventOnLockButtonClick;
			if (eventOnLockButtonClick != null)
			{
				eventOnLockButtonClick(arg1, arg2);
			}
		}

		// Token: 0x0600FA61 RID: 64097 RVA: 0x0042028C File Offset: 0x0041E48C
		private void __clearDele_EventOnLockButtonClick(ulong arg1, int arg2)
		{
			this.EventOnLockButtonClick = null;
		}

		// Token: 0x0600FA62 RID: 64098 RVA: 0x00420298 File Offset: 0x0041E498
		private void __callDele_EventOnEquipButtonClick(int arg1, ulong arg2, int arg3)
		{
			Action<int, ulong, int> eventOnEquipButtonClick = this.EventOnEquipButtonClick;
			if (eventOnEquipButtonClick != null)
			{
				eventOnEquipButtonClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600FA63 RID: 64099 RVA: 0x004202BC File Offset: 0x0041E4BC
		private void __clearDele_EventOnEquipButtonClick(int arg1, ulong arg2, int arg3)
		{
			this.EventOnEquipButtonClick = null;
		}

		// Token: 0x0600FA6C RID: 64108 RVA: 0x00420460 File Offset: 0x0041E660
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
					this.m_UpdateEquipmentDepotViewHeroInt32UInt64_hotfix = (luaObj.RawGet("UpdateEquipmentDepotView") as LuaFunction);
					this.m_CreateEquipmentList_hotfix = (luaObj.RawGet("CreateEquipmentList") as LuaFunction);
					this.m_SortEquipmentListByTypeList`1_hotfix = (luaObj.RawGet("SortEquipmentListByType") as LuaFunction);
					this.m_DefaultEquipmentItemComparerEquipmentBagItemEquipmentBagItem_hotfix = (luaObj.RawGet("DefaultEquipmentItemComparer") as LuaFunction);
					this.m_CollectEquipmentPropValueAndSortList`1PropertyModifyType_hotfix = (luaObj.RawGet("CollectEquipmentPropValueAndSort") as LuaFunction);
					this.m_OnEquipmentListItemClickUIControllerBase_hotfix = (luaObj.RawGet("OnEquipmentListItemClick") as LuaFunction);
					this.m_OnEquipmentListItemNeedFillUIControllerBase_hotfix = (luaObj.RawGet("OnEquipmentListItemNeedFill") as LuaFunction);
					this.m_OnFilterSortButtonClick_hotfix = (luaObj.RawGet("OnFilterSortButtonClick") as LuaFunction);
					this.m_OnCloseFilterSortTypeGo_hotfix = (luaObj.RawGet("OnCloseFilterSortTypeGo") as LuaFunction);
					this.m_OnFilterSortOrderButtonClick_hotfix = (luaObj.RawGet("OnFilterSortOrderButtonClick") as LuaFunction);
					this.m_OnFilterTypeButtonClickEquipmentSortItemUIControllerBoolean_hotfix = (luaObj.RawGet("OnFilterTypeButtonClick") as LuaFunction);
					this.m_SetEquipmentItemDescEquipmentBagItem_hotfix = (luaObj.RawGet("SetEquipmentItemDesc") as LuaFunction);
					this.m_SetEquipmentComparisonEquipmentBagItem_hotfix = (luaObj.RawGet("SetEquipmentComparison") as LuaFunction);
					this.m_ResetEquipmentComparisonPropValue_hotfix = (luaObj.RawGet("ResetEquipmentComparisonPropValue") as LuaFunction);
					this.m_SetEquipmentComparisonPropPropertyModifyTypeInt32Boolean_hotfix = (luaObj.RawGet("SetEquipmentComparisonProp") as LuaFunction);
					this.m_SetPropItemColorTextText_hotfix = (luaObj.RawGet("SetPropItemColor") as LuaFunction);
					this.m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix = (luaObj.RawGet("SetPropItems") as LuaFunction);
					this.m_OnDescEquipButtonClick_hotfix = (luaObj.RawGet("OnDescEquipButtonClick") as LuaFunction);
					this.m_OnConfirmPanelConfirmButtonClick_hotfix = (luaObj.RawGet("OnConfirmPanelConfirmButtonClick") as LuaFunction);
					this.m_OnConfirmPanelCancelButtonClick_hotfix = (luaObj.RawGet("OnConfirmPanelCancelButtonClick") as LuaFunction);
					this.m_OnDescUnloadButtonClick_hotfix = (luaObj.RawGet("OnDescUnloadButtonClick") as LuaFunction);
					this.m_OnDescLockButtonClick_hotfix = (luaObj.RawGet("OnDescLockButtonClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnGoldAddButtonClick_hotfix = (luaObj.RawGet("OnGoldAddButtonClick") as LuaFunction);
					this.m_ResetScrollViewToTop_hotfix = (luaObj.RawGet("ResetScrollViewToTop") as LuaFunction);
					this.m_GetFirstEquipmentGoInListForUserGuide_hotfix = (luaObj.RawGet("GetFirstEquipmentGoInListForUserGuide") as LuaFunction);
					this.m_ClickEquipmentListItemForUserGuideUIControllerBase_hotfix = (luaObj.RawGet("ClickEquipmentListItemForUserGuide") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnGoldAddButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnGoldAddButtonClick") as LuaFunction);
					this.m_remove_EventOnGoldAddButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnGoldAddButtonClick") as LuaFunction);
					this.m_add_EventOnTakeOffEquipmentAction`3_hotfix = (luaObj.RawGet("add_EventOnTakeOffEquipment") as LuaFunction);
					this.m_remove_EventOnTakeOffEquipmentAction`3_hotfix = (luaObj.RawGet("remove_EventOnTakeOffEquipment") as LuaFunction);
					this.m_add_EventOnLockButtonClickAction`2_hotfix = (luaObj.RawGet("add_EventOnLockButtonClick") as LuaFunction);
					this.m_remove_EventOnLockButtonClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnLockButtonClick") as LuaFunction);
					this.m_add_EventOnEquipButtonClickAction`3_hotfix = (luaObj.RawGet("add_EventOnEquipButtonClick") as LuaFunction);
					this.m_remove_EventOnEquipButtonClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnEquipButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600FA6D RID: 64109 RVA: 0x004208FC File Offset: 0x0041EAFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentDepotUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040092E4 RID: 37604
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x040092E5 RID: 37605
		[AutoBind("./PlayerResource/Gold/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_goldText;

		// Token: 0x040092E6 RID: 37606
		[AutoBind("./PlayerResource/Gold/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_goldAddButton;

		// Token: 0x040092E7 RID: 37607
		[AutoBind("./EquipmentList/ListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private LoopVerticalScrollRect m_loopScrollView;

		// Token: 0x040092E8 RID: 37608
		[AutoBind("./EquipmentList/ListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private EasyObjectPool m_listItemPool;

		// Token: 0x040092E9 RID: 37609
		[AutoBind("./EquipmentList/ListScrollView/ItemRoot", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_listScrollViewItemRoot;

		// Token: 0x040092EA RID: 37610
		[AutoBind("./EquipmentList/Filter/SortButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_filterSortButton;

		// Token: 0x040092EB RID: 37611
		[AutoBind("./EquipmentList/Filter/SortButton/SortTypeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_filterSortTypeText;

		// Token: 0x040092EC RID: 37612
		[AutoBind("./EquipmentList/Filter/SortOrderButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_filterSortOrderButton;

		// Token: 0x040092ED RID: 37613
		[AutoBind("./EquipmentList/Filter/SortTypes", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_filterSortTypesGo;

		// Token: 0x040092EE RID: 37614
		[AutoBind("./EquipmentList/Filter/SortTypes/GridLayout", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_filterSortTypesGridLayout;

		// Token: 0x040092EF RID: 37615
		[AutoBind("./EquipmentList/NoItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_listNotItemGo;

		// Token: 0x040092F0 RID: 37616
		[AutoBind("./Desc/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descTitleText;

		// Token: 0x040092F1 RID: 37617
		[AutoBind("./Desc/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_descIcon;

		// Token: 0x040092F2 RID: 37618
		[AutoBind("./Desc/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_descIconBg;

		// Token: 0x040092F3 RID: 37619
		[AutoBind("./Desc/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descSSREffect;

		// Token: 0x040092F4 RID: 37620
		[AutoBind("./Desc/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descStarGroup;

		// Token: 0x040092F5 RID: 37621
		[AutoBind("./Desc/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descLvText;

		// Token: 0x040092F6 RID: 37622
		[AutoBind("./Desc/ExpText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descExpText;

		// Token: 0x040092F7 RID: 37623
		[AutoBind("./Desc/ProgressImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_descProgressImage;

		// Token: 0x040092F8 RID: 37624
		[AutoBind("./Desc/EquipLimitContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descEquipLimitContent;

		// Token: 0x040092F9 RID: 37625
		[AutoBind("./Desc/EquipUnlimitText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descEquipUnlimitText;

		// Token: 0x040092FA RID: 37626
		[AutoBind("./Desc/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descSkillContent;

		// Token: 0x040092FB RID: 37627
		[AutoBind("./Desc/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_descSkillContentStateCtrl;

		// Token: 0x040092FC RID: 37628
		[AutoBind("./Desc/SkillContent/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descSkillNameText;

		// Token: 0x040092FD RID: 37629
		[AutoBind("./Desc/SkillContent/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descSkillLvText;

		// Token: 0x040092FE RID: 37630
		[AutoBind("./Desc/SkillContent/UnlockCoditionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descUnlockCoditionText;

		// Token: 0x040092FF RID: 37631
		[AutoBind("./Desc/SkillContent/Owner", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descSkillOwnerText;

		// Token: 0x04009300 RID: 37632
		[AutoBind("./Desc/SkillContent/BelongBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descSkillOwnerBGImage;

		// Token: 0x04009301 RID: 37633
		[AutoBind("./Desc/SkillContent/DescScrollView/Mask/Content/Desc", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descSkillDescText;

		// Token: 0x04009302 RID: 37634
		[AutoBind("./Desc/NotEquipSkillTip", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descNotEquipSkillTip;

		// Token: 0x04009303 RID: 37635
		[AutoBind("./Desc/LockButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_descLockButton;

		// Token: 0x04009304 RID: 37636
		[AutoBind("./Desc/EquipButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_descEquipButton;

		// Token: 0x04009305 RID: 37637
		[AutoBind("./Desc/UnloadButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_descUnloadButton;

		// Token: 0x04009306 RID: 37638
		[AutoBind("./Desc/PropGroup/PropContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropContent;

		// Token: 0x04009307 RID: 37639
		[AutoBind("./Desc/PropGroup/PropContent/AT", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropATGo;

		// Token: 0x04009308 RID: 37640
		[AutoBind("./Desc/PropGroup/PropContent/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropATValueText;

		// Token: 0x04009309 RID: 37641
		[AutoBind("./Desc/PropGroup/PropContent/DF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropDFGo;

		// Token: 0x0400930A RID: 37642
		[AutoBind("./Desc/PropGroup/PropContent/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropDFValueText;

		// Token: 0x0400930B RID: 37643
		[AutoBind("./Desc/PropGroup/PropContent/HP", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropHPGo;

		// Token: 0x0400930C RID: 37644
		[AutoBind("./Desc/PropGroup/PropContent/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropHPValueText;

		// Token: 0x0400930D RID: 37645
		[AutoBind("./Desc/PropGroup/PropContent/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropMagiccGo;

		// Token: 0x0400930E RID: 37646
		[AutoBind("./Desc/PropGroup/PropContent/Magic/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropMagicValueText;

		// Token: 0x0400930F RID: 37647
		[AutoBind("./Desc/PropGroup/PropContent/MagicDF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropMagicDFGo;

		// Token: 0x04009310 RID: 37648
		[AutoBind("./Desc/PropGroup/PropContent/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropMagicDFValueText;

		// Token: 0x04009311 RID: 37649
		[AutoBind("./Desc/PropGroup/PropContent/Dex", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropDexGo;

		// Token: 0x04009312 RID: 37650
		[AutoBind("./Desc/PropGroup/PropContent/Dex/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropDexValueText;

		// Token: 0x04009313 RID: 37651
		[AutoBind("./Desc/PropGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_descPropGroupStateCtrl;

		// Token: 0x04009314 RID: 37652
		[AutoBind("./Desc/PropGroup/EnchantmentGroup/PropertyGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropEnchantmentGroup;

		// Token: 0x04009315 RID: 37653
		[AutoBind("./Desc/PropGroup/EnchantmentGroup/Resonance/RuneIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_descPropEnchantmentGroupRuneIconImage;

		// Token: 0x04009316 RID: 37654
		[AutoBind("./Desc/PropGroup/EnchantmentGroup/Resonance/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropEnchantmentGroupRuneNameText;

		// Token: 0x04009317 RID: 37655
		[AutoBind("./Desc/PropGroup/EnchantmentGroup/Resonance", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_descPropEnchantmentGroupRuneStateCtrl;

		// Token: 0x04009318 RID: 37656
		[AutoBind("./Desc/PropertyComparison", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_PropertyComparisonGo;

		// Token: 0x04009319 RID: 37657
		[AutoBind("./Desc/PropertyComparison/PropGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_allDescPropGo;

		// Token: 0x0400931A RID: 37658
		[AutoBind("./Desc/PropertyComparison/PropGroup/Hp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_allDescHpGo;

		// Token: 0x0400931B RID: 37659
		[AutoBind("./Desc/PropertyComparison/PropGroup/Hp/FirstNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescHpOldText;

		// Token: 0x0400931C RID: 37660
		[AutoBind("./Desc/PropertyComparison/PropGroup/Hp/LastValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescHpNewText;

		// Token: 0x0400931D RID: 37661
		[AutoBind("./Desc/PropertyComparison/PropGroup/AT", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_allDescATGo;

		// Token: 0x0400931E RID: 37662
		[AutoBind("./Desc/PropertyComparison/PropGroup/AT/FirstNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescATOldText;

		// Token: 0x0400931F RID: 37663
		[AutoBind("./Desc/PropertyComparison/PropGroup/AT/LastValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescATNewText;

		// Token: 0x04009320 RID: 37664
		[AutoBind("./Desc/PropertyComparison/PropGroup/DF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_allDescDFGo;

		// Token: 0x04009321 RID: 37665
		[AutoBind("./Desc/PropertyComparison/PropGroup/DF/FirstNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescDFOldText;

		// Token: 0x04009322 RID: 37666
		[AutoBind("./Desc/PropertyComparison/PropGroup/DF/LastValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescDFNewText;

		// Token: 0x04009323 RID: 37667
		[AutoBind("./Desc/PropertyComparison/PropGroup/MagicDF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_allDescMagicDFGo;

		// Token: 0x04009324 RID: 37668
		[AutoBind("./Desc/PropertyComparison/PropGroup/MagicDF/FirstNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescMagicDFOldText;

		// Token: 0x04009325 RID: 37669
		[AutoBind("./Desc/PropertyComparison/PropGroup/MagicDF/LastValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescMagicDFNewText;

		// Token: 0x04009326 RID: 37670
		[AutoBind("./Desc/PropertyComparison/PropGroup/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_allDescMagicGo;

		// Token: 0x04009327 RID: 37671
		[AutoBind("./Desc/PropertyComparison/PropGroup/Magic/FirstNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescMagicOldText;

		// Token: 0x04009328 RID: 37672
		[AutoBind("./Desc/PropertyComparison/PropGroup/Magic/LastValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescMagicNewText;

		// Token: 0x04009329 RID: 37673
		[AutoBind("./Desc/PropertyComparison/PropGroup/Dex", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_allDescDexGo;

		// Token: 0x0400932A RID: 37674
		[AutoBind("./Desc/PropertyComparison/PropGroup/Dex/FirstNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescDexOldText;

		// Token: 0x0400932B RID: 37675
		[AutoBind("./Desc/PropertyComparison/PropGroup/Dex/LastValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_allDescDexNewText;

		// Token: 0x0400932C RID: 37676
		[AutoBind("./ConfirmPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_confirmPanelStateCtrl;

		// Token: 0x0400932D RID: 37677
		[AutoBind("./ConfirmPanel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_confirmPanelCancelButton;

		// Token: 0x0400932E RID: 37678
		[AutoBind("./ConfirmPanel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_confirmPanelConfirmButton;

		// Token: 0x0400932F RID: 37679
		private int m_isAscend = -1;

		// Token: 0x04009330 RID: 37680
		private EquipmentDepotUIController.EquipmentSortTypeState m_curEquipmentSortType;

		// Token: 0x04009331 RID: 37681
		private Hero m_hero;

		// Token: 0x04009332 RID: 37682
		private int m_slot;

		// Token: 0x04009333 RID: 37683
		private int m_canUseEquipmentCount;

		// Token: 0x04009334 RID: 37684
		private ulong m_curEquipmentInstanceId;

		// Token: 0x04009335 RID: 37685
		private bool m_isFirstIn = true;

		// Token: 0x04009336 RID: 37686
		private List<EquipmentBagItem> m_equipItemCache = new List<EquipmentBagItem>();

		// Token: 0x04009337 RID: 37687
		private List<EquipmentDepotListItemUIController> m_equipmentDepotCtrlList = new List<EquipmentDepotListItemUIController>();

		// Token: 0x04009338 RID: 37688
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009339 RID: 37689
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400933A RID: 37690
		[DoNotToLua]
		private EquipmentDepotUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400933B RID: 37691
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400933C RID: 37692
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400933D RID: 37693
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400933E RID: 37694
		private LuaFunction m_InitSortTypePanel_hotfix;

		// Token: 0x0400933F RID: 37695
		private LuaFunction m_InitLoopScrollRect_hotfix;

		// Token: 0x04009340 RID: 37696
		private LuaFunction m_UpdateEquipmentDepotViewHeroInt32UInt64_hotfix;

		// Token: 0x04009341 RID: 37697
		private LuaFunction m_CreateEquipmentList_hotfix;

		// Token: 0x04009342 RID: 37698
		private LuaFunction m_SortEquipmentListByTypeList;

		// Token: 0x04009343 RID: 37699
		private LuaFunction m_DefaultEquipmentItemComparerEquipmentBagItemEquipmentBagItem_hotfix;

		// Token: 0x04009344 RID: 37700
		private LuaFunction m_CollectEquipmentPropValueAndSortList;

		// Token: 0x04009345 RID: 37701
		private LuaFunction m_OnEquipmentListItemClickUIControllerBase_hotfix;

		// Token: 0x04009346 RID: 37702
		private LuaFunction m_OnEquipmentListItemNeedFillUIControllerBase_hotfix;

		// Token: 0x04009347 RID: 37703
		private LuaFunction m_OnFilterSortButtonClick_hotfix;

		// Token: 0x04009348 RID: 37704
		private LuaFunction m_OnCloseFilterSortTypeGo_hotfix;

		// Token: 0x04009349 RID: 37705
		private LuaFunction m_OnFilterSortOrderButtonClick_hotfix;

		// Token: 0x0400934A RID: 37706
		private LuaFunction m_OnFilterTypeButtonClickEquipmentSortItemUIControllerBoolean_hotfix;

		// Token: 0x0400934B RID: 37707
		private LuaFunction m_SetEquipmentItemDescEquipmentBagItem_hotfix;

		// Token: 0x0400934C RID: 37708
		private LuaFunction m_SetEquipmentComparisonEquipmentBagItem_hotfix;

		// Token: 0x0400934D RID: 37709
		private LuaFunction m_ResetEquipmentComparisonPropValue_hotfix;

		// Token: 0x0400934E RID: 37710
		private LuaFunction m_SetEquipmentComparisonPropPropertyModifyTypeInt32Boolean_hotfix;

		// Token: 0x0400934F RID: 37711
		private LuaFunction m_SetPropItemColorTextText_hotfix;

		// Token: 0x04009350 RID: 37712
		private LuaFunction m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix;

		// Token: 0x04009351 RID: 37713
		private LuaFunction m_OnDescEquipButtonClick_hotfix;

		// Token: 0x04009352 RID: 37714
		private LuaFunction m_OnConfirmPanelConfirmButtonClick_hotfix;

		// Token: 0x04009353 RID: 37715
		private LuaFunction m_OnConfirmPanelCancelButtonClick_hotfix;

		// Token: 0x04009354 RID: 37716
		private LuaFunction m_OnDescUnloadButtonClick_hotfix;

		// Token: 0x04009355 RID: 37717
		private LuaFunction m_OnDescLockButtonClick_hotfix;

		// Token: 0x04009356 RID: 37718
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04009357 RID: 37719
		private LuaFunction m_OnGoldAddButtonClick_hotfix;

		// Token: 0x04009358 RID: 37720
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x04009359 RID: 37721
		private LuaFunction m_GetFirstEquipmentGoInListForUserGuide_hotfix;

		// Token: 0x0400935A RID: 37722
		private LuaFunction m_ClickEquipmentListItemForUserGuideUIControllerBase_hotfix;

		// Token: 0x0400935B RID: 37723
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400935C RID: 37724
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400935D RID: 37725
		private LuaFunction m_add_EventOnGoldAddButtonClickAction_hotfix;

		// Token: 0x0400935E RID: 37726
		private LuaFunction m_remove_EventOnGoldAddButtonClickAction_hotfix;

		// Token: 0x0400935F RID: 37727
		private LuaFunction m_add_EventOnTakeOffEquipmentAction;

		// Token: 0x04009360 RID: 37728
		private LuaFunction m_remove_EventOnTakeOffEquipmentAction;

		// Token: 0x04009361 RID: 37729
		private LuaFunction m_add_EventOnLockButtonClickAction;

		// Token: 0x04009362 RID: 37730
		private LuaFunction m_remove_EventOnLockButtonClickAction;

		// Token: 0x04009363 RID: 37731
		private LuaFunction m_add_EventOnEquipButtonClickAction;

		// Token: 0x04009364 RID: 37732
		private LuaFunction m_remove_EventOnEquipButtonClickAction;

		// Token: 0x02000D52 RID: 3410
		public enum EquipmentSortTypeState
		{
			// Token: 0x04009366 RID: 37734
			Lv,
			// Token: 0x04009367 RID: 37735
			StarLv,
			// Token: 0x04009368 RID: 37736
			Rank,
			// Token: 0x04009369 RID: 37737
			Hp,
			// Token: 0x0400936A RID: 37738
			AT,
			// Token: 0x0400936B RID: 37739
			DF,
			// Token: 0x0400936C RID: 37740
			MagicAT,
			// Token: 0x0400936D RID: 37741
			MagicDF,
			// Token: 0x0400936E RID: 37742
			Dex
		}

		// Token: 0x02000D53 RID: 3411
		public new class LuaExportHelper
		{
			// Token: 0x0600FA6E RID: 64110 RVA: 0x00420964 File Offset: 0x0041EB64
			public LuaExportHelper(EquipmentDepotUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600FA6F RID: 64111 RVA: 0x00420974 File Offset: 0x0041EB74
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600FA70 RID: 64112 RVA: 0x00420984 File Offset: 0x0041EB84
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600FA71 RID: 64113 RVA: 0x00420994 File Offset: 0x0041EB94
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600FA72 RID: 64114 RVA: 0x004209A4 File Offset: 0x0041EBA4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600FA73 RID: 64115 RVA: 0x004209BC File Offset: 0x0041EBBC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600FA74 RID: 64116 RVA: 0x004209CC File Offset: 0x0041EBCC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600FA75 RID: 64117 RVA: 0x004209DC File Offset: 0x0041EBDC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600FA76 RID: 64118 RVA: 0x004209EC File Offset: 0x0041EBEC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600FA77 RID: 64119 RVA: 0x004209FC File Offset: 0x0041EBFC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600FA78 RID: 64120 RVA: 0x00420A0C File Offset: 0x0041EC0C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600FA79 RID: 64121 RVA: 0x00420A1C File Offset: 0x0041EC1C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600FA7A RID: 64122 RVA: 0x00420A2C File Offset: 0x0041EC2C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600FA7B RID: 64123 RVA: 0x00420A3C File Offset: 0x0041EC3C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600FA7C RID: 64124 RVA: 0x00420A4C File Offset: 0x0041EC4C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600FA7D RID: 64125 RVA: 0x00420A5C File Offset: 0x0041EC5C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600FA7E RID: 64126 RVA: 0x00420A6C File Offset: 0x0041EC6C
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600FA7F RID: 64127 RVA: 0x00420A7C File Offset: 0x0041EC7C
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600FA80 RID: 64128 RVA: 0x00420A8C File Offset: 0x0041EC8C
			public void __callDele_EventOnGoldAddButtonClick()
			{
				this.m_owner.__callDele_EventOnGoldAddButtonClick();
			}

			// Token: 0x0600FA81 RID: 64129 RVA: 0x00420A9C File Offset: 0x0041EC9C
			public void __clearDele_EventOnGoldAddButtonClick()
			{
				this.m_owner.__clearDele_EventOnGoldAddButtonClick();
			}

			// Token: 0x0600FA82 RID: 64130 RVA: 0x00420AAC File Offset: 0x0041ECAC
			public void __callDele_EventOnTakeOffEquipment(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__callDele_EventOnTakeOffEquipment(arg1, arg2, arg3);
			}

			// Token: 0x0600FA83 RID: 64131 RVA: 0x00420ABC File Offset: 0x0041ECBC
			public void __clearDele_EventOnTakeOffEquipment(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__clearDele_EventOnTakeOffEquipment(arg1, arg2, arg3);
			}

			// Token: 0x0600FA84 RID: 64132 RVA: 0x00420ACC File Offset: 0x0041ECCC
			public void __callDele_EventOnLockButtonClick(ulong arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnLockButtonClick(arg1, arg2);
			}

			// Token: 0x0600FA85 RID: 64133 RVA: 0x00420ADC File Offset: 0x0041ECDC
			public void __clearDele_EventOnLockButtonClick(ulong arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnLockButtonClick(arg1, arg2);
			}

			// Token: 0x0600FA86 RID: 64134 RVA: 0x00420AEC File Offset: 0x0041ECEC
			public void __callDele_EventOnEquipButtonClick(int arg1, ulong arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnEquipButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x0600FA87 RID: 64135 RVA: 0x00420AFC File Offset: 0x0041ECFC
			public void __clearDele_EventOnEquipButtonClick(int arg1, ulong arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnEquipButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x17002FAE RID: 12206
			// (get) Token: 0x0600FA88 RID: 64136 RVA: 0x00420B0C File Offset: 0x0041ED0C
			// (set) Token: 0x0600FA89 RID: 64137 RVA: 0x00420B1C File Offset: 0x0041ED1C
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

			// Token: 0x17002FAF RID: 12207
			// (get) Token: 0x0600FA8A RID: 64138 RVA: 0x00420B2C File Offset: 0x0041ED2C
			// (set) Token: 0x0600FA8B RID: 64139 RVA: 0x00420B3C File Offset: 0x0041ED3C
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

			// Token: 0x17002FB0 RID: 12208
			// (get) Token: 0x0600FA8C RID: 64140 RVA: 0x00420B4C File Offset: 0x0041ED4C
			// (set) Token: 0x0600FA8D RID: 64141 RVA: 0x00420B5C File Offset: 0x0041ED5C
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

			// Token: 0x17002FB1 RID: 12209
			// (get) Token: 0x0600FA8E RID: 64142 RVA: 0x00420B6C File Offset: 0x0041ED6C
			// (set) Token: 0x0600FA8F RID: 64143 RVA: 0x00420B7C File Offset: 0x0041ED7C
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

			// Token: 0x17002FB2 RID: 12210
			// (get) Token: 0x0600FA90 RID: 64144 RVA: 0x00420B8C File Offset: 0x0041ED8C
			// (set) Token: 0x0600FA91 RID: 64145 RVA: 0x00420B9C File Offset: 0x0041ED9C
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

			// Token: 0x17002FB3 RID: 12211
			// (get) Token: 0x0600FA92 RID: 64146 RVA: 0x00420BAC File Offset: 0x0041EDAC
			// (set) Token: 0x0600FA93 RID: 64147 RVA: 0x00420BBC File Offset: 0x0041EDBC
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

			// Token: 0x17002FB4 RID: 12212
			// (get) Token: 0x0600FA94 RID: 64148 RVA: 0x00420BCC File Offset: 0x0041EDCC
			// (set) Token: 0x0600FA95 RID: 64149 RVA: 0x00420BDC File Offset: 0x0041EDDC
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

			// Token: 0x17002FB5 RID: 12213
			// (get) Token: 0x0600FA96 RID: 64150 RVA: 0x00420BEC File Offset: 0x0041EDEC
			// (set) Token: 0x0600FA97 RID: 64151 RVA: 0x00420BFC File Offset: 0x0041EDFC
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

			// Token: 0x17002FB6 RID: 12214
			// (get) Token: 0x0600FA98 RID: 64152 RVA: 0x00420C0C File Offset: 0x0041EE0C
			// (set) Token: 0x0600FA99 RID: 64153 RVA: 0x00420C1C File Offset: 0x0041EE1C
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

			// Token: 0x17002FB7 RID: 12215
			// (get) Token: 0x0600FA9A RID: 64154 RVA: 0x00420C2C File Offset: 0x0041EE2C
			// (set) Token: 0x0600FA9B RID: 64155 RVA: 0x00420C3C File Offset: 0x0041EE3C
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

			// Token: 0x17002FB8 RID: 12216
			// (get) Token: 0x0600FA9C RID: 64156 RVA: 0x00420C4C File Offset: 0x0041EE4C
			// (set) Token: 0x0600FA9D RID: 64157 RVA: 0x00420C5C File Offset: 0x0041EE5C
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

			// Token: 0x17002FB9 RID: 12217
			// (get) Token: 0x0600FA9E RID: 64158 RVA: 0x00420C6C File Offset: 0x0041EE6C
			// (set) Token: 0x0600FA9F RID: 64159 RVA: 0x00420C7C File Offset: 0x0041EE7C
			public GameObject m_listNotItemGo
			{
				get
				{
					return this.m_owner.m_listNotItemGo;
				}
				set
				{
					this.m_owner.m_listNotItemGo = value;
				}
			}

			// Token: 0x17002FBA RID: 12218
			// (get) Token: 0x0600FAA0 RID: 64160 RVA: 0x00420C8C File Offset: 0x0041EE8C
			// (set) Token: 0x0600FAA1 RID: 64161 RVA: 0x00420C9C File Offset: 0x0041EE9C
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

			// Token: 0x17002FBB RID: 12219
			// (get) Token: 0x0600FAA2 RID: 64162 RVA: 0x00420CAC File Offset: 0x0041EEAC
			// (set) Token: 0x0600FAA3 RID: 64163 RVA: 0x00420CBC File Offset: 0x0041EEBC
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

			// Token: 0x17002FBC RID: 12220
			// (get) Token: 0x0600FAA4 RID: 64164 RVA: 0x00420CCC File Offset: 0x0041EECC
			// (set) Token: 0x0600FAA5 RID: 64165 RVA: 0x00420CDC File Offset: 0x0041EEDC
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

			// Token: 0x17002FBD RID: 12221
			// (get) Token: 0x0600FAA6 RID: 64166 RVA: 0x00420CEC File Offset: 0x0041EEEC
			// (set) Token: 0x0600FAA7 RID: 64167 RVA: 0x00420CFC File Offset: 0x0041EEFC
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

			// Token: 0x17002FBE RID: 12222
			// (get) Token: 0x0600FAA8 RID: 64168 RVA: 0x00420D0C File Offset: 0x0041EF0C
			// (set) Token: 0x0600FAA9 RID: 64169 RVA: 0x00420D1C File Offset: 0x0041EF1C
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

			// Token: 0x17002FBF RID: 12223
			// (get) Token: 0x0600FAAA RID: 64170 RVA: 0x00420D2C File Offset: 0x0041EF2C
			// (set) Token: 0x0600FAAB RID: 64171 RVA: 0x00420D3C File Offset: 0x0041EF3C
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

			// Token: 0x17002FC0 RID: 12224
			// (get) Token: 0x0600FAAC RID: 64172 RVA: 0x00420D4C File Offset: 0x0041EF4C
			// (set) Token: 0x0600FAAD RID: 64173 RVA: 0x00420D5C File Offset: 0x0041EF5C
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

			// Token: 0x17002FC1 RID: 12225
			// (get) Token: 0x0600FAAE RID: 64174 RVA: 0x00420D6C File Offset: 0x0041EF6C
			// (set) Token: 0x0600FAAF RID: 64175 RVA: 0x00420D7C File Offset: 0x0041EF7C
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

			// Token: 0x17002FC2 RID: 12226
			// (get) Token: 0x0600FAB0 RID: 64176 RVA: 0x00420D8C File Offset: 0x0041EF8C
			// (set) Token: 0x0600FAB1 RID: 64177 RVA: 0x00420D9C File Offset: 0x0041EF9C
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

			// Token: 0x17002FC3 RID: 12227
			// (get) Token: 0x0600FAB2 RID: 64178 RVA: 0x00420DAC File Offset: 0x0041EFAC
			// (set) Token: 0x0600FAB3 RID: 64179 RVA: 0x00420DBC File Offset: 0x0041EFBC
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

			// Token: 0x17002FC4 RID: 12228
			// (get) Token: 0x0600FAB4 RID: 64180 RVA: 0x00420DCC File Offset: 0x0041EFCC
			// (set) Token: 0x0600FAB5 RID: 64181 RVA: 0x00420DDC File Offset: 0x0041EFDC
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

			// Token: 0x17002FC5 RID: 12229
			// (get) Token: 0x0600FAB6 RID: 64182 RVA: 0x00420DEC File Offset: 0x0041EFEC
			// (set) Token: 0x0600FAB7 RID: 64183 RVA: 0x00420DFC File Offset: 0x0041EFFC
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

			// Token: 0x17002FC6 RID: 12230
			// (get) Token: 0x0600FAB8 RID: 64184 RVA: 0x00420E0C File Offset: 0x0041F00C
			// (set) Token: 0x0600FAB9 RID: 64185 RVA: 0x00420E1C File Offset: 0x0041F01C
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

			// Token: 0x17002FC7 RID: 12231
			// (get) Token: 0x0600FABA RID: 64186 RVA: 0x00420E2C File Offset: 0x0041F02C
			// (set) Token: 0x0600FABB RID: 64187 RVA: 0x00420E3C File Offset: 0x0041F03C
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

			// Token: 0x17002FC8 RID: 12232
			// (get) Token: 0x0600FABC RID: 64188 RVA: 0x00420E4C File Offset: 0x0041F04C
			// (set) Token: 0x0600FABD RID: 64189 RVA: 0x00420E5C File Offset: 0x0041F05C
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

			// Token: 0x17002FC9 RID: 12233
			// (get) Token: 0x0600FABE RID: 64190 RVA: 0x00420E6C File Offset: 0x0041F06C
			// (set) Token: 0x0600FABF RID: 64191 RVA: 0x00420E7C File Offset: 0x0041F07C
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

			// Token: 0x17002FCA RID: 12234
			// (get) Token: 0x0600FAC0 RID: 64192 RVA: 0x00420E8C File Offset: 0x0041F08C
			// (set) Token: 0x0600FAC1 RID: 64193 RVA: 0x00420E9C File Offset: 0x0041F09C
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

			// Token: 0x17002FCB RID: 12235
			// (get) Token: 0x0600FAC2 RID: 64194 RVA: 0x00420EAC File Offset: 0x0041F0AC
			// (set) Token: 0x0600FAC3 RID: 64195 RVA: 0x00420EBC File Offset: 0x0041F0BC
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

			// Token: 0x17002FCC RID: 12236
			// (get) Token: 0x0600FAC4 RID: 64196 RVA: 0x00420ECC File Offset: 0x0041F0CC
			// (set) Token: 0x0600FAC5 RID: 64197 RVA: 0x00420EDC File Offset: 0x0041F0DC
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

			// Token: 0x17002FCD RID: 12237
			// (get) Token: 0x0600FAC6 RID: 64198 RVA: 0x00420EEC File Offset: 0x0041F0EC
			// (set) Token: 0x0600FAC7 RID: 64199 RVA: 0x00420EFC File Offset: 0x0041F0FC
			public Button m_descLockButton
			{
				get
				{
					return this.m_owner.m_descLockButton;
				}
				set
				{
					this.m_owner.m_descLockButton = value;
				}
			}

			// Token: 0x17002FCE RID: 12238
			// (get) Token: 0x0600FAC8 RID: 64200 RVA: 0x00420F0C File Offset: 0x0041F10C
			// (set) Token: 0x0600FAC9 RID: 64201 RVA: 0x00420F1C File Offset: 0x0041F11C
			public Button m_descEquipButton
			{
				get
				{
					return this.m_owner.m_descEquipButton;
				}
				set
				{
					this.m_owner.m_descEquipButton = value;
				}
			}

			// Token: 0x17002FCF RID: 12239
			// (get) Token: 0x0600FACA RID: 64202 RVA: 0x00420F2C File Offset: 0x0041F12C
			// (set) Token: 0x0600FACB RID: 64203 RVA: 0x00420F3C File Offset: 0x0041F13C
			public Button m_descUnloadButton
			{
				get
				{
					return this.m_owner.m_descUnloadButton;
				}
				set
				{
					this.m_owner.m_descUnloadButton = value;
				}
			}

			// Token: 0x17002FD0 RID: 12240
			// (get) Token: 0x0600FACC RID: 64204 RVA: 0x00420F4C File Offset: 0x0041F14C
			// (set) Token: 0x0600FACD RID: 64205 RVA: 0x00420F5C File Offset: 0x0041F15C
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

			// Token: 0x17002FD1 RID: 12241
			// (get) Token: 0x0600FACE RID: 64206 RVA: 0x00420F6C File Offset: 0x0041F16C
			// (set) Token: 0x0600FACF RID: 64207 RVA: 0x00420F7C File Offset: 0x0041F17C
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

			// Token: 0x17002FD2 RID: 12242
			// (get) Token: 0x0600FAD0 RID: 64208 RVA: 0x00420F8C File Offset: 0x0041F18C
			// (set) Token: 0x0600FAD1 RID: 64209 RVA: 0x00420F9C File Offset: 0x0041F19C
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

			// Token: 0x17002FD3 RID: 12243
			// (get) Token: 0x0600FAD2 RID: 64210 RVA: 0x00420FAC File Offset: 0x0041F1AC
			// (set) Token: 0x0600FAD3 RID: 64211 RVA: 0x00420FBC File Offset: 0x0041F1BC
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

			// Token: 0x17002FD4 RID: 12244
			// (get) Token: 0x0600FAD4 RID: 64212 RVA: 0x00420FCC File Offset: 0x0041F1CC
			// (set) Token: 0x0600FAD5 RID: 64213 RVA: 0x00420FDC File Offset: 0x0041F1DC
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

			// Token: 0x17002FD5 RID: 12245
			// (get) Token: 0x0600FAD6 RID: 64214 RVA: 0x00420FEC File Offset: 0x0041F1EC
			// (set) Token: 0x0600FAD7 RID: 64215 RVA: 0x00420FFC File Offset: 0x0041F1FC
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

			// Token: 0x17002FD6 RID: 12246
			// (get) Token: 0x0600FAD8 RID: 64216 RVA: 0x0042100C File Offset: 0x0041F20C
			// (set) Token: 0x0600FAD9 RID: 64217 RVA: 0x0042101C File Offset: 0x0041F21C
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

			// Token: 0x17002FD7 RID: 12247
			// (get) Token: 0x0600FADA RID: 64218 RVA: 0x0042102C File Offset: 0x0041F22C
			// (set) Token: 0x0600FADB RID: 64219 RVA: 0x0042103C File Offset: 0x0041F23C
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

			// Token: 0x17002FD8 RID: 12248
			// (get) Token: 0x0600FADC RID: 64220 RVA: 0x0042104C File Offset: 0x0041F24C
			// (set) Token: 0x0600FADD RID: 64221 RVA: 0x0042105C File Offset: 0x0041F25C
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

			// Token: 0x17002FD9 RID: 12249
			// (get) Token: 0x0600FADE RID: 64222 RVA: 0x0042106C File Offset: 0x0041F26C
			// (set) Token: 0x0600FADF RID: 64223 RVA: 0x0042107C File Offset: 0x0041F27C
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

			// Token: 0x17002FDA RID: 12250
			// (get) Token: 0x0600FAE0 RID: 64224 RVA: 0x0042108C File Offset: 0x0041F28C
			// (set) Token: 0x0600FAE1 RID: 64225 RVA: 0x0042109C File Offset: 0x0041F29C
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

			// Token: 0x17002FDB RID: 12251
			// (get) Token: 0x0600FAE2 RID: 64226 RVA: 0x004210AC File Offset: 0x0041F2AC
			// (set) Token: 0x0600FAE3 RID: 64227 RVA: 0x004210BC File Offset: 0x0041F2BC
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

			// Token: 0x17002FDC RID: 12252
			// (get) Token: 0x0600FAE4 RID: 64228 RVA: 0x004210CC File Offset: 0x0041F2CC
			// (set) Token: 0x0600FAE5 RID: 64229 RVA: 0x004210DC File Offset: 0x0041F2DC
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

			// Token: 0x17002FDD RID: 12253
			// (get) Token: 0x0600FAE6 RID: 64230 RVA: 0x004210EC File Offset: 0x0041F2EC
			// (set) Token: 0x0600FAE7 RID: 64231 RVA: 0x004210FC File Offset: 0x0041F2FC
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

			// Token: 0x17002FDE RID: 12254
			// (get) Token: 0x0600FAE8 RID: 64232 RVA: 0x0042110C File Offset: 0x0041F30C
			// (set) Token: 0x0600FAE9 RID: 64233 RVA: 0x0042111C File Offset: 0x0041F31C
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

			// Token: 0x17002FDF RID: 12255
			// (get) Token: 0x0600FAEA RID: 64234 RVA: 0x0042112C File Offset: 0x0041F32C
			// (set) Token: 0x0600FAEB RID: 64235 RVA: 0x0042113C File Offset: 0x0041F33C
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

			// Token: 0x17002FE0 RID: 12256
			// (get) Token: 0x0600FAEC RID: 64236 RVA: 0x0042114C File Offset: 0x0041F34C
			// (set) Token: 0x0600FAED RID: 64237 RVA: 0x0042115C File Offset: 0x0041F35C
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

			// Token: 0x17002FE1 RID: 12257
			// (get) Token: 0x0600FAEE RID: 64238 RVA: 0x0042116C File Offset: 0x0041F36C
			// (set) Token: 0x0600FAEF RID: 64239 RVA: 0x0042117C File Offset: 0x0041F37C
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

			// Token: 0x17002FE2 RID: 12258
			// (get) Token: 0x0600FAF0 RID: 64240 RVA: 0x0042118C File Offset: 0x0041F38C
			// (set) Token: 0x0600FAF1 RID: 64241 RVA: 0x0042119C File Offset: 0x0041F39C
			public GameObject m_PropertyComparisonGo
			{
				get
				{
					return this.m_owner.m_PropertyComparisonGo;
				}
				set
				{
					this.m_owner.m_PropertyComparisonGo = value;
				}
			}

			// Token: 0x17002FE3 RID: 12259
			// (get) Token: 0x0600FAF2 RID: 64242 RVA: 0x004211AC File Offset: 0x0041F3AC
			// (set) Token: 0x0600FAF3 RID: 64243 RVA: 0x004211BC File Offset: 0x0041F3BC
			public GameObject m_allDescPropGo
			{
				get
				{
					return this.m_owner.m_allDescPropGo;
				}
				set
				{
					this.m_owner.m_allDescPropGo = value;
				}
			}

			// Token: 0x17002FE4 RID: 12260
			// (get) Token: 0x0600FAF4 RID: 64244 RVA: 0x004211CC File Offset: 0x0041F3CC
			// (set) Token: 0x0600FAF5 RID: 64245 RVA: 0x004211DC File Offset: 0x0041F3DC
			public GameObject m_allDescHpGo
			{
				get
				{
					return this.m_owner.m_allDescHpGo;
				}
				set
				{
					this.m_owner.m_allDescHpGo = value;
				}
			}

			// Token: 0x17002FE5 RID: 12261
			// (get) Token: 0x0600FAF6 RID: 64246 RVA: 0x004211EC File Offset: 0x0041F3EC
			// (set) Token: 0x0600FAF7 RID: 64247 RVA: 0x004211FC File Offset: 0x0041F3FC
			public Text m_allDescHpOldText
			{
				get
				{
					return this.m_owner.m_allDescHpOldText;
				}
				set
				{
					this.m_owner.m_allDescHpOldText = value;
				}
			}

			// Token: 0x17002FE6 RID: 12262
			// (get) Token: 0x0600FAF8 RID: 64248 RVA: 0x0042120C File Offset: 0x0041F40C
			// (set) Token: 0x0600FAF9 RID: 64249 RVA: 0x0042121C File Offset: 0x0041F41C
			public Text m_allDescHpNewText
			{
				get
				{
					return this.m_owner.m_allDescHpNewText;
				}
				set
				{
					this.m_owner.m_allDescHpNewText = value;
				}
			}

			// Token: 0x17002FE7 RID: 12263
			// (get) Token: 0x0600FAFA RID: 64250 RVA: 0x0042122C File Offset: 0x0041F42C
			// (set) Token: 0x0600FAFB RID: 64251 RVA: 0x0042123C File Offset: 0x0041F43C
			public GameObject m_allDescATGo
			{
				get
				{
					return this.m_owner.m_allDescATGo;
				}
				set
				{
					this.m_owner.m_allDescATGo = value;
				}
			}

			// Token: 0x17002FE8 RID: 12264
			// (get) Token: 0x0600FAFC RID: 64252 RVA: 0x0042124C File Offset: 0x0041F44C
			// (set) Token: 0x0600FAFD RID: 64253 RVA: 0x0042125C File Offset: 0x0041F45C
			public Text m_allDescATOldText
			{
				get
				{
					return this.m_owner.m_allDescATOldText;
				}
				set
				{
					this.m_owner.m_allDescATOldText = value;
				}
			}

			// Token: 0x17002FE9 RID: 12265
			// (get) Token: 0x0600FAFE RID: 64254 RVA: 0x0042126C File Offset: 0x0041F46C
			// (set) Token: 0x0600FAFF RID: 64255 RVA: 0x0042127C File Offset: 0x0041F47C
			public Text m_allDescATNewText
			{
				get
				{
					return this.m_owner.m_allDescATNewText;
				}
				set
				{
					this.m_owner.m_allDescATNewText = value;
				}
			}

			// Token: 0x17002FEA RID: 12266
			// (get) Token: 0x0600FB00 RID: 64256 RVA: 0x0042128C File Offset: 0x0041F48C
			// (set) Token: 0x0600FB01 RID: 64257 RVA: 0x0042129C File Offset: 0x0041F49C
			public GameObject m_allDescDFGo
			{
				get
				{
					return this.m_owner.m_allDescDFGo;
				}
				set
				{
					this.m_owner.m_allDescDFGo = value;
				}
			}

			// Token: 0x17002FEB RID: 12267
			// (get) Token: 0x0600FB02 RID: 64258 RVA: 0x004212AC File Offset: 0x0041F4AC
			// (set) Token: 0x0600FB03 RID: 64259 RVA: 0x004212BC File Offset: 0x0041F4BC
			public Text m_allDescDFOldText
			{
				get
				{
					return this.m_owner.m_allDescDFOldText;
				}
				set
				{
					this.m_owner.m_allDescDFOldText = value;
				}
			}

			// Token: 0x17002FEC RID: 12268
			// (get) Token: 0x0600FB04 RID: 64260 RVA: 0x004212CC File Offset: 0x0041F4CC
			// (set) Token: 0x0600FB05 RID: 64261 RVA: 0x004212DC File Offset: 0x0041F4DC
			public Text m_allDescDFNewText
			{
				get
				{
					return this.m_owner.m_allDescDFNewText;
				}
				set
				{
					this.m_owner.m_allDescDFNewText = value;
				}
			}

			// Token: 0x17002FED RID: 12269
			// (get) Token: 0x0600FB06 RID: 64262 RVA: 0x004212EC File Offset: 0x0041F4EC
			// (set) Token: 0x0600FB07 RID: 64263 RVA: 0x004212FC File Offset: 0x0041F4FC
			public GameObject m_allDescMagicDFGo
			{
				get
				{
					return this.m_owner.m_allDescMagicDFGo;
				}
				set
				{
					this.m_owner.m_allDescMagicDFGo = value;
				}
			}

			// Token: 0x17002FEE RID: 12270
			// (get) Token: 0x0600FB08 RID: 64264 RVA: 0x0042130C File Offset: 0x0041F50C
			// (set) Token: 0x0600FB09 RID: 64265 RVA: 0x0042131C File Offset: 0x0041F51C
			public Text m_allDescMagicDFOldText
			{
				get
				{
					return this.m_owner.m_allDescMagicDFOldText;
				}
				set
				{
					this.m_owner.m_allDescMagicDFOldText = value;
				}
			}

			// Token: 0x17002FEF RID: 12271
			// (get) Token: 0x0600FB0A RID: 64266 RVA: 0x0042132C File Offset: 0x0041F52C
			// (set) Token: 0x0600FB0B RID: 64267 RVA: 0x0042133C File Offset: 0x0041F53C
			public Text m_allDescMagicDFNewText
			{
				get
				{
					return this.m_owner.m_allDescMagicDFNewText;
				}
				set
				{
					this.m_owner.m_allDescMagicDFNewText = value;
				}
			}

			// Token: 0x17002FF0 RID: 12272
			// (get) Token: 0x0600FB0C RID: 64268 RVA: 0x0042134C File Offset: 0x0041F54C
			// (set) Token: 0x0600FB0D RID: 64269 RVA: 0x0042135C File Offset: 0x0041F55C
			public GameObject m_allDescMagicGo
			{
				get
				{
					return this.m_owner.m_allDescMagicGo;
				}
				set
				{
					this.m_owner.m_allDescMagicGo = value;
				}
			}

			// Token: 0x17002FF1 RID: 12273
			// (get) Token: 0x0600FB0E RID: 64270 RVA: 0x0042136C File Offset: 0x0041F56C
			// (set) Token: 0x0600FB0F RID: 64271 RVA: 0x0042137C File Offset: 0x0041F57C
			public Text m_allDescMagicOldText
			{
				get
				{
					return this.m_owner.m_allDescMagicOldText;
				}
				set
				{
					this.m_owner.m_allDescMagicOldText = value;
				}
			}

			// Token: 0x17002FF2 RID: 12274
			// (get) Token: 0x0600FB10 RID: 64272 RVA: 0x0042138C File Offset: 0x0041F58C
			// (set) Token: 0x0600FB11 RID: 64273 RVA: 0x0042139C File Offset: 0x0041F59C
			public Text m_allDescMagicNewText
			{
				get
				{
					return this.m_owner.m_allDescMagicNewText;
				}
				set
				{
					this.m_owner.m_allDescMagicNewText = value;
				}
			}

			// Token: 0x17002FF3 RID: 12275
			// (get) Token: 0x0600FB12 RID: 64274 RVA: 0x004213AC File Offset: 0x0041F5AC
			// (set) Token: 0x0600FB13 RID: 64275 RVA: 0x004213BC File Offset: 0x0041F5BC
			public GameObject m_allDescDexGo
			{
				get
				{
					return this.m_owner.m_allDescDexGo;
				}
				set
				{
					this.m_owner.m_allDescDexGo = value;
				}
			}

			// Token: 0x17002FF4 RID: 12276
			// (get) Token: 0x0600FB14 RID: 64276 RVA: 0x004213CC File Offset: 0x0041F5CC
			// (set) Token: 0x0600FB15 RID: 64277 RVA: 0x004213DC File Offset: 0x0041F5DC
			public Text m_allDescDexOldText
			{
				get
				{
					return this.m_owner.m_allDescDexOldText;
				}
				set
				{
					this.m_owner.m_allDescDexOldText = value;
				}
			}

			// Token: 0x17002FF5 RID: 12277
			// (get) Token: 0x0600FB16 RID: 64278 RVA: 0x004213EC File Offset: 0x0041F5EC
			// (set) Token: 0x0600FB17 RID: 64279 RVA: 0x004213FC File Offset: 0x0041F5FC
			public Text m_allDescDexNewText
			{
				get
				{
					return this.m_owner.m_allDescDexNewText;
				}
				set
				{
					this.m_owner.m_allDescDexNewText = value;
				}
			}

			// Token: 0x17002FF6 RID: 12278
			// (get) Token: 0x0600FB18 RID: 64280 RVA: 0x0042140C File Offset: 0x0041F60C
			// (set) Token: 0x0600FB19 RID: 64281 RVA: 0x0042141C File Offset: 0x0041F61C
			public CommonUIStateController m_confirmPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_confirmPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_confirmPanelStateCtrl = value;
				}
			}

			// Token: 0x17002FF7 RID: 12279
			// (get) Token: 0x0600FB1A RID: 64282 RVA: 0x0042142C File Offset: 0x0041F62C
			// (set) Token: 0x0600FB1B RID: 64283 RVA: 0x0042143C File Offset: 0x0041F63C
			public Button m_confirmPanelCancelButton
			{
				get
				{
					return this.m_owner.m_confirmPanelCancelButton;
				}
				set
				{
					this.m_owner.m_confirmPanelCancelButton = value;
				}
			}

			// Token: 0x17002FF8 RID: 12280
			// (get) Token: 0x0600FB1C RID: 64284 RVA: 0x0042144C File Offset: 0x0041F64C
			// (set) Token: 0x0600FB1D RID: 64285 RVA: 0x0042145C File Offset: 0x0041F65C
			public Button m_confirmPanelConfirmButton
			{
				get
				{
					return this.m_owner.m_confirmPanelConfirmButton;
				}
				set
				{
					this.m_owner.m_confirmPanelConfirmButton = value;
				}
			}

			// Token: 0x17002FF9 RID: 12281
			// (get) Token: 0x0600FB1E RID: 64286 RVA: 0x0042146C File Offset: 0x0041F66C
			// (set) Token: 0x0600FB1F RID: 64287 RVA: 0x0042147C File Offset: 0x0041F67C
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

			// Token: 0x17002FFA RID: 12282
			// (get) Token: 0x0600FB20 RID: 64288 RVA: 0x0042148C File Offset: 0x0041F68C
			// (set) Token: 0x0600FB21 RID: 64289 RVA: 0x0042149C File Offset: 0x0041F69C
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

			// Token: 0x17002FFB RID: 12283
			// (get) Token: 0x0600FB22 RID: 64290 RVA: 0x004214AC File Offset: 0x0041F6AC
			// (set) Token: 0x0600FB23 RID: 64291 RVA: 0x004214BC File Offset: 0x0041F6BC
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

			// Token: 0x17002FFC RID: 12284
			// (get) Token: 0x0600FB24 RID: 64292 RVA: 0x004214CC File Offset: 0x0041F6CC
			// (set) Token: 0x0600FB25 RID: 64293 RVA: 0x004214DC File Offset: 0x0041F6DC
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

			// Token: 0x17002FFD RID: 12285
			// (get) Token: 0x0600FB26 RID: 64294 RVA: 0x004214EC File Offset: 0x0041F6EC
			// (set) Token: 0x0600FB27 RID: 64295 RVA: 0x004214FC File Offset: 0x0041F6FC
			public int m_canUseEquipmentCount
			{
				get
				{
					return this.m_owner.m_canUseEquipmentCount;
				}
				set
				{
					this.m_owner.m_canUseEquipmentCount = value;
				}
			}

			// Token: 0x17002FFE RID: 12286
			// (get) Token: 0x0600FB28 RID: 64296 RVA: 0x0042150C File Offset: 0x0041F70C
			// (set) Token: 0x0600FB29 RID: 64297 RVA: 0x0042151C File Offset: 0x0041F71C
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

			// Token: 0x17002FFF RID: 12287
			// (get) Token: 0x0600FB2A RID: 64298 RVA: 0x0042152C File Offset: 0x0041F72C
			// (set) Token: 0x0600FB2B RID: 64299 RVA: 0x0042153C File Offset: 0x0041F73C
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

			// Token: 0x17003000 RID: 12288
			// (get) Token: 0x0600FB2C RID: 64300 RVA: 0x0042154C File Offset: 0x0041F74C
			// (set) Token: 0x0600FB2D RID: 64301 RVA: 0x0042155C File Offset: 0x0041F75C
			public List<EquipmentBagItem> m_equipItemCache
			{
				get
				{
					return this.m_owner.m_equipItemCache;
				}
				set
				{
					this.m_owner.m_equipItemCache = value;
				}
			}

			// Token: 0x17003001 RID: 12289
			// (get) Token: 0x0600FB2E RID: 64302 RVA: 0x0042156C File Offset: 0x0041F76C
			// (set) Token: 0x0600FB2F RID: 64303 RVA: 0x0042157C File Offset: 0x0041F77C
			public List<EquipmentDepotListItemUIController> m_equipmentDepotCtrlList
			{
				get
				{
					return this.m_owner.m_equipmentDepotCtrlList;
				}
				set
				{
					this.m_owner.m_equipmentDepotCtrlList = value;
				}
			}

			// Token: 0x17003002 RID: 12290
			// (get) Token: 0x0600FB30 RID: 64304 RVA: 0x0042158C File Offset: 0x0041F78C
			// (set) Token: 0x0600FB31 RID: 64305 RVA: 0x0042159C File Offset: 0x0041F79C
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

			// Token: 0x17003003 RID: 12291
			// (get) Token: 0x0600FB32 RID: 64306 RVA: 0x004215AC File Offset: 0x0041F7AC
			// (set) Token: 0x0600FB33 RID: 64307 RVA: 0x004215BC File Offset: 0x0041F7BC
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

			// Token: 0x0600FB34 RID: 64308 RVA: 0x004215CC File Offset: 0x0041F7CC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600FB35 RID: 64309 RVA: 0x004215DC File Offset: 0x0041F7DC
			public void InitSortTypePanel()
			{
				this.m_owner.InitSortTypePanel();
			}

			// Token: 0x0600FB36 RID: 64310 RVA: 0x004215EC File Offset: 0x0041F7EC
			public void InitLoopScrollRect()
			{
				this.m_owner.InitLoopScrollRect();
			}

			// Token: 0x0600FB37 RID: 64311 RVA: 0x004215FC File Offset: 0x0041F7FC
			public void CreateEquipmentList()
			{
				this.m_owner.CreateEquipmentList();
			}

			// Token: 0x0600FB38 RID: 64312 RVA: 0x0042160C File Offset: 0x0041F80C
			public void SortEquipmentListByType(List<EquipmentBagItem> list)
			{
				this.m_owner.SortEquipmentListByType(list);
			}

			// Token: 0x0600FB39 RID: 64313 RVA: 0x0042161C File Offset: 0x0041F81C
			public int DefaultEquipmentItemComparer(EquipmentBagItem e1, EquipmentBagItem e2)
			{
				return this.m_owner.DefaultEquipmentItemComparer(e1, e2);
			}

			// Token: 0x0600FB3A RID: 64314 RVA: 0x0042162C File Offset: 0x0041F82C
			public void CollectEquipmentPropValueAndSort(List<EquipmentBagItem> list, PropertyModifyType type)
			{
				this.m_owner.CollectEquipmentPropValueAndSort(list, type);
			}

			// Token: 0x0600FB3B RID: 64315 RVA: 0x0042163C File Offset: 0x0041F83C
			public void OnEquipmentListItemClick(UIControllerBase itemCtrl)
			{
				this.m_owner.OnEquipmentListItemClick(itemCtrl);
			}

			// Token: 0x0600FB3C RID: 64316 RVA: 0x0042164C File Offset: 0x0041F84C
			public void OnEquipmentListItemNeedFill(UIControllerBase itemCtrl)
			{
				this.m_owner.OnEquipmentListItemNeedFill(itemCtrl);
			}

			// Token: 0x0600FB3D RID: 64317 RVA: 0x0042165C File Offset: 0x0041F85C
			public void OnFilterSortButtonClick()
			{
				this.m_owner.OnFilterSortButtonClick();
			}

			// Token: 0x0600FB3E RID: 64318 RVA: 0x0042166C File Offset: 0x0041F86C
			public void OnCloseFilterSortTypeGo()
			{
				this.m_owner.OnCloseFilterSortTypeGo();
			}

			// Token: 0x0600FB3F RID: 64319 RVA: 0x0042167C File Offset: 0x0041F87C
			public void OnFilterSortOrderButtonClick()
			{
				this.m_owner.OnFilterSortOrderButtonClick();
			}

			// Token: 0x0600FB40 RID: 64320 RVA: 0x0042168C File Offset: 0x0041F88C
			public void OnFilterTypeButtonClick(EquipmentSortItemUIController ctrl, bool isOn)
			{
				this.m_owner.OnFilterTypeButtonClick(ctrl, isOn);
			}

			// Token: 0x0600FB41 RID: 64321 RVA: 0x0042169C File Offset: 0x0041F89C
			public void SetEquipmentItemDesc(EquipmentBagItem equipment)
			{
				this.m_owner.SetEquipmentItemDesc(equipment);
			}

			// Token: 0x0600FB42 RID: 64322 RVA: 0x004216AC File Offset: 0x0041F8AC
			public void SetEquipmentComparison(EquipmentBagItem equipment)
			{
				this.m_owner.SetEquipmentComparison(equipment);
			}

			// Token: 0x0600FB43 RID: 64323 RVA: 0x004216BC File Offset: 0x0041F8BC
			public void ResetEquipmentComparisonPropValue()
			{
				this.m_owner.ResetEquipmentComparisonPropValue();
			}

			// Token: 0x0600FB44 RID: 64324 RVA: 0x004216CC File Offset: 0x0041F8CC
			public void SetEquipmentComparisonProp(PropertyModifyType type, int value, bool isDressed)
			{
				this.m_owner.SetEquipmentComparisonProp(type, value, isDressed);
			}

			// Token: 0x0600FB45 RID: 64325 RVA: 0x004216DC File Offset: 0x0041F8DC
			public void SetPropItemColor(Text oldText, Text newText)
			{
				this.m_owner.SetPropItemColor(oldText, newText);
			}

			// Token: 0x0600FB46 RID: 64326 RVA: 0x004216EC File Offset: 0x0041F8EC
			public void SetPropItems(PropertyModifyType type, int value, int addValue, int level)
			{
				this.m_owner.SetPropItems(type, value, addValue, level);
			}

			// Token: 0x0600FB47 RID: 64327 RVA: 0x00421700 File Offset: 0x0041F900
			public void OnDescEquipButtonClick()
			{
				this.m_owner.OnDescEquipButtonClick();
			}

			// Token: 0x0600FB48 RID: 64328 RVA: 0x00421710 File Offset: 0x0041F910
			public void OnConfirmPanelConfirmButtonClick()
			{
				this.m_owner.OnConfirmPanelConfirmButtonClick();
			}

			// Token: 0x0600FB49 RID: 64329 RVA: 0x00421720 File Offset: 0x0041F920
			public void OnConfirmPanelCancelButtonClick()
			{
				this.m_owner.OnConfirmPanelCancelButtonClick();
			}

			// Token: 0x0600FB4A RID: 64330 RVA: 0x00421730 File Offset: 0x0041F930
			public void OnDescUnloadButtonClick()
			{
				this.m_owner.OnDescUnloadButtonClick();
			}

			// Token: 0x0600FB4B RID: 64331 RVA: 0x00421740 File Offset: 0x0041F940
			public void OnDescLockButtonClick()
			{
				this.m_owner.OnDescLockButtonClick();
			}

			// Token: 0x0600FB4C RID: 64332 RVA: 0x00421750 File Offset: 0x0041F950
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600FB4D RID: 64333 RVA: 0x00421760 File Offset: 0x0041F960
			public void OnGoldAddButtonClick()
			{
				this.m_owner.OnGoldAddButtonClick();
			}

			// Token: 0x0600FB4E RID: 64334 RVA: 0x00421770 File Offset: 0x0041F970
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x0400936F RID: 37743
			private EquipmentDepotUIController m_owner;
		}
	}
}
