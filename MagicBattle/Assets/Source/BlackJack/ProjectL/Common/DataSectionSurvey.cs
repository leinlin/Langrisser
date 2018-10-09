using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004FB RID: 1275
	[CustomLuaClass]
	public class DataSectionSurvey : DataSection
	{
		// Token: 0x06004D4E RID: 19790 RVA: 0x0017A650 File Offset: 0x00178850
		public SurveyStatus GetCurrentSurveyStatus()
		{
			if (this.m_currentSurvey == null)
			{
				return SurveyStatus.Expired;
			}
			return this.m_currentSurvey.Status;
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x0017A66C File Offset: 0x0017886C
		public void SetSurveyStatus(SurveyStatus status)
		{
			this.m_currentSurvey.Status = status;
			base.SetDirty(true);
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x0017A684 File Offset: 0x00178884
		public void SetCurrentSurvey(Survey survey)
		{
			this.m_currentSurvey = survey;
			base.SetDirty(true);
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x0017A694 File Offset: 0x00178894
		public void InitCurrentSurvey(Survey survey)
		{
			this.m_currentSurvey = survey;
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x0017A6A0 File Offset: 0x001788A0
		public override object SerializeToClient()
		{
			return new DSSurveyNtf
			{
				Version = (uint)base.Version,
				Survey = Survey.ToPBSurvey(this.m_currentSurvey)
			};
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x0017A6D4 File Offset: 0x001788D4
		public Survey GetCurrentSurvey()
		{
			return this.m_currentSurvey;
		}

		// Token: 0x040038E3 RID: 14563
		private Survey m_currentSurvey;
	}
}
