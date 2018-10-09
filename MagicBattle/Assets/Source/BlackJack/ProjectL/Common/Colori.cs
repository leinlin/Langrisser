using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003D2 RID: 978
	public struct Colori
	{
		// Token: 0x06003A8F RID: 14991 RVA: 0x0010C4D0 File Offset: 0x0010A6D0
		public Colori(byte r, byte g, byte b, byte a = 255)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x0010C4F0 File Offset: 0x0010A6F0
		public static bool operator ==(Colori lhs, Colori rhs)
		{
			return lhs.r == rhs.r && lhs.g == rhs.g && lhs.b == rhs.b && lhs.a == rhs.a;
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x0010C54C File Offset: 0x0010A74C
		public static bool operator !=(Colori lhs, Colori rhs)
		{
			return lhs.r != rhs.r || lhs.g != rhs.g || lhs.b != rhs.b || lhs.a != rhs.a;
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x0010C5A8 File Offset: 0x0010A7A8
		public static Colori Lerp(Colori a, Colori b, float t)
		{
			return new Colori((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x04002CDF RID: 11487
		public byte r;

		// Token: 0x04002CE0 RID: 11488
		public byte g;

		// Token: 0x04002CE1 RID: 11489
		public byte b;

		// Token: 0x04002CE2 RID: 11490
		public byte a;
	}
}
