using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020010EF RID: 4335
	public class VoicePacket
	{
		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x060159C1 RID: 88513 RVA: 0x0058059C File Offset: 0x0057E79C
		// (set) Token: 0x060159C2 RID: 88514 RVA: 0x005805BC File Offset: 0x0057E7BC
		[DoNotToLua]
		public VoicePacket.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new VoicePacket.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0400BCD7 RID: 48343
		[DoNotToLua]
		private VoicePacket.LuaExportHelper luaExportHelper;

		// Token: 0x020010F0 RID: 4336
		public class LuaExportHelper
		{
			// Token: 0x060159C3 RID: 88515 RVA: 0x005805C8 File Offset: 0x0057E7C8
			public LuaExportHelper(VoicePacket owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400BCD8 RID: 48344
			private VoicePacket m_owner;
		}
	}
}
