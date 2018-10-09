using System;
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
	// Token: 0x02000EAB RID: 3755
	[HotFix]
	public class RaffleUIController : UIControllerBase
	{
		// Token: 0x0601256F RID: 75119 RVA: 0x004B5B88 File Offset: 0x004B3D88
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
			this.BgButton.onClick.AddListener(new UnityAction(this.OnBgButtonClick));
			this.ShowHelpButton.onClick.AddListener(new UnityAction(this.OnShowHelpButtonClick));
			this.RewardPanelButton.onClick.AddListener(new UnityAction(this.OnRewardPanelButtonClick));
			this.DoRaffleButton.onClick.AddListener(new UnityAction(this.OnDoRaffleButtonClick));
			this.LevelEffectBgButton.onClick.AddListener(new UnityAction(this.OnLevelEffectBgButtonClick));
		}

		// Token: 0x06012570 RID: 75120 RVA: 0x004B5C7C File Offset: 0x004B3E7C
		public void UpdateRafflePanel(RafflePool rafflePool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRafflePanelRafflePool_hotfix != null)
			{
				this.m_UpdateRafflePanelRafflePool_hotfix.call(new object[]
				{
					this,
					rafflePool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateCostPanelState(rafflePool);
		}

		// Token: 0x06012571 RID: 75121 RVA: 0x004B5CF4 File Offset: 0x004B3EF4
		public RectTransform Get3DViewRectTransfrom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Get3DViewRectTransfrom_hotfix != null)
			{
				return (RectTransform)this.m_Get3DViewRectTransfrom_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.ThreeDViewRect;
		}

		// Token: 0x06012572 RID: 75122 RVA: 0x004B5D68 File Offset: 0x004B3F68
		public void ShowDrawRewardLevelEffect(int rewardLevel, bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDrawRewardLevelEffectInt32Boolean_hotfix != null)
			{
				this.m_ShowDrawRewardLevelEffectInt32Boolean_hotfix.call(new object[]
				{
					this,
					rewardLevel,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isShow)
			{
				CommonUIStateController levelEffectStateCtrlByLevel = this.GetLevelEffectStateCtrlByLevel(rewardLevel);
				UIUtility.SetUIStateOpen(levelEffectStateCtrlByLevel, "Show", null, true, true);
			}
			else
			{
				CommonUIStateController levelEffectStateCtrlByLevel2 = this.GetLevelEffectStateCtrlByLevel(rewardLevel);
				levelEffectStateCtrlByLevel2.SetToUIState("Close", false, true);
			}
		}

		// Token: 0x06012573 RID: 75123 RVA: 0x004B5E20 File Offset: 0x004B4020
		protected string GetLevelEffectNameByLevel(int rewardLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLevelEffectNameByLevelInt32_hotfix != null)
			{
				return (string)this.m_GetLevelEffectNameByLevelInt32_hotfix.call(new object[]
				{
					this,
					rewardLevel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (rewardLevel)
			{
			case 0:
				return "Special";
			case 1:
				return "First";
			case 2:
				return "Second";
			case 3:
				return "Third";
			default:
				return "Third";
			}
		}

		// Token: 0x06012574 RID: 75124 RVA: 0x004B5ED4 File Offset: 0x004B40D4
		protected CommonUIStateController GetLevelEffectStateCtrlByLevel(int rewardLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLevelEffectStateCtrlByLevelInt32_hotfix != null)
			{
				return (CommonUIStateController)this.m_GetLevelEffectStateCtrlByLevelInt32_hotfix.call(new object[]
				{
					this,
					rewardLevel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (rewardLevel)
			{
			case 0:
				return this.SpecialLevelStateCtrl;
			case 1:
				return this.FirstLevelStateCtrl;
			case 2:
				return this.SecondLevelStateCtrl;
			case 3:
				return this.ThirdLevelStateCtrl;
			default:
				return this.ThirdLevelStateCtrl;
			}
		}

		// Token: 0x06012575 RID: 75125 RVA: 0x004B5F90 File Offset: 0x004B4190
		protected void UpdateCostPanelState(RafflePool rafflePool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateCostPanelStateRafflePool_hotfix != null)
			{
				this.m_UpdateCostPanelStateRafflePool_hotfix.call(new object[]
				{
					this,
					rafflePool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = rafflePool.Config.FreeDrawCount - rafflePool.FreeDrawedCount;
			if (num > 0)
			{
				this.CostPanelStateCtrl.SetToUIState("Free", false, true);
				string format = this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Raffle_FreeCountTitle);
				this.FreeCountValueText.text = string.Format(format, num);
			}
			else
			{
				this.CostPanelStateCtrl.SetToUIState("Crystal", false, true);
				this.CostImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(rafflePool.Config.GoodsType, rafflePool.Config.DrawItemID));
				this.CostImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(rafflePool.Config.GoodsType, rafflePool.Config.DrawItemID));
				string format2 = this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Raffle_CostTitle);
				this.CostTileText.text = string.Format(format2, UIUtility.GetGoodsName(rafflePool.Config.GoodsType, rafflePool.Config.DrawItemID));
				int drawItemCost = (GameManager.Instance.PlayerContext as ProjectLPlayerContext).GetDrawItemCost(rafflePool);
				int goodsCount = UIUtility.GetGoodsCount(rafflePool.Config.GoodsType, rafflePool.Config.DrawItemID);
				this.CostValueText.text = drawItemCost.ToString();
				if (drawItemCost > goodsCount)
				{
					this.HaveMoneyValueText.text = UIUtility.AddColorTag(goodsCount.ToString(), Color.red);
				}
				else
				{
					this.HaveMoneyValueText.text = goodsCount.ToString();
				}
			}
		}

		// Token: 0x06012576 RID: 75126 RVA: 0x004B619C File Offset: 0x004B439C
		protected void OnBgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBgButtonClick_hotfix != null)
			{
				this.m_OnBgButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnBgButtonClick != null)
			{
				this.EventOnBgButtonClick();
			}
		}

		// Token: 0x06012577 RID: 75127 RVA: 0x004B6214 File Offset: 0x004B4414
		protected void OnShowHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowHelpButtonClick_hotfix != null)
			{
				this.m_OnShowHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelpButtonClick != null)
			{
				this.EventOnShowHelpButtonClick();
			}
		}

		// Token: 0x06012578 RID: 75128 RVA: 0x004B628C File Offset: 0x004B448C
		protected void OnRewardPanelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRewardPanelButtonClick_hotfix != null)
			{
				this.m_OnRewardPanelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EvetnOnRewardPanelButtonClick != null)
			{
				this.EvetnOnRewardPanelButtonClick();
			}
		}

		// Token: 0x06012579 RID: 75129 RVA: 0x004B6304 File Offset: 0x004B4504
		protected void OnDoRaffleButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDoRaffleButtonClick_hotfix != null)
			{
				this.m_OnDoRaffleButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDoRaffleButtonClick != null)
			{
				this.EventOnDoRaffleButtonClick();
			}
		}

		// Token: 0x0601257A RID: 75130 RVA: 0x004B637C File Offset: 0x004B457C
		protected void OnLevelEffectBgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLevelEffectBgButtonClick_hotfix != null)
			{
				this.m_OnLevelEffectBgButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnLevelEffectBgButtonClick != null)
			{
				this.EventOnLevelEffectBgButtonClick();
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0601257B RID: 75131 RVA: 0x004B63F4 File Offset: 0x004B45F4
		protected IConfigDataLoader ConfigDataLoader
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ConfigDataLoader_hotfix != null)
				{
					return (IConfigDataLoader)this.m_get_ConfigDataLoader_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			}
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0601257C RID: 75132 RVA: 0x004B6470 File Offset: 0x004B4670
		// (set) Token: 0x0601257D RID: 75133 RVA: 0x004B6490 File Offset: 0x004B4690
		[DoNotToLua]
		public new RaffleUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RaffleUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601257E RID: 75134 RVA: 0x004B649C File Offset: 0x004B469C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601257F RID: 75135 RVA: 0x004B64A8 File Offset: 0x004B46A8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012580 RID: 75136 RVA: 0x004B64B0 File Offset: 0x004B46B0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012581 RID: 75137 RVA: 0x004B64B8 File Offset: 0x004B46B8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012582 RID: 75138 RVA: 0x004B64CC File Offset: 0x004B46CC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012583 RID: 75139 RVA: 0x004B64D4 File Offset: 0x004B46D4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012584 RID: 75140 RVA: 0x004B64E0 File Offset: 0x004B46E0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012585 RID: 75141 RVA: 0x004B64EC File Offset: 0x004B46EC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012586 RID: 75142 RVA: 0x004B64F8 File Offset: 0x004B46F8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012587 RID: 75143 RVA: 0x004B6504 File Offset: 0x004B4704
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012588 RID: 75144 RVA: 0x004B6510 File Offset: 0x004B4710
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012589 RID: 75145 RVA: 0x004B651C File Offset: 0x004B471C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601258A RID: 75146 RVA: 0x004B6528 File Offset: 0x004B4728
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601258B RID: 75147 RVA: 0x004B6534 File Offset: 0x004B4734
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601258C RID: 75148 RVA: 0x004B6540 File Offset: 0x004B4740
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601258D RID: 75149 RVA: 0x004B6548 File Offset: 0x004B4748
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
					this.m_UpdateRafflePanelRafflePool_hotfix = (luaObj.RawGet("UpdateRafflePanel") as LuaFunction);
					this.m_Get3DViewRectTransfrom_hotfix = (luaObj.RawGet("Get3DViewRectTransfrom") as LuaFunction);
					this.m_ShowDrawRewardLevelEffectInt32Boolean_hotfix = (luaObj.RawGet("ShowDrawRewardLevelEffect") as LuaFunction);
					this.m_GetLevelEffectNameByLevelInt32_hotfix = (luaObj.RawGet("GetLevelEffectNameByLevel") as LuaFunction);
					this.m_GetLevelEffectStateCtrlByLevelInt32_hotfix = (luaObj.RawGet("GetLevelEffectStateCtrlByLevel") as LuaFunction);
					this.m_UpdateCostPanelStateRafflePool_hotfix = (luaObj.RawGet("UpdateCostPanelState") as LuaFunction);
					this.m_OnBgButtonClick_hotfix = (luaObj.RawGet("OnBgButtonClick") as LuaFunction);
					this.m_OnShowHelpButtonClick_hotfix = (luaObj.RawGet("OnShowHelpButtonClick") as LuaFunction);
					this.m_OnRewardPanelButtonClick_hotfix = (luaObj.RawGet("OnRewardPanelButtonClick") as LuaFunction);
					this.m_OnDoRaffleButtonClick_hotfix = (luaObj.RawGet("OnDoRaffleButtonClick") as LuaFunction);
					this.m_OnLevelEffectBgButtonClick_hotfix = (luaObj.RawGet("OnLevelEffectBgButtonClick") as LuaFunction);
					this.m_get_ConfigDataLoader_hotfix = (luaObj.RawGet("get_ConfigDataLoader") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601258E RID: 75150 RVA: 0x004B6740 File Offset: 0x004B4940
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaffleUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A521 RID: 42273
		public Action EventOnShowHelpButtonClick;

		// Token: 0x0400A522 RID: 42274
		public Action EvetnOnRewardPanelButtonClick;

		// Token: 0x0400A523 RID: 42275
		public Action EventOnDoRaffleButtonClick;

		// Token: 0x0400A524 RID: 42276
		public Action EventOnBgButtonClick;

		// Token: 0x0400A525 RID: 42277
		public Action EventOnLevelEffectBgButtonClick;

		// Token: 0x0400A526 RID: 42278
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController UIStateCtrl;

		// Token: 0x0400A527 RID: 42279
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button BgButton;

		// Token: 0x0400A528 RID: 42280
		[AutoBind("./LayoutRoot/Detail/WatchRewardButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button RewardPanelButton;

		// Token: 0x0400A529 RID: 42281
		[AutoBind("./LayoutRoot/Detail/DescButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button ShowHelpButton;

		// Token: 0x0400A52A RID: 42282
		[AutoBind("./LayoutRoot/Detail/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button DoRaffleButton;

		// Token: 0x0400A52B RID: 42283
		[AutoBind("./LayoutRoot/Detail/Tip", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController CostPanelStateCtrl;

		// Token: 0x0400A52C RID: 42284
		[AutoBind("./LayoutRoot/Detail/Tip/FreeCount/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text FreeCountValueText;

		// Token: 0x0400A52D RID: 42285
		[AutoBind("./LayoutRoot/Detail/Tip/Crystal", AutoBindAttribute.InitState.NotInit, false)]
		public Image CostImage;

		// Token: 0x0400A52E RID: 42286
		[AutoBind("./LayoutRoot/Detail/Tip/CrystalText", AutoBindAttribute.InitState.NotInit, false)]
		public Text CostTileText;

		// Token: 0x0400A52F RID: 42287
		[AutoBind("./LayoutRoot/Detail/Tip/CrystalText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text CostValueText;

		// Token: 0x0400A530 RID: 42288
		[AutoBind("./LayoutRoot/Detail/Tip/HaveTicketText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text HaveMoneyValueText;

		// Token: 0x0400A531 RID: 42289
		[AutoBind("./LayoutRoot/3DViewRect", AutoBindAttribute.InitState.NotInit, false)]
		public RectTransform ThreeDViewRect;

		// Token: 0x0400A532 RID: 42290
		[AutoBind("./EffectGroup", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController LevelEffectStateCtrl;

		// Token: 0x0400A533 RID: 42291
		[AutoBind("./EffectGroup/Special", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SpecialLevelStateCtrl;

		// Token: 0x0400A534 RID: 42292
		[AutoBind("./EffectGroup/First", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController FirstLevelStateCtrl;

		// Token: 0x0400A535 RID: 42293
		[AutoBind("./EffectGroup/Second", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController SecondLevelStateCtrl;

		// Token: 0x0400A536 RID: 42294
		[AutoBind("./EffectGroup/Third", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController ThirdLevelStateCtrl;

		// Token: 0x0400A537 RID: 42295
		[AutoBind("./EffectGroup/ClickScreenContinue/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button LevelEffectBgButton;

		// Token: 0x0400A538 RID: 42296
		[DoNotToLua]
		private RaffleUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A539 RID: 42297
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A53A RID: 42298
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A53B RID: 42299
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A53C RID: 42300
		private LuaFunction m_UpdateRafflePanelRafflePool_hotfix;

		// Token: 0x0400A53D RID: 42301
		private LuaFunction m_Get3DViewRectTransfrom_hotfix;

		// Token: 0x0400A53E RID: 42302
		private LuaFunction m_ShowDrawRewardLevelEffectInt32Boolean_hotfix;

		// Token: 0x0400A53F RID: 42303
		private LuaFunction m_GetLevelEffectNameByLevelInt32_hotfix;

		// Token: 0x0400A540 RID: 42304
		private LuaFunction m_GetLevelEffectStateCtrlByLevelInt32_hotfix;

		// Token: 0x0400A541 RID: 42305
		private LuaFunction m_UpdateCostPanelStateRafflePool_hotfix;

		// Token: 0x0400A542 RID: 42306
		private LuaFunction m_OnBgButtonClick_hotfix;

		// Token: 0x0400A543 RID: 42307
		private LuaFunction m_OnShowHelpButtonClick_hotfix;

		// Token: 0x0400A544 RID: 42308
		private LuaFunction m_OnRewardPanelButtonClick_hotfix;

		// Token: 0x0400A545 RID: 42309
		private LuaFunction m_OnDoRaffleButtonClick_hotfix;

		// Token: 0x0400A546 RID: 42310
		private LuaFunction m_OnLevelEffectBgButtonClick_hotfix;

		// Token: 0x0400A547 RID: 42311
		private LuaFunction m_get_ConfigDataLoader_hotfix;

		// Token: 0x02000EAC RID: 3756
		public new class LuaExportHelper
		{
			// Token: 0x0601258F RID: 75151 RVA: 0x004B67A8 File Offset: 0x004B49A8
			public LuaExportHelper(RaffleUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012590 RID: 75152 RVA: 0x004B67B8 File Offset: 0x004B49B8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012591 RID: 75153 RVA: 0x004B67C8 File Offset: 0x004B49C8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012592 RID: 75154 RVA: 0x004B67D8 File Offset: 0x004B49D8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012593 RID: 75155 RVA: 0x004B67E8 File Offset: 0x004B49E8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012594 RID: 75156 RVA: 0x004B6800 File Offset: 0x004B4A00
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012595 RID: 75157 RVA: 0x004B6810 File Offset: 0x004B4A10
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012596 RID: 75158 RVA: 0x004B6820 File Offset: 0x004B4A20
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012597 RID: 75159 RVA: 0x004B6830 File Offset: 0x004B4A30
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012598 RID: 75160 RVA: 0x004B6840 File Offset: 0x004B4A40
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012599 RID: 75161 RVA: 0x004B6850 File Offset: 0x004B4A50
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601259A RID: 75162 RVA: 0x004B6860 File Offset: 0x004B4A60
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601259B RID: 75163 RVA: 0x004B6870 File Offset: 0x004B4A70
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601259C RID: 75164 RVA: 0x004B6880 File Offset: 0x004B4A80
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601259D RID: 75165 RVA: 0x004B6890 File Offset: 0x004B4A90
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601259E RID: 75166 RVA: 0x004B68A0 File Offset: 0x004B4AA0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170037B6 RID: 14262
			// (get) Token: 0x0601259F RID: 75167 RVA: 0x004B68B0 File Offset: 0x004B4AB0
			public IConfigDataLoader ConfigDataLoader
			{
				get
				{
					return this.m_owner.ConfigDataLoader;
				}
			}

			// Token: 0x060125A0 RID: 75168 RVA: 0x004B68C0 File Offset: 0x004B4AC0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060125A1 RID: 75169 RVA: 0x004B68D0 File Offset: 0x004B4AD0
			public string GetLevelEffectNameByLevel(int rewardLevel)
			{
				return this.m_owner.GetLevelEffectNameByLevel(rewardLevel);
			}

			// Token: 0x060125A2 RID: 75170 RVA: 0x004B68E0 File Offset: 0x004B4AE0
			public CommonUIStateController GetLevelEffectStateCtrlByLevel(int rewardLevel)
			{
				return this.m_owner.GetLevelEffectStateCtrlByLevel(rewardLevel);
			}

			// Token: 0x060125A3 RID: 75171 RVA: 0x004B68F0 File Offset: 0x004B4AF0
			public void UpdateCostPanelState(RafflePool rafflePool)
			{
				this.m_owner.UpdateCostPanelState(rafflePool);
			}

			// Token: 0x060125A4 RID: 75172 RVA: 0x004B6900 File Offset: 0x004B4B00
			public void OnBgButtonClick()
			{
				this.m_owner.OnBgButtonClick();
			}

			// Token: 0x060125A5 RID: 75173 RVA: 0x004B6910 File Offset: 0x004B4B10
			public void OnShowHelpButtonClick()
			{
				this.m_owner.OnShowHelpButtonClick();
			}

			// Token: 0x060125A6 RID: 75174 RVA: 0x004B6920 File Offset: 0x004B4B20
			public void OnRewardPanelButtonClick()
			{
				this.m_owner.OnRewardPanelButtonClick();
			}

			// Token: 0x060125A7 RID: 75175 RVA: 0x004B6930 File Offset: 0x004B4B30
			public void OnDoRaffleButtonClick()
			{
				this.m_owner.OnDoRaffleButtonClick();
			}

			// Token: 0x060125A8 RID: 75176 RVA: 0x004B6940 File Offset: 0x004B4B40
			public void OnLevelEffectBgButtonClick()
			{
				this.m_owner.OnLevelEffectBgButtonClick();
			}

			// Token: 0x0400A548 RID: 42312
			private RaffleUIController m_owner;
		}
	}
}
