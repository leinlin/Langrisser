using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200132C RID: 4908
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain : LuaObject
{
	// Token: 0x0601A5A9 RID: 107945 RVA: 0x007CA0EC File Offset: 0x007C82EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActChangeMapTerrain o = new ClientNullActorActChangeMapTerrain();
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

	// Token: 0x0601A5AA RID: 107946 RVA: 0x007CA134 File Offset: 0x007C8334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActChangeMapTerrain clientNullActorActChangeMapTerrain = (ClientNullActorActChangeMapTerrain)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActChangeMapTerrain.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5AB RID: 107947 RVA: 0x007CA18C File Offset: 0x007C838C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActChangeMapTerrain clientNullActorActChangeMapTerrain = (ClientNullActorActChangeMapTerrain)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientNullActorActChangeMapTerrain.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5AC RID: 107948 RVA: 0x007CA1E4 File Offset: 0x007C83E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActChangeMapTerrain clientNullActorActChangeMapTerrain = (ClientNullActorActChangeMapTerrain)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActChangeMapTerrain.m_terrainInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5AD RID: 107949 RVA: 0x007CA238 File Offset: 0x007C8438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActChangeMapTerrain clientNullActorActChangeMapTerrain = (ClientNullActorActChangeMapTerrain)LuaObject.checkSelf(l);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 2, out terrainInfo);
			clientNullActorActChangeMapTerrain.m_terrainInfo = terrainInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5AE RID: 107950 RVA: 0x007CA290 File Offset: 0x007C8490
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActChangeMapTerrain");
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache1, true);
		string name2 = "m_terrainInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.get_m_terrainInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.set_m_terrainInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.<>f__mg$cache4, typeof(ClientNullActorActChangeMapTerrain), typeof(ClientActorAct));
	}

	// Token: 0x04010933 RID: 67891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010934 RID: 67892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010935 RID: 67893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010936 RID: 67894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010937 RID: 67895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
