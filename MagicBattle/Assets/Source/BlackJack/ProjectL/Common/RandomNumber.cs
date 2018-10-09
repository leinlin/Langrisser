using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003DC RID: 988
	[CustomLuaClass]
	public class RandomNumber
	{
		// Token: 0x06003ACF RID: 15055 RVA: 0x0010CCE8 File Offset: 0x0010AEE8
		public RandomNumber()
		{
			this.m_state = default(RandomNumberState);
			this.m_state.w = 521288629u;
			this.m_state.z = 362436069u;
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x0010CD2C File Offset: 0x0010AF2C
		public void SetSeed(int seed)
		{
			if (seed != 0)
			{
				this.m_state.w = (uint)seed;
			}
			else
			{
				this.m_state.w = 521288629u;
			}
			this.m_state.z = 362436069u + this.m_state.w - 521288629u;
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x0010CD84 File Offset: 0x0010AF84
		public void SetState(RandomNumberState state)
		{
			this.m_state.w = state.w;
			this.m_state.z = state.z;
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x0010CDAC File Offset: 0x0010AFAC
		public RandomNumberState GetState()
		{
			return this.m_state;
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x0010CDB4 File Offset: 0x0010AFB4
		public int Next()
		{
			this.m_state.w = 18000u * (this.m_state.w & 65535u) + (this.m_state.w >> 16);
			this.m_state.z = 36969u * (this.m_state.z & 65535u) + (this.m_state.z >> 16);
			uint num = (this.m_state.z << 16) + this.m_state.w;
			int num2 = (int)num;
			if (num2 < 0)
			{
				num2 = -num2;
			}
			return num2;
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x0010CE4C File Offset: 0x0010B04C
		public int Next(int min, int max)
		{
			if (max <= min)
			{
				return min;
			}
			return min + this.Next() % (max - min);
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x0010CE70 File Offset: 0x0010B070
		public int GetRandomNumberByAccumulateWeight(Dictionary<int, int> weights)
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
			int num2 = this.Next(0, num);
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

		// Token: 0x04002CF3 RID: 11507
		private RandomNumberState m_state;

		// Token: 0x04002CF4 RID: 11508
		private const uint InitW = 521288629u;

		// Token: 0x04002CF5 RID: 11509
		private const uint InitZ = 362436069u;
	}
}
