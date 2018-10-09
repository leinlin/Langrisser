using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.UtilityTools
{
	// Token: 0x0200058A RID: 1418
	public static class RandomExtentions
	{
		// Token: 0x060051DA RID: 20954 RVA: 0x00184BC8 File Offset: 0x00182DC8
		public static int GetRandomNumberByWeight(this Random random, Dictionary<int, int> weights, int weightMax)
		{
			if (weights.Count == 0 || weightMax <= 0)
			{
				return int.MinValue;
			}
			int num = 0;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (KeyValuePair<int, int> keyValuePair in weights)
			{
				if (keyValuePair.Value > 0)
				{
					num += keyValuePair.Value;
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			if (dictionary.Count == 0 || num > weightMax)
			{
				return int.MinValue;
			}
			int num2 = random.Next(weightMax);
			foreach (KeyValuePair<int, int> keyValuePair2 in dictionary)
			{
				int num3 = num2 - keyValuePair2.Value;
				if (num3 < 0)
				{
					return keyValuePair2.Key;
				}
				num2 = num3;
			}
			return int.MinValue;
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x00184CF8 File Offset: 0x00182EF8
		public static int GetRandomBumberByAccumulateWeight(this Random random, Dictionary<int, int> weights)
		{
			if (weights.Count == 0)
			{
				return int.MinValue;
			}
			int num = 0;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (KeyValuePair<int, int> keyValuePair in weights)
			{
				if (keyValuePair.Value > 0)
				{
					num += keyValuePair.Value;
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			int num2 = random.Next(num);
			foreach (KeyValuePair<int, int> keyValuePair2 in dictionary)
			{
				int num3 = num2 - keyValuePair2.Value;
				if (num3 < 0)
				{
					return keyValuePair2.Key;
				}
				num2 = num3;
			}
			return int.MinValue;
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x00184E0C File Offset: 0x0018300C
		public static bool CanGetSpecificRandomNumber(this Random random, int weight, int weightMax)
		{
			int num = random.Next(weightMax);
			return num < weight;
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x00184E2C File Offset: 0x0018302C
		public static List<int> GetRandomNums(this Random random, int begin, int end, int needToRandomNums)
		{
			int num = end - begin;
			if (num <= 0)
			{
				return new List<int>();
			}
			List<int> list = new List<int>(num);
			for (int i = begin; i < end; i++)
			{
				list.Add(i);
			}
			return random.GetRandomNums(list, needToRandomNums);
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x00184E74 File Offset: 0x00183074
		public static List<int> GetRandomNumsLessMemory(this Random random, int begin, int end, int needToRandomNums)
		{
			int num = end - begin;
			if (num < 0)
			{
				return new List<int>();
			}
			List<int> list = new List<int>();
			while (list.Count < needToRandomNums)
			{
				int item = random.Next(0, num) + begin;
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x00184EC8 File Offset: 0x001830C8
		public static List<int> GetRandomNums(this Random random, List<int> inputCollection, int nums)
		{
			if (inputCollection == null || inputCollection.Count < nums)
			{
				return new List<int>();
			}
			List<int> list = new List<int>(inputCollection);
			List<int> list2 = new List<int>();
			int num = list.Count - 1;
			for (int i = 0; i < nums; i++)
			{
				int index = random.Next(num + 1);
				int value = list[index];
				list[index] = list[num];
				list[num] = value;
				list2.Add(list[num]);
				num--;
			}
			return list2;
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00184F5C File Offset: 0x0018315C
		public static int GetRandomNumber(this Random random, List<int> inputCollection)
		{
			if (inputCollection.Count == 0)
			{
				return int.MinValue;
			}
			int index = random.Next(inputCollection.Count);
			return inputCollection[index];
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x00184F90 File Offset: 0x00183190
		public static void ShuffleWithWeight<T>(this Random rand, List<T> items, List<int> weights)
		{
			if (items.Count != weights.Count)
			{
				throw new ArgumentException("items.Count != weights.Count");
			}
			ulong num = 0UL;
			foreach (int num2 in weights)
			{
				if (num2 < 0)
				{
					throw new ArgumentException("negative weight detected!");
				}
				num += (ulong)((long)num2);
			}
			for (int i = 0; i < items.Count; i++)
			{
				if (num == 0UL)
				{
					return;
				}
				ulong num3 = rand.NextUInt64(0UL, num);
				for (int j = i; j < weights.Count; j++)
				{
					num3 -= (ulong)((long)weights[j]);
					if (num3 < 0UL)
					{
						num -= (ulong)((long)weights[j]);
						int value = weights[j];
						weights[j] = weights[i];
						weights[i] = value;
						T value2 = items[j];
						items[j] = items[i];
						items[i] = value2;
						break;
					}
				}
			}
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x001850C8 File Offset: 0x001832C8
		public static ulong NextUInt64(this Random rand, ulong inclusive_min = 0UL, ulong exclusive_max = 18446744073709551615UL)
		{
			if (exclusive_max <= inclusive_min)
			{
				throw new ArgumentOutOfRangeException("exclusive_max", "exclusive_max must be strictly greater than inclusive_min!");
			}
			ulong num = exclusive_max - inclusive_min;
			ulong num2;
			do
			{
				byte[] array = new byte[8];
				rand.NextBytes(array);
				num2 = BitConverter.ToUInt64(array, 0);
			}
			while (num2 > 18446744073709551615UL - (18446744073709551615UL % num + 1UL) % num);
			return num2 % num + inclusive_min;
		}

		// Token: 0x0200058B RID: 1419
		[CustomLuaClass]
		public class UtilityFunction
		{
			// Token: 0x060051E4 RID: 20964 RVA: 0x00185128 File Offset: 0x00183328
			public static void Swap<T>(ref T lhs, ref T rhs) where T : struct
			{
				T t = lhs;
				lhs = rhs;
				rhs = t;
			}
		}
	}
}
