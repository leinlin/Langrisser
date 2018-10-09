using System;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200034E RID: 846
	[CustomLuaClass]
	public class RealTimePVPAvailableTime
	{
		// Token: 0x04002580 RID: 9600
		public TimeSpan Start = default(TimeSpan);

		// Token: 0x04002581 RID: 9601
		public TimeSpan End = new TimeSpan(864000000000L);
	}
}
