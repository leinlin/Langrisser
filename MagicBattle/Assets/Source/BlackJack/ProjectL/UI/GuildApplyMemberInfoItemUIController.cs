using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D00 RID: 3328
	[HotFix]
	public class GuildApplyMemberInfoItemUIController : UIControllerBase
	{
		// Token: 0x0600F531 RID: 62769 RVA: 0x0040EB0C File Offset: 0x0040CD0C
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
			this.m_refuseButton.onClick.AddListener(new UnityAction(this.OnRefuseClick));
			this.m_agreeButton.onClick.AddListener(new UnityAction(this.OnAgreeClick));
		}

		// Token: 0x0600F532 RID: 62770 RVA: 0x0040EBAC File Offset: 0x0040CDAC
		public void InitItemInfo(UserSummary player)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitItemInfoUserSummary_hotfix != null)
			{
				this.m_InitItemInfoUserSummary_hotfix.call(new object[]
				{
					this,
					player
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Player = player;
			base.gameObject.SetActive(true);
			this.m_headIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(player.HeadIcon)));
			UIUtility.SetPlayerHeadFrame(this.m_HeadFrameDummy, HeadIconTools.GetHeadFrame(player.HeadIcon), true, "Normal");
			this.m_levelText.text = player.Level.ToString();
			this.m_nameText.text = player.Name;
			this.m_powerText.text = player.TopHeroBattlePower.ToString();
			this.m_headIconStateCtrl.SetToUIState((!player.Online) ? "Offline" : "Online", false, true);
			if (!player.Online)
			{
				this.m_headIconGrey.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(player.HeadIcon)));
			}
		}

		// Token: 0x0600F533 RID: 62771 RVA: 0x0040ED14 File Offset: 0x0040CF14
		private void OnAgreeClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAgreeClick_hotfix != null)
			{
				this.m_OnAgreeClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAcceptResult != null)
			{
				this.EventOnAcceptResult(this, true);
			}
		}

		// Token: 0x0600F534 RID: 62772 RVA: 0x0040ED8C File Offset: 0x0040CF8C
		private void OnRefuseClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRefuseClick_hotfix != null)
			{
				this.m_OnRefuseClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAcceptResult != null)
			{
				this.EventOnAcceptResult(this, false);
			}
		}

		// Token: 0x1400033F RID: 831
		// (add) Token: 0x0600F535 RID: 62773 RVA: 0x0040EE04 File Offset: 0x0040D004
		// (remove) Token: 0x0600F536 RID: 62774 RVA: 0x0040EEA0 File Offset: 0x0040D0A0
		public event Action<GuildApplyMemberInfoItemUIController, bool> EventOnAcceptResult
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAcceptResultAction`2_hotfix != null)
				{
					this.m_add_EventOnAcceptResultAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GuildApplyMemberInfoItemUIController, bool> action = this.EventOnAcceptResult;
				Action<GuildApplyMemberInfoItemUIController, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildApplyMemberInfoItemUIController, bool>>(ref this.EventOnAcceptResult, (Action<GuildApplyMemberInfoItemUIController, bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAcceptResultAction`2_hotfix != null)
				{
					this.m_remove_EventOnAcceptResultAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GuildApplyMemberInfoItemUIController, bool> action = this.EventOnAcceptResult;
				Action<GuildApplyMemberInfoItemUIController, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildApplyMemberInfoItemUIController, bool>>(ref this.EventOnAcceptResult, (Action<GuildApplyMemberInfoItemUIController, bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0600F537 RID: 62775 RVA: 0x0040EF3C File Offset: 0x0040D13C
		// (set) Token: 0x0600F538 RID: 62776 RVA: 0x0040EFB0 File Offset: 0x0040D1B0
		public UserSummary Player
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Player_hotfix != null)
				{
					return (UserSummary)this.m_get_Player_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Player>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_PlayerUserSummary_hotfix != null)
				{
					this.m_set_PlayerUserSummary_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Player>k__BackingField = value;
			}
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x0600F539 RID: 62777 RVA: 0x0040F028 File Offset: 0x0040D228
		// (set) Token: 0x0600F53A RID: 62778 RVA: 0x0040F048 File Offset: 0x0040D248
		[DoNotToLua]
		public new GuildApplyMemberInfoItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildApplyMemberInfoItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F53B RID: 62779 RVA: 0x0040F054 File Offset: 0x0040D254
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F53C RID: 62780 RVA: 0x0040F060 File Offset: 0x0040D260
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F53D RID: 62781 RVA: 0x0040F068 File Offset: 0x0040D268
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F53E RID: 62782 RVA: 0x0040F070 File Offset: 0x0040D270
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F53F RID: 62783 RVA: 0x0040F084 File Offset: 0x0040D284
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F540 RID: 62784 RVA: 0x0040F08C File Offset: 0x0040D28C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F541 RID: 62785 RVA: 0x0040F098 File Offset: 0x0040D298
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F542 RID: 62786 RVA: 0x0040F0A4 File Offset: 0x0040D2A4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F543 RID: 62787 RVA: 0x0040F0B0 File Offset: 0x0040D2B0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F544 RID: 62788 RVA: 0x0040F0BC File Offset: 0x0040D2BC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F545 RID: 62789 RVA: 0x0040F0C8 File Offset: 0x0040D2C8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F546 RID: 62790 RVA: 0x0040F0D4 File Offset: 0x0040D2D4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F547 RID: 62791 RVA: 0x0040F0E0 File Offset: 0x0040D2E0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F548 RID: 62792 RVA: 0x0040F0EC File Offset: 0x0040D2EC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F549 RID: 62793 RVA: 0x0040F0F8 File Offset: 0x0040D2F8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F54A RID: 62794 RVA: 0x0040F100 File Offset: 0x0040D300
		private void __callDele_EventOnAcceptResult(GuildApplyMemberInfoItemUIController arg1, bool arg2)
		{
			Action<GuildApplyMemberInfoItemUIController, bool> eventOnAcceptResult = this.EventOnAcceptResult;
			if (eventOnAcceptResult != null)
			{
				eventOnAcceptResult(arg1, arg2);
			}
		}

		// Token: 0x0600F54B RID: 62795 RVA: 0x0040F124 File Offset: 0x0040D324
		private void __clearDele_EventOnAcceptResult(GuildApplyMemberInfoItemUIController arg1, bool arg2)
		{
			this.EventOnAcceptResult = null;
		}

		// Token: 0x0600F54C RID: 62796 RVA: 0x0040F130 File Offset: 0x0040D330
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
					this.m_InitItemInfoUserSummary_hotfix = (luaObj.RawGet("InitItemInfo") as LuaFunction);
					this.m_OnAgreeClick_hotfix = (luaObj.RawGet("OnAgreeClick") as LuaFunction);
					this.m_OnRefuseClick_hotfix = (luaObj.RawGet("OnRefuseClick") as LuaFunction);
					this.m_add_EventOnAcceptResultAction`2_hotfix = (luaObj.RawGet("add_EventOnAcceptResult") as LuaFunction);
					this.m_remove_EventOnAcceptResultAction`2_hotfix = (luaObj.RawGet("remove_EventOnAcceptResult") as LuaFunction);
					this.m_get_Player_hotfix = (luaObj.RawGet("get_Player") as LuaFunction);
					this.m_set_PlayerUserSummary_hotfix = (luaObj.RawGet("set_Player") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F54D RID: 62797 RVA: 0x0040F2AC File Offset: 0x0040D4AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildApplyMemberInfoItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400910D RID: 37133
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_headIconStateCtrl;

		// Token: 0x0400910E RID: 37134
		[AutoBind("./Char/HeadIcon/HeadIconGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIconGrey;

		// Token: 0x0400910F RID: 37135
		[AutoBind("./Char/HeadIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIcon;

		// Token: 0x04009110 RID: 37136
		[AutoBind("./Char/HeadIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_HeadFrameDummy;

		// Token: 0x04009111 RID: 37137
		[AutoBind("./Char/HeadIcon/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x04009112 RID: 37138
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04009113 RID: 37139
		[AutoBind("./PowerValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_powerText;

		// Token: 0x04009114 RID: 37140
		[AutoBind("./RefuseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_refuseButton;

		// Token: 0x04009115 RID: 37141
		[AutoBind("./AgreeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_agreeButton;

		// Token: 0x04009117 RID: 37143
		[DoNotToLua]
		private GuildApplyMemberInfoItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009118 RID: 37144
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009119 RID: 37145
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400911A RID: 37146
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400911B RID: 37147
		private LuaFunction m_InitItemInfoUserSummary_hotfix;

		// Token: 0x0400911C RID: 37148
		private LuaFunction m_OnAgreeClick_hotfix;

		// Token: 0x0400911D RID: 37149
		private LuaFunction m_OnRefuseClick_hotfix;

		// Token: 0x0400911E RID: 37150
		private LuaFunction m_add_EventOnAcceptResultAction;

		// Token: 0x0400911F RID: 37151
		private LuaFunction m_remove_EventOnAcceptResultAction;

		// Token: 0x04009120 RID: 37152
		private LuaFunction m_get_Player_hotfix;

		// Token: 0x04009121 RID: 37153
		private LuaFunction m_set_PlayerUserSummary_hotfix;

		// Token: 0x02000D01 RID: 3329
		public new class LuaExportHelper
		{
			// Token: 0x0600F54E RID: 62798 RVA: 0x0040F314 File Offset: 0x0040D514
			public LuaExportHelper(GuildApplyMemberInfoItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F54F RID: 62799 RVA: 0x0040F324 File Offset: 0x0040D524
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F550 RID: 62800 RVA: 0x0040F334 File Offset: 0x0040D534
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F551 RID: 62801 RVA: 0x0040F344 File Offset: 0x0040D544
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F552 RID: 62802 RVA: 0x0040F354 File Offset: 0x0040D554
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F553 RID: 62803 RVA: 0x0040F36C File Offset: 0x0040D56C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F554 RID: 62804 RVA: 0x0040F37C File Offset: 0x0040D57C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F555 RID: 62805 RVA: 0x0040F38C File Offset: 0x0040D58C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F556 RID: 62806 RVA: 0x0040F39C File Offset: 0x0040D59C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F557 RID: 62807 RVA: 0x0040F3AC File Offset: 0x0040D5AC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F558 RID: 62808 RVA: 0x0040F3BC File Offset: 0x0040D5BC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F559 RID: 62809 RVA: 0x0040F3CC File Offset: 0x0040D5CC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F55A RID: 62810 RVA: 0x0040F3DC File Offset: 0x0040D5DC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F55B RID: 62811 RVA: 0x0040F3EC File Offset: 0x0040D5EC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F55C RID: 62812 RVA: 0x0040F3FC File Offset: 0x0040D5FC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F55D RID: 62813 RVA: 0x0040F40C File Offset: 0x0040D60C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F55E RID: 62814 RVA: 0x0040F41C File Offset: 0x0040D61C
			public void __callDele_EventOnAcceptResult(GuildApplyMemberInfoItemUIController arg1, bool arg2)
			{
				this.m_owner.__callDele_EventOnAcceptResult(arg1, arg2);
			}

			// Token: 0x0600F55F RID: 62815 RVA: 0x0040F42C File Offset: 0x0040D62C
			public void __clearDele_EventOnAcceptResult(GuildApplyMemberInfoItemUIController arg1, bool arg2)
			{
				this.m_owner.__clearDele_EventOnAcceptResult(arg1, arg2);
			}

			// Token: 0x17002F1E RID: 12062
			// (get) Token: 0x0600F560 RID: 62816 RVA: 0x0040F43C File Offset: 0x0040D63C
			// (set) Token: 0x0600F561 RID: 62817 RVA: 0x0040F44C File Offset: 0x0040D64C
			public CommonUIStateController m_headIconStateCtrl
			{
				get
				{
					return this.m_owner.m_headIconStateCtrl;
				}
				set
				{
					this.m_owner.m_headIconStateCtrl = value;
				}
			}

			// Token: 0x17002F1F RID: 12063
			// (get) Token: 0x0600F562 RID: 62818 RVA: 0x0040F45C File Offset: 0x0040D65C
			// (set) Token: 0x0600F563 RID: 62819 RVA: 0x0040F46C File Offset: 0x0040D66C
			public Image m_headIconGrey
			{
				get
				{
					return this.m_owner.m_headIconGrey;
				}
				set
				{
					this.m_owner.m_headIconGrey = value;
				}
			}

			// Token: 0x17002F20 RID: 12064
			// (get) Token: 0x0600F564 RID: 62820 RVA: 0x0040F47C File Offset: 0x0040D67C
			// (set) Token: 0x0600F565 RID: 62821 RVA: 0x0040F48C File Offset: 0x0040D68C
			public Image m_headIcon
			{
				get
				{
					return this.m_owner.m_headIcon;
				}
				set
				{
					this.m_owner.m_headIcon = value;
				}
			}

			// Token: 0x17002F21 RID: 12065
			// (get) Token: 0x0600F566 RID: 62822 RVA: 0x0040F49C File Offset: 0x0040D69C
			// (set) Token: 0x0600F567 RID: 62823 RVA: 0x0040F4AC File Offset: 0x0040D6AC
			public Transform m_HeadFrameDummy
			{
				get
				{
					return this.m_owner.m_HeadFrameDummy;
				}
				set
				{
					this.m_owner.m_HeadFrameDummy = value;
				}
			}

			// Token: 0x17002F22 RID: 12066
			// (get) Token: 0x0600F568 RID: 62824 RVA: 0x0040F4BC File Offset: 0x0040D6BC
			// (set) Token: 0x0600F569 RID: 62825 RVA: 0x0040F4CC File Offset: 0x0040D6CC
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x17002F23 RID: 12067
			// (get) Token: 0x0600F56A RID: 62826 RVA: 0x0040F4DC File Offset: 0x0040D6DC
			// (set) Token: 0x0600F56B RID: 62827 RVA: 0x0040F4EC File Offset: 0x0040D6EC
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

			// Token: 0x17002F24 RID: 12068
			// (get) Token: 0x0600F56C RID: 62828 RVA: 0x0040F4FC File Offset: 0x0040D6FC
			// (set) Token: 0x0600F56D RID: 62829 RVA: 0x0040F50C File Offset: 0x0040D70C
			public Text m_powerText
			{
				get
				{
					return this.m_owner.m_powerText;
				}
				set
				{
					this.m_owner.m_powerText = value;
				}
			}

			// Token: 0x17002F25 RID: 12069
			// (get) Token: 0x0600F56E RID: 62830 RVA: 0x0040F51C File Offset: 0x0040D71C
			// (set) Token: 0x0600F56F RID: 62831 RVA: 0x0040F52C File Offset: 0x0040D72C
			public Button m_refuseButton
			{
				get
				{
					return this.m_owner.m_refuseButton;
				}
				set
				{
					this.m_owner.m_refuseButton = value;
				}
			}

			// Token: 0x17002F26 RID: 12070
			// (get) Token: 0x0600F570 RID: 62832 RVA: 0x0040F53C File Offset: 0x0040D73C
			// (set) Token: 0x0600F571 RID: 62833 RVA: 0x0040F54C File Offset: 0x0040D74C
			public Button m_agreeButton
			{
				get
				{
					return this.m_owner.m_agreeButton;
				}
				set
				{
					this.m_owner.m_agreeButton = value;
				}
			}

			// Token: 0x17002F27 RID: 12071
			// (set) Token: 0x0600F572 RID: 62834 RVA: 0x0040F55C File Offset: 0x0040D75C
			public UserSummary Player
			{
				set
				{
					this.m_owner.Player = value;
				}
			}

			// Token: 0x0600F573 RID: 62835 RVA: 0x0040F56C File Offset: 0x0040D76C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F574 RID: 62836 RVA: 0x0040F57C File Offset: 0x0040D77C
			public void OnAgreeClick()
			{
				this.m_owner.OnAgreeClick();
			}

			// Token: 0x0600F575 RID: 62837 RVA: 0x0040F58C File Offset: 0x0040D78C
			public void OnRefuseClick()
			{
				this.m_owner.OnRefuseClick();
			}

			// Token: 0x04009122 RID: 37154
			private GuildApplyMemberInfoItemUIController m_owner;
		}
	}
}
