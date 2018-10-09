using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000422 RID: 1058
	public static class TrainingGroundExtension
	{
		// Token: 0x06003D48 RID: 15688 RVA: 0x00114A08 File Offset: 0x00112C08
		public static ProTrainingTech ToPro(this TrainingTech Tech)
		{
			return new ProTrainingTech
			{
				ConfigId = Tech.ConfigId,
				Level = Tech.Level
			};
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x00114A34 File Offset: 0x00112C34
		public static IEnumerable<TrainingTechInfo> IterateAvailableTechInfos(this TrainingGround TG)
		{
			foreach (TrainingRoom Room in TG.Rooms)
			{
				foreach (TrainingCourse Course in Room.Courses)
				{
					foreach (TrainingTech t in Course.Techs)
					{
						if (t.Level > 0)
						{
							yield return t.Infos[t.Level - 1];
						}
					}
				}
			}
			yield break;
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x00114A58 File Offset: 0x00112C58
		public static int GetTechLevel(this TrainingGround TG, int TechId)
		{
			TrainingTech learntTech = TG.GetLearntTech(TechId);
			return (learntTech != null) ? 0 : learntTech.Level;
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x00114A80 File Offset: 0x00112C80
		public static int GetTechLevelBySoldierId(this TrainingGround TG, int SoldierId)
		{
			return 0;
		}
	}
}
