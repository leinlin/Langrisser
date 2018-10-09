using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200041E RID: 1054
	[CustomLuaClass]
	public class TrainingCourse
	{
		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06003D2B RID: 15659 RVA: 0x001145B0 File Offset: 0x001127B0
		// (set) Token: 0x06003D2C RID: 15660 RVA: 0x001145B8 File Offset: 0x001127B8
		public int ConfigId { get; set; }

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06003D2D RID: 15661 RVA: 0x001145C4 File Offset: 0x001127C4
		public int RoomLevelRequired
		{
			get
			{
				return this.Config.RoomLevel;
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06003D2E RID: 15662 RVA: 0x001145D4 File Offset: 0x001127D4
		// (set) Token: 0x06003D2F RID: 15663 RVA: 0x001145DC File Offset: 0x001127DC
		public TrainingRoom WhichRoom { get; set; }

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06003D30 RID: 15664 RVA: 0x001145E8 File Offset: 0x001127E8
		public ConfigDataTrainingCourseInfo Config
		{
			get
			{
				return this.ConfigDataLoader.GetConfigDataTrainingCourseInfo(this.ConfigId);
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06003D31 RID: 15665 RVA: 0x001145FC File Offset: 0x001127FC
		// (set) Token: 0x06003D32 RID: 15666 RVA: 0x00114604 File Offset: 0x00112804
		public IConfigDataLoader ConfigDataLoader
		{
			get
			{
				return this._ConfigDataLoader;
			}
			set
			{
				if (value != this._ConfigDataLoader)
				{
					this._ConfigDataLoader = value;
					this.ReloadConfigData();
				}
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06003D33 RID: 15667 RVA: 0x00114620 File Offset: 0x00112820
		public bool Locked
		{
			get
			{
				return this.WhichRoom.Level < this.RoomLevelRequired;
			}
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00114638 File Offset: 0x00112838
		public void ReloadConfigData()
		{
			List<int> list = new List<int>();
			for (int i = this.Techs.Count - 1; i >= 0; i--)
			{
				if (this.ConfigDataLoader.GetConfigDataTrainingCourseInfo(this.Techs[i].ConfigId) == null)
				{
					list.Add(i);
				}
			}
			foreach (int index in list)
			{
				this.Techs.RemoveAt(index);
			}
			using (List<int>.Enumerator enumerator2 = this.Config.Techs.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					int TechId = enumerator2.Current;
					if (this.ConfigDataLoader.GetConfigDataTrainingTechInfo(TechId) != null)
					{
						TrainingTech trainingTech = this.Techs.Find((TrainingTech t) => t.ConfigId == TechId);
						if (trainingTech != null)
						{
							trainingTech.ConfigDataLoader = this.ConfigDataLoader;
						}
					}
				}
			}
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00114788 File Offset: 0x00112988
		public void UpdateInstantiatedData(List<TrainingTech> AvailableTechs)
		{
			using (List<TrainingTech>.Enumerator enumerator = AvailableTechs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TrainingTech AT = enumerator.Current;
					if (this.Config.Techs.FindIndex((int t) => t == AT.ConfigId) >= 0 && this.Techs.Find((TrainingTech t) => t.ConfigId == AT.ConfigId) == null)
					{
						this.WhichRoom.WhichTrainingGround.AddNewLearntTech(new TrainingTech
						{
							ConfigId = AT.ConfigId,
							Level = AT.Level,
							ConfigDataLoader = this.ConfigDataLoader
						});
					}
				}
			}
			foreach (TrainingTech trainingTech in this.Techs)
			{
				trainingTech.UpdateInstantiatedData(AvailableTechs);
			}
		}

		// Token: 0x04002E41 RID: 11841
		public List<TrainingTech> Techs = new List<TrainingTech>();

		// Token: 0x04002E43 RID: 11843
		private IConfigDataLoader _ConfigDataLoader;
	}
}
