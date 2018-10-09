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

// Token: 0x02001468 RID: 5224
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController : LuaObject
{
	// Token: 0x0601E277 RID: 123511 RVA: 0x009AC000 File Offset: 0x009AA200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			goddessDialogBoxUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E278 RID: 123512 RVA: 0x009AC04C File Offset: 0x009AA24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			goddessDialogBoxUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E279 RID: 123513 RVA: 0x009AC098 File Offset: 0x009AA298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			bool b = goddessDialogBoxUIController.IsOpened();
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

	// Token: 0x0601E27A RID: 123514 RVA: 0x009AC0EC File Offset: 0x009AA2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetWords(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			string words;
			LuaObject.checkType(l, 2, out words);
			goddessDialogBoxUIController.SetWords(words);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E27B RID: 123515 RVA: 0x009AC144 File Offset: 0x009AA344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVoicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			float voicePlayTime;
			LuaObject.checkType(l, 2, out voicePlayTime);
			goddessDialogBoxUIController.SetVoicePlayTime(voicePlayTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E27C RID: 123516 RVA: 0x009AC19C File Offset: 0x009AA39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWordsDisplayTime(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			float wordsDisplayTime = goddessDialogBoxUIController.GetWordsDisplayTime();
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

	// Token: 0x0601E27D RID: 123517 RVA: 0x009AC1F0 File Offset: 0x009AA3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DisplayAllWords(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			goddessDialogBoxUIController.DisplayAllWords();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E27E RID: 123518 RVA: 0x009AC23C File Offset: 0x009AA43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAllWordsDisplayed(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			bool b = goddessDialogBoxUIController.IsAllWordsDisplayed();
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

	// Token: 0x0601E27F RID: 123519 RVA: 0x009AC290 File Offset: 0x009AA490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			goddessDialogBoxUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E280 RID: 123520 RVA: 0x009AC2E4 File Offset: 0x009AA4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			goddessDialogBoxUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E281 RID: 123521 RVA: 0x009AC350 File Offset: 0x009AA550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			goddessDialogBoxUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E282 RID: 123522 RVA: 0x009AC3A4 File Offset: 0x009AA5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			goddessDialogBoxUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E283 RID: 123523 RVA: 0x009AC3F8 File Offset: 0x009AA5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = goddessDialogBoxUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E284 RID: 123524 RVA: 0x009AC4A0 File Offset: 0x009AA6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			goddessDialogBoxUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E285 RID: 123525 RVA: 0x009AC4F4 File Offset: 0x009AA6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			goddessDialogBoxUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E286 RID: 123526 RVA: 0x009AC560 File Offset: 0x009AA760
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
				GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				goddessDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GoddessDialogBoxUIController goddessDialogBoxUIController2 = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				goddessDialogBoxUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E287 RID: 123527 RVA: 0x009AC670 File Offset: 0x009AA870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E288 RID: 123528 RVA: 0x009AC6DC File Offset: 0x009AA8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E289 RID: 123529 RVA: 0x009AC748 File Offset: 0x009AA948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E28A RID: 123530 RVA: 0x009AC7B4 File Offset: 0x009AA9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E28B RID: 123531 RVA: 0x009AC820 File Offset: 0x009AAA20
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
				GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				goddessDialogBoxUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GoddessDialogBoxUIController goddessDialogBoxUIController2 = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				goddessDialogBoxUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E28C RID: 123532 RVA: 0x009AC930 File Offset: 0x009AAB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			string s = goddessDialogBoxUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E28D RID: 123533 RVA: 0x009AC98C File Offset: 0x009AAB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WordsSpeed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GoddessDialogBoxUIController.LuaExportHelper.WordsSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E28E RID: 123534 RVA: 0x009AC9D4 File Offset: 0x009AABD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogBoxUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E28F RID: 123535 RVA: 0x009ACA2C File Offset: 0x009AAC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			goddessDialogBoxUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E290 RID: 123536 RVA: 0x009ACA88 File Offset: 0x009AAC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogBoxUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E291 RID: 123537 RVA: 0x009ACAE0 File Offset: 0x009AACE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			DialogText text;
			LuaObject.checkType<DialogText>(l, 2, out text);
			goddessDialogBoxUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E292 RID: 123538 RVA: 0x009ACB3C File Offset: 0x009AAD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogBoxUIController.m_luaExportHelper.m_waitGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E293 RID: 123539 RVA: 0x009ACB94 File Offset: 0x009AAD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waitGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			GameObject waitGameObject;
			LuaObject.checkType<GameObject>(l, 2, out waitGameObject);
			goddessDialogBoxUIController.m_luaExportHelper.m_waitGameObject = waitGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E294 RID: 123540 RVA: 0x009ACBF0 File Offset: 0x009AADF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_time(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogBoxUIController.m_luaExportHelper.m_time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E295 RID: 123541 RVA: 0x009ACC48 File Offset: 0x009AAE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_time(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			goddessDialogBoxUIController.m_luaExportHelper.m_time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E296 RID: 123542 RVA: 0x009ACCA4 File Offset: 0x009AAEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogBoxUIController.m_luaExportHelper.m_voicePlayTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E297 RID: 123543 RVA: 0x009ACCFC File Offset: 0x009AAEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			float voicePlayTime;
			LuaObject.checkType(l, 2, out voicePlayTime);
			goddessDialogBoxUIController.m_luaExportHelper.m_voicePlayTime = voicePlayTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E298 RID: 123544 RVA: 0x009ACD58 File Offset: 0x009AAF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsDisplayLength(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E299 RID: 123545 RVA: 0x009ACDB0 File Offset: 0x009AAFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsDisplayLength(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			int wordsDisplayLength;
			LuaObject.checkType(l, 2, out wordsDisplayLength);
			goddessDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLength = wordsDisplayLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E29A RID: 123546 RVA: 0x009ACE0C File Offset: 0x009AB00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsDisplayLengthMax(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLengthMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E29B RID: 123547 RVA: 0x009ACE64 File Offset: 0x009AB064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsDisplayLengthMax(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			int wordsDisplayLengthMax;
			LuaObject.checkType(l, 2, out wordsDisplayLengthMax);
			goddessDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLengthMax = wordsDisplayLengthMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E29C RID: 123548 RVA: 0x009ACEC0 File Offset: 0x009AB0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogBoxUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E29D RID: 123549 RVA: 0x009ACF18 File Offset: 0x009AB118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogBoxUIController goddessDialogBoxUIController = (GoddessDialogBoxUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			goddessDialogBoxUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E29E RID: 123550 RVA: 0x009ACF74 File Offset: 0x009AB174
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GoddessDialogBoxUIController");
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.SetWords);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.SetVoicePlayTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.GetWordsDisplayTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.DisplayAllWords);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.IsAllWordsDisplayed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache15);
		string name = "WordsSpeed";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.get_WordsSpeed);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache16, null, false);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.get_m_uiStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache18, true);
		string name3 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.get_m_text);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.set_m_text);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1A, true);
		string name4 = "m_waitGameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.get_m_waitGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.set_m_waitGameObject);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1C, true);
		string name5 = "m_time";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.get_m_time);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.set_m_time);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1E, true);
		string name6 = "m_voicePlayTime";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.get_m_voicePlayTime);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.set_m_voicePlayTime);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache20, true);
		string name7 = "m_wordsDisplayLength";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.get_m_wordsDisplayLength);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.set_m_wordsDisplayLength);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache22, true);
		string name8 = "m_wordsDisplayLengthMax";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.get_m_wordsDisplayLengthMax);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.set_m_wordsDisplayLengthMax);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache24, true);
		string name9 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.get_m_isOpened);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.<>f__mg$cache26, true);
		LuaObject.createTypeMetatable(l, null, typeof(GoddessDialogBoxUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014389 RID: 82825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401438A RID: 82826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401438B RID: 82827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401438C RID: 82828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401438D RID: 82829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401438E RID: 82830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401438F RID: 82831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014390 RID: 82832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014391 RID: 82833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014392 RID: 82834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014393 RID: 82835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014394 RID: 82836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014395 RID: 82837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014396 RID: 82838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014397 RID: 82839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014398 RID: 82840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014399 RID: 82841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401439A RID: 82842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401439B RID: 82843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401439C RID: 82844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401439D RID: 82845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401439E RID: 82846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401439F RID: 82847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040143A0 RID: 82848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040143A1 RID: 82849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040143A2 RID: 82850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040143A3 RID: 82851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040143A4 RID: 82852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040143A5 RID: 82853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040143A6 RID: 82854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040143A7 RID: 82855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040143A8 RID: 82856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040143A9 RID: 82857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040143AA RID: 82858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040143AB RID: 82859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040143AC RID: 82860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040143AD RID: 82861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040143AE RID: 82862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040143AF RID: 82863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
