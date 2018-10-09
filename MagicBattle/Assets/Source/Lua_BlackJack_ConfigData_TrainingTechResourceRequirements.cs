using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200118B RID: 4491
[Preserve]
public class Lua_BlackJack_ConfigData_TrainingTechResourceRequirements : LuaObject
{
	// Token: 0x06016FE8 RID: 94184 RVA: 0x0062DE34 File Offset: 0x0062C034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements o = new TrainingTechResourceRequirements();
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

	// Token: 0x06016FE9 RID: 94185 RVA: 0x0062DE7C File Offset: 0x0062C07C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Addition(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements x;
			LuaObject.checkType<TrainingTechResourceRequirements>(l, 1, out x);
			TrainingTechResourceRequirements y;
			LuaObject.checkType<TrainingTechResourceRequirements>(l, 2, out y);
			TrainingTechResourceRequirements o = x + y;
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

	// Token: 0x06016FEA RID: 94186 RVA: 0x0062DEDC File Offset: 0x0062C0DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = (TrainingTechResourceRequirements)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechResourceRequirements.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FEB RID: 94187 RVA: 0x0062DF30 File Offset: 0x0062C130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = (TrainingTechResourceRequirements)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			trainingTechResourceRequirements.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FEC RID: 94188 RVA: 0x0062DF88 File Offset: 0x0062C188
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RoomLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = (TrainingTechResourceRequirements)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechResourceRequirements.RoomLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FED RID: 94189 RVA: 0x0062DFDC File Offset: 0x0062C1DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RoomLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = (TrainingTechResourceRequirements)LuaObject.checkSelf(l);
			int roomLevel;
			LuaObject.checkType(l, 2, out roomLevel);
			trainingTechResourceRequirements.RoomLevel = roomLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FEE RID: 94190 RVA: 0x0062E034 File Offset: 0x0062C234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreTechs(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = (TrainingTechResourceRequirements)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechResourceRequirements.PreTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FEF RID: 94191 RVA: 0x0062E088 File Offset: 0x0062C288
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PreTechs(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = (TrainingTechResourceRequirements)LuaObject.checkSelf(l);
			List<int> preTechs;
			LuaObject.checkType<List<int>>(l, 2, out preTechs);
			trainingTechResourceRequirements.PreTechs = preTechs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FF0 RID: 94192 RVA: 0x0062E0E0 File Offset: 0x0062C2E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PreTechLevels(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = (TrainingTechResourceRequirements)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechResourceRequirements.PreTechLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FF1 RID: 94193 RVA: 0x0062E134 File Offset: 0x0062C334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PreTechLevels(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = (TrainingTechResourceRequirements)LuaObject.checkSelf(l);
			List<int> preTechLevels;
			LuaObject.checkType<List<int>>(l, 2, out preTechLevels);
			trainingTechResourceRequirements.PreTechLevels = preTechLevels;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FF2 RID: 94194 RVA: 0x0062E18C File Offset: 0x0062C38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Materials(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = (TrainingTechResourceRequirements)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechResourceRequirements.Materials);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FF3 RID: 94195 RVA: 0x0062E1E0 File Offset: 0x0062C3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Materials(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechResourceRequirements trainingTechResourceRequirements = (TrainingTechResourceRequirements)LuaObject.checkSelf(l);
			List<Goods> materials;
			LuaObject.checkType<List<Goods>>(l, 2, out materials);
			trainingTechResourceRequirements.Materials = materials;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FF4 RID: 94196 RVA: 0x0062E238 File Offset: 0x0062C438
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.TrainingTechResourceRequirements");
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.op_Addition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache0);
		string name = "Gold";
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.get_Gold);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache1;
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.set_Gold);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache2, true);
		string name2 = "RoomLevel";
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.get_RoomLevel);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache3;
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.set_RoomLevel);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache4, true);
		string name3 = "PreTechs";
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.get_PreTechs);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache5;
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.set_PreTechs);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache6, true);
		string name4 = "PreTechLevels";
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.get_PreTechLevels);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache7;
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.set_PreTechLevels);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache8, true);
		string name5 = "Materials";
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.get_Materials);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cache9;
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.set_Materials);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cacheA, true);
		if (Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.<>f__mg$cacheB, typeof(TrainingTechResourceRequirements));
	}

	// Token: 0x0400D6B4 RID: 54964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D6B5 RID: 54965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D6B6 RID: 54966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D6B7 RID: 54967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D6B8 RID: 54968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D6B9 RID: 54969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D6BA RID: 54970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D6BB RID: 54971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D6BC RID: 54972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D6BD RID: 54973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D6BE RID: 54974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D6BF RID: 54975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
