using System;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000022 RID: 34
	public interface IAudioPlayback
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060002A2 RID: 674
		float Seconds { get; }

		// Token: 0x060002A3 RID: 675
		bool IsStoped();

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060002A4 RID: 676
		string CueName { get; }

		// Token: 0x060002A5 RID: 677
		void Stop();
	}
}
