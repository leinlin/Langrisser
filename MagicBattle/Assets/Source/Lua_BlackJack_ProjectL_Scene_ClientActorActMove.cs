using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001300 RID: 4864
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActMove : LuaObject
{
	// Token: 0x0601A216 RID: 107030 RVA: 0x007AEEDC File Offset: 0x007AD0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActMove o = new ClientActorActMove();
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

	// Token: 0x0601A217 RID: 107031 RVA: 0x007AEF24 File Offset: 0x007AD124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActMove clientActorActMove = (ClientActorActMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActMove.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A218 RID: 107032 RVA: 0x007AEF7C File Offset: 0x007AD17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActMove clientActorActMove = (ClientActorActMove)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientActorActMove.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A219 RID: 107033 RVA: 0x007AEFD4 File Offset: 0x007AD1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActMove clientActorActMove = (ClientActorActMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActMove.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A21A RID: 107034 RVA: 0x007AF028 File Offset: 0x007AD228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActMove clientActorActMove = (ClientActorActMove)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActMove.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A21B RID: 107035 RVA: 0x007AF080 File Offset: 0x007AD280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sound(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActMove clientActorActMove = (ClientActorActMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActMove.m_sound);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A21C RID: 107036 RVA: 0x007AF0D4 File Offset: 0x007AD2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sound(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActMove clientActorActMove = (ClientActorActMove)LuaObject.checkSelf(l);
			bool sound;
			LuaObject.checkType(l, 2, out sound);
			clientActorActMove.m_sound = sound;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A21D RID: 107037 RVA: 0x007AF12C File Offset: 0x007AD32C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActMove");
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActMove.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActMove.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache1, true);
		string name2 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActMove.get_m_direction);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActMove.set_m_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache3, true);
		string name3 = "m_sound";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActMove.get_m_sound);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActMove.set_m_sound);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActMove.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActMove.<>f__mg$cache6, typeof(ClientActorActMove), typeof(ClientActorAct));
	}

	// Token: 0x040105F8 RID: 67064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105F9 RID: 67065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105FA RID: 67066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040105FB RID: 67067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040105FC RID: 67068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040105FD RID: 67069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040105FE RID: 67070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
