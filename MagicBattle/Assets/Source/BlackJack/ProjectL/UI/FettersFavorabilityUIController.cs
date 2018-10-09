using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C72 RID: 3186
	[HotFix]
	public class FettersFavorabilityUIController : UIControllerBase
	{
		// Token: 0x0600E41D RID: 58397 RVA: 0x003D4388 File Offset: 0x003D2588
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
			this.m_presentButton.onClick.AddListener(new UnityAction(this.OnGiftButtonClick));
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_helpButton.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_memoryButton.onClick.AddListener(new UnityAction(this.OnMemoryButtonClick));
			this.m_fettersButton.onClick.AddListener(new UnityAction(this.OnFettersButtonClick));
			this.m_informationButton.onClick.AddListener(new UnityAction(this.OnInformationButtonClick));
			this.m_charContinueButton.onClick.AddListener(new UnityAction(this.OnCharContinueButtonClick));
			this.m_unlockEventBackButton.onClick.AddListener(new UnityAction(this.OnUnlockEventBackButtonClick));
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_charGameObjectRoot);
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600E41E RID: 58398 RVA: 0x003D4524 File Offset: 0x003D2724
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
		}

		// Token: 0x0600E41F RID: 58399 RVA: 0x003D4584 File Offset: 0x003D2784
		public void UpdateViewInFettersFavorability(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInFettersFavorabilityHero_hotfix != null)
			{
				this.m_UpdateViewInFettersFavorabilityHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Input.multiTouchEnabled = false;
			this.m_hero = hero;
			this.m_isInGiftMode = false;
			this.m_isMale = (this.m_hero.HeroInfo.Sex == 1);
			if (this.m_isMale)
			{
				this.m_sexStateCtrl.SetToUIState("Male", false, true);
			}
			else
			{
				this.m_sexStateCtrl.SetToUIState("Female", false, true);
			}
			this.m_femaleQinMiDuGameObject.SetActive(false);
			this.m_maleQinMiDuGameObject.SetActive(false);
			if (this.m_heroCharUIController.GetCharImageInfo() != this.m_hero.HeroInfo.GetCharImageInfo(hero.Level))
			{
				this.m_heroCharUIController.CreateGraphic(this.m_hero, HeroCharUIController.PerformanceState.All, true, null);
				this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
			}
			this.SetFavorabilityValue();
			this.SetTouchCountState();
			int num = 0;
			int num2 = 0;
			ConfigDataHeroInformationInfo informationInfo = this.m_hero.HeroInfo.m_informationInfo;
			if (informationInfo != null && informationInfo.HeroFetters_ID.Count > 0)
			{
				foreach (int key in informationInfo.HeroFetters_ID)
				{
					ConfigDataHeroFetterInfo configDataHeroFetterInfo = this.m_configDataLoader.GetConfigDataHeroFetterInfo(key);
					num += configDataHeroFetterInfo.MaxLevel;
				}
				foreach (KeyValuePair<int, int> keyValuePair in this.m_hero.Fetters)
				{
					num2 += keyValuePair.Value;
				}
				if (num == 0)
				{
					this.m_fettersButtonPercentText.text = "0%";
				}
				else
				{
					this.m_fettersButtonPercentText.text = num2 * 100 / num + "%";
				}
			}
			else
			{
				this.m_fettersButtonPercentText.text = "0%";
			}
			bool active = this.m_playerContext.IsHeroFetterHasNewOrLevelUp(this.m_hero);
			this.m_fettersButtonRedMark.SetActive(active);
			bool isDungeonLevelsUnLock = this.m_hero.HeroInfo.m_informationInfo.IsDungeonLevelsUnLock;
			this.m_memoryButtonPercentText.text = this.m_playerContext.HeroDungeonProgress(informationInfo.ID) + "%";
			this.m_memoryButtonNewImage.SetActive(isDungeonLevelsUnLock && this.m_playerContext.IsHeroDungeonNewMarkShow(informationInfo.ID));
			if (isDungeonLevelsUnLock)
			{
				this.m_memoryButtonStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_memoryButtonStateCtrl.SetToUIState("Grey", false, true);
			}
			this.m_informationButtonNewImage.SetActive(FettersInformationUIController.HaveNewInfomation(informationInfo));
			bool flag = this.m_playerContext.GetHeroInteractNums() != 0;
			bool flag2 = this.m_playerContext.IsFullFavorabilityExp(this.m_hero);
			if (flag2)
			{
			}
			this.m_touchImage.SetActive(false);
			this.m_touchNumberStateCtrl.gameObject.SetActive(false);
			OnDragTrigger onDragTrigger = this.m_touchImage.GetComponent<OnDragTrigger>();
			if (flag && onDragTrigger == null)
			{
				onDragTrigger = this.m_touchImage.AddComponent<OnDragTrigger>();
				onDragTrigger.EventOnBeginDrag += this.DragTrigger_EventOnBeginDrag;
				onDragTrigger.EventOnEndDrag += this.DragTrigger_EventOnEndDrag;
				onDragTrigger.EventOnClick += this.DragTrigger_EventOnClick;
				onDragTrigger.EventOnSliderFull += this.DragTrigger_EventOnSliderFull;
				onDragTrigger.EventOnSliderEmpty += this.DragTrigger_EventOnSliderEmpty;
			}
			if (onDragTrigger != null)
			{
				onDragTrigger.SetSliderAndEffectSlider((!this.m_isMale) ? this.m_progressFemaleSlider : this.m_progressMaleSlider, this.m_progressEffectSlider, this.m_hero.HeroInfo.m_informationInfo.InteractHeroPerformances_ID);
			}
		}

		// Token: 0x0600E420 RID: 58400 RVA: 0x003D49E8 File Offset: 0x003D2BE8
		public void OpenFettersFavorability()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenFettersFavorability_hotfix != null)
			{
				this.m_OpenFettersFavorability_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_commonUIStateCtrl.SetToUIState("Show", false, true);
			UIStateDesc currentUIState = this.m_presentStateCtrl.GetCurrentUIState();
			if (this.m_presentPanel.activeInHierarchy || currentUIState == null || currentUIState.StateName != "In")
			{
				this.m_presentPanel.SetActive(false);
			}
		}

		// Token: 0x0600E421 RID: 58401 RVA: 0x003D4AA0 File Offset: 0x003D2CA0
		private void SetFavorabilityValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFavorabilityValue_hotfix != null)
			{
				this.m_SetFavorabilityValue_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_favorabilityHeroNameText.text = this.m_hero.HeroInfo.Name;
			this.m_favorabilityLvText.text = this.m_hero.FavorabilityLevel.ToString();
			if (!this.m_playerContext.IsFullFavorabilityExp(this.m_hero))
			{
				this.m_favorabilityValueTextStateCtrl.SetToUIState("Normal", false, true);
				ConfigDataHeroFavorabilityLevelInfo configDataHeroFavorabilityLevelInfo = this.m_configDataLoader.GetConfigDataHeroFavorabilityLevelInfo(this.m_hero.FavorabilityLevel);
				this.m_favorabilityValueText.text = this.m_hero.FavorabilityExp + "/" + configDataHeroFavorabilityLevelInfo.NextExp;
				Slider slider = (!this.m_isMale) ? this.m_favorabilityFemaleSlider : this.m_favorabilityMaleSlider;
				slider.value = (float)this.m_hero.FavorabilityExp / (float)configDataHeroFavorabilityLevelInfo.NextExp;
				slider.gameObject.SetActive(slider.value != 0f);
			}
			else
			{
				this.m_favorabilityValueTextStateCtrl.SetToUIState("Max", false, true);
				Slider slider2 = (!this.m_isMale) ? this.m_favorabilityFemaleSlider : this.m_favorabilityMaleSlider;
				slider2.value = 1f;
			}
		}

		// Token: 0x0600E422 RID: 58402 RVA: 0x003D4C40 File Offset: 0x003D2E40
		private void SetTouchCountState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTouchCountState_hotfix != null)
			{
				this.m_SetTouchCountState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroInteractNums = this.m_playerContext.GetHeroInteractNums();
			int num = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_HeroIteractMaxNums);
			if (heroInteractNums < num)
			{
				this.m_touchNumberStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_touchNumberStateCtrl.SetToUIState("Full", false, true);
			}
			if (heroInteractNums <= 5)
			{
				this.m_touchCountStateCtrl.SetToUIState(heroInteractNums.ToString(), false, true);
			}
			bool flag = this.m_playerContext.IsFullFavorabilityExp(this.m_hero);
			if (flag)
			{
			}
		}

		// Token: 0x0600E423 RID: 58403 RVA: 0x003D4D28 File Offset: 0x003D2F28
		public void SetTouchRecoverTime(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTouchRecoverTimeTimeSpan_hotfix != null)
			{
				this.m_SetTouchRecoverTimeTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroInteractNums = this.m_playerContext.GetHeroInteractNums();
			if (heroInteractNums <= 5)
			{
				this.m_touchCountStateCtrl.SetToUIState(heroInteractNums.ToString(), false, true);
			}
			this.m_touchTimeText.text = string.Format("{0:d2}:{1:d2}", ts.Minutes, ts.Seconds);
		}

		// Token: 0x0600E424 RID: 58404 RVA: 0x003D4DF4 File Offset: 0x003D2FF4
		private void DragTrigger_EventOnSliderFull()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DragTrigger_EventOnSliderFull_hotfix != null)
			{
				this.m_DragTrigger_EventOnSliderFull_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_playerContext.IsFullFavorabilityExp(this.m_hero);
			if (flag)
			{
				System.Random random = new System.Random();
				HeroInteractionResultType heroInteractionResultType = (HeroInteractionResultType)random.Next(1, 3);
				this.OnHeroInteractSucceed(null, 0, heroInteractionResultType, 0);
			}
			else
			{
				int num = this.m_playerContext.CanInteractHero(this.m_hero.HeroId);
				if (num == 0)
				{
					if (this.EventOnSliderFull != null)
					{
						this.EventOnSliderFull();
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				}
			}
		}

		// Token: 0x0600E425 RID: 58405 RVA: 0x003D4ED4 File Offset: 0x003D30D4
		private void DragTrigger_EventOnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DragTrigger_EventOnClick_hotfix != null)
			{
				this.m_DragTrigger_EventOnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroCharUIController.PlayOneRandomPerformance(false);
		}

		// Token: 0x0600E426 RID: 58406 RVA: 0x003D4F44 File Offset: 0x003D3144
		private void DragTrigger_EventOnEndDrag()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DragTrigger_EventOnEndDrag_hotfix != null)
			{
				this.m_DragTrigger_EventOnEndDrag_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600E427 RID: 58407 RVA: 0x003D4FA4 File Offset: 0x003D31A4
		private void DragTrigger_EventOnBeginDrag()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DragTrigger_EventOnBeginDrag_hotfix != null)
			{
				this.m_DragTrigger_EventOnBeginDrag_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIStateDesc currentUIState = this.m_touchInOutStateCtrl.GetCurrentUIState();
			if (currentUIState == null || currentUIState.StateName != "In")
			{
				this.m_heroFavoribilityOldLevel = this.m_hero.FavorabilityLevel;
				this.SetCharGoTweenPos(true);
				this.m_touchInOutStateCtrl.SetToUIState("In", false, true);
				this.m_maleBGImage.SetActive(this.m_isMale);
				this.m_femaleBGImage.SetActive(!this.m_isMale);
				if (this.m_isMale)
				{
					UIUtility.ResetTween(this.m_femaleBGImage);
				}
				else
				{
					UIUtility.ResetTween(this.m_maleBGImage);
				}
			}
			this.m_heroCharUIController.PlayAnimation("idle_Touch", true);
			AudioUtility.PlaySound("Action_StopVoice");
			this.InactiveWordGameObject();
		}

		// Token: 0x0600E428 RID: 58408 RVA: 0x003D50C4 File Offset: 0x003D32C4
		private void DragTrigger_EventOnSliderEmpty()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DragTrigger_EventOnSliderEmpty_hotfix != null)
			{
				this.m_DragTrigger_EventOnSliderEmpty_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetTouchStateCtrlOut("Out");
		}

		// Token: 0x0600E429 RID: 58409 RVA: 0x003D5130 File Offset: 0x003D3330
		private void SetTouchStateCtrlOut(string stateName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTouchStateCtrlOutString_hotfix != null)
			{
				this.m_SetTouchStateCtrlOutString_hotfix.call(new object[]
				{
					this,
					stateName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetCharGoTweenPos(false);
			this.m_touchInOutStateCtrl.SetActionForUIStateFinshed(stateName, delegate
			{
				this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
			});
			this.m_touchInOutStateCtrl.SetToUIState(stateName, false, true);
			this.m_maleBGImage.SetActive(this.m_isMale);
			this.m_femaleBGImage.SetActive(!this.m_isMale);
			if (this.m_isMale)
			{
				UIUtility.ResetTween(this.m_femaleBGImage);
			}
			else
			{
				UIUtility.ResetTween(this.m_maleBGImage);
			}
		}

		// Token: 0x0600E42A RID: 58410 RVA: 0x003D521C File Offset: 0x003D341C
		private void SetCharGoTweenPos(bool isCharAtInState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCharGoTweenPosBoolean_hotfix != null)
			{
				this.m_SetCharGoTweenPosBoolean_hotfix.call(new object[]
				{
					this,
					isCharAtInState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataCharImageInfo charImageInfo = this.m_heroCharUIController.GetCharImageInfo();
			TweenPos2[] components = this.m_charGameObject.GetComponents<TweenPos2>();
			TweenScale[] components2 = this.m_charGameObject.GetComponents<TweenScale>();
			if (isCharAtInState)
			{
				TweenPos2 tweenPos = components[0];
				tweenPos.from.y = -500f;
				tweenPos.to.y = (float)charImageInfo.HeroFetterYOffset;
			}
			else
			{
				RectTransform component = this.m_charGameObject.GetComponent<RectTransform>();
				TweenPos2 tweenPos2 = components[1];
				tweenPos2.from.y = component.localPosition.y;
				tweenPos2.to.y = -500f;
				TweenScale tweenScale = components2[1];
				tweenScale.from = component.localScale;
			}
		}

		// Token: 0x0600E42B RID: 58411 RVA: 0x003D5334 File Offset: 0x003D3534
		public void OnHeroInteractSucceed(List<Goods> rewards, int heroPerformanceId, HeroInteractionResultType heroInteractionResultType, int addExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroInteractSucceedList`1Int32HeroInteractionResultTypeInt32_hotfix != null)
			{
				this.m_OnHeroInteractSucceedList`1Int32HeroInteractionResultTypeInt32_hotfix.call(new object[]
				{
					this,
					rewards,
					heroPerformanceId,
					heroInteractionResultType,
					addExp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroFavoribilityOldLevel < this.m_hero.FavorabilityLevel)
			{
				CommonUIController.Instance.EnableInput(false);
			}
			this.m_heroFavoribilityLevelUpRewards.Clear();
			if (rewards != null)
			{
				this.m_heroFavoribilityLevelUpRewards.AddRange(rewards);
			}
			this.m_favorabilityAddValueText.text = "+" + addExp;
			this.m_progressEffectGroup.SetActive(true);
			switch (heroInteractionResultType)
			{
			case HeroInteractionResultType.HeroInteractionResultType_Norml:
				this.AfterHeroInteractionResultEffect("Normal", heroPerformanceId);
				this.m_touchStateCtrl.SetToUIState("Normal", false, true);
				break;
			case HeroInteractionResultType.HeroInteractionResultType_SmallUp:
				this.AfterHeroInteractionResultEffect("LittleUp", heroPerformanceId);
				this.m_touchStateCtrl.SetToUIState("LittleUp", false, true);
				break;
			case HeroInteractionResultType.HeroInteractionResultType_BigUp:
				this.AfterHeroInteractionResultEffect("MoreUp", heroPerformanceId);
				this.m_touchStateCtrl.SetToUIState("MoreUp", false, true);
				break;
			}
			this.m_favorabilityAddValueText.gameObject.SetActive(addExp != 0);
			this.m_favorabilityAddUpArrowGo.SetActive(addExp != 0);
			this.SetTouchCountState();
			this.SetFavorabilityValue();
			if (UIUtility.GetUIStateCurrentStateName(this.m_touchInOutStateCtrl) == "In")
			{
				this.SetTouchStateCtrlOut("DelayOut");
			}
		}

		// Token: 0x0600E42C RID: 58412 RVA: 0x003D5520 File Offset: 0x003D3720
		private void AfterHeroInteractionResultEffect(string stateName, int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AfterHeroInteractionResultEffectStringInt32_hotfix != null)
			{
				this.m_AfterHeroInteractionResultEffectStringInt32_hotfix.call(new object[]
				{
					this,
					stateName,
					heroPerformanceId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroPerformanceId = heroPerformanceId2;
			FettersFavorabilityUIController $this = this;
			this.m_touchStateCtrl.SetActionForUIStateFinshed(stateName, delegate
			{
				$this.m_progressEffectGroup.SetActive(false);
				$this.PlayFavorbilityLevelUp(heroPerformanceId);
			});
		}

		// Token: 0x0600E42D RID: 58413 RVA: 0x003D55D0 File Offset: 0x003D37D0
		private void PlayFavorbilityLevelUp(int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayFavorbilityLevelUpInt32_hotfix != null)
			{
				this.m_PlayFavorbilityLevelUpInt32_hotfix.call(new object[]
				{
					this,
					heroPerformanceId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroPerformanceId = heroPerformanceId2;
			FettersFavorabilityUIController $this = this;
			bool flag = this.m_heroFavoribilityOldLevel < this.m_hero.FavorabilityLevel;
			if (flag)
			{
				if (this.m_isInGiftMode)
				{
					this.m_presentContentStateCtrl.SetToUIState("Close", false, true);
				}
				this.m_levelUpStarEffectGroup.SetActive(true);
				this.m_levelUpEffectGroupGameObject.SetActive(true);
				if (this.m_isMale)
				{
					this.m_levelUpStateCtrl.SetActionForUIStateFinshed("ShowMale", delegate
					{
						$this.StartCoroutine($this.Co_PlayHeroInteractEffect(heroPerformanceId));
					});
					this.m_levelUpStateCtrl.SetToUIState("ShowMale", false, true);
				}
				else
				{
					this.m_levelUpStateCtrl.SetActionForUIStateFinshed("ShowFemale", delegate
					{
						$this.StartCoroutine($this.Co_PlayHeroInteractEffect(heroPerformanceId));
					});
					this.m_levelUpStateCtrl.SetToUIState("ShowFemale", false, true);
				}
			}
			else
			{
				CommonUIController.Instance.EnableInput(true);
			}
		}

		// Token: 0x0600E42E RID: 58414 RVA: 0x003D5724 File Offset: 0x003D3924
		[DebuggerHidden]
		private IEnumerator Co_PlayHeroInteractEffect(int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_PlayHeroInteractEffectInt32_hotfix != null)
			{
				return (IEnumerator)this.m_Co_PlayHeroInteractEffectInt32_hotfix.call(new object[]
				{
					this,
					heroPerformanceId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FettersFavorabilityUIController.<Co_PlayHeroInteractEffect>c__Iterator0 <Co_PlayHeroInteractEffect>c__Iterator = new FettersFavorabilityUIController.<Co_PlayHeroInteractEffect>c__Iterator0();
			<Co_PlayHeroInteractEffect>c__Iterator.heroPerformanceId = heroPerformanceId;
			<Co_PlayHeroInteractEffect>c__Iterator.$this = this;
			return <Co_PlayHeroInteractEffect>c__Iterator;
		}

		// Token: 0x0600E42F RID: 58415 RVA: 0x003D57B8 File Offset: 0x003D39B8
		private void OnCharContinueButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCharContinueButtonClick_hotfix != null)
			{
				this.m_OnCharContinueButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StopAllCoroutines();
			this.InactiveWordGameObject();
			this.m_charContinueButton.gameObject.SetActive(false);
			this.ShowUnlockEvents();
			this.m_levelUpStarEffectGroup.SetActive(false);
			this.m_levelUpEffectGroupGameObject.SetActive(false);
		}

		// Token: 0x0600E430 RID: 58416 RVA: 0x003D5854 File Offset: 0x003D3A54
		private void ShowUnlockEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowUnlockEvents_hotfix != null)
			{
				this.m_ShowUnlockEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curUnlockEventIndex = 0;
			this.m_unlockEventTitleList.Clear();
			this.m_unlockEventContentList.Clear();
			this.GetUnlockEvents(this.m_hero);
			if (this.m_unlockEventTitleList.Count == 0)
			{
				this.m_heroCharUIController.SetCanClick(true);
				if (this.m_heroFavoribilityLevelUpRewards != null && this.m_heroFavoribilityLevelUpRewards.Count != 0)
				{
					GetRewardGoodsUITask.StartUITask(this.m_heroFavoribilityLevelUpRewards);
				}
				if (this.m_isInGiftMode)
				{
					this.m_presentContentStateCtrl.SetToUIState("Show", false, true);
					this.m_heroCharUIController.SetCanClick(false);
				}
				CommonUIController.Instance.EnableInput(true);
				return;
			}
			this.m_unlockEventTitleText.text = this.m_unlockEventTitleList[this.m_curUnlockEventIndex];
			this.m_unlockEventContentText.text = this.m_unlockEventContentList[this.m_curUnlockEventIndex];
			this.m_curUnlockEventIndex++;
			this.m_unlockEventStateCtrl.gameObject.SetActive(true);
			this.m_unlockEventStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x0600E431 RID: 58417 RVA: 0x003D59C0 File Offset: 0x003D3BC0
		private void GetUnlockEvents(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUnlockEventsHero_hotfix != null)
			{
				this.m_GetUnlockEventsHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInformationInfo informationInfo = hero.HeroInfo.m_informationInfo;
			List<int> heroBiographies_ID = informationInfo.HeroBiographies_ID;
			List<int> list = new List<int>();
			if (LocalAccountConfig.Instance.Data.UnlockHeroBiographyIds != null)
			{
				list = new List<int>(LocalAccountConfig.Instance.Data.UnlockHeroBiographyIds);
			}
			foreach (int num in heroBiographies_ID)
			{
				bool flag = false;
				ConfigDataHeroBiographyInfo configDataHeroBiographyInfo = this.m_configDataLoader.GetConfigDataHeroBiographyInfo(num);
				foreach (HeroBiographyCondition heroBiographyCondition in configDataHeroBiographyInfo.UnlockConditions)
				{
					if (heroBiographyCondition.ConditionType == HeroBiographyUnlockConditionType.HeroBiographyUnlockConditionType_HeroFavorabilityLevel && heroBiographyCondition.Parm2 == 1)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					if (!list.Contains(num) && this.m_playerContext.CanUnlockHeroBiography(num) == 0)
					{
						LocalAccountConfig.Instance.AddUnlockHeroBiography(num);
						this.m_unlockEventTitleList.Add(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_HeroFettersUnlockEventType_Life));
						this.m_unlockEventContentList.Add(configDataHeroBiographyInfo.Title);
					}
				}
			}
			List<int> heroPerformances_ID = this.m_configDataLoader.GetConfigDataPerformanceInfo(informationInfo.HeroPerformance_ID).HeroPerformances_ID;
			List<int> list2 = new List<int>();
			if (LocalAccountConfig.Instance.Data.UnlockHeroPerformanceIds != null)
			{
				list2 = new List<int>(LocalAccountConfig.Instance.Data.UnlockHeroPerformanceIds);
			}
			foreach (int num2 in heroPerformances_ID)
			{
				bool flag2 = false;
				ConfigDataHeroPerformanceInfo configDataHeroPerformanceInfo = this.m_configDataLoader.GetConfigDataHeroPerformanceInfo(num2);
				foreach (HeroPerformanceUnlcokCondition heroPerformanceUnlcokCondition in configDataHeroPerformanceInfo.UnlockConditions)
				{
					if (heroPerformanceUnlcokCondition.ConditionType == HeroPerformanceUnlockConditionType.HeroPerformanceUnlockConditionType_HeroFavourabilityLevel && heroPerformanceUnlcokCondition.Param2 == 1)
					{
						flag2 = true;
					}
				}
				if (!flag2)
				{
					if (!list2.Contains(num2) && this.m_playerContext.CanUnlockHeroPerformance(num2) == 0)
					{
						LocalAccountConfig.Instance.AddUnlockHeroPerformance(num2);
						this.m_unlockEventTitleList.Add(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_HeroFettersUnlockEventType_Voice));
						this.m_unlockEventContentList.Add(configDataHeroPerformanceInfo.Name);
					}
				}
			}
			List<int> heroFetters_ID = informationInfo.HeroFetters_ID;
			List<int> list3 = new List<int>(hero.Fetters.Keys);
			List<int> list4 = new List<int>();
			if (LocalAccountConfig.Instance.Data.UnlockHeroFetterIds != null)
			{
				list4 = new List<int>(LocalAccountConfig.Instance.Data.UnlockHeroFetterIds);
			}
			foreach (int num3 in heroFetters_ID)
			{
				if (!list3.Contains(num3) && !list4.Contains(num3))
				{
					if (this.m_playerContext.CanUnlockHeroFetter(hero.HeroId, num3) == 0)
					{
						LocalAccountConfig.Instance.AddUnlockHeroFetterId(num3);
						ConfigDataHeroFetterInfo configDataHeroFetterInfo = this.m_configDataLoader.GetConfigDataHeroFetterInfo(num3);
						this.m_unlockEventTitleList.Add(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_HeroFettersUnlockEventType_Fetters));
						this.m_unlockEventContentList.Add(configDataHeroFetterInfo.Name);
					}
				}
			}
			if (!informationInfo.IsDungeonLevelsUnLock)
			{
				return;
			}
			List<int> dungeonLevels_ID = informationInfo.DungeonLevels_ID;
			List<int> list5 = new List<int>();
			if (LocalAccountConfig.Instance.Data.UnlockHeroDungeonLevelIds != null)
			{
				list5 = new List<int>(LocalAccountConfig.Instance.Data.UnlockHeroDungeonLevelIds);
			}
			foreach (int num4 in dungeonLevels_ID)
			{
				bool flag3 = false;
				ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(num4);
				foreach (HeroDungeonLevelUnlcokCondition heroDungeonLevelUnlcokCondition in configDataHeroDungeonLevelInfo.UnlockConditions)
				{
					if (heroDungeonLevelUnlcokCondition.ConditionType == HeroDungeonLevellUnlockConditionType.HeroDungeonLevellUnlockConditionType_HeroFavorabilityLevel && heroDungeonLevelUnlcokCondition.Param2 == 1)
					{
						flag3 = true;
					}
				}
				if (!flag3)
				{
					if (!list5.Contains(num4) && this.m_playerContext.IsHeroDungeonLevelAttachUnlockLevel(num4) == 0)
					{
						LocalAccountConfig.Instance.AddUnlockHeroDungeonLevelId(num4);
						this.m_unlockEventTitleList.Add(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_HeroFettersUnlockEventType_Memory));
						this.m_unlockEventContentList.Add(configDataHeroDungeonLevelInfo.Name);
					}
				}
			}
		}

		// Token: 0x0600E432 RID: 58418 RVA: 0x003D5F6C File Offset: 0x003D416C
		private void OnUnlockEventBackButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnlockEventBackButtonClick_hotfix != null)
			{
				this.m_OnUnlockEventBackButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.EnableInput(false);
			this.m_unlockEventStateCtrl.SetToUIState("Close", false, true);
			if (this.m_curUnlockEventIndex >= this.m_unlockEventTitleList.Count)
			{
				this.m_unlockEventStateCtrl.SetActionForUIStateFinshed("Close", delegate
				{
					this.m_unlockEventStateCtrl.gameObject.SetActive(false);
					if (this.m_heroFavoribilityLevelUpRewards != null && this.m_heroFavoribilityLevelUpRewards.Count != 0)
					{
						GetRewardGoodsUITask.StartUITask(this.m_heroFavoribilityLevelUpRewards);
					}
					if (this.m_isInGiftMode)
					{
						this.m_presentContentStateCtrl.SetToUIState("Show", false, true);
						this.m_heroCharUIController.SetCanClick(false);
					}
					CommonUIController.Instance.EnableInput(true);
				});
				this.m_curUnlockEventIndex = 0;
				this.m_heroCharUIController.SetCanClick(true);
				return;
			}
			this.m_unlockEventTitleText.text = this.m_unlockEventTitleList[this.m_curUnlockEventIndex];
			this.m_unlockEventContentText.text = this.m_unlockEventContentList[this.m_curUnlockEventIndex];
			this.m_curUnlockEventIndex++;
			this.m_unlockEventStateCtrl.SetActionForUIStateFinshed("Show", delegate
			{
				CommonUIController.Instance.EnableInput(true);
			});
			this.m_unlockEventStateCtrl.gameObject.SetActive(false);
			this.m_unlockEventStateCtrl.gameObject.SetActive(true);
			this.m_unlockEventStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x0600E433 RID: 58419 RVA: 0x003D60D8 File Offset: 0x003D42D8
		public void UpdateViewInFettersGift(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInFettersGiftHero_hotfix != null)
			{
				this.m_UpdateViewInFettersGiftHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isInGiftMode = true;
			this.m_presentPanel.SetActive(true);
			this.m_presentItemCountShowUIStateCtrl.gameObject.SetActive(false);
			this.m_heroCharUIController.SetCanClick(false);
			this.SetFavorabilityValue();
			this.SetPresentContent();
		}

		// Token: 0x0600E434 RID: 58420 RVA: 0x003D6184 File Offset: 0x003D4384
		public void OpenFettersGift()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenFettersGift_hotfix != null)
			{
				this.m_OpenFettersGift_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIStateDesc currentUIState = this.m_presentStateCtrl.GetCurrentUIState();
			if (!this.m_presentPanel.gameObject.activeSelf || currentUIState == null || currentUIState.StateName != "In")
			{
				this.m_presentStateCtrl.SetToUIState("In", false, true);
			}
		}

		// Token: 0x0600E435 RID: 58421 RVA: 0x003D6234 File Offset: 0x003D4434
		private void SetPresentContent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPresentContent_hotfix != null)
			{
				this.m_SetPresentContent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_giftBagItemCache.Clear();
			List<BagItemBase> list = new List<BagItemBase>();
			List<BagItemBase> list2 = new List<BagItemBase>();
			GameObjectUtility.DestroyChildren(this.m_presentContent);
			foreach (BagItemBase bagItemBase in this.m_playerContext.GetBagItems())
			{
				if (bagItemBase.ItemInfo != null && bagItemBase.ItemInfo.FuncType == ItemFuncType.ItemFuncType_AddHeroFavorabilityExp)
				{
					AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = bagItemBase as AddHeroFavorabilityUseableBagItem;
					if (addHeroFavorabilityUseableBagItem.CalculateAddFavorabilityExp(this.m_hero.HeroId) > addHeroFavorabilityUseableBagItem.NormalAddExp)
					{
						list.Add(bagItemBase);
					}
					else
					{
						list2.Add(bagItemBase);
					}
				}
			}
			list.Sort(new Comparison<BagItemBase>(this.GiftBagItemComparer));
			list2.Sort(new Comparison<BagItemBase>(this.GiftBagItemComparer));
			this.m_giftBagItemCache.AddRange(list);
			this.m_giftBagItemCache.AddRange(list2);
			foreach (BagItemBase bagItemBase2 in this.m_giftBagItemCache)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_presentItemPrefab);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				FettersGiftItemUIController component = gameObject.GetComponent<FettersGiftItemUIController>();
				component.SetGiftItemInfo(bagItemBase2, this.m_hero.HeroId);
				component.EventOnItemClick += this.OnGiftItemClick;
				gameObject.transform.SetParent(this.m_presentContent.transform, false);
				if (this.m_curGiftBagItemCtrl != null && bagItemBase2 == this.m_curGiftBagItemCtrl.BagItem)
				{
					this.m_curGiftBagItemCtrl = component;
					this.m_curGiftBagItemCtrl.ShowSelectFrameImage(true);
				}
			}
			LongPressComponent longPressComponent = this.m_presentSendButton.GetComponent<LongPressComponent>();
			if (longPressComponent == null)
			{
				longPressComponent = this.m_presentSendButton.gameObject.AddComponent<LongPressComponent>();
			}
			longPressComponent.SetBasicParam(0.5f, 0.1f, new Action(this.LocalAddExpTick), new Action(this.OnSendButtonClickDown), new Action(this.SendUseGiftEvent), true);
			if (this.m_curGiftBagItemCtrl != null)
			{
				this.m_presentSendButtonStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_presentSendButtonStateCtrl.SetToUIState("Grey", false, true);
			}
			this.m_presentSendButtonMaskImage.SetActive(this.m_curGiftBagItemCtrl == null);
		}

		// Token: 0x0600E436 RID: 58422 RVA: 0x003D6524 File Offset: 0x003D4724
		private int GiftBagItemComparer(BagItemBase a, BagItemBase b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GiftBagItemComparerBagItemBaseBagItemBase_hotfix != null)
			{
				return Convert.ToInt32(this.m_GiftBagItemComparerBagItemBaseBagItemBase_hotfix.call(new object[]
				{
					this,
					a,
					b
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = a as AddHeroFavorabilityUseableBagItem;
			int num = addHeroFavorabilityUseableBagItem.CalculateAddFavorabilityExp(this.m_hero.HeroId);
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem2 = b as AddHeroFavorabilityUseableBagItem;
			int num2 = addHeroFavorabilityUseableBagItem2.CalculateAddFavorabilityExp(this.m_hero.HeroId);
			int num3 = num - num2;
			if (num3 != 0)
			{
				return num3;
			}
			num3 = a.ItemInfo.Rank - b.ItemInfo.Rank;
			if (num3 == 0)
			{
				return a.ContentId - b.ContentId;
			}
			return num3;
		}

		// Token: 0x0600E437 RID: 58423 RVA: 0x003D6624 File Offset: 0x003D4824
		private void OnSendButtonClickDown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSendButtonClickDown_hotfix != null)
			{
				this.m_OnSendButtonClickDown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sendButtonDownGiftBagItemCtrl = this.m_curGiftBagItemCtrl;
		}

		// Token: 0x0600E438 RID: 58424 RVA: 0x003D6690 File Offset: 0x003D4890
		private void SendUseGiftEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendUseGiftEvent_hotfix != null)
			{
				this.m_SendUseGiftEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curGiftBagItemCtrl == null)
			{
				return;
			}
			if (this.m_sendButtonDownGiftBagItemCtrl != null && this.m_sendButtonDownGiftBagItemCtrl != this.m_curGiftBagItemCtrl)
			{
				this.m_curGiftBagItemCtrl = this.m_sendButtonDownGiftBagItemCtrl;
			}
			if (this.m_totalUseExpItemCount == 0)
			{
				this.m_totalUseExpItemCount = 1;
			}
			if (this.m_totalUseExpItemCount == 1)
			{
				this.OnGiftItemClick(this.m_curGiftBagItemCtrl, false);
				this.LocalAddExpTick();
			}
			base.StartCoroutine(this.WaitTimeThenDoEvent(this.m_totalUseExpItemCount));
		}

		// Token: 0x0600E439 RID: 58425 RVA: 0x003D677C File Offset: 0x003D497C
		[DebuggerHidden]
		private IEnumerator WaitTimeThenDoEvent(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WaitTimeThenDoEventInt32_hotfix != null)
			{
				return (IEnumerator)this.m_WaitTimeThenDoEventInt32_hotfix.call(new object[]
				{
					this,
					count
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FettersFavorabilityUIController.<WaitTimeThenDoEvent>c__Iterator1 <WaitTimeThenDoEvent>c__Iterator = new FettersFavorabilityUIController.<WaitTimeThenDoEvent>c__Iterator1();
			<WaitTimeThenDoEvent>c__Iterator.count = count;
			<WaitTimeThenDoEvent>c__Iterator.$this = this;
			return <WaitTimeThenDoEvent>c__Iterator;
		}

		// Token: 0x0600E43A RID: 58426 RVA: 0x003D6810 File Offset: 0x003D4A10
		private void OnUseGiftItemSucceed(List<Goods> rewards)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUseGiftItemSucceedList`1_hotfix != null)
			{
				this.m_OnUseGiftItemSucceedList`1_hotfix.call(new object[]
				{
					this,
					rewards
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.EnableInput(false);
			this.m_heroFavoribilityLevelUpRewards.Clear();
			this.m_heroFavoribilityLevelUpRewards.AddRange(rewards);
			this.SetFavorabilityValue();
			this.SetPresentContent();
			ConfigDataPerformanceInfo configDataPerformanceInfo = this.m_configDataLoader.GetConfigDataPerformanceInfo(this.m_hero.HeroInfo.m_informationInfo.SendRewardsPerformance);
			System.Random random = new System.Random();
			int index = random.Next(configDataPerformanceInfo.HeroPerformances_ID.Count);
			this.PlayFavorbilityLevelUp(configDataPerformanceInfo.HeroPerformances_ID[index]);
			this.m_totalUseExpItemCount = 0;
		}

		// Token: 0x0600E43B RID: 58427 RVA: 0x003D6900 File Offset: 0x003D4B00
		private void OnGiftItemClick(FettersGiftItemUIController ctrl, bool isNeedShowDesc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGiftItemClickFettersGiftItemUIControllerBoolean_hotfix != null)
			{
				this.m_OnGiftItemClickFettersGiftItemUIControllerBoolean_hotfix.call(new object[]
				{
					this,
					ctrl,
					isNeedShowDesc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ctrl == null || (this.m_sendButtonDownGiftBagItemCtrl != null && ctrl != this.m_sendButtonDownGiftBagItemCtrl))
			{
				return;
			}
			if (this.m_curGiftBagItemCtrl != null)
			{
				this.m_curGiftBagItemCtrl.ShowSelectFrameImage(false);
			}
			if (isNeedShowDesc)
			{
				RewardGoodsDescUITask.StartUITask(ctrl, ctrl.BagItem.GoodsTypeId, ctrl.BagItem.ContentId, 0, null, true);
			}
			this.m_curGiftBagItemCtrl = ctrl;
			ctrl.ShowSelectFrameImage(true);
			this.m_tempFavorabilityLevel = this.m_hero.FavorabilityLevel;
			this.m_tempFavorabilityExp = this.m_hero.FavorabilityExp;
			this.m_tempAddExp = ctrl.AddExpValue;
			this.m_totalUseExpItemCount = 0;
			this.m_heroFavoribilityOldLevel = this.m_hero.FavorabilityLevel;
			Slider slider = (!this.m_isMale) ? this.m_favorabilityFemaleSlider : this.m_favorabilityMaleSlider;
			slider.gameObject.SetActive(true);
			this.m_presentSendButtonStateCtrl.SetToUIState("Normal", false, true);
			this.m_presentSendButtonMaskImage.SetActive(false);
		}

		// Token: 0x0600E43C RID: 58428 RVA: 0x003D6A90 File Offset: 0x003D4C90
		private void LocalAddExpTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LocalAddExpTick_hotfix != null)
			{
				this.m_LocalAddExpTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_totalUseExpItemCount++;
			if (this.m_curGiftBagItemCtrl == null)
			{
				return;
			}
			int num = this.m_playerContext.ImitateUseHeroFavorabilityExpItem(this.m_hero.HeroId, this.m_curGiftBagItemCtrl.BagItem.ContentId, this.m_totalUseExpItemCount, GoodsType.GoodsType_Item);
			if (num != 0)
			{
				this.m_totalUseExpItemCount--;
				if (this.m_totalUseExpItemCount == 0)
				{
					if (num == -500)
					{
						if (this.EventOnGotoBagFullPanel != null)
						{
							this.EventOnGotoBagFullPanel();
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
					}
				}
				return;
			}
			this.m_curGiftBagItemCtrl.SetCountTextValue(this.m_totalUseExpItemCount);
			ConfigDataHeroInformationInfo informationInfo = this.m_hero.HeroInfo.m_informationInfo;
			int num2 = this.m_tempFavorabilityExp;
			int tempFavorabilityLevel = this.m_tempFavorabilityLevel;
			int num3 = this.m_tempAddExp;
			while (informationInfo.FavorabilityMaxLevel != this.m_tempFavorabilityLevel)
			{
				int nextExp = this.m_configDataLoader.GetConfigDataHeroFavorabilityLevelInfo(this.m_tempFavorabilityLevel).NextExp;
				if (num2 + num3 < nextExp)
				{
					num2 += num3;
				}
				else
				{
					this.m_tempFavorabilityLevel++;
					num3 = num2 + num3 - nextExp;
					num2 = 0;
					if (num3 > 0)
					{
						continue;
					}
				}
				IL_195:
				if (num3 > 0)
				{
					this.m_tempFavorabilityExp = num2;
				}
				else
				{
					this.m_tempFavorabilityExp = num3;
				}
				this.m_favorabilityLvText.text = this.m_tempFavorabilityLevel.ToString();
				nextExp = this.m_configDataLoader.GetConfigDataHeroFavorabilityLevelInfo(this.m_tempFavorabilityLevel).NextExp;
				this.m_favorabilityValueText.text = this.m_tempFavorabilityExp + "/" + nextExp;
				float finalSliderValue = (float)this.m_tempFavorabilityExp / (float)nextExp;
				base.StartCoroutine(this.Co_SetFavorabilityValue(tempFavorabilityLevel, this.m_tempFavorabilityLevel - tempFavorabilityLevel, finalSliderValue));
				this.SetItemCountPanel();
				return;
			}
			goto IL_195;
		}

		// Token: 0x0600E43D RID: 58429 RVA: 0x003D6CD4 File Offset: 0x003D4ED4
		[DebuggerHidden]
		private IEnumerator Co_SetFavorabilityValue(int curFavoribilityLv, int addLv, float finalSliderValue)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_SetFavorabilityValueInt32Int32Single_hotfix != null)
			{
				return (IEnumerator)this.m_Co_SetFavorabilityValueInt32Int32Single_hotfix.call(new object[]
				{
					this,
					curFavoribilityLv,
					addLv,
					finalSliderValue
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FettersFavorabilityUIController.<Co_SetFavorabilityValue>c__Iterator2 <Co_SetFavorabilityValue>c__Iterator = new FettersFavorabilityUIController.<Co_SetFavorabilityValue>c__Iterator2();
			<Co_SetFavorabilityValue>c__Iterator.addLv = addLv;
			<Co_SetFavorabilityValue>c__Iterator.curFavoribilityLv = curFavoribilityLv;
			<Co_SetFavorabilityValue>c__Iterator.finalSliderValue = finalSliderValue;
			<Co_SetFavorabilityValue>c__Iterator.$this = this;
			return <Co_SetFavorabilityValue>c__Iterator;
		}

		// Token: 0x0600E43E RID: 58430 RVA: 0x003D6D94 File Offset: 0x003D4F94
		private void SetItemCountPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetItemCountPanel_hotfix != null)
			{
				this.m_SetItemCountPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_totalUseExpItemCount == 1)
			{
				this.m_presentItemCountShowUIStateCtrl.gameObject.SetActive(true);
				UIStateDesc currentUIState = this.m_presentItemCountShowUIStateCtrl.GetCurrentUIState();
				if (currentUIState != null)
				{
					if (currentUIState.StateName != "Show")
					{
						this.m_presentItemCountShowUIStateCtrl.SetToUIState("Show", false, true);
					}
				}
				else
				{
					this.m_presentItemCountShowUIStateCtrl.SetToUIState("Show", false, true);
				}
			}
			else
			{
				if (!this.m_presentItemCountShowUIStateCtrl.gameObject.activeSelf)
				{
					this.m_presentItemCountShowUIStateCtrl.gameObject.SetActive(true);
					UIStateDesc currentUIState2 = this.m_presentItemCountShowUIStateCtrl.GetCurrentUIState();
					if (currentUIState2 != null)
					{
						if (currentUIState2.StateName != "Show")
						{
							this.m_presentItemCountShowUIStateCtrl.SetToUIState("Show", false, true);
						}
					}
					else
					{
						this.m_presentItemCountShowUIStateCtrl.SetToUIState("Show", false, true);
					}
				}
				this.m_presentContinuousTouchUIStateCtrl.SetToUIState("Show", false, true);
			}
			int addExpValue = this.m_curGiftBagItemCtrl.AddExpValue;
			this.m_favorabilityAddValueText.text = "+" + addExpValue;
			this.m_presentExpEffect.SetToUIState("Show", false, true);
			BagItemBase bagItem = this.m_curGiftBagItemCtrl.BagItem;
			this.m_presentItemCountText.text = this.m_totalUseExpItemCount.ToString();
			Image presentItemIconImage = this.m_presentItemIconImage;
			Sprite sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(bagItem.GoodsTypeId, bagItem.ContentId));
			this.m_presentItemIconEffectImage.sprite = sprite;
			presentItemIconImage.sprite = sprite;
			Graphic presentItemIconImage2 = this.m_presentItemIconImage;
			Material asset = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(bagItem.GoodsTypeId, bagItem.ContentId));
			this.m_presentItemIconEffectImage.material = asset;
			presentItemIconImage2.material = asset;
		}

		// Token: 0x0600E43F RID: 58431 RVA: 0x003D6FC0 File Offset: 0x003D51C0
		public void PlayHeroPerformance(int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayHeroPerformanceInt32_hotfix != null)
			{
				this.m_PlayHeroPerformanceInt32_hotfix.call(new object[]
				{
					this,
					heroPerformanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroCharUIController.PlayOneSpecifiedPerformance(heroPerformanceId);
		}

		// Token: 0x0600E440 RID: 58432 RVA: 0x003D7040 File Offset: 0x003D5240
		public void GoToInformationPanel(bool isGotoOrReturn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoToInformationPanelBoolean_hotfix != null)
			{
				this.m_GoToInformationPanelBoolean_hotfix.call(new object[]
				{
					this,
					isGotoOrReturn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isGotoOrReturn)
			{
				this.m_infoStateCtrl.SetToUIState("Out", false, true);
			}
			else
			{
				this.m_infoStateCtrl.SetToUIState("In", false, true);
			}
			this.InactiveWordGameObject();
		}

		// Token: 0x0600E441 RID: 58433 RVA: 0x003D70E8 File Offset: 0x003D52E8
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isInGiftMode)
			{
				if (this.EventOnReturn != null)
				{
					this.EventOnReturn();
				}
				this.m_progressEffectGroup.SetActive(false);
				Input.multiTouchEnabled = true;
			}
			else
			{
				CommonUIController.Instance.EnableInput(false);
				UIStateDesc uistateDescByName = this.m_presentStateCtrl.GetUIStateDescByName("Out");
				float num = 0f;
				foreach (TweenMain tweenMain in uistateDescByName.TweenAnimationList)
				{
					if (!(tweenMain == null))
					{
						float num2 = tweenMain.duration + tweenMain.delay;
						if (num2 > num)
						{
							num = num2;
						}
					}
				}
				this.m_presentStateCtrl.SetToUIState("Out", false, true);
				base.StartCoroutine(this.Co_OnAnimationFinishedEnableInput(num));
				this.m_heroCharUIController.SetCanClick(true);
				this.ResetGiftScrollViewPosition();
				this.m_curGiftBagItemCtrl = null;
			}
			this.InactiveWordGameObject();
		}

		// Token: 0x0600E442 RID: 58434 RVA: 0x003D7254 File Offset: 0x003D5454
		[DebuggerHidden]
		private IEnumerator Co_OnAnimationFinishedEnableInput(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_OnAnimationFinishedEnableInputSingle_hotfix != null)
			{
				return (IEnumerator)this.m_Co_OnAnimationFinishedEnableInputSingle_hotfix.call(new object[]
				{
					this,
					time
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FettersFavorabilityUIController.<Co_OnAnimationFinishedEnableInput>c__Iterator3 <Co_OnAnimationFinishedEnableInput>c__Iterator = new FettersFavorabilityUIController.<Co_OnAnimationFinishedEnableInput>c__Iterator3();
			<Co_OnAnimationFinishedEnableInput>c__Iterator.time = time;
			<Co_OnAnimationFinishedEnableInput>c__Iterator.$this = this;
			return <Co_OnAnimationFinishedEnableInput>c__Iterator;
		}

		// Token: 0x0600E443 RID: 58435 RVA: 0x003D72E8 File Offset: 0x003D54E8
		private void OnHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHelpButtonClick_hotfix != null)
			{
				this.m_OnHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelp != null)
			{
				this.EventOnShowHelp();
			}
		}

		// Token: 0x0600E444 RID: 58436 RVA: 0x003D7360 File Offset: 0x003D5560
		private void OnInformationButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInformationButtonClick_hotfix != null)
			{
				this.m_OnInformationButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Input.multiTouchEnabled = true;
			if (this.EventOnInformationButtonClick != null)
			{
				this.EventOnInformationButtonClick(this.m_hero);
			}
			this.InactiveWordGameObject();
		}

		// Token: 0x0600E445 RID: 58437 RVA: 0x003D73E8 File Offset: 0x003D55E8
		private void OnFettersButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFettersButtonClick_hotfix != null)
			{
				this.m_OnFettersButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Input.multiTouchEnabled = true;
			if (this.EventOnFettersButtonClick != null)
			{
				this.EventOnFettersButtonClick(this.m_hero);
			}
			this.InactiveWordGameObject();
		}

		// Token: 0x0600E446 RID: 58438 RVA: 0x003D7470 File Offset: 0x003D5670
		private void OnMemoryButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryButtonClick_hotfix != null)
			{
				this.m_OnMemoryButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Input.multiTouchEnabled = true;
			List<int> dungeonLevels_ID = this.m_hero.HeroInfo.m_informationInfo.DungeonLevels_ID;
			bool isDungeonLevelsUnLock = this.m_hero.HeroInfo.m_informationInfo.IsDungeonLevelsUnLock;
			if (isDungeonLevelsUnLock && dungeonLevels_ID.Count > 0)
			{
				if (this.EventOnMemoryButtonClick != null)
				{
					this.EventOnMemoryButtonClick(this.m_hero);
				}
				this.InactiveWordGameObject();
			}
			else
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_NotOpenNow, 2f, null, true);
			}
		}

		// Token: 0x0600E447 RID: 58439 RVA: 0x003D7554 File Offset: 0x003D5754
		private void OnGiftButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGiftButtonClick_hotfix != null)
			{
				this.m_OnGiftButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGiftButtonClick != null)
			{
				this.EventOnGiftButtonClick(this.m_hero);
			}
			this.InactiveWordGameObject();
		}

		// Token: 0x0600E448 RID: 58440 RVA: 0x003D75D8 File Offset: 0x003D57D8
		private void ResetGiftScrollViewPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetGiftScrollViewPosition_hotfix != null)
			{
				this.m_ResetGiftScrollViewPosition_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_presentScrollRect.normalizedPosition = Vector2.zero;
		}

		// Token: 0x0600E449 RID: 58441 RVA: 0x003D7648 File Offset: 0x003D5848
		private void InactiveWordGameObject()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InactiveWordGameObject_hotfix != null)
			{
				this.m_InactiveWordGameObject_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_wordGameObject.SetActive(false);
		}

		// Token: 0x140002DF RID: 735
		// (add) Token: 0x0600E44A RID: 58442 RVA: 0x003D76B4 File Offset: 0x003D58B4
		// (remove) Token: 0x0600E44B RID: 58443 RVA: 0x003D7750 File Offset: 0x003D5950
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002E0 RID: 736
		// (add) Token: 0x0600E44C RID: 58444 RVA: 0x003D77EC File Offset: 0x003D59EC
		// (remove) Token: 0x0600E44D RID: 58445 RVA: 0x003D7888 File Offset: 0x003D5A88
		public event Action EventOnShowHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002E1 RID: 737
		// (add) Token: 0x0600E44E RID: 58446 RVA: 0x003D7924 File Offset: 0x003D5B24
		// (remove) Token: 0x0600E44F RID: 58447 RVA: 0x003D79C0 File Offset: 0x003D5BC0
		public event Action EventOnSliderFull
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSliderFullAction_hotfix != null)
				{
					this.m_add_EventOnSliderFullAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSliderFull;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSliderFull, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSliderFullAction_hotfix != null)
				{
					this.m_remove_EventOnSliderFullAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSliderFull;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSliderFull, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002E2 RID: 738
		// (add) Token: 0x0600E450 RID: 58448 RVA: 0x003D7A5C File Offset: 0x003D5C5C
		// (remove) Token: 0x0600E451 RID: 58449 RVA: 0x003D7AF8 File Offset: 0x003D5CF8
		public event Action<Hero> EventOnGiftButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGiftButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGiftButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnGiftButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnGiftButtonClick, (Action<Hero>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGiftButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGiftButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnGiftButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnGiftButtonClick, (Action<Hero>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002E3 RID: 739
		// (add) Token: 0x0600E452 RID: 58450 RVA: 0x003D7B94 File Offset: 0x003D5D94
		// (remove) Token: 0x0600E453 RID: 58451 RVA: 0x003D7C30 File Offset: 0x003D5E30
		public event Action<Hero> EventOnMemoryButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnMemoryButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnMemoryButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnMemoryButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnMemoryButtonClick, (Action<Hero>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnMemoryButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnMemoryButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnMemoryButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnMemoryButtonClick, (Action<Hero>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002E4 RID: 740
		// (add) Token: 0x0600E454 RID: 58452 RVA: 0x003D7CCC File Offset: 0x003D5ECC
		// (remove) Token: 0x0600E455 RID: 58453 RVA: 0x003D7D68 File Offset: 0x003D5F68
		public event Action<Hero> EventOnFettersButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFettersButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnFettersButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnFettersButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnFettersButtonClick, (Action<Hero>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFettersButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnFettersButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnFettersButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnFettersButtonClick, (Action<Hero>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002E5 RID: 741
		// (add) Token: 0x0600E456 RID: 58454 RVA: 0x003D7E04 File Offset: 0x003D6004
		// (remove) Token: 0x0600E457 RID: 58455 RVA: 0x003D7EA0 File Offset: 0x003D60A0
		public event Action<Hero> EventOnInformationButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnInformationButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnInformationButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnInformationButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnInformationButtonClick, (Action<Hero>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnInformationButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnInformationButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnInformationButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnInformationButtonClick, (Action<Hero>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002E6 RID: 742
		// (add) Token: 0x0600E458 RID: 58456 RVA: 0x003D7F3C File Offset: 0x003D613C
		// (remove) Token: 0x0600E459 RID: 58457 RVA: 0x003D7FD8 File Offset: 0x003D61D8
		public event Action<GoodsType, int, int, Action<List<Goods>>> EventOnUseGift
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUseGiftAction`4_hotfix != null)
				{
					this.m_add_EventOnUseGiftAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int, Action<List<Goods>>> action = this.EventOnUseGift;
				Action<GoodsType, int, int, Action<List<Goods>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int, Action<List<Goods>>>>(ref this.EventOnUseGift, (Action<GoodsType, int, int, Action<List<Goods>>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUseGiftAction`4_hotfix != null)
				{
					this.m_remove_EventOnUseGiftAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int, Action<List<Goods>>> action = this.EventOnUseGift;
				Action<GoodsType, int, int, Action<List<Goods>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int, Action<List<Goods>>>>(ref this.EventOnUseGift, (Action<GoodsType, int, int, Action<List<Goods>>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002E7 RID: 743
		// (add) Token: 0x0600E45A RID: 58458 RVA: 0x003D8074 File Offset: 0x003D6274
		// (remove) Token: 0x0600E45B RID: 58459 RVA: 0x003D8110 File Offset: 0x003D6310
		public event Action EventOnGotoBagFullPanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoBagFullPanelAction_hotfix != null)
				{
					this.m_add_EventOnGotoBagFullPanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGotoBagFullPanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGotoBagFullPanel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoBagFullPanelAction_hotfix != null)
				{
					this.m_remove_EventOnGotoBagFullPanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGotoBagFullPanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGotoBagFullPanel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x0600E45C RID: 58460 RVA: 0x003D81AC File Offset: 0x003D63AC
		// (set) Token: 0x0600E45D RID: 58461 RVA: 0x003D81CC File Offset: 0x003D63CC
		[DoNotToLua]
		public new FettersFavorabilityUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersFavorabilityUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E45E RID: 58462 RVA: 0x003D81D8 File Offset: 0x003D63D8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E45F RID: 58463 RVA: 0x003D81E4 File Offset: 0x003D63E4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E460 RID: 58464 RVA: 0x003D81EC File Offset: 0x003D63EC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E461 RID: 58465 RVA: 0x003D81F4 File Offset: 0x003D63F4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E462 RID: 58466 RVA: 0x003D8208 File Offset: 0x003D6408
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E463 RID: 58467 RVA: 0x003D8210 File Offset: 0x003D6410
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E464 RID: 58468 RVA: 0x003D821C File Offset: 0x003D641C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E465 RID: 58469 RVA: 0x003D8228 File Offset: 0x003D6428
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E466 RID: 58470 RVA: 0x003D8234 File Offset: 0x003D6434
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E467 RID: 58471 RVA: 0x003D8240 File Offset: 0x003D6440
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E468 RID: 58472 RVA: 0x003D824C File Offset: 0x003D644C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E469 RID: 58473 RVA: 0x003D8258 File Offset: 0x003D6458
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E46A RID: 58474 RVA: 0x003D8264 File Offset: 0x003D6464
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E46B RID: 58475 RVA: 0x003D8270 File Offset: 0x003D6470
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E46C RID: 58476 RVA: 0x003D827C File Offset: 0x003D647C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E46D RID: 58477 RVA: 0x003D8284 File Offset: 0x003D6484
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600E46E RID: 58478 RVA: 0x003D82A4 File Offset: 0x003D64A4
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600E46F RID: 58479 RVA: 0x003D82B0 File Offset: 0x003D64B0
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600E470 RID: 58480 RVA: 0x003D82D0 File Offset: 0x003D64D0
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600E471 RID: 58481 RVA: 0x003D82DC File Offset: 0x003D64DC
		private void __callDele_EventOnSliderFull()
		{
			Action eventOnSliderFull = this.EventOnSliderFull;
			if (eventOnSliderFull != null)
			{
				eventOnSliderFull();
			}
		}

		// Token: 0x0600E472 RID: 58482 RVA: 0x003D82FC File Offset: 0x003D64FC
		private void __clearDele_EventOnSliderFull()
		{
			this.EventOnSliderFull = null;
		}

		// Token: 0x0600E473 RID: 58483 RVA: 0x003D8308 File Offset: 0x003D6508
		private void __callDele_EventOnGiftButtonClick(Hero obj)
		{
			Action<Hero> eventOnGiftButtonClick = this.EventOnGiftButtonClick;
			if (eventOnGiftButtonClick != null)
			{
				eventOnGiftButtonClick(obj);
			}
		}

		// Token: 0x0600E474 RID: 58484 RVA: 0x003D832C File Offset: 0x003D652C
		private void __clearDele_EventOnGiftButtonClick(Hero obj)
		{
			this.EventOnGiftButtonClick = null;
		}

		// Token: 0x0600E475 RID: 58485 RVA: 0x003D8338 File Offset: 0x003D6538
		private void __callDele_EventOnMemoryButtonClick(Hero obj)
		{
			Action<Hero> eventOnMemoryButtonClick = this.EventOnMemoryButtonClick;
			if (eventOnMemoryButtonClick != null)
			{
				eventOnMemoryButtonClick(obj);
			}
		}

		// Token: 0x0600E476 RID: 58486 RVA: 0x003D835C File Offset: 0x003D655C
		private void __clearDele_EventOnMemoryButtonClick(Hero obj)
		{
			this.EventOnMemoryButtonClick = null;
		}

		// Token: 0x0600E477 RID: 58487 RVA: 0x003D8368 File Offset: 0x003D6568
		private void __callDele_EventOnFettersButtonClick(Hero obj)
		{
			Action<Hero> eventOnFettersButtonClick = this.EventOnFettersButtonClick;
			if (eventOnFettersButtonClick != null)
			{
				eventOnFettersButtonClick(obj);
			}
		}

		// Token: 0x0600E478 RID: 58488 RVA: 0x003D838C File Offset: 0x003D658C
		private void __clearDele_EventOnFettersButtonClick(Hero obj)
		{
			this.EventOnFettersButtonClick = null;
		}

		// Token: 0x0600E479 RID: 58489 RVA: 0x003D8398 File Offset: 0x003D6598
		private void __callDele_EventOnInformationButtonClick(Hero obj)
		{
			Action<Hero> eventOnInformationButtonClick = this.EventOnInformationButtonClick;
			if (eventOnInformationButtonClick != null)
			{
				eventOnInformationButtonClick(obj);
			}
		}

		// Token: 0x0600E47A RID: 58490 RVA: 0x003D83BC File Offset: 0x003D65BC
		private void __clearDele_EventOnInformationButtonClick(Hero obj)
		{
			this.EventOnInformationButtonClick = null;
		}

		// Token: 0x0600E47B RID: 58491 RVA: 0x003D83C8 File Offset: 0x003D65C8
		private void __callDele_EventOnUseGift(GoodsType arg1, int arg2, int arg3, Action<List<Goods>> arg4)
		{
			Action<GoodsType, int, int, Action<List<Goods>>> eventOnUseGift = this.EventOnUseGift;
			if (eventOnUseGift != null)
			{
				eventOnUseGift(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x0600E47C RID: 58492 RVA: 0x003D83F0 File Offset: 0x003D65F0
		private void __clearDele_EventOnUseGift(GoodsType arg1, int arg2, int arg3, Action<List<Goods>> arg4)
		{
			this.EventOnUseGift = null;
		}

		// Token: 0x0600E47D RID: 58493 RVA: 0x003D83FC File Offset: 0x003D65FC
		private void __callDele_EventOnGotoBagFullPanel()
		{
			Action eventOnGotoBagFullPanel = this.EventOnGotoBagFullPanel;
			if (eventOnGotoBagFullPanel != null)
			{
				eventOnGotoBagFullPanel();
			}
		}

		// Token: 0x0600E47E RID: 58494 RVA: 0x003D841C File Offset: 0x003D661C
		private void __clearDele_EventOnGotoBagFullPanel()
		{
			this.EventOnGotoBagFullPanel = null;
		}

		// Token: 0x0600E482 RID: 58498 RVA: 0x003D84C8 File Offset: 0x003D66C8
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
					this.m_UpdateViewInFettersFavorabilityHero_hotfix = (luaObj.RawGet("UpdateViewInFettersFavorability") as LuaFunction);
					this.m_OpenFettersFavorability_hotfix = (luaObj.RawGet("OpenFettersFavorability") as LuaFunction);
					this.m_SetFavorabilityValue_hotfix = (luaObj.RawGet("SetFavorabilityValue") as LuaFunction);
					this.m_SetTouchCountState_hotfix = (luaObj.RawGet("SetTouchCountState") as LuaFunction);
					this.m_SetTouchRecoverTimeTimeSpan_hotfix = (luaObj.RawGet("SetTouchRecoverTime") as LuaFunction);
					this.m_DragTrigger_EventOnSliderFull_hotfix = (luaObj.RawGet("DragTrigger_EventOnSliderFull") as LuaFunction);
					this.m_DragTrigger_EventOnClick_hotfix = (luaObj.RawGet("DragTrigger_EventOnClick") as LuaFunction);
					this.m_DragTrigger_EventOnEndDrag_hotfix = (luaObj.RawGet("DragTrigger_EventOnEndDrag") as LuaFunction);
					this.m_DragTrigger_EventOnBeginDrag_hotfix = (luaObj.RawGet("DragTrigger_EventOnBeginDrag") as LuaFunction);
					this.m_DragTrigger_EventOnSliderEmpty_hotfix = (luaObj.RawGet("DragTrigger_EventOnSliderEmpty") as LuaFunction);
					this.m_SetTouchStateCtrlOutString_hotfix = (luaObj.RawGet("SetTouchStateCtrlOut") as LuaFunction);
					this.m_SetCharGoTweenPosBoolean_hotfix = (luaObj.RawGet("SetCharGoTweenPos") as LuaFunction);
					this.m_OnHeroInteractSucceedList`1Int32HeroInteractionResultTypeInt32_hotfix = (luaObj.RawGet("OnHeroInteractSucceed") as LuaFunction);
					this.m_AfterHeroInteractionResultEffectStringInt32_hotfix = (luaObj.RawGet("AfterHeroInteractionResultEffect") as LuaFunction);
					this.m_PlayFavorbilityLevelUpInt32_hotfix = (luaObj.RawGet("PlayFavorbilityLevelUp") as LuaFunction);
					this.m_Co_PlayHeroInteractEffectInt32_hotfix = (luaObj.RawGet("Co_PlayHeroInteractEffect") as LuaFunction);
					this.m_OnCharContinueButtonClick_hotfix = (luaObj.RawGet("OnCharContinueButtonClick") as LuaFunction);
					this.m_ShowUnlockEvents_hotfix = (luaObj.RawGet("ShowUnlockEvents") as LuaFunction);
					this.m_GetUnlockEventsHero_hotfix = (luaObj.RawGet("GetUnlockEvents") as LuaFunction);
					this.m_OnUnlockEventBackButtonClick_hotfix = (luaObj.RawGet("OnUnlockEventBackButtonClick") as LuaFunction);
					this.m_UpdateViewInFettersGiftHero_hotfix = (luaObj.RawGet("UpdateViewInFettersGift") as LuaFunction);
					this.m_OpenFettersGift_hotfix = (luaObj.RawGet("OpenFettersGift") as LuaFunction);
					this.m_SetPresentContent_hotfix = (luaObj.RawGet("SetPresentContent") as LuaFunction);
					this.m_GiftBagItemComparerBagItemBaseBagItemBase_hotfix = (luaObj.RawGet("GiftBagItemComparer") as LuaFunction);
					this.m_OnSendButtonClickDown_hotfix = (luaObj.RawGet("OnSendButtonClickDown") as LuaFunction);
					this.m_SendUseGiftEvent_hotfix = (luaObj.RawGet("SendUseGiftEvent") as LuaFunction);
					this.m_WaitTimeThenDoEventInt32_hotfix = (luaObj.RawGet("WaitTimeThenDoEvent") as LuaFunction);
					this.m_OnUseGiftItemSucceedList`1_hotfix = (luaObj.RawGet("OnUseGiftItemSucceed") as LuaFunction);
					this.m_OnGiftItemClickFettersGiftItemUIControllerBoolean_hotfix = (luaObj.RawGet("OnGiftItemClick") as LuaFunction);
					this.m_LocalAddExpTick_hotfix = (luaObj.RawGet("LocalAddExpTick") as LuaFunction);
					this.m_Co_SetFavorabilityValueInt32Int32Single_hotfix = (luaObj.RawGet("Co_SetFavorabilityValue") as LuaFunction);
					this.m_SetItemCountPanel_hotfix = (luaObj.RawGet("SetItemCountPanel") as LuaFunction);
					this.m_PlayHeroPerformanceInt32_hotfix = (luaObj.RawGet("PlayHeroPerformance") as LuaFunction);
					this.m_GoToInformationPanelBoolean_hotfix = (luaObj.RawGet("GoToInformationPanel") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_Co_OnAnimationFinishedEnableInputSingle_hotfix = (luaObj.RawGet("Co_OnAnimationFinishedEnableInput") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnInformationButtonClick_hotfix = (luaObj.RawGet("OnInformationButtonClick") as LuaFunction);
					this.m_OnFettersButtonClick_hotfix = (luaObj.RawGet("OnFettersButtonClick") as LuaFunction);
					this.m_OnMemoryButtonClick_hotfix = (luaObj.RawGet("OnMemoryButtonClick") as LuaFunction);
					this.m_OnGiftButtonClick_hotfix = (luaObj.RawGet("OnGiftButtonClick") as LuaFunction);
					this.m_ResetGiftScrollViewPosition_hotfix = (luaObj.RawGet("ResetGiftScrollViewPosition") as LuaFunction);
					this.m_InactiveWordGameObject_hotfix = (luaObj.RawGet("InactiveWordGameObject") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnSliderFullAction_hotfix = (luaObj.RawGet("add_EventOnSliderFull") as LuaFunction);
					this.m_remove_EventOnSliderFullAction_hotfix = (luaObj.RawGet("remove_EventOnSliderFull") as LuaFunction);
					this.m_add_EventOnGiftButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGiftButtonClick") as LuaFunction);
					this.m_remove_EventOnGiftButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGiftButtonClick") as LuaFunction);
					this.m_add_EventOnMemoryButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnMemoryButtonClick") as LuaFunction);
					this.m_remove_EventOnMemoryButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnMemoryButtonClick") as LuaFunction);
					this.m_add_EventOnFettersButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnFettersButtonClick") as LuaFunction);
					this.m_remove_EventOnFettersButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnFettersButtonClick") as LuaFunction);
					this.m_add_EventOnInformationButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnInformationButtonClick") as LuaFunction);
					this.m_remove_EventOnInformationButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnInformationButtonClick") as LuaFunction);
					this.m_add_EventOnUseGiftAction`4_hotfix = (luaObj.RawGet("add_EventOnUseGift") as LuaFunction);
					this.m_remove_EventOnUseGiftAction`4_hotfix = (luaObj.RawGet("remove_EventOnUseGift") as LuaFunction);
					this.m_add_EventOnGotoBagFullPanelAction_hotfix = (luaObj.RawGet("add_EventOnGotoBagFullPanel") as LuaFunction);
					this.m_remove_EventOnGotoBagFullPanelAction_hotfix = (luaObj.RawGet("remove_EventOnGotoBagFullPanel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E483 RID: 58499 RVA: 0x003D8BA4 File Offset: 0x003D6DA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersFavorabilityUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040089DB RID: 35291
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x040089DC RID: 35292
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_commonUIStateCtrl;

		// Token: 0x040089DD RID: 35293
		[AutoBind("./MaleOrFemale", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_sexStateCtrl;

		// Token: 0x040089DE RID: 35294
		[AutoBind("./TouchOrNot", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_touchInOutStateCtrl;

		// Token: 0x040089DF RID: 35295
		[AutoBind("./LevelUpEffect", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_levelUpStateCtrl;

		// Token: 0x040089E0 RID: 35296
		[AutoBind("./TouchEffect", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_touchStateCtrl;

		// Token: 0x040089E1 RID: 35297
		[AutoBind("./InfoPanelEffect", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_infoStateCtrl;

		// Token: 0x040089E2 RID: 35298
		[AutoBind("./PresentEffect", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_presentStateCtrl;

		// Token: 0x040089E3 RID: 35299
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x040089E4 RID: 35300
		[AutoBind("./ReturnButton/HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x040089E5 RID: 35301
		[AutoBind("./Margin/Favorability/ValueTextGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_favorabilityValueTextStateCtrl;

		// Token: 0x040089E6 RID: 35302
		[AutoBind("./Margin/Favorability/ValueTextGroup/ValueNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_favorabilityValueText;

		// Token: 0x040089E7 RID: 35303
		[AutoBind("./Margin/Favorability/UpArrow", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_favorabilityAddUpArrowGo;

		// Token: 0x040089E8 RID: 35304
		[AutoBind("./Margin/Favorability/UpArrowText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_favorabilityAddValueText;

		// Token: 0x040089E9 RID: 35305
		[AutoBind("./Margin/Favorability/HeroNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_favorabilityHeroNameText;

		// Token: 0x040089EA RID: 35306
		[AutoBind("./Margin/Favorability/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_favorabilityLvText;

		// Token: 0x040089EB RID: 35307
		[AutoBind("./Margin/Favorability/MaleSlider", AutoBindAttribute.InitState.NotInit, false)]
		private Slider m_favorabilityMaleSlider;

		// Token: 0x040089EC RID: 35308
		[AutoBind("./Margin/Favorability/FemaleSlider", AutoBindAttribute.InitState.NotInit, false)]
		private Slider m_favorabilityFemaleSlider;

		// Token: 0x040089ED RID: 35309
		[AutoBind("./Margin/Favorability/LevelUpEffectGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_levelUpEffectGroupGameObject;

		// Token: 0x040089EE RID: 35310
		[AutoBind("./FemaleQinMiDu", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_femaleQinMiDuGameObject;

		// Token: 0x040089EF RID: 35311
		[AutoBind("./MaleQinMiDu", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_maleQinMiDuGameObject;

		// Token: 0x040089F0 RID: 35312
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGameObjectRoot;

		// Token: 0x040089F1 RID: 35313
		[AutoBind("./Char/0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGameObject;

		// Token: 0x040089F2 RID: 35314
		[AutoBind("./Word", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_wordGameObject;

		// Token: 0x040089F3 RID: 35315
		[AutoBind("./ContinueButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_charContinueButton;

		// Token: 0x040089F4 RID: 35316
		[AutoBind("./Margin/Touch", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_touchNumberStateCtrl;

		// Token: 0x040089F5 RID: 35317
		[AutoBind("./Margin/Touch/CountGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_touchCountStateCtrl;

		// Token: 0x040089F6 RID: 35318
		[AutoBind("./Margin/Touch/TimeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_touchTimeText;

		// Token: 0x040089F7 RID: 35319
		[AutoBind("./ProgressGroup/EffectSlider", AutoBindAttribute.InitState.NotInit, false)]
		private Slider m_progressEffectSlider;

		// Token: 0x040089F8 RID: 35320
		[AutoBind("./ProgressGroup/MaleSlider", AutoBindAttribute.InitState.NotInit, false)]
		private Slider m_progressMaleSlider;

		// Token: 0x040089F9 RID: 35321
		[AutoBind("./ProgressGroup/FrmaleSlider", AutoBindAttribute.InitState.NotInit, false)]
		private Slider m_progressFemaleSlider;

		// Token: 0x040089FA RID: 35322
		[AutoBind("./ProgressGroup/EffectGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_progressEffectGroup;

		// Token: 0x040089FB RID: 35323
		[AutoBind("./MaleBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_maleBGImage;

		// Token: 0x040089FC RID: 35324
		[AutoBind("./FemaleBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_femaleBGImage;

		// Token: 0x040089FD RID: 35325
		[AutoBind("./LevelUpStarEffectGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_levelUpStarEffectGroup;

		// Token: 0x040089FE RID: 35326
		[AutoBind("./Margin/Information", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_informationButton;

		// Token: 0x040089FF RID: 35327
		[AutoBind("./Margin/Information/NewImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_informationButtonNewImage;

		// Token: 0x04008A00 RID: 35328
		[AutoBind("./Margin/ToggleGroup/Fetters", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_fettersButton;

		// Token: 0x04008A01 RID: 35329
		[AutoBind("./Margin/ToggleGroup/Fetters/NewImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_fettersButtonRedMark;

		// Token: 0x04008A02 RID: 35330
		[AutoBind("./Margin/ToggleGroup/Fetters/PercentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_fettersButtonPercentText;

		// Token: 0x04008A03 RID: 35331
		[AutoBind("./Margin/ToggleGroup/Memory", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_memoryButton;

		// Token: 0x04008A04 RID: 35332
		[AutoBind("./Margin/ToggleGroup/Memory", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_memoryButtonStateCtrl;

		// Token: 0x04008A05 RID: 35333
		[AutoBind("./Margin/ToggleGroup/Memory/NewImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_memoryButtonNewImage;

		// Token: 0x04008A06 RID: 35334
		[AutoBind("./Margin/ToggleGroup/Memory/PercentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_memoryButtonPercentText;

		// Token: 0x04008A07 RID: 35335
		[AutoBind("./Margin/ToggleGroup/Present", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_presentButton;

		// Token: 0x04008A08 RID: 35336
		[AutoBind("./TouchImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_touchImage;

		// Token: 0x04008A09 RID: 35337
		[AutoBind("./UnlockEvent", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_unlockEventStateCtrl;

		// Token: 0x04008A0A RID: 35338
		[AutoBind("./UnlockEvent/Detail/Panel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unlockEventTitleText;

		// Token: 0x04008A0B RID: 35339
		[AutoBind("./UnlockEvent/Detail/Panel/InfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unlockEventContentText;

		// Token: 0x04008A0C RID: 35340
		[AutoBind("./UnlockEvent/BackButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_unlockEventBackButton;

		// Token: 0x04008A0D RID: 35341
		[AutoBind("./PresentPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_presentPanel;

		// Token: 0x04008A0E RID: 35342
		[AutoBind("./PresentPanel/ItemScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_presentContentStateCtrl;

		// Token: 0x04008A0F RID: 35343
		[AutoBind("./PresentPanel/ItemScrollView/Scroll View", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_presentScrollRect;

		// Token: 0x04008A10 RID: 35344
		[AutoBind("./PresentPanel/ItemScrollView/Scroll View/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_presentContent;

		// Token: 0x04008A11 RID: 35345
		[AutoBind("./PresentPanel/ItemCount", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_presentItemCountShowUIStateCtrl;

		// Token: 0x04008A12 RID: 35346
		[AutoBind("./PresentPanel/ItemCount/ContinuousTouch", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_presentContinuousTouchUIStateCtrl;

		// Token: 0x04008A13 RID: 35347
		[AutoBind("./PresentPanel/ItemCount/Detail/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_presentItemCountText;

		// Token: 0x04008A14 RID: 35348
		[AutoBind("./PresentPanel/ItemCount/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_presentItemIconImage;

		// Token: 0x04008A15 RID: 35349
		[AutoBind("./PresentPanel/ItemCount/IconImage/IconImageEffect", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_presentItemIconEffectImage;

		// Token: 0x04008A16 RID: 35350
		[AutoBind("./PresentExpEffect", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_presentExpEffect;

		// Token: 0x04008A17 RID: 35351
		[AutoBind("./PresentPanel/ItemScrollView/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_presentSendButton;

		// Token: 0x04008A18 RID: 35352
		[AutoBind("./PresentPanel/ItemScrollView/Button", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_presentSendButtonStateCtrl;

		// Token: 0x04008A19 RID: 35353
		[AutoBind("./PresentPanel/ItemScrollView/ButtonMaskImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_presentSendButtonMaskImage;

		// Token: 0x04008A1A RID: 35354
		[AutoBind("./Prefab/ItemPrefab", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_presentItemPrefab;

		// Token: 0x04008A1B RID: 35355
		private bool m_isMale;

		// Token: 0x04008A1C RID: 35356
		private bool m_isInGiftMode;

		// Token: 0x04008A1D RID: 35357
		private Hero m_hero;

		// Token: 0x04008A1E RID: 35358
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x04008A1F RID: 35359
		private List<Goods> m_heroFavoribilityLevelUpRewards = new List<Goods>();

		// Token: 0x04008A20 RID: 35360
		private int m_heroFavoribilityOldLevel;

		// Token: 0x04008A21 RID: 35361
		private int m_curUnlockEventIndex;

		// Token: 0x04008A22 RID: 35362
		private List<string> m_unlockEventTitleList = new List<string>();

		// Token: 0x04008A23 RID: 35363
		private List<string> m_unlockEventContentList = new List<string>();

		// Token: 0x04008A24 RID: 35364
		private int m_tempAddExp;

		// Token: 0x04008A25 RID: 35365
		private int m_tempFavorabilityExp;

		// Token: 0x04008A26 RID: 35366
		private int m_totalUseExpItemCount;

		// Token: 0x04008A27 RID: 35367
		private int m_tempFavorabilityLevel;

		// Token: 0x04008A28 RID: 35368
		private FettersGiftItemUIController m_curGiftBagItemCtrl;

		// Token: 0x04008A29 RID: 35369
		private FettersGiftItemUIController m_sendButtonDownGiftBagItemCtrl;

		// Token: 0x04008A2A RID: 35370
		private List<BagItemBase> m_giftBagItemCache = new List<BagItemBase>();

		// Token: 0x04008A2B RID: 35371
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008A2C RID: 35372
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008A2D RID: 35373
		[DoNotToLua]
		private FettersFavorabilityUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008A2F RID: 35375
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008A30 RID: 35376
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008A31 RID: 35377
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008A32 RID: 35378
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04008A33 RID: 35379
		private LuaFunction m_UpdateViewInFettersFavorabilityHero_hotfix;

		// Token: 0x04008A34 RID: 35380
		private LuaFunction m_OpenFettersFavorability_hotfix;

		// Token: 0x04008A35 RID: 35381
		private LuaFunction m_SetFavorabilityValue_hotfix;

		// Token: 0x04008A36 RID: 35382
		private LuaFunction m_SetTouchCountState_hotfix;

		// Token: 0x04008A37 RID: 35383
		private LuaFunction m_SetTouchRecoverTimeTimeSpan_hotfix;

		// Token: 0x04008A38 RID: 35384
		private LuaFunction m_DragTrigger_EventOnSliderFull_hotfix;

		// Token: 0x04008A39 RID: 35385
		private LuaFunction m_DragTrigger_EventOnClick_hotfix;

		// Token: 0x04008A3A RID: 35386
		private LuaFunction m_DragTrigger_EventOnEndDrag_hotfix;

		// Token: 0x04008A3B RID: 35387
		private LuaFunction m_DragTrigger_EventOnBeginDrag_hotfix;

		// Token: 0x04008A3C RID: 35388
		private LuaFunction m_DragTrigger_EventOnSliderEmpty_hotfix;

		// Token: 0x04008A3D RID: 35389
		private LuaFunction m_SetTouchStateCtrlOutString_hotfix;

		// Token: 0x04008A3E RID: 35390
		private LuaFunction m_SetCharGoTweenPosBoolean_hotfix;

		// Token: 0x04008A3F RID: 35391
		private LuaFunction m_OnHeroInteractSucceedList;

		// Token: 0x04008A40 RID: 35392
		private LuaFunction m_AfterHeroInteractionResultEffectStringInt32_hotfix;

		// Token: 0x04008A41 RID: 35393
		private LuaFunction m_PlayFavorbilityLevelUpInt32_hotfix;

		// Token: 0x04008A42 RID: 35394
		private LuaFunction m_Co_PlayHeroInteractEffectInt32_hotfix;

		// Token: 0x04008A43 RID: 35395
		private LuaFunction m_OnCharContinueButtonClick_hotfix;

		// Token: 0x04008A44 RID: 35396
		private LuaFunction m_ShowUnlockEvents_hotfix;

		// Token: 0x04008A45 RID: 35397
		private LuaFunction m_GetUnlockEventsHero_hotfix;

		// Token: 0x04008A46 RID: 35398
		private LuaFunction m_OnUnlockEventBackButtonClick_hotfix;

		// Token: 0x04008A47 RID: 35399
		private LuaFunction m_UpdateViewInFettersGiftHero_hotfix;

		// Token: 0x04008A48 RID: 35400
		private LuaFunction m_OpenFettersGift_hotfix;

		// Token: 0x04008A49 RID: 35401
		private LuaFunction m_SetPresentContent_hotfix;

		// Token: 0x04008A4A RID: 35402
		private LuaFunction m_GiftBagItemComparerBagItemBaseBagItemBase_hotfix;

		// Token: 0x04008A4B RID: 35403
		private LuaFunction m_OnSendButtonClickDown_hotfix;

		// Token: 0x04008A4C RID: 35404
		private LuaFunction m_SendUseGiftEvent_hotfix;

		// Token: 0x04008A4D RID: 35405
		private LuaFunction m_WaitTimeThenDoEventInt32_hotfix;

		// Token: 0x04008A4E RID: 35406
		private LuaFunction m_OnUseGiftItemSucceedList;

		// Token: 0x04008A4F RID: 35407
		private LuaFunction m_OnGiftItemClickFettersGiftItemUIControllerBoolean_hotfix;

		// Token: 0x04008A50 RID: 35408
		private LuaFunction m_LocalAddExpTick_hotfix;

		// Token: 0x04008A51 RID: 35409
		private LuaFunction m_Co_SetFavorabilityValueInt32Int32Single_hotfix;

		// Token: 0x04008A52 RID: 35410
		private LuaFunction m_SetItemCountPanel_hotfix;

		// Token: 0x04008A53 RID: 35411
		private LuaFunction m_PlayHeroPerformanceInt32_hotfix;

		// Token: 0x04008A54 RID: 35412
		private LuaFunction m_GoToInformationPanelBoolean_hotfix;

		// Token: 0x04008A55 RID: 35413
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04008A56 RID: 35414
		private LuaFunction m_Co_OnAnimationFinishedEnableInputSingle_hotfix;

		// Token: 0x04008A57 RID: 35415
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04008A58 RID: 35416
		private LuaFunction m_OnInformationButtonClick_hotfix;

		// Token: 0x04008A59 RID: 35417
		private LuaFunction m_OnFettersButtonClick_hotfix;

		// Token: 0x04008A5A RID: 35418
		private LuaFunction m_OnMemoryButtonClick_hotfix;

		// Token: 0x04008A5B RID: 35419
		private LuaFunction m_OnGiftButtonClick_hotfix;

		// Token: 0x04008A5C RID: 35420
		private LuaFunction m_ResetGiftScrollViewPosition_hotfix;

		// Token: 0x04008A5D RID: 35421
		private LuaFunction m_InactiveWordGameObject_hotfix;

		// Token: 0x04008A5E RID: 35422
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04008A5F RID: 35423
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04008A60 RID: 35424
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04008A61 RID: 35425
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04008A62 RID: 35426
		private LuaFunction m_add_EventOnSliderFullAction_hotfix;

		// Token: 0x04008A63 RID: 35427
		private LuaFunction m_remove_EventOnSliderFullAction_hotfix;

		// Token: 0x04008A64 RID: 35428
		private LuaFunction m_add_EventOnGiftButtonClickAction;

		// Token: 0x04008A65 RID: 35429
		private LuaFunction m_remove_EventOnGiftButtonClickAction;

		// Token: 0x04008A66 RID: 35430
		private LuaFunction m_add_EventOnMemoryButtonClickAction;

		// Token: 0x04008A67 RID: 35431
		private LuaFunction m_remove_EventOnMemoryButtonClickAction;

		// Token: 0x04008A68 RID: 35432
		private LuaFunction m_add_EventOnFettersButtonClickAction;

		// Token: 0x04008A69 RID: 35433
		private LuaFunction m_remove_EventOnFettersButtonClickAction;

		// Token: 0x04008A6A RID: 35434
		private LuaFunction m_add_EventOnInformationButtonClickAction;

		// Token: 0x04008A6B RID: 35435
		private LuaFunction m_remove_EventOnInformationButtonClickAction;

		// Token: 0x04008A6C RID: 35436
		private LuaFunction m_add_EventOnUseGiftAction;

		// Token: 0x04008A6D RID: 35437
		private LuaFunction m_remove_EventOnUseGiftAction;

		// Token: 0x04008A6E RID: 35438
		private LuaFunction m_add_EventOnGotoBagFullPanelAction_hotfix;

		// Token: 0x04008A6F RID: 35439
		private LuaFunction m_remove_EventOnGotoBagFullPanelAction_hotfix;

		// Token: 0x02000C73 RID: 3187
		public new class LuaExportHelper
		{
			// Token: 0x0600E484 RID: 58500 RVA: 0x003D8C0C File Offset: 0x003D6E0C
			public LuaExportHelper(FettersFavorabilityUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E485 RID: 58501 RVA: 0x003D8C1C File Offset: 0x003D6E1C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E486 RID: 58502 RVA: 0x003D8C2C File Offset: 0x003D6E2C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E487 RID: 58503 RVA: 0x003D8C3C File Offset: 0x003D6E3C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E488 RID: 58504 RVA: 0x003D8C4C File Offset: 0x003D6E4C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E489 RID: 58505 RVA: 0x003D8C64 File Offset: 0x003D6E64
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E48A RID: 58506 RVA: 0x003D8C74 File Offset: 0x003D6E74
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E48B RID: 58507 RVA: 0x003D8C84 File Offset: 0x003D6E84
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E48C RID: 58508 RVA: 0x003D8C94 File Offset: 0x003D6E94
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E48D RID: 58509 RVA: 0x003D8CA4 File Offset: 0x003D6EA4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E48E RID: 58510 RVA: 0x003D8CB4 File Offset: 0x003D6EB4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E48F RID: 58511 RVA: 0x003D8CC4 File Offset: 0x003D6EC4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E490 RID: 58512 RVA: 0x003D8CD4 File Offset: 0x003D6ED4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E491 RID: 58513 RVA: 0x003D8CE4 File Offset: 0x003D6EE4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E492 RID: 58514 RVA: 0x003D8CF4 File Offset: 0x003D6EF4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E493 RID: 58515 RVA: 0x003D8D04 File Offset: 0x003D6F04
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E494 RID: 58516 RVA: 0x003D8D14 File Offset: 0x003D6F14
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600E495 RID: 58517 RVA: 0x003D8D24 File Offset: 0x003D6F24
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600E496 RID: 58518 RVA: 0x003D8D34 File Offset: 0x003D6F34
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600E497 RID: 58519 RVA: 0x003D8D44 File Offset: 0x003D6F44
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600E498 RID: 58520 RVA: 0x003D8D54 File Offset: 0x003D6F54
			public void __callDele_EventOnSliderFull()
			{
				this.m_owner.__callDele_EventOnSliderFull();
			}

			// Token: 0x0600E499 RID: 58521 RVA: 0x003D8D64 File Offset: 0x003D6F64
			public void __clearDele_EventOnSliderFull()
			{
				this.m_owner.__clearDele_EventOnSliderFull();
			}

			// Token: 0x0600E49A RID: 58522 RVA: 0x003D8D74 File Offset: 0x003D6F74
			public void __callDele_EventOnGiftButtonClick(Hero obj)
			{
				this.m_owner.__callDele_EventOnGiftButtonClick(obj);
			}

			// Token: 0x0600E49B RID: 58523 RVA: 0x003D8D84 File Offset: 0x003D6F84
			public void __clearDele_EventOnGiftButtonClick(Hero obj)
			{
				this.m_owner.__clearDele_EventOnGiftButtonClick(obj);
			}

			// Token: 0x0600E49C RID: 58524 RVA: 0x003D8D94 File Offset: 0x003D6F94
			public void __callDele_EventOnMemoryButtonClick(Hero obj)
			{
				this.m_owner.__callDele_EventOnMemoryButtonClick(obj);
			}

			// Token: 0x0600E49D RID: 58525 RVA: 0x003D8DA4 File Offset: 0x003D6FA4
			public void __clearDele_EventOnMemoryButtonClick(Hero obj)
			{
				this.m_owner.__clearDele_EventOnMemoryButtonClick(obj);
			}

			// Token: 0x0600E49E RID: 58526 RVA: 0x003D8DB4 File Offset: 0x003D6FB4
			public void __callDele_EventOnFettersButtonClick(Hero obj)
			{
				this.m_owner.__callDele_EventOnFettersButtonClick(obj);
			}

			// Token: 0x0600E49F RID: 58527 RVA: 0x003D8DC4 File Offset: 0x003D6FC4
			public void __clearDele_EventOnFettersButtonClick(Hero obj)
			{
				this.m_owner.__clearDele_EventOnFettersButtonClick(obj);
			}

			// Token: 0x0600E4A0 RID: 58528 RVA: 0x003D8DD4 File Offset: 0x003D6FD4
			public void __callDele_EventOnInformationButtonClick(Hero obj)
			{
				this.m_owner.__callDele_EventOnInformationButtonClick(obj);
			}

			// Token: 0x0600E4A1 RID: 58529 RVA: 0x003D8DE4 File Offset: 0x003D6FE4
			public void __clearDele_EventOnInformationButtonClick(Hero obj)
			{
				this.m_owner.__clearDele_EventOnInformationButtonClick(obj);
			}

			// Token: 0x0600E4A2 RID: 58530 RVA: 0x003D8DF4 File Offset: 0x003D6FF4
			public void __callDele_EventOnUseGift(GoodsType arg1, int arg2, int arg3, Action<List<Goods>> arg4)
			{
				this.m_owner.__callDele_EventOnUseGift(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600E4A3 RID: 58531 RVA: 0x003D8E08 File Offset: 0x003D7008
			public void __clearDele_EventOnUseGift(GoodsType arg1, int arg2, int arg3, Action<List<Goods>> arg4)
			{
				this.m_owner.__clearDele_EventOnUseGift(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600E4A4 RID: 58532 RVA: 0x003D8E1C File Offset: 0x003D701C
			public void __callDele_EventOnGotoBagFullPanel()
			{
				this.m_owner.__callDele_EventOnGotoBagFullPanel();
			}

			// Token: 0x0600E4A5 RID: 58533 RVA: 0x003D8E2C File Offset: 0x003D702C
			public void __clearDele_EventOnGotoBagFullPanel()
			{
				this.m_owner.__clearDele_EventOnGotoBagFullPanel();
			}

			// Token: 0x17002C44 RID: 11332
			// (get) Token: 0x0600E4A6 RID: 58534 RVA: 0x003D8E3C File Offset: 0x003D703C
			// (set) Token: 0x0600E4A7 RID: 58535 RVA: 0x003D8E4C File Offset: 0x003D704C
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x17002C45 RID: 11333
			// (get) Token: 0x0600E4A8 RID: 58536 RVA: 0x003D8E5C File Offset: 0x003D705C
			// (set) Token: 0x0600E4A9 RID: 58537 RVA: 0x003D8E6C File Offset: 0x003D706C
			public CommonUIStateController m_commonUIStateCtrl
			{
				get
				{
					return this.m_owner.m_commonUIStateCtrl;
				}
				set
				{
					this.m_owner.m_commonUIStateCtrl = value;
				}
			}

			// Token: 0x17002C46 RID: 11334
			// (get) Token: 0x0600E4AA RID: 58538 RVA: 0x003D8E7C File Offset: 0x003D707C
			// (set) Token: 0x0600E4AB RID: 58539 RVA: 0x003D8E8C File Offset: 0x003D708C
			public CommonUIStateController m_sexStateCtrl
			{
				get
				{
					return this.m_owner.m_sexStateCtrl;
				}
				set
				{
					this.m_owner.m_sexStateCtrl = value;
				}
			}

			// Token: 0x17002C47 RID: 11335
			// (get) Token: 0x0600E4AC RID: 58540 RVA: 0x003D8E9C File Offset: 0x003D709C
			// (set) Token: 0x0600E4AD RID: 58541 RVA: 0x003D8EAC File Offset: 0x003D70AC
			public CommonUIStateController m_touchInOutStateCtrl
			{
				get
				{
					return this.m_owner.m_touchInOutStateCtrl;
				}
				set
				{
					this.m_owner.m_touchInOutStateCtrl = value;
				}
			}

			// Token: 0x17002C48 RID: 11336
			// (get) Token: 0x0600E4AE RID: 58542 RVA: 0x003D8EBC File Offset: 0x003D70BC
			// (set) Token: 0x0600E4AF RID: 58543 RVA: 0x003D8ECC File Offset: 0x003D70CC
			public CommonUIStateController m_levelUpStateCtrl
			{
				get
				{
					return this.m_owner.m_levelUpStateCtrl;
				}
				set
				{
					this.m_owner.m_levelUpStateCtrl = value;
				}
			}

			// Token: 0x17002C49 RID: 11337
			// (get) Token: 0x0600E4B0 RID: 58544 RVA: 0x003D8EDC File Offset: 0x003D70DC
			// (set) Token: 0x0600E4B1 RID: 58545 RVA: 0x003D8EEC File Offset: 0x003D70EC
			public CommonUIStateController m_touchStateCtrl
			{
				get
				{
					return this.m_owner.m_touchStateCtrl;
				}
				set
				{
					this.m_owner.m_touchStateCtrl = value;
				}
			}

			// Token: 0x17002C4A RID: 11338
			// (get) Token: 0x0600E4B2 RID: 58546 RVA: 0x003D8EFC File Offset: 0x003D70FC
			// (set) Token: 0x0600E4B3 RID: 58547 RVA: 0x003D8F0C File Offset: 0x003D710C
			public CommonUIStateController m_infoStateCtrl
			{
				get
				{
					return this.m_owner.m_infoStateCtrl;
				}
				set
				{
					this.m_owner.m_infoStateCtrl = value;
				}
			}

			// Token: 0x17002C4B RID: 11339
			// (get) Token: 0x0600E4B4 RID: 58548 RVA: 0x003D8F1C File Offset: 0x003D711C
			// (set) Token: 0x0600E4B5 RID: 58549 RVA: 0x003D8F2C File Offset: 0x003D712C
			public CommonUIStateController m_presentStateCtrl
			{
				get
				{
					return this.m_owner.m_presentStateCtrl;
				}
				set
				{
					this.m_owner.m_presentStateCtrl = value;
				}
			}

			// Token: 0x17002C4C RID: 11340
			// (get) Token: 0x0600E4B6 RID: 58550 RVA: 0x003D8F3C File Offset: 0x003D713C
			// (set) Token: 0x0600E4B7 RID: 58551 RVA: 0x003D8F4C File Offset: 0x003D714C
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17002C4D RID: 11341
			// (get) Token: 0x0600E4B8 RID: 58552 RVA: 0x003D8F5C File Offset: 0x003D715C
			// (set) Token: 0x0600E4B9 RID: 58553 RVA: 0x003D8F6C File Offset: 0x003D716C
			public Button m_helpButton
			{
				get
				{
					return this.m_owner.m_helpButton;
				}
				set
				{
					this.m_owner.m_helpButton = value;
				}
			}

			// Token: 0x17002C4E RID: 11342
			// (get) Token: 0x0600E4BA RID: 58554 RVA: 0x003D8F7C File Offset: 0x003D717C
			// (set) Token: 0x0600E4BB RID: 58555 RVA: 0x003D8F8C File Offset: 0x003D718C
			public CommonUIStateController m_favorabilityValueTextStateCtrl
			{
				get
				{
					return this.m_owner.m_favorabilityValueTextStateCtrl;
				}
				set
				{
					this.m_owner.m_favorabilityValueTextStateCtrl = value;
				}
			}

			// Token: 0x17002C4F RID: 11343
			// (get) Token: 0x0600E4BC RID: 58556 RVA: 0x003D8F9C File Offset: 0x003D719C
			// (set) Token: 0x0600E4BD RID: 58557 RVA: 0x003D8FAC File Offset: 0x003D71AC
			public Text m_favorabilityValueText
			{
				get
				{
					return this.m_owner.m_favorabilityValueText;
				}
				set
				{
					this.m_owner.m_favorabilityValueText = value;
				}
			}

			// Token: 0x17002C50 RID: 11344
			// (get) Token: 0x0600E4BE RID: 58558 RVA: 0x003D8FBC File Offset: 0x003D71BC
			// (set) Token: 0x0600E4BF RID: 58559 RVA: 0x003D8FCC File Offset: 0x003D71CC
			public GameObject m_favorabilityAddUpArrowGo
			{
				get
				{
					return this.m_owner.m_favorabilityAddUpArrowGo;
				}
				set
				{
					this.m_owner.m_favorabilityAddUpArrowGo = value;
				}
			}

			// Token: 0x17002C51 RID: 11345
			// (get) Token: 0x0600E4C0 RID: 58560 RVA: 0x003D8FDC File Offset: 0x003D71DC
			// (set) Token: 0x0600E4C1 RID: 58561 RVA: 0x003D8FEC File Offset: 0x003D71EC
			public Text m_favorabilityAddValueText
			{
				get
				{
					return this.m_owner.m_favorabilityAddValueText;
				}
				set
				{
					this.m_owner.m_favorabilityAddValueText = value;
				}
			}

			// Token: 0x17002C52 RID: 11346
			// (get) Token: 0x0600E4C2 RID: 58562 RVA: 0x003D8FFC File Offset: 0x003D71FC
			// (set) Token: 0x0600E4C3 RID: 58563 RVA: 0x003D900C File Offset: 0x003D720C
			public Text m_favorabilityHeroNameText
			{
				get
				{
					return this.m_owner.m_favorabilityHeroNameText;
				}
				set
				{
					this.m_owner.m_favorabilityHeroNameText = value;
				}
			}

			// Token: 0x17002C53 RID: 11347
			// (get) Token: 0x0600E4C4 RID: 58564 RVA: 0x003D901C File Offset: 0x003D721C
			// (set) Token: 0x0600E4C5 RID: 58565 RVA: 0x003D902C File Offset: 0x003D722C
			public Text m_favorabilityLvText
			{
				get
				{
					return this.m_owner.m_favorabilityLvText;
				}
				set
				{
					this.m_owner.m_favorabilityLvText = value;
				}
			}

			// Token: 0x17002C54 RID: 11348
			// (get) Token: 0x0600E4C6 RID: 58566 RVA: 0x003D903C File Offset: 0x003D723C
			// (set) Token: 0x0600E4C7 RID: 58567 RVA: 0x003D904C File Offset: 0x003D724C
			public Slider m_favorabilityMaleSlider
			{
				get
				{
					return this.m_owner.m_favorabilityMaleSlider;
				}
				set
				{
					this.m_owner.m_favorabilityMaleSlider = value;
				}
			}

			// Token: 0x17002C55 RID: 11349
			// (get) Token: 0x0600E4C8 RID: 58568 RVA: 0x003D905C File Offset: 0x003D725C
			// (set) Token: 0x0600E4C9 RID: 58569 RVA: 0x003D906C File Offset: 0x003D726C
			public Slider m_favorabilityFemaleSlider
			{
				get
				{
					return this.m_owner.m_favorabilityFemaleSlider;
				}
				set
				{
					this.m_owner.m_favorabilityFemaleSlider = value;
				}
			}

			// Token: 0x17002C56 RID: 11350
			// (get) Token: 0x0600E4CA RID: 58570 RVA: 0x003D907C File Offset: 0x003D727C
			// (set) Token: 0x0600E4CB RID: 58571 RVA: 0x003D908C File Offset: 0x003D728C
			public GameObject m_levelUpEffectGroupGameObject
			{
				get
				{
					return this.m_owner.m_levelUpEffectGroupGameObject;
				}
				set
				{
					this.m_owner.m_levelUpEffectGroupGameObject = value;
				}
			}

			// Token: 0x17002C57 RID: 11351
			// (get) Token: 0x0600E4CC RID: 58572 RVA: 0x003D909C File Offset: 0x003D729C
			// (set) Token: 0x0600E4CD RID: 58573 RVA: 0x003D90AC File Offset: 0x003D72AC
			public GameObject m_femaleQinMiDuGameObject
			{
				get
				{
					return this.m_owner.m_femaleQinMiDuGameObject;
				}
				set
				{
					this.m_owner.m_femaleQinMiDuGameObject = value;
				}
			}

			// Token: 0x17002C58 RID: 11352
			// (get) Token: 0x0600E4CE RID: 58574 RVA: 0x003D90BC File Offset: 0x003D72BC
			// (set) Token: 0x0600E4CF RID: 58575 RVA: 0x003D90CC File Offset: 0x003D72CC
			public GameObject m_maleQinMiDuGameObject
			{
				get
				{
					return this.m_owner.m_maleQinMiDuGameObject;
				}
				set
				{
					this.m_owner.m_maleQinMiDuGameObject = value;
				}
			}

			// Token: 0x17002C59 RID: 11353
			// (get) Token: 0x0600E4D0 RID: 58576 RVA: 0x003D90DC File Offset: 0x003D72DC
			// (set) Token: 0x0600E4D1 RID: 58577 RVA: 0x003D90EC File Offset: 0x003D72EC
			public GameObject m_charGameObjectRoot
			{
				get
				{
					return this.m_owner.m_charGameObjectRoot;
				}
				set
				{
					this.m_owner.m_charGameObjectRoot = value;
				}
			}

			// Token: 0x17002C5A RID: 11354
			// (get) Token: 0x0600E4D2 RID: 58578 RVA: 0x003D90FC File Offset: 0x003D72FC
			// (set) Token: 0x0600E4D3 RID: 58579 RVA: 0x003D910C File Offset: 0x003D730C
			public GameObject m_charGameObject
			{
				get
				{
					return this.m_owner.m_charGameObject;
				}
				set
				{
					this.m_owner.m_charGameObject = value;
				}
			}

			// Token: 0x17002C5B RID: 11355
			// (get) Token: 0x0600E4D4 RID: 58580 RVA: 0x003D911C File Offset: 0x003D731C
			// (set) Token: 0x0600E4D5 RID: 58581 RVA: 0x003D912C File Offset: 0x003D732C
			public GameObject m_wordGameObject
			{
				get
				{
					return this.m_owner.m_wordGameObject;
				}
				set
				{
					this.m_owner.m_wordGameObject = value;
				}
			}

			// Token: 0x17002C5C RID: 11356
			// (get) Token: 0x0600E4D6 RID: 58582 RVA: 0x003D913C File Offset: 0x003D733C
			// (set) Token: 0x0600E4D7 RID: 58583 RVA: 0x003D914C File Offset: 0x003D734C
			public Button m_charContinueButton
			{
				get
				{
					return this.m_owner.m_charContinueButton;
				}
				set
				{
					this.m_owner.m_charContinueButton = value;
				}
			}

			// Token: 0x17002C5D RID: 11357
			// (get) Token: 0x0600E4D8 RID: 58584 RVA: 0x003D915C File Offset: 0x003D735C
			// (set) Token: 0x0600E4D9 RID: 58585 RVA: 0x003D916C File Offset: 0x003D736C
			public CommonUIStateController m_touchNumberStateCtrl
			{
				get
				{
					return this.m_owner.m_touchNumberStateCtrl;
				}
				set
				{
					this.m_owner.m_touchNumberStateCtrl = value;
				}
			}

			// Token: 0x17002C5E RID: 11358
			// (get) Token: 0x0600E4DA RID: 58586 RVA: 0x003D917C File Offset: 0x003D737C
			// (set) Token: 0x0600E4DB RID: 58587 RVA: 0x003D918C File Offset: 0x003D738C
			public CommonUIStateController m_touchCountStateCtrl
			{
				get
				{
					return this.m_owner.m_touchCountStateCtrl;
				}
				set
				{
					this.m_owner.m_touchCountStateCtrl = value;
				}
			}

			// Token: 0x17002C5F RID: 11359
			// (get) Token: 0x0600E4DC RID: 58588 RVA: 0x003D919C File Offset: 0x003D739C
			// (set) Token: 0x0600E4DD RID: 58589 RVA: 0x003D91AC File Offset: 0x003D73AC
			public Text m_touchTimeText
			{
				get
				{
					return this.m_owner.m_touchTimeText;
				}
				set
				{
					this.m_owner.m_touchTimeText = value;
				}
			}

			// Token: 0x17002C60 RID: 11360
			// (get) Token: 0x0600E4DE RID: 58590 RVA: 0x003D91BC File Offset: 0x003D73BC
			// (set) Token: 0x0600E4DF RID: 58591 RVA: 0x003D91CC File Offset: 0x003D73CC
			public Slider m_progressEffectSlider
			{
				get
				{
					return this.m_owner.m_progressEffectSlider;
				}
				set
				{
					this.m_owner.m_progressEffectSlider = value;
				}
			}

			// Token: 0x17002C61 RID: 11361
			// (get) Token: 0x0600E4E0 RID: 58592 RVA: 0x003D91DC File Offset: 0x003D73DC
			// (set) Token: 0x0600E4E1 RID: 58593 RVA: 0x003D91EC File Offset: 0x003D73EC
			public Slider m_progressMaleSlider
			{
				get
				{
					return this.m_owner.m_progressMaleSlider;
				}
				set
				{
					this.m_owner.m_progressMaleSlider = value;
				}
			}

			// Token: 0x17002C62 RID: 11362
			// (get) Token: 0x0600E4E2 RID: 58594 RVA: 0x003D91FC File Offset: 0x003D73FC
			// (set) Token: 0x0600E4E3 RID: 58595 RVA: 0x003D920C File Offset: 0x003D740C
			public Slider m_progressFemaleSlider
			{
				get
				{
					return this.m_owner.m_progressFemaleSlider;
				}
				set
				{
					this.m_owner.m_progressFemaleSlider = value;
				}
			}

			// Token: 0x17002C63 RID: 11363
			// (get) Token: 0x0600E4E4 RID: 58596 RVA: 0x003D921C File Offset: 0x003D741C
			// (set) Token: 0x0600E4E5 RID: 58597 RVA: 0x003D922C File Offset: 0x003D742C
			public GameObject m_progressEffectGroup
			{
				get
				{
					return this.m_owner.m_progressEffectGroup;
				}
				set
				{
					this.m_owner.m_progressEffectGroup = value;
				}
			}

			// Token: 0x17002C64 RID: 11364
			// (get) Token: 0x0600E4E6 RID: 58598 RVA: 0x003D923C File Offset: 0x003D743C
			// (set) Token: 0x0600E4E7 RID: 58599 RVA: 0x003D924C File Offset: 0x003D744C
			public GameObject m_maleBGImage
			{
				get
				{
					return this.m_owner.m_maleBGImage;
				}
				set
				{
					this.m_owner.m_maleBGImage = value;
				}
			}

			// Token: 0x17002C65 RID: 11365
			// (get) Token: 0x0600E4E8 RID: 58600 RVA: 0x003D925C File Offset: 0x003D745C
			// (set) Token: 0x0600E4E9 RID: 58601 RVA: 0x003D926C File Offset: 0x003D746C
			public GameObject m_femaleBGImage
			{
				get
				{
					return this.m_owner.m_femaleBGImage;
				}
				set
				{
					this.m_owner.m_femaleBGImage = value;
				}
			}

			// Token: 0x17002C66 RID: 11366
			// (get) Token: 0x0600E4EA RID: 58602 RVA: 0x003D927C File Offset: 0x003D747C
			// (set) Token: 0x0600E4EB RID: 58603 RVA: 0x003D928C File Offset: 0x003D748C
			public GameObject m_levelUpStarEffectGroup
			{
				get
				{
					return this.m_owner.m_levelUpStarEffectGroup;
				}
				set
				{
					this.m_owner.m_levelUpStarEffectGroup = value;
				}
			}

			// Token: 0x17002C67 RID: 11367
			// (get) Token: 0x0600E4EC RID: 58604 RVA: 0x003D929C File Offset: 0x003D749C
			// (set) Token: 0x0600E4ED RID: 58605 RVA: 0x003D92AC File Offset: 0x003D74AC
			public Button m_informationButton
			{
				get
				{
					return this.m_owner.m_informationButton;
				}
				set
				{
					this.m_owner.m_informationButton = value;
				}
			}

			// Token: 0x17002C68 RID: 11368
			// (get) Token: 0x0600E4EE RID: 58606 RVA: 0x003D92BC File Offset: 0x003D74BC
			// (set) Token: 0x0600E4EF RID: 58607 RVA: 0x003D92CC File Offset: 0x003D74CC
			public GameObject m_informationButtonNewImage
			{
				get
				{
					return this.m_owner.m_informationButtonNewImage;
				}
				set
				{
					this.m_owner.m_informationButtonNewImage = value;
				}
			}

			// Token: 0x17002C69 RID: 11369
			// (get) Token: 0x0600E4F0 RID: 58608 RVA: 0x003D92DC File Offset: 0x003D74DC
			// (set) Token: 0x0600E4F1 RID: 58609 RVA: 0x003D92EC File Offset: 0x003D74EC
			public Button m_fettersButton
			{
				get
				{
					return this.m_owner.m_fettersButton;
				}
				set
				{
					this.m_owner.m_fettersButton = value;
				}
			}

			// Token: 0x17002C6A RID: 11370
			// (get) Token: 0x0600E4F2 RID: 58610 RVA: 0x003D92FC File Offset: 0x003D74FC
			// (set) Token: 0x0600E4F3 RID: 58611 RVA: 0x003D930C File Offset: 0x003D750C
			public GameObject m_fettersButtonRedMark
			{
				get
				{
					return this.m_owner.m_fettersButtonRedMark;
				}
				set
				{
					this.m_owner.m_fettersButtonRedMark = value;
				}
			}

			// Token: 0x17002C6B RID: 11371
			// (get) Token: 0x0600E4F4 RID: 58612 RVA: 0x003D931C File Offset: 0x003D751C
			// (set) Token: 0x0600E4F5 RID: 58613 RVA: 0x003D932C File Offset: 0x003D752C
			public Text m_fettersButtonPercentText
			{
				get
				{
					return this.m_owner.m_fettersButtonPercentText;
				}
				set
				{
					this.m_owner.m_fettersButtonPercentText = value;
				}
			}

			// Token: 0x17002C6C RID: 11372
			// (get) Token: 0x0600E4F6 RID: 58614 RVA: 0x003D933C File Offset: 0x003D753C
			// (set) Token: 0x0600E4F7 RID: 58615 RVA: 0x003D934C File Offset: 0x003D754C
			public Button m_memoryButton
			{
				get
				{
					return this.m_owner.m_memoryButton;
				}
				set
				{
					this.m_owner.m_memoryButton = value;
				}
			}

			// Token: 0x17002C6D RID: 11373
			// (get) Token: 0x0600E4F8 RID: 58616 RVA: 0x003D935C File Offset: 0x003D755C
			// (set) Token: 0x0600E4F9 RID: 58617 RVA: 0x003D936C File Offset: 0x003D756C
			public CommonUIStateController m_memoryButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_memoryButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_memoryButtonStateCtrl = value;
				}
			}

			// Token: 0x17002C6E RID: 11374
			// (get) Token: 0x0600E4FA RID: 58618 RVA: 0x003D937C File Offset: 0x003D757C
			// (set) Token: 0x0600E4FB RID: 58619 RVA: 0x003D938C File Offset: 0x003D758C
			public GameObject m_memoryButtonNewImage
			{
				get
				{
					return this.m_owner.m_memoryButtonNewImage;
				}
				set
				{
					this.m_owner.m_memoryButtonNewImage = value;
				}
			}

			// Token: 0x17002C6F RID: 11375
			// (get) Token: 0x0600E4FC RID: 58620 RVA: 0x003D939C File Offset: 0x003D759C
			// (set) Token: 0x0600E4FD RID: 58621 RVA: 0x003D93AC File Offset: 0x003D75AC
			public Text m_memoryButtonPercentText
			{
				get
				{
					return this.m_owner.m_memoryButtonPercentText;
				}
				set
				{
					this.m_owner.m_memoryButtonPercentText = value;
				}
			}

			// Token: 0x17002C70 RID: 11376
			// (get) Token: 0x0600E4FE RID: 58622 RVA: 0x003D93BC File Offset: 0x003D75BC
			// (set) Token: 0x0600E4FF RID: 58623 RVA: 0x003D93CC File Offset: 0x003D75CC
			public Button m_presentButton
			{
				get
				{
					return this.m_owner.m_presentButton;
				}
				set
				{
					this.m_owner.m_presentButton = value;
				}
			}

			// Token: 0x17002C71 RID: 11377
			// (get) Token: 0x0600E500 RID: 58624 RVA: 0x003D93DC File Offset: 0x003D75DC
			// (set) Token: 0x0600E501 RID: 58625 RVA: 0x003D93EC File Offset: 0x003D75EC
			public GameObject m_touchImage
			{
				get
				{
					return this.m_owner.m_touchImage;
				}
				set
				{
					this.m_owner.m_touchImage = value;
				}
			}

			// Token: 0x17002C72 RID: 11378
			// (get) Token: 0x0600E502 RID: 58626 RVA: 0x003D93FC File Offset: 0x003D75FC
			// (set) Token: 0x0600E503 RID: 58627 RVA: 0x003D940C File Offset: 0x003D760C
			public CommonUIStateController m_unlockEventStateCtrl
			{
				get
				{
					return this.m_owner.m_unlockEventStateCtrl;
				}
				set
				{
					this.m_owner.m_unlockEventStateCtrl = value;
				}
			}

			// Token: 0x17002C73 RID: 11379
			// (get) Token: 0x0600E504 RID: 58628 RVA: 0x003D941C File Offset: 0x003D761C
			// (set) Token: 0x0600E505 RID: 58629 RVA: 0x003D942C File Offset: 0x003D762C
			public Text m_unlockEventTitleText
			{
				get
				{
					return this.m_owner.m_unlockEventTitleText;
				}
				set
				{
					this.m_owner.m_unlockEventTitleText = value;
				}
			}

			// Token: 0x17002C74 RID: 11380
			// (get) Token: 0x0600E506 RID: 58630 RVA: 0x003D943C File Offset: 0x003D763C
			// (set) Token: 0x0600E507 RID: 58631 RVA: 0x003D944C File Offset: 0x003D764C
			public Text m_unlockEventContentText
			{
				get
				{
					return this.m_owner.m_unlockEventContentText;
				}
				set
				{
					this.m_owner.m_unlockEventContentText = value;
				}
			}

			// Token: 0x17002C75 RID: 11381
			// (get) Token: 0x0600E508 RID: 58632 RVA: 0x003D945C File Offset: 0x003D765C
			// (set) Token: 0x0600E509 RID: 58633 RVA: 0x003D946C File Offset: 0x003D766C
			public Button m_unlockEventBackButton
			{
				get
				{
					return this.m_owner.m_unlockEventBackButton;
				}
				set
				{
					this.m_owner.m_unlockEventBackButton = value;
				}
			}

			// Token: 0x17002C76 RID: 11382
			// (get) Token: 0x0600E50A RID: 58634 RVA: 0x003D947C File Offset: 0x003D767C
			// (set) Token: 0x0600E50B RID: 58635 RVA: 0x003D948C File Offset: 0x003D768C
			public GameObject m_presentPanel
			{
				get
				{
					return this.m_owner.m_presentPanel;
				}
				set
				{
					this.m_owner.m_presentPanel = value;
				}
			}

			// Token: 0x17002C77 RID: 11383
			// (get) Token: 0x0600E50C RID: 58636 RVA: 0x003D949C File Offset: 0x003D769C
			// (set) Token: 0x0600E50D RID: 58637 RVA: 0x003D94AC File Offset: 0x003D76AC
			public CommonUIStateController m_presentContentStateCtrl
			{
				get
				{
					return this.m_owner.m_presentContentStateCtrl;
				}
				set
				{
					this.m_owner.m_presentContentStateCtrl = value;
				}
			}

			// Token: 0x17002C78 RID: 11384
			// (get) Token: 0x0600E50E RID: 58638 RVA: 0x003D94BC File Offset: 0x003D76BC
			// (set) Token: 0x0600E50F RID: 58639 RVA: 0x003D94CC File Offset: 0x003D76CC
			public ScrollRect m_presentScrollRect
			{
				get
				{
					return this.m_owner.m_presentScrollRect;
				}
				set
				{
					this.m_owner.m_presentScrollRect = value;
				}
			}

			// Token: 0x17002C79 RID: 11385
			// (get) Token: 0x0600E510 RID: 58640 RVA: 0x003D94DC File Offset: 0x003D76DC
			// (set) Token: 0x0600E511 RID: 58641 RVA: 0x003D94EC File Offset: 0x003D76EC
			public GameObject m_presentContent
			{
				get
				{
					return this.m_owner.m_presentContent;
				}
				set
				{
					this.m_owner.m_presentContent = value;
				}
			}

			// Token: 0x17002C7A RID: 11386
			// (get) Token: 0x0600E512 RID: 58642 RVA: 0x003D94FC File Offset: 0x003D76FC
			// (set) Token: 0x0600E513 RID: 58643 RVA: 0x003D950C File Offset: 0x003D770C
			public CommonUIStateController m_presentItemCountShowUIStateCtrl
			{
				get
				{
					return this.m_owner.m_presentItemCountShowUIStateCtrl;
				}
				set
				{
					this.m_owner.m_presentItemCountShowUIStateCtrl = value;
				}
			}

			// Token: 0x17002C7B RID: 11387
			// (get) Token: 0x0600E514 RID: 58644 RVA: 0x003D951C File Offset: 0x003D771C
			// (set) Token: 0x0600E515 RID: 58645 RVA: 0x003D952C File Offset: 0x003D772C
			public CommonUIStateController m_presentContinuousTouchUIStateCtrl
			{
				get
				{
					return this.m_owner.m_presentContinuousTouchUIStateCtrl;
				}
				set
				{
					this.m_owner.m_presentContinuousTouchUIStateCtrl = value;
				}
			}

			// Token: 0x17002C7C RID: 11388
			// (get) Token: 0x0600E516 RID: 58646 RVA: 0x003D953C File Offset: 0x003D773C
			// (set) Token: 0x0600E517 RID: 58647 RVA: 0x003D954C File Offset: 0x003D774C
			public Text m_presentItemCountText
			{
				get
				{
					return this.m_owner.m_presentItemCountText;
				}
				set
				{
					this.m_owner.m_presentItemCountText = value;
				}
			}

			// Token: 0x17002C7D RID: 11389
			// (get) Token: 0x0600E518 RID: 58648 RVA: 0x003D955C File Offset: 0x003D775C
			// (set) Token: 0x0600E519 RID: 58649 RVA: 0x003D956C File Offset: 0x003D776C
			public Image m_presentItemIconImage
			{
				get
				{
					return this.m_owner.m_presentItemIconImage;
				}
				set
				{
					this.m_owner.m_presentItemIconImage = value;
				}
			}

			// Token: 0x17002C7E RID: 11390
			// (get) Token: 0x0600E51A RID: 58650 RVA: 0x003D957C File Offset: 0x003D777C
			// (set) Token: 0x0600E51B RID: 58651 RVA: 0x003D958C File Offset: 0x003D778C
			public Image m_presentItemIconEffectImage
			{
				get
				{
					return this.m_owner.m_presentItemIconEffectImage;
				}
				set
				{
					this.m_owner.m_presentItemIconEffectImage = value;
				}
			}

			// Token: 0x17002C7F RID: 11391
			// (get) Token: 0x0600E51C RID: 58652 RVA: 0x003D959C File Offset: 0x003D779C
			// (set) Token: 0x0600E51D RID: 58653 RVA: 0x003D95AC File Offset: 0x003D77AC
			public CommonUIStateController m_presentExpEffect
			{
				get
				{
					return this.m_owner.m_presentExpEffect;
				}
				set
				{
					this.m_owner.m_presentExpEffect = value;
				}
			}

			// Token: 0x17002C80 RID: 11392
			// (get) Token: 0x0600E51E RID: 58654 RVA: 0x003D95BC File Offset: 0x003D77BC
			// (set) Token: 0x0600E51F RID: 58655 RVA: 0x003D95CC File Offset: 0x003D77CC
			public Button m_presentSendButton
			{
				get
				{
					return this.m_owner.m_presentSendButton;
				}
				set
				{
					this.m_owner.m_presentSendButton = value;
				}
			}

			// Token: 0x17002C81 RID: 11393
			// (get) Token: 0x0600E520 RID: 58656 RVA: 0x003D95DC File Offset: 0x003D77DC
			// (set) Token: 0x0600E521 RID: 58657 RVA: 0x003D95EC File Offset: 0x003D77EC
			public CommonUIStateController m_presentSendButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_presentSendButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_presentSendButtonStateCtrl = value;
				}
			}

			// Token: 0x17002C82 RID: 11394
			// (get) Token: 0x0600E522 RID: 58658 RVA: 0x003D95FC File Offset: 0x003D77FC
			// (set) Token: 0x0600E523 RID: 58659 RVA: 0x003D960C File Offset: 0x003D780C
			public GameObject m_presentSendButtonMaskImage
			{
				get
				{
					return this.m_owner.m_presentSendButtonMaskImage;
				}
				set
				{
					this.m_owner.m_presentSendButtonMaskImage = value;
				}
			}

			// Token: 0x17002C83 RID: 11395
			// (get) Token: 0x0600E524 RID: 58660 RVA: 0x003D961C File Offset: 0x003D781C
			// (set) Token: 0x0600E525 RID: 58661 RVA: 0x003D962C File Offset: 0x003D782C
			public GameObject m_presentItemPrefab
			{
				get
				{
					return this.m_owner.m_presentItemPrefab;
				}
				set
				{
					this.m_owner.m_presentItemPrefab = value;
				}
			}

			// Token: 0x17002C84 RID: 11396
			// (get) Token: 0x0600E526 RID: 58662 RVA: 0x003D963C File Offset: 0x003D783C
			// (set) Token: 0x0600E527 RID: 58663 RVA: 0x003D964C File Offset: 0x003D784C
			public bool m_isMale
			{
				get
				{
					return this.m_owner.m_isMale;
				}
				set
				{
					this.m_owner.m_isMale = value;
				}
			}

			// Token: 0x17002C85 RID: 11397
			// (get) Token: 0x0600E528 RID: 58664 RVA: 0x003D965C File Offset: 0x003D785C
			// (set) Token: 0x0600E529 RID: 58665 RVA: 0x003D966C File Offset: 0x003D786C
			public bool m_isInGiftMode
			{
				get
				{
					return this.m_owner.m_isInGiftMode;
				}
				set
				{
					this.m_owner.m_isInGiftMode = value;
				}
			}

			// Token: 0x17002C86 RID: 11398
			// (get) Token: 0x0600E52A RID: 58666 RVA: 0x003D967C File Offset: 0x003D787C
			// (set) Token: 0x0600E52B RID: 58667 RVA: 0x003D968C File Offset: 0x003D788C
			public Hero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17002C87 RID: 11399
			// (get) Token: 0x0600E52C RID: 58668 RVA: 0x003D969C File Offset: 0x003D789C
			// (set) Token: 0x0600E52D RID: 58669 RVA: 0x003D96AC File Offset: 0x003D78AC
			public HeroCharUIController m_heroCharUIController
			{
				get
				{
					return this.m_owner.m_heroCharUIController;
				}
				set
				{
					this.m_owner.m_heroCharUIController = value;
				}
			}

			// Token: 0x17002C88 RID: 11400
			// (get) Token: 0x0600E52E RID: 58670 RVA: 0x003D96BC File Offset: 0x003D78BC
			// (set) Token: 0x0600E52F RID: 58671 RVA: 0x003D96CC File Offset: 0x003D78CC
			public List<Goods> m_heroFavoribilityLevelUpRewards
			{
				get
				{
					return this.m_owner.m_heroFavoribilityLevelUpRewards;
				}
				set
				{
					this.m_owner.m_heroFavoribilityLevelUpRewards = value;
				}
			}

			// Token: 0x17002C89 RID: 11401
			// (get) Token: 0x0600E530 RID: 58672 RVA: 0x003D96DC File Offset: 0x003D78DC
			// (set) Token: 0x0600E531 RID: 58673 RVA: 0x003D96EC File Offset: 0x003D78EC
			public int m_heroFavoribilityOldLevel
			{
				get
				{
					return this.m_owner.m_heroFavoribilityOldLevel;
				}
				set
				{
					this.m_owner.m_heroFavoribilityOldLevel = value;
				}
			}

			// Token: 0x17002C8A RID: 11402
			// (get) Token: 0x0600E532 RID: 58674 RVA: 0x003D96FC File Offset: 0x003D78FC
			// (set) Token: 0x0600E533 RID: 58675 RVA: 0x003D970C File Offset: 0x003D790C
			public int m_curUnlockEventIndex
			{
				get
				{
					return this.m_owner.m_curUnlockEventIndex;
				}
				set
				{
					this.m_owner.m_curUnlockEventIndex = value;
				}
			}

			// Token: 0x17002C8B RID: 11403
			// (get) Token: 0x0600E534 RID: 58676 RVA: 0x003D971C File Offset: 0x003D791C
			// (set) Token: 0x0600E535 RID: 58677 RVA: 0x003D972C File Offset: 0x003D792C
			public List<string> m_unlockEventTitleList
			{
				get
				{
					return this.m_owner.m_unlockEventTitleList;
				}
				set
				{
					this.m_owner.m_unlockEventTitleList = value;
				}
			}

			// Token: 0x17002C8C RID: 11404
			// (get) Token: 0x0600E536 RID: 58678 RVA: 0x003D973C File Offset: 0x003D793C
			// (set) Token: 0x0600E537 RID: 58679 RVA: 0x003D974C File Offset: 0x003D794C
			public List<string> m_unlockEventContentList
			{
				get
				{
					return this.m_owner.m_unlockEventContentList;
				}
				set
				{
					this.m_owner.m_unlockEventContentList = value;
				}
			}

			// Token: 0x17002C8D RID: 11405
			// (get) Token: 0x0600E538 RID: 58680 RVA: 0x003D975C File Offset: 0x003D795C
			// (set) Token: 0x0600E539 RID: 58681 RVA: 0x003D976C File Offset: 0x003D796C
			public int m_tempAddExp
			{
				get
				{
					return this.m_owner.m_tempAddExp;
				}
				set
				{
					this.m_owner.m_tempAddExp = value;
				}
			}

			// Token: 0x17002C8E RID: 11406
			// (get) Token: 0x0600E53A RID: 58682 RVA: 0x003D977C File Offset: 0x003D797C
			// (set) Token: 0x0600E53B RID: 58683 RVA: 0x003D978C File Offset: 0x003D798C
			public int m_tempFavorabilityExp
			{
				get
				{
					return this.m_owner.m_tempFavorabilityExp;
				}
				set
				{
					this.m_owner.m_tempFavorabilityExp = value;
				}
			}

			// Token: 0x17002C8F RID: 11407
			// (get) Token: 0x0600E53C RID: 58684 RVA: 0x003D979C File Offset: 0x003D799C
			// (set) Token: 0x0600E53D RID: 58685 RVA: 0x003D97AC File Offset: 0x003D79AC
			public int m_totalUseExpItemCount
			{
				get
				{
					return this.m_owner.m_totalUseExpItemCount;
				}
				set
				{
					this.m_owner.m_totalUseExpItemCount = value;
				}
			}

			// Token: 0x17002C90 RID: 11408
			// (get) Token: 0x0600E53E RID: 58686 RVA: 0x003D97BC File Offset: 0x003D79BC
			// (set) Token: 0x0600E53F RID: 58687 RVA: 0x003D97CC File Offset: 0x003D79CC
			public int m_tempFavorabilityLevel
			{
				get
				{
					return this.m_owner.m_tempFavorabilityLevel;
				}
				set
				{
					this.m_owner.m_tempFavorabilityLevel = value;
				}
			}

			// Token: 0x17002C91 RID: 11409
			// (get) Token: 0x0600E540 RID: 58688 RVA: 0x003D97DC File Offset: 0x003D79DC
			// (set) Token: 0x0600E541 RID: 58689 RVA: 0x003D97EC File Offset: 0x003D79EC
			public FettersGiftItemUIController m_curGiftBagItemCtrl
			{
				get
				{
					return this.m_owner.m_curGiftBagItemCtrl;
				}
				set
				{
					this.m_owner.m_curGiftBagItemCtrl = value;
				}
			}

			// Token: 0x17002C92 RID: 11410
			// (get) Token: 0x0600E542 RID: 58690 RVA: 0x003D97FC File Offset: 0x003D79FC
			// (set) Token: 0x0600E543 RID: 58691 RVA: 0x003D980C File Offset: 0x003D7A0C
			public FettersGiftItemUIController m_sendButtonDownGiftBagItemCtrl
			{
				get
				{
					return this.m_owner.m_sendButtonDownGiftBagItemCtrl;
				}
				set
				{
					this.m_owner.m_sendButtonDownGiftBagItemCtrl = value;
				}
			}

			// Token: 0x17002C93 RID: 11411
			// (get) Token: 0x0600E544 RID: 58692 RVA: 0x003D981C File Offset: 0x003D7A1C
			// (set) Token: 0x0600E545 RID: 58693 RVA: 0x003D982C File Offset: 0x003D7A2C
			public List<BagItemBase> m_giftBagItemCache
			{
				get
				{
					return this.m_owner.m_giftBagItemCache;
				}
				set
				{
					this.m_owner.m_giftBagItemCache = value;
				}
			}

			// Token: 0x17002C94 RID: 11412
			// (get) Token: 0x0600E546 RID: 58694 RVA: 0x003D983C File Offset: 0x003D7A3C
			// (set) Token: 0x0600E547 RID: 58695 RVA: 0x003D984C File Offset: 0x003D7A4C
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17002C95 RID: 11413
			// (get) Token: 0x0600E548 RID: 58696 RVA: 0x003D985C File Offset: 0x003D7A5C
			// (set) Token: 0x0600E549 RID: 58697 RVA: 0x003D986C File Offset: 0x003D7A6C
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x0600E54A RID: 58698 RVA: 0x003D987C File Offset: 0x003D7A7C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E54B RID: 58699 RVA: 0x003D988C File Offset: 0x003D7A8C
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600E54C RID: 58700 RVA: 0x003D989C File Offset: 0x003D7A9C
			public void SetFavorabilityValue()
			{
				this.m_owner.SetFavorabilityValue();
			}

			// Token: 0x0600E54D RID: 58701 RVA: 0x003D98AC File Offset: 0x003D7AAC
			public void SetTouchCountState()
			{
				this.m_owner.SetTouchCountState();
			}

			// Token: 0x0600E54E RID: 58702 RVA: 0x003D98BC File Offset: 0x003D7ABC
			public void DragTrigger_EventOnSliderFull()
			{
				this.m_owner.DragTrigger_EventOnSliderFull();
			}

			// Token: 0x0600E54F RID: 58703 RVA: 0x003D98CC File Offset: 0x003D7ACC
			public void DragTrigger_EventOnClick()
			{
				this.m_owner.DragTrigger_EventOnClick();
			}

			// Token: 0x0600E550 RID: 58704 RVA: 0x003D98DC File Offset: 0x003D7ADC
			public void DragTrigger_EventOnEndDrag()
			{
				this.m_owner.DragTrigger_EventOnEndDrag();
			}

			// Token: 0x0600E551 RID: 58705 RVA: 0x003D98EC File Offset: 0x003D7AEC
			public void DragTrigger_EventOnBeginDrag()
			{
				this.m_owner.DragTrigger_EventOnBeginDrag();
			}

			// Token: 0x0600E552 RID: 58706 RVA: 0x003D98FC File Offset: 0x003D7AFC
			public void DragTrigger_EventOnSliderEmpty()
			{
				this.m_owner.DragTrigger_EventOnSliderEmpty();
			}

			// Token: 0x0600E553 RID: 58707 RVA: 0x003D990C File Offset: 0x003D7B0C
			public void SetTouchStateCtrlOut(string stateName)
			{
				this.m_owner.SetTouchStateCtrlOut(stateName);
			}

			// Token: 0x0600E554 RID: 58708 RVA: 0x003D991C File Offset: 0x003D7B1C
			public void SetCharGoTweenPos(bool isCharAtInState)
			{
				this.m_owner.SetCharGoTweenPos(isCharAtInState);
			}

			// Token: 0x0600E555 RID: 58709 RVA: 0x003D992C File Offset: 0x003D7B2C
			public void AfterHeroInteractionResultEffect(string stateName, int heroPerformanceId)
			{
				this.m_owner.AfterHeroInteractionResultEffect(stateName, heroPerformanceId);
			}

			// Token: 0x0600E556 RID: 58710 RVA: 0x003D993C File Offset: 0x003D7B3C
			public void PlayFavorbilityLevelUp(int heroPerformanceId)
			{
				this.m_owner.PlayFavorbilityLevelUp(heroPerformanceId);
			}

			// Token: 0x0600E557 RID: 58711 RVA: 0x003D994C File Offset: 0x003D7B4C
			public IEnumerator Co_PlayHeroInteractEffect(int heroPerformanceId)
			{
				return this.m_owner.Co_PlayHeroInteractEffect(heroPerformanceId);
			}

			// Token: 0x0600E558 RID: 58712 RVA: 0x003D995C File Offset: 0x003D7B5C
			public void OnCharContinueButtonClick()
			{
				this.m_owner.OnCharContinueButtonClick();
			}

			// Token: 0x0600E559 RID: 58713 RVA: 0x003D996C File Offset: 0x003D7B6C
			public void ShowUnlockEvents()
			{
				this.m_owner.ShowUnlockEvents();
			}

			// Token: 0x0600E55A RID: 58714 RVA: 0x003D997C File Offset: 0x003D7B7C
			public void GetUnlockEvents(Hero hero)
			{
				this.m_owner.GetUnlockEvents(hero);
			}

			// Token: 0x0600E55B RID: 58715 RVA: 0x003D998C File Offset: 0x003D7B8C
			public void OnUnlockEventBackButtonClick()
			{
				this.m_owner.OnUnlockEventBackButtonClick();
			}

			// Token: 0x0600E55C RID: 58716 RVA: 0x003D999C File Offset: 0x003D7B9C
			public void SetPresentContent()
			{
				this.m_owner.SetPresentContent();
			}

			// Token: 0x0600E55D RID: 58717 RVA: 0x003D99AC File Offset: 0x003D7BAC
			public int GiftBagItemComparer(BagItemBase a, BagItemBase b)
			{
				return this.m_owner.GiftBagItemComparer(a, b);
			}

			// Token: 0x0600E55E RID: 58718 RVA: 0x003D99BC File Offset: 0x003D7BBC
			public void OnSendButtonClickDown()
			{
				this.m_owner.OnSendButtonClickDown();
			}

			// Token: 0x0600E55F RID: 58719 RVA: 0x003D99CC File Offset: 0x003D7BCC
			public void SendUseGiftEvent()
			{
				this.m_owner.SendUseGiftEvent();
			}

			// Token: 0x0600E560 RID: 58720 RVA: 0x003D99DC File Offset: 0x003D7BDC
			public IEnumerator WaitTimeThenDoEvent(int count)
			{
				return this.m_owner.WaitTimeThenDoEvent(count);
			}

			// Token: 0x0600E561 RID: 58721 RVA: 0x003D99EC File Offset: 0x003D7BEC
			public void OnUseGiftItemSucceed(List<Goods> rewards)
			{
				this.m_owner.OnUseGiftItemSucceed(rewards);
			}

			// Token: 0x0600E562 RID: 58722 RVA: 0x003D99FC File Offset: 0x003D7BFC
			public void OnGiftItemClick(FettersGiftItemUIController ctrl, bool isNeedShowDesc)
			{
				this.m_owner.OnGiftItemClick(ctrl, isNeedShowDesc);
			}

			// Token: 0x0600E563 RID: 58723 RVA: 0x003D9A0C File Offset: 0x003D7C0C
			public void LocalAddExpTick()
			{
				this.m_owner.LocalAddExpTick();
			}

			// Token: 0x0600E564 RID: 58724 RVA: 0x003D9A1C File Offset: 0x003D7C1C
			public IEnumerator Co_SetFavorabilityValue(int curFavoribilityLv, int addLv, float finalSliderValue)
			{
				return this.m_owner.Co_SetFavorabilityValue(curFavoribilityLv, addLv, finalSliderValue);
			}

			// Token: 0x0600E565 RID: 58725 RVA: 0x003D9A2C File Offset: 0x003D7C2C
			public void SetItemCountPanel()
			{
				this.m_owner.SetItemCountPanel();
			}

			// Token: 0x0600E566 RID: 58726 RVA: 0x003D9A3C File Offset: 0x003D7C3C
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600E567 RID: 58727 RVA: 0x003D9A4C File Offset: 0x003D7C4C
			public IEnumerator Co_OnAnimationFinishedEnableInput(float time)
			{
				return this.m_owner.Co_OnAnimationFinishedEnableInput(time);
			}

			// Token: 0x0600E568 RID: 58728 RVA: 0x003D9A5C File Offset: 0x003D7C5C
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0600E569 RID: 58729 RVA: 0x003D9A6C File Offset: 0x003D7C6C
			public void OnInformationButtonClick()
			{
				this.m_owner.OnInformationButtonClick();
			}

			// Token: 0x0600E56A RID: 58730 RVA: 0x003D9A7C File Offset: 0x003D7C7C
			public void OnFettersButtonClick()
			{
				this.m_owner.OnFettersButtonClick();
			}

			// Token: 0x0600E56B RID: 58731 RVA: 0x003D9A8C File Offset: 0x003D7C8C
			public void OnMemoryButtonClick()
			{
				this.m_owner.OnMemoryButtonClick();
			}

			// Token: 0x0600E56C RID: 58732 RVA: 0x003D9A9C File Offset: 0x003D7C9C
			public void OnGiftButtonClick()
			{
				this.m_owner.OnGiftButtonClick();
			}

			// Token: 0x0600E56D RID: 58733 RVA: 0x003D9AAC File Offset: 0x003D7CAC
			public void ResetGiftScrollViewPosition()
			{
				this.m_owner.ResetGiftScrollViewPosition();
			}

			// Token: 0x0600E56E RID: 58734 RVA: 0x003D9ABC File Offset: 0x003D7CBC
			public void InactiveWordGameObject()
			{
				this.m_owner.InactiveWordGameObject();
			}

			// Token: 0x04008A70 RID: 35440
			private FettersFavorabilityUIController m_owner;
		}
	}
}
