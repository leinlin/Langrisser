using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D18 RID: 3352
	public class MassiveCombatGuildRewardUIController : UIControllerBase
	{
		// Token: 0x0600F69E RID: 63134 RVA: 0x004134C4 File Offset: 0x004116C4
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.Init();
		}

		// Token: 0x0600F69F RID: 63135 RVA: 0x004134FC File Offset: 0x004116FC
		public void Init()
		{
			GuildMassiveCombatInfo currentGuildMassiveCombatInfo = this.m_playerContext.GetCurrentGuildMassiveCombatInfo();
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = this.m_configDataLoader.GetConfigDataGuildMassiveCombatDifficultyInfo(currentGuildMassiveCombatInfo.Difficulty);
			List<Rewards> rewardsInfo = configDataGuildMassiveCombatDifficultyInfo.RewardsInfo;
			foreach (Rewards reward in rewardsInfo)
			{
				GameObject go = GameObjectUtility.CloneGameObject(this.m_itemPrefab, this.m_rewardContent.transform);
				MassiveCombatGuildRewardItemUIController massiveCombatGuildRewardItemUIController = GameObjectUtility.AddControllerToGameObject<MassiveCombatGuildRewardItemUIController>(go);
				massiveCombatGuildRewardItemUIController.Init(reward, configDataGuildMassiveCombatDifficultyInfo.BonusGuildCoins);
				this.m_rewardItemUIControllerList.Add(massiveCombatGuildRewardItemUIController);
			}
			this.m_total.text = string.Format("{0}%", this.m_playerContext.GetGuildMassiveCombatEliminateRate());
		}

		// Token: 0x0600F6A0 RID: 63136 RVA: 0x004135D4 File Offset: 0x004117D4
		public void Refresh()
		{
		}

		// Token: 0x0400919E RID: 37278
		[AutoBind("./GuildProgressInfo/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_total;

		// Token: 0x0400919F RID: 37279
		[AutoBind("./RewardInfoListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardContent;

		// Token: 0x040091A0 RID: 37280
		[AutoBind("./Prefab/GuildRewardItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemPrefab;

		// Token: 0x040091A1 RID: 37281
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040091A2 RID: 37282
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040091A3 RID: 37283
		private List<MassiveCombatGuildRewardItemUIController> m_rewardItemUIControllerList = new List<MassiveCombatGuildRewardItemUIController>();
	}
}
