using System;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200033E RID: 830
	[CustomLuaClass]
	public class RandomStoreItemDataKey
	{
		// Token: 0x0600310D RID: 12557 RVA: 0x000C0648 File Offset: 0x000BE848
		public RandomStoreItemDataKey(int storeId, int levelZoneId)
		{
			this.StoreId = storeId;
			this.LevelZoneId = levelZoneId;
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x000C0660 File Offset: 0x000BE860
		public override int GetHashCode()
		{
			return this.StoreId << 24 | this.LevelZoneId;
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x000C0680 File Offset: 0x000BE880
		public override bool Equals(object obj)
		{
			RandomStoreItemDataKey randomStoreItemDataKey = obj as RandomStoreItemDataKey;
			return this.StoreId == randomStoreItemDataKey.StoreId && this.LevelZoneId == randomStoreItemDataKey.LevelZoneId;
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x000C06BC File Offset: 0x000BE8BC
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x000C06C4 File Offset: 0x000BE8C4
		public int StoreId { get; set; }

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x000C06D0 File Offset: 0x000BE8D0
		// (set) Token: 0x06003113 RID: 12563 RVA: 0x000C06D8 File Offset: 0x000BE8D8
		public int LevelZoneId { get; set; }
	}
}
