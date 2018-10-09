using System;

namespace BlackJack.BJFramework.Runtime.PlayerContext
{
	// Token: 0x0200006A RID: 106
	public interface IPlayerContextNetworkClient
	{
		// Token: 0x060004CC RID: 1228
		bool LoginByAuthToken(string serverAddress, int serverPort, string authToken, string clientVersion, string clientDeviceId, string localization, int loginChannelId, int bornChannelId);

		// Token: 0x060004CD RID: 1229
		bool LoginBySessionToken(string sessionToken, string clientVersion, string localization, int loginChannelId, int bornChannelId);

		// Token: 0x060004CE RID: 1230
		bool Disconnect();

		// Token: 0x060004CF RID: 1231
		bool SendMessage(object msg);

		// Token: 0x060004D0 RID: 1232
		void Tick();

		// Token: 0x060004D1 RID: 1233
		void Close();

		// Token: 0x060004D2 RID: 1234
		void BlockProcessMsg(bool isBlock);
	}
}
