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
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E71 RID: 3697
	[HotFix]
	public class MemoryCorridorUIController : UIControllerBase
	{
		// Token: 0x06011EBB RID: 73403 RVA: 0x004A0F60 File Offset: 0x0049F160
		private MemoryCorridorUIController()
		{
		}

		// Token: 0x06011EBC RID: 73404 RVA: 0x004A0F74 File Offset: 0x0049F174
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

		// Token: 0x06011EBD RID: 73405 RVA: 0x004A103C File Offset: 0x0049F23C
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
			this.ResetScrollViewToTop();
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x06011EBE RID: 73406 RVA: 0x004A10B8 File Offset: 0x0049F2B8
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

		// Token: 0x06011EBF RID: 73407 RVA: 0x004A1128 File Offset: 0x0049F328
		public void SetMemoryCorridor(ConfigDataMemoryCorridorInfo memoryCorridorInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMemoryCorridorConfigDataMemoryCorridorInfo_hotfix != null)
			{
				this.m_SetMemoryCorridorConfigDataMemoryCorridorInfo_hotfix.call(new object[]
				{
					this,
					memoryCorridorInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = memoryCorridorInfo.Name;
			this.m_backgroundImage.sprite = AssetUtility.Instance.GetSprite(memoryCorridorInfo.Background);
			this.CreateSpineGraphic(memoryCorridorInfo);
		}

		// Token: 0x06011EC0 RID: 73408 RVA: 0x004A11CC File Offset: 0x0049F3CC
		public void AddAllMemoryCorridorLevelListItems(List<ConfigDataMemoryCorridorLevelInfo> levelInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddAllMemoryCorridorLevelListItemsList`1_hotfix != null)
			{
				this.m_AddAllMemoryCorridorLevelListItemsList`1_hotfix.call(new object[]
				{
					this,
					levelInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo in levelInfos)
			{
				this.AddMemoryCorridorLevelListItem(configDataMemoryCorridorLevelInfo, projectLPlayerContext.IsMemoryCorridorLevelOpened(configDataMemoryCorridorLevelInfo.ID));
			}
		}

		// Token: 0x06011EC1 RID: 73409 RVA: 0x004A12A4 File Offset: 0x0049F4A4
		private void AddMemoryCorridorLevelListItem(ConfigDataMemoryCorridorLevelInfo levelnfo, bool opened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMemoryCorridorLevelListItemConfigDataMemoryCorridorLevelInfoBoolean_hotfix != null)
			{
				this.m_AddMemoryCorridorLevelListItemConfigDataMemoryCorridorLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelnfo,
					opened
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_memoryCorridorLevelListItemPrefab, this.m_levelListScrollRect.content, false);
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = GameObjectUtility.AddControllerToGameObject<MemoryCorridorLevelListItemUIController>(go);
			memoryCorridorLevelListItemUIController.SetMemoryCorridorLevelInfo(levelnfo);
			memoryCorridorLevelListItemUIController.SetLocked(!opened);
			memoryCorridorLevelListItemUIController.EventOnStartButtonClick += this.MemoryCorridorLevelListItem_OnStartButtonClick;
			this.m_memoryCorridorLevelListItems.Add(memoryCorridorLevelListItemUIController);
		}

		// Token: 0x06011EC2 RID: 73410 RVA: 0x004A1374 File Offset: 0x0049F574
		public void ClearMemoryCorridorLevelListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMemoryCorridorLevelListItems_hotfix != null)
			{
				this.m_ClearMemoryCorridorLevelListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<MemoryCorridorLevelListItemUIController>(this.m_memoryCorridorLevelListItems);
			this.m_memoryCorridorLevelListItems.Clear();
		}

		// Token: 0x06011EC3 RID: 73411 RVA: 0x004A13EC File Offset: 0x0049F5EC
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

		// Token: 0x06011EC4 RID: 73412 RVA: 0x004A1464 File Offset: 0x0049F664
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

		// Token: 0x06011EC5 RID: 73413 RVA: 0x004A14DC File Offset: 0x0049F6DC
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

		// Token: 0x06011EC6 RID: 73414 RVA: 0x004A1554 File Offset: 0x0049F754
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

		// Token: 0x06011EC7 RID: 73415 RVA: 0x004A15CC File Offset: 0x0049F7CC
		private void MemoryCorridorLevelListItem_OnStartButtonClick(MemoryCorridorLevelListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MemoryCorridorLevelListItem_OnStartButtonClickMemoryCorridorLevelListItemUIController_hotfix != null)
			{
				this.m_MemoryCorridorLevelListItem_OnStartButtonClickMemoryCorridorLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartMemoryCorridorLevel != null)
			{
				this.EventOnStartMemoryCorridorLevel(ctrl.GetMemoryCorridorLevelInfo());
			}
		}

		// Token: 0x06011EC8 RID: 73416 RVA: 0x004A1658 File Offset: 0x0049F858
		private void CreateSpineGraphic(ConfigDataMemoryCorridorInfo memoryCorridorInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicConfigDataMemoryCorridorInfo_hotfix != null)
			{
				this.m_CreateSpineGraphicConfigDataMemoryCorridorInfo_hotfix.call(new object[]
				{
					this,
					memoryCorridorInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic();
			if (memoryCorridorInfo == null)
			{
				return;
			}
			float num = (float)memoryCorridorInfo.UI_ModelScale * 0.01f;
			Vector2 position = new Vector2((float)memoryCorridorInfo.UI_ModelOffsetX, (float)memoryCorridorInfo.UI_ModelOffsetY);
			this.m_graphic = new UISpineGraphic();
			this.m_graphic.Create(memoryCorridorInfo.Model);
			this.m_graphic.SetParent(this.m_charGo);
			this.m_graphic.SetDirection(-1);
			this.m_graphic.SetPosition(position);
			this.m_graphic.SetScale(num);
			this.m_graphic.SetRectTransformSize(new Vector2(500f / num, 500f / num));
			this.m_graphic.PlayAnimation("idle_Normal", true, 0);
			this.m_graphic.ForceUpdate();
		}

		// Token: 0x06011EC9 RID: 73417 RVA: 0x004A1788 File Offset: 0x0049F988
		private void DestroySpineGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroySpineGraphic_hotfix != null)
			{
				this.m_DestroySpineGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.Destroy();
				this.m_graphic = null;
			}
		}

		// Token: 0x06011ECA RID: 73418 RVA: 0x004A1808 File Offset: 0x0049FA08
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

		// Token: 0x140003D8 RID: 984
		// (add) Token: 0x06011ECB RID: 73419 RVA: 0x004A1898 File Offset: 0x0049FA98
		// (remove) Token: 0x06011ECC RID: 73420 RVA: 0x004A1934 File Offset: 0x0049FB34
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

		// Token: 0x140003D9 RID: 985
		// (add) Token: 0x06011ECD RID: 73421 RVA: 0x004A19D0 File Offset: 0x0049FBD0
		// (remove) Token: 0x06011ECE RID: 73422 RVA: 0x004A1A6C File Offset: 0x0049FC6C
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

		// Token: 0x140003DA RID: 986
		// (add) Token: 0x06011ECF RID: 73423 RVA: 0x004A1B08 File Offset: 0x0049FD08
		// (remove) Token: 0x06011ED0 RID: 73424 RVA: 0x004A1BA4 File Offset: 0x0049FDA4
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

		// Token: 0x140003DB RID: 987
		// (add) Token: 0x06011ED1 RID: 73425 RVA: 0x004A1C40 File Offset: 0x0049FE40
		// (remove) Token: 0x06011ED2 RID: 73426 RVA: 0x004A1CDC File Offset: 0x0049FEDC
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

		// Token: 0x140003DC RID: 988
		// (add) Token: 0x06011ED3 RID: 73427 RVA: 0x004A1D78 File Offset: 0x0049FF78
		// (remove) Token: 0x06011ED4 RID: 73428 RVA: 0x004A1E14 File Offset: 0x004A0014
		public event Action<ConfigDataMemoryCorridorLevelInfo> EventOnStartMemoryCorridorLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartMemoryCorridorLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnStartMemoryCorridorLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataMemoryCorridorLevelInfo> action = this.EventOnStartMemoryCorridorLevel;
				Action<ConfigDataMemoryCorridorLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataMemoryCorridorLevelInfo>>(ref this.EventOnStartMemoryCorridorLevel, (Action<ConfigDataMemoryCorridorLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartMemoryCorridorLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartMemoryCorridorLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataMemoryCorridorLevelInfo> action = this.EventOnStartMemoryCorridorLevel;
				Action<ConfigDataMemoryCorridorLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataMemoryCorridorLevelInfo>>(ref this.EventOnStartMemoryCorridorLevel, (Action<ConfigDataMemoryCorridorLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x06011ED5 RID: 73429 RVA: 0x004A1EB0 File Offset: 0x004A00B0
		// (set) Token: 0x06011ED6 RID: 73430 RVA: 0x004A1ED0 File Offset: 0x004A00D0
		[DoNotToLua]
		public new MemoryCorridorUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MemoryCorridorUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011ED7 RID: 73431 RVA: 0x004A1EDC File Offset: 0x004A00DC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011ED8 RID: 73432 RVA: 0x004A1EE8 File Offset: 0x004A00E8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011ED9 RID: 73433 RVA: 0x004A1EF0 File Offset: 0x004A00F0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011EDA RID: 73434 RVA: 0x004A1EF8 File Offset: 0x004A00F8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011EDB RID: 73435 RVA: 0x004A1F0C File Offset: 0x004A010C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011EDC RID: 73436 RVA: 0x004A1F14 File Offset: 0x004A0114
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011EDD RID: 73437 RVA: 0x004A1F20 File Offset: 0x004A0120
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011EDE RID: 73438 RVA: 0x004A1F2C File Offset: 0x004A012C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011EDF RID: 73439 RVA: 0x004A1F38 File Offset: 0x004A0138
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011EE0 RID: 73440 RVA: 0x004A1F44 File Offset: 0x004A0144
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011EE1 RID: 73441 RVA: 0x004A1F50 File Offset: 0x004A0150
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011EE2 RID: 73442 RVA: 0x004A1F5C File Offset: 0x004A015C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011EE3 RID: 73443 RVA: 0x004A1F68 File Offset: 0x004A0168
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06011EE4 RID: 73444 RVA: 0x004A1F74 File Offset: 0x004A0174
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011EE5 RID: 73445 RVA: 0x004A1F80 File Offset: 0x004A0180
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011EE6 RID: 73446 RVA: 0x004A1F88 File Offset: 0x004A0188
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06011EE7 RID: 73447 RVA: 0x004A1FA8 File Offset: 0x004A01A8
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06011EE8 RID: 73448 RVA: 0x004A1FB4 File Offset: 0x004A01B4
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x06011EE9 RID: 73449 RVA: 0x004A1FD4 File Offset: 0x004A01D4
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x06011EEA RID: 73450 RVA: 0x004A1FE0 File Offset: 0x004A01E0
		private void __callDele_EventOnAddTicket()
		{
			Action eventOnAddTicket = this.EventOnAddTicket;
			if (eventOnAddTicket != null)
			{
				eventOnAddTicket();
			}
		}

		// Token: 0x06011EEB RID: 73451 RVA: 0x004A2000 File Offset: 0x004A0200
		private void __clearDele_EventOnAddTicket()
		{
			this.EventOnAddTicket = null;
		}

		// Token: 0x06011EEC RID: 73452 RVA: 0x004A200C File Offset: 0x004A020C
		private void __callDele_EventOnShowTeam()
		{
			Action eventOnShowTeam = this.EventOnShowTeam;
			if (eventOnShowTeam != null)
			{
				eventOnShowTeam();
			}
		}

		// Token: 0x06011EED RID: 73453 RVA: 0x004A202C File Offset: 0x004A022C
		private void __clearDele_EventOnShowTeam()
		{
			this.EventOnShowTeam = null;
		}

		// Token: 0x06011EEE RID: 73454 RVA: 0x004A2038 File Offset: 0x004A0238
		private void __callDele_EventOnStartMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo obj)
		{
			Action<ConfigDataMemoryCorridorLevelInfo> eventOnStartMemoryCorridorLevel = this.EventOnStartMemoryCorridorLevel;
			if (eventOnStartMemoryCorridorLevel != null)
			{
				eventOnStartMemoryCorridorLevel(obj);
			}
		}

		// Token: 0x06011EEF RID: 73455 RVA: 0x004A205C File Offset: 0x004A025C
		private void __clearDele_EventOnStartMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo obj)
		{
			this.EventOnStartMemoryCorridorLevel = null;
		}

		// Token: 0x06011EF0 RID: 73456 RVA: 0x004A2068 File Offset: 0x004A0268
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
					this.m_ResetScrollViewToTop_hotfix = (luaObj.RawGet("ResetScrollViewToTop") as LuaFunction);
					this.m_SetMemoryCorridorConfigDataMemoryCorridorInfo_hotfix = (luaObj.RawGet("SetMemoryCorridor") as LuaFunction);
					this.m_AddAllMemoryCorridorLevelListItemsList`1_hotfix = (luaObj.RawGet("AddAllMemoryCorridorLevelListItems") as LuaFunction);
					this.m_AddMemoryCorridorLevelListItemConfigDataMemoryCorridorLevelInfoBoolean_hotfix = (luaObj.RawGet("AddMemoryCorridorLevelListItem") as LuaFunction);
					this.m_ClearMemoryCorridorLevelListItems_hotfix = (luaObj.RawGet("ClearMemoryCorridorLevelListItems") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnAddTicketButtonClick_hotfix = (luaObj.RawGet("OnAddTicketButtonClick") as LuaFunction);
					this.m_OnTeamButtonClick_hotfix = (luaObj.RawGet("OnTeamButtonClick") as LuaFunction);
					this.m_MemoryCorridorLevelListItem_OnStartButtonClickMemoryCorridorLevelListItemUIController_hotfix = (luaObj.RawGet("MemoryCorridorLevelListItem_OnStartButtonClick") as LuaFunction);
					this.m_CreateSpineGraphicConfigDataMemoryCorridorInfo_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_SetDailyRewardCountInt32Int32_hotfix = (luaObj.RawGet("SetDailyRewardCount") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnAddTicketAction_hotfix = (luaObj.RawGet("add_EventOnAddTicket") as LuaFunction);
					this.m_remove_EventOnAddTicketAction_hotfix = (luaObj.RawGet("remove_EventOnAddTicket") as LuaFunction);
					this.m_add_EventOnShowTeamAction_hotfix = (luaObj.RawGet("add_EventOnShowTeam") as LuaFunction);
					this.m_remove_EventOnShowTeamAction_hotfix = (luaObj.RawGet("remove_EventOnShowTeam") as LuaFunction);
					this.m_add_EventOnStartMemoryCorridorLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnStartMemoryCorridorLevel") as LuaFunction);
					this.m_remove_EventOnStartMemoryCorridorLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartMemoryCorridorLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011EF1 RID: 73457 RVA: 0x004A238C File Offset: 0x004A058C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MemoryCorridorUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A2A9 RID: 41641
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A2AA RID: 41642
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400A2AB RID: 41643
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x0400A2AC RID: 41644
		[AutoBind("./OrganizeTeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_teamButton;

		// Token: 0x0400A2AD RID: 41645
		[AutoBind("./PlayerResource/DailyReward/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_dailyRewardCountText;

		// Token: 0x0400A2AE RID: 41646
		[AutoBind("./LevelList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_levelListScrollRect;

		// Token: 0x0400A2AF RID: 41647
		[AutoBind("./Background/Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGo;

		// Token: 0x0400A2B0 RID: 41648
		[AutoBind("./Background/BGLeft", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_backgroundImage;

		// Token: 0x0400A2B1 RID: 41649
		[AutoBind("./Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400A2B2 RID: 41650
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400A2B3 RID: 41651
		[AutoBind("./Prefabs/MemoryCorridorLevelListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_memoryCorridorLevelListItemPrefab;

		// Token: 0x0400A2B4 RID: 41652
		private List<MemoryCorridorLevelListItemUIController> m_memoryCorridorLevelListItems = new List<MemoryCorridorLevelListItemUIController>();

		// Token: 0x0400A2B5 RID: 41653
		private UISpineGraphic m_graphic;

		// Token: 0x0400A2B6 RID: 41654
		[DoNotToLua]
		private MemoryCorridorUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A2B7 RID: 41655
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A2B8 RID: 41656
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A2B9 RID: 41657
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A2BA RID: 41658
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400A2BB RID: 41659
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x0400A2BC RID: 41660
		private LuaFunction m_SetMemoryCorridorConfigDataMemoryCorridorInfo_hotfix;

		// Token: 0x0400A2BD RID: 41661
		private LuaFunction m_AddAllMemoryCorridorLevelListItemsList;

		// Token: 0x0400A2BE RID: 41662
		private LuaFunction m_AddMemoryCorridorLevelListItemConfigDataMemoryCorridorLevelInfoBoolean_hotfix;

		// Token: 0x0400A2BF RID: 41663
		private LuaFunction m_ClearMemoryCorridorLevelListItems_hotfix;

		// Token: 0x0400A2C0 RID: 41664
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400A2C1 RID: 41665
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x0400A2C2 RID: 41666
		private LuaFunction m_OnAddTicketButtonClick_hotfix;

		// Token: 0x0400A2C3 RID: 41667
		private LuaFunction m_OnTeamButtonClick_hotfix;

		// Token: 0x0400A2C4 RID: 41668
		private LuaFunction m_MemoryCorridorLevelListItem_OnStartButtonClickMemoryCorridorLevelListItemUIController_hotfix;

		// Token: 0x0400A2C5 RID: 41669
		private LuaFunction m_CreateSpineGraphicConfigDataMemoryCorridorInfo_hotfix;

		// Token: 0x0400A2C6 RID: 41670
		private LuaFunction m_DestroySpineGraphic_hotfix;

		// Token: 0x0400A2C7 RID: 41671
		private LuaFunction m_SetDailyRewardCountInt32Int32_hotfix;

		// Token: 0x0400A2C8 RID: 41672
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400A2C9 RID: 41673
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400A2CA RID: 41674
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x0400A2CB RID: 41675
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x0400A2CC RID: 41676
		private LuaFunction m_add_EventOnAddTicketAction_hotfix;

		// Token: 0x0400A2CD RID: 41677
		private LuaFunction m_remove_EventOnAddTicketAction_hotfix;

		// Token: 0x0400A2CE RID: 41678
		private LuaFunction m_add_EventOnShowTeamAction_hotfix;

		// Token: 0x0400A2CF RID: 41679
		private LuaFunction m_remove_EventOnShowTeamAction_hotfix;

		// Token: 0x0400A2D0 RID: 41680
		private LuaFunction m_add_EventOnStartMemoryCorridorLevelAction;

		// Token: 0x0400A2D1 RID: 41681
		private LuaFunction m_remove_EventOnStartMemoryCorridorLevelAction;

		// Token: 0x02000E72 RID: 3698
		public new class LuaExportHelper
		{
			// Token: 0x06011EF2 RID: 73458 RVA: 0x004A23F4 File Offset: 0x004A05F4
			public LuaExportHelper(MemoryCorridorUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011EF3 RID: 73459 RVA: 0x004A2404 File Offset: 0x004A0604
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011EF4 RID: 73460 RVA: 0x004A2414 File Offset: 0x004A0614
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011EF5 RID: 73461 RVA: 0x004A2424 File Offset: 0x004A0624
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011EF6 RID: 73462 RVA: 0x004A2434 File Offset: 0x004A0634
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011EF7 RID: 73463 RVA: 0x004A244C File Offset: 0x004A064C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011EF8 RID: 73464 RVA: 0x004A245C File Offset: 0x004A065C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011EF9 RID: 73465 RVA: 0x004A246C File Offset: 0x004A066C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011EFA RID: 73466 RVA: 0x004A247C File Offset: 0x004A067C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011EFB RID: 73467 RVA: 0x004A248C File Offset: 0x004A068C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011EFC RID: 73468 RVA: 0x004A249C File Offset: 0x004A069C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011EFD RID: 73469 RVA: 0x004A24AC File Offset: 0x004A06AC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011EFE RID: 73470 RVA: 0x004A24BC File Offset: 0x004A06BC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011EFF RID: 73471 RVA: 0x004A24CC File Offset: 0x004A06CC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011F00 RID: 73472 RVA: 0x004A24DC File Offset: 0x004A06DC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011F01 RID: 73473 RVA: 0x004A24EC File Offset: 0x004A06EC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011F02 RID: 73474 RVA: 0x004A24FC File Offset: 0x004A06FC
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06011F03 RID: 73475 RVA: 0x004A250C File Offset: 0x004A070C
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06011F04 RID: 73476 RVA: 0x004A251C File Offset: 0x004A071C
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x06011F05 RID: 73477 RVA: 0x004A252C File Offset: 0x004A072C
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x06011F06 RID: 73478 RVA: 0x004A253C File Offset: 0x004A073C
			public void __callDele_EventOnAddTicket()
			{
				this.m_owner.__callDele_EventOnAddTicket();
			}

			// Token: 0x06011F07 RID: 73479 RVA: 0x004A254C File Offset: 0x004A074C
			public void __clearDele_EventOnAddTicket()
			{
				this.m_owner.__clearDele_EventOnAddTicket();
			}

			// Token: 0x06011F08 RID: 73480 RVA: 0x004A255C File Offset: 0x004A075C
			public void __callDele_EventOnShowTeam()
			{
				this.m_owner.__callDele_EventOnShowTeam();
			}

			// Token: 0x06011F09 RID: 73481 RVA: 0x004A256C File Offset: 0x004A076C
			public void __clearDele_EventOnShowTeam()
			{
				this.m_owner.__clearDele_EventOnShowTeam();
			}

			// Token: 0x06011F0A RID: 73482 RVA: 0x004A257C File Offset: 0x004A077C
			public void __callDele_EventOnStartMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnStartMemoryCorridorLevel(obj);
			}

			// Token: 0x06011F0B RID: 73483 RVA: 0x004A258C File Offset: 0x004A078C
			public void __clearDele_EventOnStartMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartMemoryCorridorLevel(obj);
			}

			// Token: 0x170036D0 RID: 14032
			// (get) Token: 0x06011F0C RID: 73484 RVA: 0x004A259C File Offset: 0x004A079C
			// (set) Token: 0x06011F0D RID: 73485 RVA: 0x004A25AC File Offset: 0x004A07AC
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

			// Token: 0x170036D1 RID: 14033
			// (get) Token: 0x06011F0E RID: 73486 RVA: 0x004A25BC File Offset: 0x004A07BC
			// (set) Token: 0x06011F0F RID: 73487 RVA: 0x004A25CC File Offset: 0x004A07CC
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

			// Token: 0x170036D2 RID: 14034
			// (get) Token: 0x06011F10 RID: 73488 RVA: 0x004A25DC File Offset: 0x004A07DC
			// (set) Token: 0x06011F11 RID: 73489 RVA: 0x004A25EC File Offset: 0x004A07EC
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

			// Token: 0x170036D3 RID: 14035
			// (get) Token: 0x06011F12 RID: 73490 RVA: 0x004A25FC File Offset: 0x004A07FC
			// (set) Token: 0x06011F13 RID: 73491 RVA: 0x004A260C File Offset: 0x004A080C
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

			// Token: 0x170036D4 RID: 14036
			// (get) Token: 0x06011F14 RID: 73492 RVA: 0x004A261C File Offset: 0x004A081C
			// (set) Token: 0x06011F15 RID: 73493 RVA: 0x004A262C File Offset: 0x004A082C
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

			// Token: 0x170036D5 RID: 14037
			// (get) Token: 0x06011F16 RID: 73494 RVA: 0x004A263C File Offset: 0x004A083C
			// (set) Token: 0x06011F17 RID: 73495 RVA: 0x004A264C File Offset: 0x004A084C
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

			// Token: 0x170036D6 RID: 14038
			// (get) Token: 0x06011F18 RID: 73496 RVA: 0x004A265C File Offset: 0x004A085C
			// (set) Token: 0x06011F19 RID: 73497 RVA: 0x004A266C File Offset: 0x004A086C
			public GameObject m_charGo
			{
				get
				{
					return this.m_owner.m_charGo;
				}
				set
				{
					this.m_owner.m_charGo = value;
				}
			}

			// Token: 0x170036D7 RID: 14039
			// (get) Token: 0x06011F1A RID: 73498 RVA: 0x004A267C File Offset: 0x004A087C
			// (set) Token: 0x06011F1B RID: 73499 RVA: 0x004A268C File Offset: 0x004A088C
			public Image m_backgroundImage
			{
				get
				{
					return this.m_owner.m_backgroundImage;
				}
				set
				{
					this.m_owner.m_backgroundImage = value;
				}
			}

			// Token: 0x170036D8 RID: 14040
			// (get) Token: 0x06011F1C RID: 73500 RVA: 0x004A269C File Offset: 0x004A089C
			// (set) Token: 0x06011F1D RID: 73501 RVA: 0x004A26AC File Offset: 0x004A08AC
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

			// Token: 0x170036D9 RID: 14041
			// (get) Token: 0x06011F1E RID: 73502 RVA: 0x004A26BC File Offset: 0x004A08BC
			// (set) Token: 0x06011F1F RID: 73503 RVA: 0x004A26CC File Offset: 0x004A08CC
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

			// Token: 0x170036DA RID: 14042
			// (get) Token: 0x06011F20 RID: 73504 RVA: 0x004A26DC File Offset: 0x004A08DC
			// (set) Token: 0x06011F21 RID: 73505 RVA: 0x004A26EC File Offset: 0x004A08EC
			public GameObject m_memoryCorridorLevelListItemPrefab
			{
				get
				{
					return this.m_owner.m_memoryCorridorLevelListItemPrefab;
				}
				set
				{
					this.m_owner.m_memoryCorridorLevelListItemPrefab = value;
				}
			}

			// Token: 0x170036DB RID: 14043
			// (get) Token: 0x06011F22 RID: 73506 RVA: 0x004A26FC File Offset: 0x004A08FC
			// (set) Token: 0x06011F23 RID: 73507 RVA: 0x004A270C File Offset: 0x004A090C
			public List<MemoryCorridorLevelListItemUIController> m_memoryCorridorLevelListItems
			{
				get
				{
					return this.m_owner.m_memoryCorridorLevelListItems;
				}
				set
				{
					this.m_owner.m_memoryCorridorLevelListItems = value;
				}
			}

			// Token: 0x170036DC RID: 14044
			// (get) Token: 0x06011F24 RID: 73508 RVA: 0x004A271C File Offset: 0x004A091C
			// (set) Token: 0x06011F25 RID: 73509 RVA: 0x004A272C File Offset: 0x004A092C
			public UISpineGraphic m_graphic
			{
				get
				{
					return this.m_owner.m_graphic;
				}
				set
				{
					this.m_owner.m_graphic = value;
				}
			}

			// Token: 0x06011F26 RID: 73510 RVA: 0x004A273C File Offset: 0x004A093C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011F27 RID: 73511 RVA: 0x004A274C File Offset: 0x004A094C
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x06011F28 RID: 73512 RVA: 0x004A275C File Offset: 0x004A095C
			public void AddMemoryCorridorLevelListItem(ConfigDataMemoryCorridorLevelInfo levelnfo, bool opened)
			{
				this.m_owner.AddMemoryCorridorLevelListItem(levelnfo, opened);
			}

			// Token: 0x06011F29 RID: 73513 RVA: 0x004A276C File Offset: 0x004A096C
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06011F2A RID: 73514 RVA: 0x004A277C File Offset: 0x004A097C
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x06011F2B RID: 73515 RVA: 0x004A278C File Offset: 0x004A098C
			public void OnAddTicketButtonClick()
			{
				this.m_owner.OnAddTicketButtonClick();
			}

			// Token: 0x06011F2C RID: 73516 RVA: 0x004A279C File Offset: 0x004A099C
			public void OnTeamButtonClick()
			{
				this.m_owner.OnTeamButtonClick();
			}

			// Token: 0x06011F2D RID: 73517 RVA: 0x004A27AC File Offset: 0x004A09AC
			public void MemoryCorridorLevelListItem_OnStartButtonClick(MemoryCorridorLevelListItemUIController ctrl)
			{
				this.m_owner.MemoryCorridorLevelListItem_OnStartButtonClick(ctrl);
			}

			// Token: 0x06011F2E RID: 73518 RVA: 0x004A27BC File Offset: 0x004A09BC
			public void CreateSpineGraphic(ConfigDataMemoryCorridorInfo memoryCorridorInfo)
			{
				this.m_owner.CreateSpineGraphic(memoryCorridorInfo);
			}

			// Token: 0x06011F2F RID: 73519 RVA: 0x004A27CC File Offset: 0x004A09CC
			public void DestroySpineGraphic()
			{
				this.m_owner.DestroySpineGraphic();
			}

			// Token: 0x0400A2D2 RID: 41682
			private MemoryCorridorUIController m_owner;
		}
	}
}
