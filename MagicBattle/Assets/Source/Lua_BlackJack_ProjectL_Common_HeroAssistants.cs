using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001236 RID: 4662
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroAssistants : LuaObject
{
	// Token: 0x060182E6 RID: 99046 RVA: 0x006BB594 File Offset: 0x006B9794
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants o = new HeroAssistants();
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

	// Token: 0x060182E7 RID: 99047 RVA: 0x006BB5DC File Offset: 0x006B97DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReloadConfigData(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			heroAssistants.ReloadConfigData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182E8 RID: 99048 RVA: 0x006BB628 File Offset: 0x006B9828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Finder(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			FindHero findHero;
			int num = LuaObject.checkDelegate<FindHero>(l, 2, out findHero);
			if (num == 0)
			{
				heroAssistants.Finder = findHero;
			}
			else if (num == 1)
			{
				HeroAssistants heroAssistants2 = heroAssistants;
				heroAssistants2.Finder = (FindHero)Delegate.Combine(heroAssistants2.Finder, findHero);
			}
			else if (num == 2)
			{
				HeroAssistants heroAssistants3 = heroAssistants;
				heroAssistants3.Finder = (FindHero)Delegate.Remove(heroAssistants3.Finder, findHero);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182E9 RID: 99049 RVA: 0x006BB6D0 File Offset: 0x006B98D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Compute(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			ComputeBattlePower computeBattlePower;
			int num = LuaObject.checkDelegate<ComputeBattlePower>(l, 2, out computeBattlePower);
			if (num == 0)
			{
				heroAssistants.Compute = computeBattlePower;
			}
			else if (num == 1)
			{
				HeroAssistants heroAssistants2 = heroAssistants;
				heroAssistants2.Compute = (ComputeBattlePower)Delegate.Combine(heroAssistants2.Compute, computeBattlePower);
			}
			else if (num == 2)
			{
				HeroAssistants heroAssistants3 = heroAssistants;
				heroAssistants3.Compute = (ComputeBattlePower)Delegate.Remove(heroAssistants3.Compute, computeBattlePower);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182EA RID: 99050 RVA: 0x006BB778 File Offset: 0x006B9978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GetLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			GetUserLevel getUserLevel;
			int num = LuaObject.checkDelegate<GetUserLevel>(l, 2, out getUserLevel);
			if (num == 0)
			{
				heroAssistants.GetLevel = getUserLevel;
			}
			else if (num == 1)
			{
				HeroAssistants heroAssistants2 = heroAssistants;
				heroAssistants2.GetLevel = (GetUserLevel)Delegate.Combine(heroAssistants2.GetLevel, getUserLevel);
			}
			else if (num == 2)
			{
				HeroAssistants heroAssistants3 = heroAssistants;
				heroAssistants3.GetLevel = (GetUserLevel)Delegate.Remove(heroAssistants3.GetLevel, getUserLevel);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182EB RID: 99051 RVA: 0x006BB820 File Offset: 0x006B9A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Now(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			CurrentTime currentTime;
			int num = LuaObject.checkDelegate<CurrentTime>(l, 2, out currentTime);
			if (num == 0)
			{
				heroAssistants.Now = currentTime;
			}
			else if (num == 1)
			{
				HeroAssistants heroAssistants2 = heroAssistants;
				heroAssistants2.Now = (CurrentTime)Delegate.Combine(heroAssistants2.Now, currentTime);
			}
			else if (num == 2)
			{
				HeroAssistants heroAssistants3 = heroAssistants;
				heroAssistants3.Now = (CurrentTime)Delegate.Remove(heroAssistants3.Now, currentTime);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182EC RID: 99052 RVA: 0x006BB8C8 File Offset: 0x006B9AC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Tasks(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistants.Tasks);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182ED RID: 99053 RVA: 0x006BB91C File Offset: 0x006B9B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Tasks(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			List<HeroAssistantsTask> tasks;
			LuaObject.checkType<List<HeroAssistantsTask>>(l, 2, out tasks);
			heroAssistants.Tasks = tasks;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182EE RID: 99054 RVA: 0x006BB974 File Offset: 0x006B9B74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Assignments(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistants.Assignments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182EF RID: 99055 RVA: 0x006BB9C8 File Offset: 0x006B9BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Assignments(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			List<HeroAssistantsTaskAssignment> assignments;
			LuaObject.checkType<List<HeroAssistantsTaskAssignment>>(l, 2, out assignments);
			heroAssistants.Assignments = assignments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182F0 RID: 99056 RVA: 0x006BBA20 File Offset: 0x006B9C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistants.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182F1 RID: 99057 RVA: 0x006BBA74 File Offset: 0x006B9C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistants heroAssistants = (HeroAssistants)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroAssistants.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182F2 RID: 99058 RVA: 0x006BBACC File Offset: 0x006B9CCC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroAssistants");
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.ReloadConfigData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache0);
		string name = "Finder";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.set_Finder);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache1, true);
		string name2 = "Compute";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.set_Compute);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache2, true);
		string name3 = "GetLevel";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.set_GetLevel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache3, true);
		string name4 = "Now";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.set_Now);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache4, true);
		string name5 = "Tasks";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.get_Tasks);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.set_Tasks);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache6, true);
		string name6 = "Assignments";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.get_Assignments);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.set_Assignments);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache8, true);
		string name7 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.get_ConfigDataLoader);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cacheA, true);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistants.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroAssistants.<>f__mg$cacheB, typeof(HeroAssistants));
	}

	// Token: 0x0400E85C RID: 59484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E85D RID: 59485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E85E RID: 59486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E85F RID: 59487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E860 RID: 59488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E861 RID: 59489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E862 RID: 59490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E863 RID: 59491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E864 RID: 59492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E865 RID: 59493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E866 RID: 59494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E867 RID: 59495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
