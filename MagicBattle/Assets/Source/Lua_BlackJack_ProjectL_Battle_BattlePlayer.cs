using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001199 RID: 4505
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattlePlayer : LuaObject
{
	// Token: 0x06017407 RID: 95239 RVA: 0x0064EC78 File Offset: 0x0064CE78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayer o = new BattlePlayer();
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

	// Token: 0x06017408 RID: 95240 RVA: 0x0064ECC0 File Offset: 0x0064CEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTrainingTechSoldierSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayer battlePlayer = (BattlePlayer)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out soldierInfo);
			int i;
			List<ConfigDataSkillInfo> trainingTechSoldierSkillInfos = battlePlayer.GetTrainingTechSoldierSkillInfos(configDataLoader, soldierInfo, out i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechSoldierSkillInfos);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017409 RID: 95241 RVA: 0x0064ED3C File Offset: 0x0064CF3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTrainingTechSummonSkills(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayer battlePlayer = (BattlePlayer)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 3, out heroInfo);
			List<ConfigDataSkillInfo> trainingTechSummonSkills = battlePlayer.GetTrainingTechSummonSkills(configDataLoader, heroInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTechSummonSkills);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601740A RID: 95242 RVA: 0x0064EDAC File Offset: 0x0064CFAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SessionId(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayer battlePlayer = (BattlePlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePlayer.SessionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601740B RID: 95243 RVA: 0x0064EE00 File Offset: 0x0064D000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SessionId(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayer battlePlayer = (BattlePlayer)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			battlePlayer.SessionId = sessionId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601740C RID: 95244 RVA: 0x0064EE58 File Offset: 0x0064D058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayer battlePlayer = (BattlePlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePlayer.PlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601740D RID: 95245 RVA: 0x0064EEAC File Offset: 0x0064D0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayer battlePlayer = (BattlePlayer)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			battlePlayer.PlayerLevel = playerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601740E RID: 95246 RVA: 0x0064EF04 File Offset: 0x0064D104
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TrainingTechs(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayer battlePlayer = (BattlePlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePlayer.TrainingTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601740F RID: 95247 RVA: 0x0064EF58 File Offset: 0x0064D158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TrainingTechs(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayer battlePlayer = (BattlePlayer)LuaObject.checkSelf(l);
			BattlePlayerTrainingTech[] trainingTechs;
			LuaObject.checkArray<BattlePlayerTrainingTech>(l, 2, out trainingTechs);
			battlePlayer.TrainingTechs = trainingTechs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017410 RID: 95248 RVA: 0x0064EFB0 File Offset: 0x0064D1B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattlePlayer");
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayer.GetTrainingTechSoldierSkillInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayer.GetTrainingTechSummonSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache1);
		string name = "SessionId";
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayer.get_SessionId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayer.set_SessionId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache3, true);
		string name2 = "PlayerLevel";
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayer.get_PlayerLevel);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayer.set_PlayerLevel);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache5, true);
		string name3 = "TrainingTechs";
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayer.get_TrainingTechs);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayer.set_TrainingTechs);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattlePlayer.<>f__mg$cache8, typeof(BattlePlayer));
	}

	// Token: 0x0400DAB7 RID: 55991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DAB8 RID: 55992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DAB9 RID: 55993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DABA RID: 55994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DABB RID: 55995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DABC RID: 55996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DABD RID: 55997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DABE RID: 55998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DABF RID: 55999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
