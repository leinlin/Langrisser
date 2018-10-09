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

// Token: 0x0200136D RID: 4973
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaDefendActor : LuaObject
{
	// Token: 0x0601AD49 RID: 109897 RVA: 0x00804B04 File Offset: 0x00802D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendBattle uiTask;
			LuaObject.checkType<ArenaDefendBattle>(l, 2, out uiTask);
			ArenaDefendActor o = new ArenaDefendActor(uiTask);
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

	// Token: 0x0601AD4A RID: 109898 RVA: 0x00804B58 File Offset: 0x00802D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			arenaDefendActor.Destroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD4B RID: 109899 RVA: 0x00804BA4 File Offset: 0x00802DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHero(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaDefendActor.SetHero(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD4C RID: 109900 RVA: 0x00804BFC File Offset: 0x00802DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGraphics(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			arenaDefendActor.UpdateGraphics();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD4D RID: 109901 RVA: 0x00804C48 File Offset: 0x00802E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHero(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			BattleHero hero = arenaDefendActor.GetHero();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD4E RID: 109902 RVA: 0x00804C9C File Offset: 0x00802E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			arenaDefendActor.SetPosition(p, dir);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD4F RID: 109903 RVA: 0x00804D00 File Offset: 0x00802F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			GridPosition position = arenaDefendActor.GetPosition();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD50 RID: 109904 RVA: 0x00804D5C File Offset: 0x00802F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDirection(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			int direction = arenaDefendActor.GetDirection();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD51 RID: 109905 RVA: 0x00804DB0 File Offset: 0x00802FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TweenColor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			Colori c;
			LuaObject.checkValueType<Colori>(l, 2, out c);
			arenaDefendActor.TweenColor(c);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD52 RID: 109906 RVA: 0x00804E08 File Offset: 0x00803008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			arenaDefendActor.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD53 RID: 109907 RVA: 0x00804E60 File Offset: 0x00803060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			arenaDefendActor.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD54 RID: 109908 RVA: 0x00804EB8 File Offset: 0x008030B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyGraphics(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			arenaDefendActor.m_luaExportHelper.DestroyGraphics();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD55 RID: 109909 RVA: 0x00804F0C File Offset: 0x0080310C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGraphic(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			string assetName;
			LuaObject.checkType(l, 3, out assetName);
			float scale;
			LuaObject.checkType(l, 4, out scale);
			List<ReplaceAnim> replaceAnims;
			LuaObject.checkType<List<ReplaceAnim>>(l, 5, out replaceAnims);
			bool b = arenaDefendActor.m_luaExportHelper.UpdateGraphic(idx, assetName, scale, replaceAnims);
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

	// Token: 0x0601AD56 RID: 109910 RVA: 0x00804F9C File Offset: 0x0080319C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			arenaDefendActor.m_luaExportHelper.PlayAnimation(name, loop);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD57 RID: 109911 RVA: 0x00805008 File Offset: 0x00803208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeGraphicPosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			Vector3 o = arenaDefendActor.m_luaExportHelper.ComputeGraphicPosition(p);
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

	// Token: 0x0601AD58 RID: 109912 RVA: 0x00805070 File Offset: 0x00803270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGraphicOffset(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			Vector2 graphicOffset = arenaDefendActor.m_luaExportHelper.GetGraphicOffset(idx, dir);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphicOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD59 RID: 109913 RVA: 0x008050E4 File Offset: 0x008032E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendActor.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD5A RID: 109914 RVA: 0x00805140 File Offset: 0x00803340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			arenaDefendActor.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD5B RID: 109915 RVA: 0x0080519C File Offset: 0x0080339C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendActor.m_luaExportHelper.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD5C RID: 109916 RVA: 0x008051F4 File Offset: 0x008033F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			arenaDefendActor.m_luaExportHelper.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD5D RID: 109917 RVA: 0x00805250 File Offset: 0x00803450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierCount(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendActor.m_luaExportHelper.m_soldierCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD5E RID: 109918 RVA: 0x008052A8 File Offset: 0x008034A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierCount(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			int soldierCount;
			LuaObject.checkType(l, 2, out soldierCount);
			arenaDefendActor.m_luaExportHelper.m_soldierCount = soldierCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD5F RID: 109919 RVA: 0x00805304 File Offset: 0x00803504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendActor.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD60 RID: 109920 RVA: 0x0080535C File Offset: 0x0080355C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaDefendActor.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD61 RID: 109921 RVA: 0x008053B8 File Offset: 0x008035B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendActor.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD62 RID: 109922 RVA: 0x00805410 File Offset: 0x00803610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			ArenaDefendBattle battle;
			LuaObject.checkType<ArenaDefendBattle>(l, 2, out battle);
			arenaDefendActor.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD63 RID: 109923 RVA: 0x0080546C File Offset: 0x0080366C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tweenFromColor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendActor.m_luaExportHelper.m_tweenFromColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD64 RID: 109924 RVA: 0x008054C8 File Offset: 0x008036C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tweenFromColor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			Colori tweenFromColor;
			LuaObject.checkValueType<Colori>(l, 2, out tweenFromColor);
			arenaDefendActor.m_luaExportHelper.m_tweenFromColor = tweenFromColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD65 RID: 109925 RVA: 0x00805524 File Offset: 0x00803724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tweenToColor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendActor.m_luaExportHelper.m_tweenToColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD66 RID: 109926 RVA: 0x00805580 File Offset: 0x00803780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tweenToColor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			Colori tweenToColor;
			LuaObject.checkValueType<Colori>(l, 2, out tweenToColor);
			arenaDefendActor.m_luaExportHelper.m_tweenToColor = tweenToColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD67 RID: 109927 RVA: 0x008055DC File Offset: 0x008037DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tweenColorTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendActor.m_luaExportHelper.m_tweenColorTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD68 RID: 109928 RVA: 0x00805634 File Offset: 0x00803834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tweenColorTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			float tweenColorTime;
			LuaObject.checkType(l, 2, out tweenColorTime);
			arenaDefendActor.m_luaExportHelper.m_tweenColorTime = tweenColorTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD69 RID: 109929 RVA: 0x00805690 File Offset: 0x00803890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphics(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendActor.m_luaExportHelper.m_graphics);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD6A RID: 109930 RVA: 0x008056E8 File Offset: 0x008038E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphics(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendActor arenaDefendActor = (ArenaDefendActor)LuaObject.checkSelf(l);
			GenericGraphic[] graphics;
			LuaObject.checkArray<GenericGraphic>(l, 2, out graphics);
			arenaDefendActor.m_luaExportHelper.m_graphics = graphics;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD6B RID: 109931 RVA: 0x00805744 File Offset: 0x00803944
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaDefendActor");
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.Destroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.SetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.UpdateGraphics);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.GetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.SetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.GetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.GetDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.TweenColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.DestroyGraphics);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.UpdateGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.ComputeGraphicPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.GetGraphicOffset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheE);
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache10, true);
		string name2 = "m_direction";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.get_m_direction);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.set_m_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache12, true);
		string name3 = "m_soldierCount";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.get_m_soldierCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.set_m_soldierCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache14, true);
		string name4 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.get_m_hero);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.set_m_hero);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache16, true);
		string name5 = "m_battle";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.get_m_battle);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.set_m_battle);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache18, true);
		string name6 = "m_tweenFromColor";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.get_m_tweenFromColor);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.set_m_tweenFromColor);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1A, true);
		string name7 = "m_tweenToColor";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.get_m_tweenToColor);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.set_m_tweenToColor);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1C, true);
		string name8 = "m_tweenColorTime";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.get_m_tweenColorTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.set_m_tweenColorTime);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1E, true);
		string name9 = "m_graphics";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.get_m_graphics);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.set_m_graphics);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache20, true);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaDefendActor.<>f__mg$cache21, typeof(ArenaDefendActor));
	}

	// Token: 0x04011051 RID: 69713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011052 RID: 69714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011053 RID: 69715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011054 RID: 69716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011055 RID: 69717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011056 RID: 69718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011057 RID: 69719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011058 RID: 69720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011059 RID: 69721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401105A RID: 69722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401105B RID: 69723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401105C RID: 69724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401105D RID: 69725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401105E RID: 69726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401105F RID: 69727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011060 RID: 69728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011061 RID: 69729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011062 RID: 69730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011063 RID: 69731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011064 RID: 69732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011065 RID: 69733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011066 RID: 69734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011067 RID: 69735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011068 RID: 69736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011069 RID: 69737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401106A RID: 69738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401106B RID: 69739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401106C RID: 69740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401106D RID: 69741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401106E RID: 69742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401106F RID: 69743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011070 RID: 69744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011071 RID: 69745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011072 RID: 69746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
