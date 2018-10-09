using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.UtilityTools;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CEA RID: 3306
	public class GuildContributionRankingItemUIController : UIControllerBase
	{
		// Token: 0x0600F1C5 RID: 61893 RVA: 0x00403A14 File Offset: 0x00401C14
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x0600F1C6 RID: 61894 RVA: 0x00403A48 File Offset: 0x00401C48
		public void SetData(GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo, int rank)
		{
			if (rank <= 3)
			{
				this.m_rankValueImage.gameObject.SetActive(true);
				this.m_rankValueText.gameObject.SetActive(false);
				if (rank == 1)
				{
					this.m_rankValueImage.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_One.png");
				}
				else if (rank == 2)
				{
					this.m_rankValueImage.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Two.png");
				}
				else if (rank == 3)
				{
					this.m_rankValueImage.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Three.png");
				}
			}
			else
			{
				this.m_rankValueImage.gameObject.SetActive(false);
				this.m_rankValueText.gameObject.SetActive(true);
				this.m_rankValueText.text = rank.ToString();
			}
			this.m_totalContributionText.text = guildMassiveCombatMemberInfo.Points.ToString();
			this.m_todayContributionText.text = guildMassiveCombatMemberInfo.PointsToday.ToString();
			this.m_playerNameText.text = guildMassiveCombatMemberInfo.Summary.Name;
			this.m_levelText.text = guildMassiveCombatMemberInfo.Summary.Level.ToString();
			this.m_jobText.text = UIUtility.GetGuildTitleText(guildMassiveCombatMemberInfo.Title);
			this.m_headIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(guildMassiveCombatMemberInfo.Summary.HeadIcon)));
			UIUtility.SetPlayerHeadFrame(this.m_headFrameDummy, HeadIconTools.GetHeadFrame(guildMassiveCombatMemberInfo.Summary.HeadIcon), true, "Normal");
		}

		// Token: 0x04008F99 RID: 36761
		[AutoBind("./HeadIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIcon;

		// Token: 0x04008F9A RID: 36762
		[AutoBind("./HeadIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_headFrameDummy;

		// Token: 0x04008F9B RID: 36763
		[AutoBind("./HeadIcon/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x04008F9C RID: 36764
		[AutoBind("./PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x04008F9D RID: 36765
		[AutoBind("./JobText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobText;

		// Token: 0x04008F9E RID: 36766
		[AutoBind("./AllContributionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_totalContributionText;

		// Token: 0x04008F9F RID: 36767
		[AutoBind("./TodayContributionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_todayContributionText;

		// Token: 0x04008FA0 RID: 36768
		[AutoBind("./RankingIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rankValueImage;

		// Token: 0x04008FA1 RID: 36769
		[AutoBind("./RankingValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rankValueText;

		// Token: 0x04008FA2 RID: 36770
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008FA3 RID: 36771
		private IConfigDataLoader m_configDataLoader;
	}
}
