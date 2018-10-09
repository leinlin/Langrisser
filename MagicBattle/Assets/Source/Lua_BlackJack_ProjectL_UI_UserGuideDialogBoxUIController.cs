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

// Token: 0x020015D2 RID: 5586
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController : LuaObject
{
	// Token: 0x060220B2 RID: 139442 RVA: 0x00B9B24C File Offset: 0x00B9944C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			userGuideDialogBoxUIController.Show(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220B3 RID: 139443 RVA: 0x00B9B2A4 File Offset: 0x00B994A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			userGuideDialogBoxUIController.Open(onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220B4 RID: 139444 RVA: 0x00B9B2FC File Offset: 0x00B994FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			userGuideDialogBoxUIController.Close(onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220B5 RID: 139445 RVA: 0x00B9B354 File Offset: 0x00B99554
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			bool b = userGuideDialogBoxUIController.IsOpened();
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

	// Token: 0x060220B6 RID: 139446 RVA: 0x00B9B3A8 File Offset: 0x00B995A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStyle(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			int positionType;
			LuaObject.checkType(l, 2, out positionType);
			int frameType;
			LuaObject.checkType(l, 3, out frameType);
			userGuideDialogBoxUIController.SetStyle(positionType, frameType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220B7 RID: 139447 RVA: 0x00B9B40C File Offset: 0x00B9960C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			userGuideDialogBoxUIController.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220B8 RID: 139448 RVA: 0x00B9B464 File Offset: 0x00B99664
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetWords(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			string words;
			LuaObject.checkType(l, 2, out words);
			userGuideDialogBoxUIController.SetWords(words);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220B9 RID: 139449 RVA: 0x00B9B4BC File Offset: 0x00B996BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVoicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			float voicePlayTime;
			LuaObject.checkType(l, 2, out voicePlayTime);
			userGuideDialogBoxUIController.SetVoicePlayTime(voicePlayTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220BA RID: 139450 RVA: 0x00B9B514 File Offset: 0x00B99714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWordsDisplayTime(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			float wordsDisplayTime = userGuideDialogBoxUIController.GetWordsDisplayTime();
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

	// Token: 0x060220BB RID: 139451 RVA: 0x00B9B568 File Offset: 0x00B99768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			userGuideDialogBoxUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220BC RID: 139452 RVA: 0x00B9B5BC File Offset: 0x00B997BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			userGuideDialogBoxUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220BD RID: 139453 RVA: 0x00B9B628 File Offset: 0x00B99828
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			userGuideDialogBoxUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220BE RID: 139454 RVA: 0x00B9B67C File Offset: 0x00B9987C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			userGuideDialogBoxUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220BF RID: 139455 RVA: 0x00B9B6D0 File Offset: 0x00B998D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = userGuideDialogBoxUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060220C0 RID: 139456 RVA: 0x00B9B778 File Offset: 0x00B99978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			userGuideDialogBoxUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220C1 RID: 139457 RVA: 0x00B9B7CC File Offset: 0x00B999CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			userGuideDialogBoxUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220C2 RID: 139458 RVA: 0x00B9B838 File Offset: 0x00B99A38
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
				UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				userGuideDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				UserGuideDialogBoxUIController userGuideDialogBoxUIController2 = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				userGuideDialogBoxUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060220C3 RID: 139459 RVA: 0x00B9B948 File Offset: 0x00B99B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220C4 RID: 139460 RVA: 0x00B9B9B4 File Offset: 0x00B99BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220C5 RID: 139461 RVA: 0x00B9BA20 File Offset: 0x00B99C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220C6 RID: 139462 RVA: 0x00B9BA8C File Offset: 0x00B99C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideDialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220C7 RID: 139463 RVA: 0x00B9BAF8 File Offset: 0x00B99CF8
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
				UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				userGuideDialogBoxUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				UserGuideDialogBoxUIController userGuideDialogBoxUIController2 = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				userGuideDialogBoxUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060220C8 RID: 139464 RVA: 0x00B9BC08 File Offset: 0x00B99E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			string s = userGuideDialogBoxUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060220C9 RID: 139465 RVA: 0x00B9BC64 File Offset: 0x00B99E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WordsSpeed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UserGuideDialogBoxUIController.LuaExportHelper.WordsSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220CA RID: 139466 RVA: 0x00B9BCAC File Offset: 0x00B99EAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220CB RID: 139467 RVA: 0x00B9BD04 File Offset: 0x00B99F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			userGuideDialogBoxUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220CC RID: 139468 RVA: 0x00B9BD60 File Offset: 0x00B99F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220CD RID: 139469 RVA: 0x00B9BDB8 File Offset: 0x00B99FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			DialogText text;
			LuaObject.checkType<DialogText>(l, 2, out text);
			userGuideDialogBoxUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220CE RID: 139470 RVA: 0x00B9BE14 File Offset: 0x00B9A014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitGameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_waitGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220CF RID: 139471 RVA: 0x00B9BE6C File Offset: 0x00B9A06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waitGameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			GameObject waitGameObject;
			LuaObject.checkType<GameObject>(l, 2, out waitGameObject);
			userGuideDialogBoxUIController.m_luaExportHelper.m_waitGameObject = waitGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220D0 RID: 139472 RVA: 0x00B9BEC8 File Offset: 0x00B9A0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220D1 RID: 139473 RVA: 0x00B9BF20 File Offset: 0x00B9A120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			userGuideDialogBoxUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220D2 RID: 139474 RVA: 0x00B9BF7C File Offset: 0x00B9A17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_time(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220D3 RID: 139475 RVA: 0x00B9BFD4 File Offset: 0x00B9A1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_time(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			userGuideDialogBoxUIController.m_luaExportHelper.m_time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220D4 RID: 139476 RVA: 0x00B9C030 File Offset: 0x00B9A230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_voicePlayTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220D5 RID: 139477 RVA: 0x00B9C088 File Offset: 0x00B9A288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			float voicePlayTime;
			LuaObject.checkType(l, 2, out voicePlayTime);
			userGuideDialogBoxUIController.m_luaExportHelper.m_voicePlayTime = voicePlayTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220D6 RID: 139478 RVA: 0x00B9C0E4 File Offset: 0x00B9A2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsDisplayLength(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220D7 RID: 139479 RVA: 0x00B9C13C File Offset: 0x00B9A33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsDisplayLength(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			int wordsDisplayLength;
			LuaObject.checkType(l, 2, out wordsDisplayLength);
			userGuideDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLength = wordsDisplayLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220D8 RID: 139480 RVA: 0x00B9C198 File Offset: 0x00B9A398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsDisplayLengthMax(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLengthMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220D9 RID: 139481 RVA: 0x00B9C1F0 File Offset: 0x00B9A3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsDisplayLengthMax(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			int wordsDisplayLengthMax;
			LuaObject.checkType(l, 2, out wordsDisplayLengthMax);
			userGuideDialogBoxUIController.m_luaExportHelper.m_wordsDisplayLengthMax = wordsDisplayLengthMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220DA RID: 139482 RVA: 0x00B9C24C File Offset: 0x00B9A44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openStateName(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_openStateName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220DB RID: 139483 RVA: 0x00B9C2A4 File Offset: 0x00B9A4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_openStateName(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			string openStateName;
			LuaObject.checkType(l, 2, out openStateName);
			userGuideDialogBoxUIController.m_luaExportHelper.m_openStateName = openStateName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220DC RID: 139484 RVA: 0x00B9C300 File Offset: 0x00B9A500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeStateName(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_closeStateName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220DD RID: 139485 RVA: 0x00B9C358 File Offset: 0x00B9A558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeStateName(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			string closeStateName;
			LuaObject.checkType(l, 2, out closeStateName);
			userGuideDialogBoxUIController.m_luaExportHelper.m_closeStateName = closeStateName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220DE RID: 139486 RVA: 0x00B9C3B4 File Offset: 0x00B9A5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideDialogBoxUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220DF RID: 139487 RVA: 0x00B9C40C File Offset: 0x00B9A60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			UserGuideDialogBoxUIController userGuideDialogBoxUIController = (UserGuideDialogBoxUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			userGuideDialogBoxUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220E0 RID: 139488 RVA: 0x00B9C468 File Offset: 0x00B9A668
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UserGuideDialogBoxUIController");
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.Show);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.SetStyle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.SetWords);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.SetVoicePlayTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.GetWordsDisplayTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache16);
		string name = "WordsSpeed";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_WordsSpeed);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache17, null, false);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_uiStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache19, true);
		string name3 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_text);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_text);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1B, true);
		string name4 = "m_waitGameObject";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_waitGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_waitGameObject);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1D, true);
		string name5 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_nameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache1F, true);
		string name6 = "m_time";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_time);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_time);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache21, true);
		string name7 = "m_voicePlayTime";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_voicePlayTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_voicePlayTime);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache23, true);
		string name8 = "m_wordsDisplayLength";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_wordsDisplayLength);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_wordsDisplayLength);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache25, true);
		string name9 = "m_wordsDisplayLengthMax";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_wordsDisplayLengthMax);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_wordsDisplayLengthMax);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache27, true);
		string name10 = "m_openStateName";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_openStateName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_openStateName);
		}
		LuaObject.addMember(l, name10, get9, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache29, true);
		string name11 = "m_closeStateName";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_closeStateName);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_closeStateName);
		}
		LuaObject.addMember(l, name11, get10, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2B, true);
		string name12 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.get_m_isOpened);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.<>f__mg$cache2D, true);
		LuaObject.createTypeMetatable(l, null, typeof(UserGuideDialogBoxUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017EF0 RID: 98032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017EF1 RID: 98033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017EF2 RID: 98034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017EF3 RID: 98035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017EF4 RID: 98036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017EF5 RID: 98037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017EF6 RID: 98038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017EF7 RID: 98039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017EF8 RID: 98040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017EF9 RID: 98041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017EFA RID: 98042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017EFB RID: 98043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017EFC RID: 98044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017EFD RID: 98045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017EFE RID: 98046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017EFF RID: 98047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017F00 RID: 98048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017F01 RID: 98049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017F02 RID: 98050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017F03 RID: 98051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017F04 RID: 98052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017F05 RID: 98053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017F06 RID: 98054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017F07 RID: 98055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017F08 RID: 98056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017F09 RID: 98057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017F0A RID: 98058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017F0B RID: 98059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017F0C RID: 98060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017F0D RID: 98061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017F0E RID: 98062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017F0F RID: 98063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017F10 RID: 98064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017F11 RID: 98065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017F12 RID: 98066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017F13 RID: 98067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017F14 RID: 98068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017F15 RID: 98069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017F16 RID: 98070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017F17 RID: 98071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017F18 RID: 98072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017F19 RID: 98073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017F1A RID: 98074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017F1B RID: 98075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017F1C RID: 98076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017F1D RID: 98077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
