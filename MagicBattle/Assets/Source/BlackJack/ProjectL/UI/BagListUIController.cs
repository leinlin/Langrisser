using System;
using System.Collections.Generic;
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
	// Token: 0x02000A4F RID: 2639
	[HotFix]
	public class BagListUIController : UIControllerBase
	{
		// Token: 0x0600A323 RID: 41763 RVA: 0x002DF2AC File Offset: 0x002DD4AC
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
			this.m_useButton.onClick.AddListener(new UnityAction(this.OnUseButtonClick));
			this.m_alchemyButton.onClick.AddListener(new UnityAction(this.OnAlchemyButtonClick));
			this.m_itemToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnItemToggleValueChanged));
			this.m_fragmentToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnFragmentToggleValueChanged));
			this.m_jobMaterialToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnJobMaterialToggleValueChanged));
			this.m_equipmentToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnEquipmentToggleValueChanged));
			this.m_addAllItemButton.onClick.AddListener(new UnityAction(this.OnAddAllItemButtonClick));
			this.m_addAllEquipmentButton.onClick.AddListener(new UnityAction(this.OnAddAllEquipmentButtonClick));
			this.m_clearBagItemButton.onClick.AddListener(new UnityAction(this.OnClearBagButtonClick));
			this.m_speedUpButton.onClick.AddListener(new UnityAction(this.OnSpeedUpButtonClick));
			this.m_addItemButton.onClick.AddListener(new UnityAction(this.OnAddItemButtonClick));
			this.m_itemGetButton.onClick.AddListener(new UnityAction(this.OnGetItemButtonClick));
			this.m_equipmentForgeButton.onClick.AddListener(new UnityAction(this.OnEquipmentForgeButton));
			this.m_subItemMinusButton.onClick.AddListener(new UnityAction(this.OnItemMinusButtonClick));
			this.m_subItemAddButton.onClick.AddListener(new UnityAction(this.OnItemAddButtonClick));
			this.m_subItemMaxButton.onClick.AddListener(new UnityAction(this.OnItemMaxButtonClick));
			this.m_subItemUseButton.onClick.AddListener(new UnityAction(this.OnSubItemUseItemClick));
			this.m_subItemPanelReturnButton.onClick.AddListener(new UnityAction(this.CloseSubItemUsePanel));
			this.m_subItemNumInputField.onEndEdit.AddListener(new UnityAction<string>(this.OnInputEditEnd));
			this.InitLoopScrollViewRect();
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x002DF580 File Offset: 0x002DD780
		private void InitLoopScrollViewRect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLoopScrollViewRect_hotfix != null)
			{
				this.m_InitLoopScrollViewRect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("bagItem");
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			gameObject.transform.SetParent(this.m_listScrollViewItemTemplateRoot.transform, false);
			PoolInfo poolInfoByName = this.m_listItemPool.GetPoolInfoByName("bagItem");
			poolInfoByName.prefab = gameObject;
			this.m_listItemPool.CreatePools();
			Stack<PoolObject> objectPoolByName = this.m_listItemPool.GetObjectPoolByName("bagItem");
			foreach (PoolObject poolObject in objectPoolByName)
			{
				BagItemUIController component = poolObject.gameObject.GetComponent<BagItemUIController>();
				component.Init();
				component.RegisterItemClickEvent(new Action<UIControllerBase>(this.OnBagItemClick));
				component.RegisterItemNeedFillEvent(new Action<UIControllerBase>(this.OnBagItemNeedFill));
			}
			this.m_bagItemCache.Clear();
			this.m_loopScrollView.onValueChanged.AddListener(delegate(Vector2 vector2)
			{
				RectTransform component2 = this.m_bagListPointBgContent.GetComponent<RectTransform>();
				RectTransform component3 = this.m_scrollViewBagItemContent.GetComponent<RectTransform>();
				component2.anchoredPosition = component3.anchoredPosition;
			});
			this.m_loopScrollView.m_functionGetItemIndex = delegate(string itemName)
			{
				for (int i = 0; i < this.m_bagItemCache.Count; i++)
				{
					if (this.m_bagItemCache[i].ListItemName == itemName)
					{
						return i;
					}
				}
				return -1;
			};
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x002DF704 File Offset: 0x002DD904
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateOpen(component, "Show", null, false, true);
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x002DF780 File Offset: 0x002DD980
		public void UpdateViewInBagList(BagListUIController.DisplayType displayType, ulong clickInstanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInBagListDisplayTypeUInt64_hotfix != null)
			{
				this.m_UpdateViewInBagListDisplayTypeUInt64_hotfix.call(new object[]
				{
					this,
					displayType,
					clickInstanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfigData data = LocalConfig.Instance.Data;
			this.m_addAllItemButton.gameObject.SetActive(data.IsDeveloper);
			this.m_addAllEquipmentButton.gameObject.SetActive(data.IsDeveloper);
			this.m_addItemButton.gameObject.SetActive(data.IsDeveloper);
			this.m_speedUpButton.gameObject.SetActive(data.IsDeveloper);
			this.m_clearBagItemButton.gameObject.SetActive(data.IsDeveloper);
			this.m_bagItemInputField.gameObject.SetActive(data.IsDeveloper);
			this.SetBagCountLimit();
			this.m_displayType = displayType;
			switch (displayType)
			{
			case BagListUIController.DisplayType.Item:
				this.m_itemToggle.isOn = true;
				break;
			case BagListUIController.DisplayType.Fragment:
				this.m_fragmentToggle.isOn = true;
				break;
			case BagListUIController.DisplayType.JobMaterial:
				this.m_jobMaterialToggle.isOn = true;
				break;
			case BagListUIController.DisplayType.Equipment:
				this.m_equipmentToggle.isOn = true;
				break;
			}
			this.m_lastClickBagItem = this.m_playerContext.GetBagItemByInstanceId(clickInstanceId);
			this.m_lastClickBagItemType = displayType;
			this.m_bagItemCache.Clear();
			foreach (BagItemBase bagItemBase in this.m_playerContext.GetBagItems())
			{
				if (this.IsBagItemOfDisplayType(bagItemBase))
				{
					this.m_bagItemCache.Add(bagItemBase);
				}
			}
			this.m_bagItemCache.Sort(new Comparison<BagItemBase>(this.BagItemComparer));
			int startIdx = 0;
			if (this.m_lastClickBagItem != null && this.m_bagItemCache.Count > 0)
			{
				GameObject firstGameObjectInViewRect = this.m_loopScrollView.GetFirstGameObjectInViewRect();
				if (firstGameObjectInViewRect != null)
				{
					startIdx = firstGameObjectInViewRect.GetComponent<ScrollItemBaseUIController>().ItemIndex;
				}
			}
			this.m_loopScrollView.totalCount = this.m_bagItemCache.Count;
			this.m_loopScrollView.RefillCells(startIdx);
			if (this.m_bagItemCache.Count == 0)
			{
				this.CloseBagInfoPanel();
			}
			else
			{
				bool flag = false;
				if (this.m_lastClickBagItem == null)
				{
					flag = true;
				}
				else if (this.m_playerContext.GetBagItemByInstanceId(this.m_lastClickBagItem.InstanceId) == null)
				{
					flag = true;
				}
				else if (this.m_lastClickBagItemType != this.m_displayType)
				{
					flag = true;
				}
				else if (this.m_bagItemCache[0].GoodsTypeId == GoodsType.GoodsType_Item)
				{
					if (this.m_lastClickBagItem.GoodsTypeId != GoodsType.GoodsType_Item && this.m_lastClickBagItem.GoodsTypeId != GoodsType.GoodsType_EnchantStone)
					{
						flag = true;
					}
				}
				else if (this.m_bagItemCache[0].GoodsTypeId != this.m_lastClickBagItem.GoodsTypeId)
				{
					flag = true;
				}
				if (flag)
				{
					this.ResetScrollViewToTop();
					this.m_lastClickBagItem = null;
					BagItemUIController bagItemUIController = this.m_bagItemCtrlList.Find((BagItemUIController a) => a.BagItem == this.m_bagItemCache[0]);
					if (bagItemUIController != null)
					{
						this.OnBagItemClick(bagItemUIController);
					}
				}
				else
				{
					this.SetInfoPanel(this.m_lastClickBagItem);
				}
			}
			int num = 36;
			if (this.m_bagListPointBgContent.transform.childCount >= num)
			{
				UIUtility.SetGameObjectChildrenActiveCount(this.m_bagListPointBgContent, this.m_bagItemCache.Count + num);
			}
			else
			{
				int num2 = num - this.m_bagListPointBgContent.transform.childCount;
				for (int i = 0; i < num2; i++)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_bagListPointItem);
					gameObject.transform.SetParent(this.m_bagListPointBgContent.transform, false);
					gameObject.SetActive(true);
				}
			}
			Canvas.ForceUpdateCanvases();
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x002DFBC4 File Offset: 0x002DDDC4
		private bool IsBagItemOfDisplayType(BagItemBase itm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBagItemOfDisplayTypeBagItemBase_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBagItemOfDisplayTypeBagItemBase_hotfix.call(new object[]
				{
					this,
					itm
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_displayType == BagListUIController.DisplayType.Item)
			{
				if ((itm.GoodsTypeId == GoodsType.GoodsType_Item && itm.ItemInfo.DisplayType != ItemDisplayType.ItemDisplayType_HeroFragment) || itm.GoodsTypeId == GoodsType.GoodsType_EnchantStone)
				{
					return true;
				}
			}
			else if (this.m_displayType == BagListUIController.DisplayType.Fragment)
			{
				if (itm.GoodsTypeId == GoodsType.GoodsType_Item && itm.ItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_HeroFragment)
				{
					return true;
				}
			}
			else if (this.m_displayType == BagListUIController.DisplayType.JobMaterial)
			{
				if (itm.GoodsTypeId == GoodsType.GoodsType_JobMaterial)
				{
					return true;
				}
			}
			else if (this.m_displayType == BagListUIController.DisplayType.Equipment && itm.GoodsTypeId == GoodsType.GoodsType_Equipment)
			{
				return true;
			}
			return false;
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x002DFCE8 File Offset: 0x002DDEE8
		private void ShowNoItemPanelObj(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowNoItemPanelObjBoolean_hotfix != null)
			{
				this.m_ShowNoItemPanelObjBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_noItemPanelObj.SetActive(isShow);
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x002DFD64 File Offset: 0x002DDF64
		private int BagItemComparer(BagItemBase item1, BagItemBase item2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagItemComparerBagItemBaseBagItemBase_hotfix != null)
			{
				return Convert.ToInt32(this.m_BagItemComparerBagItemBaseBagItemBase_hotfix.call(new object[]
				{
					this,
					item1,
					item2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (item1.ItemInfo != null)
			{
				if (item2.ItemInfo != null)
				{
					if (item2.ItemInfo.Rank != item1.ItemInfo.Rank)
					{
						return item2.ItemInfo.Rank - item1.ItemInfo.Rank;
					}
					if (item2.ItemInfo.FuncType != item1.ItemInfo.FuncType)
					{
						return item2.ItemInfo.FuncType - item1.ItemInfo.FuncType;
					}
					return item2.ItemInfo.ID - item1.ItemInfo.ID;
				}
				else
				{
					if (item2.EnchantStoneInfo == null)
					{
						return -1;
					}
					if (item2.EnchantStoneInfo.Rank != item1.ItemInfo.Rank)
					{
						return item2.EnchantStoneInfo.Rank - item1.ItemInfo.Rank;
					}
					return item2.EnchantStoneInfo.ID - item1.ItemInfo.ID;
				}
			}
			else if (item1.JobMaterialInfo != null)
			{
				if (item2.JobMaterialInfo.Rank != item1.JobMaterialInfo.Rank)
				{
					return item2.JobMaterialInfo.Rank - item1.JobMaterialInfo.Rank;
				}
				return item2.JobMaterialInfo.ID - item1.JobMaterialInfo.ID;
			}
			else if (item1.EquipmentInfo != null)
			{
				if (item2.EquipmentInfo.EquipmentType != item1.EquipmentInfo.EquipmentType && (item1.EquipmentInfo.EquipmentType >= EquipmentType.EquipmentType_Enhancement || item2.EquipmentInfo.EquipmentType >= EquipmentType.EquipmentType_Enhancement))
				{
					if (item1.EquipmentInfo.EquipmentType < EquipmentType.EquipmentType_Enhancement || item2.EquipmentInfo.EquipmentType < EquipmentType.EquipmentType_Enhancement)
					{
						return item1.EquipmentInfo.EquipmentType - item2.EquipmentInfo.EquipmentType;
					}
					if (item2.EquipmentInfo.Rank != item1.EquipmentInfo.Rank)
					{
						return item2.EquipmentInfo.Rank - item1.EquipmentInfo.Rank;
					}
					return item2.EquipmentInfo.ID - item1.EquipmentInfo.ID;
				}
				else
				{
					if (item2.EquipmentInfo.Rank != item1.EquipmentInfo.Rank)
					{
						return item2.EquipmentInfo.Rank - item1.EquipmentInfo.Rank;
					}
					return item2.EquipmentInfo.ID - item1.EquipmentInfo.ID;
				}
			}
			else
			{
				if (item1.EnchantStoneInfo == null)
				{
					return 0;
				}
				if (item2.EnchantStoneInfo != null)
				{
					if (item2.EnchantStoneInfo.Rank != item1.EnchantStoneInfo.Rank)
					{
						return item2.EnchantStoneInfo.Rank - item1.EnchantStoneInfo.Rank;
					}
					return item2.EnchantStoneInfo.ID - item1.EnchantStoneInfo.ID;
				}
				else
				{
					if (item2.ItemInfo == null)
					{
						return 1;
					}
					if (item2.ItemInfo.Rank != item1.EnchantStoneInfo.Rank)
					{
						return item2.ItemInfo.Rank - item1.EnchantStoneInfo.Rank;
					}
					return item2.ItemInfo.ID - item1.EnchantStoneInfo.ID;
				}
			}
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x002E0104 File Offset: 0x002DE304
		private void OnBagItemClick(UIControllerBase itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBagItemClickUIControllerBase_hotfix != null)
			{
				this.m_OnBagItemClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemUIController bagItemUIController = itemCtrl as BagItemUIController;
			if (bagItemUIController == null)
			{
				return;
			}
			if (this.m_lastClickBagItem == bagItemUIController.BagItem && this.m_lastClickBagItemType == this.m_displayType)
			{
				return;
			}
			foreach (BagItemUIController bagItemUIController2 in this.m_bagItemCtrlList)
			{
				bagItemUIController2.ShowFrame(false);
			}
			bagItemUIController.ShowFrame(true);
			this.m_lastClickBagItem = bagItemUIController.BagItem;
			this.m_lastClickBagItemType = this.m_displayType;
			this.SetInfoPanel(this.m_lastClickBagItem);
			this.ShowNoItemPanelObj(false);
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x002E022C File Offset: 0x002DE42C
		private void OnBagItemNeedFill(UIControllerBase itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBagItemNeedFillUIControllerBase_hotfix != null)
			{
				this.m_OnBagItemNeedFillUIControllerBase_hotfix.call(new object[]
				{
					this,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemUIController bagItemUIController = itemCtrl as BagItemUIController;
			if (bagItemUIController == null)
			{
				return;
			}
			int itemIndex = bagItemUIController.ScrollItemBaseUICtrl.ItemIndex;
			if (itemIndex < this.m_bagItemCache.Count)
			{
				bagItemUIController.SetBagItemInfo(this.m_bagItemCache[itemIndex]);
				if (bagItemUIController.BagItem == this.m_lastClickBagItem)
				{
					bagItemUIController.ShowFrame(true);
				}
				else
				{
					bagItemUIController.ShowFrame(false);
				}
				if (!this.m_bagItemCtrlList.Contains(bagItemUIController))
				{
					this.m_bagItemCtrlList.Add(bagItemUIController);
				}
				Animator component = bagItemUIController.gameObject.GetComponent<Animator>();
				component.Play("Normal");
			}
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x002E0338 File Offset: 0x002DE538
		private void SetInfoPanel(BagItemBase bagItemBase)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetInfoPanelBagItemBase_hotfix != null)
			{
				this.m_SetInfoPanelBagItemBase_hotfix.call(new object[]
				{
					this,
					bagItemBase
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (bagItemBase == null)
			{
				return;
			}
			this.m_bagInfoPanelObj.SetActive(true);
			if (bagItemBase.ItemInfo != null)
			{
				BagItemBase bagItemByType = this.m_playerContext.GetBagItemByType(bagItemBase.GoodsTypeId, bagItemBase.ContentId);
				this.m_useButton.gameObject.SetActive(false);
				if (bagItemByType != null && bagItemByType.ItemInfo != null)
				{
					ItemFuncType funcType = bagItemByType.ItemInfo.FuncType;
					if (funcType == ItemFuncType.ItemFuncType_Gold || funcType == ItemFuncType.ItemFuncType_Crystal || funcType == ItemFuncType.ItemFuncType_Energy || funcType == ItemFuncType.ItemFuncType_PlayerEXP || funcType == ItemFuncType.ItemFuncType_RandomBox || funcType == ItemFuncType.ItemFuncType_StaticBox)
					{
						this.m_bagInfoStateCtrl.SetToUIState("Item", false, true);
					}
					else
					{
						this.m_bagInfoStateCtrl.SetToUIState("Piece", false, true);
					}
				}
			}
			else if (bagItemBase.JobMaterialInfo != null)
			{
				this.m_bagInfoStateCtrl.SetToUIState("Piece", false, true);
			}
			else if (bagItemBase.EquipmentInfo != null)
			{
				this.m_bagInfoStateCtrl.SetToUIState("Equip", false, true);
				this.SetEquipmentInfo((EquipmentBagItem)bagItemBase);
			}
			else if (bagItemBase.EnchantStoneInfo != null)
			{
				this.m_bagInfoStateCtrl.SetToUIState("Item", false, true);
				this.m_useButton.gameObject.SetActive(false);
			}
			this.m_itemNameText.text = UIUtility.GetGoodsName(bagItemBase.GoodsTypeId, bagItemBase.ContentId);
			this.m_itemDescText.text = UIUtility.GetGoodsDesc(bagItemBase.GoodsTypeId, bagItemBase.ContentId);
			this.m_itemIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(bagItemBase.GoodsTypeId, bagItemBase.ContentId));
			this.m_itemIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(bagItemBase.GoodsTypeId, bagItemBase.ContentId));
			this.m_itemCountText.text = UIUtility.GetGoodsCount(bagItemBase.GoodsTypeId, bagItemBase.ContentId).ToString();
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x002E0594 File Offset: 0x002DE794
		private void SetEquipmentInfo(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentInfoEquipmentBagItem_hotfix != null)
			{
				this.m_SetEquipmentInfoEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_equipmentInfoExplainText.text = equipment.EquipmentInfo.Desc;
			this.SetEquipmentSkillInfo(equipment);
			this.SetEquipmentLimitInfo(equipment);
			this.SetEquipmentEnchantInfo(equipment);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_equipmentPropertyGroup, 0);
			this.SetEquipmentPropItem(equipment.EquipmentInfo.Property1_ID, equipment.EquipmentInfo.Property1_Value, equipment.EquipmentInfo.Property1_LevelUpValue, equipment.Level);
			this.SetEquipmentPropItem(equipment.EquipmentInfo.Property2_ID, equipment.EquipmentInfo.Property2_Value, equipment.EquipmentInfo.Property2_LevelUpValue, equipment.Level);
			this.m_equipmentForgeButton.gameObject.SetActive(equipment.EquipmentInfo.DisplayRewardCount != 0);
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x002E06B8 File Offset: 0x002DE8B8
		private void SetEquipmentSkillInfo(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentSkillInfoEquipmentBagItem_hotfix != null)
			{
				this.m_SetEquipmentSkillInfoEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (equipment.EquipmentInfo.SkillIds.Count == 0)
			{
				this.m_equipmentSkillStateCtrl.SetToUIState("NoSkill", false, true);
			}
			else
			{
				this.m_equipmentSkillStateCtrl.SetToUIState("HaveSkill", false, true);
				string text = null;
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(UIUtility.GetSkillIdFromEquipment(equipment.EquipmentInfo, equipment.Level, ref text));
				if (configDataSkillInfo != null)
				{
					if (text == null)
					{
						this.m_equipmentSkillContentStateCtrl.SetToUIState("Grey", false, true);
						if (equipment.EquipmentInfo.SkillLevels.Count > 0)
						{
							this.m_equipmentSkillUnlockCoditionText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_EnchantToLevel), equipment.EquipmentInfo.SkillLevels[0]);
						}
						else
						{
							this.m_equipmentSkillUnlockCoditionText.text = string.Empty;
						}
					}
					else
					{
						this.m_equipmentSkillContentStateCtrl.SetToUIState("Normal", false, true);
						this.m_equipmentSkillLvValueText.text = "Lv." + text;
					}
					this.m_equipmentSkillNameText.text = configDataSkillInfo.Name;
					this.m_equipmentSkillDescText.text = configDataSkillInfo.Desc;
					ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(equipment.EquipmentInfo.SkillHero);
					this.m_equipmentSkillCharNameText.gameObject.SetActive(configDataHeroInfo != null);
					this.m_equipmentSkillCharNameBGImage.SetActive(configDataHeroInfo != null);
					if (configDataHeroInfo != null)
					{
						this.m_equipmentSkillCharNameText.text = configDataHeroInfo.Name + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Equipment_SkillOwner);
					}
				}
			}
		}

		// Token: 0x0600A32F RID: 41775 RVA: 0x002E08C4 File Offset: 0x002DEAC4
		private void SetEquipmentLimitInfo(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentLimitInfoEquipmentBagItem_hotfix != null)
			{
				this.m_SetEquipmentLimitInfoEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (equipment.EquipmentInfo.EquipCoditionDesc != string.Empty)
			{
				this.m_equipmentLimitStateCtrl.SetToUIState("Unlimit", false, true);
				this.m_equipmentEquipUnlimitText.text = equipment.EquipmentInfo.EquipCoditionDesc;
				return;
			}
			List<int> armyIds = equipment.EquipmentInfo.ArmyIds;
			if (armyIds.Count == 0)
			{
				this.m_equipmentLimitStateCtrl.SetToUIState("Unlimit", false, true);
				this.m_equipmentEquipUnlimitText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AllJobCanUse);
			}
			else if (armyIds[0] == -1)
			{
				this.m_equipmentLimitStateCtrl.SetToUIState("CanNotUse", false, true);
			}
			else
			{
				this.m_equipmentLimitStateCtrl.SetToUIState("EquipLimit", false, true);
				for (int i = 0; i < this.m_equipmentLimitContent.transform.childCount; i++)
				{
					Transform child = this.m_equipmentLimitContent.transform.GetChild(i);
					child.gameObject.SetActive(false);
				}
				for (int j = 0; j < armyIds.Count; j++)
				{
					ConfigDataArmyInfo configDataArmyInfo = this.m_configDataLoader.GetConfigDataArmyInfo(armyIds[j]);
					if (j < this.m_equipmentLimitContent.transform.childCount)
					{
						Transform child2 = this.m_equipmentLimitContent.transform.GetChild(j);
						child2.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
						child2.gameObject.SetActive(true);
					}
					else
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_equipmentLimitContent.transform.GetChild(0).gameObject, this.m_equipmentLimitContent.transform, true);
						gameObject.transform.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
						gameObject.SetActive(true);
					}
				}
			}
		}

		// Token: 0x0600A330 RID: 41776 RVA: 0x002E0B18 File Offset: 0x002DED18
		private void SetEquipmentEnchantInfo(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentEnchantInfoEquipmentBagItem_hotfix != null)
			{
				this.m_SetEquipmentEnchantInfoEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_equipmentPropEnchantmentGroupResonanceGo.SetActive(equipment.IsEnchant());
			if (equipment.IsEnchant())
			{
				int equipmentResonanceNums = this.m_playerContext.GetEquipmentResonanceNums(equipment.InstanceId);
				if (equipmentResonanceNums < 2)
				{
					this.m_equipmentPropEnchantmentGroupRuneStateCtrl.SetToUIState("1", false, true);
				}
				else
				{
					this.m_equipmentPropEnchantmentGroupRuneStateCtrl.SetToUIState("2", false, true);
				}
				ConfigDataResonanceInfo configDataResonanceInfo = this.m_configDataLoader.GetConfigDataResonanceInfo(equipment.ResonanceId);
				this.m_equipmentPropEnchantmentGroupRuneIconImage.sprite = AssetUtility.Instance.GetSprite(configDataResonanceInfo.SmallIcon);
				this.m_equipmentPropEnchantmentGroupRuneNameText.text = string.Concat(new object[]
				{
					configDataResonanceInfo.Name,
					"(",
					equipmentResonanceNums,
					"/4)"
				});
				this.m_equipmentPropGroupStateCtrl.SetToUIState("Resonance", false, true);
				List<CommonBattleProperty> enchantProperties = equipment.EnchantProperties;
				Transform transform = this.m_equipmentPropEnchantmentGroup.transform;
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
			}
			else
			{
				this.m_equipmentPropGroupStateCtrl.SetToUIState("Unresonance", false, true);
			}
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x002E0DD8 File Offset: 0x002DEFD8
		private void SetEquipmentPropItem(PropertyModifyType type, int value, int addValue, int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentPropItemPropertyModifyTypeInt32Int32Int32_hotfix != null)
			{
				this.m_SetEquipmentPropItemPropertyModifyTypeInt32Int32Int32_hotfix.call(new object[]
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
			switch (type)
			{
			case PropertyModifyType.PropertyModifyType_Hero1_HPAdd:
				this.m_equipmentPropHPGo.SetActive(true);
				this.m_equipmentPropHPValueText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_ATAdd:
				this.m_equipmentPropATGo.SetActive(true);
				this.m_equipmentPropATValueText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DFAdd:
				this.m_equipmentPropDFGo.SetActive(true);
				this.m_equipmentPropDFValueText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicAdd:
				this.m_equipmentPropMagiccGo.SetActive(true);
				this.m_equipmentPropMagicValueText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicDFAdd:
				this.m_equipmentPropMagicDFGo.SetActive(true);
				this.m_equipmentPropMagicDFValueText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DEXAdd:
				this.m_equipmentPropDexGo.SetActive(true);
				this.m_equipmentPropDexValueText.text = value.ToString();
				break;
			}
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x002E0FAC File Offset: 0x002DF1AC
		private void SetBagCountLimit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBagCountLimit_hotfix != null)
			{
				this.m_SetBagCountLimit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_BagMaxCapacity);
			int bagSize = this.m_playerContext.GetBagSize();
			if (bagSize >= num / 2)
			{
				this.m_bagCountLimitStateCtrl.gameObject.SetActive(true);
				if (bagSize <= num)
				{
					this.m_bagCountLimitStateCtrl.SetToUIState("Normal", false, true);
				}
				else
				{
					this.m_bagCountLimitStateCtrl.SetToUIState("Full", false, true);
				}
				this.m_bagCountText.text = bagSize.ToString();
				this.m_bagMaxCountText.text = num.ToString();
			}
			else
			{
				this.m_bagCountLimitStateCtrl.gameObject.SetActive(false);
			}
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x002E10B8 File Offset: 0x002DF2B8
		private void OnGetItemButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetItemButtonClick_hotfix != null)
			{
				this.m_OnGetItemButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowGetPath != null)
			{
				this.EventOnShowGetPath(this.m_lastClickBagItem, this.m_displayType);
			}
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x002E113C File Offset: 0x002DF33C
		private void OnEquipmentForgeButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentForgeButton_hotfix != null)
			{
				this.m_OnEquipmentForgeButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_lastClickBagItem.EquipmentInfo.EquipmentType != EquipmentType.EquipmentType_LevelUpStar && this.m_lastClickBagItem.EquipmentInfo.EquipmentType != EquipmentType.EquipmentType_Enhancement;
			if (flag)
			{
				if (this.EventOnEquipmentForge != null)
				{
					this.EventOnEquipmentForge((int)this.m_lastClickBagItem.EquipmentInfo.EquipmentType, this.m_lastClickBagItem.InstanceId, this.m_displayType);
				}
			}
			else
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_CantForge, 2f, null, true);
			}
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x002E1224 File Offset: 0x002DF424
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
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x0600A336 RID: 41782 RVA: 0x002E129C File Offset: 0x002DF49C
		public void ResetBagUIView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetBagUIView_hotfix != null)
			{
				this.m_ResetBagUIView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lastClickBagItem = null;
			this.m_displayType = BagListUIController.DisplayType.Item;
			this.m_itemToggle.isOn = true;
		}

		// Token: 0x0600A337 RID: 41783 RVA: 0x002E1318 File Offset: 0x002DF518
		private void OnAlchemyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAlchemyButtonClick_hotfix != null)
			{
				this.m_OnAlchemyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAlchemyButtonClick != null)
			{
				this.EventOnAlchemyButtonClick();
			}
		}

		// Token: 0x0600A338 RID: 41784 RVA: 0x002E1390 File Offset: 0x002DF590
		private void OnUseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUseButtonClick_hotfix != null)
			{
				this.m_OnUseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase lastClickBagItem = this.m_lastClickBagItem;
			int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(lastClickBagItem.GoodsTypeId, lastClickBagItem.ContentId);
			if (bagItemCountByType > 1)
			{
				if (this.m_subItemNumInputField.text == string.Empty)
				{
					this.m_subItemNumInputField.text = "1";
				}
				CommonUIStateController component = this.m_subBagInfoPanelObj.GetComponent<CommonUIStateController>();
				UIUtility.SetUIStateOpen(component, "Show", null, false, true);
			}
			else if (this.EventOnUse != null)
			{
				this.EventOnUse(lastClickBagItem.GoodsTypeId, lastClickBagItem.ContentId, 1, this.m_displayType);
			}
		}

		// Token: 0x0600A339 RID: 41785 RVA: 0x002E1488 File Offset: 0x002DF688
		private void OnSubItemUseItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSubItemUseItemClick_hotfix != null)
			{
				this.m_OnSubItemUseItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = int.Parse(this.m_subItemNumInputField.text);
			if (this.m_subItemNumInputField.text == string.Empty || num < 1)
			{
				CommonUIController.Instance.ShowErrorMessage(-521, 2f, null, true);
				return;
			}
			if (this.EventOnUse != null)
			{
				this.EventOnUse(this.m_lastClickBagItem.GoodsTypeId, this.m_lastClickBagItem.ContentId, num, this.m_displayType);
			}
			this.CloseSubItemUsePanel();
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x002E156C File Offset: 0x002DF76C
		private void CloseSubItemUsePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseSubItemUsePanel_hotfix != null)
			{
				this.m_CloseSubItemUsePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_subItemNumInputField.text = "1";
			CommonUIStateController component = this.m_subBagInfoPanelObj.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateClose(component, "Close", null, false, true);
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x002E15F8 File Offset: 0x002DF7F8
		private void OnInputEditEnd(string inputString)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInputEditEndString_hotfix != null)
			{
				this.m_OnInputEditEndString_hotfix.call(new object[]
				{
					this,
					inputString
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (inputString == null)
			{
				inputString = this.m_subItemNumInputField.text;
			}
			if (inputString != string.Empty)
			{
				int num = int.Parse(inputString);
				int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(this.m_lastClickBagItem.GoodsTypeId, this.m_lastClickBagItem.ContentId);
				if (bagItemCountByType < num)
				{
					this.m_subItemNumInputField.text = bagItemCountByType.ToString();
				}
			}
		}

		// Token: 0x0600A33C RID: 41788 RVA: 0x002E16D4 File Offset: 0x002DF8D4
		private void OnItemMinusButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemMinusButtonClick_hotfix != null)
			{
				this.m_OnItemMinusButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_subItemNumInputField.text == string.Empty)
			{
				this.m_subItemNumInputField.text = "1";
			}
			int num = int.Parse(this.m_subItemNumInputField.text);
			if (num > 1)
			{
				this.m_subItemNumInputField.text = (num - 1).ToString();
			}
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x002E1794 File Offset: 0x002DF994
		private void OnItemAddButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemAddButtonClick_hotfix != null)
			{
				this.m_OnItemAddButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_subItemNumInputField.text == string.Empty)
			{
				this.m_subItemNumInputField.text = "1";
			}
			BagItemBase lastClickBagItem = this.m_lastClickBagItem;
			int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(lastClickBagItem.GoodsTypeId, lastClickBagItem.ContentId);
			int num = int.Parse(this.m_subItemNumInputField.text);
			if (num < bagItemCountByType)
			{
				this.m_subItemNumInputField.text = (num + 1).ToString();
			}
		}

		// Token: 0x0600A33E RID: 41790 RVA: 0x002E1874 File Offset: 0x002DFA74
		private void OnItemMaxButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemMaxButtonClick_hotfix != null)
			{
				this.m_OnItemMaxButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemBase lastClickBagItem = this.m_lastClickBagItem;
			int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(lastClickBagItem.GoodsTypeId, lastClickBagItem.ContentId);
			this.m_subItemNumInputField.text = bagItemCountByType.ToString();
		}

		// Token: 0x0600A33F RID: 41791 RVA: 0x002E190C File Offset: 0x002DFB0C
		private void OnAddAllItemButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddAllItemButtonClick_hotfix != null)
			{
				this.m_OnAddAllItemButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddAllItem != null)
			{
				this.EventOnAddAllItem();
			}
		}

		// Token: 0x0600A340 RID: 41792 RVA: 0x002E1984 File Offset: 0x002DFB84
		private void OnAddAllEquipmentButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddAllEquipmentButtonClick_hotfix != null)
			{
				this.m_OnAddAllEquipmentButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddAllEquipment != null)
			{
				this.EventOnAddAllEquipment();
			}
		}

		// Token: 0x0600A341 RID: 41793 RVA: 0x002E19FC File Offset: 0x002DFBFC
		private void OnAddItemButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddItemButtonClick_hotfix != null)
			{
				this.m_OnAddItemButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddItem != null)
			{
				this.EventOnAddItem(this.m_bagItemInputField.text);
			}
		}

		// Token: 0x0600A342 RID: 41794 RVA: 0x002E1A80 File Offset: 0x002DFC80
		private void OnClearBagButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClearBagButtonClick_hotfix != null)
			{
				this.m_OnClearBagButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClearBag != null)
			{
				this.EventOnClearBag();
			}
			this.CloseBagInfoPanel();
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x002E1AFC File Offset: 0x002DFCFC
		private void OnSpeedUpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSpeedUpButtonClick_hotfix != null)
			{
				this.m_OnSpeedUpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSpeedUp != null && this.m_lastClickBagItem != null && this.m_lastClickBagItem.EquipmentInfo != null)
			{
				this.EventOnSpeedUp((int)this.m_lastClickBagItem.EquipmentInfo.EquipmentType, this.m_lastClickBagItem.InstanceId, this.m_displayType);
			}
		}

		// Token: 0x0600A344 RID: 41796 RVA: 0x002E1BB0 File Offset: 0x002DFDB0
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

		// Token: 0x0600A345 RID: 41797 RVA: 0x002E1C20 File Offset: 0x002DFE20
		public void CloseBagInfoPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseBagInfoPanel_hotfix != null)
			{
				this.m_CloseBagInfoPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowNoItemPanelObj(true);
			this.m_bagInfoPanelObj.SetActive(false);
		}

		// Token: 0x0600A346 RID: 41798 RVA: 0x002E1C94 File Offset: 0x002DFE94
		private void OnItemToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnItemToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				if (this.m_displayType == BagListUIController.DisplayType.Item)
				{
					return;
				}
				this.m_displayType = BagListUIController.DisplayType.Item;
				this.OnToggleChanged();
			}
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x002E1D24 File Offset: 0x002DFF24
		private void OnJobMaterialToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobMaterialToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnJobMaterialToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				if (this.m_displayType == BagListUIController.DisplayType.JobMaterial)
				{
					return;
				}
				this.m_displayType = BagListUIController.DisplayType.JobMaterial;
				this.OnToggleChanged();
			}
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x002E1DB4 File Offset: 0x002DFFB4
		private void OnEquipmentToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnEquipmentToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				if (this.m_displayType == BagListUIController.DisplayType.Equipment)
				{
					return;
				}
				this.m_displayType = BagListUIController.DisplayType.Equipment;
				this.OnToggleChanged();
			}
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x002E1E44 File Offset: 0x002E0044
		private void OnFragmentToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFragmentToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnFragmentToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				if (this.m_displayType == BagListUIController.DisplayType.Fragment)
				{
					return;
				}
				this.m_displayType = BagListUIController.DisplayType.Fragment;
				this.OnToggleChanged();
			}
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x002E1ED4 File Offset: 0x002E00D4
		private void OnToggleChanged()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnToggleChanged_hotfix != null)
			{
				this.m_OnToggleChanged_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lastClickBagItem = null;
			this.ResetScrollViewToTop();
			this.UpdateViewInBagList(this.m_displayType, (this.m_lastClickBagItem != null) ? this.m_lastClickBagItem.InstanceId : 0UL);
		}

		// Token: 0x140001E4 RID: 484
		// (add) Token: 0x0600A34B RID: 41803 RVA: 0x002E1F6C File Offset: 0x002E016C
		// (remove) Token: 0x0600A34C RID: 41804 RVA: 0x002E2008 File Offset: 0x002E0208
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

		// Token: 0x140001E5 RID: 485
		// (add) Token: 0x0600A34D RID: 41805 RVA: 0x002E20A4 File Offset: 0x002E02A4
		// (remove) Token: 0x0600A34E RID: 41806 RVA: 0x002E2140 File Offset: 0x002E0340
		public event Action EventOnClearBag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClearBagAction_hotfix != null)
				{
					this.m_add_EventOnClearBagAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClearBag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClearBag, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClearBagAction_hotfix != null)
				{
					this.m_remove_EventOnClearBagAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClearBag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClearBag, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001E6 RID: 486
		// (add) Token: 0x0600A34F RID: 41807 RVA: 0x002E21DC File Offset: 0x002E03DC
		// (remove) Token: 0x0600A350 RID: 41808 RVA: 0x002E2278 File Offset: 0x002E0478
		public event Action<int, ulong, BagListUIController.DisplayType> EventOnSpeedUp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSpeedUpAction`3_hotfix != null)
				{
					this.m_add_EventOnSpeedUpAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong, BagListUIController.DisplayType> action = this.EventOnSpeedUp;
				Action<int, ulong, BagListUIController.DisplayType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong, BagListUIController.DisplayType>>(ref this.EventOnSpeedUp, (Action<int, ulong, BagListUIController.DisplayType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSpeedUpAction`3_hotfix != null)
				{
					this.m_remove_EventOnSpeedUpAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong, BagListUIController.DisplayType> action = this.EventOnSpeedUp;
				Action<int, ulong, BagListUIController.DisplayType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong, BagListUIController.DisplayType>>(ref this.EventOnSpeedUp, (Action<int, ulong, BagListUIController.DisplayType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001E7 RID: 487
		// (add) Token: 0x0600A351 RID: 41809 RVA: 0x002E2314 File Offset: 0x002E0514
		// (remove) Token: 0x0600A352 RID: 41810 RVA: 0x002E23B0 File Offset: 0x002E05B0
		public event Action EventOnAddAllItem
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddAllItemAction_hotfix != null)
				{
					this.m_add_EventOnAddAllItemAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddAllItem;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddAllItem, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddAllItemAction_hotfix != null)
				{
					this.m_remove_EventOnAddAllItemAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddAllItem;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddAllItem, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001E8 RID: 488
		// (add) Token: 0x0600A353 RID: 41811 RVA: 0x002E244C File Offset: 0x002E064C
		// (remove) Token: 0x0600A354 RID: 41812 RVA: 0x002E24E8 File Offset: 0x002E06E8
		public event Action EventOnAddAllEquipment
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddAllEquipmentAction_hotfix != null)
				{
					this.m_add_EventOnAddAllEquipmentAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddAllEquipment;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddAllEquipment, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddAllEquipmentAction_hotfix != null)
				{
					this.m_remove_EventOnAddAllEquipmentAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddAllEquipment;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddAllEquipment, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001E9 RID: 489
		// (add) Token: 0x0600A355 RID: 41813 RVA: 0x002E2584 File Offset: 0x002E0784
		// (remove) Token: 0x0600A356 RID: 41814 RVA: 0x002E2620 File Offset: 0x002E0820
		public event Action EventOnAlchemyButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAlchemyButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnAlchemyButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAlchemyButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAlchemyButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAlchemyButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnAlchemyButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAlchemyButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAlchemyButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001EA RID: 490
		// (add) Token: 0x0600A357 RID: 41815 RVA: 0x002E26BC File Offset: 0x002E08BC
		// (remove) Token: 0x0600A358 RID: 41816 RVA: 0x002E2758 File Offset: 0x002E0958
		public event Action<string> EventOnAddItem
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddItemAction`1_hotfix != null)
				{
					this.m_add_EventOnAddItemAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnAddItem;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnAddItem, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddItemAction`1_hotfix != null)
				{
					this.m_remove_EventOnAddItemAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnAddItem;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnAddItem, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001EB RID: 491
		// (add) Token: 0x0600A359 RID: 41817 RVA: 0x002E27F4 File Offset: 0x002E09F4
		// (remove) Token: 0x0600A35A RID: 41818 RVA: 0x002E2890 File Offset: 0x002E0A90
		public event Action<GoodsType, int, int, BagListUIController.DisplayType> EventOnUse
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUseAction`4_hotfix != null)
				{
					this.m_add_EventOnUseAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int, BagListUIController.DisplayType> action = this.EventOnUse;
				Action<GoodsType, int, int, BagListUIController.DisplayType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int, BagListUIController.DisplayType>>(ref this.EventOnUse, (Action<GoodsType, int, int, BagListUIController.DisplayType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUseAction`4_hotfix != null)
				{
					this.m_remove_EventOnUseAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int, BagListUIController.DisplayType> action = this.EventOnUse;
				Action<GoodsType, int, int, BagListUIController.DisplayType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int, BagListUIController.DisplayType>>(ref this.EventOnUse, (Action<GoodsType, int, int, BagListUIController.DisplayType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001EC RID: 492
		// (add) Token: 0x0600A35B RID: 41819 RVA: 0x002E292C File Offset: 0x002E0B2C
		// (remove) Token: 0x0600A35C RID: 41820 RVA: 0x002E29C8 File Offset: 0x002E0BC8
		public event Action<int, ulong, BagListUIController.DisplayType> EventOnEquipmentForge
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEquipmentForgeAction`3_hotfix != null)
				{
					this.m_add_EventOnEquipmentForgeAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong, BagListUIController.DisplayType> action = this.EventOnEquipmentForge;
				Action<int, ulong, BagListUIController.DisplayType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong, BagListUIController.DisplayType>>(ref this.EventOnEquipmentForge, (Action<int, ulong, BagListUIController.DisplayType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEquipmentForgeAction`3_hotfix != null)
				{
					this.m_remove_EventOnEquipmentForgeAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong, BagListUIController.DisplayType> action = this.EventOnEquipmentForge;
				Action<int, ulong, BagListUIController.DisplayType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong, BagListUIController.DisplayType>>(ref this.EventOnEquipmentForge, (Action<int, ulong, BagListUIController.DisplayType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001ED RID: 493
		// (add) Token: 0x0600A35D RID: 41821 RVA: 0x002E2A64 File Offset: 0x002E0C64
		// (remove) Token: 0x0600A35E RID: 41822 RVA: 0x002E2B00 File Offset: 0x002E0D00
		public event Action<BagItemBase, BagListUIController.DisplayType> EventOnShowGetPath
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowGetPathAction`2_hotfix != null)
				{
					this.m_add_EventOnShowGetPathAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BagItemBase, BagListUIController.DisplayType> action = this.EventOnShowGetPath;
				Action<BagItemBase, BagListUIController.DisplayType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BagItemBase, BagListUIController.DisplayType>>(ref this.EventOnShowGetPath, (Action<BagItemBase, BagListUIController.DisplayType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowGetPathAction`2_hotfix != null)
				{
					this.m_remove_EventOnShowGetPathAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BagItemBase, BagListUIController.DisplayType> action = this.EventOnShowGetPath;
				Action<BagItemBase, BagListUIController.DisplayType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BagItemBase, BagListUIController.DisplayType>>(ref this.EventOnShowGetPath, (Action<BagItemBase, BagListUIController.DisplayType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x0600A35F RID: 41823 RVA: 0x002E2B9C File Offset: 0x002E0D9C
		// (set) Token: 0x0600A360 RID: 41824 RVA: 0x002E2BBC File Offset: 0x002E0DBC
		[DoNotToLua]
		public new BagListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BagListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x002E2BC8 File Offset: 0x002E0DC8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x002E2BD4 File Offset: 0x002E0DD4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A363 RID: 41827 RVA: 0x002E2BDC File Offset: 0x002E0DDC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A364 RID: 41828 RVA: 0x002E2BE4 File Offset: 0x002E0DE4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x002E2BF8 File Offset: 0x002E0DF8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x002E2C00 File Offset: 0x002E0E00
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x002E2C0C File Offset: 0x002E0E0C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x002E2C18 File Offset: 0x002E0E18
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x002E2C24 File Offset: 0x002E0E24
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x002E2C30 File Offset: 0x002E0E30
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x002E2C3C File Offset: 0x002E0E3C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x002E2C48 File Offset: 0x002E0E48
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x002E2C54 File Offset: 0x002E0E54
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x002E2C60 File Offset: 0x002E0E60
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x002E2C6C File Offset: 0x002E0E6C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A370 RID: 41840 RVA: 0x002E2C74 File Offset: 0x002E0E74
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x002E2C94 File Offset: 0x002E0E94
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x002E2CA0 File Offset: 0x002E0EA0
		private void __callDele_EventOnClearBag()
		{
			Action eventOnClearBag = this.EventOnClearBag;
			if (eventOnClearBag != null)
			{
				eventOnClearBag();
			}
		}

		// Token: 0x0600A373 RID: 41843 RVA: 0x002E2CC0 File Offset: 0x002E0EC0
		private void __clearDele_EventOnClearBag()
		{
			this.EventOnClearBag = null;
		}

		// Token: 0x0600A374 RID: 41844 RVA: 0x002E2CCC File Offset: 0x002E0ECC
		private void __callDele_EventOnSpeedUp(int arg1, ulong arg2, BagListUIController.DisplayType arg3)
		{
			Action<int, ulong, BagListUIController.DisplayType> eventOnSpeedUp = this.EventOnSpeedUp;
			if (eventOnSpeedUp != null)
			{
				eventOnSpeedUp(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x002E2CF0 File Offset: 0x002E0EF0
		private void __clearDele_EventOnSpeedUp(int arg1, ulong arg2, BagListUIController.DisplayType arg3)
		{
			this.EventOnSpeedUp = null;
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x002E2CFC File Offset: 0x002E0EFC
		private void __callDele_EventOnAddAllItem()
		{
			Action eventOnAddAllItem = this.EventOnAddAllItem;
			if (eventOnAddAllItem != null)
			{
				eventOnAddAllItem();
			}
		}

		// Token: 0x0600A377 RID: 41847 RVA: 0x002E2D1C File Offset: 0x002E0F1C
		private void __clearDele_EventOnAddAllItem()
		{
			this.EventOnAddAllItem = null;
		}

		// Token: 0x0600A378 RID: 41848 RVA: 0x002E2D28 File Offset: 0x002E0F28
		private void __callDele_EventOnAddAllEquipment()
		{
			Action eventOnAddAllEquipment = this.EventOnAddAllEquipment;
			if (eventOnAddAllEquipment != null)
			{
				eventOnAddAllEquipment();
			}
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x002E2D48 File Offset: 0x002E0F48
		private void __clearDele_EventOnAddAllEquipment()
		{
			this.EventOnAddAllEquipment = null;
		}

		// Token: 0x0600A37A RID: 41850 RVA: 0x002E2D54 File Offset: 0x002E0F54
		private void __callDele_EventOnAlchemyButtonClick()
		{
			Action eventOnAlchemyButtonClick = this.EventOnAlchemyButtonClick;
			if (eventOnAlchemyButtonClick != null)
			{
				eventOnAlchemyButtonClick();
			}
		}

		// Token: 0x0600A37B RID: 41851 RVA: 0x002E2D74 File Offset: 0x002E0F74
		private void __clearDele_EventOnAlchemyButtonClick()
		{
			this.EventOnAlchemyButtonClick = null;
		}

		// Token: 0x0600A37C RID: 41852 RVA: 0x002E2D80 File Offset: 0x002E0F80
		private void __callDele_EventOnAddItem(string obj)
		{
			Action<string> eventOnAddItem = this.EventOnAddItem;
			if (eventOnAddItem != null)
			{
				eventOnAddItem(obj);
			}
		}

		// Token: 0x0600A37D RID: 41853 RVA: 0x002E2DA4 File Offset: 0x002E0FA4
		private void __clearDele_EventOnAddItem(string obj)
		{
			this.EventOnAddItem = null;
		}

		// Token: 0x0600A37E RID: 41854 RVA: 0x002E2DB0 File Offset: 0x002E0FB0
		private void __callDele_EventOnUse(GoodsType arg1, int arg2, int arg3, BagListUIController.DisplayType arg4)
		{
			Action<GoodsType, int, int, BagListUIController.DisplayType> eventOnUse = this.EventOnUse;
			if (eventOnUse != null)
			{
				eventOnUse(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x0600A37F RID: 41855 RVA: 0x002E2DD8 File Offset: 0x002E0FD8
		private void __clearDele_EventOnUse(GoodsType arg1, int arg2, int arg3, BagListUIController.DisplayType arg4)
		{
			this.EventOnUse = null;
		}

		// Token: 0x0600A380 RID: 41856 RVA: 0x002E2DE4 File Offset: 0x002E0FE4
		private void __callDele_EventOnEquipmentForge(int arg1, ulong arg2, BagListUIController.DisplayType arg3)
		{
			Action<int, ulong, BagListUIController.DisplayType> eventOnEquipmentForge = this.EventOnEquipmentForge;
			if (eventOnEquipmentForge != null)
			{
				eventOnEquipmentForge(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600A381 RID: 41857 RVA: 0x002E2E08 File Offset: 0x002E1008
		private void __clearDele_EventOnEquipmentForge(int arg1, ulong arg2, BagListUIController.DisplayType arg3)
		{
			this.EventOnEquipmentForge = null;
		}

		// Token: 0x0600A382 RID: 41858 RVA: 0x002E2E14 File Offset: 0x002E1014
		private void __callDele_EventOnShowGetPath(BagItemBase arg1, BagListUIController.DisplayType arg2)
		{
			Action<BagItemBase, BagListUIController.DisplayType> eventOnShowGetPath = this.EventOnShowGetPath;
			if (eventOnShowGetPath != null)
			{
				eventOnShowGetPath(arg1, arg2);
			}
		}

		// Token: 0x0600A383 RID: 41859 RVA: 0x002E2E38 File Offset: 0x002E1038
		private void __clearDele_EventOnShowGetPath(BagItemBase arg1, BagListUIController.DisplayType arg2)
		{
			this.EventOnShowGetPath = null;
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x002E2ED8 File Offset: 0x002E10D8
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
					this.m_InitLoopScrollViewRect_hotfix = (luaObj.RawGet("InitLoopScrollViewRect") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_UpdateViewInBagListDisplayTypeUInt64_hotfix = (luaObj.RawGet("UpdateViewInBagList") as LuaFunction);
					this.m_IsBagItemOfDisplayTypeBagItemBase_hotfix = (luaObj.RawGet("IsBagItemOfDisplayType") as LuaFunction);
					this.m_ShowNoItemPanelObjBoolean_hotfix = (luaObj.RawGet("ShowNoItemPanelObj") as LuaFunction);
					this.m_BagItemComparerBagItemBaseBagItemBase_hotfix = (luaObj.RawGet("BagItemComparer") as LuaFunction);
					this.m_OnBagItemClickUIControllerBase_hotfix = (luaObj.RawGet("OnBagItemClick") as LuaFunction);
					this.m_OnBagItemNeedFillUIControllerBase_hotfix = (luaObj.RawGet("OnBagItemNeedFill") as LuaFunction);
					this.m_SetInfoPanelBagItemBase_hotfix = (luaObj.RawGet("SetInfoPanel") as LuaFunction);
					this.m_SetEquipmentInfoEquipmentBagItem_hotfix = (luaObj.RawGet("SetEquipmentInfo") as LuaFunction);
					this.m_SetEquipmentSkillInfoEquipmentBagItem_hotfix = (luaObj.RawGet("SetEquipmentSkillInfo") as LuaFunction);
					this.m_SetEquipmentLimitInfoEquipmentBagItem_hotfix = (luaObj.RawGet("SetEquipmentLimitInfo") as LuaFunction);
					this.m_SetEquipmentEnchantInfoEquipmentBagItem_hotfix = (luaObj.RawGet("SetEquipmentEnchantInfo") as LuaFunction);
					this.m_SetEquipmentPropItemPropertyModifyTypeInt32Int32Int32_hotfix = (luaObj.RawGet("SetEquipmentPropItem") as LuaFunction);
					this.m_SetBagCountLimit_hotfix = (luaObj.RawGet("SetBagCountLimit") as LuaFunction);
					this.m_OnGetItemButtonClick_hotfix = (luaObj.RawGet("OnGetItemButtonClick") as LuaFunction);
					this.m_OnEquipmentForgeButton_hotfix = (luaObj.RawGet("OnEquipmentForgeButton") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_ResetBagUIView_hotfix = (luaObj.RawGet("ResetBagUIView") as LuaFunction);
					this.m_OnAlchemyButtonClick_hotfix = (luaObj.RawGet("OnAlchemyButtonClick") as LuaFunction);
					this.m_OnUseButtonClick_hotfix = (luaObj.RawGet("OnUseButtonClick") as LuaFunction);
					this.m_OnSubItemUseItemClick_hotfix = (luaObj.RawGet("OnSubItemUseItemClick") as LuaFunction);
					this.m_CloseSubItemUsePanel_hotfix = (luaObj.RawGet("CloseSubItemUsePanel") as LuaFunction);
					this.m_OnInputEditEndString_hotfix = (luaObj.RawGet("OnInputEditEnd") as LuaFunction);
					this.m_OnItemMinusButtonClick_hotfix = (luaObj.RawGet("OnItemMinusButtonClick") as LuaFunction);
					this.m_OnItemAddButtonClick_hotfix = (luaObj.RawGet("OnItemAddButtonClick") as LuaFunction);
					this.m_OnItemMaxButtonClick_hotfix = (luaObj.RawGet("OnItemMaxButtonClick") as LuaFunction);
					this.m_OnAddAllItemButtonClick_hotfix = (luaObj.RawGet("OnAddAllItemButtonClick") as LuaFunction);
					this.m_OnAddAllEquipmentButtonClick_hotfix = (luaObj.RawGet("OnAddAllEquipmentButtonClick") as LuaFunction);
					this.m_OnAddItemButtonClick_hotfix = (luaObj.RawGet("OnAddItemButtonClick") as LuaFunction);
					this.m_OnClearBagButtonClick_hotfix = (luaObj.RawGet("OnClearBagButtonClick") as LuaFunction);
					this.m_OnSpeedUpButtonClick_hotfix = (luaObj.RawGet("OnSpeedUpButtonClick") as LuaFunction);
					this.m_ResetScrollViewToTop_hotfix = (luaObj.RawGet("ResetScrollViewToTop") as LuaFunction);
					this.m_CloseBagInfoPanel_hotfix = (luaObj.RawGet("CloseBagInfoPanel") as LuaFunction);
					this.m_OnItemToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnItemToggleValueChanged") as LuaFunction);
					this.m_OnJobMaterialToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnJobMaterialToggleValueChanged") as LuaFunction);
					this.m_OnEquipmentToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnEquipmentToggleValueChanged") as LuaFunction);
					this.m_OnFragmentToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnFragmentToggleValueChanged") as LuaFunction);
					this.m_OnToggleChanged_hotfix = (luaObj.RawGet("OnToggleChanged") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnClearBagAction_hotfix = (luaObj.RawGet("add_EventOnClearBag") as LuaFunction);
					this.m_remove_EventOnClearBagAction_hotfix = (luaObj.RawGet("remove_EventOnClearBag") as LuaFunction);
					this.m_add_EventOnSpeedUpAction`3_hotfix = (luaObj.RawGet("add_EventOnSpeedUp") as LuaFunction);
					this.m_remove_EventOnSpeedUpAction`3_hotfix = (luaObj.RawGet("remove_EventOnSpeedUp") as LuaFunction);
					this.m_add_EventOnAddAllItemAction_hotfix = (luaObj.RawGet("add_EventOnAddAllItem") as LuaFunction);
					this.m_remove_EventOnAddAllItemAction_hotfix = (luaObj.RawGet("remove_EventOnAddAllItem") as LuaFunction);
					this.m_add_EventOnAddAllEquipmentAction_hotfix = (luaObj.RawGet("add_EventOnAddAllEquipment") as LuaFunction);
					this.m_remove_EventOnAddAllEquipmentAction_hotfix = (luaObj.RawGet("remove_EventOnAddAllEquipment") as LuaFunction);
					this.m_add_EventOnAlchemyButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnAlchemyButtonClick") as LuaFunction);
					this.m_remove_EventOnAlchemyButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnAlchemyButtonClick") as LuaFunction);
					this.m_add_EventOnAddItemAction`1_hotfix = (luaObj.RawGet("add_EventOnAddItem") as LuaFunction);
					this.m_remove_EventOnAddItemAction`1_hotfix = (luaObj.RawGet("remove_EventOnAddItem") as LuaFunction);
					this.m_add_EventOnUseAction`4_hotfix = (luaObj.RawGet("add_EventOnUse") as LuaFunction);
					this.m_remove_EventOnUseAction`4_hotfix = (luaObj.RawGet("remove_EventOnUse") as LuaFunction);
					this.m_add_EventOnEquipmentForgeAction`3_hotfix = (luaObj.RawGet("add_EventOnEquipmentForge") as LuaFunction);
					this.m_remove_EventOnEquipmentForgeAction`3_hotfix = (luaObj.RawGet("remove_EventOnEquipmentForge") as LuaFunction);
					this.m_add_EventOnShowGetPathAction`2_hotfix = (luaObj.RawGet("add_EventOnShowGetPath") as LuaFunction);
					this.m_remove_EventOnShowGetPathAction`2_hotfix = (luaObj.RawGet("remove_EventOnShowGetPath") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A388 RID: 41864 RVA: 0x002E3568 File Offset: 0x002E1768
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BagListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006D1C RID: 27932
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04006D1D RID: 27933
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Item", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_itemToggle;

		// Token: 0x04006D1E RID: 27934
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Equipment", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_equipmentToggle;

		// Token: 0x04006D1F RID: 27935
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Fragment", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_fragmentToggle;

		// Token: 0x04006D20 RID: 27936
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/JobMaterial", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_jobMaterialToggle;

		// Token: 0x04006D21 RID: 27937
		[AutoBind("./GoldMetallurgyButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_alchemyButton;

		// Token: 0x04006D22 RID: 27938
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04006D23 RID: 27939
		[AutoBind("./BagListPanel/BagListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private LoopVerticalScrollRect m_loopScrollView;

		// Token: 0x04006D24 RID: 27940
		[AutoBind("./BagListPanel/BagListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private EasyObjectPool m_listItemPool;

		// Token: 0x04006D25 RID: 27941
		[AutoBind("./BagListPanel/BagListScrollView/ItemRoot", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_listScrollViewItemTemplateRoot;

		// Token: 0x04006D26 RID: 27942
		[AutoBind("./BagListPanel/BagListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scrollViewBagItemContent;

		// Token: 0x04006D27 RID: 27943
		[AutoBind("./BagListPanel/BagListScrollView/Viewport/BgContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bagListPointBgContent;

		// Token: 0x04006D28 RID: 27944
		[AutoBind("./BagListPanel/BagListScrollView/Viewport/Point", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bagListPointItem;

		// Token: 0x04006D29 RID: 27945
		[AutoBind("./BagListPanel/NoItemPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noItemPanelObj;

		// Token: 0x04006D2A RID: 27946
		[AutoBind("./BagListPanel/BagInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bagInfoPanelObj;

		// Token: 0x04006D2B RID: 27947
		[AutoBind("./BagListPanel/BagInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_bagInfoStateCtrl;

		// Token: 0x04006D2C RID: 27948
		[AutoBind("./BagListPanel/BagInfoPanel/UseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_useButton;

		// Token: 0x04006D2D RID: 27949
		[AutoBind("./BagListPanel/BagInfoPanel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemNameText;

		// Token: 0x04006D2E RID: 27950
		[AutoBind("./BagListPanel/BagInfoPanel/Count/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemCountText;

		// Token: 0x04006D2F RID: 27951
		[AutoBind("./BagListPanel/BagInfoPanel/Desc/ValueTextScrollView/Mask/Content/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemDescText;

		// Token: 0x04006D30 RID: 27952
		[AutoBind("./BagListPanel/BagInfoPanel/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_itemIconImage;

		// Token: 0x04006D31 RID: 27953
		[AutoBind("./BagListPanel/BagInfoPanel/GetButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_itemGetButton;

		// Token: 0x04006D32 RID: 27954
		[AutoBind("./CountLimit", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_bagCountLimitStateCtrl;

		// Token: 0x04006D33 RID: 27955
		[AutoBind("./CountLimit/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_bagCountText;

		// Token: 0x04006D34 RID: 27956
		[AutoBind("./CountLimit/MaxText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_bagMaxCountText;

		// Token: 0x04006D35 RID: 27957
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/ExplainFrontToggle/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentInfoExplainText;

		// Token: 0x04006D36 RID: 27958
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/ForgeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_equipmentForgeButton;

		// Token: 0x04006D37 RID: 27959
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_equipmentSkillStateCtrl;

		// Token: 0x04006D38 RID: 27960
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/SkillContent/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentSkillNameText;

		// Token: 0x04006D39 RID: 27961
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/SkillContent/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentSkillLvValueText;

		// Token: 0x04006D3A RID: 27962
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/SkillContent/UnlockCoditionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentSkillUnlockCoditionText;

		// Token: 0x04006D3B RID: 27963
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/SkillContent/Owner", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentSkillCharNameText;

		// Token: 0x04006D3C RID: 27964
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/SkillContent/BelongBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentSkillCharNameBGImage;

		// Token: 0x04006D3D RID: 27965
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/SkillContent/DescScrollView/Mask/Content/Desc", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentSkillDescText;

		// Token: 0x04006D3E RID: 27966
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_equipmentSkillContentStateCtrl;

		// Token: 0x04006D3F RID: 27967
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/EquipGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_equipmentLimitStateCtrl;

		// Token: 0x04006D40 RID: 27968
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/EquipGroup/EquipLimitContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentLimitContent;

		// Token: 0x04006D41 RID: 27969
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/EquipGroup/EquipUnlimitText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentEquipUnlimitText;

		// Token: 0x04006D42 RID: 27970
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentPropertyGroup;

		// Token: 0x04006D43 RID: 27971
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/AT", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentPropATGo;

		// Token: 0x04006D44 RID: 27972
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentPropATValueText;

		// Token: 0x04006D45 RID: 27973
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/DF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentPropDFGo;

		// Token: 0x04006D46 RID: 27974
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentPropDFValueText;

		// Token: 0x04006D47 RID: 27975
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/HP", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentPropHPGo;

		// Token: 0x04006D48 RID: 27976
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentPropHPValueText;

		// Token: 0x04006D49 RID: 27977
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentPropMagiccGo;

		// Token: 0x04006D4A RID: 27978
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/Magic/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentPropMagicValueText;

		// Token: 0x04006D4B RID: 27979
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/MagicDF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentPropMagicDFGo;

		// Token: 0x04006D4C RID: 27980
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentPropMagicDFValueText;

		// Token: 0x04006D4D RID: 27981
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/Dex", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentPropDexGo;

		// Token: 0x04006D4E RID: 27982
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/Dex/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentPropDexValueText;

		// Token: 0x04006D4F RID: 27983
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_equipmentPropGroupStateCtrl;

		// Token: 0x04006D50 RID: 27984
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/PropertyFrontToggle/Detail/PropGroup/EnchantmentGroup/PropertyGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentPropEnchantmentGroup;

		// Token: 0x04006D51 RID: 27985
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/Resonance", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentPropEnchantmentGroupResonanceGo;

		// Token: 0x04006D52 RID: 27986
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/Resonance", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_equipmentPropEnchantmentGroupRuneStateCtrl;

		// Token: 0x04006D53 RID: 27987
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/Resonance/RuneIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_equipmentPropEnchantmentGroupRuneIconImage;

		// Token: 0x04006D54 RID: 27988
		[AutoBind("./BagListPanel/BagInfoPanel/EquipInfo/Resonance/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentPropEnchantmentGroupRuneNameText;

		// Token: 0x04006D55 RID: 27989
		[AutoBind("./UseItemsPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_subBagInfoPanelObj;

		// Token: 0x04006D56 RID: 27990
		[AutoBind("./UseItemsPanel/PanelDetail/Minus", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subItemMinusButton;

		// Token: 0x04006D57 RID: 27991
		[AutoBind("./UseItemsPanel/PanelDetail/Add", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subItemAddButton;

		// Token: 0x04006D58 RID: 27992
		[AutoBind("./UseItemsPanel/PanelDetail/Max", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subItemMaxButton;

		// Token: 0x04006D59 RID: 27993
		[AutoBind("./UseItemsPanel/PanelDetail/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_subItemNumInputField;

		// Token: 0x04006D5A RID: 27994
		[AutoBind("./UseItemsPanel/PanelDetail/UseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subItemUseButton;

		// Token: 0x04006D5B RID: 27995
		[AutoBind("./UseItemsPanel/ReturnImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subItemPanelReturnButton;

		// Token: 0x04006D5C RID: 27996
		[AutoBind("./AddAllItemButton", AutoBindAttribute.InitState.Inactive, false)]
		private Button m_addAllItemButton;

		// Token: 0x04006D5D RID: 27997
		[AutoBind("./AddAllEquipmentButton", AutoBindAttribute.InitState.Inactive, false)]
		private Button m_addAllEquipmentButton;

		// Token: 0x04006D5E RID: 27998
		[AutoBind("./AddBagItemButton", AutoBindAttribute.InitState.Inactive, false)]
		private Button m_addItemButton;

		// Token: 0x04006D5F RID: 27999
		[AutoBind("./ClearBagButton", AutoBindAttribute.InitState.Inactive, false)]
		private Button m_clearBagItemButton;

		// Token: 0x04006D60 RID: 28000
		[AutoBind("./BagItemInputField", AutoBindAttribute.InitState.Inactive, false)]
		private InputField m_bagItemInputField;

		// Token: 0x04006D61 RID: 28001
		[AutoBind("./SpeedUpButton", AutoBindAttribute.InitState.Inactive, false)]
		private Button m_speedUpButton;

		// Token: 0x04006D62 RID: 28002
		private BagListUIController.DisplayType m_displayType = BagListUIController.DisplayType.Item;

		// Token: 0x04006D63 RID: 28003
		private BagItemBase m_lastClickBagItem;

		// Token: 0x04006D64 RID: 28004
		private BagListUIController.DisplayType m_lastClickBagItemType;

		// Token: 0x04006D65 RID: 28005
		private List<BagItemBase> m_bagItemCache = new List<BagItemBase>();

		// Token: 0x04006D66 RID: 28006
		private List<BagItemUIController> m_bagItemCtrlList = new List<BagItemUIController>();

		// Token: 0x04006D67 RID: 28007
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04006D68 RID: 28008
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04006D69 RID: 28009
		[DoNotToLua]
		private BagListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006D6A RID: 28010
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006D6B RID: 28011
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006D6C RID: 28012
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006D6D RID: 28013
		private LuaFunction m_InitLoopScrollViewRect_hotfix;

		// Token: 0x04006D6E RID: 28014
		private LuaFunction m_Open_hotfix;

		// Token: 0x04006D6F RID: 28015
		private LuaFunction m_UpdateViewInBagListDisplayTypeUInt64_hotfix;

		// Token: 0x04006D70 RID: 28016
		private LuaFunction m_IsBagItemOfDisplayTypeBagItemBase_hotfix;

		// Token: 0x04006D71 RID: 28017
		private LuaFunction m_ShowNoItemPanelObjBoolean_hotfix;

		// Token: 0x04006D72 RID: 28018
		private LuaFunction m_BagItemComparerBagItemBaseBagItemBase_hotfix;

		// Token: 0x04006D73 RID: 28019
		private LuaFunction m_OnBagItemClickUIControllerBase_hotfix;

		// Token: 0x04006D74 RID: 28020
		private LuaFunction m_OnBagItemNeedFillUIControllerBase_hotfix;

		// Token: 0x04006D75 RID: 28021
		private LuaFunction m_SetInfoPanelBagItemBase_hotfix;

		// Token: 0x04006D76 RID: 28022
		private LuaFunction m_SetEquipmentInfoEquipmentBagItem_hotfix;

		// Token: 0x04006D77 RID: 28023
		private LuaFunction m_SetEquipmentSkillInfoEquipmentBagItem_hotfix;

		// Token: 0x04006D78 RID: 28024
		private LuaFunction m_SetEquipmentLimitInfoEquipmentBagItem_hotfix;

		// Token: 0x04006D79 RID: 28025
		private LuaFunction m_SetEquipmentEnchantInfoEquipmentBagItem_hotfix;

		// Token: 0x04006D7A RID: 28026
		private LuaFunction m_SetEquipmentPropItemPropertyModifyTypeInt32Int32Int32_hotfix;

		// Token: 0x04006D7B RID: 28027
		private LuaFunction m_SetBagCountLimit_hotfix;

		// Token: 0x04006D7C RID: 28028
		private LuaFunction m_OnGetItemButtonClick_hotfix;

		// Token: 0x04006D7D RID: 28029
		private LuaFunction m_OnEquipmentForgeButton_hotfix;

		// Token: 0x04006D7E RID: 28030
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04006D7F RID: 28031
		private LuaFunction m_ResetBagUIView_hotfix;

		// Token: 0x04006D80 RID: 28032
		private LuaFunction m_OnAlchemyButtonClick_hotfix;

		// Token: 0x04006D81 RID: 28033
		private LuaFunction m_OnUseButtonClick_hotfix;

		// Token: 0x04006D82 RID: 28034
		private LuaFunction m_OnSubItemUseItemClick_hotfix;

		// Token: 0x04006D83 RID: 28035
		private LuaFunction m_CloseSubItemUsePanel_hotfix;

		// Token: 0x04006D84 RID: 28036
		private LuaFunction m_OnInputEditEndString_hotfix;

		// Token: 0x04006D85 RID: 28037
		private LuaFunction m_OnItemMinusButtonClick_hotfix;

		// Token: 0x04006D86 RID: 28038
		private LuaFunction m_OnItemAddButtonClick_hotfix;

		// Token: 0x04006D87 RID: 28039
		private LuaFunction m_OnItemMaxButtonClick_hotfix;

		// Token: 0x04006D88 RID: 28040
		private LuaFunction m_OnAddAllItemButtonClick_hotfix;

		// Token: 0x04006D89 RID: 28041
		private LuaFunction m_OnAddAllEquipmentButtonClick_hotfix;

		// Token: 0x04006D8A RID: 28042
		private LuaFunction m_OnAddItemButtonClick_hotfix;

		// Token: 0x04006D8B RID: 28043
		private LuaFunction m_OnClearBagButtonClick_hotfix;

		// Token: 0x04006D8C RID: 28044
		private LuaFunction m_OnSpeedUpButtonClick_hotfix;

		// Token: 0x04006D8D RID: 28045
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x04006D8E RID: 28046
		private LuaFunction m_CloseBagInfoPanel_hotfix;

		// Token: 0x04006D8F RID: 28047
		private LuaFunction m_OnItemToggleValueChangedBoolean_hotfix;

		// Token: 0x04006D90 RID: 28048
		private LuaFunction m_OnJobMaterialToggleValueChangedBoolean_hotfix;

		// Token: 0x04006D91 RID: 28049
		private LuaFunction m_OnEquipmentToggleValueChangedBoolean_hotfix;

		// Token: 0x04006D92 RID: 28050
		private LuaFunction m_OnFragmentToggleValueChangedBoolean_hotfix;

		// Token: 0x04006D93 RID: 28051
		private LuaFunction m_OnToggleChanged_hotfix;

		// Token: 0x04006D94 RID: 28052
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04006D95 RID: 28053
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04006D96 RID: 28054
		private LuaFunction m_add_EventOnClearBagAction_hotfix;

		// Token: 0x04006D97 RID: 28055
		private LuaFunction m_remove_EventOnClearBagAction_hotfix;

		// Token: 0x04006D98 RID: 28056
		private LuaFunction m_add_EventOnSpeedUpAction;

		// Token: 0x04006D99 RID: 28057
		private LuaFunction m_remove_EventOnSpeedUpAction;

		// Token: 0x04006D9A RID: 28058
		private LuaFunction m_add_EventOnAddAllItemAction_hotfix;

		// Token: 0x04006D9B RID: 28059
		private LuaFunction m_remove_EventOnAddAllItemAction_hotfix;

		// Token: 0x04006D9C RID: 28060
		private LuaFunction m_add_EventOnAddAllEquipmentAction_hotfix;

		// Token: 0x04006D9D RID: 28061
		private LuaFunction m_remove_EventOnAddAllEquipmentAction_hotfix;

		// Token: 0x04006D9E RID: 28062
		private LuaFunction m_add_EventOnAlchemyButtonClickAction_hotfix;

		// Token: 0x04006D9F RID: 28063
		private LuaFunction m_remove_EventOnAlchemyButtonClickAction_hotfix;

		// Token: 0x04006DA0 RID: 28064
		private LuaFunction m_add_EventOnAddItemAction;

		// Token: 0x04006DA1 RID: 28065
		private LuaFunction m_remove_EventOnAddItemAction;

		// Token: 0x04006DA2 RID: 28066
		private LuaFunction m_add_EventOnUseAction;

		// Token: 0x04006DA3 RID: 28067
		private LuaFunction m_remove_EventOnUseAction;

		// Token: 0x04006DA4 RID: 28068
		private LuaFunction m_add_EventOnEquipmentForgeAction;

		// Token: 0x04006DA5 RID: 28069
		private LuaFunction m_remove_EventOnEquipmentForgeAction;

		// Token: 0x04006DA6 RID: 28070
		private LuaFunction m_add_EventOnShowGetPathAction;

		// Token: 0x04006DA7 RID: 28071
		private LuaFunction m_remove_EventOnShowGetPathAction;

		// Token: 0x02000A50 RID: 2640
		public enum DisplayType
		{
			// Token: 0x04006DA9 RID: 28073
			None,
			// Token: 0x04006DAA RID: 28074
			Item,
			// Token: 0x04006DAB RID: 28075
			Fragment,
			// Token: 0x04006DAC RID: 28076
			JobMaterial,
			// Token: 0x04006DAD RID: 28077
			Equipment
		}

		// Token: 0x02000A51 RID: 2641
		public new class LuaExportHelper
		{
			// Token: 0x0600A389 RID: 41865 RVA: 0x002E35D0 File Offset: 0x002E17D0
			public LuaExportHelper(BagListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A38A RID: 41866 RVA: 0x002E35E0 File Offset: 0x002E17E0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A38B RID: 41867 RVA: 0x002E35F0 File Offset: 0x002E17F0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A38C RID: 41868 RVA: 0x002E3600 File Offset: 0x002E1800
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A38D RID: 41869 RVA: 0x002E3610 File Offset: 0x002E1810
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A38E RID: 41870 RVA: 0x002E3628 File Offset: 0x002E1828
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A38F RID: 41871 RVA: 0x002E3638 File Offset: 0x002E1838
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A390 RID: 41872 RVA: 0x002E3648 File Offset: 0x002E1848
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A391 RID: 41873 RVA: 0x002E3658 File Offset: 0x002E1858
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A392 RID: 41874 RVA: 0x002E3668 File Offset: 0x002E1868
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A393 RID: 41875 RVA: 0x002E3678 File Offset: 0x002E1878
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A394 RID: 41876 RVA: 0x002E3688 File Offset: 0x002E1888
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A395 RID: 41877 RVA: 0x002E3698 File Offset: 0x002E1898
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A396 RID: 41878 RVA: 0x002E36A8 File Offset: 0x002E18A8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A397 RID: 41879 RVA: 0x002E36B8 File Offset: 0x002E18B8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A398 RID: 41880 RVA: 0x002E36C8 File Offset: 0x002E18C8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600A399 RID: 41881 RVA: 0x002E36D8 File Offset: 0x002E18D8
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600A39A RID: 41882 RVA: 0x002E36E8 File Offset: 0x002E18E8
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600A39B RID: 41883 RVA: 0x002E36F8 File Offset: 0x002E18F8
			public void __callDele_EventOnClearBag()
			{
				this.m_owner.__callDele_EventOnClearBag();
			}

			// Token: 0x0600A39C RID: 41884 RVA: 0x002E3708 File Offset: 0x002E1908
			public void __clearDele_EventOnClearBag()
			{
				this.m_owner.__clearDele_EventOnClearBag();
			}

			// Token: 0x0600A39D RID: 41885 RVA: 0x002E3718 File Offset: 0x002E1918
			public void __callDele_EventOnSpeedUp(int arg1, ulong arg2, BagListUIController.DisplayType arg3)
			{
				this.m_owner.__callDele_EventOnSpeedUp(arg1, arg2, arg3);
			}

			// Token: 0x0600A39E RID: 41886 RVA: 0x002E3728 File Offset: 0x002E1928
			public void __clearDele_EventOnSpeedUp(int arg1, ulong arg2, BagListUIController.DisplayType arg3)
			{
				this.m_owner.__clearDele_EventOnSpeedUp(arg1, arg2, arg3);
			}

			// Token: 0x0600A39F RID: 41887 RVA: 0x002E3738 File Offset: 0x002E1938
			public void __callDele_EventOnAddAllItem()
			{
				this.m_owner.__callDele_EventOnAddAllItem();
			}

			// Token: 0x0600A3A0 RID: 41888 RVA: 0x002E3748 File Offset: 0x002E1948
			public void __clearDele_EventOnAddAllItem()
			{
				this.m_owner.__clearDele_EventOnAddAllItem();
			}

			// Token: 0x0600A3A1 RID: 41889 RVA: 0x002E3758 File Offset: 0x002E1958
			public void __callDele_EventOnAddAllEquipment()
			{
				this.m_owner.__callDele_EventOnAddAllEquipment();
			}

			// Token: 0x0600A3A2 RID: 41890 RVA: 0x002E3768 File Offset: 0x002E1968
			public void __clearDele_EventOnAddAllEquipment()
			{
				this.m_owner.__clearDele_EventOnAddAllEquipment();
			}

			// Token: 0x0600A3A3 RID: 41891 RVA: 0x002E3778 File Offset: 0x002E1978
			public void __callDele_EventOnAlchemyButtonClick()
			{
				this.m_owner.__callDele_EventOnAlchemyButtonClick();
			}

			// Token: 0x0600A3A4 RID: 41892 RVA: 0x002E3788 File Offset: 0x002E1988
			public void __clearDele_EventOnAlchemyButtonClick()
			{
				this.m_owner.__clearDele_EventOnAlchemyButtonClick();
			}

			// Token: 0x0600A3A5 RID: 41893 RVA: 0x002E3798 File Offset: 0x002E1998
			public void __callDele_EventOnAddItem(string obj)
			{
				this.m_owner.__callDele_EventOnAddItem(obj);
			}

			// Token: 0x0600A3A6 RID: 41894 RVA: 0x002E37A8 File Offset: 0x002E19A8
			public void __clearDele_EventOnAddItem(string obj)
			{
				this.m_owner.__clearDele_EventOnAddItem(obj);
			}

			// Token: 0x0600A3A7 RID: 41895 RVA: 0x002E37B8 File Offset: 0x002E19B8
			public void __callDele_EventOnUse(GoodsType arg1, int arg2, int arg3, BagListUIController.DisplayType arg4)
			{
				this.m_owner.__callDele_EventOnUse(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600A3A8 RID: 41896 RVA: 0x002E37CC File Offset: 0x002E19CC
			public void __clearDele_EventOnUse(GoodsType arg1, int arg2, int arg3, BagListUIController.DisplayType arg4)
			{
				this.m_owner.__clearDele_EventOnUse(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600A3A9 RID: 41897 RVA: 0x002E37E0 File Offset: 0x002E19E0
			public void __callDele_EventOnEquipmentForge(int arg1, ulong arg2, BagListUIController.DisplayType arg3)
			{
				this.m_owner.__callDele_EventOnEquipmentForge(arg1, arg2, arg3);
			}

			// Token: 0x0600A3AA RID: 41898 RVA: 0x002E37F0 File Offset: 0x002E19F0
			public void __clearDele_EventOnEquipmentForge(int arg1, ulong arg2, BagListUIController.DisplayType arg3)
			{
				this.m_owner.__clearDele_EventOnEquipmentForge(arg1, arg2, arg3);
			}

			// Token: 0x0600A3AB RID: 41899 RVA: 0x002E3800 File Offset: 0x002E1A00
			public void __callDele_EventOnShowGetPath(BagItemBase arg1, BagListUIController.DisplayType arg2)
			{
				this.m_owner.__callDele_EventOnShowGetPath(arg1, arg2);
			}

			// Token: 0x0600A3AC RID: 41900 RVA: 0x002E3810 File Offset: 0x002E1A10
			public void __clearDele_EventOnShowGetPath(BagItemBase arg1, BagListUIController.DisplayType arg2)
			{
				this.m_owner.__clearDele_EventOnShowGetPath(arg1, arg2);
			}

			// Token: 0x17002118 RID: 8472
			// (get) Token: 0x0600A3AD RID: 41901 RVA: 0x002E3820 File Offset: 0x002E1A20
			// (set) Token: 0x0600A3AE RID: 41902 RVA: 0x002E3830 File Offset: 0x002E1A30
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

			// Token: 0x17002119 RID: 8473
			// (get) Token: 0x0600A3AF RID: 41903 RVA: 0x002E3840 File Offset: 0x002E1A40
			// (set) Token: 0x0600A3B0 RID: 41904 RVA: 0x002E3850 File Offset: 0x002E1A50
			public Toggle m_itemToggle
			{
				get
				{
					return this.m_owner.m_itemToggle;
				}
				set
				{
					this.m_owner.m_itemToggle = value;
				}
			}

			// Token: 0x1700211A RID: 8474
			// (get) Token: 0x0600A3B1 RID: 41905 RVA: 0x002E3860 File Offset: 0x002E1A60
			// (set) Token: 0x0600A3B2 RID: 41906 RVA: 0x002E3870 File Offset: 0x002E1A70
			public Toggle m_equipmentToggle
			{
				get
				{
					return this.m_owner.m_equipmentToggle;
				}
				set
				{
					this.m_owner.m_equipmentToggle = value;
				}
			}

			// Token: 0x1700211B RID: 8475
			// (get) Token: 0x0600A3B3 RID: 41907 RVA: 0x002E3880 File Offset: 0x002E1A80
			// (set) Token: 0x0600A3B4 RID: 41908 RVA: 0x002E3890 File Offset: 0x002E1A90
			public Toggle m_fragmentToggle
			{
				get
				{
					return this.m_owner.m_fragmentToggle;
				}
				set
				{
					this.m_owner.m_fragmentToggle = value;
				}
			}

			// Token: 0x1700211C RID: 8476
			// (get) Token: 0x0600A3B5 RID: 41909 RVA: 0x002E38A0 File Offset: 0x002E1AA0
			// (set) Token: 0x0600A3B6 RID: 41910 RVA: 0x002E38B0 File Offset: 0x002E1AB0
			public Toggle m_jobMaterialToggle
			{
				get
				{
					return this.m_owner.m_jobMaterialToggle;
				}
				set
				{
					this.m_owner.m_jobMaterialToggle = value;
				}
			}

			// Token: 0x1700211D RID: 8477
			// (get) Token: 0x0600A3B7 RID: 41911 RVA: 0x002E38C0 File Offset: 0x002E1AC0
			// (set) Token: 0x0600A3B8 RID: 41912 RVA: 0x002E38D0 File Offset: 0x002E1AD0
			public Button m_alchemyButton
			{
				get
				{
					return this.m_owner.m_alchemyButton;
				}
				set
				{
					this.m_owner.m_alchemyButton = value;
				}
			}

			// Token: 0x1700211E RID: 8478
			// (get) Token: 0x0600A3B9 RID: 41913 RVA: 0x002E38E0 File Offset: 0x002E1AE0
			// (set) Token: 0x0600A3BA RID: 41914 RVA: 0x002E38F0 File Offset: 0x002E1AF0
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

			// Token: 0x1700211F RID: 8479
			// (get) Token: 0x0600A3BB RID: 41915 RVA: 0x002E3900 File Offset: 0x002E1B00
			// (set) Token: 0x0600A3BC RID: 41916 RVA: 0x002E3910 File Offset: 0x002E1B10
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

			// Token: 0x17002120 RID: 8480
			// (get) Token: 0x0600A3BD RID: 41917 RVA: 0x002E3920 File Offset: 0x002E1B20
			// (set) Token: 0x0600A3BE RID: 41918 RVA: 0x002E3930 File Offset: 0x002E1B30
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

			// Token: 0x17002121 RID: 8481
			// (get) Token: 0x0600A3BF RID: 41919 RVA: 0x002E3940 File Offset: 0x002E1B40
			// (set) Token: 0x0600A3C0 RID: 41920 RVA: 0x002E3950 File Offset: 0x002E1B50
			public GameObject m_listScrollViewItemTemplateRoot
			{
				get
				{
					return this.m_owner.m_listScrollViewItemTemplateRoot;
				}
				set
				{
					this.m_owner.m_listScrollViewItemTemplateRoot = value;
				}
			}

			// Token: 0x17002122 RID: 8482
			// (get) Token: 0x0600A3C1 RID: 41921 RVA: 0x002E3960 File Offset: 0x002E1B60
			// (set) Token: 0x0600A3C2 RID: 41922 RVA: 0x002E3970 File Offset: 0x002E1B70
			public GameObject m_scrollViewBagItemContent
			{
				get
				{
					return this.m_owner.m_scrollViewBagItemContent;
				}
				set
				{
					this.m_owner.m_scrollViewBagItemContent = value;
				}
			}

			// Token: 0x17002123 RID: 8483
			// (get) Token: 0x0600A3C3 RID: 41923 RVA: 0x002E3980 File Offset: 0x002E1B80
			// (set) Token: 0x0600A3C4 RID: 41924 RVA: 0x002E3990 File Offset: 0x002E1B90
			public GameObject m_bagListPointBgContent
			{
				get
				{
					return this.m_owner.m_bagListPointBgContent;
				}
				set
				{
					this.m_owner.m_bagListPointBgContent = value;
				}
			}

			// Token: 0x17002124 RID: 8484
			// (get) Token: 0x0600A3C5 RID: 41925 RVA: 0x002E39A0 File Offset: 0x002E1BA0
			// (set) Token: 0x0600A3C6 RID: 41926 RVA: 0x002E39B0 File Offset: 0x002E1BB0
			public GameObject m_bagListPointItem
			{
				get
				{
					return this.m_owner.m_bagListPointItem;
				}
				set
				{
					this.m_owner.m_bagListPointItem = value;
				}
			}

			// Token: 0x17002125 RID: 8485
			// (get) Token: 0x0600A3C7 RID: 41927 RVA: 0x002E39C0 File Offset: 0x002E1BC0
			// (set) Token: 0x0600A3C8 RID: 41928 RVA: 0x002E39D0 File Offset: 0x002E1BD0
			public GameObject m_noItemPanelObj
			{
				get
				{
					return this.m_owner.m_noItemPanelObj;
				}
				set
				{
					this.m_owner.m_noItemPanelObj = value;
				}
			}

			// Token: 0x17002126 RID: 8486
			// (get) Token: 0x0600A3C9 RID: 41929 RVA: 0x002E39E0 File Offset: 0x002E1BE0
			// (set) Token: 0x0600A3CA RID: 41930 RVA: 0x002E39F0 File Offset: 0x002E1BF0
			public GameObject m_bagInfoPanelObj
			{
				get
				{
					return this.m_owner.m_bagInfoPanelObj;
				}
				set
				{
					this.m_owner.m_bagInfoPanelObj = value;
				}
			}

			// Token: 0x17002127 RID: 8487
			// (get) Token: 0x0600A3CB RID: 41931 RVA: 0x002E3A00 File Offset: 0x002E1C00
			// (set) Token: 0x0600A3CC RID: 41932 RVA: 0x002E3A10 File Offset: 0x002E1C10
			public CommonUIStateController m_bagInfoStateCtrl
			{
				get
				{
					return this.m_owner.m_bagInfoStateCtrl;
				}
				set
				{
					this.m_owner.m_bagInfoStateCtrl = value;
				}
			}

			// Token: 0x17002128 RID: 8488
			// (get) Token: 0x0600A3CD RID: 41933 RVA: 0x002E3A20 File Offset: 0x002E1C20
			// (set) Token: 0x0600A3CE RID: 41934 RVA: 0x002E3A30 File Offset: 0x002E1C30
			public Button m_useButton
			{
				get
				{
					return this.m_owner.m_useButton;
				}
				set
				{
					this.m_owner.m_useButton = value;
				}
			}

			// Token: 0x17002129 RID: 8489
			// (get) Token: 0x0600A3CF RID: 41935 RVA: 0x002E3A40 File Offset: 0x002E1C40
			// (set) Token: 0x0600A3D0 RID: 41936 RVA: 0x002E3A50 File Offset: 0x002E1C50
			public Text m_itemNameText
			{
				get
				{
					return this.m_owner.m_itemNameText;
				}
				set
				{
					this.m_owner.m_itemNameText = value;
				}
			}

			// Token: 0x1700212A RID: 8490
			// (get) Token: 0x0600A3D1 RID: 41937 RVA: 0x002E3A60 File Offset: 0x002E1C60
			// (set) Token: 0x0600A3D2 RID: 41938 RVA: 0x002E3A70 File Offset: 0x002E1C70
			public Text m_itemCountText
			{
				get
				{
					return this.m_owner.m_itemCountText;
				}
				set
				{
					this.m_owner.m_itemCountText = value;
				}
			}

			// Token: 0x1700212B RID: 8491
			// (get) Token: 0x0600A3D3 RID: 41939 RVA: 0x002E3A80 File Offset: 0x002E1C80
			// (set) Token: 0x0600A3D4 RID: 41940 RVA: 0x002E3A90 File Offset: 0x002E1C90
			public Text m_itemDescText
			{
				get
				{
					return this.m_owner.m_itemDescText;
				}
				set
				{
					this.m_owner.m_itemDescText = value;
				}
			}

			// Token: 0x1700212C RID: 8492
			// (get) Token: 0x0600A3D5 RID: 41941 RVA: 0x002E3AA0 File Offset: 0x002E1CA0
			// (set) Token: 0x0600A3D6 RID: 41942 RVA: 0x002E3AB0 File Offset: 0x002E1CB0
			public Image m_itemIconImage
			{
				get
				{
					return this.m_owner.m_itemIconImage;
				}
				set
				{
					this.m_owner.m_itemIconImage = value;
				}
			}

			// Token: 0x1700212D RID: 8493
			// (get) Token: 0x0600A3D7 RID: 41943 RVA: 0x002E3AC0 File Offset: 0x002E1CC0
			// (set) Token: 0x0600A3D8 RID: 41944 RVA: 0x002E3AD0 File Offset: 0x002E1CD0
			public Button m_itemGetButton
			{
				get
				{
					return this.m_owner.m_itemGetButton;
				}
				set
				{
					this.m_owner.m_itemGetButton = value;
				}
			}

			// Token: 0x1700212E RID: 8494
			// (get) Token: 0x0600A3D9 RID: 41945 RVA: 0x002E3AE0 File Offset: 0x002E1CE0
			// (set) Token: 0x0600A3DA RID: 41946 RVA: 0x002E3AF0 File Offset: 0x002E1CF0
			public CommonUIStateController m_bagCountLimitStateCtrl
			{
				get
				{
					return this.m_owner.m_bagCountLimitStateCtrl;
				}
				set
				{
					this.m_owner.m_bagCountLimitStateCtrl = value;
				}
			}

			// Token: 0x1700212F RID: 8495
			// (get) Token: 0x0600A3DB RID: 41947 RVA: 0x002E3B00 File Offset: 0x002E1D00
			// (set) Token: 0x0600A3DC RID: 41948 RVA: 0x002E3B10 File Offset: 0x002E1D10
			public Text m_bagCountText
			{
				get
				{
					return this.m_owner.m_bagCountText;
				}
				set
				{
					this.m_owner.m_bagCountText = value;
				}
			}

			// Token: 0x17002130 RID: 8496
			// (get) Token: 0x0600A3DD RID: 41949 RVA: 0x002E3B20 File Offset: 0x002E1D20
			// (set) Token: 0x0600A3DE RID: 41950 RVA: 0x002E3B30 File Offset: 0x002E1D30
			public Text m_bagMaxCountText
			{
				get
				{
					return this.m_owner.m_bagMaxCountText;
				}
				set
				{
					this.m_owner.m_bagMaxCountText = value;
				}
			}

			// Token: 0x17002131 RID: 8497
			// (get) Token: 0x0600A3DF RID: 41951 RVA: 0x002E3B40 File Offset: 0x002E1D40
			// (set) Token: 0x0600A3E0 RID: 41952 RVA: 0x002E3B50 File Offset: 0x002E1D50
			public Text m_equipmentInfoExplainText
			{
				get
				{
					return this.m_owner.m_equipmentInfoExplainText;
				}
				set
				{
					this.m_owner.m_equipmentInfoExplainText = value;
				}
			}

			// Token: 0x17002132 RID: 8498
			// (get) Token: 0x0600A3E1 RID: 41953 RVA: 0x002E3B60 File Offset: 0x002E1D60
			// (set) Token: 0x0600A3E2 RID: 41954 RVA: 0x002E3B70 File Offset: 0x002E1D70
			public Button m_equipmentForgeButton
			{
				get
				{
					return this.m_owner.m_equipmentForgeButton;
				}
				set
				{
					this.m_owner.m_equipmentForgeButton = value;
				}
			}

			// Token: 0x17002133 RID: 8499
			// (get) Token: 0x0600A3E3 RID: 41955 RVA: 0x002E3B80 File Offset: 0x002E1D80
			// (set) Token: 0x0600A3E4 RID: 41956 RVA: 0x002E3B90 File Offset: 0x002E1D90
			public CommonUIStateController m_equipmentSkillStateCtrl
			{
				get
				{
					return this.m_owner.m_equipmentSkillStateCtrl;
				}
				set
				{
					this.m_owner.m_equipmentSkillStateCtrl = value;
				}
			}

			// Token: 0x17002134 RID: 8500
			// (get) Token: 0x0600A3E5 RID: 41957 RVA: 0x002E3BA0 File Offset: 0x002E1DA0
			// (set) Token: 0x0600A3E6 RID: 41958 RVA: 0x002E3BB0 File Offset: 0x002E1DB0
			public Text m_equipmentSkillNameText
			{
				get
				{
					return this.m_owner.m_equipmentSkillNameText;
				}
				set
				{
					this.m_owner.m_equipmentSkillNameText = value;
				}
			}

			// Token: 0x17002135 RID: 8501
			// (get) Token: 0x0600A3E7 RID: 41959 RVA: 0x002E3BC0 File Offset: 0x002E1DC0
			// (set) Token: 0x0600A3E8 RID: 41960 RVA: 0x002E3BD0 File Offset: 0x002E1DD0
			public Text m_equipmentSkillLvValueText
			{
				get
				{
					return this.m_owner.m_equipmentSkillLvValueText;
				}
				set
				{
					this.m_owner.m_equipmentSkillLvValueText = value;
				}
			}

			// Token: 0x17002136 RID: 8502
			// (get) Token: 0x0600A3E9 RID: 41961 RVA: 0x002E3BE0 File Offset: 0x002E1DE0
			// (set) Token: 0x0600A3EA RID: 41962 RVA: 0x002E3BF0 File Offset: 0x002E1DF0
			public Text m_equipmentSkillUnlockCoditionText
			{
				get
				{
					return this.m_owner.m_equipmentSkillUnlockCoditionText;
				}
				set
				{
					this.m_owner.m_equipmentSkillUnlockCoditionText = value;
				}
			}

			// Token: 0x17002137 RID: 8503
			// (get) Token: 0x0600A3EB RID: 41963 RVA: 0x002E3C00 File Offset: 0x002E1E00
			// (set) Token: 0x0600A3EC RID: 41964 RVA: 0x002E3C10 File Offset: 0x002E1E10
			public Text m_equipmentSkillCharNameText
			{
				get
				{
					return this.m_owner.m_equipmentSkillCharNameText;
				}
				set
				{
					this.m_owner.m_equipmentSkillCharNameText = value;
				}
			}

			// Token: 0x17002138 RID: 8504
			// (get) Token: 0x0600A3ED RID: 41965 RVA: 0x002E3C20 File Offset: 0x002E1E20
			// (set) Token: 0x0600A3EE RID: 41966 RVA: 0x002E3C30 File Offset: 0x002E1E30
			public GameObject m_equipmentSkillCharNameBGImage
			{
				get
				{
					return this.m_owner.m_equipmentSkillCharNameBGImage;
				}
				set
				{
					this.m_owner.m_equipmentSkillCharNameBGImage = value;
				}
			}

			// Token: 0x17002139 RID: 8505
			// (get) Token: 0x0600A3EF RID: 41967 RVA: 0x002E3C40 File Offset: 0x002E1E40
			// (set) Token: 0x0600A3F0 RID: 41968 RVA: 0x002E3C50 File Offset: 0x002E1E50
			public Text m_equipmentSkillDescText
			{
				get
				{
					return this.m_owner.m_equipmentSkillDescText;
				}
				set
				{
					this.m_owner.m_equipmentSkillDescText = value;
				}
			}

			// Token: 0x1700213A RID: 8506
			// (get) Token: 0x0600A3F1 RID: 41969 RVA: 0x002E3C60 File Offset: 0x002E1E60
			// (set) Token: 0x0600A3F2 RID: 41970 RVA: 0x002E3C70 File Offset: 0x002E1E70
			public CommonUIStateController m_equipmentSkillContentStateCtrl
			{
				get
				{
					return this.m_owner.m_equipmentSkillContentStateCtrl;
				}
				set
				{
					this.m_owner.m_equipmentSkillContentStateCtrl = value;
				}
			}

			// Token: 0x1700213B RID: 8507
			// (get) Token: 0x0600A3F3 RID: 41971 RVA: 0x002E3C80 File Offset: 0x002E1E80
			// (set) Token: 0x0600A3F4 RID: 41972 RVA: 0x002E3C90 File Offset: 0x002E1E90
			public CommonUIStateController m_equipmentLimitStateCtrl
			{
				get
				{
					return this.m_owner.m_equipmentLimitStateCtrl;
				}
				set
				{
					this.m_owner.m_equipmentLimitStateCtrl = value;
				}
			}

			// Token: 0x1700213C RID: 8508
			// (get) Token: 0x0600A3F5 RID: 41973 RVA: 0x002E3CA0 File Offset: 0x002E1EA0
			// (set) Token: 0x0600A3F6 RID: 41974 RVA: 0x002E3CB0 File Offset: 0x002E1EB0
			public GameObject m_equipmentLimitContent
			{
				get
				{
					return this.m_owner.m_equipmentLimitContent;
				}
				set
				{
					this.m_owner.m_equipmentLimitContent = value;
				}
			}

			// Token: 0x1700213D RID: 8509
			// (get) Token: 0x0600A3F7 RID: 41975 RVA: 0x002E3CC0 File Offset: 0x002E1EC0
			// (set) Token: 0x0600A3F8 RID: 41976 RVA: 0x002E3CD0 File Offset: 0x002E1ED0
			public Text m_equipmentEquipUnlimitText
			{
				get
				{
					return this.m_owner.m_equipmentEquipUnlimitText;
				}
				set
				{
					this.m_owner.m_equipmentEquipUnlimitText = value;
				}
			}

			// Token: 0x1700213E RID: 8510
			// (get) Token: 0x0600A3F9 RID: 41977 RVA: 0x002E3CE0 File Offset: 0x002E1EE0
			// (set) Token: 0x0600A3FA RID: 41978 RVA: 0x002E3CF0 File Offset: 0x002E1EF0
			public GameObject m_equipmentPropertyGroup
			{
				get
				{
					return this.m_owner.m_equipmentPropertyGroup;
				}
				set
				{
					this.m_owner.m_equipmentPropertyGroup = value;
				}
			}

			// Token: 0x1700213F RID: 8511
			// (get) Token: 0x0600A3FB RID: 41979 RVA: 0x002E3D00 File Offset: 0x002E1F00
			// (set) Token: 0x0600A3FC RID: 41980 RVA: 0x002E3D10 File Offset: 0x002E1F10
			public GameObject m_equipmentPropATGo
			{
				get
				{
					return this.m_owner.m_equipmentPropATGo;
				}
				set
				{
					this.m_owner.m_equipmentPropATGo = value;
				}
			}

			// Token: 0x17002140 RID: 8512
			// (get) Token: 0x0600A3FD RID: 41981 RVA: 0x002E3D20 File Offset: 0x002E1F20
			// (set) Token: 0x0600A3FE RID: 41982 RVA: 0x002E3D30 File Offset: 0x002E1F30
			public Text m_equipmentPropATValueText
			{
				get
				{
					return this.m_owner.m_equipmentPropATValueText;
				}
				set
				{
					this.m_owner.m_equipmentPropATValueText = value;
				}
			}

			// Token: 0x17002141 RID: 8513
			// (get) Token: 0x0600A3FF RID: 41983 RVA: 0x002E3D40 File Offset: 0x002E1F40
			// (set) Token: 0x0600A400 RID: 41984 RVA: 0x002E3D50 File Offset: 0x002E1F50
			public GameObject m_equipmentPropDFGo
			{
				get
				{
					return this.m_owner.m_equipmentPropDFGo;
				}
				set
				{
					this.m_owner.m_equipmentPropDFGo = value;
				}
			}

			// Token: 0x17002142 RID: 8514
			// (get) Token: 0x0600A401 RID: 41985 RVA: 0x002E3D60 File Offset: 0x002E1F60
			// (set) Token: 0x0600A402 RID: 41986 RVA: 0x002E3D70 File Offset: 0x002E1F70
			public Text m_equipmentPropDFValueText
			{
				get
				{
					return this.m_owner.m_equipmentPropDFValueText;
				}
				set
				{
					this.m_owner.m_equipmentPropDFValueText = value;
				}
			}

			// Token: 0x17002143 RID: 8515
			// (get) Token: 0x0600A403 RID: 41987 RVA: 0x002E3D80 File Offset: 0x002E1F80
			// (set) Token: 0x0600A404 RID: 41988 RVA: 0x002E3D90 File Offset: 0x002E1F90
			public GameObject m_equipmentPropHPGo
			{
				get
				{
					return this.m_owner.m_equipmentPropHPGo;
				}
				set
				{
					this.m_owner.m_equipmentPropHPGo = value;
				}
			}

			// Token: 0x17002144 RID: 8516
			// (get) Token: 0x0600A405 RID: 41989 RVA: 0x002E3DA0 File Offset: 0x002E1FA0
			// (set) Token: 0x0600A406 RID: 41990 RVA: 0x002E3DB0 File Offset: 0x002E1FB0
			public Text m_equipmentPropHPValueText
			{
				get
				{
					return this.m_owner.m_equipmentPropHPValueText;
				}
				set
				{
					this.m_owner.m_equipmentPropHPValueText = value;
				}
			}

			// Token: 0x17002145 RID: 8517
			// (get) Token: 0x0600A407 RID: 41991 RVA: 0x002E3DC0 File Offset: 0x002E1FC0
			// (set) Token: 0x0600A408 RID: 41992 RVA: 0x002E3DD0 File Offset: 0x002E1FD0
			public GameObject m_equipmentPropMagiccGo
			{
				get
				{
					return this.m_owner.m_equipmentPropMagiccGo;
				}
				set
				{
					this.m_owner.m_equipmentPropMagiccGo = value;
				}
			}

			// Token: 0x17002146 RID: 8518
			// (get) Token: 0x0600A409 RID: 41993 RVA: 0x002E3DE0 File Offset: 0x002E1FE0
			// (set) Token: 0x0600A40A RID: 41994 RVA: 0x002E3DF0 File Offset: 0x002E1FF0
			public Text m_equipmentPropMagicValueText
			{
				get
				{
					return this.m_owner.m_equipmentPropMagicValueText;
				}
				set
				{
					this.m_owner.m_equipmentPropMagicValueText = value;
				}
			}

			// Token: 0x17002147 RID: 8519
			// (get) Token: 0x0600A40B RID: 41995 RVA: 0x002E3E00 File Offset: 0x002E2000
			// (set) Token: 0x0600A40C RID: 41996 RVA: 0x002E3E10 File Offset: 0x002E2010
			public GameObject m_equipmentPropMagicDFGo
			{
				get
				{
					return this.m_owner.m_equipmentPropMagicDFGo;
				}
				set
				{
					this.m_owner.m_equipmentPropMagicDFGo = value;
				}
			}

			// Token: 0x17002148 RID: 8520
			// (get) Token: 0x0600A40D RID: 41997 RVA: 0x002E3E20 File Offset: 0x002E2020
			// (set) Token: 0x0600A40E RID: 41998 RVA: 0x002E3E30 File Offset: 0x002E2030
			public Text m_equipmentPropMagicDFValueText
			{
				get
				{
					return this.m_owner.m_equipmentPropMagicDFValueText;
				}
				set
				{
					this.m_owner.m_equipmentPropMagicDFValueText = value;
				}
			}

			// Token: 0x17002149 RID: 8521
			// (get) Token: 0x0600A40F RID: 41999 RVA: 0x002E3E40 File Offset: 0x002E2040
			// (set) Token: 0x0600A410 RID: 42000 RVA: 0x002E3E50 File Offset: 0x002E2050
			public GameObject m_equipmentPropDexGo
			{
				get
				{
					return this.m_owner.m_equipmentPropDexGo;
				}
				set
				{
					this.m_owner.m_equipmentPropDexGo = value;
				}
			}

			// Token: 0x1700214A RID: 8522
			// (get) Token: 0x0600A411 RID: 42001 RVA: 0x002E3E60 File Offset: 0x002E2060
			// (set) Token: 0x0600A412 RID: 42002 RVA: 0x002E3E70 File Offset: 0x002E2070
			public Text m_equipmentPropDexValueText
			{
				get
				{
					return this.m_owner.m_equipmentPropDexValueText;
				}
				set
				{
					this.m_owner.m_equipmentPropDexValueText = value;
				}
			}

			// Token: 0x1700214B RID: 8523
			// (get) Token: 0x0600A413 RID: 42003 RVA: 0x002E3E80 File Offset: 0x002E2080
			// (set) Token: 0x0600A414 RID: 42004 RVA: 0x002E3E90 File Offset: 0x002E2090
			public CommonUIStateController m_equipmentPropGroupStateCtrl
			{
				get
				{
					return this.m_owner.m_equipmentPropGroupStateCtrl;
				}
				set
				{
					this.m_owner.m_equipmentPropGroupStateCtrl = value;
				}
			}

			// Token: 0x1700214C RID: 8524
			// (get) Token: 0x0600A415 RID: 42005 RVA: 0x002E3EA0 File Offset: 0x002E20A0
			// (set) Token: 0x0600A416 RID: 42006 RVA: 0x002E3EB0 File Offset: 0x002E20B0
			public GameObject m_equipmentPropEnchantmentGroup
			{
				get
				{
					return this.m_owner.m_equipmentPropEnchantmentGroup;
				}
				set
				{
					this.m_owner.m_equipmentPropEnchantmentGroup = value;
				}
			}

			// Token: 0x1700214D RID: 8525
			// (get) Token: 0x0600A417 RID: 42007 RVA: 0x002E3EC0 File Offset: 0x002E20C0
			// (set) Token: 0x0600A418 RID: 42008 RVA: 0x002E3ED0 File Offset: 0x002E20D0
			public GameObject m_equipmentPropEnchantmentGroupResonanceGo
			{
				get
				{
					return this.m_owner.m_equipmentPropEnchantmentGroupResonanceGo;
				}
				set
				{
					this.m_owner.m_equipmentPropEnchantmentGroupResonanceGo = value;
				}
			}

			// Token: 0x1700214E RID: 8526
			// (get) Token: 0x0600A419 RID: 42009 RVA: 0x002E3EE0 File Offset: 0x002E20E0
			// (set) Token: 0x0600A41A RID: 42010 RVA: 0x002E3EF0 File Offset: 0x002E20F0
			public CommonUIStateController m_equipmentPropEnchantmentGroupRuneStateCtrl
			{
				get
				{
					return this.m_owner.m_equipmentPropEnchantmentGroupRuneStateCtrl;
				}
				set
				{
					this.m_owner.m_equipmentPropEnchantmentGroupRuneStateCtrl = value;
				}
			}

			// Token: 0x1700214F RID: 8527
			// (get) Token: 0x0600A41B RID: 42011 RVA: 0x002E3F00 File Offset: 0x002E2100
			// (set) Token: 0x0600A41C RID: 42012 RVA: 0x002E3F10 File Offset: 0x002E2110
			public Image m_equipmentPropEnchantmentGroupRuneIconImage
			{
				get
				{
					return this.m_owner.m_equipmentPropEnchantmentGroupRuneIconImage;
				}
				set
				{
					this.m_owner.m_equipmentPropEnchantmentGroupRuneIconImage = value;
				}
			}

			// Token: 0x17002150 RID: 8528
			// (get) Token: 0x0600A41D RID: 42013 RVA: 0x002E3F20 File Offset: 0x002E2120
			// (set) Token: 0x0600A41E RID: 42014 RVA: 0x002E3F30 File Offset: 0x002E2130
			public Text m_equipmentPropEnchantmentGroupRuneNameText
			{
				get
				{
					return this.m_owner.m_equipmentPropEnchantmentGroupRuneNameText;
				}
				set
				{
					this.m_owner.m_equipmentPropEnchantmentGroupRuneNameText = value;
				}
			}

			// Token: 0x17002151 RID: 8529
			// (get) Token: 0x0600A41F RID: 42015 RVA: 0x002E3F40 File Offset: 0x002E2140
			// (set) Token: 0x0600A420 RID: 42016 RVA: 0x002E3F50 File Offset: 0x002E2150
			public GameObject m_subBagInfoPanelObj
			{
				get
				{
					return this.m_owner.m_subBagInfoPanelObj;
				}
				set
				{
					this.m_owner.m_subBagInfoPanelObj = value;
				}
			}

			// Token: 0x17002152 RID: 8530
			// (get) Token: 0x0600A421 RID: 42017 RVA: 0x002E3F60 File Offset: 0x002E2160
			// (set) Token: 0x0600A422 RID: 42018 RVA: 0x002E3F70 File Offset: 0x002E2170
			public Button m_subItemMinusButton
			{
				get
				{
					return this.m_owner.m_subItemMinusButton;
				}
				set
				{
					this.m_owner.m_subItemMinusButton = value;
				}
			}

			// Token: 0x17002153 RID: 8531
			// (get) Token: 0x0600A423 RID: 42019 RVA: 0x002E3F80 File Offset: 0x002E2180
			// (set) Token: 0x0600A424 RID: 42020 RVA: 0x002E3F90 File Offset: 0x002E2190
			public Button m_subItemAddButton
			{
				get
				{
					return this.m_owner.m_subItemAddButton;
				}
				set
				{
					this.m_owner.m_subItemAddButton = value;
				}
			}

			// Token: 0x17002154 RID: 8532
			// (get) Token: 0x0600A425 RID: 42021 RVA: 0x002E3FA0 File Offset: 0x002E21A0
			// (set) Token: 0x0600A426 RID: 42022 RVA: 0x002E3FB0 File Offset: 0x002E21B0
			public Button m_subItemMaxButton
			{
				get
				{
					return this.m_owner.m_subItemMaxButton;
				}
				set
				{
					this.m_owner.m_subItemMaxButton = value;
				}
			}

			// Token: 0x17002155 RID: 8533
			// (get) Token: 0x0600A427 RID: 42023 RVA: 0x002E3FC0 File Offset: 0x002E21C0
			// (set) Token: 0x0600A428 RID: 42024 RVA: 0x002E3FD0 File Offset: 0x002E21D0
			public InputField m_subItemNumInputField
			{
				get
				{
					return this.m_owner.m_subItemNumInputField;
				}
				set
				{
					this.m_owner.m_subItemNumInputField = value;
				}
			}

			// Token: 0x17002156 RID: 8534
			// (get) Token: 0x0600A429 RID: 42025 RVA: 0x002E3FE0 File Offset: 0x002E21E0
			// (set) Token: 0x0600A42A RID: 42026 RVA: 0x002E3FF0 File Offset: 0x002E21F0
			public Button m_subItemUseButton
			{
				get
				{
					return this.m_owner.m_subItemUseButton;
				}
				set
				{
					this.m_owner.m_subItemUseButton = value;
				}
			}

			// Token: 0x17002157 RID: 8535
			// (get) Token: 0x0600A42B RID: 42027 RVA: 0x002E4000 File Offset: 0x002E2200
			// (set) Token: 0x0600A42C RID: 42028 RVA: 0x002E4010 File Offset: 0x002E2210
			public Button m_subItemPanelReturnButton
			{
				get
				{
					return this.m_owner.m_subItemPanelReturnButton;
				}
				set
				{
					this.m_owner.m_subItemPanelReturnButton = value;
				}
			}

			// Token: 0x17002158 RID: 8536
			// (get) Token: 0x0600A42D RID: 42029 RVA: 0x002E4020 File Offset: 0x002E2220
			// (set) Token: 0x0600A42E RID: 42030 RVA: 0x002E4030 File Offset: 0x002E2230
			public Button m_addAllItemButton
			{
				get
				{
					return this.m_owner.m_addAllItemButton;
				}
				set
				{
					this.m_owner.m_addAllItemButton = value;
				}
			}

			// Token: 0x17002159 RID: 8537
			// (get) Token: 0x0600A42F RID: 42031 RVA: 0x002E4040 File Offset: 0x002E2240
			// (set) Token: 0x0600A430 RID: 42032 RVA: 0x002E4050 File Offset: 0x002E2250
			public Button m_addAllEquipmentButton
			{
				get
				{
					return this.m_owner.m_addAllEquipmentButton;
				}
				set
				{
					this.m_owner.m_addAllEquipmentButton = value;
				}
			}

			// Token: 0x1700215A RID: 8538
			// (get) Token: 0x0600A431 RID: 42033 RVA: 0x002E4060 File Offset: 0x002E2260
			// (set) Token: 0x0600A432 RID: 42034 RVA: 0x002E4070 File Offset: 0x002E2270
			public Button m_addItemButton
			{
				get
				{
					return this.m_owner.m_addItemButton;
				}
				set
				{
					this.m_owner.m_addItemButton = value;
				}
			}

			// Token: 0x1700215B RID: 8539
			// (get) Token: 0x0600A433 RID: 42035 RVA: 0x002E4080 File Offset: 0x002E2280
			// (set) Token: 0x0600A434 RID: 42036 RVA: 0x002E4090 File Offset: 0x002E2290
			public Button m_clearBagItemButton
			{
				get
				{
					return this.m_owner.m_clearBagItemButton;
				}
				set
				{
					this.m_owner.m_clearBagItemButton = value;
				}
			}

			// Token: 0x1700215C RID: 8540
			// (get) Token: 0x0600A435 RID: 42037 RVA: 0x002E40A0 File Offset: 0x002E22A0
			// (set) Token: 0x0600A436 RID: 42038 RVA: 0x002E40B0 File Offset: 0x002E22B0
			public InputField m_bagItemInputField
			{
				get
				{
					return this.m_owner.m_bagItemInputField;
				}
				set
				{
					this.m_owner.m_bagItemInputField = value;
				}
			}

			// Token: 0x1700215D RID: 8541
			// (get) Token: 0x0600A437 RID: 42039 RVA: 0x002E40C0 File Offset: 0x002E22C0
			// (set) Token: 0x0600A438 RID: 42040 RVA: 0x002E40D0 File Offset: 0x002E22D0
			public Button m_speedUpButton
			{
				get
				{
					return this.m_owner.m_speedUpButton;
				}
				set
				{
					this.m_owner.m_speedUpButton = value;
				}
			}

			// Token: 0x1700215E RID: 8542
			// (get) Token: 0x0600A439 RID: 42041 RVA: 0x002E40E0 File Offset: 0x002E22E0
			// (set) Token: 0x0600A43A RID: 42042 RVA: 0x002E40F0 File Offset: 0x002E22F0
			public BagListUIController.DisplayType m_displayType
			{
				get
				{
					return this.m_owner.m_displayType;
				}
				set
				{
					this.m_owner.m_displayType = value;
				}
			}

			// Token: 0x1700215F RID: 8543
			// (get) Token: 0x0600A43B RID: 42043 RVA: 0x002E4100 File Offset: 0x002E2300
			// (set) Token: 0x0600A43C RID: 42044 RVA: 0x002E4110 File Offset: 0x002E2310
			public BagItemBase m_lastClickBagItem
			{
				get
				{
					return this.m_owner.m_lastClickBagItem;
				}
				set
				{
					this.m_owner.m_lastClickBagItem = value;
				}
			}

			// Token: 0x17002160 RID: 8544
			// (get) Token: 0x0600A43D RID: 42045 RVA: 0x002E4120 File Offset: 0x002E2320
			// (set) Token: 0x0600A43E RID: 42046 RVA: 0x002E4130 File Offset: 0x002E2330
			public BagListUIController.DisplayType m_lastClickBagItemType
			{
				get
				{
					return this.m_owner.m_lastClickBagItemType;
				}
				set
				{
					this.m_owner.m_lastClickBagItemType = value;
				}
			}

			// Token: 0x17002161 RID: 8545
			// (get) Token: 0x0600A43F RID: 42047 RVA: 0x002E4140 File Offset: 0x002E2340
			// (set) Token: 0x0600A440 RID: 42048 RVA: 0x002E4150 File Offset: 0x002E2350
			public List<BagItemBase> m_bagItemCache
			{
				get
				{
					return this.m_owner.m_bagItemCache;
				}
				set
				{
					this.m_owner.m_bagItemCache = value;
				}
			}

			// Token: 0x17002162 RID: 8546
			// (get) Token: 0x0600A441 RID: 42049 RVA: 0x002E4160 File Offset: 0x002E2360
			// (set) Token: 0x0600A442 RID: 42050 RVA: 0x002E4170 File Offset: 0x002E2370
			public List<BagItemUIController> m_bagItemCtrlList
			{
				get
				{
					return this.m_owner.m_bagItemCtrlList;
				}
				set
				{
					this.m_owner.m_bagItemCtrlList = value;
				}
			}

			// Token: 0x17002163 RID: 8547
			// (get) Token: 0x0600A443 RID: 42051 RVA: 0x002E4180 File Offset: 0x002E2380
			// (set) Token: 0x0600A444 RID: 42052 RVA: 0x002E4190 File Offset: 0x002E2390
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

			// Token: 0x17002164 RID: 8548
			// (get) Token: 0x0600A445 RID: 42053 RVA: 0x002E41A0 File Offset: 0x002E23A0
			// (set) Token: 0x0600A446 RID: 42054 RVA: 0x002E41B0 File Offset: 0x002E23B0
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

			// Token: 0x0600A447 RID: 42055 RVA: 0x002E41C0 File Offset: 0x002E23C0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600A448 RID: 42056 RVA: 0x002E41D0 File Offset: 0x002E23D0
			public void InitLoopScrollViewRect()
			{
				this.m_owner.InitLoopScrollViewRect();
			}

			// Token: 0x0600A449 RID: 42057 RVA: 0x002E41E0 File Offset: 0x002E23E0
			public bool IsBagItemOfDisplayType(BagItemBase itm)
			{
				return this.m_owner.IsBagItemOfDisplayType(itm);
			}

			// Token: 0x0600A44A RID: 42058 RVA: 0x002E41F0 File Offset: 0x002E23F0
			public void ShowNoItemPanelObj(bool isShow)
			{
				this.m_owner.ShowNoItemPanelObj(isShow);
			}

			// Token: 0x0600A44B RID: 42059 RVA: 0x002E4200 File Offset: 0x002E2400
			public int BagItemComparer(BagItemBase item1, BagItemBase item2)
			{
				return this.m_owner.BagItemComparer(item1, item2);
			}

			// Token: 0x0600A44C RID: 42060 RVA: 0x002E4210 File Offset: 0x002E2410
			public void OnBagItemClick(UIControllerBase itemCtrl)
			{
				this.m_owner.OnBagItemClick(itemCtrl);
			}

			// Token: 0x0600A44D RID: 42061 RVA: 0x002E4220 File Offset: 0x002E2420
			public void OnBagItemNeedFill(UIControllerBase itemCtrl)
			{
				this.m_owner.OnBagItemNeedFill(itemCtrl);
			}

			// Token: 0x0600A44E RID: 42062 RVA: 0x002E4230 File Offset: 0x002E2430
			public void SetInfoPanel(BagItemBase bagItemBase)
			{
				this.m_owner.SetInfoPanel(bagItemBase);
			}

			// Token: 0x0600A44F RID: 42063 RVA: 0x002E4240 File Offset: 0x002E2440
			public void SetEquipmentInfo(EquipmentBagItem equipment)
			{
				this.m_owner.SetEquipmentInfo(equipment);
			}

			// Token: 0x0600A450 RID: 42064 RVA: 0x002E4250 File Offset: 0x002E2450
			public void SetEquipmentSkillInfo(EquipmentBagItem equipment)
			{
				this.m_owner.SetEquipmentSkillInfo(equipment);
			}

			// Token: 0x0600A451 RID: 42065 RVA: 0x002E4260 File Offset: 0x002E2460
			public void SetEquipmentLimitInfo(EquipmentBagItem equipment)
			{
				this.m_owner.SetEquipmentLimitInfo(equipment);
			}

			// Token: 0x0600A452 RID: 42066 RVA: 0x002E4270 File Offset: 0x002E2470
			public void SetEquipmentEnchantInfo(EquipmentBagItem equipment)
			{
				this.m_owner.SetEquipmentEnchantInfo(equipment);
			}

			// Token: 0x0600A453 RID: 42067 RVA: 0x002E4280 File Offset: 0x002E2480
			public void SetEquipmentPropItem(PropertyModifyType type, int value, int addValue, int level)
			{
				this.m_owner.SetEquipmentPropItem(type, value, addValue, level);
			}

			// Token: 0x0600A454 RID: 42068 RVA: 0x002E4294 File Offset: 0x002E2494
			public void SetBagCountLimit()
			{
				this.m_owner.SetBagCountLimit();
			}

			// Token: 0x0600A455 RID: 42069 RVA: 0x002E42A4 File Offset: 0x002E24A4
			public void OnGetItemButtonClick()
			{
				this.m_owner.OnGetItemButtonClick();
			}

			// Token: 0x0600A456 RID: 42070 RVA: 0x002E42B4 File Offset: 0x002E24B4
			public void OnEquipmentForgeButton()
			{
				this.m_owner.OnEquipmentForgeButton();
			}

			// Token: 0x0600A457 RID: 42071 RVA: 0x002E42C4 File Offset: 0x002E24C4
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600A458 RID: 42072 RVA: 0x002E42D4 File Offset: 0x002E24D4
			public void OnAlchemyButtonClick()
			{
				this.m_owner.OnAlchemyButtonClick();
			}

			// Token: 0x0600A459 RID: 42073 RVA: 0x002E42E4 File Offset: 0x002E24E4
			public void OnUseButtonClick()
			{
				this.m_owner.OnUseButtonClick();
			}

			// Token: 0x0600A45A RID: 42074 RVA: 0x002E42F4 File Offset: 0x002E24F4
			public void OnSubItemUseItemClick()
			{
				this.m_owner.OnSubItemUseItemClick();
			}

			// Token: 0x0600A45B RID: 42075 RVA: 0x002E4304 File Offset: 0x002E2504
			public void CloseSubItemUsePanel()
			{
				this.m_owner.CloseSubItemUsePanel();
			}

			// Token: 0x0600A45C RID: 42076 RVA: 0x002E4314 File Offset: 0x002E2514
			public void OnInputEditEnd(string inputString)
			{
				this.m_owner.OnInputEditEnd(inputString);
			}

			// Token: 0x0600A45D RID: 42077 RVA: 0x002E4324 File Offset: 0x002E2524
			public void OnItemMinusButtonClick()
			{
				this.m_owner.OnItemMinusButtonClick();
			}

			// Token: 0x0600A45E RID: 42078 RVA: 0x002E4334 File Offset: 0x002E2534
			public void OnItemAddButtonClick()
			{
				this.m_owner.OnItemAddButtonClick();
			}

			// Token: 0x0600A45F RID: 42079 RVA: 0x002E4344 File Offset: 0x002E2544
			public void OnItemMaxButtonClick()
			{
				this.m_owner.OnItemMaxButtonClick();
			}

			// Token: 0x0600A460 RID: 42080 RVA: 0x002E4354 File Offset: 0x002E2554
			public void OnAddAllItemButtonClick()
			{
				this.m_owner.OnAddAllItemButtonClick();
			}

			// Token: 0x0600A461 RID: 42081 RVA: 0x002E4364 File Offset: 0x002E2564
			public void OnAddAllEquipmentButtonClick()
			{
				this.m_owner.OnAddAllEquipmentButtonClick();
			}

			// Token: 0x0600A462 RID: 42082 RVA: 0x002E4374 File Offset: 0x002E2574
			public void OnAddItemButtonClick()
			{
				this.m_owner.OnAddItemButtonClick();
			}

			// Token: 0x0600A463 RID: 42083 RVA: 0x002E4384 File Offset: 0x002E2584
			public void OnClearBagButtonClick()
			{
				this.m_owner.OnClearBagButtonClick();
			}

			// Token: 0x0600A464 RID: 42084 RVA: 0x002E4394 File Offset: 0x002E2594
			public void OnSpeedUpButtonClick()
			{
				this.m_owner.OnSpeedUpButtonClick();
			}

			// Token: 0x0600A465 RID: 42085 RVA: 0x002E43A4 File Offset: 0x002E25A4
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x0600A466 RID: 42086 RVA: 0x002E43B4 File Offset: 0x002E25B4
			public void OnItemToggleValueChanged(bool on)
			{
				this.m_owner.OnItemToggleValueChanged(on);
			}

			// Token: 0x0600A467 RID: 42087 RVA: 0x002E43C4 File Offset: 0x002E25C4
			public void OnJobMaterialToggleValueChanged(bool on)
			{
				this.m_owner.OnJobMaterialToggleValueChanged(on);
			}

			// Token: 0x0600A468 RID: 42088 RVA: 0x002E43D4 File Offset: 0x002E25D4
			public void OnEquipmentToggleValueChanged(bool on)
			{
				this.m_owner.OnEquipmentToggleValueChanged(on);
			}

			// Token: 0x0600A469 RID: 42089 RVA: 0x002E43E4 File Offset: 0x002E25E4
			public void OnFragmentToggleValueChanged(bool on)
			{
				this.m_owner.OnFragmentToggleValueChanged(on);
			}

			// Token: 0x0600A46A RID: 42090 RVA: 0x002E43F4 File Offset: 0x002E25F4
			public void OnToggleChanged()
			{
				this.m_owner.OnToggleChanged();
			}

			// Token: 0x04006DAE RID: 28078
			private BagListUIController m_owner;
		}
	}
}
