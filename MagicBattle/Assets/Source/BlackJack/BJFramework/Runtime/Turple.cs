using System;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000124 RID: 292
	public class Turple<T1, T2, T3>
	{
		// Token: 0x06000BF8 RID: 3064 RVA: 0x00033220 File Offset: 0x00031420
		public Turple(T1 elem1, T2 elem2, T3 elem3)
		{
			this.Elem1 = elem1;
			this.Elem2 = elem2;
			this.Elem3 = elem3;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00033240 File Offset: 0x00031440
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00033248 File Offset: 0x00031448
		public T1 Elem1 { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00033254 File Offset: 0x00031454
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x0003325C File Offset: 0x0003145C
		public T2 Elem2 { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00033268 File Offset: 0x00031468
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00033270 File Offset: 0x00031470
		public T3 Elem3 { get; set; }
	}
}
