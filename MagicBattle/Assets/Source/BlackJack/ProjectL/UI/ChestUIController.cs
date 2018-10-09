using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B9C RID: 2972
	[HotFix]
	public class ChestUIController : UIControllerBase
	{
		// Token: 0x0600CB94 RID: 52116 RVA: 0x00381384 File Offset: 0x0037F584
		private ChestUIController()
		{
		}

		// Token: 0x0600CB95 RID: 52117 RVA: 0x00381398 File Offset: 0x0037F598
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
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600CB96 RID: 52118 RVA: 0x00381428 File Offset: 0x0037F628
		public void ShowReward(BattleReward reward, bool isFirstWin, bool isAutoOpen)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRewardBattleRewardBooleanBoolean_hotfix != null)
			{
				this.m_ShowRewardBattleRewardBooleanBoolean_hotfix.call(new object[]
				{
					this,
					reward,
					isFirstWin,
					isAutoOpen
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_ShowReward(reward, isFirstWin, isAutoOpen));
		}

		// Token: 0x0600CB97 RID: 52119 RVA: 0x003814C8 File Offset: 0x0037F6C8
		[DebuggerHidden]
		private IEnumerator Co_ShowReward(BattleReward reward, bool isFirstWin, bool isAutoOpen)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowRewardBattleRewardBooleanBoolean_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowRewardBattleRewardBooleanBoolean_hotfix.call(new object[]
				{
					this,
					reward,
					isFirstWin,
					isAutoOpen
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChestUIController.<Co_ShowReward>c__Iterator0 <Co_ShowReward>c__Iterator = new ChestUIController.<Co_ShowReward>c__Iterator0();
			<Co_ShowReward>c__Iterator.reward = reward;
			<Co_ShowReward>c__Iterator.isFirstWin = isFirstWin;
			<Co_ShowReward>c__Iterator.isAutoOpen = isAutoOpen;
			<Co_ShowReward>c__Iterator.$this = this;
			return <Co_ShowReward>c__Iterator;
		}

		// Token: 0x0600CB98 RID: 52120 RVA: 0x00381588 File Offset: 0x0037F788
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
			ChestUIController.<Co_SetAndWaitUIState>c__Iterator1 <Co_SetAndWaitUIState>c__Iterator = new ChestUIController.<Co_SetAndWaitUIState>c__Iterator1();
			<Co_SetAndWaitUIState>c__Iterator.ctrl = ctrl;
			<Co_SetAndWaitUIState>c__Iterator.state = state;
			return <Co_SetAndWaitUIState>c__Iterator;
		}

		// Token: 0x0600CB99 RID: 52121 RVA: 0x0038162C File Offset: 0x0037F82C
		[DebuggerHidden]
		private IEnumerator Co_PlayAndWaitTween(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_PlayAndWaitTweenGameObject_hotfix != null)
			{
				return (IEnumerator)this.m_Co_PlayAndWaitTweenGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChestUIController.<Co_PlayAndWaitTween>c__Iterator2 <Co_PlayAndWaitTween>c__Iterator = new ChestUIController.<Co_PlayAndWaitTween>c__Iterator2();
			<Co_PlayAndWaitTween>c__Iterator.go = go;
			return <Co_PlayAndWaitTween>c__Iterator;
		}

		// Token: 0x0600CB9A RID: 52122 RVA: 0x003816B8 File Offset: 0x0037F8B8
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
			ChestUIController.<Co_WaitClick>c__Iterator3 <Co_WaitClick>c__Iterator = new ChestUIController.<Co_WaitClick>c__Iterator3();
			<Co_WaitClick>c__Iterator.$this = this;
			return <Co_WaitClick>c__Iterator;
		}

		// Token: 0x0600CB9B RID: 52123 RVA: 0x00381734 File Offset: 0x0037F934
		private void CreateGoodsTweenDummy(List<Goods> goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGoodsTweenDummyList`1_hotfix != null)
			{
				this.m_CreateGoodsTweenDummyList`1_hotfix.call(new object[]
				{
					this,
					goods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float x;
			if (goods.Count < 10)
			{
				x = -960f + (float)(1920 - 183 * goods.Count) * 0.5f + 85f;
			}
			else
			{
				x = -830f;
			}
			for (int i = 0; i < goods.Count; i++)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_goodsTweenDummyPrefab);
				gameObject.transform.SetParent(this.m_rewardGoodsGroupGameObject.transform, false);
				RectTransform rectTransform = gameObject.transform as RectTransform;
				rectTransform.anchoredPosition = new Vector2(x, 0f) + new Vector2((float)(183 * (i % 10)), (float)(-183 * (i / 10)));
				TweenPos component = gameObject.GetComponent<TweenPos>();
				component.from = new Vector2(0f, -360f);
				component.to = rectTransform.anchoredPosition;
				component.delay = (float)i * 0.1f;
				TweenCGAlpha component2 = gameObject.GetComponent<TweenCGAlpha>();
				component2.delay = (float)i * 0.1f;
				TweenScale component3 = gameObject.GetComponent<TweenScale>();
				component3.delay = (float)i * 0.1f;
				gameObject.SetActive(true);
			}
		}

		// Token: 0x0600CB9C RID: 52124 RVA: 0x003818D4 File Offset: 0x0037FAD4
		private void ClearGoodsDummyGroup()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearGoodsDummyGroup_hotfix != null)
			{
				this.m_ClearGoodsDummyGroup_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_rewardGoodsGroupGameObject);
		}

		// Token: 0x0600CB9D RID: 52125 RVA: 0x00381940 File Offset: 0x0037FB40
		private void ClearRewardItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearRewardItems_hotfix != null)
			{
				this.m_ClearRewardItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<RewardGoodsUIController>(this.m_rewardGoods);
			this.m_rewardGoods.Clear();
		}

		// Token: 0x0600CB9E RID: 52126 RVA: 0x003819B8 File Offset: 0x0037FBB8
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

		// Token: 0x14000275 RID: 629
		// (add) Token: 0x0600CB9F RID: 52127 RVA: 0x00381A20 File Offset: 0x0037FC20
		// (remove) Token: 0x0600CBA0 RID: 52128 RVA: 0x00381ABC File Offset: 0x0037FCBC
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

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x0600CBA1 RID: 52129 RVA: 0x00381B58 File Offset: 0x0037FD58
		// (set) Token: 0x0600CBA2 RID: 52130 RVA: 0x00381B78 File Offset: 0x0037FD78
		[DoNotToLua]
		public new ChestUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChestUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CBA3 RID: 52131 RVA: 0x00381B84 File Offset: 0x0037FD84
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600CBA4 RID: 52132 RVA: 0x00381B90 File Offset: 0x0037FD90
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600CBA5 RID: 52133 RVA: 0x00381B98 File Offset: 0x0037FD98
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600CBA6 RID: 52134 RVA: 0x00381BA0 File Offset: 0x0037FDA0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600CBA7 RID: 52135 RVA: 0x00381BB4 File Offset: 0x0037FDB4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600CBA8 RID: 52136 RVA: 0x00381BBC File Offset: 0x0037FDBC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600CBA9 RID: 52137 RVA: 0x00381BC8 File Offset: 0x0037FDC8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600CBAA RID: 52138 RVA: 0x00381BD4 File Offset: 0x0037FDD4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600CBAB RID: 52139 RVA: 0x00381BE0 File Offset: 0x0037FDE0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600CBAC RID: 52140 RVA: 0x00381BEC File Offset: 0x0037FDEC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600CBAD RID: 52141 RVA: 0x00381BF8 File Offset: 0x0037FDF8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600CBAE RID: 52142 RVA: 0x00381C04 File Offset: 0x0037FE04
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600CBAF RID: 52143 RVA: 0x00381C10 File Offset: 0x0037FE10
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600CBB0 RID: 52144 RVA: 0x00381C1C File Offset: 0x0037FE1C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600CBB1 RID: 52145 RVA: 0x00381C28 File Offset: 0x0037FE28
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600CBB2 RID: 52146 RVA: 0x00381C30 File Offset: 0x0037FE30
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600CBB3 RID: 52147 RVA: 0x00381C50 File Offset: 0x0037FE50
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600CBB4 RID: 52148 RVA: 0x00381C5C File Offset: 0x0037FE5C
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
					this.m_ShowRewardBattleRewardBooleanBoolean_hotfix = (luaObj.RawGet("ShowReward") as LuaFunction);
					this.m_Co_ShowRewardBattleRewardBooleanBoolean_hotfix = (luaObj.RawGet("Co_ShowReward") as LuaFunction);
					this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix = (luaObj.RawGet("Co_SetAndWaitUIState") as LuaFunction);
					this.m_Co_PlayAndWaitTweenGameObject_hotfix = (luaObj.RawGet("Co_PlayAndWaitTween") as LuaFunction);
					this.m_Co_WaitClick_hotfix = (luaObj.RawGet("Co_WaitClick") as LuaFunction);
					this.m_CreateGoodsTweenDummyList`1_hotfix = (luaObj.RawGet("CreateGoodsTweenDummy") as LuaFunction);
					this.m_ClearGoodsDummyGroup_hotfix = (luaObj.RawGet("ClearGoodsDummyGroup") as LuaFunction);
					this.m_ClearRewardItems_hotfix = (luaObj.RawGet("ClearRewardItems") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CBB5 RID: 52149 RVA: 0x00381E3C File Offset: 0x0038003C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChestUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007FCF RID: 32719
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x04007FD0 RID: 32720
		[AutoBind("./ChestObject", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_chestGameObject;

		// Token: 0x04007FD1 RID: 32721
		[AutoBind("./ChestObject/Chest", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_chestUIStateController;

		// Token: 0x04007FD2 RID: 32722
		[AutoBind("./FirstWin", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_firstWinGameObject;

		// Token: 0x04007FD3 RID: 32723
		[AutoBind("./RewardGoodsGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGoodsGroupGameObject;

		// Token: 0x04007FD4 RID: 32724
		[AutoBind("./TeamRewardInfo", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_teamRewardUIStateController;

		// Token: 0x04007FD5 RID: 32725
		[AutoBind("./TeamRewardInfo/Detail/RewardGroup/Friendship", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teamRewardFriendshipGameObject;

		// Token: 0x04007FD6 RID: 32726
		[AutoBind("./TeamRewardInfo/Detail/RewardGroup/Friendship/ValuGroup/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_teamRewardFriendshipValueText;

		// Token: 0x04007FD7 RID: 32727
		[AutoBind("./TeamRewardInfo/Detail/RewardGroup/Team", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teamRewardTeamGameObject;

		// Token: 0x04007FD8 RID: 32728
		[AutoBind("./TeamRewardInfo/Detail/RewardGroup/Team/ValuGroup/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_teamRewardTeamValueText;

		// Token: 0x04007FD9 RID: 32729
		[AutoBind("./TeamRewardInfo/Detail/RewardGroup/Friend", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teamRewardFriendGameObject;

		// Token: 0x04007FDA RID: 32730
		[AutoBind("./TeamRewardInfo/Detail/RewardGroup/Friend/ValuGroup/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_teamRewardFriendValueText;

		// Token: 0x04007FDB RID: 32731
		[AutoBind("./DailyRewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_dailyRewardUIStateController;

		// Token: 0x04007FDC RID: 32732
		[AutoBind("./ClickScreenContinue", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_clickScreenContinueGameObject;

		// Token: 0x04007FDD RID: 32733
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04007FDE RID: 32734
		[AutoBind("./Prefabs/GoodsTweenDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_goodsTweenDummyPrefab;

		// Token: 0x04007FDF RID: 32735
		private List<RewardGoodsUIController> m_rewardGoods = new List<RewardGoodsUIController>();

		// Token: 0x04007FE0 RID: 32736
		private bool m_isClick;

		// Token: 0x04007FE1 RID: 32737
		[DoNotToLua]
		private ChestUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007FE2 RID: 32738
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007FE3 RID: 32739
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007FE4 RID: 32740
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007FE5 RID: 32741
		private LuaFunction m_ShowRewardBattleRewardBooleanBoolean_hotfix;

		// Token: 0x04007FE6 RID: 32742
		private LuaFunction m_Co_ShowRewardBattleRewardBooleanBoolean_hotfix;

		// Token: 0x04007FE7 RID: 32743
		private LuaFunction m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix;

		// Token: 0x04007FE8 RID: 32744
		private LuaFunction m_Co_PlayAndWaitTweenGameObject_hotfix;

		// Token: 0x04007FE9 RID: 32745
		private LuaFunction m_Co_WaitClick_hotfix;

		// Token: 0x04007FEA RID: 32746
		private LuaFunction m_CreateGoodsTweenDummyList;

		// Token: 0x04007FEB RID: 32747
		private LuaFunction m_ClearGoodsDummyGroup_hotfix;

		// Token: 0x04007FEC RID: 32748
		private LuaFunction m_ClearRewardItems_hotfix;

		// Token: 0x04007FED RID: 32749
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04007FEE RID: 32750
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04007FEF RID: 32751
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000B9D RID: 2973
		public new class LuaExportHelper
		{
			// Token: 0x0600CBB6 RID: 52150 RVA: 0x00381EA4 File Offset: 0x003800A4
			public LuaExportHelper(ChestUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CBB7 RID: 52151 RVA: 0x00381EB4 File Offset: 0x003800B4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600CBB8 RID: 52152 RVA: 0x00381EC4 File Offset: 0x003800C4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600CBB9 RID: 52153 RVA: 0x00381ED4 File Offset: 0x003800D4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600CBBA RID: 52154 RVA: 0x00381EE4 File Offset: 0x003800E4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600CBBB RID: 52155 RVA: 0x00381EFC File Offset: 0x003800FC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600CBBC RID: 52156 RVA: 0x00381F0C File Offset: 0x0038010C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600CBBD RID: 52157 RVA: 0x00381F1C File Offset: 0x0038011C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600CBBE RID: 52158 RVA: 0x00381F2C File Offset: 0x0038012C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600CBBF RID: 52159 RVA: 0x00381F3C File Offset: 0x0038013C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600CBC0 RID: 52160 RVA: 0x00381F4C File Offset: 0x0038014C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600CBC1 RID: 52161 RVA: 0x00381F5C File Offset: 0x0038015C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600CBC2 RID: 52162 RVA: 0x00381F6C File Offset: 0x0038016C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600CBC3 RID: 52163 RVA: 0x00381F7C File Offset: 0x0038017C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600CBC4 RID: 52164 RVA: 0x00381F8C File Offset: 0x0038018C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600CBC5 RID: 52165 RVA: 0x00381F9C File Offset: 0x0038019C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600CBC6 RID: 52166 RVA: 0x00381FAC File Offset: 0x003801AC
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600CBC7 RID: 52167 RVA: 0x00381FBC File Offset: 0x003801BC
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002851 RID: 10321
			// (get) Token: 0x0600CBC8 RID: 52168 RVA: 0x00381FCC File Offset: 0x003801CC
			// (set) Token: 0x0600CBC9 RID: 52169 RVA: 0x00381FDC File Offset: 0x003801DC
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

			// Token: 0x17002852 RID: 10322
			// (get) Token: 0x0600CBCA RID: 52170 RVA: 0x00381FEC File Offset: 0x003801EC
			// (set) Token: 0x0600CBCB RID: 52171 RVA: 0x00381FFC File Offset: 0x003801FC
			public GameObject m_chestGameObject
			{
				get
				{
					return this.m_owner.m_chestGameObject;
				}
				set
				{
					this.m_owner.m_chestGameObject = value;
				}
			}

			// Token: 0x17002853 RID: 10323
			// (get) Token: 0x0600CBCC RID: 52172 RVA: 0x0038200C File Offset: 0x0038020C
			// (set) Token: 0x0600CBCD RID: 52173 RVA: 0x0038201C File Offset: 0x0038021C
			public CommonUIStateController m_chestUIStateController
			{
				get
				{
					return this.m_owner.m_chestUIStateController;
				}
				set
				{
					this.m_owner.m_chestUIStateController = value;
				}
			}

			// Token: 0x17002854 RID: 10324
			// (get) Token: 0x0600CBCE RID: 52174 RVA: 0x0038202C File Offset: 0x0038022C
			// (set) Token: 0x0600CBCF RID: 52175 RVA: 0x0038203C File Offset: 0x0038023C
			public GameObject m_firstWinGameObject
			{
				get
				{
					return this.m_owner.m_firstWinGameObject;
				}
				set
				{
					this.m_owner.m_firstWinGameObject = value;
				}
			}

			// Token: 0x17002855 RID: 10325
			// (get) Token: 0x0600CBD0 RID: 52176 RVA: 0x0038204C File Offset: 0x0038024C
			// (set) Token: 0x0600CBD1 RID: 52177 RVA: 0x0038205C File Offset: 0x0038025C
			public GameObject m_rewardGoodsGroupGameObject
			{
				get
				{
					return this.m_owner.m_rewardGoodsGroupGameObject;
				}
				set
				{
					this.m_owner.m_rewardGoodsGroupGameObject = value;
				}
			}

			// Token: 0x17002856 RID: 10326
			// (get) Token: 0x0600CBD2 RID: 52178 RVA: 0x0038206C File Offset: 0x0038026C
			// (set) Token: 0x0600CBD3 RID: 52179 RVA: 0x0038207C File Offset: 0x0038027C
			public CommonUIStateController m_teamRewardUIStateController
			{
				get
				{
					return this.m_owner.m_teamRewardUIStateController;
				}
				set
				{
					this.m_owner.m_teamRewardUIStateController = value;
				}
			}

			// Token: 0x17002857 RID: 10327
			// (get) Token: 0x0600CBD4 RID: 52180 RVA: 0x0038208C File Offset: 0x0038028C
			// (set) Token: 0x0600CBD5 RID: 52181 RVA: 0x0038209C File Offset: 0x0038029C
			public GameObject m_teamRewardFriendshipGameObject
			{
				get
				{
					return this.m_owner.m_teamRewardFriendshipGameObject;
				}
				set
				{
					this.m_owner.m_teamRewardFriendshipGameObject = value;
				}
			}

			// Token: 0x17002858 RID: 10328
			// (get) Token: 0x0600CBD6 RID: 52182 RVA: 0x003820AC File Offset: 0x003802AC
			// (set) Token: 0x0600CBD7 RID: 52183 RVA: 0x003820BC File Offset: 0x003802BC
			public Text m_teamRewardFriendshipValueText
			{
				get
				{
					return this.m_owner.m_teamRewardFriendshipValueText;
				}
				set
				{
					this.m_owner.m_teamRewardFriendshipValueText = value;
				}
			}

			// Token: 0x17002859 RID: 10329
			// (get) Token: 0x0600CBD8 RID: 52184 RVA: 0x003820CC File Offset: 0x003802CC
			// (set) Token: 0x0600CBD9 RID: 52185 RVA: 0x003820DC File Offset: 0x003802DC
			public GameObject m_teamRewardTeamGameObject
			{
				get
				{
					return this.m_owner.m_teamRewardTeamGameObject;
				}
				set
				{
					this.m_owner.m_teamRewardTeamGameObject = value;
				}
			}

			// Token: 0x1700285A RID: 10330
			// (get) Token: 0x0600CBDA RID: 52186 RVA: 0x003820EC File Offset: 0x003802EC
			// (set) Token: 0x0600CBDB RID: 52187 RVA: 0x003820FC File Offset: 0x003802FC
			public Text m_teamRewardTeamValueText
			{
				get
				{
					return this.m_owner.m_teamRewardTeamValueText;
				}
				set
				{
					this.m_owner.m_teamRewardTeamValueText = value;
				}
			}

			// Token: 0x1700285B RID: 10331
			// (get) Token: 0x0600CBDC RID: 52188 RVA: 0x0038210C File Offset: 0x0038030C
			// (set) Token: 0x0600CBDD RID: 52189 RVA: 0x0038211C File Offset: 0x0038031C
			public GameObject m_teamRewardFriendGameObject
			{
				get
				{
					return this.m_owner.m_teamRewardFriendGameObject;
				}
				set
				{
					this.m_owner.m_teamRewardFriendGameObject = value;
				}
			}

			// Token: 0x1700285C RID: 10332
			// (get) Token: 0x0600CBDE RID: 52190 RVA: 0x0038212C File Offset: 0x0038032C
			// (set) Token: 0x0600CBDF RID: 52191 RVA: 0x0038213C File Offset: 0x0038033C
			public Text m_teamRewardFriendValueText
			{
				get
				{
					return this.m_owner.m_teamRewardFriendValueText;
				}
				set
				{
					this.m_owner.m_teamRewardFriendValueText = value;
				}
			}

			// Token: 0x1700285D RID: 10333
			// (get) Token: 0x0600CBE0 RID: 52192 RVA: 0x0038214C File Offset: 0x0038034C
			// (set) Token: 0x0600CBE1 RID: 52193 RVA: 0x0038215C File Offset: 0x0038035C
			public CommonUIStateController m_dailyRewardUIStateController
			{
				get
				{
					return this.m_owner.m_dailyRewardUIStateController;
				}
				set
				{
					this.m_owner.m_dailyRewardUIStateController = value;
				}
			}

			// Token: 0x1700285E RID: 10334
			// (get) Token: 0x0600CBE2 RID: 52194 RVA: 0x0038216C File Offset: 0x0038036C
			// (set) Token: 0x0600CBE3 RID: 52195 RVA: 0x0038217C File Offset: 0x0038037C
			public GameObject m_clickScreenContinueGameObject
			{
				get
				{
					return this.m_owner.m_clickScreenContinueGameObject;
				}
				set
				{
					this.m_owner.m_clickScreenContinueGameObject = value;
				}
			}

			// Token: 0x1700285F RID: 10335
			// (get) Token: 0x0600CBE4 RID: 52196 RVA: 0x0038218C File Offset: 0x0038038C
			// (set) Token: 0x0600CBE5 RID: 52197 RVA: 0x0038219C File Offset: 0x0038039C
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x17002860 RID: 10336
			// (get) Token: 0x0600CBE6 RID: 52198 RVA: 0x003821AC File Offset: 0x003803AC
			// (set) Token: 0x0600CBE7 RID: 52199 RVA: 0x003821BC File Offset: 0x003803BC
			public GameObject m_goodsTweenDummyPrefab
			{
				get
				{
					return this.m_owner.m_goodsTweenDummyPrefab;
				}
				set
				{
					this.m_owner.m_goodsTweenDummyPrefab = value;
				}
			}

			// Token: 0x17002861 RID: 10337
			// (get) Token: 0x0600CBE8 RID: 52200 RVA: 0x003821CC File Offset: 0x003803CC
			// (set) Token: 0x0600CBE9 RID: 52201 RVA: 0x003821DC File Offset: 0x003803DC
			public List<RewardGoodsUIController> m_rewardGoods
			{
				get
				{
					return this.m_owner.m_rewardGoods;
				}
				set
				{
					this.m_owner.m_rewardGoods = value;
				}
			}

			// Token: 0x17002862 RID: 10338
			// (get) Token: 0x0600CBEA RID: 52202 RVA: 0x003821EC File Offset: 0x003803EC
			// (set) Token: 0x0600CBEB RID: 52203 RVA: 0x003821FC File Offset: 0x003803FC
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

			// Token: 0x0600CBEC RID: 52204 RVA: 0x0038220C File Offset: 0x0038040C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600CBED RID: 52205 RVA: 0x0038221C File Offset: 0x0038041C
			public IEnumerator Co_ShowReward(BattleReward reward, bool isFirstWin, bool isAutoOpen)
			{
				return this.m_owner.Co_ShowReward(reward, isFirstWin, isAutoOpen);
			}

			// Token: 0x0600CBEE RID: 52206 RVA: 0x0038222C File Offset: 0x0038042C
			public IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
			{
				return this.m_owner.Co_SetAndWaitUIState(ctrl, state);
			}

			// Token: 0x0600CBEF RID: 52207 RVA: 0x0038223C File Offset: 0x0038043C
			public IEnumerator Co_PlayAndWaitTween(GameObject go)
			{
				return this.m_owner.Co_PlayAndWaitTween(go);
			}

			// Token: 0x0600CBF0 RID: 52208 RVA: 0x0038224C File Offset: 0x0038044C
			public IEnumerator Co_WaitClick()
			{
				return this.m_owner.Co_WaitClick();
			}

			// Token: 0x0600CBF1 RID: 52209 RVA: 0x0038225C File Offset: 0x0038045C
			public void CreateGoodsTweenDummy(List<Goods> goods)
			{
				this.m_owner.CreateGoodsTweenDummy(goods);
			}

			// Token: 0x0600CBF2 RID: 52210 RVA: 0x0038226C File Offset: 0x0038046C
			public void ClearGoodsDummyGroup()
			{
				this.m_owner.ClearGoodsDummyGroup();
			}

			// Token: 0x0600CBF3 RID: 52211 RVA: 0x0038227C File Offset: 0x0038047C
			public void ClearRewardItems()
			{
				this.m_owner.ClearRewardItems();
			}

			// Token: 0x0600CBF4 RID: 52212 RVA: 0x0038228C File Offset: 0x0038048C
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x04007FF0 RID: 32752
			private ChestUIController m_owner;
		}
	}
}
