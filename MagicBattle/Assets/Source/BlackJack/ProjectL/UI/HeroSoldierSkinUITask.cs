using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E10 RID: 3600
	[HotFix]
	public class HeroSoldierSkinUITask : UITask
	{
		// Token: 0x06011465 RID: 70757 RVA: 0x0047B0A0 File Offset: 0x004792A0
		public HeroSoldierSkinUITask(string name) : base(name)
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

		// Token: 0x06011466 RID: 70758 RVA: 0x0047B198 File Offset: 0x00479398
		public static HeroSoldierSkinUITask StartUITask(Hero hero, bool isFromHeroInfoTab, ConfigDataSoldierInfo curSoldierInfo, UIIntent preUIIntent = null)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(HeroSoldierSkinUITask).Name, null);
			if (preUIIntent != null)
			{
				uiintentCustom = new UIIntentReturnable(preUIIntent, typeof(HeroSoldierSkinUITask).Name, null);
			}
			uiintentCustom.SetParam("HeroObj", hero);
			uiintentCustom.SetParam("IsFromHeroInfoTab", isFromHeroInfoTab);
			uiintentCustom.SetParam("SoldierInfo", curSoldierInfo);
			UIManager instance = UIManager.Instance;
			UIIntent intent = uiintentCustom;
			bool pushIntentToStack = true;
			bool clearIntentStack = false;
			if (HeroSoldierSkinUITask.<>f__mg$cache0 == null)
			{
				HeroSoldierSkinUITask.<>f__mg$cache0 = new Action(HeroSoldierSkinUITask.HeroSoldierSkinUITask_OnLoadAllResCompleted);
			}
			return instance.StartUITask(intent, pushIntentToStack, clearIntentStack, HeroSoldierSkinUITask.<>f__mg$cache0) as HeroSoldierSkinUITask;
		}

		// Token: 0x06011467 RID: 70759 RVA: 0x0047B230 File Offset: 0x00479430
		public static void HeroSoldierSkinUITask_OnLoadAllResCompleted()
		{
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroSoldierSkinUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06011468 RID: 70760 RVA: 0x0047B264 File Offset: 0x00479464
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			base.ClearAssetList();
			Hero hero = this.m_hero;
			base.CollectAsset(hero.GetActiveJob().JobConnectionInfo.Model);
			foreach (int key in hero.HeroInfo.Skins_ID)
			{
				ConfigDataHeroSkinInfo configDataHeroSkinInfo = this.m_configDataLoader.GetConfigDataHeroSkinInfo(key);
				foreach (JobConnection2SkinResource jobConnection2SkinResource in configDataHeroSkinInfo.SpecifiedModelSkinResource)
				{
					ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = this.m_configDataLoader.GetConfigDataModelSkinResourceInfo(jobConnection2SkinResource.SkinResourceId);
					base.CollectAsset(configDataModelSkinResourceInfo.Model);
				}
			}
			List<int> list = new List<int>();
			if (hero.HeroInfo.Soldier_ID != 0)
			{
				list.Add(hero.HeroInfo.Soldier_ID);
			}
			List<int> list2 = new List<int>();
			list2.Add(hero.HeroInfo.JobConnection_ID);
			list2.AddRange(this.m_playerContext.GetUseableJobConnectionInfos(hero.HeroId));
			foreach (int key2 in list2)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(key2);
				if (configDataJobConnectionInfo.IsJobOpen)
				{
					foreach (ConfigDataJobLevelInfo configDataJobLevelInfo in configDataJobConnectionInfo.m_jobLevelInfos)
					{
						if (configDataJobLevelInfo.GotSoldier_ID != 0 && !list.Contains(configDataJobLevelInfo.GotSoldier_ID))
						{
							list.Add(configDataJobLevelInfo.GotSoldier_ID);
						}
					}
				}
			}
			foreach (int key3 in list)
			{
				ConfigDataSoldierInfo configDataSoldierInfo = this.m_configDataLoader.GetConfigDataSoldierInfo(key3);
				if (configDataSoldierInfo != null)
				{
					base.CollectAsset(configDataSoldierInfo.Model);
					foreach (int key4 in configDataSoldierInfo.SoldierSkins_ID)
					{
						ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = this.m_configDataLoader.GetConfigDataSoldierSkinInfo(key4);
						if (configDataSoldierSkinInfo != null)
						{
							if (this.m_playerContext.HasOwn(GoodsType.GoodsType_SoldierSkin, configDataSoldierSkinInfo.ID) || configDataSoldierSkinInfo.IsShowBeforeGet)
							{
								foreach (Soldier2SkinResource soldier2SkinResource in configDataSoldierSkinInfo.SpecifiedSoldier)
								{
									ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo2 = this.m_configDataLoader.GetConfigDataModelSkinResourceInfo(soldier2SkinResource.SkinResourceId);
									base.CollectAsset(configDataModelSkinResourceInfo2.Model);
								}
							}
						}
					}
				}
			}
			return this.m_assets.Count > 0;
		}

		// Token: 0x06011469 RID: 70761 RVA: 0x0047B6A4 File Offset: 0x004798A4
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
			if (this.m_heroSoldierSkinUIController == null && this.m_heroSoldierSkinUIController == null)
			{
				this.m_heroSoldierSkinUIController = (this.m_uiCtrlArray[0] as HeroSoldierSkinUIController);
				this.m_heroSoldierSkinUIController.EventOnReturn += this.HeroSoldierSkinUIController_OnReturn;
				this.m_heroSoldierSkinUIController.EventOnBuyHeroSkin += this.HeroSoldierSkinUIController_OnBuyHeroSkin;
				this.m_heroSoldierSkinUIController.EventOnBuySoldierSkin += this.HeroSoldierSkinUIController_OnBuySoldierSkin;
				this.m_heroSoldierSkinUIController.EventOnWearModelSkin += this.HeroSoldierSkinUIController_OnWearModelSkin;
				this.m_heroSoldierSkinUIController.EventOnWearSoldierSkin += this.HeroSoldierSkinUIController_OnWearSoldierSkin;
				this.m_heroSoldierSkinUIController.EventOnTakeOffModelSkin += this.HeroSoldierSkinUIController_OnTakeOffModelSkin;
				this.m_heroSoldierSkinUIController.EventOnTakeOffSoldierSkin += this.HeroSoldierSkinUIController_OnTakeOffSoldierSkin;
			}
		}

		// Token: 0x0601146A RID: 70762 RVA: 0x0047B7E0 File Offset: 0x004799E0
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
			if (this.m_heroSoldierSkinUIController != null)
			{
				this.m_heroSoldierSkinUIController.EventOnReturn -= this.HeroSoldierSkinUIController_OnReturn;
				this.m_heroSoldierSkinUIController.EventOnBuyHeroSkin -= this.HeroSoldierSkinUIController_OnBuyHeroSkin;
				this.m_heroSoldierSkinUIController.EventOnBuySoldierSkin -= this.HeroSoldierSkinUIController_OnBuySoldierSkin;
				this.m_heroSoldierSkinUIController.EventOnWearModelSkin -= this.HeroSoldierSkinUIController_OnWearModelSkin;
				this.m_heroSoldierSkinUIController.EventOnWearSoldierSkin -= this.HeroSoldierSkinUIController_OnWearSoldierSkin;
				this.m_heroSoldierSkinUIController.EventOnTakeOffModelSkin -= this.HeroSoldierSkinUIController_OnTakeOffModelSkin;
				this.m_heroSoldierSkinUIController.EventOnTakeOffSoldierSkin -= this.HeroSoldierSkinUIController_OnTakeOffSoldierSkin;
				this.m_heroSoldierSkinUIController = null;
			}
		}

		// Token: 0x0601146B RID: 70763 RVA: 0x0047B900 File Offset: 0x00479B00
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
			this.InitDataFromUIIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x0601146C RID: 70764 RVA: 0x0047B98C File Offset: 0x00479B8C
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
			this.InitDataFromUIIntent(intent);
			return base.OnResume(intent);
		}

		// Token: 0x0601146D RID: 70765 RVA: 0x0047BA18 File Offset: 0x00479C18
		protected override void OnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPause_hotfix != null)
			{
				this.m_OnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnPause();
			this.EventOnReturn = null;
		}

		// Token: 0x0601146E RID: 70766 RVA: 0x0047BA88 File Offset: 0x00479C88
		public override bool OnNewIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNewIntentUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnNewIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnNewIntent(intent);
		}

		// Token: 0x0601146F RID: 70767 RVA: 0x0047BB14 File Offset: 0x00479D14
		private void InitDataFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDataFromUIIntentUIIntent_hotfix != null)
			{
				this.m_InitDataFromUIIntentUIIntent_hotfix.call(new object[]
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
				this.m_curSoldierInfo = uiintentCustom.GetClassParam<ConfigDataSoldierInfo>("SoldierInfo");
				this.m_isFromHeroInfoTab = uiintentCustom.GetStructParam<bool>("IsFromHeroInfoTab");
				this.m_hero = uiintentCustom.GetClassParam<Hero>("HeroObj");
			}
		}

		// Token: 0x06011470 RID: 70768 RVA: 0x0047BBC4 File Offset: 0x00479DC4
		protected override void OnMemoryWarning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryWarning_hotfix != null)
			{
				this.m_OnMemoryWarning_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06011471 RID: 70769 RVA: 0x0047BC2C File Offset: 0x00479E2C
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
				this.m_heroSoldierSkinUIController.Open();
			}
			this.m_heroSoldierSkinUIController.UpdateViewInHeroSoldierSkin(this.m_hero, this.m_isFromHeroInfoTab, this.m_curSoldierInfo);
		}

		// Token: 0x06011472 RID: 70770 RVA: 0x0047BCC0 File Offset: 0x00479EC0
		private void HeroSoldierSkinUIController_OnReturn(bool isFromHeroInfoTab)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSoldierSkinUIController_OnReturnBoolean_hotfix != null)
			{
				this.m_HeroSoldierSkinUIController_OnReturnBoolean_hotfix.call(new object[]
				{
					this,
					isFromHeroInfoTab
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
			base.Pause();
		}

		// Token: 0x06011473 RID: 70771 RVA: 0x0047BD4C File Offset: 0x00479F4C
		private void HeroSoldierSkinUIController_OnBuyHeroSkin(int heroSkinInfoId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSoldierSkinUIController_OnBuyHeroSkinInt32_hotfix != null)
			{
				this.m_HeroSoldierSkinUIController_OnBuyHeroSkinInt32_hotfix.call(new object[]
				{
					this,
					heroSkinInfoId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string mode = "SkinBuyMode";
			UIIntent currIntent = this.m_currIntent;
			HeroSkinChangeUITask heroSkinChangeUITask = HeroSkinChangeUITask.StartUITask(mode, heroSkinInfoId, null, currIntent);
			HeroListUITask @object = UIUtility.FindUITaskWithType(typeof(HeroListUITask)) as HeroListUITask;
			heroSkinChangeUITask.EventOnClose += @object.HeroCharChangeTask_EventOnClose;
			heroSkinChangeUITask.EventOnClose += this.HeroSoldierSkinUIController_OnCloseHeroCharChangeTask;
			heroSkinChangeUITask.EventOnAddSkinTicket += @object.HeroCharChangeTask_OnAddSkinTicket;
		}

		// Token: 0x06011474 RID: 70772 RVA: 0x0047BE24 File Offset: 0x0047A024
		public void HeroSoldierSkinUIController_OnCloseHeroCharChangeTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSoldierSkinUIController_OnCloseHeroCharChangeTask_hotfix != null)
			{
				this.m_HeroSoldierSkinUIController_OnCloseHeroCharChangeTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateView();
			HeroSkinChangeUITask heroSkinChangeUITask = UIUtility.FindUITaskWithType(typeof(HeroSkinChangeUITask)) as HeroSkinChangeUITask;
			if (heroSkinChangeUITask != null)
			{
				heroSkinChangeUITask.EventOnClose -= this.HeroSoldierSkinUIController_OnCloseHeroCharChangeTask;
			}
		}

		// Token: 0x06011475 RID: 70773 RVA: 0x0047BEB8 File Offset: 0x0047A0B8
		private void HeroSoldierSkinUIController_OnBuySoldierSkin(int soldierSkinInfoId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSoldierSkinUIController_OnBuySoldierSkinInt32_hotfix != null)
			{
				this.m_HeroSoldierSkinUIController_OnBuySoldierSkinInt32_hotfix.call(new object[]
				{
					this,
					soldierSkinInfoId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = StoreSoldierSkinDetailUITask.StartSoldierSkinDetailPanel(soldierSkinInfoId, StoreSoldierSkinDetailUITask.StartTaskFromType.StartTaskFromHeroDetail, this.m_currIntent);
			storeSoldierSkinDetailUITask.EventOnClose += this.StoreSoldierSkinDetailUITask_EventOnClose;
			storeSoldierSkinDetailUITask.EventOnBuySuccessEnd += this.StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd;
		}

		// Token: 0x06011476 RID: 70774 RVA: 0x0047BF5C File Offset: 0x0047A15C
		public void StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd_hotfix != null)
			{
				this.m_StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartUpdatePipeLine(null, false, false, true);
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = UIUtility.FindUITaskWithType(typeof(StoreSoldierSkinDetailUITask)) as StoreSoldierSkinDetailUITask;
			if (storeSoldierSkinDetailUITask != null)
			{
				storeSoldierSkinDetailUITask.EventOnClose -= this.StoreSoldierSkinDetailUITask_EventOnClose;
				storeSoldierSkinDetailUITask.EventOnBuySuccessEnd -= this.StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd;
			}
		}

		// Token: 0x06011477 RID: 70775 RVA: 0x0047C008 File Offset: 0x0047A208
		public void StoreSoldierSkinDetailUITask_EventOnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreSoldierSkinDetailUITask_EventOnClose_hotfix != null)
			{
				this.m_StoreSoldierSkinDetailUITask_EventOnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartUpdatePipeLine(null, false, false, true);
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = UIUtility.FindUITaskWithType(typeof(StoreSoldierSkinDetailUITask)) as StoreSoldierSkinDetailUITask;
			if (storeSoldierSkinDetailUITask != null)
			{
				storeSoldierSkinDetailUITask.EventOnClose -= this.StoreSoldierSkinDetailUITask_EventOnClose;
				storeSoldierSkinDetailUITask.EventOnBuySuccessEnd -= this.StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd;
			}
		}

		// Token: 0x06011478 RID: 70776 RVA: 0x0047C0B4 File Offset: 0x0047A2B4
		private void HeroSoldierSkinUIController_OnWearModelSkin(int heroId, int jobRelatedId, int modelSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSoldierSkinUIController_OnWearModelSkinInt32Int32Int32_hotfix != null)
			{
				this.m_HeroSoldierSkinUIController_OnWearModelSkinInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId,
					modelSkinId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ModelSkinWearNetTask modelSkinWearNetTask = new ModelSkinWearNetTask(heroId, jobRelatedId, modelSkinId);
			modelSkinWearNetTask.EventOnStop += delegate(Task task)
			{
				ModelSkinWearNetTask modelSkinWearNetTask2 = task as ModelSkinWearNetTask;
				if (modelSkinWearNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(modelSkinWearNetTask2.Result, 2f, null, true);
				}
			};
			modelSkinWearNetTask.Start(null);
		}

		// Token: 0x06011479 RID: 70777 RVA: 0x0047C168 File Offset: 0x0047A368
		private void HeroSoldierSkinUIController_OnTakeOffModelSkin(int heroId, int jobRelatedId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSoldierSkinUIController_OnTakeOffModelSkinInt32Int32_hotfix != null)
			{
				this.m_HeroSoldierSkinUIController_OnTakeOffModelSkinInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ModelSkinTakeOffNetTask modelSkinTakeOffNetTask = new ModelSkinTakeOffNetTask(heroId, jobRelatedId);
			modelSkinTakeOffNetTask.EventOnStop += delegate(Task task)
			{
				ModelSkinTakeOffNetTask modelSkinTakeOffNetTask2 = task as ModelSkinTakeOffNetTask;
				if (modelSkinTakeOffNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(modelSkinTakeOffNetTask2.Result, 2f, null, true);
				}
			};
			modelSkinTakeOffNetTask.Start(null);
		}

		// Token: 0x0601147A RID: 70778 RVA: 0x0047C20C File Offset: 0x0047A40C
		private void HeroSoldierSkinUIController_OnWearSoldierSkin(int heroId, int soldierId, int soldierSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSoldierSkinUIController_OnWearSoldierSkinInt32Int32Int32_hotfix != null)
			{
				this.m_HeroSoldierSkinUIController_OnWearSoldierSkinInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					soldierId,
					soldierSkinId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SoldierSkinWearNetTask soldierSkinWearNetTask = new SoldierSkinWearNetTask(heroId, soldierId, soldierSkinId, LocalConfig.Instance.Data.SetSkinToAllSoldier);
			soldierSkinWearNetTask.EventOnStop += delegate(Task task)
			{
				SoldierSkinWearNetTask soldierSkinWearNetTask2 = task as SoldierSkinWearNetTask;
				if (soldierSkinWearNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(soldierSkinWearNetTask2.Result, 2f, null, true);
				}
			};
			soldierSkinWearNetTask.Start(null);
		}

		// Token: 0x0601147B RID: 70779 RVA: 0x0047C2D0 File Offset: 0x0047A4D0
		private void HeroSoldierSkinUIController_OnTakeOffSoldierSkin(int heroId, int soldierId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSoldierSkinUIController_OnTakeOffSoldierSkinInt32Int32_hotfix != null)
			{
				this.m_HeroSoldierSkinUIController_OnTakeOffSoldierSkinInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					soldierId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SoldierSkinTakeOffNetTask soldierSkinTakeOffNetTask = new SoldierSkinTakeOffNetTask(heroId, soldierId, LocalConfig.Instance.Data.SetSkinToAllSoldier);
			soldierSkinTakeOffNetTask.EventOnStop += delegate(Task task)
			{
				SoldierSkinTakeOffNetTask soldierSkinTakeOffNetTask2 = task as SoldierSkinTakeOffNetTask;
				if (soldierSkinTakeOffNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(soldierSkinTakeOffNetTask2.Result, 2f, null, true);
				}
			};
			soldierSkinTakeOffNetTask.Start(null);
		}

		// Token: 0x0601147C RID: 70780 RVA: 0x0047C384 File Offset: 0x0047A584
		public void BringLayerToTop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BringLayerToTop_hotfix != null)
			{
				this.m_BringLayerToTop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UISceneLayer uisceneLayer = this.m_layerArray[0] as UISceneLayer;
			if (uisceneLayer != null)
			{
				SceneManager.Instance.BringLayerToTop(uisceneLayer);
			}
		}

		// Token: 0x140003B7 RID: 951
		// (add) Token: 0x0601147D RID: 70781 RVA: 0x0047C40C File Offset: 0x0047A60C
		// (remove) Token: 0x0601147E RID: 70782 RVA: 0x0047C4A8 File Offset: 0x0047A6A8
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

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x0601147F RID: 70783 RVA: 0x0047C544 File Offset: 0x0047A744
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

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x06011480 RID: 70784 RVA: 0x0047C5B8 File Offset: 0x0047A7B8
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

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x06011481 RID: 70785 RVA: 0x0047C62C File Offset: 0x0047A82C
		// (set) Token: 0x06011482 RID: 70786 RVA: 0x0047C64C File Offset: 0x0047A84C
		[DoNotToLua]
		public new HeroSoldierSkinUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroSoldierSkinUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011483 RID: 70787 RVA: 0x0047C658 File Offset: 0x0047A858
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06011484 RID: 70788 RVA: 0x0047C664 File Offset: 0x0047A864
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06011485 RID: 70789 RVA: 0x0047C66C File Offset: 0x0047A86C
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06011486 RID: 70790 RVA: 0x0047C674 File Offset: 0x0047A874
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06011487 RID: 70791 RVA: 0x0047C680 File Offset: 0x0047A880
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06011488 RID: 70792 RVA: 0x0047C68C File Offset: 0x0047A88C
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06011489 RID: 70793 RVA: 0x0047C698 File Offset: 0x0047A898
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601148A RID: 70794 RVA: 0x0047C6A0 File Offset: 0x0047A8A0
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0601148B RID: 70795 RVA: 0x0047C6A8 File Offset: 0x0047A8A8
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0601148C RID: 70796 RVA: 0x0047C6B0 File Offset: 0x0047A8B0
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0601148D RID: 70797 RVA: 0x0047C6B8 File Offset: 0x0047A8B8
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0601148E RID: 70798 RVA: 0x0047C6C0 File Offset: 0x0047A8C0
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0601148F RID: 70799 RVA: 0x0047C6C8 File Offset: 0x0047A8C8
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06011490 RID: 70800 RVA: 0x0047C6D0 File Offset: 0x0047A8D0
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06011491 RID: 70801 RVA: 0x0047C6DC File Offset: 0x0047A8DC
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06011492 RID: 70802 RVA: 0x0047C6E8 File Offset: 0x0047A8E8
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06011493 RID: 70803 RVA: 0x0047C6F4 File Offset: 0x0047A8F4
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06011494 RID: 70804 RVA: 0x0047C700 File Offset: 0x0047A900
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06011495 RID: 70805 RVA: 0x0047C708 File Offset: 0x0047A908
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06011496 RID: 70806 RVA: 0x0047C710 File Offset: 0x0047A910
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06011497 RID: 70807 RVA: 0x0047C718 File Offset: 0x0047A918
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06011498 RID: 70808 RVA: 0x0047C720 File Offset: 0x0047A920
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06011499 RID: 70809 RVA: 0x0047C728 File Offset: 0x0047A928
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0601149A RID: 70810 RVA: 0x0047C730 File Offset: 0x0047A930
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0601149B RID: 70811 RVA: 0x0047C750 File Offset: 0x0047A950
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x060114A0 RID: 70816 RVA: 0x0047C87C File Offset: 0x0047AA7C
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
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnPause_hotfix = (luaObj.RawGet("OnPause") as LuaFunction);
					this.m_OnNewIntentUIIntent_hotfix = (luaObj.RawGet("OnNewIntent") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_HeroSoldierSkinUIController_OnReturnBoolean_hotfix = (luaObj.RawGet("HeroSoldierSkinUIController_OnReturn") as LuaFunction);
					this.m_HeroSoldierSkinUIController_OnBuyHeroSkinInt32_hotfix = (luaObj.RawGet("HeroSoldierSkinUIController_OnBuyHeroSkin") as LuaFunction);
					this.m_HeroSoldierSkinUIController_OnCloseHeroCharChangeTask_hotfix = (luaObj.RawGet("HeroSoldierSkinUIController_OnCloseHeroCharChangeTask") as LuaFunction);
					this.m_HeroSoldierSkinUIController_OnBuySoldierSkinInt32_hotfix = (luaObj.RawGet("HeroSoldierSkinUIController_OnBuySoldierSkin") as LuaFunction);
					this.m_StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd_hotfix = (luaObj.RawGet("StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd") as LuaFunction);
					this.m_StoreSoldierSkinDetailUITask_EventOnClose_hotfix = (luaObj.RawGet("StoreSoldierSkinDetailUITask_EventOnClose") as LuaFunction);
					this.m_HeroSoldierSkinUIController_OnWearModelSkinInt32Int32Int32_hotfix = (luaObj.RawGet("HeroSoldierSkinUIController_OnWearModelSkin") as LuaFunction);
					this.m_HeroSoldierSkinUIController_OnTakeOffModelSkinInt32Int32_hotfix = (luaObj.RawGet("HeroSoldierSkinUIController_OnTakeOffModelSkin") as LuaFunction);
					this.m_HeroSoldierSkinUIController_OnWearSoldierSkinInt32Int32Int32_hotfix = (luaObj.RawGet("HeroSoldierSkinUIController_OnWearSoldierSkin") as LuaFunction);
					this.m_HeroSoldierSkinUIController_OnTakeOffSoldierSkinInt32Int32_hotfix = (luaObj.RawGet("HeroSoldierSkinUIController_OnTakeOffSoldierSkin") as LuaFunction);
					this.m_BringLayerToTop_hotfix = (luaObj.RawGet("BringLayerToTop") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060114A1 RID: 70817 RVA: 0x0047CBB8 File Offset: 0x0047ADB8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSoldierSkinUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009E69 RID: 40553
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroSoldierSkinUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroSoldierSkinListPanel.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04009E6A RID: 40554
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroSoldierSkinUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroSoldierSkinUIController"),
				m_ctrlName = "HeroSoldierSkinUIController"
			}
		};

		// Token: 0x04009E6B RID: 40555
		private const string ParamKey_SoldierInfo = "SoldierInfo";

		// Token: 0x04009E6C RID: 40556
		private const string ParamKey_IsFromHeroInfoTab = "IsFromHeroInfoTab";

		// Token: 0x04009E6D RID: 40557
		private const string ParamKey_HeroObject = "HeroObj";

		// Token: 0x04009E6E RID: 40558
		private Hero m_hero;

		// Token: 0x04009E6F RID: 40559
		private bool m_isFromHeroInfoTab = true;

		// Token: 0x04009E70 RID: 40560
		private ConfigDataSoldierInfo m_curSoldierInfo;

		// Token: 0x04009E71 RID: 40561
		private HeroSoldierSkinUIController m_heroSoldierSkinUIController;

		// Token: 0x04009E72 RID: 40562
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009E73 RID: 40563
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009E74 RID: 40564
		[DoNotToLua]
		private HeroSoldierSkinUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009E75 RID: 40565
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x04009E76 RID: 40566
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009E77 RID: 40567
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009E78 RID: 40568
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04009E79 RID: 40569
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04009E7A RID: 40570
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04009E7B RID: 40571
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04009E7C RID: 40572
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04009E7D RID: 40573
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04009E7E RID: 40574
		private LuaFunction m_OnPause_hotfix;

		// Token: 0x04009E7F RID: 40575
		private LuaFunction m_OnNewIntentUIIntent_hotfix;

		// Token: 0x04009E80 RID: 40576
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04009E81 RID: 40577
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04009E82 RID: 40578
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009E83 RID: 40579
		private LuaFunction m_HeroSoldierSkinUIController_OnReturnBoolean_hotfix;

		// Token: 0x04009E84 RID: 40580
		private LuaFunction m_HeroSoldierSkinUIController_OnBuyHeroSkinInt32_hotfix;

		// Token: 0x04009E85 RID: 40581
		private LuaFunction m_HeroSoldierSkinUIController_OnCloseHeroCharChangeTask_hotfix;

		// Token: 0x04009E86 RID: 40582
		private LuaFunction m_HeroSoldierSkinUIController_OnBuySoldierSkinInt32_hotfix;

		// Token: 0x04009E87 RID: 40583
		private LuaFunction m_StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd_hotfix;

		// Token: 0x04009E88 RID: 40584
		private LuaFunction m_StoreSoldierSkinDetailUITask_EventOnClose_hotfix;

		// Token: 0x04009E89 RID: 40585
		private LuaFunction m_HeroSoldierSkinUIController_OnWearModelSkinInt32Int32Int32_hotfix;

		// Token: 0x04009E8A RID: 40586
		private LuaFunction m_HeroSoldierSkinUIController_OnTakeOffModelSkinInt32Int32_hotfix;

		// Token: 0x04009E8B RID: 40587
		private LuaFunction m_HeroSoldierSkinUIController_OnWearSoldierSkinInt32Int32Int32_hotfix;

		// Token: 0x04009E8C RID: 40588
		private LuaFunction m_HeroSoldierSkinUIController_OnTakeOffSoldierSkinInt32Int32_hotfix;

		// Token: 0x04009E8D RID: 40589
		private LuaFunction m_BringLayerToTop_hotfix;

		// Token: 0x04009E8E RID: 40590
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04009E8F RID: 40591
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04009E90 RID: 40592
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04009E91 RID: 40593
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E11 RID: 3601
		public new class LuaExportHelper
		{
			// Token: 0x060114A2 RID: 70818 RVA: 0x0047CC20 File Offset: 0x0047AE20
			public LuaExportHelper(HeroSoldierSkinUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060114A3 RID: 70819 RVA: 0x0047CC30 File Offset: 0x0047AE30
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060114A4 RID: 70820 RVA: 0x0047CC40 File Offset: 0x0047AE40
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060114A5 RID: 70821 RVA: 0x0047CC50 File Offset: 0x0047AE50
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060114A6 RID: 70822 RVA: 0x0047CC60 File Offset: 0x0047AE60
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060114A7 RID: 70823 RVA: 0x0047CC70 File Offset: 0x0047AE70
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060114A8 RID: 70824 RVA: 0x0047CC80 File Offset: 0x0047AE80
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060114A9 RID: 70825 RVA: 0x0047CC90 File Offset: 0x0047AE90
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060114AA RID: 70826 RVA: 0x0047CCA0 File Offset: 0x0047AEA0
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060114AB RID: 70827 RVA: 0x0047CCB0 File Offset: 0x0047AEB0
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060114AC RID: 70828 RVA: 0x0047CCC0 File Offset: 0x0047AEC0
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060114AD RID: 70829 RVA: 0x0047CCD0 File Offset: 0x0047AED0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060114AE RID: 70830 RVA: 0x0047CCE0 File Offset: 0x0047AEE0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060114AF RID: 70831 RVA: 0x0047CCF0 File Offset: 0x0047AEF0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060114B0 RID: 70832 RVA: 0x0047CD00 File Offset: 0x0047AF00
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060114B1 RID: 70833 RVA: 0x0047CD10 File Offset: 0x0047AF10
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060114B2 RID: 70834 RVA: 0x0047CD20 File Offset: 0x0047AF20
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060114B3 RID: 70835 RVA: 0x0047CD30 File Offset: 0x0047AF30
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060114B4 RID: 70836 RVA: 0x0047CD40 File Offset: 0x0047AF40
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060114B5 RID: 70837 RVA: 0x0047CD50 File Offset: 0x0047AF50
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060114B6 RID: 70838 RVA: 0x0047CD60 File Offset: 0x0047AF60
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060114B7 RID: 70839 RVA: 0x0047CD70 File Offset: 0x0047AF70
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060114B8 RID: 70840 RVA: 0x0047CD80 File Offset: 0x0047AF80
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060114B9 RID: 70841 RVA: 0x0047CD90 File Offset: 0x0047AF90
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x060114BA RID: 70842 RVA: 0x0047CDA0 File Offset: 0x0047AFA0
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x060114BB RID: 70843 RVA: 0x0047CDB0 File Offset: 0x0047AFB0
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x17003542 RID: 13634
			// (get) Token: 0x060114BC RID: 70844 RVA: 0x0047CDC0 File Offset: 0x0047AFC0
			// (set) Token: 0x060114BD RID: 70845 RVA: 0x0047CDD0 File Offset: 0x0047AFD0
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

			// Token: 0x17003543 RID: 13635
			// (get) Token: 0x060114BE RID: 70846 RVA: 0x0047CDE0 File Offset: 0x0047AFE0
			// (set) Token: 0x060114BF RID: 70847 RVA: 0x0047CDF0 File Offset: 0x0047AFF0
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

			// Token: 0x17003544 RID: 13636
			// (get) Token: 0x060114C0 RID: 70848 RVA: 0x0047CE00 File Offset: 0x0047B000
			public static string ParamKey_SoldierInfo
			{
				get
				{
					return "SoldierInfo";
				}
			}

			// Token: 0x17003545 RID: 13637
			// (get) Token: 0x060114C1 RID: 70849 RVA: 0x0047CE08 File Offset: 0x0047B008
			public static string ParamKey_IsFromHeroInfoTab
			{
				get
				{
					return "IsFromHeroInfoTab";
				}
			}

			// Token: 0x17003546 RID: 13638
			// (get) Token: 0x060114C2 RID: 70850 RVA: 0x0047CE10 File Offset: 0x0047B010
			public static string ParamKey_HeroObject
			{
				get
				{
					return "HeroObj";
				}
			}

			// Token: 0x17003547 RID: 13639
			// (get) Token: 0x060114C3 RID: 70851 RVA: 0x0047CE18 File Offset: 0x0047B018
			// (set) Token: 0x060114C4 RID: 70852 RVA: 0x0047CE28 File Offset: 0x0047B028
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

			// Token: 0x17003548 RID: 13640
			// (get) Token: 0x060114C5 RID: 70853 RVA: 0x0047CE38 File Offset: 0x0047B038
			// (set) Token: 0x060114C6 RID: 70854 RVA: 0x0047CE48 File Offset: 0x0047B048
			public bool m_isFromHeroInfoTab
			{
				get
				{
					return this.m_owner.m_isFromHeroInfoTab;
				}
				set
				{
					this.m_owner.m_isFromHeroInfoTab = value;
				}
			}

			// Token: 0x17003549 RID: 13641
			// (get) Token: 0x060114C7 RID: 70855 RVA: 0x0047CE58 File Offset: 0x0047B058
			// (set) Token: 0x060114C8 RID: 70856 RVA: 0x0047CE68 File Offset: 0x0047B068
			public ConfigDataSoldierInfo m_curSoldierInfo
			{
				get
				{
					return this.m_owner.m_curSoldierInfo;
				}
				set
				{
					this.m_owner.m_curSoldierInfo = value;
				}
			}

			// Token: 0x1700354A RID: 13642
			// (get) Token: 0x060114C9 RID: 70857 RVA: 0x0047CE78 File Offset: 0x0047B078
			// (set) Token: 0x060114CA RID: 70858 RVA: 0x0047CE88 File Offset: 0x0047B088
			public HeroSoldierSkinUIController m_heroSoldierSkinUIController
			{
				get
				{
					return this.m_owner.m_heroSoldierSkinUIController;
				}
				set
				{
					this.m_owner.m_heroSoldierSkinUIController = value;
				}
			}

			// Token: 0x1700354B RID: 13643
			// (get) Token: 0x060114CB RID: 70859 RVA: 0x0047CE98 File Offset: 0x0047B098
			// (set) Token: 0x060114CC RID: 70860 RVA: 0x0047CEA8 File Offset: 0x0047B0A8
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

			// Token: 0x1700354C RID: 13644
			// (get) Token: 0x060114CD RID: 70861 RVA: 0x0047CEB8 File Offset: 0x0047B0B8
			// (set) Token: 0x060114CE RID: 70862 RVA: 0x0047CEC8 File Offset: 0x0047B0C8
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

			// Token: 0x1700354D RID: 13645
			// (get) Token: 0x060114CF RID: 70863 RVA: 0x0047CED8 File Offset: 0x0047B0D8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x1700354E RID: 13646
			// (get) Token: 0x060114D0 RID: 70864 RVA: 0x0047CEE8 File Offset: 0x0047B0E8
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060114D1 RID: 70865 RVA: 0x0047CEF8 File Offset: 0x0047B0F8
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x060114D2 RID: 70866 RVA: 0x0047CF08 File Offset: 0x0047B108
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060114D3 RID: 70867 RVA: 0x0047CF18 File Offset: 0x0047B118
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060114D4 RID: 70868 RVA: 0x0047CF28 File Offset: 0x0047B128
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x060114D5 RID: 70869 RVA: 0x0047CF38 File Offset: 0x0047B138
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x060114D6 RID: 70870 RVA: 0x0047CF48 File Offset: 0x0047B148
			public void OnPause()
			{
				this.m_owner.OnPause();
			}

			// Token: 0x060114D7 RID: 70871 RVA: 0x0047CF58 File Offset: 0x0047B158
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x060114D8 RID: 70872 RVA: 0x0047CF68 File Offset: 0x0047B168
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x060114D9 RID: 70873 RVA: 0x0047CF78 File Offset: 0x0047B178
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060114DA RID: 70874 RVA: 0x0047CF88 File Offset: 0x0047B188
			public void HeroSoldierSkinUIController_OnReturn(bool isFromHeroInfoTab)
			{
				this.m_owner.HeroSoldierSkinUIController_OnReturn(isFromHeroInfoTab);
			}

			// Token: 0x060114DB RID: 70875 RVA: 0x0047CF98 File Offset: 0x0047B198
			public void HeroSoldierSkinUIController_OnBuyHeroSkin(int heroSkinInfoId)
			{
				this.m_owner.HeroSoldierSkinUIController_OnBuyHeroSkin(heroSkinInfoId);
			}

			// Token: 0x060114DC RID: 70876 RVA: 0x0047CFA8 File Offset: 0x0047B1A8
			public void HeroSoldierSkinUIController_OnBuySoldierSkin(int soldierSkinInfoId)
			{
				this.m_owner.HeroSoldierSkinUIController_OnBuySoldierSkin(soldierSkinInfoId);
			}

			// Token: 0x060114DD RID: 70877 RVA: 0x0047CFB8 File Offset: 0x0047B1B8
			public void HeroSoldierSkinUIController_OnWearModelSkin(int heroId, int jobRelatedId, int modelSkinId)
			{
				this.m_owner.HeroSoldierSkinUIController_OnWearModelSkin(heroId, jobRelatedId, modelSkinId);
			}

			// Token: 0x060114DE RID: 70878 RVA: 0x0047CFC8 File Offset: 0x0047B1C8
			public void HeroSoldierSkinUIController_OnTakeOffModelSkin(int heroId, int jobRelatedId)
			{
				this.m_owner.HeroSoldierSkinUIController_OnTakeOffModelSkin(heroId, jobRelatedId);
			}

			// Token: 0x060114DF RID: 70879 RVA: 0x0047CFD8 File Offset: 0x0047B1D8
			public void HeroSoldierSkinUIController_OnWearSoldierSkin(int heroId, int soldierId, int soldierSkinId)
			{
				this.m_owner.HeroSoldierSkinUIController_OnWearSoldierSkin(heroId, soldierId, soldierSkinId);
			}

			// Token: 0x060114E0 RID: 70880 RVA: 0x0047CFE8 File Offset: 0x0047B1E8
			public void HeroSoldierSkinUIController_OnTakeOffSoldierSkin(int heroId, int soldierId)
			{
				this.m_owner.HeroSoldierSkinUIController_OnTakeOffSoldierSkin(heroId, soldierId);
			}

			// Token: 0x04009E92 RID: 40594
			private HeroSoldierSkinUITask m_owner;
		}
	}
}
