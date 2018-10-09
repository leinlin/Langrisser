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
	// Token: 0x02000E02 RID: 3586
	[HotFix]
	public class HeroSkinChangeUIController : UIControllerBase
	{
		// Token: 0x060111BD RID: 70077 RVA: 0x0046FC04 File Offset: 0x0046DE04
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
			this.m_closeButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_blackBgButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_infoSwitchButton.onClick.AddListener(new UnityAction(this.OnInfoSwitchButtonClick));
			this.m_infoBuyButton.onClick.AddListener(new UnityAction(this.OnInfoBuyButtonClick));
			this.m_skinTicketAddButton.onClick.AddListener(new UnityAction(this.OnSkinTicketButtonClick));
			this.m_skinsScrollSnapCenter = this.m_skinsScrollRect.gameObject.AddComponent<ScrollSnapCenter>();
			this.m_skinsScrollSnapCenter.m_itemSize = 208f;
			this.m_skinsScrollSnapCenter.m_scrollSnapDir = ScrollSnapDirection.Horizontal;
			this.m_skinsScrollSnapCenter.EventOnEndDrag += this.SkinsScrollSnapCenter_OnEndDrag;
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_facelifPanel);
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x060111BE RID: 70078 RVA: 0x0046FDB0 File Offset: 0x0046DFB0
		public void Open(string mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenString_hotfix != null)
			{
				this.m_OpenString_hotfix.call(new object[]
				{
					this,
					mode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string stateName = null;
			if (mode != null)
			{
				if (!(mode == "ShowSkinDetailMode"))
				{
					if (!(mode == "SkinBuyMode"))
					{
						if (mode == "ShowOneSkin")
						{
							stateName = "DescShow";
						}
					}
					else
					{
						stateName = "StoreShow";
					}
				}
				else
				{
					stateName = "HeroShow";
				}
			}
			UIUtility.SetUIStateOpen(this.m_stateCtrl, stateName, null, true, true);
		}

		// Token: 0x060111BF RID: 70079 RVA: 0x0046FE94 File Offset: 0x0046E094
		public void UpdateViewInHeroCharSkin(int heroSkinInfoId, string mode, Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInHeroCharSkinInt32StringHero_hotfix != null)
			{
				this.m_UpdateViewInHeroCharSkinInt32StringHero_hotfix.call(new object[]
				{
					this,
					heroSkinInfoId,
					mode,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_mode = mode;
			this.m_heroSkinInfoId = heroSkinInfoId;
			if (hero == null)
			{
				ConfigDataHeroSkinInfo configDataHeroSkinInfo = this.m_configDataLoader.GetConfigDataHeroSkinInfo(heroSkinInfoId);
				if (configDataHeroSkinInfo == null)
				{
					global::Debug.LogError(string.Format("HeroSkinChangeUIController invlaid heroSkin id: {0}", heroSkinInfoId));
					return;
				}
				this.m_hero = this.m_playerContext.GetHero(configDataHeroSkinInfo.SpecifiedHero);
				this.m_heroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(configDataHeroSkinInfo.SpecifiedHero);
			}
			else
			{
				this.m_hero = hero;
				if (this.m_heroSkinInfoId == 0)
				{
					this.m_heroSkinInfoId = this.m_hero.CharSkinId;
				}
			}
			this.SetSelectSkinPanelInfo();
			this.m_skinTicketCountText.text = this.m_playerContext.GetSkinTicket().ToString();
		}

		// Token: 0x060111C0 RID: 70080 RVA: 0x0046FFE4 File Offset: 0x0046E1E4
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
			Camera componentInParent = base.GetComponentInParent<Camera>();
			if (componentInParent == null)
			{
				return;
			}
			if (this.m_charSkinCtrlsList.Count <= 0)
			{
				return;
			}
			Vector2 center = this.m_skinsScrollRect.viewport.rect.center;
			HeroCharSkinItemUIController heroCharSkinItemUIController = this.m_charSkinCtrlsList[this.m_skinsScrollSnapCenter.GetCenterItemIndex()];
			foreach (HeroCharSkinItemUIController heroCharSkinItemUIController2 in this.m_charSkinCtrlsList)
			{
				float num = Mathf.Abs(UIUtility.WorldToLocalPosition(heroCharSkinItemUIController2.transform.position, componentInParent, this.m_skinsScrollRect.viewport, componentInParent).x - center.x);
				float num2 = Mathf.Clamp01((1000f - num) / 1000f);
				float num3 = num2 * 0.6f + 0.4f;
				RectTransform rectTransform = heroCharSkinItemUIController2.transform as RectTransform;
				rectTransform.localScale = new Vector3(num3, num3, num3);
				rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, (num2 - 1f) * 50f);
				heroCharSkinItemUIController2.SetLimitTime();
			}
			if (this.m_curCharSkinIndex != heroCharSkinItemUIController.GetIndex())
			{
				this.m_curCharSkinIndex = heroCharSkinItemUIController.GetIndex();
			}
			if (heroCharSkinItemUIController != null)
			{
				this.SetButtonState(heroCharSkinItemUIController);
			}
		}

		// Token: 0x060111C1 RID: 70081 RVA: 0x004701C0 File Offset: 0x0046E3C0
		private void SetSelectSkinPanelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectSkinPanelInfo_hotfix != null)
			{
				this.m_SetSelectSkinPanelInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_charSkinCtrlsList.Clear();
			GameObjectUtility.DestroyChildren(this.m_skinSelectContent);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("heroSkinItem");
			this.m_curSelectHeroCharSkinItemCtrl = null;
			if (this.m_mode == "ShowSkinDetailMode")
			{
				this.CreateHeroDefaultSkin();
			}
			List<int> list = new List<int>();
			if (this.m_mode == "ShowOneSkin")
			{
				list.Add(this.m_heroSkinInfoId);
			}
			else if (this.m_hero != null)
			{
				list.AddRange(this.m_hero.HeroInfo.Skins_ID);
			}
			else
			{
				list.AddRange(this.m_heroInfo.Skins_ID);
			}
			List<int> list2 = new List<int>(list);
			list.Clear();
			foreach (int num in list2)
			{
				ConfigDataHeroSkinInfo configDataHeroSkinInfo = this.m_configDataLoader.GetConfigDataHeroSkinInfo(num);
				if (this.m_playerContext.IsShowSkinBeforeOnSale(configDataHeroSkinInfo.FixedStoreItemId, true))
				{
					list.Add(num);
				}
			}
			int count = this.m_charSkinCtrlsList.Count;
			for (int i = 0; i < list.Count; i++)
			{
				int num2 = list[i];
				int num3 = i + count;
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				HeroCharSkinItemUIController component = gameObject.GetComponent<HeroCharSkinItemUIController>();
				component.EventOnItemClick += this.OnHeroCharSkinItemClick;
				component.SetHeroCharSkinItem(num2, num3, (this.m_hero == null) ? this.m_heroInfo : this.m_hero.HeroInfo, (this.m_hero == null) ? 0 : this.m_hero.CharSkinId, this.m_mode);
				gameObject.transform.SetParent(this.m_skinSelectContent.transform, false);
				this.m_charSkinCtrlsList.Add(component);
				this.m_skinsScrollSnapCenter.SetItemCount(this.m_charSkinCtrlsList.Count);
				RectTransform rectTransform = gameObject.transform as RectTransform;
				rectTransform.anchoredPosition = this.m_skinsScrollSnapCenter.ComputeItemPosition(num3);
				if (this.m_hero != null)
				{
					if (this.m_mode == "ShowSkinDetailMode")
					{
						if (this.m_heroSkinInfoId == num2)
						{
							this.m_curCharSkinIndex = component.GetIndex();
							this.m_curSelectHeroCharSkinItemCtrl = component;
						}
					}
					else if (this.m_mode == "SkinBuyMode" && this.m_heroSkinInfoId == num2)
					{
						this.m_curCharSkinIndex = component.GetIndex();
						this.m_curSelectHeroCharSkinItemCtrl = component;
					}
				}
			}
			if (this.m_curSelectHeroCharSkinItemCtrl != null)
			{
				this.m_curSelectHeroCharSkinItemCtrl.ShowSelectImage(true);
				this.SetSkinInfoPanel(this.m_curSelectHeroCharSkinItemCtrl);
				this.m_skinsScrollSnapCenter.Snap(this.m_curSelectHeroCharSkinItemCtrl.GetIndex(), false);
			}
			else if (this.m_charSkinCtrlsList.Count > 0)
			{
				this.m_curSelectHeroCharSkinItemCtrl = this.m_charSkinCtrlsList.Find((HeroCharSkinItemUIController ctrl) => ctrl.HeroSkinInfo != null && ctrl.HeroSkinInfo.ID == this.m_heroSkinInfoId);
				if (this.m_curSelectHeroCharSkinItemCtrl == null)
				{
					this.m_curSelectHeroCharSkinItemCtrl = this.m_charSkinCtrlsList[0];
				}
				this.m_curCharSkinIndex = this.m_curSelectHeroCharSkinItemCtrl.GetIndex();
				this.m_curSelectHeroCharSkinItemCtrl.ShowSelectImage(true);
				this.SetSkinInfoPanel(this.m_curSelectHeroCharSkinItemCtrl);
				this.m_skinsScrollSnapCenter.Snap(this.m_curSelectHeroCharSkinItemCtrl.GetIndex(), false);
			}
		}

		// Token: 0x060111C2 RID: 70082 RVA: 0x004705B0 File Offset: 0x0046E7B0
		private void CreateHeroDefaultSkin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateHeroDefaultSkin_hotfix != null)
			{
				this.m_CreateHeroDefaultSkin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("heroSkinItem");
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			HeroCharSkinItemUIController component = gameObject.GetComponent<HeroCharSkinItemUIController>();
			component.EventOnItemClick += this.OnHeroCharSkinItemClick;
			component.CreateDefaultItem((this.m_hero == null) ? this.m_heroInfo : this.m_hero.HeroInfo);
			gameObject.transform.SetParent(this.m_skinSelectContent.transform, false);
			this.m_charSkinCtrlsList.Add(component);
			if (this.m_hero != null && this.m_hero.CharSkinId == 0)
			{
				this.m_curCharSkinIndex = component.GetIndex();
				this.m_curSelectHeroCharSkinItemCtrl = component;
			}
			this.m_skinsScrollSnapCenter.SetItemCount(this.m_charSkinCtrlsList.Count);
			RectTransform rectTransform = gameObject.transform as RectTransform;
			rectTransform.anchoredPosition = this.m_skinsScrollSnapCenter.ComputeItemPosition(0);
		}

		// Token: 0x060111C3 RID: 70083 RVA: 0x004706F0 File Offset: 0x0046E8F0
		private void SetSkinInfoPanel(HeroCharSkinItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkinInfoPanelHeroCharSkinItemUIController_hotfix != null)
			{
				this.m_SetSkinInfoPanelHeroCharSkinItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!ctrl.IsDefaultSkin)
			{
				this.SetNotDefaultSkinInfoPanel(ctrl);
				if (this.EventOnSkinChangedPreview != null)
				{
					string spineAssetPath = this.m_curSelectHeroCharSkinItemCtrl.CharSkinInfo.SpineAssetPath;
					this.EventOnSkinChangedPreview(spineAssetPath, this.m_curSelectHeroCharSkinItemCtrl.HeroSkinInfo.ID);
				}
			}
			else
			{
				this.SetDefaultSkinInfoPanel(ctrl);
				if (this.EventOnSkinChangedPreview != null)
				{
					string spine = this.m_curSelectHeroCharSkinItemCtrl.HeroInfo.m_charImageInfo.Spine;
					this.EventOnSkinChangedPreview(spine, 0);
				}
			}
		}

		// Token: 0x060111C4 RID: 70084 RVA: 0x004707E4 File Offset: 0x0046E9E4
		private void SetNotDefaultSkinInfoPanel(HeroCharSkinItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNotDefaultSkinInfoPanelHeroCharSkinItemUIController_hotfix != null)
			{
				this.m_SetNotDefaultSkinInfoPanelHeroCharSkinItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroSkinInfo heroSkinInfo = ctrl.HeroSkinInfo;
			this.m_skinDescText.text = heroSkinInfo.Desc;
			GameObjectUtility.DestroyChildren(this.m_skinJobGroup);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("heroSkinJobItem");
			foreach (JobConnection2SkinResource jobConnection2SkinResource in heroSkinInfo.SpecifiedModelSkinResource)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(jobConnection2SkinResource.JobConnectionId);
				if (configDataJobConnectionInfo != null)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					HeroSkinJobUIController component = gameObject.GetComponent<HeroSkinJobUIController>();
					component.InitHeroSkinJobItem(configDataJobConnectionInfo);
					gameObject.transform.SetParent(this.m_skinJobGroup.transform, false);
				}
			}
			this.SetButtonState(ctrl);
			this.SetHeroSkinCharAndSpine(ctrl);
		}

		// Token: 0x060111C5 RID: 70085 RVA: 0x00470934 File Offset: 0x0046EB34
		private void SetButtonState(HeroCharSkinItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetButtonStateHeroCharSkinItemUIController_hotfix != null)
			{
				this.m_SetButtonStateHeroCharSkinItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ctrl.IsDefaultSkin)
			{
				if (this.m_hero.CharSkinId != 0)
				{
					this.m_buttonGroupStateCtrl.SetToUIState("Normal", false, true);
				}
				else
				{
					this.m_buttonGroupStateCtrl.SetToUIState("InUse", false, true);
				}
				return;
			}
			ConfigDataHeroSkinInfo heroSkinInfo = ctrl.HeroSkinInfo;
			if (this.m_playerContext.HasOwn(GoodsType.GoodsType_HeroSkin, heroSkinInfo.ID))
			{
				if (this.m_hero != null)
				{
					if (this.m_hero.CharSkinId != heroSkinInfo.ID)
					{
						if (this.m_mode == "ShowSkinDetailMode")
						{
							this.m_buttonGroupStateCtrl.SetToUIState("Normal", false, true);
						}
						else
						{
							this.m_buttonGroupStateCtrl.SetToUIState("Bought", false, true);
						}
					}
					else
					{
						this.m_buttonGroupStateCtrl.SetToUIState("InUse", false, true);
					}
				}
				else if (this.m_mode == "ShowSkinDetailMode")
				{
					this.m_buttonGroupStateCtrl.SetToUIState("Normal", false, true);
				}
				else
				{
					this.m_buttonGroupStateCtrl.SetToUIState("Bought", false, true);
				}
			}
			else
			{
				if (ctrl.CharSkinInfo == null)
				{
					return;
				}
				ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(ctrl.HeroSkinInfo.FixedStoreItemId);
				if (configDataFixedStoreItemInfo == null || configDataFixedStoreItemInfo.ShowEndTime == DateTime.MaxValue.ToString())
				{
					if (ctrl.HeroSkinInfo.GetPathDesc == string.Empty)
					{
						this.m_buttonGroupStateCtrl.SetToUIState("Lock", false, true);
						if (configDataFixedStoreItemInfo != null)
						{
							this.m_infoBuyValueText.text = configDataFixedStoreItemInfo.NormalPrice.ToString();
						}
						else
						{
							this.m_infoBuyValueText.text = string.Empty;
						}
					}
					else
					{
						this.m_fromText.text = ctrl.HeroSkinInfo.GetPathDesc;
						this.m_buttonGroupStateCtrl.SetToUIState("FromText", false, true);
					}
				}
				else
				{
					DateTime t = DateTime.Parse(configDataFixedStoreItemInfo.ShowEndTime);
					DateTime t2 = DateTime.Parse(configDataFixedStoreItemInfo.ShowStartTime);
					DateTime serverTime = this.m_playerContext.GetServerTime();
					if (t < serverTime || (!configDataFixedStoreItemInfo.IsFirstOnSale && t2 > serverTime))
					{
						this.m_fromText.text = ctrl.HeroSkinInfo.GetPathDesc;
						this.m_buttonGroupStateCtrl.SetToUIState("FromText", false, true);
					}
					else
					{
						this.m_buttonGroupStateCtrl.SetToUIState("Lock", false, true);
						this.m_infoBuyValueText.text = configDataFixedStoreItemInfo.NormalPrice.ToString();
					}
				}
			}
		}

		// Token: 0x060111C6 RID: 70086 RVA: 0x00470C58 File Offset: 0x0046EE58
		private void SetHeroSkinCharAndSpine(HeroCharSkinItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroSkinCharAndSpineHeroCharSkinItemUIController_hotfix != null)
			{
				this.m_SetHeroSkinCharAndSpineHeroCharSkinItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroSkinInfo heroSkinInfo = ctrl.HeroSkinInfo;
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = this.m_configDataLoader.GetConfigDataModelSkinResourceInfo(heroSkinInfo.SpecifiedModelSkinResource[0].SkinResourceId);
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(heroSkinInfo.SpecifiedModelSkinResource[0].JobConnectionId);
			if (GameObjectUtility.HasChinese(configDataModelSkinResourceInfo.Model))
			{
				return;
			}
			string model = configDataModelSkinResourceInfo.Model;
			float scale = (float)configDataJobConnectionInfo.UI_ModelScale * 0.014f;
			Vector2 offset = new Vector2((float)configDataJobConnectionInfo.UI_ModelOffsetX, (float)configDataJobConnectionInfo.UI_ModelOffsetY) * 1.4f;
			List<ReplaceAnim> replaceAnims = configDataJobConnectionInfo.ReplaceAnims;
			HeroDetailUIController.CreateSpineGraphic(ref this.m_playerHeroGraphic, model, this.m_skinCharGo, 1, offset, scale, replaceAnims);
			if (this.m_mode != "ShowSkinDetailMode")
			{
				ConfigDataCharImageSkinResourceInfo configDataCharImageSkinResourceInfo = this.m_configDataLoader.GetConfigDataCharImageSkinResourceInfo(heroSkinInfo.CharImageSkinResource_ID);
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroSkinInfo.SpecifiedHero);
				if (this.m_heroCharUIController.GetCharImageInfo() != configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star) || this.m_heroCharUIController.GetHeroCharSkinId() != heroSkinInfo.ID)
				{
					this.m_heroCharUIController.CreateGraphic(configDataHeroInfo, configDataCharImageSkinResourceInfo.SpineAssetPath, heroSkinInfo.ID);
					this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
				}
			}
		}

		// Token: 0x060111C7 RID: 70087 RVA: 0x00470E0C File Offset: 0x0046F00C
		private void SetDefaultSkinInfoPanel(HeroCharSkinItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDefaultSkinInfoPanelHeroCharSkinItemUIController_hotfix != null)
			{
				this.m_SetDefaultSkinInfoPanelHeroCharSkinItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_skinDescText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_HeroDefaultCharSkinDesc);
			GameObjectUtility.DestroyChildren(this.m_skinJobGroup);
			GameObjectUtility.DestroyChildren(this.m_skinJobGroup);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("heroSkinJobItem");
			ConfigDataJobConnectionInfo jobConnectionInfo = this.m_hero.GetActiveJob().JobConnectionInfo;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			HeroSkinJobUIController component = gameObject.GetComponent<HeroSkinJobUIController>();
			component.InitHeroSkinJobItem(jobConnectionInfo);
			gameObject.transform.SetParent(this.m_skinJobGroup.transform, false);
			this.SetButtonState(ctrl);
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(this.m_hero.GetActiveJob().JobRelatedId);
			string model = configDataJobConnectionInfo.Model;
			float scale = (float)configDataJobConnectionInfo.UI_ModelScale * 0.014f;
			Vector2 offset = new Vector2((float)configDataJobConnectionInfo.UI_ModelOffsetX, (float)configDataJobConnectionInfo.UI_ModelOffsetY) * 1.4f;
			List<ReplaceAnim> replaceAnims = configDataJobConnectionInfo.ReplaceAnims;
			HeroDetailUIController.CreateSpineGraphic(ref this.m_playerHeroGraphic, model, this.m_skinCharGo, 1, offset, scale, replaceAnims);
			if (this.m_mode != "ShowSkinDetailMode")
			{
				ConfigDataHeroInfo heroInfo = this.m_curSelectHeroCharSkinItemCtrl.HeroInfo;
				string spine = this.m_curSelectHeroCharSkinItemCtrl.HeroInfo.m_charImageInfo.Spine;
				if (this.m_heroCharUIController.GetCharImageInfo() != heroInfo.GetCharImageInfo(heroInfo.Star) || this.m_heroCharUIController.GetHeroCharSkinId() != 0)
				{
					this.m_heroCharUIController.CreateGraphic(heroInfo, spine, 0);
					this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
				}
			}
		}

		// Token: 0x060111C8 RID: 70088 RVA: 0x00471008 File Offset: 0x0046F208
		private void OnHeroCharSkinItemClick(HeroCharSkinItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroCharSkinItemClickHeroCharSkinItemUIController_hotfix != null)
			{
				this.m_OnHeroCharSkinItemClickHeroCharSkinItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ctrl.GetIndex() != this.m_curCharSkinIndex)
			{
				this.m_skinsScrollSnapCenter.Snap(ctrl.GetIndex(), true);
				foreach (HeroCharSkinItemUIController heroCharSkinItemUIController in this.m_charSkinCtrlsList)
				{
					heroCharSkinItemUIController.ShowSelectImage(false);
				}
				this.m_curSelectHeroCharSkinItemCtrl = ctrl;
				this.m_curSelectHeroCharSkinItemCtrl.ShowSelectImage(true);
				this.SetSkinInfoPanel(this.m_curSelectHeroCharSkinItemCtrl);
			}
		}

		// Token: 0x060111C9 RID: 70089 RVA: 0x0047110C File Offset: 0x0046F30C
		private void SkinsScrollSnapCenter_OnEndDrag()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkinsScrollSnapCenter_OnEndDrag_hotfix != null)
			{
				this.m_SkinsScrollSnapCenter_OnEndDrag_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_charSkinCtrlsList.Count == 0 || this.m_curSelectHeroCharSkinItemCtrl == null)
			{
				return;
			}
			if (this.m_curCharSkinIndex != this.m_curSelectHeroCharSkinItemCtrl.GetIndex())
			{
				foreach (HeroCharSkinItemUIController heroCharSkinItemUIController in this.m_charSkinCtrlsList)
				{
					if (heroCharSkinItemUIController.GetIndex() == this.m_curCharSkinIndex)
					{
						this.m_curSelectHeroCharSkinItemCtrl = heroCharSkinItemUIController;
						this.m_curSelectHeroCharSkinItemCtrl.ShowSelectImage(true);
						this.SetSkinInfoPanel(this.m_curSelectHeroCharSkinItemCtrl);
					}
					else
					{
						heroCharSkinItemUIController.ShowSelectImage(false);
					}
				}
			}
		}

		// Token: 0x060111CA RID: 70090 RVA: 0x00471228 File Offset: 0x0046F428
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
			if (this.EventOnBuySkin != null)
			{
				this.EventOnBuySkin(this.m_curSelectHeroCharSkinItemCtrl.HeroSkinInfo.ID);
			}
		}

		// Token: 0x060111CB RID: 70091 RVA: 0x004712B0 File Offset: 0x0046F4B0
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
			if (!this.m_curSelectHeroCharSkinItemCtrl.IsDefaultSkin)
			{
				int num = this.m_playerContext.CanWearCharSkin((this.m_hero == null) ? this.m_heroInfo.ID : this.m_hero.HeroId, this.m_curSelectHeroCharSkinItemCtrl.CharSkinInfo.ID);
				if (num == 0)
				{
					if (this.EventOnWearCharSkin != null)
					{
						this.EventOnWearCharSkin((this.m_hero == null) ? this.m_heroInfo.ID : this.m_hero.HeroId, this.m_curSelectHeroCharSkinItemCtrl.CharSkinInfo.ID);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				}
			}
			else
			{
				int num2 = this.m_playerContext.CanTakeOffCharSkin(this.m_hero.HeroId);
				if (num2 == 0)
				{
					if (this.EventOnTakeOffCharSkin != null)
					{
						this.EventOnTakeOffCharSkin(this.m_hero.HeroId);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num2, 2f, null, true);
				}
			}
		}

		// Token: 0x060111CC RID: 70092 RVA: 0x00471428 File Offset: 0x0046F628
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
			string stateName = null;
			string mode = this.m_mode;
			if (mode != null)
			{
				if (!(mode == "ShowSkinDetailMode"))
				{
					if (!(mode == "SkinBuyMode"))
					{
						if (mode == "ShowOneSkin")
						{
							stateName = "DescClose";
						}
					}
					else
					{
						stateName = "StoreClose";
					}
				}
				else
				{
					stateName = "HeroClose";
				}
			}
			UIUtility.SetUIStateClose(this.m_stateCtrl, stateName, delegate
			{
				if (this.EventOnReturn != null)
				{
					this.EventOnReturn();
				}
				this.m_curSelectHeroCharSkinItemCtrl = null;
			}, true, true);
		}

		// Token: 0x060111CD RID: 70093 RVA: 0x0047150C File Offset: 0x0046F70C
		private void OnSkinTicketButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkinTicketButtonClick_hotfix != null)
			{
				this.m_OnSkinTicketButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSkinTicketButtonClick != null)
			{
				this.EventOnSkinTicketButtonClick();
			}
		}

		// Token: 0x060111CE RID: 70094 RVA: 0x00471584 File Offset: 0x0046F784
		public void CloseHeroSkinChangePanel(Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseHeroSkinChangePanelAction_hotfix != null)
			{
				this.m_CloseHeroSkinChangePanelAction_hotfix.call(new object[]
				{
					this,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			HeroSkinChangeUIController $this = this;
			string stateName = null;
			string mode = this.m_mode;
			if (mode != null)
			{
				if (!(mode == "ShowSkinDetailMode"))
				{
					if (!(mode == "SkinBuyMode"))
					{
						if (mode == "ShowOneSkin")
						{
							stateName = "DescClose";
						}
					}
					else
					{
						stateName = "StoreClose";
					}
				}
				else
				{
					stateName = "HeroClose";
				}
			}
			UIUtility.SetUIStateClose(this.m_stateCtrl, stateName, delegate
			{
				if (onEnd != null)
				{
					onEnd();
				}
				$this.m_curSelectHeroCharSkinItemCtrl = null;
			}, true, true);
		}

		// Token: 0x060111CF RID: 70095 RVA: 0x0047168C File Offset: 0x0046F88C
		private void OnBuyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyButtonClick_hotfix != null)
			{
				this.m_OnBuyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnBuySkin != null)
			{
				this.EventOnBuySkin(this.m_curSelectHeroCharSkinItemCtrl.HeroSkinInfo.ID);
			}
			this.ClearData();
		}

		// Token: 0x060111D0 RID: 70096 RVA: 0x00471718 File Offset: 0x0046F918
		public void ClearData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearData_hotfix != null)
			{
				this.m_ClearData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curSelectHeroCharSkinItemCtrl = null;
			this.m_charSkinCtrlsList.Clear();
			this.m_curCharSkinIndex = 0;
			this.m_heroSkinInfoId = 0;
		}

		// Token: 0x140003A4 RID: 932
		// (add) Token: 0x060111D1 RID: 70097 RVA: 0x00471798 File Offset: 0x0046F998
		// (remove) Token: 0x060111D2 RID: 70098 RVA: 0x00471834 File Offset: 0x0046FA34
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

		// Token: 0x140003A5 RID: 933
		// (add) Token: 0x060111D3 RID: 70099 RVA: 0x004718D0 File Offset: 0x0046FAD0
		// (remove) Token: 0x060111D4 RID: 70100 RVA: 0x0047196C File Offset: 0x0046FB6C
		public event Action<int> EventOnBuySkin
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBuySkinAction`1_hotfix != null)
				{
					this.m_add_EventOnBuySkinAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnBuySkin;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnBuySkin, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBuySkinAction`1_hotfix != null)
				{
					this.m_remove_EventOnBuySkinAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnBuySkin;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnBuySkin, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003A6 RID: 934
		// (add) Token: 0x060111D5 RID: 70101 RVA: 0x00471A08 File Offset: 0x0046FC08
		// (remove) Token: 0x060111D6 RID: 70102 RVA: 0x00471AA4 File Offset: 0x0046FCA4
		public event Action<int, int> EventOnWearCharSkin
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnWearCharSkinAction`2_hotfix != null)
				{
					this.m_add_EventOnWearCharSkinAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnWearCharSkin;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnWearCharSkin, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnWearCharSkinAction`2_hotfix != null)
				{
					this.m_remove_EventOnWearCharSkinAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnWearCharSkin;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnWearCharSkin, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003A7 RID: 935
		// (add) Token: 0x060111D7 RID: 70103 RVA: 0x00471B40 File Offset: 0x0046FD40
		// (remove) Token: 0x060111D8 RID: 70104 RVA: 0x00471BDC File Offset: 0x0046FDDC
		public event Action<int> EventOnTakeOffCharSkin
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTakeOffCharSkinAction`1_hotfix != null)
				{
					this.m_add_EventOnTakeOffCharSkinAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnTakeOffCharSkin;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnTakeOffCharSkin, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTakeOffCharSkinAction`1_hotfix != null)
				{
					this.m_remove_EventOnTakeOffCharSkinAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnTakeOffCharSkin;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnTakeOffCharSkin, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003A8 RID: 936
		// (add) Token: 0x060111D9 RID: 70105 RVA: 0x00471C78 File Offset: 0x0046FE78
		// (remove) Token: 0x060111DA RID: 70106 RVA: 0x00471D14 File Offset: 0x0046FF14
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

		// Token: 0x140003A9 RID: 937
		// (add) Token: 0x060111DB RID: 70107 RVA: 0x00471DB0 File Offset: 0x0046FFB0
		// (remove) Token: 0x060111DC RID: 70108 RVA: 0x00471E4C File Offset: 0x0047004C
		public event Action EventOnSkinTicketButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkinTicketButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnSkinTicketButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkinTicketButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkinTicketButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkinTicketButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnSkinTicketButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkinTicketButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkinTicketButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x060111DD RID: 70109 RVA: 0x00471EE8 File Offset: 0x004700E8
		// (set) Token: 0x060111DE RID: 70110 RVA: 0x00471F08 File Offset: 0x00470108
		[DoNotToLua]
		public new HeroSkinChangeUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroSkinChangeUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060111DF RID: 70111 RVA: 0x00471F14 File Offset: 0x00470114
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060111E0 RID: 70112 RVA: 0x00471F20 File Offset: 0x00470120
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060111E1 RID: 70113 RVA: 0x00471F28 File Offset: 0x00470128
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060111E2 RID: 70114 RVA: 0x00471F30 File Offset: 0x00470130
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060111E3 RID: 70115 RVA: 0x00471F44 File Offset: 0x00470144
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060111E4 RID: 70116 RVA: 0x00471F4C File Offset: 0x0047014C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060111E5 RID: 70117 RVA: 0x00471F58 File Offset: 0x00470158
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060111E6 RID: 70118 RVA: 0x00471F64 File Offset: 0x00470164
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060111E7 RID: 70119 RVA: 0x00471F70 File Offset: 0x00470170
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060111E8 RID: 70120 RVA: 0x00471F7C File Offset: 0x0047017C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060111E9 RID: 70121 RVA: 0x00471F88 File Offset: 0x00470188
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060111EA RID: 70122 RVA: 0x00471F94 File Offset: 0x00470194
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060111EB RID: 70123 RVA: 0x00471FA0 File Offset: 0x004701A0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060111EC RID: 70124 RVA: 0x00471FAC File Offset: 0x004701AC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060111ED RID: 70125 RVA: 0x00471FB8 File Offset: 0x004701B8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060111EE RID: 70126 RVA: 0x00471FC0 File Offset: 0x004701C0
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x060111EF RID: 70127 RVA: 0x00471FE0 File Offset: 0x004701E0
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x060111F0 RID: 70128 RVA: 0x00471FEC File Offset: 0x004701EC
		private void __callDele_EventOnBuySkin(int obj)
		{
			Action<int> eventOnBuySkin = this.EventOnBuySkin;
			if (eventOnBuySkin != null)
			{
				eventOnBuySkin(obj);
			}
		}

		// Token: 0x060111F1 RID: 70129 RVA: 0x00472010 File Offset: 0x00470210
		private void __clearDele_EventOnBuySkin(int obj)
		{
			this.EventOnBuySkin = null;
		}

		// Token: 0x060111F2 RID: 70130 RVA: 0x0047201C File Offset: 0x0047021C
		private void __callDele_EventOnWearCharSkin(int arg1, int arg2)
		{
			Action<int, int> eventOnWearCharSkin = this.EventOnWearCharSkin;
			if (eventOnWearCharSkin != null)
			{
				eventOnWearCharSkin(arg1, arg2);
			}
		}

		// Token: 0x060111F3 RID: 70131 RVA: 0x00472040 File Offset: 0x00470240
		private void __clearDele_EventOnWearCharSkin(int arg1, int arg2)
		{
			this.EventOnWearCharSkin = null;
		}

		// Token: 0x060111F4 RID: 70132 RVA: 0x0047204C File Offset: 0x0047024C
		private void __callDele_EventOnTakeOffCharSkin(int obj)
		{
			Action<int> eventOnTakeOffCharSkin = this.EventOnTakeOffCharSkin;
			if (eventOnTakeOffCharSkin != null)
			{
				eventOnTakeOffCharSkin(obj);
			}
		}

		// Token: 0x060111F5 RID: 70133 RVA: 0x00472070 File Offset: 0x00470270
		private void __clearDele_EventOnTakeOffCharSkin(int obj)
		{
			this.EventOnTakeOffCharSkin = null;
		}

		// Token: 0x060111F6 RID: 70134 RVA: 0x0047207C File Offset: 0x0047027C
		private void __callDele_EventOnSkinChangedPreview(string arg1, int arg2)
		{
			Action<string, int> eventOnSkinChangedPreview = this.EventOnSkinChangedPreview;
			if (eventOnSkinChangedPreview != null)
			{
				eventOnSkinChangedPreview(arg1, arg2);
			}
		}

		// Token: 0x060111F7 RID: 70135 RVA: 0x004720A0 File Offset: 0x004702A0
		private void __clearDele_EventOnSkinChangedPreview(string arg1, int arg2)
		{
			this.EventOnSkinChangedPreview = null;
		}

		// Token: 0x060111F8 RID: 70136 RVA: 0x004720AC File Offset: 0x004702AC
		private void __callDele_EventOnSkinTicketButtonClick()
		{
			Action eventOnSkinTicketButtonClick = this.EventOnSkinTicketButtonClick;
			if (eventOnSkinTicketButtonClick != null)
			{
				eventOnSkinTicketButtonClick();
			}
		}

		// Token: 0x060111F9 RID: 70137 RVA: 0x004720CC File Offset: 0x004702CC
		private void __clearDele_EventOnSkinTicketButtonClick()
		{
			this.EventOnSkinTicketButtonClick = null;
		}

		// Token: 0x060111FC RID: 70140 RVA: 0x0047211C File Offset: 0x0047031C
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
					this.m_OpenString_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_UpdateViewInHeroCharSkinInt32StringHero_hotfix = (luaObj.RawGet("UpdateViewInHeroCharSkin") as LuaFunction);
					this.m_LateUpdate_hotfix = (luaObj.RawGet("LateUpdate") as LuaFunction);
					this.m_SetSelectSkinPanelInfo_hotfix = (luaObj.RawGet("SetSelectSkinPanelInfo") as LuaFunction);
					this.m_CreateHeroDefaultSkin_hotfix = (luaObj.RawGet("CreateHeroDefaultSkin") as LuaFunction);
					this.m_SetSkinInfoPanelHeroCharSkinItemUIController_hotfix = (luaObj.RawGet("SetSkinInfoPanel") as LuaFunction);
					this.m_SetNotDefaultSkinInfoPanelHeroCharSkinItemUIController_hotfix = (luaObj.RawGet("SetNotDefaultSkinInfoPanel") as LuaFunction);
					this.m_SetButtonStateHeroCharSkinItemUIController_hotfix = (luaObj.RawGet("SetButtonState") as LuaFunction);
					this.m_SetHeroSkinCharAndSpineHeroCharSkinItemUIController_hotfix = (luaObj.RawGet("SetHeroSkinCharAndSpine") as LuaFunction);
					this.m_SetDefaultSkinInfoPanelHeroCharSkinItemUIController_hotfix = (luaObj.RawGet("SetDefaultSkinInfoPanel") as LuaFunction);
					this.m_OnHeroCharSkinItemClickHeroCharSkinItemUIController_hotfix = (luaObj.RawGet("OnHeroCharSkinItemClick") as LuaFunction);
					this.m_SkinsScrollSnapCenter_OnEndDrag_hotfix = (luaObj.RawGet("SkinsScrollSnapCenter_OnEndDrag") as LuaFunction);
					this.m_OnInfoBuyButtonClick_hotfix = (luaObj.RawGet("OnInfoBuyButtonClick") as LuaFunction);
					this.m_OnInfoSwitchButtonClick_hotfix = (luaObj.RawGet("OnInfoSwitchButtonClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnSkinTicketButtonClick_hotfix = (luaObj.RawGet("OnSkinTicketButtonClick") as LuaFunction);
					this.m_CloseHeroSkinChangePanelAction_hotfix = (luaObj.RawGet("CloseHeroSkinChangePanel") as LuaFunction);
					this.m_OnBuyButtonClick_hotfix = (luaObj.RawGet("OnBuyButtonClick") as LuaFunction);
					this.m_ClearData_hotfix = (luaObj.RawGet("ClearData") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnBuySkinAction`1_hotfix = (luaObj.RawGet("add_EventOnBuySkin") as LuaFunction);
					this.m_remove_EventOnBuySkinAction`1_hotfix = (luaObj.RawGet("remove_EventOnBuySkin") as LuaFunction);
					this.m_add_EventOnWearCharSkinAction`2_hotfix = (luaObj.RawGet("add_EventOnWearCharSkin") as LuaFunction);
					this.m_remove_EventOnWearCharSkinAction`2_hotfix = (luaObj.RawGet("remove_EventOnWearCharSkin") as LuaFunction);
					this.m_add_EventOnTakeOffCharSkinAction`1_hotfix = (luaObj.RawGet("add_EventOnTakeOffCharSkin") as LuaFunction);
					this.m_remove_EventOnTakeOffCharSkinAction`1_hotfix = (luaObj.RawGet("remove_EventOnTakeOffCharSkin") as LuaFunction);
					this.m_add_EventOnSkinChangedPreviewAction`2_hotfix = (luaObj.RawGet("add_EventOnSkinChangedPreview") as LuaFunction);
					this.m_remove_EventOnSkinChangedPreviewAction`2_hotfix = (luaObj.RawGet("remove_EventOnSkinChangedPreview") as LuaFunction);
					this.m_add_EventOnSkinTicketButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnSkinTicketButtonClick") as LuaFunction);
					this.m_remove_EventOnSkinTicketButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnSkinTicketButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060111FD RID: 70141 RVA: 0x004724F0 File Offset: 0x004706F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSkinChangeUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009D54 RID: 40276
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04009D55 RID: 40277
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04009D56 RID: 40278
		[AutoBind("./FacelifPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_facelifPanel;

		// Token: 0x04009D57 RID: 40279
		[AutoBind("./FacelifPanel/ReturnBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04009D58 RID: 40280
		[AutoBind("./FacelifPanel/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeButton;

		// Token: 0x04009D59 RID: 40281
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_blackBgButton;

		// Token: 0x04009D5A RID: 40282
		[AutoBind("./FacelifPanel/Detail/SkinSelectPanel", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_skinsScrollRect;

		// Token: 0x04009D5B RID: 40283
		[AutoBind("./FacelifPanel/Detail/SkinSelectPanel/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skinSelectContent;

		// Token: 0x04009D5C RID: 40284
		[AutoBind("./FacelifPanel/Detail/InfoPanel/JobScrollView/Viewport/JobGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skinJobGroup;

		// Token: 0x04009D5D RID: 40285
		[AutoBind("./FacelifPanel/Detail/InfoPanel/Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skinCharGo;

		// Token: 0x04009D5E RID: 40286
		[AutoBind("./FacelifPanel/Detail/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skinDescText;

		// Token: 0x04009D5F RID: 40287
		[AutoBind("./FacelifPanel/Detail/ButtonGroupState", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_buttonGroupStateCtrl;

		// Token: 0x04009D60 RID: 40288
		[AutoBind("./FacelifPanel/Detail/ButtonGroupState/FromText/Title/DetailText ", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_fromText;

		// Token: 0x04009D61 RID: 40289
		[AutoBind("./FacelifPanel/Detail/ButtonGroupState/GetOn", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoSwitchButton;

		// Token: 0x04009D62 RID: 40290
		[AutoBind("./FacelifPanel/Detail/ButtonGroupState/Buy", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoBuyButton;

		// Token: 0x04009D63 RID: 40291
		[AutoBind("./FacelifPanel/Detail/ButtonGroupState/Buy/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoBuyValueText;

		// Token: 0x04009D64 RID: 40292
		[AutoBind("./FacelifPanel/PlayerResource/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skinTicketCountText;

		// Token: 0x04009D65 RID: 40293
		[AutoBind("./FacelifPanel/PlayerResource/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skinTicketAddButton;

		// Token: 0x04009D66 RID: 40294
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009D67 RID: 40295
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009D68 RID: 40296
		private Hero m_hero;

		// Token: 0x04009D69 RID: 40297
		private string m_mode;

		// Token: 0x04009D6A RID: 40298
		private int m_heroSkinInfoId;

		// Token: 0x04009D6B RID: 40299
		private int m_curCharSkinIndex;

		// Token: 0x04009D6C RID: 40300
		private ConfigDataHeroInfo m_heroInfo;

		// Token: 0x04009D6D RID: 40301
		private UISpineGraphic m_playerHeroGraphic;

		// Token: 0x04009D6E RID: 40302
		private ScrollSnapCenter m_skinsScrollSnapCenter;

		// Token: 0x04009D6F RID: 40303
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x04009D70 RID: 40304
		private HeroCharSkinItemUIController m_curSelectHeroCharSkinItemCtrl;

		// Token: 0x04009D71 RID: 40305
		private List<HeroCharSkinItemUIController> m_charSkinCtrlsList = new List<HeroCharSkinItemUIController>();

		// Token: 0x04009D72 RID: 40306
		[DoNotToLua]
		private HeroSkinChangeUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009D73 RID: 40307
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009D74 RID: 40308
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009D75 RID: 40309
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009D76 RID: 40310
		private LuaFunction m_OpenString_hotfix;

		// Token: 0x04009D77 RID: 40311
		private LuaFunction m_UpdateViewInHeroCharSkinInt32StringHero_hotfix;

		// Token: 0x04009D78 RID: 40312
		private LuaFunction m_LateUpdate_hotfix;

		// Token: 0x04009D79 RID: 40313
		private LuaFunction m_SetSelectSkinPanelInfo_hotfix;

		// Token: 0x04009D7A RID: 40314
		private LuaFunction m_CreateHeroDefaultSkin_hotfix;

		// Token: 0x04009D7B RID: 40315
		private LuaFunction m_SetSkinInfoPanelHeroCharSkinItemUIController_hotfix;

		// Token: 0x04009D7C RID: 40316
		private LuaFunction m_SetNotDefaultSkinInfoPanelHeroCharSkinItemUIController_hotfix;

		// Token: 0x04009D7D RID: 40317
		private LuaFunction m_SetButtonStateHeroCharSkinItemUIController_hotfix;

		// Token: 0x04009D7E RID: 40318
		private LuaFunction m_SetHeroSkinCharAndSpineHeroCharSkinItemUIController_hotfix;

		// Token: 0x04009D7F RID: 40319
		private LuaFunction m_SetDefaultSkinInfoPanelHeroCharSkinItemUIController_hotfix;

		// Token: 0x04009D80 RID: 40320
		private LuaFunction m_OnHeroCharSkinItemClickHeroCharSkinItemUIController_hotfix;

		// Token: 0x04009D81 RID: 40321
		private LuaFunction m_SkinsScrollSnapCenter_OnEndDrag_hotfix;

		// Token: 0x04009D82 RID: 40322
		private LuaFunction m_OnInfoBuyButtonClick_hotfix;

		// Token: 0x04009D83 RID: 40323
		private LuaFunction m_OnInfoSwitchButtonClick_hotfix;

		// Token: 0x04009D84 RID: 40324
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04009D85 RID: 40325
		private LuaFunction m_OnSkinTicketButtonClick_hotfix;

		// Token: 0x04009D86 RID: 40326
		private LuaFunction m_CloseHeroSkinChangePanelAction_hotfix;

		// Token: 0x04009D87 RID: 40327
		private LuaFunction m_OnBuyButtonClick_hotfix;

		// Token: 0x04009D88 RID: 40328
		private LuaFunction m_ClearData_hotfix;

		// Token: 0x04009D89 RID: 40329
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04009D8A RID: 40330
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04009D8B RID: 40331
		private LuaFunction m_add_EventOnBuySkinAction;

		// Token: 0x04009D8C RID: 40332
		private LuaFunction m_remove_EventOnBuySkinAction;

		// Token: 0x04009D8D RID: 40333
		private LuaFunction m_add_EventOnWearCharSkinAction;

		// Token: 0x04009D8E RID: 40334
		private LuaFunction m_remove_EventOnWearCharSkinAction;

		// Token: 0x04009D8F RID: 40335
		private LuaFunction m_add_EventOnTakeOffCharSkinAction;

		// Token: 0x04009D90 RID: 40336
		private LuaFunction m_remove_EventOnTakeOffCharSkinAction;

		// Token: 0x04009D91 RID: 40337
		private LuaFunction m_add_EventOnSkinChangedPreviewAction;

		// Token: 0x04009D92 RID: 40338
		private LuaFunction m_remove_EventOnSkinChangedPreviewAction;

		// Token: 0x04009D93 RID: 40339
		private LuaFunction m_add_EventOnSkinTicketButtonClickAction_hotfix;

		// Token: 0x04009D94 RID: 40340
		private LuaFunction m_remove_EventOnSkinTicketButtonClickAction_hotfix;

		// Token: 0x02000E03 RID: 3587
		public new class LuaExportHelper
		{
			// Token: 0x060111FE RID: 70142 RVA: 0x00472558 File Offset: 0x00470758
			public LuaExportHelper(HeroSkinChangeUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060111FF RID: 70143 RVA: 0x00472568 File Offset: 0x00470768
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011200 RID: 70144 RVA: 0x00472578 File Offset: 0x00470778
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011201 RID: 70145 RVA: 0x00472588 File Offset: 0x00470788
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011202 RID: 70146 RVA: 0x00472598 File Offset: 0x00470798
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011203 RID: 70147 RVA: 0x004725B0 File Offset: 0x004707B0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011204 RID: 70148 RVA: 0x004725C0 File Offset: 0x004707C0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011205 RID: 70149 RVA: 0x004725D0 File Offset: 0x004707D0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011206 RID: 70150 RVA: 0x004725E0 File Offset: 0x004707E0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011207 RID: 70151 RVA: 0x004725F0 File Offset: 0x004707F0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011208 RID: 70152 RVA: 0x00472600 File Offset: 0x00470800
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011209 RID: 70153 RVA: 0x00472610 File Offset: 0x00470810
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601120A RID: 70154 RVA: 0x00472620 File Offset: 0x00470820
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601120B RID: 70155 RVA: 0x00472630 File Offset: 0x00470830
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601120C RID: 70156 RVA: 0x00472640 File Offset: 0x00470840
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601120D RID: 70157 RVA: 0x00472650 File Offset: 0x00470850
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601120E RID: 70158 RVA: 0x00472660 File Offset: 0x00470860
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0601120F RID: 70159 RVA: 0x00472670 File Offset: 0x00470870
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06011210 RID: 70160 RVA: 0x00472680 File Offset: 0x00470880
			public void __callDele_EventOnBuySkin(int obj)
			{
				this.m_owner.__callDele_EventOnBuySkin(obj);
			}

			// Token: 0x06011211 RID: 70161 RVA: 0x00472690 File Offset: 0x00470890
			public void __clearDele_EventOnBuySkin(int obj)
			{
				this.m_owner.__clearDele_EventOnBuySkin(obj);
			}

			// Token: 0x06011212 RID: 70162 RVA: 0x004726A0 File Offset: 0x004708A0
			public void __callDele_EventOnWearCharSkin(int arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnWearCharSkin(arg1, arg2);
			}

			// Token: 0x06011213 RID: 70163 RVA: 0x004726B0 File Offset: 0x004708B0
			public void __clearDele_EventOnWearCharSkin(int arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnWearCharSkin(arg1, arg2);
			}

			// Token: 0x06011214 RID: 70164 RVA: 0x004726C0 File Offset: 0x004708C0
			public void __callDele_EventOnTakeOffCharSkin(int obj)
			{
				this.m_owner.__callDele_EventOnTakeOffCharSkin(obj);
			}

			// Token: 0x06011215 RID: 70165 RVA: 0x004726D0 File Offset: 0x004708D0
			public void __clearDele_EventOnTakeOffCharSkin(int obj)
			{
				this.m_owner.__clearDele_EventOnTakeOffCharSkin(obj);
			}

			// Token: 0x06011216 RID: 70166 RVA: 0x004726E0 File Offset: 0x004708E0
			public void __callDele_EventOnSkinChangedPreview(string arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnSkinChangedPreview(arg1, arg2);
			}

			// Token: 0x06011217 RID: 70167 RVA: 0x004726F0 File Offset: 0x004708F0
			public void __clearDele_EventOnSkinChangedPreview(string arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnSkinChangedPreview(arg1, arg2);
			}

			// Token: 0x06011218 RID: 70168 RVA: 0x00472700 File Offset: 0x00470900
			public void __callDele_EventOnSkinTicketButtonClick()
			{
				this.m_owner.__callDele_EventOnSkinTicketButtonClick();
			}

			// Token: 0x06011219 RID: 70169 RVA: 0x00472710 File Offset: 0x00470910
			public void __clearDele_EventOnSkinTicketButtonClick()
			{
				this.m_owner.__clearDele_EventOnSkinTicketButtonClick();
			}

			// Token: 0x170034CE RID: 13518
			// (get) Token: 0x0601121A RID: 70170 RVA: 0x00472720 File Offset: 0x00470920
			// (set) Token: 0x0601121B RID: 70171 RVA: 0x00472730 File Offset: 0x00470930
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

			// Token: 0x170034CF RID: 13519
			// (get) Token: 0x0601121C RID: 70172 RVA: 0x00472740 File Offset: 0x00470940
			// (set) Token: 0x0601121D RID: 70173 RVA: 0x00472750 File Offset: 0x00470950
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

			// Token: 0x170034D0 RID: 13520
			// (get) Token: 0x0601121E RID: 70174 RVA: 0x00472760 File Offset: 0x00470960
			// (set) Token: 0x0601121F RID: 70175 RVA: 0x00472770 File Offset: 0x00470970
			public GameObject m_facelifPanel
			{
				get
				{
					return this.m_owner.m_facelifPanel;
				}
				set
				{
					this.m_owner.m_facelifPanel = value;
				}
			}

			// Token: 0x170034D1 RID: 13521
			// (get) Token: 0x06011220 RID: 70176 RVA: 0x00472780 File Offset: 0x00470980
			// (set) Token: 0x06011221 RID: 70177 RVA: 0x00472790 File Offset: 0x00470990
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

			// Token: 0x170034D2 RID: 13522
			// (get) Token: 0x06011222 RID: 70178 RVA: 0x004727A0 File Offset: 0x004709A0
			// (set) Token: 0x06011223 RID: 70179 RVA: 0x004727B0 File Offset: 0x004709B0
			public Button m_closeButton
			{
				get
				{
					return this.m_owner.m_closeButton;
				}
				set
				{
					this.m_owner.m_closeButton = value;
				}
			}

			// Token: 0x170034D3 RID: 13523
			// (get) Token: 0x06011224 RID: 70180 RVA: 0x004727C0 File Offset: 0x004709C0
			// (set) Token: 0x06011225 RID: 70181 RVA: 0x004727D0 File Offset: 0x004709D0
			public Button m_blackBgButton
			{
				get
				{
					return this.m_owner.m_blackBgButton;
				}
				set
				{
					this.m_owner.m_blackBgButton = value;
				}
			}

			// Token: 0x170034D4 RID: 13524
			// (get) Token: 0x06011226 RID: 70182 RVA: 0x004727E0 File Offset: 0x004709E0
			// (set) Token: 0x06011227 RID: 70183 RVA: 0x004727F0 File Offset: 0x004709F0
			public ScrollRect m_skinsScrollRect
			{
				get
				{
					return this.m_owner.m_skinsScrollRect;
				}
				set
				{
					this.m_owner.m_skinsScrollRect = value;
				}
			}

			// Token: 0x170034D5 RID: 13525
			// (get) Token: 0x06011228 RID: 70184 RVA: 0x00472800 File Offset: 0x00470A00
			// (set) Token: 0x06011229 RID: 70185 RVA: 0x00472810 File Offset: 0x00470A10
			public GameObject m_skinSelectContent
			{
				get
				{
					return this.m_owner.m_skinSelectContent;
				}
				set
				{
					this.m_owner.m_skinSelectContent = value;
				}
			}

			// Token: 0x170034D6 RID: 13526
			// (get) Token: 0x0601122A RID: 70186 RVA: 0x00472820 File Offset: 0x00470A20
			// (set) Token: 0x0601122B RID: 70187 RVA: 0x00472830 File Offset: 0x00470A30
			public GameObject m_skinJobGroup
			{
				get
				{
					return this.m_owner.m_skinJobGroup;
				}
				set
				{
					this.m_owner.m_skinJobGroup = value;
				}
			}

			// Token: 0x170034D7 RID: 13527
			// (get) Token: 0x0601122C RID: 70188 RVA: 0x00472840 File Offset: 0x00470A40
			// (set) Token: 0x0601122D RID: 70189 RVA: 0x00472850 File Offset: 0x00470A50
			public GameObject m_skinCharGo
			{
				get
				{
					return this.m_owner.m_skinCharGo;
				}
				set
				{
					this.m_owner.m_skinCharGo = value;
				}
			}

			// Token: 0x170034D8 RID: 13528
			// (get) Token: 0x0601122E RID: 70190 RVA: 0x00472860 File Offset: 0x00470A60
			// (set) Token: 0x0601122F RID: 70191 RVA: 0x00472870 File Offset: 0x00470A70
			public Text m_skinDescText
			{
				get
				{
					return this.m_owner.m_skinDescText;
				}
				set
				{
					this.m_owner.m_skinDescText = value;
				}
			}

			// Token: 0x170034D9 RID: 13529
			// (get) Token: 0x06011230 RID: 70192 RVA: 0x00472880 File Offset: 0x00470A80
			// (set) Token: 0x06011231 RID: 70193 RVA: 0x00472890 File Offset: 0x00470A90
			public CommonUIStateController m_buttonGroupStateCtrl
			{
				get
				{
					return this.m_owner.m_buttonGroupStateCtrl;
				}
				set
				{
					this.m_owner.m_buttonGroupStateCtrl = value;
				}
			}

			// Token: 0x170034DA RID: 13530
			// (get) Token: 0x06011232 RID: 70194 RVA: 0x004728A0 File Offset: 0x00470AA0
			// (set) Token: 0x06011233 RID: 70195 RVA: 0x004728B0 File Offset: 0x00470AB0
			public Text m_fromText
			{
				get
				{
					return this.m_owner.m_fromText;
				}
				set
				{
					this.m_owner.m_fromText = value;
				}
			}

			// Token: 0x170034DB RID: 13531
			// (get) Token: 0x06011234 RID: 70196 RVA: 0x004728C0 File Offset: 0x00470AC0
			// (set) Token: 0x06011235 RID: 70197 RVA: 0x004728D0 File Offset: 0x00470AD0
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

			// Token: 0x170034DC RID: 13532
			// (get) Token: 0x06011236 RID: 70198 RVA: 0x004728E0 File Offset: 0x00470AE0
			// (set) Token: 0x06011237 RID: 70199 RVA: 0x004728F0 File Offset: 0x00470AF0
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

			// Token: 0x170034DD RID: 13533
			// (get) Token: 0x06011238 RID: 70200 RVA: 0x00472900 File Offset: 0x00470B00
			// (set) Token: 0x06011239 RID: 70201 RVA: 0x00472910 File Offset: 0x00470B10
			public Text m_infoBuyValueText
			{
				get
				{
					return this.m_owner.m_infoBuyValueText;
				}
				set
				{
					this.m_owner.m_infoBuyValueText = value;
				}
			}

			// Token: 0x170034DE RID: 13534
			// (get) Token: 0x0601123A RID: 70202 RVA: 0x00472920 File Offset: 0x00470B20
			// (set) Token: 0x0601123B RID: 70203 RVA: 0x00472930 File Offset: 0x00470B30
			public Text m_skinTicketCountText
			{
				get
				{
					return this.m_owner.m_skinTicketCountText;
				}
				set
				{
					this.m_owner.m_skinTicketCountText = value;
				}
			}

			// Token: 0x170034DF RID: 13535
			// (get) Token: 0x0601123C RID: 70204 RVA: 0x00472940 File Offset: 0x00470B40
			// (set) Token: 0x0601123D RID: 70205 RVA: 0x00472950 File Offset: 0x00470B50
			public Button m_skinTicketAddButton
			{
				get
				{
					return this.m_owner.m_skinTicketAddButton;
				}
				set
				{
					this.m_owner.m_skinTicketAddButton = value;
				}
			}

			// Token: 0x170034E0 RID: 13536
			// (get) Token: 0x0601123E RID: 70206 RVA: 0x00472960 File Offset: 0x00470B60
			// (set) Token: 0x0601123F RID: 70207 RVA: 0x00472970 File Offset: 0x00470B70
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

			// Token: 0x170034E1 RID: 13537
			// (get) Token: 0x06011240 RID: 70208 RVA: 0x00472980 File Offset: 0x00470B80
			// (set) Token: 0x06011241 RID: 70209 RVA: 0x00472990 File Offset: 0x00470B90
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

			// Token: 0x170034E2 RID: 13538
			// (get) Token: 0x06011242 RID: 70210 RVA: 0x004729A0 File Offset: 0x00470BA0
			// (set) Token: 0x06011243 RID: 70211 RVA: 0x004729B0 File Offset: 0x00470BB0
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

			// Token: 0x170034E3 RID: 13539
			// (get) Token: 0x06011244 RID: 70212 RVA: 0x004729C0 File Offset: 0x00470BC0
			// (set) Token: 0x06011245 RID: 70213 RVA: 0x004729D0 File Offset: 0x00470BD0
			public string m_mode
			{
				get
				{
					return this.m_owner.m_mode;
				}
				set
				{
					this.m_owner.m_mode = value;
				}
			}

			// Token: 0x170034E4 RID: 13540
			// (get) Token: 0x06011246 RID: 70214 RVA: 0x004729E0 File Offset: 0x00470BE0
			// (set) Token: 0x06011247 RID: 70215 RVA: 0x004729F0 File Offset: 0x00470BF0
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

			// Token: 0x170034E5 RID: 13541
			// (get) Token: 0x06011248 RID: 70216 RVA: 0x00472A00 File Offset: 0x00470C00
			// (set) Token: 0x06011249 RID: 70217 RVA: 0x00472A10 File Offset: 0x00470C10
			public int m_curCharSkinIndex
			{
				get
				{
					return this.m_owner.m_curCharSkinIndex;
				}
				set
				{
					this.m_owner.m_curCharSkinIndex = value;
				}
			}

			// Token: 0x170034E6 RID: 13542
			// (get) Token: 0x0601124A RID: 70218 RVA: 0x00472A20 File Offset: 0x00470C20
			// (set) Token: 0x0601124B RID: 70219 RVA: 0x00472A30 File Offset: 0x00470C30
			public ConfigDataHeroInfo m_heroInfo
			{
				get
				{
					return this.m_owner.m_heroInfo;
				}
				set
				{
					this.m_owner.m_heroInfo = value;
				}
			}

			// Token: 0x170034E7 RID: 13543
			// (get) Token: 0x0601124C RID: 70220 RVA: 0x00472A40 File Offset: 0x00470C40
			// (set) Token: 0x0601124D RID: 70221 RVA: 0x00472A50 File Offset: 0x00470C50
			public UISpineGraphic m_playerHeroGraphic
			{
				get
				{
					return this.m_owner.m_playerHeroGraphic;
				}
				set
				{
					this.m_owner.m_playerHeroGraphic = value;
				}
			}

			// Token: 0x170034E8 RID: 13544
			// (get) Token: 0x0601124E RID: 70222 RVA: 0x00472A60 File Offset: 0x00470C60
			// (set) Token: 0x0601124F RID: 70223 RVA: 0x00472A70 File Offset: 0x00470C70
			public ScrollSnapCenter m_skinsScrollSnapCenter
			{
				get
				{
					return this.m_owner.m_skinsScrollSnapCenter;
				}
				set
				{
					this.m_owner.m_skinsScrollSnapCenter = value;
				}
			}

			// Token: 0x170034E9 RID: 13545
			// (get) Token: 0x06011250 RID: 70224 RVA: 0x00472A80 File Offset: 0x00470C80
			// (set) Token: 0x06011251 RID: 70225 RVA: 0x00472A90 File Offset: 0x00470C90
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

			// Token: 0x170034EA RID: 13546
			// (get) Token: 0x06011252 RID: 70226 RVA: 0x00472AA0 File Offset: 0x00470CA0
			// (set) Token: 0x06011253 RID: 70227 RVA: 0x00472AB0 File Offset: 0x00470CB0
			public HeroCharSkinItemUIController m_curSelectHeroCharSkinItemCtrl
			{
				get
				{
					return this.m_owner.m_curSelectHeroCharSkinItemCtrl;
				}
				set
				{
					this.m_owner.m_curSelectHeroCharSkinItemCtrl = value;
				}
			}

			// Token: 0x170034EB RID: 13547
			// (get) Token: 0x06011254 RID: 70228 RVA: 0x00472AC0 File Offset: 0x00470CC0
			// (set) Token: 0x06011255 RID: 70229 RVA: 0x00472AD0 File Offset: 0x00470CD0
			public List<HeroCharSkinItemUIController> m_charSkinCtrlsList
			{
				get
				{
					return this.m_owner.m_charSkinCtrlsList;
				}
				set
				{
					this.m_owner.m_charSkinCtrlsList = value;
				}
			}

			// Token: 0x06011256 RID: 70230 RVA: 0x00472AE0 File Offset: 0x00470CE0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011257 RID: 70231 RVA: 0x00472AF0 File Offset: 0x00470CF0
			public void LateUpdate()
			{
				this.m_owner.LateUpdate();
			}

			// Token: 0x06011258 RID: 70232 RVA: 0x00472B00 File Offset: 0x00470D00
			public void SetSelectSkinPanelInfo()
			{
				this.m_owner.SetSelectSkinPanelInfo();
			}

			// Token: 0x06011259 RID: 70233 RVA: 0x00472B10 File Offset: 0x00470D10
			public void CreateHeroDefaultSkin()
			{
				this.m_owner.CreateHeroDefaultSkin();
			}

			// Token: 0x0601125A RID: 70234 RVA: 0x00472B20 File Offset: 0x00470D20
			public void SetSkinInfoPanel(HeroCharSkinItemUIController ctrl)
			{
				this.m_owner.SetSkinInfoPanel(ctrl);
			}

			// Token: 0x0601125B RID: 70235 RVA: 0x00472B30 File Offset: 0x00470D30
			public void SetNotDefaultSkinInfoPanel(HeroCharSkinItemUIController ctrl)
			{
				this.m_owner.SetNotDefaultSkinInfoPanel(ctrl);
			}

			// Token: 0x0601125C RID: 70236 RVA: 0x00472B40 File Offset: 0x00470D40
			public void SetButtonState(HeroCharSkinItemUIController ctrl)
			{
				this.m_owner.SetButtonState(ctrl);
			}

			// Token: 0x0601125D RID: 70237 RVA: 0x00472B50 File Offset: 0x00470D50
			public void SetHeroSkinCharAndSpine(HeroCharSkinItemUIController ctrl)
			{
				this.m_owner.SetHeroSkinCharAndSpine(ctrl);
			}

			// Token: 0x0601125E RID: 70238 RVA: 0x00472B60 File Offset: 0x00470D60
			public void SetDefaultSkinInfoPanel(HeroCharSkinItemUIController ctrl)
			{
				this.m_owner.SetDefaultSkinInfoPanel(ctrl);
			}

			// Token: 0x0601125F RID: 70239 RVA: 0x00472B70 File Offset: 0x00470D70
			public void OnHeroCharSkinItemClick(HeroCharSkinItemUIController ctrl)
			{
				this.m_owner.OnHeroCharSkinItemClick(ctrl);
			}

			// Token: 0x06011260 RID: 70240 RVA: 0x00472B80 File Offset: 0x00470D80
			public void SkinsScrollSnapCenter_OnEndDrag()
			{
				this.m_owner.SkinsScrollSnapCenter_OnEndDrag();
			}

			// Token: 0x06011261 RID: 70241 RVA: 0x00472B90 File Offset: 0x00470D90
			public void OnInfoBuyButtonClick()
			{
				this.m_owner.OnInfoBuyButtonClick();
			}

			// Token: 0x06011262 RID: 70242 RVA: 0x00472BA0 File Offset: 0x00470DA0
			public void OnInfoSwitchButtonClick()
			{
				this.m_owner.OnInfoSwitchButtonClick();
			}

			// Token: 0x06011263 RID: 70243 RVA: 0x00472BB0 File Offset: 0x00470DB0
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06011264 RID: 70244 RVA: 0x00472BC0 File Offset: 0x00470DC0
			public void OnSkinTicketButtonClick()
			{
				this.m_owner.OnSkinTicketButtonClick();
			}

			// Token: 0x06011265 RID: 70245 RVA: 0x00472BD0 File Offset: 0x00470DD0
			public void OnBuyButtonClick()
			{
				this.m_owner.OnBuyButtonClick();
			}

			// Token: 0x04009D95 RID: 40341
			private HeroSkinChangeUIController m_owner;
		}
	}
}
