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
	// Token: 0x02000D1D RID: 3357
	[HotFix]
	public class GuildMassiveCombatStrongHoldUIController : UIControllerBase
	{
		// Token: 0x0600F746 RID: 63302 RVA: 0x0041580C File Offset: 0x00413A0C
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
			this.m_buttonEx.onClick.AddListener(new UnityAction(this.OnClick));
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x0600F747 RID: 63303 RVA: 0x004158B8 File Offset: 0x00413AB8
		public void InitGuildMassiveCombatStrongHoldInfo(GuildMassiveCombatStronghold strongHold)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGuildMassiveCombatStrongHoldInfoGuildMassiveCombatStronghold_hotfix != null)
			{
				this.m_InitGuildMassiveCombatStrongHoldInfoGuildMassiveCombatStronghold_hotfix.call(new object[]
				{
					this,
					strongHold
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.m_strongHold = strongHold;
			ConfigDataHeroTagInfo configDataHeroTagInfo = this.m_configDataLoader.GetConfigDataHeroTagInfo(strongHold.PreferredHeroTagIds[0]);
			this.m_campImage.sprite = AssetUtility.Instance.GetSprite(configDataHeroTagInfo.Icon);
			ConfigDataGuildMassiveCombatStrongholdInfo configDataGuildMassiveCombatStrongholdInfo = this.m_configDataLoader.GetConfigDataGuildMassiveCombatStrongholdInfo(strongHold.ConfigId);
			this.m_icon.sprite = AssetUtility.Instance.GetSprite(configDataGuildMassiveCombatStrongholdInfo.Resources);
			this.SetSuppressText();
		}

		// Token: 0x0600F748 RID: 63304 RVA: 0x004159A4 File Offset: 0x00413BA4
		public void SetSuppressText()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuppressText_hotfix != null)
			{
				this.m_SetSuppressText_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int guildMassiveCombatStrongholdEliminateRate = this.m_playerContext.GetGuildMassiveCombatStrongholdEliminateRate(this.m_strongHold);
			if (guildMassiveCombatStrongholdEliminateRate == 100)
			{
				this.m_stateCtrl.SetToUIState("Suppress", false, true);
			}
			else
			{
				this.m_suppressValueText.text = guildMassiveCombatStrongholdEliminateRate + "%";
				this.m_stateCtrl.SetToUIState("Normal", false, true);
			}
		}

		// Token: 0x0600F749 RID: 63305 RVA: 0x00415A64 File Offset: 0x00413C64
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
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x14000345 RID: 837
		// (add) Token: 0x0600F74A RID: 63306 RVA: 0x00415ADC File Offset: 0x00413CDC
		// (remove) Token: 0x0600F74B RID: 63307 RVA: 0x00415B78 File Offset: 0x00413D78
		public event Action<GuildMassiveCombatStrongHoldUIController> EventOnClick
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
				Action<GuildMassiveCombatStrongHoldUIController> action = this.EventOnClick;
				Action<GuildMassiveCombatStrongHoldUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildMassiveCombatStrongHoldUIController>>(ref this.EventOnClick, (Action<GuildMassiveCombatStrongHoldUIController>)Delegate.Combine(action2, value), action);
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
				Action<GuildMassiveCombatStrongHoldUIController> action = this.EventOnClick;
				Action<GuildMassiveCombatStrongHoldUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildMassiveCombatStrongHoldUIController>>(ref this.EventOnClick, (Action<GuildMassiveCombatStrongHoldUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x0600F74C RID: 63308 RVA: 0x00415C14 File Offset: 0x00413E14
		// (set) Token: 0x0600F74D RID: 63309 RVA: 0x00415C34 File Offset: 0x00413E34
		[DoNotToLua]
		public new GuildMassiveCombatStrongHoldUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildMassiveCombatStrongHoldUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F74E RID: 63310 RVA: 0x00415C40 File Offset: 0x00413E40
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F74F RID: 63311 RVA: 0x00415C4C File Offset: 0x00413E4C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F750 RID: 63312 RVA: 0x00415C54 File Offset: 0x00413E54
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F751 RID: 63313 RVA: 0x00415C5C File Offset: 0x00413E5C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F752 RID: 63314 RVA: 0x00415C70 File Offset: 0x00413E70
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F753 RID: 63315 RVA: 0x00415C78 File Offset: 0x00413E78
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F754 RID: 63316 RVA: 0x00415C84 File Offset: 0x00413E84
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F755 RID: 63317 RVA: 0x00415C90 File Offset: 0x00413E90
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F756 RID: 63318 RVA: 0x00415C9C File Offset: 0x00413E9C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F757 RID: 63319 RVA: 0x00415CA8 File Offset: 0x00413EA8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F758 RID: 63320 RVA: 0x00415CB4 File Offset: 0x00413EB4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F759 RID: 63321 RVA: 0x00415CC0 File Offset: 0x00413EC0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F75A RID: 63322 RVA: 0x00415CCC File Offset: 0x00413ECC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F75B RID: 63323 RVA: 0x00415CD8 File Offset: 0x00413ED8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F75C RID: 63324 RVA: 0x00415CE4 File Offset: 0x00413EE4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F75D RID: 63325 RVA: 0x00415CEC File Offset: 0x00413EEC
		private void __callDele_EventOnClick(GuildMassiveCombatStrongHoldUIController obj)
		{
			Action<GuildMassiveCombatStrongHoldUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600F75E RID: 63326 RVA: 0x00415D10 File Offset: 0x00413F10
		private void __clearDele_EventOnClick(GuildMassiveCombatStrongHoldUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600F75F RID: 63327 RVA: 0x00415D1C File Offset: 0x00413F1C
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
					this.m_InitGuildMassiveCombatStrongHoldInfoGuildMassiveCombatStronghold_hotfix = (luaObj.RawGet("InitGuildMassiveCombatStrongHoldInfo") as LuaFunction);
					this.m_SetSuppressText_hotfix = (luaObj.RawGet("SetSuppressText") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F760 RID: 63328 RVA: 0x00415E64 File Offset: 0x00414064
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatStrongHoldUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040091F1 RID: 37361
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x040091F2 RID: 37362
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private ButtonEx m_buttonEx;

		// Token: 0x040091F3 RID: 37363
		[AutoBind("./SuppressGroup/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_suppressValueText;

		// Token: 0x040091F4 RID: 37364
		[AutoBind("./CampImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_campImage;

		// Token: 0x040091F5 RID: 37365
		[AutoBind("./Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_icon;

		// Token: 0x040091F6 RID: 37366
		public GuildMassiveCombatStronghold m_strongHold;

		// Token: 0x040091F7 RID: 37367
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040091F8 RID: 37368
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040091F9 RID: 37369
		[DoNotToLua]
		private GuildMassiveCombatStrongHoldUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040091FA RID: 37370
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040091FB RID: 37371
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040091FC RID: 37372
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040091FD RID: 37373
		private LuaFunction m_InitGuildMassiveCombatStrongHoldInfoGuildMassiveCombatStronghold_hotfix;

		// Token: 0x040091FE RID: 37374
		private LuaFunction m_SetSuppressText_hotfix;

		// Token: 0x040091FF RID: 37375
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x04009200 RID: 37376
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04009201 RID: 37377
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000D1E RID: 3358
		public new class LuaExportHelper
		{
			// Token: 0x0600F761 RID: 63329 RVA: 0x00415ECC File Offset: 0x004140CC
			public LuaExportHelper(GuildMassiveCombatStrongHoldUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F762 RID: 63330 RVA: 0x00415EDC File Offset: 0x004140DC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F763 RID: 63331 RVA: 0x00415EEC File Offset: 0x004140EC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F764 RID: 63332 RVA: 0x00415EFC File Offset: 0x004140FC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F765 RID: 63333 RVA: 0x00415F0C File Offset: 0x0041410C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F766 RID: 63334 RVA: 0x00415F24 File Offset: 0x00414124
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F767 RID: 63335 RVA: 0x00415F34 File Offset: 0x00414134
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F768 RID: 63336 RVA: 0x00415F44 File Offset: 0x00414144
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F769 RID: 63337 RVA: 0x00415F54 File Offset: 0x00414154
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F76A RID: 63338 RVA: 0x00415F64 File Offset: 0x00414164
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F76B RID: 63339 RVA: 0x00415F74 File Offset: 0x00414174
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F76C RID: 63340 RVA: 0x00415F84 File Offset: 0x00414184
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F76D RID: 63341 RVA: 0x00415F94 File Offset: 0x00414194
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F76E RID: 63342 RVA: 0x00415FA4 File Offset: 0x004141A4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F76F RID: 63343 RVA: 0x00415FB4 File Offset: 0x004141B4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F770 RID: 63344 RVA: 0x00415FC4 File Offset: 0x004141C4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F771 RID: 63345 RVA: 0x00415FD4 File Offset: 0x004141D4
			public void __callDele_EventOnClick(GuildMassiveCombatStrongHoldUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600F772 RID: 63346 RVA: 0x00415FE4 File Offset: 0x004141E4
			public void __clearDele_EventOnClick(GuildMassiveCombatStrongHoldUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002F67 RID: 12135
			// (get) Token: 0x0600F773 RID: 63347 RVA: 0x00415FF4 File Offset: 0x004141F4
			// (set) Token: 0x0600F774 RID: 63348 RVA: 0x00416004 File Offset: 0x00414204
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x17002F68 RID: 12136
			// (get) Token: 0x0600F775 RID: 63349 RVA: 0x00416014 File Offset: 0x00414214
			// (set) Token: 0x0600F776 RID: 63350 RVA: 0x00416024 File Offset: 0x00414224
			public ButtonEx m_buttonEx
			{
				get
				{
					return this.m_owner.m_buttonEx;
				}
				set
				{
					this.m_owner.m_buttonEx = value;
				}
			}

			// Token: 0x17002F69 RID: 12137
			// (get) Token: 0x0600F777 RID: 63351 RVA: 0x00416034 File Offset: 0x00414234
			// (set) Token: 0x0600F778 RID: 63352 RVA: 0x00416044 File Offset: 0x00414244
			public Text m_suppressValueText
			{
				get
				{
					return this.m_owner.m_suppressValueText;
				}
				set
				{
					this.m_owner.m_suppressValueText = value;
				}
			}

			// Token: 0x17002F6A RID: 12138
			// (get) Token: 0x0600F779 RID: 63353 RVA: 0x00416054 File Offset: 0x00414254
			// (set) Token: 0x0600F77A RID: 63354 RVA: 0x00416064 File Offset: 0x00414264
			public Image m_campImage
			{
				get
				{
					return this.m_owner.m_campImage;
				}
				set
				{
					this.m_owner.m_campImage = value;
				}
			}

			// Token: 0x17002F6B RID: 12139
			// (get) Token: 0x0600F77B RID: 63355 RVA: 0x00416074 File Offset: 0x00414274
			// (set) Token: 0x0600F77C RID: 63356 RVA: 0x00416084 File Offset: 0x00414284
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

			// Token: 0x17002F6C RID: 12140
			// (get) Token: 0x0600F77D RID: 63357 RVA: 0x00416094 File Offset: 0x00414294
			// (set) Token: 0x0600F77E RID: 63358 RVA: 0x004160A4 File Offset: 0x004142A4
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

			// Token: 0x17002F6D RID: 12141
			// (get) Token: 0x0600F77F RID: 63359 RVA: 0x004160B4 File Offset: 0x004142B4
			// (set) Token: 0x0600F780 RID: 63360 RVA: 0x004160C4 File Offset: 0x004142C4
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

			// Token: 0x0600F781 RID: 63361 RVA: 0x004160D4 File Offset: 0x004142D4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F782 RID: 63362 RVA: 0x004160E4 File Offset: 0x004142E4
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x04009202 RID: 37378
			private GuildMassiveCombatStrongHoldUIController m_owner;
		}
	}
}
