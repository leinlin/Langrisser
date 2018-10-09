using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Art;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BF0 RID: 3056
	[HotFix]
	public class PointDescComponent : UIControllerBase, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x0600D53F RID: 54591 RVA: 0x003A2640 File Offset: 0x003A0840
		public void SetGameObject(GameObject addComponentRoot, bool isNeedExcuteEvent, GameObject addReturnImageRoot = null, GameObject checkBoundaryGo = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGameObjectGameObjectBooleanGameObjectGameObject_hotfix != null)
			{
				this.m_SetGameObjectGameObjectBooleanGameObjectGameObject_hotfix.call(new object[]
				{
					this,
					addComponentRoot,
					isNeedExcuteEvent,
					addReturnImageRoot,
					checkBoundaryGo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (addReturnImageRoot == null)
			{
				addReturnImageRoot = addComponentRoot;
			}
			this.IsNeedExcuteEvent = isNeedExcuteEvent;
			for (int i = 0; i < addReturnImageRoot.transform.childCount; i++)
			{
				Transform child = addReturnImageRoot.transform.GetChild(i);
				if (child.name == "ReturnBgImage" && child.GetComponent<EmptyImage>() != null)
				{
					return;
				}
			}
			this.emptyImageGo = new GameObject();
			this.emptyImageGo.AddComponent<EmptyImage>();
			RectTransform component = this.emptyImageGo.GetComponent<RectTransform>();
			component.sizeDelta = new Vector2(10000f, 10000f);
			this.emptyImageGo.name = "ReturnBgImage";
			if (isNeedExcuteEvent)
			{
				this.emptyImageGo.tag = "ExcuteEventImage";
			}
			else
			{
				this.emptyImageGo.tag = "Untagged";
			}
			this.emptyImageGo.transform.SetParent(addReturnImageRoot.transform, false);
			this.emptyImageGo.transform.SetAsFirstSibling();
			if (checkBoundaryGo != null)
			{
				this.m_checkBoundaryGo = checkBoundaryGo;
			}
			else
			{
				this.m_checkBoundaryGo = addComponentRoot;
			}
			GameObjectUtility.AddControllerToGameObject<AndroidBackEventListener>(addReturnImageRoot);
		}

		// Token: 0x0600D540 RID: 54592 RVA: 0x003A2808 File Offset: 0x003A0A08
		public void ShowReturnBgImage(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowReturnBgImageBoolean_hotfix != null)
			{
				this.m_ShowReturnBgImageBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.emptyImageGo != null)
			{
				this.emptyImageGo.SetActive(isShow);
			}
		}

		// Token: 0x0600D541 RID: 54593 RVA: 0x003A2898 File Offset: 0x003A0A98
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
			if (!this.CheckPositionBoundary(eventData) && !this.m_isDragging)
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
				this.PassEvent<IPointerClickHandler>(eventData, ExecuteEvents.pointerClickHandler);
			}
		}

		// Token: 0x0600D542 RID: 54594 RVA: 0x003A2944 File Offset: 0x003A0B44
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
			if (!this.CheckPositionBoundary(eventData) && !this.m_isDragging)
			{
				this.PassEvent<IPointerEnterHandler>(eventData, ExecuteEvents.pointerEnterHandler);
				this.PassEvent<IPointerDownHandler>(eventData, ExecuteEvents.pointerDownHandler);
			}
		}

		// Token: 0x0600D543 RID: 54595 RVA: 0x003A29E8 File Offset: 0x003A0BE8
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
			if (!this.CheckPositionBoundary(eventData) && !this.m_isDragging)
			{
				this.PassEvent<IPointerUpHandler>(eventData, ExecuteEvents.pointerUpHandler);
			}
			this.PassEvent<IPointerExitHandler>(eventData, ExecuteEvents.pointerExitHandler);
		}

		// Token: 0x0600D544 RID: 54596 RVA: 0x003A2A8C File Offset: 0x003A0C8C
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
			this.PassEvent<IBeginDragHandler>(eventData, ExecuteEvents.beginDragHandler);
		}

		// Token: 0x0600D545 RID: 54597 RVA: 0x003A2B08 File Offset: 0x003A0D08
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
			this.PassEvent<IEndDragHandler>(eventData, ExecuteEvents.endDragHandler);
		}

		// Token: 0x0600D546 RID: 54598 RVA: 0x003A2B84 File Offset: 0x003A0D84
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
			if (this.m_isDragging)
			{
				this.PassEvent<IDragHandler>(eventData, ExecuteEvents.dragHandler);
			}
		}

		// Token: 0x0600D547 RID: 54599 RVA: 0x003A2C0C File Offset: 0x003A0E0C
		private bool CheckPositionBoundary(PointerEventData data)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckPositionBoundaryPointerEventData_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckPositionBoundaryPointerEventData_hotfix.call(new object[]
				{
					this,
					data
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_checkBoundaryGo == null || RectTransformUtility.RectangleContainsScreenPoint(this.m_checkBoundaryGo.GetComponent<RectTransform>(), data.position, base.gameObject.GetComponentInParent<Camera>());
		}

		// Token: 0x0600D548 RID: 54600 RVA: 0x003A2CBC File Offset: 0x003A0EBC
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
			if (!this.IsNeedExcuteEvent)
			{
				return;
			}
			List<RaycastResult> list = new List<RaycastResult>();
			EventSystem.current.RaycastAll(data, list);
			GameObject gameObject = data.pointerCurrentRaycast.gameObject;
			GameObject gameObject2 = null;
			for (int i = 0; i < list.Count; i++)
			{
				if (gameObject != list[i].gameObject)
				{
					if (!list[i].gameObject.transform.IsChildOf(base.gameObject.transform))
					{
						if (typeof(T) == typeof(IBeginDragHandler))
						{
							this.m_draggingGo = list[i].gameObject;
							gameObject2 = this.m_draggingGo;
							this.m_isDragging = (this.m_draggingGo.GetComponentInParent<ScrollRect>() != null);
						}
						else if (typeof(T) == typeof(IDragHandler))
						{
							gameObject2 = this.m_draggingGo;
						}
						else if (typeof(T) == typeof(IEndDragHandler))
						{
							this.m_isDragging = false;
							gameObject2 = this.m_draggingGo;
							this.m_draggingGo = null;
						}
						else if (typeof(T) == typeof(IPointerDownHandler))
						{
							this.m_downGo = list[i].gameObject;
							gameObject2 = this.m_downGo;
						}
						else if (typeof(T) == typeof(IPointerEnterHandler))
						{
							this.m_enterGo = list[i].gameObject;
							gameObject2 = this.m_enterGo;
						}
						else
						{
							gameObject2 = list[i].gameObject;
						}
						ExecuteEvents.ExecuteHierarchy<T>(gameObject2, data, function);
						break;
					}
				}
				else if (gameObject != this.m_downGo)
				{
					if (typeof(T) == typeof(IPointerUpHandler))
					{
						ExecuteEvents.ExecuteHierarchy<T>(this.m_downGo, data, function);
						break;
					}
					if (typeof(T) == typeof(IPointerExitHandler))
					{
						ExecuteEvents.ExecuteHierarchy<T>(this.m_enterGo, data, function);
						break;
					}
				}
				else if (gameObject != this.m_enterGo && typeof(T) == typeof(IPointerExitHandler))
				{
					ExecuteEvents.ExecuteHierarchy<T>(this.m_enterGo, data, function);
					break;
				}
			}
			if (list.Count == 0)
			{
				if (typeof(T) == typeof(IEndDragHandler))
				{
					this.m_isDragging = false;
					gameObject2 = this.m_draggingGo;
					this.m_draggingGo = null;
				}
				else if (typeof(T) == typeof(IPointerUpHandler) || typeof(T) == typeof(IPointerClickHandler))
				{
					gameObject2 = this.m_downGo;
					this.m_downGo = null;
				}
				else if (typeof(T) == typeof(IPointerExitHandler))
				{
					gameObject2 = this.m_enterGo;
					this.m_enterGo = null;
				}
				if (gameObject2 != null)
				{
					ExecuteEvents.ExecuteHierarchy<T>(gameObject2, data, function);
				}
			}
		}

		// Token: 0x140002A7 RID: 679
		// (add) Token: 0x0600D549 RID: 54601 RVA: 0x003A3080 File Offset: 0x003A1280
		// (remove) Token: 0x0600D54A RID: 54602 RVA: 0x003A311C File Offset: 0x003A131C
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

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x0600D54C RID: 54604 RVA: 0x003A3230 File Offset: 0x003A1430
		// (set) Token: 0x0600D54B RID: 54603 RVA: 0x003A31B8 File Offset: 0x003A13B8
		public bool IsNeedExcuteEvent
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsNeedExcuteEvent_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsNeedExcuteEvent_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsNeedExcuteEvent>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IsNeedExcuteEventBoolean_hotfix != null)
				{
					this.m_set_IsNeedExcuteEventBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsNeedExcuteEvent>k__BackingField = value;
			}
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x0600D54D RID: 54605 RVA: 0x003A32A4 File Offset: 0x003A14A4
		// (set) Token: 0x0600D54E RID: 54606 RVA: 0x003A32C4 File Offset: 0x003A14C4
		[DoNotToLua]
		public new PointDescComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PointDescComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D54F RID: 54607 RVA: 0x003A32D0 File Offset: 0x003A14D0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D550 RID: 54608 RVA: 0x003A32DC File Offset: 0x003A14DC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D551 RID: 54609 RVA: 0x003A32E4 File Offset: 0x003A14E4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D552 RID: 54610 RVA: 0x003A32EC File Offset: 0x003A14EC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D553 RID: 54611 RVA: 0x003A3300 File Offset: 0x003A1500
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D554 RID: 54612 RVA: 0x003A3308 File Offset: 0x003A1508
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D555 RID: 54613 RVA: 0x003A3314 File Offset: 0x003A1514
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D556 RID: 54614 RVA: 0x003A3320 File Offset: 0x003A1520
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D557 RID: 54615 RVA: 0x003A332C File Offset: 0x003A152C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D558 RID: 54616 RVA: 0x003A3338 File Offset: 0x003A1538
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D559 RID: 54617 RVA: 0x003A3344 File Offset: 0x003A1544
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D55A RID: 54618 RVA: 0x003A3350 File Offset: 0x003A1550
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D55B RID: 54619 RVA: 0x003A335C File Offset: 0x003A155C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D55C RID: 54620 RVA: 0x003A3368 File Offset: 0x003A1568
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D55D RID: 54621 RVA: 0x003A3374 File Offset: 0x003A1574
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D55E RID: 54622 RVA: 0x003A337C File Offset: 0x003A157C
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D55F RID: 54623 RVA: 0x003A339C File Offset: 0x003A159C
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D560 RID: 54624 RVA: 0x003A33A8 File Offset: 0x003A15A8
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
					this.m_SetGameObjectGameObjectBooleanGameObjectGameObject_hotfix = (luaObj.RawGet("SetGameObject") as LuaFunction);
					this.m_ShowReturnBgImageBoolean_hotfix = (luaObj.RawGet("ShowReturnBgImage") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_OnDragPointerEventData_hotfix = (luaObj.RawGet("OnDrag") as LuaFunction);
					this.m_CheckPositionBoundaryPointerEventData_hotfix = (luaObj.RawGet("CheckPositionBoundary") as LuaFunction);
					this.m_PassEventPointerEventDataEventFunction`1_hotfix = (luaObj.RawGet("PassEvent") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_set_IsNeedExcuteEventBoolean_hotfix = (luaObj.RawGet("set_IsNeedExcuteEvent") as LuaFunction);
					this.m_get_IsNeedExcuteEvent_hotfix = (luaObj.RawGet("get_IsNeedExcuteEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D561 RID: 54625 RVA: 0x003A35B8 File Offset: 0x003A17B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PointDescComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040083AC RID: 33708
		private GameObject m_checkBoundaryGo;

		// Token: 0x040083AD RID: 33709
		private GameObject m_draggingGo;

		// Token: 0x040083AE RID: 33710
		private bool m_isDragging;

		// Token: 0x040083AF RID: 33711
		private GameObject emptyImageGo;

		// Token: 0x040083B0 RID: 33712
		private GameObject m_downGo;

		// Token: 0x040083B1 RID: 33713
		private GameObject m_enterGo;

		// Token: 0x040083B2 RID: 33714
		[DoNotToLua]
		private PointDescComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040083B3 RID: 33715
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040083B4 RID: 33716
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040083B5 RID: 33717
		private LuaFunction m_SetGameObjectGameObjectBooleanGameObjectGameObject_hotfix;

		// Token: 0x040083B6 RID: 33718
		private LuaFunction m_ShowReturnBgImageBoolean_hotfix;

		// Token: 0x040083B7 RID: 33719
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x040083B8 RID: 33720
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x040083B9 RID: 33721
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x040083BA RID: 33722
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x040083BB RID: 33723
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x040083BC RID: 33724
		private LuaFunction m_OnDragPointerEventData_hotfix;

		// Token: 0x040083BD RID: 33725
		private LuaFunction m_CheckPositionBoundaryPointerEventData_hotfix;

		// Token: 0x040083BE RID: 33726
		private LuaFunction m_PassEventPointerEventDataEventFunction;

		// Token: 0x040083BF RID: 33727
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040083C0 RID: 33728
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x040083C1 RID: 33729
		private LuaFunction m_set_IsNeedExcuteEventBoolean_hotfix;

		// Token: 0x040083C2 RID: 33730
		private LuaFunction m_get_IsNeedExcuteEvent_hotfix;

		// Token: 0x02000BF1 RID: 3057
		public new class LuaExportHelper
		{
			// Token: 0x0600D562 RID: 54626 RVA: 0x003A3620 File Offset: 0x003A1820
			public LuaExportHelper(PointDescComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D563 RID: 54627 RVA: 0x003A3630 File Offset: 0x003A1830
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D564 RID: 54628 RVA: 0x003A3640 File Offset: 0x003A1840
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D565 RID: 54629 RVA: 0x003A3650 File Offset: 0x003A1850
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D566 RID: 54630 RVA: 0x003A3660 File Offset: 0x003A1860
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D567 RID: 54631 RVA: 0x003A3678 File Offset: 0x003A1878
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D568 RID: 54632 RVA: 0x003A3688 File Offset: 0x003A1888
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D569 RID: 54633 RVA: 0x003A3698 File Offset: 0x003A1898
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D56A RID: 54634 RVA: 0x003A36A8 File Offset: 0x003A18A8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D56B RID: 54635 RVA: 0x003A36B8 File Offset: 0x003A18B8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D56C RID: 54636 RVA: 0x003A36C8 File Offset: 0x003A18C8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D56D RID: 54637 RVA: 0x003A36D8 File Offset: 0x003A18D8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D56E RID: 54638 RVA: 0x003A36E8 File Offset: 0x003A18E8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D56F RID: 54639 RVA: 0x003A36F8 File Offset: 0x003A18F8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D570 RID: 54640 RVA: 0x003A3708 File Offset: 0x003A1908
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D571 RID: 54641 RVA: 0x003A3718 File Offset: 0x003A1918
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D572 RID: 54642 RVA: 0x003A3728 File Offset: 0x003A1928
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D573 RID: 54643 RVA: 0x003A3738 File Offset: 0x003A1938
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x1700299D RID: 10653
			// (get) Token: 0x0600D574 RID: 54644 RVA: 0x003A3748 File Offset: 0x003A1948
			// (set) Token: 0x0600D575 RID: 54645 RVA: 0x003A3758 File Offset: 0x003A1958
			public GameObject m_checkBoundaryGo
			{
				get
				{
					return this.m_owner.m_checkBoundaryGo;
				}
				set
				{
					this.m_owner.m_checkBoundaryGo = value;
				}
			}

			// Token: 0x1700299E RID: 10654
			// (get) Token: 0x0600D576 RID: 54646 RVA: 0x003A3768 File Offset: 0x003A1968
			// (set) Token: 0x0600D577 RID: 54647 RVA: 0x003A3778 File Offset: 0x003A1978
			public GameObject m_draggingGo
			{
				get
				{
					return this.m_owner.m_draggingGo;
				}
				set
				{
					this.m_owner.m_draggingGo = value;
				}
			}

			// Token: 0x1700299F RID: 10655
			// (get) Token: 0x0600D578 RID: 54648 RVA: 0x003A3788 File Offset: 0x003A1988
			// (set) Token: 0x0600D579 RID: 54649 RVA: 0x003A3798 File Offset: 0x003A1998
			public bool m_isDragging
			{
				get
				{
					return this.m_owner.m_isDragging;
				}
				set
				{
					this.m_owner.m_isDragging = value;
				}
			}

			// Token: 0x170029A0 RID: 10656
			// (get) Token: 0x0600D57A RID: 54650 RVA: 0x003A37A8 File Offset: 0x003A19A8
			// (set) Token: 0x0600D57B RID: 54651 RVA: 0x003A37B8 File Offset: 0x003A19B8
			public GameObject emptyImageGo
			{
				get
				{
					return this.m_owner.emptyImageGo;
				}
				set
				{
					this.m_owner.emptyImageGo = value;
				}
			}

			// Token: 0x170029A1 RID: 10657
			// (get) Token: 0x0600D57C RID: 54652 RVA: 0x003A37C8 File Offset: 0x003A19C8
			// (set) Token: 0x0600D57D RID: 54653 RVA: 0x003A37D8 File Offset: 0x003A19D8
			public GameObject m_downGo
			{
				get
				{
					return this.m_owner.m_downGo;
				}
				set
				{
					this.m_owner.m_downGo = value;
				}
			}

			// Token: 0x170029A2 RID: 10658
			// (get) Token: 0x0600D57E RID: 54654 RVA: 0x003A37E8 File Offset: 0x003A19E8
			// (set) Token: 0x0600D57F RID: 54655 RVA: 0x003A37F8 File Offset: 0x003A19F8
			public GameObject m_enterGo
			{
				get
				{
					return this.m_owner.m_enterGo;
				}
				set
				{
					this.m_owner.m_enterGo = value;
				}
			}

			// Token: 0x170029A3 RID: 10659
			// (set) Token: 0x0600D580 RID: 54656 RVA: 0x003A3808 File Offset: 0x003A1A08
			public bool IsNeedExcuteEvent
			{
				set
				{
					this.m_owner.IsNeedExcuteEvent = value;
				}
			}

			// Token: 0x0600D581 RID: 54657 RVA: 0x003A3818 File Offset: 0x003A1A18
			public bool CheckPositionBoundary(PointerEventData data)
			{
				return this.m_owner.CheckPositionBoundary(data);
			}

			// Token: 0x040083C3 RID: 33731
			private PointDescComponent m_owner;
		}
	}
}
