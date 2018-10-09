using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004FE RID: 1278
	[CustomLuaClass]
	public class DataSectionTrainingGround : DataSection
	{
		// Token: 0x06004D76 RID: 19830 RVA: 0x0017AAA0 File Offset: 0x00178CA0
		public override void ClearInitedData()
		{
			this.TrainingGround = new TrainingGround
			{
				ConfigDataLoader = this.TrainingGround.ConfigDataLoader,
				IsAnikiGymLevelCleared = this.TrainingGround.IsAnikiGymLevelCleared
			};
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x0017AADC File Offset: 0x00178CDC
		public override object SerializeToClient()
		{
			DSTrainingGroundNtf dstrainingGroundNtf = new DSTrainingGroundNtf();
			dstrainingGroundNtf.Version = (uint)base.Version;
			foreach (TrainingTech trainingTech in this.TrainingGround.IterateAvailableTechs())
			{
				dstrainingGroundNtf.AvailableTechs.Add(trainingTech.ToPro());
			}
			return dstrainingGroundNtf;
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x0017AB58 File Offset: 0x00178D58
		public void UpdateInstantiatedData(DSTrainingGroundNtf DS)
		{
			List<TrainingTech> list = new List<TrainingTech>();
			foreach (ProTrainingTech tech in DS.AvailableTechs)
			{
				list.Add(TrainingTech.FromDataSection(tech));
			}
			IEnumerable<KeyValuePair<int, ConfigDataTrainingCourseInfo>> allConfigDataTrainingCourseInfo = this.TrainingGround.ConfigDataLoader.GetAllConfigDataTrainingCourseInfo();
			foreach (KeyValuePair<int, ConfigDataTrainingCourseInfo> keyValuePair in allConfigDataTrainingCourseInfo)
			{
				foreach (int configId in keyValuePair.Value.Techs)
				{
					this.TrainingGround.AddNewLearntTech(new TrainingTech
					{
						ConfigDataLoader = this.TrainingGround.ConfigDataLoader,
						ConfigId = configId,
						Level = 0
					});
				}
			}
			this.TrainingGround.UpdateInstantiatedData(list);
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x0017ACA4 File Offset: 0x00178EA4
		public TrainingRoom GetRoom(int RoomId)
		{
			return this.TrainingGround.GetRoom(RoomId);
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x0017ACB4 File Offset: 0x00178EB4
		public TrainingTech GetTech(int TechId)
		{
			TrainingTech trainingTech = this.TrainingGround.GetLearntTech(TechId);
			if (trainingTech == null)
			{
				trainingTech = this.TrainingGround.GetUnlearntTech(TechId);
				this.TrainingGround.AddNewLearntTech(trainingTech);
			}
			return trainingTech;
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x0017ACF0 File Offset: 0x00178EF0
		public void UpdateTechLevel(int TechId, int Level)
		{
			TrainingTech tech = this.GetTech(TechId);
			tech.Level = Level;
			base.SetDirty(true);
		}

		// Token: 0x040038ED RID: 14573
		public TrainingGround TrainingGround = new TrainingGround();
	}
}
