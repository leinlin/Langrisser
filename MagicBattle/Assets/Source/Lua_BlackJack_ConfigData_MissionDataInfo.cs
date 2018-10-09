using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200117E RID: 4478
[Preserve]
public class Lua_BlackJack_ConfigData_MissionDataInfo : LuaObject
{
	// Token: 0x06016F7E RID: 94078 RVA: 0x0062B6AC File Offset: 0x006298AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MissionDataInfo o = new MissionDataInfo();
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

	// Token: 0x06016F7F RID: 94079 RVA: 0x0062B6F4 File Offset: 0x006298F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			MissionDataInfo missionDataInfo = (MissionDataInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionDataInfo.EverydayMissions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F80 RID: 94080 RVA: 0x0062B748 File Offset: 0x00629948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			MissionDataInfo missionDataInfo = (MissionDataInfo)LuaObject.checkSelf(l);
			List<ConfigDataMissionInfo> everydayMissions;
			LuaObject.checkType<List<ConfigDataMissionInfo>>(l, 2, out everydayMissions);
			missionDataInfo.EverydayMissions = everydayMissions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F81 RID: 94081 RVA: 0x0062B7A0 File Offset: 0x006299A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OneOffMissions(IntPtr l)
	{
		int result;
		try
		{
			MissionDataInfo missionDataInfo = (MissionDataInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionDataInfo.OneOffMissions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F82 RID: 94082 RVA: 0x0062B7F4 File Offset: 0x006299F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OneOffMissions(IntPtr l)
	{
		int result;
		try
		{
			MissionDataInfo missionDataInfo = (MissionDataInfo)LuaObject.checkSelf(l);
			List<ConfigDataMissionInfo> oneOffMissions;
			LuaObject.checkType<List<ConfigDataMissionInfo>>(l, 2, out oneOffMissions);
			missionDataInfo.OneOffMissions = oneOffMissions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F83 RID: 94083 RVA: 0x0062B84C File Offset: 0x00629A4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.MissionDataInfo");
		string name = "EverydayMissions";
		if (Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_MissionDataInfo.get_EverydayMissions);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_MissionDataInfo.set_EverydayMissions);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache1, true);
		string name2 = "OneOffMissions";
		if (Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_MissionDataInfo.get_OneOffMissions);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_MissionDataInfo.set_OneOffMissions);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache3, true);
		if (Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_MissionDataInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_MissionDataInfo.<>f__mg$cache4, typeof(MissionDataInfo));
	}

	// Token: 0x0400D664 RID: 54884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D665 RID: 54885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D666 RID: 54886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D667 RID: 54887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D668 RID: 54888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
