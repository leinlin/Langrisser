using System;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000593 RID: 1427
	public static class GameDateTime
	{
		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x001859BC File Offset: 0x00183BBC
		// (set) Token: 0x06005207 RID: 20999 RVA: 0x001859F4 File Offset: 0x00183BF4
		public static TimeSpan Offset
		{
			get
			{
				TimeSpan? offset = GameDateTime._Offset;
				return (offset != null) ? GameDateTime._Offset.Value : new TimeSpan(0L);
			}
			set
			{
				TimeSpan? offset = GameDateTime._Offset;
				if (offset == null)
				{
					GameDateTime._Offset = new TimeSpan?(value);
					return;
				}
				throw new ArgumentException("Offset for the game is only allowed to set once!");
			}
		}

		// Token: 0x06005208 RID: 21000 RVA: 0x00185A34 File Offset: 0x00183C34
		public static long IsSameDay(DateTime x, DateTime y)
		{
			if (GameDateTime.Offset.Ticks == 0L)
			{
				return (x.Date.Ticks - y.Date.Ticks) / GameDateTime.TicksPerDay;
			}
			DateTime dateTime = x.Add(-GameDateTime.Offset);
			DateTime dateTime2 = y.Add(-GameDateTime.Offset);
			if (dateTime.Date == dateTime2.Date)
			{
				return 0L;
			}
			long num = dateTime.Ticks - dateTime2.Ticks;
			if (num % GameDateTime.TicksPerDay == 0L)
			{
				return num / GameDateTime.TicksPerDay;
			}
			if (num > 0L)
			{
				return num / GameDateTime.TicksPerDay + 1L;
			}
			return num / GameDateTime.TicksPerDay - 1L;
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06005209 RID: 21001 RVA: 0x00185B04 File Offset: 0x00183D04
		public static DateTime BeginOfToday
		{
			get
			{
				DateTime now = DateTime.Now;
				if (GameDateTime.Offset.Ticks == 0L)
				{
					return now.Date;
				}
				DateTime date = now.Date;
				long num = GameDateTime.IsSameDay(date, now);
				if (num == 0L)
				{
					return date.AddTicks(GameDateTime.Offset.Ticks - GameDateTime.TicksPerDay);
				}
				return date.Add(GameDateTime.Offset);
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x00185B74 File Offset: 0x00183D74
		public static DateTime BeginOfTomorrow
		{
			get
			{
				return GameDateTime.BeginOfToday.AddDays(1.0);
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x0600520B RID: 21003 RVA: 0x00185B98 File Offset: 0x00183D98
		public static DateTime BeginOfYesterday
		{
			get
			{
				return GameDateTime.BeginOfToday.AddDays(-1.0);
			}
		}

		// Token: 0x04003AB5 RID: 15029
		public static readonly long TicksPerSecond = DateTime.MinValue.AddSeconds(1.0).Ticks - DateTime.MinValue.Ticks;

		// Token: 0x04003AB6 RID: 15030
		public static readonly long TicksPerMinute = GameDateTime.TicksPerSecond * 60L;

		// Token: 0x04003AB7 RID: 15031
		public static readonly long TicksPerHour = GameDateTime.TicksPerMinute * 60L;

		// Token: 0x04003AB8 RID: 15032
		public static readonly long TicksPerDay = GameDateTime.TicksPerHour * 24L;

		// Token: 0x04003AB9 RID: 15033
		private static TimeSpan? _Offset = null;
	}
}
