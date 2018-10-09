using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200136E RID: 4974
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaDefendBattle : LuaObject
{
	// Token: 0x0601AD6D RID: 109933 RVA: 0x00805C14 File Offset: 0x00803E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle o = new ArenaDefendBattle();
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

	// Token: 0x0601AD6E RID: 109934 RVA: 0x00805C5C File Offset: 0x00803E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			arenaDefendBattle.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD6F RID: 109935 RVA: 0x00805CA8 File Offset: 0x00803EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			GameObject root;
			LuaObject.checkType<GameObject>(l, 2, out root);
			arenaDefendBattle.Initialize(root);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD70 RID: 109936 RVA: 0x00805D00 File Offset: 0x00803F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMap(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out battleInfo);
			arenaDefendBattle.CreateMap(battleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD71 RID: 109937 RVA: 0x00805D58 File Offset: 0x00803F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyMap(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			arenaDefendBattle.DestroyMap();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD72 RID: 109938 RVA: 0x00805DA4 File Offset: 0x00803FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			arenaDefendBattle.Update(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD73 RID: 109939 RVA: 0x00805DFC File Offset: 0x00803FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGraphic(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			GenericGraphic o = arenaDefendBattle.CreateGraphic(assetName, scale);
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

	// Token: 0x0601AD74 RID: 109940 RVA: 0x00805E6C File Offset: 0x0080406C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyGraphic(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			GenericGraphic graphic;
			LuaObject.checkType<GenericGraphic>(l, 2, out graphic);
			arenaDefendBattle.DestroyGraphic(graphic);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD75 RID: 109941 RVA: 0x00805EC4 File Offset: 0x008040C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GridPositionToWorldPosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			Vector2 o = arenaDefendBattle.GridPositionToWorldPosition(p);
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

	// Token: 0x0601AD76 RID: 109942 RVA: 0x00805F28 File Offset: 0x00804128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldPositionToGridPosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			Vector2 sp;
			LuaObject.checkType(l, 2, out sp);
			GridPosition gridPosition = arenaDefendBattle.WorldPositionToGridPosition(sp);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD77 RID: 109943 RVA: 0x00805F90 File Offset: 0x00804190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScreenPositionToWorldPosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			Vector2 o = arenaDefendBattle.ScreenPositionToWorldPosition(p);
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

	// Token: 0x0601AD78 RID: 109944 RVA: 0x00805FF4 File Offset: 0x008041F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScreenPositionToGridPosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			GridPosition gridPosition = arenaDefendBattle.ScreenPositionToGridPosition(p);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD79 RID: 109945 RVA: 0x0080605C File Offset: 0x0080425C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMapBackground(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 3, out parent);
			arenaDefendBattle.m_luaExportHelper.CreateMapBackground(battlefieldInfo, parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD7A RID: 109946 RVA: 0x008060C8 File Offset: 0x008042C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMapBackground(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			arenaDefendBattle.m_luaExportHelper.ClearMapBackground();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD7B RID: 109947 RVA: 0x0080611C File Offset: 0x0080431C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMapTerrainFx(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 3, out parent);
			arenaDefendBattle.m_luaExportHelper.CreateMapTerrainFx(battlefieldInfo, parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD7C RID: 109948 RVA: 0x00806188 File Offset: 0x00804388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMapTerrainFx(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			arenaDefendBattle.m_luaExportHelper.ClearMapTerrainFx();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD7D RID: 109949 RVA: 0x008061DC File Offset: 0x008043DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.m_luaExportHelper.m_graphicRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD7E RID: 109950 RVA: 0x00806234 File Offset: 0x00804434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			GameObject graphicRoot;
			LuaObject.checkType<GameObject>(l, 2, out graphicRoot);
			arenaDefendBattle.m_luaExportHelper.m_graphicRoot = graphicRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD7F RID: 109951 RVA: 0x00806290 File Offset: 0x00804490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapRoot(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.m_luaExportHelper.m_mapRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD80 RID: 109952 RVA: 0x008062E8 File Offset: 0x008044E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapRoot(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			GameObject mapRoot;
			LuaObject.checkType<GameObject>(l, 2, out mapRoot);
			arenaDefendBattle.m_luaExportHelper.m_mapRoot = mapRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD81 RID: 109953 RVA: 0x00806344 File Offset: 0x00804544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapBackground(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.m_luaExportHelper.m_mapBackground);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD82 RID: 109954 RVA: 0x0080639C File Offset: 0x0080459C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapBackground(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			GameObject mapBackground;
			LuaObject.checkType<GameObject>(l, 2, out mapBackground);
			arenaDefendBattle.m_luaExportHelper.m_mapBackground = mapBackground;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD83 RID: 109955 RVA: 0x008063F8 File Offset: 0x008045F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapTerrainFxRoot(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.m_luaExportHelper.m_mapTerrainFxRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD84 RID: 109956 RVA: 0x00806450 File Offset: 0x00804650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapTerrainFxRoot(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			GameObject mapTerrainFxRoot;
			LuaObject.checkType<GameObject>(l, 2, out mapTerrainFxRoot);
			arenaDefendBattle.m_luaExportHelper.m_mapTerrainFxRoot = mapTerrainFxRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD85 RID: 109957 RVA: 0x008064AC File Offset: 0x008046AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapTerrainFxs(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.m_luaExportHelper.m_mapTerrainFxs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD86 RID: 109958 RVA: 0x00806504 File Offset: 0x00804704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapTerrainFxs(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			Dictionary<GridPosition, GameObject> mapTerrainFxs;
			LuaObject.checkType<Dictionary<GridPosition, GameObject>>(l, 2, out mapTerrainFxs);
			arenaDefendBattle.m_luaExportHelper.m_mapTerrainFxs = mapTerrainFxs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD87 RID: 109959 RVA: 0x00806560 File Offset: 0x00804760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.m_luaExportHelper.m_arenaBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD88 RID: 109960 RVA: 0x008065B8 File Offset: 0x008047B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo arenaBattleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out arenaBattleInfo);
			arenaDefendBattle.m_luaExportHelper.m_arenaBattleInfo = arenaBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD89 RID: 109961 RVA: 0x00806614 File Offset: 0x00804814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_camera(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.m_luaExportHelper.m_camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD8A RID: 109962 RVA: 0x0080666C File Offset: 0x0080486C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_camera(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			BattleCamera camera;
			LuaObject.checkType<BattleCamera>(l, 2, out camera);
			arenaDefendBattle.m_luaExportHelper.m_camera = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD8B RID: 109963 RVA: 0x008066C8 File Offset: 0x008048C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.m_luaExportHelper.m_graphicPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD8C RID: 109964 RVA: 0x00806720 File Offset: 0x00804920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			GraphicPool graphicPool;
			LuaObject.checkType<GraphicPool>(l, 2, out graphicPool);
			arenaDefendBattle.m_luaExportHelper.m_graphicPool = graphicPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD8D RID: 109965 RVA: 0x0080677C File Offset: 0x0080497C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.m_luaExportHelper.m_fxPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD8E RID: 109966 RVA: 0x008067D4 File Offset: 0x008049D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxPool(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			GraphicPool fxPool;
			LuaObject.checkType<GraphicPool>(l, 2, out fxPool);
			arenaDefendBattle.m_luaExportHelper.m_fxPool = fxPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD8F RID: 109967 RVA: 0x00806830 File Offset: 0x00804A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.m_luaExportHelper.m_fxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD90 RID: 109968 RVA: 0x00806888 File Offset: 0x00804A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			FxPlayer fxPlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out fxPlayer);
			arenaDefendBattle.m_luaExportHelper.m_fxPlayer = fxPlayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD91 RID: 109969 RVA: 0x008068E4 File Offset: 0x00804AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.ArenaBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD92 RID: 109970 RVA: 0x00806938 File Offset: 0x00804B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Camera(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.Camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD93 RID: 109971 RVA: 0x0080698C File Offset: 0x00804B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle arenaDefendBattle = (ArenaDefendBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendBattle.FxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD94 RID: 109972 RVA: 0x008069E0 File Offset: 0x00804BE0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaDefendBattle");
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.CreateMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.DestroyMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.CreateGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.DestroyGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.GridPositionToWorldPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.WorldPositionToGridPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.ScreenPositionToWorldPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.ScreenPositionToGridPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.CreateMapBackground);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.ClearMapBackground);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.CreateMapTerrainFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.ClearMapTerrainFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheE);
		string name = "m_graphicRoot";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_m_graphicRoot);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.set_m_graphicRoot);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache10, true);
		string name2 = "m_mapRoot";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_m_mapRoot);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.set_m_mapRoot);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache12, true);
		string name3 = "m_mapBackground";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_m_mapBackground);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.set_m_mapBackground);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache14, true);
		string name4 = "m_mapTerrainFxRoot";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_m_mapTerrainFxRoot);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.set_m_mapTerrainFxRoot);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache16, true);
		string name5 = "m_mapTerrainFxs";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_m_mapTerrainFxs);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.set_m_mapTerrainFxs);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache18, true);
		string name6 = "m_arenaBattleInfo";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_m_arenaBattleInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.set_m_arenaBattleInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1A, true);
		string name7 = "m_camera";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_m_camera);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.set_m_camera);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1C, true);
		string name8 = "m_graphicPool";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_m_graphicPool);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.set_m_graphicPool);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1E, true);
		string name9 = "m_fxPool";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_m_fxPool);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.set_m_fxPool);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache20, true);
		string name10 = "m_fxPlayer";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_m_fxPlayer);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.set_m_fxPlayer);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache22, true);
		string name11 = "ArenaBattleInfo";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_ArenaBattleInfo);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache23, null, true);
		string name12 = "Camera";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_Camera);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache24, null, true);
		string name13 = "FxPlayer";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.get_FxPlayer);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache25, null, true);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.<>f__mg$cache26, typeof(ArenaDefendBattle));
	}

	// Token: 0x04011073 RID: 69747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011074 RID: 69748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011075 RID: 69749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011076 RID: 69750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011077 RID: 69751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011078 RID: 69752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011079 RID: 69753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401107A RID: 69754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401107B RID: 69755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401107C RID: 69756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401107D RID: 69757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401107E RID: 69758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401107F RID: 69759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011080 RID: 69760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011081 RID: 69761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011082 RID: 69762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011083 RID: 69763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011084 RID: 69764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011085 RID: 69765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011086 RID: 69766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011087 RID: 69767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011088 RID: 69768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011089 RID: 69769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401108A RID: 69770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401108B RID: 69771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401108C RID: 69772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401108D RID: 69773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401108E RID: 69774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401108F RID: 69775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011090 RID: 69776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011091 RID: 69777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011092 RID: 69778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011093 RID: 69779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011094 RID: 69780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011095 RID: 69781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011096 RID: 69782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011097 RID: 69783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011098 RID: 69784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011099 RID: 69785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
