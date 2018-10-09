using System;
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
	// Token: 0x02000D55 RID: 3413
	[HotFix]
	public class EquipmentDepotListItemUIController : UIControllerBase
	{
		// Token: 0x0600FB52 RID: 64338 RVA: 0x0042180C File Offset: 0x0041FA0C
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

		// Token: 0x0600FB53 RID: 64339 RVA: 0x00421884 File Offset: 0x0041FA84
		public void InitEquipmentDepotListItemInfo(BagItemBase bagItem, bool canWear)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitEquipmentDepotListItemInfoBagItemBaseBoolean_hotfix != null)
			{
				this.m_InitEquipmentDepotListItemInfoBagItemBaseBoolean_hotfix.call(new object[]
				{
					this,
					bagItem,
					canWear
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			base.gameObject.name = bagItem.ListItemName;
			this.BagItem = bagItem;
			EquipmentBagItem equipmentBagItem = bagItem as EquipmentBagItem;
			EnchantStoneBagItem enchantStoneBagItem = bagItem as EnchantStoneBagItem;
			this.EquipmentInstanceId = this.BagItem.InstanceId;
			if (equipmentBagItem != null)
			{
				ConfigDataEquipmentInfo equipmentInfo = equipmentBagItem.EquipmentInfo;
				this.m_icon.sprite = AssetUtility.Instance.GetSprite(equipmentInfo.Icon);
				this.m_bgFrame.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(equipmentInfo.Rank));
				this.m_SSREffect.SetActive(UIUtility.IsRankSSR(equipmentInfo.Rank));
				UIUtility.SetGameObjectChildrenActiveCount(this.m_starGroup, equipmentBagItem.StarLevel);
				this.m_lvValueText.text = equipmentBagItem.Level.ToString();
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				int wearedEquipmentHeroIdByEquipmentId = projectLPlayerContext.GetWearedEquipmentHeroIdByEquipmentId(this.EquipmentInstanceId);
				this.IsEquiped = (wearedEquipmentHeroIdByEquipmentId > 0);
				if (this.IsEquiped)
				{
					ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(wearedEquipmentHeroIdByEquipmentId);
					ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star);
					if (charImageInfo != null)
					{
						this.m_equipingTagHeadIcon.sprite = AssetUtility.Instance.GetSprite(charImageInfo.SmallHeadImage);
					}
					this.m_stateCtrl.SetToUIState("Equiped", false, true);
				}
				else
				{
					this.m_stateCtrl.SetToUIState("UnEquiped", false, true);
				}
				this.m_lockImage.SetActive(equipmentBagItem.Locked);
				this.m_mask.SetActive(!canWear);
				this.m_enchantmentIcon.gameObject.SetActive(equipmentBagItem.IsEnchant());
				if (equipmentBagItem.IsEnchant())
				{
					ConfigDataResonanceInfo configDataResonanceInfo = configDataLoader.GetConfigDataResonanceInfo(equipmentBagItem.ResonanceId);
					this.m_enchantmentIcon.sprite = AssetUtility.Instance.GetSprite(configDataResonanceInfo.SmallIcon);
				}
			}
			else
			{
				ConfigDataEnchantStoneInfo enchantStoneInfo = enchantStoneBagItem.EnchantStoneInfo;
				this.m_icon.sprite = AssetUtility.Instance.GetSprite(enchantStoneInfo.Icon);
				this.m_bgFrame.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(enchantStoneInfo.Rank));
				this.m_SSREffect.SetActive(UIUtility.IsRankSSR(enchantStoneInfo.Rank));
				this.m_countText.text = UIUtility.GetGoodsCount(this.BagItem.GoodsTypeId, this.BagItem.ContentId).ToString();
				this.m_stateCtrl.SetToUIState("Enchant", false, true);
				this.m_enchantmentIcon.gameObject.SetActive(false);
				this.m_checkImageMask.SetActive(false);
			}
		}

		// Token: 0x0600FB54 RID: 64340 RVA: 0x00421BB4 File Offset: 0x0041FDB4
		public void ShowCheckImage(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCheckImageBoolean_hotfix != null)
			{
				this.m_ShowCheckImageBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_checkImageMask.SetActive(isShow);
		}

		// Token: 0x0600FB55 RID: 64341 RVA: 0x00421C30 File Offset: 0x0041FE30
		public void ShowSelectFrame(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectFrameBoolean_hotfix != null)
			{
				this.m_ShowSelectFrameBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectFrame.SetActive(isShow);
		}

		// Token: 0x0600FB56 RID: 64342 RVA: 0x00421CAC File Offset: 0x0041FEAC
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

		// Token: 0x0600FB57 RID: 64343 RVA: 0x00421D1C File Offset: 0x0041FF1C
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

		// Token: 0x0600FB58 RID: 64344 RVA: 0x00421D98 File Offset: 0x0041FF98
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

		// Token: 0x0600FB59 RID: 64345 RVA: 0x00421E14 File Offset: 0x00420014
		public void RegisterItem3DTouchEvent(Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterItem3DTouchEventAction`1_hotfix != null)
			{
				this.m_RegisterItem3DTouchEventAction`1_hotfix.call(new object[]
				{
					this,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScrollItemBaseUICtrl.EventOnUIItem3DTouch = action;
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x0600FB5A RID: 64346 RVA: 0x00421E90 File Offset: 0x00420090
		// (set) Token: 0x0600FB5B RID: 64347 RVA: 0x00421EB0 File Offset: 0x004200B0
		[DoNotToLua]
		public new EquipmentDepotListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EquipmentDepotListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600FB5C RID: 64348 RVA: 0x00421EBC File Offset: 0x004200BC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600FB5D RID: 64349 RVA: 0x00421EC8 File Offset: 0x004200C8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600FB5E RID: 64350 RVA: 0x00421ED0 File Offset: 0x004200D0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600FB5F RID: 64351 RVA: 0x00421ED8 File Offset: 0x004200D8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600FB60 RID: 64352 RVA: 0x00421EEC File Offset: 0x004200EC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600FB61 RID: 64353 RVA: 0x00421EF4 File Offset: 0x004200F4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600FB62 RID: 64354 RVA: 0x00421F00 File Offset: 0x00420100
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600FB63 RID: 64355 RVA: 0x00421F0C File Offset: 0x0042010C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600FB64 RID: 64356 RVA: 0x00421F18 File Offset: 0x00420118
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600FB65 RID: 64357 RVA: 0x00421F24 File Offset: 0x00420124
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600FB66 RID: 64358 RVA: 0x00421F30 File Offset: 0x00420130
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600FB67 RID: 64359 RVA: 0x00421F3C File Offset: 0x0042013C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600FB68 RID: 64360 RVA: 0x00421F48 File Offset: 0x00420148
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600FB69 RID: 64361 RVA: 0x00421F54 File Offset: 0x00420154
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600FB6A RID: 64362 RVA: 0x00421F60 File Offset: 0x00420160
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600FB6B RID: 64363 RVA: 0x00421F68 File Offset: 0x00420168
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
					this.m_InitEquipmentDepotListItemInfoBagItemBaseBoolean_hotfix = (luaObj.RawGet("InitEquipmentDepotListItemInfo") as LuaFunction);
					this.m_ShowCheckImageBoolean_hotfix = (luaObj.RawGet("ShowCheckImage") as LuaFunction);
					this.m_ShowSelectFrameBoolean_hotfix = (luaObj.RawGet("ShowSelectFrame") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_RegisterItemClickEventAction`1_hotfix = (luaObj.RawGet("RegisterItemClickEvent") as LuaFunction);
					this.m_RegisterItemNeedFillEventAction`1_hotfix = (luaObj.RawGet("RegisterItemNeedFillEvent") as LuaFunction);
					this.m_RegisterItem3DTouchEventAction`1_hotfix = (luaObj.RawGet("RegisterItem3DTouchEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600FB6C RID: 64364 RVA: 0x004220E4 File Offset: 0x004202E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentDepotListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009372 RID: 37746
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController m_stateCtrl;

		// Token: 0x04009373 RID: 37747
		[AutoBind("./Icon", AutoBindAttribute.InitState.NotInit, false)]
		public Image m_icon;

		// Token: 0x04009374 RID: 37748
		[AutoBind("./BgFrame", AutoBindAttribute.InitState.NotInit, false)]
		public Image m_bgFrame;

		// Token: 0x04009375 RID: 37749
		[AutoBind("./SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_SSREffect;

		// Token: 0x04009376 RID: 37750
		[AutoBind("./CheckImageMask", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_checkImageMask;

		// Token: 0x04009377 RID: 37751
		[AutoBind("./StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_starGroup;

		// Token: 0x04009378 RID: 37752
		[AutoBind("./Lv/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_lvValueText;

		// Token: 0x04009379 RID: 37753
		[AutoBind("./EquipingTag/HeadIcon", AutoBindAttribute.InitState.NotInit, false)]
		public Image m_equipingTagHeadIcon;

		// Token: 0x0400937A RID: 37754
		[AutoBind("./LockImage", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_lockImage;

		// Token: 0x0400937B RID: 37755
		[AutoBind("./SelectFrame", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_selectFrame;

		// Token: 0x0400937C RID: 37756
		[AutoBind("./Mask", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_mask;

		// Token: 0x0400937D RID: 37757
		[AutoBind("./EnchantmentIcon", AutoBindAttribute.InitState.NotInit, false)]
		public Image m_enchantmentIcon;

		// Token: 0x0400937E RID: 37758
		[AutoBind("./CountText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_countText;

		// Token: 0x0400937F RID: 37759
		public bool IsEquiped;

		// Token: 0x04009380 RID: 37760
		public ulong EquipmentInstanceId;

		// Token: 0x04009381 RID: 37761
		public BagItemBase BagItem;

		// Token: 0x04009382 RID: 37762
		public ScrollItemBaseUIController ScrollItemBaseUICtrl;

		// Token: 0x04009383 RID: 37763
		[DoNotToLua]
		private EquipmentDepotListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009384 RID: 37764
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009385 RID: 37765
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009386 RID: 37766
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009387 RID: 37767
		private LuaFunction m_InitEquipmentDepotListItemInfoBagItemBaseBoolean_hotfix;

		// Token: 0x04009388 RID: 37768
		private LuaFunction m_ShowCheckImageBoolean_hotfix;

		// Token: 0x04009389 RID: 37769
		private LuaFunction m_ShowSelectFrameBoolean_hotfix;

		// Token: 0x0400938A RID: 37770
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400938B RID: 37771
		private LuaFunction m_RegisterItemClickEventAction;

		// Token: 0x0400938C RID: 37772
		private LuaFunction m_RegisterItemNeedFillEventAction;

		// Token: 0x0400938D RID: 37773
		private LuaFunction m_RegisterItem3DTouchEventAction;

		// Token: 0x02000D56 RID: 3414
		public new class LuaExportHelper
		{
			// Token: 0x0600FB6D RID: 64365 RVA: 0x0042214C File Offset: 0x0042034C
			public LuaExportHelper(EquipmentDepotListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600FB6E RID: 64366 RVA: 0x0042215C File Offset: 0x0042035C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600FB6F RID: 64367 RVA: 0x0042216C File Offset: 0x0042036C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600FB70 RID: 64368 RVA: 0x0042217C File Offset: 0x0042037C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600FB71 RID: 64369 RVA: 0x0042218C File Offset: 0x0042038C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600FB72 RID: 64370 RVA: 0x004221A4 File Offset: 0x004203A4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600FB73 RID: 64371 RVA: 0x004221B4 File Offset: 0x004203B4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600FB74 RID: 64372 RVA: 0x004221C4 File Offset: 0x004203C4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600FB75 RID: 64373 RVA: 0x004221D4 File Offset: 0x004203D4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600FB76 RID: 64374 RVA: 0x004221E4 File Offset: 0x004203E4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600FB77 RID: 64375 RVA: 0x004221F4 File Offset: 0x004203F4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600FB78 RID: 64376 RVA: 0x00422204 File Offset: 0x00420404
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600FB79 RID: 64377 RVA: 0x00422214 File Offset: 0x00420414
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600FB7A RID: 64378 RVA: 0x00422224 File Offset: 0x00420424
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600FB7B RID: 64379 RVA: 0x00422234 File Offset: 0x00420434
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600FB7C RID: 64380 RVA: 0x00422244 File Offset: 0x00420444
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600FB7D RID: 64381 RVA: 0x00422254 File Offset: 0x00420454
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400938E RID: 37774
			private EquipmentDepotListItemUIController m_owner;
		}
	}
}
