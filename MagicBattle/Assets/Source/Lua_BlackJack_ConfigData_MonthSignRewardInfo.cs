using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200117F RID: 4479
[Preserve]
public class Lua_BlackJack_ConfigData_MonthSignRewardInfo : LuaObject
{
	// Token: 0x06016F85 RID: 94085 RVA: 0x0062B928 File Offset: 0x00629B28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MonthSignRewardInfo o = new MonthSignRewardInfo();
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

	// Token: 0x06016F86 RID: 94086 RVA: 0x0062B970 File Offset: 0x00629B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Month(IntPtr l)
	{
		int result;
		try
		{
			MonthSignRewardInfo monthSignRewardInfo = (MonthSignRewardInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthSignRewardInfo.Month);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F87 RID: 94087 RVA: 0x0062B9C4 File Offset: 0x00629BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Month(IntPtr l)
	{
		int result;
		try
		{
			MonthSignRewardInfo monthSignRewardInfo = (MonthSignRewardInfo)LuaObject.checkSelf(l);
			int month;
			LuaObject.checkType(l, 2, out month);
			monthSignRewardInfo.Month = month;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F88 RID: 94088 RVA: 0x0062BA1C File Offset: 0x00629C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SignRewards(IntPtr l)
	{
		int result;
		try
		{
			MonthSignRewardInfo monthSignRewardInfo = (MonthSignRewardInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthSignRewardInfo.SignRewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F89 RID: 94089 RVA: 0x0062BA70 File Offset: 0x00629C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SignRewards(IntPtr l)
	{
		int result;
		try
		{
			MonthSignRewardInfo monthSignRewardInfo = (MonthSignRewardInfo)LuaObject.checkSelf(l);
			Dictionary<int, List<Goods>> signRewards;
			LuaObject.checkType<Dictionary<int, List<Goods>>>(l, 2, out signRewards);
			monthSignRewardInfo.SignRewards = signRewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F8A RID: 94090 RVA: 0x0062BAC8 File Offset: 0x00629CC8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.MonthSignRewardInfo");
		string name = "Month";
		if (Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_MonthSignRewardInfo.get_Month);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_MonthSignRewardInfo.set_Month);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache1, true);
		string name2 = "SignRewards";
		if (Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_MonthSignRewardInfo.get_SignRewards);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_MonthSignRewardInfo.set_SignRewards);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache3, true);
		if (Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_MonthSignRewardInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_MonthSignRewardInfo.<>f__mg$cache4, typeof(MonthSignRewardInfo));
	}

	// Token: 0x0400D669 RID: 54889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D66A RID: 54890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D66B RID: 54891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D66C RID: 54892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D66D RID: 54893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
