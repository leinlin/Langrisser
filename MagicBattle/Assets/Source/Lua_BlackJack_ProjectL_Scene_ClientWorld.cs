using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Art;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001339 RID: 4921
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientWorld : LuaObject
{
	// Token: 0x0601A5F2 RID: 108018 RVA: 0x007CB934 File Offset: 0x007C9B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld o = new ClientWorld();
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

	// Token: 0x0601A5F3 RID: 108019 RVA: 0x007CB97C File Offset: 0x007C9B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5F4 RID: 108020 RVA: 0x007CB9C8 File Offset: 0x007C9BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			IClientWorldListener clientWorldListener;
			LuaObject.checkType<IClientWorldListener>(l, 2, out clientWorldListener);
			GameObject worldRoot;
			LuaObject.checkType<GameObject>(l, 3, out worldRoot);
			clientWorld.Initialize(clientWorldListener, worldRoot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5F5 RID: 108021 RVA: 0x007CBA2C File Offset: 0x007C9C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWaypointUpdate(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.OnWaypointUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5F6 RID: 108022 RVA: 0x007CBA78 File Offset: 0x007C9C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerIconUpdate(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.OnPlayerIconUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5F7 RID: 108023 RVA: 0x007CBAC4 File Offset: 0x007C9CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientWorld.Tick(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5F8 RID: 108024 RVA: 0x007CBB1C File Offset: 0x007C9D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalTimeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			float globalTimeScale;
			LuaObject.checkType(l, 2, out globalTimeScale);
			clientWorld.SetGlobalTimeScale(globalTimeScale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5F9 RID: 108025 RVA: 0x007CBB74 File Offset: 0x007C9D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5FA RID: 108026 RVA: 0x007CBBC0 File Offset: 0x007C9DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ConfigDataWorldMapInfo worldMapInfo;
			LuaObject.checkType<ConfigDataWorldMapInfo>(l, 2, out worldMapInfo);
			clientWorld.Start(worldMapInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5FB RID: 108027 RVA: 0x007CBC18 File Offset: 0x007C9E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Stop(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.Stop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5FC RID: 108028 RVA: 0x007CBC64 File Offset: 0x007C9E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorld.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5FD RID: 108029 RVA: 0x007CBCBC File Offset: 0x007C9EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWorld(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			clientWorld.ShowWorld(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5FE RID: 108030 RVA: 0x007CBD14 File Offset: 0x007C9F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateEventActorState(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.UpdateEventActorState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5FF RID: 108031 RVA: 0x007CBD60 File Offset: 0x007C9F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateCurrentScenario(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.UpdateCurrentScenario();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A600 RID: 108032 RVA: 0x007CBDAC File Offset: 0x007C9FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRegion(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			int regionId;
			LuaObject.checkType(l, 2, out regionId);
			ClientWorldRegion region = clientWorld.GetRegion(regionId);
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

	// Token: 0x0601A601 RID: 108033 RVA: 0x007CBE10 File Offset: 0x007CA010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWaypoint(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			ClientWorldWaypoint waypoint = clientWorld.GetWaypoint(waypointId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waypoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A602 RID: 108034 RVA: 0x007CBE74 File Offset: 0x007CA074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEventActorAt(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			ClientWorldEventActor eventActorAt = clientWorld.GetEventActorAt(waypointId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventActorAt);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A603 RID: 108035 RVA: 0x007CBED8 File Offset: 0x007CA0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEventActoryByEventId(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			int eventId;
			LuaObject.checkType(l, 2, out eventId);
			ClientWorldEventActor eventActoryByEventId = clientWorld.GetEventActoryByEventId(eventId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventActoryByEventId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A604 RID: 108036 RVA: 0x007CBF3C File Offset: 0x007CA13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEventActors(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			List<ClientWorldEventActor> eventActors = clientWorld.GetEventActors();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A605 RID: 108037 RVA: 0x007CBF90 File Offset: 0x007CA190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerActor(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ClientWorldPlayerActor playerActor = clientWorld.GetPlayerActor();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A606 RID: 108038 RVA: 0x007CBFE4 File Offset: 0x007CA1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWaypointClick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ClientWorldWaypoint wp;
			LuaObject.checkType<ClientWorldWaypoint>(l, 2, out wp);
			clientWorld.OnWaypointClick(wp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A607 RID: 108039 RVA: 0x007CC03C File Offset: 0x007CA23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEventActorClick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ClientWorldEventActor a;
			LuaObject.checkType<ClientWorldEventActor>(l, 2, out a);
			clientWorld.OnEventActorClick(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A608 RID: 108040 RVA: 0x007CC094 File Offset: 0x007CA294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			GenericGraphic o = clientWorld.CreateGraphic(assetName, scale);
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

	// Token: 0x0601A609 RID: 108041 RVA: 0x007CC104 File Offset: 0x007CA304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GenericGraphic graphic;
			LuaObject.checkType<GenericGraphic>(l, 2, out graphic);
			clientWorld.DestroyGraphic(graphic);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A60A RID: 108042 RVA: 0x007CC15C File Offset: 0x007CA35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCameraPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			Vector3 cameraPosition = clientWorld.GetCameraPosition();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cameraPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A60B RID: 108043 RVA: 0x007CC1B0 File Offset: 0x007CA3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCulled(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
				Vector2 p;
				LuaObject.checkType(l, 2, out p);
				bool isCombat;
				LuaObject.checkType(l, 3, out isCombat);
				bool b = clientWorld.IsCulled(p, isCombat);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 4)
			{
				ClientWorld clientWorld2 = (ClientWorld)LuaObject.checkSelf(l);
				Vector2 bmin;
				LuaObject.checkType(l, 2, out bmin);
				Vector2 bmax;
				LuaObject.checkType(l, 3, out bmax);
				bool isCombat2;
				LuaObject.checkType(l, 4, out isCombat2);
				bool b2 = clientWorld2.IsCulled(bmin, bmax, isCombat2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsCulled to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A60C RID: 108044 RVA: 0x007CC2A4 File Offset: 0x007CA4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNextEntityId(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			int nextEntityId = clientWorld.GetNextEntityId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextEntityId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A60D RID: 108045 RVA: 0x007CC2F8 File Offset: 0x007CA4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayScreenEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			clientWorld.PlayScreenEffect(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A60E RID: 108046 RVA: 0x007CC350 File Offset: 0x007CA550
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
				ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				clientWorld.PlaySound(name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(SoundTableId)))
			{
				ClientWorld clientWorld2 = (ClientWorld)LuaObject.checkSelf(l);
				SoundTableId id;
				LuaObject.checkEnum<SoundTableId>(l, 2, out id);
				clientWorld2.PlaySound(id);
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

	// Token: 0x0601A60F RID: 108047 RVA: 0x007CC428 File Offset: 0x007CA628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPath(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			int start;
			LuaObject.checkType(l, 2, out start);
			int goal;
			LuaObject.checkType(l, 3, out goal);
			List<int> path;
			LuaObject.checkType<List<int>>(l, 4, out path);
			bool checkWaypointStatus;
			LuaObject.checkType(l, 5, out checkWaypointStatus);
			bool b = clientWorld.FindPath(start, goal, path, checkWaypointStatus);
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

	// Token: 0x0601A610 RID: 108048 RVA: 0x007CC4B0 File Offset: 0x007CA6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAudio(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			AudioClip a;
			LuaObject.checkType<AudioClip>(l, 3, out a);
			clientWorld.OnAudio(e, a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A611 RID: 108049 RVA: 0x007CC514 File Offset: 0x007CA714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSound(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			clientWorld.OnSound(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A612 RID: 108050 RVA: 0x007CC578 File Offset: 0x007CA778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCameraEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			clientWorld.OnCameraEffect(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A613 RID: 108051 RVA: 0x007CC5DC File Offset: 0x007CA7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScreenEffect(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			clientWorld.OnScreenEffect(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A614 RID: 108052 RVA: 0x007CC640 File Offset: 0x007CA840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGeneral(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			clientWorld.OnGeneral(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A615 RID: 108053 RVA: 0x007CC6A4 File Offset: 0x007CA8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeActorPosition_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 pos;
			LuaObject.checkType(l, 1, out pos);
			float zoffset;
			LuaObject.checkType(l, 2, out zoffset);
			Vector3 o = ClientWorld.ComputeActorPosition(pos, zoffset);
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

	// Token: 0x0601A616 RID: 108054 RVA: 0x007CC704 File Offset: 0x007CA904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FrameToMillisecond_s(IntPtr l)
	{
		int result;
		try
		{
			int frame;
			LuaObject.checkType(l, 1, out frame);
			int i = ClientWorld.FrameToMillisecond(frame);
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

	// Token: 0x0601A617 RID: 108055 RVA: 0x007CC758 File Offset: 0x007CA958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MillisecondToFrame_s(IntPtr l)
	{
		int result;
		try
		{
			int ms;
			LuaObject.checkType(l, 1, out ms);
			int i = ClientWorld.MillisecondToFrame(ms);
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

	// Token: 0x0601A618 RID: 108056 RVA: 0x007CC7AC File Offset: 0x007CA9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MillisecondToFrame1_s(IntPtr l)
	{
		int result;
		try
		{
			int ms;
			LuaObject.checkType(l, 1, out ms);
			int i = ClientWorld.MillisecondToFrame1(ms);
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

	// Token: 0x0601A619 RID: 108057 RVA: 0x007CC800 File Offset: 0x007CAA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickClientWorld(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.m_luaExportHelper.TickClientWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A61A RID: 108058 RVA: 0x007CC854 File Offset: 0x007CAA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTimeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			float timeScale;
			LuaObject.checkType(l, 2, out timeScale);
			clientWorld.m_luaExportHelper.SetTimeScale(timeScale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A61B RID: 108059 RVA: 0x007CC8B0 File Offset: 0x007CAAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateFinalTimeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.m_luaExportHelper.UpdateFinalTimeScale();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A61C RID: 108060 RVA: 0x007CC904 File Offset: 0x007CAB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientWorld.m_luaExportHelper.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A61D RID: 108061 RVA: 0x007CC960 File Offset: 0x007CAB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.m_luaExportHelper.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A61E RID: 108062 RVA: 0x007CC9B4 File Offset: 0x007CABB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateRegion(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ConfigDataRegionInfo regionInfo;
			LuaObject.checkType<ConfigDataRegionInfo>(l, 2, out regionInfo);
			ClientWorldRegion o = clientWorld.m_luaExportHelper.CreateRegion(regionInfo);
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

	// Token: 0x0601A61F RID: 108063 RVA: 0x007CCA1C File Offset: 0x007CAC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateWaypoint(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			ClientWorldWaypoint o = clientWorld.m_luaExportHelper.CreateWaypoint(waypointInfo);
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

	// Token: 0x0601A620 RID: 108064 RVA: 0x007CCA84 File Offset: 0x007CAC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreatePlayerActor(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			int dir;
			LuaObject.checkType(l, 3, out dir);
			ClientWorldPlayerActor o = clientWorld.m_luaExportHelper.CreatePlayerActor(waypointInfo, dir);
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

	// Token: 0x0601A621 RID: 108065 RVA: 0x007CCAF8 File Offset: 0x007CACF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateEventActor(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out eventInfo);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 3, out waypointInfo);
			int dir;
			LuaObject.checkType(l, 4, out dir);
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 5, out randomEvent);
			ClientWorldEventActor o = clientWorld.m_luaExportHelper.CreateEventActor(eventInfo, waypointInfo, dir, randomEvent);
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

	// Token: 0x0601A622 RID: 108066 RVA: 0x007CCB88 File Offset: 0x007CAD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRegionState(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.m_luaExportHelper.UpdateRegionState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A623 RID: 108067 RVA: 0x007CCBDC File Offset: 0x007CADDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateWaypointState(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.m_luaExportHelper.UpdateWaypointState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A624 RID: 108068 RVA: 0x007CCC30 File Offset: 0x007CAE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			CameraBase camera = clientWorld.m_luaExportHelper.GetCamera();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A625 RID: 108069 RVA: 0x007CCC8C File Offset: 0x007CAE8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateBackground(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ConfigDataWorldMapInfo worldMapInfo;
			LuaObject.checkType<ConfigDataWorldMapInfo>(l, 2, out worldMapInfo);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 3, out parent);
			clientWorld.m_luaExportHelper.CreateBackground(worldMapInfo, parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A626 RID: 108070 RVA: 0x007CCCF8 File Offset: 0x007CAEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearBackground(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			clientWorld.m_luaExportHelper.ClearBackground();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A627 RID: 108071 RVA: 0x007CCD4C File Offset: 0x007CAF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareEventActorPositionY_s(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldEventActor a;
			LuaObject.checkType<ClientWorldEventActor>(l, 1, out a);
			ClientWorldEventActor a2;
			LuaObject.checkType<ClientWorldEventActor>(l, 2, out a2);
			int i = ClientWorld.LuaExportHelper.CompareEventActorPositionY(a, a2);
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

	// Token: 0x0601A628 RID: 108072 RVA: 0x007CCDAC File Offset: 0x007CAFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareWaypointPositionY_s(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldWaypoint a;
			LuaObject.checkType<ClientWorldWaypoint>(l, 1, out a);
			ClientWorldWaypoint a2;
			LuaObject.checkType<ClientWorldWaypoint>(l, 2, out a2);
			int i = ClientWorld.LuaExportHelper.CompareWaypointPositionY(a, a2);
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

	// Token: 0x0601A629 RID: 108073 RVA: 0x007CCE0C File Offset: 0x007CB00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_state(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientWorld.m_luaExportHelper.m_state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A62A RID: 108074 RVA: 0x007CCE64 File Offset: 0x007CB064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_state(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ClientWorldState state;
			LuaObject.checkEnum<ClientWorldState>(l, 2, out state);
			clientWorld.m_luaExportHelper.m_state = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A62B RID: 108075 RVA: 0x007CCEC0 File Offset: 0x007CB0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_entityIdCounter(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_entityIdCounter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A62C RID: 108076 RVA: 0x007CCF18 File Offset: 0x007CB118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_entityIdCounter(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			int entityIdCounter;
			LuaObject.checkType(l, 2, out entityIdCounter);
			clientWorld.m_luaExportHelper.m_entityIdCounter = entityIdCounter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A62D RID: 108077 RVA: 0x007CCF74 File Offset: 0x007CB174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frameCount(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_frameCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A62E RID: 108078 RVA: 0x007CCFCC File Offset: 0x007CB1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameCount(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			int frameCount;
			LuaObject.checkType(l, 2, out frameCount);
			clientWorld.m_luaExportHelper.m_frameCount = frameCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A62F RID: 108079 RVA: 0x007CD028 File Offset: 0x007CB228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldTickTime(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_worldTickTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A630 RID: 108080 RVA: 0x007CD080 File Offset: 0x007CB280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldTickTime(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			float worldTickTime;
			LuaObject.checkType(l, 2, out worldTickTime);
			clientWorld.m_luaExportHelper.m_worldTickTime = worldTickTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A631 RID: 108081 RVA: 0x007CD0DC File Offset: 0x007CB2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_timeScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A632 RID: 108082 RVA: 0x007CD134 File Offset: 0x007CB334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			float timeScale;
			LuaObject.checkType(l, 2, out timeScale);
			clientWorld.m_luaExportHelper.m_timeScale = timeScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A633 RID: 108083 RVA: 0x007CD190 File Offset: 0x007CB390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_globalTimeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_globalTimeScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A634 RID: 108084 RVA: 0x007CD1E8 File Offset: 0x007CB3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_globalTimeScale(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			float globalTimeScale;
			LuaObject.checkType(l, 2, out globalTimeScale);
			clientWorld.m_luaExportHelper.m_globalTimeScale = globalTimeScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A635 RID: 108085 RVA: 0x007CD244 File Offset: 0x007CB444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPaused(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_isPaused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A636 RID: 108086 RVA: 0x007CD29C File Offset: 0x007CB49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPaused(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			bool isPaused;
			LuaObject.checkType(l, 2, out isPaused);
			clientWorld.m_luaExportHelper.m_isPaused = isPaused;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A637 RID: 108087 RVA: 0x007CD2F8 File Offset: 0x007CB4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enableDebugDraw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_enableDebugDraw);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A638 RID: 108088 RVA: 0x007CD350 File Offset: 0x007CB550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enableDebugDraw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			bool enableDebugDraw;
			LuaObject.checkType(l, 2, out enableDebugDraw);
			clientWorld.m_luaExportHelper.m_enableDebugDraw = enableDebugDraw;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A639 RID: 108089 RVA: 0x007CD3AC File Offset: 0x007CB5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomNumber(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_randomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A63A RID: 108090 RVA: 0x007CD404 File Offset: 0x007CB604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomNumber(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			RandomNumber randomNumber;
			LuaObject.checkType<RandomNumber>(l, 2, out randomNumber);
			clientWorld.m_luaExportHelper.m_randomNumber = randomNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A63B RID: 108091 RVA: 0x007CD460 File Offset: 0x007CB660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A63C RID: 108092 RVA: 0x007CD4B8 File Offset: 0x007CB6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			clientWorld.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A63D RID: 108093 RVA: 0x007CD514 File Offset: 0x007CB714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerActors(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_playerActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A63E RID: 108094 RVA: 0x007CD56C File Offset: 0x007CB76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerActors(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			List<ClientWorldPlayerActor> playerActors;
			LuaObject.checkType<List<ClientWorldPlayerActor>>(l, 2, out playerActors);
			clientWorld.m_luaExportHelper.m_playerActors = playerActors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A63F RID: 108095 RVA: 0x007CD5C8 File Offset: 0x007CB7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventActors(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_eventActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A640 RID: 108096 RVA: 0x007CD620 File Offset: 0x007CB820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventActors(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			List<ClientWorldEventActor> eventActors;
			LuaObject.checkType<List<ClientWorldEventActor>>(l, 2, out eventActors);
			clientWorld.m_luaExportHelper.m_eventActors = eventActors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A641 RID: 108097 RVA: 0x007CD67C File Offset: 0x007CB87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waypoints(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_waypoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A642 RID: 108098 RVA: 0x007CD6D4 File Offset: 0x007CB8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waypoints(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			List<ClientWorldWaypoint> waypoints;
			LuaObject.checkType<List<ClientWorldWaypoint>>(l, 2, out waypoints);
			clientWorld.m_luaExportHelper.m_waypoints = waypoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A643 RID: 108099 RVA: 0x007CD730 File Offset: 0x007CB930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regions(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_regions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A644 RID: 108100 RVA: 0x007CD788 File Offset: 0x007CB988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regions(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			List<ClientWorldRegion> regions;
			LuaObject.checkType<List<ClientWorldRegion>>(l, 2, out regions);
			clientWorld.m_luaExportHelper.m_regions = regions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A645 RID: 108101 RVA: 0x007CD7E4 File Offset: 0x007CB9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldMapInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_worldMapInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A646 RID: 108102 RVA: 0x007CD83C File Offset: 0x007CBA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldMapInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			ConfigDataWorldMapInfo worldMapInfo;
			LuaObject.checkType<ConfigDataWorldMapInfo>(l, 2, out worldMapInfo);
			clientWorld.m_luaExportHelper.m_worldMapInfo = worldMapInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A647 RID: 108103 RVA: 0x007CD898 File Offset: 0x007CBA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A648 RID: 108104 RVA: 0x007CD8F0 File Offset: 0x007CBAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			clientWorld.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A649 RID: 108105 RVA: 0x007CD94C File Offset: 0x007CBB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientWorldListener(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_clientWorldListener);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A64A RID: 108106 RVA: 0x007CD9A4 File Offset: 0x007CBBA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientWorldListener(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			IClientWorldListener clientWorldListener;
			LuaObject.checkType<IClientWorldListener>(l, 2, out clientWorldListener);
			clientWorld.m_luaExportHelper.m_clientWorldListener = clientWorldListener;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A64B RID: 108107 RVA: 0x007CDA00 File Offset: 0x007CBC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_worldCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A64C RID: 108108 RVA: 0x007CDA58 File Offset: 0x007CBC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			WorldCamera worldCamera;
			LuaObject.checkType<WorldCamera>(l, 2, out worldCamera);
			clientWorld.m_luaExportHelper.m_worldCamera = worldCamera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A64D RID: 108109 RVA: 0x007CDAB4 File Offset: 0x007CBCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pathfinder(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_pathfinder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A64E RID: 108110 RVA: 0x007CDB0C File Offset: 0x007CBD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pathfinder(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			WorldPathfinder pathfinder;
			LuaObject.checkType<WorldPathfinder>(l, 2, out pathfinder);
			clientWorld.m_luaExportHelper.m_pathfinder = pathfinder;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A64F RID: 108111 RVA: 0x007CDB68 File Offset: 0x007CBD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_worldRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A650 RID: 108112 RVA: 0x007CDBC0 File Offset: 0x007CBDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject worldRoot;
			LuaObject.checkType<GameObject>(l, 2, out worldRoot);
			clientWorld.m_luaExportHelper.m_worldRoot = worldRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A651 RID: 108113 RVA: 0x007CDC1C File Offset: 0x007CBE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_graphicRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A652 RID: 108114 RVA: 0x007CDC74 File Offset: 0x007CBE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject graphicRoot;
			LuaObject.checkType<GameObject>(l, 2, out graphicRoot);
			clientWorld.m_luaExportHelper.m_graphicRoot = graphicRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A653 RID: 108115 RVA: 0x007CDCD0 File Offset: 0x007CBED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mapRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_mapRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A654 RID: 108116 RVA: 0x007CDD28 File Offset: 0x007CBF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mapRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject mapRoot;
			LuaObject.checkType<GameObject>(l, 2, out mapRoot);
			clientWorld.m_luaExportHelper.m_mapRoot = mapRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A655 RID: 108117 RVA: 0x007CDD84 File Offset: 0x007CBF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_background(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_background);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A656 RID: 108118 RVA: 0x007CDDDC File Offset: 0x007CBFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_background(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject background;
			LuaObject.checkType<GameObject>(l, 2, out background);
			clientWorld.m_luaExportHelper.m_background = background;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A657 RID: 108119 RVA: 0x007CDE38 File Offset: 0x007CC038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundWaypointsRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_backgroundWaypointsRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A658 RID: 108120 RVA: 0x007CDE90 File Offset: 0x007CC090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundWaypointsRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject backgroundWaypointsRoot;
			LuaObject.checkType<GameObject>(l, 2, out backgroundWaypointsRoot);
			clientWorld.m_luaExportHelper.m_backgroundWaypointsRoot = backgroundWaypointsRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A659 RID: 108121 RVA: 0x007CDEEC File Offset: 0x007CC0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundRegionsRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_backgroundRegionsRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A65A RID: 108122 RVA: 0x007CDF44 File Offset: 0x007CC144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundRegionsRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject backgroundRegionsRoot;
			LuaObject.checkType<GameObject>(l, 2, out backgroundRegionsRoot);
			clientWorld.m_luaExportHelper.m_backgroundRegionsRoot = backgroundRegionsRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A65B RID: 108123 RVA: 0x007CDFA0 File Offset: 0x007CC1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_worldUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A65C RID: 108124 RVA: 0x007CDFF8 File Offset: 0x007CC1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject worldUIRoot;
			LuaObject.checkType<GameObject>(l, 2, out worldUIRoot);
			clientWorld.m_luaExportHelper.m_worldUIRoot = worldUIRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A65D RID: 108125 RVA: 0x007CE054 File Offset: 0x007CC254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waypointUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_waypointUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A65E RID: 108126 RVA: 0x007CE0AC File Offset: 0x007CC2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waypointUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject waypointUIRoot;
			LuaObject.checkType<GameObject>(l, 2, out waypointUIRoot);
			clientWorld.m_luaExportHelper.m_waypointUIRoot = waypointUIRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A65F RID: 108127 RVA: 0x007CE108 File Offset: 0x007CC308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_eventUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A660 RID: 108128 RVA: 0x007CE160 File Offset: 0x007CC360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject eventUIRoot;
			LuaObject.checkType<GameObject>(l, 2, out eventUIRoot);
			clientWorld.m_luaExportHelper.m_eventUIRoot = eventUIRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A661 RID: 108129 RVA: 0x007CE1BC File Offset: 0x007CC3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_playerUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A662 RID: 108130 RVA: 0x007CE214 File Offset: 0x007CC414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject playerUIRoot;
			LuaObject.checkType<GameObject>(l, 2, out playerUIRoot);
			clientWorld.m_luaExportHelper.m_playerUIRoot = playerUIRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A663 RID: 108131 RVA: 0x007CE270 File Offset: 0x007CC470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waypointUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_waypointUIPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A664 RID: 108132 RVA: 0x007CE2C8 File Offset: 0x007CC4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waypointUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject waypointUIPrefab;
			LuaObject.checkType<GameObject>(l, 2, out waypointUIPrefab);
			clientWorld.m_luaExportHelper.m_waypointUIPrefab = waypointUIPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A665 RID: 108133 RVA: 0x007CE324 File Offset: 0x007CC524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waypoint2UIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_waypoint2UIPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A666 RID: 108134 RVA: 0x007CE37C File Offset: 0x007CC57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waypoint2UIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject waypoint2UIPrefab;
			LuaObject.checkType<GameObject>(l, 2, out waypoint2UIPrefab);
			clientWorld.m_luaExportHelper.m_waypoint2UIPrefab = waypoint2UIPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A667 RID: 108135 RVA: 0x007CE3D8 File Offset: 0x007CC5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_eventUIPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A668 RID: 108136 RVA: 0x007CE430 File Offset: 0x007CC630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject eventUIPrefab;
			LuaObject.checkType<GameObject>(l, 2, out eventUIPrefab);
			clientWorld.m_luaExportHelper.m_eventUIPrefab = eventUIPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A669 RID: 108137 RVA: 0x007CE48C File Offset: 0x007CC68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_playerUIPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A66A RID: 108138 RVA: 0x007CE4E4 File Offset: 0x007CC6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GameObject playerUIPrefab;
			LuaObject.checkType<GameObject>(l, 2, out playerUIPrefab);
			clientWorld.m_luaExportHelper.m_playerUIPrefab = playerUIPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A66B RID: 108139 RVA: 0x007CE540 File Offset: 0x007CC740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_worldScenarioUIController(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_worldScenarioUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A66C RID: 108140 RVA: 0x007CE598 File Offset: 0x007CC798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_worldScenarioUIController(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			WorldScenarioUIController worldScenarioUIController;
			LuaObject.checkType<WorldScenarioUIController>(l, 2, out worldScenarioUIController);
			clientWorld.m_luaExportHelper.m_worldScenarioUIController = worldScenarioUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A66D RID: 108141 RVA: 0x007CE5F4 File Offset: 0x007CC7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicPool(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_graphicPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A66E RID: 108142 RVA: 0x007CE64C File Offset: 0x007CC84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicPool(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GraphicPool graphicPool;
			LuaObject.checkType<GraphicPool>(l, 2, out graphicPool);
			clientWorld.m_luaExportHelper.m_graphicPool = graphicPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A66F RID: 108143 RVA: 0x007CE6A8 File Offset: 0x007CC8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxPool(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_fxPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A670 RID: 108144 RVA: 0x007CE700 File Offset: 0x007CC900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxPool(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			GraphicPool fxPool;
			LuaObject.checkType<GraphicPool>(l, 2, out fxPool);
			clientWorld.m_luaExportHelper.m_fxPool = fxPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A671 RID: 108145 RVA: 0x007CE75C File Offset: 0x007CC95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.m_luaExportHelper.m_fxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A672 RID: 108146 RVA: 0x007CE7B4 File Offset: 0x007CC9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			FxPlayer fxPlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out fxPlayer);
			clientWorld.m_luaExportHelper.m_fxPlayer = fxPlayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A673 RID: 108147 RVA: 0x007CE810 File Offset: 0x007CCA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WorldCamera(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.WorldCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A674 RID: 108148 RVA: 0x007CE864 File Offset: 0x007CCA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_State(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientWorld.State);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A675 RID: 108149 RVA: 0x007CE8B8 File Offset: 0x007CCAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnableDebugDraw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.EnableDebugDraw);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A676 RID: 108150 RVA: 0x007CE90C File Offset: 0x007CCB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnableDebugDraw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			bool enableDebugDraw;
			LuaObject.checkType(l, 2, out enableDebugDraw);
			clientWorld.EnableDebugDraw = enableDebugDraw;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A677 RID: 108151 RVA: 0x007CE964 File Offset: 0x007CCB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GraphicRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.GraphicRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A678 RID: 108152 RVA: 0x007CE9B8 File Offset: 0x007CCBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WorldUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.WorldUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A679 RID: 108153 RVA: 0x007CEA0C File Offset: 0x007CCC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WaypointUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.WaypointUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A67A RID: 108154 RVA: 0x007CEA60 File Offset: 0x007CCC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EventUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.EventUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A67B RID: 108155 RVA: 0x007CEAB4 File Offset: 0x007CCCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerUIRoot(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.PlayerUIRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A67C RID: 108156 RVA: 0x007CEB08 File Offset: 0x007CCD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WaypointUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.WaypointUIPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A67D RID: 108157 RVA: 0x007CEB5C File Offset: 0x007CCD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Waypoint2UIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.Waypoint2UIPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A67E RID: 108158 RVA: 0x007CEBB0 File Offset: 0x007CCDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EventUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.EventUIPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A67F RID: 108159 RVA: 0x007CEC04 File Offset: 0x007CCE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerUIPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.PlayerUIPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A680 RID: 108160 RVA: 0x007CEC58 File Offset: 0x007CCE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FxPlayer(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.FxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A681 RID: 108161 RVA: 0x007CECAC File Offset: 0x007CCEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A682 RID: 108162 RVA: 0x007CED00 File Offset: 0x007CCF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ClientWorldListener(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.ClientWorldListener);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A683 RID: 108163 RVA: 0x007CED54 File Offset: 0x007CCF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerContext(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.PlayerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A684 RID: 108164 RVA: 0x007CEDA8 File Offset: 0x007CCFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WorldMapInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorld clientWorld = (ClientWorld)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorld.WorldMapInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A685 RID: 108165 RVA: 0x007CEDFC File Offset: 0x007CCFFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientWorld");
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.OnWaypointUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.OnPlayerIconUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.SetGlobalTimeScale);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.Stop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.ShowWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.UpdateEventActorState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.UpdateCurrentScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.GetRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.GetWaypoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.GetEventActorAt);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.GetEventActoryByEventId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.GetEventActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.GetPlayerActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.OnWaypointClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.OnEventActorClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.CreateGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.DestroyGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.GetCameraPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.IsCulled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.GetNextEntityId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.PlayScreenEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.PlaySound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.FindPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.OnAudio);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.OnSound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.OnCameraEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.OnScreenEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.OnGeneral);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.ComputeActorPosition_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.FrameToMillisecond_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.MillisecondToFrame_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.MillisecondToFrame1_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.TickClientWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.SetTimeScale);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.UpdateFinalTimeScale);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.CreateRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.CreateWaypoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.CreatePlayerActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.CreateEventActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.UpdateRegionState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.UpdateWaypointState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.GetCamera);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.CreateBackground);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.ClearBackground);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.CompareEventActorPositionY_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.CompareWaypointPositionY_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache35);
		string name = "m_state";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_state);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_state);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache37, true);
		string name2 = "m_entityIdCounter";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_entityIdCounter);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_entityIdCounter);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache39, true);
		string name3 = "m_frameCount";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_frameCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_frameCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3B, true);
		string name4 = "m_worldTickTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_worldTickTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_worldTickTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3D, true);
		string name5 = "m_timeScale";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_timeScale);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_timeScale);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache3F, true);
		string name6 = "m_globalTimeScale";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_globalTimeScale);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_globalTimeScale);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache41, true);
		string name7 = "m_isPaused";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_isPaused);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_isPaused);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache43, true);
		string name8 = "m_enableDebugDraw";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_enableDebugDraw);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_enableDebugDraw);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache45, true);
		string name9 = "m_randomNumber";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_randomNumber);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_randomNumber);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache47, true);
		string name10 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_playerContext);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_playerContext);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache49, true);
		string name11 = "m_playerActors";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_playerActors);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_playerActors);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4B, true);
		string name12 = "m_eventActors";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_eventActors);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_eventActors);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4D, true);
		string name13 = "m_waypoints";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_waypoints);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_waypoints);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache4F, true);
		string name14 = "m_regions";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_regions);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_regions);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache51, true);
		string name15 = "m_worldMapInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_worldMapInfo);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_worldMapInfo);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache53, true);
		string name16 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_configDataLoader);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache55, true);
		string name17 = "m_clientWorldListener";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_clientWorldListener);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_clientWorldListener);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache57, true);
		string name18 = "m_worldCamera";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_worldCamera);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_worldCamera);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache59, true);
		string name19 = "m_pathfinder";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_pathfinder);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_pathfinder);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5B, true);
		string name20 = "m_worldRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_worldRoot);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_worldRoot);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5D, true);
		string name21 = "m_graphicRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_graphicRoot);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_graphicRoot);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache5F, true);
		string name22 = "m_mapRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_mapRoot);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_mapRoot);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache61, true);
		string name23 = "m_background";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_background);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_background);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache63, true);
		string name24 = "m_backgroundWaypointsRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_backgroundWaypointsRoot);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_backgroundWaypointsRoot);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache65, true);
		string name25 = "m_backgroundRegionsRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_backgroundRegionsRoot);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_backgroundRegionsRoot);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache67, true);
		string name26 = "m_worldUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_worldUIRoot);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_worldUIRoot);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache69, true);
		string name27 = "m_waypointUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_waypointUIRoot);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_waypointUIRoot);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6B, true);
		string name28 = "m_eventUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_eventUIRoot);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_eventUIRoot);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6D, true);
		string name29 = "m_playerUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_playerUIRoot);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_playerUIRoot);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache6F, true);
		string name30 = "m_waypointUIPrefab";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_waypointUIPrefab);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_waypointUIPrefab);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache71, true);
		string name31 = "m_waypoint2UIPrefab";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_waypoint2UIPrefab);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_waypoint2UIPrefab);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache73, true);
		string name32 = "m_eventUIPrefab";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_eventUIPrefab);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_eventUIPrefab);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache75, true);
		string name33 = "m_playerUIPrefab";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_playerUIPrefab);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_playerUIPrefab);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache77, true);
		string name34 = "m_worldScenarioUIController";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_worldScenarioUIController);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_worldScenarioUIController);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache79, true);
		string name35 = "m_graphicPool";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_graphicPool);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_graphicPool);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7B, true);
		string name36 = "m_fxPool";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_fxPool);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_fxPool);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7D, true);
		string name37 = "m_fxPlayer";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_m_fxPlayer);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_m_fxPlayer);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache7F, true);
		string name38 = "WorldCamera";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_WorldCamera);
		}
		LuaObject.addMember(l, name38, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache80, null, true);
		string name39 = "State";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_State);
		}
		LuaObject.addMember(l, name39, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache81, null, true);
		string name40 = "EnableDebugDraw";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_EnableDebugDraw);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.set_EnableDebugDraw);
		}
		LuaObject.addMember(l, name40, get38, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache83, true);
		string name41 = "GraphicRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_GraphicRoot);
		}
		LuaObject.addMember(l, name41, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache84, null, true);
		string name42 = "WorldUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_WorldUIRoot);
		}
		LuaObject.addMember(l, name42, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache85, null, true);
		string name43 = "WaypointUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_WaypointUIRoot);
		}
		LuaObject.addMember(l, name43, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache86, null, true);
		string name44 = "EventUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_EventUIRoot);
		}
		LuaObject.addMember(l, name44, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache87, null, true);
		string name45 = "PlayerUIRoot";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_PlayerUIRoot);
		}
		LuaObject.addMember(l, name45, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache88, null, true);
		string name46 = "WaypointUIPrefab";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_WaypointUIPrefab);
		}
		LuaObject.addMember(l, name46, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache89, null, true);
		string name47 = "Waypoint2UIPrefab";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_Waypoint2UIPrefab);
		}
		LuaObject.addMember(l, name47, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8A, null, true);
		string name48 = "EventUIPrefab";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_EventUIPrefab);
		}
		LuaObject.addMember(l, name48, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8B, null, true);
		string name49 = "PlayerUIPrefab";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_PlayerUIPrefab);
		}
		LuaObject.addMember(l, name49, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8C, null, true);
		string name50 = "FxPlayer";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_FxPlayer);
		}
		LuaObject.addMember(l, name50, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8D, null, true);
		string name51 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_ConfigDataLoader);
		}
		LuaObject.addMember(l, name51, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8E, null, true);
		string name52 = "ClientWorldListener";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_ClientWorldListener);
		}
		LuaObject.addMember(l, name52, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache8F, null, true);
		string name53 = "PlayerContext";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_PlayerContext);
		}
		LuaObject.addMember(l, name53, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache90, null, true);
		string name54 = "WorldMapInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.get_WorldMapInfo);
		}
		LuaObject.addMember(l, name54, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache91, null, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorld.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientWorld.<>f__mg$cache92, typeof(ClientWorld));
	}

	// Token: 0x04010962 RID: 67938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010963 RID: 67939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010964 RID: 67940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010965 RID: 67941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010966 RID: 67942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010967 RID: 67943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010968 RID: 67944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010969 RID: 67945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401096A RID: 67946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401096B RID: 67947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401096C RID: 67948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401096D RID: 67949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401096E RID: 67950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401096F RID: 67951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010970 RID: 67952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010971 RID: 67953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010972 RID: 67954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010973 RID: 67955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010974 RID: 67956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010975 RID: 67957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010976 RID: 67958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010977 RID: 67959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010978 RID: 67960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010979 RID: 67961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401097A RID: 67962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401097B RID: 67963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401097C RID: 67964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401097D RID: 67965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401097E RID: 67966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401097F RID: 67967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010980 RID: 67968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010981 RID: 67969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010982 RID: 67970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010983 RID: 67971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010984 RID: 67972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010985 RID: 67973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010986 RID: 67974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010987 RID: 67975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010988 RID: 67976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010989 RID: 67977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401098A RID: 67978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401098B RID: 67979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401098C RID: 67980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401098D RID: 67981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401098E RID: 67982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401098F RID: 67983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010990 RID: 67984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010991 RID: 67985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010992 RID: 67986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010993 RID: 67987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010994 RID: 67988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010995 RID: 67989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010996 RID: 67990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010997 RID: 67991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010998 RID: 67992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010999 RID: 67993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401099A RID: 67994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401099B RID: 67995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401099C RID: 67996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401099D RID: 67997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401099E RID: 67998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401099F RID: 67999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040109A0 RID: 68000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040109A1 RID: 68001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040109A2 RID: 68002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040109A3 RID: 68003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040109A4 RID: 68004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040109A5 RID: 68005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040109A6 RID: 68006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040109A7 RID: 68007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040109A8 RID: 68008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040109A9 RID: 68009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040109AA RID: 68010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040109AB RID: 68011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040109AC RID: 68012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040109AD RID: 68013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040109AE RID: 68014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040109AF RID: 68015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040109B0 RID: 68016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040109B1 RID: 68017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040109B2 RID: 68018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040109B3 RID: 68019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040109B4 RID: 68020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040109B5 RID: 68021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040109B6 RID: 68022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040109B7 RID: 68023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040109B8 RID: 68024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040109B9 RID: 68025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040109BA RID: 68026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040109BB RID: 68027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040109BC RID: 68028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040109BD RID: 68029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040109BE RID: 68030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040109BF RID: 68031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040109C0 RID: 68032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040109C1 RID: 68033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040109C2 RID: 68034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040109C3 RID: 68035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040109C4 RID: 68036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040109C5 RID: 68037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040109C6 RID: 68038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040109C7 RID: 68039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040109C8 RID: 68040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040109C9 RID: 68041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040109CA RID: 68042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040109CB RID: 68043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040109CC RID: 68044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040109CD RID: 68045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040109CE RID: 68046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040109CF RID: 68047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040109D0 RID: 68048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040109D1 RID: 68049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040109D2 RID: 68050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040109D3 RID: 68051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040109D4 RID: 68052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040109D5 RID: 68053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040109D6 RID: 68054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040109D7 RID: 68055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040109D8 RID: 68056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040109D9 RID: 68057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040109DA RID: 68058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040109DB RID: 68059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040109DC RID: 68060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040109DD RID: 68061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040109DE RID: 68062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040109DF RID: 68063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040109E0 RID: 68064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040109E1 RID: 68065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040109E2 RID: 68066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040109E3 RID: 68067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x040109E4 RID: 68068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x040109E5 RID: 68069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x040109E6 RID: 68070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x040109E7 RID: 68071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x040109E8 RID: 68072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x040109E9 RID: 68073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x040109EA RID: 68074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040109EB RID: 68075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040109EC RID: 68076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040109ED RID: 68077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040109EE RID: 68078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040109EF RID: 68079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040109F0 RID: 68080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040109F1 RID: 68081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040109F2 RID: 68082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040109F3 RID: 68083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040109F4 RID: 68084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;
}
