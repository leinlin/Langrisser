using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D15 RID: 3349
	public class GuildMassiveCombatRewardUIController : UIControllerBase
	{
		// Token: 0x0600F68E RID: 63118 RVA: 0x00412FF4 File Offset: 0x004111F4
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_personalToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				this.OnTabChange(this.m_personalToggle.gameObject);
			});
			this.m_guildToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				this.OnTabChange(this.m_guildToggle.gameObject);
			});
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnBGClick));
			this.m_personRewardUIController = GameObjectUtility.AddControllerToGameObject<MassiveCombatPersonRewardUIController>(this.m_personPlane);
			this.m_guildRewardUIController = GameObjectUtility.AddControllerToGameObject<MassiveCombatGuildRewardUIController>(this.m_guildPlane);
			this.m_personRewardUIController.gameObject.SetActive(true);
		}

		// Token: 0x0600F68F RID: 63119 RVA: 0x004130B8 File Offset: 0x004112B8
		private void OnEnable()
		{
			this.Refresh();
		}

		// Token: 0x0600F690 RID: 63120 RVA: 0x004130C0 File Offset: 0x004112C0
		private void OnTabChange(GameObject obj)
		{
			if (obj == this.m_personalToggle.gameObject)
			{
				this.m_personRewardUIController.gameObject.SetActive(true);
				this.m_guildRewardUIController.gameObject.SetActive(false);
			}
			else if (obj == this.m_guildToggle.gameObject)
			{
				this.m_personRewardUIController.gameObject.SetActive(false);
				this.m_guildRewardUIController.gameObject.SetActive(true);
			}
		}

		// Token: 0x0600F691 RID: 63121 RVA: 0x00413144 File Offset: 0x00411344
		public void Refresh()
		{
			this.m_personRewardUIController.Refresh();
			this.m_guildRewardUIController.Refresh();
		}

		// Token: 0x0600F692 RID: 63122 RVA: 0x0041315C File Offset: 0x0041135C
		private void OnBGClick()
		{
			UIUtility.SetUIStateClose(this.m_rewardPanelAnimation, "Close", null, false, true);
		}

		// Token: 0x04009187 RID: 37255
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_rewardPanelAnimation;

		// Token: 0x04009188 RID: 37256
		[AutoBind("./Detail/ToggleGroup/PersonalToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_personalToggle;

		// Token: 0x04009189 RID: 37257
		[AutoBind("./Detail/ToggleGroup/GuildToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_guildToggle;

		// Token: 0x0400918A RID: 37258
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x0400918B RID: 37259
		[AutoBind("./Detail/Person", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_personPlane;

		// Token: 0x0400918C RID: 37260
		[AutoBind("./Detail/Guild", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_guildPlane;

		// Token: 0x0400918D RID: 37261
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400918E RID: 37262
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400918F RID: 37263
		private MassiveCombatPersonRewardUIController m_personRewardUIController;

		// Token: 0x04009190 RID: 37264
		private MassiveCombatGuildRewardUIController m_guildRewardUIController;
	}
}
