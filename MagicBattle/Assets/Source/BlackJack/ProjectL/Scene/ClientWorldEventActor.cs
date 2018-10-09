using System;
using BlackJack.BJFramework.Runtime.Lua;
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
	// Token: 0x02000982 RID: 2434
	[HotFix]
	public class ClientWorldEventActor : Entity
	{
		// Token: 0x06008B96 RID: 35734 RVA: 0x0028B93C File Offset: 0x00289B3C
		public ClientWorldEventActor()
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

		// Token: 0x06008B97 RID: 35735 RVA: 0x0028B9B4 File Offset: 0x00289BB4
		public void Initialize(ClientWorld world, ConfigDataEventInfo eventInfo, RandomEvent randomEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeClientWorldConfigDataEventInfoRandomEvent_hotfix != null)
			{
				this.m_InitializeClientWorldConfigDataEventInfoRandomEvent_hotfix.call(new object[]
				{
					this,
					world,
					eventInfo,
					randomEvent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientWorld = world;
			this.m_eventInfo = eventInfo;
			this.m_randomEvent = randomEvent;
			this.m_id = world.GetNextEntityId();
			this.m_graphicInitScale = (float)eventInfo.ModelScale * 0.01f;
			this.m_graphic = world.CreateGraphic(eventInfo.Model, this.m_graphicInitScale);
			if (this.m_graphic != null)
			{
				this.m_graphic.SetName("Event_" + eventInfo.ID);
				this.m_graphic.SetRotation(ClientWorldConst.FaceCameraRotation);
				this.m_graphic.SetSortingOrder(2);
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(world.EventUIPrefab, world.EventUIRoot.transform, false);
			if (gameObject != null)
			{
				gameObject.name = "Event_" + eventInfo.ID;
				this.m_uiInitScale = gameObject.transform.localScale;
				this.m_uiController = GameObjectUtility.AddControllerToGameObject<WorldEventActorUIController>(gameObject);
				this.m_uiController.SetEvent(eventInfo);
				this.m_uiController.EventOnPointerDown += this.OnUIPointerDown;
				this.m_uiController.EventOnPointerUp += this.OnUIPointerUp;
				this.m_uiController.EventOnClick += this.OnUIClick;
				gameObject.transform.localRotation = ClientWorldConst.FaceCameraRotation;
				Canvas canvas = gameObject.AddComponent<Canvas>();
				canvas.overrideSorting = true;
				canvas.sortingOrder = 2;
				gameObject.AddComponent<GraphicRaycaster>();
			}
			this.PlayAnimation("idle", true);
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x0028BBBC File Offset: 0x00289DBC
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

		// Token: 0x06008B99 RID: 35737 RVA: 0x0028BC68 File Offset: 0x00289E68
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

		// Token: 0x06008B9A RID: 35738 RVA: 0x0028BCC8 File Offset: 0x00289EC8
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
			if (this.m_appearCountdown > 0f)
			{
				this.m_appearCountdown -= dt;
				if (this.m_appearCountdown <= 0f)
				{
					this.m_appearCountdown = 0f;
					this.SetVisible(true);
				}
			}
			if (this.m_graphic != null)
			{
				this.m_graphic.Tick(dt);
			}
		}

		// Token: 0x06008B9B RID: 35739 RVA: 0x0028BE28 File Offset: 0x0028A028
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
		}

		// Token: 0x06008B9C RID: 35740 RVA: 0x0028BE88 File Offset: 0x0028A088
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

		// Token: 0x06008B9D RID: 35741 RVA: 0x0028BF10 File Offset: 0x0028A110
		public void Locate(Vector2 p, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LocateVector2Int32_hotfix != null)
			{
				this.m_LocateVector2Int32_hotfix.call(new object[]
				{
					this,
					p,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_position = p;
			this.m_direction = dir;
			if (this.m_graphic != null)
			{
				this.m_graphic.SetPosition(ClientWorld.ComputeActorPosition(this.m_position, -0.04f));
				this.m_graphic.SetDirection(this.m_direction);
			}
			if (this.m_uiController != null)
			{
				this.m_uiController.transform.localPosition = ClientWorld.ComputeActorPosition(this.m_position, -0.06f);
			}
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x0028C008 File Offset: 0x0028A208
		public void Locate(ConfigDataWaypointInfo waypointInfo, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LocateConfigDataWaypointInfoInt32_hotfix != null)
			{
				this.m_LocateConfigDataWaypointInfoInt32_hotfix.call(new object[]
				{
					this,
					waypointInfo,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (waypointInfo == null)
			{
				return;
			}
			this.m_locateWaypointInfo = waypointInfo;
			ClientWorldWaypoint waypoint = this.m_clientWorld.GetWaypoint(waypointInfo.ID);
			if (waypoint != null)
			{
				this.Locate(waypoint.Position, dir);
			}
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x0028C0BC File Offset: 0x0028A2BC
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

		// Token: 0x06008BA0 RID: 35744 RVA: 0x0028C158 File Offset: 0x0028A358
		public void ShowAppearFx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowAppearFx_hotfix != null)
			{
				this.m_ShowAppearFx_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.PlayFx("FX/Common_ABS/CommonFX/common_Refresh.prefab");
			this.SetVisible(false);
			this.m_appearCountdown = 1f;
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x0028C1D8 File Offset: 0x0028A3D8
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

		// Token: 0x06008BA2 RID: 35746 RVA: 0x0028C280 File Offset: 0x0028A480
		private void PlayFx(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayFxString_hotfix != null)
			{
				this.m_PlayFxString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null && this.m_graphic.IsVisible())
			{
				this.m_graphic.PlayFx(name, 0);
			}
		}

		// Token: 0x06008BA3 RID: 35747 RVA: 0x0028C318 File Offset: 0x0028A518
		private void PlayFx(string name, Vector3 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayFxStringVector3_hotfix != null)
			{
				this.m_PlayFxStringVector3_hotfix.call(new object[]
				{
					this,
					name,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			GenericGraphic genericGraphic = this.m_clientWorld.FxPlayer.Play(name);
			if (genericGraphic != null)
			{
				genericGraphic.SetSortingOrder(2);
				genericGraphic.SetPosition(p);
				genericGraphic.SetRotation(ClientWorldConst.FaceCameraRotation);
				genericGraphic.AutoDelete(true);
			}
		}

		// Token: 0x06008BA4 RID: 35748 RVA: 0x0028C3DC File Offset: 0x0028A5DC
		public void SetGraphicEffect(GraphicEffect e, float param1 = 0f, float param2 = 0f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix != null)
			{
				this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix.call(new object[]
				{
					this,
					e,
					param1,
					param2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.SetEffect(e, param1, param2);
			}
		}

		// Token: 0x06008BA5 RID: 35749 RVA: 0x0028C488 File Offset: 0x0028A688
		public void ClearGraphicEffect(GraphicEffect e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearGraphicEffectGraphicEffect_hotfix != null)
			{
				this.m_ClearGraphicEffectGraphicEffect_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.ClearEffect(e);
			}
		}

		// Token: 0x06008BA6 RID: 35750 RVA: 0x0028C510 File Offset: 0x0028A710
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

		// Token: 0x06008BA7 RID: 35751 RVA: 0x0028C5C0 File Offset: 0x0028A7C0
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

		// Token: 0x06008BA8 RID: 35752 RVA: 0x0028C634 File Offset: 0x0028A834
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

		// Token: 0x06008BA9 RID: 35753 RVA: 0x0028C6CC File Offset: 0x0028A8CC
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
			this.m_isPointerDown = true;
		}

		// Token: 0x06008BAA RID: 35754 RVA: 0x0028C734 File Offset: 0x0028A934
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
			this.m_isPointerDown = false;
		}

		// Token: 0x06008BAB RID: 35755 RVA: 0x0028C79C File Offset: 0x0028A99C
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
			this.m_clientWorld.OnEventActorClick(this);
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06008BAC RID: 35756 RVA: 0x0028C808 File Offset: 0x0028AA08
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

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06008BAD RID: 35757 RVA: 0x0028C87C File Offset: 0x0028AA7C
		public int Direction
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Direction_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Direction_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_direction;
			}
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06008BAE RID: 35758 RVA: 0x0028C8F0 File Offset: 0x0028AAF0
		public ConfigDataWaypointInfo LocateWaypointInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LocateWaypointInfo_hotfix != null)
				{
					return (ConfigDataWaypointInfo)this.m_get_LocateWaypointInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_locateWaypointInfo;
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06008BAF RID: 35759 RVA: 0x0028C964 File Offset: 0x0028AB64
		public ConfigDataEventInfo EventInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_EventInfo_hotfix != null)
				{
					return (ConfigDataEventInfo)this.m_get_EventInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_eventInfo;
			}
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06008BB0 RID: 35760 RVA: 0x0028C9D8 File Offset: 0x0028ABD8
		public RandomEvent RandomEvent
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_RandomEvent_hotfix != null)
				{
					return (RandomEvent)this.m_get_RandomEvent_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_randomEvent;
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06008BB1 RID: 35761 RVA: 0x0028CA4C File Offset: 0x0028AC4C
		// (set) Token: 0x06008BB2 RID: 35762 RVA: 0x0028CA6C File Offset: 0x0028AC6C
		[DoNotToLua]
		public new ClientWorldEventActor.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClientWorldEventActor.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008BB3 RID: 35763 RVA: 0x0028CA78 File Offset: 0x0028AC78
		private void __callBase_Dispose()
		{
			base.Dispose();
		}

		// Token: 0x06008BB4 RID: 35764 RVA: 0x0028CA80 File Offset: 0x0028AC80
		private void __callBase_Tick()
		{
			base.Tick();
		}

		// Token: 0x06008BB5 RID: 35765 RVA: 0x0028CA88 File Offset: 0x0028AC88
		private void __callBase_TickGraphic(float dt)
		{
			base.TickGraphic(dt);
		}

		// Token: 0x06008BB6 RID: 35766 RVA: 0x0028CA94 File Offset: 0x0028AC94
		private void __callBase_Draw()
		{
			base.Draw();
		}

		// Token: 0x06008BB7 RID: 35767 RVA: 0x0028CA9C File Offset: 0x0028AC9C
		private void __callBase_Pause(bool pause)
		{
			base.Pause(pause);
		}

		// Token: 0x06008BB8 RID: 35768 RVA: 0x0028CAA8 File Offset: 0x0028ACA8
		private void __callBase_DoPause(bool pause)
		{
			base.DoPause(pause);
		}

		// Token: 0x06008BB9 RID: 35769 RVA: 0x0028CAB4 File Offset: 0x0028ACB4
		private void __callBase_DeleteMe()
		{
			base.DeleteMe();
		}

		// Token: 0x06008BBA RID: 35770 RVA: 0x0028CABC File Offset: 0x0028ACBC
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
					this.m_InitializeClientWorldConfigDataEventInfoRandomEvent_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_DoPauseBoolean_hotfix = (luaObj.RawGet("DoPause") as LuaFunction);
					this.m_LocateVector2Int32_hotfix = (luaObj.RawGet("Locate") as LuaFunction);
					this.m_LocateConfigDataWaypointInfoInt32_hotfix = (luaObj.RawGet("Locate") as LuaFunction);
					this.m_SetCanClickBoolean_hotfix = (luaObj.RawGet("SetCanClick") as LuaFunction);
					this.m_ShowAppearFx_hotfix = (luaObj.RawGet("ShowAppearFx") as LuaFunction);
					this.m_PlayAnimationStringBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_PlayFxString_hotfix = (luaObj.RawGet("PlayFx") as LuaFunction);
					this.m_PlayFxStringVector3_hotfix = (luaObj.RawGet("PlayFx") as LuaFunction);
					this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix = (luaObj.RawGet("SetGraphicEffect") as LuaFunction);
					this.m_ClearGraphicEffectGraphicEffect_hotfix = (luaObj.RawGet("ClearGraphicEffect") as LuaFunction);
					this.m_SetVisibleBoolean_hotfix = (luaObj.RawGet("SetVisible") as LuaFunction);
					this.m_IsVisible_hotfix = (luaObj.RawGet("IsVisible") as LuaFunction);
					this.m_SetUISiblingIndexInt32_hotfix = (luaObj.RawGet("SetUISiblingIndex") as LuaFunction);
					this.m_OnUIPointerDown_hotfix = (luaObj.RawGet("OnUIPointerDown") as LuaFunction);
					this.m_OnUIPointerUp_hotfix = (luaObj.RawGet("OnUIPointerUp") as LuaFunction);
					this.m_OnUIClick_hotfix = (luaObj.RawGet("OnUIClick") as LuaFunction);
					this.m_get_Position_hotfix = (luaObj.RawGet("get_Position") as LuaFunction);
					this.m_get_Direction_hotfix = (luaObj.RawGet("get_Direction") as LuaFunction);
					this.m_get_LocateWaypointInfo_hotfix = (luaObj.RawGet("get_LocateWaypointInfo") as LuaFunction);
					this.m_get_EventInfo_hotfix = (luaObj.RawGet("get_EventInfo") as LuaFunction);
					this.m_get_RandomEvent_hotfix = (luaObj.RawGet("get_RandomEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008BBB RID: 35771 RVA: 0x0028CE14 File Offset: 0x0028B014
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientWorldEventActor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006364 RID: 25444
		private ClientWorld m_clientWorld;

		// Token: 0x04006365 RID: 25445
		private ConfigDataEventInfo m_eventInfo;

		// Token: 0x04006366 RID: 25446
		private RandomEvent m_randomEvent;

		// Token: 0x04006367 RID: 25447
		private ConfigDataWaypointInfo m_locateWaypointInfo;

		// Token: 0x04006368 RID: 25448
		private GenericGraphic m_graphic;

		// Token: 0x04006369 RID: 25449
		private Vector2 m_position;

		// Token: 0x0400636A RID: 25450
		private int m_direction;

		// Token: 0x0400636B RID: 25451
		private bool m_isVisible;

		// Token: 0x0400636C RID: 25452
		private WorldEventActorUIController m_uiController;

		// Token: 0x0400636D RID: 25453
		private Vector3 m_uiInitScale;

		// Token: 0x0400636E RID: 25454
		private float m_graphicInitScale;

		// Token: 0x0400636F RID: 25455
		private bool m_isPointerDown;

		// Token: 0x04006370 RID: 25456
		private float m_scale = 1f;

		// Token: 0x04006371 RID: 25457
		private float m_appearCountdown;

		// Token: 0x04006372 RID: 25458
		[DoNotToLua]
		private ClientWorldEventActor.LuaExportHelper luaExportHelper;

		// Token: 0x04006373 RID: 25459
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006374 RID: 25460
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006375 RID: 25461
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04006376 RID: 25462
		private LuaFunction m_InitializeClientWorldConfigDataEventInfoRandomEvent_hotfix;

		// Token: 0x04006377 RID: 25463
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04006378 RID: 25464
		private LuaFunction m_Tick_hotfix;

		// Token: 0x04006379 RID: 25465
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x0400637A RID: 25466
		private LuaFunction m_Draw_hotfix;

		// Token: 0x0400637B RID: 25467
		private LuaFunction m_DoPauseBoolean_hotfix;

		// Token: 0x0400637C RID: 25468
		private LuaFunction m_LocateVector2Int32_hotfix;

		// Token: 0x0400637D RID: 25469
		private LuaFunction m_LocateConfigDataWaypointInfoInt32_hotfix;

		// Token: 0x0400637E RID: 25470
		private LuaFunction m_SetCanClickBoolean_hotfix;

		// Token: 0x0400637F RID: 25471
		private LuaFunction m_ShowAppearFx_hotfix;

		// Token: 0x04006380 RID: 25472
		private LuaFunction m_PlayAnimationStringBoolean_hotfix;

		// Token: 0x04006381 RID: 25473
		private LuaFunction m_PlayFxString_hotfix;

		// Token: 0x04006382 RID: 25474
		private LuaFunction m_PlayFxStringVector3_hotfix;

		// Token: 0x04006383 RID: 25475
		private LuaFunction m_SetGraphicEffectGraphicEffectSingleSingle_hotfix;

		// Token: 0x04006384 RID: 25476
		private LuaFunction m_ClearGraphicEffectGraphicEffect_hotfix;

		// Token: 0x04006385 RID: 25477
		private LuaFunction m_SetVisibleBoolean_hotfix;

		// Token: 0x04006386 RID: 25478
		private LuaFunction m_IsVisible_hotfix;

		// Token: 0x04006387 RID: 25479
		private LuaFunction m_SetUISiblingIndexInt32_hotfix;

		// Token: 0x04006388 RID: 25480
		private LuaFunction m_OnUIPointerDown_hotfix;

		// Token: 0x04006389 RID: 25481
		private LuaFunction m_OnUIPointerUp_hotfix;

		// Token: 0x0400638A RID: 25482
		private LuaFunction m_OnUIClick_hotfix;

		// Token: 0x0400638B RID: 25483
		private LuaFunction m_get_Position_hotfix;

		// Token: 0x0400638C RID: 25484
		private LuaFunction m_get_Direction_hotfix;

		// Token: 0x0400638D RID: 25485
		private LuaFunction m_get_LocateWaypointInfo_hotfix;

		// Token: 0x0400638E RID: 25486
		private LuaFunction m_get_EventInfo_hotfix;

		// Token: 0x0400638F RID: 25487
		private LuaFunction m_get_RandomEvent_hotfix;

		// Token: 0x02000983 RID: 2435
		public new class LuaExportHelper
		{
			// Token: 0x06008BBC RID: 35772 RVA: 0x0028CE7C File Offset: 0x0028B07C
			public LuaExportHelper(ClientWorldEventActor owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008BBD RID: 35773 RVA: 0x0028CE8C File Offset: 0x0028B08C
			public void __callBase_Dispose()
			{
				this.m_owner.__callBase_Dispose();
			}

			// Token: 0x06008BBE RID: 35774 RVA: 0x0028CE9C File Offset: 0x0028B09C
			public void __callBase_Tick()
			{
				this.m_owner.__callBase_Tick();
			}

			// Token: 0x06008BBF RID: 35775 RVA: 0x0028CEAC File Offset: 0x0028B0AC
			public void __callBase_TickGraphic(float dt)
			{
				this.m_owner.__callBase_TickGraphic(dt);
			}

			// Token: 0x06008BC0 RID: 35776 RVA: 0x0028CEBC File Offset: 0x0028B0BC
			public void __callBase_Draw()
			{
				this.m_owner.__callBase_Draw();
			}

			// Token: 0x06008BC1 RID: 35777 RVA: 0x0028CECC File Offset: 0x0028B0CC
			public void __callBase_Pause(bool pause)
			{
				this.m_owner.__callBase_Pause(pause);
			}

			// Token: 0x06008BC2 RID: 35778 RVA: 0x0028CEDC File Offset: 0x0028B0DC
			public void __callBase_DoPause(bool pause)
			{
				this.m_owner.__callBase_DoPause(pause);
			}

			// Token: 0x06008BC3 RID: 35779 RVA: 0x0028CEEC File Offset: 0x0028B0EC
			public void __callBase_DeleteMe()
			{
				this.m_owner.__callBase_DeleteMe();
			}

			// Token: 0x17001D42 RID: 7490
			// (get) Token: 0x06008BC4 RID: 35780 RVA: 0x0028CEFC File Offset: 0x0028B0FC
			// (set) Token: 0x06008BC5 RID: 35781 RVA: 0x0028CF0C File Offset: 0x0028B10C
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

			// Token: 0x17001D43 RID: 7491
			// (get) Token: 0x06008BC6 RID: 35782 RVA: 0x0028CF1C File Offset: 0x0028B11C
			// (set) Token: 0x06008BC7 RID: 35783 RVA: 0x0028CF2C File Offset: 0x0028B12C
			public ConfigDataEventInfo m_eventInfo
			{
				get
				{
					return this.m_owner.m_eventInfo;
				}
				set
				{
					this.m_owner.m_eventInfo = value;
				}
			}

			// Token: 0x17001D44 RID: 7492
			// (get) Token: 0x06008BC8 RID: 35784 RVA: 0x0028CF3C File Offset: 0x0028B13C
			// (set) Token: 0x06008BC9 RID: 35785 RVA: 0x0028CF4C File Offset: 0x0028B14C
			public RandomEvent m_randomEvent
			{
				get
				{
					return this.m_owner.m_randomEvent;
				}
				set
				{
					this.m_owner.m_randomEvent = value;
				}
			}

			// Token: 0x17001D45 RID: 7493
			// (get) Token: 0x06008BCA RID: 35786 RVA: 0x0028CF5C File Offset: 0x0028B15C
			// (set) Token: 0x06008BCB RID: 35787 RVA: 0x0028CF6C File Offset: 0x0028B16C
			public ConfigDataWaypointInfo m_locateWaypointInfo
			{
				get
				{
					return this.m_owner.m_locateWaypointInfo;
				}
				set
				{
					this.m_owner.m_locateWaypointInfo = value;
				}
			}

			// Token: 0x17001D46 RID: 7494
			// (get) Token: 0x06008BCC RID: 35788 RVA: 0x0028CF7C File Offset: 0x0028B17C
			// (set) Token: 0x06008BCD RID: 35789 RVA: 0x0028CF8C File Offset: 0x0028B18C
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

			// Token: 0x17001D47 RID: 7495
			// (get) Token: 0x06008BCE RID: 35790 RVA: 0x0028CF9C File Offset: 0x0028B19C
			// (set) Token: 0x06008BCF RID: 35791 RVA: 0x0028CFAC File Offset: 0x0028B1AC
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

			// Token: 0x17001D48 RID: 7496
			// (get) Token: 0x06008BD0 RID: 35792 RVA: 0x0028CFBC File Offset: 0x0028B1BC
			// (set) Token: 0x06008BD1 RID: 35793 RVA: 0x0028CFCC File Offset: 0x0028B1CC
			public int m_direction
			{
				get
				{
					return this.m_owner.m_direction;
				}
				set
				{
					this.m_owner.m_direction = value;
				}
			}

			// Token: 0x17001D49 RID: 7497
			// (get) Token: 0x06008BD2 RID: 35794 RVA: 0x0028CFDC File Offset: 0x0028B1DC
			// (set) Token: 0x06008BD3 RID: 35795 RVA: 0x0028CFEC File Offset: 0x0028B1EC
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

			// Token: 0x17001D4A RID: 7498
			// (get) Token: 0x06008BD4 RID: 35796 RVA: 0x0028CFFC File Offset: 0x0028B1FC
			// (set) Token: 0x06008BD5 RID: 35797 RVA: 0x0028D00C File Offset: 0x0028B20C
			public WorldEventActorUIController m_uiController
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

			// Token: 0x17001D4B RID: 7499
			// (get) Token: 0x06008BD6 RID: 35798 RVA: 0x0028D01C File Offset: 0x0028B21C
			// (set) Token: 0x06008BD7 RID: 35799 RVA: 0x0028D02C File Offset: 0x0028B22C
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

			// Token: 0x17001D4C RID: 7500
			// (get) Token: 0x06008BD8 RID: 35800 RVA: 0x0028D03C File Offset: 0x0028B23C
			// (set) Token: 0x06008BD9 RID: 35801 RVA: 0x0028D04C File Offset: 0x0028B24C
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

			// Token: 0x17001D4D RID: 7501
			// (get) Token: 0x06008BDA RID: 35802 RVA: 0x0028D05C File Offset: 0x0028B25C
			// (set) Token: 0x06008BDB RID: 35803 RVA: 0x0028D06C File Offset: 0x0028B26C
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

			// Token: 0x17001D4E RID: 7502
			// (get) Token: 0x06008BDC RID: 35804 RVA: 0x0028D07C File Offset: 0x0028B27C
			// (set) Token: 0x06008BDD RID: 35805 RVA: 0x0028D08C File Offset: 0x0028B28C
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

			// Token: 0x17001D4F RID: 7503
			// (get) Token: 0x06008BDE RID: 35806 RVA: 0x0028D09C File Offset: 0x0028B29C
			// (set) Token: 0x06008BDF RID: 35807 RVA: 0x0028D0AC File Offset: 0x0028B2AC
			public float m_appearCountdown
			{
				get
				{
					return this.m_owner.m_appearCountdown;
				}
				set
				{
					this.m_owner.m_appearCountdown = value;
				}
			}

			// Token: 0x06008BE0 RID: 35808 RVA: 0x0028D0BC File Offset: 0x0028B2BC
			public void PlayAnimation(string name, bool loop)
			{
				this.m_owner.PlayAnimation(name, loop);
			}

			// Token: 0x06008BE1 RID: 35809 RVA: 0x0028D0CC File Offset: 0x0028B2CC
			public void PlayFx(string name)
			{
				this.m_owner.PlayFx(name);
			}

			// Token: 0x06008BE2 RID: 35810 RVA: 0x0028D0DC File Offset: 0x0028B2DC
			public void PlayFx(string name, Vector3 p)
			{
				this.m_owner.PlayFx(name, p);
			}

			// Token: 0x06008BE3 RID: 35811 RVA: 0x0028D0EC File Offset: 0x0028B2EC
			public void OnUIPointerDown()
			{
				this.m_owner.OnUIPointerDown();
			}

			// Token: 0x06008BE4 RID: 35812 RVA: 0x0028D0FC File Offset: 0x0028B2FC
			public void OnUIPointerUp()
			{
				this.m_owner.OnUIPointerUp();
			}

			// Token: 0x06008BE5 RID: 35813 RVA: 0x0028D10C File Offset: 0x0028B30C
			public void OnUIClick()
			{
				this.m_owner.OnUIClick();
			}

			// Token: 0x04006390 RID: 25488
			private ClientWorldEventActor m_owner;
		}
	}
}
