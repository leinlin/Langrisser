using System;
using FixMath.NET;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003DD RID: 989
	public struct Vector2i
	{
		// Token: 0x06003AD6 RID: 15062 RVA: 0x0010CF84 File Offset: 0x0010B184
		public Vector2i(Fix64 x, Fix64 y)
		{
			this.x = x;
			this.y = y;
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x0010CF94 File Offset: 0x0010B194
		public Vector2i(int x, int y)
		{
			this.x = (Fix64)((long)x);
			this.y = (Fix64)((long)y);
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x0010CFB0 File Offset: 0x0010B1B0
		public void Set(Fix64 x, Fix64 y)
		{
			this.x = x;
			this.y = y;
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x0010CFC0 File Offset: 0x0010B1C0
		public void Set(int x, int y)
		{
			this.x = (Fix64)((long)x);
			this.y = (Fix64)((long)y);
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x0010CFDC File Offset: 0x0010B1DC
		public void Normalize()
		{
			Fix64 magnitude = this.magnitude;
			if (magnitude > Fix64.Zero)
			{
				this /= magnitude;
			}
			else
			{
				this = Vector2i.zero;
			}
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x0010D024 File Offset: 0x0010B224
		public static Fix64 Dot(Vector2i a, Vector2i b)
		{
			return a.x * b.x + a.y * b.y;
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x0010D054 File Offset: 0x0010B254
		public static Fix64 Distance(Vector2i a, Vector2i b)
		{
			return (a - b).magnitude;
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x0010D070 File Offset: 0x0010B270
		public static Vector2i Lerp(Vector2i a, Vector2i b, Fix64 t)
		{
			return a + (b - a) * t;
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x0010D088 File Offset: 0x0010B288
		public static Vector2i MoveTowards(Vector2i current, Vector2i target, Fix64 maxDistanceDelta)
		{
			Vector2i a = target - current;
			Fix64 magnitude = a.magnitude;
			if (magnitude <= maxDistanceDelta || magnitude == Fix64.Zero)
			{
				return target;
			}
			return current + a * (maxDistanceDelta / magnitude);
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06003ADF RID: 15071 RVA: 0x0010D0D8 File Offset: 0x0010B2D8
		public Vector2i normalized
		{
			get
			{
				Vector2i result = new Vector2i(this.x, this.y);
				result.Normalize();
				return result;
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06003AE0 RID: 15072 RVA: 0x0010D100 File Offset: 0x0010B300
		public Fix64 magnitude
		{
			get
			{
				return Fix64.Sqrt(this.x * this.x + this.y * this.y);
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x0010D130 File Offset: 0x0010B330
		public Fix64 sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y;
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x0010D15C File Offset: 0x0010B35C
		public static Vector2i zero
		{
			get
			{
				return new Vector2i(Fix64.Zero, Fix64.Zero);
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x0010D170 File Offset: 0x0010B370
		public static Vector2i one
		{
			get
			{
				return new Vector2i(Fix64.One, Fix64.One);
			}
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x0010D184 File Offset: 0x0010B384
		public static Vector2i operator +(Vector2i a, Vector2i b)
		{
			return new Vector2i(a.x + b.x, a.y + b.y);
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x0010D1B4 File Offset: 0x0010B3B4
		public static Vector2i operator -(Vector2i a, Vector2i b)
		{
			return new Vector2i(a.x - b.x, a.y - b.y);
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x0010D1E4 File Offset: 0x0010B3E4
		public static Vector2i operator -(Vector2i a)
		{
			return new Vector2i(-a.x, -a.y);
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x0010D204 File Offset: 0x0010B404
		public static Vector2i operator *(Vector2i a, Fix64 d)
		{
			return new Vector2i(a.x * d, a.y * d);
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x0010D228 File Offset: 0x0010B428
		public static Vector2i operator /(Vector2i a, Fix64 d)
		{
			return new Vector2i(a.x / d, a.y / d);
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x0010D24C File Offset: 0x0010B44C
		public static bool operator ==(Vector2i a, Vector2i b)
		{
			return a.x == b.x && a.y == b.y;
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x0010D27C File Offset: 0x0010B47C
		public static bool operator !=(Vector2i a, Vector2i b)
		{
			return a.x != b.x || a.y != b.y;
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x0010D2AC File Offset: 0x0010B4AC
		public override string ToString()
		{
			string format = "F1";
			return this.ToString(format);
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x0010D2C8 File Offset: 0x0010B4C8
		public string ToString(string format)
		{
			return string.Format("({0}, {1})", ((float)this.x).ToString(format), ((float)this.y).ToString(format));
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x0010D308 File Offset: 0x0010B508
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.y.GetHashCode() << 2;
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x0010D330 File Offset: 0x0010B530
		public override bool Equals(object other)
		{
			if (!(other is Vector2i))
			{
				return false;
			}
			Vector2i vector2i = (Vector2i)other;
			return this.x == vector2i.x && this.y == vector2i.y;
		}

		// Token: 0x04002CF6 RID: 11510
		public Fix64 x;

		// Token: 0x04002CF7 RID: 11511
		public Fix64 y;
	}
}
