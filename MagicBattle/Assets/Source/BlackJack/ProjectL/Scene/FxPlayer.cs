using System;
using System.Collections.Generic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000975 RID: 2421
	[CustomLuaClass]
	public class FxPlayer
	{
		// Token: 0x06008A78 RID: 35448 RVA: 0x00283F48 File Offset: 0x00282148
		public FxPlayer(GraphicPool pool)
		{
			this.m_pool = pool;
		}

		// Token: 0x06008A79 RID: 35449 RVA: 0x00283F64 File Offset: 0x00282164
		public void Clear()
		{
			foreach (GenericGraphic g in this.m_fxs)
			{
				this.m_pool.Destroy(g);
			}
			this.m_fxs.Clear();
		}

		// Token: 0x06008A7A RID: 35450 RVA: 0x00283FD0 File Offset: 0x002821D0
		public void SetDefaultParent(GameObject go)
		{
			this.m_parentGameObject = go;
		}

		// Token: 0x06008A7B RID: 35451 RVA: 0x00283FDC File Offset: 0x002821DC
		public GenericGraphic Play(string assetName)
		{
			if (string.IsNullOrEmpty(assetName))
			{
				return null;
			}
			GenericGraphic genericGraphic = this.m_pool.Create(assetName);
			if (genericGraphic != null)
			{
				if (this.m_parentGameObject != null)
				{
					genericGraphic.SetParent(this.m_parentGameObject);
				}
				this.m_fxs.Add(genericGraphic);
			}
			return genericGraphic;
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x00284034 File Offset: 0x00282234
		public void PauseAll(bool pause)
		{
			foreach (GenericGraphic genericGraphic in this.m_fxs)
			{
				genericGraphic.Pause(pause);
			}
		}

		// Token: 0x06008A7D RID: 35453 RVA: 0x00284090 File Offset: 0x00282290
		public void DeleteAutoDeleteFxs()
		{
			foreach (GenericGraphic genericGraphic in this.m_fxs)
			{
				if (genericGraphic.IsAutoDelete)
				{
					genericGraphic.DeleteMe();
				}
			}
		}

		// Token: 0x06008A7E RID: 35454 RVA: 0x002840F8 File Offset: 0x002822F8
		public void Tick(float dt)
		{
			int i = 0;
			while (i < this.m_fxs.Count)
			{
				GenericGraphic genericGraphic = this.m_fxs[i];
				if (genericGraphic.IsDeleteMe)
				{
					this.m_fxs.RemoveAt(i);
					this.m_pool.Destroy(genericGraphic);
				}
				else
				{
					genericGraphic.Tick(dt);
					i++;
				}
			}
		}

		// Token: 0x0400629F RID: 25247
		private List<GenericGraphic> m_fxs = new List<GenericGraphic>();

		// Token: 0x040062A0 RID: 25248
		private GraphicPool m_pool;

		// Token: 0x040062A1 RID: 25249
		public GameObject m_parentGameObject;
	}
}
