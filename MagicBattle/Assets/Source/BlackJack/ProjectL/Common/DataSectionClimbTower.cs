using System;
using BlackJack.ProjectL.Protocol;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004C4 RID: 1220
	public class DataSectionClimbTower : DataSection
	{
		// Token: 0x06004AB8 RID: 19128 RVA: 0x00174AC4 File Offset: 0x00172CC4
		public DataSectionClimbTower()
		{
			this.ClimbTower = new ClimbTower();
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x00174AD8 File Offset: 0x00172CD8
		public override object SerializeToClient()
		{
			DSClimbTowerNtf dsclimbTowerNtf = new DSClimbTowerNtf
			{
				Version = (uint)base.Version
			};
			dsclimbTowerNtf.Floor = this.ClimbTower.Floor;
			dsclimbTowerNtf.HistoryFloorMax = this.ClimbTower.HistoryFloorMax;
			dsclimbTowerNtf.ClimbTower = ClimbTower.ToPb(this.GlobalClimbTowerInfo);
			return dsclimbTowerNtf;
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x00174B30 File Offset: 0x00172D30
		public override void ClearInitedData()
		{
			this.ClimbTower = new ClimbTower();
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x00174B40 File Offset: 0x00172D40
		public void SetGlobalClimbTowerInfo(GlobalClimbTowerInfo info)
		{
			this.GlobalClimbTowerInfo = info;
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06004ABC RID: 19132 RVA: 0x00174B4C File Offset: 0x00172D4C
		// (set) Token: 0x06004ABD RID: 19133 RVA: 0x00174B54 File Offset: 0x00172D54
		public ClimbTower ClimbTower { get; set; }

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x00174B60 File Offset: 0x00172D60
		// (set) Token: 0x06004ABF RID: 19135 RVA: 0x00174B68 File Offset: 0x00172D68
		public GlobalClimbTowerInfo GlobalClimbTowerInfo { get; set; }
	}
}
