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
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CFE RID: 3326
	[HotFix]
	public class GuildMemberInfoItemUIController : UIControllerBase
	{
		// Token: 0x0600F4E1 RID: 62689 RVA: 0x0040DEC0 File Offset: 0x0040C0C0
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

		// Token: 0x0600F4E2 RID: 62690 RVA: 0x0040DF44 File Offset: 0x0040C144
		public void InitItemInfo(GuildMember member, bool isSelf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitItemInfoGuildMemberBoolean_hotfix != null)
			{
				this.m_InitItemInfoGuildMemberBoolean_hotfix.call(new object[]
				{
					this,
					member,
					isSelf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Member = member;
			base.gameObject.SetActive(true);
			this.m_headIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(member.HeadIcon)));
			UIUtility.SetPlayerHeadFrame(this.m_HeadFrameDummy, HeadIconTools.GetHeadFrame(member.HeadIcon), true, "Normal");
			this.m_levelText.text = member.Level.ToString();
			this.m_nameText.text = member.Name;
			this.m_positionText.text = this.SetTitleTextByEnum(member.Title);
			this.m_powerText.text = member.TopHeroBattlePower.ToString();
			this.m_exploitText.text = "0";
			this.m_vitalityText.text = member.TotalActivities.ToString();
			this.m_onlineStateCtrl.SetToUIState((!member.Online) ? "Offline" : "Online", false, true);
			this.m_headIconStateCtrl.SetToUIState((!member.Online) ? "Offline" : "Online", false, true);
			if (!member.Online)
			{
				this.m_OffLineText.text = UIUtility.GetMemberOnlineText(member.Online, member.LogoutTime);
				this.m_headIconGrey.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(member.HeadIcon)));
			}
			this.m_stateCtrl.SetToUIState((!isSelf) ? "Normal" : "Self", false, true);
		}

		// Token: 0x0600F4E3 RID: 62691 RVA: 0x0040E16C File Offset: 0x0040C36C
		private string SetTitleTextByEnum(GuildTitle title)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTitleTextByEnumGuildTitle_hotfix != null)
			{
				return (string)this.m_SetTitleTextByEnumGuildTitle_hotfix.call(new object[]
				{
					this,
					title
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StringTableId id = (StringTableId)0;
			switch (title)
			{
			case GuildTitle.Normal:
				id = StringTableId.StringTableId_Guild_TitleNormal;
				break;
			case GuildTitle.Elite:
				id = StringTableId.StringTableId_Guild_TitleElite;
				break;
			case GuildTitle.VP:
				id = StringTableId.StringTableId_Guild_TitleVP;
				break;
			case GuildTitle.President:
				id = StringTableId.StringTableId_Guild_TitlePresident;
				break;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			return configDataLoader.UtilityGetStringByStringTable(id);
		}

		// Token: 0x0600F4E4 RID: 62692 RVA: 0x0040E254 File Offset: 0x0040C454
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

		// Token: 0x1400033E RID: 830
		// (add) Token: 0x0600F4E5 RID: 62693 RVA: 0x0040E2CC File Offset: 0x0040C4CC
		// (remove) Token: 0x0600F4E6 RID: 62694 RVA: 0x0040E368 File Offset: 0x0040C568
		public event Action<GuildMemberInfoItemUIController> EventOnClick
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
				Action<GuildMemberInfoItemUIController> action = this.EventOnClick;
				Action<GuildMemberInfoItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildMemberInfoItemUIController>>(ref this.EventOnClick, (Action<GuildMemberInfoItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<GuildMemberInfoItemUIController> action = this.EventOnClick;
				Action<GuildMemberInfoItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildMemberInfoItemUIController>>(ref this.EventOnClick, (Action<GuildMemberInfoItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x0600F4E7 RID: 62695 RVA: 0x0040E404 File Offset: 0x0040C604
		// (set) Token: 0x0600F4E8 RID: 62696 RVA: 0x0040E478 File Offset: 0x0040C678
		public GuildMember Member
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Member_hotfix != null)
				{
					return (GuildMember)this.m_get_Member_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Member>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_MemberGuildMember_hotfix != null)
				{
					this.m_set_MemberGuildMember_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Member>k__BackingField = value;
			}
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x0600F4E9 RID: 62697 RVA: 0x0040E4F0 File Offset: 0x0040C6F0
		// (set) Token: 0x0600F4EA RID: 62698 RVA: 0x0040E510 File Offset: 0x0040C710
		[DoNotToLua]
		public new GuildMemberInfoItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildMemberInfoItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F4EB RID: 62699 RVA: 0x0040E51C File Offset: 0x0040C71C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F4EC RID: 62700 RVA: 0x0040E528 File Offset: 0x0040C728
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F4ED RID: 62701 RVA: 0x0040E530 File Offset: 0x0040C730
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F4EE RID: 62702 RVA: 0x0040E538 File Offset: 0x0040C738
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F4EF RID: 62703 RVA: 0x0040E54C File Offset: 0x0040C74C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F4F0 RID: 62704 RVA: 0x0040E554 File Offset: 0x0040C754
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F4F1 RID: 62705 RVA: 0x0040E560 File Offset: 0x0040C760
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F4F2 RID: 62706 RVA: 0x0040E56C File Offset: 0x0040C76C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F4F3 RID: 62707 RVA: 0x0040E578 File Offset: 0x0040C778
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F4F4 RID: 62708 RVA: 0x0040E584 File Offset: 0x0040C784
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F4F5 RID: 62709 RVA: 0x0040E590 File Offset: 0x0040C790
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F4F6 RID: 62710 RVA: 0x0040E59C File Offset: 0x0040C79C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F4F7 RID: 62711 RVA: 0x0040E5A8 File Offset: 0x0040C7A8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F4F8 RID: 62712 RVA: 0x0040E5B4 File Offset: 0x0040C7B4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F4F9 RID: 62713 RVA: 0x0040E5C0 File Offset: 0x0040C7C0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F4FA RID: 62714 RVA: 0x0040E5C8 File Offset: 0x0040C7C8
		private void __callDele_EventOnClick(GuildMemberInfoItemUIController obj)
		{
			Action<GuildMemberInfoItemUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600F4FB RID: 62715 RVA: 0x0040E5EC File Offset: 0x0040C7EC
		private void __clearDele_EventOnClick(GuildMemberInfoItemUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600F4FC RID: 62716 RVA: 0x0040E5F8 File Offset: 0x0040C7F8
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
					this.m_InitItemInfoGuildMemberBoolean_hotfix = (luaObj.RawGet("InitItemInfo") as LuaFunction);
					this.m_SetTitleTextByEnumGuildTitle_hotfix = (luaObj.RawGet("SetTitleTextByEnum") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					this.m_get_Member_hotfix = (luaObj.RawGet("get_Member") as LuaFunction);
					this.m_set_MemberGuildMember_hotfix = (luaObj.RawGet("set_Member") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F4FD RID: 62717 RVA: 0x0040E774 File Offset: 0x0040C974
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMemberInfoItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040090F1 RID: 37105
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x040090F2 RID: 37106
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x040090F3 RID: 37107
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_headIconStateCtrl;

		// Token: 0x040090F4 RID: 37108
		[AutoBind("./Char/HeadIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIcon;

		// Token: 0x040090F5 RID: 37109
		[AutoBind("./Char/HeadIcon/HeadIconGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIconGrey;

		// Token: 0x040090F6 RID: 37110
		[AutoBind("./Char/HeadIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_HeadFrameDummy;

		// Token: 0x040090F7 RID: 37111
		[AutoBind("./Char/HeadIcon/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x040090F8 RID: 37112
		[AutoBind("./Char/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x040090F9 RID: 37113
		[AutoBind("./Char/PositionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_positionText;

		// Token: 0x040090FA RID: 37114
		[AutoBind("./PowerText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_powerText;

		// Token: 0x040090FB RID: 37115
		[AutoBind("./ExploitText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_exploitText;

		// Token: 0x040090FC RID: 37116
		[AutoBind("./VitalityText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_vitalityText;

		// Token: 0x040090FD RID: 37117
		[AutoBind("./StateGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_onlineStateCtrl;

		// Token: 0x040090FE RID: 37118
		[AutoBind("./StateGroup/OffLine/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_OffLineText;

		// Token: 0x04009100 RID: 37120
		[DoNotToLua]
		private GuildMemberInfoItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009101 RID: 37121
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009102 RID: 37122
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009103 RID: 37123
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009104 RID: 37124
		private LuaFunction m_InitItemInfoGuildMemberBoolean_hotfix;

		// Token: 0x04009105 RID: 37125
		private LuaFunction m_SetTitleTextByEnumGuildTitle_hotfix;

		// Token: 0x04009106 RID: 37126
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x04009107 RID: 37127
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04009108 RID: 37128
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x04009109 RID: 37129
		private LuaFunction m_get_Member_hotfix;

		// Token: 0x0400910A RID: 37130
		private LuaFunction m_set_MemberGuildMember_hotfix;

		// Token: 0x02000CFF RID: 3327
		public new class LuaExportHelper
		{
			// Token: 0x0600F4FE RID: 62718 RVA: 0x0040E7DC File Offset: 0x0040C9DC
			public LuaExportHelper(GuildMemberInfoItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F4FF RID: 62719 RVA: 0x0040E7EC File Offset: 0x0040C9EC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F500 RID: 62720 RVA: 0x0040E7FC File Offset: 0x0040C9FC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F501 RID: 62721 RVA: 0x0040E80C File Offset: 0x0040CA0C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F502 RID: 62722 RVA: 0x0040E81C File Offset: 0x0040CA1C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F503 RID: 62723 RVA: 0x0040E834 File Offset: 0x0040CA34
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F504 RID: 62724 RVA: 0x0040E844 File Offset: 0x0040CA44
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F505 RID: 62725 RVA: 0x0040E854 File Offset: 0x0040CA54
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F506 RID: 62726 RVA: 0x0040E864 File Offset: 0x0040CA64
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F507 RID: 62727 RVA: 0x0040E874 File Offset: 0x0040CA74
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F508 RID: 62728 RVA: 0x0040E884 File Offset: 0x0040CA84
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F509 RID: 62729 RVA: 0x0040E894 File Offset: 0x0040CA94
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F50A RID: 62730 RVA: 0x0040E8A4 File Offset: 0x0040CAA4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F50B RID: 62731 RVA: 0x0040E8B4 File Offset: 0x0040CAB4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F50C RID: 62732 RVA: 0x0040E8C4 File Offset: 0x0040CAC4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F50D RID: 62733 RVA: 0x0040E8D4 File Offset: 0x0040CAD4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F50E RID: 62734 RVA: 0x0040E8E4 File Offset: 0x0040CAE4
			public void __callDele_EventOnClick(GuildMemberInfoItemUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600F50F RID: 62735 RVA: 0x0040E8F4 File Offset: 0x0040CAF4
			public void __clearDele_EventOnClick(GuildMemberInfoItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002F0D RID: 12045
			// (get) Token: 0x0600F510 RID: 62736 RVA: 0x0040E904 File Offset: 0x0040CB04
			// (set) Token: 0x0600F511 RID: 62737 RVA: 0x0040E914 File Offset: 0x0040CB14
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

			// Token: 0x17002F0E RID: 12046
			// (get) Token: 0x0600F512 RID: 62738 RVA: 0x0040E924 File Offset: 0x0040CB24
			// (set) Token: 0x0600F513 RID: 62739 RVA: 0x0040E934 File Offset: 0x0040CB34
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

			// Token: 0x17002F0F RID: 12047
			// (get) Token: 0x0600F514 RID: 62740 RVA: 0x0040E944 File Offset: 0x0040CB44
			// (set) Token: 0x0600F515 RID: 62741 RVA: 0x0040E954 File Offset: 0x0040CB54
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

			// Token: 0x17002F10 RID: 12048
			// (get) Token: 0x0600F516 RID: 62742 RVA: 0x0040E964 File Offset: 0x0040CB64
			// (set) Token: 0x0600F517 RID: 62743 RVA: 0x0040E974 File Offset: 0x0040CB74
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

			// Token: 0x17002F11 RID: 12049
			// (get) Token: 0x0600F518 RID: 62744 RVA: 0x0040E984 File Offset: 0x0040CB84
			// (set) Token: 0x0600F519 RID: 62745 RVA: 0x0040E994 File Offset: 0x0040CB94
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

			// Token: 0x17002F12 RID: 12050
			// (get) Token: 0x0600F51A RID: 62746 RVA: 0x0040E9A4 File Offset: 0x0040CBA4
			// (set) Token: 0x0600F51B RID: 62747 RVA: 0x0040E9B4 File Offset: 0x0040CBB4
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

			// Token: 0x17002F13 RID: 12051
			// (get) Token: 0x0600F51C RID: 62748 RVA: 0x0040E9C4 File Offset: 0x0040CBC4
			// (set) Token: 0x0600F51D RID: 62749 RVA: 0x0040E9D4 File Offset: 0x0040CBD4
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

			// Token: 0x17002F14 RID: 12052
			// (get) Token: 0x0600F51E RID: 62750 RVA: 0x0040E9E4 File Offset: 0x0040CBE4
			// (set) Token: 0x0600F51F RID: 62751 RVA: 0x0040E9F4 File Offset: 0x0040CBF4
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

			// Token: 0x17002F15 RID: 12053
			// (get) Token: 0x0600F520 RID: 62752 RVA: 0x0040EA04 File Offset: 0x0040CC04
			// (set) Token: 0x0600F521 RID: 62753 RVA: 0x0040EA14 File Offset: 0x0040CC14
			public Text m_positionText
			{
				get
				{
					return this.m_owner.m_positionText;
				}
				set
				{
					this.m_owner.m_positionText = value;
				}
			}

			// Token: 0x17002F16 RID: 12054
			// (get) Token: 0x0600F522 RID: 62754 RVA: 0x0040EA24 File Offset: 0x0040CC24
			// (set) Token: 0x0600F523 RID: 62755 RVA: 0x0040EA34 File Offset: 0x0040CC34
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

			// Token: 0x17002F17 RID: 12055
			// (get) Token: 0x0600F524 RID: 62756 RVA: 0x0040EA44 File Offset: 0x0040CC44
			// (set) Token: 0x0600F525 RID: 62757 RVA: 0x0040EA54 File Offset: 0x0040CC54
			public Text m_exploitText
			{
				get
				{
					return this.m_owner.m_exploitText;
				}
				set
				{
					this.m_owner.m_exploitText = value;
				}
			}

			// Token: 0x17002F18 RID: 12056
			// (get) Token: 0x0600F526 RID: 62758 RVA: 0x0040EA64 File Offset: 0x0040CC64
			// (set) Token: 0x0600F527 RID: 62759 RVA: 0x0040EA74 File Offset: 0x0040CC74
			public Text m_vitalityText
			{
				get
				{
					return this.m_owner.m_vitalityText;
				}
				set
				{
					this.m_owner.m_vitalityText = value;
				}
			}

			// Token: 0x17002F19 RID: 12057
			// (get) Token: 0x0600F528 RID: 62760 RVA: 0x0040EA84 File Offset: 0x0040CC84
			// (set) Token: 0x0600F529 RID: 62761 RVA: 0x0040EA94 File Offset: 0x0040CC94
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

			// Token: 0x17002F1A RID: 12058
			// (get) Token: 0x0600F52A RID: 62762 RVA: 0x0040EAA4 File Offset: 0x0040CCA4
			// (set) Token: 0x0600F52B RID: 62763 RVA: 0x0040EAB4 File Offset: 0x0040CCB4
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

			// Token: 0x17002F1B RID: 12059
			// (set) Token: 0x0600F52C RID: 62764 RVA: 0x0040EAC4 File Offset: 0x0040CCC4
			public GuildMember Member
			{
				set
				{
					this.m_owner.Member = value;
				}
			}

			// Token: 0x0600F52D RID: 62765 RVA: 0x0040EAD4 File Offset: 0x0040CCD4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F52E RID: 62766 RVA: 0x0040EAE4 File Offset: 0x0040CCE4
			public string SetTitleTextByEnum(GuildTitle title)
			{
				return this.m_owner.SetTitleTextByEnum(title);
			}

			// Token: 0x0600F52F RID: 62767 RVA: 0x0040EAF4 File Offset: 0x0040CCF4
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400910B RID: 37131
			private GuildMemberInfoItemUIController m_owner;
		}
	}
}
