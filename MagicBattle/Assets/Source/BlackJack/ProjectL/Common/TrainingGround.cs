using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000415 RID: 1045
	[CustomLuaClass]
	public class TrainingGround
	{
		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06003CFA RID: 15610 RVA: 0x00113924 File Offset: 0x00111B24
		// (set) Token: 0x06003CFB RID: 15611 RVA: 0x0011392C File Offset: 0x00111B2C
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

		// Token: 0x06003CFC RID: 15612 RVA: 0x00113948 File Offset: 0x00111B48
		public void ReloadConfigData()
		{
			List<int> list = new List<int>();
			for (int i = this.Rooms.Count - 1; i >= 0; i--)
			{
				if (this.ConfigDataLoader.GetConfigDataTrainingRoomInfo(this.Rooms[i].ConfigId) == null)
				{
					list.Add(i);
				}
			}
			foreach (int index in list)
			{
				this.Rooms.RemoveAt(index);
			}
			IEnumerable<KeyValuePair<int, ConfigDataTrainingRoomInfo>> allConfigDataTrainingRoomInfo = this.ConfigDataLoader.GetAllConfigDataTrainingRoomInfo();
			using (IEnumerator<KeyValuePair<int, ConfigDataTrainingRoomInfo>> enumerator2 = allConfigDataTrainingRoomInfo.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					KeyValuePair<int, ConfigDataTrainingRoomInfo> kv = enumerator2.Current;
					TrainingRoom trainingRoom = this.Rooms.Find((TrainingRoom r) => r.ConfigId == kv.Value.ID);
					if (trainingRoom == null)
					{
						trainingRoom = new TrainingRoom
						{
							ConfigId = kv.Value.ID
						};
						this.Rooms.Add(trainingRoom);
					}
					trainingRoom.ConfigDataLoader = this.ConfigDataLoader;
					trainingRoom.WhichTrainingGround = this;
				}
			}
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x00113AB8 File Offset: 0x00111CB8
		public void UpdateInstantiatedData(List<TrainingTech> AvailableTechs)
		{
			foreach (TrainingRoom trainingRoom in this.Rooms)
			{
				trainingRoom.UpdateInstantiatedData(AvailableTechs);
			}
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x00113B14 File Offset: 0x00111D14
		public TrainingRoom GetRoom(int RoomId)
		{
			return this.Rooms.Find((TrainingRoom r) => r.ConfigId == RoomId);
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x00113B48 File Offset: 0x00111D48
		public TrainingTech GetLearntTech(int TechId)
		{
			foreach (TrainingRoom trainingRoom in this.Rooms)
			{
				foreach (TrainingCourse trainingCourse in trainingRoom.Courses)
				{
					TrainingTech trainingTech = trainingCourse.Techs.Find((TrainingTech t) => t.ConfigId == TechId);
					if (trainingTech != null)
					{
						return trainingTech;
					}
				}
			}
			return null;
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00113C1C File Offset: 0x00111E1C
		public TrainingTech GetUnlearntTech(int TechId)
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = this.ConfigDataLoader.GetConfigDataTrainingTechInfo(TechId);
			return new TrainingTech
			{
				ConfigDataLoader = this.ConfigDataLoader,
				ConfigId = configDataTrainingTechInfo.ID,
				Level = 0
			};
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00113C5C File Offset: 0x00111E5C
		public List<TrainingTech> GetAvailableTechs()
		{
			List<TrainingTech> list = new List<TrainingTech>();
			foreach (TrainingTech item in this.IterateAvailableTechs())
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00113CBC File Offset: 0x00111EBC
		public IEnumerable<TrainingTech> IterateAvailableTechs()
		{
			foreach (TrainingRoom Room in this.Rooms)
			{
				foreach (TrainingCourse Course in Room.Courses)
				{
					foreach (TrainingTech t in Course.Techs)
					{
						if (t.Level > 0)
						{
							yield return t;
						}
					}
				}
			}
			yield break;
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00113CE0 File Offset: 0x00111EE0
		public void AddNewLearntTech(TrainingTech Tech)
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = this.ConfigDataLoader.GetConfigDataTrainingTechInfo(Tech.ConfigId);
			ConfigDataTrainingCourseInfo CourseConfig = this.ConfigDataLoader.GetConfigDataTrainingCourseInfo(configDataTrainingTechInfo.m_courseId);
			ConfigDataTrainingRoomInfo RoomConfig = this.ConfigDataLoader.GetConfigDataTrainingRoomInfo(CourseConfig.RoomID);
			TrainingCourse trainingCourse = this.Rooms.Find((TrainingRoom r) => r.ConfigId == RoomConfig.ID).Courses.Find((TrainingCourse c) => c.ConfigId == CourseConfig.ID);
			trainingCourse.Techs.RemoveAll((TrainingTech t) => t.ConfigId == Tech.ConfigId);
			trainingCourse.Techs.Add(Tech);
		}

		// Token: 0x04002E27 RID: 11815
		public AnikiGymLevelClearCheck IsAnikiGymLevelCleared;

		// Token: 0x04002E28 RID: 11816
		public List<TrainingRoom> Rooms = new List<TrainingRoom>();

		// Token: 0x04002E29 RID: 11817
		private IConfigDataLoader _ConfigDataLoader;
	}
}
