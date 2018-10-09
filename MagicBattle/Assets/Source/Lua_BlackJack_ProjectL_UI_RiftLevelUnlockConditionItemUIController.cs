using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001568 RID: 5480
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController : LuaObject
{
	// Token: 0x06020D3A RID: 134458 RVA: 0x00B002B4 File Offset: 0x00AFE4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCondition(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			RiftLevelUnlockConditionType condition;
			LuaObject.checkEnum<RiftLevelUnlockConditionType>(l, 2, out condition);
			int param;
			LuaObject.checkType(l, 3, out param);
			int param2;
			LuaObject.checkType(l, 4, out param2);
			riftLevelUnlockConditionItemUIController.SetCondition(condition, param, param2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D3B RID: 134459 RVA: 0x00B00328 File Offset: 0x00AFE528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.GoScenario();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D3C RID: 134460 RVA: 0x00B0037C File Offset: 0x00AFE57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoAchievement(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.GoAchievement();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D3D RID: 134461 RVA: 0x00B003D0 File Offset: 0x00AFE5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.GoRiftLevel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D3E RID: 134462 RVA: 0x00B00424 File Offset: 0x00AFE624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D3F RID: 134463 RVA: 0x00B00490 File Offset: 0x00AFE690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D40 RID: 134464 RVA: 0x00B004E4 File Offset: 0x00AFE6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D41 RID: 134465 RVA: 0x00B00538 File Offset: 0x00AFE738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020D42 RID: 134466 RVA: 0x00B005E0 File Offset: 0x00AFE7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D43 RID: 134467 RVA: 0x00B00634 File Offset: 0x00AFE834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D44 RID: 134468 RVA: 0x00B006A0 File Offset: 0x00AFE8A0
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
				RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController2 = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				riftLevelUnlockConditionItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020D45 RID: 134469 RVA: 0x00B007B0 File Offset: 0x00AFE9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D46 RID: 134470 RVA: 0x00B0081C File Offset: 0x00AFEA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D47 RID: 134471 RVA: 0x00B00888 File Offset: 0x00AFEA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D48 RID: 134472 RVA: 0x00B008F4 File Offset: 0x00AFEAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D49 RID: 134473 RVA: 0x00B00960 File Offset: 0x00AFEB60
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
				RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController2 = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				riftLevelUnlockConditionItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020D4A RID: 134474 RVA: 0x00B00A70 File Offset: 0x00AFEC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string s = riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020D4B RID: 134475 RVA: 0x00B00ACC File Offset: 0x00AFECCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callDele_EventOnGoToScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D4C RID: 134476 RVA: 0x00B00B28 File Offset: 0x00AFED28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__clearDele_EventOnGoToScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D4D RID: 134477 RVA: 0x00B00B84 File Offset: 0x00AFED84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoToRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__callDele_EventOnGoToRiftLevel(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D4E RID: 134478 RVA: 0x00B00BF0 File Offset: 0x00AFEDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoToRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.__clearDele_EventOnGoToRiftLevel(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D4F RID: 134479 RVA: 0x00B00C5C File Offset: 0x00AFEE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D50 RID: 134480 RVA: 0x00B00CB4 File Offset: 0x00AFEEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			Text text;
			LuaObject.checkType<Text>(l, 2, out text);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D51 RID: 134481 RVA: 0x00B00D10 File Offset: 0x00AFEF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_goButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D52 RID: 134482 RVA: 0x00B00D68 File Offset: 0x00AFEF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goButton(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			Button goButton;
			LuaObject.checkType<Button>(l, 2, out goButton);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_goButton = goButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D53 RID: 134483 RVA: 0x00B00DC4 File Offset: 0x00AFEFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelID(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_riftLevelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D54 RID: 134484 RVA: 0x00B00E1C File Offset: 0x00AFF01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftLevelID(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			int riftLevelID;
			LuaObject.checkType(l, 2, out riftLevelID);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_riftLevelID = riftLevelID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D55 RID: 134485 RVA: 0x00B00E78 File Offset: 0x00AFF078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementRiftLevelID(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_achievementRiftLevelID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D56 RID: 134486 RVA: 0x00B00ED0 File Offset: 0x00AFF0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementRiftLevelID(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			int achievementRiftLevelID;
			LuaObject.checkType(l, 2, out achievementRiftLevelID);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_achievementRiftLevelID = achievementRiftLevelID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D57 RID: 134487 RVA: 0x00B00F2C File Offset: 0x00AFF12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scenarioID(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_scenarioID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D58 RID: 134488 RVA: 0x00B00F84 File Offset: 0x00AFF184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scenarioID(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			int scenarioID;
			LuaObject.checkType(l, 2, out scenarioID);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_scenarioID = scenarioID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D59 RID: 134489 RVA: 0x00B00FE0 File Offset: 0x00AFF1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D5A RID: 134490 RVA: 0x00B01038 File Offset: 0x00AFF238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D5B RID: 134491 RVA: 0x00B01094 File Offset: 0x00AFF294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D5C RID: 134492 RVA: 0x00B010EC File Offset: 0x00AFF2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			riftLevelUnlockConditionItemUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020D5D RID: 134493 RVA: 0x00B01148 File Offset: 0x00AFF348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelUnlockConditionItemUIController.EventOnGoToScenario += value;
				}
				else if (num == 2)
				{
					riftLevelUnlockConditionItemUIController.EventOnGoToScenario -= value;
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

	// Token: 0x06020D5E RID: 134494 RVA: 0x00B011C8 File Offset: 0x00AFF3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoToRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = (RiftLevelUnlockConditionItemUIController)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelUnlockConditionItemUIController.EventOnGoToRiftLevel += value;
				}
				else if (num == 2)
				{
					riftLevelUnlockConditionItemUIController.EventOnGoToRiftLevel -= value;
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

	// Token: 0x06020D5F RID: 134495 RVA: 0x00B01248 File Offset: 0x00AFF448
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftLevelUnlockConditionItemUIController");
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.SetCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.GoScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.GoAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.GoRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callDele_EventOnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__clearDele_EventOnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__callDele_EventOnGoToRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.__clearDele_EventOnGoToRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache14);
		string name = "m_text";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.get_m_text);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.set_m_text);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache16, true);
		string name2 = "m_goButton";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.get_m_goButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.set_m_goButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache18, true);
		string name3 = "m_riftLevelID";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.get_m_riftLevelID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.set_m_riftLevelID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1A, true);
		string name4 = "m_achievementRiftLevelID";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.get_m_achievementRiftLevelID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.set_m_achievementRiftLevelID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1C, true);
		string name5 = "m_scenarioID";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.get_m_scenarioID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.set_m_scenarioID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1E, true);
		string name6 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.get_m_playerContext);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache20, true);
		string name7 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.get_m_configDataLoader);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache22, true);
		string name8 = "EventOnGoToScenario";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.set_EventOnGoToScenario);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache23, true);
		string name9 = "EventOnGoToRiftLevel";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.set_EventOnGoToRiftLevel);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.<>f__mg$cache24, true);
		LuaObject.createTypeMetatable(l, null, typeof(RiftLevelUnlockConditionItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016C4C RID: 93260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016C4D RID: 93261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016C4E RID: 93262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016C4F RID: 93263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016C50 RID: 93264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016C51 RID: 93265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016C52 RID: 93266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016C53 RID: 93267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016C54 RID: 93268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016C55 RID: 93269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016C56 RID: 93270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016C57 RID: 93271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016C58 RID: 93272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016C59 RID: 93273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016C5A RID: 93274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016C5B RID: 93275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016C5C RID: 93276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016C5D RID: 93277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016C5E RID: 93278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016C5F RID: 93279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016C60 RID: 93280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016C61 RID: 93281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016C62 RID: 93282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016C63 RID: 93283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016C64 RID: 93284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016C65 RID: 93285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016C66 RID: 93286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016C67 RID: 93287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016C68 RID: 93288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016C69 RID: 93289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016C6A RID: 93290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016C6B RID: 93291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016C6C RID: 93292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016C6D RID: 93293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016C6E RID: 93294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016C6F RID: 93295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016C70 RID: 93296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;
}
