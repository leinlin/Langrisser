using System;
using System.Collections.Generic;

namespace BlackJack.BJFramework.Runtime.Prefab
{
	// Token: 0x02000075 RID: 117
	public class PrefabControllerNextUpdateExecutor
	{
		// Token: 0x0600056A RID: 1386 RVA: 0x00017FC4 File Offset: 0x000161C4
		public void AddNextUpdateExecution(Action action)
		{
			this.m_nextUpdateExecutionList.Add(action);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00017FD4 File Offset: 0x000161D4
		public void Tick()
		{
			if (this.m_nextUpdateExecutionList.Count == 0)
			{
				return;
			}
			List<Action> list = new List<Action>();
			list.AddRange(this.m_nextUpdateExecutionList);
			this.m_nextUpdateExecutionList.Clear();
			foreach (Action action in list)
			{
				if (action != null)
				{
					action();
				}
			}
		}

		// Token: 0x040002A9 RID: 681
		private List<Action> m_nextUpdateExecutionList = new List<Action>();
	}
}
