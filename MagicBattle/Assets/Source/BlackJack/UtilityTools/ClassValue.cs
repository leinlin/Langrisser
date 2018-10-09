using System;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000592 RID: 1426
	public class ClassValue<T>
	{
		// Token: 0x06005205 RID: 20997 RVA: 0x00185990 File Offset: 0x00183B90
		public ClassValue(T v)
		{
			this.value = v;
		}

		// Token: 0x04003AB4 RID: 15028
		public T value = default(T);
	}
}
