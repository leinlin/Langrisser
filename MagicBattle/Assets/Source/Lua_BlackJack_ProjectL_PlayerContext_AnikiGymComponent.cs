using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012B0 RID: 4784
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent : LuaObject
{
	// Token: 0x0601914C RID: 102732 RVA: 0x00726650 File Offset: 0x00724850
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent o = new AnikiGymComponent();
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

	// Token: 0x0601914D RID: 102733 RVA: 0x00726698 File Offset: 0x00724898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			anikiGymComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601914E RID: 102734 RVA: 0x007266E4 File Offset: 0x007248E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			anikiGymComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601914F RID: 102735 RVA: 0x00726730 File Offset: 0x00724930
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			anikiGymComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019150 RID: 102736 RVA: 0x0072677C File Offset: 0x0072497C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			DSAnikiGymNtf msg;
			LuaObject.checkType<DSAnikiGymNtf>(l, 2, out msg);
			anikiGymComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019151 RID: 102737 RVA: 0x007267D4 File Offset: 0x007249D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			ushort dsversion = anikiGymComponent.GetDSVersion();
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

	// Token: 0x06019152 RID: 102738 RVA: 0x00726828 File Offset: 0x00724A28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCurrentTicketNums(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			int currentTicketNums = anikiGymComponent.GetCurrentTicketNums();
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

	// Token: 0x06019153 RID: 102739 RVA: 0x0072687C File Offset: 0x00724A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedAnikiGymLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isWin;
			LuaObject.checkType(l, 3, out isWin);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			int i = anikiGymComponent.FinishedAnikiGymLevel(levelId, isWin, battleTreasures);
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

	// Token: 0x06019154 RID: 102740 RVA: 0x007268F8 File Offset: 0x00724AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuccessAnikiGymLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			bool isTeamBattle;
			LuaObject.checkType(l, 5, out isTeamBattle);
			anikiGymComponent.SetSuccessAnikiGymLevel(levelInfo, battleTreasures, heroes, isTeamBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019155 RID: 102741 RVA: 0x00726978 File Offset: 0x00724B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAnikiGymOpened(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			int anikiGymId;
			LuaObject.checkType(l, 2, out anikiGymId);
			bool b = anikiGymComponent.IsAnikiGymOpened(anikiGymId);
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

	// Token: 0x06019156 RID: 102742 RVA: 0x007269DC File Offset: 0x00724BDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsAnikiLevelOpened(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			int anikiLevelId;
			LuaObject.checkType(l, 2, out anikiLevelId);
			bool b = anikiGymComponent.IsAnikiLevelOpened(anikiLevelId);
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

	// Token: 0x06019157 RID: 102743 RVA: 0x00726A40 File Offset: 0x00724C40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			string s = anikiGymComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019158 RID: 102744 RVA: 0x00726A9C File Offset: 0x00724C9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			anikiGymComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019159 RID: 102745 RVA: 0x00726AF0 File Offset: 0x00724CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			anikiGymComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601915A RID: 102746 RVA: 0x00726B44 File Offset: 0x00724D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			anikiGymComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601915B RID: 102747 RVA: 0x00726B98 File Offset: 0x00724D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			anikiGymComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601915C RID: 102748 RVA: 0x00726BF4 File Offset: 0x00724DF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			anikiGymComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601915D RID: 102749 RVA: 0x00726C48 File Offset: 0x00724E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AttackAnikiGymLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = anikiGymComponent.m_luaExportHelper.__callBase_AttackAnikiGymLevel(levelId);
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

	// Token: 0x0601915E RID: 102750 RVA: 0x00726CB0 File Offset: 0x00724EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackAnikiGymLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isTeamBattle;
			LuaObject.checkType(l, 3, out isTeamBattle);
			int i = anikiGymComponent.m_luaExportHelper.__callBase_CanAttackAnikiGymLevel(levelId, isTeamBattle);
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

	// Token: 0x0601915F RID: 102751 RVA: 0x00726D24 File Offset: 0x00724F24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = anikiGymComponent.m_luaExportHelper.__callBase_IsLevelFinished(levelId);
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

	// Token: 0x06019160 RID: 102752 RVA: 0x00726D8C File Offset: 0x00724F8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetCommonSuccessAnikiGymLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			int energyCost;
			LuaObject.checkType(l, 5, out energyCost);
			bool isBattleTeam;
			LuaObject.checkType(l, 6, out isBattleTeam);
			anikiGymComponent.m_luaExportHelper.__callBase_SetCommonSuccessAnikiGymLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019161 RID: 102753 RVA: 0x00726E1C File Offset: 0x0072501C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			HashSet<int> o = anikiGymComponent.m_luaExportHelper.__callBase_GetAllFinishedLevels();
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

	// Token: 0x06019162 RID: 102754 RVA: 0x00726E78 File Offset: 0x00725078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsDailyChallenge(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			bool b = anikiGymComponent.m_luaExportHelper.__callBase_IsDailyChallenge();
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

	// Token: 0x06019163 RID: 102755 RVA: 0x00726ED4 File Offset: 0x007250D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetDailyChallengNums(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			int i = anikiGymComponent.m_luaExportHelper.__callBase_GetDailyChallengNums();
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

	// Token: 0x06019164 RID: 102756 RVA: 0x00726F30 File Offset: 0x00725130
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			anikiGymComponent.m_luaExportHelper.__callBase_AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019165 RID: 102757 RVA: 0x00726F8C File Offset: 0x0072518C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllUnlockedLevels(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			List<int> o = anikiGymComponent.m_luaExportHelper.__callBase_GetAllUnlockedLevels();
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

	// Token: 0x06019166 RID: 102758 RVA: 0x00726FE8 File Offset: 0x007251E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymComponent anikiGymComponent = (AnikiGymComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = anikiGymComponent.m_luaExportHelper.__callBase_IsLevelUnlocked(levelId);
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

	// Token: 0x06019167 RID: 102759 RVA: 0x00727050 File Offset: 0x00725250
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.AnikiGymComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.GetCurrentTicketNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.FinishedAnikiGymLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.SetSuccessAnikiGymLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.IsAnikiGymOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.IsAnikiLevelOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_AttackAnikiGymLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_CanAttackAnikiGymLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_SetCommonSuccessAnikiGymLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_IsDailyChallenge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_GetDailyChallengNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_GetAllUnlockedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.__callBase_IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.<>f__mg$cache1A, typeof(AnikiGymComponent), typeof(AnikiGymComponentCommon));
	}

	// Token: 0x0400F5CE RID: 62926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F5CF RID: 62927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F5D0 RID: 62928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F5D1 RID: 62929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F5D2 RID: 62930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F5D3 RID: 62931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F5D4 RID: 62932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F5D5 RID: 62933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F5D6 RID: 62934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F5D7 RID: 62935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F5D8 RID: 62936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F5D9 RID: 62937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F5DA RID: 62938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F5DB RID: 62939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F5DC RID: 62940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F5DD RID: 62941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F5DE RID: 62942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F5DF RID: 62943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F5E0 RID: 62944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F5E1 RID: 62945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F5E2 RID: 62946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F5E3 RID: 62947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F5E4 RID: 62948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F5E5 RID: 62949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F5E6 RID: 62950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F5E7 RID: 62951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F5E8 RID: 62952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
