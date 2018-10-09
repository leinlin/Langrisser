using System;
using BlackJack.BJFramework.Runtime.Scene;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000006 RID: 6
	[ExecuteInEditMode]
	public class EffectBillboardController : MonoBehaviour
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00009624 File Offset: 0x00007824
		public void Start()
		{
			if (this.FaceToCameraInRuntime == null && Application.isPlaying)
			{
				this.FaceToCameraInRuntime = this.GetLayerCameraFromParent();
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00009650 File Offset: 0x00007850
		protected Camera GetLayerCameraFromParent()
		{
			Transform parent = base.transform.parent;
			while (parent != null)
			{
				ThreeDSceneLayer component = parent.gameObject.GetComponent<ThreeDSceneLayer>();
				if (component != null)
				{
					return component.LayerCamera;
				}
				parent = parent.parent;
			}
			return null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000096A4 File Offset: 0x000078A4
		public void Update()
		{
			if (this.FaceToCameraInRuntime != null && Application.isPlaying)
			{
				if (this.RotationFaceMode == EffectBillboardController.FaceMode.ReverseCameraRotation)
				{
					Quaternion rotation = this.FaceToCameraInRuntime.transform.rotation;
					base.transform.rotation = rotation * Quaternion.Euler(0f, 180f, 0f);
				}
				else
				{
					base.transform.LookAt(this.FaceToCameraInRuntime.transform);
				}
			}
			if (this.IsKeepSize)
			{
				this.KeepSize();
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000973C File Offset: 0x0000793C
		public void OnRenderObject()
		{
			if (this.FaceToCameraInEditor != null && !Application.isPlaying)
			{
				if (this.RotationFaceMode == EffectBillboardController.FaceMode.ReverseCameraRotation)
				{
					Quaternion rotation = this.FaceToCameraInEditor.transform.rotation;
					base.transform.rotation = rotation * Quaternion.Euler(0f, 180f, 0f);
				}
				else
				{
					base.transform.LookAt(this.FaceToCameraInEditor.transform);
				}
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000097C0 File Offset: 0x000079C0
		protected void KeepSize()
		{
			if (this.Render == null || this.FaceToCameraInRuntime == null)
			{
				return;
			}
			float num = this.Width / (float)Screen.currentResolution.width;
			float screenPortion = this.GetScreenPortion();
			Vector3 localScale = base.transform.localScale;
			float d = num / screenPortion;
			base.transform.localScale = localScale * d;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00009834 File Offset: 0x00007A34
		private float GetScreenPortion()
		{
			float magnitude = this.Render.bounds.size.magnitude;
			Vector3 a = this.FaceToCameraInRuntime.ScreenToWorldPoint(new Vector3(((float)Screen.width - 100f) / 2f, 0f, 1f));
			Vector3 b = this.FaceToCameraInRuntime.ScreenToWorldPoint(new Vector3(((float)Screen.width + 100f) / 2f, 0f, 1f));
			float num = 1f / (Vector3.Distance(a, b) / 100f);
			float num2 = Vector3.Distance(this.FaceToCameraInRuntime.transform.position, base.transform.position);
			float num3 = magnitude * num;
			return num3 / num2 / (float)Screen.width;
		}

		// Token: 0x04000008 RID: 8
		[Header("编辑状态下朝向的Camera")]
		public Camera FaceToCameraInEditor;

		// Token: 0x04000009 RID: 9
		[Header("运行状态下朝向的Camera")]
		public Camera FaceToCameraInRuntime;

		// Token: 0x0400000A RID: 10
		[Header("特效对象Camera朝向模式")]
		public EffectBillboardController.FaceMode RotationFaceMode;

		// Token: 0x0400000B RID: 11
		public bool IsKeepSize;

		// Token: 0x0400000C RID: 12
		public float Width;

		// Token: 0x0400000D RID: 13
		public Renderer Render;

		// Token: 0x02000007 RID: 7
		public enum FaceMode
		{
			// Token: 0x0400000F RID: 15
			ReverseCameraRotation,
			// Token: 0x04000010 RID: 16
			FaceToCamera
		}
	}
}
