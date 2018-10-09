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
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AA4 RID: 2724
	[HotFix]
	public class BattleResultScoreUIController : UIControllerBase
	{
		// Token: 0x0600AF79 RID: 44921 RVA: 0x0030BB10 File Offset: 0x00309D10
		private BattleResultScoreUIController()
		{
		}

		// Token: 0x0600AF7A RID: 44922 RVA: 0x0030BB18 File Offset: 0x00309D18
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
		}

		// Token: 0x0600AF7B RID: 44923 RVA: 0x0030BB9C File Offset: 0x00309D9C
		public void ShowBattleResultScore(BattleReward battleReward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBattleResultScoreBattleReward_hotfix != null)
			{
				this.m_ShowBattleResultScoreBattleReward_hotfix.call(new object[]
				{
					this,
					battleReward
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_ShowBattleResultScore(battleReward));
		}

		// Token: 0x0600AF7C RID: 44924 RVA: 0x0030BC1C File Offset: 0x00309E1C
		[DebuggerHidden]
		private IEnumerator Co_ShowBattleResultScore(BattleReward battleReward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowBattleResultScoreBattleReward_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowBattleResultScoreBattleReward_hotfix.call(new object[]
				{
					this,
					battleReward
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleResultScoreUIController.<Co_ShowBattleResultScore>c__Iterator0 <Co_ShowBattleResultScore>c__Iterator = new BattleResultScoreUIController.<Co_ShowBattleResultScore>c__Iterator0();
			<Co_ShowBattleResultScore>c__Iterator.battleReward = battleReward;
			<Co_ShowBattleResultScore>c__Iterator.$this = this;
			return <Co_ShowBattleResultScore>c__Iterator;
		}

		// Token: 0x0600AF7D RID: 44925 RVA: 0x0030BCB0 File Offset: 0x00309EB0
		private void SetUnchartedScoreReward(BattleReward battleReward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUnchartedScoreRewardBattleReward_hotfix != null)
			{
				this.m_SetUnchartedScoreRewardBattleReward_hotfix.call(new object[]
				{
					this,
					battleReward
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataUnchartedScoreInfo unchartedScoreInfo = BattleResultScoreUIController.GetUnchartedScoreInfo();
			if (unchartedScoreInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int unchartedScoreScore = projectLPlayerContext.GetUnchartedScoreScore(unchartedScoreInfo.ID);
			string bonusDesc = string.Empty;
			if (battleReward.DailyScoreBonus > 0 && battleReward.HeroScoreBonus <= 0)
			{
				bonusDesc = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Battle_ScoreDailyBonus), battleReward.DailyScoreBonus);
			}
			else if (battleReward.HeroScoreBonus > 0 && battleReward.DailyScoreBonus <= 0)
			{
				bonusDesc = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Battle_ScoreHeroBonus), battleReward.HeroScoreBonus);
			}
			else if (battleReward.DailyScoreBonus > 0 && battleReward.HeroScoreBonus > 0)
			{
				bonusDesc = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Battle_ScoreDailyHeroBonus), battleReward.DailyScoreBonus, battleReward.HeroScoreBonus);
			}
			int nextScore = 0;
			List<Goods> nextRewardGoods = null;
			ConfigDataUnchartedScoreRewardGroupInfo nextUnchartedScoreRewardGroupInfo = this.GetNextUnchartedScoreRewardGroupInfo(unchartedScoreInfo.UnchartedScoreRewardGroupId, unchartedScoreScore);
			if (nextUnchartedScoreRewardGroupInfo != null)
			{
				nextScore = nextUnchartedScoreRewardGroupInfo.Score;
				nextRewardGoods = nextUnchartedScoreRewardGroupInfo.RewardList;
			}
			this.SetReward(battleReward, unchartedScoreInfo.ScoreName, unchartedScoreScore, bonusDesc, nextScore, nextRewardGoods);
		}

		// Token: 0x0600AF7E RID: 44926 RVA: 0x0030BE58 File Offset: 0x0030A058
		private void SetGuildMassiveCombatScoreReward(BattleReward battleReward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGuildMassiveCombatScoreRewardBattleReward_hotfix != null)
			{
				this.m_SetGuildMassiveCombatScoreRewardBattleReward_hotfix.call(new object[]
				{
					this,
					battleReward
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int curScore = 0;
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = projectLPlayerContext.GetGuildPlayerMassiveCombatInfo();
			if (guildPlayerMassiveCombatInfo != null)
			{
				curScore = guildPlayerMassiveCombatInfo.Points;
			}
			int nextScore = 0;
			List<Goods> nextRewardGoods = null;
			ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo nextGuildMassiveCombatIndividualPointsRewardInfo = this.GetNextGuildMassiveCombatIndividualPointsRewardInfo(curScore);
			if (nextGuildMassiveCombatIndividualPointsRewardInfo != null)
			{
				nextScore = nextGuildMassiveCombatIndividualPointsRewardInfo.Points;
				nextRewardGoods = nextGuildMassiveCombatIndividualPointsRewardInfo.RewardItems;
			}
			else
			{
				this.m_nextRewardScoreText.text = string.Empty;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string scoreName = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_MassiveCombatScoreName);
			this.SetReward(battleReward, scoreName, curScore, string.Empty, nextScore, nextRewardGoods);
		}

		// Token: 0x0600AF7F RID: 44927 RVA: 0x0030BF5C File Offset: 0x0030A15C
		private void SetReward(BattleReward battleReward, string scoreName, int curScore, string bonusDesc, int nextScore, List<Goods> nextRewardGoods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRewardBattleRewardStringInt32StringInt32List`1_hotfix != null)
			{
				this.m_SetRewardBattleRewardStringInt32StringInt32List`1_hotfix.call(new object[]
				{
					this,
					battleReward,
					scoreName,
					curScore,
					bonusDesc,
					nextScore,
					nextRewardGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text getScoreNameText = this.m_getScoreNameText;
			this.m_haveScoreNameText.text = scoreName;
			getScoreNameText.text = scoreName;
			this.m_getScoreText.text = battleReward.Score.ToString();
			this.m_haveScoreText.text = curScore.ToString();
			GameObjectUtility.DestroyChildren(this.m_rewardGroupScrollRect.content.gameObject);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			RewardGoodsUIController.CreateRewardGoodsList(battleReward.ScoreGoods, this.m_rewardGroupScrollRect.content, assetInContainer, null, true, 0, true);
			if (!string.IsNullOrEmpty(bonusDesc))
			{
				this.m_getScoreDescText.gameObject.SetActive(true);
				this.m_getScoreDescText.text = bonusDesc;
			}
			else
			{
				this.m_getScoreDescText.gameObject.SetActive(false);
			}
			GameObjectUtility.DestroyChildren(this.m_nextRewardGroupTransform.gameObject);
			if (nextRewardGoods != null)
			{
				this.m_nextRewardGroupGameObject.SetActive(true);
				this.m_nextRewardScoreText.text = (nextScore - curScore).ToString();
				RewardGoodsUIController.CreateRewardGoodsList(nextRewardGoods, this.m_nextRewardGroupTransform, assetInContainer, null, true, 0, true);
			}
			else
			{
				this.m_nextRewardGroupGameObject.SetActive(false);
				this.m_nextRewardScoreText.text = string.Empty;
			}
		}

		// Token: 0x0600AF80 RID: 44928 RVA: 0x0030C15C File Offset: 0x0030A35C
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
			BattleResultScoreUIController.<Co_SetAndWaitUIState>c__Iterator1 <Co_SetAndWaitUIState>c__Iterator = new BattleResultScoreUIController.<Co_SetAndWaitUIState>c__Iterator1();
			<Co_SetAndWaitUIState>c__Iterator.ctrl = ctrl;
			<Co_SetAndWaitUIState>c__Iterator.state = state;
			return <Co_SetAndWaitUIState>c__Iterator;
		}

		// Token: 0x0600AF81 RID: 44929 RVA: 0x0030C200 File Offset: 0x0030A400
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
			BattleResultScoreUIController.<Co_WaitClick>c__Iterator2 <Co_WaitClick>c__Iterator = new BattleResultScoreUIController.<Co_WaitClick>c__Iterator2();
			<Co_WaitClick>c__Iterator.$this = this;
			return <Co_WaitClick>c__Iterator;
		}

		// Token: 0x0600AF82 RID: 44930 RVA: 0x0030C27C File Offset: 0x0030A47C
		private static ConfigDataUnchartedScoreInfo GetUnchartedScoreInfo()
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.Happening.ScoreLevelInfo != null)
			{
				return projectLPlayerContext.Happening.ScoreLevelInfo.UnchartedScoreInfo;
			}
			if (projectLPlayerContext.Happening.ChallengeLevelInfo != null)
			{
				return projectLPlayerContext.Happening.ChallengeLevelInfo.UnchartedScoreInfo;
			}
			return null;
		}

		// Token: 0x0600AF83 RID: 44931 RVA: 0x0030C2DC File Offset: 0x0030A4DC
		public ConfigDataUnchartedScoreRewardGroupInfo GetNextUnchartedScoreRewardGroupInfo(int rewardGroupId, int curScore)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNextUnchartedScoreRewardGroupInfoInt32Int32_hotfix != null)
			{
				return (ConfigDataUnchartedScoreRewardGroupInfo)this.m_GetNextUnchartedScoreRewardGroupInfoInt32Int32_hotfix.call(new object[]
				{
					this,
					rewardGroupId,
					curScore
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataUnchartedScoreRewardGroupInfo result = null;
			foreach (KeyValuePair<int, ConfigDataUnchartedScoreRewardGroupInfo> keyValuePair in configDataLoader.GetAllConfigDataUnchartedScoreRewardGroupInfo())
			{
				if (keyValuePair.Value.GroupId == rewardGroupId)
				{
					if (curScore >= keyValuePair.Value.Score)
					{
						return result;
					}
					result = keyValuePair.Value;
				}
			}
			return null;
		}

		// Token: 0x0600AF84 RID: 44932 RVA: 0x0030C3FC File Offset: 0x0030A5FC
		private static ConfigDataGuildMassiveCombatLevelInfo GetGuildMassiveCombatLevelInfo()
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo != null)
			{
				return projectLPlayerContext.Happening.GuildMassiveCombatLevelInfo;
			}
			return null;
		}

		// Token: 0x0600AF85 RID: 44933 RVA: 0x0030C438 File Offset: 0x0030A638
		public ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo GetNextGuildMassiveCombatIndividualPointsRewardInfo(int curScore)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNextGuildMassiveCombatIndividualPointsRewardInfoInt32_hotfix != null)
			{
				return (ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo)this.m_GetNextGuildMassiveCombatIndividualPointsRewardInfoInt32_hotfix.call(new object[]
				{
					this,
					curScore
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			foreach (KeyValuePair<int, ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo> keyValuePair in configDataLoader.GetAllConfigDataGuildMassiveCombatIndividualPointsRewardsInfo())
			{
				if (keyValuePair.Value.Points > curScore)
				{
					return keyValuePair.Value;
				}
			}
			return null;
		}

		// Token: 0x0600AF86 RID: 44934 RVA: 0x0030C52C File Offset: 0x0030A72C
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

		// Token: 0x14000218 RID: 536
		// (add) Token: 0x0600AF87 RID: 44935 RVA: 0x0030C594 File Offset: 0x0030A794
		// (remove) Token: 0x0600AF88 RID: 44936 RVA: 0x0030C630 File Offset: 0x0030A830
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

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x0600AF89 RID: 44937 RVA: 0x0030C6CC File Offset: 0x0030A8CC
		// (set) Token: 0x0600AF8A RID: 44938 RVA: 0x0030C6EC File Offset: 0x0030A8EC
		[DoNotToLua]
		public new BattleResultScoreUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleResultScoreUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600AF8B RID: 44939 RVA: 0x0030C6F8 File Offset: 0x0030A8F8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600AF8C RID: 44940 RVA: 0x0030C704 File Offset: 0x0030A904
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600AF8D RID: 44941 RVA: 0x0030C70C File Offset: 0x0030A90C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600AF8E RID: 44942 RVA: 0x0030C714 File Offset: 0x0030A914
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600AF8F RID: 44943 RVA: 0x0030C728 File Offset: 0x0030A928
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600AF90 RID: 44944 RVA: 0x0030C730 File Offset: 0x0030A930
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600AF91 RID: 44945 RVA: 0x0030C73C File Offset: 0x0030A93C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600AF92 RID: 44946 RVA: 0x0030C748 File Offset: 0x0030A948
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600AF93 RID: 44947 RVA: 0x0030C754 File Offset: 0x0030A954
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600AF94 RID: 44948 RVA: 0x0030C760 File Offset: 0x0030A960
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600AF95 RID: 44949 RVA: 0x0030C76C File Offset: 0x0030A96C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600AF96 RID: 44950 RVA: 0x0030C778 File Offset: 0x0030A978
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600AF97 RID: 44951 RVA: 0x0030C784 File Offset: 0x0030A984
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600AF98 RID: 44952 RVA: 0x0030C790 File Offset: 0x0030A990
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600AF99 RID: 44953 RVA: 0x0030C79C File Offset: 0x0030A99C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600AF9A RID: 44954 RVA: 0x0030C7A4 File Offset: 0x0030A9A4
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600AF9B RID: 44955 RVA: 0x0030C7C4 File Offset: 0x0030A9C4
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600AF9C RID: 44956 RVA: 0x0030C7D0 File Offset: 0x0030A9D0
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
					this.m_ShowBattleResultScoreBattleReward_hotfix = (luaObj.RawGet("ShowBattleResultScore") as LuaFunction);
					this.m_Co_ShowBattleResultScoreBattleReward_hotfix = (luaObj.RawGet("Co_ShowBattleResultScore") as LuaFunction);
					this.m_SetUnchartedScoreRewardBattleReward_hotfix = (luaObj.RawGet("SetUnchartedScoreReward") as LuaFunction);
					this.m_SetGuildMassiveCombatScoreRewardBattleReward_hotfix = (luaObj.RawGet("SetGuildMassiveCombatScoreReward") as LuaFunction);
					this.m_SetRewardBattleRewardStringInt32StringInt32List`1_hotfix = (luaObj.RawGet("SetReward") as LuaFunction);
					this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix = (luaObj.RawGet("Co_SetAndWaitUIState") as LuaFunction);
					this.m_Co_WaitClick_hotfix = (luaObj.RawGet("Co_WaitClick") as LuaFunction);
					this.m_GetNextUnchartedScoreRewardGroupInfoInt32Int32_hotfix = (luaObj.RawGet("GetNextUnchartedScoreRewardGroupInfo") as LuaFunction);
					this.m_GetNextGuildMassiveCombatIndividualPointsRewardInfoInt32_hotfix = (luaObj.RawGet("GetNextGuildMassiveCombatIndividualPointsRewardInfo") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600AF9D RID: 44957 RVA: 0x0030C9C8 File Offset: 0x0030ABC8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleResultScoreUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400726B RID: 29291
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400726C RID: 29292
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400726D RID: 29293
		[AutoBind("./Panel/ScoreGroup/Get/Name/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_getScoreNameText;

		// Token: 0x0400726E RID: 29294
		[AutoBind("./Panel/ScoreGroup/Get/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_getScoreText;

		// Token: 0x0400726F RID: 29295
		[AutoBind("./Panel/ScoreGroup/Get/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_getScoreDescText;

		// Token: 0x04007270 RID: 29296
		[AutoBind("./Panel/ScoreGroup/Have/Name/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_haveScoreNameText;

		// Token: 0x04007271 RID: 29297
		[AutoBind("./Panel/ScoreGroup/Have/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_haveScoreText;

		// Token: 0x04007272 RID: 29298
		[AutoBind("./Panel/RewardGroup/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_rewardGroupScrollRect;

		// Token: 0x04007273 RID: 29299
		[AutoBind("./Panel/NextRewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_nextRewardGroupGameObject;

		// Token: 0x04007274 RID: 29300
		[AutoBind("./Panel/NextRewardGroup/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nextRewardScoreText;

		// Token: 0x04007275 RID: 29301
		[AutoBind("./Panel/NextRewardGroup/RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_nextRewardGroupTransform;

		// Token: 0x04007276 RID: 29302
		private bool m_isClick;

		// Token: 0x04007277 RID: 29303
		[DoNotToLua]
		private BattleResultScoreUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007278 RID: 29304
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007279 RID: 29305
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400727A RID: 29306
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400727B RID: 29307
		private LuaFunction m_ShowBattleResultScoreBattleReward_hotfix;

		// Token: 0x0400727C RID: 29308
		private LuaFunction m_Co_ShowBattleResultScoreBattleReward_hotfix;

		// Token: 0x0400727D RID: 29309
		private LuaFunction m_SetUnchartedScoreRewardBattleReward_hotfix;

		// Token: 0x0400727E RID: 29310
		private LuaFunction m_SetGuildMassiveCombatScoreRewardBattleReward_hotfix;

		// Token: 0x0400727F RID: 29311
		private LuaFunction m_SetRewardBattleRewardStringInt32StringInt32List;

		// Token: 0x04007280 RID: 29312
		private LuaFunction m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix;

		// Token: 0x04007281 RID: 29313
		private LuaFunction m_Co_WaitClick_hotfix;

		// Token: 0x04007282 RID: 29314
		private LuaFunction m_GetNextUnchartedScoreRewardGroupInfoInt32Int32_hotfix;

		// Token: 0x04007283 RID: 29315
		private LuaFunction m_GetNextGuildMassiveCombatIndividualPointsRewardInfoInt32_hotfix;

		// Token: 0x04007284 RID: 29316
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04007285 RID: 29317
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04007286 RID: 29318
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000AA5 RID: 2725
		public new class LuaExportHelper
		{
			// Token: 0x0600AF9E RID: 44958 RVA: 0x0030CA30 File Offset: 0x0030AC30
			public LuaExportHelper(BattleResultScoreUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600AF9F RID: 44959 RVA: 0x0030CA40 File Offset: 0x0030AC40
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600AFA0 RID: 44960 RVA: 0x0030CA50 File Offset: 0x0030AC50
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600AFA1 RID: 44961 RVA: 0x0030CA60 File Offset: 0x0030AC60
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600AFA2 RID: 44962 RVA: 0x0030CA70 File Offset: 0x0030AC70
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600AFA3 RID: 44963 RVA: 0x0030CA88 File Offset: 0x0030AC88
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600AFA4 RID: 44964 RVA: 0x0030CA98 File Offset: 0x0030AC98
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600AFA5 RID: 44965 RVA: 0x0030CAA8 File Offset: 0x0030ACA8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600AFA6 RID: 44966 RVA: 0x0030CAB8 File Offset: 0x0030ACB8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600AFA7 RID: 44967 RVA: 0x0030CAC8 File Offset: 0x0030ACC8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600AFA8 RID: 44968 RVA: 0x0030CAD8 File Offset: 0x0030ACD8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600AFA9 RID: 44969 RVA: 0x0030CAE8 File Offset: 0x0030ACE8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600AFAA RID: 44970 RVA: 0x0030CAF8 File Offset: 0x0030ACF8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600AFAB RID: 44971 RVA: 0x0030CB08 File Offset: 0x0030AD08
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600AFAC RID: 44972 RVA: 0x0030CB18 File Offset: 0x0030AD18
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600AFAD RID: 44973 RVA: 0x0030CB28 File Offset: 0x0030AD28
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600AFAE RID: 44974 RVA: 0x0030CB38 File Offset: 0x0030AD38
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600AFAF RID: 44975 RVA: 0x0030CB48 File Offset: 0x0030AD48
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002389 RID: 9097
			// (get) Token: 0x0600AFB0 RID: 44976 RVA: 0x0030CB58 File Offset: 0x0030AD58
			// (set) Token: 0x0600AFB1 RID: 44977 RVA: 0x0030CB68 File Offset: 0x0030AD68
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

			// Token: 0x1700238A RID: 9098
			// (get) Token: 0x0600AFB2 RID: 44978 RVA: 0x0030CB78 File Offset: 0x0030AD78
			// (set) Token: 0x0600AFB3 RID: 44979 RVA: 0x0030CB88 File Offset: 0x0030AD88
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

			// Token: 0x1700238B RID: 9099
			// (get) Token: 0x0600AFB4 RID: 44980 RVA: 0x0030CB98 File Offset: 0x0030AD98
			// (set) Token: 0x0600AFB5 RID: 44981 RVA: 0x0030CBA8 File Offset: 0x0030ADA8
			public Text m_getScoreNameText
			{
				get
				{
					return this.m_owner.m_getScoreNameText;
				}
				set
				{
					this.m_owner.m_getScoreNameText = value;
				}
			}

			// Token: 0x1700238C RID: 9100
			// (get) Token: 0x0600AFB6 RID: 44982 RVA: 0x0030CBB8 File Offset: 0x0030ADB8
			// (set) Token: 0x0600AFB7 RID: 44983 RVA: 0x0030CBC8 File Offset: 0x0030ADC8
			public Text m_getScoreText
			{
				get
				{
					return this.m_owner.m_getScoreText;
				}
				set
				{
					this.m_owner.m_getScoreText = value;
				}
			}

			// Token: 0x1700238D RID: 9101
			// (get) Token: 0x0600AFB8 RID: 44984 RVA: 0x0030CBD8 File Offset: 0x0030ADD8
			// (set) Token: 0x0600AFB9 RID: 44985 RVA: 0x0030CBE8 File Offset: 0x0030ADE8
			public Text m_getScoreDescText
			{
				get
				{
					return this.m_owner.m_getScoreDescText;
				}
				set
				{
					this.m_owner.m_getScoreDescText = value;
				}
			}

			// Token: 0x1700238E RID: 9102
			// (get) Token: 0x0600AFBA RID: 44986 RVA: 0x0030CBF8 File Offset: 0x0030ADF8
			// (set) Token: 0x0600AFBB RID: 44987 RVA: 0x0030CC08 File Offset: 0x0030AE08
			public Text m_haveScoreNameText
			{
				get
				{
					return this.m_owner.m_haveScoreNameText;
				}
				set
				{
					this.m_owner.m_haveScoreNameText = value;
				}
			}

			// Token: 0x1700238F RID: 9103
			// (get) Token: 0x0600AFBC RID: 44988 RVA: 0x0030CC18 File Offset: 0x0030AE18
			// (set) Token: 0x0600AFBD RID: 44989 RVA: 0x0030CC28 File Offset: 0x0030AE28
			public Text m_haveScoreText
			{
				get
				{
					return this.m_owner.m_haveScoreText;
				}
				set
				{
					this.m_owner.m_haveScoreText = value;
				}
			}

			// Token: 0x17002390 RID: 9104
			// (get) Token: 0x0600AFBE RID: 44990 RVA: 0x0030CC38 File Offset: 0x0030AE38
			// (set) Token: 0x0600AFBF RID: 44991 RVA: 0x0030CC48 File Offset: 0x0030AE48
			public ScrollRect m_rewardGroupScrollRect
			{
				get
				{
					return this.m_owner.m_rewardGroupScrollRect;
				}
				set
				{
					this.m_owner.m_rewardGroupScrollRect = value;
				}
			}

			// Token: 0x17002391 RID: 9105
			// (get) Token: 0x0600AFC0 RID: 44992 RVA: 0x0030CC58 File Offset: 0x0030AE58
			// (set) Token: 0x0600AFC1 RID: 44993 RVA: 0x0030CC68 File Offset: 0x0030AE68
			public GameObject m_nextRewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_nextRewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_nextRewardGroupGameObject = value;
				}
			}

			// Token: 0x17002392 RID: 9106
			// (get) Token: 0x0600AFC2 RID: 44994 RVA: 0x0030CC78 File Offset: 0x0030AE78
			// (set) Token: 0x0600AFC3 RID: 44995 RVA: 0x0030CC88 File Offset: 0x0030AE88
			public Text m_nextRewardScoreText
			{
				get
				{
					return this.m_owner.m_nextRewardScoreText;
				}
				set
				{
					this.m_owner.m_nextRewardScoreText = value;
				}
			}

			// Token: 0x17002393 RID: 9107
			// (get) Token: 0x0600AFC4 RID: 44996 RVA: 0x0030CC98 File Offset: 0x0030AE98
			// (set) Token: 0x0600AFC5 RID: 44997 RVA: 0x0030CCA8 File Offset: 0x0030AEA8
			public Transform m_nextRewardGroupTransform
			{
				get
				{
					return this.m_owner.m_nextRewardGroupTransform;
				}
				set
				{
					this.m_owner.m_nextRewardGroupTransform = value;
				}
			}

			// Token: 0x17002394 RID: 9108
			// (get) Token: 0x0600AFC6 RID: 44998 RVA: 0x0030CCB8 File Offset: 0x0030AEB8
			// (set) Token: 0x0600AFC7 RID: 44999 RVA: 0x0030CCC8 File Offset: 0x0030AEC8
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

			// Token: 0x0600AFC8 RID: 45000 RVA: 0x0030CCD8 File Offset: 0x0030AED8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600AFC9 RID: 45001 RVA: 0x0030CCE8 File Offset: 0x0030AEE8
			public IEnumerator Co_ShowBattleResultScore(BattleReward battleReward)
			{
				return this.m_owner.Co_ShowBattleResultScore(battleReward);
			}

			// Token: 0x0600AFCA RID: 45002 RVA: 0x0030CCF8 File Offset: 0x0030AEF8
			public void SetUnchartedScoreReward(BattleReward battleReward)
			{
				this.m_owner.SetUnchartedScoreReward(battleReward);
			}

			// Token: 0x0600AFCB RID: 45003 RVA: 0x0030CD08 File Offset: 0x0030AF08
			public void SetGuildMassiveCombatScoreReward(BattleReward battleReward)
			{
				this.m_owner.SetGuildMassiveCombatScoreReward(battleReward);
			}

			// Token: 0x0600AFCC RID: 45004 RVA: 0x0030CD18 File Offset: 0x0030AF18
			public void SetReward(BattleReward battleReward, string scoreName, int curScore, string bonusDesc, int nextScore, List<Goods> nextRewardGoods)
			{
				this.m_owner.SetReward(battleReward, scoreName, curScore, bonusDesc, nextScore, nextRewardGoods);
			}

			// Token: 0x0600AFCD RID: 45005 RVA: 0x0030CD30 File Offset: 0x0030AF30
			public IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
			{
				return this.m_owner.Co_SetAndWaitUIState(ctrl, state);
			}

			// Token: 0x0600AFCE RID: 45006 RVA: 0x0030CD40 File Offset: 0x0030AF40
			public IEnumerator Co_WaitClick()
			{
				return this.m_owner.Co_WaitClick();
			}

			// Token: 0x0600AFCF RID: 45007 RVA: 0x0030CD50 File Offset: 0x0030AF50
			public static ConfigDataUnchartedScoreInfo GetUnchartedScoreInfo()
			{
				return BattleResultScoreUIController.GetUnchartedScoreInfo();
			}

			// Token: 0x0600AFD0 RID: 45008 RVA: 0x0030CD58 File Offset: 0x0030AF58
			public static ConfigDataGuildMassiveCombatLevelInfo GetGuildMassiveCombatLevelInfo()
			{
				return BattleResultScoreUIController.GetGuildMassiveCombatLevelInfo();
			}

			// Token: 0x0600AFD1 RID: 45009 RVA: 0x0030CD60 File Offset: 0x0030AF60
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x04007287 RID: 29319
			private BattleResultScoreUIController m_owner;
		}
	}
}
