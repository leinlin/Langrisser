using System;

namespace BlackJack.ProjectL.LibClient
{
	// Token: 0x020005AB RID: 1451
	public interface IClientEventHandler
	{
		// Token: 0x0600527F RID: 21119
		void OnConnected();

		// Token: 0x06005280 RID: 21120
		void OnDisconnected();

		// Token: 0x06005281 RID: 21121
		void OnError(int err, string excepionInfo = null);

		// Token: 0x06005282 RID: 21122
		void OnLoginByAuthTokenAck(int result, bool needRedirect, string sessionToken);

		// Token: 0x06005283 RID: 21123
		void OnLoginBySessionTokenAck(int result);

		// Token: 0x06005284 RID: 21124
		void OnMessage(object msg, int msgId);
	}
}
