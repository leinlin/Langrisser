using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D04 RID: 3332
	[HotFix]
	public class GuildInviteMemberInfoItemUIController : UIControllerBase
	{
		// Token: 0x0600F5A2 RID: 62882 RVA: 0x0040FAE4 File Offset: 0x0040DCE4
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
			this.m_addButton.onClick.AddListener(new UnityAction(this.OnAddClick));
		}

		// Token: 0x0600F5A3 RID: 62883 RVA: 0x0040FB68 File Offset: 0x0040DD68
		public void InitPlayerInfo(UserSummary player, bool isInvited)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitPlayerInfoUserSummaryBoolean_hotfix != null)
			{
				this.m_InitPlayerInfoUserSummaryBoolean_hotfix.call(new object[]
				{
					this,
					player,
					isInvited
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isAdd = isInvited;
			this.InvitePlayer = player;
			base.gameObject.SetActive(true);
			this.m_headIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(player.HeadIcon)));
			UIUtility.SetPlayerHeadFrame(this.m_HeadFrameDummy, HeadIconTools.GetHeadFrame(player.HeadIcon), true, "Normal");
			this.m_levelText.text = player.Level.ToString();
			this.m_nameText.text = player.Name.ToString();
			this.m_powerText.text = player.TopHeroBattlePower.ToString();
			this.m_onlineStateCtrl.SetToUIState((!player.Online) ? "Offline" : "Online", false, true);
			this.m_headIconStateCtrl.SetToUIState((!player.Online) ? "Offline" : "Online", false, true);
			if (!player.Online)
			{
				this.m_OffLineText.text = UIUtility.GetMemberOnlineText(player.Online, player.LogoutTime);
				this.m_headIconGrey.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(player.HeadIcon)));
			}
			this.m_addButtonStateCtrl.SetToUIState((!this.m_isAdd) ? "Add" : "Done", false, true);
		}

		// Token: 0x0600F5A4 RID: 62884 RVA: 0x0040FD54 File Offset: 0x0040DF54
		private void OnAddClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddClick_hotfix != null)
			{
				this.m_OnAddClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isAdd)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			Guild guildInfo = projectLPlayerContext.GetGuildInfo();
			if (guildInfo.IsMemberFull)
			{
				CommonUIController.Instance.ShowErrorMessage(-5224, 2f, null, true);
				return;
			}
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
			this.m_isAdd = !this.m_isAdd;
			this.m_addButtonStateCtrl.SetToUIState((!this.m_isAdd) ? "Add" : "Done", false, true);
		}

		// Token: 0x14000340 RID: 832
		// (add) Token: 0x0600F5A5 RID: 62885 RVA: 0x0040FE48 File Offset: 0x0040E048
		// (remove) Token: 0x0600F5A6 RID: 62886 RVA: 0x0040FEE4 File Offset: 0x0040E0E4
		public event Action<GuildInviteMemberInfoItemUIController> EventOnClick
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
				Action<GuildInviteMemberInfoItemUIController> action = this.EventOnClick;
				Action<GuildInviteMemberInfoItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildInviteMemberInfoItemUIController>>(ref this.EventOnClick, (Action<GuildInviteMemberInfoItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<GuildInviteMemberInfoItemUIController> action = this.EventOnClick;
				Action<GuildInviteMemberInfoItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildInviteMemberInfoItemUIController>>(ref this.EventOnClick, (Action<GuildInviteMemberInfoItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0600F5A7 RID: 62887 RVA: 0x0040FF80 File Offset: 0x0040E180
		// (set) Token: 0x0600F5A8 RID: 62888 RVA: 0x0040FFF4 File Offset: 0x0040E1F4
		public UserSummary InvitePlayer
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_InvitePlayer_hotfix != null)
				{
					return (UserSummary)this.m_get_InvitePlayer_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<InvitePlayer>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_InvitePlayerUserSummary_hotfix != null)
				{
					this.m_set_InvitePlayerUserSummary_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<InvitePlayer>k__BackingField = value;
			}
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0600F5A9 RID: 62889 RVA: 0x0041006C File Offset: 0x0040E26C
		// (set) Token: 0x0600F5AA RID: 62890 RVA: 0x0041008C File Offset: 0x0040E28C
		[DoNotToLua]
		public new GuildInviteMemberInfoItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildInviteMemberInfoItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F5AB RID: 62891 RVA: 0x00410098 File Offset: 0x0040E298
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F5AC RID: 62892 RVA: 0x004100A4 File Offset: 0x0040E2A4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F5AD RID: 62893 RVA: 0x004100AC File Offset: 0x0040E2AC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F5AE RID: 62894 RVA: 0x004100B4 File Offset: 0x0040E2B4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F5AF RID: 62895 RVA: 0x004100C8 File Offset: 0x0040E2C8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F5B0 RID: 62896 RVA: 0x004100D0 File Offset: 0x0040E2D0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F5B1 RID: 62897 RVA: 0x004100DC File Offset: 0x0040E2DC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F5B2 RID: 62898 RVA: 0x004100E8 File Offset: 0x0040E2E8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F5B3 RID: 62899 RVA: 0x004100F4 File Offset: 0x0040E2F4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F5B4 RID: 62900 RVA: 0x00410100 File Offset: 0x0040E300
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F5B5 RID: 62901 RVA: 0x0041010C File Offset: 0x0040E30C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F5B6 RID: 62902 RVA: 0x00410118 File Offset: 0x0040E318
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F5B7 RID: 62903 RVA: 0x00410124 File Offset: 0x0040E324
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F5B8 RID: 62904 RVA: 0x00410130 File Offset: 0x0040E330
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F5B9 RID: 62905 RVA: 0x0041013C File Offset: 0x0040E33C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F5BA RID: 62906 RVA: 0x00410144 File Offset: 0x0040E344
		private void __callDele_EventOnClick(GuildInviteMemberInfoItemUIController obj)
		{
			Action<GuildInviteMemberInfoItemUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600F5BB RID: 62907 RVA: 0x00410168 File Offset: 0x0040E368
		private void __clearDele_EventOnClick(GuildInviteMemberInfoItemUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600F5BC RID: 62908 RVA: 0x00410174 File Offset: 0x0040E374
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
					this.m_InitPlayerInfoUserSummaryBoolean_hotfix = (luaObj.RawGet("InitPlayerInfo") as LuaFunction);
					this.m_OnAddClick_hotfix = (luaObj.RawGet("OnAddClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					this.m_get_InvitePlayer_hotfix = (luaObj.RawGet("get_InvitePlayer") as LuaFunction);
					this.m_set_InvitePlayerUserSummary_hotfix = (luaObj.RawGet("set_InvitePlayer") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F5BD RID: 62909 RVA: 0x004102D8 File Offset: 0x0040E4D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildInviteMemberInfoItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400912C RID: 37164
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_headIconStateCtrl;

		// Token: 0x0400912D RID: 37165
		[AutoBind("./Char/HeadIcon/HeadIconGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIconGrey;

		// Token: 0x0400912E RID: 37166
		[AutoBind("./Char/HeadIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIcon;

		// Token: 0x0400912F RID: 37167
		[AutoBind("./Char/HeadIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_HeadFrameDummy;

		// Token: 0x04009130 RID: 37168
		[AutoBind("./Char/HeadIcon/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x04009131 RID: 37169
		[AutoBind("./Char/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04009132 RID: 37170
		[AutoBind("./PeopleValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_powerText;

		// Token: 0x04009133 RID: 37171
		[AutoBind("./AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addButton;

		// Token: 0x04009134 RID: 37172
		[AutoBind("./AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_addButtonStateCtrl;

		// Token: 0x04009135 RID: 37173
		[AutoBind("./StateGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_onlineStateCtrl;

		// Token: 0x04009136 RID: 37174
		[AutoBind("./StateGroup/OffLine/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_OffLineText;

		// Token: 0x04009137 RID: 37175
		private bool m_isAdd;

		// Token: 0x04009139 RID: 37177
		[DoNotToLua]
		private GuildInviteMemberInfoItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400913A RID: 37178
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400913B RID: 37179
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400913C RID: 37180
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400913D RID: 37181
		private LuaFunction m_InitPlayerInfoUserSummaryBoolean_hotfix;

		// Token: 0x0400913E RID: 37182
		private LuaFunction m_OnAddClick_hotfix;

		// Token: 0x0400913F RID: 37183
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04009140 RID: 37184
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x04009141 RID: 37185
		private LuaFunction m_get_InvitePlayer_hotfix;

		// Token: 0x04009142 RID: 37186
		private LuaFunction m_set_InvitePlayerUserSummary_hotfix;

		// Token: 0x02000D05 RID: 3333
		public new class LuaExportHelper
		{
			// Token: 0x0600F5BE RID: 62910 RVA: 0x00410340 File Offset: 0x0040E540
			public LuaExportHelper(GuildInviteMemberInfoItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F5BF RID: 62911 RVA: 0x00410350 File Offset: 0x0040E550
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F5C0 RID: 62912 RVA: 0x00410360 File Offset: 0x0040E560
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F5C1 RID: 62913 RVA: 0x00410370 File Offset: 0x0040E570
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F5C2 RID: 62914 RVA: 0x00410380 File Offset: 0x0040E580
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F5C3 RID: 62915 RVA: 0x00410398 File Offset: 0x0040E598
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F5C4 RID: 62916 RVA: 0x004103A8 File Offset: 0x0040E5A8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F5C5 RID: 62917 RVA: 0x004103B8 File Offset: 0x0040E5B8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F5C6 RID: 62918 RVA: 0x004103C8 File Offset: 0x0040E5C8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F5C7 RID: 62919 RVA: 0x004103D8 File Offset: 0x0040E5D8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F5C8 RID: 62920 RVA: 0x004103E8 File Offset: 0x0040E5E8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F5C9 RID: 62921 RVA: 0x004103F8 File Offset: 0x0040E5F8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F5CA RID: 62922 RVA: 0x00410408 File Offset: 0x0040E608
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F5CB RID: 62923 RVA: 0x00410418 File Offset: 0x0040E618
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F5CC RID: 62924 RVA: 0x00410428 File Offset: 0x0040E628
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F5CD RID: 62925 RVA: 0x00410438 File Offset: 0x0040E638
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F5CE RID: 62926 RVA: 0x00410448 File Offset: 0x0040E648
			public void __callDele_EventOnClick(GuildInviteMemberInfoItemUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600F5CF RID: 62927 RVA: 0x00410458 File Offset: 0x0040E658
			public void __clearDele_EventOnClick(GuildInviteMemberInfoItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002F2D RID: 12077
			// (get) Token: 0x0600F5D0 RID: 62928 RVA: 0x00410468 File Offset: 0x0040E668
			// (set) Token: 0x0600F5D1 RID: 62929 RVA: 0x00410478 File Offset: 0x0040E678
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

			// Token: 0x17002F2E RID: 12078
			// (get) Token: 0x0600F5D2 RID: 62930 RVA: 0x00410488 File Offset: 0x0040E688
			// (set) Token: 0x0600F5D3 RID: 62931 RVA: 0x00410498 File Offset: 0x0040E698
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

			// Token: 0x17002F2F RID: 12079
			// (get) Token: 0x0600F5D4 RID: 62932 RVA: 0x004104A8 File Offset: 0x0040E6A8
			// (set) Token: 0x0600F5D5 RID: 62933 RVA: 0x004104B8 File Offset: 0x0040E6B8
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

			// Token: 0x17002F30 RID: 12080
			// (get) Token: 0x0600F5D6 RID: 62934 RVA: 0x004104C8 File Offset: 0x0040E6C8
			// (set) Token: 0x0600F5D7 RID: 62935 RVA: 0x004104D8 File Offset: 0x0040E6D8
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

			// Token: 0x17002F31 RID: 12081
			// (get) Token: 0x0600F5D8 RID: 62936 RVA: 0x004104E8 File Offset: 0x0040E6E8
			// (set) Token: 0x0600F5D9 RID: 62937 RVA: 0x004104F8 File Offset: 0x0040E6F8
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

			// Token: 0x17002F32 RID: 12082
			// (get) Token: 0x0600F5DA RID: 62938 RVA: 0x00410508 File Offset: 0x0040E708
			// (set) Token: 0x0600F5DB RID: 62939 RVA: 0x00410518 File Offset: 0x0040E718
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

			// Token: 0x17002F33 RID: 12083
			// (get) Token: 0x0600F5DC RID: 62940 RVA: 0x00410528 File Offset: 0x0040E728
			// (set) Token: 0x0600F5DD RID: 62941 RVA: 0x00410538 File Offset: 0x0040E738
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

			// Token: 0x17002F34 RID: 12084
			// (get) Token: 0x0600F5DE RID: 62942 RVA: 0x00410548 File Offset: 0x0040E748
			// (set) Token: 0x0600F5DF RID: 62943 RVA: 0x00410558 File Offset: 0x0040E758
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

			// Token: 0x17002F35 RID: 12085
			// (get) Token: 0x0600F5E0 RID: 62944 RVA: 0x00410568 File Offset: 0x0040E768
			// (set) Token: 0x0600F5E1 RID: 62945 RVA: 0x00410578 File Offset: 0x0040E778
			public CommonUIStateController m_addButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_addButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_addButtonStateCtrl = value;
				}
			}

			// Token: 0x17002F36 RID: 12086
			// (get) Token: 0x0600F5E2 RID: 62946 RVA: 0x00410588 File Offset: 0x0040E788
			// (set) Token: 0x0600F5E3 RID: 62947 RVA: 0x00410598 File Offset: 0x0040E798
			public CommonUIStateController m_onlineStateCtrl
			{
				get
				{
					return this.m_owner.m_onlineStateCtrl;
				}
				set
				{
					this.m_owner.m_onlineStateCtrl = value;
				}
			}

			// Token: 0x17002F37 RID: 12087
			// (get) Token: 0x0600F5E4 RID: 62948 RVA: 0x004105A8 File Offset: 0x0040E7A8
			// (set) Token: 0x0600F5E5 RID: 62949 RVA: 0x004105B8 File Offset: 0x0040E7B8
			public Text m_OffLineText
			{
				get
				{
					return this.m_owner.m_OffLineText;
				}
				set
				{
					this.m_owner.m_OffLineText = value;
				}
			}

			// Token: 0x17002F38 RID: 12088
			// (get) Token: 0x0600F5E6 RID: 62950 RVA: 0x004105C8 File Offset: 0x0040E7C8
			// (set) Token: 0x0600F5E7 RID: 62951 RVA: 0x004105D8 File Offset: 0x0040E7D8
			public bool m_isAdd
			{
				get
				{
					return this.m_owner.m_isAdd;
				}
				set
				{
					this.m_owner.m_isAdd = value;
				}
			}

			// Token: 0x17002F39 RID: 12089
			// (set) Token: 0x0600F5E8 RID: 62952 RVA: 0x004105E8 File Offset: 0x0040E7E8
			public UserSummary InvitePlayer
			{
				set
				{
					this.m_owner.InvitePlayer = value;
				}
			}

			// Token: 0x0600F5E9 RID: 62953 RVA: 0x004105F8 File Offset: 0x0040E7F8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F5EA RID: 62954 RVA: 0x00410608 File Offset: 0x0040E808
			public void OnAddClick()
			{
				this.m_owner.OnAddClick();
			}

			// Token: 0x04009143 RID: 37187
			private GuildInviteMemberInfoItemUIController m_owner;
		}
	}
}
