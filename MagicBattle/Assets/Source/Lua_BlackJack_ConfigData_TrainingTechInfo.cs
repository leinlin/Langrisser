using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200118A RID: 4490
[Preserve]
public class Lua_BlackJack_ConfigData_TrainingTechInfo : LuaObject
{
	// Token: 0x06016FCC RID: 94156 RVA: 0x0062D1C8 File Offset: 0x0062B3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo o = new TrainingTechInfo();
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

	// Token: 0x06016FCD RID: 94157 RVA: 0x0062D210 File Offset: 0x0062B410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FCE RID: 94158 RVA: 0x0062D264 File Offset: 0x0062B464
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			trainingTechInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FCF RID: 94159 RVA: 0x0062D2BC File Offset: 0x0062B4BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TechID(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.TechID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FD0 RID: 94160 RVA: 0x0062D310 File Offset: 0x0062B510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TechID(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			int techID;
			LuaObject.checkType(l, 2, out techID);
			trainingTechInfo.TechID = techID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FD1 RID: 94161 RVA: 0x0062D368 File Offset: 0x0062B568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomExp(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.RoomExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FD2 RID: 94162 RVA: 0x0062D3BC File Offset: 0x0062B5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomExp(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			int roomExp;
			LuaObject.checkType(l, 2, out roomExp);
			trainingTechInfo.RoomExp = roomExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FD3 RID: 94163 RVA: 0x0062D414 File Offset: 0x0062B614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierIDUnlocked(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.SoldierIDUnlocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FD4 RID: 94164 RVA: 0x0062D468 File Offset: 0x0062B668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierIDUnlocked(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			int soldierIDUnlocked;
			LuaObject.checkType(l, 2, out soldierIDUnlocked);
			trainingTechInfo.SoldierIDUnlocked = soldierIDUnlocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FD5 RID: 94165 RVA: 0x0062D4C0 File Offset: 0x0062B6C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierSkillLevelup(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.SoldierSkillLevelup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FD6 RID: 94166 RVA: 0x0062D514 File Offset: 0x0062B714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierSkillLevelup(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			int soldierSkillLevelup;
			LuaObject.checkType(l, 2, out soldierSkillLevelup);
			trainingTechInfo.SoldierSkillLevelup = soldierSkillLevelup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FD7 RID: 94167 RVA: 0x0062D56C File Offset: 0x0062B76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierSkillID(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.SoldierSkillID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FD8 RID: 94168 RVA: 0x0062D5C0 File Offset: 0x0062B7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierSkillID(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			int soldierSkillID;
			LuaObject.checkType(l, 2, out soldierSkillID);
			trainingTechInfo.SoldierSkillID = soldierSkillID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FD9 RID: 94169 RVA: 0x0062D618 File Offset: 0x0062B818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FDA RID: 94170 RVA: 0x0062D66C File Offset: 0x0062B86C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			trainingTechInfo.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FDB RID: 94171 RVA: 0x0062D6C4 File Offset: 0x0062B8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.RoomLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FDC RID: 94172 RVA: 0x0062D718 File Offset: 0x0062B918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			int roomLevel;
			LuaObject.checkType(l, 2, out roomLevel);
			trainingTechInfo.RoomLevel = roomLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FDD RID: 94173 RVA: 0x0062D770 File Offset: 0x0062B970
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Materials(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.Materials);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FDE RID: 94174 RVA: 0x0062D7C4 File Offset: 0x0062B9C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Materials(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			List<Goods> materials;
			LuaObject.checkType<List<Goods>>(l, 2, out materials);
			trainingTechInfo.Materials = materials;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FDF RID: 94175 RVA: 0x0062D81C File Offset: 0x0062BA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreIds(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.PreIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FE0 RID: 94176 RVA: 0x0062D870 File Offset: 0x0062BA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PreIds(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			List<int> preIds;
			LuaObject.checkType<List<int>>(l, 2, out preIds);
			trainingTechInfo.PreIds = preIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FE1 RID: 94177 RVA: 0x0062D8C8 File Offset: 0x0062BAC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PreTechLevels(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.PreTechLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FE2 RID: 94178 RVA: 0x0062D91C File Offset: 0x0062BB1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PreTechLevels(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			List<int> preTechLevels;
			LuaObject.checkType<List<int>>(l, 2, out preTechLevels);
			trainingTechInfo.PreTechLevels = preTechLevels;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FE3 RID: 94179 RVA: 0x0062D974 File Offset: 0x0062BB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FE4 RID: 94180 RVA: 0x0062D9C8 File Offset: 0x0062BBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Config(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			ConfigDataTrainingTechLevelInfo config;
			LuaObject.checkType<ConfigDataTrainingTechLevelInfo>(l, 2, out config);
			trainingTechInfo.Config = config;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FE5 RID: 94181 RVA: 0x0062DA20 File Offset: 0x0062BC20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LevelupRequirements(IntPtr l)
	{
		int result;
		try
		{
			TrainingTechInfo trainingTechInfo = (TrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechInfo.LevelupRequirements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FE6 RID: 94182 RVA: 0x0062DA74 File Offset: 0x0062BC74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.TrainingTechInfo");
		string name = "ID";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_ID);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_ID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache1, true);
		string name2 = "TechID";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_TechID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_TechID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache3, true);
		string name3 = "RoomExp";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_RoomExp);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_RoomExp);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache5, true);
		string name4 = "SoldierIDUnlocked";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_SoldierIDUnlocked);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_SoldierIDUnlocked);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache7, true);
		string name5 = "SoldierSkillLevelup";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_SoldierSkillLevelup);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_SoldierSkillLevelup);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache9, true);
		string name6 = "SoldierSkillID";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_SoldierSkillID);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_SoldierSkillID);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheB, true);
		string name7 = "Gold";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_Gold);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_Gold);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheD, true);
		string name8 = "RoomLevel";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_RoomLevel);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_RoomLevel);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cacheF, true);
		string name9 = "Materials";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_Materials);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_Materials);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache11, true);
		string name10 = "PreIds";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_PreIds);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_PreIds);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache13, true);
		string name11 = "PreTechLevels";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_PreTechLevels);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_PreTechLevels);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache15, true);
		string name12 = "Config";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_Config);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.set_Config);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache17, true);
		string name13 = "LevelupRequirements";
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.get_LevelupRequirements);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache18, null, true);
		if (Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_TrainingTechInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_TrainingTechInfo.<>f__mg$cache19, typeof(TrainingTechInfo));
	}

	// Token: 0x0400D69A RID: 54938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D69B RID: 54939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D69C RID: 54940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D69D RID: 54941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D69E RID: 54942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D69F RID: 54943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D6A0 RID: 54944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D6A1 RID: 54945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D6A2 RID: 54946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D6A3 RID: 54947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D6A4 RID: 54948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D6A5 RID: 54949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D6A6 RID: 54950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D6A7 RID: 54951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D6A8 RID: 54952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D6A9 RID: 54953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D6AA RID: 54954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D6AB RID: 54955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D6AC RID: 54956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D6AD RID: 54957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D6AE RID: 54958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D6AF RID: 54959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D6B0 RID: 54960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D6B1 RID: 54961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D6B2 RID: 54962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D6B3 RID: 54963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
