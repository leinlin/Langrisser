using System;
using SLua;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000596 RID: 1430
	[CustomLuaClass]
	public class MoneyCaculate
	{
		// Token: 0x06005219 RID: 21017 RVA: 0x00185DEC File Offset: 0x00183FEC
		public static double FenToYuan(int fen)
		{
			return (double)fen * 1.0 / 100.0;
		}

		// Token: 0x0600521A RID: 21018 RVA: 0x00185E04 File Offset: 0x00184004
		public static int YuanToFen(double yuan)
		{
			return (int)(yuan * 100.0);
		}

		// Token: 0x04003ABA RID: 15034
		private const int YuanPerFen = 100;
	}
}
