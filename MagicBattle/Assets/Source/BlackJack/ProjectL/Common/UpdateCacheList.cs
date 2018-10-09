using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000581 RID: 1409
	public class UpdateCacheList<T> where T : class
	{
		// Token: 0x06005183 RID: 20867 RVA: 0x00183828 File Offset: 0x00181A28
		public UpdateCacheList()
		{
			this.Caches = new List<UpdateCache<T>>();
			this.m_freeIndices = new LinkedList<int>();
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x00183848 File Offset: 0x00181A48
		public int Init(T data)
		{
			int validCount = this.ValidCount;
			UpdateCache<T> cache = new UpdateCache<T>(data);
			return this.Add(cache, false);
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x0018386C File Offset: 0x00181A6C
		public int Add(T data)
		{
			UpdateCache<T> cache = new UpdateCache<T>(data);
			return this.Add(cache, true);
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x00183888 File Offset: 0x00181A88
		public int Add(UpdateCache<T> cache, bool dirty = true)
		{
			int num;
			if (this.m_freeIndices.Count == 0)
			{
				num = this.ValidCount;
				this.Caches.Add(cache);
			}
			else
			{
				num = this.m_freeIndices.First<int>();
				this.m_freeIndices.RemoveFirst();
				this.Caches[num] = cache;
			}
			cache.Dirty = dirty;
			return num;
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x001838EC File Offset: 0x00181AEC
		public bool Remove(int index)
		{
			if (!this.IsIndexValid(index))
			{
				return false;
			}
			UpdateCache<T> updateCache = this.Caches[index];
			if (!updateCache.IsValid())
			{
				return false;
			}
			this.Remove(updateCache, index);
			return true;
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x0018392C File Offset: 0x00181B2C
		public bool Set(int index, T data)
		{
			if (!this.IsIndexValid(index))
			{
				return false;
			}
			UpdateCache<T> updateCache = this.Find(index);
			updateCache.Data = data;
			updateCache.Dirty = true;
			return true;
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x00183960 File Offset: 0x00181B60
		private void Remove(UpdateCache<T> cache, int index)
		{
			cache.SetInvalid();
			this.m_freeIndices.AddFirst(index);
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x00183978 File Offset: 0x00181B78
		public UpdateCache<T> Find(int index)
		{
			if (!this.IsIndexValid(index))
			{
				return null;
			}
			return this.Caches[index];
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x00183994 File Offset: 0x00181B94
		public void Clear()
		{
			for (int i = 0; i < this.Caches.Count; i++)
			{
				UpdateCache<T> updateCache = this.Caches[i];
				if (updateCache.IsValid())
				{
					this.Remove(updateCache, i);
				}
			}
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x001839E0 File Offset: 0x00181BE0
		public List<T> GetAllVaildDatas()
		{
			List<T> list = new List<T>();
			foreach (UpdateCache<T> updateCache in this.Caches)
			{
				if (updateCache.IsValid())
				{
					list.Add(updateCache.Data);
				}
			}
			return list;
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x00183A54 File Offset: 0x00181C54
		public IEnumerable<T> IterateAllBagItems()
		{
			foreach (UpdateCache<T> cache in this.Caches)
			{
				if (cache.IsValid())
				{
					yield return cache.Data;
				}
			}
			yield break;
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x00183A78 File Offset: 0x00181C78
		public List<UpdateCache<T>> GetAllVaildCaches()
		{
			List<UpdateCache<T>> list = new List<UpdateCache<T>>();
			foreach (UpdateCache<T> updateCache in this.Caches)
			{
				if (updateCache.IsValid())
				{
					list.Add(updateCache);
				}
			}
			return list;
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x00183AE8 File Offset: 0x00181CE8
		public List<UpdateCache<T>> GetAllDirtyCaches()
		{
			List<UpdateCache<T>> list = new List<UpdateCache<T>>();
			foreach (UpdateCache<T> updateCache in this.Caches)
			{
				if (updateCache.Dirty)
				{
					list.Add(updateCache);
				}
			}
			return list;
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x00183B58 File Offset: 0x00181D58
		public int Count
		{
			get
			{
				return this.Caches.Count;
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06005191 RID: 20881 RVA: 0x00183B68 File Offset: 0x00181D68
		public int ValidCount
		{
			get
			{
				return this.Caches.Count - this.m_freeIndices.Count;
			}
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x00183B84 File Offset: 0x00181D84
		private bool IsIndexValid(int index)
		{
			return index >= 0 && index < this.Caches.Count;
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06005193 RID: 20883 RVA: 0x00183BA0 File Offset: 0x00181DA0
		// (set) Token: 0x06005194 RID: 20884 RVA: 0x00183BA8 File Offset: 0x00181DA8
		public List<UpdateCache<T>> Caches { get; set; }

		// Token: 0x04003A8A RID: 14986
		private LinkedList<int> m_freeIndices;
	}
}
