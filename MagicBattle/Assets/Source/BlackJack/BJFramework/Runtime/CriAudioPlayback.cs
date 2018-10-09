using System;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x020010F1 RID: 4337
	internal class CriAudioPlayback : IAudioPlayback
	{
		// Token: 0x060159C4 RID: 88516 RVA: 0x005805D8 File Offset: 0x0057E7D8
		public CriAudioPlayback(CriAtomExPlayback playback, string cueName)
		{
			this.m_playback = playback;
			this.m_cueName = cueName;
		}

		// Token: 0x060159C5 RID: 88517 RVA: 0x005805F0 File Offset: 0x0057E7F0
		public void Stop()
		{
			this.m_playback.Stop();
		}

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x060159C6 RID: 88518 RVA: 0x00580600 File Offset: 0x0057E800
		public string CueName
		{
			get
			{
				return this.m_cueName;
			}
		}

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x060159C7 RID: 88519 RVA: 0x00580608 File Offset: 0x0057E808
		public float Seconds
		{
			get
			{
				return AudioManager4CRI.Instance.GetCueLength(this.m_cueName);
			}
		}

		// Token: 0x060159C8 RID: 88520 RVA: 0x0058061C File Offset: 0x0057E81C
		public bool IsStoped()
		{
			return this.m_playback.status == CriAtomExPlayback.Status.Removed;
		}

		// Token: 0x0400BCD9 RID: 48345
		private CriAtomExPlayback m_playback;

		// Token: 0x0400BCDA RID: 48346
		private string m_cueName;
	}
}
