using System;
using System.Collections.Generic;
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
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E0A RID: 3594
	[HotFix]
	public class HeroSoldierSkinUIController : UIControllerBase
	{
		// Token: 0x0601133F RID: 70463 RVA: 0x00475F7C File Offset: 0x0047417C
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
			this.m_infoBuyButton.onClick.AddListener(new UnityAction(this.OnInfoBuyButtonClick));
			this.m_infoSwitchButton.onClick.AddListener(new UnityAction(this.OnInfoSwitchButtonClick));
			this.m_infoUnavailableButton.onClick.AddListener(new UnityAction(this.OnInfoUnavailableButtonClick));
			this.m_showHeroToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnShowHeroToggleValueChanged));
			this.m_showSoliderToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnShowSoldierToggleValueChanged));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x06011340 RID: 70464 RVA: 0x004760C0 File Offset: 0x004742C0
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
			this.m_rootGo.SetActive(true);
			CommonUIStateController component = this.m_rootGo.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateOpen(component, "Show", null, false, true);
		}

		// Token: 0x06011341 RID: 70465 RVA: 0x00476148 File Offset: 0x00474348
		public void UpdateViewInHeroSoldierSkin(Hero hero, bool isFromHeroTab, ConfigDataSoldierInfo soldierInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInHeroSoldierSkinHeroBooleanConfigDataSoldierInfo_hotfix != null)
			{
				this.m_UpdateViewInHeroSoldierSkinHeroBooleanConfigDataSoldierInfo_hotfix.call(new object[]
				{
					this,
					hero,
					isFromHeroTab,
					soldierInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_soldierInfo = soldierInfo;
			this.m_isFromHeroTab = isFromHeroTab;
			if (isFromHeroTab)
			{
				this.m_showToggleStateCtrl.SetToUIState("Hero", false, true);
				this.m_showHeroToggle.isOn = LocalConfig.Instance.Data.OnlyShowCurJobSkin;
				this.ShowHeroSkin();
			}
			else
			{
				this.m_showToggleStateCtrl.SetToUIState("Soldier", false, true);
				this.m_showSoliderToggle.isOn = LocalConfig.Instance.Data.SetSkinToAllSoldier;
				this.ShowSoldierSkin();
			}
		}

		// Token: 0x06011342 RID: 70466 RVA: 0x0047625C File Offset: 0x0047445C
		private void LateUpdate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LateUpdate_hotfix != null)
			{
				this.m_LateUpdate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (HeroOrSoliderSkinUIController heroOrSoliderSkinUIController in this.m_itemCtrlList)
			{
				heroOrSoliderSkinUIController.SetLimitTime();
			}
			if (this.m_curSelectHeroSkinItemCtrl != null)
			{
				if (this.m_curSelectHeroSkinItemCtrl.IsHeroSkin)
				{
					this.SetHeroButtonState(this.m_curSelectHeroSkinItemCtrl);
				}
				else
				{
					this.SetSoldierInfoPanel(this.m_curSelectHeroSkinItemCtrl);
				}
			}
		}

		// Token: 0x06011343 RID: 70467 RVA: 0x00476348 File Offset: 0x00474548
		private void ShowHeroSkin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowHeroSkin_hotfix != null)
			{
				this.m_ShowHeroSkin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			if (!LocalConfig.Instance.Data.OnlyShowCurJobSkin)
			{
				if (this.m_playerContext.IsProtagonistHero(this.m_hero.HeroId))
				{
					ConfigDataProtagonistInfo configDataProtagonistInfo = this.m_configDataLoader.GetConfigDataProtagonistInfo(this.m_playerContext.GetProtagonistId());
					foreach (int num in configDataProtagonistInfo.UseableJobConnections_ID)
					{
						ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(num);
						if (configDataJobConnectionInfo.IsJobOpen)
						{
							foreach (int key in configDataJobConnectionInfo.Skins_ID)
							{
								if (!dictionary.ContainsKey(key))
								{
									dictionary[key] = num;
								}
							}
						}
					}
					foreach (KeyValuePair<int, int> keyValuePair in dictionary)
					{
						if (!list.Contains(keyValuePair.Value))
						{
							list.Add(keyValuePair.Value);
						}
					}
				}
				else
				{
					foreach (int num2 in this.m_playerContext.GetUseableJobConnectionInfos(this.m_hero.HeroId))
					{
						ConfigDataJobConnectionInfo configDataJobConnectionInfo2 = this.m_configDataLoader.GetConfigDataJobConnectionInfo(num2);
						if (configDataJobConnectionInfo2.IsJobOpen)
						{
							foreach (int key2 in configDataJobConnectionInfo2.Skins_ID)
							{
								if (!dictionary.ContainsKey(key2))
								{
									dictionary[key2] = num2;
								}
							}
						}
					}
					int id = this.m_hero.HeroInfo.m_jobConnectionInfo.ID;
					ConfigDataJobConnectionInfo configDataJobConnectionInfo3 = this.m_configDataLoader.GetConfigDataJobConnectionInfo(id);
					if (!configDataJobConnectionInfo3.IsJobOpen)
					{
						foreach (int key3 in configDataJobConnectionInfo3.Skins_ID)
						{
							if (!dictionary.ContainsKey(key3))
							{
								dictionary[key3] = id;
							}
						}
					}
					foreach (KeyValuePair<int, int> keyValuePair2 in dictionary)
					{
						if (!list.Contains(keyValuePair2.Value))
						{
							list.Add(keyValuePair2.Value);
						}
					}
				}
				List<int> list2 = list;
				if (HeroSoldierSkinUIController.<>f__mg$cache0 == null)
				{
					HeroSoldierSkinUIController.<>f__mg$cache0 = new Comparison<int>(HeroJobTransferUIController.SortJobConnectionIdByUISort);
				}
				list2.Sort(HeroSoldierSkinUIController.<>f__mg$cache0);
			}
			else
			{
				list.Add(this.m_hero.GetActiveJob().JobRelatedId);
			}
			this.m_curSelectHeroSkinItemCtrl = null;
			GameObjectUtility.DestroyChildren(this.m_scrollContent);
			this.m_itemCtrlList.Clear();
			this.CreatDefaultHeroSkin();
			foreach (int key4 in list)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo4 = this.m_configDataLoader.GetConfigDataJobConnectionInfo(key4);
				foreach (int num3 in configDataJobConnectionInfo4.Skins_ID)
				{
					ConfigDataHeroSkinInfo configDataHeroSkinInfo = this.m_configDataLoader.GetConfigDataHeroSkinInfo(num3);
					if (this.m_playerContext.IsShowSkinBeforeOnSale(configDataHeroSkinInfo.FixedStoreItemId, true))
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_heroSoldierSkinItemPrefab);
						PrefabControllerCreater.CreateAllControllers(gameObject);
						HeroOrSoliderSkinUIController component = gameObject.GetComponent<HeroOrSoliderSkinUIController>();
						component.EventOnItemClick += this.OnSkinItemClick;
						component.InitHeroSkinItem(this.m_hero, configDataJobConnectionInfo4, num3);
						gameObject.transform.SetParent(this.m_scrollContent.transform, false);
						this.m_itemCtrlList.Add(component);
						if (this.m_hero.GetActiveJob().ModelSkinId == num3)
						{
							this.m_curSelectHeroSkinItemCtrl = component;
						}
					}
				}
			}
			if (this.m_curSelectHeroSkinItemCtrl != null)
			{
				this.m_curSelectHeroSkinItemCtrl.ShowSelectImage(true);
				this.SetHeroInfoPanel(this.m_curSelectHeroSkinItemCtrl);
			}
			else
			{
				this.m_curSelectHeroSkinItemCtrl = this.m_itemCtrlList[0];
				this.m_curSelectHeroSkinItemCtrl.ShowSelectImage(true);
				this.SetHeroInfoPanel(this.m_curSelectHeroSkinItemCtrl);
			}
		}

		// Token: 0x06011344 RID: 70468 RVA: 0x00476958 File Offset: 0x00474B58
		private void CreatDefaultHeroSkin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreatDefaultHeroSkin_hotfix != null)
			{
				this.m_CreatDefaultHeroSkin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_heroSoldierSkinItemPrefab);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			HeroOrSoliderSkinUIController component = gameObject.GetComponent<HeroOrSoliderSkinUIController>();
			component.EventOnItemClick += this.OnSkinItemClick;
			component.InitDefaultHeroSkinItem(this.m_hero);
			gameObject.transform.SetParent(this.m_scrollContent.transform, false);
			this.m_itemCtrlList.Add(component);
			if (this.m_hero.GetActiveJob().ModelSkinId == 0)
			{
				this.m_curSelectHeroSkinItemCtrl = component;
			}
		}

		// Token: 0x06011345 RID: 70469 RVA: 0x00476A30 File Offset: 0x00474C30
		private void SetHeroInfoPanel(HeroOrSoliderSkinUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroInfoPanelHeroOrSoliderSkinUIController_hotfix != null)
			{
				this.m_SetHeroInfoPanelHeroOrSoliderSkinUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			ConfigDataHeroSkinInfo heroSkinInfo = ctrl.HeroSkinInfo;
			if (ctrl.IsDefaultSkin)
			{
				list.Add(this.m_hero.GetActiveJob().JobRelatedId);
			}
			else
			{
				foreach (JobConnection2SkinResource jobConnection2SkinResource in heroSkinInfo.SpecifiedModelSkinResource)
				{
					list.Add(jobConnection2SkinResource.JobConnectionId);
				}
			}
			GameObjectUtility.DestroyChildren(this.m_infoHeroJobContent);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("heroSkinJobItem");
			foreach (int key in list)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(key);
				if (configDataJobConnectionInfo != null)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					HeroSkinJobUIController component = gameObject.GetComponent<HeroSkinJobUIController>();
					component.InitHeroSkinJobItem(configDataJobConnectionInfo);
					gameObject.transform.SetParent(this.m_infoHeroJobContent.transform, false);
				}
			}
			this.SetHeroButtonState(ctrl);
		}

		// Token: 0x06011346 RID: 70470 RVA: 0x00476BE0 File Offset: 0x00474DE0
		private void SetHeroButtonState(HeroOrSoliderSkinUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroButtonStateHeroOrSoliderSkinUIController_hotfix != null)
			{
				this.m_SetHeroButtonStateHeroOrSoliderSkinUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroSkinInfo heroSkinInfo = ctrl.HeroSkinInfo;
			if (ctrl.IsDefaultSkin)
			{
				this.m_infoTitleText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DefaultName);
				this.m_infoDescText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_HeroDefaultCharSkinDesc);
				if (this.m_hero.GetActiveJob().ModelSkinId != 0)
				{
					this.m_infoPanelStateCtrl.SetToUIState("NormalHero", false, true);
				}
				else
				{
					this.m_infoPanelStateCtrl.SetToUIState("InUseHero", false, true);
				}
			}
			else
			{
				this.m_infoTitleText.text = heroSkinInfo.Name;
				this.m_infoDescText.text = heroSkinInfo.Desc;
				if (this.m_playerContext.HasOwn(GoodsType.GoodsType_HeroSkin, heroSkinInfo.ID))
				{
					if (this.m_hero.GetActiveJob().ModelSkinId != heroSkinInfo.ID)
					{
						int jobRelatedId = this.m_hero.GetActiveJob().JobRelatedId;
						bool flag = false;
						foreach (JobConnection2SkinResource jobConnection2SkinResource in heroSkinInfo.SpecifiedModelSkinResource)
						{
							if (jobConnection2SkinResource.JobConnectionId == jobRelatedId)
							{
								flag = true;
							}
						}
						if (flag)
						{
							this.m_infoPanelStateCtrl.SetToUIState("NormalHero", false, true);
						}
						else
						{
							this.m_infoPanelStateCtrl.SetToUIState("UnavailablePanelHero", false, true);
						}
					}
					else
					{
						this.m_infoPanelStateCtrl.SetToUIState("InUseHero", false, true);
					}
				}
				else
				{
					if (ctrl.ModelSkinResourceInfo == null)
					{
						return;
					}
					ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(ctrl.HeroSkinInfo.FixedStoreItemId);
					if (configDataFixedStoreItemInfo == null || configDataFixedStoreItemInfo.ShowEndTime == DateTime.MaxValue.ToString())
					{
						if (ctrl.HeroSkinInfo.GetPathDesc != string.Empty)
						{
							this.m_infoFromDetailText.text = ctrl.HeroSkinInfo.GetPathDesc;
							this.m_infoPanelStateCtrl.SetToUIState("LockPanelHero", false, true);
						}
						else
						{
							this.m_infoPanelStateCtrl.SetToUIState("LockPanelHeroWithButton", false, true);
						}
					}
					else
					{
						DateTime t = DateTime.Parse(configDataFixedStoreItemInfo.ShowEndTime);
						DateTime t2 = DateTime.Parse(configDataFixedStoreItemInfo.ShowStartTime);
						DateTime serverTime = this.m_playerContext.GetServerTime();
						if (t < serverTime || (!configDataFixedStoreItemInfo.IsFirstOnSale && t2 > serverTime))
						{
							this.m_infoFromDetailText.text = ctrl.HeroSkinInfo.GetPathDesc;
							this.m_infoPanelStateCtrl.SetToUIState("LockPanelHero", false, true);
						}
						else
						{
							this.m_infoPanelStateCtrl.SetToUIState("LockPanelHeroWithButton", false, true);
						}
					}
				}
			}
		}

		// Token: 0x06011347 RID: 70471 RVA: 0x00476F28 File Offset: 0x00475128
		private void ShowSoldierSkin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSoldierSkin_hotfix != null)
			{
				this.m_ShowSoldierSkin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_scrollContent);
			this.m_itemCtrlList.Clear();
			this.CreateDefaultSoldier();
			int soldierSkinId = this.m_hero.GetSoldierSkinId(this.m_soldierInfo.ID);
			foreach (int key in this.m_soldierInfo.SoldierSkins_ID)
			{
				ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = this.m_configDataLoader.GetConfigDataSoldierSkinInfo(key);
				if (configDataSoldierSkinInfo != null)
				{
					if (this.m_playerContext.HasOwn(GoodsType.GoodsType_SoldierSkin, configDataSoldierSkinInfo.ID) || configDataSoldierSkinInfo.IsShowBeforeGet)
					{
						if (this.m_playerContext.IsShowSkinBeforeOnSale(configDataSoldierSkinInfo.FixedStoreItemId, false))
						{
							foreach (Soldier2SkinResource soldier2SkinResource in configDataSoldierSkinInfo.SpecifiedSoldier)
							{
								if (soldier2SkinResource.SoldierId == this.m_soldierInfo.ID)
								{
									GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_heroSoldierSkinItemPrefab);
									PrefabControllerCreater.CreateAllControllers(gameObject);
									HeroOrSoliderSkinUIController component = gameObject.GetComponent<HeroOrSoliderSkinUIController>();
									component.EventOnItemClick += this.OnSkinItemClick;
									component.InitSoldierSkinItem(soldier2SkinResource, configDataSoldierSkinInfo, this.m_hero);
									gameObject.transform.SetParent(this.m_scrollContent.transform, false);
									this.m_itemCtrlList.Add(component);
									if (soldierSkinId == configDataSoldierSkinInfo.ID)
									{
										this.m_curSelectHeroSkinItemCtrl = component;
									}
								}
							}
						}
					}
				}
			}
			if (this.m_curSelectHeroSkinItemCtrl != null)
			{
				this.m_curSelectHeroSkinItemCtrl.ShowSelectImage(true);
				this.SetSoldierInfoPanel(this.m_curSelectHeroSkinItemCtrl);
			}
			else if (this.m_itemCtrlList.Count > 0)
			{
				this.m_curSelectHeroSkinItemCtrl = this.m_itemCtrlList[0];
				this.m_curSelectHeroSkinItemCtrl.ShowSelectImage(true);
				this.SetSoldierInfoPanel(this.m_curSelectHeroSkinItemCtrl);
			}
		}

		// Token: 0x06011348 RID: 70472 RVA: 0x004771C4 File Offset: 0x004753C4
		private void CreateDefaultSoldier()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateDefaultSoldier_hotfix != null)
			{
				this.m_CreateDefaultSoldier_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_heroSoldierSkinItemPrefab);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			HeroOrSoliderSkinUIController component = gameObject.GetComponent<HeroOrSoliderSkinUIController>();
			component.EventOnItemClick += this.OnSkinItemClick;
			component.InitDefaultSoldierSkinItem(this.m_hero, this.m_soldierInfo);
			gameObject.transform.SetParent(this.m_scrollContent.transform, false);
			this.m_itemCtrlList.Add(component);
			if (this.m_hero.GetSoldierSkinId(this.m_soldierInfo.ID) == 0)
			{
				this.m_curSelectHeroSkinItemCtrl = component;
			}
		}

		// Token: 0x06011349 RID: 70473 RVA: 0x004772A8 File Offset: 0x004754A8
		private void SetSoldierInfoPanel(HeroOrSoliderSkinUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierInfoPanelHeroOrSoliderSkinUIController_hotfix != null)
			{
				this.m_SetSoldierInfoPanelHeroOrSoliderSkinUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ctrl.IsDefaultSkin)
			{
				this.m_infoTitleText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DefaultName);
				this.m_infoDescText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_SoldierDefaultDesc);
				if (this.m_hero.GetSoldierSkinId(this.m_soldierInfo.ID) != 0)
				{
					this.m_infoPanelStateCtrl.SetToUIState("NormalSoldier", false, true);
				}
				else
				{
					this.m_infoPanelStateCtrl.SetToUIState("InUseSoldier", false, true);
				}
				this.m_infoFromDetailText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_SoldierDefaultPathDesc);
			}
			else
			{
				ConfigDataSoldierSkinInfo soldierSkinInfo = ctrl.SoldierSkinInfo;
				this.m_infoTitleText.text = soldierSkinInfo.Name;
				this.m_infoDescText.text = soldierSkinInfo.Desc;
				if (this.m_playerContext.HasOwn(GoodsType.GoodsType_SoldierSkin, soldierSkinInfo.ID))
				{
					if (this.m_hero.GetSoldierSkinId(this.m_soldierInfo.ID) != soldierSkinInfo.ID)
					{
						this.m_infoPanelStateCtrl.SetToUIState("NormalSoldier", false, true);
					}
					else
					{
						this.m_infoPanelStateCtrl.SetToUIState("InUseSoldier", false, true);
					}
				}
				else
				{
					if (ctrl.ModelSkinResourceInfo == null)
					{
						return;
					}
					ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(ctrl.SoldierSkinInfo.FixedStoreItemId);
					if (configDataFixedStoreItemInfo == null || configDataFixedStoreItemInfo.ShowEndTime == DateTime.MaxValue.ToString())
					{
						if (ctrl.SoldierSkinInfo.GetPathDesc != string.Empty)
						{
							this.m_infoFromDetailText.text = ctrl.SoldierSkinInfo.GetPathDesc;
							this.m_infoPanelStateCtrl.SetToUIState("LockPanelSoldier", false, true);
						}
						else
						{
							this.m_infoPanelStateCtrl.SetToUIState("LockPanelSoldierWithButton", false, true);
						}
					}
					else
					{
						DateTime t = DateTime.Parse(configDataFixedStoreItemInfo.ShowEndTime);
						DateTime t2 = DateTime.Parse(configDataFixedStoreItemInfo.ShowStartTime);
						DateTime serverTime = this.m_playerContext.GetServerTime();
						if (t < serverTime || (!configDataFixedStoreItemInfo.IsFirstOnSale && t2 > serverTime))
						{
							this.m_infoFromDetailText.text = ctrl.SoldierSkinInfo.GetPathDesc;
							this.m_infoPanelStateCtrl.SetToUIState("LockPanelSoldier", false, true);
						}
						else
						{
							this.m_infoPanelStateCtrl.SetToUIState("LockPanelSoldierWithButton", false, true);
						}
					}
				}
			}
		}

		// Token: 0x0601134A RID: 70474 RVA: 0x00477584 File Offset: 0x00475784
		private void OnSkinItemClick(HeroOrSoliderSkinUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkinItemClickHeroOrSoliderSkinUIController_hotfix != null)
			{
				this.m_OnSkinItemClickHeroOrSoliderSkinUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curSelectHeroSkinItemCtrl != null)
			{
				this.m_curSelectHeroSkinItemCtrl.ShowSelectImage(false);
			}
			this.m_curSelectHeroSkinItemCtrl = ctrl;
			this.m_curSelectHeroSkinItemCtrl.ShowSelectImage(true);
			if (ctrl.IsHeroSkin)
			{
				this.SetHeroInfoPanel(ctrl);
			}
			else
			{
				this.SetSoldierInfoPanel(ctrl);
			}
		}

		// Token: 0x0601134B RID: 70475 RVA: 0x00477644 File Offset: 0x00475844
		private void OnShowHeroToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowHeroToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnShowHeroToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (LocalConfig.Instance.Data.OnlyShowCurJobSkin == isOn)
			{
				return;
			}
			LocalConfig.Instance.SetIsOnlyShowCurJobSkin(isOn);
			this.ShowHeroSkin();
		}

		// Token: 0x0601134C RID: 70476 RVA: 0x004776DC File Offset: 0x004758DC
		private void OnShowSoldierToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowSoldierToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnShowSoldierToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (LocalConfig.Instance.Data.SetSkinToAllSoldier == isOn)
			{
				return;
			}
			LocalConfig.Instance.SetIsSetSkinToAllSoldier(isOn);
			this.ShowSoldierSkin();
		}

		// Token: 0x0601134D RID: 70477 RVA: 0x00477774 File Offset: 0x00475974
		private void OnInfoUnavailableButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInfoUnavailableButtonClick_hotfix != null)
			{
				this.m_OnInfoUnavailableButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_CurrentJobCantWearSkin, 2f, null, true);
		}

		// Token: 0x0601134E RID: 70478 RVA: 0x004777EC File Offset: 0x004759EC
		private void OnInfoBuyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInfoBuyButtonClick_hotfix != null)
			{
				this.m_OnInfoBuyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isFromHeroTab)
			{
				if (this.EventOnBuyHeroSkin != null)
				{
					this.EventOnBuyHeroSkin(this.m_curSelectHeroSkinItemCtrl.HeroSkinInfo.ID);
				}
			}
			else if (this.EventOnBuySoldierSkin != null)
			{
				this.EventOnBuySoldierSkin(this.m_curSelectHeroSkinItemCtrl.SoldierSkinInfo.ID);
			}
		}

		// Token: 0x0601134F RID: 70479 RVA: 0x004778A8 File Offset: 0x00475AA8
		private void OnInfoSwitchButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInfoSwitchButtonClick_hotfix != null)
			{
				this.m_OnInfoSwitchButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_curSelectHeroSkinItemCtrl.IsDefaultSkin)
			{
				if (this.m_isFromHeroTab)
				{
					int heroId = this.m_hero.HeroId;
					int num = this.m_curSelectHeroSkinItemCtrl.JobConnectionInfo.ID;
					if (this.m_hero.GetActiveJob().JobRelatedId != this.m_curSelectHeroSkinItemCtrl.JobConnectionInfo.ID)
					{
						foreach (JobConnection2SkinResource jobConnection2SkinResource in this.m_curSelectHeroSkinItemCtrl.HeroSkinInfo.SpecifiedModelSkinResource)
						{
							num = jobConnection2SkinResource.JobConnectionId;
							if (jobConnection2SkinResource.JobConnectionId == this.m_hero.GetActiveJob().JobRelatedId)
							{
								break;
							}
						}
					}
					int id = this.m_curSelectHeroSkinItemCtrl.HeroSkinInfo.ID;
					int num2 = this.m_playerContext.CanWearModelSkin(heroId, num, id);
					if (num2 == 0)
					{
						if (this.EventOnWearModelSkin != null)
						{
							this.EventOnWearModelSkin(heroId, num, id);
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(num2, 2f, null, true);
					}
				}
				else
				{
					int num3 = this.m_playerContext.CanWearSoldierSkin(this.m_hero.HeroId, this.m_curSelectHeroSkinItemCtrl.SoldierInfo.ID, this.m_curSelectHeroSkinItemCtrl.SoldierSkinInfo.ID);
					if (num3 == 0)
					{
						if (this.EventOnWearSoldierSkin != null)
						{
							this.EventOnWearSoldierSkin(this.m_hero.HeroId, this.m_curSelectHeroSkinItemCtrl.SoldierInfo.ID, this.m_curSelectHeroSkinItemCtrl.SoldierSkinInfo.ID);
						}
					}
					else if (num3 == -619)
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_HeroNotHaveThisSoldierCantWearSkin, 2f, null, true);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(num3, 2f, null, true);
					}
				}
			}
			else if (this.m_isFromHeroTab)
			{
				int num4 = this.m_playerContext.CanTakeOffModelSkin(this.m_hero.HeroId, this.m_curSelectHeroSkinItemCtrl.JobConnectionInfo.ID);
				if (num4 == 0)
				{
					if (this.EventOnTakeOffModelSkin != null)
					{
						this.EventOnTakeOffModelSkin(this.m_hero.HeroId, this.m_curSelectHeroSkinItemCtrl.JobConnectionInfo.ID);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num4, 2f, null, true);
				}
			}
			else
			{
				int num5 = this.m_playerContext.CanTakeOffSoldierSkin(this.m_hero.HeroId, this.m_curSelectHeroSkinItemCtrl.SoldierInfo.ID);
				if (num5 == 0)
				{
					if (this.EventOnTakeOffSoldierSkin != null)
					{
						this.EventOnTakeOffSoldierSkin(this.m_hero.HeroId, this.m_curSelectHeroSkinItemCtrl.SoldierInfo.ID);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num5, 2f, null, true);
				}
			}
		}

		// Token: 0x06011350 RID: 70480 RVA: 0x00477C04 File Offset: 0x00475E04
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
			CommonUIStateController component = this.m_rootGo.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateClose(component, "Close", delegate
			{
				if (this.EventOnReturn != null)
				{
					this.EventOnReturn(this.m_isFromHeroTab);
				}
				this.m_curSelectHeroSkinItemCtrl = null;
			}, false, true);
		}

		// Token: 0x140003AF RID: 943
		// (add) Token: 0x06011351 RID: 70481 RVA: 0x00477C8C File Offset: 0x00475E8C
		// (remove) Token: 0x06011352 RID: 70482 RVA: 0x00477D28 File Offset: 0x00475F28
		public event Action<bool> EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction`1_hotfix != null)
				{
					this.m_add_EventOnReturnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnReturn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnReturn, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction`1_hotfix != null)
				{
					this.m_remove_EventOnReturnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnReturn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnReturn, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003B0 RID: 944
		// (add) Token: 0x06011353 RID: 70483 RVA: 0x00477DC4 File Offset: 0x00475FC4
		// (remove) Token: 0x06011354 RID: 70484 RVA: 0x00477E60 File Offset: 0x00476060
		public event Action<int> EventOnBuyHeroSkin
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBuyHeroSkinAction`1_hotfix != null)
				{
					this.m_add_EventOnBuyHeroSkinAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnBuyHeroSkin;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnBuyHeroSkin, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBuyHeroSkinAction`1_hotfix != null)
				{
					this.m_remove_EventOnBuyHeroSkinAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnBuyHeroSkin;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnBuyHeroSkin, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003B1 RID: 945
		// (add) Token: 0x06011355 RID: 70485 RVA: 0x00477EFC File Offset: 0x004760FC
		// (remove) Token: 0x06011356 RID: 70486 RVA: 0x00477F98 File Offset: 0x00476198
		public event Action<int> EventOnBuySoldierSkin
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBuySoldierSkinAction`1_hotfix != null)
				{
					this.m_add_EventOnBuySoldierSkinAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnBuySoldierSkin;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnBuySoldierSkin, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBuySoldierSkinAction`1_hotfix != null)
				{
					this.m_remove_EventOnBuySoldierSkinAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnBuySoldierSkin;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnBuySoldierSkin, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003B2 RID: 946
		// (add) Token: 0x06011357 RID: 70487 RVA: 0x00478034 File Offset: 0x00476234
		// (remove) Token: 0x06011358 RID: 70488 RVA: 0x004780D0 File Offset: 0x004762D0
		public event Action<int, int> EventOnTakeOffModelSkin
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTakeOffModelSkinAction`2_hotfix != null)
				{
					this.m_add_EventOnTakeOffModelSkinAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnTakeOffModelSkin;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnTakeOffModelSkin, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTakeOffModelSkinAction`2_hotfix != null)
				{
					this.m_remove_EventOnTakeOffModelSkinAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnTakeOffModelSkin;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnTakeOffModelSkin, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003B3 RID: 947
		// (add) Token: 0x06011359 RID: 70489 RVA: 0x0047816C File Offset: 0x0047636C
		// (remove) Token: 0x0601135A RID: 70490 RVA: 0x00478208 File Offset: 0x00476408
		public event Action<int, int> EventOnTakeOffSoldierSkin
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTakeOffSoldierSkinAction`2_hotfix != null)
				{
					this.m_add_EventOnTakeOffSoldierSkinAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnTakeOffSoldierSkin;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnTakeOffSoldierSkin, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTakeOffSoldierSkinAction`2_hotfix != null)
				{
					this.m_remove_EventOnTakeOffSoldierSkinAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnTakeOffSoldierSkin;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnTakeOffSoldierSkin, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003B4 RID: 948
		// (add) Token: 0x0601135B RID: 70491 RVA: 0x004782A4 File Offset: 0x004764A4
		// (remove) Token: 0x0601135C RID: 70492 RVA: 0x00478340 File Offset: 0x00476540
		public event Action<int, int, int> EventOnWearModelSkin
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnWearModelSkinAction`3_hotfix != null)
				{
					this.m_add_EventOnWearModelSkinAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, int> action = this.EventOnWearModelSkin;
				Action<int, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, int>>(ref this.EventOnWearModelSkin, (Action<int, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnWearModelSkinAction`3_hotfix != null)
				{
					this.m_remove_EventOnWearModelSkinAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, int> action = this.EventOnWearModelSkin;
				Action<int, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, int>>(ref this.EventOnWearModelSkin, (Action<int, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003B5 RID: 949
		// (add) Token: 0x0601135D RID: 70493 RVA: 0x004783DC File Offset: 0x004765DC
		// (remove) Token: 0x0601135E RID: 70494 RVA: 0x00478478 File Offset: 0x00476678
		public event Action<int, int, int> EventOnWearSoldierSkin
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnWearSoldierSkinAction`3_hotfix != null)
				{
					this.m_add_EventOnWearSoldierSkinAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, int> action = this.EventOnWearSoldierSkin;
				Action<int, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, int>>(ref this.EventOnWearSoldierSkin, (Action<int, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnWearSoldierSkinAction`3_hotfix != null)
				{
					this.m_remove_EventOnWearSoldierSkinAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, int> action = this.EventOnWearSoldierSkin;
				Action<int, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, int>>(ref this.EventOnWearSoldierSkin, (Action<int, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0601135F RID: 70495 RVA: 0x00478514 File Offset: 0x00476714
		// (set) Token: 0x06011360 RID: 70496 RVA: 0x00478534 File Offset: 0x00476734
		[DoNotToLua]
		public new HeroSoldierSkinUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroSoldierSkinUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011361 RID: 70497 RVA: 0x00478540 File Offset: 0x00476740
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011362 RID: 70498 RVA: 0x0047854C File Offset: 0x0047674C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011363 RID: 70499 RVA: 0x00478554 File Offset: 0x00476754
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011364 RID: 70500 RVA: 0x0047855C File Offset: 0x0047675C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011365 RID: 70501 RVA: 0x00478570 File Offset: 0x00476770
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011366 RID: 70502 RVA: 0x00478578 File Offset: 0x00476778
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011367 RID: 70503 RVA: 0x00478584 File Offset: 0x00476784
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011368 RID: 70504 RVA: 0x00478590 File Offset: 0x00476790
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011369 RID: 70505 RVA: 0x0047859C File Offset: 0x0047679C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601136A RID: 70506 RVA: 0x004785A8 File Offset: 0x004767A8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601136B RID: 70507 RVA: 0x004785B4 File Offset: 0x004767B4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601136C RID: 70508 RVA: 0x004785C0 File Offset: 0x004767C0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601136D RID: 70509 RVA: 0x004785CC File Offset: 0x004767CC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601136E RID: 70510 RVA: 0x004785D8 File Offset: 0x004767D8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601136F RID: 70511 RVA: 0x004785E4 File Offset: 0x004767E4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011370 RID: 70512 RVA: 0x004785EC File Offset: 0x004767EC
		private void __callDele_EventOnReturn(bool obj)
		{
			Action<bool> eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn(obj);
			}
		}

		// Token: 0x06011371 RID: 70513 RVA: 0x00478610 File Offset: 0x00476810
		private void __clearDele_EventOnReturn(bool obj)
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06011372 RID: 70514 RVA: 0x0047861C File Offset: 0x0047681C
		private void __callDele_EventOnBuyHeroSkin(int obj)
		{
			Action<int> eventOnBuyHeroSkin = this.EventOnBuyHeroSkin;
			if (eventOnBuyHeroSkin != null)
			{
				eventOnBuyHeroSkin(obj);
			}
		}

		// Token: 0x06011373 RID: 70515 RVA: 0x00478640 File Offset: 0x00476840
		private void __clearDele_EventOnBuyHeroSkin(int obj)
		{
			this.EventOnBuyHeroSkin = null;
		}

		// Token: 0x06011374 RID: 70516 RVA: 0x0047864C File Offset: 0x0047684C
		private void __callDele_EventOnBuySoldierSkin(int obj)
		{
			Action<int> eventOnBuySoldierSkin = this.EventOnBuySoldierSkin;
			if (eventOnBuySoldierSkin != null)
			{
				eventOnBuySoldierSkin(obj);
			}
		}

		// Token: 0x06011375 RID: 70517 RVA: 0x00478670 File Offset: 0x00476870
		private void __clearDele_EventOnBuySoldierSkin(int obj)
		{
			this.EventOnBuySoldierSkin = null;
		}

		// Token: 0x06011376 RID: 70518 RVA: 0x0047867C File Offset: 0x0047687C
		private void __callDele_EventOnTakeOffModelSkin(int arg1, int arg2)
		{
			Action<int, int> eventOnTakeOffModelSkin = this.EventOnTakeOffModelSkin;
			if (eventOnTakeOffModelSkin != null)
			{
				eventOnTakeOffModelSkin(arg1, arg2);
			}
		}

		// Token: 0x06011377 RID: 70519 RVA: 0x004786A0 File Offset: 0x004768A0
		private void __clearDele_EventOnTakeOffModelSkin(int arg1, int arg2)
		{
			this.EventOnTakeOffModelSkin = null;
		}

		// Token: 0x06011378 RID: 70520 RVA: 0x004786AC File Offset: 0x004768AC
		private void __callDele_EventOnTakeOffSoldierSkin(int arg1, int arg2)
		{
			Action<int, int> eventOnTakeOffSoldierSkin = this.EventOnTakeOffSoldierSkin;
			if (eventOnTakeOffSoldierSkin != null)
			{
				eventOnTakeOffSoldierSkin(arg1, arg2);
			}
		}

		// Token: 0x06011379 RID: 70521 RVA: 0x004786D0 File Offset: 0x004768D0
		private void __clearDele_EventOnTakeOffSoldierSkin(int arg1, int arg2)
		{
			this.EventOnTakeOffSoldierSkin = null;
		}

		// Token: 0x0601137A RID: 70522 RVA: 0x004786DC File Offset: 0x004768DC
		private void __callDele_EventOnWearModelSkin(int arg1, int arg2, int arg3)
		{
			Action<int, int, int> eventOnWearModelSkin = this.EventOnWearModelSkin;
			if (eventOnWearModelSkin != null)
			{
				eventOnWearModelSkin(arg1, arg2, arg3);
			}
		}

		// Token: 0x0601137B RID: 70523 RVA: 0x00478700 File Offset: 0x00476900
		private void __clearDele_EventOnWearModelSkin(int arg1, int arg2, int arg3)
		{
			this.EventOnWearModelSkin = null;
		}

		// Token: 0x0601137C RID: 70524 RVA: 0x0047870C File Offset: 0x0047690C
		private void __callDele_EventOnWearSoldierSkin(int arg1, int arg2, int arg3)
		{
			Action<int, int, int> eventOnWearSoldierSkin = this.EventOnWearSoldierSkin;
			if (eventOnWearSoldierSkin != null)
			{
				eventOnWearSoldierSkin(arg1, arg2, arg3);
			}
		}

		// Token: 0x0601137D RID: 70525 RVA: 0x00478730 File Offset: 0x00476930
		private void __clearDele_EventOnWearSoldierSkin(int arg1, int arg2, int arg3)
		{
			this.EventOnWearSoldierSkin = null;
		}

		// Token: 0x0601137F RID: 70527 RVA: 0x00478764 File Offset: 0x00476964
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
					this.m_UpdateViewInHeroSoldierSkinHeroBooleanConfigDataSoldierInfo_hotfix = (luaObj.RawGet("UpdateViewInHeroSoldierSkin") as LuaFunction);
					this.m_LateUpdate_hotfix = (luaObj.RawGet("LateUpdate") as LuaFunction);
					this.m_ShowHeroSkin_hotfix = (luaObj.RawGet("ShowHeroSkin") as LuaFunction);
					this.m_CreatDefaultHeroSkin_hotfix = (luaObj.RawGet("CreatDefaultHeroSkin") as LuaFunction);
					this.m_SetHeroInfoPanelHeroOrSoliderSkinUIController_hotfix = (luaObj.RawGet("SetHeroInfoPanel") as LuaFunction);
					this.m_SetHeroButtonStateHeroOrSoliderSkinUIController_hotfix = (luaObj.RawGet("SetHeroButtonState") as LuaFunction);
					this.m_ShowSoldierSkin_hotfix = (luaObj.RawGet("ShowSoldierSkin") as LuaFunction);
					this.m_CreateDefaultSoldier_hotfix = (luaObj.RawGet("CreateDefaultSoldier") as LuaFunction);
					this.m_SetSoldierInfoPanelHeroOrSoliderSkinUIController_hotfix = (luaObj.RawGet("SetSoldierInfoPanel") as LuaFunction);
					this.m_OnSkinItemClickHeroOrSoliderSkinUIController_hotfix = (luaObj.RawGet("OnSkinItemClick") as LuaFunction);
					this.m_OnShowHeroToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnShowHeroToggleValueChanged") as LuaFunction);
					this.m_OnShowSoldierToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnShowSoldierToggleValueChanged") as LuaFunction);
					this.m_OnInfoUnavailableButtonClick_hotfix = (luaObj.RawGet("OnInfoUnavailableButtonClick") as LuaFunction);
					this.m_OnInfoBuyButtonClick_hotfix = (luaObj.RawGet("OnInfoBuyButtonClick") as LuaFunction);
					this.m_OnInfoSwitchButtonClick_hotfix = (luaObj.RawGet("OnInfoSwitchButtonClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction`1_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction`1_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnBuyHeroSkinAction`1_hotfix = (luaObj.RawGet("add_EventOnBuyHeroSkin") as LuaFunction);
					this.m_remove_EventOnBuyHeroSkinAction`1_hotfix = (luaObj.RawGet("remove_EventOnBuyHeroSkin") as LuaFunction);
					this.m_add_EventOnBuySoldierSkinAction`1_hotfix = (luaObj.RawGet("add_EventOnBuySoldierSkin") as LuaFunction);
					this.m_remove_EventOnBuySoldierSkinAction`1_hotfix = (luaObj.RawGet("remove_EventOnBuySoldierSkin") as LuaFunction);
					this.m_add_EventOnTakeOffModelSkinAction`2_hotfix = (luaObj.RawGet("add_EventOnTakeOffModelSkin") as LuaFunction);
					this.m_remove_EventOnTakeOffModelSkinAction`2_hotfix = (luaObj.RawGet("remove_EventOnTakeOffModelSkin") as LuaFunction);
					this.m_add_EventOnTakeOffSoldierSkinAction`2_hotfix = (luaObj.RawGet("add_EventOnTakeOffSoldierSkin") as LuaFunction);
					this.m_remove_EventOnTakeOffSoldierSkinAction`2_hotfix = (luaObj.RawGet("remove_EventOnTakeOffSoldierSkin") as LuaFunction);
					this.m_add_EventOnWearModelSkinAction`3_hotfix = (luaObj.RawGet("add_EventOnWearModelSkin") as LuaFunction);
					this.m_remove_EventOnWearModelSkinAction`3_hotfix = (luaObj.RawGet("remove_EventOnWearModelSkin") as LuaFunction);
					this.m_add_EventOnWearSoldierSkinAction`3_hotfix = (luaObj.RawGet("add_EventOnWearSoldierSkin") as LuaFunction);
					this.m_remove_EventOnWearSoldierSkinAction`3_hotfix = (luaObj.RawGet("remove_EventOnWearSoldierSkin") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011380 RID: 70528 RVA: 0x00478B38 File Offset: 0x00476D38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSoldierSkinUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009DEF RID: 40431
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04009DF0 RID: 40432
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rootGo;

		// Token: 0x04009DF1 RID: 40433
		[AutoBind("./LayoutRoot/ListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scrollContent;

		// Token: 0x04009DF2 RID: 40434
		[AutoBind("./LayoutRoot/ShowTogglePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_showToggleStateCtrl;

		// Token: 0x04009DF3 RID: 40435
		[AutoBind("./LayoutRoot/ShowTogglePanel/HeroCurrentButton", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_showHeroToggle;

		// Token: 0x04009DF4 RID: 40436
		[AutoBind("./LayoutRoot/ShowTogglePanel/SoldierCurrentButton", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_showSoliderToggle;

		// Token: 0x04009DF5 RID: 40437
		[AutoBind("./ResonanceInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_infoPanelStateCtrl;

		// Token: 0x04009DF6 RID: 40438
		[AutoBind("./ResonanceInfoPanel/InfoPanel/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoTitleText;

		// Token: 0x04009DF7 RID: 40439
		[AutoBind("./ResonanceInfoPanel/InfoPanel/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoDescText;

		// Token: 0x04009DF8 RID: 40440
		[AutoBind("./ResonanceInfoPanel/InfoPanel/HeroInfoPanel/JobScrollView/Viewport/JobGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoHeroJobContent;

		// Token: 0x04009DF9 RID: 40441
		[AutoBind("./ResonanceInfoPanel/ButtonGroup/GetOn", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoSwitchButton;

		// Token: 0x04009DFA RID: 40442
		[AutoBind("./ResonanceInfoPanel/ButtonGroup/Unavailable", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoUnavailableButton;

		// Token: 0x04009DFB RID: 40443
		[AutoBind("./ResonanceInfoPanel/ButtonGroup/Buy", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoBuyButton;

		// Token: 0x04009DFC RID: 40444
		[AutoBind("./ResonanceInfoPanel/ButtonGroup/FromText/Title/DetailText ", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoFromDetailText;

		// Token: 0x04009DFD RID: 40445
		[AutoBind("./Prefab/Hero&SoldierSkinItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroSoldierSkinItemPrefab;

		// Token: 0x04009E05 RID: 40453
		private Hero m_hero;

		// Token: 0x04009E06 RID: 40454
		private bool m_isFromHeroTab = true;

		// Token: 0x04009E07 RID: 40455
		private ConfigDataSoldierInfo m_soldierInfo;

		// Token: 0x04009E08 RID: 40456
		private HeroOrSoliderSkinUIController m_curSelectHeroSkinItemCtrl;

		// Token: 0x04009E09 RID: 40457
		private List<HeroOrSoliderSkinUIController> m_itemCtrlList = new List<HeroOrSoliderSkinUIController>();

		// Token: 0x04009E0A RID: 40458
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009E0B RID: 40459
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009E0C RID: 40460
		[DoNotToLua]
		private HeroSoldierSkinUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009E0D RID: 40461
		[CompilerGenerated]
		private static Comparison<int> <>f__mg$cache0;

		// Token: 0x04009E0E RID: 40462
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009E0F RID: 40463
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009E10 RID: 40464
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009E11 RID: 40465
		private LuaFunction m_Open_hotfix;

		// Token: 0x04009E12 RID: 40466
		private LuaFunction m_UpdateViewInHeroSoldierSkinHeroBooleanConfigDataSoldierInfo_hotfix;

		// Token: 0x04009E13 RID: 40467
		private LuaFunction m_LateUpdate_hotfix;

		// Token: 0x04009E14 RID: 40468
		private LuaFunction m_ShowHeroSkin_hotfix;

		// Token: 0x04009E15 RID: 40469
		private LuaFunction m_CreatDefaultHeroSkin_hotfix;

		// Token: 0x04009E16 RID: 40470
		private LuaFunction m_SetHeroInfoPanelHeroOrSoliderSkinUIController_hotfix;

		// Token: 0x04009E17 RID: 40471
		private LuaFunction m_SetHeroButtonStateHeroOrSoliderSkinUIController_hotfix;

		// Token: 0x04009E18 RID: 40472
		private LuaFunction m_ShowSoldierSkin_hotfix;

		// Token: 0x04009E19 RID: 40473
		private LuaFunction m_CreateDefaultSoldier_hotfix;

		// Token: 0x04009E1A RID: 40474
		private LuaFunction m_SetSoldierInfoPanelHeroOrSoliderSkinUIController_hotfix;

		// Token: 0x04009E1B RID: 40475
		private LuaFunction m_OnSkinItemClickHeroOrSoliderSkinUIController_hotfix;

		// Token: 0x04009E1C RID: 40476
		private LuaFunction m_OnShowHeroToggleValueChangedBoolean_hotfix;

		// Token: 0x04009E1D RID: 40477
		private LuaFunction m_OnShowSoldierToggleValueChangedBoolean_hotfix;

		// Token: 0x04009E1E RID: 40478
		private LuaFunction m_OnInfoUnavailableButtonClick_hotfix;

		// Token: 0x04009E1F RID: 40479
		private LuaFunction m_OnInfoBuyButtonClick_hotfix;

		// Token: 0x04009E20 RID: 40480
		private LuaFunction m_OnInfoSwitchButtonClick_hotfix;

		// Token: 0x04009E21 RID: 40481
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04009E22 RID: 40482
		private LuaFunction m_add_EventOnReturnAction;

		// Token: 0x04009E23 RID: 40483
		private LuaFunction m_remove_EventOnReturnAction;

		// Token: 0x04009E24 RID: 40484
		private LuaFunction m_add_EventOnBuyHeroSkinAction;

		// Token: 0x04009E25 RID: 40485
		private LuaFunction m_remove_EventOnBuyHeroSkinAction;

		// Token: 0x04009E26 RID: 40486
		private LuaFunction m_add_EventOnBuySoldierSkinAction;

		// Token: 0x04009E27 RID: 40487
		private LuaFunction m_remove_EventOnBuySoldierSkinAction;

		// Token: 0x04009E28 RID: 40488
		private LuaFunction m_add_EventOnTakeOffModelSkinAction;

		// Token: 0x04009E29 RID: 40489
		private LuaFunction m_remove_EventOnTakeOffModelSkinAction;

		// Token: 0x04009E2A RID: 40490
		private LuaFunction m_add_EventOnTakeOffSoldierSkinAction;

		// Token: 0x04009E2B RID: 40491
		private LuaFunction m_remove_EventOnTakeOffSoldierSkinAction;

		// Token: 0x04009E2C RID: 40492
		private LuaFunction m_add_EventOnWearModelSkinAction;

		// Token: 0x04009E2D RID: 40493
		private LuaFunction m_remove_EventOnWearModelSkinAction;

		// Token: 0x04009E2E RID: 40494
		private LuaFunction m_add_EventOnWearSoldierSkinAction;

		// Token: 0x04009E2F RID: 40495
		private LuaFunction m_remove_EventOnWearSoldierSkinAction;

		// Token: 0x02000E0B RID: 3595
		public new class LuaExportHelper
		{
			// Token: 0x06011381 RID: 70529 RVA: 0x00478BA0 File Offset: 0x00476DA0
			public LuaExportHelper(HeroSoldierSkinUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011382 RID: 70530 RVA: 0x00478BB0 File Offset: 0x00476DB0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011383 RID: 70531 RVA: 0x00478BC0 File Offset: 0x00476DC0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011384 RID: 70532 RVA: 0x00478BD0 File Offset: 0x00476DD0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011385 RID: 70533 RVA: 0x00478BE0 File Offset: 0x00476DE0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011386 RID: 70534 RVA: 0x00478BF8 File Offset: 0x00476DF8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011387 RID: 70535 RVA: 0x00478C08 File Offset: 0x00476E08
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011388 RID: 70536 RVA: 0x00478C18 File Offset: 0x00476E18
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011389 RID: 70537 RVA: 0x00478C28 File Offset: 0x00476E28
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601138A RID: 70538 RVA: 0x00478C38 File Offset: 0x00476E38
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601138B RID: 70539 RVA: 0x00478C48 File Offset: 0x00476E48
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601138C RID: 70540 RVA: 0x00478C58 File Offset: 0x00476E58
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601138D RID: 70541 RVA: 0x00478C68 File Offset: 0x00476E68
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601138E RID: 70542 RVA: 0x00478C78 File Offset: 0x00476E78
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601138F RID: 70543 RVA: 0x00478C88 File Offset: 0x00476E88
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011390 RID: 70544 RVA: 0x00478C98 File Offset: 0x00476E98
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011391 RID: 70545 RVA: 0x00478CA8 File Offset: 0x00476EA8
			public void __callDele_EventOnReturn(bool obj)
			{
				this.m_owner.__callDele_EventOnReturn(obj);
			}

			// Token: 0x06011392 RID: 70546 RVA: 0x00478CB8 File Offset: 0x00476EB8
			public void __clearDele_EventOnReturn(bool obj)
			{
				this.m_owner.__clearDele_EventOnReturn(obj);
			}

			// Token: 0x06011393 RID: 70547 RVA: 0x00478CC8 File Offset: 0x00476EC8
			public void __callDele_EventOnBuyHeroSkin(int obj)
			{
				this.m_owner.__callDele_EventOnBuyHeroSkin(obj);
			}

			// Token: 0x06011394 RID: 70548 RVA: 0x00478CD8 File Offset: 0x00476ED8
			public void __clearDele_EventOnBuyHeroSkin(int obj)
			{
				this.m_owner.__clearDele_EventOnBuyHeroSkin(obj);
			}

			// Token: 0x06011395 RID: 70549 RVA: 0x00478CE8 File Offset: 0x00476EE8
			public void __callDele_EventOnBuySoldierSkin(int obj)
			{
				this.m_owner.__callDele_EventOnBuySoldierSkin(obj);
			}

			// Token: 0x06011396 RID: 70550 RVA: 0x00478CF8 File Offset: 0x00476EF8
			public void __clearDele_EventOnBuySoldierSkin(int obj)
			{
				this.m_owner.__clearDele_EventOnBuySoldierSkin(obj);
			}

			// Token: 0x06011397 RID: 70551 RVA: 0x00478D08 File Offset: 0x00476F08
			public void __callDele_EventOnTakeOffModelSkin(int arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnTakeOffModelSkin(arg1, arg2);
			}

			// Token: 0x06011398 RID: 70552 RVA: 0x00478D18 File Offset: 0x00476F18
			public void __clearDele_EventOnTakeOffModelSkin(int arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnTakeOffModelSkin(arg1, arg2);
			}

			// Token: 0x06011399 RID: 70553 RVA: 0x00478D28 File Offset: 0x00476F28
			public void __callDele_EventOnTakeOffSoldierSkin(int arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnTakeOffSoldierSkin(arg1, arg2);
			}

			// Token: 0x0601139A RID: 70554 RVA: 0x00478D38 File Offset: 0x00476F38
			public void __clearDele_EventOnTakeOffSoldierSkin(int arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnTakeOffSoldierSkin(arg1, arg2);
			}

			// Token: 0x0601139B RID: 70555 RVA: 0x00478D48 File Offset: 0x00476F48
			public void __callDele_EventOnWearModelSkin(int arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnWearModelSkin(arg1, arg2, arg3);
			}

			// Token: 0x0601139C RID: 70556 RVA: 0x00478D58 File Offset: 0x00476F58
			public void __clearDele_EventOnWearModelSkin(int arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnWearModelSkin(arg1, arg2, arg3);
			}

			// Token: 0x0601139D RID: 70557 RVA: 0x00478D68 File Offset: 0x00476F68
			public void __callDele_EventOnWearSoldierSkin(int arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnWearSoldierSkin(arg1, arg2, arg3);
			}

			// Token: 0x0601139E RID: 70558 RVA: 0x00478D78 File Offset: 0x00476F78
			public void __clearDele_EventOnWearSoldierSkin(int arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnWearSoldierSkin(arg1, arg2, arg3);
			}

			// Token: 0x1700350C RID: 13580
			// (get) Token: 0x0601139F RID: 70559 RVA: 0x00478D88 File Offset: 0x00476F88
			// (set) Token: 0x060113A0 RID: 70560 RVA: 0x00478D98 File Offset: 0x00476F98
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

			// Token: 0x1700350D RID: 13581
			// (get) Token: 0x060113A1 RID: 70561 RVA: 0x00478DA8 File Offset: 0x00476FA8
			// (set) Token: 0x060113A2 RID: 70562 RVA: 0x00478DB8 File Offset: 0x00476FB8
			public GameObject m_rootGo
			{
				get
				{
					return this.m_owner.m_rootGo;
				}
				set
				{
					this.m_owner.m_rootGo = value;
				}
			}

			// Token: 0x1700350E RID: 13582
			// (get) Token: 0x060113A3 RID: 70563 RVA: 0x00478DC8 File Offset: 0x00476FC8
			// (set) Token: 0x060113A4 RID: 70564 RVA: 0x00478DD8 File Offset: 0x00476FD8
			public GameObject m_scrollContent
			{
				get
				{
					return this.m_owner.m_scrollContent;
				}
				set
				{
					this.m_owner.m_scrollContent = value;
				}
			}

			// Token: 0x1700350F RID: 13583
			// (get) Token: 0x060113A5 RID: 70565 RVA: 0x00478DE8 File Offset: 0x00476FE8
			// (set) Token: 0x060113A6 RID: 70566 RVA: 0x00478DF8 File Offset: 0x00476FF8
			public CommonUIStateController m_showToggleStateCtrl
			{
				get
				{
					return this.m_owner.m_showToggleStateCtrl;
				}
				set
				{
					this.m_owner.m_showToggleStateCtrl = value;
				}
			}

			// Token: 0x17003510 RID: 13584
			// (get) Token: 0x060113A7 RID: 70567 RVA: 0x00478E08 File Offset: 0x00477008
			// (set) Token: 0x060113A8 RID: 70568 RVA: 0x00478E18 File Offset: 0x00477018
			public Toggle m_showHeroToggle
			{
				get
				{
					return this.m_owner.m_showHeroToggle;
				}
				set
				{
					this.m_owner.m_showHeroToggle = value;
				}
			}

			// Token: 0x17003511 RID: 13585
			// (get) Token: 0x060113A9 RID: 70569 RVA: 0x00478E28 File Offset: 0x00477028
			// (set) Token: 0x060113AA RID: 70570 RVA: 0x00478E38 File Offset: 0x00477038
			public Toggle m_showSoliderToggle
			{
				get
				{
					return this.m_owner.m_showSoliderToggle;
				}
				set
				{
					this.m_owner.m_showSoliderToggle = value;
				}
			}

			// Token: 0x17003512 RID: 13586
			// (get) Token: 0x060113AB RID: 70571 RVA: 0x00478E48 File Offset: 0x00477048
			// (set) Token: 0x060113AC RID: 70572 RVA: 0x00478E58 File Offset: 0x00477058
			public CommonUIStateController m_infoPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_infoPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_infoPanelStateCtrl = value;
				}
			}

			// Token: 0x17003513 RID: 13587
			// (get) Token: 0x060113AD RID: 70573 RVA: 0x00478E68 File Offset: 0x00477068
			// (set) Token: 0x060113AE RID: 70574 RVA: 0x00478E78 File Offset: 0x00477078
			public Text m_infoTitleText
			{
				get
				{
					return this.m_owner.m_infoTitleText;
				}
				set
				{
					this.m_owner.m_infoTitleText = value;
				}
			}

			// Token: 0x17003514 RID: 13588
			// (get) Token: 0x060113AF RID: 70575 RVA: 0x00478E88 File Offset: 0x00477088
			// (set) Token: 0x060113B0 RID: 70576 RVA: 0x00478E98 File Offset: 0x00477098
			public Text m_infoDescText
			{
				get
				{
					return this.m_owner.m_infoDescText;
				}
				set
				{
					this.m_owner.m_infoDescText = value;
				}
			}

			// Token: 0x17003515 RID: 13589
			// (get) Token: 0x060113B1 RID: 70577 RVA: 0x00478EA8 File Offset: 0x004770A8
			// (set) Token: 0x060113B2 RID: 70578 RVA: 0x00478EB8 File Offset: 0x004770B8
			public GameObject m_infoHeroJobContent
			{
				get
				{
					return this.m_owner.m_infoHeroJobContent;
				}
				set
				{
					this.m_owner.m_infoHeroJobContent = value;
				}
			}

			// Token: 0x17003516 RID: 13590
			// (get) Token: 0x060113B3 RID: 70579 RVA: 0x00478EC8 File Offset: 0x004770C8
			// (set) Token: 0x060113B4 RID: 70580 RVA: 0x00478ED8 File Offset: 0x004770D8
			public Button m_infoSwitchButton
			{
				get
				{
					return this.m_owner.m_infoSwitchButton;
				}
				set
				{
					this.m_owner.m_infoSwitchButton = value;
				}
			}

			// Token: 0x17003517 RID: 13591
			// (get) Token: 0x060113B5 RID: 70581 RVA: 0x00478EE8 File Offset: 0x004770E8
			// (set) Token: 0x060113B6 RID: 70582 RVA: 0x00478EF8 File Offset: 0x004770F8
			public Button m_infoUnavailableButton
			{
				get
				{
					return this.m_owner.m_infoUnavailableButton;
				}
				set
				{
					this.m_owner.m_infoUnavailableButton = value;
				}
			}

			// Token: 0x17003518 RID: 13592
			// (get) Token: 0x060113B7 RID: 70583 RVA: 0x00478F08 File Offset: 0x00477108
			// (set) Token: 0x060113B8 RID: 70584 RVA: 0x00478F18 File Offset: 0x00477118
			public Button m_infoBuyButton
			{
				get
				{
					return this.m_owner.m_infoBuyButton;
				}
				set
				{
					this.m_owner.m_infoBuyButton = value;
				}
			}

			// Token: 0x17003519 RID: 13593
			// (get) Token: 0x060113B9 RID: 70585 RVA: 0x00478F28 File Offset: 0x00477128
			// (set) Token: 0x060113BA RID: 70586 RVA: 0x00478F38 File Offset: 0x00477138
			public Text m_infoFromDetailText
			{
				get
				{
					return this.m_owner.m_infoFromDetailText;
				}
				set
				{
					this.m_owner.m_infoFromDetailText = value;
				}
			}

			// Token: 0x1700351A RID: 13594
			// (get) Token: 0x060113BB RID: 70587 RVA: 0x00478F48 File Offset: 0x00477148
			// (set) Token: 0x060113BC RID: 70588 RVA: 0x00478F58 File Offset: 0x00477158
			public GameObject m_heroSoldierSkinItemPrefab
			{
				get
				{
					return this.m_owner.m_heroSoldierSkinItemPrefab;
				}
				set
				{
					this.m_owner.m_heroSoldierSkinItemPrefab = value;
				}
			}

			// Token: 0x1700351B RID: 13595
			// (get) Token: 0x060113BD RID: 70589 RVA: 0x00478F68 File Offset: 0x00477168
			// (set) Token: 0x060113BE RID: 70590 RVA: 0x00478F78 File Offset: 0x00477178
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

			// Token: 0x1700351C RID: 13596
			// (get) Token: 0x060113BF RID: 70591 RVA: 0x00478F88 File Offset: 0x00477188
			// (set) Token: 0x060113C0 RID: 70592 RVA: 0x00478F98 File Offset: 0x00477198
			public bool m_isFromHeroTab
			{
				get
				{
					return this.m_owner.m_isFromHeroTab;
				}
				set
				{
					this.m_owner.m_isFromHeroTab = value;
				}
			}

			// Token: 0x1700351D RID: 13597
			// (get) Token: 0x060113C1 RID: 70593 RVA: 0x00478FA8 File Offset: 0x004771A8
			// (set) Token: 0x060113C2 RID: 70594 RVA: 0x00478FB8 File Offset: 0x004771B8
			public ConfigDataSoldierInfo m_soldierInfo
			{
				get
				{
					return this.m_owner.m_soldierInfo;
				}
				set
				{
					this.m_owner.m_soldierInfo = value;
				}
			}

			// Token: 0x1700351E RID: 13598
			// (get) Token: 0x060113C3 RID: 70595 RVA: 0x00478FC8 File Offset: 0x004771C8
			// (set) Token: 0x060113C4 RID: 70596 RVA: 0x00478FD8 File Offset: 0x004771D8
			public HeroOrSoliderSkinUIController m_curSelectHeroSkinItemCtrl
			{
				get
				{
					return this.m_owner.m_curSelectHeroSkinItemCtrl;
				}
				set
				{
					this.m_owner.m_curSelectHeroSkinItemCtrl = value;
				}
			}

			// Token: 0x1700351F RID: 13599
			// (get) Token: 0x060113C5 RID: 70597 RVA: 0x00478FE8 File Offset: 0x004771E8
			// (set) Token: 0x060113C6 RID: 70598 RVA: 0x00478FF8 File Offset: 0x004771F8
			public List<HeroOrSoliderSkinUIController> m_itemCtrlList
			{
				get
				{
					return this.m_owner.m_itemCtrlList;
				}
				set
				{
					this.m_owner.m_itemCtrlList = value;
				}
			}

			// Token: 0x17003520 RID: 13600
			// (get) Token: 0x060113C7 RID: 70599 RVA: 0x00479008 File Offset: 0x00477208
			// (set) Token: 0x060113C8 RID: 70600 RVA: 0x00479018 File Offset: 0x00477218
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

			// Token: 0x17003521 RID: 13601
			// (get) Token: 0x060113C9 RID: 70601 RVA: 0x00479028 File Offset: 0x00477228
			// (set) Token: 0x060113CA RID: 70602 RVA: 0x00479038 File Offset: 0x00477238
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

			// Token: 0x060113CB RID: 70603 RVA: 0x00479048 File Offset: 0x00477248
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060113CC RID: 70604 RVA: 0x00479058 File Offset: 0x00477258
			public void LateUpdate()
			{
				this.m_owner.LateUpdate();
			}

			// Token: 0x060113CD RID: 70605 RVA: 0x00479068 File Offset: 0x00477268
			public void ShowHeroSkin()
			{
				this.m_owner.ShowHeroSkin();
			}

			// Token: 0x060113CE RID: 70606 RVA: 0x00479078 File Offset: 0x00477278
			public void CreatDefaultHeroSkin()
			{
				this.m_owner.CreatDefaultHeroSkin();
			}

			// Token: 0x060113CF RID: 70607 RVA: 0x00479088 File Offset: 0x00477288
			public void SetHeroInfoPanel(HeroOrSoliderSkinUIController ctrl)
			{
				this.m_owner.SetHeroInfoPanel(ctrl);
			}

			// Token: 0x060113D0 RID: 70608 RVA: 0x00479098 File Offset: 0x00477298
			public void SetHeroButtonState(HeroOrSoliderSkinUIController ctrl)
			{
				this.m_owner.SetHeroButtonState(ctrl);
			}

			// Token: 0x060113D1 RID: 70609 RVA: 0x004790A8 File Offset: 0x004772A8
			public void ShowSoldierSkin()
			{
				this.m_owner.ShowSoldierSkin();
			}

			// Token: 0x060113D2 RID: 70610 RVA: 0x004790B8 File Offset: 0x004772B8
			public void CreateDefaultSoldier()
			{
				this.m_owner.CreateDefaultSoldier();
			}

			// Token: 0x060113D3 RID: 70611 RVA: 0x004790C8 File Offset: 0x004772C8
			public void SetSoldierInfoPanel(HeroOrSoliderSkinUIController ctrl)
			{
				this.m_owner.SetSoldierInfoPanel(ctrl);
			}

			// Token: 0x060113D4 RID: 70612 RVA: 0x004790D8 File Offset: 0x004772D8
			public void OnSkinItemClick(HeroOrSoliderSkinUIController ctrl)
			{
				this.m_owner.OnSkinItemClick(ctrl);
			}

			// Token: 0x060113D5 RID: 70613 RVA: 0x004790E8 File Offset: 0x004772E8
			public void OnShowHeroToggleValueChanged(bool isOn)
			{
				this.m_owner.OnShowHeroToggleValueChanged(isOn);
			}

			// Token: 0x060113D6 RID: 70614 RVA: 0x004790F8 File Offset: 0x004772F8
			public void OnShowSoldierToggleValueChanged(bool isOn)
			{
				this.m_owner.OnShowSoldierToggleValueChanged(isOn);
			}

			// Token: 0x060113D7 RID: 70615 RVA: 0x00479108 File Offset: 0x00477308
			public void OnInfoUnavailableButtonClick()
			{
				this.m_owner.OnInfoUnavailableButtonClick();
			}

			// Token: 0x060113D8 RID: 70616 RVA: 0x00479118 File Offset: 0x00477318
			public void OnInfoBuyButtonClick()
			{
				this.m_owner.OnInfoBuyButtonClick();
			}

			// Token: 0x060113D9 RID: 70617 RVA: 0x00479128 File Offset: 0x00477328
			public void OnInfoSwitchButtonClick()
			{
				this.m_owner.OnInfoSwitchButtonClick();
			}

			// Token: 0x060113DA RID: 70618 RVA: 0x00479138 File Offset: 0x00477338
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x04009E30 RID: 40496
			private HeroSoldierSkinUIController m_owner;
		}
	}
}
