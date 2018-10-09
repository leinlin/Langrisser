using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200003E RID: 62
	[Serializable]
	public class SceneSettings
	{
		// Token: 0x04000145 RID: 325
		public bool UseOrthographicForUILayer;

		// Token: 0x04000146 RID: 326
		public int DesignScreenWidth = 1920;

		// Token: 0x04000147 RID: 327
		public int DesignScreenHeight = 1080;

		// Token: 0x04000148 RID: 328
		public int TrigerWidth2ShrinkScale;

		// Token: 0x04000149 RID: 329
		public int TrigerHeight2ShrinkScale;

		// Token: 0x0400014A RID: 330
		public Vector3 SceneLayerOffset = new Vector3(1000f, 0f, 0f);
	}
}
