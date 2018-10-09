using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B2F RID: 2863
	[HotFix]
	public class BusinessCardHeroListItemUIController : UIControllerBase
	{
		// Token: 0x0600C208 RID: 49672 RVA: 0x0035E5FC File Offset: 0x0035C7FC
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
			this.m_heroItemButton.onClick.AddListener(new UnityAction(this.OnHeroItemClick));
		}

		// Token: 0x0600C209 RID: 49673 RVA: 0x0035E680 File Offset: 0x0035C880
		public void SetHeroListItemInfo(Hero hero, BusinessCard businessCard)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroListItemInfoHeroBusinessCard_hotfix != null)
			{
				this.m_SetHeroListItemInfoHeroBusinessCard_hotfix.call(new object[]
				{
					this,
					hero2,
					businessCard
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = hero2;
			if (hero.HeroInfo != null)
			{
				this.m_hero = hero;
				ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
				if (charImageInfo != null)
				{
					this.m_heroIconImg.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_1"));
				}
				ConfigDataArmyInfo configDataArmyInfo = this.m_configDataLoader.GetConfigDataArmyInfo(hero.GetActiveJob().JobConnectionInfo.m_jobInfo.Army_ID);
				this.m_heroTypeImg.sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
				this.m_heroLvText.text = hero.Level.ToString();
				this.m_heroFrameImg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetHeroItemFrameNameByRank(hero.HeroInfo.GetRank(hero.StarLevel)));
				this.m_heroSSRFrameEffect.SetActive(hero.HeroInfo.GetRank(hero.StarLevel) >= 4);
				UIUtility.SetGameObjectChildrenActiveCount(this.m_heroStar, hero.StarLevel);
				int num = businessCard.SetInfo.Heroes.FindIndex((BusinessCardHeroSet i) => i.HeroId == hero.HeroId);
				if (num >= 0)
				{
					this.m_heroPositionIndex = businessCard.SetInfo.Heroes[num].PositionIndex;
					this.m_heroIndexText.text = (businessCard.SetInfo.Heroes[num].PositionIndex + 1).ToString();
					this.m_heroItemUIStateController.SetToUIState("Select", false, true);
				}
				else
				{
					this.m_heroItemUIStateController.SetToUIState("Normal", false, true);
				}
				base.gameObject.SetActive(true);
			}
		}

		// Token: 0x0600C20A RID: 49674 RVA: 0x0035E8F8 File Offset: 0x0035CAF8
		public int GetHeroID()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroID_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroID_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_hero.HeroId;
		}

		// Token: 0x0600C20B RID: 49675 RVA: 0x0035E970 File Offset: 0x0035CB70
		public int GetPositionIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPositionIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPositionIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroPositionIndex;
		}

		// Token: 0x0600C20C RID: 49676 RVA: 0x0035E9E4 File Offset: 0x0035CBE4
		public bool IsSelect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSelect_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSelect_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroItemUIStateController.GetCurrentUIState().StateName == "Select";
		}

		// Token: 0x0600C20D RID: 49677 RVA: 0x0035EA6C File Offset: 0x0035CC6C
		public void SetNormalState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNormalState_hotfix != null)
			{
				this.m_SetNormalState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroItemUIStateController.SetToUIState("Normal", false, true);
		}

		// Token: 0x0600C20E RID: 49678 RVA: 0x0035EAE0 File Offset: 0x0035CCE0
		public void SetSelectState(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectStateInt32_hotfix != null)
			{
				this.m_SetSelectStateInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroPositionIndex = index;
			this.m_heroIndexText.text = (index + 1).ToString();
			this.m_heroItemUIStateController.SetToUIState("Select", false, true);
		}

		// Token: 0x0600C20F RID: 49679 RVA: 0x0035EB88 File Offset: 0x0035CD88
		private void OnHeroItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroItemClick_hotfix != null)
			{
				this.m_OnHeroItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSelectHeroItem != null)
			{
				this.EventOnSelectHeroItem(this);
			}
		}

		// Token: 0x14000251 RID: 593
		// (add) Token: 0x0600C210 RID: 49680 RVA: 0x0035EC00 File Offset: 0x0035CE00
		// (remove) Token: 0x0600C211 RID: 49681 RVA: 0x0035EC9C File Offset: 0x0035CE9C
		public event Action<BusinessCardHeroListItemUIController> EventOnSelectHeroItem
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectHeroItemAction`1_hotfix != null)
				{
					this.m_add_EventOnSelectHeroItemAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BusinessCardHeroListItemUIController> action = this.EventOnSelectHeroItem;
				Action<BusinessCardHeroListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BusinessCardHeroListItemUIController>>(ref this.EventOnSelectHeroItem, (Action<BusinessCardHeroListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectHeroItemAction`1_hotfix != null)
				{
					this.m_remove_EventOnSelectHeroItemAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BusinessCardHeroListItemUIController> action = this.EventOnSelectHeroItem;
				Action<BusinessCardHeroListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BusinessCardHeroListItemUIController>>(ref this.EventOnSelectHeroItem, (Action<BusinessCardHeroListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x0600C212 RID: 49682 RVA: 0x0035ED38 File Offset: 0x0035CF38
		// (set) Token: 0x0600C213 RID: 49683 RVA: 0x0035ED58 File Offset: 0x0035CF58
		[DoNotToLua]
		public new BusinessCardHeroListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BusinessCardHeroListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C214 RID: 49684 RVA: 0x0035ED64 File Offset: 0x0035CF64
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C215 RID: 49685 RVA: 0x0035ED70 File Offset: 0x0035CF70
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C216 RID: 49686 RVA: 0x0035ED78 File Offset: 0x0035CF78
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C217 RID: 49687 RVA: 0x0035ED80 File Offset: 0x0035CF80
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C218 RID: 49688 RVA: 0x0035ED94 File Offset: 0x0035CF94
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C219 RID: 49689 RVA: 0x0035ED9C File Offset: 0x0035CF9C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C21A RID: 49690 RVA: 0x0035EDA8 File Offset: 0x0035CFA8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C21B RID: 49691 RVA: 0x0035EDB4 File Offset: 0x0035CFB4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C21C RID: 49692 RVA: 0x0035EDC0 File Offset: 0x0035CFC0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C21D RID: 49693 RVA: 0x0035EDCC File Offset: 0x0035CFCC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C21E RID: 49694 RVA: 0x0035EDD8 File Offset: 0x0035CFD8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C21F RID: 49695 RVA: 0x0035EDE4 File Offset: 0x0035CFE4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C220 RID: 49696 RVA: 0x0035EDF0 File Offset: 0x0035CFF0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C221 RID: 49697 RVA: 0x0035EDFC File Offset: 0x0035CFFC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C222 RID: 49698 RVA: 0x0035EE08 File Offset: 0x0035D008
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C223 RID: 49699 RVA: 0x0035EE10 File Offset: 0x0035D010
		private void __callDele_EventOnSelectHeroItem(BusinessCardHeroListItemUIController obj)
		{
			Action<BusinessCardHeroListItemUIController> eventOnSelectHeroItem = this.EventOnSelectHeroItem;
			if (eventOnSelectHeroItem != null)
			{
				eventOnSelectHeroItem(obj);
			}
		}

		// Token: 0x0600C224 RID: 49700 RVA: 0x0035EE34 File Offset: 0x0035D034
		private void __clearDele_EventOnSelectHeroItem(BusinessCardHeroListItemUIController obj)
		{
			this.EventOnSelectHeroItem = null;
		}

		// Token: 0x0600C225 RID: 49701 RVA: 0x0035EE40 File Offset: 0x0035D040
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
					this.m_SetHeroListItemInfoHeroBusinessCard_hotfix = (luaObj.RawGet("SetHeroListItemInfo") as LuaFunction);
					this.m_GetHeroID_hotfix = (luaObj.RawGet("GetHeroID") as LuaFunction);
					this.m_GetPositionIndex_hotfix = (luaObj.RawGet("GetPositionIndex") as LuaFunction);
					this.m_IsSelect_hotfix = (luaObj.RawGet("IsSelect") as LuaFunction);
					this.m_SetNormalState_hotfix = (luaObj.RawGet("SetNormalState") as LuaFunction);
					this.m_SetSelectStateInt32_hotfix = (luaObj.RawGet("SetSelectState") as LuaFunction);
					this.m_OnHeroItemClick_hotfix = (luaObj.RawGet("OnHeroItemClick") as LuaFunction);
					this.m_add_EventOnSelectHeroItemAction`1_hotfix = (luaObj.RawGet("add_EventOnSelectHeroItem") as LuaFunction);
					this.m_remove_EventOnSelectHeroItemAction`1_hotfix = (luaObj.RawGet("remove_EventOnSelectHeroItem") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C226 RID: 49702 RVA: 0x0035EFEC File Offset: 0x0035D1EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardHeroListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007B6E RID: 31598
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroItemButton;

		// Token: 0x04007B6F RID: 31599
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_heroItemUIStateController;

		// Token: 0x04007B70 RID: 31600
		[AutoBind("./HeroStars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroStar;

		// Token: 0x04007B71 RID: 31601
		[AutoBind("./HeroTypeImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroTypeImg;

		// Token: 0x04007B72 RID: 31602
		[AutoBind("./HeroLvText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroLvText;

		// Token: 0x04007B73 RID: 31603
		[AutoBind("./SSRFrameEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroSSRFrameEffect;

		// Token: 0x04007B74 RID: 31604
		[AutoBind("./FrameImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroFrameImg;

		// Token: 0x04007B75 RID: 31605
		[AutoBind("./HeroIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroIconImg;

		// Token: 0x04007B76 RID: 31606
		[AutoBind("./SelectFrameImg/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroIndexText;

		// Token: 0x04007B77 RID: 31607
		private int m_heroPositionIndex = -1;

		// Token: 0x04007B78 RID: 31608
		private Hero m_hero;

		// Token: 0x04007B79 RID: 31609
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04007B7A RID: 31610
		[DoNotToLua]
		private BusinessCardHeroListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007B7B RID: 31611
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007B7C RID: 31612
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007B7D RID: 31613
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007B7E RID: 31614
		private LuaFunction m_SetHeroListItemInfoHeroBusinessCard_hotfix;

		// Token: 0x04007B7F RID: 31615
		private LuaFunction m_GetHeroID_hotfix;

		// Token: 0x04007B80 RID: 31616
		private LuaFunction m_GetPositionIndex_hotfix;

		// Token: 0x04007B81 RID: 31617
		private LuaFunction m_IsSelect_hotfix;

		// Token: 0x04007B82 RID: 31618
		private LuaFunction m_SetNormalState_hotfix;

		// Token: 0x04007B83 RID: 31619
		private LuaFunction m_SetSelectStateInt32_hotfix;

		// Token: 0x04007B84 RID: 31620
		private LuaFunction m_OnHeroItemClick_hotfix;

		// Token: 0x04007B85 RID: 31621
		private LuaFunction m_add_EventOnSelectHeroItemAction;

		// Token: 0x04007B86 RID: 31622
		private LuaFunction m_remove_EventOnSelectHeroItemAction;

		// Token: 0x02000B30 RID: 2864
		public new class LuaExportHelper
		{
			// Token: 0x0600C227 RID: 49703 RVA: 0x0035F054 File Offset: 0x0035D254
			public LuaExportHelper(BusinessCardHeroListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C228 RID: 49704 RVA: 0x0035F064 File Offset: 0x0035D264
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C229 RID: 49705 RVA: 0x0035F074 File Offset: 0x0035D274
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C22A RID: 49706 RVA: 0x0035F084 File Offset: 0x0035D284
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C22B RID: 49707 RVA: 0x0035F094 File Offset: 0x0035D294
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C22C RID: 49708 RVA: 0x0035F0AC File Offset: 0x0035D2AC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C22D RID: 49709 RVA: 0x0035F0BC File Offset: 0x0035D2BC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C22E RID: 49710 RVA: 0x0035F0CC File Offset: 0x0035D2CC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C22F RID: 49711 RVA: 0x0035F0DC File Offset: 0x0035D2DC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C230 RID: 49712 RVA: 0x0035F0EC File Offset: 0x0035D2EC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C231 RID: 49713 RVA: 0x0035F0FC File Offset: 0x0035D2FC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C232 RID: 49714 RVA: 0x0035F10C File Offset: 0x0035D30C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C233 RID: 49715 RVA: 0x0035F11C File Offset: 0x0035D31C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C234 RID: 49716 RVA: 0x0035F12C File Offset: 0x0035D32C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C235 RID: 49717 RVA: 0x0035F13C File Offset: 0x0035D33C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C236 RID: 49718 RVA: 0x0035F14C File Offset: 0x0035D34C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C237 RID: 49719 RVA: 0x0035F15C File Offset: 0x0035D35C
			public void __callDele_EventOnSelectHeroItem(BusinessCardHeroListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnSelectHeroItem(obj);
			}

			// Token: 0x0600C238 RID: 49720 RVA: 0x0035F16C File Offset: 0x0035D36C
			public void __clearDele_EventOnSelectHeroItem(BusinessCardHeroListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnSelectHeroItem(obj);
			}

			// Token: 0x1700270A RID: 9994
			// (get) Token: 0x0600C239 RID: 49721 RVA: 0x0035F17C File Offset: 0x0035D37C
			// (set) Token: 0x0600C23A RID: 49722 RVA: 0x0035F18C File Offset: 0x0035D38C
			public Button m_heroItemButton
			{
				get
				{
					return this.m_owner.m_heroItemButton;
				}
				set
				{
					this.m_owner.m_heroItemButton = value;
				}
			}

			// Token: 0x1700270B RID: 9995
			// (get) Token: 0x0600C23B RID: 49723 RVA: 0x0035F19C File Offset: 0x0035D39C
			// (set) Token: 0x0600C23C RID: 49724 RVA: 0x0035F1AC File Offset: 0x0035D3AC
			public CommonUIStateController m_heroItemUIStateController
			{
				get
				{
					return this.m_owner.m_heroItemUIStateController;
				}
				set
				{
					this.m_owner.m_heroItemUIStateController = value;
				}
			}

			// Token: 0x1700270C RID: 9996
			// (get) Token: 0x0600C23D RID: 49725 RVA: 0x0035F1BC File Offset: 0x0035D3BC
			// (set) Token: 0x0600C23E RID: 49726 RVA: 0x0035F1CC File Offset: 0x0035D3CC
			public GameObject m_heroStar
			{
				get
				{
					return this.m_owner.m_heroStar;
				}
				set
				{
					this.m_owner.m_heroStar = value;
				}
			}

			// Token: 0x1700270D RID: 9997
			// (get) Token: 0x0600C23F RID: 49727 RVA: 0x0035F1DC File Offset: 0x0035D3DC
			// (set) Token: 0x0600C240 RID: 49728 RVA: 0x0035F1EC File Offset: 0x0035D3EC
			public Image m_heroTypeImg
			{
				get
				{
					return this.m_owner.m_heroTypeImg;
				}
				set
				{
					this.m_owner.m_heroTypeImg = value;
				}
			}

			// Token: 0x1700270E RID: 9998
			// (get) Token: 0x0600C241 RID: 49729 RVA: 0x0035F1FC File Offset: 0x0035D3FC
			// (set) Token: 0x0600C242 RID: 49730 RVA: 0x0035F20C File Offset: 0x0035D40C
			public Text m_heroLvText
			{
				get
				{
					return this.m_owner.m_heroLvText;
				}
				set
				{
					this.m_owner.m_heroLvText = value;
				}
			}

			// Token: 0x1700270F RID: 9999
			// (get) Token: 0x0600C243 RID: 49731 RVA: 0x0035F21C File Offset: 0x0035D41C
			// (set) Token: 0x0600C244 RID: 49732 RVA: 0x0035F22C File Offset: 0x0035D42C
			public GameObject m_heroSSRFrameEffect
			{
				get
				{
					return this.m_owner.m_heroSSRFrameEffect;
				}
				set
				{
					this.m_owner.m_heroSSRFrameEffect = value;
				}
			}

			// Token: 0x17002710 RID: 10000
			// (get) Token: 0x0600C245 RID: 49733 RVA: 0x0035F23C File Offset: 0x0035D43C
			// (set) Token: 0x0600C246 RID: 49734 RVA: 0x0035F24C File Offset: 0x0035D44C
			public Image m_heroFrameImg
			{
				get
				{
					return this.m_owner.m_heroFrameImg;
				}
				set
				{
					this.m_owner.m_heroFrameImg = value;
				}
			}

			// Token: 0x17002711 RID: 10001
			// (get) Token: 0x0600C247 RID: 49735 RVA: 0x0035F25C File Offset: 0x0035D45C
			// (set) Token: 0x0600C248 RID: 49736 RVA: 0x0035F26C File Offset: 0x0035D46C
			public Image m_heroIconImg
			{
				get
				{
					return this.m_owner.m_heroIconImg;
				}
				set
				{
					this.m_owner.m_heroIconImg = value;
				}
			}

			// Token: 0x17002712 RID: 10002
			// (get) Token: 0x0600C249 RID: 49737 RVA: 0x0035F27C File Offset: 0x0035D47C
			// (set) Token: 0x0600C24A RID: 49738 RVA: 0x0035F28C File Offset: 0x0035D48C
			public Text m_heroIndexText
			{
				get
				{
					return this.m_owner.m_heroIndexText;
				}
				set
				{
					this.m_owner.m_heroIndexText = value;
				}
			}

			// Token: 0x17002713 RID: 10003
			// (get) Token: 0x0600C24B RID: 49739 RVA: 0x0035F29C File Offset: 0x0035D49C
			// (set) Token: 0x0600C24C RID: 49740 RVA: 0x0035F2AC File Offset: 0x0035D4AC
			public int m_heroPositionIndex
			{
				get
				{
					return this.m_owner.m_heroPositionIndex;
				}
				set
				{
					this.m_owner.m_heroPositionIndex = value;
				}
			}

			// Token: 0x17002714 RID: 10004
			// (get) Token: 0x0600C24D RID: 49741 RVA: 0x0035F2BC File Offset: 0x0035D4BC
			// (set) Token: 0x0600C24E RID: 49742 RVA: 0x0035F2CC File Offset: 0x0035D4CC
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

			// Token: 0x17002715 RID: 10005
			// (get) Token: 0x0600C24F RID: 49743 RVA: 0x0035F2DC File Offset: 0x0035D4DC
			// (set) Token: 0x0600C250 RID: 49744 RVA: 0x0035F2EC File Offset: 0x0035D4EC
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

			// Token: 0x0600C251 RID: 49745 RVA: 0x0035F2FC File Offset: 0x0035D4FC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C252 RID: 49746 RVA: 0x0035F30C File Offset: 0x0035D50C
			public void OnHeroItemClick()
			{
				this.m_owner.OnHeroItemClick();
			}

			// Token: 0x04007B87 RID: 31623
			private BusinessCardHeroListItemUIController m_owner;
		}
	}
}
