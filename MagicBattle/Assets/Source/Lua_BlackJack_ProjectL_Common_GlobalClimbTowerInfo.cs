using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001226 RID: 4646
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo : LuaObject
{
	// Token: 0x0601818E RID: 98702 RVA: 0x006B1DE4 File Offset: 0x006AFFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerInfo o = new GlobalClimbTowerInfo();
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

	// Token: 0x0601818F RID: 98703 RVA: 0x006B1E2C File Offset: 0x006B002C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Floors(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerInfo globalClimbTowerInfo = (GlobalClimbTowerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalClimbTowerInfo.Floors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018190 RID: 98704 RVA: 0x006B1E80 File Offset: 0x006B0080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Floors(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerInfo globalClimbTowerInfo = (GlobalClimbTowerInfo)LuaObject.checkSelf(l);
			List<GlobalClimbTowerFloor> floors;
			LuaObject.checkType<List<GlobalClimbTowerFloor>>(l, 2, out floors);
			globalClimbTowerInfo.Floors = floors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018191 RID: 98705 RVA: 0x006B1ED8 File Offset: 0x006B00D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ClimbNextWeekFlushTime(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerInfo globalClimbTowerInfo = (GlobalClimbTowerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalClimbTowerInfo.ClimbNextWeekFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018192 RID: 98706 RVA: 0x006B1F30 File Offset: 0x006B0130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ClimbNextWeekFlushTime(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerInfo globalClimbTowerInfo = (GlobalClimbTowerInfo)LuaObject.checkSelf(l);
			DateTime climbNextWeekFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out climbNextWeekFlushTime);
			globalClimbTowerInfo.ClimbNextWeekFlushTime = climbNextWeekFlushTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018193 RID: 98707 RVA: 0x006B1F88 File Offset: 0x006B0188
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GlobalClimbTowerInfo");
		string name = "Floors";
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.get_Floors);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.set_Floors);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache1, true);
		string name2 = "ClimbNextWeekFlushTime";
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.get_ClimbNextWeekFlushTime);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.set_ClimbNextWeekFlushTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.<>f__mg$cache4, typeof(GlobalClimbTowerInfo));
	}

	// Token: 0x0400E724 RID: 59172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E725 RID: 59173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E726 RID: 59174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E727 RID: 59175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E728 RID: 59176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
