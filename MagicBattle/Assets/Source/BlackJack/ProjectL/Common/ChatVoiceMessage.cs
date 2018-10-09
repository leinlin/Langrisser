using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200052C RID: 1324
	[CustomLuaClass]
	[Serializable]
	public class ChatVoiceMessage : ChatMessage
	{
		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06004EEA RID: 20202 RVA: 0x0017DE10 File Offset: 0x0017C010
		// (set) Token: 0x06004EEB RID: 20203 RVA: 0x0017DE18 File Offset: 0x0017C018
		public ulong InstanceId { get; set; }

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06004EEC RID: 20204 RVA: 0x0017DE24 File Offset: 0x0017C024
		// (set) Token: 0x06004EED RID: 20205 RVA: 0x0017DE2C File Offset: 0x0017C02C
		public byte[] VoiceData { get; set; }

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06004EEE RID: 20206 RVA: 0x0017DE38 File Offset: 0x0017C038
		// (set) Token: 0x06004EEF RID: 20207 RVA: 0x0017DE40 File Offset: 0x0017C040
		public int VoiceLength { get; set; }

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06004EF0 RID: 20208 RVA: 0x0017DE4C File Offset: 0x0017C04C
		// (set) Token: 0x06004EF1 RID: 20209 RVA: 0x0017DE54 File Offset: 0x0017C054
		public int AudioFrequency { get; set; }

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06004EF2 RID: 20210 RVA: 0x0017DE60 File Offset: 0x0017C060
		// (set) Token: 0x06004EF3 RID: 20211 RVA: 0x0017DE68 File Offset: 0x0017C068
		public int SampleLength { get; set; }

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06004EF4 RID: 20212 RVA: 0x0017DE74 File Offset: 0x0017C074
		// (set) Token: 0x06004EF5 RID: 20213 RVA: 0x0017DE7C File Offset: 0x0017C07C
		public bool IsOverdued { get; set; }

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x0017DE88 File Offset: 0x0017C088
		// (set) Token: 0x06004EF7 RID: 20215 RVA: 0x0017DE90 File Offset: 0x0017C090
		public string TranslateText { get; set; }
	}
}
