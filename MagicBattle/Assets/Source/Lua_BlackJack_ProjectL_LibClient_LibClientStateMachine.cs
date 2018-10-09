using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.LibClient;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200129A RID: 4762
[Preserve]
public class Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine : LuaObject
{
	// Token: 0x06018FDC RID: 102364 RVA: 0x0071BB90 File Offset: 0x00719D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LibClientStateMachine o = new LibClientStateMachine();
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

	// Token: 0x06018FDD RID: 102365 RVA: 0x0071BBD8 File Offset: 0x00719DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStateCheck(IntPtr l)
	{
		int result;
		try
		{
			LibClientStateMachine libClientStateMachine = (LibClientStateMachine)LuaObject.checkSelf(l);
			int commingEvent;
			LuaObject.checkType(l, 2, out commingEvent);
			int newState;
			LuaObject.checkType(l, 3, out newState);
			bool testOnly;
			LuaObject.checkType(l, 4, out testOnly);
			int i = libClientStateMachine.SetStateCheck(commingEvent, newState, testOnly);
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

	// Token: 0x06018FDE RID: 102366 RVA: 0x0071BC54 File Offset: 0x00719E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_STATE_IDLE(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FDF RID: 102367 RVA: 0x0071BC98 File Offset: 0x00719E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_STATE_AUTHLOGIN_CONNECTING(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FE0 RID: 102368 RVA: 0x0071BCDC File Offset: 0x00719EDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_STATE_AUTHLOGIN_CONNECTED(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FE1 RID: 102369 RVA: 0x0071BD20 File Offset: 0x00719F20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_STATE_AUTHLOGIN_OK_NEED_REDIRECT(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FE2 RID: 102370 RVA: 0x0071BD64 File Offset: 0x00719F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_STATE_SESSIONLOGIN_CONNECTING(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FE3 RID: 102371 RVA: 0x0071BDA8 File Offset: 0x00719FA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_STATE_SESSIONLOGIN_CONNECTED(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FE4 RID: 102372 RVA: 0x0071BDEC File Offset: 0x00719FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_STATE_LOGIN_OK(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 6);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FE5 RID: 102373 RVA: 0x0071BE30 File Offset: 0x0071A030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_STATE_DISCONNECTING(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 99);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FE6 RID: 102374 RVA: 0x0071BE74 File Offset: 0x0071A074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_STATE_DISCONNECTED(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 100);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FE7 RID: 102375 RVA: 0x0071BEB8 File Offset: 0x0071A0B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EVENT_AUTHLOGIN_CONNECT(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FE8 RID: 102376 RVA: 0x0071BEFC File Offset: 0x0071A0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EVENT_ONCONNECTED(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FE9 RID: 102377 RVA: 0x0071BF40 File Offset: 0x0071A140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EVENT_DISCONNECT(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FEA RID: 102378 RVA: 0x0071BF84 File Offset: 0x0071A184
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EVENT_ONDISCONNECTED(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FEB RID: 102379 RVA: 0x0071BFC8 File Offset: 0x0071A1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EVENT_AUTHLOGIN_OK(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FEC RID: 102380 RVA: 0x0071C00C File Offset: 0x0071A20C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EVENT_AUTHLOGIN_OK_REDRIECT(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 6);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FED RID: 102381 RVA: 0x0071C050 File Offset: 0x0071A250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EVENT_AUTHLOGIN_FAIL(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 7);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FEE RID: 102382 RVA: 0x0071C094 File Offset: 0x0071A294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EVENT_SESSIONLOGIN_CONNECT(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 8);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FEF RID: 102383 RVA: 0x0071C0D8 File Offset: 0x0071A2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EVENT_SESSIONLOGIN_OK(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 9);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FF0 RID: 102384 RVA: 0x0071C11C File Offset: 0x0071A31C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EVENT_SESSIONLOGIN_FAIL(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 10);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FF1 RID: 102385 RVA: 0x0071C160 File Offset: 0x0071A360
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.LibClient.LibClientStateMachine");
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.SetStateCheck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache0);
		string name = "STATE_IDLE";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_STATE_IDLE);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache1, null, false);
		string name2 = "STATE_AUTHLOGIN_CONNECTING";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_STATE_AUTHLOGIN_CONNECTING);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache2, null, false);
		string name3 = "STATE_AUTHLOGIN_CONNECTED";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_STATE_AUTHLOGIN_CONNECTED);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache3, null, false);
		string name4 = "STATE_AUTHLOGIN_OK_NEED_REDIRECT";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_STATE_AUTHLOGIN_OK_NEED_REDIRECT);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache4, null, false);
		string name5 = "STATE_SESSIONLOGIN_CONNECTING";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_STATE_SESSIONLOGIN_CONNECTING);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache5, null, false);
		string name6 = "STATE_SESSIONLOGIN_CONNECTED";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_STATE_SESSIONLOGIN_CONNECTED);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache6, null, false);
		string name7 = "STATE_LOGIN_OK";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_STATE_LOGIN_OK);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache7, null, false);
		string name8 = "STATE_DISCONNECTING";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_STATE_DISCONNECTING);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache8, null, false);
		string name9 = "STATE_DISCONNECTED";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_STATE_DISCONNECTED);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache9, null, false);
		string name10 = "EVENT_AUTHLOGIN_CONNECT";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_EVENT_AUTHLOGIN_CONNECT);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheA, null, false);
		string name11 = "EVENT_ONCONNECTED";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_EVENT_ONCONNECTED);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheB, null, false);
		string name12 = "EVENT_DISCONNECT";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_EVENT_DISCONNECT);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheC, null, false);
		string name13 = "EVENT_ONDISCONNECTED";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_EVENT_ONDISCONNECTED);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheD, null, false);
		string name14 = "EVENT_AUTHLOGIN_OK";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_EVENT_AUTHLOGIN_OK);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheE, null, false);
		string name15 = "EVENT_AUTHLOGIN_OK_REDRIECT";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_EVENT_AUTHLOGIN_OK_REDRIECT);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cacheF, null, false);
		string name16 = "EVENT_AUTHLOGIN_FAIL";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_EVENT_AUTHLOGIN_FAIL);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache10, null, false);
		string name17 = "EVENT_SESSIONLOGIN_CONNECT";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_EVENT_SESSIONLOGIN_CONNECT);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache11, null, false);
		string name18 = "EVENT_SESSIONLOGIN_OK";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_EVENT_SESSIONLOGIN_OK);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache12, null, false);
		string name19 = "EVENT_SESSIONLOGIN_FAIL";
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.get_EVENT_SESSIONLOGIN_FAIL);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache13, null, false);
		if (Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.<>f__mg$cache14, typeof(LibClientStateMachine), typeof(StateMachine));
	}

	// Token: 0x0400F48A RID: 62602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F48B RID: 62603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F48C RID: 62604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F48D RID: 62605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F48E RID: 62606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F48F RID: 62607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F490 RID: 62608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F491 RID: 62609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F492 RID: 62610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F493 RID: 62611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F494 RID: 62612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F495 RID: 62613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F496 RID: 62614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F497 RID: 62615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F498 RID: 62616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F499 RID: 62617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F49A RID: 62618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F49B RID: 62619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F49C RID: 62620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F49D RID: 62621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F49E RID: 62622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
