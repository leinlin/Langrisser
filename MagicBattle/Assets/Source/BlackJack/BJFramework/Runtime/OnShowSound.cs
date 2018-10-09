using System;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000027 RID: 39
	[CustomLuaClass]
	public class OnShowSound : MonoBehaviour
	{
		// Token: 0x060002BE RID: 702 RVA: 0x0000D3CC File Offset: 0x0000B5CC
		private void OnEnable()
		{
			if (!this.m_isStarted)
			{
				return;
			}
			if (string.IsNullOrEmpty(this.m_soundName))
			{
				return;
			}
			if (this.m_clickedTester != null && !this.m_clickedTester.Clicked)
			{
				return;
			}
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.PlaySound(this.m_soundName, 1f);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000D450 File Offset: 0x0000B650
		private void Start()
		{
			this.m_isStarted = true;
			if (this.m_clickedTester != null && !this.m_clickedTester.Clicked)
			{
				return;
			}
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.PlaySound(this.m_soundName, 1f);
		}

		// Token: 0x040000A4 RID: 164
		public ClickedTester m_clickedTester;

		// Token: 0x040000A5 RID: 165
		public string m_soundName = string.Empty;

		// Token: 0x040000A6 RID: 166
		private bool m_isStarted;
	}
}
