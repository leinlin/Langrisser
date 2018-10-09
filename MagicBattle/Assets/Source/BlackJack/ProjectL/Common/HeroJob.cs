using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000404 RID: 1028
	[CustomLuaClass]
	public class HeroJob
	{
		// Token: 0x06003C35 RID: 15413 RVA: 0x00111A2C File Offset: 0x0010FC2C
		public HeroJob()
		{
			this.m_jobRelatedId = 0;
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x00111A48 File Offset: 0x0010FC48
		public HeroJob(HeroJob other)
		{
			this.JobRelatedId = other.JobRelatedId;
			this.JobLevel = other.JobLevel;
			this.ModelSkinId = other.ModelSkinId;
			foreach (int item in other.Achievements)
			{
				this.Achievements.Add(item);
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06003C38 RID: 15416 RVA: 0x00111AF0 File Offset: 0x0010FCF0
		// (set) Token: 0x06003C37 RID: 15415 RVA: 0x00111AE0 File Offset: 0x0010FCE0
		public int JobRelatedId
		{
			get
			{
				return this.m_jobRelatedId;
			}
			set
			{
				this.m_jobRelatedId = value;
				this.UpdateJobConnectionInfo();
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x00111AF8 File Offset: 0x0010FCF8
		// (set) Token: 0x06003C3A RID: 15418 RVA: 0x00111B00 File Offset: 0x0010FD00
		public int JobLevel { get; set; }

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x00111B0C File Offset: 0x0010FD0C
		// (set) Token: 0x06003C3C RID: 15420 RVA: 0x00111B14 File Offset: 0x0010FD14
		public int ModelSkinId { get; set; }

		// Token: 0x06003C3D RID: 15421 RVA: 0x00111B20 File Offset: 0x0010FD20
		public static ProHeroJob HeroJobToPBHeroJob(HeroJob heroJob)
		{
			ProHeroJob proHeroJob = new ProHeroJob();
			proHeroJob.JobRelatedId = heroJob.JobRelatedId;
			proHeroJob.JobLevel = heroJob.JobLevel;
			proHeroJob.ModelSkinId = heroJob.ModelSkinId;
			proHeroJob.Achievements.AddRange(heroJob.Achievements);
			return proHeroJob;
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x00111B6C File Offset: 0x0010FD6C
		public static HeroJob PbHeroJobToHeroJob(ProHeroJob pbHeroJob)
		{
			HeroJob heroJob = new HeroJob();
			heroJob.JobRelatedId = pbHeroJob.JobRelatedId;
			heroJob.JobLevel = pbHeroJob.JobLevel;
			heroJob.ModelSkinId = pbHeroJob.ModelSkinId;
			foreach (int item in pbHeroJob.Achievements)
			{
				heroJob.Achievements.Add(item);
			}
			return heroJob;
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x00111BFC File Offset: 0x0010FDFC
		private void UpdateJobConnectionInfo()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.JobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(this.JobRelatedId);
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x00111C38 File Offset: 0x0010FE38
		// (set) Token: 0x06003C40 RID: 15424 RVA: 0x00111C2C File Offset: 0x0010FE2C
		public ConfigDataJobConnectionInfo JobConnectionInfo { get; private set; }

		// Token: 0x06003C42 RID: 15426 RVA: 0x00111C40 File Offset: 0x0010FE40
		public bool IsLevelMax()
		{
			return this.IsLevelMax(this.JobLevel);
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x00111C50 File Offset: 0x0010FE50
		public bool IsLevelMax(int jobLevel)
		{
			return this.JobConnectionInfo.IsJobLevelMax(jobLevel);
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x00111C60 File Offset: 0x0010FE60
		public ConfigDataModelSkinResourceInfo GetModelSkinResourceInfo()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			return BattleUtility.GetHeroModelSkinResourceInfo(configDataLoader, this.ModelSkinId, this.m_jobRelatedId);
		}

		// Token: 0x04002DDC RID: 11740
		private int m_jobRelatedId;

		// Token: 0x04002DDE RID: 11742
		public HashSet<int> Achievements = new HashSet<int>();
	}
}
