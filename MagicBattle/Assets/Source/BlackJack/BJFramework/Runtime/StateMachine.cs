using System;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x020000C4 RID: 196
	public class StateMachine
	{
		// Token: 0x06000702 RID: 1794 RVA: 0x00020BBC File Offset: 0x0001EDBC
		public virtual int SetStateCheck(int commingEvent, int newState = -1, bool testOnly = false)
		{
			this.State = newState;
			return this.State;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00020BCC File Offset: 0x0001EDCC
		public virtual void SetStateWithoutCheck(int newState)
		{
			this.State = newState;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00020BD8 File Offset: 0x0001EDD8
		public virtual bool EventCheck(int commingEvent)
		{
			return this.SetStateCheck(commingEvent, -1, true) != -1;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00020BEC File Offset: 0x0001EDEC
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00020BF4 File Offset: 0x0001EDF4
		public int State { get; protected set; }
	}
}
