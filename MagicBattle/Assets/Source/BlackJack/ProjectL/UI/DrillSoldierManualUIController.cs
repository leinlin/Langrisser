using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C3D RID: 3133
	[HotFix]
	public class DrillSoldierManualUIController : UIControllerBase
	{
		// Token: 0x0600DC23 RID: 56355 RVA: 0x003BA6C8 File Offset: 0x003B88C8
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
			this.m_pagePrevButton.onClick.AddListener(new UnityAction(this.OnPagePrevButtonClick));
			this.m_pageNextButton.onClick.AddListener(new UnityAction(this.OnPageNextButtonClick));
			this.m_allRankToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnAllRankToggleValueChanged));
			this.m_rank1Toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRank1ToggleValueChanged));
			this.m_rank2Toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRank2ToggleValueChanged));
			this.m_rank3Toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRank3ToggleValueChanged));
			this.m_sortButton.onClick.AddListener(new UnityAction(this.OnSortButtonClick));
			this.m_sortTypesReturnBgImage.onClick.AddListener(new UnityAction(this.CloseSortTypesPanel));
			this.m_getSoldierNoticGoToButton.onClick.AddListener(new UnityAction(this.OnGetSoldierNoticGoToButtonClick));
			this.AddListenerToSortToggles();
			this.m_soldierSkillToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSoldierSkillToggleValueChanged));
			this.m_soldierDescToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSoldierDescToggleValueChanged));
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x0600DC24 RID: 56356 RVA: 0x003BA89C File Offset: 0x003B8A9C
		private void AddListenerToSortToggles()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddListenerToSortToggles_hotfix != null)
			{
				this.m_AddListenerToSortToggles_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Transform trans = this.m_sortTypesGridLayout.transform;
			for (int i = 0; i < trans.childCount; i++)
			{
				GameObject item = trans.GetChild(i).gameObject;
				Toggle component = item.GetComponent<Toggle>();
				component.onValueChanged.AddListener(delegate(bool isOn)
				{
					if (isOn)
					{
						for (int j = 0; j < trans.childCount; j++)
						{
							GameObject gameObject = trans.GetChild(j).gameObject;
							if (gameObject.name == item.name)
							{
								this.m_curArmyTag = (ArmyTag)int.Parse(item.name);
							}
						}
						this.m_sortButtonTypeText.text = item.transform.GetChild(1).GetComponent<Text>().text;
						this.m_curPage = 0;
						this.m_curSoldierInfoCtrl = null;
						if (this.EventOnNeedUpdateView != null)
						{
							this.EventOnNeedUpdateView(this.m_curPage, this.m_curRank, this.m_curArmyTag);
						}
						this.CloseSortTypesPanel();
					}
				});
			}
		}

		// Token: 0x0600DC25 RID: 56357 RVA: 0x003BA980 File Offset: 0x003B8B80
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
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateOpen(component, "Show", null, false, true);
		}

		// Token: 0x0600DC26 RID: 56358 RVA: 0x003BA9FC File Offset: 0x003B8BFC
		public void UpdateViewInDrillSoliderManual(List<ConfigDataSoldierInfo> soldierList, int totalPageCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInDrillSoliderManualList`1Int32_hotfix != null)
			{
				this.m_UpdateViewInDrillSoliderManualList`1Int32_hotfix.call(new object[]
				{
					this,
					soldierList,
					totalPageCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isFirstIn)
			{
				this.Open();
				this.m_isFirstIn = false;
			}
			this.m_soldierInfoList.Clear();
			this.m_soldierInfoList.AddRange(soldierList);
			this.m_totalPageCount = totalPageCount;
			if (this.m_pageButtonGroup.transform.childCount < this.m_totalPageCount)
			{
				int num = this.m_totalPageCount - this.m_pageButtonGroup.transform.childCount;
				Transform child = this.m_pageButtonGroup.transform.GetChild(0);
				for (int i = 0; i < num; i++)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(child.gameObject);
					gameObject.transform.SetParent(this.m_pageButtonGroup.transform, false);
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_pageButtonGroup, this.m_totalPageCount);
			for (int j = 0; j < this.m_totalPageCount; j++)
			{
				Transform child2 = this.m_pageButtonGroup.transform.GetChild(j);
				CommonUIStateController component = child2.GetComponent<CommonUIStateController>();
				if (j == this.m_curPage)
				{
					component.SetToUIState("Light", false, true);
				}
				else
				{
					component.SetToUIState("Dark", false, true);
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_soldierListContent, this.m_soldierInfoList.Count);
			this.m_soliderItemListCtrl.Clear();
			Transform transform = this.m_soldierListContent.transform;
			for (int k = 0; k < this.m_soldierInfoList.Count; k++)
			{
				SoldierManualItemUIController component2;
				if (k < transform.childCount)
				{
					GameObject gameObject2 = transform.GetChild(k).gameObject;
					component2 = gameObject2.GetComponent<SoldierManualItemUIController>();
				}
				else
				{
					GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.m_soldierItemPrefab);
					PrefabControllerCreater.CreateAllControllers(gameObject3);
					component2 = gameObject3.GetComponent<SoldierManualItemUIController>();
					component2.EventOnSoldierItemClick += this.OnSoldierItemClick;
					gameObject3.transform.SetParent(this.m_soldierListContent.transform, false);
				}
				component2.InitSoldierItem(this.m_soldierInfoList[k]);
				this.m_soliderItemListCtrl.Add(component2);
				component2.SetClickImageActive(false);
			}
			if (this.m_curSoldierInfoCtrl != null && !this.m_soliderItemListCtrl.Contains(this.m_curSoldierInfoCtrl))
			{
				this.m_curSoldierInfoCtrl = this.m_soliderItemListCtrl.Find((SoldierManualItemUIController c) => c.SoldierInfo == this.m_curSoldierInfoCtrl.SoldierInfo);
			}
			if (this.m_curSoldierInfoCtrl == null)
			{
				if (this.m_soliderItemListCtrl.Count > 0)
				{
					this.m_curSoldierInfoCtrl = this.m_soliderItemListCtrl[0];
					this.m_curSoldierInfoCtrl.SetClickImageActive(true);
					this.m_soldierSkillToggle.isOn = true;
				}
			}
			else
			{
				this.m_curSoldierInfoCtrl.SetClickImageActive(true);
				this.m_soldierSkillToggle.isOn = true;
			}
			if (this.m_curSoldierInfoCtrl != null)
			{
				this.SetSoldierInfoDetailPanel(this.m_curSoldierInfoCtrl.SoldierInfo);
			}
		}

		// Token: 0x0600DC27 RID: 56359 RVA: 0x003BAD64 File Offset: 0x003B8F64
		private void OnSoldierItemClick(SoldierManualItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierItemClickSoldierManualItemUIController_hotfix != null)
			{
				this.m_OnSoldierItemClickSoldierManualItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curSoldierInfoCtrl != null)
			{
				this.m_curSoldierInfoCtrl.SetClickImageActive(false);
			}
			this.m_curSoldierInfoCtrl = ctrl;
			this.m_curSoldierInfoCtrl.SetClickImageActive(true);
			this.m_soldierSkillToggle.isOn = true;
			this.SetSoldierInfoDetailPanel(this.m_curSoldierInfoCtrl.SoldierInfo);
		}

		// Token: 0x0600DC28 RID: 56360 RVA: 0x003BAE24 File Offset: 0x003B9024
		private void SetSoldierInfoDetailPanel(ConfigDataSoldierInfo soldierInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierInfoDetailPanelConfigDataSoldierInfo_hotfix != null)
			{
				this.m_SetSoldierInfoDetailPanelConfigDataSoldierInfo_hotfix.call(new object[]
				{
					this,
					soldierInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (soldierInfo == null)
			{
				return;
			}
			this.m_soldierTypeIcon.sprite = AssetUtility.Instance.GetSprite(soldierInfo.m_armyInfo.Icon);
			this.m_soldierQualityIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetSoldierRankImage(soldierInfo.Rank));
			this.m_soldierNameText.text = soldierInfo.Name;
			this.m_soldierPropHpValueText.text = soldierInfo.HP_INI.ToString();
			this.m_soldierPropATValueText.text = soldierInfo.AT_INI.ToString();
			this.m_soldierPropDFValueText.text = soldierInfo.DF_INI.ToString();
			this.m_soldierPropMagicDFValueText.text = soldierInfo.MagicDF_INI.ToString();
			this.m_soldierPropRangeValueText.text = soldierInfo.BF_AttackDistance.ToString();
			this.m_soldierPropMoveValueText.text = soldierInfo.BF_MovePoint.ToString();
			this.m_soldierPropRestrainValueText.text = soldierInfo.Strong;
			this.m_soldierPropWeakValueText.text = soldierInfo.Weak;
			if (this.m_soldierSkillToggle.isOn)
			{
				this.m_soldierDescText.text = UIUtility.GetSoldierCurSkillDesc(soldierInfo);
			}
			else
			{
				this.m_soldierDescText.text = soldierInfo.Desc;
			}
			if (soldierInfo.IsMelee)
			{
				this.m_soldierPropTypeStateCtrl.SetToUIState("Melee", false, true);
			}
			else
			{
				this.m_soldierPropTypeStateCtrl.SetToUIState("NotMelee", false, true);
			}
			float scale = (float)soldierInfo.UI_ModelScale * 0.02f;
			Vector2 offset = new Vector2((float)soldierInfo.UI_ModelOffsetX, (float)soldierInfo.UI_ModelOffsetY) * 1.5f;
			HeroDetailUIController.CreateSpineGraphic(ref this.m_soldierInfoGraphic, soldierInfo.Model, this.m_soldierGraphic, 1, offset, scale, soldierInfo.ReplaceAnims);
			bool flag = this.m_playerContext.IsExistSoliderId(soldierInfo.ID);
			this.m_getSoldierNoticText.text = soldierInfo.GetSoldierDesc;
			this.m_getSoldierNoticGoToButton.gameObject.SetActive(soldierInfo.GetSoldierTechId != 0);
			this.m_getSoldierNotic.SetActive(!flag);
			if (!flag)
			{
				this.m_soldierInfoGraphic.SetColor(UIUtility.MyGrayColor);
			}
		}

		// Token: 0x0600DC29 RID: 56361 RVA: 0x003BB0EC File Offset: 0x003B92EC
		private void OnPageNextButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPageNextButtonClick_hotfix != null)
			{
				this.m_OnPageNextButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curPage + 1 > this.m_totalPageCount - 1)
			{
				return;
			}
			this.m_curPage++;
			this.m_curSoldierInfoCtrl = null;
			if (this.EventOnNeedUpdateView != null)
			{
				this.EventOnNeedUpdateView(this.m_curPage, this.m_curRank, this.m_curArmyTag);
			}
		}

		// Token: 0x0600DC2A RID: 56362 RVA: 0x003BB1A0 File Offset: 0x003B93A0
		private void OnPagePrevButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPagePrevButtonClick_hotfix != null)
			{
				this.m_OnPagePrevButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curPage - 1 < 0)
			{
				return;
			}
			this.m_curPage--;
			this.m_curSoldierInfoCtrl = null;
			if (this.EventOnNeedUpdateView != null)
			{
				this.EventOnNeedUpdateView(this.m_curPage, this.m_curRank, this.m_curArmyTag);
			}
		}

		// Token: 0x0600DC2B RID: 56363 RVA: 0x003BB24C File Offset: 0x003B944C
		private void OnAllRankToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAllRankToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnAllRankToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curPage = 0;
				this.m_curRank = 0;
				this.m_curSoldierInfoCtrl = null;
				if (this.EventOnNeedUpdateView != null)
				{
					this.EventOnNeedUpdateView(this.m_curPage, this.m_curRank, this.m_curArmyTag);
				}
			}
		}

		// Token: 0x0600DC2C RID: 56364 RVA: 0x003BB300 File Offset: 0x003B9500
		private void OnRank1ToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRank1ToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnRank1ToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curPage = 0;
				this.m_curRank = 1;
				this.m_curSoldierInfoCtrl = null;
				if (this.EventOnNeedUpdateView != null)
				{
					this.EventOnNeedUpdateView(this.m_curPage, this.m_curRank, this.m_curArmyTag);
				}
			}
		}

		// Token: 0x0600DC2D RID: 56365 RVA: 0x003BB3B4 File Offset: 0x003B95B4
		private void OnRank2ToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRank2ToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnRank2ToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curPage = 0;
				this.m_curRank = 2;
				this.m_curSoldierInfoCtrl = null;
				if (this.EventOnNeedUpdateView != null)
				{
					this.EventOnNeedUpdateView(this.m_curPage, this.m_curRank, this.m_curArmyTag);
				}
			}
		}

		// Token: 0x0600DC2E RID: 56366 RVA: 0x003BB468 File Offset: 0x003B9668
		private void OnRank3ToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRank3ToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnRank3ToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curPage = 0;
				this.m_curRank = 3;
				this.m_curSoldierInfoCtrl = null;
				if (this.EventOnNeedUpdateView != null)
				{
					this.EventOnNeedUpdateView(this.m_curPage, this.m_curRank, this.m_curArmyTag);
				}
			}
		}

		// Token: 0x0600DC2F RID: 56367 RVA: 0x003BB51C File Offset: 0x003B971C
		private void OnSoldierSkillToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierSkillToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSoldierSkillToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_soldierDescText.text = UIUtility.GetSoldierCurSkillDesc(this.m_curSoldierInfoCtrl.SoldierInfo);
			}
		}

		// Token: 0x0600DC30 RID: 56368 RVA: 0x003BB5B0 File Offset: 0x003B97B0
		private void OnSoldierDescToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierDescToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSoldierDescToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_soldierDescText.text = this.m_curSoldierInfoCtrl.SoldierInfo.Desc;
			}
		}

		// Token: 0x0600DC31 RID: 56369 RVA: 0x003BB644 File Offset: 0x003B9844
		private void OnGetSoldierNoticGoToButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetSoldierNoticGoToButtonClick_hotfix != null)
			{
				this.m_OnGetSoldierNoticGoToButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curSoldierInfoCtrl == null)
			{
				return;
			}
			int getSoldierTechId = this.m_curSoldierInfoCtrl.SoldierInfo.GetSoldierTechId;
			if (!this.m_playerContext.CanGoToGetSoldierTech(getSoldierTechId))
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_DrillNotOpen, 2f, null, true);
				return;
			}
			if (this.EventOnGoToTraingTech != null)
			{
				this.EventOnGoToTraingTech(getSoldierTechId);
			}
		}

		// Token: 0x0600DC32 RID: 56370 RVA: 0x003BB708 File Offset: 0x003B9908
		private void OnSortButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSortButtonClick_hotfix != null)
			{
				this.m_OnSortButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sortTypes.SetActive(true);
			CommonUIStateController component = this.m_sortTypes.GetComponent<CommonUIStateController>();
			component.SetToUIState("Show", false, true);
		}

		// Token: 0x0600DC33 RID: 56371 RVA: 0x003BB790 File Offset: 0x003B9990
		private void CloseSortTypesPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseSortTypesPanel_hotfix != null)
			{
				this.m_CloseSortTypesPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_sortTypes.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_sortTypes.SetActive(false);
			});
			component.SetToUIState("Close", false, true);
		}

		// Token: 0x0600DC34 RID: 56372 RVA: 0x003BB824 File Offset: 0x003B9A24
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
		}

		// Token: 0x0600DC35 RID: 56373 RVA: 0x003BB89C File Offset: 0x003B9A9C
		public void ResetData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetData_hotfix != null)
			{
				this.m_ResetData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curPage = 0;
			this.m_curRank = 0;
			this.m_curArmyTag = ArmyTag.ArmyTag_None;
			this.m_allRankToggle.isOn = true;
			this.m_curSoldierInfoCtrl = null;
			this.m_isFirstIn = true;
			Transform transform = this.m_sortTypesGridLayout.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				Toggle component = transform.GetChild(i).GetComponent<Toggle>();
				if (component != null)
				{
					component.isOn = (i == 0);
				}
			}
		}

		// Token: 0x140002B9 RID: 697
		// (add) Token: 0x0600DC36 RID: 56374 RVA: 0x003BB974 File Offset: 0x003B9B74
		// (remove) Token: 0x0600DC37 RID: 56375 RVA: 0x003BBA10 File Offset: 0x003B9C10
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

		// Token: 0x140002BA RID: 698
		// (add) Token: 0x0600DC38 RID: 56376 RVA: 0x003BBAAC File Offset: 0x003B9CAC
		// (remove) Token: 0x0600DC39 RID: 56377 RVA: 0x003BBB48 File Offset: 0x003B9D48
		public event Action<int, int, ArmyTag> EventOnNeedUpdateView
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNeedUpdateViewAction`3_hotfix != null)
				{
					this.m_add_EventOnNeedUpdateViewAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, ArmyTag> action = this.EventOnNeedUpdateView;
				Action<int, int, ArmyTag> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, ArmyTag>>(ref this.EventOnNeedUpdateView, (Action<int, int, ArmyTag>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNeedUpdateViewAction`3_hotfix != null)
				{
					this.m_remove_EventOnNeedUpdateViewAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, ArmyTag> action = this.EventOnNeedUpdateView;
				Action<int, int, ArmyTag> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, ArmyTag>>(ref this.EventOnNeedUpdateView, (Action<int, int, ArmyTag>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002BB RID: 699
		// (add) Token: 0x0600DC3A RID: 56378 RVA: 0x003BBBE4 File Offset: 0x003B9DE4
		// (remove) Token: 0x0600DC3B RID: 56379 RVA: 0x003BBC80 File Offset: 0x003B9E80
		public event Action<int> EventOnGoToTraingTech
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoToTraingTechAction`1_hotfix != null)
				{
					this.m_add_EventOnGoToTraingTechAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGoToTraingTech;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGoToTraingTech, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoToTraingTechAction`1_hotfix != null)
				{
					this.m_remove_EventOnGoToTraingTechAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGoToTraingTech;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGoToTraingTech, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x0600DC3C RID: 56380 RVA: 0x003BBD1C File Offset: 0x003B9F1C
		// (set) Token: 0x0600DC3D RID: 56381 RVA: 0x003BBD3C File Offset: 0x003B9F3C
		[DoNotToLua]
		public new DrillSoldierManualUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DrillSoldierManualUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DC3E RID: 56382 RVA: 0x003BBD48 File Offset: 0x003B9F48
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600DC3F RID: 56383 RVA: 0x003BBD54 File Offset: 0x003B9F54
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600DC40 RID: 56384 RVA: 0x003BBD5C File Offset: 0x003B9F5C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600DC41 RID: 56385 RVA: 0x003BBD64 File Offset: 0x003B9F64
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600DC42 RID: 56386 RVA: 0x003BBD78 File Offset: 0x003B9F78
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DC43 RID: 56387 RVA: 0x003BBD80 File Offset: 0x003B9F80
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600DC44 RID: 56388 RVA: 0x003BBD8C File Offset: 0x003B9F8C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600DC45 RID: 56389 RVA: 0x003BBD98 File Offset: 0x003B9F98
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600DC46 RID: 56390 RVA: 0x003BBDA4 File Offset: 0x003B9FA4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600DC47 RID: 56391 RVA: 0x003BBDB0 File Offset: 0x003B9FB0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600DC48 RID: 56392 RVA: 0x003BBDBC File Offset: 0x003B9FBC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600DC49 RID: 56393 RVA: 0x003BBDC8 File Offset: 0x003B9FC8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600DC4A RID: 56394 RVA: 0x003BBDD4 File Offset: 0x003B9FD4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600DC4B RID: 56395 RVA: 0x003BBDE0 File Offset: 0x003B9FE0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600DC4C RID: 56396 RVA: 0x003BBDEC File Offset: 0x003B9FEC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600DC4D RID: 56397 RVA: 0x003BBDF4 File Offset: 0x003B9FF4
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600DC4E RID: 56398 RVA: 0x003BBE14 File Offset: 0x003BA014
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600DC4F RID: 56399 RVA: 0x003BBE20 File Offset: 0x003BA020
		private void __callDele_EventOnNeedUpdateView(int arg1, int arg2, ArmyTag arg3)
		{
			Action<int, int, ArmyTag> eventOnNeedUpdateView = this.EventOnNeedUpdateView;
			if (eventOnNeedUpdateView != null)
			{
				eventOnNeedUpdateView(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600DC50 RID: 56400 RVA: 0x003BBE44 File Offset: 0x003BA044
		private void __clearDele_EventOnNeedUpdateView(int arg1, int arg2, ArmyTag arg3)
		{
			this.EventOnNeedUpdateView = null;
		}

		// Token: 0x0600DC51 RID: 56401 RVA: 0x003BBE50 File Offset: 0x003BA050
		private void __callDele_EventOnGoToTraingTech(int obj)
		{
			Action<int> eventOnGoToTraingTech = this.EventOnGoToTraingTech;
			if (eventOnGoToTraingTech != null)
			{
				eventOnGoToTraingTech(obj);
			}
		}

		// Token: 0x0600DC52 RID: 56402 RVA: 0x003BBE74 File Offset: 0x003BA074
		private void __clearDele_EventOnGoToTraingTech(int obj)
		{
			this.EventOnGoToTraingTech = null;
		}

		// Token: 0x0600DC55 RID: 56405 RVA: 0x003BBEA8 File Offset: 0x003BA0A8
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
					this.m_AddListenerToSortToggles_hotfix = (luaObj.RawGet("AddListenerToSortToggles") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_UpdateViewInDrillSoliderManualList`1Int32_hotfix = (luaObj.RawGet("UpdateViewInDrillSoliderManual") as LuaFunction);
					this.m_OnSoldierItemClickSoldierManualItemUIController_hotfix = (luaObj.RawGet("OnSoldierItemClick") as LuaFunction);
					this.m_SetSoldierInfoDetailPanelConfigDataSoldierInfo_hotfix = (luaObj.RawGet("SetSoldierInfoDetailPanel") as LuaFunction);
					this.m_OnPageNextButtonClick_hotfix = (luaObj.RawGet("OnPageNextButtonClick") as LuaFunction);
					this.m_OnPagePrevButtonClick_hotfix = (luaObj.RawGet("OnPagePrevButtonClick") as LuaFunction);
					this.m_OnAllRankToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnAllRankToggleValueChanged") as LuaFunction);
					this.m_OnRank1ToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnRank1ToggleValueChanged") as LuaFunction);
					this.m_OnRank2ToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnRank2ToggleValueChanged") as LuaFunction);
					this.m_OnRank3ToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnRank3ToggleValueChanged") as LuaFunction);
					this.m_OnSoldierSkillToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSoldierSkillToggleValueChanged") as LuaFunction);
					this.m_OnSoldierDescToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSoldierDescToggleValueChanged") as LuaFunction);
					this.m_OnGetSoldierNoticGoToButtonClick_hotfix = (luaObj.RawGet("OnGetSoldierNoticGoToButtonClick") as LuaFunction);
					this.m_OnSortButtonClick_hotfix = (luaObj.RawGet("OnSortButtonClick") as LuaFunction);
					this.m_CloseSortTypesPanel_hotfix = (luaObj.RawGet("CloseSortTypesPanel") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_ResetData_hotfix = (luaObj.RawGet("ResetData") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnNeedUpdateViewAction`3_hotfix = (luaObj.RawGet("add_EventOnNeedUpdateView") as LuaFunction);
					this.m_remove_EventOnNeedUpdateViewAction`3_hotfix = (luaObj.RawGet("remove_EventOnNeedUpdateView") as LuaFunction);
					this.m_add_EventOnGoToTraingTechAction`1_hotfix = (luaObj.RawGet("add_EventOnGoToTraingTech") as LuaFunction);
					this.m_remove_EventOnGoToTraingTechAction`1_hotfix = (luaObj.RawGet("remove_EventOnGoToTraingTech") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DC56 RID: 56406 RVA: 0x003BC1CC File Offset: 0x003BA3CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DrillSoldierManualUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040086AA RID: 34474
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x040086AB RID: 34475
		[AutoBind("./SoldierListPanel/PageButtonGroup/PointGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_pageButtonGroup;

		// Token: 0x040086AC RID: 34476
		[AutoBind("./SoldierListPanel/PageButtonGroup/PrevButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_pagePrevButton;

		// Token: 0x040086AD RID: 34477
		[AutoBind("./SoldierListPanel/PageButtonGroup/NextButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_pageNextButton;

		// Token: 0x040086AE RID: 34478
		[AutoBind("./SoldierListPanel/ToggleGroup/AllToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_allRankToggle;

		// Token: 0x040086AF RID: 34479
		[AutoBind("./SoldierListPanel/ToggleGroup/Level1", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_rank1Toggle;

		// Token: 0x040086B0 RID: 34480
		[AutoBind("./SoldierListPanel/ToggleGroup/Level2", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_rank2Toggle;

		// Token: 0x040086B1 RID: 34481
		[AutoBind("./SoldierListPanel/ToggleGroup/Level3", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_rank3Toggle;

		// Token: 0x040086B2 RID: 34482
		[AutoBind("./SoldierListPanel/SoldierList", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierListContent;

		// Token: 0x040086B3 RID: 34483
		[AutoBind("./Prefab/SoldierItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierItemPrefab;

		// Token: 0x040086B4 RID: 34484
		[AutoBind("./SoldierListPanel/SortButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sortButton;

		// Token: 0x040086B5 RID: 34485
		[AutoBind("./SoldierListPanel/SortButton/SortTypeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_sortButtonTypeText;

		// Token: 0x040086B6 RID: 34486
		[AutoBind("./SoldierListPanel/SortTypes", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_sortTypes;

		// Token: 0x040086B7 RID: 34487
		[AutoBind("./SoldierListPanel/SortTypes/ReturnBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sortTypesReturnBgImage;

		// Token: 0x040086B8 RID: 34488
		[AutoBind("./SoldierListPanel/SortTypes/GridLayout", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_sortTypesGridLayout;

		// Token: 0x040086B9 RID: 34489
		[AutoBind("./SoldierInfoPanel/TypeAndQuality/TypeIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierTypeIcon;

		// Token: 0x040086BA RID: 34490
		[AutoBind("./SoldierInfoPanel/TypeAndQuality/QualityIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierQualityIcon;

		// Token: 0x040086BB RID: 34491
		[AutoBind("./SoldierInfoPanel/TypeAndQuality/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierNameText;

		// Token: 0x040086BC RID: 34492
		[AutoBind("./SoldierInfoPanel/PorpretyGroup/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropHpValueText;

		// Token: 0x040086BD RID: 34493
		[AutoBind("./SoldierInfoPanel/PorpretyGroup/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropATValueText;

		// Token: 0x040086BE RID: 34494
		[AutoBind("./SoldierInfoPanel/PorpretyGroup/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropDFValueText;

		// Token: 0x040086BF RID: 34495
		[AutoBind("./SoldierInfoPanel/PorpretyGroup/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropMagicDFValueText;

		// Token: 0x040086C0 RID: 34496
		[AutoBind("./SoldierInfoPanel/PorpretyGroup/Range/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropRangeValueText;

		// Token: 0x040086C1 RID: 34497
		[AutoBind("./SoldierInfoPanel/PorpretyGroup/Move/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropMoveValueText;

		// Token: 0x040086C2 RID: 34498
		[AutoBind("./SoldierInfoPanel/PorpretyGroup/Restrain/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropRestrainValueText;

		// Token: 0x040086C3 RID: 34499
		[AutoBind("./SoldierInfoPanel/PorpretyGroup/Weak/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropWeakValueText;

		// Token: 0x040086C4 RID: 34500
		[AutoBind("./SoldierInfoPanel/PorpretyGroup/Type", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soldierPropTypeStateCtrl;

		// Token: 0x040086C5 RID: 34501
		[AutoBind("./SoldierInfoPanel/Desc/DescTextScroll/Mask/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDescText;

		// Token: 0x040086C6 RID: 34502
		[AutoBind("./SoldierInfoPanel/Desc/ExpressionToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_soldierSkillToggle;

		// Token: 0x040086C7 RID: 34503
		[AutoBind("./SoldierInfoPanel/Desc/ShortcutToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_soldierDescToggle;

		// Token: 0x040086C8 RID: 34504
		[AutoBind("./FrontSoldierShow/Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGraphic;

		// Token: 0x040086C9 RID: 34505
		[AutoBind("./GetSoldierNotic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_getSoldierNotic;

		// Token: 0x040086CA RID: 34506
		[AutoBind("./GetSoldierNotic/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_getSoldierNoticText;

		// Token: 0x040086CB RID: 34507
		[AutoBind("./GetSoldierNotic/GoToButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_getSoldierNoticGoToButton;

		// Token: 0x040086CC RID: 34508
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040086CD RID: 34509
		private int m_curPage;

		// Token: 0x040086CE RID: 34510
		private SoldierManualItemUIController m_curSoldierInfoCtrl;

		// Token: 0x040086CF RID: 34511
		private UISpineGraphic m_soldierInfoGraphic;

		// Token: 0x040086D0 RID: 34512
		private List<ConfigDataSoldierInfo> m_soldierInfoList = new List<ConfigDataSoldierInfo>();

		// Token: 0x040086D1 RID: 34513
		private List<SoldierManualItemUIController> m_soliderItemListCtrl = new List<SoldierManualItemUIController>();

		// Token: 0x040086D2 RID: 34514
		private int m_totalPageCount;

		// Token: 0x040086D3 RID: 34515
		private int m_curRank;

		// Token: 0x040086D4 RID: 34516
		private ArmyTag m_curArmyTag;

		// Token: 0x040086D5 RID: 34517
		private bool m_isFirstIn = true;

		// Token: 0x040086D6 RID: 34518
		[DoNotToLua]
		private DrillSoldierManualUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040086D7 RID: 34519
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040086D8 RID: 34520
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040086D9 RID: 34521
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040086DA RID: 34522
		private LuaFunction m_AddListenerToSortToggles_hotfix;

		// Token: 0x040086DB RID: 34523
		private LuaFunction m_Open_hotfix;

		// Token: 0x040086DC RID: 34524
		private LuaFunction m_UpdateViewInDrillSoliderManualList;

		// Token: 0x040086DD RID: 34525
		private LuaFunction m_OnSoldierItemClickSoldierManualItemUIController_hotfix;

		// Token: 0x040086DE RID: 34526
		private LuaFunction m_SetSoldierInfoDetailPanelConfigDataSoldierInfo_hotfix;

		// Token: 0x040086DF RID: 34527
		private LuaFunction m_OnPageNextButtonClick_hotfix;

		// Token: 0x040086E0 RID: 34528
		private LuaFunction m_OnPagePrevButtonClick_hotfix;

		// Token: 0x040086E1 RID: 34529
		private LuaFunction m_OnAllRankToggleValueChangedBoolean_hotfix;

		// Token: 0x040086E2 RID: 34530
		private LuaFunction m_OnRank1ToggleValueChangedBoolean_hotfix;

		// Token: 0x040086E3 RID: 34531
		private LuaFunction m_OnRank2ToggleValueChangedBoolean_hotfix;

		// Token: 0x040086E4 RID: 34532
		private LuaFunction m_OnRank3ToggleValueChangedBoolean_hotfix;

		// Token: 0x040086E5 RID: 34533
		private LuaFunction m_OnSoldierSkillToggleValueChangedBoolean_hotfix;

		// Token: 0x040086E6 RID: 34534
		private LuaFunction m_OnSoldierDescToggleValueChangedBoolean_hotfix;

		// Token: 0x040086E7 RID: 34535
		private LuaFunction m_OnGetSoldierNoticGoToButtonClick_hotfix;

		// Token: 0x040086E8 RID: 34536
		private LuaFunction m_OnSortButtonClick_hotfix;

		// Token: 0x040086E9 RID: 34537
		private LuaFunction m_CloseSortTypesPanel_hotfix;

		// Token: 0x040086EA RID: 34538
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x040086EB RID: 34539
		private LuaFunction m_ResetData_hotfix;

		// Token: 0x040086EC RID: 34540
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x040086ED RID: 34541
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x040086EE RID: 34542
		private LuaFunction m_add_EventOnNeedUpdateViewAction;

		// Token: 0x040086EF RID: 34543
		private LuaFunction m_remove_EventOnNeedUpdateViewAction;

		// Token: 0x040086F0 RID: 34544
		private LuaFunction m_add_EventOnGoToTraingTechAction;

		// Token: 0x040086F1 RID: 34545
		private LuaFunction m_remove_EventOnGoToTraingTechAction;

		// Token: 0x02000C3E RID: 3134
		public new class LuaExportHelper
		{
			// Token: 0x0600DC57 RID: 56407 RVA: 0x003BC234 File Offset: 0x003BA434
			public LuaExportHelper(DrillSoldierManualUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DC58 RID: 56408 RVA: 0x003BC244 File Offset: 0x003BA444
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600DC59 RID: 56409 RVA: 0x003BC254 File Offset: 0x003BA454
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600DC5A RID: 56410 RVA: 0x003BC264 File Offset: 0x003BA464
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600DC5B RID: 56411 RVA: 0x003BC274 File Offset: 0x003BA474
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DC5C RID: 56412 RVA: 0x003BC28C File Offset: 0x003BA48C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DC5D RID: 56413 RVA: 0x003BC29C File Offset: 0x003BA49C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DC5E RID: 56414 RVA: 0x003BC2AC File Offset: 0x003BA4AC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DC5F RID: 56415 RVA: 0x003BC2BC File Offset: 0x003BA4BC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DC60 RID: 56416 RVA: 0x003BC2CC File Offset: 0x003BA4CC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DC61 RID: 56417 RVA: 0x003BC2DC File Offset: 0x003BA4DC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DC62 RID: 56418 RVA: 0x003BC2EC File Offset: 0x003BA4EC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DC63 RID: 56419 RVA: 0x003BC2FC File Offset: 0x003BA4FC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DC64 RID: 56420 RVA: 0x003BC30C File Offset: 0x003BA50C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DC65 RID: 56421 RVA: 0x003BC31C File Offset: 0x003BA51C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DC66 RID: 56422 RVA: 0x003BC32C File Offset: 0x003BA52C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600DC67 RID: 56423 RVA: 0x003BC33C File Offset: 0x003BA53C
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600DC68 RID: 56424 RVA: 0x003BC34C File Offset: 0x003BA54C
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600DC69 RID: 56425 RVA: 0x003BC35C File Offset: 0x003BA55C
			public void __callDele_EventOnNeedUpdateView(int arg1, int arg2, ArmyTag arg3)
			{
				this.m_owner.__callDele_EventOnNeedUpdateView(arg1, arg2, arg3);
			}

			// Token: 0x0600DC6A RID: 56426 RVA: 0x003BC36C File Offset: 0x003BA56C
			public void __clearDele_EventOnNeedUpdateView(int arg1, int arg2, ArmyTag arg3)
			{
				this.m_owner.__clearDele_EventOnNeedUpdateView(arg1, arg2, arg3);
			}

			// Token: 0x0600DC6B RID: 56427 RVA: 0x003BC37C File Offset: 0x003BA57C
			public void __callDele_EventOnGoToTraingTech(int obj)
			{
				this.m_owner.__callDele_EventOnGoToTraingTech(obj);
			}

			// Token: 0x0600DC6C RID: 56428 RVA: 0x003BC38C File Offset: 0x003BA58C
			public void __clearDele_EventOnGoToTraingTech(int obj)
			{
				this.m_owner.__clearDele_EventOnGoToTraingTech(obj);
			}

			// Token: 0x17002AB1 RID: 10929
			// (get) Token: 0x0600DC6D RID: 56429 RVA: 0x003BC39C File Offset: 0x003BA59C
			// (set) Token: 0x0600DC6E RID: 56430 RVA: 0x003BC3AC File Offset: 0x003BA5AC
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

			// Token: 0x17002AB2 RID: 10930
			// (get) Token: 0x0600DC6F RID: 56431 RVA: 0x003BC3BC File Offset: 0x003BA5BC
			// (set) Token: 0x0600DC70 RID: 56432 RVA: 0x003BC3CC File Offset: 0x003BA5CC
			public GameObject m_pageButtonGroup
			{
				get
				{
					return this.m_owner.m_pageButtonGroup;
				}
				set
				{
					this.m_owner.m_pageButtonGroup = value;
				}
			}

			// Token: 0x17002AB3 RID: 10931
			// (get) Token: 0x0600DC71 RID: 56433 RVA: 0x003BC3DC File Offset: 0x003BA5DC
			// (set) Token: 0x0600DC72 RID: 56434 RVA: 0x003BC3EC File Offset: 0x003BA5EC
			public Button m_pagePrevButton
			{
				get
				{
					return this.m_owner.m_pagePrevButton;
				}
				set
				{
					this.m_owner.m_pagePrevButton = value;
				}
			}

			// Token: 0x17002AB4 RID: 10932
			// (get) Token: 0x0600DC73 RID: 56435 RVA: 0x003BC3FC File Offset: 0x003BA5FC
			// (set) Token: 0x0600DC74 RID: 56436 RVA: 0x003BC40C File Offset: 0x003BA60C
			public Button m_pageNextButton
			{
				get
				{
					return this.m_owner.m_pageNextButton;
				}
				set
				{
					this.m_owner.m_pageNextButton = value;
				}
			}

			// Token: 0x17002AB5 RID: 10933
			// (get) Token: 0x0600DC75 RID: 56437 RVA: 0x003BC41C File Offset: 0x003BA61C
			// (set) Token: 0x0600DC76 RID: 56438 RVA: 0x003BC42C File Offset: 0x003BA62C
			public Toggle m_allRankToggle
			{
				get
				{
					return this.m_owner.m_allRankToggle;
				}
				set
				{
					this.m_owner.m_allRankToggle = value;
				}
			}

			// Token: 0x17002AB6 RID: 10934
			// (get) Token: 0x0600DC77 RID: 56439 RVA: 0x003BC43C File Offset: 0x003BA63C
			// (set) Token: 0x0600DC78 RID: 56440 RVA: 0x003BC44C File Offset: 0x003BA64C
			public Toggle m_rank1Toggle
			{
				get
				{
					return this.m_owner.m_rank1Toggle;
				}
				set
				{
					this.m_owner.m_rank1Toggle = value;
				}
			}

			// Token: 0x17002AB7 RID: 10935
			// (get) Token: 0x0600DC79 RID: 56441 RVA: 0x003BC45C File Offset: 0x003BA65C
			// (set) Token: 0x0600DC7A RID: 56442 RVA: 0x003BC46C File Offset: 0x003BA66C
			public Toggle m_rank2Toggle
			{
				get
				{
					return this.m_owner.m_rank2Toggle;
				}
				set
				{
					this.m_owner.m_rank2Toggle = value;
				}
			}

			// Token: 0x17002AB8 RID: 10936
			// (get) Token: 0x0600DC7B RID: 56443 RVA: 0x003BC47C File Offset: 0x003BA67C
			// (set) Token: 0x0600DC7C RID: 56444 RVA: 0x003BC48C File Offset: 0x003BA68C
			public Toggle m_rank3Toggle
			{
				get
				{
					return this.m_owner.m_rank3Toggle;
				}
				set
				{
					this.m_owner.m_rank3Toggle = value;
				}
			}

			// Token: 0x17002AB9 RID: 10937
			// (get) Token: 0x0600DC7D RID: 56445 RVA: 0x003BC49C File Offset: 0x003BA69C
			// (set) Token: 0x0600DC7E RID: 56446 RVA: 0x003BC4AC File Offset: 0x003BA6AC
			public GameObject m_soldierListContent
			{
				get
				{
					return this.m_owner.m_soldierListContent;
				}
				set
				{
					this.m_owner.m_soldierListContent = value;
				}
			}

			// Token: 0x17002ABA RID: 10938
			// (get) Token: 0x0600DC7F RID: 56447 RVA: 0x003BC4BC File Offset: 0x003BA6BC
			// (set) Token: 0x0600DC80 RID: 56448 RVA: 0x003BC4CC File Offset: 0x003BA6CC
			public GameObject m_soldierItemPrefab
			{
				get
				{
					return this.m_owner.m_soldierItemPrefab;
				}
				set
				{
					this.m_owner.m_soldierItemPrefab = value;
				}
			}

			// Token: 0x17002ABB RID: 10939
			// (get) Token: 0x0600DC81 RID: 56449 RVA: 0x003BC4DC File Offset: 0x003BA6DC
			// (set) Token: 0x0600DC82 RID: 56450 RVA: 0x003BC4EC File Offset: 0x003BA6EC
			public Button m_sortButton
			{
				get
				{
					return this.m_owner.m_sortButton;
				}
				set
				{
					this.m_owner.m_sortButton = value;
				}
			}

			// Token: 0x17002ABC RID: 10940
			// (get) Token: 0x0600DC83 RID: 56451 RVA: 0x003BC4FC File Offset: 0x003BA6FC
			// (set) Token: 0x0600DC84 RID: 56452 RVA: 0x003BC50C File Offset: 0x003BA70C
			public Text m_sortButtonTypeText
			{
				get
				{
					return this.m_owner.m_sortButtonTypeText;
				}
				set
				{
					this.m_owner.m_sortButtonTypeText = value;
				}
			}

			// Token: 0x17002ABD RID: 10941
			// (get) Token: 0x0600DC85 RID: 56453 RVA: 0x003BC51C File Offset: 0x003BA71C
			// (set) Token: 0x0600DC86 RID: 56454 RVA: 0x003BC52C File Offset: 0x003BA72C
			public GameObject m_sortTypes
			{
				get
				{
					return this.m_owner.m_sortTypes;
				}
				set
				{
					this.m_owner.m_sortTypes = value;
				}
			}

			// Token: 0x17002ABE RID: 10942
			// (get) Token: 0x0600DC87 RID: 56455 RVA: 0x003BC53C File Offset: 0x003BA73C
			// (set) Token: 0x0600DC88 RID: 56456 RVA: 0x003BC54C File Offset: 0x003BA74C
			public Button m_sortTypesReturnBgImage
			{
				get
				{
					return this.m_owner.m_sortTypesReturnBgImage;
				}
				set
				{
					this.m_owner.m_sortTypesReturnBgImage = value;
				}
			}

			// Token: 0x17002ABF RID: 10943
			// (get) Token: 0x0600DC89 RID: 56457 RVA: 0x003BC55C File Offset: 0x003BA75C
			// (set) Token: 0x0600DC8A RID: 56458 RVA: 0x003BC56C File Offset: 0x003BA76C
			public GameObject m_sortTypesGridLayout
			{
				get
				{
					return this.m_owner.m_sortTypesGridLayout;
				}
				set
				{
					this.m_owner.m_sortTypesGridLayout = value;
				}
			}

			// Token: 0x17002AC0 RID: 10944
			// (get) Token: 0x0600DC8B RID: 56459 RVA: 0x003BC57C File Offset: 0x003BA77C
			// (set) Token: 0x0600DC8C RID: 56460 RVA: 0x003BC58C File Offset: 0x003BA78C
			public Image m_soldierTypeIcon
			{
				get
				{
					return this.m_owner.m_soldierTypeIcon;
				}
				set
				{
					this.m_owner.m_soldierTypeIcon = value;
				}
			}

			// Token: 0x17002AC1 RID: 10945
			// (get) Token: 0x0600DC8D RID: 56461 RVA: 0x003BC59C File Offset: 0x003BA79C
			// (set) Token: 0x0600DC8E RID: 56462 RVA: 0x003BC5AC File Offset: 0x003BA7AC
			public Image m_soldierQualityIcon
			{
				get
				{
					return this.m_owner.m_soldierQualityIcon;
				}
				set
				{
					this.m_owner.m_soldierQualityIcon = value;
				}
			}

			// Token: 0x17002AC2 RID: 10946
			// (get) Token: 0x0600DC8F RID: 56463 RVA: 0x003BC5BC File Offset: 0x003BA7BC
			// (set) Token: 0x0600DC90 RID: 56464 RVA: 0x003BC5CC File Offset: 0x003BA7CC
			public Text m_soldierNameText
			{
				get
				{
					return this.m_owner.m_soldierNameText;
				}
				set
				{
					this.m_owner.m_soldierNameText = value;
				}
			}

			// Token: 0x17002AC3 RID: 10947
			// (get) Token: 0x0600DC91 RID: 56465 RVA: 0x003BC5DC File Offset: 0x003BA7DC
			// (set) Token: 0x0600DC92 RID: 56466 RVA: 0x003BC5EC File Offset: 0x003BA7EC
			public Text m_soldierPropHpValueText
			{
				get
				{
					return this.m_owner.m_soldierPropHpValueText;
				}
				set
				{
					this.m_owner.m_soldierPropHpValueText = value;
				}
			}

			// Token: 0x17002AC4 RID: 10948
			// (get) Token: 0x0600DC93 RID: 56467 RVA: 0x003BC5FC File Offset: 0x003BA7FC
			// (set) Token: 0x0600DC94 RID: 56468 RVA: 0x003BC60C File Offset: 0x003BA80C
			public Text m_soldierPropATValueText
			{
				get
				{
					return this.m_owner.m_soldierPropATValueText;
				}
				set
				{
					this.m_owner.m_soldierPropATValueText = value;
				}
			}

			// Token: 0x17002AC5 RID: 10949
			// (get) Token: 0x0600DC95 RID: 56469 RVA: 0x003BC61C File Offset: 0x003BA81C
			// (set) Token: 0x0600DC96 RID: 56470 RVA: 0x003BC62C File Offset: 0x003BA82C
			public Text m_soldierPropDFValueText
			{
				get
				{
					return this.m_owner.m_soldierPropDFValueText;
				}
				set
				{
					this.m_owner.m_soldierPropDFValueText = value;
				}
			}

			// Token: 0x17002AC6 RID: 10950
			// (get) Token: 0x0600DC97 RID: 56471 RVA: 0x003BC63C File Offset: 0x003BA83C
			// (set) Token: 0x0600DC98 RID: 56472 RVA: 0x003BC64C File Offset: 0x003BA84C
			public Text m_soldierPropMagicDFValueText
			{
				get
				{
					return this.m_owner.m_soldierPropMagicDFValueText;
				}
				set
				{
					this.m_owner.m_soldierPropMagicDFValueText = value;
				}
			}

			// Token: 0x17002AC7 RID: 10951
			// (get) Token: 0x0600DC99 RID: 56473 RVA: 0x003BC65C File Offset: 0x003BA85C
			// (set) Token: 0x0600DC9A RID: 56474 RVA: 0x003BC66C File Offset: 0x003BA86C
			public Text m_soldierPropRangeValueText
			{
				get
				{
					return this.m_owner.m_soldierPropRangeValueText;
				}
				set
				{
					this.m_owner.m_soldierPropRangeValueText = value;
				}
			}

			// Token: 0x17002AC8 RID: 10952
			// (get) Token: 0x0600DC9B RID: 56475 RVA: 0x003BC67C File Offset: 0x003BA87C
			// (set) Token: 0x0600DC9C RID: 56476 RVA: 0x003BC68C File Offset: 0x003BA88C
			public Text m_soldierPropMoveValueText
			{
				get
				{
					return this.m_owner.m_soldierPropMoveValueText;
				}
				set
				{
					this.m_owner.m_soldierPropMoveValueText = value;
				}
			}

			// Token: 0x17002AC9 RID: 10953
			// (get) Token: 0x0600DC9D RID: 56477 RVA: 0x003BC69C File Offset: 0x003BA89C
			// (set) Token: 0x0600DC9E RID: 56478 RVA: 0x003BC6AC File Offset: 0x003BA8AC
			public Text m_soldierPropRestrainValueText
			{
				get
				{
					return this.m_owner.m_soldierPropRestrainValueText;
				}
				set
				{
					this.m_owner.m_soldierPropRestrainValueText = value;
				}
			}

			// Token: 0x17002ACA RID: 10954
			// (get) Token: 0x0600DC9F RID: 56479 RVA: 0x003BC6BC File Offset: 0x003BA8BC
			// (set) Token: 0x0600DCA0 RID: 56480 RVA: 0x003BC6CC File Offset: 0x003BA8CC
			public Text m_soldierPropWeakValueText
			{
				get
				{
					return this.m_owner.m_soldierPropWeakValueText;
				}
				set
				{
					this.m_owner.m_soldierPropWeakValueText = value;
				}
			}

			// Token: 0x17002ACB RID: 10955
			// (get) Token: 0x0600DCA1 RID: 56481 RVA: 0x003BC6DC File Offset: 0x003BA8DC
			// (set) Token: 0x0600DCA2 RID: 56482 RVA: 0x003BC6EC File Offset: 0x003BA8EC
			public CommonUIStateController m_soldierPropTypeStateCtrl
			{
				get
				{
					return this.m_owner.m_soldierPropTypeStateCtrl;
				}
				set
				{
					this.m_owner.m_soldierPropTypeStateCtrl = value;
				}
			}

			// Token: 0x17002ACC RID: 10956
			// (get) Token: 0x0600DCA3 RID: 56483 RVA: 0x003BC6FC File Offset: 0x003BA8FC
			// (set) Token: 0x0600DCA4 RID: 56484 RVA: 0x003BC70C File Offset: 0x003BA90C
			public Text m_soldierDescText
			{
				get
				{
					return this.m_owner.m_soldierDescText;
				}
				set
				{
					this.m_owner.m_soldierDescText = value;
				}
			}

			// Token: 0x17002ACD RID: 10957
			// (get) Token: 0x0600DCA5 RID: 56485 RVA: 0x003BC71C File Offset: 0x003BA91C
			// (set) Token: 0x0600DCA6 RID: 56486 RVA: 0x003BC72C File Offset: 0x003BA92C
			public Toggle m_soldierSkillToggle
			{
				get
				{
					return this.m_owner.m_soldierSkillToggle;
				}
				set
				{
					this.m_owner.m_soldierSkillToggle = value;
				}
			}

			// Token: 0x17002ACE RID: 10958
			// (get) Token: 0x0600DCA7 RID: 56487 RVA: 0x003BC73C File Offset: 0x003BA93C
			// (set) Token: 0x0600DCA8 RID: 56488 RVA: 0x003BC74C File Offset: 0x003BA94C
			public Toggle m_soldierDescToggle
			{
				get
				{
					return this.m_owner.m_soldierDescToggle;
				}
				set
				{
					this.m_owner.m_soldierDescToggle = value;
				}
			}

			// Token: 0x17002ACF RID: 10959
			// (get) Token: 0x0600DCA9 RID: 56489 RVA: 0x003BC75C File Offset: 0x003BA95C
			// (set) Token: 0x0600DCAA RID: 56490 RVA: 0x003BC76C File Offset: 0x003BA96C
			public GameObject m_soldierGraphic
			{
				get
				{
					return this.m_owner.m_soldierGraphic;
				}
				set
				{
					this.m_owner.m_soldierGraphic = value;
				}
			}

			// Token: 0x17002AD0 RID: 10960
			// (get) Token: 0x0600DCAB RID: 56491 RVA: 0x003BC77C File Offset: 0x003BA97C
			// (set) Token: 0x0600DCAC RID: 56492 RVA: 0x003BC78C File Offset: 0x003BA98C
			public GameObject m_getSoldierNotic
			{
				get
				{
					return this.m_owner.m_getSoldierNotic;
				}
				set
				{
					this.m_owner.m_getSoldierNotic = value;
				}
			}

			// Token: 0x17002AD1 RID: 10961
			// (get) Token: 0x0600DCAD RID: 56493 RVA: 0x003BC79C File Offset: 0x003BA99C
			// (set) Token: 0x0600DCAE RID: 56494 RVA: 0x003BC7AC File Offset: 0x003BA9AC
			public Text m_getSoldierNoticText
			{
				get
				{
					return this.m_owner.m_getSoldierNoticText;
				}
				set
				{
					this.m_owner.m_getSoldierNoticText = value;
				}
			}

			// Token: 0x17002AD2 RID: 10962
			// (get) Token: 0x0600DCAF RID: 56495 RVA: 0x003BC7BC File Offset: 0x003BA9BC
			// (set) Token: 0x0600DCB0 RID: 56496 RVA: 0x003BC7CC File Offset: 0x003BA9CC
			public Button m_getSoldierNoticGoToButton
			{
				get
				{
					return this.m_owner.m_getSoldierNoticGoToButton;
				}
				set
				{
					this.m_owner.m_getSoldierNoticGoToButton = value;
				}
			}

			// Token: 0x17002AD3 RID: 10963
			// (get) Token: 0x0600DCB1 RID: 56497 RVA: 0x003BC7DC File Offset: 0x003BA9DC
			// (set) Token: 0x0600DCB2 RID: 56498 RVA: 0x003BC7EC File Offset: 0x003BA9EC
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

			// Token: 0x17002AD4 RID: 10964
			// (get) Token: 0x0600DCB3 RID: 56499 RVA: 0x003BC7FC File Offset: 0x003BA9FC
			// (set) Token: 0x0600DCB4 RID: 56500 RVA: 0x003BC80C File Offset: 0x003BAA0C
			public int m_curPage
			{
				get
				{
					return this.m_owner.m_curPage;
				}
				set
				{
					this.m_owner.m_curPage = value;
				}
			}

			// Token: 0x17002AD5 RID: 10965
			// (get) Token: 0x0600DCB5 RID: 56501 RVA: 0x003BC81C File Offset: 0x003BAA1C
			// (set) Token: 0x0600DCB6 RID: 56502 RVA: 0x003BC82C File Offset: 0x003BAA2C
			public SoldierManualItemUIController m_curSoldierInfoCtrl
			{
				get
				{
					return this.m_owner.m_curSoldierInfoCtrl;
				}
				set
				{
					this.m_owner.m_curSoldierInfoCtrl = value;
				}
			}

			// Token: 0x17002AD6 RID: 10966
			// (get) Token: 0x0600DCB7 RID: 56503 RVA: 0x003BC83C File Offset: 0x003BAA3C
			// (set) Token: 0x0600DCB8 RID: 56504 RVA: 0x003BC84C File Offset: 0x003BAA4C
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

			// Token: 0x17002AD7 RID: 10967
			// (get) Token: 0x0600DCB9 RID: 56505 RVA: 0x003BC85C File Offset: 0x003BAA5C
			// (set) Token: 0x0600DCBA RID: 56506 RVA: 0x003BC86C File Offset: 0x003BAA6C
			public List<ConfigDataSoldierInfo> m_soldierInfoList
			{
				get
				{
					return this.m_owner.m_soldierInfoList;
				}
				set
				{
					this.m_owner.m_soldierInfoList = value;
				}
			}

			// Token: 0x17002AD8 RID: 10968
			// (get) Token: 0x0600DCBB RID: 56507 RVA: 0x003BC87C File Offset: 0x003BAA7C
			// (set) Token: 0x0600DCBC RID: 56508 RVA: 0x003BC88C File Offset: 0x003BAA8C
			public List<SoldierManualItemUIController> m_soliderItemListCtrl
			{
				get
				{
					return this.m_owner.m_soliderItemListCtrl;
				}
				set
				{
					this.m_owner.m_soliderItemListCtrl = value;
				}
			}

			// Token: 0x17002AD9 RID: 10969
			// (get) Token: 0x0600DCBD RID: 56509 RVA: 0x003BC89C File Offset: 0x003BAA9C
			// (set) Token: 0x0600DCBE RID: 56510 RVA: 0x003BC8AC File Offset: 0x003BAAAC
			public int m_totalPageCount
			{
				get
				{
					return this.m_owner.m_totalPageCount;
				}
				set
				{
					this.m_owner.m_totalPageCount = value;
				}
			}

			// Token: 0x17002ADA RID: 10970
			// (get) Token: 0x0600DCBF RID: 56511 RVA: 0x003BC8BC File Offset: 0x003BAABC
			// (set) Token: 0x0600DCC0 RID: 56512 RVA: 0x003BC8CC File Offset: 0x003BAACC
			public int m_curRank
			{
				get
				{
					return this.m_owner.m_curRank;
				}
				set
				{
					this.m_owner.m_curRank = value;
				}
			}

			// Token: 0x17002ADB RID: 10971
			// (get) Token: 0x0600DCC1 RID: 56513 RVA: 0x003BC8DC File Offset: 0x003BAADC
			// (set) Token: 0x0600DCC2 RID: 56514 RVA: 0x003BC8EC File Offset: 0x003BAAEC
			public ArmyTag m_curArmyTag
			{
				get
				{
					return this.m_owner.m_curArmyTag;
				}
				set
				{
					this.m_owner.m_curArmyTag = value;
				}
			}

			// Token: 0x17002ADC RID: 10972
			// (get) Token: 0x0600DCC3 RID: 56515 RVA: 0x003BC8FC File Offset: 0x003BAAFC
			// (set) Token: 0x0600DCC4 RID: 56516 RVA: 0x003BC90C File Offset: 0x003BAB0C
			public bool m_isFirstIn
			{
				get
				{
					return this.m_owner.m_isFirstIn;
				}
				set
				{
					this.m_owner.m_isFirstIn = value;
				}
			}

			// Token: 0x0600DCC5 RID: 56517 RVA: 0x003BC91C File Offset: 0x003BAB1C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600DCC6 RID: 56518 RVA: 0x003BC92C File Offset: 0x003BAB2C
			public void AddListenerToSortToggles()
			{
				this.m_owner.AddListenerToSortToggles();
			}

			// Token: 0x0600DCC7 RID: 56519 RVA: 0x003BC93C File Offset: 0x003BAB3C
			public void OnSoldierItemClick(SoldierManualItemUIController ctrl)
			{
				this.m_owner.OnSoldierItemClick(ctrl);
			}

			// Token: 0x0600DCC8 RID: 56520 RVA: 0x003BC94C File Offset: 0x003BAB4C
			public void SetSoldierInfoDetailPanel(ConfigDataSoldierInfo soldierInfo)
			{
				this.m_owner.SetSoldierInfoDetailPanel(soldierInfo);
			}

			// Token: 0x0600DCC9 RID: 56521 RVA: 0x003BC95C File Offset: 0x003BAB5C
			public void OnPageNextButtonClick()
			{
				this.m_owner.OnPageNextButtonClick();
			}

			// Token: 0x0600DCCA RID: 56522 RVA: 0x003BC96C File Offset: 0x003BAB6C
			public void OnPagePrevButtonClick()
			{
				this.m_owner.OnPagePrevButtonClick();
			}

			// Token: 0x0600DCCB RID: 56523 RVA: 0x003BC97C File Offset: 0x003BAB7C
			public void OnAllRankToggleValueChanged(bool isOn)
			{
				this.m_owner.OnAllRankToggleValueChanged(isOn);
			}

			// Token: 0x0600DCCC RID: 56524 RVA: 0x003BC98C File Offset: 0x003BAB8C
			public void OnRank1ToggleValueChanged(bool isOn)
			{
				this.m_owner.OnRank1ToggleValueChanged(isOn);
			}

			// Token: 0x0600DCCD RID: 56525 RVA: 0x003BC99C File Offset: 0x003BAB9C
			public void OnRank2ToggleValueChanged(bool isOn)
			{
				this.m_owner.OnRank2ToggleValueChanged(isOn);
			}

			// Token: 0x0600DCCE RID: 56526 RVA: 0x003BC9AC File Offset: 0x003BABAC
			public void OnRank3ToggleValueChanged(bool isOn)
			{
				this.m_owner.OnRank3ToggleValueChanged(isOn);
			}

			// Token: 0x0600DCCF RID: 56527 RVA: 0x003BC9BC File Offset: 0x003BABBC
			public void OnSoldierSkillToggleValueChanged(bool isOn)
			{
				this.m_owner.OnSoldierSkillToggleValueChanged(isOn);
			}

			// Token: 0x0600DCD0 RID: 56528 RVA: 0x003BC9CC File Offset: 0x003BABCC
			public void OnSoldierDescToggleValueChanged(bool isOn)
			{
				this.m_owner.OnSoldierDescToggleValueChanged(isOn);
			}

			// Token: 0x0600DCD1 RID: 56529 RVA: 0x003BC9DC File Offset: 0x003BABDC
			public void OnGetSoldierNoticGoToButtonClick()
			{
				this.m_owner.OnGetSoldierNoticGoToButtonClick();
			}

			// Token: 0x0600DCD2 RID: 56530 RVA: 0x003BC9EC File Offset: 0x003BABEC
			public void OnSortButtonClick()
			{
				this.m_owner.OnSortButtonClick();
			}

			// Token: 0x0600DCD3 RID: 56531 RVA: 0x003BC9FC File Offset: 0x003BABFC
			public void CloseSortTypesPanel()
			{
				this.m_owner.CloseSortTypesPanel();
			}

			// Token: 0x0600DCD4 RID: 56532 RVA: 0x003BCA0C File Offset: 0x003BAC0C
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x040086F2 RID: 34546
			private DrillSoldierManualUIController m_owner;
		}
	}
}
