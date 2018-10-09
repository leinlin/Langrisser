using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200132A RID: 4906
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus : LuaObject
{
	// Token: 0x0601A5A1 RID: 107937 RVA: 0x007C9EB4 File Offset: 0x007C80B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActCameraFocus o = new ClientNullActorActCameraFocus();
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

	// Token: 0x0601A5A2 RID: 107938 RVA: 0x007C9EFC File Offset: 0x007C80FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActCameraFocus clientNullActorActCameraFocus = (ClientNullActorActCameraFocus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActCameraFocus.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5A3 RID: 107939 RVA: 0x007C9F54 File Offset: 0x007C8154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActCameraFocus clientNullActorActCameraFocus = (ClientNullActorActCameraFocus)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientNullActorActCameraFocus.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5A4 RID: 107940 RVA: 0x007C9FAC File Offset: 0x007C81AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActCameraFocus");
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.<>f__mg$cache2, typeof(ClientNullActorActCameraFocus), typeof(ClientActorAct));
	}

	// Token: 0x0401092F RID: 67887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010930 RID: 67888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010931 RID: 67889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
