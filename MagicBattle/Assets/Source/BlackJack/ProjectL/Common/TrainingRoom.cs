using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200041B RID: 1051
	[CustomLuaClass]
	public class TrainingRoom
	{
		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x00114140 File Offset: 0x00112340
		// (set) Token: 0x06003D18 RID: 15640 RVA: 0x00114148 File Offset: 0x00112348
		public int ConfigId { get; set; }

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06003D19 RID: 15641 RVA: 0x00114154 File Offset: 0x00112354
		public int AnikiGymLevelRequired
		{
			get
			{
				return this.Config.LevelToUnlock;
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x00114164 File Offset: 0x00112364
		private List<int> TotalLevelupExpSteps
		{
			get
			{
				return this.Config.m_totalLevelupExpSteps;
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06003D1B RID: 15643 RVA: 0x00114174 File Offset: 0x00112374
		// (set) Token: 0x06003D1C RID: 15644 RVA: 0x0011417C File Offset: 0x0011237C
		public TrainingGround WhichTrainingGround { get; set; }

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06003D1D RID: 15645 RVA: 0x00114188 File Offset: 0x00112388
		public ConfigDataTrainingRoomInfo Config
		{
			get
			{
				return this.ConfigDataLoader.GetConfigDataTrainingRoomInfo(this.ConfigId);
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06003D1E RID: 15646 RVA: 0x0011419C File Offset: 0x0011239C
		// (set) Token: 0x06003D1F RID: 15647 RVA: 0x001141A4 File Offset: 0x001123A4
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

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x001141C0 File Offset: 0x001123C0
		public int Level
		{
			get
			{
				int num = this.TotalLevelupExpSteps.BinarySearch(this.TotalExp);
				if (num < 0)
				{
					return Math.Min(this.TotalLevelupExpSteps.Count, ~num);
				}
				return Math.Min(this.TotalLevelupExpSteps.Count, num) + 1;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06003D21 RID: 15649 RVA: 0x0011420C File Offset: 0x0011240C
		public int TotalExp
		{
			get
			{
				List<TrainingTech> availableTechs = this.WhichTrainingGround.GetAvailableTechs();
				int num = 0;
				foreach (TrainingCourse trainingCourse in this.Courses)
				{
					using (List<TrainingTech>.Enumerator enumerator2 = trainingCourse.Techs.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							TrainingTech Tech = enumerator2.Current;
							TrainingTech trainingTech = availableTechs.Find((TrainingTech at) => at.ConfigId == Tech.ConfigId);
							if (trainingTech != null)
							{
								for (int i = 0; i < trainingTech.Level; i++)
								{
									num += trainingTech.Infos[i].RoomExp;
								}
							}
						}
					}
				}
				return num;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06003D22 RID: 15650 RVA: 0x00114310 File Offset: 0x00112510
		public int Exp
		{
			get
			{
				return this.TotalExp - this.TotalLevelupExpSteps[Math.Min(this.Level - 1, this.TotalLevelupExpSteps.Count - 1)];
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06003D23 RID: 15651 RVA: 0x00114340 File Offset: 0x00112540
		public bool Locked
		{
			get
			{
				return this.AnikiGymLevelRequired != 0 && !this.WhichTrainingGround.IsAnikiGymLevelCleared(this.AnikiGymLevelRequired);
			}
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x0011436C File Offset: 0x0011256C
		public void ReloadConfigData()
		{
			List<int> list = new List<int>();
			for (int i = this.Courses.Count - 1; i >= 0; i--)
			{
				if (this.ConfigDataLoader.GetConfigDataTrainingCourseInfo(this.Courses[i].ConfigId) == null)
				{
					list.Add(i);
				}
			}
			foreach (int index in list)
			{
				this.Courses.RemoveAt(index);
			}
			IEnumerable<KeyValuePair<int, ConfigDataTrainingCourseInfo>> allConfigDataTrainingCourseInfo = this.ConfigDataLoader.GetAllConfigDataTrainingCourseInfo();
			using (IEnumerator<KeyValuePair<int, ConfigDataTrainingCourseInfo>> enumerator2 = allConfigDataTrainingCourseInfo.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<int, ConfigDataTrainingCourseInfo> kv = enumerator2.Current;
					if (kv.Value.RoomID == this.ConfigId)
					{
						TrainingCourse trainingCourse = this.Courses.Find((TrainingCourse c) => c.ConfigId == kv.Value.ID);
						if (trainingCourse == null)
						{
							trainingCourse = new TrainingCourse
							{
								ConfigId = kv.Value.ID
							};
							this.Courses.Add(trainingCourse);
						}
						trainingCourse.ConfigDataLoader = this.ConfigDataLoader;
						trainingCourse.WhichRoom = this;
					}
				}
			}
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x001144FC File Offset: 0x001126FC
		public void UpdateInstantiatedData(List<TrainingTech> AvailableTechs)
		{
			foreach (TrainingCourse trainingCourse in this.Courses)
			{
				trainingCourse.UpdateInstantiatedData(AvailableTechs);
			}
		}

		// Token: 0x04002E3B RID: 11835
		public List<TrainingCourse> Courses = new List<TrainingCourse>();

		// Token: 0x04002E3D RID: 11837
		private IConfigDataLoader _ConfigDataLoader;
	}
}
