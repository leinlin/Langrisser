using System;
using System.Collections;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.Utils;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.Scene
{
	// Token: 0x020000BC RID: 188
	[CustomLuaClass]
	public class SceneManager : ITickable
	{
		// Token: 0x060006CF RID: 1743 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
		private SceneManager()
		{
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001F2F8 File Offset: 0x0001D4F8
		[DoNotToLua]
		public static SceneManager CreateSceneManager()
		{
			if (SceneManager.m_instance == null)
			{
				SceneManager.m_instance = new SceneManager();
			}
			return SceneManager.m_instance;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0001F314 File Offset: 0x0001D514
		[DoNotToLua]
		public bool Initlize(int designScreenWidth, int designScreenHeight, int trigerWidth2ShrinkScale, int trigerHeight2ShrinkScale, Vector3 layerOffset, bool enableLayerReserve = false, bool useOrthographicForUILayer = false)
		{
			global::Debug.Log("SceneManager.Initlize start");
			this.m_designScreenWidth = designScreenWidth;
			this.m_designScreenHeight = designScreenHeight;
			this.m_trigerWidth2ShrinkScale = trigerWidth2ShrinkScale;
			this.m_trigerHeight2ShrinkScale = trigerHeight2ShrinkScale;
			this.m_layerOffset = layerOffset;
			this.m_useOrthographicForUILayer = useOrthographicForUILayer;
			this.m_enableLayerReserve = enableLayerReserve;
			if (!this.CreateSceneRoot())
			{
				global::Debug.LogError("SceneManager.Initlize CreateSceneRoot fail");
				return false;
			}
			this.m_uiLayerRootPrefab = Resources.Load<GameObject>(SceneManager.m_uiLayerRootAssetPath);
			this.m_3DLayerRootPrefab = Resources.Load<GameObject>(SceneManager.m_3DLayerRootAssetPath);
			if (this.m_uiLayerRootPrefab == null || this.m_3DLayerRootPrefab == null)
			{
				global::Debug.LogError("SceneManager.Initlize m_uiLayerRootPrefab == null || m_3DLayerRootPrefab == null");
				return false;
			}
			LayerRenderSettingDesc defaultRenderSetting = this.GetDefaultRenderSetting();
			if (defaultRenderSetting == null)
			{
				global::Debug.LogError("SceneManager.Initlize GetDefaultRenderSetting fail");
				return false;
			}
			this.ApplyRenderSetting(defaultRenderSetting);
			return true;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0001F3EC File Offset: 0x0001D5EC
		[DoNotToLua]
		public void Uninitlize()
		{
			global::Debug.Log("SceneManager.Uninitlize");
			this.m_corutineHelper.CancelAll();
			foreach (KeyValuePair<string, SceneLayerBase> keyValuePair in this.m_layerDict)
			{
				if (keyValuePair.Value != null)
				{
					UnityEngine.Object.Destroy(keyValuePair.Value.gameObject);
				}
			}
			this.m_layerDict.Clear();
			this.m_loadingLayerList.Clear();
			this.m_unusedLayerList.Clear();
			this.m_layerStack.Clear();
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
		private bool CreateSceneRoot()
		{
			global::Debug.Log("SceneManager.CreateSceneRoot start");
			GameObject gameObject = Resources.Load<GameObject>(SceneManager.m_sceneRootAssetPath);
			if (gameObject == null)
			{
				global::Debug.LogError("SceneManager.CreateSceneRoot fail sceneRootPrefab = null");
				return false;
			}
			this.m_sceneRootGo = UnityEngine.Object.Instantiate<GameObject>(gameObject);
			if (this.m_sceneRootGo == null)
			{
				global::Debug.LogError("SceneManager.CreateSceneRoot fail sceneRootGo = null");
				return false;
			}
			Util.RemoveCloneFromGameObjectName(this.m_sceneRootGo);
			this.m_sceneRootGo.transform.localPosition = Vector3.zero;
			this.m_sceneRootGo.transform.localRotation = Quaternion.identity;
			this.m_sceneRootGo.transform.localScale = Vector3.one;
			this.m_3DSceneRootGo = this.m_sceneRootGo.transform.Find("3DSceneRoot").gameObject;
			this.m_unusedLayerRootGo = this.m_sceneRootGo.transform.Find("UnusedLayerRoot").gameObject;
			this.m_loadingLayerRootGo = this.m_sceneRootGo.transform.Find("LoadingLayerRoot").gameObject;
			this.m_uiSceneGroup1RootCanvasGo = this.m_sceneRootGo.transform.Find("UISceneRoot/UILayerGroupRoot1/Canvas").gameObject;
			this.m_uiSceneGroup2RootCanvasGo = this.m_sceneRootGo.transform.Find("UISceneRoot/UILayerGroupRoot2/Canvas").gameObject;
			this.m_uiSceneGroup1Camera = this.m_sceneRootGo.transform.Find("UISceneRoot/UILayerGroupRoot1").gameObject.GetComponent<Camera>();
			this.m_uiSceneGroup2Camera = this.m_sceneRootGo.transform.Find("UISceneRoot/UILayerGroupRoot2").gameObject.GetComponent<Camera>();
			this.m_uiSceneGroup1RootCanvas = this.m_uiSceneGroup1RootCanvasGo.GetComponent<Canvas>();
			this.m_uiSceneGroup2RootCanvas = this.m_uiSceneGroup2RootCanvasGo.GetComponent<Canvas>();
			this.m_uiSceneGroup1RootCanvasScaler = this.m_uiSceneGroup1RootCanvasGo.GetComponent<CanvasScaler>();
			this.m_uiSceneGroup2RootCanvasScaler = this.m_uiSceneGroup2RootCanvasGo.GetComponent<CanvasScaler>();
			this.m_uiSceneGroup1RootCanvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
			this.m_uiSceneGroup1RootCanvasScaler.referenceResolution = new Vector2((float)this.m_designScreenWidth, (float)this.m_designScreenHeight);
			if (Screen.width < this.m_trigerWidth2ShrinkScale || Screen.height < this.m_trigerHeight2ShrinkScale)
			{
				this.m_uiSceneGroup1RootCanvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Shrink;
			}
			this.m_uiSceneGroup2RootCanvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
			this.m_uiSceneGroup2RootCanvasScaler.referenceResolution = new Vector2((float)this.m_designScreenWidth, (float)this.m_designScreenHeight);
			if (Screen.width < this.m_trigerWidth2ShrinkScale || Screen.height < this.m_trigerHeight2ShrinkScale)
			{
				this.m_uiSceneGroup2RootCanvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Shrink;
			}
			if (this.m_useOrthographicForUILayer)
			{
				Camera component = this.m_sceneRootGo.transform.Find("UISceneRoot/UILayerGroupRoot1").GetComponent<Camera>();
				component.orthographic = true;
				component = this.m_sceneRootGo.transform.Find("UISceneRoot/UILayerGroupRoot2").GetComponent<Camera>();
				component.orthographic = true;
			}
			return true;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0001F780 File Offset: 0x0001D980
		public void CreateLayer(Type layerType, string name, string resPath, Action<SceneLayerBase> onComplete, bool enableReserve = false)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new Exception("CreateLayer need a name");
			}
			if (!this.m_enableLayerReserve)
			{
				enableReserve = false;
			}
			SceneLayerBase sceneLayerBase = this.FindLayerByName(name);
			if (sceneLayerBase != null)
			{
				if (sceneLayerBase.IsReserve() && sceneLayerBase.State == SceneLayerBase.LayerState.Unused)
				{
					onComplete(sceneLayerBase);
				}
				else
				{
					onComplete(null);
				}
				return;
			}
			if (this.m_layerDict.ContainsKey(name))
			{
				throw new Exception(string.Format("CreateLayer name conflict {0}", name));
			}
			if (layerType == typeof(UISceneLayer))
			{
				this.CreateUILayer(name, resPath, onComplete, enableReserve);
			}
			else if (layerType == typeof(ThreeDSceneLayer))
			{
				this.Create3DLayer(name, resPath, onComplete, enableReserve);
			}
			else if (layerType == typeof(UnitySceneLayer))
			{
				this.CreateUnitySceneLayer(name, resPath, onComplete);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0001F870 File Offset: 0x0001DA70
		private void CreateUILayer(string name, string resPath, Action<SceneLayerBase> onComplete, bool enableReserve = false)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_uiLayerRootPrefab);
			Util.RemoveCloneFromGameObjectName(gameObject);
			gameObject.name = name + "_LayerRoot";
			UISceneLayer layer = gameObject.GetComponent<UISceneLayer>();
			layer.SetName(name);
			layer.SetReserve(enableReserve);
			this.m_layerDict.Add(name, layer);
			this.AddLayerToLoading(layer);
			IEnumerator corutine = ResourceManager.Instance.LoadAsset<GameObject>(resPath, delegate(string lpath, GameObject lasset)
			{
				if (layer.State == SceneLayerBase.LayerState.WaitForFree)
				{
					this.FreeLayer(layer);
					return;
				}
				this.OnLayerLoadAssetComplete(layer, lasset);
				onComplete((!(lasset == null)) ? layer : null);
			}, false, false);
			this.m_corutineHelper.StartCorutine(corutine);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001F920 File Offset: 0x0001DB20
		private void Create3DLayer(string name, string resPath, Action<SceneLayerBase> onComplete, bool enableReserve = false)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_3DLayerRootPrefab);
			if (gameObject == null)
			{
				global::Debug.LogError(string.Format("CreateUILayer fail to clone m_3DLayerRootPrefab name={0}", name));
			}
			Util.RemoveCloneFromGameObjectName(gameObject);
			gameObject.name = name + "_LayerRoot";
			ThreeDSceneLayer layer = gameObject.GetComponent<ThreeDSceneLayer>();
			layer.SetName(name);
			layer.SetReserve(enableReserve);
			this.m_layerDict.Add(name, layer);
			this.AddLayerToLoading(layer);
			IEnumerator corutine = ResourceManager.Instance.LoadAsset<GameObject>(resPath, delegate(string lpath, GameObject lasset)
			{
				if (layer.State == SceneLayerBase.LayerState.WaitForFree)
				{
					this.FreeLayer(layer);
					return;
				}
				this.OnLayerLoadAssetComplete(layer, lasset);
				onComplete((!(lasset == null)) ? layer : null);
			}, false, false);
			this.m_corutineHelper.StartCorutine(corutine);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001F9EC File Offset: 0x0001DBEC
		private void CreateUnitySceneLayer(string name, string resPath, Action<SceneLayerBase> onComplete)
		{
			Scene? scene;
			IEnumerator corutine = ResourceManager.Instance.LoadUnityScene(resPath, delegate(string lpath, Scene? lscene)
			{
				if (lscene == null)
				{
					onComplete(null);
					return;
				}
				scene = lscene;
				GameObject[] rootGameObjects = scene.Value.GetRootGameObjects();
				if (rootGameObjects == null || rootGameObjects.Length == 0)
				{
					onComplete(null);
					return;
				}
				UnitySceneLayer unitySceneLayer = rootGameObjects[0].AddComponent<UnitySceneLayer>();
				unitySceneLayer.SetName(name);
				unitySceneLayer.SetScene(scene.Value);
				this.m_layerDict.Add(name, unitySceneLayer);
				unitySceneLayer.State = SceneLayerBase.LayerState.Unused;
				this.m_unusedLayerList.Add(unitySceneLayer);
				this.PushLayer(unitySceneLayer);
				onComplete(unitySceneLayer);
			}, false, false);
			this.m_corutineHelper.StartCorutine(corutine);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001FA3C File Offset: 0x0001DC3C
		public void FreeLayer(SceneLayerBase layer)
		{
			if (layer == null)
			{
				return;
			}
			if (layer.State == SceneLayerBase.LayerState.Loading)
			{
				layer.State = SceneLayerBase.LayerState.WaitForFree;
				return;
			}
			if (layer.State == SceneLayerBase.LayerState.InStack)
			{
				this.PopLayer(layer);
				if (layer.IsReserve())
				{
					return;
				}
			}
			this.m_layerDict.Remove(layer.LayerName);
			this.m_unusedLayerList.Remove(layer);
			this.m_loadingLayerList.Remove(layer);
			if (layer.GetType() != typeof(UnitySceneLayer))
			{
				UnityEngine.Object.Destroy(layer.gameObject);
			}
			else
			{
				UnitySceneLayer unitySceneLayer = layer as UnitySceneLayer;
				SceneManager.UnloadSceneAsync(unitySceneLayer.Scene);
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001FAF0 File Offset: 0x0001DCF0
		public bool PushLayer(SceneLayerBase layer)
		{
			if (layer.State != SceneLayerBase.LayerState.Unused)
			{
				global::Debug.LogError(string.Format("PushLayer in wrong state layer={0} state={1}", layer.name, layer.State));
				return false;
			}
			this.m_unusedLayerList.Remove(layer);
			this.m_layerStack.Add(layer);
			layer.State = SceneLayerBase.LayerState.InStack;
			if (layer.GetType() == typeof(UISceneLayer))
			{
				layer.transform.SetParent(this.m_uiSceneGroup1RootCanvasGo.transform, false);
			}
			else if (layer.GetType() == typeof(ThreeDSceneLayer))
			{
				layer.transform.SetParent(this.m_3DSceneRootGo.transform, false);
			}
			else if (layer.GetType() == typeof(UnitySceneLayer))
			{
			}
			if (layer.GetType() != typeof(UnitySceneLayer))
			{
				layer.gameObject.SetActive(true);
			}
			this.m_stackDirty = true;
			return true;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		public void PopLayer(SceneLayerBase layer)
		{
			if (layer.State != SceneLayerBase.LayerState.InStack)
			{
				global::Debug.LogError(string.Format("PopLayer in wrong state layer={0} state={1}", layer.name, layer.State));
				return;
			}
			if (layer.GetType() != typeof(UnitySceneLayer))
			{
				layer.gameObject.SetActive(false);
			}
			this.m_layerStack.Remove(layer);
			this.m_unusedLayerList.Add(layer);
			if (layer.GetType() != typeof(UnitySceneLayer))
			{
				layer.gameObject.transform.SetParent(this.m_unusedLayerRootGo.transform, false);
			}
			layer.State = SceneLayerBase.LayerState.Unused;
			this.m_stackDirty = true;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0001FCA8 File Offset: 0x0001DEA8
		public void BringLayerToTop(UISceneLayer layer)
		{
			this.PopLayer(layer);
			this.PushLayer(layer);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0001FCBC File Offset: 0x0001DEBC
		public void Enable3DLayerBlur(bool isEnable)
		{
			if (isEnable == this.m_is3DLayerBlurActive)
			{
				return;
			}
			this.m_is3DLayerBlurActive = isEnable;
			this.m_stackDirty = true;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0001FCDC File Offset: 0x0001DEDC
		private void AddLayerToLoading(SceneLayerBase layer)
		{
			if (layer.GetType() == typeof(UnitySceneLayer))
			{
				return;
			}
			layer.gameObject.transform.SetParent(this.m_loadingLayerRootGo.transform, false);
			layer.gameObject.transform.localPosition = Vector3.zero;
			layer.gameObject.transform.localScale = Vector3.one;
			layer.gameObject.transform.localRotation = Quaternion.identity;
			layer.gameObject.SetActive(false);
			this.m_loadingLayerList.Add(layer);
			layer.State = SceneLayerBase.LayerState.Loading;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0001FD7C File Offset: 0x0001DF7C
		private void AddLayerToUnused(SceneLayerBase layer)
		{
			if (layer.GetType() == typeof(UnitySceneLayer))
			{
				return;
			}
			this.m_loadingLayerList.Remove(layer);
			this.m_layerStack.Remove(layer);
			layer.gameObject.transform.SetParent(this.m_unusedLayerRootGo.transform, false);
			layer.gameObject.transform.localPosition = Vector3.zero;
			layer.gameObject.transform.localScale = Vector3.one;
			layer.gameObject.transform.localRotation = Quaternion.identity;
			layer.gameObject.SetActive(false);
			this.m_unusedLayerList.Add(layer);
			layer.State = SceneLayerBase.LayerState.Unused;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0001FE34 File Offset: 0x0001E034
		public GameObject RootCanvasGo
		{
			get
			{
				return this.m_uiSceneGroup1RootCanvasGo;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001FE3C File Offset: 0x0001E03C
		private void OnLayerLoadAssetComplete(SceneLayerBase layer, GameObject asset)
		{
			if (layer.GetType() == typeof(UnitySceneLayer))
			{
				return;
			}
			if (asset == null)
			{
				global::Debug.LogError(string.Format("CreateUILayer LoadAsset fail name={0}", layer.LayerName));
				this.FreeLayer(layer);
				return;
			}
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(asset);
			Util.RemoveCloneFromGameObjectName(go);
			layer.AttachGameObject(go);
			this.AddLayerToUnused(layer);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001FEA4 File Offset: 0x0001E0A4
		[DoNotToLua]
		public void Tick()
		{
			this.m_corutineHelper.Tick();
			this.UpdateLayerStack();
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001FEB8 File Offset: 0x0001E0B8
		private void UpdateLayerStack()
		{
			if (!this.m_stackDirty)
			{
				return;
			}
			this.m_stackDirty = false;
			this.SortLayerStack(this.m_layerStack);
			bool flag = false;
			int num = SceneManager.m_cameraDepthMax;
			Vector3 vector = Vector3.zero;
			UnitySceneLayer unitySceneLayer = null;
			this.m_uiSceneGroup2RootCanvasGo.SetActive(false);
			for (int i = this.m_layerStack.Count - 1; i >= 0; i--)
			{
				SceneLayerBase sceneLayerBase = this.m_layerStack[i];
				if (sceneLayerBase.GetType() == typeof(UISceneLayer))
				{
					if (!flag)
					{
						sceneLayerBase.gameObject.transform.SetParent(this.m_uiSceneGroup1RootCanvasGo.transform, false);
						sceneLayerBase.gameObject.transform.localPosition = Vector3.zero;
						sceneLayerBase.gameObject.transform.localScale = Vector3.one;
						sceneLayerBase.gameObject.transform.SetAsFirstSibling();
						sceneLayerBase.LayerCamera.depth = (float)num;
					}
					else
					{
						if (!this.m_uiSceneGroup2RootCanvasGo.activeSelf)
						{
							this.m_uiSceneGroup2RootCanvasGo.SetActive(true);
						}
						sceneLayerBase.gameObject.transform.SetParent(this.m_uiSceneGroup2RootCanvasGo.transform, false);
						sceneLayerBase.gameObject.transform.localPosition = Vector3.zero;
						sceneLayerBase.gameObject.transform.SetAsFirstSibling();
						sceneLayerBase.LayerCamera.depth = (float)num;
					}
				}
				else if (sceneLayerBase.GetType() == typeof(ThreeDSceneLayer))
				{
					sceneLayerBase.gameObject.transform.SetParent(this.m_3DSceneRootGo.transform, false);
					sceneLayerBase.gameObject.transform.localPosition = vector;
					vector += this.m_layerOffset;
					sceneLayerBase.LayerCamera.depth = (float)(--num);
					num--;
					MonoBehaviour monoBehaviour = sceneLayerBase.LayerCamera.gameObject.GetComponent("UnityStandardAssets.ImageEffects.BlurOptimized") as MonoBehaviour;
					if (monoBehaviour != null)
					{
						monoBehaviour.enabled = this.m_is3DLayerBlurActive;
					}
					flag = true;
				}
				else
				{
					unitySceneLayer = ((!(unitySceneLayer == null)) ? unitySceneLayer : ((UnitySceneLayer)sceneLayerBase));
					sceneLayerBase.LayerCamera.depth = (float)(--num);
					num--;
					flag = true;
				}
			}
			bool flag2 = false;
			LayerRenderSettingDesc layerRenderSettingDesc = null;
			for (int j = this.m_layerStack.Count - 1; j >= 0; j--)
			{
				SceneLayerBase sceneLayerBase2 = this.m_layerStack[j];
				layerRenderSettingDesc = ((!(layerRenderSettingDesc == null)) ? layerRenderSettingDesc : sceneLayerBase2.GetRenderSetting());
				if (!flag2)
				{
					sceneLayerBase2.gameObject.SetActive(true);
				}
				else
				{
					sceneLayerBase2.gameObject.SetActive(false);
				}
				if (sceneLayerBase2.IsOpaque() && sceneLayerBase2.IsFullScreen())
				{
					flag2 = true;
				}
			}
			if (layerRenderSettingDesc == null)
			{
				layerRenderSettingDesc = this.GetDefaultRenderSetting();
			}
			if (unitySceneLayer != null)
			{
				if (SceneManager.GetActiveScene() != unitySceneLayer.Scene)
				{
					SceneManager.SetActiveScene(unitySceneLayer.Scene);
				}
			}
			else
			{
				this.ApplyRenderSetting(layerRenderSettingDesc);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000201EC File Offset: 0x0001E3EC
		private void SortLayerStack(List<SceneLayerBase> layerStack)
		{
			for (int i = 1; i < layerStack.Count; i++)
			{
				int num = i;
				SceneLayerBase sceneLayerBase = layerStack[i];
				while (num > 0 && !sceneLayerBase.IsStayOnTop() && layerStack[num - 1].IsStayOnTop())
				{
					layerStack[num] = layerStack[num - 1];
					num--;
				}
				layerStack[num] = sceneLayerBase;
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00020260 File Offset: 0x0001E460
		private LayerRenderSettingDesc GetDefaultRenderSetting()
		{
			if (this.m_defaultRenderSetting != null)
			{
				return this.m_defaultRenderSetting;
			}
			LayerRenderSettingDesc componentInChildren = this.m_sceneRootGo.GetComponentInChildren<LayerRenderSettingDesc>(true);
			this.m_defaultRenderSetting = componentInChildren;
			return this.m_defaultRenderSetting;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000202A0 File Offset: 0x0001E4A0
		private void ApplyRenderSetting(LayerRenderSettingDesc renderSetting)
		{
			if (this.m_currRenderSetting == renderSetting)
			{
				return;
			}
			this.m_currRenderSetting = renderSetting;
			this.ApplyRenderSettingImp(this.m_currRenderSetting);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000202C8 File Offset: 0x0001E4C8
		public void ApplyCurrRenderSetting()
		{
			this.ApplyRenderSettingImp(this.m_currRenderSetting);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000202D8 File Offset: 0x0001E4D8
		public LayerRenderSettingDesc GetCurrRenderSetting()
		{
			return this.m_currRenderSetting;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000202E0 File Offset: 0x0001E4E0
		private void ApplyRenderSettingImp(LayerRenderSettingDesc renderSetting)
		{
			RenderSettings.ambientMode = renderSetting.enviornmentLighting.AmbientSource;
			if (renderSetting.enviornmentLighting.AmbientSource == AmbientMode.Skybox)
			{
				RenderSettings.skybox = renderSetting.enviornmentLighting.SkyBox;
				RenderSettings.ambientLight = renderSetting.enviornmentLighting.AmbientColor;
			}
			else if (renderSetting.enviornmentLighting.AmbientSource == AmbientMode.Flat)
			{
				RenderSettings.skybox = renderSetting.enviornmentLighting.SkyBox;
				RenderSettings.ambientLight = renderSetting.enviornmentLighting.AmbientColor;
			}
			RenderSettings.ambientIntensity = renderSetting.enviornmentLighting.AmbientIntensity;
			RenderSettings.fog = renderSetting.fog.EnableFog;
			RenderSettings.fogMode = renderSetting.fog.FogMode;
			RenderSettings.fogColor = renderSetting.fog.FogColor;
			if (renderSetting.fog.FogMode == FogMode.Linear)
			{
				RenderSettings.fogStartDistance = renderSetting.fog.FogStart;
				RenderSettings.fogEndDistance = renderSetting.fog.FogEnd;
			}
			else
			{
				RenderSettings.fogDensity = renderSetting.fog.FogDensity;
			}
			DynamicGI.UpdateEnvironment();
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000203F0 File Offset: 0x0001E5F0
		public GameObject GetRootCanvas(int index = 0)
		{
			if (index == 0)
			{
				return this.m_uiSceneGroup1RootCanvasGo;
			}
			return this.m_uiSceneGroup2RootCanvasGo;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00020408 File Offset: 0x0001E608
		public SceneLayerBase FindLayerByName(string name)
		{
			SceneLayerBase result;
			this.m_layerDict.TryGetValue(name, out result);
			return result;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00020428 File Offset: 0x0001E628
		public SceneLayerBase FindUILayerUnderLayer(string name, Func<SceneLayerBase, bool> filter)
		{
			int num = this.m_layerStack.FindIndex((SceneLayerBase layer) => layer.LayerName == name);
			if (num == -1)
			{
				return null;
			}
			for (int i = num + 1; i < this.m_layerStack.Count; i++)
			{
				if (this.m_layerStack[i] is UISceneLayer)
				{
					if (filter == null || filter(this.m_layerStack[i]))
					{
						return this.m_layerStack[i];
					}
				}
			}
			return null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000204C8 File Offset: 0x0001E6C8
		public Camera GetLayerCameraFromSceneByPath(string rectTransPath)
		{
			string[] array = rectTransPath.Split(new char[]
			{
				'/'
			});
			if (array.Length == 0)
			{
				global::Debug.LogError("GetLayerCameraFromSceneByPath can't find Camera for " + rectTransPath);
				return null;
			}
			foreach (SceneLayerBase sceneLayerBase in this.m_layerStack)
			{
				Transform x = sceneLayerBase.transform.Find(array[0]);
				if (x != null)
				{
					return sceneLayerBase.GetComponentInParent<Camera>();
				}
			}
			return null;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00020578 File Offset: 0x0001E778
		public RectTransform GetRectTransformFromSceneByPath(string rectTransPath)
		{
			string[] array = rectTransPath.Split(new char[]
			{
				'/'
			});
			if (array.Length == 0)
			{
				global::Debug.LogError("GetRectTransformFromSceneByPath can't find rectRect for " + rectTransPath);
				return null;
			}
			int i = 0;
			RectTransform rectTransform = null;
			foreach (SceneLayerBase sceneLayerBase in this.m_layerStack)
			{
				rectTransform = (sceneLayerBase.transform.Find(array[i]) as RectTransform);
				if (rectTransform != null)
				{
					break;
				}
			}
			i++;
			if (rectTransform != null)
			{
				RectTransform rectTransform2 = rectTransform;
				RectTransform rectTransform3 = null;
				while (i < array.Length)
				{
					rectTransform3 = (rectTransform2.Find(array[i]) as RectTransform);
					if (!(rectTransform3 != null))
					{
						break;
					}
					rectTransform2 = rectTransform3;
					i++;
				}
				if (rectTransform3 != null)
				{
					return rectTransform3;
				}
			}
			global::Debug.LogError("GetRectTransformFromSceneByPath can't find rectRect for " + rectTransPath);
			return null;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00020698 File Offset: 0x0001E898
		public static string GetObjectPath(GameObject obj)
		{
			if (obj == null)
			{
				return string.Empty;
			}
			if (obj.transform.parent == null)
			{
				return obj.name;
			}
			return string.Format("{0}\\{1}", SceneManager.GetObjectPath(obj.transform.parent.gameObject), obj.name);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000206FC File Offset: 0x0001E8FC
		public static SceneManager Instance
		{
			get
			{
				return SceneManager.m_instance;
			}
		}

		// Token: 0x04000487 RID: 1159
		private static SceneManager m_instance;

		// Token: 0x04000488 RID: 1160
		private TinyCorutineHelper m_corutineHelper = new TinyCorutineHelper();

		// Token: 0x04000489 RID: 1161
		private bool m_useOrthographicForUILayer;

		// Token: 0x0400048A RID: 1162
		private int m_designScreenWidth;

		// Token: 0x0400048B RID: 1163
		private int m_designScreenHeight;

		// Token: 0x0400048C RID: 1164
		private int m_trigerWidth2ShrinkScale;

		// Token: 0x0400048D RID: 1165
		private int m_trigerHeight2ShrinkScale;

		// Token: 0x0400048E RID: 1166
		private Vector3 m_layerOffset;

		// Token: 0x0400048F RID: 1167
		private GameObject m_sceneRootGo;

		// Token: 0x04000490 RID: 1168
		private GameObject m_unusedLayerRootGo;

		// Token: 0x04000491 RID: 1169
		private GameObject m_loadingLayerRootGo;

		// Token: 0x04000492 RID: 1170
		private GameObject m_3DSceneRootGo;

		// Token: 0x04000493 RID: 1171
		private GameObject m_uiSceneGroup1RootCanvasGo;

		// Token: 0x04000494 RID: 1172
		private GameObject m_uiSceneGroup2RootCanvasGo;

		// Token: 0x04000495 RID: 1173
		public Camera m_uiSceneGroup1Camera;

		// Token: 0x04000496 RID: 1174
		public Camera m_uiSceneGroup2Camera;

		// Token: 0x04000497 RID: 1175
		private Canvas m_uiSceneGroup1RootCanvas;

		// Token: 0x04000498 RID: 1176
		private Canvas m_uiSceneGroup2RootCanvas;

		// Token: 0x04000499 RID: 1177
		private CanvasScaler m_uiSceneGroup1RootCanvasScaler;

		// Token: 0x0400049A RID: 1178
		private CanvasScaler m_uiSceneGroup2RootCanvasScaler;

		// Token: 0x0400049B RID: 1179
		private GameObject m_3DLayerRootPrefab;

		// Token: 0x0400049C RID: 1180
		private GameObject m_uiLayerRootPrefab;

		// Token: 0x0400049D RID: 1181
		private Dictionary<string, SceneLayerBase> m_layerDict = new Dictionary<string, SceneLayerBase>();

		// Token: 0x0400049E RID: 1182
		private List<SceneLayerBase> m_unusedLayerList = new List<SceneLayerBase>();

		// Token: 0x0400049F RID: 1183
		private List<SceneLayerBase> m_loadingLayerList = new List<SceneLayerBase>();

		// Token: 0x040004A0 RID: 1184
		private List<SceneLayerBase> m_layerStack = new List<SceneLayerBase>();

		// Token: 0x040004A1 RID: 1185
		private bool m_stackDirty;

		// Token: 0x040004A2 RID: 1186
		private bool m_is3DLayerBlurActive;

		// Token: 0x040004A3 RID: 1187
		private LayerRenderSettingDesc m_currRenderSetting;

		// Token: 0x040004A4 RID: 1188
		private LayerRenderSettingDesc m_defaultRenderSetting;

		// Token: 0x040004A5 RID: 1189
		private bool m_enableLayerReserve;

		// Token: 0x040004A6 RID: 1190
		private static string m_sceneRootAssetPath = "SceneRoot";

		// Token: 0x040004A7 RID: 1191
		private static string m_3DLayerRootAssetPath = "3DLayerRoot";

		// Token: 0x040004A8 RID: 1192
		private static string m_uiLayerRootAssetPath = "UILayerRoot";

		// Token: 0x040004A9 RID: 1193
		private static int m_cameraDepthMax = 80;
	}
}
