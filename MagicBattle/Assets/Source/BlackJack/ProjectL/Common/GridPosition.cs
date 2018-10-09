using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000584 RID: 1412
	public struct GridPosition
	{
		// Token: 0x060051A1 RID: 20897 RVA: 0x00183DA0 File Offset: 0x00181FA0
		public GridPosition(GridPosition p)
		{
			this.x = p.x;
			this.y = p.y;
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x00183DBC File Offset: 0x00181FBC
		public GridPosition(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		// Token: 0x060051A3 RID: 20899 RVA: 0x00183DCC File Offset: 0x00181FCC
		public void Set(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x00183DDC File Offset: 0x00181FDC
		public static GridPosition Add(GridPosition a, GridPosition b)
		{
			return new GridPosition(a.x + b.x, a.y + b.y);
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x00183E04 File Offset: 0x00182004
		public static GridPosition Subtract(GridPosition a, GridPosition b)
		{
			return new GridPosition(a.x - b.x, a.y - b.y);
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x00183E2C File Offset: 0x0018202C
		public static GridPosition Multiply(GridPosition a, int b)
		{
			return new GridPosition(a.x * b, a.y * b);
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x00183E48 File Offset: 0x00182048
		public static int Distance(GridPosition a, GridPosition b)
		{
			return Math.Abs(a.x - b.x) + Math.Abs(a.y - b.y);
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x00183E74 File Offset: 0x00182074
		public static float EuclideanDistance(GridPosition a, GridPosition b)
		{
			int num = a.x - b.x;
			int num2 = a.y - b.y;
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x00183EB0 File Offset: 0x001820B0
		public static bool operator ==(GridPosition a, GridPosition b)
		{
			return a.x == b.x && a.y == b.y;
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x00183ED8 File Offset: 0x001820D8
		public static bool operator !=(GridPosition a, GridPosition b)
		{
			return a.x != b.x || a.y != b.y;
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x00183F04 File Offset: 0x00182104
		public static GridPosition Round(float fx, float fy)
		{
			int num = (int)Math.Round((double)fx);
			int num2 = (int)Math.Round((double)fy);
			return new GridPosition(num, num2);
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x00183F2C File Offset: 0x0018212C
		public static GridPosition Lerp(GridPosition a, GridPosition b, float t)
		{
			float fx = (float)a.x + (float)(b.x - a.x) * t;
			float fy = (float)a.y + (float)(b.y - a.y) * t;
			return GridPosition.Round(fx, fy);
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x00183F78 File Offset: 0x00182178
		public override string ToString()
		{
			return string.Format("({0}, {1})", this.x.ToString(), this.y.ToString());
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x00183FA8 File Offset: 0x001821A8
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.y.GetHashCode() << 13;
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x00183FD0 File Offset: 0x001821D0
		public override bool Equals(object other)
		{
			if (!(other is GridPosition))
			{
				return false;
			}
			GridPosition gridPosition = (GridPosition)other;
			return this.x == gridPosition.x && this.y == gridPosition.y;
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x00184018 File Offset: 0x00182218
		public static GridPosition Null
		{
			get
			{
				return GridPosition._null;
			}
		}

		// Token: 0x060051B1 RID: 20913 RVA: 0x00184020 File Offset: 0x00182220
		public static bool TryParse(string str, out GridPosition ret)
		{
			ret = GridPosition.Null;
			string[] array = str.Split(new char[]
			{
				','
			});
			return array.Length == 2 && int.TryParse(array[0], out ret.x) && int.TryParse(array[1], out ret.y);
		}

		// Token: 0x04003A92 RID: 14994
		private static GridPosition _null = new GridPosition(-1, -1);

		// Token: 0x04003A93 RID: 14995
		public int x;

		// Token: 0x04003A94 RID: 14996
		public int y;
	}
}
