using System;
using System.Collections.Generic;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000120 RID: 288
	internal static class ListExtensions
	{
		// Token: 0x06000BED RID: 3053 RVA: 0x00032E88 File Offset: 0x00031088
		public static void Shuffle<T>(this IList<T> list)
		{
			int i = list.Count;
			while (i > 1)
			{
				i--;
				int index = ThreadSafeRandom.ThisThreadsRandom.Next(i + 1);
				T value = list[index];
				list[index] = list[i];
				list[i] = value;
			}
		}
	}
}
