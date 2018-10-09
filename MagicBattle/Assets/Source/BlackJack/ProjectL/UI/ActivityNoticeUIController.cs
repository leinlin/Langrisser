using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009C0 RID: 2496
	[HotFix]
	public class ActivityNoticeUIController : UIControllerBase
	{
		// Token: 0x06009124 RID: 37156 RVA: 0x002A107C File Offset: 0x0029F27C
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
			this.m_closeButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_bgCloseButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_bigItemPool = new GameObjectPool<ActivityNoticeBigItemUIController>();
			this.m_bigItemPool.Setup(this.m_bigActivePrefabObj, this.m_bigActiveScrollViewContentObject);
			this.m_smallItemPool = new GameObjectPool<ActivityNoticeSmallItemUIController>();
			this.m_smallItemPool.Setup(this.m_smallActivePrefabObj, this.m_smallActiveScrollViewContentObject);
			this.m_lampItemPool = new GameObjectPool();
			this.m_lampItemPool.Setup(this.m_lampPrefabObj, this.m_lampGroupObj);
			this.m_bigItemScrollSnapCenter = this.m_bigItemScrollRect.gameObject.AddComponent<ScrollSnapCenter>();
			this.m_bigItemScrollSnapCenter.m_itemSize = 1354f;
			this.m_bigItemScrollSnapCenter.m_scrollSnapDir = ScrollSnapDirection.Horizontal;
			this.m_bigItemScrollSnapCenter.m_scrollSnapPageType = ScrollSnapPageType.DragPercentage;
		}

		// Token: 0x06009125 RID: 37157 RVA: 0x002A11C0 File Offset: 0x0029F3C0
		public void SignOpenTween()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SignOpenTween_hotfix != null)
			{
				this.m_SignOpenTween_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x06009126 RID: 37158 RVA: 0x002A1234 File Offset: 0x0029F434
		public void UpdateActivityList(List<ActivityNoticeInfo> activityList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateActivityListList`1_hotfix != null)
			{
				this.m_UpdateActivityListList`1_hotfix.call(new object[]
				{
					this,
					activityList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (activityList == null)
			{
				return;
			}
			this.m_bigItemPool.Deactive();
			this.m_smallItemPool.Deactive();
			this.m_lampItemPool.Deactive();
			this.m_bigItemScrollSnapCenter.SetItemCount(0);
			if (this.m_lampUIStateCtrlList == null)
			{
				this.m_lampUIStateCtrlList = new List<CommonUIStateController>();
			}
			else
			{
				this.m_lampUIStateCtrlList.Clear();
			}
			foreach (ActivityNoticeInfo activityNoticeInfo in activityList)
			{
				if (activityNoticeInfo.IsLarge)
				{
					int count = this.m_bigItemPool.GetList().Count;
					bool flag;
					ActivityNoticeBigItemUIController activityNoticeBigItemUIController = this.m_bigItemPool.Allocate(out flag);
					if (activityNoticeBigItemUIController != null)
					{
						if (flag)
						{
							activityNoticeBigItemUIController.EventOnButtonClick += this.OnActivityItemClick;
						}
						activityNoticeBigItemUIController.UpdateItemInfo(activityNoticeInfo.ActivityId, activityNoticeInfo.ImageName, count);
						this.m_bigItemScrollSnapCenter.SetItemCount(this.m_bigItemPool.GetList().Count);
						RectTransform rectTransform = activityNoticeBigItemUIController.transform as RectTransform;
						rectTransform.anchoredPosition = this.m_bigItemScrollSnapCenter.ComputeItemPosition(count);
					}
				}
				else
				{
					bool flag2;
					ActivityNoticeSmallItemUIController activityNoticeSmallItemUIController = this.m_smallItemPool.Allocate(out flag2);
					if (activityNoticeSmallItemUIController != null)
					{
						if (flag2)
						{
							activityNoticeSmallItemUIController.EventOnButtonClick += this.OnActivityItemClick;
						}
						activityNoticeSmallItemUIController.UpdateItemInfo(activityNoticeInfo.ActivityId, activityNoticeInfo.ImageName, activityNoticeInfo.Desc);
					}
				}
			}
			if (this.m_bigItemPool.GetList() != null)
			{
				foreach (ActivityNoticeBigItemUIController activityNoticeBigItemUIController2 in this.m_bigItemPool.GetList())
				{
					GameObject gameObject = this.m_lampItemPool.Allocate();
					this.m_lampUIStateCtrlList.Add(gameObject.GetComponent<CommonUIStateController>());
				}
			}
			this.RefreshLampActive();
		}

		// Token: 0x06009127 RID: 37159 RVA: 0x002A14D0 File Offset: 0x0029F6D0
		private void RefreshLampActive()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshLampActive_hotfix != null)
			{
				this.m_RefreshLampActive_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_lampUIStateCtrlList == null)
			{
				return;
			}
			if (this.m_curBigItemIndex < 0 || this.m_curBigItemIndex >= this.m_lampUIStateCtrlList.Count)
			{
				return;
			}
			for (int i = 0; i < this.m_lampUIStateCtrlList.Count; i++)
			{
				if (this.m_curBigItemIndex == i)
				{
					this.m_lampUIStateCtrlList[i].SetToUIState("On", false, true);
				}
				else
				{
					this.m_lampUIStateCtrlList[i].SetToUIState("Off", false, true);
				}
			}
		}

		// Token: 0x06009128 RID: 37160 RVA: 0x002A15BC File Offset: 0x0029F7BC
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
			if (this.m_bigItemScrollSnapCenter == null || this.m_bigItemPool == null || this.m_bigItemPool.GetList() == null || this.m_bigItemPool.GetList().Count <= 0)
			{
				return;
			}
			int centerItemIndex = this.m_bigItemScrollSnapCenter.GetCenterItemIndex();
			if (centerItemIndex < 0 || centerItemIndex >= this.m_bigItemPool.GetList().Count)
			{
				return;
			}
			ActivityNoticeBigItemUIController activityNoticeBigItemUIController = this.m_bigItemPool.GetList()[centerItemIndex];
			if (activityNoticeBigItemUIController != null && this.m_curBigItemIndex != activityNoticeBigItemUIController.GetIndex())
			{
				this.m_curBigItemIndex = activityNoticeBigItemUIController.GetIndex();
				this.RefreshLampActive();
			}
		}

		// Token: 0x06009129 RID: 37161 RVA: 0x002A16CC File Offset: 0x0029F8CC
		private void OnActivityItemClick(int activityId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActivityItemClickInt32_hotfix != null)
			{
				this.m_OnActivityItemClickInt32_hotfix.call(new object[]
				{
					this,
					activityId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnActivityClick != null)
			{
				this.EventOnActivityClick(activityId);
			}
		}

		// Token: 0x0600912A RID: 37162 RVA: 0x002A1754 File Offset: 0x0029F954
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
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", delegate
			{
				if (this.EventOnCloseButtonClick != null)
				{
					this.EventOnCloseButtonClick();
				}
			}, false, true);
		}

		// Token: 0x14000195 RID: 405
		// (add) Token: 0x0600912B RID: 37163 RVA: 0x002A17D4 File Offset: 0x0029F9D4
		// (remove) Token: 0x0600912C RID: 37164 RVA: 0x002A1870 File Offset: 0x0029FA70
		public event Action<int> EventOnActivityClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnActivityClickAction`1_hotfix != null)
				{
					this.m_add_EventOnActivityClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnActivityClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnActivityClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnActivityClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnActivityClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnActivityClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnActivityClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000196 RID: 406
		// (add) Token: 0x0600912D RID: 37165 RVA: 0x002A190C File Offset: 0x0029FB0C
		// (remove) Token: 0x0600912E RID: 37166 RVA: 0x002A19A8 File Offset: 0x0029FBA8
		public event Action EventOnCloseButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnCloseButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnCloseButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x0600912F RID: 37167 RVA: 0x002A1A44 File Offset: 0x0029FC44
		// (set) Token: 0x06009130 RID: 37168 RVA: 0x002A1A64 File Offset: 0x0029FC64
		[DoNotToLua]
		public new ActivityNoticeUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ActivityNoticeUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009131 RID: 37169 RVA: 0x002A1A70 File Offset: 0x0029FC70
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009132 RID: 37170 RVA: 0x002A1A7C File Offset: 0x0029FC7C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009133 RID: 37171 RVA: 0x002A1A84 File Offset: 0x0029FC84
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009134 RID: 37172 RVA: 0x002A1A8C File Offset: 0x0029FC8C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009135 RID: 37173 RVA: 0x002A1AA0 File Offset: 0x0029FCA0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009136 RID: 37174 RVA: 0x002A1AA8 File Offset: 0x0029FCA8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009137 RID: 37175 RVA: 0x002A1AB4 File Offset: 0x0029FCB4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009138 RID: 37176 RVA: 0x002A1AC0 File Offset: 0x0029FCC0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009139 RID: 37177 RVA: 0x002A1ACC File Offset: 0x0029FCCC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600913A RID: 37178 RVA: 0x002A1AD8 File Offset: 0x0029FCD8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600913B RID: 37179 RVA: 0x002A1AE4 File Offset: 0x0029FCE4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600913C RID: 37180 RVA: 0x002A1AF0 File Offset: 0x0029FCF0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600913D RID: 37181 RVA: 0x002A1AFC File Offset: 0x0029FCFC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600913E RID: 37182 RVA: 0x002A1B08 File Offset: 0x0029FD08
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600913F RID: 37183 RVA: 0x002A1B14 File Offset: 0x0029FD14
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009140 RID: 37184 RVA: 0x002A1B1C File Offset: 0x0029FD1C
		private void __callDele_EventOnActivityClick(int obj)
		{
			Action<int> eventOnActivityClick = this.EventOnActivityClick;
			if (eventOnActivityClick != null)
			{
				eventOnActivityClick(obj);
			}
		}

		// Token: 0x06009141 RID: 37185 RVA: 0x002A1B40 File Offset: 0x0029FD40
		private void __clearDele_EventOnActivityClick(int obj)
		{
			this.EventOnActivityClick = null;
		}

		// Token: 0x06009142 RID: 37186 RVA: 0x002A1B4C File Offset: 0x0029FD4C
		private void __callDele_EventOnCloseButtonClick()
		{
			Action eventOnCloseButtonClick = this.EventOnCloseButtonClick;
			if (eventOnCloseButtonClick != null)
			{
				eventOnCloseButtonClick();
			}
		}

		// Token: 0x06009143 RID: 37187 RVA: 0x002A1B6C File Offset: 0x0029FD6C
		private void __clearDele_EventOnCloseButtonClick()
		{
			this.EventOnCloseButtonClick = null;
		}

		// Token: 0x06009145 RID: 37189 RVA: 0x002A1B90 File Offset: 0x0029FD90
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
					this.m_SignOpenTween_hotfix = (luaObj.RawGet("SignOpenTween") as LuaFunction);
					this.m_UpdateActivityListList`1_hotfix = (luaObj.RawGet("UpdateActivityList") as LuaFunction);
					this.m_RefreshLampActive_hotfix = (luaObj.RawGet("RefreshLampActive") as LuaFunction);
					this.m_LateUpdate_hotfix = (luaObj.RawGet("LateUpdate") as LuaFunction);
					this.m_OnActivityItemClickInt32_hotfix = (luaObj.RawGet("OnActivityItemClick") as LuaFunction);
					this.m_OnCloseButtonClick_hotfix = (luaObj.RawGet("OnCloseButtonClick") as LuaFunction);
					this.m_add_EventOnActivityClickAction`1_hotfix = (luaObj.RawGet("add_EventOnActivityClick") as LuaFunction);
					this.m_remove_EventOnActivityClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnActivityClick") as LuaFunction);
					this.m_add_EventOnCloseButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnCloseButtonClick") as LuaFunction);
					this.m_remove_EventOnCloseButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnCloseButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009146 RID: 37190 RVA: 0x002A1D58 File Offset: 0x0029FF58
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActivityNoticeUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040065D4 RID: 26068
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x040065D5 RID: 26069
		[AutoBind("./LayoutRoot/LampGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lampGroupObj;

		// Token: 0x040065D6 RID: 26070
		[AutoBind("./LayoutRoot/TopImageGroup/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bigActiveScrollViewContentObject;

		// Token: 0x040065D7 RID: 26071
		[AutoBind("./LayoutRoot/List/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_smallActiveScrollViewContentObject;

		// Token: 0x040065D8 RID: 26072
		[AutoBind("./Prefabs/Lamp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lampPrefabObj;

		// Token: 0x040065D9 RID: 26073
		[AutoBind("./Prefabs/BigActive", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bigActivePrefabObj;

		// Token: 0x040065DA RID: 26074
		[AutoBind("./Prefabs/SmallActive", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_smallActivePrefabObj;

		// Token: 0x040065DB RID: 26075
		[AutoBind("./LayoutRoot/Closebutton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeButton;

		// Token: 0x040065DC RID: 26076
		[AutoBind("./LayoutRoot/TopImageGroup", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_bigItemScrollRect;

		// Token: 0x040065DD RID: 26077
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgCloseButton;

		// Token: 0x040065E0 RID: 26080
		private GameObjectPool<ActivityNoticeBigItemUIController> m_bigItemPool;

		// Token: 0x040065E1 RID: 26081
		private GameObjectPool<ActivityNoticeSmallItemUIController> m_smallItemPool;

		// Token: 0x040065E2 RID: 26082
		private GameObjectPool m_lampItemPool;

		// Token: 0x040065E3 RID: 26083
		private List<CommonUIStateController> m_lampUIStateCtrlList;

		// Token: 0x040065E4 RID: 26084
		private ScrollSnapCenter m_bigItemScrollSnapCenter;

		// Token: 0x040065E5 RID: 26085
		private int m_curBigItemIndex;

		// Token: 0x040065E6 RID: 26086
		[DoNotToLua]
		private ActivityNoticeUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040065E7 RID: 26087
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040065E8 RID: 26088
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040065E9 RID: 26089
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040065EA RID: 26090
		private LuaFunction m_SignOpenTween_hotfix;

		// Token: 0x040065EB RID: 26091
		private LuaFunction m_UpdateActivityListList;

		// Token: 0x040065EC RID: 26092
		private LuaFunction m_RefreshLampActive_hotfix;

		// Token: 0x040065ED RID: 26093
		private LuaFunction m_LateUpdate_hotfix;

		// Token: 0x040065EE RID: 26094
		private LuaFunction m_OnActivityItemClickInt32_hotfix;

		// Token: 0x040065EF RID: 26095
		private LuaFunction m_OnCloseButtonClick_hotfix;

		// Token: 0x040065F0 RID: 26096
		private LuaFunction m_add_EventOnActivityClickAction;

		// Token: 0x040065F1 RID: 26097
		private LuaFunction m_remove_EventOnActivityClickAction;

		// Token: 0x040065F2 RID: 26098
		private LuaFunction m_add_EventOnCloseButtonClickAction_hotfix;

		// Token: 0x040065F3 RID: 26099
		private LuaFunction m_remove_EventOnCloseButtonClickAction_hotfix;

		// Token: 0x020009C1 RID: 2497
		public new class LuaExportHelper
		{
			// Token: 0x06009147 RID: 37191 RVA: 0x002A1DC0 File Offset: 0x0029FFC0
			public LuaExportHelper(ActivityNoticeUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009148 RID: 37192 RVA: 0x002A1DD0 File Offset: 0x0029FFD0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009149 RID: 37193 RVA: 0x002A1DE0 File Offset: 0x0029FFE0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600914A RID: 37194 RVA: 0x002A1DF0 File Offset: 0x0029FFF0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600914B RID: 37195 RVA: 0x002A1E00 File Offset: 0x002A0000
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600914C RID: 37196 RVA: 0x002A1E18 File Offset: 0x002A0018
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600914D RID: 37197 RVA: 0x002A1E28 File Offset: 0x002A0028
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600914E RID: 37198 RVA: 0x002A1E38 File Offset: 0x002A0038
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600914F RID: 37199 RVA: 0x002A1E48 File Offset: 0x002A0048
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009150 RID: 37200 RVA: 0x002A1E58 File Offset: 0x002A0058
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009151 RID: 37201 RVA: 0x002A1E68 File Offset: 0x002A0068
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009152 RID: 37202 RVA: 0x002A1E78 File Offset: 0x002A0078
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009153 RID: 37203 RVA: 0x002A1E88 File Offset: 0x002A0088
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009154 RID: 37204 RVA: 0x002A1E98 File Offset: 0x002A0098
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009155 RID: 37205 RVA: 0x002A1EA8 File Offset: 0x002A00A8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009156 RID: 37206 RVA: 0x002A1EB8 File Offset: 0x002A00B8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009157 RID: 37207 RVA: 0x002A1EC8 File Offset: 0x002A00C8
			public void __callDele_EventOnActivityClick(int obj)
			{
				this.m_owner.__callDele_EventOnActivityClick(obj);
			}

			// Token: 0x06009158 RID: 37208 RVA: 0x002A1ED8 File Offset: 0x002A00D8
			public void __clearDele_EventOnActivityClick(int obj)
			{
				this.m_owner.__clearDele_EventOnActivityClick(obj);
			}

			// Token: 0x06009159 RID: 37209 RVA: 0x002A1EE8 File Offset: 0x002A00E8
			public void __callDele_EventOnCloseButtonClick()
			{
				this.m_owner.__callDele_EventOnCloseButtonClick();
			}

			// Token: 0x0600915A RID: 37210 RVA: 0x002A1EF8 File Offset: 0x002A00F8
			public void __clearDele_EventOnCloseButtonClick()
			{
				this.m_owner.__clearDele_EventOnCloseButtonClick();
			}

			// Token: 0x17001E24 RID: 7716
			// (get) Token: 0x0600915B RID: 37211 RVA: 0x002A1F08 File Offset: 0x002A0108
			// (set) Token: 0x0600915C RID: 37212 RVA: 0x002A1F18 File Offset: 0x002A0118
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

			// Token: 0x17001E25 RID: 7717
			// (get) Token: 0x0600915D RID: 37213 RVA: 0x002A1F28 File Offset: 0x002A0128
			// (set) Token: 0x0600915E RID: 37214 RVA: 0x002A1F38 File Offset: 0x002A0138
			public GameObject m_lampGroupObj
			{
				get
				{
					return this.m_owner.m_lampGroupObj;
				}
				set
				{
					this.m_owner.m_lampGroupObj = value;
				}
			}

			// Token: 0x17001E26 RID: 7718
			// (get) Token: 0x0600915F RID: 37215 RVA: 0x002A1F48 File Offset: 0x002A0148
			// (set) Token: 0x06009160 RID: 37216 RVA: 0x002A1F58 File Offset: 0x002A0158
			public GameObject m_bigActiveScrollViewContentObject
			{
				get
				{
					return this.m_owner.m_bigActiveScrollViewContentObject;
				}
				set
				{
					this.m_owner.m_bigActiveScrollViewContentObject = value;
				}
			}

			// Token: 0x17001E27 RID: 7719
			// (get) Token: 0x06009161 RID: 37217 RVA: 0x002A1F68 File Offset: 0x002A0168
			// (set) Token: 0x06009162 RID: 37218 RVA: 0x002A1F78 File Offset: 0x002A0178
			public GameObject m_smallActiveScrollViewContentObject
			{
				get
				{
					return this.m_owner.m_smallActiveScrollViewContentObject;
				}
				set
				{
					this.m_owner.m_smallActiveScrollViewContentObject = value;
				}
			}

			// Token: 0x17001E28 RID: 7720
			// (get) Token: 0x06009163 RID: 37219 RVA: 0x002A1F88 File Offset: 0x002A0188
			// (set) Token: 0x06009164 RID: 37220 RVA: 0x002A1F98 File Offset: 0x002A0198
			public GameObject m_lampPrefabObj
			{
				get
				{
					return this.m_owner.m_lampPrefabObj;
				}
				set
				{
					this.m_owner.m_lampPrefabObj = value;
				}
			}

			// Token: 0x17001E29 RID: 7721
			// (get) Token: 0x06009165 RID: 37221 RVA: 0x002A1FA8 File Offset: 0x002A01A8
			// (set) Token: 0x06009166 RID: 37222 RVA: 0x002A1FB8 File Offset: 0x002A01B8
			public GameObject m_bigActivePrefabObj
			{
				get
				{
					return this.m_owner.m_bigActivePrefabObj;
				}
				set
				{
					this.m_owner.m_bigActivePrefabObj = value;
				}
			}

			// Token: 0x17001E2A RID: 7722
			// (get) Token: 0x06009167 RID: 37223 RVA: 0x002A1FC8 File Offset: 0x002A01C8
			// (set) Token: 0x06009168 RID: 37224 RVA: 0x002A1FD8 File Offset: 0x002A01D8
			public GameObject m_smallActivePrefabObj
			{
				get
				{
					return this.m_owner.m_smallActivePrefabObj;
				}
				set
				{
					this.m_owner.m_smallActivePrefabObj = value;
				}
			}

			// Token: 0x17001E2B RID: 7723
			// (get) Token: 0x06009169 RID: 37225 RVA: 0x002A1FE8 File Offset: 0x002A01E8
			// (set) Token: 0x0600916A RID: 37226 RVA: 0x002A1FF8 File Offset: 0x002A01F8
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

			// Token: 0x17001E2C RID: 7724
			// (get) Token: 0x0600916B RID: 37227 RVA: 0x002A2008 File Offset: 0x002A0208
			// (set) Token: 0x0600916C RID: 37228 RVA: 0x002A2018 File Offset: 0x002A0218
			public ScrollRect m_bigItemScrollRect
			{
				get
				{
					return this.m_owner.m_bigItemScrollRect;
				}
				set
				{
					this.m_owner.m_bigItemScrollRect = value;
				}
			}

			// Token: 0x17001E2D RID: 7725
			// (get) Token: 0x0600916D RID: 37229 RVA: 0x002A2028 File Offset: 0x002A0228
			// (set) Token: 0x0600916E RID: 37230 RVA: 0x002A2038 File Offset: 0x002A0238
			public Button m_bgCloseButton
			{
				get
				{
					return this.m_owner.m_bgCloseButton;
				}
				set
				{
					this.m_owner.m_bgCloseButton = value;
				}
			}

			// Token: 0x17001E2E RID: 7726
			// (get) Token: 0x0600916F RID: 37231 RVA: 0x002A2048 File Offset: 0x002A0248
			// (set) Token: 0x06009170 RID: 37232 RVA: 0x002A2058 File Offset: 0x002A0258
			public GameObjectPool<ActivityNoticeBigItemUIController> m_bigItemPool
			{
				get
				{
					return this.m_owner.m_bigItemPool;
				}
				set
				{
					this.m_owner.m_bigItemPool = value;
				}
			}

			// Token: 0x17001E2F RID: 7727
			// (get) Token: 0x06009171 RID: 37233 RVA: 0x002A2068 File Offset: 0x002A0268
			// (set) Token: 0x06009172 RID: 37234 RVA: 0x002A2078 File Offset: 0x002A0278
			public GameObjectPool<ActivityNoticeSmallItemUIController> m_smallItemPool
			{
				get
				{
					return this.m_owner.m_smallItemPool;
				}
				set
				{
					this.m_owner.m_smallItemPool = value;
				}
			}

			// Token: 0x17001E30 RID: 7728
			// (get) Token: 0x06009173 RID: 37235 RVA: 0x002A2088 File Offset: 0x002A0288
			// (set) Token: 0x06009174 RID: 37236 RVA: 0x002A2098 File Offset: 0x002A0298
			public GameObjectPool m_lampItemPool
			{
				get
				{
					return this.m_owner.m_lampItemPool;
				}
				set
				{
					this.m_owner.m_lampItemPool = value;
				}
			}

			// Token: 0x17001E31 RID: 7729
			// (get) Token: 0x06009175 RID: 37237 RVA: 0x002A20A8 File Offset: 0x002A02A8
			// (set) Token: 0x06009176 RID: 37238 RVA: 0x002A20B8 File Offset: 0x002A02B8
			public List<CommonUIStateController> m_lampUIStateCtrlList
			{
				get
				{
					return this.m_owner.m_lampUIStateCtrlList;
				}
				set
				{
					this.m_owner.m_lampUIStateCtrlList = value;
				}
			}

			// Token: 0x17001E32 RID: 7730
			// (get) Token: 0x06009177 RID: 37239 RVA: 0x002A20C8 File Offset: 0x002A02C8
			// (set) Token: 0x06009178 RID: 37240 RVA: 0x002A20D8 File Offset: 0x002A02D8
			public ScrollSnapCenter m_bigItemScrollSnapCenter
			{
				get
				{
					return this.m_owner.m_bigItemScrollSnapCenter;
				}
				set
				{
					this.m_owner.m_bigItemScrollSnapCenter = value;
				}
			}

			// Token: 0x17001E33 RID: 7731
			// (get) Token: 0x06009179 RID: 37241 RVA: 0x002A20E8 File Offset: 0x002A02E8
			// (set) Token: 0x0600917A RID: 37242 RVA: 0x002A20F8 File Offset: 0x002A02F8
			public int m_curBigItemIndex
			{
				get
				{
					return this.m_owner.m_curBigItemIndex;
				}
				set
				{
					this.m_owner.m_curBigItemIndex = value;
				}
			}

			// Token: 0x0600917B RID: 37243 RVA: 0x002A2108 File Offset: 0x002A0308
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600917C RID: 37244 RVA: 0x002A2118 File Offset: 0x002A0318
			public void RefreshLampActive()
			{
				this.m_owner.RefreshLampActive();
			}

			// Token: 0x0600917D RID: 37245 RVA: 0x002A2128 File Offset: 0x002A0328
			public void LateUpdate()
			{
				this.m_owner.LateUpdate();
			}

			// Token: 0x0600917E RID: 37246 RVA: 0x002A2138 File Offset: 0x002A0338
			public void OnActivityItemClick(int activityId)
			{
				this.m_owner.OnActivityItemClick(activityId);
			}

			// Token: 0x0600917F RID: 37247 RVA: 0x002A2148 File Offset: 0x002A0348
			public void OnCloseButtonClick()
			{
				this.m_owner.OnCloseButtonClick();
			}

			// Token: 0x040065F4 RID: 26100
			private ActivityNoticeUIController m_owner;
		}
	}
}
