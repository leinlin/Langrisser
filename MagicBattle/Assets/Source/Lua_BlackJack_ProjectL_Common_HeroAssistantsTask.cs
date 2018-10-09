using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001238 RID: 4664
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroAssistantsTask : LuaObject
{
	// Token: 0x0601831E RID: 99102 RVA: 0x006BD15C File Offset: 0x006BB35C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask o = new HeroAssistantsTask();
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

	// Token: 0x0601831F RID: 99103 RVA: 0x006BD1A4 File Offset: 0x006BB3A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroAssignPoints(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Hero)))
			{
				HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
				Hero h;
				LuaObject.checkType<Hero>(l, 2, out h);
				int heroAssignPoints = heroAssistantsTask.GetHeroAssignPoints(h);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, heroAssignPoints);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				HeroAssistantsTask heroAssistantsTask2 = (HeroAssistantsTask)LuaObject.checkSelf(l);
				int heroId;
				LuaObject.checkType(l, 2, out heroId);
				int heroAssignPoints2 = heroAssistantsTask2.GetHeroAssignPoints(heroId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, heroAssignPoints2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(List<Hero>)))
			{
				HeroAssistantsTask heroAssistantsTask3 = (HeroAssistantsTask)LuaObject.checkSelf(l);
				List<Hero> heroes;
				LuaObject.checkType<List<Hero>>(l, 2, out heroes);
				int heroAssignPoints3 = heroAssistantsTask3.GetHeroAssignPoints(heroes);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, heroAssignPoints3);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(List<int>)))
			{
				HeroAssistantsTask heroAssistantsTask4 = (HeroAssistantsTask)LuaObject.checkSelf(l);
				List<int> heroIds;
				LuaObject.checkType<List<int>>(l, 2, out heroIds);
				int heroAssignPoints4 = heroAssistantsTask4.GetHeroAssignPoints(heroIds);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, heroAssignPoints4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetHeroAssignPoints to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018320 RID: 99104 RVA: 0x006BD33C File Offset: 0x006BB53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WhichHeroAssistants(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.WhichHeroAssistants);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018321 RID: 99105 RVA: 0x006BD390 File Offset: 0x006BB590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WhichHeroAssistants(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			HeroAssistants whichHeroAssistants;
			LuaObject.checkType<HeroAssistants>(l, 2, out whichHeroAssistants);
			heroAssistantsTask.WhichHeroAssistants = whichHeroAssistants;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018322 RID: 99106 RVA: 0x006BD3E8 File Offset: 0x006BB5E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigId(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.ConfigId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018323 RID: 99107 RVA: 0x006BD43C File Offset: 0x006BB63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigId(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			int configId;
			LuaObject.checkType(l, 2, out configId);
			heroAssistantsTask.ConfigId = configId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018324 RID: 99108 RVA: 0x006BD494 File Offset: 0x006BB694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Weekday(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.Weekday);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018325 RID: 99109 RVA: 0x006BD4E8 File Offset: 0x006BB6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RecommendHeroIds(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.RecommendHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018326 RID: 99110 RVA: 0x006BD53C File Offset: 0x006BB73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierTypes(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.SoldierTypes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018327 RID: 99111 RVA: 0x006BD590 File Offset: 0x006BB790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CompletePoints(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.CompletePoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018328 RID: 99112 RVA: 0x006BD5E4 File Offset: 0x006BB7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RequiredUserLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.RequiredUserLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018329 RID: 99113 RVA: 0x006BD638 File Offset: 0x006BB838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RewardCompleteRate(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.RewardCompleteRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601832A RID: 99114 RVA: 0x006BD68C File Offset: 0x006BB88C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RewardDropId(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.RewardDropId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601832B RID: 99115 RVA: 0x006BD6E0 File Offset: 0x006BB8E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601832C RID: 99116 RVA: 0x006BD734 File Offset: 0x006BB934
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RewardWorkSeconds(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.RewardWorkSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601832D RID: 99117 RVA: 0x006BD788 File Offset: 0x006BB988
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RewardDropCount(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.RewardDropCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601832E RID: 99118 RVA: 0x006BD7DC File Offset: 0x006BB9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RecommendHeroMultiply(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.RecommendHeroMultiply);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601832F RID: 99119 RVA: 0x006BD830 File Offset: 0x006BBA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RecommendHeroAdd(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.RecommendHeroAdd);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018330 RID: 99120 RVA: 0x006BD884 File Offset: 0x006BBA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Locked(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.Locked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018331 RID: 99121 RVA: 0x006BD8D8 File Offset: 0x006BBAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018332 RID: 99122 RVA: 0x006BD92C File Offset: 0x006BBB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroAssistantsTask.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018333 RID: 99123 RVA: 0x006BD984 File Offset: 0x006BBB84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTask heroAssistantsTask = (HeroAssistantsTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTask.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018334 RID: 99124 RVA: 0x006BD9D8 File Offset: 0x006BBBD8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroAssistantsTask");
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.GetHeroAssignPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache0);
		string name = "WhichHeroAssistants";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_WhichHeroAssistants);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.set_WhichHeroAssistants);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache2, true);
		string name2 = "ConfigId";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_ConfigId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.set_ConfigId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache4, true);
		string name3 = "Weekday";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_Weekday);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache5, null, true);
		string name4 = "RecommendHeroIds";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_RecommendHeroIds);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache6, null, true);
		string name5 = "SoldierTypes";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_SoldierTypes);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache7, null, true);
		string name6 = "CompletePoints";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_CompletePoints);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache8, null, true);
		string name7 = "RequiredUserLevel";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_RequiredUserLevel);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache9, null, true);
		string name8 = "RewardCompleteRate";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_RewardCompleteRate);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheA, null, true);
		string name9 = "RewardDropId";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_RewardDropId);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheB, null, true);
		string name10 = "Rewards";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_Rewards);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheC, null, true);
		string name11 = "RewardWorkSeconds";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_RewardWorkSeconds);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheD, null, true);
		string name12 = "RewardDropCount";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_RewardDropCount);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheE, null, true);
		string name13 = "RecommendHeroMultiply";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_RecommendHeroMultiply);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cacheF, null, true);
		string name14 = "RecommendHeroAdd";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_RecommendHeroAdd);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache10, null, true);
		string name15 = "Locked";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_Locked);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache11, null, true);
		string name16 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_ConfigDataLoader);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name16, get3, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache13, true);
		string name17 = "Config";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.get_Config);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache14, null, true);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.<>f__mg$cache15, typeof(HeroAssistantsTask));
	}

	// Token: 0x0400E890 RID: 59536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E891 RID: 59537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E892 RID: 59538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E893 RID: 59539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E894 RID: 59540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E895 RID: 59541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E896 RID: 59542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E897 RID: 59543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E898 RID: 59544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E899 RID: 59545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E89A RID: 59546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E89B RID: 59547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E89C RID: 59548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E89D RID: 59549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E89E RID: 59550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E89F RID: 59551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E8A0 RID: 59552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E8A1 RID: 59553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E8A2 RID: 59554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E8A3 RID: 59555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E8A4 RID: 59556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E8A5 RID: 59557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
