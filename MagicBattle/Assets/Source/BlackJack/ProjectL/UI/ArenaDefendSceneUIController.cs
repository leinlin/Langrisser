using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009F6 RID: 2550
	[HotFix]
	public class ArenaDefendSceneUIController : UIControllerBase, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x06009794 RID: 38804 RVA: 0x002B485C File Offset: 0x002B2A5C
		private ArenaDefendSceneUIController()
		{
		}

		// Token: 0x06009795 RID: 38805 RVA: 0x002B4888 File Offset: 0x002B2A88
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
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x002B48F0 File Offset: 0x002B2AF0
		public void OnPointerDown(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerDownPointerEventData_hotfix != null)
			{
				this.m_OnPointerDownPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_downPointerId != -1000)
			{
				return;
			}
			this.m_downPointerId = (this.m_clickPointerId = eventData.pointerId);
			if (this.EventOnPointerDown != null)
			{
				this.EventOnPointerDown(eventData);
			}
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x002B49A0 File Offset: 0x002B2BA0
		public void OnPointerUp(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerUpPointerEventData_hotfix != null)
			{
				this.m_OnPointerUpPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_downPointerId)
			{
				return;
			}
			this.m_downPointerId = -1000;
			if (this.EventOnPointerUp != null)
			{
				this.EventOnPointerUp(eventData);
			}
		}

		// Token: 0x06009798 RID: 38808 RVA: 0x002B4A44 File Offset: 0x002B2C44
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_clickPointerId)
			{
				return;
			}
			this.m_clickPointerId = -1000;
			if (this.EventOnPointerClick != null)
			{
				this.EventOnPointerClick(eventData);
			}
		}

		// Token: 0x06009799 RID: 38809 RVA: 0x002B4AE8 File Offset: 0x002B2CE8
		public void OnBeginDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBeginDragPointerEventData_hotfix != null)
			{
				this.m_OnBeginDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_downPointerId)
			{
				return;
			}
			this.m_dragPointerId = eventData.pointerId;
			if (this.EventOnBeginDrag != null)
			{
				this.EventOnBeginDrag(eventData);
			}
		}

		// Token: 0x0600979A RID: 38810 RVA: 0x002B4B90 File Offset: 0x002B2D90
		public void OnEndDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndDragPointerEventData_hotfix != null)
			{
				this.m_OnEndDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_dragPointerId)
			{
				return;
			}
			this.m_dragPointerId = -1000;
			if (this.EventOnEndDrag != null)
			{
				this.EventOnEndDrag(eventData);
			}
		}

		// Token: 0x0600979B RID: 38811 RVA: 0x002B4C34 File Offset: 0x002B2E34
		public void OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDragPointerEventData_hotfix != null)
			{
				this.m_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_dragPointerId)
			{
				return;
			}
			if (this.EventOnDrag != null)
			{
				this.EventOnDrag(eventData);
			}
		}

		// Token: 0x140001A4 RID: 420
		// (add) Token: 0x0600979C RID: 38812 RVA: 0x002B4CD0 File Offset: 0x002B2ED0
		// (remove) Token: 0x0600979D RID: 38813 RVA: 0x002B4D6C File Offset: 0x002B2F6C
		public event Action<PointerEventData> EventOnPointerDown
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerDownAction`1_hotfix != null)
				{
					this.m_add_EventOnPointerDownAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerDown;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerDown, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerDownAction`1_hotfix != null)
				{
					this.m_remove_EventOnPointerDownAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerDown;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerDown, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001A5 RID: 421
		// (add) Token: 0x0600979E RID: 38814 RVA: 0x002B4E08 File Offset: 0x002B3008
		// (remove) Token: 0x0600979F RID: 38815 RVA: 0x002B4EA4 File Offset: 0x002B30A4
		public event Action<PointerEventData> EventOnPointerUp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerUpAction`1_hotfix != null)
				{
					this.m_add_EventOnPointerUpAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerUp;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerUp, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerUpAction`1_hotfix != null)
				{
					this.m_remove_EventOnPointerUpAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerUp;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerUp, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001A6 RID: 422
		// (add) Token: 0x060097A0 RID: 38816 RVA: 0x002B4F40 File Offset: 0x002B3140
		// (remove) Token: 0x060097A1 RID: 38817 RVA: 0x002B4FDC File Offset: 0x002B31DC
		public event Action<PointerEventData> EventOnPointerClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerClickAction`1_hotfix != null)
				{
					this.m_add_EventOnPointerClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerClick;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerClick, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnPointerClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnPointerClick;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnPointerClick, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001A7 RID: 423
		// (add) Token: 0x060097A2 RID: 38818 RVA: 0x002B5078 File Offset: 0x002B3278
		// (remove) Token: 0x060097A3 RID: 38819 RVA: 0x002B5114 File Offset: 0x002B3314
		public event Action<PointerEventData> EventOnBeginDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBeginDragAction`1_hotfix != null)
				{
					this.m_add_EventOnBeginDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnBeginDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnBeginDrag, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBeginDragAction`1_hotfix != null)
				{
					this.m_remove_EventOnBeginDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnBeginDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnBeginDrag, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001A8 RID: 424
		// (add) Token: 0x060097A4 RID: 38820 RVA: 0x002B51B0 File Offset: 0x002B33B0
		// (remove) Token: 0x060097A5 RID: 38821 RVA: 0x002B524C File Offset: 0x002B344C
		public event Action<PointerEventData> EventOnEndDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndDragAction`1_hotfix != null)
				{
					this.m_add_EventOnEndDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnEndDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnEndDrag, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndDragAction`1_hotfix != null)
				{
					this.m_remove_EventOnEndDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnEndDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnEndDrag, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001A9 RID: 425
		// (add) Token: 0x060097A6 RID: 38822 RVA: 0x002B52E8 File Offset: 0x002B34E8
		// (remove) Token: 0x060097A7 RID: 38823 RVA: 0x002B5384 File Offset: 0x002B3584
		public event Action<PointerEventData> EventOnDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDragAction`1_hotfix != null)
				{
					this.m_add_EventOnDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrag, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDragAction`1_hotfix != null)
				{
					this.m_remove_EventOnDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrag, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x060097A8 RID: 38824 RVA: 0x002B5420 File Offset: 0x002B3620
		// (set) Token: 0x060097A9 RID: 38825 RVA: 0x002B5440 File Offset: 0x002B3640
		[DoNotToLua]
		public new ArenaDefendSceneUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaDefendSceneUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060097AA RID: 38826 RVA: 0x002B544C File Offset: 0x002B364C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060097AB RID: 38827 RVA: 0x002B5458 File Offset: 0x002B3658
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060097AC RID: 38828 RVA: 0x002B5460 File Offset: 0x002B3660
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060097AD RID: 38829 RVA: 0x002B5468 File Offset: 0x002B3668
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060097AE RID: 38830 RVA: 0x002B547C File Offset: 0x002B367C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060097AF RID: 38831 RVA: 0x002B5484 File Offset: 0x002B3684
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060097B0 RID: 38832 RVA: 0x002B5490 File Offset: 0x002B3690
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x002B549C File Offset: 0x002B369C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x002B54A8 File Offset: 0x002B36A8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x002B54B4 File Offset: 0x002B36B4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060097B4 RID: 38836 RVA: 0x002B54C0 File Offset: 0x002B36C0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060097B5 RID: 38837 RVA: 0x002B54CC File Offset: 0x002B36CC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x002B54D8 File Offset: 0x002B36D8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060097B7 RID: 38839 RVA: 0x002B54E4 File Offset: 0x002B36E4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060097B8 RID: 38840 RVA: 0x002B54F0 File Offset: 0x002B36F0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060097B9 RID: 38841 RVA: 0x002B54F8 File Offset: 0x002B36F8
		private void __callDele_EventOnPointerDown(PointerEventData obj)
		{
			Action<PointerEventData> eventOnPointerDown = this.EventOnPointerDown;
			if (eventOnPointerDown != null)
			{
				eventOnPointerDown(obj);
			}
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x002B551C File Offset: 0x002B371C
		private void __clearDele_EventOnPointerDown(PointerEventData obj)
		{
			this.EventOnPointerDown = null;
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x002B5528 File Offset: 0x002B3728
		private void __callDele_EventOnPointerUp(PointerEventData obj)
		{
			Action<PointerEventData> eventOnPointerUp = this.EventOnPointerUp;
			if (eventOnPointerUp != null)
			{
				eventOnPointerUp(obj);
			}
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x002B554C File Offset: 0x002B374C
		private void __clearDele_EventOnPointerUp(PointerEventData obj)
		{
			this.EventOnPointerUp = null;
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x002B5558 File Offset: 0x002B3758
		private void __callDele_EventOnPointerClick(PointerEventData obj)
		{
			Action<PointerEventData> eventOnPointerClick = this.EventOnPointerClick;
			if (eventOnPointerClick != null)
			{
				eventOnPointerClick(obj);
			}
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x002B557C File Offset: 0x002B377C
		private void __clearDele_EventOnPointerClick(PointerEventData obj)
		{
			this.EventOnPointerClick = null;
		}

		// Token: 0x060097BF RID: 38847 RVA: 0x002B5588 File Offset: 0x002B3788
		private void __callDele_EventOnBeginDrag(PointerEventData obj)
		{
			Action<PointerEventData> eventOnBeginDrag = this.EventOnBeginDrag;
			if (eventOnBeginDrag != null)
			{
				eventOnBeginDrag(obj);
			}
		}

		// Token: 0x060097C0 RID: 38848 RVA: 0x002B55AC File Offset: 0x002B37AC
		private void __clearDele_EventOnBeginDrag(PointerEventData obj)
		{
			this.EventOnBeginDrag = null;
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x002B55B8 File Offset: 0x002B37B8
		private void __callDele_EventOnEndDrag(PointerEventData obj)
		{
			Action<PointerEventData> eventOnEndDrag = this.EventOnEndDrag;
			if (eventOnEndDrag != null)
			{
				eventOnEndDrag(obj);
			}
		}

		// Token: 0x060097C2 RID: 38850 RVA: 0x002B55DC File Offset: 0x002B37DC
		private void __clearDele_EventOnEndDrag(PointerEventData obj)
		{
			this.EventOnEndDrag = null;
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x002B55E8 File Offset: 0x002B37E8
		private void __callDele_EventOnDrag(PointerEventData obj)
		{
			Action<PointerEventData> eventOnDrag = this.EventOnDrag;
			if (eventOnDrag != null)
			{
				eventOnDrag(obj);
			}
		}

		// Token: 0x060097C4 RID: 38852 RVA: 0x002B560C File Offset: 0x002B380C
		private void __clearDele_EventOnDrag(PointerEventData obj)
		{
			this.EventOnDrag = null;
		}

		// Token: 0x060097C5 RID: 38853 RVA: 0x002B5618 File Offset: 0x002B3818
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
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_OnDragPointerEventData_hotfix = (luaObj.RawGet("OnDrag") as LuaFunction);
					this.m_add_EventOnPointerDownAction`1_hotfix = (luaObj.RawGet("add_EventOnPointerDown") as LuaFunction);
					this.m_remove_EventOnPointerDownAction`1_hotfix = (luaObj.RawGet("remove_EventOnPointerDown") as LuaFunction);
					this.m_add_EventOnPointerUpAction`1_hotfix = (luaObj.RawGet("add_EventOnPointerUp") as LuaFunction);
					this.m_remove_EventOnPointerUpAction`1_hotfix = (luaObj.RawGet("remove_EventOnPointerUp") as LuaFunction);
					this.m_add_EventOnPointerClickAction`1_hotfix = (luaObj.RawGet("add_EventOnPointerClick") as LuaFunction);
					this.m_remove_EventOnPointerClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnPointerClick") as LuaFunction);
					this.m_add_EventOnBeginDragAction`1_hotfix = (luaObj.RawGet("add_EventOnBeginDrag") as LuaFunction);
					this.m_remove_EventOnBeginDragAction`1_hotfix = (luaObj.RawGet("remove_EventOnBeginDrag") as LuaFunction);
					this.m_add_EventOnEndDragAction`1_hotfix = (luaObj.RawGet("add_EventOnEndDrag") as LuaFunction);
					this.m_remove_EventOnEndDragAction`1_hotfix = (luaObj.RawGet("remove_EventOnEndDrag") as LuaFunction);
					this.m_add_EventOnDragAction`1_hotfix = (luaObj.RawGet("add_EventOnDrag") as LuaFunction);
					this.m_remove_EventOnDragAction`1_hotfix = (luaObj.RawGet("remove_EventOnDrag") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060097C6 RID: 38854 RVA: 0x002B58A8 File Offset: 0x002B3AA8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaDefendSceneUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006838 RID: 26680
		private const int InvalidPointerID = -1000;

		// Token: 0x04006839 RID: 26681
		private int m_downPointerId = -1000;

		// Token: 0x0400683A RID: 26682
		private int m_clickPointerId = -1000;

		// Token: 0x0400683B RID: 26683
		private int m_dragPointerId = -1000;

		// Token: 0x0400683C RID: 26684
		[DoNotToLua]
		private ArenaDefendSceneUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400683D RID: 26685
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400683E RID: 26686
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400683F RID: 26687
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006840 RID: 26688
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x04006841 RID: 26689
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x04006842 RID: 26690
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x04006843 RID: 26691
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x04006844 RID: 26692
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x04006845 RID: 26693
		private LuaFunction m_OnDragPointerEventData_hotfix;

		// Token: 0x04006846 RID: 26694
		private LuaFunction m_add_EventOnPointerDownAction;

		// Token: 0x04006847 RID: 26695
		private LuaFunction m_remove_EventOnPointerDownAction;

		// Token: 0x04006848 RID: 26696
		private LuaFunction m_add_EventOnPointerUpAction;

		// Token: 0x04006849 RID: 26697
		private LuaFunction m_remove_EventOnPointerUpAction;

		// Token: 0x0400684A RID: 26698
		private LuaFunction m_add_EventOnPointerClickAction;

		// Token: 0x0400684B RID: 26699
		private LuaFunction m_remove_EventOnPointerClickAction;

		// Token: 0x0400684C RID: 26700
		private LuaFunction m_add_EventOnBeginDragAction;

		// Token: 0x0400684D RID: 26701
		private LuaFunction m_remove_EventOnBeginDragAction;

		// Token: 0x0400684E RID: 26702
		private LuaFunction m_add_EventOnEndDragAction;

		// Token: 0x0400684F RID: 26703
		private LuaFunction m_remove_EventOnEndDragAction;

		// Token: 0x04006850 RID: 26704
		private LuaFunction m_add_EventOnDragAction;

		// Token: 0x04006851 RID: 26705
		private LuaFunction m_remove_EventOnDragAction;

		// Token: 0x020009F7 RID: 2551
		public new class LuaExportHelper
		{
			// Token: 0x060097C7 RID: 38855 RVA: 0x002B5910 File Offset: 0x002B3B10
			public LuaExportHelper(ArenaDefendSceneUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060097C8 RID: 38856 RVA: 0x002B5920 File Offset: 0x002B3B20
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060097C9 RID: 38857 RVA: 0x002B5930 File Offset: 0x002B3B30
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060097CA RID: 38858 RVA: 0x002B5940 File Offset: 0x002B3B40
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060097CB RID: 38859 RVA: 0x002B5950 File Offset: 0x002B3B50
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060097CC RID: 38860 RVA: 0x002B5968 File Offset: 0x002B3B68
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060097CD RID: 38861 RVA: 0x002B5978 File Offset: 0x002B3B78
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060097CE RID: 38862 RVA: 0x002B5988 File Offset: 0x002B3B88
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060097CF RID: 38863 RVA: 0x002B5998 File Offset: 0x002B3B98
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060097D0 RID: 38864 RVA: 0x002B59A8 File Offset: 0x002B3BA8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060097D1 RID: 38865 RVA: 0x002B59B8 File Offset: 0x002B3BB8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060097D2 RID: 38866 RVA: 0x002B59C8 File Offset: 0x002B3BC8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060097D3 RID: 38867 RVA: 0x002B59D8 File Offset: 0x002B3BD8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060097D4 RID: 38868 RVA: 0x002B59E8 File Offset: 0x002B3BE8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060097D5 RID: 38869 RVA: 0x002B59F8 File Offset: 0x002B3BF8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060097D6 RID: 38870 RVA: 0x002B5A08 File Offset: 0x002B3C08
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060097D7 RID: 38871 RVA: 0x002B5A18 File Offset: 0x002B3C18
			public void __callDele_EventOnPointerDown(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnPointerDown(obj);
			}

			// Token: 0x060097D8 RID: 38872 RVA: 0x002B5A28 File Offset: 0x002B3C28
			public void __clearDele_EventOnPointerDown(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnPointerDown(obj);
			}

			// Token: 0x060097D9 RID: 38873 RVA: 0x002B5A38 File Offset: 0x002B3C38
			public void __callDele_EventOnPointerUp(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnPointerUp(obj);
			}

			// Token: 0x060097DA RID: 38874 RVA: 0x002B5A48 File Offset: 0x002B3C48
			public void __clearDele_EventOnPointerUp(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnPointerUp(obj);
			}

			// Token: 0x060097DB RID: 38875 RVA: 0x002B5A58 File Offset: 0x002B3C58
			public void __callDele_EventOnPointerClick(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnPointerClick(obj);
			}

			// Token: 0x060097DC RID: 38876 RVA: 0x002B5A68 File Offset: 0x002B3C68
			public void __clearDele_EventOnPointerClick(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnPointerClick(obj);
			}

			// Token: 0x060097DD RID: 38877 RVA: 0x002B5A78 File Offset: 0x002B3C78
			public void __callDele_EventOnBeginDrag(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnBeginDrag(obj);
			}

			// Token: 0x060097DE RID: 38878 RVA: 0x002B5A88 File Offset: 0x002B3C88
			public void __clearDele_EventOnBeginDrag(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnBeginDrag(obj);
			}

			// Token: 0x060097DF RID: 38879 RVA: 0x002B5A98 File Offset: 0x002B3C98
			public void __callDele_EventOnEndDrag(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnEndDrag(obj);
			}

			// Token: 0x060097E0 RID: 38880 RVA: 0x002B5AA8 File Offset: 0x002B3CA8
			public void __clearDele_EventOnEndDrag(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnEndDrag(obj);
			}

			// Token: 0x060097E1 RID: 38881 RVA: 0x002B5AB8 File Offset: 0x002B3CB8
			public void __callDele_EventOnDrag(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnDrag(obj);
			}

			// Token: 0x060097E2 RID: 38882 RVA: 0x002B5AC8 File Offset: 0x002B3CC8
			public void __clearDele_EventOnDrag(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnDrag(obj);
			}

			// Token: 0x17001F3F RID: 7999
			// (get) Token: 0x060097E3 RID: 38883 RVA: 0x002B5AD8 File Offset: 0x002B3CD8
			public static int InvalidPointerID
			{
				get
				{
					return -1000;
				}
			}

			// Token: 0x17001F40 RID: 8000
			// (get) Token: 0x060097E4 RID: 38884 RVA: 0x002B5AE0 File Offset: 0x002B3CE0
			// (set) Token: 0x060097E5 RID: 38885 RVA: 0x002B5AF0 File Offset: 0x002B3CF0
			public int m_downPointerId
			{
				get
				{
					return this.m_owner.m_downPointerId;
				}
				set
				{
					this.m_owner.m_downPointerId = value;
				}
			}

			// Token: 0x17001F41 RID: 8001
			// (get) Token: 0x060097E6 RID: 38886 RVA: 0x002B5B00 File Offset: 0x002B3D00
			// (set) Token: 0x060097E7 RID: 38887 RVA: 0x002B5B10 File Offset: 0x002B3D10
			public int m_clickPointerId
			{
				get
				{
					return this.m_owner.m_clickPointerId;
				}
				set
				{
					this.m_owner.m_clickPointerId = value;
				}
			}

			// Token: 0x17001F42 RID: 8002
			// (get) Token: 0x060097E8 RID: 38888 RVA: 0x002B5B20 File Offset: 0x002B3D20
			// (set) Token: 0x060097E9 RID: 38889 RVA: 0x002B5B30 File Offset: 0x002B3D30
			public int m_dragPointerId
			{
				get
				{
					return this.m_owner.m_dragPointerId;
				}
				set
				{
					this.m_owner.m_dragPointerId = value;
				}
			}

			// Token: 0x060097EA RID: 38890 RVA: 0x002B5B40 File Offset: 0x002B3D40
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04006852 RID: 26706
			private ArenaDefendSceneUIController m_owner;
		}
	}
}
