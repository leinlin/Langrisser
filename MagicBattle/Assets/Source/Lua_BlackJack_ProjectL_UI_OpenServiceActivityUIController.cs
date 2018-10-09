using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200151E RID: 5406
[Preserve]
public class Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController : LuaObject
{
	// Token: 0x0602014B RID: 131403 RVA: 0x00AA0CF4 File Offset: 0x00A9EEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602014C RID: 131404 RVA: 0x00AA0D40 File Offset: 0x00A9EF40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateViewInOpenServiceActivity(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.UpdateViewInOpenServiceActivity();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602014D RID: 131405 RVA: 0x00AA0D8C File Offset: 0x00A9EF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetResidueTime(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			TimeSpan residueTime;
			LuaObject.checkValueType<TimeSpan>(l, 2, out residueTime);
			openServiceActivityUIController.SetResidueTime(residueTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602014E RID: 131406 RVA: 0x00AA0DE4 File Offset: 0x00A9EFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602014F RID: 131407 RVA: 0x00AA0E38 File Offset: 0x00A9F038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitDayButtons(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.m_luaExportHelper.InitDayButtons();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020150 RID: 131408 RVA: 0x00AA0E8C File Offset: 0x00A9F08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			DayButtonUIController ctrl;
			LuaObject.checkType<DayButtonUIController>(l, 2, out ctrl);
			openServiceActivityUIController.m_luaExportHelper.OnDayButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020151 RID: 131409 RVA: 0x00AA0EE8 File Offset: 0x00A9F0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitMissionPanel(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.m_luaExportHelper.InitMissionPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020152 RID: 131410 RVA: 0x00AA0F3C File Offset: 0x00A9F13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMissionGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			GetPathData pathInfo;
			LuaObject.checkType<GetPathData>(l, 2, out pathInfo);
			openServiceActivityUIController.m_luaExportHelper.OnMissionGotoButtonClick(pathInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020153 RID: 131411 RVA: 0x00AA0F98 File Offset: 0x00A9F198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMissionGetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			OpenServiceMissonUIController ctrl;
			LuaObject.checkType<OpenServiceMissonUIController>(l, 2, out ctrl);
			openServiceActivityUIController.m_luaExportHelper.OnMissionGetButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020154 RID: 131412 RVA: 0x00AA0FF4 File Offset: 0x00A9F1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitIntegralPanel(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.m_luaExportHelper.InitIntegralPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020155 RID: 131413 RVA: 0x00AA1048 File Offset: 0x00A9F248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnIntegralGoodsClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			IntegralGoodsUIController ctrl;
			LuaObject.checkType<IntegralGoodsUIController>(l, 2, out ctrl);
			openServiceActivityUIController.m_luaExportHelper.OnIntegralGoodsClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020156 RID: 131414 RVA: 0x00AA10A4 File Offset: 0x00A9F2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020157 RID: 131415 RVA: 0x00AA10F8 File Offset: 0x00A9F2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			openServiceActivityUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020158 RID: 131416 RVA: 0x00AA1164 File Offset: 0x00A9F364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020159 RID: 131417 RVA: 0x00AA11B8 File Offset: 0x00A9F3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602015A RID: 131418 RVA: 0x00AA120C File Offset: 0x00A9F40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = openServiceActivityUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602015B RID: 131419 RVA: 0x00AA12B4 File Offset: 0x00A9F4B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602015C RID: 131420 RVA: 0x00AA1308 File Offset: 0x00A9F508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			openServiceActivityUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602015D RID: 131421 RVA: 0x00AA1374 File Offset: 0x00A9F574
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
				OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				openServiceActivityUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				OpenServiceActivityUIController openServiceActivityUIController2 = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				openServiceActivityUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602015E RID: 131422 RVA: 0x00AA1484 File Offset: 0x00A9F684
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			openServiceActivityUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602015F RID: 131423 RVA: 0x00AA14F0 File Offset: 0x00A9F6F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			openServiceActivityUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020160 RID: 131424 RVA: 0x00AA155C File Offset: 0x00A9F75C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			openServiceActivityUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020161 RID: 131425 RVA: 0x00AA15C8 File Offset: 0x00A9F7C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			openServiceActivityUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020162 RID: 131426 RVA: 0x00AA1634 File Offset: 0x00A9F834
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
				OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				openServiceActivityUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				OpenServiceActivityUIController openServiceActivityUIController2 = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				openServiceActivityUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020163 RID: 131427 RVA: 0x00AA1744 File Offset: 0x00A9F944
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			string s = openServiceActivityUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020164 RID: 131428 RVA: 0x00AA17A0 File Offset: 0x00A9F9A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020165 RID: 131429 RVA: 0x00AA17F4 File Offset: 0x00A9F9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			openServiceActivityUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020166 RID: 131430 RVA: 0x00AA1848 File Offset: 0x00A9FA48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnMissionGoto(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			openServiceActivityUIController.m_luaExportHelper.__callDele_EventOnMissionGoto(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020167 RID: 131431 RVA: 0x00AA18A4 File Offset: 0x00A9FAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMissionGoto(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			openServiceActivityUIController.m_luaExportHelper.__clearDele_EventOnMissionGoto(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020168 RID: 131432 RVA: 0x00AA1900 File Offset: 0x00A9FB00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnMissionGet(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			OpenServiceMissonUIController obj;
			LuaObject.checkType<OpenServiceMissonUIController>(l, 2, out obj);
			openServiceActivityUIController.m_luaExportHelper.__callDele_EventOnMissionGet(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020169 RID: 131433 RVA: 0x00AA195C File Offset: 0x00A9FB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMissionGet(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			OpenServiceMissonUIController obj;
			LuaObject.checkType<OpenServiceMissonUIController>(l, 2, out obj);
			openServiceActivityUIController.m_luaExportHelper.__clearDele_EventOnMissionGet(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602016A RID: 131434 RVA: 0x00AA19B8 File Offset: 0x00A9FBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnIntegralGoodsClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			IntegralGoodsUIController obj;
			LuaObject.checkType<IntegralGoodsUIController>(l, 2, out obj);
			openServiceActivityUIController.m_luaExportHelper.__callDele_EventOnIntegralGoodsClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602016B RID: 131435 RVA: 0x00AA1A14 File Offset: 0x00A9FC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnIntegralGoodsClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			IntegralGoodsUIController obj;
			LuaObject.checkType<IntegralGoodsUIController>(l, 2, out obj);
			openServiceActivityUIController.m_luaExportHelper.__clearDele_EventOnIntegralGoodsClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602016C RID: 131436 RVA: 0x00AA1A70 File Offset: 0x00A9FC70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					openServiceActivityUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					openServiceActivityUIController.EventOnReturn -= value;
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

	// Token: 0x0602016D RID: 131437 RVA: 0x00AA1AF0 File Offset: 0x00A9FCF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnMissionGoto(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			Action<GetPathData> value;
			int num = LuaObject.checkDelegate<Action<GetPathData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					openServiceActivityUIController.EventOnMissionGoto += value;
				}
				else if (num == 2)
				{
					openServiceActivityUIController.EventOnMissionGoto -= value;
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

	// Token: 0x0602016E RID: 131438 RVA: 0x00AA1B70 File Offset: 0x00A9FD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnMissionGet(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			Action<OpenServiceMissonUIController> value;
			int num = LuaObject.checkDelegate<Action<OpenServiceMissonUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					openServiceActivityUIController.EventOnMissionGet += value;
				}
				else if (num == 2)
				{
					openServiceActivityUIController.EventOnMissionGet -= value;
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

	// Token: 0x0602016F RID: 131439 RVA: 0x00AA1BF0 File Offset: 0x00A9FDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnIntegralGoodsClick(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			Action<IntegralGoodsUIController> value;
			int num = LuaObject.checkDelegate<Action<IntegralGoodsUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					openServiceActivityUIController.EventOnIntegralGoodsClick += value;
				}
				else if (num == 2)
				{
					openServiceActivityUIController.EventOnIntegralGoodsClick -= value;
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

	// Token: 0x06020170 RID: 131440 RVA: 0x00AA1C70 File Offset: 0x00A9FE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openServiceActivityStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_openServiceActivityStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020171 RID: 131441 RVA: 0x00AA1CC8 File Offset: 0x00A9FEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_openServiceActivityStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			CommonUIStateController openServiceActivityStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out openServiceActivityStateCtrl);
			openServiceActivityUIController.m_luaExportHelper.m_openServiceActivityStateCtrl = openServiceActivityStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020172 RID: 131442 RVA: 0x00AA1D24 File Offset: 0x00A9FF24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020173 RID: 131443 RVA: 0x00AA1D7C File Offset: 0x00A9FF7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			openServiceActivityUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020174 RID: 131444 RVA: 0x00AA1DD8 File Offset: 0x00A9FFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_charGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020175 RID: 131445 RVA: 0x00AA1E30 File Offset: 0x00AA0030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			GameObject charGameObject;
			LuaObject.checkType<GameObject>(l, 2, out charGameObject);
			openServiceActivityUIController.m_luaExportHelper.m_charGameObject = charGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020176 RID: 131446 RVA: 0x00AA1E8C File Offset: 0x00AA008C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_daysButtonContent(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_daysButtonContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020177 RID: 131447 RVA: 0x00AA1EE4 File Offset: 0x00AA00E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_daysButtonContent(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			GameObject daysButtonContent;
			LuaObject.checkType<GameObject>(l, 2, out daysButtonContent);
			openServiceActivityUIController.m_luaExportHelper.m_daysButtonContent = daysButtonContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020178 RID: 131448 RVA: 0x00AA1F40 File Offset: 0x00AA0140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_missionsScrollRect(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_missionsScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020179 RID: 131449 RVA: 0x00AA1F98 File Offset: 0x00AA0198
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_missionsScrollRect(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			ScrollRect missionsScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out missionsScrollRect);
			openServiceActivityUIController.m_luaExportHelper.m_missionsScrollRect = missionsScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602017A RID: 131450 RVA: 0x00AA1FF4 File Offset: 0x00AA01F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_missionsScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_missionsScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602017B RID: 131451 RVA: 0x00AA204C File Offset: 0x00AA024C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_missionsScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			GameObject missionsScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out missionsScrollViewContent);
			openServiceActivityUIController.m_luaExportHelper.m_missionsScrollViewContent = missionsScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602017C RID: 131452 RVA: 0x00AA20A8 File Offset: 0x00AA02A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_missonItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_missonItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602017D RID: 131453 RVA: 0x00AA2100 File Offset: 0x00AA0300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_missonItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			GameObject missonItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out missonItemPrefab);
			openServiceActivityUIController.m_luaExportHelper.m_missonItemPrefab = missonItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602017E RID: 131454 RVA: 0x00AA215C File Offset: 0x00AA035C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_integralContentGroup(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_integralContentGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602017F RID: 131455 RVA: 0x00AA21B4 File Offset: 0x00AA03B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_integralContentGroup(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			GameObject integralContentGroup;
			LuaObject.checkType<GameObject>(l, 2, out integralContentGroup);
			openServiceActivityUIController.m_luaExportHelper.m_integralContentGroup = integralContentGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020180 RID: 131456 RVA: 0x00AA2210 File Offset: 0x00AA0410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_integralGroupCountValueText(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_integralGroupCountValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020181 RID: 131457 RVA: 0x00AA2268 File Offset: 0x00AA0468
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_integralGroupCountValueText(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			Text integralGroupCountValueText;
			LuaObject.checkType<Text>(l, 2, out integralGroupCountValueText);
			openServiceActivityUIController.m_luaExportHelper.m_integralGroupCountValueText = integralGroupCountValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020182 RID: 131458 RVA: 0x00AA22C4 File Offset: 0x00AA04C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_residueTimeValueText(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_residueTimeValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020183 RID: 131459 RVA: 0x00AA231C File Offset: 0x00AA051C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_residueTimeValueText(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			Text residueTimeValueText;
			LuaObject.checkType<Text>(l, 2, out residueTimeValueText);
			openServiceActivityUIController.m_luaExportHelper.m_residueTimeValueText = residueTimeValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020184 RID: 131460 RVA: 0x00AA2378 File Offset: 0x00AA0578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020185 RID: 131461 RVA: 0x00AA23D0 File Offset: 0x00AA05D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			openServiceActivityUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020186 RID: 131462 RVA: 0x00AA242C File Offset: 0x00AA062C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020187 RID: 131463 RVA: 0x00AA2484 File Offset: 0x00AA0684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			openServiceActivityUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020188 RID: 131464 RVA: 0x00AA24E0 File Offset: 0x00AA06E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSelectday(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_curSelectday);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020189 RID: 131465 RVA: 0x00AA2538 File Offset: 0x00AA0738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectday(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			int curSelectday;
			LuaObject.checkType(l, 2, out curSelectday);
			openServiceActivityUIController.m_luaExportHelper.m_curSelectday = curSelectday;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602018A RID: 131466 RVA: 0x00AA2594 File Offset: 0x00AA0794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602018B RID: 131467 RVA: 0x00AA25EC File Offset: 0x00AA07EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			openServiceActivityUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602018C RID: 131468 RVA: 0x00AA2648 File Offset: 0x00AA0848
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_curSelectDayButtonCtrl(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openServiceActivityUIController.m_luaExportHelper.m_curSelectDayButtonCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602018D RID: 131469 RVA: 0x00AA26A0 File Offset: 0x00AA08A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectDayButtonCtrl(IntPtr l)
	{
		int result;
		try
		{
			OpenServiceActivityUIController openServiceActivityUIController = (OpenServiceActivityUIController)LuaObject.checkSelf(l);
			DayButtonUIController curSelectDayButtonCtrl;
			LuaObject.checkType<DayButtonUIController>(l, 2, out curSelectDayButtonCtrl);
			openServiceActivityUIController.m_luaExportHelper.m_curSelectDayButtonCtrl = curSelectDayButtonCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602018E RID: 131470 RVA: 0x00AA26FC File Offset: 0x00AA08FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.OpenServiceActivityUIController");
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.UpdateViewInOpenServiceActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.SetResidueTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.InitDayButtons);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.OnDayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.InitMissionPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.OnMissionGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.OnMissionGetButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.InitIntegralPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.OnIntegralGoodsClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callDele_EventOnMissionGoto);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__clearDele_EventOnMissionGoto);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callDele_EventOnMissionGet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__clearDele_EventOnMissionGet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__callDele_EventOnIntegralGoodsClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.__clearDele_EventOnIntegralGoodsClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache20);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache21, true);
		string name2 = "EventOnMissionGoto";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_EventOnMissionGoto);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache22, true);
		string name3 = "EventOnMissionGet";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_EventOnMissionGet);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache23, true);
		string name4 = "EventOnIntegralGoodsClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_EventOnIntegralGoodsClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache24, true);
		string name5 = "m_openServiceActivityStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_openServiceActivityStateCtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_openServiceActivityStateCtrl);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache26, true);
		string name6 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_returnButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache28, true);
		string name7 = "m_charGameObject";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_charGameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_charGameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2A, true);
		string name8 = "m_daysButtonContent";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_daysButtonContent);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_daysButtonContent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2C, true);
		string name9 = "m_missionsScrollRect";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_missionsScrollRect);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_missionsScrollRect);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2E, true);
		string name10 = "m_missionsScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_missionsScrollViewContent);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_missionsScrollViewContent);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache30, true);
		string name11 = "m_missonItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_missonItemPrefab);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_missonItemPrefab);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache32, true);
		string name12 = "m_integralContentGroup";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_integralContentGroup);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_integralContentGroup);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache34, true);
		string name13 = "m_integralGroupCountValueText";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_integralGroupCountValueText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_integralGroupCountValueText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache36, true);
		string name14 = "m_residueTimeValueText";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_residueTimeValueText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_residueTimeValueText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache38, true);
		string name15 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_playerContext);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3A, true);
		string name16 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_configDataLoader);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3C, true);
		string name17 = "m_curSelectday";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_curSelectday);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_curSelectday);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3E, true);
		string name18 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache40, true);
		string name19 = "m_curSelectDayButtonCtrl";
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.get_m_curSelectDayButtonCtrl);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.set_m_curSelectDayButtonCtrl);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.<>f__mg$cache42, true);
		LuaObject.createTypeMetatable(l, null, typeof(OpenServiceActivityUIController), typeof(UIControllerBase));
	}

	// Token: 0x040160F1 RID: 90353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040160F2 RID: 90354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040160F3 RID: 90355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040160F4 RID: 90356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040160F5 RID: 90357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040160F6 RID: 90358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040160F7 RID: 90359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040160F8 RID: 90360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040160F9 RID: 90361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040160FA RID: 90362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040160FB RID: 90363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040160FC RID: 90364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040160FD RID: 90365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040160FE RID: 90366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040160FF RID: 90367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016100 RID: 90368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016101 RID: 90369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016102 RID: 90370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016103 RID: 90371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016104 RID: 90372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016105 RID: 90373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016106 RID: 90374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016107 RID: 90375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016108 RID: 90376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016109 RID: 90377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401610A RID: 90378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401610B RID: 90379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401610C RID: 90380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401610D RID: 90381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401610E RID: 90382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401610F RID: 90383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016110 RID: 90384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016111 RID: 90385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016112 RID: 90386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016113 RID: 90387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016114 RID: 90388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016115 RID: 90389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016116 RID: 90390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016117 RID: 90391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016118 RID: 90392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016119 RID: 90393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401611A RID: 90394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401611B RID: 90395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401611C RID: 90396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401611D RID: 90397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401611E RID: 90398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401611F RID: 90399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016120 RID: 90400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016121 RID: 90401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016122 RID: 90402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016123 RID: 90403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016124 RID: 90404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016125 RID: 90405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016126 RID: 90406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016127 RID: 90407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016128 RID: 90408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016129 RID: 90409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401612A RID: 90410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401612B RID: 90411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401612C RID: 90412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401612D RID: 90413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401612E RID: 90414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401612F RID: 90415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016130 RID: 90416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04016131 RID: 90417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04016132 RID: 90418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04016133 RID: 90419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;
}
