using System;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using PD.SDK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.Static
{
	// Token: 0x020010F3 RID: 4339
	public class ProjectLGameEntryUIController : UIControllerBase
	{
		// Token: 0x060159D7 RID: 88535 RVA: 0x00580800 File Offset: 0x0057EA00
		public void SetMesssage(string msg)
		{
			this.m_messageText.text = msg;
		}

		// Token: 0x060159D8 RID: 88536 RVA: 0x00580810 File Offset: 0x0057EA10
		public void ShowMessageText(bool show)
		{
			this.m_messageText.gameObject.SetActive(show);
		}

		// Token: 0x060159D9 RID: 88537 RVA: 0x00580824 File Offset: 0x0057EA24
		public void ShowUpdateClientUI(bool show)
		{
			this.m_updateClientUI.SetActive(show);
		}

		// Token: 0x060159DA RID: 88538 RVA: 0x00580834 File Offset: 0x0057EA34
		public bool IsTipActive()
		{
			return this.m_progressBar.gameObject.activeInHierarchy;
		}

		// Token: 0x060159DB RID: 88539 RVA: 0x00580848 File Offset: 0x0057EA48
		public void SetProgress(float value)
		{
			if (this.m_progressBar.value == value)
			{
				return;
			}
			this.m_progressBar.value = value;
			this.m_progressText.text = string.Format("{0,4:F1}%", value * 100f);
		}

		// Token: 0x060159DC RID: 88540 RVA: 0x00580894 File Offset: 0x0057EA94
		public void AddProgress(float value, float threshhold = 1f)
		{
			this.SetProgress(Math.Max(this.m_progressBar.value, Math.Min(threshhold, this.m_progressBar.value + value)));
		}

		// Token: 0x060159DD RID: 88541 RVA: 0x005808C0 File Offset: 0x0057EAC0
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_closeCompanyButton.onClick.AddListener(new UnityAction(this.OnCloseCompanyClicked));
			this.m_progressBarBackground.SetActive(!PDSDK.IsIosReview);
			this.m_progressBarFill.SetActive(!PDSDK.IsIosReview);
			this.m_progressBarValue.SetActive(!PDSDK.IsIosReview);
			this.SetProgress(0f);
		}

		// Token: 0x060159DE RID: 88542 RVA: 0x00580934 File Offset: 0x0057EB34
		private void OnCloseCompanyClicked()
		{
			if (!Application.isEditor)
			{
				return;
			}
			this.m_companyUI.gameObject.SetActive(false);
			if (this.m_onShowCompanyEnd != null)
			{
				this.m_onShowCompanyEnd();
				this.m_onShowCompanyEnd = null;
			}
		}

		// Token: 0x060159DF RID: 88543 RVA: 0x00580970 File Offset: 0x0057EB70
		public void ShowCompanyUI(Action onEnd)
		{
			this.m_onShowCompanyEnd = onEnd;
			this.m_companyUI.gameObject.SetActive(true);
			this.m_companyUI.SetActionForUIStateFinshed("Show", delegate
			{
				this.m_companyUI.gameObject.SetActive(false);
				if (this.m_onShowCompanyEnd != null)
				{
					this.m_onShowCompanyEnd();
					this.m_onShowCompanyEnd = null;
				}
			});
			this.m_companyUI.SetToUIState("Show", false, true);
		}

		// Token: 0x0400BCDE RID: 48350
		private Action m_onShowCompanyEnd;

		// Token: 0x0400BCDF RID: 48351
		[AutoBind("EntryUIPrefab/UpdateClient/ProcessBar/Msg", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_messageText;

		// Token: 0x0400BCE0 RID: 48352
		[AutoBind("EntryUIPrefab/UpdateClient/ProcessBar/ProgressValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressText;

		// Token: 0x0400BCE1 RID: 48353
		[AutoBind("EntryUIPrefab/UpdateClient/ProcessBar", AutoBindAttribute.InitState.NotInit, false)]
		private Slider m_progressBar;

		// Token: 0x0400BCE2 RID: 48354
		[AutoBind("EntryUIPrefab/UpdateClient/ProcessBar/Fill Area", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_progressBarFill;

		// Token: 0x0400BCE3 RID: 48355
		[AutoBind("EntryUIPrefab/UpdateClient/ProcessBar/Background", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_progressBarBackground;

		// Token: 0x0400BCE4 RID: 48356
		[AutoBind("EntryUIPrefab/UpdateClient/ProcessBar/ProgressValue", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_progressBarValue;

		// Token: 0x0400BCE5 RID: 48357
		[AutoBind("EntryUIPrefab/UpdateClient", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_updateClientUI;

		// Token: 0x0400BCE6 RID: 48358
		[AutoBind("EntryUIPrefab/Company", AutoBindAttribute.InitState.Inactive, false)]
		private CommonUIStateController m_companyUI;

		// Token: 0x0400BCE7 RID: 48359
		[AutoBind("EntryUIPrefab/Company/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeCompanyButton;
	}
}
