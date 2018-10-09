using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011A9 RID: 4521
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_CombatSkillState : LuaObject
{
	// Token: 0x06017632 RID: 95794 RVA: 0x0065EE14 File Offset: 0x0065D014
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState o = new CombatSkillState();
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

	// Token: 0x06017633 RID: 95795 RVA: 0x0065EE5C File Offset: 0x0065D05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDelayHit(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			int frame;
			LuaObject.checkType(l, 2, out frame);
			Vector2i pos;
			LuaObject.checkValueType<Vector2i>(l, 3, out pos);
			CombatActor target;
			LuaObject.checkType<CombatActor>(l, 4, out target);
			combatSkillState.AddDelayHit(frame, pos, target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017634 RID: 95796 RVA: 0x0065EED0 File Offset: 0x0065D0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDelayHitFrameMax(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			int delayHitFrameMax = combatSkillState.GetDelayHitFrameMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, delayHitFrameMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017635 RID: 95797 RVA: 0x0065EF24 File Offset: 0x0065D124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCritical(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			bool targetIsHero;
			LuaObject.checkType(l, 2, out targetIsHero);
			bool b = combatSkillState.IsCritical(targetIsHero);
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

	// Token: 0x06017636 RID: 95798 RVA: 0x0065EF88 File Offset: 0x0065D188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSkillState.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017637 RID: 95799 RVA: 0x0065EFDC File Offset: 0x0065D1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			combatSkillState.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017638 RID: 95800 RVA: 0x0065F034 File Offset: 0x0065D234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hitId(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSkillState.m_hitId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017639 RID: 95801 RVA: 0x0065F088 File Offset: 0x0065D288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hitId(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			ushort hitId;
			LuaObject.checkType(l, 2, out hitId);
			combatSkillState.m_hitId = hitId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601763A RID: 95802 RVA: 0x0065F0E0 File Offset: 0x0065D2E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hitCount(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSkillState.m_hitCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601763B RID: 95803 RVA: 0x0065F134 File Offset: 0x0065D334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hitCount(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			int hitCount;
			LuaObject.checkType(l, 2, out hitCount);
			combatSkillState.m_hitCount = hitCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601763C RID: 95804 RVA: 0x0065F18C File Offset: 0x0065D38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_preAttackHitCount(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSkillState.m_preAttackHitCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601763D RID: 95805 RVA: 0x0065F1E0 File Offset: 0x0065D3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_preAttackHitCount(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			int preAttackHitCount;
			LuaObject.checkType(l, 2, out preAttackHitCount);
			combatSkillState.m_preAttackHitCount = preAttackHitCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601763E RID: 95806 RVA: 0x0065F238 File Offset: 0x0065D438
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_delayHits(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSkillState.m_delayHits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601763F RID: 95807 RVA: 0x0065F28C File Offset: 0x0065D48C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_delayHits(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			List<DelayHit> delayHits;
			LuaObject.checkType<List<DelayHit>>(l, 2, out delayHits);
			combatSkillState.m_delayHits = delayHits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017640 RID: 95808 RVA: 0x0065F2E4 File Offset: 0x0065D4E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isToHeroCritical(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSkillState.m_isToHeroCritical);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017641 RID: 95809 RVA: 0x0065F338 File Offset: 0x0065D538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isToHeroCritical(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			bool isToHeroCritical;
			LuaObject.checkType(l, 2, out isToHeroCritical);
			combatSkillState.m_isToHeroCritical = isToHeroCritical;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017642 RID: 95810 RVA: 0x0065F390 File Offset: 0x0065D590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isToSoldierCritical(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatSkillState.m_isToSoldierCritical);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017643 RID: 95811 RVA: 0x0065F3E4 File Offset: 0x0065D5E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isToSoldierCritical(IntPtr l)
	{
		int result;
		try
		{
			CombatSkillState combatSkillState = (CombatSkillState)LuaObject.checkSelf(l);
			bool isToSoldierCritical;
			LuaObject.checkType(l, 2, out isToSoldierCritical);
			combatSkillState.m_isToSoldierCritical = isToSoldierCritical;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017644 RID: 95812 RVA: 0x0065F43C File Offset: 0x0065D63C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.CombatSkillState");
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.AddDelayHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.GetDelayHitFrameMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.IsCritical);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache2);
		string name = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.get_m_skillInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.set_m_skillInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache4, true);
		string name2 = "m_hitId";
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.get_m_hitId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.set_m_hitId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache6, true);
		string name3 = "m_hitCount";
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.get_m_hitCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.set_m_hitCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache8, true);
		string name4 = "m_preAttackHitCount";
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.get_m_preAttackHitCount);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.set_m_preAttackHitCount);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheA, true);
		string name5 = "m_delayHits";
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.get_m_delayHits);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.set_m_delayHits);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheC, true);
		string name6 = "m_isToHeroCritical";
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.get_m_isToHeroCritical);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.set_m_isToHeroCritical);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheE, true);
		string name7 = "m_isToSoldierCritical";
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.get_m_isToSoldierCritical);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.set_m_isToSoldierCritical);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache10, true);
		if (Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatSkillState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_CombatSkillState.<>f__mg$cache11, typeof(CombatSkillState));
	}

	// Token: 0x0400DCC2 RID: 56514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DCC3 RID: 56515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DCC4 RID: 56516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DCC5 RID: 56517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DCC6 RID: 56518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DCC7 RID: 56519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DCC8 RID: 56520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DCC9 RID: 56521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DCCA RID: 56522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DCCB RID: 56523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DCCC RID: 56524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DCCD RID: 56525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DCCE RID: 56526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DCCF RID: 56527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DCD0 RID: 56528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DCD1 RID: 56529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DCD2 RID: 56530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DCD3 RID: 56531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
