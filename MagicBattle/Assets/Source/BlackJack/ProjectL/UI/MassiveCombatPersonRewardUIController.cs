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
	// Token: 0x02000D16 RID: 3350
	public class MassiveCombatPersonRewardUIController : UIControllerBase
	{
		// Token: 0x0600F696 RID: 63126 RVA: 0x004131B0 File Offset: 0x004113B0
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.Init();
		}

		// Token: 0x0600F697 RID: 63127 RVA: 0x004131E8 File Offset: 0x004113E8
		public void Init()
		{
			GuildMassiveCombatInfo currentGuildMassiveCombatInfo = this.m_playerContext.GetCurrentGuildMassiveCombatInfo();
			ConfigDataGuildMassiveCombatDifficultyInfo configDataGuildMassiveCombatDifficultyInfo = this.m_configDataLoader.GetConfigDataGuildMassiveCombatDifficultyInfo(currentGuildMassiveCombatInfo.Difficulty);
			List<ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo> list = new List<ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo>();
			foreach (KeyValuePair<int, ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataGuildMassiveCombatIndividualPointsRewardsInfo())
			{
				if (keyValuePair.Value.RewardGroupID == configDataGuildMassiveCombatDifficultyInfo.IndividualPointsRewardsInfo)
				{
					list.Add(keyValuePair.Value);
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				GameObject go = GameObjectUtility.CloneGameObject(this.m_itemPrefab, this.m_rewardContent.transform);
				MassiveCombatPersonRewardItemUIController massiveCombatPersonRewardItemUIController = GameObjectUtility.AddControllerToGameObject<MassiveCombatPersonRewardItemUIController>(go);
				massiveCombatPersonRewardItemUIController.Init(list[i]);
				this.m_rewardItemUIControllerList.Add(massiveCombatPersonRewardItemUIController);
			}
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = this.m_playerContext.GetGuildPlayerMassiveCombatInfo();
			this.m_total.text = guildPlayerMassiveCombatInfo.Points.ToString();
		}

		// Token: 0x0600F698 RID: 63128 RVA: 0x00413314 File Offset: 0x00411514
		public void Refresh()
		{
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = this.m_playerContext.GetGuildPlayerMassiveCombatInfo();
			this.m_total.text = guildPlayerMassiveCombatInfo.Points.ToString();
			foreach (MassiveCombatPersonRewardItemUIController massiveCombatPersonRewardItemUIController in this.m_rewardItemUIControllerList)
			{
				massiveCombatPersonRewardItemUIController.Refresh();
			}
		}

		// Token: 0x04009191 RID: 37265
		[AutoBind("./PersonalProgressInfo/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_total;

		// Token: 0x04009192 RID: 37266
		[AutoBind("./RewardInfoListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardContent;

		// Token: 0x04009193 RID: 37267
		[AutoBind("./Prefab/PersonalRewardItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemPrefab;

		// Token: 0x04009194 RID: 37268
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009195 RID: 37269
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009196 RID: 37270
		private List<MassiveCombatPersonRewardItemUIController> m_rewardItemUIControllerList = new List<MassiveCombatPersonRewardItemUIController>();
	}
}
