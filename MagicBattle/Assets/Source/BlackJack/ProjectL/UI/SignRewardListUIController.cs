using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
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
	// Token: 0x02000F10 RID: 3856
	[HotFix]
	public class SignRewardListUIController : UIControllerBase
	{
		// Token: 0x060131BC RID: 78268 RVA: 0x004DF670 File Offset: 0x004DD870
		public void EnableCloseButton(bool bEnable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableCloseButtonBoolean_hotfix != null)
			{
				this.m_EnableCloseButtonBoolean_hotfix.call(new object[]
				{
					this,
					bEnable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_bgButton.enabled = bEnable;
			this.m_closeButton.enabled = bEnable;
		}

		// Token: 0x060131BD RID: 78269 RVA: 0x004DF6F8 File Offset: 0x004DD8F8
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
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_closeButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_showBoxRewardPanelBGButton.onClick.AddListener(new UnityAction(this.CloseBoxRewardShowPanel));
		}

		// Token: 0x060131BE RID: 78270 RVA: 0x004DF7B4 File Offset: 0x004DD9B4
		public void SetSignDays()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSignDays_hotfix != null)
			{
				this.m_SetSignDays_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_signDaysMonthText.text = this.m_playerContext.GetSignDaysMonth().ToString();
		}

		// Token: 0x060131BF RID: 78271 RVA: 0x004DF838 File Offset: 0x004DDA38
		public void InitSignRewardItem()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSignRewardItem_hotfix != null)
			{
				this.m_InitSignRewardItem_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int childCount = this.m_scrollViewSignRewardItemContent.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				this.m_scrollViewSignRewardItemContent.transform.GetChild(i).gameObject.SetActive(false);
			}
			this.m_signRewardItemCtrlList.Clear();
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("SignRewardItem");
			List<Goods> signRewardMonthList = this.m_playerContext.GetSignRewardMonthList(this.m_playerContext.GetServerTime().Month);
			int count = signRewardMonthList.Count;
			for (int j = 0; j < count; j++)
			{
				Goods reward = signRewardMonthList[j];
				SignRewardItemUIController component;
				if (j >= childCount)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					component = gameObject.GetComponent<SignRewardItemUIController>();
					component.EventOnSignTodayItemClick += this.OnSignItemClick;
					component.EventOnSignTodayBoxOpenClick += this.OnSignBoxClick;
					component.EventOnShowBoxRewards += this.ShowBoxRewards;
					gameObject.transform.SetParent(this.m_scrollViewSignRewardItemContent.transform, false);
				}
				else
				{
					component = this.m_scrollViewSignRewardItemContent.transform.GetChild(j).gameObject.GetComponent<SignRewardItemUIController>();
				}
				int day = j + 1;
				component.SetReward(reward);
				component.SetDay(day);
				component.transform.SetParent(this.m_scrollViewSignRewardItemContent.transform, false);
				component.gameObject.SetActive(true);
				this.m_signRewardItemCtrlList.Add(component);
			}
		}

		// Token: 0x060131C0 RID: 78272 RVA: 0x004DFA1C File Offset: 0x004DDC1C
		public void PlaySignAnimation(Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySignAnimationAction_hotfix != null)
			{
				this.m_PlaySignAnimationAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SignRewardItemUIController signRewardItemUIController = this.m_signRewardItemCtrlList[this.m_playerContext.GetSignDaysMonth() - 1];
			signRewardItemUIController.PlaySignAnimation(onEnd);
		}

		// Token: 0x060131C1 RID: 78273 RVA: 0x004DFAAC File Offset: 0x004DDCAC
		public void AutoSign()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoSign_hotfix != null)
			{
				this.m_AutoSign_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.TodayIsSigned())
			{
				this.EnableCloseButton(false);
				SignRewardItemUIController signRewardItemUIController = this.m_signRewardItemCtrlList[Math.Min(this.m_signRewardItemCtrlList.Count - 1, this.m_playerContext.GetSignDaysMonth())];
				signRewardItemUIController.TodayAutoSign();
			}
		}

		// Token: 0x060131C2 RID: 78274 RVA: 0x004DFB54 File Offset: 0x004DDD54
		public void SignOpenTween(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SignOpenTweenAction_hotfix != null)
			{
				this.m_SignOpenTweenAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_signUIStateCtrl, "Show", null, false, true);
		}

		// Token: 0x060131C3 RID: 78275 RVA: 0x004DFBD8 File Offset: 0x004DDDD8
		public void ShowBoxRewards(List<Goods> items, SignRewardItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBoxRewardsList`1SignRewardItemUIController_hotfix != null)
			{
				this.m_ShowBoxRewardsList`1SignRewardItemUIController_hotfix.call(new object[]
				{
					this,
					items,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_boxIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(ctrl.GetGoodsType(), ctrl.GetGoodsId()));
			this.m_boxCountText.text = ctrl.GetGoodsCount().ToString();
			this.m_boxNameText.text = UIUtility.GetGoodsName(ctrl.GetGoodsType(), ctrl.GetGoodsId());
			this.m_boxHaveCountText.text = UIUtility.GetGoodsCount(ctrl.GetGoodsType(), ctrl.GetGoodsId()).ToString();
			this.m_boxDescText.text = UIUtility.GetGoodsDesc(ctrl.GetGoodsType(), ctrl.GetGoodsId());
			GameObjectUtility.DestroyChildren(this.m_boxRewardScrollViewObj);
			if (items != null)
			{
				foreach (Goods good in items)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_signBoxItemPrefab);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					BoxItemInfoUIController component = gameObject.GetComponent<BoxItemInfoUIController>();
					component.SetBoxItemInfo(good, false);
					gameObject.transform.SetParent(this.m_boxRewardScrollViewObj.transform, false);
				}
			}
			UIUtility.SetUIStateOpen(this.m_showBoxRewardPanelUIStateController, "Show", null, false, true);
		}

		// Token: 0x060131C4 RID: 78276 RVA: 0x004DFDA8 File Offset: 0x004DDFA8
		private void CloseBoxRewardShowPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseBoxRewardShowPanel_hotfix != null)
			{
				this.m_CloseBoxRewardShowPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_showBoxRewardPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x060131C5 RID: 78277 RVA: 0x004DFE1C File Offset: 0x004DE01C
		private void OnCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseButtonClick_hotfix != null)
			{
				this.m_OnCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_signUIStateCtrl, "Close", delegate
			{
				if (this.EventOnSignCloseButtonClick != null)
				{
					this.EventOnSignCloseButtonClick();
				}
			}, false, true);
		}

		// Token: 0x060131C6 RID: 78278 RVA: 0x004DFE9C File Offset: 0x004DE09C
		private void OnSignItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSignItemClick_hotfix != null)
			{
				this.m_OnSignItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSignTodayListClick != null)
			{
				this.EventOnSignTodayListClick();
			}
		}

		// Token: 0x060131C7 RID: 78279 RVA: 0x004DFF14 File Offset: 0x004DE114
		private void OnSignBoxClick(GoodsType type, int id, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSignBoxClickGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_OnSignBoxClickGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					type,
					id,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSignTodayBoxListClick != null)
			{
				this.EventOnSignTodayBoxListClick(type, id, count);
			}
		}

		// Token: 0x14000426 RID: 1062
		// (add) Token: 0x060131C8 RID: 78280 RVA: 0x004DFFC0 File Offset: 0x004DE1C0
		// (remove) Token: 0x060131C9 RID: 78281 RVA: 0x004E005C File Offset: 0x004DE25C
		public event Action EventOnSignTodayListClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSignTodayListClickAction_hotfix != null)
				{
					this.m_add_EventOnSignTodayListClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSignTodayListClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSignTodayListClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSignTodayListClickAction_hotfix != null)
				{
					this.m_remove_EventOnSignTodayListClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSignTodayListClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSignTodayListClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000427 RID: 1063
		// (add) Token: 0x060131CA RID: 78282 RVA: 0x004E00F8 File Offset: 0x004DE2F8
		// (remove) Token: 0x060131CB RID: 78283 RVA: 0x004E0194 File Offset: 0x004DE394
		public event Action<GoodsType, int, int> EventOnSignTodayBoxListClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSignTodayBoxListClickAction`3_hotfix != null)
				{
					this.m_add_EventOnSignTodayBoxListClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnSignTodayBoxListClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnSignTodayBoxListClick, (Action<GoodsType, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSignTodayBoxListClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnSignTodayBoxListClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnSignTodayBoxListClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnSignTodayBoxListClick, (Action<GoodsType, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000428 RID: 1064
		// (add) Token: 0x060131CC RID: 78284 RVA: 0x004E0230 File Offset: 0x004DE430
		// (remove) Token: 0x060131CD RID: 78285 RVA: 0x004E02CC File Offset: 0x004DE4CC
		public event Action EventOnSignCloseButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSignCloseButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnSignCloseButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSignCloseButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSignCloseButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSignCloseButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnSignCloseButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSignCloseButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSignCloseButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x060131CE RID: 78286 RVA: 0x004E0368 File Offset: 0x004DE568
		// (set) Token: 0x060131CF RID: 78287 RVA: 0x004E0388 File Offset: 0x004DE588
		[DoNotToLua]
		public new SignRewardListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SignRewardListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060131D0 RID: 78288 RVA: 0x004E0394 File Offset: 0x004DE594
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060131D1 RID: 78289 RVA: 0x004E03A0 File Offset: 0x004DE5A0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060131D2 RID: 78290 RVA: 0x004E03A8 File Offset: 0x004DE5A8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060131D3 RID: 78291 RVA: 0x004E03B0 File Offset: 0x004DE5B0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060131D4 RID: 78292 RVA: 0x004E03C4 File Offset: 0x004DE5C4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060131D5 RID: 78293 RVA: 0x004E03CC File Offset: 0x004DE5CC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060131D6 RID: 78294 RVA: 0x004E03D8 File Offset: 0x004DE5D8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060131D7 RID: 78295 RVA: 0x004E03E4 File Offset: 0x004DE5E4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060131D8 RID: 78296 RVA: 0x004E03F0 File Offset: 0x004DE5F0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060131D9 RID: 78297 RVA: 0x004E03FC File Offset: 0x004DE5FC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060131DA RID: 78298 RVA: 0x004E0408 File Offset: 0x004DE608
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060131DB RID: 78299 RVA: 0x004E0414 File Offset: 0x004DE614
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060131DC RID: 78300 RVA: 0x004E0420 File Offset: 0x004DE620
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060131DD RID: 78301 RVA: 0x004E042C File Offset: 0x004DE62C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060131DE RID: 78302 RVA: 0x004E0438 File Offset: 0x004DE638
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060131DF RID: 78303 RVA: 0x004E0440 File Offset: 0x004DE640
		private void __callDele_EventOnSignTodayListClick()
		{
			Action eventOnSignTodayListClick = this.EventOnSignTodayListClick;
			if (eventOnSignTodayListClick != null)
			{
				eventOnSignTodayListClick();
			}
		}

		// Token: 0x060131E0 RID: 78304 RVA: 0x004E0460 File Offset: 0x004DE660
		private void __clearDele_EventOnSignTodayListClick()
		{
			this.EventOnSignTodayListClick = null;
		}

		// Token: 0x060131E1 RID: 78305 RVA: 0x004E046C File Offset: 0x004DE66C
		private void __callDele_EventOnSignTodayBoxListClick(GoodsType arg1, int arg2, int arg3)
		{
			Action<GoodsType, int, int> eventOnSignTodayBoxListClick = this.EventOnSignTodayBoxListClick;
			if (eventOnSignTodayBoxListClick != null)
			{
				eventOnSignTodayBoxListClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x060131E2 RID: 78306 RVA: 0x004E0490 File Offset: 0x004DE690
		private void __clearDele_EventOnSignTodayBoxListClick(GoodsType arg1, int arg2, int arg3)
		{
			this.EventOnSignTodayBoxListClick = null;
		}

		// Token: 0x060131E3 RID: 78307 RVA: 0x004E049C File Offset: 0x004DE69C
		private void __callDele_EventOnSignCloseButtonClick()
		{
			Action eventOnSignCloseButtonClick = this.EventOnSignCloseButtonClick;
			if (eventOnSignCloseButtonClick != null)
			{
				eventOnSignCloseButtonClick();
			}
		}

		// Token: 0x060131E4 RID: 78308 RVA: 0x004E04BC File Offset: 0x004DE6BC
		private void __clearDele_EventOnSignCloseButtonClick()
		{
			this.EventOnSignCloseButtonClick = null;
		}

		// Token: 0x060131E6 RID: 78310 RVA: 0x004E04E0 File Offset: 0x004DE6E0
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
					this.m_EnableCloseButtonBoolean_hotfix = (luaObj.RawGet("EnableCloseButton") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_SetSignDays_hotfix = (luaObj.RawGet("SetSignDays") as LuaFunction);
					this.m_InitSignRewardItem_hotfix = (luaObj.RawGet("InitSignRewardItem") as LuaFunction);
					this.m_PlaySignAnimationAction_hotfix = (luaObj.RawGet("PlaySignAnimation") as LuaFunction);
					this.m_AutoSign_hotfix = (luaObj.RawGet("AutoSign") as LuaFunction);
					this.m_SignOpenTweenAction_hotfix = (luaObj.RawGet("SignOpenTween") as LuaFunction);
					this.m_ShowBoxRewardsList`1SignRewardItemUIController_hotfix = (luaObj.RawGet("ShowBoxRewards") as LuaFunction);
					this.m_CloseBoxRewardShowPanel_hotfix = (luaObj.RawGet("CloseBoxRewardShowPanel") as LuaFunction);
					this.m_OnCloseButtonClick_hotfix = (luaObj.RawGet("OnCloseButtonClick") as LuaFunction);
					this.m_OnSignItemClick_hotfix = (luaObj.RawGet("OnSignItemClick") as LuaFunction);
					this.m_OnSignBoxClickGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("OnSignBoxClick") as LuaFunction);
					this.m_add_EventOnSignTodayListClickAction_hotfix = (luaObj.RawGet("add_EventOnSignTodayListClick") as LuaFunction);
					this.m_remove_EventOnSignTodayListClickAction_hotfix = (luaObj.RawGet("remove_EventOnSignTodayListClick") as LuaFunction);
					this.m_add_EventOnSignTodayBoxListClickAction`3_hotfix = (luaObj.RawGet("add_EventOnSignTodayBoxListClick") as LuaFunction);
					this.m_remove_EventOnSignTodayBoxListClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnSignTodayBoxListClick") as LuaFunction);
					this.m_add_EventOnSignCloseButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnSignCloseButtonClick") as LuaFunction);
					this.m_remove_EventOnSignCloseButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnSignCloseButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060131E7 RID: 78311 RVA: 0x004E0754 File Offset: 0x004DE954
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SignRewardListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AA4A RID: 43594
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_signUIStateCtrl;

		// Token: 0x0400AA4B RID: 43595
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x0400AA4C RID: 43596
		[AutoBind("./RewardList/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeButton;

		// Token: 0x0400AA4D RID: 43597
		[AutoBind("./RewardList/RewardListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scrollViewSignRewardItemContent;

		// Token: 0x0400AA4E RID: 43598
		[AutoBind("./RewardList/SignDaysMonth/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_signDaysMonthText;

		// Token: 0x0400AA4F RID: 43599
		[AutoBind("./ShowBoxRewardPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_showBoxRewardPanelUIStateController;

		// Token: 0x0400AA50 RID: 43600
		[AutoBind("./ShowBoxRewardPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_showBoxRewardPanelBGButton;

		// Token: 0x0400AA51 RID: 43601
		[AutoBind("./ShowBoxRewardPanel/LayoutRoot/ListPanel/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_boxRewardScrollViewObj;

		// Token: 0x0400AA52 RID: 43602
		[AutoBind("./ShowBoxRewardPanel/LayoutRoot/BoxGoodsDesc/Item/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_boxIconImage;

		// Token: 0x0400AA53 RID: 43603
		[AutoBind("./ShowBoxRewardPanel/LayoutRoot/BoxGoodsDesc/Item/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_boxCountText;

		// Token: 0x0400AA54 RID: 43604
		[AutoBind("./ShowBoxRewardPanel/LayoutRoot/BoxGoodsDesc/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_boxNameText;

		// Token: 0x0400AA55 RID: 43605
		[AutoBind("./ShowBoxRewardPanel/LayoutRoot/BoxGoodsDesc/HaveCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_boxHaveCountText;

		// Token: 0x0400AA56 RID: 43606
		[AutoBind("./ShowBoxRewardPanel/LayoutRoot/BoxGoodsDesc/DescPanel/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_boxDescText;

		// Token: 0x0400AA57 RID: 43607
		[AutoBind("./Prefabs/BoxItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_signBoxItemPrefab;

		// Token: 0x0400AA58 RID: 43608
		private List<SignRewardItemUIController> m_signRewardItemCtrlList = new List<SignRewardItemUIController>();

		// Token: 0x0400AA59 RID: 43609
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400AA5A RID: 43610
		[DoNotToLua]
		private SignRewardListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AA5B RID: 43611
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AA5C RID: 43612
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AA5D RID: 43613
		private LuaFunction m_EnableCloseButtonBoolean_hotfix;

		// Token: 0x0400AA5E RID: 43614
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AA5F RID: 43615
		private LuaFunction m_SetSignDays_hotfix;

		// Token: 0x0400AA60 RID: 43616
		private LuaFunction m_InitSignRewardItem_hotfix;

		// Token: 0x0400AA61 RID: 43617
		private LuaFunction m_PlaySignAnimationAction_hotfix;

		// Token: 0x0400AA62 RID: 43618
		private LuaFunction m_AutoSign_hotfix;

		// Token: 0x0400AA63 RID: 43619
		private LuaFunction m_SignOpenTweenAction_hotfix;

		// Token: 0x0400AA64 RID: 43620
		private LuaFunction m_ShowBoxRewardsList;

		// Token: 0x0400AA65 RID: 43621
		private LuaFunction m_CloseBoxRewardShowPanel_hotfix;

		// Token: 0x0400AA66 RID: 43622
		private LuaFunction m_OnCloseButtonClick_hotfix;

		// Token: 0x0400AA67 RID: 43623
		private LuaFunction m_OnSignItemClick_hotfix;

		// Token: 0x0400AA68 RID: 43624
		private LuaFunction m_OnSignBoxClickGoodsTypeInt32Int32_hotfix;

		// Token: 0x0400AA69 RID: 43625
		private LuaFunction m_add_EventOnSignTodayListClickAction_hotfix;

		// Token: 0x0400AA6A RID: 43626
		private LuaFunction m_remove_EventOnSignTodayListClickAction_hotfix;

		// Token: 0x0400AA6B RID: 43627
		private LuaFunction m_add_EventOnSignTodayBoxListClickAction;

		// Token: 0x0400AA6C RID: 43628
		private LuaFunction m_remove_EventOnSignTodayBoxListClickAction;

		// Token: 0x0400AA6D RID: 43629
		private LuaFunction m_add_EventOnSignCloseButtonClickAction_hotfix;

		// Token: 0x0400AA6E RID: 43630
		private LuaFunction m_remove_EventOnSignCloseButtonClickAction_hotfix;

		// Token: 0x02000F11 RID: 3857
		public new class LuaExportHelper
		{
			// Token: 0x060131E8 RID: 78312 RVA: 0x004E07BC File Offset: 0x004DE9BC
			public LuaExportHelper(SignRewardListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060131E9 RID: 78313 RVA: 0x004E07CC File Offset: 0x004DE9CC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060131EA RID: 78314 RVA: 0x004E07DC File Offset: 0x004DE9DC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060131EB RID: 78315 RVA: 0x004E07EC File Offset: 0x004DE9EC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060131EC RID: 78316 RVA: 0x004E07FC File Offset: 0x004DE9FC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060131ED RID: 78317 RVA: 0x004E0814 File Offset: 0x004DEA14
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060131EE RID: 78318 RVA: 0x004E0824 File Offset: 0x004DEA24
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060131EF RID: 78319 RVA: 0x004E0834 File Offset: 0x004DEA34
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060131F0 RID: 78320 RVA: 0x004E0844 File Offset: 0x004DEA44
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060131F1 RID: 78321 RVA: 0x004E0854 File Offset: 0x004DEA54
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060131F2 RID: 78322 RVA: 0x004E0864 File Offset: 0x004DEA64
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060131F3 RID: 78323 RVA: 0x004E0874 File Offset: 0x004DEA74
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060131F4 RID: 78324 RVA: 0x004E0884 File Offset: 0x004DEA84
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060131F5 RID: 78325 RVA: 0x004E0894 File Offset: 0x004DEA94
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060131F6 RID: 78326 RVA: 0x004E08A4 File Offset: 0x004DEAA4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060131F7 RID: 78327 RVA: 0x004E08B4 File Offset: 0x004DEAB4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060131F8 RID: 78328 RVA: 0x004E08C4 File Offset: 0x004DEAC4
			public void __callDele_EventOnSignTodayListClick()
			{
				this.m_owner.__callDele_EventOnSignTodayListClick();
			}

			// Token: 0x060131F9 RID: 78329 RVA: 0x004E08D4 File Offset: 0x004DEAD4
			public void __clearDele_EventOnSignTodayListClick()
			{
				this.m_owner.__clearDele_EventOnSignTodayListClick();
			}

			// Token: 0x060131FA RID: 78330 RVA: 0x004E08E4 File Offset: 0x004DEAE4
			public void __callDele_EventOnSignTodayBoxListClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnSignTodayBoxListClick(arg1, arg2, arg3);
			}

			// Token: 0x060131FB RID: 78331 RVA: 0x004E08F4 File Offset: 0x004DEAF4
			public void __clearDele_EventOnSignTodayBoxListClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnSignTodayBoxListClick(arg1, arg2, arg3);
			}

			// Token: 0x060131FC RID: 78332 RVA: 0x004E0904 File Offset: 0x004DEB04
			public void __callDele_EventOnSignCloseButtonClick()
			{
				this.m_owner.__callDele_EventOnSignCloseButtonClick();
			}

			// Token: 0x060131FD RID: 78333 RVA: 0x004E0914 File Offset: 0x004DEB14
			public void __clearDele_EventOnSignCloseButtonClick()
			{
				this.m_owner.__clearDele_EventOnSignCloseButtonClick();
			}

			// Token: 0x1700399E RID: 14750
			// (get) Token: 0x060131FE RID: 78334 RVA: 0x004E0924 File Offset: 0x004DEB24
			// (set) Token: 0x060131FF RID: 78335 RVA: 0x004E0934 File Offset: 0x004DEB34
			public CommonUIStateController m_signUIStateCtrl
			{
				get
				{
					return this.m_owner.m_signUIStateCtrl;
				}
				set
				{
					this.m_owner.m_signUIStateCtrl = value;
				}
			}

			// Token: 0x1700399F RID: 14751
			// (get) Token: 0x06013200 RID: 78336 RVA: 0x004E0944 File Offset: 0x004DEB44
			// (set) Token: 0x06013201 RID: 78337 RVA: 0x004E0954 File Offset: 0x004DEB54
			public Button m_bgButton
			{
				get
				{
					return this.m_owner.m_bgButton;
				}
				set
				{
					this.m_owner.m_bgButton = value;
				}
			}

			// Token: 0x170039A0 RID: 14752
			// (get) Token: 0x06013202 RID: 78338 RVA: 0x004E0964 File Offset: 0x004DEB64
			// (set) Token: 0x06013203 RID: 78339 RVA: 0x004E0974 File Offset: 0x004DEB74
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

			// Token: 0x170039A1 RID: 14753
			// (get) Token: 0x06013204 RID: 78340 RVA: 0x004E0984 File Offset: 0x004DEB84
			// (set) Token: 0x06013205 RID: 78341 RVA: 0x004E0994 File Offset: 0x004DEB94
			public GameObject m_scrollViewSignRewardItemContent
			{
				get
				{
					return this.m_owner.m_scrollViewSignRewardItemContent;
				}
				set
				{
					this.m_owner.m_scrollViewSignRewardItemContent = value;
				}
			}

			// Token: 0x170039A2 RID: 14754
			// (get) Token: 0x06013206 RID: 78342 RVA: 0x004E09A4 File Offset: 0x004DEBA4
			// (set) Token: 0x06013207 RID: 78343 RVA: 0x004E09B4 File Offset: 0x004DEBB4
			public Text m_signDaysMonthText
			{
				get
				{
					return this.m_owner.m_signDaysMonthText;
				}
				set
				{
					this.m_owner.m_signDaysMonthText = value;
				}
			}

			// Token: 0x170039A3 RID: 14755
			// (get) Token: 0x06013208 RID: 78344 RVA: 0x004E09C4 File Offset: 0x004DEBC4
			// (set) Token: 0x06013209 RID: 78345 RVA: 0x004E09D4 File Offset: 0x004DEBD4
			public CommonUIStateController m_showBoxRewardPanelUIStateController
			{
				get
				{
					return this.m_owner.m_showBoxRewardPanelUIStateController;
				}
				set
				{
					this.m_owner.m_showBoxRewardPanelUIStateController = value;
				}
			}

			// Token: 0x170039A4 RID: 14756
			// (get) Token: 0x0601320A RID: 78346 RVA: 0x004E09E4 File Offset: 0x004DEBE4
			// (set) Token: 0x0601320B RID: 78347 RVA: 0x004E09F4 File Offset: 0x004DEBF4
			public Button m_showBoxRewardPanelBGButton
			{
				get
				{
					return this.m_owner.m_showBoxRewardPanelBGButton;
				}
				set
				{
					this.m_owner.m_showBoxRewardPanelBGButton = value;
				}
			}

			// Token: 0x170039A5 RID: 14757
			// (get) Token: 0x0601320C RID: 78348 RVA: 0x004E0A04 File Offset: 0x004DEC04
			// (set) Token: 0x0601320D RID: 78349 RVA: 0x004E0A14 File Offset: 0x004DEC14
			public GameObject m_boxRewardScrollViewObj
			{
				get
				{
					return this.m_owner.m_boxRewardScrollViewObj;
				}
				set
				{
					this.m_owner.m_boxRewardScrollViewObj = value;
				}
			}

			// Token: 0x170039A6 RID: 14758
			// (get) Token: 0x0601320E RID: 78350 RVA: 0x004E0A24 File Offset: 0x004DEC24
			// (set) Token: 0x0601320F RID: 78351 RVA: 0x004E0A34 File Offset: 0x004DEC34
			public Image m_boxIconImage
			{
				get
				{
					return this.m_owner.m_boxIconImage;
				}
				set
				{
					this.m_owner.m_boxIconImage = value;
				}
			}

			// Token: 0x170039A7 RID: 14759
			// (get) Token: 0x06013210 RID: 78352 RVA: 0x004E0A44 File Offset: 0x004DEC44
			// (set) Token: 0x06013211 RID: 78353 RVA: 0x004E0A54 File Offset: 0x004DEC54
			public Text m_boxCountText
			{
				get
				{
					return this.m_owner.m_boxCountText;
				}
				set
				{
					this.m_owner.m_boxCountText = value;
				}
			}

			// Token: 0x170039A8 RID: 14760
			// (get) Token: 0x06013212 RID: 78354 RVA: 0x004E0A64 File Offset: 0x004DEC64
			// (set) Token: 0x06013213 RID: 78355 RVA: 0x004E0A74 File Offset: 0x004DEC74
			public Text m_boxNameText
			{
				get
				{
					return this.m_owner.m_boxNameText;
				}
				set
				{
					this.m_owner.m_boxNameText = value;
				}
			}

			// Token: 0x170039A9 RID: 14761
			// (get) Token: 0x06013214 RID: 78356 RVA: 0x004E0A84 File Offset: 0x004DEC84
			// (set) Token: 0x06013215 RID: 78357 RVA: 0x004E0A94 File Offset: 0x004DEC94
			public Text m_boxHaveCountText
			{
				get
				{
					return this.m_owner.m_boxHaveCountText;
				}
				set
				{
					this.m_owner.m_boxHaveCountText = value;
				}
			}

			// Token: 0x170039AA RID: 14762
			// (get) Token: 0x06013216 RID: 78358 RVA: 0x004E0AA4 File Offset: 0x004DECA4
			// (set) Token: 0x06013217 RID: 78359 RVA: 0x004E0AB4 File Offset: 0x004DECB4
			public Text m_boxDescText
			{
				get
				{
					return this.m_owner.m_boxDescText;
				}
				set
				{
					this.m_owner.m_boxDescText = value;
				}
			}

			// Token: 0x170039AB RID: 14763
			// (get) Token: 0x06013218 RID: 78360 RVA: 0x004E0AC4 File Offset: 0x004DECC4
			// (set) Token: 0x06013219 RID: 78361 RVA: 0x004E0AD4 File Offset: 0x004DECD4
			public GameObject m_signBoxItemPrefab
			{
				get
				{
					return this.m_owner.m_signBoxItemPrefab;
				}
				set
				{
					this.m_owner.m_signBoxItemPrefab = value;
				}
			}

			// Token: 0x170039AC RID: 14764
			// (get) Token: 0x0601321A RID: 78362 RVA: 0x004E0AE4 File Offset: 0x004DECE4
			// (set) Token: 0x0601321B RID: 78363 RVA: 0x004E0AF4 File Offset: 0x004DECF4
			public List<SignRewardItemUIController> m_signRewardItemCtrlList
			{
				get
				{
					return this.m_owner.m_signRewardItemCtrlList;
				}
				set
				{
					this.m_owner.m_signRewardItemCtrlList = value;
				}
			}

			// Token: 0x170039AD RID: 14765
			// (get) Token: 0x0601321C RID: 78364 RVA: 0x004E0B04 File Offset: 0x004DED04
			// (set) Token: 0x0601321D RID: 78365 RVA: 0x004E0B14 File Offset: 0x004DED14
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

			// Token: 0x0601321E RID: 78366 RVA: 0x004E0B24 File Offset: 0x004DED24
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601321F RID: 78367 RVA: 0x004E0B34 File Offset: 0x004DED34
			public void CloseBoxRewardShowPanel()
			{
				this.m_owner.CloseBoxRewardShowPanel();
			}

			// Token: 0x06013220 RID: 78368 RVA: 0x004E0B44 File Offset: 0x004DED44
			public void OnCloseButtonClick()
			{
				this.m_owner.OnCloseButtonClick();
			}

			// Token: 0x06013221 RID: 78369 RVA: 0x004E0B54 File Offset: 0x004DED54
			public void OnSignItemClick()
			{
				this.m_owner.OnSignItemClick();
			}

			// Token: 0x06013222 RID: 78370 RVA: 0x004E0B64 File Offset: 0x004DED64
			public void OnSignBoxClick(GoodsType type, int id, int count)
			{
				this.m_owner.OnSignBoxClick(type, id, count);
			}

			// Token: 0x0400AA6F RID: 43631
			private SignRewardListUIController m_owner;
		}
	}
}
