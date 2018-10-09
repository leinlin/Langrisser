using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001302 RID: 4866
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit : LuaObject
{
	// Token: 0x0601A226 RID: 107046 RVA: 0x007AF4DC File Offset: 0x007AD6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPassiveSkillHit o = new ClientActorActPassiveSkillHit();
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

	// Token: 0x0601A227 RID: 107047 RVA: 0x007AF524 File Offset: 0x007AD724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sourceBuffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPassiveSkillHit clientActorActPassiveSkillHit = (ClientActorActPassiveSkillHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPassiveSkillHit.m_sourceBuffState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A228 RID: 107048 RVA: 0x007AF578 File Offset: 0x007AD778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sourceBuffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPassiveSkillHit clientActorActPassiveSkillHit = (ClientActorActPassiveSkillHit)LuaObject.checkSelf(l);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 2, out sourceBuffState);
			clientActorActPassiveSkillHit.m_sourceBuffState = sourceBuffState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A229 RID: 107049 RVA: 0x007AF5D0 File Offset: 0x007AD7D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActPassiveSkillHit");
		string name = "m_sourceBuffState";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.get_m_sourceBuffState);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.set_m_sourceBuffState);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.<>f__mg$cache2, typeof(ClientActorActPassiveSkillHit), typeof(ClientActorAct));
	}

	// Token: 0x04010604 RID: 67076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010605 RID: 67077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010606 RID: 67078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
