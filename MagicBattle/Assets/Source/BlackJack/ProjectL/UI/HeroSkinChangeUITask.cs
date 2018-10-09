using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
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
	// Token: 0x02000E07 RID: 3591
	[HotFix]
	public class HeroSkinChangeUITask : UITask
	{
		// Token: 0x060112B7 RID: 70327 RVA: 0x00473E2C File Offset: 0x0047202C
		public HeroSkinChangeUITask(string name) : base(name)
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

		// Token: 0x060112B8 RID: 70328 RVA: 0x00473F20 File Offset: 0x00472120
		public static HeroSkinChangeUITask StartUITask(string mode, int heroSkinInfoId = 0, Hero hero = null, UIIntent preUIIntent = null)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(HeroSkinChangeUITask).Name, null);
			if (preUIIntent != null)
			{
				uiintentCustom = new UIIntentReturnable(preUIIntent, typeof(HeroSkinChangeUITask).Name, null);
			}
			uiintentCustom.SetParam("HeroSkinInfoId", heroSkinInfoId);
			uiintentCustom.SetParam("HeroSkinMode", mode);
			uiintentCustom.SetParam("HeroObj", hero);
			UIManager instance = UIManager.Instance;
			UIIntent intent = uiintentCustom;
			bool pushIntentToStack = true;
			bool clearIntentStack = false;
			if (HeroSkinChangeUITask.<>f__mg$cache0 == null)
			{
				HeroSkinChangeUITask.<>f__mg$cache0 = new Action(HeroSkinChangeUITask.HeroSkinChangeUITask_OnLoadAllResCompleted);
			}
			return instance.StartUITask(intent, pushIntentToStack, clearIntentStack, HeroSkinChangeUITask.<>f__mg$cache0) as HeroSkinChangeUITask;
		}

		// Token: 0x060112B9 RID: 70329 RVA: 0x00473FB8 File Offset: 0x004721B8
		public static void HeroSkinChangeUITask_OnLoadAllResCompleted()
		{
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroSkinChangeUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x060112BA RID: 70330 RVA: 0x00473FEC File Offset: 0x004721EC
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
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataHeroInfo configDataHeroInfo = null;
			if (this.m_hero != null)
			{
				configDataHeroInfo = this.m_hero.HeroInfo;
				base.CollectAsset(UIUtility.GetHeroModelAssetPath(this.m_hero));
				base.CollectAsset(this.m_hero.GetActiveJob().JobConnectionInfo.Model);
			}
			else
			{
				ConfigDataHeroSkinInfo configDataHeroSkinInfo = configDataLoader.GetConfigDataHeroSkinInfo(this.m_heroSkinInfoId);
				if (configDataHeroSkinInfo != null)
				{
					configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(configDataHeroSkinInfo.SpecifiedHero);
					base.CollectSpriteAsset(configDataHeroSkinInfo.Icon);
					ConfigDataCharImageSkinResourceInfo configDataCharImageSkinResourceInfo = configDataLoader.GetConfigDataCharImageSkinResourceInfo(configDataHeroSkinInfo.CharImageSkinResource_ID);
					if (configDataCharImageSkinResourceInfo != null)
					{
						base.CollectSpriteAsset(configDataCharImageSkinResourceInfo.Image);
						base.CollectAsset(configDataCharImageSkinResourceInfo.SpineAssetPath);
					}
					foreach (JobConnection2SkinResource jobConnection2SkinResource in configDataHeroSkinInfo.SpecifiedModelSkinResource)
					{
						ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = configDataLoader.GetConfigDataModelSkinResourceInfo(jobConnection2SkinResource.SkinResourceId);
						base.CollectAsset(configDataModelSkinResourceInfo.Model);
					}
				}
				else
				{
					Debug.LogError(string.Format("HeroSkinChangeUITask invlaid heroSkin id: {0}", this.m_heroSkinInfoId));
				}
			}
			if (configDataHeroInfo != null)
			{
				ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.m_charImageInfo;
				base.CollectSpriteAsset(charImageInfo.Image);
				base.CollectAsset(charImageInfo.Spine);
				foreach (int key in configDataHeroInfo.Skins_ID)
				{
					ConfigDataHeroSkinInfo configDataHeroSkinInfo2 = configDataLoader.GetConfigDataHeroSkinInfo(key);
					ConfigDataCharImageSkinResourceInfo configDataCharImageSkinResourceInfo2 = configDataLoader.GetConfigDataCharImageSkinResourceInfo(configDataHeroSkinInfo2.CharImageSkinResource_ID);
					base.CollectSpriteAsset(configDataHeroSkinInfo2.Icon);
					if (configDataCharImageSkinResourceInfo2 != null)
					{
						base.CollectSpriteAsset(configDataCharImageSkinResourceInfo2.Image);
						base.CollectAsset(configDataCharImageSkinResourceInfo2.SpineAssetPath);
					}
					foreach (JobConnection2SkinResource jobConnection2SkinResource2 in configDataHeroSkinInfo2.SpecifiedModelSkinResource)
					{
						ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo2 = configDataLoader.GetConfigDataModelSkinResourceInfo(jobConnection2SkinResource2.SkinResourceId);
						base.CollectAsset(configDataModelSkinResourceInfo2.Model);
					}
				}
			}
			return this.m_assets.Count > 0;
		}

		// Token: 0x060112BB RID: 70331 RVA: 0x004742BC File Offset: 0x004724BC
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
			if (this.m_heroSkinChangeUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_heroSkinChangeUIController = (this.m_uiCtrlArray[0] as HeroSkinChangeUIController);
				}
				if (this.m_heroSkinChangeUIController != null)
				{
					this.m_heroSkinChangeUIController.EventOnReturn += this.HeroCharSkinChangeUIController_OnClose;
					this.m_heroSkinChangeUIController.EventOnBuySkin += this.HeroCharSkinChangeUIController_OnBuySkin;
					this.m_heroSkinChangeUIController.EventOnWearCharSkin += this.HeroCharSkinChangeUIController_OnWearCharSkin;
					this.m_heroSkinChangeUIController.EventOnTakeOffCharSkin += this.HeroCharSkinChangeUIController_OnTakeOffCharSkin;
					this.m_heroSkinChangeUIController.EventOnSkinChangedPreview += this.HeroSkinChangeUIController_OnSkinChangedPreview;
					this.m_heroSkinChangeUIController.EventOnSkinTicketButtonClick += this.HeroSkinChangeUIController_OnSkinTicketBuy;
				}
			}
		}

		// Token: 0x060112BC RID: 70332 RVA: 0x004743F0 File Offset: 0x004725F0
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
			if (this.m_heroSkinChangeUIController != null)
			{
				this.m_heroSkinChangeUIController.EventOnReturn -= this.HeroCharSkinChangeUIController_OnClose;
				this.m_heroSkinChangeUIController.EventOnBuySkin -= this.HeroCharSkinChangeUIController_OnBuySkin;
				this.m_heroSkinChangeUIController.EventOnWearCharSkin -= this.HeroCharSkinChangeUIController_OnWearCharSkin;
				this.m_heroSkinChangeUIController.EventOnTakeOffCharSkin -= this.HeroCharSkinChangeUIController_OnTakeOffCharSkin;
				this.m_heroSkinChangeUIController.EventOnSkinChangedPreview -= this.HeroSkinChangeUIController_OnSkinChangedPreview;
				this.m_heroSkinChangeUIController.EventOnSkinTicketButtonClick -= this.HeroSkinChangeUIController_OnSkinTicketBuy;
				this.m_heroSkinChangeUIController = null;
				this.EventOnBuySkinSucceed = null;
				this.EventOnAddSkinTicket = null;
			}
		}

		// Token: 0x060112BD RID: 70333 RVA: 0x00474508 File Offset: 0x00472708
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

		// Token: 0x060112BE RID: 70334 RVA: 0x00474594 File Offset: 0x00472794
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

		// Token: 0x060112BF RID: 70335 RVA: 0x00474620 File Offset: 0x00472820
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
			this.EventOnClose = null;
			this.EventOnBuySkinSucceed = null;
			this.EventOnSkinChangedPreview = null;
			this.EventOnAddSkinTicket = null;
		}

		// Token: 0x060112C0 RID: 70336 RVA: 0x004746A4 File Offset: 0x004728A4
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

		// Token: 0x060112C1 RID: 70337 RVA: 0x00474730 File Offset: 0x00472930
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
				this.m_heroSkinInfoId = uiintentCustom.GetStructParam<int>("HeroSkinInfoId");
				this.m_skinMode = uiintentCustom.GetClassParam<string>("HeroSkinMode");
				this.m_hero = uiintentCustom.GetClassParam<Hero>("HeroObj");
			}
		}

		// Token: 0x060112C2 RID: 70338 RVA: 0x004747E0 File Offset: 0x004729E0
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

		// Token: 0x060112C3 RID: 70339 RVA: 0x00474848 File Offset: 0x00472A48
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
				this.m_heroSkinChangeUIController.Open(this.m_skinMode);
			}
			this.m_heroSkinChangeUIController.UpdateViewInHeroCharSkin(this.m_heroSkinInfoId, this.m_skinMode, this.m_hero);
		}

		// Token: 0x060112C4 RID: 70340 RVA: 0x004748E4 File Offset: 0x00472AE4
		private void HeroCharSkinChangeUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCharSkinChangeUIController_OnClose_hotfix != null)
			{
				this.m_HeroCharSkinChangeUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
			base.Pause();
			this.m_heroSkinInfoId = 0;
			this.m_skinMode = null;
			this.m_hero = null;
		}

		// Token: 0x060112C5 RID: 70341 RVA: 0x00474978 File Offset: 0x00472B78
		private void HeroCharSkinChangeUIController_OnBuySkin(int skinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCharSkinChangeUIController_OnBuySkinInt32_hotfix != null)
			{
				this.m_HeroCharSkinChangeUIController_OnBuySkinInt32_hotfix.call(new object[]
				{
					this,
					skinId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int skinId = skinId2;
			HeroSkinChangeUITask $this = this;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = configDataLoader.GetConfigDataHeroSkinInfo(skinId);
			int num = projectLPlayerContext.CanBuyFixedStoreGoods(5, configDataHeroSkinInfo.FixedStoreItemId, -1);
			if (num == 0)
			{
				FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask = new FixedStoreBuyStoreItemNetTask(5, configDataHeroSkinInfo.FixedStoreItemId, -1);
				fixedStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
				{
					FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask2 = task as FixedStoreBuyStoreItemNetTask;
					if (fixedStoreBuyStoreItemNetTask2.Result == 0)
					{
						ConfigDataHeroSkinInfo configDataHeroSkinInfo2 = configDataLoader.GetConfigDataHeroSkinInfo(skinId);
						if ($this.EventOnBuySkinSucceed != null)
						{
							$this.EventOnBuySkinSucceed(configDataHeroSkinInfo2.FixedStoreItemId);
						}
						$this.m_heroSkinInfoId = skinId;
						$this.StartUpdatePipeLine(null, false, false, true);
						List<Goods> list = new List<Goods>();
						Goods item = new Goods
						{
							GoodsType = GoodsType.GoodsType_HeroSkin,
							Id = skinId,
							Count = 1
						};
						list.Add(item);
						GetRewardGoodsUITask.StartUITask(list);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(fixedStoreBuyStoreItemNetTask2.Result, 2f, null, true);
					}
				};
				fixedStoreBuyStoreItemNetTask.Start(null);
			}
			else if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_currIntent);
			}
			else if (num == -416)
			{
				CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_SkinTicketNotEnough, delegate(DialogBoxResult dialogResult)
				{
					if (dialogResult == DialogBoxResult.Ok)
					{
						$this.Pause();
						UIIntentReturnable uiintentReturnable = $this.m_currIntent as UIIntentReturnable;
						if (uiintentReturnable != null && SystemUtility.IsLowSystemMemory())
						{
							while (uiintentReturnable.TargetTaskName != typeof(HeroListUITask).Name)
							{
								uiintentReturnable = (uiintentReturnable.PrevTaskIntent as UIIntentReturnable);
								if (uiintentReturnable == null)
								{
									uiintentReturnable = ($this.m_currIntent as UIIntentReturnable);
									break;
								}
							}
						}
						StoreUITask.SpecialStartStoreUITask(uiintentReturnable, StoreId.StoreId_Gift);
					}
				}, (StringTableId)0, (StringTableId)0);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x060112C6 RID: 70342 RVA: 0x00474AD4 File Offset: 0x00472CD4
		private void HeroCharSkinChangeUIController_OnTakeOffCharSkin(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCharSkinChangeUIController_OnTakeOffCharSkinInt32_hotfix != null)
			{
				this.m_HeroCharSkinChangeUIController_OnTakeOffCharSkinInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CharSkinTakeOffNetTask charSkinTakeOffNetTask = new CharSkinTakeOffNetTask(heroId);
			charSkinTakeOffNetTask.EventOnStop += delegate(Task task)
			{
				CharSkinTakeOffNetTask charSkinTakeOffNetTask2 = task as CharSkinTakeOffNetTask;
				if (charSkinTakeOffNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(charSkinTakeOffNetTask2.Result, 2f, null, true);
				}
			};
			charSkinTakeOffNetTask.Start(null);
		}

		// Token: 0x060112C7 RID: 70343 RVA: 0x00474B68 File Offset: 0x00472D68
		private void HeroCharSkinChangeUIController_OnWearCharSkin(int heroId, int charSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCharSkinChangeUIController_OnWearCharSkinInt32Int32_hotfix != null)
			{
				this.m_HeroCharSkinChangeUIController_OnWearCharSkinInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					charSkinId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CharSkinWearNetTask charSkinWearNetTask = new CharSkinWearNetTask(heroId, charSkinId);
			charSkinWearNetTask.EventOnStop += delegate(Task task)
			{
				CharSkinWearNetTask charSkinWearNetTask2 = task as CharSkinWearNetTask;
				if (charSkinWearNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(charSkinWearNetTask2.Result, 2f, null, true);
				}
			};
			charSkinWearNetTask.Start(null);
		}

		// Token: 0x060112C8 RID: 70344 RVA: 0x00474C0C File Offset: 0x00472E0C
		private void HeroSkinChangeUIController_OnSkinChangedPreview(string spinePath, int heroSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSkinChangeUIController_OnSkinChangedPreviewStringInt32_hotfix != null)
			{
				this.m_HeroSkinChangeUIController_OnSkinChangedPreviewStringInt32_hotfix.call(new object[]
				{
					this,
					spinePath,
					heroSkinId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSkinChangedPreview != null)
			{
				this.EventOnSkinChangedPreview(spinePath, heroSkinId);
			}
		}

		// Token: 0x060112C9 RID: 70345 RVA: 0x00474CA4 File Offset: 0x00472EA4
		private void HeroSkinChangeUIController_OnSkinTicketBuy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSkinChangeUIController_OnSkinTicketBuy_hotfix != null)
			{
				this.m_HeroSkinChangeUIController_OnSkinTicketBuy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddSkinTicket != null)
			{
				this.EventOnAddSkinTicket();
			}
			this.HeroCharSkinChangeUIController_OnClose();
		}

		// Token: 0x060112CA RID: 70346 RVA: 0x00474D20 File Offset: 0x00472F20
		public void ClearUIControllerData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearUIControllerData_hotfix != null)
			{
				this.m_ClearUIControllerData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroSkinChangeUIController.ClearData();
		}

		// Token: 0x060112CB RID: 70347 RVA: 0x00474D8C File Offset: 0x00472F8C
		public void CloseHeroSkinChangePanelWithAnim(Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseHeroSkinChangePanelWithAnimAction_hotfix != null)
			{
				this.m_CloseHeroSkinChangePanelWithAnimAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroSkinChangeUIController.CloseHeroSkinChangePanel(onEnd);
		}

		// Token: 0x140003AB RID: 939
		// (add) Token: 0x060112CC RID: 70348 RVA: 0x00474E08 File Offset: 0x00473008
		// (remove) Token: 0x060112CD RID: 70349 RVA: 0x00474EA4 File Offset: 0x004730A4
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

		// Token: 0x140003AC RID: 940
		// (add) Token: 0x060112CE RID: 70350 RVA: 0x00474F40 File Offset: 0x00473140
		// (remove) Token: 0x060112CF RID: 70351 RVA: 0x00474FDC File Offset: 0x004731DC
		public event Action<int> EventOnBuySkinSucceed
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBuySkinSucceedAction`1_hotfix != null)
				{
					this.m_add_EventOnBuySkinSucceedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnBuySkinSucceed;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnBuySkinSucceed, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBuySkinSucceedAction`1_hotfix != null)
				{
					this.m_remove_EventOnBuySkinSucceedAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnBuySkinSucceed;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnBuySkinSucceed, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003AD RID: 941
		// (add) Token: 0x060112D0 RID: 70352 RVA: 0x00475078 File Offset: 0x00473278
		// (remove) Token: 0x060112D1 RID: 70353 RVA: 0x00475114 File Offset: 0x00473314
		public event Action<string, int> EventOnSkinChangedPreview
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkinChangedPreviewAction`2_hotfix != null)
				{
					this.m_add_EventOnSkinChangedPreviewAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, int> action = this.EventOnSkinChangedPreview;
				Action<string, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, int>>(ref this.EventOnSkinChangedPreview, (Action<string, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkinChangedPreviewAction`2_hotfix != null)
				{
					this.m_remove_EventOnSkinChangedPreviewAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, int> action = this.EventOnSkinChangedPreview;
				Action<string, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, int>>(ref this.EventOnSkinChangedPreview, (Action<string, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003AE RID: 942
		// (add) Token: 0x060112D2 RID: 70354 RVA: 0x004751B0 File Offset: 0x004733B0
		// (remove) Token: 0x060112D3 RID: 70355 RVA: 0x0047524C File Offset: 0x0047344C
		public event Action EventOnAddSkinTicket
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddSkinTicketAction_hotfix != null)
				{
					this.m_add_EventOnAddSkinTicketAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddSkinTicket;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddSkinTicket, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddSkinTicketAction_hotfix != null)
				{
					this.m_remove_EventOnAddSkinTicketAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddSkinTicket;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddSkinTicket, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x060112D4 RID: 70356 RVA: 0x004752E8 File Offset: 0x004734E8
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

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x060112D5 RID: 70357 RVA: 0x0047535C File Offset: 0x0047355C
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

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x060112D6 RID: 70358 RVA: 0x004753D0 File Offset: 0x004735D0
		// (set) Token: 0x060112D7 RID: 70359 RVA: 0x004753F0 File Offset: 0x004735F0
		[DoNotToLua]
		public new HeroSkinChangeUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroSkinChangeUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060112D8 RID: 70360 RVA: 0x004753FC File Offset: 0x004735FC
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x060112D9 RID: 70361 RVA: 0x00475408 File Offset: 0x00473608
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060112DA RID: 70362 RVA: 0x00475410 File Offset: 0x00473610
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060112DB RID: 70363 RVA: 0x00475418 File Offset: 0x00473618
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x060112DC RID: 70364 RVA: 0x00475424 File Offset: 0x00473624
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x060112DD RID: 70365 RVA: 0x00475430 File Offset: 0x00473630
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x060112DE RID: 70366 RVA: 0x0047543C File Offset: 0x0047363C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060112DF RID: 70367 RVA: 0x00475444 File Offset: 0x00473644
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060112E0 RID: 70368 RVA: 0x0047544C File Offset: 0x0047364C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x060112E1 RID: 70369 RVA: 0x00475454 File Offset: 0x00473654
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x060112E2 RID: 70370 RVA: 0x0047545C File Offset: 0x0047365C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060112E3 RID: 70371 RVA: 0x00475464 File Offset: 0x00473664
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x060112E4 RID: 70372 RVA: 0x0047546C File Offset: 0x0047366C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x060112E5 RID: 70373 RVA: 0x00475474 File Offset: 0x00473674
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x060112E6 RID: 70374 RVA: 0x00475480 File Offset: 0x00473680
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060112E7 RID: 70375 RVA: 0x0047548C File Offset: 0x0047368C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060112E8 RID: 70376 RVA: 0x00475498 File Offset: 0x00473698
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060112E9 RID: 70377 RVA: 0x004754A4 File Offset: 0x004736A4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060112EA RID: 70378 RVA: 0x004754AC File Offset: 0x004736AC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060112EB RID: 70379 RVA: 0x004754B4 File Offset: 0x004736B4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060112EC RID: 70380 RVA: 0x004754BC File Offset: 0x004736BC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060112ED RID: 70381 RVA: 0x004754C4 File Offset: 0x004736C4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060112EE RID: 70382 RVA: 0x004754CC File Offset: 0x004736CC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060112EF RID: 70383 RVA: 0x004754D4 File Offset: 0x004736D4
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x060112F0 RID: 70384 RVA: 0x004754F4 File Offset: 0x004736F4
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x060112F1 RID: 70385 RVA: 0x00475500 File Offset: 0x00473700
		private void __callDele_EventOnBuySkinSucceed(int obj)
		{
			Action<int> eventOnBuySkinSucceed = this.EventOnBuySkinSucceed;
			if (eventOnBuySkinSucceed != null)
			{
				eventOnBuySkinSucceed(obj);
			}
		}

		// Token: 0x060112F2 RID: 70386 RVA: 0x00475524 File Offset: 0x00473724
		private void __clearDele_EventOnBuySkinSucceed(int obj)
		{
			this.EventOnBuySkinSucceed = null;
		}

		// Token: 0x060112F3 RID: 70387 RVA: 0x00475530 File Offset: 0x00473730
		private void __callDele_EventOnSkinChangedPreview(string arg1, int arg2)
		{
			Action<string, int> eventOnSkinChangedPreview = this.EventOnSkinChangedPreview;
			if (eventOnSkinChangedPreview != null)
			{
				eventOnSkinChangedPreview(arg1, arg2);
			}
		}

		// Token: 0x060112F4 RID: 70388 RVA: 0x00475554 File Offset: 0x00473754
		private void __clearDele_EventOnSkinChangedPreview(string arg1, int arg2)
		{
			this.EventOnSkinChangedPreview = null;
		}

		// Token: 0x060112F5 RID: 70389 RVA: 0x00475560 File Offset: 0x00473760
		private void __callDele_EventOnAddSkinTicket()
		{
			Action eventOnAddSkinTicket = this.EventOnAddSkinTicket;
			if (eventOnAddSkinTicket != null)
			{
				eventOnAddSkinTicket();
			}
		}

		// Token: 0x060112F6 RID: 70390 RVA: 0x00475580 File Offset: 0x00473780
		private void __clearDele_EventOnAddSkinTicket()
		{
			this.EventOnAddSkinTicket = null;
		}

		// Token: 0x060112F9 RID: 70393 RVA: 0x0047561C File Offset: 0x0047381C
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
					this.m_HeroCharSkinChangeUIController_OnClose_hotfix = (luaObj.RawGet("HeroCharSkinChangeUIController_OnClose") as LuaFunction);
					this.m_HeroCharSkinChangeUIController_OnBuySkinInt32_hotfix = (luaObj.RawGet("HeroCharSkinChangeUIController_OnBuySkin") as LuaFunction);
					this.m_HeroCharSkinChangeUIController_OnTakeOffCharSkinInt32_hotfix = (luaObj.RawGet("HeroCharSkinChangeUIController_OnTakeOffCharSkin") as LuaFunction);
					this.m_HeroCharSkinChangeUIController_OnWearCharSkinInt32Int32_hotfix = (luaObj.RawGet("HeroCharSkinChangeUIController_OnWearCharSkin") as LuaFunction);
					this.m_HeroSkinChangeUIController_OnSkinChangedPreviewStringInt32_hotfix = (luaObj.RawGet("HeroSkinChangeUIController_OnSkinChangedPreview") as LuaFunction);
					this.m_HeroSkinChangeUIController_OnSkinTicketBuy_hotfix = (luaObj.RawGet("HeroSkinChangeUIController_OnSkinTicketBuy") as LuaFunction);
					this.m_ClearUIControllerData_hotfix = (luaObj.RawGet("ClearUIControllerData") as LuaFunction);
					this.m_CloseHeroSkinChangePanelWithAnimAction_hotfix = (luaObj.RawGet("CloseHeroSkinChangePanelWithAnim") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnBuySkinSucceedAction`1_hotfix = (luaObj.RawGet("add_EventOnBuySkinSucceed") as LuaFunction);
					this.m_remove_EventOnBuySkinSucceedAction`1_hotfix = (luaObj.RawGet("remove_EventOnBuySkinSucceed") as LuaFunction);
					this.m_add_EventOnSkinChangedPreviewAction`2_hotfix = (luaObj.RawGet("add_EventOnSkinChangedPreview") as LuaFunction);
					this.m_remove_EventOnSkinChangedPreviewAction`2_hotfix = (luaObj.RawGet("remove_EventOnSkinChangedPreview") as LuaFunction);
					this.m_add_EventOnAddSkinTicketAction_hotfix = (luaObj.RawGet("add_EventOnAddSkinTicket") as LuaFunction);
					this.m_remove_EventOnAddSkinTicketAction_hotfix = (luaObj.RawGet("remove_EventOnAddSkinTicket") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060112FA RID: 70394 RVA: 0x004759A4 File Offset: 0x00473BA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSkinChangeUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009DBE RID: 40382
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroSkinChangeUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/HeroSkinChangeUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04009DBF RID: 40383
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroSkinChangeUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroSkinChangeUIController"),
				m_ctrlName = "HeroSkinChangeUIController"
			}
		};

		// Token: 0x04009DC0 RID: 40384
		public const string Mode_SkinBuy = "SkinBuyMode";

		// Token: 0x04009DC1 RID: 40385
		public const string Mode_ShowSkinDetail = "ShowSkinDetailMode";

		// Token: 0x04009DC2 RID: 40386
		public const string Mode_ShowOneSkin = "ShowOneSkin";

		// Token: 0x04009DC3 RID: 40387
		private const string ParamKey_HeroSkinInfoId = "HeroSkinInfoId";

		// Token: 0x04009DC4 RID: 40388
		private const string ParamKey_HeroSkinMode = "HeroSkinMode";

		// Token: 0x04009DC5 RID: 40389
		private const string ParamKey_HeroObj = "HeroObj";

		// Token: 0x04009DC6 RID: 40390
		private int m_heroSkinInfoId;

		// Token: 0x04009DC7 RID: 40391
		private string m_skinMode;

		// Token: 0x04009DC8 RID: 40392
		private Hero m_hero;

		// Token: 0x04009DC9 RID: 40393
		private HeroSkinChangeUIController m_heroSkinChangeUIController;

		// Token: 0x04009DCA RID: 40394
		[DoNotToLua]
		private HeroSkinChangeUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009DCB RID: 40395
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x04009DCC RID: 40396
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009DCD RID: 40397
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009DCE RID: 40398
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04009DCF RID: 40399
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04009DD0 RID: 40400
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04009DD1 RID: 40401
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04009DD2 RID: 40402
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04009DD3 RID: 40403
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04009DD4 RID: 40404
		private LuaFunction m_OnPause_hotfix;

		// Token: 0x04009DD5 RID: 40405
		private LuaFunction m_OnNewIntentUIIntent_hotfix;

		// Token: 0x04009DD6 RID: 40406
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04009DD7 RID: 40407
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04009DD8 RID: 40408
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009DD9 RID: 40409
		private LuaFunction m_HeroCharSkinChangeUIController_OnClose_hotfix;

		// Token: 0x04009DDA RID: 40410
		private LuaFunction m_HeroCharSkinChangeUIController_OnBuySkinInt32_hotfix;

		// Token: 0x04009DDB RID: 40411
		private LuaFunction m_HeroCharSkinChangeUIController_OnTakeOffCharSkinInt32_hotfix;

		// Token: 0x04009DDC RID: 40412
		private LuaFunction m_HeroCharSkinChangeUIController_OnWearCharSkinInt32Int32_hotfix;

		// Token: 0x04009DDD RID: 40413
		private LuaFunction m_HeroSkinChangeUIController_OnSkinChangedPreviewStringInt32_hotfix;

		// Token: 0x04009DDE RID: 40414
		private LuaFunction m_HeroSkinChangeUIController_OnSkinTicketBuy_hotfix;

		// Token: 0x04009DDF RID: 40415
		private LuaFunction m_ClearUIControllerData_hotfix;

		// Token: 0x04009DE0 RID: 40416
		private LuaFunction m_CloseHeroSkinChangePanelWithAnimAction_hotfix;

		// Token: 0x04009DE1 RID: 40417
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04009DE2 RID: 40418
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04009DE3 RID: 40419
		private LuaFunction m_add_EventOnBuySkinSucceedAction;

		// Token: 0x04009DE4 RID: 40420
		private LuaFunction m_remove_EventOnBuySkinSucceedAction;

		// Token: 0x04009DE5 RID: 40421
		private LuaFunction m_add_EventOnSkinChangedPreviewAction;

		// Token: 0x04009DE6 RID: 40422
		private LuaFunction m_remove_EventOnSkinChangedPreviewAction;

		// Token: 0x04009DE7 RID: 40423
		private LuaFunction m_add_EventOnAddSkinTicketAction_hotfix;

		// Token: 0x04009DE8 RID: 40424
		private LuaFunction m_remove_EventOnAddSkinTicketAction_hotfix;

		// Token: 0x04009DE9 RID: 40425
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04009DEA RID: 40426
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E08 RID: 3592
		public new class LuaExportHelper
		{
			// Token: 0x060112FB RID: 70395 RVA: 0x00475A0C File Offset: 0x00473C0C
			public LuaExportHelper(HeroSkinChangeUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060112FC RID: 70396 RVA: 0x00475A1C File Offset: 0x00473C1C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060112FD RID: 70397 RVA: 0x00475A2C File Offset: 0x00473C2C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060112FE RID: 70398 RVA: 0x00475A3C File Offset: 0x00473C3C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060112FF RID: 70399 RVA: 0x00475A4C File Offset: 0x00473C4C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06011300 RID: 70400 RVA: 0x00475A5C File Offset: 0x00473C5C
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06011301 RID: 70401 RVA: 0x00475A6C File Offset: 0x00473C6C
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06011302 RID: 70402 RVA: 0x00475A7C File Offset: 0x00473C7C
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06011303 RID: 70403 RVA: 0x00475A8C File Offset: 0x00473C8C
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06011304 RID: 70404 RVA: 0x00475A9C File Offset: 0x00473C9C
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06011305 RID: 70405 RVA: 0x00475AAC File Offset: 0x00473CAC
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06011306 RID: 70406 RVA: 0x00475ABC File Offset: 0x00473CBC
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06011307 RID: 70407 RVA: 0x00475ACC File Offset: 0x00473CCC
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06011308 RID: 70408 RVA: 0x00475ADC File Offset: 0x00473CDC
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06011309 RID: 70409 RVA: 0x00475AEC File Offset: 0x00473CEC
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601130A RID: 70410 RVA: 0x00475AFC File Offset: 0x00473CFC
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0601130B RID: 70411 RVA: 0x00475B0C File Offset: 0x00473D0C
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0601130C RID: 70412 RVA: 0x00475B1C File Offset: 0x00473D1C
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0601130D RID: 70413 RVA: 0x00475B2C File Offset: 0x00473D2C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0601130E RID: 70414 RVA: 0x00475B3C File Offset: 0x00473D3C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0601130F RID: 70415 RVA: 0x00475B4C File Offset: 0x00473D4C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06011310 RID: 70416 RVA: 0x00475B5C File Offset: 0x00473D5C
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06011311 RID: 70417 RVA: 0x00475B6C File Offset: 0x00473D6C
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06011312 RID: 70418 RVA: 0x00475B7C File Offset: 0x00473D7C
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x06011313 RID: 70419 RVA: 0x00475B8C File Offset: 0x00473D8C
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06011314 RID: 70420 RVA: 0x00475B9C File Offset: 0x00473D9C
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x06011315 RID: 70421 RVA: 0x00475BAC File Offset: 0x00473DAC
			public void __callDele_EventOnBuySkinSucceed(int obj)
			{
				this.m_owner.__callDele_EventOnBuySkinSucceed(obj);
			}

			// Token: 0x06011316 RID: 70422 RVA: 0x00475BBC File Offset: 0x00473DBC
			public void __clearDele_EventOnBuySkinSucceed(int obj)
			{
				this.m_owner.__clearDele_EventOnBuySkinSucceed(obj);
			}

			// Token: 0x06011317 RID: 70423 RVA: 0x00475BCC File Offset: 0x00473DCC
			public void __callDele_EventOnSkinChangedPreview(string arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnSkinChangedPreview(arg1, arg2);
			}

			// Token: 0x06011318 RID: 70424 RVA: 0x00475BDC File Offset: 0x00473DDC
			public void __clearDele_EventOnSkinChangedPreview(string arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnSkinChangedPreview(arg1, arg2);
			}

			// Token: 0x06011319 RID: 70425 RVA: 0x00475BEC File Offset: 0x00473DEC
			public void __callDele_EventOnAddSkinTicket()
			{
				this.m_owner.__callDele_EventOnAddSkinTicket();
			}

			// Token: 0x0601131A RID: 70426 RVA: 0x00475BFC File Offset: 0x00473DFC
			public void __clearDele_EventOnAddSkinTicket()
			{
				this.m_owner.__clearDele_EventOnAddSkinTicket();
			}

			// Token: 0x17003500 RID: 13568
			// (get) Token: 0x0601131B RID: 70427 RVA: 0x00475C0C File Offset: 0x00473E0C
			// (set) Token: 0x0601131C RID: 70428 RVA: 0x00475C1C File Offset: 0x00473E1C
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

			// Token: 0x17003501 RID: 13569
			// (get) Token: 0x0601131D RID: 70429 RVA: 0x00475C2C File Offset: 0x00473E2C
			// (set) Token: 0x0601131E RID: 70430 RVA: 0x00475C3C File Offset: 0x00473E3C
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

			// Token: 0x17003502 RID: 13570
			// (get) Token: 0x0601131F RID: 70431 RVA: 0x00475C4C File Offset: 0x00473E4C
			public static string ParamKey_HeroSkinInfoId
			{
				get
				{
					return "HeroSkinInfoId";
				}
			}

			// Token: 0x17003503 RID: 13571
			// (get) Token: 0x06011320 RID: 70432 RVA: 0x00475C54 File Offset: 0x00473E54
			public static string ParamKey_HeroSkinMode
			{
				get
				{
					return "HeroSkinMode";
				}
			}

			// Token: 0x17003504 RID: 13572
			// (get) Token: 0x06011321 RID: 70433 RVA: 0x00475C5C File Offset: 0x00473E5C
			public static string ParamKey_HeroObj
			{
				get
				{
					return "HeroObj";
				}
			}

			// Token: 0x17003505 RID: 13573
			// (get) Token: 0x06011322 RID: 70434 RVA: 0x00475C64 File Offset: 0x00473E64
			// (set) Token: 0x06011323 RID: 70435 RVA: 0x00475C74 File Offset: 0x00473E74
			public int m_heroSkinInfoId
			{
				get
				{
					return this.m_owner.m_heroSkinInfoId;
				}
				set
				{
					this.m_owner.m_heroSkinInfoId = value;
				}
			}

			// Token: 0x17003506 RID: 13574
			// (get) Token: 0x06011324 RID: 70436 RVA: 0x00475C84 File Offset: 0x00473E84
			// (set) Token: 0x06011325 RID: 70437 RVA: 0x00475C94 File Offset: 0x00473E94
			public string m_skinMode
			{
				get
				{
					return this.m_owner.m_skinMode;
				}
				set
				{
					this.m_owner.m_skinMode = value;
				}
			}

			// Token: 0x17003507 RID: 13575
			// (get) Token: 0x06011326 RID: 70438 RVA: 0x00475CA4 File Offset: 0x00473EA4
			// (set) Token: 0x06011327 RID: 70439 RVA: 0x00475CB4 File Offset: 0x00473EB4
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

			// Token: 0x17003508 RID: 13576
			// (get) Token: 0x06011328 RID: 70440 RVA: 0x00475CC4 File Offset: 0x00473EC4
			// (set) Token: 0x06011329 RID: 70441 RVA: 0x00475CD4 File Offset: 0x00473ED4
			public HeroSkinChangeUIController m_heroSkinChangeUIController
			{
				get
				{
					return this.m_owner.m_heroSkinChangeUIController;
				}
				set
				{
					this.m_owner.m_heroSkinChangeUIController = value;
				}
			}

			// Token: 0x17003509 RID: 13577
			// (get) Token: 0x0601132A RID: 70442 RVA: 0x00475CE4 File Offset: 0x00473EE4
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x1700350A RID: 13578
			// (get) Token: 0x0601132B RID: 70443 RVA: 0x00475CF4 File Offset: 0x00473EF4
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0601132C RID: 70444 RVA: 0x00475D04 File Offset: 0x00473F04
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0601132D RID: 70445 RVA: 0x00475D14 File Offset: 0x00473F14
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0601132E RID: 70446 RVA: 0x00475D24 File Offset: 0x00473F24
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0601132F RID: 70447 RVA: 0x00475D34 File Offset: 0x00473F34
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06011330 RID: 70448 RVA: 0x00475D44 File Offset: 0x00473F44
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06011331 RID: 70449 RVA: 0x00475D54 File Offset: 0x00473F54
			public void OnPause()
			{
				this.m_owner.OnPause();
			}

			// Token: 0x06011332 RID: 70450 RVA: 0x00475D64 File Offset: 0x00473F64
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x06011333 RID: 70451 RVA: 0x00475D74 File Offset: 0x00473F74
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x06011334 RID: 70452 RVA: 0x00475D84 File Offset: 0x00473F84
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06011335 RID: 70453 RVA: 0x00475D94 File Offset: 0x00473F94
			public void HeroCharSkinChangeUIController_OnClose()
			{
				this.m_owner.HeroCharSkinChangeUIController_OnClose();
			}

			// Token: 0x06011336 RID: 70454 RVA: 0x00475DA4 File Offset: 0x00473FA4
			public void HeroCharSkinChangeUIController_OnBuySkin(int skinId)
			{
				this.m_owner.HeroCharSkinChangeUIController_OnBuySkin(skinId);
			}

			// Token: 0x06011337 RID: 70455 RVA: 0x00475DB4 File Offset: 0x00473FB4
			public void HeroCharSkinChangeUIController_OnTakeOffCharSkin(int heroId)
			{
				this.m_owner.HeroCharSkinChangeUIController_OnTakeOffCharSkin(heroId);
			}

			// Token: 0x06011338 RID: 70456 RVA: 0x00475DC4 File Offset: 0x00473FC4
			public void HeroCharSkinChangeUIController_OnWearCharSkin(int heroId, int charSkinId)
			{
				this.m_owner.HeroCharSkinChangeUIController_OnWearCharSkin(heroId, charSkinId);
			}

			// Token: 0x06011339 RID: 70457 RVA: 0x00475DD4 File Offset: 0x00473FD4
			public void HeroSkinChangeUIController_OnSkinChangedPreview(string spinePath, int heroSkinId)
			{
				this.m_owner.HeroSkinChangeUIController_OnSkinChangedPreview(spinePath, heroSkinId);
			}

			// Token: 0x0601133A RID: 70458 RVA: 0x00475DE4 File Offset: 0x00473FE4
			public void HeroSkinChangeUIController_OnSkinTicketBuy()
			{
				this.m_owner.HeroSkinChangeUIController_OnSkinTicketBuy();
			}

			// Token: 0x04009DEB RID: 40427
			private HeroSkinChangeUITask m_owner;
		}
	}
}
