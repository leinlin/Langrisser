using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000E4 RID: 228
	[Serializable]
	public class UIStateDesc
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0002628C File Offset: 0x0002448C
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00026294 File Offset: 0x00024494
		[HideInInspector]
		public bool AnimationFinished
		{
			get
			{
				return this.m_isAnimationFinished;
			}
			set
			{
				if (this.m_isAnimationFinished == value)
				{
					return;
				}
				this.m_isAnimationFinished = value;
				if (this.m_eventFinished != null && this.m_isAnimationFinished && this.m_isTweenFinished)
				{
					this.m_eventFinished();
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x000262E4 File Offset: 0x000244E4
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x000262EC File Offset: 0x000244EC
		[HideInInspector]
		public bool TweenFinished
		{
			get
			{
				return this.m_isTweenFinished;
			}
			set
			{
				if (this.m_isTweenFinished == value)
				{
					return;
				}
				this.m_isTweenFinished = value;
				if (this.m_eventFinished != null && this.m_isAnimationFinished && this.m_isTweenFinished)
				{
					this.m_eventFinished();
				}
			}
		}

		// Token: 0x0400056C RID: 1388
		public string StateName;

		// Token: 0x0400056D RID: 1389
		public int StateColorSetIndex = -1;

		// Token: 0x0400056E RID: 1390
		public List<GameObject> SetToShowGameObjectList = new List<GameObject>();

		// Token: 0x0400056F RID: 1391
		public List<TweenMain> TweenAnimationList = new List<TweenMain>();

		// Token: 0x04000570 RID: 1392
		[HideInInspector]
		private bool m_isTweenFinished;

		// Token: 0x04000571 RID: 1393
		[HideInInspector]
		private bool m_isAnimationFinished;

		// Token: 0x04000572 RID: 1394
		[HideInInspector]
		public Action m_eventFinished;
	}
}
