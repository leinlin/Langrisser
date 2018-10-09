using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000008 RID: 8
	public class FxChild : MonoBehaviour
	{
		// Token: 0x060001CB RID: 459 RVA: 0x00009918 File Offset: 0x00007B18
		private void Awake()
		{
			if (this.m_prefab != null)
			{
				this.m_childGameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_prefab);
				this.m_childGameObject.transform.SetParent(base.transform, false);
				this.m_childGameObject.SetActive(false);
			}
			this.m_animationVisible = false;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00009974 File Offset: 0x00007B74
		private void OnEnable()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00009978 File Offset: 0x00007B78
		private void OnDisable()
		{
			if (this.m_childGameObject != null)
			{
				this.m_childGameObject.SetActive(false);
			}
			this.m_animationVisible = false;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000099A0 File Offset: 0x00007BA0
		private void OnDrawGizmosSelected()
		{
			if (this.m_visible)
			{
				Matrix4x4 localToWorldMatrix = base.transform.localToWorldMatrix;
				Vector3 b = localToWorldMatrix.GetColumn(0);
				Vector3 b2 = localToWorldMatrix.GetColumn(1);
				Vector3 b3 = localToWorldMatrix.GetColumn(2);
				Vector3 vector = localToWorldMatrix.GetColumn(3);
				Gizmos.color = Color.red;
				Gizmos.DrawLine(vector, vector + b);
				Gizmos.color = Color.green;
				Gizmos.DrawLine(vector, vector + b2);
				Gizmos.color = Color.blue;
				Gizmos.DrawLine(vector, vector + b3);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00009A48 File Offset: 0x00007C48
		private void Update()
		{
			if (this.m_childGameObject == null)
			{
				return;
			}
			if (this.m_childGameObject.activeSelf != this.m_animationVisible)
			{
				this.m_childGameObject.SetActive(this.m_animationVisible);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00009A84 File Offset: 0x00007C84
		private void LateUpdate()
		{
			this.m_animationVisible = this.m_visible;
		}

		// Token: 0x04000011 RID: 17
		public GameObject m_prefab;

		// Token: 0x04000012 RID: 18
		public bool m_visible = true;

		// Token: 0x04000013 RID: 19
		private bool m_animationVisible;

		// Token: 0x04000014 RID: 20
		private GameObject m_childGameObject;
	}
}
