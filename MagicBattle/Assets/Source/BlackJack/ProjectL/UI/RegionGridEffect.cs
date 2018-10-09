using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A7C RID: 2684
	[HotFix]
	public class RegionGridEffect : MonoBehaviour
	{
		// Token: 0x0600A9C9 RID: 43465 RVA: 0x002F5718 File Offset: 0x002F3918
		private void Awake()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Awake_hotfix != null)
			{
				this.m_Awake_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_initScale = base.transform.localScale;
		}

		// Token: 0x0600A9CA RID: 43466 RVA: 0x002F578C File Offset: 0x002F398C
		private void Update()
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
			float deltaTime = Time.deltaTime;
			if (this.m_delayTime > 0f)
			{
				this.m_delayTime -= deltaTime;
				if (this.m_delayTime > 0f)
				{
					return;
				}
				this.m_delayTime = 0f;
			}
			if (this.m_time < this.m_duration)
			{
				this.m_time += deltaTime;
				float num = Mathf.Clamp01(this.m_time / this.m_duration);
				if (!this.m_isFadeIn)
				{
					num = 1f - num;
				}
				num = Easing.Back.Out(num);
				base.transform.localScale = Vector3.LerpUnclamped(Vector3.zero, this.m_initScale, num);
			}
		}

		// Token: 0x0600A9CB RID: 43467 RVA: 0x002F5894 File Offset: 0x002F3A94
		public void SetDelay(float t)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDelaySingle_hotfix != null)
			{
				this.m_SetDelaySingle_hotfix.call(new object[]
				{
					this,
					t
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_delayTime = t;
		}

		// Token: 0x0600A9CC RID: 43468 RVA: 0x002F590C File Offset: 0x002F3B0C
		public void SetDuration(float t)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDurationSingle_hotfix != null)
			{
				this.m_SetDurationSingle_hotfix.call(new object[]
				{
					this,
					t
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_duration = t;
			this.m_time = 0f;
		}

		// Token: 0x0600A9CD RID: 43469 RVA: 0x002F5990 File Offset: 0x002F3B90
		public void SetFade(bool fadeIn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFadeBoolean_hotfix != null)
			{
				this.m_SetFadeBoolean_hotfix.call(new object[]
				{
					this,
					fadeIn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isFadeIn = fadeIn;
			if (fadeIn)
			{
				base.transform.localScale = Vector3.zero;
			}
			else
			{
				base.transform.localScale = this.m_initScale;
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x0600A9CE RID: 43470 RVA: 0x002F5A34 File Offset: 0x002F3C34
		// (set) Token: 0x0600A9CF RID: 43471 RVA: 0x002F5A54 File Offset: 0x002F3C54
		[DoNotToLua]
		public RegionGridEffect.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RegionGridEffect.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A9D0 RID: 43472 RVA: 0x002F5A60 File Offset: 0x002F3C60
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
					this.m_Awake_hotfix = (luaObj.RawGet("Awake") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_SetDelaySingle_hotfix = (luaObj.RawGet("SetDelay") as LuaFunction);
					this.m_SetDurationSingle_hotfix = (luaObj.RawGet("SetDuration") as LuaFunction);
					this.m_SetFadeBoolean_hotfix = (luaObj.RawGet("SetFade") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A9D1 RID: 43473 RVA: 0x002F5B90 File Offset: 0x002F3D90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RegionGridEffect));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006FBA RID: 28602
		private float m_delayTime;

		// Token: 0x04006FBB RID: 28603
		private float m_duration;

		// Token: 0x04006FBC RID: 28604
		private float m_time;

		// Token: 0x04006FBD RID: 28605
		private bool m_isFadeIn = true;

		// Token: 0x04006FBE RID: 28606
		private Vector3 m_initScale;

		// Token: 0x04006FBF RID: 28607
		[DoNotToLua]
		private RegionGridEffect.LuaExportHelper luaExportHelper;

		// Token: 0x04006FC0 RID: 28608
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006FC1 RID: 28609
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006FC2 RID: 28610
		private LuaFunction m_Awake_hotfix;

		// Token: 0x04006FC3 RID: 28611
		private LuaFunction m_Update_hotfix;

		// Token: 0x04006FC4 RID: 28612
		private LuaFunction m_SetDelaySingle_hotfix;

		// Token: 0x04006FC5 RID: 28613
		private LuaFunction m_SetDurationSingle_hotfix;

		// Token: 0x04006FC6 RID: 28614
		private LuaFunction m_SetFadeBoolean_hotfix;

		// Token: 0x02000A7D RID: 2685
		public class LuaExportHelper
		{
			// Token: 0x0600A9D2 RID: 43474 RVA: 0x002F5BF8 File Offset: 0x002F3DF8
			public LuaExportHelper(RegionGridEffect owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17002273 RID: 8819
			// (get) Token: 0x0600A9D3 RID: 43475 RVA: 0x002F5C08 File Offset: 0x002F3E08
			// (set) Token: 0x0600A9D4 RID: 43476 RVA: 0x002F5C18 File Offset: 0x002F3E18
			public float m_delayTime
			{
				get
				{
					return this.m_owner.m_delayTime;
				}
				set
				{
					this.m_owner.m_delayTime = value;
				}
			}

			// Token: 0x17002274 RID: 8820
			// (get) Token: 0x0600A9D5 RID: 43477 RVA: 0x002F5C28 File Offset: 0x002F3E28
			// (set) Token: 0x0600A9D6 RID: 43478 RVA: 0x002F5C38 File Offset: 0x002F3E38
			public float m_duration
			{
				get
				{
					return this.m_owner.m_duration;
				}
				set
				{
					this.m_owner.m_duration = value;
				}
			}

			// Token: 0x17002275 RID: 8821
			// (get) Token: 0x0600A9D7 RID: 43479 RVA: 0x002F5C48 File Offset: 0x002F3E48
			// (set) Token: 0x0600A9D8 RID: 43480 RVA: 0x002F5C58 File Offset: 0x002F3E58
			public float m_time
			{
				get
				{
					return this.m_owner.m_time;
				}
				set
				{
					this.m_owner.m_time = value;
				}
			}

			// Token: 0x17002276 RID: 8822
			// (get) Token: 0x0600A9D9 RID: 43481 RVA: 0x002F5C68 File Offset: 0x002F3E68
			// (set) Token: 0x0600A9DA RID: 43482 RVA: 0x002F5C78 File Offset: 0x002F3E78
			public bool m_isFadeIn
			{
				get
				{
					return this.m_owner.m_isFadeIn;
				}
				set
				{
					this.m_owner.m_isFadeIn = value;
				}
			}

			// Token: 0x17002277 RID: 8823
			// (get) Token: 0x0600A9DB RID: 43483 RVA: 0x002F5C88 File Offset: 0x002F3E88
			// (set) Token: 0x0600A9DC RID: 43484 RVA: 0x002F5C98 File Offset: 0x002F3E98
			public Vector3 m_initScale
			{
				get
				{
					return this.m_owner.m_initScale;
				}
				set
				{
					this.m_owner.m_initScale = value;
				}
			}

			// Token: 0x0600A9DD RID: 43485 RVA: 0x002F5CA8 File Offset: 0x002F3EA8
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x0600A9DE RID: 43486 RVA: 0x002F5CB8 File Offset: 0x002F3EB8
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x04006FC7 RID: 28615
			private RegionGridEffect m_owner;
		}
	}
}
