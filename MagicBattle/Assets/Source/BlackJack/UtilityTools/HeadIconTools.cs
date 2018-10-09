using System;
using SLua;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000597 RID: 1431
	[CustomLuaClass]
	public class HeadIconTools
	{
		// Token: 0x0600521C RID: 21020 RVA: 0x00185E1C File Offset: 0x0018401C
		public static int GetHeadPortrait(int headIcon)
		{
			return headIcon >> 16;
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x00185E24 File Offset: 0x00184024
		public static int GetHeadFrame(int headIcon)
		{
			return headIcon & 65535;
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x00185E30 File Offset: 0x00184030
		public static int GetHeadIcon(int headPortraitId, int headFrameId)
		{
			return headPortraitId << 16 | headFrameId;
		}
	}
}
