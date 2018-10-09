using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001323 RID: 4899
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattleActor : LuaObject
{
	// Token: 0x0601A4BE RID: 107710 RVA: 0x007C23CC File Offset: 0x007C05CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor o = new ClientBattleActor();
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

	// Token: 0x0601A4BF RID: 107711 RVA: 0x007C2414 File Offset: 0x007C0614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			ClientBattle battle;
			LuaObject.checkType<ClientBattle>(l, 2, out battle);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 3, out actor);
			clientBattleActor.Initialize(battle, actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4C0 RID: 107712 RVA: 0x007C2478 File Offset: 0x007C0678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitializeEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.InitializeEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4C1 RID: 107713 RVA: 0x007C24C4 File Offset: 0x007C06C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostRebuildBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.PostRebuildBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4C2 RID: 107714 RVA: 0x007C2510 File Offset: 0x007C0710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4C3 RID: 107715 RVA: 0x007C255C File Offset: 0x007C075C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4C4 RID: 107716 RVA: 0x007C25A8 File Offset: 0x007C07A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientBattleActor.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4C5 RID: 107717 RVA: 0x007C2600 File Offset: 0x007C0800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4C6 RID: 107718 RVA: 0x007C264C File Offset: 0x007C084C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientBattleActor.DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4C7 RID: 107719 RVA: 0x007C26A4 File Offset: 0x007C08A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDead(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool b = clientBattleActor.IsDead();
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

	// Token: 0x0601A4C8 RID: 107720 RVA: 0x007C26F8 File Offset: 0x007C08F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int totalHealthPoint = clientBattleActor.GetTotalHealthPoint();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, totalHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4C9 RID: 107721 RVA: 0x007C274C File Offset: 0x007C094C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTotalHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int totalHealthPointMax = clientBattleActor.GetTotalHealthPointMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, totalHealthPointMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4CA RID: 107722 RVA: 0x007C27A0 File Offset: 0x007C09A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Locate(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			clientBattleActor.Locate(p, dir);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4CB RID: 107723 RVA: 0x007C2804 File Offset: 0x007C0A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAct(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			ClientActorAct act;
			LuaObject.checkType<ClientActorAct>(l, 2, out act);
			clientBattleActor.AddAct(act);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4CC RID: 107724 RVA: 0x007C285C File Offset: 0x007C0A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasAct(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool b = clientBattleActor.HasAct();
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

	// Token: 0x0601A4CD RID: 107725 RVA: 0x007C28B0 File Offset: 0x007C0AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAttachFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.ClearAttachFx();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4CE RID: 107726 RVA: 0x007C28FC File Offset: 0x007C0AFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGraphicEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			GraphicEffect e;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out e);
			float param;
			LuaObject.checkType(l, 3, out param);
			float param2;
			LuaObject.checkType(l, 4, out param2);
			clientBattleActor.SetGraphicEffect(e, param, param2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A4CF RID: 107727 RVA: 0x007C2970 File Offset: 0x007C0B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearGraphicEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			GraphicEffect e;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out e);
			clientBattleActor.ClearGraphicEffect(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A4D0 RID: 107728 RVA: 0x007C29C8 File Offset: 0x007C0BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGraphicActionFinishedEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool graphicActionFinishedEffect;
			LuaObject.checkType(l, 2, out graphicActionFinishedEffect);
			clientBattleActor.SetGraphicActionFinishedEffect(graphicActionFinishedEffect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4D1 RID: 107729 RVA: 0x007C2A20 File Offset: 0x007C0C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartIdleRun(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.StartIdleRun();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4D2 RID: 107730 RVA: 0x007C2A6C File Offset: 0x007C0C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopIdleRun(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.StopIdleRun();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4D3 RID: 107731 RVA: 0x007C2AB8 File Offset: 0x007C0CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CancelTeleportDisappear(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.CancelTeleportDisappear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4D4 RID: 107732 RVA: 0x007C2B04 File Offset: 0x007C0D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool visible;
			LuaObject.checkType(l, 2, out visible);
			clientBattleActor.SetVisible(visible);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4D5 RID: 107733 RVA: 0x007C2B5C File Offset: 0x007C0D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool b = clientBattleActor.IsVisible();
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

	// Token: 0x0601A4D6 RID: 107734 RVA: 0x007C2BB0 File Offset: 0x007C0DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoldierGraphicCount(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int soldierGraphicCount = clientBattleActor.GetSoldierGraphicCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierGraphicCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4D7 RID: 107735 RVA: 0x007C2C04 File Offset: 0x007C0E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			GenericGraphic graphic = clientBattleActor.GetGraphic(idx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4D8 RID: 107736 RVA: 0x007C2C68 File Offset: 0x007C0E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGraphicPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			Vector2 graphicPosition = clientBattleActor.GetGraphicPosition();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphicPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4D9 RID: 107737 RVA: 0x007C2CBC File Offset: 0x007C0EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool graphicSkillFade;
			LuaObject.checkType(l, 2, out graphicSkillFade);
			clientBattleActor.SetGraphicSkillFade(graphicSkillFade);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4DA RID: 107738 RVA: 0x007C2D14 File Offset: 0x007C0F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool b = clientBattleActor.IsGraphicSkillFade();
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

	// Token: 0x0601A4DB RID: 107739 RVA: 0x007C2D68 File Offset: 0x007C0F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			clientBattleActor.ShowPlayerIndex(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4DC RID: 107740 RVA: 0x007C2DC0 File Offset: 0x007C0FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeGraphicOffset_s(IntPtr l)
	{
		int result;
		try
		{
			int idx;
			LuaObject.checkType(l, 1, out idx);
			int dir;
			LuaObject.checkType(l, 2, out dir);
			int soldierCount;
			LuaObject.checkType(l, 3, out soldierCount);
			bool hasHeroAndSoldier;
			LuaObject.checkType(l, 4, out hasHeroAndSoldier);
			Vector2 o = ClientBattleActor.ComputeGraphicOffset(idx, dir, soldierCount, hasHeroAndSoldier);
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

	// Token: 0x0601A4DD RID: 107741 RVA: 0x007C2E3C File Offset: 0x007C103C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.m_luaExportHelper.CreateHeroGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4DE RID: 107742 RVA: 0x007C2E90 File Offset: 0x007C1090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSoldierGraphics(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.m_luaExportHelper.CreateSoldierGraphics();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4DF RID: 107743 RVA: 0x007C2EE4 File Offset: 0x007C10E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeGraphicPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			float zoffset;
			LuaObject.checkType(l, 3, out zoffset);
			Vector3 o = clientBattleActor.m_luaExportHelper.ComputeGraphicPosition(p, zoffset);
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

	// Token: 0x0601A4E0 RID: 107744 RVA: 0x007C2F58 File Offset: 0x007C1158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasFightTag(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			FightTag ft;
			LuaObject.checkEnum<FightTag>(l, 2, out ft);
			bool b = clientBattleActor.m_luaExportHelper.HasFightTag(ft);
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

	// Token: 0x0601A4E1 RID: 107745 RVA: 0x007C2FC0 File Offset: 0x007C11C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FaceTo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			clientBattleActor.m_luaExportHelper.FaceTo(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4E2 RID: 107746 RVA: 0x007C301C File Offset: 0x007C121C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			bool onAll;
			LuaObject.checkType(l, 4, out onAll);
			clientBattleActor.m_luaExportHelper.PlayAnimation(name, loop, onAll);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4E3 RID: 107747 RVA: 0x007C3094 File Offset: 0x007C1294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroAnimationDuration(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int heroAnimationDuration = clientBattleActor.m_luaExportHelper.GetHeroAnimationDuration(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAnimationDuration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4E4 RID: 107748 RVA: 0x007C30FC File Offset: 0x007C12FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsHeroPlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool b = clientBattleActor.m_luaExportHelper.IsHeroPlayAnimation();
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

	// Token: 0x0601A4E5 RID: 107749 RVA: 0x007C3158 File Offset: 0x007C1358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayDeathFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int deathType;
			LuaObject.checkType(l, 2, out deathType);
			clientBattleActor.m_luaExportHelper.PlayDeathFx(deathType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4E6 RID: 107750 RVA: 0x007C31B4 File Offset: 0x007C13B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayIdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.m_luaExportHelper.PlayIdleAnimation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4E7 RID: 107751 RVA: 0x007C3208 File Offset: 0x007C1408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayHeroFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			clientBattleActor.m_luaExportHelper.PlayHeroFx(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4E8 RID: 107752 RVA: 0x007C3264 File Offset: 0x007C1464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			clientBattleActor.m_luaExportHelper.PlayFx(name, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4E9 RID: 107753 RVA: 0x007C32D0 File Offset: 0x007C14D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAttachFx(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			clientBattleActor.m_luaExportHelper.PlayAttachFx(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4EA RID: 107754 RVA: 0x007C332C File Offset: 0x007C152C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySound(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				clientBattleActor.m_luaExportHelper.PlaySound(name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(SoundTableId)))
			{
				ClientBattleActor clientBattleActor2 = (ClientBattleActor)LuaObject.checkSelf(l);
				SoundTableId id;
				LuaObject.checkEnum<SoundTableId>(l, 2, out id);
				clientBattleActor2.m_luaExportHelper.PlaySound(id);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PlaySound to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4EB RID: 107755 RVA: 0x007C340C File Offset: 0x007C160C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGraphicColor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			Colori graphicColor;
			LuaObject.checkValueType<Colori>(l, 2, out graphicColor);
			clientBattleActor.m_luaExportHelper.SetGraphicColor(graphicColor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4EC RID: 107756 RVA: 0x007C3468 File Offset: 0x007C1668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttachBuff(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 2, out buffState);
			clientBattleActor.m_luaExportHelper.AttachBuff(buffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4ED RID: 107757 RVA: 0x007C34C4 File Offset: 0x007C16C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DetachBuff(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 2, out buffState);
			clientBattleActor.m_luaExportHelper.DetachBuff(buffState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4EE RID: 107758 RVA: 0x007C3520 File Offset: 0x007C1720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHpBarType(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			bool isAINpcOrTeamMate;
			LuaObject.checkType(l, 3, out isAINpcOrTeamMate);
			clientBattleActor.m_luaExportHelper.SetHpBarType(team, isAINpcOrTeamMate);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4EF RID: 107759 RVA: 0x007C358C File Offset: 0x007C178C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSoldierGraphicCount(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int i = clientBattleActor.m_luaExportHelper.ComputeSoldierGraphicCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4F0 RID: 107760 RVA: 0x007C35E8 File Offset: 0x007C17E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateSoldierGraphicCount(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.m_luaExportHelper.UpdateSoldierGraphicCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4F1 RID: 107761 RVA: 0x007C363C File Offset: 0x007C183C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGraphicVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.m_luaExportHelper.UpdateGraphicVisible();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4F2 RID: 107762 RVA: 0x007C3690 File Offset: 0x007C1890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeGraphicOffset(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			Vector2 o = clientBattleActor.m_luaExportHelper.ComputeGraphicOffset(idx);
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

	// Token: 0x0601A4F3 RID: 107763 RVA: 0x007C36F8 File Offset: 0x007C18F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHpAndBuffUI(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.m_luaExportHelper.UpdateHpAndBuffUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4F4 RID: 107764 RVA: 0x007C374C File Offset: 0x007C194C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickAct(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ClientActorAct)))
			{
				ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorAct act;
				LuaObject.checkType<ClientActorAct>(l, 2, out act);
				bool b = clientBattleActor.m_luaExportHelper.TickAct(act);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActActive)))
			{
				ClientBattleActor clientBattleActor2 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActActive act2;
				LuaObject.checkType<ClientActorActActive>(l, 2, out act2);
				bool b2 = clientBattleActor2.m_luaExportHelper.TickAct(act2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActActionBegin)))
			{
				ClientBattleActor clientBattleActor3 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActActionBegin act3;
				LuaObject.checkType<ClientActorActActionBegin>(l, 2, out act3);
				bool b3 = clientBattleActor3.m_luaExportHelper.TickAct(act3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActActionEnd)))
			{
				ClientBattleActor clientBattleActor4 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActActionEnd act4;
				LuaObject.checkType<ClientActorActActionEnd>(l, 2, out act4);
				bool b4 = clientBattleActor4.m_luaExportHelper.TickAct(act4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b4);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActMove)))
			{
				ClientBattleActor clientBattleActor5 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActMove act5;
				LuaObject.checkType<ClientActorActMove>(l, 2, out act5);
				bool b5 = clientBattleActor5.m_luaExportHelper.TickAct(act5);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b5);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActTryMove)))
			{
				ClientBattleActor clientBattleActor6 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActTryMove act6;
				LuaObject.checkType<ClientActorActTryMove>(l, 2, out act6);
				bool b6 = clientBattleActor6.m_luaExportHelper.TickAct(act6);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b6);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActPerformMove)))
			{
				ClientBattleActor clientBattleActor7 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActPerformMove act7;
				LuaObject.checkType<ClientActorActPerformMove>(l, 2, out act7);
				bool b7 = clientBattleActor7.m_luaExportHelper.TickAct(act7);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b7);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActPunchMove)))
			{
				ClientBattleActor clientBattleActor8 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActPunchMove act8;
				LuaObject.checkType<ClientActorActPunchMove>(l, 2, out act8);
				bool b8 = clientBattleActor8.m_luaExportHelper.TickAct(act8);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b8);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActExchangeMove)))
			{
				ClientBattleActor clientBattleActor9 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActExchangeMove act9;
				LuaObject.checkType<ClientActorActExchangeMove>(l, 2, out act9);
				bool b9 = clientBattleActor9.m_luaExportHelper.TickAct(act9);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b9);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActSetDir)))
			{
				ClientBattleActor clientBattleActor10 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActSetDir act10;
				LuaObject.checkType<ClientActorActSetDir>(l, 2, out act10);
				bool b10 = clientBattleActor10.m_luaExportHelper.TickAct(act10);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b10);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActPlayFx)))
			{
				ClientBattleActor clientBattleActor11 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActPlayFx act11;
				LuaObject.checkType<ClientActorActPlayFx>(l, 2, out act11);
				bool b11 = clientBattleActor11.m_luaExportHelper.TickAct(act11);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b11);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActPlayAnimation)))
			{
				ClientBattleActor clientBattleActor12 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActPlayAnimation act12;
				LuaObject.checkType<ClientActorActPlayAnimation>(l, 2, out act12);
				bool b12 = clientBattleActor12.m_luaExportHelper.TickAct(act12);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b12);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActChangeIdleAnimation)))
			{
				ClientBattleActor clientBattleActor13 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActChangeIdleAnimation act13;
				LuaObject.checkType<ClientActorActChangeIdleAnimation>(l, 2, out act13);
				bool b13 = clientBattleActor13.m_luaExportHelper.TickAct(act13);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b13);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActTarget)))
			{
				ClientBattleActor clientBattleActor14 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActTarget act14;
				LuaObject.checkType<ClientActorActTarget>(l, 2, out act14);
				bool b14 = clientBattleActor14.m_luaExportHelper.TickAct(act14);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b14);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActSkill)))
			{
				ClientBattleActor clientBattleActor15 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActSkill act15;
				LuaObject.checkType<ClientActorActSkill>(l, 2, out act15);
				bool b15 = clientBattleActor15.m_luaExportHelper.TickAct(act15);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b15);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActSkillHit)))
			{
				ClientBattleActor clientBattleActor16 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActSkillHit act16;
				LuaObject.checkType<ClientActorActSkillHit>(l, 2, out act16);
				bool b16 = clientBattleActor16.m_luaExportHelper.TickAct(act16);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b16);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActAttachBuff)))
			{
				ClientBattleActor clientBattleActor17 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActAttachBuff act17;
				LuaObject.checkType<ClientActorActAttachBuff>(l, 2, out act17);
				bool b17 = clientBattleActor17.m_luaExportHelper.TickAct(act17);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b17);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActDetachBuff)))
			{
				ClientBattleActor clientBattleActor18 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActDetachBuff act18;
				LuaObject.checkType<ClientActorActDetachBuff>(l, 2, out act18);
				bool b18 = clientBattleActor18.m_luaExportHelper.TickAct(act18);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b18);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActImmune)))
			{
				ClientBattleActor clientBattleActor19 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActImmune act19;
				LuaObject.checkType<ClientActorActImmune>(l, 2, out act19);
				bool b19 = clientBattleActor19.m_luaExportHelper.TickAct(act19);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b19);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActPassiveSkill)))
			{
				ClientBattleActor clientBattleActor20 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActPassiveSkill act20;
				LuaObject.checkType<ClientActorActPassiveSkill>(l, 2, out act20);
				bool b20 = clientBattleActor20.m_luaExportHelper.TickAct(act20);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b20);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActPassiveSkillHit)))
			{
				ClientBattleActor clientBattleActor21 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActPassiveSkillHit act21;
				LuaObject.checkType<ClientActorActPassiveSkillHit>(l, 2, out act21);
				bool b21 = clientBattleActor21.m_luaExportHelper.TickAct(act21);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b21);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActBuffHit)))
			{
				ClientBattleActor clientBattleActor22 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActBuffHit act22;
				LuaObject.checkType<ClientActorActBuffHit>(l, 2, out act22);
				bool b22 = clientBattleActor22.m_luaExportHelper.TickAct(act22);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b22);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActTerrainHit)))
			{
				ClientBattleActor clientBattleActor23 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActTerrainHit act23;
				LuaObject.checkType<ClientActorActTerrainHit>(l, 2, out act23);
				bool b23 = clientBattleActor23.m_luaExportHelper.TickAct(act23);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b23);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActTeleportDisappear)))
			{
				ClientBattleActor clientBattleActor24 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActTeleportDisappear act24;
				LuaObject.checkType<ClientActorActTeleportDisappear>(l, 2, out act24);
				bool b24 = clientBattleActor24.m_luaExportHelper.TickAct(act24);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b24);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActTeleportAppear)))
			{
				ClientBattleActor clientBattleActor25 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActTeleportAppear act25;
				LuaObject.checkType<ClientActorActTeleportAppear>(l, 2, out act25);
				bool b25 = clientBattleActor25.m_luaExportHelper.TickAct(act25);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b25);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActSummon)))
			{
				ClientBattleActor clientBattleActor26 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActSummon act26;
				LuaObject.checkType<ClientActorActSummon>(l, 2, out act26);
				bool b26 = clientBattleActor26.m_luaExportHelper.TickAct(act26);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b26);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActDie)))
			{
				ClientBattleActor clientBattleActor27 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActDie act27;
				LuaObject.checkType<ClientActorActDie>(l, 2, out act27);
				bool b27 = clientBattleActor27.m_luaExportHelper.TickAct(act27);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b27);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActAppear)))
			{
				ClientBattleActor clientBattleActor28 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActAppear act28;
				LuaObject.checkType<ClientActorActAppear>(l, 2, out act28);
				bool b28 = clientBattleActor28.m_luaExportHelper.TickAct(act28);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b28);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActDisappear)))
			{
				ClientBattleActor clientBattleActor29 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActDisappear act29;
				LuaObject.checkType<ClientActorActDisappear>(l, 2, out act29);
				bool b29 = clientBattleActor29.m_luaExportHelper.TickAct(act29);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b29);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActChangeTeam)))
			{
				ClientBattleActor clientBattleActor30 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActChangeTeam act30;
				LuaObject.checkType<ClientActorActChangeTeam>(l, 2, out act30);
				bool b30 = clientBattleActor30.m_luaExportHelper.TickAct(act30);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b30);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActChangeArmy)))
			{
				ClientBattleActor clientBattleActor31 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActChangeArmy act31;
				LuaObject.checkType<ClientActorActChangeArmy>(l, 2, out act31);
				bool b31 = clientBattleActor31.m_luaExportHelper.TickAct(act31);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b31);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActReplace)))
			{
				ClientBattleActor clientBattleActor32 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActReplace act32;
				LuaObject.checkType<ClientActorActReplace>(l, 2, out act32);
				bool b32 = clientBattleActor32.m_luaExportHelper.TickAct(act32);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b32);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActCameraFocus)))
			{
				ClientBattleActor clientBattleActor33 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActCameraFocus act33;
				LuaObject.checkType<ClientActorActCameraFocus>(l, 2, out act33);
				bool b33 = clientBattleActor33.m_luaExportHelper.TickAct(act33);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b33);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActGainBattleTreasure)))
			{
				ClientBattleActor clientBattleActor34 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActGainBattleTreasure act34;
				LuaObject.checkType<ClientActorActGainBattleTreasure>(l, 2, out act34);
				bool b34 = clientBattleActor34.m_luaExportHelper.TickAct(act34);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b34);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActStartGuard)))
			{
				ClientBattleActor clientBattleActor35 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActStartGuard act35;
				LuaObject.checkType<ClientActorActStartGuard>(l, 2, out act35);
				bool b35 = clientBattleActor35.m_luaExportHelper.TickAct(act35);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b35);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActStopGuard)))
			{
				ClientBattleActor clientBattleActor36 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActStopGuard act36;
				LuaObject.checkType<ClientActorActStopGuard>(l, 2, out act36);
				bool b36 = clientBattleActor36.m_luaExportHelper.TickAct(act36);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b36);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActBeforeStartCombat)))
			{
				ClientBattleActor clientBattleActor37 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActBeforeStartCombat act37;
				LuaObject.checkType<ClientActorActBeforeStartCombat>(l, 2, out act37);
				bool b37 = clientBattleActor37.m_luaExportHelper.TickAct(act37);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b37);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActCancelCombat)))
			{
				ClientBattleActor clientBattleActor38 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActCancelCombat act38;
				LuaObject.checkType<ClientNullActorActCancelCombat>(l, 2, out act38);
				bool b38 = clientBattleActor38.m_luaExportHelper.TickAct(act38);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b38);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActStartCombat)))
			{
				ClientBattleActor clientBattleActor39 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActStartCombat act39;
				LuaObject.checkType<ClientActorActStartCombat>(l, 2, out act39);
				bool b39 = clientBattleActor39.m_luaExportHelper.TickAct(act39);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b39);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientActorActStopCombat)))
			{
				ClientBattleActor clientBattleActor40 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientActorActStopCombat act40;
				LuaObject.checkType<ClientActorActStopCombat>(l, 2, out act40);
				bool b40 = clientBattleActor40.m_luaExportHelper.TickAct(act40);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b40);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActStartBattle)))
			{
				ClientBattleActor clientBattleActor41 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActStartBattle act41;
				LuaObject.checkType<ClientNullActorActStartBattle>(l, 2, out act41);
				bool b41 = clientBattleActor41.m_luaExportHelper.TickAct(act41);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b41);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActBattleWinCondition)))
			{
				ClientBattleActor clientBattleActor42 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActBattleWinCondition act42;
				LuaObject.checkType<ClientNullActorActBattleWinCondition>(l, 2, out act42);
				bool b42 = clientBattleActor42.m_luaExportHelper.TickAct(act42);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b42);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActBattleLoseCondition)))
			{
				ClientBattleActor clientBattleActor43 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActBattleLoseCondition act43;
				LuaObject.checkType<ClientNullActorActBattleLoseCondition>(l, 2, out act43);
				bool b43 = clientBattleActor43.m_luaExportHelper.TickAct(act43);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b43);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActNextTurn)))
			{
				ClientBattleActor clientBattleActor44 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActNextTurn act44;
				LuaObject.checkType<ClientNullActorActNextTurn>(l, 2, out act44);
				bool b44 = clientBattleActor44.m_luaExportHelper.TickAct(act44);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b44);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActNextTeam)))
			{
				ClientBattleActor clientBattleActor45 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActNextTeam act45;
				LuaObject.checkType<ClientNullActorActNextTeam>(l, 2, out act45);
				bool b45 = clientBattleActor45.m_luaExportHelper.TickAct(act45);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b45);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActNextPlayer)))
			{
				ClientBattleActor clientBattleActor46 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActNextPlayer act46;
				LuaObject.checkType<ClientNullActorActNextPlayer>(l, 2, out act46);
				bool b46 = clientBattleActor46.m_luaExportHelper.TickAct(act46);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b46);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActNextActor)))
			{
				ClientBattleActor clientBattleActor47 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActNextActor act47;
				LuaObject.checkType<ClientNullActorActNextActor>(l, 2, out act47);
				bool b47 = clientBattleActor47.m_luaExportHelper.TickAct(act47);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b47);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActFastCombat)))
			{
				ClientBattleActor clientBattleActor48 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActFastCombat act48;
				LuaObject.checkType<ClientNullActorActFastCombat>(l, 2, out act48);
				bool b48 = clientBattleActor48.m_luaExportHelper.TickAct(act48);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b48);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActBattleDialog)))
			{
				ClientBattleActor clientBattleActor49 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActBattleDialog act49;
				LuaObject.checkType<ClientNullActorActBattleDialog>(l, 2, out act49);
				bool b49 = clientBattleActor49.m_luaExportHelper.TickAct(act49);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b49);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActStartBattlePerform)))
			{
				ClientBattleActor clientBattleActor50 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActStartBattlePerform act50;
				LuaObject.checkType<ClientNullActorActStartBattlePerform>(l, 2, out act50);
				bool b50 = clientBattleActor50.m_luaExportHelper.TickAct(act50);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b50);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActStopBattlePerform)))
			{
				ClientBattleActor clientBattleActor51 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActStopBattlePerform act51;
				LuaObject.checkType<ClientNullActorActStopBattlePerform>(l, 2, out act51);
				bool b51 = clientBattleActor51.m_luaExportHelper.TickAct(act51);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b51);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActChangeMapTerrain)))
			{
				ClientBattleActor clientBattleActor52 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActChangeMapTerrain act52;
				LuaObject.checkType<ClientNullActorActChangeMapTerrain>(l, 2, out act52);
				bool b52 = clientBattleActor52.m_luaExportHelper.TickAct(act52);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b52);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActCameraFocus)))
			{
				ClientBattleActor clientBattleActor53 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActCameraFocus act53;
				LuaObject.checkType<ClientNullActorActCameraFocus>(l, 2, out act53);
				bool b53 = clientBattleActor53.m_luaExportHelper.TickAct(act53);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b53);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActPlayMusic)))
			{
				ClientBattleActor clientBattleActor54 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActPlayMusic act54;
				LuaObject.checkType<ClientNullActorActPlayMusic>(l, 2, out act54);
				bool b54 = clientBattleActor54.m_luaExportHelper.TickAct(act54);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b54);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActPlaySound)))
			{
				ClientBattleActor clientBattleActor55 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActPlaySound act55;
				LuaObject.checkType<ClientNullActorActPlaySound>(l, 2, out act55);
				bool b55 = clientBattleActor55.m_luaExportHelper.TickAct(act55);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b55);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActPlayFx)))
			{
				ClientBattleActor clientBattleActor56 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActPlayFx act56;
				LuaObject.checkType<ClientNullActorActPlayFx>(l, 2, out act56);
				bool b56 = clientBattleActor56.m_luaExportHelper.TickAct(act56);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b56);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ClientNullActorActWaitTime)))
			{
				ClientBattleActor clientBattleActor57 = (ClientBattleActor)LuaObject.checkSelf(l);
				ClientNullActorActWaitTime act57;
				LuaObject.checkType<ClientNullActorActWaitTime>(l, 2, out act57);
				bool b57 = clientBattleActor57.m_luaExportHelper.TickAct(act57);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b57);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function TickAct to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4F5 RID: 107765 RVA: 0x007C4A94 File Offset: 0x007C2C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitMoveAct(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 2, out pos);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			bool sound;
			LuaObject.checkType(l, 4, out sound);
			bool endDelay;
			LuaObject.checkType(l, 5, out endDelay);
			clientBattleActor.m_luaExportHelper.InitMoveAct(pos, dir, sound, endDelay);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4F6 RID: 107766 RVA: 0x007C4B18 File Offset: 0x007C2D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeMoveTime(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			GridPosition p2;
			LuaObject.checkValueType<GridPosition>(l, 3, out p2);
			int i = clientBattleActor.m_luaExportHelper.ComputeMoveTime(p, p2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4F7 RID: 107767 RVA: 0x007C4B8C File Offset: 0x007C2D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickSkillHits(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			List<ClientActorHitInfo> hits;
			LuaObject.checkType<List<ClientActorHitInfo>>(l, 3, out hits);
			bool b = clientBattleActor.m_luaExportHelper.TickSkillHits(skillInfo, hits);
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

	// Token: 0x0601A4F8 RID: 107768 RVA: 0x007C4C00 File Offset: 0x007C2E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.m_luaExportHelper.__callBase_Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4F9 RID: 107769 RVA: 0x007C4C54 File Offset: 0x007C2E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.m_luaExportHelper.__callBase_Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4FA RID: 107770 RVA: 0x007C4CA8 File Offset: 0x007C2EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientBattleActor.m_luaExportHelper.__callBase_TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4FB RID: 107771 RVA: 0x007C4D04 File Offset: 0x007C2F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.m_luaExportHelper.__callBase_Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4FC RID: 107772 RVA: 0x007C4D58 File Offset: 0x007C2F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientBattleActor.m_luaExportHelper.__callBase_Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4FD RID: 107773 RVA: 0x007C4DB4 File Offset: 0x007C2FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientBattleActor.m_luaExportHelper.__callBase_DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4FE RID: 107774 RVA: 0x007C4E10 File Offset: 0x007C3010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			clientBattleActor.m_luaExportHelper.__callBase_DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4FF RID: 107775 RVA: 0x007C4E64 File Offset: 0x007C3064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareBuffDisplayOrder_s(IntPtr l)
	{
		int result;
		try
		{
			ClientActorBuff b;
			LuaObject.checkType<ClientActorBuff>(l, 1, out b);
			ClientActorBuff b2;
			LuaObject.checkType<ClientActorBuff>(l, 2, out b2);
			int i = ClientBattleActor.LuaExportHelper.CompareBuffDisplayOrder(b, b2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A500 RID: 107776 RVA: 0x007C4EC4 File Offset: 0x007C30C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSkillCastTime_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 1, out skillInfo);
			int i = ClientBattleActor.LuaExportHelper.ComputeSkillCastTime(skillInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A501 RID: 107777 RVA: 0x007C4F18 File Offset: 0x007C3118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSkillHitTime_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 1, out skillInfo);
			List<ClientActorHitInfo> hits;
			LuaObject.checkType<List<ClientActorHitInfo>>(l, 2, out hits);
			int i = ClientBattleActor.LuaExportHelper.ComputeSkillHitTime(skillInfo, hits);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A502 RID: 107778 RVA: 0x007C4F78 File Offset: 0x007C3178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_clientBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A503 RID: 107779 RVA: 0x007C4FD0 File Offset: 0x007C31D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			clientBattleActor.m_luaExportHelper.m_clientBattle = clientBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A504 RID: 107780 RVA: 0x007C502C File Offset: 0x007C322C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_battleActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A505 RID: 107781 RVA: 0x007C5084 File Offset: 0x007C3284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			BattleActor battleActor;
			LuaObject.checkType<BattleActor>(l, 2, out battleActor);
			clientBattleActor.m_luaExportHelper.m_battleActor = battleActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A506 RID: 107782 RVA: 0x007C50E0 File Offset: 0x007C32E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_heroHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A507 RID: 107783 RVA: 0x007C5138 File Offset: 0x007C3338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int heroHealthPoint;
			LuaObject.checkType(l, 2, out heroHealthPoint);
			clientBattleActor.m_luaExportHelper.m_heroHealthPoint = heroHealthPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A508 RID: 107784 RVA: 0x007C5194 File Offset: 0x007C3394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_soldierTotalHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A509 RID: 107785 RVA: 0x007C51EC File Offset: 0x007C33EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int soldierTotalHealthPoint;
			LuaObject.checkType(l, 2, out soldierTotalHealthPoint);
			clientBattleActor.m_luaExportHelper.m_soldierTotalHealthPoint = soldierTotalHealthPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A50A RID: 107786 RVA: 0x007C5248 File Offset: 0x007C3448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_heroHealthPointMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A50B RID: 107787 RVA: 0x007C52A0 File Offset: 0x007C34A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int heroHealthPointMax;
			LuaObject.checkType(l, 2, out heroHealthPointMax);
			clientBattleActor.m_luaExportHelper.m_heroHealthPointMax = heroHealthPointMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A50C RID: 107788 RVA: 0x007C52FC File Offset: 0x007C34FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierTotalHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_soldierTotalHealthPointMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A50D RID: 107789 RVA: 0x007C5354 File Offset: 0x007C3554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierTotalHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int soldierTotalHealthPointMax;
			LuaObject.checkType(l, 2, out soldierTotalHealthPointMax);
			clientBattleActor.m_luaExportHelper.m_soldierTotalHealthPointMax = soldierTotalHealthPointMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A50E RID: 107790 RVA: 0x007C53B0 File Offset: 0x007C35B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fightTags(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_fightTags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A50F RID: 107791 RVA: 0x007C5408 File Offset: 0x007C3608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fightTags(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			uint fightTags;
			LuaObject.checkType(l, 2, out fightTags);
			clientBattleActor.m_luaExportHelper.m_fightTags = fightTags;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A510 RID: 107792 RVA: 0x007C5464 File Offset: 0x007C3664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicStates(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_graphicStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A511 RID: 107793 RVA: 0x007C54BC File Offset: 0x007C36BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicStates(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			ClientBattleActor.GraphicState[] graphicStates;
			LuaObject.checkArray<ClientBattleActor.GraphicState>(l, 2, out graphicStates);
			clientBattleActor.m_luaExportHelper.m_graphicStates = graphicStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A512 RID: 107794 RVA: 0x007C5518 File Offset: 0x007C3718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphicCount(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_soldierGraphicCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A513 RID: 107795 RVA: 0x007C5570 File Offset: 0x007C3770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphicCount(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int soldierGraphicCount;
			LuaObject.checkType(l, 2, out soldierGraphicCount);
			clientBattleActor.m_luaExportHelper.m_soldierGraphicCount = soldierGraphicCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A514 RID: 107796 RVA: 0x007C55CC File Offset: 0x007C37CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_graphicPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A515 RID: 107797 RVA: 0x007C5624 File Offset: 0x007C3824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			Vector2 graphicPosition;
			LuaObject.checkType(l, 2, out graphicPosition);
			clientBattleActor.m_luaExportHelper.m_graphicPosition = graphicPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A516 RID: 107798 RVA: 0x007C5680 File Offset: 0x007C3880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_isGraphicSkillFade);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A517 RID: 107799 RVA: 0x007C56D8 File Offset: 0x007C38D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool isGraphicSkillFade;
			LuaObject.checkType(l, 2, out isGraphicSkillFade);
			clientBattleActor.m_luaExportHelper.m_isGraphicSkillFade = isGraphicSkillFade;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A518 RID: 107800 RVA: 0x007C5734 File Offset: 0x007C3934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isActionFinishedGray(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_isActionFinishedGray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A519 RID: 107801 RVA: 0x007C578C File Offset: 0x007C398C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isActionFinishedGray(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool isActionFinishedGray;
			LuaObject.checkType(l, 2, out isActionFinishedGray);
			clientBattleActor.m_luaExportHelper.m_isActionFinishedGray = isActionFinishedGray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A51A RID: 107802 RVA: 0x007C57E8 File Offset: 0x007C39E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiController(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_uiController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A51B RID: 107803 RVA: 0x007C5840 File Offset: 0x007C3A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiController(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			BattleActorUIController uiController;
			LuaObject.checkType<BattleActorUIController>(l, 2, out uiController);
			clientBattleActor.m_luaExportHelper.m_uiController = uiController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A51C RID: 107804 RVA: 0x007C589C File Offset: 0x007C3A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffs(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_buffs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A51D RID: 107805 RVA: 0x007C58F4 File Offset: 0x007C3AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffs(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			List<ClientActorBuff> buffs;
			LuaObject.checkType<List<ClientActorBuff>>(l, 2, out buffs);
			clientBattleActor.m_luaExportHelper.m_buffs = buffs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A51E RID: 107806 RVA: 0x007C5950 File Offset: 0x007C3B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attachFxs(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_attachFxs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A51F RID: 107807 RVA: 0x007C59A8 File Offset: 0x007C3BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attachFxs(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			List<GenericGraphic> attachFxs;
			LuaObject.checkType<List<GenericGraphic>>(l, 2, out attachFxs);
			clientBattleActor.m_luaExportHelper.m_attachFxs = attachFxs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A520 RID: 107808 RVA: 0x007C5A04 File Offset: 0x007C3C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A521 RID: 107809 RVA: 0x007C5A60 File Offset: 0x007C3C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientBattleActor.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A522 RID: 107810 RVA: 0x007C5ABC File Offset: 0x007C3CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A523 RID: 107811 RVA: 0x007C5B14 File Offset: 0x007C3D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientBattleActor.m_luaExportHelper.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A524 RID: 107812 RVA: 0x007C5B70 File Offset: 0x007C3D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_isVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A525 RID: 107813 RVA: 0x007C5BC8 File Offset: 0x007C3DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool isVisible;
			LuaObject.checkType(l, 2, out isVisible);
			clientBattleActor.m_luaExportHelper.m_isVisible = isVisible;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A526 RID: 107814 RVA: 0x007C5C24 File Offset: 0x007C3E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isIdleRun(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_isIdleRun);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A527 RID: 107815 RVA: 0x007C5C7C File Offset: 0x007C3E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isIdleRun(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool isIdleRun;
			LuaObject.checkType(l, 2, out isIdleRun);
			clientBattleActor.m_luaExportHelper.m_isIdleRun = isIdleRun;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A528 RID: 107816 RVA: 0x007C5CD8 File Offset: 0x007C3ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGuarding(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_isGuarding);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A529 RID: 107817 RVA: 0x007C5D30 File Offset: 0x007C3F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isGuarding(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool isGuarding;
			LuaObject.checkType(l, 2, out isGuarding);
			clientBattleActor.m_luaExportHelper.m_isGuarding = isGuarding;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A52A RID: 107818 RVA: 0x007C5D8C File Offset: 0x007C3F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isTeleportDisappear(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_isTeleportDisappear);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A52B RID: 107819 RVA: 0x007C5DE4 File Offset: 0x007C3FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isTeleportDisappear(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			bool isTeleportDisappear;
			LuaObject.checkType(l, 2, out isTeleportDisappear);
			clientBattleActor.m_luaExportHelper.m_isTeleportDisappear = isTeleportDisappear;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A52C RID: 107820 RVA: 0x007C5E40 File Offset: 0x007C4040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_idleAnimationName(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_idleAnimationName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A52D RID: 107821 RVA: 0x007C5E98 File Offset: 0x007C4098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_idleAnimationName(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			string idleAnimationName;
			LuaObject.checkType(l, 2, out idleAnimationName);
			clientBattleActor.m_luaExportHelper.m_idleAnimationName = idleAnimationName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A52E RID: 107822 RVA: 0x007C5EF4 File Offset: 0x007C40F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_acts(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_acts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A52F RID: 107823 RVA: 0x007C5F4C File Offset: 0x007C414C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_acts(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			List<ClientActorAct> acts;
			LuaObject.checkType<List<ClientActorAct>>(l, 2, out acts);
			clientBattleActor.m_luaExportHelper.m_acts = acts;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A530 RID: 107824 RVA: 0x007C5FA8 File Offset: 0x007C41A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actFrame(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_actFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A531 RID: 107825 RVA: 0x007C6000 File Offset: 0x007C4200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actFrame(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int actFrame;
			LuaObject.checkType(l, 2, out actFrame);
			clientBattleActor.m_luaExportHelper.m_actFrame = actFrame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A532 RID: 107826 RVA: 0x007C605C File Offset: 0x007C425C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempActFrame(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_tempActFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A533 RID: 107827 RVA: 0x007C60B4 File Offset: 0x007C42B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempActFrame(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int tempActFrame;
			LuaObject.checkType(l, 2, out tempActFrame);
			clientBattleActor.m_luaExportHelper.m_tempActFrame = tempActFrame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A534 RID: 107828 RVA: 0x007C6110 File Offset: 0x007C4310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_deleteMeCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.m_luaExportHelper.m_deleteMeCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A535 RID: 107829 RVA: 0x007C6168 File Offset: 0x007C4368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_deleteMeCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			int deleteMeCountdown;
			LuaObject.checkType(l, 2, out deleteMeCountdown);
			clientBattleActor.m_luaExportHelper.m_deleteMeCountdown = deleteMeCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A536 RID: 107830 RVA: 0x007C61C4 File Offset: 0x007C43C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A537 RID: 107831 RVA: 0x007C621C File Offset: 0x007C441C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Direction(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.Direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A538 RID: 107832 RVA: 0x007C6270 File Offset: 0x007C4470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleActor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.BattleActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A539 RID: 107833 RVA: 0x007C62C4 File Offset: 0x007C44C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamNumber(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.TeamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A53A RID: 107834 RVA: 0x007C6318 File Offset: 0x007C4518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.HeroHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A53B RID: 107835 RVA: 0x007C636C File Offset: 0x007C456C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor clientBattleActor = (ClientBattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleActor.SoldierTotalHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A53C RID: 107836 RVA: 0x007C63C0 File Offset: 0x007C45C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattleActor");
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.InitializeEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.PostRebuildBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.IsDead);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.GetTotalHealthPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.GetTotalHealthPointMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.Locate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.AddAct);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.HasAct);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.ClearAttachFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.SetGraphicEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.ClearGraphicEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.SetGraphicActionFinishedEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.StartIdleRun);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.StopIdleRun);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.CancelTeleportDisappear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.SetVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.IsVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.GetSoldierGraphicCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.GetGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.GetGraphicPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.SetGraphicSkillFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.IsGraphicSkillFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.ShowPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.ComputeGraphicOffset_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.CreateHeroGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.CreateSoldierGraphics);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.ComputeGraphicPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.HasFightTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.FaceTo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.GetHeroAnimationDuration);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.IsHeroPlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.PlayDeathFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.PlayIdleAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.PlayHeroFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.PlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.PlayAttachFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.PlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.SetGraphicColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.AttachBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.DetachBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.SetHpBarType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.ComputeSoldierGraphicCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.UpdateSoldierGraphicCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.UpdateGraphicVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.ComputeGraphicOffset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.UpdateHpAndBuffUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.TickAct);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.InitMoveAct);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.ComputeMoveTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.TickSkillHits);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.__callBase_Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.__callBase_TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.__callBase_Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.__callBase_DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.__callBase_DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.CompareBuffDisplayOrder_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.ComputeSkillCastTime_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.ComputeSkillHitTime_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache42);
		string name = "m_clientBattle";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_clientBattle);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_clientBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache44, true);
		string name2 = "m_battleActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_battleActor);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_battleActor);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache46, true);
		string name3 = "m_heroHealthPoint";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_heroHealthPoint);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_heroHealthPoint);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache48, true);
		string name4 = "m_soldierTotalHealthPoint";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_soldierTotalHealthPoint);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_soldierTotalHealthPoint);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4A, true);
		string name5 = "m_heroHealthPointMax";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_heroHealthPointMax);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_heroHealthPointMax);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4C, true);
		string name6 = "m_soldierTotalHealthPointMax";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_soldierTotalHealthPointMax);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_soldierTotalHealthPointMax);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4E, true);
		string name7 = "m_fightTags";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_fightTags);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_fightTags);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache50, true);
		string name8 = "m_graphicStates";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_graphicStates);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_graphicStates);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache52, true);
		string name9 = "m_soldierGraphicCount";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_soldierGraphicCount);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_soldierGraphicCount);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache54, true);
		string name10 = "m_graphicPosition";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_graphicPosition);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_graphicPosition);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache56, true);
		string name11 = "m_isGraphicSkillFade";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_isGraphicSkillFade);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_isGraphicSkillFade);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache58, true);
		string name12 = "m_isActionFinishedGray";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_isActionFinishedGray);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_isActionFinishedGray);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5A, true);
		string name13 = "m_uiController";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_uiController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_uiController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5C, true);
		string name14 = "m_buffs";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_buffs);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_buffs);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5E, true);
		string name15 = "m_attachFxs";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_attachFxs);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_attachFxs);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache60, true);
		string name16 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_position);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_position);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache62, true);
		string name17 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_direction);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_direction);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache64, true);
		string name18 = "m_isVisible";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_isVisible);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_isVisible);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache66, true);
		string name19 = "m_isIdleRun";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_isIdleRun);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_isIdleRun);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache68, true);
		string name20 = "m_isGuarding";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_isGuarding);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_isGuarding);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6A, true);
		string name21 = "m_isTeleportDisappear";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_isTeleportDisappear);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_isTeleportDisappear);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6C, true);
		string name22 = "m_idleAnimationName";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_idleAnimationName);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_idleAnimationName);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6E, true);
		string name23 = "m_acts";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_acts);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_acts);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache70, true);
		string name24 = "m_actFrame";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_actFrame);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_actFrame);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache72, true);
		string name25 = "m_tempActFrame";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_tempActFrame);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_tempActFrame);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache74, true);
		string name26 = "m_deleteMeCountdown";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_m_deleteMeCountdown);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.set_m_deleteMeCountdown);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache76, true);
		string name27 = "Position";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_Position);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache77, null, true);
		string name28 = "Direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_Direction);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache78, null, true);
		string name29 = "BattleActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_BattleActor);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache79, null, true);
		string name30 = "TeamNumber";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_TeamNumber);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7A, null, true);
		string name31 = "HeroHealthPoint";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_HeroHealthPoint);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7B, null, true);
		string name32 = "SoldierTotalHealthPoint";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.get_SoldierTotalHealthPoint);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7C, null, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor.<>f__mg$cache7D, typeof(ClientBattleActor), typeof(Entity));
	}

	// Token: 0x0401085A RID: 67674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401085B RID: 67675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401085C RID: 67676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401085D RID: 67677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401085E RID: 67678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401085F RID: 67679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010860 RID: 67680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010861 RID: 67681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010862 RID: 67682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010863 RID: 67683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010864 RID: 67684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010865 RID: 67685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010866 RID: 67686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010867 RID: 67687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010868 RID: 67688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010869 RID: 67689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401086A RID: 67690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401086B RID: 67691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401086C RID: 67692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401086D RID: 67693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401086E RID: 67694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401086F RID: 67695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010870 RID: 67696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010871 RID: 67697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010872 RID: 67698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010873 RID: 67699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010874 RID: 67700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010875 RID: 67701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010876 RID: 67702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010877 RID: 67703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010878 RID: 67704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010879 RID: 67705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401087A RID: 67706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401087B RID: 67707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401087C RID: 67708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401087D RID: 67709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401087E RID: 67710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401087F RID: 67711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010880 RID: 67712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010881 RID: 67713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010882 RID: 67714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010883 RID: 67715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010884 RID: 67716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010885 RID: 67717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010886 RID: 67718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010887 RID: 67719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010888 RID: 67720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010889 RID: 67721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401088A RID: 67722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401088B RID: 67723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401088C RID: 67724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401088D RID: 67725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401088E RID: 67726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401088F RID: 67727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010890 RID: 67728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010891 RID: 67729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04010892 RID: 67730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04010893 RID: 67731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04010894 RID: 67732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04010895 RID: 67733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04010896 RID: 67734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04010897 RID: 67735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04010898 RID: 67736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04010899 RID: 67737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401089A RID: 67738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401089B RID: 67739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401089C RID: 67740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401089D RID: 67741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401089E RID: 67742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401089F RID: 67743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040108A0 RID: 67744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040108A1 RID: 67745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040108A2 RID: 67746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040108A3 RID: 67747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040108A4 RID: 67748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040108A5 RID: 67749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040108A6 RID: 67750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040108A7 RID: 67751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040108A8 RID: 67752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040108A9 RID: 67753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040108AA RID: 67754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040108AB RID: 67755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040108AC RID: 67756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040108AD RID: 67757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040108AE RID: 67758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040108AF RID: 67759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040108B0 RID: 67760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040108B1 RID: 67761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040108B2 RID: 67762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040108B3 RID: 67763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040108B4 RID: 67764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040108B5 RID: 67765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040108B6 RID: 67766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040108B7 RID: 67767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040108B8 RID: 67768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040108B9 RID: 67769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040108BA RID: 67770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040108BB RID: 67771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040108BC RID: 67772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040108BD RID: 67773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040108BE RID: 67774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040108BF RID: 67775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040108C0 RID: 67776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040108C1 RID: 67777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040108C2 RID: 67778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040108C3 RID: 67779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040108C4 RID: 67780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040108C5 RID: 67781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040108C6 RID: 67782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040108C7 RID: 67783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040108C8 RID: 67784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040108C9 RID: 67785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040108CA RID: 67786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040108CB RID: 67787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040108CC RID: 67788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040108CD RID: 67789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040108CE RID: 67790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040108CF RID: 67791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040108D0 RID: 67792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040108D1 RID: 67793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040108D2 RID: 67794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040108D3 RID: 67795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040108D4 RID: 67796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040108D5 RID: 67797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040108D6 RID: 67798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040108D7 RID: 67799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;
}
