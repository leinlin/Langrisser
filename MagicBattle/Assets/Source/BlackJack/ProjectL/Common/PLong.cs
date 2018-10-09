using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003D4 RID: 980
	public struct PLong
	{
		// Token: 0x06003A9E RID: 15006 RVA: 0x0010C890 File Offset: 0x0010AA90
		public PLong(long v)
		{
			this.m_Value = PLong.Encode(v);
			this.m_Check = PLong.Check(v);
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x0010C8AC File Offset: 0x0010AAAC
		public static implicit operator PLong(long value)
		{
			return new PLong(value);
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x0010C8B4 File Offset: 0x0010AAB4
		public static implicit operator long(PLong p)
		{
			long num = PLong.Decode(p.m_Value);
			if (p.m_Check == PLong.Check(num))
			{
				return num;
			}
			return 0L;
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x0010C8E4 File Offset: 0x0010AAE4
		public override string ToString()
		{
			return PLong.Decode(this.m_Value).ToString();
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x0010C90C File Offset: 0x0010AB0C
		private static long Encode(long v)
		{
			return v ^ 6148914691236517205L;
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x0010C91C File Offset: 0x0010AB1C
		private static long Decode(long v)
		{
			return v ^ 6148914691236517205L;
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x0010C92C File Offset: 0x0010AB2C
		private static long Check(long v)
		{
			return v ^ 8608480567731124087L;
		}

		// Token: 0x04002CE3 RID: 11491
		private long m_Value;

		// Token: 0x04002CE4 RID: 11492
		private long m_Check;
	}
}
