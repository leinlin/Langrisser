using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012EE RID: 4846
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorAct : LuaObject
{
	// Token: 0x0601A1A0 RID: 106912 RVA: 0x007AC554 File Offset: 0x007AA754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorAct o = new ClientActorAct();
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

	// Token: 0x0601A1A1 RID: 106913 RVA: 0x007AC59C File Offset: 0x007AA79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorAct clientActorAct = (ClientActorAct)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorAct.m_actor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1A2 RID: 106914 RVA: 0x007AC5F0 File Offset: 0x007AA7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorAct clientActorAct = (ClientActorAct)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			clientActorAct.m_actor = actor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1A3 RID: 106915 RVA: 0x007AC648 File Offset: 0x007AA848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_step(IntPtr l)
	{
		int result;
		try
		{
			ClientActorAct clientActorAct = (ClientActorAct)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorAct.m_step);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1A4 RID: 106916 RVA: 0x007AC69C File Offset: 0x007AA89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_step(IntPtr l)
	{
		int result;
		try
		{
			ClientActorAct clientActorAct = (ClientActorAct)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			clientActorAct.m_step = step;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1A5 RID: 106917 RVA: 0x007AC6F4 File Offset: 0x007AA8F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorAct");
		string name = "m_actor";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorAct.get_m_actor);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorAct.set_m_actor);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache1, true);
		string name2 = "m_step";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorAct.get_m_step);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorAct.set_m_step);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorAct.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorAct.<>f__mg$cache4, typeof(ClientActorAct));
	}

	// Token: 0x040105A6 RID: 66982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105A7 RID: 66983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105A8 RID: 66984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040105A9 RID: 66985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040105AA RID: 66986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
