using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003D7 RID: 983
	public struct PShort
	{
		// Token: 0x06003AB3 RID: 15027 RVA: 0x0010CA7C File Offset: 0x0010AC7C
		public PShort(short v)
		{
			this.m_Value = PShort.Encode(v);
			this.m_Check = PShort.Check(v);
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x0010CA98 File Offset: 0x0010AC98
		public static implicit operator PShort(short value)
		{
			return new PShort(value);
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x0010CAA0 File Offset: 0x0010ACA0
		public static implicit operator short(PShort p)
		{
			short num = PShort.Decode(p.m_Value);
			if (p.m_Check == PShort.Check(num))
			{
				return num;
			}
			return 0;
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x0010CAD0 File Offset: 0x0010ACD0
		public override string ToString()
		{
			return PShort.Decode(this.m_Value).ToString();
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x0010CAF8 File Offset: 0x0010ACF8
		private static short Encode(short v)
		{
			return v ^ 21845;
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x0010CB04 File Offset: 0x0010AD04
		private static short Decode(short v)
		{
			return v ^ 21845;
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x0010CB10 File Offset: 0x0010AD10
		private static short Check(short v)
		{
			return v ^ 30583;
		}

		// Token: 0x04002CE9 RID: 11497
		private short m_Value;

		// Token: 0x04002CEA RID: 11498
		private short m_Check;
	}
}
