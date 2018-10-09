using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003DA RID: 986
	public struct PByte
	{
		// Token: 0x06003AC8 RID: 15048 RVA: 0x0010CC54 File Offset: 0x0010AE54
		public PByte(byte v)
		{
			this.m_Value = PByte.Encode(v);
			this.m_Check = PByte.Check(v);
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x0010CC70 File Offset: 0x0010AE70
		public static implicit operator PByte(byte value)
		{
			return new PByte(value);
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x0010CC78 File Offset: 0x0010AE78
		public static implicit operator byte(PByte p)
		{
			byte b = PByte.Decode(p.m_Value);
			if (p.m_Check == PByte.Check(b))
			{
				return b;
			}
			return 0;
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x0010CCA8 File Offset: 0x0010AEA8
		public override string ToString()
		{
			return PByte.Decode(this.m_Value).ToString();
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x0010CCD0 File Offset: 0x0010AED0
		private static byte Encode(byte v)
		{
			return v ^ 85;
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x0010CCD8 File Offset: 0x0010AED8
		private static byte Decode(byte v)
		{
			return v ^ 85;
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x0010CCE0 File Offset: 0x0010AEE0
		private static byte Check(byte v)
		{
			return v ^ 119;
		}

		// Token: 0x04002CEF RID: 11503
		private byte m_Value;

		// Token: 0x04002CF0 RID: 11504
		private byte m_Check;
	}
}
