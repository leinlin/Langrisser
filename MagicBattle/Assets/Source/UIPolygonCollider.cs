using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000ED RID: 237
[RequireComponent(typeof(PolygonCollider2D))]
public class UIPolygonCollider : Image
{
	// Token: 0x060008C5 RID: 2245 RVA: 0x00026B14 File Offset: 0x00024D14
	protected UIPolygonCollider()
	{
		base.useLegacyMeshGeneration = true;
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00026B24 File Offset: 0x00024D24
	private PolygonCollider2D Polygon
	{
		get
		{
			if (this.m_polygon != null)
			{
				return this.m_polygon;
			}
			this.m_polygon = base.GetComponent<PolygonCollider2D>();
			return this.m_polygon;
		}
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00026B50 File Offset: 0x00024D50
	protected override void OnPopulateMesh(VertexHelper vh)
	{
		vh.Clear();
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00026B58 File Offset: 0x00024D58
	public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return this.Polygon.OverlapPoint(eventCamera.ScreenToWorldPoint(screenPoint));
	}

	// Token: 0x0400058F RID: 1423
	private PolygonCollider2D m_polygon;
}
