using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200133C RID: 4924
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor : LuaObject
{
	// Token: 0x0601A6D3 RID: 108243 RVA: 0x007D2684 File Offset: 0x007D0884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor o = new ClientWorldPlayerActor();
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

	// Token: 0x0601A6D4 RID: 108244 RVA: 0x007D26CC File Offset: 0x007D08CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			ClientWorld world;
			LuaObject.checkType<ClientWorld>(l, 2, out world);
			clientWorldPlayerActor.Initialize(world);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6D5 RID: 108245 RVA: 0x007D2724 File Offset: 0x007D0924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			ConfigDataModelSkinResourceInfo heroSkinResInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 3, out heroSkinResInfo);
			clientWorldPlayerActor.CreateGraphic(jobConnectionInfo, heroSkinResInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6D6 RID: 108246 RVA: 0x007D2788 File Offset: 0x007D0988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6D7 RID: 108247 RVA: 0x007D27D4 File Offset: 0x007D09D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6D8 RID: 108248 RVA: 0x007D2820 File Offset: 0x007D0A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientWorldPlayerActor.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6D9 RID: 108249 RVA: 0x007D2878 File Offset: 0x007D0A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6DA RID: 108250 RVA: 0x007D28C4 File Offset: 0x007D0AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldPlayerActor.DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6DB RID: 108251 RVA: 0x007D291C File Offset: 0x007D0B1C
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
				ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
				ConfigDataWaypointInfo waypointInfo;
				LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
				int dir;
				LuaObject.checkType(l, 3, out dir);
				clientWorldPlayerActor.Locate(waypointInfo, dir);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Vector2), typeof(int)))
			{
				ClientWorldPlayerActor clientWorldPlayerActor2 = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
				Vector2 p;
				LuaObject.checkType(l, 2, out p);
				int dir2;
				LuaObject.checkType(l, 3, out dir2);
				clientWorldPlayerActor2.Locate(p, dir2);
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

	// Token: 0x0601A6DC RID: 108252 RVA: 0x007D2A24 File Offset: 0x007D0C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MovePath(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			List<int> path;
			LuaObject.checkType<List<int>>(l, 2, out path);
			Action onMoveEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onMoveEnd);
			clientWorldPlayerActor.MovePath(path, onMoveEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6DD RID: 108253 RVA: 0x007D2A88 File Offset: 0x007D0C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Teleport(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			Action onTeleportEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onTeleportEnd);
			clientWorldPlayerActor.Teleport(waypointId, onTeleportEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6DE RID: 108254 RVA: 0x007D2AEC File Offset: 0x007D0CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMoving(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			bool b = clientWorldPlayerActor.IsMoving();
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

	// Token: 0x0601A6DF RID: 108255 RVA: 0x007D2B40 File Offset: 0x007D0D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGraphicEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			GraphicEffect e;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out e);
			float param;
			LuaObject.checkType(l, 3, out param);
			float param2;
			LuaObject.checkType(l, 4, out param2);
			clientWorldPlayerActor.SetGraphicEffect(e, param, param2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A6E0 RID: 108256 RVA: 0x007D2BB4 File Offset: 0x007D0DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearGraphicEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			GraphicEffect e;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out e);
			clientWorldPlayerActor.ClearGraphicEffect(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A6E1 RID: 108257 RVA: 0x007D2C0C File Offset: 0x007D0E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			bool visible;
			LuaObject.checkType(l, 2, out visible);
			clientWorldPlayerActor.SetVisible(visible);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6E2 RID: 108258 RVA: 0x007D2C64 File Offset: 0x007D0E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			bool b = clientWorldPlayerActor.IsVisible();
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

	// Token: 0x0601A6E3 RID: 108259 RVA: 0x007D2CB8 File Offset: 0x007D0EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.m_luaExportHelper.DestroyGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6E4 RID: 108260 RVA: 0x007D2D0C File Offset: 0x007D0F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			clientWorldPlayerActor.m_luaExportHelper.PlayAnimation(name, loop);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6E5 RID: 108261 RVA: 0x007D2D78 File Offset: 0x007D0F78
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
				ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				clientWorldPlayerActor.m_luaExportHelper.PlayFx(name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				ClientWorldPlayerActor clientWorldPlayerActor2 = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				Vector3 p;
				LuaObject.checkType(l, 3, out p);
				clientWorldPlayerActor2.m_luaExportHelper.PlayFx(name2, p);
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

	// Token: 0x0601A6E6 RID: 108262 RVA: 0x007D2E44 File Offset: 0x007D1044
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
				ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				clientWorldPlayerActor.m_luaExportHelper.PlaySound(name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(SoundTableId)))
			{
				ClientWorldPlayerActor clientWorldPlayerActor2 = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
				SoundTableId id;
				LuaObject.checkEnum<SoundTableId>(l, 2, out id);
				clientWorldPlayerActor2.m_luaExportHelper.PlaySound(id);
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

	// Token: 0x0601A6E7 RID: 108263 RVA: 0x007D2F24 File Offset: 0x007D1124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.m_luaExportHelper.__callBase_Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6E8 RID: 108264 RVA: 0x007D2F78 File Offset: 0x007D1178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.m_luaExportHelper.__callBase_Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6E9 RID: 108265 RVA: 0x007D2FCC File Offset: 0x007D11CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientWorldPlayerActor.m_luaExportHelper.__callBase_TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6EA RID: 108266 RVA: 0x007D3028 File Offset: 0x007D1228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.m_luaExportHelper.__callBase_Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6EB RID: 108267 RVA: 0x007D307C File Offset: 0x007D127C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldPlayerActor.m_luaExportHelper.__callBase_Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6EC RID: 108268 RVA: 0x007D30D8 File Offset: 0x007D12D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldPlayerActor.m_luaExportHelper.__callBase_DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6ED RID: 108269 RVA: 0x007D3134 File Offset: 0x007D1334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.m_luaExportHelper.__callBase_DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6EE RID: 108270 RVA: 0x007D3188 File Offset: 0x007D1388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_onMoveEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.m_luaExportHelper.__callDele_m_onMoveEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6EF RID: 108271 RVA: 0x007D31DC File Offset: 0x007D13DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_onMoveEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.m_luaExportHelper.__clearDele_m_onMoveEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6F0 RID: 108272 RVA: 0x007D3230 File Offset: 0x007D1430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_onTeleportEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.m_luaExportHelper.__callDele_m_onTeleportEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6F1 RID: 108273 RVA: 0x007D3284 File Offset: 0x007D1484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_onTeleportEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			clientWorldPlayerActor.m_luaExportHelper.__clearDele_m_onTeleportEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6F2 RID: 108274 RVA: 0x007D32D8 File Offset: 0x007D14D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientWorld(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_clientWorld);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6F3 RID: 108275 RVA: 0x007D3330 File Offset: 0x007D1530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientWorld(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			ClientWorld clientWorld;
			LuaObject.checkType<ClientWorld>(l, 2, out clientWorld);
			clientWorldPlayerActor.m_luaExportHelper.m_clientWorld = clientWorld;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6F4 RID: 108276 RVA: 0x007D338C File Offset: 0x007D158C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locateWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_locateWaypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6F5 RID: 108277 RVA: 0x007D33E4 File Offset: 0x007D15E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locateWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo locateWaypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out locateWaypointInfo);
			clientWorldPlayerActor.m_luaExportHelper.m_locateWaypointInfo = locateWaypointInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6F6 RID: 108278 RVA: 0x007D3440 File Offset: 0x007D1640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_movePath(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_movePath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6F7 RID: 108279 RVA: 0x007D3498 File Offset: 0x007D1698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_movePath(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			List<ClientWorldWaypoint> movePath;
			LuaObject.checkType<List<ClientWorldWaypoint>>(l, 2, out movePath);
			clientWorldPlayerActor.m_luaExportHelper.m_movePath = movePath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6F8 RID: 108280 RVA: 0x007D34F4 File Offset: 0x007D16F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onMoveEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				clientWorldPlayerActor.m_luaExportHelper.m_onMoveEnd = action;
			}
			else if (num == 1)
			{
				ClientWorldPlayerActor.LuaExportHelper luaExportHelper = clientWorldPlayerActor.m_luaExportHelper;
				luaExportHelper.m_onMoveEnd = (Action)Delegate.Combine(luaExportHelper.m_onMoveEnd, action);
			}
			else if (num == 2)
			{
				ClientWorldPlayerActor.LuaExportHelper luaExportHelper2 = clientWorldPlayerActor.m_luaExportHelper;
				luaExportHelper2.m_onMoveEnd = (Action)Delegate.Remove(luaExportHelper2.m_onMoveEnd, action);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6F9 RID: 108281 RVA: 0x007D35A8 File Offset: 0x007D17A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teleportAppearCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_teleportAppearCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6FA RID: 108282 RVA: 0x007D3600 File Offset: 0x007D1800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teleportAppearCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			float teleportAppearCountdown;
			LuaObject.checkType(l, 2, out teleportAppearCountdown);
			clientWorldPlayerActor.m_luaExportHelper.m_teleportAppearCountdown = teleportAppearCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6FB RID: 108283 RVA: 0x007D365C File Offset: 0x007D185C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teleportEndActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_teleportEndActionCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6FC RID: 108284 RVA: 0x007D36B4 File Offset: 0x007D18B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teleportEndActionCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			float teleportEndActionCountdown;
			LuaObject.checkType(l, 2, out teleportEndActionCountdown);
			clientWorldPlayerActor.m_luaExportHelper.m_teleportEndActionCountdown = teleportEndActionCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6FD RID: 108285 RVA: 0x007D3710 File Offset: 0x007D1910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teleportWaypoint(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_teleportWaypoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6FE RID: 108286 RVA: 0x007D3768 File Offset: 0x007D1968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teleportWaypoint(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			ClientWorldWaypoint teleportWaypoint;
			LuaObject.checkType<ClientWorldWaypoint>(l, 2, out teleportWaypoint);
			clientWorldPlayerActor.m_luaExportHelper.m_teleportWaypoint = teleportWaypoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A6FF RID: 108287 RVA: 0x007D37C4 File Offset: 0x007D19C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onTeleportEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				clientWorldPlayerActor.m_luaExportHelper.m_onTeleportEnd = action;
			}
			else if (num == 1)
			{
				ClientWorldPlayerActor.LuaExportHelper luaExportHelper = clientWorldPlayerActor.m_luaExportHelper;
				luaExportHelper.m_onTeleportEnd = (Action)Delegate.Combine(luaExportHelper.m_onTeleportEnd, action);
			}
			else if (num == 2)
			{
				ClientWorldPlayerActor.LuaExportHelper luaExportHelper2 = clientWorldPlayerActor.m_luaExportHelper;
				luaExportHelper2.m_onTeleportEnd = (Action)Delegate.Remove(luaExportHelper2.m_onTeleportEnd, action);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A700 RID: 108288 RVA: 0x007D3878 File Offset: 0x007D1A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A701 RID: 108289 RVA: 0x007D38D0 File Offset: 0x007D1AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			GenericGraphic graphic;
			LuaObject.checkType<GenericGraphic>(l, 2, out graphic);
			clientWorldPlayerActor.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A702 RID: 108290 RVA: 0x007D392C File Offset: 0x007D1B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A703 RID: 108291 RVA: 0x007D3984 File Offset: 0x007D1B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			clientWorldPlayerActor.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A704 RID: 108292 RVA: 0x007D39E0 File Offset: 0x007D1BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A705 RID: 108293 RVA: 0x007D3A38 File Offset: 0x007D1C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientWorldPlayerActor.m_luaExportHelper.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A706 RID: 108294 RVA: 0x007D3A94 File Offset: 0x007D1C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_isVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A707 RID: 108295 RVA: 0x007D3AEC File Offset: 0x007D1CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			bool isVisible;
			LuaObject.checkType(l, 2, out isVisible);
			clientWorldPlayerActor.m_luaExportHelper.m_isVisible = isVisible;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A708 RID: 108296 RVA: 0x007D3B48 File Offset: 0x007D1D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiController(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.m_luaExportHelper.m_uiController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A709 RID: 108297 RVA: 0x007D3BA0 File Offset: 0x007D1DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiController(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			WorldPlayerActorUIController uiController;
			LuaObject.checkType<WorldPlayerActorUIController>(l, 2, out uiController);
			clientWorldPlayerActor.m_luaExportHelper.m_uiController = uiController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A70A RID: 108298 RVA: 0x007D3BFC File Offset: 0x007D1DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A70B RID: 108299 RVA: 0x007D3C50 File Offset: 0x007D1E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Direction(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.Direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A70C RID: 108300 RVA: 0x007D3CA4 File Offset: 0x007D1EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LocateWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldPlayerActor clientWorldPlayerActor = (ClientWorldPlayerActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldPlayerActor.LocateWaypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A70D RID: 108301 RVA: 0x007D3CF8 File Offset: 0x007D1EF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientWorldPlayerActor");
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.CreateGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.Locate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.MovePath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.Teleport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.IsMoving);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.SetGraphicEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.ClearGraphicEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.SetVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.IsVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.DestroyGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.PlayFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.PlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__callBase_Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__callBase_TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__callBase_Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__callBase_DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__callBase_DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__callDele_m_onMoveEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__clearDele_m_onMoveEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__callDele_m_onTeleportEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.__clearDele_m_onTeleportEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1D);
		string name = "m_clientWorld";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_clientWorld);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_clientWorld);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache1F, true);
		string name2 = "m_locateWaypointInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_locateWaypointInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_locateWaypointInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache21, true);
		string name3 = "m_movePath";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_movePath);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_movePath);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache23, true);
		string name4 = "m_onMoveEnd";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_onMoveEnd);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache24, true);
		string name5 = "m_teleportAppearCountdown";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_teleportAppearCountdown);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_teleportAppearCountdown);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache26, true);
		string name6 = "m_teleportEndActionCountdown";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_teleportEndActionCountdown);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_teleportEndActionCountdown);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache28, true);
		string name7 = "m_teleportWaypoint";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_teleportWaypoint);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_teleportWaypoint);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2A, true);
		string name8 = "m_onTeleportEnd";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_onTeleportEnd);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2B, true);
		string name9 = "m_graphic";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_graphic);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_graphic);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2D, true);
		string name10 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_position);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_position);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache2F, true);
		string name11 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_direction);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_direction);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache31, true);
		string name12 = "m_isVisible";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_isVisible);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_isVisible);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache33, true);
		string name13 = "m_uiController";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_m_uiController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.set_m_uiController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache35, true);
		string name14 = "Position";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_Position);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache36, null, true);
		string name15 = "Direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_Direction);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache37, null, true);
		string name16 = "LocateWaypointInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.get_LocateWaypointInfo);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache38, null, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.<>f__mg$cache39, typeof(ClientWorldPlayerActor), typeof(Entity));
	}

	// Token: 0x04010A3D RID: 68157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010A3E RID: 68158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010A3F RID: 68159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010A40 RID: 68160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010A41 RID: 68161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010A42 RID: 68162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010A43 RID: 68163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010A44 RID: 68164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010A45 RID: 68165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010A46 RID: 68166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010A47 RID: 68167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010A48 RID: 68168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010A49 RID: 68169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010A4A RID: 68170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010A4B RID: 68171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010A4C RID: 68172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010A4D RID: 68173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010A4E RID: 68174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010A4F RID: 68175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010A50 RID: 68176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010A51 RID: 68177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010A52 RID: 68178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010A53 RID: 68179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010A54 RID: 68180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010A55 RID: 68181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010A56 RID: 68182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010A57 RID: 68183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010A58 RID: 68184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010A59 RID: 68185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010A5A RID: 68186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010A5B RID: 68187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010A5C RID: 68188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010A5D RID: 68189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010A5E RID: 68190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010A5F RID: 68191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010A60 RID: 68192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010A61 RID: 68193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010A62 RID: 68194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010A63 RID: 68195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010A64 RID: 68196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010A65 RID: 68197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010A66 RID: 68198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010A67 RID: 68199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010A68 RID: 68200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010A69 RID: 68201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010A6A RID: 68202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010A6B RID: 68203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010A6C RID: 68204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010A6D RID: 68205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010A6E RID: 68206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010A6F RID: 68207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010A70 RID: 68208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010A71 RID: 68209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010A72 RID: 68210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010A73 RID: 68211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010A74 RID: 68212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04010A75 RID: 68213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04010A76 RID: 68214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;
}
