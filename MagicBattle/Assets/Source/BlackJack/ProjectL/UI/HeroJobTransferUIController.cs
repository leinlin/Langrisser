using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
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
	// Token: 0x02000DBD RID: 3517
	[HotFix]
	public class HeroJobTransferUIController : UIControllerBase
	{
		// Token: 0x06010B92 RID: 68498 RVA: 0x00456ADC File Offset: 0x00454CDC
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
			this.m_goldAddBtn.onClick.AddListener(new UnityAction(this.OnGoldAddButtonClick));
			this.m_magicStoneBtn.onClick.AddListener(new UnityAction(this.OnMagicStoneClick));
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_masterButton.onClick.AddListener(new UnityAction(this.OnMasterRewardButtonClick));
			this.m_learnedPanelCloseBtn.onClick.AddListener(new UnityAction(this.CloseLearnedPanel));
			this.m_jobUnlockButton.onClick.AddListener(new UnityAction(this.OnJobUnlockButtonClick));
			this.m_jobTransferEffectSkipBtn.onClick.AddListener(new UnityAction(this.OnSkipBtnClick));
			this.m_jobTransferButton.onClick.AddListener(new UnityAction(this.OnJobTransferButtonClick));
			this.m_confirmBgButton.onClick.AddListener(new UnityAction(this.CloseJobTransferConfirmPanel));
			this.m_confirmReturnButton.onClick.AddListener(new UnityAction(this.CloseJobTransferConfirmPanel));
			this.m_learnedPanelSkillCloseBtn.onClick.AddListener(new UnityAction(this.CloseLearnedSkillPanel));
			this.m_masterInfoPanelReturnButton.onClick.AddListener(new UnityAction(this.CloseMasterInfoPanel));
			this.m_confirmTransferButton.onClick.AddListener(new UnityAction(this.OnJobTransferConfirmButtonClick));
			this.m_transferLockConfirmButton.onClick.AddListener(new UnityAction(this.CloseJobTransferLockedPanel));
			this.m_transferLockPanelReturnBg.onClick.AddListener(new UnityAction(this.CloseJobTransferLockedPanel));
			this.m_unLockHeroJobReturnButton.onClick.AddListener(new UnityAction(this.OnUnLockHeroJobReturnButtonClick));
			this.m_unLockHeroJobUnlockButton.onClick.AddListener(new UnityAction(this.OnUnLockHeroJobUnlockButtonClick));
			this.m_jobTransferEffectContinueButton.onClick.AddListener(new UnityAction(this.OnJobTransferEffectContinueButtonClick));
			this.m_jobUpgradeInfo.SetActive(false);
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_jobUpgradeInfo);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06010B93 RID: 68499 RVA: 0x00456D90 File Offset: 0x00454F90
		public void SetHero(Hero hero, ConfigDataJobConnectionInfo jci = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroHeroConfigDataJobConnectionInfo_hotfix != null)
			{
				this.m_SetHeroHeroConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					hero,
					jci
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero != hero)
			{
				this.m_hero = hero;
				this.m_oldSkillInfoList = null;
				this.m_oldSoldierInfoList = null;
			}
			if (this.m_curJobConnectionInfo != jci && jci != null)
			{
				this.m_curJobConnectionInfo = jci;
			}
		}

		// Token: 0x06010B94 RID: 68500 RVA: 0x00456E4C File Offset: 0x0045504C
		public void UpdateViewInHeroJobTransfer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInHeroJobTransfer_hotfix != null)
			{
				this.m_UpdateViewInHeroJobTransfer_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero == null)
			{
				return;
			}
			Input.multiTouchEnabled = false;
			this.ClearGridLayout();
			this.m_jobConnectionIds = new List<int>();
			if (this.m_playerContext.IsProtagonistHero(this.m_hero.HeroId))
			{
				ConfigDataProtagonistInfo configDataProtagonistInfo = this.m_configDataLoader.GetConfigDataProtagonistInfo(this.m_playerContext.GetProtagonistId());
				this.m_jobConnectionIds.AddRange(configDataProtagonistInfo.UseableJobConnections_ID);
			}
			else
			{
				this.m_jobConnectionIds.AddRange(this.m_playerContext.GetUseableJobConnectionInfos(this.m_hero.HeroId));
				int id = this.m_hero.HeroInfo.m_jobConnectionInfo.ID;
				this.m_jobConnectionIds.Add(id);
			}
			List<int> jobConnectionIds = this.m_jobConnectionIds;
			if (HeroJobTransferUIController.<>f__mg$cache0 == null)
			{
				HeroJobTransferUIController.<>f__mg$cache0 = new Comparison<int>(HeroJobTransferUIController.SortJobConnectionIdByUISort);
			}
			jobConnectionIds.Sort(HeroJobTransferUIController.<>f__mg$cache0);
			this.m_jobConnectionIdToJobCardCtrlDict = new Dictionary<int, HeroJobCardItemUIController>();
			foreach (int key in this.m_jobConnectionIds)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(key);
				if (configDataJobConnectionInfo.IsJobOpen)
				{
					GameObject assetInContainer = base.GetAssetInContainer<GameObject>("jobCardItem");
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					HeroJobCardItemUIController component = gameObject.GetComponent<HeroJobCardItemUIController>();
					component.EventOnJobCardItemClick += this.OnJobCardItemClick;
					component.InitHeroJobCardItem(this.m_hero, configDataJobConnectionInfo, configDataJobConnectionInfo.m_jobInfo.Rank);
					gameObject.transform.SetParent(this.GetGridLayoutByRank(configDataJobConnectionInfo.m_jobInfo.Rank).transform, false);
					this.m_jobConnectionIdToJobCardCtrlDict[configDataJobConnectionInfo.ID] = component;
				}
			}
			this.DynamicSetTransferLines(this.m_jobConnectionIds);
			if (this.m_curJobConnectionInfo == null || !this.m_jobConnectionIds.Contains(this.m_curJobConnectionInfo.ID))
			{
				this.m_curJobConnectionInfo = this.m_hero.GetActiveJob().JobConnectionInfo;
			}
			this.m_isJobHasTransfered = (this.m_hero.Jobs.Find((HeroJob a) => a.JobRelatedId == this.m_curJobConnectionInfo.ID) != null);
			this.SetHeroInfo(this.m_curJobConnectionInfo);
			this.m_goldNumText.text = this.m_playerContext.GetGold().ToString();
			this.m_magicStoneNumText.text = this.m_playerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, this.m_configDataLoader.ConfigableConstId_MagicStoneId) + string.Empty;
			Dictionary<int, HeroJobCardItemUIController>.ValueCollection values = this.m_jobConnectionIdToJobCardCtrlDict.Values;
			int num = 0;
			foreach (HeroJobCardItemUIController heroJobCardItemUIController in values)
			{
				if (heroJobCardItemUIController.IsJobMaster())
				{
					num++;
				}
			}
			this.m_alreadyMasterValueText.text = num + "/" + values.Count;
		}

		// Token: 0x06010B95 RID: 68501 RVA: 0x004571E0 File Offset: 0x004553E0
		public static int SortJobConnectionIdByUISort(int j1, int j2)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(j1);
			ConfigDataJobConnectionInfo configDataJobConnectionInfo2 = configDataLoader.GetConfigDataJobConnectionInfo(j2);
			return configDataJobConnectionInfo.UISort - configDataJobConnectionInfo2.UISort;
		}

		// Token: 0x06010B96 RID: 68502 RVA: 0x0045721C File Offset: 0x0045541C
		[DebuggerHidden]
		private IEnumerator DrawLines(List<int> Ids)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrawLinesList`1_hotfix != null)
			{
				return (IEnumerator)this.m_DrawLinesList`1_hotfix.call(new object[]
				{
					this,
					Ids
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroJobTransferUIController.<DrawLines>c__Iterator0 <DrawLines>c__Iterator = new HeroJobTransferUIController.<DrawLines>c__Iterator0();
			<DrawLines>c__Iterator.Ids = Ids;
			<DrawLines>c__Iterator.$this = this;
			return <DrawLines>c__Iterator;
		}

		// Token: 0x06010B97 RID: 68503 RVA: 0x004572B0 File Offset: 0x004554B0
		private void DynamicSetTransferLines(List<int> Ids)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DynamicSetTransferLinesList`1_hotfix != null)
			{
				this.m_DynamicSetTransferLinesList`1_hotfix.call(new object[]
				{
					this,
					Ids
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			foreach (HeroJob heroJob in this.m_hero.Jobs)
			{
				list.Add(heroJob.JobConnectionInfo.ID);
			}
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = null;
			ConfigDataJobConnectionInfo configDataJobConnectionInfo2 = null;
			List<ConfigDataJobConnectionInfo> list2 = new List<ConfigDataJobConnectionInfo>();
			List<ConfigDataJobConnectionInfo> list3 = new List<ConfigDataJobConnectionInfo>();
			foreach (int key in Ids)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo3 = this.m_configDataLoader.GetConfigDataJobConnectionInfo(key);
				if (configDataJobConnectionInfo3.IsJobOpen)
				{
					switch (configDataJobConnectionInfo3.m_jobInfo.Rank)
					{
					case 1:
						configDataJobConnectionInfo = configDataJobConnectionInfo3;
						break;
					case 2:
						configDataJobConnectionInfo2 = configDataJobConnectionInfo3;
						break;
					case 3:
						list2.Add(configDataJobConnectionInfo3);
						break;
					case 4:
						list3.Add(configDataJobConnectionInfo3);
						break;
					}
				}
			}
			this.m_rankLine1.SetActive(configDataJobConnectionInfo != null);
			this.m_rankLayout1.SetActive(configDataJobConnectionInfo != null);
			this.SetLineImageColor(this.m_rankLine1Image, list.Contains(configDataJobConnectionInfo2.ID));
			if (list2.Count == 1)
			{
				list2.Insert(0, null);
				list2.Insert(2, null);
			}
			else if (list2.Count == 2)
			{
				list2.Insert(1, null);
			}
			this.m_rankLine2Image.gameObject.SetActive(false);
			this.m_rankLine2Image1.gameObject.SetActive(false);
			this.m_rankLine2Image2.gameObject.SetActive(false);
			for (int i = 0; i < list2.Count; i++)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo4 = list2[i];
				if (configDataJobConnectionInfo4 == null)
				{
					GameObject gameObject = new GameObject("Empty", new Type[]
					{
						typeof(RectTransform)
					});
					switch (i)
					{
					case 0:
						gameObject.transform.SetParent(this.m_rankLayout3.transform);
						gameObject.transform.SetAsFirstSibling();
						break;
					case 1:
						gameObject.transform.SetParent(this.m_rankLayout3.transform);
						if (this.m_rankLayout3.transform.childCount > 3)
						{
							gameObject.transform.SetSiblingIndex(4);
						}
						else
						{
							gameObject.transform.SetSiblingIndex(1);
						}
						break;
					case 2:
						gameObject.transform.SetParent(this.m_rankLayout3.transform);
						gameObject.transform.SetAsLastSibling();
						break;
					}
				}
				else
				{
					switch (i)
					{
					case 0:
						this.m_rankLine2Image.gameObject.SetActive(true);
						this.SetLineImageColor(this.m_rankLine2Image, list.Contains(configDataJobConnectionInfo4.ID));
						break;
					case 1:
						this.m_rankLine2Image1.gameObject.SetActive(true);
						this.SetLineImageColor(this.m_rankLine2Image1, list.Contains(configDataJobConnectionInfo4.ID));
						break;
					case 2:
						this.m_rankLine2Image2.gameObject.SetActive(true);
						this.SetLineImageColor(this.m_rankLine2Image2, list.Contains(configDataJobConnectionInfo4.ID));
						break;
					}
				}
			}
			bool[] array = new bool[3];
			this.m_rankLine3Image.gameObject.SetActive(false);
			this.m_rankLine3Image1.gameObject.SetActive(false);
			this.m_rankLine3Image2.gameObject.SetActive(false);
			for (int j = 0; j < list3.Count; j++)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo5 = list3[j];
				for (int k = 0; k < list2.Count; k++)
				{
					ConfigDataJobConnectionInfo configDataJobConnectionInfo6 = list2[k];
					if (configDataJobConnectionInfo6 != null)
					{
						if (configDataJobConnectionInfo5.PreJobConnectionList[0] == configDataJobConnectionInfo6.ID)
						{
							array[k] = true;
							switch (k)
							{
							case 0:
								this.m_rankLine3Image.gameObject.SetActive(true);
								this.SetLineImageColor(this.m_rankLine3Image, list.Contains(configDataJobConnectionInfo5.ID));
								break;
							case 1:
								this.m_rankLine3Image1.gameObject.SetActive(true);
								this.SetLineImageColor(this.m_rankLine3Image1, list.Contains(configDataJobConnectionInfo5.ID));
								break;
							case 2:
								this.m_rankLine3Image2.gameObject.SetActive(true);
								this.SetLineImageColor(this.m_rankLine3Image2, list.Contains(configDataJobConnectionInfo5.ID));
								break;
							}
						}
					}
				}
			}
			for (int l = 0; l < array.Length; l++)
			{
				if (!array[l])
				{
					GameObject gameObject2 = new GameObject("Empty", new Type[]
					{
						typeof(RectTransform)
					});
					switch (l)
					{
					case 0:
						gameObject2.transform.SetParent(this.m_rankLayout4.transform);
						gameObject2.transform.SetAsFirstSibling();
						break;
					case 1:
						gameObject2.transform.SetParent(this.m_rankLayout4.transform);
						if (this.m_rankLayout4.transform.childCount > 3)
						{
							gameObject2.transform.SetSiblingIndex(4);
						}
						else
						{
							gameObject2.transform.SetSiblingIndex(1);
						}
						break;
					case 2:
						gameObject2.transform.SetParent(this.m_rankLayout4.transform);
						gameObject2.transform.SetAsLastSibling();
						break;
					}
				}
			}
		}

		// Token: 0x06010B98 RID: 68504 RVA: 0x00457918 File Offset: 0x00455B18
		private void SetLineImageColor(Image img, bool canTransfer)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLineImageColorImageBoolean_hotfix != null)
			{
				this.m_SetLineImageColorImageBoolean_hotfix.call(new object[]
				{
					this,
					img,
					canTransfer
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Color white = Color.white;
			Color black = Color.black;
			if (canTransfer)
			{
				img.color = new Color(white.r, white.g, white.b, 1f);
			}
			else
			{
				img.color = new Color(black.r, black.g, black.b, 0.5f);
			}
		}

		// Token: 0x06010B99 RID: 68505 RVA: 0x004579FC File Offset: 0x00455BFC
		private void ClearGridLayout()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearGridLayout_hotfix != null)
			{
				this.m_ClearGridLayout_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_rankLayout1);
			GameObjectUtility.DestroyChildren(this.m_rankLayout2);
			GameObjectUtility.DestroyChildren(this.m_rankLayout3);
			GameObjectUtility.DestroyChildren(this.m_rankLayout4);
		}

		// Token: 0x06010B9A RID: 68506 RVA: 0x00457A88 File Offset: 0x00455C88
		private GameObject GetGridLayoutByRank(int rank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGridLayoutByRankInt32_hotfix != null)
			{
				return (GameObject)this.m_GetGridLayoutByRankInt32_hotfix.call(new object[]
				{
					this,
					rank
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (rank)
			{
			case 1:
				return this.m_rankLayout1;
			case 2:
				return this.m_rankLayout2;
			case 3:
				return this.m_rankLayout3;
			case 4:
				return this.m_rankLayout4;
			default:
				return null;
			}
		}

		// Token: 0x06010B9B RID: 68507 RVA: 0x00457B40 File Offset: 0x00455D40
		private void OnJobCardItemClick(HeroJobCardItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobCardItemClickHeroJobCardItemUIController_hotfix != null)
			{
				this.m_OnJobCardItemClickHeroJobCardItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curJobConnectionInfo == ctrl.JobConnectionInfo)
			{
				return;
			}
			this.m_curJobConnectionInfo = ctrl.JobConnectionInfo;
			this.m_isNeedMagicStone = ctrl.IsNeedMagicStone;
			this.m_isJobLocked = ctrl.IsJobLocked;
			if (this.EventOnHeroJobCardClick != null)
			{
				this.EventOnHeroJobCardClick(this.m_curJobConnectionInfo);
			}
		}

		// Token: 0x06010B9C RID: 68508 RVA: 0x00457C04 File Offset: 0x00455E04
		private void SetHeroInfo(ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroInfoConfigDataJobConnectionInfo_hotfix != null)
			{
				this.m_SetHeroInfoConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_jobUnlockButton.gameObject.SetActive(this.m_isJobLocked);
			this.m_jobNameText.text = jobConnectionInfo.m_jobInfo.Name;
			this.m_jobNameEnText.text = jobConnectionInfo.m_jobInfo.Name_Eng;
			if (jobConnectionInfo.m_jobInfo.IsMelee)
			{
				this.m_jobTypeText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Melee);
				this.m_jobTypeBgImage.SetActive(true);
				this.m_jobTypeBgImage2.SetActive(false);
			}
			else
			{
				this.m_jobTypeText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_NotMelee);
				this.m_jobTypeBgImage.SetActive(false);
				this.m_jobTypeBgImage2.SetActive(true);
			}
			this.m_jobMoveValueText.text = jobConnectionInfo.m_jobInfo.BF_MovePoint + string.Empty;
			this.m_jobRangeValueText.text = jobConnectionInfo.m_jobInfo.BF_AttackDistance + string.Empty;
			List<Text> list = new List<Text>
			{
				this.m_jobAdvantageText,
				this.m_jobAdvantageText1,
				this.m_jobAdvantageText2
			};
			List<int> advantagePropertyIds = jobConnectionInfo.m_jobInfo.AdvantagePropertyIds;
			for (int i = 0; i < list.Count; i++)
			{
				if (i < advantagePropertyIds.Count)
				{
					ConfigDataPropertyModifyInfo configDataPropertyModifyInfo = this.m_configDataLoader.GetConfigDataPropertyModifyInfo(advantagePropertyIds[i]);
					list[i].text = ((configDataPropertyModifyInfo == null) ? string.Empty : configDataPropertyModifyInfo.Name);
				}
				else
				{
					list[i].text = null;
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_jobLvBgImagesGroup, jobConnectionInfo.m_jobLevelInfos.Length - 1);
			if (this.m_hero.GetJob(jobConnectionInfo.ID) != null)
			{
				UIUtility.SetGameObjectChildrenActiveCount(this.m_jobLvImagesGroup, this.m_hero.GetJob(jobConnectionInfo.ID).JobLevel);
			}
			else
			{
				UIUtility.SetGameObjectChildrenActiveCount(this.m_jobLvImagesGroup, 0);
			}
			this.m_jobSoldierTypeImage.sprite = AssetUtility.Instance.GetSprite(jobConnectionInfo.m_jobInfo.m_armyInfo.Icon_NoBack);
			this.CreateSpineGraphic(ref this.m_heroGraphic, jobConnectionInfo, this.m_heroGraphicObj, 0.017f, "idle", 1);
			List<ConfigDataSoldierInfo> list2 = new List<ConfigDataSoldierInfo>();
			List<ConfigDataSkillInfo> list3 = new List<ConfigDataSkillInfo>();
			foreach (ConfigDataJobLevelInfo configDataJobLevelInfo in jobConnectionInfo.m_jobLevelInfos)
			{
				if (configDataJobLevelInfo.m_gotSkillInfo != null && !list3.Contains(configDataJobLevelInfo.m_gotSkillInfo))
				{
					list3.Add(configDataJobLevelInfo.m_gotSkillInfo);
				}
				if (configDataJobLevelInfo.m_gotSoldierInfo != null && !list2.Contains(configDataJobLevelInfo.m_gotSoldierInfo))
				{
					list2.Add(configDataJobLevelInfo.m_gotSoldierInfo);
				}
			}
			this.SetCanLearnSoldiers(list2);
			this.SetCanLearnSkills(list3);
			foreach (int num in this.m_jobConnectionIdToJobCardCtrlDict.Keys)
			{
				if (jobConnectionInfo.ID == num)
				{
					this.m_jobConnectionIdToJobCardCtrlDict[num].SetFrameImage(true);
				}
				else
				{
					this.m_jobConnectionIdToJobCardCtrlDict[num].SetFrameImage(false);
				}
			}
		}

		// Token: 0x06010B9D RID: 68509 RVA: 0x00457FE4 File Offset: 0x004561E4
		private void SetCanLearnSkills(List<ConfigDataSkillInfo> skillInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCanLearnSkillsList`1_hotfix != null)
			{
				this.m_SetCanLearnSkillsList`1_hotfix.call(new object[]
				{
					this,
					skillInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<GameObject> list = new List<GameObject>
			{
				this.m_learnedSkillIconImg,
				this.m_learnedSkillIconImg2
			};
			for (int i = 0; i < list.Count; i++)
			{
				if (skillInfos.Count - 1 >= i)
				{
					HeroJobTransferSkillItemUIController component = list[i].GetComponent<HeroJobTransferSkillItemUIController>();
					if (component == null)
					{
						PrefabControllerCreater.CreateAllControllers(list[i]);
						component = list[i].GetComponent<HeroJobTransferSkillItemUIController>();
					}
					component.InitSkillItem(skillInfos[i], this.m_skillDetailPanel);
					list[i].SetActive(true);
				}
				else
				{
					list[i].SetActive(false);
				}
			}
		}

		// Token: 0x06010B9E RID: 68510 RVA: 0x00458100 File Offset: 0x00456300
		private void SetCanLearnSoldiers(List<ConfigDataSoldierInfo> soldierInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCanLearnSoldiersList`1_hotfix != null)
			{
				this.m_SetCanLearnSoldiersList`1_hotfix.call(new object[]
				{
					this,
					soldierInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic(ref this.m_soldierGraphicL);
			this.DestroyGraphic(ref this.m_soldierGraphicR);
			List<GameObject> list = new List<GameObject>
			{
				this.m_learnedSoldierGraphicBg,
				this.m_learnedSoldierGraphicBg2
			};
			List<GameObject> list2 = new List<GameObject>
			{
				this.m_learnedSoldierGraphicObj,
				this.m_learnedSoldierGraphicObj2
			};
			for (int i = 0; i < 2; i++)
			{
				HeroJobTransferSoldierItemUIController heroJobTransferSoldierItemUIController = list[i].GetComponent<HeroJobTransferSoldierItemUIController>();
				if (heroJobTransferSoldierItemUIController == null)
				{
					heroJobTransferSoldierItemUIController = GameObjectUtility.AddControllerToGameObject<HeroJobTransferSoldierItemUIController>(list[i]);
				}
				ConfigDataSoldierInfo soldierInfo = null;
				if (i < soldierInfos.Count)
				{
					soldierInfo = soldierInfos[i];
				}
				heroJobTransferSoldierItemUIController.InitSoldierItem(soldierInfo, this.m_hero, this.m_soldierDetailPanel);
				if (i == 0)
				{
					this.CreateSoldierGraphic(ref this.m_soldierGraphicL, soldierInfo, list2[i], 0.013f, 1);
				}
				else
				{
					this.CreateSoldierGraphic(ref this.m_soldierGraphicR, soldierInfo, list2[i], 0.013f, 1);
				}
			}
		}

		// Token: 0x06010B9F RID: 68511 RVA: 0x00458274 File Offset: 0x00456474
		private void CloseHeroJobInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseHeroJobInfo_hotfix != null)
			{
				this.m_CloseHeroJobInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroATGraphicObj.SetActive(false);
			this.m_transferConfirmPanel.SetActive(false);
			this.m_transferLockPanel.SetActive(false);
			this.m_masterInfoPanel.SetActive(false);
			this.m_heroATGraphicJobChangeEffectObj1.SetActive(false);
			this.m_heroATGraphicJobChangeEffectObj2.SetActive(false);
			this.m_jobUpgradeInfo.SetActive(false);
			this.m_JobTransferEffectBgImage.SetActive(false);
			this.m_jobTransferGroundImage.SetActive(false);
			this.m_jobTransferEffectContinueButton.gameObject.SetActive(false);
			this.m_JobTransferEffectWhiteImage.SetActive(false);
			this.m_JobTransferEffectBlackImage.SetActive(false);
		}

		// Token: 0x06010BA0 RID: 68512 RVA: 0x0045836C File Offset: 0x0045656C
		private void OnJobTransferButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobTransferButtonClick_hotfix != null)
			{
				this.m_OnJobTransferButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curJobConnectionInfo == this.m_hero.GetActiveJob().JobConnectionInfo)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_TransferJobIsCurJob, 2f, null, true);
				return;
			}
			int num = this.m_playerContext.CanHeroJobTransfer(this.m_hero.HeroId, this.m_curJobConnectionInfo.ID);
			if (num == -636 || num == -650 || num == -617)
			{
				CommonUIStateController component = this.m_transferLockPanel.GetComponent<CommonUIStateController>();
				component.SetToUIState("PanelOpen", false, true);
				this.m_transferLockQuesText.text = this.m_curJobConnectionInfo.m_jobInfo.UnlockText;
			}
			else
			{
				CommonUIStateController component2 = this.m_transferConfirmPanel.GetComponent<CommonUIStateController>();
				component2.SetToUIState("PanelOpen", false, true);
				this.m_goldCostValueText.text = this.m_curJobConnectionInfo.m_jobInfo.ChangeJobGold + string.Empty;
				this.m_confirmPanelJobNameText.text = "【" + this.m_curJobConnectionInfo.m_jobInfo.Name + "】";
				if (this.m_isNeedMagicStone)
				{
					this.m_confirmTransferNoticeTextStateCtrl.SetToUIState("NeedStone", false, true);
					this.m_magicStoneCostValueText.text = "1";
				}
				else
				{
					this.m_confirmTransferNoticeTextStateCtrl.SetToUIState("DontNeedStone", false, true);
					this.m_magicStoneCostValueText.text = "0";
				}
			}
		}

		// Token: 0x06010BA1 RID: 68513 RVA: 0x0045853C File Offset: 0x0045673C
		private void CloseJobTransferConfirmPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseJobTransferConfirmPanel_hotfix != null)
			{
				this.m_CloseJobTransferConfirmPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_transferConfirmPanel.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("PanelClose", delegate
			{
				this.m_transferConfirmPanel.SetActive(false);
			});
			component.SetToUIState("PanelClose", false, true);
		}

		// Token: 0x06010BA2 RID: 68514 RVA: 0x004585D0 File Offset: 0x004567D0
		private void CloseJobTransferLockedPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseJobTransferLockedPanel_hotfix != null)
			{
				this.m_CloseJobTransferLockedPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_transferLockPanel.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("PanelClose", delegate
			{
				this.m_transferLockPanel.SetActive(false);
			});
			component.SetToUIState("PanelClose", false, true);
		}

		// Token: 0x06010BA3 RID: 68515 RVA: 0x00458664 File Offset: 0x00456864
		private void OnJobUnlockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobUnlockButtonClick_hotfix != null)
			{
				this.m_OnJobUnlockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unLockHeroJobPanelJobNameText.text = "[" + this.m_curJobConnectionInfo.m_jobInfo.Name + "]";
			GameObjectUtility.DestroyChildren(this.m_unLockHeroJobConditionsContentObj);
			foreach (ConfigDataJobUnlockConditionInfo condition in this.m_curJobConnectionInfo.m_unlockConditions)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_unlcokJobConditionPrefab);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				HeroJobTransferConditionItemUIController component = gameObject.GetComponent<HeroJobTransferConditionItemUIController>();
				HeroJob heroJob = null;
				foreach (ConfigDataJobConnectionInfo configDataJobConnectionInfo in this.m_curJobConnectionInfo.m_preJobConnectionInfos)
				{
					foreach (HeroJob heroJob2 in this.m_hero.Jobs)
					{
						if (heroJob2.JobConnectionInfo == configDataJobConnectionInfo)
						{
							heroJob = heroJob2;
							break;
						}
					}
					if (heroJob != null)
					{
						break;
					}
				}
				component.InitConditionItem(condition, heroJob);
				gameObject.transform.SetParent(this.m_unLockHeroJobConditionsContentObj.transform, false);
			}
			this.m_unLockHeroJobPanel.SetActive(true);
		}

		// Token: 0x06010BA4 RID: 68516 RVA: 0x00458848 File Offset: 0x00456A48
		private void OnUnLockHeroJobReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnLockHeroJobReturnButtonClick_hotfix != null)
			{
				this.m_OnUnLockHeroJobReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unLockHeroJobPanel.SetActive(false);
		}

		// Token: 0x06010BA5 RID: 68517 RVA: 0x004588B4 File Offset: 0x00456AB4
		private void OnUnLockHeroJobUnlockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnLockHeroJobUnlockButtonClick_hotfix != null)
			{
				this.m_OnUnLockHeroJobUnlockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnHeroJobUnlock != null)
			{
				this.EventOnHeroJobUnlock(this.m_hero.HeroId, this.m_curJobConnectionInfo.ID, delegate
				{
				});
			}
		}

		// Token: 0x06010BA6 RID: 68518 RVA: 0x00458960 File Offset: 0x00456B60
		private void OnJobTransferConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobTransferConfirmButtonClick_hotfix != null)
			{
				this.m_OnJobTransferConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanHeroJobTransfer(this.m_hero.HeroId, this.m_curJobConnectionInfo.ID);
			if (num == 0)
			{
				this.m_oldJobConnectionInfo = this.m_hero.GetActiveJob().JobConnectionInfo;
				this.GetCanLearnSkillAndSoldier();
				if (this.EventOnHeroJobTransfer != null)
				{
					this.EventOnHeroJobTransfer(this.m_hero.HeroId, this.m_curJobConnectionInfo.ID, new Action(this.OnHeroJobTransferSucceed));
				}
				this.CloseJobTransferConfirmPanel();
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06010BA7 RID: 68519 RVA: 0x00458A5C File Offset: 0x00456C5C
		private void GetCanLearnSkillAndSoldier()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCanLearnSkillAndSoldier_hotfix != null)
			{
				this.m_GetCanLearnSkillAndSoldier_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_oldSoldierInfoList == null)
			{
				this.m_oldSoldierInfoList = new List<int>();
				this.m_oldSoldierInfoList.AddRange(this.m_hero.SoldierIds);
			}
			if (this.m_oldSkillInfoList == null)
			{
				this.m_oldSkillInfoList = new List<int>();
				this.m_oldSkillInfoList.AddRange(this.m_hero.SkillIds);
			}
			this.m_isShowLearnSkill = (this.m_isShowLearnSoldier = false);
			ConfigDataJobLevelInfo configDataJobLevelInfo = this.m_curJobConnectionInfo.m_jobLevelInfos[0];
			if (configDataJobLevelInfo.GotSkill_ID != 0)
			{
				if (this.m_oldSkillInfoList.Contains(configDataJobLevelInfo.GotSkill_ID))
				{
					this.m_isShowLearnSkill = false;
				}
				else
				{
					this.m_isShowLearnSkill = true;
				}
			}
			if (configDataJobLevelInfo.GotSoldier_ID != 0)
			{
				if (this.m_oldSoldierInfoList.Contains(configDataJobLevelInfo.GotSoldier_ID))
				{
					this.m_isShowLearnSoldier = false;
				}
				else
				{
					this.m_isShowLearnSoldier = true;
				}
			}
			this.m_oldSoldierInfoList.Clear();
			this.m_oldSoldierInfoList.AddRange(this.m_hero.SoldierIds);
			this.m_oldSkillInfoList.Clear();
			this.m_oldSkillInfoList.AddRange(this.m_hero.SkillIds);
		}

		// Token: 0x06010BA8 RID: 68520 RVA: 0x00458BDC File Offset: 0x00456DDC
		public void OnHeroJobTransferSucceed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroJobTransferSucceed_hotfix != null)
			{
				this.m_OnHeroJobTransferSucceed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.PlayJobTransfetEffectStep1());
			LocalConfigData data = LocalConfig.Instance.Data;
			this.m_jobTransferEffectSkipBtn.gameObject.SetActive(data.IsDeveloper);
		}

		// Token: 0x06010BA9 RID: 68521 RVA: 0x00458C6C File Offset: 0x00456E6C
		private void OnSkipBtnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkipBtnClick_hotfix != null)
			{
				this.m_OnSkipBtnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StopAllCoroutines();
			this.CloseHeroJobInfo();
			AudioUtility.PlaySound("MIMusic_Main");
			this.m_jobTransferEffectSkipBtn.gameObject.SetActive(false);
			if (this.EventOnHeroJobTransferFinishedForUserGuide != null)
			{
				this.EventOnHeroJobTransferFinishedForUserGuide();
			}
		}

		// Token: 0x06010BAA RID: 68522 RVA: 0x00458D0C File Offset: 0x00456F0C
		[DebuggerHidden]
		private IEnumerator PlayJobTransfetEffectStep1()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayJobTransfetEffectStep1_hotfix != null)
			{
				return (IEnumerator)this.m_PlayJobTransfetEffectStep1_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroJobTransferUIController.<PlayJobTransfetEffectStep1>c__Iterator1 <PlayJobTransfetEffectStep1>c__Iterator = new HeroJobTransferUIController.<PlayJobTransfetEffectStep1>c__Iterator1();
			<PlayJobTransfetEffectStep1>c__Iterator.$this = this;
			return <PlayJobTransfetEffectStep1>c__Iterator;
		}

		// Token: 0x06010BAB RID: 68523 RVA: 0x00458D88 File Offset: 0x00456F88
		[DebuggerHidden]
		private IEnumerator PlayJobTransfetEffectStep2()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayJobTransfetEffectStep2_hotfix != null)
			{
				return (IEnumerator)this.m_PlayJobTransfetEffectStep2_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroJobTransferUIController.<PlayJobTransfetEffectStep2>c__Iterator2 <PlayJobTransfetEffectStep2>c__Iterator = new HeroJobTransferUIController.<PlayJobTransfetEffectStep2>c__Iterator2();
			<PlayJobTransfetEffectStep2>c__Iterator.$this = this;
			return <PlayJobTransfetEffectStep2>c__Iterator;
		}

		// Token: 0x06010BAC RID: 68524 RVA: 0x00458E04 File Offset: 0x00457004
		[DebuggerHidden]
		private IEnumerator ShowLearnedSkillAndSoldier()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowLearnedSkillAndSoldier_hotfix != null)
			{
				return (IEnumerator)this.m_ShowLearnedSkillAndSoldier_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroJobTransferUIController.<ShowLearnedSkillAndSoldier>c__Iterator3 <ShowLearnedSkillAndSoldier>c__Iterator = new HeroJobTransferUIController.<ShowLearnedSkillAndSoldier>c__Iterator3();
			<ShowLearnedSkillAndSoldier>c__Iterator.$this = this;
			return <ShowLearnedSkillAndSoldier>c__Iterator;
		}

		// Token: 0x06010BAD RID: 68525 RVA: 0x00458E80 File Offset: 0x00457080
		private void CloseLearnedSkillPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseLearnedSkillPanel_hotfix != null)
			{
				this.m_CloseLearnedSkillPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_learnedPanelSkillPanel.SetActive(false);
			this.m_learnedPanelSoldierPanel.SetActive(true);
			UIUtility.ReplayTween(this.m_learnedPanelSoldierPanel, null);
		}

		// Token: 0x06010BAE RID: 68526 RVA: 0x00458F04 File Offset: 0x00457104
		private void CloseLearnedPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseLearnedPanel_hotfix != null)
			{
				this.m_CloseLearnedPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_learnedPanel.SetActive(false);
			this.m_learnedPanelSkillPanel.SetActive(false);
			this.m_learnedPanelSoldierPanel.SetActive(false);
		}

		// Token: 0x06010BAF RID: 68527 RVA: 0x00458F88 File Offset: 0x00457188
		private void OnJobTransferEffectContinueButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobTransferEffectContinueButtonClick_hotfix != null)
			{
				this.m_OnJobTransferEffectContinueButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isJobTransferContinue = true;
			this.m_jobTransferEffectContinueButton.gameObject.SetActive(false);
			this.m_jobTransferEffectContinueButton.interactable = false;
		}

		// Token: 0x06010BB0 RID: 68528 RVA: 0x0045900C File Offset: 0x0045720C
		private void SetTransferSucceedInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTransferSucceedInfo_hotfix != null)
			{
				this.m_SetTransferSucceedInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curComputer = new HeroPropertyComputer();
			this.m_curComputer.Init(this.m_configDataLoader);
			this.m_curComputer.ComputeHeroProperties(this.m_hero, this.m_curJobConnectionInfo.ID, -1, -1, -1, -1, -1, -1);
			this.m_oldComputer = new HeroPropertyComputer();
			this.m_oldComputer.Init(this.m_configDataLoader);
			this.m_oldComputer.ComputeHeroProperties(this.m_hero, this.m_oldJobConnectionInfo.ID, -1, -1, -1, -1, -1, -1);
			this.m_jobTransHpText.text = this.PropertyToString(this.m_curComputer.Property1.HealthPointMax, this.m_oldComputer.Property1.HealthPointMax, this.m_jobTransHpImage);
			this.m_jobTransATText.text = this.PropertyToString(this.m_curComputer.Property1.Attack, this.m_oldComputer.Property1.Attack, this.m_jobTransATImage);
			this.m_jobTransDFText.text = this.PropertyToString(this.m_curComputer.Property1.Defense, this.m_oldComputer.Property1.Defense, this.m_jobTransDFImage);
			this.m_jobTransMagicText.text = this.PropertyToString(this.m_curComputer.Property1.Magic, this.m_oldComputer.Property1.Magic, this.m_jobTransMagicImage);
			this.m_jobTransMagicDFText.text = this.PropertyToString(this.m_curComputer.Property1.MagicDefense, this.m_oldComputer.Property1.MagicDefense, this.m_jobTransMagicDFImage);
			this.m_jobTransDEXText.text = this.PropertyToString(this.m_curComputer.Property1.Dexterity, this.m_oldComputer.Property1.Dexterity, this.m_jobTransDEXImage);
		}

		// Token: 0x06010BB1 RID: 68529 RVA: 0x00459234 File Offset: 0x00457434
		private string PropertyToString(int value0, int value1, Image img)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PropertyToStringInt32Int32Image_hotfix != null)
			{
				return (string)this.m_PropertyToStringInt32Int32Image_hotfix.call(new object[]
				{
					this,
					value0,
					value1,
					img
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = value0.ToString();
			int num = value0 - value1;
			if (num > 0)
			{
				text = text + "(" + UIUtility.AddColorTag("+" + num, new Color(0.27f, 0.58f, 0.23f)) + ")";
			}
			else if (num < 0)
			{
				text = text + "(" + UIUtility.AddColorTag(string.Empty + num, new Color(1f, 0f, 0f)) + ")";
			}
			this.SetImageState(img, num);
			return text;
		}

		// Token: 0x06010BB2 RID: 68530 RVA: 0x00459374 File Offset: 0x00457574
		private void SetImageState(Image img, int t)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetImageStateImageInt32_hotfix != null)
			{
				this.m_SetImageStateImageInt32_hotfix.call(new object[]
				{
					this,
					img,
					t
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (t > 0)
			{
				img.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon_Up.png");
			}
			else if (t < 0)
			{
				img.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon_Down.png");
			}
			else
			{
				img.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon_Minus.png");
			}
		}

		// Token: 0x06010BB3 RID: 68531 RVA: 0x0045944C File Offset: 0x0045764C
		private void OnMasterRewardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMasterRewardButtonClick_hotfix != null)
			{
				this.m_OnMasterRewardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_masterInfoPanelScrollViewContent);
			Dictionary<int, HeroJobCardItemUIController>.ValueCollection values = this.m_jobConnectionIdToJobCardCtrlDict.Values;
			foreach (HeroJobCardItemUIController heroJobCardItemUIController in values)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_masterItemPrefab);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				HeroJobMasterJobItemUIController component = gameObject.GetComponent<HeroJobMasterJobItemUIController>();
				component.InitJobMasterItem(heroJobCardItemUIController.JobConnectionInfo.m_jobInfo, heroJobCardItemUIController.IsJobMaster());
				gameObject.transform.SetParent(this.m_masterInfoPanelScrollViewContent.transform, false);
			}
			this.m_masterInfoPanel.SetActive(true);
			CommonUIStateController component2 = this.m_masterInfoPanel.GetComponent<CommonUIStateController>();
			component2.SetToUIState("Show", false, true);
		}

		// Token: 0x06010BB4 RID: 68532 RVA: 0x00459578 File Offset: 0x00457778
		private void CloseMasterInfoPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseMasterInfoPanel_hotfix != null)
			{
				this.m_CloseMasterInfoPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_masterInfoPanel.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_masterInfoPanel.SetActive(false);
			});
			component.SetToUIState("Close", false, true);
		}

		// Token: 0x06010BB5 RID: 68533 RVA: 0x0045960C File Offset: 0x0045780C
		private void CreateSpineGraphic(ref UISpineGraphic graphic, ConfigDataJobConnectionInfo jobConnectionInfo, GameObject graphice, float scaleNum, string anim, int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicUISpineGraphic_ConfigDataJobConnectionInfoGameObjectSingleStringInt32_hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController_CreateSpineGraphic_UISpineGraphic_ConfigDataJobConnectionInfo_GameObject_Single_String_Int32(this, this.m_CreateSpineGraphicUISpineGraphic_ConfigDataJobConnectionInfoGameObjectSingleStringInt32_hotfix, ref graphic, jobConnectionInfo, graphice, scaleNum, anim, team);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic(ref graphic);
			string model = jobConnectionInfo.Model;
			float scale = (float)jobConnectionInfo.ModelScale * scaleNum;
			Vector2 position = new Vector2((float)jobConnectionInfo.UI_ModelOffsetX, (float)jobConnectionInfo.UI_ModelOffsetY) * (scaleNum * 100f);
			graphic = new UISpineGraphic();
			graphic.Create(model);
			graphic.SetParent(graphice);
			graphic.SetDirection((team != 0) ? -1 : 1);
			graphic.SetPosition(position);
			graphic.SetScale(scale);
			graphic.SetReplaceAnimations(jobConnectionInfo.ReplaceAnims);
			graphic.PlayAnimation(anim, true, 0);
			if (this.m_isJobHasTransfered)
			{
				graphic.SetColor(Color.white);
			}
			else
			{
				graphic.SetColor(UIUtility.MyGrayColor);
			}
			graphic.ForceUpdate();
		}

		// Token: 0x06010BB6 RID: 68534 RVA: 0x00459728 File Offset: 0x00457928
		private void CreateSoldierGraphic(ref UISpineGraphic graphic, ConfigDataSoldierInfo soldierInfo, GameObject graphice, float scales, int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSoldierGraphicUISpineGraphic_ConfigDataSoldierInfoGameObjectSingleInt32_hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController_CreateSoldierGraphic_UISpineGraphic_ConfigDataSoldierInfo_GameObject_Single_Int32(this, this.m_CreateSoldierGraphicUISpineGraphic_ConfigDataSoldierInfoGameObjectSingleInt32_hotfix, ref graphic, soldierInfo, graphice, scales, team);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic(ref graphic);
			if (soldierInfo == null)
			{
				return;
			}
			string model = soldierInfo.Model;
			float scale = (float)soldierInfo.ModelScale * scales;
			Vector2 position = new Vector2((float)soldierInfo.UI_ModelOffsetX, (float)soldierInfo.UI_ModelOffsetY) * (scales * 100f);
			graphic = new UISpineGraphic();
			graphic.Create(model);
			graphic.SetParent(graphice);
			graphic.SetDirection((team != 0) ? -1 : 1);
			graphic.SetPosition(position);
			graphic.SetScale(scale);
			graphic.SetReplaceAnimations(soldierInfo.ReplaceAnims);
			graphic.PlayAnimation("idle", true, 0);
			if (this.m_isJobHasTransfered)
			{
				graphic.SetColor(Color.white);
			}
			else
			{
				graphic.SetColor(UIUtility.MyGrayColor);
			}
			graphic.ForceUpdate();
		}

		// Token: 0x06010BB7 RID: 68535 RVA: 0x0045984C File Offset: 0x00457A4C
		private void DestroyGraphic(ref UISpineGraphic g)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyGraphicUISpineGraphic__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController_DestroyGraphic_UISpineGraphic(this, this.m_DestroyGraphicUISpineGraphic__hotfix, ref g);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (g != null)
			{
				g.Destroy();
				g = null;
			}
		}

		// Token: 0x06010BB8 RID: 68536 RVA: 0x004598B0 File Offset: 0x00457AB0
		private void OnGoldAddButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGoldAddButtonClick_hotfix != null)
			{
				this.m_OnGoldAddButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddGold != null)
			{
				this.EventOnAddGold();
			}
		}

		// Token: 0x06010BB9 RID: 68537 RVA: 0x00459928 File Offset: 0x00457B28
		private void OnMagicStoneClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMagicStoneClick_hotfix != null)
			{
				this.m_OnMagicStoneClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoodsType goodsType = GoodsType.GoodsType_Item;
			int goodsId = 3009;
			GameObject gameObject = this.m_magicStoneBtn.gameObject;
			RewardGoodsDescUITask.StartUITask(this, goodsType, goodsId, 0, gameObject, true);
		}

		// Token: 0x06010BBA RID: 68538 RVA: 0x004599AC File Offset: 0x00457BAC
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
			Input.multiTouchEnabled = true;
		}

		// Token: 0x1400038E RID: 910
		// (add) Token: 0x06010BBB RID: 68539 RVA: 0x00459A28 File Offset: 0x00457C28
		// (remove) Token: 0x06010BBC RID: 68540 RVA: 0x00459AC4 File Offset: 0x00457CC4
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

		// Token: 0x1400038F RID: 911
		// (add) Token: 0x06010BBD RID: 68541 RVA: 0x00459B60 File Offset: 0x00457D60
		// (remove) Token: 0x06010BBE RID: 68542 RVA: 0x00459BFC File Offset: 0x00457DFC
		public event Action EventOnAddGold
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddGoldAction_hotfix != null)
				{
					this.m_add_EventOnAddGoldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddGold;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddGold, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddGoldAction_hotfix != null)
				{
					this.m_remove_EventOnAddGoldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddGold;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddGold, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000390 RID: 912
		// (add) Token: 0x06010BBF RID: 68543 RVA: 0x00459C98 File Offset: 0x00457E98
		// (remove) Token: 0x06010BC0 RID: 68544 RVA: 0x00459D34 File Offset: 0x00457F34
		public event Action<int, int, Action> EventOnHeroJobUnlock
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroJobUnlockAction`3_hotfix != null)
				{
					this.m_add_EventOnHeroJobUnlockAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnHeroJobUnlock;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnHeroJobUnlock, (Action<int, int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroJobUnlockAction`3_hotfix != null)
				{
					this.m_remove_EventOnHeroJobUnlockAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnHeroJobUnlock;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnHeroJobUnlock, (Action<int, int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000391 RID: 913
		// (add) Token: 0x06010BC1 RID: 68545 RVA: 0x00459DD0 File Offset: 0x00457FD0
		// (remove) Token: 0x06010BC2 RID: 68546 RVA: 0x00459E6C File Offset: 0x0045806C
		public event Action EventOnHeroJobTransferFinishedForUserGuide
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroJobTransferFinishedForUserGuideAction_hotfix != null)
				{
					this.m_add_EventOnHeroJobTransferFinishedForUserGuideAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnHeroJobTransferFinishedForUserGuide;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnHeroJobTransferFinishedForUserGuide, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroJobTransferFinishedForUserGuideAction_hotfix != null)
				{
					this.m_remove_EventOnHeroJobTransferFinishedForUserGuideAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnHeroJobTransferFinishedForUserGuide;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnHeroJobTransferFinishedForUserGuide, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000392 RID: 914
		// (add) Token: 0x06010BC3 RID: 68547 RVA: 0x00459F08 File Offset: 0x00458108
		// (remove) Token: 0x06010BC4 RID: 68548 RVA: 0x00459FA4 File Offset: 0x004581A4
		public event Action<int, int, Action> EventOnHeroJobTransfer
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroJobTransferAction`3_hotfix != null)
				{
					this.m_add_EventOnHeroJobTransferAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnHeroJobTransfer;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnHeroJobTransfer, (Action<int, int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroJobTransferAction`3_hotfix != null)
				{
					this.m_remove_EventOnHeroJobTransferAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnHeroJobTransfer;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnHeroJobTransfer, (Action<int, int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000393 RID: 915
		// (add) Token: 0x06010BC5 RID: 68549 RVA: 0x0045A040 File Offset: 0x00458240
		// (remove) Token: 0x06010BC6 RID: 68550 RVA: 0x0045A0DC File Offset: 0x004582DC
		public event Action<ConfigDataJobConnectionInfo> EventOnHeroJobCardClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroJobCardClickAction`1_hotfix != null)
				{
					this.m_add_EventOnHeroJobCardClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataJobConnectionInfo> action = this.EventOnHeroJobCardClick;
				Action<ConfigDataJobConnectionInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataJobConnectionInfo>>(ref this.EventOnHeroJobCardClick, (Action<ConfigDataJobConnectionInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroJobCardClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnHeroJobCardClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataJobConnectionInfo> action = this.EventOnHeroJobCardClick;
				Action<ConfigDataJobConnectionInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataJobConnectionInfo>>(ref this.EventOnHeroJobCardClick, (Action<ConfigDataJobConnectionInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x06010BC7 RID: 68551 RVA: 0x0045A178 File Offset: 0x00458378
		// (set) Token: 0x06010BC8 RID: 68552 RVA: 0x0045A198 File Offset: 0x00458398
		[DoNotToLua]
		public new HeroJobTransferUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroJobTransferUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010BC9 RID: 68553 RVA: 0x0045A1A4 File Offset: 0x004583A4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010BCA RID: 68554 RVA: 0x0045A1B0 File Offset: 0x004583B0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010BCB RID: 68555 RVA: 0x0045A1B8 File Offset: 0x004583B8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010BCC RID: 68556 RVA: 0x0045A1C0 File Offset: 0x004583C0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010BCD RID: 68557 RVA: 0x0045A1D4 File Offset: 0x004583D4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010BCE RID: 68558 RVA: 0x0045A1DC File Offset: 0x004583DC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010BCF RID: 68559 RVA: 0x0045A1E8 File Offset: 0x004583E8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010BD0 RID: 68560 RVA: 0x0045A1F4 File Offset: 0x004583F4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010BD1 RID: 68561 RVA: 0x0045A200 File Offset: 0x00458400
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010BD2 RID: 68562 RVA: 0x0045A20C File Offset: 0x0045840C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010BD3 RID: 68563 RVA: 0x0045A218 File Offset: 0x00458418
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010BD4 RID: 68564 RVA: 0x0045A224 File Offset: 0x00458424
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010BD5 RID: 68565 RVA: 0x0045A230 File Offset: 0x00458430
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010BD6 RID: 68566 RVA: 0x0045A23C File Offset: 0x0045843C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010BD7 RID: 68567 RVA: 0x0045A248 File Offset: 0x00458448
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010BD8 RID: 68568 RVA: 0x0045A250 File Offset: 0x00458450
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06010BD9 RID: 68569 RVA: 0x0045A270 File Offset: 0x00458470
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06010BDA RID: 68570 RVA: 0x0045A27C File Offset: 0x0045847C
		private void __callDele_EventOnAddGold()
		{
			Action eventOnAddGold = this.EventOnAddGold;
			if (eventOnAddGold != null)
			{
				eventOnAddGold();
			}
		}

		// Token: 0x06010BDB RID: 68571 RVA: 0x0045A29C File Offset: 0x0045849C
		private void __clearDele_EventOnAddGold()
		{
			this.EventOnAddGold = null;
		}

		// Token: 0x06010BDC RID: 68572 RVA: 0x0045A2A8 File Offset: 0x004584A8
		private void __callDele_EventOnHeroJobUnlock(int arg1, int arg2, Action arg3)
		{
			Action<int, int, Action> eventOnHeroJobUnlock = this.EventOnHeroJobUnlock;
			if (eventOnHeroJobUnlock != null)
			{
				eventOnHeroJobUnlock(arg1, arg2, arg3);
			}
		}

		// Token: 0x06010BDD RID: 68573 RVA: 0x0045A2CC File Offset: 0x004584CC
		private void __clearDele_EventOnHeroJobUnlock(int arg1, int arg2, Action arg3)
		{
			this.EventOnHeroJobUnlock = null;
		}

		// Token: 0x06010BDE RID: 68574 RVA: 0x0045A2D8 File Offset: 0x004584D8
		private void __callDele_EventOnHeroJobTransferFinishedForUserGuide()
		{
			Action eventOnHeroJobTransferFinishedForUserGuide = this.EventOnHeroJobTransferFinishedForUserGuide;
			if (eventOnHeroJobTransferFinishedForUserGuide != null)
			{
				eventOnHeroJobTransferFinishedForUserGuide();
			}
		}

		// Token: 0x06010BDF RID: 68575 RVA: 0x0045A2F8 File Offset: 0x004584F8
		private void __clearDele_EventOnHeroJobTransferFinishedForUserGuide()
		{
			this.EventOnHeroJobTransferFinishedForUserGuide = null;
		}

		// Token: 0x06010BE0 RID: 68576 RVA: 0x0045A304 File Offset: 0x00458504
		private void __callDele_EventOnHeroJobTransfer(int arg1, int arg2, Action arg3)
		{
			Action<int, int, Action> eventOnHeroJobTransfer = this.EventOnHeroJobTransfer;
			if (eventOnHeroJobTransfer != null)
			{
				eventOnHeroJobTransfer(arg1, arg2, arg3);
			}
		}

		// Token: 0x06010BE1 RID: 68577 RVA: 0x0045A328 File Offset: 0x00458528
		private void __clearDele_EventOnHeroJobTransfer(int arg1, int arg2, Action arg3)
		{
			this.EventOnHeroJobTransfer = null;
		}

		// Token: 0x06010BE2 RID: 68578 RVA: 0x0045A334 File Offset: 0x00458534
		private void __callDele_EventOnHeroJobCardClick(ConfigDataJobConnectionInfo obj)
		{
			Action<ConfigDataJobConnectionInfo> eventOnHeroJobCardClick = this.EventOnHeroJobCardClick;
			if (eventOnHeroJobCardClick != null)
			{
				eventOnHeroJobCardClick(obj);
			}
		}

		// Token: 0x06010BE3 RID: 68579 RVA: 0x0045A358 File Offset: 0x00458558
		private void __clearDele_EventOnHeroJobCardClick(ConfigDataJobConnectionInfo obj)
		{
			this.EventOnHeroJobCardClick = null;
		}

		// Token: 0x06010BE9 RID: 68585 RVA: 0x0045A3B0 File Offset: 0x004585B0
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
					this.m_SetHeroHeroConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("SetHero") as LuaFunction);
					this.m_UpdateViewInHeroJobTransfer_hotfix = (luaObj.RawGet("UpdateViewInHeroJobTransfer") as LuaFunction);
					this.m_DrawLinesList`1_hotfix = (luaObj.RawGet("DrawLines") as LuaFunction);
					this.m_DynamicSetTransferLinesList`1_hotfix = (luaObj.RawGet("DynamicSetTransferLines") as LuaFunction);
					this.m_SetLineImageColorImageBoolean_hotfix = (luaObj.RawGet("SetLineImageColor") as LuaFunction);
					this.m_ClearGridLayout_hotfix = (luaObj.RawGet("ClearGridLayout") as LuaFunction);
					this.m_GetGridLayoutByRankInt32_hotfix = (luaObj.RawGet("GetGridLayoutByRank") as LuaFunction);
					this.m_OnJobCardItemClickHeroJobCardItemUIController_hotfix = (luaObj.RawGet("OnJobCardItemClick") as LuaFunction);
					this.m_SetHeroInfoConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("SetHeroInfo") as LuaFunction);
					this.m_SetCanLearnSkillsList`1_hotfix = (luaObj.RawGet("SetCanLearnSkills") as LuaFunction);
					this.m_SetCanLearnSoldiersList`1_hotfix = (luaObj.RawGet("SetCanLearnSoldiers") as LuaFunction);
					this.m_CloseHeroJobInfo_hotfix = (luaObj.RawGet("CloseHeroJobInfo") as LuaFunction);
					this.m_OnJobTransferButtonClick_hotfix = (luaObj.RawGet("OnJobTransferButtonClick") as LuaFunction);
					this.m_CloseJobTransferConfirmPanel_hotfix = (luaObj.RawGet("CloseJobTransferConfirmPanel") as LuaFunction);
					this.m_CloseJobTransferLockedPanel_hotfix = (luaObj.RawGet("CloseJobTransferLockedPanel") as LuaFunction);
					this.m_OnJobUnlockButtonClick_hotfix = (luaObj.RawGet("OnJobUnlockButtonClick") as LuaFunction);
					this.m_OnUnLockHeroJobReturnButtonClick_hotfix = (luaObj.RawGet("OnUnLockHeroJobReturnButtonClick") as LuaFunction);
					this.m_OnUnLockHeroJobUnlockButtonClick_hotfix = (luaObj.RawGet("OnUnLockHeroJobUnlockButtonClick") as LuaFunction);
					this.m_OnJobTransferConfirmButtonClick_hotfix = (luaObj.RawGet("OnJobTransferConfirmButtonClick") as LuaFunction);
					this.m_GetCanLearnSkillAndSoldier_hotfix = (luaObj.RawGet("GetCanLearnSkillAndSoldier") as LuaFunction);
					this.m_OnHeroJobTransferSucceed_hotfix = (luaObj.RawGet("OnHeroJobTransferSucceed") as LuaFunction);
					this.m_OnSkipBtnClick_hotfix = (luaObj.RawGet("OnSkipBtnClick") as LuaFunction);
					this.m_PlayJobTransfetEffectStep1_hotfix = (luaObj.RawGet("PlayJobTransfetEffectStep1") as LuaFunction);
					this.m_PlayJobTransfetEffectStep2_hotfix = (luaObj.RawGet("PlayJobTransfetEffectStep2") as LuaFunction);
					this.m_ShowLearnedSkillAndSoldier_hotfix = (luaObj.RawGet("ShowLearnedSkillAndSoldier") as LuaFunction);
					this.m_CloseLearnedSkillPanel_hotfix = (luaObj.RawGet("CloseLearnedSkillPanel") as LuaFunction);
					this.m_CloseLearnedPanel_hotfix = (luaObj.RawGet("CloseLearnedPanel") as LuaFunction);
					this.m_OnJobTransferEffectContinueButtonClick_hotfix = (luaObj.RawGet("OnJobTransferEffectContinueButtonClick") as LuaFunction);
					this.m_SetTransferSucceedInfo_hotfix = (luaObj.RawGet("SetTransferSucceedInfo") as LuaFunction);
					this.m_PropertyToStringInt32Int32Image_hotfix = (luaObj.RawGet("PropertyToString") as LuaFunction);
					this.m_SetImageStateImageInt32_hotfix = (luaObj.RawGet("SetImageState") as LuaFunction);
					this.m_OnMasterRewardButtonClick_hotfix = (luaObj.RawGet("OnMasterRewardButtonClick") as LuaFunction);
					this.m_CloseMasterInfoPanel_hotfix = (luaObj.RawGet("CloseMasterInfoPanel") as LuaFunction);
					this.m_CreateSpineGraphicUISpineGraphic_ConfigDataJobConnectionInfoGameObjectSingleStringInt32_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_CreateSoldierGraphicUISpineGraphic_ConfigDataSoldierInfoGameObjectSingleInt32_hotfix = (luaObj.RawGet("CreateSoldierGraphic") as LuaFunction);
					this.m_DestroyGraphicUISpineGraphic__hotfix = (luaObj.RawGet("DestroyGraphic") as LuaFunction);
					this.m_OnGoldAddButtonClick_hotfix = (luaObj.RawGet("OnGoldAddButtonClick") as LuaFunction);
					this.m_OnMagicStoneClick_hotfix = (luaObj.RawGet("OnMagicStoneClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnAddGoldAction_hotfix = (luaObj.RawGet("add_EventOnAddGold") as LuaFunction);
					this.m_remove_EventOnAddGoldAction_hotfix = (luaObj.RawGet("remove_EventOnAddGold") as LuaFunction);
					this.m_add_EventOnHeroJobUnlockAction`3_hotfix = (luaObj.RawGet("add_EventOnHeroJobUnlock") as LuaFunction);
					this.m_remove_EventOnHeroJobUnlockAction`3_hotfix = (luaObj.RawGet("remove_EventOnHeroJobUnlock") as LuaFunction);
					this.m_add_EventOnHeroJobTransferFinishedForUserGuideAction_hotfix = (luaObj.RawGet("add_EventOnHeroJobTransferFinishedForUserGuide") as LuaFunction);
					this.m_remove_EventOnHeroJobTransferFinishedForUserGuideAction_hotfix = (luaObj.RawGet("remove_EventOnHeroJobTransferFinishedForUserGuide") as LuaFunction);
					this.m_add_EventOnHeroJobTransferAction`3_hotfix = (luaObj.RawGet("add_EventOnHeroJobTransfer") as LuaFunction);
					this.m_remove_EventOnHeroJobTransferAction`3_hotfix = (luaObj.RawGet("remove_EventOnHeroJobTransfer") as LuaFunction);
					this.m_add_EventOnHeroJobCardClickAction`1_hotfix = (luaObj.RawGet("add_EventOnHeroJobCardClick") as LuaFunction);
					this.m_remove_EventOnHeroJobCardClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnHeroJobCardClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010BEA RID: 68586 RVA: 0x0045A978 File Offset: 0x00458B78
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobTransferUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009A78 RID: 39544
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04009A79 RID: 39545
		[AutoBind("./Margin/TransferPanel/TransferList/Rank1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rankLayout1;

		// Token: 0x04009A7A RID: 39546
		[AutoBind("./Margin/TransferPanel/TransferList/Rank2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rankLayout2;

		// Token: 0x04009A7B RID: 39547
		[AutoBind("./Margin/TransferPanel/TransferList/Rank3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rankLayout3;

		// Token: 0x04009A7C RID: 39548
		[AutoBind("./Margin/TransferPanel/TransferList/Rank4", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rankLayout4;

		// Token: 0x04009A7D RID: 39549
		[AutoBind("./Margin/TransferPanel/TransferList/Line", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rankLine1;

		// Token: 0x04009A7E RID: 39550
		[AutoBind("./Margin/TransferPanel/TransferList/Line/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rankLine1Image;

		// Token: 0x04009A7F RID: 39551
		[AutoBind("./Margin/TransferPanel/TransferList/Line2/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rankLine2Image;

		// Token: 0x04009A80 RID: 39552
		[AutoBind("./Margin/TransferPanel/TransferList/Line2/Image1", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rankLine2Image1;

		// Token: 0x04009A81 RID: 39553
		[AutoBind("./Margin/TransferPanel/TransferList/Line2/Image2", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rankLine2Image2;

		// Token: 0x04009A82 RID: 39554
		[AutoBind("./Margin/TransferPanel/TransferList/Line3/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rankLine3Image;

		// Token: 0x04009A83 RID: 39555
		[AutoBind("./Margin/TransferPanel/TransferList/Line3/Image1", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rankLine3Image1;

		// Token: 0x04009A84 RID: 39556
		[AutoBind("./Margin/TransferPanel/TransferList/Line3/Image2", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rankLine3Image2;

		// Token: 0x04009A85 RID: 39557
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04009A86 RID: 39558
		[AutoBind("./Gold/NumText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_goldNumText;

		// Token: 0x04009A87 RID: 39559
		[AutoBind("./Gold/AddBtn", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_goldAddBtn;

		// Token: 0x04009A88 RID: 39560
		[AutoBind("./MagicStone/NumText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_magicStoneNumText;

		// Token: 0x04009A89 RID: 39561
		[AutoBind("./MagicStone/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_magicStoneBtn;

		// Token: 0x04009A8A RID: 39562
		[AutoBind("./HeroJobInfo", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroJobInfoPanelObj;

		// Token: 0x04009A8B RID: 39563
		[AutoBind("./HeroJobInfo/JobBaseInfo/JobNameGroup/JobNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobNameText;

		// Token: 0x04009A8C RID: 39564
		[AutoBind("./HeroJobInfo/JobBaseInfo/JobNameGroup/JobNameEnText/JobNameEnText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobNameEnText;

		// Token: 0x04009A8D RID: 39565
		[AutoBind("./HeroJobInfo/JobBaseInfo/Faction/TypeBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobTypeBgImage;

		// Token: 0x04009A8E RID: 39566
		[AutoBind("./HeroJobInfo/JobBaseInfo/Faction/TypeBgImage2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobTypeBgImage2;

		// Token: 0x04009A8F RID: 39567
		[AutoBind("./HeroJobInfo/JobBaseInfo/Faction/TypeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobTypeText;

		// Token: 0x04009A90 RID: 39568
		[AutoBind("./HeroJobInfo/JobBaseInfo/Faction/MoveValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobMoveValueText;

		// Token: 0x04009A91 RID: 39569
		[AutoBind("./HeroJobInfo/JobBaseInfo/Faction/RangeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobRangeValueText;

		// Token: 0x04009A92 RID: 39570
		[AutoBind("./HeroJobInfo/JobBaseInfo/Advantage/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobAdvantageText;

		// Token: 0x04009A93 RID: 39571
		[AutoBind("./HeroJobInfo/JobBaseInfo/Advantage/Text1", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobAdvantageText1;

		// Token: 0x04009A94 RID: 39572
		[AutoBind("./HeroJobInfo/JobBaseInfo/Advantage/Text2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobAdvantageText2;

		// Token: 0x04009A95 RID: 39573
		[AutoBind("./HeroJobInfo/HeroGraphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroGraphicObj;

		// Token: 0x04009A96 RID: 39574
		[AutoBind("./HeroJobInfo/JobBaseInfo/JobSoldierTypeImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobSoldierTypeImage;

		// Token: 0x04009A97 RID: 39575
		[AutoBind("./HeroJobInfo/JobTransferButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_jobTransferButton;

		// Token: 0x04009A98 RID: 39576
		[AutoBind("./HeroJobInfo/JobUnlockButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_jobUnlockButton;

		// Token: 0x04009A99 RID: 39577
		[AutoBind("./Margin/TransferPanel/MasterButtonGroup/MasterButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_masterButton;

		// Token: 0x04009A9A RID: 39578
		[AutoBind("./Margin/TransferPanel/MasterButtonGroup/AlreadyMaster/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_alreadyMasterValueText;

		// Token: 0x04009A9B RID: 39579
		[AutoBind("./MasterInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_masterInfoPanel;

		// Token: 0x04009A9C RID: 39580
		[AutoBind("./MasterInfoPanel/BGButtonImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_masterInfoPanelReturnButton;

		// Token: 0x04009A9D RID: 39581
		[AutoBind("./MasterInfoPanel/Detail/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_masterInfoPanelScrollViewContent;

		// Token: 0x04009A9E RID: 39582
		[AutoBind("./Prefab/JobInfo", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_masterItemPrefab;

		// Token: 0x04009A9F RID: 39583
		[AutoBind("./HeroJobInfo/JobBaseInfo/JobLv/BreakBGImageGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobLvBgImagesGroup;

		// Token: 0x04009AA0 RID: 39584
		[AutoBind("./HeroJobInfo/JobBaseInfo/JobLv/BreakIconImageGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobLvImagesGroup;

		// Token: 0x04009AA1 RID: 39585
		[AutoBind("./HeroJobInfo/LearnedSkill/SkillIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedSkillIconImg;

		// Token: 0x04009AA2 RID: 39586
		[AutoBind("./HeroJobInfo/LearnedSkill/SkillIconImage2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedSkillIconImg2;

		// Token: 0x04009AA3 RID: 39587
		[AutoBind("./HeroJobInfo/SkillDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailPanel;

		// Token: 0x04009AA4 RID: 39588
		[AutoBind("./HeroJobInfo/LearnedSoldier/GraphicParent/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedSoldierGraphicObj;

		// Token: 0x04009AA5 RID: 39589
		[AutoBind("./HeroJobInfo/LearnedSoldier/GraphicParent/Graphic2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedSoldierGraphicObj2;

		// Token: 0x04009AA6 RID: 39590
		[AutoBind("./HeroJobInfo/LearnedSoldier/GraphicParent/Graphic/GraphicBgImg", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedSoldierGraphicBg;

		// Token: 0x04009AA7 RID: 39591
		[AutoBind("./HeroJobInfo/LearnedSoldier/GraphicParent/Graphic2/Graphic2BgImg", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedSoldierGraphicBg2;

		// Token: 0x04009AA8 RID: 39592
		[AutoBind("./HeroJobInfo/SoldierDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierDetailPanel;

		// Token: 0x04009AA9 RID: 39593
		[AutoBind("./HeroJobInfo/LockedPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_transferLockPanel;

		// Token: 0x04009AAA RID: 39594
		[AutoBind("./HeroJobInfo/LockedPanel/BgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_transferLockPanelReturnBg;

		// Token: 0x04009AAB RID: 39595
		[AutoBind("./HeroJobInfo/LockedPanel/QuesText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_transferLockQuesText;

		// Token: 0x04009AAC RID: 39596
		[AutoBind("./HeroJobInfo/LockedPanel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_transferLockConfirmButton;

		// Token: 0x04009AAD RID: 39597
		[AutoBind("./HeroJobInfo/ConfirmPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_transferConfirmPanel;

		// Token: 0x04009AAE RID: 39598
		[AutoBind("./HeroJobInfo/ConfirmPanel/JobNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_confirmPanelJobNameText;

		// Token: 0x04009AAF RID: 39599
		[AutoBind("./HeroJobInfo/ConfirmPanel/GoldCostValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_goldCostValueText;

		// Token: 0x04009AB0 RID: 39600
		[AutoBind("./HeroJobInfo/ConfirmPanel/MagicStoneCostValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_magicStoneCostValueText;

		// Token: 0x04009AB1 RID: 39601
		[AutoBind("./HeroJobInfo/ConfirmPanel/BgButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_confirmBgButton;

		// Token: 0x04009AB2 RID: 39602
		[AutoBind("./HeroJobInfo/ConfirmPanel/ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_confirmReturnButton;

		// Token: 0x04009AB3 RID: 39603
		[AutoBind("./HeroJobInfo/ConfirmPanel/TransferButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_confirmTransferButton;

		// Token: 0x04009AB4 RID: 39604
		[AutoBind("./HeroJobInfo/ConfirmPanel/NoticeText", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_confirmTransferNoticeTextStateCtrl;

		// Token: 0x04009AB5 RID: 39605
		[AutoBind("./HeroJobInfo/UnLockHeroJobPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_unLockHeroJobPanel;

		// Token: 0x04009AB6 RID: 39606
		[AutoBind("./HeroJobInfo/UnLockHeroJobPanel/JobNameText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unLockHeroJobPanelJobNameText;

		// Token: 0x04009AB7 RID: 39607
		[AutoBind("./HeroJobInfo/UnLockHeroJobPanel/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_unLockHeroJobConditionsContentObj;

		// Token: 0x04009AB8 RID: 39608
		[AutoBind("./HeroJobInfo/Prefab/UnlcokConditionItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_unlcokJobConditionPrefab;

		// Token: 0x04009AB9 RID: 39609
		[AutoBind("./HeroJobInfo/UnLockHeroJobPanel/ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_unLockHeroJobReturnButton;

		// Token: 0x04009ABA RID: 39610
		[AutoBind("./HeroJobInfo/UnLockHeroJobPanel/UnlockButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_unLockHeroJobUnlockButton;

		// Token: 0x04009ABB RID: 39611
		[AutoBind("./HeroJobInfo/SkipButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_jobTransferEffectSkipBtn;

		// Token: 0x04009ABC RID: 39612
		[AutoBind("./HeroJobInfo/BgEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_JobTransferEffectBgObj;

		// Token: 0x04009ABD RID: 39613
		[AutoBind("./HeroJobInfo/BgEffect/BlackImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_JobTransferEffectBlackImage;

		// Token: 0x04009ABE RID: 39614
		[AutoBind("./HeroJobInfo/WhiteImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_JobTransferEffectWhiteImage;

		// Token: 0x04009ABF RID: 39615
		[AutoBind("./HeroJobInfo/BgEffect/BgImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_JobTransferEffectBgImage;

		// Token: 0x04009AC0 RID: 39616
		[AutoBind("./HeroJobInfo/BgEffect/ContinueButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_jobTransferEffectContinueButton;

		// Token: 0x04009AC1 RID: 39617
		[AutoBind("./HeroJobInfo/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroATGraphicObj;

		// Token: 0x04009AC2 RID: 39618
		[AutoBind("./HeroJobInfo/GroundImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobTransferGroundImage;

		// Token: 0x04009AC3 RID: 39619
		[AutoBind("./HeroJobInfo/JobChangeSucceedText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobChangeSucceedText;

		// Token: 0x04009AC4 RID: 39620
		[AutoBind("./HeroJobInfo/Graphic/UI_JobChange_1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroATGraphicJobChangeEffectObj1;

		// Token: 0x04009AC5 RID: 39621
		[AutoBind("./HeroJobInfo/Graphic/UI_JobChange_2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroATGraphicJobChangeEffectObj2;

		// Token: 0x04009AC6 RID: 39622
		[AutoBind("./HeroJobInfo/JobUpgradeInfo", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobUpgradeInfo;

		// Token: 0x04009AC7 RID: 39623
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/Hp/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobTransHpText;

		// Token: 0x04009AC8 RID: 39624
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobTransATText;

		// Token: 0x04009AC9 RID: 39625
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobTransDFText;

		// Token: 0x04009ACA RID: 39626
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/Magic/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobTransMagicText;

		// Token: 0x04009ACB RID: 39627
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobTransMagicDFText;

		// Token: 0x04009ACC RID: 39628
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/DEX/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobTransDEXText;

		// Token: 0x04009ACD RID: 39629
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/Hp/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobTransHpImage;

		// Token: 0x04009ACE RID: 39630
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/AT/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobTransATImage;

		// Token: 0x04009ACF RID: 39631
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/DF/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobTransDFImage;

		// Token: 0x04009AD0 RID: 39632
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/Magic/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobTransMagicImage;

		// Token: 0x04009AD1 RID: 39633
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/MagicDF/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobTransMagicDFImage;

		// Token: 0x04009AD2 RID: 39634
		[AutoBind("./HeroJobInfo/JobUpgradeInfo/RightPanel/DEX/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobTransDEXImage;

		// Token: 0x04009AD3 RID: 39635
		[AutoBind("./HeroJobInfo/LearnedPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedPanel;

		// Token: 0x04009AD4 RID: 39636
		[AutoBind("./HeroJobInfo/LearnedPanel/CloseImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_learnedPanelCloseBtn;

		// Token: 0x04009AD5 RID: 39637
		[AutoBind("./HeroJobInfo/LearnedPanel/Skill/ReturnImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_learnedPanelSkillCloseBtn;

		// Token: 0x04009AD6 RID: 39638
		[AutoBind("./HeroJobInfo/LearnedPanel/Skill", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedPanelSkillPanel;

		// Token: 0x04009AD7 RID: 39639
		[AutoBind("./HeroJobInfo/LearnedPanel/Soldier", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedPanelSoldierPanel;

		// Token: 0x04009AD8 RID: 39640
		[AutoBind("./HeroJobInfo/LearnedPanel/Skill/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_learnedPanelSkillIcon;

		// Token: 0x04009AD9 RID: 39641
		[AutoBind("./HeroJobInfo/LearnedPanel/Soldier/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedPanelSoldierGraphicObj;

		// Token: 0x04009ADA RID: 39642
		[AutoBind("./HeroJobInfo/LearnedPanel/Skill/Name", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_learnedPanelSkillName;

		// Token: 0x04009ADB RID: 39643
		[AutoBind("./HeroJobInfo/LearnedPanel/Soldier/Name", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_learnedPanelSoldierName;

		// Token: 0x04009ADC RID: 39644
		private UISpineGraphic m_heroGraphic;

		// Token: 0x04009ADD RID: 39645
		private UISpineGraphic m_heroATGraphic;

		// Token: 0x04009ADE RID: 39646
		private UISpineGraphic m_soldierGraphicL;

		// Token: 0x04009ADF RID: 39647
		private UISpineGraphic m_soldierGraphicR;

		// Token: 0x04009AE0 RID: 39648
		private UISpineGraphic m_learndSoldierGraphic;

		// Token: 0x04009AE1 RID: 39649
		private Hero m_hero;

		// Token: 0x04009AE2 RID: 39650
		private List<int> m_jobConnectionIds;

		// Token: 0x04009AE3 RID: 39651
		private List<int> m_oldSkillInfoList;

		// Token: 0x04009AE4 RID: 39652
		private List<int> m_oldSoldierInfoList;

		// Token: 0x04009AE5 RID: 39653
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x04009AE6 RID: 39654
		private HeroPropertyComputer m_curComputer;

		// Token: 0x04009AE7 RID: 39655
		private HeroPropertyComputer m_oldComputer;

		// Token: 0x04009AE8 RID: 39656
		private ConfigDataJobConnectionInfo m_curJobConnectionInfo;

		// Token: 0x04009AE9 RID: 39657
		private ConfigDataJobConnectionInfo m_oldJobConnectionInfo;

		// Token: 0x04009AEA RID: 39658
		private Dictionary<int, HeroJobCardItemUIController> m_jobConnectionIdToJobCardCtrlDict;

		// Token: 0x04009AEB RID: 39659
		private bool m_isJobLocked;

		// Token: 0x04009AEC RID: 39660
		private bool m_isNeedMagicStone;

		// Token: 0x04009AED RID: 39661
		private bool m_isShowLearnSkill;

		// Token: 0x04009AEE RID: 39662
		private bool m_isShowLearnSoldier;

		// Token: 0x04009AEF RID: 39663
		private bool m_isJobHasTransfered;

		// Token: 0x04009AF0 RID: 39664
		private bool m_isJobTransferContinue;

		// Token: 0x04009AF1 RID: 39665
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009AF2 RID: 39666
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009AF3 RID: 39667
		[DoNotToLua]
		private HeroJobTransferUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009AF4 RID: 39668
		[CompilerGenerated]
		private static Comparison<int> <>f__mg$cache0;

		// Token: 0x04009AF6 RID: 39670
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009AF7 RID: 39671
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009AF8 RID: 39672
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009AF9 RID: 39673
		private LuaFunction m_SetHeroHeroConfigDataJobConnectionInfo_hotfix;

		// Token: 0x04009AFA RID: 39674
		private LuaFunction m_UpdateViewInHeroJobTransfer_hotfix;

		// Token: 0x04009AFB RID: 39675
		private LuaFunction m_DrawLinesList;

		// Token: 0x04009AFC RID: 39676
		private LuaFunction m_DynamicSetTransferLinesList;

		// Token: 0x04009AFD RID: 39677
		private LuaFunction m_SetLineImageColorImageBoolean_hotfix;

		// Token: 0x04009AFE RID: 39678
		private LuaFunction m_ClearGridLayout_hotfix;

		// Token: 0x04009AFF RID: 39679
		private LuaFunction m_GetGridLayoutByRankInt32_hotfix;

		// Token: 0x04009B00 RID: 39680
		private LuaFunction m_OnJobCardItemClickHeroJobCardItemUIController_hotfix;

		// Token: 0x04009B01 RID: 39681
		private LuaFunction m_SetHeroInfoConfigDataJobConnectionInfo_hotfix;

		// Token: 0x04009B02 RID: 39682
		private LuaFunction m_SetCanLearnSkillsList;

		// Token: 0x04009B03 RID: 39683
		private LuaFunction m_SetCanLearnSoldiersList;

		// Token: 0x04009B04 RID: 39684
		private LuaFunction m_CloseHeroJobInfo_hotfix;

		// Token: 0x04009B05 RID: 39685
		private LuaFunction m_OnJobTransferButtonClick_hotfix;

		// Token: 0x04009B06 RID: 39686
		private LuaFunction m_CloseJobTransferConfirmPanel_hotfix;

		// Token: 0x04009B07 RID: 39687
		private LuaFunction m_CloseJobTransferLockedPanel_hotfix;

		// Token: 0x04009B08 RID: 39688
		private LuaFunction m_OnJobUnlockButtonClick_hotfix;

		// Token: 0x04009B09 RID: 39689
		private LuaFunction m_OnUnLockHeroJobReturnButtonClick_hotfix;

		// Token: 0x04009B0A RID: 39690
		private LuaFunction m_OnUnLockHeroJobUnlockButtonClick_hotfix;

		// Token: 0x04009B0B RID: 39691
		private LuaFunction m_OnJobTransferConfirmButtonClick_hotfix;

		// Token: 0x04009B0C RID: 39692
		private LuaFunction m_GetCanLearnSkillAndSoldier_hotfix;

		// Token: 0x04009B0D RID: 39693
		private LuaFunction m_OnHeroJobTransferSucceed_hotfix;

		// Token: 0x04009B0E RID: 39694
		private LuaFunction m_OnSkipBtnClick_hotfix;

		// Token: 0x04009B0F RID: 39695
		private LuaFunction m_PlayJobTransfetEffectStep1_hotfix;

		// Token: 0x04009B10 RID: 39696
		private LuaFunction m_PlayJobTransfetEffectStep2_hotfix;

		// Token: 0x04009B11 RID: 39697
		private LuaFunction m_ShowLearnedSkillAndSoldier_hotfix;

		// Token: 0x04009B12 RID: 39698
		private LuaFunction m_CloseLearnedSkillPanel_hotfix;

		// Token: 0x04009B13 RID: 39699
		private LuaFunction m_CloseLearnedPanel_hotfix;

		// Token: 0x04009B14 RID: 39700
		private LuaFunction m_OnJobTransferEffectContinueButtonClick_hotfix;

		// Token: 0x04009B15 RID: 39701
		private LuaFunction m_SetTransferSucceedInfo_hotfix;

		// Token: 0x04009B16 RID: 39702
		private LuaFunction m_PropertyToStringInt32Int32Image_hotfix;

		// Token: 0x04009B17 RID: 39703
		private LuaFunction m_SetImageStateImageInt32_hotfix;

		// Token: 0x04009B18 RID: 39704
		private LuaFunction m_OnMasterRewardButtonClick_hotfix;

		// Token: 0x04009B19 RID: 39705
		private LuaFunction m_CloseMasterInfoPanel_hotfix;

		// Token: 0x04009B1A RID: 39706
		private LuaFunction m_CreateSpineGraphicUISpineGraphic_ConfigDataJobConnectionInfoGameObjectSingleStringInt32_hotfix;

		// Token: 0x04009B1B RID: 39707
		private LuaFunction m_CreateSoldierGraphicUISpineGraphic_ConfigDataSoldierInfoGameObjectSingleInt32_hotfix;

		// Token: 0x04009B1C RID: 39708
		private LuaFunction m_DestroyGraphicUISpineGraphic__hotfix;

		// Token: 0x04009B1D RID: 39709
		private LuaFunction m_OnGoldAddButtonClick_hotfix;

		// Token: 0x04009B1E RID: 39710
		private LuaFunction m_OnMagicStoneClick_hotfix;

		// Token: 0x04009B1F RID: 39711
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04009B20 RID: 39712
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04009B21 RID: 39713
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04009B22 RID: 39714
		private LuaFunction m_add_EventOnAddGoldAction_hotfix;

		// Token: 0x04009B23 RID: 39715
		private LuaFunction m_remove_EventOnAddGoldAction_hotfix;

		// Token: 0x04009B24 RID: 39716
		private LuaFunction m_add_EventOnHeroJobUnlockAction;

		// Token: 0x04009B25 RID: 39717
		private LuaFunction m_remove_EventOnHeroJobUnlockAction;

		// Token: 0x04009B26 RID: 39718
		private LuaFunction m_add_EventOnHeroJobTransferFinishedForUserGuideAction_hotfix;

		// Token: 0x04009B27 RID: 39719
		private LuaFunction m_remove_EventOnHeroJobTransferFinishedForUserGuideAction_hotfix;

		// Token: 0x04009B28 RID: 39720
		private LuaFunction m_add_EventOnHeroJobTransferAction;

		// Token: 0x04009B29 RID: 39721
		private LuaFunction m_remove_EventOnHeroJobTransferAction;

		// Token: 0x04009B2A RID: 39722
		private LuaFunction m_add_EventOnHeroJobCardClickAction;

		// Token: 0x04009B2B RID: 39723
		private LuaFunction m_remove_EventOnHeroJobCardClickAction;

		// Token: 0x02000DBE RID: 3518
		public new class LuaExportHelper
		{
			// Token: 0x06010BEB RID: 68587 RVA: 0x0045A9E0 File Offset: 0x00458BE0
			public LuaExportHelper(HeroJobTransferUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010BEC RID: 68588 RVA: 0x0045A9F0 File Offset: 0x00458BF0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010BED RID: 68589 RVA: 0x0045AA00 File Offset: 0x00458C00
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010BEE RID: 68590 RVA: 0x0045AA10 File Offset: 0x00458C10
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010BEF RID: 68591 RVA: 0x0045AA20 File Offset: 0x00458C20
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010BF0 RID: 68592 RVA: 0x0045AA38 File Offset: 0x00458C38
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010BF1 RID: 68593 RVA: 0x0045AA48 File Offset: 0x00458C48
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010BF2 RID: 68594 RVA: 0x0045AA58 File Offset: 0x00458C58
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010BF3 RID: 68595 RVA: 0x0045AA68 File Offset: 0x00458C68
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010BF4 RID: 68596 RVA: 0x0045AA78 File Offset: 0x00458C78
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010BF5 RID: 68597 RVA: 0x0045AA88 File Offset: 0x00458C88
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010BF6 RID: 68598 RVA: 0x0045AA98 File Offset: 0x00458C98
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010BF7 RID: 68599 RVA: 0x0045AAA8 File Offset: 0x00458CA8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010BF8 RID: 68600 RVA: 0x0045AAB8 File Offset: 0x00458CB8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010BF9 RID: 68601 RVA: 0x0045AAC8 File Offset: 0x00458CC8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010BFA RID: 68602 RVA: 0x0045AAD8 File Offset: 0x00458CD8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010BFB RID: 68603 RVA: 0x0045AAE8 File Offset: 0x00458CE8
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06010BFC RID: 68604 RVA: 0x0045AAF8 File Offset: 0x00458CF8
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06010BFD RID: 68605 RVA: 0x0045AB08 File Offset: 0x00458D08
			public void __callDele_EventOnAddGold()
			{
				this.m_owner.__callDele_EventOnAddGold();
			}

			// Token: 0x06010BFE RID: 68606 RVA: 0x0045AB18 File Offset: 0x00458D18
			public void __clearDele_EventOnAddGold()
			{
				this.m_owner.__clearDele_EventOnAddGold();
			}

			// Token: 0x06010BFF RID: 68607 RVA: 0x0045AB28 File Offset: 0x00458D28
			public void __callDele_EventOnHeroJobUnlock(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__callDele_EventOnHeroJobUnlock(arg1, arg2, arg3);
			}

			// Token: 0x06010C00 RID: 68608 RVA: 0x0045AB38 File Offset: 0x00458D38
			public void __clearDele_EventOnHeroJobUnlock(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__clearDele_EventOnHeroJobUnlock(arg1, arg2, arg3);
			}

			// Token: 0x06010C01 RID: 68609 RVA: 0x0045AB48 File Offset: 0x00458D48
			public void __callDele_EventOnHeroJobTransferFinishedForUserGuide()
			{
				this.m_owner.__callDele_EventOnHeroJobTransferFinishedForUserGuide();
			}

			// Token: 0x06010C02 RID: 68610 RVA: 0x0045AB58 File Offset: 0x00458D58
			public void __clearDele_EventOnHeroJobTransferFinishedForUserGuide()
			{
				this.m_owner.__clearDele_EventOnHeroJobTransferFinishedForUserGuide();
			}

			// Token: 0x06010C03 RID: 68611 RVA: 0x0045AB68 File Offset: 0x00458D68
			public void __callDele_EventOnHeroJobTransfer(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__callDele_EventOnHeroJobTransfer(arg1, arg2, arg3);
			}

			// Token: 0x06010C04 RID: 68612 RVA: 0x0045AB78 File Offset: 0x00458D78
			public void __clearDele_EventOnHeroJobTransfer(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__clearDele_EventOnHeroJobTransfer(arg1, arg2, arg3);
			}

			// Token: 0x06010C05 RID: 68613 RVA: 0x0045AB88 File Offset: 0x00458D88
			public void __callDele_EventOnHeroJobCardClick(ConfigDataJobConnectionInfo obj)
			{
				this.m_owner.__callDele_EventOnHeroJobCardClick(obj);
			}

			// Token: 0x06010C06 RID: 68614 RVA: 0x0045AB98 File Offset: 0x00458D98
			public void __clearDele_EventOnHeroJobCardClick(ConfigDataJobConnectionInfo obj)
			{
				this.m_owner.__clearDele_EventOnHeroJobCardClick(obj);
			}

			// Token: 0x170033B7 RID: 13239
			// (get) Token: 0x06010C07 RID: 68615 RVA: 0x0045ABA8 File Offset: 0x00458DA8
			// (set) Token: 0x06010C08 RID: 68616 RVA: 0x0045ABB8 File Offset: 0x00458DB8
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x170033B8 RID: 13240
			// (get) Token: 0x06010C09 RID: 68617 RVA: 0x0045ABC8 File Offset: 0x00458DC8
			// (set) Token: 0x06010C0A RID: 68618 RVA: 0x0045ABD8 File Offset: 0x00458DD8
			public GameObject m_rankLayout1
			{
				get
				{
					return this.m_owner.m_rankLayout1;
				}
				set
				{
					this.m_owner.m_rankLayout1 = value;
				}
			}

			// Token: 0x170033B9 RID: 13241
			// (get) Token: 0x06010C0B RID: 68619 RVA: 0x0045ABE8 File Offset: 0x00458DE8
			// (set) Token: 0x06010C0C RID: 68620 RVA: 0x0045ABF8 File Offset: 0x00458DF8
			public GameObject m_rankLayout2
			{
				get
				{
					return this.m_owner.m_rankLayout2;
				}
				set
				{
					this.m_owner.m_rankLayout2 = value;
				}
			}

			// Token: 0x170033BA RID: 13242
			// (get) Token: 0x06010C0D RID: 68621 RVA: 0x0045AC08 File Offset: 0x00458E08
			// (set) Token: 0x06010C0E RID: 68622 RVA: 0x0045AC18 File Offset: 0x00458E18
			public GameObject m_rankLayout3
			{
				get
				{
					return this.m_owner.m_rankLayout3;
				}
				set
				{
					this.m_owner.m_rankLayout3 = value;
				}
			}

			// Token: 0x170033BB RID: 13243
			// (get) Token: 0x06010C0F RID: 68623 RVA: 0x0045AC28 File Offset: 0x00458E28
			// (set) Token: 0x06010C10 RID: 68624 RVA: 0x0045AC38 File Offset: 0x00458E38
			public GameObject m_rankLayout4
			{
				get
				{
					return this.m_owner.m_rankLayout4;
				}
				set
				{
					this.m_owner.m_rankLayout4 = value;
				}
			}

			// Token: 0x170033BC RID: 13244
			// (get) Token: 0x06010C11 RID: 68625 RVA: 0x0045AC48 File Offset: 0x00458E48
			// (set) Token: 0x06010C12 RID: 68626 RVA: 0x0045AC58 File Offset: 0x00458E58
			public GameObject m_rankLine1
			{
				get
				{
					return this.m_owner.m_rankLine1;
				}
				set
				{
					this.m_owner.m_rankLine1 = value;
				}
			}

			// Token: 0x170033BD RID: 13245
			// (get) Token: 0x06010C13 RID: 68627 RVA: 0x0045AC68 File Offset: 0x00458E68
			// (set) Token: 0x06010C14 RID: 68628 RVA: 0x0045AC78 File Offset: 0x00458E78
			public Image m_rankLine1Image
			{
				get
				{
					return this.m_owner.m_rankLine1Image;
				}
				set
				{
					this.m_owner.m_rankLine1Image = value;
				}
			}

			// Token: 0x170033BE RID: 13246
			// (get) Token: 0x06010C15 RID: 68629 RVA: 0x0045AC88 File Offset: 0x00458E88
			// (set) Token: 0x06010C16 RID: 68630 RVA: 0x0045AC98 File Offset: 0x00458E98
			public Image m_rankLine2Image
			{
				get
				{
					return this.m_owner.m_rankLine2Image;
				}
				set
				{
					this.m_owner.m_rankLine2Image = value;
				}
			}

			// Token: 0x170033BF RID: 13247
			// (get) Token: 0x06010C17 RID: 68631 RVA: 0x0045ACA8 File Offset: 0x00458EA8
			// (set) Token: 0x06010C18 RID: 68632 RVA: 0x0045ACB8 File Offset: 0x00458EB8
			public Image m_rankLine2Image1
			{
				get
				{
					return this.m_owner.m_rankLine2Image1;
				}
				set
				{
					this.m_owner.m_rankLine2Image1 = value;
				}
			}

			// Token: 0x170033C0 RID: 13248
			// (get) Token: 0x06010C19 RID: 68633 RVA: 0x0045ACC8 File Offset: 0x00458EC8
			// (set) Token: 0x06010C1A RID: 68634 RVA: 0x0045ACD8 File Offset: 0x00458ED8
			public Image m_rankLine2Image2
			{
				get
				{
					return this.m_owner.m_rankLine2Image2;
				}
				set
				{
					this.m_owner.m_rankLine2Image2 = value;
				}
			}

			// Token: 0x170033C1 RID: 13249
			// (get) Token: 0x06010C1B RID: 68635 RVA: 0x0045ACE8 File Offset: 0x00458EE8
			// (set) Token: 0x06010C1C RID: 68636 RVA: 0x0045ACF8 File Offset: 0x00458EF8
			public Image m_rankLine3Image
			{
				get
				{
					return this.m_owner.m_rankLine3Image;
				}
				set
				{
					this.m_owner.m_rankLine3Image = value;
				}
			}

			// Token: 0x170033C2 RID: 13250
			// (get) Token: 0x06010C1D RID: 68637 RVA: 0x0045AD08 File Offset: 0x00458F08
			// (set) Token: 0x06010C1E RID: 68638 RVA: 0x0045AD18 File Offset: 0x00458F18
			public Image m_rankLine3Image1
			{
				get
				{
					return this.m_owner.m_rankLine3Image1;
				}
				set
				{
					this.m_owner.m_rankLine3Image1 = value;
				}
			}

			// Token: 0x170033C3 RID: 13251
			// (get) Token: 0x06010C1F RID: 68639 RVA: 0x0045AD28 File Offset: 0x00458F28
			// (set) Token: 0x06010C20 RID: 68640 RVA: 0x0045AD38 File Offset: 0x00458F38
			public Image m_rankLine3Image2
			{
				get
				{
					return this.m_owner.m_rankLine3Image2;
				}
				set
				{
					this.m_owner.m_rankLine3Image2 = value;
				}
			}

			// Token: 0x170033C4 RID: 13252
			// (get) Token: 0x06010C21 RID: 68641 RVA: 0x0045AD48 File Offset: 0x00458F48
			// (set) Token: 0x06010C22 RID: 68642 RVA: 0x0045AD58 File Offset: 0x00458F58
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

			// Token: 0x170033C5 RID: 13253
			// (get) Token: 0x06010C23 RID: 68643 RVA: 0x0045AD68 File Offset: 0x00458F68
			// (set) Token: 0x06010C24 RID: 68644 RVA: 0x0045AD78 File Offset: 0x00458F78
			public Text m_goldNumText
			{
				get
				{
					return this.m_owner.m_goldNumText;
				}
				set
				{
					this.m_owner.m_goldNumText = value;
				}
			}

			// Token: 0x170033C6 RID: 13254
			// (get) Token: 0x06010C25 RID: 68645 RVA: 0x0045AD88 File Offset: 0x00458F88
			// (set) Token: 0x06010C26 RID: 68646 RVA: 0x0045AD98 File Offset: 0x00458F98
			public Button m_goldAddBtn
			{
				get
				{
					return this.m_owner.m_goldAddBtn;
				}
				set
				{
					this.m_owner.m_goldAddBtn = value;
				}
			}

			// Token: 0x170033C7 RID: 13255
			// (get) Token: 0x06010C27 RID: 68647 RVA: 0x0045ADA8 File Offset: 0x00458FA8
			// (set) Token: 0x06010C28 RID: 68648 RVA: 0x0045ADB8 File Offset: 0x00458FB8
			public Text m_magicStoneNumText
			{
				get
				{
					return this.m_owner.m_magicStoneNumText;
				}
				set
				{
					this.m_owner.m_magicStoneNumText = value;
				}
			}

			// Token: 0x170033C8 RID: 13256
			// (get) Token: 0x06010C29 RID: 68649 RVA: 0x0045ADC8 File Offset: 0x00458FC8
			// (set) Token: 0x06010C2A RID: 68650 RVA: 0x0045ADD8 File Offset: 0x00458FD8
			public Button m_magicStoneBtn
			{
				get
				{
					return this.m_owner.m_magicStoneBtn;
				}
				set
				{
					this.m_owner.m_magicStoneBtn = value;
				}
			}

			// Token: 0x170033C9 RID: 13257
			// (get) Token: 0x06010C2B RID: 68651 RVA: 0x0045ADE8 File Offset: 0x00458FE8
			// (set) Token: 0x06010C2C RID: 68652 RVA: 0x0045ADF8 File Offset: 0x00458FF8
			public GameObject m_heroJobInfoPanelObj
			{
				get
				{
					return this.m_owner.m_heroJobInfoPanelObj;
				}
				set
				{
					this.m_owner.m_heroJobInfoPanelObj = value;
				}
			}

			// Token: 0x170033CA RID: 13258
			// (get) Token: 0x06010C2D RID: 68653 RVA: 0x0045AE08 File Offset: 0x00459008
			// (set) Token: 0x06010C2E RID: 68654 RVA: 0x0045AE18 File Offset: 0x00459018
			public Text m_jobNameText
			{
				get
				{
					return this.m_owner.m_jobNameText;
				}
				set
				{
					this.m_owner.m_jobNameText = value;
				}
			}

			// Token: 0x170033CB RID: 13259
			// (get) Token: 0x06010C2F RID: 68655 RVA: 0x0045AE28 File Offset: 0x00459028
			// (set) Token: 0x06010C30 RID: 68656 RVA: 0x0045AE38 File Offset: 0x00459038
			public Text m_jobNameEnText
			{
				get
				{
					return this.m_owner.m_jobNameEnText;
				}
				set
				{
					this.m_owner.m_jobNameEnText = value;
				}
			}

			// Token: 0x170033CC RID: 13260
			// (get) Token: 0x06010C31 RID: 68657 RVA: 0x0045AE48 File Offset: 0x00459048
			// (set) Token: 0x06010C32 RID: 68658 RVA: 0x0045AE58 File Offset: 0x00459058
			public GameObject m_jobTypeBgImage
			{
				get
				{
					return this.m_owner.m_jobTypeBgImage;
				}
				set
				{
					this.m_owner.m_jobTypeBgImage = value;
				}
			}

			// Token: 0x170033CD RID: 13261
			// (get) Token: 0x06010C33 RID: 68659 RVA: 0x0045AE68 File Offset: 0x00459068
			// (set) Token: 0x06010C34 RID: 68660 RVA: 0x0045AE78 File Offset: 0x00459078
			public GameObject m_jobTypeBgImage2
			{
				get
				{
					return this.m_owner.m_jobTypeBgImage2;
				}
				set
				{
					this.m_owner.m_jobTypeBgImage2 = value;
				}
			}

			// Token: 0x170033CE RID: 13262
			// (get) Token: 0x06010C35 RID: 68661 RVA: 0x0045AE88 File Offset: 0x00459088
			// (set) Token: 0x06010C36 RID: 68662 RVA: 0x0045AE98 File Offset: 0x00459098
			public Text m_jobTypeText
			{
				get
				{
					return this.m_owner.m_jobTypeText;
				}
				set
				{
					this.m_owner.m_jobTypeText = value;
				}
			}

			// Token: 0x170033CF RID: 13263
			// (get) Token: 0x06010C37 RID: 68663 RVA: 0x0045AEA8 File Offset: 0x004590A8
			// (set) Token: 0x06010C38 RID: 68664 RVA: 0x0045AEB8 File Offset: 0x004590B8
			public Text m_jobMoveValueText
			{
				get
				{
					return this.m_owner.m_jobMoveValueText;
				}
				set
				{
					this.m_owner.m_jobMoveValueText = value;
				}
			}

			// Token: 0x170033D0 RID: 13264
			// (get) Token: 0x06010C39 RID: 68665 RVA: 0x0045AEC8 File Offset: 0x004590C8
			// (set) Token: 0x06010C3A RID: 68666 RVA: 0x0045AED8 File Offset: 0x004590D8
			public Text m_jobRangeValueText
			{
				get
				{
					return this.m_owner.m_jobRangeValueText;
				}
				set
				{
					this.m_owner.m_jobRangeValueText = value;
				}
			}

			// Token: 0x170033D1 RID: 13265
			// (get) Token: 0x06010C3B RID: 68667 RVA: 0x0045AEE8 File Offset: 0x004590E8
			// (set) Token: 0x06010C3C RID: 68668 RVA: 0x0045AEF8 File Offset: 0x004590F8
			public Text m_jobAdvantageText
			{
				get
				{
					return this.m_owner.m_jobAdvantageText;
				}
				set
				{
					this.m_owner.m_jobAdvantageText = value;
				}
			}

			// Token: 0x170033D2 RID: 13266
			// (get) Token: 0x06010C3D RID: 68669 RVA: 0x0045AF08 File Offset: 0x00459108
			// (set) Token: 0x06010C3E RID: 68670 RVA: 0x0045AF18 File Offset: 0x00459118
			public Text m_jobAdvantageText1
			{
				get
				{
					return this.m_owner.m_jobAdvantageText1;
				}
				set
				{
					this.m_owner.m_jobAdvantageText1 = value;
				}
			}

			// Token: 0x170033D3 RID: 13267
			// (get) Token: 0x06010C3F RID: 68671 RVA: 0x0045AF28 File Offset: 0x00459128
			// (set) Token: 0x06010C40 RID: 68672 RVA: 0x0045AF38 File Offset: 0x00459138
			public Text m_jobAdvantageText2
			{
				get
				{
					return this.m_owner.m_jobAdvantageText2;
				}
				set
				{
					this.m_owner.m_jobAdvantageText2 = value;
				}
			}

			// Token: 0x170033D4 RID: 13268
			// (get) Token: 0x06010C41 RID: 68673 RVA: 0x0045AF48 File Offset: 0x00459148
			// (set) Token: 0x06010C42 RID: 68674 RVA: 0x0045AF58 File Offset: 0x00459158
			public GameObject m_heroGraphicObj
			{
				get
				{
					return this.m_owner.m_heroGraphicObj;
				}
				set
				{
					this.m_owner.m_heroGraphicObj = value;
				}
			}

			// Token: 0x170033D5 RID: 13269
			// (get) Token: 0x06010C43 RID: 68675 RVA: 0x0045AF68 File Offset: 0x00459168
			// (set) Token: 0x06010C44 RID: 68676 RVA: 0x0045AF78 File Offset: 0x00459178
			public Image m_jobSoldierTypeImage
			{
				get
				{
					return this.m_owner.m_jobSoldierTypeImage;
				}
				set
				{
					this.m_owner.m_jobSoldierTypeImage = value;
				}
			}

			// Token: 0x170033D6 RID: 13270
			// (get) Token: 0x06010C45 RID: 68677 RVA: 0x0045AF88 File Offset: 0x00459188
			// (set) Token: 0x06010C46 RID: 68678 RVA: 0x0045AF98 File Offset: 0x00459198
			public Button m_jobTransferButton
			{
				get
				{
					return this.m_owner.m_jobTransferButton;
				}
				set
				{
					this.m_owner.m_jobTransferButton = value;
				}
			}

			// Token: 0x170033D7 RID: 13271
			// (get) Token: 0x06010C47 RID: 68679 RVA: 0x0045AFA8 File Offset: 0x004591A8
			// (set) Token: 0x06010C48 RID: 68680 RVA: 0x0045AFB8 File Offset: 0x004591B8
			public Button m_jobUnlockButton
			{
				get
				{
					return this.m_owner.m_jobUnlockButton;
				}
				set
				{
					this.m_owner.m_jobUnlockButton = value;
				}
			}

			// Token: 0x170033D8 RID: 13272
			// (get) Token: 0x06010C49 RID: 68681 RVA: 0x0045AFC8 File Offset: 0x004591C8
			// (set) Token: 0x06010C4A RID: 68682 RVA: 0x0045AFD8 File Offset: 0x004591D8
			public Button m_masterButton
			{
				get
				{
					return this.m_owner.m_masterButton;
				}
				set
				{
					this.m_owner.m_masterButton = value;
				}
			}

			// Token: 0x170033D9 RID: 13273
			// (get) Token: 0x06010C4B RID: 68683 RVA: 0x0045AFE8 File Offset: 0x004591E8
			// (set) Token: 0x06010C4C RID: 68684 RVA: 0x0045AFF8 File Offset: 0x004591F8
			public Text m_alreadyMasterValueText
			{
				get
				{
					return this.m_owner.m_alreadyMasterValueText;
				}
				set
				{
					this.m_owner.m_alreadyMasterValueText = value;
				}
			}

			// Token: 0x170033DA RID: 13274
			// (get) Token: 0x06010C4D RID: 68685 RVA: 0x0045B008 File Offset: 0x00459208
			// (set) Token: 0x06010C4E RID: 68686 RVA: 0x0045B018 File Offset: 0x00459218
			public GameObject m_masterInfoPanel
			{
				get
				{
					return this.m_owner.m_masterInfoPanel;
				}
				set
				{
					this.m_owner.m_masterInfoPanel = value;
				}
			}

			// Token: 0x170033DB RID: 13275
			// (get) Token: 0x06010C4F RID: 68687 RVA: 0x0045B028 File Offset: 0x00459228
			// (set) Token: 0x06010C50 RID: 68688 RVA: 0x0045B038 File Offset: 0x00459238
			public Button m_masterInfoPanelReturnButton
			{
				get
				{
					return this.m_owner.m_masterInfoPanelReturnButton;
				}
				set
				{
					this.m_owner.m_masterInfoPanelReturnButton = value;
				}
			}

			// Token: 0x170033DC RID: 13276
			// (get) Token: 0x06010C51 RID: 68689 RVA: 0x0045B048 File Offset: 0x00459248
			// (set) Token: 0x06010C52 RID: 68690 RVA: 0x0045B058 File Offset: 0x00459258
			public GameObject m_masterInfoPanelScrollViewContent
			{
				get
				{
					return this.m_owner.m_masterInfoPanelScrollViewContent;
				}
				set
				{
					this.m_owner.m_masterInfoPanelScrollViewContent = value;
				}
			}

			// Token: 0x170033DD RID: 13277
			// (get) Token: 0x06010C53 RID: 68691 RVA: 0x0045B068 File Offset: 0x00459268
			// (set) Token: 0x06010C54 RID: 68692 RVA: 0x0045B078 File Offset: 0x00459278
			public GameObject m_masterItemPrefab
			{
				get
				{
					return this.m_owner.m_masterItemPrefab;
				}
				set
				{
					this.m_owner.m_masterItemPrefab = value;
				}
			}

			// Token: 0x170033DE RID: 13278
			// (get) Token: 0x06010C55 RID: 68693 RVA: 0x0045B088 File Offset: 0x00459288
			// (set) Token: 0x06010C56 RID: 68694 RVA: 0x0045B098 File Offset: 0x00459298
			public GameObject m_jobLvBgImagesGroup
			{
				get
				{
					return this.m_owner.m_jobLvBgImagesGroup;
				}
				set
				{
					this.m_owner.m_jobLvBgImagesGroup = value;
				}
			}

			// Token: 0x170033DF RID: 13279
			// (get) Token: 0x06010C57 RID: 68695 RVA: 0x0045B0A8 File Offset: 0x004592A8
			// (set) Token: 0x06010C58 RID: 68696 RVA: 0x0045B0B8 File Offset: 0x004592B8
			public GameObject m_jobLvImagesGroup
			{
				get
				{
					return this.m_owner.m_jobLvImagesGroup;
				}
				set
				{
					this.m_owner.m_jobLvImagesGroup = value;
				}
			}

			// Token: 0x170033E0 RID: 13280
			// (get) Token: 0x06010C59 RID: 68697 RVA: 0x0045B0C8 File Offset: 0x004592C8
			// (set) Token: 0x06010C5A RID: 68698 RVA: 0x0045B0D8 File Offset: 0x004592D8
			public GameObject m_learnedSkillIconImg
			{
				get
				{
					return this.m_owner.m_learnedSkillIconImg;
				}
				set
				{
					this.m_owner.m_learnedSkillIconImg = value;
				}
			}

			// Token: 0x170033E1 RID: 13281
			// (get) Token: 0x06010C5B RID: 68699 RVA: 0x0045B0E8 File Offset: 0x004592E8
			// (set) Token: 0x06010C5C RID: 68700 RVA: 0x0045B0F8 File Offset: 0x004592F8
			public GameObject m_learnedSkillIconImg2
			{
				get
				{
					return this.m_owner.m_learnedSkillIconImg2;
				}
				set
				{
					this.m_owner.m_learnedSkillIconImg2 = value;
				}
			}

			// Token: 0x170033E2 RID: 13282
			// (get) Token: 0x06010C5D RID: 68701 RVA: 0x0045B108 File Offset: 0x00459308
			// (set) Token: 0x06010C5E RID: 68702 RVA: 0x0045B118 File Offset: 0x00459318
			public GameObject m_skillDetailPanel
			{
				get
				{
					return this.m_owner.m_skillDetailPanel;
				}
				set
				{
					this.m_owner.m_skillDetailPanel = value;
				}
			}

			// Token: 0x170033E3 RID: 13283
			// (get) Token: 0x06010C5F RID: 68703 RVA: 0x0045B128 File Offset: 0x00459328
			// (set) Token: 0x06010C60 RID: 68704 RVA: 0x0045B138 File Offset: 0x00459338
			public GameObject m_learnedSoldierGraphicObj
			{
				get
				{
					return this.m_owner.m_learnedSoldierGraphicObj;
				}
				set
				{
					this.m_owner.m_learnedSoldierGraphicObj = value;
				}
			}

			// Token: 0x170033E4 RID: 13284
			// (get) Token: 0x06010C61 RID: 68705 RVA: 0x0045B148 File Offset: 0x00459348
			// (set) Token: 0x06010C62 RID: 68706 RVA: 0x0045B158 File Offset: 0x00459358
			public GameObject m_learnedSoldierGraphicObj2
			{
				get
				{
					return this.m_owner.m_learnedSoldierGraphicObj2;
				}
				set
				{
					this.m_owner.m_learnedSoldierGraphicObj2 = value;
				}
			}

			// Token: 0x170033E5 RID: 13285
			// (get) Token: 0x06010C63 RID: 68707 RVA: 0x0045B168 File Offset: 0x00459368
			// (set) Token: 0x06010C64 RID: 68708 RVA: 0x0045B178 File Offset: 0x00459378
			public GameObject m_learnedSoldierGraphicBg
			{
				get
				{
					return this.m_owner.m_learnedSoldierGraphicBg;
				}
				set
				{
					this.m_owner.m_learnedSoldierGraphicBg = value;
				}
			}

			// Token: 0x170033E6 RID: 13286
			// (get) Token: 0x06010C65 RID: 68709 RVA: 0x0045B188 File Offset: 0x00459388
			// (set) Token: 0x06010C66 RID: 68710 RVA: 0x0045B198 File Offset: 0x00459398
			public GameObject m_learnedSoldierGraphicBg2
			{
				get
				{
					return this.m_owner.m_learnedSoldierGraphicBg2;
				}
				set
				{
					this.m_owner.m_learnedSoldierGraphicBg2 = value;
				}
			}

			// Token: 0x170033E7 RID: 13287
			// (get) Token: 0x06010C67 RID: 68711 RVA: 0x0045B1A8 File Offset: 0x004593A8
			// (set) Token: 0x06010C68 RID: 68712 RVA: 0x0045B1B8 File Offset: 0x004593B8
			public GameObject m_soldierDetailPanel
			{
				get
				{
					return this.m_owner.m_soldierDetailPanel;
				}
				set
				{
					this.m_owner.m_soldierDetailPanel = value;
				}
			}

			// Token: 0x170033E8 RID: 13288
			// (get) Token: 0x06010C69 RID: 68713 RVA: 0x0045B1C8 File Offset: 0x004593C8
			// (set) Token: 0x06010C6A RID: 68714 RVA: 0x0045B1D8 File Offset: 0x004593D8
			public GameObject m_transferLockPanel
			{
				get
				{
					return this.m_owner.m_transferLockPanel;
				}
				set
				{
					this.m_owner.m_transferLockPanel = value;
				}
			}

			// Token: 0x170033E9 RID: 13289
			// (get) Token: 0x06010C6B RID: 68715 RVA: 0x0045B1E8 File Offset: 0x004593E8
			// (set) Token: 0x06010C6C RID: 68716 RVA: 0x0045B1F8 File Offset: 0x004593F8
			public Button m_transferLockPanelReturnBg
			{
				get
				{
					return this.m_owner.m_transferLockPanelReturnBg;
				}
				set
				{
					this.m_owner.m_transferLockPanelReturnBg = value;
				}
			}

			// Token: 0x170033EA RID: 13290
			// (get) Token: 0x06010C6D RID: 68717 RVA: 0x0045B208 File Offset: 0x00459408
			// (set) Token: 0x06010C6E RID: 68718 RVA: 0x0045B218 File Offset: 0x00459418
			public Text m_transferLockQuesText
			{
				get
				{
					return this.m_owner.m_transferLockQuesText;
				}
				set
				{
					this.m_owner.m_transferLockQuesText = value;
				}
			}

			// Token: 0x170033EB RID: 13291
			// (get) Token: 0x06010C6F RID: 68719 RVA: 0x0045B228 File Offset: 0x00459428
			// (set) Token: 0x06010C70 RID: 68720 RVA: 0x0045B238 File Offset: 0x00459438
			public Button m_transferLockConfirmButton
			{
				get
				{
					return this.m_owner.m_transferLockConfirmButton;
				}
				set
				{
					this.m_owner.m_transferLockConfirmButton = value;
				}
			}

			// Token: 0x170033EC RID: 13292
			// (get) Token: 0x06010C71 RID: 68721 RVA: 0x0045B248 File Offset: 0x00459448
			// (set) Token: 0x06010C72 RID: 68722 RVA: 0x0045B258 File Offset: 0x00459458
			public GameObject m_transferConfirmPanel
			{
				get
				{
					return this.m_owner.m_transferConfirmPanel;
				}
				set
				{
					this.m_owner.m_transferConfirmPanel = value;
				}
			}

			// Token: 0x170033ED RID: 13293
			// (get) Token: 0x06010C73 RID: 68723 RVA: 0x0045B268 File Offset: 0x00459468
			// (set) Token: 0x06010C74 RID: 68724 RVA: 0x0045B278 File Offset: 0x00459478
			public Text m_confirmPanelJobNameText
			{
				get
				{
					return this.m_owner.m_confirmPanelJobNameText;
				}
				set
				{
					this.m_owner.m_confirmPanelJobNameText = value;
				}
			}

			// Token: 0x170033EE RID: 13294
			// (get) Token: 0x06010C75 RID: 68725 RVA: 0x0045B288 File Offset: 0x00459488
			// (set) Token: 0x06010C76 RID: 68726 RVA: 0x0045B298 File Offset: 0x00459498
			public Text m_goldCostValueText
			{
				get
				{
					return this.m_owner.m_goldCostValueText;
				}
				set
				{
					this.m_owner.m_goldCostValueText = value;
				}
			}

			// Token: 0x170033EF RID: 13295
			// (get) Token: 0x06010C77 RID: 68727 RVA: 0x0045B2A8 File Offset: 0x004594A8
			// (set) Token: 0x06010C78 RID: 68728 RVA: 0x0045B2B8 File Offset: 0x004594B8
			public Text m_magicStoneCostValueText
			{
				get
				{
					return this.m_owner.m_magicStoneCostValueText;
				}
				set
				{
					this.m_owner.m_magicStoneCostValueText = value;
				}
			}

			// Token: 0x170033F0 RID: 13296
			// (get) Token: 0x06010C79 RID: 68729 RVA: 0x0045B2C8 File Offset: 0x004594C8
			// (set) Token: 0x06010C7A RID: 68730 RVA: 0x0045B2D8 File Offset: 0x004594D8
			public Button m_confirmBgButton
			{
				get
				{
					return this.m_owner.m_confirmBgButton;
				}
				set
				{
					this.m_owner.m_confirmBgButton = value;
				}
			}

			// Token: 0x170033F1 RID: 13297
			// (get) Token: 0x06010C7B RID: 68731 RVA: 0x0045B2E8 File Offset: 0x004594E8
			// (set) Token: 0x06010C7C RID: 68732 RVA: 0x0045B2F8 File Offset: 0x004594F8
			public Button m_confirmReturnButton
			{
				get
				{
					return this.m_owner.m_confirmReturnButton;
				}
				set
				{
					this.m_owner.m_confirmReturnButton = value;
				}
			}

			// Token: 0x170033F2 RID: 13298
			// (get) Token: 0x06010C7D RID: 68733 RVA: 0x0045B308 File Offset: 0x00459508
			// (set) Token: 0x06010C7E RID: 68734 RVA: 0x0045B318 File Offset: 0x00459518
			public Button m_confirmTransferButton
			{
				get
				{
					return this.m_owner.m_confirmTransferButton;
				}
				set
				{
					this.m_owner.m_confirmTransferButton = value;
				}
			}

			// Token: 0x170033F3 RID: 13299
			// (get) Token: 0x06010C7F RID: 68735 RVA: 0x0045B328 File Offset: 0x00459528
			// (set) Token: 0x06010C80 RID: 68736 RVA: 0x0045B338 File Offset: 0x00459538
			public CommonUIStateController m_confirmTransferNoticeTextStateCtrl
			{
				get
				{
					return this.m_owner.m_confirmTransferNoticeTextStateCtrl;
				}
				set
				{
					this.m_owner.m_confirmTransferNoticeTextStateCtrl = value;
				}
			}

			// Token: 0x170033F4 RID: 13300
			// (get) Token: 0x06010C81 RID: 68737 RVA: 0x0045B348 File Offset: 0x00459548
			// (set) Token: 0x06010C82 RID: 68738 RVA: 0x0045B358 File Offset: 0x00459558
			public GameObject m_unLockHeroJobPanel
			{
				get
				{
					return this.m_owner.m_unLockHeroJobPanel;
				}
				set
				{
					this.m_owner.m_unLockHeroJobPanel = value;
				}
			}

			// Token: 0x170033F5 RID: 13301
			// (get) Token: 0x06010C83 RID: 68739 RVA: 0x0045B368 File Offset: 0x00459568
			// (set) Token: 0x06010C84 RID: 68740 RVA: 0x0045B378 File Offset: 0x00459578
			public Text m_unLockHeroJobPanelJobNameText
			{
				get
				{
					return this.m_owner.m_unLockHeroJobPanelJobNameText;
				}
				set
				{
					this.m_owner.m_unLockHeroJobPanelJobNameText = value;
				}
			}

			// Token: 0x170033F6 RID: 13302
			// (get) Token: 0x06010C85 RID: 68741 RVA: 0x0045B388 File Offset: 0x00459588
			// (set) Token: 0x06010C86 RID: 68742 RVA: 0x0045B398 File Offset: 0x00459598
			public GameObject m_unLockHeroJobConditionsContentObj
			{
				get
				{
					return this.m_owner.m_unLockHeroJobConditionsContentObj;
				}
				set
				{
					this.m_owner.m_unLockHeroJobConditionsContentObj = value;
				}
			}

			// Token: 0x170033F7 RID: 13303
			// (get) Token: 0x06010C87 RID: 68743 RVA: 0x0045B3A8 File Offset: 0x004595A8
			// (set) Token: 0x06010C88 RID: 68744 RVA: 0x0045B3B8 File Offset: 0x004595B8
			public GameObject m_unlcokJobConditionPrefab
			{
				get
				{
					return this.m_owner.m_unlcokJobConditionPrefab;
				}
				set
				{
					this.m_owner.m_unlcokJobConditionPrefab = value;
				}
			}

			// Token: 0x170033F8 RID: 13304
			// (get) Token: 0x06010C89 RID: 68745 RVA: 0x0045B3C8 File Offset: 0x004595C8
			// (set) Token: 0x06010C8A RID: 68746 RVA: 0x0045B3D8 File Offset: 0x004595D8
			public Button m_unLockHeroJobReturnButton
			{
				get
				{
					return this.m_owner.m_unLockHeroJobReturnButton;
				}
				set
				{
					this.m_owner.m_unLockHeroJobReturnButton = value;
				}
			}

			// Token: 0x170033F9 RID: 13305
			// (get) Token: 0x06010C8B RID: 68747 RVA: 0x0045B3E8 File Offset: 0x004595E8
			// (set) Token: 0x06010C8C RID: 68748 RVA: 0x0045B3F8 File Offset: 0x004595F8
			public Button m_unLockHeroJobUnlockButton
			{
				get
				{
					return this.m_owner.m_unLockHeroJobUnlockButton;
				}
				set
				{
					this.m_owner.m_unLockHeroJobUnlockButton = value;
				}
			}

			// Token: 0x170033FA RID: 13306
			// (get) Token: 0x06010C8D RID: 68749 RVA: 0x0045B408 File Offset: 0x00459608
			// (set) Token: 0x06010C8E RID: 68750 RVA: 0x0045B418 File Offset: 0x00459618
			public Button m_jobTransferEffectSkipBtn
			{
				get
				{
					return this.m_owner.m_jobTransferEffectSkipBtn;
				}
				set
				{
					this.m_owner.m_jobTransferEffectSkipBtn = value;
				}
			}

			// Token: 0x170033FB RID: 13307
			// (get) Token: 0x06010C8F RID: 68751 RVA: 0x0045B428 File Offset: 0x00459628
			// (set) Token: 0x06010C90 RID: 68752 RVA: 0x0045B438 File Offset: 0x00459638
			public GameObject m_JobTransferEffectBgObj
			{
				get
				{
					return this.m_owner.m_JobTransferEffectBgObj;
				}
				set
				{
					this.m_owner.m_JobTransferEffectBgObj = value;
				}
			}

			// Token: 0x170033FC RID: 13308
			// (get) Token: 0x06010C91 RID: 68753 RVA: 0x0045B448 File Offset: 0x00459648
			// (set) Token: 0x06010C92 RID: 68754 RVA: 0x0045B458 File Offset: 0x00459658
			public GameObject m_JobTransferEffectBlackImage
			{
				get
				{
					return this.m_owner.m_JobTransferEffectBlackImage;
				}
				set
				{
					this.m_owner.m_JobTransferEffectBlackImage = value;
				}
			}

			// Token: 0x170033FD RID: 13309
			// (get) Token: 0x06010C93 RID: 68755 RVA: 0x0045B468 File Offset: 0x00459668
			// (set) Token: 0x06010C94 RID: 68756 RVA: 0x0045B478 File Offset: 0x00459678
			public GameObject m_JobTransferEffectWhiteImage
			{
				get
				{
					return this.m_owner.m_JobTransferEffectWhiteImage;
				}
				set
				{
					this.m_owner.m_JobTransferEffectWhiteImage = value;
				}
			}

			// Token: 0x170033FE RID: 13310
			// (get) Token: 0x06010C95 RID: 68757 RVA: 0x0045B488 File Offset: 0x00459688
			// (set) Token: 0x06010C96 RID: 68758 RVA: 0x0045B498 File Offset: 0x00459698
			public GameObject m_JobTransferEffectBgImage
			{
				get
				{
					return this.m_owner.m_JobTransferEffectBgImage;
				}
				set
				{
					this.m_owner.m_JobTransferEffectBgImage = value;
				}
			}

			// Token: 0x170033FF RID: 13311
			// (get) Token: 0x06010C97 RID: 68759 RVA: 0x0045B4A8 File Offset: 0x004596A8
			// (set) Token: 0x06010C98 RID: 68760 RVA: 0x0045B4B8 File Offset: 0x004596B8
			public Button m_jobTransferEffectContinueButton
			{
				get
				{
					return this.m_owner.m_jobTransferEffectContinueButton;
				}
				set
				{
					this.m_owner.m_jobTransferEffectContinueButton = value;
				}
			}

			// Token: 0x17003400 RID: 13312
			// (get) Token: 0x06010C99 RID: 68761 RVA: 0x0045B4C8 File Offset: 0x004596C8
			// (set) Token: 0x06010C9A RID: 68762 RVA: 0x0045B4D8 File Offset: 0x004596D8
			public GameObject m_heroATGraphicObj
			{
				get
				{
					return this.m_owner.m_heroATGraphicObj;
				}
				set
				{
					this.m_owner.m_heroATGraphicObj = value;
				}
			}

			// Token: 0x17003401 RID: 13313
			// (get) Token: 0x06010C9B RID: 68763 RVA: 0x0045B4E8 File Offset: 0x004596E8
			// (set) Token: 0x06010C9C RID: 68764 RVA: 0x0045B4F8 File Offset: 0x004596F8
			public GameObject m_jobTransferGroundImage
			{
				get
				{
					return this.m_owner.m_jobTransferGroundImage;
				}
				set
				{
					this.m_owner.m_jobTransferGroundImage = value;
				}
			}

			// Token: 0x17003402 RID: 13314
			// (get) Token: 0x06010C9D RID: 68765 RVA: 0x0045B508 File Offset: 0x00459708
			// (set) Token: 0x06010C9E RID: 68766 RVA: 0x0045B518 File Offset: 0x00459718
			public GameObject m_jobChangeSucceedText
			{
				get
				{
					return this.m_owner.m_jobChangeSucceedText;
				}
				set
				{
					this.m_owner.m_jobChangeSucceedText = value;
				}
			}

			// Token: 0x17003403 RID: 13315
			// (get) Token: 0x06010C9F RID: 68767 RVA: 0x0045B528 File Offset: 0x00459728
			// (set) Token: 0x06010CA0 RID: 68768 RVA: 0x0045B538 File Offset: 0x00459738
			public GameObject m_heroATGraphicJobChangeEffectObj1
			{
				get
				{
					return this.m_owner.m_heroATGraphicJobChangeEffectObj1;
				}
				set
				{
					this.m_owner.m_heroATGraphicJobChangeEffectObj1 = value;
				}
			}

			// Token: 0x17003404 RID: 13316
			// (get) Token: 0x06010CA1 RID: 68769 RVA: 0x0045B548 File Offset: 0x00459748
			// (set) Token: 0x06010CA2 RID: 68770 RVA: 0x0045B558 File Offset: 0x00459758
			public GameObject m_heroATGraphicJobChangeEffectObj2
			{
				get
				{
					return this.m_owner.m_heroATGraphicJobChangeEffectObj2;
				}
				set
				{
					this.m_owner.m_heroATGraphicJobChangeEffectObj2 = value;
				}
			}

			// Token: 0x17003405 RID: 13317
			// (get) Token: 0x06010CA3 RID: 68771 RVA: 0x0045B568 File Offset: 0x00459768
			// (set) Token: 0x06010CA4 RID: 68772 RVA: 0x0045B578 File Offset: 0x00459778
			public GameObject m_jobUpgradeInfo
			{
				get
				{
					return this.m_owner.m_jobUpgradeInfo;
				}
				set
				{
					this.m_owner.m_jobUpgradeInfo = value;
				}
			}

			// Token: 0x17003406 RID: 13318
			// (get) Token: 0x06010CA5 RID: 68773 RVA: 0x0045B588 File Offset: 0x00459788
			// (set) Token: 0x06010CA6 RID: 68774 RVA: 0x0045B598 File Offset: 0x00459798
			public Text m_jobTransHpText
			{
				get
				{
					return this.m_owner.m_jobTransHpText;
				}
				set
				{
					this.m_owner.m_jobTransHpText = value;
				}
			}

			// Token: 0x17003407 RID: 13319
			// (get) Token: 0x06010CA7 RID: 68775 RVA: 0x0045B5A8 File Offset: 0x004597A8
			// (set) Token: 0x06010CA8 RID: 68776 RVA: 0x0045B5B8 File Offset: 0x004597B8
			public Text m_jobTransATText
			{
				get
				{
					return this.m_owner.m_jobTransATText;
				}
				set
				{
					this.m_owner.m_jobTransATText = value;
				}
			}

			// Token: 0x17003408 RID: 13320
			// (get) Token: 0x06010CA9 RID: 68777 RVA: 0x0045B5C8 File Offset: 0x004597C8
			// (set) Token: 0x06010CAA RID: 68778 RVA: 0x0045B5D8 File Offset: 0x004597D8
			public Text m_jobTransDFText
			{
				get
				{
					return this.m_owner.m_jobTransDFText;
				}
				set
				{
					this.m_owner.m_jobTransDFText = value;
				}
			}

			// Token: 0x17003409 RID: 13321
			// (get) Token: 0x06010CAB RID: 68779 RVA: 0x0045B5E8 File Offset: 0x004597E8
			// (set) Token: 0x06010CAC RID: 68780 RVA: 0x0045B5F8 File Offset: 0x004597F8
			public Text m_jobTransMagicText
			{
				get
				{
					return this.m_owner.m_jobTransMagicText;
				}
				set
				{
					this.m_owner.m_jobTransMagicText = value;
				}
			}

			// Token: 0x1700340A RID: 13322
			// (get) Token: 0x06010CAD RID: 68781 RVA: 0x0045B608 File Offset: 0x00459808
			// (set) Token: 0x06010CAE RID: 68782 RVA: 0x0045B618 File Offset: 0x00459818
			public Text m_jobTransMagicDFText
			{
				get
				{
					return this.m_owner.m_jobTransMagicDFText;
				}
				set
				{
					this.m_owner.m_jobTransMagicDFText = value;
				}
			}

			// Token: 0x1700340B RID: 13323
			// (get) Token: 0x06010CAF RID: 68783 RVA: 0x0045B628 File Offset: 0x00459828
			// (set) Token: 0x06010CB0 RID: 68784 RVA: 0x0045B638 File Offset: 0x00459838
			public Text m_jobTransDEXText
			{
				get
				{
					return this.m_owner.m_jobTransDEXText;
				}
				set
				{
					this.m_owner.m_jobTransDEXText = value;
				}
			}

			// Token: 0x1700340C RID: 13324
			// (get) Token: 0x06010CB1 RID: 68785 RVA: 0x0045B648 File Offset: 0x00459848
			// (set) Token: 0x06010CB2 RID: 68786 RVA: 0x0045B658 File Offset: 0x00459858
			public Image m_jobTransHpImage
			{
				get
				{
					return this.m_owner.m_jobTransHpImage;
				}
				set
				{
					this.m_owner.m_jobTransHpImage = value;
				}
			}

			// Token: 0x1700340D RID: 13325
			// (get) Token: 0x06010CB3 RID: 68787 RVA: 0x0045B668 File Offset: 0x00459868
			// (set) Token: 0x06010CB4 RID: 68788 RVA: 0x0045B678 File Offset: 0x00459878
			public Image m_jobTransATImage
			{
				get
				{
					return this.m_owner.m_jobTransATImage;
				}
				set
				{
					this.m_owner.m_jobTransATImage = value;
				}
			}

			// Token: 0x1700340E RID: 13326
			// (get) Token: 0x06010CB5 RID: 68789 RVA: 0x0045B688 File Offset: 0x00459888
			// (set) Token: 0x06010CB6 RID: 68790 RVA: 0x0045B698 File Offset: 0x00459898
			public Image m_jobTransDFImage
			{
				get
				{
					return this.m_owner.m_jobTransDFImage;
				}
				set
				{
					this.m_owner.m_jobTransDFImage = value;
				}
			}

			// Token: 0x1700340F RID: 13327
			// (get) Token: 0x06010CB7 RID: 68791 RVA: 0x0045B6A8 File Offset: 0x004598A8
			// (set) Token: 0x06010CB8 RID: 68792 RVA: 0x0045B6B8 File Offset: 0x004598B8
			public Image m_jobTransMagicImage
			{
				get
				{
					return this.m_owner.m_jobTransMagicImage;
				}
				set
				{
					this.m_owner.m_jobTransMagicImage = value;
				}
			}

			// Token: 0x17003410 RID: 13328
			// (get) Token: 0x06010CB9 RID: 68793 RVA: 0x0045B6C8 File Offset: 0x004598C8
			// (set) Token: 0x06010CBA RID: 68794 RVA: 0x0045B6D8 File Offset: 0x004598D8
			public Image m_jobTransMagicDFImage
			{
				get
				{
					return this.m_owner.m_jobTransMagicDFImage;
				}
				set
				{
					this.m_owner.m_jobTransMagicDFImage = value;
				}
			}

			// Token: 0x17003411 RID: 13329
			// (get) Token: 0x06010CBB RID: 68795 RVA: 0x0045B6E8 File Offset: 0x004598E8
			// (set) Token: 0x06010CBC RID: 68796 RVA: 0x0045B6F8 File Offset: 0x004598F8
			public Image m_jobTransDEXImage
			{
				get
				{
					return this.m_owner.m_jobTransDEXImage;
				}
				set
				{
					this.m_owner.m_jobTransDEXImage = value;
				}
			}

			// Token: 0x17003412 RID: 13330
			// (get) Token: 0x06010CBD RID: 68797 RVA: 0x0045B708 File Offset: 0x00459908
			// (set) Token: 0x06010CBE RID: 68798 RVA: 0x0045B718 File Offset: 0x00459918
			public GameObject m_learnedPanel
			{
				get
				{
					return this.m_owner.m_learnedPanel;
				}
				set
				{
					this.m_owner.m_learnedPanel = value;
				}
			}

			// Token: 0x17003413 RID: 13331
			// (get) Token: 0x06010CBF RID: 68799 RVA: 0x0045B728 File Offset: 0x00459928
			// (set) Token: 0x06010CC0 RID: 68800 RVA: 0x0045B738 File Offset: 0x00459938
			public Button m_learnedPanelCloseBtn
			{
				get
				{
					return this.m_owner.m_learnedPanelCloseBtn;
				}
				set
				{
					this.m_owner.m_learnedPanelCloseBtn = value;
				}
			}

			// Token: 0x17003414 RID: 13332
			// (get) Token: 0x06010CC1 RID: 68801 RVA: 0x0045B748 File Offset: 0x00459948
			// (set) Token: 0x06010CC2 RID: 68802 RVA: 0x0045B758 File Offset: 0x00459958
			public Button m_learnedPanelSkillCloseBtn
			{
				get
				{
					return this.m_owner.m_learnedPanelSkillCloseBtn;
				}
				set
				{
					this.m_owner.m_learnedPanelSkillCloseBtn = value;
				}
			}

			// Token: 0x17003415 RID: 13333
			// (get) Token: 0x06010CC3 RID: 68803 RVA: 0x0045B768 File Offset: 0x00459968
			// (set) Token: 0x06010CC4 RID: 68804 RVA: 0x0045B778 File Offset: 0x00459978
			public GameObject m_learnedPanelSkillPanel
			{
				get
				{
					return this.m_owner.m_learnedPanelSkillPanel;
				}
				set
				{
					this.m_owner.m_learnedPanelSkillPanel = value;
				}
			}

			// Token: 0x17003416 RID: 13334
			// (get) Token: 0x06010CC5 RID: 68805 RVA: 0x0045B788 File Offset: 0x00459988
			// (set) Token: 0x06010CC6 RID: 68806 RVA: 0x0045B798 File Offset: 0x00459998
			public GameObject m_learnedPanelSoldierPanel
			{
				get
				{
					return this.m_owner.m_learnedPanelSoldierPanel;
				}
				set
				{
					this.m_owner.m_learnedPanelSoldierPanel = value;
				}
			}

			// Token: 0x17003417 RID: 13335
			// (get) Token: 0x06010CC7 RID: 68807 RVA: 0x0045B7A8 File Offset: 0x004599A8
			// (set) Token: 0x06010CC8 RID: 68808 RVA: 0x0045B7B8 File Offset: 0x004599B8
			public Image m_learnedPanelSkillIcon
			{
				get
				{
					return this.m_owner.m_learnedPanelSkillIcon;
				}
				set
				{
					this.m_owner.m_learnedPanelSkillIcon = value;
				}
			}

			// Token: 0x17003418 RID: 13336
			// (get) Token: 0x06010CC9 RID: 68809 RVA: 0x0045B7C8 File Offset: 0x004599C8
			// (set) Token: 0x06010CCA RID: 68810 RVA: 0x0045B7D8 File Offset: 0x004599D8
			public GameObject m_learnedPanelSoldierGraphicObj
			{
				get
				{
					return this.m_owner.m_learnedPanelSoldierGraphicObj;
				}
				set
				{
					this.m_owner.m_learnedPanelSoldierGraphicObj = value;
				}
			}

			// Token: 0x17003419 RID: 13337
			// (get) Token: 0x06010CCB RID: 68811 RVA: 0x0045B7E8 File Offset: 0x004599E8
			// (set) Token: 0x06010CCC RID: 68812 RVA: 0x0045B7F8 File Offset: 0x004599F8
			public Text m_learnedPanelSkillName
			{
				get
				{
					return this.m_owner.m_learnedPanelSkillName;
				}
				set
				{
					this.m_owner.m_learnedPanelSkillName = value;
				}
			}

			// Token: 0x1700341A RID: 13338
			// (get) Token: 0x06010CCD RID: 68813 RVA: 0x0045B808 File Offset: 0x00459A08
			// (set) Token: 0x06010CCE RID: 68814 RVA: 0x0045B818 File Offset: 0x00459A18
			public Text m_learnedPanelSoldierName
			{
				get
				{
					return this.m_owner.m_learnedPanelSoldierName;
				}
				set
				{
					this.m_owner.m_learnedPanelSoldierName = value;
				}
			}

			// Token: 0x1700341B RID: 13339
			// (get) Token: 0x06010CCF RID: 68815 RVA: 0x0045B828 File Offset: 0x00459A28
			// (set) Token: 0x06010CD0 RID: 68816 RVA: 0x0045B838 File Offset: 0x00459A38
			public UISpineGraphic m_heroGraphic
			{
				get
				{
					return this.m_owner.m_heroGraphic;
				}
				set
				{
					this.m_owner.m_heroGraphic = value;
				}
			}

			// Token: 0x1700341C RID: 13340
			// (get) Token: 0x06010CD1 RID: 68817 RVA: 0x0045B848 File Offset: 0x00459A48
			// (set) Token: 0x06010CD2 RID: 68818 RVA: 0x0045B858 File Offset: 0x00459A58
			public UISpineGraphic m_heroATGraphic
			{
				get
				{
					return this.m_owner.m_heroATGraphic;
				}
				set
				{
					this.m_owner.m_heroATGraphic = value;
				}
			}

			// Token: 0x1700341D RID: 13341
			// (get) Token: 0x06010CD3 RID: 68819 RVA: 0x0045B868 File Offset: 0x00459A68
			// (set) Token: 0x06010CD4 RID: 68820 RVA: 0x0045B878 File Offset: 0x00459A78
			public UISpineGraphic m_soldierGraphicL
			{
				get
				{
					return this.m_owner.m_soldierGraphicL;
				}
				set
				{
					this.m_owner.m_soldierGraphicL = value;
				}
			}

			// Token: 0x1700341E RID: 13342
			// (get) Token: 0x06010CD5 RID: 68821 RVA: 0x0045B888 File Offset: 0x00459A88
			// (set) Token: 0x06010CD6 RID: 68822 RVA: 0x0045B898 File Offset: 0x00459A98
			public UISpineGraphic m_soldierGraphicR
			{
				get
				{
					return this.m_owner.m_soldierGraphicR;
				}
				set
				{
					this.m_owner.m_soldierGraphicR = value;
				}
			}

			// Token: 0x1700341F RID: 13343
			// (get) Token: 0x06010CD7 RID: 68823 RVA: 0x0045B8A8 File Offset: 0x00459AA8
			// (set) Token: 0x06010CD8 RID: 68824 RVA: 0x0045B8B8 File Offset: 0x00459AB8
			public UISpineGraphic m_learndSoldierGraphic
			{
				get
				{
					return this.m_owner.m_learndSoldierGraphic;
				}
				set
				{
					this.m_owner.m_learndSoldierGraphic = value;
				}
			}

			// Token: 0x17003420 RID: 13344
			// (get) Token: 0x06010CD9 RID: 68825 RVA: 0x0045B8C8 File Offset: 0x00459AC8
			// (set) Token: 0x06010CDA RID: 68826 RVA: 0x0045B8D8 File Offset: 0x00459AD8
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

			// Token: 0x17003421 RID: 13345
			// (get) Token: 0x06010CDB RID: 68827 RVA: 0x0045B8E8 File Offset: 0x00459AE8
			// (set) Token: 0x06010CDC RID: 68828 RVA: 0x0045B8F8 File Offset: 0x00459AF8
			public List<int> m_jobConnectionIds
			{
				get
				{
					return this.m_owner.m_jobConnectionIds;
				}
				set
				{
					this.m_owner.m_jobConnectionIds = value;
				}
			}

			// Token: 0x17003422 RID: 13346
			// (get) Token: 0x06010CDD RID: 68829 RVA: 0x0045B908 File Offset: 0x00459B08
			// (set) Token: 0x06010CDE RID: 68830 RVA: 0x0045B918 File Offset: 0x00459B18
			public List<int> m_oldSkillInfoList
			{
				get
				{
					return this.m_owner.m_oldSkillInfoList;
				}
				set
				{
					this.m_owner.m_oldSkillInfoList = value;
				}
			}

			// Token: 0x17003423 RID: 13347
			// (get) Token: 0x06010CDF RID: 68831 RVA: 0x0045B928 File Offset: 0x00459B28
			// (set) Token: 0x06010CE0 RID: 68832 RVA: 0x0045B938 File Offset: 0x00459B38
			public List<int> m_oldSoldierInfoList
			{
				get
				{
					return this.m_owner.m_oldSoldierInfoList;
				}
				set
				{
					this.m_owner.m_oldSoldierInfoList = value;
				}
			}

			// Token: 0x17003424 RID: 13348
			// (get) Token: 0x06010CE1 RID: 68833 RVA: 0x0045B948 File Offset: 0x00459B48
			// (set) Token: 0x06010CE2 RID: 68834 RVA: 0x0045B958 File Offset: 0x00459B58
			public HeroCharUIController m_heroCharUIController
			{
				get
				{
					return this.m_owner.m_heroCharUIController;
				}
				set
				{
					this.m_owner.m_heroCharUIController = value;
				}
			}

			// Token: 0x17003425 RID: 13349
			// (get) Token: 0x06010CE3 RID: 68835 RVA: 0x0045B968 File Offset: 0x00459B68
			// (set) Token: 0x06010CE4 RID: 68836 RVA: 0x0045B978 File Offset: 0x00459B78
			public HeroPropertyComputer m_curComputer
			{
				get
				{
					return this.m_owner.m_curComputer;
				}
				set
				{
					this.m_owner.m_curComputer = value;
				}
			}

			// Token: 0x17003426 RID: 13350
			// (get) Token: 0x06010CE5 RID: 68837 RVA: 0x0045B988 File Offset: 0x00459B88
			// (set) Token: 0x06010CE6 RID: 68838 RVA: 0x0045B998 File Offset: 0x00459B98
			public HeroPropertyComputer m_oldComputer
			{
				get
				{
					return this.m_owner.m_oldComputer;
				}
				set
				{
					this.m_owner.m_oldComputer = value;
				}
			}

			// Token: 0x17003427 RID: 13351
			// (get) Token: 0x06010CE7 RID: 68839 RVA: 0x0045B9A8 File Offset: 0x00459BA8
			// (set) Token: 0x06010CE8 RID: 68840 RVA: 0x0045B9B8 File Offset: 0x00459BB8
			public ConfigDataJobConnectionInfo m_curJobConnectionInfo
			{
				get
				{
					return this.m_owner.m_curJobConnectionInfo;
				}
				set
				{
					this.m_owner.m_curJobConnectionInfo = value;
				}
			}

			// Token: 0x17003428 RID: 13352
			// (get) Token: 0x06010CE9 RID: 68841 RVA: 0x0045B9C8 File Offset: 0x00459BC8
			// (set) Token: 0x06010CEA RID: 68842 RVA: 0x0045B9D8 File Offset: 0x00459BD8
			public ConfigDataJobConnectionInfo m_oldJobConnectionInfo
			{
				get
				{
					return this.m_owner.m_oldJobConnectionInfo;
				}
				set
				{
					this.m_owner.m_oldJobConnectionInfo = value;
				}
			}

			// Token: 0x17003429 RID: 13353
			// (get) Token: 0x06010CEB RID: 68843 RVA: 0x0045B9E8 File Offset: 0x00459BE8
			// (set) Token: 0x06010CEC RID: 68844 RVA: 0x0045B9F8 File Offset: 0x00459BF8
			public Dictionary<int, HeroJobCardItemUIController> m_jobConnectionIdToJobCardCtrlDict
			{
				get
				{
					return this.m_owner.m_jobConnectionIdToJobCardCtrlDict;
				}
				set
				{
					this.m_owner.m_jobConnectionIdToJobCardCtrlDict = value;
				}
			}

			// Token: 0x1700342A RID: 13354
			// (get) Token: 0x06010CED RID: 68845 RVA: 0x0045BA08 File Offset: 0x00459C08
			// (set) Token: 0x06010CEE RID: 68846 RVA: 0x0045BA18 File Offset: 0x00459C18
			public bool m_isJobLocked
			{
				get
				{
					return this.m_owner.m_isJobLocked;
				}
				set
				{
					this.m_owner.m_isJobLocked = value;
				}
			}

			// Token: 0x1700342B RID: 13355
			// (get) Token: 0x06010CEF RID: 68847 RVA: 0x0045BA28 File Offset: 0x00459C28
			// (set) Token: 0x06010CF0 RID: 68848 RVA: 0x0045BA38 File Offset: 0x00459C38
			public bool m_isNeedMagicStone
			{
				get
				{
					return this.m_owner.m_isNeedMagicStone;
				}
				set
				{
					this.m_owner.m_isNeedMagicStone = value;
				}
			}

			// Token: 0x1700342C RID: 13356
			// (get) Token: 0x06010CF1 RID: 68849 RVA: 0x0045BA48 File Offset: 0x00459C48
			// (set) Token: 0x06010CF2 RID: 68850 RVA: 0x0045BA58 File Offset: 0x00459C58
			public bool m_isShowLearnSkill
			{
				get
				{
					return this.m_owner.m_isShowLearnSkill;
				}
				set
				{
					this.m_owner.m_isShowLearnSkill = value;
				}
			}

			// Token: 0x1700342D RID: 13357
			// (get) Token: 0x06010CF3 RID: 68851 RVA: 0x0045BA68 File Offset: 0x00459C68
			// (set) Token: 0x06010CF4 RID: 68852 RVA: 0x0045BA78 File Offset: 0x00459C78
			public bool m_isShowLearnSoldier
			{
				get
				{
					return this.m_owner.m_isShowLearnSoldier;
				}
				set
				{
					this.m_owner.m_isShowLearnSoldier = value;
				}
			}

			// Token: 0x1700342E RID: 13358
			// (get) Token: 0x06010CF5 RID: 68853 RVA: 0x0045BA88 File Offset: 0x00459C88
			// (set) Token: 0x06010CF6 RID: 68854 RVA: 0x0045BA98 File Offset: 0x00459C98
			public bool m_isJobHasTransfered
			{
				get
				{
					return this.m_owner.m_isJobHasTransfered;
				}
				set
				{
					this.m_owner.m_isJobHasTransfered = value;
				}
			}

			// Token: 0x1700342F RID: 13359
			// (get) Token: 0x06010CF7 RID: 68855 RVA: 0x0045BAA8 File Offset: 0x00459CA8
			// (set) Token: 0x06010CF8 RID: 68856 RVA: 0x0045BAB8 File Offset: 0x00459CB8
			public bool m_isJobTransferContinue
			{
				get
				{
					return this.m_owner.m_isJobTransferContinue;
				}
				set
				{
					this.m_owner.m_isJobTransferContinue = value;
				}
			}

			// Token: 0x17003430 RID: 13360
			// (get) Token: 0x06010CF9 RID: 68857 RVA: 0x0045BAC8 File Offset: 0x00459CC8
			// (set) Token: 0x06010CFA RID: 68858 RVA: 0x0045BAD8 File Offset: 0x00459CD8
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

			// Token: 0x17003431 RID: 13361
			// (get) Token: 0x06010CFB RID: 68859 RVA: 0x0045BAE8 File Offset: 0x00459CE8
			// (set) Token: 0x06010CFC RID: 68860 RVA: 0x0045BAF8 File Offset: 0x00459CF8
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

			// Token: 0x06010CFD RID: 68861 RVA: 0x0045BB08 File Offset: 0x00459D08
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010CFE RID: 68862 RVA: 0x0045BB18 File Offset: 0x00459D18
			public IEnumerator DrawLines(List<int> Ids)
			{
				return this.m_owner.DrawLines(Ids);
			}

			// Token: 0x06010CFF RID: 68863 RVA: 0x0045BB28 File Offset: 0x00459D28
			public void DynamicSetTransferLines(List<int> Ids)
			{
				this.m_owner.DynamicSetTransferLines(Ids);
			}

			// Token: 0x06010D00 RID: 68864 RVA: 0x0045BB38 File Offset: 0x00459D38
			public void SetLineImageColor(Image img, bool canTransfer)
			{
				this.m_owner.SetLineImageColor(img, canTransfer);
			}

			// Token: 0x06010D01 RID: 68865 RVA: 0x0045BB48 File Offset: 0x00459D48
			public void ClearGridLayout()
			{
				this.m_owner.ClearGridLayout();
			}

			// Token: 0x06010D02 RID: 68866 RVA: 0x0045BB58 File Offset: 0x00459D58
			public GameObject GetGridLayoutByRank(int rank)
			{
				return this.m_owner.GetGridLayoutByRank(rank);
			}

			// Token: 0x06010D03 RID: 68867 RVA: 0x0045BB68 File Offset: 0x00459D68
			public void OnJobCardItemClick(HeroJobCardItemUIController ctrl)
			{
				this.m_owner.OnJobCardItemClick(ctrl);
			}

			// Token: 0x06010D04 RID: 68868 RVA: 0x0045BB78 File Offset: 0x00459D78
			public void SetHeroInfo(ConfigDataJobConnectionInfo jobConnectionInfo)
			{
				this.m_owner.SetHeroInfo(jobConnectionInfo);
			}

			// Token: 0x06010D05 RID: 68869 RVA: 0x0045BB88 File Offset: 0x00459D88
			public void SetCanLearnSkills(List<ConfigDataSkillInfo> skillInfos)
			{
				this.m_owner.SetCanLearnSkills(skillInfos);
			}

			// Token: 0x06010D06 RID: 68870 RVA: 0x0045BB98 File Offset: 0x00459D98
			public void SetCanLearnSoldiers(List<ConfigDataSoldierInfo> soldierInfos)
			{
				this.m_owner.SetCanLearnSoldiers(soldierInfos);
			}

			// Token: 0x06010D07 RID: 68871 RVA: 0x0045BBA8 File Offset: 0x00459DA8
			public void CloseHeroJobInfo()
			{
				this.m_owner.CloseHeroJobInfo();
			}

			// Token: 0x06010D08 RID: 68872 RVA: 0x0045BBB8 File Offset: 0x00459DB8
			public void OnJobTransferButtonClick()
			{
				this.m_owner.OnJobTransferButtonClick();
			}

			// Token: 0x06010D09 RID: 68873 RVA: 0x0045BBC8 File Offset: 0x00459DC8
			public void CloseJobTransferConfirmPanel()
			{
				this.m_owner.CloseJobTransferConfirmPanel();
			}

			// Token: 0x06010D0A RID: 68874 RVA: 0x0045BBD8 File Offset: 0x00459DD8
			public void CloseJobTransferLockedPanel()
			{
				this.m_owner.CloseJobTransferLockedPanel();
			}

			// Token: 0x06010D0B RID: 68875 RVA: 0x0045BBE8 File Offset: 0x00459DE8
			public void OnJobUnlockButtonClick()
			{
				this.m_owner.OnJobUnlockButtonClick();
			}

			// Token: 0x06010D0C RID: 68876 RVA: 0x0045BBF8 File Offset: 0x00459DF8
			public void OnUnLockHeroJobReturnButtonClick()
			{
				this.m_owner.OnUnLockHeroJobReturnButtonClick();
			}

			// Token: 0x06010D0D RID: 68877 RVA: 0x0045BC08 File Offset: 0x00459E08
			public void OnUnLockHeroJobUnlockButtonClick()
			{
				this.m_owner.OnUnLockHeroJobUnlockButtonClick();
			}

			// Token: 0x06010D0E RID: 68878 RVA: 0x0045BC18 File Offset: 0x00459E18
			public void OnJobTransferConfirmButtonClick()
			{
				this.m_owner.OnJobTransferConfirmButtonClick();
			}

			// Token: 0x06010D0F RID: 68879 RVA: 0x0045BC28 File Offset: 0x00459E28
			public void GetCanLearnSkillAndSoldier()
			{
				this.m_owner.GetCanLearnSkillAndSoldier();
			}

			// Token: 0x06010D10 RID: 68880 RVA: 0x0045BC38 File Offset: 0x00459E38
			public void OnSkipBtnClick()
			{
				this.m_owner.OnSkipBtnClick();
			}

			// Token: 0x06010D11 RID: 68881 RVA: 0x0045BC48 File Offset: 0x00459E48
			public IEnumerator PlayJobTransfetEffectStep1()
			{
				return this.m_owner.PlayJobTransfetEffectStep1();
			}

			// Token: 0x06010D12 RID: 68882 RVA: 0x0045BC58 File Offset: 0x00459E58
			public IEnumerator PlayJobTransfetEffectStep2()
			{
				return this.m_owner.PlayJobTransfetEffectStep2();
			}

			// Token: 0x06010D13 RID: 68883 RVA: 0x0045BC68 File Offset: 0x00459E68
			public IEnumerator ShowLearnedSkillAndSoldier()
			{
				return this.m_owner.ShowLearnedSkillAndSoldier();
			}

			// Token: 0x06010D14 RID: 68884 RVA: 0x0045BC78 File Offset: 0x00459E78
			public void CloseLearnedSkillPanel()
			{
				this.m_owner.CloseLearnedSkillPanel();
			}

			// Token: 0x06010D15 RID: 68885 RVA: 0x0045BC88 File Offset: 0x00459E88
			public void CloseLearnedPanel()
			{
				this.m_owner.CloseLearnedPanel();
			}

			// Token: 0x06010D16 RID: 68886 RVA: 0x0045BC98 File Offset: 0x00459E98
			public void OnJobTransferEffectContinueButtonClick()
			{
				this.m_owner.OnJobTransferEffectContinueButtonClick();
			}

			// Token: 0x06010D17 RID: 68887 RVA: 0x0045BCA8 File Offset: 0x00459EA8
			public void SetTransferSucceedInfo()
			{
				this.m_owner.SetTransferSucceedInfo();
			}

			// Token: 0x06010D18 RID: 68888 RVA: 0x0045BCB8 File Offset: 0x00459EB8
			public string PropertyToString(int value0, int value1, Image img)
			{
				return this.m_owner.PropertyToString(value0, value1, img);
			}

			// Token: 0x06010D19 RID: 68889 RVA: 0x0045BCC8 File Offset: 0x00459EC8
			public void SetImageState(Image img, int t)
			{
				this.m_owner.SetImageState(img, t);
			}

			// Token: 0x06010D1A RID: 68890 RVA: 0x0045BCD8 File Offset: 0x00459ED8
			public void OnMasterRewardButtonClick()
			{
				this.m_owner.OnMasterRewardButtonClick();
			}

			// Token: 0x06010D1B RID: 68891 RVA: 0x0045BCE8 File Offset: 0x00459EE8
			public void CloseMasterInfoPanel()
			{
				this.m_owner.CloseMasterInfoPanel();
			}

			// Token: 0x06010D1C RID: 68892 RVA: 0x0045BCF8 File Offset: 0x00459EF8
			public void CreateSpineGraphic(ref UISpineGraphic graphic, ConfigDataJobConnectionInfo jobConnectionInfo, GameObject graphice, float scaleNum, string anim, int team)
			{
				this.m_owner.CreateSpineGraphic(ref graphic, jobConnectionInfo, graphice, scaleNum, anim, team);
			}

			// Token: 0x06010D1D RID: 68893 RVA: 0x0045BD10 File Offset: 0x00459F10
			public void CreateSoldierGraphic(ref UISpineGraphic graphic, ConfigDataSoldierInfo soldierInfo, GameObject graphice, float scales, int team)
			{
				this.m_owner.CreateSoldierGraphic(ref graphic, soldierInfo, graphice, scales, team);
			}

			// Token: 0x06010D1E RID: 68894 RVA: 0x0045BD24 File Offset: 0x00459F24
			public void DestroyGraphic(ref UISpineGraphic g)
			{
				this.m_owner.DestroyGraphic(ref g);
			}

			// Token: 0x06010D1F RID: 68895 RVA: 0x0045BD34 File Offset: 0x00459F34
			public void OnGoldAddButtonClick()
			{
				this.m_owner.OnGoldAddButtonClick();
			}

			// Token: 0x06010D20 RID: 68896 RVA: 0x0045BD44 File Offset: 0x00459F44
			public void OnMagicStoneClick()
			{
				this.m_owner.OnMagicStoneClick();
			}

			// Token: 0x06010D21 RID: 68897 RVA: 0x0045BD54 File Offset: 0x00459F54
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x04009B2C RID: 39724
			private HeroJobTransferUIController m_owner;
		}
	}
}
