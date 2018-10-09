using System;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000025 RID: 37
	[CustomLuaClass]
	public class OnHideSound : MonoBehaviour
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x0000D1C8 File Offset: 0x0000B3C8
		private void Start()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000D1CC File Offset: 0x0000B3CC
		private void OnDisable()
		{
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.PlaySound(this.m_soundName, 1f);
		}

		// Token: 0x0400009F RID: 159
		public string m_soundName = string.Empty;
	}
}
