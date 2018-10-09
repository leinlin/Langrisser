using System;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Scene
{
	// Token: 0x020000C1 RID: 193
	[CustomLuaClass]
	public class ThreeDSceneLayer : SceneLayerBase
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00020908 File Offset: 0x0001EB08
		public override Camera LayerCamera
		{
			get
			{
				if (this.m_layerCamera == null)
				{
					Camera[] componentsInChildren = base.GetComponentsInChildren<Camera>(true);
					if (componentsInChildren.Length == 1)
					{
						this.m_layerCamera = componentsInChildren[0];
					}
					else
					{
						foreach (Camera camera in componentsInChildren)
						{
							if (camera.gameObject.name == "LayerCamera")
							{
								this.m_layerCamera = camera;
								break;
							}
						}
					}
				}
				return this.m_layerCamera;
			}
		}

		// Token: 0x040004B5 RID: 1205
		private Camera m_layerCamera;
	}
}
