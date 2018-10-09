using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001197 RID: 4503
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleMap : LuaObject
{
	// Token: 0x060173DF RID: 95199 RVA: 0x0064DA74 File Offset: 0x0064BC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleMap o = new BattleMap();
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

	// Token: 0x060173E0 RID: 95200 RVA: 0x0064DABC File Offset: 0x0064BCBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			int w;
			LuaObject.checkType(l, 2, out w);
			int h;
			LuaObject.checkType(l, 3, out h);
			battleMap.Initialize(w, h);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173E1 RID: 95201 RVA: 0x0064DB20 File Offset: 0x0064BD20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitializeTerrain(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 3, out configDataLoader);
			bool b = battleMap.InitializeTerrain(battlefieldInfo, configDataLoader);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173E2 RID: 95202 RVA: 0x0064DB90 File Offset: 0x0064BD90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			battleMap.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173E3 RID: 95203 RVA: 0x0064DBDC File Offset: 0x0064BDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearActors(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			battleMap.ClearActors();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173E4 RID: 95204 RVA: 0x0064DC28 File Offset: 0x0064BE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			battleMap.ClearRegion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173E5 RID: 95205 RVA: 0x0064DC74 File Offset: 0x0064BE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsValidPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			bool b = battleMap.IsValidPosition(p);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173E6 RID: 95206 RVA: 0x0064DCD8 File Offset: 0x0064BED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActor(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 3, out actor);
			battleMap.SetActor(p, actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173E7 RID: 95207 RVA: 0x0064DD3C File Offset: 0x0064BF3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetActor(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			BattleActor actor = battleMap.GetActor(p);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173E8 RID: 95208 RVA: 0x0064DDA0 File Offset: 0x0064BFA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTerrain(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			ConfigDataTerrainInfo terrainInfo;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 3, out terrainInfo);
			battleMap.SetTerrain(p, terrainInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173E9 RID: 95209 RVA: 0x0064DE04 File Offset: 0x0064C004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTerrain(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			ConfigDataTerrainInfo terrain = battleMap.GetTerrain(p);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, terrain);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173EA RID: 95210 RVA: 0x0064DE68 File Offset: 0x0064C068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int region;
			LuaObject.checkType(l, 3, out region);
			battleMap.SetRegion(p, region);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173EB RID: 95211 RVA: 0x0064DECC File Offset: 0x0064C0CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int region = battleMap.GetRegion(p);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, region);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173EC RID: 95212 RVA: 0x0064DF30 File Offset: 0x0064C130
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetRegionBit(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int bit;
			LuaObject.checkType(l, 3, out bit);
			battleMap.SetRegionBit(p, bit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173ED RID: 95213 RVA: 0x0064DF94 File Offset: 0x0064C194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRegionBit(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int bit;
			LuaObject.checkType(l, 3, out bit);
			battleMap.ClearRegionBit(p, bit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173EE RID: 95214 RVA: 0x0064DFF8 File Offset: 0x0064C1F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasRegionBit(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int bit;
			LuaObject.checkType(l, 3, out bit);
			bool b = battleMap.HasRegionBit(p, bit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173EF RID: 95215 RVA: 0x0064E068 File Offset: 0x0064C268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMovePointCost(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 3, out moveType);
			int movePointCost = battleMap.GetMovePointCost(p, moveType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, movePointCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173F0 RID: 95216 RVA: 0x0064E0D8 File Offset: 0x0064C2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMovePointCost_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTerrainInfo terrain;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 1, out terrain);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 2, out moveType);
			int movePointCost = BattleMap.GetMovePointCost(terrain, moveType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, movePointCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173F1 RID: 95217 RVA: 0x0064E138 File Offset: 0x0064C338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCell(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			BattleMapCell cell = battleMap.m_luaExportHelper.GetCell(p);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cell);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173F2 RID: 95218 RVA: 0x0064E1A0 File Offset: 0x0064C3A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MoveRegion(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173F3 RID: 95219 RVA: 0x0064E1E4 File Offset: 0x0064C3E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackRegion(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173F4 RID: 95220 RVA: 0x0064E228 File Offset: 0x0064C428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillRegion(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173F5 RID: 95221 RVA: 0x0064E26C File Offset: 0x0064C46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeleportRegion(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173F6 RID: 95222 RVA: 0x0064E2B0 File Offset: 0x0064C4B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_width(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMap.m_luaExportHelper.m_width);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173F7 RID: 95223 RVA: 0x0064E308 File Offset: 0x0064C508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_width(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			int width;
			LuaObject.checkType(l, 2, out width);
			battleMap.m_luaExportHelper.m_width = width;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173F8 RID: 95224 RVA: 0x0064E364 File Offset: 0x0064C564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_height(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMap.m_luaExportHelper.m_height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173F9 RID: 95225 RVA: 0x0064E3BC File Offset: 0x0064C5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_height(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			int height;
			LuaObject.checkType(l, 2, out height);
			battleMap.m_luaExportHelper.m_height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173FA RID: 95226 RVA: 0x0064E418 File Offset: 0x0064C618
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Width(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMap.Width);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173FB RID: 95227 RVA: 0x0064E46C File Offset: 0x0064C66C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Height(IntPtr l)
	{
		int result;
		try
		{
			BattleMap battleMap = (BattleMap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMap.Height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173FC RID: 95228 RVA: 0x0064E4C0 File Offset: 0x0064C6C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleMap");
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.InitializeTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.ClearActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.ClearRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.IsValidPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.SetActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.GetActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.SetTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.GetTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.SetRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.GetRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.SetRegionBit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.ClearRegionBit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.HasRegionBit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.GetMovePointCost);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.GetMovePointCost_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.GetCell);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache11);
		string name = "MoveRegion";
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.get_MoveRegion);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache12, null, false);
		string name2 = "AttackRegion";
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.get_AttackRegion);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache13, null, false);
		string name3 = "SkillRegion";
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.get_SkillRegion);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache14, null, false);
		string name4 = "TeleportRegion";
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.get_TeleportRegion);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache15, null, false);
		string name5 = "m_width";
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.get_m_width);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.set_m_width);
		}
		LuaObject.addMember(l, name5, get, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache17, true);
		string name6 = "m_height";
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.get_m_height);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.set_m_height);
		}
		LuaObject.addMember(l, name6, get2, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache19, true);
		string name7 = "Width";
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.get_Width);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1A, null, true);
		string name8 = "Height";
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.get_Height);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1B, null, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleMap.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleMap.<>f__mg$cache1C, typeof(BattleMap));
	}

	// Token: 0x0400DA93 RID: 55955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DA94 RID: 55956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DA95 RID: 55957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DA96 RID: 55958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DA97 RID: 55959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DA98 RID: 55960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DA99 RID: 55961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DA9A RID: 55962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DA9B RID: 55963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DA9C RID: 55964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DA9D RID: 55965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DA9E RID: 55966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DA9F RID: 55967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DAA0 RID: 55968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DAA1 RID: 55969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DAA2 RID: 55970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DAA3 RID: 55971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DAA4 RID: 55972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DAA5 RID: 55973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DAA6 RID: 55974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DAA7 RID: 55975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DAA8 RID: 55976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DAA9 RID: 55977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DAAA RID: 55978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DAAB RID: 55979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DAAC RID: 55980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DAAD RID: 55981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DAAE RID: 55982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DAAF RID: 55983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
