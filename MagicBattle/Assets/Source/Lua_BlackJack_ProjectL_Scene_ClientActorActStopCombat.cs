using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200130D RID: 4877
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat : LuaObject
{
	// Token: 0x0601A281 RID: 107137 RVA: 0x007B1740 File Offset: 0x007AF940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopCombat o = new ClientActorActStopCombat();
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

	// Token: 0x0601A282 RID: 107138 RVA: 0x007B1788 File Offset: 0x007AF988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopCombat clientActorActStopCombat = (ClientActorActStopCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStopCombat.m_heroHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A283 RID: 107139 RVA: 0x007B17DC File Offset: 0x007AF9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopCombat clientActorActStopCombat = (ClientActorActStopCombat)LuaObject.checkSelf(l);
			int heroHp;
			LuaObject.checkType(l, 2, out heroHp);
			clientActorActStopCombat.m_heroHp = heroHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A284 RID: 107140 RVA: 0x007B1834 File Offset: 0x007AFA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopCombat clientActorActStopCombat = (ClientActorActStopCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStopCombat.m_soldierHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A285 RID: 107141 RVA: 0x007B1888 File Offset: 0x007AFA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopCombat clientActorActStopCombat = (ClientActorActStopCombat)LuaObject.checkSelf(l);
			int soldierHp;
			LuaObject.checkType(l, 2, out soldierHp);
			clientActorActStopCombat.m_soldierHp = soldierHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A286 RID: 107142 RVA: 0x007B18E0 File Offset: 0x007AFAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDamage(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopCombat clientActorActStopCombat = (ClientActorActStopCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStopCombat.m_heroDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A287 RID: 107143 RVA: 0x007B1934 File Offset: 0x007AFB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDamage(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopCombat clientActorActStopCombat = (ClientActorActStopCombat)LuaObject.checkSelf(l);
			int heroDamage;
			LuaObject.checkType(l, 2, out heroDamage);
			clientActorActStopCombat.m_heroDamage = heroDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A288 RID: 107144 RVA: 0x007B198C File Offset: 0x007AFB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDamage(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopCombat clientActorActStopCombat = (ClientActorActStopCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStopCombat.m_soldierDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A289 RID: 107145 RVA: 0x007B19E0 File Offset: 0x007AFBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDamage(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopCombat clientActorActStopCombat = (ClientActorActStopCombat)LuaObject.checkSelf(l);
			int soldierDamage;
			LuaObject.checkType(l, 2, out soldierDamage);
			clientActorActStopCombat.m_soldierDamage = soldierDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A28A RID: 107146 RVA: 0x007B1A38 File Offset: 0x007AFC38
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActStopCombat");
		string name = "m_heroHp";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.get_m_heroHp);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.set_m_heroHp);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache1, true);
		string name2 = "m_soldierHp";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.get_m_soldierHp);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.set_m_soldierHp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache3, true);
		string name3 = "m_heroDamage";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.get_m_heroDamage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.set_m_heroDamage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache5, true);
		string name4 = "m_soldierDamage";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.get_m_soldierDamage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.set_m_soldierDamage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.<>f__mg$cache8, typeof(ClientActorActStopCombat), typeof(ClientActorAct));
	}

	// Token: 0x04010649 RID: 67145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401064A RID: 67146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401064B RID: 67147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401064C RID: 67148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401064D RID: 67149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401064E RID: 67150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401064F RID: 67151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010650 RID: 67152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010651 RID: 67153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
