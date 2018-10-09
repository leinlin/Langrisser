using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E96 RID: 3734
	[HotFix]
	public class PlayerInfoUITask : UITask
	{
		// Token: 0x060123AF RID: 74671 RVA: 0x004B00F0 File Offset: 0x004AE2F0
		public PlayerInfoUITask(string name) : base(name)
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

		// Token: 0x060123B0 RID: 74672 RVA: 0x004B01F8 File Offset: 0x004AE3F8
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060123B1 RID: 74673 RVA: 0x004B026C File Offset: 0x004AE46C
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
			if (this.m_playerInfoUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_playerInfoUIController = (this.m_uiCtrlArray[0] as PlayerInfoUIController);
				}
				if (!(this.m_playerInfoUIController != null))
				{
					Debug.LogError("PlayerInfoUIController is null");
					return;
				}
				this.m_playerInfoUIController.EventOnShowSign += this.PlayerInfoUIController_OnShowSign;
				this.m_playerInfoUIController.EventOnClose += this.PlayerInfoUIController_OnClose;
				this.m_playerInfoUIController.EventOnShowChangeIconPanel += this.PlayerInfoUIController_OnShowChangeIconPanel;
				this.m_playerInfoUIController.EventOnChangeName += this.PlayerInfoUIController_OnChangeName;
				this.m_playerInfoUIController.EventOnShowMyBusinessCard += this.PlayerInfoUIController_OnWatchMyBusinessCard;
				this.m_playerInfoUIController.EventOnChangeHeadPortraitAndHeadFrame += this.PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrame;
				this.m_playerInfoUIController.EventOnShowPlayerSetting += this.PlayerInfoUIController_OnShowPlayerSetting;
				this.m_playerInfoUIController.EventOnChangeRECState += this.PlayerInfoUIController_OnChangeRECState;
				this.m_playerInfoUIController.EventOnRedemptionCodeUse += this.PlayerInfoUIController_OnRedemptionCodeUse;
				this.m_playerInfoUIController.EventOnCrystalNotEnough += this.PlayerInfoUIController_OnCrystalNotEnough;
			}
		}

		// Token: 0x060123B2 RID: 74674 RVA: 0x004B040C File Offset: 0x004AE60C
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
			if (this.m_playerInfoUIController != null)
			{
				this.m_playerInfoUIController.EventOnShowSign -= this.PlayerInfoUIController_OnShowSign;
				this.m_playerInfoUIController.EventOnClose -= this.PlayerInfoUIController_OnClose;
				this.m_playerInfoUIController.EventOnShowChangeIconPanel -= this.PlayerInfoUIController_OnShowChangeIconPanel;
				this.m_playerInfoUIController.EventOnChangeName -= this.PlayerInfoUIController_OnChangeName;
				this.m_playerInfoUIController.EventOnShowMyBusinessCard -= this.PlayerInfoUIController_OnWatchMyBusinessCard;
				this.m_playerInfoUIController.EventOnChangeHeadPortraitAndHeadFrame -= this.PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrame;
				this.m_playerInfoUIController.EventOnShowPlayerSetting -= this.PlayerInfoUIController_OnShowPlayerSetting;
				this.m_playerInfoUIController.EventOnChangeRECState -= this.PlayerInfoUIController_OnChangeRECState;
				this.m_playerInfoUIController.EventOnRedemptionCodeUse -= this.PlayerInfoUIController_OnRedemptionCodeUse;
				this.m_playerInfoUIController.EventOnCrystalNotEnough -= this.PlayerInfoUIController_OnCrystalNotEnough;
				this.m_playerInfoUIController = null;
			}
		}

		// Token: 0x060123B3 RID: 74675 RVA: 0x004B0570 File Offset: 0x004AE770
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

		// Token: 0x060123B4 RID: 74676 RVA: 0x004B05F4 File Offset: 0x004AE7F4
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

		// Token: 0x060123B5 RID: 74677 RVA: 0x004B065C File Offset: 0x004AE85C
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
			if (base.IsOpeningUI())
			{
				this.m_playerInfoUIController.PlayerInfoOpenTween();
			}
			this.m_playerInfoUIController.UpdateViewInPlayerInfo();
		}

		// Token: 0x060123B6 RID: 74678 RVA: 0x004B06E0 File Offset: 0x004AE8E0
		private void PlayerInfoUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUIController_OnClose_hotfix != null)
			{
				this.m_PlayerInfoUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x060123B7 RID: 74679 RVA: 0x004B075C File Offset: 0x004AE95C
		private void PlayerInfoUIController_OnShowChangeIconPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUIController_OnShowChangeIconPanel_hotfix != null)
			{
				this.m_PlayerInfoUIController_OnShowChangeIconPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			foreach (Hero hero in this.m_playerContext.GetHeros())
			{
				base.CollectSpriteAsset(UIUtility.GetPlayerHeadIconImageName(hero.HeroId));
			}
			base.StartLoadCustomAssets(delegate
			{
				this.m_playerInfoUIController.ShowChangeHeadIconPanel();
			});
		}

		// Token: 0x060123B8 RID: 74680 RVA: 0x004B0834 File Offset: 0x004AEA34
		private void PlayerInfoUIController_OnChangeName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUIController_OnChangeNameString_hotfix != null)
			{
				this.m_PlayerInfoUIController_OnChangeNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChangePlayerNameNetTask changePlayerNameNetTask = new ChangePlayerNameNetTask(name);
			changePlayerNameNetTask.EventOnStop += delegate(Task task)
			{
				ChangePlayerNameNetTask changePlayerNameNetTask2 = task as ChangePlayerNameNetTask;
				if (changePlayerNameNetTask2.Result == 0)
				{
					this.UpdateView();
					this.m_playerInfoUIController.OnChangeNamePanelCloseButtonClick();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(changePlayerNameNetTask2.Result, 2f, null, true);
				}
			};
			changePlayerNameNetTask.Start(null);
		}

		// Token: 0x060123B9 RID: 74681 RVA: 0x004B08C8 File Offset: 0x004AEAC8
		private void PlayerInfoUIController_OnWatchMyBusinessCard()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUIController_OnWatchMyBusinessCard_hotfix != null)
			{
				this.m_PlayerInfoUIController_OnWatchMyBusinessCard_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BusinessCardGetNetTask businessCardGetNetTask = new BusinessCardGetNetTask(this.m_playerContext.GetUserId());
			businessCardGetNetTask.EventOnStop += delegate(Task task)
			{
				BusinessCardGetNetTask businessCardGetNetTask2 = task as BusinessCardGetNetTask;
				if (businessCardGetNetTask2.Result == 0)
				{
					BusinessCardUITask.StartUITask(this.m_currIntent);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(businessCardGetNetTask2.Result, 2f, null, true);
				}
			};
			businessCardGetNetTask.Start(null);
		}

		// Token: 0x060123BA RID: 74682 RVA: 0x004B0954 File Offset: 0x004AEB54
		private void PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrame(int headPortraitId, int headFreameId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrameInt32Int32_hotfix != null)
			{
				this.m_PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrameInt32Int32_hotfix.call(new object[]
				{
					this,
					headPortraitId,
					headFreameId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChangeHeadPortraitAndHeadFrameNetTask changeHeadPortraitAndHeadFrameNetTask = new ChangeHeadPortraitAndHeadFrameNetTask(headPortraitId, headFreameId);
			changeHeadPortraitAndHeadFrameNetTask.EventOnStop += delegate(Task task)
			{
				ChangeHeadPortraitAndHeadFrameNetTask changeHeadPortraitAndHeadFrameNetTask2 = task as ChangeHeadPortraitAndHeadFrameNetTask;
				if (changeHeadPortraitAndHeadFrameNetTask2.Result == 0)
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_HeadIconChangeSuccess, 2f, null, true);
					this.UpdateView();
					this.m_playerInfoUIController.OnChangeIconPanelCloseButtonClick();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(changeHeadPortraitAndHeadFrameNetTask2.Result, 2f, null, true);
				}
			};
			changeHeadPortraitAndHeadFrameNetTask.Start(null);
		}

		// Token: 0x060123BB RID: 74683 RVA: 0x004B09F8 File Offset: 0x004AEBF8
		private void PlayerInfoUIController_OnRedemptionCodeUse(string key, Action<int> OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUIController_OnRedemptionCodeUseStringAction`1_hotfix != null)
			{
				this.m_PlayerInfoUIController_OnRedemptionCodeUseStringAction`1_hotfix.call(new object[]
				{
					this,
					key,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<int> OnSucceed = OnSucceed2;
			UseRedemptionCodeNetTask useRedemptionCodeNetTask = new UseRedemptionCodeNetTask(key);
			useRedemptionCodeNetTask.EventOnStop += delegate(Task task)
			{
				UseRedemptionCodeNetTask useRedemptionCodeNetTask2 = task as UseRedemptionCodeNetTask;
				if (useRedemptionCodeNetTask2.Result == 0)
				{
					OnSucceed(useRedemptionCodeNetTask2.ResultDetail);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(useRedemptionCodeNetTask2.Result, 2f, null, true);
				}
			};
			useRedemptionCodeNetTask.Start(null);
		}

		// Token: 0x060123BC RID: 74684 RVA: 0x004B0AA8 File Offset: 0x004AECA8
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
			SceneManager.Instance.PopLayer(this.m_layerArray[1]);
		}

		// Token: 0x060123BD RID: 74685 RVA: 0x004B0B1C File Offset: 0x004AED1C
		private void PlayerInfoUIController_OnShowSign()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUIController_OnShowSign_hotfix != null)
			{
				this.m_PlayerInfoUIController_OnShowSign_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(SignUITask).Name, null);
			UIManager.Instance.StartUITask(intent, true, false, new Action(this.SignUITask_OnLoadAllResCompleted));
		}

		// Token: 0x060123BE RID: 74686 RVA: 0x004B0BB4 File Offset: 0x004AEDB4
		private void SignUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SignUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_SignUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(SignUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x060123BF RID: 74687 RVA: 0x004B0C30 File Offset: 0x004AEE30
		private void PlayerInfoUIController_OnShowPlayerSetting()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUIController_OnShowPlayerSetting_hotfix != null)
			{
				this.m_PlayerInfoUIController_OnShowPlayerSetting_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(PlayerSettingUITask).Name, null);
			UIManager.Instance.StartUITask(intent, true, false, null);
		}

		// Token: 0x060123C0 RID: 74688 RVA: 0x004B0CBC File Offset: 0x004AEEBC
		private void PlayerInfoUIController_OnChangeRECState(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUIController_OnChangeRECStateBoolean_hotfix != null)
			{
				this.m_PlayerInfoUIController_OnChangeRECStateBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.ScreenRecordOn = isOn;
			LocalConfig.Instance.Apply(false);
			LocalConfig.Instance.Save();
			CommonUIController.Instance.EnableScreenRecordFunction = isOn;
		}

		// Token: 0x060123C1 RID: 74689 RVA: 0x004B0D60 File Offset: 0x004AEF60
		private void PlayerInfoUIController_OnCrystalNotEnough()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerInfoUIController_OnCrystalNotEnough_hotfix != null)
			{
				this.m_PlayerInfoUIController_OnCrystalNotEnough_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_CrystalNotEnough, delegate(DialogBoxResult dialogResult)
			{
				if (dialogResult == DialogBoxResult.Ok)
				{
					StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
				}
			}, (StringTableId)0, (StringTableId)0);
		}

		// Token: 0x140003F1 RID: 1009
		// (add) Token: 0x060123C2 RID: 74690 RVA: 0x004B0DE0 File Offset: 0x004AEFE0
		// (remove) Token: 0x060123C3 RID: 74691 RVA: 0x004B0E7C File Offset: 0x004AF07C
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

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x060123C4 RID: 74692 RVA: 0x004B0F18 File Offset: 0x004AF118
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

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x060123C5 RID: 74693 RVA: 0x004B0F8C File Offset: 0x004AF18C
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

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x060123C6 RID: 74694 RVA: 0x004B1000 File Offset: 0x004AF200
		// (set) Token: 0x060123C7 RID: 74695 RVA: 0x004B1020 File Offset: 0x004AF220
		[DoNotToLua]
		public new PlayerInfoUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerInfoUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060123C8 RID: 74696 RVA: 0x004B102C File Offset: 0x004AF22C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x060123C9 RID: 74697 RVA: 0x004B1038 File Offset: 0x004AF238
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060123CA RID: 74698 RVA: 0x004B1040 File Offset: 0x004AF240
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060123CB RID: 74699 RVA: 0x004B1048 File Offset: 0x004AF248
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x060123CC RID: 74700 RVA: 0x004B1054 File Offset: 0x004AF254
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x060123CD RID: 74701 RVA: 0x004B1060 File Offset: 0x004AF260
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x060123CE RID: 74702 RVA: 0x004B106C File Offset: 0x004AF26C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060123CF RID: 74703 RVA: 0x004B1074 File Offset: 0x004AF274
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060123D0 RID: 74704 RVA: 0x004B107C File Offset: 0x004AF27C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x060123D1 RID: 74705 RVA: 0x004B1084 File Offset: 0x004AF284
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x060123D2 RID: 74706 RVA: 0x004B108C File Offset: 0x004AF28C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060123D3 RID: 74707 RVA: 0x004B1094 File Offset: 0x004AF294
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x060123D4 RID: 74708 RVA: 0x004B109C File Offset: 0x004AF29C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x060123D5 RID: 74709 RVA: 0x004B10A4 File Offset: 0x004AF2A4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x060123D6 RID: 74710 RVA: 0x004B10B0 File Offset: 0x004AF2B0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060123D7 RID: 74711 RVA: 0x004B10BC File Offset: 0x004AF2BC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060123D8 RID: 74712 RVA: 0x004B10C8 File Offset: 0x004AF2C8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060123D9 RID: 74713 RVA: 0x004B10D4 File Offset: 0x004AF2D4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060123DA RID: 74714 RVA: 0x004B10DC File Offset: 0x004AF2DC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060123DB RID: 74715 RVA: 0x004B10E4 File Offset: 0x004AF2E4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060123DC RID: 74716 RVA: 0x004B10EC File Offset: 0x004AF2EC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060123DD RID: 74717 RVA: 0x004B10F4 File Offset: 0x004AF2F4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060123DE RID: 74718 RVA: 0x004B10FC File Offset: 0x004AF2FC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060123DF RID: 74719 RVA: 0x004B1104 File Offset: 0x004AF304
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x060123E0 RID: 74720 RVA: 0x004B1124 File Offset: 0x004AF324
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x060123E6 RID: 74726 RVA: 0x004B1264 File Offset: 0x004AF464
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
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PlayerInfoUIController_OnClose_hotfix = (luaObj.RawGet("PlayerInfoUIController_OnClose") as LuaFunction);
					this.m_PlayerInfoUIController_OnShowChangeIconPanel_hotfix = (luaObj.RawGet("PlayerInfoUIController_OnShowChangeIconPanel") as LuaFunction);
					this.m_PlayerInfoUIController_OnChangeNameString_hotfix = (luaObj.RawGet("PlayerInfoUIController_OnChangeName") as LuaFunction);
					this.m_PlayerInfoUIController_OnWatchMyBusinessCard_hotfix = (luaObj.RawGet("PlayerInfoUIController_OnWatchMyBusinessCard") as LuaFunction);
					this.m_PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrameInt32Int32_hotfix = (luaObj.RawGet("PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrame") as LuaFunction);
					this.m_PlayerInfoUIController_OnRedemptionCodeUseStringAction`1_hotfix = (luaObj.RawGet("PlayerInfoUIController_OnRedemptionCodeUse") as LuaFunction);
					this.m_PlayerSettingUIController_OnClose_hotfix = (luaObj.RawGet("PlayerSettingUIController_OnClose") as LuaFunction);
					this.m_PlayerInfoUIController_OnShowSign_hotfix = (luaObj.RawGet("PlayerInfoUIController_OnShowSign") as LuaFunction);
					this.m_SignUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("SignUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_PlayerInfoUIController_OnShowPlayerSetting_hotfix = (luaObj.RawGet("PlayerInfoUIController_OnShowPlayerSetting") as LuaFunction);
					this.m_PlayerInfoUIController_OnChangeRECStateBoolean_hotfix = (luaObj.RawGet("PlayerInfoUIController_OnChangeRECState") as LuaFunction);
					this.m_PlayerInfoUIController_OnCrystalNotEnough_hotfix = (luaObj.RawGet("PlayerInfoUIController_OnCrystalNotEnough") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060123E7 RID: 74727 RVA: 0x004B1558 File Offset: 0x004AF758
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerInfoUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A474 RID: 42100
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "PlayerInfoUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/PlayerInfo_ABS/Prefab/PlayerInfoUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A475 RID: 42101
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "PlayerInfoUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerInfoUIController"),
				m_ctrlName = "PlayerInfoUIController"
			}
		};

		// Token: 0x0400A476 RID: 42102
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400A477 RID: 42103
		private PlayerInfoUIController m_playerInfoUIController;

		// Token: 0x0400A478 RID: 42104
		[DoNotToLua]
		private PlayerInfoUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A479 RID: 42105
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A47A RID: 42106
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A47B RID: 42107
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A47C RID: 42108
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A47D RID: 42109
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A47E RID: 42110
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A47F RID: 42111
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A480 RID: 42112
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x0400A481 RID: 42113
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A482 RID: 42114
		private LuaFunction m_PlayerInfoUIController_OnClose_hotfix;

		// Token: 0x0400A483 RID: 42115
		private LuaFunction m_PlayerInfoUIController_OnShowChangeIconPanel_hotfix;

		// Token: 0x0400A484 RID: 42116
		private LuaFunction m_PlayerInfoUIController_OnChangeNameString_hotfix;

		// Token: 0x0400A485 RID: 42117
		private LuaFunction m_PlayerInfoUIController_OnWatchMyBusinessCard_hotfix;

		// Token: 0x0400A486 RID: 42118
		private LuaFunction m_PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrameInt32Int32_hotfix;

		// Token: 0x0400A487 RID: 42119
		private LuaFunction m_PlayerInfoUIController_OnRedemptionCodeUseStringAction;

		// Token: 0x0400A488 RID: 42120
		private LuaFunction m_PlayerSettingUIController_OnClose_hotfix;

		// Token: 0x0400A489 RID: 42121
		private LuaFunction m_PlayerInfoUIController_OnShowSign_hotfix;

		// Token: 0x0400A48A RID: 42122
		private LuaFunction m_SignUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400A48B RID: 42123
		private LuaFunction m_PlayerInfoUIController_OnShowPlayerSetting_hotfix;

		// Token: 0x0400A48C RID: 42124
		private LuaFunction m_PlayerInfoUIController_OnChangeRECStateBoolean_hotfix;

		// Token: 0x0400A48D RID: 42125
		private LuaFunction m_PlayerInfoUIController_OnCrystalNotEnough_hotfix;

		// Token: 0x0400A48E RID: 42126
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400A48F RID: 42127
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400A490 RID: 42128
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A491 RID: 42129
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E97 RID: 3735
		public new class LuaExportHelper
		{
			// Token: 0x060123E8 RID: 74728 RVA: 0x004B15C0 File Offset: 0x004AF7C0
			public LuaExportHelper(PlayerInfoUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060123E9 RID: 74729 RVA: 0x004B15D0 File Offset: 0x004AF7D0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060123EA RID: 74730 RVA: 0x004B15E0 File Offset: 0x004AF7E0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060123EB RID: 74731 RVA: 0x004B15F0 File Offset: 0x004AF7F0
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060123EC RID: 74732 RVA: 0x004B1600 File Offset: 0x004AF800
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060123ED RID: 74733 RVA: 0x004B1610 File Offset: 0x004AF810
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060123EE RID: 74734 RVA: 0x004B1620 File Offset: 0x004AF820
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060123EF RID: 74735 RVA: 0x004B1630 File Offset: 0x004AF830
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060123F0 RID: 74736 RVA: 0x004B1640 File Offset: 0x004AF840
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060123F1 RID: 74737 RVA: 0x004B1650 File Offset: 0x004AF850
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060123F2 RID: 74738 RVA: 0x004B1660 File Offset: 0x004AF860
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060123F3 RID: 74739 RVA: 0x004B1670 File Offset: 0x004AF870
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060123F4 RID: 74740 RVA: 0x004B1680 File Offset: 0x004AF880
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060123F5 RID: 74741 RVA: 0x004B1690 File Offset: 0x004AF890
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060123F6 RID: 74742 RVA: 0x004B16A0 File Offset: 0x004AF8A0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060123F7 RID: 74743 RVA: 0x004B16B0 File Offset: 0x004AF8B0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060123F8 RID: 74744 RVA: 0x004B16C0 File Offset: 0x004AF8C0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060123F9 RID: 74745 RVA: 0x004B16D0 File Offset: 0x004AF8D0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060123FA RID: 74746 RVA: 0x004B16E0 File Offset: 0x004AF8E0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060123FB RID: 74747 RVA: 0x004B16F0 File Offset: 0x004AF8F0
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060123FC RID: 74748 RVA: 0x004B1700 File Offset: 0x004AF900
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060123FD RID: 74749 RVA: 0x004B1710 File Offset: 0x004AF910
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060123FE RID: 74750 RVA: 0x004B1720 File Offset: 0x004AF920
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060123FF RID: 74751 RVA: 0x004B1730 File Offset: 0x004AF930
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x06012400 RID: 74752 RVA: 0x004B1740 File Offset: 0x004AF940
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06012401 RID: 74753 RVA: 0x004B1750 File Offset: 0x004AF950
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17003791 RID: 14225
			// (get) Token: 0x06012402 RID: 74754 RVA: 0x004B1760 File Offset: 0x004AF960
			// (set) Token: 0x06012403 RID: 74755 RVA: 0x004B1770 File Offset: 0x004AF970
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

			// Token: 0x17003792 RID: 14226
			// (get) Token: 0x06012404 RID: 74756 RVA: 0x004B1780 File Offset: 0x004AF980
			// (set) Token: 0x06012405 RID: 74757 RVA: 0x004B1790 File Offset: 0x004AF990
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

			// Token: 0x17003793 RID: 14227
			// (get) Token: 0x06012406 RID: 74758 RVA: 0x004B17A0 File Offset: 0x004AF9A0
			// (set) Token: 0x06012407 RID: 74759 RVA: 0x004B17B0 File Offset: 0x004AF9B0
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

			// Token: 0x17003794 RID: 14228
			// (get) Token: 0x06012408 RID: 74760 RVA: 0x004B17C0 File Offset: 0x004AF9C0
			// (set) Token: 0x06012409 RID: 74761 RVA: 0x004B17D0 File Offset: 0x004AF9D0
			public PlayerInfoUIController m_playerInfoUIController
			{
				get
				{
					return this.m_owner.m_playerInfoUIController;
				}
				set
				{
					this.m_owner.m_playerInfoUIController = value;
				}
			}

			// Token: 0x17003795 RID: 14229
			// (get) Token: 0x0601240A RID: 74762 RVA: 0x004B17E0 File Offset: 0x004AF9E0
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003796 RID: 14230
			// (get) Token: 0x0601240B RID: 74763 RVA: 0x004B17F0 File Offset: 0x004AF9F0
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0601240C RID: 74764 RVA: 0x004B1800 File Offset: 0x004AFA00
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0601240D RID: 74765 RVA: 0x004B1810 File Offset: 0x004AFA10
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0601240E RID: 74766 RVA: 0x004B1820 File Offset: 0x004AFA20
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0601240F RID: 74767 RVA: 0x004B1830 File Offset: 0x004AFA30
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06012410 RID: 74768 RVA: 0x004B1840 File Offset: 0x004AFA40
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x06012411 RID: 74769 RVA: 0x004B1850 File Offset: 0x004AFA50
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06012412 RID: 74770 RVA: 0x004B1860 File Offset: 0x004AFA60
			public void PlayerInfoUIController_OnClose()
			{
				this.m_owner.PlayerInfoUIController_OnClose();
			}

			// Token: 0x06012413 RID: 74771 RVA: 0x004B1870 File Offset: 0x004AFA70
			public void PlayerInfoUIController_OnShowChangeIconPanel()
			{
				this.m_owner.PlayerInfoUIController_OnShowChangeIconPanel();
			}

			// Token: 0x06012414 RID: 74772 RVA: 0x004B1880 File Offset: 0x004AFA80
			public void PlayerInfoUIController_OnChangeName(string name)
			{
				this.m_owner.PlayerInfoUIController_OnChangeName(name);
			}

			// Token: 0x06012415 RID: 74773 RVA: 0x004B1890 File Offset: 0x004AFA90
			public void PlayerInfoUIController_OnWatchMyBusinessCard()
			{
				this.m_owner.PlayerInfoUIController_OnWatchMyBusinessCard();
			}

			// Token: 0x06012416 RID: 74774 RVA: 0x004B18A0 File Offset: 0x004AFAA0
			public void PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrame(int headPortraitId, int headFreameId)
			{
				this.m_owner.PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrame(headPortraitId, headFreameId);
			}

			// Token: 0x06012417 RID: 74775 RVA: 0x004B18B0 File Offset: 0x004AFAB0
			public void PlayerInfoUIController_OnRedemptionCodeUse(string key, Action<int> OnSucceed)
			{
				this.m_owner.PlayerInfoUIController_OnRedemptionCodeUse(key, OnSucceed);
			}

			// Token: 0x06012418 RID: 74776 RVA: 0x004B18C0 File Offset: 0x004AFAC0
			public void PlayerSettingUIController_OnClose()
			{
				this.m_owner.PlayerSettingUIController_OnClose();
			}

			// Token: 0x06012419 RID: 74777 RVA: 0x004B18D0 File Offset: 0x004AFAD0
			public void PlayerInfoUIController_OnShowSign()
			{
				this.m_owner.PlayerInfoUIController_OnShowSign();
			}

			// Token: 0x0601241A RID: 74778 RVA: 0x004B18E0 File Offset: 0x004AFAE0
			public void SignUITask_OnLoadAllResCompleted()
			{
				this.m_owner.SignUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0601241B RID: 74779 RVA: 0x004B18F0 File Offset: 0x004AFAF0
			public void PlayerInfoUIController_OnShowPlayerSetting()
			{
				this.m_owner.PlayerInfoUIController_OnShowPlayerSetting();
			}

			// Token: 0x0601241C RID: 74780 RVA: 0x004B1900 File Offset: 0x004AFB00
			public void PlayerInfoUIController_OnChangeRECState(bool isOn)
			{
				this.m_owner.PlayerInfoUIController_OnChangeRECState(isOn);
			}

			// Token: 0x0601241D RID: 74781 RVA: 0x004B1910 File Offset: 0x004AFB10
			public void PlayerInfoUIController_OnCrystalNotEnough()
			{
				this.m_owner.PlayerInfoUIController_OnCrystalNotEnough();
			}

			// Token: 0x0400A492 RID: 42130
			private PlayerInfoUITask m_owner;
		}
	}
}
