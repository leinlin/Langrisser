using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001189 RID: 4489
[Preserve]
public class Lua_BlackJack_ConfigData_ThearchyTrialDataInfo : LuaObject
{
	// Token: 0x06016FC7 RID: 94151 RVA: 0x0062D040 File Offset: 0x0062B240
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialDataInfo o = new ThearchyTrialDataInfo();
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

	// Token: 0x06016FC8 RID: 94152 RVA: 0x0062D088 File Offset: 0x0062B288
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ThearchyTrailOfWeekDict(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialDataInfo thearchyTrialDataInfo = (ThearchyTrialDataInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyTrialDataInfo.ThearchyTrailOfWeekDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FC9 RID: 94153 RVA: 0x0062D0DC File Offset: 0x0062B2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ThearchyTrailOfWeekDict(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialDataInfo thearchyTrialDataInfo = (ThearchyTrialDataInfo)LuaObject.checkSelf(l);
			Dictionary<int, List<ConfigDataThearchyTrialInfo>> thearchyTrailOfWeekDict;
			LuaObject.checkType<Dictionary<int, List<ConfigDataThearchyTrialInfo>>>(l, 2, out thearchyTrailOfWeekDict);
			thearchyTrialDataInfo.ThearchyTrailOfWeekDict = thearchyTrailOfWeekDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FCA RID: 94154 RVA: 0x0062D134 File Offset: 0x0062B334
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ThearchyTrialDataInfo");
		string name = "ThearchyTrailOfWeekDict";
		if (Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.get_ThearchyTrailOfWeekDict);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.set_ThearchyTrailOfWeekDict);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.<>f__mg$cache1, true);
		if (Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.<>f__mg$cache2, typeof(ThearchyTrialDataInfo));
	}

	// Token: 0x0400D697 RID: 54935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D698 RID: 54936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D699 RID: 54937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
