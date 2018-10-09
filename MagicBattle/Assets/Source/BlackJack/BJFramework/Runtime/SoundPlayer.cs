using System;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200002A RID: 42
	[CustomLuaClass]
	public class SoundPlayer : MonoBehaviour
	{
		// Token: 0x060002CB RID: 715 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		public void PlaySound(string soundName)
		{
			this.m_soundName = soundName;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000D6EC File Offset: 0x0000B8EC
		private void LateUpdate()
		{
			if (string.IsNullOrEmpty(this.m_soundName))
			{
				return;
			}
			string soundName = this.m_soundName;
			this.m_soundName = string.Empty;
			if (this.m_clickedTester != null && !this.m_clickedTester.Clicked)
			{
				return;
			}
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.PlaySound(soundName, 1f);
		}

		// Token: 0x040000B2 RID: 178
		public ClickedTester m_clickedTester;

		// Token: 0x040000B3 RID: 179
		private string m_soundName;
	}
}
