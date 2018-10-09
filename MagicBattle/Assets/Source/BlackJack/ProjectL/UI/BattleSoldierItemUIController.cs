using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000ACC RID: 2764
	[HotFix]
	public class BattleSoldierItemUIController : UIControllerBase
	{
		// Token: 0x0600B3DC RID: 46044 RVA: 0x0031AE80 File Offset: 0x00319080
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
			this.m_selectButton.onClick.AddListener(new UnityAction(this.OnSelectButtonClick));
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x0031AF2C File Offset: 0x0031912C
		public void InitSoldierItem(ConfigDataSoldierInfo soldierInfo, ConfigDataModelSkinResourceInfo soldierSkinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSoldierItemConfigDataSoldierInfoConfigDataModelSkinResourceInfo_hotfix != null)
			{
				this.m_InitSoldierItemConfigDataSoldierInfoConfigDataModelSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					soldierInfo,
					soldierSkinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SoldierInfo = soldierInfo;
			this.m_solderSkinResInfo = soldierSkinResInfo;
			this.m_soldierIconImg.sprite = AssetUtility.Instance.GetSprite(this.SoldierInfo.m_armyInfo.Icon);
			this.m_typeBgImage.gameObject.SetActive(this.SoldierInfo.IsMelee);
			this.m_typeBgImage2.gameObject.SetActive(!this.SoldierInfo.IsMelee);
			this.m_soldierRangeText.text = this.SoldierInfo.BF_AttackDistance.ToString();
			this.m_soldierMoveText.text = this.SoldierInfo.BF_MovePoint.ToString();
			this.m_soldierNameText.text = this.SoldierInfo.Name;
			this.CreateSpineGraphic();
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x0031B07C File Offset: 0x0031927C
		private void OnSelectButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectButtonClick_hotfix != null)
			{
				this.m_OnSelectButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSelectButtonClick != null)
			{
				this.EventOnSelectButtonClick(this);
			}
		}

		// Token: 0x0600B3DF RID: 46047 RVA: 0x0031B0F4 File Offset: 0x003192F4
		public void SetSelectPanel(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectPanelBoolean_hotfix != null)
			{
				this.m_SetSelectPanelBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectPanel.SetActive(isShow);
		}

		// Token: 0x0600B3E0 RID: 46048 RVA: 0x0031B170 File Offset: 0x00319370
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
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

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x0031B1E8 File Offset: 0x003193E8
		private void CreateSpineGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphic_hotfix != null)
			{
				this.m_CreateSpineGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic();
			if (this.SoldierInfo == null)
			{
				return;
			}
			float num = (float)this.SoldierInfo.UI_ModelScale * 0.01f;
			Vector2 position = new Vector2((float)this.SoldierInfo.UI_ModelOffsetX, (float)this.SoldierInfo.UI_ModelOffsetY);
			string text = string.Empty;
			if (this.m_solderSkinResInfo != null)
			{
				text = this.m_solderSkinResInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = this.SoldierInfo.Model;
			}
			this.m_graphic = new UISpineGraphic();
			this.m_graphic.Create(text);
			this.m_graphic.SetParent(this.m_soldierGrapgic);
			this.m_graphic.SetDirection(1);
			this.m_graphic.SetPosition(position);
			this.m_graphic.SetScale(num);
			this.m_graphic.SetRectTransformSize(new Vector2(500f / num, 500f / num));
			this.m_graphic.SetReplaceAnimations(this.SoldierInfo.ReplaceAnims);
			this.m_graphic.PlayAnimation("idle", true, 0);
			this.m_graphic.ForceUpdate();
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x0031B360 File Offset: 0x00319560
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

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x0031B3E0 File Offset: 0x003195E0
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
			this.DestroySpineGraphic();
		}

		// Token: 0x14000223 RID: 547
		// (add) Token: 0x0600B3E4 RID: 46052 RVA: 0x0031B448 File Offset: 0x00319648
		// (remove) Token: 0x0600B3E5 RID: 46053 RVA: 0x0031B4E4 File Offset: 0x003196E4
		public event Action<BattleSoldierItemUIController> EventOnSoldierItemClick
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
				Action<BattleSoldierItemUIController> action = this.EventOnSoldierItemClick;
				Action<BattleSoldierItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleSoldierItemUIController>>(ref this.EventOnSoldierItemClick, (Action<BattleSoldierItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<BattleSoldierItemUIController> action = this.EventOnSoldierItemClick;
				Action<BattleSoldierItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleSoldierItemUIController>>(ref this.EventOnSoldierItemClick, (Action<BattleSoldierItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000224 RID: 548
		// (add) Token: 0x0600B3E6 RID: 46054 RVA: 0x0031B580 File Offset: 0x00319780
		// (remove) Token: 0x0600B3E7 RID: 46055 RVA: 0x0031B61C File Offset: 0x0031981C
		public event Action<BattleSoldierItemUIController> EventOnSelectButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnSelectButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleSoldierItemUIController> action = this.EventOnSelectButtonClick;
				Action<BattleSoldierItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleSoldierItemUIController>>(ref this.EventOnSelectButtonClick, (Action<BattleSoldierItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnSelectButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleSoldierItemUIController> action = this.EventOnSelectButtonClick;
				Action<BattleSoldierItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleSoldierItemUIController>>(ref this.EventOnSelectButtonClick, (Action<BattleSoldierItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x0600B3E9 RID: 46057 RVA: 0x0031B730 File Offset: 0x00319930
		// (set) Token: 0x0600B3E8 RID: 46056 RVA: 0x0031B6B8 File Offset: 0x003198B8
		public ConfigDataSoldierInfo SoldierInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierInfo_hotfix != null)
				{
					return (ConfigDataSoldierInfo)this.m_get_SoldierInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<SoldierInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_SoldierInfoConfigDataSoldierInfo_hotfix != null)
				{
					this.m_set_SoldierInfoConfigDataSoldierInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<SoldierInfo>k__BackingField = value;
			}
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x0600B3EA RID: 46058 RVA: 0x0031B7A4 File Offset: 0x003199A4
		// (set) Token: 0x0600B3EB RID: 46059 RVA: 0x0031B7C4 File Offset: 0x003199C4
		[DoNotToLua]
		public new BattleSoldierItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleSoldierItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B3EC RID: 46060 RVA: 0x0031B7D0 File Offset: 0x003199D0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600B3ED RID: 46061 RVA: 0x0031B7DC File Offset: 0x003199DC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600B3EE RID: 46062 RVA: 0x0031B7E4 File Offset: 0x003199E4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600B3EF RID: 46063 RVA: 0x0031B7EC File Offset: 0x003199EC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600B3F0 RID: 46064 RVA: 0x0031B800 File Offset: 0x00319A00
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600B3F1 RID: 46065 RVA: 0x0031B808 File Offset: 0x00319A08
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600B3F2 RID: 46066 RVA: 0x0031B814 File Offset: 0x00319A14
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x0031B820 File Offset: 0x00319A20
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x0031B82C File Offset: 0x00319A2C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600B3F5 RID: 46069 RVA: 0x0031B838 File Offset: 0x00319A38
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600B3F6 RID: 46070 RVA: 0x0031B844 File Offset: 0x00319A44
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600B3F7 RID: 46071 RVA: 0x0031B850 File Offset: 0x00319A50
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600B3F8 RID: 46072 RVA: 0x0031B85C File Offset: 0x00319A5C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600B3F9 RID: 46073 RVA: 0x0031B868 File Offset: 0x00319A68
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600B3FA RID: 46074 RVA: 0x0031B874 File Offset: 0x00319A74
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600B3FB RID: 46075 RVA: 0x0031B87C File Offset: 0x00319A7C
		private void __callDele_EventOnSoldierItemClick(BattleSoldierItemUIController obj)
		{
			Action<BattleSoldierItemUIController> eventOnSoldierItemClick = this.EventOnSoldierItemClick;
			if (eventOnSoldierItemClick != null)
			{
				eventOnSoldierItemClick(obj);
			}
		}

		// Token: 0x0600B3FC RID: 46076 RVA: 0x0031B8A0 File Offset: 0x00319AA0
		private void __clearDele_EventOnSoldierItemClick(BattleSoldierItemUIController obj)
		{
			this.EventOnSoldierItemClick = null;
		}

		// Token: 0x0600B3FD RID: 46077 RVA: 0x0031B8AC File Offset: 0x00319AAC
		private void __callDele_EventOnSelectButtonClick(BattleSoldierItemUIController obj)
		{
			Action<BattleSoldierItemUIController> eventOnSelectButtonClick = this.EventOnSelectButtonClick;
			if (eventOnSelectButtonClick != null)
			{
				eventOnSelectButtonClick(obj);
			}
		}

		// Token: 0x0600B3FE RID: 46078 RVA: 0x0031B8D0 File Offset: 0x00319AD0
		private void __clearDele_EventOnSelectButtonClick(BattleSoldierItemUIController obj)
		{
			this.EventOnSelectButtonClick = null;
		}

		// Token: 0x0600B3FF RID: 46079 RVA: 0x0031B8DC File Offset: 0x00319ADC
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
					this.m_InitSoldierItemConfigDataSoldierInfoConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("InitSoldierItem") as LuaFunction);
					this.m_OnSelectButtonClick_hotfix = (luaObj.RawGet("OnSelectButtonClick") as LuaFunction);
					this.m_SetSelectPanelBoolean_hotfix = (luaObj.RawGet("SetSelectPanel") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_CreateSpineGraphic_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_OnDestroy_hotfix = (luaObj.RawGet("OnDestroy") as LuaFunction);
					this.m_add_EventOnSoldierItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnSoldierItemClick") as LuaFunction);
					this.m_remove_EventOnSoldierItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnSoldierItemClick") as LuaFunction);
					this.m_add_EventOnSelectButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnSelectButtonClick") as LuaFunction);
					this.m_remove_EventOnSelectButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnSelectButtonClick") as LuaFunction);
					this.m_set_SoldierInfoConfigDataSoldierInfo_hotfix = (luaObj.RawGet("set_SoldierInfo") as LuaFunction);
					this.m_get_SoldierInfo_hotfix = (luaObj.RawGet("get_SoldierInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B400 RID: 46080 RVA: 0x0031BAEC File Offset: 0x00319CEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleSoldierItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400748B RID: 29835
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400748C RID: 29836
		[AutoBind("./SoldierIconImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierIconImg;

		// Token: 0x0400748D RID: 29837
		[AutoBind("./Faction/RangeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierRangeText;

		// Token: 0x0400748E RID: 29838
		[AutoBind("./Faction/MoveValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMoveText;

		// Token: 0x0400748F RID: 29839
		[AutoBind("./Faction/TypeBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_typeBgImage;

		// Token: 0x04007490 RID: 29840
		[AutoBind("./Faction/TypeBgImage2", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_typeBgImage2;

		// Token: 0x04007491 RID: 29841
		[AutoBind("./TitleBg/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierNameText;

		// Token: 0x04007492 RID: 29842
		[AutoBind("./SelectButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_selectButton;

		// Token: 0x04007493 RID: 29843
		[AutoBind("./SelectTag", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectPanel;

		// Token: 0x04007494 RID: 29844
		[AutoBind("./Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGrapgic;

		// Token: 0x04007495 RID: 29845
		private UISpineGraphic m_graphic;

		// Token: 0x04007496 RID: 29846
		private ConfigDataModelSkinResourceInfo m_solderSkinResInfo;

		// Token: 0x04007498 RID: 29848
		[DoNotToLua]
		private BattleSoldierItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007499 RID: 29849
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400749A RID: 29850
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400749B RID: 29851
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400749C RID: 29852
		private LuaFunction m_InitSoldierItemConfigDataSoldierInfoConfigDataModelSkinResourceInfo_hotfix;

		// Token: 0x0400749D RID: 29853
		private LuaFunction m_OnSelectButtonClick_hotfix;

		// Token: 0x0400749E RID: 29854
		private LuaFunction m_SetSelectPanelBoolean_hotfix;

		// Token: 0x0400749F RID: 29855
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x040074A0 RID: 29856
		private LuaFunction m_CreateSpineGraphic_hotfix;

		// Token: 0x040074A1 RID: 29857
		private LuaFunction m_DestroySpineGraphic_hotfix;

		// Token: 0x040074A2 RID: 29858
		private LuaFunction m_OnDestroy_hotfix;

		// Token: 0x040074A3 RID: 29859
		private LuaFunction m_add_EventOnSoldierItemClickAction;

		// Token: 0x040074A4 RID: 29860
		private LuaFunction m_remove_EventOnSoldierItemClickAction;

		// Token: 0x040074A5 RID: 29861
		private LuaFunction m_add_EventOnSelectButtonClickAction;

		// Token: 0x040074A6 RID: 29862
		private LuaFunction m_remove_EventOnSelectButtonClickAction;

		// Token: 0x040074A7 RID: 29863
		private LuaFunction m_set_SoldierInfoConfigDataSoldierInfo_hotfix;

		// Token: 0x040074A8 RID: 29864
		private LuaFunction m_get_SoldierInfo_hotfix;

		// Token: 0x02000ACD RID: 2765
		public new class LuaExportHelper
		{
			// Token: 0x0600B401 RID: 46081 RVA: 0x0031BB54 File Offset: 0x00319D54
			public LuaExportHelper(BattleSoldierItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B402 RID: 46082 RVA: 0x0031BB64 File Offset: 0x00319D64
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600B403 RID: 46083 RVA: 0x0031BB74 File Offset: 0x00319D74
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600B404 RID: 46084 RVA: 0x0031BB84 File Offset: 0x00319D84
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600B405 RID: 46085 RVA: 0x0031BB94 File Offset: 0x00319D94
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600B406 RID: 46086 RVA: 0x0031BBAC File Offset: 0x00319DAC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600B407 RID: 46087 RVA: 0x0031BBBC File Offset: 0x00319DBC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600B408 RID: 46088 RVA: 0x0031BBCC File Offset: 0x00319DCC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600B409 RID: 46089 RVA: 0x0031BBDC File Offset: 0x00319DDC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600B40A RID: 46090 RVA: 0x0031BBEC File Offset: 0x00319DEC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600B40B RID: 46091 RVA: 0x0031BBFC File Offset: 0x00319DFC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600B40C RID: 46092 RVA: 0x0031BC0C File Offset: 0x00319E0C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600B40D RID: 46093 RVA: 0x0031BC1C File Offset: 0x00319E1C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600B40E RID: 46094 RVA: 0x0031BC2C File Offset: 0x00319E2C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600B40F RID: 46095 RVA: 0x0031BC3C File Offset: 0x00319E3C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600B410 RID: 46096 RVA: 0x0031BC4C File Offset: 0x00319E4C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600B411 RID: 46097 RVA: 0x0031BC5C File Offset: 0x00319E5C
			public void __callDele_EventOnSoldierItemClick(BattleSoldierItemUIController obj)
			{
				this.m_owner.__callDele_EventOnSoldierItemClick(obj);
			}

			// Token: 0x0600B412 RID: 46098 RVA: 0x0031BC6C File Offset: 0x00319E6C
			public void __clearDele_EventOnSoldierItemClick(BattleSoldierItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnSoldierItemClick(obj);
			}

			// Token: 0x0600B413 RID: 46099 RVA: 0x0031BC7C File Offset: 0x00319E7C
			public void __callDele_EventOnSelectButtonClick(BattleSoldierItemUIController obj)
			{
				this.m_owner.__callDele_EventOnSelectButtonClick(obj);
			}

			// Token: 0x0600B414 RID: 46100 RVA: 0x0031BC8C File Offset: 0x00319E8C
			public void __clearDele_EventOnSelectButtonClick(BattleSoldierItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnSelectButtonClick(obj);
			}

			// Token: 0x1700246E RID: 9326
			// (get) Token: 0x0600B415 RID: 46101 RVA: 0x0031BC9C File Offset: 0x00319E9C
			// (set) Token: 0x0600B416 RID: 46102 RVA: 0x0031BCAC File Offset: 0x00319EAC
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x1700246F RID: 9327
			// (get) Token: 0x0600B417 RID: 46103 RVA: 0x0031BCBC File Offset: 0x00319EBC
			// (set) Token: 0x0600B418 RID: 46104 RVA: 0x0031BCCC File Offset: 0x00319ECC
			public Image m_soldierIconImg
			{
				get
				{
					return this.m_owner.m_soldierIconImg;
				}
				set
				{
					this.m_owner.m_soldierIconImg = value;
				}
			}

			// Token: 0x17002470 RID: 9328
			// (get) Token: 0x0600B419 RID: 46105 RVA: 0x0031BCDC File Offset: 0x00319EDC
			// (set) Token: 0x0600B41A RID: 46106 RVA: 0x0031BCEC File Offset: 0x00319EEC
			public Text m_soldierRangeText
			{
				get
				{
					return this.m_owner.m_soldierRangeText;
				}
				set
				{
					this.m_owner.m_soldierRangeText = value;
				}
			}

			// Token: 0x17002471 RID: 9329
			// (get) Token: 0x0600B41B RID: 46107 RVA: 0x0031BCFC File Offset: 0x00319EFC
			// (set) Token: 0x0600B41C RID: 46108 RVA: 0x0031BD0C File Offset: 0x00319F0C
			public Text m_soldierMoveText
			{
				get
				{
					return this.m_owner.m_soldierMoveText;
				}
				set
				{
					this.m_owner.m_soldierMoveText = value;
				}
			}

			// Token: 0x17002472 RID: 9330
			// (get) Token: 0x0600B41D RID: 46109 RVA: 0x0031BD1C File Offset: 0x00319F1C
			// (set) Token: 0x0600B41E RID: 46110 RVA: 0x0031BD2C File Offset: 0x00319F2C
			public Image m_typeBgImage
			{
				get
				{
					return this.m_owner.m_typeBgImage;
				}
				set
				{
					this.m_owner.m_typeBgImage = value;
				}
			}

			// Token: 0x17002473 RID: 9331
			// (get) Token: 0x0600B41F RID: 46111 RVA: 0x0031BD3C File Offset: 0x00319F3C
			// (set) Token: 0x0600B420 RID: 46112 RVA: 0x0031BD4C File Offset: 0x00319F4C
			public Image m_typeBgImage2
			{
				get
				{
					return this.m_owner.m_typeBgImage2;
				}
				set
				{
					this.m_owner.m_typeBgImage2 = value;
				}
			}

			// Token: 0x17002474 RID: 9332
			// (get) Token: 0x0600B421 RID: 46113 RVA: 0x0031BD5C File Offset: 0x00319F5C
			// (set) Token: 0x0600B422 RID: 46114 RVA: 0x0031BD6C File Offset: 0x00319F6C
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

			// Token: 0x17002475 RID: 9333
			// (get) Token: 0x0600B423 RID: 46115 RVA: 0x0031BD7C File Offset: 0x00319F7C
			// (set) Token: 0x0600B424 RID: 46116 RVA: 0x0031BD8C File Offset: 0x00319F8C
			public Button m_selectButton
			{
				get
				{
					return this.m_owner.m_selectButton;
				}
				set
				{
					this.m_owner.m_selectButton = value;
				}
			}

			// Token: 0x17002476 RID: 9334
			// (get) Token: 0x0600B425 RID: 46117 RVA: 0x0031BD9C File Offset: 0x00319F9C
			// (set) Token: 0x0600B426 RID: 46118 RVA: 0x0031BDAC File Offset: 0x00319FAC
			public GameObject m_selectPanel
			{
				get
				{
					return this.m_owner.m_selectPanel;
				}
				set
				{
					this.m_owner.m_selectPanel = value;
				}
			}

			// Token: 0x17002477 RID: 9335
			// (get) Token: 0x0600B427 RID: 46119 RVA: 0x0031BDBC File Offset: 0x00319FBC
			// (set) Token: 0x0600B428 RID: 46120 RVA: 0x0031BDCC File Offset: 0x00319FCC
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

			// Token: 0x17002478 RID: 9336
			// (get) Token: 0x0600B429 RID: 46121 RVA: 0x0031BDDC File Offset: 0x00319FDC
			// (set) Token: 0x0600B42A RID: 46122 RVA: 0x0031BDEC File Offset: 0x00319FEC
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

			// Token: 0x17002479 RID: 9337
			// (get) Token: 0x0600B42B RID: 46123 RVA: 0x0031BDFC File Offset: 0x00319FFC
			// (set) Token: 0x0600B42C RID: 46124 RVA: 0x0031BE0C File Offset: 0x0031A00C
			public ConfigDataModelSkinResourceInfo m_solderSkinResInfo
			{
				get
				{
					return this.m_owner.m_solderSkinResInfo;
				}
				set
				{
					this.m_owner.m_solderSkinResInfo = value;
				}
			}

			// Token: 0x1700247A RID: 9338
			// (set) Token: 0x0600B42D RID: 46125 RVA: 0x0031BE1C File Offset: 0x0031A01C
			public ConfigDataSoldierInfo SoldierInfo
			{
				set
				{
					this.m_owner.SoldierInfo = value;
				}
			}

			// Token: 0x0600B42E RID: 46126 RVA: 0x0031BE2C File Offset: 0x0031A02C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600B42F RID: 46127 RVA: 0x0031BE3C File Offset: 0x0031A03C
			public void OnSelectButtonClick()
			{
				this.m_owner.OnSelectButtonClick();
			}

			// Token: 0x0600B430 RID: 46128 RVA: 0x0031BE4C File Offset: 0x0031A04C
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0600B431 RID: 46129 RVA: 0x0031BE5C File Offset: 0x0031A05C
			public void CreateSpineGraphic()
			{
				this.m_owner.CreateSpineGraphic();
			}

			// Token: 0x0600B432 RID: 46130 RVA: 0x0031BE6C File Offset: 0x0031A06C
			public void DestroySpineGraphic()
			{
				this.m_owner.DestroySpineGraphic();
			}

			// Token: 0x0600B433 RID: 46131 RVA: 0x0031BE7C File Offset: 0x0031A07C
			public void OnDestroy()
			{
				this.m_owner.OnDestroy();
			}

			// Token: 0x040074A9 RID: 29865
			private BattleSoldierItemUIController m_owner;
		}
	}
}
