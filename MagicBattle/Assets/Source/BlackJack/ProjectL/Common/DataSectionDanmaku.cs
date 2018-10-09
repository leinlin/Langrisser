using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004CE RID: 1230
	[CustomLuaClass]
	public class DataSectionDanmaku : DataSection
	{
		// Token: 0x06004AE5 RID: 19173 RVA: 0x00175300 File Offset: 0x00173500
		public override void ClearInitedData()
		{
			this.m_bannedTime = DateTime.MinValue;
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x00175310 File Offset: 0x00173510
		public bool IsBanned(DateTime currentTime)
		{
			return this.m_bannedTime != DateTime.MinValue && this.m_bannedTime >= currentTime;
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x00175338 File Offset: 0x00173538
		public bool IsBannedTimeExpired(DateTime current)
		{
			return this.m_bannedTime != DateTime.MinValue && this.m_bannedTime < current;
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x00175360 File Offset: 0x00173560
		public void Ban(DateTime bannedTime)
		{
			this.m_bannedTime = bannedTime;
			base.SetDirty(true);
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x00175370 File Offset: 0x00173570
		public void Unban()
		{
			this.m_bannedTime = DateTime.MinValue;
			base.SetDirty(true);
		}

		// Token: 0x04003848 RID: 14408
		public DateTime m_bannedTime = DateTime.MinValue;
	}
}
