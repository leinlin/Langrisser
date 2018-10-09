using System;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000EE RID: 238
	[AddComponentMenu("UIExtend/UIRadarChart", 16)]
	public class UIRadarChart : MaskableGraphic
	{
		// Token: 0x060008CA RID: 2250 RVA: 0x00026BC8 File Offset: 0x00024DC8
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			Vector2 size = base.GetComponent<RectTransform>().rect.size / 2f;
			vh.Clear();
			int num = this.values.Length;
			for (int i = 0; i < num; i++)
			{
				Vector2 vector = this.GetPoint(size, i) * this.values[i];
				Vector2 vector2 = (!this.isFill) ? (vector * this.fillPercent) : Vector2.zero;
				Vector2 vector3 = (i + 1 < num) ? (this.GetPoint(size, i + 1) * this.values[i + 1]) : (this.GetPoint(size, 0) * this.values[0]);
				Vector2 vector4 = (!this.isFill) ? (vector3 * this.fillPercent) : Vector2.zero;
				vh.AddUIVertexQuad(this.GetQuad(new Vector2[]
				{
					vector,
					vector2,
					vector4,
					vector3
				}));
				if (this.useStateLine)
				{
					if (i != 0)
					{
						Vector2 end = this.GetPoint(size, i) * this.lineLength;
						Vector2 zero = Vector2.zero;
						vh.AddUIVertexQuad(this.GetLine(zero, end));
					}
					if (i + 1 == num)
					{
						Vector2 end2 = this.GetPoint(size, 0) * this.lineLength;
						Vector2 zero2 = Vector2.zero;
						vh.AddUIVertexQuad(this.GetLine(zero2, end2));
					}
				}
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00026D70 File Offset: 0x00024F70
		private UIVertex[] GetLine(Vector2 start, Vector2 end)
		{
			UIVertex[] array = new UIVertex[4];
			Vector2[] array2 = new Vector2[]
			{
				new Vector2(0f, 0f),
				new Vector2(0f, 1f),
				new Vector2(1f, 0f),
				new Vector2(1f, 1f)
			};
			Vector2 vector = end - start;
			Vector2 vector2 = (vector.y != 0f) ? new Vector2(1f, -vector.x / vector.y) : new Vector2(0f, 1f);
			vector2.Normalize();
			vector2 *= this.lineWidth / 2f;
			Vector2[] array3 = new Vector2[]
			{
				start + vector2,
				end + vector2,
				end - vector2,
				start - vector2
			};
			for (int i = 0; i < 4; i++)
			{
				UIVertex simpleVert = UIVertex.simpleVert;
				simpleVert.color = this.lineColor;
				simpleVert.position = array3[i];
				simpleVert.uv0 = array2[i];
				array[i] = simpleVert;
			}
			return array;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00026F20 File Offset: 0x00025120
		private Vector2 GetPoint(Vector2 size, int i)
		{
			int num = this.values.Length;
			float num2 = 360f / (float)num * (float)i + this.angleOffset;
			float num3 = Mathf.Sin(num2 * 0.0174532924f);
			float num4 = Mathf.Cos(num2 * 0.0174532924f);
			return new Vector2(size.x * num4, size.y * num3);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00026F7C File Offset: 0x0002517C
		private UIVertex[] GetQuad(params Vector2[] vertPos)
		{
			UIVertex[] array = new UIVertex[4];
			Vector2[] array2 = new Vector2[]
			{
				new Vector2(0f, 0f),
				new Vector2(0f, 1f),
				new Vector2(1f, 0f),
				new Vector2(1f, 1f)
			};
			for (int i = 0; i < 4; i++)
			{
				UIVertex simpleVert = UIVertex.simpleVert;
				simpleVert.color = this.color;
				simpleVert.position = vertPos[i];
				simpleVert.uv0 = array2[i];
				array[i] = simpleVert;
			}
			return array;
		}

		// Token: 0x04000590 RID: 1424
		public bool isFill = true;

		// Token: 0x04000591 RID: 1425
		[Range(0f, 0.99f)]
		public float fillPercent = 0.8f;

		// Token: 0x04000592 RID: 1426
		[Range(0f, 1f)]
		public float[] values;

		// Token: 0x04000593 RID: 1427
		[Range(0f, 360f)]
		public float angleOffset;

		// Token: 0x04000594 RID: 1428
		public bool useStateLine = true;

		// Token: 0x04000595 RID: 1429
		public Color lineColor = Color.white;

		// Token: 0x04000596 RID: 1430
		public float lineWidth = 0.5f;

		// Token: 0x04000597 RID: 1431
		[Range(0f, 1f)]
		public float lineLength = 0.8f;
	}
}
