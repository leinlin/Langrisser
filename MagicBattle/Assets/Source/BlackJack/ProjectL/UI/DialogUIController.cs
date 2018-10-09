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
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C1A RID: 3098
	[HotFix]
	public class DialogUIController : UIControllerBase
	{
		// Token: 0x0600DA3E RID: 55870 RVA: 0x003B37F4 File Offset: 0x003B19F4
		private DialogUIController()
		{
		}

		// Token: 0x0600DA3F RID: 55871 RVA: 0x003B3820 File Offset: 0x003B1A20
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
			this.m_skipButton.onClick.AddListener(new UnityAction(this.OnSkipButtonClick));
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_dialogCharUIControllers[0] = GameObjectUtility.AddControllerToGameObject<DialogCharUIController>(this.m_char0GameObject);
			this.m_dialogCharUIControllers[1] = GameObjectUtility.AddControllerToGameObject<DialogCharUIController>(this.m_char1GameObject);
			this.m_dialogCharUIControllers[2] = GameObjectUtility.AddControllerToGameObject<DialogCharUIController>(this.m_char2GameObject);
			this.m_dialogBoxUIController = GameObjectUtility.AddControllerToGameObject<DialogBoxUIController>(this.m_wordsGameObject);
		}

		// Token: 0x0600DA40 RID: 55872 RVA: 0x003B3908 File Offset: 0x003B1B08
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
			this.DestroyBackgroundGraphic();
			this.ClearBackgroundImage();
		}

		// Token: 0x0600DA41 RID: 55873 RVA: 0x003B3974 File Offset: 0x003B1B74
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600DA42 RID: 55874 RVA: 0x003B39D4 File Offset: 0x003B1BD4
		public void ShowDialog(ConfigDataDialogInfo dialogInfo, bool needBGChangeTween)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDialogConfigDataDialogInfoBoolean_hotfix != null)
			{
				this.m_ShowDialogConfigDataDialogInfoBoolean_hotfix.call(new object[]
				{
					this,
					dialogInfo,
					needBGChangeTween
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_ShowDialog(dialogInfo, needBGChangeTween));
		}

		// Token: 0x0600DA43 RID: 55875 RVA: 0x003B3A64 File Offset: 0x003B1C64
		[DebuggerHidden]
		private IEnumerator Co_ShowDialog(ConfigDataDialogInfo dialogInfo, bool needBGChangeTween)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowDialogConfigDataDialogInfoBoolean_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowDialogConfigDataDialogInfoBoolean_hotfix.call(new object[]
				{
					this,
					dialogInfo,
					needBGChangeTween
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_ShowDialog>c__Iterator0 <Co_ShowDialog>c__Iterator = new DialogUIController.<Co_ShowDialog>c__Iterator0();
			<Co_ShowDialog>c__Iterator.dialogInfo = dialogInfo;
			<Co_ShowDialog>c__Iterator.needBGChangeTween = needBGChangeTween;
			<Co_ShowDialog>c__Iterator.$this = this;
			return <Co_ShowDialog>c__Iterator;
		}

		// Token: 0x0600DA44 RID: 55876 RVA: 0x003B3B0C File Offset: 0x003B1D0C
		[DebuggerHidden]
		private IEnumerator Co_CharLeavePlay(ConfigDataDialogInfo dialogInfo, Action onEndAction = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_CharLeavePlayConfigDataDialogInfoAction_hotfix != null)
			{
				return (IEnumerator)this.m_Co_CharLeavePlayConfigDataDialogInfoAction_hotfix.call(new object[]
				{
					this,
					dialogInfo,
					onEndAction
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_CharLeavePlay>c__Iterator1 <Co_CharLeavePlay>c__Iterator = new DialogUIController.<Co_CharLeavePlay>c__Iterator1();
			<Co_CharLeavePlay>c__Iterator.dialogInfo = dialogInfo;
			<Co_CharLeavePlay>c__Iterator.onEndAction = onEndAction;
			<Co_CharLeavePlay>c__Iterator.$this = this;
			return <Co_CharLeavePlay>c__Iterator;
		}

		// Token: 0x0600DA45 RID: 55877 RVA: 0x003B3BB4 File Offset: 0x003B1DB4
		[DebuggerHidden]
		private IEnumerator Co_BGChangeTweenPlay(ConfigDataDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_BGChangeTweenPlayConfigDataDialogInfo_hotfix != null)
			{
				return (IEnumerator)this.m_Co_BGChangeTweenPlayConfigDataDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_BGChangeTweenPlay>c__Iterator2 <Co_BGChangeTweenPlay>c__Iterator = new DialogUIController.<Co_BGChangeTweenPlay>c__Iterator2();
			<Co_BGChangeTweenPlay>c__Iterator.dialogInfo = dialogInfo;
			<Co_BGChangeTweenPlay>c__Iterator.$this = this;
			return <Co_BGChangeTweenPlay>c__Iterator;
		}

		// Token: 0x0600DA46 RID: 55878 RVA: 0x003B3C48 File Offset: 0x003B1E48
		[DebuggerHidden]
		private IEnumerator Co_SetBGChangeLeaveShowUIState(ConfigDataDialogInfo dialogInfo, string state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_SetBGChangeLeaveShowUIStateConfigDataDialogInfoString_hotfix != null)
			{
				return (IEnumerator)this.m_Co_SetBGChangeLeaveShowUIStateConfigDataDialogInfoString_hotfix.call(new object[]
				{
					this,
					dialogInfo,
					state
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_SetBGChangeLeaveShowUIState>c__Iterator3 <Co_SetBGChangeLeaveShowUIState>c__Iterator = new DialogUIController.<Co_SetBGChangeLeaveShowUIState>c__Iterator3();
			<Co_SetBGChangeLeaveShowUIState>c__Iterator.state = state;
			<Co_SetBGChangeLeaveShowUIState>c__Iterator.$this = this;
			return <Co_SetBGChangeLeaveShowUIState>c__Iterator;
		}

		// Token: 0x0600DA47 RID: 55879 RVA: 0x003B3CEC File Offset: 0x003B1EEC
		[DebuggerHidden]
		private IEnumerator Co_SetBGChangeEnterShowUIState(string state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_SetBGChangeEnterShowUIStateString_hotfix != null)
			{
				return (IEnumerator)this.m_Co_SetBGChangeEnterShowUIStateString_hotfix.call(new object[]
				{
					this,
					state
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_SetBGChangeEnterShowUIState>c__Iterator4 <Co_SetBGChangeEnterShowUIState>c__Iterator = new DialogUIController.<Co_SetBGChangeEnterShowUIState>c__Iterator4();
			<Co_SetBGChangeEnterShowUIState>c__Iterator.state = state;
			<Co_SetBGChangeEnterShowUIState>c__Iterator.$this = this;
			return <Co_SetBGChangeEnterShowUIState>c__Iterator;
		}

		// Token: 0x0600DA48 RID: 55880 RVA: 0x003B3D80 File Offset: 0x003B1F80
		[DebuggerHidden]
		private IEnumerator Co_CreateCharEnter(ConfigDataDialogInfo dialogInfo, DialogCharUIController c)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_CreateCharEnterConfigDataDialogInfoDialogCharUIController_hotfix != null)
			{
				return (IEnumerator)this.m_Co_CreateCharEnterConfigDataDialogInfoDialogCharUIController_hotfix.call(new object[]
				{
					this,
					dialogInfo,
					c
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_CreateCharEnter>c__Iterator5 <Co_CreateCharEnter>c__Iterator = new DialogUIController.<Co_CreateCharEnter>c__Iterator5();
			<Co_CreateCharEnter>c__Iterator.dialogInfo = dialogInfo;
			<Co_CreateCharEnter>c__Iterator.c = c;
			return <Co_CreateCharEnter>c__Iterator;
		}

		// Token: 0x0600DA49 RID: 55881 RVA: 0x003B3E24 File Offset: 0x003B2024
		private void PlayBGMInDialog(ConfigDataDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayBGMInDialogConfigDataDialogInfo_hotfix != null)
			{
				this.m_PlayBGMInDialogConfigDataDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (dialogInfo == null || string.IsNullOrEmpty(dialogInfo.BGM))
			{
				return;
			}
			AudioUtility.PlaySound(dialogInfo.BGM);
		}

		// Token: 0x0600DA4A RID: 55882 RVA: 0x003B3EB8 File Offset: 0x003B20B8
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

		// Token: 0x0600DA4B RID: 55883 RVA: 0x003B3F28 File Offset: 0x003B2128
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
			DialogUIController.<Co_CloseDialog>c__Iterator6 <Co_CloseDialog>c__Iterator = new DialogUIController.<Co_CloseDialog>c__Iterator6();
			<Co_CloseDialog>c__Iterator.$this = this;
			return <Co_CloseDialog>c__Iterator;
		}

		// Token: 0x0600DA4C RID: 55884 RVA: 0x003B3FA4 File Offset: 0x003B21A4
		private void ShowDialogBox()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDialogBox_hotfix != null)
			{
				this.m_ShowDialogBox_hotfix.call(new object[]
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
			this.m_dialogBoxUIController.Show(true);
			this.m_dialogBoxUIController.SetStyle(this.m_dialogInfo.Position, this.m_dialogInfo.FrameType);
			this.m_dialogBoxUIController.SetWords(this.m_dialogInfo.Words);
			this.m_dialogBoxUIController.SetName(this.m_dialogInfo.CharName);
			this.m_dialogBoxUIController.Open(null);
			IAudioPlayback audioPlayback = this.PlayVoice(this.m_dialogInfo.Voice);
			this.m_currentAudio = audioPlayback;
			float num;
			if (audioPlayback != null)
			{
				num = audioPlayback.Seconds;
				this.m_dialogBoxUIController.SetVoicePlayTime(num);
			}
			else
			{
				num = this.m_dialogBoxUIController.GetWordsDisplayTime();
				this.m_dialogBoxUIController.SetVoicePlayTime(0f);
			}
			num = Mathf.Max(num, 1f);
			DialogCharUIController dialogCharUIController = this.m_dialogCharUIControllers[this.m_dialogInfo.Position];
			dialogCharUIController.StartFacialAnimation(num);
		}

		// Token: 0x0600DA4D RID: 55885 RVA: 0x003B40F4 File Offset: 0x003B22F4
		private void CreateBackgroundGraphic(string assetName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateBackgroundGraphicString_hotfix != null)
			{
				this.m_CreateBackgroundGraphicString_hotfix.call(new object[]
				{
					this,
					assetName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyBackgroundGraphic();
			if (string.IsNullOrEmpty(assetName))
			{
				return;
			}
			this.m_backgroundGraphic = new UISpineGraphic();
			this.m_backgroundGraphic.Create(assetName);
			this.m_backgroundGraphic.SetParent(this.m_backgroundGraphicGameObject);
			this.m_backgroundGraphic.SetRectTransformSize(new Vector2(2000f, 1000f));
			this.m_backgroundGraphic.ForceUpdate();
			this.m_backgroundAssetName = assetName;
		}

		// Token: 0x0600DA4E RID: 55886 RVA: 0x003B41CC File Offset: 0x003B23CC
		private void DestroyBackgroundGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyBackgroundGraphic_hotfix != null)
			{
				this.m_DestroyBackgroundGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_backgroundGraphic != null)
			{
				this.m_backgroundGraphic.Destroy();
				this.m_backgroundGraphic = null;
			}
			this.m_backgroundAssetName = string.Empty;
		}

		// Token: 0x0600DA4F RID: 55887 RVA: 0x003B4254 File Offset: 0x003B2454
		[DebuggerHidden]
		private IEnumerator Co_CreateBeforeEnterEffectGroup()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_CreateBeforeEnterEffectGroup_hotfix != null)
			{
				return (IEnumerator)this.m_Co_CreateBeforeEnterEffectGroup_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_CreateBeforeEnterEffectGroup>c__Iterator7 <Co_CreateBeforeEnterEffectGroup>c__Iterator = new DialogUIController.<Co_CreateBeforeEnterEffectGroup>c__Iterator7();
			<Co_CreateBeforeEnterEffectGroup>c__Iterator.$this = this;
			return <Co_CreateBeforeEnterEffectGroup>c__Iterator;
		}

		// Token: 0x0600DA50 RID: 55888 RVA: 0x003B42D0 File Offset: 0x003B24D0
		[DebuggerHidden]
		private IEnumerator Co_CreateBeforeTalkEffectGroup()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_CreateBeforeTalkEffectGroup_hotfix != null)
			{
				return (IEnumerator)this.m_Co_CreateBeforeTalkEffectGroup_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_CreateBeforeTalkEffectGroup>c__Iterator8 <Co_CreateBeforeTalkEffectGroup>c__Iterator = new DialogUIController.<Co_CreateBeforeTalkEffectGroup>c__Iterator8();
			<Co_CreateBeforeTalkEffectGroup>c__Iterator.$this = this;
			return <Co_CreateBeforeTalkEffectGroup>c__Iterator;
		}

		// Token: 0x0600DA51 RID: 55889 RVA: 0x003B434C File Offset: 0x003B254C
		[DebuggerHidden]
		private IEnumerator Co_AfterTalkEffectAndLeave(ConfigDataDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_AfterTalkEffectAndLeaveConfigDataDialogInfo_hotfix != null)
			{
				return (IEnumerator)this.m_Co_AfterTalkEffectAndLeaveConfigDataDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_AfterTalkEffectAndLeave>c__Iterator9 <Co_AfterTalkEffectAndLeave>c__Iterator = new DialogUIController.<Co_AfterTalkEffectAndLeave>c__Iterator9();
			<Co_AfterTalkEffectAndLeave>c__Iterator.dialogInfo = dialogInfo;
			<Co_AfterTalkEffectAndLeave>c__Iterator.$this = this;
			return <Co_AfterTalkEffectAndLeave>c__Iterator;
		}

		// Token: 0x0600DA52 RID: 55890 RVA: 0x003B43E0 File Offset: 0x003B25E0
		[DebuggerHidden]
		private IEnumerator Co_CreateAfterTalkEffectGroup(ConfigDataDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_CreateAfterTalkEffectGroupConfigDataDialogInfo_hotfix != null)
			{
				return (IEnumerator)this.m_Co_CreateAfterTalkEffectGroupConfigDataDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_CreateAfterTalkEffectGroup>c__IteratorA <Co_CreateAfterTalkEffectGroup>c__IteratorA = new DialogUIController.<Co_CreateAfterTalkEffectGroup>c__IteratorA();
			<Co_CreateAfterTalkEffectGroup>c__IteratorA.dialogInfo = dialogInfo;
			<Co_CreateAfterTalkEffectGroup>c__IteratorA.$this = this;
			return <Co_CreateAfterTalkEffectGroup>c__IteratorA;
		}

		// Token: 0x0600DA53 RID: 55891 RVA: 0x003B4474 File Offset: 0x003B2674
		private void CreateEffectGroupLeaveTogether(ConfigDataDialogInfo dialogInfo, List<int> effectGroup, GameObject parentGameObject, Action onEndAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateEffectGroupLeaveTogetherConfigDataDialogInfoList`1GameObjectAction_hotfix != null)
			{
				this.m_CreateEffectGroupLeaveTogetherConfigDataDialogInfoList`1GameObjectAction_hotfix.call(new object[]
				{
					this,
					dialogInfo2,
					effectGroup,
					parentGameObject2,
					onEndAction2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEndAction = onEndAction2;
			GameObject parentGameObject = parentGameObject2;
			ConfigDataDialogInfo dialogInfo = dialogInfo2;
			DialogUIController $this = this;
			if (effectGroup.Count == 0 || effectGroup == null)
			{
				onEndAction();
				return;
			}
			if (effectGroup[0] == -1)
			{
				GameObjectUtility.DestroyChildren(parentGameObject);
				onEndAction();
				return;
			}
			List<int> list = new List<int>();
			List<int> togetherLeaveEffectGroup = new List<int>();
			if (effectGroup.Count == 1)
			{
				togetherLeaveEffectGroup.Add(effectGroup[0]);
				bool effectComplete = false;
				bool leaveComplete = false;
				this.CreateEffectGroup(togetherLeaveEffectGroup, parentGameObject, delegate
				{
					effectComplete = true;
					if (effectComplete && leaveComplete)
					{
						onEndAction();
					}
				});
				base.StartCoroutine(this.Co_CharLeavePlay(dialogInfo, delegate
				{
					leaveComplete = true;
					if (effectComplete && leaveComplete)
					{
						onEndAction();
					}
				}));
			}
			else if (effectGroup.Count > 1)
			{
				togetherLeaveEffectGroup.Add(effectGroup[effectGroup.Count - 1]);
				for (int i = 0; i < effectGroup.Count - 1; i++)
				{
					list.Add(effectGroup[i]);
				}
				this.CreateEffectGroup(list, parentGameObject, delegate
				{
					bool effectComplete = false;
					bool leaveComplete = false;
					$this.CreateEffectGroup(togetherLeaveEffectGroup, parentGameObject, delegate
					{
						effectComplete = true;
						if (effectComplete && leaveComplete)
						{
							onEndAction();
						}
					});
					$this.StartCoroutine($this.Co_CharLeavePlay(dialogInfo, delegate
					{
						leaveComplete = true;
						if (effectComplete && leaveComplete)
						{
							onEndAction();
						}
					}));
				});
			}
		}

		// Token: 0x0600DA54 RID: 55892 RVA: 0x003B4668 File Offset: 0x003B2868
		private void CreateEffectGroup(List<int> effectGroup, GameObject parentGameObject, Action onEndAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateEffectGroupList`1GameObjectAction_hotfix != null)
			{
				this.m_CreateEffectGroupList`1GameObjectAction_hotfix.call(new object[]
				{
					this,
					effectGroup,
					parentGameObject,
					onEndAction
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (effectGroup == null || effectGroup.Count == 0)
			{
				onEndAction();
				return;
			}
			List<int> list = new List<int>();
			foreach (int item in effectGroup)
			{
				list.Add(item);
			}
			this.PlayEffectGroup(list, parentGameObject, onEndAction);
		}

		// Token: 0x0600DA55 RID: 55893 RVA: 0x003B476C File Offset: 0x003B296C
		private void PlayEffectGroup(List<int> effectGroup, GameObject parentGameObject, Action onEndAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayEffectGroupList`1GameObjectAction_hotfix != null)
			{
				this.m_PlayEffectGroupList`1GameObjectAction_hotfix.call(new object[]
				{
					this,
					effectGroup2,
					parentGameObject2,
					onEndAction2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> effectGroup = effectGroup2;
			Action onEndAction = onEndAction2;
			GameObject parentGameObject = parentGameObject2;
			DialogUIController $this = this;
			if (effectGroup == null || effectGroup.Count == 0)
			{
				onEndAction();
				return;
			}
			if (effectGroup[0] == -1)
			{
				GameObjectUtility.DestroyChildren(parentGameObject);
				onEndAction();
				return;
			}
			ConfigDataPrefabStateInfo configDataPrefabStateInfo = this.m_configDataLoader.GetConfigDataPrefabStateInfo(effectGroup[0]);
			this.CreateEffect(configDataPrefabStateInfo, parentGameObject, delegate
			{
				if (effectGroup != null && effectGroup.Count > 0)
				{
					effectGroup.RemoveAt(0);
					if (effectGroup.Count == 0)
					{
						onEndAction();
					}
					else
					{
						$this.PlayEffectGroup(effectGroup, parentGameObject, onEndAction);
					}
				}
			});
		}

		// Token: 0x0600DA56 RID: 55894 RVA: 0x003B48A0 File Offset: 0x003B2AA0
		private void CreateEffect(ConfigDataPrefabStateInfo prefabStateConfig, GameObject parentGameObject, Action onEndAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateEffectConfigDataPrefabStateInfoGameObjectAction_hotfix != null)
			{
				this.m_CreateEffectConfigDataPrefabStateInfoGameObjectAction_hotfix.call(new object[]
				{
					this,
					prefabStateConfig,
					parentGameObject,
					onEndAction
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (prefabStateConfig == null)
			{
				global::Debug.LogError("Don't have this Prefab State!");
				return;
			}
			if (parentGameObject == this.m_effectGroup1)
			{
				this.CreateEffectInGroup(ref this.m_group1PrefabName, prefabStateConfig, parentGameObject, onEndAction);
			}
			else if (parentGameObject == this.m_effectGroup2)
			{
				this.CreateEffectInGroup(ref this.m_group2PrefabName, prefabStateConfig, parentGameObject, onEndAction);
			}
			else if (parentGameObject == this.m_effectGroup3)
			{
				this.CreateEffectInGroup(ref this.m_group3PrefabName, prefabStateConfig, parentGameObject, onEndAction);
			}
			else
			{
				global::Debug.LogError("Don't have this Parent!");
			}
		}

		// Token: 0x0600DA57 RID: 55895 RVA: 0x003B49BC File Offset: 0x003B2BBC
		private void CreateEffectInGroup(ref string prefabName, ConfigDataPrefabStateInfo prefabStateConfig, GameObject parentGameObject, Action onEndAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateEffectInGroupString_ConfigDataPrefabStateInfoGameObjectAction_hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_DialogUIController_CreateEffectInGroup_String_ConfigDataPrefabStateInfo_GameObject_Action(this, this.m_CreateEffectInGroupString_ConfigDataPrefabStateInfoGameObjectAction_hotfix, ref prefabName, prefabStateConfig, parentGameObject, onEndAction);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(prefabName) || prefabStateConfig.Prefab != prefabName)
			{
				GameObjectUtility.DestroyChildren(parentGameObject);
				GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(prefabStateConfig.Prefab);
				if (asset != null)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(asset);
					CommonUIStateController component = gameObject.GetComponent<CommonUIStateController>();
					gameObject.transform.SetParent(parentGameObject.transform, false);
					gameObject.gameObject.SetActive(false);
					gameObject.gameObject.SetActive(true);
					if (prefabStateConfig.IsLoop)
					{
						UIUtility.SetUIStateOpen(component, prefabStateConfig.State, null, false, true);
						onEndAction();
					}
					else
					{
						component.SetActionForUIStateFinshed(prefabStateConfig.State, onEndAction);
						component.SetToUIState(prefabStateConfig.State, false, true);
					}
					prefabName = prefabStateConfig.Prefab;
				}
				else
				{
					global::Debug.LogError("This Prefab has wrong path!");
				}
			}
			else
			{
				CommonUIStateController componentInChildren = parentGameObject.transform.GetComponentInChildren<CommonUIStateController>();
				if (componentInChildren != null)
				{
					if (prefabStateConfig.IsLoop)
					{
						UIUtility.SetUIStateOpen(componentInChildren, prefabStateConfig.State, null, false, true);
						onEndAction();
					}
					else
					{
						componentInChildren.SetActionForUIStateFinshed(prefabStateConfig.State, onEndAction);
						componentInChildren.SetToUIState(prefabStateConfig.State, false, true);
					}
					prefabName = prefabStateConfig.Prefab;
				}
			}
		}

		// Token: 0x0600DA58 RID: 55896 RVA: 0x003B4B50 File Offset: 0x003B2D50
		private void CreateInsertEffect(int prefabStateID, Action onEndAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateInsertEffectInt32Action_hotfix != null)
			{
				this.m_CreateInsertEffectInt32Action_hotfix.call(new object[]
				{
					this,
					prefabStateID,
					onEndAction
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (prefabStateID == 0)
			{
				onEndAction();
				return;
			}
			if (prefabStateID == -1)
			{
				GameObjectUtility.DestroyChildren(this.m_insertEffect);
				onEndAction();
				return;
			}
			ConfigDataPrefabStateInfo configDataPrefabStateInfo = this.m_configDataLoader.GetConfigDataPrefabStateInfo(prefabStateID);
			GameObjectUtility.DestroyChildren(this.m_insertEffect);
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(configDataPrefabStateInfo.Prefab);
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(asset);
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			gameObject.transform.SetParent(this.m_insertEffect.transform, false);
			UIUtility.SetUIStateOpen(component, configDataPrefabStateInfo.State, onEndAction, false, true);
		}

		// Token: 0x0600DA59 RID: 55897 RVA: 0x003B4C58 File Offset: 0x003B2E58
		private void SetBackgroundImage(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBackgroundImageString_hotfix != null)
			{
				this.m_SetBackgroundImageString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Sprite sprite = AssetUtility.Instance.GetSprite(name);
			this.m_backgroundImage.sprite = sprite;
			this.m_backgroundImage.gameObject.SetActive(sprite != null);
		}

		// Token: 0x0600DA5A RID: 55898 RVA: 0x003B4CF8 File Offset: 0x003B2EF8
		private void ClearBackgroundImage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearBackgroundImage_hotfix != null)
			{
				this.m_ClearBackgroundImage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_backgroundImage.sprite = null;
			this.m_backgroundImage.gameObject.SetActive(false);
		}

		// Token: 0x0600DA5B RID: 55899 RVA: 0x003B4D78 File Offset: 0x003B2F78
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

		// Token: 0x0600DA5C RID: 55900 RVA: 0x003B4DFC File Offset: 0x003B2FFC
		private void StopVoice()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopVoice_hotfix != null)
			{
				this.m_StopVoice_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (DialogCharUIController dialogCharUIController in this.m_dialogCharUIControllers)
			{
				if (dialogCharUIController != null)
				{
					dialogCharUIController.StopMouthAnimation();
				}
			}
		}

		// Token: 0x0600DA5D RID: 55901 RVA: 0x003B4E90 File Offset: 0x003B3090
		[DebuggerHidden]
		private IEnumerator Co_NextDialog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_NextDialog_hotfix != null)
			{
				return (IEnumerator)this.m_Co_NextDialog_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DialogUIController.<Co_NextDialog>c__IteratorB <Co_NextDialog>c__IteratorB = new DialogUIController.<Co_NextDialog>c__IteratorB();
			<Co_NextDialog>c__IteratorB.$this = this;
			return <Co_NextDialog>c__IteratorB;
		}

		// Token: 0x0600DA5E RID: 55902 RVA: 0x003B4F0C File Offset: 0x003B310C
		private void OnSkipButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkipButtonClick_hotfix != null)
			{
				this.m_OnSkipButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSkip != null)
			{
				this.EventOnSkip();
			}
		}

		// Token: 0x0600DA5F RID: 55903 RVA: 0x003B4F84 File Offset: 0x003B3184
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
			if (this.m_dialogBoxUIController.IsOpened())
			{
				base.StartCoroutine(this.Co_NextDialog());
			}
		}

		// Token: 0x140002B5 RID: 693
		// (add) Token: 0x0600DA60 RID: 55904 RVA: 0x003B5004 File Offset: 0x003B3204
		// (remove) Token: 0x0600DA61 RID: 55905 RVA: 0x003B50A0 File Offset: 0x003B32A0
		public event Action EventOnSkip
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkipAction_hotfix != null)
				{
					this.m_add_EventOnSkipAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkip;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkip, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkipAction_hotfix != null)
				{
					this.m_remove_EventOnSkipAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkip;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkip, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002B6 RID: 694
		// (add) Token: 0x0600DA62 RID: 55906 RVA: 0x003B513C File Offset: 0x003B333C
		// (remove) Token: 0x0600DA63 RID: 55907 RVA: 0x003B51D8 File Offset: 0x003B33D8
		public event Action<bool> EventOnNext
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNextAction`1_hotfix != null)
				{
					this.m_add_EventOnNextAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnNext;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnNext, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNextAction`1_hotfix != null)
				{
					this.m_remove_EventOnNextAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnNext;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnNext, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002B7 RID: 695
		// (add) Token: 0x0600DA64 RID: 55908 RVA: 0x003B5274 File Offset: 0x003B3474
		// (remove) Token: 0x0600DA65 RID: 55909 RVA: 0x003B5310 File Offset: 0x003B3510
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

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0600DA66 RID: 55910 RVA: 0x003B53AC File Offset: 0x003B35AC
		// (set) Token: 0x0600DA67 RID: 55911 RVA: 0x003B53CC File Offset: 0x003B35CC
		[DoNotToLua]
		public new DialogUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DialogUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DA68 RID: 55912 RVA: 0x003B53D8 File Offset: 0x003B35D8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600DA69 RID: 55913 RVA: 0x003B53E4 File Offset: 0x003B35E4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600DA6A RID: 55914 RVA: 0x003B53EC File Offset: 0x003B35EC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600DA6B RID: 55915 RVA: 0x003B53F4 File Offset: 0x003B35F4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600DA6C RID: 55916 RVA: 0x003B5408 File Offset: 0x003B3608
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DA6D RID: 55917 RVA: 0x003B5410 File Offset: 0x003B3610
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600DA6E RID: 55918 RVA: 0x003B541C File Offset: 0x003B361C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600DA6F RID: 55919 RVA: 0x003B5428 File Offset: 0x003B3628
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600DA70 RID: 55920 RVA: 0x003B5434 File Offset: 0x003B3634
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600DA71 RID: 55921 RVA: 0x003B5440 File Offset: 0x003B3640
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600DA72 RID: 55922 RVA: 0x003B544C File Offset: 0x003B364C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600DA73 RID: 55923 RVA: 0x003B5458 File Offset: 0x003B3658
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600DA74 RID: 55924 RVA: 0x003B5464 File Offset: 0x003B3664
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600DA75 RID: 55925 RVA: 0x003B5470 File Offset: 0x003B3670
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600DA76 RID: 55926 RVA: 0x003B547C File Offset: 0x003B367C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600DA77 RID: 55927 RVA: 0x003B5484 File Offset: 0x003B3684
		private void __callDele_EventOnSkip()
		{
			Action eventOnSkip = this.EventOnSkip;
			if (eventOnSkip != null)
			{
				eventOnSkip();
			}
		}

		// Token: 0x0600DA78 RID: 55928 RVA: 0x003B54A4 File Offset: 0x003B36A4
		private void __clearDele_EventOnSkip()
		{
			this.EventOnSkip = null;
		}

		// Token: 0x0600DA79 RID: 55929 RVA: 0x003B54B0 File Offset: 0x003B36B0
		private void __callDele_EventOnNext(bool obj)
		{
			Action<bool> eventOnNext = this.EventOnNext;
			if (eventOnNext != null)
			{
				eventOnNext(obj);
			}
		}

		// Token: 0x0600DA7A RID: 55930 RVA: 0x003B54D4 File Offset: 0x003B36D4
		private void __clearDele_EventOnNext(bool obj)
		{
			this.EventOnNext = null;
		}

		// Token: 0x0600DA7B RID: 55931 RVA: 0x003B54E0 File Offset: 0x003B36E0
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600DA7C RID: 55932 RVA: 0x003B5500 File Offset: 0x003B3700
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600DA7D RID: 55933 RVA: 0x003B550C File Offset: 0x003B370C
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
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_ShowDialogConfigDataDialogInfoBoolean_hotfix = (luaObj.RawGet("ShowDialog") as LuaFunction);
					this.m_Co_ShowDialogConfigDataDialogInfoBoolean_hotfix = (luaObj.RawGet("Co_ShowDialog") as LuaFunction);
					this.m_Co_CharLeavePlayConfigDataDialogInfoAction_hotfix = (luaObj.RawGet("Co_CharLeavePlay") as LuaFunction);
					this.m_Co_BGChangeTweenPlayConfigDataDialogInfo_hotfix = (luaObj.RawGet("Co_BGChangeTweenPlay") as LuaFunction);
					this.m_Co_SetBGChangeLeaveShowUIStateConfigDataDialogInfoString_hotfix = (luaObj.RawGet("Co_SetBGChangeLeaveShowUIState") as LuaFunction);
					this.m_Co_SetBGChangeEnterShowUIStateString_hotfix = (luaObj.RawGet("Co_SetBGChangeEnterShowUIState") as LuaFunction);
					this.m_Co_CreateCharEnterConfigDataDialogInfoDialogCharUIController_hotfix = (luaObj.RawGet("Co_CreateCharEnter") as LuaFunction);
					this.m_PlayBGMInDialogConfigDataDialogInfo_hotfix = (luaObj.RawGet("PlayBGMInDialog") as LuaFunction);
					this.m_CloseDialog_hotfix = (luaObj.RawGet("CloseDialog") as LuaFunction);
					this.m_Co_CloseDialog_hotfix = (luaObj.RawGet("Co_CloseDialog") as LuaFunction);
					this.m_ShowDialogBox_hotfix = (luaObj.RawGet("ShowDialogBox") as LuaFunction);
					this.m_CreateBackgroundGraphicString_hotfix = (luaObj.RawGet("CreateBackgroundGraphic") as LuaFunction);
					this.m_DestroyBackgroundGraphic_hotfix = (luaObj.RawGet("DestroyBackgroundGraphic") as LuaFunction);
					this.m_Co_CreateBeforeEnterEffectGroup_hotfix = (luaObj.RawGet("Co_CreateBeforeEnterEffectGroup") as LuaFunction);
					this.m_Co_CreateBeforeTalkEffectGroup_hotfix = (luaObj.RawGet("Co_CreateBeforeTalkEffectGroup") as LuaFunction);
					this.m_Co_AfterTalkEffectAndLeaveConfigDataDialogInfo_hotfix = (luaObj.RawGet("Co_AfterTalkEffectAndLeave") as LuaFunction);
					this.m_Co_CreateAfterTalkEffectGroupConfigDataDialogInfo_hotfix = (luaObj.RawGet("Co_CreateAfterTalkEffectGroup") as LuaFunction);
					this.m_CreateEffectGroupLeaveTogetherConfigDataDialogInfoList`1GameObjectAction_hotfix = (luaObj.RawGet("CreateEffectGroupLeaveTogether") as LuaFunction);
					this.m_CreateEffectGroupList`1GameObjectAction_hotfix = (luaObj.RawGet("CreateEffectGroup") as LuaFunction);
					this.m_PlayEffectGroupList`1GameObjectAction_hotfix = (luaObj.RawGet("PlayEffectGroup") as LuaFunction);
					this.m_CreateEffectConfigDataPrefabStateInfoGameObjectAction_hotfix = (luaObj.RawGet("CreateEffect") as LuaFunction);
					this.m_CreateEffectInGroupString_ConfigDataPrefabStateInfoGameObjectAction_hotfix = (luaObj.RawGet("CreateEffectInGroup") as LuaFunction);
					this.m_CreateInsertEffectInt32Action_hotfix = (luaObj.RawGet("CreateInsertEffect") as LuaFunction);
					this.m_SetBackgroundImageString_hotfix = (luaObj.RawGet("SetBackgroundImage") as LuaFunction);
					this.m_ClearBackgroundImage_hotfix = (luaObj.RawGet("ClearBackgroundImage") as LuaFunction);
					this.m_PlayVoiceString_hotfix = (luaObj.RawGet("PlayVoice") as LuaFunction);
					this.m_StopVoice_hotfix = (luaObj.RawGet("StopVoice") as LuaFunction);
					this.m_Co_NextDialog_hotfix = (luaObj.RawGet("Co_NextDialog") as LuaFunction);
					this.m_OnSkipButtonClick_hotfix = (luaObj.RawGet("OnSkipButtonClick") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnSkipAction_hotfix = (luaObj.RawGet("add_EventOnSkip") as LuaFunction);
					this.m_remove_EventOnSkipAction_hotfix = (luaObj.RawGet("remove_EventOnSkip") as LuaFunction);
					this.m_add_EventOnNextAction`1_hotfix = (luaObj.RawGet("add_EventOnNext") as LuaFunction);
					this.m_remove_EventOnNextAction`1_hotfix = (luaObj.RawGet("remove_EventOnNext") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DA7E RID: 55934 RVA: 0x003B5990 File Offset: 0x003B3B90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DialogUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040085A4 RID: 34212
		[AutoBind("./SkipButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skipButton;

		// Token: 0x040085A5 RID: 34213
		[AutoBind("./Background/Mask", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_backgroundUIStateController;

		// Token: 0x040085A6 RID: 34214
		[AutoBind("./Background/Mask/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_backgroundGraphicGameObject;

		// Token: 0x040085A7 RID: 34215
		[AutoBind("./Background/Mask/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_backgroundImage;

		// Token: 0x040085A8 RID: 34216
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x040085A9 RID: 34217
		[AutoBind("./PlaceNamePanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_placeGameObject;

		// Token: 0x040085AA RID: 34218
		[AutoBind("./PlaceNamePanel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_placeText;

		// Token: 0x040085AB RID: 34219
		[AutoBind("./WordPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_wordsGameObject;

		// Token: 0x040085AC RID: 34220
		[AutoBind("./Char/0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char0GameObject;

		// Token: 0x040085AD RID: 34221
		[AutoBind("./Char/1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char1GameObject;

		// Token: 0x040085AE RID: 34222
		[AutoBind("./Char/2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char2GameObject;

		// Token: 0x040085AF RID: 34223
		[AutoBind("./AllEffectGroup/EffectGroup1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_effectGroup1;

		// Token: 0x040085B0 RID: 34224
		[AutoBind("./AllEffectGroup/EffectGroup2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_effectGroup2;

		// Token: 0x040085B1 RID: 34225
		[AutoBind("./AllEffectGroup/EffectGroup3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_effectGroup3;

		// Token: 0x040085B2 RID: 34226
		[AutoBind("./InsertEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_insertEffect;

		// Token: 0x040085B3 RID: 34227
		[AutoBind("./ChangeBGTween", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_changeBGTweenUIStateCtrl;

		// Token: 0x040085B4 RID: 34228
		private DialogCharUIController[] m_dialogCharUIControllers = new DialogCharUIController[3];

		// Token: 0x040085B5 RID: 34229
		private DialogBoxUIController m_dialogBoxUIController;

		// Token: 0x040085B6 RID: 34230
		private UISpineGraphic m_backgroundGraphic;

		// Token: 0x040085B7 RID: 34231
		private string m_group1PrefabName;

		// Token: 0x040085B8 RID: 34232
		private string m_group2PrefabName;

		// Token: 0x040085B9 RID: 34233
		private string m_group3PrefabName;

		// Token: 0x040085BA RID: 34234
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x040085BB RID: 34235
		private IAudioPlayback m_currentAudio;

		// Token: 0x040085BC RID: 34236
		private ConfigDataDialogInfo m_dialogInfo;

		// Token: 0x040085BD RID: 34237
		private string m_backgroundAssetName;

		// Token: 0x040085BE RID: 34238
		private bool m_needBGChangeTween;

		// Token: 0x040085BF RID: 34239
		[DoNotToLua]
		private DialogUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040085C0 RID: 34240
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040085C1 RID: 34241
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040085C2 RID: 34242
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040085C3 RID: 34243
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x040085C4 RID: 34244
		private LuaFunction m_Update_hotfix;

		// Token: 0x040085C5 RID: 34245
		private LuaFunction m_ShowDialogConfigDataDialogInfoBoolean_hotfix;

		// Token: 0x040085C6 RID: 34246
		private LuaFunction m_Co_ShowDialogConfigDataDialogInfoBoolean_hotfix;

		// Token: 0x040085C7 RID: 34247
		private LuaFunction m_Co_CharLeavePlayConfigDataDialogInfoAction_hotfix;

		// Token: 0x040085C8 RID: 34248
		private LuaFunction m_Co_BGChangeTweenPlayConfigDataDialogInfo_hotfix;

		// Token: 0x040085C9 RID: 34249
		private LuaFunction m_Co_SetBGChangeLeaveShowUIStateConfigDataDialogInfoString_hotfix;

		// Token: 0x040085CA RID: 34250
		private LuaFunction m_Co_SetBGChangeEnterShowUIStateString_hotfix;

		// Token: 0x040085CB RID: 34251
		private LuaFunction m_Co_CreateCharEnterConfigDataDialogInfoDialogCharUIController_hotfix;

		// Token: 0x040085CC RID: 34252
		private LuaFunction m_PlayBGMInDialogConfigDataDialogInfo_hotfix;

		// Token: 0x040085CD RID: 34253
		private LuaFunction m_CloseDialog_hotfix;

		// Token: 0x040085CE RID: 34254
		private LuaFunction m_Co_CloseDialog_hotfix;

		// Token: 0x040085CF RID: 34255
		private LuaFunction m_ShowDialogBox_hotfix;

		// Token: 0x040085D0 RID: 34256
		private LuaFunction m_CreateBackgroundGraphicString_hotfix;

		// Token: 0x040085D1 RID: 34257
		private LuaFunction m_DestroyBackgroundGraphic_hotfix;

		// Token: 0x040085D2 RID: 34258
		private LuaFunction m_Co_CreateBeforeEnterEffectGroup_hotfix;

		// Token: 0x040085D3 RID: 34259
		private LuaFunction m_Co_CreateBeforeTalkEffectGroup_hotfix;

		// Token: 0x040085D4 RID: 34260
		private LuaFunction m_Co_AfterTalkEffectAndLeaveConfigDataDialogInfo_hotfix;

		// Token: 0x040085D5 RID: 34261
		private LuaFunction m_Co_CreateAfterTalkEffectGroupConfigDataDialogInfo_hotfix;

		// Token: 0x040085D6 RID: 34262
		private LuaFunction m_CreateEffectGroupLeaveTogetherConfigDataDialogInfoList;

		// Token: 0x040085D7 RID: 34263
		private LuaFunction m_CreateEffectGroupList;

		// Token: 0x040085D8 RID: 34264
		private LuaFunction m_PlayEffectGroupList;

		// Token: 0x040085D9 RID: 34265
		private LuaFunction m_CreateEffectConfigDataPrefabStateInfoGameObjectAction_hotfix;

		// Token: 0x040085DA RID: 34266
		private LuaFunction m_CreateEffectInGroupString_ConfigDataPrefabStateInfoGameObjectAction_hotfix;

		// Token: 0x040085DB RID: 34267
		private LuaFunction m_CreateInsertEffectInt32Action_hotfix;

		// Token: 0x040085DC RID: 34268
		private LuaFunction m_SetBackgroundImageString_hotfix;

		// Token: 0x040085DD RID: 34269
		private LuaFunction m_ClearBackgroundImage_hotfix;

		// Token: 0x040085DE RID: 34270
		private LuaFunction m_PlayVoiceString_hotfix;

		// Token: 0x040085DF RID: 34271
		private LuaFunction m_StopVoice_hotfix;

		// Token: 0x040085E0 RID: 34272
		private LuaFunction m_Co_NextDialog_hotfix;

		// Token: 0x040085E1 RID: 34273
		private LuaFunction m_OnSkipButtonClick_hotfix;

		// Token: 0x040085E2 RID: 34274
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x040085E3 RID: 34275
		private LuaFunction m_add_EventOnSkipAction_hotfix;

		// Token: 0x040085E4 RID: 34276
		private LuaFunction m_remove_EventOnSkipAction_hotfix;

		// Token: 0x040085E5 RID: 34277
		private LuaFunction m_add_EventOnNextAction;

		// Token: 0x040085E6 RID: 34278
		private LuaFunction m_remove_EventOnNextAction;

		// Token: 0x040085E7 RID: 34279
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040085E8 RID: 34280
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000C1B RID: 3099
		public new class LuaExportHelper
		{
			// Token: 0x0600DA7F RID: 55935 RVA: 0x003B59F8 File Offset: 0x003B3BF8
			public LuaExportHelper(DialogUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DA80 RID: 55936 RVA: 0x003B5A08 File Offset: 0x003B3C08
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600DA81 RID: 55937 RVA: 0x003B5A18 File Offset: 0x003B3C18
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600DA82 RID: 55938 RVA: 0x003B5A28 File Offset: 0x003B3C28
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600DA83 RID: 55939 RVA: 0x003B5A38 File Offset: 0x003B3C38
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DA84 RID: 55940 RVA: 0x003B5A50 File Offset: 0x003B3C50
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DA85 RID: 55941 RVA: 0x003B5A60 File Offset: 0x003B3C60
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DA86 RID: 55942 RVA: 0x003B5A70 File Offset: 0x003B3C70
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DA87 RID: 55943 RVA: 0x003B5A80 File Offset: 0x003B3C80
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DA88 RID: 55944 RVA: 0x003B5A90 File Offset: 0x003B3C90
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DA89 RID: 55945 RVA: 0x003B5AA0 File Offset: 0x003B3CA0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DA8A RID: 55946 RVA: 0x003B5AB0 File Offset: 0x003B3CB0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DA8B RID: 55947 RVA: 0x003B5AC0 File Offset: 0x003B3CC0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DA8C RID: 55948 RVA: 0x003B5AD0 File Offset: 0x003B3CD0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DA8D RID: 55949 RVA: 0x003B5AE0 File Offset: 0x003B3CE0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DA8E RID: 55950 RVA: 0x003B5AF0 File Offset: 0x003B3CF0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600DA8F RID: 55951 RVA: 0x003B5B00 File Offset: 0x003B3D00
			public void __callDele_EventOnSkip()
			{
				this.m_owner.__callDele_EventOnSkip();
			}

			// Token: 0x0600DA90 RID: 55952 RVA: 0x003B5B10 File Offset: 0x003B3D10
			public void __clearDele_EventOnSkip()
			{
				this.m_owner.__clearDele_EventOnSkip();
			}

			// Token: 0x0600DA91 RID: 55953 RVA: 0x003B5B20 File Offset: 0x003B3D20
			public void __callDele_EventOnNext(bool obj)
			{
				this.m_owner.__callDele_EventOnNext(obj);
			}

			// Token: 0x0600DA92 RID: 55954 RVA: 0x003B5B30 File Offset: 0x003B3D30
			public void __clearDele_EventOnNext(bool obj)
			{
				this.m_owner.__clearDele_EventOnNext(obj);
			}

			// Token: 0x0600DA93 RID: 55955 RVA: 0x003B5B40 File Offset: 0x003B3D40
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600DA94 RID: 55956 RVA: 0x003B5B50 File Offset: 0x003B3D50
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002A65 RID: 10853
			// (get) Token: 0x0600DA95 RID: 55957 RVA: 0x003B5B60 File Offset: 0x003B3D60
			// (set) Token: 0x0600DA96 RID: 55958 RVA: 0x003B5B70 File Offset: 0x003B3D70
			public Button m_skipButton
			{
				get
				{
					return this.m_owner.m_skipButton;
				}
				set
				{
					this.m_owner.m_skipButton = value;
				}
			}

			// Token: 0x17002A66 RID: 10854
			// (get) Token: 0x0600DA97 RID: 55959 RVA: 0x003B5B80 File Offset: 0x003B3D80
			// (set) Token: 0x0600DA98 RID: 55960 RVA: 0x003B5B90 File Offset: 0x003B3D90
			public CommonUIStateController m_backgroundUIStateController
			{
				get
				{
					return this.m_owner.m_backgroundUIStateController;
				}
				set
				{
					this.m_owner.m_backgroundUIStateController = value;
				}
			}

			// Token: 0x17002A67 RID: 10855
			// (get) Token: 0x0600DA99 RID: 55961 RVA: 0x003B5BA0 File Offset: 0x003B3DA0
			// (set) Token: 0x0600DA9A RID: 55962 RVA: 0x003B5BB0 File Offset: 0x003B3DB0
			public GameObject m_backgroundGraphicGameObject
			{
				get
				{
					return this.m_owner.m_backgroundGraphicGameObject;
				}
				set
				{
					this.m_owner.m_backgroundGraphicGameObject = value;
				}
			}

			// Token: 0x17002A68 RID: 10856
			// (get) Token: 0x0600DA9B RID: 55963 RVA: 0x003B5BC0 File Offset: 0x003B3DC0
			// (set) Token: 0x0600DA9C RID: 55964 RVA: 0x003B5BD0 File Offset: 0x003B3DD0
			public Image m_backgroundImage
			{
				get
				{
					return this.m_owner.m_backgroundImage;
				}
				set
				{
					this.m_owner.m_backgroundImage = value;
				}
			}

			// Token: 0x17002A69 RID: 10857
			// (get) Token: 0x0600DA9D RID: 55965 RVA: 0x003B5BE0 File Offset: 0x003B3DE0
			// (set) Token: 0x0600DA9E RID: 55966 RVA: 0x003B5BF0 File Offset: 0x003B3DF0
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

			// Token: 0x17002A6A RID: 10858
			// (get) Token: 0x0600DA9F RID: 55967 RVA: 0x003B5C00 File Offset: 0x003B3E00
			// (set) Token: 0x0600DAA0 RID: 55968 RVA: 0x003B5C10 File Offset: 0x003B3E10
			public GameObject m_placeGameObject
			{
				get
				{
					return this.m_owner.m_placeGameObject;
				}
				set
				{
					this.m_owner.m_placeGameObject = value;
				}
			}

			// Token: 0x17002A6B RID: 10859
			// (get) Token: 0x0600DAA1 RID: 55969 RVA: 0x003B5C20 File Offset: 0x003B3E20
			// (set) Token: 0x0600DAA2 RID: 55970 RVA: 0x003B5C30 File Offset: 0x003B3E30
			public Text m_placeText
			{
				get
				{
					return this.m_owner.m_placeText;
				}
				set
				{
					this.m_owner.m_placeText = value;
				}
			}

			// Token: 0x17002A6C RID: 10860
			// (get) Token: 0x0600DAA3 RID: 55971 RVA: 0x003B5C40 File Offset: 0x003B3E40
			// (set) Token: 0x0600DAA4 RID: 55972 RVA: 0x003B5C50 File Offset: 0x003B3E50
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

			// Token: 0x17002A6D RID: 10861
			// (get) Token: 0x0600DAA5 RID: 55973 RVA: 0x003B5C60 File Offset: 0x003B3E60
			// (set) Token: 0x0600DAA6 RID: 55974 RVA: 0x003B5C70 File Offset: 0x003B3E70
			public GameObject m_char0GameObject
			{
				get
				{
					return this.m_owner.m_char0GameObject;
				}
				set
				{
					this.m_owner.m_char0GameObject = value;
				}
			}

			// Token: 0x17002A6E RID: 10862
			// (get) Token: 0x0600DAA7 RID: 55975 RVA: 0x003B5C80 File Offset: 0x003B3E80
			// (set) Token: 0x0600DAA8 RID: 55976 RVA: 0x003B5C90 File Offset: 0x003B3E90
			public GameObject m_char1GameObject
			{
				get
				{
					return this.m_owner.m_char1GameObject;
				}
				set
				{
					this.m_owner.m_char1GameObject = value;
				}
			}

			// Token: 0x17002A6F RID: 10863
			// (get) Token: 0x0600DAA9 RID: 55977 RVA: 0x003B5CA0 File Offset: 0x003B3EA0
			// (set) Token: 0x0600DAAA RID: 55978 RVA: 0x003B5CB0 File Offset: 0x003B3EB0
			public GameObject m_char2GameObject
			{
				get
				{
					return this.m_owner.m_char2GameObject;
				}
				set
				{
					this.m_owner.m_char2GameObject = value;
				}
			}

			// Token: 0x17002A70 RID: 10864
			// (get) Token: 0x0600DAAB RID: 55979 RVA: 0x003B5CC0 File Offset: 0x003B3EC0
			// (set) Token: 0x0600DAAC RID: 55980 RVA: 0x003B5CD0 File Offset: 0x003B3ED0
			public GameObject m_effectGroup1
			{
				get
				{
					return this.m_owner.m_effectGroup1;
				}
				set
				{
					this.m_owner.m_effectGroup1 = value;
				}
			}

			// Token: 0x17002A71 RID: 10865
			// (get) Token: 0x0600DAAD RID: 55981 RVA: 0x003B5CE0 File Offset: 0x003B3EE0
			// (set) Token: 0x0600DAAE RID: 55982 RVA: 0x003B5CF0 File Offset: 0x003B3EF0
			public GameObject m_effectGroup2
			{
				get
				{
					return this.m_owner.m_effectGroup2;
				}
				set
				{
					this.m_owner.m_effectGroup2 = value;
				}
			}

			// Token: 0x17002A72 RID: 10866
			// (get) Token: 0x0600DAAF RID: 55983 RVA: 0x003B5D00 File Offset: 0x003B3F00
			// (set) Token: 0x0600DAB0 RID: 55984 RVA: 0x003B5D10 File Offset: 0x003B3F10
			public GameObject m_effectGroup3
			{
				get
				{
					return this.m_owner.m_effectGroup3;
				}
				set
				{
					this.m_owner.m_effectGroup3 = value;
				}
			}

			// Token: 0x17002A73 RID: 10867
			// (get) Token: 0x0600DAB1 RID: 55985 RVA: 0x003B5D20 File Offset: 0x003B3F20
			// (set) Token: 0x0600DAB2 RID: 55986 RVA: 0x003B5D30 File Offset: 0x003B3F30
			public GameObject m_insertEffect
			{
				get
				{
					return this.m_owner.m_insertEffect;
				}
				set
				{
					this.m_owner.m_insertEffect = value;
				}
			}

			// Token: 0x17002A74 RID: 10868
			// (get) Token: 0x0600DAB3 RID: 55987 RVA: 0x003B5D40 File Offset: 0x003B3F40
			// (set) Token: 0x0600DAB4 RID: 55988 RVA: 0x003B5D50 File Offset: 0x003B3F50
			public CommonUIStateController m_changeBGTweenUIStateCtrl
			{
				get
				{
					return this.m_owner.m_changeBGTweenUIStateCtrl;
				}
				set
				{
					this.m_owner.m_changeBGTweenUIStateCtrl = value;
				}
			}

			// Token: 0x17002A75 RID: 10869
			// (get) Token: 0x0600DAB5 RID: 55989 RVA: 0x003B5D60 File Offset: 0x003B3F60
			// (set) Token: 0x0600DAB6 RID: 55990 RVA: 0x003B5D70 File Offset: 0x003B3F70
			public DialogCharUIController[] m_dialogCharUIControllers
			{
				get
				{
					return this.m_owner.m_dialogCharUIControllers;
				}
				set
				{
					this.m_owner.m_dialogCharUIControllers = value;
				}
			}

			// Token: 0x17002A76 RID: 10870
			// (get) Token: 0x0600DAB7 RID: 55991 RVA: 0x003B5D80 File Offset: 0x003B3F80
			// (set) Token: 0x0600DAB8 RID: 55992 RVA: 0x003B5D90 File Offset: 0x003B3F90
			public DialogBoxUIController m_dialogBoxUIController
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

			// Token: 0x17002A77 RID: 10871
			// (get) Token: 0x0600DAB9 RID: 55993 RVA: 0x003B5DA0 File Offset: 0x003B3FA0
			// (set) Token: 0x0600DABA RID: 55994 RVA: 0x003B5DB0 File Offset: 0x003B3FB0
			public UISpineGraphic m_backgroundGraphic
			{
				get
				{
					return this.m_owner.m_backgroundGraphic;
				}
				set
				{
					this.m_owner.m_backgroundGraphic = value;
				}
			}

			// Token: 0x17002A78 RID: 10872
			// (get) Token: 0x0600DABB RID: 55995 RVA: 0x003B5DC0 File Offset: 0x003B3FC0
			// (set) Token: 0x0600DABC RID: 55996 RVA: 0x003B5DD0 File Offset: 0x003B3FD0
			public string m_group1PrefabName
			{
				get
				{
					return this.m_owner.m_group1PrefabName;
				}
				set
				{
					this.m_owner.m_group1PrefabName = value;
				}
			}

			// Token: 0x17002A79 RID: 10873
			// (get) Token: 0x0600DABD RID: 55997 RVA: 0x003B5DE0 File Offset: 0x003B3FE0
			// (set) Token: 0x0600DABE RID: 55998 RVA: 0x003B5DF0 File Offset: 0x003B3FF0
			public string m_group2PrefabName
			{
				get
				{
					return this.m_owner.m_group2PrefabName;
				}
				set
				{
					this.m_owner.m_group2PrefabName = value;
				}
			}

			// Token: 0x17002A7A RID: 10874
			// (get) Token: 0x0600DABF RID: 55999 RVA: 0x003B5E00 File Offset: 0x003B4000
			// (set) Token: 0x0600DAC0 RID: 56000 RVA: 0x003B5E10 File Offset: 0x003B4010
			public string m_group3PrefabName
			{
				get
				{
					return this.m_owner.m_group3PrefabName;
				}
				set
				{
					this.m_owner.m_group3PrefabName = value;
				}
			}

			// Token: 0x17002A7B RID: 10875
			// (get) Token: 0x0600DAC1 RID: 56001 RVA: 0x003B5E20 File Offset: 0x003B4020
			// (set) Token: 0x0600DAC2 RID: 56002 RVA: 0x003B5E30 File Offset: 0x003B4030
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

			// Token: 0x17002A7C RID: 10876
			// (get) Token: 0x0600DAC3 RID: 56003 RVA: 0x003B5E40 File Offset: 0x003B4040
			// (set) Token: 0x0600DAC4 RID: 56004 RVA: 0x003B5E50 File Offset: 0x003B4050
			public IAudioPlayback m_currentAudio
			{
				get
				{
					return this.m_owner.m_currentAudio;
				}
				set
				{
					this.m_owner.m_currentAudio = value;
				}
			}

			// Token: 0x17002A7D RID: 10877
			// (get) Token: 0x0600DAC5 RID: 56005 RVA: 0x003B5E60 File Offset: 0x003B4060
			// (set) Token: 0x0600DAC6 RID: 56006 RVA: 0x003B5E70 File Offset: 0x003B4070
			public ConfigDataDialogInfo m_dialogInfo
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

			// Token: 0x17002A7E RID: 10878
			// (get) Token: 0x0600DAC7 RID: 56007 RVA: 0x003B5E80 File Offset: 0x003B4080
			// (set) Token: 0x0600DAC8 RID: 56008 RVA: 0x003B5E90 File Offset: 0x003B4090
			public string m_backgroundAssetName
			{
				get
				{
					return this.m_owner.m_backgroundAssetName;
				}
				set
				{
					this.m_owner.m_backgroundAssetName = value;
				}
			}

			// Token: 0x17002A7F RID: 10879
			// (get) Token: 0x0600DAC9 RID: 56009 RVA: 0x003B5EA0 File Offset: 0x003B40A0
			// (set) Token: 0x0600DACA RID: 56010 RVA: 0x003B5EB0 File Offset: 0x003B40B0
			public bool m_needBGChangeTween
			{
				get
				{
					return this.m_owner.m_needBGChangeTween;
				}
				set
				{
					this.m_owner.m_needBGChangeTween = value;
				}
			}

			// Token: 0x0600DACB RID: 56011 RVA: 0x003B5EC0 File Offset: 0x003B40C0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600DACC RID: 56012 RVA: 0x003B5ED0 File Offset: 0x003B40D0
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600DACD RID: 56013 RVA: 0x003B5EE0 File Offset: 0x003B40E0
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600DACE RID: 56014 RVA: 0x003B5EF0 File Offset: 0x003B40F0
			public IEnumerator Co_ShowDialog(ConfigDataDialogInfo dialogInfo, bool needBGChangeTween)
			{
				return this.m_owner.Co_ShowDialog(dialogInfo, needBGChangeTween);
			}

			// Token: 0x0600DACF RID: 56015 RVA: 0x003B5F00 File Offset: 0x003B4100
			public IEnumerator Co_CharLeavePlay(ConfigDataDialogInfo dialogInfo, Action onEndAction)
			{
				return this.m_owner.Co_CharLeavePlay(dialogInfo, onEndAction);
			}

			// Token: 0x0600DAD0 RID: 56016 RVA: 0x003B5F10 File Offset: 0x003B4110
			public IEnumerator Co_BGChangeTweenPlay(ConfigDataDialogInfo dialogInfo)
			{
				return this.m_owner.Co_BGChangeTweenPlay(dialogInfo);
			}

			// Token: 0x0600DAD1 RID: 56017 RVA: 0x003B5F20 File Offset: 0x003B4120
			public IEnumerator Co_SetBGChangeLeaveShowUIState(ConfigDataDialogInfo dialogInfo, string state)
			{
				return this.m_owner.Co_SetBGChangeLeaveShowUIState(dialogInfo, state);
			}

			// Token: 0x0600DAD2 RID: 56018 RVA: 0x003B5F30 File Offset: 0x003B4130
			public IEnumerator Co_SetBGChangeEnterShowUIState(string state)
			{
				return this.m_owner.Co_SetBGChangeEnterShowUIState(state);
			}

			// Token: 0x0600DAD3 RID: 56019 RVA: 0x003B5F40 File Offset: 0x003B4140
			public IEnumerator Co_CreateCharEnter(ConfigDataDialogInfo dialogInfo, DialogCharUIController c)
			{
				return this.m_owner.Co_CreateCharEnter(dialogInfo, c);
			}

			// Token: 0x0600DAD4 RID: 56020 RVA: 0x003B5F50 File Offset: 0x003B4150
			public void PlayBGMInDialog(ConfigDataDialogInfo dialogInfo)
			{
				this.m_owner.PlayBGMInDialog(dialogInfo);
			}

			// Token: 0x0600DAD5 RID: 56021 RVA: 0x003B5F60 File Offset: 0x003B4160
			public IEnumerator Co_CloseDialog()
			{
				return this.m_owner.Co_CloseDialog();
			}

			// Token: 0x0600DAD6 RID: 56022 RVA: 0x003B5F70 File Offset: 0x003B4170
			public void ShowDialogBox()
			{
				this.m_owner.ShowDialogBox();
			}

			// Token: 0x0600DAD7 RID: 56023 RVA: 0x003B5F80 File Offset: 0x003B4180
			public void CreateBackgroundGraphic(string assetName)
			{
				this.m_owner.CreateBackgroundGraphic(assetName);
			}

			// Token: 0x0600DAD8 RID: 56024 RVA: 0x003B5F90 File Offset: 0x003B4190
			public void DestroyBackgroundGraphic()
			{
				this.m_owner.DestroyBackgroundGraphic();
			}

			// Token: 0x0600DAD9 RID: 56025 RVA: 0x003B5FA0 File Offset: 0x003B41A0
			public IEnumerator Co_CreateBeforeEnterEffectGroup()
			{
				return this.m_owner.Co_CreateBeforeEnterEffectGroup();
			}

			// Token: 0x0600DADA RID: 56026 RVA: 0x003B5FB0 File Offset: 0x003B41B0
			public IEnumerator Co_CreateBeforeTalkEffectGroup()
			{
				return this.m_owner.Co_CreateBeforeTalkEffectGroup();
			}

			// Token: 0x0600DADB RID: 56027 RVA: 0x003B5FC0 File Offset: 0x003B41C0
			public IEnumerator Co_AfterTalkEffectAndLeave(ConfigDataDialogInfo dialogInfo)
			{
				return this.m_owner.Co_AfterTalkEffectAndLeave(dialogInfo);
			}

			// Token: 0x0600DADC RID: 56028 RVA: 0x003B5FD0 File Offset: 0x003B41D0
			public IEnumerator Co_CreateAfterTalkEffectGroup(ConfigDataDialogInfo dialogInfo)
			{
				return this.m_owner.Co_CreateAfterTalkEffectGroup(dialogInfo);
			}

			// Token: 0x0600DADD RID: 56029 RVA: 0x003B5FE0 File Offset: 0x003B41E0
			public void CreateEffectGroupLeaveTogether(ConfigDataDialogInfo dialogInfo, List<int> effectGroup, GameObject parentGameObject, Action onEndAction)
			{
				this.m_owner.CreateEffectGroupLeaveTogether(dialogInfo, effectGroup, parentGameObject, onEndAction);
			}

			// Token: 0x0600DADE RID: 56030 RVA: 0x003B5FF4 File Offset: 0x003B41F4
			public void CreateEffectGroup(List<int> effectGroup, GameObject parentGameObject, Action onEndAction)
			{
				this.m_owner.CreateEffectGroup(effectGroup, parentGameObject, onEndAction);
			}

			// Token: 0x0600DADF RID: 56031 RVA: 0x003B6004 File Offset: 0x003B4204
			public void PlayEffectGroup(List<int> effectGroup, GameObject parentGameObject, Action onEndAction)
			{
				this.m_owner.PlayEffectGroup(effectGroup, parentGameObject, onEndAction);
			}

			// Token: 0x0600DAE0 RID: 56032 RVA: 0x003B6014 File Offset: 0x003B4214
			public void CreateEffect(ConfigDataPrefabStateInfo prefabStateConfig, GameObject parentGameObject, Action onEndAction)
			{
				this.m_owner.CreateEffect(prefabStateConfig, parentGameObject, onEndAction);
			}

			// Token: 0x0600DAE1 RID: 56033 RVA: 0x003B6024 File Offset: 0x003B4224
			public void CreateEffectInGroup(ref string prefabName, ConfigDataPrefabStateInfo prefabStateConfig, GameObject parentGameObject, Action onEndAction)
			{
				this.m_owner.CreateEffectInGroup(ref prefabName, prefabStateConfig, parentGameObject, onEndAction);
			}

			// Token: 0x0600DAE2 RID: 56034 RVA: 0x003B6038 File Offset: 0x003B4238
			public void CreateInsertEffect(int prefabStateID, Action onEndAction)
			{
				this.m_owner.CreateInsertEffect(prefabStateID, onEndAction);
			}

			// Token: 0x0600DAE3 RID: 56035 RVA: 0x003B6048 File Offset: 0x003B4248
			public void SetBackgroundImage(string name)
			{
				this.m_owner.SetBackgroundImage(name);
			}

			// Token: 0x0600DAE4 RID: 56036 RVA: 0x003B6058 File Offset: 0x003B4258
			public void ClearBackgroundImage()
			{
				this.m_owner.ClearBackgroundImage();
			}

			// Token: 0x0600DAE5 RID: 56037 RVA: 0x003B6068 File Offset: 0x003B4268
			public IAudioPlayback PlayVoice(string name)
			{
				return this.m_owner.PlayVoice(name);
			}

			// Token: 0x0600DAE6 RID: 56038 RVA: 0x003B6078 File Offset: 0x003B4278
			public void StopVoice()
			{
				this.m_owner.StopVoice();
			}

			// Token: 0x0600DAE7 RID: 56039 RVA: 0x003B6088 File Offset: 0x003B4288
			public IEnumerator Co_NextDialog()
			{
				return this.m_owner.Co_NextDialog();
			}

			// Token: 0x0600DAE8 RID: 56040 RVA: 0x003B6098 File Offset: 0x003B4298
			public void OnSkipButtonClick()
			{
				this.m_owner.OnSkipButtonClick();
			}

			// Token: 0x0600DAE9 RID: 56041 RVA: 0x003B60A8 File Offset: 0x003B42A8
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x040085E9 RID: 34281
			private DialogUIController m_owner;
		}
	}
}
