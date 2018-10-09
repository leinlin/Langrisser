using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001014 RID: 4116
	[HotFix]
	public class BuyEnergyUIController : UIControllerBase
	{
		// Token: 0x06014C4B RID: 85067 RVA: 0x00544F90 File Offset: 0x00543190
		private BuyEnergyUIController()
		{
		}

		// Token: 0x06014C4C RID: 85068 RVA: 0x00544F98 File Offset: 0x00543198
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
			this.m_buyButton.onClick.AddListener(new UnityAction(this.OnBuyButtonClick));
			this.m_useMedicineButton.onClick.AddListener(new UnityAction(this.OnUseEnergyMedicineButtonClick));
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
		}

		// Token: 0x06014C4D RID: 85069 RVA: 0x00545054 File Offset: 0x00543254
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x06014C4E RID: 85070 RVA: 0x005450C8 File Offset: 0x005432C8
		public void SetEnergy(int energyCount, int price, bool IsBoughtNumsUsedOut)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnergyInt32Int32Boolean_hotfix != null)
			{
				this.m_SetEnergyInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					energyCount,
					price,
					IsBoughtNumsUsedOut
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_energyCountText.text = energyCount.ToString();
			this.m_priceText.text = price.ToString();
			this.m_buyGrayImage.enabled = IsBoughtNumsUsedOut;
		}

		// Token: 0x06014C4F RID: 85071 RVA: 0x00545194 File Offset: 0x00543394
		public void SetMedicine(int energyCount, int useMedicineCount, int redidueMedicineCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMedicineInt32Int32Int32_hotfix != null)
			{
				this.m_SetMedicineInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					energyCount,
					useMedicineCount,
					redidueMedicineCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_energyCountMedicineText.text = energyCount.ToString();
			this.m_useMedicineCountText.text = useMedicineCount.ToString();
			this.m_redidueMedicineCountText.text = redidueMedicineCount.ToString();
		}

		// Token: 0x06014C50 RID: 85072 RVA: 0x0054526C File Offset: 0x0054346C
		public void ShowEnergyNotEnoughTip(string s)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnergyNotEnoughTipString_hotfix != null)
			{
				this.m_ShowEnergyNotEnoughTipString_hotfix.call(new object[]
				{
					this,
					s
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_energyNotEnoughTipText.text = s;
			UIUtility.SetUIStateOpen(this.m_energyNotEnoughTipStateCtrl, "Show", null, false, true);
		}

		// Token: 0x06014C51 RID: 85073 RVA: 0x005452FC File Offset: 0x005434FC
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", null, false, true);
		}

		// Token: 0x06014C52 RID: 85074 RVA: 0x00545370 File Offset: 0x00543570
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", delegate
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			}, false, true);
		}

		// Token: 0x06014C53 RID: 85075 RVA: 0x005453F0 File Offset: 0x005435F0
		private void OnBuyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyButtonClick_hotfix != null)
			{
				this.m_OnBuyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnBuyEnergy != null)
			{
				this.EventOnBuyEnergy();
			}
		}

		// Token: 0x06014C54 RID: 85076 RVA: 0x00545468 File Offset: 0x00543668
		private void OnUseEnergyMedicineButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUseEnergyMedicineButtonClick_hotfix != null)
			{
				this.m_OnUseEnergyMedicineButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnUseEnergyMedicine != null)
			{
				this.EventOnUseEnergyMedicine();
			}
		}

		// Token: 0x14000492 RID: 1170
		// (add) Token: 0x06014C55 RID: 85077 RVA: 0x005454E0 File Offset: 0x005436E0
		// (remove) Token: 0x06014C56 RID: 85078 RVA: 0x0054557C File Offset: 0x0054377C
		public event Action EventOnUseEnergyMedicine
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUseEnergyMedicineAction_hotfix != null)
				{
					this.m_add_EventOnUseEnergyMedicineAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnUseEnergyMedicine;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnUseEnergyMedicine, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUseEnergyMedicineAction_hotfix != null)
				{
					this.m_remove_EventOnUseEnergyMedicineAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnUseEnergyMedicine;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnUseEnergyMedicine, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000493 RID: 1171
		// (add) Token: 0x06014C57 RID: 85079 RVA: 0x00545618 File Offset: 0x00543818
		// (remove) Token: 0x06014C58 RID: 85080 RVA: 0x005456B4 File Offset: 0x005438B4
		public event Action EventOnBuyEnergy
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBuyEnergyAction_hotfix != null)
				{
					this.m_add_EventOnBuyEnergyAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBuyEnergy;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBuyEnergy, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBuyEnergyAction_hotfix != null)
				{
					this.m_remove_EventOnBuyEnergyAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBuyEnergy;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBuyEnergy, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000494 RID: 1172
		// (add) Token: 0x06014C59 RID: 85081 RVA: 0x00545750 File Offset: 0x00543950
		// (remove) Token: 0x06014C5A RID: 85082 RVA: 0x005457EC File Offset: 0x005439EC
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x06014C5B RID: 85083 RVA: 0x00545888 File Offset: 0x00543A88
		// (set) Token: 0x06014C5C RID: 85084 RVA: 0x005458A8 File Offset: 0x00543AA8
		[DoNotToLua]
		public new BuyEnergyUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BuyEnergyUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014C5D RID: 85085 RVA: 0x005458B4 File Offset: 0x00543AB4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014C5E RID: 85086 RVA: 0x005458C0 File Offset: 0x00543AC0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014C5F RID: 85087 RVA: 0x005458C8 File Offset: 0x00543AC8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014C60 RID: 85088 RVA: 0x005458D0 File Offset: 0x00543AD0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014C61 RID: 85089 RVA: 0x005458E4 File Offset: 0x00543AE4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014C62 RID: 85090 RVA: 0x005458EC File Offset: 0x00543AEC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014C63 RID: 85091 RVA: 0x005458F8 File Offset: 0x00543AF8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014C64 RID: 85092 RVA: 0x00545904 File Offset: 0x00543B04
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014C65 RID: 85093 RVA: 0x00545910 File Offset: 0x00543B10
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014C66 RID: 85094 RVA: 0x0054591C File Offset: 0x00543B1C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014C67 RID: 85095 RVA: 0x00545928 File Offset: 0x00543B28
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014C68 RID: 85096 RVA: 0x00545934 File Offset: 0x00543B34
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014C69 RID: 85097 RVA: 0x00545940 File Offset: 0x00543B40
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014C6A RID: 85098 RVA: 0x0054594C File Offset: 0x00543B4C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014C6B RID: 85099 RVA: 0x00545958 File Offset: 0x00543B58
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014C6C RID: 85100 RVA: 0x00545960 File Offset: 0x00543B60
		private void __callDele_EventOnUseEnergyMedicine()
		{
			Action eventOnUseEnergyMedicine = this.EventOnUseEnergyMedicine;
			if (eventOnUseEnergyMedicine != null)
			{
				eventOnUseEnergyMedicine();
			}
		}

		// Token: 0x06014C6D RID: 85101 RVA: 0x00545980 File Offset: 0x00543B80
		private void __clearDele_EventOnUseEnergyMedicine()
		{
			this.EventOnUseEnergyMedicine = null;
		}

		// Token: 0x06014C6E RID: 85102 RVA: 0x0054598C File Offset: 0x00543B8C
		private void __callDele_EventOnBuyEnergy()
		{
			Action eventOnBuyEnergy = this.EventOnBuyEnergy;
			if (eventOnBuyEnergy != null)
			{
				eventOnBuyEnergy();
			}
		}

		// Token: 0x06014C6F RID: 85103 RVA: 0x005459AC File Offset: 0x00543BAC
		private void __clearDele_EventOnBuyEnergy()
		{
			this.EventOnBuyEnergy = null;
		}

		// Token: 0x06014C70 RID: 85104 RVA: 0x005459B8 File Offset: 0x00543BB8
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06014C71 RID: 85105 RVA: 0x005459D8 File Offset: 0x00543BD8
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06014C73 RID: 85107 RVA: 0x005459FC File Offset: 0x00543BFC
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_SetEnergyInt32Int32Boolean_hotfix = (luaObj.RawGet("SetEnergy") as LuaFunction);
					this.m_SetMedicineInt32Int32Int32_hotfix = (luaObj.RawGet("SetMedicine") as LuaFunction);
					this.m_ShowEnergyNotEnoughTipString_hotfix = (luaObj.RawGet("ShowEnergyNotEnoughTip") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnBuyButtonClick_hotfix = (luaObj.RawGet("OnBuyButtonClick") as LuaFunction);
					this.m_OnUseEnergyMedicineButtonClick_hotfix = (luaObj.RawGet("OnUseEnergyMedicineButtonClick") as LuaFunction);
					this.m_add_EventOnUseEnergyMedicineAction_hotfix = (luaObj.RawGet("add_EventOnUseEnergyMedicine") as LuaFunction);
					this.m_remove_EventOnUseEnergyMedicineAction_hotfix = (luaObj.RawGet("remove_EventOnUseEnergyMedicine") as LuaFunction);
					this.m_add_EventOnBuyEnergyAction_hotfix = (luaObj.RawGet("add_EventOnBuyEnergy") as LuaFunction);
					this.m_remove_EventOnBuyEnergyAction_hotfix = (luaObj.RawGet("remove_EventOnBuyEnergy") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014C74 RID: 85108 RVA: 0x00545C28 File Offset: 0x00543E28
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BuyEnergyUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B62A RID: 46634
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B62B RID: 46635
		[AutoBind("./Panel/MoneyBuy/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyCountText;

		// Token: 0x0400B62C RID: 46636
		[AutoBind("./Panel/MoneyBuy/BuyButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_buyButton;

		// Token: 0x0400B62D RID: 46637
		[AutoBind("./Panel/MoneyBuy/BuyButton/Price/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_priceText;

		// Token: 0x0400B62E RID: 46638
		[AutoBind("./Panel/MoneyBuy/BuyButton/GrayImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_buyGrayImage;

		// Token: 0x0400B62F RID: 46639
		[AutoBind("./Panel/PropBuy/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyCountMedicineText;

		// Token: 0x0400B630 RID: 46640
		[AutoBind("./Panel/PropBuy/BuyButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_useMedicineButton;

		// Token: 0x0400B631 RID: 46641
		[AutoBind("./Panel/PropBuy/BuyButton/Price/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_useMedicineCountText;

		// Token: 0x0400B632 RID: 46642
		[AutoBind("./Panel/PropBuy/ResidueValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_redidueMedicineCountText;

		// Token: 0x0400B633 RID: 46643
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400B634 RID: 46644
		[AutoBind("./EnergyNotEnoughTips", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_energyNotEnoughTipStateCtrl;

		// Token: 0x0400B635 RID: 46645
		[AutoBind("./EnergyNotEnoughTips/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyNotEnoughTipText;

		// Token: 0x0400B636 RID: 46646
		[DoNotToLua]
		private BuyEnergyUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B637 RID: 46647
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B638 RID: 46648
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B639 RID: 46649
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B63A RID: 46650
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400B63B RID: 46651
		private LuaFunction m_SetEnergyInt32Int32Boolean_hotfix;

		// Token: 0x0400B63C RID: 46652
		private LuaFunction m_SetMedicineInt32Int32Int32_hotfix;

		// Token: 0x0400B63D RID: 46653
		private LuaFunction m_ShowEnergyNotEnoughTipString_hotfix;

		// Token: 0x0400B63E RID: 46654
		private LuaFunction m_Close_hotfix;

		// Token: 0x0400B63F RID: 46655
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x0400B640 RID: 46656
		private LuaFunction m_OnBuyButtonClick_hotfix;

		// Token: 0x0400B641 RID: 46657
		private LuaFunction m_OnUseEnergyMedicineButtonClick_hotfix;

		// Token: 0x0400B642 RID: 46658
		private LuaFunction m_add_EventOnUseEnergyMedicineAction_hotfix;

		// Token: 0x0400B643 RID: 46659
		private LuaFunction m_remove_EventOnUseEnergyMedicineAction_hotfix;

		// Token: 0x0400B644 RID: 46660
		private LuaFunction m_add_EventOnBuyEnergyAction_hotfix;

		// Token: 0x0400B645 RID: 46661
		private LuaFunction m_remove_EventOnBuyEnergyAction_hotfix;

		// Token: 0x0400B646 RID: 46662
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400B647 RID: 46663
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02001015 RID: 4117
		public new class LuaExportHelper
		{
			// Token: 0x06014C75 RID: 85109 RVA: 0x00545C90 File Offset: 0x00543E90
			public LuaExportHelper(BuyEnergyUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014C76 RID: 85110 RVA: 0x00545CA0 File Offset: 0x00543EA0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014C77 RID: 85111 RVA: 0x00545CB0 File Offset: 0x00543EB0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014C78 RID: 85112 RVA: 0x00545CC0 File Offset: 0x00543EC0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014C79 RID: 85113 RVA: 0x00545CD0 File Offset: 0x00543ED0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014C7A RID: 85114 RVA: 0x00545CE8 File Offset: 0x00543EE8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014C7B RID: 85115 RVA: 0x00545CF8 File Offset: 0x00543EF8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014C7C RID: 85116 RVA: 0x00545D08 File Offset: 0x00543F08
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014C7D RID: 85117 RVA: 0x00545D18 File Offset: 0x00543F18
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014C7E RID: 85118 RVA: 0x00545D28 File Offset: 0x00543F28
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014C7F RID: 85119 RVA: 0x00545D38 File Offset: 0x00543F38
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014C80 RID: 85120 RVA: 0x00545D48 File Offset: 0x00543F48
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014C81 RID: 85121 RVA: 0x00545D58 File Offset: 0x00543F58
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014C82 RID: 85122 RVA: 0x00545D68 File Offset: 0x00543F68
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014C83 RID: 85123 RVA: 0x00545D78 File Offset: 0x00543F78
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014C84 RID: 85124 RVA: 0x00545D88 File Offset: 0x00543F88
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014C85 RID: 85125 RVA: 0x00545D98 File Offset: 0x00543F98
			public void __callDele_EventOnUseEnergyMedicine()
			{
				this.m_owner.__callDele_EventOnUseEnergyMedicine();
			}

			// Token: 0x06014C86 RID: 85126 RVA: 0x00545DA8 File Offset: 0x00543FA8
			public void __clearDele_EventOnUseEnergyMedicine()
			{
				this.m_owner.__clearDele_EventOnUseEnergyMedicine();
			}

			// Token: 0x06014C87 RID: 85127 RVA: 0x00545DB8 File Offset: 0x00543FB8
			public void __callDele_EventOnBuyEnergy()
			{
				this.m_owner.__callDele_EventOnBuyEnergy();
			}

			// Token: 0x06014C88 RID: 85128 RVA: 0x00545DC8 File Offset: 0x00543FC8
			public void __clearDele_EventOnBuyEnergy()
			{
				this.m_owner.__clearDele_EventOnBuyEnergy();
			}

			// Token: 0x06014C89 RID: 85129 RVA: 0x00545DD8 File Offset: 0x00543FD8
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06014C8A RID: 85130 RVA: 0x00545DE8 File Offset: 0x00543FE8
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17003D62 RID: 15714
			// (get) Token: 0x06014C8B RID: 85131 RVA: 0x00545DF8 File Offset: 0x00543FF8
			// (set) Token: 0x06014C8C RID: 85132 RVA: 0x00545E08 File Offset: 0x00544008
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x17003D63 RID: 15715
			// (get) Token: 0x06014C8D RID: 85133 RVA: 0x00545E18 File Offset: 0x00544018
			// (set) Token: 0x06014C8E RID: 85134 RVA: 0x00545E28 File Offset: 0x00544028
			public Text m_energyCountText
			{
				get
				{
					return this.m_owner.m_energyCountText;
				}
				set
				{
					this.m_owner.m_energyCountText = value;
				}
			}

			// Token: 0x17003D64 RID: 15716
			// (get) Token: 0x06014C8F RID: 85135 RVA: 0x00545E38 File Offset: 0x00544038
			// (set) Token: 0x06014C90 RID: 85136 RVA: 0x00545E48 File Offset: 0x00544048
			public Button m_buyButton
			{
				get
				{
					return this.m_owner.m_buyButton;
				}
				set
				{
					this.m_owner.m_buyButton = value;
				}
			}

			// Token: 0x17003D65 RID: 15717
			// (get) Token: 0x06014C91 RID: 85137 RVA: 0x00545E58 File Offset: 0x00544058
			// (set) Token: 0x06014C92 RID: 85138 RVA: 0x00545E68 File Offset: 0x00544068
			public Text m_priceText
			{
				get
				{
					return this.m_owner.m_priceText;
				}
				set
				{
					this.m_owner.m_priceText = value;
				}
			}

			// Token: 0x17003D66 RID: 15718
			// (get) Token: 0x06014C93 RID: 85139 RVA: 0x00545E78 File Offset: 0x00544078
			// (set) Token: 0x06014C94 RID: 85140 RVA: 0x00545E88 File Offset: 0x00544088
			public Image m_buyGrayImage
			{
				get
				{
					return this.m_owner.m_buyGrayImage;
				}
				set
				{
					this.m_owner.m_buyGrayImage = value;
				}
			}

			// Token: 0x17003D67 RID: 15719
			// (get) Token: 0x06014C95 RID: 85141 RVA: 0x00545E98 File Offset: 0x00544098
			// (set) Token: 0x06014C96 RID: 85142 RVA: 0x00545EA8 File Offset: 0x005440A8
			public Text m_energyCountMedicineText
			{
				get
				{
					return this.m_owner.m_energyCountMedicineText;
				}
				set
				{
					this.m_owner.m_energyCountMedicineText = value;
				}
			}

			// Token: 0x17003D68 RID: 15720
			// (get) Token: 0x06014C97 RID: 85143 RVA: 0x00545EB8 File Offset: 0x005440B8
			// (set) Token: 0x06014C98 RID: 85144 RVA: 0x00545EC8 File Offset: 0x005440C8
			public Button m_useMedicineButton
			{
				get
				{
					return this.m_owner.m_useMedicineButton;
				}
				set
				{
					this.m_owner.m_useMedicineButton = value;
				}
			}

			// Token: 0x17003D69 RID: 15721
			// (get) Token: 0x06014C99 RID: 85145 RVA: 0x00545ED8 File Offset: 0x005440D8
			// (set) Token: 0x06014C9A RID: 85146 RVA: 0x00545EE8 File Offset: 0x005440E8
			public Text m_useMedicineCountText
			{
				get
				{
					return this.m_owner.m_useMedicineCountText;
				}
				set
				{
					this.m_owner.m_useMedicineCountText = value;
				}
			}

			// Token: 0x17003D6A RID: 15722
			// (get) Token: 0x06014C9B RID: 85147 RVA: 0x00545EF8 File Offset: 0x005440F8
			// (set) Token: 0x06014C9C RID: 85148 RVA: 0x00545F08 File Offset: 0x00544108
			public Text m_redidueMedicineCountText
			{
				get
				{
					return this.m_owner.m_redidueMedicineCountText;
				}
				set
				{
					this.m_owner.m_redidueMedicineCountText = value;
				}
			}

			// Token: 0x17003D6B RID: 15723
			// (get) Token: 0x06014C9D RID: 85149 RVA: 0x00545F18 File Offset: 0x00544118
			// (set) Token: 0x06014C9E RID: 85150 RVA: 0x00545F28 File Offset: 0x00544128
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x17003D6C RID: 15724
			// (get) Token: 0x06014C9F RID: 85151 RVA: 0x00545F38 File Offset: 0x00544138
			// (set) Token: 0x06014CA0 RID: 85152 RVA: 0x00545F48 File Offset: 0x00544148
			public CommonUIStateController m_energyNotEnoughTipStateCtrl
			{
				get
				{
					return this.m_owner.m_energyNotEnoughTipStateCtrl;
				}
				set
				{
					this.m_owner.m_energyNotEnoughTipStateCtrl = value;
				}
			}

			// Token: 0x17003D6D RID: 15725
			// (get) Token: 0x06014CA1 RID: 85153 RVA: 0x00545F58 File Offset: 0x00544158
			// (set) Token: 0x06014CA2 RID: 85154 RVA: 0x00545F68 File Offset: 0x00544168
			public Text m_energyNotEnoughTipText
			{
				get
				{
					return this.m_owner.m_energyNotEnoughTipText;
				}
				set
				{
					this.m_owner.m_energyNotEnoughTipText = value;
				}
			}

			// Token: 0x06014CA3 RID: 85155 RVA: 0x00545F78 File Offset: 0x00544178
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014CA4 RID: 85156 RVA: 0x00545F88 File Offset: 0x00544188
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x06014CA5 RID: 85157 RVA: 0x00545F98 File Offset: 0x00544198
			public void OnBuyButtonClick()
			{
				this.m_owner.OnBuyButtonClick();
			}

			// Token: 0x06014CA6 RID: 85158 RVA: 0x00545FA8 File Offset: 0x005441A8
			public void OnUseEnergyMedicineButtonClick()
			{
				this.m_owner.OnUseEnergyMedicineButtonClick();
			}

			// Token: 0x0400B648 RID: 46664
			private BuyEnergyUIController m_owner;
		}
	}
}
