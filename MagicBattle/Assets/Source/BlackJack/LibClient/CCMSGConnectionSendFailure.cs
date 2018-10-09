using System;
using ProtoBuf;

namespace BlackJack.LibClient
{
	// Token: 0x02000861 RID: 2145
	[ProtoContract(Name = "CCMSGConnectionSendFailure")]
	[Serializable]
	public class CCMSGConnectionSendFailure
	{
		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06006AE6 RID: 27366 RVA: 0x001DFC5C File Offset: 0x001DDE5C
		// (set) Token: 0x06006AE7 RID: 27367 RVA: 0x001DFC64 File Offset: 0x001DDE64
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

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06006AE8 RID: 27368 RVA: 0x001DFC70 File Offset: 0x001DDE70
		// (set) Token: 0x06006AE9 RID: 27369 RVA: 0x001DFC78 File Offset: 0x001DDE78
		[ProtoMember(2, IsRequired = true, Name = "ExceptionInfo", DataFormat = DataFormat.Default)]
		public string ExceptionInfo { get; set; }

		// Token: 0x04005253 RID: 21075
		private int _MessageId = 9004;
	}
}
