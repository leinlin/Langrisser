using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000971 RID: 2417
	[HotFix]
	public class CameraBase
	{
		// Token: 0x06008A42 RID: 35394 RVA: 0x002830B8 File Offset: 0x002812B8
		public CameraBase()
		{
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

		// Token: 0x06008A43 RID: 35395 RVA: 0x00283120 File Offset: 0x00281320
		protected void Initialize(GameObject cameraGo, GameObject animatorGo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeGameObjectGameObject_hotfix != null)
			{
				this.m_InitializeGameObjectGameObject_hotfix.call(new object[]
				{
					this,
					cameraGo,
					animatorGo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (cameraGo == null)
			{
				return;
			}
			this.m_camera = cameraGo.GetComponent<Camera>();
			this.m_animationGameObject = animatorGo;
			if (this.m_animationGameObject != null)
			{
				this.m_animator = this.m_animationGameObject.GetComponent<Animator>();
			}
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x002831E4 File Offset: 0x002813E4
		public void GetViewSize(out float width, out float height)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetViewSizeSingle_Single__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Scene_CameraBase_GetViewSize_Single_Single(this, this.m_GetViewSizeSingle_Single__hotfix, out width, out height);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CameraBase.GetViewSize(this.m_camera, out width, out height);
		}

		// Token: 0x06008A45 RID: 35397 RVA: 0x00283248 File Offset: 0x00281448
		public void PlayAnimation(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationString_hotfix != null)
			{
				this.m_PlayAnimationString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (this.m_animator != null)
			{
				this.m_animator.Play(name, -1, 0f);
				this.m_animator.Update(0f);
				this.m_isPlayAnimation = true;
			}
		}

		// Token: 0x06008A46 RID: 35398 RVA: 0x00283300 File Offset: 0x00281500
		protected Vector3 GetAnimationOffset()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAnimationOffset_hotfix != null)
			{
				return (Vector3)this.m_GetAnimationOffset_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_animator == null)
			{
				return Vector3.zero;
			}
			if (!this.m_isPlayAnimation)
			{
				return Vector3.zero;
			}
			if (this.m_animator.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1f)
			{
				return this.m_animationGameObject.transform.localPosition;
			}
			this.m_isPlayAnimation = false;
			return Vector3.zero;
		}

		// Token: 0x06008A47 RID: 35399 RVA: 0x002833D0 File Offset: 0x002815D0
		public virtual bool IsCulled(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCulledVector2_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCulledVector2_hotfix.call(new object[]
				{
					this,
					p
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return CameraBase.IsCulled(this.m_camera, p);
		}

		// Token: 0x06008A48 RID: 35400 RVA: 0x00283458 File Offset: 0x00281658
		public virtual bool IsCulled(Vector2 bmin, Vector2 bmax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCulledVector2Vector2_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCulledVector2Vector2_hotfix.call(new object[]
				{
					this,
					bmin,
					bmax
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return CameraBase.IsCulled(this.m_camera, bmin, bmax);
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x002834F4 File Offset: 0x002816F4
		public static void GetViewSize(Camera cam, out float width, out float height)
		{
			if (cam == null)
			{
				width = (height = 0f);
				return;
			}
			width = cam.orthographicSize * 2f * cam.aspect;
			height = cam.orthographicSize * 2f;
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x00283540 File Offset: 0x00281740
		public static bool IsCulled(Camera cam, Vector2 p)
		{
			if (cam == null)
			{
				return false;
			}
			Vector3 vector = cam.WorldToViewportPoint(p);
			return vector.x < 0f || vector.x > 1f || vector.y < 0f || vector.y > 1f;
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x002835AC File Offset: 0x002817AC
		public static bool IsCulled(Camera cam, Vector2 bmin, Vector2 bmax)
		{
			if (cam == null)
			{
				return false;
			}
			Vector3 vector = cam.WorldToViewportPoint(bmin);
			Vector3 vector2 = cam.WorldToViewportPoint(bmax);
			return vector2.x < 0f || vector.x > 1f || vector2.y < 0f || vector.y > 1f;
		}

		// Token: 0x06008A4C RID: 35404 RVA: 0x00283628 File Offset: 0x00281828
		public static float AspectScale()
		{
			return Math.Max(1.77777779f / ((float)Screen.width / (float)Screen.height), 1f);
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x06008A4D RID: 35405 RVA: 0x00283648 File Offset: 0x00281848
		public Camera Camera
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Camera_hotfix != null)
				{
					return (Camera)this.m_get_Camera_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_camera;
			}
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06008A4E RID: 35406 RVA: 0x002836BC File Offset: 0x002818BC
		// (set) Token: 0x06008A4F RID: 35407 RVA: 0x002836DC File Offset: 0x002818DC
		[DoNotToLua]
		public CameraBase.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CameraBase.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x002836E8 File Offset: 0x002818E8
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
					this.m_InitializeGameObjectGameObject_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_GetViewSizeSingle_Single__hotfix = (luaObj.RawGet("GetViewSize") as LuaFunction);
					this.m_PlayAnimationString_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_GetAnimationOffset_hotfix = (luaObj.RawGet("GetAnimationOffset") as LuaFunction);
					this.m_IsCulledVector2_hotfix = (luaObj.RawGet("IsCulled") as LuaFunction);
					this.m_IsCulledVector2Vector2_hotfix = (luaObj.RawGet("IsCulled") as LuaFunction);
					this.m_get_Camera_hotfix = (luaObj.RawGet("get_Camera") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x00283864 File Offset: 0x00281A64
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CameraBase));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006283 RID: 25219
		protected Camera m_camera;

		// Token: 0x04006284 RID: 25220
		protected Animator m_animator;

		// Token: 0x04006285 RID: 25221
		protected GameObject m_animationGameObject;

		// Token: 0x04006286 RID: 25222
		private bool m_isPlayAnimation;

		// Token: 0x04006287 RID: 25223
		[DoNotToLua]
		private CameraBase.LuaExportHelper luaExportHelper;

		// Token: 0x04006288 RID: 25224
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006289 RID: 25225
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400628A RID: 25226
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400628B RID: 25227
		private LuaFunction m_InitializeGameObjectGameObject_hotfix;

		// Token: 0x0400628C RID: 25228
		private LuaFunction m_GetViewSizeSingle_Single__hotfix;

		// Token: 0x0400628D RID: 25229
		private LuaFunction m_PlayAnimationString_hotfix;

		// Token: 0x0400628E RID: 25230
		private LuaFunction m_GetAnimationOffset_hotfix;

		// Token: 0x0400628F RID: 25231
		private LuaFunction m_IsCulledVector2_hotfix;

		// Token: 0x04006290 RID: 25232
		private LuaFunction m_IsCulledVector2Vector2_hotfix;

		// Token: 0x04006291 RID: 25233
		private LuaFunction m_get_Camera_hotfix;

		// Token: 0x02000972 RID: 2418
		public class LuaExportHelper
		{
			// Token: 0x06008A52 RID: 35410 RVA: 0x002838CC File Offset: 0x00281ACC
			public LuaExportHelper(CameraBase owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001CF9 RID: 7417
			// (get) Token: 0x06008A53 RID: 35411 RVA: 0x002838DC File Offset: 0x00281ADC
			// (set) Token: 0x06008A54 RID: 35412 RVA: 0x002838EC File Offset: 0x00281AEC
			public Camera m_camera
			{
				get
				{
					return this.m_owner.m_camera;
				}
				set
				{
					this.m_owner.m_camera = value;
				}
			}

			// Token: 0x17001CFA RID: 7418
			// (get) Token: 0x06008A55 RID: 35413 RVA: 0x002838FC File Offset: 0x00281AFC
			// (set) Token: 0x06008A56 RID: 35414 RVA: 0x0028390C File Offset: 0x00281B0C
			public Animator m_animator
			{
				get
				{
					return this.m_owner.m_animator;
				}
				set
				{
					this.m_owner.m_animator = value;
				}
			}

			// Token: 0x17001CFB RID: 7419
			// (get) Token: 0x06008A57 RID: 35415 RVA: 0x0028391C File Offset: 0x00281B1C
			// (set) Token: 0x06008A58 RID: 35416 RVA: 0x0028392C File Offset: 0x00281B2C
			public GameObject m_animationGameObject
			{
				get
				{
					return this.m_owner.m_animationGameObject;
				}
				set
				{
					this.m_owner.m_animationGameObject = value;
				}
			}

			// Token: 0x17001CFC RID: 7420
			// (get) Token: 0x06008A59 RID: 35417 RVA: 0x0028393C File Offset: 0x00281B3C
			// (set) Token: 0x06008A5A RID: 35418 RVA: 0x0028394C File Offset: 0x00281B4C
			public bool m_isPlayAnimation
			{
				get
				{
					return this.m_owner.m_isPlayAnimation;
				}
				set
				{
					this.m_owner.m_isPlayAnimation = value;
				}
			}

			// Token: 0x06008A5B RID: 35419 RVA: 0x0028395C File Offset: 0x00281B5C
			public void Initialize(GameObject cameraGo, GameObject animatorGo)
			{
				this.m_owner.Initialize(cameraGo, animatorGo);
			}

			// Token: 0x06008A5C RID: 35420 RVA: 0x0028396C File Offset: 0x00281B6C
			public Vector3 GetAnimationOffset()
			{
				return this.m_owner.GetAnimationOffset();
			}

			// Token: 0x04006292 RID: 25234
			private CameraBase m_owner;
		}
	}
}
