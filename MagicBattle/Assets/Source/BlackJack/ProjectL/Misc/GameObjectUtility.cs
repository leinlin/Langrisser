using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000873 RID: 2163
	[CustomLuaClass]
	public class GameObjectUtility
	{
		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06006B4F RID: 27471 RVA: 0x001E198C File Offset: 0x001DFB8C
		public static GameObject SceneRoot
		{
			get
			{
				if (GameObjectUtility.m_sceneRoot != null)
				{
					return GameObjectUtility.m_sceneRoot;
				}
				GameObjectUtility.m_sceneRoot = GameObject.Find("SceneRoot");
				return GameObjectUtility.m_sceneRoot;
			}
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x001E19B8 File Offset: 0x001DFBB8
		public static GameObject FindChildObject(GameObject parentObj, string[] path)
		{
			GameObject o = null;
			GameObjectUtility.FindChildObject(parentObj, path, delegate(GameObject obj)
			{
				o = obj;
			});
			return o;
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x001E19EC File Offset: 0x001DFBEC
		public static void FindChildObject(GameObject parentObj, string[] path, Action<GameObject> action)
		{
			if (parentObj == null)
			{
				return;
			}
			if (path.Length == 0)
			{
				return;
			}
			if (action == null)
			{
				return;
			}
			for (int i = 0; i < parentObj.transform.childCount; i++)
			{
				Transform child = parentObj.transform.GetChild(i);
				if (!(child.gameObject == null))
				{
					int num;
					if (child.gameObject.name.ToLower() == path[0].ToLower() || (path[0].StartsWith("_GetChildAtIndex_") && int.TryParse(path[0].Substring(17), out num) && num - 1 == i))
					{
						if (path.Length == 1)
						{
							action(child.gameObject);
						}
						else
						{
							string[] array = new string[path.Length - 1];
							Array.Copy(path, 1, array, 0, array.Length);
							GameObjectUtility.FindChildObject(child.gameObject, array, action);
						}
						return;
					}
					GameObjectUtility.FindChildObject(child.gameObject, path, action);
				}
			}
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x001E1AF4 File Offset: 0x001DFCF4
		public static GameObject FindChildGameObject_R(GameObject go, string name)
		{
			if (go == null)
			{
				return null;
			}
			if (go.name == name)
			{
				return go;
			}
			for (int i = 0; i < go.transform.childCount; i++)
			{
				GameObject gameObject = GameObjectUtility.FindChildGameObject_R(go.transform.GetChild(i).gameObject, name);
				if (gameObject != null)
				{
					return gameObject;
				}
			}
			return null;
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x001E1B68 File Offset: 0x001DFD68
		public static string GetDefaultName(string assetName)
		{
			if (string.IsNullOrEmpty(assetName))
			{
				return string.Empty;
			}
			return Path.GetFileNameWithoutExtension(assetName);
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x001E1B84 File Offset: 0x001DFD84
		public static T AddControllerToGameObject<T>(GameObject go) where T : class
		{
			if (go == null)
			{
				return (T)((object)null);
			}
			return PrefabControllerBase.AddControllerToGameObject(go, "./", new TypeDNName(string.Empty + typeof(T).FullName), typeof(T).Name, null, true) as T;
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x001E1BF0 File Offset: 0x001DFDF0
		public static PrefabControllerBase AddControllerToGameObject(Type type, GameObject go)
		{
			if (go == null)
			{
				return null;
			}
			return PrefabControllerBase.AddControllerToGameObject(go, "./", new TypeDNName(string.Empty + type.FullName), type.Name, null, true);
		}

		// Token: 0x06006B56 RID: 27478 RVA: 0x001E1C28 File Offset: 0x001DFE28
		public static GameObject FindGameObjectByName(Transform parent, string name)
		{
			for (int i = 0; i < parent.transform.childCount; i++)
			{
				Transform child = parent.transform.GetChild(i);
				if (child.name == name)
				{
					return child.gameObject;
				}
				GameObject gameObject = GameObjectUtility.FindGameObjectByName(parent.transform.GetChild(i), name);
				if (gameObject != null)
				{
					return gameObject;
				}
			}
			return null;
		}

		// Token: 0x06006B57 RID: 27479 RVA: 0x001E1C98 File Offset: 0x001DFE98
		public static T FindComponentByName<T>(Transform parent, string name) where T : MonoBehaviour
		{
			for (int i = 0; i < parent.transform.childCount; i++)
			{
				Transform child = parent.transform.GetChild(i);
				if (child.name == name)
				{
					return child.GetComponent<T>();
				}
				T t = GameObjectUtility.FindComponentByName<T>(parent.transform.GetChild(i), name);
				if (t != null)
				{
					return t;
				}
			}
			return (T)((object)null);
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x001E1D14 File Offset: 0x001DFF14
		public static GameObject CloneGameObject(GameObject cloneObj, Transform parent)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(cloneObj, parent, false);
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localScale = Vector3.one;
			gameObject.transform.localRotation = Quaternion.identity;
			gameObject.SetActive(true);
			return gameObject;
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x001E1D64 File Offset: 0x001DFF64
		public static void DestroyChildren(GameObject obj)
		{
			if (obj == null)
			{
				return;
			}
			int childCount = obj.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				UnityEngine.Object.Destroy(obj.transform.GetChild(i).gameObject);
			}
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x001E1DB4 File Offset: 0x001DFFB4
		public static void DestroyChildrenImmediate(GameObject obj)
		{
			if (obj == null)
			{
				return;
			}
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < obj.transform.childCount; i++)
			{
				list.Add(obj.transform.GetChild(i).gameObject);
			}
			for (int j = 0; j < list.Count; j++)
			{
				UnityEngine.Object.DestroyImmediate(list[j]);
			}
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x001E1E2C File Offset: 0x001E002C
		public static void DestroyComponentList<T>(List<T> list) where T : MonoBehaviour
		{
			if (list == null)
			{
				return;
			}
			foreach (T t in list)
			{
				UnityEngine.Object.Destroy(t.gameObject);
			}
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x001E1E98 File Offset: 0x001E0098
		public static void InactiveComponentList<T>(List<T> list) where T : MonoBehaviour
		{
			if (list == null)
			{
				return;
			}
			foreach (T t in list)
			{
				t.gameObject.SetActive(false);
			}
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x001E1F04 File Offset: 0x001E0104
		public static bool HasChinese(string str)
		{
			return Regex.IsMatch(str, "[\\u4e00-\\u9fa5]");
		}

		// Token: 0x040052A8 RID: 21160
		private static GameObject m_sceneRoot;
	}
}
