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
using BlackJack.ProjectL.Protocol;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A43 RID: 2627
	[HotFix]
	public class AlchemyUIController : UIControllerBase
	{
		// Token: 0x0600A17A RID: 41338 RVA: 0x002D93B8 File Offset: 0x002D75B8
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
			this.m_itemToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnItemToggleValueChanged));
			this.m_fragmentToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnFragmentToggleValueChanged));
			this.m_jobMaterialToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnJobMaterialToggleValueChanged));
			this.m_equipmentToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnEquipmentToggleValueChanged));
			this.m_subItemUseButton.onClick.AddListener(new UnityAction(this.OnSubItemUseItemClick));
			this.m_subItemPanelReturnButton.onClick.AddListener(new UnityAction(this.CloseSubItemUsePanel));
			this.m_subItemMinusButton.onClick.AddListener(new UnityAction(this.OnItemMinusButtonClick));
			this.m_subItemAddButton.onClick.AddListener(new UnityAction(this.OnItemAddButtonClick));
			this.m_subItemMaxButton.onClick.AddListener(new UnityAction(this.OnItemMaxButtonClick));
			this.m_alchemyButton.onClick.AddListener(new UnityAction(this.OnAlchemyButtonClick));
			this.m_subItemNumInputField.onEndEdit.AddListener(new UnityAction<string>(this.OnInputEditEnd));
			this.InitLoopScrollViewRect();
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600A17B RID: 41339 RVA: 0x002D95C8 File Offset: 0x002D77C8
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

		// Token: 0x0600A17C RID: 41340 RVA: 0x002D974C File Offset: 0x002D794C
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

		// Token: 0x0600A17D RID: 41341 RVA: 0x002D97C8 File Offset: 0x002D79C8
		public void UpdateView()
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
			this.m_bagItemCache.Clear();
			List<BagItemBase> list = new List<BagItemBase>();
			List<BagItemBase> list2 = new List<BagItemBase>();
			foreach (BagItemBase bagItemBase in this.m_playerContext.GetBagItems())
			{
				if (this.IsBagItemOfDisplayType(bagItemBase))
				{
					if (UIUtility.GetBagItemAlchemyGold(bagItemBase) == 0)
					{
						list2.Add(bagItemBase);
					}
					else
					{
						if (this.m_displayType == AlchemyUIController.DisplayType.Equipment)
						{
							EquipmentBagItem equipmentBagItem = (EquipmentBagItem)bagItemBase;
							int wearedEquipmentHeroIdByEquipmentId = this.m_playerContext.GetWearedEquipmentHeroIdByEquipmentId(bagItemBase.InstanceId);
							if (wearedEquipmentHeroIdByEquipmentId >= 0 || equipmentBagItem.Locked)
							{
								list2.Add(bagItemBase);
								continue;
							}
						}
						list.Add(bagItemBase);
					}
				}
			}
			list.Sort(new Comparison<BagItemBase>(this.BagItemComparer));
			list2.Sort(new Comparison<BagItemBase>(this.BagItemComparer));
			this.m_bagItemCache.AddRange(list);
			this.m_bagItemCache.AddRange(list2);
			this.m_canAlchemyListIndex = list.Count;
			int startIdx = 0;
			if (this.m_bagItemCache.Count > 0 && this.m_lastCheckBagItem != null)
			{
				GameObject firstGameObjectInViewRect = this.m_loopScrollView.GetFirstGameObjectInViewRect();
				if (firstGameObjectInViewRect != null)
				{
					startIdx = firstGameObjectInViewRect.GetComponent<ScrollItemBaseUIController>().ItemIndex;
				}
			}
			this.m_loopScrollView.totalCount = this.m_bagItemCache.Count;
			this.m_loopScrollView.RefillCells(startIdx);
			this.SetPointBgContent();
			Canvas.ForceUpdateCanvases();
			if (this.m_checkBagItemToCountDict.Count != 0)
			{
				UIStateDesc currentUIState = this.m_alchemyButtonStateCtrl.GetCurrentUIState();
				if (currentUIState.StateName != "Normal")
				{
					this.m_alchemyButtonStateCtrl.SetToUIState("Normal", false, true);
				}
			}
			else
			{
				this.m_alchemyButtonStateCtrl.SetToUIState("Grey", false, true);
			}
			this.m_mithralStoneText.text = UIUtility.GetGoodsCount(GoodsType.GoodsType_MithralStone, 0).ToString();
			this.m_brillianceMithralStoneText.text = UIUtility.GetGoodsCount(GoodsType.GoodsType_BrillianceMithralStone, 0).ToString();
		}

		// Token: 0x0600A17E RID: 41342 RVA: 0x002D9A60 File Offset: 0x002D7C60
		private void SetPointBgContent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPointBgContent_hotfix != null)
			{
				this.m_SetPointBgContent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
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
		}

		// Token: 0x0600A17F RID: 41343 RVA: 0x002D9B48 File Offset: 0x002D7D48
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
			if (this.m_displayType == AlchemyUIController.DisplayType.Item)
			{
				if (itm.GoodsTypeId == GoodsType.GoodsType_Item && itm.ItemInfo.DisplayType != ItemDisplayType.ItemDisplayType_HeroFragment)
				{
					return true;
				}
			}
			else if (this.m_displayType == AlchemyUIController.DisplayType.Fragment)
			{
				if (itm.GoodsTypeId == GoodsType.GoodsType_Item && itm.ItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_HeroFragment)
				{
					return true;
				}
			}
			else if (this.m_displayType == AlchemyUIController.DisplayType.JobMaterial)
			{
				if (itm.GoodsTypeId == GoodsType.GoodsType_JobMaterial)
				{
					return true;
				}
			}
			else if (this.m_displayType == AlchemyUIController.DisplayType.Equipment && itm.GoodsTypeId == GoodsType.GoodsType_Equipment)
			{
				return true;
			}
			return false;
		}

		// Token: 0x0600A180 RID: 41344 RVA: 0x002D9C60 File Offset: 0x002D7E60
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
				if (item2.ItemInfo.Rank != item1.ItemInfo.Rank)
				{
					return item1.ItemInfo.Rank - item2.ItemInfo.Rank;
				}
				if (item2.ItemInfo.FuncType != item1.ItemInfo.FuncType)
				{
					return item2.ItemInfo.FuncType - item1.ItemInfo.FuncType;
				}
				return item2.ItemInfo.ID - item1.ItemInfo.ID;
			}
			else if (item1.JobMaterialInfo != null)
			{
				if (item2.JobMaterialInfo.Rank != item1.JobMaterialInfo.Rank)
				{
					return item1.JobMaterialInfo.Rank - item2.JobMaterialInfo.Rank;
				}
				return item2.JobMaterialInfo.ID - item1.JobMaterialInfo.ID;
			}
			else
			{
				if (item1.EquipmentInfo == null)
				{
					return 0;
				}
				if (item2.EquipmentInfo.EquipmentType != item1.EquipmentInfo.EquipmentType && (item1.EquipmentInfo.EquipmentType >= EquipmentType.EquipmentType_Enhancement || item2.EquipmentInfo.EquipmentType >= EquipmentType.EquipmentType_Enhancement))
				{
					if (item1.EquipmentInfo.EquipmentType < EquipmentType.EquipmentType_Enhancement || item2.EquipmentInfo.EquipmentType < EquipmentType.EquipmentType_Enhancement)
					{
						return item1.EquipmentInfo.EquipmentType - item2.EquipmentInfo.EquipmentType;
					}
					if (item2.EquipmentInfo.Rank != item1.EquipmentInfo.Rank)
					{
						return item1.EquipmentInfo.Rank - item2.EquipmentInfo.Rank;
					}
					return item2.EquipmentInfo.ID - item1.EquipmentInfo.ID;
				}
				else
				{
					if (item2.EquipmentInfo.Rank != item1.EquipmentInfo.Rank)
					{
						return item1.EquipmentInfo.Rank - item2.EquipmentInfo.Rank;
					}
					return item2.EquipmentInfo.ID - item1.EquipmentInfo.ID;
				}
			}
		}

		// Token: 0x0600A181 RID: 41345 RVA: 0x002D9EE4 File Offset: 0x002D80E4
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
			int itemIndex = bagItemUIController.ScrollItemBaseUICtrl.ItemIndex;
			if (itemIndex >= this.m_canAlchemyListIndex)
			{
				return;
			}
			if (!this.m_checkBagItemToCountDict.ContainsKey(bagItemUIController.BagItem))
			{
				if (this.GetLastAlchemyCount() <= 1)
				{
					return;
				}
				this.m_lastCheckBagItem = bagItemUIController.BagItem;
				this.m_checkBagItemToCountDict[bagItemUIController.BagItem] = 1;
				if (bagItemUIController.BagItem.GoodsTypeId != GoodsType.GoodsType_Equipment)
				{
					this.OpenSubUseItemPanel();
				}
			}
			else
			{
				this.m_checkBagItemToCountDict.Remove(bagItemUIController.BagItem);
			}
			bagItemUIController.ShowCheckFrame(this.m_checkBagItemToCountDict.ContainsKey(bagItemUIController.BagItem));
			if (!this.m_subBagInfoPanelObj.activeSelf)
			{
				if (this.m_checkBagItemToCountDict.Count != 0)
				{
					this.ShowRewardListPanel();
				}
				else
				{
					this.CloseRewardListPanel();
				}
			}
			if (this.m_checkBagItemToCountDict.Count == 0)
			{
				this.m_alchemyButtonStateCtrl.SetToUIState("Grey", false, true);
			}
			else if (bagItemUIController.BagItem.GoodsTypeId == GoodsType.GoodsType_Equipment)
			{
				UIStateDesc currentUIState = this.m_alchemyButtonStateCtrl.GetCurrentUIState();
				if (currentUIState.StateName != "Normal")
				{
					this.m_alchemyButtonStateCtrl.SetToUIState("Normal", false, true);
				}
			}
		}

		// Token: 0x0600A182 RID: 41346 RVA: 0x002DA0A4 File Offset: 0x002D82A4
		private void ShowRewardListPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRewardListPanel_hotfix != null)
			{
				this.m_ShowRewardListPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_rewardListPanelGo.activeSelf)
			{
				this.m_rewardListPanelGo.SetActive(true);
				this.m_rewardListPanelStateCtrl.SetToUIState("Show", false, true);
			}
			GameObjectUtility.DestroyChildren(this.m_rewardsContent);
			int num = 0;
			int num2 = 0;
			BagItemBase bagItemBase = null;
			List<Goods> list = new List<Goods>();
			foreach (KeyValuePair<BagItemBase, int> keyValuePair in this.m_checkBagItemToCountDict)
			{
				int value = keyValuePair.Value;
				num += value;
				BagItemBase key = keyValuePair.Key;
				if (bagItemBase == null)
				{
					bagItemBase = key;
				}
				int bagItemDropID = UIUtility.GetBagItemDropID(key);
				List<Goods> list2 = new List<Goods>();
				UIUtility.AppendRandomDropRewardGoodsToList(bagItemDropID, list2);
				int bagItemDropDisplayCount = UIUtility.GetBagItemDropDisplayCount(key);
				if (list2.Count > bagItemDropDisplayCount)
				{
					list2.RemoveRange(bagItemDropDisplayCount, list2.Count - bagItemDropDisplayCount);
				}
				using (List<Goods>.Enumerator enumerator2 = list2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Goods reward = enumerator2.Current;
						reward.Count *= value;
						Goods goods = list.Find((Goods t) => t.Id == reward.Id && t.GoodsType == reward.GoodsType);
						if (goods != null)
						{
							goods.Count += reward.Count;
						}
						else
						{
							list.Add(reward);
						}
					}
				}
				num2 += UIUtility.GetBagItemAlchemyGold(key) * value;
				if (key.GoodsTypeId == GoodsType.GoodsType_Equipment)
				{
					int num3 = this.m_playerContext.CalcEquipmentDecomposeReturnGold((EquipmentBagItem)key);
					num2 += num3 * value;
				}
			}
			foreach (Goods r in list)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				RewardGoodsUIController rewardGoodsUIController = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(gameObject);
				rewardGoodsUIController.SetReward(r, 0, true);
				rewardGoodsUIController.ShowCount(false);
				gameObject.transform.SetParent(this.m_rewardsContent.transform, false);
			}
			this.m_rewardsNothingGo.SetActive(this.m_checkBagItemToCountDict.Count == 0);
			this.m_rewardsMaterialCountText.text = num + "/" + this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_AlchemyMaxNum);
			this.m_rewardsGoldenValueText.text = num2.ToString();
			if (bagItemBase != null)
			{
				this.m_rewardsNoticTextGo.SetActive(bagItemBase.GoodsTypeId == GoodsType.GoodsType_Equipment);
				this.m_rewardsNoticText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AlchemyNoticeText);
			}
			else
			{
				this.m_rewardsNoticTextGo.SetActive(false);
			}
		}

		// Token: 0x0600A183 RID: 41347 RVA: 0x002DA430 File Offset: 0x002D8630
		private void CloseRewardListPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseRewardListPanel_hotfix != null)
			{
				this.m_CloseRewardListPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_rewardListPanelGo.activeSelf)
			{
				this.m_rewardListPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
				{
					this.m_rewardListPanelGo.SetActive(false);
				});
				this.m_rewardListPanelStateCtrl.SetToUIState("Close", false, true);
			}
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x002DA4D0 File Offset: 0x002D86D0
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
			BagItemUIController goCtrl = itemCtrl as BagItemUIController;
			if (goCtrl == null)
			{
				return;
			}
			int itemIndex = goCtrl.ScrollItemBaseUICtrl.ItemIndex;
			if (itemIndex < this.m_bagItemCache.Count)
			{
				goCtrl.SetBagItemInfo(this.m_bagItemCache[itemIndex]);
				if (!this.m_bagItemCtrlList.Contains(goCtrl))
				{
					this.m_bagItemCtrlList.Add(goCtrl);
				}
				goCtrl.ShowGreyMask(itemIndex >= this.m_canAlchemyListIndex);
				goCtrl.ShowCheckFrame(this.m_checkBagItemToCountDict.ContainsKey(goCtrl.BagItem));
				Animator component = goCtrl.gameObject.GetComponent<Animator>();
				component.Play("Normal");
			}
			LongPressComponent component2 = goCtrl.gameObject.GetComponent<LongPressComponent>();
			if (component2 == null)
			{
				goCtrl.gameObject.AddComponent<LongPressComponent>().SetBasicParam(0.3f, 0f, delegate
				{
					RewardGoodsDescUITask.StartUITask(this, goCtrl.BagItem.GoodsTypeId, goCtrl.BagItem.ContentId, 1, goCtrl.gameObject, true);
				}, null, delegate
				{
					this.CloseRewardGoodsDescPanel();
				}, false);
			}
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x002DA678 File Offset: 0x002D8878
		private void CloseRewardGoodsDescPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseRewardGoodsDescPanel_hotfix != null)
			{
				this.m_CloseRewardGoodsDescPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Transform transform = base.gameObject.transform;
			while (!transform.name.EndsWith("_LayerRoot"))
			{
				transform = transform.parent;
			}
			for (int i = 0; i < transform.transform.childCount; i++)
			{
				Transform child = transform.transform.GetChild(i);
				if (child.name == "RewardGoodsDesc")
				{
					child.gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x002DA750 File Offset: 0x002D8950
		private void OpenSubUseItemPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenSubUseItemPanel_hotfix != null)
			{
				this.m_OpenSubUseItemPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_subItemNumInputField.text = "1";
			this.SetLastAlchemyCount(null);
			CommonUIStateController component = this.m_subBagInfoPanelObj.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateOpen(component, "Show", null, false, true);
		}

		// Token: 0x0600A187 RID: 41351 RVA: 0x002DA7E4 File Offset: 0x002D89E4
		private void SetLastAlchemyCount(string inputString = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLastAlchemyCountString_hotfix != null)
			{
				this.m_SetLastAlchemyCountString_hotfix.call(new object[]
				{
					this,
					inputString
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int lastAlchemyCount = this.GetLastAlchemyCount();
			if (inputString == null)
			{
				inputString = this.m_subItemNumInputField.text;
			}
			if (inputString == string.Empty)
			{
				this.m_subItemAvailalbeValueText.text = lastAlchemyCount.ToString();
			}
			else
			{
				int num = 0;
				if (!int.TryParse(inputString, out num))
				{
					BagItemBase lastCheckBagItem = this.m_lastCheckBagItem;
					int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(lastCheckBagItem.GoodsTypeId, lastCheckBagItem.ContentId);
					num = bagItemCountByType;
					this.m_subItemNumInputField.text = num.ToString();
				}
				if (num > lastAlchemyCount)
				{
					this.m_subItemNumInputField.text = lastAlchemyCount.ToString();
					num = lastAlchemyCount;
				}
				this.m_subItemAvailalbeValueText.text = (lastAlchemyCount - num).ToString();
			}
		}

		// Token: 0x0600A188 RID: 41352 RVA: 0x002DA924 File Offset: 0x002D8B24
		private int GetLastAlchemyCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLastAlchemyCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLastAlchemyCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_AlchemyMaxNum);
			Dictionary<BagItemBase, int>.ValueCollection values = this.m_checkBagItemToCountDict.Values;
			int num2 = 0;
			foreach (int num3 in values)
			{
				num2 += num3;
			}
			num2--;
			return num - num2;
		}

		// Token: 0x0600A189 RID: 41353 RVA: 0x002DAA00 File Offset: 0x002D8C00
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
			if (this.m_subItemNumInputField.text == string.Empty)
			{
				CommonUIController.Instance.ShowErrorMessage(-521, 2f, null, true);
				return;
			}
			int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(this.m_lastCheckBagItem.GoodsTypeId, this.m_lastCheckBagItem.ContentId);
			int num = 0;
			if (!int.TryParse(this.m_subItemNumInputField.text, out num))
			{
				num = bagItemCountByType;
			}
			if (num < 1 || num > bagItemCountByType)
			{
				CommonUIController.Instance.ShowErrorMessage(-521, 2f, null, true);
				return;
			}
			this.m_checkBagItemToCountDict[this.m_lastCheckBagItem] = num;
			CommonUIStateController component = this.m_subBagInfoPanelObj.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateClose(component, "Close", null, false, true);
			this.ShowRewardListPanel();
			if (this.m_checkBagItemToCountDict.Count != 0)
			{
				UIStateDesc currentUIState = this.m_alchemyButtonStateCtrl.GetCurrentUIState();
				if (currentUIState.StateName != "Normal")
				{
					this.m_alchemyButtonStateCtrl.SetToUIState("Normal", false, true);
				}
			}
			else
			{
				this.m_alchemyButtonStateCtrl.SetToUIState("Grey", false, true);
			}
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x002DAB80 File Offset: 0x002D8D80
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
			int num = 0;
			if (!int.TryParse(this.m_subItemNumInputField.text, out num))
			{
				return;
			}
			if (num > 1)
			{
				this.m_subItemNumInputField.text = (num - 1).ToString();
			}
			this.SetLastAlchemyCount(null);
		}

		// Token: 0x0600A18B RID: 41355 RVA: 0x002DAC50 File Offset: 0x002D8E50
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
			BagItemBase lastCheckBagItem = this.m_lastCheckBagItem;
			int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(lastCheckBagItem.GoodsTypeId, lastCheckBagItem.ContentId);
			int num = 0;
			if (!int.TryParse(this.m_subItemNumInputField.text, out num))
			{
				return;
			}
			if (num < bagItemCountByType && num + 1 <= this.GetLastAlchemyCount())
			{
				this.m_subItemNumInputField.text = (num + 1).ToString();
			}
			this.SetLastAlchemyCount(null);
		}

		// Token: 0x0600A18C RID: 41356 RVA: 0x002DAD4C File Offset: 0x002D8F4C
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
			BagItemBase lastCheckBagItem = this.m_lastCheckBagItem;
			int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(lastCheckBagItem.GoodsTypeId, lastCheckBagItem.ContentId);
			if (bagItemCountByType <= this.GetLastAlchemyCount())
			{
				this.m_subItemNumInputField.text = bagItemCountByType.ToString();
			}
			else
			{
				this.m_subItemNumInputField.text = this.GetLastAlchemyCount().ToString();
			}
			this.SetLastAlchemyCount(null);
		}

		// Token: 0x0600A18D RID: 41357 RVA: 0x002DAE1C File Offset: 0x002D901C
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
			this.m_checkBagItemToCountDict.Remove(this.m_lastCheckBagItem);
			BagItemUIController bagItemUIController = this.m_bagItemCtrlList.Find((BagItemUIController t) => t.BagItem == this.m_lastCheckBagItem);
			if (bagItemUIController != null)
			{
				bagItemUIController.ShowCheckFrame(false);
			}
			CommonUIStateController component = this.m_subBagInfoPanelObj.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateClose(component, "Close", null, false, true);
			if (this.m_checkBagItemToCountDict.Count != 0)
			{
				UIStateDesc currentUIState = this.m_alchemyButtonStateCtrl.GetCurrentUIState();
				if (currentUIState.StateName != "Normal")
				{
					this.m_alchemyButtonStateCtrl.SetToUIState("Normal", false, true);
				}
			}
			else
			{
				this.m_alchemyButtonStateCtrl.SetToUIState("Grey", false, true);
			}
		}

		// Token: 0x0600A18E RID: 41358 RVA: 0x002DAF30 File Offset: 0x002D9130
		private void OnInputEditEnd(string str)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInputEditEndString_hotfix != null)
			{
				this.m_OnInputEditEndString_hotfix.call(new object[]
				{
					this,
					str
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetLastAlchemyCount(str);
		}

		// Token: 0x0600A18F RID: 41359 RVA: 0x002DAFA8 File Offset: 0x002D91A8
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

		// Token: 0x0600A190 RID: 41360 RVA: 0x002DB020 File Offset: 0x002D9220
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

		// Token: 0x0600A191 RID: 41361 RVA: 0x002DB098 File Offset: 0x002D9298
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
			List<BagItemBase> list = new List<BagItemBase>(this.m_checkBagItemToCountDict.Keys);
			List<ProGoods> list2 = BagItemBase.BagItemsToPBGoods(list);
			for (int i = 0; i < list2.Count; i++)
			{
				list2[i].Nums = this.m_checkBagItemToCountDict[list[i]];
			}
			if (list2.Count == 0)
			{
				return;
			}
			if (this.EventOnAlchemyButtonClick != null)
			{
				this.EventOnAlchemyButtonClick(list2, delegate(List<Goods> rewards)
				{
					base.StartCoroutine(this.OnAlchemySucceed(rewards));
				});
			}
			this.m_checkBagItemToCountDict.Clear();
			this.CloseRewardListPanel();
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x002DB188 File Offset: 0x002D9388
		[DebuggerHidden]
		private IEnumerator OnAlchemySucceed(List<Goods> rewards)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAlchemySucceedList`1_hotfix != null)
			{
				return (IEnumerator)this.m_OnAlchemySucceedList`1_hotfix.call(new object[]
				{
					this,
					rewards
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AlchemyUIController.<OnAlchemySucceed>c__Iterator0 <OnAlchemySucceed>c__Iterator = new AlchemyUIController.<OnAlchemySucceed>c__Iterator0();
			<OnAlchemySucceed>c__Iterator.rewards = rewards;
			<OnAlchemySucceed>c__Iterator.$this = this;
			return <OnAlchemySucceed>c__Iterator;
		}

		// Token: 0x0600A193 RID: 41363 RVA: 0x002DB21C File Offset: 0x002D941C
		public void ResetAlchemyUIView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetAlchemyUIView_hotfix != null)
			{
				this.m_ResetAlchemyUIView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lastCheckBagItem = null;
			this.m_displayType = AlchemyUIController.DisplayType.Item;
			this.m_itemToggle.isOn = true;
			this.m_checkBagItemToCountDict.Clear();
			this.CloseRewardListPanel();
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x002DB2A8 File Offset: 0x002D94A8
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

		// Token: 0x0600A195 RID: 41365 RVA: 0x002DB318 File Offset: 0x002D9518
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
				if (this.m_displayType == AlchemyUIController.DisplayType.Item)
				{
					return;
				}
				this.m_displayType = AlchemyUIController.DisplayType.Item;
				this.OnToggleChanged();
			}
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x002DB3A8 File Offset: 0x002D95A8
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
				if (this.m_displayType == AlchemyUIController.DisplayType.JobMaterial)
				{
					return;
				}
				this.m_displayType = AlchemyUIController.DisplayType.JobMaterial;
				this.OnToggleChanged();
			}
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x002DB438 File Offset: 0x002D9638
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
				if (this.m_displayType == AlchemyUIController.DisplayType.Equipment)
				{
					return;
				}
				this.m_displayType = AlchemyUIController.DisplayType.Equipment;
				this.OnToggleChanged();
			}
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x002DB4C8 File Offset: 0x002D96C8
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
				if (this.m_displayType == AlchemyUIController.DisplayType.Fragment)
				{
					return;
				}
				this.m_displayType = AlchemyUIController.DisplayType.Fragment;
				this.OnToggleChanged();
			}
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x002DB558 File Offset: 0x002D9758
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
			this.m_checkBagItemToCountDict.Clear();
			this.m_lastCheckBagItem = null;
			this.CloseRewardListPanel();
			this.ResetScrollViewToTop();
			this.UpdateView();
		}

		// Token: 0x140001DF RID: 479
		// (add) Token: 0x0600A19A RID: 41370 RVA: 0x002DB5DC File Offset: 0x002D97DC
		// (remove) Token: 0x0600A19B RID: 41371 RVA: 0x002DB678 File Offset: 0x002D9878
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

		// Token: 0x140001E0 RID: 480
		// (add) Token: 0x0600A19C RID: 41372 RVA: 0x002DB714 File Offset: 0x002D9914
		// (remove) Token: 0x0600A19D RID: 41373 RVA: 0x002DB7B0 File Offset: 0x002D99B0
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

		// Token: 0x140001E1 RID: 481
		// (add) Token: 0x0600A19E RID: 41374 RVA: 0x002DB84C File Offset: 0x002D9A4C
		// (remove) Token: 0x0600A19F RID: 41375 RVA: 0x002DB8E8 File Offset: 0x002D9AE8
		public event Action<List<ProGoods>, Action<List<Goods>>> EventOnAlchemyButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAlchemyButtonClickAction`2_hotfix != null)
				{
					this.m_add_EventOnAlchemyButtonClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<ProGoods>, Action<List<Goods>>> action = this.EventOnAlchemyButtonClick;
				Action<List<ProGoods>, Action<List<Goods>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<ProGoods>, Action<List<Goods>>>>(ref this.EventOnAlchemyButtonClick, (Action<List<ProGoods>, Action<List<Goods>>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAlchemyButtonClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnAlchemyButtonClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<ProGoods>, Action<List<Goods>>> action = this.EventOnAlchemyButtonClick;
				Action<List<ProGoods>, Action<List<Goods>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<ProGoods>, Action<List<Goods>>>>(ref this.EventOnAlchemyButtonClick, (Action<List<ProGoods>, Action<List<Goods>>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x0600A1A0 RID: 41376 RVA: 0x002DB984 File Offset: 0x002D9B84
		// (set) Token: 0x0600A1A1 RID: 41377 RVA: 0x002DB9A4 File Offset: 0x002D9BA4
		[DoNotToLua]
		public new AlchemyUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new AlchemyUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x002DB9B0 File Offset: 0x002D9BB0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x002DB9BC File Offset: 0x002D9BBC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A1A4 RID: 41380 RVA: 0x002DB9C4 File Offset: 0x002D9BC4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A1A5 RID: 41381 RVA: 0x002DB9CC File Offset: 0x002D9BCC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A1A6 RID: 41382 RVA: 0x002DB9E0 File Offset: 0x002D9BE0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A1A7 RID: 41383 RVA: 0x002DB9E8 File Offset: 0x002D9BE8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x002DB9F4 File Offset: 0x002D9BF4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A1A9 RID: 41385 RVA: 0x002DBA00 File Offset: 0x002D9C00
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x002DBA0C File Offset: 0x002D9C0C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x002DBA18 File Offset: 0x002D9C18
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x002DBA24 File Offset: 0x002D9C24
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x002DBA30 File Offset: 0x002D9C30
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x002DBA3C File Offset: 0x002D9C3C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x002DBA48 File Offset: 0x002D9C48
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x002DBA54 File Offset: 0x002D9C54
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x002DBA5C File Offset: 0x002D9C5C
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x002DBA7C File Offset: 0x002D9C7C
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x002DBA88 File Offset: 0x002D9C88
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x002DBAA8 File Offset: 0x002D9CA8
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x002DBAB4 File Offset: 0x002D9CB4
		private void __callDele_EventOnAlchemyButtonClick(List<ProGoods> arg1, Action<List<Goods>> arg2)
		{
			Action<List<ProGoods>, Action<List<Goods>>> eventOnAlchemyButtonClick = this.EventOnAlchemyButtonClick;
			if (eventOnAlchemyButtonClick != null)
			{
				eventOnAlchemyButtonClick(arg1, arg2);
			}
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x002DBAD8 File Offset: 0x002D9CD8
		private void __clearDele_EventOnAlchemyButtonClick(List<ProGoods> arg1, Action<List<Goods>> arg2)
		{
			this.EventOnAlchemyButtonClick = null;
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x002DBB90 File Offset: 0x002D9D90
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
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_SetPointBgContent_hotfix = (luaObj.RawGet("SetPointBgContent") as LuaFunction);
					this.m_IsBagItemOfDisplayTypeBagItemBase_hotfix = (luaObj.RawGet("IsBagItemOfDisplayType") as LuaFunction);
					this.m_BagItemComparerBagItemBaseBagItemBase_hotfix = (luaObj.RawGet("BagItemComparer") as LuaFunction);
					this.m_OnBagItemClickUIControllerBase_hotfix = (luaObj.RawGet("OnBagItemClick") as LuaFunction);
					this.m_ShowRewardListPanel_hotfix = (luaObj.RawGet("ShowRewardListPanel") as LuaFunction);
					this.m_CloseRewardListPanel_hotfix = (luaObj.RawGet("CloseRewardListPanel") as LuaFunction);
					this.m_OnBagItemNeedFillUIControllerBase_hotfix = (luaObj.RawGet("OnBagItemNeedFill") as LuaFunction);
					this.m_CloseRewardGoodsDescPanel_hotfix = (luaObj.RawGet("CloseRewardGoodsDescPanel") as LuaFunction);
					this.m_OpenSubUseItemPanel_hotfix = (luaObj.RawGet("OpenSubUseItemPanel") as LuaFunction);
					this.m_SetLastAlchemyCountString_hotfix = (luaObj.RawGet("SetLastAlchemyCount") as LuaFunction);
					this.m_GetLastAlchemyCount_hotfix = (luaObj.RawGet("GetLastAlchemyCount") as LuaFunction);
					this.m_OnSubItemUseItemClick_hotfix = (luaObj.RawGet("OnSubItemUseItemClick") as LuaFunction);
					this.m_OnItemMinusButtonClick_hotfix = (luaObj.RawGet("OnItemMinusButtonClick") as LuaFunction);
					this.m_OnItemAddButtonClick_hotfix = (luaObj.RawGet("OnItemAddButtonClick") as LuaFunction);
					this.m_OnItemMaxButtonClick_hotfix = (luaObj.RawGet("OnItemMaxButtonClick") as LuaFunction);
					this.m_CloseSubItemUsePanel_hotfix = (luaObj.RawGet("CloseSubItemUsePanel") as LuaFunction);
					this.m_OnInputEditEndString_hotfix = (luaObj.RawGet("OnInputEditEnd") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnAlchemyButtonClick_hotfix = (luaObj.RawGet("OnAlchemyButtonClick") as LuaFunction);
					this.m_OnAlchemySucceedList`1_hotfix = (luaObj.RawGet("OnAlchemySucceed") as LuaFunction);
					this.m_ResetAlchemyUIView_hotfix = (luaObj.RawGet("ResetAlchemyUIView") as LuaFunction);
					this.m_ResetScrollViewToTop_hotfix = (luaObj.RawGet("ResetScrollViewToTop") as LuaFunction);
					this.m_OnItemToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnItemToggleValueChanged") as LuaFunction);
					this.m_OnJobMaterialToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnJobMaterialToggleValueChanged") as LuaFunction);
					this.m_OnEquipmentToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnEquipmentToggleValueChanged") as LuaFunction);
					this.m_OnFragmentToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnFragmentToggleValueChanged") as LuaFunction);
					this.m_OnToggleChanged_hotfix = (luaObj.RawGet("OnToggleChanged") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnAlchemyButtonClickAction`2_hotfix = (luaObj.RawGet("add_EventOnAlchemyButtonClick") as LuaFunction);
					this.m_remove_EventOnAlchemyButtonClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnAlchemyButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A1BD RID: 41405 RVA: 0x002DBFF8 File Offset: 0x002DA1F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AlchemyUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006C5E RID: 27742
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04006C5F RID: 27743
		[AutoBind("./PlayerResource/MithralStone/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_mithralStoneText;

		// Token: 0x04006C60 RID: 27744
		[AutoBind("./PlayerResource/BrillianceMithralStone/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_brillianceMithralStoneText;

		// Token: 0x04006C61 RID: 27745
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Item", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_itemToggle;

		// Token: 0x04006C62 RID: 27746
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Equipment", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_equipmentToggle;

		// Token: 0x04006C63 RID: 27747
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Fragment", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_fragmentToggle;

		// Token: 0x04006C64 RID: 27748
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/JobMaterial", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_jobMaterialToggle;

		// Token: 0x04006C65 RID: 27749
		[AutoBind("./AlchemyButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_alchemyButton;

		// Token: 0x04006C66 RID: 27750
		[AutoBind("./AlchemyButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_alchemyButtonStateCtrl;

		// Token: 0x04006C67 RID: 27751
		[AutoBind("./L_gold metallurgy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_effectGameObject;

		// Token: 0x04006C68 RID: 27752
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04006C69 RID: 27753
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04006C6A RID: 27754
		[AutoBind("./BagListPanel/BagListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private LoopVerticalScrollRect m_loopScrollView;

		// Token: 0x04006C6B RID: 27755
		[AutoBind("./BagListPanel/BagListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private EasyObjectPool m_listItemPool;

		// Token: 0x04006C6C RID: 27756
		[AutoBind("./BagListPanel/BagListScrollView/ItemRoot", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_listScrollViewItemTemplateRoot;

		// Token: 0x04006C6D RID: 27757
		[AutoBind("./BagListPanel/BagListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scrollViewBagItemContent;

		// Token: 0x04006C6E RID: 27758
		[AutoBind("./BagListPanel/BagListScrollView/Viewport/BgContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bagListPointBgContent;

		// Token: 0x04006C6F RID: 27759
		[AutoBind("./BagListPanel/BagListScrollView/Viewport/Point", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bagListPointItem;

		// Token: 0x04006C70 RID: 27760
		[AutoBind("./RewardListPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardListPanelGo;

		// Token: 0x04006C71 RID: 27761
		[AutoBind("./RewardListPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_rewardListPanelStateCtrl;

		// Token: 0x04006C72 RID: 27762
		[AutoBind("./RewardListPanel/BGImage/FrameImage/RewardGroup/Viewport/ItemGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardsContent;

		// Token: 0x04006C73 RID: 27763
		[AutoBind("./RewardListPanel/BGImage/FrameImage/Nothing", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardsNothingGo;

		// Token: 0x04006C74 RID: 27764
		[AutoBind("./RewardListPanel/BGImage/FrameImage/InfoGroup/MaterialCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rewardsMaterialCountText;

		// Token: 0x04006C75 RID: 27765
		[AutoBind("./RewardListPanel/BGImage/FrameImage/InfoGroup/GoldenValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rewardsGoldenValueText;

		// Token: 0x04006C76 RID: 27766
		[AutoBind("./RewardListPanel/BGImage/FrameImage/NoticText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardsNoticTextGo;

		// Token: 0x04006C77 RID: 27767
		[AutoBind("./RewardListPanel/BGImage/FrameImage/NoticText/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rewardsNoticText;

		// Token: 0x04006C78 RID: 27768
		[AutoBind("./UseItemsPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_subBagInfoPanelObj;

		// Token: 0x04006C79 RID: 27769
		[AutoBind("./UseItemsPanel/PanelDetail/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_subItemNumInputField;

		// Token: 0x04006C7A RID: 27770
		[AutoBind("./UseItemsPanel/PanelDetail/UseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subItemUseButton;

		// Token: 0x04006C7B RID: 27771
		[AutoBind("./UseItemsPanel/ReturnImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subItemPanelReturnButton;

		// Token: 0x04006C7C RID: 27772
		[AutoBind("./UseItemsPanel/PanelDetail/Minus", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subItemMinusButton;

		// Token: 0x04006C7D RID: 27773
		[AutoBind("./UseItemsPanel/PanelDetail/Add", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subItemAddButton;

		// Token: 0x04006C7E RID: 27774
		[AutoBind("./UseItemsPanel/PanelDetail/Max", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subItemMaxButton;

		// Token: 0x04006C7F RID: 27775
		[AutoBind("./UseItemsPanel/PanelDetail/AvailalbeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_subItemAvailalbeValueText;

		// Token: 0x04006C80 RID: 27776
		private AlchemyUIController.DisplayType m_displayType = AlchemyUIController.DisplayType.Item;

		// Token: 0x04006C81 RID: 27777
		private List<BagItemBase> m_bagItemCache = new List<BagItemBase>();

		// Token: 0x04006C82 RID: 27778
		private List<BagItemUIController> m_bagItemCtrlList = new List<BagItemUIController>();

		// Token: 0x04006C83 RID: 27779
		private Dictionary<BagItemBase, int> m_checkBagItemToCountDict = new Dictionary<BagItemBase, int>();

		// Token: 0x04006C84 RID: 27780
		private BagItemBase m_lastCheckBagItem;

		// Token: 0x04006C85 RID: 27781
		private int m_canAlchemyListIndex;

		// Token: 0x04006C86 RID: 27782
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04006C87 RID: 27783
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04006C88 RID: 27784
		[DoNotToLua]
		private AlchemyUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006C89 RID: 27785
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006C8A RID: 27786
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006C8B RID: 27787
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006C8C RID: 27788
		private LuaFunction m_InitLoopScrollViewRect_hotfix;

		// Token: 0x04006C8D RID: 27789
		private LuaFunction m_Open_hotfix;

		// Token: 0x04006C8E RID: 27790
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04006C8F RID: 27791
		private LuaFunction m_SetPointBgContent_hotfix;

		// Token: 0x04006C90 RID: 27792
		private LuaFunction m_IsBagItemOfDisplayTypeBagItemBase_hotfix;

		// Token: 0x04006C91 RID: 27793
		private LuaFunction m_BagItemComparerBagItemBaseBagItemBase_hotfix;

		// Token: 0x04006C92 RID: 27794
		private LuaFunction m_OnBagItemClickUIControllerBase_hotfix;

		// Token: 0x04006C93 RID: 27795
		private LuaFunction m_ShowRewardListPanel_hotfix;

		// Token: 0x04006C94 RID: 27796
		private LuaFunction m_CloseRewardListPanel_hotfix;

		// Token: 0x04006C95 RID: 27797
		private LuaFunction m_OnBagItemNeedFillUIControllerBase_hotfix;

		// Token: 0x04006C96 RID: 27798
		private LuaFunction m_CloseRewardGoodsDescPanel_hotfix;

		// Token: 0x04006C97 RID: 27799
		private LuaFunction m_OpenSubUseItemPanel_hotfix;

		// Token: 0x04006C98 RID: 27800
		private LuaFunction m_SetLastAlchemyCountString_hotfix;

		// Token: 0x04006C99 RID: 27801
		private LuaFunction m_GetLastAlchemyCount_hotfix;

		// Token: 0x04006C9A RID: 27802
		private LuaFunction m_OnSubItemUseItemClick_hotfix;

		// Token: 0x04006C9B RID: 27803
		private LuaFunction m_OnItemMinusButtonClick_hotfix;

		// Token: 0x04006C9C RID: 27804
		private LuaFunction m_OnItemAddButtonClick_hotfix;

		// Token: 0x04006C9D RID: 27805
		private LuaFunction m_OnItemMaxButtonClick_hotfix;

		// Token: 0x04006C9E RID: 27806
		private LuaFunction m_CloseSubItemUsePanel_hotfix;

		// Token: 0x04006C9F RID: 27807
		private LuaFunction m_OnInputEditEndString_hotfix;

		// Token: 0x04006CA0 RID: 27808
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04006CA1 RID: 27809
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04006CA2 RID: 27810
		private LuaFunction m_OnAlchemyButtonClick_hotfix;

		// Token: 0x04006CA3 RID: 27811
		private LuaFunction m_OnAlchemySucceedList;

		// Token: 0x04006CA4 RID: 27812
		private LuaFunction m_ResetAlchemyUIView_hotfix;

		// Token: 0x04006CA5 RID: 27813
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x04006CA6 RID: 27814
		private LuaFunction m_OnItemToggleValueChangedBoolean_hotfix;

		// Token: 0x04006CA7 RID: 27815
		private LuaFunction m_OnJobMaterialToggleValueChangedBoolean_hotfix;

		// Token: 0x04006CA8 RID: 27816
		private LuaFunction m_OnEquipmentToggleValueChangedBoolean_hotfix;

		// Token: 0x04006CA9 RID: 27817
		private LuaFunction m_OnFragmentToggleValueChangedBoolean_hotfix;

		// Token: 0x04006CAA RID: 27818
		private LuaFunction m_OnToggleChanged_hotfix;

		// Token: 0x04006CAB RID: 27819
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04006CAC RID: 27820
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04006CAD RID: 27821
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04006CAE RID: 27822
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04006CAF RID: 27823
		private LuaFunction m_add_EventOnAlchemyButtonClickAction;

		// Token: 0x04006CB0 RID: 27824
		private LuaFunction m_remove_EventOnAlchemyButtonClickAction;

		// Token: 0x02000A44 RID: 2628
		public enum DisplayType
		{
			// Token: 0x04006CB2 RID: 27826
			None,
			// Token: 0x04006CB3 RID: 27827
			Item,
			// Token: 0x04006CB4 RID: 27828
			Fragment,
			// Token: 0x04006CB5 RID: 27829
			JobMaterial,
			// Token: 0x04006CB6 RID: 27830
			Equipment
		}

		// Token: 0x02000A45 RID: 2629
		public new class LuaExportHelper
		{
			// Token: 0x0600A1BE RID: 41406 RVA: 0x002DC060 File Offset: 0x002DA260
			public LuaExportHelper(AlchemyUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A1BF RID: 41407 RVA: 0x002DC070 File Offset: 0x002DA270
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A1C0 RID: 41408 RVA: 0x002DC080 File Offset: 0x002DA280
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A1C1 RID: 41409 RVA: 0x002DC090 File Offset: 0x002DA290
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A1C2 RID: 41410 RVA: 0x002DC0A0 File Offset: 0x002DA2A0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A1C3 RID: 41411 RVA: 0x002DC0B8 File Offset: 0x002DA2B8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A1C4 RID: 41412 RVA: 0x002DC0C8 File Offset: 0x002DA2C8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A1C5 RID: 41413 RVA: 0x002DC0D8 File Offset: 0x002DA2D8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A1C6 RID: 41414 RVA: 0x002DC0E8 File Offset: 0x002DA2E8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A1C7 RID: 41415 RVA: 0x002DC0F8 File Offset: 0x002DA2F8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A1C8 RID: 41416 RVA: 0x002DC108 File Offset: 0x002DA308
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A1C9 RID: 41417 RVA: 0x002DC118 File Offset: 0x002DA318
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A1CA RID: 41418 RVA: 0x002DC128 File Offset: 0x002DA328
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A1CB RID: 41419 RVA: 0x002DC138 File Offset: 0x002DA338
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A1CC RID: 41420 RVA: 0x002DC148 File Offset: 0x002DA348
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A1CD RID: 41421 RVA: 0x002DC158 File Offset: 0x002DA358
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600A1CE RID: 41422 RVA: 0x002DC168 File Offset: 0x002DA368
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600A1CF RID: 41423 RVA: 0x002DC178 File Offset: 0x002DA378
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600A1D0 RID: 41424 RVA: 0x002DC188 File Offset: 0x002DA388
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600A1D1 RID: 41425 RVA: 0x002DC198 File Offset: 0x002DA398
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600A1D2 RID: 41426 RVA: 0x002DC1A8 File Offset: 0x002DA3A8
			public void __callDele_EventOnAlchemyButtonClick(List<ProGoods> arg1, Action<List<Goods>> arg2)
			{
				this.m_owner.__callDele_EventOnAlchemyButtonClick(arg1, arg2);
			}

			// Token: 0x0600A1D3 RID: 41427 RVA: 0x002DC1B8 File Offset: 0x002DA3B8
			public void __clearDele_EventOnAlchemyButtonClick(List<ProGoods> arg1, Action<List<Goods>> arg2)
			{
				this.m_owner.__clearDele_EventOnAlchemyButtonClick(arg1, arg2);
			}

			// Token: 0x170020D6 RID: 8406
			// (get) Token: 0x0600A1D4 RID: 41428 RVA: 0x002DC1C8 File Offset: 0x002DA3C8
			// (set) Token: 0x0600A1D5 RID: 41429 RVA: 0x002DC1D8 File Offset: 0x002DA3D8
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

			// Token: 0x170020D7 RID: 8407
			// (get) Token: 0x0600A1D6 RID: 41430 RVA: 0x002DC1E8 File Offset: 0x002DA3E8
			// (set) Token: 0x0600A1D7 RID: 41431 RVA: 0x002DC1F8 File Offset: 0x002DA3F8
			public Text m_mithralStoneText
			{
				get
				{
					return this.m_owner.m_mithralStoneText;
				}
				set
				{
					this.m_owner.m_mithralStoneText = value;
				}
			}

			// Token: 0x170020D8 RID: 8408
			// (get) Token: 0x0600A1D8 RID: 41432 RVA: 0x002DC208 File Offset: 0x002DA408
			// (set) Token: 0x0600A1D9 RID: 41433 RVA: 0x002DC218 File Offset: 0x002DA418
			public Text m_brillianceMithralStoneText
			{
				get
				{
					return this.m_owner.m_brillianceMithralStoneText;
				}
				set
				{
					this.m_owner.m_brillianceMithralStoneText = value;
				}
			}

			// Token: 0x170020D9 RID: 8409
			// (get) Token: 0x0600A1DA RID: 41434 RVA: 0x002DC228 File Offset: 0x002DA428
			// (set) Token: 0x0600A1DB RID: 41435 RVA: 0x002DC238 File Offset: 0x002DA438
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

			// Token: 0x170020DA RID: 8410
			// (get) Token: 0x0600A1DC RID: 41436 RVA: 0x002DC248 File Offset: 0x002DA448
			// (set) Token: 0x0600A1DD RID: 41437 RVA: 0x002DC258 File Offset: 0x002DA458
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

			// Token: 0x170020DB RID: 8411
			// (get) Token: 0x0600A1DE RID: 41438 RVA: 0x002DC268 File Offset: 0x002DA468
			// (set) Token: 0x0600A1DF RID: 41439 RVA: 0x002DC278 File Offset: 0x002DA478
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

			// Token: 0x170020DC RID: 8412
			// (get) Token: 0x0600A1E0 RID: 41440 RVA: 0x002DC288 File Offset: 0x002DA488
			// (set) Token: 0x0600A1E1 RID: 41441 RVA: 0x002DC298 File Offset: 0x002DA498
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

			// Token: 0x170020DD RID: 8413
			// (get) Token: 0x0600A1E2 RID: 41442 RVA: 0x002DC2A8 File Offset: 0x002DA4A8
			// (set) Token: 0x0600A1E3 RID: 41443 RVA: 0x002DC2B8 File Offset: 0x002DA4B8
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

			// Token: 0x170020DE RID: 8414
			// (get) Token: 0x0600A1E4 RID: 41444 RVA: 0x002DC2C8 File Offset: 0x002DA4C8
			// (set) Token: 0x0600A1E5 RID: 41445 RVA: 0x002DC2D8 File Offset: 0x002DA4D8
			public CommonUIStateController m_alchemyButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_alchemyButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_alchemyButtonStateCtrl = value;
				}
			}

			// Token: 0x170020DF RID: 8415
			// (get) Token: 0x0600A1E6 RID: 41446 RVA: 0x002DC2E8 File Offset: 0x002DA4E8
			// (set) Token: 0x0600A1E7 RID: 41447 RVA: 0x002DC2F8 File Offset: 0x002DA4F8
			public GameObject m_effectGameObject
			{
				get
				{
					return this.m_owner.m_effectGameObject;
				}
				set
				{
					this.m_owner.m_effectGameObject = value;
				}
			}

			// Token: 0x170020E0 RID: 8416
			// (get) Token: 0x0600A1E8 RID: 41448 RVA: 0x002DC308 File Offset: 0x002DA508
			// (set) Token: 0x0600A1E9 RID: 41449 RVA: 0x002DC318 File Offset: 0x002DA518
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

			// Token: 0x170020E1 RID: 8417
			// (get) Token: 0x0600A1EA RID: 41450 RVA: 0x002DC328 File Offset: 0x002DA528
			// (set) Token: 0x0600A1EB RID: 41451 RVA: 0x002DC338 File Offset: 0x002DA538
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

			// Token: 0x170020E2 RID: 8418
			// (get) Token: 0x0600A1EC RID: 41452 RVA: 0x002DC348 File Offset: 0x002DA548
			// (set) Token: 0x0600A1ED RID: 41453 RVA: 0x002DC358 File Offset: 0x002DA558
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

			// Token: 0x170020E3 RID: 8419
			// (get) Token: 0x0600A1EE RID: 41454 RVA: 0x002DC368 File Offset: 0x002DA568
			// (set) Token: 0x0600A1EF RID: 41455 RVA: 0x002DC378 File Offset: 0x002DA578
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

			// Token: 0x170020E4 RID: 8420
			// (get) Token: 0x0600A1F0 RID: 41456 RVA: 0x002DC388 File Offset: 0x002DA588
			// (set) Token: 0x0600A1F1 RID: 41457 RVA: 0x002DC398 File Offset: 0x002DA598
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

			// Token: 0x170020E5 RID: 8421
			// (get) Token: 0x0600A1F2 RID: 41458 RVA: 0x002DC3A8 File Offset: 0x002DA5A8
			// (set) Token: 0x0600A1F3 RID: 41459 RVA: 0x002DC3B8 File Offset: 0x002DA5B8
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

			// Token: 0x170020E6 RID: 8422
			// (get) Token: 0x0600A1F4 RID: 41460 RVA: 0x002DC3C8 File Offset: 0x002DA5C8
			// (set) Token: 0x0600A1F5 RID: 41461 RVA: 0x002DC3D8 File Offset: 0x002DA5D8
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

			// Token: 0x170020E7 RID: 8423
			// (get) Token: 0x0600A1F6 RID: 41462 RVA: 0x002DC3E8 File Offset: 0x002DA5E8
			// (set) Token: 0x0600A1F7 RID: 41463 RVA: 0x002DC3F8 File Offset: 0x002DA5F8
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

			// Token: 0x170020E8 RID: 8424
			// (get) Token: 0x0600A1F8 RID: 41464 RVA: 0x002DC408 File Offset: 0x002DA608
			// (set) Token: 0x0600A1F9 RID: 41465 RVA: 0x002DC418 File Offset: 0x002DA618
			public GameObject m_rewardListPanelGo
			{
				get
				{
					return this.m_owner.m_rewardListPanelGo;
				}
				set
				{
					this.m_owner.m_rewardListPanelGo = value;
				}
			}

			// Token: 0x170020E9 RID: 8425
			// (get) Token: 0x0600A1FA RID: 41466 RVA: 0x002DC428 File Offset: 0x002DA628
			// (set) Token: 0x0600A1FB RID: 41467 RVA: 0x002DC438 File Offset: 0x002DA638
			public CommonUIStateController m_rewardListPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_rewardListPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_rewardListPanelStateCtrl = value;
				}
			}

			// Token: 0x170020EA RID: 8426
			// (get) Token: 0x0600A1FC RID: 41468 RVA: 0x002DC448 File Offset: 0x002DA648
			// (set) Token: 0x0600A1FD RID: 41469 RVA: 0x002DC458 File Offset: 0x002DA658
			public GameObject m_rewardsContent
			{
				get
				{
					return this.m_owner.m_rewardsContent;
				}
				set
				{
					this.m_owner.m_rewardsContent = value;
				}
			}

			// Token: 0x170020EB RID: 8427
			// (get) Token: 0x0600A1FE RID: 41470 RVA: 0x002DC468 File Offset: 0x002DA668
			// (set) Token: 0x0600A1FF RID: 41471 RVA: 0x002DC478 File Offset: 0x002DA678
			public GameObject m_rewardsNothingGo
			{
				get
				{
					return this.m_owner.m_rewardsNothingGo;
				}
				set
				{
					this.m_owner.m_rewardsNothingGo = value;
				}
			}

			// Token: 0x170020EC RID: 8428
			// (get) Token: 0x0600A200 RID: 41472 RVA: 0x002DC488 File Offset: 0x002DA688
			// (set) Token: 0x0600A201 RID: 41473 RVA: 0x002DC498 File Offset: 0x002DA698
			public Text m_rewardsMaterialCountText
			{
				get
				{
					return this.m_owner.m_rewardsMaterialCountText;
				}
				set
				{
					this.m_owner.m_rewardsMaterialCountText = value;
				}
			}

			// Token: 0x170020ED RID: 8429
			// (get) Token: 0x0600A202 RID: 41474 RVA: 0x002DC4A8 File Offset: 0x002DA6A8
			// (set) Token: 0x0600A203 RID: 41475 RVA: 0x002DC4B8 File Offset: 0x002DA6B8
			public Text m_rewardsGoldenValueText
			{
				get
				{
					return this.m_owner.m_rewardsGoldenValueText;
				}
				set
				{
					this.m_owner.m_rewardsGoldenValueText = value;
				}
			}

			// Token: 0x170020EE RID: 8430
			// (get) Token: 0x0600A204 RID: 41476 RVA: 0x002DC4C8 File Offset: 0x002DA6C8
			// (set) Token: 0x0600A205 RID: 41477 RVA: 0x002DC4D8 File Offset: 0x002DA6D8
			public GameObject m_rewardsNoticTextGo
			{
				get
				{
					return this.m_owner.m_rewardsNoticTextGo;
				}
				set
				{
					this.m_owner.m_rewardsNoticTextGo = value;
				}
			}

			// Token: 0x170020EF RID: 8431
			// (get) Token: 0x0600A206 RID: 41478 RVA: 0x002DC4E8 File Offset: 0x002DA6E8
			// (set) Token: 0x0600A207 RID: 41479 RVA: 0x002DC4F8 File Offset: 0x002DA6F8
			public Text m_rewardsNoticText
			{
				get
				{
					return this.m_owner.m_rewardsNoticText;
				}
				set
				{
					this.m_owner.m_rewardsNoticText = value;
				}
			}

			// Token: 0x170020F0 RID: 8432
			// (get) Token: 0x0600A208 RID: 41480 RVA: 0x002DC508 File Offset: 0x002DA708
			// (set) Token: 0x0600A209 RID: 41481 RVA: 0x002DC518 File Offset: 0x002DA718
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

			// Token: 0x170020F1 RID: 8433
			// (get) Token: 0x0600A20A RID: 41482 RVA: 0x002DC528 File Offset: 0x002DA728
			// (set) Token: 0x0600A20B RID: 41483 RVA: 0x002DC538 File Offset: 0x002DA738
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

			// Token: 0x170020F2 RID: 8434
			// (get) Token: 0x0600A20C RID: 41484 RVA: 0x002DC548 File Offset: 0x002DA748
			// (set) Token: 0x0600A20D RID: 41485 RVA: 0x002DC558 File Offset: 0x002DA758
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

			// Token: 0x170020F3 RID: 8435
			// (get) Token: 0x0600A20E RID: 41486 RVA: 0x002DC568 File Offset: 0x002DA768
			// (set) Token: 0x0600A20F RID: 41487 RVA: 0x002DC578 File Offset: 0x002DA778
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

			// Token: 0x170020F4 RID: 8436
			// (get) Token: 0x0600A210 RID: 41488 RVA: 0x002DC588 File Offset: 0x002DA788
			// (set) Token: 0x0600A211 RID: 41489 RVA: 0x002DC598 File Offset: 0x002DA798
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

			// Token: 0x170020F5 RID: 8437
			// (get) Token: 0x0600A212 RID: 41490 RVA: 0x002DC5A8 File Offset: 0x002DA7A8
			// (set) Token: 0x0600A213 RID: 41491 RVA: 0x002DC5B8 File Offset: 0x002DA7B8
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

			// Token: 0x170020F6 RID: 8438
			// (get) Token: 0x0600A214 RID: 41492 RVA: 0x002DC5C8 File Offset: 0x002DA7C8
			// (set) Token: 0x0600A215 RID: 41493 RVA: 0x002DC5D8 File Offset: 0x002DA7D8
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

			// Token: 0x170020F7 RID: 8439
			// (get) Token: 0x0600A216 RID: 41494 RVA: 0x002DC5E8 File Offset: 0x002DA7E8
			// (set) Token: 0x0600A217 RID: 41495 RVA: 0x002DC5F8 File Offset: 0x002DA7F8
			public Text m_subItemAvailalbeValueText
			{
				get
				{
					return this.m_owner.m_subItemAvailalbeValueText;
				}
				set
				{
					this.m_owner.m_subItemAvailalbeValueText = value;
				}
			}

			// Token: 0x170020F8 RID: 8440
			// (get) Token: 0x0600A218 RID: 41496 RVA: 0x002DC608 File Offset: 0x002DA808
			// (set) Token: 0x0600A219 RID: 41497 RVA: 0x002DC618 File Offset: 0x002DA818
			public AlchemyUIController.DisplayType m_displayType
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

			// Token: 0x170020F9 RID: 8441
			// (get) Token: 0x0600A21A RID: 41498 RVA: 0x002DC628 File Offset: 0x002DA828
			// (set) Token: 0x0600A21B RID: 41499 RVA: 0x002DC638 File Offset: 0x002DA838
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

			// Token: 0x170020FA RID: 8442
			// (get) Token: 0x0600A21C RID: 41500 RVA: 0x002DC648 File Offset: 0x002DA848
			// (set) Token: 0x0600A21D RID: 41501 RVA: 0x002DC658 File Offset: 0x002DA858
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

			// Token: 0x170020FB RID: 8443
			// (get) Token: 0x0600A21E RID: 41502 RVA: 0x002DC668 File Offset: 0x002DA868
			// (set) Token: 0x0600A21F RID: 41503 RVA: 0x002DC678 File Offset: 0x002DA878
			public Dictionary<BagItemBase, int> m_checkBagItemToCountDict
			{
				get
				{
					return this.m_owner.m_checkBagItemToCountDict;
				}
				set
				{
					this.m_owner.m_checkBagItemToCountDict = value;
				}
			}

			// Token: 0x170020FC RID: 8444
			// (get) Token: 0x0600A220 RID: 41504 RVA: 0x002DC688 File Offset: 0x002DA888
			// (set) Token: 0x0600A221 RID: 41505 RVA: 0x002DC698 File Offset: 0x002DA898
			public BagItemBase m_lastCheckBagItem
			{
				get
				{
					return this.m_owner.m_lastCheckBagItem;
				}
				set
				{
					this.m_owner.m_lastCheckBagItem = value;
				}
			}

			// Token: 0x170020FD RID: 8445
			// (get) Token: 0x0600A222 RID: 41506 RVA: 0x002DC6A8 File Offset: 0x002DA8A8
			// (set) Token: 0x0600A223 RID: 41507 RVA: 0x002DC6B8 File Offset: 0x002DA8B8
			public int m_canAlchemyListIndex
			{
				get
				{
					return this.m_owner.m_canAlchemyListIndex;
				}
				set
				{
					this.m_owner.m_canAlchemyListIndex = value;
				}
			}

			// Token: 0x170020FE RID: 8446
			// (get) Token: 0x0600A224 RID: 41508 RVA: 0x002DC6C8 File Offset: 0x002DA8C8
			// (set) Token: 0x0600A225 RID: 41509 RVA: 0x002DC6D8 File Offset: 0x002DA8D8
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

			// Token: 0x170020FF RID: 8447
			// (get) Token: 0x0600A226 RID: 41510 RVA: 0x002DC6E8 File Offset: 0x002DA8E8
			// (set) Token: 0x0600A227 RID: 41511 RVA: 0x002DC6F8 File Offset: 0x002DA8F8
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

			// Token: 0x0600A228 RID: 41512 RVA: 0x002DC708 File Offset: 0x002DA908
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600A229 RID: 41513 RVA: 0x002DC718 File Offset: 0x002DA918
			public void InitLoopScrollViewRect()
			{
				this.m_owner.InitLoopScrollViewRect();
			}

			// Token: 0x0600A22A RID: 41514 RVA: 0x002DC728 File Offset: 0x002DA928
			public void SetPointBgContent()
			{
				this.m_owner.SetPointBgContent();
			}

			// Token: 0x0600A22B RID: 41515 RVA: 0x002DC738 File Offset: 0x002DA938
			public bool IsBagItemOfDisplayType(BagItemBase itm)
			{
				return this.m_owner.IsBagItemOfDisplayType(itm);
			}

			// Token: 0x0600A22C RID: 41516 RVA: 0x002DC748 File Offset: 0x002DA948
			public int BagItemComparer(BagItemBase item1, BagItemBase item2)
			{
				return this.m_owner.BagItemComparer(item1, item2);
			}

			// Token: 0x0600A22D RID: 41517 RVA: 0x002DC758 File Offset: 0x002DA958
			public void OnBagItemClick(UIControllerBase itemCtrl)
			{
				this.m_owner.OnBagItemClick(itemCtrl);
			}

			// Token: 0x0600A22E RID: 41518 RVA: 0x002DC768 File Offset: 0x002DA968
			public void ShowRewardListPanel()
			{
				this.m_owner.ShowRewardListPanel();
			}

			// Token: 0x0600A22F RID: 41519 RVA: 0x002DC778 File Offset: 0x002DA978
			public void CloseRewardListPanel()
			{
				this.m_owner.CloseRewardListPanel();
			}

			// Token: 0x0600A230 RID: 41520 RVA: 0x002DC788 File Offset: 0x002DA988
			public void OnBagItemNeedFill(UIControllerBase itemCtrl)
			{
				this.m_owner.OnBagItemNeedFill(itemCtrl);
			}

			// Token: 0x0600A231 RID: 41521 RVA: 0x002DC798 File Offset: 0x002DA998
			public void CloseRewardGoodsDescPanel()
			{
				this.m_owner.CloseRewardGoodsDescPanel();
			}

			// Token: 0x0600A232 RID: 41522 RVA: 0x002DC7A8 File Offset: 0x002DA9A8
			public void OpenSubUseItemPanel()
			{
				this.m_owner.OpenSubUseItemPanel();
			}

			// Token: 0x0600A233 RID: 41523 RVA: 0x002DC7B8 File Offset: 0x002DA9B8
			public void SetLastAlchemyCount(string inputString)
			{
				this.m_owner.SetLastAlchemyCount(inputString);
			}

			// Token: 0x0600A234 RID: 41524 RVA: 0x002DC7C8 File Offset: 0x002DA9C8
			public int GetLastAlchemyCount()
			{
				return this.m_owner.GetLastAlchemyCount();
			}

			// Token: 0x0600A235 RID: 41525 RVA: 0x002DC7D8 File Offset: 0x002DA9D8
			public void OnSubItemUseItemClick()
			{
				this.m_owner.OnSubItemUseItemClick();
			}

			// Token: 0x0600A236 RID: 41526 RVA: 0x002DC7E8 File Offset: 0x002DA9E8
			public void OnItemMinusButtonClick()
			{
				this.m_owner.OnItemMinusButtonClick();
			}

			// Token: 0x0600A237 RID: 41527 RVA: 0x002DC7F8 File Offset: 0x002DA9F8
			public void OnItemAddButtonClick()
			{
				this.m_owner.OnItemAddButtonClick();
			}

			// Token: 0x0600A238 RID: 41528 RVA: 0x002DC808 File Offset: 0x002DAA08
			public void OnItemMaxButtonClick()
			{
				this.m_owner.OnItemMaxButtonClick();
			}

			// Token: 0x0600A239 RID: 41529 RVA: 0x002DC818 File Offset: 0x002DAA18
			public void CloseSubItemUsePanel()
			{
				this.m_owner.CloseSubItemUsePanel();
			}

			// Token: 0x0600A23A RID: 41530 RVA: 0x002DC828 File Offset: 0x002DAA28
			public void OnInputEditEnd(string str)
			{
				this.m_owner.OnInputEditEnd(str);
			}

			// Token: 0x0600A23B RID: 41531 RVA: 0x002DC838 File Offset: 0x002DAA38
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600A23C RID: 41532 RVA: 0x002DC848 File Offset: 0x002DAA48
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0600A23D RID: 41533 RVA: 0x002DC858 File Offset: 0x002DAA58
			public void OnAlchemyButtonClick()
			{
				this.m_owner.OnAlchemyButtonClick();
			}

			// Token: 0x0600A23E RID: 41534 RVA: 0x002DC868 File Offset: 0x002DAA68
			public IEnumerator OnAlchemySucceed(List<Goods> rewards)
			{
				return this.m_owner.OnAlchemySucceed(rewards);
			}

			// Token: 0x0600A23F RID: 41535 RVA: 0x002DC878 File Offset: 0x002DAA78
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x0600A240 RID: 41536 RVA: 0x002DC888 File Offset: 0x002DAA88
			public void OnItemToggleValueChanged(bool on)
			{
				this.m_owner.OnItemToggleValueChanged(on);
			}

			// Token: 0x0600A241 RID: 41537 RVA: 0x002DC898 File Offset: 0x002DAA98
			public void OnJobMaterialToggleValueChanged(bool on)
			{
				this.m_owner.OnJobMaterialToggleValueChanged(on);
			}

			// Token: 0x0600A242 RID: 41538 RVA: 0x002DC8A8 File Offset: 0x002DAAA8
			public void OnEquipmentToggleValueChanged(bool on)
			{
				this.m_owner.OnEquipmentToggleValueChanged(on);
			}

			// Token: 0x0600A243 RID: 41539 RVA: 0x002DC8B8 File Offset: 0x002DAAB8
			public void OnFragmentToggleValueChanged(bool on)
			{
				this.m_owner.OnFragmentToggleValueChanged(on);
			}

			// Token: 0x0600A244 RID: 41540 RVA: 0x002DC8C8 File Offset: 0x002DAAC8
			public void OnToggleChanged()
			{
				this.m_owner.OnToggleChanged();
			}

			// Token: 0x04006CB7 RID: 27831
			private AlchemyUIController m_owner;
		}
	}
}
