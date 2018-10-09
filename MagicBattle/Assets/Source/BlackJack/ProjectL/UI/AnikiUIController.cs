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
	// Token: 0x020009CA RID: 2506
	[HotFix]
	public class AnikiUIController : UIControllerBase
	{
		// Token: 0x060091EC RID: 37356 RVA: 0x002A364C File Offset: 0x002A184C
		private AnikiUIController()
		{
		}

		// Token: 0x060091ED RID: 37357 RVA: 0x002A3674 File Offset: 0x002A1874
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

		// Token: 0x060091EE RID: 37358 RVA: 0x002A373C File Offset: 0x002A193C
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

		// Token: 0x060091EF RID: 37359 RVA: 0x002A37B0 File Offset: 0x002A19B0
		public void AddAnikiGymListItem(ConfigDataAnikiGymInfo anikiGymInfo, bool opened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddAnikiGymListItemConfigDataAnikiGymInfoBoolean_hotfix != null)
			{
				this.m_AddAnikiGymListItemConfigDataAnikiGymInfoBoolean_hotfix.call(new object[]
				{
					this,
					anikiGymInfo,
					opened
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_anikiGymListItemPrefab, this.m_gymListGameObject.transform, false);
			AnikiGymListItemUIController anikiGymListItemUIController = GameObjectUtility.AddControllerToGameObject<AnikiGymListItemUIController>(go);
			anikiGymListItemUIController.SetAnikiGymInfo(anikiGymInfo);
			anikiGymListItemUIController.SetLocked(!opened);
			anikiGymListItemUIController.SetSelected(false);
			if (opened)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				DateTime serverTime = projectLPlayerContext.GetServerTime();
				DateTime expireTime = new DateTime(serverTime.Year, serverTime.Month, serverTime.Day) + TimeSpan.FromDays(1.0);
				anikiGymListItemUIController.SetExpireTime(expireTime);
			}
			anikiGymListItemUIController.EventOnToggleValueChanged += this.AnikiGymListItem_OnToggleValueChanged;
			this.m_anikiGymListItems.Add(anikiGymListItemUIController);
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x002A38DC File Offset: 0x002A1ADC
		public void ClearAnikiGymListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAnikiGymListItems_hotfix != null)
			{
				this.m_ClearAnikiGymListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<AnikiGymListItemUIController>(this.m_anikiGymListItems);
			this.m_anikiGymListItems.Clear();
		}

		// Token: 0x060091F1 RID: 37361 RVA: 0x002A3954 File Offset: 0x002A1B54
		public void SetAllAnikiLevelListItem(List<ConfigDataAnikiLevelInfo> levelInfoList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAllAnikiLevelListItemList`1_hotfix != null)
			{
				this.m_SetAllAnikiLevelListItemList`1_hotfix.call(new object[]
				{
					this,
					levelInfoList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int childCount = this.m_levelListScrollRect.content.childCount;
			for (int i = 0; i < childCount; i++)
			{
				this.m_levelListScrollRect.content.GetChild(i).gameObject.SetActive(false);
			}
			for (int j = 0; j < levelInfoList.Count; j++)
			{
				ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = levelInfoList[j];
				AnikiLevelListItemUIController anikiLevelListItemUIController;
				if (j >= childCount)
				{
					GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_anikiLevelListItemPrefab, this.m_levelListScrollRect.content, false);
					anikiLevelListItemUIController = GameObjectUtility.AddControllerToGameObject<AnikiLevelListItemUIController>(go);
					anikiLevelListItemUIController.EventOnStartButtonClick += this.AnikiLevelListItem_OnStartButtonClick;
				}
				else
				{
					anikiLevelListItemUIController = this.m_levelListScrollRect.content.GetChild(j).gameObject.GetComponent<AnikiLevelListItemUIController>();
				}
				anikiLevelListItemUIController.SetAnikiLevelInfo(levelInfoList[j]);
				anikiLevelListItemUIController.SetLocked(!this.m_playerContext.IsAnikiLevelOpened(levelInfoList[j].ID));
				anikiLevelListItemUIController.gameObject.SetActive(true);
			}
		}

		// Token: 0x060091F2 RID: 37362 RVA: 0x002A3AC0 File Offset: 0x002A1CC0
		public void SetSelectedAnikiGym(ConfigDataAnikiGymInfo anikiGymInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectedAnikiGymConfigDataAnikiGymInfo_hotfix != null)
			{
				this.m_SetSelectedAnikiGymConfigDataAnikiGymInfo_hotfix.call(new object[]
				{
					this,
					anikiGymInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (AnikiGymListItemUIController anikiGymListItemUIController in this.m_anikiGymListItems)
			{
				if (anikiGymListItemUIController.GetAnikiGymInfo() == anikiGymInfo)
				{
					anikiGymListItemUIController.SetSelected(true);
					break;
				}
			}
			if (anikiGymInfo != null)
			{
				this.m_gymNameText.text = anikiGymInfo.Name;
			}
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x002A3BA8 File Offset: 0x002A1DA8
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

		// Token: 0x060091F4 RID: 37364 RVA: 0x002A3C38 File Offset: 0x002A1E38
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

		// Token: 0x060091F5 RID: 37365 RVA: 0x002A3CB0 File Offset: 0x002A1EB0
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

		// Token: 0x060091F6 RID: 37366 RVA: 0x002A3D28 File Offset: 0x002A1F28
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

		// Token: 0x060091F7 RID: 37367 RVA: 0x002A3DA0 File Offset: 0x002A1FA0
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

		// Token: 0x060091F8 RID: 37368 RVA: 0x002A3E18 File Offset: 0x002A2018
		private void AnikiGymListItem_OnToggleValueChanged(bool isOn, AnikiGymListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AnikiGymListItem_OnToggleValueChangedBooleanAnikiGymListItemUIController_hotfix != null)
			{
				this.m_AnikiGymListItem_OnToggleValueChangedBooleanAnikiGymListItemUIController_hotfix.call(new object[]
				{
					this,
					isOn,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.ResetScrollViewToTop();
				this.SetSelectedAnikiGym(ctrl.GetAnikiGymInfo());
				if (this.EventOnSelectAnikiGym != null)
				{
					this.EventOnSelectAnikiGym(ctrl.GetAnikiGymInfo());
				}
			}
		}

		// Token: 0x060091F9 RID: 37369 RVA: 0x002A3ECC File Offset: 0x002A20CC
		private void AnikiLevelListItem_OnStartButtonClick(AnikiLevelListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AnikiLevelListItem_OnStartButtonClickAnikiLevelListItemUIController_hotfix != null)
			{
				this.m_AnikiLevelListItem_OnStartButtonClickAnikiLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartAnikiLevel != null)
			{
				this.EventOnStartAnikiLevel(ctrl.GetAnikiLevelInfo());
			}
		}

		// Token: 0x060091FA RID: 37370 RVA: 0x002A3F58 File Offset: 0x002A2158
		private void ResetScrollViewToTop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetScrollViewToTop_hotfix != null)
			{
				this.m_ResetScrollViewToTop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelListScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x14000197 RID: 407
		// (add) Token: 0x060091FB RID: 37371 RVA: 0x002A3FC8 File Offset: 0x002A21C8
		// (remove) Token: 0x060091FC RID: 37372 RVA: 0x002A4064 File Offset: 0x002A2264
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

		// Token: 0x14000198 RID: 408
		// (add) Token: 0x060091FD RID: 37373 RVA: 0x002A4100 File Offset: 0x002A2300
		// (remove) Token: 0x060091FE RID: 37374 RVA: 0x002A419C File Offset: 0x002A239C
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

		// Token: 0x14000199 RID: 409
		// (add) Token: 0x060091FF RID: 37375 RVA: 0x002A4238 File Offset: 0x002A2438
		// (remove) Token: 0x06009200 RID: 37376 RVA: 0x002A42D4 File Offset: 0x002A24D4
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

		// Token: 0x1400019A RID: 410
		// (add) Token: 0x06009201 RID: 37377 RVA: 0x002A4370 File Offset: 0x002A2570
		// (remove) Token: 0x06009202 RID: 37378 RVA: 0x002A440C File Offset: 0x002A260C
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

		// Token: 0x1400019B RID: 411
		// (add) Token: 0x06009203 RID: 37379 RVA: 0x002A44A8 File Offset: 0x002A26A8
		// (remove) Token: 0x06009204 RID: 37380 RVA: 0x002A4544 File Offset: 0x002A2744
		public event Action<ConfigDataAnikiGymInfo> EventOnSelectAnikiGym
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectAnikiGymAction`1_hotfix != null)
				{
					this.m_add_EventOnSelectAnikiGymAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataAnikiGymInfo> action = this.EventOnSelectAnikiGym;
				Action<ConfigDataAnikiGymInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataAnikiGymInfo>>(ref this.EventOnSelectAnikiGym, (Action<ConfigDataAnikiGymInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectAnikiGymAction`1_hotfix != null)
				{
					this.m_remove_EventOnSelectAnikiGymAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataAnikiGymInfo> action = this.EventOnSelectAnikiGym;
				Action<ConfigDataAnikiGymInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataAnikiGymInfo>>(ref this.EventOnSelectAnikiGym, (Action<ConfigDataAnikiGymInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400019C RID: 412
		// (add) Token: 0x06009205 RID: 37381 RVA: 0x002A45E0 File Offset: 0x002A27E0
		// (remove) Token: 0x06009206 RID: 37382 RVA: 0x002A467C File Offset: 0x002A287C
		public event Action<ConfigDataAnikiLevelInfo> EventOnStartAnikiLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartAnikiLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnStartAnikiLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataAnikiLevelInfo> action = this.EventOnStartAnikiLevel;
				Action<ConfigDataAnikiLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataAnikiLevelInfo>>(ref this.EventOnStartAnikiLevel, (Action<ConfigDataAnikiLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartAnikiLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartAnikiLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataAnikiLevelInfo> action = this.EventOnStartAnikiLevel;
				Action<ConfigDataAnikiLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataAnikiLevelInfo>>(ref this.EventOnStartAnikiLevel, (Action<ConfigDataAnikiLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06009207 RID: 37383 RVA: 0x002A4718 File Offset: 0x002A2918
		// (set) Token: 0x06009208 RID: 37384 RVA: 0x002A4738 File Offset: 0x002A2938
		[DoNotToLua]
		public new AnikiUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new AnikiUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x002A4744 File Offset: 0x002A2944
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x002A4750 File Offset: 0x002A2950
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x002A4758 File Offset: 0x002A2958
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x002A4760 File Offset: 0x002A2960
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600920D RID: 37389 RVA: 0x002A4774 File Offset: 0x002A2974
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600920E RID: 37390 RVA: 0x002A477C File Offset: 0x002A297C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600920F RID: 37391 RVA: 0x002A4788 File Offset: 0x002A2988
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x002A4794 File Offset: 0x002A2994
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x002A47A0 File Offset: 0x002A29A0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009212 RID: 37394 RVA: 0x002A47AC File Offset: 0x002A29AC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009213 RID: 37395 RVA: 0x002A47B8 File Offset: 0x002A29B8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x002A47C4 File Offset: 0x002A29C4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x002A47D0 File Offset: 0x002A29D0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x002A47DC File Offset: 0x002A29DC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x002A47E8 File Offset: 0x002A29E8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x002A47F0 File Offset: 0x002A29F0
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06009219 RID: 37401 RVA: 0x002A4810 File Offset: 0x002A2A10
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x002A481C File Offset: 0x002A2A1C
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x002A483C File Offset: 0x002A2A3C
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600921C RID: 37404 RVA: 0x002A4848 File Offset: 0x002A2A48
		private void __callDele_EventOnAddTicket()
		{
			Action eventOnAddTicket = this.EventOnAddTicket;
			if (eventOnAddTicket != null)
			{
				eventOnAddTicket();
			}
		}

		// Token: 0x0600921D RID: 37405 RVA: 0x002A4868 File Offset: 0x002A2A68
		private void __clearDele_EventOnAddTicket()
		{
			this.EventOnAddTicket = null;
		}

		// Token: 0x0600921E RID: 37406 RVA: 0x002A4874 File Offset: 0x002A2A74
		private void __callDele_EventOnShowTeam()
		{
			Action eventOnShowTeam = this.EventOnShowTeam;
			if (eventOnShowTeam != null)
			{
				eventOnShowTeam();
			}
		}

		// Token: 0x0600921F RID: 37407 RVA: 0x002A4894 File Offset: 0x002A2A94
		private void __clearDele_EventOnShowTeam()
		{
			this.EventOnShowTeam = null;
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x002A48A0 File Offset: 0x002A2AA0
		private void __callDele_EventOnSelectAnikiGym(ConfigDataAnikiGymInfo obj)
		{
			Action<ConfigDataAnikiGymInfo> eventOnSelectAnikiGym = this.EventOnSelectAnikiGym;
			if (eventOnSelectAnikiGym != null)
			{
				eventOnSelectAnikiGym(obj);
			}
		}

		// Token: 0x06009221 RID: 37409 RVA: 0x002A48C4 File Offset: 0x002A2AC4
		private void __clearDele_EventOnSelectAnikiGym(ConfigDataAnikiGymInfo obj)
		{
			this.EventOnSelectAnikiGym = null;
		}

		// Token: 0x06009222 RID: 37410 RVA: 0x002A48D0 File Offset: 0x002A2AD0
		private void __callDele_EventOnStartAnikiLevel(ConfigDataAnikiLevelInfo obj)
		{
			Action<ConfigDataAnikiLevelInfo> eventOnStartAnikiLevel = this.EventOnStartAnikiLevel;
			if (eventOnStartAnikiLevel != null)
			{
				eventOnStartAnikiLevel(obj);
			}
		}

		// Token: 0x06009223 RID: 37411 RVA: 0x002A48F4 File Offset: 0x002A2AF4
		private void __clearDele_EventOnStartAnikiLevel(ConfigDataAnikiLevelInfo obj)
		{
			this.EventOnStartAnikiLevel = null;
		}

		// Token: 0x06009224 RID: 37412 RVA: 0x002A4900 File Offset: 0x002A2B00
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
					this.m_AddAnikiGymListItemConfigDataAnikiGymInfoBoolean_hotfix = (luaObj.RawGet("AddAnikiGymListItem") as LuaFunction);
					this.m_ClearAnikiGymListItems_hotfix = (luaObj.RawGet("ClearAnikiGymListItems") as LuaFunction);
					this.m_SetAllAnikiLevelListItemList`1_hotfix = (luaObj.RawGet("SetAllAnikiLevelListItem") as LuaFunction);
					this.m_SetSelectedAnikiGymConfigDataAnikiGymInfo_hotfix = (luaObj.RawGet("SetSelectedAnikiGym") as LuaFunction);
					this.m_SetDailyRewardCountInt32Int32_hotfix = (luaObj.RawGet("SetDailyRewardCount") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnAddTicketButtonClick_hotfix = (luaObj.RawGet("OnAddTicketButtonClick") as LuaFunction);
					this.m_OnTeamButtonClick_hotfix = (luaObj.RawGet("OnTeamButtonClick") as LuaFunction);
					this.m_AnikiGymListItem_OnToggleValueChangedBooleanAnikiGymListItemUIController_hotfix = (luaObj.RawGet("AnikiGymListItem_OnToggleValueChanged") as LuaFunction);
					this.m_AnikiLevelListItem_OnStartButtonClickAnikiLevelListItemUIController_hotfix = (luaObj.RawGet("AnikiLevelListItem_OnStartButtonClick") as LuaFunction);
					this.m_ResetScrollViewToTop_hotfix = (luaObj.RawGet("ResetScrollViewToTop") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnAddTicketAction_hotfix = (luaObj.RawGet("add_EventOnAddTicket") as LuaFunction);
					this.m_remove_EventOnAddTicketAction_hotfix = (luaObj.RawGet("remove_EventOnAddTicket") as LuaFunction);
					this.m_add_EventOnShowTeamAction_hotfix = (luaObj.RawGet("add_EventOnShowTeam") as LuaFunction);
					this.m_remove_EventOnShowTeamAction_hotfix = (luaObj.RawGet("remove_EventOnShowTeam") as LuaFunction);
					this.m_add_EventOnSelectAnikiGymAction`1_hotfix = (luaObj.RawGet("add_EventOnSelectAnikiGym") as LuaFunction);
					this.m_remove_EventOnSelectAnikiGymAction`1_hotfix = (luaObj.RawGet("remove_EventOnSelectAnikiGym") as LuaFunction);
					this.m_add_EventOnStartAnikiLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnStartAnikiLevel") as LuaFunction);
					this.m_remove_EventOnStartAnikiLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartAnikiLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009225 RID: 37413 RVA: 0x002A4C3C File Offset: 0x002A2E3C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AnikiUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400661F RID: 26143
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04006620 RID: 26144
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04006621 RID: 26145
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04006622 RID: 26146
		[AutoBind("./OrganizeTeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_teamButton;

		// Token: 0x04006623 RID: 26147
		[AutoBind("./PlayerResource/DailyReward/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_dailyRewardCountText;

		// Token: 0x04006624 RID: 26148
		[AutoBind("./GymList", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_gymListGameObject;

		// Token: 0x04006625 RID: 26149
		[AutoBind("./LevelList/NameImage/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_gymNameText;

		// Token: 0x04006626 RID: 26150
		[AutoBind("./LevelList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_levelListScrollRect;

		// Token: 0x04006627 RID: 26151
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04006628 RID: 26152
		[AutoBind("./Prefabs/AnikiGymListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_anikiGymListItemPrefab;

		// Token: 0x04006629 RID: 26153
		[AutoBind("./Prefabs/AnikiLevelListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_anikiLevelListItemPrefab;

		// Token: 0x0400662A RID: 26154
		private List<AnikiGymListItemUIController> m_anikiGymListItems = new List<AnikiGymListItemUIController>();

		// Token: 0x0400662B RID: 26155
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400662C RID: 26156
		[DoNotToLua]
		private AnikiUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400662D RID: 26157
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400662E RID: 26158
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400662F RID: 26159
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006630 RID: 26160
		private LuaFunction m_Open_hotfix;

		// Token: 0x04006631 RID: 26161
		private LuaFunction m_AddAnikiGymListItemConfigDataAnikiGymInfoBoolean_hotfix;

		// Token: 0x04006632 RID: 26162
		private LuaFunction m_ClearAnikiGymListItems_hotfix;

		// Token: 0x04006633 RID: 26163
		private LuaFunction m_SetAllAnikiLevelListItemList;

		// Token: 0x04006634 RID: 26164
		private LuaFunction m_SetSelectedAnikiGymConfigDataAnikiGymInfo_hotfix;

		// Token: 0x04006635 RID: 26165
		private LuaFunction m_SetDailyRewardCountInt32Int32_hotfix;

		// Token: 0x04006636 RID: 26166
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04006637 RID: 26167
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04006638 RID: 26168
		private LuaFunction m_OnAddTicketButtonClick_hotfix;

		// Token: 0x04006639 RID: 26169
		private LuaFunction m_OnTeamButtonClick_hotfix;

		// Token: 0x0400663A RID: 26170
		private LuaFunction m_AnikiGymListItem_OnToggleValueChangedBooleanAnikiGymListItemUIController_hotfix;

		// Token: 0x0400663B RID: 26171
		private LuaFunction m_AnikiLevelListItem_OnStartButtonClickAnikiLevelListItemUIController_hotfix;

		// Token: 0x0400663C RID: 26172
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x0400663D RID: 26173
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400663E RID: 26174
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400663F RID: 26175
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04006640 RID: 26176
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04006641 RID: 26177
		private LuaFunction m_add_EventOnAddTicketAction_hotfix;

		// Token: 0x04006642 RID: 26178
		private LuaFunction m_remove_EventOnAddTicketAction_hotfix;

		// Token: 0x04006643 RID: 26179
		private LuaFunction m_add_EventOnShowTeamAction_hotfix;

		// Token: 0x04006644 RID: 26180
		private LuaFunction m_remove_EventOnShowTeamAction_hotfix;

		// Token: 0x04006645 RID: 26181
		private LuaFunction m_add_EventOnSelectAnikiGymAction;

		// Token: 0x04006646 RID: 26182
		private LuaFunction m_remove_EventOnSelectAnikiGymAction;

		// Token: 0x04006647 RID: 26183
		private LuaFunction m_add_EventOnStartAnikiLevelAction;

		// Token: 0x04006648 RID: 26184
		private LuaFunction m_remove_EventOnStartAnikiLevelAction;

		// Token: 0x020009CB RID: 2507
		public new class LuaExportHelper
		{
			// Token: 0x06009226 RID: 37414 RVA: 0x002A4CA4 File Offset: 0x002A2EA4
			public LuaExportHelper(AnikiUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009227 RID: 37415 RVA: 0x002A4CB4 File Offset: 0x002A2EB4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009228 RID: 37416 RVA: 0x002A4CC4 File Offset: 0x002A2EC4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009229 RID: 37417 RVA: 0x002A4CD4 File Offset: 0x002A2ED4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600922A RID: 37418 RVA: 0x002A4CE4 File Offset: 0x002A2EE4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600922B RID: 37419 RVA: 0x002A4CFC File Offset: 0x002A2EFC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600922C RID: 37420 RVA: 0x002A4D0C File Offset: 0x002A2F0C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600922D RID: 37421 RVA: 0x002A4D1C File Offset: 0x002A2F1C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600922E RID: 37422 RVA: 0x002A4D2C File Offset: 0x002A2F2C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600922F RID: 37423 RVA: 0x002A4D3C File Offset: 0x002A2F3C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009230 RID: 37424 RVA: 0x002A4D4C File Offset: 0x002A2F4C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009231 RID: 37425 RVA: 0x002A4D5C File Offset: 0x002A2F5C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009232 RID: 37426 RVA: 0x002A4D6C File Offset: 0x002A2F6C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009233 RID: 37427 RVA: 0x002A4D7C File Offset: 0x002A2F7C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009234 RID: 37428 RVA: 0x002A4D8C File Offset: 0x002A2F8C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009235 RID: 37429 RVA: 0x002A4D9C File Offset: 0x002A2F9C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009236 RID: 37430 RVA: 0x002A4DAC File Offset: 0x002A2FAC
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06009237 RID: 37431 RVA: 0x002A4DBC File Offset: 0x002A2FBC
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06009238 RID: 37432 RVA: 0x002A4DCC File Offset: 0x002A2FCC
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x06009239 RID: 37433 RVA: 0x002A4DDC File Offset: 0x002A2FDC
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600923A RID: 37434 RVA: 0x002A4DEC File Offset: 0x002A2FEC
			public void __callDele_EventOnAddTicket()
			{
				this.m_owner.__callDele_EventOnAddTicket();
			}

			// Token: 0x0600923B RID: 37435 RVA: 0x002A4DFC File Offset: 0x002A2FFC
			public void __clearDele_EventOnAddTicket()
			{
				this.m_owner.__clearDele_EventOnAddTicket();
			}

			// Token: 0x0600923C RID: 37436 RVA: 0x002A4E0C File Offset: 0x002A300C
			public void __callDele_EventOnShowTeam()
			{
				this.m_owner.__callDele_EventOnShowTeam();
			}

			// Token: 0x0600923D RID: 37437 RVA: 0x002A4E1C File Offset: 0x002A301C
			public void __clearDele_EventOnShowTeam()
			{
				this.m_owner.__clearDele_EventOnShowTeam();
			}

			// Token: 0x0600923E RID: 37438 RVA: 0x002A4E2C File Offset: 0x002A302C
			public void __callDele_EventOnSelectAnikiGym(ConfigDataAnikiGymInfo obj)
			{
				this.m_owner.__callDele_EventOnSelectAnikiGym(obj);
			}

			// Token: 0x0600923F RID: 37439 RVA: 0x002A4E3C File Offset: 0x002A303C
			public void __clearDele_EventOnSelectAnikiGym(ConfigDataAnikiGymInfo obj)
			{
				this.m_owner.__clearDele_EventOnSelectAnikiGym(obj);
			}

			// Token: 0x06009240 RID: 37440 RVA: 0x002A4E4C File Offset: 0x002A304C
			public void __callDele_EventOnStartAnikiLevel(ConfigDataAnikiLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnStartAnikiLevel(obj);
			}

			// Token: 0x06009241 RID: 37441 RVA: 0x002A4E5C File Offset: 0x002A305C
			public void __clearDele_EventOnStartAnikiLevel(ConfigDataAnikiLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartAnikiLevel(obj);
			}

			// Token: 0x17001E41 RID: 7745
			// (get) Token: 0x06009242 RID: 37442 RVA: 0x002A4E6C File Offset: 0x002A306C
			// (set) Token: 0x06009243 RID: 37443 RVA: 0x002A4E7C File Offset: 0x002A307C
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

			// Token: 0x17001E42 RID: 7746
			// (get) Token: 0x06009244 RID: 37444 RVA: 0x002A4E8C File Offset: 0x002A308C
			// (set) Token: 0x06009245 RID: 37445 RVA: 0x002A4E9C File Offset: 0x002A309C
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

			// Token: 0x17001E43 RID: 7747
			// (get) Token: 0x06009246 RID: 37446 RVA: 0x002A4EAC File Offset: 0x002A30AC
			// (set) Token: 0x06009247 RID: 37447 RVA: 0x002A4EBC File Offset: 0x002A30BC
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

			// Token: 0x17001E44 RID: 7748
			// (get) Token: 0x06009248 RID: 37448 RVA: 0x002A4ECC File Offset: 0x002A30CC
			// (set) Token: 0x06009249 RID: 37449 RVA: 0x002A4EDC File Offset: 0x002A30DC
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

			// Token: 0x17001E45 RID: 7749
			// (get) Token: 0x0600924A RID: 37450 RVA: 0x002A4EEC File Offset: 0x002A30EC
			// (set) Token: 0x0600924B RID: 37451 RVA: 0x002A4EFC File Offset: 0x002A30FC
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

			// Token: 0x17001E46 RID: 7750
			// (get) Token: 0x0600924C RID: 37452 RVA: 0x002A4F0C File Offset: 0x002A310C
			// (set) Token: 0x0600924D RID: 37453 RVA: 0x002A4F1C File Offset: 0x002A311C
			public GameObject m_gymListGameObject
			{
				get
				{
					return this.m_owner.m_gymListGameObject;
				}
				set
				{
					this.m_owner.m_gymListGameObject = value;
				}
			}

			// Token: 0x17001E47 RID: 7751
			// (get) Token: 0x0600924E RID: 37454 RVA: 0x002A4F2C File Offset: 0x002A312C
			// (set) Token: 0x0600924F RID: 37455 RVA: 0x002A4F3C File Offset: 0x002A313C
			public Text m_gymNameText
			{
				get
				{
					return this.m_owner.m_gymNameText;
				}
				set
				{
					this.m_owner.m_gymNameText = value;
				}
			}

			// Token: 0x17001E48 RID: 7752
			// (get) Token: 0x06009250 RID: 37456 RVA: 0x002A4F4C File Offset: 0x002A314C
			// (set) Token: 0x06009251 RID: 37457 RVA: 0x002A4F5C File Offset: 0x002A315C
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

			// Token: 0x17001E49 RID: 7753
			// (get) Token: 0x06009252 RID: 37458 RVA: 0x002A4F6C File Offset: 0x002A316C
			// (set) Token: 0x06009253 RID: 37459 RVA: 0x002A4F7C File Offset: 0x002A317C
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

			// Token: 0x17001E4A RID: 7754
			// (get) Token: 0x06009254 RID: 37460 RVA: 0x002A4F8C File Offset: 0x002A318C
			// (set) Token: 0x06009255 RID: 37461 RVA: 0x002A4F9C File Offset: 0x002A319C
			public GameObject m_anikiGymListItemPrefab
			{
				get
				{
					return this.m_owner.m_anikiGymListItemPrefab;
				}
				set
				{
					this.m_owner.m_anikiGymListItemPrefab = value;
				}
			}

			// Token: 0x17001E4B RID: 7755
			// (get) Token: 0x06009256 RID: 37462 RVA: 0x002A4FAC File Offset: 0x002A31AC
			// (set) Token: 0x06009257 RID: 37463 RVA: 0x002A4FBC File Offset: 0x002A31BC
			public GameObject m_anikiLevelListItemPrefab
			{
				get
				{
					return this.m_owner.m_anikiLevelListItemPrefab;
				}
				set
				{
					this.m_owner.m_anikiLevelListItemPrefab = value;
				}
			}

			// Token: 0x17001E4C RID: 7756
			// (get) Token: 0x06009258 RID: 37464 RVA: 0x002A4FCC File Offset: 0x002A31CC
			// (set) Token: 0x06009259 RID: 37465 RVA: 0x002A4FDC File Offset: 0x002A31DC
			public List<AnikiGymListItemUIController> m_anikiGymListItems
			{
				get
				{
					return this.m_owner.m_anikiGymListItems;
				}
				set
				{
					this.m_owner.m_anikiGymListItems = value;
				}
			}

			// Token: 0x17001E4D RID: 7757
			// (get) Token: 0x0600925A RID: 37466 RVA: 0x002A4FEC File Offset: 0x002A31EC
			// (set) Token: 0x0600925B RID: 37467 RVA: 0x002A4FFC File Offset: 0x002A31FC
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

			// Token: 0x0600925C RID: 37468 RVA: 0x002A500C File Offset: 0x002A320C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600925D RID: 37469 RVA: 0x002A501C File Offset: 0x002A321C
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600925E RID: 37470 RVA: 0x002A502C File Offset: 0x002A322C
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0600925F RID: 37471 RVA: 0x002A503C File Offset: 0x002A323C
			public void OnAddTicketButtonClick()
			{
				this.m_owner.OnAddTicketButtonClick();
			}

			// Token: 0x06009260 RID: 37472 RVA: 0x002A504C File Offset: 0x002A324C
			public void OnTeamButtonClick()
			{
				this.m_owner.OnTeamButtonClick();
			}

			// Token: 0x06009261 RID: 37473 RVA: 0x002A505C File Offset: 0x002A325C
			public void AnikiGymListItem_OnToggleValueChanged(bool isOn, AnikiGymListItemUIController ctrl)
			{
				this.m_owner.AnikiGymListItem_OnToggleValueChanged(isOn, ctrl);
			}

			// Token: 0x06009262 RID: 37474 RVA: 0x002A506C File Offset: 0x002A326C
			public void AnikiLevelListItem_OnStartButtonClick(AnikiLevelListItemUIController ctrl)
			{
				this.m_owner.AnikiLevelListItem_OnStartButtonClick(ctrl);
			}

			// Token: 0x06009263 RID: 37475 RVA: 0x002A507C File Offset: 0x002A327C
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x04006649 RID: 26185
			private AnikiUIController m_owner;
		}
	}
}
