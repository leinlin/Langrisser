using System;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020010D7 RID: 4311
	public class ChatMessageClient
	{
		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x06015991 RID: 88465 RVA: 0x0058026C File Offset: 0x0057E46C
		// (set) Token: 0x06015992 RID: 88466 RVA: 0x0058028C File Offset: 0x0057E48C
		[DoNotToLua]
		public ChatMessageClient.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatMessageClient.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCBF RID: 48319
		[DoNotToLua]
		private ChatMessageClient.LuaExportHelper luaExportHelper;

		// Token: 0x020010D8 RID: 4312
		public class LuaExportHelper
		{
			// Token: 0x06015993 RID: 88467 RVA: 0x00580298 File Offset: 0x0057E498
			public LuaExportHelper(ChatMessageClient owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCC0 RID: 48320
			private ChatMessageClient m_owner;
		}
	}
}
