using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Art;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013C7 RID: 5063
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController : LuaObject
{
	// Token: 0x0601C0B2 RID: 114866 RVA: 0x0089F13C File Offset: 0x0089D33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			battleTreasureDialogUIController.Open(onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0B3 RID: 114867 RVA: 0x0089F194 File Offset: 0x0089D394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			battleTreasureDialogUIController.Close(onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0B4 RID: 114868 RVA: 0x0089F1EC File Offset: 0x0089D3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetWords(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			string words;
			LuaObject.checkType(l, 2, out words);
			battleTreasureDialogUIController.SetWords(words);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0B5 RID: 114869 RVA: 0x0089F244 File Offset: 0x0089D444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			battleTreasureDialogUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0B6 RID: 114870 RVA: 0x0089F298 File Offset: 0x0089D498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			battleTreasureDialogUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0B7 RID: 114871 RVA: 0x0089F2EC File Offset: 0x0089D4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			battleTreasureDialogUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0B8 RID: 114872 RVA: 0x0089F340 File Offset: 0x0089D540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleTreasureDialogUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0B9 RID: 114873 RVA: 0x0089F3AC File Offset: 0x0089D5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			battleTreasureDialogUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0BA RID: 114874 RVA: 0x0089F400 File Offset: 0x0089D600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			battleTreasureDialogUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0BB RID: 114875 RVA: 0x0089F454 File Offset: 0x0089D654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleTreasureDialogUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C0BC RID: 114876 RVA: 0x0089F4FC File Offset: 0x0089D6FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			battleTreasureDialogUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0BD RID: 114877 RVA: 0x0089F550 File Offset: 0x0089D750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleTreasureDialogUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0BE RID: 114878 RVA: 0x0089F5BC File Offset: 0x0089D7BC
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
				BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleTreasureDialogUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleTreasureDialogUIController battleTreasureDialogUIController2 = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleTreasureDialogUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C0BF RID: 114879 RVA: 0x0089F6CC File Offset: 0x0089D8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleTreasureDialogUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0C0 RID: 114880 RVA: 0x0089F738 File Offset: 0x0089D938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleTreasureDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0C1 RID: 114881 RVA: 0x0089F7A4 File Offset: 0x0089D9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleTreasureDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0C2 RID: 114882 RVA: 0x0089F810 File Offset: 0x0089DA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleTreasureDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0C3 RID: 114883 RVA: 0x0089F87C File Offset: 0x0089DA7C
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
				BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleTreasureDialogUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleTreasureDialogUIController battleTreasureDialogUIController2 = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleTreasureDialogUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C0C4 RID: 114884 RVA: 0x0089F98C File Offset: 0x0089DB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			string s = battleTreasureDialogUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C0C5 RID: 114885 RVA: 0x0089F9E8 File Offset: 0x0089DBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			battleTreasureDialogUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0C6 RID: 114886 RVA: 0x0089FA3C File Offset: 0x0089DC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			battleTreasureDialogUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0C7 RID: 114887 RVA: 0x0089FA90 File Offset: 0x0089DC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleTreasureDialogUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleTreasureDialogUIController.EventOnClose -= value;
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

	// Token: 0x0601C0C8 RID: 114888 RVA: 0x0089FB10 File Offset: 0x0089DD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WordsSpeed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleTreasureDialogUIController.LuaExportHelper.WordsSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0C9 RID: 114889 RVA: 0x0089FB58 File Offset: 0x0089DD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureDialogUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0CA RID: 114890 RVA: 0x0089FBB0 File Offset: 0x0089DDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			battleTreasureDialogUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0CB RID: 114891 RVA: 0x0089FC0C File Offset: 0x0089DE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureDialogUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0CC RID: 114892 RVA: 0x0089FC64 File Offset: 0x0089DE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			DialogText text;
			LuaObject.checkType<DialogText>(l, 2, out text);
			battleTreasureDialogUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0CD RID: 114893 RVA: 0x0089FCC0 File Offset: 0x0089DEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureDialogUIController.m_luaExportHelper.m_waitGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0CE RID: 114894 RVA: 0x0089FD18 File Offset: 0x0089DF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waitGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			GameObject waitGameObject;
			LuaObject.checkType<GameObject>(l, 2, out waitGameObject);
			battleTreasureDialogUIController.m_luaExportHelper.m_waitGameObject = waitGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0CF RID: 114895 RVA: 0x0089FD74 File Offset: 0x0089DF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureDialogUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0D0 RID: 114896 RVA: 0x0089FDCC File Offset: 0x0089DFCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			battleTreasureDialogUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0D1 RID: 114897 RVA: 0x0089FE28 File Offset: 0x0089E028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_time(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureDialogUIController.m_luaExportHelper.m_time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0D2 RID: 114898 RVA: 0x0089FE80 File Offset: 0x0089E080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_time(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			battleTreasureDialogUIController.m_luaExportHelper.m_time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0D3 RID: 114899 RVA: 0x0089FEDC File Offset: 0x0089E0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsDisplayLength(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureDialogUIController.m_luaExportHelper.m_wordsDisplayLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0D4 RID: 114900 RVA: 0x0089FF34 File Offset: 0x0089E134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsDisplayLength(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			int wordsDisplayLength;
			LuaObject.checkType(l, 2, out wordsDisplayLength);
			battleTreasureDialogUIController.m_luaExportHelper.m_wordsDisplayLength = wordsDisplayLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0D5 RID: 114901 RVA: 0x0089FF90 File Offset: 0x0089E190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsDisplayLengthMax(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureDialogUIController.m_luaExportHelper.m_wordsDisplayLengthMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0D6 RID: 114902 RVA: 0x0089FFE8 File Offset: 0x0089E1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsDisplayLengthMax(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureDialogUIController battleTreasureDialogUIController = (BattleTreasureDialogUIController)LuaObject.checkSelf(l);
			int wordsDisplayLengthMax;
			LuaObject.checkType(l, 2, out wordsDisplayLengthMax);
			battleTreasureDialogUIController.m_luaExportHelper.m_wordsDisplayLengthMax = wordsDisplayLengthMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0D7 RID: 114903 RVA: 0x008A0044 File Offset: 0x0089E244
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleTreasureDialogUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.SetWords);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache14);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache15, true);
		string name2 = "WordsSpeed";
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.get_WordsSpeed);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache16, null, false);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache18, true);
		string name4 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.get_m_text);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.set_m_text);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1A, true);
		string name5 = "m_waitGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.get_m_waitGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.set_m_waitGameObject);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1C, true);
		string name6 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.get_m_backgroundButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1E, true);
		string name7 = "m_time";
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.get_m_time);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.set_m_time);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache20, true);
		string name8 = "m_wordsDisplayLength";
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.get_m_wordsDisplayLength);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.set_m_wordsDisplayLength);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache22, true);
		string name9 = "m_wordsDisplayLengthMax";
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.get_m_wordsDisplayLengthMax);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.set_m_wordsDisplayLengthMax);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.<>f__mg$cache24, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleTreasureDialogUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012306 RID: 74502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012307 RID: 74503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012308 RID: 74504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012309 RID: 74505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401230A RID: 74506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401230B RID: 74507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401230C RID: 74508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401230D RID: 74509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401230E RID: 74510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401230F RID: 74511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012310 RID: 74512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012311 RID: 74513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012312 RID: 74514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012313 RID: 74515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012314 RID: 74516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012315 RID: 74517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012316 RID: 74518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012317 RID: 74519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012318 RID: 74520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012319 RID: 74521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401231A RID: 74522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401231B RID: 74523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401231C RID: 74524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401231D RID: 74525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401231E RID: 74526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401231F RID: 74527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012320 RID: 74528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012321 RID: 74529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012322 RID: 74530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012323 RID: 74531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012324 RID: 74532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012325 RID: 74533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012326 RID: 74534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012327 RID: 74535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012328 RID: 74536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012329 RID: 74537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401232A RID: 74538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;
}
