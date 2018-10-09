using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
	// Token: 0x02000FC2 RID: 4034
	[HotFix]
	public class ThearchyUIController : UIControllerBase
	{
		// Token: 0x06014234 RID: 82484 RVA: 0x00520E38 File Offset: 0x0051F038
		private ThearchyUIController()
		{
		}

		// Token: 0x06014235 RID: 82485 RVA: 0x00520E4C File Offset: 0x0051F04C
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

		// Token: 0x06014236 RID: 82486 RVA: 0x00520F14 File Offset: 0x0051F114
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

		// Token: 0x06014237 RID: 82487 RVA: 0x00520F90 File Offset: 0x0051F190
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

		// Token: 0x06014238 RID: 82488 RVA: 0x00521000 File Offset: 0x0051F200
		public void SetThearchy(ConfigDataThearchyTrialInfo thearchyInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetThearchyConfigDataThearchyTrialInfo_hotfix != null)
			{
				this.m_SetThearchyConfigDataThearchyTrialInfo_hotfix.call(new object[]
				{
					this,
					thearchyInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CreateSpineGraphic(thearchyInfo);
			this.CreateBackgroundFx(thearchyInfo);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (thearchyInfo.Armys_ID.Count > 0)
			{
				this.m_armyPanelGameObject.SetActive(true);
				for (int i = 0; i < thearchyInfo.Armys_ID.Count; i++)
				{
					ConfigDataArmyInfo configDataArmyInfo = configDataLoader.GetConfigDataArmyInfo(thearchyInfo.Armys_ID[i]);
					if (this.m_armyPanelGroup.childCount <= i)
					{
						UnityEngine.Object.Instantiate<GameObject>(this.m_armyPanelGroup.GetChild(0).gameObject, this.m_armyPanelGroup, false);
					}
					this.m_armyPanelGroup.GetChild(i).gameObject.SetActive(true);
					this.m_armyPanelGroup.GetChild(i).GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
				}
				for (int j = thearchyInfo.Armys_ID.Count; j < this.m_armyPanelGroup.childCount; j++)
				{
					this.m_armyPanelGroup.GetChild(j).gameObject.SetActive(false);
				}
			}
			else
			{
				this.m_armyPanelGameObject.SetActive(false);
			}
		}

		// Token: 0x06014239 RID: 82489 RVA: 0x0052119C File Offset: 0x0051F39C
		public void SetAllThearchyLevelListItems(List<ConfigDataThearchyTrialLevelInfo> levelInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAllThearchyLevelListItemsList`1_hotfix != null)
			{
				this.m_SetAllThearchyLevelListItemsList`1_hotfix.call(new object[]
				{
					this,
					levelInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearThearchyLevelListItems();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo in levelInfos)
			{
				this.AddThearchyLevelListItem(configDataThearchyTrialLevelInfo, projectLPlayerContext.IsThearchyLevelOpened(configDataThearchyTrialLevelInfo.ID));
			}
		}

		// Token: 0x0601423A RID: 82490 RVA: 0x00521278 File Offset: 0x0051F478
		private void AddThearchyLevelListItem(ConfigDataThearchyTrialLevelInfo levelnfo, bool opened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddThearchyLevelListItemConfigDataThearchyTrialLevelInfoBoolean_hotfix != null)
			{
				this.m_AddThearchyLevelListItemConfigDataThearchyTrialLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelnfo,
					opened
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_ThearchyLevelListItemPrefab);
			gameObject.transform.SetParent(this.m_levelListScrollRect.content, false);
			ThearchyLevelListItemUIController thearchyLevelListItemUIController = GameObjectUtility.AddControllerToGameObject<ThearchyLevelListItemUIController>(gameObject);
			thearchyLevelListItemUIController.SetThearchyLevelInfo(levelnfo);
			thearchyLevelListItemUIController.SetLocked(!opened);
			thearchyLevelListItemUIController.EventOnStartButtonClick += this.ThearchyLevelListItem_OnStartButtonClick;
			this.m_thearchyLevelListItems.Add(thearchyLevelListItemUIController);
		}

		// Token: 0x0601423B RID: 82491 RVA: 0x00521354 File Offset: 0x0051F554
		private void ClearThearchyLevelListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearThearchyLevelListItems_hotfix != null)
			{
				this.m_ClearThearchyLevelListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<ThearchyLevelListItemUIController>(this.m_thearchyLevelListItems);
			this.m_thearchyLevelListItems.Clear();
		}

		// Token: 0x0601423C RID: 82492 RVA: 0x005213CC File Offset: 0x0051F5CC
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

		// Token: 0x0601423D RID: 82493 RVA: 0x00521444 File Offset: 0x0051F644
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

		// Token: 0x0601423E RID: 82494 RVA: 0x005214BC File Offset: 0x0051F6BC
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

		// Token: 0x0601423F RID: 82495 RVA: 0x00521534 File Offset: 0x0051F734
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

		// Token: 0x06014240 RID: 82496 RVA: 0x005215AC File Offset: 0x0051F7AC
		private void ThearchyLevelListItem_OnStartButtonClick(ThearchyLevelListItemUIController b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ThearchyLevelListItem_OnStartButtonClickThearchyLevelListItemUIController_hotfix != null)
			{
				this.m_ThearchyLevelListItem_OnStartButtonClickThearchyLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.CanAttackThearchyLevel(b.GetThearchyLevelInfo().ID) == 0)
			{
				base.StartCoroutine(this.PlayGodModelSingEffect(b));
			}
			else if (this.EventOnStartThearchyLevel != null)
			{
				this.EventOnStartThearchyLevel(b.GetThearchyLevelInfo());
			}
		}

		// Token: 0x06014241 RID: 82497 RVA: 0x00521674 File Offset: 0x0051F874
		[DebuggerHidden]
		private IEnumerator PlayGodModelSingEffect(ThearchyLevelListItemUIController b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayGodModelSingEffectThearchyLevelListItemUIController_hotfix != null)
			{
				return (IEnumerator)this.m_PlayGodModelSingEffectThearchyLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					b
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ThearchyUIController.<PlayGodModelSingEffect>c__Iterator0 <PlayGodModelSingEffect>c__Iterator = new ThearchyUIController.<PlayGodModelSingEffect>c__Iterator0();
			<PlayGodModelSingEffect>c__Iterator.b = b;
			<PlayGodModelSingEffect>c__Iterator.$this = this;
			return <PlayGodModelSingEffect>c__Iterator;
		}

		// Token: 0x06014242 RID: 82498 RVA: 0x00521708 File Offset: 0x0051F908
		private void CreateSpineGraphic(ConfigDataThearchyTrialInfo thearchyInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicConfigDataThearchyTrialInfo_hotfix != null)
			{
				this.m_CreateSpineGraphicConfigDataThearchyTrialInfo_hotfix.call(new object[]
				{
					this,
					thearchyInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic();
			if (thearchyInfo == null)
			{
				return;
			}
			float num = (float)thearchyInfo.UI_ModelScale * 0.01f;
			Vector2 position = new Vector2((float)thearchyInfo.UI_ModelOffsetX, (float)thearchyInfo.UI_ModelOffsetY);
			this.m_graphic = new UISpineGraphic();
			this.m_graphic.Create(thearchyInfo.Model);
			this.m_graphic.SetParent(this.m_charGo);
			this.m_graphic.SetDirection(1);
			this.m_graphic.SetPosition(position);
			this.m_graphic.SetScale(num);
			this.m_graphic.SetRectTransformSize(new Vector2(500f / num, 500f / num));
			this.m_graphic.PlayAnimation("idle", true, 0);
			this.m_graphic.ForceUpdate();
		}

		// Token: 0x06014243 RID: 82499 RVA: 0x00521838 File Offset: 0x0051FA38
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

		// Token: 0x06014244 RID: 82500 RVA: 0x005218B8 File Offset: 0x0051FAB8
		private void CreateBackgroundFx(ConfigDataThearchyTrialInfo thearchyInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateBackgroundFxConfigDataThearchyTrialInfo_hotfix != null)
			{
				this.m_CreateBackgroundFxConfigDataThearchyTrialInfo_hotfix.call(new object[]
				{
					this,
					thearchyInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyBackgroundFx();
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(thearchyInfo.Fx);
			if (asset == null)
			{
				return;
			}
			this.m_backgroundFxGameObject = UnityEngine.Object.Instantiate<GameObject>(asset, this.m_fxGo.transform, false);
		}

		// Token: 0x06014245 RID: 82501 RVA: 0x00521964 File Offset: 0x0051FB64
		private void DestroyBackgroundFx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyBackgroundFx_hotfix != null)
			{
				this.m_DestroyBackgroundFx_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_backgroundFxGameObject != null)
			{
				UnityEngine.Object.Destroy(this.m_backgroundFxGameObject);
				this.m_backgroundFxGameObject = null;
			}
		}

		// Token: 0x06014246 RID: 82502 RVA: 0x005219E8 File Offset: 0x0051FBE8
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

		// Token: 0x14000470 RID: 1136
		// (add) Token: 0x06014247 RID: 82503 RVA: 0x00521A78 File Offset: 0x0051FC78
		// (remove) Token: 0x06014248 RID: 82504 RVA: 0x00521B14 File Offset: 0x0051FD14
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

		// Token: 0x14000471 RID: 1137
		// (add) Token: 0x06014249 RID: 82505 RVA: 0x00521BB0 File Offset: 0x0051FDB0
		// (remove) Token: 0x0601424A RID: 82506 RVA: 0x00521C4C File Offset: 0x0051FE4C
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

		// Token: 0x14000472 RID: 1138
		// (add) Token: 0x0601424B RID: 82507 RVA: 0x00521CE8 File Offset: 0x0051FEE8
		// (remove) Token: 0x0601424C RID: 82508 RVA: 0x00521D84 File Offset: 0x0051FF84
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

		// Token: 0x14000473 RID: 1139
		// (add) Token: 0x0601424D RID: 82509 RVA: 0x00521E20 File Offset: 0x00520020
		// (remove) Token: 0x0601424E RID: 82510 RVA: 0x00521EBC File Offset: 0x005200BC
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

		// Token: 0x14000474 RID: 1140
		// (add) Token: 0x0601424F RID: 82511 RVA: 0x00521F58 File Offset: 0x00520158
		// (remove) Token: 0x06014250 RID: 82512 RVA: 0x00521FF4 File Offset: 0x005201F4
		public event Action<ConfigDataThearchyTrialLevelInfo> EventOnStartThearchyLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartThearchyLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnStartThearchyLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataThearchyTrialLevelInfo> action = this.EventOnStartThearchyLevel;
				Action<ConfigDataThearchyTrialLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataThearchyTrialLevelInfo>>(ref this.EventOnStartThearchyLevel, (Action<ConfigDataThearchyTrialLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartThearchyLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartThearchyLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataThearchyTrialLevelInfo> action = this.EventOnStartThearchyLevel;
				Action<ConfigDataThearchyTrialLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataThearchyTrialLevelInfo>>(ref this.EventOnStartThearchyLevel, (Action<ConfigDataThearchyTrialLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x06014251 RID: 82513 RVA: 0x00522090 File Offset: 0x00520290
		// (set) Token: 0x06014252 RID: 82514 RVA: 0x005220B0 File Offset: 0x005202B0
		[DoNotToLua]
		public new ThearchyUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ThearchyUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014253 RID: 82515 RVA: 0x005220BC File Offset: 0x005202BC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014254 RID: 82516 RVA: 0x005220C8 File Offset: 0x005202C8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014255 RID: 82517 RVA: 0x005220D0 File Offset: 0x005202D0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014256 RID: 82518 RVA: 0x005220D8 File Offset: 0x005202D8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014257 RID: 82519 RVA: 0x005220EC File Offset: 0x005202EC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014258 RID: 82520 RVA: 0x005220F4 File Offset: 0x005202F4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014259 RID: 82521 RVA: 0x00522100 File Offset: 0x00520300
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601425A RID: 82522 RVA: 0x0052210C File Offset: 0x0052030C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601425B RID: 82523 RVA: 0x00522118 File Offset: 0x00520318
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601425C RID: 82524 RVA: 0x00522124 File Offset: 0x00520324
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601425D RID: 82525 RVA: 0x00522130 File Offset: 0x00520330
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601425E RID: 82526 RVA: 0x0052213C File Offset: 0x0052033C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601425F RID: 82527 RVA: 0x00522148 File Offset: 0x00520348
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014260 RID: 82528 RVA: 0x00522154 File Offset: 0x00520354
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014261 RID: 82529 RVA: 0x00522160 File Offset: 0x00520360
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014262 RID: 82530 RVA: 0x00522168 File Offset: 0x00520368
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06014263 RID: 82531 RVA: 0x00522188 File Offset: 0x00520388
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06014264 RID: 82532 RVA: 0x00522194 File Offset: 0x00520394
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x06014265 RID: 82533 RVA: 0x005221B4 File Offset: 0x005203B4
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x06014266 RID: 82534 RVA: 0x005221C0 File Offset: 0x005203C0
		private void __callDele_EventOnAddTicket()
		{
			Action eventOnAddTicket = this.EventOnAddTicket;
			if (eventOnAddTicket != null)
			{
				eventOnAddTicket();
			}
		}

		// Token: 0x06014267 RID: 82535 RVA: 0x005221E0 File Offset: 0x005203E0
		private void __clearDele_EventOnAddTicket()
		{
			this.EventOnAddTicket = null;
		}

		// Token: 0x06014268 RID: 82536 RVA: 0x005221EC File Offset: 0x005203EC
		private void __callDele_EventOnShowTeam()
		{
			Action eventOnShowTeam = this.EventOnShowTeam;
			if (eventOnShowTeam != null)
			{
				eventOnShowTeam();
			}
		}

		// Token: 0x06014269 RID: 82537 RVA: 0x0052220C File Offset: 0x0052040C
		private void __clearDele_EventOnShowTeam()
		{
			this.EventOnShowTeam = null;
		}

		// Token: 0x0601426A RID: 82538 RVA: 0x00522218 File Offset: 0x00520418
		private void __callDele_EventOnStartThearchyLevel(ConfigDataThearchyTrialLevelInfo obj)
		{
			Action<ConfigDataThearchyTrialLevelInfo> eventOnStartThearchyLevel = this.EventOnStartThearchyLevel;
			if (eventOnStartThearchyLevel != null)
			{
				eventOnStartThearchyLevel(obj);
			}
		}

		// Token: 0x0601426B RID: 82539 RVA: 0x0052223C File Offset: 0x0052043C
		private void __clearDele_EventOnStartThearchyLevel(ConfigDataThearchyTrialLevelInfo obj)
		{
			this.EventOnStartThearchyLevel = null;
		}

		// Token: 0x0601426C RID: 82540 RVA: 0x00522248 File Offset: 0x00520448
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
					this.m_SetThearchyConfigDataThearchyTrialInfo_hotfix = (luaObj.RawGet("SetThearchy") as LuaFunction);
					this.m_SetAllThearchyLevelListItemsList`1_hotfix = (luaObj.RawGet("SetAllThearchyLevelListItems") as LuaFunction);
					this.m_AddThearchyLevelListItemConfigDataThearchyTrialLevelInfoBoolean_hotfix = (luaObj.RawGet("AddThearchyLevelListItem") as LuaFunction);
					this.m_ClearThearchyLevelListItems_hotfix = (luaObj.RawGet("ClearThearchyLevelListItems") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnAddTicketButtonClick_hotfix = (luaObj.RawGet("OnAddTicketButtonClick") as LuaFunction);
					this.m_OnTeamButtonClick_hotfix = (luaObj.RawGet("OnTeamButtonClick") as LuaFunction);
					this.m_ThearchyLevelListItem_OnStartButtonClickThearchyLevelListItemUIController_hotfix = (luaObj.RawGet("ThearchyLevelListItem_OnStartButtonClick") as LuaFunction);
					this.m_PlayGodModelSingEffectThearchyLevelListItemUIController_hotfix = (luaObj.RawGet("PlayGodModelSingEffect") as LuaFunction);
					this.m_CreateSpineGraphicConfigDataThearchyTrialInfo_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_CreateBackgroundFxConfigDataThearchyTrialInfo_hotfix = (luaObj.RawGet("CreateBackgroundFx") as LuaFunction);
					this.m_DestroyBackgroundFx_hotfix = (luaObj.RawGet("DestroyBackgroundFx") as LuaFunction);
					this.m_SetDailyRewardCountInt32Int32_hotfix = (luaObj.RawGet("SetDailyRewardCount") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnAddTicketAction_hotfix = (luaObj.RawGet("add_EventOnAddTicket") as LuaFunction);
					this.m_remove_EventOnAddTicketAction_hotfix = (luaObj.RawGet("remove_EventOnAddTicket") as LuaFunction);
					this.m_add_EventOnShowTeamAction_hotfix = (luaObj.RawGet("add_EventOnShowTeam") as LuaFunction);
					this.m_remove_EventOnShowTeamAction_hotfix = (luaObj.RawGet("remove_EventOnShowTeam") as LuaFunction);
					this.m_add_EventOnStartThearchyLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnStartThearchyLevel") as LuaFunction);
					this.m_remove_EventOnStartThearchyLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartThearchyLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601426D RID: 82541 RVA: 0x005225B8 File Offset: 0x005207B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ThearchyUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B209 RID: 45577
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B20A RID: 45578
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400B20B RID: 45579
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x0400B20C RID: 45580
		[AutoBind("./OrganizeTeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_teamButton;

		// Token: 0x0400B20D RID: 45581
		[AutoBind("./PlayerResource/DailyReward/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_dailyRewardCountText;

		// Token: 0x0400B20E RID: 45582
		[AutoBind("./LevelList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_levelListScrollRect;

		// Token: 0x0400B20F RID: 45583
		[AutoBind("./Background/Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGo;

		// Token: 0x0400B210 RID: 45584
		[AutoBind("./Background/Fx", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_fxGo;

		// Token: 0x0400B211 RID: 45585
		[AutoBind("./RecommendPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_armyPanelGameObject;

		// Token: 0x0400B212 RID: 45586
		[AutoBind("./RecommendPanel/FrameImage/SoldierGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_armyPanelGroup;

		// Token: 0x0400B213 RID: 45587
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400B214 RID: 45588
		[AutoBind("./Prefabs/ThearchyLevelListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_ThearchyLevelListItemPrefab;

		// Token: 0x0400B215 RID: 45589
		private List<ThearchyLevelListItemUIController> m_thearchyLevelListItems = new List<ThearchyLevelListItemUIController>();

		// Token: 0x0400B216 RID: 45590
		private UISpineGraphic m_graphic;

		// Token: 0x0400B217 RID: 45591
		private GameObject m_backgroundFxGameObject;

		// Token: 0x0400B218 RID: 45592
		[DoNotToLua]
		private ThearchyUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B219 RID: 45593
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B21A RID: 45594
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B21B RID: 45595
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B21C RID: 45596
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400B21D RID: 45597
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x0400B21E RID: 45598
		private LuaFunction m_SetThearchyConfigDataThearchyTrialInfo_hotfix;

		// Token: 0x0400B21F RID: 45599
		private LuaFunction m_SetAllThearchyLevelListItemsList;

		// Token: 0x0400B220 RID: 45600
		private LuaFunction m_AddThearchyLevelListItemConfigDataThearchyTrialLevelInfoBoolean_hotfix;

		// Token: 0x0400B221 RID: 45601
		private LuaFunction m_ClearThearchyLevelListItems_hotfix;

		// Token: 0x0400B222 RID: 45602
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400B223 RID: 45603
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x0400B224 RID: 45604
		private LuaFunction m_OnAddTicketButtonClick_hotfix;

		// Token: 0x0400B225 RID: 45605
		private LuaFunction m_OnTeamButtonClick_hotfix;

		// Token: 0x0400B226 RID: 45606
		private LuaFunction m_ThearchyLevelListItem_OnStartButtonClickThearchyLevelListItemUIController_hotfix;

		// Token: 0x0400B227 RID: 45607
		private LuaFunction m_PlayGodModelSingEffectThearchyLevelListItemUIController_hotfix;

		// Token: 0x0400B228 RID: 45608
		private LuaFunction m_CreateSpineGraphicConfigDataThearchyTrialInfo_hotfix;

		// Token: 0x0400B229 RID: 45609
		private LuaFunction m_DestroySpineGraphic_hotfix;

		// Token: 0x0400B22A RID: 45610
		private LuaFunction m_CreateBackgroundFxConfigDataThearchyTrialInfo_hotfix;

		// Token: 0x0400B22B RID: 45611
		private LuaFunction m_DestroyBackgroundFx_hotfix;

		// Token: 0x0400B22C RID: 45612
		private LuaFunction m_SetDailyRewardCountInt32Int32_hotfix;

		// Token: 0x0400B22D RID: 45613
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400B22E RID: 45614
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400B22F RID: 45615
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x0400B230 RID: 45616
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x0400B231 RID: 45617
		private LuaFunction m_add_EventOnAddTicketAction_hotfix;

		// Token: 0x0400B232 RID: 45618
		private LuaFunction m_remove_EventOnAddTicketAction_hotfix;

		// Token: 0x0400B233 RID: 45619
		private LuaFunction m_add_EventOnShowTeamAction_hotfix;

		// Token: 0x0400B234 RID: 45620
		private LuaFunction m_remove_EventOnShowTeamAction_hotfix;

		// Token: 0x0400B235 RID: 45621
		private LuaFunction m_add_EventOnStartThearchyLevelAction;

		// Token: 0x0400B236 RID: 45622
		private LuaFunction m_remove_EventOnStartThearchyLevelAction;

		// Token: 0x02000FC3 RID: 4035
		public new class LuaExportHelper
		{
			// Token: 0x0601426E RID: 82542 RVA: 0x00522620 File Offset: 0x00520820
			public LuaExportHelper(ThearchyUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601426F RID: 82543 RVA: 0x00522630 File Offset: 0x00520830
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014270 RID: 82544 RVA: 0x00522640 File Offset: 0x00520840
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014271 RID: 82545 RVA: 0x00522650 File Offset: 0x00520850
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014272 RID: 82546 RVA: 0x00522660 File Offset: 0x00520860
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014273 RID: 82547 RVA: 0x00522678 File Offset: 0x00520878
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014274 RID: 82548 RVA: 0x00522688 File Offset: 0x00520888
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014275 RID: 82549 RVA: 0x00522698 File Offset: 0x00520898
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014276 RID: 82550 RVA: 0x005226A8 File Offset: 0x005208A8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014277 RID: 82551 RVA: 0x005226B8 File Offset: 0x005208B8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014278 RID: 82552 RVA: 0x005226C8 File Offset: 0x005208C8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014279 RID: 82553 RVA: 0x005226D8 File Offset: 0x005208D8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601427A RID: 82554 RVA: 0x005226E8 File Offset: 0x005208E8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601427B RID: 82555 RVA: 0x005226F8 File Offset: 0x005208F8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601427C RID: 82556 RVA: 0x00522708 File Offset: 0x00520908
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601427D RID: 82557 RVA: 0x00522718 File Offset: 0x00520918
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601427E RID: 82558 RVA: 0x00522728 File Offset: 0x00520928
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0601427F RID: 82559 RVA: 0x00522738 File Offset: 0x00520938
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06014280 RID: 82560 RVA: 0x00522748 File Offset: 0x00520948
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x06014281 RID: 82561 RVA: 0x00522758 File Offset: 0x00520958
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x06014282 RID: 82562 RVA: 0x00522768 File Offset: 0x00520968
			public void __callDele_EventOnAddTicket()
			{
				this.m_owner.__callDele_EventOnAddTicket();
			}

			// Token: 0x06014283 RID: 82563 RVA: 0x00522778 File Offset: 0x00520978
			public void __clearDele_EventOnAddTicket()
			{
				this.m_owner.__clearDele_EventOnAddTicket();
			}

			// Token: 0x06014284 RID: 82564 RVA: 0x00522788 File Offset: 0x00520988
			public void __callDele_EventOnShowTeam()
			{
				this.m_owner.__callDele_EventOnShowTeam();
			}

			// Token: 0x06014285 RID: 82565 RVA: 0x00522798 File Offset: 0x00520998
			public void __clearDele_EventOnShowTeam()
			{
				this.m_owner.__clearDele_EventOnShowTeam();
			}

			// Token: 0x06014286 RID: 82566 RVA: 0x005227A8 File Offset: 0x005209A8
			public void __callDele_EventOnStartThearchyLevel(ConfigDataThearchyTrialLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnStartThearchyLevel(obj);
			}

			// Token: 0x06014287 RID: 82567 RVA: 0x005227B8 File Offset: 0x005209B8
			public void __clearDele_EventOnStartThearchyLevel(ConfigDataThearchyTrialLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartThearchyLevel(obj);
			}

			// Token: 0x17003C0F RID: 15375
			// (get) Token: 0x06014288 RID: 82568 RVA: 0x005227C8 File Offset: 0x005209C8
			// (set) Token: 0x06014289 RID: 82569 RVA: 0x005227D8 File Offset: 0x005209D8
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

			// Token: 0x17003C10 RID: 15376
			// (get) Token: 0x0601428A RID: 82570 RVA: 0x005227E8 File Offset: 0x005209E8
			// (set) Token: 0x0601428B RID: 82571 RVA: 0x005227F8 File Offset: 0x005209F8
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

			// Token: 0x17003C11 RID: 15377
			// (get) Token: 0x0601428C RID: 82572 RVA: 0x00522808 File Offset: 0x00520A08
			// (set) Token: 0x0601428D RID: 82573 RVA: 0x00522818 File Offset: 0x00520A18
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

			// Token: 0x17003C12 RID: 15378
			// (get) Token: 0x0601428E RID: 82574 RVA: 0x00522828 File Offset: 0x00520A28
			// (set) Token: 0x0601428F RID: 82575 RVA: 0x00522838 File Offset: 0x00520A38
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

			// Token: 0x17003C13 RID: 15379
			// (get) Token: 0x06014290 RID: 82576 RVA: 0x00522848 File Offset: 0x00520A48
			// (set) Token: 0x06014291 RID: 82577 RVA: 0x00522858 File Offset: 0x00520A58
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

			// Token: 0x17003C14 RID: 15380
			// (get) Token: 0x06014292 RID: 82578 RVA: 0x00522868 File Offset: 0x00520A68
			// (set) Token: 0x06014293 RID: 82579 RVA: 0x00522878 File Offset: 0x00520A78
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

			// Token: 0x17003C15 RID: 15381
			// (get) Token: 0x06014294 RID: 82580 RVA: 0x00522888 File Offset: 0x00520A88
			// (set) Token: 0x06014295 RID: 82581 RVA: 0x00522898 File Offset: 0x00520A98
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

			// Token: 0x17003C16 RID: 15382
			// (get) Token: 0x06014296 RID: 82582 RVA: 0x005228A8 File Offset: 0x00520AA8
			// (set) Token: 0x06014297 RID: 82583 RVA: 0x005228B8 File Offset: 0x00520AB8
			public GameObject m_fxGo
			{
				get
				{
					return this.m_owner.m_fxGo;
				}
				set
				{
					this.m_owner.m_fxGo = value;
				}
			}

			// Token: 0x17003C17 RID: 15383
			// (get) Token: 0x06014298 RID: 82584 RVA: 0x005228C8 File Offset: 0x00520AC8
			// (set) Token: 0x06014299 RID: 82585 RVA: 0x005228D8 File Offset: 0x00520AD8
			public GameObject m_armyPanelGameObject
			{
				get
				{
					return this.m_owner.m_armyPanelGameObject;
				}
				set
				{
					this.m_owner.m_armyPanelGameObject = value;
				}
			}

			// Token: 0x17003C18 RID: 15384
			// (get) Token: 0x0601429A RID: 82586 RVA: 0x005228E8 File Offset: 0x00520AE8
			// (set) Token: 0x0601429B RID: 82587 RVA: 0x005228F8 File Offset: 0x00520AF8
			public Transform m_armyPanelGroup
			{
				get
				{
					return this.m_owner.m_armyPanelGroup;
				}
				set
				{
					this.m_owner.m_armyPanelGroup = value;
				}
			}

			// Token: 0x17003C19 RID: 15385
			// (get) Token: 0x0601429C RID: 82588 RVA: 0x00522908 File Offset: 0x00520B08
			// (set) Token: 0x0601429D RID: 82589 RVA: 0x00522918 File Offset: 0x00520B18
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

			// Token: 0x17003C1A RID: 15386
			// (get) Token: 0x0601429E RID: 82590 RVA: 0x00522928 File Offset: 0x00520B28
			// (set) Token: 0x0601429F RID: 82591 RVA: 0x00522938 File Offset: 0x00520B38
			public GameObject m_ThearchyLevelListItemPrefab
			{
				get
				{
					return this.m_owner.m_ThearchyLevelListItemPrefab;
				}
				set
				{
					this.m_owner.m_ThearchyLevelListItemPrefab = value;
				}
			}

			// Token: 0x17003C1B RID: 15387
			// (get) Token: 0x060142A0 RID: 82592 RVA: 0x00522948 File Offset: 0x00520B48
			// (set) Token: 0x060142A1 RID: 82593 RVA: 0x00522958 File Offset: 0x00520B58
			public List<ThearchyLevelListItemUIController> m_thearchyLevelListItems
			{
				get
				{
					return this.m_owner.m_thearchyLevelListItems;
				}
				set
				{
					this.m_owner.m_thearchyLevelListItems = value;
				}
			}

			// Token: 0x17003C1C RID: 15388
			// (get) Token: 0x060142A2 RID: 82594 RVA: 0x00522968 File Offset: 0x00520B68
			// (set) Token: 0x060142A3 RID: 82595 RVA: 0x00522978 File Offset: 0x00520B78
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

			// Token: 0x17003C1D RID: 15389
			// (get) Token: 0x060142A4 RID: 82596 RVA: 0x00522988 File Offset: 0x00520B88
			// (set) Token: 0x060142A5 RID: 82597 RVA: 0x00522998 File Offset: 0x00520B98
			public GameObject m_backgroundFxGameObject
			{
				get
				{
					return this.m_owner.m_backgroundFxGameObject;
				}
				set
				{
					this.m_owner.m_backgroundFxGameObject = value;
				}
			}

			// Token: 0x060142A6 RID: 82598 RVA: 0x005229A8 File Offset: 0x00520BA8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060142A7 RID: 82599 RVA: 0x005229B8 File Offset: 0x00520BB8
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x060142A8 RID: 82600 RVA: 0x005229C8 File Offset: 0x00520BC8
			public void AddThearchyLevelListItem(ConfigDataThearchyTrialLevelInfo levelnfo, bool opened)
			{
				this.m_owner.AddThearchyLevelListItem(levelnfo, opened);
			}

			// Token: 0x060142A9 RID: 82601 RVA: 0x005229D8 File Offset: 0x00520BD8
			public void ClearThearchyLevelListItems()
			{
				this.m_owner.ClearThearchyLevelListItems();
			}

			// Token: 0x060142AA RID: 82602 RVA: 0x005229E8 File Offset: 0x00520BE8
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x060142AB RID: 82603 RVA: 0x005229F8 File Offset: 0x00520BF8
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x060142AC RID: 82604 RVA: 0x00522A08 File Offset: 0x00520C08
			public void OnAddTicketButtonClick()
			{
				this.m_owner.OnAddTicketButtonClick();
			}

			// Token: 0x060142AD RID: 82605 RVA: 0x00522A18 File Offset: 0x00520C18
			public void OnTeamButtonClick()
			{
				this.m_owner.OnTeamButtonClick();
			}

			// Token: 0x060142AE RID: 82606 RVA: 0x00522A28 File Offset: 0x00520C28
			public void ThearchyLevelListItem_OnStartButtonClick(ThearchyLevelListItemUIController b)
			{
				this.m_owner.ThearchyLevelListItem_OnStartButtonClick(b);
			}

			// Token: 0x060142AF RID: 82607 RVA: 0x00522A38 File Offset: 0x00520C38
			public IEnumerator PlayGodModelSingEffect(ThearchyLevelListItemUIController b)
			{
				return this.m_owner.PlayGodModelSingEffect(b);
			}

			// Token: 0x060142B0 RID: 82608 RVA: 0x00522A48 File Offset: 0x00520C48
			public void CreateSpineGraphic(ConfigDataThearchyTrialInfo thearchyInfo)
			{
				this.m_owner.CreateSpineGraphic(thearchyInfo);
			}

			// Token: 0x060142B1 RID: 82609 RVA: 0x00522A58 File Offset: 0x00520C58
			public void DestroySpineGraphic()
			{
				this.m_owner.DestroySpineGraphic();
			}

			// Token: 0x060142B2 RID: 82610 RVA: 0x00522A68 File Offset: 0x00520C68
			public void CreateBackgroundFx(ConfigDataThearchyTrialInfo thearchyInfo)
			{
				this.m_owner.CreateBackgroundFx(thearchyInfo);
			}

			// Token: 0x060142B3 RID: 82611 RVA: 0x00522A78 File Offset: 0x00520C78
			public void DestroyBackgroundFx()
			{
				this.m_owner.DestroyBackgroundFx();
			}

			// Token: 0x0400B237 RID: 45623
			private ThearchyUIController m_owner;
		}
	}
}
