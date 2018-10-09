using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000028 RID: 40
	[RequireComponent(typeof(AudioSource))]
	[Serializable]
	public class RandomAudioClipPlayer : MonoBehaviour
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		private void Awake()
		{
			this.m_audioSource = base.GetComponent<AudioSource>();
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000D4F8 File Offset: 0x0000B6F8
		public void Play(float volume = -1f)
		{
			if (this.AudioClipList.Count == 0)
			{
				global::Debug.LogError("AudioClip List is empty!");
				return;
			}
			if (this.MinPitch > this.MaxPitch)
			{
				global::Debug.LogError("Pitch setting error!");
				return;
			}
			if (volume != -1f)
			{
				this.m_audioSource.volume = volume;
			}
			base.StartCoroutine(this.PlayWithDelay());
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000D560 File Offset: 0x0000B760
		private IEnumerator PlayWithDelay()
		{
			if (this.DelayTime > 0f)
			{
				yield return new WaitForSeconds(this.DelayTime);
			}
			AudioClip clip = this.AudioClipList[UnityEngine.Random.Range(0, this.AudioClipList.Count)];
			this.m_audioSource.clip = clip;
			float pitch = this.MinPitch;
			if (this.MinPitch != this.MaxPitch)
			{
				pitch = UnityEngine.Random.Range(this.MinPitch, this.MaxPitch);
			}
			this.m_audioSource.pitch = pitch;
			this.m_audioSource.Play();
			yield break;
		}

		// Token: 0x040000A7 RID: 167
		private AudioSource m_audioSource;

		// Token: 0x040000A8 RID: 168
		[Header("播放延时")]
		public float DelayTime;

		// Token: 0x040000A9 RID: 169
		[Header("播放速度范围最小值")]
		public float MinPitch = 1f;

		// Token: 0x040000AA RID: 170
		[Header("播放速度范围最大值")]
		public float MaxPitch = 1.2f;

		// Token: 0x040000AB RID: 171
		[Header("待播放的AudioClip列表")]
		public List<AudioClip> AudioClipList = new List<AudioClip>();
	}
}
