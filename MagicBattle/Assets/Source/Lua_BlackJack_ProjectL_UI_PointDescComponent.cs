using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001537 RID: 5431
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PointDescComponent : LuaObject
{
	// Token: 0x0602060F RID: 132623 RVA: 0x00AC6E1C File Offset: 0x00AC501C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGameObject(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			GameObject addComponentRoot;
			LuaObject.checkType<GameObject>(l, 2, out addComponentRoot);
			bool isNeedExcuteEvent;
			LuaObject.checkType(l, 3, out isNeedExcuteEvent);
			GameObject addReturnImageRoot;
			LuaObject.checkType<GameObject>(l, 4, out addReturnImageRoot);
			GameObject checkBoundaryGo;
			LuaObject.checkType<GameObject>(l, 5, out checkBoundaryGo);
			pointDescComponent.SetGameObject(addComponentRoot, isNeedExcuteEvent, addReturnImageRoot, checkBoundaryGo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020610 RID: 132624 RVA: 0x00AC6E9C File Offset: 0x00AC509C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowReturnBgImage(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			pointDescComponent.ShowReturnBgImage(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020611 RID: 132625 RVA: 0x00AC6EF4 File Offset: 0x00AC50F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointDescComponent.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020612 RID: 132626 RVA: 0x00AC6F4C File Offset: 0x00AC514C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointDescComponent.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020613 RID: 132627 RVA: 0x00AC6FA4 File Offset: 0x00AC51A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointDescComponent.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020614 RID: 132628 RVA: 0x00AC6FFC File Offset: 0x00AC51FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointDescComponent.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020615 RID: 132629 RVA: 0x00AC7054 File Offset: 0x00AC5254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointDescComponent.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020616 RID: 132630 RVA: 0x00AC70AC File Offset: 0x00AC52AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointDescComponent.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020617 RID: 132631 RVA: 0x00AC7104 File Offset: 0x00AC5304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PassEvent(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			PointerEventData data;
			LuaObject.checkType<PointerEventData>(l, 2, out data);
			ExecuteEvents.EventFunction<IEventSystemHandler> function;
			LuaObject.checkDelegate<ExecuteEvents.EventFunction<IEventSystemHandler>>(l, 3, out function);
			pointDescComponent.PassEvent<IEventSystemHandler>(data, function);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020618 RID: 132632 RVA: 0x00AC7168 File Offset: 0x00AC5368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckPositionBoundary(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			PointerEventData data;
			LuaObject.checkType<PointerEventData>(l, 2, out data);
			bool b = pointDescComponent.m_luaExportHelper.CheckPositionBoundary(data);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020619 RID: 132633 RVA: 0x00AC71D0 File Offset: 0x00AC53D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			pointDescComponent.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602061A RID: 132634 RVA: 0x00AC723C File Offset: 0x00AC543C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			pointDescComponent.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602061B RID: 132635 RVA: 0x00AC7290 File Offset: 0x00AC5490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			pointDescComponent.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602061C RID: 132636 RVA: 0x00AC72E4 File Offset: 0x00AC54E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = pointDescComponent.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602061D RID: 132637 RVA: 0x00AC738C File Offset: 0x00AC558C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			pointDescComponent.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602061E RID: 132638 RVA: 0x00AC73E0 File Offset: 0x00AC55E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			pointDescComponent.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602061F RID: 132639 RVA: 0x00AC744C File Offset: 0x00AC564C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				pointDescComponent.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PointDescComponent pointDescComponent2 = (PointDescComponent)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				pointDescComponent2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020620 RID: 132640 RVA: 0x00AC755C File Offset: 0x00AC575C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pointDescComponent.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020621 RID: 132641 RVA: 0x00AC75C8 File Offset: 0x00AC57C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pointDescComponent.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020622 RID: 132642 RVA: 0x00AC7634 File Offset: 0x00AC5834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pointDescComponent.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020623 RID: 132643 RVA: 0x00AC76A0 File Offset: 0x00AC58A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pointDescComponent.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020624 RID: 132644 RVA: 0x00AC770C File Offset: 0x00AC590C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				pointDescComponent.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PointDescComponent pointDescComponent2 = (PointDescComponent)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				pointDescComponent2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020625 RID: 132645 RVA: 0x00AC781C File Offset: 0x00AC5A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			string s = pointDescComponent.m_luaExportHelper.__callBase_ToString();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020626 RID: 132646 RVA: 0x00AC7878 File Offset: 0x00AC5A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			pointDescComponent.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020627 RID: 132647 RVA: 0x00AC78CC File Offset: 0x00AC5ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			pointDescComponent.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020628 RID: 132648 RVA: 0x00AC7920 File Offset: 0x00AC5B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					pointDescComponent.EventOnClose += value;
				}
				else if (num == 2)
				{
					pointDescComponent.EventOnClose -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020629 RID: 132649 RVA: 0x00AC79A0 File Offset: 0x00AC5BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_checkBoundaryGo(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointDescComponent.m_luaExportHelper.m_checkBoundaryGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602062A RID: 132650 RVA: 0x00AC79F8 File Offset: 0x00AC5BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_checkBoundaryGo(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			GameObject checkBoundaryGo;
			LuaObject.checkType<GameObject>(l, 2, out checkBoundaryGo);
			pointDescComponent.m_luaExportHelper.m_checkBoundaryGo = checkBoundaryGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602062B RID: 132651 RVA: 0x00AC7A54 File Offset: 0x00AC5C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_draggingGo(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointDescComponent.m_luaExportHelper.m_draggingGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602062C RID: 132652 RVA: 0x00AC7AAC File Offset: 0x00AC5CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_draggingGo(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			GameObject draggingGo;
			LuaObject.checkType<GameObject>(l, 2, out draggingGo);
			pointDescComponent.m_luaExportHelper.m_draggingGo = draggingGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602062D RID: 132653 RVA: 0x00AC7B08 File Offset: 0x00AC5D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDragging(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointDescComponent.m_luaExportHelper.m_isDragging);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602062E RID: 132654 RVA: 0x00AC7B60 File Offset: 0x00AC5D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDragging(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			bool isDragging;
			LuaObject.checkType(l, 2, out isDragging);
			pointDescComponent.m_luaExportHelper.m_isDragging = isDragging;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602062F RID: 132655 RVA: 0x00AC7BBC File Offset: 0x00AC5DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_emptyImageGo(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointDescComponent.m_luaExportHelper.emptyImageGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020630 RID: 132656 RVA: 0x00AC7C14 File Offset: 0x00AC5E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_emptyImageGo(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			GameObject emptyImageGo;
			LuaObject.checkType<GameObject>(l, 2, out emptyImageGo);
			pointDescComponent.m_luaExportHelper.emptyImageGo = emptyImageGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020631 RID: 132657 RVA: 0x00AC7C70 File Offset: 0x00AC5E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_downGo(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointDescComponent.m_luaExportHelper.m_downGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020632 RID: 132658 RVA: 0x00AC7CC8 File Offset: 0x00AC5EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_downGo(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			GameObject downGo;
			LuaObject.checkType<GameObject>(l, 2, out downGo);
			pointDescComponent.m_luaExportHelper.m_downGo = downGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020633 RID: 132659 RVA: 0x00AC7D24 File Offset: 0x00AC5F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enterGo(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointDescComponent.m_luaExportHelper.m_enterGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020634 RID: 132660 RVA: 0x00AC7D7C File Offset: 0x00AC5F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enterGo(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			GameObject enterGo;
			LuaObject.checkType<GameObject>(l, 2, out enterGo);
			pointDescComponent.m_luaExportHelper.m_enterGo = enterGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020635 RID: 132661 RVA: 0x00AC7DD8 File Offset: 0x00AC5FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsNeedExcuteEvent(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointDescComponent.IsNeedExcuteEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020636 RID: 132662 RVA: 0x00AC7E2C File Offset: 0x00AC602C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsNeedExcuteEvent(IntPtr l)
	{
		int result;
		try
		{
			PointDescComponent pointDescComponent = (PointDescComponent)LuaObject.checkSelf(l);
			bool isNeedExcuteEvent;
			LuaObject.checkType(l, 2, out isNeedExcuteEvent);
			pointDescComponent.m_luaExportHelper.IsNeedExcuteEvent = isNeedExcuteEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020637 RID: 132663 RVA: 0x00AC7E88 File Offset: 0x00AC6088
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PointDescComponent");
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.SetGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.ShowReturnBgImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.PassEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.CheckPositionBoundary);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache18);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache19, true);
		string name2 = "m_checkBoundaryGo";
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.get_m_checkBoundaryGo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.set_m_checkBoundaryGo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1B, true);
		string name3 = "m_draggingGo";
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.get_m_draggingGo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.set_m_draggingGo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1D, true);
		string name4 = "m_isDragging";
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.get_m_isDragging);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.set_m_isDragging);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache1F, true);
		string name5 = "emptyImageGo";
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.get_emptyImageGo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.set_emptyImageGo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache21, true);
		string name6 = "m_downGo";
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.get_m_downGo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.set_m_downGo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache23, true);
		string name7 = "m_enterGo";
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.get_m_enterGo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.set_m_enterGo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache25, true);
		string name8 = "IsNeedExcuteEvent";
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.get_IsNeedExcuteEvent);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PointDescComponent.set_IsNeedExcuteEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PointDescComponent.<>f__mg$cache27, true);
		LuaObject.createTypeMetatable(l, null, typeof(PointDescComponent), typeof(UIControllerBase));
	}

	// Token: 0x04016583 RID: 91523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016584 RID: 91524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016585 RID: 91525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016586 RID: 91526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016587 RID: 91527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016588 RID: 91528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016589 RID: 91529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401658A RID: 91530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401658B RID: 91531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401658C RID: 91532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401658D RID: 91533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401658E RID: 91534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401658F RID: 91535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016590 RID: 91536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016591 RID: 91537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016592 RID: 91538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016593 RID: 91539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016594 RID: 91540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016595 RID: 91541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016596 RID: 91542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016597 RID: 91543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016598 RID: 91544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016599 RID: 91545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401659A RID: 91546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401659B RID: 91547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401659C RID: 91548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401659D RID: 91549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401659E RID: 91550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401659F RID: 91551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040165A0 RID: 91552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040165A1 RID: 91553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040165A2 RID: 91554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040165A3 RID: 91555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040165A4 RID: 91556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040165A5 RID: 91557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040165A6 RID: 91558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040165A7 RID: 91559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040165A8 RID: 91560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040165A9 RID: 91561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040165AA RID: 91562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
