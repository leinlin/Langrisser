using System;
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
	// Token: 0x02000F1D RID: 3869
	[HotFix]
	public class StoreHeroSkinItemUIController : UIControllerBase
	{
		// Token: 0x060132C8 RID: 78536 RVA: 0x004E2C6C File Offset: 0x004E0E6C
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
			this.m_storeItemButton.onClick.AddListener(new UnityAction(this.OnStoreItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x060132C9 RID: 78537 RVA: 0x004E2CFC File Offset: 0x004E0EFC
		public void SetHeroSkinItemInfo(FixedStoreItem fixedStoreItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroSkinItemInfoFixedStoreItem_hotfix != null)
			{
				this.m_SetHeroSkinItemInfoFixedStoreItem_hotfix.call(new object[]
				{
					this,
					fixedStoreItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItem.Id);
			if (configDataFixedStoreItemInfo != null && configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_HeroSkin)
			{
				this.m_storeItemConfig = configDataFixedStoreItemInfo;
				this.m_storeType = StoreType.StoreType_Static;
				ConfigDataHeroSkinInfo configDataHeroSkinInfo = this.m_configDataLoader.GetConfigDataHeroSkinInfo(this.m_storeItemConfig.ItemId);
				ConfigDataCharImageSkinResourceInfo configDataCharImageSkinResourceInfo = this.m_configDataLoader.GetConfigDataCharImageSkinResourceInfo(configDataHeroSkinInfo.CharImageSkinResource_ID);
				this.m_heroSkinIcon.sprite = AssetUtility.Instance.GetSprite(configDataCharImageSkinResourceInfo.Image);
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(configDataHeroSkinInfo.SpecifiedHero);
				this.m_heroName.text = configDataHeroInfo.Name;
				this.m_skinName.text = this.m_storeItemConfig.Name;
				this.m_priceText.text = this.m_storeItemConfig.NormalPrice.ToString();
				this.SetItemState();
				base.gameObject.SetActive(true);
			}
		}

		// Token: 0x060132CA RID: 78538 RVA: 0x004E2E54 File Offset: 0x004E1054
		public void SetItemState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetItemState_hotfix != null)
			{
				this.m_SetItemState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_playerContext.HasOwn(GoodsType.GoodsType_HeroSkin, this.m_storeItemConfig.ItemId);
			this.m_itemStateCtrl.SetToUIState((!flag) ? "Normal" : "Get", false, true);
		}

		// Token: 0x060132CB RID: 78539 RVA: 0x004E2EF0 File Offset: 0x004E10F0
		public void SetLimitTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLimitTime_hotfix != null)
			{
				this.m_SetLimitTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_storeItemConfig == null)
			{
				return;
			}
			if (this.m_playerContext.HasOwn(GoodsType.GoodsType_HeroSkin, this.m_storeItemConfig.ItemId))
			{
				this.m_timeGo.SetActive(false);
				return;
			}
			DateTime dateTime = DateTime.Parse(this.m_storeItemConfig.ShowEndTime);
			if (dateTime == DateTime.Parse(DateTime.MaxValue.ToString()))
			{
				this.m_timeGo.SetActive(false);
				return;
			}
			this.m_timeGo.SetActive(true);
			TimeSpan timeSpan = dateTime - this.m_playerContext.GetServerTime();
			if (timeSpan.Days >= 1)
			{
				string arg = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Day);
				this.m_timeValueText.text = timeSpan.Days + arg;
			}
			else
			{
				this.m_timeValueText.text = UIUtility.TimeSpanToString2(timeSpan);
				if (dateTime < this.m_playerContext.GetServerTime())
				{
					this.m_timeGo.SetActive(false);
					if (this.EventOnSkinItemOutOfDate != null)
					{
						this.EventOnSkinItemOutOfDate();
					}
				}
			}
		}

		// Token: 0x060132CC RID: 78540 RVA: 0x004E3070 File Offset: 0x004E1270
		private void OnStoreItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStoreItemClick_hotfix != null)
			{
				this.m_OnStoreItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x1400042B RID: 1067
		// (add) Token: 0x060132CD RID: 78541 RVA: 0x004E30E8 File Offset: 0x004E12E8
		// (remove) Token: 0x060132CE RID: 78542 RVA: 0x004E3184 File Offset: 0x004E1384
		public event Action<StoreHeroSkinItemUIController> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreHeroSkinItemUIController> action = this.EventOnClick;
				Action<StoreHeroSkinItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreHeroSkinItemUIController>>(ref this.EventOnClick, (Action<StoreHeroSkinItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreHeroSkinItemUIController> action = this.EventOnClick;
				Action<StoreHeroSkinItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreHeroSkinItemUIController>>(ref this.EventOnClick, (Action<StoreHeroSkinItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400042C RID: 1068
		// (add) Token: 0x060132CF RID: 78543 RVA: 0x004E3220 File Offset: 0x004E1420
		// (remove) Token: 0x060132D0 RID: 78544 RVA: 0x004E32BC File Offset: 0x004E14BC
		public event Action EventOnSkinItemOutOfDate
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkinItemOutOfDateAction_hotfix != null)
				{
					this.m_add_EventOnSkinItemOutOfDateAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkinItemOutOfDate;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkinItemOutOfDate, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkinItemOutOfDateAction_hotfix != null)
				{
					this.m_remove_EventOnSkinItemOutOfDateAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkinItemOutOfDate;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkinItemOutOfDate, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x060132D1 RID: 78545 RVA: 0x004E3358 File Offset: 0x004E1558
		// (set) Token: 0x060132D2 RID: 78546 RVA: 0x004E3378 File Offset: 0x004E1578
		[DoNotToLua]
		public new StoreHeroSkinItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new StoreHeroSkinItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060132D3 RID: 78547 RVA: 0x004E3384 File Offset: 0x004E1584
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060132D4 RID: 78548 RVA: 0x004E3390 File Offset: 0x004E1590
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060132D5 RID: 78549 RVA: 0x004E3398 File Offset: 0x004E1598
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060132D6 RID: 78550 RVA: 0x004E33A0 File Offset: 0x004E15A0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060132D7 RID: 78551 RVA: 0x004E33B4 File Offset: 0x004E15B4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060132D8 RID: 78552 RVA: 0x004E33BC File Offset: 0x004E15BC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060132D9 RID: 78553 RVA: 0x004E33C8 File Offset: 0x004E15C8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060132DA RID: 78554 RVA: 0x004E33D4 File Offset: 0x004E15D4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060132DB RID: 78555 RVA: 0x004E33E0 File Offset: 0x004E15E0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060132DC RID: 78556 RVA: 0x004E33EC File Offset: 0x004E15EC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060132DD RID: 78557 RVA: 0x004E33F8 File Offset: 0x004E15F8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060132DE RID: 78558 RVA: 0x004E3404 File Offset: 0x004E1604
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060132DF RID: 78559 RVA: 0x004E3410 File Offset: 0x004E1610
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060132E0 RID: 78560 RVA: 0x004E341C File Offset: 0x004E161C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060132E1 RID: 78561 RVA: 0x004E3428 File Offset: 0x004E1628
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060132E2 RID: 78562 RVA: 0x004E3430 File Offset: 0x004E1630
		private void __callDele_EventOnClick(StoreHeroSkinItemUIController obj)
		{
			Action<StoreHeroSkinItemUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x060132E3 RID: 78563 RVA: 0x004E3454 File Offset: 0x004E1654
		private void __clearDele_EventOnClick(StoreHeroSkinItemUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x060132E4 RID: 78564 RVA: 0x004E3460 File Offset: 0x004E1660
		private void __callDele_EventOnSkinItemOutOfDate()
		{
			Action eventOnSkinItemOutOfDate = this.EventOnSkinItemOutOfDate;
			if (eventOnSkinItemOutOfDate != null)
			{
				eventOnSkinItemOutOfDate();
			}
		}

		// Token: 0x060132E5 RID: 78565 RVA: 0x004E3480 File Offset: 0x004E1680
		private void __clearDele_EventOnSkinItemOutOfDate()
		{
			this.EventOnSkinItemOutOfDate = null;
		}

		// Token: 0x060132E6 RID: 78566 RVA: 0x004E348C File Offset: 0x004E168C
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
					this.m_SetHeroSkinItemInfoFixedStoreItem_hotfix = (luaObj.RawGet("SetHeroSkinItemInfo") as LuaFunction);
					this.m_SetItemState_hotfix = (luaObj.RawGet("SetItemState") as LuaFunction);
					this.m_SetLimitTime_hotfix = (luaObj.RawGet("SetLimitTime") as LuaFunction);
					this.m_OnStoreItemClick_hotfix = (luaObj.RawGet("OnStoreItemClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					this.m_add_EventOnSkinItemOutOfDateAction_hotfix = (luaObj.RawGet("add_EventOnSkinItemOutOfDate") as LuaFunction);
					this.m_remove_EventOnSkinItemOutOfDateAction_hotfix = (luaObj.RawGet("remove_EventOnSkinItemOutOfDate") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060132E7 RID: 78567 RVA: 0x004E3620 File Offset: 0x004E1820
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(StoreHeroSkinItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AAAB RID: 43691
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		public Button m_storeItemButton;

		// Token: 0x0400AAAC RID: 43692
		[AutoBind("./HeroIcon", AutoBindAttribute.InitState.NotInit, false)]
		public Image m_heroSkinIcon;

		// Token: 0x0400AAAD RID: 43693
		[AutoBind("./HeroNameText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_heroName;

		// Token: 0x0400AAAE RID: 43694
		[AutoBind("./OtherNameText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_skinName;

		// Token: 0x0400AAAF RID: 43695
		[AutoBind("./PricePanel/PriceText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_priceText;

		// Token: 0x0400AAB0 RID: 43696
		[AutoBind("./Tape/TSurplusText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_restTime;

		// Token: 0x0400AAB1 RID: 43697
		[AutoBind("./TimeLimit", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_timeGo;

		// Token: 0x0400AAB2 RID: 43698
		[AutoBind("./TimeLimit/TimeValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_timeValueText;

		// Token: 0x0400AAB3 RID: 43699
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController m_itemStateCtrl;

		// Token: 0x0400AAB4 RID: 43700
		public ConfigDataFixedStoreItemInfo m_storeItemConfig;

		// Token: 0x0400AAB5 RID: 43701
		public StoreType m_storeType;

		// Token: 0x0400AAB6 RID: 43702
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400AAB7 RID: 43703
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400AAB8 RID: 43704
		[DoNotToLua]
		private StoreHeroSkinItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AAB9 RID: 43705
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AABA RID: 43706
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AABB RID: 43707
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AABC RID: 43708
		private LuaFunction m_SetHeroSkinItemInfoFixedStoreItem_hotfix;

		// Token: 0x0400AABD RID: 43709
		private LuaFunction m_SetItemState_hotfix;

		// Token: 0x0400AABE RID: 43710
		private LuaFunction m_SetLimitTime_hotfix;

		// Token: 0x0400AABF RID: 43711
		private LuaFunction m_OnStoreItemClick_hotfix;

		// Token: 0x0400AAC0 RID: 43712
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400AAC1 RID: 43713
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x0400AAC2 RID: 43714
		private LuaFunction m_add_EventOnSkinItemOutOfDateAction_hotfix;

		// Token: 0x0400AAC3 RID: 43715
		private LuaFunction m_remove_EventOnSkinItemOutOfDateAction_hotfix;

		// Token: 0x02000F1E RID: 3870
		public new class LuaExportHelper
		{
			// Token: 0x060132E8 RID: 78568 RVA: 0x004E3688 File Offset: 0x004E1888
			public LuaExportHelper(StoreHeroSkinItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060132E9 RID: 78569 RVA: 0x004E3698 File Offset: 0x004E1898
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060132EA RID: 78570 RVA: 0x004E36A8 File Offset: 0x004E18A8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060132EB RID: 78571 RVA: 0x004E36B8 File Offset: 0x004E18B8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060132EC RID: 78572 RVA: 0x004E36C8 File Offset: 0x004E18C8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060132ED RID: 78573 RVA: 0x004E36E0 File Offset: 0x004E18E0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060132EE RID: 78574 RVA: 0x004E36F0 File Offset: 0x004E18F0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060132EF RID: 78575 RVA: 0x004E3700 File Offset: 0x004E1900
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060132F0 RID: 78576 RVA: 0x004E3710 File Offset: 0x004E1910
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060132F1 RID: 78577 RVA: 0x004E3720 File Offset: 0x004E1920
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060132F2 RID: 78578 RVA: 0x004E3730 File Offset: 0x004E1930
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060132F3 RID: 78579 RVA: 0x004E3740 File Offset: 0x004E1940
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060132F4 RID: 78580 RVA: 0x004E3750 File Offset: 0x004E1950
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060132F5 RID: 78581 RVA: 0x004E3760 File Offset: 0x004E1960
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060132F6 RID: 78582 RVA: 0x004E3770 File Offset: 0x004E1970
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060132F7 RID: 78583 RVA: 0x004E3780 File Offset: 0x004E1980
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060132F8 RID: 78584 RVA: 0x004E3790 File Offset: 0x004E1990
			public void __callDele_EventOnClick(StoreHeroSkinItemUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x060132F9 RID: 78585 RVA: 0x004E37A0 File Offset: 0x004E19A0
			public void __clearDele_EventOnClick(StoreHeroSkinItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x060132FA RID: 78586 RVA: 0x004E37B0 File Offset: 0x004E19B0
			public void __callDele_EventOnSkinItemOutOfDate()
			{
				this.m_owner.__callDele_EventOnSkinItemOutOfDate();
			}

			// Token: 0x060132FB RID: 78587 RVA: 0x004E37C0 File Offset: 0x004E19C0
			public void __clearDele_EventOnSkinItemOutOfDate()
			{
				this.m_owner.__clearDele_EventOnSkinItemOutOfDate();
			}

			// Token: 0x170039BE RID: 14782
			// (get) Token: 0x060132FC RID: 78588 RVA: 0x004E37D0 File Offset: 0x004E19D0
			// (set) Token: 0x060132FD RID: 78589 RVA: 0x004E37E0 File Offset: 0x004E19E0
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

			// Token: 0x170039BF RID: 14783
			// (get) Token: 0x060132FE RID: 78590 RVA: 0x004E37F0 File Offset: 0x004E19F0
			// (set) Token: 0x060132FF RID: 78591 RVA: 0x004E3800 File Offset: 0x004E1A00
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

			// Token: 0x06013300 RID: 78592 RVA: 0x004E3810 File Offset: 0x004E1A10
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013301 RID: 78593 RVA: 0x004E3820 File Offset: 0x004E1A20
			public void OnStoreItemClick()
			{
				this.m_owner.OnStoreItemClick();
			}

			// Token: 0x0400AAC4 RID: 43716
			private StoreHeroSkinItemUIController m_owner;
		}
	}
}
