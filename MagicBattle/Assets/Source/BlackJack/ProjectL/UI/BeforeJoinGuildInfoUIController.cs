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
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CD8 RID: 3288
	[HotFix]
	public class BeforeJoinGuildInfoUIController : UIControllerBase
	{
		// Token: 0x0600EF81 RID: 61313 RVA: 0x003FDB00 File Offset: 0x003FBD00
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
			this.m_guildDetailButton.onClick.AddListener(new UnityAction(this.OnGuildDetailClick));
			this.m_guildJoinButton.onClick.AddListener(new UnityAction(this.OnGuildJoinClick));
			this.SetInfoPanelState(false);
		}

		// Token: 0x0600EF82 RID: 61314 RVA: 0x003FDBD0 File Offset: 0x003FBDD0
		public void Init(BeforeJoinGuildUIController guildUIController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBeforeJoinGuildUIController_hotfix != null)
			{
				this.m_InitBeforeJoinGuildUIController_hotfix.call(new object[]
				{
					this,
					guildUIController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildUIController = guildUIController;
		}

		// Token: 0x0600EF83 RID: 61315 RVA: 0x003FDC48 File Offset: 0x003FBE48
		public void SetInfoPanelState(bool hasData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetInfoPanelStateBoolean_hotfix != null)
			{
				this.m_SetInfoPanelStateBoolean_hotfix.call(new object[]
				{
					this,
					hasData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hasData)
			{
				this.m_infoPanelAnimation.SetToUIState("Normal", false, true);
				this.m_guildJoinButtonAnimation.SetToUIState("Normal", false, true);
				this.m_guildJoinButton.enabled = true;
				this.m_guildDetailButtonAnimation.SetToUIState("Normal", false, true);
				this.m_guildDetailButton.enabled = true;
			}
			else
			{
				this.m_infoPanelAnimation.SetToUIState("Nothing", false, true);
				this.m_guildJoinButtonAnimation.SetToUIState("Grey", false, true);
				this.m_guildJoinButton.enabled = false;
				this.m_guildDetailButtonAnimation.SetToUIState("Grey", false, true);
				this.m_guildDetailButton.enabled = false;
			}
		}

		// Token: 0x0600EF84 RID: 61316 RVA: 0x003FDD60 File Offset: 0x003FBF60
		public void SetSelectGuildInfo(GuildSearchInfo guildSearchInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectGuildInfoGuildSearchInfo_hotfix != null)
			{
				this.m_SetSelectGuildInfoGuildSearchInfo_hotfix.call(new object[]
				{
					this,
					guildSearchInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (guildSearchInfo != null)
			{
				this.SetInfoPanelState(true);
			}
			this.m_selectGuildInfo = guildSearchInfo;
			this.m_charLevelText.text = guildSearchInfo.PresidentMemberInfo.Level.ToString();
			this.m_charName.text = guildSearchInfo.PresidentMemberInfo.Name.ToString();
			this.m_charIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(guildSearchInfo.PresidentMemberInfo.HeadIcon)));
			UIUtility.SetPlayerHeadFrame(this.m_headFrameDummy, HeadIconTools.GetHeadFrame(guildSearchInfo.PresidentMemberInfo.HeadIcon), true, "Normal");
			this.m_guildNameText.text = guildSearchInfo.Name;
			this.m_guildDeclarationText.text = guildSearchInfo.HiringDeclaration;
			if (guildSearchInfo.HaveSendJoinReq)
			{
				this.m_guildJoinButtonAnimation.SetToUIState("Grey", false, true);
				this.m_guildJoinButton.enabled = false;
			}
			else
			{
				this.m_guildJoinButtonAnimation.SetToUIState("Normal", false, true);
				this.m_guildJoinButton.enabled = true;
			}
		}

		// Token: 0x0600EF85 RID: 61317 RVA: 0x003FDEE0 File Offset: 0x003FC0E0
		private void OnGuildJoinClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildJoinClick_hotfix != null)
			{
				this.m_OnGuildJoinClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildJoinApplyReqNetTask guildJoinApplyReqNetTask = new GuildJoinApplyReqNetTask(this.m_selectGuildInfo.Id);
			guildJoinApplyReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildJoinApplyReqNetTask guildJoinApplyReqNetTask2 = task as GuildJoinApplyReqNetTask;
				if (guildJoinApplyReqNetTask2.Result == 0)
				{
					this.m_guildUIController.m_guildListUIController.RefreshGuildList();
					this.SetSelectGuildInfo(this.m_selectGuildInfo);
					if (!string.IsNullOrEmpty(this.m_playerContext.GetGuildId()))
					{
						GuildUITask guildUITask = UIUtility.FindUITaskWithType(typeof(GuildUITask)) as GuildUITask;
						UIIntent prevTaskIntent = (guildUITask.CurrentIntent as UIIntentReturnable).PrevTaskIntent;
						guildUITask.Stop();
						UIIntent intent = prevTaskIntent;
						GuildManagementUITask.StartUITask(null, intent);
					}
				}
				else if (guildJoinApplyReqNetTask2.Result == -5203)
				{
					TimeSpan timeSpan = this.m_playerContext.CanJoinGuildCDTime();
					string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_JoinGuildCD);
					CommonUIController.Instance.ShowMessage(string.Format(format, timeSpan.Hours, timeSpan.Minutes + 1), 2f, null, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildJoinApplyReqNetTask2.Result, 2f, null, true);
				}
			};
			guildJoinApplyReqNetTask.Start(null);
		}

		// Token: 0x0600EF86 RID: 61318 RVA: 0x003FDF6C File Offset: 0x003FC16C
		private void OnGuildDetailClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildDetailClick_hotfix != null)
			{
				this.m_OnGuildDetailClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildUITask guildUITask = UIUtility.FindUITaskWithType(typeof(GuildUITask)) as GuildUITask;
			UIIntent prevTaskIntent = (guildUITask.CurrentIntent as UIIntentReturnable).PrevTaskIntent;
			GuildManagementUITask.StartUITask(this.m_selectGuildInfo.Id, prevTaskIntent);
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x0600EF87 RID: 61319 RVA: 0x003FE004 File Offset: 0x003FC204
		// (set) Token: 0x0600EF88 RID: 61320 RVA: 0x003FE024 File Offset: 0x003FC224
		[DoNotToLua]
		public new BeforeJoinGuildInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BeforeJoinGuildInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600EF89 RID: 61321 RVA: 0x003FE030 File Offset: 0x003FC230
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600EF8A RID: 61322 RVA: 0x003FE03C File Offset: 0x003FC23C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600EF8B RID: 61323 RVA: 0x003FE044 File Offset: 0x003FC244
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600EF8C RID: 61324 RVA: 0x003FE04C File Offset: 0x003FC24C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600EF8D RID: 61325 RVA: 0x003FE060 File Offset: 0x003FC260
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600EF8E RID: 61326 RVA: 0x003FE068 File Offset: 0x003FC268
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600EF8F RID: 61327 RVA: 0x003FE074 File Offset: 0x003FC274
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600EF90 RID: 61328 RVA: 0x003FE080 File Offset: 0x003FC280
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600EF91 RID: 61329 RVA: 0x003FE08C File Offset: 0x003FC28C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600EF92 RID: 61330 RVA: 0x003FE098 File Offset: 0x003FC298
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600EF93 RID: 61331 RVA: 0x003FE0A4 File Offset: 0x003FC2A4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600EF94 RID: 61332 RVA: 0x003FE0B0 File Offset: 0x003FC2B0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600EF95 RID: 61333 RVA: 0x003FE0BC File Offset: 0x003FC2BC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600EF96 RID: 61334 RVA: 0x003FE0C8 File Offset: 0x003FC2C8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600EF97 RID: 61335 RVA: 0x003FE0D4 File Offset: 0x003FC2D4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600EF99 RID: 61337 RVA: 0x003FE1E4 File Offset: 0x003FC3E4
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
					this.m_InitBeforeJoinGuildUIController_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_SetInfoPanelStateBoolean_hotfix = (luaObj.RawGet("SetInfoPanelState") as LuaFunction);
					this.m_SetSelectGuildInfoGuildSearchInfo_hotfix = (luaObj.RawGet("SetSelectGuildInfo") as LuaFunction);
					this.m_OnGuildJoinClick_hotfix = (luaObj.RawGet("OnGuildJoinClick") as LuaFunction);
					this.m_OnGuildDetailClick_hotfix = (luaObj.RawGet("OnGuildDetailClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600EF9A RID: 61338 RVA: 0x003FE32C File Offset: 0x003FC52C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BeforeJoinGuildInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008EC4 RID: 36548
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_infoPanelAnimation;

		// Token: 0x04008EC5 RID: 36549
		[AutoBind("./Char/HeadIcon/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_charLevelText;

		// Token: 0x04008EC6 RID: 36550
		[AutoBind("./Char/HeadIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_charIcon;

		// Token: 0x04008EC7 RID: 36551
		[AutoBind("./Char/HeadIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_headFrameDummy;

		// Token: 0x04008EC8 RID: 36552
		[AutoBind("./Char/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_charName;

		// Token: 0x04008EC9 RID: 36553
		[AutoBind("./BGImages/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_guildNameText;

		// Token: 0x04008ECA RID: 36554
		[AutoBind("./Declaration/DeclarationText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_guildDeclarationText;

		// Token: 0x04008ECB RID: 36555
		[AutoBind("./DetailButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildDetailButton;

		// Token: 0x04008ECC RID: 36556
		[AutoBind("./DetailButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_guildDetailButtonAnimation;

		// Token: 0x04008ECD RID: 36557
		[AutoBind("./JoinInButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildJoinButton;

		// Token: 0x04008ECE RID: 36558
		[AutoBind("./JoinInButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_guildJoinButtonAnimation;

		// Token: 0x04008ECF RID: 36559
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008ED0 RID: 36560
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008ED1 RID: 36561
		private GuildSearchInfo m_selectGuildInfo;

		// Token: 0x04008ED2 RID: 36562
		private BeforeJoinGuildUIController m_guildUIController;

		// Token: 0x04008ED3 RID: 36563
		[DoNotToLua]
		private BeforeJoinGuildInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008ED4 RID: 36564
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008ED5 RID: 36565
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008ED6 RID: 36566
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008ED7 RID: 36567
		private LuaFunction m_InitBeforeJoinGuildUIController_hotfix;

		// Token: 0x04008ED8 RID: 36568
		private LuaFunction m_SetInfoPanelStateBoolean_hotfix;

		// Token: 0x04008ED9 RID: 36569
		private LuaFunction m_SetSelectGuildInfoGuildSearchInfo_hotfix;

		// Token: 0x04008EDA RID: 36570
		private LuaFunction m_OnGuildJoinClick_hotfix;

		// Token: 0x04008EDB RID: 36571
		private LuaFunction m_OnGuildDetailClick_hotfix;

		// Token: 0x02000CD9 RID: 3289
		public new class LuaExportHelper
		{
			// Token: 0x0600EF9B RID: 61339 RVA: 0x003FE394 File Offset: 0x003FC594
			public LuaExportHelper(BeforeJoinGuildInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600EF9C RID: 61340 RVA: 0x003FE3A4 File Offset: 0x003FC5A4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600EF9D RID: 61341 RVA: 0x003FE3B4 File Offset: 0x003FC5B4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600EF9E RID: 61342 RVA: 0x003FE3C4 File Offset: 0x003FC5C4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600EF9F RID: 61343 RVA: 0x003FE3D4 File Offset: 0x003FC5D4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600EFA0 RID: 61344 RVA: 0x003FE3EC File Offset: 0x003FC5EC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600EFA1 RID: 61345 RVA: 0x003FE3FC File Offset: 0x003FC5FC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600EFA2 RID: 61346 RVA: 0x003FE40C File Offset: 0x003FC60C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600EFA3 RID: 61347 RVA: 0x003FE41C File Offset: 0x003FC61C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600EFA4 RID: 61348 RVA: 0x003FE42C File Offset: 0x003FC62C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600EFA5 RID: 61349 RVA: 0x003FE43C File Offset: 0x003FC63C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600EFA6 RID: 61350 RVA: 0x003FE44C File Offset: 0x003FC64C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600EFA7 RID: 61351 RVA: 0x003FE45C File Offset: 0x003FC65C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600EFA8 RID: 61352 RVA: 0x003FE46C File Offset: 0x003FC66C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600EFA9 RID: 61353 RVA: 0x003FE47C File Offset: 0x003FC67C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600EFAA RID: 61354 RVA: 0x003FE48C File Offset: 0x003FC68C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002E19 RID: 11801
			// (get) Token: 0x0600EFAB RID: 61355 RVA: 0x003FE49C File Offset: 0x003FC69C
			// (set) Token: 0x0600EFAC RID: 61356 RVA: 0x003FE4AC File Offset: 0x003FC6AC
			public CommonUIStateController m_infoPanelAnimation
			{
				get
				{
					return this.m_owner.m_infoPanelAnimation;
				}
				set
				{
					this.m_owner.m_infoPanelAnimation = value;
				}
			}

			// Token: 0x17002E1A RID: 11802
			// (get) Token: 0x0600EFAD RID: 61357 RVA: 0x003FE4BC File Offset: 0x003FC6BC
			// (set) Token: 0x0600EFAE RID: 61358 RVA: 0x003FE4CC File Offset: 0x003FC6CC
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

			// Token: 0x17002E1B RID: 11803
			// (get) Token: 0x0600EFAF RID: 61359 RVA: 0x003FE4DC File Offset: 0x003FC6DC
			// (set) Token: 0x0600EFB0 RID: 61360 RVA: 0x003FE4EC File Offset: 0x003FC6EC
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

			// Token: 0x17002E1C RID: 11804
			// (get) Token: 0x0600EFB1 RID: 61361 RVA: 0x003FE4FC File Offset: 0x003FC6FC
			// (set) Token: 0x0600EFB2 RID: 61362 RVA: 0x003FE50C File Offset: 0x003FC70C
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

			// Token: 0x17002E1D RID: 11805
			// (get) Token: 0x0600EFB3 RID: 61363 RVA: 0x003FE51C File Offset: 0x003FC71C
			// (set) Token: 0x0600EFB4 RID: 61364 RVA: 0x003FE52C File Offset: 0x003FC72C
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

			// Token: 0x17002E1E RID: 11806
			// (get) Token: 0x0600EFB5 RID: 61365 RVA: 0x003FE53C File Offset: 0x003FC73C
			// (set) Token: 0x0600EFB6 RID: 61366 RVA: 0x003FE54C File Offset: 0x003FC74C
			public Text m_guildNameText
			{
				get
				{
					return this.m_owner.m_guildNameText;
				}
				set
				{
					this.m_owner.m_guildNameText = value;
				}
			}

			// Token: 0x17002E1F RID: 11807
			// (get) Token: 0x0600EFB7 RID: 61367 RVA: 0x003FE55C File Offset: 0x003FC75C
			// (set) Token: 0x0600EFB8 RID: 61368 RVA: 0x003FE56C File Offset: 0x003FC76C
			public Text m_guildDeclarationText
			{
				get
				{
					return this.m_owner.m_guildDeclarationText;
				}
				set
				{
					this.m_owner.m_guildDeclarationText = value;
				}
			}

			// Token: 0x17002E20 RID: 11808
			// (get) Token: 0x0600EFB9 RID: 61369 RVA: 0x003FE57C File Offset: 0x003FC77C
			// (set) Token: 0x0600EFBA RID: 61370 RVA: 0x003FE58C File Offset: 0x003FC78C
			public Button m_guildDetailButton
			{
				get
				{
					return this.m_owner.m_guildDetailButton;
				}
				set
				{
					this.m_owner.m_guildDetailButton = value;
				}
			}

			// Token: 0x17002E21 RID: 11809
			// (get) Token: 0x0600EFBB RID: 61371 RVA: 0x003FE59C File Offset: 0x003FC79C
			// (set) Token: 0x0600EFBC RID: 61372 RVA: 0x003FE5AC File Offset: 0x003FC7AC
			public CommonUIStateController m_guildDetailButtonAnimation
			{
				get
				{
					return this.m_owner.m_guildDetailButtonAnimation;
				}
				set
				{
					this.m_owner.m_guildDetailButtonAnimation = value;
				}
			}

			// Token: 0x17002E22 RID: 11810
			// (get) Token: 0x0600EFBD RID: 61373 RVA: 0x003FE5BC File Offset: 0x003FC7BC
			// (set) Token: 0x0600EFBE RID: 61374 RVA: 0x003FE5CC File Offset: 0x003FC7CC
			public Button m_guildJoinButton
			{
				get
				{
					return this.m_owner.m_guildJoinButton;
				}
				set
				{
					this.m_owner.m_guildJoinButton = value;
				}
			}

			// Token: 0x17002E23 RID: 11811
			// (get) Token: 0x0600EFBF RID: 61375 RVA: 0x003FE5DC File Offset: 0x003FC7DC
			// (set) Token: 0x0600EFC0 RID: 61376 RVA: 0x003FE5EC File Offset: 0x003FC7EC
			public CommonUIStateController m_guildJoinButtonAnimation
			{
				get
				{
					return this.m_owner.m_guildJoinButtonAnimation;
				}
				set
				{
					this.m_owner.m_guildJoinButtonAnimation = value;
				}
			}

			// Token: 0x17002E24 RID: 11812
			// (get) Token: 0x0600EFC1 RID: 61377 RVA: 0x003FE5FC File Offset: 0x003FC7FC
			// (set) Token: 0x0600EFC2 RID: 61378 RVA: 0x003FE60C File Offset: 0x003FC80C
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

			// Token: 0x17002E25 RID: 11813
			// (get) Token: 0x0600EFC3 RID: 61379 RVA: 0x003FE61C File Offset: 0x003FC81C
			// (set) Token: 0x0600EFC4 RID: 61380 RVA: 0x003FE62C File Offset: 0x003FC82C
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

			// Token: 0x17002E26 RID: 11814
			// (get) Token: 0x0600EFC5 RID: 61381 RVA: 0x003FE63C File Offset: 0x003FC83C
			// (set) Token: 0x0600EFC6 RID: 61382 RVA: 0x003FE64C File Offset: 0x003FC84C
			public GuildSearchInfo m_selectGuildInfo
			{
				get
				{
					return this.m_owner.m_selectGuildInfo;
				}
				set
				{
					this.m_owner.m_selectGuildInfo = value;
				}
			}

			// Token: 0x17002E27 RID: 11815
			// (get) Token: 0x0600EFC7 RID: 61383 RVA: 0x003FE65C File Offset: 0x003FC85C
			// (set) Token: 0x0600EFC8 RID: 61384 RVA: 0x003FE66C File Offset: 0x003FC86C
			public BeforeJoinGuildUIController m_guildUIController
			{
				get
				{
					return this.m_owner.m_guildUIController;
				}
				set
				{
					this.m_owner.m_guildUIController = value;
				}
			}

			// Token: 0x0600EFC9 RID: 61385 RVA: 0x003FE67C File Offset: 0x003FC87C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600EFCA RID: 61386 RVA: 0x003FE68C File Offset: 0x003FC88C
			public void OnGuildJoinClick()
			{
				this.m_owner.OnGuildJoinClick();
			}

			// Token: 0x0600EFCB RID: 61387 RVA: 0x003FE69C File Offset: 0x003FC89C
			public void OnGuildDetailClick()
			{
				this.m_owner.OnGuildDetailClick();
			}

			// Token: 0x04008EDC RID: 36572
			private BeforeJoinGuildInfoUIController m_owner;
		}
	}
}
