using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003D8 RID: 984
	public struct PUShort
	{
		// Token: 0x06003ABA RID: 15034 RVA: 0x0010CB1C File Offset: 0x0010AD1C
		public PUShort(ushort v)
		{
			this.m_Value = PUShort.Encode(v);
			this.m_Check = PUShort.Check(v);
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x0010CB38 File Offset: 0x0010AD38
		public static implicit operator PUShort(ushort value)
		{
			return new PUShort(value);
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x0010CB40 File Offset: 0x0010AD40
		public static implicit operator ushort(PUShort p)
		{
			ushort num = PUShort.Decode(p.m_Value);
			if (p.m_Check == PUShort.Check(num))
			{
				return num;
			}
			return 0;
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x0010CB70 File Offset: 0x0010AD70
		public override string ToString()
		{
			return PUShort.Decode(this.m_Value).ToString();
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x0010CB98 File Offset: 0x0010AD98
		private static ushort Encode(ushort v)
		{
			return v ^ 21845;
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x0010CBA4 File Offset: 0x0010ADA4
		private static ushort Decode(ushort v)
		{
			return v ^ 21845;
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x0010CBB0 File Offset: 0x0010ADB0
		private static ushort Check(ushort v)
		{
			return v ^ 30583;
		}

		// Token: 0x04002CEB RID: 11499
		private ushort m_Value;

		// Token: 0x04002CEC RID: 11500
		private ushort m_Check;
	}
}
