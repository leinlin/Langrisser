using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011A3 RID: 4515
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BehaviorTarget : LuaObject
{
	// Token: 0x060174D7 RID: 95447 RVA: 0x0065487C File Offset: 0x00652A7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(BattleActor)))
			{
				BattleActor actor;
				LuaObject.checkType<BattleActor>(l, 2, out actor);
				BehaviorTarget o = new BehaviorTarget(actor);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(GridPosition)))
			{
				GridPosition pos;
				LuaObject.checkValueType<GridPosition>(l, 2, out pos);
				BehaviorTarget o = new BehaviorTarget(pos);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174D8 RID: 95448 RVA: 0x00654940 File Offset: 0x00652B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEmpty(IntPtr l)
	{
		int result;
		try
		{
			BehaviorTarget behaviorTarget = (BehaviorTarget)LuaObject.checkSelf(l);
			bool b = behaviorTarget.IsEmpty();
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

	// Token: 0x060174D9 RID: 95449 RVA: 0x00654994 File Offset: 0x00652B94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_pos(IntPtr l)
	{
		int result;
		try
		{
			BehaviorTarget behaviorTarget = (BehaviorTarget)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorTarget.m_luaExportHelper.m_pos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174DA RID: 95450 RVA: 0x006549F0 File Offset: 0x00652BF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_pos(IntPtr l)
	{
		int result;
		try
		{
			BehaviorTarget behaviorTarget = (BehaviorTarget)LuaObject.checkSelf(l);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 2, out pos);
			behaviorTarget.m_luaExportHelper.m_pos = pos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174DB RID: 95451 RVA: 0x00654A4C File Offset: 0x00652C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor(IntPtr l)
	{
		int result;
		try
		{
			BehaviorTarget behaviorTarget = (BehaviorTarget)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorTarget.m_luaExportHelper.m_actor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174DC RID: 95452 RVA: 0x00654AA4 File Offset: 0x00652CA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_actor(IntPtr l)
	{
		int result;
		try
		{
			BehaviorTarget behaviorTarget = (BehaviorTarget)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			behaviorTarget.m_luaExportHelper.m_actor = actor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174DD RID: 95453 RVA: 0x00654B00 File Offset: 0x00652D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			BehaviorTarget behaviorTarget = (BehaviorTarget)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorTarget.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174DE RID: 95454 RVA: 0x00654B58 File Offset: 0x00652D58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Actor(IntPtr l)
	{
		int result;
		try
		{
			BehaviorTarget behaviorTarget = (BehaviorTarget)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorTarget.Actor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060174DF RID: 95455 RVA: 0x00654BAC File Offset: 0x00652DAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BehaviorTarget");
		if (Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorTarget.IsEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache0);
		string name = "m_pos";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorTarget.get_m_pos);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorTarget.set_m_pos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache2, true);
		string name2 = "m_actor";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorTarget.get_m_actor);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorTarget.set_m_actor);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache4, true);
		string name3 = "Position";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorTarget.get_Position);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache5, null, true);
		string name4 = "Actor";
		if (Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorTarget.get_Actor);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache6, null, true);
		if (Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BehaviorTarget.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BehaviorTarget.<>f__mg$cache7, typeof(BehaviorTarget));
	}

	// Token: 0x0400DB73 RID: 56179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DB74 RID: 56180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DB75 RID: 56181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DB76 RID: 56182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DB77 RID: 56183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DB78 RID: 56184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DB79 RID: 56185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DB7A RID: 56186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
