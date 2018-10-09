using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200128A RID: 4746
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TrainingCourse : LuaObject
{
	// Token: 0x06018BAD RID: 101293 RVA: 0x006FDB70 File Offset: 0x006FBD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse o = new TrainingCourse();
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

	// Token: 0x06018BAE RID: 101294 RVA: 0x006FDBB8 File Offset: 0x006FBDB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReloadConfigData(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			trainingCourse.ReloadConfigData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BAF RID: 101295 RVA: 0x006FDC04 File Offset: 0x006FBE04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateInstantiatedData(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			List<TrainingTech> availableTechs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out availableTechs);
			trainingCourse.UpdateInstantiatedData(availableTechs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BB0 RID: 101296 RVA: 0x006FDC5C File Offset: 0x006FBE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Techs(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingCourse.Techs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BB1 RID: 101297 RVA: 0x006FDCB0 File Offset: 0x006FBEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Techs(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out techs);
			trainingCourse.Techs = techs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BB2 RID: 101298 RVA: 0x006FDD08 File Offset: 0x006FBF08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigId(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingCourse.ConfigId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BB3 RID: 101299 RVA: 0x006FDD5C File Offset: 0x006FBF5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ConfigId(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			int configId;
			LuaObject.checkType(l, 2, out configId);
			trainingCourse.ConfigId = configId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BB4 RID: 101300 RVA: 0x006FDDB4 File Offset: 0x006FBFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomLevelRequired(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingCourse.RoomLevelRequired);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BB5 RID: 101301 RVA: 0x006FDE08 File Offset: 0x006FC008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WhichRoom(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingCourse.WhichRoom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BB6 RID: 101302 RVA: 0x006FDE5C File Offset: 0x006FC05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WhichRoom(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			TrainingRoom whichRoom;
			LuaObject.checkType<TrainingRoom>(l, 2, out whichRoom);
			trainingCourse.WhichRoom = whichRoom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BB7 RID: 101303 RVA: 0x006FDEB4 File Offset: 0x006FC0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingCourse.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BB8 RID: 101304 RVA: 0x006FDF08 File Offset: 0x006FC108
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingCourse.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BB9 RID: 101305 RVA: 0x006FDF5C File Offset: 0x006FC15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			trainingCourse.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BBA RID: 101306 RVA: 0x006FDFB4 File Offset: 0x006FC1B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Locked(IntPtr l)
	{
		int result;
		try
		{
			TrainingCourse trainingCourse = (TrainingCourse)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingCourse.Locked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BBB RID: 101307 RVA: 0x006FE008 File Offset: 0x006FC208
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TrainingCourse");
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.ReloadConfigData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.UpdateInstantiatedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache1);
		string name = "Techs";
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.get_Techs);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.set_Techs);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache3, true);
		string name2 = "ConfigId";
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.get_ConfigId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.set_ConfigId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache5, true);
		string name3 = "RoomLevelRequired";
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.get_RoomLevelRequired);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache6, null, true);
		string name4 = "WhichRoom";
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.get_WhichRoom);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.set_WhichRoom);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache8, true);
		string name5 = "Config";
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.get_Config);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cache9, null, true);
		string name6 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.get_ConfigDataLoader);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name6, get4, Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheB, true);
		string name7 = "Locked";
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.get_Locked);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheC, null, true);
		if (Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingCourse.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TrainingCourse.<>f__mg$cacheD, typeof(TrainingCourse));
	}

	// Token: 0x0400F07B RID: 61563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F07C RID: 61564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F07D RID: 61565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F07E RID: 61566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F07F RID: 61567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F080 RID: 61568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F081 RID: 61569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F082 RID: 61570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F083 RID: 61571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F084 RID: 61572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F085 RID: 61573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F086 RID: 61574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F087 RID: 61575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F088 RID: 61576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
