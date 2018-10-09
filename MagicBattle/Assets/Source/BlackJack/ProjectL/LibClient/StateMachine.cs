using System;
using SLua;

namespace BlackJack.ProjectL.LibClient
{
	// Token: 0x020005AD RID: 1453
	[CustomLuaClass]
	public class StateMachine
	{
		// Token: 0x06005288 RID: 21128 RVA: 0x00187714 File Offset: 0x00185914
		public virtual int SetStateCheck(int commingEvent, int newState = -1, bool testOnly = false)
		{
			this.State = newState;
			return this.State;
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x00187724 File Offset: 0x00185924
		public virtual void SetStateWithoutCheck(int newState)
		{
			this.State = newState;
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00187730 File Offset: 0x00185930
		public virtual bool EventCheck(int commingEvent)
		{
			return this.SetStateCheck(commingEvent, -1, true) != -1;
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x00187744 File Offset: 0x00185944
		// (set) Token: 0x0600528C RID: 21132 RVA: 0x0018774C File Offset: 0x0018594C
		public int State { get; protected set; }
	}
}
