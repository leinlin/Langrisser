using System;
using ProtoBuf;

namespace BlackJack.LibClient
{
	// Token: 0x0200085E RID: 2142
	[ProtoContract(Name = "CCMSGConnectionReady")]
	[Serializable]
	public class CCMSGConnectionReady
	{
		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06006ADD RID: 27357 RVA: 0x001DFBE4 File Offset: 0x001DDDE4
		// (set) Token: 0x06006ADE RID: 27358 RVA: 0x001DFBEC File Offset: 0x001DDDEC
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

		// Token: 0x04005250 RID: 21072
		private int _MessageId = 9001;
	}
}
