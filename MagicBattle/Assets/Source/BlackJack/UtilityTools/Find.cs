using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000594 RID: 1428
	[CustomLuaClass]
	public class Find
	{
		// Token: 0x0600520E RID: 21006 RVA: 0x00185C3C File Offset: 0x00183E3C
		public static T MinInt<T>(List<T> list, Converter<T, int> convert)
		{
			return Find.TheMost<T, int>(list, convert, (int x, int y) => (x >= y) ? 0 : 1);
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x00185C54 File Offset: 0x00183E54
		public static T MaxInt<T>(List<T> list, Converter<T, int> convert)
		{
			return Find.TheMost<T, int>(list, convert, (int x, int y) => (x <= y) ? 0 : 1);
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x00185C6C File Offset: 0x00183E6C
		public static T MinFloat<T>(List<T> list, Converter<T, float> convert)
		{
			return Find.TheMost<T, float>(list, convert, (float x, float y) => (x >= y) ? 0 : 1);
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x00185C84 File Offset: 0x00183E84
		public static T MaxFloat<T>(List<T> list, Converter<T, float> convert)
		{
			return Find.TheMost<T, float>(list, convert, (float x, float y) => (x <= y) ? 0 : 1);
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x00185C9C File Offset: 0x00183E9C
		public static T TheMost<T, F>(List<T> list, Converter<T, F> convert, Comparison<F> compare)
		{
			T result = default(T);
			if (list == null || list.Count == 0)
			{
				return result;
			}
			result = list[0];
			F y = convert(list[0]);
			for (int i = 1; i < list.Count; i++)
			{
				F f = convert(list[i]);
				if (compare(f, y) > 0)
				{
					y = f;
					result = list[i];
				}
			}
			return result;
		}
	}
}
