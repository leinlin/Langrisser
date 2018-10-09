using System;
using ProtoBuf;

namespace BlackJack.LibClient
{
	// Token: 0x0200085F RID: 2143
	[ProtoContract(Name = "CCMSGConnectionFailure")]
	[Serializable]
	public class CCMSGConnectionFailure
	{
		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06006AE0 RID: 27360 RVA: 0x001DFC0C File Offset: 0x001DDE0C
		// (set) Token: 0x06006AE1 RID: 27361 RVA: 0x001DFC14 File Offset: 0x001DDE14
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

		// Token: 0x04005251 RID: 21073
		private int _MessageId = 9003;
	}
}
