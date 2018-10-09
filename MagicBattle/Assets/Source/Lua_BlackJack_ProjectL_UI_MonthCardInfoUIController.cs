using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001515 RID: 5397
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController : LuaObject
{
	// Token: 0x0601FFE1 RID: 131041 RVA: 0x00A95998 File Offset: 0x00A93B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowReward(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			int monrhCardId;
			LuaObject.checkType(l, 2, out monrhCardId);
			monthCardInfoUIController.ShowReward(monrhCardId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFE2 RID: 131042 RVA: 0x00A959F0 File Offset: 0x00A93BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			monthCardInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFE3 RID: 131043 RVA: 0x00A95A44 File Offset: 0x00A93C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			monthCardInfoUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFE4 RID: 131044 RVA: 0x00A95A98 File Offset: 0x00A93C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			monthCardInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFE5 RID: 131045 RVA: 0x00A95B04 File Offset: 0x00A93D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			monthCardInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFE6 RID: 131046 RVA: 0x00A95B58 File Offset: 0x00A93D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			monthCardInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFE7 RID: 131047 RVA: 0x00A95BAC File Offset: 0x00A93DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = monthCardInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FFE8 RID: 131048 RVA: 0x00A95C54 File Offset: 0x00A93E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			monthCardInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFE9 RID: 131049 RVA: 0x00A95CA8 File Offset: 0x00A93EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			monthCardInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFEA RID: 131050 RVA: 0x00A95D14 File Offset: 0x00A93F14
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
				MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				monthCardInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				MonthCardInfoUIController monthCardInfoUIController2 = (MonthCardInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				monthCardInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FFEB RID: 131051 RVA: 0x00A95E24 File Offset: 0x00A94024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			monthCardInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFEC RID: 131052 RVA: 0x00A95E90 File Offset: 0x00A94090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			monthCardInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFED RID: 131053 RVA: 0x00A95EFC File Offset: 0x00A940FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			monthCardInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFEE RID: 131054 RVA: 0x00A95F68 File Offset: 0x00A94168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			monthCardInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFEF RID: 131055 RVA: 0x00A95FD4 File Offset: 0x00A941D4
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
				MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				monthCardInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				MonthCardInfoUIController monthCardInfoUIController2 = (MonthCardInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				monthCardInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FFF0 RID: 131056 RVA: 0x00A960E4 File Offset: 0x00A942E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			string s = monthCardInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FFF1 RID: 131057 RVA: 0x00A96140 File Offset: 0x00A94340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			monthCardInfoUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFF2 RID: 131058 RVA: 0x00A96194 File Offset: 0x00A94394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			monthCardInfoUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFF3 RID: 131059 RVA: 0x00A961E8 File Offset: 0x00A943E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					monthCardInfoUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					monthCardInfoUIController.EventOnClose -= value;
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

	// Token: 0x0601FFF4 RID: 131060 RVA: 0x00A96268 File Offset: 0x00A94468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PanelStateController(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUIController.m_luaExportHelper.PanelStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFF5 RID: 131061 RVA: 0x00A962C0 File Offset: 0x00A944C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PanelStateController(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController panelStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out panelStateController);
			monthCardInfoUIController.m_luaExportHelper.PanelStateController = panelStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFF6 RID: 131062 RVA: 0x00A9631C File Offset: 0x00A9451C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUIController.m_luaExportHelper.BackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFF7 RID: 131063 RVA: 0x00A96374 File Offset: 0x00A94574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			monthCardInfoUIController.m_luaExportHelper.BackgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFF8 RID: 131064 RVA: 0x00A963D0 File Offset: 0x00A945D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameText(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUIController.m_luaExportHelper.NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFF9 RID: 131065 RVA: 0x00A96428 File Offset: 0x00A94628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameText(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			monthCardInfoUIController.m_luaExportHelper.NameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFFA RID: 131066 RVA: 0x00A96484 File Offset: 0x00A94684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IconImage(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUIController.m_luaExportHelper.IconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFFB RID: 131067 RVA: 0x00A964DC File Offset: 0x00A946DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IconImage(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			monthCardInfoUIController.m_luaExportHelper.IconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFFC RID: 131068 RVA: 0x00A96538 File Offset: 0x00A94738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LeftDaysGameObject(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUIController.m_luaExportHelper.LeftDaysGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFFD RID: 131069 RVA: 0x00A96590 File Offset: 0x00A94790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LeftDaysGameObject(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			GameObject leftDaysGameObject;
			LuaObject.checkType<GameObject>(l, 2, out leftDaysGameObject);
			monthCardInfoUIController.m_luaExportHelper.LeftDaysGameObject = leftDaysGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFFE RID: 131070 RVA: 0x00A965EC File Offset: 0x00A947EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LeftDays(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUIController.m_luaExportHelper.LeftDays);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FFFF RID: 131071 RVA: 0x00A96644 File Offset: 0x00A94844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LeftDays(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			Text leftDays;
			LuaObject.checkType<Text>(l, 2, out leftDays);
			monthCardInfoUIController.m_luaExportHelper.LeftDays = leftDays;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020000 RID: 131072 RVA: 0x00A966A0 File Offset: 0x00A948A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MonthCardOrSubscribeStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUIController.m_luaExportHelper.MonthCardOrSubscribeStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020001 RID: 131073 RVA: 0x00A966F8 File Offset: 0x00A948F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonthCardOrSubscribeStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController monthCardOrSubscribeStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out monthCardOrSubscribeStateCtrl);
			monthCardInfoUIController.m_luaExportHelper.MonthCardOrSubscribeStateCtrl = monthCardOrSubscribeStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020002 RID: 131074 RVA: 0x00A96754 File Offset: 0x00A94954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescText(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCardInfoUIController.m_luaExportHelper.DescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020003 RID: 131075 RVA: 0x00A967AC File Offset: 0x00A949AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DescText(IntPtr l)
	{
		int result;
		try
		{
			MonthCardInfoUIController monthCardInfoUIController = (MonthCardInfoUIController)LuaObject.checkSelf(l);
			Text descText;
			LuaObject.checkType<Text>(l, 2, out descText);
			monthCardInfoUIController.m_luaExportHelper.DescText = descText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020004 RID: 131076 RVA: 0x00A96808 File Offset: 0x00A94A08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MonthCardInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.ShowReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache11);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache12, true);
		string name2 = "PanelStateController";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.get_PanelStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.set_PanelStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache14, true);
		string name3 = "BackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.get_BackgroundButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.set_BackgroundButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache16, true);
		string name4 = "NameText";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.get_NameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.set_NameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache18, true);
		string name5 = "IconImage";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.get_IconImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.set_IconImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1A, true);
		string name6 = "LeftDaysGameObject";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.get_LeftDaysGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.set_LeftDaysGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1C, true);
		string name7 = "LeftDays";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.get_LeftDays);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.set_LeftDays);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1E, true);
		string name8 = "MonthCardOrSubscribeStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.get_MonthCardOrSubscribeStateCtrl);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.set_MonthCardOrSubscribeStateCtrl);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache20, true);
		string name9 = "DescText";
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.get_DescText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.set_DescText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.<>f__mg$cache22, true);
		LuaObject.createTypeMetatable(l, null, typeof(MonthCardInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015F99 RID: 90009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015F9A RID: 90010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015F9B RID: 90011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015F9C RID: 90012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015F9D RID: 90013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015F9E RID: 90014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015F9F RID: 90015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015FA0 RID: 90016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015FA1 RID: 90017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015FA2 RID: 90018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015FA3 RID: 90019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015FA4 RID: 90020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015FA5 RID: 90021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015FA6 RID: 90022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015FA7 RID: 90023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015FA8 RID: 90024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015FA9 RID: 90025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015FAA RID: 90026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015FAB RID: 90027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015FAC RID: 90028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015FAD RID: 90029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015FAE RID: 90030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015FAF RID: 90031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015FB0 RID: 90032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015FB1 RID: 90033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015FB2 RID: 90034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015FB3 RID: 90035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015FB4 RID: 90036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015FB5 RID: 90037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015FB6 RID: 90038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015FB7 RID: 90039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015FB8 RID: 90040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015FB9 RID: 90041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015FBA RID: 90042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015FBB RID: 90043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;
}
