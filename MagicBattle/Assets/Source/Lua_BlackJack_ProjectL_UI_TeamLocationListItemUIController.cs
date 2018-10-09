using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001592 RID: 5522
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController : LuaObject
{
	// Token: 0x0602165A RID: 136794 RVA: 0x00B49894 File Offset: 0x00B47A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			teamLocationListItemUIController.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602165B RID: 136795 RVA: 0x00B498EC File Offset: 0x00B47AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			string name = teamLocationListItemUIController.GetName();
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

	// Token: 0x0602165C RID: 136796 RVA: 0x00B49940 File Offset: 0x00B47B40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			teamLocationListItemUIController.SetLocationId(locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602165D RID: 136797 RVA: 0x00B49998 File Offset: 0x00B47B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			int locationId = teamLocationListItemUIController.GetLocationId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602165E RID: 136798 RVA: 0x00B499EC File Offset: 0x00B47BEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetEnergy(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			int energy;
			LuaObject.checkType(l, 2, out energy);
			teamLocationListItemUIController.SetEnergy(energy);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602165F RID: 136799 RVA: 0x00B49A44 File Offset: 0x00B47C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			teamLocationListItemUIController.SetLocked(locked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021660 RID: 136800 RVA: 0x00B49A9C File Offset: 0x00B47C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			bool b = teamLocationListItemUIController.IsLocked();
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

	// Token: 0x06021661 RID: 136801 RVA: 0x00B49AF0 File Offset: 0x00B47CF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetToggleValue(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			bool toggleValue;
			LuaObject.checkType(l, 2, out toggleValue);
			teamLocationListItemUIController.SetToggleValue(toggleValue);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021662 RID: 136802 RVA: 0x00B49B48 File Offset: 0x00B47D48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetToggleValue(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			bool toggleValue = teamLocationListItemUIController.GetToggleValue();
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

	// Token: 0x06021663 RID: 136803 RVA: 0x00B49B9C File Offset: 0x00B47D9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			teamLocationListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021664 RID: 136804 RVA: 0x00B49BF0 File Offset: 0x00B47DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			teamLocationListItemUIController.m_luaExportHelper.OnToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021665 RID: 136805 RVA: 0x00B49C4C File Offset: 0x00B47E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			teamLocationListItemUIController.m_luaExportHelper.OnLockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021666 RID: 136806 RVA: 0x00B49CA0 File Offset: 0x00B47EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			teamLocationListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021667 RID: 136807 RVA: 0x00B49D0C File Offset: 0x00B47F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			teamLocationListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021668 RID: 136808 RVA: 0x00B49D60 File Offset: 0x00B47F60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			teamLocationListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021669 RID: 136809 RVA: 0x00B49DB4 File Offset: 0x00B47FB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = teamLocationListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602166A RID: 136810 RVA: 0x00B49E5C File Offset: 0x00B4805C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			teamLocationListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602166B RID: 136811 RVA: 0x00B49EB0 File Offset: 0x00B480B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			teamLocationListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602166C RID: 136812 RVA: 0x00B49F1C File Offset: 0x00B4811C
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
				TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				teamLocationListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TeamLocationListItemUIController teamLocationListItemUIController2 = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				teamLocationListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602166D RID: 136813 RVA: 0x00B4A02C File Offset: 0x00B4822C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamLocationListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602166E RID: 136814 RVA: 0x00B4A098 File Offset: 0x00B48298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamLocationListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602166F RID: 136815 RVA: 0x00B4A104 File Offset: 0x00B48304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamLocationListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021670 RID: 136816 RVA: 0x00B4A170 File Offset: 0x00B48370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamLocationListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021671 RID: 136817 RVA: 0x00B4A1DC File Offset: 0x00B483DC
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
				TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				teamLocationListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TeamLocationListItemUIController teamLocationListItemUIController2 = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				teamLocationListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021672 RID: 136818 RVA: 0x00B4A2EC File Offset: 0x00B484EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			string s = teamLocationListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021673 RID: 136819 RVA: 0x00B4A348 File Offset: 0x00B48548
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			TeamLocationListItemUIController arg2;
			LuaObject.checkType<TeamLocationListItemUIController>(l, 3, out arg2);
			teamLocationListItemUIController.m_luaExportHelper.__callDele_EventOnToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021674 RID: 136820 RVA: 0x00B4A3B4 File Offset: 0x00B485B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			TeamLocationListItemUIController arg2;
			LuaObject.checkType<TeamLocationListItemUIController>(l, 3, out arg2);
			teamLocationListItemUIController.m_luaExportHelper.__clearDele_EventOnToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021675 RID: 136821 RVA: 0x00B4A420 File Offset: 0x00B48620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Action<bool, TeamLocationListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<bool, TeamLocationListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamLocationListItemUIController.EventOnToggleValueChanged += value;
				}
				else if (num == 2)
				{
					teamLocationListItemUIController.EventOnToggleValueChanged -= value;
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

	// Token: 0x06021676 RID: 136822 RVA: 0x00B4A4A0 File Offset: 0x00B486A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021677 RID: 136823 RVA: 0x00B4A4F8 File Offset: 0x00B486F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			teamLocationListItemUIController.m_luaExportHelper.m_toggle = toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021678 RID: 136824 RVA: 0x00B4A554 File Offset: 0x00B48754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021679 RID: 136825 RVA: 0x00B4A5AC File Offset: 0x00B487AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			teamLocationListItemUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602167A RID: 136826 RVA: 0x00B4A608 File Offset: 0x00B48808
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_energyIconImage(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_energyIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602167B RID: 136827 RVA: 0x00B4A660 File Offset: 0x00B48860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyIconImage(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Image energyIconImage;
			LuaObject.checkType<Image>(l, 2, out energyIconImage);
			teamLocationListItemUIController.m_luaExportHelper.m_energyIconImage = energyIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602167C RID: 136828 RVA: 0x00B4A6BC File Offset: 0x00B488BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameTextChosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_nameTextChosen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602167D RID: 136829 RVA: 0x00B4A714 File Offset: 0x00B48914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameTextChosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Text nameTextChosen;
			LuaObject.checkType<Text>(l, 2, out nameTextChosen);
			teamLocationListItemUIController.m_luaExportHelper.m_nameTextChosen = nameTextChosen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602167E RID: 136830 RVA: 0x00B4A770 File Offset: 0x00B48970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyTextChosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_energyTextChosen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602167F RID: 136831 RVA: 0x00B4A7C8 File Offset: 0x00B489C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyTextChosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Text energyTextChosen;
			LuaObject.checkType<Text>(l, 2, out energyTextChosen);
			teamLocationListItemUIController.m_luaExportHelper.m_energyTextChosen = energyTextChosen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021680 RID: 136832 RVA: 0x00B4A824 File Offset: 0x00B48A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyXTextChosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_energyXTextChosen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021681 RID: 136833 RVA: 0x00B4A87C File Offset: 0x00B48A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyXTextChosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Text energyXTextChosen;
			LuaObject.checkType<Text>(l, 2, out energyXTextChosen);
			teamLocationListItemUIController.m_luaExportHelper.m_energyXTextChosen = energyXTextChosen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021682 RID: 136834 RVA: 0x00B4A8D8 File Offset: 0x00B48AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameTextUnchosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_nameTextUnchosen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021683 RID: 136835 RVA: 0x00B4A930 File Offset: 0x00B48B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameTextUnchosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Text nameTextUnchosen;
			LuaObject.checkType<Text>(l, 2, out nameTextUnchosen);
			teamLocationListItemUIController.m_luaExportHelper.m_nameTextUnchosen = nameTextUnchosen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021684 RID: 136836 RVA: 0x00B4A98C File Offset: 0x00B48B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyTextUnchosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_energyTextUnchosen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021685 RID: 136837 RVA: 0x00B4A9E4 File Offset: 0x00B48BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyTextUnchosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Text energyTextUnchosen;
			LuaObject.checkType<Text>(l, 2, out energyTextUnchosen);
			teamLocationListItemUIController.m_luaExportHelper.m_energyTextUnchosen = energyTextUnchosen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021686 RID: 136838 RVA: 0x00B4AA40 File Offset: 0x00B48C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyXTextUnchosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_energyXTextUnchosen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021687 RID: 136839 RVA: 0x00B4AA98 File Offset: 0x00B48C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyXTextUnchosen(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Text energyXTextUnchosen;
			LuaObject.checkType<Text>(l, 2, out energyXTextUnchosen);
			teamLocationListItemUIController.m_luaExportHelper.m_energyXTextUnchosen = energyXTextUnchosen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021688 RID: 136840 RVA: 0x00B4AAF4 File Offset: 0x00B48CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockButton(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_lockButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021689 RID: 136841 RVA: 0x00B4AB4C File Offset: 0x00B48D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockButton(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			Button lockButton;
			LuaObject.checkType<Button>(l, 2, out lockButton);
			teamLocationListItemUIController.m_luaExportHelper.m_lockButton = lockButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602168A RID: 136842 RVA: 0x00B4ABA8 File Offset: 0x00B48DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_isLocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602168B RID: 136843 RVA: 0x00B4AC00 File Offset: 0x00B48E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			bool isLocked;
			LuaObject.checkType(l, 2, out isLocked);
			teamLocationListItemUIController.m_luaExportHelper.m_isLocked = isLocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602168C RID: 136844 RVA: 0x00B4AC5C File Offset: 0x00B48E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationId(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamLocationListItemUIController.m_luaExportHelper.m_locationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602168D RID: 136845 RVA: 0x00B4ACB4 File Offset: 0x00B48EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationId(IntPtr l)
	{
		int result;
		try
		{
			TeamLocationListItemUIController teamLocationListItemUIController = (TeamLocationListItemUIController)LuaObject.checkSelf(l);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			teamLocationListItemUIController.m_luaExportHelper.m_locationId = locationId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602168E RID: 136846 RVA: 0x00B4AD10 File Offset: 0x00B48F10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamLocationListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.SetLocationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.GetLocationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.SetEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.IsLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.SetToggleValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.GetToggleValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.OnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.OnLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__callDele_EventOnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.__clearDele_EventOnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1A);
		string name = "EventOnToggleValueChanged";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_EventOnToggleValueChanged);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1B, true);
		string name2 = "m_toggle";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_toggle);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_toggle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1D, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache1F, true);
		string name4 = "m_energyIconImage";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_energyIconImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_energyIconImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache21, true);
		string name5 = "m_nameTextChosen";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_nameTextChosen);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_nameTextChosen);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache23, true);
		string name6 = "m_energyTextChosen";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_energyTextChosen);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_energyTextChosen);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache25, true);
		string name7 = "m_energyXTextChosen";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_energyXTextChosen);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_energyXTextChosen);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache27, true);
		string name8 = "m_nameTextUnchosen";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_nameTextUnchosen);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_nameTextUnchosen);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache29, true);
		string name9 = "m_energyTextUnchosen";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_energyTextUnchosen);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_energyTextUnchosen);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2B, true);
		string name10 = "m_energyXTextUnchosen";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_energyXTextUnchosen);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_energyXTextUnchosen);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2D, true);
		string name11 = "m_lockButton";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_lockButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_lockButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache2F, true);
		string name12 = "m_isLocked";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_isLocked);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_isLocked);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache31, true);
		string name13 = "m_locationId";
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.get_m_locationId);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.set_m_locationId);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.<>f__mg$cache33, true);
		LuaObject.createTypeMetatable(l, null, typeof(TeamLocationListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017518 RID: 95512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017519 RID: 95513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401751A RID: 95514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401751B RID: 95515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401751C RID: 95516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401751D RID: 95517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401751E RID: 95518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401751F RID: 95519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017520 RID: 95520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017521 RID: 95521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017522 RID: 95522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017523 RID: 95523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017524 RID: 95524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017525 RID: 95525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017526 RID: 95526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017527 RID: 95527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017528 RID: 95528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017529 RID: 95529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401752A RID: 95530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401752B RID: 95531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401752C RID: 95532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401752D RID: 95533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401752E RID: 95534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401752F RID: 95535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017530 RID: 95536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017531 RID: 95537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017532 RID: 95538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017533 RID: 95539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017534 RID: 95540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017535 RID: 95541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017536 RID: 95542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017537 RID: 95543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017538 RID: 95544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017539 RID: 95545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401753A RID: 95546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401753B RID: 95547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401753C RID: 95548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401753D RID: 95549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401753E RID: 95550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401753F RID: 95551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017540 RID: 95552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017541 RID: 95553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017542 RID: 95554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017543 RID: 95555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017544 RID: 95556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017545 RID: 95557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017546 RID: 95558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017547 RID: 95559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017548 RID: 95560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017549 RID: 95561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401754A RID: 95562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401754B RID: 95563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;
}
