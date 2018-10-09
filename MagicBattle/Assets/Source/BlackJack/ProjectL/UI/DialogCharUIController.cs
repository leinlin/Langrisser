using System;
using System.Collections;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C17 RID: 3095
	[HotFix]
	public class DialogCharUIController : UIControllerBase
	{
		// Token: 0x0600D9D0 RID: 55760 RVA: 0x003B1B38 File Offset: 0x003AFD38
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			this.m_uiStateController = base.GetComponent<CommonUIStateController>();
			this.m_image = Utility.FindChildComponent<Image>(base.gameObject, "Image", false);
		}

		// Token: 0x0600D9D1 RID: 55761 RVA: 0x003B1BC4 File Offset: 0x003AFDC4
		private void OnDisable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisable_hotfix != null)
			{
				this.m_OnDisable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic();
		}

		// Token: 0x0600D9D2 RID: 55762 RVA: 0x003B1C2C File Offset: 0x003AFE2C
		public void CreateGraphic(ConfigDataCharImageInfo charImageInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGraphicConfigDataCharImageInfo_hotfix != null)
			{
				this.m_CreateGraphicConfigDataCharImageInfo_hotfix.call(new object[]
				{
					this,
					charImageInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic();
			if (charImageInfo == null)
			{
				return;
			}
			this.m_charImageInfo = charImageInfo;
			if (!string.IsNullOrEmpty(charImageInfo.Spine))
			{
				this.m_spineGraphic = new UISpineGraphic();
				this.m_spineGraphic.Create(charImageInfo.Spine);
				this.m_spineGraphic.SetRectTransformSize(new Vector2(1000f, 2000f));
				this.m_spineGraphic.SetParent(base.gameObject);
				this.m_spineGraphic.StopAnimation(0);
			}
			else if (!string.IsNullOrEmpty(charImageInfo.Image) && this.m_image != null)
			{
				this.m_image.sprite = AssetUtility.Instance.GetSprite(charImageInfo.Image);
				this.m_image.gameObject.SetActive(this.m_image.sprite != null);
			}
			this.m_tweenColor = (this.m_curColor = Color.white);
			this.m_tweenColorTime = 0f;
		}

		// Token: 0x0600D9D3 RID: 55763 RVA: 0x003B1D98 File Offset: 0x003AFF98
		public void DestroyGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyGraphic_hotfix != null)
			{
				this.m_DestroyGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.Destroy();
				this.m_spineGraphic = null;
			}
			if (this.m_image != null)
			{
				this.m_image.gameObject.SetActive(false);
			}
			this.m_charImageInfo = null;
		}

		// Token: 0x0600D9D4 RID: 55764 RVA: 0x003B1E40 File Offset: 0x003B0040
		public void SetScaleOffet(float scale, float yOffset)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetScaleOffetSingleSingle_hotfix != null)
			{
				this.m_SetScaleOffetSingleSingle_hotfix.call(new object[]
				{
					this,
					scale,
					yOffset
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.SetScale(scale);
				this.m_spineGraphic.SetPosition(new Vector3(0f, yOffset, 0f));
			}
		}

		// Token: 0x0600D9D5 RID: 55765 RVA: 0x003B1EF8 File Offset: 0x003B00F8
		public void SetDirection(int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDirectionInt32_hotfix != null)
			{
				this.m_SetDirectionInt32_hotfix.call(new object[]
				{
					this,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.SetDirection(dir);
			}
			else if (this.m_image != null)
			{
				Vector3 localScale = this.m_image.transform.localScale;
				if (dir > 0)
				{
					localScale.x = -Mathf.Abs(localScale.x);
				}
				else
				{
					localScale.x = Mathf.Abs(localScale.x);
				}
				this.m_image.transform.localScale = localScale;
			}
		}

		// Token: 0x0600D9D6 RID: 55766 RVA: 0x003B1FEC File Offset: 0x003B01EC
		public void SetColor(Color c)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetColorColor_hotfix != null)
			{
				this.m_SetColorColor_hotfix.call(new object[]
				{
					this,
					c
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_tweenColor = c;
			this.m_curColor = c;
			this.m_tweenColorTime = 0f;
		}

		// Token: 0x0600D9D7 RID: 55767 RVA: 0x003B2078 File Offset: 0x003B0278
		public void TweenColor(Color c, float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TweenColorColorSingle_hotfix != null)
			{
				this.m_TweenColorColorSingle_hotfix.call(new object[]
				{
					this,
					c,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (time > 0f)
			{
				this.m_tweenColor = c;
				this.m_tweenColorTime = time;
			}
			else
			{
				this.SetColor(c);
			}
		}

		// Token: 0x0600D9D8 RID: 55768 RVA: 0x003B2120 File Offset: 0x003B0320
		public ConfigDataCharImageInfo GetCharImageInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCharImageInfo_hotfix != null)
			{
				return (ConfigDataCharImageInfo)this.m_GetCharImageInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_charImageInfo;
		}

		// Token: 0x0600D9D9 RID: 55769 RVA: 0x003B2194 File Offset: 0x003B0394
		public void StartFacialAnimation(float voiceTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartFacialAnimationSingle_hotfix != null)
			{
				this.m_StartFacialAnimationSingle_hotfix.call(new object[]
				{
					this,
					voiceTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_voiceTime = voiceTime;
			this.PlayMouthAnimation(this.m_idleFacialAnimationName);
			this.SetNextBlinkTime();
		}

		// Token: 0x0600D9DA RID: 55770 RVA: 0x003B2220 File Offset: 0x003B0420
		public void Enter(int enterType, Action onEndAction = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnterInt32Action_hotfix != null)
			{
				this.m_EnterInt32Action_hotfix.call(new object[]
				{
					this,
					enterType,
					onEndAction
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			if (enterType == 1)
			{
				if (this.m_uiStateController != null)
				{
					UIUtility.SetUIStateOpen(this.m_uiStateController, "In", onEndAction, false, true);
				}
			}
			else if (enterType == 2)
			{
				if (this.m_uiStateController != null)
				{
					UIUtility.SetUIStateOpen(this.m_uiStateController, "In", onEndAction, false, true);
				}
			}
			else if (enterType == 11)
			{
				base.StartCoroutine(this.Co_TweenColor(new Color(1f, 1f, 1f, 0f), Color.white, 0.5f, onEndAction));
			}
			else if (enterType == 12)
			{
				base.StartCoroutine(this.Co_TweenColor(new Color(0f, 0f, 0f, 1f), Color.white, 0.5f, onEndAction));
			}
			else
			{
				global::Debug.LogError("Don't have this EnterType!");
				if (onEndAction != null)
				{
					onEndAction();
				}
			}
		}

		// Token: 0x0600D9DB RID: 55771 RVA: 0x003B23A0 File Offset: 0x003B05A0
		public void Leave(int leaveType, Action onEndAction = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LeaveInt32Action_hotfix != null)
			{
				this.m_LeaveInt32Action_hotfix.call(new object[]
				{
					this,
					leaveType,
					onEndAction
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			if (leaveType == 1)
			{
				if (this.m_uiStateController != null)
				{
					UIUtility.SetUIStateClose(this.m_uiStateController, "Out", onEndAction, false, true);
				}
			}
			else if (leaveType == 2)
			{
				if (this.m_uiStateController != null)
				{
					UIUtility.SetUIStateClose(this.m_uiStateController, "Out", onEndAction, false, true);
				}
			}
			else if (leaveType == 11)
			{
				base.StartCoroutine(this.Co_TweenColor(this.m_curColor, new Color(this.m_curColor.r, this.m_curColor.g, this.m_curColor.b, 0f), 0.5f, onEndAction));
			}
			else if (leaveType == 12)
			{
				base.StartCoroutine(this.Co_TweenColor(this.m_curColor, new Color(0f, 0f, 0f, 1f), 0.5f, onEndAction));
			}
			else
			{
				global::Debug.LogError("Don't have this LeaveType!");
				if (onEndAction != null)
				{
					onEndAction();
				}
			}
		}

		// Token: 0x0600D9DC RID: 55772 RVA: 0x003B2534 File Offset: 0x003B0734
		[DebuggerHidden]
		private IEnumerator Co_TweenColor(Color fromColor, Color toColor, float time, Action onEndAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_TweenColorColorColorSingleAction_hotfix != null)
			{
				return (IEnumerator)this.m_Co_TweenColorColorColorSingleAction_hotfix.call(new object[]
				{
					this,
					fromColor,
					toColor,
					time,
					onEndAction
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogCharUIController.<Co_TweenColor>c__Iterator0 <Co_TweenColor>c__Iterator = new DialogCharUIController.<Co_TweenColor>c__Iterator0();
			<Co_TweenColor>c__Iterator.fromColor = fromColor;
			<Co_TweenColor>c__Iterator.toColor = toColor;
			<Co_TweenColor>c__Iterator.time = time;
			<Co_TweenColor>c__Iterator.onEndAction = onEndAction;
			<Co_TweenColor>c__Iterator.$this = this;
			return <Co_TweenColor>c__Iterator;
		}

		// Token: 0x0600D9DD RID: 55773 RVA: 0x003B260C File Offset: 0x003B080C
		public void SetAnimation(string preAnimation, string preFacialAnimation, string idleAnimation, string idleFacialAnimation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAnimationStringStringStringString_hotfix != null)
			{
				this.m_SetAnimationStringStringStringString_hotfix.call(new object[]
				{
					this,
					preAnimation,
					preFacialAnimation,
					idleAnimation,
					idleFacialAnimation
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_idleAnimationName = idleAnimation;
			this.m_idleFacialAnimationName = idleFacialAnimation;
			string text = string.Empty;
			if (!string.IsNullOrEmpty(preAnimation))
			{
				this.PlayAnimation(preAnimation, false, 0);
				text = preFacialAnimation;
				this.m_isPlayingPreAnimation = true;
			}
			else
			{
				this.PlayAnimation(idleAnimation, true, 0);
				text = idleFacialAnimation;
				this.m_isPlayingPreAnimation = false;
			}
			if (!string.IsNullOrEmpty(text))
			{
				this.PlayEyeStillAnimation(text);
				this.PlayMouthStillAnimation(text);
			}
			else
			{
				this.StopAnimation(1);
				this.StopAnimation(2);
				this.m_isPlayingEyeAnimation = (this.m_isPlayingMouthAnimation = false);
			}
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.ForceUpdate();
			}
			this.m_blinkTime = 0f;
		}

		// Token: 0x0600D9DE RID: 55774 RVA: 0x003B2754 File Offset: 0x003B0954
		public void StopMouthAnimation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopMouthAnimation_hotfix != null)
			{
				this.m_StopMouthAnimation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isPlayingMouthAnimation)
			{
				this.PlayMouthStillAnimation(this.m_idleFacialAnimationName);
			}
		}

		// Token: 0x0600D9DF RID: 55775 RVA: 0x003B27CC File Offset: 0x003B09CC
		private void SetNextBlinkTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNextBlinkTime_hotfix != null)
			{
				this.m_SetNextBlinkTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_blinkTime = (float)UnityEngine.Random.Range(1, 5);
		}

		// Token: 0x0600D9E0 RID: 55776 RVA: 0x003B283C File Offset: 0x003B0A3C
		public float GetAnimationDuration(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAnimationDurationString_hotfix != null)
			{
				return Convert.ToSingle(this.m_GetAnimationDurationString_hotfix.call(new object[]
				{
					this,
					name
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				return this.m_spineGraphic.GetAnimationDuration(name);
			}
			return 0f;
		}

		// Token: 0x0600D9E1 RID: 55777 RVA: 0x003B28D8 File Offset: 0x003B0AD8
		private void PlayAnimation(string name, bool loop, int trackIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationStringBooleanInt32_hotfix != null)
			{
				this.m_PlayAnimationStringBooleanInt32_hotfix.call(new object[]
				{
					this,
					name,
					loop,
					trackIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.PlayAnimation(name, loop, trackIndex);
			}
		}

		// Token: 0x0600D9E2 RID: 55778 RVA: 0x003B2984 File Offset: 0x003B0B84
		private void StopAnimation(int trackIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopAnimationInt32_hotfix != null)
			{
				this.m_StopAnimationInt32_hotfix.call(new object[]
				{
					this,
					trackIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.StopAnimation(trackIndex);
			}
		}

		// Token: 0x0600D9E3 RID: 55779 RVA: 0x003B2A0C File Offset: 0x003B0C0C
		private void LateUpdate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LateUpdate_hotfix != null)
			{
				this.m_LateUpdate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			if (this.m_tweenColorTime > 0f)
			{
				float maxDelta = unscaledDeltaTime / this.m_tweenColorTime;
				this.m_curColor.r = Mathf.MoveTowards(this.m_curColor.r, this.m_tweenColor.r, maxDelta);
				this.m_curColor.g = Mathf.MoveTowards(this.m_curColor.g, this.m_tweenColor.g, maxDelta);
				this.m_curColor.b = Mathf.MoveTowards(this.m_curColor.b, this.m_tweenColor.b, maxDelta);
				this.m_curColor.a = Mathf.MoveTowards(this.m_curColor.a, this.m_tweenColor.a, maxDelta);
			}
			if (this.m_spineGraphic != null)
			{
				if (this.m_isPlayingPreAnimation && !this.m_spineGraphic.IsPlayAnimation(0))
				{
					this.PlayAnimation(this.m_idleAnimationName, true, 0);
					this.PlayEyeStillAnimation(this.m_idleFacialAnimationName);
					this.PlayMouthStillAnimation(this.m_idleFacialAnimationName);
					this.m_isPlayingPreAnimation = false;
				}
				if (this.m_voiceTime > 0f)
				{
					this.m_voiceTime -= unscaledDeltaTime;
					if (this.m_voiceTime <= 0f)
					{
						this.m_voiceTime = 0f;
						this.StopMouthAnimation();
					}
				}
				if (this.m_blinkTime > 0f)
				{
					this.m_blinkTime -= unscaledDeltaTime;
					if (this.m_blinkTime <= 0f)
					{
						this.PlayEyeAnimation(this.m_idleFacialAnimationName);
						this.SetNextBlinkTime();
					}
				}
				if (this.m_isPlayingEyeAnimation && !this.m_spineGraphic.IsPlayAnimation(1))
				{
					this.PlayEyeStillAnimation(this.m_idleFacialAnimationName);
				}
				this.m_spineGraphic.SetColor(this.m_curColor);
				if (Time.timeScale > 0f)
				{
					this.m_spineGraphic.SetAnimationSpeed(1f / Time.timeScale);
				}
			}
			else if (this.m_image != null)
			{
				this.m_image.color = this.m_curColor;
			}
		}

		// Token: 0x0600D9E4 RID: 55780 RVA: 0x003B2C80 File Offset: 0x003B0E80
		private void PlayEyeAnimation(string facialAnimation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayEyeAnimationString_hotfix != null)
			{
				this.m_PlayEyeAnimationString_hotfix.call(new object[]
				{
					this,
					facialAnimation
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null && !string.IsNullOrEmpty(facialAnimation))
			{
				this.StopAnimation(1);
				this.PlayAnimation(facialAnimation + "_eye", false, 1);
				this.m_isPlayingEyeAnimation = true;
			}
		}

		// Token: 0x0600D9E5 RID: 55781 RVA: 0x003B2D28 File Offset: 0x003B0F28
		private void PlayEyeStillAnimation(string facialAnimation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayEyeStillAnimationString_hotfix != null)
			{
				this.m_PlayEyeStillAnimationString_hotfix.call(new object[]
				{
					this,
					facialAnimation
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null && !string.IsNullOrEmpty(facialAnimation))
			{
				this.StopAnimation(1);
				this.PlayAnimation(facialAnimation + "_eye_still", true, 1);
				this.m_spineGraphic.ForceUpdate();
				this.m_isPlayingEyeAnimation = false;
			}
		}

		// Token: 0x0600D9E6 RID: 55782 RVA: 0x003B2DDC File Offset: 0x003B0FDC
		private void PlayMouthAnimation(string facialAnimation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayMouthAnimationString_hotfix != null)
			{
				this.m_PlayMouthAnimationString_hotfix.call(new object[]
				{
					this,
					facialAnimation
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null && !string.IsNullOrEmpty(facialAnimation))
			{
				this.StopAnimation(2);
				this.PlayAnimation(facialAnimation + "_mouth", true, 2);
				this.m_isPlayingMouthAnimation = true;
			}
		}

		// Token: 0x0600D9E7 RID: 55783 RVA: 0x003B2E84 File Offset: 0x003B1084
		private void PlayMouthStillAnimation(string facialAnimation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayMouthStillAnimationString_hotfix != null)
			{
				this.m_PlayMouthStillAnimationString_hotfix.call(new object[]
				{
					this,
					facialAnimation
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null && !string.IsNullOrEmpty(facialAnimation))
			{
				this.StopAnimation(2);
				this.PlayAnimation(facialAnimation + "_mouth_still", true, 2);
				this.m_spineGraphic.ForceUpdate();
				this.m_isPlayingMouthAnimation = false;
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x0600D9E8 RID: 55784 RVA: 0x003B2F38 File Offset: 0x003B1138
		// (set) Token: 0x0600D9E9 RID: 55785 RVA: 0x003B2F58 File Offset: 0x003B1158
		[DoNotToLua]
		public new DialogCharUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DialogCharUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D9EA RID: 55786 RVA: 0x003B2F64 File Offset: 0x003B1164
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D9EB RID: 55787 RVA: 0x003B2F70 File Offset: 0x003B1170
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D9EC RID: 55788 RVA: 0x003B2F78 File Offset: 0x003B1178
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D9ED RID: 55789 RVA: 0x003B2F80 File Offset: 0x003B1180
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D9EE RID: 55790 RVA: 0x003B2F94 File Offset: 0x003B1194
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D9EF RID: 55791 RVA: 0x003B2F9C File Offset: 0x003B119C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D9F0 RID: 55792 RVA: 0x003B2FA8 File Offset: 0x003B11A8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D9F1 RID: 55793 RVA: 0x003B2FB4 File Offset: 0x003B11B4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D9F2 RID: 55794 RVA: 0x003B2FC0 File Offset: 0x003B11C0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D9F3 RID: 55795 RVA: 0x003B2FCC File Offset: 0x003B11CC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D9F4 RID: 55796 RVA: 0x003B2FD8 File Offset: 0x003B11D8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D9F5 RID: 55797 RVA: 0x003B2FE4 File Offset: 0x003B11E4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D9F6 RID: 55798 RVA: 0x003B2FF0 File Offset: 0x003B11F0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D9F7 RID: 55799 RVA: 0x003B2FFC File Offset: 0x003B11FC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D9F8 RID: 55800 RVA: 0x003B3008 File Offset: 0x003B1208
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D9F9 RID: 55801 RVA: 0x003B3010 File Offset: 0x003B1210
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_CreateGraphicConfigDataCharImageInfo_hotfix = (luaObj.RawGet("CreateGraphic") as LuaFunction);
					this.m_DestroyGraphic_hotfix = (luaObj.RawGet("DestroyGraphic") as LuaFunction);
					this.m_SetScaleOffetSingleSingle_hotfix = (luaObj.RawGet("SetScaleOffet") as LuaFunction);
					this.m_SetDirectionInt32_hotfix = (luaObj.RawGet("SetDirection") as LuaFunction);
					this.m_SetColorColor_hotfix = (luaObj.RawGet("SetColor") as LuaFunction);
					this.m_TweenColorColorSingle_hotfix = (luaObj.RawGet("TweenColor") as LuaFunction);
					this.m_GetCharImageInfo_hotfix = (luaObj.RawGet("GetCharImageInfo") as LuaFunction);
					this.m_StartFacialAnimationSingle_hotfix = (luaObj.RawGet("StartFacialAnimation") as LuaFunction);
					this.m_EnterInt32Action_hotfix = (luaObj.RawGet("Enter") as LuaFunction);
					this.m_LeaveInt32Action_hotfix = (luaObj.RawGet("Leave") as LuaFunction);
					this.m_Co_TweenColorColorColorSingleAction_hotfix = (luaObj.RawGet("Co_TweenColor") as LuaFunction);
					this.m_SetAnimationStringStringStringString_hotfix = (luaObj.RawGet("SetAnimation") as LuaFunction);
					this.m_StopMouthAnimation_hotfix = (luaObj.RawGet("StopMouthAnimation") as LuaFunction);
					this.m_SetNextBlinkTime_hotfix = (luaObj.RawGet("SetNextBlinkTime") as LuaFunction);
					this.m_GetAnimationDurationString_hotfix = (luaObj.RawGet("GetAnimationDuration") as LuaFunction);
					this.m_PlayAnimationStringBooleanInt32_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_StopAnimationInt32_hotfix = (luaObj.RawGet("StopAnimation") as LuaFunction);
					this.m_LateUpdate_hotfix = (luaObj.RawGet("LateUpdate") as LuaFunction);
					this.m_PlayEyeAnimationString_hotfix = (luaObj.RawGet("PlayEyeAnimation") as LuaFunction);
					this.m_PlayEyeStillAnimationString_hotfix = (luaObj.RawGet("PlayEyeStillAnimation") as LuaFunction);
					this.m_PlayMouthAnimationString_hotfix = (luaObj.RawGet("PlayMouthAnimation") as LuaFunction);
					this.m_PlayMouthStillAnimationString_hotfix = (luaObj.RawGet("PlayMouthStillAnimation") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D9FA RID: 55802 RVA: 0x003B331C File Offset: 0x003B151C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DialogCharUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008569 RID: 34153
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400856A RID: 34154
		private Image m_image;

		// Token: 0x0400856B RID: 34155
		private ConfigDataCharImageInfo m_charImageInfo;

		// Token: 0x0400856C RID: 34156
		private UISpineGraphic m_spineGraphic;

		// Token: 0x0400856D RID: 34157
		private Color m_curColor;

		// Token: 0x0400856E RID: 34158
		private Color m_tweenColor;

		// Token: 0x0400856F RID: 34159
		private float m_tweenColorTime;

		// Token: 0x04008570 RID: 34160
		private string m_idleAnimationName;

		// Token: 0x04008571 RID: 34161
		private string m_idleFacialAnimationName;

		// Token: 0x04008572 RID: 34162
		private float m_voiceTime;

		// Token: 0x04008573 RID: 34163
		private float m_blinkTime;

		// Token: 0x04008574 RID: 34164
		private bool m_isPlayingPreAnimation;

		// Token: 0x04008575 RID: 34165
		private bool m_isPlayingEyeAnimation;

		// Token: 0x04008576 RID: 34166
		private bool m_isPlayingMouthAnimation;

		// Token: 0x04008577 RID: 34167
		private const int EYE_ANIMATION_TRACK = 1;

		// Token: 0x04008578 RID: 34168
		private const int MOUTH_ANIMATION_TRACK = 2;

		// Token: 0x04008579 RID: 34169
		private const string EYE_ANIMATION = "_eye";

		// Token: 0x0400857A RID: 34170
		private const string EYE_STILL_ANIMATION = "_eye_still";

		// Token: 0x0400857B RID: 34171
		private const string MOUTH_ANIMATION = "_mouth";

		// Token: 0x0400857C RID: 34172
		private const string MOUTH_STILL_ANIMATION = "_mouth_still";

		// Token: 0x0400857D RID: 34173
		[DoNotToLua]
		private DialogCharUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400857E RID: 34174
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400857F RID: 34175
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008580 RID: 34176
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008581 RID: 34177
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04008582 RID: 34178
		private LuaFunction m_CreateGraphicConfigDataCharImageInfo_hotfix;

		// Token: 0x04008583 RID: 34179
		private LuaFunction m_DestroyGraphic_hotfix;

		// Token: 0x04008584 RID: 34180
		private LuaFunction m_SetScaleOffetSingleSingle_hotfix;

		// Token: 0x04008585 RID: 34181
		private LuaFunction m_SetDirectionInt32_hotfix;

		// Token: 0x04008586 RID: 34182
		private LuaFunction m_SetColorColor_hotfix;

		// Token: 0x04008587 RID: 34183
		private LuaFunction m_TweenColorColorSingle_hotfix;

		// Token: 0x04008588 RID: 34184
		private LuaFunction m_GetCharImageInfo_hotfix;

		// Token: 0x04008589 RID: 34185
		private LuaFunction m_StartFacialAnimationSingle_hotfix;

		// Token: 0x0400858A RID: 34186
		private LuaFunction m_EnterInt32Action_hotfix;

		// Token: 0x0400858B RID: 34187
		private LuaFunction m_LeaveInt32Action_hotfix;

		// Token: 0x0400858C RID: 34188
		private LuaFunction m_Co_TweenColorColorColorSingleAction_hotfix;

		// Token: 0x0400858D RID: 34189
		private LuaFunction m_SetAnimationStringStringStringString_hotfix;

		// Token: 0x0400858E RID: 34190
		private LuaFunction m_StopMouthAnimation_hotfix;

		// Token: 0x0400858F RID: 34191
		private LuaFunction m_SetNextBlinkTime_hotfix;

		// Token: 0x04008590 RID: 34192
		private LuaFunction m_GetAnimationDurationString_hotfix;

		// Token: 0x04008591 RID: 34193
		private LuaFunction m_PlayAnimationStringBooleanInt32_hotfix;

		// Token: 0x04008592 RID: 34194
		private LuaFunction m_StopAnimationInt32_hotfix;

		// Token: 0x04008593 RID: 34195
		private LuaFunction m_LateUpdate_hotfix;

		// Token: 0x04008594 RID: 34196
		private LuaFunction m_PlayEyeAnimationString_hotfix;

		// Token: 0x04008595 RID: 34197
		private LuaFunction m_PlayEyeStillAnimationString_hotfix;

		// Token: 0x04008596 RID: 34198
		private LuaFunction m_PlayMouthAnimationString_hotfix;

		// Token: 0x04008597 RID: 34199
		private LuaFunction m_PlayMouthStillAnimationString_hotfix;

		// Token: 0x02000C18 RID: 3096
		public new class LuaExportHelper
		{
			// Token: 0x0600D9FB RID: 55803 RVA: 0x003B3384 File Offset: 0x003B1584
			public LuaExportHelper(DialogCharUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D9FC RID: 55804 RVA: 0x003B3394 File Offset: 0x003B1594
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D9FD RID: 55805 RVA: 0x003B33A4 File Offset: 0x003B15A4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D9FE RID: 55806 RVA: 0x003B33B4 File Offset: 0x003B15B4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D9FF RID: 55807 RVA: 0x003B33C4 File Offset: 0x003B15C4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DA00 RID: 55808 RVA: 0x003B33DC File Offset: 0x003B15DC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DA01 RID: 55809 RVA: 0x003B33EC File Offset: 0x003B15EC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DA02 RID: 55810 RVA: 0x003B33FC File Offset: 0x003B15FC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DA03 RID: 55811 RVA: 0x003B340C File Offset: 0x003B160C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DA04 RID: 55812 RVA: 0x003B341C File Offset: 0x003B161C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DA05 RID: 55813 RVA: 0x003B342C File Offset: 0x003B162C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DA06 RID: 55814 RVA: 0x003B343C File Offset: 0x003B163C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DA07 RID: 55815 RVA: 0x003B344C File Offset: 0x003B164C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DA08 RID: 55816 RVA: 0x003B345C File Offset: 0x003B165C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DA09 RID: 55817 RVA: 0x003B346C File Offset: 0x003B166C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DA0A RID: 55818 RVA: 0x003B347C File Offset: 0x003B167C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002A4E RID: 10830
			// (get) Token: 0x0600DA0B RID: 55819 RVA: 0x003B348C File Offset: 0x003B168C
			// (set) Token: 0x0600DA0C RID: 55820 RVA: 0x003B349C File Offset: 0x003B169C
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x17002A4F RID: 10831
			// (get) Token: 0x0600DA0D RID: 55821 RVA: 0x003B34AC File Offset: 0x003B16AC
			// (set) Token: 0x0600DA0E RID: 55822 RVA: 0x003B34BC File Offset: 0x003B16BC
			public Image m_image
			{
				get
				{
					return this.m_owner.m_image;
				}
				set
				{
					this.m_owner.m_image = value;
				}
			}

			// Token: 0x17002A50 RID: 10832
			// (get) Token: 0x0600DA0F RID: 55823 RVA: 0x003B34CC File Offset: 0x003B16CC
			// (set) Token: 0x0600DA10 RID: 55824 RVA: 0x003B34DC File Offset: 0x003B16DC
			public ConfigDataCharImageInfo m_charImageInfo
			{
				get
				{
					return this.m_owner.m_charImageInfo;
				}
				set
				{
					this.m_owner.m_charImageInfo = value;
				}
			}

			// Token: 0x17002A51 RID: 10833
			// (get) Token: 0x0600DA11 RID: 55825 RVA: 0x003B34EC File Offset: 0x003B16EC
			// (set) Token: 0x0600DA12 RID: 55826 RVA: 0x003B34FC File Offset: 0x003B16FC
			public UISpineGraphic m_spineGraphic
			{
				get
				{
					return this.m_owner.m_spineGraphic;
				}
				set
				{
					this.m_owner.m_spineGraphic = value;
				}
			}

			// Token: 0x17002A52 RID: 10834
			// (get) Token: 0x0600DA13 RID: 55827 RVA: 0x003B350C File Offset: 0x003B170C
			// (set) Token: 0x0600DA14 RID: 55828 RVA: 0x003B351C File Offset: 0x003B171C
			public Color m_curColor
			{
				get
				{
					return this.m_owner.m_curColor;
				}
				set
				{
					this.m_owner.m_curColor = value;
				}
			}

			// Token: 0x17002A53 RID: 10835
			// (get) Token: 0x0600DA15 RID: 55829 RVA: 0x003B352C File Offset: 0x003B172C
			// (set) Token: 0x0600DA16 RID: 55830 RVA: 0x003B353C File Offset: 0x003B173C
			public Color m_tweenColor
			{
				get
				{
					return this.m_owner.m_tweenColor;
				}
				set
				{
					this.m_owner.m_tweenColor = value;
				}
			}

			// Token: 0x17002A54 RID: 10836
			// (get) Token: 0x0600DA17 RID: 55831 RVA: 0x003B354C File Offset: 0x003B174C
			// (set) Token: 0x0600DA18 RID: 55832 RVA: 0x003B355C File Offset: 0x003B175C
			public float m_tweenColorTime
			{
				get
				{
					return this.m_owner.m_tweenColorTime;
				}
				set
				{
					this.m_owner.m_tweenColorTime = value;
				}
			}

			// Token: 0x17002A55 RID: 10837
			// (get) Token: 0x0600DA19 RID: 55833 RVA: 0x003B356C File Offset: 0x003B176C
			// (set) Token: 0x0600DA1A RID: 55834 RVA: 0x003B357C File Offset: 0x003B177C
			public string m_idleAnimationName
			{
				get
				{
					return this.m_owner.m_idleAnimationName;
				}
				set
				{
					this.m_owner.m_idleAnimationName = value;
				}
			}

			// Token: 0x17002A56 RID: 10838
			// (get) Token: 0x0600DA1B RID: 55835 RVA: 0x003B358C File Offset: 0x003B178C
			// (set) Token: 0x0600DA1C RID: 55836 RVA: 0x003B359C File Offset: 0x003B179C
			public string m_idleFacialAnimationName
			{
				get
				{
					return this.m_owner.m_idleFacialAnimationName;
				}
				set
				{
					this.m_owner.m_idleFacialAnimationName = value;
				}
			}

			// Token: 0x17002A57 RID: 10839
			// (get) Token: 0x0600DA1D RID: 55837 RVA: 0x003B35AC File Offset: 0x003B17AC
			// (set) Token: 0x0600DA1E RID: 55838 RVA: 0x003B35BC File Offset: 0x003B17BC
			public float m_voiceTime
			{
				get
				{
					return this.m_owner.m_voiceTime;
				}
				set
				{
					this.m_owner.m_voiceTime = value;
				}
			}

			// Token: 0x17002A58 RID: 10840
			// (get) Token: 0x0600DA1F RID: 55839 RVA: 0x003B35CC File Offset: 0x003B17CC
			// (set) Token: 0x0600DA20 RID: 55840 RVA: 0x003B35DC File Offset: 0x003B17DC
			public float m_blinkTime
			{
				get
				{
					return this.m_owner.m_blinkTime;
				}
				set
				{
					this.m_owner.m_blinkTime = value;
				}
			}

			// Token: 0x17002A59 RID: 10841
			// (get) Token: 0x0600DA21 RID: 55841 RVA: 0x003B35EC File Offset: 0x003B17EC
			// (set) Token: 0x0600DA22 RID: 55842 RVA: 0x003B35FC File Offset: 0x003B17FC
			public bool m_isPlayingPreAnimation
			{
				get
				{
					return this.m_owner.m_isPlayingPreAnimation;
				}
				set
				{
					this.m_owner.m_isPlayingPreAnimation = value;
				}
			}

			// Token: 0x17002A5A RID: 10842
			// (get) Token: 0x0600DA23 RID: 55843 RVA: 0x003B360C File Offset: 0x003B180C
			// (set) Token: 0x0600DA24 RID: 55844 RVA: 0x003B361C File Offset: 0x003B181C
			public bool m_isPlayingEyeAnimation
			{
				get
				{
					return this.m_owner.m_isPlayingEyeAnimation;
				}
				set
				{
					this.m_owner.m_isPlayingEyeAnimation = value;
				}
			}

			// Token: 0x17002A5B RID: 10843
			// (get) Token: 0x0600DA25 RID: 55845 RVA: 0x003B362C File Offset: 0x003B182C
			// (set) Token: 0x0600DA26 RID: 55846 RVA: 0x003B363C File Offset: 0x003B183C
			public bool m_isPlayingMouthAnimation
			{
				get
				{
					return this.m_owner.m_isPlayingMouthAnimation;
				}
				set
				{
					this.m_owner.m_isPlayingMouthAnimation = value;
				}
			}

			// Token: 0x17002A5C RID: 10844
			// (get) Token: 0x0600DA27 RID: 55847 RVA: 0x003B364C File Offset: 0x003B184C
			public static int EYE_ANIMATION_TRACK
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x17002A5D RID: 10845
			// (get) Token: 0x0600DA28 RID: 55848 RVA: 0x003B3650 File Offset: 0x003B1850
			public static int MOUTH_ANIMATION_TRACK
			{
				get
				{
					return 2;
				}
			}

			// Token: 0x17002A5E RID: 10846
			// (get) Token: 0x0600DA29 RID: 55849 RVA: 0x003B3654 File Offset: 0x003B1854
			public static string EYE_ANIMATION
			{
				get
				{
					return "_eye";
				}
			}

			// Token: 0x17002A5F RID: 10847
			// (get) Token: 0x0600DA2A RID: 55850 RVA: 0x003B365C File Offset: 0x003B185C
			public static string EYE_STILL_ANIMATION
			{
				get
				{
					return "_eye_still";
				}
			}

			// Token: 0x17002A60 RID: 10848
			// (get) Token: 0x0600DA2B RID: 55851 RVA: 0x003B3664 File Offset: 0x003B1864
			public static string MOUTH_ANIMATION
			{
				get
				{
					return "_mouth";
				}
			}

			// Token: 0x17002A61 RID: 10849
			// (get) Token: 0x0600DA2C RID: 55852 RVA: 0x003B366C File Offset: 0x003B186C
			public static string MOUTH_STILL_ANIMATION
			{
				get
				{
					return "_mouth_still";
				}
			}

			// Token: 0x0600DA2D RID: 55853 RVA: 0x003B3674 File Offset: 0x003B1874
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600DA2E RID: 55854 RVA: 0x003B3684 File Offset: 0x003B1884
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600DA2F RID: 55855 RVA: 0x003B3694 File Offset: 0x003B1894
			public IEnumerator Co_TweenColor(Color fromColor, Color toColor, float time, Action onEndAction)
			{
				return this.m_owner.Co_TweenColor(fromColor, toColor, time, onEndAction);
			}

			// Token: 0x0600DA30 RID: 55856 RVA: 0x003B36A8 File Offset: 0x003B18A8
			public void SetNextBlinkTime()
			{
				this.m_owner.SetNextBlinkTime();
			}

			// Token: 0x0600DA31 RID: 55857 RVA: 0x003B36B8 File Offset: 0x003B18B8
			public void PlayAnimation(string name, bool loop, int trackIndex)
			{
				this.m_owner.PlayAnimation(name, loop, trackIndex);
			}

			// Token: 0x0600DA32 RID: 55858 RVA: 0x003B36C8 File Offset: 0x003B18C8
			public void StopAnimation(int trackIndex)
			{
				this.m_owner.StopAnimation(trackIndex);
			}

			// Token: 0x0600DA33 RID: 55859 RVA: 0x003B36D8 File Offset: 0x003B18D8
			public void LateUpdate()
			{
				this.m_owner.LateUpdate();
			}

			// Token: 0x0600DA34 RID: 55860 RVA: 0x003B36E8 File Offset: 0x003B18E8
			public void PlayEyeAnimation(string facialAnimation)
			{
				this.m_owner.PlayEyeAnimation(facialAnimation);
			}

			// Token: 0x0600DA35 RID: 55861 RVA: 0x003B36F8 File Offset: 0x003B18F8
			public void PlayEyeStillAnimation(string facialAnimation)
			{
				this.m_owner.PlayEyeStillAnimation(facialAnimation);
			}

			// Token: 0x0600DA36 RID: 55862 RVA: 0x003B3708 File Offset: 0x003B1908
			public void PlayMouthAnimation(string facialAnimation)
			{
				this.m_owner.PlayMouthAnimation(facialAnimation);
			}

			// Token: 0x0600DA37 RID: 55863 RVA: 0x003B3718 File Offset: 0x003B1918
			public void PlayMouthStillAnimation(string facialAnimation)
			{
				this.m_owner.PlayMouthStillAnimation(facialAnimation);
			}

			// Token: 0x04008598 RID: 34200
			private DialogCharUIController m_owner;
		}
	}
}
