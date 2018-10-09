using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001304 RID: 4868
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation : LuaObject
{
	// Token: 0x0601A236 RID: 107062 RVA: 0x007AFADC File Offset: 0x007ADCDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPlayAnimation o = new ClientActorActPlayAnimation();
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

	// Token: 0x0601A237 RID: 107063 RVA: 0x007AFB24 File Offset: 0x007ADD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_animationName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPlayAnimation clientActorActPlayAnimation = (ClientActorActPlayAnimation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPlayAnimation.m_animationName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A238 RID: 107064 RVA: 0x007AFB78 File Offset: 0x007ADD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_animationName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPlayAnimation clientActorActPlayAnimation = (ClientActorActPlayAnimation)LuaObject.checkSelf(l);
			string animationName;
			LuaObject.checkType(l, 2, out animationName);
			clientActorActPlayAnimation.m_animationName = animationName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A239 RID: 107065 RVA: 0x007AFBD0 File Offset: 0x007ADDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_animationTime(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPlayAnimation clientActorActPlayAnimation = (ClientActorActPlayAnimation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPlayAnimation.m_animationTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A23A RID: 107066 RVA: 0x007AFC24 File Offset: 0x007ADE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_animationTime(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPlayAnimation clientActorActPlayAnimation = (ClientActorActPlayAnimation)LuaObject.checkSelf(l);
			int animationTime;
			LuaObject.checkType(l, 2, out animationTime);
			clientActorActPlayAnimation.m_animationTime = animationTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A23B RID: 107067 RVA: 0x007AFC7C File Offset: 0x007ADE7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActPlayAnimation");
		string name = "m_animationName";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.get_m_animationName);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.set_m_animationName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache1, true);
		string name2 = "m_animationTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.get_m_animationTime);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.set_m_animationTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.<>f__mg$cache4, typeof(ClientActorActPlayAnimation), typeof(ClientActorAct));
	}

	// Token: 0x04010610 RID: 67088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010611 RID: 67089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010612 RID: 67090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010613 RID: 67091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010614 RID: 67092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
