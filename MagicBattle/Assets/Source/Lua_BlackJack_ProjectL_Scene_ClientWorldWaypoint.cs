using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200133E RID: 4926
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint : LuaObject
{
	// Token: 0x0601A731 RID: 108337 RVA: 0x007D54C0 File Offset: 0x007D36C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint o = new ClientWorldWaypoint();
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

	// Token: 0x0601A732 RID: 108338 RVA: 0x007D5508 File Offset: 0x007D3708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			ClientWorld world;
			LuaObject.checkType<ClientWorld>(l, 2, out world);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 3, out waypointInfo);
			clientWorldWaypoint.Initialize(world, waypointInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A733 RID: 108339 RVA: 0x007D556C File Offset: 0x007D376C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			clientWorldWaypoint.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A734 RID: 108340 RVA: 0x007D55B8 File Offset: 0x007D37B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			clientWorldWaypoint.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A735 RID: 108341 RVA: 0x007D5604 File Offset: 0x007D3804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientWorldWaypoint.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A736 RID: 108342 RVA: 0x007D565C File Offset: 0x007D385C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			clientWorldWaypoint.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A737 RID: 108343 RVA: 0x007D56A8 File Offset: 0x007D38A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldWaypoint.DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A738 RID: 108344 RVA: 0x007D5700 File Offset: 0x007D3900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Locate(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			clientWorldWaypoint.Locate(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A739 RID: 108345 RVA: 0x007D5758 File Offset: 0x007D3958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStatus(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			WayPointStatus status;
			LuaObject.checkEnum<WayPointStatus>(l, 2, out status);
			clientWorldWaypoint.SetStatus(status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A73A RID: 108346 RVA: 0x007D57B0 File Offset: 0x007D39B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStatus(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			WayPointStatus status = clientWorldWaypoint.GetStatus();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A73B RID: 108347 RVA: 0x007D5804 File Offset: 0x007D3A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetScenarioState(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 3, out scenarioInfo);
			clientWorldWaypoint.SetScenarioState(waypointInfo, scenarioInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A73C RID: 108348 RVA: 0x007D5868 File Offset: 0x007D3A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCanClick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			bool canClick;
			LuaObject.checkType(l, 2, out canClick);
			clientWorldWaypoint.SetCanClick(canClick);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A73D RID: 108349 RVA: 0x007D58C0 File Offset: 0x007D3AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetClickTransform(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			RectTransform clickTransform = clientWorldWaypoint.GetClickTransform();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clickTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A73E RID: 108350 RVA: 0x007D5914 File Offset: 0x007D3B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			bool visible;
			LuaObject.checkType(l, 2, out visible);
			clientWorldWaypoint.SetVisible(visible);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A73F RID: 108351 RVA: 0x007D596C File Offset: 0x007D3B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			bool b = clientWorldWaypoint.IsVisible();
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

	// Token: 0x0601A740 RID: 108352 RVA: 0x007D59C0 File Offset: 0x007D3BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUISiblingIndex(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			int uisiblingIndex;
			LuaObject.checkType(l, 2, out uisiblingIndex);
			clientWorldWaypoint.SetUISiblingIndex(uisiblingIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A741 RID: 108353 RVA: 0x007D5A18 File Offset: 0x007D3C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawArrow(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			Vector3 p;
			LuaObject.checkType(l, 2, out p);
			Vector3 p2;
			LuaObject.checkType(l, 3, out p2);
			Color color;
			LuaObject.checkType(l, 4, out color);
			clientWorldWaypoint.m_luaExportHelper.DrawArrow(p, p2, color);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A742 RID: 108354 RVA: 0x007D5A90 File Offset: 0x007D3C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			clientWorldWaypoint.m_luaExportHelper.PlayAnimation(name, loop);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A743 RID: 108355 RVA: 0x007D5AFC File Offset: 0x007D3CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUIPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			clientWorldWaypoint.m_luaExportHelper.OnUIPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A744 RID: 108356 RVA: 0x007D5B50 File Offset: 0x007D3D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUIPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			clientWorldWaypoint.m_luaExportHelper.OnUIPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A745 RID: 108357 RVA: 0x007D5BA4 File Offset: 0x007D3DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUIClick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			clientWorldWaypoint.m_luaExportHelper.OnUIClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A746 RID: 108358 RVA: 0x007D5BF8 File Offset: 0x007D3DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			clientWorldWaypoint.m_luaExportHelper.__callBase_Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A747 RID: 108359 RVA: 0x007D5C4C File Offset: 0x007D3E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			clientWorldWaypoint.m_luaExportHelper.__callBase_Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A748 RID: 108360 RVA: 0x007D5CA0 File Offset: 0x007D3EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientWorldWaypoint.m_luaExportHelper.__callBase_TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A749 RID: 108361 RVA: 0x007D5CFC File Offset: 0x007D3EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			clientWorldWaypoint.m_luaExportHelper.__callBase_Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A74A RID: 108362 RVA: 0x007D5D50 File Offset: 0x007D3F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldWaypoint.m_luaExportHelper.__callBase_Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A74B RID: 108363 RVA: 0x007D5DAC File Offset: 0x007D3FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldWaypoint.m_luaExportHelper.__callBase_DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A74C RID: 108364 RVA: 0x007D5E08 File Offset: 0x007D4008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			clientWorldWaypoint.m_luaExportHelper.__callBase_DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A74D RID: 108365 RVA: 0x007D5E5C File Offset: 0x007D405C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientWorld(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_clientWorld);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A74E RID: 108366 RVA: 0x007D5EB4 File Offset: 0x007D40B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientWorld(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			ClientWorld clientWorld;
			LuaObject.checkType<ClientWorld>(l, 2, out clientWorld);
			clientWorldWaypoint.m_luaExportHelper.m_clientWorld = clientWorld;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A74F RID: 108367 RVA: 0x007D5F10 File Offset: 0x007D4110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_waypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A750 RID: 108368 RVA: 0x007D5F68 File Offset: 0x007D4168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			clientWorldWaypoint.m_luaExportHelper.m_waypointInfo = waypointInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A751 RID: 108369 RVA: 0x007D5FC4 File Offset: 0x007D41C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_status(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientWorldWaypoint.m_luaExportHelper.m_status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A752 RID: 108370 RVA: 0x007D601C File Offset: 0x007D421C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_status(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			WayPointStatus status;
			LuaObject.checkEnum<WayPointStatus>(l, 2, out status);
			clientWorldWaypoint.m_luaExportHelper.m_status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A753 RID: 108371 RVA: 0x007D6078 File Offset: 0x007D4278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A754 RID: 108372 RVA: 0x007D60D0 File Offset: 0x007D42D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			GenericGraphic graphic;
			LuaObject.checkType<GenericGraphic>(l, 2, out graphic);
			clientWorldWaypoint.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A755 RID: 108373 RVA: 0x007D612C File Offset: 0x007D432C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A756 RID: 108374 RVA: 0x007D6184 File Offset: 0x007D4384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			clientWorldWaypoint.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A757 RID: 108375 RVA: 0x007D61E0 File Offset: 0x007D43E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_isVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A758 RID: 108376 RVA: 0x007D6238 File Offset: 0x007D4438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			bool isVisible;
			LuaObject.checkType(l, 2, out isVisible);
			clientWorldWaypoint.m_luaExportHelper.m_isVisible = isVisible;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A759 RID: 108377 RVA: 0x007D6294 File Offset: 0x007D4494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiController(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_uiController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A75A RID: 108378 RVA: 0x007D62EC File Offset: 0x007D44EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiController(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			WorldWaypointUIController uiController;
			LuaObject.checkType<WorldWaypointUIController>(l, 2, out uiController);
			clientWorldWaypoint.m_luaExportHelper.m_uiController = uiController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A75B RID: 108379 RVA: 0x007D6348 File Offset: 0x007D4548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_graphicUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A75C RID: 108380 RVA: 0x007D63A0 File Offset: 0x007D45A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			CommonUIStateController graphicUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out graphicUIStateController);
			clientWorldWaypoint.m_luaExportHelper.m_graphicUIStateController = graphicUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A75D RID: 108381 RVA: 0x007D63FC File Offset: 0x007D45FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiInitScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_uiInitScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A75E RID: 108382 RVA: 0x007D6454 File Offset: 0x007D4654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiInitScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			Vector3 uiInitScale;
			LuaObject.checkType(l, 2, out uiInitScale);
			clientWorldWaypoint.m_luaExportHelper.m_uiInitScale = uiInitScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A75F RID: 108383 RVA: 0x007D64B0 File Offset: 0x007D46B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicInitScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_graphicInitScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A760 RID: 108384 RVA: 0x007D6508 File Offset: 0x007D4708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicInitScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			float graphicInitScale;
			LuaObject.checkType(l, 2, out graphicInitScale);
			clientWorldWaypoint.m_luaExportHelper.m_graphicInitScale = graphicInitScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A761 RID: 108385 RVA: 0x007D6564 File Offset: 0x007D4764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_isPointerDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A762 RID: 108386 RVA: 0x007D65BC File Offset: 0x007D47BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			bool isPointerDown;
			LuaObject.checkType(l, 2, out isPointerDown);
			clientWorldWaypoint.m_luaExportHelper.m_isPointerDown = isPointerDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A763 RID: 108387 RVA: 0x007D6618 File Offset: 0x007D4818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.m_luaExportHelper.m_scale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A764 RID: 108388 RVA: 0x007D6670 File Offset: 0x007D4870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			float scale;
			LuaObject.checkType(l, 2, out scale);
			clientWorldWaypoint.m_luaExportHelper.m_scale = scale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A765 RID: 108389 RVA: 0x007D66CC File Offset: 0x007D48CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A766 RID: 108390 RVA: 0x007D6720 File Offset: 0x007D4920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint clientWorldWaypoint = (ClientWorldWaypoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldWaypoint.WaypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A767 RID: 108391 RVA: 0x007D6774 File Offset: 0x007D4974
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientWorldWaypoint");
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.Locate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.SetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.GetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.SetScenarioState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.SetCanClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.GetClickTransform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.SetVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.IsVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.SetUISiblingIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.DrawArrow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.OnUIPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.OnUIPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.OnUIClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.__callBase_Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.__callBase_TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.__callBase_Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.__callBase_DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.__callBase_DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1A);
		string name = "m_clientWorld";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_clientWorld);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_clientWorld);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1C, true);
		string name2 = "m_waypointInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_waypointInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_waypointInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1E, true);
		string name3 = "m_status";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_status);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_status);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache20, true);
		string name4 = "m_graphic";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_graphic);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_graphic);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache22, true);
		string name5 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_position);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_position);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache24, true);
		string name6 = "m_isVisible";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_isVisible);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_isVisible);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache26, true);
		string name7 = "m_uiController";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_uiController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_uiController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache28, true);
		string name8 = "m_graphicUIStateController";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_graphicUIStateController);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_graphicUIStateController);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2A, true);
		string name9 = "m_uiInitScale";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_uiInitScale);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_uiInitScale);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2C, true);
		string name10 = "m_graphicInitScale";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_graphicInitScale);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_graphicInitScale);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2E, true);
		string name11 = "m_isPointerDown";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_isPointerDown);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_isPointerDown);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache30, true);
		string name12 = "m_scale";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_m_scale);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.set_m_scale);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache32, true);
		string name13 = "Position";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_Position);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache33, null, true);
		string name14 = "WaypointInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.get_WaypointInfo);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache34, null, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.<>f__mg$cache35, typeof(ClientWorldWaypoint), typeof(Entity));
	}

	// Token: 0x04010A97 RID: 68247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010A98 RID: 68248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010A99 RID: 68249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010A9A RID: 68250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010A9B RID: 68251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010A9C RID: 68252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010A9D RID: 68253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010A9E RID: 68254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010A9F RID: 68255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010AA0 RID: 68256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010AA1 RID: 68257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010AA2 RID: 68258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010AA3 RID: 68259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010AA4 RID: 68260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010AA5 RID: 68261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010AA6 RID: 68262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010AA7 RID: 68263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010AA8 RID: 68264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010AA9 RID: 68265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010AAA RID: 68266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010AAB RID: 68267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010AAC RID: 68268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010AAD RID: 68269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010AAE RID: 68270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010AAF RID: 68271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010AB0 RID: 68272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010AB1 RID: 68273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010AB2 RID: 68274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010AB3 RID: 68275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010AB4 RID: 68276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010AB5 RID: 68277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010AB6 RID: 68278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010AB7 RID: 68279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010AB8 RID: 68280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010AB9 RID: 68281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010ABA RID: 68282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010ABB RID: 68283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010ABC RID: 68284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010ABD RID: 68285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010ABE RID: 68286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010ABF RID: 68287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010AC0 RID: 68288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010AC1 RID: 68289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010AC2 RID: 68290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010AC3 RID: 68291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010AC4 RID: 68292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010AC5 RID: 68293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010AC6 RID: 68294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010AC7 RID: 68295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010AC8 RID: 68296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010AC9 RID: 68297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010ACA RID: 68298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010ACB RID: 68299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010ACC RID: 68300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;
}
