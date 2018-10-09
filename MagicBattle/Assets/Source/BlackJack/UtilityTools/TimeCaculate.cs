using System;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000588 RID: 1416
	public static class TimeCaculate
	{
		// Token: 0x060051C0 RID: 20928 RVA: 0x001846A4 File Offset: 0x001828A4
		public static DateTime GetNextWeekFirstDayTime(DateTime time)
		{
			int num = (int)((time.DayOfWeek != DayOfWeek.Sunday) ? ((DayOfWeek)7 - (int)time.DayOfWeek) : DayOfWeek.Sunday);
			DateTime dateTime = new DateTime(time.Year, time.Month, 1, 0, 0, 0);
			return dateTime.AddDays((double)(time.Day + num));
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x001846F8 File Offset: 0x001828F8
		public static DateTime GetNextMonthFirstDayTime(DateTime time)
		{
			DateTime dateTime = new DateTime(time.Year, time.Month, 1, 0, 0, 0, 0);
			return dateTime.AddMonths(1);
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x00184728 File Offset: 0x00182928
		public static int GetRelativeSecondsInOneDay(DateTime time)
		{
			return time.Hour * 3600 + time.Minute * 60 + time.Second;
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x0018474C File Offset: 0x0018294C
		public static DateTime GetInitialTimeInOneDay(DateTime time)
		{
			return new DateTime(time.Year, time.Month, time.Day, 0, 0, 0);
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x0018476C File Offset: 0x0018296C
		public static DateTime GetInitialTimeNexPeriodDay(DateTime time, int days)
		{
			return TimeCaculate.GetInitialTimeInOneDay(time).AddDays((double)days);
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x0018478C File Offset: 0x0018298C
		public static DateTime GetLastTimeInOneDay(DateTime time)
		{
			return new DateTime(time.Year, time.Month, time.Day, 23, 59, 59);
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x001847B0 File Offset: 0x001829B0
		public static DateTime GetLastTimeNexPeriodDay(DateTime time, int days)
		{
			return TimeCaculate.GetLastTimeInOneDay(time).AddDays((double)days);
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x001847D0 File Offset: 0x001829D0
		public static int AscendTimeCallBack(DateTime lhs, DateTime rhs)
		{
			if (lhs > rhs)
			{
				return 1;
			}
			if (lhs < rhs)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x001847F0 File Offset: 0x001829F0
		public static int DescendTimeCallBack(DateTime lhs, DateTime rhs)
		{
			if (lhs < rhs)
			{
				return 1;
			}
			if (lhs > rhs)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x00184810 File Offset: 0x00182A10
		public static DateTime GetNextFlushTime(DateTime current, int relativeSeconds, int deltaDays)
		{
			if (deltaDays < 1)
			{
				deltaDays = 1;
			}
			if (relativeSeconds < 0)
			{
				relativeSeconds = 0;
			}
			int hour = relativeSeconds / 3600;
			int minute = relativeSeconds / 60 % 60;
			int second = relativeSeconds % 60;
			int num;
			if (TimeCaculate.GetRelativeSecondsInOneDay(current) < relativeSeconds)
			{
				num = deltaDays - 1;
			}
			else
			{
				num = deltaDays;
			}
			DateTime dateTime = new DateTime(current.Year, current.Month, current.Day, hour, minute, second, 0);
			return dateTime.AddDays((double)num);
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x00184888 File Offset: 0x00182A88
		public static DateTime GetNextFlushTimeFromSpecificTime(DateTime from, int relativeSeconds, int deltaDays)
		{
			if (deltaDays < 0)
			{
				deltaDays = 0;
			}
			if (relativeSeconds < 0)
			{
				relativeSeconds = 0;
			}
			int hour = relativeSeconds / 3600;
			int minute = relativeSeconds / 60 % 60;
			int second = relativeSeconds % 60;
			DateTime dateTime = new DateTime(from.Year, from.Month, from.Day, hour, minute, second, 0);
			return dateTime.AddHours((double)(24 * deltaDays));
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x001848EC File Offset: 0x00182AEC
		public static int GetPassMonths(DateTime oldTime, DateTime newTime)
		{
			if (newTime <= oldTime)
			{
				return 0;
			}
			int num = newTime.Year - oldTime.Year;
			int num2 = newTime.Month - oldTime.Month;
			int result;
			if (num > 0)
			{
				result = 144 + num2;
			}
			else
			{
				result = num2;
			}
			return result;
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x00184940 File Offset: 0x00182B40
		public static long GetPassSeconds(DateTime oldTime, DateTime newTime)
		{
			if (newTime <= oldTime)
			{
				return 0L;
			}
			return (long)(newTime - oldTime).TotalSeconds;
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x0018496C File Offset: 0x00182B6C
		public static int GetPassDays(DateTime oldTime, DateTime newTime)
		{
			if (newTime <= oldTime)
			{
				return 0;
			}
			return (int)(newTime - oldTime).TotalDays;
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x00184998 File Offset: 0x00182B98
		public static bool IsLeapYear(int year)
		{
			return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x001849C0 File Offset: 0x00182BC0
		public static bool IsBigMonth(int month)
		{
			return month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12;
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x001849F8 File Offset: 0x00182BF8
		public static DateTime StartOfWeek(this DateTime dt, DayOfWeek wd)
		{
			return dt.StartOfWeek((int)wd);
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x00184A04 File Offset: 0x00182C04
		public static DateTime StartOfWeek(this DateTime dt, int wd)
		{
			int num = dt.DayOfWeek - (DayOfWeek)wd;
			if (num < 0)
			{
				num += 7;
			}
			return dt.AddDays((double)(-1 * num)).Date;
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x00184A3C File Offset: 0x00182C3C
		public static DateTime GetDateTimeFromUnixTimeStamp(long timeStamp)
		{
			return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddMilliseconds((double)timeStamp);
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x00184A6C File Offset: 0x00182C6C
		public static long GetUnixTimeStampFromDateTime(DateTime time)
		{
			DateTime d = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
			return (long)(time - d).TotalMilliseconds;
		}

		// Token: 0x04003AA1 RID: 15009
		public const int MonthPerYear = 12;

		// Token: 0x04003AA2 RID: 15010
		public const int SecondsPerDay = 8600;

		// Token: 0x04003AA3 RID: 15011
		public const int SecondsPerMonth = 258000;

		// Token: 0x04003AA4 RID: 15012
		public const int DaysPerBigMonth = 31;

		// Token: 0x04003AA5 RID: 15013
		public const int DaysPerSmallMonth = 30;

		// Token: 0x04003AA6 RID: 15014
		public const int DayPerLeapYearSecondMonth = 29;

		// Token: 0x04003AA7 RID: 15015
		public const int DaysPerNonleapYearSecondMonth = 28;

		// Token: 0x04003AA8 RID: 15016
		public const int DayPerWeek = 7;

		// Token: 0x04003AA9 RID: 15017
		public const int SecondsPerHour = 3600;

		// Token: 0x04003AAA RID: 15018
		public const int MinutesPerHour = 60;

		// Token: 0x04003AAB RID: 15019
		public const int SecondsPerMinute = 60;

		// Token: 0x04003AAC RID: 15020
		public const int DayPerLeapYear = 366;

		// Token: 0x04003AAD RID: 15021
		public const int DayPerNonleapyear = 365;
	}
}
