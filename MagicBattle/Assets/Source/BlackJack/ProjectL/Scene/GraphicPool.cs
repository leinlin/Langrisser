using System;
using System.Collections.Generic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200097C RID: 2428
	[CustomLuaClass]
	public class GraphicPool
	{
		// Token: 0x06008AC9 RID: 35529 RVA: 0x00286F38 File Offset: 0x00285138
		public GraphicPool(bool isFx)
		{
			this.m_isFx = isFx;
			this.m_pool = new Dictionary<string, List<GenericGraphic>>();
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x00286F54 File Offset: 0x00285154
		public void SetDefaultParent(GameObject go)
		{
			this.m_parentGameObject = go;
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x00286F60 File Offset: 0x00285160
		public GenericGraphic Create(string assetName)
		{
			if (string.IsNullOrEmpty(assetName))
			{
				return null;
			}
			List<GenericGraphic> list;
			if (this.m_pool.TryGetValue(assetName, out list) && list.Count > 0)
			{
				GenericGraphic genericGraphic = list[list.Count - 1];
				list.RemoveAt(list.Count - 1);
				genericGraphic.SetActive(true);
				return genericGraphic;
			}
			GenericGraphic genericGraphic2 = new GenericGraphic();
			if (genericGraphic2.Create(assetName, this.m_isFx))
			{
				if (this.m_parentGameObject != null)
				{
					genericGraphic2.SetParent(this.m_parentGameObject);
				}
				return genericGraphic2;
			}
			genericGraphic2.Destroy();
			return null;
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x00287000 File Offset: 0x00285200
		public void Destroy(GenericGraphic g)
		{
			if (g == null)
			{
				return;
			}
			string assetName = g.AssetName;
			List<GenericGraphic> list;
			if (!this.m_pool.TryGetValue(assetName, out list))
			{
				list = new List<GenericGraphic>();
				this.m_pool.Add(assetName, list);
			}
			g.SetActive(false);
			if (this.m_parentGameObject != null)
			{
				g.SetParent(this.m_parentGameObject);
			}
			list.Add(g);
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x0028706C File Offset: 0x0028526C
		public void Clear()
		{
			foreach (KeyValuePair<string, List<GenericGraphic>> keyValuePair in this.m_pool)
			{
				foreach (GenericGraphic genericGraphic in keyValuePair.Value)
				{
					genericGraphic.Destroy();
				}
			}
			this.m_pool.Clear();
		}

		// Token: 0x040062DC RID: 25308
		private bool m_isFx;

		// Token: 0x040062DD RID: 25309
		private GameObject m_parentGameObject;

		// Token: 0x040062DE RID: 25310
		private Dictionary<string, List<GenericGraphic>> m_pool;
	}
}
