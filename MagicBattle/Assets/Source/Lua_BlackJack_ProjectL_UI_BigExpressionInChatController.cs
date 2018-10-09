using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013D0 RID: 5072
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BigExpressionInChatController : LuaObject
{
	// Token: 0x0601C5EB RID: 116203 RVA: 0x008C91FC File Offset: 0x008C73FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetChannel(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			bigExpressionInChatController.SetChannel(channel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5EC RID: 116204 RVA: 0x008C9254 File Offset: 0x008C7454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DelayInit(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			IEnumerator o = bigExpressionInChatController.DelayInit();
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

	// Token: 0x0601C5ED RID: 116205 RVA: 0x008C92A8 File Offset: 0x008C74A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			bigExpressionInChatController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5EE RID: 116206 RVA: 0x008C92FC File Offset: 0x008C74FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChatExpressionInfo(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			List<ConfigDataBigExpressionInfo> chatExpressionInfo = bigExpressionInChatController.m_luaExportHelper.GetChatExpressionInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatExpressionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5EF RID: 116207 RVA: 0x008C9358 File Offset: 0x008C7558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			bigExpressionInChatController.m_luaExportHelper.OnExpressionClick(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5F0 RID: 116208 RVA: 0x008C93B4 File Offset: 0x008C75B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			bigExpressionInChatController.m_luaExportHelper.OnEndDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5F1 RID: 116209 RVA: 0x008C9410 File Offset: 0x008C7610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnValueChange(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			Vector2 rectEvent;
			LuaObject.checkType(l, 2, out rectEvent);
			bigExpressionInChatController.m_luaExportHelper.OnValueChange(rectEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5F2 RID: 116210 RVA: 0x008C946C File Offset: 0x008C766C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPagePointActivity(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			int pagePointActivity;
			LuaObject.checkType(l, 2, out pagePointActivity);
			bigExpressionInChatController.m_luaExportHelper.SetPagePointActivity(pagePointActivity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5F3 RID: 116211 RVA: 0x008C94C8 File Offset: 0x008C76C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			bigExpressionInChatController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5F4 RID: 116212 RVA: 0x008C9534 File Offset: 0x008C7734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			bigExpressionInChatController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5F5 RID: 116213 RVA: 0x008C9588 File Offset: 0x008C7788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			bigExpressionInChatController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5F6 RID: 116214 RVA: 0x008C95DC File Offset: 0x008C77DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = bigExpressionInChatController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C5F7 RID: 116215 RVA: 0x008C9684 File Offset: 0x008C7884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			bigExpressionInChatController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5F8 RID: 116216 RVA: 0x008C96D8 File Offset: 0x008C78D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			bigExpressionInChatController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5F9 RID: 116217 RVA: 0x008C9744 File Offset: 0x008C7944
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
				BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				bigExpressionInChatController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BigExpressionInChatController bigExpressionInChatController2 = (BigExpressionInChatController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				bigExpressionInChatController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C5FA RID: 116218 RVA: 0x008C9854 File Offset: 0x008C7A54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bigExpressionInChatController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5FB RID: 116219 RVA: 0x008C98C0 File Offset: 0x008C7AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bigExpressionInChatController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5FC RID: 116220 RVA: 0x008C992C File Offset: 0x008C7B2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bigExpressionInChatController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5FD RID: 116221 RVA: 0x008C9998 File Offset: 0x008C7B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bigExpressionInChatController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5FE RID: 116222 RVA: 0x008C9A04 File Offset: 0x008C7C04
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
				BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				bigExpressionInChatController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BigExpressionInChatController bigExpressionInChatController2 = (BigExpressionInChatController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				bigExpressionInChatController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C5FF RID: 116223 RVA: 0x008C9B14 File Offset: 0x008C7D14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			string s = bigExpressionInChatController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C600 RID: 116224 RVA: 0x008C9B70 File Offset: 0x008C7D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			bigExpressionInChatController.m_luaExportHelper.__callDele_EventOnExpressionClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C601 RID: 116225 RVA: 0x008C9BCC File Offset: 0x008C7DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			bigExpressionInChatController.m_luaExportHelper.__clearDele_EventOnExpressionClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C602 RID: 116226 RVA: 0x008C9C28 File Offset: 0x008C7E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bigExpressionInChatController.EventOnExpressionClick += value;
				}
				else if (num == 2)
				{
					bigExpressionInChatController.EventOnExpressionClick -= value;
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

	// Token: 0x0601C603 RID: 116227 RVA: 0x008C9CA8 File Offset: 0x008C7EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollRectLastPos(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.m_luaExportHelper.m_scrollRectLastPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C604 RID: 116228 RVA: 0x008C9D00 File Offset: 0x008C7F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollRectLastPos(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			float scrollRectLastPos;
			LuaObject.checkType(l, 2, out scrollRectLastPos);
			bigExpressionInChatController.m_luaExportHelper.m_scrollRectLastPos = scrollRectLastPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C605 RID: 116229 RVA: 0x008C9D5C File Offset: 0x008C7F5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_chatChannel(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)bigExpressionInChatController.m_luaExportHelper.m_chatChannel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C606 RID: 116230 RVA: 0x008C9DB4 File Offset: 0x008C7FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatChannel(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			ChatChannel chatChannel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out chatChannel);
			bigExpressionInChatController.m_luaExportHelper.m_chatChannel = chatChannel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C607 RID: 116231 RVA: 0x008C9E10 File Offset: 0x008C8010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pageCapacity(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.m_luaExportHelper.m_pageCapacity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C608 RID: 116232 RVA: 0x008C9E68 File Offset: 0x008C8068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pageCapacity(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			int pageCapacity;
			LuaObject.checkType(l, 2, out pageCapacity);
			bigExpressionInChatController.m_luaExportHelper.m_pageCapacity = pageCapacity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C609 RID: 116233 RVA: 0x008C9EC4 File Offset: 0x008C80C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bigExpressionItemList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.m_luaExportHelper.m_bigExpressionItemList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C60A RID: 116234 RVA: 0x008C9F1C File Offset: 0x008C811C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigExpressionItemList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			List<BigExpressionItem> bigExpressionItemList;
			LuaObject.checkType<List<BigExpressionItem>>(l, 2, out bigExpressionItemList);
			bigExpressionInChatController.m_luaExportHelper.m_bigExpressionItemList = bigExpressionItemList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C60B RID: 116235 RVA: 0x008C9F78 File Offset: 0x008C8178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pageList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.m_luaExportHelper.m_pageList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C60C RID: 116236 RVA: 0x008C9FD0 File Offset: 0x008C81D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pageList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			List<GameObject> pageList;
			LuaObject.checkType<List<GameObject>>(l, 2, out pageList);
			bigExpressionInChatController.m_luaExportHelper.m_pageList = pageList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C60D RID: 116237 RVA: 0x008CA02C File Offset: 0x008C822C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pagePointStateControllerList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.m_luaExportHelper.m_pagePointStateControllerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C60E RID: 116238 RVA: 0x008CA084 File Offset: 0x008C8284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pagePointStateControllerList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			List<CommonUIStateController> pagePointStateControllerList;
			LuaObject.checkType<List<CommonUIStateController>>(l, 2, out pagePointStateControllerList);
			bigExpressionInChatController.m_luaExportHelper.m_pagePointStateControllerList = pagePointStateControllerList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C60F RID: 116239 RVA: 0x008CA0E0 File Offset: 0x008C82E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Content(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.Content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C610 RID: 116240 RVA: 0x008CA134 File Offset: 0x008C8334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Content(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			GameObject content;
			LuaObject.checkType<GameObject>(l, 2, out content);
			bigExpressionInChatController.Content = content;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C611 RID: 116241 RVA: 0x008CA18C File Offset: 0x008C838C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Expression(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.Expression);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C612 RID: 116242 RVA: 0x008CA1E0 File Offset: 0x008C83E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Expression(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			GameObject expression;
			LuaObject.checkType<GameObject>(l, 2, out expression);
			bigExpressionInChatController.Expression = expression;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C613 RID: 116243 RVA: 0x008CA238 File Offset: 0x008C8438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Page(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.Page);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C614 RID: 116244 RVA: 0x008CA28C File Offset: 0x008C848C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Page(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			GameObject page;
			LuaObject.checkType<GameObject>(l, 2, out page);
			bigExpressionInChatController.Page = page;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C615 RID: 116245 RVA: 0x008CA2E4 File Offset: 0x008C84E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PagePointNode(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.PagePointNode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C616 RID: 116246 RVA: 0x008CA338 File Offset: 0x008C8538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PagePointNode(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			GameObject pagePointNode;
			LuaObject.checkType<GameObject>(l, 2, out pagePointNode);
			bigExpressionInChatController.PagePointNode = pagePointNode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C617 RID: 116247 RVA: 0x008CA390 File Offset: 0x008C8590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PagePoint(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.PagePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C618 RID: 116248 RVA: 0x008CA3E4 File Offset: 0x008C85E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PagePoint(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			GameObject pagePoint;
			LuaObject.checkType<GameObject>(l, 2, out pagePoint);
			bigExpressionInChatController.PagePoint = pagePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C619 RID: 116249 RVA: 0x008CA43C File Offset: 0x008C863C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScrollView(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionInChatController.ScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C61A RID: 116250 RVA: 0x008CA490 File Offset: 0x008C8690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ScrollView(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionInChatController bigExpressionInChatController = (BigExpressionInChatController)LuaObject.checkSelf(l);
			ScrollRect scrollView;
			LuaObject.checkType<ScrollRect>(l, 2, out scrollView);
			bigExpressionInChatController.ScrollView = scrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C61B RID: 116251 RVA: 0x008CA4E8 File Offset: 0x008C86E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BigExpressionInChatController");
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.SetChannel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.DelayInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.GetChatExpressionInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.OnExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.OnValueChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.SetPagePointActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__callDele_EventOnExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.__clearDele_EventOnExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache16);
		string name = "EventOnExpressionClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_EventOnExpressionClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache17, true);
		string name2 = "m_scrollRectLastPos";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_m_scrollRectLastPos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_m_scrollRectLastPos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache19, true);
		string name3 = "m_chatChannel";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_m_chatChannel);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_m_chatChannel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1B, true);
		string name4 = "m_pageCapacity";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_m_pageCapacity);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_m_pageCapacity);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1D, true);
		string name5 = "m_bigExpressionItemList";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_m_bigExpressionItemList);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_m_bigExpressionItemList);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache1F, true);
		string name6 = "m_pageList";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_m_pageList);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_m_pageList);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache21, true);
		string name7 = "m_pagePointStateControllerList";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_m_pagePointStateControllerList);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_m_pagePointStateControllerList);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache23, true);
		string name8 = "Content";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_Content);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_Content);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache25, true);
		string name9 = "Expression";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_Expression);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_Expression);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache27, true);
		string name10 = "Page";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_Page);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_Page);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache29, true);
		string name11 = "PagePointNode";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_PagePointNode);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_PagePointNode);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2B, true);
		string name12 = "PagePoint";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_PagePoint);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_PagePoint);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2D, true);
		string name13 = "ScrollView";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.get_ScrollView);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.set_ScrollView);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.<>f__mg$cache2F, true);
		LuaObject.createTypeMetatable(l, null, typeof(BigExpressionInChatController), typeof(UIControllerBase));
	}

	// Token: 0x0401282D RID: 75821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401282E RID: 75822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401282F RID: 75823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012830 RID: 75824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012831 RID: 75825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012832 RID: 75826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012833 RID: 75827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012834 RID: 75828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012835 RID: 75829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012836 RID: 75830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012837 RID: 75831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012838 RID: 75832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012839 RID: 75833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401283A RID: 75834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401283B RID: 75835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401283C RID: 75836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401283D RID: 75837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401283E RID: 75838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401283F RID: 75839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012840 RID: 75840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012841 RID: 75841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012842 RID: 75842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012843 RID: 75843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012844 RID: 75844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012845 RID: 75845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012846 RID: 75846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012847 RID: 75847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012848 RID: 75848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012849 RID: 75849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401284A RID: 75850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401284B RID: 75851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401284C RID: 75852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401284D RID: 75853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401284E RID: 75854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401284F RID: 75855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012850 RID: 75856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012851 RID: 75857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012852 RID: 75858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012853 RID: 75859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012854 RID: 75860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012855 RID: 75861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012856 RID: 75862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012857 RID: 75863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012858 RID: 75864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012859 RID: 75865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401285A RID: 75866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401285B RID: 75867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401285C RID: 75868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
