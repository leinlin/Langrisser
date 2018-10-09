using System;
using SLua;

namespace BlackJack.ProjectL.LibClient
{
	// Token: 0x020005AA RID: 1450
	[CustomLuaClass]
	public class SessionToken
	{
		// Token: 0x0600527E RID: 21118 RVA: 0x001873DC File Offset: 0x001855DC
		public static SessionToken GetSessionObject(string sessionToken)
		{
			SessionToken sessionToken2 = new SessionToken();
			if (sessionToken == null)
			{
				return null;
			}
			string[] array = sessionToken.Split(new char[]
			{
				'|'
			});
			if (array.Length < 6)
			{
				return null;
			}
			sessionToken2.AuthId = array[3];
			sessionToken2.ServerAddress = array[0];
			sessionToken2.ServerPort = int.Parse(array[1]);
			if (sessionToken2.ServerPort < 1 || sessionToken2.ServerPort > 65535)
			{
				return null;
			}
			string[] array2 = array[4].Split(new char[]
			{
				'-'
			});
			if (array2.Length != 5)
			{
				return null;
			}
			int year = int.Parse(array2[0]);
			int month = int.Parse(array2[1]);
			int day = int.Parse(array2[2]);
			int hour = int.Parse(array2[3]);
			int minute = int.Parse(array2[4]);
			sessionToken2.TimeStamp = new DateTime(year, month, day, hour, minute, 0);
			sessionToken2.SessionTokenOriginal = sessionToken;
			return sessionToken2;
		}

		// Token: 0x04003DE9 RID: 15849
		public string AuthId;

		// Token: 0x04003DEA RID: 15850
		public string ServerAddress;

		// Token: 0x04003DEB RID: 15851
		public int ServerPort;

		// Token: 0x04003DEC RID: 15852
		public DateTime TimeStamp = DateTime.MinValue;

		// Token: 0x04003DED RID: 15853
		public string SessionTokenOriginal;
	}
}
