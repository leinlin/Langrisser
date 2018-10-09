using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001607 RID: 5639
[Preserve]
public class Lua_System_TimeSpan : LuaObject
{
	// Token: 0x060229AE RID: 141742 RVA: 0x00BE5300 File Offset: 0x00BE3500
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
				TimeSpan timeSpan = new TimeSpan(ticks);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, timeSpan);
				result = 2;
			}
			else if (num == 4)
			{
				int hours;
				LuaObject.checkType(l, 2, out hours);
				int minutes;
				LuaObject.checkType(l, 3, out minutes);
				int seconds;
				LuaObject.checkType(l, 4, out seconds);
				TimeSpan timeSpan = new TimeSpan(hours, minutes, seconds);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, timeSpan);
				result = 2;
			}
			else if (num == 5)
			{
				int days;
				LuaObject.checkType(l, 2, out days);
				int hours2;
				LuaObject.checkType(l, 3, out hours2);
				int minutes2;
				LuaObject.checkType(l, 4, out minutes2);
				int seconds2;
				LuaObject.checkType(l, 5, out seconds2);
				TimeSpan timeSpan = new TimeSpan(days, hours2, minutes2, seconds2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, timeSpan);
				result = 2;
			}
			else if (num == 6)
			{
				int days2;
				LuaObject.checkType(l, 2, out days2);
				int hours3;
				LuaObject.checkType(l, 3, out hours3);
				int minutes3;
				LuaObject.checkType(l, 4, out minutes3);
				int seconds3;
				LuaObject.checkType(l, 5, out seconds3);
				int milliseconds;
				LuaObject.checkType(l, 6, out milliseconds);
				TimeSpan timeSpan = new TimeSpan(days2, hours3, minutes3, seconds3, milliseconds);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, timeSpan);
				result = 2;
			}
			else if (num == 0)
			{
				TimeSpan timeSpan = default(TimeSpan);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, timeSpan);
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

	// Token: 0x060229AF RID: 141743 RVA: 0x00BE54B8 File Offset: 0x00BE36B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Add(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			TimeSpan ts;
			LuaObject.checkValueType<TimeSpan>(l, 2, out ts);
			TimeSpan timeSpan2 = timeSpan.Add(ts);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229B0 RID: 141744 RVA: 0x00BE5520 File Offset: 0x00BE3720
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
				TimeSpan timeSpan;
				LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
				object value;
				LuaObject.checkType<object>(l, 2, out value);
				int i = timeSpan.CompareTo(value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(TimeSpan)))
			{
				TimeSpan timeSpan2;
				LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan2);
				TimeSpan value2;
				LuaObject.checkValueType<TimeSpan>(l, 2, out value2);
				int i2 = timeSpan2.CompareTo(value2);
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

	// Token: 0x060229B1 RID: 141745 RVA: 0x00BE5608 File Offset: 0x00BE3808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Duration(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			TimeSpan timeSpan2 = timeSpan.Duration();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229B2 RID: 141746 RVA: 0x00BE5660 File Offset: 0x00BE3860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Negate(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			TimeSpan timeSpan2 = timeSpan.Negate();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229B3 RID: 141747 RVA: 0x00BE56B8 File Offset: 0x00BE38B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Subtract(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			TimeSpan ts;
			LuaObject.checkValueType<TimeSpan>(l, 2, out ts);
			TimeSpan timeSpan2 = timeSpan.Subtract(ts);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229B4 RID: 141748 RVA: 0x00BE5720 File Offset: 0x00BE3920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Compare_s(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan t2;
			LuaObject.checkValueType<TimeSpan>(l, 2, out t2);
			int i = TimeSpan.Compare(t, t2);
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

	// Token: 0x060229B5 RID: 141749 RVA: 0x00BE5780 File Offset: 0x00BE3980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromDays_s(IntPtr l)
	{
		int result;
		try
		{
			double value;
			LuaObject.checkType(l, 1, out value);
			TimeSpan timeSpan = TimeSpan.FromDays(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229B6 RID: 141750 RVA: 0x00BE57D8 File Offset: 0x00BE39D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromHours_s(IntPtr l)
	{
		int result;
		try
		{
			double value;
			LuaObject.checkType(l, 1, out value);
			TimeSpan timeSpan = TimeSpan.FromHours(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229B7 RID: 141751 RVA: 0x00BE5830 File Offset: 0x00BE3A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromMinutes_s(IntPtr l)
	{
		int result;
		try
		{
			double value;
			LuaObject.checkType(l, 1, out value);
			TimeSpan timeSpan = TimeSpan.FromMinutes(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229B8 RID: 141752 RVA: 0x00BE5888 File Offset: 0x00BE3A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromSeconds_s(IntPtr l)
	{
		int result;
		try
		{
			double value;
			LuaObject.checkType(l, 1, out value);
			TimeSpan timeSpan = TimeSpan.FromSeconds(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229B9 RID: 141753 RVA: 0x00BE58E0 File Offset: 0x00BE3AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromMilliseconds_s(IntPtr l)
	{
		int result;
		try
		{
			double value;
			LuaObject.checkType(l, 1, out value);
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229BA RID: 141754 RVA: 0x00BE5938 File Offset: 0x00BE3B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromTicks_s(IntPtr l)
	{
		int result;
		try
		{
			long value;
			LuaObject.checkType(l, 1, out value);
			TimeSpan timeSpan = TimeSpan.FromTicks(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229BB RID: 141755 RVA: 0x00BE5990 File Offset: 0x00BE3B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Parse_s(IntPtr l)
	{
		int result;
		try
		{
			string s;
			LuaObject.checkType(l, 1, out s);
			TimeSpan timeSpan = TimeSpan.Parse(s);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229BC RID: 141756 RVA: 0x00BE59E8 File Offset: 0x00BE3BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryParse_s(IntPtr l)
	{
		int result;
		try
		{
			string s;
			LuaObject.checkType(l, 1, out s);
			TimeSpan timeSpan;
			bool b = TimeSpan.TryParse(s, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, timeSpan);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229BD RID: 141757 RVA: 0x00BE5A4C File Offset: 0x00BE3C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Addition(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan t2;
			LuaObject.checkValueType<TimeSpan>(l, 2, out t2);
			TimeSpan timeSpan = t + t2;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229BE RID: 141758 RVA: 0x00BE5AB0 File Offset: 0x00BE3CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan t2;
			LuaObject.checkValueType<TimeSpan>(l, 2, out t2);
			bool b = t == t2;
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

	// Token: 0x060229BF RID: 141759 RVA: 0x00BE5B10 File Offset: 0x00BE3D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_GreaterThan(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan t2;
			LuaObject.checkValueType<TimeSpan>(l, 2, out t2);
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

	// Token: 0x060229C0 RID: 141760 RVA: 0x00BE5B70 File Offset: 0x00BE3D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_GreaterThanOrEqual(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan t2;
			LuaObject.checkValueType<TimeSpan>(l, 2, out t2);
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

	// Token: 0x060229C1 RID: 141761 RVA: 0x00BE5BD0 File Offset: 0x00BE3DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan t2;
			LuaObject.checkValueType<TimeSpan>(l, 2, out t2);
			bool b = t != t2;
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

	// Token: 0x060229C2 RID: 141762 RVA: 0x00BE5C30 File Offset: 0x00BE3E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_LessThan(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan t2;
			LuaObject.checkValueType<TimeSpan>(l, 2, out t2);
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

	// Token: 0x060229C3 RID: 141763 RVA: 0x00BE5C90 File Offset: 0x00BE3E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_LessThanOrEqual(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan t2;
			LuaObject.checkValueType<TimeSpan>(l, 2, out t2);
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

	// Token: 0x060229C4 RID: 141764 RVA: 0x00BE5CF0 File Offset: 0x00BE3EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Subtraction(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan t2;
			LuaObject.checkValueType<TimeSpan>(l, 2, out t2);
			TimeSpan timeSpan = t - t2;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229C5 RID: 141765 RVA: 0x00BE5D54 File Offset: 0x00BE3F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_UnaryNegation(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan timeSpan = -t;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229C6 RID: 141766 RVA: 0x00BE5DAC File Offset: 0x00BE3FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_UnaryPlus(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan t;
			LuaObject.checkValueType<TimeSpan>(l, 1, out t);
			TimeSpan timeSpan = +t;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229C7 RID: 141767 RVA: 0x00BE5E04 File Offset: 0x00BE4004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TicksPerDay(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 864000000000L);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229C8 RID: 141768 RVA: 0x00BE5E50 File Offset: 0x00BE4050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TicksPerHour(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 36000000000L);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229C9 RID: 141769 RVA: 0x00BE5E9C File Offset: 0x00BE409C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TicksPerMillisecond(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 10000L);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229CA RID: 141770 RVA: 0x00BE5EE4 File Offset: 0x00BE40E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TicksPerMinute(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 600000000L);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229CB RID: 141771 RVA: 0x00BE5F2C File Offset: 0x00BE412C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TicksPerSecond(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 10000000L);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229CC RID: 141772 RVA: 0x00BE5F74 File Offset: 0x00BE4174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MaxValue(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, TimeSpan.MaxValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229CD RID: 141773 RVA: 0x00BE5FC0 File Offset: 0x00BE41C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MinValue(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, TimeSpan.MinValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229CE RID: 141774 RVA: 0x00BE600C File Offset: 0x00BE420C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Zero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, TimeSpan.Zero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229CF RID: 141775 RVA: 0x00BE6058 File Offset: 0x00BE4258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Days(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.Days);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229D0 RID: 141776 RVA: 0x00BE60AC File Offset: 0x00BE42AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Hours(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.Hours);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229D1 RID: 141777 RVA: 0x00BE6100 File Offset: 0x00BE4300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Milliseconds(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.Milliseconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229D2 RID: 141778 RVA: 0x00BE6154 File Offset: 0x00BE4354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Minutes(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.Minutes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229D3 RID: 141779 RVA: 0x00BE61A8 File Offset: 0x00BE43A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Seconds(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.Seconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229D4 RID: 141780 RVA: 0x00BE61FC File Offset: 0x00BE43FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Ticks(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.Ticks);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229D5 RID: 141781 RVA: 0x00BE6250 File Offset: 0x00BE4450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalDays(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.TotalDays);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229D6 RID: 141782 RVA: 0x00BE62A4 File Offset: 0x00BE44A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalHours(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.TotalHours);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229D7 RID: 141783 RVA: 0x00BE62F8 File Offset: 0x00BE44F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalMilliseconds(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.TotalMilliseconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229D8 RID: 141784 RVA: 0x00BE634C File Offset: 0x00BE454C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalMinutes(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.TotalMinutes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229D9 RID: 141785 RVA: 0x00BE63A0 File Offset: 0x00BE45A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalSeconds(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan.TotalSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229DA RID: 141786 RVA: 0x00BE63F4 File Offset: 0x00BE45F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "TimeSpan");
		if (Lua_System_TimeSpan.<>f__mg$cache0 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache0 = new LuaCSFunction(Lua_System_TimeSpan.Add);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache0);
		if (Lua_System_TimeSpan.<>f__mg$cache1 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache1 = new LuaCSFunction(Lua_System_TimeSpan.CompareTo);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache1);
		if (Lua_System_TimeSpan.<>f__mg$cache2 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache2 = new LuaCSFunction(Lua_System_TimeSpan.Duration);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache2);
		if (Lua_System_TimeSpan.<>f__mg$cache3 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache3 = new LuaCSFunction(Lua_System_TimeSpan.Negate);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache3);
		if (Lua_System_TimeSpan.<>f__mg$cache4 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache4 = new LuaCSFunction(Lua_System_TimeSpan.Subtract);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache4);
		if (Lua_System_TimeSpan.<>f__mg$cache5 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache5 = new LuaCSFunction(Lua_System_TimeSpan.Compare_s);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache5);
		if (Lua_System_TimeSpan.<>f__mg$cache6 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache6 = new LuaCSFunction(Lua_System_TimeSpan.FromDays_s);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache6);
		if (Lua_System_TimeSpan.<>f__mg$cache7 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache7 = new LuaCSFunction(Lua_System_TimeSpan.FromHours_s);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache7);
		if (Lua_System_TimeSpan.<>f__mg$cache8 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache8 = new LuaCSFunction(Lua_System_TimeSpan.FromMinutes_s);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache8);
		if (Lua_System_TimeSpan.<>f__mg$cache9 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache9 = new LuaCSFunction(Lua_System_TimeSpan.FromSeconds_s);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache9);
		if (Lua_System_TimeSpan.<>f__mg$cacheA == null)
		{
			Lua_System_TimeSpan.<>f__mg$cacheA = new LuaCSFunction(Lua_System_TimeSpan.FromMilliseconds_s);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cacheA);
		if (Lua_System_TimeSpan.<>f__mg$cacheB == null)
		{
			Lua_System_TimeSpan.<>f__mg$cacheB = new LuaCSFunction(Lua_System_TimeSpan.FromTicks_s);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cacheB);
		if (Lua_System_TimeSpan.<>f__mg$cacheC == null)
		{
			Lua_System_TimeSpan.<>f__mg$cacheC = new LuaCSFunction(Lua_System_TimeSpan.Parse_s);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cacheC);
		if (Lua_System_TimeSpan.<>f__mg$cacheD == null)
		{
			Lua_System_TimeSpan.<>f__mg$cacheD = new LuaCSFunction(Lua_System_TimeSpan.TryParse_s);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cacheD);
		if (Lua_System_TimeSpan.<>f__mg$cacheE == null)
		{
			Lua_System_TimeSpan.<>f__mg$cacheE = new LuaCSFunction(Lua_System_TimeSpan.op_Addition);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cacheE);
		if (Lua_System_TimeSpan.<>f__mg$cacheF == null)
		{
			Lua_System_TimeSpan.<>f__mg$cacheF = new LuaCSFunction(Lua_System_TimeSpan.op_Equality);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cacheF);
		if (Lua_System_TimeSpan.<>f__mg$cache10 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache10 = new LuaCSFunction(Lua_System_TimeSpan.op_GreaterThan);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache10);
		if (Lua_System_TimeSpan.<>f__mg$cache11 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache11 = new LuaCSFunction(Lua_System_TimeSpan.op_GreaterThanOrEqual);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache11);
		if (Lua_System_TimeSpan.<>f__mg$cache12 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache12 = new LuaCSFunction(Lua_System_TimeSpan.op_Inequality);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache12);
		if (Lua_System_TimeSpan.<>f__mg$cache13 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache13 = new LuaCSFunction(Lua_System_TimeSpan.op_LessThan);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache13);
		if (Lua_System_TimeSpan.<>f__mg$cache14 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache14 = new LuaCSFunction(Lua_System_TimeSpan.op_LessThanOrEqual);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache14);
		if (Lua_System_TimeSpan.<>f__mg$cache15 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache15 = new LuaCSFunction(Lua_System_TimeSpan.op_Subtraction);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache15);
		if (Lua_System_TimeSpan.<>f__mg$cache16 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache16 = new LuaCSFunction(Lua_System_TimeSpan.op_UnaryNegation);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache16);
		if (Lua_System_TimeSpan.<>f__mg$cache17 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache17 = new LuaCSFunction(Lua_System_TimeSpan.op_UnaryPlus);
		}
		LuaObject.addMember(l, Lua_System_TimeSpan.<>f__mg$cache17);
		string name = "TicksPerDay";
		if (Lua_System_TimeSpan.<>f__mg$cache18 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache18 = new LuaCSFunction(Lua_System_TimeSpan.get_TicksPerDay);
		}
		LuaObject.addMember(l, name, Lua_System_TimeSpan.<>f__mg$cache18, null, false);
		string name2 = "TicksPerHour";
		if (Lua_System_TimeSpan.<>f__mg$cache19 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache19 = new LuaCSFunction(Lua_System_TimeSpan.get_TicksPerHour);
		}
		LuaObject.addMember(l, name2, Lua_System_TimeSpan.<>f__mg$cache19, null, false);
		string name3 = "TicksPerMillisecond";
		if (Lua_System_TimeSpan.<>f__mg$cache1A == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache1A = new LuaCSFunction(Lua_System_TimeSpan.get_TicksPerMillisecond);
		}
		LuaObject.addMember(l, name3, Lua_System_TimeSpan.<>f__mg$cache1A, null, false);
		string name4 = "TicksPerMinute";
		if (Lua_System_TimeSpan.<>f__mg$cache1B == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache1B = new LuaCSFunction(Lua_System_TimeSpan.get_TicksPerMinute);
		}
		LuaObject.addMember(l, name4, Lua_System_TimeSpan.<>f__mg$cache1B, null, false);
		string name5 = "TicksPerSecond";
		if (Lua_System_TimeSpan.<>f__mg$cache1C == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache1C = new LuaCSFunction(Lua_System_TimeSpan.get_TicksPerSecond);
		}
		LuaObject.addMember(l, name5, Lua_System_TimeSpan.<>f__mg$cache1C, null, false);
		string name6 = "MaxValue";
		if (Lua_System_TimeSpan.<>f__mg$cache1D == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache1D = new LuaCSFunction(Lua_System_TimeSpan.get_MaxValue);
		}
		LuaObject.addMember(l, name6, Lua_System_TimeSpan.<>f__mg$cache1D, null, false);
		string name7 = "MinValue";
		if (Lua_System_TimeSpan.<>f__mg$cache1E == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache1E = new LuaCSFunction(Lua_System_TimeSpan.get_MinValue);
		}
		LuaObject.addMember(l, name7, Lua_System_TimeSpan.<>f__mg$cache1E, null, false);
		string name8 = "Zero";
		if (Lua_System_TimeSpan.<>f__mg$cache1F == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache1F = new LuaCSFunction(Lua_System_TimeSpan.get_Zero);
		}
		LuaObject.addMember(l, name8, Lua_System_TimeSpan.<>f__mg$cache1F, null, false);
		string name9 = "Days";
		if (Lua_System_TimeSpan.<>f__mg$cache20 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache20 = new LuaCSFunction(Lua_System_TimeSpan.get_Days);
		}
		LuaObject.addMember(l, name9, Lua_System_TimeSpan.<>f__mg$cache20, null, true);
		string name10 = "Hours";
		if (Lua_System_TimeSpan.<>f__mg$cache21 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache21 = new LuaCSFunction(Lua_System_TimeSpan.get_Hours);
		}
		LuaObject.addMember(l, name10, Lua_System_TimeSpan.<>f__mg$cache21, null, true);
		string name11 = "Milliseconds";
		if (Lua_System_TimeSpan.<>f__mg$cache22 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache22 = new LuaCSFunction(Lua_System_TimeSpan.get_Milliseconds);
		}
		LuaObject.addMember(l, name11, Lua_System_TimeSpan.<>f__mg$cache22, null, true);
		string name12 = "Minutes";
		if (Lua_System_TimeSpan.<>f__mg$cache23 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache23 = new LuaCSFunction(Lua_System_TimeSpan.get_Minutes);
		}
		LuaObject.addMember(l, name12, Lua_System_TimeSpan.<>f__mg$cache23, null, true);
		string name13 = "Seconds";
		if (Lua_System_TimeSpan.<>f__mg$cache24 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache24 = new LuaCSFunction(Lua_System_TimeSpan.get_Seconds);
		}
		LuaObject.addMember(l, name13, Lua_System_TimeSpan.<>f__mg$cache24, null, true);
		string name14 = "Ticks";
		if (Lua_System_TimeSpan.<>f__mg$cache25 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache25 = new LuaCSFunction(Lua_System_TimeSpan.get_Ticks);
		}
		LuaObject.addMember(l, name14, Lua_System_TimeSpan.<>f__mg$cache25, null, true);
		string name15 = "TotalDays";
		if (Lua_System_TimeSpan.<>f__mg$cache26 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache26 = new LuaCSFunction(Lua_System_TimeSpan.get_TotalDays);
		}
		LuaObject.addMember(l, name15, Lua_System_TimeSpan.<>f__mg$cache26, null, true);
		string name16 = "TotalHours";
		if (Lua_System_TimeSpan.<>f__mg$cache27 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache27 = new LuaCSFunction(Lua_System_TimeSpan.get_TotalHours);
		}
		LuaObject.addMember(l, name16, Lua_System_TimeSpan.<>f__mg$cache27, null, true);
		string name17 = "TotalMilliseconds";
		if (Lua_System_TimeSpan.<>f__mg$cache28 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache28 = new LuaCSFunction(Lua_System_TimeSpan.get_TotalMilliseconds);
		}
		LuaObject.addMember(l, name17, Lua_System_TimeSpan.<>f__mg$cache28, null, true);
		string name18 = "TotalMinutes";
		if (Lua_System_TimeSpan.<>f__mg$cache29 == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache29 = new LuaCSFunction(Lua_System_TimeSpan.get_TotalMinutes);
		}
		LuaObject.addMember(l, name18, Lua_System_TimeSpan.<>f__mg$cache29, null, true);
		string name19 = "TotalSeconds";
		if (Lua_System_TimeSpan.<>f__mg$cache2A == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache2A = new LuaCSFunction(Lua_System_TimeSpan.get_TotalSeconds);
		}
		LuaObject.addMember(l, name19, Lua_System_TimeSpan.<>f__mg$cache2A, null, true);
		if (Lua_System_TimeSpan.<>f__mg$cache2B == null)
		{
			Lua_System_TimeSpan.<>f__mg$cache2B = new LuaCSFunction(Lua_System_TimeSpan.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_System_TimeSpan.<>f__mg$cache2B, typeof(TimeSpan), typeof(ValueType));
	}

	// Token: 0x04018782 RID: 100226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018783 RID: 100227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018784 RID: 100228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018785 RID: 100229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018786 RID: 100230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018787 RID: 100231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018788 RID: 100232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018789 RID: 100233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401878A RID: 100234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401878B RID: 100235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401878C RID: 100236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401878D RID: 100237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401878E RID: 100238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401878F RID: 100239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018790 RID: 100240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018791 RID: 100241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018792 RID: 100242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018793 RID: 100243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018794 RID: 100244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018795 RID: 100245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018796 RID: 100246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018797 RID: 100247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018798 RID: 100248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018799 RID: 100249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401879A RID: 100250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401879B RID: 100251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401879C RID: 100252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401879D RID: 100253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401879E RID: 100254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401879F RID: 100255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040187A0 RID: 100256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040187A1 RID: 100257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040187A2 RID: 100258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040187A3 RID: 100259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040187A4 RID: 100260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040187A5 RID: 100261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040187A6 RID: 100262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040187A7 RID: 100263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040187A8 RID: 100264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040187A9 RID: 100265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040187AA RID: 100266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040187AB RID: 100267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040187AC RID: 100268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040187AD RID: 100269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
