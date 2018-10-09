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
using BlackJack.ProjectL.Misc;
using PD.SDK;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CC6 RID: 3270
	[HotFix]
	public class GoddessDialogUIController : UIControllerBase
	{
		// Token: 0x0600ED4F RID: 60751 RVA: 0x003F6830 File Offset: 0x003F4A30
		private GoddessDialogUIController()
		{
		}

		// Token: 0x0600ED50 RID: 60752 RVA: 0x003F6868 File Offset: 0x003F4A68
		private void Start()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Start_hotfix != null)
			{
				this.m_Start_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.printGameEventLog("28", string.Empty);
		}

		// Token: 0x0600ED51 RID: 60753 RVA: 0x003F68DC File Offset: 0x003F4ADC
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_acceptButton.onClick.AddListener(new UnityAction(this.OnAcceptButtonClick));
			this.m_retryButton.onClick.AddListener(new UnityAction(this.OnRetryButtonClick));
			this.m_selectButton.onClick.AddListener(new UnityAction(this.OnSelectButtonClick));
			this.m_confirmButton.onClick.AddListener(new UnityAction(this.OnConfirmButtonClick));
			this.m_retryButton2.onClick.AddListener(new UnityAction(this.OnRetryButton2Click));
			this.m_prevButton.onClick.AddListener(new UnityAction(this.OnPrevButtonClick));
			this.m_nextButton.onClick.AddListener(new UnityAction(this.OnNextButtonClick));
			this.m_dialogCharUIController = GameObjectUtility.AddControllerToGameObject<DialogCharUIController>(this.m_charGameObject);
			this.m_dialogBoxUIController = GameObjectUtility.AddControllerToGameObject<GoddessDialogBoxUIController>(this.m_wordsGameObject);
			this.m_choiceButtons[0] = GameObjectUtility.AddControllerToGameObject<GoddessDialogChoiceButton>(this.m_choice1GameObject);
			this.m_choiceButtons[0].SetIndex(0);
			this.m_choiceButtons[0].EventOnClick += this.OnChoiceButtonClick;
			this.m_choiceButtons[1] = GameObjectUtility.AddControllerToGameObject<GoddessDialogChoiceButton>(this.m_choice2GameObject);
			this.m_choiceButtons[1].SetIndex(1);
			this.m_choiceButtons[1].EventOnClick += this.OnChoiceButtonClick;
			this.m_choiceButtons[2] = GameObjectUtility.AddControllerToGameObject<GoddessDialogChoiceButton>(this.m_choice3GameObject);
			this.m_choiceButtons[2].SetIndex(2);
			this.m_choiceButtons[2].EventOnClick += this.OnChoiceButtonClick;
			this.m_jobButtons[0] = GameObjectUtility.AddControllerToGameObject<GoddessDialogJobButton>(this.m_job1GameObject);
			this.m_jobButtons[0].EventOnClick += this.OnJobButtonClick;
			this.m_jobButtons[1] = GameObjectUtility.AddControllerToGameObject<GoddessDialogJobButton>(this.m_job2GameObject);
			this.m_jobButtons[1].EventOnClick += this.OnJobButtonClick;
			this.m_jobGameObject.SetActive(false);
			this.m_dialogBoxUIController.gameObject.SetActive(false);
			this.m_choiceUIStateController.gameObject.SetActive(false);
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600ED52 RID: 60754 RVA: 0x003F6B84 File Offset: 0x003F4D84
		public void CreateChar(ConfigDataCharImageInfo charImageInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateCharConfigDataCharImageInfo_hotfix != null)
			{
				this.m_CreateCharConfigDataCharImageInfo_hotfix.call(new object[]
				{
					this,
					charImageInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_dialogCharUIController.GetCharImageInfo() != charImageInfo)
			{
				this.m_dialogCharUIController.CreateGraphic(charImageInfo);
			}
		}

		// Token: 0x0600ED53 RID: 60755 RVA: 0x003F6C14 File Offset: 0x003F4E14
		public void SetDialog(ConfigDataGoddessDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDialogConfigDataGoddessDialogInfo_hotfix != null)
			{
				this.m_SetDialogConfigDataGoddessDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (dialogInfo == null)
			{
				return;
			}
			float delay = 0f;
			if (this.m_dialogInfo == null)
			{
				this.m_dialogBoxUIController.SetWords(string.Empty);
				delay = 2f;
			}
			this.m_dialogInfo = dialogInfo;
			this.m_dialogCharUIController.SetAnimation(dialogInfo.PreAnimation, dialogInfo.PreFacialAnimation, dialogInfo.IdleAnimation, dialogInfo.IdleFacialAnimation);
			base.StartCoroutine(this.Co_ShowWords(delay));
		}

		// Token: 0x0600ED54 RID: 60756 RVA: 0x003F6CEC File Offset: 0x003F4EEC
		public void CloseDialog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseDialog_hotfix != null)
			{
				this.m_CloseDialog_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_CloseDialog());
		}

		// Token: 0x0600ED55 RID: 60757 RVA: 0x003F6D5C File Offset: 0x003F4F5C
		public void ShowJobs(ConfigDataHeroInfo heroInfo, List<ConfigDataJobConnectionInfo> jobConnectionInfos, bool hasPrev, bool hasNext)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowJobsConfigDataHeroInfoList`1BooleanBoolean_hotfix != null)
			{
				this.m_ShowJobsConfigDataHeroInfoList`1BooleanBoolean_hotfix.call(new object[]
				{
					this,
					heroInfo,
					jobConnectionInfos,
					hasPrev,
					hasNext
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.printGameEventLog("29", string.Empty);
			this.m_jobGameObject.SetActive(true);
			UIUtility.SetUIStateOpen(this.m_jobUIStateController, "Open", null, false, true);
			this.m_heroNameText.text = heroInfo.Name;
			if (heroInfo != null)
			{
				ConfigDataCharImageInfo charImageInfo = heroInfo.GetCharImageInfo(heroInfo.Star);
				if (charImageInfo != null)
				{
					this.m_heroIconImage.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
				}
			}
			this.m_jobButtons[0].SetJobConnectionInfo(jobConnectionInfos[jobConnectionInfos.Count - 2]);
			this.m_jobButtons[1].SetJobConnectionInfo(jobConnectionInfos[jobConnectionInfos.Count - 1]);
			if (hasPrev || hasNext)
			{
				this.m_jobButtonGroup1GameObject.SetActive(false);
				this.m_jobButtonGroup2GameObject.SetActive(true);
				this.m_prevButton.gameObject.SetActive(hasPrev);
				this.m_nextButton.gameObject.SetActive(hasNext);
			}
			else
			{
				this.m_jobButtonGroup1GameObject.SetActive(true);
				this.m_jobButtonGroup2GameObject.SetActive(false);
			}
		}

		// Token: 0x0600ED56 RID: 60758 RVA: 0x003F6F1C File Offset: 0x003F511C
		public void HideJobConnections()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideJobConnections_hotfix != null)
			{
				this.m_HideJobConnections_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_jobUIStateController, "Close", delegate
			{
				this.m_jobGameObject.SetActive(false);
			}, true, true);
		}

		// Token: 0x0600ED57 RID: 60759 RVA: 0x003F6F9C File Offset: 0x003F519C
		[DebuggerHidden]
		private IEnumerator Co_CloseDialog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_CloseDialog_hotfix != null)
			{
				return (IEnumerator)this.m_Co_CloseDialog_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoddessDialogUIController.<Co_CloseDialog>c__Iterator0 <Co_CloseDialog>c__Iterator = new GoddessDialogUIController.<Co_CloseDialog>c__Iterator0();
			<Co_CloseDialog>c__Iterator.$this = this;
			return <Co_CloseDialog>c__Iterator;
		}

		// Token: 0x0600ED58 RID: 60760 RVA: 0x003F7018 File Offset: 0x003F5218
		[DebuggerHidden]
		private IEnumerator Co_ShowWords(float delay)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowWordsSingle_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowWordsSingle_hotfix.call(new object[]
				{
					this,
					delay
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoddessDialogUIController.<Co_ShowWords>c__Iterator1 <Co_ShowWords>c__Iterator = new GoddessDialogUIController.<Co_ShowWords>c__Iterator1();
			<Co_ShowWords>c__Iterator.delay = delay;
			<Co_ShowWords>c__Iterator.$this = this;
			return <Co_ShowWords>c__Iterator;
		}

		// Token: 0x0600ED59 RID: 60761 RVA: 0x003F70AC File Offset: 0x003F52AC
		private void ShowChoice()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChoice_hotfix != null)
			{
				this.m_ShowChoice_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_dialogInfo == null)
			{
				return;
			}
			UIUtility.SetUIStateOpen(this.m_choiceUIStateController, "Open", null, false, true);
			this.m_dialogBoxUIController.Close();
			foreach (GoddessDialogChoiceButton goddessDialogChoiceButton in this.m_choiceButtons)
			{
				goddessDialogChoiceButton.SetText(string.Empty);
			}
			this.m_choiceButtons[0].SetText(this.m_dialogInfo.Choice1Text);
			this.m_choiceButtons[1].SetText(this.m_dialogInfo.Choice2Text);
			this.m_choiceButtons[2].SetText(this.m_dialogInfo.Choice3Text);
		}

		// Token: 0x0600ED5A RID: 60762 RVA: 0x003F71A8 File Offset: 0x003F53A8
		[DebuggerHidden]
		private IEnumerator Co_DoChoice(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_DoChoiceInt32_hotfix != null)
			{
				return (IEnumerator)this.m_Co_DoChoiceInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoddessDialogUIController.<Co_DoChoice>c__Iterator2 <Co_DoChoice>c__Iterator = new GoddessDialogUIController.<Co_DoChoice>c__Iterator2();
			<Co_DoChoice>c__Iterator.idx = idx;
			<Co_DoChoice>c__Iterator.$this = this;
			return <Co_DoChoice>c__Iterator;
		}

		// Token: 0x0600ED5B RID: 60763 RVA: 0x003F723C File Offset: 0x003F543C
		[DebuggerHidden]
		private IEnumerator Co_WaitForSecondsOrClick(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_WaitForSecondsOrClickSingle_hotfix != null)
			{
				return (IEnumerator)this.m_Co_WaitForSecondsOrClickSingle_hotfix.call(new object[]
				{
					this,
					time
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoddessDialogUIController.<Co_WaitForSecondsOrClick>c__Iterator3 <Co_WaitForSecondsOrClick>c__Iterator = new GoddessDialogUIController.<Co_WaitForSecondsOrClick>c__Iterator3();
			<Co_WaitForSecondsOrClick>c__Iterator.time = time;
			<Co_WaitForSecondsOrClick>c__Iterator.$this = this;
			return <Co_WaitForSecondsOrClick>c__Iterator;
		}

		// Token: 0x0600ED5C RID: 60764 RVA: 0x003F72D0 File Offset: 0x003F54D0
		[DebuggerHidden]
		private IEnumerator Co_WaitForClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_WaitForClick_hotfix != null)
			{
				return (IEnumerator)this.m_Co_WaitForClick_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoddessDialogUIController.<Co_WaitForClick>c__Iterator4 <Co_WaitForClick>c__Iterator = new GoddessDialogUIController.<Co_WaitForClick>c__Iterator4();
			<Co_WaitForClick>c__Iterator.$this = this;
			return <Co_WaitForClick>c__Iterator;
		}

		// Token: 0x0600ED5D RID: 60765 RVA: 0x003F734C File Offset: 0x003F554C
		[DebuggerHidden]
		private IEnumerator Co_WaitForAllWordsDisplayed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_WaitForAllWordsDisplayed_hotfix != null)
			{
				return (IEnumerator)this.m_Co_WaitForAllWordsDisplayed_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoddessDialogUIController.<Co_WaitForAllWordsDisplayed>c__Iterator5 <Co_WaitForAllWordsDisplayed>c__Iterator = new GoddessDialogUIController.<Co_WaitForAllWordsDisplayed>c__Iterator5();
			<Co_WaitForAllWordsDisplayed>c__Iterator.$this = this;
			return <Co_WaitForAllWordsDisplayed>c__Iterator;
		}

		// Token: 0x0600ED5E RID: 60766 RVA: 0x003F73C8 File Offset: 0x003F55C8
		private bool HasChoice()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasChoice_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasChoice_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_dialogInfo != null && (!string.IsNullOrEmpty(this.m_dialogInfo.Choice1Text) || !string.IsNullOrEmpty(this.m_dialogInfo.Choice2Text) || !string.IsNullOrEmpty(this.m_dialogInfo.Choice3Text));
		}

		// Token: 0x0600ED5F RID: 60767 RVA: 0x003F7484 File Offset: 0x003F5684
		private IAudioPlayback PlayVoice(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayVoiceString_hotfix != null)
			{
				return (IAudioPlayback)this.m_PlayVoiceString_hotfix.call(new object[]
				{
					this,
					name
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return AudioUtility.PlaySound(name);
		}

		// Token: 0x0600ED60 RID: 60768 RVA: 0x003F7508 File Offset: 0x003F5708
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isClickBackground = true;
			if (this.m_dialogBoxUIController.IsOpened() && !this.m_dialogBoxUIController.IsAllWordsDisplayed())
			{
				this.m_dialogBoxUIController.DisplayAllWords();
				return;
			}
			if (!this.HasChoice())
			{
				if (this.m_dialogBoxUIController.IsAllWordsDisplayed() && this.EventOnNext != null)
				{
					this.EventOnNext();
				}
			}
		}

		// Token: 0x0600ED61 RID: 60769 RVA: 0x003F75D4 File Offset: 0x003F57D4
		private void OnAcceptButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAcceptButtonClick_hotfix != null)
			{
				this.m_OnAcceptButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnConfirmJob != null)
			{
				this.EventOnConfirmJob();
			}
		}

		// Token: 0x0600ED62 RID: 60770 RVA: 0x003F764C File Offset: 0x003F584C
		private void OnRetryButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRetryButtonClick_hotfix != null)
			{
				this.m_OnRetryButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRetry != null)
			{
				this.EventOnRetry();
			}
		}

		// Token: 0x0600ED63 RID: 60771 RVA: 0x003F76C4 File Offset: 0x003F58C4
		private void OnSelectButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectButtonClick_hotfix != null)
			{
				this.m_OnSelectButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSelectJob != null)
			{
				this.EventOnSelectJob();
			}
		}

		// Token: 0x0600ED64 RID: 60772 RVA: 0x003F773C File Offset: 0x003F593C
		private void OnConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfirmButtonClick_hotfix != null)
			{
				this.m_OnConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnConfirmJob != null)
			{
				this.EventOnConfirmJob();
			}
		}

		// Token: 0x0600ED65 RID: 60773 RVA: 0x003F77B4 File Offset: 0x003F59B4
		private void OnRetryButton2Click()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRetryButton2Click_hotfix != null)
			{
				this.m_OnRetryButton2Click_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRetry != null)
			{
				this.EventOnRetry();
			}
		}

		// Token: 0x0600ED66 RID: 60774 RVA: 0x003F782C File Offset: 0x003F5A2C
		private void OnPrevButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPrevButtonClick_hotfix != null)
			{
				this.m_OnPrevButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPrevJob != null)
			{
				this.EventOnPrevJob();
			}
		}

		// Token: 0x0600ED67 RID: 60775 RVA: 0x003F78A4 File Offset: 0x003F5AA4
		private void OnNextButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNextButtonClick_hotfix != null)
			{
				this.m_OnNextButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnNextJob != null)
			{
				this.EventOnNextJob();
			}
		}

		// Token: 0x0600ED68 RID: 60776 RVA: 0x003F791C File Offset: 0x003F5B1C
		private void OnChoiceButtonClick(GoddessDialogChoiceButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChoiceButtonClickGoddessDialogChoiceButton_hotfix != null)
			{
				this.m_OnChoiceButtonClickGoddessDialogChoiceButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isDoingChoose)
			{
				return;
			}
			base.StartCoroutine(this.Co_DoChoice(b.GetIndex()));
		}

		// Token: 0x0600ED69 RID: 60777 RVA: 0x003F79AC File Offset: 0x003F5BAC
		private void OnJobButtonClick(GoddessDialogJobButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobButtonClickGoddessDialogJobButton_hotfix != null)
			{
				this.m_OnJobButtonClickGoddessDialogJobButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowJobInfo != null)
			{
				this.EventOnShowJobInfo(b.GetJobConnectionInfo());
			}
		}

		// Token: 0x1400031E RID: 798
		// (add) Token: 0x0600ED6A RID: 60778 RVA: 0x003F7A38 File Offset: 0x003F5C38
		// (remove) Token: 0x0600ED6B RID: 60779 RVA: 0x003F7AD4 File Offset: 0x003F5CD4
		public event Action EventOnNext
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNextAction_hotfix != null)
				{
					this.m_add_EventOnNextAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNext;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNext, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNextAction_hotfix != null)
				{
					this.m_remove_EventOnNextAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNext;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNext, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400031F RID: 799
		// (add) Token: 0x0600ED6C RID: 60780 RVA: 0x003F7B70 File Offset: 0x003F5D70
		// (remove) Token: 0x0600ED6D RID: 60781 RVA: 0x003F7C0C File Offset: 0x003F5E0C
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000320 RID: 800
		// (add) Token: 0x0600ED6E RID: 60782 RVA: 0x003F7CA8 File Offset: 0x003F5EA8
		// (remove) Token: 0x0600ED6F RID: 60783 RVA: 0x003F7D44 File Offset: 0x003F5F44
		public event Action<int> EventOnChoose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChooseAction`1_hotfix != null)
				{
					this.m_add_EventOnChooseAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnChoose;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnChoose, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChooseAction`1_hotfix != null)
				{
					this.m_remove_EventOnChooseAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnChoose;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnChoose, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000321 RID: 801
		// (add) Token: 0x0600ED70 RID: 60784 RVA: 0x003F7DE0 File Offset: 0x003F5FE0
		// (remove) Token: 0x0600ED71 RID: 60785 RVA: 0x003F7E7C File Offset: 0x003F607C
		public event Action<ConfigDataJobConnectionInfo> EventOnShowJobInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowJobInfoAction`1_hotfix != null)
				{
					this.m_add_EventOnShowJobInfoAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataJobConnectionInfo> action = this.EventOnShowJobInfo;
				Action<ConfigDataJobConnectionInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataJobConnectionInfo>>(ref this.EventOnShowJobInfo, (Action<ConfigDataJobConnectionInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowJobInfoAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowJobInfoAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataJobConnectionInfo> action = this.EventOnShowJobInfo;
				Action<ConfigDataJobConnectionInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataJobConnectionInfo>>(ref this.EventOnShowJobInfo, (Action<ConfigDataJobConnectionInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000322 RID: 802
		// (add) Token: 0x0600ED72 RID: 60786 RVA: 0x003F7F18 File Offset: 0x003F6118
		// (remove) Token: 0x0600ED73 RID: 60787 RVA: 0x003F7FB4 File Offset: 0x003F61B4
		public event Action EventOnConfirmJob
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnConfirmJobAction_hotfix != null)
				{
					this.m_add_EventOnConfirmJobAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnConfirmJob;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnConfirmJob, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnConfirmJobAction_hotfix != null)
				{
					this.m_remove_EventOnConfirmJobAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnConfirmJob;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnConfirmJob, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000323 RID: 803
		// (add) Token: 0x0600ED74 RID: 60788 RVA: 0x003F8050 File Offset: 0x003F6250
		// (remove) Token: 0x0600ED75 RID: 60789 RVA: 0x003F80EC File Offset: 0x003F62EC
		public event Action EventOnRetry
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRetryAction_hotfix != null)
				{
					this.m_add_EventOnRetryAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRetry;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRetry, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRetryAction_hotfix != null)
				{
					this.m_remove_EventOnRetryAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRetry;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRetry, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000324 RID: 804
		// (add) Token: 0x0600ED76 RID: 60790 RVA: 0x003F8188 File Offset: 0x003F6388
		// (remove) Token: 0x0600ED77 RID: 60791 RVA: 0x003F8224 File Offset: 0x003F6424
		public event Action EventOnSelectJob
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectJobAction_hotfix != null)
				{
					this.m_add_EventOnSelectJobAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSelectJob;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSelectJob, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectJobAction_hotfix != null)
				{
					this.m_remove_EventOnSelectJobAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSelectJob;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSelectJob, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000325 RID: 805
		// (add) Token: 0x0600ED78 RID: 60792 RVA: 0x003F82C0 File Offset: 0x003F64C0
		// (remove) Token: 0x0600ED79 RID: 60793 RVA: 0x003F835C File Offset: 0x003F655C
		public event Action EventOnPrevJob
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPrevJobAction_hotfix != null)
				{
					this.m_add_EventOnPrevJobAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPrevJob;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPrevJob, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPrevJobAction_hotfix != null)
				{
					this.m_remove_EventOnPrevJobAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPrevJob;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPrevJob, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000326 RID: 806
		// (add) Token: 0x0600ED7A RID: 60794 RVA: 0x003F83F8 File Offset: 0x003F65F8
		// (remove) Token: 0x0600ED7B RID: 60795 RVA: 0x003F8494 File Offset: 0x003F6694
		public event Action EventOnNextJob
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNextJobAction_hotfix != null)
				{
					this.m_add_EventOnNextJobAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNextJob;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNextJob, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNextJobAction_hotfix != null)
				{
					this.m_remove_EventOnNextJobAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNextJob;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNextJob, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0600ED7C RID: 60796 RVA: 0x003F8530 File Offset: 0x003F6730
		// (set) Token: 0x0600ED7D RID: 60797 RVA: 0x003F8550 File Offset: 0x003F6750
		[DoNotToLua]
		public new GoddessDialogUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GoddessDialogUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600ED7E RID: 60798 RVA: 0x003F855C File Offset: 0x003F675C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600ED7F RID: 60799 RVA: 0x003F8568 File Offset: 0x003F6768
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600ED80 RID: 60800 RVA: 0x003F8570 File Offset: 0x003F6770
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600ED81 RID: 60801 RVA: 0x003F8578 File Offset: 0x003F6778
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600ED82 RID: 60802 RVA: 0x003F858C File Offset: 0x003F678C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600ED83 RID: 60803 RVA: 0x003F8594 File Offset: 0x003F6794
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600ED84 RID: 60804 RVA: 0x003F85A0 File Offset: 0x003F67A0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600ED85 RID: 60805 RVA: 0x003F85AC File Offset: 0x003F67AC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600ED86 RID: 60806 RVA: 0x003F85B8 File Offset: 0x003F67B8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600ED87 RID: 60807 RVA: 0x003F85C4 File Offset: 0x003F67C4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600ED88 RID: 60808 RVA: 0x003F85D0 File Offset: 0x003F67D0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600ED89 RID: 60809 RVA: 0x003F85DC File Offset: 0x003F67DC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600ED8A RID: 60810 RVA: 0x003F85E8 File Offset: 0x003F67E8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600ED8B RID: 60811 RVA: 0x003F85F4 File Offset: 0x003F67F4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600ED8C RID: 60812 RVA: 0x003F8600 File Offset: 0x003F6800
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600ED8D RID: 60813 RVA: 0x003F8608 File Offset: 0x003F6808
		private void __callDele_EventOnNext()
		{
			Action eventOnNext = this.EventOnNext;
			if (eventOnNext != null)
			{
				eventOnNext();
			}
		}

		// Token: 0x0600ED8E RID: 60814 RVA: 0x003F8628 File Offset: 0x003F6828
		private void __clearDele_EventOnNext()
		{
			this.EventOnNext = null;
		}

		// Token: 0x0600ED8F RID: 60815 RVA: 0x003F8634 File Offset: 0x003F6834
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600ED90 RID: 60816 RVA: 0x003F8654 File Offset: 0x003F6854
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600ED91 RID: 60817 RVA: 0x003F8660 File Offset: 0x003F6860
		private void __callDele_EventOnChoose(int obj)
		{
			Action<int> eventOnChoose = this.EventOnChoose;
			if (eventOnChoose != null)
			{
				eventOnChoose(obj);
			}
		}

		// Token: 0x0600ED92 RID: 60818 RVA: 0x003F8684 File Offset: 0x003F6884
		private void __clearDele_EventOnChoose(int obj)
		{
			this.EventOnChoose = null;
		}

		// Token: 0x0600ED93 RID: 60819 RVA: 0x003F8690 File Offset: 0x003F6890
		private void __callDele_EventOnShowJobInfo(ConfigDataJobConnectionInfo obj)
		{
			Action<ConfigDataJobConnectionInfo> eventOnShowJobInfo = this.EventOnShowJobInfo;
			if (eventOnShowJobInfo != null)
			{
				eventOnShowJobInfo(obj);
			}
		}

		// Token: 0x0600ED94 RID: 60820 RVA: 0x003F86B4 File Offset: 0x003F68B4
		private void __clearDele_EventOnShowJobInfo(ConfigDataJobConnectionInfo obj)
		{
			this.EventOnShowJobInfo = null;
		}

		// Token: 0x0600ED95 RID: 60821 RVA: 0x003F86C0 File Offset: 0x003F68C0
		private void __callDele_EventOnConfirmJob()
		{
			Action eventOnConfirmJob = this.EventOnConfirmJob;
			if (eventOnConfirmJob != null)
			{
				eventOnConfirmJob();
			}
		}

		// Token: 0x0600ED96 RID: 60822 RVA: 0x003F86E0 File Offset: 0x003F68E0
		private void __clearDele_EventOnConfirmJob()
		{
			this.EventOnConfirmJob = null;
		}

		// Token: 0x0600ED97 RID: 60823 RVA: 0x003F86EC File Offset: 0x003F68EC
		private void __callDele_EventOnRetry()
		{
			Action eventOnRetry = this.EventOnRetry;
			if (eventOnRetry != null)
			{
				eventOnRetry();
			}
		}

		// Token: 0x0600ED98 RID: 60824 RVA: 0x003F870C File Offset: 0x003F690C
		private void __clearDele_EventOnRetry()
		{
			this.EventOnRetry = null;
		}

		// Token: 0x0600ED99 RID: 60825 RVA: 0x003F8718 File Offset: 0x003F6918
		private void __callDele_EventOnSelectJob()
		{
			Action eventOnSelectJob = this.EventOnSelectJob;
			if (eventOnSelectJob != null)
			{
				eventOnSelectJob();
			}
		}

		// Token: 0x0600ED9A RID: 60826 RVA: 0x003F8738 File Offset: 0x003F6938
		private void __clearDele_EventOnSelectJob()
		{
			this.EventOnSelectJob = null;
		}

		// Token: 0x0600ED9B RID: 60827 RVA: 0x003F8744 File Offset: 0x003F6944
		private void __callDele_EventOnPrevJob()
		{
			Action eventOnPrevJob = this.EventOnPrevJob;
			if (eventOnPrevJob != null)
			{
				eventOnPrevJob();
			}
		}

		// Token: 0x0600ED9C RID: 60828 RVA: 0x003F8764 File Offset: 0x003F6964
		private void __clearDele_EventOnPrevJob()
		{
			this.EventOnPrevJob = null;
		}

		// Token: 0x0600ED9D RID: 60829 RVA: 0x003F8770 File Offset: 0x003F6970
		private void __callDele_EventOnNextJob()
		{
			Action eventOnNextJob = this.EventOnNextJob;
			if (eventOnNextJob != null)
			{
				eventOnNextJob();
			}
		}

		// Token: 0x0600ED9E RID: 60830 RVA: 0x003F8790 File Offset: 0x003F6990
		private void __clearDele_EventOnNextJob()
		{
			this.EventOnNextJob = null;
		}

		// Token: 0x0600EDA0 RID: 60832 RVA: 0x003F87AC File Offset: 0x003F69AC
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
					this.m_Start_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_CreateCharConfigDataCharImageInfo_hotfix = (luaObj.RawGet("CreateChar") as LuaFunction);
					this.m_SetDialogConfigDataGoddessDialogInfo_hotfix = (luaObj.RawGet("SetDialog") as LuaFunction);
					this.m_CloseDialog_hotfix = (luaObj.RawGet("CloseDialog") as LuaFunction);
					this.m_ShowJobsConfigDataHeroInfoList`1BooleanBoolean_hotfix = (luaObj.RawGet("ShowJobs") as LuaFunction);
					this.m_HideJobConnections_hotfix = (luaObj.RawGet("HideJobConnections") as LuaFunction);
					this.m_Co_CloseDialog_hotfix = (luaObj.RawGet("Co_CloseDialog") as LuaFunction);
					this.m_Co_ShowWordsSingle_hotfix = (luaObj.RawGet("Co_ShowWords") as LuaFunction);
					this.m_ShowChoice_hotfix = (luaObj.RawGet("ShowChoice") as LuaFunction);
					this.m_Co_DoChoiceInt32_hotfix = (luaObj.RawGet("Co_DoChoice") as LuaFunction);
					this.m_Co_WaitForSecondsOrClickSingle_hotfix = (luaObj.RawGet("Co_WaitForSecondsOrClick") as LuaFunction);
					this.m_Co_WaitForClick_hotfix = (luaObj.RawGet("Co_WaitForClick") as LuaFunction);
					this.m_Co_WaitForAllWordsDisplayed_hotfix = (luaObj.RawGet("Co_WaitForAllWordsDisplayed") as LuaFunction);
					this.m_HasChoice_hotfix = (luaObj.RawGet("HasChoice") as LuaFunction);
					this.m_PlayVoiceString_hotfix = (luaObj.RawGet("PlayVoice") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnAcceptButtonClick_hotfix = (luaObj.RawGet("OnAcceptButtonClick") as LuaFunction);
					this.m_OnRetryButtonClick_hotfix = (luaObj.RawGet("OnRetryButtonClick") as LuaFunction);
					this.m_OnSelectButtonClick_hotfix = (luaObj.RawGet("OnSelectButtonClick") as LuaFunction);
					this.m_OnConfirmButtonClick_hotfix = (luaObj.RawGet("OnConfirmButtonClick") as LuaFunction);
					this.m_OnRetryButton2Click_hotfix = (luaObj.RawGet("OnRetryButton2Click") as LuaFunction);
					this.m_OnPrevButtonClick_hotfix = (luaObj.RawGet("OnPrevButtonClick") as LuaFunction);
					this.m_OnNextButtonClick_hotfix = (luaObj.RawGet("OnNextButtonClick") as LuaFunction);
					this.m_OnChoiceButtonClickGoddessDialogChoiceButton_hotfix = (luaObj.RawGet("OnChoiceButtonClick") as LuaFunction);
					this.m_OnJobButtonClickGoddessDialogJobButton_hotfix = (luaObj.RawGet("OnJobButtonClick") as LuaFunction);
					this.m_add_EventOnNextAction_hotfix = (luaObj.RawGet("add_EventOnNext") as LuaFunction);
					this.m_remove_EventOnNextAction_hotfix = (luaObj.RawGet("remove_EventOnNext") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnChooseAction`1_hotfix = (luaObj.RawGet("add_EventOnChoose") as LuaFunction);
					this.m_remove_EventOnChooseAction`1_hotfix = (luaObj.RawGet("remove_EventOnChoose") as LuaFunction);
					this.m_add_EventOnShowJobInfoAction`1_hotfix = (luaObj.RawGet("add_EventOnShowJobInfo") as LuaFunction);
					this.m_remove_EventOnShowJobInfoAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowJobInfo") as LuaFunction);
					this.m_add_EventOnConfirmJobAction_hotfix = (luaObj.RawGet("add_EventOnConfirmJob") as LuaFunction);
					this.m_remove_EventOnConfirmJobAction_hotfix = (luaObj.RawGet("remove_EventOnConfirmJob") as LuaFunction);
					this.m_add_EventOnRetryAction_hotfix = (luaObj.RawGet("add_EventOnRetry") as LuaFunction);
					this.m_remove_EventOnRetryAction_hotfix = (luaObj.RawGet("remove_EventOnRetry") as LuaFunction);
					this.m_add_EventOnSelectJobAction_hotfix = (luaObj.RawGet("add_EventOnSelectJob") as LuaFunction);
					this.m_remove_EventOnSelectJobAction_hotfix = (luaObj.RawGet("remove_EventOnSelectJob") as LuaFunction);
					this.m_add_EventOnPrevJobAction_hotfix = (luaObj.RawGet("add_EventOnPrevJob") as LuaFunction);
					this.m_remove_EventOnPrevJobAction_hotfix = (luaObj.RawGet("remove_EventOnPrevJob") as LuaFunction);
					this.m_add_EventOnNextJobAction_hotfix = (luaObj.RawGet("add_EventOnNextJob") as LuaFunction);
					this.m_remove_EventOnNextJobAction_hotfix = (luaObj.RawGet("remove_EventOnNextJob") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600EDA1 RID: 60833 RVA: 0x003F8CAC File Offset: 0x003F6EAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GoddessDialogUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008DE7 RID: 36327
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x04008DE8 RID: 36328
		[AutoBind("./Words", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_wordsGameObject;

		// Token: 0x04008DE9 RID: 36329
		[AutoBind("./Char/0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGameObject;

		// Token: 0x04008DEA RID: 36330
		[AutoBind("./Choice", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_choiceUIStateController;

		// Token: 0x04008DEB RID: 36331
		[AutoBind("./Choice/1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_choice1GameObject;

		// Token: 0x04008DEC RID: 36332
		[AutoBind("./Choice/2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_choice2GameObject;

		// Token: 0x04008DED RID: 36333
		[AutoBind("./Choice/3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_choice3GameObject;

		// Token: 0x04008DEE RID: 36334
		[AutoBind("./Job", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobGameObject;

		// Token: 0x04008DEF RID: 36335
		[AutoBind("./Job/Panel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_jobUIStateController;

		// Token: 0x04008DF0 RID: 36336
		[AutoBind("./Job/Panel/HeroIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroIconImage;

		// Token: 0x04008DF1 RID: 36337
		[AutoBind("./Job/Panel/HeroNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroNameText;

		// Token: 0x04008DF2 RID: 36338
		[AutoBind("./Job/Panel/Job1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_job1GameObject;

		// Token: 0x04008DF3 RID: 36339
		[AutoBind("./Job/Panel/Job2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_job2GameObject;

		// Token: 0x04008DF4 RID: 36340
		[AutoBind("./Job/Panel/ButtonGroup1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobButtonGroup1GameObject;

		// Token: 0x04008DF5 RID: 36341
		[AutoBind("./Job/Panel/ButtonGroup1/AcceptButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_acceptButton;

		// Token: 0x04008DF6 RID: 36342
		[AutoBind("./Job/Panel/ButtonGroup1/RetryButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_retryButton;

		// Token: 0x04008DF7 RID: 36343
		[AutoBind("./Job/Panel/ButtonGroup1/SelectButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_selectButton;

		// Token: 0x04008DF8 RID: 36344
		[AutoBind("./Job/Panel/ButtonGroup2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobButtonGroup2GameObject;

		// Token: 0x04008DF9 RID: 36345
		[AutoBind("./Job/Panel/ButtonGroup2/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_confirmButton;

		// Token: 0x04008DFA RID: 36346
		[AutoBind("./Job/Panel/ButtonGroup2/RetryButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_retryButton2;

		// Token: 0x04008DFB RID: 36347
		[AutoBind("./Job/Panel/ButtonGroup2/PrevButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_prevButton;

		// Token: 0x04008DFC RID: 36348
		[AutoBind("./Job/Panel/ButtonGroup2/NextButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_nextButton;

		// Token: 0x04008DFD RID: 36349
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04008DFE RID: 36350
		private DialogCharUIController m_dialogCharUIController;

		// Token: 0x04008DFF RID: 36351
		private GoddessDialogBoxUIController m_dialogBoxUIController;

		// Token: 0x04008E00 RID: 36352
		private GoddessDialogChoiceButton[] m_choiceButtons = new GoddessDialogChoiceButton[3];

		// Token: 0x04008E01 RID: 36353
		private GoddessDialogJobButton[] m_jobButtons = new GoddessDialogJobButton[2];

		// Token: 0x04008E02 RID: 36354
		private ConfigDataGoddessDialogInfo m_dialogInfo;

		// Token: 0x04008E03 RID: 36355
		private List<string> m_feedbackVoices = new List<string>();

		// Token: 0x04008E04 RID: 36356
		private List<string> m_feedbackTexts = new List<string>();

		// Token: 0x04008E05 RID: 36357
		private bool m_isClickBackground;

		// Token: 0x04008E06 RID: 36358
		private bool m_isDoingChoose;

		// Token: 0x04008E07 RID: 36359
		[DoNotToLua]
		private GoddessDialogUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008E08 RID: 36360
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008E09 RID: 36361
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008E0A RID: 36362
		private LuaFunction m_Start_hotfix;

		// Token: 0x04008E0B RID: 36363
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008E0C RID: 36364
		private LuaFunction m_CreateCharConfigDataCharImageInfo_hotfix;

		// Token: 0x04008E0D RID: 36365
		private LuaFunction m_SetDialogConfigDataGoddessDialogInfo_hotfix;

		// Token: 0x04008E0E RID: 36366
		private LuaFunction m_CloseDialog_hotfix;

		// Token: 0x04008E0F RID: 36367
		private LuaFunction m_ShowJobsConfigDataHeroInfoList;

		// Token: 0x04008E10 RID: 36368
		private LuaFunction m_HideJobConnections_hotfix;

		// Token: 0x04008E11 RID: 36369
		private LuaFunction m_Co_CloseDialog_hotfix;

		// Token: 0x04008E12 RID: 36370
		private LuaFunction m_Co_ShowWordsSingle_hotfix;

		// Token: 0x04008E13 RID: 36371
		private LuaFunction m_ShowChoice_hotfix;

		// Token: 0x04008E14 RID: 36372
		private LuaFunction m_Co_DoChoiceInt32_hotfix;

		// Token: 0x04008E15 RID: 36373
		private LuaFunction m_Co_WaitForSecondsOrClickSingle_hotfix;

		// Token: 0x04008E16 RID: 36374
		private LuaFunction m_Co_WaitForClick_hotfix;

		// Token: 0x04008E17 RID: 36375
		private LuaFunction m_Co_WaitForAllWordsDisplayed_hotfix;

		// Token: 0x04008E18 RID: 36376
		private LuaFunction m_HasChoice_hotfix;

		// Token: 0x04008E19 RID: 36377
		private LuaFunction m_PlayVoiceString_hotfix;

		// Token: 0x04008E1A RID: 36378
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04008E1B RID: 36379
		private LuaFunction m_OnAcceptButtonClick_hotfix;

		// Token: 0x04008E1C RID: 36380
		private LuaFunction m_OnRetryButtonClick_hotfix;

		// Token: 0x04008E1D RID: 36381
		private LuaFunction m_OnSelectButtonClick_hotfix;

		// Token: 0x04008E1E RID: 36382
		private LuaFunction m_OnConfirmButtonClick_hotfix;

		// Token: 0x04008E1F RID: 36383
		private LuaFunction m_OnRetryButton2Click_hotfix;

		// Token: 0x04008E20 RID: 36384
		private LuaFunction m_OnPrevButtonClick_hotfix;

		// Token: 0x04008E21 RID: 36385
		private LuaFunction m_OnNextButtonClick_hotfix;

		// Token: 0x04008E22 RID: 36386
		private LuaFunction m_OnChoiceButtonClickGoddessDialogChoiceButton_hotfix;

		// Token: 0x04008E23 RID: 36387
		private LuaFunction m_OnJobButtonClickGoddessDialogJobButton_hotfix;

		// Token: 0x04008E24 RID: 36388
		private LuaFunction m_add_EventOnNextAction_hotfix;

		// Token: 0x04008E25 RID: 36389
		private LuaFunction m_remove_EventOnNextAction_hotfix;

		// Token: 0x04008E26 RID: 36390
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04008E27 RID: 36391
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04008E28 RID: 36392
		private LuaFunction m_add_EventOnChooseAction;

		// Token: 0x04008E29 RID: 36393
		private LuaFunction m_remove_EventOnChooseAction;

		// Token: 0x04008E2A RID: 36394
		private LuaFunction m_add_EventOnShowJobInfoAction;

		// Token: 0x04008E2B RID: 36395
		private LuaFunction m_remove_EventOnShowJobInfoAction;

		// Token: 0x04008E2C RID: 36396
		private LuaFunction m_add_EventOnConfirmJobAction_hotfix;

		// Token: 0x04008E2D RID: 36397
		private LuaFunction m_remove_EventOnConfirmJobAction_hotfix;

		// Token: 0x04008E2E RID: 36398
		private LuaFunction m_add_EventOnRetryAction_hotfix;

		// Token: 0x04008E2F RID: 36399
		private LuaFunction m_remove_EventOnRetryAction_hotfix;

		// Token: 0x04008E30 RID: 36400
		private LuaFunction m_add_EventOnSelectJobAction_hotfix;

		// Token: 0x04008E31 RID: 36401
		private LuaFunction m_remove_EventOnSelectJobAction_hotfix;

		// Token: 0x04008E32 RID: 36402
		private LuaFunction m_add_EventOnPrevJobAction_hotfix;

		// Token: 0x04008E33 RID: 36403
		private LuaFunction m_remove_EventOnPrevJobAction_hotfix;

		// Token: 0x04008E34 RID: 36404
		private LuaFunction m_add_EventOnNextJobAction_hotfix;

		// Token: 0x04008E35 RID: 36405
		private LuaFunction m_remove_EventOnNextJobAction_hotfix;

		// Token: 0x02000CC7 RID: 3271
		public new class LuaExportHelper
		{
			// Token: 0x0600EDA2 RID: 60834 RVA: 0x003F8D14 File Offset: 0x003F6F14
			public LuaExportHelper(GoddessDialogUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600EDA3 RID: 60835 RVA: 0x003F8D24 File Offset: 0x003F6F24
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600EDA4 RID: 60836 RVA: 0x003F8D34 File Offset: 0x003F6F34
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600EDA5 RID: 60837 RVA: 0x003F8D44 File Offset: 0x003F6F44
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600EDA6 RID: 60838 RVA: 0x003F8D54 File Offset: 0x003F6F54
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600EDA7 RID: 60839 RVA: 0x003F8D6C File Offset: 0x003F6F6C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600EDA8 RID: 60840 RVA: 0x003F8D7C File Offset: 0x003F6F7C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600EDA9 RID: 60841 RVA: 0x003F8D8C File Offset: 0x003F6F8C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600EDAA RID: 60842 RVA: 0x003F8D9C File Offset: 0x003F6F9C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600EDAB RID: 60843 RVA: 0x003F8DAC File Offset: 0x003F6FAC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600EDAC RID: 60844 RVA: 0x003F8DBC File Offset: 0x003F6FBC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600EDAD RID: 60845 RVA: 0x003F8DCC File Offset: 0x003F6FCC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600EDAE RID: 60846 RVA: 0x003F8DDC File Offset: 0x003F6FDC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600EDAF RID: 60847 RVA: 0x003F8DEC File Offset: 0x003F6FEC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600EDB0 RID: 60848 RVA: 0x003F8DFC File Offset: 0x003F6FFC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600EDB1 RID: 60849 RVA: 0x003F8E0C File Offset: 0x003F700C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600EDB2 RID: 60850 RVA: 0x003F8E1C File Offset: 0x003F701C
			public void __callDele_EventOnNext()
			{
				this.m_owner.__callDele_EventOnNext();
			}

			// Token: 0x0600EDB3 RID: 60851 RVA: 0x003F8E2C File Offset: 0x003F702C
			public void __clearDele_EventOnNext()
			{
				this.m_owner.__clearDele_EventOnNext();
			}

			// Token: 0x0600EDB4 RID: 60852 RVA: 0x003F8E3C File Offset: 0x003F703C
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600EDB5 RID: 60853 RVA: 0x003F8E4C File Offset: 0x003F704C
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x0600EDB6 RID: 60854 RVA: 0x003F8E5C File Offset: 0x003F705C
			public void __callDele_EventOnChoose(int obj)
			{
				this.m_owner.__callDele_EventOnChoose(obj);
			}

			// Token: 0x0600EDB7 RID: 60855 RVA: 0x003F8E6C File Offset: 0x003F706C
			public void __clearDele_EventOnChoose(int obj)
			{
				this.m_owner.__clearDele_EventOnChoose(obj);
			}

			// Token: 0x0600EDB8 RID: 60856 RVA: 0x003F8E7C File Offset: 0x003F707C
			public void __callDele_EventOnShowJobInfo(ConfigDataJobConnectionInfo obj)
			{
				this.m_owner.__callDele_EventOnShowJobInfo(obj);
			}

			// Token: 0x0600EDB9 RID: 60857 RVA: 0x003F8E8C File Offset: 0x003F708C
			public void __clearDele_EventOnShowJobInfo(ConfigDataJobConnectionInfo obj)
			{
				this.m_owner.__clearDele_EventOnShowJobInfo(obj);
			}

			// Token: 0x0600EDBA RID: 60858 RVA: 0x003F8E9C File Offset: 0x003F709C
			public void __callDele_EventOnConfirmJob()
			{
				this.m_owner.__callDele_EventOnConfirmJob();
			}

			// Token: 0x0600EDBB RID: 60859 RVA: 0x003F8EAC File Offset: 0x003F70AC
			public void __clearDele_EventOnConfirmJob()
			{
				this.m_owner.__clearDele_EventOnConfirmJob();
			}

			// Token: 0x0600EDBC RID: 60860 RVA: 0x003F8EBC File Offset: 0x003F70BC
			public void __callDele_EventOnRetry()
			{
				this.m_owner.__callDele_EventOnRetry();
			}

			// Token: 0x0600EDBD RID: 60861 RVA: 0x003F8ECC File Offset: 0x003F70CC
			public void __clearDele_EventOnRetry()
			{
				this.m_owner.__clearDele_EventOnRetry();
			}

			// Token: 0x0600EDBE RID: 60862 RVA: 0x003F8EDC File Offset: 0x003F70DC
			public void __callDele_EventOnSelectJob()
			{
				this.m_owner.__callDele_EventOnSelectJob();
			}

			// Token: 0x0600EDBF RID: 60863 RVA: 0x003F8EEC File Offset: 0x003F70EC
			public void __clearDele_EventOnSelectJob()
			{
				this.m_owner.__clearDele_EventOnSelectJob();
			}

			// Token: 0x0600EDC0 RID: 60864 RVA: 0x003F8EFC File Offset: 0x003F70FC
			public void __callDele_EventOnPrevJob()
			{
				this.m_owner.__callDele_EventOnPrevJob();
			}

			// Token: 0x0600EDC1 RID: 60865 RVA: 0x003F8F0C File Offset: 0x003F710C
			public void __clearDele_EventOnPrevJob()
			{
				this.m_owner.__clearDele_EventOnPrevJob();
			}

			// Token: 0x0600EDC2 RID: 60866 RVA: 0x003F8F1C File Offset: 0x003F711C
			public void __callDele_EventOnNextJob()
			{
				this.m_owner.__callDele_EventOnNextJob();
			}

			// Token: 0x0600EDC3 RID: 60867 RVA: 0x003F8F2C File Offset: 0x003F712C
			public void __clearDele_EventOnNextJob()
			{
				this.m_owner.__clearDele_EventOnNextJob();
			}

			// Token: 0x17002DC4 RID: 11716
			// (get) Token: 0x0600EDC4 RID: 60868 RVA: 0x003F8F3C File Offset: 0x003F713C
			// (set) Token: 0x0600EDC5 RID: 60869 RVA: 0x003F8F4C File Offset: 0x003F714C
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x17002DC5 RID: 11717
			// (get) Token: 0x0600EDC6 RID: 60870 RVA: 0x003F8F5C File Offset: 0x003F715C
			// (set) Token: 0x0600EDC7 RID: 60871 RVA: 0x003F8F6C File Offset: 0x003F716C
			public GameObject m_wordsGameObject
			{
				get
				{
					return this.m_owner.m_wordsGameObject;
				}
				set
				{
					this.m_owner.m_wordsGameObject = value;
				}
			}

			// Token: 0x17002DC6 RID: 11718
			// (get) Token: 0x0600EDC8 RID: 60872 RVA: 0x003F8F7C File Offset: 0x003F717C
			// (set) Token: 0x0600EDC9 RID: 60873 RVA: 0x003F8F8C File Offset: 0x003F718C
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

			// Token: 0x17002DC7 RID: 11719
			// (get) Token: 0x0600EDCA RID: 60874 RVA: 0x003F8F9C File Offset: 0x003F719C
			// (set) Token: 0x0600EDCB RID: 60875 RVA: 0x003F8FAC File Offset: 0x003F71AC
			public CommonUIStateController m_choiceUIStateController
			{
				get
				{
					return this.m_owner.m_choiceUIStateController;
				}
				set
				{
					this.m_owner.m_choiceUIStateController = value;
				}
			}

			// Token: 0x17002DC8 RID: 11720
			// (get) Token: 0x0600EDCC RID: 60876 RVA: 0x003F8FBC File Offset: 0x003F71BC
			// (set) Token: 0x0600EDCD RID: 60877 RVA: 0x003F8FCC File Offset: 0x003F71CC
			public GameObject m_choice1GameObject
			{
				get
				{
					return this.m_owner.m_choice1GameObject;
				}
				set
				{
					this.m_owner.m_choice1GameObject = value;
				}
			}

			// Token: 0x17002DC9 RID: 11721
			// (get) Token: 0x0600EDCE RID: 60878 RVA: 0x003F8FDC File Offset: 0x003F71DC
			// (set) Token: 0x0600EDCF RID: 60879 RVA: 0x003F8FEC File Offset: 0x003F71EC
			public GameObject m_choice2GameObject
			{
				get
				{
					return this.m_owner.m_choice2GameObject;
				}
				set
				{
					this.m_owner.m_choice2GameObject = value;
				}
			}

			// Token: 0x17002DCA RID: 11722
			// (get) Token: 0x0600EDD0 RID: 60880 RVA: 0x003F8FFC File Offset: 0x003F71FC
			// (set) Token: 0x0600EDD1 RID: 60881 RVA: 0x003F900C File Offset: 0x003F720C
			public GameObject m_choice3GameObject
			{
				get
				{
					return this.m_owner.m_choice3GameObject;
				}
				set
				{
					this.m_owner.m_choice3GameObject = value;
				}
			}

			// Token: 0x17002DCB RID: 11723
			// (get) Token: 0x0600EDD2 RID: 60882 RVA: 0x003F901C File Offset: 0x003F721C
			// (set) Token: 0x0600EDD3 RID: 60883 RVA: 0x003F902C File Offset: 0x003F722C
			public GameObject m_jobGameObject
			{
				get
				{
					return this.m_owner.m_jobGameObject;
				}
				set
				{
					this.m_owner.m_jobGameObject = value;
				}
			}

			// Token: 0x17002DCC RID: 11724
			// (get) Token: 0x0600EDD4 RID: 60884 RVA: 0x003F903C File Offset: 0x003F723C
			// (set) Token: 0x0600EDD5 RID: 60885 RVA: 0x003F904C File Offset: 0x003F724C
			public CommonUIStateController m_jobUIStateController
			{
				get
				{
					return this.m_owner.m_jobUIStateController;
				}
				set
				{
					this.m_owner.m_jobUIStateController = value;
				}
			}

			// Token: 0x17002DCD RID: 11725
			// (get) Token: 0x0600EDD6 RID: 60886 RVA: 0x003F905C File Offset: 0x003F725C
			// (set) Token: 0x0600EDD7 RID: 60887 RVA: 0x003F906C File Offset: 0x003F726C
			public Image m_heroIconImage
			{
				get
				{
					return this.m_owner.m_heroIconImage;
				}
				set
				{
					this.m_owner.m_heroIconImage = value;
				}
			}

			// Token: 0x17002DCE RID: 11726
			// (get) Token: 0x0600EDD8 RID: 60888 RVA: 0x003F907C File Offset: 0x003F727C
			// (set) Token: 0x0600EDD9 RID: 60889 RVA: 0x003F908C File Offset: 0x003F728C
			public Text m_heroNameText
			{
				get
				{
					return this.m_owner.m_heroNameText;
				}
				set
				{
					this.m_owner.m_heroNameText = value;
				}
			}

			// Token: 0x17002DCF RID: 11727
			// (get) Token: 0x0600EDDA RID: 60890 RVA: 0x003F909C File Offset: 0x003F729C
			// (set) Token: 0x0600EDDB RID: 60891 RVA: 0x003F90AC File Offset: 0x003F72AC
			public GameObject m_job1GameObject
			{
				get
				{
					return this.m_owner.m_job1GameObject;
				}
				set
				{
					this.m_owner.m_job1GameObject = value;
				}
			}

			// Token: 0x17002DD0 RID: 11728
			// (get) Token: 0x0600EDDC RID: 60892 RVA: 0x003F90BC File Offset: 0x003F72BC
			// (set) Token: 0x0600EDDD RID: 60893 RVA: 0x003F90CC File Offset: 0x003F72CC
			public GameObject m_job2GameObject
			{
				get
				{
					return this.m_owner.m_job2GameObject;
				}
				set
				{
					this.m_owner.m_job2GameObject = value;
				}
			}

			// Token: 0x17002DD1 RID: 11729
			// (get) Token: 0x0600EDDE RID: 60894 RVA: 0x003F90DC File Offset: 0x003F72DC
			// (set) Token: 0x0600EDDF RID: 60895 RVA: 0x003F90EC File Offset: 0x003F72EC
			public GameObject m_jobButtonGroup1GameObject
			{
				get
				{
					return this.m_owner.m_jobButtonGroup1GameObject;
				}
				set
				{
					this.m_owner.m_jobButtonGroup1GameObject = value;
				}
			}

			// Token: 0x17002DD2 RID: 11730
			// (get) Token: 0x0600EDE0 RID: 60896 RVA: 0x003F90FC File Offset: 0x003F72FC
			// (set) Token: 0x0600EDE1 RID: 60897 RVA: 0x003F910C File Offset: 0x003F730C
			public Button m_acceptButton
			{
				get
				{
					return this.m_owner.m_acceptButton;
				}
				set
				{
					this.m_owner.m_acceptButton = value;
				}
			}

			// Token: 0x17002DD3 RID: 11731
			// (get) Token: 0x0600EDE2 RID: 60898 RVA: 0x003F911C File Offset: 0x003F731C
			// (set) Token: 0x0600EDE3 RID: 60899 RVA: 0x003F912C File Offset: 0x003F732C
			public Button m_retryButton
			{
				get
				{
					return this.m_owner.m_retryButton;
				}
				set
				{
					this.m_owner.m_retryButton = value;
				}
			}

			// Token: 0x17002DD4 RID: 11732
			// (get) Token: 0x0600EDE4 RID: 60900 RVA: 0x003F913C File Offset: 0x003F733C
			// (set) Token: 0x0600EDE5 RID: 60901 RVA: 0x003F914C File Offset: 0x003F734C
			public Button m_selectButton
			{
				get
				{
					return this.m_owner.m_selectButton;
				}
				set
				{
					this.m_owner.m_selectButton = value;
				}
			}

			// Token: 0x17002DD5 RID: 11733
			// (get) Token: 0x0600EDE6 RID: 60902 RVA: 0x003F915C File Offset: 0x003F735C
			// (set) Token: 0x0600EDE7 RID: 60903 RVA: 0x003F916C File Offset: 0x003F736C
			public GameObject m_jobButtonGroup2GameObject
			{
				get
				{
					return this.m_owner.m_jobButtonGroup2GameObject;
				}
				set
				{
					this.m_owner.m_jobButtonGroup2GameObject = value;
				}
			}

			// Token: 0x17002DD6 RID: 11734
			// (get) Token: 0x0600EDE8 RID: 60904 RVA: 0x003F917C File Offset: 0x003F737C
			// (set) Token: 0x0600EDE9 RID: 60905 RVA: 0x003F918C File Offset: 0x003F738C
			public Button m_confirmButton
			{
				get
				{
					return this.m_owner.m_confirmButton;
				}
				set
				{
					this.m_owner.m_confirmButton = value;
				}
			}

			// Token: 0x17002DD7 RID: 11735
			// (get) Token: 0x0600EDEA RID: 60906 RVA: 0x003F919C File Offset: 0x003F739C
			// (set) Token: 0x0600EDEB RID: 60907 RVA: 0x003F91AC File Offset: 0x003F73AC
			public Button m_retryButton2
			{
				get
				{
					return this.m_owner.m_retryButton2;
				}
				set
				{
					this.m_owner.m_retryButton2 = value;
				}
			}

			// Token: 0x17002DD8 RID: 11736
			// (get) Token: 0x0600EDEC RID: 60908 RVA: 0x003F91BC File Offset: 0x003F73BC
			// (set) Token: 0x0600EDED RID: 60909 RVA: 0x003F91CC File Offset: 0x003F73CC
			public Button m_prevButton
			{
				get
				{
					return this.m_owner.m_prevButton;
				}
				set
				{
					this.m_owner.m_prevButton = value;
				}
			}

			// Token: 0x17002DD9 RID: 11737
			// (get) Token: 0x0600EDEE RID: 60910 RVA: 0x003F91DC File Offset: 0x003F73DC
			// (set) Token: 0x0600EDEF RID: 60911 RVA: 0x003F91EC File Offset: 0x003F73EC
			public Button m_nextButton
			{
				get
				{
					return this.m_owner.m_nextButton;
				}
				set
				{
					this.m_owner.m_nextButton = value;
				}
			}

			// Token: 0x17002DDA RID: 11738
			// (get) Token: 0x0600EDF0 RID: 60912 RVA: 0x003F91FC File Offset: 0x003F73FC
			// (set) Token: 0x0600EDF1 RID: 60913 RVA: 0x003F920C File Offset: 0x003F740C
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x17002DDB RID: 11739
			// (get) Token: 0x0600EDF2 RID: 60914 RVA: 0x003F921C File Offset: 0x003F741C
			// (set) Token: 0x0600EDF3 RID: 60915 RVA: 0x003F922C File Offset: 0x003F742C
			public DialogCharUIController m_dialogCharUIController
			{
				get
				{
					return this.m_owner.m_dialogCharUIController;
				}
				set
				{
					this.m_owner.m_dialogCharUIController = value;
				}
			}

			// Token: 0x17002DDC RID: 11740
			// (get) Token: 0x0600EDF4 RID: 60916 RVA: 0x003F923C File Offset: 0x003F743C
			// (set) Token: 0x0600EDF5 RID: 60917 RVA: 0x003F924C File Offset: 0x003F744C
			public GoddessDialogBoxUIController m_dialogBoxUIController
			{
				get
				{
					return this.m_owner.m_dialogBoxUIController;
				}
				set
				{
					this.m_owner.m_dialogBoxUIController = value;
				}
			}

			// Token: 0x17002DDD RID: 11741
			// (get) Token: 0x0600EDF6 RID: 60918 RVA: 0x003F925C File Offset: 0x003F745C
			// (set) Token: 0x0600EDF7 RID: 60919 RVA: 0x003F926C File Offset: 0x003F746C
			public GoddessDialogChoiceButton[] m_choiceButtons
			{
				get
				{
					return this.m_owner.m_choiceButtons;
				}
				set
				{
					this.m_owner.m_choiceButtons = value;
				}
			}

			// Token: 0x17002DDE RID: 11742
			// (get) Token: 0x0600EDF8 RID: 60920 RVA: 0x003F927C File Offset: 0x003F747C
			// (set) Token: 0x0600EDF9 RID: 60921 RVA: 0x003F928C File Offset: 0x003F748C
			public GoddessDialogJobButton[] m_jobButtons
			{
				get
				{
					return this.m_owner.m_jobButtons;
				}
				set
				{
					this.m_owner.m_jobButtons = value;
				}
			}

			// Token: 0x17002DDF RID: 11743
			// (get) Token: 0x0600EDFA RID: 60922 RVA: 0x003F929C File Offset: 0x003F749C
			// (set) Token: 0x0600EDFB RID: 60923 RVA: 0x003F92AC File Offset: 0x003F74AC
			public ConfigDataGoddessDialogInfo m_dialogInfo
			{
				get
				{
					return this.m_owner.m_dialogInfo;
				}
				set
				{
					this.m_owner.m_dialogInfo = value;
				}
			}

			// Token: 0x17002DE0 RID: 11744
			// (get) Token: 0x0600EDFC RID: 60924 RVA: 0x003F92BC File Offset: 0x003F74BC
			// (set) Token: 0x0600EDFD RID: 60925 RVA: 0x003F92CC File Offset: 0x003F74CC
			public List<string> m_feedbackVoices
			{
				get
				{
					return this.m_owner.m_feedbackVoices;
				}
				set
				{
					this.m_owner.m_feedbackVoices = value;
				}
			}

			// Token: 0x17002DE1 RID: 11745
			// (get) Token: 0x0600EDFE RID: 60926 RVA: 0x003F92DC File Offset: 0x003F74DC
			// (set) Token: 0x0600EDFF RID: 60927 RVA: 0x003F92EC File Offset: 0x003F74EC
			public List<string> m_feedbackTexts
			{
				get
				{
					return this.m_owner.m_feedbackTexts;
				}
				set
				{
					this.m_owner.m_feedbackTexts = value;
				}
			}

			// Token: 0x17002DE2 RID: 11746
			// (get) Token: 0x0600EE00 RID: 60928 RVA: 0x003F92FC File Offset: 0x003F74FC
			// (set) Token: 0x0600EE01 RID: 60929 RVA: 0x003F930C File Offset: 0x003F750C
			public bool m_isClickBackground
			{
				get
				{
					return this.m_owner.m_isClickBackground;
				}
				set
				{
					this.m_owner.m_isClickBackground = value;
				}
			}

			// Token: 0x17002DE3 RID: 11747
			// (get) Token: 0x0600EE02 RID: 60930 RVA: 0x003F931C File Offset: 0x003F751C
			// (set) Token: 0x0600EE03 RID: 60931 RVA: 0x003F932C File Offset: 0x003F752C
			public bool m_isDoingChoose
			{
				get
				{
					return this.m_owner.m_isDoingChoose;
				}
				set
				{
					this.m_owner.m_isDoingChoose = value;
				}
			}

			// Token: 0x0600EE04 RID: 60932 RVA: 0x003F933C File Offset: 0x003F753C
			public void Start()
			{
				this.m_owner.Start();
			}

			// Token: 0x0600EE05 RID: 60933 RVA: 0x003F934C File Offset: 0x003F754C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600EE06 RID: 60934 RVA: 0x003F935C File Offset: 0x003F755C
			public IEnumerator Co_CloseDialog()
			{
				return this.m_owner.Co_CloseDialog();
			}

			// Token: 0x0600EE07 RID: 60935 RVA: 0x003F936C File Offset: 0x003F756C
			public IEnumerator Co_ShowWords(float delay)
			{
				return this.m_owner.Co_ShowWords(delay);
			}

			// Token: 0x0600EE08 RID: 60936 RVA: 0x003F937C File Offset: 0x003F757C
			public void ShowChoice()
			{
				this.m_owner.ShowChoice();
			}

			// Token: 0x0600EE09 RID: 60937 RVA: 0x003F938C File Offset: 0x003F758C
			public IEnumerator Co_DoChoice(int idx)
			{
				return this.m_owner.Co_DoChoice(idx);
			}

			// Token: 0x0600EE0A RID: 60938 RVA: 0x003F939C File Offset: 0x003F759C
			public IEnumerator Co_WaitForSecondsOrClick(float time)
			{
				return this.m_owner.Co_WaitForSecondsOrClick(time);
			}

			// Token: 0x0600EE0B RID: 60939 RVA: 0x003F93AC File Offset: 0x003F75AC
			public IEnumerator Co_WaitForClick()
			{
				return this.m_owner.Co_WaitForClick();
			}

			// Token: 0x0600EE0C RID: 60940 RVA: 0x003F93BC File Offset: 0x003F75BC
			public IEnumerator Co_WaitForAllWordsDisplayed()
			{
				return this.m_owner.Co_WaitForAllWordsDisplayed();
			}

			// Token: 0x0600EE0D RID: 60941 RVA: 0x003F93CC File Offset: 0x003F75CC
			public bool HasChoice()
			{
				return this.m_owner.HasChoice();
			}

			// Token: 0x0600EE0E RID: 60942 RVA: 0x003F93DC File Offset: 0x003F75DC
			public IAudioPlayback PlayVoice(string name)
			{
				return this.m_owner.PlayVoice(name);
			}

			// Token: 0x0600EE0F RID: 60943 RVA: 0x003F93EC File Offset: 0x003F75EC
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x0600EE10 RID: 60944 RVA: 0x003F93FC File Offset: 0x003F75FC
			public void OnAcceptButtonClick()
			{
				this.m_owner.OnAcceptButtonClick();
			}

			// Token: 0x0600EE11 RID: 60945 RVA: 0x003F940C File Offset: 0x003F760C
			public void OnRetryButtonClick()
			{
				this.m_owner.OnRetryButtonClick();
			}

			// Token: 0x0600EE12 RID: 60946 RVA: 0x003F941C File Offset: 0x003F761C
			public void OnSelectButtonClick()
			{
				this.m_owner.OnSelectButtonClick();
			}

			// Token: 0x0600EE13 RID: 60947 RVA: 0x003F942C File Offset: 0x003F762C
			public void OnConfirmButtonClick()
			{
				this.m_owner.OnConfirmButtonClick();
			}

			// Token: 0x0600EE14 RID: 60948 RVA: 0x003F943C File Offset: 0x003F763C
			public void OnRetryButton2Click()
			{
				this.m_owner.OnRetryButton2Click();
			}

			// Token: 0x0600EE15 RID: 60949 RVA: 0x003F944C File Offset: 0x003F764C
			public void OnPrevButtonClick()
			{
				this.m_owner.OnPrevButtonClick();
			}

			// Token: 0x0600EE16 RID: 60950 RVA: 0x003F945C File Offset: 0x003F765C
			public void OnNextButtonClick()
			{
				this.m_owner.OnNextButtonClick();
			}

			// Token: 0x0600EE17 RID: 60951 RVA: 0x003F946C File Offset: 0x003F766C
			public void OnChoiceButtonClick(GoddessDialogChoiceButton b)
			{
				this.m_owner.OnChoiceButtonClick(b);
			}

			// Token: 0x0600EE18 RID: 60952 RVA: 0x003F947C File Offset: 0x003F767C
			public void OnJobButtonClick(GoddessDialogJobButton b)
			{
				this.m_owner.OnJobButtonClick(b);
			}

			// Token: 0x04008E36 RID: 36406
			private GoddessDialogUIController m_owner;
		}
	}
}
