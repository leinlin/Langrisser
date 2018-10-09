using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015B8 RID: 5560
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController : LuaObject
{
	// Token: 0x06021CA3 RID: 138403 RVA: 0x00B7B828 File Offset: 0x00B79A28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitTrainingSkillItemInfo(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			TrainingTech tech;
			LuaObject.checkType<TrainingTech>(l, 2, out tech);
			trainingSkillItemUIController.InitTrainingSkillItemInfo(tech);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CA4 RID: 138404 RVA: 0x00B7B880 File Offset: 0x00B79A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			trainingSkillItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CA5 RID: 138405 RVA: 0x00B7B8D4 File Offset: 0x00B79AD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTrainingSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			trainingSkillItemUIController.m_luaExportHelper.OnTrainingSkillItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CA6 RID: 138406 RVA: 0x00B7B928 File Offset: 0x00B79B28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			trainingSkillItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CA7 RID: 138407 RVA: 0x00B7B994 File Offset: 0x00B79B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			trainingSkillItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CA8 RID: 138408 RVA: 0x00B7B9E8 File Offset: 0x00B79BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			trainingSkillItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CA9 RID: 138409 RVA: 0x00B7BA3C File Offset: 0x00B79C3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = trainingSkillItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021CAA RID: 138410 RVA: 0x00B7BAE4 File Offset: 0x00B79CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			trainingSkillItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CAB RID: 138411 RVA: 0x00B7BB38 File Offset: 0x00B79D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			trainingSkillItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CAC RID: 138412 RVA: 0x00B7BBA4 File Offset: 0x00B79DA4
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
				TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				trainingSkillItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TrainingSkillItemUIController trainingSkillItemUIController2 = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				trainingSkillItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021CAD RID: 138413 RVA: 0x00B7BCB4 File Offset: 0x00B79EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingSkillItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CAE RID: 138414 RVA: 0x00B7BD20 File Offset: 0x00B79F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CAF RID: 138415 RVA: 0x00B7BD8C File Offset: 0x00B79F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CB0 RID: 138416 RVA: 0x00B7BDF8 File Offset: 0x00B79FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CB1 RID: 138417 RVA: 0x00B7BE64 File Offset: 0x00B7A064
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
				TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				trainingSkillItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TrainingSkillItemUIController trainingSkillItemUIController2 = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				trainingSkillItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021CB2 RID: 138418 RVA: 0x00B7BF74 File Offset: 0x00B7A174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			string s = trainingSkillItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021CB3 RID: 138419 RVA: 0x00B7BFD0 File Offset: 0x00B7A1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTrainingSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			TrainingSkillItemUIController obj;
			LuaObject.checkType<TrainingSkillItemUIController>(l, 2, out obj);
			trainingSkillItemUIController.m_luaExportHelper.__callDele_EventOnTrainingSkillItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CB4 RID: 138420 RVA: 0x00B7C02C File Offset: 0x00B7A22C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnTrainingSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			TrainingSkillItemUIController obj;
			LuaObject.checkType<TrainingSkillItemUIController>(l, 2, out obj);
			trainingSkillItemUIController.m_luaExportHelper.__clearDele_EventOnTrainingSkillItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CB5 RID: 138421 RVA: 0x00B7C088 File Offset: 0x00B7A288
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnTrainingSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			Action<TrainingSkillItemUIController> value;
			int num = LuaObject.checkDelegate<Action<TrainingSkillItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					trainingSkillItemUIController.EventOnTrainingSkillItemClick += value;
				}
				else if (num == 2)
				{
					trainingSkillItemUIController.EventOnTrainingSkillItemClick -= value;
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

	// Token: 0x06021CB6 RID: 138422 RVA: 0x00B7C108 File Offset: 0x00B7A308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CB7 RID: 138423 RVA: 0x00B7C160 File Offset: 0x00B7A360
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			trainingSkillItemUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CB8 RID: 138424 RVA: 0x00B7C1BC File Offset: 0x00B7A3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CB9 RID: 138425 RVA: 0x00B7C214 File Offset: 0x00B7A414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			trainingSkillItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CBA RID: 138426 RVA: 0x00B7C270 File Offset: 0x00B7A470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CBB RID: 138427 RVA: 0x00B7C2C8 File Offset: 0x00B7A4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			trainingSkillItemUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CBC RID: 138428 RVA: 0x00B7C324 File Offset: 0x00B7A524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_iconImageGrey(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.m_luaExportHelper.m_iconImageGrey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CBD RID: 138429 RVA: 0x00B7C37C File Offset: 0x00B7A57C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_iconImageGrey(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			Image iconImageGrey;
			LuaObject.checkType<Image>(l, 2, out iconImageGrey);
			trainingSkillItemUIController.m_luaExportHelper.m_iconImageGrey = iconImageGrey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CBE RID: 138430 RVA: 0x00B7C3D8 File Offset: 0x00B7A5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lvValueText(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.m_luaExportHelper.m_lvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CBF RID: 138431 RVA: 0x00B7C430 File Offset: 0x00B7A630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lvValueText(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			Text lvValueText;
			LuaObject.checkType<Text>(l, 2, out lvValueText);
			trainingSkillItemUIController.m_luaExportHelper.m_lvValueText = lvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CC0 RID: 138432 RVA: 0x00B7C48C File Offset: 0x00B7A68C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lvMaxText(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.m_luaExportHelper.m_lvMaxText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CC1 RID: 138433 RVA: 0x00B7C4E4 File Offset: 0x00B7A6E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lvMaxText(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			GameObject lvMaxText;
			LuaObject.checkType<GameObject>(l, 2, out lvMaxText);
			trainingSkillItemUIController.m_luaExportHelper.m_lvMaxText = lvMaxText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CC2 RID: 138434 RVA: 0x00B7C540 File Offset: 0x00B7A740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.m_luaExportHelper.m_soldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CC3 RID: 138435 RVA: 0x00B7C598 File Offset: 0x00B7A798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			Text soldierNameText;
			LuaObject.checkType<Text>(l, 2, out soldierNameText);
			trainingSkillItemUIController.m_luaExportHelper.m_soldierNameText = soldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CC4 RID: 138436 RVA: 0x00B7C5F4 File Offset: 0x00B7A7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CC5 RID: 138437 RVA: 0x00B7C64C File Offset: 0x00B7A84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			GameObject graphic;
			LuaObject.checkType<GameObject>(l, 2, out graphic);
			trainingSkillItemUIController.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CC6 RID: 138438 RVA: 0x00B7C6A8 File Offset: 0x00B7A8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.m_luaExportHelper.m_redMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CC7 RID: 138439 RVA: 0x00B7C700 File Offset: 0x00B7A900
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			GameObject redMark;
			LuaObject.checkType<GameObject>(l, 2, out redMark);
			trainingSkillItemUIController.m_luaExportHelper.m_redMark = redMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CC8 RID: 138440 RVA: 0x00B7C75C File Offset: 0x00B7A95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.m_luaExportHelper.m_soldierInfoGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CC9 RID: 138441 RVA: 0x00B7C7B4 File Offset: 0x00B7A9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierInfoGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierInfoGraphic);
			trainingSkillItemUIController.m_luaExportHelper.m_soldierInfoGraphic = soldierInfoGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CCA RID: 138442 RVA: 0x00B7C810 File Offset: 0x00B7AA10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TrainingTech(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.TrainingTech);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CCB RID: 138443 RVA: 0x00B7C864 File Offset: 0x00B7AA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TrainingTech(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			TrainingTech trainingTech;
			LuaObject.checkType<TrainingTech>(l, 2, out trainingTech);
			trainingSkillItemUIController.TrainingTech = trainingTech;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CCC RID: 138444 RVA: 0x00B7C8BC File Offset: 0x00B7AABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TechMaxLv(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillItemUIController.TechMaxLv);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CCD RID: 138445 RVA: 0x00B7C910 File Offset: 0x00B7AB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TechMaxLv(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillItemUIController trainingSkillItemUIController = (TrainingSkillItemUIController)LuaObject.checkSelf(l);
			int techMaxLv;
			LuaObject.checkType(l, 2, out techMaxLv);
			trainingSkillItemUIController.TechMaxLv = techMaxLv;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CCE RID: 138446 RVA: 0x00B7C968 File Offset: 0x00B7AB68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TrainingSkillItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.InitTrainingSkillItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.OnTrainingSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__callDele_EventOnTrainingSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.__clearDele_EventOnTrainingSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache11);
		string name = "EventOnTrainingSkillItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_EventOnTrainingSkillItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache12, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache14, true);
		string name3 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_m_button);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache16, true);
		string name4 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_m_iconImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache18, true);
		string name5 = "m_iconImageGrey";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_m_iconImageGrey);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_m_iconImageGrey);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1A, true);
		string name6 = "m_lvValueText";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_m_lvValueText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_m_lvValueText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1C, true);
		string name7 = "m_lvMaxText";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_m_lvMaxText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_m_lvMaxText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1E, true);
		string name8 = "m_soldierNameText";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_m_soldierNameText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_m_soldierNameText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache20, true);
		string name9 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_m_graphic);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_m_graphic);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache22, true);
		string name10 = "m_redMark";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_m_redMark);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_m_redMark);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache24, true);
		string name11 = "m_soldierInfoGraphic";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_m_soldierInfoGraphic);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_m_soldierInfoGraphic);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache26, true);
		string name12 = "TrainingTech";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_TrainingTech);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_TrainingTech);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache28, true);
		string name13 = "TechMaxLv";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.get_TechMaxLv);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.set_TechMaxLv);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.<>f__mg$cache2A, true);
		LuaObject.createTypeMetatable(l, null, typeof(TrainingSkillItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017B15 RID: 97045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017B16 RID: 97046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017B17 RID: 97047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017B18 RID: 97048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017B19 RID: 97049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017B1A RID: 97050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017B1B RID: 97051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017B1C RID: 97052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017B1D RID: 97053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017B1E RID: 97054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017B1F RID: 97055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017B20 RID: 97056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017B21 RID: 97057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017B22 RID: 97058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017B23 RID: 97059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017B24 RID: 97060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017B25 RID: 97061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017B26 RID: 97062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017B27 RID: 97063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017B28 RID: 97064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017B29 RID: 97065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017B2A RID: 97066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017B2B RID: 97067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017B2C RID: 97068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017B2D RID: 97069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017B2E RID: 97070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017B2F RID: 97071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017B30 RID: 97072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017B31 RID: 97073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017B32 RID: 97074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017B33 RID: 97075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017B34 RID: 97076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017B35 RID: 97077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017B36 RID: 97078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017B37 RID: 97079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017B38 RID: 97080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017B39 RID: 97081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017B3A RID: 97082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017B3B RID: 97083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017B3C RID: 97084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017B3D RID: 97085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017B3E RID: 97086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017B3F RID: 97087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
