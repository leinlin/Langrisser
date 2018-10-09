using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C09 RID: 3081
	[HotFix]
	public class TouchFx
	{
		// Token: 0x0600D801 RID: 55297 RVA: 0x003ABEE4 File Offset: 0x003AA0E4
		public TouchFx()
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

		// Token: 0x0600D802 RID: 55298 RVA: 0x003ABF64 File Offset: 0x003AA164
		public void Init(GameObject parent, Camera camera)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGameObjectCamera_hotfix != null)
			{
				this.m_InitGameObjectCamera_hotfix.call(new object[]
				{
					this,
					parent,
					camera
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_graphicPool = new GraphicPool(true);
			this.m_fxPlayer = new FxPlayer(this.m_graphicPool);
			this.m_fxPlayer.SetDefaultParent(parent);
			this.m_camera = camera;
		}

		// Token: 0x0600D803 RID: 55299 RVA: 0x003AC014 File Offset: 0x003AA214
		public void SetHitFxName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHitFxNameString_hotfix != null)
			{
				this.m_SetHitFxNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hitFxName = name;
		}

		// Token: 0x0600D804 RID: 55300 RVA: 0x003AC08C File Offset: 0x003AA28C
		public void SetLoopFxName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLoopFxNameString_hotfix != null)
			{
				this.m_SetLoopFxNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (name == this.m_loopFxName)
			{
				return;
			}
			this.m_loopFxName = name;
			for (int i = 0; i < this.m_loopFxs.Length; i++)
			{
				GenericGraphic genericGraphic = this.m_loopFxs[i];
				if (genericGraphic != null && genericGraphic.AssetName != name)
				{
					genericGraphic.FxStop(true);
					this.m_loopFxs[i] = null;
				}
			}
		}

		// Token: 0x0600D805 RID: 55301 RVA: 0x003AC160 File Offset: 0x003AA360
		public void SetDisableInputGameObject(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDisableInputGameObjectGameObject_hotfix != null)
			{
				this.m_SetDisableInputGameObjectGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_disableInputGameObject = go;
		}

		// Token: 0x0600D806 RID: 55302 RVA: 0x003AC1D8 File Offset: 0x003AA3D8
		public void SetTouchFXParentActive(bool isActive)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTouchFXParentActiveBoolean_hotfix != null)
			{
				this.m_SetTouchFXParentActiveBoolean_hotfix.call(new object[]
				{
					this,
					isActive
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fxPlayer.m_parentGameObject.SetActive(isActive);
		}

		// Token: 0x0600D807 RID: 55303 RVA: 0x003AC25C File Offset: 0x003AA45C
		public void ClearFx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearFx_hotfix != null)
			{
				this.m_ClearFx_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fxPlayer.Clear();
			this.m_touchStates.Clear();
			for (int i = 0; i < this.m_loopFxs.Length; i++)
			{
				this.m_loopFxs[i] = null;
			}
		}

		// Token: 0x0600D808 RID: 55304 RVA: 0x003AC2F4 File Offset: 0x003AA4F4
		public void Dispose()
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
			this.ClearFx();
			this.m_graphicPool.Clear();
		}

		// Token: 0x0600D809 RID: 55305 RVA: 0x003AC368 File Offset: 0x003AA568
		public void Tick(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickSingle_hotfix != null)
			{
				this.m_TickSingle_hotfix.call(new object[]
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
			this.m_touchStates.Clear();
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				TouchFx.TouchState item = default(TouchFx.TouchState);
				item.phase = touch.phase;
				item.fingerId = touch.fingerId;
				item.position = touch.position;
				this.m_touchStates.Add(item);
			}
			if (this.m_touchStates.Count == 0)
			{
				for (int j = 0; j < 3; j++)
				{
					if (Input.GetMouseButtonDown(j))
					{
						TouchFx.TouchState item2 = default(TouchFx.TouchState);
						item2.phase = TouchPhase.Began;
						item2.fingerId = j;
						item2.position = Input.mousePosition;
						this.m_touchStates.Add(item2);
					}
					if (Input.GetMouseButtonUp(j))
					{
						TouchFx.TouchState item3 = default(TouchFx.TouchState);
						item3.phase = TouchPhase.Ended;
						item3.fingerId = j;
						item3.position = Input.mousePosition;
						this.m_touchStates.Add(item3);
					}
					if (Input.GetMouseButton(j))
					{
						TouchFx.TouchState item4 = default(TouchFx.TouchState);
						item4.phase = TouchPhase.Moved;
						item4.fingerId = j;
						item4.position = Input.mousePosition;
						this.m_touchStates.Add(item4);
					}
				}
			}
			foreach (TouchFx.TouchState touchState in this.m_touchStates)
			{
				if (touchState.fingerId < this.m_loopFxs.Length)
				{
					Vector3 position = this.m_camera.ScreenToWorldPoint(touchState.position);
					if (touchState.phase == TouchPhase.Began)
					{
						if (!(this.m_disableInputGameObject != null) || !this.m_disableInputGameObject.activeSelf)
						{
							GenericGraphic genericGraphic = this.m_fxPlayer.Play(this.m_hitFxName);
							if (genericGraphic != null)
							{
								genericGraphic.SetPosition(position);
								genericGraphic.AutoDelete(true);
							}
							if (this.m_loopFxs[touchState.fingerId] == null)
							{
								this.m_loopFxs[touchState.fingerId] = this.m_fxPlayer.Play(this.m_loopFxName);
								if (this.m_loopFxs[touchState.fingerId] != null)
								{
									this.m_loopFxs[touchState.fingerId].AutoDelete(false);
								}
							}
							if (this.m_loopFxs[touchState.fingerId] != null)
							{
								this.m_loopFxs[touchState.fingerId].SetPosition(position);
							}
						}
					}
					else if (touchState.phase == TouchPhase.Ended || touchState.phase == TouchPhase.Canceled)
					{
						if (this.m_loopFxs[touchState.fingerId] != null)
						{
							this.m_loopFxs[touchState.fingerId].FxStop(true);
							this.m_loopFxs[touchState.fingerId] = null;
						}
					}
					else if (touchState.phase == TouchPhase.Moved && this.m_loopFxs[touchState.fingerId] != null)
					{
						this.m_loopFxs[touchState.fingerId].SetPosition(position);
					}
				}
			}
			this.m_fxPlayer.Tick(dt);
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x0600D80A RID: 55306 RVA: 0x003AC738 File Offset: 0x003AA938
		// (set) Token: 0x0600D80B RID: 55307 RVA: 0x003AC758 File Offset: 0x003AA958
		[DoNotToLua]
		public TouchFx.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TouchFx.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D80C RID: 55308 RVA: 0x003AC764 File Offset: 0x003AA964
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
					this.m_InitGameObjectCamera_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_SetHitFxNameString_hotfix = (luaObj.RawGet("SetHitFxName") as LuaFunction);
					this.m_SetLoopFxNameString_hotfix = (luaObj.RawGet("SetLoopFxName") as LuaFunction);
					this.m_SetDisableInputGameObjectGameObject_hotfix = (luaObj.RawGet("SetDisableInputGameObject") as LuaFunction);
					this.m_SetTouchFXParentActiveBoolean_hotfix = (luaObj.RawGet("SetTouchFXParentActive") as LuaFunction);
					this.m_ClearFx_hotfix = (luaObj.RawGet("ClearFx") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_TickSingle_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D80D RID: 55309 RVA: 0x003AC8F8 File Offset: 0x003AAAF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TouchFx));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040084C9 RID: 33993
		private string m_hitFxName;

		// Token: 0x040084CA RID: 33994
		private string m_loopFxName;

		// Token: 0x040084CB RID: 33995
		private Camera m_camera;

		// Token: 0x040084CC RID: 33996
		private GameObject m_disableInputGameObject;

		// Token: 0x040084CD RID: 33997
		private GraphicPool m_graphicPool;

		// Token: 0x040084CE RID: 33998
		private FxPlayer m_fxPlayer;

		// Token: 0x040084CF RID: 33999
		private List<TouchFx.TouchState> m_touchStates = new List<TouchFx.TouchState>();

		// Token: 0x040084D0 RID: 34000
		private GenericGraphic[] m_loopFxs = new GenericGraphic[10];

		// Token: 0x040084D1 RID: 34001
		[DoNotToLua]
		private TouchFx.LuaExportHelper luaExportHelper;

		// Token: 0x040084D2 RID: 34002
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040084D3 RID: 34003
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040084D4 RID: 34004
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040084D5 RID: 34005
		private LuaFunction m_InitGameObjectCamera_hotfix;

		// Token: 0x040084D6 RID: 34006
		private LuaFunction m_SetHitFxNameString_hotfix;

		// Token: 0x040084D7 RID: 34007
		private LuaFunction m_SetLoopFxNameString_hotfix;

		// Token: 0x040084D8 RID: 34008
		private LuaFunction m_SetDisableInputGameObjectGameObject_hotfix;

		// Token: 0x040084D9 RID: 34009
		private LuaFunction m_SetTouchFXParentActiveBoolean_hotfix;

		// Token: 0x040084DA RID: 34010
		private LuaFunction m_ClearFx_hotfix;

		// Token: 0x040084DB RID: 34011
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x040084DC RID: 34012
		private LuaFunction m_TickSingle_hotfix;

		// Token: 0x02000C0A RID: 3082
		public struct TouchState
		{
			// Token: 0x040084DD RID: 34013
			public int fingerId;

			// Token: 0x040084DE RID: 34014
			public Vector2 position;

			// Token: 0x040084DF RID: 34015
			public TouchPhase phase;
		}

		// Token: 0x02000C0B RID: 3083
		public class LuaExportHelper
		{
			// Token: 0x0600D80E RID: 55310 RVA: 0x003AC960 File Offset: 0x003AAB60
			public LuaExportHelper(TouchFx owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17002A17 RID: 10775
			// (get) Token: 0x0600D80F RID: 55311 RVA: 0x003AC970 File Offset: 0x003AAB70
			// (set) Token: 0x0600D810 RID: 55312 RVA: 0x003AC980 File Offset: 0x003AAB80
			public string m_hitFxName
			{
				get
				{
					return this.m_owner.m_hitFxName;
				}
				set
				{
					this.m_owner.m_hitFxName = value;
				}
			}

			// Token: 0x17002A18 RID: 10776
			// (get) Token: 0x0600D811 RID: 55313 RVA: 0x003AC990 File Offset: 0x003AAB90
			// (set) Token: 0x0600D812 RID: 55314 RVA: 0x003AC9A0 File Offset: 0x003AABA0
			public string m_loopFxName
			{
				get
				{
					return this.m_owner.m_loopFxName;
				}
				set
				{
					this.m_owner.m_loopFxName = value;
				}
			}

			// Token: 0x17002A19 RID: 10777
			// (get) Token: 0x0600D813 RID: 55315 RVA: 0x003AC9B0 File Offset: 0x003AABB0
			// (set) Token: 0x0600D814 RID: 55316 RVA: 0x003AC9C0 File Offset: 0x003AABC0
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

			// Token: 0x17002A1A RID: 10778
			// (get) Token: 0x0600D815 RID: 55317 RVA: 0x003AC9D0 File Offset: 0x003AABD0
			// (set) Token: 0x0600D816 RID: 55318 RVA: 0x003AC9E0 File Offset: 0x003AABE0
			public GameObject m_disableInputGameObject
			{
				get
				{
					return this.m_owner.m_disableInputGameObject;
				}
				set
				{
					this.m_owner.m_disableInputGameObject = value;
				}
			}

			// Token: 0x17002A1B RID: 10779
			// (get) Token: 0x0600D817 RID: 55319 RVA: 0x003AC9F0 File Offset: 0x003AABF0
			// (set) Token: 0x0600D818 RID: 55320 RVA: 0x003ACA00 File Offset: 0x003AAC00
			public GraphicPool m_graphicPool
			{
				get
				{
					return this.m_owner.m_graphicPool;
				}
				set
				{
					this.m_owner.m_graphicPool = value;
				}
			}

			// Token: 0x17002A1C RID: 10780
			// (get) Token: 0x0600D819 RID: 55321 RVA: 0x003ACA10 File Offset: 0x003AAC10
			// (set) Token: 0x0600D81A RID: 55322 RVA: 0x003ACA20 File Offset: 0x003AAC20
			public FxPlayer m_fxPlayer
			{
				get
				{
					return this.m_owner.m_fxPlayer;
				}
				set
				{
					this.m_owner.m_fxPlayer = value;
				}
			}

			// Token: 0x17002A1D RID: 10781
			// (get) Token: 0x0600D81B RID: 55323 RVA: 0x003ACA30 File Offset: 0x003AAC30
			// (set) Token: 0x0600D81C RID: 55324 RVA: 0x003ACA40 File Offset: 0x003AAC40
			public List<TouchFx.TouchState> m_touchStates
			{
				get
				{
					return this.m_owner.m_touchStates;
				}
				set
				{
					this.m_owner.m_touchStates = value;
				}
			}

			// Token: 0x17002A1E RID: 10782
			// (get) Token: 0x0600D81D RID: 55325 RVA: 0x003ACA50 File Offset: 0x003AAC50
			// (set) Token: 0x0600D81E RID: 55326 RVA: 0x003ACA60 File Offset: 0x003AAC60
			public GenericGraphic[] m_loopFxs
			{
				get
				{
					return this.m_owner.m_loopFxs;
				}
				set
				{
					this.m_owner.m_loopFxs = value;
				}
			}

			// Token: 0x040084E0 RID: 34016
			private TouchFx m_owner;
		}
	}
}
