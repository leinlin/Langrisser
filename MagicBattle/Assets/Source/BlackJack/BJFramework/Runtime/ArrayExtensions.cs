using System;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000122 RID: 290
	public static class ArrayExtensions
	{
		// Token: 0x06000BF3 RID: 3059 RVA: 0x00033188 File Offset: 0x00031388
		public static bool Contains(this int[] target, int nr)
		{
			if (target == null)
			{
				return false;
			}
			foreach (int num in target)
			{
				if (num == nr)
				{
					return true;
				}
			}
			return false;
		}
	}
}
