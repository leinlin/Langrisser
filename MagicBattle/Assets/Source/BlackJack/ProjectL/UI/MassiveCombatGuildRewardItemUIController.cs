using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D19 RID: 3353
	public class MassiveCombatGuildRewardItemUIController : UIControllerBase
	{
		// Token: 0x0600F6A2 RID: 63138 RVA: 0x004135E0 File Offset: 0x004117E0
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_currencyButton.onClick.AddListener(new UnityAction(this.OnCurrencyClick));
		}

		// Token: 0x0600F6A3 RID: 63139 RVA: 0x0041363C File Offset: 0x0041183C
		public void Init(Rewards reward, int totalRewardCurrency)
		{
			ConfigDataGuildMassiveCombatRewardsInfo configDataGuildMassiveCombatRewardsInfo = this.m_configDataLoader.GetConfigDataGuildMassiveCombatRewardsInfo(reward.Id);
			this.m_percentText.text = string.Format("{0}%", reward.Percent);
			int num = Mathf.CeilToInt((float)(totalRewardCurrency * reward.Percent) * 0.01f);
			this.m_currencyText.text = string.Format("{0}+", num);
			GameObject prefab = this.m_resourceContainer.GetAsset("RewardGoods") as GameObject;
			RewardGoodsUIController.CreateRewardGoodsList(configDataGuildMassiveCombatRewardsInfo.BonusItems, this.m_rewardGroup.transform, prefab, null, true, 0, true);
		}

		// Token: 0x0600F6A4 RID: 63140 RVA: 0x004136DC File Offset: 0x004118DC
		private void OnCurrencyClick()
		{
			RewardGoodsDescUITask.StartUITask(this, GoodsType.GoodsType_GuildMedal, 0, 0, null, true);
		}

		// Token: 0x040091A4 RID: 37284
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private PrefabResourceContainer m_resourceContainer;

		// Token: 0x040091A5 RID: 37285
		[AutoBind("./TargeTitleText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_percentText;

		// Token: 0x040091A6 RID: 37286
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroup;

		// Token: 0x040091A7 RID: 37287
		[AutoBind("./RewardGroup/Currency", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currencyButton;

		// Token: 0x040091A8 RID: 37288
		[AutoBind("./RewardGroup/Currency/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_currencyText;

		// Token: 0x040091A9 RID: 37289
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040091AA RID: 37290
		private IConfigDataLoader m_configDataLoader;
	}
}
