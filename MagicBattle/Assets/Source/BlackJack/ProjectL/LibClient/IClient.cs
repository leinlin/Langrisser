using System;

namespace BlackJack.ProjectL.LibClient
{
	// Token: 0x020005A9 RID: 1449
	public interface IClient
	{
		// Token: 0x06005276 RID: 21110
		bool LoginByAuthToken(string serverAddress, int serverPort, string authToken, string clientVersion, string clientDeviceId, string localization, int loginChannelId, int bornChannelId);

		// Token: 0x06005277 RID: 21111
		bool LoginBySessionToken(string sessionToken, string clientVersion, string localization, int loginChannelId, int bornChannelId);

		// Token: 0x06005278 RID: 21112
		bool Disconnect();

		// Token: 0x06005279 RID: 21113
		bool SendMessage(object msg);

		// Token: 0x0600527A RID: 21114
		void Tick();

		// Token: 0x0600527B RID: 21115
		void Close();

		// Token: 0x0600527C RID: 21116
		void BlockProcessMsg(bool isBlock);
	}
}
