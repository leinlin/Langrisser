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
	// Token: 0x02000D9A RID: 3482
	[HotFix]
	public class HeroEquipItemUIController : UIControllerBase
	{
		// Token: 0x060105B3 RID: 66995 RVA: 0x00444AE0 File Offset: 0x00442CE0
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
			this.m_addButton.onClick.AddListener(new UnityAction(this.OnAddButtonClick));
			this.m_iconButton.onClick.AddListener(new UnityAction(this.OnIconClick));
			this.m_runeIconButton.onClick.AddListener(new UnityAction(this.OnRuneIconButtonClick));
		}

		// Token: 0x060105B4 RID: 66996 RVA: 0x00444B9C File Offset: 0x00442D9C
		public void InitHeroEquipmentItem(EquipmentBagItem equipment, int slot, int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroEquipmentItemEquipmentBagItemInt32Int32_hotfix != null)
			{
				this.m_InitHeroEquipmentItemEquipmentBagItemInt32Int32_hotfix.call(new object[]
				{
					this,
					equipment,
					slot,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.Slot = slot;
			this.Equipment = equipment;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			if (equipment != null)
			{
				ConfigDataEquipmentInfo equipmentInfo = this.Equipment.EquipmentInfo;
				component.SetToUIState("Have", false, true);
				this.m_iconImg.sprite = AssetUtility.Instance.GetSprite(equipmentInfo.Icon);
				this.m_iconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(equipmentInfo.Rank));
				this.m_nameText.text = equipmentInfo.Name;
				int levelLimit = configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipment.StarLevel).LevelLimit;
				this.m_lvText.text = equipment.Level + "/" + levelLimit;
				UIUtility.SetGameObjectChildrenActiveCount(this.m_starGroupg, equipment.StarLevel);
				this.m_iconSSREffect.SetActive(UIUtility.IsRankSSR(equipmentInfo.Rank));
				if (equipment.IsEnchant())
				{
					this.m_runeIconStateCtrl.gameObject.SetActive(true);
					ConfigDataResonanceInfo configDataResonanceInfo = configDataLoader.GetConfigDataResonanceInfo(equipment.ResonanceId);
					int equipmentResonanceNums = projectLPlayerContext.GetEquipmentResonanceNums(equipment.InstanceId);
					if (equipmentResonanceNums >= 2)
					{
						this.m_runeIconStateCtrl.SetToUIState("Active", false, true);
						this.m_runeActiveIcon.sprite = AssetUtility.Instance.GetSprite(configDataResonanceInfo.ActiveIcon);
					}
					else
					{
						this.m_runeIconStateCtrl.SetToUIState("Unactive", false, true);
						this.m_runeInactiveIcon.sprite = AssetUtility.Instance.GetSprite(configDataResonanceInfo.InactiveIcon);
					}
				}
				else
				{
					this.m_runeIconStateCtrl.gameObject.SetActive(false);
				}
			}
			else
			{
				component.SetToUIState("NotHave", false, true);
			}
			this.m_redMarkGo.SetActive(projectLPlayerContext.HasBetterEquipmentBySlotId(heroId, slot));
		}

		// Token: 0x060105B5 RID: 66997 RVA: 0x00444E1C File Offset: 0x0044301C
		public void ShowSelectImage(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectImageBoolean_hotfix != null)
			{
				this.m_ShowSelectImageBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectImage.SetActive(isShow);
		}

		// Token: 0x060105B6 RID: 66998 RVA: 0x00444E98 File Offset: 0x00443098
		private void OnIconClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnIconClick_hotfix != null)
			{
				this.m_OnIconClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnIconClick != null)
			{
				this.EventOnIconClick(this);
			}
		}

		// Token: 0x060105B7 RID: 66999 RVA: 0x00444F10 File Offset: 0x00443110
		private void OnAddButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddButtonClick_hotfix != null)
			{
				this.m_OnAddButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddButtonClick != null)
			{
				this.EventOnAddButtonClick(this);
			}
		}

		// Token: 0x060105B8 RID: 67000 RVA: 0x00444F88 File Offset: 0x00443188
		private void OnRuneIconButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRuneIconButtonClick_hotfix != null)
			{
				this.m_OnRuneIconButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRuneIconButtonClick != null)
			{
				this.EventOnRuneIconButtonClick(this);
			}
		}

		// Token: 0x14000375 RID: 885
		// (add) Token: 0x060105B9 RID: 67001 RVA: 0x00445000 File Offset: 0x00443200
		// (remove) Token: 0x060105BA RID: 67002 RVA: 0x0044509C File Offset: 0x0044329C
		public event Action<HeroEquipItemUIController> EventOnAddButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnAddButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroEquipItemUIController> action = this.EventOnAddButtonClick;
				Action<HeroEquipItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroEquipItemUIController>>(ref this.EventOnAddButtonClick, (Action<HeroEquipItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnAddButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroEquipItemUIController> action = this.EventOnAddButtonClick;
				Action<HeroEquipItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroEquipItemUIController>>(ref this.EventOnAddButtonClick, (Action<HeroEquipItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000376 RID: 886
		// (add) Token: 0x060105BB RID: 67003 RVA: 0x00445138 File Offset: 0x00443338
		// (remove) Token: 0x060105BC RID: 67004 RVA: 0x004451D4 File Offset: 0x004433D4
		public event Action<HeroEquipItemUIController> EventOnIconClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnIconClickAction`1_hotfix != null)
				{
					this.m_add_EventOnIconClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroEquipItemUIController> action = this.EventOnIconClick;
				Action<HeroEquipItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroEquipItemUIController>>(ref this.EventOnIconClick, (Action<HeroEquipItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnIconClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnIconClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroEquipItemUIController> action = this.EventOnIconClick;
				Action<HeroEquipItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroEquipItemUIController>>(ref this.EventOnIconClick, (Action<HeroEquipItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000377 RID: 887
		// (add) Token: 0x060105BD RID: 67005 RVA: 0x00445270 File Offset: 0x00443470
		// (remove) Token: 0x060105BE RID: 67006 RVA: 0x0044530C File Offset: 0x0044350C
		public event Action<HeroEquipItemUIController> EventOnRuneIconButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRuneIconButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnRuneIconButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroEquipItemUIController> action = this.EventOnRuneIconButtonClick;
				Action<HeroEquipItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroEquipItemUIController>>(ref this.EventOnRuneIconButtonClick, (Action<HeroEquipItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRuneIconButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnRuneIconButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroEquipItemUIController> action = this.EventOnRuneIconButtonClick;
				Action<HeroEquipItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroEquipItemUIController>>(ref this.EventOnRuneIconButtonClick, (Action<HeroEquipItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x060105BF RID: 67007 RVA: 0x004453A8 File Offset: 0x004435A8
		// (set) Token: 0x060105C0 RID: 67008 RVA: 0x004453C8 File Offset: 0x004435C8
		[DoNotToLua]
		public new HeroEquipItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroEquipItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060105C1 RID: 67009 RVA: 0x004453D4 File Offset: 0x004435D4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060105C2 RID: 67010 RVA: 0x004453E0 File Offset: 0x004435E0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060105C3 RID: 67011 RVA: 0x004453E8 File Offset: 0x004435E8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060105C4 RID: 67012 RVA: 0x004453F0 File Offset: 0x004435F0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060105C5 RID: 67013 RVA: 0x00445404 File Offset: 0x00443604
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060105C6 RID: 67014 RVA: 0x0044540C File Offset: 0x0044360C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060105C7 RID: 67015 RVA: 0x00445418 File Offset: 0x00443618
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060105C8 RID: 67016 RVA: 0x00445424 File Offset: 0x00443624
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060105C9 RID: 67017 RVA: 0x00445430 File Offset: 0x00443630
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060105CA RID: 67018 RVA: 0x0044543C File Offset: 0x0044363C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060105CB RID: 67019 RVA: 0x00445448 File Offset: 0x00443648
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060105CC RID: 67020 RVA: 0x00445454 File Offset: 0x00443654
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060105CD RID: 67021 RVA: 0x00445460 File Offset: 0x00443660
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060105CE RID: 67022 RVA: 0x0044546C File Offset: 0x0044366C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060105CF RID: 67023 RVA: 0x00445478 File Offset: 0x00443678
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060105D0 RID: 67024 RVA: 0x00445480 File Offset: 0x00443680
		private void __callDele_EventOnAddButtonClick(HeroEquipItemUIController obj)
		{
			Action<HeroEquipItemUIController> eventOnAddButtonClick = this.EventOnAddButtonClick;
			if (eventOnAddButtonClick != null)
			{
				eventOnAddButtonClick(obj);
			}
		}

		// Token: 0x060105D1 RID: 67025 RVA: 0x004454A4 File Offset: 0x004436A4
		private void __clearDele_EventOnAddButtonClick(HeroEquipItemUIController obj)
		{
			this.EventOnAddButtonClick = null;
		}

		// Token: 0x060105D2 RID: 67026 RVA: 0x004454B0 File Offset: 0x004436B0
		private void __callDele_EventOnIconClick(HeroEquipItemUIController obj)
		{
			Action<HeroEquipItemUIController> eventOnIconClick = this.EventOnIconClick;
			if (eventOnIconClick != null)
			{
				eventOnIconClick(obj);
			}
		}

		// Token: 0x060105D3 RID: 67027 RVA: 0x004454D4 File Offset: 0x004436D4
		private void __clearDele_EventOnIconClick(HeroEquipItemUIController obj)
		{
			this.EventOnIconClick = null;
		}

		// Token: 0x060105D4 RID: 67028 RVA: 0x004454E0 File Offset: 0x004436E0
		private void __callDele_EventOnRuneIconButtonClick(HeroEquipItemUIController obj)
		{
			Action<HeroEquipItemUIController> eventOnRuneIconButtonClick = this.EventOnRuneIconButtonClick;
			if (eventOnRuneIconButtonClick != null)
			{
				eventOnRuneIconButtonClick(obj);
			}
		}

		// Token: 0x060105D5 RID: 67029 RVA: 0x00445504 File Offset: 0x00443704
		private void __clearDele_EventOnRuneIconButtonClick(HeroEquipItemUIController obj)
		{
			this.EventOnRuneIconButtonClick = null;
		}

		// Token: 0x060105D6 RID: 67030 RVA: 0x00445510 File Offset: 0x00443710
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
					this.m_InitHeroEquipmentItemEquipmentBagItemInt32Int32_hotfix = (luaObj.RawGet("InitHeroEquipmentItem") as LuaFunction);
					this.m_ShowSelectImageBoolean_hotfix = (luaObj.RawGet("ShowSelectImage") as LuaFunction);
					this.m_OnIconClick_hotfix = (luaObj.RawGet("OnIconClick") as LuaFunction);
					this.m_OnAddButtonClick_hotfix = (luaObj.RawGet("OnAddButtonClick") as LuaFunction);
					this.m_OnRuneIconButtonClick_hotfix = (luaObj.RawGet("OnRuneIconButtonClick") as LuaFunction);
					this.m_add_EventOnAddButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnAddButtonClick") as LuaFunction);
					this.m_remove_EventOnAddButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnAddButtonClick") as LuaFunction);
					this.m_add_EventOnIconClickAction`1_hotfix = (luaObj.RawGet("add_EventOnIconClick") as LuaFunction);
					this.m_remove_EventOnIconClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnIconClick") as LuaFunction);
					this.m_add_EventOnRuneIconButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnRuneIconButtonClick") as LuaFunction);
					this.m_remove_EventOnRuneIconButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnRuneIconButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060105D7 RID: 67031 RVA: 0x004456F0 File Offset: 0x004438F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroEquipItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009807 RID: 38919
		[AutoBind("./Content/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconBg;

		// Token: 0x04009808 RID: 38920
		[AutoBind("./Content/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_iconSSREffect;

		// Token: 0x04009809 RID: 38921
		[AutoBind("./Content/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImg;

		// Token: 0x0400980A RID: 38922
		[AutoBind("./Content/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_iconButton;

		// Token: 0x0400980B RID: 38923
		[AutoBind("./Content/Name", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400980C RID: 38924
		[AutoBind("./Content/LV/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lvText;

		// Token: 0x0400980D RID: 38925
		[AutoBind("./Content/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_starGroupg;

		// Token: 0x0400980E RID: 38926
		[AutoBind("./RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_redMarkGo;

		// Token: 0x0400980F RID: 38927
		[AutoBind("./NoEquip/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addButton;

		// Token: 0x04009810 RID: 38928
		[AutoBind("./SelectImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectImage;

		// Token: 0x04009811 RID: 38929
		[AutoBind("./RuneIcon", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_runeIconStateCtrl;

		// Token: 0x04009812 RID: 38930
		[AutoBind("./RuneIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_runeIconButton;

		// Token: 0x04009813 RID: 38931
		[AutoBind("./RuneIcon/Active", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_runeActiveIcon;

		// Token: 0x04009814 RID: 38932
		[AutoBind("./RuneIcon/Unactive", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_runeInactiveIcon;

		// Token: 0x04009815 RID: 38933
		public int Slot;

		// Token: 0x04009816 RID: 38934
		public EquipmentBagItem Equipment;

		// Token: 0x04009817 RID: 38935
		[DoNotToLua]
		private HeroEquipItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009818 RID: 38936
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009819 RID: 38937
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400981A RID: 38938
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400981B RID: 38939
		private LuaFunction m_InitHeroEquipmentItemEquipmentBagItemInt32Int32_hotfix;

		// Token: 0x0400981C RID: 38940
		private LuaFunction m_ShowSelectImageBoolean_hotfix;

		// Token: 0x0400981D RID: 38941
		private LuaFunction m_OnIconClick_hotfix;

		// Token: 0x0400981E RID: 38942
		private LuaFunction m_OnAddButtonClick_hotfix;

		// Token: 0x0400981F RID: 38943
		private LuaFunction m_OnRuneIconButtonClick_hotfix;

		// Token: 0x04009820 RID: 38944
		private LuaFunction m_add_EventOnAddButtonClickAction;

		// Token: 0x04009821 RID: 38945
		private LuaFunction m_remove_EventOnAddButtonClickAction;

		// Token: 0x04009822 RID: 38946
		private LuaFunction m_add_EventOnIconClickAction;

		// Token: 0x04009823 RID: 38947
		private LuaFunction m_remove_EventOnIconClickAction;

		// Token: 0x04009824 RID: 38948
		private LuaFunction m_add_EventOnRuneIconButtonClickAction;

		// Token: 0x04009825 RID: 38949
		private LuaFunction m_remove_EventOnRuneIconButtonClickAction;

		// Token: 0x02000D9B RID: 3483
		public new class LuaExportHelper
		{
			// Token: 0x060105D8 RID: 67032 RVA: 0x00445758 File Offset: 0x00443958
			public LuaExportHelper(HeroEquipItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060105D9 RID: 67033 RVA: 0x00445768 File Offset: 0x00443968
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060105DA RID: 67034 RVA: 0x00445778 File Offset: 0x00443978
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060105DB RID: 67035 RVA: 0x00445788 File Offset: 0x00443988
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060105DC RID: 67036 RVA: 0x00445798 File Offset: 0x00443998
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060105DD RID: 67037 RVA: 0x004457B0 File Offset: 0x004439B0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060105DE RID: 67038 RVA: 0x004457C0 File Offset: 0x004439C0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060105DF RID: 67039 RVA: 0x004457D0 File Offset: 0x004439D0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060105E0 RID: 67040 RVA: 0x004457E0 File Offset: 0x004439E0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060105E1 RID: 67041 RVA: 0x004457F0 File Offset: 0x004439F0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060105E2 RID: 67042 RVA: 0x00445800 File Offset: 0x00443A00
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060105E3 RID: 67043 RVA: 0x00445810 File Offset: 0x00443A10
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060105E4 RID: 67044 RVA: 0x00445820 File Offset: 0x00443A20
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060105E5 RID: 67045 RVA: 0x00445830 File Offset: 0x00443A30
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060105E6 RID: 67046 RVA: 0x00445840 File Offset: 0x00443A40
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060105E7 RID: 67047 RVA: 0x00445850 File Offset: 0x00443A50
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060105E8 RID: 67048 RVA: 0x00445860 File Offset: 0x00443A60
			public void __callDele_EventOnAddButtonClick(HeroEquipItemUIController obj)
			{
				this.m_owner.__callDele_EventOnAddButtonClick(obj);
			}

			// Token: 0x060105E9 RID: 67049 RVA: 0x00445870 File Offset: 0x00443A70
			public void __clearDele_EventOnAddButtonClick(HeroEquipItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnAddButtonClick(obj);
			}

			// Token: 0x060105EA RID: 67050 RVA: 0x00445880 File Offset: 0x00443A80
			public void __callDele_EventOnIconClick(HeroEquipItemUIController obj)
			{
				this.m_owner.__callDele_EventOnIconClick(obj);
			}

			// Token: 0x060105EB RID: 67051 RVA: 0x00445890 File Offset: 0x00443A90
			public void __clearDele_EventOnIconClick(HeroEquipItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnIconClick(obj);
			}

			// Token: 0x060105EC RID: 67052 RVA: 0x004458A0 File Offset: 0x00443AA0
			public void __callDele_EventOnRuneIconButtonClick(HeroEquipItemUIController obj)
			{
				this.m_owner.__callDele_EventOnRuneIconButtonClick(obj);
			}

			// Token: 0x060105ED RID: 67053 RVA: 0x004458B0 File Offset: 0x00443AB0
			public void __clearDele_EventOnRuneIconButtonClick(HeroEquipItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnRuneIconButtonClick(obj);
			}

			// Token: 0x17003273 RID: 12915
			// (get) Token: 0x060105EE RID: 67054 RVA: 0x004458C0 File Offset: 0x00443AC0
			// (set) Token: 0x060105EF RID: 67055 RVA: 0x004458D0 File Offset: 0x00443AD0
			public Image m_iconBg
			{
				get
				{
					return this.m_owner.m_iconBg;
				}
				set
				{
					this.m_owner.m_iconBg = value;
				}
			}

			// Token: 0x17003274 RID: 12916
			// (get) Token: 0x060105F0 RID: 67056 RVA: 0x004458E0 File Offset: 0x00443AE0
			// (set) Token: 0x060105F1 RID: 67057 RVA: 0x004458F0 File Offset: 0x00443AF0
			public GameObject m_iconSSREffect
			{
				get
				{
					return this.m_owner.m_iconSSREffect;
				}
				set
				{
					this.m_owner.m_iconSSREffect = value;
				}
			}

			// Token: 0x17003275 RID: 12917
			// (get) Token: 0x060105F2 RID: 67058 RVA: 0x00445900 File Offset: 0x00443B00
			// (set) Token: 0x060105F3 RID: 67059 RVA: 0x00445910 File Offset: 0x00443B10
			public Image m_iconImg
			{
				get
				{
					return this.m_owner.m_iconImg;
				}
				set
				{
					this.m_owner.m_iconImg = value;
				}
			}

			// Token: 0x17003276 RID: 12918
			// (get) Token: 0x060105F4 RID: 67060 RVA: 0x00445920 File Offset: 0x00443B20
			// (set) Token: 0x060105F5 RID: 67061 RVA: 0x00445930 File Offset: 0x00443B30
			public Button m_iconButton
			{
				get
				{
					return this.m_owner.m_iconButton;
				}
				set
				{
					this.m_owner.m_iconButton = value;
				}
			}

			// Token: 0x17003277 RID: 12919
			// (get) Token: 0x060105F6 RID: 67062 RVA: 0x00445940 File Offset: 0x00443B40
			// (set) Token: 0x060105F7 RID: 67063 RVA: 0x00445950 File Offset: 0x00443B50
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

			// Token: 0x17003278 RID: 12920
			// (get) Token: 0x060105F8 RID: 67064 RVA: 0x00445960 File Offset: 0x00443B60
			// (set) Token: 0x060105F9 RID: 67065 RVA: 0x00445970 File Offset: 0x00443B70
			public Text m_lvText
			{
				get
				{
					return this.m_owner.m_lvText;
				}
				set
				{
					this.m_owner.m_lvText = value;
				}
			}

			// Token: 0x17003279 RID: 12921
			// (get) Token: 0x060105FA RID: 67066 RVA: 0x00445980 File Offset: 0x00443B80
			// (set) Token: 0x060105FB RID: 67067 RVA: 0x00445990 File Offset: 0x00443B90
			public GameObject m_starGroupg
			{
				get
				{
					return this.m_owner.m_starGroupg;
				}
				set
				{
					this.m_owner.m_starGroupg = value;
				}
			}

			// Token: 0x1700327A RID: 12922
			// (get) Token: 0x060105FC RID: 67068 RVA: 0x004459A0 File Offset: 0x00443BA0
			// (set) Token: 0x060105FD RID: 67069 RVA: 0x004459B0 File Offset: 0x00443BB0
			public GameObject m_redMarkGo
			{
				get
				{
					return this.m_owner.m_redMarkGo;
				}
				set
				{
					this.m_owner.m_redMarkGo = value;
				}
			}

			// Token: 0x1700327B RID: 12923
			// (get) Token: 0x060105FE RID: 67070 RVA: 0x004459C0 File Offset: 0x00443BC0
			// (set) Token: 0x060105FF RID: 67071 RVA: 0x004459D0 File Offset: 0x00443BD0
			public Button m_addButton
			{
				get
				{
					return this.m_owner.m_addButton;
				}
				set
				{
					this.m_owner.m_addButton = value;
				}
			}

			// Token: 0x1700327C RID: 12924
			// (get) Token: 0x06010600 RID: 67072 RVA: 0x004459E0 File Offset: 0x00443BE0
			// (set) Token: 0x06010601 RID: 67073 RVA: 0x004459F0 File Offset: 0x00443BF0
			public GameObject m_selectImage
			{
				get
				{
					return this.m_owner.m_selectImage;
				}
				set
				{
					this.m_owner.m_selectImage = value;
				}
			}

			// Token: 0x1700327D RID: 12925
			// (get) Token: 0x06010602 RID: 67074 RVA: 0x00445A00 File Offset: 0x00443C00
			// (set) Token: 0x06010603 RID: 67075 RVA: 0x00445A10 File Offset: 0x00443C10
			public CommonUIStateController m_runeIconStateCtrl
			{
				get
				{
					return this.m_owner.m_runeIconStateCtrl;
				}
				set
				{
					this.m_owner.m_runeIconStateCtrl = value;
				}
			}

			// Token: 0x1700327E RID: 12926
			// (get) Token: 0x06010604 RID: 67076 RVA: 0x00445A20 File Offset: 0x00443C20
			// (set) Token: 0x06010605 RID: 67077 RVA: 0x00445A30 File Offset: 0x00443C30
			public Button m_runeIconButton
			{
				get
				{
					return this.m_owner.m_runeIconButton;
				}
				set
				{
					this.m_owner.m_runeIconButton = value;
				}
			}

			// Token: 0x1700327F RID: 12927
			// (get) Token: 0x06010606 RID: 67078 RVA: 0x00445A40 File Offset: 0x00443C40
			// (set) Token: 0x06010607 RID: 67079 RVA: 0x00445A50 File Offset: 0x00443C50
			public Image m_runeActiveIcon
			{
				get
				{
					return this.m_owner.m_runeActiveIcon;
				}
				set
				{
					this.m_owner.m_runeActiveIcon = value;
				}
			}

			// Token: 0x17003280 RID: 12928
			// (get) Token: 0x06010608 RID: 67080 RVA: 0x00445A60 File Offset: 0x00443C60
			// (set) Token: 0x06010609 RID: 67081 RVA: 0x00445A70 File Offset: 0x00443C70
			public Image m_runeInactiveIcon
			{
				get
				{
					return this.m_owner.m_runeInactiveIcon;
				}
				set
				{
					this.m_owner.m_runeInactiveIcon = value;
				}
			}

			// Token: 0x0601060A RID: 67082 RVA: 0x00445A80 File Offset: 0x00443C80
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601060B RID: 67083 RVA: 0x00445A90 File Offset: 0x00443C90
			public void OnIconClick()
			{
				this.m_owner.OnIconClick();
			}

			// Token: 0x0601060C RID: 67084 RVA: 0x00445AA0 File Offset: 0x00443CA0
			public void OnAddButtonClick()
			{
				this.m_owner.OnAddButtonClick();
			}

			// Token: 0x0601060D RID: 67085 RVA: 0x00445AB0 File Offset: 0x00443CB0
			public void OnRuneIconButtonClick()
			{
				this.m_owner.OnRuneIconButtonClick();
			}

			// Token: 0x04009826 RID: 38950
			private HeroEquipItemUIController m_owner;
		}
	}
}
