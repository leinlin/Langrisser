using System;
using System.Collections.Generic;
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
	// Token: 0x02000EB8 RID: 3768
	[HotFix]
	public class RankingSubMenuUIController : UIControllerBase, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x060126A5 RID: 75429 RVA: 0x004BA2C4 File Offset: 0x004B84C4
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
			if (this.EventOnNoneSubMenuAreaClick != null)
			{
				this.EventOnNoneSubMenuAreaClick();
			}
			this.PassEvent<IPointerClickHandler>(eventData, ExecuteEvents.pointerClickHandler);
		}

		// Token: 0x060126A6 RID: 75430 RVA: 0x004BA358 File Offset: 0x004B8558
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
		}

		// Token: 0x060126A7 RID: 75431 RVA: 0x004BA3C8 File Offset: 0x004B85C8
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
		}

		// Token: 0x060126A8 RID: 75432 RVA: 0x004BA438 File Offset: 0x004B8638
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
			if (this.EventOnNoneSubMenuAreaClick != null)
			{
				this.EventOnNoneSubMenuAreaClick();
			}
			this.PassEvent<IBeginDragHandler>(eventData, ExecuteEvents.beginDragHandler);
		}

		// Token: 0x060126A9 RID: 75433 RVA: 0x004BA4CC File Offset: 0x004B86CC
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
			if (this.EventOnNoneSubMenuAreaClick != null)
			{
				this.EventOnNoneSubMenuAreaClick();
			}
			this.PassEvent<IEndDragHandler>(eventData, ExecuteEvents.endDragHandler);
		}

		// Token: 0x060126AA RID: 75434 RVA: 0x004BA560 File Offset: 0x004B8760
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
			if (this.EventOnNoneSubMenuAreaClick != null)
			{
				this.EventOnNoneSubMenuAreaClick();
			}
			this.PassEvent<IDragHandler>(eventData, ExecuteEvents.dragHandler);
		}

		// Token: 0x060126AB RID: 75435 RVA: 0x004BA5F4 File Offset: 0x004B87F4
		public void PassEvent<T>(PointerEventData data, ExecuteEvents.EventFunction<T> function) where T : IEventSystemHandler
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PassEventPointerEventDataEventFunction`1_hotfix != null)
			{
				this.m_PassEventPointerEventDataEventFunction`1_hotfix.call(new object[]
				{
					this,
					data,
					function
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<RaycastResult> list = new List<RaycastResult>();
			EventSystem.current.RaycastAll(data, list);
			GameObject gameObject = data.pointerCurrentRaycast.gameObject;
			for (int i = 0; i < list.Count; i++)
			{
				if (gameObject != list[i].gameObject)
				{
					ExecuteEvents.ExecuteHierarchy<T>(list[i].gameObject, data, function);
					break;
				}
			}
		}

		// Token: 0x140003F2 RID: 1010
		// (add) Token: 0x060126AC RID: 75436 RVA: 0x004BA6E4 File Offset: 0x004B88E4
		// (remove) Token: 0x060126AD RID: 75437 RVA: 0x004BA780 File Offset: 0x004B8980
		public event Action EventOnNoneSubMenuAreaClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNoneSubMenuAreaClickAction_hotfix != null)
				{
					this.m_add_EventOnNoneSubMenuAreaClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNoneSubMenuAreaClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNoneSubMenuAreaClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNoneSubMenuAreaClickAction_hotfix != null)
				{
					this.m_remove_EventOnNoneSubMenuAreaClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNoneSubMenuAreaClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNoneSubMenuAreaClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x060126AE RID: 75438 RVA: 0x004BA81C File Offset: 0x004B8A1C
		// (set) Token: 0x060126AF RID: 75439 RVA: 0x004BA83C File Offset: 0x004B8A3C
		[DoNotToLua]
		public new RankingSubMenuUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RankingSubMenuUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060126B0 RID: 75440 RVA: 0x004BA848 File Offset: 0x004B8A48
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060126B1 RID: 75441 RVA: 0x004BA854 File Offset: 0x004B8A54
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060126B2 RID: 75442 RVA: 0x004BA85C File Offset: 0x004B8A5C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060126B3 RID: 75443 RVA: 0x004BA864 File Offset: 0x004B8A64
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060126B4 RID: 75444 RVA: 0x004BA878 File Offset: 0x004B8A78
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060126B5 RID: 75445 RVA: 0x004BA880 File Offset: 0x004B8A80
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060126B6 RID: 75446 RVA: 0x004BA88C File Offset: 0x004B8A8C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060126B7 RID: 75447 RVA: 0x004BA898 File Offset: 0x004B8A98
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060126B8 RID: 75448 RVA: 0x004BA8A4 File Offset: 0x004B8AA4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060126B9 RID: 75449 RVA: 0x004BA8B0 File Offset: 0x004B8AB0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060126BA RID: 75450 RVA: 0x004BA8BC File Offset: 0x004B8ABC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060126BB RID: 75451 RVA: 0x004BA8C8 File Offset: 0x004B8AC8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060126BC RID: 75452 RVA: 0x004BA8D4 File Offset: 0x004B8AD4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060126BD RID: 75453 RVA: 0x004BA8E0 File Offset: 0x004B8AE0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060126BE RID: 75454 RVA: 0x004BA8EC File Offset: 0x004B8AEC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060126BF RID: 75455 RVA: 0x004BA8F4 File Offset: 0x004B8AF4
		private void __callDele_EventOnNoneSubMenuAreaClick()
		{
			Action eventOnNoneSubMenuAreaClick = this.EventOnNoneSubMenuAreaClick;
			if (eventOnNoneSubMenuAreaClick != null)
			{
				eventOnNoneSubMenuAreaClick();
			}
		}

		// Token: 0x060126C0 RID: 75456 RVA: 0x004BA914 File Offset: 0x004B8B14
		private void __clearDele_EventOnNoneSubMenuAreaClick()
		{
			this.EventOnNoneSubMenuAreaClick = null;
		}

		// Token: 0x060126C1 RID: 75457 RVA: 0x004BA920 File Offset: 0x004B8B20
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
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_OnDragPointerEventData_hotfix = (luaObj.RawGet("OnDrag") as LuaFunction);
					this.m_PassEventPointerEventDataEventFunction`1_hotfix = (luaObj.RawGet("PassEvent") as LuaFunction);
					this.m_add_EventOnNoneSubMenuAreaClickAction_hotfix = (luaObj.RawGet("add_EventOnNoneSubMenuAreaClick") as LuaFunction);
					this.m_remove_EventOnNoneSubMenuAreaClickAction_hotfix = (luaObj.RawGet("remove_EventOnNoneSubMenuAreaClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060126C2 RID: 75458 RVA: 0x004BAAB4 File Offset: 0x004B8CB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RankingSubMenuUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A5B5 RID: 42421
		[DoNotToLua]
		private RankingSubMenuUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A5B6 RID: 42422
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A5B7 RID: 42423
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A5B8 RID: 42424
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x0400A5B9 RID: 42425
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x0400A5BA RID: 42426
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x0400A5BB RID: 42427
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x0400A5BC RID: 42428
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x0400A5BD RID: 42429
		private LuaFunction m_OnDragPointerEventData_hotfix;

		// Token: 0x0400A5BE RID: 42430
		private LuaFunction m_PassEventPointerEventDataEventFunction;

		// Token: 0x0400A5BF RID: 42431
		private LuaFunction m_add_EventOnNoneSubMenuAreaClickAction_hotfix;

		// Token: 0x0400A5C0 RID: 42432
		private LuaFunction m_remove_EventOnNoneSubMenuAreaClickAction_hotfix;

		// Token: 0x02000EB9 RID: 3769
		public new class LuaExportHelper
		{
			// Token: 0x060126C3 RID: 75459 RVA: 0x004BAB1C File Offset: 0x004B8D1C
			public LuaExportHelper(RankingSubMenuUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060126C4 RID: 75460 RVA: 0x004BAB2C File Offset: 0x004B8D2C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060126C5 RID: 75461 RVA: 0x004BAB3C File Offset: 0x004B8D3C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060126C6 RID: 75462 RVA: 0x004BAB4C File Offset: 0x004B8D4C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060126C7 RID: 75463 RVA: 0x004BAB5C File Offset: 0x004B8D5C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060126C8 RID: 75464 RVA: 0x004BAB74 File Offset: 0x004B8D74
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060126C9 RID: 75465 RVA: 0x004BAB84 File Offset: 0x004B8D84
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060126CA RID: 75466 RVA: 0x004BAB94 File Offset: 0x004B8D94
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060126CB RID: 75467 RVA: 0x004BABA4 File Offset: 0x004B8DA4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060126CC RID: 75468 RVA: 0x004BABB4 File Offset: 0x004B8DB4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060126CD RID: 75469 RVA: 0x004BABC4 File Offset: 0x004B8DC4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060126CE RID: 75470 RVA: 0x004BABD4 File Offset: 0x004B8DD4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060126CF RID: 75471 RVA: 0x004BABE4 File Offset: 0x004B8DE4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060126D0 RID: 75472 RVA: 0x004BABF4 File Offset: 0x004B8DF4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060126D1 RID: 75473 RVA: 0x004BAC04 File Offset: 0x004B8E04
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060126D2 RID: 75474 RVA: 0x004BAC14 File Offset: 0x004B8E14
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060126D3 RID: 75475 RVA: 0x004BAC24 File Offset: 0x004B8E24
			public void __callDele_EventOnNoneSubMenuAreaClick()
			{
				this.m_owner.__callDele_EventOnNoneSubMenuAreaClick();
			}

			// Token: 0x060126D4 RID: 75476 RVA: 0x004BAC34 File Offset: 0x004B8E34
			public void __clearDele_EventOnNoneSubMenuAreaClick()
			{
				this.m_owner.__clearDele_EventOnNoneSubMenuAreaClick();
			}

			// Token: 0x0400A5C1 RID: 42433
			private RankingSubMenuUIController m_owner;
		}
	}
}
