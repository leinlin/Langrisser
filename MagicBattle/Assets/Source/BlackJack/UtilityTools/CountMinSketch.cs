using System;
using SLua;

namespace BlackJack.UtilityTools
{
	// Token: 0x0200059B RID: 1435
	[CustomLuaClass]
	public class CountMinSketch
	{
		// Token: 0x06005227 RID: 21031 RVA: 0x00185FD8 File Offset: 0x001841D8
		public CountMinSketch(double epsilon, double delta)
		{
			this._width = (uint)Math.Ceiling(2.7182818284590451 / epsilon);
			this._depth = (uint)Math.Ceiling(Math.Log(1.0 / delta));
			this._epsilon = epsilon;
			this._delta = delta;
			this.Reset();
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x00186034 File Offset: 0x00184234
		public CountMinSketch Add(ulong data)
		{
			int num = 0;
			while ((long)num < (long)((ulong)this._depth))
			{
				this._matrix[num][(int)(checked((IntPtr)this.Hash(num, data)))] += 1UL;
				num++;
			}
			this._count += 1UL;
			return this;
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x00186088 File Offset: 0x00184288
		public ulong Count(ulong data)
		{
			ulong num = ulong.MaxValue;
			int num2 = 0;
			while ((long)num2 < (long)((ulong)this._depth))
			{
				num = Math.Min(num, this._matrix[num2][(int)(checked((IntPtr)this.Hash(num2, data)))]);
				num2++;
			}
			return num;
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x001860CC File Offset: 0x001842CC
		public CountMinSketch Reset()
		{
			Random random = new Random();
			this._matrix = new ulong[this._depth][];
			this._a = new ulong[this._depth];
			this._b = new ulong[this._depth];
			int num = 0;
			while ((long)num < (long)((ulong)this._depth))
			{
				this._matrix[num] = new ulong[this._width];
				bool flag;
				ulong num2;
				ulong num3;
				do
				{
					flag = true;
					num2 = (ulong)((long)random.Next(1, (int)(this._depth * 1000u)));
					num3 = (ulong)((long)random.Next(1, (int)(this._depth * 1000u)));
					for (int i = 0; i < num; i++)
					{
						if (this._a[i] * num3 == this._b[i] * num2)
						{
							flag = false;
							break;
						}
					}
				}
				while (!flag);
				this._a[num] = num2;
				this._b[num] = num3;
				if (this._a[num] >= 2305843009213693951UL || this._b[num] >= 2305843009213693951UL)
				{
					throw new ArgumentException("Hash function parameters must be 0 < a < P && b < P");
				}
				num++;
			}
			return this;
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x00186204 File Offset: 0x00184404
		public ulong Hash(int index, ulong value)
		{
			return (this._a[index] * value + this._b[index]) % 2305843009213693951UL % (ulong)this._width;
		}

		// Token: 0x04003ABB RID: 15035
		private const ulong VERY_LARGE_PRIME = 2305843009213693951UL;

		// Token: 0x04003ABC RID: 15036
		private double _epsilon;

		// Token: 0x04003ABD RID: 15037
		private double _delta;

		// Token: 0x04003ABE RID: 15038
		[DoNotToLua]
		private ulong[][] _matrix;

		// Token: 0x04003ABF RID: 15039
		private uint _width;

		// Token: 0x04003AC0 RID: 15040
		private uint _depth;

		// Token: 0x04003AC1 RID: 15041
		private ulong[] _a;

		// Token: 0x04003AC2 RID: 15042
		private ulong[] _b;

		// Token: 0x04003AC3 RID: 15043
		private ulong _count;
	}
}
