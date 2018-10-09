using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200122A RID: 4650
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GoodsNextFlushCaculateTools : LuaObject
{
	// Token: 0x060181B7 RID: 98743 RVA: 0x006B2E90 File Offset: 0x006B1090
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GoodsNextFlushCaculateTools o = new GoodsNextFlushCaculateTools();
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

	// Token: 0x060181B8 RID: 98744 RVA: 0x006B2ED8 File Offset: 0x006B10D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CaculateNextFlushTime_s(IntPtr l)
	{
		int result;
		try
		{
			BuyRuleType rule;
			LuaObject.checkEnum<BuyRuleType>(l, 1, out rule);
			int param;
			LuaObject.checkType(l, 2, out param);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			long oldNextFlushTimeTicks;
			LuaObject.checkType(l, 4, out oldNextFlushTimeTicks);
			DateTime dateTime = GoodsNextFlushCaculateTools.CaculateNextFlushTime(rule, param, currentTime, oldNextFlushTimeTicks);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181B9 RID: 98745 RVA: 0x006B2F58 File Offset: 0x006B1158
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GoodsNextFlushCaculateTools");
		if (Lua_BlackJack_ProjectL_Common_GoodsNextFlushCaculateTools.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GoodsNextFlushCaculateTools.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GoodsNextFlushCaculateTools.CaculateNextFlushTime_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GoodsNextFlushCaculateTools.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GoodsNextFlushCaculateTools.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GoodsNextFlushCaculateTools.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GoodsNextFlushCaculateTools.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GoodsNextFlushCaculateTools.<>f__mg$cache1, typeof(GoodsNextFlushCaculateTools));
	}

	// Token: 0x0400E745 RID: 59205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E746 RID: 59206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
