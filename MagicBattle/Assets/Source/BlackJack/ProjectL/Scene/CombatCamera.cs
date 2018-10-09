using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200096E RID: 2414
	[HotFix]
	public class CombatCamera : CameraBase
	{
		// Token: 0x060089F2 RID: 35314 RVA: 0x002828AC File Offset: 0x00280AAC
		public CombatCamera()
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

		// Token: 0x060089F3 RID: 35315 RVA: 0x00282914 File Offset: 0x00280B14
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
			GameObject cameraGo = Utility.FindChildGameObject(go, "0", true);
			GameObject animatorGo = Utility.FindChildGameObject(go, "Animation", true);
			base.Initialize(cameraGo, animatorGo);
			this.m_gameObject = go;
			this.m_initPosition = go.transform.localPosition;
			this.m_camera1 = Utility.FindChildComponent<Camera>(go, "1", true);
			this.m_camera2 = Utility.FindChildComponent<Camera>(go, "2", true);
			this.m_initOrthographicSize = this.m_camera.orthographicSize;
			this.m_initSplitScreenOrthographicSize = this.m_camera1.orthographicSize;
			this.m_camera.orthographicSize = this.m_initOrthographicSize * CameraBase.AspectScale();
			Camera camera = this.m_camera1;
			float orthographicSize = this.m_initSplitScreenOrthographicSize * CameraBase.AspectScale();
			this.m_camera2.orthographicSize = orthographicSize;
			camera.orthographicSize = orthographicSize;
		}

		// Token: 0x060089F4 RID: 35316 RVA: 0x00282A40 File Offset: 0x00280C40
		public void StartCombat(bool splitScreen)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartCombatBoolean_hotfix != null)
			{
				this.m_StartCombatBoolean_hotfix.call(new object[]
				{
					this,
					splitScreen
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_gameObject.transform.localPosition = this.m_initPosition;
			this.m_camera.gameObject.SetActive(!splitScreen);
			this.m_camera1.gameObject.SetActive(splitScreen);
			this.m_camera2.gameObject.SetActive(splitScreen);
			this.m_camera.orthographicSize = this.m_initOrthographicSize * CameraBase.AspectScale();
			Camera camera = this.m_camera1;
			float orthographicSize = this.m_initSplitScreenOrthographicSize * CameraBase.AspectScale();
			this.m_camera2.orthographicSize = orthographicSize;
			camera.orthographicSize = orthographicSize;
			this.m_isSplitScreen = splitScreen;
		}

		// Token: 0x060089F5 RID: 35317 RVA: 0x00282B40 File Offset: 0x00280D40
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
			this.m_gameObject.transform.localPosition = this.m_initPosition + base.GetAnimationOffset();
		}

		// Token: 0x060089F6 RID: 35318 RVA: 0x00282BD4 File Offset: 0x00280DD4
		public override bool IsCulled(Vector2 p)
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
			if (this.m_isSplitScreen)
			{
				return CameraBase.IsCulled(this.m_camera1, p) && CameraBase.IsCulled(this.m_camera2, p);
			}
			return base.IsCulled(p);
		}

		// Token: 0x060089F7 RID: 35319 RVA: 0x00282C84 File Offset: 0x00280E84
		public override bool IsCulled(Vector2 bmin, Vector2 bmax)
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
			if (this.m_isSplitScreen)
			{
				return CameraBase.IsCulled(this.m_camera1, bmin, bmax) && CameraBase.IsCulled(this.m_camera2, bmin, bmax);
			}
			return base.IsCulled(bmin, bmax);
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x060089F8 RID: 35320 RVA: 0x00282D48 File Offset: 0x00280F48
		// (set) Token: 0x060089F9 RID: 35321 RVA: 0x00282D68 File Offset: 0x00280F68
		[DoNotToLua]
		public new CombatCamera.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CombatCamera.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060089FA RID: 35322 RVA: 0x00282D74 File Offset: 0x00280F74
		private void __callBase_Initialize(GameObject cameraGo, GameObject animatorGo)
		{
			base.Initialize(cameraGo, animatorGo);
		}

		// Token: 0x060089FB RID: 35323 RVA: 0x00282D80 File Offset: 0x00280F80
		private void __callBase_GetViewSize(out float width, out float height)
		{
			base.GetViewSize(out width, out height);
		}

		// Token: 0x060089FC RID: 35324 RVA: 0x00282D8C File Offset: 0x00280F8C
		private void __callBase_PlayAnimation(string name)
		{
			base.PlayAnimation(name);
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x00282D98 File Offset: 0x00280F98
		private Vector3 __callBase_GetAnimationOffset()
		{
			return base.GetAnimationOffset();
		}

		// Token: 0x060089FE RID: 35326 RVA: 0x00282DA0 File Offset: 0x00280FA0
		private bool __callBase_IsCulled(Vector2 p)
		{
			return base.IsCulled(p);
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x00282DAC File Offset: 0x00280FAC
		private bool __callBase_IsCulled(Vector2 bmin, Vector2 bmax)
		{
			return base.IsCulled(bmin, bmax);
		}

		// Token: 0x06008A00 RID: 35328 RVA: 0x00282DB8 File Offset: 0x00280FB8
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
					this.m_StartCombatBoolean_hotfix = (luaObj.RawGet("StartCombat") as LuaFunction);
					this.m_UpdateSingle_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_IsCulledVector2_hotfix = (luaObj.RawGet("IsCulled") as LuaFunction);
					this.m_IsCulledVector2Vector2_hotfix = (luaObj.RawGet("IsCulled") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008A01 RID: 35329 RVA: 0x00282F00 File Offset: 0x00281100
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CombatCamera));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006272 RID: 25202
		private bool m_isSplitScreen;

		// Token: 0x04006273 RID: 25203
		private GameObject m_gameObject;

		// Token: 0x04006274 RID: 25204
		private Camera m_camera1;

		// Token: 0x04006275 RID: 25205
		private Camera m_camera2;

		// Token: 0x04006276 RID: 25206
		private Vector3 m_initPosition;

		// Token: 0x04006277 RID: 25207
		private float m_initOrthographicSize;

		// Token: 0x04006278 RID: 25208
		private float m_initSplitScreenOrthographicSize;

		// Token: 0x04006279 RID: 25209
		[DoNotToLua]
		private CombatCamera.LuaExportHelper luaExportHelper;

		// Token: 0x0400627A RID: 25210
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400627B RID: 25211
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400627C RID: 25212
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400627D RID: 25213
		private LuaFunction m_InitializeGameObject_hotfix;

		// Token: 0x0400627E RID: 25214
		private LuaFunction m_StartCombatBoolean_hotfix;

		// Token: 0x0400627F RID: 25215
		private LuaFunction m_UpdateSingle_hotfix;

		// Token: 0x04006280 RID: 25216
		private LuaFunction m_IsCulledVector2_hotfix;

		// Token: 0x04006281 RID: 25217
		private LuaFunction m_IsCulledVector2Vector2_hotfix;

		// Token: 0x0200096F RID: 2415
		public new class LuaExportHelper
		{
			// Token: 0x06008A02 RID: 35330 RVA: 0x00282F68 File Offset: 0x00281168
			public LuaExportHelper(CombatCamera owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008A03 RID: 35331 RVA: 0x00282F78 File Offset: 0x00281178
			public void __callBase_Initialize(GameObject cameraGo, GameObject animatorGo)
			{
				this.m_owner.__callBase_Initialize(cameraGo, animatorGo);
			}

			// Token: 0x06008A04 RID: 35332 RVA: 0x00282F88 File Offset: 0x00281188
			public void __callBase_GetViewSize(out float width, out float height)
			{
				this.m_owner.__callBase_GetViewSize(out width, out height);
			}

			// Token: 0x06008A05 RID: 35333 RVA: 0x00282F98 File Offset: 0x00281198
			public void __callBase_PlayAnimation(string name)
			{
				this.m_owner.__callBase_PlayAnimation(name);
			}

			// Token: 0x06008A06 RID: 35334 RVA: 0x00282FA8 File Offset: 0x002811A8
			public Vector3 __callBase_GetAnimationOffset()
			{
				return this.m_owner.__callBase_GetAnimationOffset();
			}

			// Token: 0x06008A07 RID: 35335 RVA: 0x00282FB8 File Offset: 0x002811B8
			public bool __callBase_IsCulled(Vector2 p)
			{
				return this.m_owner.__callBase_IsCulled(p);
			}

			// Token: 0x06008A08 RID: 35336 RVA: 0x00282FC8 File Offset: 0x002811C8
			public bool __callBase_IsCulled(Vector2 bmin, Vector2 bmax)
			{
				return this.m_owner.__callBase_IsCulled(bmin, bmax);
			}

			// Token: 0x17001CF0 RID: 7408
			// (get) Token: 0x06008A09 RID: 35337 RVA: 0x00282FD8 File Offset: 0x002811D8
			// (set) Token: 0x06008A0A RID: 35338 RVA: 0x00282FE8 File Offset: 0x002811E8
			public bool m_isSplitScreen
			{
				get
				{
					return this.m_owner.m_isSplitScreen;
				}
				set
				{
					this.m_owner.m_isSplitScreen = value;
				}
			}

			// Token: 0x17001CF1 RID: 7409
			// (get) Token: 0x06008A0B RID: 35339 RVA: 0x00282FF8 File Offset: 0x002811F8
			// (set) Token: 0x06008A0C RID: 35340 RVA: 0x00283008 File Offset: 0x00281208
			public GameObject m_gameObject
			{
				get
				{
					return this.m_owner.m_gameObject;
				}
				set
				{
					this.m_owner.m_gameObject = value;
				}
			}

			// Token: 0x17001CF2 RID: 7410
			// (get) Token: 0x06008A0D RID: 35341 RVA: 0x00283018 File Offset: 0x00281218
			// (set) Token: 0x06008A0E RID: 35342 RVA: 0x00283028 File Offset: 0x00281228
			public Camera m_camera1
			{
				get
				{
					return this.m_owner.m_camera1;
				}
				set
				{
					this.m_owner.m_camera1 = value;
				}
			}

			// Token: 0x17001CF3 RID: 7411
			// (get) Token: 0x06008A0F RID: 35343 RVA: 0x00283038 File Offset: 0x00281238
			// (set) Token: 0x06008A10 RID: 35344 RVA: 0x00283048 File Offset: 0x00281248
			public Camera m_camera2
			{
				get
				{
					return this.m_owner.m_camera2;
				}
				set
				{
					this.m_owner.m_camera2 = value;
				}
			}

			// Token: 0x17001CF4 RID: 7412
			// (get) Token: 0x06008A11 RID: 35345 RVA: 0x00283058 File Offset: 0x00281258
			// (set) Token: 0x06008A12 RID: 35346 RVA: 0x00283068 File Offset: 0x00281268
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

			// Token: 0x17001CF5 RID: 7413
			// (get) Token: 0x06008A13 RID: 35347 RVA: 0x00283078 File Offset: 0x00281278
			// (set) Token: 0x06008A14 RID: 35348 RVA: 0x00283088 File Offset: 0x00281288
			public float m_initOrthographicSize
			{
				get
				{
					return this.m_owner.m_initOrthographicSize;
				}
				set
				{
					this.m_owner.m_initOrthographicSize = value;
				}
			}

			// Token: 0x17001CF6 RID: 7414
			// (get) Token: 0x06008A15 RID: 35349 RVA: 0x00283098 File Offset: 0x00281298
			// (set) Token: 0x06008A16 RID: 35350 RVA: 0x002830A8 File Offset: 0x002812A8
			public float m_initSplitScreenOrthographicSize
			{
				get
				{
					return this.m_owner.m_initSplitScreenOrthographicSize;
				}
				set
				{
					this.m_owner.m_initSplitScreenOrthographicSize = value;
				}
			}

			// Token: 0x04006282 RID: 25218
			private CombatCamera m_owner;
		}
	}
}
