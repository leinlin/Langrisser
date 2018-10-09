using System;
using System.Collections.Generic;

namespace BlackJack.Utils
{
	// Token: 0x020000D9 RID: 217
	public class DelayExecHelper
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x00024CB8 File Offset: 0x00022EB8
		public DelayExecHelper.IDelayExecItem DelayExec(Action action, int delayTime, uint currTime)
		{
			if (delayTime <= 0)
			{
				action();
				return null;
			}
			uint execTime = (uint)((ulong)currTime + (ulong)((long)delayTime));
			DelayExecHelper.DelayExecItem delayExecItem = new DelayExecHelper.DelayExecItem
			{
				m_action = action,
				m_execTime = execTime
			};
			this.DelayExec(execTime, delayExecItem);
			return delayExecItem;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00024CFC File Offset: 0x00022EFC
		private void DelayExec(uint execTime, DelayExecHelper.DelayExecItem item)
		{
			bool flag = false;
			for (int i = 0; i < this.m_delayExecList.Count; i++)
			{
				DelayExecHelper.DelayExecItem delayExecItem = this.m_delayExecList[i];
				if (delayExecItem.m_execTime > execTime)
				{
					flag = true;
					this.m_delayExecList.Insert(i, item);
					break;
				}
			}
			if (!flag)
			{
				this.m_delayExecList.Add(item);
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00024D68 File Offset: 0x00022F68
		public void Tick(uint currTime)
		{
			for (int i = 0; i < this.m_delayExecList.Count; i++)
			{
				DelayExecHelper.DelayExecItem delayExecItem = this.m_delayExecList[i];
				if (delayExecItem.m_execTime >= currTime)
				{
					break;
				}
				this.m_delayExecList.Remove(delayExecItem);
				i--;
				delayExecItem.m_action();
				if (delayExecItem.m_continueItem != null)
				{
					this.DelayExec(delayExecItem.m_continueItem.m_execTime, delayExecItem.m_continueItem);
				}
			}
		}

		// Token: 0x0400053B RID: 1339
		private List<DelayExecHelper.DelayExecItem> m_delayExecList = new List<DelayExecHelper.DelayExecItem>();

		// Token: 0x020000DA RID: 218
		public interface IDelayExecItem
		{
			// Token: 0x0600085C RID: 2140
			DelayExecHelper.IDelayExecItem ContinueWith(Action action, int delayTime);
		}

		// Token: 0x020000DB RID: 219
		private class DelayExecItem : DelayExecHelper.IDelayExecItem
		{
			// Token: 0x0600085E RID: 2142 RVA: 0x00024DFC File Offset: 0x00022FFC
			DelayExecHelper.IDelayExecItem DelayExecHelper.IDelayExecItem.ContinueWith(Action action, int delayTime)
			{
				this.m_continueItem = new DelayExecHelper.DelayExecItem
				{
					m_action = action,
					m_execTime = this.m_execTime + (uint)delayTime
				};
				return this.m_continueItem;
			}

			// Token: 0x0400053C RID: 1340
			public Action m_action;

			// Token: 0x0400053D RID: 1341
			public uint m_execTime;

			// Token: 0x0400053E RID: 1342
			public DelayExecHelper.DelayExecItem m_continueItem;
		}
	}
}
