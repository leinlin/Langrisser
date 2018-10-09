using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000583 RID: 1411
	[CustomLuaClass]
	public class DebugUtility
	{
		// Token: 0x0600519E RID: 20894 RVA: 0x00183D64 File Offset: 0x00181F64
		public static void Log(object obj)
		{
			Debug.Log("[D] " + obj);
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x00183D78 File Offset: 0x00181F78
		public static void LogWarning(object obj)
		{
			Debug.LogWarning("[W] " + obj);
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x00183D8C File Offset: 0x00181F8C
		public static void LogError(object obj)
		{
			Debug.LogError("[E] " + obj);
		}
	}
}
