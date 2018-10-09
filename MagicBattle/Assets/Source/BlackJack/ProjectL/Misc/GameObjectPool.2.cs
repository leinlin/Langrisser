using System;
using System.Collections.Generic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000876 RID: 2166
	[CustomLuaClass]
	public class GameObjectPool
	{
		// Token: 0x06006B69 RID: 27497 RVA: 0x001E21B0 File Offset: 0x001E03B0
		public void Setup(GameObject prefab, GameObject parent)
		{
			this.m_prefab = prefab;
			this.m_parent = parent;
			if (this.m_prefab != null)
			{
				this.m_prefab.SetActive(true);
			}
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x001E21E0 File Offset: 0x001E03E0
		public GameObject Allocate()
		{
			if (this.m_prefab == null)
			{
				return null;
			}
			foreach (GameObject gameObject in this.m_list)
			{
				if (!gameObject.activeSelf)
				{
					gameObject.SetActive(true);
					return gameObject;
				}
			}
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_prefab);
			if (gameObject2 != null)
			{
				if (this.m_parent != null)
				{
					gameObject2.transform.SetParent(this.m_parent.transform, false);
				}
				this.m_list.Add(gameObject2);
				return gameObject2;
			}
			return null;
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x001E22B4 File Offset: 0x001E04B4
		public void Deactive()
		{
			foreach (GameObject gameObject in this.m_list)
			{
				gameObject.SetActive(false);
			}
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x001E2310 File Offset: 0x001E0510
		public void Destroy()
		{
			foreach (GameObject obj in this.m_list)
			{
				UnityEngine.Object.Destroy(obj);
			}
			this.m_list.Clear();
		}

		// Token: 0x06006B6D RID: 27501 RVA: 0x001E2378 File Offset: 0x001E0578
		public List<GameObject> GetList()
		{
			return this.m_list;
		}

		// Token: 0x040052AD RID: 21165
		public List<GameObject> m_list = new List<GameObject>();

		// Token: 0x040052AE RID: 21166
		private GameObject m_prefab;

		// Token: 0x040052AF RID: 21167
		private GameObject m_parent;
	}
}
