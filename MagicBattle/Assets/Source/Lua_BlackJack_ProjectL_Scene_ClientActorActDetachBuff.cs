using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012FA RID: 4858
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff : LuaObject
{
	// Token: 0x0601A1EC RID: 106988 RVA: 0x007ADFBC File Offset: 0x007AC1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDetachBuff o = new ClientActorActDetachBuff();
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

	// Token: 0x0601A1ED RID: 106989 RVA: 0x007AE004 File Offset: 0x007AC204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDetachBuff clientActorActDetachBuff = (ClientActorActDetachBuff)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActDetachBuff.m_buffState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1EE RID: 106990 RVA: 0x007AE058 File Offset: 0x007AC258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDetachBuff clientActorActDetachBuff = (ClientActorActDetachBuff)LuaObject.checkSelf(l);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 2, out buffState);
			clientActorActDetachBuff.m_buffState = buffState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1EF RID: 106991 RVA: 0x007AE0B0 File Offset: 0x007AC2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fightTags(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDetachBuff clientActorActDetachBuff = (ClientActorActDetachBuff)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActDetachBuff.m_fightTags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1F0 RID: 106992 RVA: 0x007AE104 File Offset: 0x007AC304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fightTags(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDetachBuff clientActorActDetachBuff = (ClientActorActDetachBuff)LuaObject.checkSelf(l);
			uint fightTags;
			LuaObject.checkType(l, 2, out fightTags);
			clientActorActDetachBuff.m_fightTags = fightTags;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1F1 RID: 106993 RVA: 0x007AE15C File Offset: 0x007AC35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHpMax(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDetachBuff clientActorActDetachBuff = (ClientActorActDetachBuff)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActDetachBuff.m_heroHpMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1F2 RID: 106994 RVA: 0x007AE1B0 File Offset: 0x007AC3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHpMax(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDetachBuff clientActorActDetachBuff = (ClientActorActDetachBuff)LuaObject.checkSelf(l);
			int heroHpMax;
			LuaObject.checkType(l, 2, out heroHpMax);
			clientActorActDetachBuff.m_heroHpMax = heroHpMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1F3 RID: 106995 RVA: 0x007AE208 File Offset: 0x007AC408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHpMax(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDetachBuff clientActorActDetachBuff = (ClientActorActDetachBuff)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActDetachBuff.m_soldierHpMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1F4 RID: 106996 RVA: 0x007AE25C File Offset: 0x007AC45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHpMax(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDetachBuff clientActorActDetachBuff = (ClientActorActDetachBuff)LuaObject.checkSelf(l);
			int soldierHpMax;
			LuaObject.checkType(l, 2, out soldierHpMax);
			clientActorActDetachBuff.m_soldierHpMax = soldierHpMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1F5 RID: 106997 RVA: 0x007AE2B4 File Offset: 0x007AC4B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActDetachBuff");
		string name = "m_buffState";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.get_m_buffState);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.set_m_buffState);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache1, true);
		string name2 = "m_fightTags";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.get_m_fightTags);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.set_m_fightTags);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache3, true);
		string name3 = "m_heroHpMax";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.get_m_heroHpMax);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.set_m_heroHpMax);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache5, true);
		string name4 = "m_soldierHpMax";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.get_m_soldierHpMax);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.set_m_soldierHpMax);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.<>f__mg$cache8, typeof(ClientActorActDetachBuff), typeof(ClientActorAct));
	}

	// Token: 0x040105DA RID: 67034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105DB RID: 67035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105DC RID: 67036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040105DD RID: 67037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040105DE RID: 67038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040105DF RID: 67039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040105E0 RID: 67040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040105E1 RID: 67041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040105E2 RID: 67042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
