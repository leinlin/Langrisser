using System;
using UnityEngine;

// Token: 0x02000127 RID: 295
public class Effect_Rotate : MonoBehaviour
{
	// Token: 0x06000C08 RID: 3080 RVA: 0x00033554 File Offset: 0x00031754
	private void Awake()
	{
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00033558 File Offset: 0x00031758
	private void Update()
	{
		float deltaTime = Time.deltaTime;
		float xAngle = this.SpeedX * deltaTime;
		float yAngle = this.SpeedY * deltaTime;
		float zAngle = this.SpeedZ * deltaTime;
		base.transform.Rotate(xAngle, yAngle, zAngle);
	}

	// Token: 0x04000710 RID: 1808
	public float SpeedX;

	// Token: 0x04000711 RID: 1809
	public float SpeedY;

	// Token: 0x04000712 RID: 1810
	public float SpeedZ;
}
