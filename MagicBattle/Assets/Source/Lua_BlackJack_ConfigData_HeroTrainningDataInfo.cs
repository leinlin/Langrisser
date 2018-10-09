using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200117C RID: 4476
[Preserve]
public class Lua_BlackJack_ConfigData_HeroTrainningDataInfo : LuaObject
{
	// Token: 0x06016F74 RID: 94068 RVA: 0x0062B39C File Offset: 0x0062959C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningDataInfo o = new HeroTrainningDataInfo();
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

	// Token: 0x06016F75 RID: 94069 RVA: 0x0062B3E4 File Offset: 0x006295E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroTrainningOfWeekDict(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningDataInfo heroTrainningDataInfo = (HeroTrainningDataInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningDataInfo.HeroTrainningOfWeekDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F76 RID: 94070 RVA: 0x0062B438 File Offset: 0x00629638
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroTrainningOfWeekDict(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningDataInfo heroTrainningDataInfo = (HeroTrainningDataInfo)LuaObject.checkSelf(l);
			Dictionary<int, List<ConfigDataHeroTrainningInfo>> heroTrainningOfWeekDict;
			LuaObject.checkType<Dictionary<int, List<ConfigDataHeroTrainningInfo>>>(l, 2, out heroTrainningOfWeekDict);
			heroTrainningDataInfo.HeroTrainningOfWeekDict = heroTrainningOfWeekDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F77 RID: 94071 RVA: 0x0062B490 File Offset: 0x00629690
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.HeroTrainningDataInfo");
		string name = "HeroTrainningOfWeekDict";
		if (Lua_BlackJack_ConfigData_HeroTrainningDataInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_HeroTrainningDataInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_HeroTrainningDataInfo.get_HeroTrainningOfWeekDict);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_HeroTrainningDataInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_HeroTrainningDataInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_HeroTrainningDataInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_HeroTrainningDataInfo.set_HeroTrainningOfWeekDict);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_HeroTrainningDataInfo.<>f__mg$cache1, true);
		if (Lua_BlackJack_ConfigData_HeroTrainningDataInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_HeroTrainningDataInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_HeroTrainningDataInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_HeroTrainningDataInfo.<>f__mg$cache2, typeof(HeroTrainningDataInfo));
	}

	// Token: 0x0400D65E RID: 54878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D65F RID: 54879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D660 RID: 54880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
