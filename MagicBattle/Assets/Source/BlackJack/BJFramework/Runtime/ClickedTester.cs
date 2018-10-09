using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200001C RID: 28
	public class ClickedTester : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000CED8 File Offset: 0x0000B0D8
		public bool Clicked
		{
			get
			{
				bool isClicked = this.m_isClicked;
				this.m_isClicked = false;
				return isClicked;
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000CEF4 File Offset: 0x0000B0F4
		public void OnPointerClick(PointerEventData eventData)
		{
			this.m_isClicked = true;
		}

		// Token: 0x04000090 RID: 144
		private bool m_isClicked;
	}
}
