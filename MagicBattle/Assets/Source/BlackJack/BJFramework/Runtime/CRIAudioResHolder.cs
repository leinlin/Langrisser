using System;
using System.Collections;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200001D RID: 29
	[AddComponentMenu("CRIWARE/BlackJack/CRI Audio Res Holder")]
	public class CRIAudioResHolder : MonoBehaviour
	{
		// Token: 0x06000280 RID: 640 RVA: 0x0000CF14 File Offset: 0x0000B114
		public void Play()
		{
			base.StartCoroutine(this.PlayWithDelay());
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000CF24 File Offset: 0x0000B124
		private IEnumerator PlayWithDelay()
		{
			if (this.DelayTime > 0f)
			{
				yield return new WaitForSeconds(this.DelayTime);
			}
			GameManager.Instance.AudioManager.PlaySound(this.m_criCueName, 1f);
			yield break;
		}

		// Token: 0x04000091 RID: 145
		[Header("播放延时")]
		public float DelayTime;

		// Token: 0x04000092 RID: 146
		public string m_criCueName = string.Empty;
	}
}
