using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012AB RID: 4779
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData : LuaObject
{
	// Token: 0x0601910C RID: 102668 RVA: 0x00724CA0 File Offset: 0x00722EA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData o = new LocalProcessingBattleData();
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

	// Token: 0x0601910D RID: 102669 RVA: 0x00724CE8 File Offset: 0x00722EE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			localProcessingBattleData.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601910E RID: 102670 RVA: 0x00724D34 File Offset: 0x00722F34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Version(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localProcessingBattleData.Version);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601910F RID: 102671 RVA: 0x00724D88 File Offset: 0x00722F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Version(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			int version;
			LuaObject.checkType(l, 2, out version);
			localProcessingBattleData.Version = version;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019110 RID: 102672 RVA: 0x00724DE0 File Offset: 0x00722FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localProcessingBattleData.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019111 RID: 102673 RVA: 0x00724E34 File Offset: 0x00723034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			int type;
			LuaObject.checkType(l, 2, out type);
			localProcessingBattleData.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019112 RID: 102674 RVA: 0x00724E8C File Offset: 0x0072308C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TypeId(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localProcessingBattleData.TypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019113 RID: 102675 RVA: 0x00724EE0 File Offset: 0x007230E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TypeId(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			int typeId;
			LuaObject.checkType(l, 2, out typeId);
			localProcessingBattleData.TypeId = typeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019114 RID: 102676 RVA: 0x00724F38 File Offset: 0x00723138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RandomSeed(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localProcessingBattleData.RandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019115 RID: 102677 RVA: 0x00724F8C File Offset: 0x0072318C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RandomSeed(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			int randomSeed;
			LuaObject.checkType(l, 2, out randomSeed);
			localProcessingBattleData.RandomSeed = randomSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019116 RID: 102678 RVA: 0x00724FE4 File Offset: 0x007231E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localProcessingBattleData.ArmyRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019117 RID: 102679 RVA: 0x00725038 File Offset: 0x00723238
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			int armyRandomSeed;
			LuaObject.checkType(l, 2, out armyRandomSeed);
			localProcessingBattleData.ArmyRandomSeed = armyRandomSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019118 RID: 102680 RVA: 0x00725090 File Offset: 0x00723290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Step(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localProcessingBattleData.Step);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019119 RID: 102681 RVA: 0x007250E4 File Offset: 0x007232E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Step(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			localProcessingBattleData.Step = step;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601911A RID: 102682 RVA: 0x0072513C File Offset: 0x0072333C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RegretCount(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localProcessingBattleData.RegretCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601911B RID: 102683 RVA: 0x00725190 File Offset: 0x00723390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RegretCount(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			int regretCount;
			LuaObject.checkType(l, 2, out regretCount);
			localProcessingBattleData.RegretCount = regretCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601911C RID: 102684 RVA: 0x007251E8 File Offset: 0x007233E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleCommands(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localProcessingBattleData.BattleCommands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601911D RID: 102685 RVA: 0x0072523C File Offset: 0x0072343C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleCommands(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData localProcessingBattleData = (LocalProcessingBattleData)LuaObject.checkSelf(l);
			LocalProcessingBattleData.LocalBattleCommand[] battleCommands;
			LuaObject.checkArray<LocalProcessingBattleData.LocalBattleCommand>(l, 2, out battleCommands);
			localProcessingBattleData.BattleCommands = battleCommands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601911E RID: 102686 RVA: 0x00725294 File Offset: 0x00723494
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.LocalProcessingBattleData");
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache0);
		string name = "Version";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.get_Version);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.set_Version);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache2, true);
		string name2 = "Type";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.get_Type);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.set_Type);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache4, true);
		string name3 = "TypeId";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.get_TypeId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.set_TypeId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache6, true);
		string name4 = "RandomSeed";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.get_RandomSeed);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.set_RandomSeed);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache8, true);
		string name5 = "ArmyRandomSeed";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.get_ArmyRandomSeed);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.set_ArmyRandomSeed);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheA, true);
		string name6 = "Step";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.get_Step);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.set_Step);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheC, true);
		string name7 = "RegretCount";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.get_RegretCount);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.set_RegretCount);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheE, true);
		string name8 = "BattleCommands";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.get_BattleCommands);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.set_BattleCommands);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache10, true);
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.<>f__mg$cache11, typeof(LocalProcessingBattleData));
	}

	// Token: 0x0400F598 RID: 62872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F599 RID: 62873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F59A RID: 62874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F59B RID: 62875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F59C RID: 62876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F59D RID: 62877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F59E RID: 62878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F59F RID: 62879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F5A0 RID: 62880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F5A1 RID: 62881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F5A2 RID: 62882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F5A3 RID: 62883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F5A4 RID: 62884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F5A5 RID: 62885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F5A6 RID: 62886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F5A7 RID: 62887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F5A8 RID: 62888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F5A9 RID: 62889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
