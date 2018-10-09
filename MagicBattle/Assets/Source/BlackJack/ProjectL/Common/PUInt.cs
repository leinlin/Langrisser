using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003D6 RID: 982
	public struct PUInt
	{
		// Token: 0x06003AAC RID: 15020 RVA: 0x0010C9DC File Offset: 0x0010ABDC
		public PUInt(uint v)
		{
			this.m_Value = PUInt.Encode(v);
			this.m_Check = PUInt.Check(v);
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x0010C9F8 File Offset: 0x0010ABF8
		public static implicit operator PUInt(uint value)
		{
			return new PUInt(value);
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x0010CA00 File Offset: 0x0010AC00
		public static implicit operator uint(PUInt p)
		{
			uint num = PUInt.Decode(p.m_Value);
			if (p.m_Check == PUInt.Check(num))
			{
				return num;
			}
			return 0u;
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x0010CA30 File Offset: 0x0010AC30
		public override string ToString()
		{
			return PUInt.Decode(this.m_Value).ToString();
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x0010CA58 File Offset: 0x0010AC58
		private static uint Encode(uint v)
		{
			return v ^ 1431655765u;
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x0010CA64 File Offset: 0x0010AC64
		private static uint Decode(uint v)
		{
			return v ^ 1431655765u;
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x0010CA70 File Offset: 0x0010AC70
		private static uint Check(uint v)
		{
			return v ^ 2004318071u;
		}

		// Token: 0x04002CE7 RID: 11495
		private uint m_Value;

		// Token: 0x04002CE8 RID: 11496
		private uint m_Check;
	}
}
