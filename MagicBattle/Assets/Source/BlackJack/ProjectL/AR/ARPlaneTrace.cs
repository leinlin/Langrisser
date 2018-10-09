using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.AR
{
	// Token: 0x02000B0E RID: 2830
	[HotFix]
	public class ARPlaneTrace
	{
		// Token: 0x0600BE65 RID: 48741 RVA: 0x00352BF0 File Offset: 0x00350DF0
		public ARPlaneTrace()
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

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x0600BE66 RID: 48742 RVA: 0x00352C6C File Offset: 0x00350E6C
		// (set) Token: 0x0600BE67 RID: 48743 RVA: 0x00352CE0 File Offset: 0x00350EE0
		public ARPlaneTrace.FocusState SquareState
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SquareState_hotfix != null)
				{
					return (ARPlaneTrace.FocusState)this.m_get_SquareState_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.squareState;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_SquareStateFocusState_hotfix != null)
				{
					this.m_set_SquareStateFocusState_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.squareState = value;
			}
		}

		// Token: 0x0600BE68 RID: 48744 RVA: 0x00352D58 File Offset: 0x00350F58
		public void Init(Camera camera)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitCamera_hotfix != null)
			{
				this.m_InitCamera_hotfix.call(new object[]
				{
					this,
					camera
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SquareState = ARPlaneTrace.FocusState.Initializing;
			this.trackingInitialized = true;
			this.camera = camera;
		}

		// Token: 0x0600BE69 RID: 48745 RVA: 0x00352DE0 File Offset: 0x00350FE0
		public void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3 position = new Vector3((float)(Screen.width / 2), (float)(Screen.height / 2), this.findingSquareDist);
			if (this.trackingInitialized)
			{
				this.SquareState = ARPlaneTrace.FocusState.Finding;
				if (Vector3.Dot(this.camera.transform.forward, Vector3.down) > 0f)
				{
					this.centerPos = this.camera.ScreenToWorldPoint(position);
					Vector3 lhs = this.centerPos - this.camera.transform.position;
					Vector3 lhs2 = Vector3.Cross(lhs, Vector3.up);
					Vector3 forward = Vector3.Cross(lhs2, Vector3.up);
					this.centerRotation = Quaternion.LookRotation(forward, Vector3.up);
				}
			}
		}

		// Token: 0x0600BE6A RID: 48746 RVA: 0x00352EEC File Offset: 0x003510EC
		private Quaternion CalculateLookVector(Vector3 srcPos, Vector3 destPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalculateLookVectorVector3Vector3_hotfix != null)
			{
				return (Quaternion)this.m_CalculateLookVectorVector3Vector3_hotfix.call(new object[]
				{
					this,
					srcPos,
					destPos
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3 lhs = srcPos - destPos;
			Vector3 lhs2 = Vector3.Cross(lhs, Vector3.up);
			Vector3 forward = Vector3.Cross(lhs2, Vector3.up);
			return Quaternion.LookRotation(forward, Vector3.up);
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x0600BE6B RID: 48747 RVA: 0x00352FA8 File Offset: 0x003511A8
		// (set) Token: 0x0600BE6C RID: 48748 RVA: 0x00352FC8 File Offset: 0x003511C8
		[DoNotToLua]
		public ARPlaneTrace.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ARPlaneTrace.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BE6D RID: 48749 RVA: 0x00352FD4 File Offset: 0x003511D4
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
					this.m_get_SquareState_hotfix = (luaObj.RawGet("get_SquareState") as LuaFunction);
					this.m_set_SquareStateFocusState_hotfix = (luaObj.RawGet("set_SquareState") as LuaFunction);
					this.m_InitCamera_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_CalculateLookVectorVector3Vector3_hotfix = (luaObj.RawGet("CalculateLookVector") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BE6E RID: 48750 RVA: 0x0035311C File Offset: 0x0035131C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ARPlaneTrace));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040079D9 RID: 31193
		public Vector3 centerPos;

		// Token: 0x040079DA RID: 31194
		public Quaternion centerRotation;

		// Token: 0x040079DB RID: 31195
		public Camera camera;

		// Token: 0x040079DC RID: 31196
		private float maxRayDistance = 30f;

		// Token: 0x040079DD RID: 31197
		private LayerMask collisionLayerMask;

		// Token: 0x040079DE RID: 31198
		private float findingSquareDist = 0.5f;

		// Token: 0x040079DF RID: 31199
		private ARPlaneTrace.FocusState squareState;

		// Token: 0x040079E0 RID: 31200
		private bool trackingInitialized;

		// Token: 0x040079E1 RID: 31201
		[DoNotToLua]
		private ARPlaneTrace.LuaExportHelper luaExportHelper;

		// Token: 0x040079E2 RID: 31202
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040079E3 RID: 31203
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040079E4 RID: 31204
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040079E5 RID: 31205
		private LuaFunction m_get_SquareState_hotfix;

		// Token: 0x040079E6 RID: 31206
		private LuaFunction m_set_SquareStateFocusState_hotfix;

		// Token: 0x040079E7 RID: 31207
		private LuaFunction m_InitCamera_hotfix;

		// Token: 0x040079E8 RID: 31208
		private LuaFunction m_Update_hotfix;

		// Token: 0x040079E9 RID: 31209
		private LuaFunction m_CalculateLookVectorVector3Vector3_hotfix;

		// Token: 0x02000B0F RID: 2831
		public enum FocusState
		{
			// Token: 0x040079EB RID: 31211
			Initializing,
			// Token: 0x040079EC RID: 31212
			Finding,
			// Token: 0x040079ED RID: 31213
			Found
		}

		// Token: 0x02000B10 RID: 2832
		public class LuaExportHelper
		{
			// Token: 0x0600BE6F RID: 48751 RVA: 0x00353184 File Offset: 0x00351384
			public LuaExportHelper(ARPlaneTrace owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17002635 RID: 9781
			// (get) Token: 0x0600BE70 RID: 48752 RVA: 0x00353194 File Offset: 0x00351394
			// (set) Token: 0x0600BE71 RID: 48753 RVA: 0x003531A4 File Offset: 0x003513A4
			public float maxRayDistance
			{
				get
				{
					return this.m_owner.maxRayDistance;
				}
				set
				{
					this.m_owner.maxRayDistance = value;
				}
			}

			// Token: 0x17002636 RID: 9782
			// (get) Token: 0x0600BE72 RID: 48754 RVA: 0x003531B4 File Offset: 0x003513B4
			// (set) Token: 0x0600BE73 RID: 48755 RVA: 0x003531C4 File Offset: 0x003513C4
			public LayerMask collisionLayerMask
			{
				get
				{
					return this.m_owner.collisionLayerMask;
				}
				set
				{
					this.m_owner.collisionLayerMask = value;
				}
			}

			// Token: 0x17002637 RID: 9783
			// (get) Token: 0x0600BE74 RID: 48756 RVA: 0x003531D4 File Offset: 0x003513D4
			// (set) Token: 0x0600BE75 RID: 48757 RVA: 0x003531E4 File Offset: 0x003513E4
			public float findingSquareDist
			{
				get
				{
					return this.m_owner.findingSquareDist;
				}
				set
				{
					this.m_owner.findingSquareDist = value;
				}
			}

			// Token: 0x17002638 RID: 9784
			// (get) Token: 0x0600BE76 RID: 48758 RVA: 0x003531F4 File Offset: 0x003513F4
			// (set) Token: 0x0600BE77 RID: 48759 RVA: 0x00353204 File Offset: 0x00351404
			public ARPlaneTrace.FocusState squareState
			{
				get
				{
					return this.m_owner.squareState;
				}
				set
				{
					this.m_owner.squareState = value;
				}
			}

			// Token: 0x17002639 RID: 9785
			// (get) Token: 0x0600BE78 RID: 48760 RVA: 0x00353214 File Offset: 0x00351414
			// (set) Token: 0x0600BE79 RID: 48761 RVA: 0x00353224 File Offset: 0x00351424
			public bool trackingInitialized
			{
				get
				{
					return this.m_owner.trackingInitialized;
				}
				set
				{
					this.m_owner.trackingInitialized = value;
				}
			}

			// Token: 0x0600BE7A RID: 48762 RVA: 0x00353234 File Offset: 0x00351434
			public Quaternion CalculateLookVector(Vector3 srcPos, Vector3 destPos)
			{
				return this.m_owner.CalculateLookVector(srcPos, destPos);
			}

			// Token: 0x040079EE RID: 31214
			private ARPlaneTrace m_owner;
		}
	}
}
