using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D8E RID: 3470
	[HotFix]
	public class HeroCommentUITask : UITask
	{
		// Token: 0x0601034B RID: 66379 RVA: 0x0043C238 File Offset: 0x0043A438
		public HeroCommentUITask(string name) : base(name)
		{
			base.RegisterModesDefine(HeroCommentUITask.UIMode_HeroComment, new string[]
			{
				HeroCommentUITask.UIModel_RankingList
			});
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

		// Token: 0x0601034C RID: 66380 RVA: 0x0043C3B8 File Offset: 0x0043A5B8
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
			if (this.m_heroCommentUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_heroCommentUIController = (this.m_uiCtrlArray[0] as HeroCommentUIController);
				}
				if (!(this.m_heroCommentUIController != null))
				{
					Debug.LogError("HeroCommentUIController is null");
					return;
				}
				this.m_heroCommentUIController.EventOnReturn += this.HeroCommentUIController_OnReturn;
				this.m_heroCommentUIController.EventOnNameClick += this.HeroCommentUIController_OnCommenterHeroView;
				this.m_heroCommentUIController.EventOnCommentSend += this.HeroCommentUIController_OnCommentSend;
				this.m_heroCommentUIController.EventOnPraisedBtnClick += this.HeroCommentUIController_OnCommentPraised;
				this.m_heroCommentUIController.EventOnGetHeroComments += this.HeroCommentUIController_OnCommentGet;
				this.m_heroCommentUIController.EventOnRankingQurey += this.HeroCommentUIController_OnRankingQuery;
				this.m_heroCommentUIController.EventOnRankingListLockClick += this.HeroCommentUIController_OnRankingListLockClick;
				this.m_heroCommentUIController.m_rankingListUICtrl.CreateItemListPool(10);
			}
		}

		// Token: 0x0601034D RID: 66381 RVA: 0x0043C524 File Offset: 0x0043A724
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
			if (this.m_heroCommentUIController != null)
			{
				this.m_heroCommentUIController.EventOnReturn -= this.HeroCommentUIController_OnReturn;
				this.m_heroCommentUIController.EventOnNameClick -= this.HeroCommentUIController_OnCommenterHeroView;
				this.m_heroCommentUIController.EventOnCommentSend -= this.HeroCommentUIController_OnCommentSend;
				this.m_heroCommentUIController.EventOnPraisedBtnClick -= this.HeroCommentUIController_OnCommentPraised;
				this.m_heroCommentUIController.EventOnGetHeroComments -= this.HeroCommentUIController_OnCommentGet;
				this.m_heroCommentUIController.EventOnRankingQurey -= this.HeroCommentUIController_OnRankingQuery;
				this.m_heroCommentUIController.EventOnRankingListLockClick -= this.HeroCommentUIController_OnRankingListLockClick;
				this.m_heroCommentUIController = null;
			}
		}

		// Token: 0x0601034E RID: 66382 RVA: 0x0043C644 File Offset: 0x0043A844
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

		// Token: 0x0601034F RID: 66383 RVA: 0x0043C6D0 File Offset: 0x0043A8D0
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

		// Token: 0x06010350 RID: 66384 RVA: 0x0043C75C File Offset: 0x0043A95C
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
				Hero classParam = uiintentCustom.GetClassParam<Hero>("hero");
				if (this.m_hero != classParam)
				{
					this.m_hero = classParam;
					this.m_isNeedResetScrollViewPos = true;
				}
				this.HeroCommentUIController_OnCommentGet(this.m_hero.HeroId, this.m_isNeedResetScrollViewPos);
			}
		}

		// Token: 0x06010351 RID: 66385 RVA: 0x0043C818 File Offset: 0x0043AA18
		protected override bool IsNeedUpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedUpdateDataCache_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedUpdateDataCache_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_currMode == HeroCommentUITask.UIModel_RankingList || base.IsNeedUpdateDataCache();
		}

		// Token: 0x06010352 RID: 66386 RVA: 0x0043C8A4 File Offset: 0x0043AAA4
		protected override void UpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDataCache_hotfix != null)
			{
				this.m_UpdateDataCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_currMode == HeroCommentUITask.UIModel_RankingList)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				this.m_currRankList = projectLPlayerContext.GetSingleHeroRankingListInfoByHeroId(this.m_hero.HeroId);
				if (this.m_currRankList == null)
				{
					Debug.LogError("HeroCommentUITask UpdateDataCache error, m_currRankList == null");
					return;
				}
			}
		}

		// Token: 0x06010353 RID: 66387 RVA: 0x0043C958 File Offset: 0x0043AB58
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
			return this.m_currMode == HeroCommentUITask.UIModel_RankingList || this.m_playerHero != null || base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06010354 RID: 66388 RVA: 0x0043C9EC File Offset: 0x0043ABEC
		protected override List<string> CollectAllDynamicResForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAllDynamicResForLoad_hotfix != null)
			{
				return (List<string>)this.m_CollectAllDynamicResForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			if (this.m_currMode == HeroCommentUITask.UIModel_RankingList)
			{
				foreach (RankingTargetPlayerInfo rankingTargetPlayerInfo in this.m_currRankList.PlayerList)
				{
					string playerHeadIconImageName = UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(rankingTargetPlayerInfo.PlayerInfo.HeadIcon));
					if (!string.IsNullOrEmpty(playerHeadIconImageName))
					{
						base.CollectSpriteAsset(playerHeadIconImageName);
					}
				}
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				string playerHeadIconImageName2 = UIUtility.GetPlayerHeadIconImageName(projectLPlayerContext.GetPlayerHeadPortrait());
				if (!string.IsNullOrEmpty(playerHeadIconImageName2))
				{
					base.CollectSpriteAsset(playerHeadIconImageName2);
				}
			}
			if (this.m_playerHero != null)
			{
				base.CollectAsset(this.m_playerHero.SelectedSoldierInfo.Model);
			}
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06010355 RID: 66389 RVA: 0x0043CB40 File Offset: 0x0043AD40
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
				this.m_heroCommentUIController.Open();
			}
			this.m_heroCommentUIController.HeroCommentUpdateView(this.m_hero, this.m_isNeedResetScrollViewPos);
			if (this.m_currMode == HeroCommentUITask.UIModel_RankingList)
			{
				this.m_heroCommentUIController.UpdateRankingList(this.m_currRankList);
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = 0;
			projectLPlayerContext.IsAbleQueryRankingListInfo(RankingListType.SingleHero, out num);
			this.m_heroCommentUIController.UpdateRankingListLock(num == -4101);
			if (this.m_isNeedShowHeroDetailPanel)
			{
				this.m_heroCommentUIController.ShowPlayerHeroDetailPanel(this.m_playerComment, this.m_playerHero);
				this.m_isNeedShowHeroDetailPanel = false;
				this.m_playerComment = null;
				this.m_playerHero = null;
			}
		}

		// Token: 0x06010356 RID: 66390 RVA: 0x0043CC5C File Offset: 0x0043AE5C
		private void HeroCommentUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCommentUIController_OnReturn_hotfix != null)
			{
				this.m_HeroCommentUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x06010357 RID: 66391 RVA: 0x0043CCE0 File Offset: 0x0043AEE0
		private void HeroCommentUIController_OnCommentGet(int heroId, bool isNeedReset)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCommentUIController_OnCommentGetInt32Boolean_hotfix != null)
			{
				this.m_HeroCommentUIController_OnCommentGetInt32Boolean_hotfix.call(new object[]
				{
					this,
					heroId,
					isNeedReset
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isNeedResetScrollViewPos = isNeedReset;
			HeroCommentGetNetTask heroCommentGetNetTask = new HeroCommentGetNetTask(heroId);
			heroCommentGetNetTask.EventOnStop += delegate(Task task)
			{
				HeroCommentGetNetTask heroCommentGetNetTask2 = task as HeroCommentGetNetTask;
				if (heroCommentGetNetTask2.Result == 0 || heroCommentGetNetTask2.Result == -2405)
				{
					this.m_currMode = HeroCommentUITask.UIMode_HeroComment;
					if (this.m_heroCommentUIController != null)
					{
						this.m_heroCommentUIController.HeroCommentUpdateView(this.m_hero, this.m_isNeedResetScrollViewPos);
					}
					if (heroCommentGetNetTask2.Result == -2405)
					{
						CommonUIController.Instance.ShowErrorMessage(heroCommentGetNetTask2.Result, 2f, null, true);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroCommentGetNetTask2.Result, 2f, null, true);
				}
			};
			heroCommentGetNetTask.Start(null);
		}

		// Token: 0x06010358 RID: 66392 RVA: 0x0043CD88 File Offset: 0x0043AF88
		private void HeroCommentUIController_OnRankingQuery(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCommentUIController_OnRankingQueryInt32_hotfix != null)
			{
				this.m_HeroCommentUIController_OnRankingQueryInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			RankingListType type = RankingListType.SingleHero;
			if (!projectLPlayerContext.IsSingleHeroRankingListInfoValid(heroId))
			{
				int errorCode = 0;
				if (!projectLPlayerContext.IsAbleQueryRankingListInfo(RankingListType.SingleHero, out errorCode))
				{
					CommonUIController.Instance.ShowErrorMessage(errorCode, 2f, null, true);
					return;
				}
				RankingNetTask rankingNetTask = new RankingNetTask(type, heroId);
				rankingNetTask.EventOnStop += delegate(Task task)
				{
					RankingNetTask rankingNetTask2 = task as RankingNetTask;
					if (rankingNetTask2.Result == 0)
					{
						this.m_currIntent.TargetMode = HeroCommentUITask.UIModel_RankingList;
						base.StartUpdatePipeLine(this.m_currIntent, false, false, true);
						return;
					}
					CommonUIController.Instance.ShowErrorMessage(rankingNetTask2.Result, 2f, null, true);
				};
				rankingNetTask.Start(null);
			}
			else
			{
				this.m_currIntent.TargetMode = HeroCommentUITask.UIModel_RankingList;
				base.StartUpdatePipeLine(this.m_currIntent, false, false, true);
			}
		}

		// Token: 0x06010359 RID: 66393 RVA: 0x0043CE88 File Offset: 0x0043B088
		private void HeroCommentUIController_OnRankingListLockClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCommentUIController_OnRankingListLockClick_hotfix != null)
			{
				this.m_HeroCommentUIController_OnRankingListLockClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowErrorMessage(-4101, 2f, null, true);
		}

		// Token: 0x0601035A RID: 66394 RVA: 0x0043CF00 File Offset: 0x0043B100
		private void HeroCommentUIController_OnCommentSend(int heroId, string commentStr)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCommentUIController_OnCommentSendInt32String_hotfix != null)
			{
				this.m_HeroCommentUIController_OnCommentSendInt32String_hotfix.call(new object[]
				{
					this,
					heroId,
					commentStr
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroCommentSendNetTask heroCommentSendNetTask = new HeroCommentSendNetTask(heroId, commentStr);
			heroCommentSendNetTask.EventOnStop += delegate(Task task)
			{
				HeroCommentSendNetTask heroCommentSendNetTask2 = task as HeroCommentSendNetTask;
				if (heroCommentSendNetTask2.Result == 0)
				{
					this.UpdateView();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroCommentSendNetTask2.Result, 2f, null, true);
				}
			};
			heroCommentSendNetTask.Start(null);
		}

		// Token: 0x0601035B RID: 66395 RVA: 0x0043CFA4 File Offset: 0x0043B1A4
		private void HeroCommentUIController_OnCommentPraised(int heroId, ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCommentUIController_OnCommentPraisedInt32UInt64_hotfix != null)
			{
				this.m_HeroCommentUIController_OnCommentPraisedInt32UInt64_hotfix.call(new object[]
				{
					this,
					heroId,
					instanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroCommentPraisedNetTask heroCommentPraisedNetTask = new HeroCommentPraisedNetTask(heroId, instanceId);
			heroCommentPraisedNetTask.EventOnStop += delegate(Task task)
			{
				HeroCommentPraisedNetTask heroCommentPraisedNetTask2 = task as HeroCommentPraisedNetTask;
				if (heroCommentPraisedNetTask2.Result == 0)
				{
					this.m_isNeedResetScrollViewPos = false;
					this.UpdateView();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroCommentPraisedNetTask2.Result, 2f, null, true);
				}
			};
			heroCommentPraisedNetTask.Start(null);
		}

		// Token: 0x0601035C RID: 66396 RVA: 0x0043D048 File Offset: 0x0043B248
		private void HeroCommentUIController_OnCommenterHeroView(int heroId, HeroCommentEntry comment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCommentUIController_OnCommenterHeroViewInt32HeroCommentEntry_hotfix != null)
			{
				this.m_HeroCommentUIController_OnCommenterHeroViewInt32HeroCommentEntry_hotfix.call(new object[]
				{
					this,
					heroId,
					comment2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroCommentEntry comment = comment2;
			HeroCommentUITask $this = this;
			ViewCommenterHeroNetTask viewCommenterHeroNetTask = new ViewCommenterHeroNetTask(heroId, comment.CommenterUserId);
			viewCommenterHeroNetTask.EventOnStop += delegate(Task task)
			{
				ViewCommenterHeroNetTask viewCommenterHeroNetTask2 = task as ViewCommenterHeroNetTask;
				if (viewCommenterHeroNetTask2.Result == 0)
				{
					$this.m_isNeedShowHeroDetailPanel = true;
					$this.m_playerHero = viewCommenterHeroNetTask2.PlayerHero;
					$this.m_playerComment = comment;
					$this.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(viewCommenterHeroNetTask2.Result, 2f, null, true);
				}
			};
			viewCommenterHeroNetTask.Start(null);
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0601035D RID: 66397 RVA: 0x0043D108 File Offset: 0x0043B308
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

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0601035E RID: 66398 RVA: 0x0043D17C File Offset: 0x0043B37C
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

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0601035F RID: 66399 RVA: 0x0043D1F0 File Offset: 0x0043B3F0
		// (set) Token: 0x06010360 RID: 66400 RVA: 0x0043D210 File Offset: 0x0043B410
		[DoNotToLua]
		public new HeroCommentUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroCommentUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010361 RID: 66401 RVA: 0x0043D21C File Offset: 0x0043B41C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06010362 RID: 66402 RVA: 0x0043D228 File Offset: 0x0043B428
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06010363 RID: 66403 RVA: 0x0043D230 File Offset: 0x0043B430
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06010364 RID: 66404 RVA: 0x0043D238 File Offset: 0x0043B438
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06010365 RID: 66405 RVA: 0x0043D244 File Offset: 0x0043B444
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06010366 RID: 66406 RVA: 0x0043D250 File Offset: 0x0043B450
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06010367 RID: 66407 RVA: 0x0043D25C File Offset: 0x0043B45C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06010368 RID: 66408 RVA: 0x0043D264 File Offset: 0x0043B464
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06010369 RID: 66409 RVA: 0x0043D26C File Offset: 0x0043B46C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0601036A RID: 66410 RVA: 0x0043D274 File Offset: 0x0043B474
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0601036B RID: 66411 RVA: 0x0043D27C File Offset: 0x0043B47C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0601036C RID: 66412 RVA: 0x0043D284 File Offset: 0x0043B484
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0601036D RID: 66413 RVA: 0x0043D28C File Offset: 0x0043B48C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0601036E RID: 66414 RVA: 0x0043D294 File Offset: 0x0043B494
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0601036F RID: 66415 RVA: 0x0043D2A0 File Offset: 0x0043B4A0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06010370 RID: 66416 RVA: 0x0043D2AC File Offset: 0x0043B4AC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06010371 RID: 66417 RVA: 0x0043D2B8 File Offset: 0x0043B4B8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06010372 RID: 66418 RVA: 0x0043D2C4 File Offset: 0x0043B4C4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06010373 RID: 66419 RVA: 0x0043D2CC File Offset: 0x0043B4CC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06010374 RID: 66420 RVA: 0x0043D2D4 File Offset: 0x0043B4D4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06010375 RID: 66421 RVA: 0x0043D2DC File Offset: 0x0043B4DC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06010376 RID: 66422 RVA: 0x0043D2E4 File Offset: 0x0043B4E4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06010377 RID: 66423 RVA: 0x0043D2EC File Offset: 0x0043B4EC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0601037E RID: 66430 RVA: 0x0043D4B4 File Offset: 0x0043B6B4
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_IsNeedUpdateDataCache_hotfix = (luaObj.RawGet("IsNeedUpdateDataCache") as LuaFunction);
					this.m_UpdateDataCache_hotfix = (luaObj.RawGet("UpdateDataCache") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_CollectAllDynamicResForLoad_hotfix = (luaObj.RawGet("CollectAllDynamicResForLoad") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_HeroCommentUIController_OnReturn_hotfix = (luaObj.RawGet("HeroCommentUIController_OnReturn") as LuaFunction);
					this.m_HeroCommentUIController_OnCommentGetInt32Boolean_hotfix = (luaObj.RawGet("HeroCommentUIController_OnCommentGet") as LuaFunction);
					this.m_HeroCommentUIController_OnRankingQueryInt32_hotfix = (luaObj.RawGet("HeroCommentUIController_OnRankingQuery") as LuaFunction);
					this.m_HeroCommentUIController_OnRankingListLockClick_hotfix = (luaObj.RawGet("HeroCommentUIController_OnRankingListLockClick") as LuaFunction);
					this.m_HeroCommentUIController_OnCommentSendInt32String_hotfix = (luaObj.RawGet("HeroCommentUIController_OnCommentSend") as LuaFunction);
					this.m_HeroCommentUIController_OnCommentPraisedInt32UInt64_hotfix = (luaObj.RawGet("HeroCommentUIController_OnCommentPraised") as LuaFunction);
					this.m_HeroCommentUIController_OnCommenterHeroViewInt32HeroCommentEntry_hotfix = (luaObj.RawGet("HeroCommentUIController_OnCommenterHeroView") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601037F RID: 66431 RVA: 0x0043D75C File Offset: 0x0043B95C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCommentUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040096FA RID: 38650
		protected RankingListInfo m_currRankList;

		// Token: 0x040096FB RID: 38651
		public static string UIMode_HeroComment = "HeroComment";

		// Token: 0x040096FC RID: 38652
		public static string UIModel_RankingList = "RankingList";

		// Token: 0x040096FD RID: 38653
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroCommentUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroCommentUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040096FE RID: 38654
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroCommentUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroCommentUIController"),
				m_ctrlName = "HeroCommentUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroCommentUILayer",
				m_attachPath = "./RankingListGroup",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.RankingListUIController"),
				m_ctrlName = "RankingListUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroCommentUILayer",
				m_attachPath = "./RankingListGroup/PlayerInfoGroup",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.SelfRankingListItemUIController"),
				m_ctrlName = "SelfRankingListItemUIController"
			}
		};

		// Token: 0x040096FF RID: 38655
		private Hero m_hero;

		// Token: 0x04009700 RID: 38656
		private bool m_isNeedResetScrollViewPos;

		// Token: 0x04009701 RID: 38657
		private HeroCommentUIController m_heroCommentUIController;

		// Token: 0x04009702 RID: 38658
		private bool m_isNeedShowHeroDetailPanel;

		// Token: 0x04009703 RID: 38659
		private Hero m_playerHero;

		// Token: 0x04009704 RID: 38660
		private HeroCommentEntry m_playerComment;

		// Token: 0x04009705 RID: 38661
		[DoNotToLua]
		private HeroCommentUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009706 RID: 38662
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009707 RID: 38663
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009708 RID: 38664
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04009709 RID: 38665
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400970A RID: 38666
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400970B RID: 38667
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400970C RID: 38668
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400970D RID: 38669
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400970E RID: 38670
		private LuaFunction m_IsNeedUpdateDataCache_hotfix;

		// Token: 0x0400970F RID: 38671
		private LuaFunction m_UpdateDataCache_hotfix;

		// Token: 0x04009710 RID: 38672
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04009711 RID: 38673
		private LuaFunction m_CollectAllDynamicResForLoad_hotfix;

		// Token: 0x04009712 RID: 38674
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009713 RID: 38675
		private LuaFunction m_HeroCommentUIController_OnReturn_hotfix;

		// Token: 0x04009714 RID: 38676
		private LuaFunction m_HeroCommentUIController_OnCommentGetInt32Boolean_hotfix;

		// Token: 0x04009715 RID: 38677
		private LuaFunction m_HeroCommentUIController_OnRankingQueryInt32_hotfix;

		// Token: 0x04009716 RID: 38678
		private LuaFunction m_HeroCommentUIController_OnRankingListLockClick_hotfix;

		// Token: 0x04009717 RID: 38679
		private LuaFunction m_HeroCommentUIController_OnCommentSendInt32String_hotfix;

		// Token: 0x04009718 RID: 38680
		private LuaFunction m_HeroCommentUIController_OnCommentPraisedInt32UInt64_hotfix;

		// Token: 0x04009719 RID: 38681
		private LuaFunction m_HeroCommentUIController_OnCommenterHeroViewInt32HeroCommentEntry_hotfix;

		// Token: 0x0400971A RID: 38682
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400971B RID: 38683
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000D8F RID: 3471
		public new class LuaExportHelper
		{
			// Token: 0x06010380 RID: 66432 RVA: 0x0043D7C4 File Offset: 0x0043B9C4
			public LuaExportHelper(HeroCommentUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010381 RID: 66433 RVA: 0x0043D7D4 File Offset: 0x0043B9D4
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06010382 RID: 66434 RVA: 0x0043D7E4 File Offset: 0x0043B9E4
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06010383 RID: 66435 RVA: 0x0043D7F4 File Offset: 0x0043B9F4
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06010384 RID: 66436 RVA: 0x0043D804 File Offset: 0x0043BA04
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06010385 RID: 66437 RVA: 0x0043D814 File Offset: 0x0043BA14
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06010386 RID: 66438 RVA: 0x0043D824 File Offset: 0x0043BA24
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06010387 RID: 66439 RVA: 0x0043D834 File Offset: 0x0043BA34
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06010388 RID: 66440 RVA: 0x0043D844 File Offset: 0x0043BA44
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06010389 RID: 66441 RVA: 0x0043D854 File Offset: 0x0043BA54
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0601038A RID: 66442 RVA: 0x0043D864 File Offset: 0x0043BA64
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0601038B RID: 66443 RVA: 0x0043D874 File Offset: 0x0043BA74
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0601038C RID: 66444 RVA: 0x0043D884 File Offset: 0x0043BA84
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0601038D RID: 66445 RVA: 0x0043D894 File Offset: 0x0043BA94
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0601038E RID: 66446 RVA: 0x0043D8A4 File Offset: 0x0043BAA4
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601038F RID: 66447 RVA: 0x0043D8B4 File Offset: 0x0043BAB4
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06010390 RID: 66448 RVA: 0x0043D8C4 File Offset: 0x0043BAC4
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06010391 RID: 66449 RVA: 0x0043D8D4 File Offset: 0x0043BAD4
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06010392 RID: 66450 RVA: 0x0043D8E4 File Offset: 0x0043BAE4
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06010393 RID: 66451 RVA: 0x0043D8F4 File Offset: 0x0043BAF4
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06010394 RID: 66452 RVA: 0x0043D904 File Offset: 0x0043BB04
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06010395 RID: 66453 RVA: 0x0043D914 File Offset: 0x0043BB14
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06010396 RID: 66454 RVA: 0x0043D924 File Offset: 0x0043BB24
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06010397 RID: 66455 RVA: 0x0043D934 File Offset: 0x0043BB34
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x170031E9 RID: 12777
			// (get) Token: 0x06010398 RID: 66456 RVA: 0x0043D944 File Offset: 0x0043BB44
			// (set) Token: 0x06010399 RID: 66457 RVA: 0x0043D954 File Offset: 0x0043BB54
			public RankingListInfo m_currRankList
			{
				get
				{
					return this.m_owner.m_currRankList;
				}
				set
				{
					this.m_owner.m_currRankList = value;
				}
			}

			// Token: 0x170031EA RID: 12778
			// (get) Token: 0x0601039A RID: 66458 RVA: 0x0043D964 File Offset: 0x0043BB64
			// (set) Token: 0x0601039B RID: 66459 RVA: 0x0043D974 File Offset: 0x0043BB74
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

			// Token: 0x170031EB RID: 12779
			// (get) Token: 0x0601039C RID: 66460 RVA: 0x0043D984 File Offset: 0x0043BB84
			// (set) Token: 0x0601039D RID: 66461 RVA: 0x0043D994 File Offset: 0x0043BB94
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

			// Token: 0x170031EC RID: 12780
			// (get) Token: 0x0601039E RID: 66462 RVA: 0x0043D9A4 File Offset: 0x0043BBA4
			// (set) Token: 0x0601039F RID: 66463 RVA: 0x0043D9B4 File Offset: 0x0043BBB4
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

			// Token: 0x170031ED RID: 12781
			// (get) Token: 0x060103A0 RID: 66464 RVA: 0x0043D9C4 File Offset: 0x0043BBC4
			// (set) Token: 0x060103A1 RID: 66465 RVA: 0x0043D9D4 File Offset: 0x0043BBD4
			public bool m_isNeedResetScrollViewPos
			{
				get
				{
					return this.m_owner.m_isNeedResetScrollViewPos;
				}
				set
				{
					this.m_owner.m_isNeedResetScrollViewPos = value;
				}
			}

			// Token: 0x170031EE RID: 12782
			// (get) Token: 0x060103A2 RID: 66466 RVA: 0x0043D9E4 File Offset: 0x0043BBE4
			// (set) Token: 0x060103A3 RID: 66467 RVA: 0x0043D9F4 File Offset: 0x0043BBF4
			public HeroCommentUIController m_heroCommentUIController
			{
				get
				{
					return this.m_owner.m_heroCommentUIController;
				}
				set
				{
					this.m_owner.m_heroCommentUIController = value;
				}
			}

			// Token: 0x170031EF RID: 12783
			// (get) Token: 0x060103A4 RID: 66468 RVA: 0x0043DA04 File Offset: 0x0043BC04
			// (set) Token: 0x060103A5 RID: 66469 RVA: 0x0043DA14 File Offset: 0x0043BC14
			public bool m_isNeedShowHeroDetailPanel
			{
				get
				{
					return this.m_owner.m_isNeedShowHeroDetailPanel;
				}
				set
				{
					this.m_owner.m_isNeedShowHeroDetailPanel = value;
				}
			}

			// Token: 0x170031F0 RID: 12784
			// (get) Token: 0x060103A6 RID: 66470 RVA: 0x0043DA24 File Offset: 0x0043BC24
			// (set) Token: 0x060103A7 RID: 66471 RVA: 0x0043DA34 File Offset: 0x0043BC34
			public Hero m_playerHero
			{
				get
				{
					return this.m_owner.m_playerHero;
				}
				set
				{
					this.m_owner.m_playerHero = value;
				}
			}

			// Token: 0x170031F1 RID: 12785
			// (get) Token: 0x060103A8 RID: 66472 RVA: 0x0043DA44 File Offset: 0x0043BC44
			// (set) Token: 0x060103A9 RID: 66473 RVA: 0x0043DA54 File Offset: 0x0043BC54
			public HeroCommentEntry m_playerComment
			{
				get
				{
					return this.m_owner.m_playerComment;
				}
				set
				{
					this.m_owner.m_playerComment = value;
				}
			}

			// Token: 0x170031F2 RID: 12786
			// (get) Token: 0x060103AA RID: 66474 RVA: 0x0043DA64 File Offset: 0x0043BC64
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170031F3 RID: 12787
			// (get) Token: 0x060103AB RID: 66475 RVA: 0x0043DA74 File Offset: 0x0043BC74
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060103AC RID: 66476 RVA: 0x0043DA84 File Offset: 0x0043BC84
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060103AD RID: 66477 RVA: 0x0043DA94 File Offset: 0x0043BC94
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060103AE RID: 66478 RVA: 0x0043DAA4 File Offset: 0x0043BCA4
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x060103AF RID: 66479 RVA: 0x0043DAB4 File Offset: 0x0043BCB4
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x060103B0 RID: 66480 RVA: 0x0043DAC4 File Offset: 0x0043BCC4
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x060103B1 RID: 66481 RVA: 0x0043DAD4 File Offset: 0x0043BCD4
			public bool IsNeedUpdateDataCache()
			{
				return this.m_owner.IsNeedUpdateDataCache();
			}

			// Token: 0x060103B2 RID: 66482 RVA: 0x0043DAE4 File Offset: 0x0043BCE4
			public void UpdateDataCache()
			{
				this.m_owner.UpdateDataCache();
			}

			// Token: 0x060103B3 RID: 66483 RVA: 0x0043DAF4 File Offset: 0x0043BCF4
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x060103B4 RID: 66484 RVA: 0x0043DB04 File Offset: 0x0043BD04
			public List<string> CollectAllDynamicResForLoad()
			{
				return this.m_owner.CollectAllDynamicResForLoad();
			}

			// Token: 0x060103B5 RID: 66485 RVA: 0x0043DB14 File Offset: 0x0043BD14
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060103B6 RID: 66486 RVA: 0x0043DB24 File Offset: 0x0043BD24
			public void HeroCommentUIController_OnReturn()
			{
				this.m_owner.HeroCommentUIController_OnReturn();
			}

			// Token: 0x060103B7 RID: 66487 RVA: 0x0043DB34 File Offset: 0x0043BD34
			public void HeroCommentUIController_OnCommentGet(int heroId, bool isNeedReset)
			{
				this.m_owner.HeroCommentUIController_OnCommentGet(heroId, isNeedReset);
			}

			// Token: 0x060103B8 RID: 66488 RVA: 0x0043DB44 File Offset: 0x0043BD44
			public void HeroCommentUIController_OnRankingQuery(int heroId)
			{
				this.m_owner.HeroCommentUIController_OnRankingQuery(heroId);
			}

			// Token: 0x060103B9 RID: 66489 RVA: 0x0043DB54 File Offset: 0x0043BD54
			public void HeroCommentUIController_OnRankingListLockClick()
			{
				this.m_owner.HeroCommentUIController_OnRankingListLockClick();
			}

			// Token: 0x060103BA RID: 66490 RVA: 0x0043DB64 File Offset: 0x0043BD64
			public void HeroCommentUIController_OnCommentSend(int heroId, string commentStr)
			{
				this.m_owner.HeroCommentUIController_OnCommentSend(heroId, commentStr);
			}

			// Token: 0x060103BB RID: 66491 RVA: 0x0043DB74 File Offset: 0x0043BD74
			public void HeroCommentUIController_OnCommentPraised(int heroId, ulong instanceId)
			{
				this.m_owner.HeroCommentUIController_OnCommentPraised(heroId, instanceId);
			}

			// Token: 0x060103BC RID: 66492 RVA: 0x0043DB84 File Offset: 0x0043BD84
			public void HeroCommentUIController_OnCommenterHeroView(int heroId, HeroCommentEntry comment)
			{
				this.m_owner.HeroCommentUIController_OnCommenterHeroView(heroId, comment);
			}

			// Token: 0x0400971C RID: 38684
			private HeroCommentUITask m_owner;
		}
	}
}
