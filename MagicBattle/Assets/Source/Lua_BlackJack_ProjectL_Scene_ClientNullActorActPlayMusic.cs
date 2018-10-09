using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001333 RID: 4915
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic : LuaObject
{
	// Token: 0x0601A5D8 RID: 107992 RVA: 0x007CB1A4 File Offset: 0x007C93A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlayMusic o = new ClientNullActorActPlayMusic();
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

	// Token: 0x0601A5D9 RID: 107993 RVA: 0x007CB1EC File Offset: 0x007C93EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_musicName(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlayMusic clientNullActorActPlayMusic = (ClientNullActorActPlayMusic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActPlayMusic.m_musicName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5DA RID: 107994 RVA: 0x007CB240 File Offset: 0x007C9440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_musicName(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActPlayMusic clientNullActorActPlayMusic = (ClientNullActorActPlayMusic)LuaObject.checkSelf(l);
			string musicName;
			LuaObject.checkType(l, 2, out musicName);
			clientNullActorActPlayMusic.m_musicName = musicName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5DB RID: 107995 RVA: 0x007CB298 File Offset: 0x007C9498
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActPlayMusic");
		string name = "m_musicName";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.get_m_musicName);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.set_m_musicName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.<>f__mg$cache2, typeof(ClientNullActorActPlayMusic), typeof(ClientActorAct));
	}

	// Token: 0x04010954 RID: 67924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010955 RID: 67925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010956 RID: 67926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
