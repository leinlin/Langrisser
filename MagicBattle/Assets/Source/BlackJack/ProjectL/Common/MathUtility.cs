using System;
using FixMath.NET;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003D3 RID: 979
	public struct MathUtility
	{
		// Token: 0x06003A93 RID: 14995 RVA: 0x0010C62C File Offset: 0x0010A82C
		public static Fix64 Min(Fix64 a, Fix64 b)
		{
			return (!(a <= b)) ? b : a;
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x0010C644 File Offset: 0x0010A844
		public static Fix64 Max(Fix64 a, Fix64 b)
		{
			return (!(a >= b)) ? b : a;
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x0010C65C File Offset: 0x0010A85C
		public static Fix64 Lerp(Fix64 a, Fix64 b, Fix64 t)
		{
			return a + (b - a) * t;
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x0010C674 File Offset: 0x0010A874
		public static Fix64 Clamp(Fix64 a, Fix64 min, Fix64 max)
		{
			if (a < min)
			{
				return a;
			}
			if (a > max)
			{
				return max;
			}
			return a;
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x0010C694 File Offset: 0x0010A894
		public static uint SetByte(uint a, int idx, int value)
		{
			int num = idx * 8;
			a &= ~(255u << num);
			a |= (uint)((uint)value << num);
			return a;
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x0010C6C0 File Offset: 0x0010A8C0
		public static int GetByte(uint a, int idx)
		{
			int num = idx * 8;
			return (int)(a >> num & 255u);
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x0010C6E0 File Offset: 0x0010A8E0
		public static uint SetBit(uint a, int idx, bool b)
		{
			uint num = 1u << idx;
			if (b)
			{
				a |= num;
			}
			else
			{
				a &= ~num;
			}
			return a;
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x0010C70C File Offset: 0x0010A90C
		public static ulong SetBit(ulong a, int idx, bool b)
		{
			ulong num = 1UL << idx;
			if (b)
			{
				a |= num;
			}
			else
			{
				a &= ~num;
			}
			return a;
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x0010C738 File Offset: 0x0010A938
		public static bool GetBit(uint a, int idx)
		{
			uint num = 1u << idx;
			return (a & num) != 0u;
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x0010C758 File Offset: 0x0010A958
		public static bool GetBit(ulong a, int idx)
		{
			ulong num = 1UL << idx;
			return (a & num) != 0UL;
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x0010C778 File Offset: 0x0010A978
		public static bool IsLineSegmentIntersectCircle(Vector2i p0, Vector2i p1, Vector2i center, Fix64 radius)
		{
			Vector2i vector2i = p1 - p0;
			Vector2i vector2i2 = p0 - center;
			Fix64 y = Vector2i.Dot(vector2i, vector2i);
			Fix64 fix = Vector2i.Dot(vector2i2, vector2i) * (Fix64)2L;
			Fix64 y2 = Vector2i.Dot(vector2i2, vector2i2) - radius * radius;
			Fix64 fix2 = fix * fix - (Fix64)4L * y * y2;
			if (fix2 < Fix64.Zero)
			{
				return false;
			}
			fix2 = Fix64.Sqrt(fix2);
			Fix64 x = (-fix - fix2) / ((Fix64)2L * y);
			Fix64 x2 = (-fix + fix2) / ((Fix64)2L * y);
			return (x >= Fix64.Zero && x <= Fix64.One) || (x2 >= Fix64.Zero && x2 <= Fix64.One);
		}
	}
}
