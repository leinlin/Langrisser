using System;
using SLua;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000598 RID: 1432
	[CustomLuaClass]
	public class RMBStoreoreGoodsIdTools
	{
		// Token: 0x06005220 RID: 21024 RVA: 0x00185E40 File Offset: 0x00184040
		public static int GetRealGoodsId(string goodsId)
		{
			string[] array = goodsId.Split(new char[]
			{
				'_'
			});
			if (array.Length != 2)
			{
				return 0;
			}
			int result;
			if (int.TryParse(array[1], out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x00185E7C File Offset: 0x0018407C
		public static int GetStoreTypeId(string goodsId)
		{
			string[] array = goodsId.Split(new char[]
			{
				'_'
			});
			if (array.Length != 2)
			{
				return 0;
			}
			int result;
			if (int.TryParse(array[0], out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x00185EB8 File Offset: 0x001840B8
		public static string GetGoodsId(int storeTypeId, int realGoodsId)
		{
			return string.Format("{0}_{1}", storeTypeId, realGoodsId);
		}
	}
}
