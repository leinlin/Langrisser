using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000407 RID: 1031
	[CustomLuaClass]
	public class RandomEvent
	{
		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06003C51 RID: 15441 RVA: 0x00111D14 File Offset: 0x0010FF14
		// (set) Token: 0x06003C52 RID: 15442 RVA: 0x00111D1C File Offset: 0x0010FF1C
		public int EventId { get; set; }

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06003C53 RID: 15443 RVA: 0x00111D28 File Offset: 0x0010FF28
		// (set) Token: 0x06003C54 RID: 15444 RVA: 0x00111D30 File Offset: 0x0010FF30
		public int WayPointId { get; set; }

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06003C55 RID: 15445 RVA: 0x00111D3C File Offset: 0x0010FF3C
		// (set) Token: 0x06003C56 RID: 15446 RVA: 0x00111D44 File Offset: 0x0010FF44
		public int Lives { get; set; }

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06003C57 RID: 15447 RVA: 0x00111D50 File Offset: 0x0010FF50
		// (set) Token: 0x06003C58 RID: 15448 RVA: 0x00111D58 File Offset: 0x0010FF58
		public int DeadLives { get; set; }

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x00111D64 File Offset: 0x0010FF64
		// (set) Token: 0x06003C5A RID: 15450 RVA: 0x00111D6C File Offset: 0x0010FF6C
		public long ExpiredTime { get; set; }

		// Token: 0x06003C5B RID: 15451 RVA: 0x00111D78 File Offset: 0x0010FF78
		public static ProRandomEvent RandomEventToPBRandomEvent(RandomEvent randomEvent)
		{
			return new ProRandomEvent
			{
				EventId = randomEvent.EventId,
				WayPointId = randomEvent.WayPointId,
				DeadLives = randomEvent.DeadLives,
				ExpiredTime = randomEvent.ExpiredTime
			};
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x00111DBC File Offset: 0x0010FFBC
		public static List<ProRandomEvent> RandomEventsToPBRandomEvents(List<RandomEvent> randomEvents)
		{
			List<ProRandomEvent> list = new List<ProRandomEvent>();
			foreach (RandomEvent randomEvent in randomEvents)
			{
				list.Add(RandomEvent.RandomEventToPBRandomEvent(randomEvent));
			}
			return list;
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x00111E20 File Offset: 0x00110020
		public static RandomEvent PBRandomEventToRandomEvent(ProRandomEvent pbRadomEvent)
		{
			return new RandomEvent
			{
				EventId = pbRadomEvent.EventId,
				WayPointId = pbRadomEvent.WayPointId,
				DeadLives = pbRadomEvent.DeadLives,
				ExpiredTime = pbRadomEvent.ExpiredTime
			};
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x00111E64 File Offset: 0x00110064
		public static List<RandomEvent> PBRandomEventsToRandomEvents(List<ProRandomEvent> pbRadomEvents)
		{
			List<RandomEvent> list = new List<RandomEvent>();
			foreach (ProRandomEvent pbRadomEvent in pbRadomEvents)
			{
				list.Add(RandomEvent.PBRandomEventToRandomEvent(pbRadomEvent));
			}
			return list;
		}
	}
}
