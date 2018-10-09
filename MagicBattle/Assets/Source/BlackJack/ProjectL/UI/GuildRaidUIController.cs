using System;
using System.Collections.Generic;
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
	// Token: 0x02000D40 RID: 3392
	[HotFix]
	public class GuildRaidUIController : UIControllerBase
	{
		// Token: 0x0600F8B8 RID: 63672 RVA: 0x004191F8 File Offset: 0x004173F8
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

		// Token: 0x0600F8B9 RID: 63673 RVA: 0x004192B0 File Offset: 0x004174B0
		public void GuildRaidUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildRaidUpdateView_hotfix != null)
			{
				this.m_GuildRaidUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_configDataLoader.ConfigableConstId_GuildMassiveCombatAvailableCountPerWeek - this.m_playerContext.GetFinishedGuildMassiveCombatThisWeek();
			this.m_timesText.text = num + "/" + this.m_configDataLoader.ConfigableConstId_GuildMassiveCombatAvailableCountPerWeek;
			List<ConfigDataGuildMassiveCombatDifficultyInfo> list = new List<ConfigDataGuildMassiveCombatDifficultyInfo>();
			foreach (KeyValuePair<int, ConfigDataGuildMassiveCombatDifficultyInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataGuildMassiveCombatDifficultyInfo())
			{
				list.Add(keyValuePair.Value);
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_scrollViewContent, list.Count);
			Transform transform = this.m_scrollViewContent.transform;
			for (int i = 0; i < list.Count; i++)
			{
				GuildRaidListItemUIController guildRaidListItemUIController;
				if (i < transform.childCount)
				{
					Transform child = transform.GetChild(i);
					guildRaidListItemUIController = child.GetComponent<GuildRaidListItemUIController>();
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_levelListItemPrefab);
					guildRaidListItemUIController = GameObjectUtility.AddControllerToGameObject<GuildRaidListItemUIController>(gameObject);
					guildRaidListItemUIController.EventOnStartButtonClick += this.OnGuildRaidListItemStartButtonClick;
					gameObject.transform.SetParent(transform, false);
				}
				ConfigDataGuildMassiveCombatDifficultyInfo info = list[i];
				guildRaidListItemUIController.InitGuildRaidListItemInfo(info);
			}
			this.m_scrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x0600F8BA RID: 63674 RVA: 0x0041946C File Offset: 0x0041766C
		private void OnGuildRaidListItemStartButtonClick(GuildRaidListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildRaidListItemStartButtonClickGuildRaidListItemUIController_hotfix != null)
			{
				this.m_OnGuildRaidListItemStartButtonClickGuildRaidListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGuildRaidListItemClick != null)
			{
				this.EventOnGuildRaidListItemClick(ctrl.GuildMassiveCombatDifficultyInfo);
			}
		}

		// Token: 0x0600F8BB RID: 63675 RVA: 0x004194F8 File Offset: 0x004176F8
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

		// Token: 0x0600F8BC RID: 63676 RVA: 0x00419570 File Offset: 0x00417770
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
			UIUtility.SetUIStateOpen(this.m_stateCtrl, "Show", null, true, true);
		}

		// Token: 0x0600F8BD RID: 63677 RVA: 0x004195E4 File Offset: 0x004177E4
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

		// Token: 0x14000347 RID: 839
		// (add) Token: 0x0600F8BE RID: 63678 RVA: 0x00419644 File Offset: 0x00417844
		// (remove) Token: 0x0600F8BF RID: 63679 RVA: 0x004196E0 File Offset: 0x004178E0
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

		// Token: 0x14000348 RID: 840
		// (add) Token: 0x0600F8C0 RID: 63680 RVA: 0x0041977C File Offset: 0x0041797C
		// (remove) Token: 0x0600F8C1 RID: 63681 RVA: 0x00419818 File Offset: 0x00417A18
		public event Action<ConfigDataGuildMassiveCombatDifficultyInfo> EventOnGuildRaidListItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGuildRaidListItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGuildRaidListItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataGuildMassiveCombatDifficultyInfo> action = this.EventOnGuildRaidListItemClick;
				Action<ConfigDataGuildMassiveCombatDifficultyInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataGuildMassiveCombatDifficultyInfo>>(ref this.EventOnGuildRaidListItemClick, (Action<ConfigDataGuildMassiveCombatDifficultyInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGuildRaidListItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGuildRaidListItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataGuildMassiveCombatDifficultyInfo> action = this.EventOnGuildRaidListItemClick;
				Action<ConfigDataGuildMassiveCombatDifficultyInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataGuildMassiveCombatDifficultyInfo>>(ref this.EventOnGuildRaidListItemClick, (Action<ConfigDataGuildMassiveCombatDifficultyInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x0600F8C2 RID: 63682 RVA: 0x004198B4 File Offset: 0x00417AB4
		// (set) Token: 0x0600F8C3 RID: 63683 RVA: 0x004198D4 File Offset: 0x00417AD4
		[DoNotToLua]
		public new GuildRaidUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildRaidUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F8C4 RID: 63684 RVA: 0x004198E0 File Offset: 0x00417AE0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F8C5 RID: 63685 RVA: 0x004198EC File Offset: 0x00417AEC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F8C6 RID: 63686 RVA: 0x004198F4 File Offset: 0x00417AF4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F8C7 RID: 63687 RVA: 0x004198FC File Offset: 0x00417AFC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F8C8 RID: 63688 RVA: 0x00419910 File Offset: 0x00417B10
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F8C9 RID: 63689 RVA: 0x00419918 File Offset: 0x00417B18
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F8CA RID: 63690 RVA: 0x00419924 File Offset: 0x00417B24
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F8CB RID: 63691 RVA: 0x00419930 File Offset: 0x00417B30
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F8CC RID: 63692 RVA: 0x0041993C File Offset: 0x00417B3C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F8CD RID: 63693 RVA: 0x00419948 File Offset: 0x00417B48
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F8CE RID: 63694 RVA: 0x00419954 File Offset: 0x00417B54
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F8CF RID: 63695 RVA: 0x00419960 File Offset: 0x00417B60
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F8D0 RID: 63696 RVA: 0x0041996C File Offset: 0x00417B6C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F8D1 RID: 63697 RVA: 0x00419978 File Offset: 0x00417B78
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F8D2 RID: 63698 RVA: 0x00419984 File Offset: 0x00417B84
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F8D3 RID: 63699 RVA: 0x0041998C File Offset: 0x00417B8C
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600F8D4 RID: 63700 RVA: 0x004199AC File Offset: 0x00417BAC
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600F8D5 RID: 63701 RVA: 0x004199B8 File Offset: 0x00417BB8
		private void __callDele_EventOnGuildRaidListItemClick(ConfigDataGuildMassiveCombatDifficultyInfo obj)
		{
			Action<ConfigDataGuildMassiveCombatDifficultyInfo> eventOnGuildRaidListItemClick = this.EventOnGuildRaidListItemClick;
			if (eventOnGuildRaidListItemClick != null)
			{
				eventOnGuildRaidListItemClick(obj);
			}
		}

		// Token: 0x0600F8D6 RID: 63702 RVA: 0x004199DC File Offset: 0x00417BDC
		private void __clearDele_EventOnGuildRaidListItemClick(ConfigDataGuildMassiveCombatDifficultyInfo obj)
		{
			this.EventOnGuildRaidListItemClick = null;
		}

		// Token: 0x0600F8D7 RID: 63703 RVA: 0x004199E8 File Offset: 0x00417BE8
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
					this.m_GuildRaidUpdateView_hotfix = (luaObj.RawGet("GuildRaidUpdateView") as LuaFunction);
					this.m_OnGuildRaidListItemStartButtonClickGuildRaidListItemUIController_hotfix = (luaObj.RawGet("OnGuildRaidListItemStartButtonClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnGuildRaidListItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGuildRaidListItemClick") as LuaFunction);
					this.m_remove_EventOnGuildRaidListItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGuildRaidListItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F8D8 RID: 63704 RVA: 0x00419B94 File Offset: 0x00417D94
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildRaidUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400924B RID: 37451
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x0400924C RID: 37452
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400924D RID: 37453
		[AutoBind("./PlayerResource/Times/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timesText;

		// Token: 0x0400924E RID: 37454
		[AutoBind("./LevelList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_scrollRect;

		// Token: 0x0400924F RID: 37455
		[AutoBind("./LevelList/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scrollViewContent;

		// Token: 0x04009250 RID: 37456
		[AutoBind("./Prefabs/LevelListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_levelListItemPrefab;

		// Token: 0x04009253 RID: 37459
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009254 RID: 37460
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009255 RID: 37461
		[DoNotToLua]
		private GuildRaidUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009256 RID: 37462
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009257 RID: 37463
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009258 RID: 37464
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009259 RID: 37465
		private LuaFunction m_GuildRaidUpdateView_hotfix;

		// Token: 0x0400925A RID: 37466
		private LuaFunction m_OnGuildRaidListItemStartButtonClickGuildRaidListItemUIController_hotfix;

		// Token: 0x0400925B RID: 37467
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400925C RID: 37468
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400925D RID: 37469
		private LuaFunction m_Close_hotfix;

		// Token: 0x0400925E RID: 37470
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400925F RID: 37471
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04009260 RID: 37472
		private LuaFunction m_add_EventOnGuildRaidListItemClickAction;

		// Token: 0x04009261 RID: 37473
		private LuaFunction m_remove_EventOnGuildRaidListItemClickAction;

		// Token: 0x02000D41 RID: 3393
		public new class LuaExportHelper
		{
			// Token: 0x0600F8D9 RID: 63705 RVA: 0x00419BFC File Offset: 0x00417DFC
			public LuaExportHelper(GuildRaidUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F8DA RID: 63706 RVA: 0x00419C0C File Offset: 0x00417E0C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F8DB RID: 63707 RVA: 0x00419C1C File Offset: 0x00417E1C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F8DC RID: 63708 RVA: 0x00419C2C File Offset: 0x00417E2C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F8DD RID: 63709 RVA: 0x00419C3C File Offset: 0x00417E3C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F8DE RID: 63710 RVA: 0x00419C54 File Offset: 0x00417E54
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F8DF RID: 63711 RVA: 0x00419C64 File Offset: 0x00417E64
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F8E0 RID: 63712 RVA: 0x00419C74 File Offset: 0x00417E74
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F8E1 RID: 63713 RVA: 0x00419C84 File Offset: 0x00417E84
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F8E2 RID: 63714 RVA: 0x00419C94 File Offset: 0x00417E94
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F8E3 RID: 63715 RVA: 0x00419CA4 File Offset: 0x00417EA4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F8E4 RID: 63716 RVA: 0x00419CB4 File Offset: 0x00417EB4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F8E5 RID: 63717 RVA: 0x00419CC4 File Offset: 0x00417EC4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F8E6 RID: 63718 RVA: 0x00419CD4 File Offset: 0x00417ED4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F8E7 RID: 63719 RVA: 0x00419CE4 File Offset: 0x00417EE4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F8E8 RID: 63720 RVA: 0x00419CF4 File Offset: 0x00417EF4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F8E9 RID: 63721 RVA: 0x00419D04 File Offset: 0x00417F04
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600F8EA RID: 63722 RVA: 0x00419D14 File Offset: 0x00417F14
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600F8EB RID: 63723 RVA: 0x00419D24 File Offset: 0x00417F24
			public void __callDele_EventOnGuildRaidListItemClick(ConfigDataGuildMassiveCombatDifficultyInfo obj)
			{
				this.m_owner.__callDele_EventOnGuildRaidListItemClick(obj);
			}

			// Token: 0x0600F8EC RID: 63724 RVA: 0x00419D34 File Offset: 0x00417F34
			public void __clearDele_EventOnGuildRaidListItemClick(ConfigDataGuildMassiveCombatDifficultyInfo obj)
			{
				this.m_owner.__clearDele_EventOnGuildRaidListItemClick(obj);
			}

			// Token: 0x17002F88 RID: 12168
			// (get) Token: 0x0600F8ED RID: 63725 RVA: 0x00419D44 File Offset: 0x00417F44
			// (set) Token: 0x0600F8EE RID: 63726 RVA: 0x00419D54 File Offset: 0x00417F54
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

			// Token: 0x17002F89 RID: 12169
			// (get) Token: 0x0600F8EF RID: 63727 RVA: 0x00419D64 File Offset: 0x00417F64
			// (set) Token: 0x0600F8F0 RID: 63728 RVA: 0x00419D74 File Offset: 0x00417F74
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

			// Token: 0x17002F8A RID: 12170
			// (get) Token: 0x0600F8F1 RID: 63729 RVA: 0x00419D84 File Offset: 0x00417F84
			// (set) Token: 0x0600F8F2 RID: 63730 RVA: 0x00419D94 File Offset: 0x00417F94
			public Text m_timesText
			{
				get
				{
					return this.m_owner.m_timesText;
				}
				set
				{
					this.m_owner.m_timesText = value;
				}
			}

			// Token: 0x17002F8B RID: 12171
			// (get) Token: 0x0600F8F3 RID: 63731 RVA: 0x00419DA4 File Offset: 0x00417FA4
			// (set) Token: 0x0600F8F4 RID: 63732 RVA: 0x00419DB4 File Offset: 0x00417FB4
			public ScrollRect m_scrollRect
			{
				get
				{
					return this.m_owner.m_scrollRect;
				}
				set
				{
					this.m_owner.m_scrollRect = value;
				}
			}

			// Token: 0x17002F8C RID: 12172
			// (get) Token: 0x0600F8F5 RID: 63733 RVA: 0x00419DC4 File Offset: 0x00417FC4
			// (set) Token: 0x0600F8F6 RID: 63734 RVA: 0x00419DD4 File Offset: 0x00417FD4
			public GameObject m_scrollViewContent
			{
				get
				{
					return this.m_owner.m_scrollViewContent;
				}
				set
				{
					this.m_owner.m_scrollViewContent = value;
				}
			}

			// Token: 0x17002F8D RID: 12173
			// (get) Token: 0x0600F8F7 RID: 63735 RVA: 0x00419DE4 File Offset: 0x00417FE4
			// (set) Token: 0x0600F8F8 RID: 63736 RVA: 0x00419DF4 File Offset: 0x00417FF4
			public GameObject m_levelListItemPrefab
			{
				get
				{
					return this.m_owner.m_levelListItemPrefab;
				}
				set
				{
					this.m_owner.m_levelListItemPrefab = value;
				}
			}

			// Token: 0x17002F8E RID: 12174
			// (get) Token: 0x0600F8F9 RID: 63737 RVA: 0x00419E04 File Offset: 0x00418004
			// (set) Token: 0x0600F8FA RID: 63738 RVA: 0x00419E14 File Offset: 0x00418014
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

			// Token: 0x17002F8F RID: 12175
			// (get) Token: 0x0600F8FB RID: 63739 RVA: 0x00419E24 File Offset: 0x00418024
			// (set) Token: 0x0600F8FC RID: 63740 RVA: 0x00419E34 File Offset: 0x00418034
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

			// Token: 0x0600F8FD RID: 63741 RVA: 0x00419E44 File Offset: 0x00418044
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F8FE RID: 63742 RVA: 0x00419E54 File Offset: 0x00418054
			public void OnGuildRaidListItemStartButtonClick(GuildRaidListItemUIController ctrl)
			{
				this.m_owner.OnGuildRaidListItemStartButtonClick(ctrl);
			}

			// Token: 0x0600F8FF RID: 63743 RVA: 0x00419E64 File Offset: 0x00418064
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x04009262 RID: 37474
			private GuildRaidUIController m_owner;
		}
	}
}
