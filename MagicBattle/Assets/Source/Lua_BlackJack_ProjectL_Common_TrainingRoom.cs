using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200128D RID: 4749
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TrainingRoom : LuaObject
{
	// Token: 0x06018BFD RID: 101373 RVA: 0x00700138 File Offset: 0x006FE338
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom o = new TrainingRoom();
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

	// Token: 0x06018BFE RID: 101374 RVA: 0x00700180 File Offset: 0x006FE380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReloadConfigData(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			trainingRoom.ReloadConfigData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BFF RID: 101375 RVA: 0x007001CC File Offset: 0x006FE3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateInstantiatedData(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			List<TrainingTech> availableTechs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out availableTechs);
			trainingRoom.UpdateInstantiatedData(availableTechs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C00 RID: 101376 RVA: 0x00700224 File Offset: 0x006FE424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Courses(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingRoom.Courses);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C01 RID: 101377 RVA: 0x00700278 File Offset: 0x006FE478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Courses(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			List<TrainingCourse> courses;
			LuaObject.checkType<List<TrainingCourse>>(l, 2, out courses);
			trainingRoom.Courses = courses;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C02 RID: 101378 RVA: 0x007002D0 File Offset: 0x006FE4D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigId(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingRoom.ConfigId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C03 RID: 101379 RVA: 0x00700324 File Offset: 0x006FE524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ConfigId(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			int configId;
			LuaObject.checkType(l, 2, out configId);
			trainingRoom.ConfigId = configId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C04 RID: 101380 RVA: 0x0070037C File Offset: 0x006FE57C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AnikiGymLevelRequired(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingRoom.AnikiGymLevelRequired);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C05 RID: 101381 RVA: 0x007003D0 File Offset: 0x006FE5D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WhichTrainingGround(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingRoom.WhichTrainingGround);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C06 RID: 101382 RVA: 0x00700424 File Offset: 0x006FE624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WhichTrainingGround(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			TrainingGround whichTrainingGround;
			LuaObject.checkType<TrainingGround>(l, 2, out whichTrainingGround);
			trainingRoom.WhichTrainingGround = whichTrainingGround;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C07 RID: 101383 RVA: 0x0070047C File Offset: 0x006FE67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingRoom.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C08 RID: 101384 RVA: 0x007004D0 File Offset: 0x006FE6D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingRoom.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C09 RID: 101385 RVA: 0x00700524 File Offset: 0x006FE724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			trainingRoom.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C0A RID: 101386 RVA: 0x0070057C File Offset: 0x006FE77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingRoom.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C0B RID: 101387 RVA: 0x007005D0 File Offset: 0x006FE7D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TotalExp(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingRoom.TotalExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C0C RID: 101388 RVA: 0x00700624 File Offset: 0x006FE824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Exp(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingRoom.Exp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C0D RID: 101389 RVA: 0x00700678 File Offset: 0x006FE878
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Locked(IntPtr l)
	{
		int result;
		try
		{
			TrainingRoom trainingRoom = (TrainingRoom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingRoom.Locked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C0E RID: 101390 RVA: 0x007006CC File Offset: 0x006FE8CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TrainingRoom");
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.ReloadConfigData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.UpdateInstantiatedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache1);
		string name = "Courses";
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.get_Courses);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.set_Courses);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache3, true);
		string name2 = "ConfigId";
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.get_ConfigId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.set_ConfigId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache5, true);
		string name3 = "AnikiGymLevelRequired";
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.get_AnikiGymLevelRequired);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache6, null, true);
		string name4 = "WhichTrainingGround";
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.get_WhichTrainingGround);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.set_WhichTrainingGround);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache8, true);
		string name5 = "Config";
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.get_Config);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache9, null, true);
		string name6 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.get_ConfigDataLoader);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name6, get4, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheB, true);
		string name7 = "Level";
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.get_Level);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheC, null, true);
		string name8 = "TotalExp";
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.get_TotalExp);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheD, null, true);
		string name9 = "Exp";
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.get_Exp);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheE, null, true);
		string name10 = "Locked";
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.get_Locked);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cacheF, null, true);
		if (Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingRoom.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TrainingRoom.<>f__mg$cache10, typeof(TrainingRoom));
	}

	// Token: 0x0400F0C5 RID: 61637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F0C6 RID: 61638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F0C7 RID: 61639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F0C8 RID: 61640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F0C9 RID: 61641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F0CA RID: 61642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F0CB RID: 61643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F0CC RID: 61644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F0CD RID: 61645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F0CE RID: 61646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F0CF RID: 61647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F0D0 RID: 61648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F0D1 RID: 61649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F0D2 RID: 61650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F0D3 RID: 61651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F0D4 RID: 61652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F0D5 RID: 61653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
