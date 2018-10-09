using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.ProjectLBasic;

namespace BlackJack.ProjectL.Static
{
	// Token: 0x02001101 RID: 4353
	public class ProjectLGameManager : GameManager
	{
		// Token: 0x06015A51 RID: 88657 RVA: 0x005824B8 File Offset: 0x005806B8
		public override bool Initlize()
		{
			AudioManager4CRI.m_criProviderType = typeof(CRIProvider);
			return base.Initlize();
		}

		// Token: 0x06015A52 RID: 88658 RVA: 0x005824D0 File Offset: 0x005806D0
		public bool InitLogicInterface()
		{
			if (this.m_classLoader == null)
			{
				Debug.LogError("ProjectLGameManager.InitLogicInterface m_classLoader is null.");
				return false;
			}
			string text = "BlackJack.ProjectL.Misc.GameLogic4TargetProject";
			this.m_logicInterface = (this.m_classLoader.CreateInstance(new TypeDNName(text), new object[0]) as IGameLogicInterface4TargetProject);
			if (this.m_logicInterface == null)
			{
				Debug.LogError(string.Format("ProjectLGameManager.InitLogicInterface Failed to create: {0}", text));
				return false;
			}
			this.m_logicInterface.OnInitialize();
			return true;
		}

		// Token: 0x06015A53 RID: 88659 RVA: 0x00582548 File Offset: 0x00580748
		public override bool InitGameNetworkClient()
		{
			if (this.m_logicInterface == null)
			{
				Debug.LogError("ProjectLGameManager.InitGameNetworkClient Error: m_logicInterface is null.");
				return false;
			}
			this.m_networkClient = this.m_logicInterface.CreateNetWorkClient();
			return this.m_networkClient != null;
		}

		// Token: 0x06015A54 RID: 88660 RVA: 0x00582580 File Offset: 0x00580780
		public override bool InitPlayerContext()
		{
			TypeDNName typeDNName = new TypeDNName("BlackJack.ProjectL.PlayerContext.ProjectLPlayerContext");
			this.m_playerContext = (ClassLoader.Instance.CreateInstance(typeDNName, new object[0]) as PlayerContextBase);
			return this.m_playerContext != null;
		}

		// Token: 0x06015A55 RID: 88661 RVA: 0x005825C0 File Offset: 0x005807C0
		public override bool StartLuaManager(Action<bool> onEnd)
		{
			if ((this.m_state != GameManager.GMState.Inited && this.m_state != GameManager.GMState.DynamicAssemblyLoadEnd) || this.m_resourceManager.State != ResourceManager.RMState.AssetBundleManifestLoadEnd)
			{
				Debug.LogError("StartLuaManager in wrong status");
				return false;
			}
			return base.StartLuaManager(onEnd);
		}

		// Token: 0x06015A56 RID: 88662 RVA: 0x00582600 File Offset: 0x00580800
		public override bool StartLoadConfigData(Action<bool> onEnd, out int initLoadDataCount)
		{
			return base.StartLoadConfigData(delegate(bool lret)
			{
				onEnd(lret);
			}, out initLoadDataCount);
		}

		// Token: 0x06015A57 RID: 88663 RVA: 0x00582630 File Offset: 0x00580830
		public override void OnApplicationQuit()
		{
			if (this.m_networkClient != null)
			{
				Debug.Log("OnAppliactionQuit m_networkClient.Close");
				this.m_networkClient.Disconnect();
				this.m_networkClient.Close();
			}
			base.OnApplicationQuit();
			if (this.m_logicInterface != null)
			{
				this.m_logicInterface.OnApplicationQuit();
			}
		}

		// Token: 0x06015A58 RID: 88664 RVA: 0x00582688 File Offset: 0x00580888
		public override void Clear4Relogin()
		{
			Debug.Log("Clear4Relogin");
		}

		// Token: 0x06015A59 RID: 88665 RVA: 0x00582694 File Offset: 0x00580894
		public override void Clear4Return2Login(bool isCacheDataDirty)
		{
			Debug.Log("Clear4Return2Login, isCacheDataDirty " + isCacheDataDirty);
			base.Clear4Return2Login(isCacheDataDirty);
		}

		// Token: 0x0400BD33 RID: 48435
		private IGameLogicInterface4TargetProject m_logicInterface;
	}
}
