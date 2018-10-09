using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001301 RID: 4865
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill : LuaObject
{
	// Token: 0x0601A21F RID: 107039 RVA: 0x007AF258 File Offset: 0x007AD458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPassiveSkill o = new ClientActorActPassiveSkill();
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

	// Token: 0x0601A220 RID: 107040 RVA: 0x007AF2A0 File Offset: 0x007AD4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sourceBuffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPassiveSkill clientActorActPassiveSkill = (ClientActorActPassiveSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPassiveSkill.m_sourceBuffState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A221 RID: 107041 RVA: 0x007AF2F4 File Offset: 0x007AD4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sourceBuffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPassiveSkill clientActorActPassiveSkill = (ClientActorActPassiveSkill)LuaObject.checkSelf(l);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 2, out sourceBuffState);
			clientActorActPassiveSkill.m_sourceBuffState = sourceBuffState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A222 RID: 107042 RVA: 0x007AF34C File Offset: 0x007AD54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hitSelf(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPassiveSkill clientActorActPassiveSkill = (ClientActorActPassiveSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPassiveSkill.m_hitSelf);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A223 RID: 107043 RVA: 0x007AF3A0 File Offset: 0x007AD5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hitSelf(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPassiveSkill clientActorActPassiveSkill = (ClientActorActPassiveSkill)LuaObject.checkSelf(l);
			bool hitSelf;
			LuaObject.checkType(l, 2, out hitSelf);
			clientActorActPassiveSkill.m_hitSelf = hitSelf;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A224 RID: 107044 RVA: 0x007AF3F8 File Offset: 0x007AD5F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActPassiveSkill");
		string name = "m_sourceBuffState";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.get_m_sourceBuffState);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.set_m_sourceBuffState);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache1, true);
		string name2 = "m_hitSelf";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.get_m_hitSelf);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.set_m_hitSelf);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.<>f__mg$cache4, typeof(ClientActorActPassiveSkill), typeof(ClientActorAct));
	}

	// Token: 0x040105FF RID: 67071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010600 RID: 67072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010601 RID: 67073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010602 RID: 67074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010603 RID: 67075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
