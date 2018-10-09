using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012E5 RID: 4837
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent : LuaObject
{
	// Token: 0x0601A0AE RID: 106670 RVA: 0x007A4DF8 File Offset: 0x007A2FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent o = new ThearchyTrialComponent();
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

	// Token: 0x0601A0AF RID: 106671 RVA: 0x007A4E40 File Offset: 0x007A3040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			thearchyTrialComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0B0 RID: 106672 RVA: 0x007A4E8C File Offset: 0x007A308C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			thearchyTrialComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0B1 RID: 106673 RVA: 0x007A4ED8 File Offset: 0x007A30D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			thearchyTrialComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0B2 RID: 106674 RVA: 0x007A4F24 File Offset: 0x007A3124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			DSThearchyTrialNtf msg;
			LuaObject.checkType<DSThearchyTrialNtf>(l, 2, out msg);
			thearchyTrialComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0B3 RID: 106675 RVA: 0x007A4F7C File Offset: 0x007A317C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			ushort dsversion = thearchyTrialComponent.GetDSVersion();
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

	// Token: 0x0601A0B4 RID: 106676 RVA: 0x007A4FD0 File Offset: 0x007A31D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentTicketNums(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			int currentTicketNums = thearchyTrialComponent.GetCurrentTicketNums();
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

	// Token: 0x0601A0B5 RID: 106677 RVA: 0x007A5024 File Offset: 0x007A3224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedThearchyTrialLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isWin;
			LuaObject.checkType(l, 3, out isWin);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			int i = thearchyTrialComponent.FinishedThearchyTrialLevel(levelId, isWin, battleTreasures);
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

	// Token: 0x0601A0B6 RID: 106678 RVA: 0x007A50A0 File Offset: 0x007A32A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuccessThearchyTrialLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			bool isTeamBattle;
			LuaObject.checkType(l, 5, out isTeamBattle);
			thearchyTrialComponent.SetSuccessThearchyTrialLevel(levelInfo, battleTreasures, heroes, isTeamBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0B7 RID: 106679 RVA: 0x007A5120 File Offset: 0x007A3320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsThearchyOpened(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			int thearchyId;
			LuaObject.checkType(l, 2, out thearchyId);
			bool b = thearchyTrialComponent.IsThearchyOpened(thearchyId);
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

	// Token: 0x0601A0B8 RID: 106680 RVA: 0x007A5184 File Offset: 0x007A3384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsThearchyLevelOpened(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = thearchyTrialComponent.IsThearchyLevelOpened(levelId);
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

	// Token: 0x0601A0B9 RID: 106681 RVA: 0x007A51E8 File Offset: 0x007A33E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			string s = thearchyTrialComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x0601A0BA RID: 106682 RVA: 0x007A5244 File Offset: 0x007A3444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			thearchyTrialComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0BB RID: 106683 RVA: 0x007A5298 File Offset: 0x007A3498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			thearchyTrialComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0BC RID: 106684 RVA: 0x007A52EC File Offset: 0x007A34EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			thearchyTrialComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0BD RID: 106685 RVA: 0x007A5340 File Offset: 0x007A3540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			thearchyTrialComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0BE RID: 106686 RVA: 0x007A539C File Offset: 0x007A359C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			thearchyTrialComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0BF RID: 106687 RVA: 0x007A53F0 File Offset: 0x007A35F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AttackThearchyTrialLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = thearchyTrialComponent.m_luaExportHelper.__callBase_AttackThearchyTrialLevel(levelId);
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

	// Token: 0x0601A0C0 RID: 106688 RVA: 0x007A5458 File Offset: 0x007A3658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = thearchyTrialComponent.m_luaExportHelper.__callBase_IsLevelFinished(levelId);
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

	// Token: 0x0601A0C1 RID: 106689 RVA: 0x007A54C0 File Offset: 0x007A36C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackThearchyTrialLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = thearchyTrialComponent.m_luaExportHelper.__callBase_CanAttackThearchyTrialLevel(levelId, isTeamBattle);
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

	// Token: 0x0601A0C2 RID: 106690 RVA: 0x007A5534 File Offset: 0x007A3734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackLevelByEnergyAndSoOn(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out levelInfo);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = thearchyTrialComponent.m_luaExportHelper.__callBase_CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
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

	// Token: 0x0601A0C3 RID: 106691 RVA: 0x007A55A8 File Offset: 0x007A37A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCommonSuccessThearchyTrialLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			int energyCost;
			LuaObject.checkType(l, 5, out energyCost);
			bool isBattleTeam;
			LuaObject.checkType(l, 6, out isBattleTeam);
			thearchyTrialComponent.m_luaExportHelper.__callBase_SetCommonSuccessThearchyTrialLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0C4 RID: 106692 RVA: 0x007A5638 File Offset: 0x007A3838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			HashSet<int> o = thearchyTrialComponent.m_luaExportHelper.__callBase_GetAllFinishedLevels();
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

	// Token: 0x0601A0C5 RID: 106693 RVA: 0x007A5694 File Offset: 0x007A3894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsDailyChallenge(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			bool b = thearchyTrialComponent.m_luaExportHelper.__callBase_IsDailyChallenge();
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

	// Token: 0x0601A0C6 RID: 106694 RVA: 0x007A56F0 File Offset: 0x007A38F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetDailyChallengNums(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			int i = thearchyTrialComponent.m_luaExportHelper.__callBase_GetDailyChallengNums();
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

	// Token: 0x0601A0C7 RID: 106695 RVA: 0x007A574C File Offset: 0x007A394C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			thearchyTrialComponent.m_luaExportHelper.__callBase_AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0C8 RID: 106696 RVA: 0x007A57A8 File Offset: 0x007A39A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllUnlockedLevels(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			List<int> o = thearchyTrialComponent.m_luaExportHelper.__callBase_GetAllUnlockedLevels();
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

	// Token: 0x0601A0C9 RID: 106697 RVA: 0x007A5804 File Offset: 0x007A3A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			ThearchyTrialComponent thearchyTrialComponent = (ThearchyTrialComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = thearchyTrialComponent.m_luaExportHelper.__callBase_IsLevelUnlocked(levelId);
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

	// Token: 0x0601A0CA RID: 106698 RVA: 0x007A586C File Offset: 0x007A3A6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ThearchyTrialComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.GetCurrentTicketNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.FinishedThearchyTrialLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.SetSuccessThearchyTrialLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.IsThearchyOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.IsThearchyLevelOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_AttackThearchyTrialLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_CanAttackThearchyTrialLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_CanAttackLevelByEnergyAndSoOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_SetCommonSuccessThearchyTrialLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_IsDailyChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_GetDailyChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_GetAllUnlockedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.__callBase_IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.<>f__mg$cache1B, typeof(ThearchyTrialComponent), typeof(ThearchyTrialCompomentCommon));
	}

	// Token: 0x040104C6 RID: 66758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040104C7 RID: 66759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040104C8 RID: 66760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040104C9 RID: 66761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040104CA RID: 66762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040104CB RID: 66763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040104CC RID: 66764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040104CD RID: 66765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040104CE RID: 66766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040104CF RID: 66767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040104D0 RID: 66768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040104D1 RID: 66769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040104D2 RID: 66770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040104D3 RID: 66771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040104D4 RID: 66772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040104D5 RID: 66773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040104D6 RID: 66774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040104D7 RID: 66775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040104D8 RID: 66776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040104D9 RID: 66777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040104DA RID: 66778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040104DB RID: 66779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040104DC RID: 66780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040104DD RID: 66781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040104DE RID: 66782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040104DF RID: 66783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040104E0 RID: 66784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040104E1 RID: 66785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
