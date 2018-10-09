using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Art;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200097F RID: 2431
	[HotFix]
	public class ClientWorld : IFxEventListener
	{
		// Token: 0x06008AEA RID: 35562 RVA: 0x002879CC File Offset: 0x00285BCC
		public ClientWorld()
		{
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_randomNumber = new RandomNumber();
			this.m_worldCamera = new WorldCamera();
			this.m_pathfinder = new WorldPathfinder();
			this.m_playerActors = new List<ClientWorldPlayerActor>();
			this.m_eventActors = new List<ClientWorldEventActor>();
			this.m_waypoints = new List<ClientWorldWaypoint>();
			this.m_regions = new List<ClientWorldRegion>();
			this.m_graphicPool = new GraphicPool(false);
			this.m_fxPool = new GraphicPool(true);
			this.m_fxPlayer = new FxPlayer(this.m_fxPool);
			this.m_state = ClientWorldState.None;
			this.m_frameCount = 0;
			this.m_timeScale = (this.m_globalTimeScale = 1f);
			this.SetTimeScale(1f);
			GlobalFxEventListener.Instance = this;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06008AEB RID: 35563 RVA: 0x00287B08 File Offset: 0x00285D08
		public void Dispose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Dispose_hotfix != null)
			{
				this.m_Dispose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Clear();
			this.ClearBackground();
			if (this.m_fxPlayer != null)
			{
				this.m_fxPlayer.Clear();
				this.m_fxPlayer = null;
			}
			if (this.m_graphicPool != null)
			{
				this.m_graphicPool.Clear();
				this.m_graphicPool = null;
			}
			if (this.m_fxPool != null)
			{
				this.m_fxPool.Clear();
				this.m_fxPool = null;
			}
			if (this.m_pathfinder != null)
			{
				this.m_pathfinder.Dispose();
				this.m_pathfinder = null;
			}
			this.m_randomNumber = null;
			this.m_worldCamera = null;
			this.m_playerActors = null;
			this.m_eventActors = null;
			this.m_waypoints = null;
			this.m_regions = null;
			GlobalFxEventListener.Instance = null;
		}

		// Token: 0x06008AEC RID: 35564 RVA: 0x00287C18 File Offset: 0x00285E18
		public void Initialize(IClientWorldListener clientWorldListener, GameObject worldRoot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeIClientWorldListenerGameObject_hotfix != null)
			{
				this.m_InitializeIClientWorldListenerGameObject_hotfix.call(new object[]
				{
					this,
					clientWorldListener,
					worldRoot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorldListener = clientWorldListener;
			this.m_worldRoot = worldRoot;
			this.m_graphicRoot = Utility.FindChildGameObject(worldRoot, "Graphics", true);
			this.m_mapRoot = Utility.FindChildGameObject(worldRoot, "Map", true);
			this.m_mapRoot.SetActive(false);
			this.m_worldUIRoot = Utility.FindChildGameObject(worldRoot, "Canvas", true);
			this.m_waypointUIRoot = Utility.FindChildGameObject(this.m_worldUIRoot, "Waypoints", true);
			this.m_eventUIRoot = Utility.FindChildGameObject(this.m_worldUIRoot, "Events", true);
			this.m_playerUIRoot = Utility.FindChildGameObject(this.m_worldUIRoot, "Players", true);
			GameObject gameObject = Utility.FindChildGameObject(this.m_worldUIRoot, "Prefabs", true);
			gameObject.SetActive(false);
			this.m_waypointUIPrefab = Utility.FindChildGameObject(gameObject, "Waypoint", true);
			this.m_waypoint2UIPrefab = Utility.FindChildGameObject(gameObject, "Waypoint2", true);
			this.m_eventUIPrefab = Utility.FindChildGameObject(gameObject, "Event", true);
			this.m_playerUIPrefab = Utility.FindChildGameObject(gameObject, "Player", true);
			GameObject gameObject2 = Utility.FindChildGameObject(this.m_worldUIRoot, "Scenario", true);
			this.m_worldScenarioUIController = GameObjectUtility.AddControllerToGameObject<WorldScenarioUIController>(gameObject2);
			Canvas canvas = gameObject2.AddComponent<Canvas>();
			canvas.overrideSorting = true;
			canvas.sortingOrder = 4;
			this.m_worldCamera.Initialize(Utility.FindChildGameObject(worldRoot, "Camera", true));
			GameObject gameObject3 = Utility.FindChildGameObject(worldRoot, "GraphicPool", true);
			gameObject3.SetActive(false);
			this.m_graphicPool.SetDefaultParent(gameObject3);
			GameObject gameObject4 = Utility.FindChildGameObject(worldRoot, "FxPool", true);
			gameObject4.SetActive(false);
			this.m_fxPool.SetDefaultParent(gameObject4);
			this.m_fxPlayer.SetDefaultParent(this.m_graphicRoot);
			this.m_state = ClientWorldState.Initialized;
		}

		// Token: 0x06008AED RID: 35565 RVA: 0x00287E34 File Offset: 0x00286034
		public void OnWaypointUpdate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWaypointUpdate_hotfix != null)
			{
				this.m_OnWaypointUpdate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateRegionState();
			this.UpdateWaypointState();
			ClientWorldPlayerActor playerActor = this.GetPlayerActor();
			playerActor.Locate(this.m_playerContext.GetPlayerCurrentWaypointInfo(), playerActor.Direction);
			this.UpdateEventActorState();
		}

		// Token: 0x06008AEE RID: 35566 RVA: 0x00287EC4 File Offset: 0x002860C4
		public void OnPlayerIconUpdate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerIconUpdate_hotfix != null)
			{
				this.m_OnPlayerIconUpdate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_playerContext.GetHero(this.m_playerContext.GetPlayerHeadPortrait());
			if (hero != null)
			{
				HeroJob activeJob = hero.GetActiveJob();
				this.GetPlayerActor().CreateGraphic(activeJob.JobConnectionInfo, activeJob.GetModelSkinResourceInfo());
			}
		}

		// Token: 0x06008AEF RID: 35567 RVA: 0x00287F60 File Offset: 0x00286160
		public void Tick(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickSingle_hotfix != null)
			{
				this.m_TickSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_state == ClientWorldState.None)
			{
				return;
			}
			if (dt > 0f)
			{
				this.m_worldCamera.Update(dt);
				float num = 0.0333333351f;
				this.m_worldTickTime += dt;
				while (this.m_worldTickTime >= num)
				{
					this.TickClientWorld();
					this.m_worldTickTime -= num;
				}
				this.TickGraphic(dt);
				this.m_fxPlayer.Tick(dt);
			}
			this.Draw();
		}

		// Token: 0x06008AF0 RID: 35568 RVA: 0x00288048 File Offset: 0x00286248
		private void TickClientWorld()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickClientWorld_hotfix != null)
			{
				this.m_TickClientWorld_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isPaused)
			{
				return;
			}
			if (this.m_state != ClientWorldState.None)
			{
				if (this.m_state != ClientWorldState.Play)
				{
					if (this.m_state != ClientWorldState.Stop)
					{
						if (this.m_state == ClientWorldState.End)
						{
						}
					}
				}
			}
			EntityList.Tick<ClientWorldPlayerActor>(this.m_playerActors);
			EntityList.RemoveDeleted<ClientWorldPlayerActor>(this.m_playerActors);
			EntityList.Tick<ClientWorldEventActor>(this.m_eventActors);
			EntityList.RemoveDeleted<ClientWorldEventActor>(this.m_eventActors);
			EntityList.Tick<ClientWorldWaypoint>(this.m_waypoints);
			EntityList.RemoveDeleted<ClientWorldWaypoint>(this.m_waypoints);
			EntityList.Tick<ClientWorldRegion>(this.m_regions);
			EntityList.RemoveDeleted<ClientWorldRegion>(this.m_regions);
			this.m_frameCount++;
		}

		// Token: 0x06008AF1 RID: 35569 RVA: 0x00288158 File Offset: 0x00286358
		private void SetTimeScale(float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTimeScaleSingle_hotfix != null)
			{
				this.m_SetTimeScaleSingle_hotfix.call(new object[]
				{
					this,
					scale
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_timeScale = scale;
			this.UpdateFinalTimeScale();
		}

		// Token: 0x06008AF2 RID: 35570 RVA: 0x002881D8 File Offset: 0x002863D8
		public void SetGlobalTimeScale(float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGlobalTimeScaleSingle_hotfix != null)
			{
				this.m_SetGlobalTimeScaleSingle_hotfix.call(new object[]
				{
					this,
					scale
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_globalTimeScale = scale;
			this.UpdateFinalTimeScale();
		}

		// Token: 0x06008AF3 RID: 35571 RVA: 0x00288258 File Offset: 0x00286458
		private void UpdateFinalTimeScale()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateFinalTimeScale_hotfix != null)
			{
				this.m_UpdateFinalTimeScale_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float timeScale = this.m_timeScale * this.m_globalTimeScale;
			SystemUtility.SetTimeScale(timeScale);
		}

		// Token: 0x06008AF4 RID: 35572 RVA: 0x002882CC File Offset: 0x002864CC
		private void TickGraphic(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickGraphicSingle_hotfix != null)
			{
				this.m_TickGraphicSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isPaused)
			{
				dt = 0f;
			}
			EntityList.TickGraphic<ClientWorldPlayerActor>(this.m_playerActors, dt);
			EntityList.TickGraphic<ClientWorldEventActor>(this.m_eventActors, dt);
			EntityList.TickGraphic<ClientWorldWaypoint>(this.m_waypoints, dt);
			EntityList.TickGraphic<ClientWorldRegion>(this.m_regions, dt);
		}

		// Token: 0x06008AF5 RID: 35573 RVA: 0x00288380 File Offset: 0x00286580
		private void Draw()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Draw_hotfix != null)
			{
				this.m_Draw_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_enableDebugDraw)
			{
				return;
			}
			EntityList.Draw<ClientWorldPlayerActor>(this.m_playerActors);
			EntityList.Draw<ClientWorldEventActor>(this.m_eventActors);
			EntityList.Draw<ClientWorldWaypoint>(this.m_waypoints);
			EntityList.Draw<ClientWorldRegion>(this.m_regions);
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x00288418 File Offset: 0x00286618
		public void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EntityList.RemoveAll<ClientWorldPlayerActor>(this.m_playerActors);
			EntityList.RemoveAll<ClientWorldEventActor>(this.m_eventActors);
			EntityList.RemoveAll<ClientWorldWaypoint>(this.m_waypoints);
			EntityList.RemoveAll<ClientWorldRegion>(this.m_regions);
			this.m_entityIdCounter = 0;
			this.m_state = ClientWorldState.None;
			this.m_frameCount = 0;
			this.m_worldTickTime = 0f;
			this.m_fxPlayer.Clear();
		}

		// Token: 0x06008AF7 RID: 35575 RVA: 0x002884D0 File Offset: 0x002866D0
		public void Start(ConfigDataWorldMapInfo worldMapInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartConfigDataWorldMapInfo_hotfix != null)
			{
				this.m_StartConfigDataWorldMapInfo_hotfix.call(new object[]
				{
					this,
					worldMapInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (worldMapInfo == null)
			{
				return;
			}
			this.Clear();
			this.m_worldMapInfo = worldMapInfo;
			this.CreateBackground(worldMapInfo, this.m_mapRoot);
			this.m_mapRoot.SetActive(true);
			this.m_state = ClientWorldState.Play;
			this.m_isPaused = false;
			this.m_randomNumber.SetSeed(12345);
			List<ConfigDataWaypointInfo> list = new List<ConfigDataWaypointInfo>();
			foreach (ConfigDataRegionInfo configDataRegionInfo in this.m_worldMapInfo.m_regionInfos)
			{
				ClientWorldRegion clientWorldRegion = this.CreateRegion(configDataRegionInfo);
				clientWorldRegion.SetOpen(this.m_playerContext.IsRegionOpen(clientWorldRegion.RegionInfo.ID));
				foreach (ConfigDataWaypointInfo item in configDataRegionInfo.m_waypointInfos)
				{
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
			}
			foreach (ConfigDataWaypointInfo configDataWaypointInfo in list)
			{
				ClientWorldWaypoint clientWorldWaypoint = this.CreateWaypoint(configDataWaypointInfo);
				WayPointStatus waypointStatus = this.m_playerContext.GetWaypointStatus(configDataWaypointInfo.ID);
				clientWorldWaypoint.SetStatus(waypointStatus);
			}
			ClientWorldPlayerActor clientWorldPlayerActor = this.CreatePlayerActor(this.m_playerContext.GetPlayerCurrentWaypointInfo(), -1);
			this.UpdateEventActorState();
			this.UpdateCurrentScenario();
			this.m_worldCamera.Start(this.m_worldMapInfo);
			this.m_worldCamera.Look(clientWorldPlayerActor.Position);
		}

		// Token: 0x06008AF8 RID: 35576 RVA: 0x002886C8 File Offset: 0x002868C8
		public void Stop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Stop_hotfix != null)
			{
				this.m_Stop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_state = ClientWorldState.Stop;
		}

		// Token: 0x06008AF9 RID: 35577 RVA: 0x00288730 File Offset: 0x00286930
		public void Pause(bool pause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PauseBoolean_hotfix != null)
			{
				this.m_PauseBoolean_hotfix.call(new object[]
				{
					this,
					pause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isPaused = pause;
			foreach (ClientWorldPlayerActor clientWorldPlayerActor in this.m_playerActors)
			{
				clientWorldPlayerActor.Pause(pause);
			}
			foreach (ClientWorldEventActor clientWorldEventActor in this.m_eventActors)
			{
				clientWorldEventActor.Pause(pause);
			}
			foreach (ClientWorldWaypoint clientWorldWaypoint in this.m_waypoints)
			{
				clientWorldWaypoint.Pause(pause);
			}
			foreach (ClientWorldRegion clientWorldRegion in this.m_regions)
			{
				clientWorldRegion.Pause(pause);
			}
		}

		// Token: 0x06008AFA RID: 35578 RVA: 0x002888E0 File Offset: 0x00286AE0
		public void ShowWorld(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowWorldBoolean_hotfix != null)
			{
				this.m_ShowWorldBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_worldRoot.SetActive(show);
			this.m_worldCamera.EnableTouchMove(show);
			if (!show)
			{
				this.m_fxPlayer.DeleteAutoDeleteFxs();
			}
		}

		// Token: 0x06008AFB RID: 35579 RVA: 0x0028897C File Offset: 0x00286B7C
		private ClientWorldRegion CreateRegion(ConfigDataRegionInfo regionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateRegionConfigDataRegionInfo_hotfix != null)
			{
				return (ClientWorldRegion)this.m_CreateRegionConfigDataRegionInfo_hotfix.call(new object[]
				{
					this,
					regionInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (regionInfo == null)
			{
				return null;
			}
			ClientWorldRegion clientWorldRegion = new ClientWorldRegion();
			clientWorldRegion.Initialize(this, regionInfo);
			this.m_regions.Add(clientWorldRegion);
			return clientWorldRegion;
		}

		// Token: 0x06008AFC RID: 35580 RVA: 0x00288A1C File Offset: 0x00286C1C
		private ClientWorldWaypoint CreateWaypoint(ConfigDataWaypointInfo waypointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateWaypointConfigDataWaypointInfo_hotfix != null)
			{
				return (ClientWorldWaypoint)this.m_CreateWaypointConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					waypointInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (waypointInfo == null)
			{
				return null;
			}
			ClientWorldWaypoint clientWorldWaypoint = new ClientWorldWaypoint();
			clientWorldWaypoint.Initialize(this, waypointInfo);
			GameObject gameObject = Utility.FindChildGameObject(this.m_backgroundWaypointsRoot, waypointInfo.ID.ToString("D2"), true);
			if (gameObject != null)
			{
				clientWorldWaypoint.Locate(gameObject.transform.localPosition);
			}
			this.m_waypoints.Add(clientWorldWaypoint);
			return clientWorldWaypoint;
		}

		// Token: 0x06008AFD RID: 35581 RVA: 0x00288B00 File Offset: 0x00286D00
		private ClientWorldPlayerActor CreatePlayerActor(ConfigDataWaypointInfo waypointInfo, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreatePlayerActorConfigDataWaypointInfoInt32_hotfix != null)
			{
				return (ClientWorldPlayerActor)this.m_CreatePlayerActorConfigDataWaypointInfoInt32_hotfix.call(new object[]
				{
					this,
					waypointInfo,
					dir
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientWorldPlayerActor clientWorldPlayerActor = new ClientWorldPlayerActor();
			clientWorldPlayerActor.Initialize(this);
			Hero hero = this.m_playerContext.GetHero(this.m_playerContext.GetPlayerHeadPortrait());
			if (hero != null)
			{
				HeroJob activeJob = hero.GetActiveJob();
				clientWorldPlayerActor.CreateGraphic(activeJob.JobConnectionInfo, activeJob.GetModelSkinResourceInfo());
			}
			if (waypointInfo != null)
			{
				clientWorldPlayerActor.Locate(waypointInfo, dir);
			}
			this.m_playerActors.Add(clientWorldPlayerActor);
			return clientWorldPlayerActor;
		}

		// Token: 0x06008AFE RID: 35582 RVA: 0x00288BEC File Offset: 0x00286DEC
		private ClientWorldEventActor CreateEventActor(ConfigDataEventInfo eventInfo, ConfigDataWaypointInfo waypointInfo, int dir, RandomEvent randomEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateEventActorConfigDataEventInfoConfigDataWaypointInfoInt32RandomEvent_hotfix != null)
			{
				return (ClientWorldEventActor)this.m_CreateEventActorConfigDataEventInfoConfigDataWaypointInfoInt32RandomEvent_hotfix.call(new object[]
				{
					this,
					eventInfo,
					waypointInfo,
					dir,
					randomEvent
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientWorldEventActor clientWorldEventActor = new ClientWorldEventActor();
			clientWorldEventActor.Initialize(this, eventInfo, randomEvent);
			if (waypointInfo != null)
			{
				clientWorldEventActor.Locate(waypointInfo, dir);
			}
			this.m_eventActors.Add(clientWorldEventActor);
			return clientWorldEventActor;
		}

		// Token: 0x06008AFF RID: 35583 RVA: 0x00288CC4 File Offset: 0x00286EC4
		private void UpdateRegionState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRegionState_hotfix != null)
			{
				this.m_UpdateRegionState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientWorldRegion clientWorldRegion in this.m_regions)
			{
				bool flag = this.m_playerContext.IsRegionOpen(clientWorldRegion.RegionInfo.ID);
				if (flag != clientWorldRegion.IsOpened())
				{
					clientWorldRegion.SetOpen(flag);
				}
			}
		}

		// Token: 0x06008B00 RID: 35584 RVA: 0x00288D98 File Offset: 0x00286F98
		private void UpdateWaypointState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateWaypointState_hotfix != null)
			{
				this.m_UpdateWaypointState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientWorldWaypoint clientWorldWaypoint in this.m_waypoints)
			{
				WayPointStatus waypointStatus = this.m_playerContext.GetWaypointStatus(clientWorldWaypoint.WaypointInfo.ID);
				if (waypointStatus != clientWorldWaypoint.GetStatus())
				{
					clientWorldWaypoint.SetStatus(waypointStatus);
				}
			}
		}

		// Token: 0x06008B01 RID: 35585 RVA: 0x00288E6C File Offset: 0x0028706C
		public void UpdateEventActorState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateEventActorState_hotfix != null)
			{
				this.m_UpdateEventActorState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientWorldPlayerActor playerActor = this.GetPlayerActor();
			bool flag = false;
			foreach (ClientWorldWaypoint clientWorldWaypoint in this.m_waypoints)
			{
				ConfigDataEventInfo currentWaypointEventInfo = this.m_playerContext.GetCurrentWaypointEventInfo(clientWorldWaypoint.WaypointInfo.ID);
				ClientWorldEventActor clientWorldEventActor = this.GetEventActorAt(clientWorldWaypoint.WaypointInfo.ID);
				if (currentWaypointEventInfo != null)
				{
					if (clientWorldEventActor != null && clientWorldEventActor.EventInfo != currentWaypointEventInfo)
					{
						clientWorldEventActor.DeleteMe();
						clientWorldEventActor = null;
					}
					if (clientWorldEventActor == null)
					{
						int dir = (clientWorldWaypoint.Position.x > playerActor.Position.x) ? -1 : 1;
						RandomEvent currentWaypointRandomEvent = this.m_playerContext.GetCurrentWaypointRandomEvent(clientWorldWaypoint.WaypointInfo.ID);
						clientWorldEventActor = this.CreateEventActor(currentWaypointEventInfo, clientWorldWaypoint.WaypointInfo, dir, currentWaypointRandomEvent);
						flag = true;
					}
					clientWorldWaypoint.SetCanClick(false);
				}
				else
				{
					if (clientWorldEventActor != null)
					{
						clientWorldEventActor.DeleteMe();
						flag = true;
					}
					WayPointStatus status = clientWorldWaypoint.GetStatus();
					ConfigDataScenarioInfo currentScenarioInfo = this.m_playerContext.GetCurrentScenarioInfo();
					clientWorldWaypoint.SetCanClick(status == WayPointStatus.Public || status == WayPointStatus.Arrived || (currentScenarioInfo != null && currentScenarioInfo.m_waypointInfo == clientWorldWaypoint.WaypointInfo));
				}
			}
			if (flag)
			{
				List<ClientWorldEventActor> list = new List<ClientWorldEventActor>();
				list.AddRange(this.m_eventActors);
				List<ClientWorldEventActor> list2 = list;
				if (ClientWorld.<>f__mg$cache0 == null)
				{
					ClientWorld.<>f__mg$cache0 = new Comparison<ClientWorldEventActor>(ClientWorld.CompareEventActorPositionY);
				}
				list2.Sort(ClientWorld.<>f__mg$cache0);
				for (int i = 0; i < list.Count; i++)
				{
					list[i].SetUISiblingIndex(i);
				}
			}
		}

		// Token: 0x06008B02 RID: 35586 RVA: 0x002890AC File Offset: 0x002872AC
		private static int CompareEventActorPositionY(ClientWorldEventActor a0, ClientWorldEventActor a1)
		{
			if (a0.Position.y > a1.Position.y)
			{
				return -1;
			}
			if (a0.Position.y < a1.Position.y)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06008B03 RID: 35587 RVA: 0x00289100 File Offset: 0x00287300
		private static int CompareWaypointPositionY(ClientWorldWaypoint a0, ClientWorldWaypoint a1)
		{
			if (a0.Position.y > a1.Position.y)
			{
				return -1;
			}
			if (a0.Position.y < a1.Position.y)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06008B04 RID: 35588 RVA: 0x00289154 File Offset: 0x00287354
		public void UpdateCurrentScenario()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateCurrentScenario_hotfix != null)
			{
				this.m_UpdateCurrentScenario_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataScenarioInfo currentScenarioInfo = this.m_playerContext.GetCurrentScenarioInfo();
			if (currentScenarioInfo != null)
			{
				this.m_worldScenarioUIController.gameObject.SetActive(true);
				ClientWorldWaypoint waypoint = this.GetWaypoint(currentScenarioInfo.Waypoint_ID);
				if (waypoint != null)
				{
					this.m_worldScenarioUIController.transform.localPosition = waypoint.Position;
				}
			}
			else
			{
				this.m_worldScenarioUIController.gameObject.SetActive(false);
			}
			foreach (ClientWorldWaypoint clientWorldWaypoint in this.m_waypoints)
			{
				clientWorldWaypoint.SetScenarioState(clientWorldWaypoint.WaypointInfo, currentScenarioInfo);
			}
		}

		// Token: 0x06008B05 RID: 35589 RVA: 0x00289270 File Offset: 0x00287470
		public ClientWorldRegion GetRegion(int regionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRegionInt32_hotfix != null)
			{
				return (ClientWorldRegion)this.m_GetRegionInt32_hotfix.call(new object[]
				{
					this,
					regionId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientWorldRegion clientWorldRegion in this.m_regions)
			{
				if (clientWorldRegion.RegionInfo.ID == regionId)
				{
					return clientWorldRegion;
				}
			}
			return null;
		}

		// Token: 0x06008B06 RID: 35590 RVA: 0x00289350 File Offset: 0x00287550
		public ClientWorldWaypoint GetWaypoint(int waypointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetWaypointInt32_hotfix != null)
			{
				return (ClientWorldWaypoint)this.m_GetWaypointInt32_hotfix.call(new object[]
				{
					this,
					waypointId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientWorldWaypoint clientWorldWaypoint in this.m_waypoints)
			{
				if (clientWorldWaypoint.WaypointInfo.ID == waypointId)
				{
					return clientWorldWaypoint;
				}
			}
			return null;
		}

		// Token: 0x06008B07 RID: 35591 RVA: 0x00289430 File Offset: 0x00287630
		public ClientWorldEventActor GetEventActorAt(int waypointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEventActorAtInt32_hotfix != null)
			{
				return (ClientWorldEventActor)this.m_GetEventActorAtInt32_hotfix.call(new object[]
				{
					this,
					waypointId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientWorldEventActor clientWorldEventActor in this.m_eventActors)
			{
				if (clientWorldEventActor.LocateWaypointInfo.ID == waypointId)
				{
					return clientWorldEventActor;
				}
			}
			return null;
		}

		// Token: 0x06008B08 RID: 35592 RVA: 0x00289510 File Offset: 0x00287710
		public ClientWorldEventActor GetEventActoryByEventId(int eventId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEventActoryByEventIdInt32_hotfix != null)
			{
				return (ClientWorldEventActor)this.m_GetEventActoryByEventIdInt32_hotfix.call(new object[]
				{
					this,
					eventId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientWorldEventActor clientWorldEventActor in this.m_eventActors)
			{
				if (clientWorldEventActor.EventInfo.ID == eventId)
				{
					return clientWorldEventActor;
				}
			}
			return null;
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x002895F0 File Offset: 0x002877F0
		public List<ClientWorldEventActor> GetEventActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEventActors_hotfix != null)
			{
				return (List<ClientWorldEventActor>)this.m_GetEventActors_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_eventActors;
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x00289664 File Offset: 0x00287864
		public ClientWorldPlayerActor GetPlayerActor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerActor_hotfix != null)
			{
				return (ClientWorldPlayerActor)this.m_GetPlayerActor_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerActors.Count > 0)
			{
				return this.m_playerActors[0];
			}
			return null;
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x002896F0 File Offset: 0x002878F0
		public void OnWaypointClick(ClientWorldWaypoint wp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWaypointClickClientWorldWaypoint_hotfix != null)
			{
				this.m_OnWaypointClickClientWorldWaypoint_hotfix.call(new object[]
				{
					this,
					wp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorldListener.OnWaypointClick(wp.WaypointInfo);
		}

		// Token: 0x06008B0C RID: 35596 RVA: 0x00289774 File Offset: 0x00287974
		public void OnEventActorClick(ClientWorldEventActor a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEventActorClickClientWorldEventActor_hotfix != null)
			{
				this.m_OnEventActorClickClientWorldEventActor_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorldListener.OnWaypointClick(a.LocateWaypointInfo);
		}

		// Token: 0x06008B0D RID: 35597 RVA: 0x002897F8 File Offset: 0x002879F8
		public GenericGraphic CreateGraphic(string assetName, float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGraphicStringSingle_hotfix != null)
			{
				return (GenericGraphic)this.m_CreateGraphicStringSingle_hotfix.call(new object[]
				{
					this,
					assetName,
					scale
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GenericGraphic genericGraphic = this.m_graphicPool.Create(assetName);
			if (genericGraphic != null)
			{
				genericGraphic.SetContainer(null);
				genericGraphic.SetFxPlayer(this.m_fxPlayer);
				genericGraphic.SetParent(this.m_graphicRoot);
				genericGraphic.SetPrefabScale(scale);
			}
			return genericGraphic;
		}

		// Token: 0x06008B0E RID: 35598 RVA: 0x002898C0 File Offset: 0x00287AC0
		public void DestroyGraphic(GenericGraphic graphic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyGraphicGenericGraphic_hotfix != null)
			{
				this.m_DestroyGraphicGenericGraphic_hotfix.call(new object[]
				{
					this,
					graphic
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_graphicPool.Destroy(graphic);
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x0028993C File Offset: 0x00287B3C
		private CameraBase GetCamera()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCamera_hotfix != null)
			{
				return (CameraBase)this.m_GetCamera_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_worldCamera;
		}

		// Token: 0x06008B10 RID: 35600 RVA: 0x002899B0 File Offset: 0x00287BB0
		public Vector3 GetCameraPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCameraPosition_hotfix != null)
			{
				return (Vector3)this.m_GetCameraPosition_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_worldCamera.Camera.transform.position;
		}

		// Token: 0x06008B11 RID: 35601 RVA: 0x00289A34 File Offset: 0x00287C34
		public static Vector3 ComputeActorPosition(Vector2 pos, float zoffset)
		{
			Vector3 vector = new Vector3(pos.x, pos.y, 0f);
			vector += ClientWorldConst.FaceCameraRotation * new Vector3(0f, 0f, zoffset);
			return vector;
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x00289A80 File Offset: 0x00287C80
		public bool IsCulled(Vector2 p, bool isCombat)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCulledVector2Boolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCulledVector2Boolean_hotfix.call(new object[]
				{
					this,
					p,
					isCombat
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_worldCamera.IsCulled(p);
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x00289B18 File Offset: 0x00287D18
		public bool IsCulled(Vector2 bmin, Vector2 bmax, bool isCombat)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCulledVector2Vector2Boolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCulledVector2Vector2Boolean_hotfix.call(new object[]
				{
					this,
					bmin,
					bmax,
					isCombat
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_worldCamera.IsCulled(bmin, bmax);
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x00289BC4 File Offset: 0x00287DC4
		public int GetNextEntityId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNextEntityId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetNextEntityId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_entityIdCounter++;
			if (this.m_entityIdCounter <= 0)
			{
				this.m_entityIdCounter = 1;
			}
			return this.m_entityIdCounter;
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x00289C58 File Offset: 0x00287E58
		public void PlayScreenEffect(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayScreenEffectString_hotfix != null)
			{
				this.m_PlayScreenEffectString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorldListener.OnScreenEffect(name);
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x00289CD4 File Offset: 0x00287ED4
		private void CreateBackground(ConfigDataWorldMapInfo worldMapInfo, GameObject parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateBackgroundConfigDataWorldMapInfoGameObject_hotfix != null)
			{
				this.m_CreateBackgroundConfigDataWorldMapInfoGameObject_hotfix.call(new object[]
				{
					this,
					worldMapInfo,
					parent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearBackground();
			if (worldMapInfo == null || parent == null)
			{
				return;
			}
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(worldMapInfo.WorldMap);
			if (asset != null)
			{
				this.m_background = UnityEngine.Object.Instantiate<GameObject>(asset, parent.transform, false);
				this.m_background.SetActive(true);
				this.m_backgroundWaypointsRoot = Utility.FindChildGameObject(this.m_background, "Waypoints", true);
				if (this.m_backgroundWaypointsRoot != null)
				{
					this.m_backgroundWaypointsRoot.SetActive(false);
				}
				this.m_backgroundRegionsRoot = Utility.FindChildGameObject(this.m_background, "Regions", true);
				if (this.m_backgroundRegionsRoot != null)
				{
					this.m_backgroundRegionsRoot.SetActive(false);
				}
			}
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x00289E14 File Offset: 0x00288014
		private void ClearBackground()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearBackground_hotfix != null)
			{
				this.m_ClearBackground_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_background != null)
			{
				UnityEngine.Object.Destroy(this.m_background);
				this.m_background = null;
				this.m_backgroundWaypointsRoot = null;
				this.m_backgroundRegionsRoot = null;
			}
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x00289EA8 File Offset: 0x002880A8
		public void PlaySound(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySoundString_hotfix != null)
			{
				this.m_PlaySoundString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AudioUtility.PlaySound(name);
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x00289F20 File Offset: 0x00288120
		public void PlaySound(SoundTableId id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySoundSoundTableId_hotfix != null)
			{
				this.m_PlaySoundSoundTableId_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AudioUtility.PlaySound(id);
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x00289F98 File Offset: 0x00288198
		public bool FindPath(int start, int goal, List<int> path, bool checkWaypointStatus)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPathInt32Int32List`1Boolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_FindPathInt32Int32List`1Boolean_hotfix.call(new object[]
				{
					this,
					start,
					goal,
					path,
					checkWaypointStatus
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_pathfinder.FindPath(this, start, goal, path, checkWaypointStatus);
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x0028A058 File Offset: 0x00288258
		public static int FrameToMillisecond(int frame)
		{
			return frame * 1000 / 30;
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x0028A064 File Offset: 0x00288264
		public static int MillisecondToFrame(int ms)
		{
			return (ms * 30 + 500) / 1000;
		}

		// Token: 0x06008B1D RID: 35613 RVA: 0x0028A078 File Offset: 0x00288278
		public static int MillisecondToFrame1(int ms)
		{
			return Math.Max((ms * 30 + 500) / 1000, 1);
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06008B1E RID: 35614 RVA: 0x0028A090 File Offset: 0x00288290
		public WorldCamera WorldCamera
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_WorldCamera_hotfix != null)
				{
					return (WorldCamera)this.m_get_WorldCamera_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_worldCamera;
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06008B1F RID: 35615 RVA: 0x0028A104 File Offset: 0x00288304
		public ClientWorldState State
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_State_hotfix != null)
				{
					return (ClientWorldState)this.m_get_State_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_state;
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06008B21 RID: 35617 RVA: 0x0028A1F0 File Offset: 0x002883F0
		// (set) Token: 0x06008B20 RID: 35616 RVA: 0x0028A178 File Offset: 0x00288378
		public bool EnableDebugDraw
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_EnableDebugDraw_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_EnableDebugDraw_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_enableDebugDraw;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_EnableDebugDrawBoolean_hotfix != null)
				{
					this.m_set_EnableDebugDrawBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_enableDebugDraw = value;
			}
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06008B22 RID: 35618 RVA: 0x0028A264 File Offset: 0x00288464
		public GameObject GraphicRoot
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GraphicRoot_hotfix != null)
				{
					return (GameObject)this.m_get_GraphicRoot_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_graphicRoot;
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06008B23 RID: 35619 RVA: 0x0028A2D8 File Offset: 0x002884D8
		public GameObject WorldUIRoot
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_WorldUIRoot_hotfix != null)
				{
					return (GameObject)this.m_get_WorldUIRoot_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_worldUIRoot;
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06008B24 RID: 35620 RVA: 0x0028A34C File Offset: 0x0028854C
		public GameObject WaypointUIRoot
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_WaypointUIRoot_hotfix != null)
				{
					return (GameObject)this.m_get_WaypointUIRoot_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_waypointUIRoot;
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x06008B25 RID: 35621 RVA: 0x0028A3C0 File Offset: 0x002885C0
		public GameObject EventUIRoot
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_EventUIRoot_hotfix != null)
				{
					return (GameObject)this.m_get_EventUIRoot_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_eventUIRoot;
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06008B26 RID: 35622 RVA: 0x0028A434 File Offset: 0x00288634
		public GameObject PlayerUIRoot
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PlayerUIRoot_hotfix != null)
				{
					return (GameObject)this.m_get_PlayerUIRoot_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_playerUIRoot;
			}
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06008B27 RID: 35623 RVA: 0x0028A4A8 File Offset: 0x002886A8
		public GameObject WaypointUIPrefab
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_WaypointUIPrefab_hotfix != null)
				{
					return (GameObject)this.m_get_WaypointUIPrefab_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_waypointUIPrefab;
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06008B28 RID: 35624 RVA: 0x0028A51C File Offset: 0x0028871C
		public GameObject Waypoint2UIPrefab
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Waypoint2UIPrefab_hotfix != null)
				{
					return (GameObject)this.m_get_Waypoint2UIPrefab_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_waypoint2UIPrefab;
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06008B29 RID: 35625 RVA: 0x0028A590 File Offset: 0x00288790
		public GameObject EventUIPrefab
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_EventUIPrefab_hotfix != null)
				{
					return (GameObject)this.m_get_EventUIPrefab_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_eventUIPrefab;
			}
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06008B2A RID: 35626 RVA: 0x0028A604 File Offset: 0x00288804
		public GameObject PlayerUIPrefab
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PlayerUIPrefab_hotfix != null)
				{
					return (GameObject)this.m_get_PlayerUIPrefab_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_playerUIPrefab;
			}
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06008B2B RID: 35627 RVA: 0x0028A678 File Offset: 0x00288878
		public FxPlayer FxPlayer
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_FxPlayer_hotfix != null)
				{
					return (FxPlayer)this.m_get_FxPlayer_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_fxPlayer;
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06008B2C RID: 35628 RVA: 0x0028A6EC File Offset: 0x002888EC
		public IConfigDataLoader ConfigDataLoader
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ConfigDataLoader_hotfix != null)
				{
					return (IConfigDataLoader)this.m_get_ConfigDataLoader_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_configDataLoader;
			}
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06008B2D RID: 35629 RVA: 0x0028A760 File Offset: 0x00288960
		public IClientWorldListener ClientWorldListener
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ClientWorldListener_hotfix != null)
				{
					return (IClientWorldListener)this.m_get_ClientWorldListener_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_clientWorldListener;
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06008B2E RID: 35630 RVA: 0x0028A7D4 File Offset: 0x002889D4
		public ProjectLPlayerContext PlayerContext
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PlayerContext_hotfix != null)
				{
					return (ProjectLPlayerContext)this.m_get_PlayerContext_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_playerContext;
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06008B2F RID: 35631 RVA: 0x0028A848 File Offset: 0x00288A48
		public ConfigDataWorldMapInfo WorldMapInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_WorldMapInfo_hotfix != null)
				{
					return (ConfigDataWorldMapInfo)this.m_get_WorldMapInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_worldMapInfo;
			}
		}

		// Token: 0x06008B30 RID: 35632 RVA: 0x0028A8BC File Offset: 0x00288ABC
		public void OnAudio(FxEvent e, AudioClip a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAudioFxEventAudioClip_hotfix != null)
			{
				this.m_OnAudioFxEventAudioClip_hotfix.call(new object[]
				{
					this,
					e,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AudioUtility.PlaySound(a);
		}

		// Token: 0x06008B31 RID: 35633 RVA: 0x0028A944 File Offset: 0x00288B44
		public void OnSound(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoundFxEventString_hotfix != null)
			{
				this.m_OnSoundFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AudioUtility.PlaySound(name);
		}

		// Token: 0x06008B32 RID: 35634 RVA: 0x0028A9CC File Offset: 0x00288BCC
		public void OnCameraEffect(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCameraEffectFxEventString_hotfix != null)
			{
				this.m_OnCameraEffectFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CameraBase camera = this.GetCamera();
			if (camera != null)
			{
				camera.PlayAnimation(name);
			}
		}

		// Token: 0x06008B33 RID: 35635 RVA: 0x0028AA60 File Offset: 0x00288C60
		public void OnScreenEffect(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScreenEffectFxEventString_hotfix != null)
			{
				this.m_OnScreenEffectFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.PlayScreenEffect(name);
		}

		// Token: 0x06008B34 RID: 35636 RVA: 0x0028AAE8 File Offset: 0x00288CE8
		public void OnGeneral(FxEvent e, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGeneralFxEventString_hotfix != null)
			{
				this.m_OnGeneralFxEventString_hotfix.call(new object[]
				{
					this,
					e,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06008B35 RID: 35637 RVA: 0x0028AB68 File Offset: 0x00288D68
		// (set) Token: 0x06008B36 RID: 35638 RVA: 0x0028AB88 File Offset: 0x00288D88
		[DoNotToLua]
		public ClientWorld.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClientWorld.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008B37 RID: 35639 RVA: 0x0028AB94 File Offset: 0x00288D94
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_InitializeIClientWorldListenerGameObject_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_OnWaypointUpdate_hotfix = (luaObj.RawGet("OnWaypointUpdate") as LuaFunction);
					this.m_OnPlayerIconUpdate_hotfix = (luaObj.RawGet("OnPlayerIconUpdate") as LuaFunction);
					this.m_TickSingle_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickClientWorld_hotfix = (luaObj.RawGet("TickClientWorld") as LuaFunction);
					this.m_SetTimeScaleSingle_hotfix = (luaObj.RawGet("SetTimeScale") as LuaFunction);
					this.m_SetGlobalTimeScaleSingle_hotfix = (luaObj.RawGet("SetGlobalTimeScale") as LuaFunction);
					this.m_UpdateFinalTimeScale_hotfix = (luaObj.RawGet("UpdateFinalTimeScale") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_StartConfigDataWorldMapInfo_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_Stop_hotfix = (luaObj.RawGet("Stop") as LuaFunction);
					this.m_PauseBoolean_hotfix = (luaObj.RawGet("Pause") as LuaFunction);
					this.m_ShowWorldBoolean_hotfix = (luaObj.RawGet("ShowWorld") as LuaFunction);
					this.m_CreateRegionConfigDataRegionInfo_hotfix = (luaObj.RawGet("CreateRegion") as LuaFunction);
					this.m_CreateWaypointConfigDataWaypointInfo_hotfix = (luaObj.RawGet("CreateWaypoint") as LuaFunction);
					this.m_CreatePlayerActorConfigDataWaypointInfoInt32_hotfix = (luaObj.RawGet("CreatePlayerActor") as LuaFunction);
					this.m_CreateEventActorConfigDataEventInfoConfigDataWaypointInfoInt32RandomEvent_hotfix = (luaObj.RawGet("CreateEventActor") as LuaFunction);
					this.m_UpdateRegionState_hotfix = (luaObj.RawGet("UpdateRegionState") as LuaFunction);
					this.m_UpdateWaypointState_hotfix = (luaObj.RawGet("UpdateWaypointState") as LuaFunction);
					this.m_UpdateEventActorState_hotfix = (luaObj.RawGet("UpdateEventActorState") as LuaFunction);
					this.m_UpdateCurrentScenario_hotfix = (luaObj.RawGet("UpdateCurrentScenario") as LuaFunction);
					this.m_GetRegionInt32_hotfix = (luaObj.RawGet("GetRegion") as LuaFunction);
					this.m_GetWaypointInt32_hotfix = (luaObj.RawGet("GetWaypoint") as LuaFunction);
					this.m_GetEventActorAtInt32_hotfix = (luaObj.RawGet("GetEventActorAt") as LuaFunction);
					this.m_GetEventActoryByEventIdInt32_hotfix = (luaObj.RawGet("GetEventActoryByEventId") as LuaFunction);
					this.m_GetEventActors_hotfix = (luaObj.RawGet("GetEventActors") as LuaFunction);
					this.m_GetPlayerActor_hotfix = (luaObj.RawGet("GetPlayerActor") as LuaFunction);
					this.m_OnWaypointClickClientWorldWaypoint_hotfix = (luaObj.RawGet("OnWaypointClick") as LuaFunction);
					this.m_OnEventActorClickClientWorldEventActor_hotfix = (luaObj.RawGet("OnEventActorClick") as LuaFunction);
					this.m_CreateGraphicStringSingle_hotfix = (luaObj.RawGet("CreateGraphic") as LuaFunction);
					this.m_DestroyGraphicGenericGraphic_hotfix = (luaObj.RawGet("DestroyGraphic") as LuaFunction);
					this.m_GetCamera_hotfix = (luaObj.RawGet("GetCamera") as LuaFunction);
					this.m_GetCameraPosition_hotfix = (luaObj.RawGet("GetCameraPosition") as LuaFunction);
					this.m_IsCulledVector2Boolean_hotfix = (luaObj.RawGet("IsCulled") as LuaFunction);
					this.m_IsCulledVector2Vector2Boolean_hotfix = (luaObj.RawGet("IsCulled") as LuaFunction);
					this.m_GetNextEntityId_hotfix = (luaObj.RawGet("GetNextEntityId") as LuaFunction);
					this.m_PlayScreenEffectString_hotfix = (luaObj.RawGet("PlayScreenEffect") as LuaFunction);
					this.m_CreateBackgroundConfigDataWorldMapInfoGameObject_hotfix = (luaObj.RawGet("CreateBackground") as LuaFunction);
					this.m_ClearBackground_hotfix = (luaObj.RawGet("ClearBackground") as LuaFunction);
					this.m_PlaySoundString_hotfix = (luaObj.RawGet("PlaySound") as LuaFunction);
					this.m_PlaySoundSoundTableId_hotfix = (luaObj.RawGet("PlaySound") as LuaFunction);
					this.m_FindPathInt32Int32List`1Boolean_hotfix = (luaObj.RawGet("FindPath") as LuaFunction);
					this.m_get_WorldCamera_hotfix = (luaObj.RawGet("get_WorldCamera") as LuaFunction);
					this.m_get_State_hotfix = (luaObj.RawGet("get_State") as LuaFunction);
					this.m_set_EnableDebugDrawBoolean_hotfix = (luaObj.RawGet("set_EnableDebugDraw") as LuaFunction);
					this.m_get_EnableDebugDraw_hotfix = (luaObj.RawGet("get_EnableDebugDraw") as LuaFunction);
					this.m_get_GraphicRoot_hotfix = (luaObj.RawGet("get_GraphicRoot") as LuaFunction);
					this.m_get_WorldUIRoot_hotfix = (luaObj.RawGet("get_WorldUIRoot") as LuaFunction);
					this.m_get_WaypointUIRoot_hotfix = (luaObj.RawGet("get_WaypointUIRoot") as LuaFunction);
					this.m_get_EventUIRoot_hotfix = (luaObj.RawGet("get_EventUIRoot") as LuaFunction);
					this.m_get_PlayerUIRoot_hotfix = (luaObj.RawGet("get_PlayerUIRoot") as LuaFunction);
					this.m_get_WaypointUIPrefab_hotfix = (luaObj.RawGet("get_WaypointUIPrefab") as LuaFunction);
					this.m_get_Waypoint2UIPrefab_hotfix = (luaObj.RawGet("get_Waypoint2UIPrefab") as LuaFunction);
					this.m_get_EventUIPrefab_hotfix = (luaObj.RawGet("get_EventUIPrefab") as LuaFunction);
					this.m_get_PlayerUIPrefab_hotfix = (luaObj.RawGet("get_PlayerUIPrefab") as LuaFunction);
					this.m_get_FxPlayer_hotfix = (luaObj.RawGet("get_FxPlayer") as LuaFunction);
					this.m_get_ConfigDataLoader_hotfix = (luaObj.RawGet("get_ConfigDataLoader") as LuaFunction);
					this.m_get_ClientWorldListener_hotfix = (luaObj.RawGet("get_ClientWorldListener") as LuaFunction);
					this.m_get_PlayerContext_hotfix = (luaObj.RawGet("get_PlayerContext") as LuaFunction);
					this.m_get_WorldMapInfo_hotfix = (luaObj.RawGet("get_WorldMapInfo") as LuaFunction);
					this.m_OnAudioFxEventAudioClip_hotfix = (luaObj.RawGet("OnAudio") as LuaFunction);
					this.m_OnSoundFxEventString_hotfix = (luaObj.RawGet("OnSound") as LuaFunction);
					this.m_OnCameraEffectFxEventString_hotfix = (luaObj.RawGet("OnCameraEffect") as LuaFunction);
					this.m_OnScreenEffectFxEventString_hotfix = (luaObj.RawGet("OnScreenEffect") as LuaFunction);
					this.m_OnGeneralFxEventString_hotfix = (luaObj.RawGet("OnGeneral") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008B38 RID: 35640 RVA: 0x0028B304 File Offset: 0x00289504
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientWorld));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040062EB RID: 25323
		private ClientWorldState m_state;

		// Token: 0x040062EC RID: 25324
		private int m_entityIdCounter;

		// Token: 0x040062ED RID: 25325
		private int m_frameCount;

		// Token: 0x040062EE RID: 25326
		private float m_worldTickTime;

		// Token: 0x040062EF RID: 25327
		private float m_timeScale;

		// Token: 0x040062F0 RID: 25328
		private float m_globalTimeScale;

		// Token: 0x040062F1 RID: 25329
		private bool m_isPaused;

		// Token: 0x040062F2 RID: 25330
		private bool m_enableDebugDraw;

		// Token: 0x040062F3 RID: 25331
		private RandomNumber m_randomNumber;

		// Token: 0x040062F4 RID: 25332
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040062F5 RID: 25333
		private List<ClientWorldPlayerActor> m_playerActors;

		// Token: 0x040062F6 RID: 25334
		private List<ClientWorldEventActor> m_eventActors;

		// Token: 0x040062F7 RID: 25335
		private List<ClientWorldWaypoint> m_waypoints;

		// Token: 0x040062F8 RID: 25336
		private List<ClientWorldRegion> m_regions;

		// Token: 0x040062F9 RID: 25337
		private ConfigDataWorldMapInfo m_worldMapInfo;

		// Token: 0x040062FA RID: 25338
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040062FB RID: 25339
		private IClientWorldListener m_clientWorldListener;

		// Token: 0x040062FC RID: 25340
		private WorldCamera m_worldCamera;

		// Token: 0x040062FD RID: 25341
		private WorldPathfinder m_pathfinder;

		// Token: 0x040062FE RID: 25342
		private GameObject m_worldRoot;

		// Token: 0x040062FF RID: 25343
		private GameObject m_graphicRoot;

		// Token: 0x04006300 RID: 25344
		private GameObject m_mapRoot;

		// Token: 0x04006301 RID: 25345
		private GameObject m_background;

		// Token: 0x04006302 RID: 25346
		private GameObject m_backgroundWaypointsRoot;

		// Token: 0x04006303 RID: 25347
		private GameObject m_backgroundRegionsRoot;

		// Token: 0x04006304 RID: 25348
		private GameObject m_worldUIRoot;

		// Token: 0x04006305 RID: 25349
		private GameObject m_waypointUIRoot;

		// Token: 0x04006306 RID: 25350
		private GameObject m_eventUIRoot;

		// Token: 0x04006307 RID: 25351
		private GameObject m_playerUIRoot;

		// Token: 0x04006308 RID: 25352
		private GameObject m_waypointUIPrefab;

		// Token: 0x04006309 RID: 25353
		private GameObject m_waypoint2UIPrefab;

		// Token: 0x0400630A RID: 25354
		private GameObject m_eventUIPrefab;

		// Token: 0x0400630B RID: 25355
		private GameObject m_playerUIPrefab;

		// Token: 0x0400630C RID: 25356
		private WorldScenarioUIController m_worldScenarioUIController;

		// Token: 0x0400630D RID: 25357
		private GraphicPool m_graphicPool;

		// Token: 0x0400630E RID: 25358
		private GraphicPool m_fxPool;

		// Token: 0x0400630F RID: 25359
		private FxPlayer m_fxPlayer;

		// Token: 0x04006310 RID: 25360
		[DoNotToLua]
		private ClientWorld.LuaExportHelper luaExportHelper;

		// Token: 0x04006311 RID: 25361
		[CompilerGenerated]
		private static Comparison<ClientWorldEventActor> <>f__mg$cache0;

		// Token: 0x04006312 RID: 25362
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006313 RID: 25363
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006314 RID: 25364
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04006315 RID: 25365
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04006316 RID: 25366
		private LuaFunction m_InitializeIClientWorldListenerGameObject_hotfix;

		// Token: 0x04006317 RID: 25367
		private LuaFunction m_OnWaypointUpdate_hotfix;

		// Token: 0x04006318 RID: 25368
		private LuaFunction m_OnPlayerIconUpdate_hotfix;

		// Token: 0x04006319 RID: 25369
		private LuaFunction m_TickSingle_hotfix;

		// Token: 0x0400631A RID: 25370
		private LuaFunction m_TickClientWorld_hotfix;

		// Token: 0x0400631B RID: 25371
		private LuaFunction m_SetTimeScaleSingle_hotfix;

		// Token: 0x0400631C RID: 25372
		private LuaFunction m_SetGlobalTimeScaleSingle_hotfix;

		// Token: 0x0400631D RID: 25373
		private LuaFunction m_UpdateFinalTimeScale_hotfix;

		// Token: 0x0400631E RID: 25374
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x0400631F RID: 25375
		private LuaFunction m_Draw_hotfix;

		// Token: 0x04006320 RID: 25376
		private LuaFunction m_Clear_hotfix;

		// Token: 0x04006321 RID: 25377
		private LuaFunction m_StartConfigDataWorldMapInfo_hotfix;

		// Token: 0x04006322 RID: 25378
		private LuaFunction m_Stop_hotfix;

		// Token: 0x04006323 RID: 25379
		private LuaFunction m_PauseBoolean_hotfix;

		// Token: 0x04006324 RID: 25380
		private LuaFunction m_ShowWorldBoolean_hotfix;

		// Token: 0x04006325 RID: 25381
		private LuaFunction m_CreateRegionConfigDataRegionInfo_hotfix;

		// Token: 0x04006326 RID: 25382
		private LuaFunction m_CreateWaypointConfigDataWaypointInfo_hotfix;

		// Token: 0x04006327 RID: 25383
		private LuaFunction m_CreatePlayerActorConfigDataWaypointInfoInt32_hotfix;

		// Token: 0x04006328 RID: 25384
		private LuaFunction m_CreateEventActorConfigDataEventInfoConfigDataWaypointInfoInt32RandomEvent_hotfix;

		// Token: 0x04006329 RID: 25385
		private LuaFunction m_UpdateRegionState_hotfix;

		// Token: 0x0400632A RID: 25386
		private LuaFunction m_UpdateWaypointState_hotfix;

		// Token: 0x0400632B RID: 25387
		private LuaFunction m_UpdateEventActorState_hotfix;

		// Token: 0x0400632C RID: 25388
		private LuaFunction m_UpdateCurrentScenario_hotfix;

		// Token: 0x0400632D RID: 25389
		private LuaFunction m_GetRegionInt32_hotfix;

		// Token: 0x0400632E RID: 25390
		private LuaFunction m_GetWaypointInt32_hotfix;

		// Token: 0x0400632F RID: 25391
		private LuaFunction m_GetEventActorAtInt32_hotfix;

		// Token: 0x04006330 RID: 25392
		private LuaFunction m_GetEventActoryByEventIdInt32_hotfix;

		// Token: 0x04006331 RID: 25393
		private LuaFunction m_GetEventActors_hotfix;

		// Token: 0x04006332 RID: 25394
		private LuaFunction m_GetPlayerActor_hotfix;

		// Token: 0x04006333 RID: 25395
		private LuaFunction m_OnWaypointClickClientWorldWaypoint_hotfix;

		// Token: 0x04006334 RID: 25396
		private LuaFunction m_OnEventActorClickClientWorldEventActor_hotfix;

		// Token: 0x04006335 RID: 25397
		private LuaFunction m_CreateGraphicStringSingle_hotfix;

		// Token: 0x04006336 RID: 25398
		private LuaFunction m_DestroyGraphicGenericGraphic_hotfix;

		// Token: 0x04006337 RID: 25399
		private LuaFunction m_GetCamera_hotfix;

		// Token: 0x04006338 RID: 25400
		private LuaFunction m_GetCameraPosition_hotfix;

		// Token: 0x04006339 RID: 25401
		private LuaFunction m_IsCulledVector2Boolean_hotfix;

		// Token: 0x0400633A RID: 25402
		private LuaFunction m_IsCulledVector2Vector2Boolean_hotfix;

		// Token: 0x0400633B RID: 25403
		private LuaFunction m_GetNextEntityId_hotfix;

		// Token: 0x0400633C RID: 25404
		private LuaFunction m_PlayScreenEffectString_hotfix;

		// Token: 0x0400633D RID: 25405
		private LuaFunction m_CreateBackgroundConfigDataWorldMapInfoGameObject_hotfix;

		// Token: 0x0400633E RID: 25406
		private LuaFunction m_ClearBackground_hotfix;

		// Token: 0x0400633F RID: 25407
		private LuaFunction m_PlaySoundString_hotfix;

		// Token: 0x04006340 RID: 25408
		private LuaFunction m_PlaySoundSoundTableId_hotfix;

		// Token: 0x04006341 RID: 25409
		private LuaFunction m_FindPathInt32Int32List;

		// Token: 0x04006342 RID: 25410
		private LuaFunction m_get_WorldCamera_hotfix;

		// Token: 0x04006343 RID: 25411
		private LuaFunction m_get_State_hotfix;

		// Token: 0x04006344 RID: 25412
		private LuaFunction m_set_EnableDebugDrawBoolean_hotfix;

		// Token: 0x04006345 RID: 25413
		private LuaFunction m_get_EnableDebugDraw_hotfix;

		// Token: 0x04006346 RID: 25414
		private LuaFunction m_get_GraphicRoot_hotfix;

		// Token: 0x04006347 RID: 25415
		private LuaFunction m_get_WorldUIRoot_hotfix;

		// Token: 0x04006348 RID: 25416
		private LuaFunction m_get_WaypointUIRoot_hotfix;

		// Token: 0x04006349 RID: 25417
		private LuaFunction m_get_EventUIRoot_hotfix;

		// Token: 0x0400634A RID: 25418
		private LuaFunction m_get_PlayerUIRoot_hotfix;

		// Token: 0x0400634B RID: 25419
		private LuaFunction m_get_WaypointUIPrefab_hotfix;

		// Token: 0x0400634C RID: 25420
		private LuaFunction m_get_Waypoint2UIPrefab_hotfix;

		// Token: 0x0400634D RID: 25421
		private LuaFunction m_get_EventUIPrefab_hotfix;

		// Token: 0x0400634E RID: 25422
		private LuaFunction m_get_PlayerUIPrefab_hotfix;

		// Token: 0x0400634F RID: 25423
		private LuaFunction m_get_FxPlayer_hotfix;

		// Token: 0x04006350 RID: 25424
		private LuaFunction m_get_ConfigDataLoader_hotfix;

		// Token: 0x04006351 RID: 25425
		private LuaFunction m_get_ClientWorldListener_hotfix;

		// Token: 0x04006352 RID: 25426
		private LuaFunction m_get_PlayerContext_hotfix;

		// Token: 0x04006353 RID: 25427
		private LuaFunction m_get_WorldMapInfo_hotfix;

		// Token: 0x04006354 RID: 25428
		private LuaFunction m_OnAudioFxEventAudioClip_hotfix;

		// Token: 0x04006355 RID: 25429
		private LuaFunction m_OnSoundFxEventString_hotfix;

		// Token: 0x04006356 RID: 25430
		private LuaFunction m_OnCameraEffectFxEventString_hotfix;

		// Token: 0x04006357 RID: 25431
		private LuaFunction m_OnScreenEffectFxEventString_hotfix;

		// Token: 0x04006358 RID: 25432
		private LuaFunction m_OnGeneralFxEventString_hotfix;

		// Token: 0x02000980 RID: 2432
		public class LuaExportHelper
		{
			// Token: 0x06008B39 RID: 35641 RVA: 0x0028B36C File Offset: 0x0028956C
			public LuaExportHelper(ClientWorld owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001D17 RID: 7447
			// (get) Token: 0x06008B3A RID: 35642 RVA: 0x0028B37C File Offset: 0x0028957C
			// (set) Token: 0x06008B3B RID: 35643 RVA: 0x0028B38C File Offset: 0x0028958C
			public ClientWorldState m_state
			{
				get
				{
					return this.m_owner.m_state;
				}
				set
				{
					this.m_owner.m_state = value;
				}
			}

			// Token: 0x17001D18 RID: 7448
			// (get) Token: 0x06008B3C RID: 35644 RVA: 0x0028B39C File Offset: 0x0028959C
			// (set) Token: 0x06008B3D RID: 35645 RVA: 0x0028B3AC File Offset: 0x002895AC
			public int m_entityIdCounter
			{
				get
				{
					return this.m_owner.m_entityIdCounter;
				}
				set
				{
					this.m_owner.m_entityIdCounter = value;
				}
			}

			// Token: 0x17001D19 RID: 7449
			// (get) Token: 0x06008B3E RID: 35646 RVA: 0x0028B3BC File Offset: 0x002895BC
			// (set) Token: 0x06008B3F RID: 35647 RVA: 0x0028B3CC File Offset: 0x002895CC
			public int m_frameCount
			{
				get
				{
					return this.m_owner.m_frameCount;
				}
				set
				{
					this.m_owner.m_frameCount = value;
				}
			}

			// Token: 0x17001D1A RID: 7450
			// (get) Token: 0x06008B40 RID: 35648 RVA: 0x0028B3DC File Offset: 0x002895DC
			// (set) Token: 0x06008B41 RID: 35649 RVA: 0x0028B3EC File Offset: 0x002895EC
			public float m_worldTickTime
			{
				get
				{
					return this.m_owner.m_worldTickTime;
				}
				set
				{
					this.m_owner.m_worldTickTime = value;
				}
			}

			// Token: 0x17001D1B RID: 7451
			// (get) Token: 0x06008B42 RID: 35650 RVA: 0x0028B3FC File Offset: 0x002895FC
			// (set) Token: 0x06008B43 RID: 35651 RVA: 0x0028B40C File Offset: 0x0028960C
			public float m_timeScale
			{
				get
				{
					return this.m_owner.m_timeScale;
				}
				set
				{
					this.m_owner.m_timeScale = value;
				}
			}

			// Token: 0x17001D1C RID: 7452
			// (get) Token: 0x06008B44 RID: 35652 RVA: 0x0028B41C File Offset: 0x0028961C
			// (set) Token: 0x06008B45 RID: 35653 RVA: 0x0028B42C File Offset: 0x0028962C
			public float m_globalTimeScale
			{
				get
				{
					return this.m_owner.m_globalTimeScale;
				}
				set
				{
					this.m_owner.m_globalTimeScale = value;
				}
			}

			// Token: 0x17001D1D RID: 7453
			// (get) Token: 0x06008B46 RID: 35654 RVA: 0x0028B43C File Offset: 0x0028963C
			// (set) Token: 0x06008B47 RID: 35655 RVA: 0x0028B44C File Offset: 0x0028964C
			public bool m_isPaused
			{
				get
				{
					return this.m_owner.m_isPaused;
				}
				set
				{
					this.m_owner.m_isPaused = value;
				}
			}

			// Token: 0x17001D1E RID: 7454
			// (get) Token: 0x06008B48 RID: 35656 RVA: 0x0028B45C File Offset: 0x0028965C
			// (set) Token: 0x06008B49 RID: 35657 RVA: 0x0028B46C File Offset: 0x0028966C
			public bool m_enableDebugDraw
			{
				get
				{
					return this.m_owner.m_enableDebugDraw;
				}
				set
				{
					this.m_owner.m_enableDebugDraw = value;
				}
			}

			// Token: 0x17001D1F RID: 7455
			// (get) Token: 0x06008B4A RID: 35658 RVA: 0x0028B47C File Offset: 0x0028967C
			// (set) Token: 0x06008B4B RID: 35659 RVA: 0x0028B48C File Offset: 0x0028968C
			public RandomNumber m_randomNumber
			{
				get
				{
					return this.m_owner.m_randomNumber;
				}
				set
				{
					this.m_owner.m_randomNumber = value;
				}
			}

			// Token: 0x17001D20 RID: 7456
			// (get) Token: 0x06008B4C RID: 35660 RVA: 0x0028B49C File Offset: 0x0028969C
			// (set) Token: 0x06008B4D RID: 35661 RVA: 0x0028B4AC File Offset: 0x002896AC
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17001D21 RID: 7457
			// (get) Token: 0x06008B4E RID: 35662 RVA: 0x0028B4BC File Offset: 0x002896BC
			// (set) Token: 0x06008B4F RID: 35663 RVA: 0x0028B4CC File Offset: 0x002896CC
			public List<ClientWorldPlayerActor> m_playerActors
			{
				get
				{
					return this.m_owner.m_playerActors;
				}
				set
				{
					this.m_owner.m_playerActors = value;
				}
			}

			// Token: 0x17001D22 RID: 7458
			// (get) Token: 0x06008B50 RID: 35664 RVA: 0x0028B4DC File Offset: 0x002896DC
			// (set) Token: 0x06008B51 RID: 35665 RVA: 0x0028B4EC File Offset: 0x002896EC
			public List<ClientWorldEventActor> m_eventActors
			{
				get
				{
					return this.m_owner.m_eventActors;
				}
				set
				{
					this.m_owner.m_eventActors = value;
				}
			}

			// Token: 0x17001D23 RID: 7459
			// (get) Token: 0x06008B52 RID: 35666 RVA: 0x0028B4FC File Offset: 0x002896FC
			// (set) Token: 0x06008B53 RID: 35667 RVA: 0x0028B50C File Offset: 0x0028970C
			public List<ClientWorldWaypoint> m_waypoints
			{
				get
				{
					return this.m_owner.m_waypoints;
				}
				set
				{
					this.m_owner.m_waypoints = value;
				}
			}

			// Token: 0x17001D24 RID: 7460
			// (get) Token: 0x06008B54 RID: 35668 RVA: 0x0028B51C File Offset: 0x0028971C
			// (set) Token: 0x06008B55 RID: 35669 RVA: 0x0028B52C File Offset: 0x0028972C
			public List<ClientWorldRegion> m_regions
			{
				get
				{
					return this.m_owner.m_regions;
				}
				set
				{
					this.m_owner.m_regions = value;
				}
			}

			// Token: 0x17001D25 RID: 7461
			// (get) Token: 0x06008B56 RID: 35670 RVA: 0x0028B53C File Offset: 0x0028973C
			// (set) Token: 0x06008B57 RID: 35671 RVA: 0x0028B54C File Offset: 0x0028974C
			public ConfigDataWorldMapInfo m_worldMapInfo
			{
				get
				{
					return this.m_owner.m_worldMapInfo;
				}
				set
				{
					this.m_owner.m_worldMapInfo = value;
				}
			}

			// Token: 0x17001D26 RID: 7462
			// (get) Token: 0x06008B58 RID: 35672 RVA: 0x0028B55C File Offset: 0x0028975C
			// (set) Token: 0x06008B59 RID: 35673 RVA: 0x0028B56C File Offset: 0x0028976C
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17001D27 RID: 7463
			// (get) Token: 0x06008B5A RID: 35674 RVA: 0x0028B57C File Offset: 0x0028977C
			// (set) Token: 0x06008B5B RID: 35675 RVA: 0x0028B58C File Offset: 0x0028978C
			public IClientWorldListener m_clientWorldListener
			{
				get
				{
					return this.m_owner.m_clientWorldListener;
				}
				set
				{
					this.m_owner.m_clientWorldListener = value;
				}
			}

			// Token: 0x17001D28 RID: 7464
			// (get) Token: 0x06008B5C RID: 35676 RVA: 0x0028B59C File Offset: 0x0028979C
			// (set) Token: 0x06008B5D RID: 35677 RVA: 0x0028B5AC File Offset: 0x002897AC
			public WorldCamera m_worldCamera
			{
				get
				{
					return this.m_owner.m_worldCamera;
				}
				set
				{
					this.m_owner.m_worldCamera = value;
				}
			}

			// Token: 0x17001D29 RID: 7465
			// (get) Token: 0x06008B5E RID: 35678 RVA: 0x0028B5BC File Offset: 0x002897BC
			// (set) Token: 0x06008B5F RID: 35679 RVA: 0x0028B5CC File Offset: 0x002897CC
			public WorldPathfinder m_pathfinder
			{
				get
				{
					return this.m_owner.m_pathfinder;
				}
				set
				{
					this.m_owner.m_pathfinder = value;
				}
			}

			// Token: 0x17001D2A RID: 7466
			// (get) Token: 0x06008B60 RID: 35680 RVA: 0x0028B5DC File Offset: 0x002897DC
			// (set) Token: 0x06008B61 RID: 35681 RVA: 0x0028B5EC File Offset: 0x002897EC
			public GameObject m_worldRoot
			{
				get
				{
					return this.m_owner.m_worldRoot;
				}
				set
				{
					this.m_owner.m_worldRoot = value;
				}
			}

			// Token: 0x17001D2B RID: 7467
			// (get) Token: 0x06008B62 RID: 35682 RVA: 0x0028B5FC File Offset: 0x002897FC
			// (set) Token: 0x06008B63 RID: 35683 RVA: 0x0028B60C File Offset: 0x0028980C
			public GameObject m_graphicRoot
			{
				get
				{
					return this.m_owner.m_graphicRoot;
				}
				set
				{
					this.m_owner.m_graphicRoot = value;
				}
			}

			// Token: 0x17001D2C RID: 7468
			// (get) Token: 0x06008B64 RID: 35684 RVA: 0x0028B61C File Offset: 0x0028981C
			// (set) Token: 0x06008B65 RID: 35685 RVA: 0x0028B62C File Offset: 0x0028982C
			public GameObject m_mapRoot
			{
				get
				{
					return this.m_owner.m_mapRoot;
				}
				set
				{
					this.m_owner.m_mapRoot = value;
				}
			}

			// Token: 0x17001D2D RID: 7469
			// (get) Token: 0x06008B66 RID: 35686 RVA: 0x0028B63C File Offset: 0x0028983C
			// (set) Token: 0x06008B67 RID: 35687 RVA: 0x0028B64C File Offset: 0x0028984C
			public GameObject m_background
			{
				get
				{
					return this.m_owner.m_background;
				}
				set
				{
					this.m_owner.m_background = value;
				}
			}

			// Token: 0x17001D2E RID: 7470
			// (get) Token: 0x06008B68 RID: 35688 RVA: 0x0028B65C File Offset: 0x0028985C
			// (set) Token: 0x06008B69 RID: 35689 RVA: 0x0028B66C File Offset: 0x0028986C
			public GameObject m_backgroundWaypointsRoot
			{
				get
				{
					return this.m_owner.m_backgroundWaypointsRoot;
				}
				set
				{
					this.m_owner.m_backgroundWaypointsRoot = value;
				}
			}

			// Token: 0x17001D2F RID: 7471
			// (get) Token: 0x06008B6A RID: 35690 RVA: 0x0028B67C File Offset: 0x0028987C
			// (set) Token: 0x06008B6B RID: 35691 RVA: 0x0028B68C File Offset: 0x0028988C
			public GameObject m_backgroundRegionsRoot
			{
				get
				{
					return this.m_owner.m_backgroundRegionsRoot;
				}
				set
				{
					this.m_owner.m_backgroundRegionsRoot = value;
				}
			}

			// Token: 0x17001D30 RID: 7472
			// (get) Token: 0x06008B6C RID: 35692 RVA: 0x0028B69C File Offset: 0x0028989C
			// (set) Token: 0x06008B6D RID: 35693 RVA: 0x0028B6AC File Offset: 0x002898AC
			public GameObject m_worldUIRoot
			{
				get
				{
					return this.m_owner.m_worldUIRoot;
				}
				set
				{
					this.m_owner.m_worldUIRoot = value;
				}
			}

			// Token: 0x17001D31 RID: 7473
			// (get) Token: 0x06008B6E RID: 35694 RVA: 0x0028B6BC File Offset: 0x002898BC
			// (set) Token: 0x06008B6F RID: 35695 RVA: 0x0028B6CC File Offset: 0x002898CC
			public GameObject m_waypointUIRoot
			{
				get
				{
					return this.m_owner.m_waypointUIRoot;
				}
				set
				{
					this.m_owner.m_waypointUIRoot = value;
				}
			}

			// Token: 0x17001D32 RID: 7474
			// (get) Token: 0x06008B70 RID: 35696 RVA: 0x0028B6DC File Offset: 0x002898DC
			// (set) Token: 0x06008B71 RID: 35697 RVA: 0x0028B6EC File Offset: 0x002898EC
			public GameObject m_eventUIRoot
			{
				get
				{
					return this.m_owner.m_eventUIRoot;
				}
				set
				{
					this.m_owner.m_eventUIRoot = value;
				}
			}

			// Token: 0x17001D33 RID: 7475
			// (get) Token: 0x06008B72 RID: 35698 RVA: 0x0028B6FC File Offset: 0x002898FC
			// (set) Token: 0x06008B73 RID: 35699 RVA: 0x0028B70C File Offset: 0x0028990C
			public GameObject m_playerUIRoot
			{
				get
				{
					return this.m_owner.m_playerUIRoot;
				}
				set
				{
					this.m_owner.m_playerUIRoot = value;
				}
			}

			// Token: 0x17001D34 RID: 7476
			// (get) Token: 0x06008B74 RID: 35700 RVA: 0x0028B71C File Offset: 0x0028991C
			// (set) Token: 0x06008B75 RID: 35701 RVA: 0x0028B72C File Offset: 0x0028992C
			public GameObject m_waypointUIPrefab
			{
				get
				{
					return this.m_owner.m_waypointUIPrefab;
				}
				set
				{
					this.m_owner.m_waypointUIPrefab = value;
				}
			}

			// Token: 0x17001D35 RID: 7477
			// (get) Token: 0x06008B76 RID: 35702 RVA: 0x0028B73C File Offset: 0x0028993C
			// (set) Token: 0x06008B77 RID: 35703 RVA: 0x0028B74C File Offset: 0x0028994C
			public GameObject m_waypoint2UIPrefab
			{
				get
				{
					return this.m_owner.m_waypoint2UIPrefab;
				}
				set
				{
					this.m_owner.m_waypoint2UIPrefab = value;
				}
			}

			// Token: 0x17001D36 RID: 7478
			// (get) Token: 0x06008B78 RID: 35704 RVA: 0x0028B75C File Offset: 0x0028995C
			// (set) Token: 0x06008B79 RID: 35705 RVA: 0x0028B76C File Offset: 0x0028996C
			public GameObject m_eventUIPrefab
			{
				get
				{
					return this.m_owner.m_eventUIPrefab;
				}
				set
				{
					this.m_owner.m_eventUIPrefab = value;
				}
			}

			// Token: 0x17001D37 RID: 7479
			// (get) Token: 0x06008B7A RID: 35706 RVA: 0x0028B77C File Offset: 0x0028997C
			// (set) Token: 0x06008B7B RID: 35707 RVA: 0x0028B78C File Offset: 0x0028998C
			public GameObject m_playerUIPrefab
			{
				get
				{
					return this.m_owner.m_playerUIPrefab;
				}
				set
				{
					this.m_owner.m_playerUIPrefab = value;
				}
			}

			// Token: 0x17001D38 RID: 7480
			// (get) Token: 0x06008B7C RID: 35708 RVA: 0x0028B79C File Offset: 0x0028999C
			// (set) Token: 0x06008B7D RID: 35709 RVA: 0x0028B7AC File Offset: 0x002899AC
			public WorldScenarioUIController m_worldScenarioUIController
			{
				get
				{
					return this.m_owner.m_worldScenarioUIController;
				}
				set
				{
					this.m_owner.m_worldScenarioUIController = value;
				}
			}

			// Token: 0x17001D39 RID: 7481
			// (get) Token: 0x06008B7E RID: 35710 RVA: 0x0028B7BC File Offset: 0x002899BC
			// (set) Token: 0x06008B7F RID: 35711 RVA: 0x0028B7CC File Offset: 0x002899CC
			public GraphicPool m_graphicPool
			{
				get
				{
					return this.m_owner.m_graphicPool;
				}
				set
				{
					this.m_owner.m_graphicPool = value;
				}
			}

			// Token: 0x17001D3A RID: 7482
			// (get) Token: 0x06008B80 RID: 35712 RVA: 0x0028B7DC File Offset: 0x002899DC
			// (set) Token: 0x06008B81 RID: 35713 RVA: 0x0028B7EC File Offset: 0x002899EC
			public GraphicPool m_fxPool
			{
				get
				{
					return this.m_owner.m_fxPool;
				}
				set
				{
					this.m_owner.m_fxPool = value;
				}
			}

			// Token: 0x17001D3B RID: 7483
			// (get) Token: 0x06008B82 RID: 35714 RVA: 0x0028B7FC File Offset: 0x002899FC
			// (set) Token: 0x06008B83 RID: 35715 RVA: 0x0028B80C File Offset: 0x00289A0C
			public FxPlayer m_fxPlayer
			{
				get
				{
					return this.m_owner.m_fxPlayer;
				}
				set
				{
					this.m_owner.m_fxPlayer = value;
				}
			}

			// Token: 0x06008B84 RID: 35716 RVA: 0x0028B81C File Offset: 0x00289A1C
			public void TickClientWorld()
			{
				this.m_owner.TickClientWorld();
			}

			// Token: 0x06008B85 RID: 35717 RVA: 0x0028B82C File Offset: 0x00289A2C
			public void SetTimeScale(float scale)
			{
				this.m_owner.SetTimeScale(scale);
			}

			// Token: 0x06008B86 RID: 35718 RVA: 0x0028B83C File Offset: 0x00289A3C
			public void UpdateFinalTimeScale()
			{
				this.m_owner.UpdateFinalTimeScale();
			}

			// Token: 0x06008B87 RID: 35719 RVA: 0x0028B84C File Offset: 0x00289A4C
			public void TickGraphic(float dt)
			{
				this.m_owner.TickGraphic(dt);
			}

			// Token: 0x06008B88 RID: 35720 RVA: 0x0028B85C File Offset: 0x00289A5C
			public void Draw()
			{
				this.m_owner.Draw();
			}

			// Token: 0x06008B89 RID: 35721 RVA: 0x0028B86C File Offset: 0x00289A6C
			public ClientWorldRegion CreateRegion(ConfigDataRegionInfo regionInfo)
			{
				return this.m_owner.CreateRegion(regionInfo);
			}

			// Token: 0x06008B8A RID: 35722 RVA: 0x0028B87C File Offset: 0x00289A7C
			public ClientWorldWaypoint CreateWaypoint(ConfigDataWaypointInfo waypointInfo)
			{
				return this.m_owner.CreateWaypoint(waypointInfo);
			}

			// Token: 0x06008B8B RID: 35723 RVA: 0x0028B88C File Offset: 0x00289A8C
			public ClientWorldPlayerActor CreatePlayerActor(ConfigDataWaypointInfo waypointInfo, int dir)
			{
				return this.m_owner.CreatePlayerActor(waypointInfo, dir);
			}

			// Token: 0x06008B8C RID: 35724 RVA: 0x0028B89C File Offset: 0x00289A9C
			public ClientWorldEventActor CreateEventActor(ConfigDataEventInfo eventInfo, ConfigDataWaypointInfo waypointInfo, int dir, RandomEvent randomEvent)
			{
				return this.m_owner.CreateEventActor(eventInfo, waypointInfo, dir, randomEvent);
			}

			// Token: 0x06008B8D RID: 35725 RVA: 0x0028B8B0 File Offset: 0x00289AB0
			public void UpdateRegionState()
			{
				this.m_owner.UpdateRegionState();
			}

			// Token: 0x06008B8E RID: 35726 RVA: 0x0028B8C0 File Offset: 0x00289AC0
			public void UpdateWaypointState()
			{
				this.m_owner.UpdateWaypointState();
			}

			// Token: 0x06008B8F RID: 35727 RVA: 0x0028B8D0 File Offset: 0x00289AD0
			public static int CompareEventActorPositionY(ClientWorldEventActor a0, ClientWorldEventActor a1)
			{
				return ClientWorld.CompareEventActorPositionY(a0, a1);
			}

			// Token: 0x06008B90 RID: 35728 RVA: 0x0028B8DC File Offset: 0x00289ADC
			public static int CompareWaypointPositionY(ClientWorldWaypoint a0, ClientWorldWaypoint a1)
			{
				return ClientWorld.CompareWaypointPositionY(a0, a1);
			}

			// Token: 0x06008B91 RID: 35729 RVA: 0x0028B8E8 File Offset: 0x00289AE8
			public CameraBase GetCamera()
			{
				return this.m_owner.GetCamera();
			}

			// Token: 0x06008B92 RID: 35730 RVA: 0x0028B8F8 File Offset: 0x00289AF8
			public void CreateBackground(ConfigDataWorldMapInfo worldMapInfo, GameObject parent)
			{
				this.m_owner.CreateBackground(worldMapInfo, parent);
			}

			// Token: 0x06008B93 RID: 35731 RVA: 0x0028B908 File Offset: 0x00289B08
			public void ClearBackground()
			{
				this.m_owner.ClearBackground();
			}

			// Token: 0x04006359 RID: 25433
			private ClientWorld m_owner;
		}
	}
}
