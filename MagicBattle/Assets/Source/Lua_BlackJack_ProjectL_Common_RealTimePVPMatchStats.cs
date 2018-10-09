using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001272 RID: 4722
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats : LuaObject
{
	// Token: 0x060189AA RID: 100778 RVA: 0x006EF014 File Offset: 0x006ED214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats o = new RealTimePVPMatchStats();
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

	// Token: 0x060189AB RID: 100779 RVA: 0x006EF05C File Offset: 0x006ED25C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddWins(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			realTimePVPMatchStats.AddWins();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189AC RID: 100780 RVA: 0x006EF0A8 File Offset: 0x006ED2A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddLosses(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			realTimePVPMatchStats.AddLosses();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189AD RID: 100781 RVA: 0x006EF0F4 File Offset: 0x006ED2F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeepDuplicate(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			RealTimePVPMatchStats o = realTimePVPMatchStats.DeepDuplicate();
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

	// Token: 0x060189AE RID: 100782 RVA: 0x006EF148 File Offset: 0x006ED348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPro(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats stats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			ProRealTimePVPMatchStats o = stats.ToPro();
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

	// Token: 0x060189AF RID: 100783 RVA: 0x006EF19C File Offset: 0x006ED39C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Matches(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPMatchStats.Matches);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189B0 RID: 100784 RVA: 0x006EF1F0 File Offset: 0x006ED3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Matches(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			int matches;
			LuaObject.checkType(l, 2, out matches);
			realTimePVPMatchStats.Matches = matches;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189B1 RID: 100785 RVA: 0x006EF248 File Offset: 0x006ED448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Wins(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPMatchStats.Wins);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189B2 RID: 100786 RVA: 0x006EF29C File Offset: 0x006ED49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Wins(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			int wins;
			LuaObject.checkType(l, 2, out wins);
			realTimePVPMatchStats.Wins = wins;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189B3 RID: 100787 RVA: 0x006EF2F4 File Offset: 0x006ED4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConsecutiveWins(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPMatchStats.ConsecutiveWins);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189B4 RID: 100788 RVA: 0x006EF348 File Offset: 0x006ED548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConsecutiveWins(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			int consecutiveWins;
			LuaObject.checkType(l, 2, out consecutiveWins);
			realTimePVPMatchStats.ConsecutiveWins = consecutiveWins;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189B5 RID: 100789 RVA: 0x006EF3A0 File Offset: 0x006ED5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConsecutiveLosses(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPMatchStats.ConsecutiveLosses);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189B6 RID: 100790 RVA: 0x006EF3F4 File Offset: 0x006ED5F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ConsecutiveLosses(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPMatchStats realTimePVPMatchStats = (RealTimePVPMatchStats)LuaObject.checkSelf(l);
			int consecutiveLosses;
			LuaObject.checkType(l, 2, out consecutiveLosses);
			realTimePVPMatchStats.ConsecutiveLosses = consecutiveLosses;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189B7 RID: 100791 RVA: 0x006EF44C File Offset: 0x006ED64C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RealTimePVPMatchStats");
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.AddWins);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.AddLosses);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.DeepDuplicate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.ToPro);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache3);
		string name = "Matches";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.get_Matches);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.set_Matches);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache5, true);
		string name2 = "Wins";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.get_Wins);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.set_Wins);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache7, true);
		string name3 = "ConsecutiveWins";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.get_ConsecutiveWins);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.set_ConsecutiveWins);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cache9, true);
		string name4 = "ConsecutiveLosses";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.get_ConsecutiveLosses);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.set_ConsecutiveLosses);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.<>f__mg$cacheC, typeof(RealTimePVPMatchStats));
	}

	// Token: 0x0400EEA8 RID: 61096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EEA9 RID: 61097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EEAA RID: 61098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EEAB RID: 61099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EEAC RID: 61100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EEAD RID: 61101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EEAE RID: 61102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EEAF RID: 61103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EEB0 RID: 61104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EEB1 RID: 61105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EEB2 RID: 61106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EEB3 RID: 61107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EEB4 RID: 61108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
