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
	// Token: 0x02000C11 RID: 3089
	[HotFix]
	public class CooperateBattleUIController : UIControllerBase
	{
		// Token: 0x0600D8BD RID: 55485 RVA: 0x003AE5E0 File Offset: 0x003AC7E0
		private CooperateBattleUIController()
		{
		}

		// Token: 0x0600D8BE RID: 55486 RVA: 0x003AE5F4 File Offset: 0x003AC7F4
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
			this.m_helpButton.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_teamButton.onClick.AddListener(new UnityAction(this.OnTeamButtonClick));
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600D8BF RID: 55487 RVA: 0x003AE6BC File Offset: 0x003AC8BC
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
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x0600D8C0 RID: 55488 RVA: 0x003AE730 File Offset: 0x003AC930
		public void SetCooperateBattle(ConfigDataCooperateBattleInfo cooperateBattleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCooperateBattleConfigDataCooperateBattleInfo_hotfix != null)
			{
				this.m_SetCooperateBattleConfigDataCooperateBattleInfo_hotfix.call(new object[]
				{
					this,
					cooperateBattleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chapterNameText.text = cooperateBattleInfo.Name;
			this.m_chapterDescText.text = cooperateBattleInfo.Desc;
			this.m_chapterImage.sprite = AssetUtility.Instance.GetSprite(cooperateBattleInfo.BriefView);
		}

		// Token: 0x0600D8C1 RID: 55489 RVA: 0x003AE7E0 File Offset: 0x003AC9E0
		public void AddAllCooperateBattleLevelListItems(List<ConfigDataCooperateBattleLevelInfo> levelInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddAllCooperateBattleLevelListItemsList`1_hotfix != null)
			{
				this.m_AddAllCooperateBattleLevelListItemsList`1_hotfix.call(new object[]
				{
					this,
					levelInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo in levelInfos)
			{
				this.AddCooperateBattleLevelListItem(configDataCooperateBattleLevelInfo, projectLPlayerContext.IsCooperateBattleLevelOpened(configDataCooperateBattleLevelInfo.ID));
			}
		}

		// Token: 0x0600D8C2 RID: 55490 RVA: 0x003AE8B8 File Offset: 0x003ACAB8
		private void AddCooperateBattleLevelListItem(ConfigDataCooperateBattleLevelInfo levelnfo, bool opened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddCooperateBattleLevelListItemConfigDataCooperateBattleLevelInfoBoolean_hotfix != null)
			{
				this.m_AddCooperateBattleLevelListItemConfigDataCooperateBattleLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelnfo,
					opened
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_CooperateBattleLevelListItemPrefab, this.m_levelListScrollRect.content, false);
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = GameObjectUtility.AddControllerToGameObject<CooperateBattleLevelListItemUIController>(go);
			cooperateBattleLevelListItemUIController.SetCooperateBattleLevelInfo(levelnfo);
			cooperateBattleLevelListItemUIController.SetLocked(!opened);
			cooperateBattleLevelListItemUIController.EventOnStartButtonClick += this.CooperateBattleLevelListItem_OnStartButtonClick;
			this.m_CooperateBattleLevelListItems.Add(cooperateBattleLevelListItemUIController);
		}

		// Token: 0x0600D8C3 RID: 55491 RVA: 0x003AE988 File Offset: 0x003ACB88
		public void ClearCooperateBattleLevelListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearCooperateBattleLevelListItems_hotfix != null)
			{
				this.m_ClearCooperateBattleLevelListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<CooperateBattleLevelListItemUIController>(this.m_CooperateBattleLevelListItems);
			this.m_CooperateBattleLevelListItems.Clear();
		}

		// Token: 0x0600D8C4 RID: 55492 RVA: 0x003AEA00 File Offset: 0x003ACC00
		public void SetDailyRewardCount(int restCount, int allCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDailyRewardCountInt32Int32_hotfix != null)
			{
				this.m_SetDailyRewardCountInt32Int32_hotfix.call(new object[]
				{
					this,
					restCount,
					allCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetDailyRewardCount(this.m_dailyRewardCountText, restCount, allCount);
		}

		// Token: 0x0600D8C5 RID: 55493 RVA: 0x003AEA90 File Offset: 0x003ACC90
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

		// Token: 0x0600D8C6 RID: 55494 RVA: 0x003AEB08 File Offset: 0x003ACD08
		private void OnHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHelpButtonClick_hotfix != null)
			{
				this.m_OnHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelp != null)
			{
				this.EventOnShowHelp();
			}
		}

		// Token: 0x0600D8C7 RID: 55495 RVA: 0x003AEB80 File Offset: 0x003ACD80
		private void OnAddTicketButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddTicketButtonClick_hotfix != null)
			{
				this.m_OnAddTicketButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddTicket != null)
			{
				this.EventOnAddTicket();
			}
		}

		// Token: 0x0600D8C8 RID: 55496 RVA: 0x003AEBF8 File Offset: 0x003ACDF8
		private void OnTeamButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTeamButtonClick_hotfix != null)
			{
				this.m_OnTeamButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowTeam != null)
			{
				this.EventOnShowTeam();
			}
		}

		// Token: 0x0600D8C9 RID: 55497 RVA: 0x003AEC70 File Offset: 0x003ACE70
		private void CooperateBattleLevelListItem_OnStartButtonClick(CooperateBattleLevelListItemUIController b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CooperateBattleLevelListItem_OnStartButtonClickCooperateBattleLevelListItemUIController_hotfix != null)
			{
				this.m_CooperateBattleLevelListItem_OnStartButtonClickCooperateBattleLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartCooperateBattleLevel != null)
			{
				this.EventOnStartCooperateBattleLevel(b.GetCooperateBattleLevelInfo());
			}
		}

		// Token: 0x140002AF RID: 687
		// (add) Token: 0x0600D8CA RID: 55498 RVA: 0x003AECFC File Offset: 0x003ACEFC
		// (remove) Token: 0x0600D8CB RID: 55499 RVA: 0x003AED98 File Offset: 0x003ACF98
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

		// Token: 0x140002B0 RID: 688
		// (add) Token: 0x0600D8CC RID: 55500 RVA: 0x003AEE34 File Offset: 0x003AD034
		// (remove) Token: 0x0600D8CD RID: 55501 RVA: 0x003AEED0 File Offset: 0x003AD0D0
		public event Action EventOnShowHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002B1 RID: 689
		// (add) Token: 0x0600D8CE RID: 55502 RVA: 0x003AEF6C File Offset: 0x003AD16C
		// (remove) Token: 0x0600D8CF RID: 55503 RVA: 0x003AF008 File Offset: 0x003AD208
		public event Action EventOnAddTicket
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddTicketAction_hotfix != null)
				{
					this.m_add_EventOnAddTicketAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddTicket;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddTicket, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddTicketAction_hotfix != null)
				{
					this.m_remove_EventOnAddTicketAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddTicket;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddTicket, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002B2 RID: 690
		// (add) Token: 0x0600D8D0 RID: 55504 RVA: 0x003AF0A4 File Offset: 0x003AD2A4
		// (remove) Token: 0x0600D8D1 RID: 55505 RVA: 0x003AF140 File Offset: 0x003AD340
		public event Action EventOnShowTeam
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowTeamAction_hotfix != null)
				{
					this.m_add_EventOnShowTeamAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowTeam;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowTeam, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowTeamAction_hotfix != null)
				{
					this.m_remove_EventOnShowTeamAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowTeam;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowTeam, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002B3 RID: 691
		// (add) Token: 0x0600D8D2 RID: 55506 RVA: 0x003AF1DC File Offset: 0x003AD3DC
		// (remove) Token: 0x0600D8D3 RID: 55507 RVA: 0x003AF278 File Offset: 0x003AD478
		public event Action<ConfigDataCooperateBattleLevelInfo> EventOnStartCooperateBattleLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartCooperateBattleLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnStartCooperateBattleLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataCooperateBattleLevelInfo> action = this.EventOnStartCooperateBattleLevel;
				Action<ConfigDataCooperateBattleLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataCooperateBattleLevelInfo>>(ref this.EventOnStartCooperateBattleLevel, (Action<ConfigDataCooperateBattleLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartCooperateBattleLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartCooperateBattleLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataCooperateBattleLevelInfo> action = this.EventOnStartCooperateBattleLevel;
				Action<ConfigDataCooperateBattleLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataCooperateBattleLevelInfo>>(ref this.EventOnStartCooperateBattleLevel, (Action<ConfigDataCooperateBattleLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x0600D8D4 RID: 55508 RVA: 0x003AF314 File Offset: 0x003AD514
		// (set) Token: 0x0600D8D5 RID: 55509 RVA: 0x003AF334 File Offset: 0x003AD534
		[DoNotToLua]
		public new CooperateBattleUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CooperateBattleUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D8D6 RID: 55510 RVA: 0x003AF340 File Offset: 0x003AD540
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D8D7 RID: 55511 RVA: 0x003AF34C File Offset: 0x003AD54C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D8D8 RID: 55512 RVA: 0x003AF354 File Offset: 0x003AD554
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D8D9 RID: 55513 RVA: 0x003AF35C File Offset: 0x003AD55C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D8DA RID: 55514 RVA: 0x003AF370 File Offset: 0x003AD570
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D8DB RID: 55515 RVA: 0x003AF378 File Offset: 0x003AD578
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D8DC RID: 55516 RVA: 0x003AF384 File Offset: 0x003AD584
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D8DD RID: 55517 RVA: 0x003AF390 File Offset: 0x003AD590
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D8DE RID: 55518 RVA: 0x003AF39C File Offset: 0x003AD59C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D8DF RID: 55519 RVA: 0x003AF3A8 File Offset: 0x003AD5A8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D8E0 RID: 55520 RVA: 0x003AF3B4 File Offset: 0x003AD5B4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D8E1 RID: 55521 RVA: 0x003AF3C0 File Offset: 0x003AD5C0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D8E2 RID: 55522 RVA: 0x003AF3CC File Offset: 0x003AD5CC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D8E3 RID: 55523 RVA: 0x003AF3D8 File Offset: 0x003AD5D8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D8E4 RID: 55524 RVA: 0x003AF3E4 File Offset: 0x003AD5E4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D8E5 RID: 55525 RVA: 0x003AF3EC File Offset: 0x003AD5EC
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600D8E6 RID: 55526 RVA: 0x003AF40C File Offset: 0x003AD60C
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600D8E7 RID: 55527 RVA: 0x003AF418 File Offset: 0x003AD618
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600D8E8 RID: 55528 RVA: 0x003AF438 File Offset: 0x003AD638
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600D8E9 RID: 55529 RVA: 0x003AF444 File Offset: 0x003AD644
		private void __callDele_EventOnAddTicket()
		{
			Action eventOnAddTicket = this.EventOnAddTicket;
			if (eventOnAddTicket != null)
			{
				eventOnAddTicket();
			}
		}

		// Token: 0x0600D8EA RID: 55530 RVA: 0x003AF464 File Offset: 0x003AD664
		private void __clearDele_EventOnAddTicket()
		{
			this.EventOnAddTicket = null;
		}

		// Token: 0x0600D8EB RID: 55531 RVA: 0x003AF470 File Offset: 0x003AD670
		private void __callDele_EventOnShowTeam()
		{
			Action eventOnShowTeam = this.EventOnShowTeam;
			if (eventOnShowTeam != null)
			{
				eventOnShowTeam();
			}
		}

		// Token: 0x0600D8EC RID: 55532 RVA: 0x003AF490 File Offset: 0x003AD690
		private void __clearDele_EventOnShowTeam()
		{
			this.EventOnShowTeam = null;
		}

		// Token: 0x0600D8ED RID: 55533 RVA: 0x003AF49C File Offset: 0x003AD69C
		private void __callDele_EventOnStartCooperateBattleLevel(ConfigDataCooperateBattleLevelInfo obj)
		{
			Action<ConfigDataCooperateBattleLevelInfo> eventOnStartCooperateBattleLevel = this.EventOnStartCooperateBattleLevel;
			if (eventOnStartCooperateBattleLevel != null)
			{
				eventOnStartCooperateBattleLevel(obj);
			}
		}

		// Token: 0x0600D8EE RID: 55534 RVA: 0x003AF4C0 File Offset: 0x003AD6C0
		private void __clearDele_EventOnStartCooperateBattleLevel(ConfigDataCooperateBattleLevelInfo obj)
		{
			this.EventOnStartCooperateBattleLevel = null;
		}

		// Token: 0x0600D8EF RID: 55535 RVA: 0x003AF4CC File Offset: 0x003AD6CC
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_SetCooperateBattleConfigDataCooperateBattleInfo_hotfix = (luaObj.RawGet("SetCooperateBattle") as LuaFunction);
					this.m_AddAllCooperateBattleLevelListItemsList`1_hotfix = (luaObj.RawGet("AddAllCooperateBattleLevelListItems") as LuaFunction);
					this.m_AddCooperateBattleLevelListItemConfigDataCooperateBattleLevelInfoBoolean_hotfix = (luaObj.RawGet("AddCooperateBattleLevelListItem") as LuaFunction);
					this.m_ClearCooperateBattleLevelListItems_hotfix = (luaObj.RawGet("ClearCooperateBattleLevelListItems") as LuaFunction);
					this.m_SetDailyRewardCountInt32Int32_hotfix = (luaObj.RawGet("SetDailyRewardCount") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnAddTicketButtonClick_hotfix = (luaObj.RawGet("OnAddTicketButtonClick") as LuaFunction);
					this.m_OnTeamButtonClick_hotfix = (luaObj.RawGet("OnTeamButtonClick") as LuaFunction);
					this.m_CooperateBattleLevelListItem_OnStartButtonClickCooperateBattleLevelListItemUIController_hotfix = (luaObj.RawGet("CooperateBattleLevelListItem_OnStartButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnAddTicketAction_hotfix = (luaObj.RawGet("add_EventOnAddTicket") as LuaFunction);
					this.m_remove_EventOnAddTicketAction_hotfix = (luaObj.RawGet("remove_EventOnAddTicket") as LuaFunction);
					this.m_add_EventOnShowTeamAction_hotfix = (luaObj.RawGet("add_EventOnShowTeam") as LuaFunction);
					this.m_remove_EventOnShowTeamAction_hotfix = (luaObj.RawGet("remove_EventOnShowTeam") as LuaFunction);
					this.m_add_EventOnStartCooperateBattleLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnStartCooperateBattleLevel") as LuaFunction);
					this.m_remove_EventOnStartCooperateBattleLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartCooperateBattleLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D8F0 RID: 55536 RVA: 0x003AF7A4 File Offset: 0x003AD9A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CooperateBattleUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008513 RID: 34067
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04008514 RID: 34068
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04008515 RID: 34069
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04008516 RID: 34070
		[AutoBind("./OrganizeTeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_teamButton;

		// Token: 0x04008517 RID: 34071
		[AutoBind("./PlayerResource/DailyReward/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_dailyRewardCountText;

		// Token: 0x04008518 RID: 34072
		[AutoBind("./Chapter/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_chapterNameText;

		// Token: 0x04008519 RID: 34073
		[AutoBind("./Chapter/DetailText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_chapterDescText;

		// Token: 0x0400851A RID: 34074
		[AutoBind("./Chapter/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_chapterImage;

		// Token: 0x0400851B RID: 34075
		[AutoBind("./LevelList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_levelListScrollRect;

		// Token: 0x0400851C RID: 34076
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400851D RID: 34077
		[AutoBind("./Prefabs/CooperateBattleLevelListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_CooperateBattleLevelListItemPrefab;

		// Token: 0x0400851E RID: 34078
		private List<CooperateBattleLevelListItemUIController> m_CooperateBattleLevelListItems = new List<CooperateBattleLevelListItemUIController>();

		// Token: 0x0400851F RID: 34079
		[DoNotToLua]
		private CooperateBattleUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008520 RID: 34080
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008521 RID: 34081
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008522 RID: 34082
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008523 RID: 34083
		private LuaFunction m_Open_hotfix;

		// Token: 0x04008524 RID: 34084
		private LuaFunction m_SetCooperateBattleConfigDataCooperateBattleInfo_hotfix;

		// Token: 0x04008525 RID: 34085
		private LuaFunction m_AddAllCooperateBattleLevelListItemsList;

		// Token: 0x04008526 RID: 34086
		private LuaFunction m_AddCooperateBattleLevelListItemConfigDataCooperateBattleLevelInfoBoolean_hotfix;

		// Token: 0x04008527 RID: 34087
		private LuaFunction m_ClearCooperateBattleLevelListItems_hotfix;

		// Token: 0x04008528 RID: 34088
		private LuaFunction m_SetDailyRewardCountInt32Int32_hotfix;

		// Token: 0x04008529 RID: 34089
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400852A RID: 34090
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x0400852B RID: 34091
		private LuaFunction m_OnAddTicketButtonClick_hotfix;

		// Token: 0x0400852C RID: 34092
		private LuaFunction m_OnTeamButtonClick_hotfix;

		// Token: 0x0400852D RID: 34093
		private LuaFunction m_CooperateBattleLevelListItem_OnStartButtonClickCooperateBattleLevelListItemUIController_hotfix;

		// Token: 0x0400852E RID: 34094
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400852F RID: 34095
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04008530 RID: 34096
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04008531 RID: 34097
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04008532 RID: 34098
		private LuaFunction m_add_EventOnAddTicketAction_hotfix;

		// Token: 0x04008533 RID: 34099
		private LuaFunction m_remove_EventOnAddTicketAction_hotfix;

		// Token: 0x04008534 RID: 34100
		private LuaFunction m_add_EventOnShowTeamAction_hotfix;

		// Token: 0x04008535 RID: 34101
		private LuaFunction m_remove_EventOnShowTeamAction_hotfix;

		// Token: 0x04008536 RID: 34102
		private LuaFunction m_add_EventOnStartCooperateBattleLevelAction;

		// Token: 0x04008537 RID: 34103
		private LuaFunction m_remove_EventOnStartCooperateBattleLevelAction;

		// Token: 0x02000C12 RID: 3090
		public new class LuaExportHelper
		{
			// Token: 0x0600D8F1 RID: 55537 RVA: 0x003AF80C File Offset: 0x003ADA0C
			public LuaExportHelper(CooperateBattleUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D8F2 RID: 55538 RVA: 0x003AF81C File Offset: 0x003ADA1C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D8F3 RID: 55539 RVA: 0x003AF82C File Offset: 0x003ADA2C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D8F4 RID: 55540 RVA: 0x003AF83C File Offset: 0x003ADA3C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D8F5 RID: 55541 RVA: 0x003AF84C File Offset: 0x003ADA4C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D8F6 RID: 55542 RVA: 0x003AF864 File Offset: 0x003ADA64
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D8F7 RID: 55543 RVA: 0x003AF874 File Offset: 0x003ADA74
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D8F8 RID: 55544 RVA: 0x003AF884 File Offset: 0x003ADA84
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D8F9 RID: 55545 RVA: 0x003AF894 File Offset: 0x003ADA94
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D8FA RID: 55546 RVA: 0x003AF8A4 File Offset: 0x003ADAA4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D8FB RID: 55547 RVA: 0x003AF8B4 File Offset: 0x003ADAB4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D8FC RID: 55548 RVA: 0x003AF8C4 File Offset: 0x003ADAC4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D8FD RID: 55549 RVA: 0x003AF8D4 File Offset: 0x003ADAD4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D8FE RID: 55550 RVA: 0x003AF8E4 File Offset: 0x003ADAE4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D8FF RID: 55551 RVA: 0x003AF8F4 File Offset: 0x003ADAF4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D900 RID: 55552 RVA: 0x003AF904 File Offset: 0x003ADB04
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D901 RID: 55553 RVA: 0x003AF914 File Offset: 0x003ADB14
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600D902 RID: 55554 RVA: 0x003AF924 File Offset: 0x003ADB24
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600D903 RID: 55555 RVA: 0x003AF934 File Offset: 0x003ADB34
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600D904 RID: 55556 RVA: 0x003AF944 File Offset: 0x003ADB44
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600D905 RID: 55557 RVA: 0x003AF954 File Offset: 0x003ADB54
			public void __callDele_EventOnAddTicket()
			{
				this.m_owner.__callDele_EventOnAddTicket();
			}

			// Token: 0x0600D906 RID: 55558 RVA: 0x003AF964 File Offset: 0x003ADB64
			public void __clearDele_EventOnAddTicket()
			{
				this.m_owner.__clearDele_EventOnAddTicket();
			}

			// Token: 0x0600D907 RID: 55559 RVA: 0x003AF974 File Offset: 0x003ADB74
			public void __callDele_EventOnShowTeam()
			{
				this.m_owner.__callDele_EventOnShowTeam();
			}

			// Token: 0x0600D908 RID: 55560 RVA: 0x003AF984 File Offset: 0x003ADB84
			public void __clearDele_EventOnShowTeam()
			{
				this.m_owner.__clearDele_EventOnShowTeam();
			}

			// Token: 0x0600D909 RID: 55561 RVA: 0x003AF994 File Offset: 0x003ADB94
			public void __callDele_EventOnStartCooperateBattleLevel(ConfigDataCooperateBattleLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnStartCooperateBattleLevel(obj);
			}

			// Token: 0x0600D90A RID: 55562 RVA: 0x003AF9A4 File Offset: 0x003ADBA4
			public void __clearDele_EventOnStartCooperateBattleLevel(ConfigDataCooperateBattleLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartCooperateBattleLevel(obj);
			}

			// Token: 0x17002A2E RID: 10798
			// (get) Token: 0x0600D90B RID: 55563 RVA: 0x003AF9B4 File Offset: 0x003ADBB4
			// (set) Token: 0x0600D90C RID: 55564 RVA: 0x003AF9C4 File Offset: 0x003ADBC4
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x17002A2F RID: 10799
			// (get) Token: 0x0600D90D RID: 55565 RVA: 0x003AF9D4 File Offset: 0x003ADBD4
			// (set) Token: 0x0600D90E RID: 55566 RVA: 0x003AF9E4 File Offset: 0x003ADBE4
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

			// Token: 0x17002A30 RID: 10800
			// (get) Token: 0x0600D90F RID: 55567 RVA: 0x003AF9F4 File Offset: 0x003ADBF4
			// (set) Token: 0x0600D910 RID: 55568 RVA: 0x003AFA04 File Offset: 0x003ADC04
			public Button m_helpButton
			{
				get
				{
					return this.m_owner.m_helpButton;
				}
				set
				{
					this.m_owner.m_helpButton = value;
				}
			}

			// Token: 0x17002A31 RID: 10801
			// (get) Token: 0x0600D911 RID: 55569 RVA: 0x003AFA14 File Offset: 0x003ADC14
			// (set) Token: 0x0600D912 RID: 55570 RVA: 0x003AFA24 File Offset: 0x003ADC24
			public Button m_teamButton
			{
				get
				{
					return this.m_owner.m_teamButton;
				}
				set
				{
					this.m_owner.m_teamButton = value;
				}
			}

			// Token: 0x17002A32 RID: 10802
			// (get) Token: 0x0600D913 RID: 55571 RVA: 0x003AFA34 File Offset: 0x003ADC34
			// (set) Token: 0x0600D914 RID: 55572 RVA: 0x003AFA44 File Offset: 0x003ADC44
			public Text m_dailyRewardCountText
			{
				get
				{
					return this.m_owner.m_dailyRewardCountText;
				}
				set
				{
					this.m_owner.m_dailyRewardCountText = value;
				}
			}

			// Token: 0x17002A33 RID: 10803
			// (get) Token: 0x0600D915 RID: 55573 RVA: 0x003AFA54 File Offset: 0x003ADC54
			// (set) Token: 0x0600D916 RID: 55574 RVA: 0x003AFA64 File Offset: 0x003ADC64
			public Text m_chapterNameText
			{
				get
				{
					return this.m_owner.m_chapterNameText;
				}
				set
				{
					this.m_owner.m_chapterNameText = value;
				}
			}

			// Token: 0x17002A34 RID: 10804
			// (get) Token: 0x0600D917 RID: 55575 RVA: 0x003AFA74 File Offset: 0x003ADC74
			// (set) Token: 0x0600D918 RID: 55576 RVA: 0x003AFA84 File Offset: 0x003ADC84
			public Text m_chapterDescText
			{
				get
				{
					return this.m_owner.m_chapterDescText;
				}
				set
				{
					this.m_owner.m_chapterDescText = value;
				}
			}

			// Token: 0x17002A35 RID: 10805
			// (get) Token: 0x0600D919 RID: 55577 RVA: 0x003AFA94 File Offset: 0x003ADC94
			// (set) Token: 0x0600D91A RID: 55578 RVA: 0x003AFAA4 File Offset: 0x003ADCA4
			public Image m_chapterImage
			{
				get
				{
					return this.m_owner.m_chapterImage;
				}
				set
				{
					this.m_owner.m_chapterImage = value;
				}
			}

			// Token: 0x17002A36 RID: 10806
			// (get) Token: 0x0600D91B RID: 55579 RVA: 0x003AFAB4 File Offset: 0x003ADCB4
			// (set) Token: 0x0600D91C RID: 55580 RVA: 0x003AFAC4 File Offset: 0x003ADCC4
			public ScrollRect m_levelListScrollRect
			{
				get
				{
					return this.m_owner.m_levelListScrollRect;
				}
				set
				{
					this.m_owner.m_levelListScrollRect = value;
				}
			}

			// Token: 0x17002A37 RID: 10807
			// (get) Token: 0x0600D91D RID: 55581 RVA: 0x003AFAD4 File Offset: 0x003ADCD4
			// (set) Token: 0x0600D91E RID: 55582 RVA: 0x003AFAE4 File Offset: 0x003ADCE4
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x17002A38 RID: 10808
			// (get) Token: 0x0600D91F RID: 55583 RVA: 0x003AFAF4 File Offset: 0x003ADCF4
			// (set) Token: 0x0600D920 RID: 55584 RVA: 0x003AFB04 File Offset: 0x003ADD04
			public GameObject m_CooperateBattleLevelListItemPrefab
			{
				get
				{
					return this.m_owner.m_CooperateBattleLevelListItemPrefab;
				}
				set
				{
					this.m_owner.m_CooperateBattleLevelListItemPrefab = value;
				}
			}

			// Token: 0x17002A39 RID: 10809
			// (get) Token: 0x0600D921 RID: 55585 RVA: 0x003AFB14 File Offset: 0x003ADD14
			// (set) Token: 0x0600D922 RID: 55586 RVA: 0x003AFB24 File Offset: 0x003ADD24
			public List<CooperateBattleLevelListItemUIController> m_CooperateBattleLevelListItems
			{
				get
				{
					return this.m_owner.m_CooperateBattleLevelListItems;
				}
				set
				{
					this.m_owner.m_CooperateBattleLevelListItems = value;
				}
			}

			// Token: 0x0600D923 RID: 55587 RVA: 0x003AFB34 File Offset: 0x003ADD34
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D924 RID: 55588 RVA: 0x003AFB44 File Offset: 0x003ADD44
			public void AddCooperateBattleLevelListItem(ConfigDataCooperateBattleLevelInfo levelnfo, bool opened)
			{
				this.m_owner.AddCooperateBattleLevelListItem(levelnfo, opened);
			}

			// Token: 0x0600D925 RID: 55589 RVA: 0x003AFB54 File Offset: 0x003ADD54
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600D926 RID: 55590 RVA: 0x003AFB64 File Offset: 0x003ADD64
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0600D927 RID: 55591 RVA: 0x003AFB74 File Offset: 0x003ADD74
			public void OnAddTicketButtonClick()
			{
				this.m_owner.OnAddTicketButtonClick();
			}

			// Token: 0x0600D928 RID: 55592 RVA: 0x003AFB84 File Offset: 0x003ADD84
			public void OnTeamButtonClick()
			{
				this.m_owner.OnTeamButtonClick();
			}

			// Token: 0x0600D929 RID: 55593 RVA: 0x003AFB94 File Offset: 0x003ADD94
			public void CooperateBattleLevelListItem_OnStartButtonClick(CooperateBattleLevelListItemUIController b)
			{
				this.m_owner.CooperateBattleLevelListItem_OnStartButtonClick(b);
			}

			// Token: 0x04008538 RID: 34104
			private CooperateBattleUIController m_owner;
		}
	}
}
