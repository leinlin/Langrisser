using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DB2 RID: 3506
	[HotFix]
	public class SoldierItemUIController : UIControllerBase
	{
		// Token: 0x06010A08 RID: 68104 RVA: 0x00451C5C File Offset: 0x0044FE5C
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
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnSoldierItemClick));
			this.m_attackButton.onClick.AddListener(new UnityAction(this.OnAttackButtonClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x06010A09 RID: 68105 RVA: 0x00451D0C File Offset: 0x0044FF0C
		public void InitSoldierItem(ConfigDataSoldierInfo si, ConfigDataJobConnectionInfo jci, bool isSoliderGet, int soldierSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSoldierItemConfigDataSoldierInfoConfigDataJobConnectionInfoBooleanInt32_hotfix != null)
			{
				this.m_InitSoldierItemConfigDataSoldierInfoConfigDataJobConnectionInfoBooleanInt32_hotfix.call(new object[]
				{
					this,
					si,
					jci,
					isSoliderGet,
					soldierSkinId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.SoldierInfo == si && this.JobConnectionInfo == jci && this.m_isSoldierGet == isSoliderGet && this.m_soldierSkinId == soldierSkinId)
			{
				return;
			}
			this.SoldierInfo = si;
			this.JobConnectionInfo = jci;
			this.m_isSoldierGet = isSoliderGet;
			this.m_soldierSkinId = soldierSkinId;
			this.m_soldierNameText.text = si.Name;
			this.m_dontGetObj.SetActive(!isSoliderGet);
			this.CreateSpineGraphic(si, isSoliderGet, soldierSkinId);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int num = 0;
			foreach (int num2 in si.SoldierSkins_ID)
			{
				ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = configDataLoader.GetConfigDataSoldierSkinInfo(num2);
				if (projectLPlayerContext.HasOwn(GoodsType.GoodsType_SoldierSkin, num2) || configDataSoldierSkinInfo.IsShowBeforeGet)
				{
					if (projectLPlayerContext.IsShowSkinBeforeOnSale(configDataSoldierSkinInfo.FixedStoreItemId, false))
					{
						num++;
					}
				}
			}
			this.m_skinIconImage.SetActive(num > 0);
		}

		// Token: 0x06010A0A RID: 68106 RVA: 0x00451EE4 File Offset: 0x004500E4
		private void OnSoldierItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierItemClick_hotfix != null)
			{
				this.m_OnSoldierItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSoldierItemClick != null)
			{
				this.EventOnSoldierItemClick(this);
			}
		}

		// Token: 0x06010A0B RID: 68107 RVA: 0x00451F5C File Offset: 0x0045015C
		private void OnAttackButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAttackButtonClick_hotfix != null)
			{
				this.m_OnAttackButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAttackButtonClick != null)
			{
				this.EventOnAttackButtonClick(this.SoldierInfo);
			}
		}

		// Token: 0x06010A0C RID: 68108 RVA: 0x00451FD8 File Offset: 0x004501D8
		public void SetAttackingPanelActive(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAttackingPanelActiveBoolean_hotfix != null)
			{
				this.m_SetAttackingPanelActiveBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_attackingObj.SetActive(isShow);
		}

		// Token: 0x06010A0D RID: 68109 RVA: 0x00452054 File Offset: 0x00450254
		public void SetAttackButtonActive(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAttackButtonActiveBoolean_hotfix != null)
			{
				this.m_SetAttackButtonActiveBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_attackButton.gameObject.SetActive(isShow);
		}

		// Token: 0x06010A0E RID: 68110 RVA: 0x004520D8 File Offset: 0x004502D8
		public void SetFrameImgActive(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFrameImgActiveBoolean_hotfix != null)
			{
				this.m_SetFrameImgActiveBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_frameImage.SetActive(isShow);
		}

		// Token: 0x06010A0F RID: 68111 RVA: 0x00452154 File Offset: 0x00450354
		private void CreateSpineGraphic(ConfigDataSoldierInfo soldierInfo, bool isGet, int soldierSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicConfigDataSoldierInfoBooleanInt32_hotfix != null)
			{
				this.m_CreateSpineGraphicConfigDataSoldierInfoBooleanInt32_hotfix.call(new object[]
				{
					this,
					soldierInfo2,
					isGet,
					soldierSkinId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSoldierInfo soldierInfo = soldierInfo2;
			this.DestroySpineGraphic();
			if (soldierInfo == null)
			{
				return;
			}
			float num = (float)soldierInfo.UI_ModelScale * 0.01f;
			Vector2 position = new Vector2((float)soldierInfo.UI_ModelOffsetX, (float)soldierInfo.UI_ModelOffsetY);
			this.m_graphic = new UISpineGraphic();
			if (soldierSkinId != 0)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = configDataLoader.GetConfigDataSoldierSkinInfo(soldierSkinId);
				int skinResourceId = configDataSoldierSkinInfo.SpecifiedSoldier.Find((Soldier2SkinResource item) => item.SoldierId == soldierInfo.ID).SkinResourceId;
				ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = configDataLoader.GetConfigDataModelSkinResourceInfo(skinResourceId);
				this.m_graphic.Create(configDataModelSkinResourceInfo.Model);
			}
			else
			{
				this.m_graphic.Create(soldierInfo.Model);
			}
			this.m_graphic.SetParent(this.m_soldierGrapgic);
			this.m_graphic.SetDirection(1);
			this.m_graphic.SetPosition(position);
			this.m_graphic.SetScale(num);
			this.m_graphic.SetRectTransformSize(new Vector2(500f / num, 500f / num));
			this.m_graphic.SetReplaceAnimations(soldierInfo.ReplaceAnims);
			this.m_graphic.PlayAnimation("idle", true, 0);
			if (!isGet)
			{
				this.m_graphic.SetColor(UIUtility.MyGrayColor);
			}
			this.m_graphic.ForceUpdate();
		}

		// Token: 0x06010A10 RID: 68112 RVA: 0x00452354 File Offset: 0x00450554
		private void DestroySpineGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroySpineGraphic_hotfix != null)
			{
				this.m_DestroySpineGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.Destroy();
				this.m_graphic = null;
			}
		}

		// Token: 0x06010A11 RID: 68113 RVA: 0x004523D4 File Offset: 0x004505D4
		private void OnDestroy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDestroy_hotfix != null)
			{
				this.m_OnDestroy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EventOnAttackButtonClick = null;
			this.EventOnSoldierItemClick = null;
			this.DestroySpineGraphic();
		}

		// Token: 0x14000386 RID: 902
		// (add) Token: 0x06010A12 RID: 68114 RVA: 0x00452448 File Offset: 0x00450648
		// (remove) Token: 0x06010A13 RID: 68115 RVA: 0x004524E4 File Offset: 0x004506E4
		public event Action<SoldierItemUIController> EventOnSoldierItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSoldierItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnSoldierItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SoldierItemUIController> action = this.EventOnSoldierItemClick;
				Action<SoldierItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SoldierItemUIController>>(ref this.EventOnSoldierItemClick, (Action<SoldierItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSoldierItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnSoldierItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SoldierItemUIController> action = this.EventOnSoldierItemClick;
				Action<SoldierItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SoldierItemUIController>>(ref this.EventOnSoldierItemClick, (Action<SoldierItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000387 RID: 903
		// (add) Token: 0x06010A14 RID: 68116 RVA: 0x00452580 File Offset: 0x00450780
		// (remove) Token: 0x06010A15 RID: 68117 RVA: 0x0045261C File Offset: 0x0045081C
		public event Action<ConfigDataSoldierInfo> EventOnAttackButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAttackButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnAttackButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataSoldierInfo> action = this.EventOnAttackButtonClick;
				Action<ConfigDataSoldierInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataSoldierInfo>>(ref this.EventOnAttackButtonClick, (Action<ConfigDataSoldierInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAttackButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnAttackButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataSoldierInfo> action = this.EventOnAttackButtonClick;
				Action<ConfigDataSoldierInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataSoldierInfo>>(ref this.EventOnAttackButtonClick, (Action<ConfigDataSoldierInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x06010A16 RID: 68118 RVA: 0x004526B8 File Offset: 0x004508B8
		// (set) Token: 0x06010A17 RID: 68119 RVA: 0x004526D8 File Offset: 0x004508D8
		[DoNotToLua]
		public new SoldierItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SoldierItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010A18 RID: 68120 RVA: 0x004526E4 File Offset: 0x004508E4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010A19 RID: 68121 RVA: 0x004526F0 File Offset: 0x004508F0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010A1A RID: 68122 RVA: 0x004526F8 File Offset: 0x004508F8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010A1B RID: 68123 RVA: 0x00452700 File Offset: 0x00450900
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010A1C RID: 68124 RVA: 0x00452714 File Offset: 0x00450914
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010A1D RID: 68125 RVA: 0x0045271C File Offset: 0x0045091C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010A1E RID: 68126 RVA: 0x00452728 File Offset: 0x00450928
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010A1F RID: 68127 RVA: 0x00452734 File Offset: 0x00450934
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010A20 RID: 68128 RVA: 0x00452740 File Offset: 0x00450940
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010A21 RID: 68129 RVA: 0x0045274C File Offset: 0x0045094C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010A22 RID: 68130 RVA: 0x00452758 File Offset: 0x00450958
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010A23 RID: 68131 RVA: 0x00452764 File Offset: 0x00450964
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010A24 RID: 68132 RVA: 0x00452770 File Offset: 0x00450970
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010A25 RID: 68133 RVA: 0x0045277C File Offset: 0x0045097C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010A26 RID: 68134 RVA: 0x00452788 File Offset: 0x00450988
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010A27 RID: 68135 RVA: 0x00452790 File Offset: 0x00450990
		private void __callDele_EventOnSoldierItemClick(SoldierItemUIController obj)
		{
			Action<SoldierItemUIController> eventOnSoldierItemClick = this.EventOnSoldierItemClick;
			if (eventOnSoldierItemClick != null)
			{
				eventOnSoldierItemClick(obj);
			}
		}

		// Token: 0x06010A28 RID: 68136 RVA: 0x004527B4 File Offset: 0x004509B4
		private void __clearDele_EventOnSoldierItemClick(SoldierItemUIController obj)
		{
			this.EventOnSoldierItemClick = null;
		}

		// Token: 0x06010A29 RID: 68137 RVA: 0x004527C0 File Offset: 0x004509C0
		private void __callDele_EventOnAttackButtonClick(ConfigDataSoldierInfo obj)
		{
			Action<ConfigDataSoldierInfo> eventOnAttackButtonClick = this.EventOnAttackButtonClick;
			if (eventOnAttackButtonClick != null)
			{
				eventOnAttackButtonClick(obj);
			}
		}

		// Token: 0x06010A2A RID: 68138 RVA: 0x004527E4 File Offset: 0x004509E4
		private void __clearDele_EventOnAttackButtonClick(ConfigDataSoldierInfo obj)
		{
			this.EventOnAttackButtonClick = null;
		}

		// Token: 0x06010A2B RID: 68139 RVA: 0x004527F0 File Offset: 0x004509F0
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
					this.m_InitSoldierItemConfigDataSoldierInfoConfigDataJobConnectionInfoBooleanInt32_hotfix = (luaObj.RawGet("InitSoldierItem") as LuaFunction);
					this.m_OnSoldierItemClick_hotfix = (luaObj.RawGet("OnSoldierItemClick") as LuaFunction);
					this.m_OnAttackButtonClick_hotfix = (luaObj.RawGet("OnAttackButtonClick") as LuaFunction);
					this.m_SetAttackingPanelActiveBoolean_hotfix = (luaObj.RawGet("SetAttackingPanelActive") as LuaFunction);
					this.m_SetAttackButtonActiveBoolean_hotfix = (luaObj.RawGet("SetAttackButtonActive") as LuaFunction);
					this.m_SetFrameImgActiveBoolean_hotfix = (luaObj.RawGet("SetFrameImgActive") as LuaFunction);
					this.m_CreateSpineGraphicConfigDataSoldierInfoBooleanInt32_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_OnDestroy_hotfix = (luaObj.RawGet("OnDestroy") as LuaFunction);
					this.m_add_EventOnSoldierItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnSoldierItemClick") as LuaFunction);
					this.m_remove_EventOnSoldierItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnSoldierItemClick") as LuaFunction);
					this.m_add_EventOnAttackButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnAttackButtonClick") as LuaFunction);
					this.m_remove_EventOnAttackButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnAttackButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010A2C RID: 68140 RVA: 0x00452A00 File Offset: 0x00450C00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SoldierItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040099CE RID: 39374
		[AutoBind("./TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierNameText;

		// Token: 0x040099CF RID: 39375
		[AutoBind("./AttackButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_attackButton;

		// Token: 0x040099D0 RID: 39376
		[AutoBind("./Attacking", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_attackingObj;

		// Token: 0x040099D1 RID: 39377
		[AutoBind("./NotGet", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dontGetObj;

		// Token: 0x040099D2 RID: 39378
		[AutoBind("./Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGrapgic;

		// Token: 0x040099D3 RID: 39379
		[AutoBind("./FrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_frameImage;

		// Token: 0x040099D4 RID: 39380
		[AutoBind("./SkinIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skinIconImage;

		// Token: 0x040099D5 RID: 39381
		private bool m_isSoldierGet;

		// Token: 0x040099D6 RID: 39382
		private int m_soldierSkinId;

		// Token: 0x040099D7 RID: 39383
		private UISpineGraphic m_graphic;

		// Token: 0x040099D8 RID: 39384
		public ConfigDataJobConnectionInfo JobConnectionInfo;

		// Token: 0x040099D9 RID: 39385
		public ConfigDataSoldierInfo SoldierInfo;

		// Token: 0x040099DA RID: 39386
		[DoNotToLua]
		private SoldierItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040099DB RID: 39387
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040099DC RID: 39388
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040099DD RID: 39389
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040099DE RID: 39390
		private LuaFunction m_InitSoldierItemConfigDataSoldierInfoConfigDataJobConnectionInfoBooleanInt32_hotfix;

		// Token: 0x040099DF RID: 39391
		private LuaFunction m_OnSoldierItemClick_hotfix;

		// Token: 0x040099E0 RID: 39392
		private LuaFunction m_OnAttackButtonClick_hotfix;

		// Token: 0x040099E1 RID: 39393
		private LuaFunction m_SetAttackingPanelActiveBoolean_hotfix;

		// Token: 0x040099E2 RID: 39394
		private LuaFunction m_SetAttackButtonActiveBoolean_hotfix;

		// Token: 0x040099E3 RID: 39395
		private LuaFunction m_SetFrameImgActiveBoolean_hotfix;

		// Token: 0x040099E4 RID: 39396
		private LuaFunction m_CreateSpineGraphicConfigDataSoldierInfoBooleanInt32_hotfix;

		// Token: 0x040099E5 RID: 39397
		private LuaFunction m_DestroySpineGraphic_hotfix;

		// Token: 0x040099E6 RID: 39398
		private LuaFunction m_OnDestroy_hotfix;

		// Token: 0x040099E7 RID: 39399
		private LuaFunction m_add_EventOnSoldierItemClickAction;

		// Token: 0x040099E8 RID: 39400
		private LuaFunction m_remove_EventOnSoldierItemClickAction;

		// Token: 0x040099E9 RID: 39401
		private LuaFunction m_add_EventOnAttackButtonClickAction;

		// Token: 0x040099EA RID: 39402
		private LuaFunction m_remove_EventOnAttackButtonClickAction;

		// Token: 0x02000DB3 RID: 3507
		public new class LuaExportHelper
		{
			// Token: 0x06010A2D RID: 68141 RVA: 0x00452A68 File Offset: 0x00450C68
			public LuaExportHelper(SoldierItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010A2E RID: 68142 RVA: 0x00452A78 File Offset: 0x00450C78
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010A2F RID: 68143 RVA: 0x00452A88 File Offset: 0x00450C88
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010A30 RID: 68144 RVA: 0x00452A98 File Offset: 0x00450C98
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010A31 RID: 68145 RVA: 0x00452AA8 File Offset: 0x00450CA8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010A32 RID: 68146 RVA: 0x00452AC0 File Offset: 0x00450CC0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010A33 RID: 68147 RVA: 0x00452AD0 File Offset: 0x00450CD0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010A34 RID: 68148 RVA: 0x00452AE0 File Offset: 0x00450CE0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010A35 RID: 68149 RVA: 0x00452AF0 File Offset: 0x00450CF0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010A36 RID: 68150 RVA: 0x00452B00 File Offset: 0x00450D00
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010A37 RID: 68151 RVA: 0x00452B10 File Offset: 0x00450D10
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010A38 RID: 68152 RVA: 0x00452B20 File Offset: 0x00450D20
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010A39 RID: 68153 RVA: 0x00452B30 File Offset: 0x00450D30
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010A3A RID: 68154 RVA: 0x00452B40 File Offset: 0x00450D40
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010A3B RID: 68155 RVA: 0x00452B50 File Offset: 0x00450D50
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010A3C RID: 68156 RVA: 0x00452B60 File Offset: 0x00450D60
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010A3D RID: 68157 RVA: 0x00452B70 File Offset: 0x00450D70
			public void __callDele_EventOnSoldierItemClick(SoldierItemUIController obj)
			{
				this.m_owner.__callDele_EventOnSoldierItemClick(obj);
			}

			// Token: 0x06010A3E RID: 68158 RVA: 0x00452B80 File Offset: 0x00450D80
			public void __clearDele_EventOnSoldierItemClick(SoldierItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnSoldierItemClick(obj);
			}

			// Token: 0x06010A3F RID: 68159 RVA: 0x00452B90 File Offset: 0x00450D90
			public void __callDele_EventOnAttackButtonClick(ConfigDataSoldierInfo obj)
			{
				this.m_owner.__callDele_EventOnAttackButtonClick(obj);
			}

			// Token: 0x06010A40 RID: 68160 RVA: 0x00452BA0 File Offset: 0x00450DA0
			public void __clearDele_EventOnAttackButtonClick(ConfigDataSoldierInfo obj)
			{
				this.m_owner.__clearDele_EventOnAttackButtonClick(obj);
			}

			// Token: 0x17003373 RID: 13171
			// (get) Token: 0x06010A41 RID: 68161 RVA: 0x00452BB0 File Offset: 0x00450DB0
			// (set) Token: 0x06010A42 RID: 68162 RVA: 0x00452BC0 File Offset: 0x00450DC0
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

			// Token: 0x17003374 RID: 13172
			// (get) Token: 0x06010A43 RID: 68163 RVA: 0x00452BD0 File Offset: 0x00450DD0
			// (set) Token: 0x06010A44 RID: 68164 RVA: 0x00452BE0 File Offset: 0x00450DE0
			public Button m_attackButton
			{
				get
				{
					return this.m_owner.m_attackButton;
				}
				set
				{
					this.m_owner.m_attackButton = value;
				}
			}

			// Token: 0x17003375 RID: 13173
			// (get) Token: 0x06010A45 RID: 68165 RVA: 0x00452BF0 File Offset: 0x00450DF0
			// (set) Token: 0x06010A46 RID: 68166 RVA: 0x00452C00 File Offset: 0x00450E00
			public GameObject m_attackingObj
			{
				get
				{
					return this.m_owner.m_attackingObj;
				}
				set
				{
					this.m_owner.m_attackingObj = value;
				}
			}

			// Token: 0x17003376 RID: 13174
			// (get) Token: 0x06010A47 RID: 68167 RVA: 0x00452C10 File Offset: 0x00450E10
			// (set) Token: 0x06010A48 RID: 68168 RVA: 0x00452C20 File Offset: 0x00450E20
			public GameObject m_dontGetObj
			{
				get
				{
					return this.m_owner.m_dontGetObj;
				}
				set
				{
					this.m_owner.m_dontGetObj = value;
				}
			}

			// Token: 0x17003377 RID: 13175
			// (get) Token: 0x06010A49 RID: 68169 RVA: 0x00452C30 File Offset: 0x00450E30
			// (set) Token: 0x06010A4A RID: 68170 RVA: 0x00452C40 File Offset: 0x00450E40
			public GameObject m_soldierGrapgic
			{
				get
				{
					return this.m_owner.m_soldierGrapgic;
				}
				set
				{
					this.m_owner.m_soldierGrapgic = value;
				}
			}

			// Token: 0x17003378 RID: 13176
			// (get) Token: 0x06010A4B RID: 68171 RVA: 0x00452C50 File Offset: 0x00450E50
			// (set) Token: 0x06010A4C RID: 68172 RVA: 0x00452C60 File Offset: 0x00450E60
			public GameObject m_frameImage
			{
				get
				{
					return this.m_owner.m_frameImage;
				}
				set
				{
					this.m_owner.m_frameImage = value;
				}
			}

			// Token: 0x17003379 RID: 13177
			// (get) Token: 0x06010A4D RID: 68173 RVA: 0x00452C70 File Offset: 0x00450E70
			// (set) Token: 0x06010A4E RID: 68174 RVA: 0x00452C80 File Offset: 0x00450E80
			public GameObject m_skinIconImage
			{
				get
				{
					return this.m_owner.m_skinIconImage;
				}
				set
				{
					this.m_owner.m_skinIconImage = value;
				}
			}

			// Token: 0x1700337A RID: 13178
			// (get) Token: 0x06010A4F RID: 68175 RVA: 0x00452C90 File Offset: 0x00450E90
			// (set) Token: 0x06010A50 RID: 68176 RVA: 0x00452CA0 File Offset: 0x00450EA0
			public bool m_isSoldierGet
			{
				get
				{
					return this.m_owner.m_isSoldierGet;
				}
				set
				{
					this.m_owner.m_isSoldierGet = value;
				}
			}

			// Token: 0x1700337B RID: 13179
			// (get) Token: 0x06010A51 RID: 68177 RVA: 0x00452CB0 File Offset: 0x00450EB0
			// (set) Token: 0x06010A52 RID: 68178 RVA: 0x00452CC0 File Offset: 0x00450EC0
			public int m_soldierSkinId
			{
				get
				{
					return this.m_owner.m_soldierSkinId;
				}
				set
				{
					this.m_owner.m_soldierSkinId = value;
				}
			}

			// Token: 0x1700337C RID: 13180
			// (get) Token: 0x06010A53 RID: 68179 RVA: 0x00452CD0 File Offset: 0x00450ED0
			// (set) Token: 0x06010A54 RID: 68180 RVA: 0x00452CE0 File Offset: 0x00450EE0
			public UISpineGraphic m_graphic
			{
				get
				{
					return this.m_owner.m_graphic;
				}
				set
				{
					this.m_owner.m_graphic = value;
				}
			}

			// Token: 0x06010A55 RID: 68181 RVA: 0x00452CF0 File Offset: 0x00450EF0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010A56 RID: 68182 RVA: 0x00452D00 File Offset: 0x00450F00
			public void OnSoldierItemClick()
			{
				this.m_owner.OnSoldierItemClick();
			}

			// Token: 0x06010A57 RID: 68183 RVA: 0x00452D10 File Offset: 0x00450F10
			public void OnAttackButtonClick()
			{
				this.m_owner.OnAttackButtonClick();
			}

			// Token: 0x06010A58 RID: 68184 RVA: 0x00452D20 File Offset: 0x00450F20
			public void CreateSpineGraphic(ConfigDataSoldierInfo soldierInfo, bool isGet, int soldierSkinId)
			{
				this.m_owner.CreateSpineGraphic(soldierInfo, isGet, soldierSkinId);
			}

			// Token: 0x06010A59 RID: 68185 RVA: 0x00452D30 File Offset: 0x00450F30
			public void DestroySpineGraphic()
			{
				this.m_owner.DestroySpineGraphic();
			}

			// Token: 0x06010A5A RID: 68186 RVA: 0x00452D40 File Offset: 0x00450F40
			public void OnDestroy()
			{
				this.m_owner.OnDestroy();
			}

			// Token: 0x040099EB RID: 39403
			private SoldierItemUIController m_owner;
		}
	}
}
