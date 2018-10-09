using System;
using System.Collections;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Art;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using FixMath.NET;
using SLua;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000976 RID: 2422
	[CustomLuaClass]
	public class GenericGraphic : IBattleGraphic
	{
		// Token: 0x06008A7F RID: 35455 RVA: 0x00284160 File Offset: 0x00282360
		public GenericGraphic()
		{
			this.m_isVisible = true;
		}

		// Token: 0x06008A80 RID: 35456 RVA: 0x002841B0 File Offset: 0x002823B0
		public bool Create(string assetName, bool isFx)
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
				global::Debug.LogWarning("GenericGraphic.Create GetAsset " + assetName + " fail.");
				this.Destroy();
				return false;
			}
			this.m_prefab = UnityEngine.Object.Instantiate<GameObject>(asset, this.m_gameObject.transform, false);
			this.m_prefab.transform.localPosition = Vector3.zero;
			this.m_prefab.transform.localRotation = Quaternion.identity;
			this.m_initScale = this.m_prefab.transform.localScale;
			SkeletonAnimation component = this.m_prefab.GetComponent<SkeletonAnimation>();
			if (component != null)
			{
				if (!component.valid || component.state == null)
				{
					global::Debug.LogWarning("Spine " + assetName + " error.");
					this.Destroy();
					return false;
				}
				this.m_spineInfo = new GenericGraphic.SpineInfo();
				this.m_spineInfo.m_spine = component;
				component.state.Event += this.HandleSpineAnimationEvent;
				component.state.Start += this.HandleSpineAnimationStart;
				component.state.End += this.HandleSpineAnimationEnd;
				Renderer component2 = this.m_prefab.GetComponent<Renderer>();
				if (component2 != null)
				{
					Bounds bounds = component2.bounds;
					this.m_spineInfo.m_boundsMin.Set(bounds.min.x, bounds.min.y);
					this.m_spineInfo.m_boundsMax.Set(bounds.max.x, bounds.max.y);
				}
				this.m_spineInfo.m_initAnimationName = component.AnimationName;
			}
			if (isFx)
			{
				this.m_fxInfo = new GenericGraphic.FxInfo();
				this.GetAnimationInfo();
				this.m_fxInfo.m_lifeCountdown = this.m_fxInfo.m_initLife;
				this.m_fxInfo.m_fxDesc = this.m_prefab.GetComponent<FxDesc>();
				TrailRenderer[] componentsInChildren = this.m_prefab.GetComponentsInChildren<TrailRenderer>(true);
				if (componentsInChildren != null && componentsInChildren.Length > 0)
				{
					foreach (TrailRenderer trailRenderer in componentsInChildren)
					{
						trailRenderer.autodestruct = false;
						trailRenderer.Clear();
					}
					this.m_fxInfo.m_trailRenderers = componentsInChildren;
				}
			}
			this.m_animator = this.m_prefab.GetComponent<Animator>();
			return true;
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x00284460 File Offset: 0x00282660
		private void HandleSpineAnimationEvent(Spine.AnimationState state, int trackIndex, Spine.Event e)
		{
			AudioUtility.SearchAndPlaySpineAnimEventSound(this.m_spineInfo.m_spine.skeletonDataAsset.name, state.ToString(), e.Data.Name);
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x00284490 File Offset: 0x00282690
		private void HandleSpineAnimationStart(Spine.AnimationState state, int trackIndex)
		{
			AudioUtility.SearchAndPlaySpineAnimEventSound(this.m_spineInfo.m_spine.skeletonDataAsset.name, state.ToString(), "start");
		}

		// Token: 0x06008A83 RID: 35459 RVA: 0x002844B8 File Offset: 0x002826B8
		private void HandleSpineAnimationEnd(Spine.AnimationState state, int trackIndex)
		{
			AudioUtility.SearchAndPlaySpineAnimEventSound(this.m_spineInfo.m_spine.skeletonDataAsset.name, state.ToString(), "end");
		}

		// Token: 0x06008A84 RID: 35460 RVA: 0x002844E0 File Offset: 0x002826E0
		public void Destroy()
		{
			if (this.m_spineInfo != null && this.m_spineInfo.m_spine != null)
			{
				this.m_spineInfo.m_spine.state.Event -= this.HandleSpineAnimationEvent;
				this.m_spineInfo.m_spine.state.Start -= this.HandleSpineAnimationStart;
			}
			this.ClearAttachFxs(-1);
			this.ClearGhosts();
			this.m_prefab = null;
			if (this.m_gameObject != null)
			{
				UnityEngine.Object.Destroy(this.m_gameObject);
				this.m_gameObject = null;
			}
			this.m_spineInfo = null;
			this.m_fxInfo = null;
			this.m_effectInfo = null;
			this.m_assetName = string.Empty;
			this.m_animator = null;
			this.m_animatorTriggerNameId = 0;
		}

		// Token: 0x06008A85 RID: 35461 RVA: 0x002845B8 File Offset: 0x002827B8
		public void SetActive(bool active)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			this.m_gameObject.SetActive(active);
			if (active)
			{
				if (this.m_spineInfo != null)
				{
					this.m_spineInfo.m_spine.state.ClearTracks();
					this.m_spineInfo.m_spine.Skeleton.SetToSetupPose();
					this.m_spineInfo.m_spine.Skeleton.FlipX = false;
					this.m_spineInfo.m_spine.SetCulled(false);
					if (!string.IsNullOrEmpty(this.m_spineInfo.m_initAnimationName))
					{
						this.m_spineInfo.m_spine.state.SetAnimation(0, this.m_spineInfo.m_initAnimationName, this.m_spineInfo.m_spine.loop);
					}
					this.m_spineInfo.m_isAnimationLoop = false;
					this.m_spineInfo.m_isCulled = false;
					this.m_spineInfo.m_height = (this.m_spineInfo.m_footHeight = 0f);
				}
				if (this.m_fxInfo != null)
				{
					this.m_fxInfo.m_lifeCountdown = this.m_fxInfo.m_initLife;
					this.m_fxInfo.m_isDeleteMe = false;
					this.m_fxInfo.m_isAutoDelete = false;
					this.m_fxInfo.m_attachBone = null;
					this.m_fxInfo.m_yOffset = 0f;
					if (this.m_fxInfo.m_trailRenderers != null)
					{
						foreach (TrailRenderer trailRenderer in this.m_fxInfo.m_trailRenderers)
						{
							trailRenderer.Clear();
						}
					}
					if (this.m_fxInfo.m_stopParticleSystems != null)
					{
						foreach (ParticleSystem particleSystem in this.m_fxInfo.m_stopParticleSystems)
						{
							particleSystem.emission.enabled = true;
						}
						this.m_fxInfo.m_stopParticleSystems.Clear();
					}
					if (this.m_fxInfo.m_stopRenderers != null)
					{
						foreach (Renderer renderer in this.m_fxInfo.m_stopRenderers)
						{
							renderer.enabled = true;
						}
						this.m_fxInfo.m_stopRenderers.Clear();
					}
				}
				if (this.m_effectInfo != null)
				{
					this.m_effectInfo.m_curTime = (this.m_effectInfo.m_totalTime = 0f);
					this.m_effectInfo.m_type = GraphicEffect.None;
				}
				this.m_gameObject.transform.localPosition = Vector3.zero;
				this.m_gameObject.transform.localRotation = Quaternion.identity;
				this.m_gameObject.transform.localScale = Vector3.one;
				this.m_direction = 0;
				this.SetColor(new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
				this.SetIntensity(1f);
				this.SetSaturation(1f);
				this.SetPrefabScale(1f);
				this.SetLayer(0);
				this.SetSortingOrder(0);
				this.Pause(false);
				this.SetVisible(true);
			}
			else
			{
				this.ClearAttachFxs(-1);
				this.ClearGhosts();
				this.m_container = null;
			}
		}

		// Token: 0x06008A86 RID: 35462 RVA: 0x00284934 File Offset: 0x00282B34
		private void GetAnimationInfo()
		{
			if (this.m_prefab == null)
			{
				return;
			}
			if (this.m_fxInfo == null)
			{
				return;
			}
			this.m_fxInfo.m_initLife = 0f;
			this.m_fxInfo.m_initLoop = false;
			Animator[] componentsInChildren = this.m_prefab.GetComponentsInChildren<Animator>();
			foreach (Animator animator in componentsInChildren)
			{
				AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
				this.m_fxInfo.m_initLife = Math.Max(this.m_fxInfo.m_initLife, currentAnimatorStateInfo.length);
				this.m_fxInfo.m_initLoop |= currentAnimatorStateInfo.loop;
			}
			UnityEngine.Animation[] componentsInChildren2 = this.m_prefab.GetComponentsInChildren<UnityEngine.Animation>();
			foreach (UnityEngine.Animation animation in componentsInChildren2)
			{
				IEnumerator enumerator = animation.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						UnityEngine.AnimationState animationState = (UnityEngine.AnimationState)obj;
						this.m_fxInfo.m_initLife = Math.Max(this.m_fxInfo.m_initLife, animationState.clip.length);
						this.m_fxInfo.m_initLoop |= (animationState.wrapMode == WrapMode.Loop);
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
			ParticleSystem[] componentsInChildren3 = this.m_prefab.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren3)
			{
				ParticleSystem.MainModule main = particleSystem.main;
				this.m_fxInfo.m_initLife = Math.Max(this.m_fxInfo.m_initLife, main.duration + main.startDelay.constant + main.startLifetime.constant);
				this.m_fxInfo.m_initLoop |= main.loop;
			}
			if (this.m_spineInfo != null)
			{
				foreach (Spine.Animation animation2 in this.m_spineInfo.m_spine.Skeleton.Data.Animations)
				{
					this.m_fxInfo.m_initLife = Math.Max(this.m_fxInfo.m_initLife, animation2.Duration);
				}
			}
		}

		// Token: 0x06008A87 RID: 35463 RVA: 0x00284BCC File Offset: 0x00282DCC
		public void SetParent(GameObject parent)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			this.m_gameObject.transform.SetParent((!(parent != null)) ? null : parent.transform, false);
		}

		// Token: 0x06008A88 RID: 35464 RVA: 0x00284C0C File Offset: 0x00282E0C
		public void SetLayer(int layer)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			if (layer == this.m_layer)
			{
				return;
			}
			Renderer[] componentsInChildren = this.m_gameObject.GetComponentsInChildren<Renderer>(true);
			foreach (Renderer renderer in componentsInChildren)
			{
				renderer.gameObject.layer = layer;
			}
			this.m_layer = layer;
		}

		// Token: 0x06008A89 RID: 35465 RVA: 0x00284C74 File Offset: 0x00282E74
		public void SetSortingOrder(int order)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			if (order == this.m_sortingOrder)
			{
				return;
			}
			Renderer[] componentsInChildren = this.m_gameObject.GetComponentsInChildren<Renderer>(true);
			foreach (Renderer renderer in componentsInChildren)
			{
				renderer.sortingOrder = order;
			}
			this.m_sortingOrder = order;
		}

		// Token: 0x06008A8A RID: 35466 RVA: 0x00284CD8 File Offset: 0x00282ED8
		public GameObject GetPrefab()
		{
			return this.m_prefab;
		}

		// Token: 0x06008A8B RID: 35467 RVA: 0x00284CE0 File Offset: 0x00282EE0
		public void SetContainer(IGenericGraphicContainer container)
		{
			this.m_container = container;
		}

		// Token: 0x06008A8C RID: 35468 RVA: 0x00284CEC File Offset: 0x00282EEC
		public void SetFxPlayer(FxPlayer player)
		{
			this.m_fxPlayer = player;
		}

		// Token: 0x06008A8D RID: 35469 RVA: 0x00284CF8 File Offset: 0x00282EF8
		public void PlayAnimation(string name, bool loop)
		{
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (this.m_spineInfo != null)
			{
				if (this.m_spineInfo.m_replaceAnims != null)
				{
					foreach (ReplaceAnim replaceAnim in this.m_spineInfo.m_replaceAnims)
					{
						if (name == replaceAnim.DefaultName)
						{
							name = replaceAnim.ReplaceName;
							break;
						}
					}
				}
				Spine.Animation animation = this.m_spineInfo.m_spine.state.Data.SkeletonData.FindAnimation(name);
				if (animation != null)
				{
					if (loop && this.m_spineInfo.m_isAnimationLoop)
					{
						TrackEntry current = this.m_spineInfo.m_spine.state.GetCurrent(0);
						if (current != null && current.Animation == animation)
						{
							return;
						}
					}
					this.m_spineInfo.m_spine.state.SetAnimation(0, animation, loop);
					this.m_spineInfo.m_isAnimationLoop = loop;
				}
				else
				{
					global::Debug.LogWarning(this.m_spineInfo.m_spine.skeletonDataAsset.name + " animation " + name + " not found.");
				}
			}
			else if (this.m_animator != null)
			{
				if (this.m_animatorTriggerNameId != 0)
				{
					this.m_animator.ResetTrigger(this.m_animatorTriggerNameId);
				}
				this.m_animatorTriggerNameId = Animator.StringToHash(name);
				this.m_animator.SetTrigger(this.m_animatorTriggerNameId);
			}
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x00284EA4 File Offset: 0x002830A4
		public void PlayDeathAnimation(int deathType)
		{
			if (this.m_spineInfo == null)
			{
				return;
			}
			Spine.Animation animation = null;
			if (deathType == 1)
			{
				animation = this.m_spineInfo.m_spine.state.Data.SkeletonData.FindAnimation("death1");
				this.PlayFx("Spine/Effect_ABS/effect_death/EffectDeath1Prefab.prefab", 0);
			}
			else if (deathType == 2)
			{
				animation = this.m_spineInfo.m_spine.state.Data.SkeletonData.FindAnimation("death2");
				this.PlayFx("Spine/Effect_ABS/effect_death/EffectDeath2Prefab.prefab", 0);
			}
			if (animation == null)
			{
				animation = this.m_spineInfo.m_spine.state.Data.SkeletonData.FindAnimation("death");
			}
			if (animation != null)
			{
				this.m_spineInfo.m_spine.state.SetAnimation(0, animation, false);
				this.m_spineInfo.m_isAnimationLoop = false;
			}
			else
			{
				global::Debug.LogWarning(this.m_spineInfo.m_spine.skeletonDataAsset.name + " animation death not found.");
			}
		}

		// Token: 0x06008A8F RID: 35471 RVA: 0x00284FB4 File Offset: 0x002831B4
		public float GetAnimationDuration(string name)
		{
			if (this.m_spineInfo != null)
			{
				Spine.Animation animation = this.m_spineInfo.m_spine.state.Data.SkeletonData.FindAnimation(name);
				if (animation != null)
				{
					return animation.Duration;
				}
			}
			return 0f;
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x00285000 File Offset: 0x00283200
		public bool IsPlayAnimation(int trackIndex)
		{
			if (this.m_spineInfo != null)
			{
				TrackEntry current = this.m_spineInfo.m_spine.state.GetCurrent(trackIndex);
				return current != null;
			}
			return false;
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x00285038 File Offset: 0x00283238
		public void PlayFx(string name, int tag = 0)
		{
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (this.m_gameObject == null)
			{
				return;
			}
			if (this.m_fxPlayer == null)
			{
				return;
			}
			bool flag = false;
			if (this.m_direction == 1)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				string text = configDataLoader.UtilityGetFxFlipName(name);
				if (!string.IsNullOrEmpty(text))
				{
					name = text;
					flag = true;
				}
			}
			GenericGraphic genericGraphic = this.m_fxPlayer.Play(name);
			if (genericGraphic == null)
			{
				return;
			}
			genericGraphic.SetContainer(this.m_container);
			genericGraphic.SetFxPlayer(this.m_fxPlayer);
			FxAttachMode fxAttachMode = FxAttachMode.Once;
			float num = 0f;
			float num2 = 0f;
			FxDesc fxDesc = null;
			if (genericGraphic.m_fxInfo != null)
			{
				fxDesc = genericGraphic.m_fxInfo.m_fxDesc;
				genericGraphic.m_fxInfo.m_tag = tag;
			}
			Bone bone = null;
			if (fxDesc != null)
			{
				fxAttachMode = fxDesc.m_attach;
				if (this.m_spineInfo != null)
				{
					num = this.m_spineInfo.m_height * fxDesc.m_height + this.m_spineInfo.m_footHeight;
				}
				if (fxDesc.m_randomRotation)
				{
					num2 = (float)UnityEngine.Random.Range(0, 360);
				}
				if (!string.IsNullOrEmpty(fxDesc.m_attachBone) && this.m_spineInfo != null)
				{
					bone = this.m_spineInfo.m_spine.skeleton.FindBone(fxDesc.m_attachBone);
				}
				if (fxDesc.m_attachScale)
				{
					genericGraphic.SetPrefabScale(this.m_prefabScale);
				}
			}
			if (genericGraphic.m_fxInfo != null)
			{
				genericGraphic.m_fxInfo.m_yOffset = num;
				genericGraphic.m_fxInfo.m_attachBone = bone;
			}
			Vector3 vector = Vector3.zero;
			if (bone != null)
			{
				vector = this.m_gameObject.transform.TransformPoint(new Vector3(bone.WorldX, bone.WorldY, 0f));
			}
			if (fxAttachMode == FxAttachMode.Once)
			{
				if (bone != null)
				{
					Vector3 vector2 = vector;
					vector2.y += num;
					vector2.z -= 0.1f;
					genericGraphic.SetWorldPosition(vector2);
				}
				else
				{
					Vector3 vector2 = this.GetPosition();
					vector2.y += num;
					vector2.z -= 0.1f;
					genericGraphic.SetPosition(vector2);
				}
				if (num2 != 0f)
				{
					genericGraphic.SetRotationZ(num2);
				}
				if (!flag)
				{
					genericGraphic.SetDirection(this.m_direction);
				}
				genericGraphic.AutoDelete(true);
			}
			else if (fxAttachMode == FxAttachMode.Always)
			{
				genericGraphic.SetParent(this.m_gameObject);
				if (bone != null)
				{
					Vector3 worldPosition = vector;
					worldPosition.y += num;
					worldPosition.z -= 0.1f;
					genericGraphic.SetWorldPosition(worldPosition);
				}
				else
				{
					Vector3 worldPosition = this.GetPosition();
					worldPosition.y += num;
					worldPosition.z -= 0.1f;
					genericGraphic.SetPosition(new Vector3(0f, num, -0.1f));
				}
				genericGraphic.SetDirection(this.m_direction);
				if (num2 != 0f)
				{
					genericGraphic.SetRotationZ(num2);
				}
				genericGraphic.AutoDelete(false);
				if (this.m_attachFxs == null)
				{
					this.m_attachFxs = new List<GenericGraphic>();
				}
				this.m_attachFxs.Add(genericGraphic);
			}
			else if (fxAttachMode == FxAttachMode.No)
			{
				Vector3 position;
				if (this.m_container != null)
				{
					position = this.m_container.GetCameraPosition();
				}
				else
				{
					position = Camera.main.transform.position;
				}
				position.y += num;
				position.z = -1f;
				genericGraphic.SetPosition(position);
				if (num2 != 0f)
				{
					genericGraphic.SetRotationZ(num2);
				}
				genericGraphic.AutoDelete(true);
			}
			AssetUtility.Instance.AddAssetToLruCache(5, name);
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x00285420 File Offset: 0x00283620
		public void SetReplaceAnimations(List<ReplaceAnim> replaceAnims)
		{
			if (this.m_spineInfo != null)
			{
				this.m_spineInfo.m_replaceAnims = replaceAnims;
			}
		}

		// Token: 0x06008A93 RID: 35475 RVA: 0x0028543C File Offset: 0x0028363C
		public void SetHeight(float height, float footHeight)
		{
			if (this.m_spineInfo != null)
			{
				this.m_spineInfo.m_height = height;
				this.m_spineInfo.m_footHeight = footHeight;
			}
		}

		// Token: 0x06008A94 RID: 35476 RVA: 0x00285464 File Offset: 0x00283664
		public void SetCombatPosition(Vector2i pos, Fix64 z, int zoffset)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			if (this.m_container == null)
			{
				return;
			}
			if (this.m_container.IsCombatGraphicMirrorX())
			{
				pos.x = -pos.x;
			}
			Vector3 vector = this.m_container.CombatPositionToWorldPosition(pos, z, true);
			vector.z += (float)zoffset;
			this.m_gameObject.transform.localPosition = vector;
			this.CheckIsCulled(vector, true);
		}

		// Token: 0x06008A95 RID: 35477 RVA: 0x002854EC File Offset: 0x002836EC
		public void SetCombatDirection(Vector2i front, Fix64 frontZ)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			if (this.m_container == null)
			{
				return;
			}
			if (this.m_container.IsCombatGraphicMirrorX())
			{
				front.x = -front.x;
			}
			Vector3 vector = this.m_container.CombatPositionToWorldPosition(front, frontZ, false);
			bool flag = vector.x >= 0f;
			this.SetDirection((!flag) ? -1 : 1);
			if (flag)
			{
				this.m_gameObject.transform.localRotation = Quaternion.LookRotation(Vector3.forward, Vector3.Cross(Vector3.forward, vector));
			}
			else
			{
				this.m_gameObject.transform.localRotation = Quaternion.LookRotation(Vector3.forward, Vector3.Cross(vector, Vector3.forward));
			}
		}

		// Token: 0x06008A96 RID: 35478 RVA: 0x002855C4 File Offset: 0x002837C4
		public void SetCombatDirection(int dir)
		{
			if (this.m_container == null)
			{
				return;
			}
			if (this.m_container.IsCombatGraphicMirrorX())
			{
				dir = -dir;
			}
			this.SetDirection(dir);
		}

		// Token: 0x06008A97 RID: 35479 RVA: 0x002855F0 File Offset: 0x002837F0
		public void SetDirection(int dir)
		{
			if (dir == this.m_direction)
			{
				return;
			}
			this.m_direction = dir;
			if (this.m_spineInfo != null && this.m_fxInfo == null)
			{
				this.m_spineInfo.m_spine.Skeleton.FlipX = (dir > 0);
			}
			else
			{
				Vector3 localScale = this.m_gameObject.transform.localScale;
				if (dir > 0)
				{
					localScale.x = -Math.Abs(localScale.x);
				}
				else
				{
					localScale.x = Math.Abs(localScale.x);
				}
				this.m_gameObject.transform.localScale = localScale;
			}
			if (this.m_attachFxs != null)
			{
				foreach (GenericGraphic genericGraphic in this.m_attachFxs)
				{
					genericGraphic.SetDirection(this.m_direction);
				}
			}
		}

		// Token: 0x06008A98 RID: 35480 RVA: 0x002856FC File Offset: 0x002838FC
		public void SetRotationZ(float rz)
		{
			if (this.m_gameObject != null)
			{
				this.m_gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, rz);
			}
		}

		// Token: 0x06008A99 RID: 35481 RVA: 0x00285730 File Offset: 0x00283930
		public void SetRotation(Quaternion q)
		{
			if (this.m_gameObject != null)
			{
				this.m_gameObject.transform.localRotation = q;
			}
		}

		// Token: 0x06008A9A RID: 35482 RVA: 0x00285754 File Offset: 0x00283954
		public void SetPrefabScale(float scale)
		{
			this.SetPrefabScale(new Vector3(scale, scale, scale));
		}

		// Token: 0x06008A9B RID: 35483 RVA: 0x00285764 File Offset: 0x00283964
		public void SetPrefabScale(Vector3 scale)
		{
			if (this.m_prefab == null)
			{
				return;
			}
			this.m_prefabScale = scale;
			this.m_prefab.transform.localScale = new Vector3(this.m_initScale.x * scale.x, this.m_initScale.y * scale.y, this.m_initScale.z * scale.z);
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x002857D8 File Offset: 0x002839D8
		public void SetName(string name)
		{
			if (this.m_gameObject != null)
			{
				this.m_gameObject.name = name;
			}
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x002857F8 File Offset: 0x002839F8
		public void SetVisible(bool visible)
		{
			if (this.m_isVisible == visible)
			{
				return;
			}
			this.m_isVisible = visible;
			if (this.m_gameObject != null)
			{
				this.m_gameObject.SetActive(visible);
			}
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x0028582C File Offset: 0x00283A2C
		public void SetColor(Colori color)
		{
			if (color == this.m_color)
			{
				return;
			}
			this.m_color = color;
			if (this.m_spineInfo != null)
			{
				this.m_spineInfo.m_spine.Skeleton.R = (float)color.r / 255f;
				this.m_spineInfo.m_spine.Skeleton.G = (float)color.g / 255f;
				this.m_spineInfo.m_spine.Skeleton.B = (float)color.b / 255f;
				this.m_spineInfo.m_spine.Skeleton.A = (float)color.a / 255f;
			}
			else
			{
				Color color2 = new Color((float)color.r / 255f, (float)color.g / 255f, (float)color.b / 255f, (float)color.a / 255f);
				foreach (SpriteRenderer spriteRenderer in this.m_prefab.GetComponentsInChildren<SpriteRenderer>())
				{
					spriteRenderer.color = color2;
				}
			}
		}

		// Token: 0x06008A9F RID: 35487 RVA: 0x00285958 File Offset: 0x00283B58
		public void SetIntensity(float intensity)
		{
			if (intensity == this.m_intensity)
			{
				return;
			}
			this.m_intensity = intensity;
			this.UpdateMaterialPropertyBlock();
		}

		// Token: 0x06008AA0 RID: 35488 RVA: 0x00285974 File Offset: 0x00283B74
		public void SetSaturation(float saturation)
		{
			if (saturation == this.m_saturation)
			{
				return;
			}
			this.m_saturation = saturation;
			this.UpdateMaterialPropertyBlock();
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x00285990 File Offset: 0x00283B90
		private void UpdateMaterialPropertyBlock()
		{
			if (this.s_materialPropertyBlock == null)
			{
				this.s_materialPropertyBlock = new MaterialPropertyBlock();
			}
			this.s_materialPropertyBlock.Clear();
			this.s_materialPropertyBlock.SetVector("_IntensityAndSaturation", new Vector4(this.m_intensity, this.m_saturation, 0f, 0f));
			if (this.m_spineInfo != null)
			{
				Renderer component = this.m_spineInfo.m_spine.GetComponent<Renderer>();
				if (component != null)
				{
					component.SetPropertyBlock(this.s_materialPropertyBlock);
				}
			}
		}

		// Token: 0x06008AA2 RID: 35490 RVA: 0x00285A20 File Offset: 0x00283C20
		public void SetEffect(GraphicEffect e, float param1, float param2)
		{
			if (this.m_effectInfo == null)
			{
				this.m_effectInfo = new GenericGraphic.EffectInfo();
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (e == GraphicEffect.Flash)
			{
				this.FlashEffect(new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_HitFlashIntensity), (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_HitFlashTime) * 0.001f, configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_HitFlashRepeat));
			}
			else if (e == GraphicEffect.Ghost)
			{
				int count = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_ChargeGhostCount);
				float distance = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_ChargeGhostDistance) * 0.02f;
				float fade = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Combat_ChargeGhostFadeOut) * 0.01f;
				this.GhostEffect(count, distance, fade);
			}
			else if (e == GraphicEffect.Highlight_Red)
			{
				this.HighlightEffect(e, new Colori(byte.MaxValue, 0, 0, byte.MaxValue), 2f, 1f);
			}
			else if (e == GraphicEffect.Highlight_White)
			{
				this.HighlightEffect(e, new Colori(200, 200, 200, byte.MaxValue), 2f, 1f);
			}
			else if (e == GraphicEffect.FadeIn)
			{
				this.FadeInEffect(param1);
			}
			else if (e == GraphicEffect.FadeOut)
			{
				this.FadeOutEffect(param1);
			}
		}

		// Token: 0x06008AA3 RID: 35491 RVA: 0x00285B64 File Offset: 0x00283D64
		public void ClearEffect(GraphicEffect e)
		{
			if (this.m_effectInfo == null)
			{
				return;
			}
			if (e == GraphicEffect.Ghost)
			{
				this.ClearGhosts();
			}
			else
			{
				this.SetColor(new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
				this.SetIntensity(1f);
				this.SetSaturation(1f);
				this.m_effectInfo.m_type = GraphicEffect.None;
				this.m_effectInfo.m_curTime = (this.m_effectInfo.m_totalTime = 0f);
			}
		}

		// Token: 0x06008AA4 RID: 35492 RVA: 0x00285BF0 File Offset: 0x00283DF0
		public void ClearAttachFxs(int tagMask)
		{
			if (this.m_attachFxs == null)
			{
				return;
			}
			if (tagMask == -1)
			{
				foreach (GenericGraphic genericGraphic in this.m_attachFxs)
				{
					genericGraphic.DeleteMe();
				}
				this.m_attachFxs.Clear();
			}
			else
			{
				int i = 0;
				while (i < this.m_attachFxs.Count)
				{
					GenericGraphic genericGraphic2 = this.m_attachFxs[i];
					if (genericGraphic2.m_fxInfo == null || (1 << genericGraphic2.m_fxInfo.m_tag & tagMask) != 0)
					{
						this.m_attachFxs.RemoveAt(i);
						genericGraphic2.DeleteMe();
					}
					else
					{
						i++;
					}
				}
			}
		}

		// Token: 0x06008AA5 RID: 35493 RVA: 0x00285CD0 File Offset: 0x00283ED0
		public void Pause(bool pause)
		{
			if (pause == this.m_isPaused)
			{
				return;
			}
			this.m_isPaused = pause;
			if (this.m_prefab == null)
			{
				return;
			}
			if (this.m_spineInfo != null)
			{
				this.m_spineInfo.m_spine.state.TimeScale = (float)((!pause) ? 1 : 0);
			}
			else
			{
				Animator[] componentsInChildren = this.m_prefab.GetComponentsInChildren<Animator>();
				foreach (Animator animator in componentsInChildren)
				{
					animator.speed = (float)((!pause) ? 1 : 0);
				}
				UnityEngine.Animation[] componentsInChildren2 = this.m_prefab.GetComponentsInChildren<UnityEngine.Animation>();
				foreach (UnityEngine.Animation animation in componentsInChildren2)
				{
					IEnumerator enumerator = animation.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							UnityEngine.AnimationState animationState = (UnityEngine.AnimationState)obj;
							if (animation.enabled)
							{
								animationState.speed = (float)((!pause) ? 1 : 0);
							}
						}
					}
					finally
					{
						IDisposable disposable;
						if ((disposable = (enumerator as IDisposable)) != null)
						{
							disposable.Dispose();
						}
					}
				}
				ParticleSystem[] componentsInChildren3 = this.m_prefab.GetComponentsInChildren<ParticleSystem>();
				foreach (ParticleSystem particleSystem in componentsInChildren3)
				{
					if (pause)
					{
						particleSystem.Pause();
					}
					else
					{
						particleSystem.Play();
					}
				}
			}
		}

		// Token: 0x06008AA6 RID: 35494 RVA: 0x00285E60 File Offset: 0x00284060
		private void FadeStop()
		{
			if (this.m_fxInfo == null)
			{
				return;
			}
			if (this.m_prefab == null)
			{
				return;
			}
			if (this.m_fxInfo.m_stopParticleSystems != null)
			{
				this.m_fxInfo.m_stopParticleSystems.Clear();
			}
			if (this.m_fxInfo.m_stopRenderers != null)
			{
				this.m_fxInfo.m_stopRenderers.Clear();
			}
			float num = 0f;
			ParticleSystem[] componentsInChildren = this.m_prefab.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				if (particleSystem.particleCount > 1)
				{
					particleSystem.emission.enabled = false;
					num = Math.Max(num, particleSystem.main.startLifetime.constant);
					if (this.m_fxInfo.m_stopParticleSystems == null)
					{
						this.m_fxInfo.m_stopParticleSystems = new List<ParticleSystem>();
					}
					this.m_fxInfo.m_stopParticleSystems.Add(particleSystem);
				}
				else
				{
					ParticleSystemRenderer component = particleSystem.GetComponent<ParticleSystemRenderer>();
					if (component != null)
					{
						component.enabled = false;
						if (this.m_fxInfo.m_stopRenderers == null)
						{
							this.m_fxInfo.m_stopRenderers = new List<Renderer>();
						}
						this.m_fxInfo.m_stopRenderers.Add(component);
					}
				}
			}
			Renderer[] componentsInChildren2 = this.m_prefab.GetComponentsInChildren<Renderer>();
			foreach (Renderer renderer in componentsInChildren2)
			{
				if (renderer.GetType() != typeof(ParticleSystemRenderer))
				{
					renderer.enabled = false;
					if (this.m_fxInfo.m_stopRenderers == null)
					{
						this.m_fxInfo.m_stopRenderers = new List<Renderer>();
					}
					this.m_fxInfo.m_stopRenderers.Add(renderer);
				}
			}
			if (num == 0f)
			{
				this.DeleteMe();
			}
			else
			{
				this.m_fxInfo.m_lifeCountdown = num;
				this.AutoDelete(true);
			}
		}

		// Token: 0x06008AA7 RID: 35495 RVA: 0x00286068 File Offset: 0x00284268
		public void ForceUpdateSpine()
		{
			if (this.m_spineInfo != null)
			{
				this.m_spineInfo.m_spine.Update(0f);
			}
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x0028608C File Offset: 0x0028428C
		public void Tick(float dt)
		{
			if (this.m_isPaused)
			{
				return;
			}
			this.TickEffect(dt);
			this.TickFx(dt);
			this.TickAttachFx(dt);
		}

		// Token: 0x06008AA9 RID: 35497 RVA: 0x002860B0 File Offset: 0x002842B0
		public void FxStop(bool fadeOut)
		{
			if (this.m_fxInfo == null)
			{
				global::Debug.LogWarning("FxStop() on none fx");
				return;
			}
			if (fadeOut)
			{
				this.FadeStop();
			}
			else
			{
				this.DeleteMe();
			}
		}

		// Token: 0x06008AAA RID: 35498 RVA: 0x002860E0 File Offset: 0x002842E0
		private void TickEffect(float dt)
		{
			if (this.m_effectInfo == null)
			{
				return;
			}
			if (this.m_effectInfo.m_type == GraphicEffect.Flash)
			{
				if (this.m_effectInfo.m_curTime < this.m_effectInfo.m_totalTime)
				{
					this.m_effectInfo.m_curTime += dt;
					float num = Mathf.Clamp01(this.m_effectInfo.m_curTime / this.m_effectInfo.m_totalTime);
					this.SetColor(Colori.Lerp(this.m_effectInfo.m_color, new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), num));
					this.SetIntensity(Mathf.Lerp(this.m_effectInfo.m_intensity, 1f, num));
					if (num >= 1f)
					{
						this.m_effectInfo.m_curTime = 0f;
						this.m_effectInfo.m_repeatCount--;
						if (this.m_effectInfo.m_repeatCount <= 0)
						{
							this.m_effectInfo.m_type = GraphicEffect.None;
						}
					}
				}
			}
			else if (this.m_effectInfo.m_type == GraphicEffect.Highlight_Red || this.m_effectInfo.m_type == GraphicEffect.Highlight_White)
			{
				this.m_effectInfo.m_curTime += dt;
				float t = (float)Math.Sin((double)(this.m_effectInfo.m_curTime / this.m_effectInfo.m_totalTime) * 3.1415926535897931 * 2.0) * 0.5f + 0.5f;
				this.SetColor(Colori.Lerp(new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), this.m_effectInfo.m_color, t));
				this.SetIntensity(Mathf.Lerp(1f, this.m_effectInfo.m_intensity, t));
			}
			else if (this.m_effectInfo.m_type == GraphicEffect.FadeIn)
			{
				if (this.m_effectInfo.m_curTime < this.m_effectInfo.m_totalTime)
				{
					this.m_effectInfo.m_curTime += dt;
					float num2 = Mathf.Clamp01(this.m_effectInfo.m_curTime / this.m_effectInfo.m_totalTime);
					this.SetColor(new Colori(byte.MaxValue, byte.MaxValue, 225, (byte)(num2 * 255f)));
					if (num2 >= 1f)
					{
						this.m_effectInfo.m_type = GraphicEffect.None;
					}
				}
			}
			else if (this.m_effectInfo.m_type == GraphicEffect.FadeOut && this.m_effectInfo.m_curTime < this.m_effectInfo.m_totalTime)
			{
				this.m_effectInfo.m_curTime += dt;
				float num3 = Mathf.Clamp01(this.m_effectInfo.m_curTime / this.m_effectInfo.m_totalTime);
				this.SetColor(new Colori(byte.MaxValue, byte.MaxValue, 225, (byte)(255f - num3 * 255f)));
				if (num3 >= 1f)
				{
					this.m_effectInfo.m_type = GraphicEffect.None;
					this.SetVisible(false);
				}
			}
			if (this.m_effectInfo.m_ghosts != null)
			{
				for (int i = 0; i < this.m_effectInfo.m_ghosts.Count; i++)
				{
					GenericGraphic.Ghost ghost = this.m_effectInfo.m_ghosts[i];
					Vector2 vector = ghost.m_fx.GetPosition();
					Vector2 vector2;
					int direction;
					if (i == 0)
					{
						vector2 = this.GetPosition();
						direction = this.m_direction;
					}
					else
					{
						vector2 = this.m_effectInfo.m_ghosts[i - 1].m_fx.GetPosition();
						direction = this.m_effectInfo.m_ghosts[i - 1].m_fx.m_direction;
					}
					if (ghost.m_state == 2)
					{
						vector2 = ghost.m_targetPosition;
					}
					Vector2 a = vector2 - vector;
					float magnitude = a.magnitude;
					Vector2 vector3 = vector;
					if (ghost.m_state == 0)
					{
						if (magnitude > this.m_effectInfo.m_ghostDistance)
						{
							vector3 = vector + a * ((magnitude - this.m_effectInfo.m_ghostDistance) / magnitude);
							ghost.m_state = 1;
							ghost.m_followStartPosition = vector3;
							ghost.m_followTime = 0f;
						}
					}
					else if (ghost.m_state == 1)
					{
						if (magnitude > 0f)
						{
							vector3 = vector + a * ((magnitude - this.m_effectInfo.m_ghostDistance) / magnitude);
						}
						if (ghost.m_fx.m_direction != direction)
						{
							ghost.m_targetPosition = vector2;
							ghost.m_state = 2;
							ghost.m_speed = Vector2.Distance(vector3, ghost.m_followStartPosition) / ghost.m_followTime;
							ghost.m_turnCount++;
						}
						else
						{
							ghost.m_followTime += dt;
						}
					}
					else if (ghost.m_state == 2)
					{
						float num4 = ghost.m_speed * dt;
						if (num4 < magnitude)
						{
							vector3 = Vector2.MoveTowards(vector, vector2, num4);
						}
						else
						{
							vector3 = vector2;
							ghost.m_fx.SetDirection(direction);
							if (ghost.m_turnCount <= 1)
							{
								ghost.m_state = 0;
							}
							else
							{
								ghost.m_fx.SetVisible(false);
							}
						}
					}
					ghost.m_fx.SetPosition(new Vector3(vector3.x, vector3.y, ghost.m_fx.GetPosition().z));
				}
			}
		}

		// Token: 0x06008AAB RID: 35499 RVA: 0x00286688 File Offset: 0x00284888
		private void TickFx(float dt)
		{
			if (this.m_fxInfo == null)
			{
				return;
			}
			if (this.m_fxInfo.m_lifeCountdown > 0f)
			{
				this.m_fxInfo.m_lifeCountdown -= dt;
				if (this.m_fxInfo.m_lifeCountdown <= 0f)
				{
					this.m_fxInfo.m_lifeCountdown = 0f;
					if (this.m_fxInfo.m_isAutoDelete)
					{
						this.DeleteMe();
					}
				}
			}
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x00286704 File Offset: 0x00284904
		public bool IsFxLifeEnd()
		{
			return this.m_fxInfo != null && this.m_fxInfo.m_lifeCountdown <= 0f && !this.m_fxInfo.m_initLoop;
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x0028673C File Offset: 0x0028493C
		private void TickAttachFx(float dt)
		{
			if (this.m_attachFxs == null)
			{
				return;
			}
			int i = 0;
			while (i < this.m_attachFxs.Count)
			{
				GenericGraphic genericGraphic = this.m_attachFxs[i];
				GenericGraphic.FxInfo fxInfo = genericGraphic.m_fxInfo;
				if (fxInfo != null)
				{
					if (fxInfo.m_lifeCountdown <= 0f && !fxInfo.m_initLoop)
					{
						this.m_attachFxs.RemoveAt(i);
						genericGraphic.DeleteMe();
					}
					else
					{
						if (fxInfo.m_attachBone != null)
						{
							Vector3 worldPosition = this.m_prefab.transform.TransformPoint(new Vector3(fxInfo.m_attachBone.WorldX, fxInfo.m_attachBone.WorldY, 0f));
							worldPosition.y += fxInfo.m_yOffset;
							worldPosition.z -= 0.1f;
							genericGraphic.SetWorldPosition(worldPosition);
						}
						i++;
					}
				}
			}
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x00286828 File Offset: 0x00284A28
		public void SetPosition(Vector3 p)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			this.m_gameObject.transform.localPosition = p;
			this.CheckIsCulled(p, false);
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x00286858 File Offset: 0x00284A58
		public Vector3 GetPosition()
		{
			if (this.m_gameObject == null)
			{
				return Vector3.zero;
			}
			return this.m_gameObject.transform.localPosition;
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x00286884 File Offset: 0x00284A84
		public void SetAnchoredPosition(Vector3 p)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			RectTransform rectTransform = this.m_gameObject.transform as RectTransform;
			if (rectTransform != null)
			{
				rectTransform.anchoredPosition3D = p;
			}
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x002868C8 File Offset: 0x00284AC8
		private void SetWorldPosition(Vector3 p)
		{
			if (this.m_gameObject == null)
			{
				return;
			}
			this.m_gameObject.transform.position = p;
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x002868F0 File Offset: 0x00284AF0
		private Vector3 GetWorldPosition()
		{
			if (this.m_gameObject == null)
			{
				return Vector3.zero;
			}
			return this.m_gameObject.transform.position;
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x0028691C File Offset: 0x00284B1C
		private void CheckIsCulled(Vector3 p, bool isCombat)
		{
			if (this.m_container == null)
			{
				return;
			}
			if (this.m_spineInfo != null)
			{
				float num = this.m_prefabScale.x * 1.5f;
				float num2 = this.m_prefabScale.y * 1.5f;
				Vector2 bmin;
				Vector2 bmax;
				if (!this.m_spineInfo.m_spine.Skeleton.FlipX)
				{
					bmin.x = p.x + this.m_spineInfo.m_boundsMin.x * num;
					bmin.y = p.y + this.m_spineInfo.m_boundsMin.y * num2;
					bmax.x = p.x + this.m_spineInfo.m_boundsMax.x * num;
					bmax.y = p.y + this.m_spineInfo.m_boundsMax.y * num2;
				}
				else
				{
					bmin.x = p.x - this.m_spineInfo.m_boundsMax.x * num;
					bmin.y = p.y + this.m_spineInfo.m_boundsMin.y * num2;
					bmax.x = p.x - this.m_spineInfo.m_boundsMin.x * num;
					bmax.y = p.y + this.m_spineInfo.m_boundsMax.y * num2;
				}
				this.m_spineInfo.m_isCulled = this.m_container.IsCulled(bmin, bmax, isCombat);
				this.m_spineInfo.m_spine.SetCulled(this.m_spineInfo.m_isCulled);
			}
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x00286AC0 File Offset: 0x00284CC0
		public bool IsCulled()
		{
			return this.m_spineInfo != null && this.m_spineInfo.m_isCulled;
		}

		// Token: 0x06008AB5 RID: 35509 RVA: 0x00286ADC File Offset: 0x00284CDC
		public bool IsVisible()
		{
			return this.m_isVisible;
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x00286AE4 File Offset: 0x00284CE4
		private void FlashEffect(Colori color, float intensity, float time, int repeat)
		{
			if (this.m_effectInfo == null)
			{
				return;
			}
			this.m_effectInfo.m_color = color;
			this.m_effectInfo.m_intensity = intensity;
			this.m_effectInfo.m_curTime = 0f;
			this.m_effectInfo.m_totalTime = time;
			this.m_effectInfo.m_repeatCount = repeat;
			this.m_effectInfo.m_type = GraphicEffect.Flash;
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x00286B4C File Offset: 0x00284D4C
		private void GhostEffect(int count, float distance, float fade)
		{
			if (this.m_effectInfo == null)
			{
				return;
			}
			if (this.m_fxPlayer == null)
			{
				return;
			}
			this.ClearGhosts();
			if (this.m_effectInfo.m_ghosts == null)
			{
				this.m_effectInfo.m_ghosts = new List<GenericGraphic.Ghost>();
			}
			this.m_effectInfo.m_ghostDistance = distance;
			float num = 1f;
			Vector3 position = this.GetPosition();
			for (int i = 0; i < count; i++)
			{
				num -= fade;
				if (num <= 0f)
				{
					break;
				}
				GenericGraphic genericGraphic = this.m_fxPlayer.Play(this.m_assetName);
				if (genericGraphic != null)
				{
					genericGraphic.SetContainer(this.m_container);
					if (this.m_gameObject.transform.parent != null)
					{
						genericGraphic.SetParent(this.m_gameObject.transform.parent.gameObject);
					}
					genericGraphic.AutoDelete(false);
					genericGraphic.SetPosition(new Vector3(position.x, position.y, position.z + (float)(i + 1) * 0.01f));
					genericGraphic.SetDirection(this.m_direction);
					genericGraphic.SetPrefabScale(this.m_prefabScale);
					genericGraphic.SetColor(new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, (byte)(num * 255f)));
					if (this.m_spineInfo.m_spine != null)
					{
						genericGraphic.PlayAnimation(this.m_spineInfo.m_spine.AnimationName, this.m_spineInfo.m_isAnimationLoop);
					}
					GenericGraphic.Ghost ghost = new GenericGraphic.Ghost();
					ghost.m_fx = genericGraphic;
					this.m_effectInfo.m_ghosts.Add(ghost);
				}
			}
		}

		// Token: 0x06008AB8 RID: 35512 RVA: 0x00286CFC File Offset: 0x00284EFC
		public void ClearGhosts()
		{
			if (this.m_effectInfo == null)
			{
				return;
			}
			if (this.m_effectInfo.m_ghosts == null)
			{
				return;
			}
			foreach (GenericGraphic.Ghost ghost in this.m_effectInfo.m_ghosts)
			{
				ghost.m_fx.DeleteMe();
			}
			this.m_effectInfo.m_ghosts.Clear();
		}

		// Token: 0x06008AB9 RID: 35513 RVA: 0x00286D90 File Offset: 0x00284F90
		private void HighlightEffect(GraphicEffect effectType, Colori color, float intensity, float time)
		{
			if (this.m_effectInfo == null)
			{
				return;
			}
			this.m_effectInfo.m_color = color;
			this.m_effectInfo.m_intensity = intensity;
			this.m_effectInfo.m_totalTime = time;
			this.m_effectInfo.m_curTime = 0f;
			this.m_effectInfo.m_type = effectType;
		}

		// Token: 0x06008ABA RID: 35514 RVA: 0x00286DEC File Offset: 0x00284FEC
		private void FadeInEffect(float time)
		{
			if (this.m_effectInfo == null)
			{
				return;
			}
			this.m_effectInfo.m_curTime = 0f;
			this.m_effectInfo.m_totalTime = time;
			this.m_effectInfo.m_type = GraphicEffect.FadeIn;
			this.SetVisible(true);
			this.SetColor(new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0));
		}

		// Token: 0x06008ABB RID: 35515 RVA: 0x00286E50 File Offset: 0x00285050
		private void FadeOutEffect(float time)
		{
			if (this.m_effectInfo == null)
			{
				return;
			}
			this.m_effectInfo.m_curTime = 0f;
			this.m_effectInfo.m_totalTime = time;
			this.m_effectInfo.m_type = GraphicEffect.FadeOut;
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x00286E88 File Offset: 0x00285088
		public void AutoDelete(bool autoDelete)
		{
			if (this.m_fxInfo == null)
			{
				global::Debug.LogWarning("AutoDelete() on none fx");
				return;
			}
			this.m_fxInfo.m_isAutoDelete = autoDelete;
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x00286EAC File Offset: 0x002850AC
		public void DeleteMe()
		{
			if (this.m_fxInfo == null)
			{
				global::Debug.LogWarning("DeleteMe() on none fx");
				return;
			}
			this.m_fxInfo.m_isDeleteMe = true;
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06008ABE RID: 35518 RVA: 0x00286ED0 File Offset: 0x002850D0
		public string AssetName
		{
			get
			{
				return this.m_assetName;
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06008ABF RID: 35519 RVA: 0x00286ED8 File Offset: 0x002850D8
		public bool IsDeleteMe
		{
			get
			{
				return this.m_fxInfo != null && this.m_fxInfo.m_isDeleteMe;
			}
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06008AC0 RID: 35520 RVA: 0x00286EF8 File Offset: 0x002850F8
		public bool IsAutoDelete
		{
			get
			{
				return this.m_fxInfo != null && this.m_fxInfo.m_isAutoDelete;
			}
		}

		// Token: 0x040062A2 RID: 25250
		private IGenericGraphicContainer m_container;

		// Token: 0x040062A3 RID: 25251
		private FxPlayer m_fxPlayer;

		// Token: 0x040062A4 RID: 25252
		private GameObject m_gameObject;

		// Token: 0x040062A5 RID: 25253
		private GameObject m_prefab;

		// Token: 0x040062A6 RID: 25254
		private Animator m_animator;

		// Token: 0x040062A7 RID: 25255
		private int m_animatorTriggerNameId;

		// Token: 0x040062A8 RID: 25256
		private string m_assetName;

		// Token: 0x040062A9 RID: 25257
		private Vector3 m_initScale;

		// Token: 0x040062AA RID: 25258
		private Vector3 m_prefabScale;

		// Token: 0x040062AB RID: 25259
		private int m_direction;

		// Token: 0x040062AC RID: 25260
		private int m_layer;

		// Token: 0x040062AD RID: 25261
		private int m_sortingOrder;

		// Token: 0x040062AE RID: 25262
		private Colori m_color = new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x040062AF RID: 25263
		private float m_intensity = 1f;

		// Token: 0x040062B0 RID: 25264
		private float m_saturation = 1f;

		// Token: 0x040062B1 RID: 25265
		private bool m_isPaused;

		// Token: 0x040062B2 RID: 25266
		private bool m_isVisible;

		// Token: 0x040062B3 RID: 25267
		private GenericGraphic.SpineInfo m_spineInfo;

		// Token: 0x040062B4 RID: 25268
		private GenericGraphic.FxInfo m_fxInfo;

		// Token: 0x040062B5 RID: 25269
		private GenericGraphic.EffectInfo m_effectInfo;

		// Token: 0x040062B6 RID: 25270
		private List<GenericGraphic> m_attachFxs;

		// Token: 0x040062B7 RID: 25271
		private MaterialPropertyBlock s_materialPropertyBlock;

		// Token: 0x02000977 RID: 2423
		[CustomLuaClass]
		public class SpineInfo
		{
			// Token: 0x040062B8 RID: 25272
			public SkeletonAnimation m_spine;

			// Token: 0x040062B9 RID: 25273
			public string m_initAnimationName;

			// Token: 0x040062BA RID: 25274
			public bool m_isAnimationLoop;

			// Token: 0x040062BB RID: 25275
			public Vector2 m_boundsMin;

			// Token: 0x040062BC RID: 25276
			public Vector2 m_boundsMax;

			// Token: 0x040062BD RID: 25277
			public bool m_isCulled;

			// Token: 0x040062BE RID: 25278
			public float m_height;

			// Token: 0x040062BF RID: 25279
			public float m_footHeight;

			// Token: 0x040062C0 RID: 25280
			public List<ReplaceAnim> m_replaceAnims;
		}

		// Token: 0x02000978 RID: 2424
		[CustomLuaClass]
		public class FxInfo
		{
			// Token: 0x040062C1 RID: 25281
			public FxDesc m_fxDesc;

			// Token: 0x040062C2 RID: 25282
			public float m_initLife;

			// Token: 0x040062C3 RID: 25283
			public float m_lifeCountdown;

			// Token: 0x040062C4 RID: 25284
			public bool m_initLoop;

			// Token: 0x040062C5 RID: 25285
			public bool m_isDeleteMe;

			// Token: 0x040062C6 RID: 25286
			public bool m_isAutoDelete;

			// Token: 0x040062C7 RID: 25287
			public int m_tag;

			// Token: 0x040062C8 RID: 25288
			public List<ParticleSystem> m_stopParticleSystems;

			// Token: 0x040062C9 RID: 25289
			public List<Renderer> m_stopRenderers;

			// Token: 0x040062CA RID: 25290
			public TrailRenderer[] m_trailRenderers;

			// Token: 0x040062CB RID: 25291
			public Bone m_attachBone;

			// Token: 0x040062CC RID: 25292
			public float m_yOffset;
		}

		// Token: 0x02000979 RID: 2425
		[CustomLuaClass]
		public class Ghost
		{
			// Token: 0x040062CD RID: 25293
			public float m_speed;

			// Token: 0x040062CE RID: 25294
			public float m_followTime;

			// Token: 0x040062CF RID: 25295
			public Vector2 m_followStartPosition;

			// Token: 0x040062D0 RID: 25296
			public int m_state;

			// Token: 0x040062D1 RID: 25297
			public int m_turnCount;

			// Token: 0x040062D2 RID: 25298
			public Vector2 m_targetPosition;

			// Token: 0x040062D3 RID: 25299
			public GenericGraphic m_fx;
		}

		// Token: 0x0200097A RID: 2426
		[CustomLuaClass]
		public class EffectInfo
		{
			// Token: 0x040062D4 RID: 25300
			public Colori m_color;

			// Token: 0x040062D5 RID: 25301
			public float m_intensity;

			// Token: 0x040062D6 RID: 25302
			public float m_totalTime;

			// Token: 0x040062D7 RID: 25303
			public float m_curTime;

			// Token: 0x040062D8 RID: 25304
			public int m_repeatCount;

			// Token: 0x040062D9 RID: 25305
			public GraphicEffect m_type;

			// Token: 0x040062DA RID: 25306
			public float m_ghostDistance;

			// Token: 0x040062DB RID: 25307
			public List<GenericGraphic.Ghost> m_ghosts;
		}
	}
}
