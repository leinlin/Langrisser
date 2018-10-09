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

// Token: 0x0200139F RID: 5023
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController : LuaObject
{
	// Token: 0x0601B7F2 RID: 112626 RVA: 0x00859BE4 File Offset: 0x00857DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleDialogBoxUIController.Show(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7F3 RID: 112627 RVA: 0x00859C3C File Offset: 0x00857E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			battleDialogBoxUIController.Open(onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7F4 RID: 112628 RVA: 0x00859C94 File Offset: 0x00857E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			battleDialogBoxUIController.Close(onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7F5 RID: 112629 RVA: 0x00859CEC File Offset: 0x00857EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			bool b = battleDialogBoxUIController.IsOpened();
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

	// Token: 0x0601B7F6 RID: 112630 RVA: 0x00859D40 File Offset: 0x00857F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStyle(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			int positionType;
			LuaObject.checkType(l, 2, out positionType);
			int frameType;
			LuaObject.checkType(l, 3, out frameType);
			battleDialogBoxUIController.SetStyle(positionType, frameType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7F7 RID: 112631 RVA: 0x00859DA4 File Offset: 0x00857FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			battleDialogBoxUIController.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7F8 RID: 112632 RVA: 0x00859DFC File Offset: 0x00857FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetWords(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			string words;
			LuaObject.checkType(l, 2, out words);
			battleDialogBoxUIController.SetWords(words);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7F9 RID: 112633 RVA: 0x00859E54 File Offset: 0x00858054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVoicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			float voicePlayTime;
			LuaObject.checkType(l, 2, out voicePlayTime);
			battleDialogBoxUIController.SetVoicePlayTime(voicePlayTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7FA RID: 112634 RVA: 0x00859EAC File Offset: 0x008580AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWordsDisplayTime(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			float wordsDisplayTime = battleDialogBoxUIController.GetWordsDisplayTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wordsDisplayTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7FB RID: 112635 RVA: 0x00859F00 File Offset: 0x00858100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			battleDialogBoxUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7FC RID: 112636 RVA: 0x00859F54 File Offset: 0x00858154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleDialogBoxUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7FD RID: 112637 RVA: 0x00859FC0 File Offset: 0x008581C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			battleDialogBoxUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7FE RID: 112638 RVA: 0x0085A014 File Offset: 0x00858214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			battleDialogBoxUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7FF RID: 112639 RVA: 0x0085A068 File Offset: 0x00858268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleDialogBoxUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B800 RID: 112640 RVA: 0x0085A110 File Offset: 0x00858310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			battleDialogBoxUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B801 RID: 112641 RVA: 0x0085A164 File Offset: 0x00858364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleDialogBoxUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B802 RID: 112642 RVA: 0x0085A1D0 File Offset: 0x008583D0
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
				BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleDialogBoxUIController battleDialogBoxUIController2 = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleDialogBoxUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B803 RID: 112643 RVA: 0x0085A2E0 File Offset: 0x008584E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B804 RID: 112644 RVA: 0x0085A34C File Offset: 0x0085854C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B805 RID: 112645 RVA: 0x0085A3B8 File Offset: 0x008585B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B806 RID: 112646 RVA: 0x0085A424 File Offset: 0x00858624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B807 RID: 112647 RVA: 0x0085A490 File Offset: 0x00858690
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
				BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleDialogBoxUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleDialogBoxUIController battleDialogBoxUIController2 = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleDialogBoxUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B808 RID: 112648 RVA: 0x0085A5A0 File Offset: 0x008587A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			string s = battleDialogBoxUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B809 RID: 112649 RVA: 0x0085A5FC File Offset: 0x008587FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WordsSpeed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleDialogBoxUIController.LuaExportHelper.WordsSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B80A RID: 112650 RVA: 0x0085A644 File Offset: 0x00858844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B80B RID: 112651 RVA: 0x0085A69C File Offset: 0x0085889C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			battleDialogBoxUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B80C RID: 112652 RVA: 0x0085A6F8 File Offset: 0x008588F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B80D RID: 112653 RVA: 0x0085A750 File Offset: 0x00858950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			DialogText text;
			LuaObject.checkType<DialogText>(l, 2, out text);
			battleDialogBoxUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B80E RID: 112654 RVA: 0x0085A7AC File Offset: 0x008589AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_waitGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B80F RID: 112655 RVA: 0x0085A804 File Offset: 0x00858A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waitGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			GameObject waitGameObject;
			LuaObject.checkType<GameObject>(l, 2, out waitGameObject);
			battleDialogBoxUIController.m_luaExportHelper.m_waitGameObject = waitGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B810 RID: 112656 RVA: 0x0085A860 File Offset: 0x00858A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B811 RID: 112657 RVA: 0x0085A8B8 File Offset: 0x00858AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			battleDialogBoxUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B812 RID: 112658 RVA: 0x0085A914 File Offset: 0x00858B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_time(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B813 RID: 112659 RVA: 0x0085A96C File Offset: 0x00858B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_time(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			battleDialogBoxUIController.m_luaExportHelper.m_time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B814 RID: 112660 RVA: 0x0085A9C8 File Offset: 0x00858BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_voicePlayTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B815 RID: 112661 RVA: 0x0085AA20 File Offset: 0x00858C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			float voicePlayTime;
			LuaObject.checkType(l, 2, out voicePlayTime);
			battleDialogBoxUIController.m_luaExportHelper.m_voicePlayTime = voicePlayTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B816 RID: 112662 RVA: 0x0085AA7C File Offset: 0x00858C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsDisplayLength(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B817 RID: 112663 RVA: 0x0085AAD4 File Offset: 0x00858CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsDisplayLength(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			int wordsDisplayLength;
			LuaObject.checkType(l, 2, out wordsDisplayLength);
			battleDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLength = wordsDisplayLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B818 RID: 112664 RVA: 0x0085AB30 File Offset: 0x00858D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsDisplayLengthMax(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLengthMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B819 RID: 112665 RVA: 0x0085AB88 File Offset: 0x00858D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsDisplayLengthMax(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			int wordsDisplayLengthMax;
			LuaObject.checkType(l, 2, out wordsDisplayLengthMax);
			battleDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLengthMax = wordsDisplayLengthMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B81A RID: 112666 RVA: 0x0085ABE4 File Offset: 0x00858DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openStateName(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_openStateName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B81B RID: 112667 RVA: 0x0085AC3C File Offset: 0x00858E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_openStateName(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			string openStateName;
			LuaObject.checkType(l, 2, out openStateName);
			battleDialogBoxUIController.m_luaExportHelper.m_openStateName = openStateName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B81C RID: 112668 RVA: 0x0085AC98 File Offset: 0x00858E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeStateName(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_closeStateName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B81D RID: 112669 RVA: 0x0085ACF0 File Offset: 0x00858EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeStateName(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			string closeStateName;
			LuaObject.checkType(l, 2, out closeStateName);
			battleDialogBoxUIController.m_luaExportHelper.m_closeStateName = closeStateName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B81E RID: 112670 RVA: 0x0085AD4C File Offset: 0x00858F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDialogBoxUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B81F RID: 112671 RVA: 0x0085ADA4 File Offset: 0x00858FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattleDialogBoxUIController battleDialogBoxUIController = (BattleDialogBoxUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			battleDialogBoxUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B820 RID: 112672 RVA: 0x0085AE00 File Offset: 0x00859000
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleDialogBoxUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.Show);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.SetStyle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.SetWords);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.SetVoicePlayTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.GetWordsDisplayTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache16);
		string name = "WordsSpeed";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_WordsSpeed);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache17, null, false);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_uiStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache19, true);
		string name3 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_text);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_text);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1B, true);
		string name4 = "m_waitGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_waitGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_waitGameObject);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1D, true);
		string name5 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_nameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache1F, true);
		string name6 = "m_time";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_time);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_time);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache21, true);
		string name7 = "m_voicePlayTime";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_voicePlayTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_voicePlayTime);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache23, true);
		string name8 = "m_wordsDisplayLength";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_wordsDisplayLength);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_wordsDisplayLength);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache25, true);
		string name9 = "m_wordsDisplayLengthMax";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_wordsDisplayLengthMax);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_wordsDisplayLengthMax);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache27, true);
		string name10 = "m_openStateName";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_openStateName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_openStateName);
		}
		LuaObject.addMember(l, name10, get9, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache29, true);
		string name11 = "m_closeStateName";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_closeStateName);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_closeStateName);
		}
		LuaObject.addMember(l, name11, get10, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2B, true);
		string name12 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.get_m_isOpened);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.<>f__mg$cache2D, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleDialogBoxUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011A96 RID: 72342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011A97 RID: 72343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011A98 RID: 72344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011A99 RID: 72345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011A9A RID: 72346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011A9B RID: 72347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011A9C RID: 72348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011A9D RID: 72349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011A9E RID: 72350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011A9F RID: 72351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011AA0 RID: 72352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011AA1 RID: 72353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011AA2 RID: 72354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011AA3 RID: 72355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011AA4 RID: 72356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011AA5 RID: 72357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011AA6 RID: 72358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011AA7 RID: 72359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011AA8 RID: 72360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011AA9 RID: 72361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011AAA RID: 72362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011AAB RID: 72363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011AAC RID: 72364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011AAD RID: 72365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011AAE RID: 72366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011AAF RID: 72367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011AB0 RID: 72368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011AB1 RID: 72369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011AB2 RID: 72370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011AB3 RID: 72371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011AB4 RID: 72372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011AB5 RID: 72373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011AB6 RID: 72374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011AB7 RID: 72375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011AB8 RID: 72376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011AB9 RID: 72377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011ABA RID: 72378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011ABB RID: 72379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011ABC RID: 72380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011ABD RID: 72381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011ABE RID: 72382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011ABF RID: 72383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011AC0 RID: 72384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011AC1 RID: 72385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011AC2 RID: 72386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011AC3 RID: 72387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
