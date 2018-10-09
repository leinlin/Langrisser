using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012A8 RID: 4776
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_LocalConfig : LuaObject
{
	// Token: 0x060190A5 RID: 102565 RVA: 0x00721E68 File Offset: 0x00720068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig o = new LocalConfig();
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

	// Token: 0x060190A6 RID: 102566 RVA: 0x00721EB0 File Offset: 0x007200B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFileName(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			string fileName;
			LuaObject.checkType(l, 2, out fileName);
			localConfig.SetFileName(fileName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190A7 RID: 102567 RVA: 0x00721F08 File Offset: 0x00720108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Save(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			bool b = localConfig.Save();
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

	// Token: 0x060190A8 RID: 102568 RVA: 0x00721F5C File Offset: 0x0072015C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Load(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			bool b = localConfig.Load();
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

	// Token: 0x060190A9 RID: 102569 RVA: 0x00721FB0 File Offset: 0x007201B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ApplyVolume(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			string category;
			LuaObject.checkType(l, 2, out category);
			bool isInitialize;
			LuaObject.checkType(l, 3, out isInitialize);
			localConfig.ApplyVolume(category, isInitialize);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190AA RID: 102570 RVA: 0x00722014 File Offset: 0x00720214
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Apply(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			bool isInitialize;
			LuaObject.checkType(l, 2, out isInitialize);
			localConfig.Apply(isInitialize);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190AB RID: 102571 RVA: 0x0072206C File Offset: 0x0072026C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRecentLoginServerID(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			localConfig.AddRecentLoginServerID(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190AC RID: 102572 RVA: 0x007220C4 File Offset: 0x007202C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			bool autoBattle;
			LuaObject.checkType(l, 3, out autoBattle);
			localConfig.SetAutoBattle(battleType, autoBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190AD RID: 102573 RVA: 0x00722128 File Offset: 0x00720328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			bool b = localConfig.IsAutoBattle(battleType);
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

	// Token: 0x060190AE RID: 102574 RVA: 0x0072218C File Offset: 0x0072038C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAutoBattle(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			localConfig.ClearAutoBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190AF RID: 102575 RVA: 0x007221D8 File Offset: 0x007203D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTestUIId(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			int testType;
			LuaObject.checkType(l, 2, out testType);
			int testId;
			LuaObject.checkType(l, 3, out testId);
			localConfig.SetTestUIId(testType, testId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190B0 RID: 102576 RVA: 0x0072223C File Offset: 0x0072043C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTestUIId(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			int testType;
			LuaObject.checkType(l, 2, out testType);
			int testUIId = localConfig.GetTestUIId(testType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUIId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190B1 RID: 102577 RVA: 0x007222A0 File Offset: 0x007204A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattleDanmakuState(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			bool battleDanmakuState;
			LuaObject.checkType(l, 2, out battleDanmakuState);
			localConfig.SetBattleDanmakuState(battleDanmakuState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190B2 RID: 102578 RVA: 0x007222F8 File Offset: 0x007204F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeroListSortType(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			int heroListSortType;
			LuaObject.checkType(l, 2, out heroListSortType);
			localConfig.SetHeroListSortType(heroListSortType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190B3 RID: 102579 RVA: 0x00722350 File Offset: 0x00720550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetIsOnlyShowCurJobSkin(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			bool isOnlyShowCurJobSkin;
			LuaObject.checkType(l, 2, out isOnlyShowCurJobSkin);
			localConfig.SetIsOnlyShowCurJobSkin(isOnlyShowCurJobSkin);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190B4 RID: 102580 RVA: 0x007223A8 File Offset: 0x007205A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIsSetSkinToAllSoldier(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			bool isSetSkinToAllSoldier;
			LuaObject.checkType(l, 2, out isSetSkinToAllSoldier);
			localConfig.SetIsSetSkinToAllSoldier(isSetSkinToAllSoldier);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190B5 RID: 102581 RVA: 0x00722400 File Offset: 0x00720600
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateGMUser(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			bool isGMUser;
			LuaObject.checkType(l, 2, out isGMUser);
			localConfig.UpdateGMUser(isGMUser);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190B6 RID: 102582 RVA: 0x00722458 File Offset: 0x00720658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Data(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig localConfig = (LocalConfig)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfig.Data);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190B7 RID: 102583 RVA: 0x007224AC File Offset: 0x007206AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LocalConfig.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190B8 RID: 102584 RVA: 0x007224F4 File Offset: 0x007206F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Instance(IntPtr l)
	{
		int result;
		try
		{
			LocalConfig instance;
			LuaObject.checkType<LocalConfig>(l, 2, out instance);
			LocalConfig.Instance = instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190B9 RID: 102585 RVA: 0x00722540 File Offset: 0x00720740
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.LocalConfig");
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.SetFileName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.Save);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.Load);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.ApplyVolume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.Apply);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.AddRecentLoginServerID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.SetAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.IsAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.ClearAutoBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.SetTestUIId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.GetTestUIId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.SetBattleDanmakuState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.SetHeroListSortType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.SetIsOnlyShowCurJobSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.SetIsSetSkinToAllSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.UpdateGMUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cacheF);
		string name = "Data";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.get_Data);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache10, null, true);
		string name2 = "Instance";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.get_Instance);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.set_Instance);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache12, false);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfig.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_LocalConfig.<>f__mg$cache13, typeof(LocalConfig));
	}

	// Token: 0x0400F537 RID: 62775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F538 RID: 62776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F539 RID: 62777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F53A RID: 62778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F53B RID: 62779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F53C RID: 62780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F53D RID: 62781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F53E RID: 62782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F53F RID: 62783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F540 RID: 62784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F541 RID: 62785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F542 RID: 62786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F543 RID: 62787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F544 RID: 62788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F545 RID: 62789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F546 RID: 62790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F547 RID: 62791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F548 RID: 62792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F549 RID: 62793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F54A RID: 62794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
