using System;
using System.Collections.Generic;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000575 RID: 1397
	public class RingContainer<T>
	{
		// Token: 0x06005126 RID: 20774 RVA: 0x00182C0C File Offset: 0x00180E0C
		public RingContainer(int capacity)
		{
			this.m_buffer = new List<T>();
			this.m_capacity = capacity;
			this.m_nextIndex = 0;
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x00182C30 File Offset: 0x00180E30
		public T Add(T item)
		{
			if (this.m_buffer.Count == this.m_capacity)
			{
				this.m_buffer[this.m_nextIndex] = item;
			}
			else
			{
				this.m_buffer.Add(item);
			}
			this.m_nextIndex = (this.m_nextIndex + 1) % this.m_capacity;
			return item;
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x00182C8C File Offset: 0x00180E8C
		public T Get(int index)
		{
			if (index < 0 || index >= this.m_buffer.Count)
			{
				return default(T);
			}
			return this.m_buffer[index];
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x00182CC8 File Offset: 0x00180EC8
		public List<T> GetOrderItems()
		{
			List<T> list = new List<T>();
			int num = this.m_nextIndex;
			while (num < this.m_buffer.Count && num < this.m_capacity)
			{
				list.Add(this.m_buffer[num]);
				num++;
			}
			for (int i = 0; i < this.m_nextIndex; i++)
			{
				list.Add(this.m_buffer[i]);
			}
			return list;
		}

		// Token: 0x04003A64 RID: 14948
		private int m_nextIndex;

		// Token: 0x04003A65 RID: 14949
		private int m_capacity;

		// Token: 0x04003A66 RID: 14950
		private List<T> m_buffer;
	}
}
