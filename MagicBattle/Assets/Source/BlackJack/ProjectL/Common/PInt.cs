using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003D5 RID: 981
	public struct PInt
	{
		// Token: 0x06003AA5 RID: 15013 RVA: 0x0010C93C File Offset: 0x0010AB3C
		public PInt(int v)
		{
			this.m_Value = PInt.Encode(v);
			this.m_Check = PInt.Check(v);
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x0010C958 File Offset: 0x0010AB58
		public static implicit operator PInt(int value)
		{
			return new PInt(value);
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x0010C960 File Offset: 0x0010AB60
		public static implicit operator int(PInt p)
		{
			int num = PInt.Decode(p.m_Value);
			if (p.m_Check == PInt.Check(num))
			{
				return num;
			}
			return 0;
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x0010C990 File Offset: 0x0010AB90
		public override string ToString()
		{
			return PInt.Decode(this.m_Value).ToString();
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x0010C9B8 File Offset: 0x0010ABB8
		private static int Encode(int v)
		{
			return v ^ 1431655765;
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x0010C9C4 File Offset: 0x0010ABC4
		private static int Decode(int v)
		{
			return v ^ 1431655765;
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x0010C9D0 File Offset: 0x0010ABD0
		private static int Check(int v)
		{
			return v ^ 2004318071;
		}

		// Token: 0x04002CE5 RID: 11493
		private int m_Value;

		// Token: 0x04002CE6 RID: 11494
		private int m_Check;
	}
}
