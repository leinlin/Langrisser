using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200132F RID: 4911
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer : LuaObject
{
	// Token: 0x0601A5BE RID: 107966 RVA: 0x007CA880 File Offset: 0x007C8A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextPlayer o = new ClientNullActorActNextPlayer();
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

	// Token: 0x0601A5BF RID: 107967 RVA: 0x007CA8C8 File Offset: 0x007C8AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerIndex(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextPlayer clientNullActorActNextPlayer = (ClientNullActorActNextPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActNextPlayer.m_playerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5C0 RID: 107968 RVA: 0x007CA91C File Offset: 0x007C8B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerIndex(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextPlayer clientNullActorActNextPlayer = (ClientNullActorActNextPlayer)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			clientNullActorActNextPlayer.m_playerIndex = playerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5C1 RID: 107969 RVA: 0x007CA974 File Offset: 0x007C8B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_focusActor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextPlayer clientNullActorActNextPlayer = (ClientNullActorActNextPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActNextPlayer.m_focusActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5C2 RID: 107970 RVA: 0x007CA9C8 File Offset: 0x007C8BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_focusActor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextPlayer clientNullActorActNextPlayer = (ClientNullActorActNextPlayer)LuaObject.checkSelf(l);
			ClientBattleActor focusActor;
			LuaObject.checkType<ClientBattleActor>(l, 2, out focusActor);
			clientNullActorActNextPlayer.m_focusActor = focusActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5C3 RID: 107971 RVA: 0x007CAA20 File Offset: 0x007C8C20
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActNextPlayer");
		string name = "m_playerIndex";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.get_m_playerIndex);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.set_m_playerIndex);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache1, true);
		string name2 = "m_focusActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.get_m_focusActor);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.set_m_focusActor);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.<>f__mg$cache4, typeof(ClientNullActorActNextPlayer), typeof(ClientActorAct));
	}

	// Token: 0x04010942 RID: 67906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010943 RID: 67907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010944 RID: 67908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010945 RID: 67909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010946 RID: 67910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
