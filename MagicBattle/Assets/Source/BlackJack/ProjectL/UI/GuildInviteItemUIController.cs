using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CE1 RID: 3297
	[HotFix]
	public class GuildInviteItemUIController : UIControllerBase
	{
		// Token: 0x0600F0B8 RID: 61624 RVA: 0x00400BAC File Offset: 0x003FEDAC
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_acceptButton.onClick.AddListener(new UnityAction(this.OnAcceptClick));
			this.m_refuseButton.onClick.AddListener(new UnityAction(this.OnRefuseClick));
			this.m_detialButton.onClick.AddListener(new UnityAction(this.OnDetailClick));
		}

		// Token: 0x0600F0B9 RID: 61625 RVA: 0x00400C90 File Offset: 0x003FEE90
		public void Init(GuildJoinInvitation guildJoinInvitation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGuildJoinInvitation_hotfix != null)
			{
				this.m_InitGuildJoinInvitation_hotfix.call(new object[]
				{
					this,
					guildJoinInvitation
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildJoinInvitation = guildJoinInvitation;
			this.Refresh();
		}

		// Token: 0x0600F0BA RID: 61626 RVA: 0x00400D10 File Offset: 0x003FEF10
		public void Refresh()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Refresh_hotfix != null)
			{
				this.m_Refresh_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_charName.text = this.m_guildJoinInvitation.Name;
			this.m_charLevelText.text = this.m_guildJoinInvitation.Level.ToString();
			this.m_charIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(this.m_guildJoinInvitation.HeadIcon)));
			UIUtility.SetPlayerHeadFrame(this.m_headFrameDummy, HeadIconTools.GetHeadFrame(this.m_guildJoinInvitation.HeadIcon), true, "Normal");
			this.m_inviteGuildName.text = this.m_guildJoinInvitation.GuildName;
		}

		// Token: 0x0600F0BB RID: 61627 RVA: 0x00400E0C File Offset: 0x003FF00C
		private void OnAcceptClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAcceptClick_hotfix != null)
			{
				this.m_OnAcceptClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildJoinPlayerConfirmReqNetTask guildJoinPlayerConfirmReqNetTask = new GuildJoinPlayerConfirmReqNetTask(this.m_guildJoinInvitation.GuildId);
			guildJoinPlayerConfirmReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildJoinPlayerConfirmReqNetTask guildJoinPlayerConfirmReqNetTask2 = task as GuildJoinPlayerConfirmReqNetTask;
				if (guildJoinPlayerConfirmReqNetTask2.Result == 0)
				{
					GuildUITask guildUITask = UIUtility.FindUITaskWithType(typeof(GuildUITask)) as GuildUITask;
					UIIntent prevTaskIntent = (guildUITask.CurrentIntent as UIIntentReturnable).PrevTaskIntent;
					guildUITask.Stop();
					UIIntent intent = prevTaskIntent;
					GuildManagementUITask.StartUITask(null, intent);
					string value = this.m_configDataLoader.GetConfigDataStringTable(14016).Value;
					CommonUIController.Instance.ShowMessage(value, 2f, null, true);
				}
				else if (guildJoinPlayerConfirmReqNetTask2.Result == -5203)
				{
					TimeSpan timeSpan = this.m_playerContext.CanJoinGuildCDTime();
					string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_JoinGuildCD);
					CommonUIController.Instance.ShowMessage(string.Format(format, timeSpan.Hours, timeSpan.Minutes + 1), 2f, null, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildJoinPlayerConfirmReqNetTask2.Result, 2f, null, true);
				}
				if (this.ItemRefreshEvent != null)
				{
					this.ItemRefreshEvent();
				}
			};
			guildJoinPlayerConfirmReqNetTask.Start(null);
		}

		// Token: 0x0600F0BC RID: 61628 RVA: 0x00400E98 File Offset: 0x003FF098
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
			GuildJoinInvitationRefuseReqNetTask guildJoinInvitationRefuseReqNetTask = new GuildJoinInvitationRefuseReqNetTask(this.m_guildJoinInvitation.GuildId);
			guildJoinInvitationRefuseReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildJoinInvitationRefuseReqNetTask guildJoinInvitationRefuseReqNetTask2 = task as GuildJoinInvitationRefuseReqNetTask;
				if (guildJoinInvitationRefuseReqNetTask2.Result == 0)
				{
					if (this.ItemRefreshEvent != null)
					{
						this.ItemRefreshEvent();
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildJoinInvitationRefuseReqNetTask2.Result, 2f, null, true);
				}
			};
			guildJoinInvitationRefuseReqNetTask.Start(null);
		}

		// Token: 0x0600F0BD RID: 61629 RVA: 0x00400F24 File Offset: 0x003FF124
		private void OnDetailClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDetailClick_hotfix != null)
			{
				this.m_OnDetailClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildUITask guildUITask = UIUtility.FindUITaskWithType(typeof(GuildUITask)) as GuildUITask;
			UIIntent prevTaskIntent = (guildUITask.CurrentIntent as UIIntentReturnable).PrevTaskIntent;
			GuildManagementUITask.StartUITask(this.m_guildJoinInvitation.GuildId, prevTaskIntent);
		}

		// Token: 0x1400032A RID: 810
		// (add) Token: 0x0600F0BE RID: 61630 RVA: 0x00400FBC File Offset: 0x003FF1BC
		// (remove) Token: 0x0600F0BF RID: 61631 RVA: 0x00401058 File Offset: 0x003FF258
		public event Action ItemRefreshEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_ItemRefreshEventAction_hotfix != null)
				{
					this.m_add_ItemRefreshEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.ItemRefreshEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.ItemRefreshEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_ItemRefreshEventAction_hotfix != null)
				{
					this.m_remove_ItemRefreshEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.ItemRefreshEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.ItemRefreshEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0600F0C0 RID: 61632 RVA: 0x004010F4 File Offset: 0x003FF2F4
		// (set) Token: 0x0600F0C1 RID: 61633 RVA: 0x00401114 File Offset: 0x003FF314
		[DoNotToLua]
		public new GuildInviteItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildInviteItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F0C2 RID: 61634 RVA: 0x00401120 File Offset: 0x003FF320
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F0C3 RID: 61635 RVA: 0x0040112C File Offset: 0x003FF32C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F0C4 RID: 61636 RVA: 0x00401134 File Offset: 0x003FF334
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F0C5 RID: 61637 RVA: 0x0040113C File Offset: 0x003FF33C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F0C6 RID: 61638 RVA: 0x00401150 File Offset: 0x003FF350
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F0C7 RID: 61639 RVA: 0x00401158 File Offset: 0x003FF358
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F0C8 RID: 61640 RVA: 0x00401164 File Offset: 0x003FF364
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F0C9 RID: 61641 RVA: 0x00401170 File Offset: 0x003FF370
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F0CA RID: 61642 RVA: 0x0040117C File Offset: 0x003FF37C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F0CB RID: 61643 RVA: 0x00401188 File Offset: 0x003FF388
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F0CC RID: 61644 RVA: 0x00401194 File Offset: 0x003FF394
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F0CD RID: 61645 RVA: 0x004011A0 File Offset: 0x003FF3A0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F0CE RID: 61646 RVA: 0x004011AC File Offset: 0x003FF3AC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F0CF RID: 61647 RVA: 0x004011B8 File Offset: 0x003FF3B8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F0D0 RID: 61648 RVA: 0x004011C4 File Offset: 0x003FF3C4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F0D1 RID: 61649 RVA: 0x004011CC File Offset: 0x003FF3CC
		private void __callDele_ItemRefreshEvent()
		{
			Action itemRefreshEvent = this.ItemRefreshEvent;
			if (itemRefreshEvent != null)
			{
				itemRefreshEvent();
			}
		}

		// Token: 0x0600F0D2 RID: 61650 RVA: 0x004011EC File Offset: 0x003FF3EC
		private void __clearDele_ItemRefreshEvent()
		{
			this.ItemRefreshEvent = null;
		}

		// Token: 0x0600F0D5 RID: 61653 RVA: 0x00401364 File Offset: 0x003FF564
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
					this.m_InitGuildJoinInvitation_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_Refresh_hotfix = (luaObj.RawGet("Refresh") as LuaFunction);
					this.m_OnAcceptClick_hotfix = (luaObj.RawGet("OnAcceptClick") as LuaFunction);
					this.m_OnRefuseClick_hotfix = (luaObj.RawGet("OnRefuseClick") as LuaFunction);
					this.m_OnDetailClick_hotfix = (luaObj.RawGet("OnDetailClick") as LuaFunction);
					this.m_add_ItemRefreshEventAction_hotfix = (luaObj.RawGet("add_ItemRefreshEvent") as LuaFunction);
					this.m_remove_ItemRefreshEventAction_hotfix = (luaObj.RawGet("remove_ItemRefreshEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F0D6 RID: 61654 RVA: 0x004014E0 File Offset: 0x003FF6E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildInviteItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008F2B RID: 36651
		[AutoBind("./Char/HeadIcon/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_charLevelText;

		// Token: 0x04008F2C RID: 36652
		[AutoBind("./Char/HeadIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_charIcon;

		// Token: 0x04008F2D RID: 36653
		[AutoBind("./Char/HeadIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_headFrameDummy;

		// Token: 0x04008F2E RID: 36654
		[AutoBind("./Char/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_charName;

		// Token: 0x04008F2F RID: 36655
		[AutoBind("./Char/SociatyNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_inviteGuildName;

		// Token: 0x04008F30 RID: 36656
		[AutoBind("./InfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_detialButton;

		// Token: 0x04008F31 RID: 36657
		[AutoBind("./AgreeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_acceptButton;

		// Token: 0x04008F32 RID: 36658
		[AutoBind("./RefuseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_refuseButton;

		// Token: 0x04008F34 RID: 36660
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008F35 RID: 36661
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008F36 RID: 36662
		private GuildJoinInvitation m_guildJoinInvitation;

		// Token: 0x04008F37 RID: 36663
		[DoNotToLua]
		private GuildInviteItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008F38 RID: 36664
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008F39 RID: 36665
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008F3A RID: 36666
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008F3B RID: 36667
		private LuaFunction m_InitGuildJoinInvitation_hotfix;

		// Token: 0x04008F3C RID: 36668
		private LuaFunction m_Refresh_hotfix;

		// Token: 0x04008F3D RID: 36669
		private LuaFunction m_OnAcceptClick_hotfix;

		// Token: 0x04008F3E RID: 36670
		private LuaFunction m_OnRefuseClick_hotfix;

		// Token: 0x04008F3F RID: 36671
		private LuaFunction m_OnDetailClick_hotfix;

		// Token: 0x04008F40 RID: 36672
		private LuaFunction m_add_ItemRefreshEventAction_hotfix;

		// Token: 0x04008F41 RID: 36673
		private LuaFunction m_remove_ItemRefreshEventAction_hotfix;

		// Token: 0x02000CE2 RID: 3298
		public new class LuaExportHelper
		{
			// Token: 0x0600F0D7 RID: 61655 RVA: 0x00401548 File Offset: 0x003FF748
			public LuaExportHelper(GuildInviteItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F0D8 RID: 61656 RVA: 0x00401558 File Offset: 0x003FF758
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F0D9 RID: 61657 RVA: 0x00401568 File Offset: 0x003FF768
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F0DA RID: 61658 RVA: 0x00401578 File Offset: 0x003FF778
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F0DB RID: 61659 RVA: 0x00401588 File Offset: 0x003FF788
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F0DC RID: 61660 RVA: 0x004015A0 File Offset: 0x003FF7A0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F0DD RID: 61661 RVA: 0x004015B0 File Offset: 0x003FF7B0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F0DE RID: 61662 RVA: 0x004015C0 File Offset: 0x003FF7C0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F0DF RID: 61663 RVA: 0x004015D0 File Offset: 0x003FF7D0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F0E0 RID: 61664 RVA: 0x004015E0 File Offset: 0x003FF7E0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F0E1 RID: 61665 RVA: 0x004015F0 File Offset: 0x003FF7F0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F0E2 RID: 61666 RVA: 0x00401600 File Offset: 0x003FF800
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F0E3 RID: 61667 RVA: 0x00401610 File Offset: 0x003FF810
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F0E4 RID: 61668 RVA: 0x00401620 File Offset: 0x003FF820
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F0E5 RID: 61669 RVA: 0x00401630 File Offset: 0x003FF830
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F0E6 RID: 61670 RVA: 0x00401640 File Offset: 0x003FF840
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F0E7 RID: 61671 RVA: 0x00401650 File Offset: 0x003FF850
			public void __callDele_ItemRefreshEvent()
			{
				this.m_owner.__callDele_ItemRefreshEvent();
			}

			// Token: 0x0600F0E8 RID: 61672 RVA: 0x00401660 File Offset: 0x003FF860
			public void __clearDele_ItemRefreshEvent()
			{
				this.m_owner.__clearDele_ItemRefreshEvent();
			}

			// Token: 0x17002E51 RID: 11857
			// (get) Token: 0x0600F0E9 RID: 61673 RVA: 0x00401670 File Offset: 0x003FF870
			// (set) Token: 0x0600F0EA RID: 61674 RVA: 0x00401680 File Offset: 0x003FF880
			public Text m_charLevelText
			{
				get
				{
					return this.m_owner.m_charLevelText;
				}
				set
				{
					this.m_owner.m_charLevelText = value;
				}
			}

			// Token: 0x17002E52 RID: 11858
			// (get) Token: 0x0600F0EB RID: 61675 RVA: 0x00401690 File Offset: 0x003FF890
			// (set) Token: 0x0600F0EC RID: 61676 RVA: 0x004016A0 File Offset: 0x003FF8A0
			public Image m_charIcon
			{
				get
				{
					return this.m_owner.m_charIcon;
				}
				set
				{
					this.m_owner.m_charIcon = value;
				}
			}

			// Token: 0x17002E53 RID: 11859
			// (get) Token: 0x0600F0ED RID: 61677 RVA: 0x004016B0 File Offset: 0x003FF8B0
			// (set) Token: 0x0600F0EE RID: 61678 RVA: 0x004016C0 File Offset: 0x003FF8C0
			public Transform m_headFrameDummy
			{
				get
				{
					return this.m_owner.m_headFrameDummy;
				}
				set
				{
					this.m_owner.m_headFrameDummy = value;
				}
			}

			// Token: 0x17002E54 RID: 11860
			// (get) Token: 0x0600F0EF RID: 61679 RVA: 0x004016D0 File Offset: 0x003FF8D0
			// (set) Token: 0x0600F0F0 RID: 61680 RVA: 0x004016E0 File Offset: 0x003FF8E0
			public Text m_charName
			{
				get
				{
					return this.m_owner.m_charName;
				}
				set
				{
					this.m_owner.m_charName = value;
				}
			}

			// Token: 0x17002E55 RID: 11861
			// (get) Token: 0x0600F0F1 RID: 61681 RVA: 0x004016F0 File Offset: 0x003FF8F0
			// (set) Token: 0x0600F0F2 RID: 61682 RVA: 0x00401700 File Offset: 0x003FF900
			public Text m_inviteGuildName
			{
				get
				{
					return this.m_owner.m_inviteGuildName;
				}
				set
				{
					this.m_owner.m_inviteGuildName = value;
				}
			}

			// Token: 0x17002E56 RID: 11862
			// (get) Token: 0x0600F0F3 RID: 61683 RVA: 0x00401710 File Offset: 0x003FF910
			// (set) Token: 0x0600F0F4 RID: 61684 RVA: 0x00401720 File Offset: 0x003FF920
			public Button m_detialButton
			{
				get
				{
					return this.m_owner.m_detialButton;
				}
				set
				{
					this.m_owner.m_detialButton = value;
				}
			}

			// Token: 0x17002E57 RID: 11863
			// (get) Token: 0x0600F0F5 RID: 61685 RVA: 0x00401730 File Offset: 0x003FF930
			// (set) Token: 0x0600F0F6 RID: 61686 RVA: 0x00401740 File Offset: 0x003FF940
			public Button m_acceptButton
			{
				get
				{
					return this.m_owner.m_acceptButton;
				}
				set
				{
					this.m_owner.m_acceptButton = value;
				}
			}

			// Token: 0x17002E58 RID: 11864
			// (get) Token: 0x0600F0F7 RID: 61687 RVA: 0x00401750 File Offset: 0x003FF950
			// (set) Token: 0x0600F0F8 RID: 61688 RVA: 0x00401760 File Offset: 0x003FF960
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

			// Token: 0x17002E59 RID: 11865
			// (get) Token: 0x0600F0F9 RID: 61689 RVA: 0x00401770 File Offset: 0x003FF970
			// (set) Token: 0x0600F0FA RID: 61690 RVA: 0x00401780 File Offset: 0x003FF980
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

			// Token: 0x17002E5A RID: 11866
			// (get) Token: 0x0600F0FB RID: 61691 RVA: 0x00401790 File Offset: 0x003FF990
			// (set) Token: 0x0600F0FC RID: 61692 RVA: 0x004017A0 File Offset: 0x003FF9A0
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

			// Token: 0x17002E5B RID: 11867
			// (get) Token: 0x0600F0FD RID: 61693 RVA: 0x004017B0 File Offset: 0x003FF9B0
			// (set) Token: 0x0600F0FE RID: 61694 RVA: 0x004017C0 File Offset: 0x003FF9C0
			public GuildJoinInvitation m_guildJoinInvitation
			{
				get
				{
					return this.m_owner.m_guildJoinInvitation;
				}
				set
				{
					this.m_owner.m_guildJoinInvitation = value;
				}
			}

			// Token: 0x0600F0FF RID: 61695 RVA: 0x004017D0 File Offset: 0x003FF9D0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F100 RID: 61696 RVA: 0x004017E0 File Offset: 0x003FF9E0
			public void OnAcceptClick()
			{
				this.m_owner.OnAcceptClick();
			}

			// Token: 0x0600F101 RID: 61697 RVA: 0x004017F0 File Offset: 0x003FF9F0
			public void OnRefuseClick()
			{
				this.m_owner.OnRefuseClick();
			}

			// Token: 0x0600F102 RID: 61698 RVA: 0x00401800 File Offset: 0x003FFA00
			public void OnDetailClick()
			{
				this.m_owner.OnDetailClick();
			}

			// Token: 0x04008F42 RID: 36674
			private GuildInviteItemUIController m_owner;
		}
	}
}
