using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200130A RID: 4874
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit : LuaObject
{
	// Token: 0x0601A264 RID: 107108 RVA: 0x007B0BE4 File Offset: 0x007AEDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkillHit o = new ClientActorActSkillHit();
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

	// Token: 0x0601A265 RID: 107109 RVA: 0x007B0C2C File Offset: 0x007AEE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkillHit clientActorActSkillHit = (ClientActorActSkillHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActSkillHit.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A266 RID: 107110 RVA: 0x007B0C80 File Offset: 0x007AEE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkillHit clientActorActSkillHit = (ClientActorActSkillHit)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			clientActorActSkillHit.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A267 RID: 107111 RVA: 0x007B0CD8 File Offset: 0x007AEED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkillHit clientActorActSkillHit = (ClientActorActSkillHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActSkillHit.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A268 RID: 107112 RVA: 0x007B0D2C File Offset: 0x007AEF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkillHit clientActorActSkillHit = (ClientActorActSkillHit)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActSkillHit.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A269 RID: 107113 RVA: 0x007B0D84 File Offset: 0x007AEF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hits(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkillHit clientActorActSkillHit = (ClientActorActSkillHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActSkillHit.m_hits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A26A RID: 107114 RVA: 0x007B0DD8 File Offset: 0x007AEFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hits(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkillHit clientActorActSkillHit = (ClientActorActSkillHit)LuaObject.checkSelf(l);
			List<ClientActorHitInfo> hits;
			LuaObject.checkType<List<ClientActorHitInfo>>(l, 2, out hits);
			clientActorActSkillHit.m_hits = hits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A26B RID: 107115 RVA: 0x007B0E30 File Offset: 0x007AF030
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActSkillHit");
		string name = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.get_m_skillInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.set_m_skillInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache1, true);
		string name2 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.get_m_direction);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.set_m_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache3, true);
		string name3 = "m_hits";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.get_m_hits);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.set_m_hits);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.<>f__mg$cache6, typeof(ClientActorActSkillHit), typeof(ClientActorAct));
	}

	// Token: 0x04010632 RID: 67122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010633 RID: 67123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010634 RID: 67124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010635 RID: 67125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010636 RID: 67126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010637 RID: 67127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010638 RID: 67128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
