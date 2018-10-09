using System;
using System.Threading;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200011F RID: 287
	public static class ThreadSafeRandom
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00032E5C File Offset: 0x0003105C
		public static Random ThisThreadsRandom
		{
			get
			{
				Random result;
				if ((result = ThreadSafeRandom.m_local) == null)
				{
					result = (ThreadSafeRandom.m_local = new Random(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId));
				}
				return result;
			}
		}

		// Token: 0x04000701 RID: 1793
		[ThreadStatic]
		private static Random m_local;
	}
}
