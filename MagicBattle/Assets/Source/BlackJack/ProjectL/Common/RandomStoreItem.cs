using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000577 RID: 1399
	[CustomLuaClass]
	public class RandomStoreItem
	{
		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06005137 RID: 20791 RVA: 0x00182FA4 File Offset: 0x001811A4
		// (set) Token: 0x06005136 RID: 20790 RVA: 0x00182F98 File Offset: 0x00181198
		public int Id { get; set; }

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06005139 RID: 20793 RVA: 0x00182FB8 File Offset: 0x001811B8
		// (set) Token: 0x06005138 RID: 20792 RVA: 0x00182FAC File Offset: 0x001811AC
		public bool Bought { get; set; }

		// Token: 0x0600513A RID: 20794 RVA: 0x00182FC0 File Offset: 0x001811C0
		public static ProRandomStoreItem StoreItemToPBStoreItem(RandomStoreItem storeItem)
		{
			return new ProRandomStoreItem
			{
				Id = storeItem.Id,
				Bought = storeItem.Bought
			};
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x00182FF0 File Offset: 0x001811F0
		public static RandomStoreItem PBStoreItemToStoreItem(ProRandomStoreItem pbStoreItem)
		{
			return new RandomStoreItem
			{
				Id = pbStoreItem.Id,
				Bought = pbStoreItem.Bought
			};
		}
	}
}
