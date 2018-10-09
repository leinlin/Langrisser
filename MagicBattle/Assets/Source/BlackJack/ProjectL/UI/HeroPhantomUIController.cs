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
	// Token: 0x02000E1E RID: 3614
	[HotFix]
	public class HeroPhantomUIController : UIControllerBase
	{
		// Token: 0x06011674 RID: 71284 RVA: 0x00482BB0 File Offset: 0x00480DB0
		private HeroPhantomUIController()
		{
		}

		// Token: 0x06011675 RID: 71285 RVA: 0x00482BD0 File Offset: 0x00480DD0
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
			this.m_achievementUIStateController.gameObject.SetActive(false);
			this.m_achievementBackgroundButton.onClick.AddListener(new UnityAction(this.OnAchievementBackgroundButtonClick));
			this.m_prefabsGameObject.SetActive(false);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06011676 RID: 71286 RVA: 0x00482CB4 File Offset: 0x00480EB4
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

		// Token: 0x06011677 RID: 71287 RVA: 0x00482D30 File Offset: 0x00480F30
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

		// Token: 0x06011678 RID: 71288 RVA: 0x00482DA0 File Offset: 0x00480FA0
		public void SetHeroPhantom(ConfigDataHeroPhantomInfo heroPhantomInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroPhantomConfigDataHeroPhantomInfo_hotfix != null)
			{
				this.m_SetHeroPhantomConfigDataHeroPhantomInfo_hotfix.call(new object[]
				{
					this,
					heroPhantomInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CreateSpineGraphic(heroPhantomInfo);
		}

		// Token: 0x06011679 RID: 71289 RVA: 0x00482E18 File Offset: 0x00481018
		public void AddAllHeroPhantomLevelListItems(List<ConfigDataHeroPhantomLevelInfo> levelInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddAllHeroPhantomLevelListItemsList`1_hotfix != null)
			{
				this.m_AddAllHeroPhantomLevelListItemsList`1_hotfix.call(new object[]
				{
					this,
					levelInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo in levelInfos)
			{
				this.AddHeroPhantomLevelListItem(configDataHeroPhantomLevelInfo, projectLPlayerContext.IsHeroPhantomLevelOpened(configDataHeroPhantomLevelInfo.ID));
			}
		}

		// Token: 0x0601167A RID: 71290 RVA: 0x00482EF0 File Offset: 0x004810F0
		private void AddHeroPhantomLevelListItem(ConfigDataHeroPhantomLevelInfo levelnfo, bool opened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroPhantomLevelListItemConfigDataHeroPhantomLevelInfoBoolean_hotfix != null)
			{
				this.m_AddHeroPhantomLevelListItemConfigDataHeroPhantomLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelnfo,
					opened
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_heroPhantomLevelListItemPrefab, this.m_levelListScrollRect.content, false);
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = GameObjectUtility.AddControllerToGameObject<HeroPhantomLevelListItemUIController>(go);
			heroPhantomLevelListItemUIController.SetHeroPhantomLevelInfo(levelnfo);
			heroPhantomLevelListItemUIController.SetLocked(!opened);
			heroPhantomLevelListItemUIController.EventOnStartButtonClick += this.HeroPhantomLevelListItem_OnStartButtonClick;
			heroPhantomLevelListItemUIController.EventOnAchievementButtonClick += this.HeroPhantomLevelListItem_OnAchievementButtonClick;
			this.m_heroPhantomLevelListItems.Add(heroPhantomLevelListItemUIController);
		}

		// Token: 0x0601167B RID: 71291 RVA: 0x00482FD0 File Offset: 0x004811D0
		public void ClearHeroPhantomLevelListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearHeroPhantomLevelListItems_hotfix != null)
			{
				this.m_ClearHeroPhantomLevelListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<HeroPhantomLevelListItemUIController>(this.m_heroPhantomLevelListItems);
			this.m_heroPhantomLevelListItems.Clear();
		}

		// Token: 0x0601167C RID: 71292 RVA: 0x00483048 File Offset: 0x00481248
		private void CreateSpineGraphic(ConfigDataHeroPhantomInfo heroPhantomInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicConfigDataHeroPhantomInfo_hotfix != null)
			{
				this.m_CreateSpineGraphicConfigDataHeroPhantomInfo_hotfix.call(new object[]
				{
					this,
					heroPhantomInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic();
			if (heroPhantomInfo == null)
			{
				return;
			}
			float num = (float)heroPhantomInfo.UI_ModelScale * 0.01f;
			Vector2 position = new Vector2((float)heroPhantomInfo.UI_ModelOffsetX, (float)heroPhantomInfo.UI_ModelOffsetY);
			this.m_graphic = new UISpineGraphic();
			this.m_graphic.Create(heroPhantomInfo.Model);
			this.m_graphic.SetParent(this.m_charGo);
			this.m_graphic.SetDirection(-1);
			this.m_graphic.SetPosition(position);
			this.m_graphic.SetScale(num);
			this.m_graphic.SetRectTransformSize(new Vector2(500f / num, 500f / num));
			this.m_graphic.PlayAnimation("idle_Normal", true, 0);
			this.m_graphic.ForceUpdate();
		}

		// Token: 0x0601167D RID: 71293 RVA: 0x00483178 File Offset: 0x00481378
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

		// Token: 0x0601167E RID: 71294 RVA: 0x004831F8 File Offset: 0x004813F8
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

		// Token: 0x0601167F RID: 71295 RVA: 0x00483270 File Offset: 0x00481470
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
			if (this.EventOnHelp != null)
			{
				this.EventOnHelp();
			}
		}

		// Token: 0x06011680 RID: 71296 RVA: 0x004832E8 File Offset: 0x004814E8
		private void HeroPhantomLevelListItem_OnStartButtonClick(HeroPhantomLevelListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroPhantomLevelListItem_OnStartButtonClickHeroPhantomLevelListItemUIController_hotfix != null)
			{
				this.m_HeroPhantomLevelListItem_OnStartButtonClickHeroPhantomLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartHeroPhantomLevel != null)
			{
				this.EventOnStartHeroPhantomLevel(ctrl.GetHeroPhantomLevelInfo());
			}
		}

		// Token: 0x06011681 RID: 71297 RVA: 0x00483374 File Offset: 0x00481574
		private void OnAchievementBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAchievementBackgroundButtonClick_hotfix != null)
			{
				this.m_OnAchievementBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_achievementUIStateController, "Close", null, false, true);
		}

		// Token: 0x06011682 RID: 71298 RVA: 0x004833E8 File Offset: 0x004815E8
		private void HeroPhantomLevelListItem_OnAchievementButtonClick(HeroPhantomLevelListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroPhantomLevelListItem_OnAchievementButtonClickHeroPhantomLevelListItemUIController_hotfix != null)
			{
				this.m_HeroPhantomLevelListItem_OnAchievementButtonClickHeroPhantomLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroPhantomLevelInfo heroPhantomLevelInfo = ctrl.GetHeroPhantomLevelInfo();
			if (heroPhantomLevelInfo != null && heroPhantomLevelInfo.m_achievements != null && heroPhantomLevelInfo.m_achievements.Length > 0)
			{
				this.ShowAchievement(heroPhantomLevelInfo.m_achievements, heroPhantomLevelInfo);
			}
		}

		// Token: 0x06011683 RID: 71299 RVA: 0x0048348C File Offset: 0x0048168C
		private void ShowAchievement(BattleLevelAchievement[] achievements, ConfigDataHeroPhantomLevelInfo heroPhantomLevelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowAchievementBattleLevelAchievementbeConfigDataHeroPhantomLevelInfo_hotfix != null)
			{
				this.m_ShowAchievementBattleLevelAchievementbeConfigDataHeroPhantomLevelInfo_hotfix.call(new object[]
				{
					this,
					achievements,
					heroPhantomLevelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearAchievementItems();
			if (achievements == null || achievements.Length <= 0)
			{
				return;
			}
			UIUtility.SetUIStateOpen(this.m_achievementUIStateController, "Open", null, false, true);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("BattleAchievementItem");
			for (int i = 0; i < 2; i++)
			{
				foreach (BattleLevelAchievement battleLevelAchievement in achievements)
				{
					bool flag = projectLPlayerContext.IsCompleteHeroPhantomLevelAchievement(battleLevelAchievement.m_achievementRelatedInfo.ID);
					if (flag == (i == 1))
					{
						this.AddAchievementItem(battleLevelAchievement.m_achievementRelatedInfo.m_achievementInfo, battleLevelAchievement.m_rewards, assetInContainer, flag);
					}
				}
			}
			this.m_achievementScrollRect.verticalNormalizedPosition = 1f;
		}

		// Token: 0x06011684 RID: 71300 RVA: 0x004835D0 File Offset: 0x004817D0
		private void AddAchievementItem(ConfigDataBattleAchievementInfo achievementInfo, List<Goods> rewards, GameObject prefab, bool complete)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddAchievementItemConfigDataBattleAchievementInfoList`1GameObjectBoolean_hotfix != null)
			{
				this.m_AddAchievementItemConfigDataBattleAchievementInfoList`1GameObjectBoolean_hotfix.call(new object[]
				{
					this,
					achievementInfo,
					rewards,
					prefab,
					complete
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(prefab, this.m_achievementScrollRect.content, false);
			BattleAchievementItemUIController battleAchievementItemUIController = GameObjectUtility.AddControllerToGameObject<BattleAchievementItemUIController>(go);
			battleAchievementItemUIController.SetAchievement(achievementInfo);
			battleAchievementItemUIController.SetRewards(rewards);
			battleAchievementItemUIController.SetComplete(complete);
			this.m_achievementItems.Add(battleAchievementItemUIController);
		}

		// Token: 0x06011685 RID: 71301 RVA: 0x004836AC File Offset: 0x004818AC
		private void ClearAchievementItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAchievementItems_hotfix != null)
			{
				this.m_ClearAchievementItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<BattleAchievementItemUIController>(this.m_achievementItems);
			this.m_achievementItems.Clear();
		}

		// Token: 0x140003BD RID: 957
		// (add) Token: 0x06011686 RID: 71302 RVA: 0x00483724 File Offset: 0x00481924
		// (remove) Token: 0x06011687 RID: 71303 RVA: 0x004837C0 File Offset: 0x004819C0
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

		// Token: 0x140003BE RID: 958
		// (add) Token: 0x06011688 RID: 71304 RVA: 0x0048385C File Offset: 0x00481A5C
		// (remove) Token: 0x06011689 RID: 71305 RVA: 0x004838F8 File Offset: 0x00481AF8
		public event Action EventOnHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHelpAction_hotfix != null)
				{
					this.m_add_EventOnHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHelpAction_hotfix != null)
				{
					this.m_remove_EventOnHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003BF RID: 959
		// (add) Token: 0x0601168A RID: 71306 RVA: 0x00483994 File Offset: 0x00481B94
		// (remove) Token: 0x0601168B RID: 71307 RVA: 0x00483A30 File Offset: 0x00481C30
		public event Action<ConfigDataHeroPhantomLevelInfo> EventOnStartHeroPhantomLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartHeroPhantomLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnStartHeroPhantomLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataHeroPhantomLevelInfo> action = this.EventOnStartHeroPhantomLevel;
				Action<ConfigDataHeroPhantomLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataHeroPhantomLevelInfo>>(ref this.EventOnStartHeroPhantomLevel, (Action<ConfigDataHeroPhantomLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartHeroPhantomLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartHeroPhantomLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataHeroPhantomLevelInfo> action = this.EventOnStartHeroPhantomLevel;
				Action<ConfigDataHeroPhantomLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataHeroPhantomLevelInfo>>(ref this.EventOnStartHeroPhantomLevel, (Action<ConfigDataHeroPhantomLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0601168C RID: 71308 RVA: 0x00483ACC File Offset: 0x00481CCC
		// (set) Token: 0x0601168D RID: 71309 RVA: 0x00483AEC File Offset: 0x00481CEC
		[DoNotToLua]
		public new HeroPhantomUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroPhantomUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601168E RID: 71310 RVA: 0x00483AF8 File Offset: 0x00481CF8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601168F RID: 71311 RVA: 0x00483B04 File Offset: 0x00481D04
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011690 RID: 71312 RVA: 0x00483B0C File Offset: 0x00481D0C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011691 RID: 71313 RVA: 0x00483B14 File Offset: 0x00481D14
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011692 RID: 71314 RVA: 0x00483B28 File Offset: 0x00481D28
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011693 RID: 71315 RVA: 0x00483B30 File Offset: 0x00481D30
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011694 RID: 71316 RVA: 0x00483B3C File Offset: 0x00481D3C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011695 RID: 71317 RVA: 0x00483B48 File Offset: 0x00481D48
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011696 RID: 71318 RVA: 0x00483B54 File Offset: 0x00481D54
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011697 RID: 71319 RVA: 0x00483B60 File Offset: 0x00481D60
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011698 RID: 71320 RVA: 0x00483B6C File Offset: 0x00481D6C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011699 RID: 71321 RVA: 0x00483B78 File Offset: 0x00481D78
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601169A RID: 71322 RVA: 0x00483B84 File Offset: 0x00481D84
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601169B RID: 71323 RVA: 0x00483B90 File Offset: 0x00481D90
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601169C RID: 71324 RVA: 0x00483B9C File Offset: 0x00481D9C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601169D RID: 71325 RVA: 0x00483BA4 File Offset: 0x00481DA4
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0601169E RID: 71326 RVA: 0x00483BC4 File Offset: 0x00481DC4
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0601169F RID: 71327 RVA: 0x00483BD0 File Offset: 0x00481DD0
		private void __callDele_EventOnHelp()
		{
			Action eventOnHelp = this.EventOnHelp;
			if (eventOnHelp != null)
			{
				eventOnHelp();
			}
		}

		// Token: 0x060116A0 RID: 71328 RVA: 0x00483BF0 File Offset: 0x00481DF0
		private void __clearDele_EventOnHelp()
		{
			this.EventOnHelp = null;
		}

		// Token: 0x060116A1 RID: 71329 RVA: 0x00483BFC File Offset: 0x00481DFC
		private void __callDele_EventOnStartHeroPhantomLevel(ConfigDataHeroPhantomLevelInfo obj)
		{
			Action<ConfigDataHeroPhantomLevelInfo> eventOnStartHeroPhantomLevel = this.EventOnStartHeroPhantomLevel;
			if (eventOnStartHeroPhantomLevel != null)
			{
				eventOnStartHeroPhantomLevel(obj);
			}
		}

		// Token: 0x060116A2 RID: 71330 RVA: 0x00483C20 File Offset: 0x00481E20
		private void __clearDele_EventOnStartHeroPhantomLevel(ConfigDataHeroPhantomLevelInfo obj)
		{
			this.EventOnStartHeroPhantomLevel = null;
		}

		// Token: 0x060116A3 RID: 71331 RVA: 0x00483C2C File Offset: 0x00481E2C
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
					this.m_SetHeroPhantomConfigDataHeroPhantomInfo_hotfix = (luaObj.RawGet("SetHeroPhantom") as LuaFunction);
					this.m_AddAllHeroPhantomLevelListItemsList`1_hotfix = (luaObj.RawGet("AddAllHeroPhantomLevelListItems") as LuaFunction);
					this.m_AddHeroPhantomLevelListItemConfigDataHeroPhantomLevelInfoBoolean_hotfix = (luaObj.RawGet("AddHeroPhantomLevelListItem") as LuaFunction);
					this.m_ClearHeroPhantomLevelListItems_hotfix = (luaObj.RawGet("ClearHeroPhantomLevelListItems") as LuaFunction);
					this.m_CreateSpineGraphicConfigDataHeroPhantomInfo_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_HeroPhantomLevelListItem_OnStartButtonClickHeroPhantomLevelListItemUIController_hotfix = (luaObj.RawGet("HeroPhantomLevelListItem_OnStartButtonClick") as LuaFunction);
					this.m_OnAchievementBackgroundButtonClick_hotfix = (luaObj.RawGet("OnAchievementBackgroundButtonClick") as LuaFunction);
					this.m_HeroPhantomLevelListItem_OnAchievementButtonClickHeroPhantomLevelListItemUIController_hotfix = (luaObj.RawGet("HeroPhantomLevelListItem_OnAchievementButtonClick") as LuaFunction);
					this.m_ShowAchievementBattleLevelAchievementbeConfigDataHeroPhantomLevelInfo_hotfix = (luaObj.RawGet("ShowAchievement") as LuaFunction);
					this.m_AddAchievementItemConfigDataBattleAchievementInfoList`1GameObjectBoolean_hotfix = (luaObj.RawGet("AddAchievementItem") as LuaFunction);
					this.m_ClearAchievementItems_hotfix = (luaObj.RawGet("ClearAchievementItems") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnHelpAction_hotfix = (luaObj.RawGet("add_EventOnHelp") as LuaFunction);
					this.m_remove_EventOnHelpAction_hotfix = (luaObj.RawGet("remove_EventOnHelp") as LuaFunction);
					this.m_add_EventOnStartHeroPhantomLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnStartHeroPhantomLevel") as LuaFunction);
					this.m_remove_EventOnStartHeroPhantomLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartHeroPhantomLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060116A4 RID: 71332 RVA: 0x00483F20 File Offset: 0x00482120
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPhantomUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009F30 RID: 40752
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04009F31 RID: 40753
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04009F32 RID: 40754
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04009F33 RID: 40755
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04009F34 RID: 40756
		[AutoBind("./Margin/LevelList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_levelListScrollRect;

		// Token: 0x04009F35 RID: 40757
		[AutoBind("./Background/Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGo;

		// Token: 0x04009F36 RID: 40758
		[AutoBind("./Achievement", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_achievementUIStateController;

		// Token: 0x04009F37 RID: 40759
		[AutoBind("./Achievement/Panel/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_achievementScrollRect;

		// Token: 0x04009F38 RID: 40760
		[AutoBind("./Achievement/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_achievementBackgroundButton;

		// Token: 0x04009F39 RID: 40761
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04009F3A RID: 40762
		[AutoBind("./Prefabs/PhantomButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroPhantomLevelListItemPrefab;

		// Token: 0x04009F3B RID: 40763
		private List<HeroPhantomLevelListItemUIController> m_heroPhantomLevelListItems = new List<HeroPhantomLevelListItemUIController>();

		// Token: 0x04009F3C RID: 40764
		private List<BattleAchievementItemUIController> m_achievementItems = new List<BattleAchievementItemUIController>();

		// Token: 0x04009F3D RID: 40765
		private UISpineGraphic m_graphic;

		// Token: 0x04009F3E RID: 40766
		[DoNotToLua]
		private HeroPhantomUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009F3F RID: 40767
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009F40 RID: 40768
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009F41 RID: 40769
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009F42 RID: 40770
		private LuaFunction m_Open_hotfix;

		// Token: 0x04009F43 RID: 40771
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x04009F44 RID: 40772
		private LuaFunction m_SetHeroPhantomConfigDataHeroPhantomInfo_hotfix;

		// Token: 0x04009F45 RID: 40773
		private LuaFunction m_AddAllHeroPhantomLevelListItemsList;

		// Token: 0x04009F46 RID: 40774
		private LuaFunction m_AddHeroPhantomLevelListItemConfigDataHeroPhantomLevelInfoBoolean_hotfix;

		// Token: 0x04009F47 RID: 40775
		private LuaFunction m_ClearHeroPhantomLevelListItems_hotfix;

		// Token: 0x04009F48 RID: 40776
		private LuaFunction m_CreateSpineGraphicConfigDataHeroPhantomInfo_hotfix;

		// Token: 0x04009F49 RID: 40777
		private LuaFunction m_DestroySpineGraphic_hotfix;

		// Token: 0x04009F4A RID: 40778
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04009F4B RID: 40779
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04009F4C RID: 40780
		private LuaFunction m_HeroPhantomLevelListItem_OnStartButtonClickHeroPhantomLevelListItemUIController_hotfix;

		// Token: 0x04009F4D RID: 40781
		private LuaFunction m_OnAchievementBackgroundButtonClick_hotfix;

		// Token: 0x04009F4E RID: 40782
		private LuaFunction m_HeroPhantomLevelListItem_OnAchievementButtonClickHeroPhantomLevelListItemUIController_hotfix;

		// Token: 0x04009F4F RID: 40783
		private LuaFunction m_ShowAchievementBattleLevelAchievementbeConfigDataHeroPhantomLevelInfo_hotfix;

		// Token: 0x04009F50 RID: 40784
		private LuaFunction m_AddAchievementItemConfigDataBattleAchievementInfoList;

		// Token: 0x04009F51 RID: 40785
		private LuaFunction m_ClearAchievementItems_hotfix;

		// Token: 0x04009F52 RID: 40786
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04009F53 RID: 40787
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04009F54 RID: 40788
		private LuaFunction m_add_EventOnHelpAction_hotfix;

		// Token: 0x04009F55 RID: 40789
		private LuaFunction m_remove_EventOnHelpAction_hotfix;

		// Token: 0x04009F56 RID: 40790
		private LuaFunction m_add_EventOnStartHeroPhantomLevelAction;

		// Token: 0x04009F57 RID: 40791
		private LuaFunction m_remove_EventOnStartHeroPhantomLevelAction;

		// Token: 0x02000E1F RID: 3615
		public new class LuaExportHelper
		{
			// Token: 0x060116A5 RID: 71333 RVA: 0x00483F88 File Offset: 0x00482188
			public LuaExportHelper(HeroPhantomUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060116A6 RID: 71334 RVA: 0x00483F98 File Offset: 0x00482198
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060116A7 RID: 71335 RVA: 0x00483FA8 File Offset: 0x004821A8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060116A8 RID: 71336 RVA: 0x00483FB8 File Offset: 0x004821B8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060116A9 RID: 71337 RVA: 0x00483FC8 File Offset: 0x004821C8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060116AA RID: 71338 RVA: 0x00483FE0 File Offset: 0x004821E0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060116AB RID: 71339 RVA: 0x00483FF0 File Offset: 0x004821F0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060116AC RID: 71340 RVA: 0x00484000 File Offset: 0x00482200
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060116AD RID: 71341 RVA: 0x00484010 File Offset: 0x00482210
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060116AE RID: 71342 RVA: 0x00484020 File Offset: 0x00482220
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060116AF RID: 71343 RVA: 0x00484030 File Offset: 0x00482230
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060116B0 RID: 71344 RVA: 0x00484040 File Offset: 0x00482240
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060116B1 RID: 71345 RVA: 0x00484050 File Offset: 0x00482250
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060116B2 RID: 71346 RVA: 0x00484060 File Offset: 0x00482260
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060116B3 RID: 71347 RVA: 0x00484070 File Offset: 0x00482270
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060116B4 RID: 71348 RVA: 0x00484080 File Offset: 0x00482280
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060116B5 RID: 71349 RVA: 0x00484090 File Offset: 0x00482290
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x060116B6 RID: 71350 RVA: 0x004840A0 File Offset: 0x004822A0
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x060116B7 RID: 71351 RVA: 0x004840B0 File Offset: 0x004822B0
			public void __callDele_EventOnHelp()
			{
				this.m_owner.__callDele_EventOnHelp();
			}

			// Token: 0x060116B8 RID: 71352 RVA: 0x004840C0 File Offset: 0x004822C0
			public void __clearDele_EventOnHelp()
			{
				this.m_owner.__clearDele_EventOnHelp();
			}

			// Token: 0x060116B9 RID: 71353 RVA: 0x004840D0 File Offset: 0x004822D0
			public void __callDele_EventOnStartHeroPhantomLevel(ConfigDataHeroPhantomLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnStartHeroPhantomLevel(obj);
			}

			// Token: 0x060116BA RID: 71354 RVA: 0x004840E0 File Offset: 0x004822E0
			public void __clearDele_EventOnStartHeroPhantomLevel(ConfigDataHeroPhantomLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartHeroPhantomLevel(obj);
			}

			// Token: 0x1700359A RID: 13722
			// (get) Token: 0x060116BB RID: 71355 RVA: 0x004840F0 File Offset: 0x004822F0
			// (set) Token: 0x060116BC RID: 71356 RVA: 0x00484100 File Offset: 0x00482300
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x1700359B RID: 13723
			// (get) Token: 0x060116BD RID: 71357 RVA: 0x00484110 File Offset: 0x00482310
			// (set) Token: 0x060116BE RID: 71358 RVA: 0x00484120 File Offset: 0x00482320
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

			// Token: 0x1700359C RID: 13724
			// (get) Token: 0x060116BF RID: 71359 RVA: 0x00484130 File Offset: 0x00482330
			// (set) Token: 0x060116C0 RID: 71360 RVA: 0x00484140 File Offset: 0x00482340
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

			// Token: 0x1700359D RID: 13725
			// (get) Token: 0x060116C1 RID: 71361 RVA: 0x00484150 File Offset: 0x00482350
			// (set) Token: 0x060116C2 RID: 71362 RVA: 0x00484160 File Offset: 0x00482360
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

			// Token: 0x1700359E RID: 13726
			// (get) Token: 0x060116C3 RID: 71363 RVA: 0x00484170 File Offset: 0x00482370
			// (set) Token: 0x060116C4 RID: 71364 RVA: 0x00484180 File Offset: 0x00482380
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

			// Token: 0x1700359F RID: 13727
			// (get) Token: 0x060116C5 RID: 71365 RVA: 0x00484190 File Offset: 0x00482390
			// (set) Token: 0x060116C6 RID: 71366 RVA: 0x004841A0 File Offset: 0x004823A0
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

			// Token: 0x170035A0 RID: 13728
			// (get) Token: 0x060116C7 RID: 71367 RVA: 0x004841B0 File Offset: 0x004823B0
			// (set) Token: 0x060116C8 RID: 71368 RVA: 0x004841C0 File Offset: 0x004823C0
			public CommonUIStateController m_achievementUIStateController
			{
				get
				{
					return this.m_owner.m_achievementUIStateController;
				}
				set
				{
					this.m_owner.m_achievementUIStateController = value;
				}
			}

			// Token: 0x170035A1 RID: 13729
			// (get) Token: 0x060116C9 RID: 71369 RVA: 0x004841D0 File Offset: 0x004823D0
			// (set) Token: 0x060116CA RID: 71370 RVA: 0x004841E0 File Offset: 0x004823E0
			public ScrollRect m_achievementScrollRect
			{
				get
				{
					return this.m_owner.m_achievementScrollRect;
				}
				set
				{
					this.m_owner.m_achievementScrollRect = value;
				}
			}

			// Token: 0x170035A2 RID: 13730
			// (get) Token: 0x060116CB RID: 71371 RVA: 0x004841F0 File Offset: 0x004823F0
			// (set) Token: 0x060116CC RID: 71372 RVA: 0x00484200 File Offset: 0x00482400
			public Button m_achievementBackgroundButton
			{
				get
				{
					return this.m_owner.m_achievementBackgroundButton;
				}
				set
				{
					this.m_owner.m_achievementBackgroundButton = value;
				}
			}

			// Token: 0x170035A3 RID: 13731
			// (get) Token: 0x060116CD RID: 71373 RVA: 0x00484210 File Offset: 0x00482410
			// (set) Token: 0x060116CE RID: 71374 RVA: 0x00484220 File Offset: 0x00482420
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

			// Token: 0x170035A4 RID: 13732
			// (get) Token: 0x060116CF RID: 71375 RVA: 0x00484230 File Offset: 0x00482430
			// (set) Token: 0x060116D0 RID: 71376 RVA: 0x00484240 File Offset: 0x00482440
			public GameObject m_heroPhantomLevelListItemPrefab
			{
				get
				{
					return this.m_owner.m_heroPhantomLevelListItemPrefab;
				}
				set
				{
					this.m_owner.m_heroPhantomLevelListItemPrefab = value;
				}
			}

			// Token: 0x170035A5 RID: 13733
			// (get) Token: 0x060116D1 RID: 71377 RVA: 0x00484250 File Offset: 0x00482450
			// (set) Token: 0x060116D2 RID: 71378 RVA: 0x00484260 File Offset: 0x00482460
			public List<HeroPhantomLevelListItemUIController> m_heroPhantomLevelListItems
			{
				get
				{
					return this.m_owner.m_heroPhantomLevelListItems;
				}
				set
				{
					this.m_owner.m_heroPhantomLevelListItems = value;
				}
			}

			// Token: 0x170035A6 RID: 13734
			// (get) Token: 0x060116D3 RID: 71379 RVA: 0x00484270 File Offset: 0x00482470
			// (set) Token: 0x060116D4 RID: 71380 RVA: 0x00484280 File Offset: 0x00482480
			public List<BattleAchievementItemUIController> m_achievementItems
			{
				get
				{
					return this.m_owner.m_achievementItems;
				}
				set
				{
					this.m_owner.m_achievementItems = value;
				}
			}

			// Token: 0x170035A7 RID: 13735
			// (get) Token: 0x060116D5 RID: 71381 RVA: 0x00484290 File Offset: 0x00482490
			// (set) Token: 0x060116D6 RID: 71382 RVA: 0x004842A0 File Offset: 0x004824A0
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

			// Token: 0x060116D7 RID: 71383 RVA: 0x004842B0 File Offset: 0x004824B0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060116D8 RID: 71384 RVA: 0x004842C0 File Offset: 0x004824C0
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x060116D9 RID: 71385 RVA: 0x004842D0 File Offset: 0x004824D0
			public void AddHeroPhantomLevelListItem(ConfigDataHeroPhantomLevelInfo levelnfo, bool opened)
			{
				this.m_owner.AddHeroPhantomLevelListItem(levelnfo, opened);
			}

			// Token: 0x060116DA RID: 71386 RVA: 0x004842E0 File Offset: 0x004824E0
			public void CreateSpineGraphic(ConfigDataHeroPhantomInfo heroPhantomInfo)
			{
				this.m_owner.CreateSpineGraphic(heroPhantomInfo);
			}

			// Token: 0x060116DB RID: 71387 RVA: 0x004842F0 File Offset: 0x004824F0
			public void DestroySpineGraphic()
			{
				this.m_owner.DestroySpineGraphic();
			}

			// Token: 0x060116DC RID: 71388 RVA: 0x00484300 File Offset: 0x00482500
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x060116DD RID: 71389 RVA: 0x00484310 File Offset: 0x00482510
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x060116DE RID: 71390 RVA: 0x00484320 File Offset: 0x00482520
			public void HeroPhantomLevelListItem_OnStartButtonClick(HeroPhantomLevelListItemUIController ctrl)
			{
				this.m_owner.HeroPhantomLevelListItem_OnStartButtonClick(ctrl);
			}

			// Token: 0x060116DF RID: 71391 RVA: 0x00484330 File Offset: 0x00482530
			public void OnAchievementBackgroundButtonClick()
			{
				this.m_owner.OnAchievementBackgroundButtonClick();
			}

			// Token: 0x060116E0 RID: 71392 RVA: 0x00484340 File Offset: 0x00482540
			public void HeroPhantomLevelListItem_OnAchievementButtonClick(HeroPhantomLevelListItemUIController ctrl)
			{
				this.m_owner.HeroPhantomLevelListItem_OnAchievementButtonClick(ctrl);
			}

			// Token: 0x060116E1 RID: 71393 RVA: 0x00484350 File Offset: 0x00482550
			public void ShowAchievement(BattleLevelAchievement[] achievements, ConfigDataHeroPhantomLevelInfo heroPhantomLevelInfo)
			{
				this.m_owner.ShowAchievement(achievements, heroPhantomLevelInfo);
			}

			// Token: 0x060116E2 RID: 71394 RVA: 0x00484360 File Offset: 0x00482560
			public void AddAchievementItem(ConfigDataBattleAchievementInfo achievementInfo, List<Goods> rewards, GameObject prefab, bool complete)
			{
				this.m_owner.AddAchievementItem(achievementInfo, rewards, prefab, complete);
			}

			// Token: 0x060116E3 RID: 71395 RVA: 0x00484374 File Offset: 0x00482574
			public void ClearAchievementItems()
			{
				this.m_owner.ClearAchievementItems();
			}

			// Token: 0x04009F58 RID: 40792
			private HeroPhantomUIController m_owner;
		}
	}
}
