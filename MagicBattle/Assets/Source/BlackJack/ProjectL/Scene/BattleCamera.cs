using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000918 RID: 2328
	[HotFix]
	public class BattleCamera : CameraBase
	{
		// Token: 0x0600867A RID: 34426 RVA: 0x00269AEC File Offset: 0x00267CEC
		public BattleCamera()
		{
			this.m_eventSystem = EventSystem.current;
			this.m_pointData = new PointerEventData(this.m_eventSystem);
			this.m_raycastResults = new List<RaycastResult>();
			this.m_touchStatus = new TouchStatus[2];
			for (int i = 0; i < this.m_touchStatus.Length; i++)
			{
				this.m_touchStatus[i] = new TouchStatus();
			}
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

		// Token: 0x0600867B RID: 34427 RVA: 0x00269BBC File Offset: 0x00267DBC
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
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_viewSizeMin = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_CameraSizeMin) * 0.01f;
			this.m_viewSizeMax = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_CameraSizeMax) * 0.01f;
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x00269C8C File Offset: 0x00267E8C
		public void PrepareBattle(ConfigDataBattlefieldInfo battlefieldInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PrepareBattleConfigDataBattlefieldInfo_hotfix != null)
			{
				this.m_PrepareBattleConfigDataBattlefieldInfo_hotfix.call(new object[]
				{
					this,
					battlefieldInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battlefieldInfo == null)
			{
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_camera.transform.localPosition = this.m_initPosition;
			this.SetOrthographicSize((float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_CameraSize) * 0.01f);
			this.m_mapSizeHalf.x = (float)battlefieldInfo.BackgroundWidth * 2f * 0.5f;
			this.m_mapSizeHalf.y = (float)battlefieldInfo.BackgroundHeight * 2f * 0.5f;
		}

		// Token: 0x0600867D RID: 34429 RVA: 0x00269D7C File Offset: 0x00267F7C
		public void StartBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattle_hotfix != null)
			{
				this.m_StartBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600867E RID: 34430 RVA: 0x00269DDC File Offset: 0x00267FDC
		public void SetOrthographicSize(float size)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOrthographicSizeSingle_hotfix != null)
			{
				this.m_SetOrthographicSizeSingle_hotfix.call(new object[]
				{
					this,
					size
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_camera == null)
			{
				return;
			}
			this.m_camera.orthographicSize = size * CameraBase.AspectScale();
		}

		// Token: 0x0600867F RID: 34431 RVA: 0x00269E70 File Offset: 0x00268070
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
			this.UpdateEnableTouchMove();
		}

		// Token: 0x06008680 RID: 34432 RVA: 0x00269EF0 File Offset: 0x002680F0
		public void EnableTouchMove2(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableTouchMove2Boolean_hotfix != null)
			{
				this.m_EnableTouchMove2Boolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_enableTouchMove2 = enable;
			this.UpdateEnableTouchMove();
		}

		// Token: 0x06008681 RID: 34433 RVA: 0x00269F70 File Offset: 0x00268170
		private void UpdateEnableTouchMove()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateEnableTouchMove_hotfix != null)
			{
				this.m_UpdateEnableTouchMove_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_enableTouchMove2 || !this.m_enableTouchMove)
			{
				this.m_touchMoveVelocity = Vector2.zero;
				foreach (TouchStatus touchStatus2 in this.m_touchStatus)
				{
					touchStatus2.m_pressed = false;
				}
			}
		}

		// Token: 0x06008682 RID: 34434 RVA: 0x0026A018 File Offset: 0x00268218
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
			}
			else if (this.m_enableTouchMove && this.m_enableTouchMove2)
			{
				this.UpdateTouch(dt);
			}
			this.m_camera.transform.localPosition = new Vector3(this.m_position.x, this.m_position.y, this.m_camera.transform.localPosition.z) + base.GetAnimationOffset();
		}

		// Token: 0x06008683 RID: 34435 RVA: 0x0026A158 File Offset: 0x00268358
		private static Vector2 ScreenPositionToViewPosition(Vector2 p, float viewWidth, float viewHeight)
		{
			return new Vector2(p.x / (float)Screen.width * viewWidth, p.y / (float)Screen.height * viewHeight);
		}

		// Token: 0x06008684 RID: 34436 RVA: 0x0026A180 File Offset: 0x00268380
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
			return this.m_raycastResults.Count != 0 && !(this.m_raycastResults[0].gameObject.name == "BattleHitImage");
		}

		// Token: 0x06008685 RID: 34437 RVA: 0x0026A27C File Offset: 0x0026847C
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
				this.m_camera.orthographicSize = Mathf.Clamp(this.m_camera.orthographicSize / CameraBase.AspectScale() * num, this.m_viewSizeMin, this.m_viewSizeMax) * CameraBase.AspectScale();
			}
			if (this.m_touchStatus[0].m_pressed || this.m_touchStatus[1].m_pressed)
			{
				float viewWidth = this.m_camera.orthographicSize * 2f * this.m_camera.aspect;
				float viewHeight = this.m_camera.orthographicSize * 2f;
				Vector2 position = this.m_position;
				if (this.m_touchStatus[0].m_pressed ^ this.m_touchStatus[1].m_pressed)
				{
					int num2 = (!this.m_touchStatus[0].m_pressed) ? 1 : 0;
					Vector2 vector = BattleCamera.ScreenPositionToViewPosition(this.m_touchStatus[num2].m_currentPosition - this.m_touchStatus[num2].m_prevPosition, viewWidth, viewHeight);
					this.m_touchStatus[num2].m_prevPosition = this.m_touchStatus[num2].m_currentPosition;
					position.x -= vector.x;
					position.y -= vector.y;
				}
				else if (this.m_touchStatus[0].m_pressed && this.m_touchStatus[1].m_pressed && axis == 0f)
				{
					Vector2 b = (this.m_touchStatus[0].m_prevPosition + this.m_touchStatus[1].m_prevPosition) * 0.5f;
					Vector2 a = (this.m_touchStatus[0].m_currentPosition + this.m_touchStatus[1].m_currentPosition) * 0.5f;
					float num3 = Vector2.Distance(BattleCamera.ScreenPositionToViewPosition(this.m_touchStatus[0].m_prevPosition, viewWidth, viewHeight), BattleCamera.ScreenPositionToViewPosition(this.m_touchStatus[1].m_prevPosition, viewWidth, viewHeight));
					float num4 = Vector2.Distance(BattleCamera.ScreenPositionToViewPosition(this.m_touchStatus[0].m_currentPosition, viewWidth, viewHeight), BattleCamera.ScreenPositionToViewPosition(this.m_touchStatus[1].m_currentPosition, viewWidth, viewHeight));
					this.m_touchStatus[0].m_prevPosition = this.m_touchStatus[0].m_currentPosition;
					this.m_touchStatus[1].m_prevPosition = this.m_touchStatus[1].m_currentPosition;
					Vector2 vector2 = BattleCamera.ScreenPositionToViewPosition(a - b, viewWidth, viewHeight);
					position.x -= vector2.x;
					position.y -= vector2.y;
					if (num3 > 0f && num4 > 0f)
					{
						this.m_camera.orthographicSize = Mathf.Clamp(this.m_camera.orthographicSize / CameraBase.AspectScale() * num3 / num4, this.m_viewSizeMin, this.m_viewSizeMax) * CameraBase.AspectScale();
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

		// Token: 0x06008686 RID: 34438 RVA: 0x0026A804 File Offset: 0x00268A04
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
			Vector2 result;
			if (num > this.m_mapSizeHalf.x)
			{
				result.x = 0f;
			}
			else
			{
				result.x = Mathf.Clamp(p.x, -this.m_mapSizeHalf.x + num, this.m_mapSizeHalf.x - num);
			}
			if (orthographicSize > this.m_mapSizeHalf.y)
			{
				result.y = 0f;
			}
			else
			{
				result.y = Mathf.Clamp(p.y, -this.m_mapSizeHalf.y + orthographicSize, this.m_mapSizeHalf.y - orthographicSize);
			}
			return result;
		}

		// Token: 0x06008687 RID: 34439 RVA: 0x0026A948 File Offset: 0x00268B48
		private Vector2 ComputeBoundPosition(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeBoundPositionVector2_hotfix != null)
			{
				return (Vector2)this.m_ComputeBoundPositionVector2_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float num = this.m_camera.orthographicSize * this.m_camera.aspect;
			float orthographicSize = this.m_camera.orthographicSize;
			Vector2 result;
			result.x = Mathf.Clamp(p.x, this.m_position.x - num + 6f, this.m_position.x + num - 5f);
			result.y = Mathf.Clamp(p.y, this.m_position.y - orthographicSize + 6f, this.m_position.y + orthographicSize - 5f);
			return result;
		}

		// Token: 0x06008688 RID: 34440 RVA: 0x0026AA5C File Offset: 0x00268C5C
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
			this.m_smoothMoveTime = (this.m_smoothMoveTotalTime = 0f);
			this.m_position = this.ClampCameraPosition(p);
			this.Update(0f);
		}

		// Token: 0x06008689 RID: 34441 RVA: 0x0026AAF8 File Offset: 0x00268CF8
		public void SmoothLook(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SmoothLookVector2_hotfix != null)
			{
				this.m_SmoothLookVector2_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_smoothMoveStartPosition = this.m_position;
			this.m_smoothMoveEndPosition = this.ClampCameraPosition(p);
			this.m_smoothMoveTime = 0f;
			this.m_smoothMoveTotalTime = Vector2.Distance(this.m_smoothMoveStartPosition, this.m_smoothMoveEndPosition) / (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_CameraMoveSpeed);
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x0026ABC0 File Offset: 0x00268DC0
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

		// Token: 0x0600868B RID: 34443 RVA: 0x0026AC50 File Offset: 0x00268E50
		public void Bound(Vector2 p, float dt, int speed = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BoundVector2SingleInt32_hotfix != null)
			{
				this.m_BoundVector2SingleInt32_hotfix.call(new object[]
				{
					this,
					p,
					dt,
					speed
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 b = this.ComputeBoundPosition(p);
			Vector2 vector = this.ClampCameraPosition(this.m_position + p - b);
			if (speed > 0)
			{
				this.m_position = Vector2.MoveTowards(this.m_position, vector, dt * (float)speed);
			}
			else
			{
				this.m_position = vector;
			}
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x0026AD2C File Offset: 0x00268F2C
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

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x0600868D RID: 34445 RVA: 0x0026ADA0 File Offset: 0x00268FA0
		// (set) Token: 0x0600868E RID: 34446 RVA: 0x0026ADC0 File Offset: 0x00268FC0
		[DoNotToLua]
		public new BattleCamera.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleCamera.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x0026ADCC File Offset: 0x00268FCC
		private void __callBase_Initialize(GameObject cameraGo, GameObject animatorGo)
		{
			base.Initialize(cameraGo, animatorGo);
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x0026ADD8 File Offset: 0x00268FD8
		private void __callBase_GetViewSize(out float width, out float height)
		{
			base.GetViewSize(out width, out height);
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x0026ADE4 File Offset: 0x00268FE4
		private void __callBase_PlayAnimation(string name)
		{
			base.PlayAnimation(name);
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x0026ADF0 File Offset: 0x00268FF0
		private Vector3 __callBase_GetAnimationOffset()
		{
			return base.GetAnimationOffset();
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x0026ADF8 File Offset: 0x00268FF8
		private bool __callBase_IsCulled(Vector2 p)
		{
			return base.IsCulled(p);
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x0026AE04 File Offset: 0x00269004
		private bool __callBase_IsCulled(Vector2 bmin, Vector2 bmax)
		{
			return base.IsCulled(bmin, bmax);
		}

		// Token: 0x06008695 RID: 34453 RVA: 0x0026AE10 File Offset: 0x00269010
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
					this.m_PrepareBattleConfigDataBattlefieldInfo_hotfix = (luaObj.RawGet("PrepareBattle") as LuaFunction);
					this.m_StartBattle_hotfix = (luaObj.RawGet("StartBattle") as LuaFunction);
					this.m_SetOrthographicSizeSingle_hotfix = (luaObj.RawGet("SetOrthographicSize") as LuaFunction);
					this.m_EnableTouchMoveBoolean_hotfix = (luaObj.RawGet("EnableTouchMove") as LuaFunction);
					this.m_EnableTouchMove2Boolean_hotfix = (luaObj.RawGet("EnableTouchMove2") as LuaFunction);
					this.m_UpdateEnableTouchMove_hotfix = (luaObj.RawGet("UpdateEnableTouchMove") as LuaFunction);
					this.m_UpdateSingle_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_IsTouchUIVector2_hotfix = (luaObj.RawGet("IsTouchUI") as LuaFunction);
					this.m_UpdateTouchSingle_hotfix = (luaObj.RawGet("UpdateTouch") as LuaFunction);
					this.m_ClampCameraPositionVector2_hotfix = (luaObj.RawGet("ClampCameraPosition") as LuaFunction);
					this.m_ComputeBoundPositionVector2_hotfix = (luaObj.RawGet("ComputeBoundPosition") as LuaFunction);
					this.m_LookVector2_hotfix = (luaObj.RawGet("Look") as LuaFunction);
					this.m_SmoothLookVector2_hotfix = (luaObj.RawGet("SmoothLook") as LuaFunction);
					this.m_IsSmoothMoving_hotfix = (luaObj.RawGet("IsSmoothMoving") as LuaFunction);
					this.m_BoundVector2SingleInt32_hotfix = (luaObj.RawGet("Bound") as LuaFunction);
					this.m_GetPosition_hotfix = (luaObj.RawGet("GetPosition") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008696 RID: 34454 RVA: 0x0026B084 File Offset: 0x00269284
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleCamera));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005F8B RID: 24459
		private Vector2 m_position;

		// Token: 0x04005F8C RID: 24460
		private Vector2 m_smoothMoveStartPosition;

		// Token: 0x04005F8D RID: 24461
		private Vector2 m_smoothMoveEndPosition;

		// Token: 0x04005F8E RID: 24462
		private Vector2 m_touchMoveVelocity;

		// Token: 0x04005F8F RID: 24463
		private bool m_enableTouchMove = true;

		// Token: 0x04005F90 RID: 24464
		private bool m_enableTouchMove2 = true;

		// Token: 0x04005F91 RID: 24465
		private float m_smoothMoveTime;

		// Token: 0x04005F92 RID: 24466
		private float m_smoothMoveTotalTime;

		// Token: 0x04005F93 RID: 24467
		private EventSystem m_eventSystem;

		// Token: 0x04005F94 RID: 24468
		private PointerEventData m_pointData;

		// Token: 0x04005F95 RID: 24469
		private List<RaycastResult> m_raycastResults;

		// Token: 0x04005F96 RID: 24470
		private TouchStatus[] m_touchStatus;

		// Token: 0x04005F97 RID: 24471
		private Vector3 m_initPosition;

		// Token: 0x04005F98 RID: 24472
		private Vector2 m_mapSizeHalf;

		// Token: 0x04005F99 RID: 24473
		private float m_viewSizeMin;

		// Token: 0x04005F9A RID: 24474
		private float m_viewSizeMax;

		// Token: 0x04005F9B RID: 24475
		[DoNotToLua]
		private BattleCamera.LuaExportHelper luaExportHelper;

		// Token: 0x04005F9C RID: 24476
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005F9D RID: 24477
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005F9E RID: 24478
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005F9F RID: 24479
		private LuaFunction m_InitializeGameObject_hotfix;

		// Token: 0x04005FA0 RID: 24480
		private LuaFunction m_PrepareBattleConfigDataBattlefieldInfo_hotfix;

		// Token: 0x04005FA1 RID: 24481
		private LuaFunction m_StartBattle_hotfix;

		// Token: 0x04005FA2 RID: 24482
		private LuaFunction m_SetOrthographicSizeSingle_hotfix;

		// Token: 0x04005FA3 RID: 24483
		private LuaFunction m_EnableTouchMoveBoolean_hotfix;

		// Token: 0x04005FA4 RID: 24484
		private LuaFunction m_EnableTouchMove2Boolean_hotfix;

		// Token: 0x04005FA5 RID: 24485
		private LuaFunction m_UpdateEnableTouchMove_hotfix;

		// Token: 0x04005FA6 RID: 24486
		private LuaFunction m_UpdateSingle_hotfix;

		// Token: 0x04005FA7 RID: 24487
		private LuaFunction m_IsTouchUIVector2_hotfix;

		// Token: 0x04005FA8 RID: 24488
		private LuaFunction m_UpdateTouchSingle_hotfix;

		// Token: 0x04005FA9 RID: 24489
		private LuaFunction m_ClampCameraPositionVector2_hotfix;

		// Token: 0x04005FAA RID: 24490
		private LuaFunction m_ComputeBoundPositionVector2_hotfix;

		// Token: 0x04005FAB RID: 24491
		private LuaFunction m_LookVector2_hotfix;

		// Token: 0x04005FAC RID: 24492
		private LuaFunction m_SmoothLookVector2_hotfix;

		// Token: 0x04005FAD RID: 24493
		private LuaFunction m_IsSmoothMoving_hotfix;

		// Token: 0x04005FAE RID: 24494
		private LuaFunction m_BoundVector2SingleInt32_hotfix;

		// Token: 0x04005FAF RID: 24495
		private LuaFunction m_GetPosition_hotfix;

		// Token: 0x02000919 RID: 2329
		public new class LuaExportHelper
		{
			// Token: 0x06008697 RID: 34455 RVA: 0x0026B0EC File Offset: 0x002692EC
			public LuaExportHelper(BattleCamera owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008698 RID: 34456 RVA: 0x0026B0FC File Offset: 0x002692FC
			public void __callBase_Initialize(GameObject cameraGo, GameObject animatorGo)
			{
				this.m_owner.__callBase_Initialize(cameraGo, animatorGo);
			}

			// Token: 0x06008699 RID: 34457 RVA: 0x0026B10C File Offset: 0x0026930C
			public void __callBase_GetViewSize(out float width, out float height)
			{
				this.m_owner.__callBase_GetViewSize(out width, out height);
			}

			// Token: 0x0600869A RID: 34458 RVA: 0x0026B11C File Offset: 0x0026931C
			public void __callBase_PlayAnimation(string name)
			{
				this.m_owner.__callBase_PlayAnimation(name);
			}

			// Token: 0x0600869B RID: 34459 RVA: 0x0026B12C File Offset: 0x0026932C
			public Vector3 __callBase_GetAnimationOffset()
			{
				return this.m_owner.__callBase_GetAnimationOffset();
			}

			// Token: 0x0600869C RID: 34460 RVA: 0x0026B13C File Offset: 0x0026933C
			public bool __callBase_IsCulled(Vector2 p)
			{
				return this.m_owner.__callBase_IsCulled(p);
			}

			// Token: 0x0600869D RID: 34461 RVA: 0x0026B14C File Offset: 0x0026934C
			public bool __callBase_IsCulled(Vector2 bmin, Vector2 bmax)
			{
				return this.m_owner.__callBase_IsCulled(bmin, bmax);
			}

			// Token: 0x17001C54 RID: 7252
			// (get) Token: 0x0600869E RID: 34462 RVA: 0x0026B15C File Offset: 0x0026935C
			// (set) Token: 0x0600869F RID: 34463 RVA: 0x0026B16C File Offset: 0x0026936C
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

			// Token: 0x17001C55 RID: 7253
			// (get) Token: 0x060086A0 RID: 34464 RVA: 0x0026B17C File Offset: 0x0026937C
			// (set) Token: 0x060086A1 RID: 34465 RVA: 0x0026B18C File Offset: 0x0026938C
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

			// Token: 0x17001C56 RID: 7254
			// (get) Token: 0x060086A2 RID: 34466 RVA: 0x0026B19C File Offset: 0x0026939C
			// (set) Token: 0x060086A3 RID: 34467 RVA: 0x0026B1AC File Offset: 0x002693AC
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

			// Token: 0x17001C57 RID: 7255
			// (get) Token: 0x060086A4 RID: 34468 RVA: 0x0026B1BC File Offset: 0x002693BC
			// (set) Token: 0x060086A5 RID: 34469 RVA: 0x0026B1CC File Offset: 0x002693CC
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

			// Token: 0x17001C58 RID: 7256
			// (get) Token: 0x060086A6 RID: 34470 RVA: 0x0026B1DC File Offset: 0x002693DC
			// (set) Token: 0x060086A7 RID: 34471 RVA: 0x0026B1EC File Offset: 0x002693EC
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

			// Token: 0x17001C59 RID: 7257
			// (get) Token: 0x060086A8 RID: 34472 RVA: 0x0026B1FC File Offset: 0x002693FC
			// (set) Token: 0x060086A9 RID: 34473 RVA: 0x0026B20C File Offset: 0x0026940C
			public bool m_enableTouchMove2
			{
				get
				{
					return this.m_owner.m_enableTouchMove2;
				}
				set
				{
					this.m_owner.m_enableTouchMove2 = value;
				}
			}

			// Token: 0x17001C5A RID: 7258
			// (get) Token: 0x060086AA RID: 34474 RVA: 0x0026B21C File Offset: 0x0026941C
			// (set) Token: 0x060086AB RID: 34475 RVA: 0x0026B22C File Offset: 0x0026942C
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

			// Token: 0x17001C5B RID: 7259
			// (get) Token: 0x060086AC RID: 34476 RVA: 0x0026B23C File Offset: 0x0026943C
			// (set) Token: 0x060086AD RID: 34477 RVA: 0x0026B24C File Offset: 0x0026944C
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

			// Token: 0x17001C5C RID: 7260
			// (get) Token: 0x060086AE RID: 34478 RVA: 0x0026B25C File Offset: 0x0026945C
			// (set) Token: 0x060086AF RID: 34479 RVA: 0x0026B26C File Offset: 0x0026946C
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

			// Token: 0x17001C5D RID: 7261
			// (get) Token: 0x060086B0 RID: 34480 RVA: 0x0026B27C File Offset: 0x0026947C
			// (set) Token: 0x060086B1 RID: 34481 RVA: 0x0026B28C File Offset: 0x0026948C
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

			// Token: 0x17001C5E RID: 7262
			// (get) Token: 0x060086B2 RID: 34482 RVA: 0x0026B29C File Offset: 0x0026949C
			// (set) Token: 0x060086B3 RID: 34483 RVA: 0x0026B2AC File Offset: 0x002694AC
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

			// Token: 0x17001C5F RID: 7263
			// (get) Token: 0x060086B4 RID: 34484 RVA: 0x0026B2BC File Offset: 0x002694BC
			// (set) Token: 0x060086B5 RID: 34485 RVA: 0x0026B2CC File Offset: 0x002694CC
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

			// Token: 0x17001C60 RID: 7264
			// (get) Token: 0x060086B6 RID: 34486 RVA: 0x0026B2DC File Offset: 0x002694DC
			// (set) Token: 0x060086B7 RID: 34487 RVA: 0x0026B2EC File Offset: 0x002694EC
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

			// Token: 0x17001C61 RID: 7265
			// (get) Token: 0x060086B8 RID: 34488 RVA: 0x0026B2FC File Offset: 0x002694FC
			// (set) Token: 0x060086B9 RID: 34489 RVA: 0x0026B30C File Offset: 0x0026950C
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

			// Token: 0x17001C62 RID: 7266
			// (get) Token: 0x060086BA RID: 34490 RVA: 0x0026B31C File Offset: 0x0026951C
			// (set) Token: 0x060086BB RID: 34491 RVA: 0x0026B32C File Offset: 0x0026952C
			public float m_viewSizeMin
			{
				get
				{
					return this.m_owner.m_viewSizeMin;
				}
				set
				{
					this.m_owner.m_viewSizeMin = value;
				}
			}

			// Token: 0x17001C63 RID: 7267
			// (get) Token: 0x060086BC RID: 34492 RVA: 0x0026B33C File Offset: 0x0026953C
			// (set) Token: 0x060086BD RID: 34493 RVA: 0x0026B34C File Offset: 0x0026954C
			public float m_viewSizeMax
			{
				get
				{
					return this.m_owner.m_viewSizeMax;
				}
				set
				{
					this.m_owner.m_viewSizeMax = value;
				}
			}

			// Token: 0x060086BE RID: 34494 RVA: 0x0026B35C File Offset: 0x0026955C
			public void UpdateEnableTouchMove()
			{
				this.m_owner.UpdateEnableTouchMove();
			}

			// Token: 0x060086BF RID: 34495 RVA: 0x0026B36C File Offset: 0x0026956C
			public static Vector2 ScreenPositionToViewPosition(Vector2 p, float viewWidth, float viewHeight)
			{
				return BattleCamera.ScreenPositionToViewPosition(p, viewWidth, viewHeight);
			}

			// Token: 0x060086C0 RID: 34496 RVA: 0x0026B378 File Offset: 0x00269578
			public bool IsTouchUI(Vector2 pos)
			{
				return this.m_owner.IsTouchUI(pos);
			}

			// Token: 0x060086C1 RID: 34497 RVA: 0x0026B388 File Offset: 0x00269588
			public void UpdateTouch(float dt)
			{
				this.m_owner.UpdateTouch(dt);
			}

			// Token: 0x060086C2 RID: 34498 RVA: 0x0026B398 File Offset: 0x00269598
			public Vector2 ClampCameraPosition(Vector2 p)
			{
				return this.m_owner.ClampCameraPosition(p);
			}

			// Token: 0x060086C3 RID: 34499 RVA: 0x0026B3A8 File Offset: 0x002695A8
			public Vector2 ComputeBoundPosition(Vector2 p)
			{
				return this.m_owner.ComputeBoundPosition(p);
			}

			// Token: 0x04005FB0 RID: 24496
			private BattleCamera m_owner;
		}
	}
}
