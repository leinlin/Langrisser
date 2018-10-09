using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003D9 RID: 985
	public struct PSByte
	{
		// Token: 0x06003AC1 RID: 15041 RVA: 0x0010CBBC File Offset: 0x0010ADBC
		public PSByte(sbyte v)
		{
			this.m_Value = PSByte.Encode(v);
			this.m_Check = PSByte.Check(v);
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x0010CBD8 File Offset: 0x0010ADD8
		public static implicit operator PSByte(sbyte value)
		{
			return new PSByte(value);
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x0010CBE0 File Offset: 0x0010ADE0
		public static implicit operator sbyte(PSByte p)
		{
			sbyte b = PSByte.Decode(p.m_Value);
			if ((int)p.m_Check == (int)PSByte.Check(b))
			{
				return b;
			}
			return 0;
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x0010CC14 File Offset: 0x0010AE14
		public override string ToString()
		{
			return PSByte.Decode(this.m_Value).ToString();
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x0010CC3C File Offset: 0x0010AE3C
		private static sbyte Encode(sbyte v)
		{
			return (sbyte)((int)v ^ 85);
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x0010CC44 File Offset: 0x0010AE44
		private static sbyte Decode(sbyte v)
		{
			return (sbyte)((int)v ^ 85);
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x0010CC4C File Offset: 0x0010AE4C
		private static sbyte Check(sbyte v)
		{
			return (sbyte)((int)v ^ 119);
		}

		// Token: 0x04002CED RID: 11501
		private sbyte m_Value;

		// Token: 0x04002CEE RID: 11502
		private sbyte m_Check;
	}
}
