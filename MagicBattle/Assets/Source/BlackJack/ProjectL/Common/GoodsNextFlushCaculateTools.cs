using System;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200042A RID: 1066
	[CustomLuaClass]
	public class GoodsNextFlushCaculateTools
	{
		// Token: 0x06003D69 RID: 15721 RVA: 0x00114FB0 File Offset: 0x001131B0
		public static DateTime CaculateNextFlushTime(BuyRuleType rule, int param, DateTime currentTime, long oldNextFlushTimeTicks = 0L)
		{
			DateTime dateTime = (oldNextFlushTimeTicks != 0L) ? new DateTime(oldNextFlushTimeTicks) : currentTime;
			if (dateTime > currentTime)
			{
				return dateTime;
			}
			DateTime maxValue = DateTime.MaxValue;
			switch (rule)
			{
			case BuyRuleType.BuyRuleType_FixedTime:
			{
				if (param <= 0)
				{
					return DateTime.MaxValue;
				}
				int num = (int)(currentTime.Date - dateTime.Date).TotalDays / param + 1;
				int num2 = param * num;
				return TimeCaculate.GetInitialTimeInOneDay(dateTime).AddDays((double)num2);
			}
			case BuyRuleType.BuyRuleType_WeekTime:
				return TimeCaculate.GetNextWeekFirstDayTime(currentTime);
			case BuyRuleType.BuyRuleType_MonthTime:
				return TimeCaculate.GetNextMonthFirstDayTime(currentTime);
			}
			return DateTime.MaxValue;
		}
	}
}
