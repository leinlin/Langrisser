using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001334 RID: 4916
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound : LuaObject
{
	// Token: 0x0601A5DD RID: 107997 RVA: 0x007CB338 File Offset: 0x007C9538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlaySound o = new ClientNullActorActPlaySound();
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

	// Token: 0x0601A5DE RID: 107998 RVA: 0x007CB380 File Offset: 0x007C9580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soundName(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlaySound clientNullActorActPlaySound = (ClientNullActorActPlaySound)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActPlaySound.m_soundName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5DF RID: 107999 RVA: 0x007CB3D4 File Offset: 0x007C95D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soundName(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlaySound clientNullActorActPlaySound = (ClientNullActorActPlaySound)LuaObject.checkSelf(l);
			string soundName;
			LuaObject.checkType(l, 2, out soundName);
			clientNullActorActPlaySound.m_soundName = soundName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5E0 RID: 108000 RVA: 0x007CB42C File Offset: 0x007C962C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActPlaySound");
		string name = "m_soundName";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.get_m_soundName);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.set_m_soundName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.<>f__mg$cache2, typeof(ClientNullActorActPlaySound), typeof(ClientActorAct));
	}

	// Token: 0x04010957 RID: 67927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010958 RID: 67928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010959 RID: 67929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
