using System;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000E8 RID: 232
	[AddComponentMenu("UI/Effects/Gradient")]
	public class Gradient : BaseMeshEffect
	{
		// Token: 0x060008A9 RID: 2217 RVA: 0x0002639C File Offset: 0x0002459C
		public override void ModifyMesh(VertexHelper vh)
		{
			if (!this.IsActive())
			{
				return;
			}
			UIVertex simpleVert = UIVertex.simpleVert;
			float num = float.MaxValue;
			float num2 = float.MinValue;
			for (int i = 0; i < vh.currentVertCount; i++)
			{
				vh.PopulateUIVertex(ref simpleVert, i);
				float b = (this.m_gradientDir != GradientDirection.Vertical) ? simpleVert.position.x : simpleVert.position.y;
				num = Mathf.Min(num, b);
				num2 = Mathf.Max(num2, b);
			}
			float num3 = num2 - num;
			if (num3 > 0f)
			{
				for (int j = 0; j < vh.currentVertCount; j++)
				{
					vh.PopulateUIVertex(ref simpleVert, j);
					simpleVert.color *= Color.Lerp(this.m_color2, this.m_color1, (((this.m_gradientDir != GradientDirection.Vertical) ? simpleVert.position.x : simpleVert.position.y) - num) / num3);
					vh.SetUIVertex(simpleVert, j);
				}
			}
		}

		// Token: 0x0400057B RID: 1403
		public GradientDirection m_gradientDir;

		// Token: 0x0400057C RID: 1404
		public Color m_color1 = Color.white;

		// Token: 0x0400057D RID: 1405
		public Color m_color2 = Color.black;
	}
}
