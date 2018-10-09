using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200118E RID: 4494
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleAchievementState : LuaObject
{
	// Token: 0x0601701D RID: 94237 RVA: 0x0062F4BC File Offset: 0x0062D6BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementState o = new BattleAchievementState();
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

	// Token: 0x0601701E RID: 94238 RVA: 0x0062F504 File Offset: 0x0062D704
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_conditionId(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementState battleAchievementState = (BattleAchievementState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleAchievementState.m_conditionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601701F RID: 94239 RVA: 0x0062F558 File Offset: 0x0062D758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_conditionId(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementState battleAchievementState = (BattleAchievementState)LuaObject.checkSelf(l);
			int conditionId;
			LuaObject.checkType(l, 2, out conditionId);
			battleAchievementState.m_conditionId = conditionId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017020 RID: 94240 RVA: 0x0062F5B0 File Offset: 0x0062D7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_status(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementState battleAchievementState = (BattleAchievementState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleAchievementState.m_status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017021 RID: 94241 RVA: 0x0062F604 File Offset: 0x0062D804
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_status(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementState battleAchievementState = (BattleAchievementState)LuaObject.checkSelf(l);
			BattleConditionStatus status;
			LuaObject.checkEnum<BattleConditionStatus>(l, 2, out status);
			battleAchievementState.m_status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017022 RID: 94242 RVA: 0x0062F65C File Offset: 0x0062D85C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_achievementRelatedInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementState battleAchievementState = (BattleAchievementState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleAchievementState.m_achievementRelatedInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017023 RID: 94243 RVA: 0x0062F6B0 File Offset: 0x0062D8B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementRelatedInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementState battleAchievementState = (BattleAchievementState)LuaObject.checkSelf(l);
			ConfigDataBattleAchievementRelatedInfo achievementRelatedInfo;
			LuaObject.checkType<ConfigDataBattleAchievementRelatedInfo>(l, 2, out achievementRelatedInfo);
			battleAchievementState.m_achievementRelatedInfo = achievementRelatedInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017024 RID: 94244 RVA: 0x0062F708 File Offset: 0x0062D908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnCount(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementState battleAchievementState = (BattleAchievementState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleAchievementState.m_turnCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017025 RID: 94245 RVA: 0x0062F75C File Offset: 0x0062D95C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_turnCount(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementState battleAchievementState = (BattleAchievementState)LuaObject.checkSelf(l);
			int turnCount;
			LuaObject.checkType(l, 2, out turnCount);
			battleAchievementState.m_turnCount = turnCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017026 RID: 94246 RVA: 0x0062F7B4 File Offset: 0x0062D9B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleAchievementState");
		string name = "m_conditionId";
		if (Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleAchievementState.get_m_conditionId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleAchievementState.set_m_conditionId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache1, true);
		string name2 = "m_status";
		if (Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleAchievementState.get_m_status);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleAchievementState.set_m_status);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache3, true);
		string name3 = "m_achievementRelatedInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleAchievementState.get_m_achievementRelatedInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleAchievementState.set_m_achievementRelatedInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache5, true);
		string name4 = "m_turnCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleAchievementState.get_m_turnCount);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleAchievementState.set_m_turnCount);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleAchievementState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleAchievementState.<>f__mg$cache8, typeof(BattleAchievementState));
	}

	// Token: 0x0400D6E3 RID: 55011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D6E4 RID: 55012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D6E5 RID: 55013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D6E6 RID: 55014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D6E7 RID: 55015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D6E8 RID: 55016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D6E9 RID: 55017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D6EA RID: 55018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D6EB RID: 55019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
