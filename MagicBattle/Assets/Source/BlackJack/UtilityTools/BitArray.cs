using System;
using System.Collections.Generic;

namespace BlackJack.UtilityTools
{
	// Token: 0x0200059C RID: 1436
	public class BitArray
	{
		// Token: 0x0600522D RID: 21037 RVA: 0x00186240 File Offset: 0x00184440
		public void SetBits(List<int> bits)
		{
			foreach (int abit in bits)
			{
				this.SetABit(abit);
			}
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x00186298 File Offset: 0x00184498
		public void SetABit(int bit)
		{
			int num = bit / BitArray.IntBitNums;
			int num2 = num - this.Bits.Count + 1;
			if (num2 > 0)
			{
				for (int i = 0; i < num2; i++)
				{
					this.Bits.Add(0);
				}
			}
			int num3 = bit % BitArray.IntBitNums;
			int num4 = 1 << num3;
			List<int> bits;
			int index;
			(bits = this.Bits)[index = num] = (bits[index] | num4);
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00186314 File Offset: 0x00184514
		public void CleanBits(List<int> bits)
		{
			foreach (int bit in bits)
			{
				this.CleanABit(bit);
			}
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x0018636C File Offset: 0x0018456C
		public void CleanABit(int bit)
		{
			int num = bit / BitArray.IntBitNums;
			int num2 = bit % BitArray.IntBitNums;
			int num3 = -1 - (1 << num2);
			List<int> bits;
			int index;
			(bits = this.Bits)[index = num] = (bits[index] & num3);
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x001863B0 File Offset: 0x001845B0
		public bool IsBitSet(int bit)
		{
			int num = bit / BitArray.IntBitNums;
			if (num >= this.Bits.Count)
			{
				return false;
			}
			int num2 = bit % BitArray.IntBitNums;
			int num3 = 1 << num2;
			return (this.Bits[num] & num3) != 0;
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x001863FC File Offset: 0x001845FC
		public void Clear()
		{
			this.Bits.Clear();
		}

		// Token: 0x04003AC4 RID: 15044
		public List<int> Bits = new List<int>();

		// Token: 0x04003AC5 RID: 15045
		private static int IntBitNums = 32;
	}
}
