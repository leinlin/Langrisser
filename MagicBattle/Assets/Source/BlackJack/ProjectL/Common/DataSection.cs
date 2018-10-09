using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004C1 RID: 1217
	[CustomLuaClass]
	[Serializable]
	public class DataSection
	{
		// Token: 0x06004A72 RID: 19058 RVA: 0x00174308 File Offset: 0x00172508
		public void InitVersion(ushort dbVersion, ushort clientVersion)
		{
			this.m_dbVersion = dbVersion;
			this.m_dbVersion = ((this.m_dbVersion != 0) ? this.m_dbVersion : 1);
			this.m_clientVersion = clientVersion;
			this.m_clientVersion = ((this.m_clientVersion != 0) ? this.m_clientVersion : 1);
			this.m_dbCommitedVersion = this.m_dbVersion;
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x0017436C File Offset: 0x0017256C
		public void SetDirty(bool needCommit2Client = true)
		{
			this.m_dbVersion += 1;
			this.m_dbVersion = ((this.m_dbVersion != 0) ? this.m_dbVersion : 1);
			if (needCommit2Client)
			{
				this.m_clientVersion += 1;
				this.m_clientVersion = ((this.m_clientVersion != 0) ? this.m_clientVersion : 1);
			}
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x001743D8 File Offset: 0x001725D8
		public bool NeedSyncToDB()
		{
			return this.m_dbCommitedVersion != this.m_dbVersion;
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x001743EC File Offset: 0x001725EC
		public void OnDBSynced()
		{
			this.m_dbCommitedVersion = this.m_dbVersion;
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x001743FC File Offset: 0x001725FC
		public void SetClientCommitedVersion(ushort version)
		{
			this.m_clientCommitedVersion = version;
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x00174408 File Offset: 0x00172608
		public bool NeedSyncToClient()
		{
			return this.m_clientCommitedVersion != this.m_clientVersion;
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x0017441C File Offset: 0x0017261C
		public void OnClientSynced()
		{
			this.m_clientCommitedVersion = this.m_clientVersion;
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x0017442C File Offset: 0x0017262C
		public virtual object SerializeToClient()
		{
			return null;
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x00174430 File Offset: 0x00172630
		public virtual void ClearInitedData()
		{
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06004A7B RID: 19067 RVA: 0x00174434 File Offset: 0x00172634
		public ushort Version
		{
			get
			{
				return this.m_dbVersion;
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x0017443C File Offset: 0x0017263C
		public ushort ClientVersion
		{
			get
			{
				return this.m_clientVersion;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06004A7D RID: 19069 RVA: 0x00174444 File Offset: 0x00172644
		public ushort ClientCommitedVersion
		{
			get
			{
				return this.m_clientCommitedVersion;
			}
		}

		// Token: 0x0400382A RID: 14378
		protected ushort m_dbVersion = 1;

		// Token: 0x0400382B RID: 14379
		protected ushort m_clientVersion = 1;

		// Token: 0x0400382C RID: 14380
		protected ushort m_dbCommitedVersion = 1;

		// Token: 0x0400382D RID: 14381
		protected ushort m_clientCommitedVersion = 1;
	}
}
