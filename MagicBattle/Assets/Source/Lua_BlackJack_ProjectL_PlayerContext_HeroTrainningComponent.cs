using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012CE RID: 4814
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent : LuaObject
{
	// Token: 0x0601961A RID: 103962 RVA: 0x0074C3CC File Offset: 0x0074A5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent o = new HeroTrainningComponent();
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

	// Token: 0x0601961B RID: 103963 RVA: 0x0074C414 File Offset: 0x0074A614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			heroTrainningComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601961C RID: 103964 RVA: 0x0074C460 File Offset: 0x0074A660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			heroTrainningComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601961D RID: 103965 RVA: 0x0074C4AC File Offset: 0x0074A6AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			heroTrainningComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601961E RID: 103966 RVA: 0x0074C4F8 File Offset: 0x0074A6F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			ushort dsversion = heroTrainningComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601961F RID: 103967 RVA: 0x0074C54C File Offset: 0x0074A74C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			DSHeroTrainningNtf msg;
			LuaObject.checkType<DSHeroTrainningNtf>(l, 2, out msg);
			heroTrainningComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019620 RID: 103968 RVA: 0x0074C5A4 File Offset: 0x0074A7A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCurrentTicketNums(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			int currentTicketNums = heroTrainningComponent.GetCurrentTicketNums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentTicketNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019621 RID: 103969 RVA: 0x0074C5F8 File Offset: 0x0074A7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isWin;
			LuaObject.checkType(l, 3, out isWin);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			int i = heroTrainningComponent.FinishedHeroTrainningLevel(levelId, isWin, battleTreasures);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019622 RID: 103970 RVA: 0x0074C674 File Offset: 0x0074A874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuccessHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			bool isTeamBattle;
			LuaObject.checkType(l, 5, out isTeamBattle);
			heroTrainningComponent.SetSuccessHeroTrainningLevel(levelInfo, battleTreasures, heroes, isTeamBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019623 RID: 103971 RVA: 0x0074C6F4 File Offset: 0x0074A8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsHeroTrainningOpened(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			int heroTrainningId;
			LuaObject.checkType(l, 2, out heroTrainningId);
			bool b = heroTrainningComponent.IsHeroTrainningOpened(heroTrainningId);
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

	// Token: 0x06019624 RID: 103972 RVA: 0x0074C758 File Offset: 0x0074A958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsHeroTrainningLevelOpened(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = heroTrainningComponent.IsHeroTrainningLevelOpened(levelId);
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

	// Token: 0x06019625 RID: 103973 RVA: 0x0074C7BC File Offset: 0x0074A9BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			string s = heroTrainningComponent.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019626 RID: 103974 RVA: 0x0074C818 File Offset: 0x0074AA18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			heroTrainningComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019627 RID: 103975 RVA: 0x0074C86C File Offset: 0x0074AA6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			heroTrainningComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019628 RID: 103976 RVA: 0x0074C8C0 File Offset: 0x0074AAC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			heroTrainningComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019629 RID: 103977 RVA: 0x0074C914 File Offset: 0x0074AB14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			heroTrainningComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601962A RID: 103978 RVA: 0x0074C970 File Offset: 0x0074AB70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			heroTrainningComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601962B RID: 103979 RVA: 0x0074C9C4 File Offset: 0x0074ABC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AttackHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroTrainningComponent.m_luaExportHelper.__callBase_AttackHeroTrainningLevel(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601962C RID: 103980 RVA: 0x0074CA2C File Offset: 0x0074AC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = heroTrainningComponent.m_luaExportHelper.__callBase_CanAttackHeroTrainningLevel(levelId, isTeamBattle);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601962D RID: 103981 RVA: 0x0074CAA0 File Offset: 0x0074ACA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = heroTrainningComponent.m_luaExportHelper.__callBase_IsLevelFinished(levelId);
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

	// Token: 0x0601962E RID: 103982 RVA: 0x0074CB08 File Offset: 0x0074AD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCommonSuccessHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			int energyCost;
			LuaObject.checkType(l, 5, out energyCost);
			bool isBattleTeam;
			LuaObject.checkType(l, 6, out isBattleTeam);
			heroTrainningComponent.m_luaExportHelper.__callBase_SetCommonSuccessHeroTrainningLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601962F RID: 103983 RVA: 0x0074CB98 File Offset: 0x0074AD98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			HashSet<int> o = heroTrainningComponent.m_luaExportHelper.__callBase_GetAllFinishedLevels();
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

	// Token: 0x06019630 RID: 103984 RVA: 0x0074CBF4 File Offset: 0x0074ADF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsDailyChallenge(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			bool b = heroTrainningComponent.m_luaExportHelper.__callBase_IsDailyChallenge();
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

	// Token: 0x06019631 RID: 103985 RVA: 0x0074CC50 File Offset: 0x0074AE50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetDailyChallengNums(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			int i = heroTrainningComponent.m_luaExportHelper.__callBase_GetDailyChallengNums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019632 RID: 103986 RVA: 0x0074CCAC File Offset: 0x0074AEAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			heroTrainningComponent.m_luaExportHelper.__callBase_AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019633 RID: 103987 RVA: 0x0074CD08 File Offset: 0x0074AF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllUnlockedLevels(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			List<int> o = heroTrainningComponent.m_luaExportHelper.__callBase_GetAllUnlockedLevels();
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

	// Token: 0x06019634 RID: 103988 RVA: 0x0074CD64 File Offset: 0x0074AF64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningComponent heroTrainningComponent = (HeroTrainningComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = heroTrainningComponent.m_luaExportHelper.__callBase_IsLevelUnlocked(levelId);
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

	// Token: 0x06019635 RID: 103989 RVA: 0x0074CDCC File Offset: 0x0074AFCC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.HeroTrainningComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.GetCurrentTicketNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.FinishedHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.SetSuccessHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.IsHeroTrainningOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.IsHeroTrainningLevelOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_AttackHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_CanAttackHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_SetCommonSuccessHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_IsDailyChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_GetDailyChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_GetAllUnlockedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.__callBase_IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.<>f__mg$cache1A, typeof(HeroTrainningComponent), typeof(HeroTrainningComponentCommon));
	}

	// Token: 0x0400FA60 RID: 64096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FA61 RID: 64097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FA62 RID: 64098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FA63 RID: 64099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FA64 RID: 64100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FA65 RID: 64101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FA66 RID: 64102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FA67 RID: 64103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400FA68 RID: 64104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400FA69 RID: 64105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400FA6A RID: 64106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400FA6B RID: 64107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400FA6C RID: 64108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400FA6D RID: 64109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400FA6E RID: 64110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400FA6F RID: 64111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400FA70 RID: 64112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400FA71 RID: 64113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400FA72 RID: 64114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400FA73 RID: 64115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400FA74 RID: 64116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400FA75 RID: 64117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400FA76 RID: 64118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400FA77 RID: 64119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400FA78 RID: 64120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400FA79 RID: 64121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400FA7A RID: 64122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
