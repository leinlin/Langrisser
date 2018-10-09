using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200133B RID: 4923
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor : LuaObject
{
	// Token: 0x0601A695 RID: 108181 RVA: 0x007D0818 File Offset: 0x007CEA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor o = new ClientWorldEventActor();
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

	// Token: 0x0601A696 RID: 108182 RVA: 0x007D0860 File Offset: 0x007CEA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			ClientWorld world;
			LuaObject.checkType<ClientWorld>(l, 2, out world);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out eventInfo);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 4, out randomEvent);
			clientWorldEventActor.Initialize(world, eventInfo, randomEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A697 RID: 108183 RVA: 0x007D08D4 File Offset: 0x007CEAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A698 RID: 108184 RVA: 0x007D0920 File Offset: 0x007CEB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A699 RID: 108185 RVA: 0x007D096C File Offset: 0x007CEB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientWorldEventActor.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A69A RID: 108186 RVA: 0x007D09C4 File Offset: 0x007CEBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A69B RID: 108187 RVA: 0x007D0A10 File Offset: 0x007CEC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldEventActor.DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A69C RID: 108188 RVA: 0x007D0A68 File Offset: 0x007CEC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Locate(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ConfigDataWaypointInfo), typeof(int)))
			{
				ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
				ConfigDataWaypointInfo waypointInfo;
				LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
				int dir;
				LuaObject.checkType(l, 3, out dir);
				clientWorldEventActor.Locate(waypointInfo, dir);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Vector2), typeof(int)))
			{
				ClientWorldEventActor clientWorldEventActor2 = (ClientWorldEventActor)LuaObject.checkSelf(l);
				Vector2 p;
				LuaObject.checkType(l, 2, out p);
				int dir2;
				LuaObject.checkType(l, 3, out dir2);
				clientWorldEventActor2.Locate(p, dir2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Locate to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A69D RID: 108189 RVA: 0x007D0B70 File Offset: 0x007CED70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCanClick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			bool canClick;
			LuaObject.checkType(l, 2, out canClick);
			clientWorldEventActor.SetCanClick(canClick);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A69E RID: 108190 RVA: 0x007D0BC8 File Offset: 0x007CEDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowAppearFx(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.ShowAppearFx();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A69F RID: 108191 RVA: 0x007D0C14 File Offset: 0x007CEE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGraphicEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			GraphicEffect e;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out e);
			float param;
			LuaObject.checkType(l, 3, out param);
			float param2;
			LuaObject.checkType(l, 4, out param2);
			clientWorldEventActor.SetGraphicEffect(e, param, param2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A6A0 RID: 108192 RVA: 0x007D0C88 File Offset: 0x007CEE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearGraphicEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			GraphicEffect e;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out e);
			clientWorldEventActor.ClearGraphicEffect(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A6A1 RID: 108193 RVA: 0x007D0CE0 File Offset: 0x007CEEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			bool visible;
			LuaObject.checkType(l, 2, out visible);
			clientWorldEventActor.SetVisible(visible);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6A2 RID: 108194 RVA: 0x007D0D38 File Offset: 0x007CEF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			bool b = clientWorldEventActor.IsVisible();
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

	// Token: 0x0601A6A3 RID: 108195 RVA: 0x007D0D8C File Offset: 0x007CEF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUISiblingIndex(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			int uisiblingIndex;
			LuaObject.checkType(l, 2, out uisiblingIndex);
			clientWorldEventActor.SetUISiblingIndex(uisiblingIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6A4 RID: 108196 RVA: 0x007D0DE4 File Offset: 0x007CEFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			clientWorldEventActor.m_luaExportHelper.PlayAnimation(name, loop);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6A5 RID: 108197 RVA: 0x007D0E50 File Offset: 0x007CF050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayFx(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				clientWorldEventActor.m_luaExportHelper.PlayFx(name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				ClientWorldEventActor clientWorldEventActor2 = (ClientWorldEventActor)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				Vector3 p;
				LuaObject.checkType(l, 3, out p);
				clientWorldEventActor2.m_luaExportHelper.PlayFx(name2, p);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PlayFx to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6A6 RID: 108198 RVA: 0x007D0F1C File Offset: 0x007CF11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUIPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.m_luaExportHelper.OnUIPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6A7 RID: 108199 RVA: 0x007D0F70 File Offset: 0x007CF170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUIPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.m_luaExportHelper.OnUIPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6A8 RID: 108200 RVA: 0x007D0FC4 File Offset: 0x007CF1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUIClick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.m_luaExportHelper.OnUIClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6A9 RID: 108201 RVA: 0x007D1018 File Offset: 0x007CF218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.m_luaExportHelper.__callBase_Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6AA RID: 108202 RVA: 0x007D106C File Offset: 0x007CF26C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.m_luaExportHelper.__callBase_Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6AB RID: 108203 RVA: 0x007D10C0 File Offset: 0x007CF2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientWorldEventActor.m_luaExportHelper.__callBase_TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6AC RID: 108204 RVA: 0x007D111C File Offset: 0x007CF31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.m_luaExportHelper.__callBase_Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6AD RID: 108205 RVA: 0x007D1170 File Offset: 0x007CF370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldEventActor.m_luaExportHelper.__callBase_Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6AE RID: 108206 RVA: 0x007D11CC File Offset: 0x007CF3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldEventActor.m_luaExportHelper.__callBase_DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6AF RID: 108207 RVA: 0x007D1228 File Offset: 0x007CF428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			clientWorldEventActor.m_luaExportHelper.__callBase_DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6B0 RID: 108208 RVA: 0x007D127C File Offset: 0x007CF47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientWorld(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_clientWorld);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6B1 RID: 108209 RVA: 0x007D12D4 File Offset: 0x007CF4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientWorld(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			ClientWorld clientWorld;
			LuaObject.checkType<ClientWorld>(l, 2, out clientWorld);
			clientWorldEventActor.m_luaExportHelper.m_clientWorld = clientWorld;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6B2 RID: 108210 RVA: 0x007D1330 File Offset: 0x007CF530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_eventInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6B3 RID: 108211 RVA: 0x007D1388 File Offset: 0x007CF588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out eventInfo);
			clientWorldEventActor.m_luaExportHelper.m_eventInfo = eventInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6B4 RID: 108212 RVA: 0x007D13E4 File Offset: 0x007CF5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomEvent(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_randomEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6B5 RID: 108213 RVA: 0x007D143C File Offset: 0x007CF63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomEvent(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 2, out randomEvent);
			clientWorldEventActor.m_luaExportHelper.m_randomEvent = randomEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6B6 RID: 108214 RVA: 0x007D1498 File Offset: 0x007CF698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locateWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_locateWaypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6B7 RID: 108215 RVA: 0x007D14F0 File Offset: 0x007CF6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locateWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo locateWaypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out locateWaypointInfo);
			clientWorldEventActor.m_luaExportHelper.m_locateWaypointInfo = locateWaypointInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6B8 RID: 108216 RVA: 0x007D154C File Offset: 0x007CF74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6B9 RID: 108217 RVA: 0x007D15A4 File Offset: 0x007CF7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			GenericGraphic graphic;
			LuaObject.checkType<GenericGraphic>(l, 2, out graphic);
			clientWorldEventActor.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6BA RID: 108218 RVA: 0x007D1600 File Offset: 0x007CF800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6BB RID: 108219 RVA: 0x007D1658 File Offset: 0x007CF858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			clientWorldEventActor.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6BC RID: 108220 RVA: 0x007D16B4 File Offset: 0x007CF8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6BD RID: 108221 RVA: 0x007D170C File Offset: 0x007CF90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientWorldEventActor.m_luaExportHelper.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6BE RID: 108222 RVA: 0x007D1768 File Offset: 0x007CF968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_isVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6BF RID: 108223 RVA: 0x007D17C0 File Offset: 0x007CF9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			bool isVisible;
			LuaObject.checkType(l, 2, out isVisible);
			clientWorldEventActor.m_luaExportHelper.m_isVisible = isVisible;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6C0 RID: 108224 RVA: 0x007D181C File Offset: 0x007CFA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiController(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_uiController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6C1 RID: 108225 RVA: 0x007D1874 File Offset: 0x007CFA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiController(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			WorldEventActorUIController uiController;
			LuaObject.checkType<WorldEventActorUIController>(l, 2, out uiController);
			clientWorldEventActor.m_luaExportHelper.m_uiController = uiController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6C2 RID: 108226 RVA: 0x007D18D0 File Offset: 0x007CFAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiInitScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_uiInitScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6C3 RID: 108227 RVA: 0x007D1928 File Offset: 0x007CFB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiInitScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			Vector3 uiInitScale;
			LuaObject.checkType(l, 2, out uiInitScale);
			clientWorldEventActor.m_luaExportHelper.m_uiInitScale = uiInitScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6C4 RID: 108228 RVA: 0x007D1984 File Offset: 0x007CFB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicInitScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_graphicInitScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6C5 RID: 108229 RVA: 0x007D19DC File Offset: 0x007CFBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicInitScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			float graphicInitScale;
			LuaObject.checkType(l, 2, out graphicInitScale);
			clientWorldEventActor.m_luaExportHelper.m_graphicInitScale = graphicInitScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6C6 RID: 108230 RVA: 0x007D1A38 File Offset: 0x007CFC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_isPointerDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6C7 RID: 108231 RVA: 0x007D1A90 File Offset: 0x007CFC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			bool isPointerDown;
			LuaObject.checkType(l, 2, out isPointerDown);
			clientWorldEventActor.m_luaExportHelper.m_isPointerDown = isPointerDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6C8 RID: 108232 RVA: 0x007D1AEC File Offset: 0x007CFCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_scale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6C9 RID: 108233 RVA: 0x007D1B44 File Offset: 0x007CFD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			float scale;
			LuaObject.checkType(l, 2, out scale);
			clientWorldEventActor.m_luaExportHelper.m_scale = scale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6CA RID: 108234 RVA: 0x007D1BA0 File Offset: 0x007CFDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_appearCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.m_luaExportHelper.m_appearCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6CB RID: 108235 RVA: 0x007D1BF8 File Offset: 0x007CFDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_appearCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			float appearCountdown;
			LuaObject.checkType(l, 2, out appearCountdown);
			clientWorldEventActor.m_luaExportHelper.m_appearCountdown = appearCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6CC RID: 108236 RVA: 0x007D1C54 File Offset: 0x007CFE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6CD RID: 108237 RVA: 0x007D1CA8 File Offset: 0x007CFEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Direction(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.Direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6CE RID: 108238 RVA: 0x007D1CFC File Offset: 0x007CFEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LocateWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.LocateWaypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6CF RID: 108239 RVA: 0x007D1D50 File Offset: 0x007CFF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EventInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.EventInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6D0 RID: 108240 RVA: 0x007D1DA4 File Offset: 0x007CFFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RandomEvent(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor clientWorldEventActor = (ClientWorldEventActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldEventActor.RandomEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6D1 RID: 108241 RVA: 0x007D1DF8 File Offset: 0x007CFFF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientWorldEventActor");
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.Locate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.SetCanClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.ShowAppearFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.SetGraphicEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.ClearGraphicEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.SetVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.IsVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.SetUISiblingIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.PlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.OnUIPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.OnUIPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.OnUIClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.__callBase_Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.__callBase_TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.__callBase_Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.__callBase_DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.__callBase_DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache19);
		string name = "m_clientWorld";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_clientWorld);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_clientWorld);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1B, true);
		string name2 = "m_eventInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_eventInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_eventInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1D, true);
		string name3 = "m_randomEvent";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_randomEvent);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_randomEvent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache1F, true);
		string name4 = "m_locateWaypointInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_locateWaypointInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_locateWaypointInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache21, true);
		string name5 = "m_graphic";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_graphic);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_graphic);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache23, true);
		string name6 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_position);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_position);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache25, true);
		string name7 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_direction);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_direction);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache27, true);
		string name8 = "m_isVisible";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_isVisible);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_isVisible);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache29, true);
		string name9 = "m_uiController";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_uiController);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_uiController);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2B, true);
		string name10 = "m_uiInitScale";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_uiInitScale);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_uiInitScale);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2D, true);
		string name11 = "m_graphicInitScale";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_graphicInitScale);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_graphicInitScale);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache2F, true);
		string name12 = "m_isPointerDown";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_isPointerDown);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_isPointerDown);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache31, true);
		string name13 = "m_scale";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_scale);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_scale);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache33, true);
		string name14 = "m_appearCountdown";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_m_appearCountdown);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.set_m_appearCountdown);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache35, true);
		string name15 = "Position";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_Position);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache36, null, true);
		string name16 = "Direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_Direction);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache37, null, true);
		string name17 = "LocateWaypointInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_LocateWaypointInfo);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache38, null, true);
		string name18 = "EventInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_EventInfo);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache39, null, true);
		string name19 = "RandomEvent";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.get_RandomEvent);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache3A, null, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.<>f__mg$cache3B, typeof(ClientWorldEventActor), typeof(Entity));
	}

	// Token: 0x04010A01 RID: 68097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010A02 RID: 68098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010A03 RID: 68099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010A04 RID: 68100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010A05 RID: 68101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010A06 RID: 68102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010A07 RID: 68103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010A08 RID: 68104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010A09 RID: 68105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010A0A RID: 68106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010A0B RID: 68107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010A0C RID: 68108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010A0D RID: 68109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010A0E RID: 68110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010A0F RID: 68111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010A10 RID: 68112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010A11 RID: 68113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010A12 RID: 68114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010A13 RID: 68115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010A14 RID: 68116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010A15 RID: 68117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010A16 RID: 68118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010A17 RID: 68119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010A18 RID: 68120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010A19 RID: 68121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010A1A RID: 68122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010A1B RID: 68123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010A1C RID: 68124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010A1D RID: 68125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010A1E RID: 68126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010A1F RID: 68127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010A20 RID: 68128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010A21 RID: 68129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010A22 RID: 68130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010A23 RID: 68131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010A24 RID: 68132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010A25 RID: 68133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010A26 RID: 68134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010A27 RID: 68135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010A28 RID: 68136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010A29 RID: 68137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010A2A RID: 68138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010A2B RID: 68139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010A2C RID: 68140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010A2D RID: 68141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010A2E RID: 68142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010A2F RID: 68143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010A30 RID: 68144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010A31 RID: 68145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010A32 RID: 68146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010A33 RID: 68147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010A34 RID: 68148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010A35 RID: 68149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010A36 RID: 68150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010A37 RID: 68151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010A38 RID: 68152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04010A39 RID: 68153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04010A3A RID: 68154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04010A3B RID: 68155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04010A3C RID: 68156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;
}
