using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004EE RID: 1262
	[CustomLuaClass]
	public class DataSecionRandomEvent : DataSection
	{
		// Token: 0x06004C95 RID: 19605 RVA: 0x00178E44 File Offset: 0x00177044
		public DataSecionRandomEvent()
		{
			this.RandomLevelZone = new Dictionary<int, RandomEventLevelZone>();
			this.RandomEventTimeList = new List<int>();
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x00178E64 File Offset: 0x00177064
		public override void ClearInitedData()
		{
			this.RandomLevelZone.Clear();
			this.RandomEventTimeList.Clear();
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x00178E7C File Offset: 0x0017707C
		public void InitDefiniteLevelZone(RandomEventLevelZone zone)
		{
			this.DefiniteLevelZone = zone;
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x00178E88 File Offset: 0x00177088
		public void InitRandomLevelZone(List<RandomEventLevelZone> zones)
		{
			this.RandomLevelZone.Clear();
			foreach (RandomEventLevelZone randomEventLevelZone in zones)
			{
				this.RandomLevelZone.Add(randomEventLevelZone.LevelZoneId, randomEventLevelZone);
			}
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x00178EF8 File Offset: 0x001770F8
		public void InitGenerateEventTime(List<int> timeList)
		{
			this.RandomEventTimeList = new List<int>(timeList);
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x00178F08 File Offset: 0x00177108
		public void InitGenerateRandomEventTotalCount(int count)
		{
			this.GenerateRandomEventTotalCount = count;
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x00178F14 File Offset: 0x00177114
		public void InitRandomEventTotalCount(int count)
		{
			this.RandomEventTotalCount = count;
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x00178F20 File Offset: 0x00177120
		public void SetDefiniteEventLevelZone(RandomEventLevelZone zone)
		{
			this.DefiniteLevelZone = zone;
			base.SetDirty(true);
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x00178F30 File Offset: 0x00177130
		public void DefiniteGroupGenerateRandomEvent(int groupId)
		{
			RandomEventGroup randomEventGroup;
			if (!this.DefiniteLevelZone.Groups.TryGetValue(groupId, out randomEventGroup))
			{
				return;
			}
			randomEventGroup.Nums++;
			base.SetDirty(true);
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x00178F6C File Offset: 0x0017716C
		public void RandomGroupGenerateRandomEvent(int levelZoneId, int groupId, int maxCount)
		{
			RandomEventLevelZone randomEventLevelZone;
			RandomEventGroup randomEventGroup;
			if (this.RandomLevelZone.TryGetValue(levelZoneId, out randomEventLevelZone))
			{
				if (randomEventLevelZone.Groups.TryGetValue(groupId, out randomEventGroup))
				{
					randomEventGroup.Nums++;
					base.SetDirty(true);
					return;
				}
			}
			else
			{
				randomEventLevelZone = new RandomEventLevelZone();
				randomEventLevelZone.LevelZoneId = levelZoneId;
				this.RandomLevelZone.Add(randomEventLevelZone.LevelZoneId, randomEventLevelZone);
			}
			randomEventGroup = new RandomEventGroup();
			randomEventGroup.Index = groupId;
			randomEventGroup.MaxNums = maxCount;
			randomEventGroup.Nums = 1;
			randomEventLevelZone.Groups.Add(groupId, randomEventGroup);
			base.SetDirty(true);
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x00179008 File Offset: 0x00177208
		public void AddRandomEventLevelZone(int index, RandomEventLevelZone zone)
		{
			if (this.RandomLevelZone.ContainsKey(index))
			{
				return;
			}
			this.RandomLevelZone.Add(index, zone);
			base.SetDirty(true);
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x00179030 File Offset: 0x00177230
		public void SetRandomEventTotalCount(int count)
		{
			this.RandomEventTotalCount = count;
			base.SetDirty(true);
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x00179040 File Offset: 0x00177240
		public void SetRandomEventTimes(List<int> timeList)
		{
			this.RandomEventTimeList = new List<int>(timeList);
			this.RandomEventTimeList.Sort();
			base.SetDirty(true);
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x00179060 File Offset: 0x00177260
		public void SetNextRandomEventFlushTime(DateTime setTime)
		{
			this.NextRandomEventFlushTime = setTime;
			base.SetDirty(true);
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x00179070 File Offset: 0x00177270
		public void SetDefiniteEventMaxCount(int maxCount)
		{
			this.DefiniteEventMaxCount = maxCount;
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x0017907C File Offset: 0x0017727C
		public void AddRandomEventCount(int count = 1)
		{
			this.GenerateRandomEventTotalCount += count;
			base.SetDirty(true);
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x00179094 File Offset: 0x00177294
		public Dictionary<int, RandomEventGroup> GetDefiniteGroupRandomEventGroups()
		{
			if (this.DefiniteLevelZone == null)
			{
				return new Dictionary<int, RandomEventGroup>();
			}
			return this.DefiniteLevelZone.Groups;
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x001790B4 File Offset: 0x001772B4
		public void AddDefiniteGroupRandomEventGroup(RandomEventGroup newGroup)
		{
			RandomEventGroup randomEventGroup;
			if (this.DefiniteLevelZone.Groups.TryGetValue(newGroup.Index, out randomEventGroup))
			{
				randomEventGroup.MaxNums = newGroup.MaxNums;
			}
			else
			{
				this.DefiniteLevelZone.Groups.Add(newGroup.Index, newGroup);
			}
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x00179108 File Offset: 0x00177308
		public Dictionary<int, RandomEventGroup> GetRandomGroupLevelZoneEventGroups(int levelZoneId)
		{
			RandomEventLevelZone randomEventLevelZone;
			if (!this.RandomLevelZone.TryGetValue(levelZoneId, out randomEventLevelZone))
			{
				return new Dictionary<int, RandomEventGroup>();
			}
			return randomEventLevelZone.Groups;
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x00179134 File Offset: 0x00177334
		public void ClearRandomInfo()
		{
			this.RandomLevelZone.Clear();
			this.DefiniteLevelZone = null;
			this.GenerateRandomEventTotalCount = 0;
			this.DefiniteEventMaxCount = 0;
			this.RandomEventTotalCount = 0;
			base.SetDirty(true);
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x00179164 File Offset: 0x00177364
		public void RemoveRandomEventTime(int time)
		{
			this.RandomEventTimeList.Remove(time);
			base.SetDirty(true);
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x0017917C File Offset: 0x0017737C
		public bool IsCompletedRandomEventGenerate()
		{
			return this.RandomEventTotalCount <= this.GenerateRandomEventTotalCount;
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06004CAB RID: 19627 RVA: 0x00179190 File Offset: 0x00177390
		// (set) Token: 0x06004CAC RID: 19628 RVA: 0x00179198 File Offset: 0x00177398
		public int RandomEventTotalCount { get; set; }

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06004CAD RID: 19629 RVA: 0x001791A4 File Offset: 0x001773A4
		// (set) Token: 0x06004CAE RID: 19630 RVA: 0x001791AC File Offset: 0x001773AC
		public int GenerateRandomEventTotalCount { get; set; }

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06004CAF RID: 19631 RVA: 0x001791B8 File Offset: 0x001773B8
		// (set) Token: 0x06004CB0 RID: 19632 RVA: 0x001791C0 File Offset: 0x001773C0
		public int DefiniteEventMaxCount { get; set; }

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06004CB1 RID: 19633 RVA: 0x001791CC File Offset: 0x001773CC
		// (set) Token: 0x06004CB2 RID: 19634 RVA: 0x001791D4 File Offset: 0x001773D4
		public DateTime NextRandomEventFlushTime { get; set; }

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x001791E0 File Offset: 0x001773E0
		// (set) Token: 0x06004CB4 RID: 19636 RVA: 0x001791E8 File Offset: 0x001773E8
		public RandomEventLevelZone DefiniteLevelZone { get; set; }

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06004CB5 RID: 19637 RVA: 0x001791F4 File Offset: 0x001773F4
		// (set) Token: 0x06004CB6 RID: 19638 RVA: 0x001791FC File Offset: 0x001773FC
		public Dictionary<int, RandomEventLevelZone> RandomLevelZone { get; set; }

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06004CB7 RID: 19639 RVA: 0x00179208 File Offset: 0x00177408
		// (set) Token: 0x06004CB8 RID: 19640 RVA: 0x00179210 File Offset: 0x00177410
		public List<int> RandomEventTimeList { get; set; }
	}
}
