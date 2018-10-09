using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B3F RID: 2879
	[HotFix]
	public class ChatExpressionUIController : UIControllerBase
	{
		// Token: 0x0600C397 RID: 50071 RVA: 0x00363328 File Offset: 0x00361528
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
			base.SetButtonClickListener("ExpressionBgButton", new Action<UIControllerBase>(this.OnExpressionBgButtonClick));
			this.SmallExpressionToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSmallExpressionToggleValueChanged));
			EventTriggerListener eventTriggerListener = this.SmallExpressionRoot.AddComponent<EventTriggerListener>();
			EventTriggerListener eventTriggerListener2 = eventTriggerListener;
			eventTriggerListener2.onEndDrag = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener2.onEndDrag, new EventTriggerListener.VoidDelegate(this.OnPointerUp4ExpressionScrollRect));
			this.m_bigExpressionInChatController = UIUtility.CreateSubUI<BigExpressionInChatController>(this.BigExpressionGroupDummy.transform);
			this.m_bigExpressionInChatController.EventOnExpressionClick += this.OnBigExpressionClick;
			base.StartCoroutine(this.m_bigExpressionInChatController.DelayInit());
			UIUtility.SetUIStateClose(this.PanelStateCtrl, "Close", null, false, true);
		}

		// Token: 0x0600C398 RID: 50072 RVA: 0x00363444 File Offset: 0x00361644
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600C399 RID: 50073 RVA: 0x003634A4 File Offset: 0x003616A4
		public void ShowOrHideExpressionPanel(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOrHideExpressionPanelBoolean_hotfix != null)
			{
				this.m_ShowOrHideExpressionPanelBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isShow)
			{
				UIUtility.SetUIStateOpen(this.PanelStateCtrl, "Show", null, false, true);
			}
			else
			{
				UIUtility.SetUIStateClose(this.PanelStateCtrl, "Close", null, false, true);
			}
		}

		// Token: 0x0600C39A RID: 50074 RVA: 0x00363548 File Offset: 0x00361748
		public void SwitchExpressionPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SwitchExpressionPanel_hotfix != null)
			{
				this.m_SwitchExpressionPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIStateDesc currentUIState = this.PanelStateCtrl.GetCurrentUIState();
			if (currentUIState.StateName == "Close")
			{
				UIUtility.SetUIStateOpen(this.PanelStateCtrl, "Show", null, false, true);
			}
			else
			{
				UIUtility.SetUIStateClose(this.PanelStateCtrl, "Close", null, false, true);
			}
		}

		// Token: 0x0600C39B RID: 50075 RVA: 0x003635F4 File Offset: 0x003617F4
		[DebuggerHidden]
		public IEnumerator DelayInstancePrefab()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DelayInstancePrefab_hotfix != null)
			{
				return (IEnumerator)this.m_DelayInstancePrefab_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatExpressionUIController.<DelayInstancePrefab>c__Iterator0 <DelayInstancePrefab>c__Iterator = new ChatExpressionUIController.<DelayInstancePrefab>c__Iterator0();
			<DelayInstancePrefab>c__Iterator.$this = this;
			return <DelayInstancePrefab>c__Iterator;
		}

		// Token: 0x0600C39C RID: 50076 RVA: 0x00363670 File Offset: 0x00361870
		private void OnPointerUp4ExpressionScrollRect(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerUp4ExpressionScrollRectGameObject_hotfix != null)
			{
				this.m_OnPointerUp4ExpressionScrollRectGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float x = this.SmallExpressionRoot.GetComponent<ScrollRect>().normalizedPosition.x;
			bool flag = x >= this.m_smallExpressionPageSubSectionList[this.m_currSmallPageIndex].Key;
			if (flag)
			{
				for (int i = 0; i < this.m_smallExpressionPageSubSectionList.Count; i++)
				{
					if (x <= this.m_smallExpressionPageSubSectionList[i].Key + 2f * this.m_emptySpaceNormalRatio)
					{
						base.StartCoroutine(this.SetSmallExpressionPage(i));
						break;
					}
					if (i == this.m_smallExpressionPageSubSectionList.Count - 1)
					{
						base.StartCoroutine(this.SetSmallExpressionPage(i));
						break;
					}
				}
			}
			else
			{
				for (int j = 0; j < this.m_smallExpressionPageSubSectionList.Count; j++)
				{
					if (x < this.m_smallExpressionPageSubSectionList[j].Value - 2f * this.m_emptySpaceNormalRatio)
					{
						base.StartCoroutine(this.SetSmallExpressionPage(j));
						break;
					}
					if (j == this.m_smallExpressionPageSubSectionList.Count - 1)
					{
						base.StartCoroutine(this.SetSmallExpressionPage(j));
						break;
					}
				}
			}
		}

		// Token: 0x0600C39D RID: 50077 RVA: 0x00363830 File Offset: 0x00361A30
		private void OnSmallExpressionClick(SmallExpressionItemContrller uCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSmallExpressionClickSmallExpressionItemContrller_hotfix != null)
			{
				this.m_OnSmallExpressionClickSmallExpressionItemContrller_hotfix.call(new object[]
				{
					this,
					uCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSmallExpressionClick != null)
			{
				this.EventOnSmallExpressionClick(uCtrl);
			}
		}

		// Token: 0x0600C39E RID: 50078 RVA: 0x003638B8 File Offset: 0x00361AB8
		private void OnExpressionBgButtonClick(UIControllerBase uCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExpressionBgButtonClickUIControllerBase_hotfix != null)
			{
				this.m_OnExpressionBgButtonClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					uCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnExpressionBgButtonClick != null)
			{
				this.EventOnExpressionBgButtonClick();
			}
		}

		// Token: 0x0600C39F RID: 50079 RVA: 0x00363940 File Offset: 0x00361B40
		private void OnSmallExpressionToggleValueChanged(bool isSelected)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSmallExpressionToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSmallExpressionToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isSelected
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isSelected)
			{
				this.SetSmallExpressionPageImmediate(0);
			}
		}

		// Token: 0x0600C3A0 RID: 50080 RVA: 0x003639C0 File Offset: 0x00361BC0
		private void OnBigExpressionClick(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBigExpressionClickInt32_hotfix != null)
			{
				this.m_OnBigExpressionClickInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowOrHideExpressionPanel(false);
		}

		// Token: 0x0600C3A1 RID: 50081 RVA: 0x00363A38 File Offset: 0x00361C38
		[DebuggerHidden]
		public IEnumerator InitExpressionPageAndItem()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitExpressionPageAndItem_hotfix != null)
			{
				return (IEnumerator)this.m_InitExpressionPageAndItem_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatExpressionUIController.<InitExpressionPageAndItem>c__Iterator1 <InitExpressionPageAndItem>c__Iterator = new ChatExpressionUIController.<InitExpressionPageAndItem>c__Iterator1();
			<InitExpressionPageAndItem>c__Iterator.$this = this;
			return <InitExpressionPageAndItem>c__Iterator;
		}

		// Token: 0x0600C3A2 RID: 50082 RVA: 0x00363AB4 File Offset: 0x00361CB4
		private void SetSmallExpressionPageImmediate(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSmallExpressionPageImmediateInt32_hotfix != null)
			{
				this.m_SetSmallExpressionPageImmediateInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currSmallPageIndex = index;
			ScrollRect component = this.SmallExpressionRoot.GetComponent<ScrollRect>();
			component.normalizedPosition = new Vector2(this.m_smallExpressionPageSubSectionList[index].Key, component.normalizedPosition.y);
			for (int i = 0; i < this.m_smallExpressionPagePointList.Count; i++)
			{
				if (i == index)
				{
					this.m_smallExpressionPagePointList[i].SetToUIState("Normal", false, true);
				}
				else
				{
					this.m_smallExpressionPagePointList[i].SetToUIState("Grey", false, true);
				}
			}
		}

		// Token: 0x0600C3A3 RID: 50083 RVA: 0x00363BBC File Offset: 0x00361DBC
		[DebuggerHidden]
		private IEnumerator SetSmallExpressionPage(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSmallExpressionPageInt32_hotfix != null)
			{
				return (IEnumerator)this.m_SetSmallExpressionPageInt32_hotfix.call(new object[]
				{
					this,
					index
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatExpressionUIController.<SetSmallExpressionPage>c__Iterator2 <SetSmallExpressionPage>c__Iterator = new ChatExpressionUIController.<SetSmallExpressionPage>c__Iterator2();
			<SetSmallExpressionPage>c__Iterator.index = index;
			<SetSmallExpressionPage>c__Iterator.$this = this;
			return <SetSmallExpressionPage>c__Iterator;
		}

		// Token: 0x14000255 RID: 597
		// (add) Token: 0x0600C3A4 RID: 50084 RVA: 0x00363C50 File Offset: 0x00361E50
		// (remove) Token: 0x0600C3A5 RID: 50085 RVA: 0x00363CEC File Offset: 0x00361EEC
		public event Action<SmallExpressionItemContrller> EventOnSmallExpressionClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSmallExpressionClickAction`1_hotfix != null)
				{
					this.m_add_EventOnSmallExpressionClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SmallExpressionItemContrller> action = this.EventOnSmallExpressionClick;
				Action<SmallExpressionItemContrller> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SmallExpressionItemContrller>>(ref this.EventOnSmallExpressionClick, (Action<SmallExpressionItemContrller>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSmallExpressionClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnSmallExpressionClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SmallExpressionItemContrller> action = this.EventOnSmallExpressionClick;
				Action<SmallExpressionItemContrller> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SmallExpressionItemContrller>>(ref this.EventOnSmallExpressionClick, (Action<SmallExpressionItemContrller>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000256 RID: 598
		// (add) Token: 0x0600C3A6 RID: 50086 RVA: 0x00363D88 File Offset: 0x00361F88
		// (remove) Token: 0x0600C3A7 RID: 50087 RVA: 0x00363E24 File Offset: 0x00362024
		public event Action EventOnExpressionBgButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExpressionBgButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnExpressionBgButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExpressionBgButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExpressionBgButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExpressionBgButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnExpressionBgButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExpressionBgButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExpressionBgButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x0600C3A8 RID: 50088 RVA: 0x00363EC0 File Offset: 0x003620C0
		// (set) Token: 0x0600C3A9 RID: 50089 RVA: 0x00363EE0 File Offset: 0x003620E0
		[DoNotToLua]
		public new ChatExpressionUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatExpressionUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C3AA RID: 50090 RVA: 0x00363EEC File Offset: 0x003620EC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C3AB RID: 50091 RVA: 0x00363EF8 File Offset: 0x003620F8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C3AC RID: 50092 RVA: 0x00363F00 File Offset: 0x00362100
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x00363F08 File Offset: 0x00362108
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C3AE RID: 50094 RVA: 0x00363F1C File Offset: 0x0036211C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C3AF RID: 50095 RVA: 0x00363F24 File Offset: 0x00362124
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C3B0 RID: 50096 RVA: 0x00363F30 File Offset: 0x00362130
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C3B1 RID: 50097 RVA: 0x00363F3C File Offset: 0x0036213C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C3B2 RID: 50098 RVA: 0x00363F48 File Offset: 0x00362148
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C3B3 RID: 50099 RVA: 0x00363F54 File Offset: 0x00362154
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C3B4 RID: 50100 RVA: 0x00363F60 File Offset: 0x00362160
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C3B5 RID: 50101 RVA: 0x00363F6C File Offset: 0x0036216C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C3B6 RID: 50102 RVA: 0x00363F78 File Offset: 0x00362178
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C3B7 RID: 50103 RVA: 0x00363F84 File Offset: 0x00362184
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C3B8 RID: 50104 RVA: 0x00363F90 File Offset: 0x00362190
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C3B9 RID: 50105 RVA: 0x00363F98 File Offset: 0x00362198
		private void __callDele_EventOnSmallExpressionClick(SmallExpressionItemContrller obj)
		{
			Action<SmallExpressionItemContrller> eventOnSmallExpressionClick = this.EventOnSmallExpressionClick;
			if (eventOnSmallExpressionClick != null)
			{
				eventOnSmallExpressionClick(obj);
			}
		}

		// Token: 0x0600C3BA RID: 50106 RVA: 0x00363FBC File Offset: 0x003621BC
		private void __clearDele_EventOnSmallExpressionClick(SmallExpressionItemContrller obj)
		{
			this.EventOnSmallExpressionClick = null;
		}

		// Token: 0x0600C3BB RID: 50107 RVA: 0x00363FC8 File Offset: 0x003621C8
		private void __callDele_EventOnExpressionBgButtonClick()
		{
			Action eventOnExpressionBgButtonClick = this.EventOnExpressionBgButtonClick;
			if (eventOnExpressionBgButtonClick != null)
			{
				eventOnExpressionBgButtonClick();
			}
		}

		// Token: 0x0600C3BC RID: 50108 RVA: 0x00363FE8 File Offset: 0x003621E8
		private void __clearDele_EventOnExpressionBgButtonClick()
		{
			this.EventOnExpressionBgButtonClick = null;
		}

		// Token: 0x0600C3BD RID: 50109 RVA: 0x00363FF4 File Offset: 0x003621F4
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
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_ShowOrHideExpressionPanelBoolean_hotfix = (luaObj.RawGet("ShowOrHideExpressionPanel") as LuaFunction);
					this.m_SwitchExpressionPanel_hotfix = (luaObj.RawGet("SwitchExpressionPanel") as LuaFunction);
					this.m_DelayInstancePrefab_hotfix = (luaObj.RawGet("DelayInstancePrefab") as LuaFunction);
					this.m_OnPointerUp4ExpressionScrollRectGameObject_hotfix = (luaObj.RawGet("OnPointerUp4ExpressionScrollRect") as LuaFunction);
					this.m_OnSmallExpressionClickSmallExpressionItemContrller_hotfix = (luaObj.RawGet("OnSmallExpressionClick") as LuaFunction);
					this.m_OnExpressionBgButtonClickUIControllerBase_hotfix = (luaObj.RawGet("OnExpressionBgButtonClick") as LuaFunction);
					this.m_OnSmallExpressionToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSmallExpressionToggleValueChanged") as LuaFunction);
					this.m_OnBigExpressionClickInt32_hotfix = (luaObj.RawGet("OnBigExpressionClick") as LuaFunction);
					this.m_InitExpressionPageAndItem_hotfix = (luaObj.RawGet("InitExpressionPageAndItem") as LuaFunction);
					this.m_SetSmallExpressionPageImmediateInt32_hotfix = (luaObj.RawGet("SetSmallExpressionPageImmediate") as LuaFunction);
					this.m_SetSmallExpressionPageInt32_hotfix = (luaObj.RawGet("SetSmallExpressionPage") as LuaFunction);
					this.m_add_EventOnSmallExpressionClickAction`1_hotfix = (luaObj.RawGet("add_EventOnSmallExpressionClick") as LuaFunction);
					this.m_remove_EventOnSmallExpressionClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnSmallExpressionClick") as LuaFunction);
					this.m_add_EventOnExpressionBgButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnExpressionBgButtonClick") as LuaFunction);
					this.m_remove_EventOnExpressionBgButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnExpressionBgButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C3BE RID: 50110 RVA: 0x00364250 File Offset: 0x00362450
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatExpressionUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007C04 RID: 31748
		public BigExpressionInChatController m_bigExpressionInChatController;

		// Token: 0x04007C05 RID: 31749
		private float m_emptySpaceNormalRatio;

		// Token: 0x04007C06 RID: 31750
		private int m_currSmallPageIndex;

		// Token: 0x04007C07 RID: 31751
		private List<CommonUIStateController> m_smallExpressionPagePointList = new List<CommonUIStateController>();

		// Token: 0x04007C08 RID: 31752
		private List<KeyValuePair<float, float>> m_smallExpressionPageSubSectionList = new List<KeyValuePair<float, float>>();

		// Token: 0x04007C09 RID: 31753
		private List<SmallExpressionItemContrller> m_smallExpressionCtrlList = new List<SmallExpressionItemContrller>();

		// Token: 0x04007C0A RID: 31754
		[AutoBind("./Detail/ExpressionToggle", AutoBindAttribute.InitState.NotInit, false)]
		public Toggle SmallExpressionToggle;

		// Token: 0x04007C0B RID: 31755
		[AutoBind("./ExpressionBGButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button ExpressionBgButton;

		// Token: 0x04007C0C RID: 31756
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController PanelStateCtrl;

		// Token: 0x04007C0D RID: 31757
		[AutoBind("./Detail/ExpressionGroup/ExpressionScrollView", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject SmallExpressionRoot;

		// Token: 0x04007C0E RID: 31758
		[AutoBind("./Detail/ExpressionGroup/ExpressionScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject SmallExpressionContent;

		// Token: 0x04007C0F RID: 31759
		[AutoBind("./Detail/ExpressionGroup/ExpressionScrollView/Viewport/Content/OnePage/ExpressionItem", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject SmallExpressionItem;

		// Token: 0x04007C10 RID: 31760
		[AutoBind("./Detail/ExpressionGroup/ExpressionScrollView/Viewport/Content/OnePage", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject SmallExpressionPage;

		// Token: 0x04007C11 RID: 31761
		[AutoBind("./Detail/ExpressionGroup/PagePoint/PagePoint", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject ExpressionPagePoint;

		// Token: 0x04007C12 RID: 31762
		[AutoBind("./Detail/ExpressionGroup/PagePoint", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject ExpressionPagePointRoot;

		// Token: 0x04007C13 RID: 31763
		[AutoBind("./Detail/BigExressionGroupDummy", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject BigExpressionGroupDummy;

		// Token: 0x04007C14 RID: 31764
		[AutoBind("./Detail", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject ExpressionDetailRoot;

		// Token: 0x04007C15 RID: 31765
		private const int SmallExpressionCount4OnePage = 24;

		// Token: 0x04007C16 RID: 31766
		private const int ExpressionPageEmptySpaceWidth = 100;

		// Token: 0x04007C17 RID: 31767
		[DoNotToLua]
		private ChatExpressionUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007C18 RID: 31768
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007C19 RID: 31769
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007C1A RID: 31770
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007C1B RID: 31771
		private LuaFunction m_Update_hotfix;

		// Token: 0x04007C1C RID: 31772
		private LuaFunction m_ShowOrHideExpressionPanelBoolean_hotfix;

		// Token: 0x04007C1D RID: 31773
		private LuaFunction m_SwitchExpressionPanel_hotfix;

		// Token: 0x04007C1E RID: 31774
		private LuaFunction m_DelayInstancePrefab_hotfix;

		// Token: 0x04007C1F RID: 31775
		private LuaFunction m_OnPointerUp4ExpressionScrollRectGameObject_hotfix;

		// Token: 0x04007C20 RID: 31776
		private LuaFunction m_OnSmallExpressionClickSmallExpressionItemContrller_hotfix;

		// Token: 0x04007C21 RID: 31777
		private LuaFunction m_OnExpressionBgButtonClickUIControllerBase_hotfix;

		// Token: 0x04007C22 RID: 31778
		private LuaFunction m_OnSmallExpressionToggleValueChangedBoolean_hotfix;

		// Token: 0x04007C23 RID: 31779
		private LuaFunction m_OnBigExpressionClickInt32_hotfix;

		// Token: 0x04007C24 RID: 31780
		private LuaFunction m_InitExpressionPageAndItem_hotfix;

		// Token: 0x04007C25 RID: 31781
		private LuaFunction m_SetSmallExpressionPageImmediateInt32_hotfix;

		// Token: 0x04007C26 RID: 31782
		private LuaFunction m_SetSmallExpressionPageInt32_hotfix;

		// Token: 0x04007C27 RID: 31783
		private LuaFunction m_add_EventOnSmallExpressionClickAction;

		// Token: 0x04007C28 RID: 31784
		private LuaFunction m_remove_EventOnSmallExpressionClickAction;

		// Token: 0x04007C29 RID: 31785
		private LuaFunction m_add_EventOnExpressionBgButtonClickAction_hotfix;

		// Token: 0x04007C2A RID: 31786
		private LuaFunction m_remove_EventOnExpressionBgButtonClickAction_hotfix;

		// Token: 0x02000B40 RID: 2880
		public new class LuaExportHelper
		{
			// Token: 0x0600C3BF RID: 50111 RVA: 0x003642B8 File Offset: 0x003624B8
			public LuaExportHelper(ChatExpressionUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C3C0 RID: 50112 RVA: 0x003642C8 File Offset: 0x003624C8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C3C1 RID: 50113 RVA: 0x003642D8 File Offset: 0x003624D8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C3C2 RID: 50114 RVA: 0x003642E8 File Offset: 0x003624E8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C3C3 RID: 50115 RVA: 0x003642F8 File Offset: 0x003624F8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C3C4 RID: 50116 RVA: 0x00364310 File Offset: 0x00362510
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C3C5 RID: 50117 RVA: 0x00364320 File Offset: 0x00362520
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C3C6 RID: 50118 RVA: 0x00364330 File Offset: 0x00362530
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C3C7 RID: 50119 RVA: 0x00364340 File Offset: 0x00362540
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C3C8 RID: 50120 RVA: 0x00364350 File Offset: 0x00362550
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C3C9 RID: 50121 RVA: 0x00364360 File Offset: 0x00362560
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C3CA RID: 50122 RVA: 0x00364370 File Offset: 0x00362570
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C3CB RID: 50123 RVA: 0x00364380 File Offset: 0x00362580
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C3CC RID: 50124 RVA: 0x00364390 File Offset: 0x00362590
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C3CD RID: 50125 RVA: 0x003643A0 File Offset: 0x003625A0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C3CE RID: 50126 RVA: 0x003643B0 File Offset: 0x003625B0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C3CF RID: 50127 RVA: 0x003643C0 File Offset: 0x003625C0
			public void __callDele_EventOnSmallExpressionClick(SmallExpressionItemContrller obj)
			{
				this.m_owner.__callDele_EventOnSmallExpressionClick(obj);
			}

			// Token: 0x0600C3D0 RID: 50128 RVA: 0x003643D0 File Offset: 0x003625D0
			public void __clearDele_EventOnSmallExpressionClick(SmallExpressionItemContrller obj)
			{
				this.m_owner.__clearDele_EventOnSmallExpressionClick(obj);
			}

			// Token: 0x0600C3D1 RID: 50129 RVA: 0x003643E0 File Offset: 0x003625E0
			public void __callDele_EventOnExpressionBgButtonClick()
			{
				this.m_owner.__callDele_EventOnExpressionBgButtonClick();
			}

			// Token: 0x0600C3D2 RID: 50130 RVA: 0x003643F0 File Offset: 0x003625F0
			public void __clearDele_EventOnExpressionBgButtonClick()
			{
				this.m_owner.__clearDele_EventOnExpressionBgButtonClick();
			}

			// Token: 0x1700273A RID: 10042
			// (get) Token: 0x0600C3D3 RID: 50131 RVA: 0x00364400 File Offset: 0x00362600
			// (set) Token: 0x0600C3D4 RID: 50132 RVA: 0x00364410 File Offset: 0x00362610
			public float m_emptySpaceNormalRatio
			{
				get
				{
					return this.m_owner.m_emptySpaceNormalRatio;
				}
				set
				{
					this.m_owner.m_emptySpaceNormalRatio = value;
				}
			}

			// Token: 0x1700273B RID: 10043
			// (get) Token: 0x0600C3D5 RID: 50133 RVA: 0x00364420 File Offset: 0x00362620
			// (set) Token: 0x0600C3D6 RID: 50134 RVA: 0x00364430 File Offset: 0x00362630
			public int m_currSmallPageIndex
			{
				get
				{
					return this.m_owner.m_currSmallPageIndex;
				}
				set
				{
					this.m_owner.m_currSmallPageIndex = value;
				}
			}

			// Token: 0x1700273C RID: 10044
			// (get) Token: 0x0600C3D7 RID: 50135 RVA: 0x00364440 File Offset: 0x00362640
			// (set) Token: 0x0600C3D8 RID: 50136 RVA: 0x00364450 File Offset: 0x00362650
			public List<CommonUIStateController> m_smallExpressionPagePointList
			{
				get
				{
					return this.m_owner.m_smallExpressionPagePointList;
				}
				set
				{
					this.m_owner.m_smallExpressionPagePointList = value;
				}
			}

			// Token: 0x1700273D RID: 10045
			// (get) Token: 0x0600C3D9 RID: 50137 RVA: 0x00364460 File Offset: 0x00362660
			// (set) Token: 0x0600C3DA RID: 50138 RVA: 0x00364470 File Offset: 0x00362670
			public List<KeyValuePair<float, float>> m_smallExpressionPageSubSectionList
			{
				get
				{
					return this.m_owner.m_smallExpressionPageSubSectionList;
				}
				set
				{
					this.m_owner.m_smallExpressionPageSubSectionList = value;
				}
			}

			// Token: 0x1700273E RID: 10046
			// (get) Token: 0x0600C3DB RID: 50139 RVA: 0x00364480 File Offset: 0x00362680
			// (set) Token: 0x0600C3DC RID: 50140 RVA: 0x00364490 File Offset: 0x00362690
			public List<SmallExpressionItemContrller> m_smallExpressionCtrlList
			{
				get
				{
					return this.m_owner.m_smallExpressionCtrlList;
				}
				set
				{
					this.m_owner.m_smallExpressionCtrlList = value;
				}
			}

			// Token: 0x1700273F RID: 10047
			// (get) Token: 0x0600C3DD RID: 50141 RVA: 0x003644A0 File Offset: 0x003626A0
			public static int SmallExpressionCount4OnePage
			{
				get
				{
					return 24;
				}
			}

			// Token: 0x17002740 RID: 10048
			// (get) Token: 0x0600C3DE RID: 50142 RVA: 0x003644A4 File Offset: 0x003626A4
			public static int ExpressionPageEmptySpaceWidth
			{
				get
				{
					return 100;
				}
			}

			// Token: 0x0600C3DF RID: 50143 RVA: 0x003644A8 File Offset: 0x003626A8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C3E0 RID: 50144 RVA: 0x003644B8 File Offset: 0x003626B8
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600C3E1 RID: 50145 RVA: 0x003644C8 File Offset: 0x003626C8
			public void OnPointerUp4ExpressionScrollRect(GameObject go)
			{
				this.m_owner.OnPointerUp4ExpressionScrollRect(go);
			}

			// Token: 0x0600C3E2 RID: 50146 RVA: 0x003644D8 File Offset: 0x003626D8
			public void OnSmallExpressionClick(SmallExpressionItemContrller uCtrl)
			{
				this.m_owner.OnSmallExpressionClick(uCtrl);
			}

			// Token: 0x0600C3E3 RID: 50147 RVA: 0x003644E8 File Offset: 0x003626E8
			public void OnExpressionBgButtonClick(UIControllerBase uCtrl)
			{
				this.m_owner.OnExpressionBgButtonClick(uCtrl);
			}

			// Token: 0x0600C3E4 RID: 50148 RVA: 0x003644F8 File Offset: 0x003626F8
			public void OnSmallExpressionToggleValueChanged(bool isSelected)
			{
				this.m_owner.OnSmallExpressionToggleValueChanged(isSelected);
			}

			// Token: 0x0600C3E5 RID: 50149 RVA: 0x00364508 File Offset: 0x00362708
			public void OnBigExpressionClick(int id)
			{
				this.m_owner.OnBigExpressionClick(id);
			}

			// Token: 0x0600C3E6 RID: 50150 RVA: 0x00364518 File Offset: 0x00362718
			public void SetSmallExpressionPageImmediate(int index)
			{
				this.m_owner.SetSmallExpressionPageImmediate(index);
			}

			// Token: 0x0600C3E7 RID: 50151 RVA: 0x00364528 File Offset: 0x00362728
			public IEnumerator SetSmallExpressionPage(int index)
			{
				return this.m_owner.SetSmallExpressionPage(index);
			}

			// Token: 0x04007C2B RID: 31787
			private ChatExpressionUIController m_owner;
		}
	}
}
