using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000988 RID: 2440
	[HotFix]
	public class ClientWorldWaypoint : Entity
	{
		// Token: 0x06008C68 RID: 35944 RVA: 0x0028F690 File Offset: 0x0028D890
		public ClientWorldWaypoint()
		{
			this.m_isVisible = true;
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

		// Token: 0x06008C69 RID: 35945 RVA: 0x0028F708 File Offset: 0x0028D908
		public void Initialize(ClientWorld world, ConfigDataWaypointInfo waypointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeClientWorldConfigDataWaypointInfo_hotfix != null)
			{
				this.m_InitializeClientWorldConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					world,
					waypointInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorld = world;
			this.m_waypointInfo = waypointInfo;
			this.m_id = world.GetNextEntityId();
			bool flag = waypointInfo.FuncType == WaypointFuncType.WaypointFuncType_Scenario || waypointInfo.FuncType == WaypointFuncType.WaypointFuncType_Portal;
			this.m_graphicInitScale = 1f;
			this.m_graphic = world.CreateGraphic(waypointInfo.Model, this.m_graphicInitScale);
			if (this.m_graphic != null)
			{
				this.m_graphic.SetName("Waypoint_" + waypointInfo.ID);
				this.m_graphic.SetRotation(ClientWorldConst.FaceCameraRotation);
				if (flag)
				{
					this.m_graphic.SetSortingOrder(2);
				}
				this.m_graphicUIStateController = this.m_graphic.GetPrefab().GetComponent<CommonUIStateController>();
			}
			GameObject gameObject;
			if (flag)
			{
				gameObject = UnityEngine.Object.Instantiate<GameObject>(world.WaypointUIPrefab, world.WaypointUIRoot.transform, false);
			}
			else
			{
				gameObject = UnityEngine.Object.Instantiate<GameObject>(world.Waypoint2UIPrefab, world.WaypointUIRoot.transform, false);
			}
			if (gameObject != null)
			{
				gameObject.name = "Waypoint_" + waypointInfo.ID;
				this.m_uiInitScale = gameObject.transform.localScale;
				this.m_uiController = GameObjectUtility.AddControllerToGameObject<WorldWaypointUIController>(gameObject);
				this.m_uiController.SetWaypoint(this.m_waypointInfo);
				this.m_uiController.EventOnPointerDown += this.OnUIPointerDown;
				this.m_uiController.EventOnPointerUp += this.OnUIPointerUp;
				this.m_uiController.EventOnClick += this.OnUIClick;
				gameObject.transform.localRotation = ClientWorldConst.FaceCameraRotation;
				if (flag)
				{
					Canvas canvas = gameObject.AddComponent<Canvas>();
					canvas.overrideSorting = true;
					canvas.sortingOrder = 2;
					gameObject.AddComponent<GraphicRaycaster>();
				}
			}
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x0028F94C File Offset: 0x0028DB4C
		public override void Dispose()
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
			if (this.m_graphic != null)
			{
				this.m_clientWorld.DestroyGraphic(this.m_graphic);
				this.m_graphic = null;
			}
			if (this.m_uiController != null)
			{
				UnityEngine.Object.Destroy(this.m_uiController.gameObject);
				this.m_uiController = null;
			}
		}

		// Token: 0x06008C6B RID: 35947 RVA: 0x0028F9F8 File Offset: 0x0028DBF8
		public override void Tick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Tick_hotfix != null)
			{
				this.m_Tick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x0028FA58 File Offset: 0x0028DC58
		public override void TickGraphic(float dt)
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
			float num = this.m_scale;
			if (this.m_isPointerDown)
			{
				num = Mathf.MoveTowards(this.m_scale, 0.9f, dt);
			}
			else
			{
				num = Mathf.MoveTowards(this.m_scale, 1f, dt);
			}
			if (num != this.m_scale)
			{
				this.m_scale = num;
				if (this.m_graphic != null)
				{
					this.m_graphic.SetPrefabScale(this.m_graphicInitScale * num);
				}
				if (this.m_uiController != null)
				{
					this.m_uiController.transform.localScale = this.m_uiInitScale * num;
				}
			}
			if (this.m_graphic != null)
			{
				this.m_graphic.Tick(dt);
			}
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x0028FB78 File Offset: 0x0028DD78
		public override void Draw()
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
			foreach (int waypointId in this.m_waypointInfo.Waypoints_ID)
			{
				ClientWorldWaypoint waypoint = this.m_clientWorld.GetWaypoint(waypointId);
				if (waypoint != null)
				{
					this.DrawArrow(this.m_position, waypoint.m_position, Color.white);
				}
			}
		}

		// Token: 0x06008C6E RID: 35950 RVA: 0x0028FC5C File Offset: 0x0028DE5C
		private void DrawArrow(Vector3 p0, Vector3 p1, Color color)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrawArrowVector3Vector3Color_hotfix != null)
			{
				this.m_DrawArrowVector3Vector3Color_hotfix.call(new object[]
				{
					this,
					p0,
					p1,
					color
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3 normalized = (p0 - p1).normalized;
			Vector3 b = new Vector3(-normalized.y * 0.5f, normalized.x * 0.5f, normalized.z);
			global::Debug.DrawLine(p0, p1, color);
			global::Debug.DrawLine(p1, p1 + (normalized + b) * 0.5f, color);
			global::Debug.DrawLine(p1, p1 + (normalized - b) * 0.5f, color);
		}

		// Token: 0x06008C6F RID: 35951 RVA: 0x0028FD6C File Offset: 0x0028DF6C
		public override void DoPause(bool pause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoPauseBoolean_hotfix != null)
			{
				this.m_DoPauseBoolean_hotfix.call(new object[]
				{
					this,
					pause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.Pause(pause);
			}
		}

		// Token: 0x06008C70 RID: 35952 RVA: 0x0028FDF4 File Offset: 0x0028DFF4
		public void Locate(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LocateVector2_hotfix != null)
			{
				this.m_LocateVector2_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_position = p;
			if (this.m_graphic != null)
			{
				this.m_graphic.SetPosition(ClientWorld.ComputeActorPosition(this.m_position, 0f));
			}
			if (this.m_uiController != null)
			{
				this.m_uiController.transform.localPosition = ClientWorld.ComputeActorPosition(this.m_position, -0.02f);
			}
		}

		// Token: 0x06008C71 RID: 35953 RVA: 0x0028FEC4 File Offset: 0x0028E0C4
		public void SetStatus(WayPointStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStatusWayPointStatus_hotfix != null)
			{
				this.m_SetStatusWayPointStatus_hotfix.call(new object[]
				{
					this,
					status
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_status = status;
			Colori color;
			if (status == WayPointStatus.Close || status == WayPointStatus.Open)
			{
				color = new Colori(150, 150, 150, byte.MaxValue);
			}
			else
			{
				color = new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			}
			bool flag = status != WayPointStatus.Close;
			if (this.m_graphic != null)
			{
				this.m_graphic.SetVisible(flag);
				this.m_graphic.SetColor(color);
			}
			if (this.m_uiController != null)
			{
				this.m_uiController.gameObject.SetActive(flag);
				this.m_uiController.SetStatus(status);
			}
		}

		// Token: 0x06008C72 RID: 35954 RVA: 0x0028FFE0 File Offset: 0x0028E1E0
		public WayPointStatus GetStatus()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStatus_hotfix != null)
			{
				return (WayPointStatus)this.m_GetStatus_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_status;
		}

		// Token: 0x06008C73 RID: 35955 RVA: 0x00290054 File Offset: 0x0028E254
		public void SetScenarioState(ConfigDataWaypointInfo waypointInfo, ConfigDataScenarioInfo scenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetScenarioStateConfigDataWaypointInfoConfigDataScenarioInfo_hotfix != null)
			{
				this.m_SetScenarioStateConfigDataWaypointInfoConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					waypointInfo,
					scenarioInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphicUIStateController == null)
			{
				return;
			}
			string text = string.Empty;
			if (scenarioInfo != null)
			{
				foreach (WaypointInfoStateList waypointInfoStateList in waypointInfo.StateList)
				{
					ConfigDataScenarioInfo configDataScenarioInfo = this.m_clientWorld.ConfigDataLoader.GetConfigDataScenarioInfo(waypointInfoStateList.ScenarioId);
					if (configDataScenarioInfo != null)
					{
						if (scenarioInfo.m_scenarioDepth >= configDataScenarioInfo.m_scenarioDepth)
						{
							text = waypointInfoStateList.StateName;
						}
					}
				}
			}
			else if (waypointInfo.StateList.Count > 0)
			{
				text = waypointInfo.StateList[waypointInfo.StateList.Count - 1].StateName;
			}
			if (!string.IsNullOrEmpty(text))
			{
				this.m_graphicUIStateController.SetToUIState(text, false, true);
			}
		}

		// Token: 0x06008C74 RID: 35956 RVA: 0x002901C4 File Offset: 0x0028E3C4
		public void SetCanClick(bool canClick)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCanClickBoolean_hotfix != null)
			{
				this.m_SetCanClickBoolean_hotfix.call(new object[]
				{
					this,
					canClick
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_uiController != null)
			{
				this.m_uiController.SetCanClick(canClick);
			}
			if (!canClick)
			{
				this.m_isPointerDown = false;
			}
		}

		// Token: 0x06008C75 RID: 35957 RVA: 0x00290260 File Offset: 0x0028E460
		public RectTransform GetClickTransform()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetClickTransform_hotfix != null)
			{
				return (RectTransform)this.m_GetClickTransform_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_uiController != null)
			{
				return this.m_uiController.GetClickTransform();
			}
			return null;
		}

		// Token: 0x06008C76 RID: 35958 RVA: 0x002902EC File Offset: 0x0028E4EC
		private void PlayAnimation(string name, bool loop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationStringBoolean_hotfix != null)
			{
				this.m_PlayAnimationStringBoolean_hotfix.call(new object[]
				{
					this,
					name,
					loop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null && this.m_graphic.IsVisible())
			{
				this.m_graphic.PlayAnimation(name, loop);
			}
		}

		// Token: 0x06008C77 RID: 35959 RVA: 0x00290394 File Offset: 0x0028E594
		public void SetVisible(bool visible)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetVisibleBoolean_hotfix != null)
			{
				this.m_SetVisibleBoolean_hotfix.call(new object[]
				{
					this,
					visible
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isVisible = visible;
			if (this.m_graphic != null)
			{
				this.m_graphic.SetVisible(visible);
			}
			if (this.m_uiController != null)
			{
				this.m_uiController.gameObject.SetActive(visible);
			}
		}

		// Token: 0x06008C78 RID: 35960 RVA: 0x00290444 File Offset: 0x0028E644
		public bool IsVisible()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsVisible_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsVisible_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isVisible;
		}

		// Token: 0x06008C79 RID: 35961 RVA: 0x002904B8 File Offset: 0x0028E6B8
		public void SetUISiblingIndex(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUISiblingIndexInt32_hotfix != null)
			{
				this.m_SetUISiblingIndexInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_uiController != null)
			{
				this.m_uiController.gameObject.transform.SetSiblingIndex(idx);
			}
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x00290550 File Offset: 0x0028E750
		private void OnUIPointerDown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUIPointerDown_hotfix != null)
			{
				this.m_OnUIPointerDown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_uiController != null && !this.m_uiController.CanClick())
			{
				return;
			}
			this.m_isPointerDown = true;
		}

		// Token: 0x06008C7B RID: 35963 RVA: 0x002905DC File Offset: 0x0028E7DC
		private void OnUIPointerUp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUIPointerUp_hotfix != null)
			{
				this.m_OnUIPointerUp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_uiController != null && !this.m_uiController.CanClick())
			{
				return;
			}
			this.m_isPointerDown = false;
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x00290668 File Offset: 0x0028E868
		private void OnUIClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUIClick_hotfix != null)
			{
				this.m_OnUIClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_uiController != null && !this.m_uiController.CanClick())
			{
				return;
			}
			this.m_clientWorld.OnWaypointClick(this);
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06008C7D RID: 35965 RVA: 0x002906F8 File Offset: 0x0028E8F8
		public Vector2 Position
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Position_hotfix != null)
				{
					return (Vector2)this.m_get_Position_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_position;
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06008C7E RID: 35966 RVA: 0x0029076C File Offset: 0x0028E96C
		public ConfigDataWaypointInfo WaypointInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_WaypointInfo_hotfix != null)
				{
					return (ConfigDataWaypointInfo)this.m_get_WaypointInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_waypointInfo;
			}
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06008C7F RID: 35967 RVA: 0x002907E0 File Offset: 0x0028E9E0
		// (set) Token: 0x06008C80 RID: 35968 RVA: 0x00290800 File Offset: 0x0028EA00
		[DoNotToLua]
		public new ClientWorldWaypoint.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClientWorldWaypoint.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008C81 RID: 35969 RVA: 0x0029080C File Offset: 0x0028EA0C
		private void __callBase_Dispose()
		{
			base.Dispose();
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x00290814 File Offset: 0x0028EA14
		private void __callBase_Tick()
		{
			base.Tick();
		}

		// Token: 0x06008C83 RID: 35971 RVA: 0x0029081C File Offset: 0x0028EA1C
		private void __callBase_TickGraphic(float dt)
		{
			base.TickGraphic(dt);
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x00290828 File Offset: 0x0028EA28
		private void __callBase_Draw()
		{
			base.Draw();
		}

		// Token: 0x06008C85 RID: 35973 RVA: 0x00290830 File Offset: 0x0028EA30
		private void __callBase_Pause(bool pause)
		{
			base.Pause(pause);
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x0029083C File Offset: 0x0028EA3C
		private void __callBase_DoPause(bool pause)
		{
			base.DoPause(pause);
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x00290848 File Offset: 0x0028EA48
		private void __callBase_DeleteMe()
		{
			base.DeleteMe();
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x00290850 File Offset: 0x0028EA50
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
					this.m_InitializeClientWorldConfigDataWaypointInfo_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_DrawArrowVector3Vector3Color_hotfix = (luaObj.RawGet("DrawArrow") as LuaFunction);
					this.m_DoPauseBoolean_hotfix = (luaObj.RawGet("DoPause") as LuaFunction);
					this.m_LocateVector2_hotfix = (luaObj.RawGet("Locate") as LuaFunction);
					this.m_SetStatusWayPointStatus_hotfix = (luaObj.RawGet("SetStatus") as LuaFunction);
					this.m_GetStatus_hotfix = (luaObj.RawGet("GetStatus") as LuaFunction);
					this.m_SetScenarioStateConfigDataWaypointInfoConfigDataScenarioInfo_hotfix = (luaObj.RawGet("SetScenarioState") as LuaFunction);
					this.m_SetCanClickBoolean_hotfix = (luaObj.RawGet("SetCanClick") as LuaFunction);
					this.m_GetClickTransform_hotfix = (luaObj.RawGet("GetClickTransform") as LuaFunction);
					this.m_PlayAnimationStringBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_SetVisibleBoolean_hotfix = (luaObj.RawGet("SetVisible") as LuaFunction);
					this.m_IsVisible_hotfix = (luaObj.RawGet("IsVisible") as LuaFunction);
					this.m_SetUISiblingIndexInt32_hotfix = (luaObj.RawGet("SetUISiblingIndex") as LuaFunction);
					this.m_OnUIPointerDown_hotfix = (luaObj.RawGet("OnUIPointerDown") as LuaFunction);
					this.m_OnUIPointerUp_hotfix = (luaObj.RawGet("OnUIPointerUp") as LuaFunction);
					this.m_OnUIClick_hotfix = (luaObj.RawGet("OnUIClick") as LuaFunction);
					this.m_get_Position_hotfix = (luaObj.RawGet("get_Position") as LuaFunction);
					this.m_get_WaypointInfo_hotfix = (luaObj.RawGet("get_WaypointInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x00290B44 File Offset: 0x0028ED44
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientWorldWaypoint));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040063D4 RID: 25556
		private ClientWorld m_clientWorld;

		// Token: 0x040063D5 RID: 25557
		private ConfigDataWaypointInfo m_waypointInfo;

		// Token: 0x040063D6 RID: 25558
		private WayPointStatus m_status;

		// Token: 0x040063D7 RID: 25559
		private GenericGraphic m_graphic;

		// Token: 0x040063D8 RID: 25560
		private Vector2 m_position;

		// Token: 0x040063D9 RID: 25561
		private bool m_isVisible;

		// Token: 0x040063DA RID: 25562
		private WorldWaypointUIController m_uiController;

		// Token: 0x040063DB RID: 25563
		private CommonUIStateController m_graphicUIStateController;

		// Token: 0x040063DC RID: 25564
		private Vector3 m_uiInitScale;

		// Token: 0x040063DD RID: 25565
		private float m_graphicInitScale;

		// Token: 0x040063DE RID: 25566
		private bool m_isPointerDown;

		// Token: 0x040063DF RID: 25567
		private float m_scale = 1f;

		// Token: 0x040063E0 RID: 25568
		[DoNotToLua]
		private ClientWorldWaypoint.LuaExportHelper luaExportHelper;

		// Token: 0x040063E1 RID: 25569
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040063E2 RID: 25570
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040063E3 RID: 25571
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040063E4 RID: 25572
		private LuaFunction m_InitializeClientWorldConfigDataWaypointInfo_hotfix;

		// Token: 0x040063E5 RID: 25573
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x040063E6 RID: 25574
		private LuaFunction m_Tick_hotfix;

		// Token: 0x040063E7 RID: 25575
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x040063E8 RID: 25576
		private LuaFunction m_Draw_hotfix;

		// Token: 0x040063E9 RID: 25577
		private LuaFunction m_DrawArrowVector3Vector3Color_hotfix;

		// Token: 0x040063EA RID: 25578
		private LuaFunction m_DoPauseBoolean_hotfix;

		// Token: 0x040063EB RID: 25579
		private LuaFunction m_LocateVector2_hotfix;

		// Token: 0x040063EC RID: 25580
		private LuaFunction m_SetStatusWayPointStatus_hotfix;

		// Token: 0x040063ED RID: 25581
		private LuaFunction m_GetStatus_hotfix;

		// Token: 0x040063EE RID: 25582
		private LuaFunction m_SetScenarioStateConfigDataWaypointInfoConfigDataScenarioInfo_hotfix;

		// Token: 0x040063EF RID: 25583
		private LuaFunction m_SetCanClickBoolean_hotfix;

		// Token: 0x040063F0 RID: 25584
		private LuaFunction m_GetClickTransform_hotfix;

		// Token: 0x040063F1 RID: 25585
		private LuaFunction m_PlayAnimationStringBoolean_hotfix;

		// Token: 0x040063F2 RID: 25586
		private LuaFunction m_SetVisibleBoolean_hotfix;

		// Token: 0x040063F3 RID: 25587
		private LuaFunction m_IsVisible_hotfix;

		// Token: 0x040063F4 RID: 25588
		private LuaFunction m_SetUISiblingIndexInt32_hotfix;

		// Token: 0x040063F5 RID: 25589
		private LuaFunction m_OnUIPointerDown_hotfix;

		// Token: 0x040063F6 RID: 25590
		private LuaFunction m_OnUIPointerUp_hotfix;

		// Token: 0x040063F7 RID: 25591
		private LuaFunction m_OnUIClick_hotfix;

		// Token: 0x040063F8 RID: 25592
		private LuaFunction m_get_Position_hotfix;

		// Token: 0x040063F9 RID: 25593
		private LuaFunction m_get_WaypointInfo_hotfix;

		// Token: 0x02000989 RID: 2441
		public new class LuaExportHelper
		{
			// Token: 0x06008C8A RID: 35978 RVA: 0x00290BAC File Offset: 0x0028EDAC
			public LuaExportHelper(ClientWorldWaypoint owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008C8B RID: 35979 RVA: 0x00290BBC File Offset: 0x0028EDBC
			public void __callBase_Dispose()
			{
				this.m_owner.__callBase_Dispose();
			}

			// Token: 0x06008C8C RID: 35980 RVA: 0x00290BCC File Offset: 0x0028EDCC
			public void __callBase_Tick()
			{
				this.m_owner.__callBase_Tick();
			}

			// Token: 0x06008C8D RID: 35981 RVA: 0x00290BDC File Offset: 0x0028EDDC
			public void __callBase_TickGraphic(float dt)
			{
				this.m_owner.__callBase_TickGraphic(dt);
			}

			// Token: 0x06008C8E RID: 35982 RVA: 0x00290BEC File Offset: 0x0028EDEC
			public void __callBase_Draw()
			{
				this.m_owner.__callBase_Draw();
			}

			// Token: 0x06008C8F RID: 35983 RVA: 0x00290BFC File Offset: 0x0028EDFC
			public void __callBase_Pause(bool pause)
			{
				this.m_owner.__callBase_Pause(pause);
			}

			// Token: 0x06008C90 RID: 35984 RVA: 0x00290C0C File Offset: 0x0028EE0C
			public void __callBase_DoPause(bool pause)
			{
				this.m_owner.__callBase_DoPause(pause);
			}

			// Token: 0x06008C91 RID: 35985 RVA: 0x00290C1C File Offset: 0x0028EE1C
			public void __callBase_DeleteMe()
			{
				this.m_owner.__callBase_DeleteMe();
			}

			// Token: 0x17001D6C RID: 7532
			// (get) Token: 0x06008C92 RID: 35986 RVA: 0x00290C2C File Offset: 0x0028EE2C
			// (set) Token: 0x06008C93 RID: 35987 RVA: 0x00290C3C File Offset: 0x0028EE3C
			public ClientWorld m_clientWorld
			{
				get
				{
					return this.m_owner.m_clientWorld;
				}
				set
				{
					this.m_owner.m_clientWorld = value;
				}
			}

			// Token: 0x17001D6D RID: 7533
			// (get) Token: 0x06008C94 RID: 35988 RVA: 0x00290C4C File Offset: 0x0028EE4C
			// (set) Token: 0x06008C95 RID: 35989 RVA: 0x00290C5C File Offset: 0x0028EE5C
			public ConfigDataWaypointInfo m_waypointInfo
			{
				get
				{
					return this.m_owner.m_waypointInfo;
				}
				set
				{
					this.m_owner.m_waypointInfo = value;
				}
			}

			// Token: 0x17001D6E RID: 7534
			// (get) Token: 0x06008C96 RID: 35990 RVA: 0x00290C6C File Offset: 0x0028EE6C
			// (set) Token: 0x06008C97 RID: 35991 RVA: 0x00290C7C File Offset: 0x0028EE7C
			public WayPointStatus m_status
			{
				get
				{
					return this.m_owner.m_status;
				}
				set
				{
					this.m_owner.m_status = value;
				}
			}

			// Token: 0x17001D6F RID: 7535
			// (get) Token: 0x06008C98 RID: 35992 RVA: 0x00290C8C File Offset: 0x0028EE8C
			// (set) Token: 0x06008C99 RID: 35993 RVA: 0x00290C9C File Offset: 0x0028EE9C
			public GenericGraphic m_graphic
			{
				get
				{
					return this.m_owner.m_graphic;
				}
				set
				{
					this.m_owner.m_graphic = value;
				}
			}

			// Token: 0x17001D70 RID: 7536
			// (get) Token: 0x06008C9A RID: 35994 RVA: 0x00290CAC File Offset: 0x0028EEAC
			// (set) Token: 0x06008C9B RID: 35995 RVA: 0x00290CBC File Offset: 0x0028EEBC
			public Vector2 m_position
			{
				get
				{
					return this.m_owner.m_position;
				}
				set
				{
					this.m_owner.m_position = value;
				}
			}

			// Token: 0x17001D71 RID: 7537
			// (get) Token: 0x06008C9C RID: 35996 RVA: 0x00290CCC File Offset: 0x0028EECC
			// (set) Token: 0x06008C9D RID: 35997 RVA: 0x00290CDC File Offset: 0x0028EEDC
			public bool m_isVisible
			{
				get
				{
					return this.m_owner.m_isVisible;
				}
				set
				{
					this.m_owner.m_isVisible = value;
				}
			}

			// Token: 0x17001D72 RID: 7538
			// (get) Token: 0x06008C9E RID: 35998 RVA: 0x00290CEC File Offset: 0x0028EEEC
			// (set) Token: 0x06008C9F RID: 35999 RVA: 0x00290CFC File Offset: 0x0028EEFC
			public WorldWaypointUIController m_uiController
			{
				get
				{
					return this.m_owner.m_uiController;
				}
				set
				{
					this.m_owner.m_uiController = value;
				}
			}

			// Token: 0x17001D73 RID: 7539
			// (get) Token: 0x06008CA0 RID: 36000 RVA: 0x00290D0C File Offset: 0x0028EF0C
			// (set) Token: 0x06008CA1 RID: 36001 RVA: 0x00290D1C File Offset: 0x0028EF1C
			public CommonUIStateController m_graphicUIStateController
			{
				get
				{
					return this.m_owner.m_graphicUIStateController;
				}
				set
				{
					this.m_owner.m_graphicUIStateController = value;
				}
			}

			// Token: 0x17001D74 RID: 7540
			// (get) Token: 0x06008CA2 RID: 36002 RVA: 0x00290D2C File Offset: 0x0028EF2C
			// (set) Token: 0x06008CA3 RID: 36003 RVA: 0x00290D3C File Offset: 0x0028EF3C
			public Vector3 m_uiInitScale
			{
				get
				{
					return this.m_owner.m_uiInitScale;
				}
				set
				{
					this.m_owner.m_uiInitScale = value;
				}
			}

			// Token: 0x17001D75 RID: 7541
			// (get) Token: 0x06008CA4 RID: 36004 RVA: 0x00290D4C File Offset: 0x0028EF4C
			// (set) Token: 0x06008CA5 RID: 36005 RVA: 0x00290D5C File Offset: 0x0028EF5C
			public float m_graphicInitScale
			{
				get
				{
					return this.m_owner.m_graphicInitScale;
				}
				set
				{
					this.m_owner.m_graphicInitScale = value;
				}
			}

			// Token: 0x17001D76 RID: 7542
			// (get) Token: 0x06008CA6 RID: 36006 RVA: 0x00290D6C File Offset: 0x0028EF6C
			// (set) Token: 0x06008CA7 RID: 36007 RVA: 0x00290D7C File Offset: 0x0028EF7C
			public bool m_isPointerDown
			{
				get
				{
					return this.m_owner.m_isPointerDown;
				}
				set
				{
					this.m_owner.m_isPointerDown = value;
				}
			}

			// Token: 0x17001D77 RID: 7543
			// (get) Token: 0x06008CA8 RID: 36008 RVA: 0x00290D8C File Offset: 0x0028EF8C
			// (set) Token: 0x06008CA9 RID: 36009 RVA: 0x00290D9C File Offset: 0x0028EF9C
			public float m_scale
			{
				get
				{
					return this.m_owner.m_scale;
				}
				set
				{
					this.m_owner.m_scale = value;
				}
			}

			// Token: 0x06008CAA RID: 36010 RVA: 0x00290DAC File Offset: 0x0028EFAC
			public void DrawArrow(Vector3 p0, Vector3 p1, Color color)
			{
				this.m_owner.DrawArrow(p0, p1, color);
			}

			// Token: 0x06008CAB RID: 36011 RVA: 0x00290DBC File Offset: 0x0028EFBC
			public void PlayAnimation(string name, bool loop)
			{
				this.m_owner.PlayAnimation(name, loop);
			}

			// Token: 0x06008CAC RID: 36012 RVA: 0x00290DCC File Offset: 0x0028EFCC
			public void OnUIPointerDown()
			{
				this.m_owner.OnUIPointerDown();
			}

			// Token: 0x06008CAD RID: 36013 RVA: 0x00290DDC File Offset: 0x0028EFDC
			public void OnUIPointerUp()
			{
				this.m_owner.OnUIPointerUp();
			}

			// Token: 0x06008CAE RID: 36014 RVA: 0x00290DEC File Offset: 0x0028EFEC
			public void OnUIClick()
			{
				this.m_owner.OnUIClick();
			}

			// Token: 0x040063FA RID: 25594
			private ClientWorldWaypoint m_owner;
		}
	}
}
