using System;
using System.Collections.Generic;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000599 RID: 1433
	public static class MiscExtensions
	{
		// Token: 0x06005223 RID: 21027 RVA: 0x00185ED0 File Offset: 0x001840D0
		public static T Clamp<T>(this T value, T min, T max, IComparer<T> comparer = null)
		{
			comparer = (comparer ?? Comparer<T>.Default);
			if (comparer.Compare(min, max) > 0)
			{
				return value.Clamp(max, min, comparer);
			}
			if (comparer.Compare(value, min) < 0)
			{
				return min;
			}
			if (comparer.Compare(value, max) > 0)
			{
				return max;
			}
			return value;
		}
	}
}
