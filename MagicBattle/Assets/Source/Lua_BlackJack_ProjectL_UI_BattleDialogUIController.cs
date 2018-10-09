using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013A0 RID: 5024
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleDialogUIController : LuaObject
{
	// Token: 0x0601B822 RID: 112674 RVA: 0x0085B48C File Offset: 0x0085968C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDialog(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo dialog;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out dialog);
			battleDialogUIController.SetDialog(dialog);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B823 RID: 112675 RVA: 0x0085B4E4 File Offset: 0x008596E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseDialog(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.CloseDialog();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B824 RID: 112676 RVA: 0x0085B530 File Offset: 0x00859730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B825 RID: 112677 RVA: 0x0085B584 File Offset: 0x00859784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B826 RID: 112678 RVA: 0x0085B5D8 File Offset: 0x008597D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_CloseDialog(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = battleDialogUIController.m_luaExportHelper.Co_CloseDialog();
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

	// Token: 0x0601B827 RID: 112679 RVA: 0x0085B634 File Offset: 0x00859834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDialogBox(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.ShowDialogBox();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B828 RID: 112680 RVA: 0x0085B688 File Offset: 0x00859888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayVoice(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			IAudioPlayback o = battleDialogUIController.m_luaExportHelper.PlayVoice(name);
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

	// Token: 0x0601B829 RID: 112681 RVA: 0x0085B6F0 File Offset: 0x008598F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopVoice(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.StopVoice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B82A RID: 112682 RVA: 0x0085B744 File Offset: 0x00859944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_NextDialog(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			IEnumerator o = battleDialogUIController.m_luaExportHelper.Co_NextDialog();
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

	// Token: 0x0601B82B RID: 112683 RVA: 0x0085B7A0 File Offset: 0x008599A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkipButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.OnSkipButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B82C RID: 112684 RVA: 0x0085B7F4 File Offset: 0x008599F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B82D RID: 112685 RVA: 0x0085B848 File Offset: 0x00859A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleDialogUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B82E RID: 112686 RVA: 0x0085B8B4 File Offset: 0x00859AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B82F RID: 112687 RVA: 0x0085B908 File Offset: 0x00859B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B830 RID: 112688 RVA: 0x0085B95C File Offset: 0x00859B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleDialogUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B831 RID: 112689 RVA: 0x0085BA04 File Offset: 0x00859C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B832 RID: 112690 RVA: 0x0085BA58 File Offset: 0x00859C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleDialogUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B833 RID: 112691 RVA: 0x0085BAC4 File Offset: 0x00859CC4
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
				BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleDialogUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleDialogUIController battleDialogUIController2 = (BattleDialogUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleDialogUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B834 RID: 112692 RVA: 0x0085BBD4 File Offset: 0x00859DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDialogUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B835 RID: 112693 RVA: 0x0085BC40 File Offset: 0x00859E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B836 RID: 112694 RVA: 0x0085BCAC File Offset: 0x00859EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B837 RID: 112695 RVA: 0x0085BD18 File Offset: 0x00859F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDialogUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B838 RID: 112696 RVA: 0x0085BD84 File Offset: 0x00859F84
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
				BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleDialogUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleDialogUIController battleDialogUIController2 = (BattleDialogUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleDialogUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B839 RID: 112697 RVA: 0x0085BE94 File Offset: 0x0085A094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			string s = battleDialogUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B83A RID: 112698 RVA: 0x0085BEF0 File Offset: 0x0085A0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.__callDele_EventOnSkip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B83B RID: 112699 RVA: 0x0085BF44 File Offset: 0x0085A144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.__clearDele_EventOnSkip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B83C RID: 112700 RVA: 0x0085BF98 File Offset: 0x0085A198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.__callDele_EventOnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B83D RID: 112701 RVA: 0x0085BFEC File Offset: 0x0085A1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.__clearDele_EventOnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B83E RID: 112702 RVA: 0x0085C040 File Offset: 0x0085A240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B83F RID: 112703 RVA: 0x0085C094 File Offset: 0x0085A294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			battleDialogUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B840 RID: 112704 RVA: 0x0085C0E8 File Offset: 0x0085A2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleDialogUIController.EventOnSkip += value;
				}
				else if (num == 2)
				{
					battleDialogUIController.EventOnSkip -= value;
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

	// Token: 0x0601B841 RID: 112705 RVA: 0x0085C168 File Offset: 0x0085A368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleDialogUIController.EventOnNext += value;
				}
				else if (num == 2)
				{
					battleDialogUIController.EventOnNext -= value;
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

	// Token: 0x0601B842 RID: 112706 RVA: 0x0085C1E8 File Offset: 0x0085A3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleDialogUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleDialogUIController.EventOnClose -= value;
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

	// Token: 0x0601B843 RID: 112707 RVA: 0x0085C268 File Offset: 0x0085A468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skipButton(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUIController.m_luaExportHelper.m_skipButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B844 RID: 112708 RVA: 0x0085C2C0 File Offset: 0x0085A4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skipButton(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			Button skipButton;
			LuaObject.checkType<Button>(l, 2, out skipButton);
			battleDialogUIController.m_luaExportHelper.m_skipButton = skipButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B845 RID: 112709 RVA: 0x0085C31C File Offset: 0x0085A51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B846 RID: 112710 RVA: 0x0085C374 File Offset: 0x0085A574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			battleDialogUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B847 RID: 112711 RVA: 0x0085C3D0 File Offset: 0x0085A5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUIController.m_luaExportHelper.m_wordsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B848 RID: 112712 RVA: 0x0085C428 File Offset: 0x0085A628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			GameObject wordsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out wordsGameObject);
			battleDialogUIController.m_luaExportHelper.m_wordsGameObject = wordsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B849 RID: 112713 RVA: 0x0085C484 File Offset: 0x0085A684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char0GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUIController.m_luaExportHelper.m_char0GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B84A RID: 112714 RVA: 0x0085C4DC File Offset: 0x0085A6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char0GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			GameObject char0GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char0GameObject);
			battleDialogUIController.m_luaExportHelper.m_char0GameObject = char0GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B84B RID: 112715 RVA: 0x0085C538 File Offset: 0x0085A738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char1GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUIController.m_luaExportHelper.m_char1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B84C RID: 112716 RVA: 0x0085C590 File Offset: 0x0085A790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char1GameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			GameObject char1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char1GameObject);
			battleDialogUIController.m_luaExportHelper.m_char1GameObject = char1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B84D RID: 112717 RVA: 0x0085C5EC File Offset: 0x0085A7EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogCharUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUIController.m_luaExportHelper.m_dialogCharUIControllers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B84E RID: 112718 RVA: 0x0085C644 File Offset: 0x0085A844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogCharUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			DialogCharUIController[] dialogCharUIControllers;
			LuaObject.checkArray<DialogCharUIController>(l, 2, out dialogCharUIControllers);
			battleDialogUIController.m_luaExportHelper.m_dialogCharUIControllers = dialogCharUIControllers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B84F RID: 112719 RVA: 0x0085C6A0 File Offset: 0x0085A8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogBoxUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUIController.m_luaExportHelper.m_dialogBoxUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B850 RID: 112720 RVA: 0x0085C6F8 File Offset: 0x0085A8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogBoxUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			BattleDialogBoxUIController dialogBoxUIController;
			LuaObject.checkType<BattleDialogBoxUIController>(l, 2, out dialogBoxUIController);
			battleDialogUIController.m_luaExportHelper.m_dialogBoxUIController = dialogBoxUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B851 RID: 112721 RVA: 0x0085C754 File Offset: 0x0085A954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentAudio(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUIController.m_luaExportHelper.m_currentAudio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B852 RID: 112722 RVA: 0x0085C7AC File Offset: 0x0085A9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentAudio(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			IAudioPlayback currentAudio;
			LuaObject.checkType<IAudioPlayback>(l, 2, out currentAudio);
			battleDialogUIController.m_luaExportHelper.m_currentAudio = currentAudio;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B853 RID: 112723 RVA: 0x0085C808 File Offset: 0x0085AA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUIController.m_luaExportHelper.m_dialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B854 RID: 112724 RVA: 0x0085C860 File Offset: 0x0085AA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out dialogInfo);
			battleDialogUIController.m_luaExportHelper.m_dialogInfo = dialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B855 RID: 112725 RVA: 0x0085C8BC File Offset: 0x0085AABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showDialogBoxTime(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogUIController.m_luaExportHelper.m_showDialogBoxTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B856 RID: 112726 RVA: 0x0085C914 File Offset: 0x0085AB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showDialogBoxTime(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogUIController battleDialogUIController = (BattleDialogUIController)LuaObject.checkSelf(l);
			float showDialogBoxTime;
			LuaObject.checkType(l, 2, out showDialogBoxTime);
			battleDialogUIController.m_luaExportHelper.m_showDialogBoxTime = showDialogBoxTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B857 RID: 112727 RVA: 0x0085C970 File Offset: 0x0085AB70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleDialogUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.SetDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.CloseDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.Co_CloseDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.ShowDialogBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.PlayVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.StopVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.Co_NextDialog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.OnSkipButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callDele_EventOnSkip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__clearDele_EventOnSkip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callDele_EventOnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__clearDele_EventOnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1D);
		string name = "EventOnSkip";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_EventOnSkip);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1E, true);
		string name2 = "EventOnNext";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_EventOnNext);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache1F, true);
		string name3 = "EventOnClose";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache20, true);
		string name4 = "m_skipButton";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.get_m_skipButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_m_skipButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache22, true);
		string name5 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.get_m_backgroundButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache24, true);
		string name6 = "m_wordsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.get_m_wordsGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_m_wordsGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache26, true);
		string name7 = "m_char0GameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.get_m_char0GameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_m_char0GameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache28, true);
		string name8 = "m_char1GameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.get_m_char1GameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_m_char1GameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2A, true);
		string name9 = "m_dialogCharUIControllers";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.get_m_dialogCharUIControllers);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_m_dialogCharUIControllers);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2C, true);
		string name10 = "m_dialogBoxUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.get_m_dialogBoxUIController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_m_dialogBoxUIController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2E, true);
		string name11 = "m_currentAudio";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.get_m_currentAudio);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_m_currentAudio);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache30, true);
		string name12 = "m_dialogInfo";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.get_m_dialogInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_m_dialogInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache32, true);
		string name13 = "m_showDialogBoxTime";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.get_m_showDialogBoxTime);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.set_m_showDialogBoxTime);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleDialogUIController.<>f__mg$cache34, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleDialogUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011AC4 RID: 72388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011AC5 RID: 72389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011AC6 RID: 72390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011AC7 RID: 72391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011AC8 RID: 72392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011AC9 RID: 72393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011ACA RID: 72394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011ACB RID: 72395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011ACC RID: 72396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011ACD RID: 72397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011ACE RID: 72398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011ACF RID: 72399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011AD0 RID: 72400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011AD1 RID: 72401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011AD2 RID: 72402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011AD3 RID: 72403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011AD4 RID: 72404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011AD5 RID: 72405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011AD6 RID: 72406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011AD7 RID: 72407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011AD8 RID: 72408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011AD9 RID: 72409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011ADA RID: 72410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011ADB RID: 72411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011ADC RID: 72412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011ADD RID: 72413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011ADE RID: 72414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011ADF RID: 72415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011AE0 RID: 72416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011AE1 RID: 72417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011AE2 RID: 72418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011AE3 RID: 72419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011AE4 RID: 72420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011AE5 RID: 72421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011AE6 RID: 72422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011AE7 RID: 72423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011AE8 RID: 72424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011AE9 RID: 72425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011AEA RID: 72426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011AEB RID: 72427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011AEC RID: 72428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011AED RID: 72429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011AEE RID: 72430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011AEF RID: 72431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011AF0 RID: 72432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011AF1 RID: 72433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011AF2 RID: 72434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011AF3 RID: 72435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011AF4 RID: 72436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011AF5 RID: 72437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011AF6 RID: 72438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011AF7 RID: 72439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011AF8 RID: 72440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
