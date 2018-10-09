using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001194 RID: 4500
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState : LuaObject
{
	// Token: 0x060173B2 RID: 95154 RVA: 0x0064C478 File Offset: 0x0064A678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState o = new BattleEventTriggerState();
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

	// Token: 0x060173B3 RID: 95155 RVA: 0x0064C4C0 File Offset: 0x0064A6C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_conditionId(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState battleEventTriggerState = (BattleEventTriggerState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleEventTriggerState.m_conditionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173B4 RID: 95156 RVA: 0x0064C514 File Offset: 0x0064A714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_conditionId(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState battleEventTriggerState = (BattleEventTriggerState)LuaObject.checkSelf(l);
			int conditionId;
			LuaObject.checkType(l, 2, out conditionId);
			battleEventTriggerState.m_conditionId = conditionId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173B5 RID: 95157 RVA: 0x0064C56C File Offset: 0x0064A76C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_status(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState battleEventTriggerState = (BattleEventTriggerState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleEventTriggerState.m_status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173B6 RID: 95158 RVA: 0x0064C5C0 File Offset: 0x0064A7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_status(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState battleEventTriggerState = (BattleEventTriggerState)LuaObject.checkSelf(l);
			BattleConditionStatus status;
			LuaObject.checkEnum<BattleConditionStatus>(l, 2, out status);
			battleEventTriggerState.m_status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173B7 RID: 95159 RVA: 0x0064C618 File Offset: 0x0064A818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_triggerCount(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState battleEventTriggerState = (BattleEventTriggerState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleEventTriggerState.m_triggerCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173B8 RID: 95160 RVA: 0x0064C66C File Offset: 0x0064A86C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_triggerCount(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState battleEventTriggerState = (BattleEventTriggerState)LuaObject.checkSelf(l);
			int triggerCount;
			LuaObject.checkType(l, 2, out triggerCount);
			battleEventTriggerState.m_triggerCount = triggerCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173B9 RID: 95161 RVA: 0x0064C6C4 File Offset: 0x0064A8C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_triggerTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState battleEventTriggerState = (BattleEventTriggerState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleEventTriggerState.m_triggerTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173BA RID: 95162 RVA: 0x0064C718 File Offset: 0x0064A918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_triggerTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState battleEventTriggerState = (BattleEventTriggerState)LuaObject.checkSelf(l);
			int triggerTurn;
			LuaObject.checkType(l, 2, out triggerTurn);
			battleEventTriggerState.m_triggerTurn = triggerTurn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173BB RID: 95163 RVA: 0x0064C770 File Offset: 0x0064A970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_triggerInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState battleEventTriggerState = (BattleEventTriggerState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleEventTriggerState.m_triggerInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173BC RID: 95164 RVA: 0x0064C7C4 File Offset: 0x0064A9C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_triggerInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleEventTriggerState battleEventTriggerState = (BattleEventTriggerState)LuaObject.checkSelf(l);
			ConfigDataBattleEventTriggerInfo triggerInfo;
			LuaObject.checkType<ConfigDataBattleEventTriggerInfo>(l, 2, out triggerInfo);
			battleEventTriggerState.m_triggerInfo = triggerInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173BD RID: 95165 RVA: 0x0064C81C File Offset: 0x0064AA1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleEventTriggerState");
		string name = "m_conditionId";
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.get_m_conditionId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.set_m_conditionId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache1, true);
		string name2 = "m_status";
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.get_m_status);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.set_m_status);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache3, true);
		string name3 = "m_triggerCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.get_m_triggerCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.set_m_triggerCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache5, true);
		string name4 = "m_triggerTurn";
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.get_m_triggerTurn);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.set_m_triggerTurn);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache7, true);
		string name5 = "m_triggerInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.get_m_triggerInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.set_m_triggerInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.<>f__mg$cacheA, typeof(BattleEventTriggerState));
	}

	// Token: 0x0400DA6C RID: 55916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DA6D RID: 55917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DA6E RID: 55918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DA6F RID: 55919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DA70 RID: 55920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DA71 RID: 55921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DA72 RID: 55922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DA73 RID: 55923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DA74 RID: 55924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DA75 RID: 55925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DA76 RID: 55926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
