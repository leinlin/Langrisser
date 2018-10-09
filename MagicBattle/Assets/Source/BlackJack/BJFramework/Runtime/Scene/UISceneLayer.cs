using System;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Scene
{
	// Token: 0x020000C2 RID: 194
	[CustomLuaClass]
	public class UISceneLayer : SceneLayerBase
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00020994 File Offset: 0x0001EB94
		public override Camera LayerCamera
		{
			get
			{
				if (this.State == SceneLayerBase.LayerState.InStack)
				{
					if (this.m_layerParent != base.transform.parent)
					{
						this.m_layerParent = base.transform.parent;
						this.m_layerCamera = null;
					}
					if (this.m_layerCamera == null)
					{
						Camera[] componentsInParent = base.GetComponentsInParent<Camera>(true);
						if (componentsInParent.Length != 0)
						{
							this.m_layerCamera = componentsInParent[0];
						}
					}
				}
				else
				{
					this.m_layerCamera = null;
				}
				return this.m_layerCamera;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00020A1C File Offset: 0x0001EC1C
		public Canvas LayerCanvas
		{
			get
			{
				if (this.State == SceneLayerBase.LayerState.InStack)
				{
					if (this.m_layerParent != base.transform.parent)
					{
						this.m_layerParent = base.transform.parent;
						this.m_layerCanvas = null;
					}
					if (this.m_layerCanvas == null)
					{
						Canvas[] componentsInParent = base.GetComponentsInParent<Canvas>(true);
						if (componentsInParent.Length != 0)
						{
							this.m_layerCanvas = componentsInParent[0];
						}
					}
				}
				else
				{
					this.m_layerCanvas = null;
				}
				return this.m_layerCanvas;
			}
		}

		// Token: 0x040004B6 RID: 1206
		private Transform m_layerParent;

		// Token: 0x040004B7 RID: 1207
		private Camera m_layerCamera;

		// Token: 0x040004B8 RID: 1208
		private Canvas m_layerCanvas;
	}
}
