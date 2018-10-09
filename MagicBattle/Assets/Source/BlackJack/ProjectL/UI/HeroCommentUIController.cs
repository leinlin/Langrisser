using System;
using System.Collections.Generic;
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
	// Token: 0x02000D87 RID: 3463
	[HotFix]
	public class HeroCommentUIController : UIControllerBase
	{
		// Token: 0x060101BD RID: 65981 RVA: 0x004371F4 File Offset: 0x004353F4
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
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_commentSendButton.onClick.AddListener(new UnityAction(this.OnCommentSendButtonClick));
			this.m_playerHeroDetailCloseBtn.onClick.AddListener(new UnityAction(this.ClosePlayerHeroDetailPanel));
			this.m_playerHeroDetailCloseImage.onClick.AddListener(new UnityAction(this.ClosePlayerHeroDetailPanel));
			this.m_commentNormalToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnAllCommentToggleClick));
			this.m_commentHotToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnHotCommentToggleClick));
			this.m_commentRankingToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRankingListCommentToggleClick));
			this.m_rankingListLockButton.onClick.AddListener(new UnityAction(this.OnRankingListLockButtonClick));
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(base.gameObject);
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x060101BE RID: 65982 RVA: 0x00437390 File Offset: 0x00435590
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_stateCtrl, "Show", null, true, true);
		}

		// Token: 0x060101BF RID: 65983 RVA: 0x00437404 File Offset: 0x00435604
		public void HeroCommentUpdateView(Hero hero, bool isNeedResetScrollViewPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCommentUpdateViewHeroBoolean_hotfix != null)
			{
				this.m_HeroCommentUpdateViewHeroBoolean_hotfix.call(new object[]
				{
					this,
					hero,
					isNeedResetScrollViewPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero != hero)
			{
				this.m_hero = hero;
			}
			this.CreateComments();
			if (isNeedResetScrollViewPos)
			{
				this.ResetScrollViewToTop();
			}
		}

		// Token: 0x060101C0 RID: 65984 RVA: 0x004374AC File Offset: 0x004356AC
		public void UpdateRankingListLock(bool isLock)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRankingListLockBoolean_hotfix != null)
			{
				this.m_UpdateRankingListLockBoolean_hotfix.call(new object[]
				{
					this,
					isLock
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_rankingListLockButton.gameObject.SetActive(isLock);
		}

		// Token: 0x060101C1 RID: 65985 RVA: 0x00437530 File Offset: 0x00435730
		private void CreateComments()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateComments_hotfix != null)
			{
				this.m_CreateComments_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroCharUIController.GetCharImageInfo() != this.m_hero.HeroInfo.GetCharImageInfo(this.m_hero.StarLevel))
			{
				this.m_heroCharUIController.CreateGraphic(this.m_hero, HeroCharUIController.PerformanceState.All, false, null);
				this.m_heroCharUIController.PlayAnimation("idle_Normal", false);
			}
			GameObjectUtility.DestroyChildren(this.m_hotCommentListObj);
			GameObjectUtility.DestroyChildren(this.m_normalCommentListObj);
			this.m_rankingListGroup.SetActive(false);
			this.m_commentListScrollRect.gameObject.SetActive(false);
			List<HeroCommentEntry> commentEntries = this.m_playerContext.GetHeroComments(this.m_hero.HeroId).CommentEntries;
			switch (this.m_curToggleState)
			{
			case HeroCommentUIController.ToggleState.Hot:
			{
				this.m_commentHotToggle.isOn = true;
				this.m_commentListScrollRect.gameObject.SetActive(true);
				List<HeroCommentEntry> commentsWithCount = this.GetCommentsWithCount(commentEntries, this.m_configDataLoader.ConfigableConstId_MaxPopularCommentEntry);
				this.CreateCommentByList(commentsWithCount, this.m_hotCommentListObj, true);
				break;
			}
			case HeroCommentUIController.ToggleState.All:
			{
				this.m_commentNormalToggle.isOn = true;
				this.m_commentListScrollRect.gameObject.SetActive(true);
				List<HeroCommentEntry> commentsWithCount2 = this.GetCommentsWithCount(commentEntries, 3);
				this.CreateCommentByList(commentsWithCount2, this.m_hotCommentListObj, true);
				List<HeroCommentEntry> normalCommentsInAllComments = this.GetNormalCommentsInAllComments(commentEntries, commentsWithCount2, this.m_curShowedNormalCommentCount);
				this.CreateCommentByList(normalCommentsInAllComments, this.m_normalCommentListObj, false);
				int num = commentEntries.Count - commentsWithCount2.Count;
				if (this.m_curShowedNormalCommentCount < num)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_moreCommentButton.gameObject);
					gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnMoreCommentButtonClick));
					gameObject.transform.SetParent(this.m_normalCommentListObj.transform, false);
				}
				break;
			}
			case HeroCommentUIController.ToggleState.Ranking:
				this.m_commentRankingToggle.isOn = true;
				this.m_rankingListGroup.SetActive(true);
				break;
			}
			this.m_moreCommentTextObj.SetActive(this.m_curToggleState == HeroCommentUIController.ToggleState.All && commentEntries.Count != 0);
			this.m_noCommentPanelObj.SetActive(commentEntries.Count == 0 && this.m_curToggleState != HeroCommentUIController.ToggleState.Ranking);
			this.m_inputCommentGo.SetActive(this.m_curToggleState != HeroCommentUIController.ToggleState.Ranking);
		}

		// Token: 0x060101C2 RID: 65986 RVA: 0x004377D0 File Offset: 0x004359D0
		public void UpdateRankingList(RankingListInfo rankInfoList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRankingListRankingListInfo_hotfix != null)
			{
				this.m_UpdateRankingListRankingListInfo_hotfix.call(new object[]
				{
					this,
					rankInfoList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_rankingListUICtrl.UpdateRankingListInfo(rankInfoList);
		}

		// Token: 0x060101C3 RID: 65987 RVA: 0x0043784C File Offset: 0x00435A4C
		private List<HeroCommentEntry> GetNormalCommentsInAllComments(List<HeroCommentEntry> allComments, List<HeroCommentEntry> hotComments, int needShowedCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNormalCommentsInAllCommentsList`1List`1Int32_hotfix != null)
			{
				return (List<HeroCommentEntry>)this.m_GetNormalCommentsInAllCommentsList`1List`1Int32_hotfix.call(new object[]
				{
					this,
					allComments,
					hotComments,
					needShowedCount
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<HeroCommentEntry> list = new List<HeroCommentEntry>();
			for (int i = 0; i < allComments.Count; i++)
			{
				if (!hotComments.Contains(allComments[i]))
				{
					list.Add(allComments[i]);
				}
				if (list.Count == needShowedCount)
				{
					break;
				}
			}
			list.Sort(new Comparison<HeroCommentEntry>(this.CommentComparerByTime));
			return list;
		}

		// Token: 0x060101C4 RID: 65988 RVA: 0x00437948 File Offset: 0x00435B48
		private int CommentComparerByTime(HeroCommentEntry c1, HeroCommentEntry c2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CommentComparerByTimeHeroCommentEntryHeroCommentEntry_hotfix != null)
			{
				return Convert.ToInt32(this.m_CommentComparerByTimeHeroCommentEntryHeroCommentEntry_hotfix.call(new object[]
				{
					this,
					c1,
					c2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (c1.CommentTime < c2.CommentTime)
			{
				return 1;
			}
			if (c1.CommentTime > c2.CommentTime)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x060101C5 RID: 65989 RVA: 0x004379FC File Offset: 0x00435BFC
		private int CommentComparerByPraisedNum(HeroCommentEntry c1, HeroCommentEntry c2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CommentComparerByPraisedNumHeroCommentEntryHeroCommentEntry_hotfix != null)
			{
				return Convert.ToInt32(this.m_CommentComparerByPraisedNumHeroCommentEntryHeroCommentEntry_hotfix.call(new object[]
				{
					this,
					c1,
					c2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (c1.PraiseNums != c2.PraiseNums)
			{
				return c2.PraiseNums - c1.PraiseNums;
			}
			return this.CommentComparerByTime(c1, c2);
		}

		// Token: 0x060101C6 RID: 65990 RVA: 0x00437AB0 File Offset: 0x00435CB0
		private List<HeroCommentEntry> GetCommentsWithCount(List<HeroCommentEntry> commentList, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCommentsWithCountList`1Int32_hotfix != null)
			{
				return (List<HeroCommentEntry>)this.m_GetCommentsWithCountList`1Int32_hotfix.call(new object[]
				{
					this,
					commentList,
					count
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<HeroCommentEntry> list = new List<HeroCommentEntry>();
			list.AddRange(commentList);
			list.Sort(new Comparison<HeroCommentEntry>(this.CommentComparerByPraisedNum));
			List<HeroCommentEntry> list2 = new List<HeroCommentEntry>();
			for (int i = 0; i < list.Count; i++)
			{
				if (i < count)
				{
					list2.Add(list[i]);
				}
			}
			return list2;
		}

		// Token: 0x060101C7 RID: 65991 RVA: 0x00437B90 File Offset: 0x00435D90
		private void CreateCommentByList(List<HeroCommentEntry> commentList, GameObject content, bool isShowPraisedIcon)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateCommentByListList`1GameObjectBoolean_hotfix != null)
			{
				this.m_CreateCommentByListList`1GameObjectBoolean_hotfix.call(new object[]
				{
					this,
					commentList,
					content,
					isShowPraisedIcon
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (HeroCommentEntry comment in commentList)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_commentItemPrefabObj);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				HeroCommentItemUIController component = gameObject.GetComponent<HeroCommentItemUIController>();
				component.InitCommentItem(comment, isShowPraisedIcon);
				component.EventOnPraisedBtnClick += this.OnCommentItemPraisedBtnClick;
				gameObject.transform.SetParent(content.transform, false);
			}
		}

		// Token: 0x060101C8 RID: 65992 RVA: 0x00437CAC File Offset: 0x00435EAC
		public void ShowPlayerHeroDetailPanel(HeroCommentEntry commentEntry, Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerHeroDetailPanelHeroCommentEntryHero_hotfix != null)
			{
				this.m_ShowPlayerHeroDetailPanelHeroCommentEntryHero_hotfix.call(new object[]
				{
					this,
					commentEntry,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerHeroDetailPanelObj.SetActive(true);
			CommonUIStateController component = this.m_playerHeroDetailPanelObj.GetComponent<CommonUIStateController>();
			component.SetToUIState("Show", false, true);
			this.m_playerNameText.text = string.Concat(new object[]
			{
				"LV:",
				commentEntry.CommenterLevel,
				" ",
				commentEntry.CommenterName
			});
			ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
			this.m_playerHeroHalfBodyImage.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
			UIUtility.SetGameObjectChildrenActiveCount(this.m_playerHeroLvStarsObj, hero.StarLevel);
			HeroJob activeJob = hero.GetActiveJob();
			this.m_playerHeroJobNameText.text = activeJob.JobConnectionInfo.m_jobInfo.Name;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_playerHeroJobLvStarsObj, activeJob.JobLevel);
			this.m_playerHeroJobMasterImg.gameObject.SetActive(false);
			char[] array = activeJob.JobConnectionInfo.PropertyRating.ToCharArray();
			List<Image> list = new List<Image>();
			list.Add(this.m_playerHeroPropHPImg);
			list.Add(this.m_playerHeroPropATImg);
			list.Add(this.m_playerHeroPropMagicImg);
			list.Add(this.m_playerHeroPropDFImg);
			list.Add(this.m_playerHeroPropMagicDFImg);
			list.Add(this.m_playerHeroPropDEXImg);
			for (int i = 0; i < array.Length; i++)
			{
				string propertyRatingImageName = UIUtility.GetPropertyRatingImageName(array[i]);
				list[i].sprite = AssetUtility.Instance.GetSprite(propertyRatingImageName);
			}
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			heroPropertyComputer.ComputeHeroProperties(hero, activeJob.JobRelatedId, -1, -1, -1, -1, -1, -1);
			this.m_playerHeroPropHPValueText.text = heroPropertyComputer.Property0.HealthPointMax.ToString();
			this.m_playerHeroPropDFValueText.text = heroPropertyComputer.Property0.Defense.ToString();
			this.m_playerHeroPropATValueText.text = heroPropertyComputer.Property0.Attack.ToString();
			this.m_playerHeroPropMagicDFValueText.text = heroPropertyComputer.Property0.MagicDefense.ToString();
			this.m_playerHeroPropMagicValueText.text = heroPropertyComputer.Property0.Magic.ToString();
			this.m_playerHeroPropDEXValueText.text = heroPropertyComputer.Property0.Dexterity.ToString();
			int num = heroPropertyComputer.Property1.HealthPointMax - heroPropertyComputer.Property0.HealthPointMax;
			this.m_playerHeroPropHPAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Defense - heroPropertyComputer.Property0.Defense;
			this.m_playerHeroPropDFAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Attack - heroPropertyComputer.Property0.Attack;
			this.m_playerHeroPropATAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.MagicDefense - heroPropertyComputer.Property0.MagicDefense;
			this.m_playerHeroPropMagicDFAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Magic - heroPropertyComputer.Property0.Magic;
			this.m_playerHeroPropMagicAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Dexterity - heroPropertyComputer.Property0.Dexterity;
			this.m_playerHeroPropDEXAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			this.m_playerHeroLvValueText.text = hero.Level.ToString();
			this.m_playerHeroNameText.text = hero.HeroInfo.Name;
			this.m_playerHeroSoldierIconImg.sprite = AssetUtility.Instance.GetSprite(hero.SelectedSoldierInfo.m_armyInfo.Icon);
			List<Image> list2 = new List<Image>();
			list2.Add(this.m_playerHeroEquipments1);
			list2.Add(this.m_playerHeroEquipments2);
			list2.Add(this.m_playerHeroEquipments3);
			list2.Add(this.m_playerHeroEquipments4);
			ulong[] equipmentIds = hero.EquipmentIds;
			for (int j = 0; j < list2.Count; j++)
			{
				BagItemBase bagItemByInstanceId = this.m_playerContext.GetBagItemByInstanceId(equipmentIds[j]);
				if (bagItemByInstanceId != null)
				{
					ConfigDataEquipmentInfo equipmentInfo = bagItemByInstanceId.EquipmentInfo;
					list2[j].sprite = AssetUtility.Instance.GetSprite(equipmentInfo.Icon);
					list2[j].gameObject.SetActive(true);
				}
				else
				{
					list2[j].gameObject.SetActive(false);
				}
			}
			ConfigDataSkillInfo talentSkillInfo = hero.GetActiveJob().JobConnectionInfo.GetTalentSkillInfo(hero.StarLevel);
			if (talentSkillInfo != null)
			{
				this.m_playerHeroTalentIcon.sprite = AssetUtility.Instance.GetSprite(talentSkillInfo.Icon);
				this.m_playerHeroTalentIcon.gameObject.SetActive(true);
			}
			else
			{
				this.m_playerHeroTalentIcon.gameObject.SetActive(false);
			}
			List<Image> list3 = new List<Image>();
			list3.Add(this.m_playerHeroSkillIcon1);
			list3.Add(this.m_playerHeroSkillIcon2);
			list3.Add(this.m_playerHeroSkillIcon3);
			List<int> selectedSkills = hero.SelectedSkills;
			for (int k = 0; k < list3.Count; k++)
			{
				if (k < selectedSkills.Count)
				{
					ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(selectedSkills[k]);
					list3[k].sprite = AssetUtility.Instance.GetSprite(configDataSkillInfo.Icon);
					list3[k].gameObject.AddComponent<PlayerHeroSkillUIController>().SetSkillInfoAndDescObj(configDataSkillInfo, this.m_playerHeroSkillDescObj);
					list3[k].gameObject.GetComponent<PlayerHeroSkillUIController>().EventOnSkillClick += this.OnSkillItemClick;
					list3[k].gameObject.SetActive(true);
				}
				else
				{
					list3[k].gameObject.SetActive(false);
				}
			}
			ConfigDataSoldierInfo selectedSoldierInfo = hero.SelectedSoldierInfo;
			float scale = (float)selectedSoldierInfo.UI_ModelScale * 0.012f;
			Vector2 offset = new Vector2((float)selectedSoldierInfo.UI_ModelOffsetX, (float)selectedSoldierInfo.UI_ModelOffsetY) * 1.5f;
			this.CreateSpineGraphic(ref this.m_soldierInfoGraphic, selectedSoldierInfo.Model, this.m_soldierGraphicObj, 1, offset, scale, selectedSoldierInfo.ReplaceAnims);
			heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			heroPropertyComputer.ComputeSoldierCommandProperties(hero, selectedSoldierInfo);
			this.m_soldierHPValueText.text = heroPropertyComputer.Property0.HealthPointMax.ToString();
			this.SetSoldierPropAddText(heroPropertyComputer.Property0.HealthPointMax, heroPropertyComputer.Property1.HealthPointMax, this.m_soldierHPAddText);
			this.m_soldierATValueText.text = heroPropertyComputer.Property0.Attack.ToString();
			this.SetSoldierPropAddText(heroPropertyComputer.Property0.Attack, heroPropertyComputer.Property1.Attack, this.m_soldierATAddText);
			this.m_soldierDFValueText.text = heroPropertyComputer.Property0.Defense.ToString();
			this.SetSoldierPropAddText(heroPropertyComputer.Property0.Defense, heroPropertyComputer.Property1.Defense, this.m_soldierDFAddText);
			this.m_soldierMagicDFValueText.text = heroPropertyComputer.Property0.MagicDefense.ToString();
			this.SetSoldierPropAddText(heroPropertyComputer.Property0.MagicDefense, heroPropertyComputer.Property1.MagicDefense, this.m_soldierMagicDFAddText);
		}

		// Token: 0x060101C9 RID: 65993 RVA: 0x00438588 File Offset: 0x00436788
		private void OnSkillItemClick(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkillItemClickConfigDataSkillInfo_hotfix != null)
			{
				this.m_OnSkillItemClickConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetSkillDescPanel(skillInfo);
		}

		// Token: 0x060101CA RID: 65994 RVA: 0x00438600 File Offset: 0x00436800
		private void SetSkillDescPanel(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkillDescPanelConfigDataSkillInfo_hotfix != null)
			{
				this.m_SetSkillDescPanelConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			this.m_playerHeroSkillDescNameText.text = skillInfo.Name;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_playerHeroSkillDescCostObj, skillInfo.SkillCost);
			this.m_playerHeroSkillDescText.text = skillInfo.Desc;
			this.m_playerHeroSkillDescTypeText.text = skillInfo.TypeText;
			this.m_playerHeroSkillDescCDText.text = skillInfo.CDText;
			this.m_playerHeroSkillDescDistanceText.text = skillInfo.DistanceText;
			this.m_playerHeroSkillDescRangeText.text = skillInfo.RangeText;
		}

		// Token: 0x060101CB RID: 65995 RVA: 0x004386F0 File Offset: 0x004368F0
		private void SetSoldierPropAddText(int oldValue, int newValue, Text txt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierPropAddTextInt32Int32Text_hotfix != null)
			{
				this.m_SetSoldierPropAddTextInt32Int32Text_hotfix.call(new object[]
				{
					this,
					oldValue,
					newValue,
					txt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (oldValue == newValue)
			{
				txt.gameObject.SetActive(false);
				return;
			}
			txt.gameObject.SetActive(true);
			txt.text = string.Concat(new object[]
			{
				"+",
				newValue - oldValue,
				"(",
				(newValue - oldValue) * 100 / oldValue,
				"%)"
			});
		}

		// Token: 0x060101CC RID: 65996 RVA: 0x004387E4 File Offset: 0x004369E4
		private void ClosePlayerHeroDetailPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClosePlayerHeroDetailPanel_hotfix != null)
			{
				this.m_ClosePlayerHeroDetailPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_playerHeroDetailPanelObj.GetComponent<CommonUIStateController>();
			component.SetToUIState("Close", false, true);
			component.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_playerHeroDetailPanelObj.SetActive(false);
			});
		}

		// Token: 0x060101CD RID: 65997 RVA: 0x00438878 File Offset: 0x00436A78
		private void OnCommentItemNameClick(HeroCommentEntry comment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCommentItemNameClickHeroCommentEntry_hotfix != null)
			{
				this.m_OnCommentItemNameClickHeroCommentEntry_hotfix.call(new object[]
				{
					this,
					comment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnNameClick != null)
			{
				this.EventOnNameClick(this.m_hero.HeroId, comment);
			}
		}

		// Token: 0x060101CE RID: 65998 RVA: 0x0043890C File Offset: 0x00436B0C
		private void OnCommentItemPraisedBtnClick(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCommentItemPraisedBtnClickUInt64_hotfix != null)
			{
				this.m_OnCommentItemPraisedBtnClickUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanPraiseHeroCommentEntry(this.m_hero.HeroId, instanceId);
			if (num == 0)
			{
				if (this.EventOnPraisedBtnClick != null)
				{
					this.EventOnPraisedBtnClick(this.m_hero.HeroId, instanceId);
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x060101CF RID: 65999 RVA: 0x004389D4 File Offset: 0x00436BD4
		private void OnMoreCommentButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMoreCommentButtonClick_hotfix != null)
			{
				this.m_OnMoreCommentButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curShowedNormalCommentCount += 10;
			this.CreateComments();
		}

		// Token: 0x060101D0 RID: 66000 RVA: 0x00438A4C File Offset: 0x00436C4C
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
			this.m_curShowedNormalCommentCount = 10;
			this.m_curToggleState = HeroCommentUIController.ToggleState.Hot;
		}

		// Token: 0x060101D1 RID: 66001 RVA: 0x00438AD4 File Offset: 0x00436CD4
		private void OnAllCommentToggleClick(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAllCommentToggleClickBoolean_hotfix != null)
			{
				this.m_OnAllCommentToggleClickBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				if (this.m_curToggleState == HeroCommentUIController.ToggleState.All)
				{
					return;
				}
				this.m_curToggleState = HeroCommentUIController.ToggleState.All;
				if (this.EventOnGetHeroComments != null)
				{
					this.EventOnGetHeroComments(this.m_hero.HeroId, true);
				}
			}
			this.m_commentNormalToggleClick.SetActive(isOn);
			this.m_commentNormalToggleUnClick.SetActive(!isOn);
		}

		// Token: 0x060101D2 RID: 66002 RVA: 0x00438B9C File Offset: 0x00436D9C
		private void OnHotCommentToggleClick(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHotCommentToggleClickBoolean_hotfix != null)
			{
				this.m_OnHotCommentToggleClickBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				if (this.m_curToggleState == HeroCommentUIController.ToggleState.Hot)
				{
					return;
				}
				this.m_curToggleState = HeroCommentUIController.ToggleState.Hot;
				if (this.EventOnGetHeroComments != null)
				{
					this.EventOnGetHeroComments(this.m_hero.HeroId, true);
				}
			}
			this.m_commentHotToggleClick.SetActive(isOn);
			this.m_commentHotToggleUnClick.SetActive(!isOn);
		}

		// Token: 0x060101D3 RID: 66003 RVA: 0x00438C64 File Offset: 0x00436E64
		private void OnRankingListCommentToggleClick(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRankingListCommentToggleClickBoolean_hotfix != null)
			{
				this.m_OnRankingListCommentToggleClickBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				if (this.m_curToggleState == HeroCommentUIController.ToggleState.Ranking)
				{
					return;
				}
				this.m_curToggleState = HeroCommentUIController.ToggleState.Ranking;
				if (this.EventOnRankingQurey != null)
				{
					this.EventOnRankingQurey(this.m_hero.HeroId);
				}
			}
			this.m_commnetRankingClick.SetActive(isOn);
			this.m_commnetRankingUnClick.SetActive(!isOn);
		}

		// Token: 0x060101D4 RID: 66004 RVA: 0x00438D2C File Offset: 0x00436F2C
		private void OnRankingListLockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRankingListLockButtonClick_hotfix != null)
			{
				this.m_OnRankingListLockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRankingListLockClick != null)
			{
				this.EventOnRankingListLockClick();
			}
		}

		// Token: 0x060101D5 RID: 66005 RVA: 0x00438DA4 File Offset: 0x00436FA4
		private void OnCommentSendButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCommentSendButtonClick_hotfix != null)
			{
				this.m_OnCommentSendButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = this.m_commentInputField.text;
			if (text == string.Empty)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_HeroCommentCantBeEmpty, 2f, null, true);
				return;
			}
			int num = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_CanSendCommentMinLevel);
			if (this.m_playerContext.GetPlayerLevel() < num)
			{
				string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_SendCommentMinLevelTip);
				CommonUIController.Instance.ShowMessage(string.Format(format, num), 2f, null, true);
				return;
			}
			if (this.EventOnCommentSend != null && text != string.Empty)
			{
				this.EventOnCommentSend(this.m_hero.HeroId, text);
			}
			this.m_commentInputField.text = string.Empty;
		}

		// Token: 0x060101D6 RID: 66006 RVA: 0x00438ECC File Offset: 0x004370CC
		private void CreateSpineGraphic(ref UISpineGraphic graphic, string assetName, GameObject parent, int direction, Vector2 offset, float scale, List<ReplaceAnim> anims)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicUISpineGraphic_StringGameObjectInt32Vector2SingleList`1_hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_HeroCommentUIController_CreateSpineGraphic_UISpineGraphic_String_GameObject_Int32_Vector2_Single_List1(this, this.m_CreateSpineGraphicUISpineGraphic_StringGameObjectInt32Vector2SingleList`1_hotfix, ref graphic, assetName, parent, direction, offset, scale, anims);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic(ref graphic);
			graphic = new UISpineGraphic();
			graphic.Create(assetName);
			graphic.SetParent(parent);
			graphic.SetDirection(direction);
			graphic.SetPosition(offset);
			graphic.SetScale(scale);
			graphic.SetRectTransformSize(new Vector2(500f / scale, 500f / scale));
			graphic.SetReplaceAnimations(anims);
			graphic.PlayAnimation("idle", true, 0);
			graphic.ForceUpdate();
		}

		// Token: 0x060101D7 RID: 66007 RVA: 0x00438FA0 File Offset: 0x004371A0
		private void DestroySpineGraphic(ref UISpineGraphic g)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroySpineGraphicUISpineGraphic__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_HeroCommentUIController_DestroySpineGraphic_UISpineGraphic(this, this.m_DestroySpineGraphicUISpineGraphic__hotfix, ref g);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (g != null)
			{
				g.Destroy();
				g = null;
			}
		}

		// Token: 0x060101D8 RID: 66008 RVA: 0x00439004 File Offset: 0x00437204
		private void ResetScrollViewToTop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetScrollViewToTop_hotfix != null)
			{
				this.m_ResetScrollViewToTop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_commentListScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x14000361 RID: 865
		// (add) Token: 0x060101D9 RID: 66009 RVA: 0x00439074 File Offset: 0x00437274
		// (remove) Token: 0x060101DA RID: 66010 RVA: 0x00439110 File Offset: 0x00437310
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

		// Token: 0x14000362 RID: 866
		// (add) Token: 0x060101DB RID: 66011 RVA: 0x004391AC File Offset: 0x004373AC
		// (remove) Token: 0x060101DC RID: 66012 RVA: 0x00439248 File Offset: 0x00437448
		public event Action<int, string> EventOnCommentSend
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCommentSendAction`2_hotfix != null)
				{
					this.m_add_EventOnCommentSendAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, string> action = this.EventOnCommentSend;
				Action<int, string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, string>>(ref this.EventOnCommentSend, (Action<int, string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCommentSendAction`2_hotfix != null)
				{
					this.m_remove_EventOnCommentSendAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, string> action = this.EventOnCommentSend;
				Action<int, string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, string>>(ref this.EventOnCommentSend, (Action<int, string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000363 RID: 867
		// (add) Token: 0x060101DD RID: 66013 RVA: 0x004392E4 File Offset: 0x004374E4
		// (remove) Token: 0x060101DE RID: 66014 RVA: 0x00439380 File Offset: 0x00437580
		public event Action<int, HeroCommentEntry> EventOnNameClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNameClickAction`2_hotfix != null)
				{
					this.m_add_EventOnNameClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, HeroCommentEntry> action = this.EventOnNameClick;
				Action<int, HeroCommentEntry> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, HeroCommentEntry>>(ref this.EventOnNameClick, (Action<int, HeroCommentEntry>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNameClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnNameClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, HeroCommentEntry> action = this.EventOnNameClick;
				Action<int, HeroCommentEntry> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, HeroCommentEntry>>(ref this.EventOnNameClick, (Action<int, HeroCommentEntry>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000364 RID: 868
		// (add) Token: 0x060101DF RID: 66015 RVA: 0x0043941C File Offset: 0x0043761C
		// (remove) Token: 0x060101E0 RID: 66016 RVA: 0x004394B8 File Offset: 0x004376B8
		public event Action<int, ulong> EventOnPraisedBtnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPraisedBtnClickAction`2_hotfix != null)
				{
					this.m_add_EventOnPraisedBtnClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong> action = this.EventOnPraisedBtnClick;
				Action<int, ulong> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong>>(ref this.EventOnPraisedBtnClick, (Action<int, ulong>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPraisedBtnClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnPraisedBtnClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, ulong> action = this.EventOnPraisedBtnClick;
				Action<int, ulong> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, ulong>>(ref this.EventOnPraisedBtnClick, (Action<int, ulong>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000365 RID: 869
		// (add) Token: 0x060101E1 RID: 66017 RVA: 0x00439554 File Offset: 0x00437754
		// (remove) Token: 0x060101E2 RID: 66018 RVA: 0x004395F0 File Offset: 0x004377F0
		public event Action<int, bool> EventOnGetHeroComments
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetHeroCommentsAction`2_hotfix != null)
				{
					this.m_add_EventOnGetHeroCommentsAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, bool> action = this.EventOnGetHeroComments;
				Action<int, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, bool>>(ref this.EventOnGetHeroComments, (Action<int, bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetHeroCommentsAction`2_hotfix != null)
				{
					this.m_remove_EventOnGetHeroCommentsAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, bool> action = this.EventOnGetHeroComments;
				Action<int, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, bool>>(ref this.EventOnGetHeroComments, (Action<int, bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000366 RID: 870
		// (add) Token: 0x060101E3 RID: 66019 RVA: 0x0043968C File Offset: 0x0043788C
		// (remove) Token: 0x060101E4 RID: 66020 RVA: 0x00439728 File Offset: 0x00437928
		public event Action<int> EventOnRankingQurey
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRankingQureyAction`1_hotfix != null)
				{
					this.m_add_EventOnRankingQureyAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnRankingQurey;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnRankingQurey, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRankingQureyAction`1_hotfix != null)
				{
					this.m_remove_EventOnRankingQureyAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnRankingQurey;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnRankingQurey, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000367 RID: 871
		// (add) Token: 0x060101E5 RID: 66021 RVA: 0x004397C4 File Offset: 0x004379C4
		// (remove) Token: 0x060101E6 RID: 66022 RVA: 0x00439860 File Offset: 0x00437A60
		public event Action EventOnRankingListLockClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRankingListLockClickAction_hotfix != null)
				{
					this.m_add_EventOnRankingListLockClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRankingListLockClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRankingListLockClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRankingListLockClickAction_hotfix != null)
				{
					this.m_remove_EventOnRankingListLockClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRankingListLockClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRankingListLockClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x060101E7 RID: 66023 RVA: 0x004398FC File Offset: 0x00437AFC
		// (set) Token: 0x060101E8 RID: 66024 RVA: 0x0043991C File Offset: 0x00437B1C
		[DoNotToLua]
		public new HeroCommentUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroCommentUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060101E9 RID: 66025 RVA: 0x00439928 File Offset: 0x00437B28
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060101EA RID: 66026 RVA: 0x00439934 File Offset: 0x00437B34
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060101EB RID: 66027 RVA: 0x0043993C File Offset: 0x00437B3C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060101EC RID: 66028 RVA: 0x00439944 File Offset: 0x00437B44
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060101ED RID: 66029 RVA: 0x00439958 File Offset: 0x00437B58
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060101EE RID: 66030 RVA: 0x00439960 File Offset: 0x00437B60
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060101EF RID: 66031 RVA: 0x0043996C File Offset: 0x00437B6C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060101F0 RID: 66032 RVA: 0x00439978 File Offset: 0x00437B78
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060101F1 RID: 66033 RVA: 0x00439984 File Offset: 0x00437B84
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060101F2 RID: 66034 RVA: 0x00439990 File Offset: 0x00437B90
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060101F3 RID: 66035 RVA: 0x0043999C File Offset: 0x00437B9C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060101F4 RID: 66036 RVA: 0x004399A8 File Offset: 0x00437BA8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060101F5 RID: 66037 RVA: 0x004399B4 File Offset: 0x00437BB4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060101F6 RID: 66038 RVA: 0x004399C0 File Offset: 0x00437BC0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060101F7 RID: 66039 RVA: 0x004399CC File Offset: 0x00437BCC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060101F8 RID: 66040 RVA: 0x004399D4 File Offset: 0x00437BD4
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x060101F9 RID: 66041 RVA: 0x004399F4 File Offset: 0x00437BF4
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x060101FA RID: 66042 RVA: 0x00439A00 File Offset: 0x00437C00
		private void __callDele_EventOnCommentSend(int arg1, string arg2)
		{
			Action<int, string> eventOnCommentSend = this.EventOnCommentSend;
			if (eventOnCommentSend != null)
			{
				eventOnCommentSend(arg1, arg2);
			}
		}

		// Token: 0x060101FB RID: 66043 RVA: 0x00439A24 File Offset: 0x00437C24
		private void __clearDele_EventOnCommentSend(int arg1, string arg2)
		{
			this.EventOnCommentSend = null;
		}

		// Token: 0x060101FC RID: 66044 RVA: 0x00439A30 File Offset: 0x00437C30
		private void __callDele_EventOnNameClick(int arg1, HeroCommentEntry arg2)
		{
			Action<int, HeroCommentEntry> eventOnNameClick = this.EventOnNameClick;
			if (eventOnNameClick != null)
			{
				eventOnNameClick(arg1, arg2);
			}
		}

		// Token: 0x060101FD RID: 66045 RVA: 0x00439A54 File Offset: 0x00437C54
		private void __clearDele_EventOnNameClick(int arg1, HeroCommentEntry arg2)
		{
			this.EventOnNameClick = null;
		}

		// Token: 0x060101FE RID: 66046 RVA: 0x00439A60 File Offset: 0x00437C60
		private void __callDele_EventOnPraisedBtnClick(int arg1, ulong arg2)
		{
			Action<int, ulong> eventOnPraisedBtnClick = this.EventOnPraisedBtnClick;
			if (eventOnPraisedBtnClick != null)
			{
				eventOnPraisedBtnClick(arg1, arg2);
			}
		}

		// Token: 0x060101FF RID: 66047 RVA: 0x00439A84 File Offset: 0x00437C84
		private void __clearDele_EventOnPraisedBtnClick(int arg1, ulong arg2)
		{
			this.EventOnPraisedBtnClick = null;
		}

		// Token: 0x06010200 RID: 66048 RVA: 0x00439A90 File Offset: 0x00437C90
		private void __callDele_EventOnGetHeroComments(int arg1, bool arg2)
		{
			Action<int, bool> eventOnGetHeroComments = this.EventOnGetHeroComments;
			if (eventOnGetHeroComments != null)
			{
				eventOnGetHeroComments(arg1, arg2);
			}
		}

		// Token: 0x06010201 RID: 66049 RVA: 0x00439AB4 File Offset: 0x00437CB4
		private void __clearDele_EventOnGetHeroComments(int arg1, bool arg2)
		{
			this.EventOnGetHeroComments = null;
		}

		// Token: 0x06010202 RID: 66050 RVA: 0x00439AC0 File Offset: 0x00437CC0
		private void __callDele_EventOnRankingQurey(int obj)
		{
			Action<int> eventOnRankingQurey = this.EventOnRankingQurey;
			if (eventOnRankingQurey != null)
			{
				eventOnRankingQurey(obj);
			}
		}

		// Token: 0x06010203 RID: 66051 RVA: 0x00439AE4 File Offset: 0x00437CE4
		private void __clearDele_EventOnRankingQurey(int obj)
		{
			this.EventOnRankingQurey = null;
		}

		// Token: 0x06010204 RID: 66052 RVA: 0x00439AF0 File Offset: 0x00437CF0
		private void __callDele_EventOnRankingListLockClick()
		{
			Action eventOnRankingListLockClick = this.EventOnRankingListLockClick;
			if (eventOnRankingListLockClick != null)
			{
				eventOnRankingListLockClick();
			}
		}

		// Token: 0x06010205 RID: 66053 RVA: 0x00439B10 File Offset: 0x00437D10
		private void __clearDele_EventOnRankingListLockClick()
		{
			this.EventOnRankingListLockClick = null;
		}

		// Token: 0x06010207 RID: 66055 RVA: 0x00439B2C File Offset: 0x00437D2C
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_HeroCommentUpdateViewHeroBoolean_hotfix = (luaObj.RawGet("HeroCommentUpdateView") as LuaFunction);
					this.m_UpdateRankingListLockBoolean_hotfix = (luaObj.RawGet("UpdateRankingListLock") as LuaFunction);
					this.m_CreateComments_hotfix = (luaObj.RawGet("CreateComments") as LuaFunction);
					this.m_UpdateRankingListRankingListInfo_hotfix = (luaObj.RawGet("UpdateRankingList") as LuaFunction);
					this.m_GetNormalCommentsInAllCommentsList`1List`1Int32_hotfix = (luaObj.RawGet("GetNormalCommentsInAllComments") as LuaFunction);
					this.m_CommentComparerByTimeHeroCommentEntryHeroCommentEntry_hotfix = (luaObj.RawGet("CommentComparerByTime") as LuaFunction);
					this.m_CommentComparerByPraisedNumHeroCommentEntryHeroCommentEntry_hotfix = (luaObj.RawGet("CommentComparerByPraisedNum") as LuaFunction);
					this.m_GetCommentsWithCountList`1Int32_hotfix = (luaObj.RawGet("GetCommentsWithCount") as LuaFunction);
					this.m_CreateCommentByListList`1GameObjectBoolean_hotfix = (luaObj.RawGet("CreateCommentByList") as LuaFunction);
					this.m_ShowPlayerHeroDetailPanelHeroCommentEntryHero_hotfix = (luaObj.RawGet("ShowPlayerHeroDetailPanel") as LuaFunction);
					this.m_OnSkillItemClickConfigDataSkillInfo_hotfix = (luaObj.RawGet("OnSkillItemClick") as LuaFunction);
					this.m_SetSkillDescPanelConfigDataSkillInfo_hotfix = (luaObj.RawGet("SetSkillDescPanel") as LuaFunction);
					this.m_SetSoldierPropAddTextInt32Int32Text_hotfix = (luaObj.RawGet("SetSoldierPropAddText") as LuaFunction);
					this.m_ClosePlayerHeroDetailPanel_hotfix = (luaObj.RawGet("ClosePlayerHeroDetailPanel") as LuaFunction);
					this.m_OnCommentItemNameClickHeroCommentEntry_hotfix = (luaObj.RawGet("OnCommentItemNameClick") as LuaFunction);
					this.m_OnCommentItemPraisedBtnClickUInt64_hotfix = (luaObj.RawGet("OnCommentItemPraisedBtnClick") as LuaFunction);
					this.m_OnMoreCommentButtonClick_hotfix = (luaObj.RawGet("OnMoreCommentButtonClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnAllCommentToggleClickBoolean_hotfix = (luaObj.RawGet("OnAllCommentToggleClick") as LuaFunction);
					this.m_OnHotCommentToggleClickBoolean_hotfix = (luaObj.RawGet("OnHotCommentToggleClick") as LuaFunction);
					this.m_OnRankingListCommentToggleClickBoolean_hotfix = (luaObj.RawGet("OnRankingListCommentToggleClick") as LuaFunction);
					this.m_OnRankingListLockButtonClick_hotfix = (luaObj.RawGet("OnRankingListLockButtonClick") as LuaFunction);
					this.m_OnCommentSendButtonClick_hotfix = (luaObj.RawGet("OnCommentSendButtonClick") as LuaFunction);
					this.m_CreateSpineGraphicUISpineGraphic_StringGameObjectInt32Vector2SingleList`1_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphicUISpineGraphic__hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_ResetScrollViewToTop_hotfix = (luaObj.RawGet("ResetScrollViewToTop") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnCommentSendAction`2_hotfix = (luaObj.RawGet("add_EventOnCommentSend") as LuaFunction);
					this.m_remove_EventOnCommentSendAction`2_hotfix = (luaObj.RawGet("remove_EventOnCommentSend") as LuaFunction);
					this.m_add_EventOnNameClickAction`2_hotfix = (luaObj.RawGet("add_EventOnNameClick") as LuaFunction);
					this.m_remove_EventOnNameClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnNameClick") as LuaFunction);
					this.m_add_EventOnPraisedBtnClickAction`2_hotfix = (luaObj.RawGet("add_EventOnPraisedBtnClick") as LuaFunction);
					this.m_remove_EventOnPraisedBtnClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnPraisedBtnClick") as LuaFunction);
					this.m_add_EventOnGetHeroCommentsAction`2_hotfix = (luaObj.RawGet("add_EventOnGetHeroComments") as LuaFunction);
					this.m_remove_EventOnGetHeroCommentsAction`2_hotfix = (luaObj.RawGet("remove_EventOnGetHeroComments") as LuaFunction);
					this.m_add_EventOnRankingQureyAction`1_hotfix = (luaObj.RawGet("add_EventOnRankingQurey") as LuaFunction);
					this.m_remove_EventOnRankingQureyAction`1_hotfix = (luaObj.RawGet("remove_EventOnRankingQurey") as LuaFunction);
					this.m_add_EventOnRankingListLockClickAction_hotfix = (luaObj.RawGet("add_EventOnRankingListLockClick") as LuaFunction);
					this.m_remove_EventOnRankingListLockClickAction_hotfix = (luaObj.RawGet("remove_EventOnRankingListLockClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010208 RID: 66056 RVA: 0x00439FF8 File Offset: 0x004381F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCommentUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009647 RID: 38471
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04009648 RID: 38472
		[AutoBind("./CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04009649 RID: 38473
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400964A RID: 38474
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Normal", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_commentNormalToggle;

		// Token: 0x0400964B RID: 38475
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Normal/UnClick", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_commentNormalToggleUnClick;

		// Token: 0x0400964C RID: 38476
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Normal/Click", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_commentNormalToggleClick;

		// Token: 0x0400964D RID: 38477
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Hot", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_commentHotToggle;

		// Token: 0x0400964E RID: 38478
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Hot/UnClick", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_commentHotToggleUnClick;

		// Token: 0x0400964F RID: 38479
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Hot/Click", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_commentHotToggleClick;

		// Token: 0x04009650 RID: 38480
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/RankingList", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_commentRankingToggle;

		// Token: 0x04009651 RID: 38481
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/RankingList/UnClick", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_commnetRankingUnClick;

		// Token: 0x04009652 RID: 38482
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/RankingList/Click", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_commnetRankingClick;

		// Token: 0x04009653 RID: 38483
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/RankingList/LockButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rankingListLockButton;

		// Token: 0x04009654 RID: 38484
		[AutoBind("./NoCommentPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noCommentPanelObj;

		// Token: 0x04009655 RID: 38485
		[AutoBind("./CommentList/Viewport/Content/HotContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_hotCommentListObj;

		// Token: 0x04009656 RID: 38486
		[AutoBind("./CommentList/Viewport/Content/NormalContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_normalCommentListObj;

		// Token: 0x04009657 RID: 38487
		[AutoBind("./CommentList/Viewport/Content/MoreCommentText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_moreCommentTextObj;

		// Token: 0x04009658 RID: 38488
		[AutoBind("./CommentList", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_commentListScrollRect;

		// Token: 0x04009659 RID: 38489
		[AutoBind("./InputComment", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_inputCommentGo;

		// Token: 0x0400965A RID: 38490
		[AutoBind("./InputComment/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_commentInputField;

		// Token: 0x0400965B RID: 38491
		[AutoBind("./InputComment/SendButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_commentSendButton;

		// Token: 0x0400965C RID: 38492
		[AutoBind("./Prefab/CommentItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_commentItemPrefabObj;

		// Token: 0x0400965D RID: 38493
		[AutoBind("./Prefab/MoreCommentButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_moreCommentButton;

		// Token: 0x0400965E RID: 38494
		[AutoBind("./RankingListGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rankingListGroup;

		// Token: 0x0400965F RID: 38495
		[AutoBind("./RankingListGroup", AutoBindAttribute.InitState.NotInit, false)]
		public RankingListUIController m_rankingListUICtrl;

		// Token: 0x04009660 RID: 38496
		[AutoBind("./PlayerHeroDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerHeroDetailPanelObj;

		// Token: 0x04009661 RID: 38497
		[AutoBind("./PlayerHeroDetailPanel/GrayBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_playerHeroDetailCloseImage;

		// Token: 0x04009662 RID: 38498
		[AutoBind("./PlayerHeroDetailPanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_playerHeroDetailCloseBtn;

		// Token: 0x04009663 RID: 38499
		[AutoBind("./PlayerHeroDetailPanel/Detail/HeroStars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerHeroLvStarsObj;

		// Token: 0x04009664 RID: 38500
		[AutoBind("./PlayerHeroDetailPanel/Detail/JobName/JobNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroJobNameText;

		// Token: 0x04009665 RID: 38501
		[AutoBind("./PlayerHeroDetailPanel/Detail/JobLV/LvImgs", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerHeroJobLvStarsObj;

		// Token: 0x04009666 RID: 38502
		[AutoBind("./PlayerHeroDetailPanel/Detail/JobLV/MasterImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroJobMasterImg;

		// Token: 0x04009667 RID: 38503
		[AutoBind("./PlayerHeroDetailPanel/Detail/HeroHalfBodyImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroHalfBodyImage;

		// Token: 0x04009668 RID: 38504
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/HP/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroPropHPImg;

		// Token: 0x04009669 RID: 38505
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/DF/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroPropDFImg;

		// Token: 0x0400966A RID: 38506
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/AT/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroPropATImg;

		// Token: 0x0400966B RID: 38507
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/MagicDF/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroPropMagicDFImg;

		// Token: 0x0400966C RID: 38508
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/Magic/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroPropMagicImg;

		// Token: 0x0400966D RID: 38509
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/DEX/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroPropDEXImg;

		// Token: 0x0400966E RID: 38510
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/HP/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropHPValueText;

		// Token: 0x0400966F RID: 38511
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/DF/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropDFValueText;

		// Token: 0x04009670 RID: 38512
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/AT/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropATValueText;

		// Token: 0x04009671 RID: 38513
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/MagicDF/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropMagicDFValueText;

		// Token: 0x04009672 RID: 38514
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/Magic/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropMagicValueText;

		// Token: 0x04009673 RID: 38515
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/DEX/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropDEXValueText;

		// Token: 0x04009674 RID: 38516
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/HP/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropHPAddText;

		// Token: 0x04009675 RID: 38517
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/DF/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropDFAddText;

		// Token: 0x04009676 RID: 38518
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/AT/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropATAddText;

		// Token: 0x04009677 RID: 38519
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/MagicDF/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropMagicDFAddText;

		// Token: 0x04009678 RID: 38520
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/Magic/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropMagicAddText;

		// Token: 0x04009679 RID: 38521
		[AutoBind("./PlayerHeroDetailPanel/Detail/Property/DEX/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroPropDEXAddText;

		// Token: 0x0400967A RID: 38522
		[AutoBind("./PlayerHeroDetailPanel/Detail/NameTitle/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x0400967B RID: 38523
		[AutoBind("./PlayerHeroDetailPanel/Detail/HeroName/LvValue/LvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroLvValueText;

		// Token: 0x0400967C RID: 38524
		[AutoBind("./PlayerHeroDetailPanel/Detail/HeroName/Name/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroNameText;

		// Token: 0x0400967D RID: 38525
		[AutoBind("./PlayerHeroDetailPanel/Detail/HeroName/SoldierIconImg/SoldierIconImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroSoldierIconImg;

		// Token: 0x0400967E RID: 38526
		[AutoBind("./PlayerHeroDetailPanel/Detail/Equipments/1", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroEquipments1;

		// Token: 0x0400967F RID: 38527
		[AutoBind("./PlayerHeroDetailPanel/Detail/Equipments/2", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroEquipments2;

		// Token: 0x04009680 RID: 38528
		[AutoBind("./PlayerHeroDetailPanel/Detail/Equipments/3", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroEquipments3;

		// Token: 0x04009681 RID: 38529
		[AutoBind("./PlayerHeroDetailPanel/Detail/Equipments/4", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroEquipments4;

		// Token: 0x04009682 RID: 38530
		[AutoBind("./PlayerHeroDetailPanel/Detail/TalentIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroTalentIcon;

		// Token: 0x04009683 RID: 38531
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillContent/1", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroSkillIcon1;

		// Token: 0x04009684 RID: 38532
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillContent/2", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroSkillIcon2;

		// Token: 0x04009685 RID: 38533
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillContent/3", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeroSkillIcon3;

		// Token: 0x04009686 RID: 38534
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillDesc", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerHeroSkillDescObj;

		// Token: 0x04009687 RID: 38535
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillDesc/TitleNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroSkillDescNameText;

		// Token: 0x04009688 RID: 38536
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillDesc/Costs", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerHeroSkillDescCostObj;

		// Token: 0x04009689 RID: 38537
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillDesc/SkillType/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroSkillDescText;

		// Token: 0x0400968A RID: 38538
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillDesc/Type/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroSkillDescTypeText;

		// Token: 0x0400968B RID: 38539
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillDesc/CD/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroSkillDescCDText;

		// Token: 0x0400968C RID: 38540
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillDesc/Distance/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroSkillDescDistanceText;

		// Token: 0x0400968D RID: 38541
		[AutoBind("./PlayerHeroDetailPanel/Detail/SkillDesc/Range/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerHeroSkillDescRangeText;

		// Token: 0x0400968E RID: 38542
		[AutoBind("./PlayerHeroDetailPanel/Detail/SoldierInfo/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGraphicObj;

		// Token: 0x0400968F RID: 38543
		[AutoBind("./PlayerHeroDetailPanel/Detail/SoldierInfo/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierHPValueText;

		// Token: 0x04009690 RID: 38544
		[AutoBind("./PlayerHeroDetailPanel/Detail/SoldierInfo/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierATValueText;

		// Token: 0x04009691 RID: 38545
		[AutoBind("./PlayerHeroDetailPanel/Detail/SoldierInfo/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDFValueText;

		// Token: 0x04009692 RID: 38546
		[AutoBind("./PlayerHeroDetailPanel/Detail/SoldierInfo/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMagicDFValueText;

		// Token: 0x04009693 RID: 38547
		[AutoBind("./PlayerHeroDetailPanel/Detail/SoldierInfo/HP/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierHPAddText;

		// Token: 0x04009694 RID: 38548
		[AutoBind("./PlayerHeroDetailPanel/Detail/SoldierInfo/AT/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierATAddText;

		// Token: 0x04009695 RID: 38549
		[AutoBind("./PlayerHeroDetailPanel/Detail/SoldierInfo/DF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDFAddText;

		// Token: 0x04009696 RID: 38550
		[AutoBind("./PlayerHeroDetailPanel/Detail/SoldierInfo/MagicDF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMagicDFAddText;

		// Token: 0x04009697 RID: 38551
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009698 RID: 38552
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009699 RID: 38553
		private Hero m_hero;

		// Token: 0x0400969A RID: 38554
		private UISpineGraphic m_soldierInfoGraphic;

		// Token: 0x0400969B RID: 38555
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x0400969C RID: 38556
		private HeroCommentUIController.ToggleState m_curToggleState;

		// Token: 0x0400969D RID: 38557
		private int m_curShowedNormalCommentCount = 10;

		// Token: 0x0400969E RID: 38558
		[DoNotToLua]
		private HeroCommentUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400969F RID: 38559
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040096A0 RID: 38560
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040096A1 RID: 38561
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040096A2 RID: 38562
		private LuaFunction m_Open_hotfix;

		// Token: 0x040096A3 RID: 38563
		private LuaFunction m_HeroCommentUpdateViewHeroBoolean_hotfix;

		// Token: 0x040096A4 RID: 38564
		private LuaFunction m_UpdateRankingListLockBoolean_hotfix;

		// Token: 0x040096A5 RID: 38565
		private LuaFunction m_CreateComments_hotfix;

		// Token: 0x040096A6 RID: 38566
		private LuaFunction m_UpdateRankingListRankingListInfo_hotfix;

		// Token: 0x040096A7 RID: 38567
		private LuaFunction m_GetNormalCommentsInAllCommentsList`1List;

		// Token: 0x040096A8 RID: 38568
		private LuaFunction m_CommentComparerByTimeHeroCommentEntryHeroCommentEntry_hotfix;

		// Token: 0x040096A9 RID: 38569
		private LuaFunction m_CommentComparerByPraisedNumHeroCommentEntryHeroCommentEntry_hotfix;

		// Token: 0x040096AA RID: 38570
		private LuaFunction m_GetCommentsWithCountList;

		// Token: 0x040096AB RID: 38571
		private LuaFunction m_CreateCommentByListList;

		// Token: 0x040096AC RID: 38572
		private LuaFunction m_ShowPlayerHeroDetailPanelHeroCommentEntryHero_hotfix;

		// Token: 0x040096AD RID: 38573
		private LuaFunction m_OnSkillItemClickConfigDataSkillInfo_hotfix;

		// Token: 0x040096AE RID: 38574
		private LuaFunction m_SetSkillDescPanelConfigDataSkillInfo_hotfix;

		// Token: 0x040096AF RID: 38575
		private LuaFunction m_SetSoldierPropAddTextInt32Int32Text_hotfix;

		// Token: 0x040096B0 RID: 38576
		private LuaFunction m_ClosePlayerHeroDetailPanel_hotfix;

		// Token: 0x040096B1 RID: 38577
		private LuaFunction m_OnCommentItemNameClickHeroCommentEntry_hotfix;

		// Token: 0x040096B2 RID: 38578
		private LuaFunction m_OnCommentItemPraisedBtnClickUInt64_hotfix;

		// Token: 0x040096B3 RID: 38579
		private LuaFunction m_OnMoreCommentButtonClick_hotfix;

		// Token: 0x040096B4 RID: 38580
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x040096B5 RID: 38581
		private LuaFunction m_OnAllCommentToggleClickBoolean_hotfix;

		// Token: 0x040096B6 RID: 38582
		private LuaFunction m_OnHotCommentToggleClickBoolean_hotfix;

		// Token: 0x040096B7 RID: 38583
		private LuaFunction m_OnRankingListCommentToggleClickBoolean_hotfix;

		// Token: 0x040096B8 RID: 38584
		private LuaFunction m_OnRankingListLockButtonClick_hotfix;

		// Token: 0x040096B9 RID: 38585
		private LuaFunction m_OnCommentSendButtonClick_hotfix;

		// Token: 0x040096BA RID: 38586
		private LuaFunction m_CreateSpineGraphicUISpineGraphic_StringGameObjectInt32Vector2SingleList;

		// Token: 0x040096BB RID: 38587
		private LuaFunction m_DestroySpineGraphicUISpineGraphic__hotfix;

		// Token: 0x040096BC RID: 38588
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x040096BD RID: 38589
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x040096BE RID: 38590
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x040096BF RID: 38591
		private LuaFunction m_add_EventOnCommentSendAction;

		// Token: 0x040096C0 RID: 38592
		private LuaFunction m_remove_EventOnCommentSendAction;

		// Token: 0x040096C1 RID: 38593
		private LuaFunction m_add_EventOnNameClickAction;

		// Token: 0x040096C2 RID: 38594
		private LuaFunction m_remove_EventOnNameClickAction;

		// Token: 0x040096C3 RID: 38595
		private LuaFunction m_add_EventOnPraisedBtnClickAction;

		// Token: 0x040096C4 RID: 38596
		private LuaFunction m_remove_EventOnPraisedBtnClickAction;

		// Token: 0x040096C5 RID: 38597
		private LuaFunction m_add_EventOnGetHeroCommentsAction;

		// Token: 0x040096C6 RID: 38598
		private LuaFunction m_remove_EventOnGetHeroCommentsAction;

		// Token: 0x040096C7 RID: 38599
		private LuaFunction m_add_EventOnRankingQureyAction;

		// Token: 0x040096C8 RID: 38600
		private LuaFunction m_remove_EventOnRankingQureyAction;

		// Token: 0x040096C9 RID: 38601
		private LuaFunction m_add_EventOnRankingListLockClickAction_hotfix;

		// Token: 0x040096CA RID: 38602
		private LuaFunction m_remove_EventOnRankingListLockClickAction_hotfix;

		// Token: 0x02000D88 RID: 3464
		public enum ToggleState
		{
			// Token: 0x040096CC RID: 38604
			Hot,
			// Token: 0x040096CD RID: 38605
			All,
			// Token: 0x040096CE RID: 38606
			Ranking
		}

		// Token: 0x02000D89 RID: 3465
		public new class LuaExportHelper
		{
			// Token: 0x06010209 RID: 66057 RVA: 0x0043A060 File Offset: 0x00438260
			public LuaExportHelper(HeroCommentUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601020A RID: 66058 RVA: 0x0043A070 File Offset: 0x00438270
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601020B RID: 66059 RVA: 0x0043A080 File Offset: 0x00438280
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601020C RID: 66060 RVA: 0x0043A090 File Offset: 0x00438290
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601020D RID: 66061 RVA: 0x0043A0A0 File Offset: 0x004382A0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601020E RID: 66062 RVA: 0x0043A0B8 File Offset: 0x004382B8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601020F RID: 66063 RVA: 0x0043A0C8 File Offset: 0x004382C8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010210 RID: 66064 RVA: 0x0043A0D8 File Offset: 0x004382D8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010211 RID: 66065 RVA: 0x0043A0E8 File Offset: 0x004382E8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010212 RID: 66066 RVA: 0x0043A0F8 File Offset: 0x004382F8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010213 RID: 66067 RVA: 0x0043A108 File Offset: 0x00438308
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010214 RID: 66068 RVA: 0x0043A118 File Offset: 0x00438318
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010215 RID: 66069 RVA: 0x0043A128 File Offset: 0x00438328
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010216 RID: 66070 RVA: 0x0043A138 File Offset: 0x00438338
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010217 RID: 66071 RVA: 0x0043A148 File Offset: 0x00438348
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010218 RID: 66072 RVA: 0x0043A158 File Offset: 0x00438358
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010219 RID: 66073 RVA: 0x0043A168 File Offset: 0x00438368
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0601021A RID: 66074 RVA: 0x0043A178 File Offset: 0x00438378
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0601021B RID: 66075 RVA: 0x0043A188 File Offset: 0x00438388
			public void __callDele_EventOnCommentSend(int arg1, string arg2)
			{
				this.m_owner.__callDele_EventOnCommentSend(arg1, arg2);
			}

			// Token: 0x0601021C RID: 66076 RVA: 0x0043A198 File Offset: 0x00438398
			public void __clearDele_EventOnCommentSend(int arg1, string arg2)
			{
				this.m_owner.__clearDele_EventOnCommentSend(arg1, arg2);
			}

			// Token: 0x0601021D RID: 66077 RVA: 0x0043A1A8 File Offset: 0x004383A8
			public void __callDele_EventOnNameClick(int arg1, HeroCommentEntry arg2)
			{
				this.m_owner.__callDele_EventOnNameClick(arg1, arg2);
			}

			// Token: 0x0601021E RID: 66078 RVA: 0x0043A1B8 File Offset: 0x004383B8
			public void __clearDele_EventOnNameClick(int arg1, HeroCommentEntry arg2)
			{
				this.m_owner.__clearDele_EventOnNameClick(arg1, arg2);
			}

			// Token: 0x0601021F RID: 66079 RVA: 0x0043A1C8 File Offset: 0x004383C8
			public void __callDele_EventOnPraisedBtnClick(int arg1, ulong arg2)
			{
				this.m_owner.__callDele_EventOnPraisedBtnClick(arg1, arg2);
			}

			// Token: 0x06010220 RID: 66080 RVA: 0x0043A1D8 File Offset: 0x004383D8
			public void __clearDele_EventOnPraisedBtnClick(int arg1, ulong arg2)
			{
				this.m_owner.__clearDele_EventOnPraisedBtnClick(arg1, arg2);
			}

			// Token: 0x06010221 RID: 66081 RVA: 0x0043A1E8 File Offset: 0x004383E8
			public void __callDele_EventOnGetHeroComments(int arg1, bool arg2)
			{
				this.m_owner.__callDele_EventOnGetHeroComments(arg1, arg2);
			}

			// Token: 0x06010222 RID: 66082 RVA: 0x0043A1F8 File Offset: 0x004383F8
			public void __clearDele_EventOnGetHeroComments(int arg1, bool arg2)
			{
				this.m_owner.__clearDele_EventOnGetHeroComments(arg1, arg2);
			}

			// Token: 0x06010223 RID: 66083 RVA: 0x0043A208 File Offset: 0x00438408
			public void __callDele_EventOnRankingQurey(int obj)
			{
				this.m_owner.__callDele_EventOnRankingQurey(obj);
			}

			// Token: 0x06010224 RID: 66084 RVA: 0x0043A218 File Offset: 0x00438418
			public void __clearDele_EventOnRankingQurey(int obj)
			{
				this.m_owner.__clearDele_EventOnRankingQurey(obj);
			}

			// Token: 0x06010225 RID: 66085 RVA: 0x0043A228 File Offset: 0x00438428
			public void __callDele_EventOnRankingListLockClick()
			{
				this.m_owner.__callDele_EventOnRankingListLockClick();
			}

			// Token: 0x06010226 RID: 66086 RVA: 0x0043A238 File Offset: 0x00438438
			public void __clearDele_EventOnRankingListLockClick()
			{
				this.m_owner.__clearDele_EventOnRankingListLockClick();
			}

			// Token: 0x1700317F RID: 12671
			// (get) Token: 0x06010227 RID: 66087 RVA: 0x0043A248 File Offset: 0x00438448
			// (set) Token: 0x06010228 RID: 66088 RVA: 0x0043A258 File Offset: 0x00438458
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x17003180 RID: 12672
			// (get) Token: 0x06010229 RID: 66089 RVA: 0x0043A268 File Offset: 0x00438468
			// (set) Token: 0x0601022A RID: 66090 RVA: 0x0043A278 File Offset: 0x00438478
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

			// Token: 0x17003181 RID: 12673
			// (get) Token: 0x0601022B RID: 66091 RVA: 0x0043A288 File Offset: 0x00438488
			// (set) Token: 0x0601022C RID: 66092 RVA: 0x0043A298 File Offset: 0x00438498
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

			// Token: 0x17003182 RID: 12674
			// (get) Token: 0x0601022D RID: 66093 RVA: 0x0043A2A8 File Offset: 0x004384A8
			// (set) Token: 0x0601022E RID: 66094 RVA: 0x0043A2B8 File Offset: 0x004384B8
			public Toggle m_commentNormalToggle
			{
				get
				{
					return this.m_owner.m_commentNormalToggle;
				}
				set
				{
					this.m_owner.m_commentNormalToggle = value;
				}
			}

			// Token: 0x17003183 RID: 12675
			// (get) Token: 0x0601022F RID: 66095 RVA: 0x0043A2C8 File Offset: 0x004384C8
			// (set) Token: 0x06010230 RID: 66096 RVA: 0x0043A2D8 File Offset: 0x004384D8
			public GameObject m_commentNormalToggleUnClick
			{
				get
				{
					return this.m_owner.m_commentNormalToggleUnClick;
				}
				set
				{
					this.m_owner.m_commentNormalToggleUnClick = value;
				}
			}

			// Token: 0x17003184 RID: 12676
			// (get) Token: 0x06010231 RID: 66097 RVA: 0x0043A2E8 File Offset: 0x004384E8
			// (set) Token: 0x06010232 RID: 66098 RVA: 0x0043A2F8 File Offset: 0x004384F8
			public GameObject m_commentNormalToggleClick
			{
				get
				{
					return this.m_owner.m_commentNormalToggleClick;
				}
				set
				{
					this.m_owner.m_commentNormalToggleClick = value;
				}
			}

			// Token: 0x17003185 RID: 12677
			// (get) Token: 0x06010233 RID: 66099 RVA: 0x0043A308 File Offset: 0x00438508
			// (set) Token: 0x06010234 RID: 66100 RVA: 0x0043A318 File Offset: 0x00438518
			public Toggle m_commentHotToggle
			{
				get
				{
					return this.m_owner.m_commentHotToggle;
				}
				set
				{
					this.m_owner.m_commentHotToggle = value;
				}
			}

			// Token: 0x17003186 RID: 12678
			// (get) Token: 0x06010235 RID: 66101 RVA: 0x0043A328 File Offset: 0x00438528
			// (set) Token: 0x06010236 RID: 66102 RVA: 0x0043A338 File Offset: 0x00438538
			public GameObject m_commentHotToggleUnClick
			{
				get
				{
					return this.m_owner.m_commentHotToggleUnClick;
				}
				set
				{
					this.m_owner.m_commentHotToggleUnClick = value;
				}
			}

			// Token: 0x17003187 RID: 12679
			// (get) Token: 0x06010237 RID: 66103 RVA: 0x0043A348 File Offset: 0x00438548
			// (set) Token: 0x06010238 RID: 66104 RVA: 0x0043A358 File Offset: 0x00438558
			public GameObject m_commentHotToggleClick
			{
				get
				{
					return this.m_owner.m_commentHotToggleClick;
				}
				set
				{
					this.m_owner.m_commentHotToggleClick = value;
				}
			}

			// Token: 0x17003188 RID: 12680
			// (get) Token: 0x06010239 RID: 66105 RVA: 0x0043A368 File Offset: 0x00438568
			// (set) Token: 0x0601023A RID: 66106 RVA: 0x0043A378 File Offset: 0x00438578
			public Toggle m_commentRankingToggle
			{
				get
				{
					return this.m_owner.m_commentRankingToggle;
				}
				set
				{
					this.m_owner.m_commentRankingToggle = value;
				}
			}

			// Token: 0x17003189 RID: 12681
			// (get) Token: 0x0601023B RID: 66107 RVA: 0x0043A388 File Offset: 0x00438588
			// (set) Token: 0x0601023C RID: 66108 RVA: 0x0043A398 File Offset: 0x00438598
			public GameObject m_commnetRankingUnClick
			{
				get
				{
					return this.m_owner.m_commnetRankingUnClick;
				}
				set
				{
					this.m_owner.m_commnetRankingUnClick = value;
				}
			}

			// Token: 0x1700318A RID: 12682
			// (get) Token: 0x0601023D RID: 66109 RVA: 0x0043A3A8 File Offset: 0x004385A8
			// (set) Token: 0x0601023E RID: 66110 RVA: 0x0043A3B8 File Offset: 0x004385B8
			public GameObject m_commnetRankingClick
			{
				get
				{
					return this.m_owner.m_commnetRankingClick;
				}
				set
				{
					this.m_owner.m_commnetRankingClick = value;
				}
			}

			// Token: 0x1700318B RID: 12683
			// (get) Token: 0x0601023F RID: 66111 RVA: 0x0043A3C8 File Offset: 0x004385C8
			// (set) Token: 0x06010240 RID: 66112 RVA: 0x0043A3D8 File Offset: 0x004385D8
			public Button m_rankingListLockButton
			{
				get
				{
					return this.m_owner.m_rankingListLockButton;
				}
				set
				{
					this.m_owner.m_rankingListLockButton = value;
				}
			}

			// Token: 0x1700318C RID: 12684
			// (get) Token: 0x06010241 RID: 66113 RVA: 0x0043A3E8 File Offset: 0x004385E8
			// (set) Token: 0x06010242 RID: 66114 RVA: 0x0043A3F8 File Offset: 0x004385F8
			public GameObject m_noCommentPanelObj
			{
				get
				{
					return this.m_owner.m_noCommentPanelObj;
				}
				set
				{
					this.m_owner.m_noCommentPanelObj = value;
				}
			}

			// Token: 0x1700318D RID: 12685
			// (get) Token: 0x06010243 RID: 66115 RVA: 0x0043A408 File Offset: 0x00438608
			// (set) Token: 0x06010244 RID: 66116 RVA: 0x0043A418 File Offset: 0x00438618
			public GameObject m_hotCommentListObj
			{
				get
				{
					return this.m_owner.m_hotCommentListObj;
				}
				set
				{
					this.m_owner.m_hotCommentListObj = value;
				}
			}

			// Token: 0x1700318E RID: 12686
			// (get) Token: 0x06010245 RID: 66117 RVA: 0x0043A428 File Offset: 0x00438628
			// (set) Token: 0x06010246 RID: 66118 RVA: 0x0043A438 File Offset: 0x00438638
			public GameObject m_normalCommentListObj
			{
				get
				{
					return this.m_owner.m_normalCommentListObj;
				}
				set
				{
					this.m_owner.m_normalCommentListObj = value;
				}
			}

			// Token: 0x1700318F RID: 12687
			// (get) Token: 0x06010247 RID: 66119 RVA: 0x0043A448 File Offset: 0x00438648
			// (set) Token: 0x06010248 RID: 66120 RVA: 0x0043A458 File Offset: 0x00438658
			public GameObject m_moreCommentTextObj
			{
				get
				{
					return this.m_owner.m_moreCommentTextObj;
				}
				set
				{
					this.m_owner.m_moreCommentTextObj = value;
				}
			}

			// Token: 0x17003190 RID: 12688
			// (get) Token: 0x06010249 RID: 66121 RVA: 0x0043A468 File Offset: 0x00438668
			// (set) Token: 0x0601024A RID: 66122 RVA: 0x0043A478 File Offset: 0x00438678
			public ScrollRect m_commentListScrollRect
			{
				get
				{
					return this.m_owner.m_commentListScrollRect;
				}
				set
				{
					this.m_owner.m_commentListScrollRect = value;
				}
			}

			// Token: 0x17003191 RID: 12689
			// (get) Token: 0x0601024B RID: 66123 RVA: 0x0043A488 File Offset: 0x00438688
			// (set) Token: 0x0601024C RID: 66124 RVA: 0x0043A498 File Offset: 0x00438698
			public GameObject m_inputCommentGo
			{
				get
				{
					return this.m_owner.m_inputCommentGo;
				}
				set
				{
					this.m_owner.m_inputCommentGo = value;
				}
			}

			// Token: 0x17003192 RID: 12690
			// (get) Token: 0x0601024D RID: 66125 RVA: 0x0043A4A8 File Offset: 0x004386A8
			// (set) Token: 0x0601024E RID: 66126 RVA: 0x0043A4B8 File Offset: 0x004386B8
			public InputField m_commentInputField
			{
				get
				{
					return this.m_owner.m_commentInputField;
				}
				set
				{
					this.m_owner.m_commentInputField = value;
				}
			}

			// Token: 0x17003193 RID: 12691
			// (get) Token: 0x0601024F RID: 66127 RVA: 0x0043A4C8 File Offset: 0x004386C8
			// (set) Token: 0x06010250 RID: 66128 RVA: 0x0043A4D8 File Offset: 0x004386D8
			public Button m_commentSendButton
			{
				get
				{
					return this.m_owner.m_commentSendButton;
				}
				set
				{
					this.m_owner.m_commentSendButton = value;
				}
			}

			// Token: 0x17003194 RID: 12692
			// (get) Token: 0x06010251 RID: 66129 RVA: 0x0043A4E8 File Offset: 0x004386E8
			// (set) Token: 0x06010252 RID: 66130 RVA: 0x0043A4F8 File Offset: 0x004386F8
			public GameObject m_commentItemPrefabObj
			{
				get
				{
					return this.m_owner.m_commentItemPrefabObj;
				}
				set
				{
					this.m_owner.m_commentItemPrefabObj = value;
				}
			}

			// Token: 0x17003195 RID: 12693
			// (get) Token: 0x06010253 RID: 66131 RVA: 0x0043A508 File Offset: 0x00438708
			// (set) Token: 0x06010254 RID: 66132 RVA: 0x0043A518 File Offset: 0x00438718
			public Button m_moreCommentButton
			{
				get
				{
					return this.m_owner.m_moreCommentButton;
				}
				set
				{
					this.m_owner.m_moreCommentButton = value;
				}
			}

			// Token: 0x17003196 RID: 12694
			// (get) Token: 0x06010255 RID: 66133 RVA: 0x0043A528 File Offset: 0x00438728
			// (set) Token: 0x06010256 RID: 66134 RVA: 0x0043A538 File Offset: 0x00438738
			public GameObject m_rankingListGroup
			{
				get
				{
					return this.m_owner.m_rankingListGroup;
				}
				set
				{
					this.m_owner.m_rankingListGroup = value;
				}
			}

			// Token: 0x17003197 RID: 12695
			// (get) Token: 0x06010257 RID: 66135 RVA: 0x0043A548 File Offset: 0x00438748
			// (set) Token: 0x06010258 RID: 66136 RVA: 0x0043A558 File Offset: 0x00438758
			public GameObject m_playerHeroDetailPanelObj
			{
				get
				{
					return this.m_owner.m_playerHeroDetailPanelObj;
				}
				set
				{
					this.m_owner.m_playerHeroDetailPanelObj = value;
				}
			}

			// Token: 0x17003198 RID: 12696
			// (get) Token: 0x06010259 RID: 66137 RVA: 0x0043A568 File Offset: 0x00438768
			// (set) Token: 0x0601025A RID: 66138 RVA: 0x0043A578 File Offset: 0x00438778
			public Button m_playerHeroDetailCloseImage
			{
				get
				{
					return this.m_owner.m_playerHeroDetailCloseImage;
				}
				set
				{
					this.m_owner.m_playerHeroDetailCloseImage = value;
				}
			}

			// Token: 0x17003199 RID: 12697
			// (get) Token: 0x0601025B RID: 66139 RVA: 0x0043A588 File Offset: 0x00438788
			// (set) Token: 0x0601025C RID: 66140 RVA: 0x0043A598 File Offset: 0x00438798
			public Button m_playerHeroDetailCloseBtn
			{
				get
				{
					return this.m_owner.m_playerHeroDetailCloseBtn;
				}
				set
				{
					this.m_owner.m_playerHeroDetailCloseBtn = value;
				}
			}

			// Token: 0x1700319A RID: 12698
			// (get) Token: 0x0601025D RID: 66141 RVA: 0x0043A5A8 File Offset: 0x004387A8
			// (set) Token: 0x0601025E RID: 66142 RVA: 0x0043A5B8 File Offset: 0x004387B8
			public GameObject m_playerHeroLvStarsObj
			{
				get
				{
					return this.m_owner.m_playerHeroLvStarsObj;
				}
				set
				{
					this.m_owner.m_playerHeroLvStarsObj = value;
				}
			}

			// Token: 0x1700319B RID: 12699
			// (get) Token: 0x0601025F RID: 66143 RVA: 0x0043A5C8 File Offset: 0x004387C8
			// (set) Token: 0x06010260 RID: 66144 RVA: 0x0043A5D8 File Offset: 0x004387D8
			public Text m_playerHeroJobNameText
			{
				get
				{
					return this.m_owner.m_playerHeroJobNameText;
				}
				set
				{
					this.m_owner.m_playerHeroJobNameText = value;
				}
			}

			// Token: 0x1700319C RID: 12700
			// (get) Token: 0x06010261 RID: 66145 RVA: 0x0043A5E8 File Offset: 0x004387E8
			// (set) Token: 0x06010262 RID: 66146 RVA: 0x0043A5F8 File Offset: 0x004387F8
			public GameObject m_playerHeroJobLvStarsObj
			{
				get
				{
					return this.m_owner.m_playerHeroJobLvStarsObj;
				}
				set
				{
					this.m_owner.m_playerHeroJobLvStarsObj = value;
				}
			}

			// Token: 0x1700319D RID: 12701
			// (get) Token: 0x06010263 RID: 66147 RVA: 0x0043A608 File Offset: 0x00438808
			// (set) Token: 0x06010264 RID: 66148 RVA: 0x0043A618 File Offset: 0x00438818
			public Image m_playerHeroJobMasterImg
			{
				get
				{
					return this.m_owner.m_playerHeroJobMasterImg;
				}
				set
				{
					this.m_owner.m_playerHeroJobMasterImg = value;
				}
			}

			// Token: 0x1700319E RID: 12702
			// (get) Token: 0x06010265 RID: 66149 RVA: 0x0043A628 File Offset: 0x00438828
			// (set) Token: 0x06010266 RID: 66150 RVA: 0x0043A638 File Offset: 0x00438838
			public Image m_playerHeroHalfBodyImage
			{
				get
				{
					return this.m_owner.m_playerHeroHalfBodyImage;
				}
				set
				{
					this.m_owner.m_playerHeroHalfBodyImage = value;
				}
			}

			// Token: 0x1700319F RID: 12703
			// (get) Token: 0x06010267 RID: 66151 RVA: 0x0043A648 File Offset: 0x00438848
			// (set) Token: 0x06010268 RID: 66152 RVA: 0x0043A658 File Offset: 0x00438858
			public Image m_playerHeroPropHPImg
			{
				get
				{
					return this.m_owner.m_playerHeroPropHPImg;
				}
				set
				{
					this.m_owner.m_playerHeroPropHPImg = value;
				}
			}

			// Token: 0x170031A0 RID: 12704
			// (get) Token: 0x06010269 RID: 66153 RVA: 0x0043A668 File Offset: 0x00438868
			// (set) Token: 0x0601026A RID: 66154 RVA: 0x0043A678 File Offset: 0x00438878
			public Image m_playerHeroPropDFImg
			{
				get
				{
					return this.m_owner.m_playerHeroPropDFImg;
				}
				set
				{
					this.m_owner.m_playerHeroPropDFImg = value;
				}
			}

			// Token: 0x170031A1 RID: 12705
			// (get) Token: 0x0601026B RID: 66155 RVA: 0x0043A688 File Offset: 0x00438888
			// (set) Token: 0x0601026C RID: 66156 RVA: 0x0043A698 File Offset: 0x00438898
			public Image m_playerHeroPropATImg
			{
				get
				{
					return this.m_owner.m_playerHeroPropATImg;
				}
				set
				{
					this.m_owner.m_playerHeroPropATImg = value;
				}
			}

			// Token: 0x170031A2 RID: 12706
			// (get) Token: 0x0601026D RID: 66157 RVA: 0x0043A6A8 File Offset: 0x004388A8
			// (set) Token: 0x0601026E RID: 66158 RVA: 0x0043A6B8 File Offset: 0x004388B8
			public Image m_playerHeroPropMagicDFImg
			{
				get
				{
					return this.m_owner.m_playerHeroPropMagicDFImg;
				}
				set
				{
					this.m_owner.m_playerHeroPropMagicDFImg = value;
				}
			}

			// Token: 0x170031A3 RID: 12707
			// (get) Token: 0x0601026F RID: 66159 RVA: 0x0043A6C8 File Offset: 0x004388C8
			// (set) Token: 0x06010270 RID: 66160 RVA: 0x0043A6D8 File Offset: 0x004388D8
			public Image m_playerHeroPropMagicImg
			{
				get
				{
					return this.m_owner.m_playerHeroPropMagicImg;
				}
				set
				{
					this.m_owner.m_playerHeroPropMagicImg = value;
				}
			}

			// Token: 0x170031A4 RID: 12708
			// (get) Token: 0x06010271 RID: 66161 RVA: 0x0043A6E8 File Offset: 0x004388E8
			// (set) Token: 0x06010272 RID: 66162 RVA: 0x0043A6F8 File Offset: 0x004388F8
			public Image m_playerHeroPropDEXImg
			{
				get
				{
					return this.m_owner.m_playerHeroPropDEXImg;
				}
				set
				{
					this.m_owner.m_playerHeroPropDEXImg = value;
				}
			}

			// Token: 0x170031A5 RID: 12709
			// (get) Token: 0x06010273 RID: 66163 RVA: 0x0043A708 File Offset: 0x00438908
			// (set) Token: 0x06010274 RID: 66164 RVA: 0x0043A718 File Offset: 0x00438918
			public Text m_playerHeroPropHPValueText
			{
				get
				{
					return this.m_owner.m_playerHeroPropHPValueText;
				}
				set
				{
					this.m_owner.m_playerHeroPropHPValueText = value;
				}
			}

			// Token: 0x170031A6 RID: 12710
			// (get) Token: 0x06010275 RID: 66165 RVA: 0x0043A728 File Offset: 0x00438928
			// (set) Token: 0x06010276 RID: 66166 RVA: 0x0043A738 File Offset: 0x00438938
			public Text m_playerHeroPropDFValueText
			{
				get
				{
					return this.m_owner.m_playerHeroPropDFValueText;
				}
				set
				{
					this.m_owner.m_playerHeroPropDFValueText = value;
				}
			}

			// Token: 0x170031A7 RID: 12711
			// (get) Token: 0x06010277 RID: 66167 RVA: 0x0043A748 File Offset: 0x00438948
			// (set) Token: 0x06010278 RID: 66168 RVA: 0x0043A758 File Offset: 0x00438958
			public Text m_playerHeroPropATValueText
			{
				get
				{
					return this.m_owner.m_playerHeroPropATValueText;
				}
				set
				{
					this.m_owner.m_playerHeroPropATValueText = value;
				}
			}

			// Token: 0x170031A8 RID: 12712
			// (get) Token: 0x06010279 RID: 66169 RVA: 0x0043A768 File Offset: 0x00438968
			// (set) Token: 0x0601027A RID: 66170 RVA: 0x0043A778 File Offset: 0x00438978
			public Text m_playerHeroPropMagicDFValueText
			{
				get
				{
					return this.m_owner.m_playerHeroPropMagicDFValueText;
				}
				set
				{
					this.m_owner.m_playerHeroPropMagicDFValueText = value;
				}
			}

			// Token: 0x170031A9 RID: 12713
			// (get) Token: 0x0601027B RID: 66171 RVA: 0x0043A788 File Offset: 0x00438988
			// (set) Token: 0x0601027C RID: 66172 RVA: 0x0043A798 File Offset: 0x00438998
			public Text m_playerHeroPropMagicValueText
			{
				get
				{
					return this.m_owner.m_playerHeroPropMagicValueText;
				}
				set
				{
					this.m_owner.m_playerHeroPropMagicValueText = value;
				}
			}

			// Token: 0x170031AA RID: 12714
			// (get) Token: 0x0601027D RID: 66173 RVA: 0x0043A7A8 File Offset: 0x004389A8
			// (set) Token: 0x0601027E RID: 66174 RVA: 0x0043A7B8 File Offset: 0x004389B8
			public Text m_playerHeroPropDEXValueText
			{
				get
				{
					return this.m_owner.m_playerHeroPropDEXValueText;
				}
				set
				{
					this.m_owner.m_playerHeroPropDEXValueText = value;
				}
			}

			// Token: 0x170031AB RID: 12715
			// (get) Token: 0x0601027F RID: 66175 RVA: 0x0043A7C8 File Offset: 0x004389C8
			// (set) Token: 0x06010280 RID: 66176 RVA: 0x0043A7D8 File Offset: 0x004389D8
			public Text m_playerHeroPropHPAddText
			{
				get
				{
					return this.m_owner.m_playerHeroPropHPAddText;
				}
				set
				{
					this.m_owner.m_playerHeroPropHPAddText = value;
				}
			}

			// Token: 0x170031AC RID: 12716
			// (get) Token: 0x06010281 RID: 66177 RVA: 0x0043A7E8 File Offset: 0x004389E8
			// (set) Token: 0x06010282 RID: 66178 RVA: 0x0043A7F8 File Offset: 0x004389F8
			public Text m_playerHeroPropDFAddText
			{
				get
				{
					return this.m_owner.m_playerHeroPropDFAddText;
				}
				set
				{
					this.m_owner.m_playerHeroPropDFAddText = value;
				}
			}

			// Token: 0x170031AD RID: 12717
			// (get) Token: 0x06010283 RID: 66179 RVA: 0x0043A808 File Offset: 0x00438A08
			// (set) Token: 0x06010284 RID: 66180 RVA: 0x0043A818 File Offset: 0x00438A18
			public Text m_playerHeroPropATAddText
			{
				get
				{
					return this.m_owner.m_playerHeroPropATAddText;
				}
				set
				{
					this.m_owner.m_playerHeroPropATAddText = value;
				}
			}

			// Token: 0x170031AE RID: 12718
			// (get) Token: 0x06010285 RID: 66181 RVA: 0x0043A828 File Offset: 0x00438A28
			// (set) Token: 0x06010286 RID: 66182 RVA: 0x0043A838 File Offset: 0x00438A38
			public Text m_playerHeroPropMagicDFAddText
			{
				get
				{
					return this.m_owner.m_playerHeroPropMagicDFAddText;
				}
				set
				{
					this.m_owner.m_playerHeroPropMagicDFAddText = value;
				}
			}

			// Token: 0x170031AF RID: 12719
			// (get) Token: 0x06010287 RID: 66183 RVA: 0x0043A848 File Offset: 0x00438A48
			// (set) Token: 0x06010288 RID: 66184 RVA: 0x0043A858 File Offset: 0x00438A58
			public Text m_playerHeroPropMagicAddText
			{
				get
				{
					return this.m_owner.m_playerHeroPropMagicAddText;
				}
				set
				{
					this.m_owner.m_playerHeroPropMagicAddText = value;
				}
			}

			// Token: 0x170031B0 RID: 12720
			// (get) Token: 0x06010289 RID: 66185 RVA: 0x0043A868 File Offset: 0x00438A68
			// (set) Token: 0x0601028A RID: 66186 RVA: 0x0043A878 File Offset: 0x00438A78
			public Text m_playerHeroPropDEXAddText
			{
				get
				{
					return this.m_owner.m_playerHeroPropDEXAddText;
				}
				set
				{
					this.m_owner.m_playerHeroPropDEXAddText = value;
				}
			}

			// Token: 0x170031B1 RID: 12721
			// (get) Token: 0x0601028B RID: 66187 RVA: 0x0043A888 File Offset: 0x00438A88
			// (set) Token: 0x0601028C RID: 66188 RVA: 0x0043A898 File Offset: 0x00438A98
			public Text m_playerNameText
			{
				get
				{
					return this.m_owner.m_playerNameText;
				}
				set
				{
					this.m_owner.m_playerNameText = value;
				}
			}

			// Token: 0x170031B2 RID: 12722
			// (get) Token: 0x0601028D RID: 66189 RVA: 0x0043A8A8 File Offset: 0x00438AA8
			// (set) Token: 0x0601028E RID: 66190 RVA: 0x0043A8B8 File Offset: 0x00438AB8
			public Text m_playerHeroLvValueText
			{
				get
				{
					return this.m_owner.m_playerHeroLvValueText;
				}
				set
				{
					this.m_owner.m_playerHeroLvValueText = value;
				}
			}

			// Token: 0x170031B3 RID: 12723
			// (get) Token: 0x0601028F RID: 66191 RVA: 0x0043A8C8 File Offset: 0x00438AC8
			// (set) Token: 0x06010290 RID: 66192 RVA: 0x0043A8D8 File Offset: 0x00438AD8
			public Text m_playerHeroNameText
			{
				get
				{
					return this.m_owner.m_playerHeroNameText;
				}
				set
				{
					this.m_owner.m_playerHeroNameText = value;
				}
			}

			// Token: 0x170031B4 RID: 12724
			// (get) Token: 0x06010291 RID: 66193 RVA: 0x0043A8E8 File Offset: 0x00438AE8
			// (set) Token: 0x06010292 RID: 66194 RVA: 0x0043A8F8 File Offset: 0x00438AF8
			public Image m_playerHeroSoldierIconImg
			{
				get
				{
					return this.m_owner.m_playerHeroSoldierIconImg;
				}
				set
				{
					this.m_owner.m_playerHeroSoldierIconImg = value;
				}
			}

			// Token: 0x170031B5 RID: 12725
			// (get) Token: 0x06010293 RID: 66195 RVA: 0x0043A908 File Offset: 0x00438B08
			// (set) Token: 0x06010294 RID: 66196 RVA: 0x0043A918 File Offset: 0x00438B18
			public Image m_playerHeroEquipments1
			{
				get
				{
					return this.m_owner.m_playerHeroEquipments1;
				}
				set
				{
					this.m_owner.m_playerHeroEquipments1 = value;
				}
			}

			// Token: 0x170031B6 RID: 12726
			// (get) Token: 0x06010295 RID: 66197 RVA: 0x0043A928 File Offset: 0x00438B28
			// (set) Token: 0x06010296 RID: 66198 RVA: 0x0043A938 File Offset: 0x00438B38
			public Image m_playerHeroEquipments2
			{
				get
				{
					return this.m_owner.m_playerHeroEquipments2;
				}
				set
				{
					this.m_owner.m_playerHeroEquipments2 = value;
				}
			}

			// Token: 0x170031B7 RID: 12727
			// (get) Token: 0x06010297 RID: 66199 RVA: 0x0043A948 File Offset: 0x00438B48
			// (set) Token: 0x06010298 RID: 66200 RVA: 0x0043A958 File Offset: 0x00438B58
			public Image m_playerHeroEquipments3
			{
				get
				{
					return this.m_owner.m_playerHeroEquipments3;
				}
				set
				{
					this.m_owner.m_playerHeroEquipments3 = value;
				}
			}

			// Token: 0x170031B8 RID: 12728
			// (get) Token: 0x06010299 RID: 66201 RVA: 0x0043A968 File Offset: 0x00438B68
			// (set) Token: 0x0601029A RID: 66202 RVA: 0x0043A978 File Offset: 0x00438B78
			public Image m_playerHeroEquipments4
			{
				get
				{
					return this.m_owner.m_playerHeroEquipments4;
				}
				set
				{
					this.m_owner.m_playerHeroEquipments4 = value;
				}
			}

			// Token: 0x170031B9 RID: 12729
			// (get) Token: 0x0601029B RID: 66203 RVA: 0x0043A988 File Offset: 0x00438B88
			// (set) Token: 0x0601029C RID: 66204 RVA: 0x0043A998 File Offset: 0x00438B98
			public Image m_playerHeroTalentIcon
			{
				get
				{
					return this.m_owner.m_playerHeroTalentIcon;
				}
				set
				{
					this.m_owner.m_playerHeroTalentIcon = value;
				}
			}

			// Token: 0x170031BA RID: 12730
			// (get) Token: 0x0601029D RID: 66205 RVA: 0x0043A9A8 File Offset: 0x00438BA8
			// (set) Token: 0x0601029E RID: 66206 RVA: 0x0043A9B8 File Offset: 0x00438BB8
			public Image m_playerHeroSkillIcon1
			{
				get
				{
					return this.m_owner.m_playerHeroSkillIcon1;
				}
				set
				{
					this.m_owner.m_playerHeroSkillIcon1 = value;
				}
			}

			// Token: 0x170031BB RID: 12731
			// (get) Token: 0x0601029F RID: 66207 RVA: 0x0043A9C8 File Offset: 0x00438BC8
			// (set) Token: 0x060102A0 RID: 66208 RVA: 0x0043A9D8 File Offset: 0x00438BD8
			public Image m_playerHeroSkillIcon2
			{
				get
				{
					return this.m_owner.m_playerHeroSkillIcon2;
				}
				set
				{
					this.m_owner.m_playerHeroSkillIcon2 = value;
				}
			}

			// Token: 0x170031BC RID: 12732
			// (get) Token: 0x060102A1 RID: 66209 RVA: 0x0043A9E8 File Offset: 0x00438BE8
			// (set) Token: 0x060102A2 RID: 66210 RVA: 0x0043A9F8 File Offset: 0x00438BF8
			public Image m_playerHeroSkillIcon3
			{
				get
				{
					return this.m_owner.m_playerHeroSkillIcon3;
				}
				set
				{
					this.m_owner.m_playerHeroSkillIcon3 = value;
				}
			}

			// Token: 0x170031BD RID: 12733
			// (get) Token: 0x060102A3 RID: 66211 RVA: 0x0043AA08 File Offset: 0x00438C08
			// (set) Token: 0x060102A4 RID: 66212 RVA: 0x0043AA18 File Offset: 0x00438C18
			public GameObject m_playerHeroSkillDescObj
			{
				get
				{
					return this.m_owner.m_playerHeroSkillDescObj;
				}
				set
				{
					this.m_owner.m_playerHeroSkillDescObj = value;
				}
			}

			// Token: 0x170031BE RID: 12734
			// (get) Token: 0x060102A5 RID: 66213 RVA: 0x0043AA28 File Offset: 0x00438C28
			// (set) Token: 0x060102A6 RID: 66214 RVA: 0x0043AA38 File Offset: 0x00438C38
			public Text m_playerHeroSkillDescNameText
			{
				get
				{
					return this.m_owner.m_playerHeroSkillDescNameText;
				}
				set
				{
					this.m_owner.m_playerHeroSkillDescNameText = value;
				}
			}

			// Token: 0x170031BF RID: 12735
			// (get) Token: 0x060102A7 RID: 66215 RVA: 0x0043AA48 File Offset: 0x00438C48
			// (set) Token: 0x060102A8 RID: 66216 RVA: 0x0043AA58 File Offset: 0x00438C58
			public GameObject m_playerHeroSkillDescCostObj
			{
				get
				{
					return this.m_owner.m_playerHeroSkillDescCostObj;
				}
				set
				{
					this.m_owner.m_playerHeroSkillDescCostObj = value;
				}
			}

			// Token: 0x170031C0 RID: 12736
			// (get) Token: 0x060102A9 RID: 66217 RVA: 0x0043AA68 File Offset: 0x00438C68
			// (set) Token: 0x060102AA RID: 66218 RVA: 0x0043AA78 File Offset: 0x00438C78
			public Text m_playerHeroSkillDescText
			{
				get
				{
					return this.m_owner.m_playerHeroSkillDescText;
				}
				set
				{
					this.m_owner.m_playerHeroSkillDescText = value;
				}
			}

			// Token: 0x170031C1 RID: 12737
			// (get) Token: 0x060102AB RID: 66219 RVA: 0x0043AA88 File Offset: 0x00438C88
			// (set) Token: 0x060102AC RID: 66220 RVA: 0x0043AA98 File Offset: 0x00438C98
			public Text m_playerHeroSkillDescTypeText
			{
				get
				{
					return this.m_owner.m_playerHeroSkillDescTypeText;
				}
				set
				{
					this.m_owner.m_playerHeroSkillDescTypeText = value;
				}
			}

			// Token: 0x170031C2 RID: 12738
			// (get) Token: 0x060102AD RID: 66221 RVA: 0x0043AAA8 File Offset: 0x00438CA8
			// (set) Token: 0x060102AE RID: 66222 RVA: 0x0043AAB8 File Offset: 0x00438CB8
			public Text m_playerHeroSkillDescCDText
			{
				get
				{
					return this.m_owner.m_playerHeroSkillDescCDText;
				}
				set
				{
					this.m_owner.m_playerHeroSkillDescCDText = value;
				}
			}

			// Token: 0x170031C3 RID: 12739
			// (get) Token: 0x060102AF RID: 66223 RVA: 0x0043AAC8 File Offset: 0x00438CC8
			// (set) Token: 0x060102B0 RID: 66224 RVA: 0x0043AAD8 File Offset: 0x00438CD8
			public Text m_playerHeroSkillDescDistanceText
			{
				get
				{
					return this.m_owner.m_playerHeroSkillDescDistanceText;
				}
				set
				{
					this.m_owner.m_playerHeroSkillDescDistanceText = value;
				}
			}

			// Token: 0x170031C4 RID: 12740
			// (get) Token: 0x060102B1 RID: 66225 RVA: 0x0043AAE8 File Offset: 0x00438CE8
			// (set) Token: 0x060102B2 RID: 66226 RVA: 0x0043AAF8 File Offset: 0x00438CF8
			public Text m_playerHeroSkillDescRangeText
			{
				get
				{
					return this.m_owner.m_playerHeroSkillDescRangeText;
				}
				set
				{
					this.m_owner.m_playerHeroSkillDescRangeText = value;
				}
			}

			// Token: 0x170031C5 RID: 12741
			// (get) Token: 0x060102B3 RID: 66227 RVA: 0x0043AB08 File Offset: 0x00438D08
			// (set) Token: 0x060102B4 RID: 66228 RVA: 0x0043AB18 File Offset: 0x00438D18
			public GameObject m_soldierGraphicObj
			{
				get
				{
					return this.m_owner.m_soldierGraphicObj;
				}
				set
				{
					this.m_owner.m_soldierGraphicObj = value;
				}
			}

			// Token: 0x170031C6 RID: 12742
			// (get) Token: 0x060102B5 RID: 66229 RVA: 0x0043AB28 File Offset: 0x00438D28
			// (set) Token: 0x060102B6 RID: 66230 RVA: 0x0043AB38 File Offset: 0x00438D38
			public Text m_soldierHPValueText
			{
				get
				{
					return this.m_owner.m_soldierHPValueText;
				}
				set
				{
					this.m_owner.m_soldierHPValueText = value;
				}
			}

			// Token: 0x170031C7 RID: 12743
			// (get) Token: 0x060102B7 RID: 66231 RVA: 0x0043AB48 File Offset: 0x00438D48
			// (set) Token: 0x060102B8 RID: 66232 RVA: 0x0043AB58 File Offset: 0x00438D58
			public Text m_soldierATValueText
			{
				get
				{
					return this.m_owner.m_soldierATValueText;
				}
				set
				{
					this.m_owner.m_soldierATValueText = value;
				}
			}

			// Token: 0x170031C8 RID: 12744
			// (get) Token: 0x060102B9 RID: 66233 RVA: 0x0043AB68 File Offset: 0x00438D68
			// (set) Token: 0x060102BA RID: 66234 RVA: 0x0043AB78 File Offset: 0x00438D78
			public Text m_soldierDFValueText
			{
				get
				{
					return this.m_owner.m_soldierDFValueText;
				}
				set
				{
					this.m_owner.m_soldierDFValueText = value;
				}
			}

			// Token: 0x170031C9 RID: 12745
			// (get) Token: 0x060102BB RID: 66235 RVA: 0x0043AB88 File Offset: 0x00438D88
			// (set) Token: 0x060102BC RID: 66236 RVA: 0x0043AB98 File Offset: 0x00438D98
			public Text m_soldierMagicDFValueText
			{
				get
				{
					return this.m_owner.m_soldierMagicDFValueText;
				}
				set
				{
					this.m_owner.m_soldierMagicDFValueText = value;
				}
			}

			// Token: 0x170031CA RID: 12746
			// (get) Token: 0x060102BD RID: 66237 RVA: 0x0043ABA8 File Offset: 0x00438DA8
			// (set) Token: 0x060102BE RID: 66238 RVA: 0x0043ABB8 File Offset: 0x00438DB8
			public Text m_soldierHPAddText
			{
				get
				{
					return this.m_owner.m_soldierHPAddText;
				}
				set
				{
					this.m_owner.m_soldierHPAddText = value;
				}
			}

			// Token: 0x170031CB RID: 12747
			// (get) Token: 0x060102BF RID: 66239 RVA: 0x0043ABC8 File Offset: 0x00438DC8
			// (set) Token: 0x060102C0 RID: 66240 RVA: 0x0043ABD8 File Offset: 0x00438DD8
			public Text m_soldierATAddText
			{
				get
				{
					return this.m_owner.m_soldierATAddText;
				}
				set
				{
					this.m_owner.m_soldierATAddText = value;
				}
			}

			// Token: 0x170031CC RID: 12748
			// (get) Token: 0x060102C1 RID: 66241 RVA: 0x0043ABE8 File Offset: 0x00438DE8
			// (set) Token: 0x060102C2 RID: 66242 RVA: 0x0043ABF8 File Offset: 0x00438DF8
			public Text m_soldierDFAddText
			{
				get
				{
					return this.m_owner.m_soldierDFAddText;
				}
				set
				{
					this.m_owner.m_soldierDFAddText = value;
				}
			}

			// Token: 0x170031CD RID: 12749
			// (get) Token: 0x060102C3 RID: 66243 RVA: 0x0043AC08 File Offset: 0x00438E08
			// (set) Token: 0x060102C4 RID: 66244 RVA: 0x0043AC18 File Offset: 0x00438E18
			public Text m_soldierMagicDFAddText
			{
				get
				{
					return this.m_owner.m_soldierMagicDFAddText;
				}
				set
				{
					this.m_owner.m_soldierMagicDFAddText = value;
				}
			}

			// Token: 0x170031CE RID: 12750
			// (get) Token: 0x060102C5 RID: 66245 RVA: 0x0043AC28 File Offset: 0x00438E28
			// (set) Token: 0x060102C6 RID: 66246 RVA: 0x0043AC38 File Offset: 0x00438E38
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

			// Token: 0x170031CF RID: 12751
			// (get) Token: 0x060102C7 RID: 66247 RVA: 0x0043AC48 File Offset: 0x00438E48
			// (set) Token: 0x060102C8 RID: 66248 RVA: 0x0043AC58 File Offset: 0x00438E58
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

			// Token: 0x170031D0 RID: 12752
			// (get) Token: 0x060102C9 RID: 66249 RVA: 0x0043AC68 File Offset: 0x00438E68
			// (set) Token: 0x060102CA RID: 66250 RVA: 0x0043AC78 File Offset: 0x00438E78
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

			// Token: 0x170031D1 RID: 12753
			// (get) Token: 0x060102CB RID: 66251 RVA: 0x0043AC88 File Offset: 0x00438E88
			// (set) Token: 0x060102CC RID: 66252 RVA: 0x0043AC98 File Offset: 0x00438E98
			public UISpineGraphic m_soldierInfoGraphic
			{
				get
				{
					return this.m_owner.m_soldierInfoGraphic;
				}
				set
				{
					this.m_owner.m_soldierInfoGraphic = value;
				}
			}

			// Token: 0x170031D2 RID: 12754
			// (get) Token: 0x060102CD RID: 66253 RVA: 0x0043ACA8 File Offset: 0x00438EA8
			// (set) Token: 0x060102CE RID: 66254 RVA: 0x0043ACB8 File Offset: 0x00438EB8
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

			// Token: 0x170031D3 RID: 12755
			// (get) Token: 0x060102CF RID: 66255 RVA: 0x0043ACC8 File Offset: 0x00438EC8
			// (set) Token: 0x060102D0 RID: 66256 RVA: 0x0043ACD8 File Offset: 0x00438ED8
			public HeroCommentUIController.ToggleState m_curToggleState
			{
				get
				{
					return this.m_owner.m_curToggleState;
				}
				set
				{
					this.m_owner.m_curToggleState = value;
				}
			}

			// Token: 0x170031D4 RID: 12756
			// (get) Token: 0x060102D1 RID: 66257 RVA: 0x0043ACE8 File Offset: 0x00438EE8
			// (set) Token: 0x060102D2 RID: 66258 RVA: 0x0043ACF8 File Offset: 0x00438EF8
			public int m_curShowedNormalCommentCount
			{
				get
				{
					return this.m_owner.m_curShowedNormalCommentCount;
				}
				set
				{
					this.m_owner.m_curShowedNormalCommentCount = value;
				}
			}

			// Token: 0x060102D3 RID: 66259 RVA: 0x0043AD08 File Offset: 0x00438F08
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060102D4 RID: 66260 RVA: 0x0043AD18 File Offset: 0x00438F18
			public void CreateComments()
			{
				this.m_owner.CreateComments();
			}

			// Token: 0x060102D5 RID: 66261 RVA: 0x0043AD28 File Offset: 0x00438F28
			public List<HeroCommentEntry> GetNormalCommentsInAllComments(List<HeroCommentEntry> allComments, List<HeroCommentEntry> hotComments, int needShowedCount)
			{
				return this.m_owner.GetNormalCommentsInAllComments(allComments, hotComments, needShowedCount);
			}

			// Token: 0x060102D6 RID: 66262 RVA: 0x0043AD38 File Offset: 0x00438F38
			public int CommentComparerByTime(HeroCommentEntry c1, HeroCommentEntry c2)
			{
				return this.m_owner.CommentComparerByTime(c1, c2);
			}

			// Token: 0x060102D7 RID: 66263 RVA: 0x0043AD48 File Offset: 0x00438F48
			public int CommentComparerByPraisedNum(HeroCommentEntry c1, HeroCommentEntry c2)
			{
				return this.m_owner.CommentComparerByPraisedNum(c1, c2);
			}

			// Token: 0x060102D8 RID: 66264 RVA: 0x0043AD58 File Offset: 0x00438F58
			public List<HeroCommentEntry> GetCommentsWithCount(List<HeroCommentEntry> commentList, int count)
			{
				return this.m_owner.GetCommentsWithCount(commentList, count);
			}

			// Token: 0x060102D9 RID: 66265 RVA: 0x0043AD68 File Offset: 0x00438F68
			public void CreateCommentByList(List<HeroCommentEntry> commentList, GameObject content, bool isShowPraisedIcon)
			{
				this.m_owner.CreateCommentByList(commentList, content, isShowPraisedIcon);
			}

			// Token: 0x060102DA RID: 66266 RVA: 0x0043AD78 File Offset: 0x00438F78
			public void OnSkillItemClick(ConfigDataSkillInfo skillInfo)
			{
				this.m_owner.OnSkillItemClick(skillInfo);
			}

			// Token: 0x060102DB RID: 66267 RVA: 0x0043AD88 File Offset: 0x00438F88
			public void SetSkillDescPanel(ConfigDataSkillInfo skillInfo)
			{
				this.m_owner.SetSkillDescPanel(skillInfo);
			}

			// Token: 0x060102DC RID: 66268 RVA: 0x0043AD98 File Offset: 0x00438F98
			public void SetSoldierPropAddText(int oldValue, int newValue, Text txt)
			{
				this.m_owner.SetSoldierPropAddText(oldValue, newValue, txt);
			}

			// Token: 0x060102DD RID: 66269 RVA: 0x0043ADA8 File Offset: 0x00438FA8
			public void ClosePlayerHeroDetailPanel()
			{
				this.m_owner.ClosePlayerHeroDetailPanel();
			}

			// Token: 0x060102DE RID: 66270 RVA: 0x0043ADB8 File Offset: 0x00438FB8
			public void OnCommentItemNameClick(HeroCommentEntry comment)
			{
				this.m_owner.OnCommentItemNameClick(comment);
			}

			// Token: 0x060102DF RID: 66271 RVA: 0x0043ADC8 File Offset: 0x00438FC8
			public void OnCommentItemPraisedBtnClick(ulong instanceId)
			{
				this.m_owner.OnCommentItemPraisedBtnClick(instanceId);
			}

			// Token: 0x060102E0 RID: 66272 RVA: 0x0043ADD8 File Offset: 0x00438FD8
			public void OnMoreCommentButtonClick()
			{
				this.m_owner.OnMoreCommentButtonClick();
			}

			// Token: 0x060102E1 RID: 66273 RVA: 0x0043ADE8 File Offset: 0x00438FE8
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x060102E2 RID: 66274 RVA: 0x0043ADF8 File Offset: 0x00438FF8
			public void OnAllCommentToggleClick(bool isOn)
			{
				this.m_owner.OnAllCommentToggleClick(isOn);
			}

			// Token: 0x060102E3 RID: 66275 RVA: 0x0043AE08 File Offset: 0x00439008
			public void OnHotCommentToggleClick(bool isOn)
			{
				this.m_owner.OnHotCommentToggleClick(isOn);
			}

			// Token: 0x060102E4 RID: 66276 RVA: 0x0043AE18 File Offset: 0x00439018
			public void OnRankingListCommentToggleClick(bool isOn)
			{
				this.m_owner.OnRankingListCommentToggleClick(isOn);
			}

			// Token: 0x060102E5 RID: 66277 RVA: 0x0043AE28 File Offset: 0x00439028
			public void OnRankingListLockButtonClick()
			{
				this.m_owner.OnRankingListLockButtonClick();
			}

			// Token: 0x060102E6 RID: 66278 RVA: 0x0043AE38 File Offset: 0x00439038
			public void OnCommentSendButtonClick()
			{
				this.m_owner.OnCommentSendButtonClick();
			}

			// Token: 0x060102E7 RID: 66279 RVA: 0x0043AE48 File Offset: 0x00439048
			public void CreateSpineGraphic(ref UISpineGraphic graphic, string assetName, GameObject parent, int direction, Vector2 offset, float scale, List<ReplaceAnim> anims)
			{
				this.m_owner.CreateSpineGraphic(ref graphic, assetName, parent, direction, offset, scale, anims);
			}

			// Token: 0x060102E8 RID: 66280 RVA: 0x0043AE60 File Offset: 0x00439060
			public void DestroySpineGraphic(ref UISpineGraphic g)
			{
				this.m_owner.DestroySpineGraphic(ref g);
			}

			// Token: 0x060102E9 RID: 66281 RVA: 0x0043AE70 File Offset: 0x00439070
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x040096CF RID: 38607
			private HeroCommentUIController m_owner;
		}
	}
}
