using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004E2 RID: 1250
	[CustomLuaClass]
	public class DataSectionLevel : DataSection
	{
		// Token: 0x06004BD2 RID: 19410 RVA: 0x0017750C File Offset: 0x0017570C
		public DataSectionLevel()
		{
			this.CanMoveWayPointIds = new Dictionary<int, WayPointStatus>();
			this.RandomEvents = new List<RandomEvent>();
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x0017752C File Offset: 0x0017572C
		public override void ClearInitedData()
		{
			this.CanMoveWayPointIds.Clear();
			this.RandomEvents.Clear();
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00177544 File Offset: 0x00175744
		public override object SerializeToClient()
		{
			DSLevelNtf dslevelNtf = new DSLevelNtf();
			dslevelNtf.Version = (uint)base.Version;
			dslevelNtf.CurrentWayPointId = this.CurrentWayPointId;
			dslevelNtf.ScenarioId = this.LastFinishedScenarioId;
			foreach (KeyValuePair<int, WayPointStatus> keyValuePair in this.CanMoveWayPointIds)
			{
				if (this.IsWayPointArrived(keyValuePair.Key))
				{
					dslevelNtf.ArrivedWayPointIds.Add(keyValuePair.Key);
				}
			}
			dslevelNtf.RandomEvents.AddRange(RandomEvent.RandomEventsToPBRandomEvents(this.RandomEvents));
			return dslevelNtf;
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x00177600 File Offset: 0x00175800
		public void SetScenario(int id)
		{
			this.LastFinishedScenarioId = id;
			base.SetDirty(true);
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x00177610 File Offset: 0x00175810
		public void InitScenario(int id)
		{
			this.LastFinishedScenarioId = id;
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x0017761C File Offset: 0x0017581C
		public void SetCurrentWayPoint(int wayPointId)
		{
			this.CurrentWayPointId = wayPointId;
			base.SetDirty(true);
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x0017762C File Offset: 0x0017582C
		public void InitCurrentWayPoint(int wayPointId)
		{
			this.CurrentWayPointId = wayPointId;
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x00177638 File Offset: 0x00175838
		public void SetArrivedWayPointId(int wayPointId)
		{
			this.CanMoveWayPointIds[wayPointId] = WayPointStatus.Arrived;
			base.SetDirty(true);
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x00177650 File Offset: 0x00175850
		public void SetRandomEvent(int wayPointId)
		{
			Dictionary<int, WayPointStatus> canMoveWayPointIds;
			(canMoveWayPointIds = this.CanMoveWayPointIds)[wayPointId] = (canMoveWayPointIds[wayPointId] | WayPointStatus.RandomEvent);
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x00177678 File Offset: 0x00175878
		public void CleanWayPointEvent(int wayPointId)
		{
			this.CanMoveWayPointIds[wayPointId] = WayPointStatus.Arrived;
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x00177688 File Offset: 0x00175888
		public void SetWayPointStatus(int wayPointId, WayPointStatus status)
		{
			this.CanMoveWayPointIds[wayPointId] = status;
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x00177698 File Offset: 0x00175898
		public bool IsSetRandomEvent(int wayPointId)
		{
			return (this.CanMoveWayPointIds[wayPointId] & WayPointStatus.RandomEvent) != WayPointStatus.None;
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x001776B0 File Offset: 0x001758B0
		public bool IsExistRandomEvent()
		{
			return this.RandomEvents.Count != 0;
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x001776C4 File Offset: 0x001758C4
		public void AddCanMoveWayPointId(int wayPointId, WayPointStatus eventStatus)
		{
			if (!this.CanMoveWayPointIds.ContainsKey(wayPointId))
			{
				this.CanMoveWayPointIds.Add(wayPointId, WayPointStatus.Public | eventStatus);
			}
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x001776E8 File Offset: 0x001758E8
		public void AddArrivedWayPoint(int wayPointId)
		{
			this.CanMoveWayPointIds.Add(wayPointId, WayPointStatus.Arrived);
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x001776F8 File Offset: 0x001758F8
		public bool IsWayPointArrived(int wayPointId)
		{
			WayPointStatus wayPointStatus;
			return this.CanMoveWayPointIds.TryGetValue(wayPointId, out wayPointStatus) && (wayPointStatus & WayPointStatus.Arrived) != WayPointStatus.None;
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x00177724 File Offset: 0x00175924
		public List<int> GetNotEventWayPoints()
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, WayPointStatus> keyValuePair in this.CanMoveWayPointIds)
			{
				if (keyValuePair.Value == WayPointStatus.Arrived)
				{
					list.Add(keyValuePair.Key);
				}
			}
			return list;
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x0017779C File Offset: 0x0017599C
		public List<int> GetArrivedWayPoints()
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, WayPointStatus> keyValuePair in this.CanMoveWayPointIds)
			{
				if (this.IsWayPointArrived(keyValuePair.Key))
				{
					list.Add(keyValuePair.Key);
				}
			}
			return list;
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x00177818 File Offset: 0x00175A18
		public bool CanExpandWayPoint(int wayPointId)
		{
			WayPointStatus wayPointStatus;
			return this.CanMoveWayPointIds.TryGetValue(wayPointId, out wayPointStatus) && wayPointStatus == WayPointStatus.Arrived;
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x00177840 File Offset: 0x00175A40
		public bool CanMoveWayPoint(int wayPointId)
		{
			return this.CanMoveWayPointIds.ContainsKey(wayPointId);
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x00177860 File Offset: 0x00175A60
		// (set) Token: 0x06004BE6 RID: 19430 RVA: 0x00177850 File Offset: 0x00175A50
		public int CurrentWayPointId
		{
			get
			{
				return this.m_currentWayPointId;
			}
			set
			{
				this.m_currentWayPointId = value;
				this.UpdateCurrentWaypointInfo();
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x00177878 File Offset: 0x00175A78
		// (set) Token: 0x06004BE8 RID: 19432 RVA: 0x00177868 File Offset: 0x00175A68
		public int LastFinishedScenarioId
		{
			get
			{
				return this.m_lastFinishedScenarioId;
			}
			set
			{
				this.m_lastFinishedScenarioId = value;
				this.UpdateScenarioInfo();
			}
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x00177880 File Offset: 0x00175A80
		public void InitRandomEvents(List<RandomEvent> randomEvents)
		{
			this.RandomEvents.Clear();
			this.RandomEvents.AddRange(randomEvents);
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x0017789C File Offset: 0x00175A9C
		public void SetRandomEvents(List<RandomEvent> randomEvents)
		{
			this.RandomEvents.Clear();
			this.RandomEvents.AddRange(randomEvents);
			base.SetDirty(true);
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x001778BC File Offset: 0x00175ABC
		public void AddRandomEvent(RandomEvent randomEvent)
		{
			this.RandomEvents.Add(randomEvent);
			this.SortByExpiredTimeAscend();
			base.SetDirty(true);
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x001778D8 File Offset: 0x00175AD8
		public void AddDeadLives(RandomEvent randomEvent, int deadLives)
		{
			randomEvent.DeadLives += deadLives;
			base.SetDirty(true);
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x001778F0 File Offset: 0x00175AF0
		public void RemoveRandomEvent(RandomEvent randomEvent)
		{
			if (this.RandomEvents.Contains(randomEvent))
			{
				this.RandomEvents.Remove(randomEvent);
				base.SetDirty(true);
			}
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x00177918 File Offset: 0x00175B18
		private void SortByExpiredTimeAscend()
		{
			this.RandomEvents.Sort((RandomEvent a, RandomEvent b) => TimeCaculate.AscendTimeCallBack(new DateTime(a.ExpiredTime), new DateTime(b.ExpiredTime)));
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x00177944 File Offset: 0x00175B44
		public void ClearRandomEvents()
		{
			this.RandomEvents.Clear();
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x00177954 File Offset: 0x00175B54
		public RandomEvent GetRandomEvent(int wayPointId)
		{
			return this.RandomEvents.Find((RandomEvent t) => t.WayPointId == wayPointId);
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x00177988 File Offset: 0x00175B88
		// (set) Token: 0x06004BF3 RID: 19443 RVA: 0x00177990 File Offset: 0x00175B90
		public Dictionary<int, WayPointStatus> CanMoveWayPointIds { get; set; }

		// Token: 0x06004BF4 RID: 19444 RVA: 0x0017799C File Offset: 0x00175B9C
		private void UpdateScenarioInfo()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.LastFinishedScenarioInfo = configDataLoader.GetConfigDataScenarioInfo(this.LastFinishedScenarioId);
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x001779CC File Offset: 0x00175BCC
		private void UpdateCurrentWaypointInfo()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.CurrentWaypointInfo = configDataLoader.GetConfigDataWaypointInfo(this.CurrentWayPointId);
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x00177A08 File Offset: 0x00175C08
		// (set) Token: 0x06004BF6 RID: 19446 RVA: 0x001779FC File Offset: 0x00175BFC
		public ConfigDataScenarioInfo LastFinishedScenarioInfo { get; private set; }

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x00177A1C File Offset: 0x00175C1C
		// (set) Token: 0x06004BF8 RID: 19448 RVA: 0x00177A10 File Offset: 0x00175C10
		public ConfigDataWaypointInfo CurrentWaypointInfo { get; private set; }

		// Token: 0x04003881 RID: 14465
		private int m_currentWayPointId;

		// Token: 0x04003882 RID: 14466
		private int m_lastFinishedScenarioId;

		// Token: 0x04003883 RID: 14467
		public List<RandomEvent> RandomEvents;
	}
}
