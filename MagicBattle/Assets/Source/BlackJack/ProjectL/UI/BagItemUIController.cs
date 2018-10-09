using System;
using System.Runtime.CompilerServices;
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
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A4D RID: 2637
	[HotFix]
	public class BagItemUIController : UIControllerBase
	{
		// Token: 0x0600A2EF RID: 41711 RVA: 0x002DE498 File Offset: 0x002DC698
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
			this.ScrollItemBaseUICtrl = base.gameObject.GetComponent<ScrollItemBaseUIController>();
		}

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x002DE510 File Offset: 0x002DC710
		public void SetBagItemInfo(BagItemBase bagItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBagItemInfoBagItemBase_hotfix != null)
			{
				this.m_SetBagItemInfoBagItemBase_hotfix.call(new object[]
				{
					this,
					bagItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			base.gameObject.name = bagItem.ListItemName;
			this.BagItem = bagItem;
			this.m_itemInfo = bagItem.ItemInfo;
			this.m_jobMaterialInfo = bagItem.JobMaterialInfo;
			this.m_equipmentInfo = bagItem.EquipmentInfo;
			this.m_enchantStoneInfo = bagItem.EnchantStoneInfo;
			this.m_countText.text = bagItem.Nums.ToString();
			this.SetItemInfoByType(bagItem.GoodsTypeId);
		}

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x002DE600 File Offset: 0x002DC800
		private void SetItemInfoByType(GoodsType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetItemInfoByTypeGoodsType_hotfix != null)
			{
				this.m_SetItemInfoByTypeGoodsType_hotfix.call(new object[]
				{
					this,
					type
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (type == GoodsType.GoodsType_Equipment)
			{
				this.m_stateCtrl.SetToUIState("Equipment", false, true);
			}
			else
			{
				this.m_stateCtrl.SetToUIState("Item", false, true);
			}
			this.m_iconImage.transform.localScale = new Vector3(1f, 1f);
			this.m_bgImage.gameObject.SetActive(true);
			this.m_enchantmentIcon.gameObject.SetActive(false);
			this.m_lockImage.SetActive(false);
			this.SetItemStateByType(type);
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(this.BagItem.GoodsTypeId, this.BagItem.ContentId));
			this.m_iconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(this.BagItem.GoodsTypeId, this.BagItem.ContentId));
			string goodsFrameName = UIUtility.GetGoodsFrameName(this.BagItem.GoodsTypeId, this.BagItem.ContentId);
			this.m_bgImage.sprite = AssetUtility.Instance.GetSprite(goodsFrameName);
			this.m_bgImage.gameObject.SetActive(goodsFrameName != string.Empty);
			this.m_ssrEffect.SetActive(UIUtility.IsRankSSR(UIUtility.GetGoodsRank(this.BagItem.GoodsTypeId, this.BagItem.ContentId)));
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x002DE7CC File Offset: 0x002DC9CC
		private void SetItemStateByType(GoodsType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetItemStateByTypeGoodsType_hotfix != null)
			{
				this.m_SetItemStateByTypeGoodsType_hotfix.call(new object[]
				{
					this,
					type
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (type)
			{
			case GoodsType.GoodsType_JobMaterial:
				break;
			case GoodsType.GoodsType_Item:
				if (this.m_itemInfo.DisplayType == ItemDisplayType.ItemDisplayType_HeroFragment)
				{
					this.m_iconImage.transform.localScale = new Vector3(1.3f, 1.3f);
					this.m_bgImage.gameObject.SetActive(false);
				}
				break;
			case GoodsType.GoodsType_Equipment:
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				EquipmentBagItem equipmentBagItem = (EquipmentBagItem)this.BagItem;
				int wearedEquipmentHeroIdByEquipmentId = projectLPlayerContext.GetWearedEquipmentHeroIdByEquipmentId(equipmentBagItem.InstanceId);
				if (wearedEquipmentHeroIdByEquipmentId > 0)
				{
					ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(wearedEquipmentHeroIdByEquipmentId);
					ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star);
					if (charImageInfo != null)
					{
						this.m_equipingTagHeadIcon.sprite = AssetUtility.Instance.GetSprite(charImageInfo.SmallHeadImage);
					}
				}
				this.m_equipingTag.SetActive(wearedEquipmentHeroIdByEquipmentId > 0);
				UIUtility.SetGameObjectChildrenActiveCount(this.m_starGroup, equipmentBagItem.StarLevel);
				this.m_lvValueText.text = equipmentBagItem.Level.ToString();
				this.m_lockImage.SetActive(equipmentBagItem.Locked);
				this.m_enchantmentIcon.gameObject.SetActive(equipmentBagItem.IsEnchant());
				if (equipmentBagItem.IsEnchant())
				{
					ConfigDataResonanceInfo configDataResonanceInfo = configDataLoader.GetConfigDataResonanceInfo(equipmentBagItem.ResonanceId);
					this.m_enchantmentIcon.sprite = AssetUtility.Instance.GetSprite(configDataResonanceInfo.SmallIcon);
				}
				break;
			}
			default:
				if (type != GoodsType.GoodsType_EnchantStone)
				{
				}
				break;
			}
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x002DE9D0 File Offset: 0x002DCBD0
		public void ShowFrame(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowFrameBoolean_hotfix != null)
			{
				this.m_ShowFrameBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_itemInfo != null && this.m_itemInfo.DisplayType == ItemDisplayType.ItemDisplayType_HeroFragment;
			this.m_fragmentSelectFrameImg.SetActive(flag && isShow);
			this.m_selectFrameImage.SetActive(!flag && isShow);
		}

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x002DEA88 File Offset: 0x002DCC88
		public void ShowCheckFrame(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCheckFrameBoolean_hotfix != null)
			{
				this.m_ShowCheckFrameBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_checkFrameImage.SetActive(isShow);
		}

		// Token: 0x0600A2F5 RID: 41717 RVA: 0x002DEB04 File Offset: 0x002DCD04
		public void ShowGreyMask(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowGreyMaskBoolean_hotfix != null)
			{
				this.m_ShowGreyMaskBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.BagItem.ItemInfo != null && this.BagItem.ItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_HeroFragment;
			this.m_greyMaskItem.SetActive(!flag && isShow);
			this.m_greyMaskPiece.SetActive(flag && isShow);
		}

		// Token: 0x0600A2F6 RID: 41718 RVA: 0x002DEBC8 File Offset: 0x002DCDC8
		public void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScrollItemBaseUICtrl.Init(this, true);
		}

		// Token: 0x0600A2F7 RID: 41719 RVA: 0x002DEC38 File Offset: 0x002DCE38
		public void RegisterItemClickEvent(Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterItemClickEventAction`1_hotfix != null)
			{
				this.m_RegisterItemClickEventAction`1_hotfix.call(new object[]
				{
					this,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScrollItemBaseUICtrl.EventOnUIItemClick = action;
		}

		// Token: 0x0600A2F8 RID: 41720 RVA: 0x002DECB4 File Offset: 0x002DCEB4
		public void RegisterItemNeedFillEvent(Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterItemNeedFillEventAction`1_hotfix != null)
			{
				this.m_RegisterItemNeedFillEventAction`1_hotfix.call(new object[]
				{
					this,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScrollItemBaseUICtrl.EventOnUIItemNeedFill = action;
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x0600A2FA RID: 41722 RVA: 0x002DEDA8 File Offset: 0x002DCFA8
		// (set) Token: 0x0600A2F9 RID: 41721 RVA: 0x002DED30 File Offset: 0x002DCF30
		public BagItemBase BagItem
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BagItem_hotfix != null)
				{
					return (BagItemBase)this.m_get_BagItem_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<BagItem>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_BagItemBagItemBase_hotfix != null)
				{
					this.m_set_BagItemBagItemBase_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<BagItem>k__BackingField = value;
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x0600A2FB RID: 41723 RVA: 0x002DEE1C File Offset: 0x002DD01C
		// (set) Token: 0x0600A2FC RID: 41724 RVA: 0x002DEE3C File Offset: 0x002DD03C
		[DoNotToLua]
		public new BagItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BagItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x002DEE48 File Offset: 0x002DD048
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x002DEE54 File Offset: 0x002DD054
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A2FF RID: 41727 RVA: 0x002DEE5C File Offset: 0x002DD05C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A300 RID: 41728 RVA: 0x002DEE64 File Offset: 0x002DD064
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A301 RID: 41729 RVA: 0x002DEE78 File Offset: 0x002DD078
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A302 RID: 41730 RVA: 0x002DEE80 File Offset: 0x002DD080
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x002DEE8C File Offset: 0x002DD08C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x002DEE98 File Offset: 0x002DD098
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x002DEEA4 File Offset: 0x002DD0A4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x002DEEB0 File Offset: 0x002DD0B0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x002DEEBC File Offset: 0x002DD0BC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A308 RID: 41736 RVA: 0x002DEEC8 File Offset: 0x002DD0C8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A309 RID: 41737 RVA: 0x002DEED4 File Offset: 0x002DD0D4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x002DEEE0 File Offset: 0x002DD0E0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x002DEEEC File Offset: 0x002DD0EC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x002DEEF4 File Offset: 0x002DD0F4
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
					this.m_SetBagItemInfoBagItemBase_hotfix = (luaObj.RawGet("SetBagItemInfo") as LuaFunction);
					this.m_SetItemInfoByTypeGoodsType_hotfix = (luaObj.RawGet("SetItemInfoByType") as LuaFunction);
					this.m_SetItemStateByTypeGoodsType_hotfix = (luaObj.RawGet("SetItemStateByType") as LuaFunction);
					this.m_ShowFrameBoolean_hotfix = (luaObj.RawGet("ShowFrame") as LuaFunction);
					this.m_ShowCheckFrameBoolean_hotfix = (luaObj.RawGet("ShowCheckFrame") as LuaFunction);
					this.m_ShowGreyMaskBoolean_hotfix = (luaObj.RawGet("ShowGreyMask") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_RegisterItemClickEventAction`1_hotfix = (luaObj.RawGet("RegisterItemClickEvent") as LuaFunction);
					this.m_RegisterItemNeedFillEventAction`1_hotfix = (luaObj.RawGet("RegisterItemNeedFillEvent") as LuaFunction);
					this.m_set_BagItemBagItemBase_hotfix = (luaObj.RawGet("set_BagItem") as LuaFunction);
					this.m_get_BagItem_hotfix = (luaObj.RawGet("get_BagItem") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A30D RID: 41741 RVA: 0x002DF0D4 File Offset: 0x002DD2D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BagItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006CEC RID: 27884
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController m_stateCtrl;

		// Token: 0x04006CED RID: 27885
		[AutoBind("./CountText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_countText;

		// Token: 0x04006CEE RID: 27886
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		public Image m_iconImage;

		// Token: 0x04006CEF RID: 27887
		[AutoBind("./SelectFrameImg", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_selectFrameImage;

		// Token: 0x04006CF0 RID: 27888
		[AutoBind("./FragmentSelectFrameImg", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_fragmentSelectFrameImg;

		// Token: 0x04006CF1 RID: 27889
		[AutoBind("./SelectFrameImg2", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_checkFrameImage;

		// Token: 0x04006CF2 RID: 27890
		[AutoBind("./BgImage", AutoBindAttribute.InitState.NotInit, false)]
		public Image m_bgImage;

		// Token: 0x04006CF3 RID: 27891
		[AutoBind("./SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_ssrEffect;

		// Token: 0x04006CF4 RID: 27892
		[AutoBind("./LockImage", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_lockImage;

		// Token: 0x04006CF5 RID: 27893
		[AutoBind("./Lv/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_lvValueText;

		// Token: 0x04006CF6 RID: 27894
		[AutoBind("./EquipingTag", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_equipingTag;

		// Token: 0x04006CF7 RID: 27895
		[AutoBind("./EquipingTag/HeadIcon", AutoBindAttribute.InitState.NotInit, false)]
		public Image m_equipingTagHeadIcon;

		// Token: 0x04006CF8 RID: 27896
		[AutoBind("./StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_starGroup;

		// Token: 0x04006CF9 RID: 27897
		[AutoBind("./GreyMaskItem", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_greyMaskItem;

		// Token: 0x04006CFA RID: 27898
		[AutoBind("./GreyMaskPiece", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_greyMaskPiece;

		// Token: 0x04006CFB RID: 27899
		[AutoBind("./EnchantmentIcon", AutoBindAttribute.InitState.NotInit, false)]
		public Image m_enchantmentIcon;

		// Token: 0x04006CFC RID: 27900
		public ConfigDataItemInfo m_itemInfo;

		// Token: 0x04006CFD RID: 27901
		public ConfigDataJobMaterialInfo m_jobMaterialInfo;

		// Token: 0x04006CFE RID: 27902
		public ConfigDataEquipmentInfo m_equipmentInfo;

		// Token: 0x04006CFF RID: 27903
		public ConfigDataEnchantStoneInfo m_enchantStoneInfo;

		// Token: 0x04006D01 RID: 27905
		public ScrollItemBaseUIController ScrollItemBaseUICtrl;

		// Token: 0x04006D02 RID: 27906
		[DoNotToLua]
		private BagItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006D03 RID: 27907
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006D04 RID: 27908
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006D05 RID: 27909
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006D06 RID: 27910
		private LuaFunction m_SetBagItemInfoBagItemBase_hotfix;

		// Token: 0x04006D07 RID: 27911
		private LuaFunction m_SetItemInfoByTypeGoodsType_hotfix;

		// Token: 0x04006D08 RID: 27912
		private LuaFunction m_SetItemStateByTypeGoodsType_hotfix;

		// Token: 0x04006D09 RID: 27913
		private LuaFunction m_ShowFrameBoolean_hotfix;

		// Token: 0x04006D0A RID: 27914
		private LuaFunction m_ShowCheckFrameBoolean_hotfix;

		// Token: 0x04006D0B RID: 27915
		private LuaFunction m_ShowGreyMaskBoolean_hotfix;

		// Token: 0x04006D0C RID: 27916
		private LuaFunction m_Init_hotfix;

		// Token: 0x04006D0D RID: 27917
		private LuaFunction m_RegisterItemClickEventAction;

		// Token: 0x04006D0E RID: 27918
		private LuaFunction m_RegisterItemNeedFillEventAction;

		// Token: 0x04006D0F RID: 27919
		private LuaFunction m_set_BagItemBagItemBase_hotfix;

		// Token: 0x04006D10 RID: 27920
		private LuaFunction m_get_BagItem_hotfix;

		// Token: 0x02000A4E RID: 2638
		public new class LuaExportHelper
		{
			// Token: 0x0600A30E RID: 41742 RVA: 0x002DF13C File Offset: 0x002DD33C
			public LuaExportHelper(BagItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A30F RID: 41743 RVA: 0x002DF14C File Offset: 0x002DD34C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A310 RID: 41744 RVA: 0x002DF15C File Offset: 0x002DD35C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A311 RID: 41745 RVA: 0x002DF16C File Offset: 0x002DD36C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A312 RID: 41746 RVA: 0x002DF17C File Offset: 0x002DD37C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A313 RID: 41747 RVA: 0x002DF194 File Offset: 0x002DD394
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A314 RID: 41748 RVA: 0x002DF1A4 File Offset: 0x002DD3A4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A315 RID: 41749 RVA: 0x002DF1B4 File Offset: 0x002DD3B4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A316 RID: 41750 RVA: 0x002DF1C4 File Offset: 0x002DD3C4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A317 RID: 41751 RVA: 0x002DF1D4 File Offset: 0x002DD3D4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A318 RID: 41752 RVA: 0x002DF1E4 File Offset: 0x002DD3E4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A319 RID: 41753 RVA: 0x002DF1F4 File Offset: 0x002DD3F4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A31A RID: 41754 RVA: 0x002DF204 File Offset: 0x002DD404
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A31B RID: 41755 RVA: 0x002DF214 File Offset: 0x002DD414
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A31C RID: 41756 RVA: 0x002DF224 File Offset: 0x002DD424
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A31D RID: 41757 RVA: 0x002DF234 File Offset: 0x002DD434
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002116 RID: 8470
			// (set) Token: 0x0600A31E RID: 41758 RVA: 0x002DF244 File Offset: 0x002DD444
			public BagItemBase BagItem
			{
				set
				{
					this.m_owner.BagItem = value;
				}
			}

			// Token: 0x0600A31F RID: 41759 RVA: 0x002DF254 File Offset: 0x002DD454
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600A320 RID: 41760 RVA: 0x002DF264 File Offset: 0x002DD464
			public void SetItemInfoByType(GoodsType type)
			{
				this.m_owner.SetItemInfoByType(type);
			}

			// Token: 0x0600A321 RID: 41761 RVA: 0x002DF274 File Offset: 0x002DD474
			public void SetItemStateByType(GoodsType type)
			{
				this.m_owner.SetItemStateByType(type);
			}

			// Token: 0x04006D11 RID: 27921
			private BagItemUIController m_owner;
		}
	}
}
