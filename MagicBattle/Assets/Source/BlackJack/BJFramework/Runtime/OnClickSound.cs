using System;
using BlackJack.BJFramework.Runtime.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000024 RID: 36
	[CustomLuaClass]
	public class OnClickSound : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x0000D038 File Offset: 0x0000B238
		private void Start()
		{
			if (string.IsNullOrEmpty(this.m_clickSoundName))
			{
				global::Debug.LogError(string.Format("The OnClickSound at [{1}] has no click sound name.", this.m_clickSoundName, SceneManager.GetObjectPath(base.gameObject)));
				return;
			}
			Button component = base.gameObject.GetComponent<Button>();
			if (component != null)
			{
				component.onClick.AddListener(new UnityAction(this.OnButtonClick));
				return;
			}
			Toggle component2 = base.gameObject.GetComponent<Toggle>();
			if (component2 != null)
			{
				component2.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleValueChanged));
				return;
			}
			global::Debug.LogError(string.Format("The OnClickSound with [{0}] at [{1}] has no Button and no Toggle component.", this.m_clickSoundName, SceneManager.GetObjectPath(base.gameObject)));
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		private void OnButtonClick()
		{
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.PlaySound(this.m_clickSoundName, 1f);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000D130 File Offset: 0x0000B330
		private void OnToggleValueChanged(bool val)
		{
			if (!val)
			{
				return;
			}
			this.m_shouldLatePlay = true;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000D140 File Offset: 0x0000B340
		private void LateUpdate()
		{
			if (!this.m_shouldLatePlay)
			{
				return;
			}
			this.m_shouldLatePlay = false;
			if (!this.m_isClicked)
			{
				return;
			}
			this.m_isClicked = false;
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.PlaySound(this.m_clickSoundName, 1f);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		public void OnPointerClick(PointerEventData eventData)
		{
			this.m_isClicked = true;
		}

		// Token: 0x0400009C RID: 156
		public string m_clickSoundName = string.Empty;

		// Token: 0x0400009D RID: 157
		private bool m_isClicked;

		// Token: 0x0400009E RID: 158
		private bool m_shouldLatePlay;
	}
}
