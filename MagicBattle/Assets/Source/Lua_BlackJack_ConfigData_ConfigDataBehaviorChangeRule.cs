using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001142 RID: 4418
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule : LuaObject
{
	// Token: 0x060165EC RID: 91628 RVA: 0x005E5ED4 File Offset: 0x005E40D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule o = new ConfigDataBehaviorChangeRule();
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

	// Token: 0x060165ED RID: 91629 RVA: 0x005E5F1C File Offset: 0x005E411C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			bool b = configDataBehaviorChangeRule.Initialize();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165EE RID: 91630 RVA: 0x005E5F70 File Offset: 0x005E4170
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CCParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehaviorChangeRule.CCParamData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165EF RID: 91631 RVA: 0x005E5FC4 File Offset: 0x005E41C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CCParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			ConfigDataBehavior.ParamData ccparamData;
			LuaObject.checkType<ConfigDataBehavior.ParamData>(l, 2, out ccparamData);
			configDataBehaviorChangeRule.CCParamData = ccparamData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165F0 RID: 91632 RVA: 0x005E601C File Offset: 0x005E421C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehaviorChangeRule.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165F1 RID: 91633 RVA: 0x005E6070 File Offset: 0x005E4270
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBehaviorChangeRule.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165F2 RID: 91634 RVA: 0x005E60C8 File Offset: 0x005E42C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehaviorChangeRule.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165F3 RID: 91635 RVA: 0x005E611C File Offset: 0x005E431C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataBehaviorChangeRule.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165F4 RID: 91636 RVA: 0x005E6174 File Offset: 0x005E4374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChangeCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBehaviorChangeRule.ChangeCondition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165F5 RID: 91637 RVA: 0x005E61C8 File Offset: 0x005E43C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChangeCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			BehaviorCondition changeCondition;
			LuaObject.checkEnum<BehaviorCondition>(l, 2, out changeCondition);
			configDataBehaviorChangeRule.ChangeCondition = changeCondition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165F6 RID: 91638 RVA: 0x005E6220 File Offset: 0x005E4420
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CCParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehaviorChangeRule.CCParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165F7 RID: 91639 RVA: 0x005E6274 File Offset: 0x005E4474
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CCParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			string ccparam;
			LuaObject.checkType(l, 2, out ccparam);
			configDataBehaviorChangeRule.CCParam = ccparam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165F8 RID: 91640 RVA: 0x005E62CC File Offset: 0x005E44CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NextBehaviorID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehaviorChangeRule.NextBehaviorID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165F9 RID: 91641 RVA: 0x005E6320 File Offset: 0x005E4520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NextBehaviorID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehaviorChangeRule configDataBehaviorChangeRule = (ConfigDataBehaviorChangeRule)LuaObject.checkSelf(l);
			int nextBehaviorID;
			LuaObject.checkType(l, 2, out nextBehaviorID);
			configDataBehaviorChangeRule.NextBehaviorID = nextBehaviorID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165FA RID: 91642 RVA: 0x005E6378 File Offset: 0x005E4578
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBehaviorChangeRule");
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache0);
		string name = "CCParamData";
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.get_CCParamData);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache1;
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.set_CCParamData);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache2, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache3;
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache4, true);
		string name3 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.get_Desc);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache5;
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.set_Desc);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache6, true);
		string name4 = "ChangeCondition";
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.get_ChangeCondition);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache7;
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.set_ChangeCondition);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache8, true);
		string name5 = "CCParam";
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.get_CCParam);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cache9;
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.set_CCParam);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheA, true);
		string name6 = "NextBehaviorID";
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.get_NextBehaviorID);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheB;
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.set_NextBehaviorID);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheC, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.<>f__mg$cacheD, typeof(ConfigDataBehaviorChangeRule));
	}

	// Token: 0x0400CD4A RID: 52554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CD4B RID: 52555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CD4C RID: 52556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CD4D RID: 52557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CD4E RID: 52558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CD4F RID: 52559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CD50 RID: 52560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CD51 RID: 52561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CD52 RID: 52562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CD53 RID: 52563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CD54 RID: 52564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CD55 RID: 52565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CD56 RID: 52566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CD57 RID: 52567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
