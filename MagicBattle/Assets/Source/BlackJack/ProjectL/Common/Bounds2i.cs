using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003D1 RID: 977
	public struct Bounds2i
	{
		// Token: 0x06003A8B RID: 14987 RVA: 0x0010C3AC File Offset: 0x0010A5AC
		public void SetEmpty()
		{
			this.minX = (this.minY = int.MaxValue);
			this.maxX = (this.maxY = int.MinValue);
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x0010C3E4 File Offset: 0x0010A5E4
		public bool IsEmpty()
		{
			return this.minX >= this.maxX || this.minY >= this.maxY;
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x0010C40C File Offset: 0x0010A60C
		public void Expand(int x, int y, int radius)
		{
			if (x - radius < this.minX)
			{
				this.minX = x - radius;
			}
			if (x + radius > this.maxX)
			{
				this.maxX = x + radius;
			}
			if (y - radius < this.minY)
			{
				this.minY = y - radius;
			}
			if (y + radius > this.maxY)
			{
				this.maxY = y + radius;
			}
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x0010C478 File Offset: 0x0010A678
		public bool IsOverlap(Bounds2i b)
		{
			return b.minX <= this.maxX && b.maxX >= this.minX && b.minY <= this.maxY && b.maxY >= this.minY;
		}

		// Token: 0x04002CDB RID: 11483
		public int minX;

		// Token: 0x04002CDC RID: 11484
		public int minY;

		// Token: 0x04002CDD RID: 11485
		public int maxX;

		// Token: 0x04002CDE RID: 11486
		public int maxY;
	}
}
