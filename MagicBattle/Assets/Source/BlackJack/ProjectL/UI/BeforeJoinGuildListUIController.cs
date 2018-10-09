using System;
using System.Collections.Generic;
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
	// Token: 0x02000CDA RID: 3290
	[HotFix]
	public class BeforeJoinGuildListUIController : UIControllerBase
	{
		// Token: 0x0600EFCD RID: 61389 RVA: 0x003FE6C0 File Offset: 0x003FC8C0
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
			this.m_guildCreateButton.onClick.AddListener(new UnityAction(this.OnCreateGuildClick));
			this.m_changeButton.onClick.AddListener(new UnityAction(this.OnChangeGuildClick));
			this.m_guildSearchButton.onClick.AddListener(new UnityAction(this.OnSearchClick));
			this.m_deleteSearchButton.onClick.AddListener(new UnityAction(this.OnDeleteSearchClick));
		}

		// Token: 0x0600EFCE RID: 61390 RVA: 0x003FE7C0 File Offset: 0x003FC9C0
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
			this.m_guildRecommendInfoList = this.m_playerContext.GetGuildRecommendList();
			if (this.m_guildRecommendInfoList == null)
			{
				this.GetRandomGuildList(null);
			}
			else
			{
				this.RefreshGuildList(this.m_guildRecommendInfoList);
			}
		}

		// Token: 0x0600EFCF RID: 61391 RVA: 0x003FE86C File Offset: 0x003FCA6C
		private void GetRandomGuildList(Action<int> OnReqFinish)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRandomGuildListAction`1_hotfix != null)
			{
				this.m_GetRandomGuildListAction`1_hotfix.call(new object[]
				{
					this,
					OnReqFinish2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<int> OnReqFinish = OnReqFinish2;
			BeforeJoinGuildListUIController $this = this;
			int result = this.m_playerContext.CheckGuildRandomList();
			if (result != 0)
			{
				CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				return;
			}
			GuildRandomListReqNetTask guildRandomListReqNetTask = new GuildRandomListReqNetTask();
			guildRandomListReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildRandomListReqNetTask guildRandomListReqNetTask2 = task as GuildRandomListReqNetTask;
				if (guildRandomListReqNetTask2.Result == 0)
				{
					$this.m_guildRecommendInfoList = guildRandomListReqNetTask2.m_guildSearchInfoList;
					$this.RefreshGuildList($this.m_guildRecommendInfoList);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildRandomListReqNetTask2.Result, 2f, null, true);
				}
				if (OnReqFinish != null)
				{
					OnReqFinish(result);
				}
			};
			guildRandomListReqNetTask.Start(null);
		}

		// Token: 0x0600EFD0 RID: 61392 RVA: 0x003FE944 File Offset: 0x003FCB44
		private void SetGuildItemSelect(BeforeJoinSingleGuildUIController guildItemUIController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGuildItemSelectBeforeJoinSingleGuildUIController_hotfix != null)
			{
				this.m_SetGuildItemSelectBeforeJoinSingleGuildUIController_hotfix.call(new object[]
				{
					this,
					guildItemUIController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_selectGuildItemUIController != null)
			{
				this.m_selectGuildItemUIController.SetSelect(false);
			}
			this.m_selectGuildItemUIController = guildItemUIController;
			this.m_selectGuildItemUIController.SetSelect(true);
			this.m_guildUIController.m_guildInfoUIController.SetSelectGuildInfo(guildItemUIController.m_guildSearchInfo);
		}

		// Token: 0x0600EFD1 RID: 61393 RVA: 0x003FE9FC File Offset: 0x003FCBFC
		public void RefreshGuildList(List<GuildSearchInfo> guildSearchInfoList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshGuildListList`1_hotfix != null)
			{
				this.m_RefreshGuildListList`1_hotfix.call(new object[]
				{
					this,
					guildSearchInfoList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_showGuildInfoList = guildSearchInfoList;
			foreach (BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController in this.m_guildInfoUIController)
			{
				UnityEngine.Object.Destroy(beforeJoinSingleGuildUIController.gameObject);
			}
			this.m_guildInfoUIController.Clear();
			foreach (GuildSearchInfo guildSearchInfo in guildSearchInfoList)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_guildItem);
				gameObject.transform.SetParent(this.m_guildListContent, false);
				BeforeJoinSingleGuildUIController beforeJoinSingleGuildUIController2 = GameObjectUtility.AddControllerToGameObject<BeforeJoinSingleGuildUIController>(gameObject);
				beforeJoinSingleGuildUIController2.Init(guildSearchInfo, new Action<BeforeJoinSingleGuildUIController>(this.OnGuildItemClick));
				this.m_guildInfoUIController.Add(beforeJoinSingleGuildUIController2);
			}
			if (this.m_guildInfoUIController.Count > 0)
			{
				this.SetGuildItemSelect(this.m_guildInfoUIController[0]);
				this.m_listPanelAnimation.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_guildUIController.m_guildInfoUIController.SetInfoPanelState(false);
				this.m_listPanelAnimation.SetToUIState("Nothing", false, true);
			}
		}

		// Token: 0x0600EFD2 RID: 61394 RVA: 0x003FEBB8 File Offset: 0x003FCDB8
		public void RefreshGuildList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshGuildList_hotfix != null)
			{
				this.m_RefreshGuildList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RefreshGuildList(this.m_showGuildInfoList);
		}

		// Token: 0x0600EFD3 RID: 61395 RVA: 0x003FEC24 File Offset: 0x003FCE24
		private void OnCreateGuildClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCreateGuildClick_hotfix != null)
			{
				this.m_OnCreateGuildClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildUIController.m_createGuildUIController.Show();
		}

		// Token: 0x0600EFD4 RID: 61396 RVA: 0x003FEC94 File Offset: 0x003FCE94
		private void OnChangeGuildClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeGuildClick_hotfix != null)
			{
				this.m_OnChangeGuildClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.GetRandomGuildList(delegate(int result)
			{
				string value = this.m_configDataLoader.GetConfigDataStringTable(14015).Value;
				CommonUIController.Instance.ShowTip(value);
			});
		}

		// Token: 0x0600EFD5 RID: 61397 RVA: 0x003FED08 File Offset: 0x003FCF08
		private void OnSearchClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSearchClick_hotfix != null)
			{
				this.m_OnSearchClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(this.m_guildNameInputField.text))
			{
				string value = this.m_configDataLoader.GetConfigDataStringTable(14003).Value;
				CommonUIController.Instance.ShowMessage(value, 2f, null, true);
				return;
			}
			int num = this.m_playerContext.CheckGuildSearch(this.m_guildNameInputField.text);
			if (num != 0)
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				return;
			}
			GuildSearchReqNetTask guildSearchReqNetTask = new GuildSearchReqNetTask(this.m_guildNameInputField.text);
			guildSearchReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildSearchReqNetTask guildSearchReqNetTask2 = task as GuildSearchReqNetTask;
				if (guildSearchReqNetTask2.Result == 0)
				{
					this.m_guildSearchInfoList = guildSearchReqNetTask2.m_guildSearchInfoList;
					this.RefreshGuildList(this.m_guildSearchInfoList);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildSearchReqNetTask2.Result, 2f, null, true);
				}
			};
			guildSearchReqNetTask.Start(null);
		}

		// Token: 0x0600EFD6 RID: 61398 RVA: 0x003FEE04 File Offset: 0x003FD004
		private void OnDeleteSearchClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDeleteSearchClick_hotfix != null)
			{
				this.m_OnDeleteSearchClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildNameInputField.text = string.Empty;
			this.RefreshGuildList(this.m_guildRecommendInfoList);
		}

		// Token: 0x0600EFD7 RID: 61399 RVA: 0x003FEE80 File Offset: 0x003FD080
		private void OnGuildItemClick(BeforeJoinSingleGuildUIController guildItemUIController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildItemClickBeforeJoinSingleGuildUIController_hotfix != null)
			{
				this.m_OnGuildItemClickBeforeJoinSingleGuildUIController_hotfix.call(new object[]
				{
					this,
					guildItemUIController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetGuildItemSelect(guildItemUIController);
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0600EFD8 RID: 61400 RVA: 0x003FEEF8 File Offset: 0x003FD0F8
		// (set) Token: 0x0600EFD9 RID: 61401 RVA: 0x003FEF18 File Offset: 0x003FD118
		[DoNotToLua]
		public new BeforeJoinGuildListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BeforeJoinGuildListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600EFDA RID: 61402 RVA: 0x003FEF24 File Offset: 0x003FD124
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600EFDB RID: 61403 RVA: 0x003FEF30 File Offset: 0x003FD130
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600EFDC RID: 61404 RVA: 0x003FEF38 File Offset: 0x003FD138
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600EFDD RID: 61405 RVA: 0x003FEF40 File Offset: 0x003FD140
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600EFDE RID: 61406 RVA: 0x003FEF54 File Offset: 0x003FD154
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600EFDF RID: 61407 RVA: 0x003FEF5C File Offset: 0x003FD15C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600EFE0 RID: 61408 RVA: 0x003FEF68 File Offset: 0x003FD168
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600EFE1 RID: 61409 RVA: 0x003FEF74 File Offset: 0x003FD174
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600EFE2 RID: 61410 RVA: 0x003FEF80 File Offset: 0x003FD180
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600EFE3 RID: 61411 RVA: 0x003FEF8C File Offset: 0x003FD18C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600EFE4 RID: 61412 RVA: 0x003FEF98 File Offset: 0x003FD198
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600EFE5 RID: 61413 RVA: 0x003FEFA4 File Offset: 0x003FD1A4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600EFE6 RID: 61414 RVA: 0x003FEFB0 File Offset: 0x003FD1B0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600EFE7 RID: 61415 RVA: 0x003FEFBC File Offset: 0x003FD1BC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600EFE8 RID: 61416 RVA: 0x003FEFC8 File Offset: 0x003FD1C8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600EFEB RID: 61419 RVA: 0x003FF054 File Offset: 0x003FD254
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
					this.m_GetRandomGuildListAction`1_hotfix = (luaObj.RawGet("GetRandomGuildList") as LuaFunction);
					this.m_SetGuildItemSelectBeforeJoinSingleGuildUIController_hotfix = (luaObj.RawGet("SetGuildItemSelect") as LuaFunction);
					this.m_RefreshGuildListList`1_hotfix = (luaObj.RawGet("RefreshGuildList") as LuaFunction);
					this.m_RefreshGuildList_hotfix = (luaObj.RawGet("RefreshGuildList") as LuaFunction);
					this.m_OnCreateGuildClick_hotfix = (luaObj.RawGet("OnCreateGuildClick") as LuaFunction);
					this.m_OnChangeGuildClick_hotfix = (luaObj.RawGet("OnChangeGuildClick") as LuaFunction);
					this.m_OnSearchClick_hotfix = (luaObj.RawGet("OnSearchClick") as LuaFunction);
					this.m_OnDeleteSearchClick_hotfix = (luaObj.RawGet("OnDeleteSearchClick") as LuaFunction);
					this.m_OnGuildItemClickBeforeJoinSingleGuildUIController_hotfix = (luaObj.RawGet("OnGuildItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600EFEC RID: 61420 RVA: 0x003FF21C File Offset: 0x003FD41C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BeforeJoinGuildListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008EDD RID: 36573
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_listPanelAnimation;

		// Token: 0x04008EDE RID: 36574
		[AutoBind("./SociatyListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_guildListContent;

		// Token: 0x04008EDF RID: 36575
		[AutoBind("./BottomButtonPanel/ChangeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeButton;

		// Token: 0x04008EE0 RID: 36576
		[AutoBind("./BottomButtonPanel/GreatButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildCreateButton;

		// Token: 0x04008EE1 RID: 36577
		[AutoBind("./BottomButtonPanel/Search/SearchButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildSearchButton;

		// Token: 0x04008EE2 RID: 36578
		[AutoBind("./BottomButtonPanel/Search/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_deleteSearchButton;

		// Token: 0x04008EE3 RID: 36579
		[AutoBind("./Prefab/SociatyItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_guildItem;

		// Token: 0x04008EE4 RID: 36580
		[AutoBind("./BottomButtonPanel/Search/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_guildNameInputField;

		// Token: 0x04008EE5 RID: 36581
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008EE6 RID: 36582
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008EE7 RID: 36583
		private BeforeJoinGuildUIController m_guildUIController;

		// Token: 0x04008EE8 RID: 36584
		private List<GuildSearchInfo> m_guildSearchInfoList;

		// Token: 0x04008EE9 RID: 36585
		private List<GuildSearchInfo> m_guildRecommendInfoList;

		// Token: 0x04008EEA RID: 36586
		private List<GuildSearchInfo> m_showGuildInfoList;

		// Token: 0x04008EEB RID: 36587
		private List<BeforeJoinSingleGuildUIController> m_guildInfoUIController = new List<BeforeJoinSingleGuildUIController>();

		// Token: 0x04008EEC RID: 36588
		private BeforeJoinSingleGuildUIController m_selectGuildItemUIController;

		// Token: 0x04008EED RID: 36589
		[DoNotToLua]
		private BeforeJoinGuildListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008EEE RID: 36590
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008EEF RID: 36591
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008EF0 RID: 36592
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008EF1 RID: 36593
		private LuaFunction m_InitBeforeJoinGuildUIController_hotfix;

		// Token: 0x04008EF2 RID: 36594
		private LuaFunction m_GetRandomGuildListAction;

		// Token: 0x04008EF3 RID: 36595
		private LuaFunction m_SetGuildItemSelectBeforeJoinSingleGuildUIController_hotfix;

		// Token: 0x04008EF4 RID: 36596
		private LuaFunction m_RefreshGuildListList;

		// Token: 0x04008EF5 RID: 36597
		private LuaFunction m_RefreshGuildList_hotfix;

		// Token: 0x04008EF6 RID: 36598
		private LuaFunction m_OnCreateGuildClick_hotfix;

		// Token: 0x04008EF7 RID: 36599
		private LuaFunction m_OnChangeGuildClick_hotfix;

		// Token: 0x04008EF8 RID: 36600
		private LuaFunction m_OnSearchClick_hotfix;

		// Token: 0x04008EF9 RID: 36601
		private LuaFunction m_OnDeleteSearchClick_hotfix;

		// Token: 0x04008EFA RID: 36602
		private LuaFunction m_OnGuildItemClickBeforeJoinSingleGuildUIController_hotfix;

		// Token: 0x02000CDB RID: 3291
		public new class LuaExportHelper
		{
			// Token: 0x0600EFED RID: 61421 RVA: 0x003FF284 File Offset: 0x003FD484
			public LuaExportHelper(BeforeJoinGuildListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600EFEE RID: 61422 RVA: 0x003FF294 File Offset: 0x003FD494
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600EFEF RID: 61423 RVA: 0x003FF2A4 File Offset: 0x003FD4A4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600EFF0 RID: 61424 RVA: 0x003FF2B4 File Offset: 0x003FD4B4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600EFF1 RID: 61425 RVA: 0x003FF2C4 File Offset: 0x003FD4C4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600EFF2 RID: 61426 RVA: 0x003FF2DC File Offset: 0x003FD4DC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600EFF3 RID: 61427 RVA: 0x003FF2EC File Offset: 0x003FD4EC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600EFF4 RID: 61428 RVA: 0x003FF2FC File Offset: 0x003FD4FC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600EFF5 RID: 61429 RVA: 0x003FF30C File Offset: 0x003FD50C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600EFF6 RID: 61430 RVA: 0x003FF31C File Offset: 0x003FD51C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600EFF7 RID: 61431 RVA: 0x003FF32C File Offset: 0x003FD52C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600EFF8 RID: 61432 RVA: 0x003FF33C File Offset: 0x003FD53C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600EFF9 RID: 61433 RVA: 0x003FF34C File Offset: 0x003FD54C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600EFFA RID: 61434 RVA: 0x003FF35C File Offset: 0x003FD55C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600EFFB RID: 61435 RVA: 0x003FF36C File Offset: 0x003FD56C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600EFFC RID: 61436 RVA: 0x003FF37C File Offset: 0x003FD57C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002E29 RID: 11817
			// (get) Token: 0x0600EFFD RID: 61437 RVA: 0x003FF38C File Offset: 0x003FD58C
			// (set) Token: 0x0600EFFE RID: 61438 RVA: 0x003FF39C File Offset: 0x003FD59C
			public CommonUIStateController m_listPanelAnimation
			{
				get
				{
					return this.m_owner.m_listPanelAnimation;
				}
				set
				{
					this.m_owner.m_listPanelAnimation = value;
				}
			}

			// Token: 0x17002E2A RID: 11818
			// (get) Token: 0x0600EFFF RID: 61439 RVA: 0x003FF3AC File Offset: 0x003FD5AC
			// (set) Token: 0x0600F000 RID: 61440 RVA: 0x003FF3BC File Offset: 0x003FD5BC
			public Transform m_guildListContent
			{
				get
				{
					return this.m_owner.m_guildListContent;
				}
				set
				{
					this.m_owner.m_guildListContent = value;
				}
			}

			// Token: 0x17002E2B RID: 11819
			// (get) Token: 0x0600F001 RID: 61441 RVA: 0x003FF3CC File Offset: 0x003FD5CC
			// (set) Token: 0x0600F002 RID: 61442 RVA: 0x003FF3DC File Offset: 0x003FD5DC
			public Button m_changeButton
			{
				get
				{
					return this.m_owner.m_changeButton;
				}
				set
				{
					this.m_owner.m_changeButton = value;
				}
			}

			// Token: 0x17002E2C RID: 11820
			// (get) Token: 0x0600F003 RID: 61443 RVA: 0x003FF3EC File Offset: 0x003FD5EC
			// (set) Token: 0x0600F004 RID: 61444 RVA: 0x003FF3FC File Offset: 0x003FD5FC
			public Button m_guildCreateButton
			{
				get
				{
					return this.m_owner.m_guildCreateButton;
				}
				set
				{
					this.m_owner.m_guildCreateButton = value;
				}
			}

			// Token: 0x17002E2D RID: 11821
			// (get) Token: 0x0600F005 RID: 61445 RVA: 0x003FF40C File Offset: 0x003FD60C
			// (set) Token: 0x0600F006 RID: 61446 RVA: 0x003FF41C File Offset: 0x003FD61C
			public Button m_guildSearchButton
			{
				get
				{
					return this.m_owner.m_guildSearchButton;
				}
				set
				{
					this.m_owner.m_guildSearchButton = value;
				}
			}

			// Token: 0x17002E2E RID: 11822
			// (get) Token: 0x0600F007 RID: 61447 RVA: 0x003FF42C File Offset: 0x003FD62C
			// (set) Token: 0x0600F008 RID: 61448 RVA: 0x003FF43C File Offset: 0x003FD63C
			public Button m_deleteSearchButton
			{
				get
				{
					return this.m_owner.m_deleteSearchButton;
				}
				set
				{
					this.m_owner.m_deleteSearchButton = value;
				}
			}

			// Token: 0x17002E2F RID: 11823
			// (get) Token: 0x0600F009 RID: 61449 RVA: 0x003FF44C File Offset: 0x003FD64C
			// (set) Token: 0x0600F00A RID: 61450 RVA: 0x003FF45C File Offset: 0x003FD65C
			public GameObject m_guildItem
			{
				get
				{
					return this.m_owner.m_guildItem;
				}
				set
				{
					this.m_owner.m_guildItem = value;
				}
			}

			// Token: 0x17002E30 RID: 11824
			// (get) Token: 0x0600F00B RID: 61451 RVA: 0x003FF46C File Offset: 0x003FD66C
			// (set) Token: 0x0600F00C RID: 61452 RVA: 0x003FF47C File Offset: 0x003FD67C
			public InputField m_guildNameInputField
			{
				get
				{
					return this.m_owner.m_guildNameInputField;
				}
				set
				{
					this.m_owner.m_guildNameInputField = value;
				}
			}

			// Token: 0x17002E31 RID: 11825
			// (get) Token: 0x0600F00D RID: 61453 RVA: 0x003FF48C File Offset: 0x003FD68C
			// (set) Token: 0x0600F00E RID: 61454 RVA: 0x003FF49C File Offset: 0x003FD69C
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

			// Token: 0x17002E32 RID: 11826
			// (get) Token: 0x0600F00F RID: 61455 RVA: 0x003FF4AC File Offset: 0x003FD6AC
			// (set) Token: 0x0600F010 RID: 61456 RVA: 0x003FF4BC File Offset: 0x003FD6BC
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

			// Token: 0x17002E33 RID: 11827
			// (get) Token: 0x0600F011 RID: 61457 RVA: 0x003FF4CC File Offset: 0x003FD6CC
			// (set) Token: 0x0600F012 RID: 61458 RVA: 0x003FF4DC File Offset: 0x003FD6DC
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

			// Token: 0x17002E34 RID: 11828
			// (get) Token: 0x0600F013 RID: 61459 RVA: 0x003FF4EC File Offset: 0x003FD6EC
			// (set) Token: 0x0600F014 RID: 61460 RVA: 0x003FF4FC File Offset: 0x003FD6FC
			public List<GuildSearchInfo> m_guildSearchInfoList
			{
				get
				{
					return this.m_owner.m_guildSearchInfoList;
				}
				set
				{
					this.m_owner.m_guildSearchInfoList = value;
				}
			}

			// Token: 0x17002E35 RID: 11829
			// (get) Token: 0x0600F015 RID: 61461 RVA: 0x003FF50C File Offset: 0x003FD70C
			// (set) Token: 0x0600F016 RID: 61462 RVA: 0x003FF51C File Offset: 0x003FD71C
			public List<GuildSearchInfo> m_guildRecommendInfoList
			{
				get
				{
					return this.m_owner.m_guildRecommendInfoList;
				}
				set
				{
					this.m_owner.m_guildRecommendInfoList = value;
				}
			}

			// Token: 0x17002E36 RID: 11830
			// (get) Token: 0x0600F017 RID: 61463 RVA: 0x003FF52C File Offset: 0x003FD72C
			// (set) Token: 0x0600F018 RID: 61464 RVA: 0x003FF53C File Offset: 0x003FD73C
			public List<GuildSearchInfo> m_showGuildInfoList
			{
				get
				{
					return this.m_owner.m_showGuildInfoList;
				}
				set
				{
					this.m_owner.m_showGuildInfoList = value;
				}
			}

			// Token: 0x17002E37 RID: 11831
			// (get) Token: 0x0600F019 RID: 61465 RVA: 0x003FF54C File Offset: 0x003FD74C
			// (set) Token: 0x0600F01A RID: 61466 RVA: 0x003FF55C File Offset: 0x003FD75C
			public List<BeforeJoinSingleGuildUIController> m_guildInfoUIController
			{
				get
				{
					return this.m_owner.m_guildInfoUIController;
				}
				set
				{
					this.m_owner.m_guildInfoUIController = value;
				}
			}

			// Token: 0x17002E38 RID: 11832
			// (get) Token: 0x0600F01B RID: 61467 RVA: 0x003FF56C File Offset: 0x003FD76C
			// (set) Token: 0x0600F01C RID: 61468 RVA: 0x003FF57C File Offset: 0x003FD77C
			public BeforeJoinSingleGuildUIController m_selectGuildItemUIController
			{
				get
				{
					return this.m_owner.m_selectGuildItemUIController;
				}
				set
				{
					this.m_owner.m_selectGuildItemUIController = value;
				}
			}

			// Token: 0x0600F01D RID: 61469 RVA: 0x003FF58C File Offset: 0x003FD78C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F01E RID: 61470 RVA: 0x003FF59C File Offset: 0x003FD79C
			public void GetRandomGuildList(Action<int> OnReqFinish)
			{
				this.m_owner.GetRandomGuildList(OnReqFinish);
			}

			// Token: 0x0600F01F RID: 61471 RVA: 0x003FF5AC File Offset: 0x003FD7AC
			public void SetGuildItemSelect(BeforeJoinSingleGuildUIController guildItemUIController)
			{
				this.m_owner.SetGuildItemSelect(guildItemUIController);
			}

			// Token: 0x0600F020 RID: 61472 RVA: 0x003FF5BC File Offset: 0x003FD7BC
			public void OnCreateGuildClick()
			{
				this.m_owner.OnCreateGuildClick();
			}

			// Token: 0x0600F021 RID: 61473 RVA: 0x003FF5CC File Offset: 0x003FD7CC
			public void OnChangeGuildClick()
			{
				this.m_owner.OnChangeGuildClick();
			}

			// Token: 0x0600F022 RID: 61474 RVA: 0x003FF5DC File Offset: 0x003FD7DC
			public void OnSearchClick()
			{
				this.m_owner.OnSearchClick();
			}

			// Token: 0x0600F023 RID: 61475 RVA: 0x003FF5EC File Offset: 0x003FD7EC
			public void OnDeleteSearchClick()
			{
				this.m_owner.OnDeleteSearchClick();
			}

			// Token: 0x0600F024 RID: 61476 RVA: 0x003FF5FC File Offset: 0x003FD7FC
			public void OnGuildItemClick(BeforeJoinSingleGuildUIController guildItemUIController)
			{
				this.m_owner.OnGuildItemClick(guildItemUIController);
			}

			// Token: 0x04008EFB RID: 36603
			private BeforeJoinGuildListUIController m_owner;
		}
	}
}
