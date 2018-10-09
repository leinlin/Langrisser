using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.TaskNs;
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
	// Token: 0x02000CE3 RID: 3299
	[HotFix]
	public class BeforeJoinGuildUIController : UIControllerBase
	{
		// Token: 0x0600F104 RID: 61700 RVA: 0x00401818 File Offset: 0x003FFA18
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
			this.m_guildUITask = (UIUtility.FindUITaskWithType(typeof(GuildUITask)) as GuildUITask);
			this.m_guildListUIController = GameObjectUtility.AddControllerToGameObject<BeforeJoinGuildListUIController>(this.m_listPanel);
			this.m_guildInfoUIController = GameObjectUtility.AddControllerToGameObject<BeforeJoinGuildInfoUIController>(this.m_infoPanel);
			this.m_receiveMsgUIController = GameObjectUtility.AddControllerToGameObject<BeforeJoinGuildMsgUIController>(this.m_messagePanel);
			this.m_createGuildUIController = GameObjectUtility.AddControllerToGameObject<CreateGuildUIController>(this.m_createGuildPanel);
			this.m_guildListUIController.Init(this);
			this.m_guildInfoUIController.Init(this);
			this.m_messageButton.onClick.AddListener(new UnityAction(this.OnMessageClick));
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnClick));
			this.m_infoButton.onClick.AddListener(new UnityAction(this.OnInfoClick));
			this.GetInviteMsgList();
			this.m_playerContext.EventOnGuildUpdateInfo += this.OnGuildUpdateInfoNtf;
		}

		// Token: 0x0600F105 RID: 61701 RVA: 0x00401990 File Offset: 0x003FFB90
		public override void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Clear();
			this.m_playerContext.EventOnGuildUpdateInfo -= this.OnGuildUpdateInfoNtf;
		}

		// Token: 0x0600F106 RID: 61702 RVA: 0x00401A10 File Offset: 0x003FFC10
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Time.frameCount % 30 == 0)
			{
				this.RefreshMessageRedPoint();
			}
		}

		// Token: 0x0600F107 RID: 61703 RVA: 0x00401A84 File Offset: 0x003FFC84
		private void GetInviteMsgList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetInviteMsgList_hotfix != null)
			{
				this.m_GetInviteMsgList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildJoinInvitationGetReqNetTask guildJoinInvitationGetReqNetTask = new GuildJoinInvitationGetReqNetTask();
			guildJoinInvitationGetReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildJoinInvitationGetReqNetTask guildJoinInvitationGetReqNetTask2 = task as GuildJoinInvitationGetReqNetTask;
				if (guildJoinInvitationGetReqNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(guildJoinInvitationGetReqNetTask2.Result, 2f, null, true);
				}
			};
			guildJoinInvitationGetReqNetTask.Start(null);
		}

		// Token: 0x0600F108 RID: 61704 RVA: 0x00401B18 File Offset: 0x003FFD18
		private void RefreshMessageRedPoint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshMessageRedPoint_hotfix != null)
			{
				this.m_RefreshMessageRedPoint_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool active = false;
			if (this.m_playerContext.GetGuildJoinInvitationList().Count > 0)
			{
				active = true;
			}
			this.m_messageRedPoint.SetActive(active);
		}

		// Token: 0x0600F109 RID: 61705 RVA: 0x00401BA0 File Offset: 0x003FFDA0
		private void OnReturnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnClick_hotfix != null)
			{
				this.m_OnReturnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_guildUITask.Stop();
				this.m_guildUITask.ReturnPrevUITaskWrap();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600F10A RID: 61706 RVA: 0x00401C24 File Offset: 0x003FFE24
		private void OnMessageClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMessageClick_hotfix != null)
			{
				this.m_OnMessageClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_receiveMsgUIController.Show();
		}

		// Token: 0x0600F10B RID: 61707 RVA: 0x00401C90 File Offset: 0x003FFE90
		private void OnInfoClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInfoClick_hotfix != null)
			{
				this.m_OnInfoClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Guild);
		}

		// Token: 0x0600F10C RID: 61708 RVA: 0x00401CFC File Offset: 0x003FFEFC
		private void OnGuildUpdateInfoNtf(GuildLog log)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildUpdateInfoNtfGuildLog_hotfix != null)
			{
				this.m_OnGuildUpdateInfoNtfGuildLog_hotfix.call(new object[]
				{
					this,
					log
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (log.ModeId == 20010)
			{
				this.m_guildUITask.Stop();
				UIIntent prevTaskIntent = (this.m_guildUITask.CurrentIntent as UIIntentReturnable).PrevTaskIntent;
				UIIntent intent = prevTaskIntent;
				GuildManagementUITask.StartUITask(null, intent);
			}
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x0600F10D RID: 61709 RVA: 0x00401DA8 File Offset: 0x003FFFA8
		// (set) Token: 0x0600F10E RID: 61710 RVA: 0x00401DC8 File Offset: 0x003FFFC8
		[DoNotToLua]
		public new BeforeJoinGuildUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BeforeJoinGuildUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F10F RID: 61711 RVA: 0x00401DD4 File Offset: 0x003FFFD4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F110 RID: 61712 RVA: 0x00401DE0 File Offset: 0x003FFFE0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F111 RID: 61713 RVA: 0x00401DE8 File Offset: 0x003FFFE8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F112 RID: 61714 RVA: 0x00401DF0 File Offset: 0x003FFFF0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F113 RID: 61715 RVA: 0x00401E04 File Offset: 0x00400004
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F114 RID: 61716 RVA: 0x00401E0C File Offset: 0x0040000C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F115 RID: 61717 RVA: 0x00401E18 File Offset: 0x00400018
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F116 RID: 61718 RVA: 0x00401E24 File Offset: 0x00400024
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F117 RID: 61719 RVA: 0x00401E30 File Offset: 0x00400030
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F118 RID: 61720 RVA: 0x00401E3C File Offset: 0x0040003C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F119 RID: 61721 RVA: 0x00401E48 File Offset: 0x00400048
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F11A RID: 61722 RVA: 0x00401E54 File Offset: 0x00400054
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F11B RID: 61723 RVA: 0x00401E60 File Offset: 0x00400060
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F11C RID: 61724 RVA: 0x00401E6C File Offset: 0x0040006C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F11D RID: 61725 RVA: 0x00401E78 File Offset: 0x00400078
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F120 RID: 61728 RVA: 0x00401EE0 File Offset: 0x004000E0
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
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_GetInviteMsgList_hotfix = (luaObj.RawGet("GetInviteMsgList") as LuaFunction);
					this.m_RefreshMessageRedPoint_hotfix = (luaObj.RawGet("RefreshMessageRedPoint") as LuaFunction);
					this.m_OnReturnClick_hotfix = (luaObj.RawGet("OnReturnClick") as LuaFunction);
					this.m_OnMessageClick_hotfix = (luaObj.RawGet("OnMessageClick") as LuaFunction);
					this.m_OnInfoClick_hotfix = (luaObj.RawGet("OnInfoClick") as LuaFunction);
					this.m_OnGuildUpdateInfoNtfGuildLog_hotfix = (luaObj.RawGet("OnGuildUpdateInfoNtf") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F121 RID: 61729 RVA: 0x00402074 File Offset: 0x00400274
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BeforeJoinGuildUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008F43 RID: 36675
		[AutoBind("./MainPanel/InfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoPanel;

		// Token: 0x04008F44 RID: 36676
		[AutoBind("./MainPanel/RankingPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rankingPanel;

		// Token: 0x04008F45 RID: 36677
		[AutoBind("./MainPanel/ListPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_listPanel;

		// Token: 0x04008F46 RID: 36678
		[AutoBind("./MessagePanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_messagePanel;

		// Token: 0x04008F47 RID: 36679
		[AutoBind("./GreatSociatyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_createGuildPanel;

		// Token: 0x04008F48 RID: 36680
		[AutoBind("./MainPanel/MessageButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_messageButton;

		// Token: 0x04008F49 RID: 36681
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04008F4A RID: 36682
		[AutoBind("./InfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoButton;

		// Token: 0x04008F4B RID: 36683
		[AutoBind("./MainPanel/MessageButton/RedPoint", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_messageRedPoint;

		// Token: 0x04008F4C RID: 36684
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008F4D RID: 36685
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008F4E RID: 36686
		public BeforeJoinGuildListUIController m_guildListUIController;

		// Token: 0x04008F4F RID: 36687
		public BeforeJoinGuildInfoUIController m_guildInfoUIController;

		// Token: 0x04008F50 RID: 36688
		public BeforeJoinGuildMsgUIController m_receiveMsgUIController;

		// Token: 0x04008F51 RID: 36689
		public CreateGuildUIController m_createGuildUIController;

		// Token: 0x04008F52 RID: 36690
		private GuildUITask m_guildUITask;

		// Token: 0x04008F53 RID: 36691
		[DoNotToLua]
		private BeforeJoinGuildUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008F55 RID: 36693
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008F56 RID: 36694
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008F57 RID: 36695
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008F58 RID: 36696
		private LuaFunction m_Clear_hotfix;

		// Token: 0x04008F59 RID: 36697
		private LuaFunction m_Update_hotfix;

		// Token: 0x04008F5A RID: 36698
		private LuaFunction m_GetInviteMsgList_hotfix;

		// Token: 0x04008F5B RID: 36699
		private LuaFunction m_RefreshMessageRedPoint_hotfix;

		// Token: 0x04008F5C RID: 36700
		private LuaFunction m_OnReturnClick_hotfix;

		// Token: 0x04008F5D RID: 36701
		private LuaFunction m_OnMessageClick_hotfix;

		// Token: 0x04008F5E RID: 36702
		private LuaFunction m_OnInfoClick_hotfix;

		// Token: 0x04008F5F RID: 36703
		private LuaFunction m_OnGuildUpdateInfoNtfGuildLog_hotfix;

		// Token: 0x02000CE4 RID: 3300
		public new class LuaExportHelper
		{
			// Token: 0x0600F122 RID: 61730 RVA: 0x004020DC File Offset: 0x004002DC
			public LuaExportHelper(BeforeJoinGuildUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F123 RID: 61731 RVA: 0x004020EC File Offset: 0x004002EC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F124 RID: 61732 RVA: 0x004020FC File Offset: 0x004002FC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F125 RID: 61733 RVA: 0x0040210C File Offset: 0x0040030C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F126 RID: 61734 RVA: 0x0040211C File Offset: 0x0040031C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F127 RID: 61735 RVA: 0x00402134 File Offset: 0x00400334
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F128 RID: 61736 RVA: 0x00402144 File Offset: 0x00400344
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F129 RID: 61737 RVA: 0x00402154 File Offset: 0x00400354
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F12A RID: 61738 RVA: 0x00402164 File Offset: 0x00400364
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F12B RID: 61739 RVA: 0x00402174 File Offset: 0x00400374
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F12C RID: 61740 RVA: 0x00402184 File Offset: 0x00400384
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F12D RID: 61741 RVA: 0x00402194 File Offset: 0x00400394
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F12E RID: 61742 RVA: 0x004021A4 File Offset: 0x004003A4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F12F RID: 61743 RVA: 0x004021B4 File Offset: 0x004003B4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F130 RID: 61744 RVA: 0x004021C4 File Offset: 0x004003C4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F131 RID: 61745 RVA: 0x004021D4 File Offset: 0x004003D4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002E5D RID: 11869
			// (get) Token: 0x0600F132 RID: 61746 RVA: 0x004021E4 File Offset: 0x004003E4
			// (set) Token: 0x0600F133 RID: 61747 RVA: 0x004021F4 File Offset: 0x004003F4
			public GameObject m_infoPanel
			{
				get
				{
					return this.m_owner.m_infoPanel;
				}
				set
				{
					this.m_owner.m_infoPanel = value;
				}
			}

			// Token: 0x17002E5E RID: 11870
			// (get) Token: 0x0600F134 RID: 61748 RVA: 0x00402204 File Offset: 0x00400404
			// (set) Token: 0x0600F135 RID: 61749 RVA: 0x00402214 File Offset: 0x00400414
			public GameObject m_rankingPanel
			{
				get
				{
					return this.m_owner.m_rankingPanel;
				}
				set
				{
					this.m_owner.m_rankingPanel = value;
				}
			}

			// Token: 0x17002E5F RID: 11871
			// (get) Token: 0x0600F136 RID: 61750 RVA: 0x00402224 File Offset: 0x00400424
			// (set) Token: 0x0600F137 RID: 61751 RVA: 0x00402234 File Offset: 0x00400434
			public GameObject m_listPanel
			{
				get
				{
					return this.m_owner.m_listPanel;
				}
				set
				{
					this.m_owner.m_listPanel = value;
				}
			}

			// Token: 0x17002E60 RID: 11872
			// (get) Token: 0x0600F138 RID: 61752 RVA: 0x00402244 File Offset: 0x00400444
			// (set) Token: 0x0600F139 RID: 61753 RVA: 0x00402254 File Offset: 0x00400454
			public GameObject m_messagePanel
			{
				get
				{
					return this.m_owner.m_messagePanel;
				}
				set
				{
					this.m_owner.m_messagePanel = value;
				}
			}

			// Token: 0x17002E61 RID: 11873
			// (get) Token: 0x0600F13A RID: 61754 RVA: 0x00402264 File Offset: 0x00400464
			// (set) Token: 0x0600F13B RID: 61755 RVA: 0x00402274 File Offset: 0x00400474
			public GameObject m_createGuildPanel
			{
				get
				{
					return this.m_owner.m_createGuildPanel;
				}
				set
				{
					this.m_owner.m_createGuildPanel = value;
				}
			}

			// Token: 0x17002E62 RID: 11874
			// (get) Token: 0x0600F13C RID: 61756 RVA: 0x00402284 File Offset: 0x00400484
			// (set) Token: 0x0600F13D RID: 61757 RVA: 0x00402294 File Offset: 0x00400494
			public Button m_messageButton
			{
				get
				{
					return this.m_owner.m_messageButton;
				}
				set
				{
					this.m_owner.m_messageButton = value;
				}
			}

			// Token: 0x17002E63 RID: 11875
			// (get) Token: 0x0600F13E RID: 61758 RVA: 0x004022A4 File Offset: 0x004004A4
			// (set) Token: 0x0600F13F RID: 61759 RVA: 0x004022B4 File Offset: 0x004004B4
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17002E64 RID: 11876
			// (get) Token: 0x0600F140 RID: 61760 RVA: 0x004022C4 File Offset: 0x004004C4
			// (set) Token: 0x0600F141 RID: 61761 RVA: 0x004022D4 File Offset: 0x004004D4
			public Button m_infoButton
			{
				get
				{
					return this.m_owner.m_infoButton;
				}
				set
				{
					this.m_owner.m_infoButton = value;
				}
			}

			// Token: 0x17002E65 RID: 11877
			// (get) Token: 0x0600F142 RID: 61762 RVA: 0x004022E4 File Offset: 0x004004E4
			// (set) Token: 0x0600F143 RID: 61763 RVA: 0x004022F4 File Offset: 0x004004F4
			public GameObject m_messageRedPoint
			{
				get
				{
					return this.m_owner.m_messageRedPoint;
				}
				set
				{
					this.m_owner.m_messageRedPoint = value;
				}
			}

			// Token: 0x17002E66 RID: 11878
			// (get) Token: 0x0600F144 RID: 61764 RVA: 0x00402304 File Offset: 0x00400504
			// (set) Token: 0x0600F145 RID: 61765 RVA: 0x00402314 File Offset: 0x00400514
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

			// Token: 0x17002E67 RID: 11879
			// (get) Token: 0x0600F146 RID: 61766 RVA: 0x00402324 File Offset: 0x00400524
			// (set) Token: 0x0600F147 RID: 61767 RVA: 0x00402334 File Offset: 0x00400534
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

			// Token: 0x17002E68 RID: 11880
			// (get) Token: 0x0600F148 RID: 61768 RVA: 0x00402344 File Offset: 0x00400544
			// (set) Token: 0x0600F149 RID: 61769 RVA: 0x00402354 File Offset: 0x00400554
			public GuildUITask m_guildUITask
			{
				get
				{
					return this.m_owner.m_guildUITask;
				}
				set
				{
					this.m_owner.m_guildUITask = value;
				}
			}

			// Token: 0x0600F14A RID: 61770 RVA: 0x00402364 File Offset: 0x00400564
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F14B RID: 61771 RVA: 0x00402374 File Offset: 0x00400574
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600F14C RID: 61772 RVA: 0x00402384 File Offset: 0x00400584
			public void GetInviteMsgList()
			{
				this.m_owner.GetInviteMsgList();
			}

			// Token: 0x0600F14D RID: 61773 RVA: 0x00402394 File Offset: 0x00400594
			public void RefreshMessageRedPoint()
			{
				this.m_owner.RefreshMessageRedPoint();
			}

			// Token: 0x0600F14E RID: 61774 RVA: 0x004023A4 File Offset: 0x004005A4
			public void OnReturnClick()
			{
				this.m_owner.OnReturnClick();
			}

			// Token: 0x0600F14F RID: 61775 RVA: 0x004023B4 File Offset: 0x004005B4
			public void OnMessageClick()
			{
				this.m_owner.OnMessageClick();
			}

			// Token: 0x0600F150 RID: 61776 RVA: 0x004023C4 File Offset: 0x004005C4
			public void OnInfoClick()
			{
				this.m_owner.OnInfoClick();
			}

			// Token: 0x0600F151 RID: 61777 RVA: 0x004023D4 File Offset: 0x004005D4
			public void OnGuildUpdateInfoNtf(GuildLog log)
			{
				this.m_owner.OnGuildUpdateInfoNtf(log);
			}

			// Token: 0x04008F60 RID: 36704
			private BeforeJoinGuildUIController m_owner;
		}
	}
}
