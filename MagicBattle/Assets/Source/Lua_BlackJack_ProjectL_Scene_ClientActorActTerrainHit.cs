using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001313 RID: 4883
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit : LuaObject
{
	// Token: 0x0601A2B1 RID: 107185 RVA: 0x007B2944 File Offset: 0x007B0B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit o = new ClientActorActTerrainHit();
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

	// Token: 0x0601A2B2 RID: 107186 RVA: 0x007B298C File Offset: 0x007B0B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrainInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTerrainHit.m_terrainInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2B3 RID: 107187 RVA: 0x007B29E0 File Offset: 0x007B0BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_terrainInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 2, out terrainInfo);
			clientActorActTerrainHit.m_terrainInfo = terrainInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2B4 RID: 107188 RVA: 0x007B2A38 File Offset: 0x007B0C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTerrainHit.m_heroHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2B5 RID: 107189 RVA: 0x007B2A8C File Offset: 0x007B0C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			int heroHp;
			LuaObject.checkType(l, 2, out heroHp);
			clientActorActTerrainHit.m_heroHp = heroHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2B6 RID: 107190 RVA: 0x007B2AE4 File Offset: 0x007B0CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTerrainHit.m_soldierHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2B7 RID: 107191 RVA: 0x007B2B38 File Offset: 0x007B0D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			int soldierHp;
			LuaObject.checkType(l, 2, out soldierHp);
			clientActorActTerrainHit.m_soldierHp = soldierHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2B8 RID: 107192 RVA: 0x007B2B90 File Offset: 0x007B0D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTerrainHit.m_heroHpModify);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2B9 RID: 107193 RVA: 0x007B2BE4 File Offset: 0x007B0DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			int heroHpModify;
			LuaObject.checkType(l, 2, out heroHpModify);
			clientActorActTerrainHit.m_heroHpModify = heroHpModify;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2BA RID: 107194 RVA: 0x007B2C3C File Offset: 0x007B0E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTerrainHit.m_soldierHpModify);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2BB RID: 107195 RVA: 0x007B2C90 File Offset: 0x007B0E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			int soldierHpModify;
			LuaObject.checkType(l, 2, out soldierHpModify);
			clientActorActTerrainHit.m_soldierHpModify = soldierHpModify;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2BC RID: 107196 RVA: 0x007B2CE8 File Offset: 0x007B0EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientActorActTerrainHit.m_damageNumberType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2BD RID: 107197 RVA: 0x007B2D3C File Offset: 0x007B0F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTerrainHit clientActorActTerrainHit = (ClientActorActTerrainHit)LuaObject.checkSelf(l);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 2, out damageNumberType);
			clientActorActTerrainHit.m_damageNumberType = damageNumberType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2BE RID: 107198 RVA: 0x007B2D94 File Offset: 0x007B0F94
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActTerrainHit");
		string name = "m_terrainInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.get_m_terrainInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.set_m_terrainInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache1, true);
		string name2 = "m_heroHp";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.get_m_heroHp);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.set_m_heroHp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache3, true);
		string name3 = "m_soldierHp";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.get_m_soldierHp);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.set_m_soldierHp);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache5, true);
		string name4 = "m_heroHpModify";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.get_m_heroHpModify);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.set_m_heroHpModify);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache7, true);
		string name5 = "m_soldierHpModify";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.get_m_soldierHpModify);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.set_m_soldierHpModify);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cache9, true);
		string name6 = "m_damageNumberType";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.get_m_damageNumberType);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.set_m_damageNumberType);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.<>f__mg$cacheC, typeof(ClientActorActTerrainHit), typeof(ClientActorAct));
	}

	// Token: 0x0401066D RID: 67181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401066E RID: 67182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401066F RID: 67183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010670 RID: 67184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010671 RID: 67185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010672 RID: 67186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010673 RID: 67187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010674 RID: 67188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010675 RID: 67189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010676 RID: 67190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010677 RID: 67191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010678 RID: 67192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010679 RID: 67193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
