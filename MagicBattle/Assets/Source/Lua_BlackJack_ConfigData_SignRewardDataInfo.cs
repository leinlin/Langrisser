using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001187 RID: 4487
[Preserve]
public class Lua_BlackJack_ConfigData_SignRewardDataInfo : LuaObject
{
	// Token: 0x06016FBD RID: 94141 RVA: 0x0062CD20 File Offset: 0x0062AF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SignRewardDataInfo o = new SignRewardDataInfo();
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

	// Token: 0x06016FBE RID: 94142 RVA: 0x0062CD68 File Offset: 0x0062AF68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MonthRewards(IntPtr l)
	{
		int result;
		try
		{
			SignRewardDataInfo signRewardDataInfo = (SignRewardDataInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardDataInfo.MonthRewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FBF RID: 94143 RVA: 0x0062CDBC File Offset: 0x0062AFBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MonthRewards(IntPtr l)
	{
		int result;
		try
		{
			SignRewardDataInfo signRewardDataInfo = (SignRewardDataInfo)LuaObject.checkSelf(l);
			Dictionary<int, MonthSignRewardInfo> monthRewards;
			LuaObject.checkType<Dictionary<int, MonthSignRewardInfo>>(l, 2, out monthRewards);
			signRewardDataInfo.MonthRewards = monthRewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FC0 RID: 94144 RVA: 0x0062CE14 File Offset: 0x0062B014
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.SignRewardDataInfo");
		string name = "MonthRewards";
		if (Lua_BlackJack_ConfigData_SignRewardDataInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_SignRewardDataInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_SignRewardDataInfo.get_MonthRewards);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_SignRewardDataInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_SignRewardDataInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_SignRewardDataInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_SignRewardDataInfo.set_MonthRewards);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_SignRewardDataInfo.<>f__mg$cache1, true);
		if (Lua_BlackJack_ConfigData_SignRewardDataInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_SignRewardDataInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_SignRewardDataInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_SignRewardDataInfo.<>f__mg$cache2, typeof(SignRewardDataInfo));
	}

	// Token: 0x0400D691 RID: 54929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D692 RID: 54930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D693 RID: 54931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
