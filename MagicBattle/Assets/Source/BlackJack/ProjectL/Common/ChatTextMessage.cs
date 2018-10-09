using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200052B RID: 1323
	[CustomLuaClass]
	[Serializable]
	public class ChatTextMessage : ChatMessage
	{
		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06004EE5 RID: 20197 RVA: 0x0017DDE0 File Offset: 0x0017BFE0
		// (set) Token: 0x06004EE6 RID: 20198 RVA: 0x0017DDE8 File Offset: 0x0017BFE8
		public string Text { get; set; }

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06004EE7 RID: 20199 RVA: 0x0017DDF4 File Offset: 0x0017BFF4
		// (set) Token: 0x06004EE8 RID: 20200 RVA: 0x0017DDFC File Offset: 0x0017BFFC
		public int SystemContentTemplateId { get; set; }
	}
}
