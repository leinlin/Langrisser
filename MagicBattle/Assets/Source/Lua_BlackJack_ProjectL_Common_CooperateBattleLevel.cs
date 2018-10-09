using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011EC RID: 4588
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CooperateBattleLevel : LuaObject
{
	// Token: 0x06017CBE RID: 97470 RVA: 0x0068F370 File Offset: 0x0068D570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel o = new CooperateBattleLevel();
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

	// Token: 0x06017CBF RID: 97471 RVA: 0x0068F3B8 File Offset: 0x0068D5B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FirstClear(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.FirstClear);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CC0 RID: 97472 RVA: 0x0068F410 File Offset: 0x0068D610
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FirstClear(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			DateTime firstClear;
			LuaObject.checkValueType<DateTime>(l, 2, out firstClear);
			cooperateBattleLevel.FirstClear = firstClear;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CC1 RID: 97473 RVA: 0x0068F468 File Offset: 0x0068D668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WhichCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.WhichCooperateBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CC2 RID: 97474 RVA: 0x0068F4BC File Offset: 0x0068D6BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WhichCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			CooperateBattle whichCooperateBattle;
			LuaObject.checkType<CooperateBattle>(l, 2, out whichCooperateBattle);
			cooperateBattleLevel.WhichCooperateBattle = whichCooperateBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CC3 RID: 97475 RVA: 0x0068F514 File Offset: 0x0068D714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CC4 RID: 97476 RVA: 0x0068F568 File Offset: 0x0068D768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			cooperateBattleLevel.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CC5 RID: 97477 RVA: 0x0068F5C0 File Offset: 0x0068D7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CC6 RID: 97478 RVA: 0x0068F614 File Offset: 0x0068D814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerLevelRequirement(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.PlayerLevelRequirement);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CC7 RID: 97479 RVA: 0x0068F668 File Offset: 0x0068D868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CC8 RID: 97480 RVA: 0x0068F6BC File Offset: 0x0068D8BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CC9 RID: 97481 RVA: 0x0068F710 File Offset: 0x0068D910
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CCA RID: 97482 RVA: 0x0068F764 File Offset: 0x0068D964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleID(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.BattleID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CCB RID: 97483 RVA: 0x0068F7B8 File Offset: 0x0068D9B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserExp(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.UserExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CCC RID: 97484 RVA: 0x0068F80C File Offset: 0x0068DA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CCD RID: 97485 RVA: 0x0068F860 File Offset: 0x0068DA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoldBonus(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.GoldBonus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CCE RID: 97486 RVA: 0x0068F8B4 File Offset: 0x0068DAB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomDropID(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.RandomDropID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CCF RID: 97487 RVA: 0x0068F908 File Offset: 0x0068DB08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamRandomDropID(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.TeamRandomDropID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CD0 RID: 97488 RVA: 0x0068F95C File Offset: 0x0068DB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemDropCountDisplay(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.ItemDropCountDisplay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CD1 RID: 97489 RVA: 0x0068F9B0 File Offset: 0x0068DBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DayBonusDropID(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.DayBonusDropID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CD2 RID: 97490 RVA: 0x0068FA04 File Offset: 0x0068DC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Cleared(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.Cleared);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CD3 RID: 97491 RVA: 0x0068FA58 File Offset: 0x0068DC58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsAvailableForChallenge(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.IsAvailableForChallenge);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CD4 RID: 97492 RVA: 0x0068FAAC File Offset: 0x0068DCAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CD5 RID: 97493 RVA: 0x0068FB00 File Offset: 0x0068DD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			cooperateBattleLevel.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CD6 RID: 97494 RVA: 0x0068FB58 File Offset: 0x0068DD58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevel cooperateBattleLevel = (CooperateBattleLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CD7 RID: 97495 RVA: 0x0068FBAC File Offset: 0x0068DDAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CooperateBattleLevel");
		string name = "FirstClear";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_FirstClear);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.set_FirstClear);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache1, true);
		string name2 = "WhichCooperateBattle";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_WhichCooperateBattle);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.set_WhichCooperateBattle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache5, true);
		string name4 = "Name";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_Name);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache6, null, true);
		string name5 = "PlayerLevelRequirement";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_PlayerLevelRequirement);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache7, null, true);
		string name6 = "EnergySuccess";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_EnergySuccess);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache8, null, true);
		string name7 = "EnergyFail";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_EnergyFail);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache9, null, true);
		string name8 = "MonsterLevel";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_MonsterLevel);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheA, null, true);
		string name9 = "BattleID";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_BattleID);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheB, null, true);
		string name10 = "UserExp";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_UserExp);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheC, null, true);
		string name11 = "HeroExp";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_HeroExp);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheD, null, true);
		string name12 = "GoldBonus";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_GoldBonus);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheE, null, true);
		string name13 = "RandomDropID";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_RandomDropID);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cacheF, null, true);
		string name14 = "TeamRandomDropID";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_TeamRandomDropID);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache10, null, true);
		string name15 = "ItemDropCountDisplay";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_ItemDropCountDisplay);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache11, null, true);
		string name16 = "DayBonusDropID";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_DayBonusDropID);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache12, null, true);
		string name17 = "Cleared";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_Cleared);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache13, null, true);
		string name18 = "IsAvailableForChallenge";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_IsAvailableForChallenge);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache14, null, true);
		string name19 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_ConfigDataLoader);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name19, get4, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache16, true);
		string name20 = "Config";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.get_Config);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache17, null, true);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.<>f__mg$cache18, typeof(CooperateBattleLevel));
	}

	// Token: 0x0400E2C8 RID: 58056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E2C9 RID: 58057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E2CA RID: 58058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E2CB RID: 58059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E2CC RID: 58060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E2CD RID: 58061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E2CE RID: 58062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E2CF RID: 58063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E2D0 RID: 58064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E2D1 RID: 58065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E2D2 RID: 58066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E2D3 RID: 58067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E2D4 RID: 58068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E2D5 RID: 58069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E2D6 RID: 58070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E2D7 RID: 58071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E2D8 RID: 58072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E2D9 RID: 58073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E2DA RID: 58074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E2DB RID: 58075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E2DC RID: 58076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E2DD RID: 58077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E2DE RID: 58078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E2DF RID: 58079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E2E0 RID: 58080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
