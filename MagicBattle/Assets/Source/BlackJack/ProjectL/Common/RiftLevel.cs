using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000573 RID: 1395
	[CustomLuaClass]
	public class RiftLevel
	{
		// Token: 0x06005116 RID: 20758 RVA: 0x00182B0C File Offset: 0x00180D0C
		public RiftLevel(int levelId, int nums, int stars)
		{
			this.LevelId = levelId;
			this.Nums = nums;
			this.Stars = stars;
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06005117 RID: 20759 RVA: 0x00182B2C File Offset: 0x00180D2C
		// (set) Token: 0x06005118 RID: 20760 RVA: 0x00182B34 File Offset: 0x00180D34
		public int LevelId { get; set; }

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06005119 RID: 20761 RVA: 0x00182B40 File Offset: 0x00180D40
		// (set) Token: 0x0600511A RID: 20762 RVA: 0x00182B48 File Offset: 0x00180D48
		public int Nums { get; set; }

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x0600511B RID: 20763 RVA: 0x00182B54 File Offset: 0x00180D54
		// (set) Token: 0x0600511C RID: 20764 RVA: 0x00182B5C File Offset: 0x00180D5C
		public int Stars { get; set; }

		// Token: 0x0600511D RID: 20765 RVA: 0x00182B68 File Offset: 0x00180D68
		public static RiftLevel PBRiftLevelToRiftLevel(ProRiftLevel pbRiftLevel)
		{
			return new RiftLevel(pbRiftLevel.LevelId, pbRiftLevel.Nums, pbRiftLevel.Star);
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x00182B90 File Offset: 0x00180D90
		public static ProRiftLevel RiftLevelToPBRiftLevel(RiftLevel riftLevel)
		{
			return new ProRiftLevel
			{
				LevelId = riftLevel.LevelId,
				Nums = riftLevel.Nums,
				Star = riftLevel.Stars
			};
		}
	}
}
