using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B7D RID: 2941
	[HotFix]
	public class VoiceRecordUITask : UITask
	{
		// Token: 0x0600C7FE RID: 51198 RVA: 0x00376698 File Offset: 0x00374898
		public VoiceRecordUITask(string name) : base(name)
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

		// Token: 0x0600C7FF RID: 51199 RVA: 0x003767A8 File Offset: 0x003749A8
		public static VoiceRecordUITask StartVoiceRecordUITask(GameObject btnObj, ChatChannel channelType)
		{
			if (UIUtility.FindUITaskWithType(typeof(VoiceRecordUITask)) != null)
			{
				UIManager.Instance.StopUITask(typeof(VoiceRecordUITask).Name);
			}
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(VoiceRecordUITask).Name, null);
			uiintentCustom.SetParam("TalkButtonObj", btnObj);
			uiintentCustom.SetParam("ChannelType", channelType);
			uiintentCustom.SetParam("BattleType", BattleType.Rift);
			return UIManager.Instance.StartUITask(uiintentCustom, true, false, null) as VoiceRecordUITask;
		}

		// Token: 0x0600C800 RID: 51200 RVA: 0x0037683C File Offset: 0x00374A3C
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
			this.GetDataFromIntent(intent);
			base.OnStart(intent);
			VoiceRecordHelper.Instance.EventOnVoiceRecordTimeout += this.OnVoiceRecordTimeout;
			return true;
		}

		// Token: 0x0600C801 RID: 51201 RVA: 0x003768E0 File Offset: 0x00374AE0
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.GetDataFromIntent(intent);
			return true;
		}

		// Token: 0x0600C802 RID: 51202 RVA: 0x00376964 File Offset: 0x00374B64
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
			VoiceRecordHelper.Instance.EventOnVoiceRecordTimeout -= this.OnVoiceRecordTimeout;
		}

		// Token: 0x0600C803 RID: 51203 RVA: 0x003769E0 File Offset: 0x00374BE0
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			if (this.m_VoiceUICtrl == null)
			{
				return;
			}
			this.TickForVoiceRecordTime();
		}

		// Token: 0x0600C804 RID: 51204 RVA: 0x00376A60 File Offset: 0x00374C60
		private void GetDataFromIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDataFromIntentUIIntent_hotfix != null)
			{
				this.m_GetDataFromIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_TalkBtnObj = uiintentCustom.GetClassParam<GameObject>("TalkButtonObj");
				this.m_currentTableType = uiintentCustom.GetStructParam<ChatChannel>("ChannelType");
				global::Debug.Log("VoiceRecordUITask.GetDataFromIntent type=" + this.m_currentTableType);
			}
		}

		// Token: 0x0600C805 RID: 51205 RVA: 0x00376B1C File Offset: 0x00374D1C
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
			if (this.m_uiCtrlArray.Length > 0)
			{
				this.m_VoiceUICtrl = (this.m_uiCtrlArray[0] as VoiceRecordUIController);
				if (this.m_TalkBtnObj != null)
				{
					VoiceRecordButtonListerner voiceRecordButtonListerner = this.m_TalkBtnObj.GetComponent<VoiceRecordButtonListerner>();
					if (voiceRecordButtonListerner == null)
					{
						voiceRecordButtonListerner = this.m_TalkBtnObj.AddComponent<VoiceRecordButtonListerner>();
					}
					voiceRecordButtonListerner.EventOnTalkButtonHold += this.OnTalkButtonHold;
					voiceRecordButtonListerner.EventOnTalkButtonClickUp += this.OnTalkButtonClickUp;
					voiceRecordButtonListerner.EventOnExitTalkButtonClick += this.OnExitTalkButton;
					voiceRecordButtonListerner.EventOnEnterTalkButtonClick += this.OnEnterTalkButton;
				}
			}
		}

		// Token: 0x0600C806 RID: 51206 RVA: 0x00376C20 File Offset: 0x00374E20
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
			if (this.m_TalkBtnObj != null)
			{
				VoiceRecordButtonListerner component = this.m_TalkBtnObj.GetComponent<VoiceRecordButtonListerner>();
				if (component != null)
				{
					component.EventOnTalkButtonHold -= this.OnTalkButtonHold;
					component.EventOnTalkButtonClickUp -= this.OnTalkButtonClickUp;
					component.EventOnExitTalkButtonClick -= this.OnExitTalkButton;
					component.EventOnEnterTalkButtonClick -= this.OnEnterTalkButton;
				}
			}
		}

		// Token: 0x0600C807 RID: 51207 RVA: 0x00376CF8 File Offset: 0x00374EF8
		[DebuggerHidden]
		private IEnumerator RequestMicrophonePermission()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RequestMicrophonePermission_hotfix != null)
			{
				return (IEnumerator)this.m_RequestMicrophonePermission_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new VoiceRecordUITask.<RequestMicrophonePermission>c__Iterator0();
		}

		// Token: 0x0600C808 RID: 51208 RVA: 0x00376D6C File Offset: 0x00374F6C
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
			if (!Application.HasUserAuthorization(UserAuthorization.Microphone) && CommonUIController.Instance != null)
			{
				CommonUIController.Instance.StartCoroutine(this.RequestMicrophonePermission());
			}
		}

		// Token: 0x0600C809 RID: 51209 RVA: 0x00376DF8 File Offset: 0x00374FF8
		private void OnTalkButtonHold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalkButtonHold_hotfix != null)
			{
				this.m_OnTalkButtonHold_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (!VoiceRecordHelper.Instance.IsMicrophoneAvailable())
			{
				string txt = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_MicrophoneNotFound);
				CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
				return;
			}
			if (!Application.HasUserAuthorization(UserAuthorization.Microphone))
			{
				if (Application.platform == RuntimePlatform.IPhonePlayer)
				{
					CommonUIController.Instance.ShowDialogBox(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_NoIOSMicrophonePermission), null, string.Empty, string.Empty);
				}
				else if (Application.platform == RuntimePlatform.Android)
				{
					CommonUIController.Instance.ShowDialogBox(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_NoAndroidMicrophonePermission), null, string.Empty, string.Empty);
				}
				else
				{
					CommonUIController.Instance.ShowMessage(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_MicrophoneNotFound), 2f, null, true);
				}
				return;
			}
			this.m_isTalkButtonDown = true;
			VoiceRecordHelper.Instance.StartRecord(this.m_currentTableType, delegate
			{
				this.m_VoiceUICtrl.ShowVoiceRecordTip();
			});
		}

		// Token: 0x0600C80A RID: 51210 RVA: 0x00376F44 File Offset: 0x00375144
		private void OnTalkButtonClickUp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalkButtonClickUp_hotfix != null)
			{
				this.m_OnTalkButtonClickUp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isTalkButtonDown)
			{
				return;
			}
			this.m_isTalkButtonDown = false;
			if (VoiceRecordHelper.Instance.IsRecording() && VoiceRecordHelper.Instance.IsTooShort())
			{
				this.m_VoiceUICtrl.ShowVoiceShortTip();
				base.ExecAfterTicks(delegate
				{
					if (!VoiceRecordHelper.Instance.IsRecording())
					{
						this.m_VoiceUICtrl.HideVoiceRecordTip();
					}
				}, (ulong)((1f + Time.smoothDeltaTime) / Time.smoothDeltaTime));
			}
			else
			{
				this.m_VoiceUICtrl.HideVoiceRecordTip();
			}
			if (this.m_isExitTalkButtonRect)
			{
				this.m_isExitTalkButtonRect = false;
				VoiceRecordHelper.Instance.CancelRecord();
			}
			else
			{
				VoiceRecordHelper.Instance.StopRecord();
			}
		}

		// Token: 0x0600C80B RID: 51211 RVA: 0x00377040 File Offset: 0x00375240
		private void OnExitTalkButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExitTalkButton_hotfix != null)
			{
				this.m_OnExitTalkButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isTalkButtonDown)
			{
				this.m_VoiceUICtrl.ShowVoiceCancelTip();
				this.m_isExitTalkButtonRect = true;
			}
		}

		// Token: 0x0600C80C RID: 51212 RVA: 0x003770C0 File Offset: 0x003752C0
		private void OnEnterTalkButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnterTalkButton_hotfix != null)
			{
				this.m_OnEnterTalkButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isTalkButtonDown)
			{
				this.m_VoiceUICtrl.ShowVoiceRecordTip();
				this.m_isExitTalkButtonRect = false;
			}
		}

		// Token: 0x0600C80D RID: 51213 RVA: 0x00377140 File Offset: 0x00375340
		private void OnVoiceRecordTimeout(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnVoiceRecordTimeoutChatChannel_hotfix != null)
			{
				this.m_OnVoiceRecordTimeoutChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isTalkButtonDown = false;
			this.m_VoiceUICtrl.HideVoiceRecordTip();
			VoiceRecordHelper.Instance.StopRecord();
		}

		// Token: 0x0600C80E RID: 51214 RVA: 0x003771CC File Offset: 0x003753CC
		private void TickForVoiceRecordTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickForVoiceRecordTime_hotfix != null)
			{
				this.m_TickForVoiceRecordTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isTalkButtonDown && this.m_VoiceUICtrl != null && VoiceRecordHelper.Instance.IsRecording())
			{
				if (!VoiceRecordHelper.Instance.IsArrivalMaxLength())
				{
					this.m_VoiceUICtrl.UpdateVoiceRecordTime(VoiceRecordHelper.Instance.GetRecordLength());
				}
				else
				{
					this.m_VoiceUICtrl.HideVoiceRecordTip();
				}
			}
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x0600C80F RID: 51215 RVA: 0x0037728C File Offset: 0x0037548C
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

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x0600C810 RID: 51216 RVA: 0x00377300 File Offset: 0x00375500
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

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x0600C811 RID: 51217 RVA: 0x00377374 File Offset: 0x00375574
		// (set) Token: 0x0600C812 RID: 51218 RVA: 0x00377394 File Offset: 0x00375594
		[DoNotToLua]
		public new VoiceRecordUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new VoiceRecordUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C813 RID: 51219 RVA: 0x003773A0 File Offset: 0x003755A0
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600C814 RID: 51220 RVA: 0x003773AC File Offset: 0x003755AC
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600C815 RID: 51221 RVA: 0x003773B4 File Offset: 0x003755B4
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600C816 RID: 51222 RVA: 0x003773BC File Offset: 0x003755BC
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600C817 RID: 51223 RVA: 0x003773C8 File Offset: 0x003755C8
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600C818 RID: 51224 RVA: 0x003773D4 File Offset: 0x003755D4
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600C819 RID: 51225 RVA: 0x003773E0 File Offset: 0x003755E0
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600C81A RID: 51226 RVA: 0x003773E8 File Offset: 0x003755E8
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600C81B RID: 51227 RVA: 0x003773F0 File Offset: 0x003755F0
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600C81C RID: 51228 RVA: 0x003773F8 File Offset: 0x003755F8
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600C81D RID: 51229 RVA: 0x00377400 File Offset: 0x00375600
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600C81E RID: 51230 RVA: 0x00377408 File Offset: 0x00375608
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600C81F RID: 51231 RVA: 0x00377410 File Offset: 0x00375610
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600C820 RID: 51232 RVA: 0x00377418 File Offset: 0x00375618
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600C821 RID: 51233 RVA: 0x00377424 File Offset: 0x00375624
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600C822 RID: 51234 RVA: 0x00377430 File Offset: 0x00375630
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600C823 RID: 51235 RVA: 0x0037743C File Offset: 0x0037563C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600C824 RID: 51236 RVA: 0x00377448 File Offset: 0x00375648
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600C825 RID: 51237 RVA: 0x00377450 File Offset: 0x00375650
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600C826 RID: 51238 RVA: 0x00377458 File Offset: 0x00375658
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600C827 RID: 51239 RVA: 0x00377460 File Offset: 0x00375660
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600C828 RID: 51240 RVA: 0x00377468 File Offset: 0x00375668
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600C829 RID: 51241 RVA: 0x00377470 File Offset: 0x00375670
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600C82C RID: 51244 RVA: 0x003774A4 File Offset: 0x003756A4
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_GetDataFromIntentUIIntent_hotfix = (luaObj.RawGet("GetDataFromIntent") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_RequestMicrophonePermission_hotfix = (luaObj.RawGet("RequestMicrophonePermission") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnTalkButtonHold_hotfix = (luaObj.RawGet("OnTalkButtonHold") as LuaFunction);
					this.m_OnTalkButtonClickUp_hotfix = (luaObj.RawGet("OnTalkButtonClickUp") as LuaFunction);
					this.m_OnExitTalkButton_hotfix = (luaObj.RawGet("OnExitTalkButton") as LuaFunction);
					this.m_OnEnterTalkButton_hotfix = (luaObj.RawGet("OnEnterTalkButton") as LuaFunction);
					this.m_OnVoiceRecordTimeoutChatChannel_hotfix = (luaObj.RawGet("OnVoiceRecordTimeout") as LuaFunction);
					this.m_TickForVoiceRecordTime_hotfix = (luaObj.RawGet("TickForVoiceRecordTime") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C82D RID: 51245 RVA: 0x00377718 File Offset: 0x00375918
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(VoiceRecordUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007E87 RID: 32391
		private GameObject m_TalkBtnObj;

		// Token: 0x04007E88 RID: 32392
		private bool m_isTalkButtonDown;

		// Token: 0x04007E89 RID: 32393
		private bool m_isExitTalkButtonRect;

		// Token: 0x04007E8A RID: 32394
		private ProjectLPlayerContext m_playerCtx = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04007E8B RID: 32395
		private ChatChannel m_currentTableType = ChatChannel.Team;

		// Token: 0x04007E8C RID: 32396
		private VoiceRecordUIController m_VoiceUICtrl;

		// Token: 0x04007E8D RID: 32397
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "VoiceRecordUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Chat_ABS/Prefab/VoiceRecordUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04007E8E RID: 32398
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "VoiceRecordUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.VoiceRecordUIController"),
				m_ctrlName = "VoiceRecordUIController"
			}
		};

		// Token: 0x04007E8F RID: 32399
		[DoNotToLua]
		private VoiceRecordUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04007E90 RID: 32400
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007E91 RID: 32401
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007E92 RID: 32402
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04007E93 RID: 32403
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04007E94 RID: 32404
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04007E95 RID: 32405
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04007E96 RID: 32406
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x04007E97 RID: 32407
		private LuaFunction m_GetDataFromIntentUIIntent_hotfix;

		// Token: 0x04007E98 RID: 32408
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04007E99 RID: 32409
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04007E9A RID: 32410
		private LuaFunction m_RequestMicrophonePermission_hotfix;

		// Token: 0x04007E9B RID: 32411
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04007E9C RID: 32412
		private LuaFunction m_OnTalkButtonHold_hotfix;

		// Token: 0x04007E9D RID: 32413
		private LuaFunction m_OnTalkButtonClickUp_hotfix;

		// Token: 0x04007E9E RID: 32414
		private LuaFunction m_OnExitTalkButton_hotfix;

		// Token: 0x04007E9F RID: 32415
		private LuaFunction m_OnEnterTalkButton_hotfix;

		// Token: 0x04007EA0 RID: 32416
		private LuaFunction m_OnVoiceRecordTimeoutChatChannel_hotfix;

		// Token: 0x04007EA1 RID: 32417
		private LuaFunction m_TickForVoiceRecordTime_hotfix;

		// Token: 0x04007EA2 RID: 32418
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04007EA3 RID: 32419
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000B7E RID: 2942
		public new class LuaExportHelper
		{
			// Token: 0x0600C82E RID: 51246 RVA: 0x00377780 File Offset: 0x00375980
			public LuaExportHelper(VoiceRecordUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C82F RID: 51247 RVA: 0x00377790 File Offset: 0x00375990
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600C830 RID: 51248 RVA: 0x003777A0 File Offset: 0x003759A0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600C831 RID: 51249 RVA: 0x003777B0 File Offset: 0x003759B0
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600C832 RID: 51250 RVA: 0x003777C0 File Offset: 0x003759C0
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600C833 RID: 51251 RVA: 0x003777D0 File Offset: 0x003759D0
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600C834 RID: 51252 RVA: 0x003777E0 File Offset: 0x003759E0
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600C835 RID: 51253 RVA: 0x003777F0 File Offset: 0x003759F0
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600C836 RID: 51254 RVA: 0x00377800 File Offset: 0x00375A00
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600C837 RID: 51255 RVA: 0x00377810 File Offset: 0x00375A10
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600C838 RID: 51256 RVA: 0x00377820 File Offset: 0x00375A20
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600C839 RID: 51257 RVA: 0x00377830 File Offset: 0x00375A30
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600C83A RID: 51258 RVA: 0x00377840 File Offset: 0x00375A40
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600C83B RID: 51259 RVA: 0x00377850 File Offset: 0x00375A50
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600C83C RID: 51260 RVA: 0x00377860 File Offset: 0x00375A60
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600C83D RID: 51261 RVA: 0x00377870 File Offset: 0x00375A70
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600C83E RID: 51262 RVA: 0x00377880 File Offset: 0x00375A80
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600C83F RID: 51263 RVA: 0x00377890 File Offset: 0x00375A90
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600C840 RID: 51264 RVA: 0x003778A0 File Offset: 0x00375AA0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600C841 RID: 51265 RVA: 0x003778B0 File Offset: 0x00375AB0
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600C842 RID: 51266 RVA: 0x003778C0 File Offset: 0x00375AC0
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600C843 RID: 51267 RVA: 0x003778D0 File Offset: 0x00375AD0
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600C844 RID: 51268 RVA: 0x003778E0 File Offset: 0x00375AE0
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600C845 RID: 51269 RVA: 0x003778F0 File Offset: 0x00375AF0
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x170027CF RID: 10191
			// (get) Token: 0x0600C846 RID: 51270 RVA: 0x00377900 File Offset: 0x00375B00
			// (set) Token: 0x0600C847 RID: 51271 RVA: 0x00377910 File Offset: 0x00375B10
			public GameObject m_TalkBtnObj
			{
				get
				{
					return this.m_owner.m_TalkBtnObj;
				}
				set
				{
					this.m_owner.m_TalkBtnObj = value;
				}
			}

			// Token: 0x170027D0 RID: 10192
			// (get) Token: 0x0600C848 RID: 51272 RVA: 0x00377920 File Offset: 0x00375B20
			// (set) Token: 0x0600C849 RID: 51273 RVA: 0x00377930 File Offset: 0x00375B30
			public bool m_isTalkButtonDown
			{
				get
				{
					return this.m_owner.m_isTalkButtonDown;
				}
				set
				{
					this.m_owner.m_isTalkButtonDown = value;
				}
			}

			// Token: 0x170027D1 RID: 10193
			// (get) Token: 0x0600C84A RID: 51274 RVA: 0x00377940 File Offset: 0x00375B40
			// (set) Token: 0x0600C84B RID: 51275 RVA: 0x00377950 File Offset: 0x00375B50
			public bool m_isExitTalkButtonRect
			{
				get
				{
					return this.m_owner.m_isExitTalkButtonRect;
				}
				set
				{
					this.m_owner.m_isExitTalkButtonRect = value;
				}
			}

			// Token: 0x170027D2 RID: 10194
			// (get) Token: 0x0600C84C RID: 51276 RVA: 0x00377960 File Offset: 0x00375B60
			// (set) Token: 0x0600C84D RID: 51277 RVA: 0x00377970 File Offset: 0x00375B70
			public ProjectLPlayerContext m_playerCtx
			{
				get
				{
					return this.m_owner.m_playerCtx;
				}
				set
				{
					this.m_owner.m_playerCtx = value;
				}
			}

			// Token: 0x170027D3 RID: 10195
			// (get) Token: 0x0600C84E RID: 51278 RVA: 0x00377980 File Offset: 0x00375B80
			// (set) Token: 0x0600C84F RID: 51279 RVA: 0x00377990 File Offset: 0x00375B90
			public ChatChannel m_currentTableType
			{
				get
				{
					return this.m_owner.m_currentTableType;
				}
				set
				{
					this.m_owner.m_currentTableType = value;
				}
			}

			// Token: 0x170027D4 RID: 10196
			// (get) Token: 0x0600C850 RID: 51280 RVA: 0x003779A0 File Offset: 0x00375BA0
			// (set) Token: 0x0600C851 RID: 51281 RVA: 0x003779B0 File Offset: 0x00375BB0
			public VoiceRecordUIController m_VoiceUICtrl
			{
				get
				{
					return this.m_owner.m_VoiceUICtrl;
				}
				set
				{
					this.m_owner.m_VoiceUICtrl = value;
				}
			}

			// Token: 0x170027D5 RID: 10197
			// (get) Token: 0x0600C852 RID: 51282 RVA: 0x003779C0 File Offset: 0x00375BC0
			// (set) Token: 0x0600C853 RID: 51283 RVA: 0x003779D0 File Offset: 0x00375BD0
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

			// Token: 0x170027D6 RID: 10198
			// (get) Token: 0x0600C854 RID: 51284 RVA: 0x003779E0 File Offset: 0x00375BE0
			// (set) Token: 0x0600C855 RID: 51285 RVA: 0x003779F0 File Offset: 0x00375BF0
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

			// Token: 0x170027D7 RID: 10199
			// (get) Token: 0x0600C856 RID: 51286 RVA: 0x00377A00 File Offset: 0x00375C00
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170027D8 RID: 10200
			// (get) Token: 0x0600C857 RID: 51287 RVA: 0x00377A10 File Offset: 0x00375C10
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600C858 RID: 51288 RVA: 0x00377A20 File Offset: 0x00375C20
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600C859 RID: 51289 RVA: 0x00377A30 File Offset: 0x00375C30
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600C85A RID: 51290 RVA: 0x00377A40 File Offset: 0x00375C40
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600C85B RID: 51291 RVA: 0x00377A50 File Offset: 0x00375C50
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0600C85C RID: 51292 RVA: 0x00377A60 File Offset: 0x00375C60
			public void GetDataFromIntent(UIIntent intent)
			{
				this.m_owner.GetDataFromIntent(intent);
			}

			// Token: 0x0600C85D RID: 51293 RVA: 0x00377A70 File Offset: 0x00375C70
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600C85E RID: 51294 RVA: 0x00377A80 File Offset: 0x00375C80
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600C85F RID: 51295 RVA: 0x00377A90 File Offset: 0x00375C90
			public IEnumerator RequestMicrophonePermission()
			{
				return this.m_owner.RequestMicrophonePermission();
			}

			// Token: 0x0600C860 RID: 51296 RVA: 0x00377AA0 File Offset: 0x00375CA0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600C861 RID: 51297 RVA: 0x00377AB0 File Offset: 0x00375CB0
			public void OnTalkButtonHold()
			{
				this.m_owner.OnTalkButtonHold();
			}

			// Token: 0x0600C862 RID: 51298 RVA: 0x00377AC0 File Offset: 0x00375CC0
			public void OnTalkButtonClickUp()
			{
				this.m_owner.OnTalkButtonClickUp();
			}

			// Token: 0x0600C863 RID: 51299 RVA: 0x00377AD0 File Offset: 0x00375CD0
			public void OnExitTalkButton()
			{
				this.m_owner.OnExitTalkButton();
			}

			// Token: 0x0600C864 RID: 51300 RVA: 0x00377AE0 File Offset: 0x00375CE0
			public void OnEnterTalkButton()
			{
				this.m_owner.OnEnterTalkButton();
			}

			// Token: 0x0600C865 RID: 51301 RVA: 0x00377AF0 File Offset: 0x00375CF0
			public void OnVoiceRecordTimeout(ChatChannel channel)
			{
				this.m_owner.OnVoiceRecordTimeout(channel);
			}

			// Token: 0x0600C866 RID: 51302 RVA: 0x00377B00 File Offset: 0x00375D00
			public void TickForVoiceRecordTime()
			{
				this.m_owner.TickForVoiceRecordTime();
			}

			// Token: 0x04007EA4 RID: 32420
			private VoiceRecordUITask m_owner;
		}
	}
}
