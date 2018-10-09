using System;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x0200011A RID: 282
	public class UITaskPipeLineCtx
	{
		// Token: 0x06000BC4 RID: 3012 RVA: 0x000322C4 File Offset: 0x000304C4
		public virtual void Clear()
		{
			this.m_isInitPipeLine = false;
			this.m_layerLoadedInPipe = false;
			this.m_isTaskResume = false;
			this.m_redirectPipLineOnAllResReady = null;
			this.m_updateMask = 0UL;
			this.m_isRuning = false;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000322F4 File Offset: 0x000304F4
		public void SetUpdateMask(ulong mask)
		{
			this.m_updateMask = mask;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00032300 File Offset: 0x00030500
		public void SetUpdateMask(params int[] indexs)
		{
			this.m_updateMask = 0UL;
			foreach (int num in indexs)
			{
				if (num < 64)
				{
					this.m_updateMask |= 1UL << num;
				}
			}
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0003234C File Offset: 0x0003054C
		public void AddUpdateMask(int index)
		{
			if (index < 64)
			{
				this.m_updateMask |= 1UL << index;
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0003236C File Offset: 0x0003056C
		public void ClearUpdateMask(int index)
		{
			if (index < 64)
			{
				this.m_updateMask &= (ulong)(~(1L << (index & 31)));
			}
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0003238C File Offset: 0x0003058C
		public bool IsNeedUpdate(int index)
		{
			return index < 64 && (this.m_updateMask & 1UL << index) != 0UL;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000323B0 File Offset: 0x000305B0
		public bool IsUpdateMaskClear()
		{
			return this.m_updateMask == 0UL;
		}

		// Token: 0x040006E8 RID: 1768
		public bool m_isInitPipeLine = true;

		// Token: 0x040006E9 RID: 1769
		public bool m_isTaskResume;

		// Token: 0x040006EA RID: 1770
		public bool m_isRuning;

		// Token: 0x040006EB RID: 1771
		public bool m_layerLoadedInPipe;

		// Token: 0x040006EC RID: 1772
		public bool m_blockGlobalUIInput = true;

		// Token: 0x040006ED RID: 1773
		public Action m_redirectPipLineOnAllResReady;

		// Token: 0x040006EE RID: 1774
		protected ulong m_updateMask;
	}
}
