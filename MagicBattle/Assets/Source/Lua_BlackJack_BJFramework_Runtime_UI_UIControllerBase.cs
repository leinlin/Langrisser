using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001127 RID: 4391
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase : LuaObject
{
	// Token: 0x06015DB2 RID: 89522 RVA: 0x005A729C File Offset: 0x005A549C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initlize(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			uicontrollerBase.Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DB3 RID: 89523 RVA: 0x005A7300 File Offset: 0x005A5500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BindFields(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			uicontrollerBase.BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DB4 RID: 89524 RVA: 0x005A734C File Offset: 0x005A554C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			uicontrollerBase.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DB5 RID: 89525 RVA: 0x005A7398 File Offset: 0x005A5598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				uicontrollerBase.SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				UIControllerBase uicontrollerBase2 = (UIControllerBase)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				uicontrollerBase2.SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DB6 RID: 89526 RVA: 0x005A74A0 File Offset: 0x005A56A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			uicontrollerBase.SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DB7 RID: 89527 RVA: 0x005A7504 File Offset: 0x005A5704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			uicontrollerBase.SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DB8 RID: 89528 RVA: 0x005A7568 File Offset: 0x005A5768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			uicontrollerBase.SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DB9 RID: 89529 RVA: 0x005A75CC File Offset: 0x005A57CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			uicontrollerBase.SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DBA RID: 89530 RVA: 0x005A7630 File Offset: 0x005A5830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				uicontrollerBase.SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				UIControllerBase uicontrollerBase2 = (UIControllerBase)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				uicontrollerBase2.SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DBB RID: 89531 RVA: 0x005A7738 File Offset: 0x005A5938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckAndUpdateCurrFrameButtonClickStateInfo_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = UIControllerBase.CheckAndUpdateCurrFrameButtonClickStateInfo();
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

	// Token: 0x06015DBC RID: 89532 RVA: 0x005A7780 File Offset: 0x005A5980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLocalizedString_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject goRoot;
			LuaObject.checkType<GameObject>(l, 1, out goRoot);
			UIControllerBase.InitLocalizedString(goRoot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DBD RID: 89533 RVA: 0x005A77CC File Offset: 0x005A59CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			uicontrollerBase.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DBE RID: 89534 RVA: 0x005A7820 File Offset: 0x005A5A20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = uicontrollerBase.m_luaExportHelper.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06015DBF RID: 89535 RVA: 0x005A78C8 File Offset: 0x005A5AC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			uicontrollerBase.m_luaExportHelper.OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DC0 RID: 89536 RVA: 0x005A7934 File Offset: 0x005A5B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnButtonDoubleClick(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			uicontrollerBase.m_luaExportHelper.OnButtonDoubleClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DC1 RID: 89537 RVA: 0x005A79A0 File Offset: 0x005A5BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnButtonLongPressStart(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			uicontrollerBase.m_luaExportHelper.OnButtonLongPressStart(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DC2 RID: 89538 RVA: 0x005A7A0C File Offset: 0x005A5C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnButtonLongPressing(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			uicontrollerBase.m_luaExportHelper.OnButtonLongPressing(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DC3 RID: 89539 RVA: 0x005A7A78 File Offset: 0x005A5C78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnButtonLongPressEnd(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			uicontrollerBase.m_luaExportHelper.OnButtonLongPressEnd(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DC4 RID: 89540 RVA: 0x005A7AE4 File Offset: 0x005A5CE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			bool value;
			LuaObject.checkType(l, 4, out value);
			uicontrollerBase.m_luaExportHelper.OnToggleValueChanged(toggle, fieldName, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DC5 RID: 89541 RVA: 0x005A7B5C File Offset: 0x005A5D5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			uicontrollerBase.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DC6 RID: 89542 RVA: 0x005A7BC8 File Offset: 0x005A5DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAssetInContainer(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			string resName;
			LuaObject.checkType(l, 2, out resName);
			UnityEngine.Object o = uicontrollerBase.m_luaExportHelper.__callBase_GetAssetInContainer(resName);
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

	// Token: 0x06015DC7 RID: 89543 RVA: 0x005A7C30 File Offset: 0x005A5E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindResContainer(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			uicontrollerBase.m_luaExportHelper.__callBase_BindResContainer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DC8 RID: 89544 RVA: 0x005A7C84 File Offset: 0x005A5E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			uicontrollerBase.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DC9 RID: 89545 RVA: 0x005A7CD8 File Offset: 0x005A5ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetNextUpdateExecutor(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			PrefabControllerNextUpdateExecutor o = uicontrollerBase.m_luaExportHelper.__callBase_GetNextUpdateExecutor();
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

	// Token: 0x06015DCA RID: 89546 RVA: 0x005A7D34 File Offset: 0x005A5F34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			uicontrollerBase.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DCB RID: 89547 RVA: 0x005A7D88 File Offset: 0x005A5F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = uicontrollerBase.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06015DCC RID: 89548 RVA: 0x005A7E30 File Offset: 0x005A6030
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetChildByPath(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			string path;
			LuaObject.checkType(l, 2, out path);
			GameObject o = uicontrollerBase.m_luaExportHelper.__callBase_GetChildByPath(path);
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

	// Token: 0x06015DCD RID: 89549 RVA: 0x005A7E98 File Offset: 0x005A6098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AutoInitLocalizedString(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerBase.AutoInitLocalizedString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DCE RID: 89550 RVA: 0x005A7EEC File Offset: 0x005A60EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AutoInitLocalizedString(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			bool autoInitLocalizedString;
			LuaObject.checkType(l, 2, out autoInitLocalizedString);
			uicontrollerBase.AutoInitLocalizedString = autoInitLocalizedString;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DCF RID: 89551 RVA: 0x005A7F44 File Offset: 0x005A6144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buttonClickListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerBase.m_luaExportHelper.m_buttonClickListenerDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DD0 RID: 89552 RVA: 0x005A7F9C File Offset: 0x005A619C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_buttonClickListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Dictionary<string, Action<UIControllerBase>> buttonClickListenerDict;
			LuaObject.checkType<Dictionary<string, Action<UIControllerBase>>>(l, 2, out buttonClickListenerDict);
			uicontrollerBase.m_luaExportHelper.m_buttonClickListenerDict = buttonClickListenerDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DD1 RID: 89553 RVA: 0x005A7FF8 File Offset: 0x005A61F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_buttonDoubleClickListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerBase.m_luaExportHelper.m_buttonDoubleClickListenerDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DD2 RID: 89554 RVA: 0x005A8050 File Offset: 0x005A6250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buttonDoubleClickListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Dictionary<string, Action<UIControllerBase>> buttonDoubleClickListenerDict;
			LuaObject.checkType<Dictionary<string, Action<UIControllerBase>>>(l, 2, out buttonDoubleClickListenerDict);
			uicontrollerBase.m_luaExportHelper.m_buttonDoubleClickListenerDict = buttonDoubleClickListenerDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DD3 RID: 89555 RVA: 0x005A80AC File Offset: 0x005A62AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buttonLongPressStartListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerBase.m_luaExportHelper.m_buttonLongPressStartListenerDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DD4 RID: 89556 RVA: 0x005A8104 File Offset: 0x005A6304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_buttonLongPressStartListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Dictionary<string, Action<UIControllerBase>> buttonLongPressStartListenerDict;
			LuaObject.checkType<Dictionary<string, Action<UIControllerBase>>>(l, 2, out buttonLongPressStartListenerDict);
			uicontrollerBase.m_luaExportHelper.m_buttonLongPressStartListenerDict = buttonLongPressStartListenerDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DD5 RID: 89557 RVA: 0x005A8160 File Offset: 0x005A6360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buttonLongPressingListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerBase.m_luaExportHelper.m_buttonLongPressingListenerDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DD6 RID: 89558 RVA: 0x005A81B8 File Offset: 0x005A63B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_buttonLongPressingListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Dictionary<string, Action<UIControllerBase>> buttonLongPressingListenerDict;
			LuaObject.checkType<Dictionary<string, Action<UIControllerBase>>>(l, 2, out buttonLongPressingListenerDict);
			uicontrollerBase.m_luaExportHelper.m_buttonLongPressingListenerDict = buttonLongPressingListenerDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DD7 RID: 89559 RVA: 0x005A8214 File Offset: 0x005A6414
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_buttonLongPressEndListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerBase.m_luaExportHelper.m_buttonLongPressEndListenerDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DD8 RID: 89560 RVA: 0x005A826C File Offset: 0x005A646C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_buttonLongPressEndListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Dictionary<string, Action<UIControllerBase>> buttonLongPressEndListenerDict;
			LuaObject.checkType<Dictionary<string, Action<UIControllerBase>>>(l, 2, out buttonLongPressEndListenerDict);
			uicontrollerBase.m_luaExportHelper.m_buttonLongPressEndListenerDict = buttonLongPressEndListenerDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DD9 RID: 89561 RVA: 0x005A82C8 File Offset: 0x005A64C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_toggleValueChangedListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerBase.m_luaExportHelper.m_toggleValueChangedListenerDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DDA RID: 89562 RVA: 0x005A8320 File Offset: 0x005A6520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggleValueChangedListenerDict(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase uicontrollerBase = (UIControllerBase)LuaObject.checkSelf(l);
			Dictionary<string, Action<UIControllerBase, bool>> toggleValueChangedListenerDict;
			LuaObject.checkType<Dictionary<string, Action<UIControllerBase, bool>>>(l, 2, out toggleValueChangedListenerDict);
			uicontrollerBase.m_luaExportHelper.m_toggleValueChangedListenerDict = toggleValueChangedListenerDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DDB RID: 89563 RVA: 0x005A837C File Offset: 0x005A657C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastButtonClickFrameCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIControllerBase.LuaExportHelper.m_lastButtonClickFrameCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DDC RID: 89564 RVA: 0x005A83C4 File Offset: 0x005A65C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastButtonClickFrameCount(IntPtr l)
	{
		int result;
		try
		{
			int lastButtonClickFrameCount;
			LuaObject.checkType(l, 2, out lastButtonClickFrameCount);
			UIControllerBase.LuaExportHelper.m_lastButtonClickFrameCount = lastButtonClickFrameCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DDD RID: 89565 RVA: 0x005A8410 File Offset: 0x005A6610
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.UI.UIControllerBase");
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.CheckAndUpdateCurrFrameButtonClickStateInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.InitLocalizedString_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.OnButtonDoubleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.OnButtonLongPressStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.OnButtonLongPressing);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.OnButtonLongPressEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.OnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache13);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.__callBase_GetAssetInContainer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache14);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.__callBase_BindResContainer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache15);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache16);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.__callBase_GetNextUpdateExecutor);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache17);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache18);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache19);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.__callBase_GetChildByPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1A);
		string name = "AutoInitLocalizedString";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.get_AutoInitLocalizedString);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1B;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.set_AutoInitLocalizedString);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1C, true);
		string name2 = "m_buttonClickListenerDict";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.get_m_buttonClickListenerDict);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1D;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.set_m_buttonClickListenerDict);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1E, true);
		string name3 = "m_buttonDoubleClickListenerDict";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.get_m_buttonDoubleClickListenerDict);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache1F;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.set_m_buttonDoubleClickListenerDict);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache20, true);
		string name4 = "m_buttonLongPressStartListenerDict";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.get_m_buttonLongPressStartListenerDict);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache21;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.set_m_buttonLongPressStartListenerDict);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache22, true);
		string name5 = "m_buttonLongPressingListenerDict";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.get_m_buttonLongPressingListenerDict);
		}
		LuaCSFunction get5 = Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache23;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.set_m_buttonLongPressingListenerDict);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache24, true);
		string name6 = "m_buttonLongPressEndListenerDict";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.get_m_buttonLongPressEndListenerDict);
		}
		LuaCSFunction get6 = Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache25;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.set_m_buttonLongPressEndListenerDict);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache26, true);
		string name7 = "m_toggleValueChangedListenerDict";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.get_m_toggleValueChangedListenerDict);
		}
		LuaCSFunction get7 = Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache27;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.set_m_toggleValueChangedListenerDict);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache28, true);
		string name8 = "m_lastButtonClickFrameCount";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.get_m_lastButtonClickFrameCount);
		}
		LuaCSFunction get8 = Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache29;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.set_m_lastButtonClickFrameCount);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.<>f__mg$cache2A, false);
		LuaObject.createTypeMetatable(l, null, typeof(UIControllerBase), typeof(PrefabControllerBase));
	}

	// Token: 0x0400C546 RID: 50502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C547 RID: 50503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C548 RID: 50504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C549 RID: 50505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C54A RID: 50506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C54B RID: 50507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C54C RID: 50508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C54D RID: 50509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C54E RID: 50510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C54F RID: 50511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C550 RID: 50512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C551 RID: 50513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C552 RID: 50514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C553 RID: 50515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C554 RID: 50516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C555 RID: 50517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C556 RID: 50518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C557 RID: 50519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C558 RID: 50520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C559 RID: 50521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C55A RID: 50522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C55B RID: 50523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C55C RID: 50524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C55D RID: 50525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C55E RID: 50526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C55F RID: 50527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C560 RID: 50528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C561 RID: 50529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C562 RID: 50530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C563 RID: 50531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C564 RID: 50532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C565 RID: 50533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C566 RID: 50534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C567 RID: 50535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C568 RID: 50536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C569 RID: 50537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C56A RID: 50538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C56B RID: 50539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400C56C RID: 50540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400C56D RID: 50541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400C56E RID: 50542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400C56F RID: 50543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400C570 RID: 50544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
