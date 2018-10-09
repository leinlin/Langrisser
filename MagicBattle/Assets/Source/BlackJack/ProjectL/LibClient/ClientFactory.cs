using System;
using System.IO;
using SLua;

namespace BlackJack.ProjectL.LibClient
{
	// Token: 0x020005A8 RID: 1448
	[CustomLuaClass]
	public class ClientFactory
	{
		// Token: 0x06005275 RID: 21109 RVA: 0x001873B0 File Offset: 0x001855B0
		public static IClient CreateClient(IClientEventHandler handler, Func<Stream, Type, int, object> deserializeMessageAction = null)
		{
			return new Client(handler, deserializeMessageAction);
		}
	}
}
