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
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EFE RID: 3838
	[HotFix]
	public class SelectRewardsItemUIController : UIControllerBase, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06012FEB RID: 77803 RVA: 0x004DA048 File Offset: 0x004D8248
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
			base.gameObject.SetActive(true);
		}

		// Token: 0x06012FEC RID: 77804 RVA: 0x004DA0BC File Offset: 0x004D82BC
		public void InitSelectRewardsInfo(Goods goods, bool isNew, bool isFragment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSelectRewardsInfoGoodsBooleanBoolean_hotfix != null)
			{
				this.m_InitSelectRewardsInfoGoodsBooleanBoolean_hotfix.call(new object[]
				{
					this,
					goods,
					isNew,
					isFragment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_text.text = goods.Count.ToString();
			this.m_goods = goods;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			string name = null;
			string name2 = null;
			int num = 0;
			int rank = 0;
			this.m_icon.gameObject.transform.localScale = Vector3.one;
			this.m_fragmentItemID = 0;
			this.m_stars.gameObject.SetActive(true);
			switch (goods.GoodsType)
			{
			case GoodsType.GoodsType_Hero:
			{
				Hero hero = projectLPlayerContext.GetHero(goods.Id);
				if (hero != null)
				{
					ConfigDataHeroInfo heroInfo = hero.HeroInfo;
					rank = heroInfo.GetRank(hero.StarLevel);
					num = hero.StarLevel;
					if (isFragment)
					{
						this.m_text.text = heroInfo.ExchangedFragmentCount.ToString();
						this.m_fragmentItemID = heroInfo.FragmentItem_ID;
						name = UIUtility.GetGoodsIconName(GoodsType.GoodsType_Item, heroInfo.FragmentItem_ID);
						name2 = UIUtility.GetGoodsIconMaterialName(GoodsType.GoodsType_Item, heroInfo.FragmentItem_ID);
						this.m_stars.gameObject.SetActive(false);
					}
					else
					{
						ConfigDataCharImageInfo charImageInfo = heroInfo.GetCharImageInfo(heroInfo.Star);
						if (charImageInfo != null)
						{
							name = charImageInfo.SummonHeadImage;
							name2 = "UI/Icon/Card_ABS/Material/CardIcon.mat";
						}
					}
					this.m_frame.gameObject.SetActive(false);
					this.m_icon.gameObject.transform.localScale *= 1.3f;
				}
				break;
			}
			case GoodsType.GoodsType_JobMaterial:
			{
				ConfigDataJobMaterialInfo configDataJobMaterialInfo = configDataLoader.GetConfigDataJobMaterialInfo(goods.Id);
				name = configDataJobMaterialInfo.Icon;
				rank = configDataJobMaterialInfo.Rank;
				num = 0;
				break;
			}
			case GoodsType.GoodsType_Item:
			{
				ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goods.Id);
				isFragment = (configDataItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_HeroFragment);
				name = configDataItemInfo.Icon;
				rank = configDataItemInfo.Rank;
				num = 0;
				break;
			}
			case GoodsType.GoodsType_Equipment:
			{
				ConfigDataEquipmentInfo configDataEquipmentInfo = configDataLoader.GetConfigDataEquipmentInfo(goods.Id);
				name = configDataEquipmentInfo.Icon;
				rank = configDataEquipmentInfo.Rank;
				num = configDataEquipmentInfo.BornStarLevel;
				break;
			}
			}
			this.m_icon.sprite = AssetUtility.Instance.GetSprite(name);
			this.m_icon.material = AssetUtility.Instance.GetAsset<Material>(name2);
			this.m_frame.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(rank));
			UIUtility.SetGameObjectChildrenActiveCount(this.m_stars, num);
			this.m_new.SetActive(isNew);
			this.m_ssrEffect.SetActive(UIUtility.IsRankSSR(rank) && !isFragment);
			this.m_ssrPieceEffect.SetActive(UIUtility.IsRankSSR(rank) && isFragment);
			this.m_text.gameObject.SetActive(goods.Count != 1 || isFragment);
		}

		// Token: 0x06012FED RID: 77805 RVA: 0x004DA474 File Offset: 0x004D8674
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_fragmentItemID > 0)
			{
				RewardGoodsDescUITask.StartUITask(this, GoodsType.GoodsType_Item, this.m_fragmentItemID, 0, null, true);
			}
			else
			{
				RewardGoodsDescUITask.StartUITask(this, this.m_goods.GoodsType, this.m_goods.Id, 0, null, true);
			}
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x06012FEE RID: 77806 RVA: 0x004DA528 File Offset: 0x004D8728
		// (set) Token: 0x06012FEF RID: 77807 RVA: 0x004DA548 File Offset: 0x004D8748
		[DoNotToLua]
		public new SelectRewardsItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SelectRewardsItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012FF0 RID: 77808 RVA: 0x004DA554 File Offset: 0x004D8754
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012FF1 RID: 77809 RVA: 0x004DA560 File Offset: 0x004D8760
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012FF2 RID: 77810 RVA: 0x004DA568 File Offset: 0x004D8768
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012FF3 RID: 77811 RVA: 0x004DA570 File Offset: 0x004D8770
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012FF4 RID: 77812 RVA: 0x004DA584 File Offset: 0x004D8784
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012FF5 RID: 77813 RVA: 0x004DA58C File Offset: 0x004D878C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012FF6 RID: 77814 RVA: 0x004DA598 File Offset: 0x004D8798
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012FF7 RID: 77815 RVA: 0x004DA5A4 File Offset: 0x004D87A4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012FF8 RID: 77816 RVA: 0x004DA5B0 File Offset: 0x004D87B0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012FF9 RID: 77817 RVA: 0x004DA5BC File Offset: 0x004D87BC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012FFA RID: 77818 RVA: 0x004DA5C8 File Offset: 0x004D87C8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012FFB RID: 77819 RVA: 0x004DA5D4 File Offset: 0x004D87D4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012FFC RID: 77820 RVA: 0x004DA5E0 File Offset: 0x004D87E0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012FFD RID: 77821 RVA: 0x004DA5EC File Offset: 0x004D87EC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012FFE RID: 77822 RVA: 0x004DA5F8 File Offset: 0x004D87F8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012FFF RID: 77823 RVA: 0x004DA600 File Offset: 0x004D8800
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
					this.m_InitSelectRewardsInfoGoodsBooleanBoolean_hotfix = (luaObj.RawGet("InitSelectRewardsInfo") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013000 RID: 77824 RVA: 0x004DA700 File Offset: 0x004D8900
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SelectRewardsItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A9AD RID: 43437
		[AutoBind("./Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_icon;

		// Token: 0x0400A9AE RID: 43438
		[AutoBind("./Frame", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_frame;

		// Token: 0x0400A9AF RID: 43439
		[AutoBind("./Stars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_stars;

		// Token: 0x0400A9B0 RID: 43440
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_text;

		// Token: 0x0400A9B1 RID: 43441
		[AutoBind("./New", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_new;

		// Token: 0x0400A9B2 RID: 43442
		[AutoBind("./SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_ssrEffect;

		// Token: 0x0400A9B3 RID: 43443
		[AutoBind("./SSRPieceEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_ssrPieceEffect;

		// Token: 0x0400A9B4 RID: 43444
		private Goods m_goods;

		// Token: 0x0400A9B5 RID: 43445
		private int m_fragmentItemID;

		// Token: 0x0400A9B6 RID: 43446
		[DoNotToLua]
		private SelectRewardsItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A9B7 RID: 43447
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A9B8 RID: 43448
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A9B9 RID: 43449
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A9BA RID: 43450
		private LuaFunction m_InitSelectRewardsInfoGoodsBooleanBoolean_hotfix;

		// Token: 0x0400A9BB RID: 43451
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x02000EFF RID: 3839
		public new class LuaExportHelper
		{
			// Token: 0x06013001 RID: 77825 RVA: 0x004DA768 File Offset: 0x004D8968
			public LuaExportHelper(SelectRewardsItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013002 RID: 77826 RVA: 0x004DA778 File Offset: 0x004D8978
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013003 RID: 77827 RVA: 0x004DA788 File Offset: 0x004D8988
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013004 RID: 77828 RVA: 0x004DA798 File Offset: 0x004D8998
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013005 RID: 77829 RVA: 0x004DA7A8 File Offset: 0x004D89A8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013006 RID: 77830 RVA: 0x004DA7C0 File Offset: 0x004D89C0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013007 RID: 77831 RVA: 0x004DA7D0 File Offset: 0x004D89D0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013008 RID: 77832 RVA: 0x004DA7E0 File Offset: 0x004D89E0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013009 RID: 77833 RVA: 0x004DA7F0 File Offset: 0x004D89F0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601300A RID: 77834 RVA: 0x004DA800 File Offset: 0x004D8A00
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601300B RID: 77835 RVA: 0x004DA810 File Offset: 0x004D8A10
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601300C RID: 77836 RVA: 0x004DA820 File Offset: 0x004D8A20
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601300D RID: 77837 RVA: 0x004DA830 File Offset: 0x004D8A30
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601300E RID: 77838 RVA: 0x004DA840 File Offset: 0x004D8A40
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601300F RID: 77839 RVA: 0x004DA850 File Offset: 0x004D8A50
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013010 RID: 77840 RVA: 0x004DA860 File Offset: 0x004D8A60
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003960 RID: 14688
			// (get) Token: 0x06013011 RID: 77841 RVA: 0x004DA870 File Offset: 0x004D8A70
			// (set) Token: 0x06013012 RID: 77842 RVA: 0x004DA880 File Offset: 0x004D8A80
			public Image m_icon
			{
				get
				{
					return this.m_owner.m_icon;
				}
				set
				{
					this.m_owner.m_icon = value;
				}
			}

			// Token: 0x17003961 RID: 14689
			// (get) Token: 0x06013013 RID: 77843 RVA: 0x004DA890 File Offset: 0x004D8A90
			// (set) Token: 0x06013014 RID: 77844 RVA: 0x004DA8A0 File Offset: 0x004D8AA0
			public Image m_frame
			{
				get
				{
					return this.m_owner.m_frame;
				}
				set
				{
					this.m_owner.m_frame = value;
				}
			}

			// Token: 0x17003962 RID: 14690
			// (get) Token: 0x06013015 RID: 77845 RVA: 0x004DA8B0 File Offset: 0x004D8AB0
			// (set) Token: 0x06013016 RID: 77846 RVA: 0x004DA8C0 File Offset: 0x004D8AC0
			public GameObject m_stars
			{
				get
				{
					return this.m_owner.m_stars;
				}
				set
				{
					this.m_owner.m_stars = value;
				}
			}

			// Token: 0x17003963 RID: 14691
			// (get) Token: 0x06013017 RID: 77847 RVA: 0x004DA8D0 File Offset: 0x004D8AD0
			// (set) Token: 0x06013018 RID: 77848 RVA: 0x004DA8E0 File Offset: 0x004D8AE0
			public Text m_text
			{
				get
				{
					return this.m_owner.m_text;
				}
				set
				{
					this.m_owner.m_text = value;
				}
			}

			// Token: 0x17003964 RID: 14692
			// (get) Token: 0x06013019 RID: 77849 RVA: 0x004DA8F0 File Offset: 0x004D8AF0
			// (set) Token: 0x0601301A RID: 77850 RVA: 0x004DA900 File Offset: 0x004D8B00
			public GameObject m_new
			{
				get
				{
					return this.m_owner.m_new;
				}
				set
				{
					this.m_owner.m_new = value;
				}
			}

			// Token: 0x17003965 RID: 14693
			// (get) Token: 0x0601301B RID: 77851 RVA: 0x004DA910 File Offset: 0x004D8B10
			// (set) Token: 0x0601301C RID: 77852 RVA: 0x004DA920 File Offset: 0x004D8B20
			public GameObject m_ssrEffect
			{
				get
				{
					return this.m_owner.m_ssrEffect;
				}
				set
				{
					this.m_owner.m_ssrEffect = value;
				}
			}

			// Token: 0x17003966 RID: 14694
			// (get) Token: 0x0601301D RID: 77853 RVA: 0x004DA930 File Offset: 0x004D8B30
			// (set) Token: 0x0601301E RID: 77854 RVA: 0x004DA940 File Offset: 0x004D8B40
			public GameObject m_ssrPieceEffect
			{
				get
				{
					return this.m_owner.m_ssrPieceEffect;
				}
				set
				{
					this.m_owner.m_ssrPieceEffect = value;
				}
			}

			// Token: 0x17003967 RID: 14695
			// (get) Token: 0x0601301F RID: 77855 RVA: 0x004DA950 File Offset: 0x004D8B50
			// (set) Token: 0x06013020 RID: 77856 RVA: 0x004DA960 File Offset: 0x004D8B60
			public Goods m_goods
			{
				get
				{
					return this.m_owner.m_goods;
				}
				set
				{
					this.m_owner.m_goods = value;
				}
			}

			// Token: 0x17003968 RID: 14696
			// (get) Token: 0x06013021 RID: 77857 RVA: 0x004DA970 File Offset: 0x004D8B70
			// (set) Token: 0x06013022 RID: 77858 RVA: 0x004DA980 File Offset: 0x004D8B80
			public int m_fragmentItemID
			{
				get
				{
					return this.m_owner.m_fragmentItemID;
				}
				set
				{
					this.m_owner.m_fragmentItemID = value;
				}
			}

			// Token: 0x06013023 RID: 77859 RVA: 0x004DA990 File Offset: 0x004D8B90
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400A9BC RID: 43452
			private SelectRewardsItemUIController m_owner;
		}
	}
}
