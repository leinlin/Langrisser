using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015EB RID: 5611
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WorldWaypointUIController : LuaObject
{
	// Token: 0x06022774 RID: 141172 RVA: 0x00BD0D8C File Offset: 0x00BCEF8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetWaypoint(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypoint;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypoint);
			worldWaypointUIController.SetWaypoint(waypoint);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022775 RID: 141173 RVA: 0x00BD0DE4 File Offset: 0x00BCEFE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetStatus(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			WayPointStatus status;
			LuaObject.checkEnum<WayPointStatus>(l, 2, out status);
			worldWaypointUIController.SetStatus(status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022776 RID: 141174 RVA: 0x00BD0E3C File Offset: 0x00BCF03C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCanClick(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			bool canClick;
			LuaObject.checkType(l, 2, out canClick);
			worldWaypointUIController.SetCanClick(canClick);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022777 RID: 141175 RVA: 0x00BD0E94 File Offset: 0x00BCF094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanClick(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			bool b = worldWaypointUIController.CanClick();
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

	// Token: 0x06022778 RID: 141176 RVA: 0x00BD0EE8 File Offset: 0x00BCF0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IgnoreClick(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.IgnoreClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022779 RID: 141177 RVA: 0x00BD0F34 File Offset: 0x00BCF134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetClickTransform(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			RectTransform clickTransform = worldWaypointUIController.GetClickTransform();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clickTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602277A RID: 141178 RVA: 0x00BD0F88 File Offset: 0x00BCF188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldWaypointUIController.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602277B RID: 141179 RVA: 0x00BD0FE0 File Offset: 0x00BCF1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldWaypointUIController.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602277C RID: 141180 RVA: 0x00BD1038 File Offset: 0x00BCF238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldWaypointUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602277D RID: 141181 RVA: 0x00BD1090 File Offset: 0x00BCF290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602277E RID: 141182 RVA: 0x00BD10E4 File Offset: 0x00BCF2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			worldWaypointUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602277F RID: 141183 RVA: 0x00BD1150 File Offset: 0x00BCF350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022780 RID: 141184 RVA: 0x00BD11A4 File Offset: 0x00BCF3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022781 RID: 141185 RVA: 0x00BD11F8 File Offset: 0x00BCF3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = worldWaypointUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06022782 RID: 141186 RVA: 0x00BD12A0 File Offset: 0x00BCF4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022783 RID: 141187 RVA: 0x00BD12F4 File Offset: 0x00BCF4F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			worldWaypointUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022784 RID: 141188 RVA: 0x00BD1360 File Offset: 0x00BCF560
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				worldWaypointUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				WorldWaypointUIController worldWaypointUIController2 = (WorldWaypointUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				worldWaypointUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06022785 RID: 141189 RVA: 0x00BD1470 File Offset: 0x00BCF670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldWaypointUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022786 RID: 141190 RVA: 0x00BD14DC File Offset: 0x00BCF6DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldWaypointUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022787 RID: 141191 RVA: 0x00BD1548 File Offset: 0x00BCF748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldWaypointUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022788 RID: 141192 RVA: 0x00BD15B4 File Offset: 0x00BCF7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldWaypointUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022789 RID: 141193 RVA: 0x00BD1620 File Offset: 0x00BCF820
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
				WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				worldWaypointUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				WorldWaypointUIController worldWaypointUIController2 = (WorldWaypointUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				worldWaypointUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602278A RID: 141194 RVA: 0x00BD1730 File Offset: 0x00BCF930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			string s = worldWaypointUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602278B RID: 141195 RVA: 0x00BD178C File Offset: 0x00BCF98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.m_luaExportHelper.__callDele_EventOnPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602278C RID: 141196 RVA: 0x00BD17E0 File Offset: 0x00BCF9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.m_luaExportHelper.__clearDele_EventOnPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602278D RID: 141197 RVA: 0x00BD1834 File Offset: 0x00BCFA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.m_luaExportHelper.__callDele_EventOnPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602278E RID: 141198 RVA: 0x00BD1888 File Offset: 0x00BCFA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.m_luaExportHelper.__clearDele_EventOnPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602278F RID: 141199 RVA: 0x00BD18DC File Offset: 0x00BCFADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.m_luaExportHelper.__callDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022790 RID: 141200 RVA: 0x00BD1930 File Offset: 0x00BCFB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			worldWaypointUIController.m_luaExportHelper.__clearDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022791 RID: 141201 RVA: 0x00BD1984 File Offset: 0x00BCFB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldWaypointUIController.EventOnPointerDown += value;
				}
				else if (num == 2)
				{
					worldWaypointUIController.EventOnPointerDown -= value;
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

	// Token: 0x06022792 RID: 141202 RVA: 0x00BD1A04 File Offset: 0x00BCFC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldWaypointUIController.EventOnPointerUp += value;
				}
				else if (num == 2)
				{
					worldWaypointUIController.EventOnPointerUp -= value;
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

	// Token: 0x06022793 RID: 141203 RVA: 0x00BD1A84 File Offset: 0x00BCFC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldWaypointUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					worldWaypointUIController.EventOnClick -= value;
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

	// Token: 0x06022794 RID: 141204 RVA: 0x00BD1B04 File Offset: 0x00BCFD04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testText(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldWaypointUIController.m_luaExportHelper.m_testText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022795 RID: 141205 RVA: 0x00BD1B5C File Offset: 0x00BCFD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testText(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			Text testText;
			LuaObject.checkType<Text>(l, 2, out testText);
			worldWaypointUIController.m_luaExportHelper.m_testText = testText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022796 RID: 141206 RVA: 0x00BD1BB8 File Offset: 0x00BCFDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hitGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldWaypointUIController.m_luaExportHelper.m_hitGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022797 RID: 141207 RVA: 0x00BD1C10 File Offset: 0x00BCFE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hitGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			GameObject hitGameObject;
			LuaObject.checkType<GameObject>(l, 2, out hitGameObject);
			worldWaypointUIController.m_luaExportHelper.m_hitGameObject = hitGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022798 RID: 141208 RVA: 0x00BD1C6C File Offset: 0x00BCFE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldWaypointUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022799 RID: 141209 RVA: 0x00BD1CC4 File Offset: 0x00BCFEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			worldWaypointUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602279A RID: 141210 RVA: 0x00BD1D20 File Offset: 0x00BCFF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameBackgroundImage(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldWaypointUIController.m_luaExportHelper.m_nameBackgroundImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602279B RID: 141211 RVA: 0x00BD1D78 File Offset: 0x00BCFF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameBackgroundImage(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			Image nameBackgroundImage;
			LuaObject.checkType<Image>(l, 2, out nameBackgroundImage);
			worldWaypointUIController.m_luaExportHelper.m_nameBackgroundImage = nameBackgroundImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602279C RID: 141212 RVA: 0x00BD1DD4 File Offset: 0x00BCFFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waypointInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldWaypointUIController.m_luaExportHelper.m_waypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602279D RID: 141213 RVA: 0x00BD1E2C File Offset: 0x00BD002C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waypointInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			worldWaypointUIController.m_luaExportHelper.m_waypointInfo = waypointInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602279E RID: 141214 RVA: 0x00BD1E88 File Offset: 0x00BD0088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldWaypointUIController.m_luaExportHelper.m_isPointerDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602279F RID: 141215 RVA: 0x00BD1EE0 File Offset: 0x00BD00E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			bool isPointerDown;
			LuaObject.checkType(l, 2, out isPointerDown);
			worldWaypointUIController.m_luaExportHelper.m_isPointerDown = isPointerDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227A0 RID: 141216 RVA: 0x00BD1F3C File Offset: 0x00BD013C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_ignoreClick(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldWaypointUIController.m_luaExportHelper.m_ignoreClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227A1 RID: 141217 RVA: 0x00BD1F94 File Offset: 0x00BD0194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ignoreClick(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			bool ignoreClick;
			LuaObject.checkType(l, 2, out ignoreClick);
			worldWaypointUIController.m_luaExportHelper.m_ignoreClick = ignoreClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227A2 RID: 141218 RVA: 0x00BD1FF0 File Offset: 0x00BD01F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_initNameBackgroundWidth(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldWaypointUIController.m_luaExportHelper.m_initNameBackgroundWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227A3 RID: 141219 RVA: 0x00BD2048 File Offset: 0x00BD0248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initNameBackgroundWidth(IntPtr l)
	{
		int result;
		try
		{
			WorldWaypointUIController worldWaypointUIController = (WorldWaypointUIController)LuaObject.checkSelf(l);
			float initNameBackgroundWidth;
			LuaObject.checkType(l, 2, out initNameBackgroundWidth);
			worldWaypointUIController.m_luaExportHelper.m_initNameBackgroundWidth = initNameBackgroundWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227A4 RID: 141220 RVA: 0x00BD20A4 File Offset: 0x00BD02A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WorldWaypointUIController");
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.SetWaypoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.SetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.SetCanClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.CanClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.IgnoreClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.GetClickTransform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__clearDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__clearDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1C);
		string name = "EventOnPointerDown";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_EventOnPointerDown);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1D, true);
		string name2 = "EventOnPointerUp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_EventOnPointerUp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1E, true);
		string name3 = "EventOnClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache1F, true);
		string name4 = "m_testText";
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.get_m_testText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_m_testText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache21, true);
		string name5 = "m_hitGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.get_m_hitGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_m_hitGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache23, true);
		string name6 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.get_m_nameText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache25, true);
		string name7 = "m_nameBackgroundImage";
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.get_m_nameBackgroundImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_m_nameBackgroundImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache27, true);
		string name8 = "m_waypointInfo";
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.get_m_waypointInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_m_waypointInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache29, true);
		string name9 = "m_isPointerDown";
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.get_m_isPointerDown);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_m_isPointerDown);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2B, true);
		string name10 = "m_ignoreClick";
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.get_m_ignoreClick);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_m_ignoreClick);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2D, true);
		string name11 = "m_initNameBackgroundWidth";
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.get_m_initNameBackgroundWidth);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.set_m_initNameBackgroundWidth);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.<>f__mg$cache2F, true);
		LuaObject.createTypeMetatable(l, null, typeof(WorldWaypointUIController), typeof(UIControllerBase));
	}

	// Token: 0x04018580 RID: 99712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018581 RID: 99713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018582 RID: 99714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018583 RID: 99715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018584 RID: 99716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018585 RID: 99717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018586 RID: 99718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018587 RID: 99719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018588 RID: 99720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018589 RID: 99721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401858A RID: 99722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401858B RID: 99723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401858C RID: 99724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401858D RID: 99725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401858E RID: 99726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401858F RID: 99727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018590 RID: 99728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018591 RID: 99729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018592 RID: 99730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018593 RID: 99731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018594 RID: 99732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018595 RID: 99733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018596 RID: 99734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018597 RID: 99735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018598 RID: 99736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018599 RID: 99737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401859A RID: 99738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401859B RID: 99739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401859C RID: 99740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401859D RID: 99741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401859E RID: 99742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401859F RID: 99743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040185A0 RID: 99744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040185A1 RID: 99745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040185A2 RID: 99746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040185A3 RID: 99747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040185A4 RID: 99748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040185A5 RID: 99749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040185A6 RID: 99750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040185A7 RID: 99751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040185A8 RID: 99752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040185A9 RID: 99753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040185AA RID: 99754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040185AB RID: 99755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040185AC RID: 99756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040185AD RID: 99757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040185AE RID: 99758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040185AF RID: 99759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
