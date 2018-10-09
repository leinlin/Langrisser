using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BC0 RID: 3008
	[HotFix]
	public class GetRewardGoodsUIController : UIControllerBase
	{
		// Token: 0x0600CEF2 RID: 52978 RVA: 0x0038DA84 File Offset: 0x0038BC84
		private GetRewardGoodsUIController()
		{
		}

		// Token: 0x0600CEF3 RID: 52979 RVA: 0x0038DA8C File Offset: 0x0038BC8C
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
		}

		// Token: 0x0600CEF4 RID: 52980 RVA: 0x0038DB10 File Offset: 0x0038BD10
		public void ShowReward(List<Goods> itemList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRewardList`1_hotfix != null)
			{
				this.m_ShowRewardList`1_hotfix.call(new object[]
				{
					this,
					itemList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_ShowReward(itemList));
		}

		// Token: 0x0600CEF5 RID: 52981 RVA: 0x0038DB90 File Offset: 0x0038BD90
		[DebuggerHidden]
		private IEnumerator Co_ShowReward(List<Goods> goodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowRewardList`1_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowRewardList`1_hotfix.call(new object[]
				{
					this,
					goodsList
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetRewardGoodsUIController.<Co_ShowReward>c__Iterator0 <Co_ShowReward>c__Iterator = new GetRewardGoodsUIController.<Co_ShowReward>c__Iterator0();
			<Co_ShowReward>c__Iterator.goodsList = goodsList;
			<Co_ShowReward>c__Iterator.$this = this;
			return <Co_ShowReward>c__Iterator;
		}

		// Token: 0x0600CEF6 RID: 52982 RVA: 0x0038DC24 File Offset: 0x0038BE24
		[DebuggerHidden]
		private IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix != null)
			{
				return (IEnumerator)this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix.call(new object[]
				{
					this,
					ctrl,
					state
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetRewardGoodsUIController.<Co_SetAndWaitUIState>c__Iterator1 <Co_SetAndWaitUIState>c__Iterator = new GetRewardGoodsUIController.<Co_SetAndWaitUIState>c__Iterator1();
			<Co_SetAndWaitUIState>c__Iterator.ctrl = ctrl;
			<Co_SetAndWaitUIState>c__Iterator.state = state;
			return <Co_SetAndWaitUIState>c__Iterator;
		}

		// Token: 0x0600CEF7 RID: 52983 RVA: 0x0038DCC8 File Offset: 0x0038BEC8
		[DebuggerHidden]
		private IEnumerator Co_WaitClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_WaitClick_hotfix != null)
			{
				return (IEnumerator)this.m_Co_WaitClick_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetRewardGoodsUIController.<Co_WaitClick>c__Iterator2 <Co_WaitClick>c__Iterator = new GetRewardGoodsUIController.<Co_WaitClick>c__Iterator2();
			<Co_WaitClick>c__Iterator.$this = this;
			return <Co_WaitClick>c__Iterator;
		}

		// Token: 0x0600CEF8 RID: 52984 RVA: 0x0038DD44 File Offset: 0x0038BF44
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isClick = true;
		}

		// Token: 0x1400027A RID: 634
		// (add) Token: 0x0600CEF9 RID: 52985 RVA: 0x0038DDAC File Offset: 0x0038BFAC
		// (remove) Token: 0x0600CEFA RID: 52986 RVA: 0x0038DE48 File Offset: 0x0038C048
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x0600CEFB RID: 52987 RVA: 0x0038DEE4 File Offset: 0x0038C0E4
		// (set) Token: 0x0600CEFC RID: 52988 RVA: 0x0038DF04 File Offset: 0x0038C104
		[DoNotToLua]
		public new GetRewardGoodsUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GetRewardGoodsUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CEFD RID: 52989 RVA: 0x0038DF10 File Offset: 0x0038C110
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600CEFE RID: 52990 RVA: 0x0038DF1C File Offset: 0x0038C11C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600CEFF RID: 52991 RVA: 0x0038DF24 File Offset: 0x0038C124
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600CF00 RID: 52992 RVA: 0x0038DF2C File Offset: 0x0038C12C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600CF01 RID: 52993 RVA: 0x0038DF40 File Offset: 0x0038C140
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600CF02 RID: 52994 RVA: 0x0038DF48 File Offset: 0x0038C148
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600CF03 RID: 52995 RVA: 0x0038DF54 File Offset: 0x0038C154
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600CF04 RID: 52996 RVA: 0x0038DF60 File Offset: 0x0038C160
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600CF05 RID: 52997 RVA: 0x0038DF6C File Offset: 0x0038C16C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600CF06 RID: 52998 RVA: 0x0038DF78 File Offset: 0x0038C178
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600CF07 RID: 52999 RVA: 0x0038DF84 File Offset: 0x0038C184
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600CF08 RID: 53000 RVA: 0x0038DF90 File Offset: 0x0038C190
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600CF09 RID: 53001 RVA: 0x0038DF9C File Offset: 0x0038C19C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600CF0A RID: 53002 RVA: 0x0038DFA8 File Offset: 0x0038C1A8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600CF0B RID: 53003 RVA: 0x0038DFB4 File Offset: 0x0038C1B4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600CF0C RID: 53004 RVA: 0x0038DFBC File Offset: 0x0038C1BC
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600CF0D RID: 53005 RVA: 0x0038DFDC File Offset: 0x0038C1DC
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600CF0E RID: 53006 RVA: 0x0038DFE8 File Offset: 0x0038C1E8
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
					this.m_ShowRewardList`1_hotfix = (luaObj.RawGet("ShowReward") as LuaFunction);
					this.m_Co_ShowRewardList`1_hotfix = (luaObj.RawGet("Co_ShowReward") as LuaFunction);
					this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix = (luaObj.RawGet("Co_SetAndWaitUIState") as LuaFunction);
					this.m_Co_WaitClick_hotfix = (luaObj.RawGet("Co_WaitClick") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CF0F RID: 53007 RVA: 0x0038E164 File Offset: 0x0038C364
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetRewardGoodsUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008146 RID: 33094
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04008147 RID: 33095
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x04008148 RID: 33096
		[AutoBind("./Panel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_panelGameObject;

		// Token: 0x04008149 RID: 33097
		[AutoBind("./Panel/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_scrollRect;

		// Token: 0x0400814A RID: 33098
		[AutoBind("./Panel/ScrollView/Viewport/RewardItemGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GridLayoutGroup m_gridLayoutGroup;

		// Token: 0x0400814B RID: 33099
		private bool m_isClick;

		// Token: 0x0400814C RID: 33100
		[DoNotToLua]
		private GetRewardGoodsUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400814D RID: 33101
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400814E RID: 33102
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400814F RID: 33103
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008150 RID: 33104
		private LuaFunction m_ShowRewardList;

		// Token: 0x04008151 RID: 33105
		private LuaFunction m_Co_ShowRewardList;

		// Token: 0x04008152 RID: 33106
		private LuaFunction m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix;

		// Token: 0x04008153 RID: 33107
		private LuaFunction m_Co_WaitClick_hotfix;

		// Token: 0x04008154 RID: 33108
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04008155 RID: 33109
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04008156 RID: 33110
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000BC1 RID: 3009
		public new class LuaExportHelper
		{
			// Token: 0x0600CF10 RID: 53008 RVA: 0x0038E1CC File Offset: 0x0038C3CC
			public LuaExportHelper(GetRewardGoodsUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CF11 RID: 53009 RVA: 0x0038E1DC File Offset: 0x0038C3DC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600CF12 RID: 53010 RVA: 0x0038E1EC File Offset: 0x0038C3EC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600CF13 RID: 53011 RVA: 0x0038E1FC File Offset: 0x0038C3FC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600CF14 RID: 53012 RVA: 0x0038E20C File Offset: 0x0038C40C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600CF15 RID: 53013 RVA: 0x0038E224 File Offset: 0x0038C424
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600CF16 RID: 53014 RVA: 0x0038E234 File Offset: 0x0038C434
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600CF17 RID: 53015 RVA: 0x0038E244 File Offset: 0x0038C444
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600CF18 RID: 53016 RVA: 0x0038E254 File Offset: 0x0038C454
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600CF19 RID: 53017 RVA: 0x0038E264 File Offset: 0x0038C464
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600CF1A RID: 53018 RVA: 0x0038E274 File Offset: 0x0038C474
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600CF1B RID: 53019 RVA: 0x0038E284 File Offset: 0x0038C484
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600CF1C RID: 53020 RVA: 0x0038E294 File Offset: 0x0038C494
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600CF1D RID: 53021 RVA: 0x0038E2A4 File Offset: 0x0038C4A4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600CF1E RID: 53022 RVA: 0x0038E2B4 File Offset: 0x0038C4B4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600CF1F RID: 53023 RVA: 0x0038E2C4 File Offset: 0x0038C4C4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600CF20 RID: 53024 RVA: 0x0038E2D4 File Offset: 0x0038C4D4
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600CF21 RID: 53025 RVA: 0x0038E2E4 File Offset: 0x0038C4E4
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170028E4 RID: 10468
			// (get) Token: 0x0600CF22 RID: 53026 RVA: 0x0038E2F4 File Offset: 0x0038C4F4
			// (set) Token: 0x0600CF23 RID: 53027 RVA: 0x0038E304 File Offset: 0x0038C504
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x170028E5 RID: 10469
			// (get) Token: 0x0600CF24 RID: 53028 RVA: 0x0038E314 File Offset: 0x0038C514
			// (set) Token: 0x0600CF25 RID: 53029 RVA: 0x0038E324 File Offset: 0x0038C524
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x170028E6 RID: 10470
			// (get) Token: 0x0600CF26 RID: 53030 RVA: 0x0038E334 File Offset: 0x0038C534
			// (set) Token: 0x0600CF27 RID: 53031 RVA: 0x0038E344 File Offset: 0x0038C544
			public GameObject m_panelGameObject
			{
				get
				{
					return this.m_owner.m_panelGameObject;
				}
				set
				{
					this.m_owner.m_panelGameObject = value;
				}
			}

			// Token: 0x170028E7 RID: 10471
			// (get) Token: 0x0600CF28 RID: 53032 RVA: 0x0038E354 File Offset: 0x0038C554
			// (set) Token: 0x0600CF29 RID: 53033 RVA: 0x0038E364 File Offset: 0x0038C564
			public ScrollRect m_scrollRect
			{
				get
				{
					return this.m_owner.m_scrollRect;
				}
				set
				{
					this.m_owner.m_scrollRect = value;
				}
			}

			// Token: 0x170028E8 RID: 10472
			// (get) Token: 0x0600CF2A RID: 53034 RVA: 0x0038E374 File Offset: 0x0038C574
			// (set) Token: 0x0600CF2B RID: 53035 RVA: 0x0038E384 File Offset: 0x0038C584
			public GridLayoutGroup m_gridLayoutGroup
			{
				get
				{
					return this.m_owner.m_gridLayoutGroup;
				}
				set
				{
					this.m_owner.m_gridLayoutGroup = value;
				}
			}

			// Token: 0x170028E9 RID: 10473
			// (get) Token: 0x0600CF2C RID: 53036 RVA: 0x0038E394 File Offset: 0x0038C594
			// (set) Token: 0x0600CF2D RID: 53037 RVA: 0x0038E3A4 File Offset: 0x0038C5A4
			public bool m_isClick
			{
				get
				{
					return this.m_owner.m_isClick;
				}
				set
				{
					this.m_owner.m_isClick = value;
				}
			}

			// Token: 0x0600CF2E RID: 53038 RVA: 0x0038E3B4 File Offset: 0x0038C5B4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600CF2F RID: 53039 RVA: 0x0038E3C4 File Offset: 0x0038C5C4
			public IEnumerator Co_ShowReward(List<Goods> goodsList)
			{
				return this.m_owner.Co_ShowReward(goodsList);
			}

			// Token: 0x0600CF30 RID: 53040 RVA: 0x0038E3D4 File Offset: 0x0038C5D4
			public IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
			{
				return this.m_owner.Co_SetAndWaitUIState(ctrl, state);
			}

			// Token: 0x0600CF31 RID: 53041 RVA: 0x0038E3E4 File Offset: 0x0038C5E4
			public IEnumerator Co_WaitClick()
			{
				return this.m_owner.Co_WaitClick();
			}

			// Token: 0x0600CF32 RID: 53042 RVA: 0x0038E3F4 File Offset: 0x0038C5F4
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x04008157 RID: 33111
			private GetRewardGoodsUIController m_owner;
		}
	}
}
