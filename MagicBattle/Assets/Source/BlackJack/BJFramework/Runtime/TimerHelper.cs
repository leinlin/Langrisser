using System;
using System.Collections.Generic;
using System.Globalization;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x020000D6 RID: 214
	public class TimerHelper
	{
		// Token: 0x06000847 RID: 2119 RVA: 0x000249C0 File Offset: 0x00022BC0
		public static void Start(string msg, bool isLargeThanFixedTime = false)
		{
			DateTime now = DateTime.Now;
			TimerHelper.m_timeStack.Push(now);
			if (!isLargeThanFixedTime)
			{
				Debug.Log(msg + now.ToString("yyyy/MM/dd/HH/mm/ss/fff", DateTimeFormatInfo.InvariantInfo));
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00024A08 File Offset: 0x00022C08
		public static void Stop(string msg, bool isLargeThanFixedTime = false)
		{
			DateTime d = TimerHelper.m_timeStack.Pop();
			DateTime now = DateTime.Now;
			double totalMilliseconds = (now - d).TotalMilliseconds;
			if (isLargeThanFixedTime)
			{
				if (totalMilliseconds >= 300.0)
				{
					Debug.Log(string.Format("{0} endtime:{1}  timespan{2}", msg, now.ToString("yyyy/MM/dd/HH/mm/ss/fff", DateTimeFormatInfo.InvariantInfo), totalMilliseconds));
				}
			}
			else
			{
				Debug.Log(string.Format("{0} endtime:{1}  timespan{2}", msg, now.ToString("yyyy/MM/dd/HH/mm/ss/fff", DateTimeFormatInfo.InvariantInfo), totalMilliseconds));
			}
		}

		// Token: 0x04000532 RID: 1330
		protected static Stack<DateTime> m_timeStack = new Stack<DateTime>();
	}
}
