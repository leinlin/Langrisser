using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200145C RID: 5212
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GetPathItemUIController : LuaObject
{
	// Token: 0x0601E172 RID: 123250 RVA: 0x009A421C File Offset: 0x009A241C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGetPath(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			GetPathData getPath;
			LuaObject.checkType<GetPathData>(l, 2, out getPath);
			getPathItemUIController.SetGetPath(getPath);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E173 RID: 123251 RVA: 0x009A4274 File Offset: 0x009A2474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			getPathItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E174 RID: 123252 RVA: 0x009A42C8 File Offset: 0x009A24C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			getPathItemUIController.m_luaExportHelper.OnGotoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E175 RID: 123253 RVA: 0x009A431C File Offset: 0x009A251C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			getPathItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E176 RID: 123254 RVA: 0x009A4388 File Offset: 0x009A2588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			getPathItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E177 RID: 123255 RVA: 0x009A43DC File Offset: 0x009A25DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			getPathItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E178 RID: 123256 RVA: 0x009A4430 File Offset: 0x009A2630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = getPathItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E179 RID: 123257 RVA: 0x009A44D8 File Offset: 0x009A26D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			getPathItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E17A RID: 123258 RVA: 0x009A452C File Offset: 0x009A272C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			getPathItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E17B RID: 123259 RVA: 0x009A4598 File Offset: 0x009A2798
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
				GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				getPathItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GetPathItemUIController getPathItemUIController2 = (GetPathItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				getPathItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E17C RID: 123260 RVA: 0x009A46A8 File Offset: 0x009A28A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getPathItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E17D RID: 123261 RVA: 0x009A4714 File Offset: 0x009A2914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getPathItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E17E RID: 123262 RVA: 0x009A4780 File Offset: 0x009A2980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getPathItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E17F RID: 123263 RVA: 0x009A47EC File Offset: 0x009A29EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getPathItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E180 RID: 123264 RVA: 0x009A4858 File Offset: 0x009A2A58
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
				GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				getPathItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GetPathItemUIController getPathItemUIController2 = (GetPathItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				getPathItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E181 RID: 123265 RVA: 0x009A4968 File Offset: 0x009A2B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			string s = getPathItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E182 RID: 123266 RVA: 0x009A49C4 File Offset: 0x009A2BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			getPathItemUIController.m_luaExportHelper.__callDele_EventOnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E183 RID: 123267 RVA: 0x009A4A20 File Offset: 0x009A2C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			getPathItemUIController.m_luaExportHelper.__clearDele_EventOnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E184 RID: 123268 RVA: 0x009A4A7C File Offset: 0x009A2C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			Action<GetPathData> value;
			int num = LuaObject.checkDelegate<Action<GetPathData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					getPathItemUIController.EventOnGotoButtonClick += value;
				}
				else if (num == 2)
				{
					getPathItemUIController.EventOnGotoButtonClick -= value;
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

	// Token: 0x0601E185 RID: 123269 RVA: 0x009A4AFC File Offset: 0x009A2CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E186 RID: 123270 RVA: 0x009A4B54 File Offset: 0x009A2D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			getPathItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E187 RID: 123271 RVA: 0x009A4BB0 File Offset: 0x009A2DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E188 RID: 123272 RVA: 0x009A4C08 File Offset: 0x009A2E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			getPathItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E189 RID: 123273 RVA: 0x009A4C64 File Offset: 0x009A2E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timesStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathItemUIController.m_luaExportHelper.m_timesStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E18A RID: 123274 RVA: 0x009A4CBC File Offset: 0x009A2EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timesStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController timesStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out timesStateCtrl);
			getPathItemUIController.m_luaExportHelper.m_timesStateCtrl = timesStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E18B RID: 123275 RVA: 0x009A4D18 File Offset: 0x009A2F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timesValue(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathItemUIController.m_luaExportHelper.m_timesValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E18C RID: 123276 RVA: 0x009A4D70 File Offset: 0x009A2F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timesValue(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			Text timesValue;
			LuaObject.checkType<Text>(l, 2, out timesValue);
			getPathItemUIController.m_luaExportHelper.m_timesValue = timesValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E18D RID: 123277 RVA: 0x009A4DCC File Offset: 0x009A2FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timesAllValue(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathItemUIController.m_luaExportHelper.m_timesAllValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E18E RID: 123278 RVA: 0x009A4E24 File Offset: 0x009A3024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timesAllValue(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			Text timesAllValue;
			LuaObject.checkType<Text>(l, 2, out timesAllValue);
			getPathItemUIController.m_luaExportHelper.m_timesAllValue = timesAllValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E18F RID: 123279 RVA: 0x009A4E80 File Offset: 0x009A3080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathItemUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E190 RID: 123280 RVA: 0x009A4ED8 File Offset: 0x009A30D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			getPathItemUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E191 RID: 123281 RVA: 0x009A4F34 File Offset: 0x009A3134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GetPathInfo(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathItemUIController.GetPathInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E192 RID: 123282 RVA: 0x009A4F88 File Offset: 0x009A3188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GetPathInfo(IntPtr l)
	{
		int result;
		try
		{
			GetPathItemUIController getPathItemUIController = (GetPathItemUIController)LuaObject.checkSelf(l);
			GetPathData getPathInfo;
			LuaObject.checkType<GetPathData>(l, 2, out getPathInfo);
			getPathItemUIController.m_luaExportHelper.GetPathInfo = getPathInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E193 RID: 123283 RVA: 0x009A4FE4 File Offset: 0x009A31E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GetPathItemUIController");
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.SetGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.OnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__callDele_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.__clearDele_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache11);
		string name = "EventOnGotoButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.set_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache12, true);
		string name2 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.get_m_nameText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache14, true);
		string name3 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.get_m_button);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache16, true);
		string name4 = "m_timesStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.get_m_timesStateCtrl);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.set_m_timesStateCtrl);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache18, true);
		string name5 = "m_timesValue";
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.get_m_timesValue);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.set_m_timesValue);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1A, true);
		string name6 = "m_timesAllValue";
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.get_m_timesAllValue);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.set_m_timesAllValue);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1C, true);
		string name7 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1E, true);
		string name8 = "GetPathInfo";
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.get_GetPathInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.set_GetPathInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GetPathItemUIController.<>f__mg$cache20, true);
		LuaObject.createTypeMetatable(l, null, typeof(GetPathItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401429C RID: 82588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401429D RID: 82589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401429E RID: 82590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401429F RID: 82591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040142A0 RID: 82592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040142A1 RID: 82593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040142A2 RID: 82594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040142A3 RID: 82595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040142A4 RID: 82596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040142A5 RID: 82597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040142A6 RID: 82598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040142A7 RID: 82599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040142A8 RID: 82600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040142A9 RID: 82601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040142AA RID: 82602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040142AB RID: 82603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040142AC RID: 82604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040142AD RID: 82605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040142AE RID: 82606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040142AF RID: 82607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040142B0 RID: 82608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040142B1 RID: 82609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040142B2 RID: 82610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040142B3 RID: 82611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040142B4 RID: 82612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040142B5 RID: 82613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040142B6 RID: 82614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040142B7 RID: 82615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040142B8 RID: 82616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040142B9 RID: 82617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040142BA RID: 82618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040142BB RID: 82619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040142BC RID: 82620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;
}
