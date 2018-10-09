using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F42 RID: 3906
	[HotFix]
	public class StoreSoldierSkinItemUIController : UIControllerBase
	{
		// Token: 0x06013733 RID: 79667 RVA: 0x004F4B1C File Offset: 0x004F2D1C
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

		// Token: 0x06013734 RID: 79668 RVA: 0x004F4BAC File Offset: 0x004F2DAC
		public void SetSoldierSkinItemInfo(FixedStoreItem soldierSkinItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierSkinItemInfoFixedStoreItem_hotfix != null)
			{
				this.m_SetSoldierSkinItemInfoFixedStoreItem_hotfix.call(new object[]
				{
					this,
					soldierSkinItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(soldierSkinItem.Id);
			if (configDataFixedStoreItemInfo != null && configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_SoldierSkin)
			{
				this.m_storeItemConfig = configDataFixedStoreItemInfo;
				this.m_storeType = StoreType.StoreType_Static;
				ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = this.m_configDataLoader.GetConfigDataSoldierSkinInfo(this.m_storeItemConfig.ItemId);
				this.m_soldierName.text = this.m_storeItemConfig.Name;
				this.m_priceText.text = this.m_storeItemConfig.NormalPrice.ToString();
				this.SetSoldierSpineAnim(configDataSoldierSkinInfo);
				this.SetItemState();
				base.gameObject.SetActive(true);
			}
		}

		// Token: 0x06013735 RID: 79669 RVA: 0x004F4CBC File Offset: 0x004F2EBC
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
			bool flag = this.m_playerContext.HasOwn(GoodsType.GoodsType_SoldierSkin, this.m_storeItemConfig.ItemId);
			if (this.m_storeItemConfig.ShowEndTime != DateTime.MaxValue.ToString())
			{
				DateTime d = DateTime.Parse(this.m_storeItemConfig.ShowEndTime);
				this.m_restTime.text = string.Format("{0}{1}", this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_LeftDay), (d - this.m_playerContext.GetCurrServerTime()).Days);
				this.m_itemUIStateCtrl.SetToUIState((!flag) ? "Tape" : "GetAndTape", false, true);
			}
			else
			{
				this.m_itemUIStateCtrl.SetToUIState((!flag) ? "Normal" : "Get", false, true);
			}
		}

		// Token: 0x06013736 RID: 79670 RVA: 0x004F4DFC File Offset: 0x004F2FFC
		protected void SetSoldierSpineAnim(ConfigDataSoldierSkinInfo soldierSkinInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierSpineAnimConfigDataSoldierSkinInfo_hotfix != null)
			{
				this.m_SetSoldierSpineAnimConfigDataSoldierSkinInfo_hotfix.call(new object[]
				{
					this,
					soldierSkinInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = this.m_configDataLoader.GetConfigDataModelSkinResourceInfo(soldierSkinInfo.ShowInListSkinResInfo[0].SkinResourceId);
			ConfigDataSoldierInfo configDataSoldierInfo = this.m_configDataLoader.GetConfigDataSoldierInfo(soldierSkinInfo.ShowInListSkinResInfo[0].SoldierId);
			string model = configDataModelSkinResourceInfo.Model;
			float scale = (float)configDataSoldierInfo.UI_ModelScale * 0.012f;
			Vector2 offset = new Vector2((float)configDataSoldierInfo.UI_ModelOffsetX + (float)Math.Abs(configDataSoldierInfo.UI_ModelOffsetX) * 0.2f, (float)configDataSoldierInfo.UI_ModelOffsetY + (float)Math.Abs(configDataSoldierInfo.UI_ModelOffsetY) * 0.4f);
			HeroDetailUIController.CreateSpineGraphic(ref this.m_soldierGraphic, model, this.m_spineAnimObj, 1, offset, scale, configDataSoldierInfo.ReplaceAnims);
		}

		// Token: 0x06013737 RID: 79671 RVA: 0x004F4F14 File Offset: 0x004F3114
		protected void OnStoreItemClick()
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

		// Token: 0x14000440 RID: 1088
		// (add) Token: 0x06013738 RID: 79672 RVA: 0x004F4F8C File Offset: 0x004F318C
		// (remove) Token: 0x06013739 RID: 79673 RVA: 0x004F5028 File Offset: 0x004F3228
		public event Action<StoreSoldierSkinItemUIController> EventOnClick
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
				Action<StoreSoldierSkinItemUIController> action = this.EventOnClick;
				Action<StoreSoldierSkinItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreSoldierSkinItemUIController>>(ref this.EventOnClick, (Action<StoreSoldierSkinItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<StoreSoldierSkinItemUIController> action = this.EventOnClick;
				Action<StoreSoldierSkinItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreSoldierSkinItemUIController>>(ref this.EventOnClick, (Action<StoreSoldierSkinItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x0601373A RID: 79674 RVA: 0x004F50C4 File Offset: 0x004F32C4
		// (set) Token: 0x0601373B RID: 79675 RVA: 0x004F50E4 File Offset: 0x004F32E4
		[DoNotToLua]
		public new StoreSoldierSkinItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new StoreSoldierSkinItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601373C RID: 79676 RVA: 0x004F50F0 File Offset: 0x004F32F0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601373D RID: 79677 RVA: 0x004F50FC File Offset: 0x004F32FC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601373E RID: 79678 RVA: 0x004F5104 File Offset: 0x004F3304
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601373F RID: 79679 RVA: 0x004F510C File Offset: 0x004F330C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013740 RID: 79680 RVA: 0x004F5120 File Offset: 0x004F3320
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013741 RID: 79681 RVA: 0x004F5128 File Offset: 0x004F3328
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013742 RID: 79682 RVA: 0x004F5134 File Offset: 0x004F3334
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013743 RID: 79683 RVA: 0x004F5140 File Offset: 0x004F3340
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013744 RID: 79684 RVA: 0x004F514C File Offset: 0x004F334C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013745 RID: 79685 RVA: 0x004F5158 File Offset: 0x004F3358
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013746 RID: 79686 RVA: 0x004F5164 File Offset: 0x004F3364
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013747 RID: 79687 RVA: 0x004F5170 File Offset: 0x004F3370
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013748 RID: 79688 RVA: 0x004F517C File Offset: 0x004F337C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013749 RID: 79689 RVA: 0x004F5188 File Offset: 0x004F3388
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601374A RID: 79690 RVA: 0x004F5194 File Offset: 0x004F3394
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601374B RID: 79691 RVA: 0x004F519C File Offset: 0x004F339C
		private void __callDele_EventOnClick(StoreSoldierSkinItemUIController obj)
		{
			Action<StoreSoldierSkinItemUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0601374C RID: 79692 RVA: 0x004F51C0 File Offset: 0x004F33C0
		private void __clearDele_EventOnClick(StoreSoldierSkinItemUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0601374D RID: 79693 RVA: 0x004F51CC File Offset: 0x004F33CC
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
					this.m_SetSoldierSkinItemInfoFixedStoreItem_hotfix = (luaObj.RawGet("SetSoldierSkinItemInfo") as LuaFunction);
					this.m_SetItemState_hotfix = (luaObj.RawGet("SetItemState") as LuaFunction);
					this.m_SetSoldierSpineAnimConfigDataSoldierSkinInfo_hotfix = (luaObj.RawGet("SetSoldierSpineAnim") as LuaFunction);
					this.m_OnStoreItemClick_hotfix = (luaObj.RawGet("OnStoreItemClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601374E RID: 79694 RVA: 0x004F5330 File Offset: 0x004F3530
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(StoreSoldierSkinItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400ACBD RID: 44221
		public StoreType m_storeType;

		// Token: 0x0400ACBE RID: 44222
		public ConfigDataFixedStoreItemInfo m_storeItemConfig;

		// Token: 0x0400ACBF RID: 44223
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400ACC0 RID: 44224
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400ACC1 RID: 44225
		private UISpineGraphic m_soldierGraphic;

		// Token: 0x0400ACC2 RID: 44226
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		public Button m_storeItemButton;

		// Token: 0x0400ACC3 RID: 44227
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_spineAnimObj;

		// Token: 0x0400ACC4 RID: 44228
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_soldierName;

		// Token: 0x0400ACC5 RID: 44229
		[AutoBind("./Tape /TSurplusText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_restTime;

		// Token: 0x0400ACC6 RID: 44230
		[AutoBind("./PricePanel/PriceText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_priceText;

		// Token: 0x0400ACC7 RID: 44231
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController m_itemUIStateCtrl;

		// Token: 0x0400ACC8 RID: 44232
		[DoNotToLua]
		private StoreSoldierSkinItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400ACC9 RID: 44233
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400ACCA RID: 44234
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400ACCB RID: 44235
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400ACCC RID: 44236
		private LuaFunction m_SetSoldierSkinItemInfoFixedStoreItem_hotfix;

		// Token: 0x0400ACCD RID: 44237
		private LuaFunction m_SetItemState_hotfix;

		// Token: 0x0400ACCE RID: 44238
		private LuaFunction m_SetSoldierSpineAnimConfigDataSoldierSkinInfo_hotfix;

		// Token: 0x0400ACCF RID: 44239
		private LuaFunction m_OnStoreItemClick_hotfix;

		// Token: 0x0400ACD0 RID: 44240
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400ACD1 RID: 44241
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000F43 RID: 3907
		public new class LuaExportHelper
		{
			// Token: 0x0601374F RID: 79695 RVA: 0x004F5398 File Offset: 0x004F3598
			public LuaExportHelper(StoreSoldierSkinItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013750 RID: 79696 RVA: 0x004F53A8 File Offset: 0x004F35A8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013751 RID: 79697 RVA: 0x004F53B8 File Offset: 0x004F35B8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013752 RID: 79698 RVA: 0x004F53C8 File Offset: 0x004F35C8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013753 RID: 79699 RVA: 0x004F53D8 File Offset: 0x004F35D8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013754 RID: 79700 RVA: 0x004F53F0 File Offset: 0x004F35F0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013755 RID: 79701 RVA: 0x004F5400 File Offset: 0x004F3600
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013756 RID: 79702 RVA: 0x004F5410 File Offset: 0x004F3610
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013757 RID: 79703 RVA: 0x004F5420 File Offset: 0x004F3620
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013758 RID: 79704 RVA: 0x004F5430 File Offset: 0x004F3630
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013759 RID: 79705 RVA: 0x004F5440 File Offset: 0x004F3640
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601375A RID: 79706 RVA: 0x004F5450 File Offset: 0x004F3650
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601375B RID: 79707 RVA: 0x004F5460 File Offset: 0x004F3660
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601375C RID: 79708 RVA: 0x004F5470 File Offset: 0x004F3670
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601375D RID: 79709 RVA: 0x004F5480 File Offset: 0x004F3680
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601375E RID: 79710 RVA: 0x004F5490 File Offset: 0x004F3690
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601375F RID: 79711 RVA: 0x004F54A0 File Offset: 0x004F36A0
			public void __callDele_EventOnClick(StoreSoldierSkinItemUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x06013760 RID: 79712 RVA: 0x004F54B0 File Offset: 0x004F36B0
			public void __clearDele_EventOnClick(StoreSoldierSkinItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17003A98 RID: 15000
			// (get) Token: 0x06013761 RID: 79713 RVA: 0x004F54C0 File Offset: 0x004F36C0
			// (set) Token: 0x06013762 RID: 79714 RVA: 0x004F54D0 File Offset: 0x004F36D0
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

			// Token: 0x17003A99 RID: 15001
			// (get) Token: 0x06013763 RID: 79715 RVA: 0x004F54E0 File Offset: 0x004F36E0
			// (set) Token: 0x06013764 RID: 79716 RVA: 0x004F54F0 File Offset: 0x004F36F0
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

			// Token: 0x17003A9A RID: 15002
			// (get) Token: 0x06013765 RID: 79717 RVA: 0x004F5500 File Offset: 0x004F3700
			// (set) Token: 0x06013766 RID: 79718 RVA: 0x004F5510 File Offset: 0x004F3710
			public UISpineGraphic m_soldierGraphic
			{
				get
				{
					return this.m_owner.m_soldierGraphic;
				}
				set
				{
					this.m_owner.m_soldierGraphic = value;
				}
			}

			// Token: 0x06013767 RID: 79719 RVA: 0x004F5520 File Offset: 0x004F3720
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013768 RID: 79720 RVA: 0x004F5530 File Offset: 0x004F3730
			public void SetSoldierSpineAnim(ConfigDataSoldierSkinInfo soldierSkinInfo)
			{
				this.m_owner.SetSoldierSpineAnim(soldierSkinInfo);
			}

			// Token: 0x06013769 RID: 79721 RVA: 0x004F5540 File Offset: 0x004F3740
			public void OnStoreItemClick()
			{
				this.m_owner.OnStoreItemClick();
			}

			// Token: 0x0400ACD2 RID: 44242
			private StoreSoldierSkinItemUIController m_owner;
		}
	}
}
