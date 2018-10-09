using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000973 RID: 2419
	[HotFix]
	public class CutsceneCamera : CameraBase
	{
		// Token: 0x06008A5D RID: 35421 RVA: 0x0028397C File Offset: 0x00281B7C
		public CutsceneCamera()
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

		// Token: 0x06008A5E RID: 35422 RVA: 0x002839E4 File Offset: 0x00281BE4
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
			this.m_clipAnimator = go.GetComponent<Animator>();
			this.m_initOrthographicSize = this.m_camera.orthographicSize;
			this.m_camera.orthographicSize = this.m_initOrthographicSize * CameraBase.AspectScale();
		}

		// Token: 0x06008A5F RID: 35423 RVA: 0x00283A9C File Offset: 0x00281C9C
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
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x00283B0C File Offset: 0x00281D0C
		public void StartCutscene()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartCutscene_hotfix != null)
			{
				this.m_StartCutscene_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_camera.orthographicSize = this.m_initOrthographicSize * CameraBase.AspectScale();
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x00283B84 File Offset: 0x00281D84
		public void StopCutscene()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopCutscene_hotfix != null)
			{
				this.m_StopCutscene_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x00283BE4 File Offset: 0x00281DE4
		public void PlayClipAnimation(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayClipAnimationString_hotfix != null)
			{
				this.m_PlayClipAnimationString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clipAnimator != null)
			{
				this.m_clipAnimator.Play(name, -1, 0f);
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06008A63 RID: 35427 RVA: 0x00283C78 File Offset: 0x00281E78
		// (set) Token: 0x06008A64 RID: 35428 RVA: 0x00283C98 File Offset: 0x00281E98
		[DoNotToLua]
		public new CutsceneCamera.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CutsceneCamera.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008A65 RID: 35429 RVA: 0x00283CA4 File Offset: 0x00281EA4
		private void __callBase_Initialize(GameObject cameraGo, GameObject animatorGo)
		{
			base.Initialize(cameraGo, animatorGo);
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x00283CB0 File Offset: 0x00281EB0
		private void __callBase_GetViewSize(out float width, out float height)
		{
			base.GetViewSize(out width, out height);
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x00283CBC File Offset: 0x00281EBC
		private void __callBase_PlayAnimation(string name)
		{
			base.PlayAnimation(name);
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x00283CC8 File Offset: 0x00281EC8
		private Vector3 __callBase_GetAnimationOffset()
		{
			return base.GetAnimationOffset();
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x00283CD0 File Offset: 0x00281ED0
		private bool __callBase_IsCulled(Vector2 p)
		{
			return base.IsCulled(p);
		}

		// Token: 0x06008A6A RID: 35434 RVA: 0x00283CDC File Offset: 0x00281EDC
		private bool __callBase_IsCulled(Vector2 bmin, Vector2 bmax)
		{
			return base.IsCulled(bmin, bmax);
		}

		// Token: 0x06008A6B RID: 35435 RVA: 0x00283CE8 File Offset: 0x00281EE8
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
					this.m_UpdateSingle_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_StartCutscene_hotfix = (luaObj.RawGet("StartCutscene") as LuaFunction);
					this.m_StopCutscene_hotfix = (luaObj.RawGet("StopCutscene") as LuaFunction);
					this.m_PlayClipAnimationString_hotfix = (luaObj.RawGet("PlayClipAnimation") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008A6C RID: 35436 RVA: 0x00283E30 File Offset: 0x00282030
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CutsceneCamera));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006293 RID: 25235
		private Animator m_clipAnimator;

		// Token: 0x04006294 RID: 25236
		private float m_initOrthographicSize;

		// Token: 0x04006295 RID: 25237
		[DoNotToLua]
		private CutsceneCamera.LuaExportHelper luaExportHelper;

		// Token: 0x04006296 RID: 25238
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006297 RID: 25239
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006298 RID: 25240
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04006299 RID: 25241
		private LuaFunction m_InitializeGameObject_hotfix;

		// Token: 0x0400629A RID: 25242
		private LuaFunction m_UpdateSingle_hotfix;

		// Token: 0x0400629B RID: 25243
		private LuaFunction m_StartCutscene_hotfix;

		// Token: 0x0400629C RID: 25244
		private LuaFunction m_StopCutscene_hotfix;

		// Token: 0x0400629D RID: 25245
		private LuaFunction m_PlayClipAnimationString_hotfix;

		// Token: 0x02000974 RID: 2420
		public new class LuaExportHelper
		{
			// Token: 0x06008A6D RID: 35437 RVA: 0x00283E98 File Offset: 0x00282098
			public LuaExportHelper(CutsceneCamera owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008A6E RID: 35438 RVA: 0x00283EA8 File Offset: 0x002820A8
			public void __callBase_Initialize(GameObject cameraGo, GameObject animatorGo)
			{
				this.m_owner.__callBase_Initialize(cameraGo, animatorGo);
			}

			// Token: 0x06008A6F RID: 35439 RVA: 0x00283EB8 File Offset: 0x002820B8
			public void __callBase_GetViewSize(out float width, out float height)
			{
				this.m_owner.__callBase_GetViewSize(out width, out height);
			}

			// Token: 0x06008A70 RID: 35440 RVA: 0x00283EC8 File Offset: 0x002820C8
			public void __callBase_PlayAnimation(string name)
			{
				this.m_owner.__callBase_PlayAnimation(name);
			}

			// Token: 0x06008A71 RID: 35441 RVA: 0x00283ED8 File Offset: 0x002820D8
			public Vector3 __callBase_GetAnimationOffset()
			{
				return this.m_owner.__callBase_GetAnimationOffset();
			}

			// Token: 0x06008A72 RID: 35442 RVA: 0x00283EE8 File Offset: 0x002820E8
			public bool __callBase_IsCulled(Vector2 p)
			{
				return this.m_owner.__callBase_IsCulled(p);
			}

			// Token: 0x06008A73 RID: 35443 RVA: 0x00283EF8 File Offset: 0x002820F8
			public bool __callBase_IsCulled(Vector2 bmin, Vector2 bmax)
			{
				return this.m_owner.__callBase_IsCulled(bmin, bmax);
			}

			// Token: 0x17001CFE RID: 7422
			// (get) Token: 0x06008A74 RID: 35444 RVA: 0x00283F08 File Offset: 0x00282108
			// (set) Token: 0x06008A75 RID: 35445 RVA: 0x00283F18 File Offset: 0x00282118
			public Animator m_clipAnimator
			{
				get
				{
					return this.m_owner.m_clipAnimator;
				}
				set
				{
					this.m_owner.m_clipAnimator = value;
				}
			}

			// Token: 0x17001CFF RID: 7423
			// (get) Token: 0x06008A76 RID: 35446 RVA: 0x00283F28 File Offset: 0x00282128
			// (set) Token: 0x06008A77 RID: 35447 RVA: 0x00283F38 File Offset: 0x00282138
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

			// Token: 0x0400629E RID: 25246
			private CutsceneCamera m_owner;
		}
	}
}
