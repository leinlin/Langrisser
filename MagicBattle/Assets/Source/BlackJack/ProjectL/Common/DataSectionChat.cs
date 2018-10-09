using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004C3 RID: 1219
	[CustomLuaClass]
	public class DataSectionChat : DataSection
	{
		// Token: 0x06004AA5 RID: 19109 RVA: 0x001748CC File Offset: 0x00172ACC
		public DataSectionChat()
		{
			this.m_bannedTime = DateTime.MinValue;
			this.m_silentlyBannedTime = DateTime.MinValue;
			this.LastWorldChannelChatSendTime = DateTime.MinValue;
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x001748F8 File Offset: 0x00172AF8
		public override object SerializeToClient()
		{
			return new DSChatNtf
			{
				Version = (uint)base.Version,
				BannedTime = this.m_bannedTime.Ticks
			};
		}

		// Token: 0x06004AA7 RID: 19111 RVA: 0x0017492C File Offset: 0x00172B2C
		public void InitBannedTime(long bannedTime)
		{
			this.m_bannedTime = new DateTime(bannedTime);
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x0017493C File Offset: 0x00172B3C
		public bool IsBanned(DateTime currentTime)
		{
			return this.m_bannedTime != DateTime.MinValue && this.m_bannedTime >= currentTime;
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x00174964 File Offset: 0x00172B64
		public bool IsBannedTimeExpired(DateTime current)
		{
			return this.m_bannedTime != DateTime.MinValue && this.m_bannedTime < current;
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x0017498C File Offset: 0x00172B8C
		public void Ban(DateTime bannedTime)
		{
			this.m_bannedTime = bannedTime;
			base.SetDirty(true);
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x0017499C File Offset: 0x00172B9C
		public void Unban()
		{
			this.m_bannedTime = DateTime.MinValue;
			base.SetDirty(true);
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x001749B0 File Offset: 0x00172BB0
		public void InitSilentBannedTime(long bannedTime)
		{
			this.m_silentlyBannedTime = new DateTime(bannedTime);
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x001749C0 File Offset: 0x00172BC0
		public bool IsSilentlyBanned(DateTime currentTime)
		{
			return this.m_silentlyBannedTime != DateTime.MinValue && this.m_silentlyBannedTime >= currentTime;
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x001749E8 File Offset: 0x00172BE8
		public bool IsSilentBannedTimeExpired(DateTime current)
		{
			return this.m_silentlyBannedTime != DateTime.MinValue && this.m_silentlyBannedTime < current;
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x00174A10 File Offset: 0x00172C10
		public void SilentBan(DateTime bannedTime)
		{
			this.m_silentlyBannedTime = bannedTime;
			base.SetDirty(true);
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x00174A20 File Offset: 0x00172C20
		public void SilentUnban()
		{
			this.m_silentlyBannedTime = DateTime.MinValue;
			base.SetDirty(true);
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x00174A34 File Offset: 0x00172C34
		public bool CanSendWorldChatByTime(int intervalTime, DateTime currentTime)
		{
			return this.LastWorldChannelChatSendTime == DateTime.MinValue || (this.LastWorldChannelChatSendTime != DateTime.MinValue && this.LastWorldChannelChatSendTime.AddSeconds((double)intervalTime) <= currentTime);
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06004AB2 RID: 19122 RVA: 0x00174A88 File Offset: 0x00172C88
		// (set) Token: 0x06004AB3 RID: 19123 RVA: 0x00174A90 File Offset: 0x00172C90
		public DateTime m_bannedTime { get; private set; }

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06004AB4 RID: 19124 RVA: 0x00174A9C File Offset: 0x00172C9C
		// (set) Token: 0x06004AB5 RID: 19125 RVA: 0x00174AA4 File Offset: 0x00172CA4
		public DateTime m_silentlyBannedTime { get; private set; }

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06004AB6 RID: 19126 RVA: 0x00174AB0 File Offset: 0x00172CB0
		// (set) Token: 0x06004AB7 RID: 19127 RVA: 0x00174AB8 File Offset: 0x00172CB8
		public DateTime LastWorldChannelChatSendTime { get; set; }
	}
}
