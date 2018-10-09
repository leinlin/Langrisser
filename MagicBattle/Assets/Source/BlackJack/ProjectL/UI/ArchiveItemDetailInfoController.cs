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
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009DD RID: 2525
	[HotFix]
	public class ArchiveItemDetailInfoController : UIControllerBase
	{
		// Token: 0x06009519 RID: 38169 RVA: 0x002ACA8C File Offset: 0x002AAC8C
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
			this.ClosePropDisplay();
		}

		// Token: 0x0600951A RID: 38170 RVA: 0x002ACB24 File Offset: 0x002AAD24
		public void SetData(EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDataEquipmentInfoWrap_hotfix != null)
			{
				this.m_SetDataEquipmentInfoWrap_hotfix.call(new object[]
				{
					this,
					equipmentInfoWrap
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_equipmentInfoWrap = equipmentInfoWrap;
			this.Refresh();
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x002ACBA4 File Offset: 0x002AADA4
		public void Refresh()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Refresh_hotfix != null)
			{
				this.m_Refresh_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentInfo equipmentInfo = this.m_equipmentInfoWrap.equipmentInfo;
			this.m_nameText.text = equipmentInfo.Name;
			this.m_itemIamge.sprite = AssetUtility.Instance.GetSprite(equipmentInfo.Icon);
			CommonUIStateController component = this.m_itemIamge.GetComponent<CommonUIStateController>();
			if (this.m_equipmentInfoWrap.isUnlocked)
			{
				component.SetToUIState("Normal", false, true);
			}
			else
			{
				component.SetToUIState("Dark", false, true);
			}
			for (int i = 0; i < this.m_equipLimitContent.transform.childCount; i++)
			{
				this.m_equipLimitContent.transform.GetChild(i).gameObject.SetActive(false);
			}
			if (equipmentInfo.EquipCoditionDesc != string.Empty)
			{
				this.m_equipLimitGroupAnimation.SetToUIState("Unlimit", false, true);
				this.m_descEquipUnlimitText.text = equipmentInfo.EquipCoditionDesc;
			}
			else
			{
				List<int> armyIds = equipmentInfo.ArmyIds;
				if (armyIds.Count == 0)
				{
					this.m_equipLimitGroupAnimation.SetToUIState("Unlimit", false, true);
					this.m_descEquipUnlimitText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AllJobCanUse);
				}
				else if (armyIds[0] == -1)
				{
					this.m_equipLimitGroupAnimation.SetToUIState("CanNotUse", false, true);
				}
				else
				{
					this.m_equipLimitGroupAnimation.SetToUIState("EquipLimit", false, true);
					for (int j = 0; j < armyIds.Count; j++)
					{
						ConfigDataArmyInfo configDataArmyInfo = this.m_configDataLoader.GetConfigDataArmyInfo(armyIds[j]);
						if (j < this.m_equipLimitContent.transform.childCount)
						{
							Transform child = this.m_equipLimitContent.transform.GetChild(j);
							child.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
							child.gameObject.SetActive(true);
						}
						else
						{
							GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_equipLimitContent.transform.GetChild(0).gameObject, this.m_equipLimitContent.transform, true);
							gameObject.transform.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
							gameObject.SetActive(true);
						}
					}
				}
			}
			this.m_equipmentExplain.text = equipmentInfo.Desc;
			this.ClosePropDisplay();
			this.SetEquipmentPropItem(equipmentInfo.Property1_ID, equipmentInfo.Property1_Value);
			this.SetEquipmentPropItem(equipmentInfo.Property2_ID, equipmentInfo.Property2_Value);
			if (equipmentInfo.SkillIds.Count == 0)
			{
				this.m_skillAnimation.SetToUIState("NoSkill", false, true);
			}
			else
			{
				this.m_skillAnimation.SetToUIState("HaveSkill", false, true);
				string text = null;
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(UIUtility.GetSkillIdFromEquipment(equipmentInfo, 1, ref text));
				if (configDataSkillInfo != null)
				{
					this.m_skillContentAnimation.SetToUIState("Grey", false, true);
					if (equipmentInfo.SkillLevels.Count > 0)
					{
						if (equipmentInfo.SkillLevels[equipmentInfo.SkillLevels.Count - 1] > 1)
						{
							this.m_skillUnlockConditionText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_EnchantToLevel), equipmentInfo.SkillLevels[0]);
						}
						else
						{
							this.m_skillContentAnimation.SetToUIState("Normal", false, true);
						}
					}
					this.m_skillNameText.text = configDataSkillInfo.Name;
					this.m_skillDescText.text = configDataSkillInfo.Desc;
					ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(equipmentInfo.SkillHero);
					this.m_skillBelongText.gameObject.SetActive(configDataHeroInfo != null);
					this.m_skillBelongBGText.SetActive(configDataHeroInfo != null);
					if (configDataHeroInfo != null)
					{
						this.m_skillBelongText.text = configDataHeroInfo.Name + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Equipment_SkillOwner);
					}
				}
			}
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x002AD004 File Offset: 0x002AB204
		private void ClosePropDisplay()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClosePropDisplay_hotfix != null)
			{
				this.m_ClosePropDisplay_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_HPGameObject.SetActive(false);
			this.m_ATGameObject.SetActive(false);
			this.m_DFGameObject.SetActive(false);
			this.m_MagicDFGameObject.SetActive(false);
			this.m_MagicGameObject.SetActive(false);
			this.m_DexGameObject.SetActive(false);
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x002AD0AC File Offset: 0x002AB2AC
		private void SetEquipmentPropItem(PropertyModifyType type, int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentPropItemPropertyModifyTypeInt32_hotfix != null)
			{
				this.m_SetEquipmentPropItemPropertyModifyTypeInt32_hotfix.call(new object[]
				{
					this,
					type,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (type)
			{
			case PropertyModifyType.PropertyModifyType_Hero1_HPAdd:
				this.m_HPGameObject.SetActive(true);
				this.m_HPText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_ATAdd:
				this.m_ATGameObject.SetActive(true);
				this.m_ATText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DFAdd:
				this.m_DFGameObject.SetActive(true);
				this.m_DFText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicAdd:
				this.m_MagicGameObject.SetActive(true);
				this.m_MagicText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicDFAdd:
				this.m_MagicDFGameObject.SetActive(true);
				this.m_MagicDFText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DEXAdd:
				this.m_DexGameObject.SetActive(true);
				this.m_DexText.text = value.ToString();
				break;
			}
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x0600951E RID: 38174 RVA: 0x002AD248 File Offset: 0x002AB448
		// (set) Token: 0x0600951F RID: 38175 RVA: 0x002AD268 File Offset: 0x002AB468
		[DoNotToLua]
		public new ArchiveItemDetailInfoController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArchiveItemDetailInfoController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009520 RID: 38176 RVA: 0x002AD274 File Offset: 0x002AB474
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009521 RID: 38177 RVA: 0x002AD280 File Offset: 0x002AB480
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x002AD288 File Offset: 0x002AB488
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009523 RID: 38179 RVA: 0x002AD290 File Offset: 0x002AB490
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009524 RID: 38180 RVA: 0x002AD2A4 File Offset: 0x002AB4A4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009525 RID: 38181 RVA: 0x002AD2AC File Offset: 0x002AB4AC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x002AD2B8 File Offset: 0x002AB4B8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x002AD2C4 File Offset: 0x002AB4C4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x002AD2D0 File Offset: 0x002AB4D0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009529 RID: 38185 RVA: 0x002AD2DC File Offset: 0x002AB4DC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600952A RID: 38186 RVA: 0x002AD2E8 File Offset: 0x002AB4E8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x002AD2F4 File Offset: 0x002AB4F4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x002AD300 File Offset: 0x002AB500
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600952D RID: 38189 RVA: 0x002AD30C File Offset: 0x002AB50C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600952E RID: 38190 RVA: 0x002AD318 File Offset: 0x002AB518
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600952F RID: 38191 RVA: 0x002AD320 File Offset: 0x002AB520
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
					this.m_SetDataEquipmentInfoWrap_hotfix = (luaObj.RawGet("SetData") as LuaFunction);
					this.m_Refresh_hotfix = (luaObj.RawGet("Refresh") as LuaFunction);
					this.m_ClosePropDisplay_hotfix = (luaObj.RawGet("ClosePropDisplay") as LuaFunction);
					this.m_SetEquipmentPropItemPropertyModifyTypeInt32_hotfix = (luaObj.RawGet("SetEquipmentPropItem") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009530 RID: 38192 RVA: 0x002AD450 File Offset: 0x002AB650
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArchiveItemDetailInfoController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400672B RID: 26411
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400672C RID: 26412
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_itemIamge;

		// Token: 0x0400672D RID: 26413
		[AutoBind("./EquipInfo/EquipGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_equipLimitGroupAnimation;

		// Token: 0x0400672E RID: 26414
		[AutoBind("./EquipInfo/EquipGroup/EquipLimitContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipLimitContent;

		// Token: 0x0400672F RID: 26415
		[AutoBind("./EquipInfo/EquipGroup/EquipUnlimitText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descEquipUnlimitText;

		// Token: 0x04006730 RID: 26416
		[AutoBind("./EquipInfo/ExplainFrontToggle/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipmentExplain;

		// Token: 0x04006731 RID: 26417
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/HP", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_HPGameObject;

		// Token: 0x04006732 RID: 26418
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_HPText;

		// Token: 0x04006733 RID: 26419
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/AT", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_ATGameObject;

		// Token: 0x04006734 RID: 26420
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_ATText;

		// Token: 0x04006735 RID: 26421
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/DF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_DFGameObject;

		// Token: 0x04006736 RID: 26422
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_DFText;

		// Token: 0x04006737 RID: 26423
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/MagicDF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_MagicDFGameObject;

		// Token: 0x04006738 RID: 26424
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_MagicDFText;

		// Token: 0x04006739 RID: 26425
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_MagicGameObject;

		// Token: 0x0400673A RID: 26426
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/Magic/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_MagicText;

		// Token: 0x0400673B RID: 26427
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/Dex", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_DexGameObject;

		// Token: 0x0400673C RID: 26428
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/PropGroup/PropContent/Dex/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_DexText;

		// Token: 0x0400673D RID: 26429
		[AutoBind("./EquipInfo/PropertyFrontToggle", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillAnimation;

		// Token: 0x0400673E RID: 26430
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillContentAnimation;

		// Token: 0x0400673F RID: 26431
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/SkillContent/Owner", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillBelongText;

		// Token: 0x04006740 RID: 26432
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/SkillContent/BelongBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillBelongBGText;

		// Token: 0x04006741 RID: 26433
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/SkillContent/UnlockCoditionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillUnlockConditionText;

		// Token: 0x04006742 RID: 26434
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/SkillContent/DescScrollView/Mask/Content/Desc", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDescText;

		// Token: 0x04006743 RID: 26435
		[AutoBind("./EquipInfo/PropertyFrontToggle/Detail/SkillContent/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillNameText;

		// Token: 0x04006744 RID: 26436
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04006745 RID: 26437
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04006746 RID: 26438
		private EquipmentArchiveUIController.EquipmentInfoWrap m_equipmentInfoWrap;

		// Token: 0x04006747 RID: 26439
		[DoNotToLua]
		private ArchiveItemDetailInfoController.LuaExportHelper luaExportHelper;

		// Token: 0x04006748 RID: 26440
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006749 RID: 26441
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400674A RID: 26442
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400674B RID: 26443
		private LuaFunction m_SetDataEquipmentInfoWrap_hotfix;

		// Token: 0x0400674C RID: 26444
		private LuaFunction m_Refresh_hotfix;

		// Token: 0x0400674D RID: 26445
		private LuaFunction m_ClosePropDisplay_hotfix;

		// Token: 0x0400674E RID: 26446
		private LuaFunction m_SetEquipmentPropItemPropertyModifyTypeInt32_hotfix;

		// Token: 0x020009DE RID: 2526
		public new class LuaExportHelper
		{
			// Token: 0x06009531 RID: 38193 RVA: 0x002AD4B8 File Offset: 0x002AB6B8
			public LuaExportHelper(ArchiveItemDetailInfoController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009532 RID: 38194 RVA: 0x002AD4C8 File Offset: 0x002AB6C8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009533 RID: 38195 RVA: 0x002AD4D8 File Offset: 0x002AB6D8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009534 RID: 38196 RVA: 0x002AD4E8 File Offset: 0x002AB6E8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009535 RID: 38197 RVA: 0x002AD4F8 File Offset: 0x002AB6F8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009536 RID: 38198 RVA: 0x002AD510 File Offset: 0x002AB710
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009537 RID: 38199 RVA: 0x002AD520 File Offset: 0x002AB720
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009538 RID: 38200 RVA: 0x002AD530 File Offset: 0x002AB730
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009539 RID: 38201 RVA: 0x002AD540 File Offset: 0x002AB740
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600953A RID: 38202 RVA: 0x002AD550 File Offset: 0x002AB750
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600953B RID: 38203 RVA: 0x002AD560 File Offset: 0x002AB760
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600953C RID: 38204 RVA: 0x002AD570 File Offset: 0x002AB770
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600953D RID: 38205 RVA: 0x002AD580 File Offset: 0x002AB780
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600953E RID: 38206 RVA: 0x002AD590 File Offset: 0x002AB790
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600953F RID: 38207 RVA: 0x002AD5A0 File Offset: 0x002AB7A0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009540 RID: 38208 RVA: 0x002AD5B0 File Offset: 0x002AB7B0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17001EB5 RID: 7861
			// (get) Token: 0x06009541 RID: 38209 RVA: 0x002AD5C0 File Offset: 0x002AB7C0
			// (set) Token: 0x06009542 RID: 38210 RVA: 0x002AD5D0 File Offset: 0x002AB7D0
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x17001EB6 RID: 7862
			// (get) Token: 0x06009543 RID: 38211 RVA: 0x002AD5E0 File Offset: 0x002AB7E0
			// (set) Token: 0x06009544 RID: 38212 RVA: 0x002AD5F0 File Offset: 0x002AB7F0
			public Image m_itemIamge
			{
				get
				{
					return this.m_owner.m_itemIamge;
				}
				set
				{
					this.m_owner.m_itemIamge = value;
				}
			}

			// Token: 0x17001EB7 RID: 7863
			// (get) Token: 0x06009545 RID: 38213 RVA: 0x002AD600 File Offset: 0x002AB800
			// (set) Token: 0x06009546 RID: 38214 RVA: 0x002AD610 File Offset: 0x002AB810
			public CommonUIStateController m_equipLimitGroupAnimation
			{
				get
				{
					return this.m_owner.m_equipLimitGroupAnimation;
				}
				set
				{
					this.m_owner.m_equipLimitGroupAnimation = value;
				}
			}

			// Token: 0x17001EB8 RID: 7864
			// (get) Token: 0x06009547 RID: 38215 RVA: 0x002AD620 File Offset: 0x002AB820
			// (set) Token: 0x06009548 RID: 38216 RVA: 0x002AD630 File Offset: 0x002AB830
			public GameObject m_equipLimitContent
			{
				get
				{
					return this.m_owner.m_equipLimitContent;
				}
				set
				{
					this.m_owner.m_equipLimitContent = value;
				}
			}

			// Token: 0x17001EB9 RID: 7865
			// (get) Token: 0x06009549 RID: 38217 RVA: 0x002AD640 File Offset: 0x002AB840
			// (set) Token: 0x0600954A RID: 38218 RVA: 0x002AD650 File Offset: 0x002AB850
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

			// Token: 0x17001EBA RID: 7866
			// (get) Token: 0x0600954B RID: 38219 RVA: 0x002AD660 File Offset: 0x002AB860
			// (set) Token: 0x0600954C RID: 38220 RVA: 0x002AD670 File Offset: 0x002AB870
			public Text m_equipmentExplain
			{
				get
				{
					return this.m_owner.m_equipmentExplain;
				}
				set
				{
					this.m_owner.m_equipmentExplain = value;
				}
			}

			// Token: 0x17001EBB RID: 7867
			// (get) Token: 0x0600954D RID: 38221 RVA: 0x002AD680 File Offset: 0x002AB880
			// (set) Token: 0x0600954E RID: 38222 RVA: 0x002AD690 File Offset: 0x002AB890
			public GameObject m_HPGameObject
			{
				get
				{
					return this.m_owner.m_HPGameObject;
				}
				set
				{
					this.m_owner.m_HPGameObject = value;
				}
			}

			// Token: 0x17001EBC RID: 7868
			// (get) Token: 0x0600954F RID: 38223 RVA: 0x002AD6A0 File Offset: 0x002AB8A0
			// (set) Token: 0x06009550 RID: 38224 RVA: 0x002AD6B0 File Offset: 0x002AB8B0
			public Text m_HPText
			{
				get
				{
					return this.m_owner.m_HPText;
				}
				set
				{
					this.m_owner.m_HPText = value;
				}
			}

			// Token: 0x17001EBD RID: 7869
			// (get) Token: 0x06009551 RID: 38225 RVA: 0x002AD6C0 File Offset: 0x002AB8C0
			// (set) Token: 0x06009552 RID: 38226 RVA: 0x002AD6D0 File Offset: 0x002AB8D0
			public GameObject m_ATGameObject
			{
				get
				{
					return this.m_owner.m_ATGameObject;
				}
				set
				{
					this.m_owner.m_ATGameObject = value;
				}
			}

			// Token: 0x17001EBE RID: 7870
			// (get) Token: 0x06009553 RID: 38227 RVA: 0x002AD6E0 File Offset: 0x002AB8E0
			// (set) Token: 0x06009554 RID: 38228 RVA: 0x002AD6F0 File Offset: 0x002AB8F0
			public Text m_ATText
			{
				get
				{
					return this.m_owner.m_ATText;
				}
				set
				{
					this.m_owner.m_ATText = value;
				}
			}

			// Token: 0x17001EBF RID: 7871
			// (get) Token: 0x06009555 RID: 38229 RVA: 0x002AD700 File Offset: 0x002AB900
			// (set) Token: 0x06009556 RID: 38230 RVA: 0x002AD710 File Offset: 0x002AB910
			public GameObject m_DFGameObject
			{
				get
				{
					return this.m_owner.m_DFGameObject;
				}
				set
				{
					this.m_owner.m_DFGameObject = value;
				}
			}

			// Token: 0x17001EC0 RID: 7872
			// (get) Token: 0x06009557 RID: 38231 RVA: 0x002AD720 File Offset: 0x002AB920
			// (set) Token: 0x06009558 RID: 38232 RVA: 0x002AD730 File Offset: 0x002AB930
			public Text m_DFText
			{
				get
				{
					return this.m_owner.m_DFText;
				}
				set
				{
					this.m_owner.m_DFText = value;
				}
			}

			// Token: 0x17001EC1 RID: 7873
			// (get) Token: 0x06009559 RID: 38233 RVA: 0x002AD740 File Offset: 0x002AB940
			// (set) Token: 0x0600955A RID: 38234 RVA: 0x002AD750 File Offset: 0x002AB950
			public GameObject m_MagicDFGameObject
			{
				get
				{
					return this.m_owner.m_MagicDFGameObject;
				}
				set
				{
					this.m_owner.m_MagicDFGameObject = value;
				}
			}

			// Token: 0x17001EC2 RID: 7874
			// (get) Token: 0x0600955B RID: 38235 RVA: 0x002AD760 File Offset: 0x002AB960
			// (set) Token: 0x0600955C RID: 38236 RVA: 0x002AD770 File Offset: 0x002AB970
			public Text m_MagicDFText
			{
				get
				{
					return this.m_owner.m_MagicDFText;
				}
				set
				{
					this.m_owner.m_MagicDFText = value;
				}
			}

			// Token: 0x17001EC3 RID: 7875
			// (get) Token: 0x0600955D RID: 38237 RVA: 0x002AD780 File Offset: 0x002AB980
			// (set) Token: 0x0600955E RID: 38238 RVA: 0x002AD790 File Offset: 0x002AB990
			public GameObject m_MagicGameObject
			{
				get
				{
					return this.m_owner.m_MagicGameObject;
				}
				set
				{
					this.m_owner.m_MagicGameObject = value;
				}
			}

			// Token: 0x17001EC4 RID: 7876
			// (get) Token: 0x0600955F RID: 38239 RVA: 0x002AD7A0 File Offset: 0x002AB9A0
			// (set) Token: 0x06009560 RID: 38240 RVA: 0x002AD7B0 File Offset: 0x002AB9B0
			public Text m_MagicText
			{
				get
				{
					return this.m_owner.m_MagicText;
				}
				set
				{
					this.m_owner.m_MagicText = value;
				}
			}

			// Token: 0x17001EC5 RID: 7877
			// (get) Token: 0x06009561 RID: 38241 RVA: 0x002AD7C0 File Offset: 0x002AB9C0
			// (set) Token: 0x06009562 RID: 38242 RVA: 0x002AD7D0 File Offset: 0x002AB9D0
			public GameObject m_DexGameObject
			{
				get
				{
					return this.m_owner.m_DexGameObject;
				}
				set
				{
					this.m_owner.m_DexGameObject = value;
				}
			}

			// Token: 0x17001EC6 RID: 7878
			// (get) Token: 0x06009563 RID: 38243 RVA: 0x002AD7E0 File Offset: 0x002AB9E0
			// (set) Token: 0x06009564 RID: 38244 RVA: 0x002AD7F0 File Offset: 0x002AB9F0
			public Text m_DexText
			{
				get
				{
					return this.m_owner.m_DexText;
				}
				set
				{
					this.m_owner.m_DexText = value;
				}
			}

			// Token: 0x17001EC7 RID: 7879
			// (get) Token: 0x06009565 RID: 38245 RVA: 0x002AD800 File Offset: 0x002ABA00
			// (set) Token: 0x06009566 RID: 38246 RVA: 0x002AD810 File Offset: 0x002ABA10
			public CommonUIStateController m_skillAnimation
			{
				get
				{
					return this.m_owner.m_skillAnimation;
				}
				set
				{
					this.m_owner.m_skillAnimation = value;
				}
			}

			// Token: 0x17001EC8 RID: 7880
			// (get) Token: 0x06009567 RID: 38247 RVA: 0x002AD820 File Offset: 0x002ABA20
			// (set) Token: 0x06009568 RID: 38248 RVA: 0x002AD830 File Offset: 0x002ABA30
			public CommonUIStateController m_skillContentAnimation
			{
				get
				{
					return this.m_owner.m_skillContentAnimation;
				}
				set
				{
					this.m_owner.m_skillContentAnimation = value;
				}
			}

			// Token: 0x17001EC9 RID: 7881
			// (get) Token: 0x06009569 RID: 38249 RVA: 0x002AD840 File Offset: 0x002ABA40
			// (set) Token: 0x0600956A RID: 38250 RVA: 0x002AD850 File Offset: 0x002ABA50
			public Text m_skillBelongText
			{
				get
				{
					return this.m_owner.m_skillBelongText;
				}
				set
				{
					this.m_owner.m_skillBelongText = value;
				}
			}

			// Token: 0x17001ECA RID: 7882
			// (get) Token: 0x0600956B RID: 38251 RVA: 0x002AD860 File Offset: 0x002ABA60
			// (set) Token: 0x0600956C RID: 38252 RVA: 0x002AD870 File Offset: 0x002ABA70
			public GameObject m_skillBelongBGText
			{
				get
				{
					return this.m_owner.m_skillBelongBGText;
				}
				set
				{
					this.m_owner.m_skillBelongBGText = value;
				}
			}

			// Token: 0x17001ECB RID: 7883
			// (get) Token: 0x0600956D RID: 38253 RVA: 0x002AD880 File Offset: 0x002ABA80
			// (set) Token: 0x0600956E RID: 38254 RVA: 0x002AD890 File Offset: 0x002ABA90
			public Text m_skillUnlockConditionText
			{
				get
				{
					return this.m_owner.m_skillUnlockConditionText;
				}
				set
				{
					this.m_owner.m_skillUnlockConditionText = value;
				}
			}

			// Token: 0x17001ECC RID: 7884
			// (get) Token: 0x0600956F RID: 38255 RVA: 0x002AD8A0 File Offset: 0x002ABAA0
			// (set) Token: 0x06009570 RID: 38256 RVA: 0x002AD8B0 File Offset: 0x002ABAB0
			public Text m_skillDescText
			{
				get
				{
					return this.m_owner.m_skillDescText;
				}
				set
				{
					this.m_owner.m_skillDescText = value;
				}
			}

			// Token: 0x17001ECD RID: 7885
			// (get) Token: 0x06009571 RID: 38257 RVA: 0x002AD8C0 File Offset: 0x002ABAC0
			// (set) Token: 0x06009572 RID: 38258 RVA: 0x002AD8D0 File Offset: 0x002ABAD0
			public Text m_skillNameText
			{
				get
				{
					return this.m_owner.m_skillNameText;
				}
				set
				{
					this.m_owner.m_skillNameText = value;
				}
			}

			// Token: 0x17001ECE RID: 7886
			// (get) Token: 0x06009573 RID: 38259 RVA: 0x002AD8E0 File Offset: 0x002ABAE0
			// (set) Token: 0x06009574 RID: 38260 RVA: 0x002AD8F0 File Offset: 0x002ABAF0
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

			// Token: 0x17001ECF RID: 7887
			// (get) Token: 0x06009575 RID: 38261 RVA: 0x002AD900 File Offset: 0x002ABB00
			// (set) Token: 0x06009576 RID: 38262 RVA: 0x002AD910 File Offset: 0x002ABB10
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

			// Token: 0x17001ED0 RID: 7888
			// (get) Token: 0x06009577 RID: 38263 RVA: 0x002AD920 File Offset: 0x002ABB20
			// (set) Token: 0x06009578 RID: 38264 RVA: 0x002AD930 File Offset: 0x002ABB30
			public EquipmentArchiveUIController.EquipmentInfoWrap m_equipmentInfoWrap
			{
				get
				{
					return this.m_owner.m_equipmentInfoWrap;
				}
				set
				{
					this.m_owner.m_equipmentInfoWrap = value;
				}
			}

			// Token: 0x06009579 RID: 38265 RVA: 0x002AD940 File Offset: 0x002ABB40
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600957A RID: 38266 RVA: 0x002AD950 File Offset: 0x002ABB50
			public void ClosePropDisplay()
			{
				this.m_owner.ClosePropDisplay();
			}

			// Token: 0x0600957B RID: 38267 RVA: 0x002AD960 File Offset: 0x002ABB60
			public void SetEquipmentPropItem(PropertyModifyType type, int value)
			{
				this.m_owner.SetEquipmentPropItem(type, value);
			}

			// Token: 0x0400674F RID: 26447
			private ArchiveItemDetailInfoController m_owner;
		}
	}
}
