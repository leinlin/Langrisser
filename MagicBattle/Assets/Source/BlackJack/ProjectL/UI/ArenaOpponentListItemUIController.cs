using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A26 RID: 2598
	[HotFix]
	public class ArenaOpponentListItemUIController : UIControllerBase
	{
		// Token: 0x06009E97 RID: 40599 RVA: 0x002CEAB4 File Offset: 0x002CCCB4
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
			this.m_attackButton.onClick.AddListener(new UnityAction(this.OnAttackButtonClick));
		}

		// Token: 0x06009E98 RID: 40600 RVA: 0x002CEB38 File Offset: 0x002CCD38
		public void SetArenaOpponent(ArenaOpponent o, int idx, bool isGuardBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaOpponentArenaOpponentInt32Boolean_hotfix != null)
			{
				this.m_SetArenaOpponentArenaOpponentInt32Boolean_hotfix.call(new object[]
				{
					this,
					o,
					idx,
					isGuardBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerNameText.text = o.Name;
			this.m_playerLevelText.text = o.Level.ToString();
			this.m_playerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(o.HeadIcon)));
			if (isGuardBattle)
			{
				this.m_arenaPointsGameObject.SetActive(false);
			}
			else
			{
				this.m_arenaPointsGameObject.SetActive(true);
				this.m_arenaPointsText.text = o.ArenaPoints.ToString();
			}
			this.m_index = idx;
			int num = 3 - idx;
			if (isGuardBattle)
			{
				this.m_uiStateCtrl.SetToUIState("High", false, true);
			}
			else if (num == 1)
			{
				this.m_uiStateCtrl.SetToUIState("Low", false, true);
			}
			else if (num == 2)
			{
				this.m_uiStateCtrl.SetToUIState("Normal", false, true);
			}
			else if (num == 3)
			{
				this.m_uiStateCtrl.SetToUIState("High", false, true);
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataArenaOpponentPointZoneInfo configDataArenaOpponentPointZoneInfo = configDataLoader.GetConfigDataArenaOpponentPointZoneInfo(num);
			if (configDataArenaOpponentPointZoneInfo != null)
			{
				this.m_victoryPointsText.text = "+ " + configDataArenaOpponentPointZoneInfo.VictoryPoint;
			}
		}

		// Token: 0x06009E99 RID: 40601 RVA: 0x002CED20 File Offset: 0x002CCF20
		public int GetIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_index;
		}

		// Token: 0x06009E9A RID: 40602 RVA: 0x002CED94 File Offset: 0x002CCF94
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
				this.EventOnAttackButtonClick(this);
			}
		}

		// Token: 0x140001D8 RID: 472
		// (add) Token: 0x06009E9B RID: 40603 RVA: 0x002CEE0C File Offset: 0x002CD00C
		// (remove) Token: 0x06009E9C RID: 40604 RVA: 0x002CEEA8 File Offset: 0x002CD0A8
		public event Action<ArenaOpponentListItemUIController> EventOnAttackButtonClick
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
				Action<ArenaOpponentListItemUIController> action = this.EventOnAttackButtonClick;
				Action<ArenaOpponentListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaOpponentListItemUIController>>(ref this.EventOnAttackButtonClick, (Action<ArenaOpponentListItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<ArenaOpponentListItemUIController> action = this.EventOnAttackButtonClick;
				Action<ArenaOpponentListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaOpponentListItemUIController>>(ref this.EventOnAttackButtonClick, (Action<ArenaOpponentListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x06009E9D RID: 40605 RVA: 0x002CEF44 File Offset: 0x002CD144
		// (set) Token: 0x06009E9E RID: 40606 RVA: 0x002CEF64 File Offset: 0x002CD164
		[DoNotToLua]
		public new ArenaOpponentListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaOpponentListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x002CEF70 File Offset: 0x002CD170
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x002CEF7C File Offset: 0x002CD17C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009EA1 RID: 40609 RVA: 0x002CEF84 File Offset: 0x002CD184
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x002CEF8C File Offset: 0x002CD18C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009EA3 RID: 40611 RVA: 0x002CEFA0 File Offset: 0x002CD1A0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x002CEFA8 File Offset: 0x002CD1A8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x002CEFB4 File Offset: 0x002CD1B4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x002CEFC0 File Offset: 0x002CD1C0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x002CEFCC File Offset: 0x002CD1CC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009EA8 RID: 40616 RVA: 0x002CEFD8 File Offset: 0x002CD1D8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x002CEFE4 File Offset: 0x002CD1E4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x002CEFF0 File Offset: 0x002CD1F0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009EAB RID: 40619 RVA: 0x002CEFFC File Offset: 0x002CD1FC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009EAC RID: 40620 RVA: 0x002CF008 File Offset: 0x002CD208
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009EAD RID: 40621 RVA: 0x002CF014 File Offset: 0x002CD214
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009EAE RID: 40622 RVA: 0x002CF01C File Offset: 0x002CD21C
		private void __callDele_EventOnAttackButtonClick(ArenaOpponentListItemUIController obj)
		{
			Action<ArenaOpponentListItemUIController> eventOnAttackButtonClick = this.EventOnAttackButtonClick;
			if (eventOnAttackButtonClick != null)
			{
				eventOnAttackButtonClick(obj);
			}
		}

		// Token: 0x06009EAF RID: 40623 RVA: 0x002CF040 File Offset: 0x002CD240
		private void __clearDele_EventOnAttackButtonClick(ArenaOpponentListItemUIController obj)
		{
			this.EventOnAttackButtonClick = null;
		}

		// Token: 0x06009EB0 RID: 40624 RVA: 0x002CF04C File Offset: 0x002CD24C
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
					this.m_SetArenaOpponentArenaOpponentInt32Boolean_hotfix = (luaObj.RawGet("SetArenaOpponent") as LuaFunction);
					this.m_GetIndex_hotfix = (luaObj.RawGet("GetIndex") as LuaFunction);
					this.m_OnAttackButtonClick_hotfix = (luaObj.RawGet("OnAttackButtonClick") as LuaFunction);
					this.m_add_EventOnAttackButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnAttackButtonClick") as LuaFunction);
					this.m_remove_EventOnAttackButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnAttackButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009EB1 RID: 40625 RVA: 0x002CF194 File Offset: 0x002CD394
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaOpponentListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006B46 RID: 27462
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateCtrl;

		// Token: 0x04006B47 RID: 27463
		[AutoBind("./PlayerIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerIconImage;

		// Token: 0x04006B48 RID: 27464
		[AutoBind("./PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x04006B49 RID: 27465
		[AutoBind("./PlayerLevel/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x04006B4A RID: 27466
		[AutoBind("./ArenaPoints", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arenaPointsGameObject;

		// Token: 0x04006B4B RID: 27467
		[AutoBind("./ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_arenaPointsText;

		// Token: 0x04006B4C RID: 27468
		[AutoBind("./VictoryPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_victoryPointsText;

		// Token: 0x04006B4D RID: 27469
		[AutoBind("./AttackButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_attackButton;

		// Token: 0x04006B4E RID: 27470
		private int m_index;

		// Token: 0x04006B4F RID: 27471
		[DoNotToLua]
		private ArenaOpponentListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006B50 RID: 27472
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006B51 RID: 27473
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006B52 RID: 27474
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006B53 RID: 27475
		private LuaFunction m_SetArenaOpponentArenaOpponentInt32Boolean_hotfix;

		// Token: 0x04006B54 RID: 27476
		private LuaFunction m_GetIndex_hotfix;

		// Token: 0x04006B55 RID: 27477
		private LuaFunction m_OnAttackButtonClick_hotfix;

		// Token: 0x04006B56 RID: 27478
		private LuaFunction m_add_EventOnAttackButtonClickAction;

		// Token: 0x04006B57 RID: 27479
		private LuaFunction m_remove_EventOnAttackButtonClickAction;

		// Token: 0x02000A27 RID: 2599
		public new class LuaExportHelper
		{
			// Token: 0x06009EB2 RID: 40626 RVA: 0x002CF1FC File Offset: 0x002CD3FC
			public LuaExportHelper(ArenaOpponentListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009EB3 RID: 40627 RVA: 0x002CF20C File Offset: 0x002CD40C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009EB4 RID: 40628 RVA: 0x002CF21C File Offset: 0x002CD41C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009EB5 RID: 40629 RVA: 0x002CF22C File Offset: 0x002CD42C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009EB6 RID: 40630 RVA: 0x002CF23C File Offset: 0x002CD43C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009EB7 RID: 40631 RVA: 0x002CF254 File Offset: 0x002CD454
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009EB8 RID: 40632 RVA: 0x002CF264 File Offset: 0x002CD464
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009EB9 RID: 40633 RVA: 0x002CF274 File Offset: 0x002CD474
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009EBA RID: 40634 RVA: 0x002CF284 File Offset: 0x002CD484
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009EBB RID: 40635 RVA: 0x002CF294 File Offset: 0x002CD494
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009EBC RID: 40636 RVA: 0x002CF2A4 File Offset: 0x002CD4A4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009EBD RID: 40637 RVA: 0x002CF2B4 File Offset: 0x002CD4B4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009EBE RID: 40638 RVA: 0x002CF2C4 File Offset: 0x002CD4C4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009EBF RID: 40639 RVA: 0x002CF2D4 File Offset: 0x002CD4D4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009EC0 RID: 40640 RVA: 0x002CF2E4 File Offset: 0x002CD4E4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009EC1 RID: 40641 RVA: 0x002CF2F4 File Offset: 0x002CD4F4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009EC2 RID: 40642 RVA: 0x002CF304 File Offset: 0x002CD504
			public void __callDele_EventOnAttackButtonClick(ArenaOpponentListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnAttackButtonClick(obj);
			}

			// Token: 0x06009EC3 RID: 40643 RVA: 0x002CF314 File Offset: 0x002CD514
			public void __clearDele_EventOnAttackButtonClick(ArenaOpponentListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnAttackButtonClick(obj);
			}

			// Token: 0x1700206C RID: 8300
			// (get) Token: 0x06009EC4 RID: 40644 RVA: 0x002CF324 File Offset: 0x002CD524
			// (set) Token: 0x06009EC5 RID: 40645 RVA: 0x002CF334 File Offset: 0x002CD534
			public CommonUIStateController m_uiStateCtrl
			{
				get
				{
					return this.m_owner.m_uiStateCtrl;
				}
				set
				{
					this.m_owner.m_uiStateCtrl = value;
				}
			}

			// Token: 0x1700206D RID: 8301
			// (get) Token: 0x06009EC6 RID: 40646 RVA: 0x002CF344 File Offset: 0x002CD544
			// (set) Token: 0x06009EC7 RID: 40647 RVA: 0x002CF354 File Offset: 0x002CD554
			public Image m_playerIconImage
			{
				get
				{
					return this.m_owner.m_playerIconImage;
				}
				set
				{
					this.m_owner.m_playerIconImage = value;
				}
			}

			// Token: 0x1700206E RID: 8302
			// (get) Token: 0x06009EC8 RID: 40648 RVA: 0x002CF364 File Offset: 0x002CD564
			// (set) Token: 0x06009EC9 RID: 40649 RVA: 0x002CF374 File Offset: 0x002CD574
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

			// Token: 0x1700206F RID: 8303
			// (get) Token: 0x06009ECA RID: 40650 RVA: 0x002CF384 File Offset: 0x002CD584
			// (set) Token: 0x06009ECB RID: 40651 RVA: 0x002CF394 File Offset: 0x002CD594
			public Text m_playerLevelText
			{
				get
				{
					return this.m_owner.m_playerLevelText;
				}
				set
				{
					this.m_owner.m_playerLevelText = value;
				}
			}

			// Token: 0x17002070 RID: 8304
			// (get) Token: 0x06009ECC RID: 40652 RVA: 0x002CF3A4 File Offset: 0x002CD5A4
			// (set) Token: 0x06009ECD RID: 40653 RVA: 0x002CF3B4 File Offset: 0x002CD5B4
			public GameObject m_arenaPointsGameObject
			{
				get
				{
					return this.m_owner.m_arenaPointsGameObject;
				}
				set
				{
					this.m_owner.m_arenaPointsGameObject = value;
				}
			}

			// Token: 0x17002071 RID: 8305
			// (get) Token: 0x06009ECE RID: 40654 RVA: 0x002CF3C4 File Offset: 0x002CD5C4
			// (set) Token: 0x06009ECF RID: 40655 RVA: 0x002CF3D4 File Offset: 0x002CD5D4
			public Text m_arenaPointsText
			{
				get
				{
					return this.m_owner.m_arenaPointsText;
				}
				set
				{
					this.m_owner.m_arenaPointsText = value;
				}
			}

			// Token: 0x17002072 RID: 8306
			// (get) Token: 0x06009ED0 RID: 40656 RVA: 0x002CF3E4 File Offset: 0x002CD5E4
			// (set) Token: 0x06009ED1 RID: 40657 RVA: 0x002CF3F4 File Offset: 0x002CD5F4
			public Text m_victoryPointsText
			{
				get
				{
					return this.m_owner.m_victoryPointsText;
				}
				set
				{
					this.m_owner.m_victoryPointsText = value;
				}
			}

			// Token: 0x17002073 RID: 8307
			// (get) Token: 0x06009ED2 RID: 40658 RVA: 0x002CF404 File Offset: 0x002CD604
			// (set) Token: 0x06009ED3 RID: 40659 RVA: 0x002CF414 File Offset: 0x002CD614
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

			// Token: 0x17002074 RID: 8308
			// (get) Token: 0x06009ED4 RID: 40660 RVA: 0x002CF424 File Offset: 0x002CD624
			// (set) Token: 0x06009ED5 RID: 40661 RVA: 0x002CF434 File Offset: 0x002CD634
			public int m_index
			{
				get
				{
					return this.m_owner.m_index;
				}
				set
				{
					this.m_owner.m_index = value;
				}
			}

			// Token: 0x06009ED6 RID: 40662 RVA: 0x002CF444 File Offset: 0x002CD644
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06009ED7 RID: 40663 RVA: 0x002CF454 File Offset: 0x002CD654
			public void OnAttackButtonClick()
			{
				this.m_owner.OnAttackButtonClick();
			}

			// Token: 0x04006B58 RID: 27480
			private ArenaOpponentListItemUIController m_owner;
		}
	}
}
