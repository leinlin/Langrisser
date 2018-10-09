using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001171 RID: 4465
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo : LuaObject
{
	// Token: 0x06016E66 RID: 93798 RVA: 0x00623CC8 File Offset: 0x00621EC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingRoomInfo o = new ConfigDataTrainingRoomInfo();
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

	// Token: 0x06016E67 RID: 93799 RVA: 0x00623D10 File Offset: 0x00621F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalLevelupExpSteps(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingRoomInfo configDataTrainingRoomInfo = (ConfigDataTrainingRoomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingRoomInfo.m_totalLevelupExpSteps);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E68 RID: 93800 RVA: 0x00623D64 File Offset: 0x00621F64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_totalLevelupExpSteps(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingRoomInfo configDataTrainingRoomInfo = (ConfigDataTrainingRoomInfo)LuaObject.checkSelf(l);
			List<int> totalLevelupExpSteps;
			LuaObject.checkType<List<int>>(l, 2, out totalLevelupExpSteps);
			configDataTrainingRoomInfo.m_totalLevelupExpSteps = totalLevelupExpSteps;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E69 RID: 93801 RVA: 0x00623DBC File Offset: 0x00621FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingRoomInfo configDataTrainingRoomInfo = (ConfigDataTrainingRoomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingRoomInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E6A RID: 93802 RVA: 0x00623E10 File Offset: 0x00622010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingRoomInfo configDataTrainingRoomInfo = (ConfigDataTrainingRoomInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataTrainingRoomInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E6B RID: 93803 RVA: 0x00623E68 File Offset: 0x00622068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingRoomInfo configDataTrainingRoomInfo = (ConfigDataTrainingRoomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingRoomInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E6C RID: 93804 RVA: 0x00623EBC File Offset: 0x006220BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingRoomInfo configDataTrainingRoomInfo = (ConfigDataTrainingRoomInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataTrainingRoomInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E6D RID: 93805 RVA: 0x00623F14 File Offset: 0x00622114
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingRoomInfo configDataTrainingRoomInfo = (ConfigDataTrainingRoomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingRoomInfo.SoldierType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E6E RID: 93806 RVA: 0x00623F68 File Offset: 0x00622168
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LevelToUnlock(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingRoomInfo configDataTrainingRoomInfo = (ConfigDataTrainingRoomInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingRoomInfo.LevelToUnlock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E6F RID: 93807 RVA: 0x00623FBC File Offset: 0x006221BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LevelToUnlock(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingRoomInfo configDataTrainingRoomInfo = (ConfigDataTrainingRoomInfo)LuaObject.checkSelf(l);
			int levelToUnlock;
			LuaObject.checkType(l, 2, out levelToUnlock);
			configDataTrainingRoomInfo.LevelToUnlock = levelToUnlock;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E70 RID: 93808 RVA: 0x00624014 File Offset: 0x00622214
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataTrainingRoomInfo");
		string name = "m_totalLevelupExpSteps";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.get_m_totalLevelupExpSteps);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.set_m_totalLevelupExpSteps);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache5, true);
		string name4 = "SoldierType";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.get_SoldierType);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache6, null, true);
		string name5 = "LevelToUnlock";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.get_LevelToUnlock);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache7;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.set_LevelToUnlock);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache8, true);
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.<>f__mg$cache9, typeof(ConfigDataTrainingRoomInfo));
	}

	// Token: 0x0400D566 RID: 54630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D567 RID: 54631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D568 RID: 54632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D569 RID: 54633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D56A RID: 54634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D56B RID: 54635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D56C RID: 54636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D56D RID: 54637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D56E RID: 54638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D56F RID: 54639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
