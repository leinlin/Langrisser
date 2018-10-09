using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AAC RID: 2732
	[HotFix]
	public class BattleResultUIController : UIControllerBase
	{
		// Token: 0x0600B03D RID: 45117 RVA: 0x0030DF20 File Offset: 0x0030C120
		private BattleResultUIController()
		{
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x0030DF34 File Offset: 0x0030C134
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_achievementItemUIController = GameObjectUtility.AddControllerToGameObject<BattleAchievementItemUIController>(this.m_achievementGameObject);
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600B03F RID: 45119 RVA: 0x0030DFD4 File Offset: 0x0030C1D4
		public void ShowBattleResult(BattleType battleType, List<Hero> heros, int stars, int starTurnMax, int starDeadMax, int turn, BattleReward reward, List<int> gotAchievements, BattleLevelAchievement[] achievements)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBattleResultBattleTypeList`1Int32Int32Int32Int32BattleRewardList`1BattleLevelAchievementbe_hotfix != null)
			{
				this.m_ShowBattleResultBattleTypeList`1Int32Int32Int32Int32BattleRewardList`1BattleLevelAchievementbe_hotfix.call(new object[]
				{
					this,
					battleType,
					heros,
					stars,
					starTurnMax,
					starDeadMax,
					turn,
					reward,
					gotAchievements,
					achievements
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_ShowBattleResult(battleType, heros, stars, starTurnMax, starDeadMax, turn, reward, gotAchievements, achievements));
		}

		// Token: 0x0600B040 RID: 45120 RVA: 0x0030E0E0 File Offset: 0x0030C2E0
		[DebuggerHidden]
		private IEnumerator Co_ShowBattleResult(BattleType battleType, List<Hero> heros, int stars, int starTurnMax, int starDeadMax, int turn, BattleReward reward, List<int> gotAchievements, BattleLevelAchievement[] achievements)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowBattleResultBattleTypeList`1Int32Int32Int32Int32BattleRewardList`1BattleLevelAchievementbe_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowBattleResultBattleTypeList`1Int32Int32Int32Int32BattleRewardList`1BattleLevelAchievementbe_hotfix.call(new object[]
				{
					this,
					battleType,
					heros,
					stars,
					starTurnMax,
					starDeadMax,
					turn,
					reward,
					gotAchievements,
					achievements
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultUIController.<Co_ShowBattleResult>c__Iterator0 <Co_ShowBattleResult>c__Iterator = new BattleResultUIController.<Co_ShowBattleResult>c__Iterator0();
			<Co_ShowBattleResult>c__Iterator.battleType = battleType;
			<Co_ShowBattleResult>c__Iterator.reward = reward;
			<Co_ShowBattleResult>c__Iterator.stars = stars;
			<Co_ShowBattleResult>c__Iterator.starTurnMax = starTurnMax;
			<Co_ShowBattleResult>c__Iterator.starDeadMax = starDeadMax;
			<Co_ShowBattleResult>c__Iterator.turn = turn;
			<Co_ShowBattleResult>c__Iterator.heros = heros;
			<Co_ShowBattleResult>c__Iterator.achievements = achievements;
			<Co_ShowBattleResult>c__Iterator.gotAchievements = gotAchievements;
			<Co_ShowBattleResult>c__Iterator.$this = this;
			return <Co_ShowBattleResult>c__Iterator;
		}

		// Token: 0x0600B041 RID: 45121 RVA: 0x0030E230 File Offset: 0x0030C430
		[DebuggerHidden]
		private IEnumerator AddPlayerExpBarWidth()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddPlayerExpBarWidth_hotfix != null)
			{
				return (IEnumerator)this.m_AddPlayerExpBarWidth_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultUIController.<AddPlayerExpBarWidth>c__Iterator1 <AddPlayerExpBarWidth>c__Iterator = new BattleResultUIController.<AddPlayerExpBarWidth>c__Iterator1();
			<AddPlayerExpBarWidth>c__Iterator.$this = this;
			return <AddPlayerExpBarWidth>c__Iterator;
		}

		// Token: 0x0600B042 RID: 45122 RVA: 0x0030E2AC File Offset: 0x0030C4AC
		private void UpdateTextValue(float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTextValueSingle_hotfix != null)
			{
				this.m_UpdateTextValueSingle_hotfix.call(new object[]
				{
					this,
					scale
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_singleAddExp = (float)this.m_finalPlayerExp / (this.m_playerExpTotalWidth * scale / (100f * Time.deltaTime));
			this.m_singleAddGold = (float)this.m_finalPlayerGold / (this.m_playerExpTotalWidth * scale / (100f * Time.deltaTime));
			float num = this.m_beforePlayerExp + this.m_singleAddExp;
			if (num >= (float)this.m_finalPlayerExp)
			{
				this.m_playerExpText.text = string.Empty + this.m_finalPlayerExp;
			}
			else
			{
				if (Math.Ceiling((double)this.m_beforePlayerExp) != Math.Ceiling((double)num))
				{
					this.m_playerExpText.text = string.Empty + Math.Ceiling((double)num);
				}
				this.m_beforePlayerExp = num;
			}
			float num2 = this.m_beforePlayerGold + this.m_singleAddGold;
			if (num2 >= (float)this.m_finalPlayerGold)
			{
				this.m_goldText.text = string.Empty + this.m_finalPlayerGold;
			}
			else
			{
				if (Math.Ceiling((double)this.m_beforePlayerGold) != Math.Ceiling((double)num2))
				{
					this.m_goldText.text = string.Empty + Math.Ceiling((double)num2);
				}
				this.m_beforePlayerGold = num2;
			}
		}

		// Token: 0x0600B043 RID: 45123 RVA: 0x0030E460 File Offset: 0x0030C660
		[DebuggerHidden]
		private IEnumerator Co_ShowStars(BattleType battleType, int stars, int starTurnMax, int starDeadMax, int turn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowStarsBattleTypeInt32Int32Int32Int32_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowStarsBattleTypeInt32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					battleType,
					stars,
					starTurnMax,
					starDeadMax,
					turn
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultUIController.<Co_ShowStars>c__Iterator2 <Co_ShowStars>c__Iterator = new BattleResultUIController.<Co_ShowStars>c__Iterator2();
			<Co_ShowStars>c__Iterator.starTurnMax = starTurnMax;
			<Co_ShowStars>c__Iterator.starDeadMax = starDeadMax;
			<Co_ShowStars>c__Iterator.battleType = battleType;
			<Co_ShowStars>c__Iterator.stars = stars;
			<Co_ShowStars>c__Iterator.turn = turn;
			<Co_ShowStars>c__Iterator.$this = this;
			return <Co_ShowStars>c__Iterator;
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x0030E550 File Offset: 0x0030C750
		[DebuggerHidden]
		private IEnumerator Co_ShowHeros(BattleReward reward, List<Hero> heros)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowHerosBattleRewardList`1_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowHerosBattleRewardList`1_hotfix.call(new object[]
				{
					this,
					reward,
					heros
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultUIController.<Co_ShowHeros>c__Iterator3 <Co_ShowHeros>c__Iterator = new BattleResultUIController.<Co_ShowHeros>c__Iterator3();
			<Co_ShowHeros>c__Iterator.heros = heros;
			<Co_ShowHeros>c__Iterator.$this = this;
			return <Co_ShowHeros>c__Iterator;
		}

		// Token: 0x0600B045 RID: 45125 RVA: 0x0030E5F4 File Offset: 0x0030C7F4
		[DebuggerHidden]
		private IEnumerator Co_ShowEnemyBoomToGold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowEnemyBoomToGold_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowEnemyBoomToGold_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultUIController.<Co_ShowEnemyBoomToGold>c__Iterator4 <Co_ShowEnemyBoomToGold>c__Iterator = new BattleResultUIController.<Co_ShowEnemyBoomToGold>c__Iterator4();
			<Co_ShowEnemyBoomToGold>c__Iterator.$this = this;
			return <Co_ShowEnemyBoomToGold>c__Iterator;
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x0030E670 File Offset: 0x0030C870
		private void AutoMoveItemWhenOutOfScrollRect(EnemyBoomToGoldUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoMoveItemWhenOutOfScrollRectEnemyBoomToGoldUIController_hotfix != null)
			{
				this.m_AutoMoveItemWhenOutOfScrollRectEnemyBoomToGoldUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 cellSize = this.m_treasureMapRewardGroupGridLayputGroup.cellSize;
			Vector2 vector = ((RectTransform)ctrl.transform).anchoredPosition + this.m_treasureMapRewardGroupScrollRect.content.anchoredPosition;
			if (this.m_treasureMapRewardGroupScrollRect.horizontal)
			{
				float width = this.m_treasureMapRewardGroupScrollRect.viewport.rect.width;
				if (-vector.x + cellSize.x / 2f > width)
				{
					this.m_treasureMapRewardGroupScrollRect.content.anchoredPosition += new Vector2(-vector.x + cellSize.x / 2f - width, 0f);
				}
			}
			else if (this.m_treasureMapRewardGroupScrollRect.vertical)
			{
				float height = this.m_treasureMapRewardGroupScrollRect.viewport.rect.height;
				if (-vector.y + cellSize.y / 2f > height)
				{
					this.m_treasureMapRewardGroupScrollRect.content.anchoredPosition += new Vector2(0f, -vector.y + cellSize.y / 2f - height);
				}
			}
		}

		// Token: 0x0600B047 RID: 45127 RVA: 0x0030E820 File Offset: 0x0030CA20
		[DebuggerHidden]
		private IEnumerator Co_ShowPlayerLevelUp(int oldLevel, int newLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowPlayerLevelUpInt32Int32_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowPlayerLevelUpInt32Int32_hotfix.call(new object[]
				{
					this,
					oldLevel,
					newLevel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultUIController.<Co_ShowPlayerLevelUp>c__Iterator5 <Co_ShowPlayerLevelUp>c__Iterator = new BattleResultUIController.<Co_ShowPlayerLevelUp>c__Iterator5();
			<Co_ShowPlayerLevelUp>c__Iterator.oldLevel = oldLevel;
			<Co_ShowPlayerLevelUp>c__Iterator.newLevel = newLevel;
			<Co_ShowPlayerLevelUp>c__Iterator.$this = this;
			return <Co_ShowPlayerLevelUp>c__Iterator;
		}

		// Token: 0x0600B048 RID: 45128 RVA: 0x0030E8C8 File Offset: 0x0030CAC8
		[DebuggerHidden]
		private IEnumerator Co_ShowAchievements(List<int> gotAchievements, BattleLevelAchievement[] achievements)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowAchievementsList`1BattleLevelAchievementbe_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowAchievementsList`1BattleLevelAchievementbe_hotfix.call(new object[]
				{
					this,
					gotAchievements,
					achievements
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultUIController.<Co_ShowAchievements>c__Iterator6 <Co_ShowAchievements>c__Iterator = new BattleResultUIController.<Co_ShowAchievements>c__Iterator6();
			<Co_ShowAchievements>c__Iterator.gotAchievements = gotAchievements;
			<Co_ShowAchievements>c__Iterator.achievements = achievements;
			<Co_ShowAchievements>c__Iterator.$this = this;
			return <Co_ShowAchievements>c__Iterator;
		}

		// Token: 0x0600B049 RID: 45129 RVA: 0x0030E970 File Offset: 0x0030CB70
		[DebuggerHidden]
		private IEnumerator Co_SetGoldValueChanged(float changeValue)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_SetGoldValueChangedSingle_hotfix != null)
			{
				return (IEnumerator)this.m_Co_SetGoldValueChangedSingle_hotfix.call(new object[]
				{
					this,
					changeValue
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultUIController.<Co_SetGoldValueChanged>c__Iterator7 <Co_SetGoldValueChanged>c__Iterator = new BattleResultUIController.<Co_SetGoldValueChanged>c__Iterator7();
			<Co_SetGoldValueChanged>c__Iterator.changeValue = changeValue;
			<Co_SetGoldValueChanged>c__Iterator.$this = this;
			return <Co_SetGoldValueChanged>c__Iterator;
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x0030EA04 File Offset: 0x0030CC04
		[DebuggerHidden]
		private IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix != null)
			{
				return (IEnumerator)this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix.call(new object[]
				{
					this,
					ctrl,
					state
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultUIController.<Co_SetAndWaitUIState>c__Iterator8 <Co_SetAndWaitUIState>c__Iterator = new BattleResultUIController.<Co_SetAndWaitUIState>c__Iterator8();
			<Co_SetAndWaitUIState>c__Iterator.ctrl = ctrl;
			<Co_SetAndWaitUIState>c__Iterator.state = state;
			return <Co_SetAndWaitUIState>c__Iterator;
		}

		// Token: 0x0600B04B RID: 45131 RVA: 0x0030EAA8 File Offset: 0x0030CCA8
		[DebuggerHidden]
		private IEnumerator Co_WaitClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_WaitClick_hotfix != null)
			{
				return (IEnumerator)this.m_Co_WaitClick_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultUIController.<Co_WaitClick>c__Iterator9 <Co_WaitClick>c__Iterator = new BattleResultUIController.<Co_WaitClick>c__Iterator9();
			<Co_WaitClick>c__Iterator.$this = this;
			return <Co_WaitClick>c__Iterator;
		}

		// Token: 0x0600B04C RID: 45132 RVA: 0x0030EB24 File Offset: 0x0030CD24
		private void PlayerLevelUpUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerLevelUpUITask_OnClose_hotfix != null)
			{
				this.m_PlayerLevelUpUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerLevelUpUITask != null)
			{
				this.m_playerLevelUpUITask.EventOnClose -= this.PlayerLevelUpUITask_OnClose;
				this.m_playerLevelUpUITask = null;
			}
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x0030EBB0 File Offset: 0x0030CDB0
		private void ClearHeroItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearHeroItems_hotfix != null)
			{
				this.m_ClearHeroItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<RewardHeroUIController>(this.m_rewardHeros);
			this.m_rewardHeros.Clear();
		}

		// Token: 0x0600B04E RID: 45134 RVA: 0x0030EC28 File Offset: 0x0030CE28
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isClick = true;
		}

		// Token: 0x1400021A RID: 538
		// (add) Token: 0x0600B04F RID: 45135 RVA: 0x0030EC90 File Offset: 0x0030CE90
		// (remove) Token: 0x0600B050 RID: 45136 RVA: 0x0030ED2C File Offset: 0x0030CF2C
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0600B051 RID: 45137 RVA: 0x0030EDC8 File Offset: 0x0030CFC8
		// (set) Token: 0x0600B052 RID: 45138 RVA: 0x0030EDE8 File Offset: 0x0030CFE8
		[DoNotToLua]
		public new BattleResultUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleResultUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x0030EDF4 File Offset: 0x0030CFF4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x0030EE00 File Offset: 0x0030D000
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600B055 RID: 45141 RVA: 0x0030EE08 File Offset: 0x0030D008
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600B056 RID: 45142 RVA: 0x0030EE10 File Offset: 0x0030D010
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600B057 RID: 45143 RVA: 0x0030EE24 File Offset: 0x0030D024
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x0030EE2C File Offset: 0x0030D02C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600B059 RID: 45145 RVA: 0x0030EE38 File Offset: 0x0030D038
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600B05A RID: 45146 RVA: 0x0030EE44 File Offset: 0x0030D044
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x0030EE50 File Offset: 0x0030D050
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x0030EE5C File Offset: 0x0030D05C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x0030EE68 File Offset: 0x0030D068
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600B05E RID: 45150 RVA: 0x0030EE74 File Offset: 0x0030D074
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600B05F RID: 45151 RVA: 0x0030EE80 File Offset: 0x0030D080
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600B060 RID: 45152 RVA: 0x0030EE8C File Offset: 0x0030D08C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600B061 RID: 45153 RVA: 0x0030EE98 File Offset: 0x0030D098
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x0030EEA0 File Offset: 0x0030D0A0
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x0030EEC0 File Offset: 0x0030D0C0
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x0030EECC File Offset: 0x0030D0CC
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
					this.m_ShowBattleResultBattleTypeList`1Int32Int32Int32Int32BattleRewardList`1BattleLevelAchievementbe_hotfix = (luaObj.RawGet("ShowBattleResult") as LuaFunction);
					this.m_Co_ShowBattleResultBattleTypeList`1Int32Int32Int32Int32BattleRewardList`1BattleLevelAchievementbe_hotfix = (luaObj.RawGet("Co_ShowBattleResult") as LuaFunction);
					this.m_AddPlayerExpBarWidth_hotfix = (luaObj.RawGet("AddPlayerExpBarWidth") as LuaFunction);
					this.m_UpdateTextValueSingle_hotfix = (luaObj.RawGet("UpdateTextValue") as LuaFunction);
					this.m_Co_ShowStarsBattleTypeInt32Int32Int32Int32_hotfix = (luaObj.RawGet("Co_ShowStars") as LuaFunction);
					this.m_Co_ShowHerosBattleRewardList`1_hotfix = (luaObj.RawGet("Co_ShowHeros") as LuaFunction);
					this.m_Co_ShowEnemyBoomToGold_hotfix = (luaObj.RawGet("Co_ShowEnemyBoomToGold") as LuaFunction);
					this.m_AutoMoveItemWhenOutOfScrollRectEnemyBoomToGoldUIController_hotfix = (luaObj.RawGet("AutoMoveItemWhenOutOfScrollRect") as LuaFunction);
					this.m_Co_ShowPlayerLevelUpInt32Int32_hotfix = (luaObj.RawGet("Co_ShowPlayerLevelUp") as LuaFunction);
					this.m_Co_ShowAchievementsList`1BattleLevelAchievementbe_hotfix = (luaObj.RawGet("Co_ShowAchievements") as LuaFunction);
					this.m_Co_SetGoldValueChangedSingle_hotfix = (luaObj.RawGet("Co_SetGoldValueChanged") as LuaFunction);
					this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix = (luaObj.RawGet("Co_SetAndWaitUIState") as LuaFunction);
					this.m_Co_WaitClick_hotfix = (luaObj.RawGet("Co_WaitClick") as LuaFunction);
					this.m_PlayerLevelUpUITask_OnClose_hotfix = (luaObj.RawGet("PlayerLevelUpUITask_OnClose") as LuaFunction);
					this.m_ClearHeroItems_hotfix = (luaObj.RawGet("ClearHeroItems") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x0030F15C File Offset: 0x0030D35C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleResultUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040072AF RID: 29359
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x040072B0 RID: 29360
		[AutoBind("./AccountingPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_accountingPanelUIStateController;

		// Token: 0x040072B1 RID: 29361
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Stars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_starsGameObject;

		// Token: 0x040072B2 RID: 29362
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Stars/Star1", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_star1UIStateController;

		// Token: 0x040072B3 RID: 29363
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Stars/Star2", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_star2UIStateController;

		// Token: 0x040072B4 RID: 29364
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Stars/Star2/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_star2Text;

		// Token: 0x040072B5 RID: 29365
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Stars/Star3", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_star3UIStateController;

		// Token: 0x040072B6 RID: 29366
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Stars/Star3/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_star3Text;

		// Token: 0x040072B7 RID: 29367
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/ArenaResult", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arenaResultGameObject;

		// Token: 0x040072B8 RID: 29368
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/ArenaResult/ArenaPoint/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_arenaPointText;

		// Token: 0x040072B9 RID: 29369
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/ArenaResult/VictoryPoint/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_arenaVictoryPointText;

		// Token: 0x040072BA RID: 29370
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/ArenaResult/ArenaPoint/AutoFightText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arenaAutoFightGameObject;

		// Token: 0x040072BB RID: 29371
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/RealtimePVPResult", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_realtimePVPResultGameObject;

		// Token: 0x040072BC RID: 29372
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/RealtimePVPResult/Score/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_realtimePVPScoreText;

		// Token: 0x040072BD RID: 29373
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/RealtimePVPResult/Win/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_realtimePVPWinText;

		// Token: 0x040072BE RID: 29374
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/RealtimePVPResult/Score/WinBonusText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_realtimePVPWinBonusGameObject;

		// Token: 0x040072BF RID: 29375
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/RealtimePVPResult/Score/WinBonusText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_realtimePVPWinBonusText;

		// Token: 0x040072C0 RID: 29376
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Gold", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_goldGameObject;

		// Token: 0x040072C1 RID: 29377
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Exp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_expGameObject;

		// Token: 0x040072C2 RID: 29378
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Gold/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_goldText;

		// Token: 0x040072C3 RID: 29379
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Exp/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerExpText;

		// Token: 0x040072C4 RID: 29380
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Exp/EXP/LvNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerGroupLvText;

		// Token: 0x040072C5 RID: 29381
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Exp/EXP/ExpProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerExpImage;

		// Token: 0x040072C6 RID: 29382
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/Exp/LevelUpEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerLevelUpGameObject;

		// Token: 0x040072C7 RID: 29383
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/HeroExp/HeroGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroGroupGameObject;

		// Token: 0x040072C8 RID: 29384
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/HeroExp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroExpGameObject;

		// Token: 0x040072C9 RID: 29385
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/EnemyBoomToGold/Gold/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_enemyBoomToGoldText;

		// Token: 0x040072CA RID: 29386
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/EnemyBoomToGold", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enemyBoomToGoldGameObject;

		// Token: 0x040072CB RID: 29387
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/EnemyBoomToGold/TreasureMapRewardScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_treasureMapRewardGroupGameObject;

		// Token: 0x040072CC RID: 29388
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/EnemyBoomToGold/TreasureMapRewardScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_treasureMapRewardGroupScrollRect;

		// Token: 0x040072CD RID: 29389
		[AutoBind("./AccountingPanel/BGImages/BgImage/FrameImage/EnemyBoomToGold/TreasureMapRewardScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GridLayoutGroup m_treasureMapRewardGroupGridLayputGroup;

		// Token: 0x040072CE RID: 29390
		[AutoBind("./AchievementPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_achievementPanelUIStateController;

		// Token: 0x040072CF RID: 29391
		[AutoBind("./AchievementPanel/AchievementInfo", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_achievementGameObject;

		// Token: 0x040072D0 RID: 29392
		[AutoBind("./ClickScreenContinue", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_clickScreenContinueGameObject;

		// Token: 0x040072D1 RID: 29393
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x040072D2 RID: 29394
		[AutoBind("./Prefabs/HeroItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroItemPrefab;

		// Token: 0x040072D3 RID: 29395
		[AutoBind("./Prefabs/EnemyItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enemyItemPrefab;

		// Token: 0x040072D4 RID: 29396
		private List<RewardHeroUIController> m_rewardHeros = new List<RewardHeroUIController>();

		// Token: 0x040072D5 RID: 29397
		private BattleAchievementItemUIController m_achievementItemUIController;

		// Token: 0x040072D6 RID: 29398
		private bool m_isClick;

		// Token: 0x040072D7 RID: 29399
		private PlayerLevelUpUITask m_playerLevelUpUITask;

		// Token: 0x040072D8 RID: 29400
		private float m_playerExpTotalWidth;

		// Token: 0x040072D9 RID: 29401
		private UISpineGraphic m_spineGraphic;

		// Token: 0x040072DA RID: 29402
		private float m_singleAddExp;

		// Token: 0x040072DB RID: 29403
		private float m_beforePlayerExp;

		// Token: 0x040072DC RID: 29404
		private int m_finalPlayerExp;

		// Token: 0x040072DD RID: 29405
		private float m_singleAddGold;

		// Token: 0x040072DE RID: 29406
		private float m_beforePlayerGold;

		// Token: 0x040072DF RID: 29407
		private int m_finalPlayerGold;

		// Token: 0x040072E0 RID: 29408
		[DoNotToLua]
		private BattleResultUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040072E1 RID: 29409
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040072E2 RID: 29410
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040072E3 RID: 29411
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040072E4 RID: 29412
		private LuaFunction m_ShowBattleResultBattleTypeList`1Int32Int32Int32Int32BattleRewardList;

		// Token: 0x040072E5 RID: 29413
		private LuaFunction m_Co_ShowBattleResultBattleTypeList`1Int32Int32Int32Int32BattleRewardList;

		// Token: 0x040072E6 RID: 29414
		private LuaFunction m_AddPlayerExpBarWidth_hotfix;

		// Token: 0x040072E7 RID: 29415
		private LuaFunction m_UpdateTextValueSingle_hotfix;

		// Token: 0x040072E8 RID: 29416
		private LuaFunction m_Co_ShowStarsBattleTypeInt32Int32Int32Int32_hotfix;

		// Token: 0x040072E9 RID: 29417
		private LuaFunction m_Co_ShowHerosBattleRewardList;

		// Token: 0x040072EA RID: 29418
		private LuaFunction m_Co_ShowEnemyBoomToGold_hotfix;

		// Token: 0x040072EB RID: 29419
		private LuaFunction m_AutoMoveItemWhenOutOfScrollRectEnemyBoomToGoldUIController_hotfix;

		// Token: 0x040072EC RID: 29420
		private LuaFunction m_Co_ShowPlayerLevelUpInt32Int32_hotfix;

		// Token: 0x040072ED RID: 29421
		private LuaFunction m_Co_ShowAchievementsList;

		// Token: 0x040072EE RID: 29422
		private LuaFunction m_Co_SetGoldValueChangedSingle_hotfix;

		// Token: 0x040072EF RID: 29423
		private LuaFunction m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix;

		// Token: 0x040072F0 RID: 29424
		private LuaFunction m_Co_WaitClick_hotfix;

		// Token: 0x040072F1 RID: 29425
		private LuaFunction m_PlayerLevelUpUITask_OnClose_hotfix;

		// Token: 0x040072F2 RID: 29426
		private LuaFunction m_ClearHeroItems_hotfix;

		// Token: 0x040072F3 RID: 29427
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x040072F4 RID: 29428
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040072F5 RID: 29429
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000AAD RID: 2733
		public new class LuaExportHelper
		{
			// Token: 0x0600B066 RID: 45158 RVA: 0x0030F1C4 File Offset: 0x0030D3C4
			public LuaExportHelper(BattleResultUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B067 RID: 45159 RVA: 0x0030F1D4 File Offset: 0x0030D3D4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600B068 RID: 45160 RVA: 0x0030F1E4 File Offset: 0x0030D3E4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600B069 RID: 45161 RVA: 0x0030F1F4 File Offset: 0x0030D3F4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600B06A RID: 45162 RVA: 0x0030F204 File Offset: 0x0030D404
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600B06B RID: 45163 RVA: 0x0030F21C File Offset: 0x0030D41C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600B06C RID: 45164 RVA: 0x0030F22C File Offset: 0x0030D42C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600B06D RID: 45165 RVA: 0x0030F23C File Offset: 0x0030D43C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600B06E RID: 45166 RVA: 0x0030F24C File Offset: 0x0030D44C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600B06F RID: 45167 RVA: 0x0030F25C File Offset: 0x0030D45C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600B070 RID: 45168 RVA: 0x0030F26C File Offset: 0x0030D46C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600B071 RID: 45169 RVA: 0x0030F27C File Offset: 0x0030D47C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600B072 RID: 45170 RVA: 0x0030F28C File Offset: 0x0030D48C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600B073 RID: 45171 RVA: 0x0030F29C File Offset: 0x0030D49C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600B074 RID: 45172 RVA: 0x0030F2AC File Offset: 0x0030D4AC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600B075 RID: 45173 RVA: 0x0030F2BC File Offset: 0x0030D4BC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600B076 RID: 45174 RVA: 0x0030F2CC File Offset: 0x0030D4CC
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600B077 RID: 45175 RVA: 0x0030F2DC File Offset: 0x0030D4DC
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170023A5 RID: 9125
			// (get) Token: 0x0600B078 RID: 45176 RVA: 0x0030F2EC File Offset: 0x0030D4EC
			// (set) Token: 0x0600B079 RID: 45177 RVA: 0x0030F2FC File Offset: 0x0030D4FC
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x170023A6 RID: 9126
			// (get) Token: 0x0600B07A RID: 45178 RVA: 0x0030F30C File Offset: 0x0030D50C
			// (set) Token: 0x0600B07B RID: 45179 RVA: 0x0030F31C File Offset: 0x0030D51C
			public CommonUIStateController m_accountingPanelUIStateController
			{
				get
				{
					return this.m_owner.m_accountingPanelUIStateController;
				}
				set
				{
					this.m_owner.m_accountingPanelUIStateController = value;
				}
			}

			// Token: 0x170023A7 RID: 9127
			// (get) Token: 0x0600B07C RID: 45180 RVA: 0x0030F32C File Offset: 0x0030D52C
			// (set) Token: 0x0600B07D RID: 45181 RVA: 0x0030F33C File Offset: 0x0030D53C
			public GameObject m_starsGameObject
			{
				get
				{
					return this.m_owner.m_starsGameObject;
				}
				set
				{
					this.m_owner.m_starsGameObject = value;
				}
			}

			// Token: 0x170023A8 RID: 9128
			// (get) Token: 0x0600B07E RID: 45182 RVA: 0x0030F34C File Offset: 0x0030D54C
			// (set) Token: 0x0600B07F RID: 45183 RVA: 0x0030F35C File Offset: 0x0030D55C
			public CommonUIStateController m_star1UIStateController
			{
				get
				{
					return this.m_owner.m_star1UIStateController;
				}
				set
				{
					this.m_owner.m_star1UIStateController = value;
				}
			}

			// Token: 0x170023A9 RID: 9129
			// (get) Token: 0x0600B080 RID: 45184 RVA: 0x0030F36C File Offset: 0x0030D56C
			// (set) Token: 0x0600B081 RID: 45185 RVA: 0x0030F37C File Offset: 0x0030D57C
			public CommonUIStateController m_star2UIStateController
			{
				get
				{
					return this.m_owner.m_star2UIStateController;
				}
				set
				{
					this.m_owner.m_star2UIStateController = value;
				}
			}

			// Token: 0x170023AA RID: 9130
			// (get) Token: 0x0600B082 RID: 45186 RVA: 0x0030F38C File Offset: 0x0030D58C
			// (set) Token: 0x0600B083 RID: 45187 RVA: 0x0030F39C File Offset: 0x0030D59C
			public Text m_star2Text
			{
				get
				{
					return this.m_owner.m_star2Text;
				}
				set
				{
					this.m_owner.m_star2Text = value;
				}
			}

			// Token: 0x170023AB RID: 9131
			// (get) Token: 0x0600B084 RID: 45188 RVA: 0x0030F3AC File Offset: 0x0030D5AC
			// (set) Token: 0x0600B085 RID: 45189 RVA: 0x0030F3BC File Offset: 0x0030D5BC
			public CommonUIStateController m_star3UIStateController
			{
				get
				{
					return this.m_owner.m_star3UIStateController;
				}
				set
				{
					this.m_owner.m_star3UIStateController = value;
				}
			}

			// Token: 0x170023AC RID: 9132
			// (get) Token: 0x0600B086 RID: 45190 RVA: 0x0030F3CC File Offset: 0x0030D5CC
			// (set) Token: 0x0600B087 RID: 45191 RVA: 0x0030F3DC File Offset: 0x0030D5DC
			public Text m_star3Text
			{
				get
				{
					return this.m_owner.m_star3Text;
				}
				set
				{
					this.m_owner.m_star3Text = value;
				}
			}

			// Token: 0x170023AD RID: 9133
			// (get) Token: 0x0600B088 RID: 45192 RVA: 0x0030F3EC File Offset: 0x0030D5EC
			// (set) Token: 0x0600B089 RID: 45193 RVA: 0x0030F3FC File Offset: 0x0030D5FC
			public GameObject m_arenaResultGameObject
			{
				get
				{
					return this.m_owner.m_arenaResultGameObject;
				}
				set
				{
					this.m_owner.m_arenaResultGameObject = value;
				}
			}

			// Token: 0x170023AE RID: 9134
			// (get) Token: 0x0600B08A RID: 45194 RVA: 0x0030F40C File Offset: 0x0030D60C
			// (set) Token: 0x0600B08B RID: 45195 RVA: 0x0030F41C File Offset: 0x0030D61C
			public Text m_arenaPointText
			{
				get
				{
					return this.m_owner.m_arenaPointText;
				}
				set
				{
					this.m_owner.m_arenaPointText = value;
				}
			}

			// Token: 0x170023AF RID: 9135
			// (get) Token: 0x0600B08C RID: 45196 RVA: 0x0030F42C File Offset: 0x0030D62C
			// (set) Token: 0x0600B08D RID: 45197 RVA: 0x0030F43C File Offset: 0x0030D63C
			public Text m_arenaVictoryPointText
			{
				get
				{
					return this.m_owner.m_arenaVictoryPointText;
				}
				set
				{
					this.m_owner.m_arenaVictoryPointText = value;
				}
			}

			// Token: 0x170023B0 RID: 9136
			// (get) Token: 0x0600B08E RID: 45198 RVA: 0x0030F44C File Offset: 0x0030D64C
			// (set) Token: 0x0600B08F RID: 45199 RVA: 0x0030F45C File Offset: 0x0030D65C
			public GameObject m_arenaAutoFightGameObject
			{
				get
				{
					return this.m_owner.m_arenaAutoFightGameObject;
				}
				set
				{
					this.m_owner.m_arenaAutoFightGameObject = value;
				}
			}

			// Token: 0x170023B1 RID: 9137
			// (get) Token: 0x0600B090 RID: 45200 RVA: 0x0030F46C File Offset: 0x0030D66C
			// (set) Token: 0x0600B091 RID: 45201 RVA: 0x0030F47C File Offset: 0x0030D67C
			public GameObject m_realtimePVPResultGameObject
			{
				get
				{
					return this.m_owner.m_realtimePVPResultGameObject;
				}
				set
				{
					this.m_owner.m_realtimePVPResultGameObject = value;
				}
			}

			// Token: 0x170023B2 RID: 9138
			// (get) Token: 0x0600B092 RID: 45202 RVA: 0x0030F48C File Offset: 0x0030D68C
			// (set) Token: 0x0600B093 RID: 45203 RVA: 0x0030F49C File Offset: 0x0030D69C
			public Text m_realtimePVPScoreText
			{
				get
				{
					return this.m_owner.m_realtimePVPScoreText;
				}
				set
				{
					this.m_owner.m_realtimePVPScoreText = value;
				}
			}

			// Token: 0x170023B3 RID: 9139
			// (get) Token: 0x0600B094 RID: 45204 RVA: 0x0030F4AC File Offset: 0x0030D6AC
			// (set) Token: 0x0600B095 RID: 45205 RVA: 0x0030F4BC File Offset: 0x0030D6BC
			public Text m_realtimePVPWinText
			{
				get
				{
					return this.m_owner.m_realtimePVPWinText;
				}
				set
				{
					this.m_owner.m_realtimePVPWinText = value;
				}
			}

			// Token: 0x170023B4 RID: 9140
			// (get) Token: 0x0600B096 RID: 45206 RVA: 0x0030F4CC File Offset: 0x0030D6CC
			// (set) Token: 0x0600B097 RID: 45207 RVA: 0x0030F4DC File Offset: 0x0030D6DC
			public GameObject m_realtimePVPWinBonusGameObject
			{
				get
				{
					return this.m_owner.m_realtimePVPWinBonusGameObject;
				}
				set
				{
					this.m_owner.m_realtimePVPWinBonusGameObject = value;
				}
			}

			// Token: 0x170023B5 RID: 9141
			// (get) Token: 0x0600B098 RID: 45208 RVA: 0x0030F4EC File Offset: 0x0030D6EC
			// (set) Token: 0x0600B099 RID: 45209 RVA: 0x0030F4FC File Offset: 0x0030D6FC
			public Text m_realtimePVPWinBonusText
			{
				get
				{
					return this.m_owner.m_realtimePVPWinBonusText;
				}
				set
				{
					this.m_owner.m_realtimePVPWinBonusText = value;
				}
			}

			// Token: 0x170023B6 RID: 9142
			// (get) Token: 0x0600B09A RID: 45210 RVA: 0x0030F50C File Offset: 0x0030D70C
			// (set) Token: 0x0600B09B RID: 45211 RVA: 0x0030F51C File Offset: 0x0030D71C
			public GameObject m_goldGameObject
			{
				get
				{
					return this.m_owner.m_goldGameObject;
				}
				set
				{
					this.m_owner.m_goldGameObject = value;
				}
			}

			// Token: 0x170023B7 RID: 9143
			// (get) Token: 0x0600B09C RID: 45212 RVA: 0x0030F52C File Offset: 0x0030D72C
			// (set) Token: 0x0600B09D RID: 45213 RVA: 0x0030F53C File Offset: 0x0030D73C
			public GameObject m_expGameObject
			{
				get
				{
					return this.m_owner.m_expGameObject;
				}
				set
				{
					this.m_owner.m_expGameObject = value;
				}
			}

			// Token: 0x170023B8 RID: 9144
			// (get) Token: 0x0600B09E RID: 45214 RVA: 0x0030F54C File Offset: 0x0030D74C
			// (set) Token: 0x0600B09F RID: 45215 RVA: 0x0030F55C File Offset: 0x0030D75C
			public Text m_goldText
			{
				get
				{
					return this.m_owner.m_goldText;
				}
				set
				{
					this.m_owner.m_goldText = value;
				}
			}

			// Token: 0x170023B9 RID: 9145
			// (get) Token: 0x0600B0A0 RID: 45216 RVA: 0x0030F56C File Offset: 0x0030D76C
			// (set) Token: 0x0600B0A1 RID: 45217 RVA: 0x0030F57C File Offset: 0x0030D77C
			public Text m_playerExpText
			{
				get
				{
					return this.m_owner.m_playerExpText;
				}
				set
				{
					this.m_owner.m_playerExpText = value;
				}
			}

			// Token: 0x170023BA RID: 9146
			// (get) Token: 0x0600B0A2 RID: 45218 RVA: 0x0030F58C File Offset: 0x0030D78C
			// (set) Token: 0x0600B0A3 RID: 45219 RVA: 0x0030F59C File Offset: 0x0030D79C
			public Text m_playerGroupLvText
			{
				get
				{
					return this.m_owner.m_playerGroupLvText;
				}
				set
				{
					this.m_owner.m_playerGroupLvText = value;
				}
			}

			// Token: 0x170023BB RID: 9147
			// (get) Token: 0x0600B0A4 RID: 45220 RVA: 0x0030F5AC File Offset: 0x0030D7AC
			// (set) Token: 0x0600B0A5 RID: 45221 RVA: 0x0030F5BC File Offset: 0x0030D7BC
			public Image m_playerExpImage
			{
				get
				{
					return this.m_owner.m_playerExpImage;
				}
				set
				{
					this.m_owner.m_playerExpImage = value;
				}
			}

			// Token: 0x170023BC RID: 9148
			// (get) Token: 0x0600B0A6 RID: 45222 RVA: 0x0030F5CC File Offset: 0x0030D7CC
			// (set) Token: 0x0600B0A7 RID: 45223 RVA: 0x0030F5DC File Offset: 0x0030D7DC
			public GameObject m_playerLevelUpGameObject
			{
				get
				{
					return this.m_owner.m_playerLevelUpGameObject;
				}
				set
				{
					this.m_owner.m_playerLevelUpGameObject = value;
				}
			}

			// Token: 0x170023BD RID: 9149
			// (get) Token: 0x0600B0A8 RID: 45224 RVA: 0x0030F5EC File Offset: 0x0030D7EC
			// (set) Token: 0x0600B0A9 RID: 45225 RVA: 0x0030F5FC File Offset: 0x0030D7FC
			public GameObject m_heroGroupGameObject
			{
				get
				{
					return this.m_owner.m_heroGroupGameObject;
				}
				set
				{
					this.m_owner.m_heroGroupGameObject = value;
				}
			}

			// Token: 0x170023BE RID: 9150
			// (get) Token: 0x0600B0AA RID: 45226 RVA: 0x0030F60C File Offset: 0x0030D80C
			// (set) Token: 0x0600B0AB RID: 45227 RVA: 0x0030F61C File Offset: 0x0030D81C
			public GameObject m_heroExpGameObject
			{
				get
				{
					return this.m_owner.m_heroExpGameObject;
				}
				set
				{
					this.m_owner.m_heroExpGameObject = value;
				}
			}

			// Token: 0x170023BF RID: 9151
			// (get) Token: 0x0600B0AC RID: 45228 RVA: 0x0030F62C File Offset: 0x0030D82C
			// (set) Token: 0x0600B0AD RID: 45229 RVA: 0x0030F63C File Offset: 0x0030D83C
			public Text m_enemyBoomToGoldText
			{
				get
				{
					return this.m_owner.m_enemyBoomToGoldText;
				}
				set
				{
					this.m_owner.m_enemyBoomToGoldText = value;
				}
			}

			// Token: 0x170023C0 RID: 9152
			// (get) Token: 0x0600B0AE RID: 45230 RVA: 0x0030F64C File Offset: 0x0030D84C
			// (set) Token: 0x0600B0AF RID: 45231 RVA: 0x0030F65C File Offset: 0x0030D85C
			public GameObject m_enemyBoomToGoldGameObject
			{
				get
				{
					return this.m_owner.m_enemyBoomToGoldGameObject;
				}
				set
				{
					this.m_owner.m_enemyBoomToGoldGameObject = value;
				}
			}

			// Token: 0x170023C1 RID: 9153
			// (get) Token: 0x0600B0B0 RID: 45232 RVA: 0x0030F66C File Offset: 0x0030D86C
			// (set) Token: 0x0600B0B1 RID: 45233 RVA: 0x0030F67C File Offset: 0x0030D87C
			public GameObject m_treasureMapRewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_treasureMapRewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_treasureMapRewardGroupGameObject = value;
				}
			}

			// Token: 0x170023C2 RID: 9154
			// (get) Token: 0x0600B0B2 RID: 45234 RVA: 0x0030F68C File Offset: 0x0030D88C
			// (set) Token: 0x0600B0B3 RID: 45235 RVA: 0x0030F69C File Offset: 0x0030D89C
			public ScrollRect m_treasureMapRewardGroupScrollRect
			{
				get
				{
					return this.m_owner.m_treasureMapRewardGroupScrollRect;
				}
				set
				{
					this.m_owner.m_treasureMapRewardGroupScrollRect = value;
				}
			}

			// Token: 0x170023C3 RID: 9155
			// (get) Token: 0x0600B0B4 RID: 45236 RVA: 0x0030F6AC File Offset: 0x0030D8AC
			// (set) Token: 0x0600B0B5 RID: 45237 RVA: 0x0030F6BC File Offset: 0x0030D8BC
			public GridLayoutGroup m_treasureMapRewardGroupGridLayputGroup
			{
				get
				{
					return this.m_owner.m_treasureMapRewardGroupGridLayputGroup;
				}
				set
				{
					this.m_owner.m_treasureMapRewardGroupGridLayputGroup = value;
				}
			}

			// Token: 0x170023C4 RID: 9156
			// (get) Token: 0x0600B0B6 RID: 45238 RVA: 0x0030F6CC File Offset: 0x0030D8CC
			// (set) Token: 0x0600B0B7 RID: 45239 RVA: 0x0030F6DC File Offset: 0x0030D8DC
			public CommonUIStateController m_achievementPanelUIStateController
			{
				get
				{
					return this.m_owner.m_achievementPanelUIStateController;
				}
				set
				{
					this.m_owner.m_achievementPanelUIStateController = value;
				}
			}

			// Token: 0x170023C5 RID: 9157
			// (get) Token: 0x0600B0B8 RID: 45240 RVA: 0x0030F6EC File Offset: 0x0030D8EC
			// (set) Token: 0x0600B0B9 RID: 45241 RVA: 0x0030F6FC File Offset: 0x0030D8FC
			public GameObject m_achievementGameObject
			{
				get
				{
					return this.m_owner.m_achievementGameObject;
				}
				set
				{
					this.m_owner.m_achievementGameObject = value;
				}
			}

			// Token: 0x170023C6 RID: 9158
			// (get) Token: 0x0600B0BA RID: 45242 RVA: 0x0030F70C File Offset: 0x0030D90C
			// (set) Token: 0x0600B0BB RID: 45243 RVA: 0x0030F71C File Offset: 0x0030D91C
			public GameObject m_clickScreenContinueGameObject
			{
				get
				{
					return this.m_owner.m_clickScreenContinueGameObject;
				}
				set
				{
					this.m_owner.m_clickScreenContinueGameObject = value;
				}
			}

			// Token: 0x170023C7 RID: 9159
			// (get) Token: 0x0600B0BC RID: 45244 RVA: 0x0030F72C File Offset: 0x0030D92C
			// (set) Token: 0x0600B0BD RID: 45245 RVA: 0x0030F73C File Offset: 0x0030D93C
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

			// Token: 0x170023C8 RID: 9160
			// (get) Token: 0x0600B0BE RID: 45246 RVA: 0x0030F74C File Offset: 0x0030D94C
			// (set) Token: 0x0600B0BF RID: 45247 RVA: 0x0030F75C File Offset: 0x0030D95C
			public GameObject m_heroItemPrefab
			{
				get
				{
					return this.m_owner.m_heroItemPrefab;
				}
				set
				{
					this.m_owner.m_heroItemPrefab = value;
				}
			}

			// Token: 0x170023C9 RID: 9161
			// (get) Token: 0x0600B0C0 RID: 45248 RVA: 0x0030F76C File Offset: 0x0030D96C
			// (set) Token: 0x0600B0C1 RID: 45249 RVA: 0x0030F77C File Offset: 0x0030D97C
			public GameObject m_enemyItemPrefab
			{
				get
				{
					return this.m_owner.m_enemyItemPrefab;
				}
				set
				{
					this.m_owner.m_enemyItemPrefab = value;
				}
			}

			// Token: 0x170023CA RID: 9162
			// (get) Token: 0x0600B0C2 RID: 45250 RVA: 0x0030F78C File Offset: 0x0030D98C
			// (set) Token: 0x0600B0C3 RID: 45251 RVA: 0x0030F79C File Offset: 0x0030D99C
			public List<RewardHeroUIController> m_rewardHeros
			{
				get
				{
					return this.m_owner.m_rewardHeros;
				}
				set
				{
					this.m_owner.m_rewardHeros = value;
				}
			}

			// Token: 0x170023CB RID: 9163
			// (get) Token: 0x0600B0C4 RID: 45252 RVA: 0x0030F7AC File Offset: 0x0030D9AC
			// (set) Token: 0x0600B0C5 RID: 45253 RVA: 0x0030F7BC File Offset: 0x0030D9BC
			public BattleAchievementItemUIController m_achievementItemUIController
			{
				get
				{
					return this.m_owner.m_achievementItemUIController;
				}
				set
				{
					this.m_owner.m_achievementItemUIController = value;
				}
			}

			// Token: 0x170023CC RID: 9164
			// (get) Token: 0x0600B0C6 RID: 45254 RVA: 0x0030F7CC File Offset: 0x0030D9CC
			// (set) Token: 0x0600B0C7 RID: 45255 RVA: 0x0030F7DC File Offset: 0x0030D9DC
			public bool m_isClick
			{
				get
				{
					return this.m_owner.m_isClick;
				}
				set
				{
					this.m_owner.m_isClick = value;
				}
			}

			// Token: 0x170023CD RID: 9165
			// (get) Token: 0x0600B0C8 RID: 45256 RVA: 0x0030F7EC File Offset: 0x0030D9EC
			// (set) Token: 0x0600B0C9 RID: 45257 RVA: 0x0030F7FC File Offset: 0x0030D9FC
			public PlayerLevelUpUITask m_playerLevelUpUITask
			{
				get
				{
					return this.m_owner.m_playerLevelUpUITask;
				}
				set
				{
					this.m_owner.m_playerLevelUpUITask = value;
				}
			}

			// Token: 0x170023CE RID: 9166
			// (get) Token: 0x0600B0CA RID: 45258 RVA: 0x0030F80C File Offset: 0x0030DA0C
			// (set) Token: 0x0600B0CB RID: 45259 RVA: 0x0030F81C File Offset: 0x0030DA1C
			public float m_playerExpTotalWidth
			{
				get
				{
					return this.m_owner.m_playerExpTotalWidth;
				}
				set
				{
					this.m_owner.m_playerExpTotalWidth = value;
				}
			}

			// Token: 0x170023CF RID: 9167
			// (get) Token: 0x0600B0CC RID: 45260 RVA: 0x0030F82C File Offset: 0x0030DA2C
			// (set) Token: 0x0600B0CD RID: 45261 RVA: 0x0030F83C File Offset: 0x0030DA3C
			public UISpineGraphic m_spineGraphic
			{
				get
				{
					return this.m_owner.m_spineGraphic;
				}
				set
				{
					this.m_owner.m_spineGraphic = value;
				}
			}

			// Token: 0x170023D0 RID: 9168
			// (get) Token: 0x0600B0CE RID: 45262 RVA: 0x0030F84C File Offset: 0x0030DA4C
			// (set) Token: 0x0600B0CF RID: 45263 RVA: 0x0030F85C File Offset: 0x0030DA5C
			public float m_singleAddExp
			{
				get
				{
					return this.m_owner.m_singleAddExp;
				}
				set
				{
					this.m_owner.m_singleAddExp = value;
				}
			}

			// Token: 0x170023D1 RID: 9169
			// (get) Token: 0x0600B0D0 RID: 45264 RVA: 0x0030F86C File Offset: 0x0030DA6C
			// (set) Token: 0x0600B0D1 RID: 45265 RVA: 0x0030F87C File Offset: 0x0030DA7C
			public float m_beforePlayerExp
			{
				get
				{
					return this.m_owner.m_beforePlayerExp;
				}
				set
				{
					this.m_owner.m_beforePlayerExp = value;
				}
			}

			// Token: 0x170023D2 RID: 9170
			// (get) Token: 0x0600B0D2 RID: 45266 RVA: 0x0030F88C File Offset: 0x0030DA8C
			// (set) Token: 0x0600B0D3 RID: 45267 RVA: 0x0030F89C File Offset: 0x0030DA9C
			public int m_finalPlayerExp
			{
				get
				{
					return this.m_owner.m_finalPlayerExp;
				}
				set
				{
					this.m_owner.m_finalPlayerExp = value;
				}
			}

			// Token: 0x170023D3 RID: 9171
			// (get) Token: 0x0600B0D4 RID: 45268 RVA: 0x0030F8AC File Offset: 0x0030DAAC
			// (set) Token: 0x0600B0D5 RID: 45269 RVA: 0x0030F8BC File Offset: 0x0030DABC
			public float m_singleAddGold
			{
				get
				{
					return this.m_owner.m_singleAddGold;
				}
				set
				{
					this.m_owner.m_singleAddGold = value;
				}
			}

			// Token: 0x170023D4 RID: 9172
			// (get) Token: 0x0600B0D6 RID: 45270 RVA: 0x0030F8CC File Offset: 0x0030DACC
			// (set) Token: 0x0600B0D7 RID: 45271 RVA: 0x0030F8DC File Offset: 0x0030DADC
			public float m_beforePlayerGold
			{
				get
				{
					return this.m_owner.m_beforePlayerGold;
				}
				set
				{
					this.m_owner.m_beforePlayerGold = value;
				}
			}

			// Token: 0x170023D5 RID: 9173
			// (get) Token: 0x0600B0D8 RID: 45272 RVA: 0x0030F8EC File Offset: 0x0030DAEC
			// (set) Token: 0x0600B0D9 RID: 45273 RVA: 0x0030F8FC File Offset: 0x0030DAFC
			public int m_finalPlayerGold
			{
				get
				{
					return this.m_owner.m_finalPlayerGold;
				}
				set
				{
					this.m_owner.m_finalPlayerGold = value;
				}
			}

			// Token: 0x0600B0DA RID: 45274 RVA: 0x0030F90C File Offset: 0x0030DB0C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600B0DB RID: 45275 RVA: 0x0030F91C File Offset: 0x0030DB1C
			public IEnumerator Co_ShowBattleResult(BattleType battleType, List<Hero> heros, int stars, int starTurnMax, int starDeadMax, int turn, BattleReward reward, List<int> gotAchievements, BattleLevelAchievement[] achievements)
			{
				return this.m_owner.Co_ShowBattleResult(battleType, heros, stars, starTurnMax, starDeadMax, turn, reward, gotAchievements, achievements);
			}

			// Token: 0x0600B0DC RID: 45276 RVA: 0x0030F944 File Offset: 0x0030DB44
			public IEnumerator AddPlayerExpBarWidth()
			{
				return this.m_owner.AddPlayerExpBarWidth();
			}

			// Token: 0x0600B0DD RID: 45277 RVA: 0x0030F954 File Offset: 0x0030DB54
			public void UpdateTextValue(float scale)
			{
				this.m_owner.UpdateTextValue(scale);
			}

			// Token: 0x0600B0DE RID: 45278 RVA: 0x0030F964 File Offset: 0x0030DB64
			public IEnumerator Co_ShowStars(BattleType battleType, int stars, int starTurnMax, int starDeadMax, int turn)
			{
				return this.m_owner.Co_ShowStars(battleType, stars, starTurnMax, starDeadMax, turn);
			}

			// Token: 0x0600B0DF RID: 45279 RVA: 0x0030F978 File Offset: 0x0030DB78
			public IEnumerator Co_ShowHeros(BattleReward reward, List<Hero> heros)
			{
				return this.m_owner.Co_ShowHeros(reward, heros);
			}

			// Token: 0x0600B0E0 RID: 45280 RVA: 0x0030F988 File Offset: 0x0030DB88
			public IEnumerator Co_ShowEnemyBoomToGold()
			{
				return this.m_owner.Co_ShowEnemyBoomToGold();
			}

			// Token: 0x0600B0E1 RID: 45281 RVA: 0x0030F998 File Offset: 0x0030DB98
			public void AutoMoveItemWhenOutOfScrollRect(EnemyBoomToGoldUIController ctrl)
			{
				this.m_owner.AutoMoveItemWhenOutOfScrollRect(ctrl);
			}

			// Token: 0x0600B0E2 RID: 45282 RVA: 0x0030F9A8 File Offset: 0x0030DBA8
			public IEnumerator Co_ShowPlayerLevelUp(int oldLevel, int newLevel)
			{
				return this.m_owner.Co_ShowPlayerLevelUp(oldLevel, newLevel);
			}

			// Token: 0x0600B0E3 RID: 45283 RVA: 0x0030F9B8 File Offset: 0x0030DBB8
			public IEnumerator Co_ShowAchievements(List<int> gotAchievements, BattleLevelAchievement[] achievements)
			{
				return this.m_owner.Co_ShowAchievements(gotAchievements, achievements);
			}

			// Token: 0x0600B0E4 RID: 45284 RVA: 0x0030F9C8 File Offset: 0x0030DBC8
			public IEnumerator Co_SetGoldValueChanged(float changeValue)
			{
				return this.m_owner.Co_SetGoldValueChanged(changeValue);
			}

			// Token: 0x0600B0E5 RID: 45285 RVA: 0x0030F9D8 File Offset: 0x0030DBD8
			public IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
			{
				return this.m_owner.Co_SetAndWaitUIState(ctrl, state);
			}

			// Token: 0x0600B0E6 RID: 45286 RVA: 0x0030F9E8 File Offset: 0x0030DBE8
			public IEnumerator Co_WaitClick()
			{
				return this.m_owner.Co_WaitClick();
			}

			// Token: 0x0600B0E7 RID: 45287 RVA: 0x0030F9F8 File Offset: 0x0030DBF8
			public void PlayerLevelUpUITask_OnClose()
			{
				this.m_owner.PlayerLevelUpUITask_OnClose();
			}

			// Token: 0x0600B0E8 RID: 45288 RVA: 0x0030FA08 File Offset: 0x0030DC08
			public void ClearHeroItems()
			{
				this.m_owner.ClearHeroItems();
			}

			// Token: 0x0600B0E9 RID: 45289 RVA: 0x0030FA18 File Offset: 0x0030DC18
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x040072F6 RID: 29430
			private BattleResultUIController m_owner;
		}
	}
}
