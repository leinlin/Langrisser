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
	// Token: 0x02000E26 RID: 3622
	[HotFix]
	public class HeroTrainningUIController : UIControllerBase
	{
		// Token: 0x0601179E RID: 71582 RVA: 0x00486598 File Offset: 0x00484798
		private HeroTrainningUIController()
		{
		}

		// Token: 0x0601179F RID: 71583 RVA: 0x004865AC File Offset: 0x004847AC
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

		// Token: 0x060117A0 RID: 71584 RVA: 0x00486674 File Offset: 0x00484874
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

		// Token: 0x060117A1 RID: 71585 RVA: 0x004866F0 File Offset: 0x004848F0
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

		// Token: 0x060117A2 RID: 71586 RVA: 0x00486760 File Offset: 0x00484960
		public void AddAllHeroTrainningLevelListItems(List<ConfigDataHeroTrainningLevelInfo> levelInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddAllHeroTrainningLevelListItemsList`1_hotfix != null)
			{
				this.m_AddAllHeroTrainningLevelListItemsList`1_hotfix.call(new object[]
				{
					this,
					levelInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo in levelInfos)
			{
				this.AddHeroTrainningLevelListItem(configDataHeroTrainningLevelInfo, projectLPlayerContext.IsHeroTrainningLevelOpened(configDataHeroTrainningLevelInfo.ID));
			}
		}

		// Token: 0x060117A3 RID: 71587 RVA: 0x00486838 File Offset: 0x00484A38
		private void AddHeroTrainningLevelListItem(ConfigDataHeroTrainningLevelInfo levelnfo, bool opened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroTrainningLevelListItemConfigDataHeroTrainningLevelInfoBoolean_hotfix != null)
			{
				this.m_AddHeroTrainningLevelListItemConfigDataHeroTrainningLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelnfo,
					opened
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_heroTrainningLevelListItemPrefab, this.m_levelListScrollRect.content, false);
			HeroTrainningLevelListItemUIController heroTrainningLevelListItemUIController = GameObjectUtility.AddControllerToGameObject<HeroTrainningLevelListItemUIController>(go);
			heroTrainningLevelListItemUIController.SetHeroTrainningLevelInfo(levelnfo);
			heroTrainningLevelListItemUIController.SetLocked(!opened);
			heroTrainningLevelListItemUIController.EventOnStartButtonClick += this.HeroTrainningLevelListItem_OnStartButtonClick;
			this.m_heroTrainningLevelListItems.Add(heroTrainningLevelListItemUIController);
		}

		// Token: 0x060117A4 RID: 71588 RVA: 0x00486908 File Offset: 0x00484B08
		public void ClearHeroTrainningLevelListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearHeroTrainningLevelListItems_hotfix != null)
			{
				this.m_ClearHeroTrainningLevelListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<HeroTrainningLevelListItemUIController>(this.m_heroTrainningLevelListItems);
			this.m_heroTrainningLevelListItems.Clear();
		}

		// Token: 0x060117A5 RID: 71589 RVA: 0x00486980 File Offset: 0x00484B80
		public void SetHeroTrainning(ConfigDataHeroTrainningInfo heroTrainningInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroTrainningConfigDataHeroTrainningInfo_hotfix != null)
			{
				this.m_SetHeroTrainningConfigDataHeroTrainningInfo_hotfix.call(new object[]
				{
					this,
					heroTrainningInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CreateSpineGraphic(heroTrainningInfo);
		}

		// Token: 0x060117A6 RID: 71590 RVA: 0x004869F8 File Offset: 0x00484BF8
		private void CreateSpineGraphic(ConfigDataHeroTrainningInfo heroTrainningInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicConfigDataHeroTrainningInfo_hotfix != null)
			{
				this.m_CreateSpineGraphicConfigDataHeroTrainningInfo_hotfix.call(new object[]
				{
					this,
					heroTrainningInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic();
			if (heroTrainningInfo == null)
			{
				return;
			}
			float num = (float)heroTrainningInfo.UI_ModelScale * 0.01f;
			Vector2 position = new Vector2((float)heroTrainningInfo.UI_ModelOffsetX, (float)heroTrainningInfo.UI_ModelOffsetY);
			this.m_graphic = new UISpineGraphic();
			this.m_graphic.Create(heroTrainningInfo.Model);
			this.m_graphic.SetParent(this.m_charGo);
			this.m_graphic.SetDirection(1);
			this.m_graphic.SetPosition(position);
			this.m_graphic.SetScale(num);
			this.m_graphic.SetRectTransformSize(new Vector2(500f / num, 500f / num));
			this.m_graphic.PlayAnimation("idle_Normal", true, 0);
			this.m_graphic.ForceUpdate();
		}

		// Token: 0x060117A7 RID: 71591 RVA: 0x00486B28 File Offset: 0x00484D28
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

		// Token: 0x060117A8 RID: 71592 RVA: 0x00486BA8 File Offset: 0x00484DA8
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

		// Token: 0x060117A9 RID: 71593 RVA: 0x00486C38 File Offset: 0x00484E38
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

		// Token: 0x060117AA RID: 71594 RVA: 0x00486CB0 File Offset: 0x00484EB0
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

		// Token: 0x060117AB RID: 71595 RVA: 0x00486D28 File Offset: 0x00484F28
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

		// Token: 0x060117AC RID: 71596 RVA: 0x00486DA0 File Offset: 0x00484FA0
		private void HeroTrainningLevelListItem_OnStartButtonClick(HeroTrainningLevelListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroTrainningLevelListItem_OnStartButtonClickHeroTrainningLevelListItemUIController_hotfix != null)
			{
				this.m_HeroTrainningLevelListItem_OnStartButtonClickHeroTrainningLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartHeroTrainningLevel != null)
			{
				this.EventOnStartHeroTrainningLevel(ctrl.GetHeroTrainningLevelInfo());
			}
		}

		// Token: 0x140003C2 RID: 962
		// (add) Token: 0x060117AD RID: 71597 RVA: 0x00486E2C File Offset: 0x0048502C
		// (remove) Token: 0x060117AE RID: 71598 RVA: 0x00486EC8 File Offset: 0x004850C8
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

		// Token: 0x140003C3 RID: 963
		// (add) Token: 0x060117AF RID: 71599 RVA: 0x00486F64 File Offset: 0x00485164
		// (remove) Token: 0x060117B0 RID: 71600 RVA: 0x00487000 File Offset: 0x00485200
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

		// Token: 0x140003C4 RID: 964
		// (add) Token: 0x060117B1 RID: 71601 RVA: 0x0048709C File Offset: 0x0048529C
		// (remove) Token: 0x060117B2 RID: 71602 RVA: 0x00487138 File Offset: 0x00485338
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

		// Token: 0x140003C5 RID: 965
		// (add) Token: 0x060117B3 RID: 71603 RVA: 0x004871D4 File Offset: 0x004853D4
		// (remove) Token: 0x060117B4 RID: 71604 RVA: 0x00487270 File Offset: 0x00485470
		public event Action<ConfigDataHeroTrainningLevelInfo> EventOnStartHeroTrainningLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartHeroTrainningLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnStartHeroTrainningLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataHeroTrainningLevelInfo> action = this.EventOnStartHeroTrainningLevel;
				Action<ConfigDataHeroTrainningLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataHeroTrainningLevelInfo>>(ref this.EventOnStartHeroTrainningLevel, (Action<ConfigDataHeroTrainningLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartHeroTrainningLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartHeroTrainningLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataHeroTrainningLevelInfo> action = this.EventOnStartHeroTrainningLevel;
				Action<ConfigDataHeroTrainningLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataHeroTrainningLevelInfo>>(ref this.EventOnStartHeroTrainningLevel, (Action<ConfigDataHeroTrainningLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x060117B5 RID: 71605 RVA: 0x0048730C File Offset: 0x0048550C
		// (set) Token: 0x060117B6 RID: 71606 RVA: 0x0048732C File Offset: 0x0048552C
		[DoNotToLua]
		public new HeroTrainningUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroTrainningUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060117B7 RID: 71607 RVA: 0x00487338 File Offset: 0x00485538
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060117B8 RID: 71608 RVA: 0x00487344 File Offset: 0x00485544
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060117B9 RID: 71609 RVA: 0x0048734C File Offset: 0x0048554C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060117BA RID: 71610 RVA: 0x00487354 File Offset: 0x00485554
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060117BB RID: 71611 RVA: 0x00487368 File Offset: 0x00485568
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060117BC RID: 71612 RVA: 0x00487370 File Offset: 0x00485570
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060117BD RID: 71613 RVA: 0x0048737C File Offset: 0x0048557C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060117BE RID: 71614 RVA: 0x00487388 File Offset: 0x00485588
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060117BF RID: 71615 RVA: 0x00487394 File Offset: 0x00485594
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060117C0 RID: 71616 RVA: 0x004873A0 File Offset: 0x004855A0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060117C1 RID: 71617 RVA: 0x004873AC File Offset: 0x004855AC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060117C2 RID: 71618 RVA: 0x004873B8 File Offset: 0x004855B8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060117C3 RID: 71619 RVA: 0x004873C4 File Offset: 0x004855C4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060117C4 RID: 71620 RVA: 0x004873D0 File Offset: 0x004855D0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060117C5 RID: 71621 RVA: 0x004873DC File Offset: 0x004855DC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060117C6 RID: 71622 RVA: 0x004873E4 File Offset: 0x004855E4
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x060117C7 RID: 71623 RVA: 0x00487404 File Offset: 0x00485604
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x060117C8 RID: 71624 RVA: 0x00487410 File Offset: 0x00485610
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x060117C9 RID: 71625 RVA: 0x00487430 File Offset: 0x00485630
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x060117CA RID: 71626 RVA: 0x0048743C File Offset: 0x0048563C
		private void __callDele_EventOnShowTeam()
		{
			Action eventOnShowTeam = this.EventOnShowTeam;
			if (eventOnShowTeam != null)
			{
				eventOnShowTeam();
			}
		}

		// Token: 0x060117CB RID: 71627 RVA: 0x0048745C File Offset: 0x0048565C
		private void __clearDele_EventOnShowTeam()
		{
			this.EventOnShowTeam = null;
		}

		// Token: 0x060117CC RID: 71628 RVA: 0x00487468 File Offset: 0x00485668
		private void __callDele_EventOnStartHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo obj)
		{
			Action<ConfigDataHeroTrainningLevelInfo> eventOnStartHeroTrainningLevel = this.EventOnStartHeroTrainningLevel;
			if (eventOnStartHeroTrainningLevel != null)
			{
				eventOnStartHeroTrainningLevel(obj);
			}
		}

		// Token: 0x060117CD RID: 71629 RVA: 0x0048748C File Offset: 0x0048568C
		private void __clearDele_EventOnStartHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo obj)
		{
			this.EventOnStartHeroTrainningLevel = null;
		}

		// Token: 0x060117CE RID: 71630 RVA: 0x00487498 File Offset: 0x00485698
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
					this.m_AddAllHeroTrainningLevelListItemsList`1_hotfix = (luaObj.RawGet("AddAllHeroTrainningLevelListItems") as LuaFunction);
					this.m_AddHeroTrainningLevelListItemConfigDataHeroTrainningLevelInfoBoolean_hotfix = (luaObj.RawGet("AddHeroTrainningLevelListItem") as LuaFunction);
					this.m_ClearHeroTrainningLevelListItems_hotfix = (luaObj.RawGet("ClearHeroTrainningLevelListItems") as LuaFunction);
					this.m_SetHeroTrainningConfigDataHeroTrainningInfo_hotfix = (luaObj.RawGet("SetHeroTrainning") as LuaFunction);
					this.m_CreateSpineGraphicConfigDataHeroTrainningInfo_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_SetDailyRewardCountInt32Int32_hotfix = (luaObj.RawGet("SetDailyRewardCount") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnTeamButtonClick_hotfix = (luaObj.RawGet("OnTeamButtonClick") as LuaFunction);
					this.m_HeroTrainningLevelListItem_OnStartButtonClickHeroTrainningLevelListItemUIController_hotfix = (luaObj.RawGet("HeroTrainningLevelListItem_OnStartButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnShowTeamAction_hotfix = (luaObj.RawGet("add_EventOnShowTeam") as LuaFunction);
					this.m_remove_EventOnShowTeamAction_hotfix = (luaObj.RawGet("remove_EventOnShowTeam") as LuaFunction);
					this.m_add_EventOnStartHeroTrainningLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnStartHeroTrainningLevel") as LuaFunction);
					this.m_remove_EventOnStartHeroTrainningLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartHeroTrainningLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060117CF RID: 71631 RVA: 0x00487770 File Offset: 0x00485970
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroTrainningUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009F96 RID: 40854
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04009F97 RID: 40855
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04009F98 RID: 40856
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04009F99 RID: 40857
		[AutoBind("./OrganizeTeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_teamButton;

		// Token: 0x04009F9A RID: 40858
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGo;

		// Token: 0x04009F9B RID: 40859
		[AutoBind("./TrainingList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_levelListScrollRect;

		// Token: 0x04009F9C RID: 40860
		[AutoBind("./PlayerResource/DailyReward/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_dailyRewardCountText;

		// Token: 0x04009F9D RID: 40861
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04009F9E RID: 40862
		[AutoBind("./Prefabs/HeroTrainingLevelListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroTrainningLevelListItemPrefab;

		// Token: 0x04009F9F RID: 40863
		private UISpineGraphic m_graphic;

		// Token: 0x04009FA0 RID: 40864
		private List<HeroTrainningLevelListItemUIController> m_heroTrainningLevelListItems = new List<HeroTrainningLevelListItemUIController>();

		// Token: 0x04009FA1 RID: 40865
		[DoNotToLua]
		private HeroTrainningUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009FA2 RID: 40866
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009FA3 RID: 40867
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009FA4 RID: 40868
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009FA5 RID: 40869
		private LuaFunction m_Open_hotfix;

		// Token: 0x04009FA6 RID: 40870
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x04009FA7 RID: 40871
		private LuaFunction m_AddAllHeroTrainningLevelListItemsList;

		// Token: 0x04009FA8 RID: 40872
		private LuaFunction m_AddHeroTrainningLevelListItemConfigDataHeroTrainningLevelInfoBoolean_hotfix;

		// Token: 0x04009FA9 RID: 40873
		private LuaFunction m_ClearHeroTrainningLevelListItems_hotfix;

		// Token: 0x04009FAA RID: 40874
		private LuaFunction m_SetHeroTrainningConfigDataHeroTrainningInfo_hotfix;

		// Token: 0x04009FAB RID: 40875
		private LuaFunction m_CreateSpineGraphicConfigDataHeroTrainningInfo_hotfix;

		// Token: 0x04009FAC RID: 40876
		private LuaFunction m_DestroySpineGraphic_hotfix;

		// Token: 0x04009FAD RID: 40877
		private LuaFunction m_SetDailyRewardCountInt32Int32_hotfix;

		// Token: 0x04009FAE RID: 40878
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04009FAF RID: 40879
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04009FB0 RID: 40880
		private LuaFunction m_OnTeamButtonClick_hotfix;

		// Token: 0x04009FB1 RID: 40881
		private LuaFunction m_HeroTrainningLevelListItem_OnStartButtonClickHeroTrainningLevelListItemUIController_hotfix;

		// Token: 0x04009FB2 RID: 40882
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04009FB3 RID: 40883
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04009FB4 RID: 40884
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04009FB5 RID: 40885
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04009FB6 RID: 40886
		private LuaFunction m_add_EventOnShowTeamAction_hotfix;

		// Token: 0x04009FB7 RID: 40887
		private LuaFunction m_remove_EventOnShowTeamAction_hotfix;

		// Token: 0x04009FB8 RID: 40888
		private LuaFunction m_add_EventOnStartHeroTrainningLevelAction;

		// Token: 0x04009FB9 RID: 40889
		private LuaFunction m_remove_EventOnStartHeroTrainningLevelAction;

		// Token: 0x02000E27 RID: 3623
		public new class LuaExportHelper
		{
			// Token: 0x060117D0 RID: 71632 RVA: 0x004877D8 File Offset: 0x004859D8
			public LuaExportHelper(HeroTrainningUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060117D1 RID: 71633 RVA: 0x004877E8 File Offset: 0x004859E8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060117D2 RID: 71634 RVA: 0x004877F8 File Offset: 0x004859F8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060117D3 RID: 71635 RVA: 0x00487808 File Offset: 0x00485A08
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060117D4 RID: 71636 RVA: 0x00487818 File Offset: 0x00485A18
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060117D5 RID: 71637 RVA: 0x00487830 File Offset: 0x00485A30
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060117D6 RID: 71638 RVA: 0x00487840 File Offset: 0x00485A40
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060117D7 RID: 71639 RVA: 0x00487850 File Offset: 0x00485A50
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060117D8 RID: 71640 RVA: 0x00487860 File Offset: 0x00485A60
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060117D9 RID: 71641 RVA: 0x00487870 File Offset: 0x00485A70
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060117DA RID: 71642 RVA: 0x00487880 File Offset: 0x00485A80
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060117DB RID: 71643 RVA: 0x00487890 File Offset: 0x00485A90
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060117DC RID: 71644 RVA: 0x004878A0 File Offset: 0x00485AA0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060117DD RID: 71645 RVA: 0x004878B0 File Offset: 0x00485AB0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060117DE RID: 71646 RVA: 0x004878C0 File Offset: 0x00485AC0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060117DF RID: 71647 RVA: 0x004878D0 File Offset: 0x00485AD0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060117E0 RID: 71648 RVA: 0x004878E0 File Offset: 0x00485AE0
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x060117E1 RID: 71649 RVA: 0x004878F0 File Offset: 0x00485AF0
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x060117E2 RID: 71650 RVA: 0x00487900 File Offset: 0x00485B00
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x060117E3 RID: 71651 RVA: 0x00487910 File Offset: 0x00485B10
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x060117E4 RID: 71652 RVA: 0x00487920 File Offset: 0x00485B20
			public void __callDele_EventOnShowTeam()
			{
				this.m_owner.__callDele_EventOnShowTeam();
			}

			// Token: 0x060117E5 RID: 71653 RVA: 0x00487930 File Offset: 0x00485B30
			public void __clearDele_EventOnShowTeam()
			{
				this.m_owner.__clearDele_EventOnShowTeam();
			}

			// Token: 0x060117E6 RID: 71654 RVA: 0x00487940 File Offset: 0x00485B40
			public void __callDele_EventOnStartHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnStartHeroTrainningLevel(obj);
			}

			// Token: 0x060117E7 RID: 71655 RVA: 0x00487950 File Offset: 0x00485B50
			public void __clearDele_EventOnStartHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartHeroTrainningLevel(obj);
			}

			// Token: 0x170035C0 RID: 13760
			// (get) Token: 0x060117E8 RID: 71656 RVA: 0x00487960 File Offset: 0x00485B60
			// (set) Token: 0x060117E9 RID: 71657 RVA: 0x00487970 File Offset: 0x00485B70
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

			// Token: 0x170035C1 RID: 13761
			// (get) Token: 0x060117EA RID: 71658 RVA: 0x00487980 File Offset: 0x00485B80
			// (set) Token: 0x060117EB RID: 71659 RVA: 0x00487990 File Offset: 0x00485B90
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

			// Token: 0x170035C2 RID: 13762
			// (get) Token: 0x060117EC RID: 71660 RVA: 0x004879A0 File Offset: 0x00485BA0
			// (set) Token: 0x060117ED RID: 71661 RVA: 0x004879B0 File Offset: 0x00485BB0
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

			// Token: 0x170035C3 RID: 13763
			// (get) Token: 0x060117EE RID: 71662 RVA: 0x004879C0 File Offset: 0x00485BC0
			// (set) Token: 0x060117EF RID: 71663 RVA: 0x004879D0 File Offset: 0x00485BD0
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

			// Token: 0x170035C4 RID: 13764
			// (get) Token: 0x060117F0 RID: 71664 RVA: 0x004879E0 File Offset: 0x00485BE0
			// (set) Token: 0x060117F1 RID: 71665 RVA: 0x004879F0 File Offset: 0x00485BF0
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

			// Token: 0x170035C5 RID: 13765
			// (get) Token: 0x060117F2 RID: 71666 RVA: 0x00487A00 File Offset: 0x00485C00
			// (set) Token: 0x060117F3 RID: 71667 RVA: 0x00487A10 File Offset: 0x00485C10
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

			// Token: 0x170035C6 RID: 13766
			// (get) Token: 0x060117F4 RID: 71668 RVA: 0x00487A20 File Offset: 0x00485C20
			// (set) Token: 0x060117F5 RID: 71669 RVA: 0x00487A30 File Offset: 0x00485C30
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

			// Token: 0x170035C7 RID: 13767
			// (get) Token: 0x060117F6 RID: 71670 RVA: 0x00487A40 File Offset: 0x00485C40
			// (set) Token: 0x060117F7 RID: 71671 RVA: 0x00487A50 File Offset: 0x00485C50
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

			// Token: 0x170035C8 RID: 13768
			// (get) Token: 0x060117F8 RID: 71672 RVA: 0x00487A60 File Offset: 0x00485C60
			// (set) Token: 0x060117F9 RID: 71673 RVA: 0x00487A70 File Offset: 0x00485C70
			public GameObject m_heroTrainningLevelListItemPrefab
			{
				get
				{
					return this.m_owner.m_heroTrainningLevelListItemPrefab;
				}
				set
				{
					this.m_owner.m_heroTrainningLevelListItemPrefab = value;
				}
			}

			// Token: 0x170035C9 RID: 13769
			// (get) Token: 0x060117FA RID: 71674 RVA: 0x00487A80 File Offset: 0x00485C80
			// (set) Token: 0x060117FB RID: 71675 RVA: 0x00487A90 File Offset: 0x00485C90
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

			// Token: 0x170035CA RID: 13770
			// (get) Token: 0x060117FC RID: 71676 RVA: 0x00487AA0 File Offset: 0x00485CA0
			// (set) Token: 0x060117FD RID: 71677 RVA: 0x00487AB0 File Offset: 0x00485CB0
			public List<HeroTrainningLevelListItemUIController> m_heroTrainningLevelListItems
			{
				get
				{
					return this.m_owner.m_heroTrainningLevelListItems;
				}
				set
				{
					this.m_owner.m_heroTrainningLevelListItems = value;
				}
			}

			// Token: 0x060117FE RID: 71678 RVA: 0x00487AC0 File Offset: 0x00485CC0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060117FF RID: 71679 RVA: 0x00487AD0 File Offset: 0x00485CD0
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x06011800 RID: 71680 RVA: 0x00487AE0 File Offset: 0x00485CE0
			public void AddHeroTrainningLevelListItem(ConfigDataHeroTrainningLevelInfo levelnfo, bool opened)
			{
				this.m_owner.AddHeroTrainningLevelListItem(levelnfo, opened);
			}

			// Token: 0x06011801 RID: 71681 RVA: 0x00487AF0 File Offset: 0x00485CF0
			public void CreateSpineGraphic(ConfigDataHeroTrainningInfo heroTrainningInfo)
			{
				this.m_owner.CreateSpineGraphic(heroTrainningInfo);
			}

			// Token: 0x06011802 RID: 71682 RVA: 0x00487B00 File Offset: 0x00485D00
			public void DestroySpineGraphic()
			{
				this.m_owner.DestroySpineGraphic();
			}

			// Token: 0x06011803 RID: 71683 RVA: 0x00487B10 File Offset: 0x00485D10
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06011804 RID: 71684 RVA: 0x00487B20 File Offset: 0x00485D20
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x06011805 RID: 71685 RVA: 0x00487B30 File Offset: 0x00485D30
			public void OnTeamButtonClick()
			{
				this.m_owner.OnTeamButtonClick();
			}

			// Token: 0x06011806 RID: 71686 RVA: 0x00487B40 File Offset: 0x00485D40
			public void HeroTrainningLevelListItem_OnStartButtonClick(HeroTrainningLevelListItemUIController ctrl)
			{
				this.m_owner.HeroTrainningLevelListItem_OnStartButtonClick(ctrl);
			}

			// Token: 0x04009FBA RID: 40890
			private HeroTrainningUIController m_owner;
		}
	}
}
