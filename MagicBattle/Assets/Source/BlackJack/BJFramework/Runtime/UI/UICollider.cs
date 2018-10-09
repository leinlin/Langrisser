using System;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000EC RID: 236
	[AddComponentMenu("UIExtend/UICollider", 16)]
	public class UICollider : Graphic
	{
		// Token: 0x060008C3 RID: 2243 RVA: 0x00026B08 File Offset: 0x00024D08
		public override bool Raycast(Vector2 sp, Camera eventCamera)
		{
			return true;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00026B0C File Offset: 0x00024D0C
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			vh.Clear();
		}
	}
}
