using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200119A RID: 4506
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech : LuaObject
{
	// Token: 0x06017412 RID: 95250 RVA: 0x0064F118 File Offset: 0x0064D318
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayerTrainingTech o = new BattlePlayerTrainingTech();
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

	// Token: 0x06017413 RID: 95251 RVA: 0x0064F160 File Offset: 0x0064D360
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TrainingTechInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayerTrainingTech battlePlayerTrainingTech = (BattlePlayerTrainingTech)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePlayerTrainingTech.TrainingTechInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017414 RID: 95252 RVA: 0x0064F1B4 File Offset: 0x0064D3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TrainingTechInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayerTrainingTech battlePlayerTrainingTech = (BattlePlayerTrainingTech)LuaObject.checkSelf(l);
			ConfigDataTrainingTechInfo trainingTechInfo;
			LuaObject.checkType<ConfigDataTrainingTechInfo>(l, 2, out trainingTechInfo);
			battlePlayerTrainingTech.TrainingTechInfo = trainingTechInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017415 RID: 95253 RVA: 0x0064F20C File Offset: 0x0064D40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayerTrainingTech battlePlayerTrainingTech = (BattlePlayerTrainingTech)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePlayerTrainingTech.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017416 RID: 95254 RVA: 0x0064F260 File Offset: 0x0064D460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			BattlePlayerTrainingTech battlePlayerTrainingTech = (BattlePlayerTrainingTech)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			battlePlayerTrainingTech.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017417 RID: 95255 RVA: 0x0064F2B8 File Offset: 0x0064D4B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattlePlayerTrainingTech");
		string name = "TrainingTechInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.get_TrainingTechInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.set_TrainingTechInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache1, true);
		string name2 = "Level";
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.get_Level);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.set_Level);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.<>f__mg$cache4, typeof(BattlePlayerTrainingTech));
	}

	// Token: 0x0400DAC0 RID: 56000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DAC1 RID: 56001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DAC2 RID: 56002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DAC3 RID: 56003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DAC4 RID: 56004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
