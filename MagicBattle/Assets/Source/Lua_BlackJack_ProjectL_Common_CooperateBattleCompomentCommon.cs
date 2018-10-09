using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011EB RID: 4587
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon : LuaObject
{
	// Token: 0x06017C90 RID: 97424 RVA: 0x0068DC48 File Offset: 0x0068BE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon o = new CooperateBattleCompomentCommon();
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

	// Token: 0x06017C91 RID: 97425 RVA: 0x0068DC90 File Offset: 0x0068BE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			string name = cooperateBattleCompomentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C92 RID: 97426 RVA: 0x0068DCE4 File Offset: 0x0068BEE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			cooperateBattleCompomentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C93 RID: 97427 RVA: 0x0068DD30 File Offset: 0x0068BF30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			cooperateBattleCompomentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C94 RID: 97428 RVA: 0x0068DD7C File Offset: 0x0068BF7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			cooperateBattleCompomentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C95 RID: 97429 RVA: 0x0068DDC8 File Offset: 0x0068BFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			cooperateBattleCompomentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C96 RID: 97430 RVA: 0x0068DE20 File Offset: 0x0068C020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			cooperateBattleCompomentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C97 RID: 97431 RVA: 0x0068DE6C File Offset: 0x0068C06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckCooperateBattleAvailable(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			int cooperateBattleID;
			LuaObject.checkType(l, 2, out cooperateBattleID);
			int i;
			LuaObject.checkType(l, 3, out i);
			bool b = cooperateBattleCompomentCommon.CheckCooperateBattleAvailable(cooperateBattleID, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C98 RID: 97432 RVA: 0x0068DEE4 File Offset: 0x0068C0E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckCooperateBattleDisplayable(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			int cooperateBattleID;
			LuaObject.checkType(l, 2, out cooperateBattleID);
			bool b = cooperateBattleCompomentCommon.CheckCooperateBattleDisplayable(cooperateBattleID);
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

	// Token: 0x06017C99 RID: 97433 RVA: 0x0068DF48 File Offset: 0x0068C148
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = cooperateBattleCompomentCommon.IsLevelUnlocked(levelId);
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

	// Token: 0x06017C9A RID: 97434 RVA: 0x0068DFAC File Offset: 0x0068C1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = cooperateBattleCompomentCommon.IsLevelFinished(levelId);
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

	// Token: 0x06017C9B RID: 97435 RVA: 0x0068E010 File Offset: 0x0068C210
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllUnlockedLevels(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			List<int> allUnlockedLevels = cooperateBattleCompomentCommon.GetAllUnlockedLevels();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allUnlockedLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C9C RID: 97436 RVA: 0x0068E064 File Offset: 0x0068C264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			List<int> allFinishedLevels = cooperateBattleCompomentCommon.GetAllFinishedLevels();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allFinishedLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C9D RID: 97437 RVA: 0x0068E0B8 File Offset: 0x0068C2B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDailyChallengeNums(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int dailyChallengeNums = cooperateBattleCompomentCommon.GetDailyChallengeNums(battleId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dailyChallengeNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C9E RID: 97438 RVA: 0x0068E11C File Offset: 0x0068C31C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckCooperateBattleLevelAvailable(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i;
			LuaObject.checkType(l, 4, out i);
			bool b = cooperateBattleCompomentCommon.CheckCooperateBattleLevelAvailable(battleId, levelId, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C9F RID: 97439 RVA: 0x0068E1A0 File Offset: 0x0068C3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckPlayerOutOfBattle(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			bool b = cooperateBattleCompomentCommon.CheckPlayerOutOfBattle(ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CA0 RID: 97440 RVA: 0x0068E20C File Offset: 0x0068C40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckEnergy(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i;
			LuaObject.checkType(l, 4, out i);
			bool b = cooperateBattleCompomentCommon.CheckEnergy(battleId, levelId, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CA1 RID: 97441 RVA: 0x0068E290 File Offset: 0x0068C490
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckBag(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			int cooperateBattleId;
			LuaObject.checkType(l, 2, out cooperateBattleId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			int i;
			LuaObject.checkType(l, 4, out i);
			bool b = cooperateBattleCompomentCommon.CheckBag(cooperateBattleId, levelId, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CA2 RID: 97442 RVA: 0x0068E314 File Offset: 0x0068C514
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
				int levelId;
				LuaObject.checkType(l, 2, out levelId);
				int i = cooperateBattleCompomentCommon.CanAttackCooperateBattleLevel(levelId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				CooperateBattleCompomentCommon cooperateBattleCompomentCommon2 = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
				int battleId;
				LuaObject.checkType(l, 2, out battleId);
				int levelId2;
				LuaObject.checkType(l, 3, out levelId2);
				int i2 = cooperateBattleCompomentCommon2.CanAttackCooperateBattleLevel(battleId, levelId2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CanAttackCooperateBattleLevel to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CA3 RID: 97443 RVA: 0x0068E3EC File Offset: 0x0068C5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCommonSuccessCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo level;
			LuaObject.checkType<ConfigDataCooperateBattleLevelInfo>(l, 2, out level);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 3, out heroes);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			cooperateBattleCompomentCommon.SetCommonSuccessCooperateBattleLevel(level, heroes, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CA4 RID: 97444 RVA: 0x0068E460 File Offset: 0x0068C660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushChallengNums(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			cooperateBattleCompomentCommon.m_luaExportHelper.FlushChallengNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CA5 RID: 97445 RVA: 0x0068E4B4 File Offset: 0x0068C6B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsGameFunctionOpened(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			bool b = cooperateBattleCompomentCommon.m_luaExportHelper.IsGameFunctionOpened();
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

	// Token: 0x06017CA6 RID: 97446 RVA: 0x0068E510 File Offset: 0x0068C710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FinishedCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			CooperateBattleLevel level;
			LuaObject.checkType<CooperateBattleLevel>(l, 2, out level);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 3, out heroes);
			cooperateBattleCompomentCommon.m_luaExportHelper.FinishedCooperateBattleLevel(level, heroes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CA7 RID: 97447 RVA: 0x0068E57C File Offset: 0x0068C77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_CompleteCooperateBattleMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			cooperateBattleCompomentCommon.m_luaExportHelper.__callDele_CompleteCooperateBattleMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CA8 RID: 97448 RVA: 0x0068E5F4 File Offset: 0x0068C7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_CompleteCooperateBattleMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			cooperateBattleCompomentCommon.m_luaExportHelper.__clearDele_CompleteCooperateBattleMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CA9 RID: 97449 RVA: 0x0068E66C File Offset: 0x0068C86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCompomentCommon.m_luaExportHelper._configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CAA RID: 97450 RVA: 0x0068E6C4 File Offset: 0x0068C8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			cooperateBattleCompomentCommon.m_luaExportHelper._configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CAB RID: 97451 RVA: 0x0068E720 File Offset: 0x0068C920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cooperateBattleDS(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCompomentCommon.m_luaExportHelper.m_cooperateBattleDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CAC RID: 97452 RVA: 0x0068E778 File Offset: 0x0068C978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cooperateBattleDS(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			DataSectionCooperateBattle cooperateBattleDS;
			LuaObject.checkType<DataSectionCooperateBattle>(l, 2, out cooperateBattleDS);
			cooperateBattleCompomentCommon.m_luaExportHelper.m_cooperateBattleDS = cooperateBattleDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CAD RID: 97453 RVA: 0x0068E7D4 File Offset: 0x0068C9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCompomentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CAE RID: 97454 RVA: 0x0068E82C File Offset: 0x0068CA2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			cooperateBattleCompomentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CAF RID: 97455 RVA: 0x0068E888 File Offset: 0x0068CA88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCompomentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CB0 RID: 97456 RVA: 0x0068E8E0 File Offset: 0x0068CAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			cooperateBattleCompomentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CB1 RID: 97457 RVA: 0x0068E93C File Offset: 0x0068CB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCompomentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CB2 RID: 97458 RVA: 0x0068E994 File Offset: 0x0068CB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			cooperateBattleCompomentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CB3 RID: 97459 RVA: 0x0068E9F0 File Offset: 0x0068CBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCompomentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CB4 RID: 97460 RVA: 0x0068EA48 File Offset: 0x0068CC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			cooperateBattleCompomentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CB5 RID: 97461 RVA: 0x0068EAA4 File Offset: 0x0068CCA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCompomentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CB6 RID: 97462 RVA: 0x0068EAFC File Offset: 0x0068CCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			cooperateBattleCompomentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CB7 RID: 97463 RVA: 0x0068EB58 File Offset: 0x0068CD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CompleteCooperateBattleMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			Action<BattleType, int, List<int>> value;
			int num = LuaObject.checkDelegate<Action<BattleType, int, List<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					cooperateBattleCompomentCommon.CompleteCooperateBattleMissionEvent += value;
				}
				else if (num == 2)
				{
					cooperateBattleCompomentCommon.CompleteCooperateBattleMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CB8 RID: 97464 RVA: 0x0068EBD8 File Offset: 0x0068CDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCompomentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CB9 RID: 97465 RVA: 0x0068EC2C File Offset: 0x0068CE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			cooperateBattleCompomentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CBA RID: 97466 RVA: 0x0068EC84 File Offset: 0x0068CE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCompomentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CBB RID: 97467 RVA: 0x0068ECDC File Offset: 0x0068CEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCompomentCommon cooperateBattleCompomentCommon = (CooperateBattleCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			cooperateBattleCompomentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CBC RID: 97468 RVA: 0x0068ED38 File Offset: 0x0068CF38
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CooperateBattleCompomentCommon");
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.CheckCooperateBattleAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.CheckCooperateBattleDisplayable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.GetAllUnlockedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.GetDailyChallengeNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.CheckCooperateBattleLevelAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.CheckPlayerOutOfBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.CheckEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.CheckBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.CanAttackCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.SetCommonSuccessCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.FlushChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.IsGameFunctionOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.FinishedCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.__callDele_CompleteCooperateBattleMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.__clearDele_CompleteCooperateBattleMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache17);
		string name = "_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.get__configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.set__configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache19, true);
		string name2 = "m_cooperateBattleDS";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.get_m_cooperateBattleDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.set_m_cooperateBattleDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1B, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1D, true);
		string name4 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.get_m_battle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache1F, true);
		string name5 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.get_m_bag);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache21, true);
		string name6 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.get_m_hero);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache23, true);
		string name7 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.get_m_rift);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache25, true);
		string name8 = "CompleteCooperateBattleMissionEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.set_CompleteCooperateBattleMissionEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache26, true);
		string name9 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.get_Owner);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.set_Owner);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache28, true);
		string name10 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache2A, true);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.<>f__mg$cache2B, typeof(CooperateBattleCompomentCommon));
	}

	// Token: 0x0400E29C RID: 58012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E29D RID: 58013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E29E RID: 58014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E29F RID: 58015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E2A0 RID: 58016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E2A1 RID: 58017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E2A2 RID: 58018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E2A3 RID: 58019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E2A4 RID: 58020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E2A5 RID: 58021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E2A6 RID: 58022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E2A7 RID: 58023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E2A8 RID: 58024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E2A9 RID: 58025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E2AA RID: 58026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E2AB RID: 58027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E2AC RID: 58028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E2AD RID: 58029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E2AE RID: 58030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E2AF RID: 58031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E2B0 RID: 58032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E2B1 RID: 58033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E2B2 RID: 58034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E2B3 RID: 58035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E2B4 RID: 58036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E2B5 RID: 58037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E2B6 RID: 58038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E2B7 RID: 58039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E2B8 RID: 58040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E2B9 RID: 58041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E2BA RID: 58042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E2BB RID: 58043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E2BC RID: 58044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E2BD RID: 58045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E2BE RID: 58046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E2BF RID: 58047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E2C0 RID: 58048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E2C1 RID: 58049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E2C2 RID: 58050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E2C3 RID: 58051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E2C4 RID: 58052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E2C5 RID: 58053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E2C6 RID: 58054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E2C7 RID: 58055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
