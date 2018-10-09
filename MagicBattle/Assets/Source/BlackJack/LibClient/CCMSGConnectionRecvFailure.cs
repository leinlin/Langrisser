using System;
using ProtoBuf;

namespace BlackJack.LibClient
{
	// Token: 0x02000862 RID: 2146
	[ProtoContract(Name = "CCMSGConnectionRecvFailure")]
	[Serializable]
	public class CCMSGConnectionRecvFailure
	{
		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06006AEB RID: 27371 RVA: 0x001DFC98 File Offset: 0x001DDE98
		// (set) Token: 0x06006AEC RID: 27372 RVA: 0x001DFCA0 File Offset: 0x001DDEA0
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

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06006AED RID: 27373 RVA: 0x001DFCAC File Offset: 0x001DDEAC
		// (set) Token: 0x06006AEE RID: 27374 RVA: 0x001DFCB4 File Offset: 0x001DDEB4
		[ProtoMember(2, IsRequired = true, Name = "ExceptionInfo", DataFormat = DataFormat.Default)]
		public string ExceptionInfo { get; set; }

		// Token: 0x04005255 RID: 21077
		private int _MessageId = 9005;
	}
}
