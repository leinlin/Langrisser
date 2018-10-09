using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001768 RID: 5992
[Preserve]
public class Lua_UnityEngine_RangeInt : LuaObject
{
	// Token: 0x0602393B RID: 145723 RVA: 0x00C6D7DC File Offset: 0x00C6B9DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int start;
			LuaObject.checkType(l, 2, out start);
			int length;
			LuaObject.checkType(l, 3, out length);
			RangeInt rangeInt = new RangeInt(start, length);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rangeInt);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602393C RID: 145724 RVA: 0x00C6D844 File Offset: 0x00C6BA44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_start(IntPtr l)
	{
		int result;
		try
		{
			RangeInt rangeInt;
			LuaObject.checkValueType<RangeInt>(l, 1, out rangeInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rangeInt.start);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602393D RID: 145725 RVA: 0x00C6D898 File Offset: 0x00C6BA98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_start(IntPtr l)
	{
		int result;
		try
		{
			RangeInt rangeInt;
			LuaObject.checkValueType<RangeInt>(l, 1, out rangeInt);
			int start;
			LuaObject.checkType(l, 2, out start);
			rangeInt.start = start;
			LuaObject.setBack(l, rangeInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602393E RID: 145726 RVA: 0x00C6D8FC File Offset: 0x00C6BAFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_length(IntPtr l)
	{
		int result;
		try
		{
			RangeInt rangeInt;
			LuaObject.checkValueType<RangeInt>(l, 1, out rangeInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rangeInt.length);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602393F RID: 145727 RVA: 0x00C6D950 File Offset: 0x00C6BB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_length(IntPtr l)
	{
		int result;
		try
		{
			RangeInt rangeInt;
			LuaObject.checkValueType<RangeInt>(l, 1, out rangeInt);
			int length;
			LuaObject.checkType(l, 2, out length);
			rangeInt.length = length;
			LuaObject.setBack(l, rangeInt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023940 RID: 145728 RVA: 0x00C6D9B4 File Offset: 0x00C6BBB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_end(IntPtr l)
	{
		int result;
		try
		{
			RangeInt rangeInt;
			LuaObject.checkValueType<RangeInt>(l, 1, out rangeInt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rangeInt.end);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023941 RID: 145729 RVA: 0x00C6DA08 File Offset: 0x00C6BC08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RangeInt");
		string name = "start";
		if (Lua_UnityEngine_RangeInt.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RangeInt.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RangeInt.get_start);
		}
		LuaCSFunction get = Lua_UnityEngine_RangeInt.<>f__mg$cache0;
		if (Lua_UnityEngine_RangeInt.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RangeInt.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RangeInt.set_start);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_RangeInt.<>f__mg$cache1, true);
		string name2 = "length";
		if (Lua_UnityEngine_RangeInt.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RangeInt.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RangeInt.get_length);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RangeInt.<>f__mg$cache2;
		if (Lua_UnityEngine_RangeInt.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RangeInt.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RangeInt.set_length);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_RangeInt.<>f__mg$cache3, true);
		string name3 = "end";
		if (Lua_UnityEngine_RangeInt.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RangeInt.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RangeInt.get_end);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_RangeInt.<>f__mg$cache4, null, true);
		if (Lua_UnityEngine_RangeInt.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RangeInt.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RangeInt.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RangeInt.<>f__mg$cache5, typeof(RangeInt), typeof(ValueType));
	}

	// Token: 0x040196C9 RID: 104137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040196CA RID: 104138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040196CB RID: 104139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040196CC RID: 104140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040196CD RID: 104141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040196CE RID: 104142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
