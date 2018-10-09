using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001303 RID: 4867
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove : LuaObject
{
	// Token: 0x0601A22B RID: 107051 RVA: 0x007AF670 File Offset: 0x007AD870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPerformMove o = new ClientActorActPerformMove();
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

	// Token: 0x0601A22C RID: 107052 RVA: 0x007AF6B8 File Offset: 0x007AD8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPerformMove clientActorActPerformMove = (ClientActorActPerformMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPerformMove.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A22D RID: 107053 RVA: 0x007AF710 File Offset: 0x007AD910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPerformMove clientActorActPerformMove = (ClientActorActPerformMove)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientActorActPerformMove.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A22E RID: 107054 RVA: 0x007AF768 File Offset: 0x007AD968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPerformMove clientActorActPerformMove = (ClientActorActPerformMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPerformMove.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A22F RID: 107055 RVA: 0x007AF7BC File Offset: 0x007AD9BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPerformMove clientActorActPerformMove = (ClientActorActPerformMove)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActPerformMove.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A230 RID: 107056 RVA: 0x007AF814 File Offset: 0x007ADA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sound(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPerformMove clientActorActPerformMove = (ClientActorActPerformMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPerformMove.m_sound);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A231 RID: 107057 RVA: 0x007AF868 File Offset: 0x007ADA68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sound(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPerformMove clientActorActPerformMove = (ClientActorActPerformMove)LuaObject.checkSelf(l);
			bool sound;
			LuaObject.checkType(l, 2, out sound);
			clientActorActPerformMove.m_sound = sound;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A232 RID: 107058 RVA: 0x007AF8C0 File Offset: 0x007ADAC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cameraFollow(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPerformMove clientActorActPerformMove = (ClientActorActPerformMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPerformMove.m_cameraFollow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A233 RID: 107059 RVA: 0x007AF914 File Offset: 0x007ADB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cameraFollow(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPerformMove clientActorActPerformMove = (ClientActorActPerformMove)LuaObject.checkSelf(l);
			bool cameraFollow;
			LuaObject.checkType(l, 2, out cameraFollow);
			clientActorActPerformMove.m_cameraFollow = cameraFollow;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A234 RID: 107060 RVA: 0x007AF96C File Offset: 0x007ADB6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActPerformMove");
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache1, true);
		string name2 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.get_m_direction);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.set_m_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache3, true);
		string name3 = "m_sound";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.get_m_sound);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.set_m_sound);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache5, true);
		string name4 = "m_cameraFollow";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.get_m_cameraFollow);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.set_m_cameraFollow);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.<>f__mg$cache8, typeof(ClientActorActPerformMove), typeof(ClientActorAct));
	}

	// Token: 0x04010607 RID: 67079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010608 RID: 67080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010609 RID: 67081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401060A RID: 67082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401060B RID: 67083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401060C RID: 67084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401060D RID: 67085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401060E RID: 67086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401060F RID: 67087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
