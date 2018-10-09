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
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D97 RID: 3479
	[HotFix]
	public class HeroDetailEquipmentUIController : UIControllerBase
	{
		// Token: 0x060104B8 RID: 66744 RVA: 0x004416C4 File Offset: 0x0043F8C4
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
			this.m_equipItemDescForgeButton.onClick.AddListener(new UnityAction(this.OnForgeButtonClick));
			this.m_autoEquipButton.onClick.AddListener(new UnityAction(this.OnAutoEquipButtonClick));
			this.m_fastRemoveButton.onClick.AddListener(new UnityAction(this.OnFastRemoveButtonClick));
			this.m_equipItemDescExchangeButton.onClick.AddListener(new UnityAction(this.OnExchangeButtonClick));
			this.m_equipItemDescLockButton.onClick.AddListener(new UnityAction(this.OnEquipemntLockButtonClick));
			this.m_resonanceInfoPanelBgButton.onClick.AddListener(new UnityAction(this.CloseResonanceInfoPanel));
			this.m_enchantmentButton.onClick.AddListener(new UnityAction(this.OnEnchantmentButtonClick));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x060104B9 RID: 66745 RVA: 0x00441830 File Offset: 0x0043FA30
		public void UpdateViewInEquipmentState(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInEquipmentStateHero_hotfix != null)
			{
				this.m_UpdateViewInEquipmentStateHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.CreateEquipmentList();
		}

		// Token: 0x060104BA RID: 66746 RVA: 0x004418B0 File Offset: 0x0043FAB0
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
			if (this.m_equipmentGos.Count == 0)
			{
				this.m_equipmentGos.Add(this.m_equipItem);
				this.m_equipmentGos.Add(this.m_equipItem1);
				this.m_equipmentGos.Add(this.m_equipItem2);
				this.m_equipmentGos.Add(this.m_equipItem3);
			}
			ulong[] equipmentIds = this.m_hero.EquipmentIds;
			for (int i = 0; i < this.m_equipmentGos.Count; i++)
			{
				GameObject gameObject = this.m_equipmentGos[i];
				EquipmentBagItem equipment = null;
				if (i < equipmentIds.Length)
				{
					equipment = (this.m_playerContext.GetBagItemByInstanceId(equipmentIds[i]) as EquipmentBagItem);
				}
				HeroEquipItemUIController component = gameObject.GetComponent<HeroEquipItemUIController>();
				if (component == null)
				{
					PrefabControllerCreater.CreateAllControllers(gameObject);
					component = gameObject.GetComponent<HeroEquipItemUIController>();
					component.EventOnIconClick += this.OnEquipmentIconClick;
					component.EventOnAddButtonClick += this.OnEquipmentAddButtonClick;
					component.EventOnRuneIconButtonClick += this.OnRuneIconButtonClick;
				}
				component.InitHeroEquipmentItem(equipment, i, this.m_hero.HeroId);
			}
			PointDescComponent component2 = this.m_equipItemDescGo.GetComponent<PointDescComponent>();
			if (component2 == null)
			{
				PointDescComponent pointDescComponent = GameObjectUtility.AddControllerToGameObject<PointDescComponent>(this.m_equipItemDescGo);
				pointDescComponent.SetGameObject(this.m_equipItemDescGo, true, null, null);
				pointDescComponent.EventOnClose += delegate()
				{
					this.CloseEquipemntItemDescGo();
				};
			}
			if (this.m_equipItemDescGo.activeSelf && this.m_slot >= 0)
			{
				HeroEquipItemUIController component3 = this.m_equipmentGos[this.m_slot].GetComponent<HeroEquipItemUIController>();
				if (component3 != null)
				{
					this.SetEquipmentItemDesc(component3);
				}
			}
			if (!this.m_autoEquipButtonNormalBg.activeSelf)
			{
				this.m_autoEquipButtonNormalBg.SetActive(true);
			}
			int num = 0;
			foreach (ulong num2 in equipmentIds)
			{
				if (num2 != 0UL)
				{
					num++;
				}
			}
			this.m_fastRemoveButton.gameObject.SetActive(num >= 1);
		}

		// Token: 0x060104BB RID: 66747 RVA: 0x00441B28 File Offset: 0x0043FD28
		private void OnEquipmentIconClick(HeroEquipItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentIconClickHeroEquipItemUIController_hotfix != null)
			{
				this.m_OnEquipmentIconClickHeroEquipItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_equipmentInstanceId = ctrl.Equipment.InstanceId;
			this.m_slot = ctrl.Slot;
			this.SetEquipmentItemDesc(ctrl);
			this.m_equipItemDescGo.SetActive(true);
			CommonUIStateController component = this.m_equipItemDescGo.GetComponent<CommonUIStateController>();
			component.SetToUIState("Show", false, true);
		}

		// Token: 0x060104BC RID: 66748 RVA: 0x00441BE4 File Offset: 0x0043FDE4
		private void OnEquipmentAddButtonClick(HeroEquipItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentAddButtonClickHeroEquipItemUIController_hotfix != null)
			{
				this.m_OnEquipmentAddButtonClickHeroEquipItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.HaveEquipmentInBag(ctrl);
			if (flag)
			{
				this.m_slot = ctrl.Slot;
				if (this.EventOnGotoEquipmentStore != null)
				{
					this.EventOnGotoEquipmentStore(this.m_slot, 0UL);
				}
			}
			else
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_NoEquipmentCanBeUse, 2f, null, true);
			}
		}

		// Token: 0x060104BD RID: 66749 RVA: 0x00441CA8 File Offset: 0x0043FEA8
		private bool HaveEquipmentInBag(HeroEquipItemUIController equipmentCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HaveEquipmentInBagHeroEquipItemUIController_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HaveEquipmentInBagHeroEquipItemUIController_hotfix.call(new object[]
				{
					this,
					equipmentCtrl
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BagItemBase bagItemBase in this.m_playerContext.GetBagItems())
			{
				if (bagItemBase.GoodsTypeId == GoodsType.GoodsType_Equipment && bagItemBase.EquipmentInfo.EquipmentType == (EquipmentType)equipmentCtrl.Slot && this.m_playerContext.CanWearEquipment(this.m_hero.HeroId, bagItemBase.InstanceId) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060104BE RID: 66750 RVA: 0x00441DC0 File Offset: 0x0043FFC0
		private void OnRuneIconButtonClick(HeroEquipItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRuneIconButtonClickHeroEquipItemUIController_hotfix != null)
			{
				this.m_OnRuneIconButtonClickHeroEquipItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetResonanceInfoPanel(ctrl.Equipment);
			this.m_resonanceInfoPanelStateCtrl.gameObject.SetActive(true);
			this.m_resonanceInfoPanelStateCtrl.SetToUIState("Show" + (ctrl.Slot + 1), false, true);
		}

		// Token: 0x060104BF RID: 66751 RVA: 0x00441E74 File Offset: 0x00440074
		private void SetResonanceInfoPanel(EquipmentBagItem equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetResonanceInfoPanelEquipmentBagItem_hotfix != null)
			{
				this.m_SetResonanceInfoPanelEquipmentBagItem_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataResonanceInfo configDataResonanceInfo = this.m_configDataLoader.GetConfigDataResonanceInfo(equipment.ResonanceId);
			int equipmentResonanceNums = this.m_playerContext.GetEquipmentResonanceNums(equipment.InstanceId);
			if (equipmentResonanceNums >= 2)
			{
				this.m_resonanceInfoPanel2SuitStateCtrl.SetToUIState("Active", false, true);
				if (equipmentResonanceNums == 4)
				{
					this.m_resonanceInfoPanel4SuitStateCtrl.SetToUIState("Active", false, true);
				}
				else
				{
					this.m_resonanceInfoPanel4SuitStateCtrl.SetToUIState("Inactive", false, true);
				}
			}
			else
			{
				this.m_resonanceInfoPanel2SuitStateCtrl.SetToUIState("Inactive", false, true);
				this.m_resonanceInfoPanel4SuitStateCtrl.SetToUIState("Inactive", false, true);
			}
			this.m_resonanceInfoPanelNameText.text = configDataResonanceInfo.Name;
			ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect1);
			this.m_resonanceInfoPanel2SuitInfoText.text = configDataSkillInfo.Desc;
			configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect2);
			this.m_resonanceInfoPanel4SuitInfoText.text = configDataSkillInfo.Desc;
		}

		// Token: 0x060104C0 RID: 66752 RVA: 0x00441FD4 File Offset: 0x004401D4
		private void CloseResonanceInfoPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseResonanceInfoPanel_hotfix != null)
			{
				this.m_CloseResonanceInfoPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string stateName = this.m_resonanceInfoPanelStateCtrl.GetCurrentUIState().StateName;
			string stateName2 = stateName.Replace("Show", "Close");
			this.m_resonanceInfoPanelStateCtrl.SetActionForUIStateFinshed(stateName2, delegate
			{
				this.m_resonanceInfoPanelStateCtrl.gameObject.SetActive(false);
			});
			this.m_resonanceInfoPanelStateCtrl.SetToUIState(stateName2, false, true);
		}

		// Token: 0x060104C1 RID: 66753 RVA: 0x00442080 File Offset: 0x00440280
		private void SetEquipmentItemDesc(HeroEquipItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentItemDescHeroEquipItemUIController_hotfix != null)
			{
				this.m_SetEquipmentItemDescHeroEquipItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentBagItem equipment = ctrl.Equipment;
			if (equipment == null)
			{
				return;
			}
			this.m_equipItemDescTitleText.text = equipment.EquipmentInfo.Name;
			this.m_equipItemDescLvText.text = "Lv." + equipment.Level.ToString();
			this.m_equipItemDescIconImage.sprite = AssetUtility.Instance.GetSprite(equipment.EquipmentInfo.Icon);
			this.m_equipItemDescIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(equipment.EquipmentInfo.Rank));
			this.m_equipItemDescSSREffect.SetActive(UIUtility.IsRankSSR(equipment.EquipmentInfo.Rank));
			int num = this.m_playerContext.CaculateEquipmentNextLevelExp(equipment);
			this.m_equipItemDescExpText.text = (num - equipment.Exp).ToString();
			this.m_equipItemDescProgressImage.fillAmount = (float)equipment.Exp / (float)num;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_equipItemDescStarGroup, equipment.StarLevel);
			CommonUIStateController component = this.m_equipItemDescEquipLimitContent.GetComponent<CommonUIStateController>();
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
					for (int i = 0; i < this.m_equipItemDescEquipLimitContent.transform.childCount; i++)
					{
						Transform child = this.m_equipItemDescEquipLimitContent.transform.GetChild(i);
						child.gameObject.SetActive(false);
					}
					for (int j = 0; j < armyIds.Count; j++)
					{
						ConfigDataArmyInfo configDataArmyInfo = this.m_configDataLoader.GetConfigDataArmyInfo(armyIds[j]);
						if (j < this.m_equipItemDescEquipLimitContent.transform.childCount)
						{
							Transform child2 = this.m_equipItemDescEquipLimitContent.transform.GetChild(j);
							child2.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
							child2.gameObject.SetActive(true);
						}
						else
						{
							GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_equipItemDescEquipLimitContent.transform.GetChild(0).gameObject, this.m_equipItemDescEquipLimitContent.transform, true);
							gameObject.transform.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
							gameObject.SetActive(true);
						}
					}
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_equipItemDescPropContent, 0);
			this.SetPropItems(equipment.EquipmentInfo.Property1_ID, equipment.EquipmentInfo.Property1_Value, equipment.EquipmentInfo.Property1_LevelUpValue, equipment.Level);
			this.SetPropItems(equipment.EquipmentInfo.Property2_ID, equipment.EquipmentInfo.Property2_Value, equipment.EquipmentInfo.Property2_LevelUpValue, equipment.Level);
			List<CommonBattleProperty> enchantProperties = equipment.EnchantProperties;
			this.m_enchantmentButton.gameObject.SetActive(LocalConfig.Instance.Data.IsDeveloper && enchantProperties.Count > 0);
			this.m_enchantmentValueInputField1.gameObject.SetActive(LocalConfig.Instance.Data.IsDeveloper && enchantProperties.Count > 0);
			this.m_enchantmentValueInputField2.gameObject.SetActive(LocalConfig.Instance.Data.IsDeveloper && enchantProperties.Count > 0);
			this.m_enchantmentValueInputField3.gameObject.SetActive(LocalConfig.Instance.Data.IsDeveloper && enchantProperties.Count > 0);
			InputField[] array = new InputField[]
			{
				this.m_enchantmentValueInputField1,
				this.m_enchantmentValueInputField2,
				this.m_enchantmentValueInputField3
			};
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
					if (LocalConfig.Instance.Data.IsDeveloper)
					{
						this.m_slectedEquipment = equipment;
						this.m_enchantmentValueTypes[k] = configDataPropertyModifyInfo;
						if (configDataPropertyModifyInfo.IsAddType)
						{
							array[k].text = enchantProperties[k].Value.ToString();
						}
						else
						{
							array[k].text = (enchantProperties[k].Value / 100).ToString();
						}
					}
				}
				else
				{
					text.gameObject.SetActive(false);
					text2.text = "--";
				}
			}
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
			}
			else
			{
				this.m_descPropGroupStateCtrl.SetToUIState("Unresonance", false, true);
			}
			if (equipment.EquipmentInfo.SkillIds.Count != 0)
			{
				string text3 = null;
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(UIUtility.GetSkillIdFromEquipment(equipment.EquipmentInfo, equipment.Level, ref text3));
				if (configDataSkillInfo != null)
				{
					if (text3 == null)
					{
						this.m_equipItemDescSkillContentStateCtrl.SetToUIState("Grey", false, true);
						this.m_equipItemDescUnlockCoditionText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_EnchantToLevel), equipment.EquipmentInfo.SkillLevels[0]);
					}
					else
					{
						this.m_equipItemDescSkillContentStateCtrl.SetToUIState("Normal", false, true);
						this.m_equipItemDescSkillLvText.text = "Lv." + text3;
					}
					this.m_equipItemDescSkillNameText.text = configDataSkillInfo.Name;
					this.m_equipItemDescSkillDescText.text = configDataSkillInfo.Desc;
					ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(equipment.EquipmentInfo.SkillHero);
					if (configDataHeroInfo != null)
					{
						this.m_equipItemDescSkillOwnerText.text = configDataHeroInfo.Name + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Equipment_SkillOwner);
					}
					this.m_equipItemDescSkillOwnerText.gameObject.SetActive(configDataHeroInfo != null);
					this.m_equipItemDescSkillOwnerBGImage.SetActive(configDataHeroInfo != null);
				}
				else
				{
					this.m_equipItemDescSkillNameText.text = null;
					this.m_equipItemDescSkillLvText.text = null;
					this.m_equipItemDescSkillDescText.text = null;
					this.m_equipItemDescSkillOwnerText.text = null;
					this.m_equipItemDescSkillOwnerBGImage.SetActive(false);
				}
			}
			this.m_equipItemDescSkillContent.SetActive(equipment.EquipmentInfo.SkillIds.Count != 0);
			this.m_equipItemDescNotEquipSkillTip.SetActive(equipment.EquipmentInfo.SkillIds.Count == 0);
			CommonUIStateController component2 = this.m_equipItemDescLockButton.GetComponent<CommonUIStateController>();
			if (equipment.Locked)
			{
				component2.SetToUIState("Lock", false, true);
			}
			else
			{
				component2.SetToUIState("Unlock", false, true);
			}
		}

		// Token: 0x060104C2 RID: 66754 RVA: 0x00442A14 File Offset: 0x00440C14
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
			switch (type)
			{
			case PropertyModifyType.PropertyModifyType_Hero1_HPAdd:
				this.m_equipItemDescPropHPGo.SetActive(true);
				this.m_equipItemDescPropHPValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_ATAdd:
				this.m_equipItemDescPropATGo.SetActive(true);
				this.m_equipItemDescPropATValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DFAdd:
				this.m_equipItemDescPropDFGo.SetActive(true);
				this.m_equipItemDescPropDFValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicAdd:
				this.m_equipItemDescPropMagiccGo.SetActive(true);
				this.m_equipItemDescPropMagicValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicDFAdd:
				this.m_equipItemDescPropMagicDFGo.SetActive(true);
				this.m_equipItemDescPropMagicDFValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DEXAdd:
				this.m_equipItemDescPropDexGo.SetActive(true);
				this.m_equipItemDescPropDexValueText.text = "+" + value;
				break;
			}
		}

		// Token: 0x060104C3 RID: 66755 RVA: 0x00442BFC File Offset: 0x00440DFC
		private void OnForgeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnForgeButtonClick_hotfix != null)
			{
				this.m_OnForgeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseEquipemntItemDescGo();
			if (this.EventOnGotoEquipmentForge != null)
			{
				this.EventOnGotoEquipmentForge(this.m_slot, this.m_equipmentInstanceId);
			}
		}

		// Token: 0x060104C4 RID: 66756 RVA: 0x00442C84 File Offset: 0x00440E84
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
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			base.StartCoroutine(TestUIController.SetEnchantProperty(this.m_slectedEquipment.InstanceId, string.Format("{0},{1};{2},{3};{4},{5}", new object[]
			{
				this.m_enchantmentValueTypes[0].ID,
				(!this.m_enchantmentValueTypes[0].IsAddType) ? (int.Parse(this.m_enchantmentValueInputField1.text) * 100).ToString() : this.m_enchantmentValueInputField1.text,
				this.m_enchantmentValueTypes[1].ID,
				(!this.m_enchantmentValueTypes[1].IsAddType) ? (int.Parse(this.m_enchantmentValueInputField2.text) * 100).ToString() : this.m_enchantmentValueInputField2.text,
				this.m_enchantmentValueTypes[2].ID,
				(!this.m_enchantmentValueTypes[2].IsAddType) ? (int.Parse(this.m_enchantmentValueInputField3.text) * 100).ToString() : this.m_enchantmentValueInputField3.text
			}), null));
		}

		// Token: 0x060104C5 RID: 66757 RVA: 0x00442E28 File Offset: 0x00441028
		private void OnExchangeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExchangeButtonClick_hotfix != null)
			{
				this.m_OnExchangeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseEquipemntItemDescGo();
			if (this.EventOnGotoEquipmentStore != null)
			{
				this.EventOnGotoEquipmentStore(this.m_slot, this.m_equipmentInstanceId);
			}
		}

		// Token: 0x060104C6 RID: 66758 RVA: 0x00442EB0 File Offset: 0x004410B0
		private void OnAutoEquipButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAutoEquipButtonClick_hotfix != null)
			{
				this.m_OnAutoEquipButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanAutoEquipment(this.m_hero.HeroId);
			if (num == 0)
			{
				if (this.EventOnAutoEquip != null)
				{
					this.EventOnAutoEquip(this.m_hero.HeroId, delegate
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_UpdateEquipmentSucceed, (float)this.m_configDataLoader.ConfigableConstId_AutoEquipmentDeltaTime, null, true);
					});
				}
			}
			else if (num == -654)
			{
				CommonUIController.Instance.ShowErrorMessage(num, (float)this.m_configDataLoader.ConfigableConstId_AutoEquipmentDeltaTime, null, true);
			}
			base.StartCoroutine(this.DisableAutoEquipButton());
		}

		// Token: 0x060104C7 RID: 66759 RVA: 0x00442F90 File Offset: 0x00441190
		private void OnFastRemoveButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFastRemoveButtonClick_hotfix != null)
			{
				this.m_OnFastRemoveButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!false && this.EventOnAutoRemove != null)
			{
				this.EventOnAutoRemove(this.m_hero.HeroId);
			}
		}

		// Token: 0x060104C8 RID: 66760 RVA: 0x0044301C File Offset: 0x0044121C
		[DebuggerHidden]
		private IEnumerator DisableAutoEquipButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DisableAutoEquipButton_hotfix != null)
			{
				return (IEnumerator)this.m_DisableAutoEquipButton_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDetailEquipmentUIController.<DisableAutoEquipButton>c__Iterator0 <DisableAutoEquipButton>c__Iterator = new HeroDetailEquipmentUIController.<DisableAutoEquipButton>c__Iterator0();
			<DisableAutoEquipButton>c__Iterator.$this = this;
			return <DisableAutoEquipButton>c__Iterator;
		}

		// Token: 0x060104C9 RID: 66761 RVA: 0x00443098 File Offset: 0x00441298
		private void CloseEquipemntItemDescGo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseEquipemntItemDescGo_hotfix != null)
			{
				this.m_CloseEquipemntItemDescGo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_equipItemDescGo.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateClose(component, "Close", delegate
			{
				this.m_equipItemDescGo.SetActive(false);
			}, false, true);
		}

		// Token: 0x060104CA RID: 66762 RVA: 0x00443120 File Offset: 0x00441320
		private void OnEquipemntLockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipemntLockButtonClick_hotfix != null)
			{
				this.m_OnEquipemntLockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnLockButtonClick != null)
			{
				this.EventOnLockButtonClick(this.m_equipmentInstanceId, this.m_slot, delegate
				{
					CommonUIStateController component = this.m_equipItemDescLockButton.GetComponent<CommonUIStateController>();
					if (UIUtility.GetUIStateCurrentStateName(component) == "Unlock")
					{
						component.SetToUIState("Lock", false, true);
					}
					else
					{
						component.SetToUIState("Unlock", false, true);
					}
				});
			}
		}

		// Token: 0x060104CB RID: 66763 RVA: 0x004431B0 File Offset: 0x004413B0
		public void SetCommonUIState(string stateName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonUIStateString_hotfix != null)
			{
				this.m_SetCommonUIStateString_hotfix.call(new object[]
				{
					this,
					stateName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateOpen(component, stateName, null, true, true);
		}

		// Token: 0x14000370 RID: 880
		// (add) Token: 0x060104CC RID: 66764 RVA: 0x00443238 File Offset: 0x00441438
		// (remove) Token: 0x060104CD RID: 66765 RVA: 0x004432D4 File Offset: 0x004414D4
		public event Action<int> EventOnAutoRemove
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAutoRemoveAction`1_hotfix != null)
				{
					this.m_add_EventOnAutoRemoveAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnAutoRemove;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnAutoRemove, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAutoRemoveAction`1_hotfix != null)
				{
					this.m_remove_EventOnAutoRemoveAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnAutoRemove;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnAutoRemove, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000371 RID: 881
		// (add) Token: 0x060104CE RID: 66766 RVA: 0x00443370 File Offset: 0x00441570
		// (remove) Token: 0x060104CF RID: 66767 RVA: 0x0044340C File Offset: 0x0044160C
		public event Action<int, Action> EventOnAutoEquip
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAutoEquipAction`2_hotfix != null)
				{
					this.m_add_EventOnAutoEquipAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, Action> action = this.EventOnAutoEquip;
				Action<int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, Action>>(ref this.EventOnAutoEquip, (Action<int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAutoEquipAction`2_hotfix != null)
				{
					this.m_remove_EventOnAutoEquipAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, Action> action = this.EventOnAutoEquip;
				Action<int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, Action>>(ref this.EventOnAutoEquip, (Action<int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000372 RID: 882
		// (add) Token: 0x060104D0 RID: 66768 RVA: 0x004434A8 File Offset: 0x004416A8
		// (remove) Token: 0x060104D1 RID: 66769 RVA: 0x00443544 File Offset: 0x00441744
		public event Action<int, ulong> EventOnGotoEquipmentForge
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoEquipmentForgeAction`2_hotfix != null)
				{
					this.m_add_EventOnGotoEquipmentForgeAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong> action = this.EventOnGotoEquipmentForge;
				Action<int, ulong> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong>>(ref this.EventOnGotoEquipmentForge, (Action<int, ulong>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoEquipmentForgeAction`2_hotfix != null)
				{
					this.m_remove_EventOnGotoEquipmentForgeAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong> action = this.EventOnGotoEquipmentForge;
				Action<int, ulong> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong>>(ref this.EventOnGotoEquipmentForge, (Action<int, ulong>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000373 RID: 883
		// (add) Token: 0x060104D2 RID: 66770 RVA: 0x004435E0 File Offset: 0x004417E0
		// (remove) Token: 0x060104D3 RID: 66771 RVA: 0x0044367C File Offset: 0x0044187C
		public event Action<int, ulong> EventOnGotoEquipmentStore
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoEquipmentStoreAction`2_hotfix != null)
				{
					this.m_add_EventOnGotoEquipmentStoreAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong> action = this.EventOnGotoEquipmentStore;
				Action<int, ulong> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong>>(ref this.EventOnGotoEquipmentStore, (Action<int, ulong>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoEquipmentStoreAction`2_hotfix != null)
				{
					this.m_remove_EventOnGotoEquipmentStoreAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong> action = this.EventOnGotoEquipmentStore;
				Action<int, ulong> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong>>(ref this.EventOnGotoEquipmentStore, (Action<int, ulong>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000374 RID: 884
		// (add) Token: 0x060104D4 RID: 66772 RVA: 0x00443718 File Offset: 0x00441918
		// (remove) Token: 0x060104D5 RID: 66773 RVA: 0x004437B4 File Offset: 0x004419B4
		public event Action<ulong, int, Action> EventOnLockButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLockButtonClickAction`3_hotfix != null)
				{
					this.m_add_EventOnLockButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, Action> action = this.EventOnLockButtonClick;
				Action<ulong, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, Action>>(ref this.EventOnLockButtonClick, (Action<ulong, int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLockButtonClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnLockButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong, int, Action> action = this.EventOnLockButtonClick;
				Action<ulong, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong, int, Action>>(ref this.EventOnLockButtonClick, (Action<ulong, int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x060104D6 RID: 66774 RVA: 0x00443850 File Offset: 0x00441A50
		// (set) Token: 0x060104D7 RID: 66775 RVA: 0x00443870 File Offset: 0x00441A70
		[DoNotToLua]
		public new HeroDetailEquipmentUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDetailEquipmentUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060104D8 RID: 66776 RVA: 0x0044387C File Offset: 0x00441A7C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060104D9 RID: 66777 RVA: 0x00443888 File Offset: 0x00441A88
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060104DA RID: 66778 RVA: 0x00443890 File Offset: 0x00441A90
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060104DB RID: 66779 RVA: 0x00443898 File Offset: 0x00441A98
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060104DC RID: 66780 RVA: 0x004438AC File Offset: 0x00441AAC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060104DD RID: 66781 RVA: 0x004438B4 File Offset: 0x00441AB4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060104DE RID: 66782 RVA: 0x004438C0 File Offset: 0x00441AC0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060104DF RID: 66783 RVA: 0x004438CC File Offset: 0x00441ACC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060104E0 RID: 66784 RVA: 0x004438D8 File Offset: 0x00441AD8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060104E1 RID: 66785 RVA: 0x004438E4 File Offset: 0x00441AE4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060104E2 RID: 66786 RVA: 0x004438F0 File Offset: 0x00441AF0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060104E3 RID: 66787 RVA: 0x004438FC File Offset: 0x00441AFC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060104E4 RID: 66788 RVA: 0x00443908 File Offset: 0x00441B08
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060104E5 RID: 66789 RVA: 0x00443914 File Offset: 0x00441B14
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060104E6 RID: 66790 RVA: 0x00443920 File Offset: 0x00441B20
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060104E7 RID: 66791 RVA: 0x00443928 File Offset: 0x00441B28
		private void __callDele_EventOnAutoRemove(int obj)
		{
			Action<int> eventOnAutoRemove = this.EventOnAutoRemove;
			if (eventOnAutoRemove != null)
			{
				eventOnAutoRemove(obj);
			}
		}

		// Token: 0x060104E8 RID: 66792 RVA: 0x0044394C File Offset: 0x00441B4C
		private void __clearDele_EventOnAutoRemove(int obj)
		{
			this.EventOnAutoRemove = null;
		}

		// Token: 0x060104E9 RID: 66793 RVA: 0x00443958 File Offset: 0x00441B58
		private void __callDele_EventOnAutoEquip(int arg1, Action arg2)
		{
			Action<int, Action> eventOnAutoEquip = this.EventOnAutoEquip;
			if (eventOnAutoEquip != null)
			{
				eventOnAutoEquip(arg1, arg2);
			}
		}

		// Token: 0x060104EA RID: 66794 RVA: 0x0044397C File Offset: 0x00441B7C
		private void __clearDele_EventOnAutoEquip(int arg1, Action arg2)
		{
			this.EventOnAutoEquip = null;
		}

		// Token: 0x060104EB RID: 66795 RVA: 0x00443988 File Offset: 0x00441B88
		private void __callDele_EventOnGotoEquipmentForge(int arg1, ulong arg2)
		{
			Action<int, ulong> eventOnGotoEquipmentForge = this.EventOnGotoEquipmentForge;
			if (eventOnGotoEquipmentForge != null)
			{
				eventOnGotoEquipmentForge(arg1, arg2);
			}
		}

		// Token: 0x060104EC RID: 66796 RVA: 0x004439AC File Offset: 0x00441BAC
		private void __clearDele_EventOnGotoEquipmentForge(int arg1, ulong arg2)
		{
			this.EventOnGotoEquipmentForge = null;
		}

		// Token: 0x060104ED RID: 66797 RVA: 0x004439B8 File Offset: 0x00441BB8
		private void __callDele_EventOnGotoEquipmentStore(int arg1, ulong arg2)
		{
			Action<int, ulong> eventOnGotoEquipmentStore = this.EventOnGotoEquipmentStore;
			if (eventOnGotoEquipmentStore != null)
			{
				eventOnGotoEquipmentStore(arg1, arg2);
			}
		}

		// Token: 0x060104EE RID: 66798 RVA: 0x004439DC File Offset: 0x00441BDC
		private void __clearDele_EventOnGotoEquipmentStore(int arg1, ulong arg2)
		{
			this.EventOnGotoEquipmentStore = null;
		}

		// Token: 0x060104EF RID: 66799 RVA: 0x004439E8 File Offset: 0x00441BE8
		private void __callDele_EventOnLockButtonClick(ulong arg1, int arg2, Action arg3)
		{
			Action<ulong, int, Action> eventOnLockButtonClick = this.EventOnLockButtonClick;
			if (eventOnLockButtonClick != null)
			{
				eventOnLockButtonClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x060104F0 RID: 66800 RVA: 0x00443A0C File Offset: 0x00441C0C
		private void __clearDele_EventOnLockButtonClick(ulong arg1, int arg2, Action arg3)
		{
			this.EventOnLockButtonClick = null;
		}

		// Token: 0x060104F6 RID: 66806 RVA: 0x00443AB4 File Offset: 0x00441CB4
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
					this.m_UpdateViewInEquipmentStateHero_hotfix = (luaObj.RawGet("UpdateViewInEquipmentState") as LuaFunction);
					this.m_CreateEquipmentList_hotfix = (luaObj.RawGet("CreateEquipmentList") as LuaFunction);
					this.m_OnEquipmentIconClickHeroEquipItemUIController_hotfix = (luaObj.RawGet("OnEquipmentIconClick") as LuaFunction);
					this.m_OnEquipmentAddButtonClickHeroEquipItemUIController_hotfix = (luaObj.RawGet("OnEquipmentAddButtonClick") as LuaFunction);
					this.m_HaveEquipmentInBagHeroEquipItemUIController_hotfix = (luaObj.RawGet("HaveEquipmentInBag") as LuaFunction);
					this.m_OnRuneIconButtonClickHeroEquipItemUIController_hotfix = (luaObj.RawGet("OnRuneIconButtonClick") as LuaFunction);
					this.m_SetResonanceInfoPanelEquipmentBagItem_hotfix = (luaObj.RawGet("SetResonanceInfoPanel") as LuaFunction);
					this.m_CloseResonanceInfoPanel_hotfix = (luaObj.RawGet("CloseResonanceInfoPanel") as LuaFunction);
					this.m_SetEquipmentItemDescHeroEquipItemUIController_hotfix = (luaObj.RawGet("SetEquipmentItemDesc") as LuaFunction);
					this.m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix = (luaObj.RawGet("SetPropItems") as LuaFunction);
					this.m_OnForgeButtonClick_hotfix = (luaObj.RawGet("OnForgeButtonClick") as LuaFunction);
					this.m_OnEnchantmentButtonClick_hotfix = (luaObj.RawGet("OnEnchantmentButtonClick") as LuaFunction);
					this.m_OnExchangeButtonClick_hotfix = (luaObj.RawGet("OnExchangeButtonClick") as LuaFunction);
					this.m_OnAutoEquipButtonClick_hotfix = (luaObj.RawGet("OnAutoEquipButtonClick") as LuaFunction);
					this.m_OnFastRemoveButtonClick_hotfix = (luaObj.RawGet("OnFastRemoveButtonClick") as LuaFunction);
					this.m_DisableAutoEquipButton_hotfix = (luaObj.RawGet("DisableAutoEquipButton") as LuaFunction);
					this.m_CloseEquipemntItemDescGo_hotfix = (luaObj.RawGet("CloseEquipemntItemDescGo") as LuaFunction);
					this.m_OnEquipemntLockButtonClick_hotfix = (luaObj.RawGet("OnEquipemntLockButtonClick") as LuaFunction);
					this.m_SetCommonUIStateString_hotfix = (luaObj.RawGet("SetCommonUIState") as LuaFunction);
					this.m_add_EventOnAutoRemoveAction`1_hotfix = (luaObj.RawGet("add_EventOnAutoRemove") as LuaFunction);
					this.m_remove_EventOnAutoRemoveAction`1_hotfix = (luaObj.RawGet("remove_EventOnAutoRemove") as LuaFunction);
					this.m_add_EventOnAutoEquipAction`2_hotfix = (luaObj.RawGet("add_EventOnAutoEquip") as LuaFunction);
					this.m_remove_EventOnAutoEquipAction`2_hotfix = (luaObj.RawGet("remove_EventOnAutoEquip") as LuaFunction);
					this.m_add_EventOnGotoEquipmentForgeAction`2_hotfix = (luaObj.RawGet("add_EventOnGotoEquipmentForge") as LuaFunction);
					this.m_remove_EventOnGotoEquipmentForgeAction`2_hotfix = (luaObj.RawGet("remove_EventOnGotoEquipmentForge") as LuaFunction);
					this.m_add_EventOnGotoEquipmentStoreAction`2_hotfix = (luaObj.RawGet("add_EventOnGotoEquipmentStore") as LuaFunction);
					this.m_remove_EventOnGotoEquipmentStoreAction`2_hotfix = (luaObj.RawGet("remove_EventOnGotoEquipmentStore") as LuaFunction);
					this.m_add_EventOnLockButtonClickAction`3_hotfix = (luaObj.RawGet("add_EventOnLockButtonClick") as LuaFunction);
					this.m_remove_EventOnLockButtonClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnLockButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060104F7 RID: 66807 RVA: 0x00443E54 File Offset: 0x00442054
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDetailEquipmentUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400979A RID: 38810
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400979B RID: 38811
		[AutoBind("./Content/Equipment1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItem;

		// Token: 0x0400979C RID: 38812
		[AutoBind("./Content/Equipment2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItem1;

		// Token: 0x0400979D RID: 38813
		[AutoBind("./Content/Equipment3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItem2;

		// Token: 0x0400979E RID: 38814
		[AutoBind("./Content/Equipment4", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItem3;

		// Token: 0x0400979F RID: 38815
		[AutoBind("./FastEquipButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_autoEquipButton;

		// Token: 0x040097A0 RID: 38816
		[AutoBind("./FastEquipButton/Image", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_autoEquipButtonNormalBg;

		// Token: 0x040097A1 RID: 38817
		[AutoBind("./FastRemoveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_fastRemoveButton;

		// Token: 0x040097A2 RID: 38818
		[AutoBind("./Desc", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_equipItemDescGo;

		// Token: 0x040097A3 RID: 38819
		[AutoBind("./Desc/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescTitleText;

		// Token: 0x040097A4 RID: 38820
		[AutoBind("./Desc/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescLvText;

		// Token: 0x040097A5 RID: 38821
		[AutoBind("./Desc/ExpText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescExpText;

		// Token: 0x040097A6 RID: 38822
		[AutoBind("./Desc/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_equipItemDescIconImage;

		// Token: 0x040097A7 RID: 38823
		[AutoBind("./Desc/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_equipItemDescIconBg;

		// Token: 0x040097A8 RID: 38824
		[AutoBind("./Desc/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescSSREffect;

		// Token: 0x040097A9 RID: 38825
		[AutoBind("./Desc/ProgressImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_equipItemDescProgressImage;

		// Token: 0x040097AA RID: 38826
		[AutoBind("./Desc/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescStarGroup;

		// Token: 0x040097AB RID: 38827
		[AutoBind("./Desc/EquipLimitContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescEquipLimitContent;

		// Token: 0x040097AC RID: 38828
		[AutoBind("./Desc/EquipUnlimitText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descEquipUnlimitText;

		// Token: 0x040097AD RID: 38829
		[AutoBind("./Desc/PropGroup/PropContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropContent;

		// Token: 0x040097AE RID: 38830
		[AutoBind("./Desc/PropGroup/PropContent/AT", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropATGo;

		// Token: 0x040097AF RID: 38831
		[AutoBind("./Desc/PropGroup/PropContent/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropATValueText;

		// Token: 0x040097B0 RID: 38832
		[AutoBind("./Desc/PropGroup/PropContent/DF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropDFGo;

		// Token: 0x040097B1 RID: 38833
		[AutoBind("./Desc/PropGroup/PropContent/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropDFValueText;

		// Token: 0x040097B2 RID: 38834
		[AutoBind("./Desc/PropGroup/PropContent/HP", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropHPGo;

		// Token: 0x040097B3 RID: 38835
		[AutoBind("./Desc/PropGroup/PropContent/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropHPValueText;

		// Token: 0x040097B4 RID: 38836
		[AutoBind("./Desc/PropGroup/PropContent/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropMagiccGo;

		// Token: 0x040097B5 RID: 38837
		[AutoBind("./Desc/PropGroup/PropContent/Magic/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropMagicValueText;

		// Token: 0x040097B6 RID: 38838
		[AutoBind("./Desc/PropGroup/PropContent/MagicDF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropMagicDFGo;

		// Token: 0x040097B7 RID: 38839
		[AutoBind("./Desc/PropGroup/PropContent/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropMagicDFValueText;

		// Token: 0x040097B8 RID: 38840
		[AutoBind("./Desc/PropGroup/PropContent/Dex", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropDexGo;

		// Token: 0x040097B9 RID: 38841
		[AutoBind("./Desc/PropGroup/PropContent/Dex/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropDexValueText;

		// Token: 0x040097BA RID: 38842
		[AutoBind("./Desc/PropGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_descPropGroupStateCtrl;

		// Token: 0x040097BB RID: 38843
		[AutoBind("./Desc/PropGroup/EnchantmentGroup/PropertyGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_descPropEnchantmentGroup;

		// Token: 0x040097BC RID: 38844
		[AutoBind("./Desc/PropGroup/EnchantmentGroup/Resonance", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_descPropEnchantmentGroupRuneStateCtrl;

		// Token: 0x040097BD RID: 38845
		[AutoBind("./Desc/PropGroup/EnchantmentGroup/Resonance/RuneIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_descPropEnchantmentGroupRuneIconImage;

		// Token: 0x040097BE RID: 38846
		[AutoBind("./Desc/PropGroup/EnchantmentGroup/Resonance/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descPropEnchantmentGroupRuneNameText;

		// Token: 0x040097BF RID: 38847
		[AutoBind("./Desc/ValueInputField1", AutoBindAttribute.InitState.Inactive, false)]
		private InputField m_enchantmentValueInputField1;

		// Token: 0x040097C0 RID: 38848
		[AutoBind("./Desc/ValueInputField2", AutoBindAttribute.InitState.Inactive, false)]
		private InputField m_enchantmentValueInputField2;

		// Token: 0x040097C1 RID: 38849
		[AutoBind("./Desc/ValueInputField3", AutoBindAttribute.InitState.Inactive, false)]
		private InputField m_enchantmentValueInputField3;

		// Token: 0x040097C2 RID: 38850
		[AutoBind("./Desc/EnchantmentButton", AutoBindAttribute.InitState.Inactive, false)]
		private Button m_enchantmentButton;

		// Token: 0x040097C3 RID: 38851
		private ConfigDataPropertyModifyInfo[] m_enchantmentValueTypes = new ConfigDataPropertyModifyInfo[3];

		// Token: 0x040097C4 RID: 38852
		private EquipmentBagItem m_slectedEquipment;

		// Token: 0x040097C5 RID: 38853
		[AutoBind("./Desc/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescSkillContent;

		// Token: 0x040097C6 RID: 38854
		[AutoBind("./Desc/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_equipItemDescSkillContentStateCtrl;

		// Token: 0x040097C7 RID: 38855
		[AutoBind("./Desc/SkillContent/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescSkillNameText;

		// Token: 0x040097C8 RID: 38856
		[AutoBind("./Desc/SkillContent/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescSkillLvText;

		// Token: 0x040097C9 RID: 38857
		[AutoBind("./Desc/SkillContent/UnlockCoditionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescUnlockCoditionText;

		// Token: 0x040097CA RID: 38858
		[AutoBind("./Desc/SkillContent/Owner", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescSkillOwnerText;

		// Token: 0x040097CB RID: 38859
		[AutoBind("./Desc/SkillContent/BelongBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescSkillOwnerBGImage;

		// Token: 0x040097CC RID: 38860
		[AutoBind("./Desc/SkillContent/DescScrollView/Mask/Content/Desc", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescSkillDescText;

		// Token: 0x040097CD RID: 38861
		[AutoBind("./Desc/NotEquipSkillTip", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescNotEquipSkillTip;

		// Token: 0x040097CE RID: 38862
		[AutoBind("./Desc/LockButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_equipItemDescLockButton;

		// Token: 0x040097CF RID: 38863
		[AutoBind("./Desc/ForgeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_equipItemDescForgeButton;

		// Token: 0x040097D0 RID: 38864
		[AutoBind("./Desc/ExchangeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_equipItemDescExchangeButton;

		// Token: 0x040097D1 RID: 38865
		[AutoBind("./ResonanceInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_resonanceInfoPanelStateCtrl;

		// Token: 0x040097D2 RID: 38866
		[AutoBind("./ResonanceInfoPanel/BgButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_resonanceInfoPanelBgButton;

		// Token: 0x040097D3 RID: 38867
		[AutoBind("./ResonanceInfoPanel/SuitInfo/2SuitInfo", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_resonanceInfoPanel2SuitStateCtrl;

		// Token: 0x040097D4 RID: 38868
		[AutoBind("./ResonanceInfoPanel/SuitInfo/2SuitInfo/2SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_resonanceInfoPanel2SuitInfoText;

		// Token: 0x040097D5 RID: 38869
		[AutoBind("./ResonanceInfoPanel/SuitInfo/4SuitInfo", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_resonanceInfoPanel4SuitStateCtrl;

		// Token: 0x040097D6 RID: 38870
		[AutoBind("./ResonanceInfoPanel/SuitInfo/4SuitInfo/4SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_resonanceInfoPanel4SuitInfoText;

		// Token: 0x040097D7 RID: 38871
		[AutoBind("./ResonanceInfoPanel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_resonanceInfoPanelNameText;

		// Token: 0x040097D8 RID: 38872
		private int m_slot = -1;

		// Token: 0x040097D9 RID: 38873
		private Hero m_hero;

		// Token: 0x040097DA RID: 38874
		private ulong m_equipmentInstanceId;

		// Token: 0x040097DB RID: 38875
		private List<GameObject> m_equipmentGos = new List<GameObject>();

		// Token: 0x040097DC RID: 38876
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040097DD RID: 38877
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040097DE RID: 38878
		[DoNotToLua]
		private HeroDetailEquipmentUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040097DF RID: 38879
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040097E0 RID: 38880
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040097E1 RID: 38881
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040097E2 RID: 38882
		private LuaFunction m_UpdateViewInEquipmentStateHero_hotfix;

		// Token: 0x040097E3 RID: 38883
		private LuaFunction m_CreateEquipmentList_hotfix;

		// Token: 0x040097E4 RID: 38884
		private LuaFunction m_OnEquipmentIconClickHeroEquipItemUIController_hotfix;

		// Token: 0x040097E5 RID: 38885
		private LuaFunction m_OnEquipmentAddButtonClickHeroEquipItemUIController_hotfix;

		// Token: 0x040097E6 RID: 38886
		private LuaFunction m_HaveEquipmentInBagHeroEquipItemUIController_hotfix;

		// Token: 0x040097E7 RID: 38887
		private LuaFunction m_OnRuneIconButtonClickHeroEquipItemUIController_hotfix;

		// Token: 0x040097E8 RID: 38888
		private LuaFunction m_SetResonanceInfoPanelEquipmentBagItem_hotfix;

		// Token: 0x040097E9 RID: 38889
		private LuaFunction m_CloseResonanceInfoPanel_hotfix;

		// Token: 0x040097EA RID: 38890
		private LuaFunction m_SetEquipmentItemDescHeroEquipItemUIController_hotfix;

		// Token: 0x040097EB RID: 38891
		private LuaFunction m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix;

		// Token: 0x040097EC RID: 38892
		private LuaFunction m_OnForgeButtonClick_hotfix;

		// Token: 0x040097ED RID: 38893
		private LuaFunction m_OnEnchantmentButtonClick_hotfix;

		// Token: 0x040097EE RID: 38894
		private LuaFunction m_OnExchangeButtonClick_hotfix;

		// Token: 0x040097EF RID: 38895
		private LuaFunction m_OnAutoEquipButtonClick_hotfix;

		// Token: 0x040097F0 RID: 38896
		private LuaFunction m_OnFastRemoveButtonClick_hotfix;

		// Token: 0x040097F1 RID: 38897
		private LuaFunction m_DisableAutoEquipButton_hotfix;

		// Token: 0x040097F2 RID: 38898
		private LuaFunction m_CloseEquipemntItemDescGo_hotfix;

		// Token: 0x040097F3 RID: 38899
		private LuaFunction m_OnEquipemntLockButtonClick_hotfix;

		// Token: 0x040097F4 RID: 38900
		private LuaFunction m_SetCommonUIStateString_hotfix;

		// Token: 0x040097F5 RID: 38901
		private LuaFunction m_add_EventOnAutoRemoveAction;

		// Token: 0x040097F6 RID: 38902
		private LuaFunction m_remove_EventOnAutoRemoveAction;

		// Token: 0x040097F7 RID: 38903
		private LuaFunction m_add_EventOnAutoEquipAction;

		// Token: 0x040097F8 RID: 38904
		private LuaFunction m_remove_EventOnAutoEquipAction;

		// Token: 0x040097F9 RID: 38905
		private LuaFunction m_add_EventOnGotoEquipmentForgeAction;

		// Token: 0x040097FA RID: 38906
		private LuaFunction m_remove_EventOnGotoEquipmentForgeAction;

		// Token: 0x040097FB RID: 38907
		private LuaFunction m_add_EventOnGotoEquipmentStoreAction;

		// Token: 0x040097FC RID: 38908
		private LuaFunction m_remove_EventOnGotoEquipmentStoreAction;

		// Token: 0x040097FD RID: 38909
		private LuaFunction m_add_EventOnLockButtonClickAction;

		// Token: 0x040097FE RID: 38910
		private LuaFunction m_remove_EventOnLockButtonClickAction;

		// Token: 0x02000D98 RID: 3480
		public new class LuaExportHelper
		{
			// Token: 0x060104F8 RID: 66808 RVA: 0x00443EBC File Offset: 0x004420BC
			public LuaExportHelper(HeroDetailEquipmentUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060104F9 RID: 66809 RVA: 0x00443ECC File Offset: 0x004420CC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060104FA RID: 66810 RVA: 0x00443EDC File Offset: 0x004420DC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060104FB RID: 66811 RVA: 0x00443EEC File Offset: 0x004420EC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060104FC RID: 66812 RVA: 0x00443EFC File Offset: 0x004420FC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060104FD RID: 66813 RVA: 0x00443F14 File Offset: 0x00442114
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060104FE RID: 66814 RVA: 0x00443F24 File Offset: 0x00442124
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060104FF RID: 66815 RVA: 0x00443F34 File Offset: 0x00442134
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010500 RID: 66816 RVA: 0x00443F44 File Offset: 0x00442144
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010501 RID: 66817 RVA: 0x00443F54 File Offset: 0x00442154
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010502 RID: 66818 RVA: 0x00443F64 File Offset: 0x00442164
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010503 RID: 66819 RVA: 0x00443F74 File Offset: 0x00442174
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010504 RID: 66820 RVA: 0x00443F84 File Offset: 0x00442184
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010505 RID: 66821 RVA: 0x00443F94 File Offset: 0x00442194
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010506 RID: 66822 RVA: 0x00443FA4 File Offset: 0x004421A4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010507 RID: 66823 RVA: 0x00443FB4 File Offset: 0x004421B4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010508 RID: 66824 RVA: 0x00443FC4 File Offset: 0x004421C4
			public void __callDele_EventOnAutoRemove(int obj)
			{
				this.m_owner.__callDele_EventOnAutoRemove(obj);
			}

			// Token: 0x06010509 RID: 66825 RVA: 0x00443FD4 File Offset: 0x004421D4
			public void __clearDele_EventOnAutoRemove(int obj)
			{
				this.m_owner.__clearDele_EventOnAutoRemove(obj);
			}

			// Token: 0x0601050A RID: 66826 RVA: 0x00443FE4 File Offset: 0x004421E4
			public void __callDele_EventOnAutoEquip(int arg1, Action arg2)
			{
				this.m_owner.__callDele_EventOnAutoEquip(arg1, arg2);
			}

			// Token: 0x0601050B RID: 66827 RVA: 0x00443FF4 File Offset: 0x004421F4
			public void __clearDele_EventOnAutoEquip(int arg1, Action arg2)
			{
				this.m_owner.__clearDele_EventOnAutoEquip(arg1, arg2);
			}

			// Token: 0x0601050C RID: 66828 RVA: 0x00444004 File Offset: 0x00442204
			public void __callDele_EventOnGotoEquipmentForge(int arg1, ulong arg2)
			{
				this.m_owner.__callDele_EventOnGotoEquipmentForge(arg1, arg2);
			}

			// Token: 0x0601050D RID: 66829 RVA: 0x00444014 File Offset: 0x00442214
			public void __clearDele_EventOnGotoEquipmentForge(int arg1, ulong arg2)
			{
				this.m_owner.__clearDele_EventOnGotoEquipmentForge(arg1, arg2);
			}

			// Token: 0x0601050E RID: 66830 RVA: 0x00444024 File Offset: 0x00442224
			public void __callDele_EventOnGotoEquipmentStore(int arg1, ulong arg2)
			{
				this.m_owner.__callDele_EventOnGotoEquipmentStore(arg1, arg2);
			}

			// Token: 0x0601050F RID: 66831 RVA: 0x00444034 File Offset: 0x00442234
			public void __clearDele_EventOnGotoEquipmentStore(int arg1, ulong arg2)
			{
				this.m_owner.__clearDele_EventOnGotoEquipmentStore(arg1, arg2);
			}

			// Token: 0x06010510 RID: 66832 RVA: 0x00444044 File Offset: 0x00442244
			public void __callDele_EventOnLockButtonClick(ulong arg1, int arg2, Action arg3)
			{
				this.m_owner.__callDele_EventOnLockButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x06010511 RID: 66833 RVA: 0x00444054 File Offset: 0x00442254
			public void __clearDele_EventOnLockButtonClick(ulong arg1, int arg2, Action arg3)
			{
				this.m_owner.__clearDele_EventOnLockButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x1700322C RID: 12844
			// (get) Token: 0x06010512 RID: 66834 RVA: 0x00444064 File Offset: 0x00442264
			// (set) Token: 0x06010513 RID: 66835 RVA: 0x00444074 File Offset: 0x00442274
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

			// Token: 0x1700322D RID: 12845
			// (get) Token: 0x06010514 RID: 66836 RVA: 0x00444084 File Offset: 0x00442284
			// (set) Token: 0x06010515 RID: 66837 RVA: 0x00444094 File Offset: 0x00442294
			public GameObject m_equipItem
			{
				get
				{
					return this.m_owner.m_equipItem;
				}
				set
				{
					this.m_owner.m_equipItem = value;
				}
			}

			// Token: 0x1700322E RID: 12846
			// (get) Token: 0x06010516 RID: 66838 RVA: 0x004440A4 File Offset: 0x004422A4
			// (set) Token: 0x06010517 RID: 66839 RVA: 0x004440B4 File Offset: 0x004422B4
			public GameObject m_equipItem1
			{
				get
				{
					return this.m_owner.m_equipItem1;
				}
				set
				{
					this.m_owner.m_equipItem1 = value;
				}
			}

			// Token: 0x1700322F RID: 12847
			// (get) Token: 0x06010518 RID: 66840 RVA: 0x004440C4 File Offset: 0x004422C4
			// (set) Token: 0x06010519 RID: 66841 RVA: 0x004440D4 File Offset: 0x004422D4
			public GameObject m_equipItem2
			{
				get
				{
					return this.m_owner.m_equipItem2;
				}
				set
				{
					this.m_owner.m_equipItem2 = value;
				}
			}

			// Token: 0x17003230 RID: 12848
			// (get) Token: 0x0601051A RID: 66842 RVA: 0x004440E4 File Offset: 0x004422E4
			// (set) Token: 0x0601051B RID: 66843 RVA: 0x004440F4 File Offset: 0x004422F4
			public GameObject m_equipItem3
			{
				get
				{
					return this.m_owner.m_equipItem3;
				}
				set
				{
					this.m_owner.m_equipItem3 = value;
				}
			}

			// Token: 0x17003231 RID: 12849
			// (get) Token: 0x0601051C RID: 66844 RVA: 0x00444104 File Offset: 0x00442304
			// (set) Token: 0x0601051D RID: 66845 RVA: 0x00444114 File Offset: 0x00442314
			public Button m_autoEquipButton
			{
				get
				{
					return this.m_owner.m_autoEquipButton;
				}
				set
				{
					this.m_owner.m_autoEquipButton = value;
				}
			}

			// Token: 0x17003232 RID: 12850
			// (get) Token: 0x0601051E RID: 66846 RVA: 0x00444124 File Offset: 0x00442324
			// (set) Token: 0x0601051F RID: 66847 RVA: 0x00444134 File Offset: 0x00442334
			public GameObject m_autoEquipButtonNormalBg
			{
				get
				{
					return this.m_owner.m_autoEquipButtonNormalBg;
				}
				set
				{
					this.m_owner.m_autoEquipButtonNormalBg = value;
				}
			}

			// Token: 0x17003233 RID: 12851
			// (get) Token: 0x06010520 RID: 66848 RVA: 0x00444144 File Offset: 0x00442344
			// (set) Token: 0x06010521 RID: 66849 RVA: 0x00444154 File Offset: 0x00442354
			public Button m_fastRemoveButton
			{
				get
				{
					return this.m_owner.m_fastRemoveButton;
				}
				set
				{
					this.m_owner.m_fastRemoveButton = value;
				}
			}

			// Token: 0x17003234 RID: 12852
			// (get) Token: 0x06010522 RID: 66850 RVA: 0x00444164 File Offset: 0x00442364
			// (set) Token: 0x06010523 RID: 66851 RVA: 0x00444174 File Offset: 0x00442374
			public GameObject m_equipItemDescGo
			{
				get
				{
					return this.m_owner.m_equipItemDescGo;
				}
				set
				{
					this.m_owner.m_equipItemDescGo = value;
				}
			}

			// Token: 0x17003235 RID: 12853
			// (get) Token: 0x06010524 RID: 66852 RVA: 0x00444184 File Offset: 0x00442384
			// (set) Token: 0x06010525 RID: 66853 RVA: 0x00444194 File Offset: 0x00442394
			public Text m_equipItemDescTitleText
			{
				get
				{
					return this.m_owner.m_equipItemDescTitleText;
				}
				set
				{
					this.m_owner.m_equipItemDescTitleText = value;
				}
			}

			// Token: 0x17003236 RID: 12854
			// (get) Token: 0x06010526 RID: 66854 RVA: 0x004441A4 File Offset: 0x004423A4
			// (set) Token: 0x06010527 RID: 66855 RVA: 0x004441B4 File Offset: 0x004423B4
			public Text m_equipItemDescLvText
			{
				get
				{
					return this.m_owner.m_equipItemDescLvText;
				}
				set
				{
					this.m_owner.m_equipItemDescLvText = value;
				}
			}

			// Token: 0x17003237 RID: 12855
			// (get) Token: 0x06010528 RID: 66856 RVA: 0x004441C4 File Offset: 0x004423C4
			// (set) Token: 0x06010529 RID: 66857 RVA: 0x004441D4 File Offset: 0x004423D4
			public Text m_equipItemDescExpText
			{
				get
				{
					return this.m_owner.m_equipItemDescExpText;
				}
				set
				{
					this.m_owner.m_equipItemDescExpText = value;
				}
			}

			// Token: 0x17003238 RID: 12856
			// (get) Token: 0x0601052A RID: 66858 RVA: 0x004441E4 File Offset: 0x004423E4
			// (set) Token: 0x0601052B RID: 66859 RVA: 0x004441F4 File Offset: 0x004423F4
			public Image m_equipItemDescIconImage
			{
				get
				{
					return this.m_owner.m_equipItemDescIconImage;
				}
				set
				{
					this.m_owner.m_equipItemDescIconImage = value;
				}
			}

			// Token: 0x17003239 RID: 12857
			// (get) Token: 0x0601052C RID: 66860 RVA: 0x00444204 File Offset: 0x00442404
			// (set) Token: 0x0601052D RID: 66861 RVA: 0x00444214 File Offset: 0x00442414
			public Image m_equipItemDescIconBg
			{
				get
				{
					return this.m_owner.m_equipItemDescIconBg;
				}
				set
				{
					this.m_owner.m_equipItemDescIconBg = value;
				}
			}

			// Token: 0x1700323A RID: 12858
			// (get) Token: 0x0601052E RID: 66862 RVA: 0x00444224 File Offset: 0x00442424
			// (set) Token: 0x0601052F RID: 66863 RVA: 0x00444234 File Offset: 0x00442434
			public GameObject m_equipItemDescSSREffect
			{
				get
				{
					return this.m_owner.m_equipItemDescSSREffect;
				}
				set
				{
					this.m_owner.m_equipItemDescSSREffect = value;
				}
			}

			// Token: 0x1700323B RID: 12859
			// (get) Token: 0x06010530 RID: 66864 RVA: 0x00444244 File Offset: 0x00442444
			// (set) Token: 0x06010531 RID: 66865 RVA: 0x00444254 File Offset: 0x00442454
			public Image m_equipItemDescProgressImage
			{
				get
				{
					return this.m_owner.m_equipItemDescProgressImage;
				}
				set
				{
					this.m_owner.m_equipItemDescProgressImage = value;
				}
			}

			// Token: 0x1700323C RID: 12860
			// (get) Token: 0x06010532 RID: 66866 RVA: 0x00444264 File Offset: 0x00442464
			// (set) Token: 0x06010533 RID: 66867 RVA: 0x00444274 File Offset: 0x00442474
			public GameObject m_equipItemDescStarGroup
			{
				get
				{
					return this.m_owner.m_equipItemDescStarGroup;
				}
				set
				{
					this.m_owner.m_equipItemDescStarGroup = value;
				}
			}

			// Token: 0x1700323D RID: 12861
			// (get) Token: 0x06010534 RID: 66868 RVA: 0x00444284 File Offset: 0x00442484
			// (set) Token: 0x06010535 RID: 66869 RVA: 0x00444294 File Offset: 0x00442494
			public GameObject m_equipItemDescEquipLimitContent
			{
				get
				{
					return this.m_owner.m_equipItemDescEquipLimitContent;
				}
				set
				{
					this.m_owner.m_equipItemDescEquipLimitContent = value;
				}
			}

			// Token: 0x1700323E RID: 12862
			// (get) Token: 0x06010536 RID: 66870 RVA: 0x004442A4 File Offset: 0x004424A4
			// (set) Token: 0x06010537 RID: 66871 RVA: 0x004442B4 File Offset: 0x004424B4
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

			// Token: 0x1700323F RID: 12863
			// (get) Token: 0x06010538 RID: 66872 RVA: 0x004442C4 File Offset: 0x004424C4
			// (set) Token: 0x06010539 RID: 66873 RVA: 0x004442D4 File Offset: 0x004424D4
			public GameObject m_equipItemDescPropContent
			{
				get
				{
					return this.m_owner.m_equipItemDescPropContent;
				}
				set
				{
					this.m_owner.m_equipItemDescPropContent = value;
				}
			}

			// Token: 0x17003240 RID: 12864
			// (get) Token: 0x0601053A RID: 66874 RVA: 0x004442E4 File Offset: 0x004424E4
			// (set) Token: 0x0601053B RID: 66875 RVA: 0x004442F4 File Offset: 0x004424F4
			public GameObject m_equipItemDescPropATGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropATGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropATGo = value;
				}
			}

			// Token: 0x17003241 RID: 12865
			// (get) Token: 0x0601053C RID: 66876 RVA: 0x00444304 File Offset: 0x00442504
			// (set) Token: 0x0601053D RID: 66877 RVA: 0x00444314 File Offset: 0x00442514
			public Text m_equipItemDescPropATValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropATValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropATValueText = value;
				}
			}

			// Token: 0x17003242 RID: 12866
			// (get) Token: 0x0601053E RID: 66878 RVA: 0x00444324 File Offset: 0x00442524
			// (set) Token: 0x0601053F RID: 66879 RVA: 0x00444334 File Offset: 0x00442534
			public GameObject m_equipItemDescPropDFGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropDFGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropDFGo = value;
				}
			}

			// Token: 0x17003243 RID: 12867
			// (get) Token: 0x06010540 RID: 66880 RVA: 0x00444344 File Offset: 0x00442544
			// (set) Token: 0x06010541 RID: 66881 RVA: 0x00444354 File Offset: 0x00442554
			public Text m_equipItemDescPropDFValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropDFValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropDFValueText = value;
				}
			}

			// Token: 0x17003244 RID: 12868
			// (get) Token: 0x06010542 RID: 66882 RVA: 0x00444364 File Offset: 0x00442564
			// (set) Token: 0x06010543 RID: 66883 RVA: 0x00444374 File Offset: 0x00442574
			public GameObject m_equipItemDescPropHPGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropHPGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropHPGo = value;
				}
			}

			// Token: 0x17003245 RID: 12869
			// (get) Token: 0x06010544 RID: 66884 RVA: 0x00444384 File Offset: 0x00442584
			// (set) Token: 0x06010545 RID: 66885 RVA: 0x00444394 File Offset: 0x00442594
			public Text m_equipItemDescPropHPValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropHPValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropHPValueText = value;
				}
			}

			// Token: 0x17003246 RID: 12870
			// (get) Token: 0x06010546 RID: 66886 RVA: 0x004443A4 File Offset: 0x004425A4
			// (set) Token: 0x06010547 RID: 66887 RVA: 0x004443B4 File Offset: 0x004425B4
			public GameObject m_equipItemDescPropMagiccGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropMagiccGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropMagiccGo = value;
				}
			}

			// Token: 0x17003247 RID: 12871
			// (get) Token: 0x06010548 RID: 66888 RVA: 0x004443C4 File Offset: 0x004425C4
			// (set) Token: 0x06010549 RID: 66889 RVA: 0x004443D4 File Offset: 0x004425D4
			public Text m_equipItemDescPropMagicValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropMagicValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropMagicValueText = value;
				}
			}

			// Token: 0x17003248 RID: 12872
			// (get) Token: 0x0601054A RID: 66890 RVA: 0x004443E4 File Offset: 0x004425E4
			// (set) Token: 0x0601054B RID: 66891 RVA: 0x004443F4 File Offset: 0x004425F4
			public GameObject m_equipItemDescPropMagicDFGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropMagicDFGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropMagicDFGo = value;
				}
			}

			// Token: 0x17003249 RID: 12873
			// (get) Token: 0x0601054C RID: 66892 RVA: 0x00444404 File Offset: 0x00442604
			// (set) Token: 0x0601054D RID: 66893 RVA: 0x00444414 File Offset: 0x00442614
			public Text m_equipItemDescPropMagicDFValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropMagicDFValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropMagicDFValueText = value;
				}
			}

			// Token: 0x1700324A RID: 12874
			// (get) Token: 0x0601054E RID: 66894 RVA: 0x00444424 File Offset: 0x00442624
			// (set) Token: 0x0601054F RID: 66895 RVA: 0x00444434 File Offset: 0x00442634
			public GameObject m_equipItemDescPropDexGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropDexGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropDexGo = value;
				}
			}

			// Token: 0x1700324B RID: 12875
			// (get) Token: 0x06010550 RID: 66896 RVA: 0x00444444 File Offset: 0x00442644
			// (set) Token: 0x06010551 RID: 66897 RVA: 0x00444454 File Offset: 0x00442654
			public Text m_equipItemDescPropDexValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropDexValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropDexValueText = value;
				}
			}

			// Token: 0x1700324C RID: 12876
			// (get) Token: 0x06010552 RID: 66898 RVA: 0x00444464 File Offset: 0x00442664
			// (set) Token: 0x06010553 RID: 66899 RVA: 0x00444474 File Offset: 0x00442674
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

			// Token: 0x1700324D RID: 12877
			// (get) Token: 0x06010554 RID: 66900 RVA: 0x00444484 File Offset: 0x00442684
			// (set) Token: 0x06010555 RID: 66901 RVA: 0x00444494 File Offset: 0x00442694
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

			// Token: 0x1700324E RID: 12878
			// (get) Token: 0x06010556 RID: 66902 RVA: 0x004444A4 File Offset: 0x004426A4
			// (set) Token: 0x06010557 RID: 66903 RVA: 0x004444B4 File Offset: 0x004426B4
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

			// Token: 0x1700324F RID: 12879
			// (get) Token: 0x06010558 RID: 66904 RVA: 0x004444C4 File Offset: 0x004426C4
			// (set) Token: 0x06010559 RID: 66905 RVA: 0x004444D4 File Offset: 0x004426D4
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

			// Token: 0x17003250 RID: 12880
			// (get) Token: 0x0601055A RID: 66906 RVA: 0x004444E4 File Offset: 0x004426E4
			// (set) Token: 0x0601055B RID: 66907 RVA: 0x004444F4 File Offset: 0x004426F4
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

			// Token: 0x17003251 RID: 12881
			// (get) Token: 0x0601055C RID: 66908 RVA: 0x00444504 File Offset: 0x00442704
			// (set) Token: 0x0601055D RID: 66909 RVA: 0x00444514 File Offset: 0x00442714
			public InputField m_enchantmentValueInputField1
			{
				get
				{
					return this.m_owner.m_enchantmentValueInputField1;
				}
				set
				{
					this.m_owner.m_enchantmentValueInputField1 = value;
				}
			}

			// Token: 0x17003252 RID: 12882
			// (get) Token: 0x0601055E RID: 66910 RVA: 0x00444524 File Offset: 0x00442724
			// (set) Token: 0x0601055F RID: 66911 RVA: 0x00444534 File Offset: 0x00442734
			public InputField m_enchantmentValueInputField2
			{
				get
				{
					return this.m_owner.m_enchantmentValueInputField2;
				}
				set
				{
					this.m_owner.m_enchantmentValueInputField2 = value;
				}
			}

			// Token: 0x17003253 RID: 12883
			// (get) Token: 0x06010560 RID: 66912 RVA: 0x00444544 File Offset: 0x00442744
			// (set) Token: 0x06010561 RID: 66913 RVA: 0x00444554 File Offset: 0x00442754
			public InputField m_enchantmentValueInputField3
			{
				get
				{
					return this.m_owner.m_enchantmentValueInputField3;
				}
				set
				{
					this.m_owner.m_enchantmentValueInputField3 = value;
				}
			}

			// Token: 0x17003254 RID: 12884
			// (get) Token: 0x06010562 RID: 66914 RVA: 0x00444564 File Offset: 0x00442764
			// (set) Token: 0x06010563 RID: 66915 RVA: 0x00444574 File Offset: 0x00442774
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

			// Token: 0x17003255 RID: 12885
			// (get) Token: 0x06010564 RID: 66916 RVA: 0x00444584 File Offset: 0x00442784
			// (set) Token: 0x06010565 RID: 66917 RVA: 0x00444594 File Offset: 0x00442794
			public ConfigDataPropertyModifyInfo[] m_enchantmentValueTypes
			{
				get
				{
					return this.m_owner.m_enchantmentValueTypes;
				}
				set
				{
					this.m_owner.m_enchantmentValueTypes = value;
				}
			}

			// Token: 0x17003256 RID: 12886
			// (get) Token: 0x06010566 RID: 66918 RVA: 0x004445A4 File Offset: 0x004427A4
			// (set) Token: 0x06010567 RID: 66919 RVA: 0x004445B4 File Offset: 0x004427B4
			public EquipmentBagItem m_slectedEquipment
			{
				get
				{
					return this.m_owner.m_slectedEquipment;
				}
				set
				{
					this.m_owner.m_slectedEquipment = value;
				}
			}

			// Token: 0x17003257 RID: 12887
			// (get) Token: 0x06010568 RID: 66920 RVA: 0x004445C4 File Offset: 0x004427C4
			// (set) Token: 0x06010569 RID: 66921 RVA: 0x004445D4 File Offset: 0x004427D4
			public GameObject m_equipItemDescSkillContent
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillContent;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillContent = value;
				}
			}

			// Token: 0x17003258 RID: 12888
			// (get) Token: 0x0601056A RID: 66922 RVA: 0x004445E4 File Offset: 0x004427E4
			// (set) Token: 0x0601056B RID: 66923 RVA: 0x004445F4 File Offset: 0x004427F4
			public CommonUIStateController m_equipItemDescSkillContentStateCtrl
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillContentStateCtrl;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillContentStateCtrl = value;
				}
			}

			// Token: 0x17003259 RID: 12889
			// (get) Token: 0x0601056C RID: 66924 RVA: 0x00444604 File Offset: 0x00442804
			// (set) Token: 0x0601056D RID: 66925 RVA: 0x00444614 File Offset: 0x00442814
			public Text m_equipItemDescSkillNameText
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillNameText;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillNameText = value;
				}
			}

			// Token: 0x1700325A RID: 12890
			// (get) Token: 0x0601056E RID: 66926 RVA: 0x00444624 File Offset: 0x00442824
			// (set) Token: 0x0601056F RID: 66927 RVA: 0x00444634 File Offset: 0x00442834
			public Text m_equipItemDescSkillLvText
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillLvText;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillLvText = value;
				}
			}

			// Token: 0x1700325B RID: 12891
			// (get) Token: 0x06010570 RID: 66928 RVA: 0x00444644 File Offset: 0x00442844
			// (set) Token: 0x06010571 RID: 66929 RVA: 0x00444654 File Offset: 0x00442854
			public Text m_equipItemDescUnlockCoditionText
			{
				get
				{
					return this.m_owner.m_equipItemDescUnlockCoditionText;
				}
				set
				{
					this.m_owner.m_equipItemDescUnlockCoditionText = value;
				}
			}

			// Token: 0x1700325C RID: 12892
			// (get) Token: 0x06010572 RID: 66930 RVA: 0x00444664 File Offset: 0x00442864
			// (set) Token: 0x06010573 RID: 66931 RVA: 0x00444674 File Offset: 0x00442874
			public Text m_equipItemDescSkillOwnerText
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillOwnerText;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillOwnerText = value;
				}
			}

			// Token: 0x1700325D RID: 12893
			// (get) Token: 0x06010574 RID: 66932 RVA: 0x00444684 File Offset: 0x00442884
			// (set) Token: 0x06010575 RID: 66933 RVA: 0x00444694 File Offset: 0x00442894
			public GameObject m_equipItemDescSkillOwnerBGImage
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillOwnerBGImage;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillOwnerBGImage = value;
				}
			}

			// Token: 0x1700325E RID: 12894
			// (get) Token: 0x06010576 RID: 66934 RVA: 0x004446A4 File Offset: 0x004428A4
			// (set) Token: 0x06010577 RID: 66935 RVA: 0x004446B4 File Offset: 0x004428B4
			public Text m_equipItemDescSkillDescText
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillDescText;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillDescText = value;
				}
			}

			// Token: 0x1700325F RID: 12895
			// (get) Token: 0x06010578 RID: 66936 RVA: 0x004446C4 File Offset: 0x004428C4
			// (set) Token: 0x06010579 RID: 66937 RVA: 0x004446D4 File Offset: 0x004428D4
			public GameObject m_equipItemDescNotEquipSkillTip
			{
				get
				{
					return this.m_owner.m_equipItemDescNotEquipSkillTip;
				}
				set
				{
					this.m_owner.m_equipItemDescNotEquipSkillTip = value;
				}
			}

			// Token: 0x17003260 RID: 12896
			// (get) Token: 0x0601057A RID: 66938 RVA: 0x004446E4 File Offset: 0x004428E4
			// (set) Token: 0x0601057B RID: 66939 RVA: 0x004446F4 File Offset: 0x004428F4
			public Button m_equipItemDescLockButton
			{
				get
				{
					return this.m_owner.m_equipItemDescLockButton;
				}
				set
				{
					this.m_owner.m_equipItemDescLockButton = value;
				}
			}

			// Token: 0x17003261 RID: 12897
			// (get) Token: 0x0601057C RID: 66940 RVA: 0x00444704 File Offset: 0x00442904
			// (set) Token: 0x0601057D RID: 66941 RVA: 0x00444714 File Offset: 0x00442914
			public Button m_equipItemDescForgeButton
			{
				get
				{
					return this.m_owner.m_equipItemDescForgeButton;
				}
				set
				{
					this.m_owner.m_equipItemDescForgeButton = value;
				}
			}

			// Token: 0x17003262 RID: 12898
			// (get) Token: 0x0601057E RID: 66942 RVA: 0x00444724 File Offset: 0x00442924
			// (set) Token: 0x0601057F RID: 66943 RVA: 0x00444734 File Offset: 0x00442934
			public Button m_equipItemDescExchangeButton
			{
				get
				{
					return this.m_owner.m_equipItemDescExchangeButton;
				}
				set
				{
					this.m_owner.m_equipItemDescExchangeButton = value;
				}
			}

			// Token: 0x17003263 RID: 12899
			// (get) Token: 0x06010580 RID: 66944 RVA: 0x00444744 File Offset: 0x00442944
			// (set) Token: 0x06010581 RID: 66945 RVA: 0x00444754 File Offset: 0x00442954
			public CommonUIStateController m_resonanceInfoPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanelStateCtrl = value;
				}
			}

			// Token: 0x17003264 RID: 12900
			// (get) Token: 0x06010582 RID: 66946 RVA: 0x00444764 File Offset: 0x00442964
			// (set) Token: 0x06010583 RID: 66947 RVA: 0x00444774 File Offset: 0x00442974
			public Button m_resonanceInfoPanelBgButton
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanelBgButton;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanelBgButton = value;
				}
			}

			// Token: 0x17003265 RID: 12901
			// (get) Token: 0x06010584 RID: 66948 RVA: 0x00444784 File Offset: 0x00442984
			// (set) Token: 0x06010585 RID: 66949 RVA: 0x00444794 File Offset: 0x00442994
			public CommonUIStateController m_resonanceInfoPanel2SuitStateCtrl
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanel2SuitStateCtrl;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanel2SuitStateCtrl = value;
				}
			}

			// Token: 0x17003266 RID: 12902
			// (get) Token: 0x06010586 RID: 66950 RVA: 0x004447A4 File Offset: 0x004429A4
			// (set) Token: 0x06010587 RID: 66951 RVA: 0x004447B4 File Offset: 0x004429B4
			public Text m_resonanceInfoPanel2SuitInfoText
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanel2SuitInfoText;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanel2SuitInfoText = value;
				}
			}

			// Token: 0x17003267 RID: 12903
			// (get) Token: 0x06010588 RID: 66952 RVA: 0x004447C4 File Offset: 0x004429C4
			// (set) Token: 0x06010589 RID: 66953 RVA: 0x004447D4 File Offset: 0x004429D4
			public CommonUIStateController m_resonanceInfoPanel4SuitStateCtrl
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanel4SuitStateCtrl;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanel4SuitStateCtrl = value;
				}
			}

			// Token: 0x17003268 RID: 12904
			// (get) Token: 0x0601058A RID: 66954 RVA: 0x004447E4 File Offset: 0x004429E4
			// (set) Token: 0x0601058B RID: 66955 RVA: 0x004447F4 File Offset: 0x004429F4
			public Text m_resonanceInfoPanel4SuitInfoText
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanel4SuitInfoText;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanel4SuitInfoText = value;
				}
			}

			// Token: 0x17003269 RID: 12905
			// (get) Token: 0x0601058C RID: 66956 RVA: 0x00444804 File Offset: 0x00442A04
			// (set) Token: 0x0601058D RID: 66957 RVA: 0x00444814 File Offset: 0x00442A14
			public Text m_resonanceInfoPanelNameText
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanelNameText;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanelNameText = value;
				}
			}

			// Token: 0x1700326A RID: 12906
			// (get) Token: 0x0601058E RID: 66958 RVA: 0x00444824 File Offset: 0x00442A24
			// (set) Token: 0x0601058F RID: 66959 RVA: 0x00444834 File Offset: 0x00442A34
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

			// Token: 0x1700326B RID: 12907
			// (get) Token: 0x06010590 RID: 66960 RVA: 0x00444844 File Offset: 0x00442A44
			// (set) Token: 0x06010591 RID: 66961 RVA: 0x00444854 File Offset: 0x00442A54
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

			// Token: 0x1700326C RID: 12908
			// (get) Token: 0x06010592 RID: 66962 RVA: 0x00444864 File Offset: 0x00442A64
			// (set) Token: 0x06010593 RID: 66963 RVA: 0x00444874 File Offset: 0x00442A74
			public ulong m_equipmentInstanceId
			{
				get
				{
					return this.m_owner.m_equipmentInstanceId;
				}
				set
				{
					this.m_owner.m_equipmentInstanceId = value;
				}
			}

			// Token: 0x1700326D RID: 12909
			// (get) Token: 0x06010594 RID: 66964 RVA: 0x00444884 File Offset: 0x00442A84
			// (set) Token: 0x06010595 RID: 66965 RVA: 0x00444894 File Offset: 0x00442A94
			public List<GameObject> m_equipmentGos
			{
				get
				{
					return this.m_owner.m_equipmentGos;
				}
				set
				{
					this.m_owner.m_equipmentGos = value;
				}
			}

			// Token: 0x1700326E RID: 12910
			// (get) Token: 0x06010596 RID: 66966 RVA: 0x004448A4 File Offset: 0x00442AA4
			// (set) Token: 0x06010597 RID: 66967 RVA: 0x004448B4 File Offset: 0x00442AB4
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

			// Token: 0x1700326F RID: 12911
			// (get) Token: 0x06010598 RID: 66968 RVA: 0x004448C4 File Offset: 0x00442AC4
			// (set) Token: 0x06010599 RID: 66969 RVA: 0x004448D4 File Offset: 0x00442AD4
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

			// Token: 0x0601059A RID: 66970 RVA: 0x004448E4 File Offset: 0x00442AE4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601059B RID: 66971 RVA: 0x004448F4 File Offset: 0x00442AF4
			public void CreateEquipmentList()
			{
				this.m_owner.CreateEquipmentList();
			}

			// Token: 0x0601059C RID: 66972 RVA: 0x00444904 File Offset: 0x00442B04
			public void OnEquipmentIconClick(HeroEquipItemUIController ctrl)
			{
				this.m_owner.OnEquipmentIconClick(ctrl);
			}

			// Token: 0x0601059D RID: 66973 RVA: 0x00444914 File Offset: 0x00442B14
			public void OnEquipmentAddButtonClick(HeroEquipItemUIController ctrl)
			{
				this.m_owner.OnEquipmentAddButtonClick(ctrl);
			}

			// Token: 0x0601059E RID: 66974 RVA: 0x00444924 File Offset: 0x00442B24
			public bool HaveEquipmentInBag(HeroEquipItemUIController equipmentCtrl)
			{
				return this.m_owner.HaveEquipmentInBag(equipmentCtrl);
			}

			// Token: 0x0601059F RID: 66975 RVA: 0x00444934 File Offset: 0x00442B34
			public void OnRuneIconButtonClick(HeroEquipItemUIController ctrl)
			{
				this.m_owner.OnRuneIconButtonClick(ctrl);
			}

			// Token: 0x060105A0 RID: 66976 RVA: 0x00444944 File Offset: 0x00442B44
			public void SetResonanceInfoPanel(EquipmentBagItem equipment)
			{
				this.m_owner.SetResonanceInfoPanel(equipment);
			}

			// Token: 0x060105A1 RID: 66977 RVA: 0x00444954 File Offset: 0x00442B54
			public void CloseResonanceInfoPanel()
			{
				this.m_owner.CloseResonanceInfoPanel();
			}

			// Token: 0x060105A2 RID: 66978 RVA: 0x00444964 File Offset: 0x00442B64
			public void SetEquipmentItemDesc(HeroEquipItemUIController ctrl)
			{
				this.m_owner.SetEquipmentItemDesc(ctrl);
			}

			// Token: 0x060105A3 RID: 66979 RVA: 0x00444974 File Offset: 0x00442B74
			public void SetPropItems(PropertyModifyType type, int value, int addValue, int level)
			{
				this.m_owner.SetPropItems(type, value, addValue, level);
			}

			// Token: 0x060105A4 RID: 66980 RVA: 0x00444988 File Offset: 0x00442B88
			public void OnForgeButtonClick()
			{
				this.m_owner.OnForgeButtonClick();
			}

			// Token: 0x060105A5 RID: 66981 RVA: 0x00444998 File Offset: 0x00442B98
			public void OnEnchantmentButtonClick()
			{
				this.m_owner.OnEnchantmentButtonClick();
			}

			// Token: 0x060105A6 RID: 66982 RVA: 0x004449A8 File Offset: 0x00442BA8
			public void OnExchangeButtonClick()
			{
				this.m_owner.OnExchangeButtonClick();
			}

			// Token: 0x060105A7 RID: 66983 RVA: 0x004449B8 File Offset: 0x00442BB8
			public void OnAutoEquipButtonClick()
			{
				this.m_owner.OnAutoEquipButtonClick();
			}

			// Token: 0x060105A8 RID: 66984 RVA: 0x004449C8 File Offset: 0x00442BC8
			public void OnFastRemoveButtonClick()
			{
				this.m_owner.OnFastRemoveButtonClick();
			}

			// Token: 0x060105A9 RID: 66985 RVA: 0x004449D8 File Offset: 0x00442BD8
			public IEnumerator DisableAutoEquipButton()
			{
				return this.m_owner.DisableAutoEquipButton();
			}

			// Token: 0x060105AA RID: 66986 RVA: 0x004449E8 File Offset: 0x00442BE8
			public void CloseEquipemntItemDescGo()
			{
				this.m_owner.CloseEquipemntItemDescGo();
			}

			// Token: 0x060105AB RID: 66987 RVA: 0x004449F8 File Offset: 0x00442BF8
			public void OnEquipemntLockButtonClick()
			{
				this.m_owner.OnEquipemntLockButtonClick();
			}

			// Token: 0x040097FF RID: 38911
			private HeroDetailEquipmentUIController m_owner;
		}
	}
}
