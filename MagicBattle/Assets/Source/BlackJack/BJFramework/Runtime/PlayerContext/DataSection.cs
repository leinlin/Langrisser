using System;
using System.Runtime.Serialization;

namespace BlackJack.BJFramework.Runtime.PlayerContext
{
	// Token: 0x0200006E RID: 110
	[Serializable]
	public class DataSection
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x00017838 File Offset: 0x00015A38
		public void InitWithPersistentVersion(ushort version)
		{
			this.m_persistentVersion = version;
			this.m_version = this.m_persistentVersion;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00017850 File Offset: 0x00015A50
		public void SetVersion(ushort version)
		{
			this.m_version = version;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0001785C File Offset: 0x00015A5C
		public bool NeedFlushPersistent()
		{
			return this.m_persistentVersion != this.m_version;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00017870 File Offset: 0x00015A70
		public void OnFlushed()
		{
			this.m_persistentVersion = this.m_version;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00017880 File Offset: 0x00015A80
		public ushort Version
		{
			get
			{
				return this.m_version;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00017888 File Offset: 0x00015A88
		public ushort PersistentVersion
		{
			get
			{
				return this.m_persistentVersion;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00017890 File Offset: 0x00015A90
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			this.InitWithPersistentVersion(this.m_persistentVersion);
		}

		// Token: 0x04000286 RID: 646
		[NonSerialized]
		protected ushort m_version;

		// Token: 0x04000287 RID: 647
		protected ushort m_persistentVersion;
	}
}
