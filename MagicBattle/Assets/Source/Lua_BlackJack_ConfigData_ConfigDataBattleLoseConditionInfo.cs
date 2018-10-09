using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200113D RID: 4413
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo : LuaObject
{
	// Token: 0x06016580 RID: 91520 RVA: 0x005E2EB0 File Offset: 0x005E10B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleLoseConditionInfo o = new ConfigDataBattleLoseConditionInfo();
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

	// Token: 0x06016581 RID: 91521 RVA: 0x005E2EF8 File Offset: 0x005E10F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Param1FirstValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleLoseConditionInfo configDataBattleLoseConditionInfo = (ConfigDataBattleLoseConditionInfo)LuaObject.checkSelf(l);
			int i = configDataBattleLoseConditionInfo.Param1FirstValue();
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

	// Token: 0x06016582 RID: 91522 RVA: 0x005E2F4C File Offset: 0x005E114C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Param2FirstValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleLoseConditionInfo configDataBattleLoseConditionInfo = (ConfigDataBattleLoseConditionInfo)LuaObject.checkSelf(l);
			int i = configDataBattleLoseConditionInfo.Param2FirstValue();
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

	// Token: 0x06016583 RID: 91523 RVA: 0x005E2FA0 File Offset: 0x005E11A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleLoseConditionInfo configDataBattleLoseConditionInfo = (ConfigDataBattleLoseConditionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleLoseConditionInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016584 RID: 91524 RVA: 0x005E2FF4 File Offset: 0x005E11F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleLoseConditionInfo configDataBattleLoseConditionInfo = (ConfigDataBattleLoseConditionInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBattleLoseConditionInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016585 RID: 91525 RVA: 0x005E304C File Offset: 0x005E124C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoseConditionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleLoseConditionInfo configDataBattleLoseConditionInfo = (ConfigDataBattleLoseConditionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBattleLoseConditionInfo.LoseConditionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016586 RID: 91526 RVA: 0x005E30A0 File Offset: 0x005E12A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LoseConditionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleLoseConditionInfo configDataBattleLoseConditionInfo = (ConfigDataBattleLoseConditionInfo)LuaObject.checkSelf(l);
			BattleLoseConditionType loseConditionType;
			LuaObject.checkEnum<BattleLoseConditionType>(l, 2, out loseConditionType);
			configDataBattleLoseConditionInfo.LoseConditionType = loseConditionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016587 RID: 91527 RVA: 0x005E30F8 File Offset: 0x005E12F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Param1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleLoseConditionInfo configDataBattleLoseConditionInfo = (ConfigDataBattleLoseConditionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleLoseConditionInfo.Param1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016588 RID: 91528 RVA: 0x005E314C File Offset: 0x005E134C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleLoseConditionInfo configDataBattleLoseConditionInfo = (ConfigDataBattleLoseConditionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleLoseConditionInfo.Param2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016589 RID: 91529 RVA: 0x005E31A0 File Offset: 0x005E13A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleLoseConditionInfo configDataBattleLoseConditionInfo = (ConfigDataBattleLoseConditionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleLoseConditionInfo.Param3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601658A RID: 91530 RVA: 0x005E31F4 File Offset: 0x005E13F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBattleLoseConditionInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.Param1FirstValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.Param2FirstValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache1);
		string name = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.get_ID);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.set_ID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache3, true);
		string name2 = "LoseConditionType";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.get_LoseConditionType);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.set_LoseConditionType);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache5, true);
		string name3 = "Param1";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.get_Param1);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache6, null, true);
		string name4 = "Param2";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.get_Param2);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache7, null, true);
		string name5 = "Param3";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.get_Param3);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache8, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.<>f__mg$cache9, typeof(ConfigDataBattleLoseConditionInfo));
	}

	// Token: 0x0400CCE8 RID: 52456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CCE9 RID: 52457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CCEA RID: 52458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CCEB RID: 52459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CCEC RID: 52460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CCED RID: 52461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CCEE RID: 52462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CCEF RID: 52463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CCF0 RID: 52464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CCF1 RID: 52465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
