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
	// Token: 0x02000B0C RID: 2828
	[HotFix]
	public class ARHeroCardUIController : UIControllerBase
	{
		// Token: 0x0600BE20 RID: 48672 RVA: 0x00352228 File Offset: 0x00350428
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
			this.m_heroItemButton.onClick.AddListener(new UnityAction(this.OnHeroItemClick));
		}

		// Token: 0x0600BE21 RID: 48673 RVA: 0x003522C0 File Offset: 0x003504C0
		public void SetHeroListItemInfo(ARHeroListUIController.HeroWrap heroWrap)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroListItemInfoHeroWrap_hotfix != null)
			{
				this.m_SetHeroListItemInfoHeroWrap_hotfix.call(new object[]
				{
					this,
					heroWrap
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = heroWrap.hero;
			if (hero.HeroInfo != null)
			{
				this.m_heroWrap = heroWrap;
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
				base.gameObject.SetActive(true);
				this.RefreshHeroSelect();
			}
		}

		// Token: 0x0600BE22 RID: 48674 RVA: 0x00352454 File Offset: 0x00350654
		public void RefreshHeroSelect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshHeroSelect_hotfix != null)
			{
				this.m_RefreshHeroSelect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroSelectFrame.SetActive(this.m_heroWrap.isSelect);
			this.m_heroSelectFront.SetActive(this.m_heroWrap.isSelect);
		}

		// Token: 0x0600BE23 RID: 48675 RVA: 0x003524E0 File Offset: 0x003506E0
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

		// Token: 0x14000249 RID: 585
		// (add) Token: 0x0600BE24 RID: 48676 RVA: 0x00352558 File Offset: 0x00350758
		// (remove) Token: 0x0600BE25 RID: 48677 RVA: 0x003525F4 File Offset: 0x003507F4
		public event Action<ARHeroCardUIController> EventOnSelectHeroItem
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
				Action<ARHeroCardUIController> action = this.EventOnSelectHeroItem;
				Action<ARHeroCardUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ARHeroCardUIController>>(ref this.EventOnSelectHeroItem, (Action<ARHeroCardUIController>)Delegate.Combine(action2, value), action);
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
				Action<ARHeroCardUIController> action = this.EventOnSelectHeroItem;
				Action<ARHeroCardUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ARHeroCardUIController>>(ref this.EventOnSelectHeroItem, (Action<ARHeroCardUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x0600BE26 RID: 48678 RVA: 0x00352690 File Offset: 0x00350890
		// (set) Token: 0x0600BE27 RID: 48679 RVA: 0x003526B0 File Offset: 0x003508B0
		[DoNotToLua]
		public new ARHeroCardUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ARHeroCardUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BE28 RID: 48680 RVA: 0x003526BC File Offset: 0x003508BC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600BE29 RID: 48681 RVA: 0x003526C8 File Offset: 0x003508C8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600BE2A RID: 48682 RVA: 0x003526D0 File Offset: 0x003508D0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600BE2B RID: 48683 RVA: 0x003526D8 File Offset: 0x003508D8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600BE2C RID: 48684 RVA: 0x003526EC File Offset: 0x003508EC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600BE2D RID: 48685 RVA: 0x003526F4 File Offset: 0x003508F4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600BE2E RID: 48686 RVA: 0x00352700 File Offset: 0x00350900
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600BE2F RID: 48687 RVA: 0x0035270C File Offset: 0x0035090C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600BE30 RID: 48688 RVA: 0x00352718 File Offset: 0x00350918
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600BE31 RID: 48689 RVA: 0x00352724 File Offset: 0x00350924
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600BE32 RID: 48690 RVA: 0x00352730 File Offset: 0x00350930
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x0035273C File Offset: 0x0035093C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600BE34 RID: 48692 RVA: 0x00352748 File Offset: 0x00350948
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600BE35 RID: 48693 RVA: 0x00352754 File Offset: 0x00350954
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600BE36 RID: 48694 RVA: 0x00352760 File Offset: 0x00350960
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600BE37 RID: 48695 RVA: 0x00352768 File Offset: 0x00350968
		private void __callDele_EventOnSelectHeroItem(ARHeroCardUIController obj)
		{
			Action<ARHeroCardUIController> eventOnSelectHeroItem = this.EventOnSelectHeroItem;
			if (eventOnSelectHeroItem != null)
			{
				eventOnSelectHeroItem(obj);
			}
		}

		// Token: 0x0600BE38 RID: 48696 RVA: 0x0035278C File Offset: 0x0035098C
		private void __clearDele_EventOnSelectHeroItem(ARHeroCardUIController obj)
		{
			this.EventOnSelectHeroItem = null;
		}

		// Token: 0x0600BE39 RID: 48697 RVA: 0x00352798 File Offset: 0x00350998
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
					this.m_SetHeroListItemInfoHeroWrap_hotfix = (luaObj.RawGet("SetHeroListItemInfo") as LuaFunction);
					this.m_RefreshHeroSelect_hotfix = (luaObj.RawGet("RefreshHeroSelect") as LuaFunction);
					this.m_OnHeroItemClick_hotfix = (luaObj.RawGet("OnHeroItemClick") as LuaFunction);
					this.m_add_EventOnSelectHeroItemAction`1_hotfix = (luaObj.RawGet("add_EventOnSelectHeroItem") as LuaFunction);
					this.m_remove_EventOnSelectHeroItemAction`1_hotfix = (luaObj.RawGet("remove_EventOnSelectHeroItem") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BE3A RID: 48698 RVA: 0x003528E0 File Offset: 0x00350AE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ARHeroCardUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040079C3 RID: 31171
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroItemButton;

		// Token: 0x040079C4 RID: 31172
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_heroItemUIStateController;

		// Token: 0x040079C5 RID: 31173
		[AutoBind("./HeroStars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroStar;

		// Token: 0x040079C6 RID: 31174
		[AutoBind("./HeroTypeImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroTypeImg;

		// Token: 0x040079C7 RID: 31175
		[AutoBind("./HeroLvText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroLvText;

		// Token: 0x040079C8 RID: 31176
		[AutoBind("./SSRFrameEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroSSRFrameEffect;

		// Token: 0x040079C9 RID: 31177
		[AutoBind("./FrameImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroFrameImg;

		// Token: 0x040079CA RID: 31178
		[AutoBind("./HeroIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroIconImg;

		// Token: 0x040079CB RID: 31179
		[AutoBind("./ARSelectFrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroSelectFrame;

		// Token: 0x040079CC RID: 31180
		[AutoBind("./ARSelectFrontImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroSelectFront;

		// Token: 0x040079CD RID: 31181
		public ARHeroListUIController.HeroWrap m_heroWrap;

		// Token: 0x040079CE RID: 31182
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040079CF RID: 31183
		[DoNotToLua]
		private ARHeroCardUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040079D0 RID: 31184
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040079D1 RID: 31185
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040079D2 RID: 31186
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040079D3 RID: 31187
		private LuaFunction m_SetHeroListItemInfoHeroWrap_hotfix;

		// Token: 0x040079D4 RID: 31188
		private LuaFunction m_RefreshHeroSelect_hotfix;

		// Token: 0x040079D5 RID: 31189
		private LuaFunction m_OnHeroItemClick_hotfix;

		// Token: 0x040079D6 RID: 31190
		private LuaFunction m_add_EventOnSelectHeroItemAction;

		// Token: 0x040079D7 RID: 31191
		private LuaFunction m_remove_EventOnSelectHeroItemAction;

		// Token: 0x02000B0D RID: 2829
		public new class LuaExportHelper
		{
			// Token: 0x0600BE3B RID: 48699 RVA: 0x00352948 File Offset: 0x00350B48
			public LuaExportHelper(ARHeroCardUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600BE3C RID: 48700 RVA: 0x00352958 File Offset: 0x00350B58
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600BE3D RID: 48701 RVA: 0x00352968 File Offset: 0x00350B68
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600BE3E RID: 48702 RVA: 0x00352978 File Offset: 0x00350B78
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600BE3F RID: 48703 RVA: 0x00352988 File Offset: 0x00350B88
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600BE40 RID: 48704 RVA: 0x003529A0 File Offset: 0x00350BA0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600BE41 RID: 48705 RVA: 0x003529B0 File Offset: 0x00350BB0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600BE42 RID: 48706 RVA: 0x003529C0 File Offset: 0x00350BC0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600BE43 RID: 48707 RVA: 0x003529D0 File Offset: 0x00350BD0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600BE44 RID: 48708 RVA: 0x003529E0 File Offset: 0x00350BE0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600BE45 RID: 48709 RVA: 0x003529F0 File Offset: 0x00350BF0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600BE46 RID: 48710 RVA: 0x00352A00 File Offset: 0x00350C00
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600BE47 RID: 48711 RVA: 0x00352A10 File Offset: 0x00350C10
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600BE48 RID: 48712 RVA: 0x00352A20 File Offset: 0x00350C20
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600BE49 RID: 48713 RVA: 0x00352A30 File Offset: 0x00350C30
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600BE4A RID: 48714 RVA: 0x00352A40 File Offset: 0x00350C40
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600BE4B RID: 48715 RVA: 0x00352A50 File Offset: 0x00350C50
			public void __callDele_EventOnSelectHeroItem(ARHeroCardUIController obj)
			{
				this.m_owner.__callDele_EventOnSelectHeroItem(obj);
			}

			// Token: 0x0600BE4C RID: 48716 RVA: 0x00352A60 File Offset: 0x00350C60
			public void __clearDele_EventOnSelectHeroItem(ARHeroCardUIController obj)
			{
				this.m_owner.__clearDele_EventOnSelectHeroItem(obj);
			}

			// Token: 0x17002628 RID: 9768
			// (get) Token: 0x0600BE4D RID: 48717 RVA: 0x00352A70 File Offset: 0x00350C70
			// (set) Token: 0x0600BE4E RID: 48718 RVA: 0x00352A80 File Offset: 0x00350C80
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

			// Token: 0x17002629 RID: 9769
			// (get) Token: 0x0600BE4F RID: 48719 RVA: 0x00352A90 File Offset: 0x00350C90
			// (set) Token: 0x0600BE50 RID: 48720 RVA: 0x00352AA0 File Offset: 0x00350CA0
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

			// Token: 0x1700262A RID: 9770
			// (get) Token: 0x0600BE51 RID: 48721 RVA: 0x00352AB0 File Offset: 0x00350CB0
			// (set) Token: 0x0600BE52 RID: 48722 RVA: 0x00352AC0 File Offset: 0x00350CC0
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

			// Token: 0x1700262B RID: 9771
			// (get) Token: 0x0600BE53 RID: 48723 RVA: 0x00352AD0 File Offset: 0x00350CD0
			// (set) Token: 0x0600BE54 RID: 48724 RVA: 0x00352AE0 File Offset: 0x00350CE0
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

			// Token: 0x1700262C RID: 9772
			// (get) Token: 0x0600BE55 RID: 48725 RVA: 0x00352AF0 File Offset: 0x00350CF0
			// (set) Token: 0x0600BE56 RID: 48726 RVA: 0x00352B00 File Offset: 0x00350D00
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

			// Token: 0x1700262D RID: 9773
			// (get) Token: 0x0600BE57 RID: 48727 RVA: 0x00352B10 File Offset: 0x00350D10
			// (set) Token: 0x0600BE58 RID: 48728 RVA: 0x00352B20 File Offset: 0x00350D20
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

			// Token: 0x1700262E RID: 9774
			// (get) Token: 0x0600BE59 RID: 48729 RVA: 0x00352B30 File Offset: 0x00350D30
			// (set) Token: 0x0600BE5A RID: 48730 RVA: 0x00352B40 File Offset: 0x00350D40
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

			// Token: 0x1700262F RID: 9775
			// (get) Token: 0x0600BE5B RID: 48731 RVA: 0x00352B50 File Offset: 0x00350D50
			// (set) Token: 0x0600BE5C RID: 48732 RVA: 0x00352B60 File Offset: 0x00350D60
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

			// Token: 0x17002630 RID: 9776
			// (get) Token: 0x0600BE5D RID: 48733 RVA: 0x00352B70 File Offset: 0x00350D70
			// (set) Token: 0x0600BE5E RID: 48734 RVA: 0x00352B80 File Offset: 0x00350D80
			public GameObject m_heroSelectFrame
			{
				get
				{
					return this.m_owner.m_heroSelectFrame;
				}
				set
				{
					this.m_owner.m_heroSelectFrame = value;
				}
			}

			// Token: 0x17002631 RID: 9777
			// (get) Token: 0x0600BE5F RID: 48735 RVA: 0x00352B90 File Offset: 0x00350D90
			// (set) Token: 0x0600BE60 RID: 48736 RVA: 0x00352BA0 File Offset: 0x00350DA0
			public GameObject m_heroSelectFront
			{
				get
				{
					return this.m_owner.m_heroSelectFront;
				}
				set
				{
					this.m_owner.m_heroSelectFront = value;
				}
			}

			// Token: 0x17002632 RID: 9778
			// (get) Token: 0x0600BE61 RID: 48737 RVA: 0x00352BB0 File Offset: 0x00350DB0
			// (set) Token: 0x0600BE62 RID: 48738 RVA: 0x00352BC0 File Offset: 0x00350DC0
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

			// Token: 0x0600BE63 RID: 48739 RVA: 0x00352BD0 File Offset: 0x00350DD0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600BE64 RID: 48740 RVA: 0x00352BE0 File Offset: 0x00350DE0
			public void OnHeroItemClick()
			{
				this.m_owner.OnHeroItemClick();
			}

			// Token: 0x040079D8 RID: 31192
			private ARHeroCardUIController m_owner;
		}
	}
}
