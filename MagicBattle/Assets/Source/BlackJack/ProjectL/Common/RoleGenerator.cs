using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000427 RID: 1063
	[CustomLuaClass]
	public class RoleGenerator
	{
		// Token: 0x06003D59 RID: 15705 RVA: 0x00114EC4 File Offset: 0x001130C4
		public static int GetBornChannelIdFromUserId(string userId)
		{
			ulong num;
			if (!ulong.TryParse(userId, out num))
			{
				return 0;
			}
			return (int)(num >> 49);
		}
	}
}
