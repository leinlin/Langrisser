using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001469 RID: 5225
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton : LuaObject
{
	// Token: 0x0601E2A0 RID: 123552 RVA: 0x009AD50C File Offset: 0x009AB70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIndex(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			goddessDialogChoiceButton.SetIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2A1 RID: 123553 RVA: 0x009AD564 File Offset: 0x009AB764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndex(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			int index = goddessDialogChoiceButton.GetIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2A2 RID: 123554 RVA: 0x009AD5B8 File Offset: 0x009AB7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetText(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			string text;
			LuaObject.checkType(l, 2, out text);
			goddessDialogChoiceButton.SetText(text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2A3 RID: 123555 RVA: 0x009AD610 File Offset: 0x009AB810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			goddessDialogChoiceButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2A4 RID: 123556 RVA: 0x009AD664 File Offset: 0x009AB864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			goddessDialogChoiceButton.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2A5 RID: 123557 RVA: 0x009AD6B8 File Offset: 0x009AB8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			goddessDialogChoiceButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2A6 RID: 123558 RVA: 0x009AD724 File Offset: 0x009AB924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			goddessDialogChoiceButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2A7 RID: 123559 RVA: 0x009AD778 File Offset: 0x009AB978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			goddessDialogChoiceButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2A8 RID: 123560 RVA: 0x009AD7CC File Offset: 0x009AB9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = goddessDialogChoiceButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E2A9 RID: 123561 RVA: 0x009AD874 File Offset: 0x009ABA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			goddessDialogChoiceButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2AA RID: 123562 RVA: 0x009AD8C8 File Offset: 0x009ABAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			goddessDialogChoiceButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2AB RID: 123563 RVA: 0x009AD934 File Offset: 0x009ABB34
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
				GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				goddessDialogChoiceButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GoddessDialogChoiceButton goddessDialogChoiceButton2 = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				goddessDialogChoiceButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E2AC RID: 123564 RVA: 0x009ADA44 File Offset: 0x009ABC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogChoiceButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2AD RID: 123565 RVA: 0x009ADAB0 File Offset: 0x009ABCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogChoiceButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2AE RID: 123566 RVA: 0x009ADB1C File Offset: 0x009ABD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogChoiceButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2AF RID: 123567 RVA: 0x009ADB88 File Offset: 0x009ABD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogChoiceButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2B0 RID: 123568 RVA: 0x009ADBF4 File Offset: 0x009ABDF4
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
				GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				goddessDialogChoiceButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GoddessDialogChoiceButton goddessDialogChoiceButton2 = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				goddessDialogChoiceButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E2B1 RID: 123569 RVA: 0x009ADD04 File Offset: 0x009ABF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			string s = goddessDialogChoiceButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E2B2 RID: 123570 RVA: 0x009ADD60 File Offset: 0x009ABF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			GoddessDialogChoiceButton obj;
			LuaObject.checkType<GoddessDialogChoiceButton>(l, 2, out obj);
			goddessDialogChoiceButton.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2B3 RID: 123571 RVA: 0x009ADDBC File Offset: 0x009ABFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			GoddessDialogChoiceButton obj;
			LuaObject.checkType<GoddessDialogChoiceButton>(l, 2, out obj);
			goddessDialogChoiceButton.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2B4 RID: 123572 RVA: 0x009ADE18 File Offset: 0x009AC018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			Action<GoddessDialogChoiceButton> value;
			int num = LuaObject.checkDelegate<Action<GoddessDialogChoiceButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogChoiceButton.EventOnClick += value;
				}
				else if (num == 2)
				{
					goddessDialogChoiceButton.EventOnClick -= value;
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

	// Token: 0x0601E2B5 RID: 123573 RVA: 0x009ADE98 File Offset: 0x009AC098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogChoiceButton.m_luaExportHelper.m_buton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2B6 RID: 123574 RVA: 0x009ADEF0 File Offset: 0x009AC0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			Button buton;
			LuaObject.checkType<Button>(l, 2, out buton);
			goddessDialogChoiceButton.m_luaExportHelper.m_buton = buton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2B7 RID: 123575 RVA: 0x009ADF4C File Offset: 0x009AC14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogChoiceButton.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2B8 RID: 123576 RVA: 0x009ADFA4 File Offset: 0x009AC1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			Text text;
			LuaObject.checkType<Text>(l, 2, out text);
			goddessDialogChoiceButton.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2B9 RID: 123577 RVA: 0x009AE000 File Offset: 0x009AC200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogChoiceButton.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2BA RID: 123578 RVA: 0x009AE058 File Offset: 0x009AC258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogChoiceButton goddessDialogChoiceButton = (GoddessDialogChoiceButton)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			goddessDialogChoiceButton.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2BB RID: 123579 RVA: 0x009AE0B4 File Offset: 0x009AC2B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GoddessDialogChoiceButton");
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.SetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.GetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.SetText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache13);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache14, true);
		string name2 = "m_buton";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.get_m_buton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.set_m_buton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache16, true);
		string name3 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.get_m_text);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.set_m_text);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache18, true);
		string name4 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.get_m_index);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.set_m_index);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.<>f__mg$cache1A, true);
		LuaObject.createTypeMetatable(l, null, typeof(GoddessDialogChoiceButton), typeof(UIControllerBase));
	}

	// Token: 0x040143B0 RID: 82864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040143B1 RID: 82865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040143B2 RID: 82866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040143B3 RID: 82867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040143B4 RID: 82868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040143B5 RID: 82869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040143B6 RID: 82870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040143B7 RID: 82871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040143B8 RID: 82872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040143B9 RID: 82873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040143BA RID: 82874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040143BB RID: 82875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040143BC RID: 82876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040143BD RID: 82877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040143BE RID: 82878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040143BF RID: 82879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040143C0 RID: 82880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040143C1 RID: 82881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040143C2 RID: 82882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040143C3 RID: 82883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040143C4 RID: 82884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040143C5 RID: 82885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040143C6 RID: 82886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040143C7 RID: 82887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040143C8 RID: 82888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040143C9 RID: 82889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040143CA RID: 82890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
