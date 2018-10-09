using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200040B RID: 1035
	[CustomLuaClass]
	public class SoldierSkin
	{
		// Token: 0x06003C9F RID: 15519 RVA: 0x001130EC File Offset: 0x001112EC
		public SoldierSkin()
		{
			this.SkinId = 0;
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x001130FC File Offset: 0x001112FC
		public SoldierSkin(SoldierSkin other)
		{
			this.SkinId = other.SkinId;
			this.SoldierId = other.SoldierId;
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x0011311C File Offset: 0x0011131C
		// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x00113124 File Offset: 0x00111324
		public int SkinId { get; set; }

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x00113130 File Offset: 0x00111330
		// (set) Token: 0x06003CA4 RID: 15524 RVA: 0x00113138 File Offset: 0x00111338
		public int SoldierId { get; set; }

		// Token: 0x06003CA5 RID: 15525 RVA: 0x00113144 File Offset: 0x00111344
		public static ProSoldierSkin SoldierSkinToPbSoldierSkin(SoldierSkin skin)
		{
			return new ProSoldierSkin
			{
				SkinId = skin.SkinId,
				SoldierId = skin.SoldierId
			};
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x00113170 File Offset: 0x00111370
		public static SoldierSkin PbSoldierSkinToSoldierSkin(ProSoldierSkin pbSkin)
		{
			return new SoldierSkin
			{
				SkinId = pbSkin.SkinId,
				SoldierId = pbSkin.SoldierId
			};
		}
	}
}
