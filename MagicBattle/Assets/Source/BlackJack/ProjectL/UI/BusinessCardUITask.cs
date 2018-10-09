using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B34 RID: 2868
	[HotFix]
	public class BusinessCardUITask : UITask
	{
		// Token: 0x0600C290 RID: 49808 RVA: 0x0035FCE8 File Offset: 0x0035DEE8
		public BusinessCardUITask(string name) : base(name)
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

		// Token: 0x0600C291 RID: 49809 RVA: 0x0035FE40 File Offset: 0x0035E040
		public static void StartUITask(UIIntent uiIntent)
		{
			UIIntentReturnable intent = new UIIntentReturnable(uiIntent, typeof(BusinessCardUITask).Name, null);
			UIManager.Instance.StartUITask(intent, false, false, null);
		}

		// Token: 0x0600C292 RID: 49810 RVA: 0x0035FE74 File Offset: 0x0035E074
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
			this.CollectHeroModelAssets(this.m_playerContext.BusinessCard.Heroes);
			this.CollectHeroModelAssets(this.m_playerContext.BusinessCard.MostSkilledHeroes);
			base.CollectSpriteAsset(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(this.m_playerContext.BusinessCard.HeadIcon)));
			if (this.m_playerContext.IsMe(this.m_playerContext.BusinessCard.UserId))
			{
				foreach (Hero hero in this.m_playerContext.GetHeros())
				{
					ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
					if (charImageInfo != null)
					{
						base.CollectAsset(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_1"));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600C293 RID: 49811 RVA: 0x0035FFD4 File Offset: 0x0035E1D4
		private void CollectHeroModelAssets(List<BattleHero> heros)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectHeroModelAssetsList`1_hotfix != null)
			{
				this.m_CollectHeroModelAssetsList`1_hotfix.call(new object[]
				{
					this,
					heros
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heros == null)
			{
				return;
			}
			foreach (BattleHero hero in heros)
			{
				base.CollectAsset(UIUtility.GetHeroModelAssetPath(hero));
			}
		}

		// Token: 0x0600C294 RID: 49812 RVA: 0x0036009C File Offset: 0x0035E29C
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
			if (this.m_businessCardUIController == null)
			{
				this.m_businessCardUIController = (this.m_uiCtrlArray[0] as BusinessCardUIController);
				if (this.m_businessCardUIController != null)
				{
					this.m_businessCardUIController.EventOnReturn += this.BusinessCardUIController_OnReturn;
					this.m_businessCardUIController.EventOnLike += this.BusinessCardUIController_OnLike;
					this.m_businessCardUIController.EventOnChangeSign += this.BusinessCardUIController_OnUpdateSign;
					this.m_businessCardUIController.EventOnUpdateHeroSet += this.BusinessCardUIController_OnUpdateHeroSet;
					this.m_businessCardUIController.EventOnArClick += this.BusinessCardUIController_OnArDisplayClick;
				}
				else
				{
					Debug.LogError("BusinessCardUIController is null!");
				}
				this.m_arHeroListUIController = (this.m_uiCtrlArray[1] as ARHeroListUIController);
				this.m_arHeroListUIController.SetUITask(this);
			}
		}

		// Token: 0x0600C295 RID: 49813 RVA: 0x003601D8 File Offset: 0x0035E3D8
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
			if (this.m_businessCardUIController != null)
			{
				this.m_businessCardUIController.EventOnReturn -= this.BusinessCardUIController_OnReturn;
				this.m_businessCardUIController.EventOnLike -= this.BusinessCardUIController_OnLike;
				this.m_businessCardUIController.EventOnChangeSign -= this.BusinessCardUIController_OnUpdateSign;
				this.m_businessCardUIController.EventOnUpdateHeroSet -= this.BusinessCardUIController_OnUpdateHeroSet;
				this.m_businessCardUIController.EventOnArClick -= this.BusinessCardUIController_OnArDisplayClick;
				this.m_businessCardUIController = null;
			}
		}

		// Token: 0x0600C296 RID: 49814 RVA: 0x003602CC File Offset: 0x0035E4CC
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

		// Token: 0x0600C297 RID: 49815 RVA: 0x00360334 File Offset: 0x0035E534
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
				this.m_businessCardUIController.ShowOpenState();
			}
			this.m_businessCardUIController.SetPlayerInfo(this.m_playerContext.BusinessCard, this.m_playerContext.IsMe(this.m_playerContext.BusinessCard.UserId), this.m_playerContext.CanSendLikes(this.m_playerContext.BusinessCard.UserId) == 0, this.m_playerContext.BusinessCard.SetInfo.IsActionRandom);
		}

		// Token: 0x0600C298 RID: 49816 RVA: 0x00360410 File Offset: 0x0035E610
		private void BusinessCardUIController_OnReturn(bool isRandowShowValueChanged)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BusinessCardUIController_OnReturnBoolean_hotfix != null)
			{
				this.m_BusinessCardUIController_OnReturnBoolean_hotfix.call(new object[]
				{
					this,
					isRandowShowValueChanged
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.BusinessCardUIController_OnRandomShowChange(isRandowShowValueChanged);
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Stop();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600C299 RID: 49817 RVA: 0x003604A8 File Offset: 0x0035E6A8
		private void BusinessCardUIController_OnRandomShowChange(bool isRandowShowValueChanged)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BusinessCardUIController_OnRandomShowChangeBoolean_hotfix != null)
			{
				this.m_BusinessCardUIController_OnRandomShowChangeBoolean_hotfix.call(new object[]
				{
					this,
					isRandowShowValueChanged
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isRandowShowValueChanged)
			{
				BusinessCardRandomShowChangeNetTask businessCardRandomShowChangeNetTask = new BusinessCardRandomShowChangeNetTask(!this.m_playerContext.BusinessCard.SetInfo.IsActionRandom);
				businessCardRandomShowChangeNetTask.EventOnStop += delegate(Task task)
				{
					BusinessCardRandomShowChangeNetTask businessCardRandomShowChangeNetTask2 = task as BusinessCardRandomShowChangeNetTask;
					if (businessCardRandomShowChangeNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(businessCardRandomShowChangeNetTask2.Result, 2f, null, true);
					}
				};
				businessCardRandomShowChangeNetTask.Start(null);
			}
		}

		// Token: 0x0600C29A RID: 49818 RVA: 0x00360568 File Offset: 0x0035E768
		private void BusinessCardUIController_OnLike(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BusinessCardUIController_OnLikeString_hotfix != null)
			{
				this.m_BusinessCardUIController_OnLikeString_hotfix.call(new object[]
				{
					this,
					userID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanSendLikes(userID);
			if (num == 0)
			{
				LikeNetTask likeNetTask = new LikeNetTask(userID);
				likeNetTask.EventOnStop += delegate(Task task)
				{
					LikeNetTask likeNetTask2 = task as LikeNetTask;
					if (likeNetTask2.Result == 0)
					{
						this.UpdateView();
						CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_Like_Success), 2f, null, true);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(likeNetTask2.Result, 2f, null, true);
					}
				};
				likeNetTask.Start(null);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600C29B RID: 49819 RVA: 0x00360624 File Offset: 0x0035E824
		private void BusinessCardUIController_OnUpdateSign(string sign)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BusinessCardUIController_OnUpdateSignString_hotfix != null)
			{
				this.m_BusinessCardUIController_OnUpdateSignString_hotfix.call(new object[]
				{
					this,
					sign2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string sign = sign2;
			BusinessCardUITask $this = this;
			BusinessCardDescUpdateNetTask businessCardDescUpdateNetTask = new BusinessCardDescUpdateNetTask(sign);
			businessCardDescUpdateNetTask.EventOnStop += delegate(Task task)
			{
				BusinessCardDescUpdateNetTask businessCardDescUpdateNetTask2 = task as BusinessCardDescUpdateNetTask;
				if (businessCardDescUpdateNetTask2.Result == 0)
				{
					$this.m_businessCardUIController.PlayerSignUpdateSuccess(sign);
				}
				else
				{
					$this.m_businessCardUIController.PlayerSignUpdateEnd();
					CommonUIController.Instance.ShowErrorMessage(businessCardDescUpdateNetTask2.Result, 2f, null, true);
				}
			};
			businessCardDescUpdateNetTask.Start(null);
		}

		// Token: 0x0600C29C RID: 49820 RVA: 0x003606D0 File Offset: 0x0035E8D0
		private void BusinessCardUIController_OnUpdateHeroSet(List<BusinessCardHeroSet> heroSetList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BusinessCardUIController_OnUpdateHeroSetList`1_hotfix != null)
			{
				this.m_BusinessCardUIController_OnUpdateHeroSetList`1_hotfix.call(new object[]
				{
					this,
					heroSetList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BusinessCardHeroSet> list = new List<BusinessCardHeroSet>();
			int i;
			for (i = 0; i < 5; i++)
			{
				BusinessCardHeroSet businessCardHeroSet = heroSetList.Find((BusinessCardHeroSet heroSet) => heroSet.PositionIndex == i);
				if (businessCardHeroSet != null)
				{
					list.Add(businessCardHeroSet);
				}
			}
			BusinessCardHeroSetUpdateNetTask businessCardHeroSetUpdateNetTask = new BusinessCardHeroSetUpdateNetTask(list);
			businessCardHeroSetUpdateNetTask.EventOnStop += delegate(Task task)
			{
				BusinessCardHeroSetUpdateNetTask businessCardHeroSetUpdateNetTask2 = task as BusinessCardHeroSetUpdateNetTask;
				if (businessCardHeroSetUpdateNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
					this.m_businessCardUIController.SetRandomShowToggleOff();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(businessCardHeroSetUpdateNetTask2.Result, 2f, null, true);
				}
			};
			businessCardHeroSetUpdateNetTask.Start(null);
		}

		// Token: 0x0600C29D RID: 49821 RVA: 0x003607B4 File Offset: 0x0035E9B4
		private void BusinessCardUIController_OnArDisplayClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BusinessCardUIController_OnArDisplayClick_hotfix != null)
			{
				this.m_BusinessCardUIController_OnArDisplayClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arHeroListUIController.Show();
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x0600C29E RID: 49822 RVA: 0x00360820 File Offset: 0x0035EA20
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

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x0600C29F RID: 49823 RVA: 0x00360894 File Offset: 0x0035EA94
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

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x0600C2A0 RID: 49824 RVA: 0x00360908 File Offset: 0x0035EB08
		// (set) Token: 0x0600C2A1 RID: 49825 RVA: 0x00360928 File Offset: 0x0035EB28
		[DoNotToLua]
		public new BusinessCardUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BusinessCardUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C2A2 RID: 49826 RVA: 0x00360934 File Offset: 0x0035EB34
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600C2A3 RID: 49827 RVA: 0x00360940 File Offset: 0x0035EB40
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600C2A4 RID: 49828 RVA: 0x00360948 File Offset: 0x0035EB48
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600C2A5 RID: 49829 RVA: 0x00360950 File Offset: 0x0035EB50
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600C2A6 RID: 49830 RVA: 0x0036095C File Offset: 0x0035EB5C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600C2A7 RID: 49831 RVA: 0x00360968 File Offset: 0x0035EB68
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600C2A8 RID: 49832 RVA: 0x00360974 File Offset: 0x0035EB74
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600C2A9 RID: 49833 RVA: 0x0036097C File Offset: 0x0035EB7C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600C2AA RID: 49834 RVA: 0x00360984 File Offset: 0x0035EB84
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600C2AB RID: 49835 RVA: 0x0036098C File Offset: 0x0035EB8C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600C2AC RID: 49836 RVA: 0x00360994 File Offset: 0x0035EB94
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600C2AD RID: 49837 RVA: 0x0036099C File Offset: 0x0035EB9C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600C2AE RID: 49838 RVA: 0x003609A4 File Offset: 0x0035EBA4
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600C2AF RID: 49839 RVA: 0x003609AC File Offset: 0x0035EBAC
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600C2B0 RID: 49840 RVA: 0x003609B8 File Offset: 0x0035EBB8
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600C2B1 RID: 49841 RVA: 0x003609C4 File Offset: 0x0035EBC4
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600C2B2 RID: 49842 RVA: 0x003609D0 File Offset: 0x0035EBD0
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600C2B3 RID: 49843 RVA: 0x003609DC File Offset: 0x0035EBDC
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600C2B4 RID: 49844 RVA: 0x003609E4 File Offset: 0x0035EBE4
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600C2B5 RID: 49845 RVA: 0x003609EC File Offset: 0x0035EBEC
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600C2B6 RID: 49846 RVA: 0x003609F4 File Offset: 0x0035EBF4
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600C2B7 RID: 49847 RVA: 0x003609FC File Offset: 0x0035EBFC
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600C2B8 RID: 49848 RVA: 0x00360A04 File Offset: 0x0035EC04
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x00360B1C File Offset: 0x0035ED1C
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
					this.m_CollectHeroModelAssetsList`1_hotfix = (luaObj.RawGet("CollectHeroModelAssets") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_BusinessCardUIController_OnReturnBoolean_hotfix = (luaObj.RawGet("BusinessCardUIController_OnReturn") as LuaFunction);
					this.m_BusinessCardUIController_OnRandomShowChangeBoolean_hotfix = (luaObj.RawGet("BusinessCardUIController_OnRandomShowChange") as LuaFunction);
					this.m_BusinessCardUIController_OnLikeString_hotfix = (luaObj.RawGet("BusinessCardUIController_OnLike") as LuaFunction);
					this.m_BusinessCardUIController_OnUpdateSignString_hotfix = (luaObj.RawGet("BusinessCardUIController_OnUpdateSign") as LuaFunction);
					this.m_BusinessCardUIController_OnUpdateHeroSetList`1_hotfix = (luaObj.RawGet("BusinessCardUIController_OnUpdateHeroSet") as LuaFunction);
					this.m_BusinessCardUIController_OnArDisplayClick_hotfix = (luaObj.RawGet("BusinessCardUIController_OnArDisplayClick") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C2BE RID: 49854 RVA: 0x00360D48 File Offset: 0x0035EF48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007B9B RID: 31643
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BusinessCardUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Friend_ABS/Prefab/NameCardUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04007B9C RID: 31644
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BusinessCardUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BusinessCardUIController"),
				m_ctrlName = "BusinessCardUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BusinessCardUILayer",
				m_attachPath = "./ARHeroListPanel",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ARHeroListUIController"),
				m_ctrlName = "ARHeroListUIController"
			}
		};

		// Token: 0x04007B9D RID: 31645
		private const int HeroTeamMaxCount = 5;

		// Token: 0x04007B9E RID: 31646
		private BusinessCardUIController m_businessCardUIController;

		// Token: 0x04007B9F RID: 31647
		private ARHeroListUIController m_arHeroListUIController;

		// Token: 0x04007BA0 RID: 31648
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04007BA1 RID: 31649
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04007BA2 RID: 31650
		[DoNotToLua]
		private BusinessCardUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04007BA4 RID: 31652
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007BA5 RID: 31653
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007BA6 RID: 31654
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04007BA7 RID: 31655
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04007BA8 RID: 31656
		private LuaFunction m_CollectHeroModelAssetsList;

		// Token: 0x04007BA9 RID: 31657
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04007BAA RID: 31658
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04007BAB RID: 31659
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04007BAC RID: 31660
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04007BAD RID: 31661
		private LuaFunction m_BusinessCardUIController_OnReturnBoolean_hotfix;

		// Token: 0x04007BAE RID: 31662
		private LuaFunction m_BusinessCardUIController_OnRandomShowChangeBoolean_hotfix;

		// Token: 0x04007BAF RID: 31663
		private LuaFunction m_BusinessCardUIController_OnLikeString_hotfix;

		// Token: 0x04007BB0 RID: 31664
		private LuaFunction m_BusinessCardUIController_OnUpdateSignString_hotfix;

		// Token: 0x04007BB1 RID: 31665
		private LuaFunction m_BusinessCardUIController_OnUpdateHeroSetList;

		// Token: 0x04007BB2 RID: 31666
		private LuaFunction m_BusinessCardUIController_OnArDisplayClick_hotfix;

		// Token: 0x04007BB3 RID: 31667
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04007BB4 RID: 31668
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000B35 RID: 2869
		public new class LuaExportHelper
		{
			// Token: 0x0600C2BF RID: 49855 RVA: 0x00360DB0 File Offset: 0x0035EFB0
			public LuaExportHelper(BusinessCardUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C2C0 RID: 49856 RVA: 0x00360DC0 File Offset: 0x0035EFC0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600C2C1 RID: 49857 RVA: 0x00360DD0 File Offset: 0x0035EFD0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600C2C2 RID: 49858 RVA: 0x00360DE0 File Offset: 0x0035EFE0
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600C2C3 RID: 49859 RVA: 0x00360DF0 File Offset: 0x0035EFF0
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600C2C4 RID: 49860 RVA: 0x00360E00 File Offset: 0x0035F000
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600C2C5 RID: 49861 RVA: 0x00360E10 File Offset: 0x0035F010
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600C2C6 RID: 49862 RVA: 0x00360E20 File Offset: 0x0035F020
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600C2C7 RID: 49863 RVA: 0x00360E30 File Offset: 0x0035F030
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600C2C8 RID: 49864 RVA: 0x00360E40 File Offset: 0x0035F040
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600C2C9 RID: 49865 RVA: 0x00360E50 File Offset: 0x0035F050
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600C2CA RID: 49866 RVA: 0x00360E60 File Offset: 0x0035F060
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600C2CB RID: 49867 RVA: 0x00360E70 File Offset: 0x0035F070
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600C2CC RID: 49868 RVA: 0x00360E80 File Offset: 0x0035F080
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600C2CD RID: 49869 RVA: 0x00360E90 File Offset: 0x0035F090
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600C2CE RID: 49870 RVA: 0x00360EA0 File Offset: 0x0035F0A0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600C2CF RID: 49871 RVA: 0x00360EB0 File Offset: 0x0035F0B0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600C2D0 RID: 49872 RVA: 0x00360EC0 File Offset: 0x0035F0C0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600C2D1 RID: 49873 RVA: 0x00360ED0 File Offset: 0x0035F0D0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600C2D2 RID: 49874 RVA: 0x00360EE0 File Offset: 0x0035F0E0
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600C2D3 RID: 49875 RVA: 0x00360EF0 File Offset: 0x0035F0F0
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600C2D4 RID: 49876 RVA: 0x00360F00 File Offset: 0x0035F100
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600C2D5 RID: 49877 RVA: 0x00360F10 File Offset: 0x0035F110
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600C2D6 RID: 49878 RVA: 0x00360F20 File Offset: 0x0035F120
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x1700271E RID: 10014
			// (get) Token: 0x0600C2D7 RID: 49879 RVA: 0x00360F30 File Offset: 0x0035F130
			// (set) Token: 0x0600C2D8 RID: 49880 RVA: 0x00360F40 File Offset: 0x0035F140
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

			// Token: 0x1700271F RID: 10015
			// (get) Token: 0x0600C2D9 RID: 49881 RVA: 0x00360F50 File Offset: 0x0035F150
			// (set) Token: 0x0600C2DA RID: 49882 RVA: 0x00360F60 File Offset: 0x0035F160
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

			// Token: 0x17002720 RID: 10016
			// (get) Token: 0x0600C2DB RID: 49883 RVA: 0x00360F70 File Offset: 0x0035F170
			public static int HeroTeamMaxCount
			{
				get
				{
					return 5;
				}
			}

			// Token: 0x17002721 RID: 10017
			// (get) Token: 0x0600C2DC RID: 49884 RVA: 0x00360F74 File Offset: 0x0035F174
			// (set) Token: 0x0600C2DD RID: 49885 RVA: 0x00360F84 File Offset: 0x0035F184
			public BusinessCardUIController m_businessCardUIController
			{
				get
				{
					return this.m_owner.m_businessCardUIController;
				}
				set
				{
					this.m_owner.m_businessCardUIController = value;
				}
			}

			// Token: 0x17002722 RID: 10018
			// (get) Token: 0x0600C2DE RID: 49886 RVA: 0x00360F94 File Offset: 0x0035F194
			// (set) Token: 0x0600C2DF RID: 49887 RVA: 0x00360FA4 File Offset: 0x0035F1A4
			public ARHeroListUIController m_arHeroListUIController
			{
				get
				{
					return this.m_owner.m_arHeroListUIController;
				}
				set
				{
					this.m_owner.m_arHeroListUIController = value;
				}
			}

			// Token: 0x17002723 RID: 10019
			// (get) Token: 0x0600C2E0 RID: 49888 RVA: 0x00360FB4 File Offset: 0x0035F1B4
			// (set) Token: 0x0600C2E1 RID: 49889 RVA: 0x00360FC4 File Offset: 0x0035F1C4
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

			// Token: 0x17002724 RID: 10020
			// (get) Token: 0x0600C2E2 RID: 49890 RVA: 0x00360FD4 File Offset: 0x0035F1D4
			// (set) Token: 0x0600C2E3 RID: 49891 RVA: 0x00360FE4 File Offset: 0x0035F1E4
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

			// Token: 0x17002725 RID: 10021
			// (get) Token: 0x0600C2E4 RID: 49892 RVA: 0x00360FF4 File Offset: 0x0035F1F4
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002726 RID: 10022
			// (get) Token: 0x0600C2E5 RID: 49893 RVA: 0x00361004 File Offset: 0x0035F204
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600C2E6 RID: 49894 RVA: 0x00361014 File Offset: 0x0035F214
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600C2E7 RID: 49895 RVA: 0x00361024 File Offset: 0x0035F224
			public void CollectHeroModelAssets(List<BattleHero> heros)
			{
				this.m_owner.CollectHeroModelAssets(heros);
			}

			// Token: 0x0600C2E8 RID: 49896 RVA: 0x00361034 File Offset: 0x0035F234
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600C2E9 RID: 49897 RVA: 0x00361044 File Offset: 0x0035F244
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600C2EA RID: 49898 RVA: 0x00361054 File Offset: 0x0035F254
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x0600C2EB RID: 49899 RVA: 0x00361064 File Offset: 0x0035F264
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600C2EC RID: 49900 RVA: 0x00361074 File Offset: 0x0035F274
			public void BusinessCardUIController_OnReturn(bool isRandowShowValueChanged)
			{
				this.m_owner.BusinessCardUIController_OnReturn(isRandowShowValueChanged);
			}

			// Token: 0x0600C2ED RID: 49901 RVA: 0x00361084 File Offset: 0x0035F284
			public void BusinessCardUIController_OnRandomShowChange(bool isRandowShowValueChanged)
			{
				this.m_owner.BusinessCardUIController_OnRandomShowChange(isRandowShowValueChanged);
			}

			// Token: 0x0600C2EE RID: 49902 RVA: 0x00361094 File Offset: 0x0035F294
			public void BusinessCardUIController_OnLike(string userID)
			{
				this.m_owner.BusinessCardUIController_OnLike(userID);
			}

			// Token: 0x0600C2EF RID: 49903 RVA: 0x003610A4 File Offset: 0x0035F2A4
			public void BusinessCardUIController_OnUpdateSign(string sign)
			{
				this.m_owner.BusinessCardUIController_OnUpdateSign(sign);
			}

			// Token: 0x0600C2F0 RID: 49904 RVA: 0x003610B4 File Offset: 0x0035F2B4
			public void BusinessCardUIController_OnUpdateHeroSet(List<BusinessCardHeroSet> heroSetList)
			{
				this.m_owner.BusinessCardUIController_OnUpdateHeroSet(heroSetList);
			}

			// Token: 0x0600C2F1 RID: 49905 RVA: 0x003610C4 File Offset: 0x0035F2C4
			public void BusinessCardUIController_OnArDisplayClick()
			{
				this.m_owner.BusinessCardUIController_OnArDisplayClick();
			}

			// Token: 0x04007BB5 RID: 31669
			private BusinessCardUITask m_owner;
		}
	}
}
