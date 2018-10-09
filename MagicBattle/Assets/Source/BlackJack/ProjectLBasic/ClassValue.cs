using System;

namespace BlackJack.ProjectLBasic
{
	// Token: 0x020010BF RID: 4287
	public class ClassValue<T>
	{
		// Token: 0x060158DD RID: 88285 RVA: 0x0057D73C File Offset: 0x0057B93C
		public ClassValue(T v)
		{
			this.value = v;
		}

		// Token: 0x0400BC82 RID: 48258
		public T value = default(T);
	}
}
