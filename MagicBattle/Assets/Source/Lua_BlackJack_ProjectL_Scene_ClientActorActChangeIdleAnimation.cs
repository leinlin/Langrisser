using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012F8 RID: 4856
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation : LuaObject
{
	// Token: 0x0601A1E0 RID: 106976 RVA: 0x007ADBA4 File Offset: 0x007ABDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeIdleAnimation o = new ClientActorActChangeIdleAnimation();
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

	// Token: 0x0601A1E1 RID: 106977 RVA: 0x007ADBEC File Offset: 0x007ABDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_idleAnimationName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeIdleAnimation clientActorActChangeIdleAnimation = (ClientActorActChangeIdleAnimation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActChangeIdleAnimation.m_idleAnimationName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1E2 RID: 106978 RVA: 0x007ADC40 File Offset: 0x007ABE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_idleAnimationName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeIdleAnimation clientActorActChangeIdleAnimation = (ClientActorActChangeIdleAnimation)LuaObject.checkSelf(l);
			string idleAnimationName;
			LuaObject.checkType(l, 2, out idleAnimationName);
			clientActorActChangeIdleAnimation.m_idleAnimationName = idleAnimationName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1E3 RID: 106979 RVA: 0x007ADC98 File Offset: 0x007ABE98
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActChangeIdleAnimation");
		string name = "m_idleAnimationName";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.get_m_idleAnimationName);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.set_m_idleAnimationName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.<>f__mg$cache2, typeof(ClientActorActChangeIdleAnimation), typeof(ClientActorAct));
	}

	// Token: 0x040105D2 RID: 67026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105D3 RID: 67027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105D4 RID: 67028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
