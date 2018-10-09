using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200052A RID: 1322
	[CustomLuaClass]
	[Serializable]
	public class ChatEnterRoomMessage : ChatMessage
	{
		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06004EE0 RID: 20192 RVA: 0x0017DDB0 File Offset: 0x0017BFB0
		// (set) Token: 0x06004EE1 RID: 20193 RVA: 0x0017DDB8 File Offset: 0x0017BFB8
		public int RoomId { get; set; }

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06004EE2 RID: 20194 RVA: 0x0017DDC4 File Offset: 0x0017BFC4
		// (set) Token: 0x06004EE3 RID: 20195 RVA: 0x0017DDCC File Offset: 0x0017BFCC
		public int PlayerCount { get; set; }
	}
}
