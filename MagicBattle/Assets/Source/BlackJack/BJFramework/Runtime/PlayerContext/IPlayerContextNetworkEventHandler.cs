using System;

namespace BlackJack.BJFramework.Runtime.PlayerContext
{
	// Token: 0x0200006B RID: 107
	public interface IPlayerContextNetworkEventHandler
	{
		// Token: 0x060004D3 RID: 1235
		void OnGameServerConnected();

		// Token: 0x060004D4 RID: 1236
		void OnGameServerDisconnected();

		// Token: 0x060004D5 RID: 1237
		void OnGameServerError(int err, string excepionInfo = null);

		// Token: 0x060004D6 RID: 1238
		void OnLoginByAuthTokenAck(int result, bool needRedirect, string sessionToken);

		// Token: 0x060004D7 RID: 1239
		void OnLoginBySessionTokenAck(int result);

		// Token: 0x060004D8 RID: 1240
		void OnGameServerMessage(object msg, int msgId);
	}
}
