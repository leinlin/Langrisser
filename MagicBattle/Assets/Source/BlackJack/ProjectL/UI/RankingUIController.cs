using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EBA RID: 3770
	[HotFix]
	public class RankingUIController : UIControllerBase
	{
		// Token: 0x060126D6 RID: 75478 RVA: 0x004BAC54 File Offset: 0x004B8E54
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
			this.ReturnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.MainMenuPowerButton.onClick.AddListener(new UnityAction(this.OnMainMenuPowerClick));
			this.MainMenuRiftButton.onClick.AddListener(new UnityAction(this.OnMainMenuRiftClick));
			this.MainMenuStageButton.onClick.AddListener(new UnityAction(this.OnMainMenuStageClick));
			this.SubMenuTopHeroButton.onClick.AddListener(new UnityAction(this.OnSubMenuTopHeroClick));
			this.SubMenuAllHeroButton.onClick.AddListener(new UnityAction(this.OnSubMenuAllHeroClick));
			this.SubMenuChampionHeroButton.onClick.AddListener(new UnityAction(this.OnSubMenuChampionHeroClick));
			this.SubMenuRiftChapterStarButton.onClick.AddListener(new UnityAction(this.OnSubMenuRiftChapterStarClick));
			this.SubMenuRiftAchievementButton.onClick.AddListener(new UnityAction(this.OnSubMenuRiftAchievementClick));
			this.SubMenuUICtrl.EventOnNoneSubMenuAreaClick += this.OnNoneSubMenuAreaClick;
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060126D7 RID: 75479 RVA: 0x004BADD0 File Offset: 0x004B8FD0
		public void UpdateRankingUICtrl(RankingListType rankingType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRankingUICtrlRankingListType_hotfix != null)
			{
				this.m_UpdateRankingUICtrlRankingListType_hotfix.call(new object[]
				{
					this,
					rankingType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isDuringUpdate = true;
			this.m_currRankingType = rankingType;
			this.m_mainMenuSelectState = this.GetMainMenuSelectStateFromRankingType(rankingType);
			this.SetMainMenuSelectState(this.m_mainMenuSelectState);
			this.HideAllSubMenuPanel();
			this.m_isDuringUpdate = false;
		}

		// Token: 0x060126D8 RID: 75480 RVA: 0x004BAE74 File Offset: 0x004B9074
		protected RankingUIController.MainMenuSelectState GetMainMenuSelectStateFromRankingType(RankingListType rankingType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMainMenuSelectStateFromRankingTypeRankingListType_hotfix != null)
			{
				return (RankingUIController.MainMenuSelectState)this.m_GetMainMenuSelectStateFromRankingTypeRankingListType_hotfix.call(new object[]
				{
					this,
					rankingType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (rankingType)
			{
			case RankingListType.TopHero:
			case RankingListType.AllHero:
			case RankingListType.ChampionHero:
				return RankingUIController.MainMenuSelectState.Power;
			case RankingListType.RiftChapterStar:
			case RankingListType.RiftAchievement:
				return RankingUIController.MainMenuSelectState.Rift;
			default:
				return RankingUIController.MainMenuSelectState.Power;
			}
		}

		// Token: 0x060126D9 RID: 75481 RVA: 0x004BAF14 File Offset: 0x004B9114
		protected void SetMainMenuSelectState(RankingUIController.MainMenuSelectState state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMainMenuSelectStateMainMenuSelectState_hotfix != null)
			{
				this.m_SetMainMenuSelectStateMainMenuSelectState_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetAllMainMenuUnselect();
			switch (state)
			{
			case RankingUIController.MainMenuSelectState.Power:
				this.MainMenuPowerStateCtrl.SetToUIState("Select", false, true);
				break;
			case RankingUIController.MainMenuSelectState.Rift:
				this.MainMenuRiftStateCtrl.SetToUIState("Select", false, true);
				break;
			case RankingUIController.MainMenuSelectState.Stage:
				this.MainMenuStageStateCtrl.SetToUIState("Select", false, true);
				break;
			}
		}

		// Token: 0x060126DA RID: 75482 RVA: 0x004BAFF0 File Offset: 0x004B91F0
		protected void SetAllMainMenuUnselect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAllMainMenuUnselect_hotfix != null)
			{
				this.m_SetAllMainMenuUnselect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.MainMenuPowerStateCtrl.SetToUIState("Normal", false, true);
			this.MainMenuRiftStateCtrl.SetToUIState("Normal", false, true);
			this.MainMenuStageStateCtrl.SetToUIState("Normal", false, true);
		}

		// Token: 0x060126DB RID: 75483 RVA: 0x004BB088 File Offset: 0x004B9288
		protected void SetSubMenuSelectState(RankingListType rankType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSubMenuSelectStateRankingListType_hotfix != null)
			{
				this.m_SetSubMenuSelectStateRankingListType_hotfix.call(new object[]
				{
					this,
					rankType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetAllSubMenuToggleUnselect();
			switch (rankType)
			{
			case RankingListType.TopHero:
				this.SubMenuTopHeroStateCtrl.SetToUIState("Select", false, true);
				break;
			case RankingListType.AllHero:
				this.SubMenuAllHeroStateCtrl.SetToUIState("Select", false, true);
				break;
			case RankingListType.ChampionHero:
				this.SubMenuChampionHeroStateCtrl.SetToUIState("Select", false, true);
				break;
			case RankingListType.RiftChapterStar:
				this.SubMenuRiftChapterStarStateCtrl.SetToUIState("Select", false, true);
				break;
			case RankingListType.RiftAchievement:
				this.SubMenuRiftAchievementStateCtrl.SetToUIState("Select", false, true);
				break;
			}
		}

		// Token: 0x060126DC RID: 75484 RVA: 0x004BB190 File Offset: 0x004B9390
		protected void SetAllSubMenuToggleUnselect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAllSubMenuToggleUnselect_hotfix != null)
			{
				this.m_SetAllSubMenuToggleUnselect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SubMenuTopHeroStateCtrl.SetToUIState("Normal", false, true);
			this.SubMenuAllHeroStateCtrl.SetToUIState("Normal", false, true);
			this.SubMenuChampionHeroStateCtrl.SetToUIState("Normal", false, true);
			this.SubMenuRiftChapterStarStateCtrl.SetToUIState("Normal", false, true);
			this.SubMenuRiftAchievementStateCtrl.SetToUIState("Normal", false, true);
		}

		// Token: 0x060126DD RID: 75485 RVA: 0x004BB24C File Offset: 0x004B944C
		protected void ShowPowerSubMenuPanel(bool isshow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPowerSubMenuPanelBoolean_hotfix != null)
			{
				this.m_ShowPowerSubMenuPanelBoolean_hotfix.call(new object[]
				{
					this,
					isshow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isSubMenuPanelPowerShow = isshow;
			if (isshow)
			{
				this.SubMenuPanelPowerStateCtrl.gameObject.SetActive(true);
				this.SubMenuPanelPowerStateCtrl.SetToUIState("Show", false, true);
				this.SubMenuPanelRiftStateCtrl.gameObject.SetActive(false);
				this.m_isSubMenuPanelRiftShow = false;
				this.SubMenuUICtrl.gameObject.SetActive(true);
				this.SetSubMenuSelectState(this.m_currRankingType);
			}
			else
			{
				this.SubMenuPanelPowerStateCtrl.SetToUIState("Close", false, true);
				this.SubMenuUICtrl.gameObject.SetActive(false);
			}
		}

		// Token: 0x060126DE RID: 75486 RVA: 0x004BB34C File Offset: 0x004B954C
		protected void ShowRiftSubMenuPanel(bool isshow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRiftSubMenuPanelBoolean_hotfix != null)
			{
				this.m_ShowRiftSubMenuPanelBoolean_hotfix.call(new object[]
				{
					this,
					isshow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isSubMenuPanelRiftShow = isshow;
			if (isshow)
			{
				this.SubMenuPanelRiftStateCtrl.gameObject.SetActive(true);
				this.SubMenuPanelRiftStateCtrl.SetToUIState("Show", false, true);
				this.SubMenuPanelPowerStateCtrl.gameObject.SetActive(false);
				this.m_isSubMenuPanelPowerShow = false;
				this.SubMenuUICtrl.gameObject.SetActive(true);
				this.SetSubMenuSelectState(this.m_currRankingType);
			}
			else
			{
				this.SubMenuPanelRiftStateCtrl.SetToUIState("Close", false, true);
				this.SubMenuUICtrl.gameObject.SetActive(false);
			}
		}

		// Token: 0x060126DF RID: 75487 RVA: 0x004BB44C File Offset: 0x004B964C
		protected void HideAllSubMenuPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideAllSubMenuPanel_hotfix != null)
			{
				this.m_HideAllSubMenuPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SubMenuPanelPowerStateCtrl.gameObject.SetActive(false);
			this.m_isSubMenuPanelPowerShow = false;
			this.SubMenuPanelRiftStateCtrl.gameObject.SetActive(false);
			this.m_isSubMenuPanelRiftShow = false;
			this.SubMenuPanelStageStateCtrl.gameObject.SetActive(false);
			this.SubMenuUICtrl.gameObject.SetActive(false);
		}

		// Token: 0x060126E0 RID: 75488 RVA: 0x004BB500 File Offset: 0x004B9700
		protected void OnReturnButtonClick()
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
			if (this.EventOnRetunButtonClick != null)
			{
				this.EventOnRetunButtonClick();
			}
		}

		// Token: 0x060126E1 RID: 75489 RVA: 0x004BB578 File Offset: 0x004B9778
		protected void OnNoneSubMenuAreaClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNoneSubMenuAreaClick_hotfix != null)
			{
				this.m_OnNoneSubMenuAreaClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideAllSubMenuPanel();
			if (this.EventOnResetRankingType != null)
			{
				this.EventOnResetRankingType();
			}
		}

		// Token: 0x060126E2 RID: 75490 RVA: 0x004BB5F4 File Offset: 0x004B97F4
		protected void OnMainMenuPowerClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMainMenuPowerClick_hotfix != null)
			{
				this.m_OnMainMenuPowerClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetMainMenuSelectState(RankingUIController.MainMenuSelectState.Power);
			if (this.m_isSubMenuPanelPowerShow)
			{
				this.ShowPowerSubMenuPanel(false);
				if (this.EventOnResetRankingType != null)
				{
					this.EventOnResetRankingType();
				}
			}
			else
			{
				this.ShowPowerSubMenuPanel(true);
			}
		}

		// Token: 0x060126E3 RID: 75491 RVA: 0x004BB690 File Offset: 0x004B9890
		protected void OnMainMenuRiftClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMainMenuRiftClick_hotfix != null)
			{
				this.m_OnMainMenuRiftClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetMainMenuSelectState(RankingUIController.MainMenuSelectState.Rift);
			if (this.m_isSubMenuPanelRiftShow)
			{
				this.ShowRiftSubMenuPanel(false);
				if (this.EventOnResetRankingType != null)
				{
					this.EventOnResetRankingType();
				}
			}
			else
			{
				this.ShowRiftSubMenuPanel(true);
			}
		}

		// Token: 0x060126E4 RID: 75492 RVA: 0x004BB72C File Offset: 0x004B992C
		protected void OnMainMenuStageClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMainMenuStageClick_hotfix != null)
			{
				this.m_OnMainMenuStageClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060126E5 RID: 75493 RVA: 0x004BB78C File Offset: 0x004B998C
		protected void OnRankingTypeMenuClick(RankingListType rankListType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRankingTypeMenuClickRankingListType_hotfix != null)
			{
				this.m_OnRankingTypeMenuClickRankingListType_hotfix.call(new object[]
				{
					this,
					rankListType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRankingTypeMenuClick != null)
			{
				this.EventOnRankingTypeMenuClick(rankListType);
			}
		}

		// Token: 0x060126E6 RID: 75494 RVA: 0x004BB814 File Offset: 0x004B9A14
		protected void OnSubMenuTopHeroClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSubMenuTopHeroClick_hotfix != null)
			{
				this.m_OnSubMenuTopHeroClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnRankingTypeMenuClick(RankingListType.TopHero);
		}

		// Token: 0x060126E7 RID: 75495 RVA: 0x004BB87C File Offset: 0x004B9A7C
		protected void OnSubMenuAllHeroClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSubMenuAllHeroClick_hotfix != null)
			{
				this.m_OnSubMenuAllHeroClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnRankingTypeMenuClick(RankingListType.AllHero);
		}

		// Token: 0x060126E8 RID: 75496 RVA: 0x004BB8E4 File Offset: 0x004B9AE4
		protected void OnSubMenuChampionHeroClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSubMenuChampionHeroClick_hotfix != null)
			{
				this.m_OnSubMenuChampionHeroClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnRankingTypeMenuClick(RankingListType.ChampionHero);
		}

		// Token: 0x060126E9 RID: 75497 RVA: 0x004BB94C File Offset: 0x004B9B4C
		protected void OnSubMenuRiftChapterStarClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSubMenuRiftChapterStarClick_hotfix != null)
			{
				this.m_OnSubMenuRiftChapterStarClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnRankingTypeMenuClick(RankingListType.RiftChapterStar);
		}

		// Token: 0x060126EA RID: 75498 RVA: 0x004BB9B4 File Offset: 0x004B9BB4
		protected void OnSubMenuRiftAchievementClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSubMenuRiftAchievementClick_hotfix != null)
			{
				this.m_OnSubMenuRiftAchievementClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnRankingTypeMenuClick(RankingListType.RiftAchievement);
		}

		// Token: 0x140003F3 RID: 1011
		// (add) Token: 0x060126EB RID: 75499 RVA: 0x004BBA1C File Offset: 0x004B9C1C
		// (remove) Token: 0x060126EC RID: 75500 RVA: 0x004BBAB8 File Offset: 0x004B9CB8
		public event Action<RankingListType> EventOnRankingTypeMenuClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRankingTypeMenuClickAction`1_hotfix != null)
				{
					this.m_add_EventOnRankingTypeMenuClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<RankingListType> action = this.EventOnRankingTypeMenuClick;
				Action<RankingListType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<RankingListType>>(ref this.EventOnRankingTypeMenuClick, (Action<RankingListType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRankingTypeMenuClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnRankingTypeMenuClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<RankingListType> action = this.EventOnRankingTypeMenuClick;
				Action<RankingListType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<RankingListType>>(ref this.EventOnRankingTypeMenuClick, (Action<RankingListType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003F4 RID: 1012
		// (add) Token: 0x060126ED RID: 75501 RVA: 0x004BBB54 File Offset: 0x004B9D54
		// (remove) Token: 0x060126EE RID: 75502 RVA: 0x004BBBF0 File Offset: 0x004B9DF0
		public event Action EventOnResetRankingType
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnResetRankingTypeAction_hotfix != null)
				{
					this.m_add_EventOnResetRankingTypeAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnResetRankingType;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnResetRankingType, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnResetRankingTypeAction_hotfix != null)
				{
					this.m_remove_EventOnResetRankingTypeAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnResetRankingType;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnResetRankingType, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003F5 RID: 1013
		// (add) Token: 0x060126EF RID: 75503 RVA: 0x004BBC8C File Offset: 0x004B9E8C
		// (remove) Token: 0x060126F0 RID: 75504 RVA: 0x004BBD28 File Offset: 0x004B9F28
		public event Action EventOnRetunButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRetunButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnRetunButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRetunButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRetunButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRetunButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnRetunButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRetunButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRetunButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x060126F1 RID: 75505 RVA: 0x004BBDC4 File Offset: 0x004B9FC4
		// (set) Token: 0x060126F2 RID: 75506 RVA: 0x004BBDE4 File Offset: 0x004B9FE4
		[DoNotToLua]
		public new RankingUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RankingUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060126F3 RID: 75507 RVA: 0x004BBDF0 File Offset: 0x004B9FF0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060126F4 RID: 75508 RVA: 0x004BBDFC File Offset: 0x004B9FFC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060126F5 RID: 75509 RVA: 0x004BBE04 File Offset: 0x004BA004
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060126F6 RID: 75510 RVA: 0x004BBE0C File Offset: 0x004BA00C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060126F7 RID: 75511 RVA: 0x004BBE20 File Offset: 0x004BA020
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060126F8 RID: 75512 RVA: 0x004BBE28 File Offset: 0x004BA028
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060126F9 RID: 75513 RVA: 0x004BBE34 File Offset: 0x004BA034
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060126FA RID: 75514 RVA: 0x004BBE40 File Offset: 0x004BA040
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060126FB RID: 75515 RVA: 0x004BBE4C File Offset: 0x004BA04C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060126FC RID: 75516 RVA: 0x004BBE58 File Offset: 0x004BA058
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060126FD RID: 75517 RVA: 0x004BBE64 File Offset: 0x004BA064
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060126FE RID: 75518 RVA: 0x004BBE70 File Offset: 0x004BA070
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060126FF RID: 75519 RVA: 0x004BBE7C File Offset: 0x004BA07C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012700 RID: 75520 RVA: 0x004BBE88 File Offset: 0x004BA088
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012701 RID: 75521 RVA: 0x004BBE94 File Offset: 0x004BA094
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012702 RID: 75522 RVA: 0x004BBE9C File Offset: 0x004BA09C
		private void __callDele_EventOnRankingTypeMenuClick(RankingListType obj)
		{
			Action<RankingListType> eventOnRankingTypeMenuClick = this.EventOnRankingTypeMenuClick;
			if (eventOnRankingTypeMenuClick != null)
			{
				eventOnRankingTypeMenuClick(obj);
			}
		}

		// Token: 0x06012703 RID: 75523 RVA: 0x004BBEC0 File Offset: 0x004BA0C0
		private void __clearDele_EventOnRankingTypeMenuClick(RankingListType obj)
		{
			this.EventOnRankingTypeMenuClick = null;
		}

		// Token: 0x06012704 RID: 75524 RVA: 0x004BBECC File Offset: 0x004BA0CC
		private void __callDele_EventOnResetRankingType()
		{
			Action eventOnResetRankingType = this.EventOnResetRankingType;
			if (eventOnResetRankingType != null)
			{
				eventOnResetRankingType();
			}
		}

		// Token: 0x06012705 RID: 75525 RVA: 0x004BBEEC File Offset: 0x004BA0EC
		private void __clearDele_EventOnResetRankingType()
		{
			this.EventOnResetRankingType = null;
		}

		// Token: 0x06012706 RID: 75526 RVA: 0x004BBEF8 File Offset: 0x004BA0F8
		private void __callDele_EventOnRetunButtonClick()
		{
			Action eventOnRetunButtonClick = this.EventOnRetunButtonClick;
			if (eventOnRetunButtonClick != null)
			{
				eventOnRetunButtonClick();
			}
		}

		// Token: 0x06012707 RID: 75527 RVA: 0x004BBF18 File Offset: 0x004BA118
		private void __clearDele_EventOnRetunButtonClick()
		{
			this.EventOnRetunButtonClick = null;
		}

		// Token: 0x06012708 RID: 75528 RVA: 0x004BBF24 File Offset: 0x004BA124
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
					this.m_UpdateRankingUICtrlRankingListType_hotfix = (luaObj.RawGet("UpdateRankingUICtrl") as LuaFunction);
					this.m_GetMainMenuSelectStateFromRankingTypeRankingListType_hotfix = (luaObj.RawGet("GetMainMenuSelectStateFromRankingType") as LuaFunction);
					this.m_SetMainMenuSelectStateMainMenuSelectState_hotfix = (luaObj.RawGet("SetMainMenuSelectState") as LuaFunction);
					this.m_SetAllMainMenuUnselect_hotfix = (luaObj.RawGet("SetAllMainMenuUnselect") as LuaFunction);
					this.m_SetSubMenuSelectStateRankingListType_hotfix = (luaObj.RawGet("SetSubMenuSelectState") as LuaFunction);
					this.m_SetAllSubMenuToggleUnselect_hotfix = (luaObj.RawGet("SetAllSubMenuToggleUnselect") as LuaFunction);
					this.m_ShowPowerSubMenuPanelBoolean_hotfix = (luaObj.RawGet("ShowPowerSubMenuPanel") as LuaFunction);
					this.m_ShowRiftSubMenuPanelBoolean_hotfix = (luaObj.RawGet("ShowRiftSubMenuPanel") as LuaFunction);
					this.m_HideAllSubMenuPanel_hotfix = (luaObj.RawGet("HideAllSubMenuPanel") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnNoneSubMenuAreaClick_hotfix = (luaObj.RawGet("OnNoneSubMenuAreaClick") as LuaFunction);
					this.m_OnMainMenuPowerClick_hotfix = (luaObj.RawGet("OnMainMenuPowerClick") as LuaFunction);
					this.m_OnMainMenuRiftClick_hotfix = (luaObj.RawGet("OnMainMenuRiftClick") as LuaFunction);
					this.m_OnMainMenuStageClick_hotfix = (luaObj.RawGet("OnMainMenuStageClick") as LuaFunction);
					this.m_OnRankingTypeMenuClickRankingListType_hotfix = (luaObj.RawGet("OnRankingTypeMenuClick") as LuaFunction);
					this.m_OnSubMenuTopHeroClick_hotfix = (luaObj.RawGet("OnSubMenuTopHeroClick") as LuaFunction);
					this.m_OnSubMenuAllHeroClick_hotfix = (luaObj.RawGet("OnSubMenuAllHeroClick") as LuaFunction);
					this.m_OnSubMenuChampionHeroClick_hotfix = (luaObj.RawGet("OnSubMenuChampionHeroClick") as LuaFunction);
					this.m_OnSubMenuRiftChapterStarClick_hotfix = (luaObj.RawGet("OnSubMenuRiftChapterStarClick") as LuaFunction);
					this.m_OnSubMenuRiftAchievementClick_hotfix = (luaObj.RawGet("OnSubMenuRiftAchievementClick") as LuaFunction);
					this.m_add_EventOnRankingTypeMenuClickAction`1_hotfix = (luaObj.RawGet("add_EventOnRankingTypeMenuClick") as LuaFunction);
					this.m_remove_EventOnRankingTypeMenuClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnRankingTypeMenuClick") as LuaFunction);
					this.m_add_EventOnResetRankingTypeAction_hotfix = (luaObj.RawGet("add_EventOnResetRankingType") as LuaFunction);
					this.m_remove_EventOnResetRankingTypeAction_hotfix = (luaObj.RawGet("remove_EventOnResetRankingType") as LuaFunction);
					this.m_add_EventOnRetunButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnRetunButtonClick") as LuaFunction);
					this.m_remove_EventOnRetunButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnRetunButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012709 RID: 75529 RVA: 0x004BC27C File Offset: 0x004BA47C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RankingUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A5C2 RID: 42434
		protected bool m_isDuringUpdate;

		// Token: 0x0400A5C3 RID: 42435
		protected bool m_isSubMenuPanelPowerShow;

		// Token: 0x0400A5C4 RID: 42436
		protected bool m_isSubMenuPanelRiftShow;

		// Token: 0x0400A5C5 RID: 42437
		protected RankingUIController.MainMenuSelectState m_mainMenuSelectState = RankingUIController.MainMenuSelectState.Power;

		// Token: 0x0400A5C6 RID: 42438
		protected RankingListType m_currRankingType;

		// Token: 0x0400A5CA RID: 42442
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button ReturnButton;

		// Token: 0x0400A5CB RID: 42443
		[AutoBind("./SubMenumGroup/NoneSubMenuArea", AutoBindAttribute.InitState.NotInit, false)]
		public RankingSubMenuUIController SubMenuUICtrl;

		// Token: 0x0400A5CC RID: 42444
		[AutoBind("./MainMenuPanel/MainMenuScrollView/Viewport/Content/Power", AutoBindAttribute.InitState.NotInit, false)]
		public ButtonEx MainMenuPowerButton;

		// Token: 0x0400A5CD RID: 42445
		[AutoBind("./MainMenuPanel/MainMenuScrollView/Viewport/Content/Power", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController MainMenuPowerStateCtrl;

		// Token: 0x0400A5CE RID: 42446
		[AutoBind("./SubMenumGroup/PowerMenulList/BGImage/BGImage1/Content/TopHero", AutoBindAttribute.InitState.NotInit, false)]
		public ButtonEx SubMenuTopHeroButton;

		// Token: 0x0400A5CF RID: 42447
		[AutoBind("./SubMenumGroup/PowerMenulList/BGImage/BGImage1/Content/TopHero", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SubMenuTopHeroStateCtrl;

		// Token: 0x0400A5D0 RID: 42448
		[AutoBind("./SubMenumGroup/PowerMenulList/BGImage/BGImage1/Content/AllHero", AutoBindAttribute.InitState.NotInit, false)]
		public ButtonEx SubMenuAllHeroButton;

		// Token: 0x0400A5D1 RID: 42449
		[AutoBind("./SubMenumGroup/PowerMenulList/BGImage/BGImage1/Content/AllHero", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SubMenuAllHeroStateCtrl;

		// Token: 0x0400A5D2 RID: 42450
		[AutoBind("./SubMenumGroup/PowerMenulList/BGImage/BGImage1/Content/ChampionHero", AutoBindAttribute.InitState.NotInit, false)]
		public ButtonEx SubMenuChampionHeroButton;

		// Token: 0x0400A5D3 RID: 42451
		[AutoBind("./SubMenumGroup/PowerMenulList/BGImage/BGImage1/Content/ChampionHero", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SubMenuChampionHeroStateCtrl;

		// Token: 0x0400A5D4 RID: 42452
		[AutoBind("./MainMenuPanel/MainMenuScrollView/Viewport/Content/Rift", AutoBindAttribute.InitState.NotInit, false)]
		public ButtonEx MainMenuRiftButton;

		// Token: 0x0400A5D5 RID: 42453
		[AutoBind("./MainMenuPanel/MainMenuScrollView/Viewport/Content/Rift", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController MainMenuRiftStateCtrl;

		// Token: 0x0400A5D6 RID: 42454
		[AutoBind("./SubMenumGroup/RiftMenuList/BGImage/BGImage1/Content/RiftChapterStar", AutoBindAttribute.InitState.NotInit, false)]
		public ButtonEx SubMenuRiftChapterStarButton;

		// Token: 0x0400A5D7 RID: 42455
		[AutoBind("./SubMenumGroup/RiftMenuList/BGImage/BGImage1/Content/RiftChapterStar", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SubMenuRiftChapterStarStateCtrl;

		// Token: 0x0400A5D8 RID: 42456
		[AutoBind("./SubMenumGroup/RiftMenuList/BGImage/BGImage1/Content/RiftAchievement", AutoBindAttribute.InitState.NotInit, false)]
		public ButtonEx SubMenuRiftAchievementButton;

		// Token: 0x0400A5D9 RID: 42457
		[AutoBind("./SubMenumGroup/RiftMenuList/BGImage/BGImage1/Content/RiftAchievement", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SubMenuRiftAchievementStateCtrl;

		// Token: 0x0400A5DA RID: 42458
		[AutoBind("./MainMenuPanel/MainMenuScrollView/Viewport/Content/Stage", AutoBindAttribute.InitState.NotInit, false)]
		public ButtonEx MainMenuStageButton;

		// Token: 0x0400A5DB RID: 42459
		[AutoBind("./MainMenuPanel/MainMenuScrollView/Viewport/Content/Stage", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController MainMenuStageStateCtrl;

		// Token: 0x0400A5DC RID: 42460
		[AutoBind("./SubMenumGroup/PowerMenulList", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SubMenuPanelPowerStateCtrl;

		// Token: 0x0400A5DD RID: 42461
		[AutoBind("./SubMenumGroup/RiftMenuList", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SubMenuPanelRiftStateCtrl;

		// Token: 0x0400A5DE RID: 42462
		[AutoBind("./SubMenumGroup/StageMenuList", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SubMenuPanelStageStateCtrl;

		// Token: 0x0400A5DF RID: 42463
		[DoNotToLua]
		private RankingUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A5E0 RID: 42464
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A5E1 RID: 42465
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A5E2 RID: 42466
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A5E3 RID: 42467
		private LuaFunction m_UpdateRankingUICtrlRankingListType_hotfix;

		// Token: 0x0400A5E4 RID: 42468
		private LuaFunction m_GetMainMenuSelectStateFromRankingTypeRankingListType_hotfix;

		// Token: 0x0400A5E5 RID: 42469
		private LuaFunction m_SetMainMenuSelectStateMainMenuSelectState_hotfix;

		// Token: 0x0400A5E6 RID: 42470
		private LuaFunction m_SetAllMainMenuUnselect_hotfix;

		// Token: 0x0400A5E7 RID: 42471
		private LuaFunction m_SetSubMenuSelectStateRankingListType_hotfix;

		// Token: 0x0400A5E8 RID: 42472
		private LuaFunction m_SetAllSubMenuToggleUnselect_hotfix;

		// Token: 0x0400A5E9 RID: 42473
		private LuaFunction m_ShowPowerSubMenuPanelBoolean_hotfix;

		// Token: 0x0400A5EA RID: 42474
		private LuaFunction m_ShowRiftSubMenuPanelBoolean_hotfix;

		// Token: 0x0400A5EB RID: 42475
		private LuaFunction m_HideAllSubMenuPanel_hotfix;

		// Token: 0x0400A5EC RID: 42476
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400A5ED RID: 42477
		private LuaFunction m_OnNoneSubMenuAreaClick_hotfix;

		// Token: 0x0400A5EE RID: 42478
		private LuaFunction m_OnMainMenuPowerClick_hotfix;

		// Token: 0x0400A5EF RID: 42479
		private LuaFunction m_OnMainMenuRiftClick_hotfix;

		// Token: 0x0400A5F0 RID: 42480
		private LuaFunction m_OnMainMenuStageClick_hotfix;

		// Token: 0x0400A5F1 RID: 42481
		private LuaFunction m_OnRankingTypeMenuClickRankingListType_hotfix;

		// Token: 0x0400A5F2 RID: 42482
		private LuaFunction m_OnSubMenuTopHeroClick_hotfix;

		// Token: 0x0400A5F3 RID: 42483
		private LuaFunction m_OnSubMenuAllHeroClick_hotfix;

		// Token: 0x0400A5F4 RID: 42484
		private LuaFunction m_OnSubMenuChampionHeroClick_hotfix;

		// Token: 0x0400A5F5 RID: 42485
		private LuaFunction m_OnSubMenuRiftChapterStarClick_hotfix;

		// Token: 0x0400A5F6 RID: 42486
		private LuaFunction m_OnSubMenuRiftAchievementClick_hotfix;

		// Token: 0x0400A5F7 RID: 42487
		private LuaFunction m_add_EventOnRankingTypeMenuClickAction;

		// Token: 0x0400A5F8 RID: 42488
		private LuaFunction m_remove_EventOnRankingTypeMenuClickAction;

		// Token: 0x0400A5F9 RID: 42489
		private LuaFunction m_add_EventOnResetRankingTypeAction_hotfix;

		// Token: 0x0400A5FA RID: 42490
		private LuaFunction m_remove_EventOnResetRankingTypeAction_hotfix;

		// Token: 0x0400A5FB RID: 42491
		private LuaFunction m_add_EventOnRetunButtonClickAction_hotfix;

		// Token: 0x0400A5FC RID: 42492
		private LuaFunction m_remove_EventOnRetunButtonClickAction_hotfix;

		// Token: 0x02000EBB RID: 3771
		public enum MainMenuSelectState
		{
			// Token: 0x0400A5FE RID: 42494
			None,
			// Token: 0x0400A5FF RID: 42495
			Power,
			// Token: 0x0400A600 RID: 42496
			Rift,
			// Token: 0x0400A601 RID: 42497
			Stage
		}

		// Token: 0x02000EBC RID: 3772
		public new class LuaExportHelper
		{
			// Token: 0x0601270A RID: 75530 RVA: 0x004BC2E4 File Offset: 0x004BA4E4
			public LuaExportHelper(RankingUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601270B RID: 75531 RVA: 0x004BC2F4 File Offset: 0x004BA4F4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601270C RID: 75532 RVA: 0x004BC304 File Offset: 0x004BA504
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601270D RID: 75533 RVA: 0x004BC314 File Offset: 0x004BA514
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601270E RID: 75534 RVA: 0x004BC324 File Offset: 0x004BA524
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601270F RID: 75535 RVA: 0x004BC33C File Offset: 0x004BA53C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012710 RID: 75536 RVA: 0x004BC34C File Offset: 0x004BA54C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012711 RID: 75537 RVA: 0x004BC35C File Offset: 0x004BA55C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012712 RID: 75538 RVA: 0x004BC36C File Offset: 0x004BA56C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012713 RID: 75539 RVA: 0x004BC37C File Offset: 0x004BA57C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012714 RID: 75540 RVA: 0x004BC38C File Offset: 0x004BA58C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012715 RID: 75541 RVA: 0x004BC39C File Offset: 0x004BA59C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012716 RID: 75542 RVA: 0x004BC3AC File Offset: 0x004BA5AC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012717 RID: 75543 RVA: 0x004BC3BC File Offset: 0x004BA5BC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012718 RID: 75544 RVA: 0x004BC3CC File Offset: 0x004BA5CC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012719 RID: 75545 RVA: 0x004BC3DC File Offset: 0x004BA5DC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601271A RID: 75546 RVA: 0x004BC3EC File Offset: 0x004BA5EC
			public void __callDele_EventOnRankingTypeMenuClick(RankingListType obj)
			{
				this.m_owner.__callDele_EventOnRankingTypeMenuClick(obj);
			}

			// Token: 0x0601271B RID: 75547 RVA: 0x004BC3FC File Offset: 0x004BA5FC
			public void __clearDele_EventOnRankingTypeMenuClick(RankingListType obj)
			{
				this.m_owner.__clearDele_EventOnRankingTypeMenuClick(obj);
			}

			// Token: 0x0601271C RID: 75548 RVA: 0x004BC40C File Offset: 0x004BA60C
			public void __callDele_EventOnResetRankingType()
			{
				this.m_owner.__callDele_EventOnResetRankingType();
			}

			// Token: 0x0601271D RID: 75549 RVA: 0x004BC41C File Offset: 0x004BA61C
			public void __clearDele_EventOnResetRankingType()
			{
				this.m_owner.__clearDele_EventOnResetRankingType();
			}

			// Token: 0x0601271E RID: 75550 RVA: 0x004BC42C File Offset: 0x004BA62C
			public void __callDele_EventOnRetunButtonClick()
			{
				this.m_owner.__callDele_EventOnRetunButtonClick();
			}

			// Token: 0x0601271F RID: 75551 RVA: 0x004BC43C File Offset: 0x004BA63C
			public void __clearDele_EventOnRetunButtonClick()
			{
				this.m_owner.__clearDele_EventOnRetunButtonClick();
			}

			// Token: 0x170037D2 RID: 14290
			// (get) Token: 0x06012720 RID: 75552 RVA: 0x004BC44C File Offset: 0x004BA64C
			// (set) Token: 0x06012721 RID: 75553 RVA: 0x004BC45C File Offset: 0x004BA65C
			public bool m_isDuringUpdate
			{
				get
				{
					return this.m_owner.m_isDuringUpdate;
				}
				set
				{
					this.m_owner.m_isDuringUpdate = value;
				}
			}

			// Token: 0x170037D3 RID: 14291
			// (get) Token: 0x06012722 RID: 75554 RVA: 0x004BC46C File Offset: 0x004BA66C
			// (set) Token: 0x06012723 RID: 75555 RVA: 0x004BC47C File Offset: 0x004BA67C
			public bool m_isSubMenuPanelPowerShow
			{
				get
				{
					return this.m_owner.m_isSubMenuPanelPowerShow;
				}
				set
				{
					this.m_owner.m_isSubMenuPanelPowerShow = value;
				}
			}

			// Token: 0x170037D4 RID: 14292
			// (get) Token: 0x06012724 RID: 75556 RVA: 0x004BC48C File Offset: 0x004BA68C
			// (set) Token: 0x06012725 RID: 75557 RVA: 0x004BC49C File Offset: 0x004BA69C
			public bool m_isSubMenuPanelRiftShow
			{
				get
				{
					return this.m_owner.m_isSubMenuPanelRiftShow;
				}
				set
				{
					this.m_owner.m_isSubMenuPanelRiftShow = value;
				}
			}

			// Token: 0x170037D5 RID: 14293
			// (get) Token: 0x06012726 RID: 75558 RVA: 0x004BC4AC File Offset: 0x004BA6AC
			// (set) Token: 0x06012727 RID: 75559 RVA: 0x004BC4BC File Offset: 0x004BA6BC
			public RankingUIController.MainMenuSelectState m_mainMenuSelectState
			{
				get
				{
					return this.m_owner.m_mainMenuSelectState;
				}
				set
				{
					this.m_owner.m_mainMenuSelectState = value;
				}
			}

			// Token: 0x170037D6 RID: 14294
			// (get) Token: 0x06012728 RID: 75560 RVA: 0x004BC4CC File Offset: 0x004BA6CC
			// (set) Token: 0x06012729 RID: 75561 RVA: 0x004BC4DC File Offset: 0x004BA6DC
			public RankingListType m_currRankingType
			{
				get
				{
					return this.m_owner.m_currRankingType;
				}
				set
				{
					this.m_owner.m_currRankingType = value;
				}
			}

			// Token: 0x0601272A RID: 75562 RVA: 0x004BC4EC File Offset: 0x004BA6EC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601272B RID: 75563 RVA: 0x004BC4FC File Offset: 0x004BA6FC
			public RankingUIController.MainMenuSelectState GetMainMenuSelectStateFromRankingType(RankingListType rankingType)
			{
				return this.m_owner.GetMainMenuSelectStateFromRankingType(rankingType);
			}

			// Token: 0x0601272C RID: 75564 RVA: 0x004BC50C File Offset: 0x004BA70C
			public void SetMainMenuSelectState(RankingUIController.MainMenuSelectState state)
			{
				this.m_owner.SetMainMenuSelectState(state);
			}

			// Token: 0x0601272D RID: 75565 RVA: 0x004BC51C File Offset: 0x004BA71C
			public void SetAllMainMenuUnselect()
			{
				this.m_owner.SetAllMainMenuUnselect();
			}

			// Token: 0x0601272E RID: 75566 RVA: 0x004BC52C File Offset: 0x004BA72C
			public void SetSubMenuSelectState(RankingListType rankType)
			{
				this.m_owner.SetSubMenuSelectState(rankType);
			}

			// Token: 0x0601272F RID: 75567 RVA: 0x004BC53C File Offset: 0x004BA73C
			public void SetAllSubMenuToggleUnselect()
			{
				this.m_owner.SetAllSubMenuToggleUnselect();
			}

			// Token: 0x06012730 RID: 75568 RVA: 0x004BC54C File Offset: 0x004BA74C
			public void ShowPowerSubMenuPanel(bool isshow)
			{
				this.m_owner.ShowPowerSubMenuPanel(isshow);
			}

			// Token: 0x06012731 RID: 75569 RVA: 0x004BC55C File Offset: 0x004BA75C
			public void ShowRiftSubMenuPanel(bool isshow)
			{
				this.m_owner.ShowRiftSubMenuPanel(isshow);
			}

			// Token: 0x06012732 RID: 75570 RVA: 0x004BC56C File Offset: 0x004BA76C
			public void HideAllSubMenuPanel()
			{
				this.m_owner.HideAllSubMenuPanel();
			}

			// Token: 0x06012733 RID: 75571 RVA: 0x004BC57C File Offset: 0x004BA77C
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06012734 RID: 75572 RVA: 0x004BC58C File Offset: 0x004BA78C
			public void OnNoneSubMenuAreaClick()
			{
				this.m_owner.OnNoneSubMenuAreaClick();
			}

			// Token: 0x06012735 RID: 75573 RVA: 0x004BC59C File Offset: 0x004BA79C
			public void OnMainMenuPowerClick()
			{
				this.m_owner.OnMainMenuPowerClick();
			}

			// Token: 0x06012736 RID: 75574 RVA: 0x004BC5AC File Offset: 0x004BA7AC
			public void OnMainMenuRiftClick()
			{
				this.m_owner.OnMainMenuRiftClick();
			}

			// Token: 0x06012737 RID: 75575 RVA: 0x004BC5BC File Offset: 0x004BA7BC
			public void OnMainMenuStageClick()
			{
				this.m_owner.OnMainMenuStageClick();
			}

			// Token: 0x06012738 RID: 75576 RVA: 0x004BC5CC File Offset: 0x004BA7CC
			public void OnRankingTypeMenuClick(RankingListType rankListType)
			{
				this.m_owner.OnRankingTypeMenuClick(rankListType);
			}

			// Token: 0x06012739 RID: 75577 RVA: 0x004BC5DC File Offset: 0x004BA7DC
			public void OnSubMenuTopHeroClick()
			{
				this.m_owner.OnSubMenuTopHeroClick();
			}

			// Token: 0x0601273A RID: 75578 RVA: 0x004BC5EC File Offset: 0x004BA7EC
			public void OnSubMenuAllHeroClick()
			{
				this.m_owner.OnSubMenuAllHeroClick();
			}

			// Token: 0x0601273B RID: 75579 RVA: 0x004BC5FC File Offset: 0x004BA7FC
			public void OnSubMenuChampionHeroClick()
			{
				this.m_owner.OnSubMenuChampionHeroClick();
			}

			// Token: 0x0601273C RID: 75580 RVA: 0x004BC60C File Offset: 0x004BA80C
			public void OnSubMenuRiftChapterStarClick()
			{
				this.m_owner.OnSubMenuRiftChapterStarClick();
			}

			// Token: 0x0601273D RID: 75581 RVA: 0x004BC61C File Offset: 0x004BA81C
			public void OnSubMenuRiftAchievementClick()
			{
				this.m_owner.OnSubMenuRiftAchievementClick();
			}

			// Token: 0x0400A602 RID: 42498
			private RankingUIController m_owner;
		}
	}
}
