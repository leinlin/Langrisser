using System;
using SLua;

namespace BlackJack.UtilityTools
{
	// Token: 0x0200058C RID: 1420
	[CustomLuaClass]
	public class MathCaculate
	{
		// Token: 0x060051E6 RID: 20966 RVA: 0x00185158 File Offset: 0x00183358
		public static long GetDownIntegerByPeriod(long inputIntger, int period)
		{
			if (period <= 0)
			{
				period = 1;
			}
			long num = inputIntger / (long)period;
			if (inputIntger < 0L)
			{
				num -= 1L;
			}
			return num;
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x00185184 File Offset: 0x00183384
		public static long GetUpInterByPeriod(long inputIntger, int period)
		{
			if (period <= 0)
			{
				period = 1;
			}
			long num = inputIntger / (long)period;
			if (inputIntger > 0L)
			{
				num += 1L;
			}
			return num;
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x001851B0 File Offset: 0x001833B0
		public static long GetDownIntegerByDiscount(long inputInterger, int discount)
		{
			if (discount > 10 || discount < 1)
			{
				discount = 10;
			}
			return MathCaculate.GetDownIntegerByPeriod(inputInterger * (long)discount, 10);
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x001851D0 File Offset: 0x001833D0
		public static long GetUpIntegerByDiscount(long inputInterger, int discount)
		{
			if (discount > 10 || discount < 1)
			{
				discount = 10;
			}
			return MathCaculate.GetUpInterByPeriod(inputInterger * (long)discount, 10);
		}

		// Token: 0x04003AAF RID: 15023
		private const int MaxDiscount = 10;

		// Token: 0x04003AB0 RID: 15024
		private const int MinDiscount = 1;
	}
}
