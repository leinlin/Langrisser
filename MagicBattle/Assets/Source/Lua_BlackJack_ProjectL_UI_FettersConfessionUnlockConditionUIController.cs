using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001439 RID: 5177
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController : LuaObject
{
	// Token: 0x0601DBB0 RID: 121776 RVA: 0x00976560 File Offset: 0x00974760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitFettersConfessionUnlockCondition(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			int heroFetterId;
			LuaObject.checkType(l, 2, out heroFetterId);
			int confessLevel;
			LuaObject.checkType(l, 3, out confessLevel);
			bool isFetterUnLock;
			LuaObject.checkType(l, 4, out isFetterUnLock);
			int curLevel;
			LuaObject.checkType(l, 5, out curLevel);
			fettersConfessionUnlockConditionUIController.InitFettersConfessionUnlockCondition(heroFetterId, confessLevel, isFetterUnLock, curLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBB1 RID: 121777 RVA: 0x009765E0 File Offset: 0x009747E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBB2 RID: 121778 RVA: 0x00976634 File Offset: 0x00974834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBB3 RID: 121779 RVA: 0x009766A0 File Offset: 0x009748A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBB4 RID: 121780 RVA: 0x009766F4 File Offset: 0x009748F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBB5 RID: 121781 RVA: 0x00976748 File Offset: 0x00974948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DBB6 RID: 121782 RVA: 0x009767F0 File Offset: 0x009749F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBB7 RID: 121783 RVA: 0x00976844 File Offset: 0x00974A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBB8 RID: 121784 RVA: 0x009768B0 File Offset: 0x00974AB0
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
				FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController2 = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersConfessionUnlockConditionUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DBB9 RID: 121785 RVA: 0x009769C0 File Offset: 0x00974BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBBA RID: 121786 RVA: 0x00976A2C File Offset: 0x00974C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBBB RID: 121787 RVA: 0x00976A98 File Offset: 0x00974C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBBC RID: 121788 RVA: 0x00976B04 File Offset: 0x00974D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBBD RID: 121789 RVA: 0x00976B70 File Offset: 0x00974D70
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
				FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController2 = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersConfessionUnlockConditionUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DBBE RID: 121790 RVA: 0x00976C80 File Offset: 0x00974E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			string s = fettersConfessionUnlockConditionUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DBBF RID: 121791 RVA: 0x00976CDC File Offset: 0x00974EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUnlockConditionUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBC0 RID: 121792 RVA: 0x00976D34 File Offset: 0x00974F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBC1 RID: 121793 RVA: 0x00976D90 File Offset: 0x00974F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillIconImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUnlockConditionUIController.m_luaExportHelper.m_skillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBC2 RID: 121794 RVA: 0x00976DE8 File Offset: 0x00974FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillIconImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			Image skillIconImage;
			LuaObject.checkType<Image>(l, 2, out skillIconImage);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.m_skillIconImage = skillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBC3 RID: 121795 RVA: 0x00976E44 File Offset: 0x00975044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUnlockConditionUIController.m_luaExportHelper.m_skillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBC4 RID: 121796 RVA: 0x00976E9C File Offset: 0x0097509C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			Text skillNameText;
			LuaObject.checkType<Text>(l, 2, out skillNameText);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.m_skillNameText = skillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBC5 RID: 121797 RVA: 0x00976EF8 File Offset: 0x009750F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillCurLevelValue(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUnlockConditionUIController.m_luaExportHelper.m_skillCurLevelValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBC6 RID: 121798 RVA: 0x00976F50 File Offset: 0x00975150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillCurLevelValue(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			Text skillCurLevelValue;
			LuaObject.checkType<Text>(l, 2, out skillCurLevelValue);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.m_skillCurLevelValue = skillCurLevelValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBC7 RID: 121799 RVA: 0x00976FAC File Offset: 0x009751AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillMaxLevelValue(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUnlockConditionUIController.m_luaExportHelper.m_skillMaxLevelValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBC8 RID: 121800 RVA: 0x00977004 File Offset: 0x00975204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skillMaxLevelValue(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUnlockConditionUIController fettersConfessionUnlockConditionUIController = (FettersConfessionUnlockConditionUIController)LuaObject.checkSelf(l);
			Text skillMaxLevelValue;
			LuaObject.checkType<Text>(l, 2, out skillMaxLevelValue);
			fettersConfessionUnlockConditionUIController.m_luaExportHelper.m_skillMaxLevelValue = skillMaxLevelValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBC9 RID: 121801 RVA: 0x00977060 File Offset: 0x00975260
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersConfessionUnlockConditionUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.InitFettersConfessionUnlockCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheE);
		string name = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.get_m_stateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache10, true);
		string name2 = "m_skillIconImage";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.get_m_skillIconImage);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.set_m_skillIconImage);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache12, true);
		string name3 = "m_skillNameText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.get_m_skillNameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.set_m_skillNameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache14, true);
		string name4 = "m_skillCurLevelValue";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.get_m_skillCurLevelValue);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.set_m_skillCurLevelValue);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache16, true);
		string name5 = "m_skillMaxLevelValue";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.get_m_skillMaxLevelValue);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.set_m_skillMaxLevelValue);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.<>f__mg$cache18, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersConfessionUnlockConditionUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013D20 RID: 81184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013D21 RID: 81185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013D22 RID: 81186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013D23 RID: 81187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013D24 RID: 81188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013D25 RID: 81189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013D26 RID: 81190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013D27 RID: 81191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013D28 RID: 81192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013D29 RID: 81193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013D2A RID: 81194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013D2B RID: 81195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013D2C RID: 81196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013D2D RID: 81197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013D2E RID: 81198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013D2F RID: 81199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013D30 RID: 81200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013D31 RID: 81201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013D32 RID: 81202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013D33 RID: 81203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013D34 RID: 81204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013D35 RID: 81205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013D36 RID: 81206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013D37 RID: 81207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013D38 RID: 81208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
