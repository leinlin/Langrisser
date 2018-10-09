using System;
using BlackJack.BJFramework.Runtime.Scene;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000026 RID: 38
	[CustomLuaClass]
	public class OnImageFillAmmountSound : MonoBehaviour
	{
		// Token: 0x060002BA RID: 698 RVA: 0x0000D218 File Offset: 0x0000B418
		private void Start()
		{
			if (string.IsNullOrEmpty(this.m_fillSoundName))
			{
				global::Debug.LogError(string.Format("The OnImageFillAmmountSound at [{1}] has no click sound name.", this.m_fillSoundName, SceneManager.GetObjectPath(base.gameObject)));
				return;
			}
			this.m_image = base.gameObject.GetComponent<Image>();
			if (this.m_image == null)
			{
				global::Debug.LogError(string.Format("The OnImageFillAmmountSound with [{0}] at [{1}] has no Image component.", this.m_fillSoundName, SceneManager.GetObjectPath(base.gameObject)));
				return;
			}
			if (this.m_image.type != Image.Type.Filled)
			{
				this.m_image = null;
				global::Debug.LogError(string.Format("The OnImageFillAmmountSound with [{0}] at [{1}] has no Image which type is [Filled].", this.m_fillSoundName, SceneManager.GetObjectPath(base.gameObject)));
				return;
			}
			this.m_lastFillAmmount = this.m_image.fillAmount;
			this.m_fillAmmountValue = Math.Max(0.0001f, this.m_fillAmmountValue);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000D2FC File Offset: 0x0000B4FC
		private void OnEnable()
		{
			this.m_lastFillAmmount = this.m_image.fillAmount;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000D310 File Offset: 0x0000B510
		private void Update()
		{
			if (this.m_image == null)
			{
				return;
			}
			if (this.m_image.fillAmount == this.m_lastFillAmmount)
			{
				return;
			}
			if ((this.m_image.fillAmount - this.m_fillAmmountValue) * (this.m_lastFillAmmount - this.m_fillAmmountValue) < 0f && GameManager.Instance != null && GameManager.Instance.AudioManager != null)
			{
				GameManager.Instance.AudioManager.PlaySound(this.m_fillSoundName, 1f);
			}
			this.m_lastFillAmmount = this.m_image.fillAmount;
		}

		// Token: 0x040000A0 RID: 160
		public string m_fillSoundName = string.Empty;

		// Token: 0x040000A1 RID: 161
		public float m_fillAmmountValue;

		// Token: 0x040000A2 RID: 162
		private Image m_image;

		// Token: 0x040000A3 RID: 163
		private float m_lastFillAmmount;
	}
}
