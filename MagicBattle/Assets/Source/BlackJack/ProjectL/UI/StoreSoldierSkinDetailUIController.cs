using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F3B RID: 3899
	[HotFix]
	public class StoreSoldierSkinDetailUIController : UIControllerBase
	{
		// Token: 0x0601369B RID: 79515 RVA: 0x004F27BC File Offset: 0x004F09BC
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
			this.m_soldierDefaultSkinItemCtrlList.Clear();
			SoldierShowItemController item = new SoldierShowItemController(this.m_soldierDefaultSkinItem1);
			this.m_soldierDefaultSkinItemCtrlList.Add(item);
			item = new SoldierShowItemController(this.m_soldierDefaultSkinItem2);
			this.m_soldierDefaultSkinItemCtrlList.Add(item);
			this.m_soldierBuySkinItemCtrlList.Clear();
			SoldierShowItemController item2 = new SoldierShowItemController(this.m_soldierBuySkinItem1);
			this.m_soldierBuySkinItemCtrlList.Add(item2);
			item2 = new SoldierShowItemController(this.m_soldierBuySkinItem2);
			this.m_soldierBuySkinItemCtrlList.Add(item2);
		}

		// Token: 0x0601369C RID: 79516 RVA: 0x004F289C File Offset: 0x004F0A9C
		public void UpdateSoldierSkinDetailPanelByFixedStoreItemConfigInfo(ConfigDataFixedStoreItemInfo fixedStoreItemConfig, bool isNeedBuy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSoldierSkinDetailPanelByFixedStoreItemConfigInfoConfigDataFixedStoreItemInfoBoolean_hotfix != null)
			{
				this.m_UpdateSoldierSkinDetailPanelByFixedStoreItemConfigInfoConfigDataFixedStoreItemInfoBoolean_hotfix.call(new object[]
				{
					this,
					fixedStoreItemConfig,
					isNeedBuy
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (fixedStoreItemConfig != null)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = configDataLoader.GetConfigDataSoldierSkinInfo(fixedStoreItemConfig.ItemId);
				this.m_nameText.text = fixedStoreItemConfig.Name;
				this.m_priceText.text = fixedStoreItemConfig.NormalPrice.ToString();
				this.SetSoldierDefaultAndSkinItemInfo(fixedStoreItemConfig.Name, configDataSoldierSkinInfo.SpecifiedSoldier);
				this.SetPanelBuyButtonState(isNeedBuy);
			}
		}

		// Token: 0x0601369D RID: 79517 RVA: 0x004F2988 File Offset: 0x004F0B88
		public void UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfo(ConfigDataSoldierSkinInfo skinConfigInfo, bool isNeedBuy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfoConfigDataSoldierSkinInfoBoolean_hotfix != null)
			{
				this.m_UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfoConfigDataSoldierSkinInfoBoolean_hotfix.call(new object[]
				{
					this,
					skinConfigInfo,
					isNeedBuy
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skinConfigInfo != null)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				this.m_nameText.text = skinConfigInfo.Name;
				if (isNeedBuy)
				{
					ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = configDataLoader.GetConfigDataFixedStoreItemInfo(skinConfigInfo.FixedStoreItemId);
					if (configDataFixedStoreItemInfo != null)
					{
						this.m_priceText.text = configDataFixedStoreItemInfo.NormalPrice.ToString();
					}
				}
				this.SetSoldierDefaultAndSkinItemInfo(skinConfigInfo.Name, skinConfigInfo.SpecifiedSoldier);
				this.SetPanelBuyButtonState(isNeedBuy);
			}
		}

		// Token: 0x0601369E RID: 79518 RVA: 0x004F2A80 File Offset: 0x004F0C80
		public void PlayPanelOpenAnim()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayPanelOpenAnim_hotfix != null)
			{
				this.m_PlayPanelOpenAnim_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_panelStateUICtrl, "Show", null, true, true);
		}

		// Token: 0x0601369F RID: 79519 RVA: 0x004F2AF4 File Offset: 0x004F0CF4
		public void PlayPanelCloseAnim(Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayPanelCloseAnimAction_hotfix != null)
			{
				this.m_PlayPanelCloseAnimAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_panelStateUICtrl, "Close", onEnd, true, true);
		}

		// Token: 0x060136A0 RID: 79520 RVA: 0x004F2B78 File Offset: 0x004F0D78
		public void SetBuyButtonToHasBuyMode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBuyButtonToHasBuyMode_hotfix != null)
			{
				this.m_SetBuyButtonToHasBuyMode_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_buyStateCtrl.SetToUIState("Got", false, true);
		}

		// Token: 0x060136A1 RID: 79521 RVA: 0x004F2BEC File Offset: 0x004F0DEC
		protected void SetPanelBuyButtonState(bool isNeedBuy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPanelBuyButtonStateBoolean_hotfix != null)
			{
				this.m_SetPanelBuyButtonStateBoolean_hotfix.call(new object[]
				{
					this,
					isNeedBuy
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_buyStateCtrl.gameObject.SetActive(isNeedBuy);
			if (isNeedBuy)
			{
				this.m_buyStateCtrl.SetToUIState("Buy", false, true);
			}
		}

		// Token: 0x060136A2 RID: 79522 RVA: 0x004F2C88 File Offset: 0x004F0E88
		protected void SetSoldierDefaultAndSkinItemInfo(string skinName, List<Soldier2SkinResource> soldier2SkinResList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierDefaultAndSkinItemInfoStringList`1_hotfix != null)
			{
				this.m_SetSoldierDefaultAndSkinItemInfoStringList`1_hotfix.call(new object[]
				{
					this,
					skinName,
					soldier2SkinResList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (soldier2SkinResList.Count > 2)
			{
				global::Debug.LogError("StoreSoldierDetailUIController::SetSoldierSkinSpineAnim::Too Many Spine Need !");
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			for (int i = 0; i < this.m_soldierDefaultSkinItemCtrlList.Count; i++)
			{
				if (i < soldier2SkinResList.Count)
				{
					Soldier2SkinResource soldier2SkinResource = soldier2SkinResList[i];
					ConfigDataSoldierInfo configDataSoldierInfo = configDataLoader.GetConfigDataSoldierInfo(soldier2SkinResource.SoldierId);
					this.m_soldierDefaultSkinItemCtrlList[i].m_nameText.text = configDataSoldierInfo.Name;
					this.SetSpineAnim(configDataSoldierInfo.Model, ref this.m_soldierDefaultSkinItemCtrlList[i].m_soldierSkinGraphic, this.m_soldierDefaultSkinItemCtrlList[i].m_spineObj, configDataSoldierInfo);
					this.m_soldierDefaultSkinItemCtrlList[i].m_itemStateCtrl.SetToUIState((!projectLPlayerContext.IsExistSoliderId(soldier2SkinResource.SoldierId)) ? "Lock" : "Normal", false, true);
					ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = configDataLoader.GetConfigDataModelSkinResourceInfo(soldier2SkinResource.SkinResourceId);
					this.m_soldierBuySkinItemCtrlList[i].m_nameText.text = configDataModelSkinResourceInfo.Name;
					this.SetSpineAnim(configDataModelSkinResourceInfo.Model, ref this.m_soldierBuySkinItemCtrlList[i].m_soldierSkinGraphic, this.m_soldierBuySkinItemCtrlList[i].m_spineObj, configDataSoldierInfo);
					this.m_soldierBuySkinItemCtrlList[i].m_itemStateCtrl.SetToUIState("Normal", false, true);
					this.m_soldierDefaultSkinItemCtrlList[i].SetActive(true);
					this.m_soldierBuySkinItemCtrlList[i].SetActive(true);
				}
				else
				{
					this.m_soldierDefaultSkinItemCtrlList[i].SetActive(false);
					this.m_soldierBuySkinItemCtrlList[i].SetActive(false);
				}
			}
		}

		// Token: 0x060136A3 RID: 79523 RVA: 0x004F2ECC File Offset: 0x004F10CC
		protected void SetSpineAnim(string modelPath, ref UISpineGraphic graphic, GameObject go, ConfigDataSoldierInfo soldierInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSpineAnimStringUISpineGraphic_GameObjectConfigDataSoldierInfo_hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController_SetSpineAnim_String_UISpineGraphic_GameObject_ConfigDataSoldierInfo(this, this.m_SetSpineAnimStringUISpineGraphic_GameObjectConfigDataSoldierInfo_hotfix, modelPath, ref graphic, go, soldierInfo);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float scale = (float)soldierInfo.UI_ModelScale * 0.011f;
			Vector2 offset = new Vector2((float)soldierInfo.UI_ModelOffsetX + (float)Math.Abs(soldierInfo.UI_ModelOffsetX) * 0.2f, (float)soldierInfo.UI_ModelOffsetY + (float)Math.Abs(soldierInfo.UI_ModelOffsetY) * 1.1f);
			HeroDetailUIController.CreateSpineGraphic(ref graphic, modelPath, go, 1, offset, scale, soldierInfo.ReplaceAnims);
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x060136A4 RID: 79524 RVA: 0x004F2F84 File Offset: 0x004F1184
		// (set) Token: 0x060136A5 RID: 79525 RVA: 0x004F2FA4 File Offset: 0x004F11A4
		[DoNotToLua]
		public new StoreSoldierSkinDetailUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new StoreSoldierSkinDetailUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060136A6 RID: 79526 RVA: 0x004F2FB0 File Offset: 0x004F11B0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060136A7 RID: 79527 RVA: 0x004F2FBC File Offset: 0x004F11BC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060136A8 RID: 79528 RVA: 0x004F2FC4 File Offset: 0x004F11C4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060136A9 RID: 79529 RVA: 0x004F2FCC File Offset: 0x004F11CC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060136AA RID: 79530 RVA: 0x004F2FE0 File Offset: 0x004F11E0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060136AB RID: 79531 RVA: 0x004F2FE8 File Offset: 0x004F11E8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060136AC RID: 79532 RVA: 0x004F2FF4 File Offset: 0x004F11F4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060136AD RID: 79533 RVA: 0x004F3000 File Offset: 0x004F1200
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060136AE RID: 79534 RVA: 0x004F300C File Offset: 0x004F120C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060136AF RID: 79535 RVA: 0x004F3018 File Offset: 0x004F1218
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060136B0 RID: 79536 RVA: 0x004F3024 File Offset: 0x004F1224
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060136B1 RID: 79537 RVA: 0x004F3030 File Offset: 0x004F1230
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060136B2 RID: 79538 RVA: 0x004F303C File Offset: 0x004F123C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060136B3 RID: 79539 RVA: 0x004F3048 File Offset: 0x004F1248
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060136B4 RID: 79540 RVA: 0x004F3054 File Offset: 0x004F1254
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060136B5 RID: 79541 RVA: 0x004F305C File Offset: 0x004F125C
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
					this.m_UpdateSoldierSkinDetailPanelByFixedStoreItemConfigInfoConfigDataFixedStoreItemInfoBoolean_hotfix = (luaObj.RawGet("UpdateSoldierSkinDetailPanelByFixedStoreItemConfigInfo") as LuaFunction);
					this.m_UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfoConfigDataSoldierSkinInfoBoolean_hotfix = (luaObj.RawGet("UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfo") as LuaFunction);
					this.m_PlayPanelOpenAnim_hotfix = (luaObj.RawGet("PlayPanelOpenAnim") as LuaFunction);
					this.m_PlayPanelCloseAnimAction_hotfix = (luaObj.RawGet("PlayPanelCloseAnim") as LuaFunction);
					this.m_SetBuyButtonToHasBuyMode_hotfix = (luaObj.RawGet("SetBuyButtonToHasBuyMode") as LuaFunction);
					this.m_SetPanelBuyButtonStateBoolean_hotfix = (luaObj.RawGet("SetPanelBuyButtonState") as LuaFunction);
					this.m_SetSoldierDefaultAndSkinItemInfoStringList`1_hotfix = (luaObj.RawGet("SetSoldierDefaultAndSkinItemInfo") as LuaFunction);
					this.m_SetSpineAnimStringUISpineGraphic_GameObjectConfigDataSoldierInfo_hotfix = (luaObj.RawGet("SetSpineAnim") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060136B6 RID: 79542 RVA: 0x004F31F0 File Offset: 0x004F13F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(StoreSoldierSkinDetailUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AC76 RID: 44150
		public List<SoldierShowItemController> m_soldierDefaultSkinItemCtrlList = new List<SoldierShowItemController>();

		// Token: 0x0400AC77 RID: 44151
		public List<SoldierShowItemController> m_soldierBuySkinItemCtrlList = new List<SoldierShowItemController>();

		// Token: 0x0400AC78 RID: 44152
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button m_panelBgButton;

		// Token: 0x0400AC79 RID: 44153
		[AutoBind("./LayoutRoot/BuyAndGot/SureBtn", AutoBindAttribute.InitState.NotInit, false)]
		public Button m_buyButton;

		// Token: 0x0400AC7A RID: 44154
		[AutoBind("./LayoutRoot/BuyAndGot/SureBtn/SureText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_priceText;

		// Token: 0x0400AC7B RID: 44155
		[AutoBind("./LayoutRoot/NameText", AutoBindAttribute.InitState.NotInit, false)]
		public Text m_nameText;

		// Token: 0x0400AC7C RID: 44156
		[AutoBind("./LayoutRoot/BuyAndGot", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController m_buyStateCtrl;

		// Token: 0x0400AC7D RID: 44157
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController m_panelStateUICtrl;

		// Token: 0x0400AC7E RID: 44158
		[AutoBind("./LayoutRoot/SoldierRight/SoldierGroup/Soldier1", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_soldierDefaultSkinItem1;

		// Token: 0x0400AC7F RID: 44159
		[AutoBind("./LayoutRoot/SoldierRight/SoldierGroup/Soldier2", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_soldierDefaultSkinItem2;

		// Token: 0x0400AC80 RID: 44160
		[AutoBind("./LayoutRoot/SoldierLeft/SoldierGroup/Soldier1", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_soldierBuySkinItem1;

		// Token: 0x0400AC81 RID: 44161
		[AutoBind("./LayoutRoot/SoldierLeft/SoldierGroup/Soldier2", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject m_soldierBuySkinItem2;

		// Token: 0x0400AC82 RID: 44162
		[DoNotToLua]
		private StoreSoldierSkinDetailUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AC83 RID: 44163
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AC84 RID: 44164
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AC85 RID: 44165
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AC86 RID: 44166
		private LuaFunction m_UpdateSoldierSkinDetailPanelByFixedStoreItemConfigInfoConfigDataFixedStoreItemInfoBoolean_hotfix;

		// Token: 0x0400AC87 RID: 44167
		private LuaFunction m_UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfoConfigDataSoldierSkinInfoBoolean_hotfix;

		// Token: 0x0400AC88 RID: 44168
		private LuaFunction m_PlayPanelOpenAnim_hotfix;

		// Token: 0x0400AC89 RID: 44169
		private LuaFunction m_PlayPanelCloseAnimAction_hotfix;

		// Token: 0x0400AC8A RID: 44170
		private LuaFunction m_SetBuyButtonToHasBuyMode_hotfix;

		// Token: 0x0400AC8B RID: 44171
		private LuaFunction m_SetPanelBuyButtonStateBoolean_hotfix;

		// Token: 0x0400AC8C RID: 44172
		private LuaFunction m_SetSoldierDefaultAndSkinItemInfoStringList;

		// Token: 0x0400AC8D RID: 44173
		private LuaFunction m_SetSpineAnimStringUISpineGraphic_GameObjectConfigDataSoldierInfo_hotfix;

		// Token: 0x02000F3C RID: 3900
		public new class LuaExportHelper
		{
			// Token: 0x060136B7 RID: 79543 RVA: 0x004F3258 File Offset: 0x004F1458
			public LuaExportHelper(StoreSoldierSkinDetailUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060136B8 RID: 79544 RVA: 0x004F3268 File Offset: 0x004F1468
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060136B9 RID: 79545 RVA: 0x004F3278 File Offset: 0x004F1478
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060136BA RID: 79546 RVA: 0x004F3288 File Offset: 0x004F1488
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060136BB RID: 79547 RVA: 0x004F3298 File Offset: 0x004F1498
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060136BC RID: 79548 RVA: 0x004F32B0 File Offset: 0x004F14B0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060136BD RID: 79549 RVA: 0x004F32C0 File Offset: 0x004F14C0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060136BE RID: 79550 RVA: 0x004F32D0 File Offset: 0x004F14D0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060136BF RID: 79551 RVA: 0x004F32E0 File Offset: 0x004F14E0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060136C0 RID: 79552 RVA: 0x004F32F0 File Offset: 0x004F14F0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060136C1 RID: 79553 RVA: 0x004F3300 File Offset: 0x004F1500
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060136C2 RID: 79554 RVA: 0x004F3310 File Offset: 0x004F1510
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060136C3 RID: 79555 RVA: 0x004F3320 File Offset: 0x004F1520
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060136C4 RID: 79556 RVA: 0x004F3330 File Offset: 0x004F1530
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060136C5 RID: 79557 RVA: 0x004F3340 File Offset: 0x004F1540
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060136C6 RID: 79558 RVA: 0x004F3350 File Offset: 0x004F1550
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060136C7 RID: 79559 RVA: 0x004F3360 File Offset: 0x004F1560
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060136C8 RID: 79560 RVA: 0x004F3370 File Offset: 0x004F1570
			public void SetPanelBuyButtonState(bool isNeedBuy)
			{
				this.m_owner.SetPanelBuyButtonState(isNeedBuy);
			}

			// Token: 0x060136C9 RID: 79561 RVA: 0x004F3380 File Offset: 0x004F1580
			public void SetSoldierDefaultAndSkinItemInfo(string skinName, List<Soldier2SkinResource> soldier2SkinResList)
			{
				this.m_owner.SetSoldierDefaultAndSkinItemInfo(skinName, soldier2SkinResList);
			}

			// Token: 0x060136CA RID: 79562 RVA: 0x004F3390 File Offset: 0x004F1590
			public void SetSpineAnim(string modelPath, ref UISpineGraphic graphic, GameObject go, ConfigDataSoldierInfo soldierInfo)
			{
				this.m_owner.SetSpineAnim(modelPath, ref graphic, go, soldierInfo);
			}

			// Token: 0x0400AC8E RID: 44174
			private StoreSoldierSkinDetailUIController m_owner;
		}
	}
}
