using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013CF RID: 5071
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BigExpressionController : LuaObject
{
	// Token: 0x0601C5BB RID: 116155 RVA: 0x008C7944 File Offset: 0x008C5B44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			bigExpressionController.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5BC RID: 116156 RVA: 0x008C7990 File Offset: 0x008C5B90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			bigExpressionController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5BD RID: 116157 RVA: 0x008C79E4 File Offset: 0x008C5BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCombatExpressionInfo(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			List<ConfigDataBigExpressionInfo> combatExpressionInfo = bigExpressionController.m_luaExportHelper.GetCombatExpressionInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatExpressionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5BE RID: 116158 RVA: 0x008C7A40 File Offset: 0x008C5C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			bigExpressionController.m_luaExportHelper.OnExpressionClick(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5BF RID: 116159 RVA: 0x008C7A9C File Offset: 0x008C5C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBGMaskClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			bigExpressionController.m_luaExportHelper.OnBGMaskClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5C0 RID: 116160 RVA: 0x008C7AF0 File Offset: 0x008C5CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			bigExpressionController.m_luaExportHelper.OnEndDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5C1 RID: 116161 RVA: 0x008C7B4C File Offset: 0x008C5D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnValueChange(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			Vector2 rectEvent;
			LuaObject.checkType(l, 2, out rectEvent);
			bigExpressionController.m_luaExportHelper.OnValueChange(rectEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5C2 RID: 116162 RVA: 0x008C7BA8 File Offset: 0x008C5DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPagePointActivity(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			int pagePointActivity;
			LuaObject.checkType(l, 2, out pagePointActivity);
			bigExpressionController.m_luaExportHelper.SetPagePointActivity(pagePointActivity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5C3 RID: 116163 RVA: 0x008C7C04 File Offset: 0x008C5E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			bigExpressionController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5C4 RID: 116164 RVA: 0x008C7C70 File Offset: 0x008C5E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			bigExpressionController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5C5 RID: 116165 RVA: 0x008C7CC4 File Offset: 0x008C5EC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			bigExpressionController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5C6 RID: 116166 RVA: 0x008C7D18 File Offset: 0x008C5F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = bigExpressionController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C5C7 RID: 116167 RVA: 0x008C7DC0 File Offset: 0x008C5FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			bigExpressionController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5C8 RID: 116168 RVA: 0x008C7E14 File Offset: 0x008C6014
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			bigExpressionController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5C9 RID: 116169 RVA: 0x008C7E80 File Offset: 0x008C6080
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
				BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				bigExpressionController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BigExpressionController bigExpressionController2 = (BigExpressionController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				bigExpressionController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C5CA RID: 116170 RVA: 0x008C7F90 File Offset: 0x008C6190
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bigExpressionController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5CB RID: 116171 RVA: 0x008C7FFC File Offset: 0x008C61FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bigExpressionController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5CC RID: 116172 RVA: 0x008C8068 File Offset: 0x008C6268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bigExpressionController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5CD RID: 116173 RVA: 0x008C80D4 File Offset: 0x008C62D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bigExpressionController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5CE RID: 116174 RVA: 0x008C8140 File Offset: 0x008C6340
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
				BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				bigExpressionController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BigExpressionController bigExpressionController2 = (BigExpressionController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				bigExpressionController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C5CF RID: 116175 RVA: 0x008C8250 File Offset: 0x008C6450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			string s = bigExpressionController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C5D0 RID: 116176 RVA: 0x008C82AC File Offset: 0x008C64AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			bigExpressionController.m_luaExportHelper.__callDele_EventOnExpressionClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5D1 RID: 116177 RVA: 0x008C8308 File Offset: 0x008C6508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			bigExpressionController.m_luaExportHelper.__clearDele_EventOnExpressionClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5D2 RID: 116178 RVA: 0x008C8364 File Offset: 0x008C6564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bigExpressionController.EventOnExpressionClick += value;
				}
				else if (num == 2)
				{
					bigExpressionController.EventOnExpressionClick -= value;
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

	// Token: 0x0601C5D3 RID: 116179 RVA: 0x008C83E4 File Offset: 0x008C65E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_scrollRectLastPos(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.m_luaExportHelper.scrollRectLastPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5D4 RID: 116180 RVA: 0x008C843C File Offset: 0x008C663C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_scrollRectLastPos(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			float scrollRectLastPos;
			LuaObject.checkType(l, 2, out scrollRectLastPos);
			bigExpressionController.m_luaExportHelper.scrollRectLastPos = scrollRectLastPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5D5 RID: 116181 RVA: 0x008C8498 File Offset: 0x008C6698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pageCapacity(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.m_luaExportHelper.m_pageCapacity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5D6 RID: 116182 RVA: 0x008C84F0 File Offset: 0x008C66F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pageCapacity(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			int pageCapacity;
			LuaObject.checkType(l, 2, out pageCapacity);
			bigExpressionController.m_luaExportHelper.m_pageCapacity = pageCapacity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5D7 RID: 116183 RVA: 0x008C854C File Offset: 0x008C674C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bigExpressionItemList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.m_luaExportHelper.bigExpressionItemList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5D8 RID: 116184 RVA: 0x008C85A4 File Offset: 0x008C67A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bigExpressionItemList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			List<BigExpressionItem> bigExpressionItemList;
			LuaObject.checkType<List<BigExpressionItem>>(l, 2, out bigExpressionItemList);
			bigExpressionController.m_luaExportHelper.bigExpressionItemList = bigExpressionItemList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5D9 RID: 116185 RVA: 0x008C8600 File Offset: 0x008C6800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pageList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.m_luaExportHelper.m_pageList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5DA RID: 116186 RVA: 0x008C8658 File Offset: 0x008C6858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pageList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			List<GameObject> pageList;
			LuaObject.checkType<List<GameObject>>(l, 2, out pageList);
			bigExpressionController.m_luaExportHelper.m_pageList = pageList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5DB RID: 116187 RVA: 0x008C86B4 File Offset: 0x008C68B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pagePointStateControllerList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.m_luaExportHelper.m_pagePointStateControllerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5DC RID: 116188 RVA: 0x008C870C File Offset: 0x008C690C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pagePointStateControllerList(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			List<CommonUIStateController> pagePointStateControllerList;
			LuaObject.checkType<List<CommonUIStateController>>(l, 2, out pagePointStateControllerList);
			bigExpressionController.m_luaExportHelper.m_pagePointStateControllerList = pagePointStateControllerList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5DD RID: 116189 RVA: 0x008C8768 File Offset: 0x008C6968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Content(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.Content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5DE RID: 116190 RVA: 0x008C87BC File Offset: 0x008C69BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Content(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			GameObject content;
			LuaObject.checkType<GameObject>(l, 2, out content);
			bigExpressionController.Content = content;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5DF RID: 116191 RVA: 0x008C8814 File Offset: 0x008C6A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Expression(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.Expression);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5E0 RID: 116192 RVA: 0x008C8868 File Offset: 0x008C6A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Expression(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			GameObject expression;
			LuaObject.checkType<GameObject>(l, 2, out expression);
			bigExpressionController.Expression = expression;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5E1 RID: 116193 RVA: 0x008C88C0 File Offset: 0x008C6AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Page(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.Page);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5E2 RID: 116194 RVA: 0x008C8914 File Offset: 0x008C6B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Page(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			GameObject page;
			LuaObject.checkType<GameObject>(l, 2, out page);
			bigExpressionController.Page = page;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5E3 RID: 116195 RVA: 0x008C896C File Offset: 0x008C6B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PagePointNode(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.PagePointNode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5E4 RID: 116196 RVA: 0x008C89C0 File Offset: 0x008C6BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PagePointNode(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			GameObject pagePointNode;
			LuaObject.checkType<GameObject>(l, 2, out pagePointNode);
			bigExpressionController.PagePointNode = pagePointNode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5E5 RID: 116197 RVA: 0x008C8A18 File Offset: 0x008C6C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PagePoint(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.PagePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5E6 RID: 116198 RVA: 0x008C8A6C File Offset: 0x008C6C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PagePoint(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			GameObject pagePoint;
			LuaObject.checkType<GameObject>(l, 2, out pagePoint);
			bigExpressionController.PagePoint = pagePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5E7 RID: 116199 RVA: 0x008C8AC4 File Offset: 0x008C6CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScrollView(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionController.ScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5E8 RID: 116200 RVA: 0x008C8B18 File Offset: 0x008C6D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScrollView(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionController bigExpressionController = (BigExpressionController)LuaObject.checkSelf(l);
			ScrollRect scrollView;
			LuaObject.checkType<ScrollRect>(l, 2, out scrollView);
			bigExpressionController.ScrollView = scrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C5E9 RID: 116201 RVA: 0x008C8B70 File Offset: 0x008C6D70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BigExpressionController");
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.GetCombatExpressionInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.OnExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.OnBGMaskClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.OnValueChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.SetPagePointActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__callDele_EventOnExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.__clearDele_EventOnExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache16);
		string name = "EventOnExpressionClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_EventOnExpressionClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache17, true);
		string name2 = "scrollRectLastPos";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_scrollRectLastPos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_scrollRectLastPos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache19, true);
		string name3 = "m_pageCapacity";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_m_pageCapacity);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_m_pageCapacity);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1B, true);
		string name4 = "bigExpressionItemList";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_bigExpressionItemList);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_bigExpressionItemList);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1D, true);
		string name5 = "m_pageList";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_m_pageList);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_m_pageList);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache1F, true);
		string name6 = "m_pagePointStateControllerList";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_m_pagePointStateControllerList);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_m_pagePointStateControllerList);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache21, true);
		string name7 = "Content";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_Content);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_Content);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache23, true);
		string name8 = "Expression";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_Expression);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_Expression);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache25, true);
		string name9 = "Page";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_Page);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_Page);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache27, true);
		string name10 = "PagePointNode";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_PagePointNode);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_PagePointNode);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache29, true);
		string name11 = "PagePoint";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_PagePoint);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_PagePoint);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2B, true);
		string name12 = "ScrollView";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.get_ScrollView);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionController.set_ScrollView);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BigExpressionController.<>f__mg$cache2D, true);
		LuaObject.createTypeMetatable(l, null, typeof(BigExpressionController), typeof(UIControllerBase));
	}

	// Token: 0x040127FF RID: 75775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012800 RID: 75776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012801 RID: 75777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012802 RID: 75778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012803 RID: 75779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012804 RID: 75780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012805 RID: 75781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012806 RID: 75782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012807 RID: 75783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012808 RID: 75784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012809 RID: 75785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401280A RID: 75786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401280B RID: 75787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401280C RID: 75788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401280D RID: 75789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401280E RID: 75790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401280F RID: 75791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012810 RID: 75792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012811 RID: 75793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012812 RID: 75794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012813 RID: 75795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012814 RID: 75796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012815 RID: 75797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012816 RID: 75798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012817 RID: 75799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012818 RID: 75800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012819 RID: 75801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401281A RID: 75802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401281B RID: 75803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401281C RID: 75804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401281D RID: 75805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401281E RID: 75806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401281F RID: 75807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012820 RID: 75808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012821 RID: 75809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012822 RID: 75810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012823 RID: 75811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012824 RID: 75812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012825 RID: 75813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012826 RID: 75814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012827 RID: 75815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012828 RID: 75816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012829 RID: 75817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401282A RID: 75818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401282B RID: 75819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401282C RID: 75820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
