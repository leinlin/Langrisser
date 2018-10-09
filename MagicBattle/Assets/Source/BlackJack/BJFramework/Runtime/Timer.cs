using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000052 RID: 82
	public static class Timer
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00011A20 File Offset: 0x0000FC20
		public static uint GetLastFrameDeltaTimeMs()
		{
			return (uint)(Timer.m_currTime - Timer.m_lastTickTime).TotalMilliseconds;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00011A48 File Offset: 0x0000FC48
		public static int GetCurrFrameCount()
		{
			return Time.frameCount;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00011A50 File Offset: 0x0000FC50
		public static void Tick()
		{
			Timer.m_lastTickTime = Timer.m_currTime;
			Timer.m_currTime = DateTime.Now;
			Timer.m_currTick += 1UL;
		}

		// Token: 0x040001A7 RID: 423
		public static DateTime m_currTime;

		// Token: 0x040001A8 RID: 424
		public static ulong m_currTick;

		// Token: 0x040001A9 RID: 425
		public static DateTime m_lastTickTime = DateTime.MaxValue;
	}
}
