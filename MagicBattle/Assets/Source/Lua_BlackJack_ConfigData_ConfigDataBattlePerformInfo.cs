using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200113E RID: 4414
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo : LuaObject
{
	// Token: 0x0601658C RID: 91532 RVA: 0x005E3394 File Offset: 0x005E1594
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo o = new ConfigDataBattlePerformInfo();
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

	// Token: 0x0601658D RID: 91533 RVA: 0x005E33DC File Offset: 0x005E15DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prevPerformInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.m_prevPerformInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601658E RID: 91534 RVA: 0x005E3430 File Offset: 0x005E1630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_prevPerformInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo prevPerformInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out prevPerformInfo);
			configDataBattlePerformInfo.m_prevPerformInfo = prevPerformInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601658F RID: 91535 RVA: 0x005E3488 File Offset: 0x005E1688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextPerformInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.m_nextPerformInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016590 RID: 91536 RVA: 0x005E34DC File Offset: 0x005E16DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_nextPerformInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo nextPerformInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out nextPerformInfo);
			configDataBattlePerformInfo.m_nextPerformInfo = nextPerformInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016591 RID: 91537 RVA: 0x005E3534 File Offset: 0x005E1734
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016592 RID: 91538 RVA: 0x005E3588 File Offset: 0x005E1788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBattlePerformInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016593 RID: 91539 RVA: 0x005E35E0 File Offset: 0x005E17E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016594 RID: 91540 RVA: 0x005E3634 File Offset: 0x005E1834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataBattlePerformInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016595 RID: 91541 RVA: 0x005E368C File Offset: 0x005E188C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextPerform_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.NextPerform_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016596 RID: 91542 RVA: 0x005E36E0 File Offset: 0x005E18E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextPerform_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			int nextPerform_ID;
			LuaObject.checkType(l, 2, out nextPerform_ID);
			configDataBattlePerformInfo.NextPerform_ID = nextPerform_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016597 RID: 91543 RVA: 0x005E3738 File Offset: 0x005E1938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PerformType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBattlePerformInfo.PerformType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016598 RID: 91544 RVA: 0x005E378C File Offset: 0x005E198C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PerformType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			BattlePerformType performType;
			LuaObject.checkEnum<BattlePerformType>(l, 2, out performType);
			configDataBattlePerformInfo.PerformType = performType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016599 RID: 91545 RVA: 0x005E37E4 File Offset: 0x005E19E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.Param1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601659A RID: 91546 RVA: 0x005E3838 File Offset: 0x005E1A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Param1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			int param;
			LuaObject.checkType(l, 2, out param);
			configDataBattlePerformInfo.Param1 = param;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601659B RID: 91547 RVA: 0x005E3890 File Offset: 0x005E1A90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Param2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.Param2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601659C RID: 91548 RVA: 0x005E38E4 File Offset: 0x005E1AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Param2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			int param;
			LuaObject.checkType(l, 2, out param);
			configDataBattlePerformInfo.Param2 = param;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601659D RID: 91549 RVA: 0x005E393C File Offset: 0x005E1B3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Param3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.Param3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601659E RID: 91550 RVA: 0x005E3990 File Offset: 0x005E1B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param4(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.Param4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601659F RID: 91551 RVA: 0x005E39E4 File Offset: 0x005E1BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param5(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.Param5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165A0 RID: 91552 RVA: 0x005E3A38 File Offset: 0x005E1C38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Param5(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			string param;
			LuaObject.checkType(l, 2, out param);
			configDataBattlePerformInfo.Param5 = param;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165A1 RID: 91553 RVA: 0x005E3A90 File Offset: 0x005E1C90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Param6(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattlePerformInfo configDataBattlePerformInfo = (ConfigDataBattlePerformInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattlePerformInfo.Param6);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165A2 RID: 91554 RVA: 0x005E3AE4 File Offset: 0x005E1CE4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBattlePerformInfo");
		string name = "m_prevPerformInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_m_prevPerformInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.set_m_prevPerformInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache1, true);
		string name2 = "m_nextPerformInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_m_nextPerformInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.set_m_nextPerformInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache5, true);
		string name4 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache7, true);
		string name5 = "NextPerform_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_NextPerform_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.set_NextPerform_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache9, true);
		string name6 = "PerformType";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_PerformType);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.set_PerformType);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheB, true);
		string name7 = "Param1";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_Param1);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.set_Param1);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheD, true);
		string name8 = "Param2";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_Param2);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.set_Param2);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cacheF, true);
		string name9 = "Param3";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_Param3);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache10, null, true);
		string name10 = "Param4";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_Param4);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache11, null, true);
		string name11 = "Param5";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_Param5);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.set_Param5);
		}
		LuaObject.addMember(l, name11, get9, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache13, true);
		string name12 = "Param6";
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.get_Param6);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache14, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.<>f__mg$cache15, typeof(ConfigDataBattlePerformInfo));
	}

	// Token: 0x0400CCF2 RID: 52466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CCF3 RID: 52467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CCF4 RID: 52468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CCF5 RID: 52469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CCF6 RID: 52470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CCF7 RID: 52471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CCF8 RID: 52472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CCF9 RID: 52473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CCFA RID: 52474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CCFB RID: 52475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CCFC RID: 52476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CCFD RID: 52477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CCFE RID: 52478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CCFF RID: 52479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CD00 RID: 52480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CD01 RID: 52481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CD02 RID: 52482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CD03 RID: 52483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CD04 RID: 52484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CD05 RID: 52485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CD06 RID: 52486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CD07 RID: 52487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
