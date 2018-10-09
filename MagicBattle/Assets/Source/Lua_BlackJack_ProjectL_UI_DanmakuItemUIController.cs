using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001411 RID: 5137
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DanmakuItemUIController : LuaObject
{
	// Token: 0x0601D0AE RID: 118958 RVA: 0x0091E738 File Offset: 0x0091C938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDanmakuItem(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			int turn;
			LuaObject.checkType(l, 3, out turn);
			danmakuItemUIController.InitDanmakuItem(content, turn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0AF RID: 118959 RVA: 0x0091E79C File Offset: 0x0091C99C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayTextTweenPos(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			danmakuItemUIController.PlayTextTweenPos();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0B0 RID: 118960 RVA: 0x0091E7E8 File Offset: 0x0091C9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			danmakuItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0B1 RID: 118961 RVA: 0x0091E83C File Offset: 0x0091CA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			danmakuItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0B2 RID: 118962 RVA: 0x0091E8A8 File Offset: 0x0091CAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			danmakuItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0B3 RID: 118963 RVA: 0x0091E8FC File Offset: 0x0091CAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			danmakuItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0B4 RID: 118964 RVA: 0x0091E950 File Offset: 0x0091CB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = danmakuItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D0B5 RID: 118965 RVA: 0x0091E9F8 File Offset: 0x0091CBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			danmakuItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0B6 RID: 118966 RVA: 0x0091EA4C File Offset: 0x0091CC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			danmakuItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0B7 RID: 118967 RVA: 0x0091EAB8 File Offset: 0x0091CCB8
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
				DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				danmakuItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				DanmakuItemUIController danmakuItemUIController2 = (DanmakuItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				danmakuItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D0B8 RID: 118968 RVA: 0x0091EBC8 File Offset: 0x0091CDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			danmakuItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0B9 RID: 118969 RVA: 0x0091EC34 File Offset: 0x0091CE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			danmakuItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0BA RID: 118970 RVA: 0x0091ECA0 File Offset: 0x0091CEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			danmakuItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0BB RID: 118971 RVA: 0x0091ED0C File Offset: 0x0091CF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			danmakuItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0BC RID: 118972 RVA: 0x0091ED78 File Offset: 0x0091CF78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				danmakuItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				DanmakuItemUIController danmakuItemUIController2 = (DanmakuItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				danmakuItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D0BD RID: 118973 RVA: 0x0091EE88 File Offset: 0x0091D088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			string s = danmakuItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D0BE RID: 118974 RVA: 0x0091EEE4 File Offset: 0x0091D0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnText(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuItemUIController.m_luaExportHelper.m_turnText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0BF RID: 118975 RVA: 0x0091EF3C File Offset: 0x0091D13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turnText(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			Text turnText;
			LuaObject.checkType<Text>(l, 2, out turnText);
			danmakuItemUIController.m_luaExportHelper.m_turnText = turnText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0C0 RID: 118976 RVA: 0x0091EF98 File Offset: 0x0091D198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_contentText(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuItemUIController.m_luaExportHelper.m_contentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0C1 RID: 118977 RVA: 0x0091EFF0 File Offset: 0x0091D1F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_contentText(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			Text contentText;
			LuaObject.checkType<Text>(l, 2, out contentText);
			danmakuItemUIController.m_luaExportHelper.m_contentText = contentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0C2 RID: 118978 RVA: 0x0091F04C File Offset: 0x0091D24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_contentTextTweenPos(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuItemUIController.m_luaExportHelper.m_contentTextTweenPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0C3 RID: 118979 RVA: 0x0091F0A4 File Offset: 0x0091D2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_contentTextTweenPos(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			TweenPos contentTextTweenPos;
			LuaObject.checkType<TweenPos>(l, 2, out contentTextTweenPos);
			danmakuItemUIController.m_luaExportHelper.m_contentTextTweenPos = contentTextTweenPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0C4 RID: 118980 RVA: 0x0091F100 File Offset: 0x0091D300
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_textMaskRectTransform(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuItemUIController.m_luaExportHelper.m_textMaskRectTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0C5 RID: 118981 RVA: 0x0091F158 File Offset: 0x0091D358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_textMaskRectTransform(IntPtr l)
	{
		int result;
		try
		{
			DanmakuItemUIController danmakuItemUIController = (DanmakuItemUIController)LuaObject.checkSelf(l);
			RectTransform textMaskRectTransform;
			LuaObject.checkType<RectTransform>(l, 2, out textMaskRectTransform);
			danmakuItemUIController.m_luaExportHelper.m_textMaskRectTransform = textMaskRectTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0C6 RID: 118982 RVA: 0x0091F1B4 File Offset: 0x0091D3B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DanmakuItemUIController");
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.InitDanmakuItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.PlayTextTweenPos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cacheF);
		string name = "m_turnText";
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.get_m_turnText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.set_m_turnText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache11, true);
		string name2 = "m_contentText";
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.get_m_contentText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.set_m_contentText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache13, true);
		string name3 = "m_contentTextTweenPos";
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.get_m_contentTextTweenPos);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.set_m_contentTextTweenPos);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache15, true);
		string name4 = "m_textMaskRectTransform";
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.get_m_textMaskRectTransform);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.set_m_textMaskRectTransform);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.<>f__mg$cache17, true);
		LuaObject.createTypeMetatable(l, null, typeof(DanmakuItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401326E RID: 78446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401326F RID: 78447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013270 RID: 78448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013271 RID: 78449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013272 RID: 78450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013273 RID: 78451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013274 RID: 78452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013275 RID: 78453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013276 RID: 78454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013277 RID: 78455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013278 RID: 78456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013279 RID: 78457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401327A RID: 78458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401327B RID: 78459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401327C RID: 78460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401327D RID: 78461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401327E RID: 78462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401327F RID: 78463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013280 RID: 78464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013281 RID: 78465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013282 RID: 78466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013283 RID: 78467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013284 RID: 78468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013285 RID: 78469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
