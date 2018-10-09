using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009DF RID: 2527
	[HotFix]
	public class HeroArchiveUIController : UIControllerBase
	{
		// Token: 0x0600957D RID: 38269 RVA: 0x002AD9D0 File Offset: 0x002ABBD0
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnClick));
			this.m_heroShowButton.onClick.AddListener(new UnityAction(this.OnHeroShowClick));
			this.m_charALLToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharFilterClick(this.m_charALLToggle.gameObject);
				}
			});
			this.m_charSSRToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharFilterClick(this.m_charSSRToggle.gameObject);
				}
			});
			this.m_charSRToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharFilterClick(this.m_charSRToggle.gameObject);
				}
			});
			this.m_charRToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.OnCharFilterClick(this.m_charRToggle.gameObject);
				}
			});
			List<Hero> heros = this.m_playerContext.GetHeros();
			this.m_messageGroupUIComponent.Init(this.m_heroMessageGroup);
			this.m_messageGroupUIComponent.SetEnglishNameText(this.m_heroEnglishNameText);
			IEnumerable<KeyValuePair<int, ConfigDataHeroInfo>> allConfigDataHeroInfo = this.m_configDataLoader.GetAllConfigDataHeroInfo();
			using (IEnumerator<KeyValuePair<int, ConfigDataHeroInfo>> enumerator = allConfigDataHeroInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, ConfigDataHeroInfo> item = enumerator.Current;
					if (item.Value.Useable)
					{
						if (item.Value.Rank != 1)
						{
							HeroArchiveUIController.HeroWrap heroWrap = new HeroArchiveUIController.HeroWrap();
							heroWrap.hero = item.Value;
							heroWrap.isUnlocked = false;
							if (heros.Find((Hero h) => h.HeroId == item.Value.ID) != null)
							{
								this.m_allOwnHeroCount++;
								heroWrap.isUnlocked = true;
								int rank = item.Value.Rank;
								if (rank != 2)
								{
									if (rank != 3)
									{
										if (rank == 4)
										{
											this.m_ssrOwnHeroCount++;
										}
									}
									else
									{
										this.m_srOwnHeroCount++;
									}
								}
								else
								{
									this.m_rOwnHeroCount++;
								}
							}
							this.m_heroAllList.Add(heroWrap);
							int rank2 = item.Value.Rank;
							if (rank2 != 2)
							{
								if (rank2 != 3)
								{
									if (rank2 == 4)
									{
										this.m_heroSSRList.Add(heroWrap);
									}
								}
								else
								{
									this.m_heroSRList.Add(heroWrap);
								}
							}
							else
							{
								this.m_heroRList.Add(heroWrap);
							}
						}
					}
				}
			}
			this.m_heroAllList.Sort(new Comparison<HeroArchiveUIController.HeroWrap>(this.HeroListCompare));
			this.HeroCountRefresh(this.m_allOwnHeroCount, this.m_heroAllList.Count);
			this.m_selectHeroList = this.m_heroAllList;
			for (int i = 0; i < this.m_heroContentInfinityGrid.MinAmount; i++)
			{
				GameObject go = GameObjectUtility.CloneGameObject(this.m_heroHeadPrefab, this.m_heroContent.transform);
				HeroHeadUIController heroHeadUIController = GameObjectUtility.AddControllerToGameObject<HeroHeadUIController>(go);
				heroHeadUIController.OnHeroHeadClickEvent += this.OnHeroHeadClick;
				this.m_heroHeadUIControllerList.Add(heroHeadUIController);
			}
			InfinityGridLayoutGroup heroContentInfinityGrid = this.m_heroContentInfinityGrid;
			heroContentInfinityGrid.updateChildrenCallback = (InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate)Delegate.Combine(heroContentInfinityGrid.updateChildrenCallback, new InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate(this.OnHeroHeadListRefresh));
			this.m_heroContentInfinityGrid.SetAmount(this.m_heroAllList.Count);
		}

		// Token: 0x0600957E RID: 38270 RVA: 0x002ADDD0 File Offset: 0x002ABFD0
		public void SetTask(ArchiveUITask task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTaskArchiveUITask_hotfix != null)
			{
				this.m_SetTaskArchiveUITask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_task = task;
		}

		// Token: 0x0600957F RID: 38271 RVA: 0x002ADE48 File Offset: 0x002AC048
		public void EnterController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnterController_hotfix != null)
			{
				this.m_EnterController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_prefabAnimation.SetToUIState("Show", false, true);
			this.m_task.CustomLoadAsset(delegate
			{
				foreach (HeroArchiveUIController.HeroWrap heroWrap in this.m_heroAllList)
				{
					ConfigDataCharImageInfo charImageInfo = heroWrap.hero.GetCharImageInfo(heroWrap.hero.Star);
					if (charImageInfo != null && heroWrap.isUnlocked)
					{
						this.m_task.CollectSpriteAssetWrap(charImageInfo.SummonHeadImage);
					}
				}
			}, delegate
			{
				this.m_task.PostDelayTimeExecuteAction(delegate
				{
					this.CreateHeroHeadList(this.m_heroAllList);
					this.m_charALLToggle.isOn = true;
				}, 0.1f);
			});
		}

		// Token: 0x06009580 RID: 38272 RVA: 0x002ADEE0 File Offset: 0x002AC0E0
		private int HeroListCompare(HeroArchiveUIController.HeroWrap heroWrap1, HeroArchiveUIController.HeroWrap heroWrap2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListCompareHeroWrapHeroWrap_hotfix != null)
			{
				return Convert.ToInt32(this.m_HeroListCompareHeroWrapHeroWrap_hotfix.call(new object[]
				{
					this,
					heroWrap1,
					heroWrap2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo hero = heroWrap1.hero;
			ConfigDataHeroInfo hero2 = heroWrap2.hero;
			return hero2.Rank - hero.Rank;
		}

		// Token: 0x06009581 RID: 38273 RVA: 0x002ADF8C File Offset: 0x002AC18C
		private List<ConfigDataJobConnectionInfo> GetHeroFinalJobList(ConfigDataHeroInfo heroInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroFinalJobListConfigDataHeroInfo_hotfix != null)
			{
				return (List<ConfigDataJobConnectionInfo>)this.m_GetHeroFinalJobListConfigDataHeroInfo_hotfix.call(new object[]
				{
					this,
					heroInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataJobConnectionInfo> list = new List<ConfigDataJobConnectionInfo>();
			foreach (ConfigDataJobConnectionInfo configDataJobConnectionInfo in heroInfo.m_useableJobConnectionInfos)
			{
				ConfigDataJobInfo configDataJobInfo = this.m_configDataLoader.GetConfigDataJobInfo(configDataJobConnectionInfo.Job_ID);
				if (configDataJobInfo.Rank == 4)
				{
					list.Add(configDataJobConnectionInfo);
				}
			}
			return list;
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x002AE058 File Offset: 0x002AC258
		public void HeroCountRefresh(int ownCount, int maxCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCountRefreshInt32Int32_hotfix != null)
			{
				this.m_HeroCountRefreshInt32Int32_hotfix.call(new object[]
				{
					this,
					ownCount,
					maxCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_ownHeroCountText.text = ownCount.ToString() + "/" + maxCount.ToString();
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x002AE108 File Offset: 0x002AC308
		private void HeroDrawRefresh(HeroHeadUIController heroHeadUIController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroDrawRefreshHeroHeadUIController_hotfix != null)
			{
				this.m_HeroDrawRefreshHeroHeadUIController_hotfix.call(new object[]
				{
					this,
					heroHeadUIController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo hero = heroHeadUIController.m_heroWrap.hero;
			if (this.m_selectHeroPainting != null)
			{
				UnityEngine.Object.Destroy(this.m_selectHeroPainting);
			}
			foreach (UISpineGraphic uispineGraphic in this.m_jobSpineGraphicList)
			{
				UnityEngine.Object.Destroy(uispineGraphic.GameObject);
			}
			this.m_jobSpineGraphicList.Clear();
			if (this.m_selectHeroWrap != null)
			{
				this.m_selectHeroWrap.isSelect = false;
				this.RefreshHeroHeadWithHeroData(this.m_selectHeroWrap);
			}
			heroHeadUIController.Selected(true);
			this.m_selectHeroWrap = heroHeadUIController.m_heroWrap;
			this.CreateHeroGraphic(this.m_selectHeroWrap);
			this.m_messageGroupUIComponent.Refresh(this.m_selectHeroWrap.hero);
			ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(hero.FragmentItem_ID);
			if (configDataItemInfo != null)
			{
				this.m_heroObtainText.text = configDataItemInfo.GetPathDesc;
			}
			this.m_introTextscrollRect.verticalNormalizedPosition = 1f;
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = this.m_configDataLoader.GetConfigDataHeroInformationInfo(hero.ID);
			if (configDataHeroInformationInfo != null)
			{
				ConfigDataHeroBiographyInfo configDataHeroBiographyInfo = this.m_configDataLoader.GetConfigDataHeroBiographyInfo(configDataHeroInformationInfo.HeroBiographies_ID[1]);
				this.m_heroIntroText.text = configDataHeroBiographyInfo.Desc;
			}
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x002AE2D8 File Offset: 0x002AC4D8
		public void CreateHeroGraphic(HeroArchiveUIController.HeroWrap heroWrap)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateHeroGraphicHeroWrap_hotfix != null)
			{
				this.m_CreateHeroGraphicHeroWrap_hotfix.call(new object[]
				{
					this,
					heroWrap2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroArchiveUIController.HeroWrap heroWrap = heroWrap2;
			HeroArchiveUIController $this = this;
			ConfigDataHeroInfo heroInfo = heroWrap.hero;
			List<ConfigDataJobConnectionInfo> jobConnectionInfoList = this.GetHeroFinalJobList(heroInfo);
			this.m_task.CustomLoadAsset(delegate
			{
				ConfigDataCharImageInfo charImageInfo = heroInfo.GetCharImageInfo(heroInfo.Star);
				if (charImageInfo != null)
				{
					$this.m_task.CollectAssetWrap(charImageInfo.HeroPainting);
				}
				foreach (ConfigDataJobConnectionInfo configDataJobConnectionInfo in jobConnectionInfoList)
				{
					if (configDataJobConnectionInfo.IsJobOpen)
					{
						if (configDataJobConnectionInfo.Model != null)
						{
							$this.m_task.CollectAssetWrap(configDataJobConnectionInfo.Model);
						}
					}
				}
			}, delegate
			{
				ConfigDataCharImageInfo charImageInfo = heroInfo.GetCharImageInfo(heroInfo.Star);
				if (!string.IsNullOrEmpty(charImageInfo.HeroPainting))
				{
					GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(charImageInfo.HeroPainting);
					$this.m_selectHeroPainting = UnityEngine.Object.Instantiate<GameObject>(asset);
					$this.m_selectHeroPainting.transform.SetParent($this.m_heroDrawShowDummy.transform, false);
					CommonUIStateController component = $this.m_selectHeroPainting.GetComponent<CommonUIStateController>();
					if (heroWrap.isUnlocked)
					{
						component.SetToUIState("Normal", false, true);
					}
					else
					{
						component.SetToUIState("Dark", false, true);
					}
				}
				foreach (ConfigDataJobConnectionInfo configDataJobConnectionInfo in jobConnectionInfoList)
				{
					if (configDataJobConnectionInfo.IsJobOpen)
					{
						if (configDataJobConnectionInfo.Model != null)
						{
							UISpineGraphic uispineGraphic = new UISpineGraphic();
							uispineGraphic.Create(configDataJobConnectionInfo.Model);
							uispineGraphic.SetParent($this.m_spineJobDummy);
							uispineGraphic.SetScale((float)configDataJobConnectionInfo.UI_ModelScale * 0.01f);
							uispineGraphic.SetPosition(new Vector3((float)configDataJobConnectionInfo.UI_ModelOffsetX, (float)configDataJobConnectionInfo.UI_ModelOffsetY, 0f));
							uispineGraphic.ForceUpdate();
							uispineGraphic.PlayAnimation("idle", true, 0);
							$this.m_jobSpineGraphicList.Add(uispineGraphic);
						}
					}
				}
			});
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x002AE3A4 File Offset: 0x002AC5A4
		private void CreateHeroHeadList(List<HeroArchiveUIController.HeroWrap> heroList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateHeroHeadListList`1_hotfix != null)
			{
				this.m_CreateHeroHeadListList`1_hotfix.call(new object[]
				{
					this,
					heroList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectHeroList = heroList;
			this.m_heroContentInfinityGrid.SetAmount(heroList.Count);
			foreach (HeroArchiveUIController.HeroWrap heroWrap in heroList)
			{
				heroWrap.isSelect = false;
			}
			if (this.m_selectHeroList.Count > 0)
			{
				this.m_task.PostDelayTimeExecuteAction(delegate
				{
					this.HeroDrawRefresh(this.m_heroHeadUIControllerList[0]);
				}, 0.1f);
			}
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x002AE4A4 File Offset: 0x002AC6A4
		private void DestroyHeroHeadList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyHeroHeadList_hotfix != null)
			{
				this.m_DestroyHeroHeadList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = this.m_heroHeadUIControllerList.Count - 1; i >= 0; i--)
			{
				UnityEngine.Object.Destroy(this.m_heroHeadUIControllerList[i].gameObject);
				this.m_heroHeadUIControllerList.RemoveAt(i);
			}
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x002AE544 File Offset: 0x002AC744
		private void RefreshHeroHeadWithHeroData(HeroArchiveUIController.HeroWrap heroWrap)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshHeroHeadWithHeroDataHeroWrap_hotfix != null)
			{
				this.m_RefreshHeroHeadWithHeroDataHeroWrap_hotfix.call(new object[]
				{
					this,
					heroWrap
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (HeroHeadUIController heroHeadUIController in this.m_heroHeadUIControllerList)
			{
				if (heroHeadUIController.m_heroWrap == heroWrap)
				{
					heroHeadUIController.RefreshDisplay();
					break;
				}
			}
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x002AE614 File Offset: 0x002AC814
		protected void OnReturnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnClick_hotfix != null)
			{
				this.m_OnReturnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_task.m_heroArchiveUIController.gameObject.SetActive(false);
				this.m_task.m_equipmentArchiveUIController.gameObject.SetActive(false);
				this.m_task.m_manualUIController.gameObject.SetActive(true);
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x002AE698 File Offset: 0x002AC898
		protected void OnCharFilterClick(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCharFilterClickGameObject_hotfix != null)
			{
				this.m_OnCharFilterClickGameObject_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (obj == this.m_charALLToggle.gameObject)
			{
				this.CreateHeroHeadList(this.m_heroAllList);
				this.HeroCountRefresh(this.m_allOwnHeroCount, this.m_heroAllList.Count);
			}
			else if (obj == this.m_charSSRToggle.gameObject)
			{
				this.CreateHeroHeadList(this.m_heroSSRList);
				this.HeroCountRefresh(this.m_ssrOwnHeroCount, this.m_heroSSRList.Count);
			}
			else if (obj == this.m_charSRToggle.gameObject)
			{
				this.CreateHeroHeadList(this.m_heroSRList);
				this.HeroCountRefresh(this.m_srOwnHeroCount, this.m_heroSRList.Count);
			}
			else if (obj == this.m_charRToggle.gameObject)
			{
				this.CreateHeroHeadList(this.m_heroRList);
				this.HeroCountRefresh(this.m_rOwnHeroCount, this.m_heroRList.Count);
			}
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x002AE7FC File Offset: 0x002AC9FC
		private void OnHeroHeadClick(HeroHeadUIController heroHeadUIController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroHeadClickHeroHeadUIController_hotfix != null)
			{
				this.m_OnHeroHeadClickHeroHeadUIController_hotfix.call(new object[]
				{
					this,
					heroHeadUIController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HeroDrawRefresh(heroHeadUIController);
		}

		// Token: 0x0600958B RID: 38283 RVA: 0x002AE874 File Offset: 0x002ACA74
		private void OnHeroShowClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroShowClick_hotfix != null)
			{
				this.m_OnHeroShowClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_task.m_heroArchiveUIController.gameObject.SetActive(false);
				this.m_task.m_heroShowUIController.gameObject.SetActive(true);
				if (this.m_selectHeroWrap != null)
				{
					int rank = this.m_selectHeroWrap.hero.Rank;
					this.m_task.m_heroShowUIController.SwitchShowRankHero(rank);
				}
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x002AE8F8 File Offset: 0x002ACAF8
		private void OnHeroHeadListRefresh(int index, Transform trans)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroHeadListRefreshInt32Transform_hotfix != null)
			{
				this.m_OnHeroHeadListRefreshInt32Transform_hotfix.call(new object[]
				{
					this,
					index,
					trans
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (index > this.m_selectHeroList.Count - 1)
			{
				return;
			}
			HeroArchiveUIController.HeroWrap heroWrap = this.m_selectHeroList[index];
			HeroHeadUIController component = trans.GetComponent<HeroHeadUIController>();
			component.SetHeroWrap(heroWrap);
			component.RefreshDisplay();
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x0600958D RID: 38285 RVA: 0x002AE9B0 File Offset: 0x002ACBB0
		// (set) Token: 0x0600958E RID: 38286 RVA: 0x002AE9D0 File Offset: 0x002ACBD0
		[DoNotToLua]
		public new HeroArchiveUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroArchiveUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600958F RID: 38287 RVA: 0x002AE9DC File Offset: 0x002ACBDC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009590 RID: 38288 RVA: 0x002AE9E8 File Offset: 0x002ACBE8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009591 RID: 38289 RVA: 0x002AE9F0 File Offset: 0x002ACBF0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009592 RID: 38290 RVA: 0x002AE9F8 File Offset: 0x002ACBF8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009593 RID: 38291 RVA: 0x002AEA0C File Offset: 0x002ACC0C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009594 RID: 38292 RVA: 0x002AEA14 File Offset: 0x002ACC14
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009595 RID: 38293 RVA: 0x002AEA20 File Offset: 0x002ACC20
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009596 RID: 38294 RVA: 0x002AEA2C File Offset: 0x002ACC2C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009597 RID: 38295 RVA: 0x002AEA38 File Offset: 0x002ACC38
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009598 RID: 38296 RVA: 0x002AEA44 File Offset: 0x002ACC44
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009599 RID: 38297 RVA: 0x002AEA50 File Offset: 0x002ACC50
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600959A RID: 38298 RVA: 0x002AEA5C File Offset: 0x002ACC5C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600959B RID: 38299 RVA: 0x002AEA68 File Offset: 0x002ACC68
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600959C RID: 38300 RVA: 0x002AEA74 File Offset: 0x002ACC74
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600959D RID: 38301 RVA: 0x002AEA80 File Offset: 0x002ACC80
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060095A8 RID: 38312 RVA: 0x002AECA4 File Offset: 0x002ACEA4
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
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_SetTaskArchiveUITask_hotfix = (luaObj.RawGet("SetTask") as LuaFunction);
					this.m_EnterController_hotfix = (luaObj.RawGet("EnterController") as LuaFunction);
					this.m_HeroListCompareHeroWrapHeroWrap_hotfix = (luaObj.RawGet("HeroListCompare") as LuaFunction);
					this.m_GetHeroFinalJobListConfigDataHeroInfo_hotfix = (luaObj.RawGet("GetHeroFinalJobList") as LuaFunction);
					this.m_HeroCountRefreshInt32Int32_hotfix = (luaObj.RawGet("HeroCountRefresh") as LuaFunction);
					this.m_HeroDrawRefreshHeroHeadUIController_hotfix = (luaObj.RawGet("HeroDrawRefresh") as LuaFunction);
					this.m_CreateHeroGraphicHeroWrap_hotfix = (luaObj.RawGet("CreateHeroGraphic") as LuaFunction);
					this.m_CreateHeroHeadListList`1_hotfix = (luaObj.RawGet("CreateHeroHeadList") as LuaFunction);
					this.m_DestroyHeroHeadList_hotfix = (luaObj.RawGet("DestroyHeroHeadList") as LuaFunction);
					this.m_RefreshHeroHeadWithHeroDataHeroWrap_hotfix = (luaObj.RawGet("RefreshHeroHeadWithHeroData") as LuaFunction);
					this.m_OnReturnClick_hotfix = (luaObj.RawGet("OnReturnClick") as LuaFunction);
					this.m_OnCharFilterClickGameObject_hotfix = (luaObj.RawGet("OnCharFilterClick") as LuaFunction);
					this.m_OnHeroHeadClickHeroHeadUIController_hotfix = (luaObj.RawGet("OnHeroHeadClick") as LuaFunction);
					this.m_OnHeroShowClick_hotfix = (luaObj.RawGet("OnHeroShowClick") as LuaFunction);
					this.m_OnHeroHeadListRefreshInt32Transform_hotfix = (luaObj.RawGet("OnHeroHeadListRefresh") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060095A9 RID: 38313 RVA: 0x002AEEE8 File Offset: 0x002AD0E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroArchiveUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006750 RID: 26448
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_prefabAnimation;

		// Token: 0x04006751 RID: 26449
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04006752 RID: 26450
		[AutoBind("./Margin/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroShowButton;

		// Token: 0x04006753 RID: 26451
		[AutoBind("./HeroListGroup/Scroll View", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_heroScrollRect;

		// Token: 0x04006754 RID: 26452
		[AutoBind("./HeroListGroup/Scroll View/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroContent;

		// Token: 0x04006755 RID: 26453
		[AutoBind("./HeroListGroup/Scroll View/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private InfinityGridLayoutGroup m_heroContentInfinityGrid;

		// Token: 0x04006756 RID: 26454
		[AutoBind("./Prefab/HeroHeadPrefab", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroHeadPrefab;

		// Token: 0x04006757 RID: 26455
		[AutoBind("./CountLimit/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_ownHeroCountText;

		// Token: 0x04006758 RID: 26456
		[AutoBind("./HeroGroup/HeroEnglishNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroEnglishNameText;

		// Token: 0x04006759 RID: 26457
		[AutoBind("./HeroGroup/PaperRightImage/JobPatternTitleBgImage/SpineGroupDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_spineJobDummy;

		// Token: 0x0400675A RID: 26458
		[AutoBind("./HeroGroup/PaperRightImage/HeroPatternTitle/HeroDescScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_introTextscrollRect;

		// Token: 0x0400675B RID: 26459
		[AutoBind("./HeroGroup/PaperRightImage/HeroPatternTitle/HeroDescScrollView/Viewport/Content/HeroMoreText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroIntroText;

		// Token: 0x0400675C RID: 26460
		[AutoBind("./HeroGroup/PaperRightImage/ApproachPatternTitleBgImage/ExplainText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroObtainText;

		// Token: 0x0400675D RID: 26461
		[AutoBind("./HeroGroup/HeroDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroDrawShowDummy;

		// Token: 0x0400675E RID: 26462
		[AutoBind("./HeroGroup/HeroMessageGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroMessageGroup;

		// Token: 0x0400675F RID: 26463
		[AutoBind("./HeroGroup/GradeToggle/All", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charALLToggle;

		// Token: 0x04006760 RID: 26464
		[AutoBind("./HeroGroup/GradeToggle/SSR", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charSSRToggle;

		// Token: 0x04006761 RID: 26465
		[AutoBind("./HeroGroup/GradeToggle/SR", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charSRToggle;

		// Token: 0x04006762 RID: 26466
		[AutoBind("./HeroGroup/GradeToggle/R", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_charRToggle;

		// Token: 0x04006763 RID: 26467
		private HeroMessageGroupUIComponent m_messageGroupUIComponent = new HeroMessageGroupUIComponent();

		// Token: 0x04006764 RID: 26468
		private ArchiveUITask m_task;

		// Token: 0x04006765 RID: 26469
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04006766 RID: 26470
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04006767 RID: 26471
		private List<HeroArchiveUIController.HeroWrap> m_selectHeroList;

		// Token: 0x04006768 RID: 26472
		private List<HeroArchiveUIController.HeroWrap> m_heroAllList = new List<HeroArchiveUIController.HeroWrap>();

		// Token: 0x04006769 RID: 26473
		private List<HeroArchiveUIController.HeroWrap> m_heroSSRList = new List<HeroArchiveUIController.HeroWrap>();

		// Token: 0x0400676A RID: 26474
		private List<HeroArchiveUIController.HeroWrap> m_heroSRList = new List<HeroArchiveUIController.HeroWrap>();

		// Token: 0x0400676B RID: 26475
		private List<HeroArchiveUIController.HeroWrap> m_heroRList = new List<HeroArchiveUIController.HeroWrap>();

		// Token: 0x0400676C RID: 26476
		private List<HeroHeadUIController> m_heroHeadUIControllerList = new List<HeroHeadUIController>();

		// Token: 0x0400676D RID: 26477
		private HeroArchiveUIController.HeroWrap m_selectHeroWrap;

		// Token: 0x0400676E RID: 26478
		private GameObject m_selectHeroPainting;

		// Token: 0x0400676F RID: 26479
		private List<UISpineGraphic> m_jobSpineGraphicList = new List<UISpineGraphic>();

		// Token: 0x04006770 RID: 26480
		private int m_allOwnHeroCount;

		// Token: 0x04006771 RID: 26481
		private int m_ssrOwnHeroCount;

		// Token: 0x04006772 RID: 26482
		private int m_srOwnHeroCount;

		// Token: 0x04006773 RID: 26483
		private int m_rOwnHeroCount;

		// Token: 0x04006774 RID: 26484
		private const int FinalJobRank = 4;

		// Token: 0x04006775 RID: 26485
		[DoNotToLua]
		private HeroArchiveUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006776 RID: 26486
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006777 RID: 26487
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006778 RID: 26488
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006779 RID: 26489
		private LuaFunction m_SetTaskArchiveUITask_hotfix;

		// Token: 0x0400677A RID: 26490
		private LuaFunction m_EnterController_hotfix;

		// Token: 0x0400677B RID: 26491
		private LuaFunction m_HeroListCompareHeroWrapHeroWrap_hotfix;

		// Token: 0x0400677C RID: 26492
		private LuaFunction m_GetHeroFinalJobListConfigDataHeroInfo_hotfix;

		// Token: 0x0400677D RID: 26493
		private LuaFunction m_HeroCountRefreshInt32Int32_hotfix;

		// Token: 0x0400677E RID: 26494
		private LuaFunction m_HeroDrawRefreshHeroHeadUIController_hotfix;

		// Token: 0x0400677F RID: 26495
		private LuaFunction m_CreateHeroGraphicHeroWrap_hotfix;

		// Token: 0x04006780 RID: 26496
		private LuaFunction m_CreateHeroHeadListList;

		// Token: 0x04006781 RID: 26497
		private LuaFunction m_DestroyHeroHeadList_hotfix;

		// Token: 0x04006782 RID: 26498
		private LuaFunction m_RefreshHeroHeadWithHeroDataHeroWrap_hotfix;

		// Token: 0x04006783 RID: 26499
		private LuaFunction m_OnReturnClick_hotfix;

		// Token: 0x04006784 RID: 26500
		private LuaFunction m_OnCharFilterClickGameObject_hotfix;

		// Token: 0x04006785 RID: 26501
		private LuaFunction m_OnHeroHeadClickHeroHeadUIController_hotfix;

		// Token: 0x04006786 RID: 26502
		private LuaFunction m_OnHeroShowClick_hotfix;

		// Token: 0x04006787 RID: 26503
		private LuaFunction m_OnHeroHeadListRefreshInt32Transform_hotfix;

		// Token: 0x020009E0 RID: 2528
		[HotFix]
		public class HeroWrap
		{
			// Token: 0x04006788 RID: 26504
			public ConfigDataHeroInfo hero;

			// Token: 0x04006789 RID: 26505
			public bool isUnlocked;

			// Token: 0x0400678A RID: 26506
			public bool isSelect;
		}

		// Token: 0x020009E1 RID: 2529
		public new class LuaExportHelper
		{
			// Token: 0x060095AB RID: 38315 RVA: 0x002AEF58 File Offset: 0x002AD158
			public LuaExportHelper(HeroArchiveUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060095AC RID: 38316 RVA: 0x002AEF68 File Offset: 0x002AD168
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060095AD RID: 38317 RVA: 0x002AEF78 File Offset: 0x002AD178
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060095AE RID: 38318 RVA: 0x002AEF88 File Offset: 0x002AD188
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060095AF RID: 38319 RVA: 0x002AEF98 File Offset: 0x002AD198
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060095B0 RID: 38320 RVA: 0x002AEFB0 File Offset: 0x002AD1B0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060095B1 RID: 38321 RVA: 0x002AEFC0 File Offset: 0x002AD1C0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060095B2 RID: 38322 RVA: 0x002AEFD0 File Offset: 0x002AD1D0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060095B3 RID: 38323 RVA: 0x002AEFE0 File Offset: 0x002AD1E0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060095B4 RID: 38324 RVA: 0x002AEFF0 File Offset: 0x002AD1F0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060095B5 RID: 38325 RVA: 0x002AF000 File Offset: 0x002AD200
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060095B6 RID: 38326 RVA: 0x002AF010 File Offset: 0x002AD210
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060095B7 RID: 38327 RVA: 0x002AF020 File Offset: 0x002AD220
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060095B8 RID: 38328 RVA: 0x002AF030 File Offset: 0x002AD230
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060095B9 RID: 38329 RVA: 0x002AF040 File Offset: 0x002AD240
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060095BA RID: 38330 RVA: 0x002AF050 File Offset: 0x002AD250
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17001ED2 RID: 7890
			// (get) Token: 0x060095BB RID: 38331 RVA: 0x002AF060 File Offset: 0x002AD260
			// (set) Token: 0x060095BC RID: 38332 RVA: 0x002AF070 File Offset: 0x002AD270
			public CommonUIStateController m_prefabAnimation
			{
				get
				{
					return this.m_owner.m_prefabAnimation;
				}
				set
				{
					this.m_owner.m_prefabAnimation = value;
				}
			}

			// Token: 0x17001ED3 RID: 7891
			// (get) Token: 0x060095BD RID: 38333 RVA: 0x002AF080 File Offset: 0x002AD280
			// (set) Token: 0x060095BE RID: 38334 RVA: 0x002AF090 File Offset: 0x002AD290
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17001ED4 RID: 7892
			// (get) Token: 0x060095BF RID: 38335 RVA: 0x002AF0A0 File Offset: 0x002AD2A0
			// (set) Token: 0x060095C0 RID: 38336 RVA: 0x002AF0B0 File Offset: 0x002AD2B0
			public Button m_heroShowButton
			{
				get
				{
					return this.m_owner.m_heroShowButton;
				}
				set
				{
					this.m_owner.m_heroShowButton = value;
				}
			}

			// Token: 0x17001ED5 RID: 7893
			// (get) Token: 0x060095C1 RID: 38337 RVA: 0x002AF0C0 File Offset: 0x002AD2C0
			// (set) Token: 0x060095C2 RID: 38338 RVA: 0x002AF0D0 File Offset: 0x002AD2D0
			public ScrollRect m_heroScrollRect
			{
				get
				{
					return this.m_owner.m_heroScrollRect;
				}
				set
				{
					this.m_owner.m_heroScrollRect = value;
				}
			}

			// Token: 0x17001ED6 RID: 7894
			// (get) Token: 0x060095C3 RID: 38339 RVA: 0x002AF0E0 File Offset: 0x002AD2E0
			// (set) Token: 0x060095C4 RID: 38340 RVA: 0x002AF0F0 File Offset: 0x002AD2F0
			public GameObject m_heroContent
			{
				get
				{
					return this.m_owner.m_heroContent;
				}
				set
				{
					this.m_owner.m_heroContent = value;
				}
			}

			// Token: 0x17001ED7 RID: 7895
			// (get) Token: 0x060095C5 RID: 38341 RVA: 0x002AF100 File Offset: 0x002AD300
			// (set) Token: 0x060095C6 RID: 38342 RVA: 0x002AF110 File Offset: 0x002AD310
			public InfinityGridLayoutGroup m_heroContentInfinityGrid
			{
				get
				{
					return this.m_owner.m_heroContentInfinityGrid;
				}
				set
				{
					this.m_owner.m_heroContentInfinityGrid = value;
				}
			}

			// Token: 0x17001ED8 RID: 7896
			// (get) Token: 0x060095C7 RID: 38343 RVA: 0x002AF120 File Offset: 0x002AD320
			// (set) Token: 0x060095C8 RID: 38344 RVA: 0x002AF130 File Offset: 0x002AD330
			public GameObject m_heroHeadPrefab
			{
				get
				{
					return this.m_owner.m_heroHeadPrefab;
				}
				set
				{
					this.m_owner.m_heroHeadPrefab = value;
				}
			}

			// Token: 0x17001ED9 RID: 7897
			// (get) Token: 0x060095C9 RID: 38345 RVA: 0x002AF140 File Offset: 0x002AD340
			// (set) Token: 0x060095CA RID: 38346 RVA: 0x002AF150 File Offset: 0x002AD350
			public Text m_ownHeroCountText
			{
				get
				{
					return this.m_owner.m_ownHeroCountText;
				}
				set
				{
					this.m_owner.m_ownHeroCountText = value;
				}
			}

			// Token: 0x17001EDA RID: 7898
			// (get) Token: 0x060095CB RID: 38347 RVA: 0x002AF160 File Offset: 0x002AD360
			// (set) Token: 0x060095CC RID: 38348 RVA: 0x002AF170 File Offset: 0x002AD370
			public Text m_heroEnglishNameText
			{
				get
				{
					return this.m_owner.m_heroEnglishNameText;
				}
				set
				{
					this.m_owner.m_heroEnglishNameText = value;
				}
			}

			// Token: 0x17001EDB RID: 7899
			// (get) Token: 0x060095CD RID: 38349 RVA: 0x002AF180 File Offset: 0x002AD380
			// (set) Token: 0x060095CE RID: 38350 RVA: 0x002AF190 File Offset: 0x002AD390
			public GameObject m_spineJobDummy
			{
				get
				{
					return this.m_owner.m_spineJobDummy;
				}
				set
				{
					this.m_owner.m_spineJobDummy = value;
				}
			}

			// Token: 0x17001EDC RID: 7900
			// (get) Token: 0x060095CF RID: 38351 RVA: 0x002AF1A0 File Offset: 0x002AD3A0
			// (set) Token: 0x060095D0 RID: 38352 RVA: 0x002AF1B0 File Offset: 0x002AD3B0
			public ScrollRect m_introTextscrollRect
			{
				get
				{
					return this.m_owner.m_introTextscrollRect;
				}
				set
				{
					this.m_owner.m_introTextscrollRect = value;
				}
			}

			// Token: 0x17001EDD RID: 7901
			// (get) Token: 0x060095D1 RID: 38353 RVA: 0x002AF1C0 File Offset: 0x002AD3C0
			// (set) Token: 0x060095D2 RID: 38354 RVA: 0x002AF1D0 File Offset: 0x002AD3D0
			public Text m_heroIntroText
			{
				get
				{
					return this.m_owner.m_heroIntroText;
				}
				set
				{
					this.m_owner.m_heroIntroText = value;
				}
			}

			// Token: 0x17001EDE RID: 7902
			// (get) Token: 0x060095D3 RID: 38355 RVA: 0x002AF1E0 File Offset: 0x002AD3E0
			// (set) Token: 0x060095D4 RID: 38356 RVA: 0x002AF1F0 File Offset: 0x002AD3F0
			public Text m_heroObtainText
			{
				get
				{
					return this.m_owner.m_heroObtainText;
				}
				set
				{
					this.m_owner.m_heroObtainText = value;
				}
			}

			// Token: 0x17001EDF RID: 7903
			// (get) Token: 0x060095D5 RID: 38357 RVA: 0x002AF200 File Offset: 0x002AD400
			// (set) Token: 0x060095D6 RID: 38358 RVA: 0x002AF210 File Offset: 0x002AD410
			public GameObject m_heroDrawShowDummy
			{
				get
				{
					return this.m_owner.m_heroDrawShowDummy;
				}
				set
				{
					this.m_owner.m_heroDrawShowDummy = value;
				}
			}

			// Token: 0x17001EE0 RID: 7904
			// (get) Token: 0x060095D7 RID: 38359 RVA: 0x002AF220 File Offset: 0x002AD420
			// (set) Token: 0x060095D8 RID: 38360 RVA: 0x002AF230 File Offset: 0x002AD430
			public GameObject m_heroMessageGroup
			{
				get
				{
					return this.m_owner.m_heroMessageGroup;
				}
				set
				{
					this.m_owner.m_heroMessageGroup = value;
				}
			}

			// Token: 0x17001EE1 RID: 7905
			// (get) Token: 0x060095D9 RID: 38361 RVA: 0x002AF240 File Offset: 0x002AD440
			// (set) Token: 0x060095DA RID: 38362 RVA: 0x002AF250 File Offset: 0x002AD450
			public Toggle m_charALLToggle
			{
				get
				{
					return this.m_owner.m_charALLToggle;
				}
				set
				{
					this.m_owner.m_charALLToggle = value;
				}
			}

			// Token: 0x17001EE2 RID: 7906
			// (get) Token: 0x060095DB RID: 38363 RVA: 0x002AF260 File Offset: 0x002AD460
			// (set) Token: 0x060095DC RID: 38364 RVA: 0x002AF270 File Offset: 0x002AD470
			public Toggle m_charSSRToggle
			{
				get
				{
					return this.m_owner.m_charSSRToggle;
				}
				set
				{
					this.m_owner.m_charSSRToggle = value;
				}
			}

			// Token: 0x17001EE3 RID: 7907
			// (get) Token: 0x060095DD RID: 38365 RVA: 0x002AF280 File Offset: 0x002AD480
			// (set) Token: 0x060095DE RID: 38366 RVA: 0x002AF290 File Offset: 0x002AD490
			public Toggle m_charSRToggle
			{
				get
				{
					return this.m_owner.m_charSRToggle;
				}
				set
				{
					this.m_owner.m_charSRToggle = value;
				}
			}

			// Token: 0x17001EE4 RID: 7908
			// (get) Token: 0x060095DF RID: 38367 RVA: 0x002AF2A0 File Offset: 0x002AD4A0
			// (set) Token: 0x060095E0 RID: 38368 RVA: 0x002AF2B0 File Offset: 0x002AD4B0
			public Toggle m_charRToggle
			{
				get
				{
					return this.m_owner.m_charRToggle;
				}
				set
				{
					this.m_owner.m_charRToggle = value;
				}
			}

			// Token: 0x17001EE5 RID: 7909
			// (get) Token: 0x060095E1 RID: 38369 RVA: 0x002AF2C0 File Offset: 0x002AD4C0
			// (set) Token: 0x060095E2 RID: 38370 RVA: 0x002AF2D0 File Offset: 0x002AD4D0
			public HeroMessageGroupUIComponent m_messageGroupUIComponent
			{
				get
				{
					return this.m_owner.m_messageGroupUIComponent;
				}
				set
				{
					this.m_owner.m_messageGroupUIComponent = value;
				}
			}

			// Token: 0x17001EE6 RID: 7910
			// (get) Token: 0x060095E3 RID: 38371 RVA: 0x002AF2E0 File Offset: 0x002AD4E0
			// (set) Token: 0x060095E4 RID: 38372 RVA: 0x002AF2F0 File Offset: 0x002AD4F0
			public ArchiveUITask m_task
			{
				get
				{
					return this.m_owner.m_task;
				}
				set
				{
					this.m_owner.m_task = value;
				}
			}

			// Token: 0x17001EE7 RID: 7911
			// (get) Token: 0x060095E5 RID: 38373 RVA: 0x002AF300 File Offset: 0x002AD500
			// (set) Token: 0x060095E6 RID: 38374 RVA: 0x002AF310 File Offset: 0x002AD510
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

			// Token: 0x17001EE8 RID: 7912
			// (get) Token: 0x060095E7 RID: 38375 RVA: 0x002AF320 File Offset: 0x002AD520
			// (set) Token: 0x060095E8 RID: 38376 RVA: 0x002AF330 File Offset: 0x002AD530
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

			// Token: 0x17001EE9 RID: 7913
			// (get) Token: 0x060095E9 RID: 38377 RVA: 0x002AF340 File Offset: 0x002AD540
			// (set) Token: 0x060095EA RID: 38378 RVA: 0x002AF350 File Offset: 0x002AD550
			public List<HeroArchiveUIController.HeroWrap> m_selectHeroList
			{
				get
				{
					return this.m_owner.m_selectHeroList;
				}
				set
				{
					this.m_owner.m_selectHeroList = value;
				}
			}

			// Token: 0x17001EEA RID: 7914
			// (get) Token: 0x060095EB RID: 38379 RVA: 0x002AF360 File Offset: 0x002AD560
			// (set) Token: 0x060095EC RID: 38380 RVA: 0x002AF370 File Offset: 0x002AD570
			public List<HeroArchiveUIController.HeroWrap> m_heroAllList
			{
				get
				{
					return this.m_owner.m_heroAllList;
				}
				set
				{
					this.m_owner.m_heroAllList = value;
				}
			}

			// Token: 0x17001EEB RID: 7915
			// (get) Token: 0x060095ED RID: 38381 RVA: 0x002AF380 File Offset: 0x002AD580
			// (set) Token: 0x060095EE RID: 38382 RVA: 0x002AF390 File Offset: 0x002AD590
			public List<HeroArchiveUIController.HeroWrap> m_heroSSRList
			{
				get
				{
					return this.m_owner.m_heroSSRList;
				}
				set
				{
					this.m_owner.m_heroSSRList = value;
				}
			}

			// Token: 0x17001EEC RID: 7916
			// (get) Token: 0x060095EF RID: 38383 RVA: 0x002AF3A0 File Offset: 0x002AD5A0
			// (set) Token: 0x060095F0 RID: 38384 RVA: 0x002AF3B0 File Offset: 0x002AD5B0
			public List<HeroArchiveUIController.HeroWrap> m_heroSRList
			{
				get
				{
					return this.m_owner.m_heroSRList;
				}
				set
				{
					this.m_owner.m_heroSRList = value;
				}
			}

			// Token: 0x17001EED RID: 7917
			// (get) Token: 0x060095F1 RID: 38385 RVA: 0x002AF3C0 File Offset: 0x002AD5C0
			// (set) Token: 0x060095F2 RID: 38386 RVA: 0x002AF3D0 File Offset: 0x002AD5D0
			public List<HeroArchiveUIController.HeroWrap> m_heroRList
			{
				get
				{
					return this.m_owner.m_heroRList;
				}
				set
				{
					this.m_owner.m_heroRList = value;
				}
			}

			// Token: 0x17001EEE RID: 7918
			// (get) Token: 0x060095F3 RID: 38387 RVA: 0x002AF3E0 File Offset: 0x002AD5E0
			// (set) Token: 0x060095F4 RID: 38388 RVA: 0x002AF3F0 File Offset: 0x002AD5F0
			public List<HeroHeadUIController> m_heroHeadUIControllerList
			{
				get
				{
					return this.m_owner.m_heroHeadUIControllerList;
				}
				set
				{
					this.m_owner.m_heroHeadUIControllerList = value;
				}
			}

			// Token: 0x17001EEF RID: 7919
			// (get) Token: 0x060095F5 RID: 38389 RVA: 0x002AF400 File Offset: 0x002AD600
			// (set) Token: 0x060095F6 RID: 38390 RVA: 0x002AF410 File Offset: 0x002AD610
			public HeroArchiveUIController.HeroWrap m_selectHeroWrap
			{
				get
				{
					return this.m_owner.m_selectHeroWrap;
				}
				set
				{
					this.m_owner.m_selectHeroWrap = value;
				}
			}

			// Token: 0x17001EF0 RID: 7920
			// (get) Token: 0x060095F7 RID: 38391 RVA: 0x002AF420 File Offset: 0x002AD620
			// (set) Token: 0x060095F8 RID: 38392 RVA: 0x002AF430 File Offset: 0x002AD630
			public GameObject m_selectHeroPainting
			{
				get
				{
					return this.m_owner.m_selectHeroPainting;
				}
				set
				{
					this.m_owner.m_selectHeroPainting = value;
				}
			}

			// Token: 0x17001EF1 RID: 7921
			// (get) Token: 0x060095F9 RID: 38393 RVA: 0x002AF440 File Offset: 0x002AD640
			// (set) Token: 0x060095FA RID: 38394 RVA: 0x002AF450 File Offset: 0x002AD650
			public List<UISpineGraphic> m_jobSpineGraphicList
			{
				get
				{
					return this.m_owner.m_jobSpineGraphicList;
				}
				set
				{
					this.m_owner.m_jobSpineGraphicList = value;
				}
			}

			// Token: 0x17001EF2 RID: 7922
			// (get) Token: 0x060095FB RID: 38395 RVA: 0x002AF460 File Offset: 0x002AD660
			// (set) Token: 0x060095FC RID: 38396 RVA: 0x002AF470 File Offset: 0x002AD670
			public int m_allOwnHeroCount
			{
				get
				{
					return this.m_owner.m_allOwnHeroCount;
				}
				set
				{
					this.m_owner.m_allOwnHeroCount = value;
				}
			}

			// Token: 0x17001EF3 RID: 7923
			// (get) Token: 0x060095FD RID: 38397 RVA: 0x002AF480 File Offset: 0x002AD680
			// (set) Token: 0x060095FE RID: 38398 RVA: 0x002AF490 File Offset: 0x002AD690
			public int m_ssrOwnHeroCount
			{
				get
				{
					return this.m_owner.m_ssrOwnHeroCount;
				}
				set
				{
					this.m_owner.m_ssrOwnHeroCount = value;
				}
			}

			// Token: 0x17001EF4 RID: 7924
			// (get) Token: 0x060095FF RID: 38399 RVA: 0x002AF4A0 File Offset: 0x002AD6A0
			// (set) Token: 0x06009600 RID: 38400 RVA: 0x002AF4B0 File Offset: 0x002AD6B0
			public int m_srOwnHeroCount
			{
				get
				{
					return this.m_owner.m_srOwnHeroCount;
				}
				set
				{
					this.m_owner.m_srOwnHeroCount = value;
				}
			}

			// Token: 0x17001EF5 RID: 7925
			// (get) Token: 0x06009601 RID: 38401 RVA: 0x002AF4C0 File Offset: 0x002AD6C0
			// (set) Token: 0x06009602 RID: 38402 RVA: 0x002AF4D0 File Offset: 0x002AD6D0
			public int m_rOwnHeroCount
			{
				get
				{
					return this.m_owner.m_rOwnHeroCount;
				}
				set
				{
					this.m_owner.m_rOwnHeroCount = value;
				}
			}

			// Token: 0x17001EF6 RID: 7926
			// (get) Token: 0x06009603 RID: 38403 RVA: 0x002AF4E0 File Offset: 0x002AD6E0
			public static int FinalJobRank
			{
				get
				{
					return 4;
				}
			}

			// Token: 0x06009604 RID: 38404 RVA: 0x002AF4E4 File Offset: 0x002AD6E4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06009605 RID: 38405 RVA: 0x002AF4F4 File Offset: 0x002AD6F4
			public int HeroListCompare(HeroArchiveUIController.HeroWrap heroWrap1, HeroArchiveUIController.HeroWrap heroWrap2)
			{
				return this.m_owner.HeroListCompare(heroWrap1, heroWrap2);
			}

			// Token: 0x06009606 RID: 38406 RVA: 0x002AF504 File Offset: 0x002AD704
			public List<ConfigDataJobConnectionInfo> GetHeroFinalJobList(ConfigDataHeroInfo heroInfo)
			{
				return this.m_owner.GetHeroFinalJobList(heroInfo);
			}

			// Token: 0x06009607 RID: 38407 RVA: 0x002AF514 File Offset: 0x002AD714
			public void HeroDrawRefresh(HeroHeadUIController heroHeadUIController)
			{
				this.m_owner.HeroDrawRefresh(heroHeadUIController);
			}

			// Token: 0x06009608 RID: 38408 RVA: 0x002AF524 File Offset: 0x002AD724
			public void CreateHeroHeadList(List<HeroArchiveUIController.HeroWrap> heroList)
			{
				this.m_owner.CreateHeroHeadList(heroList);
			}

			// Token: 0x06009609 RID: 38409 RVA: 0x002AF534 File Offset: 0x002AD734
			public void DestroyHeroHeadList()
			{
				this.m_owner.DestroyHeroHeadList();
			}

			// Token: 0x0600960A RID: 38410 RVA: 0x002AF544 File Offset: 0x002AD744
			public void RefreshHeroHeadWithHeroData(HeroArchiveUIController.HeroWrap heroWrap)
			{
				this.m_owner.RefreshHeroHeadWithHeroData(heroWrap);
			}

			// Token: 0x0600960B RID: 38411 RVA: 0x002AF554 File Offset: 0x002AD754
			public void OnReturnClick()
			{
				this.m_owner.OnReturnClick();
			}

			// Token: 0x0600960C RID: 38412 RVA: 0x002AF564 File Offset: 0x002AD764
			public void OnCharFilterClick(GameObject obj)
			{
				this.m_owner.OnCharFilterClick(obj);
			}

			// Token: 0x0600960D RID: 38413 RVA: 0x002AF574 File Offset: 0x002AD774
			public void OnHeroHeadClick(HeroHeadUIController heroHeadUIController)
			{
				this.m_owner.OnHeroHeadClick(heroHeadUIController);
			}

			// Token: 0x0600960E RID: 38414 RVA: 0x002AF584 File Offset: 0x002AD784
			public void OnHeroShowClick()
			{
				this.m_owner.OnHeroShowClick();
			}

			// Token: 0x0600960F RID: 38415 RVA: 0x002AF594 File Offset: 0x002AD794
			public void OnHeroHeadListRefresh(int index, Transform trans)
			{
				this.m_owner.OnHeroHeadListRefresh(index, trans);
			}

			// Token: 0x0400678B RID: 26507
			private HeroArchiveUIController m_owner;
		}
	}
}
