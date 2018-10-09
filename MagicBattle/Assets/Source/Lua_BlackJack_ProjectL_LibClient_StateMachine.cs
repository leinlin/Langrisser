using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.LibClient;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200129C RID: 4764
[Preserve]
public class Lua_BlackJack_ProjectL_LibClient_StateMachine : LuaObject
{
	// Token: 0x06019001 RID: 102401 RVA: 0x0071CAC4 File Offset: 0x0071ACC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			StateMachine o = new StateMachine();
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

	// Token: 0x06019002 RID: 102402 RVA: 0x0071CB0C File Offset: 0x0071AD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStateCheck(IntPtr l)
	{
		int result;
		try
		{
			StateMachine stateMachine = (StateMachine)LuaObject.checkSelf(l);
			int commingEvent;
			LuaObject.checkType(l, 2, out commingEvent);
			int newState;
			LuaObject.checkType(l, 3, out newState);
			bool testOnly;
			LuaObject.checkType(l, 4, out testOnly);
			int i = stateMachine.SetStateCheck(commingEvent, newState, testOnly);
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

	// Token: 0x06019003 RID: 102403 RVA: 0x0071CB88 File Offset: 0x0071AD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStateWithoutCheck(IntPtr l)
	{
		int result;
		try
		{
			StateMachine stateMachine = (StateMachine)LuaObject.checkSelf(l);
			int stateWithoutCheck;
			LuaObject.checkType(l, 2, out stateWithoutCheck);
			stateMachine.SetStateWithoutCheck(stateWithoutCheck);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019004 RID: 102404 RVA: 0x0071CBE0 File Offset: 0x0071ADE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EventCheck(IntPtr l)
	{
		int result;
		try
		{
			StateMachine stateMachine = (StateMachine)LuaObject.checkSelf(l);
			int commingEvent;
			LuaObject.checkType(l, 2, out commingEvent);
			bool b = stateMachine.EventCheck(commingEvent);
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

	// Token: 0x06019005 RID: 102405 RVA: 0x0071CC44 File Offset: 0x0071AE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_State(IntPtr l)
	{
		int result;
		try
		{
			StateMachine stateMachine = (StateMachine)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stateMachine.State);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019006 RID: 102406 RVA: 0x0071CC98 File Offset: 0x0071AE98
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.LibClient.StateMachine");
		if (Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_StateMachine.SetStateCheck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_StateMachine.SetStateWithoutCheck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_StateMachine.EventCheck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache2);
		string name = "State";
		if (Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_StateMachine.get_State);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache3, null, true);
		if (Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_StateMachine.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_LibClient_StateMachine.<>f__mg$cache4, typeof(StateMachine));
	}

	// Token: 0x0400F4AB RID: 62635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F4AC RID: 62636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F4AD RID: 62637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F4AE RID: 62638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F4AF RID: 62639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
