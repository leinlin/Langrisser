using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001346 RID: 4934
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost : LuaObject
{
	// Token: 0x0601A815 RID: 108565 RVA: 0x007DBE9C File Offset: 0x007DA09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost o = new GenericGraphic.Ghost();
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

	// Token: 0x0601A816 RID: 108566 RVA: 0x007DBEE4 File Offset: 0x007DA0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_speed(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ghost.m_speed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A817 RID: 108567 RVA: 0x007DBF38 File Offset: 0x007DA138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_speed(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			float speed;
			LuaObject.checkType(l, 2, out speed);
			ghost.m_speed = speed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A818 RID: 108568 RVA: 0x007DBF90 File Offset: 0x007DA190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_followTime(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ghost.m_followTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A819 RID: 108569 RVA: 0x007DBFE4 File Offset: 0x007DA1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_followTime(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			float followTime;
			LuaObject.checkType(l, 2, out followTime);
			ghost.m_followTime = followTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A81A RID: 108570 RVA: 0x007DC03C File Offset: 0x007DA23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_followStartPosition(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ghost.m_followStartPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A81B RID: 108571 RVA: 0x007DC090 File Offset: 0x007DA290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_followStartPosition(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			Vector2 followStartPosition;
			LuaObject.checkType(l, 2, out followStartPosition);
			ghost.m_followStartPosition = followStartPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A81C RID: 108572 RVA: 0x007DC0E8 File Offset: 0x007DA2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_state(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ghost.m_state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A81D RID: 108573 RVA: 0x007DC13C File Offset: 0x007DA33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_state(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			int state;
			LuaObject.checkType(l, 2, out state);
			ghost.m_state = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A81E RID: 108574 RVA: 0x007DC194 File Offset: 0x007DA394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnCount(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ghost.m_turnCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A81F RID: 108575 RVA: 0x007DC1E8 File Offset: 0x007DA3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turnCount(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			int turnCount;
			LuaObject.checkType(l, 2, out turnCount);
			ghost.m_turnCount = turnCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A820 RID: 108576 RVA: 0x007DC240 File Offset: 0x007DA440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ghost.m_targetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A821 RID: 108577 RVA: 0x007DC294 File Offset: 0x007DA494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			Vector2 targetPosition;
			LuaObject.checkType(l, 2, out targetPosition);
			ghost.m_targetPosition = targetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A822 RID: 108578 RVA: 0x007DC2EC File Offset: 0x007DA4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fx(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ghost.m_fx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A823 RID: 108579 RVA: 0x007DC340 File Offset: 0x007DA540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fx(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.Ghost ghost = (GenericGraphic.Ghost)LuaObject.checkSelf(l);
			GenericGraphic fx;
			LuaObject.checkType<GenericGraphic>(l, 2, out fx);
			ghost.m_fx = fx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A824 RID: 108580 RVA: 0x007DC398 File Offset: 0x007DA598
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.GenericGraphic.Ghost");
		string name = "m_speed";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.get_m_speed);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.set_m_speed);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache1, true);
		string name2 = "m_followTime";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.get_m_followTime);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.set_m_followTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache3, true);
		string name3 = "m_followStartPosition";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.get_m_followStartPosition);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.set_m_followStartPosition);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache5, true);
		string name4 = "m_state";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.get_m_state);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.set_m_state);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache7, true);
		string name5 = "m_turnCount";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.get_m_turnCount);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.set_m_turnCount);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cache9, true);
		string name6 = "m_targetPosition";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.get_m_targetPosition);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.set_m_targetPosition);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheB, true);
		string name7 = "m_fx";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.get_m_fx);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.set_m_fx);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.<>f__mg$cacheE, typeof(GenericGraphic.Ghost));
	}

	// Token: 0x04010B6B RID: 68459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010B6C RID: 68460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010B6D RID: 68461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010B6E RID: 68462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010B6F RID: 68463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010B70 RID: 68464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010B71 RID: 68465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010B72 RID: 68466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010B73 RID: 68467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010B74 RID: 68468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010B75 RID: 68469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010B76 RID: 68470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010B77 RID: 68471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010B78 RID: 68472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010B79 RID: 68473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
