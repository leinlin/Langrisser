using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001225 RID: 4645
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor : LuaObject
{
	// Token: 0x06018183 RID: 98691 RVA: 0x006B1984 File Offset: 0x006AFB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerFloor o = new GlobalClimbTowerFloor();
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

	// Token: 0x06018184 RID: 98692 RVA: 0x006B19CC File Offset: 0x006AFBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelId(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerFloor globalClimbTowerFloor = (GlobalClimbTowerFloor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalClimbTowerFloor.LevelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018185 RID: 98693 RVA: 0x006B1A20 File Offset: 0x006AFC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LevelId(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerFloor globalClimbTowerFloor = (GlobalClimbTowerFloor)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			globalClimbTowerFloor.LevelId = levelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018186 RID: 98694 RVA: 0x006B1A78 File Offset: 0x006AFC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RuleId(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerFloor globalClimbTowerFloor = (GlobalClimbTowerFloor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalClimbTowerFloor.RuleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018187 RID: 98695 RVA: 0x006B1ACC File Offset: 0x006AFCCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RuleId(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerFloor globalClimbTowerFloor = (GlobalClimbTowerFloor)LuaObject.checkSelf(l);
			int ruleId;
			LuaObject.checkType(l, 2, out ruleId);
			globalClimbTowerFloor.RuleId = ruleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018188 RID: 98696 RVA: 0x006B1B24 File Offset: 0x006AFD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerFloor globalClimbTowerFloor = (GlobalClimbTowerFloor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalClimbTowerFloor.ArmyRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018189 RID: 98697 RVA: 0x006B1B78 File Offset: 0x006AFD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerFloor globalClimbTowerFloor = (GlobalClimbTowerFloor)LuaObject.checkSelf(l);
			int armyRandomSeed;
			LuaObject.checkType(l, 2, out armyRandomSeed);
			globalClimbTowerFloor.ArmyRandomSeed = armyRandomSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601818A RID: 98698 RVA: 0x006B1BD0 File Offset: 0x006AFDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BonusHeroGroupId(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerFloor globalClimbTowerFloor = (GlobalClimbTowerFloor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalClimbTowerFloor.BonusHeroGroupId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601818B RID: 98699 RVA: 0x006B1C24 File Offset: 0x006AFE24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BonusHeroGroupId(IntPtr l)
	{
		int result;
		try
		{
			GlobalClimbTowerFloor globalClimbTowerFloor = (GlobalClimbTowerFloor)LuaObject.checkSelf(l);
			int bonusHeroGroupId;
			LuaObject.checkType(l, 2, out bonusHeroGroupId);
			globalClimbTowerFloor.BonusHeroGroupId = bonusHeroGroupId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601818C RID: 98700 RVA: 0x006B1C7C File Offset: 0x006AFE7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GlobalClimbTowerFloor");
		string name = "LevelId";
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.get_LevelId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.set_LevelId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache1, true);
		string name2 = "RuleId";
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.get_RuleId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.set_RuleId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache3, true);
		string name3 = "ArmyRandomSeed";
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.get_ArmyRandomSeed);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.set_ArmyRandomSeed);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache5, true);
		string name4 = "BonusHeroGroupId";
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.get_BonusHeroGroupId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.set_BonusHeroGroupId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.<>f__mg$cache8, typeof(GlobalClimbTowerFloor));
	}

	// Token: 0x0400E71B RID: 59163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E71C RID: 59164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E71D RID: 59165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E71E RID: 59166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E71F RID: 59167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E720 RID: 59168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E721 RID: 59169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E722 RID: 59170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E723 RID: 59171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
