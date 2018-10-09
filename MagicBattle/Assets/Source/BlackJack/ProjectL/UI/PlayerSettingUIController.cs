using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BE6 RID: 3046
	[HotFix]
	public class PlayerSettingUIController : UIControllerBase
	{
		// Token: 0x0600D2D7 RID: 53975 RVA: 0x00398BEC File Offset: 0x00396DEC
		private PlayerSettingUIController()
		{
		}

		// Token: 0x0600D2D8 RID: 53976 RVA: 0x00398C0C File Offset: 0x00396E0C
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
			this.m_settingPanelCloseButton.onClick.AddListener(new UnityAction(this.OnSettingPanelCloseButtonClick));
			this.m_settingPanelBGButton.onClick.AddListener(new UnityAction(this.OnSettingPanelCloseButtonClick));
			this.m_musicVolumeSlider.onValueChanged.AddListener(new UnityAction<float>(this.OnMusicVolumeValueChanged));
			this.m_soundVolumeSlider.onValueChanged.AddListener(new UnityAction<float>(this.OnSoundVolumeValueChanged));
			this.m_voiceVolumeSlider.onValueChanged.AddListener(new UnityAction<float>(this.OnVoiceVolumeValueChanged));
			this.m_powerSaveModeOnToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnPowerSaveModeToggleValueChanged));
			this.m_endActionOnToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnEndActionToggleValueChanged));
			this.m_recoveryEnergyOnToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRecoveryEnergyToggleValueChanged));
			this.m_arenaTicketOnToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnArenaTicketToggleValueChanged));
			this.m_storeRefreshOnToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnStoreRefreshToggleValueChanged));
			this.m_battleAnimationOnToggle.onValueChanged.AddListener(new UnityAction<bool>(this.SetBattleAnimationOn));
			this.m_battleAnimationOffToggle.onValueChanged.AddListener(new UnityAction<bool>(this.SetBattleAnimationOff));
			this.m_battleAnimationOnlyMineToggle.onValueChanged.AddListener(new UnityAction<bool>(this.SetBattleAnimationOnlyMine));
			this.m_battleAnimationOffButton.onClick.AddListener(new UnityAction(this.OnBattleAnimationOffButtonClick));
			this.m_battleAnimationOnlyMineButton.onClick.AddListener(new UnityAction(this.OnBattleAnimationOnlyMineButtonClick));
		}

		// Token: 0x0600D2D9 RID: 53977 RVA: 0x00398E18 File Offset: 0x00397018
		public void SettingPanelShow()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SettingPanelShow_hotfix != null)
			{
				this.m_SettingPanelShow_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_settingStateCtrl, "Show", null, false, true);
		}

		// Token: 0x0600D2DA RID: 53978 RVA: 0x00398E8C File Offset: 0x0039708C
		private void OnSettingPanelCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSettingPanelCloseButtonClick_hotfix != null)
			{
				this.m_OnSettingPanelCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_settingStateCtrl, "Close", delegate
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			}, false, true);
		}

		// Token: 0x0600D2DB RID: 53979 RVA: 0x00398F0C File Offset: 0x0039710C
		public void UpdateSettingPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSettingPanel_hotfix != null)
			{
				this.m_UpdateSettingPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_SkipBattleAnimation))
			{
				this.m_battleAnimationOffButton.gameObject.SetActive(false);
				this.m_battleAnimationOnlyMineButton.gameObject.SetActive(false);
				this.m_battleAnimationOffToggle.gameObject.SetActive(true);
				this.m_battleAnimationOnlyMineToggle.gameObject.SetActive(true);
			}
			else
			{
				this.m_battleAnimationOffButton.gameObject.SetActive(true);
				this.m_battleAnimationOnlyMineButton.gameObject.SetActive(true);
				this.m_battleAnimationOffToggle.gameObject.SetActive(false);
				this.m_battleAnimationOnlyMineToggle.gameObject.SetActive(false);
			}
			this.m_isIgnoreToggleEvent = true;
			this.m_musicVolumeSlider.value = LocalConfig.Instance.Data.MusicVolume;
			this.m_soundVolumeSlider.value = LocalConfig.Instance.Data.SoundVolumn;
			this.m_voiceVolumeSlider.value = LocalConfig.Instance.Data.VoiceVolume;
			this.m_powerSaveModeOnToggle.isOn = LocalConfig.Instance.Data.PowerSaveModeOn;
			this.m_powerSaveModeOffToggle.isOn = !LocalConfig.Instance.Data.PowerSaveModeOn;
			this.m_endActionOnToggle.isOn = LocalConfig.Instance.Data.ClickActorEndAction;
			this.m_endActionOffToggle.isOn = !LocalConfig.Instance.Data.ClickActorEndAction;
			this.m_recoveryEnergyOnToggle.isOn = LocalConfig.Instance.Data.NotifyEnergyRecover;
			this.m_recoveryEnergyOffToggle.isOn = !LocalConfig.Instance.Data.NotifyEnergyRecover;
			this.m_arenaTicketOnToggle.isOn = LocalConfig.Instance.Data.NotifyArenaTicket;
			this.m_arenaTicketOffToggle.isOn = !LocalConfig.Instance.Data.NotifyArenaTicket;
			this.m_storeRefreshOnToggle.isOn = LocalConfig.Instance.Data.NotifyStoreRefresh;
			this.m_storeRefreshOffToggle.isOn = !LocalConfig.Instance.Data.NotifyStoreRefresh;
			int skipCombatMode = LocalConfig.Instance.Data.SkipCombatMode;
			if (skipCombatMode != 0)
			{
				if (skipCombatMode != 1)
				{
					if (skipCombatMode == 2)
					{
						this.m_battleAnimationOnToggle.isOn = false;
						this.m_battleAnimationOffToggle.isOn = false;
						this.m_battleAnimationOnlyMineToggle.isOn = true;
					}
				}
				else
				{
					this.m_battleAnimationOnToggle.isOn = false;
					this.m_battleAnimationOffToggle.isOn = true;
					this.m_battleAnimationOnlyMineToggle.isOn = false;
				}
			}
			else
			{
				this.m_battleAnimationOnToggle.isOn = true;
				this.m_battleAnimationOffToggle.isOn = false;
				this.m_battleAnimationOnlyMineToggle.isOn = false;
			}
			this.m_isIgnoreToggleEvent = false;
		}

		// Token: 0x0600D2DC RID: 53980 RVA: 0x00399220 File Offset: 0x00397420
		private void OnMusicVolumeValueChanged(float volumn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMusicVolumeValueChangedSingle_hotfix != null)
			{
				this.m_OnMusicVolumeValueChangedSingle_hotfix.call(new object[]
				{
					this,
					volumn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = volumn > 0f;
			this.m_musicSoundOnState.SetToUIState((!flag) ? "Grey" : "Normal", false, true);
			this.m_musicSoundOffState.SetToUIState((!flag) ? "Normal" : "Grey", false, true);
			if (this.EventOnMusicVolumeChanged != null)
			{
				this.EventOnMusicVolumeChanged(volumn);
			}
		}

		// Token: 0x0600D2DD RID: 53981 RVA: 0x003992F4 File Offset: 0x003974F4
		private void OnSoundVolumeValueChanged(float volumn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoundVolumeValueChangedSingle_hotfix != null)
			{
				this.m_OnSoundVolumeValueChangedSingle_hotfix.call(new object[]
				{
					this,
					volumn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = volumn > 0f;
			this.m_soundSoundOnState.SetToUIState((!flag) ? "Grey" : "Normal", false, true);
			this.m_soundSoundOffState.SetToUIState((!flag) ? "Normal" : "Grey", false, true);
			if (this.EventOnSoundVolumeChanged != null)
			{
				this.EventOnSoundVolumeChanged(volumn);
			}
		}

		// Token: 0x0600D2DE RID: 53982 RVA: 0x003993C8 File Offset: 0x003975C8
		private void OnVoiceVolumeValueChanged(float volumn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnVoiceVolumeValueChangedSingle_hotfix != null)
			{
				this.m_OnVoiceVolumeValueChangedSingle_hotfix.call(new object[]
				{
					this,
					volumn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = volumn > 0f;
			this.m_voiceSoundOnState.SetToUIState((!flag) ? "Grey" : "Normal", false, true);
			this.m_voiceSoundOffState.SetToUIState((!flag) ? "Normal" : "Grey", false, true);
			if (this.EventOnVoiceVolumeChanged != null)
			{
				this.EventOnVoiceVolumeChanged(volumn);
			}
		}

		// Token: 0x0600D2DF RID: 53983 RVA: 0x0039949C File Offset: 0x0039769C
		private void OnPowerSaveModeToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPowerSaveModeToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnPowerSaveModeToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (this.EventOnPowerSaveModeIsOn != null)
			{
				this.EventOnPowerSaveModeIsOn(isOn);
			}
		}

		// Token: 0x0600D2E0 RID: 53984 RVA: 0x00399530 File Offset: 0x00397730
		private void OnEndActionToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndActionToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnEndActionToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (this.EventOnEndActionIsOn != null)
			{
				this.EventOnEndActionIsOn(isOn);
			}
		}

		// Token: 0x0600D2E1 RID: 53985 RVA: 0x003995C4 File Offset: 0x003977C4
		private void OnRecoveryEnergyToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRecoveryEnergyToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnRecoveryEnergyToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (this.EventOnNotifyRecoveryEnergyIsOn != null)
			{
				this.EventOnNotifyRecoveryEnergyIsOn(isOn);
			}
		}

		// Token: 0x0600D2E2 RID: 53986 RVA: 0x00399658 File Offset: 0x00397858
		private void OnRandomEventToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRandomEventToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnRandomEventToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (this.EventOnNotifyRandomEventIsOn != null)
			{
				this.EventOnNotifyRandomEventIsOn(isOn);
			}
		}

		// Token: 0x0600D2E3 RID: 53987 RVA: 0x003996EC File Offset: 0x003978EC
		private void OnArenaTicketToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnArenaTicketToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnArenaTicketToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (this.EventOnNotifyArenaTicketIsOn != null)
			{
				this.EventOnNotifyArenaTicketIsOn(isOn);
			}
		}

		// Token: 0x0600D2E4 RID: 53988 RVA: 0x00399780 File Offset: 0x00397980
		private void OnStoreRefreshToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStoreRefreshToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnStoreRefreshToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (this.EventOnNotifyStoreRefreshIsOn != null)
			{
				this.EventOnNotifyStoreRefreshIsOn(isOn);
			}
		}

		// Token: 0x0600D2E5 RID: 53989 RVA: 0x00399814 File Offset: 0x00397A14
		private void SetBattleAnimationOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleAnimationOnBoolean_hotfix != null)
			{
				this.m_SetBattleAnimationOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn && this.EventOnSetBattleAnimationMode != null)
			{
				this.EventOnSetBattleAnimationMode(SkipCombatMode.None);
			}
		}

		// Token: 0x0600D2E6 RID: 53990 RVA: 0x003998B0 File Offset: 0x00397AB0
		private void SetBattleAnimationOff(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleAnimationOffBoolean_hotfix != null)
			{
				this.m_SetBattleAnimationOffBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn && this.EventOnSetBattleAnimationMode != null)
			{
				this.EventOnSetBattleAnimationMode(SkipCombatMode.All);
			}
		}

		// Token: 0x0600D2E7 RID: 53991 RVA: 0x0039994C File Offset: 0x00397B4C
		private void SetBattleAnimationOnlyMine(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleAnimationOnlyMineBoolean_hotfix != null)
			{
				this.m_SetBattleAnimationOnlyMineBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn && this.EventOnSetBattleAnimationMode != null)
			{
				this.EventOnSetBattleAnimationMode(SkipCombatMode.Enemy);
			}
		}

		// Token: 0x0600D2E8 RID: 53992 RVA: 0x003999E8 File Offset: 0x00397BE8
		private void OnBattleAnimationOffButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleAnimationOffButtonClick_hotfix != null)
			{
				this.m_OnBattleAnimationOffButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_SkipBattleAnimation), 2f, null, true);
		}

		// Token: 0x0600D2E9 RID: 53993 RVA: 0x00399A60 File Offset: 0x00397C60
		private void OnBattleAnimationOnlyMineButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleAnimationOnlyMineButtonClick_hotfix != null)
			{
				this.m_OnBattleAnimationOnlyMineButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_SkipBattleAnimation), 2f, null, true);
		}

		// Token: 0x1400028C RID: 652
		// (add) Token: 0x0600D2EA RID: 53994 RVA: 0x00399AD8 File Offset: 0x00397CD8
		// (remove) Token: 0x0600D2EB RID: 53995 RVA: 0x00399B74 File Offset: 0x00397D74
		public event Action<float> EventOnMusicVolumeChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnMusicVolumeChangedAction`1_hotfix != null)
				{
					this.m_add_EventOnMusicVolumeChangedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<float> action = this.EventOnMusicVolumeChanged;
				Action<float> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<float>>(ref this.EventOnMusicVolumeChanged, (Action<float>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnMusicVolumeChangedAction`1_hotfix != null)
				{
					this.m_remove_EventOnMusicVolumeChangedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<float> action = this.EventOnMusicVolumeChanged;
				Action<float> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<float>>(ref this.EventOnMusicVolumeChanged, (Action<float>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400028D RID: 653
		// (add) Token: 0x0600D2EC RID: 53996 RVA: 0x00399C10 File Offset: 0x00397E10
		// (remove) Token: 0x0600D2ED RID: 53997 RVA: 0x00399CAC File Offset: 0x00397EAC
		public event Action<float> EventOnSoundVolumeChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSoundVolumeChangedAction`1_hotfix != null)
				{
					this.m_add_EventOnSoundVolumeChangedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<float> action = this.EventOnSoundVolumeChanged;
				Action<float> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<float>>(ref this.EventOnSoundVolumeChanged, (Action<float>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSoundVolumeChangedAction`1_hotfix != null)
				{
					this.m_remove_EventOnSoundVolumeChangedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<float> action = this.EventOnSoundVolumeChanged;
				Action<float> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<float>>(ref this.EventOnSoundVolumeChanged, (Action<float>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400028E RID: 654
		// (add) Token: 0x0600D2EE RID: 53998 RVA: 0x00399D48 File Offset: 0x00397F48
		// (remove) Token: 0x0600D2EF RID: 53999 RVA: 0x00399DE4 File Offset: 0x00397FE4
		public event Action<float> EventOnVoiceVolumeChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnVoiceVolumeChangedAction`1_hotfix != null)
				{
					this.m_add_EventOnVoiceVolumeChangedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<float> action = this.EventOnVoiceVolumeChanged;
				Action<float> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<float>>(ref this.EventOnVoiceVolumeChanged, (Action<float>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnVoiceVolumeChangedAction`1_hotfix != null)
				{
					this.m_remove_EventOnVoiceVolumeChangedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<float> action = this.EventOnVoiceVolumeChanged;
				Action<float> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<float>>(ref this.EventOnVoiceVolumeChanged, (Action<float>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400028F RID: 655
		// (add) Token: 0x0600D2F0 RID: 54000 RVA: 0x00399E80 File Offset: 0x00398080
		// (remove) Token: 0x0600D2F1 RID: 54001 RVA: 0x00399F1C File Offset: 0x0039811C
		public event Action<bool> EventOnPowerSaveModeIsOn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPowerSaveModeIsOnAction`1_hotfix != null)
				{
					this.m_add_EventOnPowerSaveModeIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnPowerSaveModeIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnPowerSaveModeIsOn, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPowerSaveModeIsOnAction`1_hotfix != null)
				{
					this.m_remove_EventOnPowerSaveModeIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnPowerSaveModeIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnPowerSaveModeIsOn, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000290 RID: 656
		// (add) Token: 0x0600D2F2 RID: 54002 RVA: 0x00399FB8 File Offset: 0x003981B8
		// (remove) Token: 0x0600D2F3 RID: 54003 RVA: 0x0039A054 File Offset: 0x00398254
		public event Action<bool> EventOnEndActionIsOn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndActionIsOnAction`1_hotfix != null)
				{
					this.m_add_EventOnEndActionIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnEndActionIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnEndActionIsOn, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndActionIsOnAction`1_hotfix != null)
				{
					this.m_remove_EventOnEndActionIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnEndActionIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnEndActionIsOn, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000291 RID: 657
		// (add) Token: 0x0600D2F4 RID: 54004 RVA: 0x0039A0F0 File Offset: 0x003982F0
		// (remove) Token: 0x0600D2F5 RID: 54005 RVA: 0x0039A18C File Offset: 0x0039838C
		public event Action<bool> EventOnNotifyRecoveryEnergyIsOn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNotifyRecoveryEnergyIsOnAction`1_hotfix != null)
				{
					this.m_add_EventOnNotifyRecoveryEnergyIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnNotifyRecoveryEnergyIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnNotifyRecoveryEnergyIsOn, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNotifyRecoveryEnergyIsOnAction`1_hotfix != null)
				{
					this.m_remove_EventOnNotifyRecoveryEnergyIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnNotifyRecoveryEnergyIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnNotifyRecoveryEnergyIsOn, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000292 RID: 658
		// (add) Token: 0x0600D2F6 RID: 54006 RVA: 0x0039A228 File Offset: 0x00398428
		// (remove) Token: 0x0600D2F7 RID: 54007 RVA: 0x0039A2C4 File Offset: 0x003984C4
		public event Action<bool> EventOnNotifyRandomEventIsOn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNotifyRandomEventIsOnAction`1_hotfix != null)
				{
					this.m_add_EventOnNotifyRandomEventIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnNotifyRandomEventIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnNotifyRandomEventIsOn, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNotifyRandomEventIsOnAction`1_hotfix != null)
				{
					this.m_remove_EventOnNotifyRandomEventIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnNotifyRandomEventIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnNotifyRandomEventIsOn, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000293 RID: 659
		// (add) Token: 0x0600D2F8 RID: 54008 RVA: 0x0039A360 File Offset: 0x00398560
		// (remove) Token: 0x0600D2F9 RID: 54009 RVA: 0x0039A3FC File Offset: 0x003985FC
		public event Action<bool> EventOnNotifyArenaTicketIsOn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNotifyArenaTicketIsOnAction`1_hotfix != null)
				{
					this.m_add_EventOnNotifyArenaTicketIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnNotifyArenaTicketIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnNotifyArenaTicketIsOn, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNotifyArenaTicketIsOnAction`1_hotfix != null)
				{
					this.m_remove_EventOnNotifyArenaTicketIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnNotifyArenaTicketIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnNotifyArenaTicketIsOn, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000294 RID: 660
		// (add) Token: 0x0600D2FA RID: 54010 RVA: 0x0039A498 File Offset: 0x00398698
		// (remove) Token: 0x0600D2FB RID: 54011 RVA: 0x0039A534 File Offset: 0x00398734
		public event Action<bool> EventOnNotifyStoreRefreshIsOn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNotifyStoreRefreshIsOnAction`1_hotfix != null)
				{
					this.m_add_EventOnNotifyStoreRefreshIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnNotifyStoreRefreshIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnNotifyStoreRefreshIsOn, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNotifyStoreRefreshIsOnAction`1_hotfix != null)
				{
					this.m_remove_EventOnNotifyStoreRefreshIsOnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnNotifyStoreRefreshIsOn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnNotifyStoreRefreshIsOn, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000295 RID: 661
		// (add) Token: 0x0600D2FC RID: 54012 RVA: 0x0039A5D0 File Offset: 0x003987D0
		// (remove) Token: 0x0600D2FD RID: 54013 RVA: 0x0039A66C File Offset: 0x0039886C
		public event Action<SkipCombatMode> EventOnSetBattleAnimationMode
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSetBattleAnimationModeAction`1_hotfix != null)
				{
					this.m_add_EventOnSetBattleAnimationModeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SkipCombatMode> action = this.EventOnSetBattleAnimationMode;
				Action<SkipCombatMode> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SkipCombatMode>>(ref this.EventOnSetBattleAnimationMode, (Action<SkipCombatMode>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSetBattleAnimationModeAction`1_hotfix != null)
				{
					this.m_remove_EventOnSetBattleAnimationModeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SkipCombatMode> action = this.EventOnSetBattleAnimationMode;
				Action<SkipCombatMode> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SkipCombatMode>>(ref this.EventOnSetBattleAnimationMode, (Action<SkipCombatMode>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000296 RID: 662
		// (add) Token: 0x0600D2FE RID: 54014 RVA: 0x0039A708 File Offset: 0x00398908
		// (remove) Token: 0x0600D2FF RID: 54015 RVA: 0x0039A7A4 File Offset: 0x003989A4
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

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x0600D300 RID: 54016 RVA: 0x0039A840 File Offset: 0x00398A40
		// (set) Token: 0x0600D301 RID: 54017 RVA: 0x0039A860 File Offset: 0x00398A60
		[DoNotToLua]
		public new PlayerSettingUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerSettingUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D302 RID: 54018 RVA: 0x0039A86C File Offset: 0x00398A6C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D303 RID: 54019 RVA: 0x0039A878 File Offset: 0x00398A78
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D304 RID: 54020 RVA: 0x0039A880 File Offset: 0x00398A80
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D305 RID: 54021 RVA: 0x0039A888 File Offset: 0x00398A88
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D306 RID: 54022 RVA: 0x0039A89C File Offset: 0x00398A9C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D307 RID: 54023 RVA: 0x0039A8A4 File Offset: 0x00398AA4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D308 RID: 54024 RVA: 0x0039A8B0 File Offset: 0x00398AB0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D309 RID: 54025 RVA: 0x0039A8BC File Offset: 0x00398ABC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D30A RID: 54026 RVA: 0x0039A8C8 File Offset: 0x00398AC8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D30B RID: 54027 RVA: 0x0039A8D4 File Offset: 0x00398AD4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D30C RID: 54028 RVA: 0x0039A8E0 File Offset: 0x00398AE0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D30D RID: 54029 RVA: 0x0039A8EC File Offset: 0x00398AEC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D30E RID: 54030 RVA: 0x0039A8F8 File Offset: 0x00398AF8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D30F RID: 54031 RVA: 0x0039A904 File Offset: 0x00398B04
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D310 RID: 54032 RVA: 0x0039A910 File Offset: 0x00398B10
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D311 RID: 54033 RVA: 0x0039A918 File Offset: 0x00398B18
		private void __callDele_EventOnMusicVolumeChanged(float obj)
		{
			Action<float> eventOnMusicVolumeChanged = this.EventOnMusicVolumeChanged;
			if (eventOnMusicVolumeChanged != null)
			{
				eventOnMusicVolumeChanged(obj);
			}
		}

		// Token: 0x0600D312 RID: 54034 RVA: 0x0039A93C File Offset: 0x00398B3C
		private void __clearDele_EventOnMusicVolumeChanged(float obj)
		{
			this.EventOnMusicVolumeChanged = null;
		}

		// Token: 0x0600D313 RID: 54035 RVA: 0x0039A948 File Offset: 0x00398B48
		private void __callDele_EventOnSoundVolumeChanged(float obj)
		{
			Action<float> eventOnSoundVolumeChanged = this.EventOnSoundVolumeChanged;
			if (eventOnSoundVolumeChanged != null)
			{
				eventOnSoundVolumeChanged(obj);
			}
		}

		// Token: 0x0600D314 RID: 54036 RVA: 0x0039A96C File Offset: 0x00398B6C
		private void __clearDele_EventOnSoundVolumeChanged(float obj)
		{
			this.EventOnSoundVolumeChanged = null;
		}

		// Token: 0x0600D315 RID: 54037 RVA: 0x0039A978 File Offset: 0x00398B78
		private void __callDele_EventOnVoiceVolumeChanged(float obj)
		{
			Action<float> eventOnVoiceVolumeChanged = this.EventOnVoiceVolumeChanged;
			if (eventOnVoiceVolumeChanged != null)
			{
				eventOnVoiceVolumeChanged(obj);
			}
		}

		// Token: 0x0600D316 RID: 54038 RVA: 0x0039A99C File Offset: 0x00398B9C
		private void __clearDele_EventOnVoiceVolumeChanged(float obj)
		{
			this.EventOnVoiceVolumeChanged = null;
		}

		// Token: 0x0600D317 RID: 54039 RVA: 0x0039A9A8 File Offset: 0x00398BA8
		private void __callDele_EventOnPowerSaveModeIsOn(bool obj)
		{
			Action<bool> eventOnPowerSaveModeIsOn = this.EventOnPowerSaveModeIsOn;
			if (eventOnPowerSaveModeIsOn != null)
			{
				eventOnPowerSaveModeIsOn(obj);
			}
		}

		// Token: 0x0600D318 RID: 54040 RVA: 0x0039A9CC File Offset: 0x00398BCC
		private void __clearDele_EventOnPowerSaveModeIsOn(bool obj)
		{
			this.EventOnPowerSaveModeIsOn = null;
		}

		// Token: 0x0600D319 RID: 54041 RVA: 0x0039A9D8 File Offset: 0x00398BD8
		private void __callDele_EventOnEndActionIsOn(bool obj)
		{
			Action<bool> eventOnEndActionIsOn = this.EventOnEndActionIsOn;
			if (eventOnEndActionIsOn != null)
			{
				eventOnEndActionIsOn(obj);
			}
		}

		// Token: 0x0600D31A RID: 54042 RVA: 0x0039A9FC File Offset: 0x00398BFC
		private void __clearDele_EventOnEndActionIsOn(bool obj)
		{
			this.EventOnEndActionIsOn = null;
		}

		// Token: 0x0600D31B RID: 54043 RVA: 0x0039AA08 File Offset: 0x00398C08
		private void __callDele_EventOnNotifyRecoveryEnergyIsOn(bool obj)
		{
			Action<bool> eventOnNotifyRecoveryEnergyIsOn = this.EventOnNotifyRecoveryEnergyIsOn;
			if (eventOnNotifyRecoveryEnergyIsOn != null)
			{
				eventOnNotifyRecoveryEnergyIsOn(obj);
			}
		}

		// Token: 0x0600D31C RID: 54044 RVA: 0x0039AA2C File Offset: 0x00398C2C
		private void __clearDele_EventOnNotifyRecoveryEnergyIsOn(bool obj)
		{
			this.EventOnNotifyRecoveryEnergyIsOn = null;
		}

		// Token: 0x0600D31D RID: 54045 RVA: 0x0039AA38 File Offset: 0x00398C38
		private void __callDele_EventOnNotifyRandomEventIsOn(bool obj)
		{
			Action<bool> eventOnNotifyRandomEventIsOn = this.EventOnNotifyRandomEventIsOn;
			if (eventOnNotifyRandomEventIsOn != null)
			{
				eventOnNotifyRandomEventIsOn(obj);
			}
		}

		// Token: 0x0600D31E RID: 54046 RVA: 0x0039AA5C File Offset: 0x00398C5C
		private void __clearDele_EventOnNotifyRandomEventIsOn(bool obj)
		{
			this.EventOnNotifyRandomEventIsOn = null;
		}

		// Token: 0x0600D31F RID: 54047 RVA: 0x0039AA68 File Offset: 0x00398C68
		private void __callDele_EventOnNotifyArenaTicketIsOn(bool obj)
		{
			Action<bool> eventOnNotifyArenaTicketIsOn = this.EventOnNotifyArenaTicketIsOn;
			if (eventOnNotifyArenaTicketIsOn != null)
			{
				eventOnNotifyArenaTicketIsOn(obj);
			}
		}

		// Token: 0x0600D320 RID: 54048 RVA: 0x0039AA8C File Offset: 0x00398C8C
		private void __clearDele_EventOnNotifyArenaTicketIsOn(bool obj)
		{
			this.EventOnNotifyArenaTicketIsOn = null;
		}

		// Token: 0x0600D321 RID: 54049 RVA: 0x0039AA98 File Offset: 0x00398C98
		private void __callDele_EventOnNotifyStoreRefreshIsOn(bool obj)
		{
			Action<bool> eventOnNotifyStoreRefreshIsOn = this.EventOnNotifyStoreRefreshIsOn;
			if (eventOnNotifyStoreRefreshIsOn != null)
			{
				eventOnNotifyStoreRefreshIsOn(obj);
			}
		}

		// Token: 0x0600D322 RID: 54050 RVA: 0x0039AABC File Offset: 0x00398CBC
		private void __clearDele_EventOnNotifyStoreRefreshIsOn(bool obj)
		{
			this.EventOnNotifyStoreRefreshIsOn = null;
		}

		// Token: 0x0600D323 RID: 54051 RVA: 0x0039AAC8 File Offset: 0x00398CC8
		private void __callDele_EventOnSetBattleAnimationMode(SkipCombatMode obj)
		{
			Action<SkipCombatMode> eventOnSetBattleAnimationMode = this.EventOnSetBattleAnimationMode;
			if (eventOnSetBattleAnimationMode != null)
			{
				eventOnSetBattleAnimationMode(obj);
			}
		}

		// Token: 0x0600D324 RID: 54052 RVA: 0x0039AAEC File Offset: 0x00398CEC
		private void __clearDele_EventOnSetBattleAnimationMode(SkipCombatMode obj)
		{
			this.EventOnSetBattleAnimationMode = null;
		}

		// Token: 0x0600D325 RID: 54053 RVA: 0x0039AAF8 File Offset: 0x00398CF8
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D326 RID: 54054 RVA: 0x0039AB18 File Offset: 0x00398D18
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D328 RID: 54056 RVA: 0x0039AB3C File Offset: 0x00398D3C
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
					this.m_SettingPanelShow_hotfix = (luaObj.RawGet("SettingPanelShow") as LuaFunction);
					this.m_OnSettingPanelCloseButtonClick_hotfix = (luaObj.RawGet("OnSettingPanelCloseButtonClick") as LuaFunction);
					this.m_UpdateSettingPanel_hotfix = (luaObj.RawGet("UpdateSettingPanel") as LuaFunction);
					this.m_OnMusicVolumeValueChangedSingle_hotfix = (luaObj.RawGet("OnMusicVolumeValueChanged") as LuaFunction);
					this.m_OnSoundVolumeValueChangedSingle_hotfix = (luaObj.RawGet("OnSoundVolumeValueChanged") as LuaFunction);
					this.m_OnVoiceVolumeValueChangedSingle_hotfix = (luaObj.RawGet("OnVoiceVolumeValueChanged") as LuaFunction);
					this.m_OnPowerSaveModeToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnPowerSaveModeToggleValueChanged") as LuaFunction);
					this.m_OnEndActionToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnEndActionToggleValueChanged") as LuaFunction);
					this.m_OnRecoveryEnergyToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnRecoveryEnergyToggleValueChanged") as LuaFunction);
					this.m_OnRandomEventToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnRandomEventToggleValueChanged") as LuaFunction);
					this.m_OnArenaTicketToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnArenaTicketToggleValueChanged") as LuaFunction);
					this.m_OnStoreRefreshToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnStoreRefreshToggleValueChanged") as LuaFunction);
					this.m_SetBattleAnimationOnBoolean_hotfix = (luaObj.RawGet("SetBattleAnimationOn") as LuaFunction);
					this.m_SetBattleAnimationOffBoolean_hotfix = (luaObj.RawGet("SetBattleAnimationOff") as LuaFunction);
					this.m_SetBattleAnimationOnlyMineBoolean_hotfix = (luaObj.RawGet("SetBattleAnimationOnlyMine") as LuaFunction);
					this.m_OnBattleAnimationOffButtonClick_hotfix = (luaObj.RawGet("OnBattleAnimationOffButtonClick") as LuaFunction);
					this.m_OnBattleAnimationOnlyMineButtonClick_hotfix = (luaObj.RawGet("OnBattleAnimationOnlyMineButtonClick") as LuaFunction);
					this.m_add_EventOnMusicVolumeChangedAction`1_hotfix = (luaObj.RawGet("add_EventOnMusicVolumeChanged") as LuaFunction);
					this.m_remove_EventOnMusicVolumeChangedAction`1_hotfix = (luaObj.RawGet("remove_EventOnMusicVolumeChanged") as LuaFunction);
					this.m_add_EventOnSoundVolumeChangedAction`1_hotfix = (luaObj.RawGet("add_EventOnSoundVolumeChanged") as LuaFunction);
					this.m_remove_EventOnSoundVolumeChangedAction`1_hotfix = (luaObj.RawGet("remove_EventOnSoundVolumeChanged") as LuaFunction);
					this.m_add_EventOnVoiceVolumeChangedAction`1_hotfix = (luaObj.RawGet("add_EventOnVoiceVolumeChanged") as LuaFunction);
					this.m_remove_EventOnVoiceVolumeChangedAction`1_hotfix = (luaObj.RawGet("remove_EventOnVoiceVolumeChanged") as LuaFunction);
					this.m_add_EventOnPowerSaveModeIsOnAction`1_hotfix = (luaObj.RawGet("add_EventOnPowerSaveModeIsOn") as LuaFunction);
					this.m_remove_EventOnPowerSaveModeIsOnAction`1_hotfix = (luaObj.RawGet("remove_EventOnPowerSaveModeIsOn") as LuaFunction);
					this.m_add_EventOnEndActionIsOnAction`1_hotfix = (luaObj.RawGet("add_EventOnEndActionIsOn") as LuaFunction);
					this.m_remove_EventOnEndActionIsOnAction`1_hotfix = (luaObj.RawGet("remove_EventOnEndActionIsOn") as LuaFunction);
					this.m_add_EventOnNotifyRecoveryEnergyIsOnAction`1_hotfix = (luaObj.RawGet("add_EventOnNotifyRecoveryEnergyIsOn") as LuaFunction);
					this.m_remove_EventOnNotifyRecoveryEnergyIsOnAction`1_hotfix = (luaObj.RawGet("remove_EventOnNotifyRecoveryEnergyIsOn") as LuaFunction);
					this.m_add_EventOnNotifyRandomEventIsOnAction`1_hotfix = (luaObj.RawGet("add_EventOnNotifyRandomEventIsOn") as LuaFunction);
					this.m_remove_EventOnNotifyRandomEventIsOnAction`1_hotfix = (luaObj.RawGet("remove_EventOnNotifyRandomEventIsOn") as LuaFunction);
					this.m_add_EventOnNotifyArenaTicketIsOnAction`1_hotfix = (luaObj.RawGet("add_EventOnNotifyArenaTicketIsOn") as LuaFunction);
					this.m_remove_EventOnNotifyArenaTicketIsOnAction`1_hotfix = (luaObj.RawGet("remove_EventOnNotifyArenaTicketIsOn") as LuaFunction);
					this.m_add_EventOnNotifyStoreRefreshIsOnAction`1_hotfix = (luaObj.RawGet("add_EventOnNotifyStoreRefreshIsOn") as LuaFunction);
					this.m_remove_EventOnNotifyStoreRefreshIsOnAction`1_hotfix = (luaObj.RawGet("remove_EventOnNotifyStoreRefreshIsOn") as LuaFunction);
					this.m_add_EventOnSetBattleAnimationModeAction`1_hotfix = (luaObj.RawGet("add_EventOnSetBattleAnimationMode") as LuaFunction);
					this.m_remove_EventOnSetBattleAnimationModeAction`1_hotfix = (luaObj.RawGet("remove_EventOnSetBattleAnimationMode") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D329 RID: 54057 RVA: 0x0039AFD8 File Offset: 0x003991D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerSettingUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040082A6 RID: 33446
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_settingStateCtrl;

		// Token: 0x040082A7 RID: 33447
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_settingPanelBGButton;

		// Token: 0x040082A8 RID: 33448
		[AutoBind("./DetailPanel/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_settingPanelCloseButton;

		// Token: 0x040082A9 RID: 33449
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/BGM/Slider", AutoBindAttribute.InitState.NotInit, false)]
		private Slider m_musicVolumeSlider;

		// Token: 0x040082AA RID: 33450
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/Sound/Slider", AutoBindAttribute.InitState.NotInit, false)]
		private Slider m_soundVolumeSlider;

		// Token: 0x040082AB RID: 33451
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/Voice/Slider", AutoBindAttribute.InitState.NotInit, false)]
		private Slider m_voiceVolumeSlider;

		// Token: 0x040082AC RID: 33452
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/BGM/SoundOnImage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_musicSoundOnState;

		// Token: 0x040082AD RID: 33453
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/BGM/SoundOffImage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_musicSoundOffState;

		// Token: 0x040082AE RID: 33454
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/Sound/SoundOnImage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soundSoundOnState;

		// Token: 0x040082AF RID: 33455
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/Sound/SoundOffImage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soundSoundOffState;

		// Token: 0x040082B0 RID: 33456
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/Voice/SoundOnImage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_voiceSoundOnState;

		// Token: 0x040082B1 RID: 33457
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/Voice/SoundOffImage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_voiceSoundOffState;

		// Token: 0x040082B2 RID: 33458
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/PowerSave/ToggleGroup/OnToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_powerSaveModeOnToggle;

		// Token: 0x040082B3 RID: 33459
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BasicSettingGroup/PowerSave/ToggleGroup/OffToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_powerSaveModeOffToggle;

		// Token: 0x040082B4 RID: 33460
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BattleSettingGroup/EndAction/ToggleGroup/OnToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_endActionOnToggle;

		// Token: 0x040082B5 RID: 33461
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BattleSettingGroup/EndAction/ToggleGroup/OffToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_endActionOffToggle;

		// Token: 0x040082B6 RID: 33462
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/NoticeSettingGroup/RecoveryEnergy/ToggleGroup/OnToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_recoveryEnergyOnToggle;

		// Token: 0x040082B7 RID: 33463
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/NoticeSettingGroup/RecoveryEnergy/ToggleGroup/OffToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_recoveryEnergyOffToggle;

		// Token: 0x040082B8 RID: 33464
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/NoticeSettingGroup/ArenaTicket/ToggleGroup/OnToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_arenaTicketOnToggle;

		// Token: 0x040082B9 RID: 33465
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/NoticeSettingGroup/ArenaTicket/ToggleGroup/OffToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_arenaTicketOffToggle;

		// Token: 0x040082BA RID: 33466
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/NoticeSettingGroup/StoreRefresh/ToggleGroup/OnToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_storeRefreshOnToggle;

		// Token: 0x040082BB RID: 33467
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/NoticeSettingGroup/StoreRefresh/ToggleGroup/OffToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_storeRefreshOffToggle;

		// Token: 0x040082BC RID: 33468
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BattleSettingGroup/BattleAnimation/ToggleGroup/OnToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_battleAnimationOnToggle;

		// Token: 0x040082BD RID: 33469
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BattleSettingGroup/BattleAnimation/ToggleGroup/OffToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_battleAnimationOffToggle;

		// Token: 0x040082BE RID: 33470
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BattleSettingGroup/BattleAnimation/OffButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_battleAnimationOffButton;

		// Token: 0x040082BF RID: 33471
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BattleSettingGroup/BattleAnimation/ToggleGroup/OnlyMine", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_battleAnimationOnlyMineToggle;

		// Token: 0x040082C0 RID: 33472
		[AutoBind("./DetailPanel/ScrollView/Viewport/Content/BattleSettingGroup/BattleAnimation/OnlyMineButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_battleAnimationOnlyMineButton;

		// Token: 0x040082C1 RID: 33473
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x040082C2 RID: 33474
		private bool m_isIgnoreToggleEvent;

		// Token: 0x040082C3 RID: 33475
		[DoNotToLua]
		private PlayerSettingUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040082C4 RID: 33476
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040082C5 RID: 33477
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040082C6 RID: 33478
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040082C7 RID: 33479
		private LuaFunction m_SettingPanelShow_hotfix;

		// Token: 0x040082C8 RID: 33480
		private LuaFunction m_OnSettingPanelCloseButtonClick_hotfix;

		// Token: 0x040082C9 RID: 33481
		private LuaFunction m_UpdateSettingPanel_hotfix;

		// Token: 0x040082CA RID: 33482
		private LuaFunction m_OnMusicVolumeValueChangedSingle_hotfix;

		// Token: 0x040082CB RID: 33483
		private LuaFunction m_OnSoundVolumeValueChangedSingle_hotfix;

		// Token: 0x040082CC RID: 33484
		private LuaFunction m_OnVoiceVolumeValueChangedSingle_hotfix;

		// Token: 0x040082CD RID: 33485
		private LuaFunction m_OnPowerSaveModeToggleValueChangedBoolean_hotfix;

		// Token: 0x040082CE RID: 33486
		private LuaFunction m_OnEndActionToggleValueChangedBoolean_hotfix;

		// Token: 0x040082CF RID: 33487
		private LuaFunction m_OnRecoveryEnergyToggleValueChangedBoolean_hotfix;

		// Token: 0x040082D0 RID: 33488
		private LuaFunction m_OnRandomEventToggleValueChangedBoolean_hotfix;

		// Token: 0x040082D1 RID: 33489
		private LuaFunction m_OnArenaTicketToggleValueChangedBoolean_hotfix;

		// Token: 0x040082D2 RID: 33490
		private LuaFunction m_OnStoreRefreshToggleValueChangedBoolean_hotfix;

		// Token: 0x040082D3 RID: 33491
		private LuaFunction m_SetBattleAnimationOnBoolean_hotfix;

		// Token: 0x040082D4 RID: 33492
		private LuaFunction m_SetBattleAnimationOffBoolean_hotfix;

		// Token: 0x040082D5 RID: 33493
		private LuaFunction m_SetBattleAnimationOnlyMineBoolean_hotfix;

		// Token: 0x040082D6 RID: 33494
		private LuaFunction m_OnBattleAnimationOffButtonClick_hotfix;

		// Token: 0x040082D7 RID: 33495
		private LuaFunction m_OnBattleAnimationOnlyMineButtonClick_hotfix;

		// Token: 0x040082D8 RID: 33496
		private LuaFunction m_add_EventOnMusicVolumeChangedAction;

		// Token: 0x040082D9 RID: 33497
		private LuaFunction m_remove_EventOnMusicVolumeChangedAction;

		// Token: 0x040082DA RID: 33498
		private LuaFunction m_add_EventOnSoundVolumeChangedAction;

		// Token: 0x040082DB RID: 33499
		private LuaFunction m_remove_EventOnSoundVolumeChangedAction;

		// Token: 0x040082DC RID: 33500
		private LuaFunction m_add_EventOnVoiceVolumeChangedAction;

		// Token: 0x040082DD RID: 33501
		private LuaFunction m_remove_EventOnVoiceVolumeChangedAction;

		// Token: 0x040082DE RID: 33502
		private LuaFunction m_add_EventOnPowerSaveModeIsOnAction;

		// Token: 0x040082DF RID: 33503
		private LuaFunction m_remove_EventOnPowerSaveModeIsOnAction;

		// Token: 0x040082E0 RID: 33504
		private LuaFunction m_add_EventOnEndActionIsOnAction;

		// Token: 0x040082E1 RID: 33505
		private LuaFunction m_remove_EventOnEndActionIsOnAction;

		// Token: 0x040082E2 RID: 33506
		private LuaFunction m_add_EventOnNotifyRecoveryEnergyIsOnAction;

		// Token: 0x040082E3 RID: 33507
		private LuaFunction m_remove_EventOnNotifyRecoveryEnergyIsOnAction;

		// Token: 0x040082E4 RID: 33508
		private LuaFunction m_add_EventOnNotifyRandomEventIsOnAction;

		// Token: 0x040082E5 RID: 33509
		private LuaFunction m_remove_EventOnNotifyRandomEventIsOnAction;

		// Token: 0x040082E6 RID: 33510
		private LuaFunction m_add_EventOnNotifyArenaTicketIsOnAction;

		// Token: 0x040082E7 RID: 33511
		private LuaFunction m_remove_EventOnNotifyArenaTicketIsOnAction;

		// Token: 0x040082E8 RID: 33512
		private LuaFunction m_add_EventOnNotifyStoreRefreshIsOnAction;

		// Token: 0x040082E9 RID: 33513
		private LuaFunction m_remove_EventOnNotifyStoreRefreshIsOnAction;

		// Token: 0x040082EA RID: 33514
		private LuaFunction m_add_EventOnSetBattleAnimationModeAction;

		// Token: 0x040082EB RID: 33515
		private LuaFunction m_remove_EventOnSetBattleAnimationModeAction;

		// Token: 0x040082EC RID: 33516
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040082ED RID: 33517
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000BE7 RID: 3047
		public new class LuaExportHelper
		{
			// Token: 0x0600D32A RID: 54058 RVA: 0x0039B040 File Offset: 0x00399240
			public LuaExportHelper(PlayerSettingUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D32B RID: 54059 RVA: 0x0039B050 File Offset: 0x00399250
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D32C RID: 54060 RVA: 0x0039B060 File Offset: 0x00399260
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D32D RID: 54061 RVA: 0x0039B070 File Offset: 0x00399270
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D32E RID: 54062 RVA: 0x0039B080 File Offset: 0x00399280
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D32F RID: 54063 RVA: 0x0039B098 File Offset: 0x00399298
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D330 RID: 54064 RVA: 0x0039B0A8 File Offset: 0x003992A8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D331 RID: 54065 RVA: 0x0039B0B8 File Offset: 0x003992B8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D332 RID: 54066 RVA: 0x0039B0C8 File Offset: 0x003992C8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D333 RID: 54067 RVA: 0x0039B0D8 File Offset: 0x003992D8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D334 RID: 54068 RVA: 0x0039B0E8 File Offset: 0x003992E8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D335 RID: 54069 RVA: 0x0039B0F8 File Offset: 0x003992F8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D336 RID: 54070 RVA: 0x0039B108 File Offset: 0x00399308
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D337 RID: 54071 RVA: 0x0039B118 File Offset: 0x00399318
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D338 RID: 54072 RVA: 0x0039B128 File Offset: 0x00399328
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D339 RID: 54073 RVA: 0x0039B138 File Offset: 0x00399338
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D33A RID: 54074 RVA: 0x0039B148 File Offset: 0x00399348
			public void __callDele_EventOnMusicVolumeChanged(float obj)
			{
				this.m_owner.__callDele_EventOnMusicVolumeChanged(obj);
			}

			// Token: 0x0600D33B RID: 54075 RVA: 0x0039B158 File Offset: 0x00399358
			public void __clearDele_EventOnMusicVolumeChanged(float obj)
			{
				this.m_owner.__clearDele_EventOnMusicVolumeChanged(obj);
			}

			// Token: 0x0600D33C RID: 54076 RVA: 0x0039B168 File Offset: 0x00399368
			public void __callDele_EventOnSoundVolumeChanged(float obj)
			{
				this.m_owner.__callDele_EventOnSoundVolumeChanged(obj);
			}

			// Token: 0x0600D33D RID: 54077 RVA: 0x0039B178 File Offset: 0x00399378
			public void __clearDele_EventOnSoundVolumeChanged(float obj)
			{
				this.m_owner.__clearDele_EventOnSoundVolumeChanged(obj);
			}

			// Token: 0x0600D33E RID: 54078 RVA: 0x0039B188 File Offset: 0x00399388
			public void __callDele_EventOnVoiceVolumeChanged(float obj)
			{
				this.m_owner.__callDele_EventOnVoiceVolumeChanged(obj);
			}

			// Token: 0x0600D33F RID: 54079 RVA: 0x0039B198 File Offset: 0x00399398
			public void __clearDele_EventOnVoiceVolumeChanged(float obj)
			{
				this.m_owner.__clearDele_EventOnVoiceVolumeChanged(obj);
			}

			// Token: 0x0600D340 RID: 54080 RVA: 0x0039B1A8 File Offset: 0x003993A8
			public void __callDele_EventOnPowerSaveModeIsOn(bool obj)
			{
				this.m_owner.__callDele_EventOnPowerSaveModeIsOn(obj);
			}

			// Token: 0x0600D341 RID: 54081 RVA: 0x0039B1B8 File Offset: 0x003993B8
			public void __clearDele_EventOnPowerSaveModeIsOn(bool obj)
			{
				this.m_owner.__clearDele_EventOnPowerSaveModeIsOn(obj);
			}

			// Token: 0x0600D342 RID: 54082 RVA: 0x0039B1C8 File Offset: 0x003993C8
			public void __callDele_EventOnEndActionIsOn(bool obj)
			{
				this.m_owner.__callDele_EventOnEndActionIsOn(obj);
			}

			// Token: 0x0600D343 RID: 54083 RVA: 0x0039B1D8 File Offset: 0x003993D8
			public void __clearDele_EventOnEndActionIsOn(bool obj)
			{
				this.m_owner.__clearDele_EventOnEndActionIsOn(obj);
			}

			// Token: 0x0600D344 RID: 54084 RVA: 0x0039B1E8 File Offset: 0x003993E8
			public void __callDele_EventOnNotifyRecoveryEnergyIsOn(bool obj)
			{
				this.m_owner.__callDele_EventOnNotifyRecoveryEnergyIsOn(obj);
			}

			// Token: 0x0600D345 RID: 54085 RVA: 0x0039B1F8 File Offset: 0x003993F8
			public void __clearDele_EventOnNotifyRecoveryEnergyIsOn(bool obj)
			{
				this.m_owner.__clearDele_EventOnNotifyRecoveryEnergyIsOn(obj);
			}

			// Token: 0x0600D346 RID: 54086 RVA: 0x0039B208 File Offset: 0x00399408
			public void __callDele_EventOnNotifyRandomEventIsOn(bool obj)
			{
				this.m_owner.__callDele_EventOnNotifyRandomEventIsOn(obj);
			}

			// Token: 0x0600D347 RID: 54087 RVA: 0x0039B218 File Offset: 0x00399418
			public void __clearDele_EventOnNotifyRandomEventIsOn(bool obj)
			{
				this.m_owner.__clearDele_EventOnNotifyRandomEventIsOn(obj);
			}

			// Token: 0x0600D348 RID: 54088 RVA: 0x0039B228 File Offset: 0x00399428
			public void __callDele_EventOnNotifyArenaTicketIsOn(bool obj)
			{
				this.m_owner.__callDele_EventOnNotifyArenaTicketIsOn(obj);
			}

			// Token: 0x0600D349 RID: 54089 RVA: 0x0039B238 File Offset: 0x00399438
			public void __clearDele_EventOnNotifyArenaTicketIsOn(bool obj)
			{
				this.m_owner.__clearDele_EventOnNotifyArenaTicketIsOn(obj);
			}

			// Token: 0x0600D34A RID: 54090 RVA: 0x0039B248 File Offset: 0x00399448
			public void __callDele_EventOnNotifyStoreRefreshIsOn(bool obj)
			{
				this.m_owner.__callDele_EventOnNotifyStoreRefreshIsOn(obj);
			}

			// Token: 0x0600D34B RID: 54091 RVA: 0x0039B258 File Offset: 0x00399458
			public void __clearDele_EventOnNotifyStoreRefreshIsOn(bool obj)
			{
				this.m_owner.__clearDele_EventOnNotifyStoreRefreshIsOn(obj);
			}

			// Token: 0x0600D34C RID: 54092 RVA: 0x0039B268 File Offset: 0x00399468
			public void __callDele_EventOnSetBattleAnimationMode(SkipCombatMode obj)
			{
				this.m_owner.__callDele_EventOnSetBattleAnimationMode(obj);
			}

			// Token: 0x0600D34D RID: 54093 RVA: 0x0039B278 File Offset: 0x00399478
			public void __clearDele_EventOnSetBattleAnimationMode(SkipCombatMode obj)
			{
				this.m_owner.__clearDele_EventOnSetBattleAnimationMode(obj);
			}

			// Token: 0x0600D34E RID: 54094 RVA: 0x0039B288 File Offset: 0x00399488
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D34F RID: 54095 RVA: 0x0039B298 File Offset: 0x00399498
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002961 RID: 10593
			// (get) Token: 0x0600D350 RID: 54096 RVA: 0x0039B2A8 File Offset: 0x003994A8
			// (set) Token: 0x0600D351 RID: 54097 RVA: 0x0039B2B8 File Offset: 0x003994B8
			public CommonUIStateController m_settingStateCtrl
			{
				get
				{
					return this.m_owner.m_settingStateCtrl;
				}
				set
				{
					this.m_owner.m_settingStateCtrl = value;
				}
			}

			// Token: 0x17002962 RID: 10594
			// (get) Token: 0x0600D352 RID: 54098 RVA: 0x0039B2C8 File Offset: 0x003994C8
			// (set) Token: 0x0600D353 RID: 54099 RVA: 0x0039B2D8 File Offset: 0x003994D8
			public Button m_settingPanelBGButton
			{
				get
				{
					return this.m_owner.m_settingPanelBGButton;
				}
				set
				{
					this.m_owner.m_settingPanelBGButton = value;
				}
			}

			// Token: 0x17002963 RID: 10595
			// (get) Token: 0x0600D354 RID: 54100 RVA: 0x0039B2E8 File Offset: 0x003994E8
			// (set) Token: 0x0600D355 RID: 54101 RVA: 0x0039B2F8 File Offset: 0x003994F8
			public Button m_settingPanelCloseButton
			{
				get
				{
					return this.m_owner.m_settingPanelCloseButton;
				}
				set
				{
					this.m_owner.m_settingPanelCloseButton = value;
				}
			}

			// Token: 0x17002964 RID: 10596
			// (get) Token: 0x0600D356 RID: 54102 RVA: 0x0039B308 File Offset: 0x00399508
			// (set) Token: 0x0600D357 RID: 54103 RVA: 0x0039B318 File Offset: 0x00399518
			public Slider m_musicVolumeSlider
			{
				get
				{
					return this.m_owner.m_musicVolumeSlider;
				}
				set
				{
					this.m_owner.m_musicVolumeSlider = value;
				}
			}

			// Token: 0x17002965 RID: 10597
			// (get) Token: 0x0600D358 RID: 54104 RVA: 0x0039B328 File Offset: 0x00399528
			// (set) Token: 0x0600D359 RID: 54105 RVA: 0x0039B338 File Offset: 0x00399538
			public Slider m_soundVolumeSlider
			{
				get
				{
					return this.m_owner.m_soundVolumeSlider;
				}
				set
				{
					this.m_owner.m_soundVolumeSlider = value;
				}
			}

			// Token: 0x17002966 RID: 10598
			// (get) Token: 0x0600D35A RID: 54106 RVA: 0x0039B348 File Offset: 0x00399548
			// (set) Token: 0x0600D35B RID: 54107 RVA: 0x0039B358 File Offset: 0x00399558
			public Slider m_voiceVolumeSlider
			{
				get
				{
					return this.m_owner.m_voiceVolumeSlider;
				}
				set
				{
					this.m_owner.m_voiceVolumeSlider = value;
				}
			}

			// Token: 0x17002967 RID: 10599
			// (get) Token: 0x0600D35C RID: 54108 RVA: 0x0039B368 File Offset: 0x00399568
			// (set) Token: 0x0600D35D RID: 54109 RVA: 0x0039B378 File Offset: 0x00399578
			public CommonUIStateController m_musicSoundOnState
			{
				get
				{
					return this.m_owner.m_musicSoundOnState;
				}
				set
				{
					this.m_owner.m_musicSoundOnState = value;
				}
			}

			// Token: 0x17002968 RID: 10600
			// (get) Token: 0x0600D35E RID: 54110 RVA: 0x0039B388 File Offset: 0x00399588
			// (set) Token: 0x0600D35F RID: 54111 RVA: 0x0039B398 File Offset: 0x00399598
			public CommonUIStateController m_musicSoundOffState
			{
				get
				{
					return this.m_owner.m_musicSoundOffState;
				}
				set
				{
					this.m_owner.m_musicSoundOffState = value;
				}
			}

			// Token: 0x17002969 RID: 10601
			// (get) Token: 0x0600D360 RID: 54112 RVA: 0x0039B3A8 File Offset: 0x003995A8
			// (set) Token: 0x0600D361 RID: 54113 RVA: 0x0039B3B8 File Offset: 0x003995B8
			public CommonUIStateController m_soundSoundOnState
			{
				get
				{
					return this.m_owner.m_soundSoundOnState;
				}
				set
				{
					this.m_owner.m_soundSoundOnState = value;
				}
			}

			// Token: 0x1700296A RID: 10602
			// (get) Token: 0x0600D362 RID: 54114 RVA: 0x0039B3C8 File Offset: 0x003995C8
			// (set) Token: 0x0600D363 RID: 54115 RVA: 0x0039B3D8 File Offset: 0x003995D8
			public CommonUIStateController m_soundSoundOffState
			{
				get
				{
					return this.m_owner.m_soundSoundOffState;
				}
				set
				{
					this.m_owner.m_soundSoundOffState = value;
				}
			}

			// Token: 0x1700296B RID: 10603
			// (get) Token: 0x0600D364 RID: 54116 RVA: 0x0039B3E8 File Offset: 0x003995E8
			// (set) Token: 0x0600D365 RID: 54117 RVA: 0x0039B3F8 File Offset: 0x003995F8
			public CommonUIStateController m_voiceSoundOnState
			{
				get
				{
					return this.m_owner.m_voiceSoundOnState;
				}
				set
				{
					this.m_owner.m_voiceSoundOnState = value;
				}
			}

			// Token: 0x1700296C RID: 10604
			// (get) Token: 0x0600D366 RID: 54118 RVA: 0x0039B408 File Offset: 0x00399608
			// (set) Token: 0x0600D367 RID: 54119 RVA: 0x0039B418 File Offset: 0x00399618
			public CommonUIStateController m_voiceSoundOffState
			{
				get
				{
					return this.m_owner.m_voiceSoundOffState;
				}
				set
				{
					this.m_owner.m_voiceSoundOffState = value;
				}
			}

			// Token: 0x1700296D RID: 10605
			// (get) Token: 0x0600D368 RID: 54120 RVA: 0x0039B428 File Offset: 0x00399628
			// (set) Token: 0x0600D369 RID: 54121 RVA: 0x0039B438 File Offset: 0x00399638
			public Toggle m_powerSaveModeOnToggle
			{
				get
				{
					return this.m_owner.m_powerSaveModeOnToggle;
				}
				set
				{
					this.m_owner.m_powerSaveModeOnToggle = value;
				}
			}

			// Token: 0x1700296E RID: 10606
			// (get) Token: 0x0600D36A RID: 54122 RVA: 0x0039B448 File Offset: 0x00399648
			// (set) Token: 0x0600D36B RID: 54123 RVA: 0x0039B458 File Offset: 0x00399658
			public Toggle m_powerSaveModeOffToggle
			{
				get
				{
					return this.m_owner.m_powerSaveModeOffToggle;
				}
				set
				{
					this.m_owner.m_powerSaveModeOffToggle = value;
				}
			}

			// Token: 0x1700296F RID: 10607
			// (get) Token: 0x0600D36C RID: 54124 RVA: 0x0039B468 File Offset: 0x00399668
			// (set) Token: 0x0600D36D RID: 54125 RVA: 0x0039B478 File Offset: 0x00399678
			public Toggle m_endActionOnToggle
			{
				get
				{
					return this.m_owner.m_endActionOnToggle;
				}
				set
				{
					this.m_owner.m_endActionOnToggle = value;
				}
			}

			// Token: 0x17002970 RID: 10608
			// (get) Token: 0x0600D36E RID: 54126 RVA: 0x0039B488 File Offset: 0x00399688
			// (set) Token: 0x0600D36F RID: 54127 RVA: 0x0039B498 File Offset: 0x00399698
			public Toggle m_endActionOffToggle
			{
				get
				{
					return this.m_owner.m_endActionOffToggle;
				}
				set
				{
					this.m_owner.m_endActionOffToggle = value;
				}
			}

			// Token: 0x17002971 RID: 10609
			// (get) Token: 0x0600D370 RID: 54128 RVA: 0x0039B4A8 File Offset: 0x003996A8
			// (set) Token: 0x0600D371 RID: 54129 RVA: 0x0039B4B8 File Offset: 0x003996B8
			public Toggle m_recoveryEnergyOnToggle
			{
				get
				{
					return this.m_owner.m_recoveryEnergyOnToggle;
				}
				set
				{
					this.m_owner.m_recoveryEnergyOnToggle = value;
				}
			}

			// Token: 0x17002972 RID: 10610
			// (get) Token: 0x0600D372 RID: 54130 RVA: 0x0039B4C8 File Offset: 0x003996C8
			// (set) Token: 0x0600D373 RID: 54131 RVA: 0x0039B4D8 File Offset: 0x003996D8
			public Toggle m_recoveryEnergyOffToggle
			{
				get
				{
					return this.m_owner.m_recoveryEnergyOffToggle;
				}
				set
				{
					this.m_owner.m_recoveryEnergyOffToggle = value;
				}
			}

			// Token: 0x17002973 RID: 10611
			// (get) Token: 0x0600D374 RID: 54132 RVA: 0x0039B4E8 File Offset: 0x003996E8
			// (set) Token: 0x0600D375 RID: 54133 RVA: 0x0039B4F8 File Offset: 0x003996F8
			public Toggle m_arenaTicketOnToggle
			{
				get
				{
					return this.m_owner.m_arenaTicketOnToggle;
				}
				set
				{
					this.m_owner.m_arenaTicketOnToggle = value;
				}
			}

			// Token: 0x17002974 RID: 10612
			// (get) Token: 0x0600D376 RID: 54134 RVA: 0x0039B508 File Offset: 0x00399708
			// (set) Token: 0x0600D377 RID: 54135 RVA: 0x0039B518 File Offset: 0x00399718
			public Toggle m_arenaTicketOffToggle
			{
				get
				{
					return this.m_owner.m_arenaTicketOffToggle;
				}
				set
				{
					this.m_owner.m_arenaTicketOffToggle = value;
				}
			}

			// Token: 0x17002975 RID: 10613
			// (get) Token: 0x0600D378 RID: 54136 RVA: 0x0039B528 File Offset: 0x00399728
			// (set) Token: 0x0600D379 RID: 54137 RVA: 0x0039B538 File Offset: 0x00399738
			public Toggle m_storeRefreshOnToggle
			{
				get
				{
					return this.m_owner.m_storeRefreshOnToggle;
				}
				set
				{
					this.m_owner.m_storeRefreshOnToggle = value;
				}
			}

			// Token: 0x17002976 RID: 10614
			// (get) Token: 0x0600D37A RID: 54138 RVA: 0x0039B548 File Offset: 0x00399748
			// (set) Token: 0x0600D37B RID: 54139 RVA: 0x0039B558 File Offset: 0x00399758
			public Toggle m_storeRefreshOffToggle
			{
				get
				{
					return this.m_owner.m_storeRefreshOffToggle;
				}
				set
				{
					this.m_owner.m_storeRefreshOffToggle = value;
				}
			}

			// Token: 0x17002977 RID: 10615
			// (get) Token: 0x0600D37C RID: 54140 RVA: 0x0039B568 File Offset: 0x00399768
			// (set) Token: 0x0600D37D RID: 54141 RVA: 0x0039B578 File Offset: 0x00399778
			public Toggle m_battleAnimationOnToggle
			{
				get
				{
					return this.m_owner.m_battleAnimationOnToggle;
				}
				set
				{
					this.m_owner.m_battleAnimationOnToggle = value;
				}
			}

			// Token: 0x17002978 RID: 10616
			// (get) Token: 0x0600D37E RID: 54142 RVA: 0x0039B588 File Offset: 0x00399788
			// (set) Token: 0x0600D37F RID: 54143 RVA: 0x0039B598 File Offset: 0x00399798
			public Toggle m_battleAnimationOffToggle
			{
				get
				{
					return this.m_owner.m_battleAnimationOffToggle;
				}
				set
				{
					this.m_owner.m_battleAnimationOffToggle = value;
				}
			}

			// Token: 0x17002979 RID: 10617
			// (get) Token: 0x0600D380 RID: 54144 RVA: 0x0039B5A8 File Offset: 0x003997A8
			// (set) Token: 0x0600D381 RID: 54145 RVA: 0x0039B5B8 File Offset: 0x003997B8
			public Button m_battleAnimationOffButton
			{
				get
				{
					return this.m_owner.m_battleAnimationOffButton;
				}
				set
				{
					this.m_owner.m_battleAnimationOffButton = value;
				}
			}

			// Token: 0x1700297A RID: 10618
			// (get) Token: 0x0600D382 RID: 54146 RVA: 0x0039B5C8 File Offset: 0x003997C8
			// (set) Token: 0x0600D383 RID: 54147 RVA: 0x0039B5D8 File Offset: 0x003997D8
			public Toggle m_battleAnimationOnlyMineToggle
			{
				get
				{
					return this.m_owner.m_battleAnimationOnlyMineToggle;
				}
				set
				{
					this.m_owner.m_battleAnimationOnlyMineToggle = value;
				}
			}

			// Token: 0x1700297B RID: 10619
			// (get) Token: 0x0600D384 RID: 54148 RVA: 0x0039B5E8 File Offset: 0x003997E8
			// (set) Token: 0x0600D385 RID: 54149 RVA: 0x0039B5F8 File Offset: 0x003997F8
			public Button m_battleAnimationOnlyMineButton
			{
				get
				{
					return this.m_owner.m_battleAnimationOnlyMineButton;
				}
				set
				{
					this.m_owner.m_battleAnimationOnlyMineButton = value;
				}
			}

			// Token: 0x1700297C RID: 10620
			// (get) Token: 0x0600D386 RID: 54150 RVA: 0x0039B608 File Offset: 0x00399808
			// (set) Token: 0x0600D387 RID: 54151 RVA: 0x0039B618 File Offset: 0x00399818
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

			// Token: 0x1700297D RID: 10621
			// (get) Token: 0x0600D388 RID: 54152 RVA: 0x0039B628 File Offset: 0x00399828
			// (set) Token: 0x0600D389 RID: 54153 RVA: 0x0039B638 File Offset: 0x00399838
			public bool m_isIgnoreToggleEvent
			{
				get
				{
					return this.m_owner.m_isIgnoreToggleEvent;
				}
				set
				{
					this.m_owner.m_isIgnoreToggleEvent = value;
				}
			}

			// Token: 0x0600D38A RID: 54154 RVA: 0x0039B648 File Offset: 0x00399848
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D38B RID: 54155 RVA: 0x0039B658 File Offset: 0x00399858
			public void OnSettingPanelCloseButtonClick()
			{
				this.m_owner.OnSettingPanelCloseButtonClick();
			}

			// Token: 0x0600D38C RID: 54156 RVA: 0x0039B668 File Offset: 0x00399868
			public void OnMusicVolumeValueChanged(float volumn)
			{
				this.m_owner.OnMusicVolumeValueChanged(volumn);
			}

			// Token: 0x0600D38D RID: 54157 RVA: 0x0039B678 File Offset: 0x00399878
			public void OnSoundVolumeValueChanged(float volumn)
			{
				this.m_owner.OnSoundVolumeValueChanged(volumn);
			}

			// Token: 0x0600D38E RID: 54158 RVA: 0x0039B688 File Offset: 0x00399888
			public void OnVoiceVolumeValueChanged(float volumn)
			{
				this.m_owner.OnVoiceVolumeValueChanged(volumn);
			}

			// Token: 0x0600D38F RID: 54159 RVA: 0x0039B698 File Offset: 0x00399898
			public void OnPowerSaveModeToggleValueChanged(bool isOn)
			{
				this.m_owner.OnPowerSaveModeToggleValueChanged(isOn);
			}

			// Token: 0x0600D390 RID: 54160 RVA: 0x0039B6A8 File Offset: 0x003998A8
			public void OnEndActionToggleValueChanged(bool isOn)
			{
				this.m_owner.OnEndActionToggleValueChanged(isOn);
			}

			// Token: 0x0600D391 RID: 54161 RVA: 0x0039B6B8 File Offset: 0x003998B8
			public void OnRecoveryEnergyToggleValueChanged(bool isOn)
			{
				this.m_owner.OnRecoveryEnergyToggleValueChanged(isOn);
			}

			// Token: 0x0600D392 RID: 54162 RVA: 0x0039B6C8 File Offset: 0x003998C8
			public void OnRandomEventToggleValueChanged(bool isOn)
			{
				this.m_owner.OnRandomEventToggleValueChanged(isOn);
			}

			// Token: 0x0600D393 RID: 54163 RVA: 0x0039B6D8 File Offset: 0x003998D8
			public void OnArenaTicketToggleValueChanged(bool isOn)
			{
				this.m_owner.OnArenaTicketToggleValueChanged(isOn);
			}

			// Token: 0x0600D394 RID: 54164 RVA: 0x0039B6E8 File Offset: 0x003998E8
			public void OnStoreRefreshToggleValueChanged(bool isOn)
			{
				this.m_owner.OnStoreRefreshToggleValueChanged(isOn);
			}

			// Token: 0x0600D395 RID: 54165 RVA: 0x0039B6F8 File Offset: 0x003998F8
			public void SetBattleAnimationOn(bool isOn)
			{
				this.m_owner.SetBattleAnimationOn(isOn);
			}

			// Token: 0x0600D396 RID: 54166 RVA: 0x0039B708 File Offset: 0x00399908
			public void SetBattleAnimationOff(bool isOn)
			{
				this.m_owner.SetBattleAnimationOff(isOn);
			}

			// Token: 0x0600D397 RID: 54167 RVA: 0x0039B718 File Offset: 0x00399918
			public void SetBattleAnimationOnlyMine(bool isOn)
			{
				this.m_owner.SetBattleAnimationOnlyMine(isOn);
			}

			// Token: 0x0600D398 RID: 54168 RVA: 0x0039B728 File Offset: 0x00399928
			public void OnBattleAnimationOffButtonClick()
			{
				this.m_owner.OnBattleAnimationOffButtonClick();
			}

			// Token: 0x0600D399 RID: 54169 RVA: 0x0039B738 File Offset: 0x00399938
			public void OnBattleAnimationOnlyMineButtonClick()
			{
				this.m_owner.OnBattleAnimationOnlyMineButtonClick();
			}

			// Token: 0x040082EE RID: 33518
			private PlayerSettingUIController m_owner;
		}
	}
}
