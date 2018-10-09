using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001271 RID: 4721
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RealTimePVPInfo : LuaObject
{
	// Token: 0x0601899B RID: 100763 RVA: 0x006EE9D0 File Offset: 0x006ECBD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo o = new RealTimePVPInfo();
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

	// Token: 0x0601899C RID: 100764 RVA: 0x006EEA18 File Offset: 0x006ECC18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPInfo.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601899D RID: 100765 RVA: 0x006EEA6C File Offset: 0x006ECC6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			realTimePVPInfo.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601899E RID: 100766 RVA: 0x006EEAC4 File Offset: 0x006ECCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Score(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPInfo.Score);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601899F RID: 100767 RVA: 0x006EEB18 File Offset: 0x006ECD18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Score(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			int score;
			LuaObject.checkType(l, 2, out score);
			realTimePVPInfo.Score = score;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189A0 RID: 100768 RVA: 0x006EEB70 File Offset: 0x006ECD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LocalRank(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPInfo.LocalRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189A1 RID: 100769 RVA: 0x006EEBC4 File Offset: 0x006ECDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LocalRank(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			int localRank;
			LuaObject.checkType(l, 2, out localRank);
			realTimePVPInfo.LocalRank = localRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189A2 RID: 100770 RVA: 0x006EEC1C File Offset: 0x006ECE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GlobalRank(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPInfo.GlobalRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189A3 RID: 100771 RVA: 0x006EEC70 File Offset: 0x006ECE70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GlobalRank(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			int globalRank;
			LuaObject.checkType(l, 2, out globalRank);
			realTimePVPInfo.GlobalRank = globalRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189A4 RID: 100772 RVA: 0x006EECC8 File Offset: 0x006ECEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Dan(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPInfo.Dan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189A5 RID: 100773 RVA: 0x006EED1C File Offset: 0x006ECF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Dan(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			int dan;
			LuaObject.checkType(l, 2, out dan);
			realTimePVPInfo.Dan = dan;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189A6 RID: 100774 RVA: 0x006EED74 File Offset: 0x006ECF74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsBot(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPInfo.IsBot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189A7 RID: 100775 RVA: 0x006EEDC8 File Offset: 0x006ECFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsBot(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPInfo realTimePVPInfo = (RealTimePVPInfo)LuaObject.checkSelf(l);
			bool isBot;
			LuaObject.checkType(l, 2, out isBot);
			realTimePVPInfo.IsBot = isBot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189A8 RID: 100776 RVA: 0x006EEE20 File Offset: 0x006ED020
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RealTimePVPInfo");
		string name = "UserId";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.get_UserId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.set_UserId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache1, true);
		string name2 = "Score";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.get_Score);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.set_Score);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache3, true);
		string name3 = "LocalRank";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.get_LocalRank);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.set_LocalRank);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache5, true);
		string name4 = "GlobalRank";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.get_GlobalRank);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.set_GlobalRank);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache7, true);
		string name5 = "Dan";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.get_Dan);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.set_Dan);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cache9, true);
		string name6 = "IsBot";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.get_IsBot);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.set_IsBot);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.<>f__mg$cacheC, typeof(RealTimePVPInfo));
	}

	// Token: 0x0400EE9B RID: 61083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EE9C RID: 61084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EE9D RID: 61085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EE9E RID: 61086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EE9F RID: 61087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EEA0 RID: 61088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EEA1 RID: 61089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EEA2 RID: 61090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EEA3 RID: 61091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EEA4 RID: 61092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EEA5 RID: 61093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EEA6 RID: 61094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EEA7 RID: 61095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
