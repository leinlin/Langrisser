using System;
using UnityEngine;

// Token: 0x02000125 RID: 293
public class AnimationUV : MonoBehaviour
{
	// Token: 0x06000C00 RID: 3072 RVA: 0x000332A8 File Offset: 0x000314A8
	private void Start()
	{
		this.offsettime = Time.time;
		this.mRenderer = base.GetComponent<Renderer>();
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x000332C4 File Offset: 0x000314C4
	private void Update()
	{
		this.index = (int)((Time.time - this.offsettime) * this.framesPerSecond);
		if (this.play)
		{
			this.index %= this.uvAnimationTileX * this.uvAnimationTileY;
			Vector2 value = new Vector2(1f / (float)this.uvAnimationTileX, 1f / (float)this.uvAnimationTileY);
			int num = this.index % this.uvAnimationTileX;
			int num2 = this.index / this.uvAnimationTileX;
			Vector2 value2 = new Vector2((float)num * value.x, 1f - value.y - (float)num2 * value.y);
			this.mRenderer.material.SetTextureOffset("_MainTex", value2);
			this.mRenderer.material.SetTextureScale("_MainTex", value);
		}
		if (!this.loop && this.index >= this.uvAnimationTileX * this.uvAnimationTileY - 1)
		{
			this.play = false;
			if (this.Hidewhenstopplaying)
			{
				this.mRenderer.enabled = false;
			}
		}
	}

	// Token: 0x04000705 RID: 1797
	public int uvAnimationTileX = 24;

	// Token: 0x04000706 RID: 1798
	public int uvAnimationTileY = 1;

	// Token: 0x04000707 RID: 1799
	public float framesPerSecond = 10f;

	// Token: 0x04000708 RID: 1800
	public bool loop;

	// Token: 0x04000709 RID: 1801
	public bool play = true;

	// Token: 0x0400070A RID: 1802
	private int index;

	// Token: 0x0400070B RID: 1803
	private float offsettime;

	// Token: 0x0400070C RID: 1804
	public bool Hidewhenstopplaying;

	// Token: 0x0400070D RID: 1805
	private Renderer mRenderer;
}
