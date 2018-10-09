using System;
using System.Collections.Generic;
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
	// Token: 0x02000DD7 RID: 3543
	[HotFix]
	public class HeroListUITask : UITask
	{
		// Token: 0x06010FE1 RID: 69601 RVA: 0x00465C88 File Offset: 0x00463E88
		public HeroListUITask(string name) : base(name)
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

		// Token: 0x06010FE2 RID: 69602 RVA: 0x00466180 File Offset: 0x00464380
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
			this.GetUIStateFromIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x06010FE3 RID: 69603 RVA: 0x0046620C File Offset: 0x0046440C
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
			if (this.m_heroJobTransferUITask != null)
			{
				this.m_heroJobTransferUITask.Stop();
				this.m_heroJobTransferUITask = null;
			}
			if (this.m_heroCharChangeTask != null)
			{
				this.m_heroCharChangeTask.Stop();
				this.m_heroCharChangeTask = null;
			}
			if (this.m_storeSoldierSkinDetailUITask != null)
			{
				this.m_storeSoldierSkinDetailUITask.Stop();
				this.m_storeSoldierSkinDetailUITask = null;
			}
			base.OnStop();
		}

		// Token: 0x06010FE4 RID: 69604 RVA: 0x004662D0 File Offset: 0x004644D0
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
			bool structParam = uiintentReturnable.GetStructParam<bool>("IsInitState");
			uiintentReturnable.SetParam("IsInitState", structParam);
			uiintentReturnable.SetParam("CurMode", this.m_curMode);
			uiintentReturnable.SetParam("LastMode", this.m_lastMode);
			uiintentReturnable.SetParam("IsDetailOpen", this.m_isDetailLayerOpen);
			uiintentReturnable.SetParam("CurHeroPos", this.m_curHeroPos);
			if (this.m_curHeroList.Count > this.m_curHeroPos)
			{
				uiintentReturnable.SetParam("LastHeroId", this.m_curHeroList[this.m_curHeroPos].HeroId);
			}
			else
			{
				uiintentReturnable.SetParam("LastHeroId", 0);
			}
		}

		// Token: 0x06010FE5 RID: 69605 RVA: 0x00466400 File Offset: 0x00464600
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
			this.m_isDetailLayerOpen = uiintentReturnable.GetStructParam<bool>("IsDetailOpen");
			this.m_curHeroPos = uiintentReturnable.GetStructParam<int>("CurHeroPos");
			this.m_lastHeroId = uiintentReturnable.GetStructParam<int>("LastHeroId");
			object obj;
			uiintentReturnable.TryGetParam("CurMode", out obj);
			object obj2;
			uiintentReturnable.TryGetParam("LastMode", out obj2);
			this.m_curMode = (string)obj;
			if (this.m_curMode == null)
			{
				this.m_curMode = "List";
			}
			this.m_lastMode = (string)obj2;
		}

		// Token: 0x06010FE6 RID: 69606 RVA: 0x004664FC File Offset: 0x004646FC
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
			this.UpdataHeroListData();
			this.UpdateHeroCardData();
			this.UpdateCurrentHeroData();
			if (this.m_curMode == "DetailSoldier")
			{
				this.UpdateSoldierModeData();
			}
			if (this.m_curMode == "DetailJob")
			{
				this.UpdateJobModeData();
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06010FE7 RID: 69607 RVA: 0x004665E8 File Offset: 0x004647E8
		private void UpdataHeroListData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdataHeroListData_hotfix != null)
			{
				this.m_UpdataHeroListData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curMode == "List" || this.m_curHeroList.Count == 0)
			{
				this.m_curHeroSortType = (HeroListUIController.HeroSortType)LocalConfig.Instance.Data.HeroListSortType;
				this.m_unlockedList.Clear();
				this.m_unlockedList.AddRange(this.m_playerContext.GetHeros());
				this.m_unlockedList.Sort(new Comparison<Hero>(this.HeroListItemCompare));
				this.m_lockedList.Clear();
				List<Hero> list = new List<Hero>();
				List<Hero> list2 = new List<Hero>();
				Dictionary<int, Hero>.ValueCollection values = this.m_playerContext.GetAllDefaultHeros().Values;
				using (Dictionary<int, Hero>.ValueCollection.Enumerator enumerator = values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Hero item = enumerator.Current;
						if (this.m_unlockedList.Find((Hero h) => h.HeroId == item.HeroId) == null)
						{
							if (item.HeroInfo.FragmentItem_ID != 0)
							{
								int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, item.HeroInfo.FragmentItem_ID);
								if (bagItemCountByType != 0)
								{
									if (bagItemCountByType >= this.m_configDataLoader.GetConfigDataHeroStarInfo(item.StarLevel).Fragment)
									{
										list.Add(item);
									}
									else
									{
										list2.Add(item);
									}
								}
							}
						}
					}
				}
				list.Sort(new Comparison<Hero>(this.HeroListItemCompare));
				list2.Sort(new Comparison<Hero>(this.HeroListItemCompare));
				this.m_lockedList.AddRange(list);
				this.m_lockedList.AddRange(list2);
				this.m_curHeroList.Clear();
				if (this.m_lastHeroId != 0)
				{
					if (this.m_unlockedList.Contains(this.m_playerContext.GetHero(this.m_lastHeroId)))
					{
						this.m_curHeroList.AddRange(this.m_unlockedList);
						this.m_isUnlockHero = true;
					}
					else
					{
						this.m_curHeroList.AddRange(this.m_lockedList);
						this.m_isUnlockHero = false;
					}
				}
				else
				{
					this.m_curHeroList.AddRange(this.m_unlockedList);
					this.m_isUnlockHero = true;
				}
				if (this.m_lastHeroId != 0)
				{
					for (int i = 0; i < this.m_curHeroList.Count; i++)
					{
						if (this.m_lastHeroId == this.m_curHeroList[i].HeroId)
						{
							this.m_curHeroPos = i;
							break;
						}
					}
				}
				else
				{
					this.m_curHeroPos = 0;
					if (this.m_curHeroList.Count > this.m_curHeroPos)
					{
						this.m_lastHeroId = this.m_curHeroList[this.m_curHeroPos].HeroId;
					}
					else
					{
						this.m_lastHeroId = 0;
					}
				}
			}
		}

		// Token: 0x06010FE8 RID: 69608 RVA: 0x00466938 File Offset: 0x00464B38
		private void UpdateHeroCardData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHeroCardData_hotfix != null)
			{
				this.m_UpdateHeroCardData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unlockedList.Count > 0)
			{
				foreach (Hero hero in this.m_unlockedList)
				{
					ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
					if (charImageInfo != null)
					{
						base.CollectAsset(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
						base.CollectAsset(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_1"));
					}
				}
			}
			if (this.m_lockedList.Count > 0)
			{
				foreach (Hero hero2 in this.m_lockedList)
				{
					ConfigDataCharImageInfo charImageInfo2 = hero2.HeroInfo.GetCharImageInfo(hero2.StarLevel);
					if (charImageInfo2 != null)
					{
						base.CollectAsset(AssetUtility.MakeSpriteAssetName(charImageInfo2.CardHeadImage, "_0"));
						base.CollectAsset(AssetUtility.MakeSpriteAssetName(charImageInfo2.CardHeadImage, "_1"));
					}
				}
			}
		}

		// Token: 0x06010FE9 RID: 69609 RVA: 0x00466AD4 File Offset: 0x00464CD4
		private void UpdateCurrentHeroData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateCurrentHeroData_hotfix != null)
			{
				this.m_UpdateCurrentHeroData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curHeroList.Count > this.m_curHeroPos)
			{
				Hero hero = this.m_curHeroList[this.m_curHeroPos];
				string heroCharAssetPath = UIUtility.GetHeroCharAssetPath(hero);
				if (!string.IsNullOrEmpty(heroCharAssetPath))
				{
					base.CollectAsset(heroCharAssetPath);
				}
				else
				{
					ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
					if (charImageInfo != null)
					{
						base.CollectSpriteAsset(charImageInfo.Image);
					}
				}
				base.CollectAsset(UIUtility.GetHeroModelAssetPath(hero));
				List<int> list = new List<int>(hero.HeroInfo.m_heroTagIds);
				foreach (int key in list)
				{
					ConfigDataHeroTagInfo configDataHeroTagInfo = this.m_configDataLoader.GetConfigDataHeroTagInfo(key);
					base.CollectSpriteAsset(configDataHeroTagInfo.Icon);
				}
			}
		}

		// Token: 0x06010FEA RID: 69610 RVA: 0x00466C1C File Offset: 0x00464E1C
		private void UpdateSoldierModeData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSoldierModeData_hotfix != null)
			{
				this.m_UpdateSoldierModeData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_curHeroList[this.m_curHeroPos];
			string soldierModelAssetPath = UIUtility.GetSoldierModelAssetPath(hero, hero.HeroInfo.m_soldierInfo.ID);
			base.CollectAsset(soldierModelAssetPath);
			ConfigDataJobLevelInfo[] jobLevelInfos = hero.HeroInfo.m_jobConnectionInfo.m_jobLevelInfos;
			foreach (ConfigDataJobLevelInfo configDataJobLevelInfo in jobLevelInfos)
			{
				if (configDataJobLevelInfo.m_gotSoldierInfo != null)
				{
					string soldierModelAssetPath2 = UIUtility.GetSoldierModelAssetPath(hero, configDataJobLevelInfo.m_gotSoldierInfo.ID);
					base.CollectAsset(soldierModelAssetPath2);
				}
			}
			foreach (int key in this.m_playerContext.GetUseableJobConnectionInfos(hero.HeroId))
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(key);
				foreach (ConfigDataJobLevelInfo configDataJobLevelInfo2 in configDataJobConnectionInfo.m_jobLevelInfos)
				{
					if (configDataJobLevelInfo2.m_gotSoldierInfo != null)
					{
						string soldierModelAssetPath3 = UIUtility.GetSoldierModelAssetPath(hero, configDataJobLevelInfo2.m_gotSoldierInfo.ID);
						base.CollectAsset(soldierModelAssetPath3);
					}
				}
			}
			foreach (int soldierId in hero.HeroInfo.TechCanLearnSoldiers_ID)
			{
				string soldierModelAssetPath4 = UIUtility.GetSoldierModelAssetPath(hero, soldierId);
				base.CollectAsset(soldierModelAssetPath4);
			}
		}

		// Token: 0x06010FEB RID: 69611 RVA: 0x00466E18 File Offset: 0x00465018
		private void UpdateJobModeData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateJobModeData_hotfix != null)
			{
				this.m_UpdateJobModeData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_curHeroList[this.m_curHeroPos];
			ConfigDataJobConnectionInfo jobConnectionInfo = hero.GetActiveJob().JobConnectionInfo;
			foreach (ConfigDataJobLevelInfo configDataJobLevelInfo in jobConnectionInfo.m_jobLevelInfos)
			{
				if (configDataJobLevelInfo.m_gotSoldierInfo != null)
				{
					string soldierModelAssetPath = UIUtility.GetSoldierModelAssetPath(hero, configDataJobLevelInfo.m_gotSoldierInfo.ID);
					base.CollectAsset(soldierModelAssetPath);
				}
			}
		}

		// Token: 0x06010FEC RID: 69612 RVA: 0x00466EE0 File Offset: 0x004650E0
		private int HeroListItemCompare(Hero h1, Hero h2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListItemCompareHeroHero_hotfix != null)
			{
				return Convert.ToInt32(this.m_HeroListItemCompareHeroHero_hotfix.call(new object[]
				{
					this,
					h1,
					h2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = h2.Level - h1.Level;
			int num2 = h2.HeroInfo.GetRank(h2.StarLevel) - h1.HeroInfo.GetRank(h1.StarLevel);
			int num3 = h2.StarLevel - h1.StarLevel;
			int num4 = h2.BattlePower - h1.BattlePower;
			switch (this.m_curHeroSortType)
			{
			case HeroListUIController.HeroSortType.Level:
				if (num != 0)
				{
					return num;
				}
				if (num3 != 0)
				{
					return num3;
				}
				if (num2 != 0)
				{
					return num2;
				}
				if (num4 != 0)
				{
					return num4;
				}
				break;
			case HeroListUIController.HeroSortType.StarLevel:
				if (num3 != 0)
				{
					return num3;
				}
				if (num != 0)
				{
					return num;
				}
				if (num2 != 0)
				{
					return num2;
				}
				if (num4 != 0)
				{
					return num4;
				}
				break;
			case HeroListUIController.HeroSortType.Rank:
				if (num2 != 0)
				{
					return num2;
				}
				if (num != 0)
				{
					return num;
				}
				if (num3 != 0)
				{
					return num3;
				}
				if (num4 != 0)
				{
					return num4;
				}
				break;
			case HeroListUIController.HeroSortType.Power:
				if (num4 != 0)
				{
					return num4;
				}
				if (num != 0)
				{
					return num;
				}
				if (num3 != 0)
				{
					return num3;
				}
				if (num2 != 0)
				{
					return num2;
				}
				break;
			}
			return h1.HeroId - h2.HeroId;
		}

		// Token: 0x06010FED RID: 69613 RVA: 0x00467084 File Offset: 0x00465284
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
			if (this.m_curMode == "List")
			{
				return base.IsNeedLoadStaticRes();
			}
			if (this.m_heroListUIController == null)
			{
				return true;
			}
			if (this.m_curMode == "DetailInfo")
			{
				if (this.m_heroDetailInfoUIController == null)
				{
					return true;
				}
			}
			else if (this.m_curMode == "DetailJob")
			{
				if (this.m_heroDetailJobUIController == null)
				{
					return true;
				}
			}
			else if (this.m_curMode == "DetailSoldier")
			{
				if (this.m_heroDetailSoldierUIController == null)
				{
					return true;
				}
			}
			else if (this.m_curMode == "DetailEquipment")
			{
				if (this.m_heroDetailEquipmentUIController == null)
				{
					return true;
				}
			}
			else if (this.m_curMode == "DetailLife")
			{
				if (this.m_heroDetailLifeUIController == null)
				{
					return true;
				}
			}
			else if (this.m_curMode == "DetailSelectSkill")
			{
				if (this.m_heroDetailSelectSkillUIController == null)
				{
					return true;
				}
			}
			else if (this.m_curMode == "DetailAddExp" && this.m_heroDetailAddExpUIController == null)
			{
				return true;
			}
			return false;
		}

		// Token: 0x06010FEE RID: 69614 RVA: 0x00467258 File Offset: 0x00465458
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
			if (this.m_curMode == "List")
			{
				return base.CollectAllStaticResDescForLoad();
			}
			list.Add(this.CreateLayerDescByIndex(0));
			list.Add(this.CreateLayerDescByIndex(1));
			if (this.m_curMode == "DetailInfo")
			{
				list.Add(this.CreateLayerDescByIndex(2));
				return list;
			}
			if (this.m_curMode == "DetailJob")
			{
				list.Add(this.CreateLayerDescByIndex(3));
				return list;
			}
			if (this.m_curMode == "DetailSoldier")
			{
				list.Add(this.CreateLayerDescByIndex(4));
				return list;
			}
			if (this.m_curMode == "DetailEquipment")
			{
				list.Add(this.CreateLayerDescByIndex(5));
				return list;
			}
			if (this.m_curMode == "DetailLife")
			{
				list.Add(this.CreateLayerDescByIndex(6));
				return list;
			}
			if (this.m_curMode == "DetailSelectSkill")
			{
				list.Add(this.CreateLayerDescByIndex(7));
				return list;
			}
			if (this.m_curMode == "DetailAddExp")
			{
				list.Add(this.CreateLayerDescByIndex(8));
				return list;
			}
			return base.CollectAllStaticResDescForLoad();
		}

		// Token: 0x06010FEF RID: 69615 RVA: 0x00467404 File Offset: 0x00465604
		private UITaskBase.LayerDesc CreateLayerDescByIndex(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateLayerDescByIndexInt32_hotfix != null)
			{
				return (UITaskBase.LayerDesc)this.m_CreateLayerDescByIndexInt32_hotfix.call(new object[]
				{
					this,
					index
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new UITaskBase.LayerDesc
			{
				m_layerName = this.LayerDescArray[index].m_layerName,
				m_layerResPath = this.LayerDescArray[index].m_layerResPath,
				m_isUILayer = this.LayerDescArray[index].m_isUILayer,
				m_index = this.LayerDescArray[index].m_index
			};
		}

		// Token: 0x06010FF0 RID: 69616 RVA: 0x004674D4 File Offset: 0x004656D4
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
			if (this.m_heroListUIController == null)
			{
				this.m_heroListUIController = (this.m_uiCtrlArray[0] as HeroListUIController);
				this.m_heroListUIController.EventOnReturn += this.HeroListUIController_OnReturn;
				this.m_heroListUIController.EventOnDetail += this.HeroListUIController_OnDetail;
				this.m_heroListUIController.EventOnAddHero += this.HeroListUIController_OnAddHero;
				this.m_heroListUIController.EventOnUpdateViewInListAndDetail += this.UpdateViewOnHeroChanged;
				this.m_heroListUIController.EventOnInitHeroList += this.HeroListUIController_SetHeroList;
				this.m_heroListUIController.EventOnComposeHero += this.HeroListUIController_OnHeroCompose;
				this.m_heroListUIController.EventOnComment += this.HeroListUIController_OnComment;
				this.m_heroListUIController.EventOnHeroBreak += this.HeroListUIController_OnHeroBreak;
				this.m_heroListUIController.EventOnShowGetPath += this.Hero_OnShowGetPath;
				this.m_heroListUIController.EventOnEquipment += this.HeroListUIController_OnGotoEquipmentTab;
				this.m_heroListUIController.EventOnJob += this.HeroListUIController_OnGotoJobTab;
				this.m_heroListUIController.EventOnSortToggleClick += this.HeroListUIController_OnSortToggleClick;
				this.m_heroListUIController.EventOnHeroCharSkinChangeButtonClick += this.HeroListUIController_OnHeroCharSkinChangeButtonClick;
				this.m_heroListUIController.EventOnHeroCharClick += this.HeroListUIController_OnHeroCharClick;
				this.m_heroListUIController.EventOnGoToMemoryExtractionStore += this.HeroListUIController_OnGoToMemoryExtractionStore;
			}
			if (this.m_curMode != "List" && this.m_heroDetailUIController == null)
			{
				this.m_heroDetailUIController = (this.m_uiCtrlArray[1] as HeroDetailUIController);
				this.m_heroDetailUIController.EventOnReturn += this.HeroDetailUIController_OnReturn;
				this.m_heroDetailUIController.EventOnJobTransfer += this.HeroDetailUIController_OnJobTransfer;
				this.m_heroDetailUIController.EventOnUpdateViewInListAndDetail += this.UpdateViewOnHeroChanged;
				this.m_heroDetailUIController.EventOnSetDetailState += this.HeroDetailUIController_OnSetDetailState;
			}
			if (this.m_curMode == "DetailInfo" && this.m_heroDetailInfoUIController == null)
			{
				this.m_heroDetailInfoUIController = (this.m_uiCtrlArray[2] as HeroDetailInfoUIController);
				this.m_heroDetailInfoUIController.EventOnSetDetailState += this.HeroDetailUIController_OnSetDetailState;
				this.m_heroDetailInfoUIController.EventOnSkinInfoButtonClick += this.HeroDetailInfoUIController_OnSkinInfoButtonClick;
				this.m_heroDetailInfoUIController.EventOnJobUpButtonClick += this.HeroDetailInfoUIController_OnJobUpButtonClick;
			}
			if (this.m_curMode == "DetailJob" && this.m_heroDetailJobUIController == null)
			{
				this.m_heroDetailJobUIController = (this.m_uiCtrlArray[3] as HeroDetailJobUIController);
				this.m_heroDetailJobUIController.EventOnJobLvUpgrade += this.HeroDetailJobUIController_OnJobLvUpgrade;
				this.m_heroDetailJobUIController.EventOnShowGetPath += this.Hero_OnShowGetPath;
				this.m_heroDetailJobUIController.EventOnUpdateView += this.StartUpdatePiplineInHeroListTask;
			}
			if (this.m_curMode == "DetailSoldier" && this.m_heroDetailSoldierUIController == null)
			{
				this.m_heroDetailSoldierUIController = (this.m_uiCtrlArray[4] as HeroDetailSoldierUIController);
				this.m_heroDetailSoldierUIController.EventOnSoldierAttackButtonClick += this.HeroDetailSoldierUIController_OnHeroSoldierSelect;
				this.m_heroDetailSoldierUIController.EventOnGotoDrill += this.HeroDetailSoldierUIController_OnGotoDrill;
				this.m_heroDetailSoldierUIController.EventOnGotoJobTransfer += this.HeroDetailSoldierUIController_OnGotoJobTransfer;
				this.m_heroDetailSoldierUIController.EventOnSkinInfoButtonClick += this.HeroDetailSoldierUIController_OnSkinInfoButtonClick;
			}
			if (this.m_curMode == "DetailEquipment" && this.m_heroDetailEquipmentUIController == null)
			{
				this.m_heroDetailEquipmentUIController = (this.m_uiCtrlArray[5] as HeroDetailEquipmentUIController);
				this.m_heroDetailEquipmentUIController.EventOnGotoEquipmentStore += this.HeroDetailEquipmentUIController_OnGotoEquipmentDepot;
				this.m_heroDetailEquipmentUIController.EventOnLockButtonClick += this.HeroDetailEquipmentUIController_OnLockButtonClick;
				this.m_heroDetailEquipmentUIController.EventOnGotoEquipmentForge += this.HeroDetailEquipmentUIController_OnGotoEquipmentForge;
				this.m_heroDetailEquipmentUIController.EventOnAutoEquip += this.HeroDetailEquipmentUIController_OnAutoEquip;
				this.m_heroDetailEquipmentUIController.EventOnAutoRemove += this.HeroDetailEquipmentUIController_OnAutoRemove;
			}
			if (this.m_curMode == "DetailLife" && this.m_heroDetailLifeUIController == null)
			{
				this.m_heroDetailLifeUIController = (this.m_uiCtrlArray[6] as HeroDetailLifeUIController);
				this.m_heroDetailLifeUIController.EventOnVoiceItemClick += this.HeroDetailLifeUIController_OnVoiceItemClick;
			}
			if (this.m_curMode == "DetailSelectSkill" && this.m_heroDetailSelectSkillUIController == null)
			{
				this.m_heroDetailSelectSkillUIController = (this.m_uiCtrlArray[7] as HeroDetailSelectSkillUIController);
				this.m_heroDetailSelectSkillUIController.EventOnHeroSkillsSelect += this.HeroDetailSelectSkillUIController_OnHeroSkillsSelect;
			}
			if (this.m_curMode == "DetailAddExp" && this.m_heroDetailAddExpUIController == null)
			{
				this.m_heroDetailAddExpUIController = (this.m_uiCtrlArray[8] as HeroDetailAddExpUIController);
				this.m_heroDetailAddExpUIController.EventOnReturn += this.HeroDetailAddExpUIController_OnReturn;
				this.m_heroDetailAddExpUIController.EventOnHeroAddExp += this.HeroDetailAddExpUIController_OnHeroAddExp;
			}
		}

		// Token: 0x06010FF1 RID: 69617 RVA: 0x00467A90 File Offset: 0x00465C90
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
			if (this.m_heroListUIController != null)
			{
				this.m_heroListUIController.EventOnReturn -= this.HeroListUIController_OnReturn;
				this.m_heroListUIController.EventOnDetail -= this.HeroListUIController_OnDetail;
				this.m_heroListUIController.EventOnAddHero -= this.HeroListUIController_OnAddHero;
				this.m_heroListUIController.EventOnUpdateViewInListAndDetail -= this.UpdateViewOnHeroChanged;
				this.m_heroListUIController.EventOnInitHeroList -= this.HeroListUIController_SetHeroList;
				this.m_heroListUIController.EventOnComposeHero -= this.HeroListUIController_OnHeroCompose;
				this.m_heroListUIController.EventOnComment -= this.HeroListUIController_OnComment;
				this.m_heroListUIController.EventOnHeroBreak -= this.HeroListUIController_OnHeroBreak;
				this.m_heroListUIController.EventOnShowGetPath -= this.Hero_OnShowGetPath;
				this.m_heroListUIController.EventOnEquipment -= this.HeroListUIController_OnGotoEquipmentTab;
				this.m_heroListUIController.EventOnJob -= this.HeroListUIController_OnGotoJobTab;
				this.m_heroListUIController.EventOnSortToggleClick -= this.HeroListUIController_OnSortToggleClick;
				this.m_heroListUIController.EventOnHeroCharSkinChangeButtonClick -= this.HeroListUIController_OnHeroCharSkinChangeButtonClick;
				this.m_heroListUIController.EventOnHeroCharClick -= this.HeroListUIController_OnHeroCharClick;
				this.m_heroListUIController.EventOnGoToMemoryExtractionStore -= this.HeroListUIController_OnGoToMemoryExtractionStore;
				this.m_heroListUIController = null;
			}
			if (this.m_heroDetailUIController != null)
			{
				this.m_heroDetailUIController.EventOnReturn -= this.HeroDetailUIController_OnReturn;
				this.m_heroDetailUIController.EventOnJobTransfer -= this.HeroDetailUIController_OnJobTransfer;
				this.m_heroDetailUIController.EventOnUpdateViewInListAndDetail -= this.UpdateViewOnHeroChanged;
				this.m_heroDetailUIController.EventOnSetDetailState -= this.HeroDetailUIController_OnSetDetailState;
				this.m_heroDetailUIController = null;
			}
			if (this.m_heroDetailInfoUIController != null)
			{
				this.m_heroDetailInfoUIController.EventOnSetDetailState -= this.HeroDetailUIController_OnSetDetailState;
				this.m_heroDetailInfoUIController.EventOnSkinInfoButtonClick -= this.HeroDetailInfoUIController_OnSkinInfoButtonClick;
				this.m_heroDetailInfoUIController.EventOnJobUpButtonClick -= this.HeroDetailInfoUIController_OnJobUpButtonClick;
				this.m_heroDetailInfoUIController = null;
			}
			if (this.m_heroDetailJobUIController != null)
			{
				this.m_heroDetailJobUIController.EventOnJobLvUpgrade -= this.HeroDetailJobUIController_OnJobLvUpgrade;
				this.m_heroDetailJobUIController.EventOnShowGetPath -= this.Hero_OnShowGetPath;
				this.m_heroDetailJobUIController.EventOnUpdateView -= this.StartUpdatePiplineInHeroListTask;
				this.m_heroDetailJobUIController = null;
			}
			if (this.m_heroDetailSoldierUIController != null)
			{
				this.m_heroDetailSoldierUIController.EventOnSoldierAttackButtonClick -= this.HeroDetailSoldierUIController_OnHeroSoldierSelect;
				this.m_heroDetailSoldierUIController.EventOnGotoDrill -= this.HeroDetailSoldierUIController_OnGotoDrill;
				this.m_heroDetailSoldierUIController.EventOnGotoJobTransfer -= this.HeroDetailSoldierUIController_OnGotoJobTransfer;
				this.m_heroDetailSoldierUIController.EventOnSkinInfoButtonClick -= this.HeroDetailSoldierUIController_OnSkinInfoButtonClick;
				this.m_heroDetailSoldierUIController = null;
			}
			if (this.m_heroDetailEquipmentUIController != null)
			{
				this.m_heroDetailEquipmentUIController.EventOnGotoEquipmentStore -= this.HeroDetailEquipmentUIController_OnGotoEquipmentDepot;
				this.m_heroDetailEquipmentUIController.EventOnLockButtonClick -= this.HeroDetailEquipmentUIController_OnLockButtonClick;
				this.m_heroDetailEquipmentUIController.EventOnAutoEquip -= this.HeroDetailEquipmentUIController_OnAutoEquip;
				this.m_heroDetailEquipmentUIController.EventOnAutoRemove -= this.HeroDetailEquipmentUIController_OnAutoRemove;
				this.m_heroDetailEquipmentUIController = null;
			}
			if (this.m_heroDetailLifeUIController != null)
			{
				this.m_heroDetailLifeUIController.EventOnVoiceItemClick -= this.HeroDetailLifeUIController_OnVoiceItemClick;
				this.m_heroDetailLifeUIController = null;
			}
			if (this.m_heroDetailSelectSkillUIController != null)
			{
				this.m_heroDetailSelectSkillUIController.EventOnHeroSkillsSelect -= this.HeroDetailSelectSkillUIController_OnHeroSkillsSelect;
				this.m_heroDetailSelectSkillUIController = null;
			}
			if (this.m_heroDetailAddExpUIController != null)
			{
				this.m_heroDetailAddExpUIController.EventOnReturn -= this.HeroDetailAddExpUIController_OnReturn;
				this.m_heroDetailAddExpUIController.EventOnHeroAddExp -= this.HeroDetailAddExpUIController_OnHeroAddExp;
				this.m_heroDetailAddExpUIController = null;
			}
		}

		// Token: 0x06010FF2 RID: 69618 RVA: 0x00467F24 File Offset: 0x00466124
		private void UpdateViewOnHeroChanged(int pos, bool isUnlockHero, bool isNeedStopCoroutine, int lastHeroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewOnHeroChangedInt32BooleanBooleanInt32_hotfix != null)
			{
				this.m_UpdateViewOnHeroChangedInt32BooleanBooleanInt32_hotfix.call(new object[]
				{
					this,
					pos,
					isUnlockHero,
					isNeedStopCoroutine,
					lastHeroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curHeroPos = pos;
			this.m_isUnlockHero = isUnlockHero;
			this.m_lastHeroId = lastHeroId;
			if (this.m_heroListUIController != null)
			{
				this.m_heroListUIController.ResetHeroPowerValue();
				if (isNeedStopCoroutine)
				{
					this.m_heroListUIController.StopAllCoroutineInHeroList();
				}
			}
			base.StartUpdatePipeLine(null, false, false, true);
			if (this.m_heroCharChangeTask != null && this.m_heroCharChangeTask.State == Task.TaskState.Running)
			{
				Hero hero = this.m_curHeroList[this.m_curHeroPos];
				int num = 0;
				foreach (int key in hero.HeroInfo.Skins_ID)
				{
					ConfigDataHeroSkinInfo configDataHeroSkinInfo = this.m_configDataLoader.GetConfigDataHeroSkinInfo(key);
					if (this.m_playerContext.IsShowSkinBeforeOnSale(configDataHeroSkinInfo.FixedStoreItemId, true))
					{
						num++;
					}
				}
				if (num > 0)
				{
					this.m_heroDetailInfoUIController.IsShowHeroLittleSpine(false);
					this.m_heroCharChangeTask.ClearUIControllerData();
					string mode = "ShowSkinDetailMode";
					Hero hero2 = hero;
					this.m_heroCharChangeTask = HeroSkinChangeUITask.StartUITask(mode, 0, hero2, this.m_currIntent);
				}
				else
				{
					this.m_heroCharChangeTask.CloseHeroSkinChangePanelWithAnim(delegate
					{
						this.m_heroCharChangeTask.Stop();
						this.m_heroCharChangeTask = null;
					});
				}
			}
		}

		// Token: 0x06010FF3 RID: 69619 RVA: 0x00468118 File Offset: 0x00466318
		private void StartUpdatePiplineInHeroListTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUpdatePiplineInHeroListTask_hotfix != null)
			{
				this.m_StartUpdatePiplineInHeroListTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06010FF4 RID: 69620 RVA: 0x00468184 File Offset: 0x00466384
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

		// Token: 0x06010FF5 RID: 69621 RVA: 0x004681EC File Offset: 0x004663EC
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
			this.PushLayerByCurState();
			if (this.m_curMode == "List")
			{
				this.m_heroListUIController.m_curSelectedHeroIndex = this.m_curHeroPos;
				this.m_heroListUIController.m_isUnLockHero = this.m_isUnlockHero;
				UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
				object obj;
				uiintentReturnable.TryGetParam("IsInitState", out obj);
				if ((bool)obj)
				{
					this.m_heroListUIController.SetToInitState();
					uiintentReturnable.SetParam("IsInitState", false);
				}
				this.m_heroListUIController.UpdateViewInHeroList(true);
				this.m_stateName = "ToRight";
				this.m_heroListUIController.ShowButtonGameObject(true);
				if (base.IsOpeningUI())
				{
					this.m_heroListUIController.Open();
				}
			}
			else
			{
				this.m_heroListUIController.m_curSelectedHeroIndex = (this.m_heroDetailUIController.m_curHeroNum = this.m_curHeroPos);
				this.m_heroListUIController.SetToAtLeftState();
				this.m_heroListUIController.UpdateViewInHeroList(false);
				this.m_heroDetailUIController.UpdateViewInHeroDetail();
				CommonUIStateController component = this.m_heroDetailUIController.gameObject.GetComponent<CommonUIStateController>();
				if (this.m_isDetailLayerOpen)
				{
					if (this.m_lastMode == "DetailAddExp" || this.m_lastMode == "DetailSelectSkill")
					{
						this.m_stateName = "StartState";
					}
					else
					{
						this.m_stateName = "Alpha";
					}
					component.SetToUIState("StartState", false, true);
					UIUtility.SetUIStateOpen(component, "StartState", null, true, true);
				}
				else
				{
					this.m_stateName = "ToLeft";
					UIUtility.SetUIStateOpen(component, this.m_stateName, null, true, true);
				}
				this.m_isDetailLayerOpen = true;
				this.m_heroListUIController.ShowButtonGameObject(false);
			}
			this.m_heroListUIController.SetHeroPowerValue();
			Hero hero = this.m_curHeroList[this.m_curHeroPos];
			if (this.m_curMode == "DetailInfo")
			{
				this.m_heroDetailInfoUIController.UpdateViewInInfoState(hero);
				this.m_heroDetailUIController.SetToggleToInfo();
			}
			else if (this.m_curMode == "DetailJob")
			{
				this.m_heroDetailJobUIController.UpdateViewInJobState(hero);
				this.m_heroDetailUIController.SetToggleToJob();
			}
			else if (this.m_curMode == "DetailSoldier")
			{
				this.m_heroDetailSoldierUIController.UpdateViewInSoldierState(hero);
				this.m_heroDetailUIController.SetToggleToSoldier();
			}
			else if (this.m_curMode == "DetailEquipment")
			{
				this.m_heroDetailEquipmentUIController.UpdateViewInEquipmentState(hero);
				this.m_heroDetailUIController.SetToggleToEquip();
			}
			else if (this.m_curMode == "DetailLife")
			{
				this.m_heroDetailLifeUIController.UpdateViewInLife(hero);
				this.m_heroDetailUIController.SetToggleToLife();
			}
			else if (this.m_curMode == "DetailSelectSkill")
			{
				this.m_heroDetailSelectSkillUIController.UpdateViewInSelectSkillState(hero);
			}
			else if (this.m_curMode == "DetailAddExp")
			{
				this.m_heroDetailAddExpUIController.UpdateViewInAddExpState(hero);
			}
			this.SetTabCommonUIStateByName(this.m_curMode, this.m_stateName);
			this.CheckConflictBetweenLayer(this.m_curLayerDescIndex);
			if (this.m_curMode != "List")
			{
				this.m_lastMode = this.m_curMode;
			}
		}

		// Token: 0x06010FF6 RID: 69622 RVA: 0x00468598 File Offset: 0x00466798
		private void PushLayerByCurState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PushLayerByCurState_hotfix != null)
			{
				this.m_PushLayerByCurState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curMode == "List")
			{
				this.PushLayerByIndex(0);
			}
			else
			{
				for (int i = 0; i <= 1; i++)
				{
					SceneLayerBase sceneLayerBase = this.m_layerArray[i];
					if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
					{
						SceneManager.Instance.PushLayer(sceneLayerBase);
					}
				}
			}
			if (this.m_curMode == "DetailInfo")
			{
				this.PushLayerByIndex(2);
			}
			else if (this.m_curMode == "DetailJob")
			{
				this.PushLayerByIndex(3);
			}
			else if (this.m_curMode == "DetailSoldier")
			{
				this.PushLayerByIndex(4);
			}
			else if (this.m_curMode == "DetailEquipment")
			{
				this.PushLayerByIndex(5);
			}
			else if (this.m_curMode == "DetailLife")
			{
				this.PushLayerByIndex(6);
			}
			else if (this.m_curMode == "DetailSelectSkill")
			{
				this.PushLayerByIndex(7);
			}
			else if (this.m_curMode == "DetailAddExp")
			{
				this.PushLayerByIndex(8);
			}
		}

		// Token: 0x06010FF7 RID: 69623 RVA: 0x00468730 File Offset: 0x00466930
		private void PushLayerByIndex(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PushLayerByIndexInt32_hotfix != null)
			{
				this.m_PushLayerByIndexInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SceneLayerBase sceneLayerBase = this.m_layerArray[index];
			if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
			{
				SceneManager.Instance.PushLayer(sceneLayerBase);
			}
			this.m_curLayerDescIndex = index;
		}

		// Token: 0x06010FF8 RID: 69624 RVA: 0x004687C8 File Offset: 0x004669C8
		private void CheckConflictBetweenLayer(int layerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckConflictBetweenLayerInt32_hotfix != null)
			{
				this.m_CheckConflictBetweenLayerInt32_hotfix.call(new object[]
				{
					this,
					layerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (layerIndex == 0 || (layerIndex >= 2 && layerIndex <= 6))
			{
				for (int i = 2; i <= 6; i++)
				{
					if (layerIndex != i)
					{
						SceneLayerBase sceneLayerBase = this.m_layerArray[i];
						if (sceneLayerBase != null && sceneLayerBase.State == SceneLayerBase.LayerState.InStack)
						{
							SceneManager.Instance.PopLayer(sceneLayerBase);
						}
					}
				}
			}
		}

		// Token: 0x06010FF9 RID: 69625 RVA: 0x00468898 File Offset: 0x00466A98
		private void HeroDetailUIController_OnSetDetailState(string mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailUIController_OnSetDetailStateString_hotfix != null)
			{
				this.m_HeroDetailUIController_OnSetDetailStateString_hotfix.call(new object[]
				{
					this,
					mode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curMode == "List")
			{
				this.m_stateName = "ToLeft";
			}
			else
			{
				this.m_stateName = "Alpha";
			}
			this.m_curMode = mode;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06010FFA RID: 69626 RVA: 0x0046894C File Offset: 0x00466B4C
		private void SetTabCommonUIStateByName(string modeName, string stateName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTabCommonUIStateByNameStringString_hotfix != null)
			{
				this.m_SetTabCommonUIStateByNameStringString_hotfix.call(new object[]
				{
					this,
					modeName,
					stateName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (modeName != null)
			{
				if (!(modeName == "DetailInfo"))
				{
					if (!(modeName == "DetailJob"))
					{
						if (!(modeName == "DetailSoldier"))
						{
							if (!(modeName == "DetailEquipment"))
							{
								if (modeName == "DetailLife")
								{
									this.m_heroDetailLifeUIController.SetCommonUIState(stateName);
								}
							}
							else
							{
								this.m_heroDetailEquipmentUIController.SetCommonUIState(stateName);
							}
						}
						else
						{
							this.m_heroDetailSoldierUIController.SetCommonUIState(stateName);
						}
					}
					else
					{
						this.m_heroDetailJobUIController.SetCommonUIState(stateName);
					}
				}
				else
				{
					this.m_heroDetailInfoUIController.SetCommonUIState(stateName);
				}
			}
		}

		// Token: 0x06010FFB RID: 69627 RVA: 0x00468A84 File Offset: 0x00466C84
		private void HeroListUIController_SetHeroList(List<Hero> unlockedList, List<Hero> lockedList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_SetHeroListList`1List`1_hotfix != null)
			{
				this.m_HeroListUIController_SetHeroListList`1List`1_hotfix.call(new object[]
				{
					this,
					unlockedList,
					lockedList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			unlockedList.Clear();
			unlockedList.AddRange(this.m_unlockedList);
			lockedList.Clear();
			lockedList.AddRange(this.m_lockedList);
			if (this.m_heroDetailUIController != null)
			{
				this.m_heroDetailUIController.PassHeroInfo(unlockedList, this.m_curHeroPos);
			}
		}

		// Token: 0x06010FFC RID: 69628 RVA: 0x00468B4C File Offset: 0x00466D4C
		private void HeroListUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnReturn_hotfix != null)
			{
				this.m_HeroListUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_lastMode = null;
				this.m_curHeroPos = 0;
				this.m_lastHeroId = 0;
				this.m_isUnlockHero = true;
				this.m_curMode = "List";
				this.m_isDetailLayerOpen = false;
				this.m_lockedList.Clear();
				this.m_curHeroList.Clear();
				this.m_unlockedList.Clear();
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06010FFD RID: 69629 RVA: 0x00468BD0 File Offset: 0x00466DD0
		private void HeroListUIController_OnAddHero(string str)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnAddHeroString_hotfix != null)
			{
				this.m_HeroListUIController_OnAddHeroString_hotfix.call(new object[]
				{
					this,
					str
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			if (str == null)
			{
				return;
			}
			string cmd = "ADD_HERO " + str;
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(cmd);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x06010FFE RID: 69630 RVA: 0x00468C80 File Offset: 0x00466E80
		private void HeroListUIController_OnHeroCompose(int heroId, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnHeroComposeInt32Action_hotfix != null)
			{
				this.m_HeroListUIController_OnHeroComposeInt32Action_hotfix.call(new object[]
				{
					this,
					heroId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			HeroComposeNetTask heroComposeNetTask = new HeroComposeNetTask(heroId);
			heroComposeNetTask.EventOnStop += delegate(Task task)
			{
				HeroComposeNetTask heroComposeNetTask2 = task as HeroComposeNetTask;
				if (heroComposeNetTask2.Result == 0)
				{
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroComposeNetTask2.Result, 2f, null, true);
				}
			};
			heroComposeNetTask.Start(null);
		}

		// Token: 0x06010FFF RID: 69631 RVA: 0x00468D30 File Offset: 0x00466F30
		private void HeroDetailLifeUIController_OnVoiceItemClick(int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailLifeUIController_OnVoiceItemClickInt32_hotfix != null)
			{
				this.m_HeroDetailLifeUIController_OnVoiceItemClickInt32_hotfix.call(new object[]
				{
					this,
					heroPerformanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroListUIController.PlayHeroPerformance(heroPerformanceId);
		}

		// Token: 0x06011000 RID: 69632 RVA: 0x00468DAC File Offset: 0x00466FAC
		private void HeroDetailSelectSkillUIController_OnHeroSkillsSelect(int heroId, List<int> skillIds, bool isSkillChanged)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailSelectSkillUIController_OnHeroSkillsSelectInt32List`1Boolean_hotfix != null)
			{
				this.m_HeroDetailSelectSkillUIController_OnHeroSkillsSelectInt32List`1Boolean_hotfix.call(new object[]
				{
					this,
					heroId,
					skillIds,
					isSkillChanged
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!isSkillChanged)
			{
				SceneLayerBase sceneLayerBase = this.m_layerArray[7];
				if (sceneLayerBase.State == SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PopLayer(sceneLayerBase);
				}
				this.m_lastMode = (this.m_curMode = "DetailInfo");
				return;
			}
			HeroSkillsSelectNetTask heroSkillsSelectNetTask = new HeroSkillsSelectNetTask(heroId, skillIds);
			heroSkillsSelectNetTask.EventOnStop += delegate(Task task)
			{
				HeroSkillsSelectNetTask heroSkillsSelectNetTask2 = task as HeroSkillsSelectNetTask;
				if (heroSkillsSelectNetTask2.Result == 0)
				{
					SceneLayerBase sceneLayerBase2 = this.m_layerArray[7];
					if (sceneLayerBase2.State == SceneLayerBase.LayerState.InStack)
					{
						SceneManager.Instance.PopLayer(sceneLayerBase2);
					}
					this.m_curMode = "DetailInfo";
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroSkillsSelectNetTask2.Result, 2f, null, true);
				}
			};
			heroSkillsSelectNetTask.Start(null);
		}

		// Token: 0x06011001 RID: 69633 RVA: 0x00468E9C File Offset: 0x0046709C
		private void HeroDetailSoldierUIController_OnHeroSoldierSelect(int heroId, int soldierId, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailSoldierUIController_OnHeroSoldierSelectInt32Int32Action_hotfix != null)
			{
				this.m_HeroDetailSoldierUIController_OnHeroSoldierSelectInt32Int32Action_hotfix.call(new object[]
				{
					this,
					heroId,
					soldierId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			HeroListUITask $this = this;
			HeroSoldierSelectNetTask heroSoldierSelectNetTask = new HeroSoldierSelectNetTask(heroId, soldierId);
			heroSoldierSelectNetTask.EventOnStop += delegate(Task task)
			{
				HeroSoldierSelectNetTask heroSoldierSelectNetTask2 = task as HeroSoldierSelectNetTask;
				if (heroSoldierSelectNetTask2.Result == 0)
				{
					OnSucceed();
					$this.m_heroListUIController.SetHeroPowerValue();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroSoldierSelectNetTask2.Result, 2f, null, true);
				}
			};
			heroSoldierSelectNetTask.Start(null);
		}

		// Token: 0x06011002 RID: 69634 RVA: 0x00468F64 File Offset: 0x00467164
		private void HeroDetailSoldierUIController_OnGotoDrill(int techId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailSoldierUIController_OnGotoDrillInt32_hotfix != null)
			{
				this.m_HeroDetailSoldierUIController_OnGotoDrillInt32_hotfix.call(new object[]
				{
					this,
					techId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DrillUITask.StartUITask(this.m_currIntent, techId);
		}

		// Token: 0x06011003 RID: 69635 RVA: 0x00468FE0 File Offset: 0x004671E0
		private void HeroDetailSoldierUIController_OnGotoJobTransfer(ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailSoldierUIController_OnGotoJobTransferConfigDataJobConnectionInfo_hotfix != null)
			{
				this.m_HeroDetailSoldierUIController_OnGotoJobTransferConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataJobConnectionInfo jobConnectionInfo = jobConnectionInfo2;
			HeroListUITask $this = this;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable($this.m_currIntent, typeof(HeroJobTransferUITask).Name, null);
				Hero value = $this.m_heroDetailUIController.m_curHeroList[$this.m_heroDetailUIController.m_curHeroNum];
				uiintentReturnable.SetParam("hero", value);
				uiintentReturnable.SetParam("jobConnectionInfo", jobConnectionInfo);
				$this.m_heroJobTransferUITask = (UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action($this.HeroJobTransferUITask_OnLoadAllResCompleted)) as HeroJobTransferUITask);
				$this.m_heroListUIController.m_curSelectedHeroIndex = $this.m_heroDetailUIController.m_curHeroNum;
				$this.CloseHeroCharChangeTask(null);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06011004 RID: 69636 RVA: 0x00469088 File Offset: 0x00467288
		private void HeroDetailJobUIController_OnJobLvUpgrade(int heroId, int jobConnectionId, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailJobUIController_OnJobLvUpgradeInt32Int32Action_hotfix != null)
			{
				this.m_HeroDetailJobUIController_OnJobLvUpgradeInt32Int32Action_hotfix.call(new object[]
				{
					this,
					heroId,
					jobConnectionId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			HeroJobLevelUpNetTask heroJobLevelUpNetTask = new HeroJobLevelUpNetTask(heroId, jobConnectionId);
			heroJobLevelUpNetTask.EventOnStop += delegate(Task task)
			{
				HeroJobLevelUpNetTask heroJobLevelUpNetTask2 = task as HeroJobLevelUpNetTask;
				if (heroJobLevelUpNetTask2.Result == 0)
				{
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroJobLevelUpNetTask2.Result, 2f, null, true);
				}
			};
			heroJobLevelUpNetTask.Start(null);
		}

		// Token: 0x06011005 RID: 69637 RVA: 0x00469148 File Offset: 0x00467348
		private void HeroDetailAddExpUIController_OnHeroAddExp(int heroId, BagItemBase bagItem, int count, Action OnFinished)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailAddExpUIController_OnHeroAddExpInt32BagItemBaseInt32Action_hotfix != null)
			{
				this.m_HeroDetailAddExpUIController_OnHeroAddExpInt32BagItemBaseInt32Action_hotfix.call(new object[]
				{
					this,
					heroId,
					bagItem,
					count,
					OnFinished2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnFinished = OnFinished2;
			HeroListUITask $this = this;
			GoodsType goodsTypeId = bagItem.GoodsTypeId;
			int contentId = bagItem.ContentId;
			HeroAddExpNetTask heroAddExpNetTask = new HeroAddExpNetTask(heroId, goodsTypeId, contentId, count);
			heroAddExpNetTask.EventOnStop += delegate(Task task)
			{
				if (OnFinished != null)
				{
					OnFinished();
				}
				HeroAddExpNetTask heroAddExpNetTask2 = task as HeroAddExpNetTask;
				if (heroAddExpNetTask2.Result == 0)
				{
					$this.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroAddExpNetTask2.Result, 2f, null, true);
				}
			};
			heroAddExpNetTask.Start(null);
		}

		// Token: 0x06011006 RID: 69638 RVA: 0x00469230 File Offset: 0x00467430
		private void HeroDetailAddExpUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailAddExpUIController_OnReturn_hotfix != null)
			{
				this.m_HeroDetailAddExpUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SceneLayerBase sceneLayerBase = this.m_layerArray[8];
			if (sceneLayerBase.State == SceneLayerBase.LayerState.InStack)
			{
				SceneManager.Instance.PopLayer(sceneLayerBase);
			}
			this.m_curMode = "DetailInfo";
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06011007 RID: 69639 RVA: 0x004692C8 File Offset: 0x004674C8
		private void HeroListUIController_OnDetail()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnDetail_hotfix != null)
			{
				this.m_HeroListUIController_OnDetail_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curMode = ((this.m_lastMode != null) ? this.m_lastMode : "DetailInfo");
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06011008 RID: 69640 RVA: 0x00469354 File Offset: 0x00467554
		private void HeroDetailUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailUIController_OnReturn_hotfix != null)
			{
				this.m_HeroDetailUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curMode = "List";
			base.StartUpdatePipeLine(null, false, false, true);
			this.m_heroListUIController.m_curSelectedHeroIndex = this.m_heroDetailUIController.m_curHeroNum;
			this.m_heroListUIController.ResetPanelPos();
			CommonUIStateController component = this.m_heroDetailUIController.gameObject.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateOpen(component, "ToRight", delegate
			{
				SceneLayerBase sceneLayerBase = this.m_layerArray[1];
				if (sceneLayerBase.State == SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PopLayer(sceneLayerBase);
				}
			}, true, true);
			this.m_isDetailLayerOpen = false;
			this.CloseHeroCharChangeTask(null);
		}

		// Token: 0x06011009 RID: 69641 RVA: 0x00469424 File Offset: 0x00467624
		private void HeroListUIController_OnHeroBreak(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnHeroBreakInt32_hotfix != null)
			{
				this.m_HeroListUIController_OnHeroBreakInt32_hotfix.call(new object[]
				{
					this,
					id2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int id = id2;
			HeroListUITask $this = this;
			HeroStarLevelUpNetTask heroStarLevelUpNetTask = new HeroStarLevelUpNetTask(id);
			heroStarLevelUpNetTask.EventOnStop += delegate(Task task)
			{
				HeroStarLevelUpNetTask heroStarLevelUpNetTask2 = task as HeroStarLevelUpNetTask;
				if (heroStarLevelUpNetTask2.Result == 0)
				{
					$this.Pause();
					HeroBreakEffectUITask.StartUITask($this.m_currIntent, id);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroStarLevelUpNetTask2.Result, 2f, null, true);
				}
			};
			heroStarLevelUpNetTask.Start(null);
		}

		// Token: 0x0601100A RID: 69642 RVA: 0x004694D0 File Offset: 0x004676D0
		private void HeroDetailUIController_OnJobTransfer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailUIController_OnJobTransfer_hotfix != null)
			{
				this.m_HeroDetailUIController_OnJobTransfer_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(HeroJobTransferUITask).Name, null);
				Hero value = this.m_heroDetailUIController.m_curHeroList[this.m_heroDetailUIController.m_curHeroNum];
				uiintentReturnable.SetParam("hero", value);
				this.m_heroJobTransferUITask = (UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action(this.HeroJobTransferUITask_OnLoadAllResCompleted)) as HeroJobTransferUITask);
				this.m_heroListUIController.m_curSelectedHeroIndex = this.m_heroDetailUIController.m_curHeroNum;
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0601100B RID: 69643 RVA: 0x00469554 File Offset: 0x00467754
		private void HeroJobTransferUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroJobTransferUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_HeroJobTransferUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroJobTransferUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601100C RID: 69644 RVA: 0x004695E0 File Offset: 0x004677E0
		private void HeroListUIController_OnComment()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnComment_hotfix != null)
			{
				this.m_HeroListUIController_OnComment_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(HeroCommentUITask).Name, HeroCommentUITask.UIMode_HeroComment);
				Hero value = this.m_heroListUIController.m_unLockedHeroList[this.m_heroListUIController.m_curSelectedHeroIndex];
				uiintentReturnable.SetParam("hero", value);
				UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action(this.HeroCommentUITask_OnLoadAllResCompleted));
				this.CloseHeroCharChangeTask(null);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0601100D RID: 69645 RVA: 0x00469664 File Offset: 0x00467864
		private void HeroCommentUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCommentUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_HeroCommentUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroCommentUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601100E RID: 69646 RVA: 0x004696F0 File Offset: 0x004678F0
		private void HeroDetailEquipmentUIController_OnGotoEquipmentDepot(int slot, ulong equipmentInstanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailEquipmentUIController_OnGotoEquipmentDepotInt32UInt64_hotfix != null)
			{
				this.m_HeroDetailEquipmentUIController_OnGotoEquipmentDepotInt32UInt64_hotfix.call(new object[]
				{
					this,
					slot2,
					equipmentInstanceId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int slot = slot2;
			ulong equipmentInstanceId = equipmentInstanceId2;
			HeroListUITask $this = this;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable($this.m_currIntent, typeof(EquipmentDepotUITask).Name, null);
				Hero value = $this.m_heroDetailUIController.m_curHeroList[$this.m_heroDetailUIController.m_curHeroNum];
				uiintentReturnable.SetParam("hero", value);
				uiintentReturnable.SetParam("slot", slot);
				uiintentReturnable.SetParam("id", equipmentInstanceId);
				UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action($this.EquipmentDepotUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0601100F RID: 69647 RVA: 0x004697AC File Offset: 0x004679AC
		private void EquipmentDepotUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentDepotUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_EquipmentDepotUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(EquipmentDepotUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06011010 RID: 69648 RVA: 0x00469838 File Offset: 0x00467A38
		private void HeroDetailEquipmentUIController_OnGotoEquipmentForge(int slot, ulong equipmentInstanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailEquipmentUIController_OnGotoEquipmentForgeInt32UInt64_hotfix != null)
			{
				this.m_HeroDetailEquipmentUIController_OnGotoEquipmentForgeInt32UInt64_hotfix.call(new object[]
				{
					this,
					slot2,
					equipmentInstanceId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int slot = slot2;
			ulong equipmentInstanceId = equipmentInstanceId2;
			HeroListUITask $this = this;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable($this.m_currIntent, typeof(EquipmentForgeUITask).Name, null);
				Hero value = $this.m_heroDetailUIController.m_curHeroList[$this.m_heroDetailUIController.m_curHeroNum];
				uiintentReturnable.SetParam("hero", value);
				uiintentReturnable.SetParam("slot", slot);
				uiintentReturnable.SetParam("id", equipmentInstanceId);
				uiintentReturnable.SetParam("state", EquipmentForgeUIController.ForgeState.Enhance);
				UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action($this.EquipmentForgeUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06011011 RID: 69649 RVA: 0x004698F4 File Offset: 0x00467AF4
		private void EquipmentForgeUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_EquipmentForgeUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(EquipmentForgeUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06011012 RID: 69650 RVA: 0x00469980 File Offset: 0x00467B80
		private void HeroDetailEquipmentUIController_OnEquipmentTakeOff(int heroId, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailEquipmentUIController_OnEquipmentTakeOffInt32Int32_hotfix != null)
			{
				this.m_HeroDetailEquipmentUIController_OnEquipmentTakeOffInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					slot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EquipmentTakeOffNetTask equipmentTakeOffNetTask = new EquipmentTakeOffNetTask(heroId, slot);
			equipmentTakeOffNetTask.EventOnStop += delegate(Task task)
			{
				EquipmentTakeOffNetTask equipmentTakeOffNetTask2 = task as EquipmentTakeOffNetTask;
				if (equipmentTakeOffNetTask2.Result == 0)
				{
					this.UpdateView();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(equipmentTakeOffNetTask2.Result, 2f, null, true);
				}
			};
			equipmentTakeOffNetTask.Start(null);
		}

		// Token: 0x06011013 RID: 69651 RVA: 0x00469A24 File Offset: 0x00467C24
		private void HeroDetailEquipmentUIController_OnLockButtonClick(ulong instanceId, int slot, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailEquipmentUIController_OnLockButtonClickUInt64Int32Action_hotfix != null)
			{
				this.m_HeroDetailEquipmentUIController_OnLockButtonClickUInt64Int32Action_hotfix.call(new object[]
				{
					this,
					instanceId,
					slot,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			EquipmentLockAndUnLockNetTask equipmentLockAndUnLockNetTask = new EquipmentLockAndUnLockNetTask(instanceId);
			equipmentLockAndUnLockNetTask.EventOnStop += delegate(Task task)
			{
				EquipmentLockAndUnLockNetTask equipmentLockAndUnLockNetTask2 = task as EquipmentLockAndUnLockNetTask;
				if (equipmentLockAndUnLockNetTask2.Result == 0)
				{
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(equipmentLockAndUnLockNetTask2.Result, 2f, null, true);
				}
			};
			equipmentLockAndUnLockNetTask.Start(null);
		}

		// Token: 0x06011014 RID: 69652 RVA: 0x00469AE4 File Offset: 0x00467CE4
		private void HeroDetailEquipmentUIController_OnAutoEquip(int heroId, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailEquipmentUIController_OnAutoEquipInt32Action_hotfix != null)
			{
				this.m_HeroDetailEquipmentUIController_OnAutoEquipInt32Action_hotfix.call(new object[]
				{
					this,
					heroId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			HeroListUITask $this = this;
			AutoEquipNetTask autoEquipNetTask = new AutoEquipNetTask(heroId);
			autoEquipNetTask.EventOnStop += delegate(Task task)
			{
				AutoEquipNetTask autoEquipNetTask2 = task as AutoEquipNetTask;
				if (autoEquipNetTask2.Result == 0)
				{
					$this.StartUpdatePipeLine(null, false, false, true);
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(autoEquipNetTask2.Result, 2f, null, true);
				}
			};
			autoEquipNetTask.Start(null);
		}

		// Token: 0x06011015 RID: 69653 RVA: 0x00469B9C File Offset: 0x00467D9C
		private void HeroDetailEquipmentUIController_OnAutoRemove(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailEquipmentUIController_OnAutoRemoveInt32_hotfix != null)
			{
				this.m_HeroDetailEquipmentUIController_OnAutoRemoveInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AutoRemoveEquipmentNetTask autoRemoveEquipmentNetTask = new AutoRemoveEquipmentNetTask(heroId);
			autoRemoveEquipmentNetTask.EventOnStop += delegate(Task task)
			{
				AutoRemoveEquipmentNetTask autoRemoveEquipmentNetTask2 = task as AutoRemoveEquipmentNetTask;
				if (autoRemoveEquipmentNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(autoRemoveEquipmentNetTask2.Result, 2f, null, true);
				}
			};
			autoRemoveEquipmentNetTask.Start(null);
		}

		// Token: 0x06011016 RID: 69654 RVA: 0x00469C30 File Offset: 0x00467E30
		private void Hero_OnShowGetPath(GoodsType goodsType, int goodsId, int needCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Hero_OnShowGetPathGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_Hero_OnShowGetPathGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					goodsType,
					goodsId,
					needCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetPathUITask.StartUITask(goodsType, goodsId, new Action<GetPathData, NeedGoods>(this.Hero_OnGotoGetPath), needCount);
		}

		// Token: 0x06011017 RID: 69655 RVA: 0x00469CD8 File Offset: 0x00467ED8
		private void HeroListUIController_OnGotoEquipmentTab()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnGotoEquipmentTab_hotfix != null)
			{
				this.m_HeroListUIController_OnGotoEquipmentTab_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curMode = "DetailEquipment";
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06011018 RID: 69656 RVA: 0x00469D50 File Offset: 0x00467F50
		private void HeroListUIController_OnGotoJobTab()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnGotoJobTab_hotfix != null)
			{
				this.m_HeroListUIController_OnGotoJobTab_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curMode = "DetailJob";
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06011019 RID: 69657 RVA: 0x00469DC8 File Offset: 0x00467FC8
		private void HeroListUIController_OnSortToggleClick(HeroListUIController.HeroSortType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnSortToggleClickHeroSortType_hotfix != null)
			{
				this.m_HeroListUIController_OnSortToggleClickHeroSortType_hotfix.call(new object[]
				{
					this,
					type
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curHeroSortType = type;
			LocalConfig.Instance.SetHeroListSortType((int)this.m_curHeroSortType);
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0601101A RID: 69658 RVA: 0x00469E5C File Offset: 0x0046805C
		private void CloseHeroCharChangeTask(Action closeFinisdhAction = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseHeroCharChangeTaskAction_hotfix != null)
			{
				this.m_CloseHeroCharChangeTaskAction_hotfix.call(new object[]
				{
					this,
					closeFinisdhAction2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action closeFinisdhAction = closeFinisdhAction2;
			HeroListUITask $this = this;
			if (this.m_heroCharChangeTask != null && this.m_heroCharChangeTask.State == Task.TaskState.Running)
			{
				this.m_heroCharChangeTask.CloseHeroSkinChangePanelWithAnim(delegate
				{
					if (closeFinisdhAction != null)
					{
						closeFinisdhAction();
					}
					$this.m_heroCharChangeTask.Stop();
					$this.m_heroCharChangeTask = null;
				});
			}
		}

		// Token: 0x0601101B RID: 69659 RVA: 0x00469F14 File Offset: 0x00468114
		private void HeroListUIController_OnHeroCharSkinChangeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnHeroCharSkinChangeButtonClick_hotfix != null)
			{
				this.m_HeroListUIController_OnHeroCharSkinChangeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroCharChangeTask != null && this.m_heroCharChangeTask.State == Task.TaskState.Running)
			{
				this.m_heroCharChangeTask.CloseHeroSkinChangePanelWithAnim(delegate
				{
					this.HeroCharChangeTask_EventOnClose();
					this.m_heroCharChangeTask.Stop();
					this.m_heroCharChangeTask = null;
				});
			}
			else
			{
				if (this.m_heroDetailInfoUIController != null)
				{
					this.m_heroDetailInfoUIController.IsShowHeroLittleSpine(false);
				}
				Hero hero = this.m_curHeroList[this.m_curHeroPos];
				string mode = "ShowSkinDetailMode";
				Hero hero2 = hero;
				this.m_heroCharChangeTask = HeroSkinChangeUITask.StartUITask(mode, 0, hero2, this.m_currIntent);
				this.m_heroCharChangeTask.EventOnClose += this.HeroCharChangeTask_EventOnClose;
				this.m_heroCharChangeTask.EventOnSkinChangedPreview += this.HeroCharChangeTask_OnSkinChangedPreview;
			}
		}

		// Token: 0x0601101C RID: 69660 RVA: 0x0046A028 File Offset: 0x00468228
		private void HeroListUIController_OnHeroCharClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnHeroCharClick_hotfix != null)
			{
				this.m_HeroListUIController_OnHeroCharClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseHeroCharChangeTask(delegate
			{
				this.HeroCharChangeTask_EventOnClose();
			});
		}

		// Token: 0x0601101D RID: 69661 RVA: 0x0046A09C File Offset: 0x0046829C
		private void HeroListUIController_OnGoToMemoryExtractionStore()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListUIController_OnGoToMemoryExtractionStore_hotfix != null)
			{
				this.m_HeroListUIController_OnGoToMemoryExtractionStore_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Memory, null, true);
		}

		// Token: 0x0601101E RID: 69662 RVA: 0x0046A114 File Offset: 0x00468314
		public void HeroCharChangeTask_OnSkinChangedPreview(string spinePath, int heroSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCharChangeTask_OnSkinChangedPreviewStringInt32_hotfix != null)
			{
				this.m_HeroCharChangeTask_OnSkinChangedPreviewStringInt32_hotfix.call(new object[]
				{
					this,
					spinePath,
					heroSkinId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroListUIController.SetHeroCharSkinPreview(spinePath, heroSkinId);
		}

		// Token: 0x0601101F RID: 69663 RVA: 0x0046A1A4 File Offset: 0x004683A4
		public void HeroCharChangeTask_EventOnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCharChangeTask_EventOnClose_hotfix != null)
			{
				this.m_HeroCharChangeTask_EventOnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lastMode = "DetailAddExp";
			if (this.m_heroDetailInfoUIController != null)
			{
				this.m_heroDetailInfoUIController.IsShowHeroLittleSpine(true);
			}
			base.StartUpdatePipeLine(null, false, false, true);
			if (this.m_heroCharChangeTask != null)
			{
				this.m_heroCharChangeTask.EventOnClose -= this.HeroCharChangeTask_EventOnClose;
				this.m_heroCharChangeTask.EventOnSkinChangedPreview -= this.HeroCharChangeTask_OnSkinChangedPreview;
			}
		}

		// Token: 0x06011020 RID: 69664 RVA: 0x0046A270 File Offset: 0x00468470
		public void HeroCharChangeTask_OnAddSkinTicket()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCharChangeTask_OnAddSkinTicket_hotfix != null)
			{
				this.m_HeroCharChangeTask_OnAddSkinTicket_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Gift, null, false);
		}

		// Token: 0x06011021 RID: 69665 RVA: 0x0046A2E8 File Offset: 0x004684E8
		private void Hero_OnGotoGetPath(GetPathData getPath, NeedGoods needGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Hero_OnGotoGetPathGetPathDataNeedGoods_hotfix != null)
			{
				this.m_Hero_OnGotoGetPathGetPathDataNeedGoods_hotfix.call(new object[]
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

		// Token: 0x06011022 RID: 69666 RVA: 0x0046A37C File Offset: 0x0046857C
		private void HeroDetailSoldierUIController_OnSkinInfoButtonClick(ConfigDataSoldierInfo soldierInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailSoldierUIController_OnSkinInfoButtonClickConfigDataSoldierInfo_hotfix != null)
			{
				this.m_HeroDetailSoldierUIController_OnSkinInfoButtonClickConfigDataSoldierInfo_hotfix.call(new object[]
				{
					this,
					soldierInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_curHeroList[this.m_curHeroPos];
			HeroSoldierSkinUITask heroSoldierSkinUITask = HeroSoldierSkinUITask.StartUITask(hero, false, soldierInfo, this.m_currIntent);
			heroSoldierSkinUITask.BringLayerToTop();
			heroSoldierSkinUITask.EventOnReturn += this.HeroSoldierSkinUITask_EventOnReturn;
		}

		// Token: 0x06011023 RID: 69667 RVA: 0x0046A428 File Offset: 0x00468628
		private void HeroDetailInfoUIController_OnSkinInfoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailInfoUIController_OnSkinInfoButtonClick_hotfix != null)
			{
				this.m_HeroDetailInfoUIController_OnSkinInfoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.m_curHeroList[this.m_curHeroPos];
			HeroSoldierSkinUITask heroSoldierSkinUITask = HeroSoldierSkinUITask.StartUITask(hero, true, null, this.m_currIntent);
			heroSoldierSkinUITask.BringLayerToTop();
			heroSoldierSkinUITask.EventOnReturn += this.HeroSoldierSkinUITask_EventOnReturn;
		}

		// Token: 0x06011024 RID: 69668 RVA: 0x0046A4C4 File Offset: 0x004686C4
		private void HeroSoldierSkinUITask_EventOnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroSoldierSkinUITask_EventOnReturn_hotfix != null)
			{
				this.m_HeroSoldierSkinUITask_EventOnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06011025 RID: 69669 RVA: 0x0046A530 File Offset: 0x00468730
		private void HeroDetailInfoUIController_OnJobUpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDetailInfoUIController_OnJobUpButtonClick_hotfix != null)
			{
				this.m_HeroDetailInfoUIController_OnJobUpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curMode = "DetailJob";
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06011026 RID: 69670 RVA: 0x0046A5A8 File Offset: 0x004687A8
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

		// Token: 0x06011027 RID: 69671 RVA: 0x0046A654 File Offset: 0x00468854
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

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x06011028 RID: 69672 RVA: 0x0046A700 File Offset: 0x00468900
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

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x06011029 RID: 69673 RVA: 0x0046A774 File Offset: 0x00468974
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

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0601102A RID: 69674 RVA: 0x0046A7E8 File Offset: 0x004689E8
		// (set) Token: 0x0601102B RID: 69675 RVA: 0x0046A808 File Offset: 0x00468A08
		[DoNotToLua]
		public new HeroListUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroListUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601102C RID: 69676 RVA: 0x0046A814 File Offset: 0x00468A14
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0601102D RID: 69677 RVA: 0x0046A820 File Offset: 0x00468A20
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0601102E RID: 69678 RVA: 0x0046A828 File Offset: 0x00468A28
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0601102F RID: 69679 RVA: 0x0046A830 File Offset: 0x00468A30
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06011030 RID: 69680 RVA: 0x0046A83C File Offset: 0x00468A3C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06011031 RID: 69681 RVA: 0x0046A848 File Offset: 0x00468A48
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06011032 RID: 69682 RVA: 0x0046A854 File Offset: 0x00468A54
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06011033 RID: 69683 RVA: 0x0046A85C File Offset: 0x00468A5C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06011034 RID: 69684 RVA: 0x0046A864 File Offset: 0x00468A64
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06011035 RID: 69685 RVA: 0x0046A86C File Offset: 0x00468A6C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06011036 RID: 69686 RVA: 0x0046A874 File Offset: 0x00468A74
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06011037 RID: 69687 RVA: 0x0046A87C File Offset: 0x00468A7C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06011038 RID: 69688 RVA: 0x0046A884 File Offset: 0x00468A84
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06011039 RID: 69689 RVA: 0x0046A88C File Offset: 0x00468A8C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0601103A RID: 69690 RVA: 0x0046A898 File Offset: 0x00468A98
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0601103B RID: 69691 RVA: 0x0046A8A4 File Offset: 0x00468AA4
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0601103C RID: 69692 RVA: 0x0046A8B0 File Offset: 0x00468AB0
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0601103D RID: 69693 RVA: 0x0046A8BC File Offset: 0x00468ABC
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0601103E RID: 69694 RVA: 0x0046A8C4 File Offset: 0x00468AC4
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0601103F RID: 69695 RVA: 0x0046A8CC File Offset: 0x00468ACC
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06011040 RID: 69696 RVA: 0x0046A8D4 File Offset: 0x00468AD4
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06011041 RID: 69697 RVA: 0x0046A8DC File Offset: 0x00468ADC
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06011042 RID: 69698 RVA: 0x0046A8E4 File Offset: 0x00468AE4
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0601104E RID: 69710 RVA: 0x0046AC14 File Offset: 0x00468E14
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
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_SaveUIStateToIntent_hotfix = (luaObj.RawGet("SaveUIStateToIntent") as LuaFunction);
					this.m_GetUIStateFromIntentUIIntent_hotfix = (luaObj.RawGet("GetUIStateFromIntent") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_UpdataHeroListData_hotfix = (luaObj.RawGet("UpdataHeroListData") as LuaFunction);
					this.m_UpdateHeroCardData_hotfix = (luaObj.RawGet("UpdateHeroCardData") as LuaFunction);
					this.m_UpdateCurrentHeroData_hotfix = (luaObj.RawGet("UpdateCurrentHeroData") as LuaFunction);
					this.m_UpdateSoldierModeData_hotfix = (luaObj.RawGet("UpdateSoldierModeData") as LuaFunction);
					this.m_UpdateJobModeData_hotfix = (luaObj.RawGet("UpdateJobModeData") as LuaFunction);
					this.m_HeroListItemCompareHeroHero_hotfix = (luaObj.RawGet("HeroListItemCompare") as LuaFunction);
					this.m_IsNeedLoadStaticRes_hotfix = (luaObj.RawGet("IsNeedLoadStaticRes") as LuaFunction);
					this.m_CollectAllStaticResDescForLoad_hotfix = (luaObj.RawGet("CollectAllStaticResDescForLoad") as LuaFunction);
					this.m_CreateLayerDescByIndexInt32_hotfix = (luaObj.RawGet("CreateLayerDescByIndex") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateViewOnHeroChangedInt32BooleanBooleanInt32_hotfix = (luaObj.RawGet("UpdateViewOnHeroChanged") as LuaFunction);
					this.m_StartUpdatePiplineInHeroListTask_hotfix = (luaObj.RawGet("StartUpdatePiplineInHeroListTask") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PushLayerByCurState_hotfix = (luaObj.RawGet("PushLayerByCurState") as LuaFunction);
					this.m_PushLayerByIndexInt32_hotfix = (luaObj.RawGet("PushLayerByIndex") as LuaFunction);
					this.m_CheckConflictBetweenLayerInt32_hotfix = (luaObj.RawGet("CheckConflictBetweenLayer") as LuaFunction);
					this.m_HeroDetailUIController_OnSetDetailStateString_hotfix = (luaObj.RawGet("HeroDetailUIController_OnSetDetailState") as LuaFunction);
					this.m_SetTabCommonUIStateByNameStringString_hotfix = (luaObj.RawGet("SetTabCommonUIStateByName") as LuaFunction);
					this.m_HeroListUIController_SetHeroListList`1List`1_hotfix = (luaObj.RawGet("HeroListUIController_SetHeroList") as LuaFunction);
					this.m_HeroListUIController_OnReturn_hotfix = (luaObj.RawGet("HeroListUIController_OnReturn") as LuaFunction);
					this.m_HeroListUIController_OnAddHeroString_hotfix = (luaObj.RawGet("HeroListUIController_OnAddHero") as LuaFunction);
					this.m_HeroListUIController_OnHeroComposeInt32Action_hotfix = (luaObj.RawGet("HeroListUIController_OnHeroCompose") as LuaFunction);
					this.m_HeroDetailLifeUIController_OnVoiceItemClickInt32_hotfix = (luaObj.RawGet("HeroDetailLifeUIController_OnVoiceItemClick") as LuaFunction);
					this.m_HeroDetailSelectSkillUIController_OnHeroSkillsSelectInt32List`1Boolean_hotfix = (luaObj.RawGet("HeroDetailSelectSkillUIController_OnHeroSkillsSelect") as LuaFunction);
					this.m_HeroDetailSoldierUIController_OnHeroSoldierSelectInt32Int32Action_hotfix = (luaObj.RawGet("HeroDetailSoldierUIController_OnHeroSoldierSelect") as LuaFunction);
					this.m_HeroDetailSoldierUIController_OnGotoDrillInt32_hotfix = (luaObj.RawGet("HeroDetailSoldierUIController_OnGotoDrill") as LuaFunction);
					this.m_HeroDetailSoldierUIController_OnGotoJobTransferConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("HeroDetailSoldierUIController_OnGotoJobTransfer") as LuaFunction);
					this.m_HeroDetailJobUIController_OnJobLvUpgradeInt32Int32Action_hotfix = (luaObj.RawGet("HeroDetailJobUIController_OnJobLvUpgrade") as LuaFunction);
					this.m_HeroDetailAddExpUIController_OnHeroAddExpInt32BagItemBaseInt32Action_hotfix = (luaObj.RawGet("HeroDetailAddExpUIController_OnHeroAddExp") as LuaFunction);
					this.m_HeroDetailAddExpUIController_OnReturn_hotfix = (luaObj.RawGet("HeroDetailAddExpUIController_OnReturn") as LuaFunction);
					this.m_HeroListUIController_OnDetail_hotfix = (luaObj.RawGet("HeroListUIController_OnDetail") as LuaFunction);
					this.m_HeroDetailUIController_OnReturn_hotfix = (luaObj.RawGet("HeroDetailUIController_OnReturn") as LuaFunction);
					this.m_HeroListUIController_OnHeroBreakInt32_hotfix = (luaObj.RawGet("HeroListUIController_OnHeroBreak") as LuaFunction);
					this.m_HeroDetailUIController_OnJobTransfer_hotfix = (luaObj.RawGet("HeroDetailUIController_OnJobTransfer") as LuaFunction);
					this.m_HeroJobTransferUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("HeroJobTransferUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_HeroListUIController_OnComment_hotfix = (luaObj.RawGet("HeroListUIController_OnComment") as LuaFunction);
					this.m_HeroCommentUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("HeroCommentUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_HeroDetailEquipmentUIController_OnGotoEquipmentDepotInt32UInt64_hotfix = (luaObj.RawGet("HeroDetailEquipmentUIController_OnGotoEquipmentDepot") as LuaFunction);
					this.m_EquipmentDepotUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("EquipmentDepotUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_HeroDetailEquipmentUIController_OnGotoEquipmentForgeInt32UInt64_hotfix = (luaObj.RawGet("HeroDetailEquipmentUIController_OnGotoEquipmentForge") as LuaFunction);
					this.m_EquipmentForgeUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("EquipmentForgeUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_HeroDetailEquipmentUIController_OnEquipmentTakeOffInt32Int32_hotfix = (luaObj.RawGet("HeroDetailEquipmentUIController_OnEquipmentTakeOff") as LuaFunction);
					this.m_HeroDetailEquipmentUIController_OnLockButtonClickUInt64Int32Action_hotfix = (luaObj.RawGet("HeroDetailEquipmentUIController_OnLockButtonClick") as LuaFunction);
					this.m_HeroDetailEquipmentUIController_OnAutoEquipInt32Action_hotfix = (luaObj.RawGet("HeroDetailEquipmentUIController_OnAutoEquip") as LuaFunction);
					this.m_HeroDetailEquipmentUIController_OnAutoRemoveInt32_hotfix = (luaObj.RawGet("HeroDetailEquipmentUIController_OnAutoRemove") as LuaFunction);
					this.m_Hero_OnShowGetPathGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("Hero_OnShowGetPath") as LuaFunction);
					this.m_HeroListUIController_OnGotoEquipmentTab_hotfix = (luaObj.RawGet("HeroListUIController_OnGotoEquipmentTab") as LuaFunction);
					this.m_HeroListUIController_OnGotoJobTab_hotfix = (luaObj.RawGet("HeroListUIController_OnGotoJobTab") as LuaFunction);
					this.m_HeroListUIController_OnSortToggleClickHeroSortType_hotfix = (luaObj.RawGet("HeroListUIController_OnSortToggleClick") as LuaFunction);
					this.m_CloseHeroCharChangeTaskAction_hotfix = (luaObj.RawGet("CloseHeroCharChangeTask") as LuaFunction);
					this.m_HeroListUIController_OnHeroCharSkinChangeButtonClick_hotfix = (luaObj.RawGet("HeroListUIController_OnHeroCharSkinChangeButtonClick") as LuaFunction);
					this.m_HeroListUIController_OnHeroCharClick_hotfix = (luaObj.RawGet("HeroListUIController_OnHeroCharClick") as LuaFunction);
					this.m_HeroListUIController_OnGoToMemoryExtractionStore_hotfix = (luaObj.RawGet("HeroListUIController_OnGoToMemoryExtractionStore") as LuaFunction);
					this.m_HeroCharChangeTask_OnSkinChangedPreviewStringInt32_hotfix = (luaObj.RawGet("HeroCharChangeTask_OnSkinChangedPreview") as LuaFunction);
					this.m_HeroCharChangeTask_EventOnClose_hotfix = (luaObj.RawGet("HeroCharChangeTask_EventOnClose") as LuaFunction);
					this.m_HeroCharChangeTask_OnAddSkinTicket_hotfix = (luaObj.RawGet("HeroCharChangeTask_OnAddSkinTicket") as LuaFunction);
					this.m_Hero_OnGotoGetPathGetPathDataNeedGoods_hotfix = (luaObj.RawGet("Hero_OnGotoGetPath") as LuaFunction);
					this.m_HeroDetailSoldierUIController_OnSkinInfoButtonClickConfigDataSoldierInfo_hotfix = (luaObj.RawGet("HeroDetailSoldierUIController_OnSkinInfoButtonClick") as LuaFunction);
					this.m_HeroDetailInfoUIController_OnSkinInfoButtonClick_hotfix = (luaObj.RawGet("HeroDetailInfoUIController_OnSkinInfoButtonClick") as LuaFunction);
					this.m_HeroSoldierSkinUITask_EventOnReturn_hotfix = (luaObj.RawGet("HeroSoldierSkinUITask_EventOnReturn") as LuaFunction);
					this.m_HeroDetailInfoUIController_OnJobUpButtonClick_hotfix = (luaObj.RawGet("HeroDetailInfoUIController_OnJobUpButtonClick") as LuaFunction);
					this.m_StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd_hotfix = (luaObj.RawGet("StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd") as LuaFunction);
					this.m_StoreSoldierSkinDetailUITask_EventOnClose_hotfix = (luaObj.RawGet("StoreSoldierSkinDetailUITask_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601104F RID: 69711 RVA: 0x0046B3E8 File Offset: 0x004695E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroListUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009C6A RID: 40042
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroListUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroListUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = false
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroDetailUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroDetailUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroDetailInfoUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroDetailInfoUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroDetailJobUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroDetailJobUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroDetailSoldierUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroDetailSoldierUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroDetailEquipmentUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroDetailEquipmentUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroDetailLifeUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroDetailLifeUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroDetailSelectSkillUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroDetailSelectSkillUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroDetailAddExpUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroDetailAddExpUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroSoldierSkinUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroSoldierSkinListPanel.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			}
		};

		// Token: 0x04009C6B RID: 40043
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroListUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroListUIController"),
				m_ctrlName = "HeroListUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroDetailUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroDetailUIController"),
				m_ctrlName = "HeroDetailUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroDetailInfoUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroDetailInfoUIController"),
				m_ctrlName = "HeroDetailInfoUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroDetailJobUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroDetailJobUIController"),
				m_ctrlName = "HeroDetailJobUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroDetailSoldierUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroDetailSoldierUIController"),
				m_ctrlName = "HeroDetailSoldierUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroDetailEquipmentUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroDetailEquipmentUIController"),
				m_ctrlName = "HeroDetailEquipmentUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroDetailLifeUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroDetailLifeUIController"),
				m_ctrlName = "HeroDetailLifeUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroDetailSelectSkillUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroDetailSelectSkillUIController"),
				m_ctrlName = "HeroDetailSelectSkillUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroDetailAddExpUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroDetailAddExpUIController"),
				m_ctrlName = "HeroDetailAddExpUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroSoldierSkinUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroSoldierSkinUIController"),
				m_ctrlName = "HeroSoldierSkinUIController"
			}
		};

		// Token: 0x04009C6C RID: 40044
		private HeroListUIController m_heroListUIController;

		// Token: 0x04009C6D RID: 40045
		private HeroDetailUIController m_heroDetailUIController;

		// Token: 0x04009C6E RID: 40046
		private HeroDetailJobUIController m_heroDetailJobUIController;

		// Token: 0x04009C6F RID: 40047
		private HeroDetailInfoUIController m_heroDetailInfoUIController;

		// Token: 0x04009C70 RID: 40048
		private HeroDetailAddExpUIController m_heroDetailAddExpUIController;

		// Token: 0x04009C71 RID: 40049
		private HeroDetailSoldierUIController m_heroDetailSoldierUIController;

		// Token: 0x04009C72 RID: 40050
		private HeroDetailLifeUIController m_heroDetailLifeUIController;

		// Token: 0x04009C73 RID: 40051
		private HeroDetailEquipmentUIController m_heroDetailEquipmentUIController;

		// Token: 0x04009C74 RID: 40052
		private HeroDetailSelectSkillUIController m_heroDetailSelectSkillUIController;

		// Token: 0x04009C75 RID: 40053
		private HeroJobTransferUITask m_heroJobTransferUITask;

		// Token: 0x04009C76 RID: 40054
		private HeroSkinChangeUITask m_heroCharChangeTask;

		// Token: 0x04009C77 RID: 40055
		private StoreSoldierSkinDetailUITask m_storeSoldierSkinDetailUITask;

		// Token: 0x04009C78 RID: 40056
		public const string ListMode = "List";

		// Token: 0x04009C79 RID: 40057
		public const string DetailInfoMode = "DetailInfo";

		// Token: 0x04009C7A RID: 40058
		public const string DetailJobMode = "DetailJob";

		// Token: 0x04009C7B RID: 40059
		public const string DetailSoldierMode = "DetailSoldier";

		// Token: 0x04009C7C RID: 40060
		public const string DetailEquipmentMode = "DetailEquipment";

		// Token: 0x04009C7D RID: 40061
		public const string DetailLifeMode = "DetailLife";

		// Token: 0x04009C7E RID: 40062
		public const string DetailSelectSkillMode = "DetailSelectSkill";

		// Token: 0x04009C7F RID: 40063
		public const string DetailAddExpMode = "DetailAddExp";

		// Token: 0x04009C80 RID: 40064
		private string m_stateName;

		// Token: 0x04009C81 RID: 40065
		private string m_lastMode;

		// Token: 0x04009C82 RID: 40066
		private string m_curMode = "List";

		// Token: 0x04009C83 RID: 40067
		private List<Hero> m_lockedList = new List<Hero>();

		// Token: 0x04009C84 RID: 40068
		private List<Hero> m_curHeroList = new List<Hero>();

		// Token: 0x04009C85 RID: 40069
		private List<Hero> m_unlockedList = new List<Hero>();

		// Token: 0x04009C86 RID: 40070
		private int m_curHeroPos;

		// Token: 0x04009C87 RID: 40071
		private int m_curLayerDescIndex;

		// Token: 0x04009C88 RID: 40072
		private int m_lastHeroId;

		// Token: 0x04009C89 RID: 40073
		private bool m_isUnlockHero = true;

		// Token: 0x04009C8A RID: 40074
		private bool m_isDetailLayerOpen;

		// Token: 0x04009C8B RID: 40075
		private HeroListUIController.HeroSortType m_curHeroSortType = (HeroListUIController.HeroSortType)LocalConfig.Instance.Data.HeroListSortType;

		// Token: 0x04009C8C RID: 40076
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009C8D RID: 40077
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009C8E RID: 40078
		[DoNotToLua]
		private HeroListUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009C8F RID: 40079
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009C90 RID: 40080
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009C91 RID: 40081
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04009C92 RID: 40082
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04009C93 RID: 40083
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04009C94 RID: 40084
		private LuaFunction m_SaveUIStateToIntent_hotfix;

		// Token: 0x04009C95 RID: 40085
		private LuaFunction m_GetUIStateFromIntentUIIntent_hotfix;

		// Token: 0x04009C96 RID: 40086
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04009C97 RID: 40087
		private LuaFunction m_UpdataHeroListData_hotfix;

		// Token: 0x04009C98 RID: 40088
		private LuaFunction m_UpdateHeroCardData_hotfix;

		// Token: 0x04009C99 RID: 40089
		private LuaFunction m_UpdateCurrentHeroData_hotfix;

		// Token: 0x04009C9A RID: 40090
		private LuaFunction m_UpdateSoldierModeData_hotfix;

		// Token: 0x04009C9B RID: 40091
		private LuaFunction m_UpdateJobModeData_hotfix;

		// Token: 0x04009C9C RID: 40092
		private LuaFunction m_HeroListItemCompareHeroHero_hotfix;

		// Token: 0x04009C9D RID: 40093
		private LuaFunction m_IsNeedLoadStaticRes_hotfix;

		// Token: 0x04009C9E RID: 40094
		private LuaFunction m_CollectAllStaticResDescForLoad_hotfix;

		// Token: 0x04009C9F RID: 40095
		private LuaFunction m_CreateLayerDescByIndexInt32_hotfix;

		// Token: 0x04009CA0 RID: 40096
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04009CA1 RID: 40097
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04009CA2 RID: 40098
		private LuaFunction m_UpdateViewOnHeroChangedInt32BooleanBooleanInt32_hotfix;

		// Token: 0x04009CA3 RID: 40099
		private LuaFunction m_StartUpdatePiplineInHeroListTask_hotfix;

		// Token: 0x04009CA4 RID: 40100
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04009CA5 RID: 40101
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009CA6 RID: 40102
		private LuaFunction m_PushLayerByCurState_hotfix;

		// Token: 0x04009CA7 RID: 40103
		private LuaFunction m_PushLayerByIndexInt32_hotfix;

		// Token: 0x04009CA8 RID: 40104
		private LuaFunction m_CheckConflictBetweenLayerInt32_hotfix;

		// Token: 0x04009CA9 RID: 40105
		private LuaFunction m_HeroDetailUIController_OnSetDetailStateString_hotfix;

		// Token: 0x04009CAA RID: 40106
		private LuaFunction m_SetTabCommonUIStateByNameStringString_hotfix;

		// Token: 0x04009CAB RID: 40107
		private LuaFunction m_HeroListUIController_SetHeroListList`1List;

		// Token: 0x04009CAC RID: 40108
		private LuaFunction m_HeroListUIController_OnReturn_hotfix;

		// Token: 0x04009CAD RID: 40109
		private LuaFunction m_HeroListUIController_OnAddHeroString_hotfix;

		// Token: 0x04009CAE RID: 40110
		private LuaFunction m_HeroListUIController_OnHeroComposeInt32Action_hotfix;

		// Token: 0x04009CAF RID: 40111
		private LuaFunction m_HeroDetailLifeUIController_OnVoiceItemClickInt32_hotfix;

		// Token: 0x04009CB0 RID: 40112
		private LuaFunction m_HeroDetailSelectSkillUIController_OnHeroSkillsSelectInt32List;

		// Token: 0x04009CB1 RID: 40113
		private LuaFunction m_HeroDetailSoldierUIController_OnHeroSoldierSelectInt32Int32Action_hotfix;

		// Token: 0x04009CB2 RID: 40114
		private LuaFunction m_HeroDetailSoldierUIController_OnGotoDrillInt32_hotfix;

		// Token: 0x04009CB3 RID: 40115
		private LuaFunction m_HeroDetailSoldierUIController_OnGotoJobTransferConfigDataJobConnectionInfo_hotfix;

		// Token: 0x04009CB4 RID: 40116
		private LuaFunction m_HeroDetailJobUIController_OnJobLvUpgradeInt32Int32Action_hotfix;

		// Token: 0x04009CB5 RID: 40117
		private LuaFunction m_HeroDetailAddExpUIController_OnHeroAddExpInt32BagItemBaseInt32Action_hotfix;

		// Token: 0x04009CB6 RID: 40118
		private LuaFunction m_HeroDetailAddExpUIController_OnReturn_hotfix;

		// Token: 0x04009CB7 RID: 40119
		private LuaFunction m_HeroListUIController_OnDetail_hotfix;

		// Token: 0x04009CB8 RID: 40120
		private LuaFunction m_HeroDetailUIController_OnReturn_hotfix;

		// Token: 0x04009CB9 RID: 40121
		private LuaFunction m_HeroListUIController_OnHeroBreakInt32_hotfix;

		// Token: 0x04009CBA RID: 40122
		private LuaFunction m_HeroDetailUIController_OnJobTransfer_hotfix;

		// Token: 0x04009CBB RID: 40123
		private LuaFunction m_HeroJobTransferUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04009CBC RID: 40124
		private LuaFunction m_HeroListUIController_OnComment_hotfix;

		// Token: 0x04009CBD RID: 40125
		private LuaFunction m_HeroCommentUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04009CBE RID: 40126
		private LuaFunction m_HeroDetailEquipmentUIController_OnGotoEquipmentDepotInt32UInt64_hotfix;

		// Token: 0x04009CBF RID: 40127
		private LuaFunction m_EquipmentDepotUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04009CC0 RID: 40128
		private LuaFunction m_HeroDetailEquipmentUIController_OnGotoEquipmentForgeInt32UInt64_hotfix;

		// Token: 0x04009CC1 RID: 40129
		private LuaFunction m_EquipmentForgeUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04009CC2 RID: 40130
		private LuaFunction m_HeroDetailEquipmentUIController_OnEquipmentTakeOffInt32Int32_hotfix;

		// Token: 0x04009CC3 RID: 40131
		private LuaFunction m_HeroDetailEquipmentUIController_OnLockButtonClickUInt64Int32Action_hotfix;

		// Token: 0x04009CC4 RID: 40132
		private LuaFunction m_HeroDetailEquipmentUIController_OnAutoEquipInt32Action_hotfix;

		// Token: 0x04009CC5 RID: 40133
		private LuaFunction m_HeroDetailEquipmentUIController_OnAutoRemoveInt32_hotfix;

		// Token: 0x04009CC6 RID: 40134
		private LuaFunction m_Hero_OnShowGetPathGoodsTypeInt32Int32_hotfix;

		// Token: 0x04009CC7 RID: 40135
		private LuaFunction m_HeroListUIController_OnGotoEquipmentTab_hotfix;

		// Token: 0x04009CC8 RID: 40136
		private LuaFunction m_HeroListUIController_OnGotoJobTab_hotfix;

		// Token: 0x04009CC9 RID: 40137
		private LuaFunction m_HeroListUIController_OnSortToggleClickHeroSortType_hotfix;

		// Token: 0x04009CCA RID: 40138
		private LuaFunction m_CloseHeroCharChangeTaskAction_hotfix;

		// Token: 0x04009CCB RID: 40139
		private LuaFunction m_HeroListUIController_OnHeroCharSkinChangeButtonClick_hotfix;

		// Token: 0x04009CCC RID: 40140
		private LuaFunction m_HeroListUIController_OnHeroCharClick_hotfix;

		// Token: 0x04009CCD RID: 40141
		private LuaFunction m_HeroListUIController_OnGoToMemoryExtractionStore_hotfix;

		// Token: 0x04009CCE RID: 40142
		private LuaFunction m_HeroCharChangeTask_OnSkinChangedPreviewStringInt32_hotfix;

		// Token: 0x04009CCF RID: 40143
		private LuaFunction m_HeroCharChangeTask_EventOnClose_hotfix;

		// Token: 0x04009CD0 RID: 40144
		private LuaFunction m_HeroCharChangeTask_OnAddSkinTicket_hotfix;

		// Token: 0x04009CD1 RID: 40145
		private LuaFunction m_Hero_OnGotoGetPathGetPathDataNeedGoods_hotfix;

		// Token: 0x04009CD2 RID: 40146
		private LuaFunction m_HeroDetailSoldierUIController_OnSkinInfoButtonClickConfigDataSoldierInfo_hotfix;

		// Token: 0x04009CD3 RID: 40147
		private LuaFunction m_HeroDetailInfoUIController_OnSkinInfoButtonClick_hotfix;

		// Token: 0x04009CD4 RID: 40148
		private LuaFunction m_HeroSoldierSkinUITask_EventOnReturn_hotfix;

		// Token: 0x04009CD5 RID: 40149
		private LuaFunction m_HeroDetailInfoUIController_OnJobUpButtonClick_hotfix;

		// Token: 0x04009CD6 RID: 40150
		private LuaFunction m_StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd_hotfix;

		// Token: 0x04009CD7 RID: 40151
		private LuaFunction m_StoreSoldierSkinDetailUITask_EventOnClose_hotfix;

		// Token: 0x04009CD8 RID: 40152
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04009CD9 RID: 40153
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000DD8 RID: 3544
		public new class LuaExportHelper
		{
			// Token: 0x06011050 RID: 69712 RVA: 0x0046B450 File Offset: 0x00469650
			public LuaExportHelper(HeroListUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011051 RID: 69713 RVA: 0x0046B460 File Offset: 0x00469660
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06011052 RID: 69714 RVA: 0x0046B470 File Offset: 0x00469670
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06011053 RID: 69715 RVA: 0x0046B480 File Offset: 0x00469680
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06011054 RID: 69716 RVA: 0x0046B490 File Offset: 0x00469690
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06011055 RID: 69717 RVA: 0x0046B4A0 File Offset: 0x004696A0
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06011056 RID: 69718 RVA: 0x0046B4B0 File Offset: 0x004696B0
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06011057 RID: 69719 RVA: 0x0046B4C0 File Offset: 0x004696C0
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06011058 RID: 69720 RVA: 0x0046B4D0 File Offset: 0x004696D0
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06011059 RID: 69721 RVA: 0x0046B4E0 File Offset: 0x004696E0
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0601105A RID: 69722 RVA: 0x0046B4F0 File Offset: 0x004696F0
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0601105B RID: 69723 RVA: 0x0046B500 File Offset: 0x00469700
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0601105C RID: 69724 RVA: 0x0046B510 File Offset: 0x00469710
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0601105D RID: 69725 RVA: 0x0046B520 File Offset: 0x00469720
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0601105E RID: 69726 RVA: 0x0046B530 File Offset: 0x00469730
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601105F RID: 69727 RVA: 0x0046B540 File Offset: 0x00469740
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06011060 RID: 69728 RVA: 0x0046B550 File Offset: 0x00469750
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06011061 RID: 69729 RVA: 0x0046B560 File Offset: 0x00469760
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06011062 RID: 69730 RVA: 0x0046B570 File Offset: 0x00469770
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06011063 RID: 69731 RVA: 0x0046B580 File Offset: 0x00469780
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06011064 RID: 69732 RVA: 0x0046B590 File Offset: 0x00469790
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06011065 RID: 69733 RVA: 0x0046B5A0 File Offset: 0x004697A0
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06011066 RID: 69734 RVA: 0x0046B5B0 File Offset: 0x004697B0
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06011067 RID: 69735 RVA: 0x0046B5C0 File Offset: 0x004697C0
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x170034A6 RID: 13478
			// (get) Token: 0x06011068 RID: 69736 RVA: 0x0046B5D0 File Offset: 0x004697D0
			// (set) Token: 0x06011069 RID: 69737 RVA: 0x0046B5E0 File Offset: 0x004697E0
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

			// Token: 0x170034A7 RID: 13479
			// (get) Token: 0x0601106A RID: 69738 RVA: 0x0046B5F0 File Offset: 0x004697F0
			// (set) Token: 0x0601106B RID: 69739 RVA: 0x0046B600 File Offset: 0x00469800
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

			// Token: 0x170034A8 RID: 13480
			// (get) Token: 0x0601106C RID: 69740 RVA: 0x0046B610 File Offset: 0x00469810
			// (set) Token: 0x0601106D RID: 69741 RVA: 0x0046B620 File Offset: 0x00469820
			public HeroListUIController m_heroListUIController
			{
				get
				{
					return this.m_owner.m_heroListUIController;
				}
				set
				{
					this.m_owner.m_heroListUIController = value;
				}
			}

			// Token: 0x170034A9 RID: 13481
			// (get) Token: 0x0601106E RID: 69742 RVA: 0x0046B630 File Offset: 0x00469830
			// (set) Token: 0x0601106F RID: 69743 RVA: 0x0046B640 File Offset: 0x00469840
			public HeroDetailUIController m_heroDetailUIController
			{
				get
				{
					return this.m_owner.m_heroDetailUIController;
				}
				set
				{
					this.m_owner.m_heroDetailUIController = value;
				}
			}

			// Token: 0x170034AA RID: 13482
			// (get) Token: 0x06011070 RID: 69744 RVA: 0x0046B650 File Offset: 0x00469850
			// (set) Token: 0x06011071 RID: 69745 RVA: 0x0046B660 File Offset: 0x00469860
			public HeroDetailJobUIController m_heroDetailJobUIController
			{
				get
				{
					return this.m_owner.m_heroDetailJobUIController;
				}
				set
				{
					this.m_owner.m_heroDetailJobUIController = value;
				}
			}

			// Token: 0x170034AB RID: 13483
			// (get) Token: 0x06011072 RID: 69746 RVA: 0x0046B670 File Offset: 0x00469870
			// (set) Token: 0x06011073 RID: 69747 RVA: 0x0046B680 File Offset: 0x00469880
			public HeroDetailInfoUIController m_heroDetailInfoUIController
			{
				get
				{
					return this.m_owner.m_heroDetailInfoUIController;
				}
				set
				{
					this.m_owner.m_heroDetailInfoUIController = value;
				}
			}

			// Token: 0x170034AC RID: 13484
			// (get) Token: 0x06011074 RID: 69748 RVA: 0x0046B690 File Offset: 0x00469890
			// (set) Token: 0x06011075 RID: 69749 RVA: 0x0046B6A0 File Offset: 0x004698A0
			public HeroDetailAddExpUIController m_heroDetailAddExpUIController
			{
				get
				{
					return this.m_owner.m_heroDetailAddExpUIController;
				}
				set
				{
					this.m_owner.m_heroDetailAddExpUIController = value;
				}
			}

			// Token: 0x170034AD RID: 13485
			// (get) Token: 0x06011076 RID: 69750 RVA: 0x0046B6B0 File Offset: 0x004698B0
			// (set) Token: 0x06011077 RID: 69751 RVA: 0x0046B6C0 File Offset: 0x004698C0
			public HeroDetailSoldierUIController m_heroDetailSoldierUIController
			{
				get
				{
					return this.m_owner.m_heroDetailSoldierUIController;
				}
				set
				{
					this.m_owner.m_heroDetailSoldierUIController = value;
				}
			}

			// Token: 0x170034AE RID: 13486
			// (get) Token: 0x06011078 RID: 69752 RVA: 0x0046B6D0 File Offset: 0x004698D0
			// (set) Token: 0x06011079 RID: 69753 RVA: 0x0046B6E0 File Offset: 0x004698E0
			public HeroDetailLifeUIController m_heroDetailLifeUIController
			{
				get
				{
					return this.m_owner.m_heroDetailLifeUIController;
				}
				set
				{
					this.m_owner.m_heroDetailLifeUIController = value;
				}
			}

			// Token: 0x170034AF RID: 13487
			// (get) Token: 0x0601107A RID: 69754 RVA: 0x0046B6F0 File Offset: 0x004698F0
			// (set) Token: 0x0601107B RID: 69755 RVA: 0x0046B700 File Offset: 0x00469900
			public HeroDetailEquipmentUIController m_heroDetailEquipmentUIController
			{
				get
				{
					return this.m_owner.m_heroDetailEquipmentUIController;
				}
				set
				{
					this.m_owner.m_heroDetailEquipmentUIController = value;
				}
			}

			// Token: 0x170034B0 RID: 13488
			// (get) Token: 0x0601107C RID: 69756 RVA: 0x0046B710 File Offset: 0x00469910
			// (set) Token: 0x0601107D RID: 69757 RVA: 0x0046B720 File Offset: 0x00469920
			public HeroDetailSelectSkillUIController m_heroDetailSelectSkillUIController
			{
				get
				{
					return this.m_owner.m_heroDetailSelectSkillUIController;
				}
				set
				{
					this.m_owner.m_heroDetailSelectSkillUIController = value;
				}
			}

			// Token: 0x170034B1 RID: 13489
			// (get) Token: 0x0601107E RID: 69758 RVA: 0x0046B730 File Offset: 0x00469930
			// (set) Token: 0x0601107F RID: 69759 RVA: 0x0046B740 File Offset: 0x00469940
			public HeroJobTransferUITask m_heroJobTransferUITask
			{
				get
				{
					return this.m_owner.m_heroJobTransferUITask;
				}
				set
				{
					this.m_owner.m_heroJobTransferUITask = value;
				}
			}

			// Token: 0x170034B2 RID: 13490
			// (get) Token: 0x06011080 RID: 69760 RVA: 0x0046B750 File Offset: 0x00469950
			// (set) Token: 0x06011081 RID: 69761 RVA: 0x0046B760 File Offset: 0x00469960
			public HeroSkinChangeUITask m_heroCharChangeTask
			{
				get
				{
					return this.m_owner.m_heroCharChangeTask;
				}
				set
				{
					this.m_owner.m_heroCharChangeTask = value;
				}
			}

			// Token: 0x170034B3 RID: 13491
			// (get) Token: 0x06011082 RID: 69762 RVA: 0x0046B770 File Offset: 0x00469970
			// (set) Token: 0x06011083 RID: 69763 RVA: 0x0046B780 File Offset: 0x00469980
			public StoreSoldierSkinDetailUITask m_storeSoldierSkinDetailUITask
			{
				get
				{
					return this.m_owner.m_storeSoldierSkinDetailUITask;
				}
				set
				{
					this.m_owner.m_storeSoldierSkinDetailUITask = value;
				}
			}

			// Token: 0x170034B4 RID: 13492
			// (get) Token: 0x06011084 RID: 69764 RVA: 0x0046B790 File Offset: 0x00469990
			// (set) Token: 0x06011085 RID: 69765 RVA: 0x0046B7A0 File Offset: 0x004699A0
			public string m_stateName
			{
				get
				{
					return this.m_owner.m_stateName;
				}
				set
				{
					this.m_owner.m_stateName = value;
				}
			}

			// Token: 0x170034B5 RID: 13493
			// (get) Token: 0x06011086 RID: 69766 RVA: 0x0046B7B0 File Offset: 0x004699B0
			// (set) Token: 0x06011087 RID: 69767 RVA: 0x0046B7C0 File Offset: 0x004699C0
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

			// Token: 0x170034B6 RID: 13494
			// (get) Token: 0x06011088 RID: 69768 RVA: 0x0046B7D0 File Offset: 0x004699D0
			// (set) Token: 0x06011089 RID: 69769 RVA: 0x0046B7E0 File Offset: 0x004699E0
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

			// Token: 0x170034B7 RID: 13495
			// (get) Token: 0x0601108A RID: 69770 RVA: 0x0046B7F0 File Offset: 0x004699F0
			// (set) Token: 0x0601108B RID: 69771 RVA: 0x0046B800 File Offset: 0x00469A00
			public List<Hero> m_lockedList
			{
				get
				{
					return this.m_owner.m_lockedList;
				}
				set
				{
					this.m_owner.m_lockedList = value;
				}
			}

			// Token: 0x170034B8 RID: 13496
			// (get) Token: 0x0601108C RID: 69772 RVA: 0x0046B810 File Offset: 0x00469A10
			// (set) Token: 0x0601108D RID: 69773 RVA: 0x0046B820 File Offset: 0x00469A20
			public List<Hero> m_curHeroList
			{
				get
				{
					return this.m_owner.m_curHeroList;
				}
				set
				{
					this.m_owner.m_curHeroList = value;
				}
			}

			// Token: 0x170034B9 RID: 13497
			// (get) Token: 0x0601108E RID: 69774 RVA: 0x0046B830 File Offset: 0x00469A30
			// (set) Token: 0x0601108F RID: 69775 RVA: 0x0046B840 File Offset: 0x00469A40
			public List<Hero> m_unlockedList
			{
				get
				{
					return this.m_owner.m_unlockedList;
				}
				set
				{
					this.m_owner.m_unlockedList = value;
				}
			}

			// Token: 0x170034BA RID: 13498
			// (get) Token: 0x06011090 RID: 69776 RVA: 0x0046B850 File Offset: 0x00469A50
			// (set) Token: 0x06011091 RID: 69777 RVA: 0x0046B860 File Offset: 0x00469A60
			public int m_curHeroPos
			{
				get
				{
					return this.m_owner.m_curHeroPos;
				}
				set
				{
					this.m_owner.m_curHeroPos = value;
				}
			}

			// Token: 0x170034BB RID: 13499
			// (get) Token: 0x06011092 RID: 69778 RVA: 0x0046B870 File Offset: 0x00469A70
			// (set) Token: 0x06011093 RID: 69779 RVA: 0x0046B880 File Offset: 0x00469A80
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

			// Token: 0x170034BC RID: 13500
			// (get) Token: 0x06011094 RID: 69780 RVA: 0x0046B890 File Offset: 0x00469A90
			// (set) Token: 0x06011095 RID: 69781 RVA: 0x0046B8A0 File Offset: 0x00469AA0
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

			// Token: 0x170034BD RID: 13501
			// (get) Token: 0x06011096 RID: 69782 RVA: 0x0046B8B0 File Offset: 0x00469AB0
			// (set) Token: 0x06011097 RID: 69783 RVA: 0x0046B8C0 File Offset: 0x00469AC0
			public bool m_isUnlockHero
			{
				get
				{
					return this.m_owner.m_isUnlockHero;
				}
				set
				{
					this.m_owner.m_isUnlockHero = value;
				}
			}

			// Token: 0x170034BE RID: 13502
			// (get) Token: 0x06011098 RID: 69784 RVA: 0x0046B8D0 File Offset: 0x00469AD0
			// (set) Token: 0x06011099 RID: 69785 RVA: 0x0046B8E0 File Offset: 0x00469AE0
			public bool m_isDetailLayerOpen
			{
				get
				{
					return this.m_owner.m_isDetailLayerOpen;
				}
				set
				{
					this.m_owner.m_isDetailLayerOpen = value;
				}
			}

			// Token: 0x170034BF RID: 13503
			// (get) Token: 0x0601109A RID: 69786 RVA: 0x0046B8F0 File Offset: 0x00469AF0
			// (set) Token: 0x0601109B RID: 69787 RVA: 0x0046B900 File Offset: 0x00469B00
			public HeroListUIController.HeroSortType m_curHeroSortType
			{
				get
				{
					return this.m_owner.m_curHeroSortType;
				}
				set
				{
					this.m_owner.m_curHeroSortType = value;
				}
			}

			// Token: 0x170034C0 RID: 13504
			// (get) Token: 0x0601109C RID: 69788 RVA: 0x0046B910 File Offset: 0x00469B10
			// (set) Token: 0x0601109D RID: 69789 RVA: 0x0046B920 File Offset: 0x00469B20
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

			// Token: 0x170034C1 RID: 13505
			// (get) Token: 0x0601109E RID: 69790 RVA: 0x0046B930 File Offset: 0x00469B30
			// (set) Token: 0x0601109F RID: 69791 RVA: 0x0046B940 File Offset: 0x00469B40
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

			// Token: 0x170034C2 RID: 13506
			// (get) Token: 0x060110A0 RID: 69792 RVA: 0x0046B950 File Offset: 0x00469B50
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170034C3 RID: 13507
			// (get) Token: 0x060110A1 RID: 69793 RVA: 0x0046B960 File Offset: 0x00469B60
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060110A2 RID: 69794 RVA: 0x0046B970 File Offset: 0x00469B70
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x060110A3 RID: 69795 RVA: 0x0046B980 File Offset: 0x00469B80
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x060110A4 RID: 69796 RVA: 0x0046B990 File Offset: 0x00469B90
			public void SaveUIStateToIntent()
			{
				this.m_owner.SaveUIStateToIntent();
			}

			// Token: 0x060110A5 RID: 69797 RVA: 0x0046B9A0 File Offset: 0x00469BA0
			public void GetUIStateFromIntent(UIIntent uiIntent)
			{
				this.m_owner.GetUIStateFromIntent(uiIntent);
			}

			// Token: 0x060110A6 RID: 69798 RVA: 0x0046B9B0 File Offset: 0x00469BB0
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x060110A7 RID: 69799 RVA: 0x0046B9C0 File Offset: 0x00469BC0
			public void UpdataHeroListData()
			{
				this.m_owner.UpdataHeroListData();
			}

			// Token: 0x060110A8 RID: 69800 RVA: 0x0046B9D0 File Offset: 0x00469BD0
			public void UpdateHeroCardData()
			{
				this.m_owner.UpdateHeroCardData();
			}

			// Token: 0x060110A9 RID: 69801 RVA: 0x0046B9E0 File Offset: 0x00469BE0
			public void UpdateCurrentHeroData()
			{
				this.m_owner.UpdateCurrentHeroData();
			}

			// Token: 0x060110AA RID: 69802 RVA: 0x0046B9F0 File Offset: 0x00469BF0
			public void UpdateSoldierModeData()
			{
				this.m_owner.UpdateSoldierModeData();
			}

			// Token: 0x060110AB RID: 69803 RVA: 0x0046BA00 File Offset: 0x00469C00
			public void UpdateJobModeData()
			{
				this.m_owner.UpdateJobModeData();
			}

			// Token: 0x060110AC RID: 69804 RVA: 0x0046BA10 File Offset: 0x00469C10
			public int HeroListItemCompare(Hero h1, Hero h2)
			{
				return this.m_owner.HeroListItemCompare(h1, h2);
			}

			// Token: 0x060110AD RID: 69805 RVA: 0x0046BA20 File Offset: 0x00469C20
			public bool IsNeedLoadStaticRes()
			{
				return this.m_owner.IsNeedLoadStaticRes();
			}

			// Token: 0x060110AE RID: 69806 RVA: 0x0046BA30 File Offset: 0x00469C30
			public List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
			{
				return this.m_owner.CollectAllStaticResDescForLoad();
			}

			// Token: 0x060110AF RID: 69807 RVA: 0x0046BA40 File Offset: 0x00469C40
			public UITaskBase.LayerDesc CreateLayerDescByIndex(int index)
			{
				return this.m_owner.CreateLayerDescByIndex(index);
			}

			// Token: 0x060110B0 RID: 69808 RVA: 0x0046BA50 File Offset: 0x00469C50
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060110B1 RID: 69809 RVA: 0x0046BA60 File Offset: 0x00469C60
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060110B2 RID: 69810 RVA: 0x0046BA70 File Offset: 0x00469C70
			public void UpdateViewOnHeroChanged(int pos, bool isUnlockHero, bool isNeedStopCoroutine, int lastHeroId)
			{
				this.m_owner.UpdateViewOnHeroChanged(pos, isUnlockHero, isNeedStopCoroutine, lastHeroId);
			}

			// Token: 0x060110B3 RID: 69811 RVA: 0x0046BA84 File Offset: 0x00469C84
			public void StartUpdatePiplineInHeroListTask()
			{
				this.m_owner.StartUpdatePiplineInHeroListTask();
			}

			// Token: 0x060110B4 RID: 69812 RVA: 0x0046BA94 File Offset: 0x00469C94
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x060110B5 RID: 69813 RVA: 0x0046BAA4 File Offset: 0x00469CA4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060110B6 RID: 69814 RVA: 0x0046BAB4 File Offset: 0x00469CB4
			public void PushLayerByCurState()
			{
				this.m_owner.PushLayerByCurState();
			}

			// Token: 0x060110B7 RID: 69815 RVA: 0x0046BAC4 File Offset: 0x00469CC4
			public void PushLayerByIndex(int index)
			{
				this.m_owner.PushLayerByIndex(index);
			}

			// Token: 0x060110B8 RID: 69816 RVA: 0x0046BAD4 File Offset: 0x00469CD4
			public void CheckConflictBetweenLayer(int layerIndex)
			{
				this.m_owner.CheckConflictBetweenLayer(layerIndex);
			}

			// Token: 0x060110B9 RID: 69817 RVA: 0x0046BAE4 File Offset: 0x00469CE4
			public void HeroDetailUIController_OnSetDetailState(string mode)
			{
				this.m_owner.HeroDetailUIController_OnSetDetailState(mode);
			}

			// Token: 0x060110BA RID: 69818 RVA: 0x0046BAF4 File Offset: 0x00469CF4
			public void SetTabCommonUIStateByName(string modeName, string stateName)
			{
				this.m_owner.SetTabCommonUIStateByName(modeName, stateName);
			}

			// Token: 0x060110BB RID: 69819 RVA: 0x0046BB04 File Offset: 0x00469D04
			public void HeroListUIController_SetHeroList(List<Hero> unlockedList, List<Hero> lockedList)
			{
				this.m_owner.HeroListUIController_SetHeroList(unlockedList, lockedList);
			}

			// Token: 0x060110BC RID: 69820 RVA: 0x0046BB14 File Offset: 0x00469D14
			public void HeroListUIController_OnReturn()
			{
				this.m_owner.HeroListUIController_OnReturn();
			}

			// Token: 0x060110BD RID: 69821 RVA: 0x0046BB24 File Offset: 0x00469D24
			public void HeroListUIController_OnAddHero(string str)
			{
				this.m_owner.HeroListUIController_OnAddHero(str);
			}

			// Token: 0x060110BE RID: 69822 RVA: 0x0046BB34 File Offset: 0x00469D34
			public void HeroListUIController_OnHeroCompose(int heroId, Action OnSucceed)
			{
				this.m_owner.HeroListUIController_OnHeroCompose(heroId, OnSucceed);
			}

			// Token: 0x060110BF RID: 69823 RVA: 0x0046BB44 File Offset: 0x00469D44
			public void HeroDetailLifeUIController_OnVoiceItemClick(int heroPerformanceId)
			{
				this.m_owner.HeroDetailLifeUIController_OnVoiceItemClick(heroPerformanceId);
			}

			// Token: 0x060110C0 RID: 69824 RVA: 0x0046BB54 File Offset: 0x00469D54
			public void HeroDetailSelectSkillUIController_OnHeroSkillsSelect(int heroId, List<int> skillIds, bool isSkillChanged)
			{
				this.m_owner.HeroDetailSelectSkillUIController_OnHeroSkillsSelect(heroId, skillIds, isSkillChanged);
			}

			// Token: 0x060110C1 RID: 69825 RVA: 0x0046BB64 File Offset: 0x00469D64
			public void HeroDetailSoldierUIController_OnHeroSoldierSelect(int heroId, int soldierId, Action OnSucceed)
			{
				this.m_owner.HeroDetailSoldierUIController_OnHeroSoldierSelect(heroId, soldierId, OnSucceed);
			}

			// Token: 0x060110C2 RID: 69826 RVA: 0x0046BB74 File Offset: 0x00469D74
			public void HeroDetailSoldierUIController_OnGotoDrill(int techId)
			{
				this.m_owner.HeroDetailSoldierUIController_OnGotoDrill(techId);
			}

			// Token: 0x060110C3 RID: 69827 RVA: 0x0046BB84 File Offset: 0x00469D84
			public void HeroDetailSoldierUIController_OnGotoJobTransfer(ConfigDataJobConnectionInfo jobConnectionInfo)
			{
				this.m_owner.HeroDetailSoldierUIController_OnGotoJobTransfer(jobConnectionInfo);
			}

			// Token: 0x060110C4 RID: 69828 RVA: 0x0046BB94 File Offset: 0x00469D94
			public void HeroDetailJobUIController_OnJobLvUpgrade(int heroId, int jobConnectionId, Action OnSucceed)
			{
				this.m_owner.HeroDetailJobUIController_OnJobLvUpgrade(heroId, jobConnectionId, OnSucceed);
			}

			// Token: 0x060110C5 RID: 69829 RVA: 0x0046BBA4 File Offset: 0x00469DA4
			public void HeroDetailAddExpUIController_OnHeroAddExp(int heroId, BagItemBase bagItem, int count, Action OnFinished)
			{
				this.m_owner.HeroDetailAddExpUIController_OnHeroAddExp(heroId, bagItem, count, OnFinished);
			}

			// Token: 0x060110C6 RID: 69830 RVA: 0x0046BBB8 File Offset: 0x00469DB8
			public void HeroDetailAddExpUIController_OnReturn()
			{
				this.m_owner.HeroDetailAddExpUIController_OnReturn();
			}

			// Token: 0x060110C7 RID: 69831 RVA: 0x0046BBC8 File Offset: 0x00469DC8
			public void HeroListUIController_OnDetail()
			{
				this.m_owner.HeroListUIController_OnDetail();
			}

			// Token: 0x060110C8 RID: 69832 RVA: 0x0046BBD8 File Offset: 0x00469DD8
			public void HeroDetailUIController_OnReturn()
			{
				this.m_owner.HeroDetailUIController_OnReturn();
			}

			// Token: 0x060110C9 RID: 69833 RVA: 0x0046BBE8 File Offset: 0x00469DE8
			public void HeroListUIController_OnHeroBreak(int id)
			{
				this.m_owner.HeroListUIController_OnHeroBreak(id);
			}

			// Token: 0x060110CA RID: 69834 RVA: 0x0046BBF8 File Offset: 0x00469DF8
			public void HeroDetailUIController_OnJobTransfer()
			{
				this.m_owner.HeroDetailUIController_OnJobTransfer();
			}

			// Token: 0x060110CB RID: 69835 RVA: 0x0046BC08 File Offset: 0x00469E08
			public void HeroJobTransferUITask_OnLoadAllResCompleted()
			{
				this.m_owner.HeroJobTransferUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060110CC RID: 69836 RVA: 0x0046BC18 File Offset: 0x00469E18
			public void HeroListUIController_OnComment()
			{
				this.m_owner.HeroListUIController_OnComment();
			}

			// Token: 0x060110CD RID: 69837 RVA: 0x0046BC28 File Offset: 0x00469E28
			public void HeroCommentUITask_OnLoadAllResCompleted()
			{
				this.m_owner.HeroCommentUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060110CE RID: 69838 RVA: 0x0046BC38 File Offset: 0x00469E38
			public void HeroDetailEquipmentUIController_OnGotoEquipmentDepot(int slot, ulong equipmentInstanceId)
			{
				this.m_owner.HeroDetailEquipmentUIController_OnGotoEquipmentDepot(slot, equipmentInstanceId);
			}

			// Token: 0x060110CF RID: 69839 RVA: 0x0046BC48 File Offset: 0x00469E48
			public void EquipmentDepotUITask_OnLoadAllResCompleted()
			{
				this.m_owner.EquipmentDepotUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060110D0 RID: 69840 RVA: 0x0046BC58 File Offset: 0x00469E58
			public void HeroDetailEquipmentUIController_OnGotoEquipmentForge(int slot, ulong equipmentInstanceId)
			{
				this.m_owner.HeroDetailEquipmentUIController_OnGotoEquipmentForge(slot, equipmentInstanceId);
			}

			// Token: 0x060110D1 RID: 69841 RVA: 0x0046BC68 File Offset: 0x00469E68
			public void EquipmentForgeUITask_OnLoadAllResCompleted()
			{
				this.m_owner.EquipmentForgeUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060110D2 RID: 69842 RVA: 0x0046BC78 File Offset: 0x00469E78
			public void HeroDetailEquipmentUIController_OnEquipmentTakeOff(int heroId, int slot)
			{
				this.m_owner.HeroDetailEquipmentUIController_OnEquipmentTakeOff(heroId, slot);
			}

			// Token: 0x060110D3 RID: 69843 RVA: 0x0046BC88 File Offset: 0x00469E88
			public void HeroDetailEquipmentUIController_OnLockButtonClick(ulong instanceId, int slot, Action OnSucceed)
			{
				this.m_owner.HeroDetailEquipmentUIController_OnLockButtonClick(instanceId, slot, OnSucceed);
			}

			// Token: 0x060110D4 RID: 69844 RVA: 0x0046BC98 File Offset: 0x00469E98
			public void HeroDetailEquipmentUIController_OnAutoEquip(int heroId, Action OnSucceed)
			{
				this.m_owner.HeroDetailEquipmentUIController_OnAutoEquip(heroId, OnSucceed);
			}

			// Token: 0x060110D5 RID: 69845 RVA: 0x0046BCA8 File Offset: 0x00469EA8
			public void HeroDetailEquipmentUIController_OnAutoRemove(int heroId)
			{
				this.m_owner.HeroDetailEquipmentUIController_OnAutoRemove(heroId);
			}

			// Token: 0x060110D6 RID: 69846 RVA: 0x0046BCB8 File Offset: 0x00469EB8
			public void Hero_OnShowGetPath(GoodsType goodsType, int goodsId, int needCount)
			{
				this.m_owner.Hero_OnShowGetPath(goodsType, goodsId, needCount);
			}

			// Token: 0x060110D7 RID: 69847 RVA: 0x0046BCC8 File Offset: 0x00469EC8
			public void HeroListUIController_OnGotoEquipmentTab()
			{
				this.m_owner.HeroListUIController_OnGotoEquipmentTab();
			}

			// Token: 0x060110D8 RID: 69848 RVA: 0x0046BCD8 File Offset: 0x00469ED8
			public void HeroListUIController_OnGotoJobTab()
			{
				this.m_owner.HeroListUIController_OnGotoJobTab();
			}

			// Token: 0x060110D9 RID: 69849 RVA: 0x0046BCE8 File Offset: 0x00469EE8
			public void HeroListUIController_OnSortToggleClick(HeroListUIController.HeroSortType type)
			{
				this.m_owner.HeroListUIController_OnSortToggleClick(type);
			}

			// Token: 0x060110DA RID: 69850 RVA: 0x0046BCF8 File Offset: 0x00469EF8
			public void CloseHeroCharChangeTask(Action closeFinisdhAction)
			{
				this.m_owner.CloseHeroCharChangeTask(closeFinisdhAction);
			}

			// Token: 0x060110DB RID: 69851 RVA: 0x0046BD08 File Offset: 0x00469F08
			public void HeroListUIController_OnHeroCharSkinChangeButtonClick()
			{
				this.m_owner.HeroListUIController_OnHeroCharSkinChangeButtonClick();
			}

			// Token: 0x060110DC RID: 69852 RVA: 0x0046BD18 File Offset: 0x00469F18
			public void HeroListUIController_OnHeroCharClick()
			{
				this.m_owner.HeroListUIController_OnHeroCharClick();
			}

			// Token: 0x060110DD RID: 69853 RVA: 0x0046BD28 File Offset: 0x00469F28
			public void HeroListUIController_OnGoToMemoryExtractionStore()
			{
				this.m_owner.HeroListUIController_OnGoToMemoryExtractionStore();
			}

			// Token: 0x060110DE RID: 69854 RVA: 0x0046BD38 File Offset: 0x00469F38
			public void Hero_OnGotoGetPath(GetPathData getPath, NeedGoods needGoods)
			{
				this.m_owner.Hero_OnGotoGetPath(getPath, needGoods);
			}

			// Token: 0x060110DF RID: 69855 RVA: 0x0046BD48 File Offset: 0x00469F48
			public void HeroDetailSoldierUIController_OnSkinInfoButtonClick(ConfigDataSoldierInfo soldierInfo)
			{
				this.m_owner.HeroDetailSoldierUIController_OnSkinInfoButtonClick(soldierInfo);
			}

			// Token: 0x060110E0 RID: 69856 RVA: 0x0046BD58 File Offset: 0x00469F58
			public void HeroDetailInfoUIController_OnSkinInfoButtonClick()
			{
				this.m_owner.HeroDetailInfoUIController_OnSkinInfoButtonClick();
			}

			// Token: 0x060110E1 RID: 69857 RVA: 0x0046BD68 File Offset: 0x00469F68
			public void HeroSoldierSkinUITask_EventOnReturn()
			{
				this.m_owner.HeroSoldierSkinUITask_EventOnReturn();
			}

			// Token: 0x060110E2 RID: 69858 RVA: 0x0046BD78 File Offset: 0x00469F78
			public void HeroDetailInfoUIController_OnJobUpButtonClick()
			{
				this.m_owner.HeroDetailInfoUIController_OnJobUpButtonClick();
			}

			// Token: 0x04009CDA RID: 40154
			private HeroListUITask m_owner;
		}
	}
}
