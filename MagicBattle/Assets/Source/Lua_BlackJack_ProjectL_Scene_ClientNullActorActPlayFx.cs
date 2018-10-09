using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001332 RID: 4914
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx : LuaObject
{
	// Token: 0x0601A5D1 RID: 107985 RVA: 0x007CAF1C File Offset: 0x007C911C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlayFx o = new ClientNullActorActPlayFx();
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

	// Token: 0x0601A5D2 RID: 107986 RVA: 0x007CAF64 File Offset: 0x007C9164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlayFx clientNullActorActPlayFx = (ClientNullActorActPlayFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActPlayFx.m_fxName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5D3 RID: 107987 RVA: 0x007CAFB8 File Offset: 0x007C91B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlayFx clientNullActorActPlayFx = (ClientNullActorActPlayFx)LuaObject.checkSelf(l);
			string fxName;
			LuaObject.checkType(l, 2, out fxName);
			clientNullActorActPlayFx.m_fxName = fxName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5D4 RID: 107988 RVA: 0x007CB010 File Offset: 0x007C9210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlayFx clientNullActorActPlayFx = (ClientNullActorActPlayFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActPlayFx.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5D5 RID: 107989 RVA: 0x007CB068 File Offset: 0x007C9268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlayFx clientNullActorActPlayFx = (ClientNullActorActPlayFx)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientNullActorActPlayFx.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5D6 RID: 107990 RVA: 0x007CB0C0 File Offset: 0x007C92C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActPlayFx");
		string name = "m_fxName";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.get_m_fxName);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.set_m_fxName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache1, true);
		string name2 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.get_m_position);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.set_m_position);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.<>f__mg$cache4, typeof(ClientNullActorActPlayFx), typeof(ClientActorAct));
	}

	// Token: 0x0401094F RID: 67919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010950 RID: 67920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010951 RID: 67921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010952 RID: 67922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010953 RID: 67923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
