using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009D8 RID: 2520
	[HotFix]
	public class EquipmentArchiveUIController : UIControllerBase
	{
		// Token: 0x06009440 RID: 37952 RVA: 0x002AA4A4 File Offset: 0x002A86A4
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnClick));
			this.m_equipmentFilterButton.onClick.AddListener(new UnityAction(this.OnEquipmentFilterClick));
			this.m_filterBGButton.onClick.AddListener(new UnityAction(this.OnFilterBGClick));
			this.m_getButton.onClick.AddListener(new UnityAction(this.OnGetItemPathClick));
			this.m_aLLItemToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnEquipmentFilterSwitchClick(this.m_aLLItemToggle.gameObject);
				}
			});
			this.m_weaponItemToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnEquipmentFilterSwitchClick(this.m_weaponItemToggle.gameObject);
				}
			});
			this.m_armorItemToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnEquipmentFilterSwitchClick(this.m_armorItemToggle.gameObject);
				}
			});
			this.m_helmetItemToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnEquipmentFilterSwitchClick(this.m_helmetItemToggle.gameObject);
				}
			});
			this.m_ornamentItemToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnEquipmentFilterSwitchClick(this.m_ornamentItemToggle.gameObject);
				}
			});
			this.m_otherItemToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnEquipmentFilterSwitchClick(this.m_otherItemToggle.gameObject);
				}
			});
			this.m_itemDetailInfoController = GameObjectUtility.AddControllerToGameObject<ArchiveItemDetailInfoController>(this.m_equipmentInfoPanel);
			IEnumerable<KeyValuePair<int, ConfigDataEquipmentInfo>> allConfigDataEquipmentInfo = this.m_configDataLoader.GetAllConfigDataEquipmentInfo();
			foreach (KeyValuePair<int, ConfigDataEquipmentInfo> keyValuePair in allConfigDataEquipmentInfo)
			{
				if (keyValuePair.Value.ArchiveDisplay)
				{
					EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap = new EquipmentArchiveUIController.EquipmentInfoWrap();
					equipmentInfoWrap.equipmentInfo = keyValuePair.Value;
					equipmentInfoWrap.isUnlocked = false;
					if (this.m_playerContext.HasOwn(GoodsType.GoodsType_Equipment, keyValuePair.Value.ID))
					{
						equipmentInfoWrap.isUnlocked = true;
						this.m_allOwnItemCount++;
						switch (keyValuePair.Value.EquipmentType)
						{
						case EquipmentType.EquipmentType_Weapon:
							this.m_weaponOwnItemCount++;
							break;
						case EquipmentType.EquipmentType_Armor:
							this.m_armorOwnItemCount++;
							break;
						case EquipmentType.EquipmentType_Helmet:
							this.m_helmetOwnItemCount++;
							break;
						case EquipmentType.EquipmentType_Ornament:
							this.m_ornamentOwnItemCount++;
							break;
						case EquipmentType.EquipmentType_Enhancement:
						case EquipmentType.EquipmentType_LevelUpStar:
							this.m_otherOwnItemCount++;
							break;
						}
					}
					this.m_allBagItemList.Add(equipmentInfoWrap);
					switch (keyValuePair.Value.EquipmentType)
					{
					case EquipmentType.EquipmentType_Weapon:
						this.m_weaponBagItemList.Add(equipmentInfoWrap);
						break;
					case EquipmentType.EquipmentType_Armor:
						this.m_armorBagItemList.Add(equipmentInfoWrap);
						break;
					case EquipmentType.EquipmentType_Helmet:
						this.m_helmetBagItemList.Add(equipmentInfoWrap);
						break;
					case EquipmentType.EquipmentType_Ornament:
						this.m_ornamentBagItemList.Add(equipmentInfoWrap);
						break;
					case EquipmentType.EquipmentType_Enhancement:
					case EquipmentType.EquipmentType_LevelUpStar:
						this.m_otherBagItemList.Add(equipmentInfoWrap);
						break;
					}
				}
			}
			this.m_allBagItemList.Sort(new Comparison<EquipmentArchiveUIController.EquipmentInfoWrap>(this.ItemListCompare));
			this.m_armorBagItemList.Sort(new Comparison<EquipmentArchiveUIController.EquipmentInfoWrap>(this.ItemListCompare));
			this.m_helmetBagItemList.Sort(new Comparison<EquipmentArchiveUIController.EquipmentInfoWrap>(this.ItemListCompare));
			this.m_ornamentBagItemList.Sort(new Comparison<EquipmentArchiveUIController.EquipmentInfoWrap>(this.ItemListCompare));
			this.m_weaponBagItemList.Sort(new Comparison<EquipmentArchiveUIController.EquipmentInfoWrap>(this.ItemListCompare));
			this.m_otherBagItemList.Sort(new Comparison<EquipmentArchiveUIController.EquipmentInfoWrap>(this.ItemListCompare));
			this.RefreshItemCount(this.m_allOwnItemCount, this.m_allBagItemList.Count);
			this.m_selectBagItemList = this.m_allBagItemList;
			for (int i = 0; i < this.m_itemContentInfinityGrid.MinAmount; i++)
			{
				GameObject go = GameObjectUtility.CloneGameObject(this.m_itemPrefab, this.m_itemContent.transform);
				ArchiveItemUIController archiveItemUIController = GameObjectUtility.AddControllerToGameObject<ArchiveItemUIController>(go);
				archiveItemUIController.OnItemClickEvent += this.OnItemClick;
				this.m_itemUIControllerList.Add(archiveItemUIController);
			}
			InfinityGridLayoutGroup itemContentInfinityGrid = this.m_itemContentInfinityGrid;
			itemContentInfinityGrid.updateChildrenCallback = (InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate)Delegate.Combine(itemContentInfinityGrid.updateChildrenCallback, new InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate(this.UpdateChildrenCallbackDelegate));
			this.m_itemContentInfinityGrid.SetAmount(this.m_selectBagItemList.Count);
		}

		// Token: 0x06009441 RID: 37953 RVA: 0x002AA988 File Offset: 0x002A8B88
		public void SetTask(ArchiveUITask task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTaskArchiveUITask_hotfix != null)
			{
				this.m_SetTaskArchiveUITask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_task = task;
		}

		// Token: 0x06009442 RID: 37954 RVA: 0x002AAA00 File Offset: 0x002A8C00
		public void EnterController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnterController_hotfix != null)
			{
				this.m_EnterController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_prefabAnimation.SetToUIState("Show", false, true);
			this.m_task.CustomLoadAsset(delegate
			{
				foreach (EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap in this.m_allBagItemList)
				{
					ConfigDataEquipmentInfo equipmentInfo = equipmentInfoWrap.equipmentInfo;
					if (equipmentInfo != null)
					{
						this.m_task.CollectSpriteAssetWrap(equipmentInfo.Icon);
					}
				}
			}, delegate
			{
				this.m_weaponItemToggle.isOn = false;
				this.m_armorItemToggle.isOn = false;
				this.m_helmetItemToggle.isOn = false;
				this.m_ornamentItemToggle.isOn = false;
				this.m_otherItemToggle.isOn = false;
				this.m_aLLItemToggle.isOn = true;
				this.CreateItemList(this.m_allBagItemList);
			});
		}

		// Token: 0x06009443 RID: 37955 RVA: 0x002AAA98 File Offset: 0x002A8C98
		private int ItemListCompare(EquipmentArchiveUIController.EquipmentInfoWrap equipmentWrap1, EquipmentArchiveUIController.EquipmentInfoWrap equipmentWrap2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ItemListCompareEquipmentInfoWrapEquipmentInfoWrap_hotfix != null)
			{
				return Convert.ToInt32(this.m_ItemListCompareEquipmentInfoWrapEquipmentInfoWrap_hotfix.call(new object[]
				{
					this,
					equipmentWrap1,
					equipmentWrap2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentInfo equipmentInfo = equipmentWrap1.equipmentInfo;
			ConfigDataEquipmentInfo equipmentInfo2 = equipmentWrap2.equipmentInfo;
			return equipmentInfo2.Rank - equipmentInfo.Rank;
		}

		// Token: 0x06009444 RID: 37956 RVA: 0x002AAB44 File Offset: 0x002A8D44
		private void RefreshItem(ArchiveItemUIController archiveItemUIController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshItemArchiveItemUIController_hotfix != null)
			{
				this.m_RefreshItemArchiveItemUIController_hotfix.call(new object[]
				{
					this,
					archiveItemUIController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_selectEquipmentInfoWrap != null)
			{
				this.m_selectEquipmentInfoWrap.isSelect = false;
				this.RefreshItemBagWithHeroData(this.m_selectEquipmentInfoWrap);
			}
			archiveItemUIController.SetSelected(true);
			this.m_selectEquipmentInfoWrap = archiveItemUIController.m_equipmentInfoWrap;
			this.m_itemDetailInfoController.SetData(archiveItemUIController.m_equipmentInfoWrap);
		}

		// Token: 0x06009445 RID: 37957 RVA: 0x002AABFC File Offset: 0x002A8DFC
		private void RefreshItemCount(int currentCount, int maxCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshItemCountInt32Int32_hotfix != null)
			{
				this.m_RefreshItemCountInt32Int32_hotfix.call(new object[]
				{
					this,
					currentCount,
					maxCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currentItemCountText.text = currentCount.ToString();
			this.m_maxItemCountText.text = maxCount.ToString();
		}

		// Token: 0x06009446 RID: 37958 RVA: 0x002AACAC File Offset: 0x002A8EAC
		private void CreateItemList(List<EquipmentArchiveUIController.EquipmentInfoWrap> equipmentInfoWrapList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateItemListList`1_hotfix != null)
			{
				this.m_CreateItemListList`1_hotfix.call(new object[]
				{
					this,
					equipmentInfoWrapList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectBagItemList = equipmentInfoWrapList;
			this.m_itemContentInfinityGrid.SetAmount(this.m_selectBagItemList.Count);
			foreach (EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap in this.m_selectBagItemList)
			{
				equipmentInfoWrap.isSelect = false;
			}
			if (this.m_selectBagItemList.Count > 0)
			{
				this.m_task.PostDelayTimeExecuteAction(delegate
				{
					this.m_selectEquipmentInfoWrap = this.m_itemUIControllerList[0].m_equipmentInfoWrap;
					this.m_itemUIControllerList[0].SetSelected(true);
					this.m_itemDetailInfoController.SetData(this.m_itemUIControllerList[0].m_equipmentInfoWrap);
				}, 0.1f);
			}
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x002AADB8 File Offset: 0x002A8FB8
		private void DestroyItemBagList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyItemBagList_hotfix != null)
			{
				this.m_DestroyItemBagList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = this.m_itemUIControllerList.Count - 1; i >= 0; i--)
			{
				UnityEngine.Object.Destroy(this.m_itemUIControllerList[i].gameObject);
				this.m_itemUIControllerList.RemoveAt(i);
			}
		}

		// Token: 0x06009448 RID: 37960 RVA: 0x002AAE58 File Offset: 0x002A9058
		private void RefreshItemBagWithHeroData(EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshItemBagWithHeroDataEquipmentInfoWrap_hotfix != null)
			{
				this.m_RefreshItemBagWithHeroDataEquipmentInfoWrap_hotfix.call(new object[]
				{
					this,
					equipmentInfoWrap
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ArchiveItemUIController archiveItemUIController in this.m_itemUIControllerList)
			{
				if (archiveItemUIController.m_equipmentInfoWrap == equipmentInfoWrap)
				{
					archiveItemUIController.Refresh();
					break;
				}
			}
		}

		// Token: 0x06009449 RID: 37961 RVA: 0x002AAF28 File Offset: 0x002A9128
		protected void OnReturnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnClick_hotfix != null)
			{
				this.m_OnReturnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_task.m_heroArchiveUIController.gameObject.SetActive(false);
				this.m_task.m_equipmentArchiveUIController.gameObject.SetActive(false);
				this.m_task.m_manualUIController.gameObject.SetActive(true);
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600944A RID: 37962 RVA: 0x002AAFAC File Offset: 0x002A91AC
		private void OnItemClick(ArchiveItemUIController archiveItemUIController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemClickArchiveItemUIController_hotfix != null)
			{
				this.m_OnItemClickArchiveItemUIController_hotfix.call(new object[]
				{
					this,
					archiveItemUIController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RefreshItem(archiveItemUIController);
		}

		// Token: 0x0600944B RID: 37963 RVA: 0x002AB024 File Offset: 0x002A9224
		private void OnEquipmentFilterSwitchClick(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentFilterSwitchClickGameObject_hotfix != null)
			{
				this.m_OnEquipmentFilterSwitchClickGameObject_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (obj == this.m_aLLItemToggle.gameObject)
			{
				this.CreateItemList(this.m_allBagItemList);
				this.RefreshItemCount(this.m_allOwnItemCount, this.m_allBagItemList.Count);
				this.m_filterText.text = "全部";
			}
			else if (obj == this.m_weaponItemToggle.gameObject)
			{
				this.CreateItemList(this.m_weaponBagItemList);
				this.RefreshItemCount(this.m_weaponOwnItemCount, this.m_weaponBagItemList.Count);
				this.m_filterText.text = "武器";
			}
			else if (obj == this.m_armorItemToggle.gameObject)
			{
				this.CreateItemList(this.m_armorBagItemList);
				this.RefreshItemCount(this.m_armorOwnItemCount, this.m_armorBagItemList.Count);
				this.m_filterText.text = "护甲";
			}
			else if (obj == this.m_helmetItemToggle.gameObject)
			{
				this.CreateItemList(this.m_helmetBagItemList);
				this.RefreshItemCount(this.m_helmetOwnItemCount, this.m_helmetBagItemList.Count);
				this.m_filterText.text = "头盔";
			}
			else if (obj == this.m_ornamentItemToggle.gameObject)
			{
				this.CreateItemList(this.m_ornamentBagItemList);
				this.RefreshItemCount(this.m_ornamentOwnItemCount, this.m_ornamentBagItemList.Count);
				this.m_filterText.text = "饰品";
			}
			else if (obj == this.m_otherItemToggle.gameObject)
			{
				this.CreateItemList(this.m_otherBagItemList);
				this.RefreshItemCount(this.m_otherOwnItemCount, this.m_otherBagItemList.Count);
				this.m_filterText.text = "其他";
			}
			this.m_filterPanel.SetActive(false);
		}

		// Token: 0x0600944C RID: 37964 RVA: 0x002AB270 File Offset: 0x002A9470
		private void OnEquipmentFilterClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentFilterClick_hotfix != null)
			{
				this.m_OnEquipmentFilterClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_filterPanel.SetActive(true);
		}

		// Token: 0x0600944D RID: 37965 RVA: 0x002AB2DC File Offset: 0x002A94DC
		private void OnFilterBGClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFilterBGClick_hotfix != null)
			{
				this.m_OnFilterBGClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_filterPanel.SetActive(false);
		}

		// Token: 0x0600944E RID: 37966 RVA: 0x002AB348 File Offset: 0x002A9548
		private void OnGetItemPathClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetItemPathClick_hotfix != null)
			{
				this.m_OnGetItemPathClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentInfo equipmentInfo = this.m_selectEquipmentInfoWrap.equipmentInfo;
			GetPathUITask.StartUITask(GoodsType.GoodsType_Equipment, equipmentInfo.ID, delegate(GetPathData getPath, NeedGoods needGoods)
			{
				this.m_task.Pause();
				WorldUITask.StartGetPathTargetUITask(getPath, this.m_task.CurrentIntent, null);
			}, 0);
		}

		// Token: 0x0600944F RID: 37967 RVA: 0x002AB3D0 File Offset: 0x002A95D0
		private void UpdateChildrenCallbackDelegate(int index, Transform trans)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateChildrenCallbackDelegateInt32Transform_hotfix != null)
			{
				this.m_UpdateChildrenCallbackDelegateInt32Transform_hotfix.call(new object[]
				{
					this,
					index,
					trans
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfo = this.m_selectBagItemList[index];
			ArchiveItemUIController component = trans.GetComponent<ArchiveItemUIController>();
			component.SetEquipmentInfo(equipmentInfo);
			component.Refresh();
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x06009450 RID: 37968 RVA: 0x002AB474 File Offset: 0x002A9674
		// (set) Token: 0x06009451 RID: 37969 RVA: 0x002AB494 File Offset: 0x002A9694
		[DoNotToLua]
		public new EquipmentArchiveUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EquipmentArchiveUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009452 RID: 37970 RVA: 0x002AB4A0 File Offset: 0x002A96A0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009453 RID: 37971 RVA: 0x002AB4AC File Offset: 0x002A96AC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009454 RID: 37972 RVA: 0x002AB4B4 File Offset: 0x002A96B4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009455 RID: 37973 RVA: 0x002AB4BC File Offset: 0x002A96BC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x002AB4D0 File Offset: 0x002A96D0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009457 RID: 37975 RVA: 0x002AB4D8 File Offset: 0x002A96D8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009458 RID: 37976 RVA: 0x002AB4E4 File Offset: 0x002A96E4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009459 RID: 37977 RVA: 0x002AB4F0 File Offset: 0x002A96F0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600945A RID: 37978 RVA: 0x002AB4FC File Offset: 0x002A96FC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600945B RID: 37979 RVA: 0x002AB508 File Offset: 0x002A9708
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600945C RID: 37980 RVA: 0x002AB514 File Offset: 0x002A9714
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600945D RID: 37981 RVA: 0x002AB520 File Offset: 0x002A9720
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600945E RID: 37982 RVA: 0x002AB52C File Offset: 0x002A972C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600945F RID: 37983 RVA: 0x002AB538 File Offset: 0x002A9738
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009460 RID: 37984 RVA: 0x002AB544 File Offset: 0x002A9744
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x002AB79C File Offset: 0x002A999C
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
					this.m_SetTaskArchiveUITask_hotfix = (luaObj.RawGet("SetTask") as LuaFunction);
					this.m_EnterController_hotfix = (luaObj.RawGet("EnterController") as LuaFunction);
					this.m_ItemListCompareEquipmentInfoWrapEquipmentInfoWrap_hotfix = (luaObj.RawGet("ItemListCompare") as LuaFunction);
					this.m_RefreshItemArchiveItemUIController_hotfix = (luaObj.RawGet("RefreshItem") as LuaFunction);
					this.m_RefreshItemCountInt32Int32_hotfix = (luaObj.RawGet("RefreshItemCount") as LuaFunction);
					this.m_CreateItemListList`1_hotfix = (luaObj.RawGet("CreateItemList") as LuaFunction);
					this.m_DestroyItemBagList_hotfix = (luaObj.RawGet("DestroyItemBagList") as LuaFunction);
					this.m_RefreshItemBagWithHeroDataEquipmentInfoWrap_hotfix = (luaObj.RawGet("RefreshItemBagWithHeroData") as LuaFunction);
					this.m_OnReturnClick_hotfix = (luaObj.RawGet("OnReturnClick") as LuaFunction);
					this.m_OnItemClickArchiveItemUIController_hotfix = (luaObj.RawGet("OnItemClick") as LuaFunction);
					this.m_OnEquipmentFilterSwitchClickGameObject_hotfix = (luaObj.RawGet("OnEquipmentFilterSwitchClick") as LuaFunction);
					this.m_OnEquipmentFilterClick_hotfix = (luaObj.RawGet("OnEquipmentFilterClick") as LuaFunction);
					this.m_OnFilterBGClick_hotfix = (luaObj.RawGet("OnFilterBGClick") as LuaFunction);
					this.m_OnGetItemPathClick_hotfix = (luaObj.RawGet("OnGetItemPathClick") as LuaFunction);
					this.m_UpdateChildrenCallbackDelegateInt32Transform_hotfix = (luaObj.RawGet("UpdateChildrenCallbackDelegate") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x002AB9E0 File Offset: 0x002A9BE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentArchiveUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040066D9 RID: 26329
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_prefabAnimation;

		// Token: 0x040066DA RID: 26330
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x040066DB RID: 26331
		[AutoBind("./EquipmentInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentInfoPanel;

		// Token: 0x040066DC RID: 26332
		[AutoBind("./EquipmentInfoPanel/GetButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_getButton;

		// Token: 0x040066DD RID: 26333
		[AutoBind("./EquipmentList/EquipmentFilter/SortTypes/GridLayout/All", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_aLLItemToggle;

		// Token: 0x040066DE RID: 26334
		[AutoBind("./EquipmentList/EquipmentFilter/SortTypes/GridLayout/Weapon", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_weaponItemToggle;

		// Token: 0x040066DF RID: 26335
		[AutoBind("./EquipmentList/EquipmentFilter/SortTypes/GridLayout/Armour", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_armorItemToggle;

		// Token: 0x040066E0 RID: 26336
		[AutoBind("./EquipmentList/EquipmentFilter/SortTypes/GridLayout/Helmet", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_helmetItemToggle;

		// Token: 0x040066E1 RID: 26337
		[AutoBind("./EquipmentList/EquipmentFilter/SortTypes/GridLayout/Ornament", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_ornamentItemToggle;

		// Token: 0x040066E2 RID: 26338
		[AutoBind("./EquipmentList/EquipmentFilter/SortTypes/GridLayout/Other", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_otherItemToggle;

		// Token: 0x040066E3 RID: 26339
		[AutoBind("./EquipmentList/EquipmentFilter/SortButton/SortTypeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_filterText;

		// Token: 0x040066E4 RID: 26340
		[AutoBind("./EquipmentList/EquipmentFilter/SortButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_equipmentFilterButton;

		// Token: 0x040066E5 RID: 26341
		[AutoBind("./EquipmentList/EquipmentFilter/SortTypes", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_filterPanel;

		// Token: 0x040066E6 RID: 26342
		[AutoBind("./EquipmentList/EquipmentFilter/SortTypes/BGImages/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_filterBGButton;

		// Token: 0x040066E7 RID: 26343
		[AutoBind("./EquipmentList/ListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private InfinityGridLayoutGroup m_itemContentInfinityGrid;

		// Token: 0x040066E8 RID: 26344
		[AutoBind("./EquipmentList/ListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemContent;

		// Token: 0x040066E9 RID: 26345
		[AutoBind("./Prefab/ItemPrefab", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemPrefab;

		// Token: 0x040066EA RID: 26346
		[AutoBind("./CountLimit/CountGroup/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_currentItemCountText;

		// Token: 0x040066EB RID: 26347
		[AutoBind("./CountLimit/CountGroup/MaxText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_maxItemCountText;

		// Token: 0x040066EC RID: 26348
		private List<EquipmentArchiveUIController.EquipmentInfoWrap> m_selectBagItemList;

		// Token: 0x040066ED RID: 26349
		private List<EquipmentArchiveUIController.EquipmentInfoWrap> m_allBagItemList = new List<EquipmentArchiveUIController.EquipmentInfoWrap>();

		// Token: 0x040066EE RID: 26350
		private List<EquipmentArchiveUIController.EquipmentInfoWrap> m_armorBagItemList = new List<EquipmentArchiveUIController.EquipmentInfoWrap>();

		// Token: 0x040066EF RID: 26351
		private List<EquipmentArchiveUIController.EquipmentInfoWrap> m_helmetBagItemList = new List<EquipmentArchiveUIController.EquipmentInfoWrap>();

		// Token: 0x040066F0 RID: 26352
		private List<EquipmentArchiveUIController.EquipmentInfoWrap> m_ornamentBagItemList = new List<EquipmentArchiveUIController.EquipmentInfoWrap>();

		// Token: 0x040066F1 RID: 26353
		private List<EquipmentArchiveUIController.EquipmentInfoWrap> m_weaponBagItemList = new List<EquipmentArchiveUIController.EquipmentInfoWrap>();

		// Token: 0x040066F2 RID: 26354
		private List<EquipmentArchiveUIController.EquipmentInfoWrap> m_otherBagItemList = new List<EquipmentArchiveUIController.EquipmentInfoWrap>();

		// Token: 0x040066F3 RID: 26355
		private ArchiveUITask m_task;

		// Token: 0x040066F4 RID: 26356
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040066F5 RID: 26357
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040066F6 RID: 26358
		private List<ArchiveItemUIController> m_itemUIControllerList = new List<ArchiveItemUIController>();

		// Token: 0x040066F7 RID: 26359
		private EquipmentArchiveUIController.EquipmentInfoWrap m_selectEquipmentInfoWrap;

		// Token: 0x040066F8 RID: 26360
		private ArchiveItemDetailInfoController m_itemDetailInfoController;

		// Token: 0x040066F9 RID: 26361
		private int m_allOwnItemCount;

		// Token: 0x040066FA RID: 26362
		private int m_armorOwnItemCount;

		// Token: 0x040066FB RID: 26363
		private int m_helmetOwnItemCount;

		// Token: 0x040066FC RID: 26364
		private int m_ornamentOwnItemCount;

		// Token: 0x040066FD RID: 26365
		private int m_weaponOwnItemCount;

		// Token: 0x040066FE RID: 26366
		private int m_otherOwnItemCount;

		// Token: 0x040066FF RID: 26367
		[DoNotToLua]
		private EquipmentArchiveUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006700 RID: 26368
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006701 RID: 26369
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006702 RID: 26370
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006703 RID: 26371
		private LuaFunction m_SetTaskArchiveUITask_hotfix;

		// Token: 0x04006704 RID: 26372
		private LuaFunction m_EnterController_hotfix;

		// Token: 0x04006705 RID: 26373
		private LuaFunction m_ItemListCompareEquipmentInfoWrapEquipmentInfoWrap_hotfix;

		// Token: 0x04006706 RID: 26374
		private LuaFunction m_RefreshItemArchiveItemUIController_hotfix;

		// Token: 0x04006707 RID: 26375
		private LuaFunction m_RefreshItemCountInt32Int32_hotfix;

		// Token: 0x04006708 RID: 26376
		private LuaFunction m_CreateItemListList;

		// Token: 0x04006709 RID: 26377
		private LuaFunction m_DestroyItemBagList_hotfix;

		// Token: 0x0400670A RID: 26378
		private LuaFunction m_RefreshItemBagWithHeroDataEquipmentInfoWrap_hotfix;

		// Token: 0x0400670B RID: 26379
		private LuaFunction m_OnReturnClick_hotfix;

		// Token: 0x0400670C RID: 26380
		private LuaFunction m_OnItemClickArchiveItemUIController_hotfix;

		// Token: 0x0400670D RID: 26381
		private LuaFunction m_OnEquipmentFilterSwitchClickGameObject_hotfix;

		// Token: 0x0400670E RID: 26382
		private LuaFunction m_OnEquipmentFilterClick_hotfix;

		// Token: 0x0400670F RID: 26383
		private LuaFunction m_OnFilterBGClick_hotfix;

		// Token: 0x04006710 RID: 26384
		private LuaFunction m_OnGetItemPathClick_hotfix;

		// Token: 0x04006711 RID: 26385
		private LuaFunction m_UpdateChildrenCallbackDelegateInt32Transform_hotfix;

		// Token: 0x020009D9 RID: 2521
		[HotFix]
		public class EquipmentInfoWrap
		{
			// Token: 0x04006712 RID: 26386
			public ConfigDataEquipmentInfo equipmentInfo;

			// Token: 0x04006713 RID: 26387
			public bool isUnlocked;

			// Token: 0x04006714 RID: 26388
			public bool isSelect;
		}

		// Token: 0x020009DA RID: 2522
		public new class LuaExportHelper
		{
			// Token: 0x0600946F RID: 37999 RVA: 0x002ABA50 File Offset: 0x002A9C50
			public LuaExportHelper(EquipmentArchiveUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009470 RID: 38000 RVA: 0x002ABA60 File Offset: 0x002A9C60
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009471 RID: 38001 RVA: 0x002ABA70 File Offset: 0x002A9C70
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009472 RID: 38002 RVA: 0x002ABA80 File Offset: 0x002A9C80
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009473 RID: 38003 RVA: 0x002ABA90 File Offset: 0x002A9C90
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009474 RID: 38004 RVA: 0x002ABAA8 File Offset: 0x002A9CA8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009475 RID: 38005 RVA: 0x002ABAB8 File Offset: 0x002A9CB8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009476 RID: 38006 RVA: 0x002ABAC8 File Offset: 0x002A9CC8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009477 RID: 38007 RVA: 0x002ABAD8 File Offset: 0x002A9CD8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009478 RID: 38008 RVA: 0x002ABAE8 File Offset: 0x002A9CE8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009479 RID: 38009 RVA: 0x002ABAF8 File Offset: 0x002A9CF8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600947A RID: 38010 RVA: 0x002ABB08 File Offset: 0x002A9D08
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600947B RID: 38011 RVA: 0x002ABB18 File Offset: 0x002A9D18
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600947C RID: 38012 RVA: 0x002ABB28 File Offset: 0x002A9D28
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600947D RID: 38013 RVA: 0x002ABB38 File Offset: 0x002A9D38
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600947E RID: 38014 RVA: 0x002ABB48 File Offset: 0x002A9D48
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17001E85 RID: 7813
			// (get) Token: 0x0600947F RID: 38015 RVA: 0x002ABB58 File Offset: 0x002A9D58
			// (set) Token: 0x06009480 RID: 38016 RVA: 0x002ABB68 File Offset: 0x002A9D68
			public CommonUIStateController m_prefabAnimation
			{
				get
				{
					return this.m_owner.m_prefabAnimation;
				}
				set
				{
					this.m_owner.m_prefabAnimation = value;
				}
			}

			// Token: 0x17001E86 RID: 7814
			// (get) Token: 0x06009481 RID: 38017 RVA: 0x002ABB78 File Offset: 0x002A9D78
			// (set) Token: 0x06009482 RID: 38018 RVA: 0x002ABB88 File Offset: 0x002A9D88
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

			// Token: 0x17001E87 RID: 7815
			// (get) Token: 0x06009483 RID: 38019 RVA: 0x002ABB98 File Offset: 0x002A9D98
			// (set) Token: 0x06009484 RID: 38020 RVA: 0x002ABBA8 File Offset: 0x002A9DA8
			public GameObject m_equipmentInfoPanel
			{
				get
				{
					return this.m_owner.m_equipmentInfoPanel;
				}
				set
				{
					this.m_owner.m_equipmentInfoPanel = value;
				}
			}

			// Token: 0x17001E88 RID: 7816
			// (get) Token: 0x06009485 RID: 38021 RVA: 0x002ABBB8 File Offset: 0x002A9DB8
			// (set) Token: 0x06009486 RID: 38022 RVA: 0x002ABBC8 File Offset: 0x002A9DC8
			public Button m_getButton
			{
				get
				{
					return this.m_owner.m_getButton;
				}
				set
				{
					this.m_owner.m_getButton = value;
				}
			}

			// Token: 0x17001E89 RID: 7817
			// (get) Token: 0x06009487 RID: 38023 RVA: 0x002ABBD8 File Offset: 0x002A9DD8
			// (set) Token: 0x06009488 RID: 38024 RVA: 0x002ABBE8 File Offset: 0x002A9DE8
			public Toggle m_aLLItemToggle
			{
				get
				{
					return this.m_owner.m_aLLItemToggle;
				}
				set
				{
					this.m_owner.m_aLLItemToggle = value;
				}
			}

			// Token: 0x17001E8A RID: 7818
			// (get) Token: 0x06009489 RID: 38025 RVA: 0x002ABBF8 File Offset: 0x002A9DF8
			// (set) Token: 0x0600948A RID: 38026 RVA: 0x002ABC08 File Offset: 0x002A9E08
			public Toggle m_weaponItemToggle
			{
				get
				{
					return this.m_owner.m_weaponItemToggle;
				}
				set
				{
					this.m_owner.m_weaponItemToggle = value;
				}
			}

			// Token: 0x17001E8B RID: 7819
			// (get) Token: 0x0600948B RID: 38027 RVA: 0x002ABC18 File Offset: 0x002A9E18
			// (set) Token: 0x0600948C RID: 38028 RVA: 0x002ABC28 File Offset: 0x002A9E28
			public Toggle m_armorItemToggle
			{
				get
				{
					return this.m_owner.m_armorItemToggle;
				}
				set
				{
					this.m_owner.m_armorItemToggle = value;
				}
			}

			// Token: 0x17001E8C RID: 7820
			// (get) Token: 0x0600948D RID: 38029 RVA: 0x002ABC38 File Offset: 0x002A9E38
			// (set) Token: 0x0600948E RID: 38030 RVA: 0x002ABC48 File Offset: 0x002A9E48
			public Toggle m_helmetItemToggle
			{
				get
				{
					return this.m_owner.m_helmetItemToggle;
				}
				set
				{
					this.m_owner.m_helmetItemToggle = value;
				}
			}

			// Token: 0x17001E8D RID: 7821
			// (get) Token: 0x0600948F RID: 38031 RVA: 0x002ABC58 File Offset: 0x002A9E58
			// (set) Token: 0x06009490 RID: 38032 RVA: 0x002ABC68 File Offset: 0x002A9E68
			public Toggle m_ornamentItemToggle
			{
				get
				{
					return this.m_owner.m_ornamentItemToggle;
				}
				set
				{
					this.m_owner.m_ornamentItemToggle = value;
				}
			}

			// Token: 0x17001E8E RID: 7822
			// (get) Token: 0x06009491 RID: 38033 RVA: 0x002ABC78 File Offset: 0x002A9E78
			// (set) Token: 0x06009492 RID: 38034 RVA: 0x002ABC88 File Offset: 0x002A9E88
			public Toggle m_otherItemToggle
			{
				get
				{
					return this.m_owner.m_otherItemToggle;
				}
				set
				{
					this.m_owner.m_otherItemToggle = value;
				}
			}

			// Token: 0x17001E8F RID: 7823
			// (get) Token: 0x06009493 RID: 38035 RVA: 0x002ABC98 File Offset: 0x002A9E98
			// (set) Token: 0x06009494 RID: 38036 RVA: 0x002ABCA8 File Offset: 0x002A9EA8
			public Text m_filterText
			{
				get
				{
					return this.m_owner.m_filterText;
				}
				set
				{
					this.m_owner.m_filterText = value;
				}
			}

			// Token: 0x17001E90 RID: 7824
			// (get) Token: 0x06009495 RID: 38037 RVA: 0x002ABCB8 File Offset: 0x002A9EB8
			// (set) Token: 0x06009496 RID: 38038 RVA: 0x002ABCC8 File Offset: 0x002A9EC8
			public Button m_equipmentFilterButton
			{
				get
				{
					return this.m_owner.m_equipmentFilterButton;
				}
				set
				{
					this.m_owner.m_equipmentFilterButton = value;
				}
			}

			// Token: 0x17001E91 RID: 7825
			// (get) Token: 0x06009497 RID: 38039 RVA: 0x002ABCD8 File Offset: 0x002A9ED8
			// (set) Token: 0x06009498 RID: 38040 RVA: 0x002ABCE8 File Offset: 0x002A9EE8
			public GameObject m_filterPanel
			{
				get
				{
					return this.m_owner.m_filterPanel;
				}
				set
				{
					this.m_owner.m_filterPanel = value;
				}
			}

			// Token: 0x17001E92 RID: 7826
			// (get) Token: 0x06009499 RID: 38041 RVA: 0x002ABCF8 File Offset: 0x002A9EF8
			// (set) Token: 0x0600949A RID: 38042 RVA: 0x002ABD08 File Offset: 0x002A9F08
			public Button m_filterBGButton
			{
				get
				{
					return this.m_owner.m_filterBGButton;
				}
				set
				{
					this.m_owner.m_filterBGButton = value;
				}
			}

			// Token: 0x17001E93 RID: 7827
			// (get) Token: 0x0600949B RID: 38043 RVA: 0x002ABD18 File Offset: 0x002A9F18
			// (set) Token: 0x0600949C RID: 38044 RVA: 0x002ABD28 File Offset: 0x002A9F28
			public InfinityGridLayoutGroup m_itemContentInfinityGrid
			{
				get
				{
					return this.m_owner.m_itemContentInfinityGrid;
				}
				set
				{
					this.m_owner.m_itemContentInfinityGrid = value;
				}
			}

			// Token: 0x17001E94 RID: 7828
			// (get) Token: 0x0600949D RID: 38045 RVA: 0x002ABD38 File Offset: 0x002A9F38
			// (set) Token: 0x0600949E RID: 38046 RVA: 0x002ABD48 File Offset: 0x002A9F48
			public GameObject m_itemContent
			{
				get
				{
					return this.m_owner.m_itemContent;
				}
				set
				{
					this.m_owner.m_itemContent = value;
				}
			}

			// Token: 0x17001E95 RID: 7829
			// (get) Token: 0x0600949F RID: 38047 RVA: 0x002ABD58 File Offset: 0x002A9F58
			// (set) Token: 0x060094A0 RID: 38048 RVA: 0x002ABD68 File Offset: 0x002A9F68
			public GameObject m_itemPrefab
			{
				get
				{
					return this.m_owner.m_itemPrefab;
				}
				set
				{
					this.m_owner.m_itemPrefab = value;
				}
			}

			// Token: 0x17001E96 RID: 7830
			// (get) Token: 0x060094A1 RID: 38049 RVA: 0x002ABD78 File Offset: 0x002A9F78
			// (set) Token: 0x060094A2 RID: 38050 RVA: 0x002ABD88 File Offset: 0x002A9F88
			public Text m_currentItemCountText
			{
				get
				{
					return this.m_owner.m_currentItemCountText;
				}
				set
				{
					this.m_owner.m_currentItemCountText = value;
				}
			}

			// Token: 0x17001E97 RID: 7831
			// (get) Token: 0x060094A3 RID: 38051 RVA: 0x002ABD98 File Offset: 0x002A9F98
			// (set) Token: 0x060094A4 RID: 38052 RVA: 0x002ABDA8 File Offset: 0x002A9FA8
			public Text m_maxItemCountText
			{
				get
				{
					return this.m_owner.m_maxItemCountText;
				}
				set
				{
					this.m_owner.m_maxItemCountText = value;
				}
			}

			// Token: 0x17001E98 RID: 7832
			// (get) Token: 0x060094A5 RID: 38053 RVA: 0x002ABDB8 File Offset: 0x002A9FB8
			// (set) Token: 0x060094A6 RID: 38054 RVA: 0x002ABDC8 File Offset: 0x002A9FC8
			public List<EquipmentArchiveUIController.EquipmentInfoWrap> m_selectBagItemList
			{
				get
				{
					return this.m_owner.m_selectBagItemList;
				}
				set
				{
					this.m_owner.m_selectBagItemList = value;
				}
			}

			// Token: 0x17001E99 RID: 7833
			// (get) Token: 0x060094A7 RID: 38055 RVA: 0x002ABDD8 File Offset: 0x002A9FD8
			// (set) Token: 0x060094A8 RID: 38056 RVA: 0x002ABDE8 File Offset: 0x002A9FE8
			public List<EquipmentArchiveUIController.EquipmentInfoWrap> m_allBagItemList
			{
				get
				{
					return this.m_owner.m_allBagItemList;
				}
				set
				{
					this.m_owner.m_allBagItemList = value;
				}
			}

			// Token: 0x17001E9A RID: 7834
			// (get) Token: 0x060094A9 RID: 38057 RVA: 0x002ABDF8 File Offset: 0x002A9FF8
			// (set) Token: 0x060094AA RID: 38058 RVA: 0x002ABE08 File Offset: 0x002AA008
			public List<EquipmentArchiveUIController.EquipmentInfoWrap> m_armorBagItemList
			{
				get
				{
					return this.m_owner.m_armorBagItemList;
				}
				set
				{
					this.m_owner.m_armorBagItemList = value;
				}
			}

			// Token: 0x17001E9B RID: 7835
			// (get) Token: 0x060094AB RID: 38059 RVA: 0x002ABE18 File Offset: 0x002AA018
			// (set) Token: 0x060094AC RID: 38060 RVA: 0x002ABE28 File Offset: 0x002AA028
			public List<EquipmentArchiveUIController.EquipmentInfoWrap> m_helmetBagItemList
			{
				get
				{
					return this.m_owner.m_helmetBagItemList;
				}
				set
				{
					this.m_owner.m_helmetBagItemList = value;
				}
			}

			// Token: 0x17001E9C RID: 7836
			// (get) Token: 0x060094AD RID: 38061 RVA: 0x002ABE38 File Offset: 0x002AA038
			// (set) Token: 0x060094AE RID: 38062 RVA: 0x002ABE48 File Offset: 0x002AA048
			public List<EquipmentArchiveUIController.EquipmentInfoWrap> m_ornamentBagItemList
			{
				get
				{
					return this.m_owner.m_ornamentBagItemList;
				}
				set
				{
					this.m_owner.m_ornamentBagItemList = value;
				}
			}

			// Token: 0x17001E9D RID: 7837
			// (get) Token: 0x060094AF RID: 38063 RVA: 0x002ABE58 File Offset: 0x002AA058
			// (set) Token: 0x060094B0 RID: 38064 RVA: 0x002ABE68 File Offset: 0x002AA068
			public List<EquipmentArchiveUIController.EquipmentInfoWrap> m_weaponBagItemList
			{
				get
				{
					return this.m_owner.m_weaponBagItemList;
				}
				set
				{
					this.m_owner.m_weaponBagItemList = value;
				}
			}

			// Token: 0x17001E9E RID: 7838
			// (get) Token: 0x060094B1 RID: 38065 RVA: 0x002ABE78 File Offset: 0x002AA078
			// (set) Token: 0x060094B2 RID: 38066 RVA: 0x002ABE88 File Offset: 0x002AA088
			public List<EquipmentArchiveUIController.EquipmentInfoWrap> m_otherBagItemList
			{
				get
				{
					return this.m_owner.m_otherBagItemList;
				}
				set
				{
					this.m_owner.m_otherBagItemList = value;
				}
			}

			// Token: 0x17001E9F RID: 7839
			// (get) Token: 0x060094B3 RID: 38067 RVA: 0x002ABE98 File Offset: 0x002AA098
			// (set) Token: 0x060094B4 RID: 38068 RVA: 0x002ABEA8 File Offset: 0x002AA0A8
			public ArchiveUITask m_task
			{
				get
				{
					return this.m_owner.m_task;
				}
				set
				{
					this.m_owner.m_task = value;
				}
			}

			// Token: 0x17001EA0 RID: 7840
			// (get) Token: 0x060094B5 RID: 38069 RVA: 0x002ABEB8 File Offset: 0x002AA0B8
			// (set) Token: 0x060094B6 RID: 38070 RVA: 0x002ABEC8 File Offset: 0x002AA0C8
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

			// Token: 0x17001EA1 RID: 7841
			// (get) Token: 0x060094B7 RID: 38071 RVA: 0x002ABED8 File Offset: 0x002AA0D8
			// (set) Token: 0x060094B8 RID: 38072 RVA: 0x002ABEE8 File Offset: 0x002AA0E8
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

			// Token: 0x17001EA2 RID: 7842
			// (get) Token: 0x060094B9 RID: 38073 RVA: 0x002ABEF8 File Offset: 0x002AA0F8
			// (set) Token: 0x060094BA RID: 38074 RVA: 0x002ABF08 File Offset: 0x002AA108
			public List<ArchiveItemUIController> m_itemUIControllerList
			{
				get
				{
					return this.m_owner.m_itemUIControllerList;
				}
				set
				{
					this.m_owner.m_itemUIControllerList = value;
				}
			}

			// Token: 0x17001EA3 RID: 7843
			// (get) Token: 0x060094BB RID: 38075 RVA: 0x002ABF18 File Offset: 0x002AA118
			// (set) Token: 0x060094BC RID: 38076 RVA: 0x002ABF28 File Offset: 0x002AA128
			public EquipmentArchiveUIController.EquipmentInfoWrap m_selectEquipmentInfoWrap
			{
				get
				{
					return this.m_owner.m_selectEquipmentInfoWrap;
				}
				set
				{
					this.m_owner.m_selectEquipmentInfoWrap = value;
				}
			}

			// Token: 0x17001EA4 RID: 7844
			// (get) Token: 0x060094BD RID: 38077 RVA: 0x002ABF38 File Offset: 0x002AA138
			// (set) Token: 0x060094BE RID: 38078 RVA: 0x002ABF48 File Offset: 0x002AA148
			public ArchiveItemDetailInfoController m_itemDetailInfoController
			{
				get
				{
					return this.m_owner.m_itemDetailInfoController;
				}
				set
				{
					this.m_owner.m_itemDetailInfoController = value;
				}
			}

			// Token: 0x17001EA5 RID: 7845
			// (get) Token: 0x060094BF RID: 38079 RVA: 0x002ABF58 File Offset: 0x002AA158
			// (set) Token: 0x060094C0 RID: 38080 RVA: 0x002ABF68 File Offset: 0x002AA168
			public int m_allOwnItemCount
			{
				get
				{
					return this.m_owner.m_allOwnItemCount;
				}
				set
				{
					this.m_owner.m_allOwnItemCount = value;
				}
			}

			// Token: 0x17001EA6 RID: 7846
			// (get) Token: 0x060094C1 RID: 38081 RVA: 0x002ABF78 File Offset: 0x002AA178
			// (set) Token: 0x060094C2 RID: 38082 RVA: 0x002ABF88 File Offset: 0x002AA188
			public int m_armorOwnItemCount
			{
				get
				{
					return this.m_owner.m_armorOwnItemCount;
				}
				set
				{
					this.m_owner.m_armorOwnItemCount = value;
				}
			}

			// Token: 0x17001EA7 RID: 7847
			// (get) Token: 0x060094C3 RID: 38083 RVA: 0x002ABF98 File Offset: 0x002AA198
			// (set) Token: 0x060094C4 RID: 38084 RVA: 0x002ABFA8 File Offset: 0x002AA1A8
			public int m_helmetOwnItemCount
			{
				get
				{
					return this.m_owner.m_helmetOwnItemCount;
				}
				set
				{
					this.m_owner.m_helmetOwnItemCount = value;
				}
			}

			// Token: 0x17001EA8 RID: 7848
			// (get) Token: 0x060094C5 RID: 38085 RVA: 0x002ABFB8 File Offset: 0x002AA1B8
			// (set) Token: 0x060094C6 RID: 38086 RVA: 0x002ABFC8 File Offset: 0x002AA1C8
			public int m_ornamentOwnItemCount
			{
				get
				{
					return this.m_owner.m_ornamentOwnItemCount;
				}
				set
				{
					this.m_owner.m_ornamentOwnItemCount = value;
				}
			}

			// Token: 0x17001EA9 RID: 7849
			// (get) Token: 0x060094C7 RID: 38087 RVA: 0x002ABFD8 File Offset: 0x002AA1D8
			// (set) Token: 0x060094C8 RID: 38088 RVA: 0x002ABFE8 File Offset: 0x002AA1E8
			public int m_weaponOwnItemCount
			{
				get
				{
					return this.m_owner.m_weaponOwnItemCount;
				}
				set
				{
					this.m_owner.m_weaponOwnItemCount = value;
				}
			}

			// Token: 0x17001EAA RID: 7850
			// (get) Token: 0x060094C9 RID: 38089 RVA: 0x002ABFF8 File Offset: 0x002AA1F8
			// (set) Token: 0x060094CA RID: 38090 RVA: 0x002AC008 File Offset: 0x002AA208
			public int m_otherOwnItemCount
			{
				get
				{
					return this.m_owner.m_otherOwnItemCount;
				}
				set
				{
					this.m_owner.m_otherOwnItemCount = value;
				}
			}

			// Token: 0x060094CB RID: 38091 RVA: 0x002AC018 File Offset: 0x002AA218
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060094CC RID: 38092 RVA: 0x002AC028 File Offset: 0x002AA228
			public int ItemListCompare(EquipmentArchiveUIController.EquipmentInfoWrap equipmentWrap1, EquipmentArchiveUIController.EquipmentInfoWrap equipmentWrap2)
			{
				return this.m_owner.ItemListCompare(equipmentWrap1, equipmentWrap2);
			}

			// Token: 0x060094CD RID: 38093 RVA: 0x002AC038 File Offset: 0x002AA238
			public void RefreshItem(ArchiveItemUIController archiveItemUIController)
			{
				this.m_owner.RefreshItem(archiveItemUIController);
			}

			// Token: 0x060094CE RID: 38094 RVA: 0x002AC048 File Offset: 0x002AA248
			public void RefreshItemCount(int currentCount, int maxCount)
			{
				this.m_owner.RefreshItemCount(currentCount, maxCount);
			}

			// Token: 0x060094CF RID: 38095 RVA: 0x002AC058 File Offset: 0x002AA258
			public void CreateItemList(List<EquipmentArchiveUIController.EquipmentInfoWrap> equipmentInfoWrapList)
			{
				this.m_owner.CreateItemList(equipmentInfoWrapList);
			}

			// Token: 0x060094D0 RID: 38096 RVA: 0x002AC068 File Offset: 0x002AA268
			public void DestroyItemBagList()
			{
				this.m_owner.DestroyItemBagList();
			}

			// Token: 0x060094D1 RID: 38097 RVA: 0x002AC078 File Offset: 0x002AA278
			public void RefreshItemBagWithHeroData(EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap)
			{
				this.m_owner.RefreshItemBagWithHeroData(equipmentInfoWrap);
			}

			// Token: 0x060094D2 RID: 38098 RVA: 0x002AC088 File Offset: 0x002AA288
			public void OnReturnClick()
			{
				this.m_owner.OnReturnClick();
			}

			// Token: 0x060094D3 RID: 38099 RVA: 0x002AC098 File Offset: 0x002AA298
			public void OnItemClick(ArchiveItemUIController archiveItemUIController)
			{
				this.m_owner.OnItemClick(archiveItemUIController);
			}

			// Token: 0x060094D4 RID: 38100 RVA: 0x002AC0A8 File Offset: 0x002AA2A8
			public void OnEquipmentFilterSwitchClick(GameObject obj)
			{
				this.m_owner.OnEquipmentFilterSwitchClick(obj);
			}

			// Token: 0x060094D5 RID: 38101 RVA: 0x002AC0B8 File Offset: 0x002AA2B8
			public void OnEquipmentFilterClick()
			{
				this.m_owner.OnEquipmentFilterClick();
			}

			// Token: 0x060094D6 RID: 38102 RVA: 0x002AC0C8 File Offset: 0x002AA2C8
			public void OnFilterBGClick()
			{
				this.m_owner.OnFilterBGClick();
			}

			// Token: 0x060094D7 RID: 38103 RVA: 0x002AC0D8 File Offset: 0x002AA2D8
			public void OnGetItemPathClick()
			{
				this.m_owner.OnGetItemPathClick();
			}

			// Token: 0x060094D8 RID: 38104 RVA: 0x002AC0E8 File Offset: 0x002AA2E8
			public void UpdateChildrenCallbackDelegate(int index, Transform trans)
			{
				this.m_owner.UpdateChildrenCallbackDelegate(index, trans);
			}

			// Token: 0x04006715 RID: 26389
			private EquipmentArchiveUIController m_owner;
		}
	}
}
