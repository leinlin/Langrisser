using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000E5 RID: 229
	[Serializable]
	public class UIStateColorDesc
	{
		// Token: 0x04000573 RID: 1395
		public Color TargetColor = Color.white;

		// Token: 0x04000574 RID: 1396
		public GameObject ChangeColorGo;

		// Token: 0x04000575 RID: 1397
		[HideInInspector]
		public List<Image> ChangeColorImageList = new List<Image>();

		// Token: 0x04000576 RID: 1398
		[HideInInspector]
		public List<Text> ChangeColorTextList = new List<Text>();
	}
}
