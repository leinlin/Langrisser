using System;
using UnityEngine;

// Token: 0x02000128 RID: 296
public class ParticleAndAnimation : MonoBehaviour
{
	// Token: 0x06000C0B RID: 3083 RVA: 0x0003359C File Offset: 0x0003179C
	[ContextMenu("Play Loop")]
	public void PlayLoop()
	{
		ParticleSystem[] componentsInChildren = base.GetComponentsInChildren<ParticleSystem>(true);
		foreach (ParticleSystem particleSystem in componentsInChildren)
		{
			particleSystem.main.loop = true;
			particleSystem.Clear(true);
			particleSystem.time = 0f;
			particleSystem.Play();
		}
		Animation[] componentsInChildren2 = base.GetComponentsInChildren<Animation>(true);
		foreach (Animation animation in componentsInChildren2)
		{
			animation.wrapMode = WrapMode.Loop;
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
				animatorClipInfo.clip.wrapMode = WrapMode.Loop;
				componentInChildren.Play(animatorClipInfo.clip.name, -1, 0f);
			}
		}
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x000336A8 File Offset: 0x000318A8
	[ContextMenu("Play Once")]
	public void PlayOnce()
	{
		Transform[] componentsInChildren = base.GetComponentsInChildren<Transform>(true);
		foreach (Transform transform in componentsInChildren)
		{
			DelayPlay component = transform.GetComponent<DelayPlay>();
			if (component != null)
			{
				if (component.delayTime >= 0f)
				{
					component.InvokePlay();
				}
			}
			else
			{
				this.PlayOnce(transform.gameObject);
			}
		}
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x00033718 File Offset: 0x00031918
	private void PlayOnce(GameObject obj)
	{
		if (obj == null)
		{
			return;
		}
		ParticleSystem[] componentsInChildren = obj.GetComponentsInChildren<ParticleSystem>(true);
		foreach (ParticleSystem particleSystem in componentsInChildren)
		{
			particleSystem.main.loop = false;
			particleSystem.Clear(true);
			particleSystem.time = 0f;
			particleSystem.Play();
		}
		Animation[] componentsInChildren2 = obj.GetComponentsInChildren<Animation>(true);
		foreach (Animation animation in componentsInChildren2)
		{
			animation.wrapMode = WrapMode.Once;
			animation.Play();
		}
		Animator componentInChildren = obj.GetComponentInChildren<Animator>();
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
}
