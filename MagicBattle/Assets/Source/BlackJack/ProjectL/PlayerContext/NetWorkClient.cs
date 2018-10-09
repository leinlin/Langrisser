using System;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.ProjectL.LibClient;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008F2 RID: 2290
	[CustomLuaClass]
	public class NetWorkClient : IPlayerContextNetworkClient
	{
		// Token: 0x0600788E RID: 30862 RVA: 0x0020D074 File Offset: 0x0020B274
		public NetWorkClient(IClient realClient)
		{
			this.m_client = realClient;
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x0020D084 File Offset: 0x0020B284
		public bool LoginByAuthToken(string serverAddress, int serverPort, string authToken, string clientVersion, string clientDeviceId, string localization, int loginChannelId, int bornChannelId)
		{
			return this.m_client.LoginByAuthToken(serverAddress, serverPort, authToken, clientVersion, clientDeviceId, localization, loginChannelId, bornChannelId);
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x0020D0AC File Offset: 0x0020B2AC
		public bool LoginBySessionToken(string sessionToken, string clientVersion, string localization, int loginChannelId, int bornChannelId)
		{
			return this.m_client.LoginBySessionToken(sessionToken, clientVersion, localization, loginChannelId, bornChannelId);
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x0020D0C0 File Offset: 0x0020B2C0
		public bool Disconnect()
		{
			return this.m_client.Disconnect();
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x0020D0D0 File Offset: 0x0020B2D0
		public bool SendMessage(object msg)
		{
			return this.m_client.SendMessage(msg);
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x0020D0E0 File Offset: 0x0020B2E0
		public void Tick()
		{
			this.m_client.Tick();
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x0020D0F0 File Offset: 0x0020B2F0
		public void Close()
		{
			this.m_client.Close();
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x0020D100 File Offset: 0x0020B300
		public void BlockProcessMsg(bool isBlock)
		{
			this.m_client.BlockProcessMsg(isBlock);
		}

		// Token: 0x0400569D RID: 22173
		private IClient m_client;
	}
}
