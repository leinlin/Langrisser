using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001186 RID: 4486
[Preserve]
public class Lua_BlackJack_ConfigData_RealTimePVPAvailableTime : LuaObject
{
	// Token: 0x06016FB6 RID: 94134 RVA: 0x0062CA9C File Offset: 0x0062AC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPAvailableTime o = new RealTimePVPAvailableTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FB7 RID: 94135 RVA: 0x0062CAE4 File Offset: 0x0062ACE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Start(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPAvailableTime realTimePVPAvailableTime = (RealTimePVPAvailableTime)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPAvailableTime.Start);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FB8 RID: 94136 RVA: 0x0062CB3C File Offset: 0x0062AD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Start(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPAvailableTime realTimePVPAvailableTime = (RealTimePVPAvailableTime)LuaObject.checkSelf(l);
			TimeSpan start;
			LuaObject.checkValueType<TimeSpan>(l, 2, out start);
			realTimePVPAvailableTime.Start = start;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FB9 RID: 94137 RVA: 0x0062CB94 File Offset: 0x0062AD94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_End(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPAvailableTime realTimePVPAvailableTime = (RealTimePVPAvailableTime)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPAvailableTime.End);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FBA RID: 94138 RVA: 0x0062CBEC File Offset: 0x0062ADEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_End(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPAvailableTime realTimePVPAvailableTime = (RealTimePVPAvailableTime)LuaObject.checkSelf(l);
			TimeSpan end;
			LuaObject.checkValueType<TimeSpan>(l, 2, out end);
			realTimePVPAvailableTime.End = end;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FBB RID: 94139 RVA: 0x0062CC44 File Offset: 0x0062AE44
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.RealTimePVPAvailableTime");
		string name = "Start";
		if (Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.get_Start);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.set_Start);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache1, true);
		string name2 = "End";
		if (Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.get_End);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.set_End);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache3, true);
		if (Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.<>f__mg$cache4, typeof(RealTimePVPAvailableTime));
	}

	// Token: 0x0400D68C RID: 54924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D68D RID: 54925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D68E RID: 54926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D68F RID: 54927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D690 RID: 54928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
