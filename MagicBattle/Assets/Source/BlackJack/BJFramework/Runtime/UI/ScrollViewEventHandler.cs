using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000E9 RID: 233
	[AddComponentMenu("UIExtend/ScrollViewEventHandler", 16)]
	public class ScrollViewEventHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		// Token: 0x060008AB RID: 2219 RVA: 0x000264C4 File Offset: 0x000246C4
		public void OnPointerDown(PointerEventData eventData)
		{
			if (this.EventOnScrollViewClick != null)
			{
				this.EventOnScrollViewClick();
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x060008AC RID: 2220 RVA: 0x000264DC File Offset: 0x000246DC
		// (remove) Token: 0x060008AD RID: 2221 RVA: 0x00026514 File Offset: 0x00024714
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action EventOnScrollViewClick;
	}
}
