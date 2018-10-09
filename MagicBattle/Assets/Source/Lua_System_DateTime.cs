using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001605 RID: 5637
[Preserve]
public class Lua_System_DateTime : LuaObject
{
	// Token: 0x06022940 RID: 141632 RVA: 0x00BDF168 File Offset: 0x00BDD368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				long ticks;
				LuaObject.checkType(l, 2, out ticks);
				DateTime dateTime = new DateTime(ticks);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (num == 4)
			{
				int year;
				LuaObject.checkType(l, 2, out year);
				int month;
				LuaObject.checkType(l, 3, out month);
				int day;
				LuaObject.checkType(l, 4, out day);
				DateTime dateTime = new DateTime(year, month, day);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (num == 7)
			{
				int year2;
				LuaObject.checkType(l, 2, out year2);
				int month2;
				LuaObject.checkType(l, 3, out month2);
				int day2;
				LuaObject.checkType(l, 4, out day2);
				int hour;
				LuaObject.checkType(l, 5, out hour);
				int minute;
				LuaObject.checkType(l, 6, out minute);
				int second;
				LuaObject.checkType(l, 7, out second);
				DateTime dateTime = new DateTime(year2, month2, day2, hour, minute, second);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)))
			{
				int year3;
				LuaObject.checkType(l, 2, out year3);
				int month3;
				LuaObject.checkType(l, 3, out month3);
				int day3;
				LuaObject.checkType(l, 4, out day3);
				int hour2;
				LuaObject.checkType(l, 5, out hour2);
				int minute2;
				LuaObject.checkType(l, 6, out minute2);
				int second2;
				LuaObject.checkType(l, 7, out second2);
				int millisecond;
				LuaObject.checkType(l, 8, out millisecond);
				DateTime dateTime = new DateTime(year3, month3, day3, hour2, minute2, second2, millisecond);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (num == 5)
			{
				int year4;
				LuaObject.checkType(l, 2, out year4);
				int month4;
				LuaObject.checkType(l, 3, out month4);
				int day4;
				LuaObject.checkType(l, 4, out day4);
				Calendar calendar;
				LuaObject.checkType<Calendar>(l, 5, out calendar);
				DateTime dateTime = new DateTime(year4, month4, day4, calendar);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Calendar)))
			{
				int year5;
				LuaObject.checkType(l, 2, out year5);
				int month5;
				LuaObject.checkType(l, 3, out month5);
				int day5;
				LuaObject.checkType(l, 4, out day5);
				int hour3;
				LuaObject.checkType(l, 5, out hour3);
				int minute3;
				LuaObject.checkType(l, 6, out minute3);
				int second3;
				LuaObject.checkType(l, 7, out second3);
				Calendar calendar2;
				LuaObject.checkType<Calendar>(l, 8, out calendar2);
				DateTime dateTime = new DateTime(year5, month5, day5, hour3, minute3, second3, calendar2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Calendar)))
			{
				int year6;
				LuaObject.checkType(l, 2, out year6);
				int month6;
				LuaObject.checkType(l, 3, out month6);
				int day6;
				LuaObject.checkType(l, 4, out day6);
				int hour4;
				LuaObject.checkType(l, 5, out hour4);
				int minute4;
				LuaObject.checkType(l, 6, out minute4);
				int second4;
				LuaObject.checkType(l, 7, out second4);
				int millisecond2;
				LuaObject.checkType(l, 8, out millisecond2);
				Calendar calendar3;
				LuaObject.checkType<Calendar>(l, 9, out calendar3);
				DateTime dateTime = new DateTime(year6, month6, day6, hour4, minute4, second4, millisecond2, calendar3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (num == 3)
			{
				long ticks2;
				LuaObject.checkType(l, 2, out ticks2);
				DateTimeKind kind;
				LuaObject.checkEnum<DateTimeKind>(l, 3, out kind);
				DateTime dateTime = new DateTime(ticks2, kind);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTimeKind)))
			{
				int year7;
				LuaObject.checkType(l, 2, out year7);
				int month7;
				LuaObject.checkType(l, 3, out month7);
				int day7;
				LuaObject.checkType(l, 4, out day7);
				int hour5;
				LuaObject.checkType(l, 5, out hour5);
				int minute5;
				LuaObject.checkType(l, 6, out minute5);
				int second5;
				LuaObject.checkType(l, 7, out second5);
				DateTimeKind kind2;
				LuaObject.checkEnum<DateTimeKind>(l, 8, out kind2);
				DateTime dateTime = new DateTime(year7, month7, day7, hour5, minute5, second5, kind2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTimeKind)))
			{
				int year8;
				LuaObject.checkType(l, 2, out year8);
				int month8;
				LuaObject.checkType(l, 3, out month8);
				int day8;
				LuaObject.checkType(l, 4, out day8);
				int hour6;
				LuaObject.checkType(l, 5, out hour6);
				int minute6;
				LuaObject.checkType(l, 6, out minute6);
				int second6;
				LuaObject.checkType(l, 7, out second6);
				int millisecond3;
				LuaObject.checkType(l, 8, out millisecond3);
				DateTimeKind kind3;
				LuaObject.checkEnum<DateTimeKind>(l, 9, out kind3);
				DateTime dateTime = new DateTime(year8, month8, day8, hour6, minute6, second6, millisecond3, kind3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (num == 10)
			{
				int year9;
				LuaObject.checkType(l, 2, out year9);
				int month9;
				LuaObject.checkType(l, 3, out month9);
				int day9;
				LuaObject.checkType(l, 4, out day9);
				int hour7;
				LuaObject.checkType(l, 5, out hour7);
				int minute7;
				LuaObject.checkType(l, 6, out minute7);
				int second7;
				LuaObject.checkType(l, 7, out second7);
				int millisecond4;
				LuaObject.checkType(l, 8, out millisecond4);
				Calendar calendar4;
				LuaObject.checkType<Calendar>(l, 9, out calendar4);
				DateTimeKind kind4;
				LuaObject.checkEnum<DateTimeKind>(l, 10, out kind4);
				DateTime dateTime = new DateTime(year9, month9, day9, hour7, minute7, second7, millisecond4, calendar4, kind4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (num == 0)
			{
				DateTime dateTime = default(DateTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, dateTime);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022941 RID: 141633 RVA: 0x00BDF818 File Offset: 0x00BDDA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Add(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			TimeSpan value;
			LuaObject.checkValueType<TimeSpan>(l, 2, out value);
			DateTime dateTime2 = dateTime.Add(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022942 RID: 141634 RVA: 0x00BDF880 File Offset: 0x00BDDA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDays(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			double value;
			LuaObject.checkType(l, 2, out value);
			DateTime dateTime2 = dateTime.AddDays(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022943 RID: 141635 RVA: 0x00BDF8E8 File Offset: 0x00BDDAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTicks(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			long value;
			LuaObject.checkType(l, 2, out value);
			DateTime dateTime2 = dateTime.AddTicks(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022944 RID: 141636 RVA: 0x00BDF950 File Offset: 0x00BDDB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHours(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			double value;
			LuaObject.checkType(l, 2, out value);
			DateTime dateTime2 = dateTime.AddHours(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022945 RID: 141637 RVA: 0x00BDF9B8 File Offset: 0x00BDDBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMilliseconds(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			double value;
			LuaObject.checkType(l, 2, out value);
			DateTime dateTime2 = dateTime.AddMilliseconds(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022946 RID: 141638 RVA: 0x00BDFA20 File Offset: 0x00BDDC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMinutes(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			double value;
			LuaObject.checkType(l, 2, out value);
			DateTime dateTime2 = dateTime.AddMinutes(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022947 RID: 141639 RVA: 0x00BDFA88 File Offset: 0x00BDDC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMonths(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			int months;
			LuaObject.checkType(l, 2, out months);
			DateTime dateTime2 = dateTime.AddMonths(months);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022948 RID: 141640 RVA: 0x00BDFAF0 File Offset: 0x00BDDCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSeconds(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			double value;
			LuaObject.checkType(l, 2, out value);
			DateTime dateTime2 = dateTime.AddSeconds(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022949 RID: 141641 RVA: 0x00BDFB58 File Offset: 0x00BDDD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddYears(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			int value;
			LuaObject.checkType(l, 2, out value);
			DateTime dateTime2 = dateTime.AddYears(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602294A RID: 141642 RVA: 0x00BDFBC0 File Offset: 0x00BDDDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareTo(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(object)))
			{
				DateTime dateTime;
				LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
				object value;
				LuaObject.checkType<object>(l, 2, out value);
				int i = dateTime.CompareTo(value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(DateTime)))
			{
				DateTime dateTime2;
				LuaObject.checkValueType<DateTime>(l, 1, out dateTime2);
				DateTime value2;
				LuaObject.checkValueType<DateTime>(l, 2, out value2);
				int i2 = dateTime2.CompareTo(value2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CompareTo to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602294B RID: 141643 RVA: 0x00BDFCA8 File Offset: 0x00BDDEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDaylightSavingTime(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			bool b = dateTime.IsDaylightSavingTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602294C RID: 141644 RVA: 0x00BDFCFC File Offset: 0x00BDDEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToBinary(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			long i = dateTime.ToBinary();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602294D RID: 141645 RVA: 0x00BDFD50 File Offset: 0x00BDDF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDateTimeFormats(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				DateTime dateTime;
				LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
				string[] dateTimeFormats = dateTime.GetDateTimeFormats();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTimeFormats);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(char)))
			{
				DateTime dateTime2;
				LuaObject.checkValueType<DateTime>(l, 1, out dateTime2);
				char format;
				LuaObject.checkType(l, 2, out format);
				string[] dateTimeFormats2 = dateTime2.GetDateTimeFormats(format);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTimeFormats2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(IFormatProvider)))
			{
				DateTime dateTime3;
				LuaObject.checkValueType<DateTime>(l, 1, out dateTime3);
				IFormatProvider provider;
				LuaObject.checkType<IFormatProvider>(l, 2, out provider);
				string[] dateTimeFormats3 = dateTime3.GetDateTimeFormats(provider);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTimeFormats3);
				result = 2;
			}
			else if (num == 3)
			{
				DateTime dateTime4;
				LuaObject.checkValueType<DateTime>(l, 1, out dateTime4);
				char format2;
				LuaObject.checkType(l, 2, out format2);
				IFormatProvider provider2;
				LuaObject.checkType<IFormatProvider>(l, 3, out provider2);
				string[] dateTimeFormats4 = dateTime4.GetDateTimeFormats(format2, provider2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTimeFormats4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetDateTimeFormats to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602294E RID: 141646 RVA: 0x00BDFEB8 File Offset: 0x00BDE0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTypeCode(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			TypeCode typeCode = dateTime.GetTypeCode();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)typeCode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602294F RID: 141647 RVA: 0x00BDFF0C File Offset: 0x00BDE10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Subtract(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(DateTime)))
			{
				DateTime dateTime;
				LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
				DateTime value;
				LuaObject.checkValueType<DateTime>(l, 2, out value);
				TimeSpan timeSpan = dateTime.Subtract(value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, timeSpan);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(TimeSpan)))
			{
				DateTime dateTime2;
				LuaObject.checkValueType<DateTime>(l, 1, out dateTime2);
				TimeSpan value2;
				LuaObject.checkValueType<TimeSpan>(l, 2, out value2);
				DateTime dateTime3 = dateTime2.Subtract(value2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Subtract to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022950 RID: 141648 RVA: 0x00BE0000 File Offset: 0x00BDE200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToFileTime(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			long i = dateTime.ToFileTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022951 RID: 141649 RVA: 0x00BE0054 File Offset: 0x00BDE254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToFileTimeUtc(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			long i = dateTime.ToFileTimeUtc();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022952 RID: 141650 RVA: 0x00BE00A8 File Offset: 0x00BDE2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToLongDateString(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			string s = dateTime.ToLongDateString();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022953 RID: 141651 RVA: 0x00BE00FC File Offset: 0x00BDE2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToLongTimeString(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			string s = dateTime.ToLongTimeString();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022954 RID: 141652 RVA: 0x00BE0150 File Offset: 0x00BDE350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToOADate(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			double d = dateTime.ToOADate();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, d);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022955 RID: 141653 RVA: 0x00BE01A4 File Offset: 0x00BDE3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToShortDateString(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			string s = dateTime.ToShortDateString();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022956 RID: 141654 RVA: 0x00BE01F8 File Offset: 0x00BDE3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToShortTimeString(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			string s = dateTime.ToShortTimeString();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022957 RID: 141655 RVA: 0x00BE024C File Offset: 0x00BDE44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToLocalTime(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			DateTime dateTime2 = dateTime.ToLocalTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022958 RID: 141656 RVA: 0x00BE02A4 File Offset: 0x00BDE4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToUniversalTime(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			DateTime dateTime2 = dateTime.ToUniversalTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022959 RID: 141657 RVA: 0x00BE02FC File Offset: 0x00BDE4FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartOfWeek(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				DateTime dt;
				LuaObject.checkValueType<DateTime>(l, 1, out dt);
				int wd;
				LuaObject.checkType(l, 2, out wd);
				DateTime dateTime = dt.StartOfWeek(wd);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(DayOfWeek)))
			{
				DateTime dt2;
				LuaObject.checkValueType<DateTime>(l, 1, out dt2);
				DayOfWeek wd2;
				LuaObject.checkEnum<DayOfWeek>(l, 2, out wd2);
				DateTime dateTime2 = dt2.StartOfWeek(wd2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function StartOfWeek to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602295A RID: 141658 RVA: 0x00BE03F0 File Offset: 0x00BDE5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Compare_s(IntPtr l)
	{
		int result;
		try
		{
			DateTime t;
			LuaObject.checkValueType<DateTime>(l, 1, out t);
			DateTime t2;
			LuaObject.checkValueType<DateTime>(l, 2, out t2);
			int i = DateTime.Compare(t, t2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602295B RID: 141659 RVA: 0x00BE0450 File Offset: 0x00BDE650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromBinary_s(IntPtr l)
	{
		int result;
		try
		{
			long dateData;
			LuaObject.checkType(l, 1, out dateData);
			DateTime dateTime = DateTime.FromBinary(dateData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602295C RID: 141660 RVA: 0x00BE04A8 File Offset: 0x00BDE6A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SpecifyKind_s(IntPtr l)
	{
		int result;
		try
		{
			DateTime value;
			LuaObject.checkValueType<DateTime>(l, 1, out value);
			DateTimeKind kind;
			LuaObject.checkEnum<DateTimeKind>(l, 2, out kind);
			DateTime dateTime = DateTime.SpecifyKind(value, kind);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602295D RID: 141661 RVA: 0x00BE050C File Offset: 0x00BDE70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DaysInMonth_s(IntPtr l)
	{
		int result;
		try
		{
			int year;
			LuaObject.checkType(l, 1, out year);
			int month;
			LuaObject.checkType(l, 2, out month);
			int i = DateTime.DaysInMonth(year, month);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602295E RID: 141662 RVA: 0x00BE056C File Offset: 0x00BDE76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromFileTime_s(IntPtr l)
	{
		int result;
		try
		{
			long fileTime;
			LuaObject.checkType(l, 1, out fileTime);
			DateTime dateTime = DateTime.FromFileTime(fileTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602295F RID: 141663 RVA: 0x00BE05C4 File Offset: 0x00BDE7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromFileTimeUtc_s(IntPtr l)
	{
		int result;
		try
		{
			long fileTime;
			LuaObject.checkType(l, 1, out fileTime);
			DateTime dateTime = DateTime.FromFileTimeUtc(fileTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022960 RID: 141664 RVA: 0x00BE061C File Offset: 0x00BDE81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromOADate_s(IntPtr l)
	{
		int result;
		try
		{
			double d;
			LuaObject.checkType(l, 1, out d);
			DateTime dateTime = DateTime.FromOADate(d);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022961 RID: 141665 RVA: 0x00BE0674 File Offset: 0x00BDE874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLeapYear_s(IntPtr l)
	{
		int result;
		try
		{
			int year;
			LuaObject.checkType(l, 1, out year);
			bool b = DateTime.IsLeapYear(year);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022962 RID: 141666 RVA: 0x00BE06C8 File Offset: 0x00BDE8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Parse_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string s;
				LuaObject.checkType(l, 1, out s);
				DateTime dateTime = DateTime.Parse(s);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (num == 2)
			{
				string s2;
				LuaObject.checkType(l, 1, out s2);
				IFormatProvider provider;
				LuaObject.checkType<IFormatProvider>(l, 2, out provider);
				DateTime dateTime2 = DateTime.Parse(s2, provider);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime2);
				result = 2;
			}
			else if (num == 3)
			{
				string s3;
				LuaObject.checkType(l, 1, out s3);
				IFormatProvider provider2;
				LuaObject.checkType<IFormatProvider>(l, 2, out provider2);
				DateTimeStyles styles;
				LuaObject.checkEnum<DateTimeStyles>(l, 3, out styles);
				DateTime dateTime3 = DateTime.Parse(s3, provider2, styles);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Parse to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022963 RID: 141667 RVA: 0x00BE07D8 File Offset: 0x00BDE9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ParseExact_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				string s;
				LuaObject.checkType(l, 1, out s);
				string format;
				LuaObject.checkType(l, 2, out format);
				IFormatProvider provider;
				LuaObject.checkType<IFormatProvider>(l, 3, out provider);
				DateTime dateTime = DateTime.ParseExact(s, format, provider);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(string[]), typeof(IFormatProvider), typeof(DateTimeStyles)))
			{
				string s2;
				LuaObject.checkType(l, 1, out s2);
				string[] formats;
				LuaObject.checkArray<string>(l, 2, out formats);
				IFormatProvider provider2;
				LuaObject.checkType<IFormatProvider>(l, 3, out provider2);
				DateTimeStyles style;
				LuaObject.checkEnum<DateTimeStyles>(l, 4, out style);
				DateTime dateTime2 = DateTime.ParseExact(s2, formats, provider2, style);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)))
			{
				string s3;
				LuaObject.checkType(l, 1, out s3);
				string format2;
				LuaObject.checkType(l, 2, out format2);
				IFormatProvider provider3;
				LuaObject.checkType<IFormatProvider>(l, 3, out provider3);
				DateTimeStyles style2;
				LuaObject.checkEnum<DateTimeStyles>(l, 4, out style2);
				DateTime dateTime3 = DateTime.ParseExact(s3, format2, provider3, style2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ParseExact to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022964 RID: 141668 RVA: 0x00BE0990 File Offset: 0x00BDEB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryParse_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string s;
				LuaObject.checkType(l, 1, out s);
				DateTime dateTime;
				bool b = DateTime.TryParse(s, out dateTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				LuaObject.pushValue(l, dateTime);
				result = 3;
			}
			else if (num == 4)
			{
				string s2;
				LuaObject.checkType(l, 1, out s2);
				IFormatProvider provider;
				LuaObject.checkType<IFormatProvider>(l, 2, out provider);
				DateTimeStyles styles;
				LuaObject.checkEnum<DateTimeStyles>(l, 3, out styles);
				DateTime dateTime2;
				bool b2 = DateTime.TryParse(s2, provider, styles, out dateTime2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				LuaObject.pushValue(l, dateTime2);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function TryParse to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022965 RID: 141669 RVA: 0x00BE0A78 File Offset: 0x00BDEC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryParseExact_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string), typeof(string[]), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(LuaOut)))
			{
				string s;
				LuaObject.checkType(l, 1, out s);
				string[] formats;
				LuaObject.checkArray<string>(l, 2, out formats);
				IFormatProvider provider;
				LuaObject.checkType<IFormatProvider>(l, 3, out provider);
				DateTimeStyles style;
				LuaObject.checkEnum<DateTimeStyles>(l, 4, out style);
				DateTime dateTime;
				bool b = DateTime.TryParseExact(s, formats, provider, style, out dateTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				LuaObject.pushValue(l, dateTime);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(LuaOut)))
			{
				string s2;
				LuaObject.checkType(l, 1, out s2);
				string format;
				LuaObject.checkType(l, 2, out format);
				IFormatProvider provider2;
				LuaObject.checkType<IFormatProvider>(l, 3, out provider2);
				DateTimeStyles style2;
				LuaObject.checkEnum<DateTimeStyles>(l, 4, out style2);
				DateTime dateTime2;
				bool b2 = DateTime.TryParseExact(s2, format, provider2, style2, out dateTime2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				LuaObject.pushValue(l, dateTime2);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function TryParseExact to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022966 RID: 141670 RVA: 0x00BE0C0C File Offset: 0x00BDEE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Addition(IntPtr l)
	{
		int result;
		try
		{
			DateTime d;
			LuaObject.checkValueType<DateTime>(l, 1, out d);
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 2, out t);
			DateTime dateTime = d + t;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022967 RID: 141671 RVA: 0x00BE0C70 File Offset: 0x00BDEE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			DateTime d;
			LuaObject.checkValueType<DateTime>(l, 1, out d);
			DateTime d2;
			LuaObject.checkValueType<DateTime>(l, 2, out d2);
			bool b = d == d2;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022968 RID: 141672 RVA: 0x00BE0CD0 File Offset: 0x00BDEED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_GreaterThan(IntPtr l)
	{
		int result;
		try
		{
			DateTime t;
			LuaObject.checkValueType<DateTime>(l, 1, out t);
			DateTime t2;
			LuaObject.checkValueType<DateTime>(l, 2, out t2);
			bool b = t2 < t;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022969 RID: 141673 RVA: 0x00BE0D30 File Offset: 0x00BDEF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_GreaterThanOrEqual(IntPtr l)
	{
		int result;
		try
		{
			DateTime t;
			LuaObject.checkValueType<DateTime>(l, 1, out t);
			DateTime t2;
			LuaObject.checkValueType<DateTime>(l, 2, out t2);
			bool b = t2 <= t;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602296A RID: 141674 RVA: 0x00BE0D90 File Offset: 0x00BDEF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			DateTime d;
			LuaObject.checkValueType<DateTime>(l, 1, out d);
			DateTime d2;
			LuaObject.checkValueType<DateTime>(l, 2, out d2);
			bool b = d != d2;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602296B RID: 141675 RVA: 0x00BE0DF0 File Offset: 0x00BDEFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_LessThan(IntPtr l)
	{
		int result;
		try
		{
			DateTime t;
			LuaObject.checkValueType<DateTime>(l, 1, out t);
			DateTime t2;
			LuaObject.checkValueType<DateTime>(l, 2, out t2);
			bool b = t < t2;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602296C RID: 141676 RVA: 0x00BE0E50 File Offset: 0x00BDF050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_LessThanOrEqual(IntPtr l)
	{
		int result;
		try
		{
			DateTime t;
			LuaObject.checkValueType<DateTime>(l, 1, out t);
			DateTime t2;
			LuaObject.checkValueType<DateTime>(l, 2, out t2);
			bool b = t <= t2;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602296D RID: 141677 RVA: 0x00BE0EB0 File Offset: 0x00BDF0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Subtraction(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(DateTime), typeof(TimeSpan)))
			{
				DateTime d;
				LuaObject.checkValueType<DateTime>(l, 1, out d);
				TimeSpan t;
				LuaObject.checkValueType<TimeSpan>(l, 2, out t);
				DateTime dateTime = d - t;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, dateTime);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(DateTime), typeof(DateTime)))
			{
				DateTime d2;
				LuaObject.checkValueType<DateTime>(l, 1, out d2);
				DateTime d3;
				LuaObject.checkValueType<DateTime>(l, 2, out d3);
				TimeSpan timeSpan = d2 - d3;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, timeSpan);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function op_Subtraction to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602296E RID: 141678 RVA: 0x00BE0FB8 File Offset: 0x00BDF1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MaxValue(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DateTime.MaxValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602296F RID: 141679 RVA: 0x00BE1004 File Offset: 0x00BDF204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MinValue(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DateTime.MinValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022970 RID: 141680 RVA: 0x00BE1050 File Offset: 0x00BDF250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Date(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.Date);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022971 RID: 141681 RVA: 0x00BE10A8 File Offset: 0x00BDF2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Month(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.Month);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022972 RID: 141682 RVA: 0x00BE10FC File Offset: 0x00BDF2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Day(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.Day);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022973 RID: 141683 RVA: 0x00BE1150 File Offset: 0x00BDF350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DayOfWeek(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)dateTime.DayOfWeek);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022974 RID: 141684 RVA: 0x00BE11A4 File Offset: 0x00BDF3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DayOfYear(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.DayOfYear);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022975 RID: 141685 RVA: 0x00BE11F8 File Offset: 0x00BDF3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TimeOfDay(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.TimeOfDay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022976 RID: 141686 RVA: 0x00BE1250 File Offset: 0x00BDF450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Hour(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.Hour);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022977 RID: 141687 RVA: 0x00BE12A4 File Offset: 0x00BDF4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Minute(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.Minute);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022978 RID: 141688 RVA: 0x00BE12F8 File Offset: 0x00BDF4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Second(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.Second);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022979 RID: 141689 RVA: 0x00BE134C File Offset: 0x00BDF54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Millisecond(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.Millisecond);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602297A RID: 141690 RVA: 0x00BE13A0 File Offset: 0x00BDF5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Now(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DateTime.Now);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602297B RID: 141691 RVA: 0x00BE13EC File Offset: 0x00BDF5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Ticks(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.Ticks);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602297C RID: 141692 RVA: 0x00BE1440 File Offset: 0x00BDF640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Today(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DateTime.Today);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602297D RID: 141693 RVA: 0x00BE148C File Offset: 0x00BDF68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UtcNow(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DateTime.UtcNow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602297E RID: 141694 RVA: 0x00BE14D8 File Offset: 0x00BDF6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Year(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime.Year);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602297F RID: 141695 RVA: 0x00BE152C File Offset: 0x00BDF72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Kind(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)dateTime.Kind);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022980 RID: 141696 RVA: 0x00BE1580 File Offset: 0x00BDF780
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "DateTime");
		if (Lua_System_DateTime.<>f__mg$cache0 == null)
		{
			Lua_System_DateTime.<>f__mg$cache0 = new LuaCSFunction(Lua_System_DateTime.Add);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache0);
		if (Lua_System_DateTime.<>f__mg$cache1 == null)
		{
			Lua_System_DateTime.<>f__mg$cache1 = new LuaCSFunction(Lua_System_DateTime.AddDays);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache1);
		if (Lua_System_DateTime.<>f__mg$cache2 == null)
		{
			Lua_System_DateTime.<>f__mg$cache2 = new LuaCSFunction(Lua_System_DateTime.AddTicks);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache2);
		if (Lua_System_DateTime.<>f__mg$cache3 == null)
		{
			Lua_System_DateTime.<>f__mg$cache3 = new LuaCSFunction(Lua_System_DateTime.AddHours);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache3);
		if (Lua_System_DateTime.<>f__mg$cache4 == null)
		{
			Lua_System_DateTime.<>f__mg$cache4 = new LuaCSFunction(Lua_System_DateTime.AddMilliseconds);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache4);
		if (Lua_System_DateTime.<>f__mg$cache5 == null)
		{
			Lua_System_DateTime.<>f__mg$cache5 = new LuaCSFunction(Lua_System_DateTime.AddMinutes);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache5);
		if (Lua_System_DateTime.<>f__mg$cache6 == null)
		{
			Lua_System_DateTime.<>f__mg$cache6 = new LuaCSFunction(Lua_System_DateTime.AddMonths);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache6);
		if (Lua_System_DateTime.<>f__mg$cache7 == null)
		{
			Lua_System_DateTime.<>f__mg$cache7 = new LuaCSFunction(Lua_System_DateTime.AddSeconds);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache7);
		if (Lua_System_DateTime.<>f__mg$cache8 == null)
		{
			Lua_System_DateTime.<>f__mg$cache8 = new LuaCSFunction(Lua_System_DateTime.AddYears);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache8);
		if (Lua_System_DateTime.<>f__mg$cache9 == null)
		{
			Lua_System_DateTime.<>f__mg$cache9 = new LuaCSFunction(Lua_System_DateTime.CompareTo);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache9);
		if (Lua_System_DateTime.<>f__mg$cacheA == null)
		{
			Lua_System_DateTime.<>f__mg$cacheA = new LuaCSFunction(Lua_System_DateTime.IsDaylightSavingTime);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cacheA);
		if (Lua_System_DateTime.<>f__mg$cacheB == null)
		{
			Lua_System_DateTime.<>f__mg$cacheB = new LuaCSFunction(Lua_System_DateTime.ToBinary);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cacheB);
		if (Lua_System_DateTime.<>f__mg$cacheC == null)
		{
			Lua_System_DateTime.<>f__mg$cacheC = new LuaCSFunction(Lua_System_DateTime.GetDateTimeFormats);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cacheC);
		if (Lua_System_DateTime.<>f__mg$cacheD == null)
		{
			Lua_System_DateTime.<>f__mg$cacheD = new LuaCSFunction(Lua_System_DateTime.GetTypeCode);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cacheD);
		if (Lua_System_DateTime.<>f__mg$cacheE == null)
		{
			Lua_System_DateTime.<>f__mg$cacheE = new LuaCSFunction(Lua_System_DateTime.Subtract);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cacheE);
		if (Lua_System_DateTime.<>f__mg$cacheF == null)
		{
			Lua_System_DateTime.<>f__mg$cacheF = new LuaCSFunction(Lua_System_DateTime.ToFileTime);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cacheF);
		if (Lua_System_DateTime.<>f__mg$cache10 == null)
		{
			Lua_System_DateTime.<>f__mg$cache10 = new LuaCSFunction(Lua_System_DateTime.ToFileTimeUtc);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache10);
		if (Lua_System_DateTime.<>f__mg$cache11 == null)
		{
			Lua_System_DateTime.<>f__mg$cache11 = new LuaCSFunction(Lua_System_DateTime.ToLongDateString);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache11);
		if (Lua_System_DateTime.<>f__mg$cache12 == null)
		{
			Lua_System_DateTime.<>f__mg$cache12 = new LuaCSFunction(Lua_System_DateTime.ToLongTimeString);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache12);
		if (Lua_System_DateTime.<>f__mg$cache13 == null)
		{
			Lua_System_DateTime.<>f__mg$cache13 = new LuaCSFunction(Lua_System_DateTime.ToOADate);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache13);
		if (Lua_System_DateTime.<>f__mg$cache14 == null)
		{
			Lua_System_DateTime.<>f__mg$cache14 = new LuaCSFunction(Lua_System_DateTime.ToShortDateString);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache14);
		if (Lua_System_DateTime.<>f__mg$cache15 == null)
		{
			Lua_System_DateTime.<>f__mg$cache15 = new LuaCSFunction(Lua_System_DateTime.ToShortTimeString);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache15);
		if (Lua_System_DateTime.<>f__mg$cache16 == null)
		{
			Lua_System_DateTime.<>f__mg$cache16 = new LuaCSFunction(Lua_System_DateTime.ToLocalTime);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache16);
		if (Lua_System_DateTime.<>f__mg$cache17 == null)
		{
			Lua_System_DateTime.<>f__mg$cache17 = new LuaCSFunction(Lua_System_DateTime.ToUniversalTime);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache17);
		if (Lua_System_DateTime.<>f__mg$cache18 == null)
		{
			Lua_System_DateTime.<>f__mg$cache18 = new LuaCSFunction(Lua_System_DateTime.StartOfWeek);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache18);
		if (Lua_System_DateTime.<>f__mg$cache19 == null)
		{
			Lua_System_DateTime.<>f__mg$cache19 = new LuaCSFunction(Lua_System_DateTime.Compare_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache19);
		if (Lua_System_DateTime.<>f__mg$cache1A == null)
		{
			Lua_System_DateTime.<>f__mg$cache1A = new LuaCSFunction(Lua_System_DateTime.FromBinary_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache1A);
		if (Lua_System_DateTime.<>f__mg$cache1B == null)
		{
			Lua_System_DateTime.<>f__mg$cache1B = new LuaCSFunction(Lua_System_DateTime.SpecifyKind_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache1B);
		if (Lua_System_DateTime.<>f__mg$cache1C == null)
		{
			Lua_System_DateTime.<>f__mg$cache1C = new LuaCSFunction(Lua_System_DateTime.DaysInMonth_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache1C);
		if (Lua_System_DateTime.<>f__mg$cache1D == null)
		{
			Lua_System_DateTime.<>f__mg$cache1D = new LuaCSFunction(Lua_System_DateTime.FromFileTime_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache1D);
		if (Lua_System_DateTime.<>f__mg$cache1E == null)
		{
			Lua_System_DateTime.<>f__mg$cache1E = new LuaCSFunction(Lua_System_DateTime.FromFileTimeUtc_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache1E);
		if (Lua_System_DateTime.<>f__mg$cache1F == null)
		{
			Lua_System_DateTime.<>f__mg$cache1F = new LuaCSFunction(Lua_System_DateTime.FromOADate_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache1F);
		if (Lua_System_DateTime.<>f__mg$cache20 == null)
		{
			Lua_System_DateTime.<>f__mg$cache20 = new LuaCSFunction(Lua_System_DateTime.IsLeapYear_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache20);
		if (Lua_System_DateTime.<>f__mg$cache21 == null)
		{
			Lua_System_DateTime.<>f__mg$cache21 = new LuaCSFunction(Lua_System_DateTime.Parse_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache21);
		if (Lua_System_DateTime.<>f__mg$cache22 == null)
		{
			Lua_System_DateTime.<>f__mg$cache22 = new LuaCSFunction(Lua_System_DateTime.ParseExact_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache22);
		if (Lua_System_DateTime.<>f__mg$cache23 == null)
		{
			Lua_System_DateTime.<>f__mg$cache23 = new LuaCSFunction(Lua_System_DateTime.TryParse_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache23);
		if (Lua_System_DateTime.<>f__mg$cache24 == null)
		{
			Lua_System_DateTime.<>f__mg$cache24 = new LuaCSFunction(Lua_System_DateTime.TryParseExact_s);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache24);
		if (Lua_System_DateTime.<>f__mg$cache25 == null)
		{
			Lua_System_DateTime.<>f__mg$cache25 = new LuaCSFunction(Lua_System_DateTime.op_Addition);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache25);
		if (Lua_System_DateTime.<>f__mg$cache26 == null)
		{
			Lua_System_DateTime.<>f__mg$cache26 = new LuaCSFunction(Lua_System_DateTime.op_Equality);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache26);
		if (Lua_System_DateTime.<>f__mg$cache27 == null)
		{
			Lua_System_DateTime.<>f__mg$cache27 = new LuaCSFunction(Lua_System_DateTime.op_GreaterThan);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache27);
		if (Lua_System_DateTime.<>f__mg$cache28 == null)
		{
			Lua_System_DateTime.<>f__mg$cache28 = new LuaCSFunction(Lua_System_DateTime.op_GreaterThanOrEqual);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache28);
		if (Lua_System_DateTime.<>f__mg$cache29 == null)
		{
			Lua_System_DateTime.<>f__mg$cache29 = new LuaCSFunction(Lua_System_DateTime.op_Inequality);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache29);
		if (Lua_System_DateTime.<>f__mg$cache2A == null)
		{
			Lua_System_DateTime.<>f__mg$cache2A = new LuaCSFunction(Lua_System_DateTime.op_LessThan);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache2A);
		if (Lua_System_DateTime.<>f__mg$cache2B == null)
		{
			Lua_System_DateTime.<>f__mg$cache2B = new LuaCSFunction(Lua_System_DateTime.op_LessThanOrEqual);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache2B);
		if (Lua_System_DateTime.<>f__mg$cache2C == null)
		{
			Lua_System_DateTime.<>f__mg$cache2C = new LuaCSFunction(Lua_System_DateTime.op_Subtraction);
		}
		LuaObject.addMember(l, Lua_System_DateTime.<>f__mg$cache2C);
		string name = "MaxValue";
		if (Lua_System_DateTime.<>f__mg$cache2D == null)
		{
			Lua_System_DateTime.<>f__mg$cache2D = new LuaCSFunction(Lua_System_DateTime.get_MaxValue);
		}
		LuaObject.addMember(l, name, Lua_System_DateTime.<>f__mg$cache2D, null, false);
		string name2 = "MinValue";
		if (Lua_System_DateTime.<>f__mg$cache2E == null)
		{
			Lua_System_DateTime.<>f__mg$cache2E = new LuaCSFunction(Lua_System_DateTime.get_MinValue);
		}
		LuaObject.addMember(l, name2, Lua_System_DateTime.<>f__mg$cache2E, null, false);
		string name3 = "Date";
		if (Lua_System_DateTime.<>f__mg$cache2F == null)
		{
			Lua_System_DateTime.<>f__mg$cache2F = new LuaCSFunction(Lua_System_DateTime.get_Date);
		}
		LuaObject.addMember(l, name3, Lua_System_DateTime.<>f__mg$cache2F, null, true);
		string name4 = "Month";
		if (Lua_System_DateTime.<>f__mg$cache30 == null)
		{
			Lua_System_DateTime.<>f__mg$cache30 = new LuaCSFunction(Lua_System_DateTime.get_Month);
		}
		LuaObject.addMember(l, name4, Lua_System_DateTime.<>f__mg$cache30, null, true);
		string name5 = "Day";
		if (Lua_System_DateTime.<>f__mg$cache31 == null)
		{
			Lua_System_DateTime.<>f__mg$cache31 = new LuaCSFunction(Lua_System_DateTime.get_Day);
		}
		LuaObject.addMember(l, name5, Lua_System_DateTime.<>f__mg$cache31, null, true);
		string name6 = "DayOfWeek";
		if (Lua_System_DateTime.<>f__mg$cache32 == null)
		{
			Lua_System_DateTime.<>f__mg$cache32 = new LuaCSFunction(Lua_System_DateTime.get_DayOfWeek);
		}
		LuaObject.addMember(l, name6, Lua_System_DateTime.<>f__mg$cache32, null, true);
		string name7 = "DayOfYear";
		if (Lua_System_DateTime.<>f__mg$cache33 == null)
		{
			Lua_System_DateTime.<>f__mg$cache33 = new LuaCSFunction(Lua_System_DateTime.get_DayOfYear);
		}
		LuaObject.addMember(l, name7, Lua_System_DateTime.<>f__mg$cache33, null, true);
		string name8 = "TimeOfDay";
		if (Lua_System_DateTime.<>f__mg$cache34 == null)
		{
			Lua_System_DateTime.<>f__mg$cache34 = new LuaCSFunction(Lua_System_DateTime.get_TimeOfDay);
		}
		LuaObject.addMember(l, name8, Lua_System_DateTime.<>f__mg$cache34, null, true);
		string name9 = "Hour";
		if (Lua_System_DateTime.<>f__mg$cache35 == null)
		{
			Lua_System_DateTime.<>f__mg$cache35 = new LuaCSFunction(Lua_System_DateTime.get_Hour);
		}
		LuaObject.addMember(l, name9, Lua_System_DateTime.<>f__mg$cache35, null, true);
		string name10 = "Minute";
		if (Lua_System_DateTime.<>f__mg$cache36 == null)
		{
			Lua_System_DateTime.<>f__mg$cache36 = new LuaCSFunction(Lua_System_DateTime.get_Minute);
		}
		LuaObject.addMember(l, name10, Lua_System_DateTime.<>f__mg$cache36, null, true);
		string name11 = "Second";
		if (Lua_System_DateTime.<>f__mg$cache37 == null)
		{
			Lua_System_DateTime.<>f__mg$cache37 = new LuaCSFunction(Lua_System_DateTime.get_Second);
		}
		LuaObject.addMember(l, name11, Lua_System_DateTime.<>f__mg$cache37, null, true);
		string name12 = "Millisecond";
		if (Lua_System_DateTime.<>f__mg$cache38 == null)
		{
			Lua_System_DateTime.<>f__mg$cache38 = new LuaCSFunction(Lua_System_DateTime.get_Millisecond);
		}
		LuaObject.addMember(l, name12, Lua_System_DateTime.<>f__mg$cache38, null, true);
		string name13 = "Now";
		if (Lua_System_DateTime.<>f__mg$cache39 == null)
		{
			Lua_System_DateTime.<>f__mg$cache39 = new LuaCSFunction(Lua_System_DateTime.get_Now);
		}
		LuaObject.addMember(l, name13, Lua_System_DateTime.<>f__mg$cache39, null, false);
		string name14 = "Ticks";
		if (Lua_System_DateTime.<>f__mg$cache3A == null)
		{
			Lua_System_DateTime.<>f__mg$cache3A = new LuaCSFunction(Lua_System_DateTime.get_Ticks);
		}
		LuaObject.addMember(l, name14, Lua_System_DateTime.<>f__mg$cache3A, null, true);
		string name15 = "Today";
		if (Lua_System_DateTime.<>f__mg$cache3B == null)
		{
			Lua_System_DateTime.<>f__mg$cache3B = new LuaCSFunction(Lua_System_DateTime.get_Today);
		}
		LuaObject.addMember(l, name15, Lua_System_DateTime.<>f__mg$cache3B, null, false);
		string name16 = "UtcNow";
		if (Lua_System_DateTime.<>f__mg$cache3C == null)
		{
			Lua_System_DateTime.<>f__mg$cache3C = new LuaCSFunction(Lua_System_DateTime.get_UtcNow);
		}
		LuaObject.addMember(l, name16, Lua_System_DateTime.<>f__mg$cache3C, null, false);
		string name17 = "Year";
		if (Lua_System_DateTime.<>f__mg$cache3D == null)
		{
			Lua_System_DateTime.<>f__mg$cache3D = new LuaCSFunction(Lua_System_DateTime.get_Year);
		}
		LuaObject.addMember(l, name17, Lua_System_DateTime.<>f__mg$cache3D, null, true);
		string name18 = "Kind";
		if (Lua_System_DateTime.<>f__mg$cache3E == null)
		{
			Lua_System_DateTime.<>f__mg$cache3E = new LuaCSFunction(Lua_System_DateTime.get_Kind);
		}
		LuaObject.addMember(l, name18, Lua_System_DateTime.<>f__mg$cache3E, null, true);
		if (Lua_System_DateTime.<>f__mg$cache3F == null)
		{
			Lua_System_DateTime.<>f__mg$cache3F = new LuaCSFunction(Lua_System_DateTime.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_System_DateTime.<>f__mg$cache3F, typeof(DateTime), typeof(ValueType));
	}

	// Token: 0x04018718 RID: 100120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018719 RID: 100121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401871A RID: 100122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401871B RID: 100123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401871C RID: 100124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401871D RID: 100125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401871E RID: 100126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401871F RID: 100127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018720 RID: 100128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018721 RID: 100129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018722 RID: 100130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018723 RID: 100131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018724 RID: 100132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018725 RID: 100133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018726 RID: 100134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018727 RID: 100135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018728 RID: 100136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018729 RID: 100137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401872A RID: 100138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401872B RID: 100139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401872C RID: 100140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401872D RID: 100141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401872E RID: 100142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401872F RID: 100143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018730 RID: 100144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018731 RID: 100145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018732 RID: 100146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018733 RID: 100147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018734 RID: 100148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018735 RID: 100149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018736 RID: 100150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018737 RID: 100151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018738 RID: 100152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018739 RID: 100153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401873A RID: 100154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401873B RID: 100155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401873C RID: 100156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401873D RID: 100157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401873E RID: 100158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401873F RID: 100159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04018740 RID: 100160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04018741 RID: 100161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04018742 RID: 100162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04018743 RID: 100163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04018744 RID: 100164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04018745 RID: 100165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04018746 RID: 100166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04018747 RID: 100167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04018748 RID: 100168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04018749 RID: 100169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401874A RID: 100170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401874B RID: 100171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401874C RID: 100172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401874D RID: 100173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401874E RID: 100174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401874F RID: 100175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04018750 RID: 100176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04018751 RID: 100177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04018752 RID: 100178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04018753 RID: 100179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04018754 RID: 100180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04018755 RID: 100181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04018756 RID: 100182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04018757 RID: 100183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;
}
