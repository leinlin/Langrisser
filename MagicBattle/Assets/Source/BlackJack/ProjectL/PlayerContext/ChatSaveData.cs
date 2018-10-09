using System;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020010D9 RID: 4313
	public class ChatSaveData
	{
		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x06015995 RID: 88469 RVA: 0x005802B0 File Offset: 0x0057E4B0
		// (set) Token: 0x06015996 RID: 88470 RVA: 0x005802D0 File Offset: 0x0057E4D0
		[DoNotToLua]
		public ChatSaveData.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatSaveData.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCC1 RID: 48321
		[DoNotToLua]
		private ChatSaveData.LuaExportHelper luaExportHelper;

		// Token: 0x020010DA RID: 4314
		public class LuaExportHelper
		{
			// Token: 0x06015997 RID: 88471 RVA: 0x005802DC File Offset: 0x0057E4DC
			public LuaExportHelper(ChatSaveData owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCC2 RID: 48322
			private ChatSaveData m_owner;
		}
	}
}
