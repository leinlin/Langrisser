using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BE8 RID: 3048
	[HotFix]
	public class PlayerSettingUITask : UITask
	{
		// Token: 0x0600D39A RID: 54170 RVA: 0x0039B748 File Offset: 0x00399948
		public PlayerSettingUITask(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600D39B RID: 54171 RVA: 0x0039B83C File Offset: 0x00399A3C
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (this.m_playerSettingUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_playerSettingUIController = (this.m_uiCtrlArray[0] as PlayerSettingUIController);
				}
				if (!(this.m_playerSettingUIController != null))
				{
					Debug.LogError("PlayerSettingUIController is null!");
					return;
				}
				this.m_playerSettingUIController.EventOnClose += this.PlayerSettingUIController_OnClose;
				this.m_playerSettingUIController.EventOnMusicVolumeChanged += this.PlayerSettingUIController_OnMusicVolumeChanged;
				this.m_playerSettingUIController.EventOnSoundVolumeChanged += this.PlayerSettingUIController_OnSFXVolumeChanged;
				this.m_playerSettingUIController.EventOnVoiceVolumeChanged += this.PlayerSettingUIController_OnVoiceVolumeChanged;
				this.m_playerSettingUIController.EventOnPowerSaveModeIsOn += this.PlayerSettingUIController_OnPowerSaveModeIsOn;
				this.m_playerSettingUIController.EventOnEndActionIsOn += this.PlayerSettingUIController_OnEndActionIsOn;
				this.m_playerSettingUIController.EventOnNotifyRecoveryEnergyIsOn += this.PlayerSettingUIController_OnNotifyRecoveryEnergyIsOn;
				this.m_playerSettingUIController.EventOnNotifyRandomEventIsOn += this.PlayerSettingUIController_OnNotifyRandomEventIsOn;
				this.m_playerSettingUIController.EventOnNotifyArenaTicketIsOn += this.PlayerSettingUIController_OnNotifyArenaTicketIsOn;
				this.m_playerSettingUIController.EventOnNotifyStoreRefreshIsOn += this.PlayerSettingUIController_OnNotifyStoreRefreshIsOn;
				this.m_playerSettingUIController.EventOnSetBattleAnimationMode += this.PlayerSettingUIController_OnSetBattleAnimationMode;
			}
		}

		// Token: 0x0600D39C RID: 54172 RVA: 0x0039B9F4 File Offset: 0x00399BF4
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_playerSettingUIController != null)
			{
				this.m_playerSettingUIController.EventOnClose -= this.PlayerSettingUIController_OnClose;
				this.m_playerSettingUIController.EventOnMusicVolumeChanged -= this.PlayerSettingUIController_OnMusicVolumeChanged;
				this.m_playerSettingUIController.EventOnSoundVolumeChanged -= this.PlayerSettingUIController_OnSFXVolumeChanged;
				this.m_playerSettingUIController.EventOnVoiceVolumeChanged -= this.PlayerSettingUIController_OnVoiceVolumeChanged;
				this.m_playerSettingUIController.EventOnPowerSaveModeIsOn -= this.PlayerSettingUIController_OnPowerSaveModeIsOn;
				this.m_playerSettingUIController.EventOnEndActionIsOn -= this.PlayerSettingUIController_OnEndActionIsOn;
				this.m_playerSettingUIController.EventOnNotifyRecoveryEnergyIsOn -= this.PlayerSettingUIController_OnNotifyRecoveryEnergyIsOn;
				this.m_playerSettingUIController.EventOnNotifyRandomEventIsOn -= this.PlayerSettingUIController_OnNotifyRandomEventIsOn;
				this.m_playerSettingUIController.EventOnNotifyArenaTicketIsOn -= this.PlayerSettingUIController_OnNotifyArenaTicketIsOn;
				this.m_playerSettingUIController.EventOnNotifyStoreRefreshIsOn -= this.PlayerSettingUIController_OnNotifyStoreRefreshIsOn;
				this.m_playerSettingUIController.EventOnSetBattleAnimationMode -= this.PlayerSettingUIController_OnSetBattleAnimationMode;
				this.m_playerSettingUIController = null;
			}
		}

		// Token: 0x0600D39D RID: 54173 RVA: 0x0039BB70 File Offset: 0x00399D70
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isOpeningUI)
			{
				this.m_playerSettingUIController.SettingPanelShow();
			}
			this.m_playerSettingUIController.UpdateSettingPanel();
		}

		// Token: 0x0600D39E RID: 54174 RVA: 0x0039BBF4 File Offset: 0x00399DF4
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return base.OnStart(intent);
		}

		// Token: 0x0600D39F RID: 54175 RVA: 0x0039BC78 File Offset: 0x00399E78
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnStop();
		}

		// Token: 0x0600D3A0 RID: 54176 RVA: 0x0039BCE0 File Offset: 0x00399EE0
		private void PlayerSettingUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnClose_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
		}

		// Token: 0x0600D3A1 RID: 54177 RVA: 0x0039BD48 File Offset: 0x00399F48
		private void PlayerSettingUIController_OnMusicVolumeChanged(float volume)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnMusicVolumeChangedSingle_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnMusicVolumeChangedSingle_hotfix.call(new object[]
				{
					this,
					volume
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.MusicVolume = volume;
			LocalConfig.Instance.ApplyVolume("Music_VolumeControl", false);
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600D3A2 RID: 54178 RVA: 0x0039BDE4 File Offset: 0x00399FE4
		private void PlayerSettingUIController_OnSFXVolumeChanged(float volume)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnSFXVolumeChangedSingle_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnSFXVolumeChangedSingle_hotfix.call(new object[]
				{
					this,
					volume
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.SoundVolumn = volume;
			LocalConfig.Instance.ApplyVolume("SFX_VolumeControl", false);
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600D3A3 RID: 54179 RVA: 0x0039BE80 File Offset: 0x0039A080
		private void PlayerSettingUIController_OnVoiceVolumeChanged(float volume)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnVoiceVolumeChangedSingle_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnVoiceVolumeChangedSingle_hotfix.call(new object[]
				{
					this,
					volume
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.VoiceVolume = volume;
			LocalConfig.Instance.ApplyVolume("Voice_VolumeControl", false);
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600D3A4 RID: 54180 RVA: 0x0039BF1C File Offset: 0x0039A11C
		private void PlayerSettingUIController_OnBGMIsOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnBGMIsOnBoolean_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnBGMIsOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.MusicOn = isOn;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600D3A5 RID: 54181 RVA: 0x0039BFB4 File Offset: 0x0039A1B4
		private void PlayerSettingUIController_OnSoundIsOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnSoundIsOnBoolean_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnSoundIsOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.SoundOn = isOn;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600D3A6 RID: 54182 RVA: 0x0039C04C File Offset: 0x0039A24C
		private void PlayerSettingUIController_OnVoiceIsOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnVoiceIsOnBoolean_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnVoiceIsOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.VoiceOn = isOn;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600D3A7 RID: 54183 RVA: 0x0039C0E4 File Offset: 0x0039A2E4
		private void PlayerSettingUIController_OnEndActionIsOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnEndActionIsOnBoolean_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnEndActionIsOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.ClickActorEndAction = isOn;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600D3A8 RID: 54184 RVA: 0x0039C17C File Offset: 0x0039A37C
		private void PlayerSettingUIController_OnNotifyRecoveryEnergyIsOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnNotifyRecoveryEnergyIsOnBoolean_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnNotifyRecoveryEnergyIsOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.NotifyEnergyRecover = isOn;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
			LoginUITask.SetLocalPushNotifications();
		}

		// Token: 0x0600D3A9 RID: 54185 RVA: 0x0039C218 File Offset: 0x0039A418
		private void PlayerSettingUIController_OnNotifyRandomEventIsOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnNotifyRandomEventIsOnBoolean_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnNotifyRandomEventIsOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.NotifyRandomEvent = isOn;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
			LoginUITask.SetLocalPushNotifications();
		}

		// Token: 0x0600D3AA RID: 54186 RVA: 0x0039C2B4 File Offset: 0x0039A4B4
		private void PlayerSettingUIController_OnNotifyArenaTicketIsOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnNotifyArenaTicketIsOnBoolean_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnNotifyArenaTicketIsOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.NotifyArenaTicket = isOn;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
			LoginUITask.SetLocalPushNotifications();
		}

		// Token: 0x0600D3AB RID: 54187 RVA: 0x0039C350 File Offset: 0x0039A550
		private void PlayerSettingUIController_OnNotifyStoreRefreshIsOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnNotifyStoreRefreshIsOnBoolean_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnNotifyStoreRefreshIsOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.NotifyStoreRefresh = isOn;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
			LoginUITask.SetLocalPushNotifications();
		}

		// Token: 0x0600D3AC RID: 54188 RVA: 0x0039C3EC File Offset: 0x0039A5EC
		private void PlayerSettingUIController_OnSetBattleAnimationMode(SkipCombatMode mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnSetBattleAnimationModeSkipCombatMode_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnSetBattleAnimationModeSkipCombatMode_hotfix.call(new object[]
				{
					this,
					mode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.SkipCombatMode = (int)mode;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
		}

		// Token: 0x0600D3AD RID: 54189 RVA: 0x0039C484 File Offset: 0x0039A684
		private void PlayerSettingUIController_OnPowerSaveModeIsOn(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSettingUIController_OnPowerSaveModeIsOnBoolean_hotfix != null)
			{
				this.m_PlayerSettingUIController_OnPowerSaveModeIsOnBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.PowerSaveModeOn = isOn;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x0600D3AE RID: 54190 RVA: 0x0039C51C File Offset: 0x0039A71C
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x0600D3AF RID: 54191 RVA: 0x0039C590 File Offset: 0x0039A790
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x0600D3B0 RID: 54192 RVA: 0x0039C604 File Offset: 0x0039A804
		// (set) Token: 0x0600D3B1 RID: 54193 RVA: 0x0039C624 File Offset: 0x0039A824
		[DoNotToLua]
		public new PlayerSettingUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerSettingUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D3B2 RID: 54194 RVA: 0x0039C630 File Offset: 0x0039A830
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600D3B3 RID: 54195 RVA: 0x0039C63C File Offset: 0x0039A83C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600D3B4 RID: 54196 RVA: 0x0039C644 File Offset: 0x0039A844
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600D3B5 RID: 54197 RVA: 0x0039C64C File Offset: 0x0039A84C
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600D3B6 RID: 54198 RVA: 0x0039C658 File Offset: 0x0039A858
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600D3B7 RID: 54199 RVA: 0x0039C664 File Offset: 0x0039A864
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600D3B8 RID: 54200 RVA: 0x0039C670 File Offset: 0x0039A870
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600D3B9 RID: 54201 RVA: 0x0039C678 File Offset: 0x0039A878
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600D3BA RID: 54202 RVA: 0x0039C680 File Offset: 0x0039A880
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600D3BB RID: 54203 RVA: 0x0039C688 File Offset: 0x0039A888
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600D3BC RID: 54204 RVA: 0x0039C690 File Offset: 0x0039A890
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600D3BD RID: 54205 RVA: 0x0039C698 File Offset: 0x0039A898
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600D3BE RID: 54206 RVA: 0x0039C6A0 File Offset: 0x0039A8A0
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600D3BF RID: 54207 RVA: 0x0039C6A8 File Offset: 0x0039A8A8
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600D3C0 RID: 54208 RVA: 0x0039C6B4 File Offset: 0x0039A8B4
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600D3C1 RID: 54209 RVA: 0x0039C6C0 File Offset: 0x0039A8C0
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600D3C2 RID: 54210 RVA: 0x0039C6CC File Offset: 0x0039A8CC
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600D3C3 RID: 54211 RVA: 0x0039C6D8 File Offset: 0x0039A8D8
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600D3C4 RID: 54212 RVA: 0x0039C6E0 File Offset: 0x0039A8E0
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600D3C5 RID: 54213 RVA: 0x0039C6E8 File Offset: 0x0039A8E8
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600D3C6 RID: 54214 RVA: 0x0039C6F0 File Offset: 0x0039A8F0
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600D3C7 RID: 54215 RVA: 0x0039C6F8 File Offset: 0x0039A8F8
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600D3C8 RID: 54216 RVA: 0x0039C700 File Offset: 0x0039A900
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600D3C9 RID: 54217 RVA: 0x0039C708 File Offset: 0x0039A908
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_PlayerSettingUIController_OnClose_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnClose") as LuaFunction);
					this.m_PlayerSettingUIController_OnMusicVolumeChangedSingle_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnMusicVolumeChanged") as LuaFunction);
					this.m_PlayerSettingUIController_OnSFXVolumeChangedSingle_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnSFXVolumeChanged") as LuaFunction);
					this.m_PlayerSettingUIController_OnVoiceVolumeChangedSingle_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnVoiceVolumeChanged") as LuaFunction);
					this.m_PlayerSettingUIController_OnBGMIsOnBoolean_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnBGMIsOn") as LuaFunction);
					this.m_PlayerSettingUIController_OnSoundIsOnBoolean_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnSoundIsOn") as LuaFunction);
					this.m_PlayerSettingUIController_OnVoiceIsOnBoolean_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnVoiceIsOn") as LuaFunction);
					this.m_PlayerSettingUIController_OnEndActionIsOnBoolean_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnEndActionIsOn") as LuaFunction);
					this.m_PlayerSettingUIController_OnNotifyRecoveryEnergyIsOnBoolean_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnNotifyRecoveryEnergyIsOn") as LuaFunction);
					this.m_PlayerSettingUIController_OnNotifyRandomEventIsOnBoolean_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnNotifyRandomEventIsOn") as LuaFunction);
					this.m_PlayerSettingUIController_OnNotifyArenaTicketIsOnBoolean_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnNotifyArenaTicketIsOn") as LuaFunction);
					this.m_PlayerSettingUIController_OnNotifyStoreRefreshIsOnBoolean_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnNotifyStoreRefreshIsOn") as LuaFunction);
					this.m_PlayerSettingUIController_OnSetBattleAnimationModeSkipCombatMode_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnSetBattleAnimationMode") as LuaFunction);
					this.m_PlayerSettingUIController_OnPowerSaveModeIsOnBoolean_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnPowerSaveModeIsOn") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D3CA RID: 54218 RVA: 0x0039C9E0 File Offset: 0x0039ABE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerSettingUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040082EF RID: 33519
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "PlayerSettingUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/PlayerSettingUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040082F0 RID: 33520
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "PlayerSettingUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerSettingUIController"),
				m_ctrlName = "PlayerSettingUIController"
			}
		};

		// Token: 0x040082F1 RID: 33521
		private PlayerSettingUIController m_playerSettingUIController;

		// Token: 0x040082F2 RID: 33522
		[DoNotToLua]
		private PlayerSettingUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040082F3 RID: 33523
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040082F4 RID: 33524
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040082F5 RID: 33525
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040082F6 RID: 33526
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040082F7 RID: 33527
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040082F8 RID: 33528
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040082F9 RID: 33529
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x040082FA RID: 33530
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x040082FB RID: 33531
		private LuaFunction m_PlayerSettingUIController_OnClose_hotfix;

		// Token: 0x040082FC RID: 33532
		private LuaFunction m_PlayerSettingUIController_OnMusicVolumeChangedSingle_hotfix;

		// Token: 0x040082FD RID: 33533
		private LuaFunction m_PlayerSettingUIController_OnSFXVolumeChangedSingle_hotfix;

		// Token: 0x040082FE RID: 33534
		private LuaFunction m_PlayerSettingUIController_OnVoiceVolumeChangedSingle_hotfix;

		// Token: 0x040082FF RID: 33535
		private LuaFunction m_PlayerSettingUIController_OnBGMIsOnBoolean_hotfix;

		// Token: 0x04008300 RID: 33536
		private LuaFunction m_PlayerSettingUIController_OnSoundIsOnBoolean_hotfix;

		// Token: 0x04008301 RID: 33537
		private LuaFunction m_PlayerSettingUIController_OnVoiceIsOnBoolean_hotfix;

		// Token: 0x04008302 RID: 33538
		private LuaFunction m_PlayerSettingUIController_OnEndActionIsOnBoolean_hotfix;

		// Token: 0x04008303 RID: 33539
		private LuaFunction m_PlayerSettingUIController_OnNotifyRecoveryEnergyIsOnBoolean_hotfix;

		// Token: 0x04008304 RID: 33540
		private LuaFunction m_PlayerSettingUIController_OnNotifyRandomEventIsOnBoolean_hotfix;

		// Token: 0x04008305 RID: 33541
		private LuaFunction m_PlayerSettingUIController_OnNotifyArenaTicketIsOnBoolean_hotfix;

		// Token: 0x04008306 RID: 33542
		private LuaFunction m_PlayerSettingUIController_OnNotifyStoreRefreshIsOnBoolean_hotfix;

		// Token: 0x04008307 RID: 33543
		private LuaFunction m_PlayerSettingUIController_OnSetBattleAnimationModeSkipCombatMode_hotfix;

		// Token: 0x04008308 RID: 33544
		private LuaFunction m_PlayerSettingUIController_OnPowerSaveModeIsOnBoolean_hotfix;

		// Token: 0x04008309 RID: 33545
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400830A RID: 33546
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000BE9 RID: 3049
		public new class LuaExportHelper
		{
			// Token: 0x0600D3CB RID: 54219 RVA: 0x0039CA48 File Offset: 0x0039AC48
			public LuaExportHelper(PlayerSettingUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D3CC RID: 54220 RVA: 0x0039CA58 File Offset: 0x0039AC58
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600D3CD RID: 54221 RVA: 0x0039CA68 File Offset: 0x0039AC68
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600D3CE RID: 54222 RVA: 0x0039CA78 File Offset: 0x0039AC78
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600D3CF RID: 54223 RVA: 0x0039CA88 File Offset: 0x0039AC88
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600D3D0 RID: 54224 RVA: 0x0039CA98 File Offset: 0x0039AC98
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600D3D1 RID: 54225 RVA: 0x0039CAA8 File Offset: 0x0039ACA8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600D3D2 RID: 54226 RVA: 0x0039CAB8 File Offset: 0x0039ACB8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D3D3 RID: 54227 RVA: 0x0039CAC8 File Offset: 0x0039ACC8
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600D3D4 RID: 54228 RVA: 0x0039CAD8 File Offset: 0x0039ACD8
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600D3D5 RID: 54229 RVA: 0x0039CAE8 File Offset: 0x0039ACE8
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600D3D6 RID: 54230 RVA: 0x0039CAF8 File Offset: 0x0039ACF8
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600D3D7 RID: 54231 RVA: 0x0039CB08 File Offset: 0x0039AD08
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600D3D8 RID: 54232 RVA: 0x0039CB18 File Offset: 0x0039AD18
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600D3D9 RID: 54233 RVA: 0x0039CB28 File Offset: 0x0039AD28
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600D3DA RID: 54234 RVA: 0x0039CB38 File Offset: 0x0039AD38
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600D3DB RID: 54235 RVA: 0x0039CB48 File Offset: 0x0039AD48
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600D3DC RID: 54236 RVA: 0x0039CB58 File Offset: 0x0039AD58
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600D3DD RID: 54237 RVA: 0x0039CB68 File Offset: 0x0039AD68
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600D3DE RID: 54238 RVA: 0x0039CB78 File Offset: 0x0039AD78
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600D3DF RID: 54239 RVA: 0x0039CB88 File Offset: 0x0039AD88
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600D3E0 RID: 54240 RVA: 0x0039CB98 File Offset: 0x0039AD98
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600D3E1 RID: 54241 RVA: 0x0039CBA8 File Offset: 0x0039ADA8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600D3E2 RID: 54242 RVA: 0x0039CBB8 File Offset: 0x0039ADB8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002981 RID: 10625
			// (get) Token: 0x0600D3E3 RID: 54243 RVA: 0x0039CBC8 File Offset: 0x0039ADC8
			// (set) Token: 0x0600D3E4 RID: 54244 RVA: 0x0039CBD8 File Offset: 0x0039ADD8
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x17002982 RID: 10626
			// (get) Token: 0x0600D3E5 RID: 54245 RVA: 0x0039CBE8 File Offset: 0x0039ADE8
			// (set) Token: 0x0600D3E6 RID: 54246 RVA: 0x0039CBF8 File Offset: 0x0039ADF8
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x17002983 RID: 10627
			// (get) Token: 0x0600D3E7 RID: 54247 RVA: 0x0039CC08 File Offset: 0x0039AE08
			// (set) Token: 0x0600D3E8 RID: 54248 RVA: 0x0039CC18 File Offset: 0x0039AE18
			public PlayerSettingUIController m_playerSettingUIController
			{
				get
				{
					return this.m_owner.m_playerSettingUIController;
				}
				set
				{
					this.m_owner.m_playerSettingUIController = value;
				}
			}

			// Token: 0x17002984 RID: 10628
			// (get) Token: 0x0600D3E9 RID: 54249 RVA: 0x0039CC28 File Offset: 0x0039AE28
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002985 RID: 10629
			// (get) Token: 0x0600D3EA RID: 54250 RVA: 0x0039CC38 File Offset: 0x0039AE38
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600D3EB RID: 54251 RVA: 0x0039CC48 File Offset: 0x0039AE48
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600D3EC RID: 54252 RVA: 0x0039CC58 File Offset: 0x0039AE58
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600D3ED RID: 54253 RVA: 0x0039CC68 File Offset: 0x0039AE68
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600D3EE RID: 54254 RVA: 0x0039CC78 File Offset: 0x0039AE78
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600D3EF RID: 54255 RVA: 0x0039CC88 File Offset: 0x0039AE88
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600D3F0 RID: 54256 RVA: 0x0039CC98 File Offset: 0x0039AE98
			public void PlayerSettingUIController_OnClose()
			{
				this.m_owner.PlayerSettingUIController_OnClose();
			}

			// Token: 0x0600D3F1 RID: 54257 RVA: 0x0039CCA8 File Offset: 0x0039AEA8
			public void PlayerSettingUIController_OnMusicVolumeChanged(float volume)
			{
				this.m_owner.PlayerSettingUIController_OnMusicVolumeChanged(volume);
			}

			// Token: 0x0600D3F2 RID: 54258 RVA: 0x0039CCB8 File Offset: 0x0039AEB8
			public void PlayerSettingUIController_OnSFXVolumeChanged(float volume)
			{
				this.m_owner.PlayerSettingUIController_OnSFXVolumeChanged(volume);
			}

			// Token: 0x0600D3F3 RID: 54259 RVA: 0x0039CCC8 File Offset: 0x0039AEC8
			public void PlayerSettingUIController_OnVoiceVolumeChanged(float volume)
			{
				this.m_owner.PlayerSettingUIController_OnVoiceVolumeChanged(volume);
			}

			// Token: 0x0600D3F4 RID: 54260 RVA: 0x0039CCD8 File Offset: 0x0039AED8
			public void PlayerSettingUIController_OnBGMIsOn(bool isOn)
			{
				this.m_owner.PlayerSettingUIController_OnBGMIsOn(isOn);
			}

			// Token: 0x0600D3F5 RID: 54261 RVA: 0x0039CCE8 File Offset: 0x0039AEE8
			public void PlayerSettingUIController_OnSoundIsOn(bool isOn)
			{
				this.m_owner.PlayerSettingUIController_OnSoundIsOn(isOn);
			}

			// Token: 0x0600D3F6 RID: 54262 RVA: 0x0039CCF8 File Offset: 0x0039AEF8
			public void PlayerSettingUIController_OnVoiceIsOn(bool isOn)
			{
				this.m_owner.PlayerSettingUIController_OnVoiceIsOn(isOn);
			}

			// Token: 0x0600D3F7 RID: 54263 RVA: 0x0039CD08 File Offset: 0x0039AF08
			public void PlayerSettingUIController_OnEndActionIsOn(bool isOn)
			{
				this.m_owner.PlayerSettingUIController_OnEndActionIsOn(isOn);
			}

			// Token: 0x0600D3F8 RID: 54264 RVA: 0x0039CD18 File Offset: 0x0039AF18
			public void PlayerSettingUIController_OnNotifyRecoveryEnergyIsOn(bool isOn)
			{
				this.m_owner.PlayerSettingUIController_OnNotifyRecoveryEnergyIsOn(isOn);
			}

			// Token: 0x0600D3F9 RID: 54265 RVA: 0x0039CD28 File Offset: 0x0039AF28
			public void PlayerSettingUIController_OnNotifyRandomEventIsOn(bool isOn)
			{
				this.m_owner.PlayerSettingUIController_OnNotifyRandomEventIsOn(isOn);
			}

			// Token: 0x0600D3FA RID: 54266 RVA: 0x0039CD38 File Offset: 0x0039AF38
			public void PlayerSettingUIController_OnNotifyArenaTicketIsOn(bool isOn)
			{
				this.m_owner.PlayerSettingUIController_OnNotifyArenaTicketIsOn(isOn);
			}

			// Token: 0x0600D3FB RID: 54267 RVA: 0x0039CD48 File Offset: 0x0039AF48
			public void PlayerSettingUIController_OnNotifyStoreRefreshIsOn(bool isOn)
			{
				this.m_owner.PlayerSettingUIController_OnNotifyStoreRefreshIsOn(isOn);
			}

			// Token: 0x0600D3FC RID: 54268 RVA: 0x0039CD58 File Offset: 0x0039AF58
			public void PlayerSettingUIController_OnSetBattleAnimationMode(SkipCombatMode mode)
			{
				this.m_owner.PlayerSettingUIController_OnSetBattleAnimationMode(mode);
			}

			// Token: 0x0600D3FD RID: 54269 RVA: 0x0039CD68 File Offset: 0x0039AF68
			public void PlayerSettingUIController_OnPowerSaveModeIsOn(bool isOn)
			{
				this.m_owner.PlayerSettingUIController_OnPowerSaveModeIsOn(isOn);
			}

			// Token: 0x0400830B RID: 33547
			private PlayerSettingUITask m_owner;
		}
	}
}
