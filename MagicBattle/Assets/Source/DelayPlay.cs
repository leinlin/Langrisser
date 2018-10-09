using System;
using UnityEngine;

// Token: 0x02000126 RID: 294
public class DelayPlay : MonoBehaviour
{
	// Token: 0x06000C03 RID: 3075 RVA: 0x000333FC File Offset: 0x000315FC
	private void Start()
	{
		base.gameObject.SetActive(false);
		if (this.playOnAwake)
		{
			this.InvokePlay();
		}
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x0003341C File Offset: 0x0003161C
	public void InvokePlay()
	{
		base.gameObject.SetActive(false);
		base.Invoke("DelayFunc", this.delayTime);
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x0003343C File Offset: 0x0003163C
	private void DelayFunc()
	{
		base.gameObject.SetActive(true);
		this.PlayOnce();
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x00033450 File Offset: 0x00031650
	public void PlayOnce()
	{
		ParticleSystem[] componentsInChildren = base.GetComponentsInChildren<ParticleSystem>(true);
		foreach (ParticleSystem particleSystem in componentsInChildren)
		{
			particleSystem.main.loop = false;
			particleSystem.Play();
		}
		Animation[] componentsInChildren2 = base.GetComponentsInChildren<Animation>(true);
		foreach (Animation animation in componentsInChildren2)
		{
			animation.wrapMode = WrapMode.Once;
			animation.Play();
		}
		Animator componentInChildren = base.GetComponentInChildren<Animator>();
		if (null != componentInChildren)
		{
			AnimatorClipInfo[] currentAnimatorClipInfo = componentInChildren.GetCurrentAnimatorClipInfo(0);
			AnimatorClipInfo[] array3 = currentAnimatorClipInfo;
			int num = 0;
			if (num < array3.Length)
			{
				AnimatorClipInfo animatorClipInfo = array3[num];
				animatorClipInfo.clip.wrapMode = WrapMode.Once;
				componentInChildren.Play(animatorClipInfo.clip.name, -1, 0f);
			}
		}
	}

	// Token: 0x0400070E RID: 1806
	public float delayTime = 1f;

	// Token: 0x0400070F RID: 1807
	public bool playOnAwake;
}
