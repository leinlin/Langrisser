using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200132D RID: 4909
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat : LuaObject
{
	// Token: 0x0601A5B0 RID: 107952 RVA: 0x007CA374 File Offset: 0x007C8574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActFastCombat o = new ClientNullActorActFastCombat();
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

	// Token: 0x0601A5B1 RID: 107953 RVA: 0x007CA3BC File Offset: 0x007C85BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fastCombatActorInfoA(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActFastCombat clientNullActorActFastCombat = (ClientNullActorActFastCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActFastCombat.m_fastCombatActorInfoA);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5B2 RID: 107954 RVA: 0x007CA410 File Offset: 0x007C8610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fastCombatActorInfoA(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActFastCombat clientNullActorActFastCombat = (ClientNullActorActFastCombat)LuaObject.checkSelf(l);
			FastCombatActorInfo fastCombatActorInfoA;
			LuaObject.checkType<FastCombatActorInfo>(l, 2, out fastCombatActorInfoA);
			clientNullActorActFastCombat.m_fastCombatActorInfoA = fastCombatActorInfoA;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5B3 RID: 107955 RVA: 0x007CA468 File Offset: 0x007C8668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fastCombatActorInfoB(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActFastCombat clientNullActorActFastCombat = (ClientNullActorActFastCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActFastCombat.m_fastCombatActorInfoB);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5B4 RID: 107956 RVA: 0x007CA4BC File Offset: 0x007C86BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fastCombatActorInfoB(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActFastCombat clientNullActorActFastCombat = (ClientNullActorActFastCombat)LuaObject.checkSelf(l);
			FastCombatActorInfo fastCombatActorInfoB;
			LuaObject.checkType<FastCombatActorInfo>(l, 2, out fastCombatActorInfoB);
			clientNullActorActFastCombat.m_fastCombatActorInfoB = fastCombatActorInfoB;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5B5 RID: 107957 RVA: 0x007CA514 File Offset: 0x007C8714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackerSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActFastCombat clientNullActorActFastCombat = (ClientNullActorActFastCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActFastCombat.m_attackerSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5B6 RID: 107958 RVA: 0x007CA568 File Offset: 0x007C8768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackerSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActFastCombat clientNullActorActFastCombat = (ClientNullActorActFastCombat)LuaObject.checkSelf(l);
			ConfigDataSkillInfo attackerSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out attackerSkillInfo);
			clientNullActorActFastCombat.m_attackerSkillInfo = attackerSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5B7 RID: 107959 RVA: 0x007CA5C0 File Offset: 0x007C87C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActFastCombat");
		string name = "m_fastCombatActorInfoA";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.get_m_fastCombatActorInfoA);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.set_m_fastCombatActorInfoA);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache1, true);
		string name2 = "m_fastCombatActorInfoB";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.get_m_fastCombatActorInfoB);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.set_m_fastCombatActorInfoB);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache3, true);
		string name3 = "m_attackerSkillInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.get_m_attackerSkillInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.set_m_attackerSkillInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.<>f__mg$cache6, typeof(ClientNullActorActFastCombat), typeof(ClientActorAct));
	}

	// Token: 0x04010938 RID: 67896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010939 RID: 67897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401093A RID: 67898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401093B RID: 67899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401093C RID: 67900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401093D RID: 67901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401093E RID: 67902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
