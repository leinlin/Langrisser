using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001150 RID: 4432
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataGroupBehavior : LuaObject
{
	// Token: 0x06016860 RID: 92256 RVA: 0x005F7D14 File Offset: 0x005F5F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior o = new ConfigDataGroupBehavior();
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

	// Token: 0x06016861 RID: 92257 RVA: 0x005F7D5C File Offset: 0x005F5F5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			bool b = configDataGroupBehavior.Initialize();
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

	// Token: 0x06016862 RID: 92258 RVA: 0x005F7DB0 File Offset: 0x005F5FB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SLCParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGroupBehavior.SLCParamData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016863 RID: 92259 RVA: 0x005F7E04 File Offset: 0x005F6004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SLCParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			ConfigDataBehavior.ParamData slcparamData;
			LuaObject.checkType<ConfigDataBehavior.ParamData>(l, 2, out slcparamData);
			configDataGroupBehavior.SLCParamData = slcparamData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016864 RID: 92260 RVA: 0x005F7E5C File Offset: 0x005F605C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGroupBehavior.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016865 RID: 92261 RVA: 0x005F7EB0 File Offset: 0x005F60B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataGroupBehavior.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016866 RID: 92262 RVA: 0x005F7F08 File Offset: 0x005F6108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGroupBehavior.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016867 RID: 92263 RVA: 0x005F7F5C File Offset: 0x005F615C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataGroupBehavior.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016868 RID: 92264 RVA: 0x005F7FB4 File Offset: 0x005F61B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectLeaderCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataGroupBehavior.SelectLeaderCondition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016869 RID: 92265 RVA: 0x005F8008 File Offset: 0x005F6208
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SelectLeaderCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			BehaviorCondition selectLeaderCondition;
			LuaObject.checkEnum<BehaviorCondition>(l, 2, out selectLeaderCondition);
			configDataGroupBehavior.SelectLeaderCondition = selectLeaderCondition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601686A RID: 92266 RVA: 0x005F8060 File Offset: 0x005F6260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SLCParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGroupBehavior.SLCParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601686B RID: 92267 RVA: 0x005F80B4 File Offset: 0x005F62B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SLCParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			string slcparam;
			LuaObject.checkType(l, 2, out slcparam);
			configDataGroupBehavior.SLCParam = slcparam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601686C RID: 92268 RVA: 0x005F810C File Offset: 0x005F630C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LeaderBehavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGroupBehavior.LeaderBehavior);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601686D RID: 92269 RVA: 0x005F8160 File Offset: 0x005F6360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LeaderBehavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			int leaderBehavior;
			LuaObject.checkType(l, 2, out leaderBehavior);
			configDataGroupBehavior.LeaderBehavior = leaderBehavior;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601686E RID: 92270 RVA: 0x005F81B8 File Offset: 0x005F63B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MemberBehavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGroupBehavior.MemberBehavior);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601686F RID: 92271 RVA: 0x005F820C File Offset: 0x005F640C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MemberBehavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGroupBehavior configDataGroupBehavior = (ConfigDataGroupBehavior)LuaObject.checkSelf(l);
			int memberBehavior;
			LuaObject.checkType(l, 2, out memberBehavior);
			configDataGroupBehavior.MemberBehavior = memberBehavior;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016870 RID: 92272 RVA: 0x005F8264 File Offset: 0x005F6464
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataGroupBehavior");
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache0);
		string name = "SLCParamData";
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.get_SLCParamData);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache1;
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.set_SLCParamData);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache2, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache3;
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache4, true);
		string name3 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.get_Desc);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache5;
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.set_Desc);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache6, true);
		string name4 = "SelectLeaderCondition";
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.get_SelectLeaderCondition);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache7;
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.set_SelectLeaderCondition);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache8, true);
		string name5 = "SLCParam";
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.get_SLCParam);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cache9;
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.set_SLCParam);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheA, true);
		string name6 = "LeaderBehavior";
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.get_LeaderBehavior);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheB;
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.set_LeaderBehavior);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheC, true);
		string name7 = "MemberBehavior";
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.get_MemberBehavior);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.set_MemberBehavior);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheE, true);
		if (Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.<>f__mg$cacheF, typeof(ConfigDataGroupBehavior));
	}

	// Token: 0x0400CFA2 RID: 53154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CFA3 RID: 53155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CFA4 RID: 53156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CFA5 RID: 53157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CFA6 RID: 53158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CFA7 RID: 53159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CFA8 RID: 53160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CFA9 RID: 53161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CFAA RID: 53162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CFAB RID: 53163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CFAC RID: 53164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CFAD RID: 53165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CFAE RID: 53166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CFAF RID: 53167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CFB0 RID: 53168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CFB1 RID: 53169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
