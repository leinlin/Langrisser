using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D49 RID: 3401
	public class GuildStoreUITask : UITask
	{
		// Token: 0x0600F9A0 RID: 63904 RVA: 0x0041B7EC File Offset: 0x004199EC
		public GuildStoreUITask(string name) : base(name)
		{
		}

		// Token: 0x0600F9A1 RID: 63905 RVA: 0x0041B87C File Offset: 0x00419A7C
		public static void StartUITask(UIIntent lastIntent)
		{
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(lastIntent, typeof(GuildStoreUITask).Name, null);
				UIManager instance = UIManager.Instance;
				UIIntent intent = uiintentReturnable;
				bool pushIntentToStack = true;
				bool clearIntentStack = false;
				if (GuildStoreUITask.<>f__mg$cache0 == null)
				{
					GuildStoreUITask.<>f__mg$cache0 = new Action(GuildStoreUITask.OnLoadAllResCompletedCallback);
				}
				instance.StartUITask(intent, pushIntentToStack, clearIntentStack, GuildStoreUITask.<>f__mg$cache0);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600F9A2 RID: 63906 RVA: 0x0041B8B8 File Offset: 0x00419AB8
		public static void OnLoadAllResCompletedCallback()
		{
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(GuildStoreUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600F9A3 RID: 63907 RVA: 0x0041B8EC File Offset: 0x00419AEC
		protected override void InitAllUIControllers()
		{
			base.InitAllUIControllers();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_guildStoreUIController = (this.m_uiCtrlArray[0] as GuildStoreUIController);
			this.m_guildStoreUIController.Init(this);
		}

		// Token: 0x0600F9A4 RID: 63908 RVA: 0x0041B948 File Offset: 0x00419B48
		protected override void UpdateView()
		{
		}

		// Token: 0x0600F9A5 RID: 63909 RVA: 0x0041B94C File Offset: 0x00419B4C
		public void ReturnLastScene()
		{
			base.Stop();
			base.ReturnPrevUITask();
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x0600F9A6 RID: 63910 RVA: 0x0041B95C File Offset: 0x00419B5C
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				return this.m_layerDescArray;
			}
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x0600F9A7 RID: 63911 RVA: 0x0041B964 File Offset: 0x00419B64
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x04009299 RID: 37529
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "GuildStoreUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Guild_ABS/Prefab/GuildStoreUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400929A RID: 37530
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "GuildStoreUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.GuildStoreUIController"),
				m_ctrlName = "GuildStoreUIController"
			}
		};

		// Token: 0x0400929B RID: 37531
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400929C RID: 37532
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400929D RID: 37533
		private GuildStoreUIController m_guildStoreUIController;

		// Token: 0x0400929E RID: 37534
		[CompilerGenerated]
		private static Action <>f__mg$cache0;
	}
}
