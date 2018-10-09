using System;
using System.Collections.Generic;
using SLua;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BlackJack.BJFramework.Runtime.Scene
{
	// Token: 0x020000C3 RID: 195
	[CustomLuaClass]
	public class UnitySceneLayer : ThreeDSceneLayer
	{
		// Token: 0x060006FF RID: 1791 RVA: 0x00020AB8 File Offset: 0x0001ECB8
		public void SetScene(Scene scene)
		{
			this.Scene = scene;
			this.UnitySceneRootObjs.AddRange(scene.GetRootGameObjects());
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00020AD4 File Offset: 0x0001ECD4
		public override Camera LayerCamera
		{
			get
			{
				if (this.m_layerCamera == null)
				{
					foreach (GameObject gameObject in this.UnitySceneRootObjs)
					{
						Camera[] componentsInChildren = gameObject.GetComponentsInChildren<Camera>(true);
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
									return this.m_layerCamera;
								}
							}
						}
					}
				}
				return this.m_layerCamera;
			}
		}

		// Token: 0x040004B9 RID: 1209
		private Camera m_layerCamera;

		// Token: 0x040004BA RID: 1210
		public Scene Scene;

		// Token: 0x040004BB RID: 1211
		public List<GameObject> UnitySceneRootObjs = new List<GameObject>();
	}
}
