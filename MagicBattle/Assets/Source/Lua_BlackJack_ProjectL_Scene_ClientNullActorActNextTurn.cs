using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001331 RID: 4913
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn : LuaObject
{
	// Token: 0x0601A5CC RID: 107980 RVA: 0x007CAD88 File Offset: 0x007C8F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextTurn o = new ClientNullActorActNextTurn();
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

	// Token: 0x0601A5CD RID: 107981 RVA: 0x007CADD0 File Offset: 0x007C8FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turn(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextTurn clientNullActorActNextTurn = (ClientNullActorActNextTurn)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActNextTurn.m_turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5CE RID: 107982 RVA: 0x007CAE24 File Offset: 0x007C9024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turn(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextTurn clientNullActorActNextTurn = (ClientNullActorActNextTurn)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			clientNullActorActNextTurn.m_turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5CF RID: 107983 RVA: 0x007CAE7C File Offset: 0x007C907C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActNextTurn");
		string name = "m_turn";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.get_m_turn);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.set_m_turn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.<>f__mg$cache2, typeof(ClientNullActorActNextTurn), typeof(ClientActorAct));
	}

	// Token: 0x0401094C RID: 67916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401094D RID: 67917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401094E RID: 67918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
