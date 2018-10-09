using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CDF RID: 3295
	[HotFix]
	public class BeforeJoinGuildMsgUIController : UIControllerBase
	{
		// Token: 0x0600F06C RID: 61548 RVA: 0x00400018 File Offset: 0x003FE218
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
			this.m_colseButton.onClick.AddListener(new UnityAction(this.OnCloseClick));
			this.m_allRefuseButton.onClick.AddListener(new UnityAction(this.OnRefuseAllClick));
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnBGClick));
		}

		// Token: 0x0600F06D RID: 61549 RVA: 0x004000FC File Offset: 0x003FE2FC
		private void OnEnable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnable_hotfix != null)
			{
				this.m_OnEnable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.GetInviteMsgList();
		}

		// Token: 0x0600F06E RID: 61550 RVA: 0x00400164 File Offset: 0x003FE364
		public void Show()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Show_hotfix != null)
			{
				this.m_Show_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.m_guildMsgAnimation.SetToUIState("Show", false, true);
		}

		// Token: 0x0600F06F RID: 61551 RVA: 0x004001E4 File Offset: 0x003FE3E4
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
				if (guildJoinInvitationGetReqNetTask2.Result == 0)
				{
					this.m_guildJoinInvitationList = guildJoinInvitationGetReqNetTask2.m_guildJoinInvitationList;
					this.Refresh();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildJoinInvitationGetReqNetTask2.Result, 2f, null, true);
				}
			};
			guildJoinInvitationGetReqNetTask.Start(null);
		}

		// Token: 0x0600F070 RID: 61552 RVA: 0x00400264 File Offset: 0x003FE464
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
			foreach (GuildInviteItemUIController guildInviteItemUIController in this.m_guildInviteItemUIControllerList)
			{
				UnityEngine.Object.Destroy(guildInviteItemUIController.gameObject);
			}
			this.m_guildInviteItemUIControllerList.Clear();
			foreach (GuildJoinInvitation guildJoinInvitation in this.m_guildJoinInvitationList)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_guildItemTemplate);
				gameObject.transform.SetParent(this.m_msgListContent.transform, false);
				GuildInviteItemUIController guildInviteItemUIController2 = GameObjectUtility.AddControllerToGameObject<GuildInviteItemUIController>(gameObject);
				guildInviteItemUIController2.Init(guildJoinInvitation);
				guildInviteItemUIController2.ItemRefreshEvent += this.Refresh;
				this.m_guildInviteItemUIControllerList.Add(guildInviteItemUIController2);
			}
			if (this.m_guildJoinInvitationList.Count == 0)
			{
				this.m_noMessage.SetActive(true);
			}
			else
			{
				this.m_noMessage.SetActive(false);
			}
		}

		// Token: 0x0600F071 RID: 61553 RVA: 0x004003EC File Offset: 0x003FE5EC
		private void OnCloseClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseClick_hotfix != null)
			{
				this.m_OnCloseClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_guildMsgAnimation, "Close", delegate
			{
				base.gameObject.SetActive(false);
			}, false, true);
		}

		// Token: 0x0600F072 RID: 61554 RVA: 0x0040046C File Offset: 0x003FE66C
		private void OnBGClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBGClick_hotfix != null)
			{
				this.m_OnBGClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_guildMsgAnimation, "Close", delegate
			{
				base.gameObject.SetActive(false);
			}, false, true);
		}

		// Token: 0x0600F073 RID: 61555 RVA: 0x004004EC File Offset: 0x003FE6EC
		private void OnRefuseAllClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRefuseAllClick_hotfix != null)
			{
				this.m_OnRefuseAllClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AllGuildJoinInvitationRefuseReqNetTask allGuildJoinInvitationRefuseReqNetTask = new AllGuildJoinInvitationRefuseReqNetTask();
			allGuildJoinInvitationRefuseReqNetTask.EventOnStop += delegate(Task task)
			{
				AllGuildJoinInvitationRefuseReqNetTask allGuildJoinInvitationRefuseReqNetTask2 = task as AllGuildJoinInvitationRefuseReqNetTask;
				if (allGuildJoinInvitationRefuseReqNetTask2.Result == 0)
				{
					this.Refresh();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(allGuildJoinInvitationRefuseReqNetTask2.Result, 2f, null, true);
				}
			};
			allGuildJoinInvitationRefuseReqNetTask.Start(null);
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0600F074 RID: 61556 RVA: 0x0040056C File Offset: 0x003FE76C
		// (set) Token: 0x0600F075 RID: 61557 RVA: 0x0040058C File Offset: 0x003FE78C
		[DoNotToLua]
		public new BeforeJoinGuildMsgUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BeforeJoinGuildMsgUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F076 RID: 61558 RVA: 0x00400598 File Offset: 0x003FE798
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F077 RID: 61559 RVA: 0x004005A4 File Offset: 0x003FE7A4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F078 RID: 61560 RVA: 0x004005AC File Offset: 0x003FE7AC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F079 RID: 61561 RVA: 0x004005B4 File Offset: 0x003FE7B4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F07A RID: 61562 RVA: 0x004005C8 File Offset: 0x003FE7C8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F07B RID: 61563 RVA: 0x004005D0 File Offset: 0x003FE7D0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F07C RID: 61564 RVA: 0x004005DC File Offset: 0x003FE7DC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F07D RID: 61565 RVA: 0x004005E8 File Offset: 0x003FE7E8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F07E RID: 61566 RVA: 0x004005F4 File Offset: 0x003FE7F4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F07F RID: 61567 RVA: 0x00400600 File Offset: 0x003FE800
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F080 RID: 61568 RVA: 0x0040060C File Offset: 0x003FE80C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F081 RID: 61569 RVA: 0x00400618 File Offset: 0x003FE818
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F082 RID: 61570 RVA: 0x00400624 File Offset: 0x003FE824
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F083 RID: 61571 RVA: 0x00400630 File Offset: 0x003FE830
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F084 RID: 61572 RVA: 0x0040063C File Offset: 0x003FE83C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F089 RID: 61577 RVA: 0x004006F8 File Offset: 0x003FE8F8
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
					this.m_OnEnable_hotfix = (luaObj.RawGet("OnEnable") as LuaFunction);
					this.m_Show_hotfix = (luaObj.RawGet("Show") as LuaFunction);
					this.m_GetInviteMsgList_hotfix = (luaObj.RawGet("GetInviteMsgList") as LuaFunction);
					this.m_Refresh_hotfix = (luaObj.RawGet("Refresh") as LuaFunction);
					this.m_OnCloseClick_hotfix = (luaObj.RawGet("OnCloseClick") as LuaFunction);
					this.m_OnBGClick_hotfix = (luaObj.RawGet("OnBGClick") as LuaFunction);
					this.m_OnRefuseAllClick_hotfix = (luaObj.RawGet("OnRefuseAllClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F08A RID: 61578 RVA: 0x00400874 File Offset: 0x003FEA74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BeforeJoinGuildMsgUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008F14 RID: 36628
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_guildMsgAnimation;

		// Token: 0x04008F15 RID: 36629
		[AutoBind("./Detail/AllRefuseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_allRefuseButton;

		// Token: 0x04008F16 RID: 36630
		[AutoBind("./Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_colseButton;

		// Token: 0x04008F17 RID: 36631
		[AutoBind("./BackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x04008F18 RID: 36632
		[AutoBind("./Prefab/SociatyItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_guildItemTemplate;

		// Token: 0x04008F19 RID: 36633
		[AutoBind("./Detail/MessageListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_msgListContent;

		// Token: 0x04008F1A RID: 36634
		[AutoBind("./Detail/NoMessage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noMessage;

		// Token: 0x04008F1B RID: 36635
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008F1C RID: 36636
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008F1D RID: 36637
		private List<GuildJoinInvitation> m_guildJoinInvitationList;

		// Token: 0x04008F1E RID: 36638
		private List<GuildInviteItemUIController> m_guildInviteItemUIControllerList = new List<GuildInviteItemUIController>();

		// Token: 0x04008F1F RID: 36639
		[DoNotToLua]
		private BeforeJoinGuildMsgUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008F20 RID: 36640
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008F21 RID: 36641
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008F22 RID: 36642
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008F23 RID: 36643
		private LuaFunction m_OnEnable_hotfix;

		// Token: 0x04008F24 RID: 36644
		private LuaFunction m_Show_hotfix;

		// Token: 0x04008F25 RID: 36645
		private LuaFunction m_GetInviteMsgList_hotfix;

		// Token: 0x04008F26 RID: 36646
		private LuaFunction m_Refresh_hotfix;

		// Token: 0x04008F27 RID: 36647
		private LuaFunction m_OnCloseClick_hotfix;

		// Token: 0x04008F28 RID: 36648
		private LuaFunction m_OnBGClick_hotfix;

		// Token: 0x04008F29 RID: 36649
		private LuaFunction m_OnRefuseAllClick_hotfix;

		// Token: 0x02000CE0 RID: 3296
		public new class LuaExportHelper
		{
			// Token: 0x0600F08B RID: 61579 RVA: 0x004008DC File Offset: 0x003FEADC
			public LuaExportHelper(BeforeJoinGuildMsgUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F08C RID: 61580 RVA: 0x004008EC File Offset: 0x003FEAEC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F08D RID: 61581 RVA: 0x004008FC File Offset: 0x003FEAFC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F08E RID: 61582 RVA: 0x0040090C File Offset: 0x003FEB0C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F08F RID: 61583 RVA: 0x0040091C File Offset: 0x003FEB1C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F090 RID: 61584 RVA: 0x00400934 File Offset: 0x003FEB34
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F091 RID: 61585 RVA: 0x00400944 File Offset: 0x003FEB44
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F092 RID: 61586 RVA: 0x00400954 File Offset: 0x003FEB54
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F093 RID: 61587 RVA: 0x00400964 File Offset: 0x003FEB64
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F094 RID: 61588 RVA: 0x00400974 File Offset: 0x003FEB74
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F095 RID: 61589 RVA: 0x00400984 File Offset: 0x003FEB84
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F096 RID: 61590 RVA: 0x00400994 File Offset: 0x003FEB94
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F097 RID: 61591 RVA: 0x004009A4 File Offset: 0x003FEBA4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F098 RID: 61592 RVA: 0x004009B4 File Offset: 0x003FEBB4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F099 RID: 61593 RVA: 0x004009C4 File Offset: 0x003FEBC4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F09A RID: 61594 RVA: 0x004009D4 File Offset: 0x003FEBD4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002E45 RID: 11845
			// (get) Token: 0x0600F09B RID: 61595 RVA: 0x004009E4 File Offset: 0x003FEBE4
			// (set) Token: 0x0600F09C RID: 61596 RVA: 0x004009F4 File Offset: 0x003FEBF4
			public CommonUIStateController m_guildMsgAnimation
			{
				get
				{
					return this.m_owner.m_guildMsgAnimation;
				}
				set
				{
					this.m_owner.m_guildMsgAnimation = value;
				}
			}

			// Token: 0x17002E46 RID: 11846
			// (get) Token: 0x0600F09D RID: 61597 RVA: 0x00400A04 File Offset: 0x003FEC04
			// (set) Token: 0x0600F09E RID: 61598 RVA: 0x00400A14 File Offset: 0x003FEC14
			public Button m_allRefuseButton
			{
				get
				{
					return this.m_owner.m_allRefuseButton;
				}
				set
				{
					this.m_owner.m_allRefuseButton = value;
				}
			}

			// Token: 0x17002E47 RID: 11847
			// (get) Token: 0x0600F09F RID: 61599 RVA: 0x00400A24 File Offset: 0x003FEC24
			// (set) Token: 0x0600F0A0 RID: 61600 RVA: 0x00400A34 File Offset: 0x003FEC34
			public Button m_colseButton
			{
				get
				{
					return this.m_owner.m_colseButton;
				}
				set
				{
					this.m_owner.m_colseButton = value;
				}
			}

			// Token: 0x17002E48 RID: 11848
			// (get) Token: 0x0600F0A1 RID: 61601 RVA: 0x00400A44 File Offset: 0x003FEC44
			// (set) Token: 0x0600F0A2 RID: 61602 RVA: 0x00400A54 File Offset: 0x003FEC54
			public Button m_bgButton
			{
				get
				{
					return this.m_owner.m_bgButton;
				}
				set
				{
					this.m_owner.m_bgButton = value;
				}
			}

			// Token: 0x17002E49 RID: 11849
			// (get) Token: 0x0600F0A3 RID: 61603 RVA: 0x00400A64 File Offset: 0x003FEC64
			// (set) Token: 0x0600F0A4 RID: 61604 RVA: 0x00400A74 File Offset: 0x003FEC74
			public GameObject m_guildItemTemplate
			{
				get
				{
					return this.m_owner.m_guildItemTemplate;
				}
				set
				{
					this.m_owner.m_guildItemTemplate = value;
				}
			}

			// Token: 0x17002E4A RID: 11850
			// (get) Token: 0x0600F0A5 RID: 61605 RVA: 0x00400A84 File Offset: 0x003FEC84
			// (set) Token: 0x0600F0A6 RID: 61606 RVA: 0x00400A94 File Offset: 0x003FEC94
			public GameObject m_msgListContent
			{
				get
				{
					return this.m_owner.m_msgListContent;
				}
				set
				{
					this.m_owner.m_msgListContent = value;
				}
			}

			// Token: 0x17002E4B RID: 11851
			// (get) Token: 0x0600F0A7 RID: 61607 RVA: 0x00400AA4 File Offset: 0x003FECA4
			// (set) Token: 0x0600F0A8 RID: 61608 RVA: 0x00400AB4 File Offset: 0x003FECB4
			public GameObject m_noMessage
			{
				get
				{
					return this.m_owner.m_noMessage;
				}
				set
				{
					this.m_owner.m_noMessage = value;
				}
			}

			// Token: 0x17002E4C RID: 11852
			// (get) Token: 0x0600F0A9 RID: 61609 RVA: 0x00400AC4 File Offset: 0x003FECC4
			// (set) Token: 0x0600F0AA RID: 61610 RVA: 0x00400AD4 File Offset: 0x003FECD4
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

			// Token: 0x17002E4D RID: 11853
			// (get) Token: 0x0600F0AB RID: 61611 RVA: 0x00400AE4 File Offset: 0x003FECE4
			// (set) Token: 0x0600F0AC RID: 61612 RVA: 0x00400AF4 File Offset: 0x003FECF4
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

			// Token: 0x17002E4E RID: 11854
			// (get) Token: 0x0600F0AD RID: 61613 RVA: 0x00400B04 File Offset: 0x003FED04
			// (set) Token: 0x0600F0AE RID: 61614 RVA: 0x00400B14 File Offset: 0x003FED14
			public List<GuildJoinInvitation> m_guildJoinInvitationList
			{
				get
				{
					return this.m_owner.m_guildJoinInvitationList;
				}
				set
				{
					this.m_owner.m_guildJoinInvitationList = value;
				}
			}

			// Token: 0x17002E4F RID: 11855
			// (get) Token: 0x0600F0AF RID: 61615 RVA: 0x00400B24 File Offset: 0x003FED24
			// (set) Token: 0x0600F0B0 RID: 61616 RVA: 0x00400B34 File Offset: 0x003FED34
			public List<GuildInviteItemUIController> m_guildInviteItemUIControllerList
			{
				get
				{
					return this.m_owner.m_guildInviteItemUIControllerList;
				}
				set
				{
					this.m_owner.m_guildInviteItemUIControllerList = value;
				}
			}

			// Token: 0x0600F0B1 RID: 61617 RVA: 0x00400B44 File Offset: 0x003FED44
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F0B2 RID: 61618 RVA: 0x00400B54 File Offset: 0x003FED54
			public void OnEnable()
			{
				this.m_owner.OnEnable();
			}

			// Token: 0x0600F0B3 RID: 61619 RVA: 0x00400B64 File Offset: 0x003FED64
			public void GetInviteMsgList()
			{
				this.m_owner.GetInviteMsgList();
			}

			// Token: 0x0600F0B4 RID: 61620 RVA: 0x00400B74 File Offset: 0x003FED74
			public void OnCloseClick()
			{
				this.m_owner.OnCloseClick();
			}

			// Token: 0x0600F0B5 RID: 61621 RVA: 0x00400B84 File Offset: 0x003FED84
			public void OnBGClick()
			{
				this.m_owner.OnBGClick();
			}

			// Token: 0x0600F0B6 RID: 61622 RVA: 0x00400B94 File Offset: 0x003FED94
			public void OnRefuseAllClick()
			{
				this.m_owner.OnRefuseAllClick();
			}

			// Token: 0x04008F2A RID: 36650
			private BeforeJoinGuildMsgUIController m_owner;
		}
	}
}
