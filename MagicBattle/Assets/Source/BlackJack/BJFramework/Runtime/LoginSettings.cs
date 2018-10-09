using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public class LoginSettings
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000109E0 File Offset: 0x0000EBE0
		public int BasicVersion
		{
			get
			{
				if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.OSXEditor)
				{
					return this.IOSBasicVersion;
				}
				return this.AndroidBasicVersion;
			}
		}

		// Token: 0x04000168 RID: 360
		public bool LoginUseSDK;

		// Token: 0x04000169 RID: 361
		public bool LoginUseSettings = true;

		// Token: 0x0400016A RID: 362
		public string GameServerAddress = "192.168.1.111";

		// Token: 0x0400016B RID: 363
		public int GameServerPort = 16001;

		// Token: 0x0400016C RID: 364
		public string LoginAccount = "testUser1";

		// Token: 0x0400016D RID: 365
		public string ClientVersion = string.Empty;

		// Token: 0x0400016E RID: 366
		public int AndroidBasicVersion = 1;

		// Token: 0x0400016F RID: 367
		public int IOSBasicVersion = 1;
	}
}
