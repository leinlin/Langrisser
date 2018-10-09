using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001305 RID: 4869
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx : LuaObject
{
	// Token: 0x0601A23D RID: 107069 RVA: 0x007AFD60 File Offset: 0x007ADF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPlayFx o = new ClientActorActPlayFx();
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

	// Token: 0x0601A23E RID: 107070 RVA: 0x007AFDA8 File Offset: 0x007ADFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPlayFx clientActorActPlayFx = (ClientActorActPlayFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPlayFx.m_fxName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A23F RID: 107071 RVA: 0x007AFDFC File Offset: 0x007ADFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPlayFx clientActorActPlayFx = (ClientActorActPlayFx)LuaObject.checkSelf(l);
			string fxName;
			LuaObject.checkType(l, 2, out fxName);
			clientActorActPlayFx.m_fxName = fxName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A240 RID: 107072 RVA: 0x007AFE54 File Offset: 0x007AE054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attachMode(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPlayFx clientActorActPlayFx = (ClientActorActPlayFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPlayFx.m_attachMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A241 RID: 107073 RVA: 0x007AFEA8 File Offset: 0x007AE0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attachMode(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPlayFx clientActorActPlayFx = (ClientActorActPlayFx)LuaObject.checkSelf(l);
			int attachMode;
			LuaObject.checkType(l, 2, out attachMode);
			clientActorActPlayFx.m_attachMode = attachMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A242 RID: 107074 RVA: 0x007AFF00 File Offset: 0x007AE100
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActPlayFx");
		string name = "m_fxName";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.get_m_fxName);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.set_m_fxName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache1, true);
		string name2 = "m_attachMode";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.get_m_attachMode);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.set_m_attachMode);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.<>f__mg$cache4, typeof(ClientActorActPlayFx), typeof(ClientActorAct));
	}

	// Token: 0x04010615 RID: 67093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010616 RID: 67094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010617 RID: 67095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010618 RID: 67096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010619 RID: 67097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
