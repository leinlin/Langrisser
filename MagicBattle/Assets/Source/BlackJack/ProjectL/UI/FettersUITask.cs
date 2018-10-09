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
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C8F RID: 3215
	[HotFix]
	public class FettersUITask : UITask
	{
		// Token: 0x0600E7EB RID: 59371 RVA: 0x003E1490 File Offset: 0x003DF690
		public FettersUITask(string name) : base(name)
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

		// Token: 0x0600E7EC RID: 59372 RVA: 0x003E16DC File Offset: 0x003DF8DC
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.GetUIStateFromIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x0600E7ED RID: 59373 RVA: 0x003E1790 File Offset: 0x003DF990
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.GetUIStateFromIntent(intent);
			return base.OnResume(intent);
		}

		// Token: 0x0600E7EE RID: 59374 RVA: 0x003E1844 File Offset: 0x003DFA44
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
			this.SaveUIStateToIntent();
			base.OnStop();
		}

		// Token: 0x0600E7EF RID: 59375 RVA: 0x003E18B0 File Offset: 0x003DFAB0
		private void SaveUIStateToIntent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SaveUIStateToIntent_hotfix != null)
			{
				this.m_SaveUIStateToIntent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
			if (uiintentReturnable == null)
			{
				return;
			}
			uiintentReturnable.SetParam("CurMode", this.m_curMode);
			uiintentReturnable.SetParam("LastMode", this.m_lastMode);
			if (this.m_hero != null)
			{
				uiintentReturnable.SetParam("LastHeroId", this.m_hero.HeroId);
			}
			else
			{
				uiintentReturnable.SetParam("LastHeroId", 0);
			}
		}

		// Token: 0x0600E7F0 RID: 59376 RVA: 0x003E1984 File Offset: 0x003DFB84
		private void GetUIStateFromIntent(UIIntent uiIntent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUIStateFromIntentUIIntent_hotfix != null)
			{
				this.m_GetUIStateFromIntentUIIntent_hotfix.call(new object[]
				{
					this,
					uiIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable uiintentReturnable = uiIntent as UIIntentReturnable;
			if (uiintentReturnable == null)
			{
				return;
			}
			this.m_lastHeroId = uiintentReturnable.GetStructParam<int>("LastHeroId");
			object obj;
			uiintentReturnable.TryGetParam("CurMode", out obj);
			object obj2;
			uiintentReturnable.TryGetParam("LastMode", out obj2);
			this.m_curMode = (string)obj;
			if (this.m_curMode == null)
			{
				this.m_curMode = "Matthew";
			}
			this.m_lastMode = (string)obj2;
		}

		// Token: 0x0600E7F1 RID: 59377 RVA: 0x003E1A60 File Offset: 0x003DFC60
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
			if (this.m_curMode == "Matthew")
			{
				this.m_hero = this.m_playerContext.GetHero(this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_ProtagonistHeroID));
			}
			else if (this.m_lastHeroId > 0)
			{
				this.m_hero = this.m_playerContext.GetHero(this.m_lastHeroId);
				this.m_lastHeroId = 0;
			}
			if (this.m_hero != null)
			{
				string heroCharAssetPath = UIUtility.GetHeroCharAssetPath(this.m_hero);
				if (!string.IsNullOrEmpty(heroCharAssetPath))
				{
					base.CollectAsset(heroCharAssetPath);
				}
				else
				{
					ConfigDataCharImageInfo charImageInfo = this.m_hero.HeroInfo.GetCharImageInfo(this.m_hero.StarLevel);
					if (charImageInfo != null)
					{
						base.CollectSpriteAsset(charImageInfo.Image);
					}
				}
				ConfigDataJobConnectionInfo jobConnectionInfo = this.m_hero.GetActiveJob().JobConnectionInfo;
				if (jobConnectionInfo != null)
				{
					base.CollectAsset(jobConnectionInfo.Model);
				}
			}
			foreach (Hero hero in this.m_playerContext.GetHeros())
			{
				base.CollectAsset(AssetUtility.MakeSpriteAssetName(hero.HeroInfo.GetCharImageInfo(hero.StarLevel).CardHeadImage, "_1"));
			}
			if (this.m_curMode == "Confession")
			{
				List<ConfigDataHeroFetterInfo> fetterInfos = this.m_hero.HeroInfo.m_informationInfo.m_fetterInfos;
				foreach (ConfigDataHeroFetterInfo configDataHeroFetterInfo in fetterInfos)
				{
					base.CollectSpriteAsset(configDataHeroFetterInfo.Icon);
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600E7F2 RID: 59378 RVA: 0x003E1CA8 File Offset: 0x003DFEA8
		protected override void InitLayerStateOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLayerStateOnLoadAllResCompleted_hotfix != null)
			{
				this.m_InitLayerStateOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600E7F3 RID: 59379 RVA: 0x003E1D08 File Offset: 0x003DFF08
		protected override bool IsNeedLoadStaticRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadStaticRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadStaticRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curMode == "Matthew")
			{
				return base.IsNeedLoadStaticRes();
			}
			return ((this.m_curMode == "Favorability" || this.m_curMode == "Gift") && this.m_fettersFavorabilityUIController == null) || (this.m_curMode == "Information" && this.m_fettersInformationUIController == null) || (this.m_curMode == "Confession" && this.m_fettersConfessionUIController == null) || base.IsNeedLoadStaticRes();
		}

		// Token: 0x0600E7F4 RID: 59380 RVA: 0x003E1E24 File Offset: 0x003E0024
		protected override List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAllStaticResDescForLoad_hotfix != null)
			{
				return (List<UITaskBase.LayerDesc>)this.m_CollectAllStaticResDescForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<UITaskBase.LayerDesc> list = new List<UITaskBase.LayerDesc>();
			if (this.m_curMode == "Matthew")
			{
				return base.CollectAllStaticResDescForLoad();
			}
			if (this.m_curMode == "Favorability" || this.m_curMode == "Gift")
			{
				list.Add(new UITaskBase.LayerDesc
				{
					m_layerName = this.LayerDescArray[1].m_layerName,
					m_layerResPath = this.LayerDescArray[1].m_layerResPath,
					m_isUILayer = this.LayerDescArray[1].m_isUILayer,
					m_index = this.LayerDescArray[1].m_index
				});
				return list;
			}
			if (this.m_curMode == "Information")
			{
				list.Add(new UITaskBase.LayerDesc
				{
					m_layerName = this.LayerDescArray[2].m_layerName,
					m_layerResPath = this.LayerDescArray[2].m_layerResPath,
					m_isUILayer = this.LayerDescArray[2].m_isUILayer,
					m_index = this.LayerDescArray[2].m_index
				});
				return list;
			}
			if (this.m_curMode == "Confession")
			{
				list.Add(new UITaskBase.LayerDesc
				{
					m_layerName = this.LayerDescArray[3].m_layerName,
					m_layerResPath = this.LayerDescArray[3].m_layerResPath,
					m_isUILayer = this.LayerDescArray[3].m_isUILayer,
					m_index = this.LayerDescArray[3].m_index
				});
				return list;
			}
			return base.CollectAllStaticResDescForLoad();
		}

		// Token: 0x0600E7F5 RID: 59381 RVA: 0x003E2020 File Offset: 0x003E0220
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
			if (this.m_curMode == "Matthew")
			{
				if (this.m_fettersUIController == null)
				{
					this.m_fettersUIController = (this.m_uiCtrlArray[0] as FettersUIController);
					this.m_fettersUIController.EventOnReturn += this.FettersUIController_OnReturn;
					this.m_fettersUIController.EventOnShowHelp += this.FettersUIController_OnShowHelp;
					this.m_fettersUIController.EventOnListItemClick += this.FettersUIController_OnListItemClick;
					this.m_fettersUIController.EventOnInformationButtonClick += this.FettersUIController_OnInformationButtonClick;
					this.m_fettersUIController.EventOnFettersButtonClick += this.FettersUIController_OnFettersButtonClick;
				}
			}
			else if (this.m_curMode == "Favorability")
			{
				if (this.m_fettersFavorabilityUIController == null)
				{
					this.m_fettersFavorabilityUIController = (this.m_uiCtrlArray[1] as FettersFavorabilityUIController);
					this.m_fettersFavorabilityUIController.EventOnReturn += this.FettersFavorabilityUIController_OnReturn;
					this.m_fettersFavorabilityUIController.EventOnShowHelp += this.FettersFavorabilityUIController_OnShowHelp;
					this.m_fettersFavorabilityUIController.EventOnInformationButtonClick += this.FettersFavorabilityUIController_OnInformationButtonClick;
					this.m_fettersFavorabilityUIController.EventOnGiftButtonClick += this.FettersFavorabilityUIController_OnGiftButtonClick;
					this.m_fettersFavorabilityUIController.EventOnUseGift += this.FettersFavorabilityUIController_OnUseGift;
					this.m_fettersFavorabilityUIController.EventOnSliderFull += this.FettersFavorabilityUIController_OnHeroInteract;
					this.m_fettersFavorabilityUIController.EventOnMemoryButtonClick += this.FettersFavorabilityUIController_OnMemoryButtonClick;
					this.m_fettersFavorabilityUIController.EventOnFettersButtonClick += this.FettersFavorabilityUIController_OnFettersButtonClick;
					this.m_fettersFavorabilityUIController.EventOnGotoBagFullPanel += this.FettersFavorabilityUIController_GotoBagFullUITask;
				}
			}
			else if (this.m_curMode == "Information")
			{
				if (this.m_fettersInformationUIController == null)
				{
					this.m_fettersInformationUIController = (this.m_uiCtrlArray[2] as FettersInformationUIController);
					this.m_fettersInformationUIController.EventOnReturn += this.FettersInformationUIController_OnReturn;
					this.m_fettersInformationUIController.EventOnVoiceItemClick += this.FettersInformationUIController_OnVoiceItemClick;
				}
			}
			else if (this.m_curMode == "Confession" && this.m_fettersConfessionUIController == null)
			{
				this.m_fettersConfessionUIController = (this.m_uiCtrlArray[3] as FettersConfessionUIController);
				this.m_fettersConfessionUIController.EventOnReturn += this.FettersConfessionUIController_OnReturn;
				this.m_fettersConfessionUIController.EventOnShowHelp += this.FettersConfessionUIControlle_OnShowHelp;
				this.m_fettersConfessionUIController.EventOnGoldAdd += this.FettersConfessionUIController_OnAddGold;
				this.m_fettersConfessionUIController.EventOnAddCrystal += this.FettersConfessionUIController_OnAddCrystal;
				this.m_fettersConfessionUIController.EventOnSkillUnlockButtonClick += this.FettersConfessionUIController_OnSkillUnlockButtonClick;
				this.m_fettersConfessionUIController.EventOnEvolutionMaterialClick += this.FettersConfessionUIController_OnEvolutionMaterialClick;
				this.m_fettersConfessionUIController.EventOnEvolutionButtonClick += this.FettersConfessionUIController_OnEvolutionButtonClick;
				this.m_fettersConfessionUIController.EventOnHeroFetterConfess += this.FettersConfessionUIController_OnHeroFetterConfess;
			}
		}

		// Token: 0x0600E7F6 RID: 59382 RVA: 0x003E23A4 File Offset: 0x003E05A4
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
			if (this.m_fettersUIController != null)
			{
				this.m_fettersUIController.EventOnReturn -= this.FettersUIController_OnReturn;
				this.m_fettersUIController.EventOnShowHelp -= this.FettersUIController_OnShowHelp;
				this.m_fettersUIController.EventOnListItemClick -= this.FettersUIController_OnListItemClick;
				this.m_fettersUIController.EventOnFettersButtonClick -= this.FettersUIController_OnFettersButtonClick;
				this.m_fettersUIController.EventOnInformationButtonClick -= this.FettersUIController_OnInformationButtonClick;
				this.m_fettersUIController = null;
			}
			if (this.m_fettersFavorabilityUIController != null)
			{
				this.m_fettersFavorabilityUIController.EventOnReturn -= this.FettersFavorabilityUIController_OnReturn;
				this.m_fettersFavorabilityUIController.EventOnShowHelp -= this.FettersFavorabilityUIController_OnShowHelp;
				this.m_fettersFavorabilityUIController.EventOnInformationButtonClick -= this.FettersFavorabilityUIController_OnInformationButtonClick;
				this.m_fettersFavorabilityUIController.EventOnGiftButtonClick -= this.FettersFavorabilityUIController_OnGiftButtonClick;
				this.m_fettersFavorabilityUIController.EventOnUseGift -= this.FettersFavorabilityUIController_OnUseGift;
				this.m_fettersFavorabilityUIController.EventOnSliderFull -= this.FettersFavorabilityUIController_OnHeroInteract;
				this.m_fettersFavorabilityUIController.EventOnMemoryButtonClick -= this.FettersFavorabilityUIController_OnMemoryButtonClick;
				this.m_fettersFavorabilityUIController.EventOnFettersButtonClick -= this.FettersFavorabilityUIController_OnFettersButtonClick;
				this.m_fettersFavorabilityUIController.EventOnGotoBagFullPanel -= this.FettersFavorabilityUIController_GotoBagFullUITask;
				this.m_fettersFavorabilityUIController = null;
			}
			if (this.m_fettersInformationUIController != null)
			{
				this.m_fettersInformationUIController.EventOnReturn -= this.FettersInformationUIController_OnReturn;
				this.m_fettersInformationUIController.EventOnVoiceItemClick -= this.FettersInformationUIController_OnVoiceItemClick;
				this.m_fettersInformationUIController = null;
			}
			if (this.m_fettersConfessionUIController != null)
			{
				this.m_fettersConfessionUIController.EventOnReturn -= this.FettersConfessionUIController_OnReturn;
				this.m_fettersConfessionUIController.EventOnShowHelp -= this.FettersConfessionUIControlle_OnShowHelp;
				this.m_fettersConfessionUIController.EventOnGoldAdd -= this.FettersConfessionUIController_OnAddGold;
				this.m_fettersConfessionUIController.EventOnAddCrystal -= this.FettersConfessionUIController_OnAddCrystal;
				this.m_fettersConfessionUIController.EventOnSkillUnlockButtonClick -= this.FettersConfessionUIController_OnSkillUnlockButtonClick;
				this.m_fettersConfessionUIController.EventOnEvolutionMaterialClick -= this.FettersConfessionUIController_OnEvolutionMaterialClick;
				this.m_fettersConfessionUIController.EventOnEvolutionButtonClick -= this.FettersConfessionUIController_OnEvolutionButtonClick;
				this.m_fettersConfessionUIController.EventOnHeroFetterConfess -= this.FettersConfessionUIController_OnHeroFetterConfess;
				this.m_fettersConfessionUIController = null;
			}
		}

		// Token: 0x0600E7F7 RID: 59383 RVA: 0x003E2694 File Offset: 0x003E0894
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

		// Token: 0x0600E7F8 RID: 59384 RVA: 0x003E26FC File Offset: 0x003E08FC
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
			if (this.m_isNeedShowFadeIn)
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_isNeedShowFadeIn = false;
			}
			this.PushAndPopLayerByState();
			if (this.m_curMode == "Matthew")
			{
				this.m_fettersUIController.UpdateViewInFetters(this.m_hero);
			}
			else if (this.m_curMode == "Favorability")
			{
				this.m_fettersFavorabilityUIController.OpenFettersFavorability();
				this.m_fettersFavorabilityUIController.UpdateViewInFettersFavorability(this.m_hero);
			}
			else if (this.m_curMode == "Information")
			{
				if (this.m_lastMode == "Matthew")
				{
					this.m_fettersUIController.GoToInformationPanel(true);
				}
				else
				{
					this.m_fettersFavorabilityUIController.GoToInformationPanel(true);
				}
				this.m_fettersInformationUIController.UpdateViewInFettersInformation(this.m_hero);
			}
			else if (this.m_curMode == "Gift")
			{
				this.m_fettersFavorabilityUIController.OpenFettersGift();
				this.m_fettersFavorabilityUIController.UpdateViewInFettersGift(this.m_hero);
			}
			else if (this.m_curMode == "Confession")
			{
				this.m_fettersConfessionUIController.UpdateViewInFettersConfession(this.m_hero);
			}
			if (this.m_curMode == "Matthew" || this.m_curMode == "Favorability")
			{
				this.m_lastMode = this.m_curMode;
			}
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				BattleType structParam = uiintentCustom.GetStructParam<BattleType>("BattleType");
				Hero classParam = uiintentCustom.GetClassParam<Hero>("Hero");
				uiintentCustom.SetParam("BattleType", BattleType.None);
				uiintentCustom.SetParam("Hero", null);
				if (structParam != BattleType.None && classParam != null)
				{
					this.m_hero = classParam;
					this.FettersFavorabilityUIController_OnMemoryButtonClick(this.m_hero);
				}
			}
		}

		// Token: 0x0600E7F9 RID: 59385 RVA: 0x003E2934 File Offset: 0x003E0B34
		private void PushAndPopLayerByState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PushAndPopLayerByState_hotfix != null)
			{
				this.m_PushAndPopLayerByState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curMode == "Matthew")
			{
				SceneLayerBase sceneLayerBase = this.m_layerArray[0];
				if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase);
				}
				this.m_curLayerDescIndex = 0;
			}
			else if (this.m_curMode == "Favorability")
			{
				SceneLayerBase sceneLayerBase2 = this.m_layerArray[1];
				if (sceneLayerBase2.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase2);
				}
				this.m_curLayerDescIndex = 1;
			}
			else if (this.m_curMode == "Information")
			{
				SceneLayerBase sceneLayerBase3 = this.m_layerArray[2];
				if (sceneLayerBase3.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase3);
				}
				this.m_curLayerDescIndex = 2;
			}
			else if (this.m_curMode == "Confession")
			{
				SceneLayerBase sceneLayerBase4 = this.m_layerArray[3];
				if (sceneLayerBase4.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase4);
				}
				this.m_curLayerDescIndex = 3;
			}
			for (int i = 0; i < this.m_layerArray.Length; i++)
			{
				if (i != this.m_curLayerDescIndex && (this.m_curLayerDescIndex != 2 || i > 1))
				{
					SceneLayerBase sceneLayerBase5 = this.m_layerArray[i];
					if (sceneLayerBase5 != null && sceneLayerBase5.State == SceneLayerBase.LayerState.InStack)
					{
						SceneManager.Instance.PopLayer(sceneLayerBase5);
					}
				}
			}
		}

		// Token: 0x0600E7FA RID: 59386 RVA: 0x003E2B0C File Offset: 0x003E0D0C
		private void FettersUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersUIController_OnReturn_hotfix != null)
			{
				this.m_FettersUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x0600E7FB RID: 59387 RVA: 0x003E2B90 File Offset: 0x003E0D90
		private void FettersUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersUIController_OnShowHelp_hotfix != null)
			{
				this.m_FettersUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Fetters);
		}

		// Token: 0x0600E7FC RID: 59388 RVA: 0x003E2BFC File Offset: 0x003E0DFC
		private void FettersUIController_OnListItemClick(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersUIController_OnListItemClickHero_hotfix != null)
			{
				this.m_FettersUIController_OnListItemClickHero_hotfix.call(new object[]
				{
					this,
					hero2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = hero2;
			FettersUITask $this = this;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				$this.m_isNeedShowFadeIn = true;
				$this.m_hero = hero;
				$this.m_curMode = "Favorability";
				$this.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E7FD RID: 59389 RVA: 0x003E2CA4 File Offset: 0x003E0EA4
		private void FettersUIController_OnInformationButtonClick(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersUIController_OnInformationButtonClickHero_hotfix != null)
			{
				this.m_FettersUIController_OnInformationButtonClickHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_curMode = "Information";
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600E7FE RID: 59390 RVA: 0x003E2D34 File Offset: 0x003E0F34
		private void FettersUIController_OnFettersButtonClick(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersUIController_OnFettersButtonClickHero_hotfix != null)
			{
				this.m_FettersUIController_OnFettersButtonClickHero_hotfix.call(new object[]
				{
					this,
					hero2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = hero2;
			FettersUITask $this = this;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				$this.m_isNeedShowFadeIn = true;
				$this.m_hero = hero;
				$this.m_curMode = "Confession";
				$this.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E7FF RID: 59391 RVA: 0x003E2DDC File Offset: 0x003E0FDC
		private void FettersFavorabilityUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersFavorabilityUIController_OnReturn_hotfix != null)
			{
				this.m_FettersFavorabilityUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_isNeedShowFadeIn = true;
				this.m_hero = null;
				this.m_curMode = "Matthew";
				base.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E800 RID: 59392 RVA: 0x003E2E60 File Offset: 0x003E1060
		private void FettersFavorabilityUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersFavorabilityUIController_OnShowHelp_hotfix != null)
			{
				this.m_FettersFavorabilityUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_FettersFavorability);
		}

		// Token: 0x0600E801 RID: 59393 RVA: 0x003E2ECC File Offset: 0x003E10CC
		private void FettersFavorabilityUIController_OnInformationButtonClick(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersFavorabilityUIController_OnInformationButtonClickHero_hotfix != null)
			{
				this.m_FettersFavorabilityUIController_OnInformationButtonClickHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_curMode = "Information";
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600E802 RID: 59394 RVA: 0x003E2F5C File Offset: 0x003E115C
		private void FettersFavorabilityUIController_OnGiftButtonClick(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersFavorabilityUIController_OnGiftButtonClickHero_hotfix != null)
			{
				this.m_FettersFavorabilityUIController_OnGiftButtonClickHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_curMode = "Gift";
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600E803 RID: 59395 RVA: 0x003E2FEC File Offset: 0x003E11EC
		private void FettersFavorabilityUIController_OnUseGift(GoodsType goodsType, int itemId, int count, Action<List<Goods>> Onsucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersFavorabilityUIController_OnUseGiftGoodsTypeInt32Int32Action`1_hotfix != null)
			{
				this.m_FettersFavorabilityUIController_OnUseGiftGoodsTypeInt32Int32Action`1_hotfix.call(new object[]
				{
					this,
					goodsType,
					itemId,
					count,
					Onsucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<List<Goods>> Onsucceed = Onsucceed2;
			FettersUITask $this = this;
			HeroFavorabilityExpAddNetTask heroFavorabilityExpAddNetTask = new HeroFavorabilityExpAddNetTask(this.m_hero.HeroId, goodsType, itemId, count);
			heroFavorabilityExpAddNetTask.EventOnStop += delegate(Task task)
			{
				HeroFavorabilityExpAddNetTask heroFavorabilityExpAddNetTask2 = task as HeroFavorabilityExpAddNetTask;
				if (heroFavorabilityExpAddNetTask2.Result == 0)
				{
					Onsucceed(heroFavorabilityExpAddNetTask2.Rewards);
				}
				else if (heroFavorabilityExpAddNetTask2.Result == -500)
				{
					BagFullUITask.StartUITask($this.m_currIntent);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroFavorabilityExpAddNetTask2.Result, 2f, null, true);
				}
			};
			heroFavorabilityExpAddNetTask.Start(null);
		}

		// Token: 0x0600E804 RID: 59396 RVA: 0x003E30D0 File Offset: 0x003E12D0
		private void FettersFavorabilityUIController_GotoBagFullUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersFavorabilityUIController_GotoBagFullUITask_hotfix != null)
			{
				this.m_FettersFavorabilityUIController_GotoBagFullUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagFullUITask.StartUITask(this.m_currIntent);
		}

		// Token: 0x0600E805 RID: 59397 RVA: 0x003E313C File Offset: 0x003E133C
		private void FettersFavorabilityUIController_OnHeroInteract()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersFavorabilityUIController_OnHeroInteract_hotfix != null)
			{
				this.m_FettersFavorabilityUIController_OnHeroInteract_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroInteractNetTask heroInteractNetTask = new HeroInteractNetTask(this.m_hero.HeroId);
			heroInteractNetTask.EventOnStop += delegate(Task task)
			{
				HeroInteractNetTask heroInteractNetTask2 = task as HeroInteractNetTask;
				if (heroInteractNetTask2.Result == 0)
				{
					this.m_fettersFavorabilityUIController.OnHeroInteractSucceed(heroInteractNetTask2.Rewards, heroInteractNetTask2.HeroPerformanceId, heroInteractNetTask2.InteractResult, heroInteractNetTask2.AddFavoribilityExp);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroInteractNetTask2.Result, 2f, null, true);
				}
			};
			heroInteractNetTask.Start(null);
		}

		// Token: 0x0600E806 RID: 59398 RVA: 0x003E31C8 File Offset: 0x003E13C8
		private void FettersFavorabilityUIController_OnMemoryButtonClick(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersFavorabilityUIController_OnMemoryButtonClickHero_hotfix != null)
			{
				this.m_FettersFavorabilityUIController_OnMemoryButtonClickHero_hotfix.call(new object[]
				{
					this,
					hero2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = hero2;
			FettersUITask $this = this;
			this.m_hero = hero;
			if (hero == null)
			{
				return;
			}
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				$this.m_curMode = "Favorability";
				$this.Pause();
				if ($this.EventOnStartHeroDungeon != null)
				{
					$this.EventOnStartHeroDungeon(hero, $this.m_currIntent);
				}
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E807 RID: 59399 RVA: 0x003E3288 File Offset: 0x003E1488
		private void FettersFavorabilityUIController_OnFettersButtonClick(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersFavorabilityUIController_OnFettersButtonClickHero_hotfix != null)
			{
				this.m_FettersFavorabilityUIController_OnFettersButtonClickHero_hotfix.call(new object[]
				{
					this,
					hero2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = hero2;
			FettersUITask $this = this;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				$this.m_isNeedShowFadeIn = true;
				$this.m_hero = hero;
				$this.m_curMode = "Confession";
				$this.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E808 RID: 59400 RVA: 0x003E3330 File Offset: 0x003E1530
		private void FettersInformationUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersInformationUIController_OnReturn_hotfix != null)
			{
				this.m_FettersInformationUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curMode = this.m_lastMode;
			if (this.m_curMode == "Matthew")
			{
				this.m_fettersUIController.GoToInformationPanel(false);
			}
			else
			{
				this.m_fettersFavorabilityUIController.GoToInformationPanel(false);
			}
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600E809 RID: 59401 RVA: 0x003E33DC File Offset: 0x003E15DC
		private void FettersInformationUIController_OnVoiceItemClick(int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersInformationUIController_OnVoiceItemClickInt32_hotfix != null)
			{
				this.m_FettersInformationUIController_OnVoiceItemClickInt32_hotfix.call(new object[]
				{
					this,
					heroPerformanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_lastMode == "Matthew")
			{
				this.m_fettersUIController.PlayHeroPerformance(heroPerformanceId);
			}
			else if (this.m_lastMode == "Favorability")
			{
				this.m_fettersFavorabilityUIController.PlayHeroPerformance(heroPerformanceId);
			}
		}

		// Token: 0x0600E80A RID: 59402 RVA: 0x003E3494 File Offset: 0x003E1694
		private void FettersGiftUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersGiftUIController_OnReturn_hotfix != null)
			{
				this.m_FettersGiftUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_isNeedShowFadeIn = true;
				this.m_curMode = this.m_lastMode;
				base.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E80B RID: 59403 RVA: 0x003E3518 File Offset: 0x003E1718
		private void FettersConfessionUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersConfessionUIController_OnReturn_hotfix != null)
			{
				this.m_FettersConfessionUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_isNeedShowFadeIn = true;
				this.m_curMode = this.m_lastMode;
				base.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E80C RID: 59404 RVA: 0x003E359C File Offset: 0x003E179C
		private void FettersConfessionUIControlle_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersConfessionUIControlle_OnShowHelp_hotfix != null)
			{
				this.m_FettersConfessionUIControlle_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_FettersConfession);
		}

		// Token: 0x0600E80D RID: 59405 RVA: 0x003E3608 File Offset: 0x003E1808
		private void FettersConfessionUIController_OnAddGold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersConfessionUIController_OnAddGold_hotfix != null)
			{
				this.m_FettersConfessionUIController_OnAddGold_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Crystal, null, false);
		}

		// Token: 0x0600E80E RID: 59406 RVA: 0x003E3680 File Offset: 0x003E1880
		private void FettersConfessionUIController_OnAddCrystal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersConfessionUIController_OnAddCrystal_hotfix != null)
			{
				this.m_FettersConfessionUIController_OnAddCrystal_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
		}

		// Token: 0x0600E80F RID: 59407 RVA: 0x003E36F8 File Offset: 0x003E18F8
		private void FettersConfessionUIController_OnSkillUnlockButtonClick(int heroId, int fetterId, Action<List<Goods>> OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersConfessionUIController_OnSkillUnlockButtonClickInt32Int32Action`1_hotfix != null)
			{
				this.m_FettersConfessionUIController_OnSkillUnlockButtonClickInt32Int32Action`1_hotfix.call(new object[]
				{
					this,
					heroId,
					fetterId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<List<Goods>> OnSucceed = OnSucceed2;
			FettersUITask $this = this;
			FetterSkillUnlockNetTask fetterSkillUnlockNetTask = new FetterSkillUnlockNetTask(heroId, fetterId);
			fetterSkillUnlockNetTask.EventOnStop += delegate(Task task)
			{
				FetterSkillUnlockNetTask fetterSkillUnlockNetTask2 = task as FetterSkillUnlockNetTask;
				if (fetterSkillUnlockNetTask2.Result == 0)
				{
					$this.StartUpdatePipeLine(null, false, false, true);
					OnSucceed(fetterSkillUnlockNetTask2.Rewards);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(fetterSkillUnlockNetTask2.Result, 2f, null, true);
				}
			};
			fetterSkillUnlockNetTask.Start(null);
		}

		// Token: 0x0600E810 RID: 59408 RVA: 0x003E37C0 File Offset: 0x003E19C0
		private void FettersConfessionUIController_OnEvolutionButtonClick(int heroId, int fetterId, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersConfessionUIController_OnEvolutionButtonClickInt32Int32Action_hotfix != null)
			{
				this.m_FettersConfessionUIController_OnEvolutionButtonClickInt32Int32Action_hotfix.call(new object[]
				{
					this,
					heroId,
					fetterId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			FettersUITask $this = this;
			HeroFetterLevelUpNetTask heroFetterLevelUpNetTask = new HeroFetterLevelUpNetTask(heroId, fetterId);
			heroFetterLevelUpNetTask.EventOnStop += delegate(Task task)
			{
				HeroFetterLevelUpNetTask heroFetterLevelUpNetTask2 = task as HeroFetterLevelUpNetTask;
				if (heroFetterLevelUpNetTask2.Result == 0)
				{
					$this.StartUpdatePipeLine(null, false, false, true);
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroFetterLevelUpNetTask2.Result, 2f, null, true);
				}
			};
			heroFetterLevelUpNetTask.Start(null);
		}

		// Token: 0x0600E811 RID: 59409 RVA: 0x003E3888 File Offset: 0x003E1A88
		private void FettersConfessionUIController_OnHeroFetterConfess(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersConfessionUIController_OnHeroFetterConfessInt32_hotfix != null)
			{
				this.m_FettersConfessionUIController_OnHeroFetterConfessInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroConfessNetTask heroConfessNetTask = new HeroConfessNetTask(heroId);
			heroConfessNetTask.EventOnStop += delegate(Task task)
			{
				HeroConfessNetTask heroConfessNetTask2 = task as HeroConfessNetTask;
				if (heroConfessNetTask2.Result == 0)
				{
					this.m_fettersConfessionUIController.OnConfessionAndRewardSucceedEffect(heroConfessNetTask2.Rewards);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroConfessNetTask2.Result, 2f, null, true);
				}
			};
			heroConfessNetTask.Start(null);
		}

		// Token: 0x0600E812 RID: 59410 RVA: 0x003E391C File Offset: 0x003E1B1C
		private void FettersConfessionUIController_OnEvolutionMaterialClick(GoodsType goodsType, int goodsId, int needCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersConfessionUIController_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_FettersConfessionUIController_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					goodsType,
					goodsId,
					needCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetPathUITask.StartUITask(goodsType, goodsId, new Action<GetPathData, NeedGoods>(this.FettersConfessionUIController_OnGotoGetPath), needCount);
		}

		// Token: 0x0600E813 RID: 59411 RVA: 0x003E39C4 File Offset: 0x003E1BC4
		private void FettersConfessionUIController_OnGotoGetPath(GetPathData getPath, NeedGoods needGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FettersConfessionUIController_OnGotoGetPathGetPathDataNeedGoods_hotfix != null)
			{
				this.m_FettersConfessionUIController_OnGotoGetPathGetPathDataNeedGoods_hotfix.call(new object[]
				{
					this,
					getPath,
					needGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			WorldUITask.StartGetPathTargetUITask(getPath, this.m_currIntent, needGoods);
		}

		// Token: 0x0600E814 RID: 59412 RVA: 0x003E3A58 File Offset: 0x003E1C58
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
			if (this.m_fettersFavorabilityUIController == null)
			{
				return;
			}
			int second = DateTime.Now.Second;
			if (second != this.m_nowSeconds)
			{
				this.m_nowSeconds = second;
				this.UpdateTouchTimeText();
			}
		}

		// Token: 0x0600E815 RID: 59413 RVA: 0x003E3AF8 File Offset: 0x003E1CF8
		private void UpdateTouchTimeText()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTouchTimeText_hotfix != null)
			{
				this.m_UpdateTouchTimeText_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TimeSpan touchRecoverTime = this.m_playerContext.GetHeroInteractNumsFlushTime() + TimeSpan.FromSeconds((double)this.m_configDataLoader.ConfigableConstId_HeroInteractNumsRecoveryPeriod) - this.m_playerContext.GetServerTime();
			this.m_fettersFavorabilityUIController.SetTouchRecoverTime(touchRecoverTime);
		}

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x0600E816 RID: 59414 RVA: 0x003E3B98 File Offset: 0x003E1D98
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

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x0600E817 RID: 59415 RVA: 0x003E3C0C File Offset: 0x003E1E0C
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

		// Token: 0x140002F7 RID: 759
		// (add) Token: 0x0600E818 RID: 59416 RVA: 0x003E3C80 File Offset: 0x003E1E80
		// (remove) Token: 0x0600E819 RID: 59417 RVA: 0x003E3D1C File Offset: 0x003E1F1C
		public event Action<Hero, UIIntent> EventOnStartHeroDungeon
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartHeroDungeonAction`2_hotfix != null)
				{
					this.m_add_EventOnStartHeroDungeonAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero, UIIntent> action = this.EventOnStartHeroDungeon;
				Action<Hero, UIIntent> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero, UIIntent>>(ref this.EventOnStartHeroDungeon, (Action<Hero, UIIntent>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartHeroDungeonAction`2_hotfix != null)
				{
					this.m_remove_EventOnStartHeroDungeonAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero, UIIntent> action = this.EventOnStartHeroDungeon;
				Action<Hero, UIIntent> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero, UIIntent>>(ref this.EventOnStartHeroDungeon, (Action<Hero, UIIntent>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x0600E81A RID: 59418 RVA: 0x003E3DB8 File Offset: 0x003E1FB8
		// (set) Token: 0x0600E81B RID: 59419 RVA: 0x003E3DD8 File Offset: 0x003E1FD8
		[DoNotToLua]
		public new FettersUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E81C RID: 59420 RVA: 0x003E3DE4 File Offset: 0x003E1FE4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600E81D RID: 59421 RVA: 0x003E3DF0 File Offset: 0x003E1FF0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600E81E RID: 59422 RVA: 0x003E3DF8 File Offset: 0x003E1FF8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600E81F RID: 59423 RVA: 0x003E3E00 File Offset: 0x003E2000
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600E820 RID: 59424 RVA: 0x003E3E0C File Offset: 0x003E200C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600E821 RID: 59425 RVA: 0x003E3E18 File Offset: 0x003E2018
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600E822 RID: 59426 RVA: 0x003E3E24 File Offset: 0x003E2024
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600E823 RID: 59427 RVA: 0x003E3E2C File Offset: 0x003E202C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600E824 RID: 59428 RVA: 0x003E3E34 File Offset: 0x003E2034
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600E825 RID: 59429 RVA: 0x003E3E3C File Offset: 0x003E203C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600E826 RID: 59430 RVA: 0x003E3E44 File Offset: 0x003E2044
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600E827 RID: 59431 RVA: 0x003E3E4C File Offset: 0x003E204C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600E828 RID: 59432 RVA: 0x003E3E54 File Offset: 0x003E2054
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600E829 RID: 59433 RVA: 0x003E3E5C File Offset: 0x003E205C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600E82A RID: 59434 RVA: 0x003E3E68 File Offset: 0x003E2068
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600E82B RID: 59435 RVA: 0x003E3E74 File Offset: 0x003E2074
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600E82C RID: 59436 RVA: 0x003E3E80 File Offset: 0x003E2080
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600E82D RID: 59437 RVA: 0x003E3E8C File Offset: 0x003E208C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600E82E RID: 59438 RVA: 0x003E3E94 File Offset: 0x003E2094
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600E82F RID: 59439 RVA: 0x003E3E9C File Offset: 0x003E209C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600E830 RID: 59440 RVA: 0x003E3EA4 File Offset: 0x003E20A4
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600E831 RID: 59441 RVA: 0x003E3EAC File Offset: 0x003E20AC
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600E832 RID: 59442 RVA: 0x003E3EB4 File Offset: 0x003E20B4
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600E833 RID: 59443 RVA: 0x003E3EBC File Offset: 0x003E20BC
		private void __callDele_EventOnStartHeroDungeon(Hero arg1, UIIntent arg2)
		{
			Action<Hero, UIIntent> eventOnStartHeroDungeon = this.EventOnStartHeroDungeon;
			if (eventOnStartHeroDungeon != null)
			{
				eventOnStartHeroDungeon(arg1, arg2);
			}
		}

		// Token: 0x0600E834 RID: 59444 RVA: 0x003E3EE0 File Offset: 0x003E20E0
		private void __clearDele_EventOnStartHeroDungeon(Hero arg1, UIIntent arg2)
		{
			this.EventOnStartHeroDungeon = null;
		}

		// Token: 0x0600E83B RID: 59451 RVA: 0x003E401C File Offset: 0x003E221C
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_SaveUIStateToIntent_hotfix = (luaObj.RawGet("SaveUIStateToIntent") as LuaFunction);
					this.m_GetUIStateFromIntentUIIntent_hotfix = (luaObj.RawGet("GetUIStateFromIntent") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_IsNeedLoadStaticRes_hotfix = (luaObj.RawGet("IsNeedLoadStaticRes") as LuaFunction);
					this.m_CollectAllStaticResDescForLoad_hotfix = (luaObj.RawGet("CollectAllStaticResDescForLoad") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PushAndPopLayerByState_hotfix = (luaObj.RawGet("PushAndPopLayerByState") as LuaFunction);
					this.m_FettersUIController_OnReturn_hotfix = (luaObj.RawGet("FettersUIController_OnReturn") as LuaFunction);
					this.m_FettersUIController_OnShowHelp_hotfix = (luaObj.RawGet("FettersUIController_OnShowHelp") as LuaFunction);
					this.m_FettersUIController_OnListItemClickHero_hotfix = (luaObj.RawGet("FettersUIController_OnListItemClick") as LuaFunction);
					this.m_FettersUIController_OnInformationButtonClickHero_hotfix = (luaObj.RawGet("FettersUIController_OnInformationButtonClick") as LuaFunction);
					this.m_FettersUIController_OnFettersButtonClickHero_hotfix = (luaObj.RawGet("FettersUIController_OnFettersButtonClick") as LuaFunction);
					this.m_FettersFavorabilityUIController_OnReturn_hotfix = (luaObj.RawGet("FettersFavorabilityUIController_OnReturn") as LuaFunction);
					this.m_FettersFavorabilityUIController_OnShowHelp_hotfix = (luaObj.RawGet("FettersFavorabilityUIController_OnShowHelp") as LuaFunction);
					this.m_FettersFavorabilityUIController_OnInformationButtonClickHero_hotfix = (luaObj.RawGet("FettersFavorabilityUIController_OnInformationButtonClick") as LuaFunction);
					this.m_FettersFavorabilityUIController_OnGiftButtonClickHero_hotfix = (luaObj.RawGet("FettersFavorabilityUIController_OnGiftButtonClick") as LuaFunction);
					this.m_FettersFavorabilityUIController_OnUseGiftGoodsTypeInt32Int32Action`1_hotfix = (luaObj.RawGet("FettersFavorabilityUIController_OnUseGift") as LuaFunction);
					this.m_FettersFavorabilityUIController_GotoBagFullUITask_hotfix = (luaObj.RawGet("FettersFavorabilityUIController_GotoBagFullUITask") as LuaFunction);
					this.m_FettersFavorabilityUIController_OnHeroInteract_hotfix = (luaObj.RawGet("FettersFavorabilityUIController_OnHeroInteract") as LuaFunction);
					this.m_FettersFavorabilityUIController_OnMemoryButtonClickHero_hotfix = (luaObj.RawGet("FettersFavorabilityUIController_OnMemoryButtonClick") as LuaFunction);
					this.m_FettersFavorabilityUIController_OnFettersButtonClickHero_hotfix = (luaObj.RawGet("FettersFavorabilityUIController_OnFettersButtonClick") as LuaFunction);
					this.m_FettersInformationUIController_OnReturn_hotfix = (luaObj.RawGet("FettersInformationUIController_OnReturn") as LuaFunction);
					this.m_FettersInformationUIController_OnVoiceItemClickInt32_hotfix = (luaObj.RawGet("FettersInformationUIController_OnVoiceItemClick") as LuaFunction);
					this.m_FettersGiftUIController_OnReturn_hotfix = (luaObj.RawGet("FettersGiftUIController_OnReturn") as LuaFunction);
					this.m_FettersConfessionUIController_OnReturn_hotfix = (luaObj.RawGet("FettersConfessionUIController_OnReturn") as LuaFunction);
					this.m_FettersConfessionUIControlle_OnShowHelp_hotfix = (luaObj.RawGet("FettersConfessionUIControlle_OnShowHelp") as LuaFunction);
					this.m_FettersConfessionUIController_OnAddGold_hotfix = (luaObj.RawGet("FettersConfessionUIController_OnAddGold") as LuaFunction);
					this.m_FettersConfessionUIController_OnAddCrystal_hotfix = (luaObj.RawGet("FettersConfessionUIController_OnAddCrystal") as LuaFunction);
					this.m_FettersConfessionUIController_OnSkillUnlockButtonClickInt32Int32Action`1_hotfix = (luaObj.RawGet("FettersConfessionUIController_OnSkillUnlockButtonClick") as LuaFunction);
					this.m_FettersConfessionUIController_OnEvolutionButtonClickInt32Int32Action_hotfix = (luaObj.RawGet("FettersConfessionUIController_OnEvolutionButtonClick") as LuaFunction);
					this.m_FettersConfessionUIController_OnHeroFetterConfessInt32_hotfix = (luaObj.RawGet("FettersConfessionUIController_OnHeroFetterConfess") as LuaFunction);
					this.m_FettersConfessionUIController_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("FettersConfessionUIController_OnEvolutionMaterialClick") as LuaFunction);
					this.m_FettersConfessionUIController_OnGotoGetPathGetPathDataNeedGoods_hotfix = (luaObj.RawGet("FettersConfessionUIController_OnGotoGetPath") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_UpdateTouchTimeText_hotfix = (luaObj.RawGet("UpdateTouchTimeText") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					this.m_add_EventOnStartHeroDungeonAction`2_hotfix = (luaObj.RawGet("add_EventOnStartHeroDungeon") as LuaFunction);
					this.m_remove_EventOnStartHeroDungeonAction`2_hotfix = (luaObj.RawGet("remove_EventOnStartHeroDungeon") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E83C RID: 59452 RVA: 0x003E4568 File Offset: 0x003E2768
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008B82 RID: 35714
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "FettersUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Fetters_ABS/Prefab/FettersMatthewUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = false
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "FettersFavorabilityUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Fetters_ABS/Prefab/FettersFavorabilityUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "FettersInformationUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Fetters_ABS/Prefab/FettersInformationUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "FettersConfessionUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Fetters_ABS/Prefab/FettersConfessionUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			}
		};

		// Token: 0x04008B83 RID: 35715
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "FettersUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.FettersUIController"),
				m_ctrlName = "FettersUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "FettersFavorabilityUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.FettersFavorabilityUIController"),
				m_ctrlName = "FettersFavorabilityUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "FettersInformationUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.FettersInformationUIController"),
				m_ctrlName = "FettersInformationUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "FettersConfessionUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.FettersConfessionUIController"),
				m_ctrlName = "FettersConfessionUIController"
			}
		};

		// Token: 0x04008B84 RID: 35716
		private FettersUIController m_fettersUIController;

		// Token: 0x04008B85 RID: 35717
		private FettersFavorabilityUIController m_fettersFavorabilityUIController;

		// Token: 0x04008B86 RID: 35718
		private FettersInformationUIController m_fettersInformationUIController;

		// Token: 0x04008B87 RID: 35719
		private FettersConfessionUIController m_fettersConfessionUIController;

		// Token: 0x04008B88 RID: 35720
		public const string MatthewMode = "Matthew";

		// Token: 0x04008B89 RID: 35721
		public const string FavorabilityMode = "Favorability";

		// Token: 0x04008B8A RID: 35722
		public const string InformationMode = "Information";

		// Token: 0x04008B8B RID: 35723
		public const string GiftMode = "Gift";

		// Token: 0x04008B8C RID: 35724
		public const string ConfessionMode = "Confession";

		// Token: 0x04008B8D RID: 35725
		private string m_curMode = "Matthew";

		// Token: 0x04008B8E RID: 35726
		private string m_lastMode = "Matthew";

		// Token: 0x04008B8F RID: 35727
		private int m_curLayerDescIndex;

		// Token: 0x04008B90 RID: 35728
		private Hero m_hero;

		// Token: 0x04008B91 RID: 35729
		private int m_lastHeroId;

		// Token: 0x04008B92 RID: 35730
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008B93 RID: 35731
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008B94 RID: 35732
		private int m_nowSeconds;

		// Token: 0x04008B96 RID: 35734
		private bool m_isNeedShowFadeIn;

		// Token: 0x04008B97 RID: 35735
		[DoNotToLua]
		private FettersUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04008B98 RID: 35736
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008B99 RID: 35737
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008B9A RID: 35738
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04008B9B RID: 35739
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04008B9C RID: 35740
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04008B9D RID: 35741
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04008B9E RID: 35742
		private LuaFunction m_SaveUIStateToIntent_hotfix;

		// Token: 0x04008B9F RID: 35743
		private LuaFunction m_GetUIStateFromIntentUIIntent_hotfix;

		// Token: 0x04008BA0 RID: 35744
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04008BA1 RID: 35745
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x04008BA2 RID: 35746
		private LuaFunction m_IsNeedLoadStaticRes_hotfix;

		// Token: 0x04008BA3 RID: 35747
		private LuaFunction m_CollectAllStaticResDescForLoad_hotfix;

		// Token: 0x04008BA4 RID: 35748
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04008BA5 RID: 35749
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04008BA6 RID: 35750
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04008BA7 RID: 35751
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008BA8 RID: 35752
		private LuaFunction m_PushAndPopLayerByState_hotfix;

		// Token: 0x04008BA9 RID: 35753
		private LuaFunction m_FettersUIController_OnReturn_hotfix;

		// Token: 0x04008BAA RID: 35754
		private LuaFunction m_FettersUIController_OnShowHelp_hotfix;

		// Token: 0x04008BAB RID: 35755
		private LuaFunction m_FettersUIController_OnListItemClickHero_hotfix;

		// Token: 0x04008BAC RID: 35756
		private LuaFunction m_FettersUIController_OnInformationButtonClickHero_hotfix;

		// Token: 0x04008BAD RID: 35757
		private LuaFunction m_FettersUIController_OnFettersButtonClickHero_hotfix;

		// Token: 0x04008BAE RID: 35758
		private LuaFunction m_FettersFavorabilityUIController_OnReturn_hotfix;

		// Token: 0x04008BAF RID: 35759
		private LuaFunction m_FettersFavorabilityUIController_OnShowHelp_hotfix;

		// Token: 0x04008BB0 RID: 35760
		private LuaFunction m_FettersFavorabilityUIController_OnInformationButtonClickHero_hotfix;

		// Token: 0x04008BB1 RID: 35761
		private LuaFunction m_FettersFavorabilityUIController_OnGiftButtonClickHero_hotfix;

		// Token: 0x04008BB2 RID: 35762
		private LuaFunction m_FettersFavorabilityUIController_OnUseGiftGoodsTypeInt32Int32Action;

		// Token: 0x04008BB3 RID: 35763
		private LuaFunction m_FettersFavorabilityUIController_GotoBagFullUITask_hotfix;

		// Token: 0x04008BB4 RID: 35764
		private LuaFunction m_FettersFavorabilityUIController_OnHeroInteract_hotfix;

		// Token: 0x04008BB5 RID: 35765
		private LuaFunction m_FettersFavorabilityUIController_OnMemoryButtonClickHero_hotfix;

		// Token: 0x04008BB6 RID: 35766
		private LuaFunction m_FettersFavorabilityUIController_OnFettersButtonClickHero_hotfix;

		// Token: 0x04008BB7 RID: 35767
		private LuaFunction m_FettersInformationUIController_OnReturn_hotfix;

		// Token: 0x04008BB8 RID: 35768
		private LuaFunction m_FettersInformationUIController_OnVoiceItemClickInt32_hotfix;

		// Token: 0x04008BB9 RID: 35769
		private LuaFunction m_FettersGiftUIController_OnReturn_hotfix;

		// Token: 0x04008BBA RID: 35770
		private LuaFunction m_FettersConfessionUIController_OnReturn_hotfix;

		// Token: 0x04008BBB RID: 35771
		private LuaFunction m_FettersConfessionUIControlle_OnShowHelp_hotfix;

		// Token: 0x04008BBC RID: 35772
		private LuaFunction m_FettersConfessionUIController_OnAddGold_hotfix;

		// Token: 0x04008BBD RID: 35773
		private LuaFunction m_FettersConfessionUIController_OnAddCrystal_hotfix;

		// Token: 0x04008BBE RID: 35774
		private LuaFunction m_FettersConfessionUIController_OnSkillUnlockButtonClickInt32Int32Action;

		// Token: 0x04008BBF RID: 35775
		private LuaFunction m_FettersConfessionUIController_OnEvolutionButtonClickInt32Int32Action_hotfix;

		// Token: 0x04008BC0 RID: 35776
		private LuaFunction m_FettersConfessionUIController_OnHeroFetterConfessInt32_hotfix;

		// Token: 0x04008BC1 RID: 35777
		private LuaFunction m_FettersConfessionUIController_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix;

		// Token: 0x04008BC2 RID: 35778
		private LuaFunction m_FettersConfessionUIController_OnGotoGetPathGetPathDataNeedGoods_hotfix;

		// Token: 0x04008BC3 RID: 35779
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x04008BC4 RID: 35780
		private LuaFunction m_UpdateTouchTimeText_hotfix;

		// Token: 0x04008BC5 RID: 35781
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04008BC6 RID: 35782
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x04008BC7 RID: 35783
		private LuaFunction m_add_EventOnStartHeroDungeonAction;

		// Token: 0x04008BC8 RID: 35784
		private LuaFunction m_remove_EventOnStartHeroDungeonAction;

		// Token: 0x02000C90 RID: 3216
		public new class LuaExportHelper
		{
			// Token: 0x0600E83D RID: 59453 RVA: 0x003E45D0 File Offset: 0x003E27D0
			public LuaExportHelper(FettersUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E83E RID: 59454 RVA: 0x003E45E0 File Offset: 0x003E27E0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600E83F RID: 59455 RVA: 0x003E45F0 File Offset: 0x003E27F0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600E840 RID: 59456 RVA: 0x003E4600 File Offset: 0x003E2800
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600E841 RID: 59457 RVA: 0x003E4610 File Offset: 0x003E2810
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600E842 RID: 59458 RVA: 0x003E4620 File Offset: 0x003E2820
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600E843 RID: 59459 RVA: 0x003E4630 File Offset: 0x003E2830
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600E844 RID: 59460 RVA: 0x003E4640 File Offset: 0x003E2840
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600E845 RID: 59461 RVA: 0x003E4650 File Offset: 0x003E2850
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600E846 RID: 59462 RVA: 0x003E4660 File Offset: 0x003E2860
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600E847 RID: 59463 RVA: 0x003E4670 File Offset: 0x003E2870
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600E848 RID: 59464 RVA: 0x003E4680 File Offset: 0x003E2880
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600E849 RID: 59465 RVA: 0x003E4690 File Offset: 0x003E2890
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600E84A RID: 59466 RVA: 0x003E46A0 File Offset: 0x003E28A0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600E84B RID: 59467 RVA: 0x003E46B0 File Offset: 0x003E28B0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600E84C RID: 59468 RVA: 0x003E46C0 File Offset: 0x003E28C0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600E84D RID: 59469 RVA: 0x003E46D0 File Offset: 0x003E28D0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600E84E RID: 59470 RVA: 0x003E46E0 File Offset: 0x003E28E0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600E84F RID: 59471 RVA: 0x003E46F0 File Offset: 0x003E28F0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600E850 RID: 59472 RVA: 0x003E4700 File Offset: 0x003E2900
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600E851 RID: 59473 RVA: 0x003E4710 File Offset: 0x003E2910
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600E852 RID: 59474 RVA: 0x003E4720 File Offset: 0x003E2920
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600E853 RID: 59475 RVA: 0x003E4730 File Offset: 0x003E2930
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600E854 RID: 59476 RVA: 0x003E4740 File Offset: 0x003E2940
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600E855 RID: 59477 RVA: 0x003E4750 File Offset: 0x003E2950
			public void __callDele_EventOnStartHeroDungeon(Hero arg1, UIIntent arg2)
			{
				this.m_owner.__callDele_EventOnStartHeroDungeon(arg1, arg2);
			}

			// Token: 0x0600E856 RID: 59478 RVA: 0x003E4760 File Offset: 0x003E2960
			public void __clearDele_EventOnStartHeroDungeon(Hero arg1, UIIntent arg2)
			{
				this.m_owner.__clearDele_EventOnStartHeroDungeon(arg1, arg2);
			}

			// Token: 0x17002D03 RID: 11523
			// (get) Token: 0x0600E857 RID: 59479 RVA: 0x003E4770 File Offset: 0x003E2970
			// (set) Token: 0x0600E858 RID: 59480 RVA: 0x003E4780 File Offset: 0x003E2980
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

			// Token: 0x17002D04 RID: 11524
			// (get) Token: 0x0600E859 RID: 59481 RVA: 0x003E4790 File Offset: 0x003E2990
			// (set) Token: 0x0600E85A RID: 59482 RVA: 0x003E47A0 File Offset: 0x003E29A0
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

			// Token: 0x17002D05 RID: 11525
			// (get) Token: 0x0600E85B RID: 59483 RVA: 0x003E47B0 File Offset: 0x003E29B0
			// (set) Token: 0x0600E85C RID: 59484 RVA: 0x003E47C0 File Offset: 0x003E29C0
			public FettersUIController m_fettersUIController
			{
				get
				{
					return this.m_owner.m_fettersUIController;
				}
				set
				{
					this.m_owner.m_fettersUIController = value;
				}
			}

			// Token: 0x17002D06 RID: 11526
			// (get) Token: 0x0600E85D RID: 59485 RVA: 0x003E47D0 File Offset: 0x003E29D0
			// (set) Token: 0x0600E85E RID: 59486 RVA: 0x003E47E0 File Offset: 0x003E29E0
			public FettersFavorabilityUIController m_fettersFavorabilityUIController
			{
				get
				{
					return this.m_owner.m_fettersFavorabilityUIController;
				}
				set
				{
					this.m_owner.m_fettersFavorabilityUIController = value;
				}
			}

			// Token: 0x17002D07 RID: 11527
			// (get) Token: 0x0600E85F RID: 59487 RVA: 0x003E47F0 File Offset: 0x003E29F0
			// (set) Token: 0x0600E860 RID: 59488 RVA: 0x003E4800 File Offset: 0x003E2A00
			public FettersInformationUIController m_fettersInformationUIController
			{
				get
				{
					return this.m_owner.m_fettersInformationUIController;
				}
				set
				{
					this.m_owner.m_fettersInformationUIController = value;
				}
			}

			// Token: 0x17002D08 RID: 11528
			// (get) Token: 0x0600E861 RID: 59489 RVA: 0x003E4810 File Offset: 0x003E2A10
			// (set) Token: 0x0600E862 RID: 59490 RVA: 0x003E4820 File Offset: 0x003E2A20
			public FettersConfessionUIController m_fettersConfessionUIController
			{
				get
				{
					return this.m_owner.m_fettersConfessionUIController;
				}
				set
				{
					this.m_owner.m_fettersConfessionUIController = value;
				}
			}

			// Token: 0x17002D09 RID: 11529
			// (get) Token: 0x0600E863 RID: 59491 RVA: 0x003E4830 File Offset: 0x003E2A30
			// (set) Token: 0x0600E864 RID: 59492 RVA: 0x003E4840 File Offset: 0x003E2A40
			public string m_curMode
			{
				get
				{
					return this.m_owner.m_curMode;
				}
				set
				{
					this.m_owner.m_curMode = value;
				}
			}

			// Token: 0x17002D0A RID: 11530
			// (get) Token: 0x0600E865 RID: 59493 RVA: 0x003E4850 File Offset: 0x003E2A50
			// (set) Token: 0x0600E866 RID: 59494 RVA: 0x003E4860 File Offset: 0x003E2A60
			public string m_lastMode
			{
				get
				{
					return this.m_owner.m_lastMode;
				}
				set
				{
					this.m_owner.m_lastMode = value;
				}
			}

			// Token: 0x17002D0B RID: 11531
			// (get) Token: 0x0600E867 RID: 59495 RVA: 0x003E4870 File Offset: 0x003E2A70
			// (set) Token: 0x0600E868 RID: 59496 RVA: 0x003E4880 File Offset: 0x003E2A80
			public int m_curLayerDescIndex
			{
				get
				{
					return this.m_owner.m_curLayerDescIndex;
				}
				set
				{
					this.m_owner.m_curLayerDescIndex = value;
				}
			}

			// Token: 0x17002D0C RID: 11532
			// (get) Token: 0x0600E869 RID: 59497 RVA: 0x003E4890 File Offset: 0x003E2A90
			// (set) Token: 0x0600E86A RID: 59498 RVA: 0x003E48A0 File Offset: 0x003E2AA0
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

			// Token: 0x17002D0D RID: 11533
			// (get) Token: 0x0600E86B RID: 59499 RVA: 0x003E48B0 File Offset: 0x003E2AB0
			// (set) Token: 0x0600E86C RID: 59500 RVA: 0x003E48C0 File Offset: 0x003E2AC0
			public int m_lastHeroId
			{
				get
				{
					return this.m_owner.m_lastHeroId;
				}
				set
				{
					this.m_owner.m_lastHeroId = value;
				}
			}

			// Token: 0x17002D0E RID: 11534
			// (get) Token: 0x0600E86D RID: 59501 RVA: 0x003E48D0 File Offset: 0x003E2AD0
			// (set) Token: 0x0600E86E RID: 59502 RVA: 0x003E48E0 File Offset: 0x003E2AE0
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

			// Token: 0x17002D0F RID: 11535
			// (get) Token: 0x0600E86F RID: 59503 RVA: 0x003E48F0 File Offset: 0x003E2AF0
			// (set) Token: 0x0600E870 RID: 59504 RVA: 0x003E4900 File Offset: 0x003E2B00
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

			// Token: 0x17002D10 RID: 11536
			// (get) Token: 0x0600E871 RID: 59505 RVA: 0x003E4910 File Offset: 0x003E2B10
			// (set) Token: 0x0600E872 RID: 59506 RVA: 0x003E4920 File Offset: 0x003E2B20
			public int m_nowSeconds
			{
				get
				{
					return this.m_owner.m_nowSeconds;
				}
				set
				{
					this.m_owner.m_nowSeconds = value;
				}
			}

			// Token: 0x17002D11 RID: 11537
			// (get) Token: 0x0600E873 RID: 59507 RVA: 0x003E4930 File Offset: 0x003E2B30
			// (set) Token: 0x0600E874 RID: 59508 RVA: 0x003E4940 File Offset: 0x003E2B40
			public bool m_isNeedShowFadeIn
			{
				get
				{
					return this.m_owner.m_isNeedShowFadeIn;
				}
				set
				{
					this.m_owner.m_isNeedShowFadeIn = value;
				}
			}

			// Token: 0x17002D12 RID: 11538
			// (get) Token: 0x0600E875 RID: 59509 RVA: 0x003E4950 File Offset: 0x003E2B50
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002D13 RID: 11539
			// (get) Token: 0x0600E876 RID: 59510 RVA: 0x003E4960 File Offset: 0x003E2B60
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600E877 RID: 59511 RVA: 0x003E4970 File Offset: 0x003E2B70
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600E878 RID: 59512 RVA: 0x003E4980 File Offset: 0x003E2B80
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600E879 RID: 59513 RVA: 0x003E4990 File Offset: 0x003E2B90
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600E87A RID: 59514 RVA: 0x003E49A0 File Offset: 0x003E2BA0
			public void SaveUIStateToIntent()
			{
				this.m_owner.SaveUIStateToIntent();
			}

			// Token: 0x0600E87B RID: 59515 RVA: 0x003E49B0 File Offset: 0x003E2BB0
			public void GetUIStateFromIntent(UIIntent uiIntent)
			{
				this.m_owner.GetUIStateFromIntent(uiIntent);
			}

			// Token: 0x0600E87C RID: 59516 RVA: 0x003E49C0 File Offset: 0x003E2BC0
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600E87D RID: 59517 RVA: 0x003E49D0 File Offset: 0x003E2BD0
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x0600E87E RID: 59518 RVA: 0x003E49E0 File Offset: 0x003E2BE0
			public bool IsNeedLoadStaticRes()
			{
				return this.m_owner.IsNeedLoadStaticRes();
			}

			// Token: 0x0600E87F RID: 59519 RVA: 0x003E49F0 File Offset: 0x003E2BF0
			public List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
			{
				return this.m_owner.CollectAllStaticResDescForLoad();
			}

			// Token: 0x0600E880 RID: 59520 RVA: 0x003E4A00 File Offset: 0x003E2C00
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600E881 RID: 59521 RVA: 0x003E4A10 File Offset: 0x003E2C10
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600E882 RID: 59522 RVA: 0x003E4A20 File Offset: 0x003E2C20
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x0600E883 RID: 59523 RVA: 0x003E4A30 File Offset: 0x003E2C30
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600E884 RID: 59524 RVA: 0x003E4A40 File Offset: 0x003E2C40
			public void PushAndPopLayerByState()
			{
				this.m_owner.PushAndPopLayerByState();
			}

			// Token: 0x0600E885 RID: 59525 RVA: 0x003E4A50 File Offset: 0x003E2C50
			public void FettersUIController_OnReturn()
			{
				this.m_owner.FettersUIController_OnReturn();
			}

			// Token: 0x0600E886 RID: 59526 RVA: 0x003E4A60 File Offset: 0x003E2C60
			public void FettersUIController_OnShowHelp()
			{
				this.m_owner.FettersUIController_OnShowHelp();
			}

			// Token: 0x0600E887 RID: 59527 RVA: 0x003E4A70 File Offset: 0x003E2C70
			public void FettersUIController_OnListItemClick(Hero hero)
			{
				this.m_owner.FettersUIController_OnListItemClick(hero);
			}

			// Token: 0x0600E888 RID: 59528 RVA: 0x003E4A80 File Offset: 0x003E2C80
			public void FettersUIController_OnInformationButtonClick(Hero hero)
			{
				this.m_owner.FettersUIController_OnInformationButtonClick(hero);
			}

			// Token: 0x0600E889 RID: 59529 RVA: 0x003E4A90 File Offset: 0x003E2C90
			public void FettersUIController_OnFettersButtonClick(Hero hero)
			{
				this.m_owner.FettersUIController_OnFettersButtonClick(hero);
			}

			// Token: 0x0600E88A RID: 59530 RVA: 0x003E4AA0 File Offset: 0x003E2CA0
			public void FettersFavorabilityUIController_OnReturn()
			{
				this.m_owner.FettersFavorabilityUIController_OnReturn();
			}

			// Token: 0x0600E88B RID: 59531 RVA: 0x003E4AB0 File Offset: 0x003E2CB0
			public void FettersFavorabilityUIController_OnShowHelp()
			{
				this.m_owner.FettersFavorabilityUIController_OnShowHelp();
			}

			// Token: 0x0600E88C RID: 59532 RVA: 0x003E4AC0 File Offset: 0x003E2CC0
			public void FettersFavorabilityUIController_OnInformationButtonClick(Hero hero)
			{
				this.m_owner.FettersFavorabilityUIController_OnInformationButtonClick(hero);
			}

			// Token: 0x0600E88D RID: 59533 RVA: 0x003E4AD0 File Offset: 0x003E2CD0
			public void FettersFavorabilityUIController_OnGiftButtonClick(Hero hero)
			{
				this.m_owner.FettersFavorabilityUIController_OnGiftButtonClick(hero);
			}

			// Token: 0x0600E88E RID: 59534 RVA: 0x003E4AE0 File Offset: 0x003E2CE0
			public void FettersFavorabilityUIController_OnUseGift(GoodsType goodsType, int itemId, int count, Action<List<Goods>> Onsucceed)
			{
				this.m_owner.FettersFavorabilityUIController_OnUseGift(goodsType, itemId, count, Onsucceed);
			}

			// Token: 0x0600E88F RID: 59535 RVA: 0x003E4AF4 File Offset: 0x003E2CF4
			public void FettersFavorabilityUIController_GotoBagFullUITask()
			{
				this.m_owner.FettersFavorabilityUIController_GotoBagFullUITask();
			}

			// Token: 0x0600E890 RID: 59536 RVA: 0x003E4B04 File Offset: 0x003E2D04
			public void FettersFavorabilityUIController_OnHeroInteract()
			{
				this.m_owner.FettersFavorabilityUIController_OnHeroInteract();
			}

			// Token: 0x0600E891 RID: 59537 RVA: 0x003E4B14 File Offset: 0x003E2D14
			public void FettersFavorabilityUIController_OnMemoryButtonClick(Hero hero)
			{
				this.m_owner.FettersFavorabilityUIController_OnMemoryButtonClick(hero);
			}

			// Token: 0x0600E892 RID: 59538 RVA: 0x003E4B24 File Offset: 0x003E2D24
			public void FettersFavorabilityUIController_OnFettersButtonClick(Hero hero)
			{
				this.m_owner.FettersFavorabilityUIController_OnFettersButtonClick(hero);
			}

			// Token: 0x0600E893 RID: 59539 RVA: 0x003E4B34 File Offset: 0x003E2D34
			public void FettersInformationUIController_OnReturn()
			{
				this.m_owner.FettersInformationUIController_OnReturn();
			}

			// Token: 0x0600E894 RID: 59540 RVA: 0x003E4B44 File Offset: 0x003E2D44
			public void FettersInformationUIController_OnVoiceItemClick(int heroPerformanceId)
			{
				this.m_owner.FettersInformationUIController_OnVoiceItemClick(heroPerformanceId);
			}

			// Token: 0x0600E895 RID: 59541 RVA: 0x003E4B54 File Offset: 0x003E2D54
			public void FettersGiftUIController_OnReturn()
			{
				this.m_owner.FettersGiftUIController_OnReturn();
			}

			// Token: 0x0600E896 RID: 59542 RVA: 0x003E4B64 File Offset: 0x003E2D64
			public void FettersConfessionUIController_OnReturn()
			{
				this.m_owner.FettersConfessionUIController_OnReturn();
			}

			// Token: 0x0600E897 RID: 59543 RVA: 0x003E4B74 File Offset: 0x003E2D74
			public void FettersConfessionUIControlle_OnShowHelp()
			{
				this.m_owner.FettersConfessionUIControlle_OnShowHelp();
			}

			// Token: 0x0600E898 RID: 59544 RVA: 0x003E4B84 File Offset: 0x003E2D84
			public void FettersConfessionUIController_OnAddGold()
			{
				this.m_owner.FettersConfessionUIController_OnAddGold();
			}

			// Token: 0x0600E899 RID: 59545 RVA: 0x003E4B94 File Offset: 0x003E2D94
			public void FettersConfessionUIController_OnAddCrystal()
			{
				this.m_owner.FettersConfessionUIController_OnAddCrystal();
			}

			// Token: 0x0600E89A RID: 59546 RVA: 0x003E4BA4 File Offset: 0x003E2DA4
			public void FettersConfessionUIController_OnSkillUnlockButtonClick(int heroId, int fetterId, Action<List<Goods>> OnSucceed)
			{
				this.m_owner.FettersConfessionUIController_OnSkillUnlockButtonClick(heroId, fetterId, OnSucceed);
			}

			// Token: 0x0600E89B RID: 59547 RVA: 0x003E4BB4 File Offset: 0x003E2DB4
			public void FettersConfessionUIController_OnEvolutionButtonClick(int heroId, int fetterId, Action OnSucceed)
			{
				this.m_owner.FettersConfessionUIController_OnEvolutionButtonClick(heroId, fetterId, OnSucceed);
			}

			// Token: 0x0600E89C RID: 59548 RVA: 0x003E4BC4 File Offset: 0x003E2DC4
			public void FettersConfessionUIController_OnHeroFetterConfess(int heroId)
			{
				this.m_owner.FettersConfessionUIController_OnHeroFetterConfess(heroId);
			}

			// Token: 0x0600E89D RID: 59549 RVA: 0x003E4BD4 File Offset: 0x003E2DD4
			public void FettersConfessionUIController_OnEvolutionMaterialClick(GoodsType goodsType, int goodsId, int needCount)
			{
				this.m_owner.FettersConfessionUIController_OnEvolutionMaterialClick(goodsType, goodsId, needCount);
			}

			// Token: 0x0600E89E RID: 59550 RVA: 0x003E4BE4 File Offset: 0x003E2DE4
			public void FettersConfessionUIController_OnGotoGetPath(GetPathData getPath, NeedGoods needGoods)
			{
				this.m_owner.FettersConfessionUIController_OnGotoGetPath(getPath, needGoods);
			}

			// Token: 0x0600E89F RID: 59551 RVA: 0x003E4BF4 File Offset: 0x003E2DF4
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0600E8A0 RID: 59552 RVA: 0x003E4C04 File Offset: 0x003E2E04
			public void UpdateTouchTimeText()
			{
				this.m_owner.UpdateTouchTimeText();
			}

			// Token: 0x04008BC9 RID: 35785
			private FettersUITask m_owner;
		}
	}
}
