using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200097D RID: 2429
	[CustomLuaClass]
	public class UISpineGraphic
	{
		// Token: 0x06008ACF RID: 35535 RVA: 0x00287120 File Offset: 0x00285320
		public bool Create(string assetName)
		{
			this.Destroy();
			if (string.IsNullOrEmpty(assetName))
			{
				return false;
			}
			this.m_assetName = assetName;
			this.m_gameObject = new GameObject(GameObjectUtility.GetDefaultName(assetName));
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(assetName);
			if (asset == null)
			{
				global::Debug.LogWarning("UISpineGraphic.Create GetAsset " + assetName + " fail.");
				this.Destroy();
				return false;
			}
			SkeletonAnimation component = asset.GetComponent<SkeletonAnimation>();
			if (!(component != null))
			{
				global::Debug.LogWarning(assetName + " not spine prefab.");
				this.Destroy();
				return false;
			}
			SkeletonGraphic skeletonGraphic = this.m_gameObject.AddComponent<SkeletonGraphic>();
			Texture texture = null;
			Renderer component2 = asset.GetComponent<Renderer>();
			string text = string.Empty;
			if (component2 != null && component2.sharedMaterial != null)
			{
				if (component2.sharedMaterial.HasProperty("_AlphaTex"))
				{
					texture = component2.sharedMaterial.GetTexture("_AlphaTex");
				}
				text = component2.sharedMaterial.shader.name;
			}
			if (texture != null)
			{
				if (text.Contains("Skeleton2_SepAlpha"))
				{
					this.m_material = new Material(AssetUtility.Instance.GetAsset<Material>("UI/Common_New_ABS/Material/UISpine2_SepAlpha.mat"));
				}
				else
				{
					this.m_material = new Material(AssetUtility.Instance.GetAsset<Material>("UI/Common_New_ABS/Material/UISpine_SepAlpha.mat"));
				}
				this.m_material.SetTexture("_AlphaTex", texture);
				skeletonGraphic.material = this.m_material;
			}
			else if (text.Contains("Skeleton2"))
			{
				skeletonGraphic.material = AssetUtility.Instance.GetAsset<Material>("UI/Common_New_ABS/Material/UISpine2.mat");
			}
			else
			{
				skeletonGraphic.material = AssetUtility.Instance.GetAsset<Material>("UI/Common_New_ABS/Material/UISpine.mat");
			}
			skeletonGraphic.initialSkinName = component.initialSkinName;
			skeletonGraphic.skeletonDataAsset = component.skeletonDataAsset;
			skeletonGraphic.raycastTarget = false;
			skeletonGraphic.startingAnimation = component._animationName;
			skeletonGraphic.startingLoop = component.loop;
			skeletonGraphic.Initialize(false);
			if (!skeletonGraphic.IsValid)
			{
				global::Debug.LogWarning("Spine " + assetName + " error.");
				this.Destroy();
				return false;
			}
			this.m_spine = skeletonGraphic;
			this.m_spine.AnimationState.Event += this.HandleSpineAnimationEvent;
			this.m_spine.AnimationState.Start += this.HandleSpineAnimationStart;
			this.m_spine.AnimationState.End += this.HandleSpineAnimationEnd;
			return true;
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x002873AC File Offset: 0x002855AC
		private void HandleSpineAnimationEvent(Spine.AnimationState state, int trackIndex, Spine.Event e)
		{
			AudioUtility.SearchAndPlaySpineAnimEventSound(this.m_spine.skeletonDataAsset.name, state.ToString(), e.Data.Name);
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x002873D4 File Offset: 0x002855D4
		private void HandleSpineAnimationStart(Spine.AnimationState state, int trackIndex)
		{
			AudioUtility.SearchAndPlaySpineAnimEventSound(this.m_spine.skeletonDataAsset.name, state.ToString(), "start");
		}

		// Token: 0x06008AD2 RID: 35538 RVA: 0x002873F8 File Offset: 0x002855F8
		private void HandleSpineAnimationEnd(Spine.AnimationState state, int trackIndex)
		{
			AudioUtility.SearchAndPlaySpineAnimEventSound(this.m_spine.skeletonDataAsset.name, state.ToString(), "end");
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x0028741C File Offset: 0x0028561C
		public void Destroy()
		{
			if (this.m_spine != null)
			{
				this.m_spine.AnimationState.Event -= this.HandleSpineAnimationEvent;
				this.m_spine.AnimationState.Start -= this.HandleSpineAnimationStart;
				this.m_spine = null;
			}
			if (this.m_material != null)
			{
				UnityEngine.Object.Destroy(this.m_material);
				this.m_material = null;
			}
			if (this.m_gameObject != null)
			{
				UnityEngine.Object.Destroy(this.m_gameObject);
				this.m_gameObject = null;
			}
			this.m_assetName = string.Empty;
		}

		// Token: 0x06008AD4 RID: 35540 RVA: 0x002874CC File Offset: 0x002856CC
		public void SetDirection(int dir)
		{
			if (this.m_spine != null)
			{
				this.m_spine.Skeleton.FlipX = (dir > 0);
			}
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x002874F4 File Offset: 0x002856F4
		public void SetParent(GameObject parent)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			this.m_gameObject.transform.SetParent((!(parent != null)) ? null : parent.transform, false);
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x00287534 File Offset: 0x00285734
		public void SetPosition(Vector2 p)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			RectTransform rectTransform = this.m_gameObject.transform as RectTransform;
			if (rectTransform != null)
			{
				rectTransform.anchoredPosition = p;
			}
			else
			{
				this.m_gameObject.transform.localPosition = p;
			}
		}

		// Token: 0x06008AD7 RID: 35543 RVA: 0x00287594 File Offset: 0x00285794
		public void SetScale(float scale)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			this.m_gameObject.transform.localScale = new Vector3(scale, scale, scale);
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x002875C0 File Offset: 0x002857C0
		public void SetRectTransformSize(Vector2 size)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			RectTransform rectTransform = this.m_gameObject.transform as RectTransform;
			if (rectTransform != null)
			{
				rectTransform.sizeDelta = size;
			}
		}

		// Token: 0x06008AD9 RID: 35545 RVA: 0x00287604 File Offset: 0x00285804
		public void SetColor(Color color)
		{
			if (this.m_spine != null)
			{
				this.m_spine.color = color;
			}
		}

		// Token: 0x06008ADA RID: 35546 RVA: 0x00287624 File Offset: 0x00285824
		public void PlayAnimation(string name, bool loop, int trackIndex = 0)
		{
			if (this.m_spine == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (this.m_replaceAnims != null)
			{
				foreach (ReplaceAnim replaceAnim in this.m_replaceAnims)
				{
					if (name == replaceAnim.DefaultName)
					{
						name = replaceAnim.ReplaceName;
						break;
					}
				}
			}
			Spine.Animation animation = this.m_spine.AnimationState.Data.SkeletonData.FindAnimation(name);
			if (animation != null)
			{
				TrackEntry current = this.m_spine.AnimationState.GetCurrent(trackIndex);
				if (loop && this.m_isAnimationLoop && current != null && current.Animation == animation)
				{
					return;
				}
				this.m_spine.AnimationState.SetAnimation(trackIndex, animation, loop);
				this.m_isAnimationLoop = loop;
			}
			else
			{
				global::Debug.LogWarning(this.m_spine.skeletonDataAsset.name + " animation " + name + " not found.");
			}
		}

		// Token: 0x06008ADB RID: 35547 RVA: 0x00287760 File Offset: 0x00285960
		public void StopAnimation(int trackIndex)
		{
			if (this.m_spine == null)
			{
				return;
			}
			this.m_spine.AnimationState.ClearTrack(trackIndex);
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x00287788 File Offset: 0x00285988
		public bool IsLoop(int trackIndex)
		{
			TrackEntry current = this.m_spine.AnimationState.GetCurrent(trackIndex);
			return current != null && current.Loop;
		}

		// Token: 0x06008ADD RID: 35549 RVA: 0x002877B8 File Offset: 0x002859B8
		public bool IsPlayAnimation(int trackIndex)
		{
			if (this.m_spine == null)
			{
				return false;
			}
			TrackEntry current = this.m_spine.AnimationState.GetCurrent(trackIndex);
			return current != null;
		}

		// Token: 0x06008ADE RID: 35550 RVA: 0x002877F4 File Offset: 0x002859F4
		public float GetAnimationDuration(int trackIndex)
		{
			TrackEntry current = this.m_spine.AnimationState.GetCurrent(trackIndex);
			if (current != null)
			{
				return current.Animation.Duration;
			}
			return 0f;
		}

		// Token: 0x06008ADF RID: 35551 RVA: 0x0028782C File Offset: 0x00285A2C
		public float GetAnimationDuration(string name)
		{
			Spine.Animation animation = this.m_spine.AnimationState.Data.SkeletonData.FindAnimation(name);
			if (animation != null)
			{
				return animation.Duration;
			}
			return 0f;
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x00287868 File Offset: 0x00285A68
		public float GetAnimationTime(int trackIndex)
		{
			TrackEntry current = this.m_spine.AnimationState.GetCurrent(trackIndex);
			if (current != null)
			{
				return current.Time;
			}
			return 0f;
		}

		// Token: 0x06008AE1 RID: 35553 RVA: 0x0028789C File Offset: 0x00285A9C
		public void SetAnimationTime(int trackIndex, float time)
		{
			TrackEntry current = this.m_spine.AnimationState.GetCurrent(trackIndex);
			if (current != null)
			{
				current.Time = time;
			}
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x002878C8 File Offset: 0x00285AC8
		public void SetReplaceAnimations(List<ReplaceAnim> replaceAnims)
		{
			this.m_replaceAnims = replaceAnims;
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x002878D4 File Offset: 0x00285AD4
		public bool HasAnimation(string name)
		{
			return !(this.m_spine == null) && this.m_spine.AnimationState.Data.SkeletonData.FindAnimation(name) != null;
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x0028790C File Offset: 0x00285B0C
		public void SetAnimationSpeed(float s)
		{
			if (this.m_spine == null)
			{
				return;
			}
			this.m_spine.timeScale = s;
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x0028792C File Offset: 0x00285B2C
		public void ForceUpdate()
		{
			if (this.m_spine != null)
			{
				this.m_spine.Update(0f);
			}
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x00287950 File Offset: 0x00285B50
		public void ShowSlot(string name, bool show)
		{
			if (this.m_spine == null)
			{
				return;
			}
			Slot slot = this.m_spine.Skeleton.FindSlot(name);
			if (slot != null)
			{
				slot.A = (float)((!show) ? 0 : 1);
			}
		}

		// Token: 0x06008AE7 RID: 35559 RVA: 0x0028799C File Offset: 0x00285B9C
		public void EnableCanvasGroupAlpha(bool enable)
		{
			if (this.m_spine != null)
			{
				this.m_spine.EnableCanvasGroupAlpha(enable);
			}
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06008AE8 RID: 35560 RVA: 0x002879BC File Offset: 0x00285BBC
		public GameObject GameObject
		{
			get
			{
				return this.m_gameObject;
			}
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06008AE9 RID: 35561 RVA: 0x002879C4 File Offset: 0x00285BC4
		public string AssetName
		{
			get
			{
				return this.m_assetName;
			}
		}

		// Token: 0x040062DF RID: 25311
		private SkeletonGraphic m_spine;

		// Token: 0x040062E0 RID: 25312
		private Material m_material;

		// Token: 0x040062E1 RID: 25313
		private GameObject m_gameObject;

		// Token: 0x040062E2 RID: 25314
		private bool m_isAnimationLoop;

		// Token: 0x040062E3 RID: 25315
		private List<ReplaceAnim> m_replaceAnims;

		// Token: 0x040062E4 RID: 25316
		private string m_assetName;
	}
}
