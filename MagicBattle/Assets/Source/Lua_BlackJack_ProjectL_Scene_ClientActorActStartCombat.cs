using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200130B RID: 4875
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat : LuaObject
{
	// Token: 0x0601A26D RID: 107117 RVA: 0x007B0F5C File Offset: 0x007AF15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartCombat o = new ClientActorActStartCombat();
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

	// Token: 0x0601A26E RID: 107118 RVA: 0x007B0FA4 File Offset: 0x007AF1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetActor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartCombat clientActorActStartCombat = (ClientActorActStartCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStartCombat.m_targetActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A26F RID: 107119 RVA: 0x007B0FF8 File Offset: 0x007AF1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetActor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartCombat clientActorActStartCombat = (ClientActorActStartCombat)LuaObject.checkSelf(l);
			BattleActor targetActor;
			LuaObject.checkType<BattleActor>(l, 2, out targetActor);
			clientActorActStartCombat.m_targetActor = targetActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A270 RID: 107120 RVA: 0x007B1050 File Offset: 0x007AF250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackerSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartCombat clientActorActStartCombat = (ClientActorActStartCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStartCombat.m_attackerSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A271 RID: 107121 RVA: 0x007B10A4 File Offset: 0x007AF2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackerSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartCombat clientActorActStartCombat = (ClientActorActStartCombat)LuaObject.checkSelf(l);
			ConfigDataSkillInfo attackerSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out attackerSkillInfo);
			clientActorActStartCombat.m_attackerSkillInfo = attackerSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A272 RID: 107122 RVA: 0x007B10FC File Offset: 0x007AF2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartCombat clientActorActStartCombat = (ClientActorActStartCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStartCombat.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A273 RID: 107123 RVA: 0x007B1150 File Offset: 0x007AF350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartCombat clientActorActStartCombat = (ClientActorActStartCombat)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActStartCombat.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A274 RID: 107124 RVA: 0x007B11A8 File Offset: 0x007AF3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAttacker(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartCombat clientActorActStartCombat = (ClientActorActStartCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStartCombat.m_isAttacker);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A275 RID: 107125 RVA: 0x007B11FC File Offset: 0x007AF3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAttacker(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartCombat clientActorActStartCombat = (ClientActorActStartCombat)LuaObject.checkSelf(l);
			bool isAttacker;
			LuaObject.checkType(l, 2, out isAttacker);
			clientActorActStartCombat.m_isAttacker = isAttacker;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A276 RID: 107126 RVA: 0x007B1254 File Offset: 0x007AF454
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActStartCombat");
		string name = "m_targetActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.get_m_targetActor);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.set_m_targetActor);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache1, true);
		string name2 = "m_attackerSkillInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.get_m_attackerSkillInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.set_m_attackerSkillInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache3, true);
		string name3 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.get_m_direction);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.set_m_direction);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache5, true);
		string name4 = "m_isAttacker";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.get_m_isAttacker);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.set_m_isAttacker);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.<>f__mg$cache8, typeof(ClientActorActStartCombat), typeof(ClientActorAct));
	}

	// Token: 0x04010639 RID: 67129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401063A RID: 67130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401063B RID: 67131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401063C RID: 67132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401063D RID: 67133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401063E RID: 67134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401063F RID: 67135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010640 RID: 67136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010641 RID: 67137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
