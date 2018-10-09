using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
	// Token: 0x02000D91 RID: 3473
	[HotFix]
	public class HeroDetailAddExpUIController : UIControllerBase
	{
		// Token: 0x060103C0 RID: 66496 RVA: 0x0043DC3C File Offset: 0x0043BE3C
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
			this.m_closeAddExpButton.onClick.AddListener(new UnityAction(this.CloseAddExpPanel));
			this.m_addExpConfirmPanelBgButton.onClick.AddListener(new UnityAction(this.OnAddExpCanelButtonClick));
			this.m_addExpConfirmPanelCancelButton.onClick.AddListener(new UnityAction(this.OnAddExpCanelButtonClick));
			this.m_addExpConfirmPanelConfirmButton.onClick.AddListener(new UnityAction(this.OnAddExpConfirmButtonClick));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x060103C1 RID: 66497 RVA: 0x0043DD48 File Offset: 0x0043BF48
		public void UpdateViewInAddExpState(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInAddExpStateHero_hotfix != null)
			{
				this.m_UpdateViewInAddExpStateHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Input.multiTouchEnabled = false;
			this.m_hero = hero;
			this.UpdateAddExpPanel();
			if (this.m_isFirstIn)
			{
				CommonUIStateController component = this.m_rootGo.GetComponent<CommonUIStateController>();
				UIUtility.SetUIStateOpen(component, "Show", null, false, true);
				this.m_isFirstIn = false;
				this.m_addExpPanelLevelUpEffect.SetActive(false);
				this.m_addExpPanelLevelUp3DEffect.SetActive(false);
				this.m_addExpConfirmPanelTip1.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AddExpTitleTip);
				this.m_addExpConfirmPanelTip2.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AddExpContentTip);
			}
		}

		// Token: 0x060103C2 RID: 66498 RVA: 0x0043DE48 File Offset: 0x0043C048
		public void UpdateAddExpPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateAddExpPanel_hotfix != null)
			{
				this.m_UpdateAddExpPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_addExpPanelLvValueText.gameObject.SetActive(true);
			this.m_addExpPanelLvValueText.text = this.m_hero.Level.ToString();
			int num = this.m_playerContext.GetPlayerLevel() + this.m_configDataLoader.ConfigableConstId_HeroLevelUpCeiling;
			int configableConstId_PlayerLevelMaxLevel = this.m_configDataLoader.ConfigableConstId_PlayerLevelMaxLevel;
			this.m_addExpPanelLvValueMaxText.text = ((num >= configableConstId_PlayerLevelMaxLevel) ? configableConstId_PlayerLevelMaxLevel : num).ToString();
			this.m_addExpPanelExpValueText.text = (this.m_playerContext.GetHeroNextLevelExp(this.m_hero.Level) - this.m_hero.Exp).ToString();
			this.m_addExpPanelHeroNameText.text = this.m_hero.HeroInfo.Name;
			ConfigDataCharImageInfo charImageInfo = this.m_hero.HeroInfo.GetCharImageInfo(this.m_hero.StarLevel);
			if (charImageInfo != null)
			{
				this.m_addExpPanelHeroIconImg.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("expItem");
			GameObjectUtility.InactiveComponentList<HeroExpItemUIController>(this.m_expCtrlList);
			int num2 = 0;
			List<BagItemBase> list = new List<BagItemBase>();
			foreach (BagItemBase bagItemBase in this.m_playerContext.GetBagItems())
			{
				if (bagItemBase.ItemInfo != null && bagItemBase.ItemInfo.FuncType == ItemFuncType.ItemFuncType_HeroEXP)
				{
					list.Add(bagItemBase);
				}
			}
			list.Sort((BagItemBase a, BagItemBase b) => a.ItemInfo.Rank - b.ItemInfo.Rank);
			foreach (BagItemBase bagItem in list)
			{
				HeroExpItemUIController heroExpItemUIController;
				if (this.m_expCtrlList.Count - 1 < num2)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					heroExpItemUIController = gameObject.GetComponent<HeroExpItemUIController>();
					heroExpItemUIController.OnItemPointDown += this.OnExpItemClick;
					heroExpItemUIController.OnItemPointUp += this.OnLocalAddExpFinishedSendReq;
					gameObject.transform.SetParent(this.m_addExpScrollViewContent.transform, false);
					this.m_expCtrlList.Add(heroExpItemUIController);
				}
				else
				{
					heroExpItemUIController = this.m_expCtrlList[num2];
				}
				num2++;
				heroExpItemUIController.InitExpItem(bagItem, 0.5f, 0.1f, new Action(this.LocalAddExpTick));
			}
			this.m_addExpPanelNoExpItemTip.SetActive(list.Count == 0);
			float num3 = 0f;
			int heroNextLevelExp = this.m_playerContext.GetHeroNextLevelExp(this.m_hero.Level);
			if (heroNextLevelExp != 0)
			{
				num3 = (float)this.m_hero.Exp / (float)heroNextLevelExp;
			}
			RectTransform component = this.m_addExpPanelExpProgressImg.GetComponent<RectTransform>();
			if (this.m_expProgressBarWidth2 == 0f)
			{
				this.m_expProgressBarWidth2 = component.sizeDelta.x;
			}
			float x = this.m_expProgressBarWidth2 * num3;
			component.sizeDelta = new Vector2(x, component.sizeDelta.y);
			this.m_heroLastLevel = this.m_hero.Level;
		}

		// Token: 0x060103C3 RID: 66499 RVA: 0x0043E23C File Offset: 0x0043C43C
		private void HeroAddExpLvUpEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroAddExpLvUpEffect_hotfix != null)
			{
				this.m_HeroAddExpLvUpEffect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_addExpPanelLevelUp3DEffect.SetActive(true);
			this.m_addExpPanelLevelUpEffect.SetActive(true);
			UIUtility.ReplayTween(this.m_addExpPanelLevelUpEffect, delegate
			{
				this.m_addExpPanelLevelUpEffect.SetActive(false);
				this.m_addExpPanelLevelUp3DEffect.SetActive(false);
			});
		}

		// Token: 0x060103C4 RID: 66500 RVA: 0x0043E2CC File Offset: 0x0043C4CC
		private void OnExpItemClick(HeroExpItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExpItemClickHeroExpItemUIController_hotfix != null)
			{
				this.m_OnExpItemClickHeroExpItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curExpBagItemCtrl = ctrl;
			this.m_tempHeroLevel = this.m_hero.Level;
			this.m_tempHeroExp = this.m_hero.Exp;
			this.m_tempAddExp = ctrl.AddExpValue;
			this.m_totalUseExpItemCount = 0;
			this.m_addImageCoroutineCount = 0;
		}

		// Token: 0x060103C5 RID: 66501 RVA: 0x0043E380 File Offset: 0x0043C580
		private void LocalAddExpTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LocalAddExpTick_hotfix != null)
			{
				this.m_LocalAddExpTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_totalUseExpItemCount++;
			this.m_heroLastLevel = this.m_tempHeroLevel;
			int heroNextLevelExp = this.m_playerContext.GetHeroNextLevelExp(this.m_tempHeroLevel);
			int i = this.m_tempHeroExp + this.m_tempAddExp;
			while (i >= heroNextLevelExp)
			{
				if (this.m_playerContext.IsCurrentLevelMaxHeroLevel(this.m_tempHeroLevel))
				{
					this.m_tempHeroExp = heroNextLevelExp;
				}
				else
				{
					this.m_tempHeroLevel++;
					i -= heroNextLevelExp;
					this.m_tempHeroExp = i;
					heroNextLevelExp = this.m_playerContext.GetHeroNextLevelExp(this.m_tempHeroLevel);
					if (i > 0)
					{
						continue;
					}
				}
				IL_F4:
				this.m_canLastClickExpItemUse = true;
				if (!this.CanExpItemUse(this.m_tempHeroLevel, i))
				{
					this.m_totalUseExpItemCount--;
					this.m_curExpBagItemCtrl.IsPointDown = false;
					this.m_canLastClickExpItemUse = false;
					return;
				}
				this.m_addExpPanelLvValueText.text = this.m_tempHeroLevel.ToString();
				float num = (float)(this.m_playerContext.GetHeroNextLevelExp(this.m_tempHeroLevel) - this.m_tempHeroExp);
				this.m_addExpPanelExpValueText.text = ((num <= 0f) ? "0" : num.ToString());
				this.m_isHeroLvUp = (this.m_tempHeroLevel - this.m_hero.Level > 0);
				float num2 = (float)i / (float)this.m_playerContext.GetHeroNextLevelExp(this.m_tempHeroLevel);
				float desWidth = this.m_expProgressBarWidth2 * num2;
				num2 = (float)this.m_tempAddExp / (float)this.m_playerContext.GetHeroNextLevelExp(this.m_tempHeroLevel);
				float totalWidth = this.m_expProgressBarWidth2 * num2;
				base.StartCoroutine(this.AddProgressImageWidth(totalWidth, desWidth, 0.1f));
				AudioUtility.PlaySound(this.m_configDataLoader.UtilityGetSound(SoundTableId.SoundTableId_AddExpToHero));
				return;
			}
			this.m_tempHeroExp = i;
			goto IL_F4;
		}

		// Token: 0x060103C6 RID: 66502 RVA: 0x0043E5AC File Offset: 0x0043C7AC
		[DebuggerHidden]
		private IEnumerator AddProgressImageWidth(float totalWidth, float DesWidth, float intervalTime = 0.1f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddProgressImageWidthSingleSingleSingle_hotfix != null)
			{
				return (IEnumerator)this.m_AddProgressImageWidthSingleSingleSingle_hotfix.call(new object[]
				{
					this,
					totalWidth,
					DesWidth,
					intervalTime
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDetailAddExpUIController.<AddProgressImageWidth>c__Iterator0 <AddProgressImageWidth>c__Iterator = new HeroDetailAddExpUIController.<AddProgressImageWidth>c__Iterator0();
			<AddProgressImageWidth>c__Iterator.totalWidth = totalWidth;
			<AddProgressImageWidth>c__Iterator.intervalTime = intervalTime;
			<AddProgressImageWidth>c__Iterator.DesWidth = DesWidth;
			<AddProgressImageWidth>c__Iterator.$this = this;
			return <AddProgressImageWidth>c__Iterator;
		}

		// Token: 0x060103C7 RID: 66503 RVA: 0x0043E66C File Offset: 0x0043C86C
		private void OnLocalAddExpFinishedSendReq(int usedCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLocalAddExpFinishedSendReqInt32_hotfix != null)
			{
				this.m_OnLocalAddExpFinishedSendReqInt32_hotfix.call(new object[]
				{
					this,
					usedCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_totalUseExpItemCount = usedCount;
			if (this.m_curExpBagItemCtrl == null)
			{
				return;
			}
			if (this.EventOnHeroAddExp != null)
			{
				if (this.m_totalUseExpItemCount == 1)
				{
					this.OnExpItemClick(this.m_curExpBagItemCtrl);
					this.LocalAddExpTick();
					if (this.m_canLastClickExpItemUse)
					{
						base.StartCoroutine(this.WaitTimeThenDoEvent(this.m_totalUseExpItemCount));
					}
				}
				else if (this.m_canLastClickExpItemUse)
				{
					base.StartCoroutine(this.WaitTimeThenDoEvent(this.m_totalUseExpItemCount));
				}
				else
				{
					base.StartCoroutine(this.WaitTimeThenDoEvent(this.m_totalUseExpItemCount - 1));
				}
			}
		}

		// Token: 0x060103C8 RID: 66504 RVA: 0x0043E77C File Offset: 0x0043C97C
		[DebuggerHidden]
		private IEnumerator WaitTimeThenDoEvent(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WaitTimeThenDoEventInt32_hotfix != null)
			{
				return (IEnumerator)this.m_WaitTimeThenDoEventInt32_hotfix.call(new object[]
				{
					this,
					count
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDetailAddExpUIController.<WaitTimeThenDoEvent>c__Iterator1 <WaitTimeThenDoEvent>c__Iterator = new HeroDetailAddExpUIController.<WaitTimeThenDoEvent>c__Iterator1();
			<WaitTimeThenDoEvent>c__Iterator.count = count;
			<WaitTimeThenDoEvent>c__Iterator.$this = this;
			return <WaitTimeThenDoEvent>c__Iterator;
		}

		// Token: 0x060103C9 RID: 66505 RVA: 0x0043E810 File Offset: 0x0043CA10
		private bool CanExpItemUse(int heroLv, int herpExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanExpItemUseInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanExpItemUseInt32Int32_hotfix.call(new object[]
				{
					this,
					heroLv,
					herpExp
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.GetPlayerLevel() + this.m_configDataLoader.ConfigableConstId_HeroLevelUpCeiling;
			if (heroLv <= num)
			{
				if (herpExp > this.m_playerContext.GetHeroNextLevelExp(heroLv))
				{
					if (!this.m_addExpConfirmPanel.activeSelf)
					{
						CommonUIStateController component = this.m_addExpConfirmPanel.GetComponent<CommonUIStateController>();
						UIUtility.SetUIStateOpen(component, "Show", null, false, true);
					}
					return false;
				}
			}
			else if (heroLv > num)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_AddExp_ExpMax, 2f, null, true);
				return false;
			}
			return this.m_curExpBagItemCtrl.BagItem.Nums >= this.m_totalUseExpItemCount;
		}

		// Token: 0x060103CA RID: 66506 RVA: 0x0043E93C File Offset: 0x0043CB3C
		private void OnAddExpConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddExpConfirmButtonClick_hotfix != null)
			{
				this.m_OnAddExpConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.WaitTimeThenDoEvent(1));
			this.OnAddExpCanelButtonClick();
		}

		// Token: 0x060103CB RID: 66507 RVA: 0x0043E9B0 File Offset: 0x0043CBB0
		private void OnAddExpCanelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddExpCanelButtonClick_hotfix != null)
			{
				this.m_OnAddExpCanelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_addExpConfirmPanel.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateClose(component, "Close", null, false, true);
		}

		// Token: 0x060103CC RID: 66508 RVA: 0x0043EA2C File Offset: 0x0043CC2C
		private void CloseAddExpPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAddExpPanel_hotfix != null)
			{
				this.m_CloseAddExpPanel_hotfix.call(new object[]
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
					this.EventOnReturn();
				}
			}, false, true);
			this.m_addExpPanelLvValueText.gameObject.SetActive(false);
			this.m_addExpPanelLevelUpEffect.SetActive(false);
			this.m_addExpPanelLevelUp3DEffect.SetActive(false);
			this.m_isFirstIn = true;
			Input.multiTouchEnabled = true;
		}

		// Token: 0x060103CD RID: 66509 RVA: 0x0043EAE8 File Offset: 0x0043CCE8
		public void UseFirstExpBagItemForUserGuide(HeroExpItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UseFirstExpBagItemForUserGuideHeroExpItemUIController_hotfix != null)
			{
				this.m_UseFirstExpBagItemForUserGuideHeroExpItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_expCtrlList.Count == 0 || ctrl == null)
			{
				return;
			}
			this.OnExpItemClick(ctrl);
			this.OnLocalAddExpFinishedSendReq(1);
		}

		// Token: 0x1400036B RID: 875
		// (add) Token: 0x060103CE RID: 66510 RVA: 0x0043EB84 File Offset: 0x0043CD84
		// (remove) Token: 0x060103CF RID: 66511 RVA: 0x0043EC20 File Offset: 0x0043CE20
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

		// Token: 0x1400036C RID: 876
		// (add) Token: 0x060103D0 RID: 66512 RVA: 0x0043ECBC File Offset: 0x0043CEBC
		// (remove) Token: 0x060103D1 RID: 66513 RVA: 0x0043ED58 File Offset: 0x0043CF58
		public event Action<int, BagItemBase, int, Action> EventOnHeroAddExp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroAddExpAction`4_hotfix != null)
				{
					this.m_add_EventOnHeroAddExpAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, BagItemBase, int, Action> action = this.EventOnHeroAddExp;
				Action<int, BagItemBase, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, BagItemBase, int, Action>>(ref this.EventOnHeroAddExp, (Action<int, BagItemBase, int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroAddExpAction`4_hotfix != null)
				{
					this.m_remove_EventOnHeroAddExpAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, BagItemBase, int, Action> action = this.EventOnHeroAddExp;
				Action<int, BagItemBase, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, BagItemBase, int, Action>>(ref this.EventOnHeroAddExp, (Action<int, BagItemBase, int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x060103D2 RID: 66514 RVA: 0x0043EDF4 File Offset: 0x0043CFF4
		// (set) Token: 0x060103D3 RID: 66515 RVA: 0x0043EE14 File Offset: 0x0043D014
		[DoNotToLua]
		public new HeroDetailAddExpUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDetailAddExpUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060103D4 RID: 66516 RVA: 0x0043EE20 File Offset: 0x0043D020
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060103D5 RID: 66517 RVA: 0x0043EE2C File Offset: 0x0043D02C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060103D6 RID: 66518 RVA: 0x0043EE34 File Offset: 0x0043D034
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060103D7 RID: 66519 RVA: 0x0043EE3C File Offset: 0x0043D03C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060103D8 RID: 66520 RVA: 0x0043EE50 File Offset: 0x0043D050
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060103D9 RID: 66521 RVA: 0x0043EE58 File Offset: 0x0043D058
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060103DA RID: 66522 RVA: 0x0043EE64 File Offset: 0x0043D064
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060103DB RID: 66523 RVA: 0x0043EE70 File Offset: 0x0043D070
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060103DC RID: 66524 RVA: 0x0043EE7C File Offset: 0x0043D07C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060103DD RID: 66525 RVA: 0x0043EE88 File Offset: 0x0043D088
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060103DE RID: 66526 RVA: 0x0043EE94 File Offset: 0x0043D094
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060103DF RID: 66527 RVA: 0x0043EEA0 File Offset: 0x0043D0A0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060103E0 RID: 66528 RVA: 0x0043EEAC File Offset: 0x0043D0AC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060103E1 RID: 66529 RVA: 0x0043EEB8 File Offset: 0x0043D0B8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060103E2 RID: 66530 RVA: 0x0043EEC4 File Offset: 0x0043D0C4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060103E3 RID: 66531 RVA: 0x0043EECC File Offset: 0x0043D0CC
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x060103E4 RID: 66532 RVA: 0x0043EEEC File Offset: 0x0043D0EC
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x060103E5 RID: 66533 RVA: 0x0043EEF8 File Offset: 0x0043D0F8
		private void __callDele_EventOnHeroAddExp(int arg1, BagItemBase arg2, int arg3, Action arg4)
		{
			Action<int, BagItemBase, int, Action> eventOnHeroAddExp = this.EventOnHeroAddExp;
			if (eventOnHeroAddExp != null)
			{
				eventOnHeroAddExp(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x060103E6 RID: 66534 RVA: 0x0043EF20 File Offset: 0x0043D120
		private void __clearDele_EventOnHeroAddExp(int arg1, BagItemBase arg2, int arg3, Action arg4)
		{
			this.EventOnHeroAddExp = null;
		}

		// Token: 0x060103EA RID: 66538 RVA: 0x0043EF7C File Offset: 0x0043D17C
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
					this.m_UpdateViewInAddExpStateHero_hotfix = (luaObj.RawGet("UpdateViewInAddExpState") as LuaFunction);
					this.m_UpdateAddExpPanel_hotfix = (luaObj.RawGet("UpdateAddExpPanel") as LuaFunction);
					this.m_HeroAddExpLvUpEffect_hotfix = (luaObj.RawGet("HeroAddExpLvUpEffect") as LuaFunction);
					this.m_OnExpItemClickHeroExpItemUIController_hotfix = (luaObj.RawGet("OnExpItemClick") as LuaFunction);
					this.m_LocalAddExpTick_hotfix = (luaObj.RawGet("LocalAddExpTick") as LuaFunction);
					this.m_AddProgressImageWidthSingleSingleSingle_hotfix = (luaObj.RawGet("AddProgressImageWidth") as LuaFunction);
					this.m_OnLocalAddExpFinishedSendReqInt32_hotfix = (luaObj.RawGet("OnLocalAddExpFinishedSendReq") as LuaFunction);
					this.m_WaitTimeThenDoEventInt32_hotfix = (luaObj.RawGet("WaitTimeThenDoEvent") as LuaFunction);
					this.m_CanExpItemUseInt32Int32_hotfix = (luaObj.RawGet("CanExpItemUse") as LuaFunction);
					this.m_OnAddExpConfirmButtonClick_hotfix = (luaObj.RawGet("OnAddExpConfirmButtonClick") as LuaFunction);
					this.m_OnAddExpCanelButtonClick_hotfix = (luaObj.RawGet("OnAddExpCanelButtonClick") as LuaFunction);
					this.m_CloseAddExpPanel_hotfix = (luaObj.RawGet("CloseAddExpPanel") as LuaFunction);
					this.m_UseFirstExpBagItemForUserGuideHeroExpItemUIController_hotfix = (luaObj.RawGet("UseFirstExpBagItemForUserGuide") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnHeroAddExpAction`4_hotfix = (luaObj.RawGet("add_EventOnHeroAddExp") as LuaFunction);
					this.m_remove_EventOnHeroAddExpAction`4_hotfix = (luaObj.RawGet("remove_EventOnHeroAddExp") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060103EB RID: 66539 RVA: 0x0043F1F0 File Offset: 0x0043D3F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDetailAddExpUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400971F RID: 38687
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rootGo;

		// Token: 0x04009720 RID: 38688
		[AutoBind("./ReturnBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeAddExpButton;

		// Token: 0x04009721 RID: 38689
		[AutoBind("./Detail/ExpItemScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addExpScrollViewContent;

		// Token: 0x04009722 RID: 38690
		[AutoBind("./Detail/HeroInfoGroup/Lv/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_addExpPanelLvValueText;

		// Token: 0x04009723 RID: 38691
		[AutoBind("./Detail/HeroInfoGroup/Lv/ValueText/MaxText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_addExpPanelLvValueMaxText;

		// Token: 0x04009724 RID: 38692
		[AutoBind("./Detail/HeroInfoGroup/HeroNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_addExpPanelHeroNameText;

		// Token: 0x04009725 RID: 38693
		[AutoBind("./Detail/LevelUpEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addExpPanelLevelUpEffect;

		// Token: 0x04009726 RID: 38694
		[AutoBind("./Detail/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_addExpPanelHeroIconImg;

		// Token: 0x04009727 RID: 38695
		[AutoBind("./Detail/Exp/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_addExpPanelExpValueText;

		// Token: 0x04009728 RID: 38696
		[AutoBind("./Detail/Exp/ProgressImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_addExpPanelExpProgressImg;

		// Token: 0x04009729 RID: 38697
		[AutoBind("./Detail/U_LevelUp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addExpPanelLevelUp3DEffect;

		// Token: 0x0400972A RID: 38698
		[AutoBind("./Detail/NoExpItemTip", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addExpPanelNoExpItemTip;

		// Token: 0x0400972B RID: 38699
		[AutoBind("./Detail/ConfirmPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addExpConfirmPanel;

		// Token: 0x0400972C RID: 38700
		[AutoBind("./Detail/ConfirmPanel/Tip1", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_addExpConfirmPanelTip1;

		// Token: 0x0400972D RID: 38701
		[AutoBind("./Detail/ConfirmPanel/Tip2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_addExpConfirmPanelTip2;

		// Token: 0x0400972E RID: 38702
		[AutoBind("./Detail/ConfirmPanel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addExpConfirmPanelConfirmButton;

		// Token: 0x0400972F RID: 38703
		[AutoBind("./Detail/ConfirmPanel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addExpConfirmPanelCancelButton;

		// Token: 0x04009730 RID: 38704
		[AutoBind("./Detail/ConfirmPanel/BgButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addExpConfirmPanelBgButton;

		// Token: 0x04009733 RID: 38707
		private bool m_isHeroLvUp;

		// Token: 0x04009734 RID: 38708
		private bool m_isFirstIn = true;

		// Token: 0x04009735 RID: 38709
		private bool m_canLastClickExpItemUse = true;

		// Token: 0x04009736 RID: 38710
		private Hero m_hero;

		// Token: 0x04009737 RID: 38711
		private float m_expProgressBarWidth2;

		// Token: 0x04009738 RID: 38712
		private int m_totalUseExpItemCount;

		// Token: 0x04009739 RID: 38713
		private int m_tempHeroLevel;

		// Token: 0x0400973A RID: 38714
		private int m_tempHeroExp;

		// Token: 0x0400973B RID: 38715
		private int m_tempAddExp;

		// Token: 0x0400973C RID: 38716
		private int m_heroLastLevel;

		// Token: 0x0400973D RID: 38717
		private HeroExpItemUIController m_curExpBagItemCtrl;

		// Token: 0x0400973E RID: 38718
		public List<HeroExpItemUIController> m_expCtrlList = new List<HeroExpItemUIController>();

		// Token: 0x0400973F RID: 38719
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009740 RID: 38720
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009741 RID: 38721
		private int m_addImageCoroutineCount;

		// Token: 0x04009742 RID: 38722
		[DoNotToLua]
		private HeroDetailAddExpUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009744 RID: 38724
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009745 RID: 38725
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009746 RID: 38726
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009747 RID: 38727
		private LuaFunction m_UpdateViewInAddExpStateHero_hotfix;

		// Token: 0x04009748 RID: 38728
		private LuaFunction m_UpdateAddExpPanel_hotfix;

		// Token: 0x04009749 RID: 38729
		private LuaFunction m_HeroAddExpLvUpEffect_hotfix;

		// Token: 0x0400974A RID: 38730
		private LuaFunction m_OnExpItemClickHeroExpItemUIController_hotfix;

		// Token: 0x0400974B RID: 38731
		private LuaFunction m_LocalAddExpTick_hotfix;

		// Token: 0x0400974C RID: 38732
		private LuaFunction m_AddProgressImageWidthSingleSingleSingle_hotfix;

		// Token: 0x0400974D RID: 38733
		private LuaFunction m_OnLocalAddExpFinishedSendReqInt32_hotfix;

		// Token: 0x0400974E RID: 38734
		private LuaFunction m_WaitTimeThenDoEventInt32_hotfix;

		// Token: 0x0400974F RID: 38735
		private LuaFunction m_CanExpItemUseInt32Int32_hotfix;

		// Token: 0x04009750 RID: 38736
		private LuaFunction m_OnAddExpConfirmButtonClick_hotfix;

		// Token: 0x04009751 RID: 38737
		private LuaFunction m_OnAddExpCanelButtonClick_hotfix;

		// Token: 0x04009752 RID: 38738
		private LuaFunction m_CloseAddExpPanel_hotfix;

		// Token: 0x04009753 RID: 38739
		private LuaFunction m_UseFirstExpBagItemForUserGuideHeroExpItemUIController_hotfix;

		// Token: 0x04009754 RID: 38740
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04009755 RID: 38741
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04009756 RID: 38742
		private LuaFunction m_add_EventOnHeroAddExpAction;

		// Token: 0x04009757 RID: 38743
		private LuaFunction m_remove_EventOnHeroAddExpAction;

		// Token: 0x02000D92 RID: 3474
		public new class LuaExportHelper
		{
			// Token: 0x060103EC RID: 66540 RVA: 0x0043F258 File Offset: 0x0043D458
			public LuaExportHelper(HeroDetailAddExpUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060103ED RID: 66541 RVA: 0x0043F268 File Offset: 0x0043D468
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060103EE RID: 66542 RVA: 0x0043F278 File Offset: 0x0043D478
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060103EF RID: 66543 RVA: 0x0043F288 File Offset: 0x0043D488
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060103F0 RID: 66544 RVA: 0x0043F298 File Offset: 0x0043D498
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060103F1 RID: 66545 RVA: 0x0043F2B0 File Offset: 0x0043D4B0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060103F2 RID: 66546 RVA: 0x0043F2C0 File Offset: 0x0043D4C0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060103F3 RID: 66547 RVA: 0x0043F2D0 File Offset: 0x0043D4D0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060103F4 RID: 66548 RVA: 0x0043F2E0 File Offset: 0x0043D4E0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060103F5 RID: 66549 RVA: 0x0043F2F0 File Offset: 0x0043D4F0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060103F6 RID: 66550 RVA: 0x0043F300 File Offset: 0x0043D500
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060103F7 RID: 66551 RVA: 0x0043F310 File Offset: 0x0043D510
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060103F8 RID: 66552 RVA: 0x0043F320 File Offset: 0x0043D520
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060103F9 RID: 66553 RVA: 0x0043F330 File Offset: 0x0043D530
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060103FA RID: 66554 RVA: 0x0043F340 File Offset: 0x0043D540
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060103FB RID: 66555 RVA: 0x0043F350 File Offset: 0x0043D550
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060103FC RID: 66556 RVA: 0x0043F360 File Offset: 0x0043D560
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x060103FD RID: 66557 RVA: 0x0043F370 File Offset: 0x0043D570
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x060103FE RID: 66558 RVA: 0x0043F380 File Offset: 0x0043D580
			public void __callDele_EventOnHeroAddExp(int arg1, BagItemBase arg2, int arg3, Action arg4)
			{
				this.m_owner.__callDele_EventOnHeroAddExp(arg1, arg2, arg3, arg4);
			}

			// Token: 0x060103FF RID: 66559 RVA: 0x0043F394 File Offset: 0x0043D594
			public void __clearDele_EventOnHeroAddExp(int arg1, BagItemBase arg2, int arg3, Action arg4)
			{
				this.m_owner.__clearDele_EventOnHeroAddExp(arg1, arg2, arg3, arg4);
			}

			// Token: 0x170031F5 RID: 12789
			// (get) Token: 0x06010400 RID: 66560 RVA: 0x0043F3A8 File Offset: 0x0043D5A8
			// (set) Token: 0x06010401 RID: 66561 RVA: 0x0043F3B8 File Offset: 0x0043D5B8
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

			// Token: 0x170031F6 RID: 12790
			// (get) Token: 0x06010402 RID: 66562 RVA: 0x0043F3C8 File Offset: 0x0043D5C8
			// (set) Token: 0x06010403 RID: 66563 RVA: 0x0043F3D8 File Offset: 0x0043D5D8
			public Button m_closeAddExpButton
			{
				get
				{
					return this.m_owner.m_closeAddExpButton;
				}
				set
				{
					this.m_owner.m_closeAddExpButton = value;
				}
			}

			// Token: 0x170031F7 RID: 12791
			// (get) Token: 0x06010404 RID: 66564 RVA: 0x0043F3E8 File Offset: 0x0043D5E8
			// (set) Token: 0x06010405 RID: 66565 RVA: 0x0043F3F8 File Offset: 0x0043D5F8
			public GameObject m_addExpScrollViewContent
			{
				get
				{
					return this.m_owner.m_addExpScrollViewContent;
				}
				set
				{
					this.m_owner.m_addExpScrollViewContent = value;
				}
			}

			// Token: 0x170031F8 RID: 12792
			// (get) Token: 0x06010406 RID: 66566 RVA: 0x0043F408 File Offset: 0x0043D608
			// (set) Token: 0x06010407 RID: 66567 RVA: 0x0043F418 File Offset: 0x0043D618
			public Text m_addExpPanelLvValueText
			{
				get
				{
					return this.m_owner.m_addExpPanelLvValueText;
				}
				set
				{
					this.m_owner.m_addExpPanelLvValueText = value;
				}
			}

			// Token: 0x170031F9 RID: 12793
			// (get) Token: 0x06010408 RID: 66568 RVA: 0x0043F428 File Offset: 0x0043D628
			// (set) Token: 0x06010409 RID: 66569 RVA: 0x0043F438 File Offset: 0x0043D638
			public Text m_addExpPanelLvValueMaxText
			{
				get
				{
					return this.m_owner.m_addExpPanelLvValueMaxText;
				}
				set
				{
					this.m_owner.m_addExpPanelLvValueMaxText = value;
				}
			}

			// Token: 0x170031FA RID: 12794
			// (get) Token: 0x0601040A RID: 66570 RVA: 0x0043F448 File Offset: 0x0043D648
			// (set) Token: 0x0601040B RID: 66571 RVA: 0x0043F458 File Offset: 0x0043D658
			public Text m_addExpPanelHeroNameText
			{
				get
				{
					return this.m_owner.m_addExpPanelHeroNameText;
				}
				set
				{
					this.m_owner.m_addExpPanelHeroNameText = value;
				}
			}

			// Token: 0x170031FB RID: 12795
			// (get) Token: 0x0601040C RID: 66572 RVA: 0x0043F468 File Offset: 0x0043D668
			// (set) Token: 0x0601040D RID: 66573 RVA: 0x0043F478 File Offset: 0x0043D678
			public GameObject m_addExpPanelLevelUpEffect
			{
				get
				{
					return this.m_owner.m_addExpPanelLevelUpEffect;
				}
				set
				{
					this.m_owner.m_addExpPanelLevelUpEffect = value;
				}
			}

			// Token: 0x170031FC RID: 12796
			// (get) Token: 0x0601040E RID: 66574 RVA: 0x0043F488 File Offset: 0x0043D688
			// (set) Token: 0x0601040F RID: 66575 RVA: 0x0043F498 File Offset: 0x0043D698
			public Image m_addExpPanelHeroIconImg
			{
				get
				{
					return this.m_owner.m_addExpPanelHeroIconImg;
				}
				set
				{
					this.m_owner.m_addExpPanelHeroIconImg = value;
				}
			}

			// Token: 0x170031FD RID: 12797
			// (get) Token: 0x06010410 RID: 66576 RVA: 0x0043F4A8 File Offset: 0x0043D6A8
			// (set) Token: 0x06010411 RID: 66577 RVA: 0x0043F4B8 File Offset: 0x0043D6B8
			public Text m_addExpPanelExpValueText
			{
				get
				{
					return this.m_owner.m_addExpPanelExpValueText;
				}
				set
				{
					this.m_owner.m_addExpPanelExpValueText = value;
				}
			}

			// Token: 0x170031FE RID: 12798
			// (get) Token: 0x06010412 RID: 66578 RVA: 0x0043F4C8 File Offset: 0x0043D6C8
			// (set) Token: 0x06010413 RID: 66579 RVA: 0x0043F4D8 File Offset: 0x0043D6D8
			public Image m_addExpPanelExpProgressImg
			{
				get
				{
					return this.m_owner.m_addExpPanelExpProgressImg;
				}
				set
				{
					this.m_owner.m_addExpPanelExpProgressImg = value;
				}
			}

			// Token: 0x170031FF RID: 12799
			// (get) Token: 0x06010414 RID: 66580 RVA: 0x0043F4E8 File Offset: 0x0043D6E8
			// (set) Token: 0x06010415 RID: 66581 RVA: 0x0043F4F8 File Offset: 0x0043D6F8
			public GameObject m_addExpPanelLevelUp3DEffect
			{
				get
				{
					return this.m_owner.m_addExpPanelLevelUp3DEffect;
				}
				set
				{
					this.m_owner.m_addExpPanelLevelUp3DEffect = value;
				}
			}

			// Token: 0x17003200 RID: 12800
			// (get) Token: 0x06010416 RID: 66582 RVA: 0x0043F508 File Offset: 0x0043D708
			// (set) Token: 0x06010417 RID: 66583 RVA: 0x0043F518 File Offset: 0x0043D718
			public GameObject m_addExpPanelNoExpItemTip
			{
				get
				{
					return this.m_owner.m_addExpPanelNoExpItemTip;
				}
				set
				{
					this.m_owner.m_addExpPanelNoExpItemTip = value;
				}
			}

			// Token: 0x17003201 RID: 12801
			// (get) Token: 0x06010418 RID: 66584 RVA: 0x0043F528 File Offset: 0x0043D728
			// (set) Token: 0x06010419 RID: 66585 RVA: 0x0043F538 File Offset: 0x0043D738
			public GameObject m_addExpConfirmPanel
			{
				get
				{
					return this.m_owner.m_addExpConfirmPanel;
				}
				set
				{
					this.m_owner.m_addExpConfirmPanel = value;
				}
			}

			// Token: 0x17003202 RID: 12802
			// (get) Token: 0x0601041A RID: 66586 RVA: 0x0043F548 File Offset: 0x0043D748
			// (set) Token: 0x0601041B RID: 66587 RVA: 0x0043F558 File Offset: 0x0043D758
			public Text m_addExpConfirmPanelTip1
			{
				get
				{
					return this.m_owner.m_addExpConfirmPanelTip1;
				}
				set
				{
					this.m_owner.m_addExpConfirmPanelTip1 = value;
				}
			}

			// Token: 0x17003203 RID: 12803
			// (get) Token: 0x0601041C RID: 66588 RVA: 0x0043F568 File Offset: 0x0043D768
			// (set) Token: 0x0601041D RID: 66589 RVA: 0x0043F578 File Offset: 0x0043D778
			public Text m_addExpConfirmPanelTip2
			{
				get
				{
					return this.m_owner.m_addExpConfirmPanelTip2;
				}
				set
				{
					this.m_owner.m_addExpConfirmPanelTip2 = value;
				}
			}

			// Token: 0x17003204 RID: 12804
			// (get) Token: 0x0601041E RID: 66590 RVA: 0x0043F588 File Offset: 0x0043D788
			// (set) Token: 0x0601041F RID: 66591 RVA: 0x0043F598 File Offset: 0x0043D798
			public Button m_addExpConfirmPanelConfirmButton
			{
				get
				{
					return this.m_owner.m_addExpConfirmPanelConfirmButton;
				}
				set
				{
					this.m_owner.m_addExpConfirmPanelConfirmButton = value;
				}
			}

			// Token: 0x17003205 RID: 12805
			// (get) Token: 0x06010420 RID: 66592 RVA: 0x0043F5A8 File Offset: 0x0043D7A8
			// (set) Token: 0x06010421 RID: 66593 RVA: 0x0043F5B8 File Offset: 0x0043D7B8
			public Button m_addExpConfirmPanelCancelButton
			{
				get
				{
					return this.m_owner.m_addExpConfirmPanelCancelButton;
				}
				set
				{
					this.m_owner.m_addExpConfirmPanelCancelButton = value;
				}
			}

			// Token: 0x17003206 RID: 12806
			// (get) Token: 0x06010422 RID: 66594 RVA: 0x0043F5C8 File Offset: 0x0043D7C8
			// (set) Token: 0x06010423 RID: 66595 RVA: 0x0043F5D8 File Offset: 0x0043D7D8
			public Button m_addExpConfirmPanelBgButton
			{
				get
				{
					return this.m_owner.m_addExpConfirmPanelBgButton;
				}
				set
				{
					this.m_owner.m_addExpConfirmPanelBgButton = value;
				}
			}

			// Token: 0x17003207 RID: 12807
			// (get) Token: 0x06010424 RID: 66596 RVA: 0x0043F5E8 File Offset: 0x0043D7E8
			// (set) Token: 0x06010425 RID: 66597 RVA: 0x0043F5F8 File Offset: 0x0043D7F8
			public bool m_isHeroLvUp
			{
				get
				{
					return this.m_owner.m_isHeroLvUp;
				}
				set
				{
					this.m_owner.m_isHeroLvUp = value;
				}
			}

			// Token: 0x17003208 RID: 12808
			// (get) Token: 0x06010426 RID: 66598 RVA: 0x0043F608 File Offset: 0x0043D808
			// (set) Token: 0x06010427 RID: 66599 RVA: 0x0043F618 File Offset: 0x0043D818
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

			// Token: 0x17003209 RID: 12809
			// (get) Token: 0x06010428 RID: 66600 RVA: 0x0043F628 File Offset: 0x0043D828
			// (set) Token: 0x06010429 RID: 66601 RVA: 0x0043F638 File Offset: 0x0043D838
			public bool m_canLastClickExpItemUse
			{
				get
				{
					return this.m_owner.m_canLastClickExpItemUse;
				}
				set
				{
					this.m_owner.m_canLastClickExpItemUse = value;
				}
			}

			// Token: 0x1700320A RID: 12810
			// (get) Token: 0x0601042A RID: 66602 RVA: 0x0043F648 File Offset: 0x0043D848
			// (set) Token: 0x0601042B RID: 66603 RVA: 0x0043F658 File Offset: 0x0043D858
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

			// Token: 0x1700320B RID: 12811
			// (get) Token: 0x0601042C RID: 66604 RVA: 0x0043F668 File Offset: 0x0043D868
			// (set) Token: 0x0601042D RID: 66605 RVA: 0x0043F678 File Offset: 0x0043D878
			public float m_expProgressBarWidth2
			{
				get
				{
					return this.m_owner.m_expProgressBarWidth2;
				}
				set
				{
					this.m_owner.m_expProgressBarWidth2 = value;
				}
			}

			// Token: 0x1700320C RID: 12812
			// (get) Token: 0x0601042E RID: 66606 RVA: 0x0043F688 File Offset: 0x0043D888
			// (set) Token: 0x0601042F RID: 66607 RVA: 0x0043F698 File Offset: 0x0043D898
			public int m_totalUseExpItemCount
			{
				get
				{
					return this.m_owner.m_totalUseExpItemCount;
				}
				set
				{
					this.m_owner.m_totalUseExpItemCount = value;
				}
			}

			// Token: 0x1700320D RID: 12813
			// (get) Token: 0x06010430 RID: 66608 RVA: 0x0043F6A8 File Offset: 0x0043D8A8
			// (set) Token: 0x06010431 RID: 66609 RVA: 0x0043F6B8 File Offset: 0x0043D8B8
			public int m_tempHeroLevel
			{
				get
				{
					return this.m_owner.m_tempHeroLevel;
				}
				set
				{
					this.m_owner.m_tempHeroLevel = value;
				}
			}

			// Token: 0x1700320E RID: 12814
			// (get) Token: 0x06010432 RID: 66610 RVA: 0x0043F6C8 File Offset: 0x0043D8C8
			// (set) Token: 0x06010433 RID: 66611 RVA: 0x0043F6D8 File Offset: 0x0043D8D8
			public int m_tempHeroExp
			{
				get
				{
					return this.m_owner.m_tempHeroExp;
				}
				set
				{
					this.m_owner.m_tempHeroExp = value;
				}
			}

			// Token: 0x1700320F RID: 12815
			// (get) Token: 0x06010434 RID: 66612 RVA: 0x0043F6E8 File Offset: 0x0043D8E8
			// (set) Token: 0x06010435 RID: 66613 RVA: 0x0043F6F8 File Offset: 0x0043D8F8
			public int m_tempAddExp
			{
				get
				{
					return this.m_owner.m_tempAddExp;
				}
				set
				{
					this.m_owner.m_tempAddExp = value;
				}
			}

			// Token: 0x17003210 RID: 12816
			// (get) Token: 0x06010436 RID: 66614 RVA: 0x0043F708 File Offset: 0x0043D908
			// (set) Token: 0x06010437 RID: 66615 RVA: 0x0043F718 File Offset: 0x0043D918
			public int m_heroLastLevel
			{
				get
				{
					return this.m_owner.m_heroLastLevel;
				}
				set
				{
					this.m_owner.m_heroLastLevel = value;
				}
			}

			// Token: 0x17003211 RID: 12817
			// (get) Token: 0x06010438 RID: 66616 RVA: 0x0043F728 File Offset: 0x0043D928
			// (set) Token: 0x06010439 RID: 66617 RVA: 0x0043F738 File Offset: 0x0043D938
			public HeroExpItemUIController m_curExpBagItemCtrl
			{
				get
				{
					return this.m_owner.m_curExpBagItemCtrl;
				}
				set
				{
					this.m_owner.m_curExpBagItemCtrl = value;
				}
			}

			// Token: 0x17003212 RID: 12818
			// (get) Token: 0x0601043A RID: 66618 RVA: 0x0043F748 File Offset: 0x0043D948
			// (set) Token: 0x0601043B RID: 66619 RVA: 0x0043F758 File Offset: 0x0043D958
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

			// Token: 0x17003213 RID: 12819
			// (get) Token: 0x0601043C RID: 66620 RVA: 0x0043F768 File Offset: 0x0043D968
			// (set) Token: 0x0601043D RID: 66621 RVA: 0x0043F778 File Offset: 0x0043D978
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

			// Token: 0x17003214 RID: 12820
			// (get) Token: 0x0601043E RID: 66622 RVA: 0x0043F788 File Offset: 0x0043D988
			// (set) Token: 0x0601043F RID: 66623 RVA: 0x0043F798 File Offset: 0x0043D998
			public int m_addImageCoroutineCount
			{
				get
				{
					return this.m_owner.m_addImageCoroutineCount;
				}
				set
				{
					this.m_owner.m_addImageCoroutineCount = value;
				}
			}

			// Token: 0x06010440 RID: 66624 RVA: 0x0043F7A8 File Offset: 0x0043D9A8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010441 RID: 66625 RVA: 0x0043F7B8 File Offset: 0x0043D9B8
			public void HeroAddExpLvUpEffect()
			{
				this.m_owner.HeroAddExpLvUpEffect();
			}

			// Token: 0x06010442 RID: 66626 RVA: 0x0043F7C8 File Offset: 0x0043D9C8
			public void OnExpItemClick(HeroExpItemUIController ctrl)
			{
				this.m_owner.OnExpItemClick(ctrl);
			}

			// Token: 0x06010443 RID: 66627 RVA: 0x0043F7D8 File Offset: 0x0043D9D8
			public void LocalAddExpTick()
			{
				this.m_owner.LocalAddExpTick();
			}

			// Token: 0x06010444 RID: 66628 RVA: 0x0043F7E8 File Offset: 0x0043D9E8
			public IEnumerator AddProgressImageWidth(float totalWidth, float DesWidth, float intervalTime)
			{
				return this.m_owner.AddProgressImageWidth(totalWidth, DesWidth, intervalTime);
			}

			// Token: 0x06010445 RID: 66629 RVA: 0x0043F7F8 File Offset: 0x0043D9F8
			public void OnLocalAddExpFinishedSendReq(int usedCount)
			{
				this.m_owner.OnLocalAddExpFinishedSendReq(usedCount);
			}

			// Token: 0x06010446 RID: 66630 RVA: 0x0043F808 File Offset: 0x0043DA08
			public IEnumerator WaitTimeThenDoEvent(int count)
			{
				return this.m_owner.WaitTimeThenDoEvent(count);
			}

			// Token: 0x06010447 RID: 66631 RVA: 0x0043F818 File Offset: 0x0043DA18
			public bool CanExpItemUse(int heroLv, int herpExp)
			{
				return this.m_owner.CanExpItemUse(heroLv, herpExp);
			}

			// Token: 0x06010448 RID: 66632 RVA: 0x0043F828 File Offset: 0x0043DA28
			public void OnAddExpConfirmButtonClick()
			{
				this.m_owner.OnAddExpConfirmButtonClick();
			}

			// Token: 0x06010449 RID: 66633 RVA: 0x0043F838 File Offset: 0x0043DA38
			public void OnAddExpCanelButtonClick()
			{
				this.m_owner.OnAddExpCanelButtonClick();
			}

			// Token: 0x0601044A RID: 66634 RVA: 0x0043F848 File Offset: 0x0043DA48
			public void CloseAddExpPanel()
			{
				this.m_owner.CloseAddExpPanel();
			}

			// Token: 0x04009758 RID: 38744
			private HeroDetailAddExpUIController m_owner;
		}
	}
}
