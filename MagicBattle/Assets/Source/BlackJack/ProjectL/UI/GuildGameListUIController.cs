using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
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
	// Token: 0x02000CEB RID: 3307
	[HotFix]
	public class GuildGameListUIController : UIControllerBase
	{
		// Token: 0x0600F1C8 RID: 61896 RVA: 0x00403C0C File Offset: 0x00401E0C
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
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x0600F1C9 RID: 61897 RVA: 0x00403CC4 File Offset: 0x00401EC4
		public void GuildGameListUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildGameListUpdateView_hotfix != null)
			{
				this.m_GuildGameListUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetGuildPlayListPanel();
		}

		// Token: 0x0600F1CA RID: 61898 RVA: 0x00403D2C File Offset: 0x00401F2C
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_guildRaidListPanelStateCtrl, "Show", null, true, true);
		}

		// Token: 0x0600F1CB RID: 61899 RVA: 0x00403DA0 File Offset: 0x00401FA0
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600F1CC RID: 61900 RVA: 0x00403E00 File Offset: 0x00402000
		private void SetGuildPlayListPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGuildPlayListPanel_hotfix != null)
			{
				this.m_SetGuildPlayListPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 1;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_guildRaidListScrollViewContent, num);
			Transform transform = this.m_guildRaidListScrollViewContent.transform;
			for (int i = 0; i < num; i++)
			{
				GuildGameListItemUIController guildGameListItemUIController;
				if (i < transform.childCount)
				{
					Transform child = transform.GetChild(i);
					guildGameListItemUIController = child.GetComponent<GuildGameListItemUIController>();
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_guildRaidListItemPrefab);
					guildGameListItemUIController = GameObjectUtility.AddControllerToGameObject<GuildGameListItemUIController>(gameObject);
					guildGameListItemUIController.EventOnClick += this.OnGuildPlayListItemClick;
					gameObject.transform.SetParent(transform, false);
				}
				guildGameListItemUIController.InitGuildGameListItemInfo();
			}
			this.m_guildRaidListScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x0600F1CD RID: 61901 RVA: 0x00403EFC File Offset: 0x004020FC
		private void OnGuildPlayListItemClick(GuildGameListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildPlayListItemClickGuildGameListItemUIController_hotfix != null)
			{
				this.m_OnGuildPlayListItemClickGuildGameListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGuildPlayListItemClick != null)
			{
				this.EventOnGuildPlayListItemClick();
			}
		}

		// Token: 0x0600F1CE RID: 61902 RVA: 0x00403F84 File Offset: 0x00402184
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x1400032C RID: 812
		// (add) Token: 0x0600F1CF RID: 61903 RVA: 0x00403FFC File Offset: 0x004021FC
		// (remove) Token: 0x0600F1D0 RID: 61904 RVA: 0x00404098 File Offset: 0x00402298
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400032D RID: 813
		// (add) Token: 0x0600F1D1 RID: 61905 RVA: 0x00404134 File Offset: 0x00402334
		// (remove) Token: 0x0600F1D2 RID: 61906 RVA: 0x004041D0 File Offset: 0x004023D0
		public event Action EventOnGuildPlayListItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGuildPlayListItemClickAction_hotfix != null)
				{
					this.m_add_EventOnGuildPlayListItemClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGuildPlayListItemClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGuildPlayListItemClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGuildPlayListItemClickAction_hotfix != null)
				{
					this.m_remove_EventOnGuildPlayListItemClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGuildPlayListItemClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGuildPlayListItemClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0600F1D3 RID: 61907 RVA: 0x0040426C File Offset: 0x0040246C
		// (set) Token: 0x0600F1D4 RID: 61908 RVA: 0x0040428C File Offset: 0x0040248C
		[DoNotToLua]
		public new GuildGameListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildGameListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F1D5 RID: 61909 RVA: 0x00404298 File Offset: 0x00402498
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F1D6 RID: 61910 RVA: 0x004042A4 File Offset: 0x004024A4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F1D7 RID: 61911 RVA: 0x004042AC File Offset: 0x004024AC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F1D8 RID: 61912 RVA: 0x004042B4 File Offset: 0x004024B4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F1D9 RID: 61913 RVA: 0x004042C8 File Offset: 0x004024C8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F1DA RID: 61914 RVA: 0x004042D0 File Offset: 0x004024D0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F1DB RID: 61915 RVA: 0x004042DC File Offset: 0x004024DC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F1DC RID: 61916 RVA: 0x004042E8 File Offset: 0x004024E8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F1DD RID: 61917 RVA: 0x004042F4 File Offset: 0x004024F4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F1DE RID: 61918 RVA: 0x00404300 File Offset: 0x00402500
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F1DF RID: 61919 RVA: 0x0040430C File Offset: 0x0040250C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F1E0 RID: 61920 RVA: 0x00404318 File Offset: 0x00402518
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F1E1 RID: 61921 RVA: 0x00404324 File Offset: 0x00402524
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F1E2 RID: 61922 RVA: 0x00404330 File Offset: 0x00402530
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F1E3 RID: 61923 RVA: 0x0040433C File Offset: 0x0040253C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F1E4 RID: 61924 RVA: 0x00404344 File Offset: 0x00402544
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600F1E5 RID: 61925 RVA: 0x00404364 File Offset: 0x00402564
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600F1E6 RID: 61926 RVA: 0x00404370 File Offset: 0x00402570
		private void __callDele_EventOnGuildPlayListItemClick()
		{
			Action eventOnGuildPlayListItemClick = this.EventOnGuildPlayListItemClick;
			if (eventOnGuildPlayListItemClick != null)
			{
				eventOnGuildPlayListItemClick();
			}
		}

		// Token: 0x0600F1E7 RID: 61927 RVA: 0x00404390 File Offset: 0x00402590
		private void __clearDele_EventOnGuildPlayListItemClick()
		{
			this.EventOnGuildPlayListItemClick = null;
		}

		// Token: 0x0600F1E8 RID: 61928 RVA: 0x0040439C File Offset: 0x0040259C
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
					this.m_GuildGameListUpdateView_hotfix = (luaObj.RawGet("GuildGameListUpdateView") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_SetGuildPlayListPanel_hotfix = (luaObj.RawGet("SetGuildPlayListPanel") as LuaFunction);
					this.m_OnGuildPlayListItemClickGuildGameListItemUIController_hotfix = (luaObj.RawGet("OnGuildPlayListItemClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnGuildPlayListItemClickAction_hotfix = (luaObj.RawGet("add_EventOnGuildPlayListItemClick") as LuaFunction);
					this.m_remove_EventOnGuildPlayListItemClickAction_hotfix = (luaObj.RawGet("remove_EventOnGuildPlayListItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F1E9 RID: 61929 RVA: 0x00404564 File Offset: 0x00402764
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildGameListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008FA4 RID: 36772
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_guildRaidListPanelStateCtrl;

		// Token: 0x04008FA5 RID: 36773
		[AutoBind("./Detail/RaidListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_guildRaidListScrollRect;

		// Token: 0x04008FA6 RID: 36774
		[AutoBind("./Detail/RaidListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_guildRaidListScrollViewContent;

		// Token: 0x04008FA7 RID: 36775
		[AutoBind("./Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04008FA8 RID: 36776
		[AutoBind("./Prefab/GuildRaidListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_guildRaidListItemPrefab;

		// Token: 0x04008FAB RID: 36779
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008FAC RID: 36780
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008FAD RID: 36781
		[DoNotToLua]
		private GuildGameListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008FAE RID: 36782
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008FAF RID: 36783
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008FB0 RID: 36784
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008FB1 RID: 36785
		private LuaFunction m_GuildGameListUpdateView_hotfix;

		// Token: 0x04008FB2 RID: 36786
		private LuaFunction m_Open_hotfix;

		// Token: 0x04008FB3 RID: 36787
		private LuaFunction m_Close_hotfix;

		// Token: 0x04008FB4 RID: 36788
		private LuaFunction m_SetGuildPlayListPanel_hotfix;

		// Token: 0x04008FB5 RID: 36789
		private LuaFunction m_OnGuildPlayListItemClickGuildGameListItemUIController_hotfix;

		// Token: 0x04008FB6 RID: 36790
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04008FB7 RID: 36791
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04008FB8 RID: 36792
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04008FB9 RID: 36793
		private LuaFunction m_add_EventOnGuildPlayListItemClickAction_hotfix;

		// Token: 0x04008FBA RID: 36794
		private LuaFunction m_remove_EventOnGuildPlayListItemClickAction_hotfix;

		// Token: 0x02000CEC RID: 3308
		public new class LuaExportHelper
		{
			// Token: 0x0600F1EA RID: 61930 RVA: 0x004045CC File Offset: 0x004027CC
			public LuaExportHelper(GuildGameListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F1EB RID: 61931 RVA: 0x004045DC File Offset: 0x004027DC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F1EC RID: 61932 RVA: 0x004045EC File Offset: 0x004027EC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F1ED RID: 61933 RVA: 0x004045FC File Offset: 0x004027FC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F1EE RID: 61934 RVA: 0x0040460C File Offset: 0x0040280C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F1EF RID: 61935 RVA: 0x00404624 File Offset: 0x00402824
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F1F0 RID: 61936 RVA: 0x00404634 File Offset: 0x00402834
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F1F1 RID: 61937 RVA: 0x00404644 File Offset: 0x00402844
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F1F2 RID: 61938 RVA: 0x00404654 File Offset: 0x00402854
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F1F3 RID: 61939 RVA: 0x00404664 File Offset: 0x00402864
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F1F4 RID: 61940 RVA: 0x00404674 File Offset: 0x00402874
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F1F5 RID: 61941 RVA: 0x00404684 File Offset: 0x00402884
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F1F6 RID: 61942 RVA: 0x00404694 File Offset: 0x00402894
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F1F7 RID: 61943 RVA: 0x004046A4 File Offset: 0x004028A4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F1F8 RID: 61944 RVA: 0x004046B4 File Offset: 0x004028B4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F1F9 RID: 61945 RVA: 0x004046C4 File Offset: 0x004028C4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F1FA RID: 61946 RVA: 0x004046D4 File Offset: 0x004028D4
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600F1FB RID: 61947 RVA: 0x004046E4 File Offset: 0x004028E4
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600F1FC RID: 61948 RVA: 0x004046F4 File Offset: 0x004028F4
			public void __callDele_EventOnGuildPlayListItemClick()
			{
				this.m_owner.__callDele_EventOnGuildPlayListItemClick();
			}

			// Token: 0x0600F1FD RID: 61949 RVA: 0x00404704 File Offset: 0x00402904
			public void __clearDele_EventOnGuildPlayListItemClick()
			{
				this.m_owner.__clearDele_EventOnGuildPlayListItemClick();
			}

			// Token: 0x17002E7B RID: 11899
			// (get) Token: 0x0600F1FE RID: 61950 RVA: 0x00404714 File Offset: 0x00402914
			// (set) Token: 0x0600F1FF RID: 61951 RVA: 0x00404724 File Offset: 0x00402924
			public CommonUIStateController m_guildRaidListPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_guildRaidListPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_guildRaidListPanelStateCtrl = value;
				}
			}

			// Token: 0x17002E7C RID: 11900
			// (get) Token: 0x0600F200 RID: 61952 RVA: 0x00404734 File Offset: 0x00402934
			// (set) Token: 0x0600F201 RID: 61953 RVA: 0x00404744 File Offset: 0x00402944
			public ScrollRect m_guildRaidListScrollRect
			{
				get
				{
					return this.m_owner.m_guildRaidListScrollRect;
				}
				set
				{
					this.m_owner.m_guildRaidListScrollRect = value;
				}
			}

			// Token: 0x17002E7D RID: 11901
			// (get) Token: 0x0600F202 RID: 61954 RVA: 0x00404754 File Offset: 0x00402954
			// (set) Token: 0x0600F203 RID: 61955 RVA: 0x00404764 File Offset: 0x00402964
			public GameObject m_guildRaidListScrollViewContent
			{
				get
				{
					return this.m_owner.m_guildRaidListScrollViewContent;
				}
				set
				{
					this.m_owner.m_guildRaidListScrollViewContent = value;
				}
			}

			// Token: 0x17002E7E RID: 11902
			// (get) Token: 0x0600F204 RID: 61956 RVA: 0x00404774 File Offset: 0x00402974
			// (set) Token: 0x0600F205 RID: 61957 RVA: 0x00404784 File Offset: 0x00402984
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

			// Token: 0x17002E7F RID: 11903
			// (get) Token: 0x0600F206 RID: 61958 RVA: 0x00404794 File Offset: 0x00402994
			// (set) Token: 0x0600F207 RID: 61959 RVA: 0x004047A4 File Offset: 0x004029A4
			public GameObject m_guildRaidListItemPrefab
			{
				get
				{
					return this.m_owner.m_guildRaidListItemPrefab;
				}
				set
				{
					this.m_owner.m_guildRaidListItemPrefab = value;
				}
			}

			// Token: 0x17002E80 RID: 11904
			// (get) Token: 0x0600F208 RID: 61960 RVA: 0x004047B4 File Offset: 0x004029B4
			// (set) Token: 0x0600F209 RID: 61961 RVA: 0x004047C4 File Offset: 0x004029C4
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

			// Token: 0x17002E81 RID: 11905
			// (get) Token: 0x0600F20A RID: 61962 RVA: 0x004047D4 File Offset: 0x004029D4
			// (set) Token: 0x0600F20B RID: 61963 RVA: 0x004047E4 File Offset: 0x004029E4
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

			// Token: 0x0600F20C RID: 61964 RVA: 0x004047F4 File Offset: 0x004029F4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F20D RID: 61965 RVA: 0x00404804 File Offset: 0x00402A04
			public void SetGuildPlayListPanel()
			{
				this.m_owner.SetGuildPlayListPanel();
			}

			// Token: 0x0600F20E RID: 61966 RVA: 0x00404814 File Offset: 0x00402A14
			public void OnGuildPlayListItemClick(GuildGameListItemUIController ctrl)
			{
				this.m_owner.OnGuildPlayListItemClick(ctrl);
			}

			// Token: 0x0600F20F RID: 61967 RVA: 0x00404824 File Offset: 0x00402A24
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x04008FBB RID: 36795
			private GuildGameListUIController m_owner;
		}
	}
}
