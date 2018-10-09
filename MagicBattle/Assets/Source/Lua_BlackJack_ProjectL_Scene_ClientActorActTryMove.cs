using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001314 RID: 4884
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove : LuaObject
{
	// Token: 0x0601A2C0 RID: 107200 RVA: 0x007B2F90 File Offset: 0x007B1190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTryMove o = new ClientActorActTryMove();
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

	// Token: 0x0601A2C1 RID: 107201 RVA: 0x007B2FD8 File Offset: 0x007B11D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTryMove clientActorActTryMove = (ClientActorActTryMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTryMove.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2C2 RID: 107202 RVA: 0x007B3030 File Offset: 0x007B1230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTryMove clientActorActTryMove = (ClientActorActTryMove)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientActorActTryMove.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2C3 RID: 107203 RVA: 0x007B3088 File Offset: 0x007B1288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTryMove clientActorActTryMove = (ClientActorActTryMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTryMove.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2C4 RID: 107204 RVA: 0x007B30DC File Offset: 0x007B12DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTryMove clientActorActTryMove = (ClientActorActTryMove)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActTryMove.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2C5 RID: 107205 RVA: 0x007B3134 File Offset: 0x007B1334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sound(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTryMove clientActorActTryMove = (ClientActorActTryMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTryMove.m_sound);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2C6 RID: 107206 RVA: 0x007B3188 File Offset: 0x007B1388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sound(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTryMove clientActorActTryMove = (ClientActorActTryMove)LuaObject.checkSelf(l);
			bool sound;
			LuaObject.checkType(l, 2, out sound);
			clientActorActTryMove.m_sound = sound;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2C7 RID: 107207 RVA: 0x007B31E0 File Offset: 0x007B13E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActTryMove");
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache1, true);
		string name2 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.get_m_direction);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.set_m_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache3, true);
		string name3 = "m_sound";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.get_m_sound);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.set_m_sound);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.<>f__mg$cache6, typeof(ClientActorActTryMove), typeof(ClientActorAct));
	}

	// Token: 0x0401067A RID: 67194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401067B RID: 67195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401067C RID: 67196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401067D RID: 67197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401067E RID: 67198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401067F RID: 67199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010680 RID: 67200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
