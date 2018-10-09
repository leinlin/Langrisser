using System;
using System.Collections.Generic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x0200086D RID: 2157
	[CustomLuaClass]
	public class LruAssetCache
	{
		// Token: 0x06006B2E RID: 27438 RVA: 0x001E130C File Offset: 0x001DF50C
		public LruAssetCache(int cacheType, int maxCount)
		{
			this.m_cacheType = cacheType;
			this.m_maxCount = maxCount;
		}

		// Token: 0x06006B2F RID: 27439 RVA: 0x001E1330 File Offset: 0x001DF530
		public int GetCacheType()
		{
			return this.m_cacheType;
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x001E1338 File Offset: 0x001DF538
		public int GetMaxCount()
		{
			return this.m_maxCount;
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x001E1340 File Offset: 0x001DF540
		public void Add(UnityEngine.Object a)
		{
			if (a == null)
			{
				return;
			}
			LinkedListNode<UnityEngine.Object> linkedListNode = this.m_assets.Find(a);
			if (linkedListNode != null)
			{
				this.m_assets.Remove(linkedListNode);
				this.m_assets.AddLast(linkedListNode);
				return;
			}
			if (this.m_maxCount > 0)
			{
				while (this.m_assets.Count >= this.m_maxCount)
				{
					this.m_assets.RemoveFirst();
				}
			}
			this.m_assets.AddLast(a);
		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x001E13C8 File Offset: 0x001DF5C8
		public void Clear()
		{
			this.m_assets.Clear();
		}

		// Token: 0x0400527C RID: 21116
		private int m_maxCount;

		// Token: 0x0400527D RID: 21117
		private int m_cacheType;

		// Token: 0x0400527E RID: 21118
		private LinkedList<UnityEngine.Object> m_assets = new LinkedList<UnityEngine.Object>();
	}
}
