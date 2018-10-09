using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000986 RID: 2438
	[HotFix]
	public class ClientWorldRegion : Entity
	{
		// Token: 0x06008C3B RID: 35899 RVA: 0x0028EB20 File Offset: 0x0028CD20
		public ClientWorldRegion()
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

		// Token: 0x06008C3C RID: 35900 RVA: 0x0028EB90 File Offset: 0x0028CD90
		public void Initialize(ClientWorld world, ConfigDataRegionInfo regionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeClientWorldConfigDataRegionInfo_hotfix != null)
			{
				this.m_InitializeClientWorldConfigDataRegionInfo_hotfix.call(new object[]
				{
					this,
					world,
					regionInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_regionInfo = regionInfo;
			this.m_id = world.GetNextEntityId();
			this.m_gameObject = null;
		}

		// Token: 0x06008C3D RID: 35901 RVA: 0x0028EC2C File Offset: 0x0028CE2C
		public void SetGameObject(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGameObjectGameObject_hotfix != null)
			{
				this.m_SetGameObjectGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_gameObject = go;
			this.m_animator = go.GetComponent<Animator>();
			if (this.m_animator != null)
			{
				this.m_animator.StopPlayback();
			}
		}

		// Token: 0x06008C3E RID: 35902 RVA: 0x0028ECCC File Offset: 0x0028CECC
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
		}

		// Token: 0x06008C3F RID: 35903 RVA: 0x0028ED2C File Offset: 0x0028CF2C
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

		// Token: 0x06008C40 RID: 35904 RVA: 0x0028ED8C File Offset: 0x0028CF8C
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
		}

		// Token: 0x06008C41 RID: 35905 RVA: 0x0028EDFC File Offset: 0x0028CFFC
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

		// Token: 0x06008C42 RID: 35906 RVA: 0x0028EE5C File Offset: 0x0028D05C
		public void SetOpen(bool open)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOpenBoolean_hotfix != null)
			{
				this.m_SetOpenBoolean_hotfix.call(new object[]
				{
					this,
					open
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isOpened = open;
		}

		// Token: 0x06008C43 RID: 35907 RVA: 0x0028EED4 File Offset: 0x0028D0D4
		public bool IsOpened()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOpened_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOpened_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isOpened;
		}

		// Token: 0x06008C44 RID: 35908 RVA: 0x0028EF48 File Offset: 0x0028D148
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
		}

		// Token: 0x06008C45 RID: 35909 RVA: 0x0028EFB8 File Offset: 0x0028D1B8
		private void PlayAnimation(string name)
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
			if (this.m_animator != null)
			{
				this.m_animator.Play(name);
			}
		}

		// Token: 0x06008C46 RID: 35910 RVA: 0x0028F048 File Offset: 0x0028D248
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
			if (this.m_gameObject != null)
			{
				this.m_gameObject.SetActive(visible);
			}
		}

		// Token: 0x06008C47 RID: 35911 RVA: 0x0028F0DC File Offset: 0x0028D2DC
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

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x06008C48 RID: 35912 RVA: 0x0028F150 File Offset: 0x0028D350
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
				if (this.m_gameObject != null)
				{
					return this.m_gameObject.transform.position;
				}
				return Vector2.zero;
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06008C49 RID: 35913 RVA: 0x0028F1E8 File Offset: 0x0028D3E8
		public ConfigDataRegionInfo RegionInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_RegionInfo_hotfix != null)
				{
					return (ConfigDataRegionInfo)this.m_get_RegionInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_regionInfo;
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06008C4A RID: 35914 RVA: 0x0028F25C File Offset: 0x0028D45C
		// (set) Token: 0x06008C4B RID: 35915 RVA: 0x0028F27C File Offset: 0x0028D47C
		[DoNotToLua]
		public new ClientWorldRegion.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClientWorldRegion.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x0028F288 File Offset: 0x0028D488
		private void __callBase_Dispose()
		{
			base.Dispose();
		}

		// Token: 0x06008C4D RID: 35917 RVA: 0x0028F290 File Offset: 0x0028D490
		private void __callBase_Tick()
		{
			base.Tick();
		}

		// Token: 0x06008C4E RID: 35918 RVA: 0x0028F298 File Offset: 0x0028D498
		private void __callBase_TickGraphic(float dt)
		{
			base.TickGraphic(dt);
		}

		// Token: 0x06008C4F RID: 35919 RVA: 0x0028F2A4 File Offset: 0x0028D4A4
		private void __callBase_Draw()
		{
			base.Draw();
		}

		// Token: 0x06008C50 RID: 35920 RVA: 0x0028F2AC File Offset: 0x0028D4AC
		private void __callBase_Pause(bool pause)
		{
			base.Pause(pause);
		}

		// Token: 0x06008C51 RID: 35921 RVA: 0x0028F2B8 File Offset: 0x0028D4B8
		private void __callBase_DoPause(bool pause)
		{
			base.DoPause(pause);
		}

		// Token: 0x06008C52 RID: 35922 RVA: 0x0028F2C4 File Offset: 0x0028D4C4
		private void __callBase_DeleteMe()
		{
			base.DeleteMe();
		}

		// Token: 0x06008C53 RID: 35923 RVA: 0x0028F2CC File Offset: 0x0028D4CC
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
					this.m_InitializeClientWorldConfigDataRegionInfo_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_SetGameObjectGameObject_hotfix = (luaObj.RawGet("SetGameObject") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_SetOpenBoolean_hotfix = (luaObj.RawGet("SetOpen") as LuaFunction);
					this.m_IsOpened_hotfix = (luaObj.RawGet("IsOpened") as LuaFunction);
					this.m_DoPauseBoolean_hotfix = (luaObj.RawGet("DoPause") as LuaFunction);
					this.m_PlayAnimationString_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_SetVisibleBoolean_hotfix = (luaObj.RawGet("SetVisible") as LuaFunction);
					this.m_IsVisible_hotfix = (luaObj.RawGet("IsVisible") as LuaFunction);
					this.m_get_Position_hotfix = (luaObj.RawGet("get_Position") as LuaFunction);
					this.m_get_RegionInfo_hotfix = (luaObj.RawGet("get_RegionInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008C54 RID: 35924 RVA: 0x0028F4F8 File Offset: 0x0028D6F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientWorldRegion));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040063BC RID: 25532
		private ConfigDataRegionInfo m_regionInfo;

		// Token: 0x040063BD RID: 25533
		private GameObject m_gameObject;

		// Token: 0x040063BE RID: 25534
		private Animator m_animator;

		// Token: 0x040063BF RID: 25535
		private bool m_isOpened;

		// Token: 0x040063C0 RID: 25536
		private bool m_isVisible;

		// Token: 0x040063C1 RID: 25537
		[DoNotToLua]
		private ClientWorldRegion.LuaExportHelper luaExportHelper;

		// Token: 0x040063C2 RID: 25538
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040063C3 RID: 25539
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040063C4 RID: 25540
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040063C5 RID: 25541
		private LuaFunction m_InitializeClientWorldConfigDataRegionInfo_hotfix;

		// Token: 0x040063C6 RID: 25542
		private LuaFunction m_SetGameObjectGameObject_hotfix;

		// Token: 0x040063C7 RID: 25543
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x040063C8 RID: 25544
		private LuaFunction m_Tick_hotfix;

		// Token: 0x040063C9 RID: 25545
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x040063CA RID: 25546
		private LuaFunction m_Draw_hotfix;

		// Token: 0x040063CB RID: 25547
		private LuaFunction m_SetOpenBoolean_hotfix;

		// Token: 0x040063CC RID: 25548
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x040063CD RID: 25549
		private LuaFunction m_DoPauseBoolean_hotfix;

		// Token: 0x040063CE RID: 25550
		private LuaFunction m_PlayAnimationString_hotfix;

		// Token: 0x040063CF RID: 25551
		private LuaFunction m_SetVisibleBoolean_hotfix;

		// Token: 0x040063D0 RID: 25552
		private LuaFunction m_IsVisible_hotfix;

		// Token: 0x040063D1 RID: 25553
		private LuaFunction m_get_Position_hotfix;

		// Token: 0x040063D2 RID: 25554
		private LuaFunction m_get_RegionInfo_hotfix;

		// Token: 0x02000987 RID: 2439
		public new class LuaExportHelper
		{
			// Token: 0x06008C55 RID: 35925 RVA: 0x0028F560 File Offset: 0x0028D760
			public LuaExportHelper(ClientWorldRegion owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008C56 RID: 35926 RVA: 0x0028F570 File Offset: 0x0028D770
			public void __callBase_Dispose()
			{
				this.m_owner.__callBase_Dispose();
			}

			// Token: 0x06008C57 RID: 35927 RVA: 0x0028F580 File Offset: 0x0028D780
			public void __callBase_Tick()
			{
				this.m_owner.__callBase_Tick();
			}

			// Token: 0x06008C58 RID: 35928 RVA: 0x0028F590 File Offset: 0x0028D790
			public void __callBase_TickGraphic(float dt)
			{
				this.m_owner.__callBase_TickGraphic(dt);
			}

			// Token: 0x06008C59 RID: 35929 RVA: 0x0028F5A0 File Offset: 0x0028D7A0
			public void __callBase_Draw()
			{
				this.m_owner.__callBase_Draw();
			}

			// Token: 0x06008C5A RID: 35930 RVA: 0x0028F5B0 File Offset: 0x0028D7B0
			public void __callBase_Pause(bool pause)
			{
				this.m_owner.__callBase_Pause(pause);
			}

			// Token: 0x06008C5B RID: 35931 RVA: 0x0028F5C0 File Offset: 0x0028D7C0
			public void __callBase_DoPause(bool pause)
			{
				this.m_owner.__callBase_DoPause(pause);
			}

			// Token: 0x06008C5C RID: 35932 RVA: 0x0028F5D0 File Offset: 0x0028D7D0
			public void __callBase_DeleteMe()
			{
				this.m_owner.__callBase_DeleteMe();
			}

			// Token: 0x17001D64 RID: 7524
			// (get) Token: 0x06008C5D RID: 35933 RVA: 0x0028F5E0 File Offset: 0x0028D7E0
			// (set) Token: 0x06008C5E RID: 35934 RVA: 0x0028F5F0 File Offset: 0x0028D7F0
			public ConfigDataRegionInfo m_regionInfo
			{
				get
				{
					return this.m_owner.m_regionInfo;
				}
				set
				{
					this.m_owner.m_regionInfo = value;
				}
			}

			// Token: 0x17001D65 RID: 7525
			// (get) Token: 0x06008C5F RID: 35935 RVA: 0x0028F600 File Offset: 0x0028D800
			// (set) Token: 0x06008C60 RID: 35936 RVA: 0x0028F610 File Offset: 0x0028D810
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

			// Token: 0x17001D66 RID: 7526
			// (get) Token: 0x06008C61 RID: 35937 RVA: 0x0028F620 File Offset: 0x0028D820
			// (set) Token: 0x06008C62 RID: 35938 RVA: 0x0028F630 File Offset: 0x0028D830
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

			// Token: 0x17001D67 RID: 7527
			// (get) Token: 0x06008C63 RID: 35939 RVA: 0x0028F640 File Offset: 0x0028D840
			// (set) Token: 0x06008C64 RID: 35940 RVA: 0x0028F650 File Offset: 0x0028D850
			public bool m_isOpened
			{
				get
				{
					return this.m_owner.m_isOpened;
				}
				set
				{
					this.m_owner.m_isOpened = value;
				}
			}

			// Token: 0x17001D68 RID: 7528
			// (get) Token: 0x06008C65 RID: 35941 RVA: 0x0028F660 File Offset: 0x0028D860
			// (set) Token: 0x06008C66 RID: 35942 RVA: 0x0028F670 File Offset: 0x0028D870
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

			// Token: 0x06008C67 RID: 35943 RVA: 0x0028F680 File Offset: 0x0028D880
			public void PlayAnimation(string name)
			{
				this.m_owner.PlayAnimation(name);
			}

			// Token: 0x040063D3 RID: 25555
			private ClientWorldRegion m_owner;
		}
	}
}
