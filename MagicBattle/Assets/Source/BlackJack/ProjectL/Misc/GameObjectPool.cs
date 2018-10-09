using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Prefab;
using UnityEngine;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000875 RID: 2165
	public class GameObjectPool<T> where T : MonoBehaviour
	{
		// Token: 0x06006B62 RID: 27490 RVA: 0x001E1F40 File Offset: 0x001E0140
		public void Setup(GameObject prefab, GameObject parent)
		{
			this.m_prefab = prefab;
			this.m_parent = parent;
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x001E1F50 File Offset: 0x001E0150
		public T Allocate()
		{
			bool flag;
			return this.Allocate(out flag);
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x001E1F68 File Offset: 0x001E0168
		public T Allocate(out bool isNew)
		{
			isNew = false;
			if (this.m_prefab == null)
			{
				return (T)((object)null);
			}
			foreach (T result in this.m_list)
			{
				if (!result.gameObject.activeSelf)
				{
					result.gameObject.SetActive(true);
					return result;
				}
			}
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_prefab);
			if (gameObject != null)
			{
				gameObject.SetActive(true);
				T t = (T)((object)null);
				if (typeof(T).IsSubclassOf(typeof(PrefabControllerBase)))
				{
					t = GameObjectUtility.AddControllerToGameObject<T>(gameObject);
				}
				else
				{
					t = gameObject.AddComponent<T>();
				}
				if (t != null)
				{
					if (this.m_parent != null)
					{
						gameObject.transform.SetParent(this.m_parent.transform, false);
					}
					this.m_list.Add(t);
					isNew = true;
					return t;
				}
			}
			return (T)((object)null);
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x001E20B8 File Offset: 0x001E02B8
		public void Deactive()
		{
			foreach (T t in this.m_list)
			{
				t.gameObject.SetActive(false);
			}
		}

		// Token: 0x06006B66 RID: 27494 RVA: 0x001E2120 File Offset: 0x001E0320
		public void Destroy()
		{
			foreach (T t in this.m_list)
			{
				UnityEngine.Object.Destroy(t.gameObject);
			}
			this.m_list.Clear();
		}

		// Token: 0x06006B67 RID: 27495 RVA: 0x001E2194 File Offset: 0x001E0394
		public List<T> GetList()
		{
			return this.m_list;
		}

		// Token: 0x040052AA RID: 21162
		private List<T> m_list = new List<T>();

		// Token: 0x040052AB RID: 21163
		private GameObject m_prefab;

		// Token: 0x040052AC RID: 21164
		private GameObject m_parent;
	}
}
