using System;
using ProtoBuf;

namespace BlackJack.LibClient
{
	// Token: 0x02000860 RID: 2144
	[ProtoContract(Name = "CCMSGConnectionBreak")]
	[Serializable]
	public class CCMSGConnectionBreak
	{
		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06006AE3 RID: 27363 RVA: 0x001DFC34 File Offset: 0x001DDE34
		// (set) Token: 0x06006AE4 RID: 27364 RVA: 0x001DFC3C File Offset: 0x001DDE3C
		[ProtoMember(1, IsRequired = true, Name = "MessageId", DataFormat = DataFormat.Default)]
		public int MessageId
		{
			get
			{
				return this._MessageId;
			}
			set
			{
				this._MessageId = value;
			}
		}

		// Token: 0x04005252 RID: 21074
		private int _MessageId = 9002;
	}
}
