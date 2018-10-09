using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200098B RID: 2443
	[HotFix]
	public class WorldCamera : CameraBase
	{
		// Token: 0x06008CB1 RID: 36017 RVA: 0x00290DFC File Offset: 0x0028EFFC
		public WorldCamera()
		{
			this.m_eventSystem = EventSystem.current;
			this.m_pointData = new PointerEventData(this.m_eventSystem);
			this.m_raycastResults = new List<RaycastResult>();
			this.m_touchStatus = new TouchStatus[2];
			for (int i = 0; i < this.m_touchStatus.Length; i++)
			{
				this.m_touchStatus[i] = new TouchStatus();
			}
			this.m_enableTouchMove = true;
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

		// Token: 0x06008CB2 RID: 36018 RVA: 0x00290EC4 File Offset: 0x0028F0C4
		public void Initialize(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeGameObject_hotfix != null)
			{
				this.m_InitializeGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Initialize(go, Utility.FindChildGameObject(go, "Animation", true));
			this.m_initPosition = go.transform.localPosition;
			this.m_initFov = this.m_camera.fieldOfView;
			this.m_camera.transparencySortMode = TransparencySortMode.Orthographic;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_height = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_World_CameraHeight) * 0.01f;
			this.m_viewHeightMin = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_World_CameraHeightMin) * 0.01f;
			this.m_viewHeightMax = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_World_CameraHeightMax) * 0.01f;
		}

		// Token: 0x06008CB3 RID: 36019 RVA: 0x00290FC4 File Offset: 0x0028F1C4
		public void Start(ConfigDataWorldMapInfo worldMap)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartConfigDataWorldMapInfo_hotfix != null)
			{
				this.m_StartConfigDataWorldMapInfo_hotfix.call(new object[]
				{
					this,
					worldMap
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (worldMap == null)
			{
				return;
			}
			this.m_camera.transform.localPosition = this.m_initPosition;
			this.m_camera.fieldOfView = this.m_initFov;
			this.m_mapSizeHalf.x = (float)worldMap.BackgroundWidth * 2f * 0.5f;
			this.m_mapSizeHalf.y = (float)worldMap.BackgroundHeight * 2f * 0.5f;
			this.m_isFollowing = false;
		}

		// Token: 0x06008CB4 RID: 36020 RVA: 0x002910A8 File Offset: 0x0028F2A8
		public void EnableTouchMove(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableTouchMoveBoolean_hotfix != null)
			{
				this.m_EnableTouchMoveBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enableTouchMove = enable;
			if (!enable)
			{
				this.m_touchMoveVelocity = Vector2.zero;
				foreach (TouchStatus touchStatus2 in this.m_touchStatus)
				{
					touchStatus2.m_pressed = false;
				}
			}
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x00291158 File Offset: 0x0028F358
		public void Update(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSingle_hotfix != null)
			{
				this.m_UpdateSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_camera == null)
			{
				return;
			}
			if (this.IsSmoothMoving())
			{
				this.m_smoothMoveTime += dt;
				float num = Mathf.Clamp01(this.m_smoothMoveTime / this.m_smoothMoveTotalTime);
				num = Easing.Sinusoidal.InOut(num);
				this.m_position = Vector2.LerpUnclamped(this.m_smoothMoveStartPosition, this.m_smoothMoveEndPosition, num);
				if (this.m_onSmoothMoveEnd != null && !this.IsSmoothMoving())
				{
					Action onSmoothMoveEnd = this.m_onSmoothMoveEnd;
					this.m_onSmoothMoveEnd = null;
					onSmoothMoveEnd();
				}
			}
			else
			{
				if (this.m_isFollowing)
				{
					this.m_position = Vector2.SmoothDamp(this.m_position, this.m_followTargetPosition, ref this.m_followVelocity, 0.2f, 100f, dt);
				}
				if (this.m_enableTouchMove)
				{
					this.UpdateTouch(dt);
				}
			}
			this.m_camera.transform.localPosition = new Vector3(this.m_position.x, this.m_position.y, -this.m_height) + base.GetAnimationOffset();
		}

		// Token: 0x06008CB6 RID: 36022 RVA: 0x002912D8 File Offset: 0x0028F4D8
		private static Vector2 ScreenPositionToViewPosition(Vector2 p, float viewWidth, float viewHeight)
		{
			return new Vector2(p.x / (float)Screen.width * viewWidth, p.y / (float)Screen.height * viewHeight);
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x00291300 File Offset: 0x0028F500
		private bool IsTouchUI(Vector2 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTouchUIVector2_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTouchUIVector2_hotfix.call(new object[]
				{
					this,
					pos
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_eventSystem == null)
			{
				return false;
			}
			this.m_pointData.position = pos;
			this.m_raycastResults.Clear();
			this.m_eventSystem.RaycastAll(this.m_pointData, this.m_raycastResults);
			if (this.m_raycastResults.Count == 0)
			{
				return false;
			}
			WorldWaypointUIController componentInParent = this.m_raycastResults[0].gameObject.GetComponentInParent<WorldWaypointUIController>();
			if (componentInParent != null)
			{
				this.m_hitWaypointUIController = componentInParent;
				return false;
			}
			WorldEventActorUIController componentInParent2 = this.m_raycastResults[0].gameObject.GetComponentInParent<WorldEventActorUIController>();
			if (componentInParent2 != null)
			{
				this.m_hitEventActorUIController = componentInParent2;
				return false;
			}
			return !(this.m_raycastResults[0].gameObject.name == "WorldMapHitImage") && !(this.m_raycastResults[0].gameObject.name == "DisableInput");
		}

		// Token: 0x06008CB8 RID: 36024 RVA: 0x00291484 File Offset: 0x0028F684
		private void UpdateTouch(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTouchSingle_hotfix != null)
			{
				this.m_UpdateTouchSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.fingerId < 2)
				{
					TouchStatus touchStatus = this.m_touchStatus[touch.fingerId];
					if (touch.phase == TouchPhase.Began)
					{
						if (!this.IsTouchUI(touch.position))
						{
							touchStatus.m_beginPosition = (touchStatus.m_currentPosition = (touchStatus.m_prevPosition = touch.position));
							touchStatus.m_pressed = true;
						}
					}
					else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
					{
						touchStatus.m_pressed = false;
					}
					else if (touch.phase == TouchPhase.Moved)
					{
						touchStatus.m_currentPosition = touch.position;
					}
				}
			}
			if (Input.touchCount <= 0)
			{
				TouchStatus touchStatus2 = this.m_touchStatus[0];
				if (Input.GetMouseButtonDown(0) && !this.IsTouchUI(Input.mousePosition))
				{
					touchStatus2.m_beginPosition = (touchStatus2.m_currentPosition = (touchStatus2.m_prevPosition = Input.mousePosition));
					touchStatus2.m_pressed = true;
				}
				if (Input.GetMouseButtonUp(0))
				{
					touchStatus2.m_pressed = false;
				}
				if (Input.GetMouseButton(0))
				{
					touchStatus2.m_currentPosition = Input.mousePosition;
				}
			}
			float axis = Input.GetAxis("Mouse ScrollWheel");
			if (axis != 0f)
			{
				float num = 1f - axis;
				this.m_height = Mathf.Clamp(this.m_height * num, this.m_viewHeightMin, this.m_viewHeightMax);
			}
			if (this.m_touchStatus[0].m_pressed || this.m_touchStatus[1].m_pressed)
			{
				this.m_isFollowing = false;
				float viewWidth = this.m_camera.orthographicSize * 2f * this.m_camera.aspect;
				float viewHeight = this.m_camera.orthographicSize * 2f;
				Vector2 position = this.m_position;
				if (this.m_touchStatus[0].m_pressed ^ this.m_touchStatus[1].m_pressed)
				{
					int num2 = (!this.m_touchStatus[0].m_pressed) ? 1 : 0;
					Vector2 vector = WorldCamera.ScreenPositionToViewPosition(this.m_touchStatus[num2].m_currentPosition - this.m_touchStatus[num2].m_prevPosition, viewWidth, viewHeight);
					this.m_touchStatus[num2].m_prevPosition = this.m_touchStatus[num2].m_currentPosition;
					position.x -= vector.x;
					position.y -= vector.y;
				}
				else if (this.m_touchStatus[0].m_pressed && this.m_touchStatus[1].m_pressed && axis == 0f)
				{
					Vector2 b = (this.m_touchStatus[0].m_prevPosition + this.m_touchStatus[1].m_prevPosition) * 0.5f;
					Vector2 a = (this.m_touchStatus[0].m_currentPosition + this.m_touchStatus[1].m_currentPosition) * 0.5f;
					float num3 = Vector2.Distance(WorldCamera.ScreenPositionToViewPosition(this.m_touchStatus[0].m_prevPosition, viewWidth, viewHeight), WorldCamera.ScreenPositionToViewPosition(this.m_touchStatus[1].m_prevPosition, viewWidth, viewHeight));
					float num4 = Vector2.Distance(WorldCamera.ScreenPositionToViewPosition(this.m_touchStatus[0].m_currentPosition, viewWidth, viewHeight), WorldCamera.ScreenPositionToViewPosition(this.m_touchStatus[1].m_currentPosition, viewWidth, viewHeight));
					this.m_touchStatus[0].m_prevPosition = this.m_touchStatus[0].m_currentPosition;
					this.m_touchStatus[1].m_prevPosition = this.m_touchStatus[1].m_currentPosition;
					Vector2 vector2 = WorldCamera.ScreenPositionToViewPosition(a - b, viewWidth, viewHeight);
					position.x -= vector2.x;
					position.y -= vector2.y;
					if (num3 > 0f && num4 > 0f)
					{
						this.m_height = Mathf.Clamp(this.m_height * num3 / num4, this.m_viewHeightMin, this.m_viewHeightMax);
					}
				}
				if (this.m_hitWaypointUIController != null || this.m_hitEventActorUIController != null)
				{
					float num5 = 0f;
					if (this.m_touchStatus[0].m_pressed)
					{
						num5 += WorldCamera.ScreenPositionToViewPosition(this.m_touchStatus[0].m_beginPosition - this.m_touchStatus[0].m_currentPosition, viewWidth, viewHeight).magnitude;
					}
					if (this.m_touchStatus[1].m_pressed)
					{
						num5 += WorldCamera.ScreenPositionToViewPosition(this.m_touchStatus[1].m_beginPosition - this.m_touchStatus[1].m_currentPosition, viewWidth, viewHeight).magnitude;
					}
					if (num5 > 0.2f)
					{
						if (this.m_hitWaypointUIController != null)
						{
							this.m_hitWaypointUIController.IgnoreClick();
							this.m_hitWaypointUIController = null;
						}
						if (this.m_hitEventActorUIController != null)
						{
							this.m_hitEventActorUIController.IgnoreClick();
							this.m_hitEventActorUIController = null;
						}
					}
				}
				if (dt > 0f)
				{
					this.m_touchMoveVelocity = (position - this.m_position) / dt;
				}
				this.m_position = this.ClampCameraPosition(position);
			}
			else
			{
				float magnitude = this.m_touchMoveVelocity.magnitude;
				if (magnitude > 0f)
				{
					float d = Math.Max(magnitude - magnitude * dt * 10f, 0f);
					this.m_touchMoveVelocity = this.m_touchMoveVelocity / magnitude * d;
					this.m_position = this.ClampCameraPosition(this.m_position + this.m_touchMoveVelocity * dt);
				}
			}
		}

		// Token: 0x06008CB9 RID: 36025 RVA: 0x00291AF0 File Offset: 0x0028FCF0
		private Vector2 ClampCameraPosition(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClampCameraPositionVector2_hotfix != null)
			{
				return (Vector2)this.m_ClampCameraPositionVector2_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float num = this.m_camera.orthographicSize * this.m_camera.aspect;
			float orthographicSize = this.m_camera.orthographicSize;
			Vector2 vector = this.GroundPositionToCameraPosition(new Vector2(0f, 0f));
			Vector2 result;
			if (num > this.m_mapSizeHalf.x + vector.x)
			{
				result.x = vector.x;
			}
			else
			{
				result.x = Mathf.Clamp(p.x, -this.m_mapSizeHalf.x + num + vector.x, this.m_mapSizeHalf.x - num + vector.x);
			}
			if (orthographicSize > this.m_mapSizeHalf.y + vector.y)
			{
				result.y = vector.y;
			}
			else
			{
				result.y = Mathf.Clamp(p.y, -this.m_mapSizeHalf.y + orthographicSize + vector.y, this.m_mapSizeHalf.y - orthographicSize + vector.y);
			}
			return result;
		}

		// Token: 0x06008CBA RID: 36026 RVA: 0x00291C7C File Offset: 0x0028FE7C
		private Vector2 GroundPositionToCameraPosition(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GroundPositionToCameraPositionVector2_hotfix != null)
			{
				return (Vector2)this.m_GroundPositionToCameraPositionVector2_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 result = p;
			result.y -= Mathf.Tan(0.34906584f) * this.m_height;
			return result;
		}

		// Token: 0x06008CBB RID: 36027 RVA: 0x00291D1C File Offset: 0x0028FF1C
		public void Look(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LookVector2_hotfix != null)
			{
				this.m_LookVector2_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_position = this.ClampCameraPosition(this.GroundPositionToCameraPosition(p));
			this.m_isFollowing = false;
			this.Update(0f);
		}

		// Token: 0x06008CBC RID: 36028 RVA: 0x00291DB4 File Offset: 0x0028FFB4
		public void SmoothLook(Vector2 p, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SmoothLookVector2Action_hotfix != null)
			{
				this.m_SmoothLookVector2Action_hotfix.call(new object[]
				{
					this,
					p,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_smoothMoveStartPosition = this.m_position;
			this.m_smoothMoveEndPosition = this.ClampCameraPosition(this.GroundPositionToCameraPosition(p));
			this.m_smoothMoveTime = 0f;
			this.m_smoothMoveTotalTime = Vector2.Distance(this.m_smoothMoveStartPosition, this.m_smoothMoveEndPosition) / (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_CameraMoveSpeed);
			this.m_isFollowing = false;
			this.m_onSmoothMoveEnd = onEnd;
			if (onEnd != null && this.m_smoothMoveTotalTime == 0f)
			{
				this.m_onSmoothMoveEnd = null;
				onEnd();
			}
		}

		// Token: 0x06008CBD RID: 36029 RVA: 0x00291EC0 File Offset: 0x002900C0
		public bool IsSmoothMoving()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSmoothMoving_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSmoothMoving_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_smoothMoveTotalTime > 0f && this.m_smoothMoveTime < this.m_smoothMoveTotalTime;
		}

		// Token: 0x06008CBE RID: 36030 RVA: 0x00291F50 File Offset: 0x00290150
		public void StartFollow()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartFollow_hotfix != null)
			{
				this.m_StartFollow_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isFollowing = true;
		}

		// Token: 0x06008CBF RID: 36031 RVA: 0x00291FB8 File Offset: 0x002901B8
		public void SetFollowPosition(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFollowPositionVector2_hotfix != null)
			{
				this.m_SetFollowPositionVector2_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isFollowing)
			{
				this.m_followTargetPosition = this.ClampCameraPosition(this.GroundPositionToCameraPosition(p));
			}
		}

		// Token: 0x06008CC0 RID: 36032 RVA: 0x00292048 File Offset: 0x00290248
		public Vector2 GetPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPosition_hotfix != null)
			{
				return (Vector2)this.m_GetPosition_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_position;
		}

		// Token: 0x06008CC1 RID: 36033 RVA: 0x002920BC File Offset: 0x002902BC
		public float GetZoomFactor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetZoomFactor_hotfix != null)
			{
				return Convert.ToSingle(this.m_GetZoomFactor_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (this.m_height - this.m_viewHeightMin) / (this.m_viewHeightMax - this.m_viewHeightMin);
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06008CC2 RID: 36034 RVA: 0x00292144 File Offset: 0x00290344
		// (set) Token: 0x06008CC3 RID: 36035 RVA: 0x00292164 File Offset: 0x00290364
		[DoNotToLua]
		public new WorldCamera.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldCamera.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008CC4 RID: 36036 RVA: 0x00292170 File Offset: 0x00290370
		private void __callBase_Initialize(GameObject cameraGo, GameObject animatorGo)
		{
			base.Initialize(cameraGo, animatorGo);
		}

		// Token: 0x06008CC5 RID: 36037 RVA: 0x0029217C File Offset: 0x0029037C
		private void __callBase_GetViewSize(out float width, out float height)
		{
			base.GetViewSize(out width, out height);
		}

		// Token: 0x06008CC6 RID: 36038 RVA: 0x00292188 File Offset: 0x00290388
		private void __callBase_PlayAnimation(string name)
		{
			base.PlayAnimation(name);
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x00292194 File Offset: 0x00290394
		private Vector3 __callBase_GetAnimationOffset()
		{
			return base.GetAnimationOffset();
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x0029219C File Offset: 0x0029039C
		private bool __callBase_IsCulled(Vector2 p)
		{
			return base.IsCulled(p);
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x002921A8 File Offset: 0x002903A8
		private bool __callBase_IsCulled(Vector2 bmin, Vector2 bmax)
		{
			return base.IsCulled(bmin, bmax);
		}

		// Token: 0x06008CCA RID: 36042 RVA: 0x002921B4 File Offset: 0x002903B4
		private void __callDele_m_onSmoothMoveEnd()
		{
			Action onSmoothMoveEnd = this.m_onSmoothMoveEnd;
			if (onSmoothMoveEnd != null)
			{
				onSmoothMoveEnd();
			}
		}

		// Token: 0x06008CCB RID: 36043 RVA: 0x002921D4 File Offset: 0x002903D4
		private void __clearDele_m_onSmoothMoveEnd()
		{
			this.m_onSmoothMoveEnd = null;
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x002921E0 File Offset: 0x002903E0
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
					this.m_InitializeGameObject_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_StartConfigDataWorldMapInfo_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_EnableTouchMoveBoolean_hotfix = (luaObj.RawGet("EnableTouchMove") as LuaFunction);
					this.m_UpdateSingle_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_IsTouchUIVector2_hotfix = (luaObj.RawGet("IsTouchUI") as LuaFunction);
					this.m_UpdateTouchSingle_hotfix = (luaObj.RawGet("UpdateTouch") as LuaFunction);
					this.m_ClampCameraPositionVector2_hotfix = (luaObj.RawGet("ClampCameraPosition") as LuaFunction);
					this.m_GroundPositionToCameraPositionVector2_hotfix = (luaObj.RawGet("GroundPositionToCameraPosition") as LuaFunction);
					this.m_LookVector2_hotfix = (luaObj.RawGet("Look") as LuaFunction);
					this.m_SmoothLookVector2Action_hotfix = (luaObj.RawGet("SmoothLook") as LuaFunction);
					this.m_IsSmoothMoving_hotfix = (luaObj.RawGet("IsSmoothMoving") as LuaFunction);
					this.m_StartFollow_hotfix = (luaObj.RawGet("StartFollow") as LuaFunction);
					this.m_SetFollowPositionVector2_hotfix = (luaObj.RawGet("SetFollowPosition") as LuaFunction);
					this.m_GetPosition_hotfix = (luaObj.RawGet("GetPosition") as LuaFunction);
					this.m_GetZoomFactor_hotfix = (luaObj.RawGet("GetZoomFactor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008CCD RID: 36045 RVA: 0x00292424 File Offset: 0x00290624
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldCamera));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040063FB RID: 25595
		private Vector2 m_position;

		// Token: 0x040063FC RID: 25596
		private float m_height;

		// Token: 0x040063FD RID: 25597
		private Vector2 m_smoothMoveStartPosition;

		// Token: 0x040063FE RID: 25598
		private Vector2 m_smoothMoveEndPosition;

		// Token: 0x040063FF RID: 25599
		private Vector2 m_touchMoveVelocity;

		// Token: 0x04006400 RID: 25600
		private Vector2 m_followTargetPosition;

		// Token: 0x04006401 RID: 25601
		private Vector2 m_followVelocity;

		// Token: 0x04006402 RID: 25602
		private bool m_enableTouchMove;

		// Token: 0x04006403 RID: 25603
		private bool m_isFollowing;

		// Token: 0x04006404 RID: 25604
		private float m_smoothMoveTime;

		// Token: 0x04006405 RID: 25605
		private float m_smoothMoveTotalTime;

		// Token: 0x04006406 RID: 25606
		private EventSystem m_eventSystem;

		// Token: 0x04006407 RID: 25607
		private PointerEventData m_pointData;

		// Token: 0x04006408 RID: 25608
		private List<RaycastResult> m_raycastResults;

		// Token: 0x04006409 RID: 25609
		private TouchStatus[] m_touchStatus;

		// Token: 0x0400640A RID: 25610
		private Vector3 m_initPosition;

		// Token: 0x0400640B RID: 25611
		private float m_initFov;

		// Token: 0x0400640C RID: 25612
		private Vector2 m_mapSizeHalf;

		// Token: 0x0400640D RID: 25613
		private float m_viewHeightMin;

		// Token: 0x0400640E RID: 25614
		private float m_viewHeightMax;

		// Token: 0x0400640F RID: 25615
		private WorldWaypointUIController m_hitWaypointUIController;

		// Token: 0x04006410 RID: 25616
		private WorldEventActorUIController m_hitEventActorUIController;

		// Token: 0x04006411 RID: 25617
		private Action m_onSmoothMoveEnd;

		// Token: 0x04006412 RID: 25618
		[DoNotToLua]
		private WorldCamera.LuaExportHelper luaExportHelper;

		// Token: 0x04006413 RID: 25619
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006414 RID: 25620
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006415 RID: 25621
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04006416 RID: 25622
		private LuaFunction m_InitializeGameObject_hotfix;

		// Token: 0x04006417 RID: 25623
		private LuaFunction m_StartConfigDataWorldMapInfo_hotfix;

		// Token: 0x04006418 RID: 25624
		private LuaFunction m_EnableTouchMoveBoolean_hotfix;

		// Token: 0x04006419 RID: 25625
		private LuaFunction m_UpdateSingle_hotfix;

		// Token: 0x0400641A RID: 25626
		private LuaFunction m_IsTouchUIVector2_hotfix;

		// Token: 0x0400641B RID: 25627
		private LuaFunction m_UpdateTouchSingle_hotfix;

		// Token: 0x0400641C RID: 25628
		private LuaFunction m_ClampCameraPositionVector2_hotfix;

		// Token: 0x0400641D RID: 25629
		private LuaFunction m_GroundPositionToCameraPositionVector2_hotfix;

		// Token: 0x0400641E RID: 25630
		private LuaFunction m_LookVector2_hotfix;

		// Token: 0x0400641F RID: 25631
		private LuaFunction m_SmoothLookVector2Action_hotfix;

		// Token: 0x04006420 RID: 25632
		private LuaFunction m_IsSmoothMoving_hotfix;

		// Token: 0x04006421 RID: 25633
		private LuaFunction m_StartFollow_hotfix;

		// Token: 0x04006422 RID: 25634
		private LuaFunction m_SetFollowPositionVector2_hotfix;

		// Token: 0x04006423 RID: 25635
		private LuaFunction m_GetPosition_hotfix;

		// Token: 0x04006424 RID: 25636
		private LuaFunction m_GetZoomFactor_hotfix;

		// Token: 0x0200098C RID: 2444
		public new class LuaExportHelper
		{
			// Token: 0x06008CCE RID: 36046 RVA: 0x0029248C File Offset: 0x0029068C
			public LuaExportHelper(WorldCamera owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008CCF RID: 36047 RVA: 0x0029249C File Offset: 0x0029069C
			public void __callBase_Initialize(GameObject cameraGo, GameObject animatorGo)
			{
				this.m_owner.__callBase_Initialize(cameraGo, animatorGo);
			}

			// Token: 0x06008CD0 RID: 36048 RVA: 0x002924AC File Offset: 0x002906AC
			public void __callBase_GetViewSize(out float width, out float height)
			{
				this.m_owner.__callBase_GetViewSize(out width, out height);
			}

			// Token: 0x06008CD1 RID: 36049 RVA: 0x002924BC File Offset: 0x002906BC
			public void __callBase_PlayAnimation(string name)
			{
				this.m_owner.__callBase_PlayAnimation(name);
			}

			// Token: 0x06008CD2 RID: 36050 RVA: 0x002924CC File Offset: 0x002906CC
			public Vector3 __callBase_GetAnimationOffset()
			{
				return this.m_owner.__callBase_GetAnimationOffset();
			}

			// Token: 0x06008CD3 RID: 36051 RVA: 0x002924DC File Offset: 0x002906DC
			public bool __callBase_IsCulled(Vector2 p)
			{
				return this.m_owner.__callBase_IsCulled(p);
			}

			// Token: 0x06008CD4 RID: 36052 RVA: 0x002924EC File Offset: 0x002906EC
			public bool __callBase_IsCulled(Vector2 bmin, Vector2 bmax)
			{
				return this.m_owner.__callBase_IsCulled(bmin, bmax);
			}

			// Token: 0x06008CD5 RID: 36053 RVA: 0x002924FC File Offset: 0x002906FC
			public void __callDele_m_onSmoothMoveEnd()
			{
				this.m_owner.__callDele_m_onSmoothMoveEnd();
			}

			// Token: 0x06008CD6 RID: 36054 RVA: 0x0029250C File Offset: 0x0029070C
			public void __clearDele_m_onSmoothMoveEnd()
			{
				this.m_owner.__clearDele_m_onSmoothMoveEnd();
			}

			// Token: 0x17001D79 RID: 7545
			// (get) Token: 0x06008CD7 RID: 36055 RVA: 0x0029251C File Offset: 0x0029071C
			// (set) Token: 0x06008CD8 RID: 36056 RVA: 0x0029252C File Offset: 0x0029072C
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

			// Token: 0x17001D7A RID: 7546
			// (get) Token: 0x06008CD9 RID: 36057 RVA: 0x0029253C File Offset: 0x0029073C
			// (set) Token: 0x06008CDA RID: 36058 RVA: 0x0029254C File Offset: 0x0029074C
			public float m_height
			{
				get
				{
					return this.m_owner.m_height;
				}
				set
				{
					this.m_owner.m_height = value;
				}
			}

			// Token: 0x17001D7B RID: 7547
			// (get) Token: 0x06008CDB RID: 36059 RVA: 0x0029255C File Offset: 0x0029075C
			// (set) Token: 0x06008CDC RID: 36060 RVA: 0x0029256C File Offset: 0x0029076C
			public Vector2 m_smoothMoveStartPosition
			{
				get
				{
					return this.m_owner.m_smoothMoveStartPosition;
				}
				set
				{
					this.m_owner.m_smoothMoveStartPosition = value;
				}
			}

			// Token: 0x17001D7C RID: 7548
			// (get) Token: 0x06008CDD RID: 36061 RVA: 0x0029257C File Offset: 0x0029077C
			// (set) Token: 0x06008CDE RID: 36062 RVA: 0x0029258C File Offset: 0x0029078C
			public Vector2 m_smoothMoveEndPosition
			{
				get
				{
					return this.m_owner.m_smoothMoveEndPosition;
				}
				set
				{
					this.m_owner.m_smoothMoveEndPosition = value;
				}
			}

			// Token: 0x17001D7D RID: 7549
			// (get) Token: 0x06008CDF RID: 36063 RVA: 0x0029259C File Offset: 0x0029079C
			// (set) Token: 0x06008CE0 RID: 36064 RVA: 0x002925AC File Offset: 0x002907AC
			public Vector2 m_touchMoveVelocity
			{
				get
				{
					return this.m_owner.m_touchMoveVelocity;
				}
				set
				{
					this.m_owner.m_touchMoveVelocity = value;
				}
			}

			// Token: 0x17001D7E RID: 7550
			// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x002925BC File Offset: 0x002907BC
			// (set) Token: 0x06008CE2 RID: 36066 RVA: 0x002925CC File Offset: 0x002907CC
			public Vector2 m_followTargetPosition
			{
				get
				{
					return this.m_owner.m_followTargetPosition;
				}
				set
				{
					this.m_owner.m_followTargetPosition = value;
				}
			}

			// Token: 0x17001D7F RID: 7551
			// (get) Token: 0x06008CE3 RID: 36067 RVA: 0x002925DC File Offset: 0x002907DC
			// (set) Token: 0x06008CE4 RID: 36068 RVA: 0x002925EC File Offset: 0x002907EC
			public Vector2 m_followVelocity
			{
				get
				{
					return this.m_owner.m_followVelocity;
				}
				set
				{
					this.m_owner.m_followVelocity = value;
				}
			}

			// Token: 0x17001D80 RID: 7552
			// (get) Token: 0x06008CE5 RID: 36069 RVA: 0x002925FC File Offset: 0x002907FC
			// (set) Token: 0x06008CE6 RID: 36070 RVA: 0x0029260C File Offset: 0x0029080C
			public bool m_enableTouchMove
			{
				get
				{
					return this.m_owner.m_enableTouchMove;
				}
				set
				{
					this.m_owner.m_enableTouchMove = value;
				}
			}

			// Token: 0x17001D81 RID: 7553
			// (get) Token: 0x06008CE7 RID: 36071 RVA: 0x0029261C File Offset: 0x0029081C
			// (set) Token: 0x06008CE8 RID: 36072 RVA: 0x0029262C File Offset: 0x0029082C
			public bool m_isFollowing
			{
				get
				{
					return this.m_owner.m_isFollowing;
				}
				set
				{
					this.m_owner.m_isFollowing = value;
				}
			}

			// Token: 0x17001D82 RID: 7554
			// (get) Token: 0x06008CE9 RID: 36073 RVA: 0x0029263C File Offset: 0x0029083C
			// (set) Token: 0x06008CEA RID: 36074 RVA: 0x0029264C File Offset: 0x0029084C
			public float m_smoothMoveTime
			{
				get
				{
					return this.m_owner.m_smoothMoveTime;
				}
				set
				{
					this.m_owner.m_smoothMoveTime = value;
				}
			}

			// Token: 0x17001D83 RID: 7555
			// (get) Token: 0x06008CEB RID: 36075 RVA: 0x0029265C File Offset: 0x0029085C
			// (set) Token: 0x06008CEC RID: 36076 RVA: 0x0029266C File Offset: 0x0029086C
			public float m_smoothMoveTotalTime
			{
				get
				{
					return this.m_owner.m_smoothMoveTotalTime;
				}
				set
				{
					this.m_owner.m_smoothMoveTotalTime = value;
				}
			}

			// Token: 0x17001D84 RID: 7556
			// (get) Token: 0x06008CED RID: 36077 RVA: 0x0029267C File Offset: 0x0029087C
			// (set) Token: 0x06008CEE RID: 36078 RVA: 0x0029268C File Offset: 0x0029088C
			public EventSystem m_eventSystem
			{
				get
				{
					return this.m_owner.m_eventSystem;
				}
				set
				{
					this.m_owner.m_eventSystem = value;
				}
			}

			// Token: 0x17001D85 RID: 7557
			// (get) Token: 0x06008CEF RID: 36079 RVA: 0x0029269C File Offset: 0x0029089C
			// (set) Token: 0x06008CF0 RID: 36080 RVA: 0x002926AC File Offset: 0x002908AC
			public PointerEventData m_pointData
			{
				get
				{
					return this.m_owner.m_pointData;
				}
				set
				{
					this.m_owner.m_pointData = value;
				}
			}

			// Token: 0x17001D86 RID: 7558
			// (get) Token: 0x06008CF1 RID: 36081 RVA: 0x002926BC File Offset: 0x002908BC
			// (set) Token: 0x06008CF2 RID: 36082 RVA: 0x002926CC File Offset: 0x002908CC
			public List<RaycastResult> m_raycastResults
			{
				get
				{
					return this.m_owner.m_raycastResults;
				}
				set
				{
					this.m_owner.m_raycastResults = value;
				}
			}

			// Token: 0x17001D87 RID: 7559
			// (get) Token: 0x06008CF3 RID: 36083 RVA: 0x002926DC File Offset: 0x002908DC
			// (set) Token: 0x06008CF4 RID: 36084 RVA: 0x002926EC File Offset: 0x002908EC
			public TouchStatus[] m_touchStatus
			{
				get
				{
					return this.m_owner.m_touchStatus;
				}
				set
				{
					this.m_owner.m_touchStatus = value;
				}
			}

			// Token: 0x17001D88 RID: 7560
			// (get) Token: 0x06008CF5 RID: 36085 RVA: 0x002926FC File Offset: 0x002908FC
			// (set) Token: 0x06008CF6 RID: 36086 RVA: 0x0029270C File Offset: 0x0029090C
			public Vector3 m_initPosition
			{
				get
				{
					return this.m_owner.m_initPosition;
				}
				set
				{
					this.m_owner.m_initPosition = value;
				}
			}

			// Token: 0x17001D89 RID: 7561
			// (get) Token: 0x06008CF7 RID: 36087 RVA: 0x0029271C File Offset: 0x0029091C
			// (set) Token: 0x06008CF8 RID: 36088 RVA: 0x0029272C File Offset: 0x0029092C
			public float m_initFov
			{
				get
				{
					return this.m_owner.m_initFov;
				}
				set
				{
					this.m_owner.m_initFov = value;
				}
			}

			// Token: 0x17001D8A RID: 7562
			// (get) Token: 0x06008CF9 RID: 36089 RVA: 0x0029273C File Offset: 0x0029093C
			// (set) Token: 0x06008CFA RID: 36090 RVA: 0x0029274C File Offset: 0x0029094C
			public Vector2 m_mapSizeHalf
			{
				get
				{
					return this.m_owner.m_mapSizeHalf;
				}
				set
				{
					this.m_owner.m_mapSizeHalf = value;
				}
			}

			// Token: 0x17001D8B RID: 7563
			// (get) Token: 0x06008CFB RID: 36091 RVA: 0x0029275C File Offset: 0x0029095C
			// (set) Token: 0x06008CFC RID: 36092 RVA: 0x0029276C File Offset: 0x0029096C
			public float m_viewHeightMin
			{
				get
				{
					return this.m_owner.m_viewHeightMin;
				}
				set
				{
					this.m_owner.m_viewHeightMin = value;
				}
			}

			// Token: 0x17001D8C RID: 7564
			// (get) Token: 0x06008CFD RID: 36093 RVA: 0x0029277C File Offset: 0x0029097C
			// (set) Token: 0x06008CFE RID: 36094 RVA: 0x0029278C File Offset: 0x0029098C
			public float m_viewHeightMax
			{
				get
				{
					return this.m_owner.m_viewHeightMax;
				}
				set
				{
					this.m_owner.m_viewHeightMax = value;
				}
			}

			// Token: 0x17001D8D RID: 7565
			// (get) Token: 0x06008CFF RID: 36095 RVA: 0x0029279C File Offset: 0x0029099C
			// (set) Token: 0x06008D00 RID: 36096 RVA: 0x002927AC File Offset: 0x002909AC
			public WorldWaypointUIController m_hitWaypointUIController
			{
				get
				{
					return this.m_owner.m_hitWaypointUIController;
				}
				set
				{
					this.m_owner.m_hitWaypointUIController = value;
				}
			}

			// Token: 0x17001D8E RID: 7566
			// (get) Token: 0x06008D01 RID: 36097 RVA: 0x002927BC File Offset: 0x002909BC
			// (set) Token: 0x06008D02 RID: 36098 RVA: 0x002927CC File Offset: 0x002909CC
			public WorldEventActorUIController m_hitEventActorUIController
			{
				get
				{
					return this.m_owner.m_hitEventActorUIController;
				}
				set
				{
					this.m_owner.m_hitEventActorUIController = value;
				}
			}

			// Token: 0x17001D8F RID: 7567
			// (get) Token: 0x06008D03 RID: 36099 RVA: 0x002927DC File Offset: 0x002909DC
			// (set) Token: 0x06008D04 RID: 36100 RVA: 0x002927EC File Offset: 0x002909EC
			public Action m_onSmoothMoveEnd
			{
				get
				{
					return this.m_owner.m_onSmoothMoveEnd;
				}
				set
				{
					this.m_owner.m_onSmoothMoveEnd = value;
				}
			}

			// Token: 0x06008D05 RID: 36101 RVA: 0x002927FC File Offset: 0x002909FC
			public static Vector2 ScreenPositionToViewPosition(Vector2 p, float viewWidth, float viewHeight)
			{
				return WorldCamera.ScreenPositionToViewPosition(p, viewWidth, viewHeight);
			}

			// Token: 0x06008D06 RID: 36102 RVA: 0x00292808 File Offset: 0x00290A08
			public bool IsTouchUI(Vector2 pos)
			{
				return this.m_owner.IsTouchUI(pos);
			}

			// Token: 0x06008D07 RID: 36103 RVA: 0x00292818 File Offset: 0x00290A18
			public void UpdateTouch(float dt)
			{
				this.m_owner.UpdateTouch(dt);
			}

			// Token: 0x06008D08 RID: 36104 RVA: 0x00292828 File Offset: 0x00290A28
			public Vector2 ClampCameraPosition(Vector2 p)
			{
				return this.m_owner.ClampCameraPosition(p);
			}

			// Token: 0x06008D09 RID: 36105 RVA: 0x00292838 File Offset: 0x00290A38
			public Vector2 GroundPositionToCameraPosition(Vector2 p)
			{
				return this.m_owner.GroundPositionToCameraPosition(p);
			}

			// Token: 0x04006425 RID: 25637
			private WorldCamera m_owner;
		}
	}
}
