using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200113F RID: 4415
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo : LuaObject
{
	// Token: 0x060165A4 RID: 91556 RVA: 0x005E3E28 File Offset: 0x005E2028
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleWinConditionInfo o = new ConfigDataBattleWinConditionInfo();
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

	// Token: 0x060165A5 RID: 91557 RVA: 0x005E3E70 File Offset: 0x005E2070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Param1FirstValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleWinConditionInfo configDataBattleWinConditionInfo = (ConfigDataBattleWinConditionInfo)LuaObject.checkSelf(l);
			int i = configDataBattleWinConditionInfo.Param1FirstValue();
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

	// Token: 0x060165A6 RID: 91558 RVA: 0x005E3EC4 File Offset: 0x005E20C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Param2FirstValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleWinConditionInfo configDataBattleWinConditionInfo = (ConfigDataBattleWinConditionInfo)LuaObject.checkSelf(l);
			int i = configDataBattleWinConditionInfo.Param2FirstValue();
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

	// Token: 0x060165A7 RID: 91559 RVA: 0x005E3F18 File Offset: 0x005E2118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleWinConditionInfo configDataBattleWinConditionInfo = (ConfigDataBattleWinConditionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleWinConditionInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165A8 RID: 91560 RVA: 0x005E3F6C File Offset: 0x005E216C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleWinConditionInfo configDataBattleWinConditionInfo = (ConfigDataBattleWinConditionInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBattleWinConditionInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165A9 RID: 91561 RVA: 0x005E3FC4 File Offset: 0x005E21C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WinConditionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleWinConditionInfo configDataBattleWinConditionInfo = (ConfigDataBattleWinConditionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBattleWinConditionInfo.WinConditionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165AA RID: 91562 RVA: 0x005E4018 File Offset: 0x005E2218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WinConditionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleWinConditionInfo configDataBattleWinConditionInfo = (ConfigDataBattleWinConditionInfo)LuaObject.checkSelf(l);
			BattleWinConditionType winConditionType;
			LuaObject.checkEnum<BattleWinConditionType>(l, 2, out winConditionType);
			configDataBattleWinConditionInfo.WinConditionType = winConditionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165AB RID: 91563 RVA: 0x005E4070 File Offset: 0x005E2270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleWinConditionInfo configDataBattleWinConditionInfo = (ConfigDataBattleWinConditionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleWinConditionInfo.Param1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165AC RID: 91564 RVA: 0x005E40C4 File Offset: 0x005E22C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleWinConditionInfo configDataBattleWinConditionInfo = (ConfigDataBattleWinConditionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleWinConditionInfo.Param2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165AD RID: 91565 RVA: 0x005E4118 File Offset: 0x005E2318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleWinConditionInfo configDataBattleWinConditionInfo = (ConfigDataBattleWinConditionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleWinConditionInfo.Param3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165AE RID: 91566 RVA: 0x005E416C File Offset: 0x005E236C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBattleWinConditionInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.Param1FirstValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.Param2FirstValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache1);
		string name = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.get_ID);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.set_ID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache3, true);
		string name2 = "WinConditionType";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.get_WinConditionType);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.set_WinConditionType);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache5, true);
		string name3 = "Param1";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.get_Param1);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache6, null, true);
		string name4 = "Param2";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.get_Param2);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache7, null, true);
		string name5 = "Param3";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.get_Param3);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache8, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.<>f__mg$cache9, typeof(ConfigDataBattleWinConditionInfo));
	}

	// Token: 0x0400CD08 RID: 52488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CD09 RID: 52489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CD0A RID: 52490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CD0B RID: 52491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CD0C RID: 52492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CD0D RID: 52493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CD0E RID: 52494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CD0F RID: 52495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CD10 RID: 52496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CD11 RID: 52497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
