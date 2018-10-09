using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001198 RID: 4504
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleMapCell : LuaObject
{
	// Token: 0x060173FE RID: 95230 RVA: 0x0064E90C File Offset: 0x0064CB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleMapCell o = new BattleMapCell();
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

	// Token: 0x060173FF RID: 95231 RVA: 0x0064E954 File Offset: 0x0064CB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_terrain(IntPtr l)
	{
		int result;
		try
		{
			BattleMapCell battleMapCell = (BattleMapCell)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapCell.m_terrain);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017400 RID: 95232 RVA: 0x0064E9A8 File Offset: 0x0064CBA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_terrain(IntPtr l)
	{
		int result;
		try
		{
			BattleMapCell battleMapCell = (BattleMapCell)LuaObject.checkSelf(l);
			ConfigDataTerrainInfo terrain;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 2, out terrain);
			battleMapCell.m_terrain = terrain;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017401 RID: 95233 RVA: 0x0064EA00 File Offset: 0x0064CC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actor(IntPtr l)
	{
		int result;
		try
		{
			BattleMapCell battleMapCell = (BattleMapCell)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapCell.m_actor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017402 RID: 95234 RVA: 0x0064EA54 File Offset: 0x0064CC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actor(IntPtr l)
	{
		int result;
		try
		{
			BattleMapCell battleMapCell = (BattleMapCell)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			battleMapCell.m_actor = actor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017403 RID: 95235 RVA: 0x0064EAAC File Offset: 0x0064CCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_region(IntPtr l)
	{
		int result;
		try
		{
			BattleMapCell battleMapCell = (BattleMapCell)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapCell.m_region);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017404 RID: 95236 RVA: 0x0064EB00 File Offset: 0x0064CD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_region(IntPtr l)
	{
		int result;
		try
		{
			BattleMapCell battleMapCell = (BattleMapCell)LuaObject.checkSelf(l);
			int region;
			LuaObject.checkType(l, 2, out region);
			battleMapCell.m_region = region;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017405 RID: 95237 RVA: 0x0064EB58 File Offset: 0x0064CD58
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleMapCell");
		string name = "m_terrain";
		if (Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMapCell.get_m_terrain);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMapCell.set_m_terrain);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache1, true);
		string name2 = "m_actor";
		if (Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMapCell.get_m_actor);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMapCell.set_m_actor);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache3, true);
		string name3 = "m_region";
		if (Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMapCell.get_m_region);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMapCell.set_m_region);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMapCell.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleMapCell.<>f__mg$cache6, typeof(BattleMapCell));
	}

	// Token: 0x0400DAB0 RID: 55984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DAB1 RID: 55985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DAB2 RID: 55986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DAB3 RID: 55987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DAB4 RID: 55988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DAB5 RID: 55989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DAB6 RID: 55990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
