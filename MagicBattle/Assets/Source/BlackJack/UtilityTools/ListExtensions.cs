using System;
using System.Collections.Generic;

namespace BlackJack.UtilityTools
{
	// Token: 0x0200058D RID: 1421
	public static class ListExtensions
	{
		// Token: 0x060051EA RID: 20970 RVA: 0x001851F0 File Offset: 0x001833F0
		public static void Remove<T>(this List<T> list, Predicate<T> match)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (match(list[i]))
				{
					list.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x00185230 File Offset: 0x00183430
		public static int InsertInOrder<T>(this List<T> list, T item, bool unique = true, bool reverse = false)
		{
			int num = list.BinarySearch(item, (T x, T y) => Comparer<T>.Default.Compare(x, y), reverse);
			if (num < 0)
			{
				num = ~num;
				list.Insert(num, item);
			}
			else if (!unique)
			{
				list.Insert(num, item);
			}
			return num;
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x00185278 File Offset: 0x00183478
		public static int InsertInOrder<T>(this List<T> list, T item, Func<T, T, int> compare, bool unique = true)
		{
			int num = list.BinarySearch(item, compare, false);
			if (num < 0)
			{
				num = ~num;
				list.Insert(num, item);
			}
			else if (!unique)
			{
				list.Insert(num, item);
			}
			return num;
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x001852B8 File Offset: 0x001834B8
		public static int BinarySearch<T>(this List<T> list, T item, Func<T, T, int> compare = null, bool reverse = false)
		{
			if (compare == null)
			{
				return list.BinarySearch(item, (T x, T y) => Comparer<T>.Default.Compare(x, y), reverse);
			}
			return list.BinarySearch(item, new ListExtensions.ComparisonComparer<T>(compare, reverse));
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x001852E4 File Offset: 0x001834E4
		public static void AddUnique<T>(this List<T> list, T item)
		{
			int num = list.BinarySearch(item);
			if (num < 0)
			{
				list.Insert(~num, item);
			}
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x0018530C File Offset: 0x0018350C
		public static void AddRangeUnique<T>(this List<T> list, List<T> items)
		{
			foreach (T item in items)
			{
				list.AddUnique(item);
			}
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x00185364 File Offset: 0x00183564
		public static void RandomList<T>(this List<T> list)
		{
			if (list == null || list.Count == 0)
			{
				return;
			}
			Random random = new Random();
			int num = list.Count / 2;
			for (int i = 0; i < num; i++)
			{
				int index = random.Next(num, list.Count);
				T value = list[index];
				list[index] = list[i];
				list[i] = value;
			}
		}

		// Token: 0x0200058E RID: 1422
		public class ComparisonComparer<T> : IComparer<T>
		{
			// Token: 0x060051F3 RID: 20979 RVA: 0x001853F8 File Offset: 0x001835F8
			public ComparisonComparer(Func<T, T, int> compare, bool reverse = false)
			{
				if (compare == null)
				{
					throw new ArgumentNullException("comparison");
				}
				this.comparison = new Comparison<T>(compare.Invoke);
				this.reverse = reverse;
			}

			// Token: 0x060051F4 RID: 20980 RVA: 0x0018542C File Offset: 0x0018362C
			public int Compare(T x, T y)
			{
				return (!this.reverse) ? this.comparison(x, y) : this.comparison(y, x);
			}

			// Token: 0x04003AB1 RID: 15025
			private readonly Comparison<T> comparison;

			// Token: 0x04003AB2 RID: 15026
			private readonly bool reverse;
		}
	}
}
