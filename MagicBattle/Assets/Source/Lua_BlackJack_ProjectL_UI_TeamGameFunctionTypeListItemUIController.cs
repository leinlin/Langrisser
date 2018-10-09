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

// Token: 0x02001591 RID: 5521
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController : LuaObject
{
	// Token: 0x06021629 RID: 136745 RVA: 0x00B47F30 File Offset: 0x00B46130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			teamGameFunctionTypeListItemUIController.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602162A RID: 136746 RVA: 0x00B47F88 File Offset: 0x00B46188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			string name = teamGameFunctionTypeListItemUIController.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602162B RID: 136747 RVA: 0x00B47FDC File Offset: 0x00B461DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			teamGameFunctionTypeListItemUIController.SetGameFunctionType(gameFunctionType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602162C RID: 136748 RVA: 0x00B48034 File Offset: 0x00B46234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType = teamGameFunctionTypeListItemUIController.GetGameFunctionType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)gameFunctionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602162D RID: 136749 RVA: 0x00B48088 File Offset: 0x00B46288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChapterId(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			teamGameFunctionTypeListItemUIController.SetChapterId(chapterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602162E RID: 136750 RVA: 0x00B480E0 File Offset: 0x00B462E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChapterId(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			int chapterId = teamGameFunctionTypeListItemUIController.GetChapterId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chapterId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602162F RID: 136751 RVA: 0x00B48134 File Offset: 0x00B46334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			teamGameFunctionTypeListItemUIController.SetLocked(locked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021630 RID: 136752 RVA: 0x00B4818C File Offset: 0x00B4638C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			bool b = teamGameFunctionTypeListItemUIController.IsLocked();
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

	// Token: 0x06021631 RID: 136753 RVA: 0x00B481E0 File Offset: 0x00B463E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToggleValue(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			bool toggleValue;
			LuaObject.checkType(l, 2, out toggleValue);
			teamGameFunctionTypeListItemUIController.SetToggleValue(toggleValue);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021632 RID: 136754 RVA: 0x00B48238 File Offset: 0x00B46438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetToggleValue(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			bool toggleValue = teamGameFunctionTypeListItemUIController.GetToggleValue();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, toggleValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021633 RID: 136755 RVA: 0x00B4828C File Offset: 0x00B4648C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021634 RID: 136756 RVA: 0x00B482E0 File Offset: 0x00B464E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.OnToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021635 RID: 136757 RVA: 0x00B4833C File Offset: 0x00B4653C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.OnLockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021636 RID: 136758 RVA: 0x00B48390 File Offset: 0x00B46590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021637 RID: 136759 RVA: 0x00B483FC File Offset: 0x00B465FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021638 RID: 136760 RVA: 0x00B48450 File Offset: 0x00B46650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021639 RID: 136761 RVA: 0x00B484A4 File Offset: 0x00B466A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602163A RID: 136762 RVA: 0x00B4854C File Offset: 0x00B4674C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602163B RID: 136763 RVA: 0x00B485A0 File Offset: 0x00B467A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602163C RID: 136764 RVA: 0x00B4860C File Offset: 0x00B4680C
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
				TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController2 = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				teamGameFunctionTypeListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602163D RID: 136765 RVA: 0x00B4871C File Offset: 0x00B4691C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602163E RID: 136766 RVA: 0x00B48788 File Offset: 0x00B46988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602163F RID: 136767 RVA: 0x00B487F4 File Offset: 0x00B469F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021640 RID: 136768 RVA: 0x00B48860 File Offset: 0x00B46A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021641 RID: 136769 RVA: 0x00B488CC File Offset: 0x00B46ACC
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
				TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController2 = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				teamGameFunctionTypeListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021642 RID: 136770 RVA: 0x00B489DC File Offset: 0x00B46BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			string s = teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021643 RID: 136771 RVA: 0x00B48A38 File Offset: 0x00B46C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			TeamGameFunctionTypeListItemUIController arg2;
			LuaObject.checkType<TeamGameFunctionTypeListItemUIController>(l, 3, out arg2);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__callDele_EventOnToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021644 RID: 136772 RVA: 0x00B48AA4 File Offset: 0x00B46CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			TeamGameFunctionTypeListItemUIController arg2;
			LuaObject.checkType<TeamGameFunctionTypeListItemUIController>(l, 3, out arg2);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.__clearDele_EventOnToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021645 RID: 136773 RVA: 0x00B48B10 File Offset: 0x00B46D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			Action<bool, TeamGameFunctionTypeListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<bool, TeamGameFunctionTypeListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamGameFunctionTypeListItemUIController.EventOnToggleValueChanged += value;
				}
				else if (num == 2)
				{
					teamGameFunctionTypeListItemUIController.EventOnToggleValueChanged -= value;
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

	// Token: 0x06021646 RID: 136774 RVA: 0x00B48B90 File Offset: 0x00B46D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021647 RID: 136775 RVA: 0x00B48BE8 File Offset: 0x00B46DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_toggle = toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021648 RID: 136776 RVA: 0x00B48C44 File Offset: 0x00B46E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021649 RID: 136777 RVA: 0x00B48C9C File Offset: 0x00B46E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602164A RID: 136778 RVA: 0x00B48CF8 File Offset: 0x00B46EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameTextChosen(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_nameTextChosen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602164B RID: 136779 RVA: 0x00B48D50 File Offset: 0x00B46F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameTextChosen(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			Text nameTextChosen;
			LuaObject.checkType<Text>(l, 2, out nameTextChosen);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_nameTextChosen = nameTextChosen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602164C RID: 136780 RVA: 0x00B48DAC File Offset: 0x00B46FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameTextUnchosen(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_nameTextUnchosen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602164D RID: 136781 RVA: 0x00B48E04 File Offset: 0x00B47004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameTextUnchosen(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			Text nameTextUnchosen;
			LuaObject.checkType<Text>(l, 2, out nameTextUnchosen);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_nameTextUnchosen = nameTextUnchosen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602164E RID: 136782 RVA: 0x00B48E60 File Offset: 0x00B47060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameTextLock(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_nameTextLock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602164F RID: 136783 RVA: 0x00B48EB8 File Offset: 0x00B470B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameTextLock(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			Text nameTextLock;
			LuaObject.checkType<Text>(l, 2, out nameTextLock);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_nameTextLock = nameTextLock;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021650 RID: 136784 RVA: 0x00B48F14 File Offset: 0x00B47114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockButton(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_lockButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021651 RID: 136785 RVA: 0x00B48F6C File Offset: 0x00B4716C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockButton(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			Button lockButton;
			LuaObject.checkType<Button>(l, 2, out lockButton);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_lockButton = lockButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021652 RID: 136786 RVA: 0x00B48FC8 File Offset: 0x00B471C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_isLocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021653 RID: 136787 RVA: 0x00B49020 File Offset: 0x00B47220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			bool isLocked;
			LuaObject.checkType(l, 2, out isLocked);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_isLocked = isLocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021654 RID: 136788 RVA: 0x00B4907C File Offset: 0x00B4727C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_gameFunctionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021655 RID: 136789 RVA: 0x00B490D4 File Offset: 0x00B472D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_gameFunctionType = gameFunctionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021656 RID: 136790 RVA: 0x00B49130 File Offset: 0x00B47330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chapterId(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_chapterId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021657 RID: 136791 RVA: 0x00B49188 File Offset: 0x00B47388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_chapterId(IntPtr l)
	{
		int result;
		try
		{
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = (TeamGameFunctionTypeListItemUIController)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			teamGameFunctionTypeListItemUIController.m_luaExportHelper.m_chapterId = chapterId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021658 RID: 136792 RVA: 0x00B491E4 File Offset: 0x00B473E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamGameFunctionTypeListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.SetGameFunctionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.GetGameFunctionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.SetChapterId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.GetChapterId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.IsLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.SetToggleValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.GetToggleValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.OnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.OnLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__callDele_EventOnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.__clearDele_EventOnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1B);
		string name = "EventOnToggleValueChanged";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.set_EventOnToggleValueChanged);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1C, true);
		string name2 = "m_toggle";
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.get_m_toggle);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.set_m_toggle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1E, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache20, true);
		string name4 = "m_nameTextChosen";
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.get_m_nameTextChosen);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.set_m_nameTextChosen);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache22, true);
		string name5 = "m_nameTextUnchosen";
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.get_m_nameTextUnchosen);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.set_m_nameTextUnchosen);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache24, true);
		string name6 = "m_nameTextLock";
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.get_m_nameTextLock);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.set_m_nameTextLock);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache26, true);
		string name7 = "m_lockButton";
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.get_m_lockButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.set_m_lockButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache28, true);
		string name8 = "m_isLocked";
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.get_m_isLocked);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.set_m_isLocked);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2A, true);
		string name9 = "m_gameFunctionType";
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.get_m_gameFunctionType);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.set_m_gameFunctionType);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2C, true);
		string name10 = "m_chapterId";
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.get_m_chapterId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.set_m_chapterId);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.<>f__mg$cache2E, true);
		LuaObject.createTypeMetatable(l, null, typeof(TeamGameFunctionTypeListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040174E9 RID: 95465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040174EA RID: 95466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040174EB RID: 95467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040174EC RID: 95468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040174ED RID: 95469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040174EE RID: 95470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040174EF RID: 95471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040174F0 RID: 95472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040174F1 RID: 95473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040174F2 RID: 95474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040174F3 RID: 95475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040174F4 RID: 95476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040174F5 RID: 95477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040174F6 RID: 95478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040174F7 RID: 95479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040174F8 RID: 95480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040174F9 RID: 95481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040174FA RID: 95482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040174FB RID: 95483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040174FC RID: 95484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040174FD RID: 95485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040174FE RID: 95486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040174FF RID: 95487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017500 RID: 95488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017501 RID: 95489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017502 RID: 95490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017503 RID: 95491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017504 RID: 95492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017505 RID: 95493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017506 RID: 95494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017507 RID: 95495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017508 RID: 95496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017509 RID: 95497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401750A RID: 95498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401750B RID: 95499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401750C RID: 95500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401750D RID: 95501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401750E RID: 95502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401750F RID: 95503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017510 RID: 95504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017511 RID: 95505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017512 RID: 95506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017513 RID: 95507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017514 RID: 95508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017515 RID: 95509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017516 RID: 95510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017517 RID: 95511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
