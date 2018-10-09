using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D21 RID: 3361
	[HotFix]
	public class GuildMassiveCombatUITask : UITask
	{
		// Token: 0x0600F7BC RID: 63420 RVA: 0x004168EC File Offset: 0x00414AEC
		public GuildMassiveCombatUITask(string name) : base(name)
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

		// Token: 0x0600F7BD RID: 63421 RVA: 0x00416A54 File Offset: 0x00414C54
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
			base.ClearAssetList();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			Guild guildInfo = projectLPlayerContext.GetGuildInfo();
			GuildMassiveCombatInfo recentCombat = guildInfo.MassiveCombat.RecentCombat;
			if (recentCombat != null)
			{
				List<GuildMassiveCombatStronghold> list = new List<GuildMassiveCombatStronghold>(recentCombat.Strongholds);
				foreach (GuildMassiveCombatStronghold guildMassiveCombatStronghold in list)
				{
					ConfigDataHeroTagInfo configDataHeroTagInfo = configDataLoader.GetConfigDataHeroTagInfo(guildMassiveCombatStronghold.PreferredHeroTagIds[0]);
					base.CollectSpriteAsset(configDataHeroTagInfo.Icon);
					ConfigDataGuildMassiveCombatStrongholdInfo configDataGuildMassiveCombatStrongholdInfo = configDataLoader.GetConfigDataGuildMassiveCombatStrongholdInfo(guildMassiveCombatStronghold.ConfigId);
					base.CollectSpriteAsset(configDataGuildMassiveCombatStrongholdInfo.Resources);
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600F7BE RID: 63422 RVA: 0x00416B98 File Offset: 0x00414D98
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
			if (this.m_guildMassiveCombatUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_guildMassiveCombatUIController = (this.m_uiCtrlArray[0] as GuildMassiveCombatUIController);
				}
				if (this.m_guildMassiveCombatUIController != null)
				{
					this.m_guildMassiveCombatUIController.EventOnReturn += this.OnClose;
					this.m_guildMassiveCombatUIController.EventOnSingleBattle += this.GuildMassiveCombatUIController_OnSingleBattle;
					this.m_guildMassiveCombatUIController.EventOnTeamBattle += this.GuildMassiveCombatUIController_OnTeamBattle;
					this.m_guildMassiveCombatUIController.EventOnGiveUpButtonClick += this.GuildMassiveCombatUIController_OnGiveUpButtonClick;
				}
			}
		}

		// Token: 0x0600F7BF RID: 63423 RVA: 0x00416CA0 File Offset: 0x00414EA0
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
			if (this.m_guildMassiveCombatUIController != null)
			{
				this.m_guildMassiveCombatUIController.EventOnReturn -= this.OnClose;
				this.m_guildMassiveCombatUIController.EventOnSingleBattle -= this.GuildMassiveCombatUIController_OnSingleBattle;
				this.m_guildMassiveCombatUIController.EventOnTeamBattle -= this.GuildMassiveCombatUIController_OnTeamBattle;
				this.m_guildMassiveCombatUIController.EventOnGiveUpButtonClick -= this.GuildMassiveCombatUIController_OnGiveUpButtonClick;
				this.m_guildMassiveCombatUIController = null;
			}
		}

		// Token: 0x0600F7C0 RID: 63424 RVA: 0x00416D7C File Offset: 0x00414F7C
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
				this.m_guildMassiveCombatUIController.Open();
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				RewardPlayerStatus beforeRewardPlayerStatus = projectLPlayerContext.GetBeforeRewardPlayerStatus();
				if (beforeRewardPlayerStatus.GuildMassiveCombatEliminateRate != 0)
				{
					int guildMassiveCombatEliminateRate = projectLPlayerContext.GetGuildMassiveCombatEliminateRate();
					if (guildMassiveCombatEliminateRate >= 100)
					{
						this.m_guildMassiveCombatUIController.ShowCombatResultEffect(true, null);
						beforeRewardPlayerStatus.GuildMassiveCombatEliminateRate = 0;
					}
				}
			}
			this.m_guildMassiveCombatUIController.GuildMassiveCombatUpdateView();
		}

		// Token: 0x0600F7C1 RID: 63425 RVA: 0x00416E44 File Offset: 0x00415044
		private void StartTeamRoomInfoUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartTeamRoomInfoUITask_hotfix != null)
			{
				this.m_StartTeamRoomInfoUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(TeamRoomInfoUITask).Name, null);
			UIManager.Instance.StartUITask(intent, true, false, null);
		}

		// Token: 0x0600F7C2 RID: 63426 RVA: 0x00416ED0 File Offset: 0x004150D0
		private void OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClose_hotfix != null)
			{
				this.m_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600F7C3 RID: 63427 RVA: 0x00416F54 File Offset: 0x00415154
		private void GuildMassiveCombatUIController_OnGiveUpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildMassiveCombatUIController_OnGiveUpButtonClick_hotfix != null)
			{
				this.m_GuildMassiveCombatUIController_OnGiveUpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildMassiveCombatSurrenderNetTask guildMassiveCombatSurrenderNetTask = new GuildMassiveCombatSurrenderNetTask();
			guildMassiveCombatSurrenderNetTask.EventOnStop += delegate(Task task)
			{
				GuildMassiveCombatSurrenderNetTask guildMassiveCombatSurrenderNetTask2 = task as GuildMassiveCombatSurrenderNetTask;
				if (guildMassiveCombatSurrenderNetTask2.Result == 0)
				{
					this.m_guildMassiveCombatUIController.ShowCombatResultEffect(false, delegate
					{
						this.OnClose();
					});
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildMassiveCombatSurrenderNetTask2.Result, 2f, null, true);
				}
			};
			guildMassiveCombatSurrenderNetTask.Start(null);
		}

		// Token: 0x0600F7C4 RID: 63428 RVA: 0x00416FD4 File Offset: 0x004151D4
		private void GuildMassiveCombatUIController_OnSingleBattle(GuildMassiveCombatStronghold strongHold)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildMassiveCombatUIController_OnSingleBattleGuildMassiveCombatStronghold_hotfix != null)
			{
				this.m_GuildMassiveCombatUIController_OnSingleBattleGuildMassiveCombatStronghold_hotfix.call(new object[]
				{
					this,
					strongHold
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackGuildMassiveCombatSinglePVELevel(strongHold.LevelId);
			if (num == 0)
			{
				WorldUITask.StartBattleHappening(BattleType.GuildMassiveCombat, strongHold.LevelId);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x0600F7C5 RID: 63429 RVA: 0x00417088 File Offset: 0x00415288
		private void GuildMassiveCombatUIController_OnTeamBattle(GuildMassiveCombatStronghold strongHold)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildMassiveCombatUIController_OnTeamBattleGuildMassiveCombatStronghold_hotfix != null)
			{
				this.m_GuildMassiveCombatUIController_OnTeamBattleGuildMassiveCombatStronghold_hotfix.call(new object[]
				{
					this,
					strongHold
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			TeamRoomSetting teamRoomSetting = new TeamRoomSetting();
			teamRoomSetting.GameFunctionTypeId = GameFunctionType.GameFunctionType_GuildMassiveCombat;
			teamRoomSetting.LocationId = strongHold.LevelId;
			teamRoomSetting.JoinMinLevel = 1;
			teamRoomSetting.JoinMaxLevel = configDataLoader.ConfigableConstId_PlayerLevelMaxLevel;
			teamRoomSetting.Authority = TeamRoomAuthority.GuildMassiveCombat;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanCreateTeam(teamRoomSetting);
			if (num == 0)
			{
				TeamRoomCreateNetTask teamRoomCreateNetTask = new TeamRoomCreateNetTask(teamRoomSetting);
				teamRoomCreateNetTask.EventOnStop += delegate(Task task)
				{
					TeamRoomCreateNetTask teamRoomCreateNetTask2 = task as TeamRoomCreateNetTask;
					if (teamRoomCreateNetTask2.Result == 0)
					{
						this.StartTeamRoomInfoUITask();
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(teamRoomCreateNetTask2.Result, 2f, null, true);
					}
				};
				teamRoomCreateNetTask.Start(null);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x0600F7C6 RID: 63430 RVA: 0x00417190 File Offset: 0x00415390
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

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x0600F7C7 RID: 63431 RVA: 0x00417204 File Offset: 0x00415404
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

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x0600F7C8 RID: 63432 RVA: 0x00417278 File Offset: 0x00415478
		// (set) Token: 0x0600F7C9 RID: 63433 RVA: 0x00417298 File Offset: 0x00415498
		[DoNotToLua]
		public new GuildMassiveCombatUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildMassiveCombatUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F7CA RID: 63434 RVA: 0x004172A4 File Offset: 0x004154A4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600F7CB RID: 63435 RVA: 0x004172B0 File Offset: 0x004154B0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600F7CC RID: 63436 RVA: 0x004172B8 File Offset: 0x004154B8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600F7CD RID: 63437 RVA: 0x004172C0 File Offset: 0x004154C0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600F7CE RID: 63438 RVA: 0x004172CC File Offset: 0x004154CC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600F7CF RID: 63439 RVA: 0x004172D8 File Offset: 0x004154D8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600F7D0 RID: 63440 RVA: 0x004172E4 File Offset: 0x004154E4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600F7D1 RID: 63441 RVA: 0x004172EC File Offset: 0x004154EC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600F7D2 RID: 63442 RVA: 0x004172F4 File Offset: 0x004154F4
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600F7D3 RID: 63443 RVA: 0x004172FC File Offset: 0x004154FC
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600F7D4 RID: 63444 RVA: 0x00417304 File Offset: 0x00415504
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600F7D5 RID: 63445 RVA: 0x0041730C File Offset: 0x0041550C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600F7D6 RID: 63446 RVA: 0x00417314 File Offset: 0x00415514
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600F7D7 RID: 63447 RVA: 0x0041731C File Offset: 0x0041551C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600F7D8 RID: 63448 RVA: 0x00417328 File Offset: 0x00415528
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600F7D9 RID: 63449 RVA: 0x00417334 File Offset: 0x00415534
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600F7DA RID: 63450 RVA: 0x00417340 File Offset: 0x00415540
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600F7DB RID: 63451 RVA: 0x0041734C File Offset: 0x0041554C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600F7DC RID: 63452 RVA: 0x00417354 File Offset: 0x00415554
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600F7DD RID: 63453 RVA: 0x0041735C File Offset: 0x0041555C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600F7DE RID: 63454 RVA: 0x00417364 File Offset: 0x00415564
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600F7DF RID: 63455 RVA: 0x0041736C File Offset: 0x0041556C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600F7E0 RID: 63456 RVA: 0x00417374 File Offset: 0x00415574
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600F7E5 RID: 63461 RVA: 0x00417438 File Offset: 0x00415638
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
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_StartTeamRoomInfoUITask_hotfix = (luaObj.RawGet("StartTeamRoomInfoUITask") as LuaFunction);
					this.m_OnClose_hotfix = (luaObj.RawGet("OnClose") as LuaFunction);
					this.m_GuildMassiveCombatUIController_OnGiveUpButtonClick_hotfix = (luaObj.RawGet("GuildMassiveCombatUIController_OnGiveUpButtonClick") as LuaFunction);
					this.m_GuildMassiveCombatUIController_OnSingleBattleGuildMassiveCombatStronghold_hotfix = (luaObj.RawGet("GuildMassiveCombatUIController_OnSingleBattle") as LuaFunction);
					this.m_GuildMassiveCombatUIController_OnTeamBattleGuildMassiveCombatStronghold_hotfix = (luaObj.RawGet("GuildMassiveCombatUIController_OnTeamBattle") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F7E6 RID: 63462 RVA: 0x00417618 File Offset: 0x00415818
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009212 RID: 37394
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "GuildMassiveCombatUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Guild_ABS/Prefab/GuildMassiveCombatUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04009213 RID: 37395
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "GuildMassiveCombatUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.GuildMassiveCombatUIController"),
				m_ctrlName = "GuildMassiveCombatUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "GuildMassiveCombatUILayer",
				m_attachPath = "./ContributionPanel",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.GuildContributionUIController"),
				m_ctrlName = "GuildContributionUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "GuildMassiveCombatUILayer",
				m_attachPath = "./RewardInfoPanel",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.GuildMassiveCombatRewardUIController"),
				m_ctrlName = "GuildMassiveCombatRewardUIController"
			}
		};

		// Token: 0x04009214 RID: 37396
		private GuildMassiveCombatUIController m_guildMassiveCombatUIController;

		// Token: 0x04009215 RID: 37397
		[DoNotToLua]
		private GuildMassiveCombatUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009216 RID: 37398
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009217 RID: 37399
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009218 RID: 37400
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04009219 RID: 37401
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400921A RID: 37402
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400921B RID: 37403
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400921C RID: 37404
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400921D RID: 37405
		private LuaFunction m_StartTeamRoomInfoUITask_hotfix;

		// Token: 0x0400921E RID: 37406
		private LuaFunction m_OnClose_hotfix;

		// Token: 0x0400921F RID: 37407
		private LuaFunction m_GuildMassiveCombatUIController_OnGiveUpButtonClick_hotfix;

		// Token: 0x04009220 RID: 37408
		private LuaFunction m_GuildMassiveCombatUIController_OnSingleBattleGuildMassiveCombatStronghold_hotfix;

		// Token: 0x04009221 RID: 37409
		private LuaFunction m_GuildMassiveCombatUIController_OnTeamBattleGuildMassiveCombatStronghold_hotfix;

		// Token: 0x04009222 RID: 37410
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04009223 RID: 37411
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000D22 RID: 3362
		public new class LuaExportHelper
		{
			// Token: 0x0600F7E7 RID: 63463 RVA: 0x00417680 File Offset: 0x00415880
			public LuaExportHelper(GuildMassiveCombatUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F7E8 RID: 63464 RVA: 0x00417690 File Offset: 0x00415890
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600F7E9 RID: 63465 RVA: 0x004176A0 File Offset: 0x004158A0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600F7EA RID: 63466 RVA: 0x004176B0 File Offset: 0x004158B0
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600F7EB RID: 63467 RVA: 0x004176C0 File Offset: 0x004158C0
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600F7EC RID: 63468 RVA: 0x004176D0 File Offset: 0x004158D0
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600F7ED RID: 63469 RVA: 0x004176E0 File Offset: 0x004158E0
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600F7EE RID: 63470 RVA: 0x004176F0 File Offset: 0x004158F0
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600F7EF RID: 63471 RVA: 0x00417700 File Offset: 0x00415900
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600F7F0 RID: 63472 RVA: 0x00417710 File Offset: 0x00415910
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600F7F1 RID: 63473 RVA: 0x00417720 File Offset: 0x00415920
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600F7F2 RID: 63474 RVA: 0x00417730 File Offset: 0x00415930
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600F7F3 RID: 63475 RVA: 0x00417740 File Offset: 0x00415940
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600F7F4 RID: 63476 RVA: 0x00417750 File Offset: 0x00415950
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600F7F5 RID: 63477 RVA: 0x00417760 File Offset: 0x00415960
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600F7F6 RID: 63478 RVA: 0x00417770 File Offset: 0x00415970
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600F7F7 RID: 63479 RVA: 0x00417780 File Offset: 0x00415980
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600F7F8 RID: 63480 RVA: 0x00417790 File Offset: 0x00415990
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600F7F9 RID: 63481 RVA: 0x004177A0 File Offset: 0x004159A0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600F7FA RID: 63482 RVA: 0x004177B0 File Offset: 0x004159B0
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600F7FB RID: 63483 RVA: 0x004177C0 File Offset: 0x004159C0
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600F7FC RID: 63484 RVA: 0x004177D0 File Offset: 0x004159D0
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600F7FD RID: 63485 RVA: 0x004177E0 File Offset: 0x004159E0
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600F7FE RID: 63486 RVA: 0x004177F0 File Offset: 0x004159F0
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002F77 RID: 12151
			// (get) Token: 0x0600F7FF RID: 63487 RVA: 0x00417800 File Offset: 0x00415A00
			// (set) Token: 0x0600F800 RID: 63488 RVA: 0x00417810 File Offset: 0x00415A10
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

			// Token: 0x17002F78 RID: 12152
			// (get) Token: 0x0600F801 RID: 63489 RVA: 0x00417820 File Offset: 0x00415A20
			// (set) Token: 0x0600F802 RID: 63490 RVA: 0x00417830 File Offset: 0x00415A30
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

			// Token: 0x17002F79 RID: 12153
			// (get) Token: 0x0600F803 RID: 63491 RVA: 0x00417840 File Offset: 0x00415A40
			// (set) Token: 0x0600F804 RID: 63492 RVA: 0x00417850 File Offset: 0x00415A50
			public GuildMassiveCombatUIController m_guildMassiveCombatUIController
			{
				get
				{
					return this.m_owner.m_guildMassiveCombatUIController;
				}
				set
				{
					this.m_owner.m_guildMassiveCombatUIController = value;
				}
			}

			// Token: 0x17002F7A RID: 12154
			// (get) Token: 0x0600F805 RID: 63493 RVA: 0x00417860 File Offset: 0x00415A60
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002F7B RID: 12155
			// (get) Token: 0x0600F806 RID: 63494 RVA: 0x00417870 File Offset: 0x00415A70
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600F807 RID: 63495 RVA: 0x00417880 File Offset: 0x00415A80
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600F808 RID: 63496 RVA: 0x00417890 File Offset: 0x00415A90
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600F809 RID: 63497 RVA: 0x004178A0 File Offset: 0x00415AA0
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600F80A RID: 63498 RVA: 0x004178B0 File Offset: 0x00415AB0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600F80B RID: 63499 RVA: 0x004178C0 File Offset: 0x00415AC0
			public void StartTeamRoomInfoUITask()
			{
				this.m_owner.StartTeamRoomInfoUITask();
			}

			// Token: 0x0600F80C RID: 63500 RVA: 0x004178D0 File Offset: 0x00415AD0
			public void OnClose()
			{
				this.m_owner.OnClose();
			}

			// Token: 0x0600F80D RID: 63501 RVA: 0x004178E0 File Offset: 0x00415AE0
			public void GuildMassiveCombatUIController_OnGiveUpButtonClick()
			{
				this.m_owner.GuildMassiveCombatUIController_OnGiveUpButtonClick();
			}

			// Token: 0x0600F80E RID: 63502 RVA: 0x004178F0 File Offset: 0x00415AF0
			public void GuildMassiveCombatUIController_OnSingleBattle(GuildMassiveCombatStronghold strongHold)
			{
				this.m_owner.GuildMassiveCombatUIController_OnSingleBattle(strongHold);
			}

			// Token: 0x0600F80F RID: 63503 RVA: 0x00417900 File Offset: 0x00415B00
			public void GuildMassiveCombatUIController_OnTeamBattle(GuildMassiveCombatStronghold strongHold)
			{
				this.m_owner.GuildMassiveCombatUIController_OnTeamBattle(strongHold);
			}

			// Token: 0x04009224 RID: 37412
			private GuildMassiveCombatUITask m_owner;
		}
	}
}
