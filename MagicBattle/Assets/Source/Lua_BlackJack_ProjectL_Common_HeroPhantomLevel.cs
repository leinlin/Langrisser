using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001246 RID: 4678
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroPhantomLevel : LuaObject
{
	// Token: 0x060184F4 RID: 99572 RVA: 0x006CBC14 File Offset: 0x006C9E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel o = new HeroPhantomLevel();
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

	// Token: 0x060184F5 RID: 99573 RVA: 0x006CBC5C File Offset: 0x006C9E5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FirstClear(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.FirstClear);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184F6 RID: 99574 RVA: 0x006CBCB4 File Offset: 0x006C9EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FirstClear(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			DateTime firstClear;
			LuaObject.checkValueType<DateTime>(l, 2, out firstClear);
			heroPhantomLevel.FirstClear = firstClear;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184F7 RID: 99575 RVA: 0x006CBD0C File Offset: 0x006C9F0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AchievementIdsFinished(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.AchievementIdsFinished);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184F8 RID: 99576 RVA: 0x006CBD60 File Offset: 0x006C9F60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AchievementIdsFinished(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			List<int> achievementIdsFinished;
			LuaObject.checkType<List<int>>(l, 2, out achievementIdsFinished);
			heroPhantomLevel.AchievementIdsFinished = achievementIdsFinished;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184F9 RID: 99577 RVA: 0x006CBDB8 File Offset: 0x006C9FB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WhichPhantom(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.WhichPhantom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184FA RID: 99578 RVA: 0x006CBE0C File Offset: 0x006CA00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WhichPhantom(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			HeroPhantom whichPhantom;
			LuaObject.checkType<HeroPhantom>(l, 2, out whichPhantom);
			heroPhantomLevel.WhichPhantom = whichPhantom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184FB RID: 99579 RVA: 0x006CBE64 File Offset: 0x006CA064
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184FC RID: 99580 RVA: 0x006CBEB8 File Offset: 0x006CA0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			heroPhantomLevel.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184FD RID: 99581 RVA: 0x006CBF10 File Offset: 0x006CA110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184FE RID: 99582 RVA: 0x006CBF64 File Offset: 0x006CA164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.PreLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184FF RID: 99583 RVA: 0x006CBFB8 File Offset: 0x006CA1B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018500 RID: 99584 RVA: 0x006CC00C File Offset: 0x006CA20C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018501 RID: 99585 RVA: 0x006CC060 File Offset: 0x006CA260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018502 RID: 99586 RVA: 0x006CC0B4 File Offset: 0x006CA2B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.BattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018503 RID: 99587 RVA: 0x006CC108 File Offset: 0x006CA308
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserExp(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.UserExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018504 RID: 99588 RVA: 0x006CC15C File Offset: 0x006CA35C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018505 RID: 99589 RVA: 0x006CC1B0 File Offset: 0x006CA3B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GoldBonus(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.GoldBonus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018506 RID: 99590 RVA: 0x006CC204 File Offset: 0x006CA404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RandomDropID(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.RandomDropID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018507 RID: 99591 RVA: 0x006CC258 File Offset: 0x006CA458
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FirstClearDropItems(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.FirstClearDropItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018508 RID: 99592 RVA: 0x006CC2AC File Offset: 0x006CA4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Achievements(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.Achievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018509 RID: 99593 RVA: 0x006CC300 File Offset: 0x006CA500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601850A RID: 99594 RVA: 0x006CC354 File Offset: 0x006CA554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroPhantomLevel.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601850B RID: 99595 RVA: 0x006CC3AC File Offset: 0x006CA5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601850C RID: 99596 RVA: 0x006CC400 File Offset: 0x006CA600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Cleared(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.Cleared);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601850D RID: 99597 RVA: 0x006CC454 File Offset: 0x006CA654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsAvailableForChallenge(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevel heroPhantomLevel = (HeroPhantomLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel.IsAvailableForChallenge);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601850E RID: 99598 RVA: 0x006CC4A8 File Offset: 0x006CA6A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroPhantomLevel");
		string name = "FirstClear";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_FirstClear);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.set_FirstClear);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache1, true);
		string name2 = "AchievementIdsFinished";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_AchievementIdsFinished);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.set_AchievementIdsFinished);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache3, true);
		string name3 = "WhichPhantom";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_WhichPhantom);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.set_WhichPhantom);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_Name);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache8, null, true);
		string name6 = "PreLevel";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_PreLevel);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache9, null, true);
		string name7 = "EnergySuccess";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_EnergySuccess);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheA, null, true);
		string name8 = "EnergyFail";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_EnergyFail);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheB, null, true);
		string name9 = "MonsterLevel";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_MonsterLevel);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheC, null, true);
		string name10 = "BattleInfo";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_BattleInfo);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheD, null, true);
		string name11 = "UserExp";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_UserExp);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheE, null, true);
		string name12 = "HeroExp";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_HeroExp);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cacheF, null, true);
		string name13 = "GoldBonus";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_GoldBonus);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache10, null, true);
		string name14 = "RandomDropID";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_RandomDropID);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache11, null, true);
		string name15 = "FirstClearDropItems";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_FirstClearDropItems);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache12, null, true);
		string name16 = "Achievements";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_Achievements);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache13, null, true);
		string name17 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_ConfigDataLoader);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name17, get5, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache15, true);
		string name18 = "Config";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_Config);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache16, null, true);
		string name19 = "Cleared";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_Cleared);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache17, null, true);
		string name20 = "IsAvailableForChallenge";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.get_IsAvailableForChallenge);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache18, null, true);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.<>f__mg$cache19, typeof(HeroPhantomLevel));
	}

	// Token: 0x0400EA4A RID: 59978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EA4B RID: 59979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EA4C RID: 59980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EA4D RID: 59981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EA4E RID: 59982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EA4F RID: 59983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EA50 RID: 59984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EA51 RID: 59985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EA52 RID: 59986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EA53 RID: 59987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EA54 RID: 59988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EA55 RID: 59989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EA56 RID: 59990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EA57 RID: 59991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EA58 RID: 59992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EA59 RID: 59993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EA5A RID: 59994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EA5B RID: 59995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EA5C RID: 59996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EA5D RID: 59997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EA5E RID: 59998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EA5F RID: 59999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EA60 RID: 60000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EA61 RID: 60001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EA62 RID: 60002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EA63 RID: 60003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
