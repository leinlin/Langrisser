using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200057A RID: 1402
	[CustomLuaClass]
	public class Survey
	{
		// Token: 0x06005150 RID: 20816 RVA: 0x00183330 File Offset: 0x00181530
		public Survey()
		{
			this.Status = SurveyStatus.Locking;
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06005151 RID: 20817 RVA: 0x00183340 File Offset: 0x00181540
		// (set) Token: 0x06005152 RID: 20818 RVA: 0x00183348 File Offset: 0x00181548
		public int Id { get; set; }

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06005153 RID: 20819 RVA: 0x00183354 File Offset: 0x00181554
		// (set) Token: 0x06005154 RID: 20820 RVA: 0x0018335C File Offset: 0x0018155C
		public SurveyStatus Status { get; set; }

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06005155 RID: 20821 RVA: 0x00183368 File Offset: 0x00181568
		// (set) Token: 0x06005156 RID: 20822 RVA: 0x00183370 File Offset: 0x00181570
		public DateTime StartTime { get; set; }

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06005157 RID: 20823 RVA: 0x0018337C File Offset: 0x0018157C
		// (set) Token: 0x06005158 RID: 20824 RVA: 0x00183384 File Offset: 0x00181584
		public DateTime EndTime { get; set; }

		// Token: 0x06005159 RID: 20825 RVA: 0x00183390 File Offset: 0x00181590
		public static ProSurvey ToPBSurvey(Survey survey)
		{
			if (survey == null)
			{
				return null;
			}
			return new ProSurvey
			{
				Id = survey.Id,
				StartTime = survey.StartTime.Ticks,
				EndTime = survey.EndTime.Ticks,
				Status = (int)survey.Status
			};
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x001833EC File Offset: 0x001815EC
		public static Survey ToSurvey(ProSurvey pbSurvey)
		{
			if (pbSurvey == null)
			{
				return null;
			}
			return new Survey
			{
				Id = pbSurvey.Id,
				StartTime = new DateTime(pbSurvey.StartTime),
				EndTime = new DateTime(pbSurvey.EndTime),
				Status = (SurveyStatus)pbSurvey.Status
			};
		}
	}
}
