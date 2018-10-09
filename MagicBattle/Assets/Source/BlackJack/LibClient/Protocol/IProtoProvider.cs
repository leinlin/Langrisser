using System;

namespace BlackJack.LibClient.Protocol
{
	// Token: 0x02000866 RID: 2150
	public interface IProtoProvider
	{
		// Token: 0x06006B06 RID: 27398
		Type GetTypeById(int vId);

		// Token: 0x06006B07 RID: 27399
		int GetIdByType(Type vType);
	}
}
