using System;
using System.Runtime.CompilerServices;
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
	// Token: 0x02000C7E RID: 3198
	[HotFix]
	public class FettersGiftItemUIController : UIControllerBase
	{
		// Token: 0x0600E5DD RID: 58845 RVA: 0x003DB724 File Offset: 0x003D9924
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x0600E5DE RID: 58846 RVA: 0x003DB7A8 File Offset: 0x003D99A8
		public void SetGiftItemInfo(BagItemBase bagItem, int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGiftItemInfoBagItemBaseInt32_hotfix != null)
			{
				this.m_SetGiftItemInfoBagItemBaseInt32_hotfix.call(new object[]
				{
					this,
					bagItem,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			if (bagItem == null)
			{
				return;
			}
			this.BagItem = bagItem;
			this.m_image.sprite = AssetUtility.Instance.GetSprite(bagItem.ItemInfo.Icon);
			this.m_countText.text = bagItem.Nums.ToString();
			this.m_rankBgImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameName(bagItem.GoodsTypeId, bagItem.ContentId));
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = bagItem as AddHeroFavorabilityUseableBagItem;
			int num = addHeroFavorabilityUseableBagItem.CalculateAddFavorabilityExp(heroId);
			this.m_addGo.SetActive(num > addHeroFavorabilityUseableBagItem.NormalAddExp);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			num = projectLPlayerContext.GetAdditiveHeroFavourabilityAddExp(num);
			this.AddExpValue = num;
			int bagItemCountByInstanceId = projectLPlayerContext.GetBagItemCountByInstanceId(bagItem.InstanceId);
			this.m_goods = new Goods
			{
				GoodsType = bagItem.GoodsTypeId,
				Id = bagItem.ContentId,
				Count = bagItemCountByInstanceId
			};
		}

		// Token: 0x0600E5DF RID: 58847 RVA: 0x003DB92C File Offset: 0x003D9B2C
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnItemClick != null)
			{
				this.EventOnItemClick(this, true);
			}
		}

		// Token: 0x0600E5E0 RID: 58848 RVA: 0x003DB9A4 File Offset: 0x003D9BA4
		public void ShowSelectFrameImage(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectFrameImageBoolean_hotfix != null)
			{
				this.m_ShowSelectFrameImageBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectFrameImage.SetActive(isShow);
		}

		// Token: 0x0600E5E1 RID: 58849 RVA: 0x003DBA20 File Offset: 0x003D9C20
		public void SetCountTextValue(int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCountTextValueInt32_hotfix != null)
			{
				this.m_SetCountTextValueInt32_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_countText.text = (this.BagItem.Nums - value).ToString();
		}

		// Token: 0x140002ED RID: 749
		// (add) Token: 0x0600E5E2 RID: 58850 RVA: 0x003DBAB8 File Offset: 0x003D9CB8
		// (remove) Token: 0x0600E5E3 RID: 58851 RVA: 0x003DBB54 File Offset: 0x003D9D54
		public event Action<FettersGiftItemUIController, bool> EventOnItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnItemClickAction`2_hotfix != null)
				{
					this.m_add_EventOnItemClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FettersGiftItemUIController, bool> action = this.EventOnItemClick;
				Action<FettersGiftItemUIController, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FettersGiftItemUIController, bool>>(ref this.EventOnItemClick, (Action<FettersGiftItemUIController, bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnItemClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnItemClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FettersGiftItemUIController, bool> action = this.EventOnItemClick;
				Action<FettersGiftItemUIController, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FettersGiftItemUIController, bool>>(ref this.EventOnItemClick, (Action<FettersGiftItemUIController, bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x0600E5E5 RID: 58853 RVA: 0x003DBC68 File Offset: 0x003D9E68
		// (set) Token: 0x0600E5E4 RID: 58852 RVA: 0x003DBBF0 File Offset: 0x003D9DF0
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

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x0600E5E7 RID: 58855 RVA: 0x003DBD54 File Offset: 0x003D9F54
		// (set) Token: 0x0600E5E6 RID: 58854 RVA: 0x003DBCDC File Offset: 0x003D9EDC
		public int AddExpValue
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_AddExpValue_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_AddExpValue_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<AddExpValue>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_AddExpValueInt32_hotfix != null)
				{
					this.m_set_AddExpValueInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<AddExpValue>k__BackingField = value;
			}
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x0600E5E8 RID: 58856 RVA: 0x003DBDC8 File Offset: 0x003D9FC8
		// (set) Token: 0x0600E5E9 RID: 58857 RVA: 0x003DBDE8 File Offset: 0x003D9FE8
		[DoNotToLua]
		public new FettersGiftItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersGiftItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E5EA RID: 58858 RVA: 0x003DBDF4 File Offset: 0x003D9FF4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E5EB RID: 58859 RVA: 0x003DBE00 File Offset: 0x003DA000
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E5EC RID: 58860 RVA: 0x003DBE08 File Offset: 0x003DA008
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E5ED RID: 58861 RVA: 0x003DBE10 File Offset: 0x003DA010
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E5EE RID: 58862 RVA: 0x003DBE24 File Offset: 0x003DA024
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E5EF RID: 58863 RVA: 0x003DBE2C File Offset: 0x003DA02C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E5F0 RID: 58864 RVA: 0x003DBE38 File Offset: 0x003DA038
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E5F1 RID: 58865 RVA: 0x003DBE44 File Offset: 0x003DA044
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E5F2 RID: 58866 RVA: 0x003DBE50 File Offset: 0x003DA050
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E5F3 RID: 58867 RVA: 0x003DBE5C File Offset: 0x003DA05C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E5F4 RID: 58868 RVA: 0x003DBE68 File Offset: 0x003DA068
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E5F5 RID: 58869 RVA: 0x003DBE74 File Offset: 0x003DA074
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E5F6 RID: 58870 RVA: 0x003DBE80 File Offset: 0x003DA080
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E5F7 RID: 58871 RVA: 0x003DBE8C File Offset: 0x003DA08C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E5F8 RID: 58872 RVA: 0x003DBE98 File Offset: 0x003DA098
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E5F9 RID: 58873 RVA: 0x003DBEA0 File Offset: 0x003DA0A0
		private void __callDele_EventOnItemClick(FettersGiftItemUIController arg1, bool arg2)
		{
			Action<FettersGiftItemUIController, bool> eventOnItemClick = this.EventOnItemClick;
			if (eventOnItemClick != null)
			{
				eventOnItemClick(arg1, arg2);
			}
		}

		// Token: 0x0600E5FA RID: 58874 RVA: 0x003DBEC4 File Offset: 0x003DA0C4
		private void __clearDele_EventOnItemClick(FettersGiftItemUIController arg1, bool arg2)
		{
			this.EventOnItemClick = null;
		}

		// Token: 0x0600E5FB RID: 58875 RVA: 0x003DBED0 File Offset: 0x003DA0D0
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
					this.m_SetGiftItemInfoBagItemBaseInt32_hotfix = (luaObj.RawGet("SetGiftItemInfo") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_ShowSelectFrameImageBoolean_hotfix = (luaObj.RawGet("ShowSelectFrameImage") as LuaFunction);
					this.m_SetCountTextValueInt32_hotfix = (luaObj.RawGet("SetCountTextValue") as LuaFunction);
					this.m_add_EventOnItemClickAction`2_hotfix = (luaObj.RawGet("add_EventOnItemClick") as LuaFunction);
					this.m_remove_EventOnItemClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnItemClick") as LuaFunction);
					this.m_set_BagItemBagItemBase_hotfix = (luaObj.RawGet("set_BagItem") as LuaFunction);
					this.m_get_BagItem_hotfix = (luaObj.RawGet("get_BagItem") as LuaFunction);
					this.m_set_AddExpValueInt32_hotfix = (luaObj.RawGet("set_AddExpValue") as LuaFunction);
					this.m_get_AddExpValue_hotfix = (luaObj.RawGet("get_AddExpValue") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E5FC RID: 58876 RVA: 0x003DC098 File Offset: 0x003DA298
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersGiftItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008AC5 RID: 35525
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04008AC6 RID: 35526
		[AutoBind("./FrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rankBgImage;

		// Token: 0x04008AC7 RID: 35527
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x04008AC8 RID: 35528
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_countText;

		// Token: 0x04008AC9 RID: 35529
		[AutoBind("./AddImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addGo;

		// Token: 0x04008ACA RID: 35530
		[AutoBind("./SelectFrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectFrameImage;

		// Token: 0x04008ACB RID: 35531
		private Goods m_goods;

		// Token: 0x04008ACE RID: 35534
		[DoNotToLua]
		private FettersGiftItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008ACF RID: 35535
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008AD0 RID: 35536
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008AD1 RID: 35537
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008AD2 RID: 35538
		private LuaFunction m_SetGiftItemInfoBagItemBaseInt32_hotfix;

		// Token: 0x04008AD3 RID: 35539
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x04008AD4 RID: 35540
		private LuaFunction m_ShowSelectFrameImageBoolean_hotfix;

		// Token: 0x04008AD5 RID: 35541
		private LuaFunction m_SetCountTextValueInt32_hotfix;

		// Token: 0x04008AD6 RID: 35542
		private LuaFunction m_add_EventOnItemClickAction;

		// Token: 0x04008AD7 RID: 35543
		private LuaFunction m_remove_EventOnItemClickAction;

		// Token: 0x04008AD8 RID: 35544
		private LuaFunction m_set_BagItemBagItemBase_hotfix;

		// Token: 0x04008AD9 RID: 35545
		private LuaFunction m_get_BagItem_hotfix;

		// Token: 0x04008ADA RID: 35546
		private LuaFunction m_set_AddExpValueInt32_hotfix;

		// Token: 0x04008ADB RID: 35547
		private LuaFunction m_get_AddExpValue_hotfix;

		// Token: 0x02000C7F RID: 3199
		public new class LuaExportHelper
		{
			// Token: 0x0600E5FD RID: 58877 RVA: 0x003DC100 File Offset: 0x003DA300
			public LuaExportHelper(FettersGiftItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E5FE RID: 58878 RVA: 0x003DC110 File Offset: 0x003DA310
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E5FF RID: 58879 RVA: 0x003DC120 File Offset: 0x003DA320
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E600 RID: 58880 RVA: 0x003DC130 File Offset: 0x003DA330
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E601 RID: 58881 RVA: 0x003DC140 File Offset: 0x003DA340
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E602 RID: 58882 RVA: 0x003DC158 File Offset: 0x003DA358
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E603 RID: 58883 RVA: 0x003DC168 File Offset: 0x003DA368
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E604 RID: 58884 RVA: 0x003DC178 File Offset: 0x003DA378
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E605 RID: 58885 RVA: 0x003DC188 File Offset: 0x003DA388
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E606 RID: 58886 RVA: 0x003DC198 File Offset: 0x003DA398
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E607 RID: 58887 RVA: 0x003DC1A8 File Offset: 0x003DA3A8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E608 RID: 58888 RVA: 0x003DC1B8 File Offset: 0x003DA3B8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E609 RID: 58889 RVA: 0x003DC1C8 File Offset: 0x003DA3C8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E60A RID: 58890 RVA: 0x003DC1D8 File Offset: 0x003DA3D8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E60B RID: 58891 RVA: 0x003DC1E8 File Offset: 0x003DA3E8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E60C RID: 58892 RVA: 0x003DC1F8 File Offset: 0x003DA3F8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E60D RID: 58893 RVA: 0x003DC208 File Offset: 0x003DA408
			public void __callDele_EventOnItemClick(FettersGiftItemUIController arg1, bool arg2)
			{
				this.m_owner.__callDele_EventOnItemClick(arg1, arg2);
			}

			// Token: 0x0600E60E RID: 58894 RVA: 0x003DC218 File Offset: 0x003DA418
			public void __clearDele_EventOnItemClick(FettersGiftItemUIController arg1, bool arg2)
			{
				this.m_owner.__clearDele_EventOnItemClick(arg1, arg2);
			}

			// Token: 0x17002CB0 RID: 11440
			// (get) Token: 0x0600E60F RID: 58895 RVA: 0x003DC228 File Offset: 0x003DA428
			// (set) Token: 0x0600E610 RID: 58896 RVA: 0x003DC238 File Offset: 0x003DA438
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x17002CB1 RID: 11441
			// (get) Token: 0x0600E611 RID: 58897 RVA: 0x003DC248 File Offset: 0x003DA448
			// (set) Token: 0x0600E612 RID: 58898 RVA: 0x003DC258 File Offset: 0x003DA458
			public Image m_rankBgImage
			{
				get
				{
					return this.m_owner.m_rankBgImage;
				}
				set
				{
					this.m_owner.m_rankBgImage = value;
				}
			}

			// Token: 0x17002CB2 RID: 11442
			// (get) Token: 0x0600E613 RID: 58899 RVA: 0x003DC268 File Offset: 0x003DA468
			// (set) Token: 0x0600E614 RID: 58900 RVA: 0x003DC278 File Offset: 0x003DA478
			public Image m_image
			{
				get
				{
					return this.m_owner.m_image;
				}
				set
				{
					this.m_owner.m_image = value;
				}
			}

			// Token: 0x17002CB3 RID: 11443
			// (get) Token: 0x0600E615 RID: 58901 RVA: 0x003DC288 File Offset: 0x003DA488
			// (set) Token: 0x0600E616 RID: 58902 RVA: 0x003DC298 File Offset: 0x003DA498
			public Text m_countText
			{
				get
				{
					return this.m_owner.m_countText;
				}
				set
				{
					this.m_owner.m_countText = value;
				}
			}

			// Token: 0x17002CB4 RID: 11444
			// (get) Token: 0x0600E617 RID: 58903 RVA: 0x003DC2A8 File Offset: 0x003DA4A8
			// (set) Token: 0x0600E618 RID: 58904 RVA: 0x003DC2B8 File Offset: 0x003DA4B8
			public GameObject m_addGo
			{
				get
				{
					return this.m_owner.m_addGo;
				}
				set
				{
					this.m_owner.m_addGo = value;
				}
			}

			// Token: 0x17002CB5 RID: 11445
			// (get) Token: 0x0600E619 RID: 58905 RVA: 0x003DC2C8 File Offset: 0x003DA4C8
			// (set) Token: 0x0600E61A RID: 58906 RVA: 0x003DC2D8 File Offset: 0x003DA4D8
			public GameObject m_selectFrameImage
			{
				get
				{
					return this.m_owner.m_selectFrameImage;
				}
				set
				{
					this.m_owner.m_selectFrameImage = value;
				}
			}

			// Token: 0x17002CB6 RID: 11446
			// (get) Token: 0x0600E61B RID: 58907 RVA: 0x003DC2E8 File Offset: 0x003DA4E8
			// (set) Token: 0x0600E61C RID: 58908 RVA: 0x003DC2F8 File Offset: 0x003DA4F8
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

			// Token: 0x17002CB7 RID: 11447
			// (set) Token: 0x0600E61D RID: 58909 RVA: 0x003DC308 File Offset: 0x003DA508
			public BagItemBase BagItem
			{
				set
				{
					this.m_owner.BagItem = value;
				}
			}

			// Token: 0x17002CB8 RID: 11448
			// (set) Token: 0x0600E61E RID: 58910 RVA: 0x003DC318 File Offset: 0x003DA518
			public int AddExpValue
			{
				set
				{
					this.m_owner.AddExpValue = value;
				}
			}

			// Token: 0x0600E61F RID: 58911 RVA: 0x003DC328 File Offset: 0x003DA528
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E620 RID: 58912 RVA: 0x003DC338 File Offset: 0x003DA538
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x04008ADC RID: 35548
			private FettersGiftItemUIController m_owner;
		}
	}
}
