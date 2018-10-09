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

// Token: 0x02001414 RID: 5140
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DialogBoxUIController : LuaObject
{
	// Token: 0x0601D0EB RID: 119019 RVA: 0x00920714 File Offset: 0x0091E914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			dialogBoxUIController.Show(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0EC RID: 119020 RVA: 0x0092076C File Offset: 0x0091E96C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			dialogBoxUIController.Open(onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0ED RID: 119021 RVA: 0x009207C4 File Offset: 0x0091E9C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			dialogBoxUIController.Close(onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0EE RID: 119022 RVA: 0x0092081C File Offset: 0x0091EA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			bool b = dialogBoxUIController.IsOpened();
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

	// Token: 0x0601D0EF RID: 119023 RVA: 0x00920870 File Offset: 0x0091EA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStyle(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			int positionType;
			LuaObject.checkType(l, 2, out positionType);
			int frameType;
			LuaObject.checkType(l, 3, out frameType);
			dialogBoxUIController.SetStyle(positionType, frameType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0F0 RID: 119024 RVA: 0x009208D4 File Offset: 0x0091EAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			dialogBoxUIController.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0F1 RID: 119025 RVA: 0x0092092C File Offset: 0x0091EB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetWords(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			string words;
			LuaObject.checkType(l, 2, out words);
			dialogBoxUIController.SetWords(words);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0F2 RID: 119026 RVA: 0x00920984 File Offset: 0x0091EB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVoicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			float voicePlayTime;
			LuaObject.checkType(l, 2, out voicePlayTime);
			dialogBoxUIController.SetVoicePlayTime(voicePlayTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0F3 RID: 119027 RVA: 0x009209DC File Offset: 0x0091EBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWordsDisplayTime(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			float wordsDisplayTime = dialogBoxUIController.GetWordsDisplayTime();
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

	// Token: 0x0601D0F4 RID: 119028 RVA: 0x00920A30 File Offset: 0x0091EC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			dialogBoxUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0F5 RID: 119029 RVA: 0x00920A84 File Offset: 0x0091EC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			dialogBoxUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0F6 RID: 119030 RVA: 0x00920AF0 File Offset: 0x0091ECF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			dialogBoxUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0F7 RID: 119031 RVA: 0x00920B44 File Offset: 0x0091ED44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			dialogBoxUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0F8 RID: 119032 RVA: 0x00920B98 File Offset: 0x0091ED98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = dialogBoxUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D0F9 RID: 119033 RVA: 0x00920C40 File Offset: 0x0091EE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			dialogBoxUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0FA RID: 119034 RVA: 0x00920C94 File Offset: 0x0091EE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			dialogBoxUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0FB RID: 119035 RVA: 0x00920D00 File Offset: 0x0091EF00
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
				DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				dialogBoxUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				DialogBoxUIController dialogBoxUIController2 = (DialogBoxUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				dialogBoxUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D0FC RID: 119036 RVA: 0x00920E10 File Offset: 0x0091F010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogBoxUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0FD RID: 119037 RVA: 0x00920E7C File Offset: 0x0091F07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0FE RID: 119038 RVA: 0x00920EE8 File Offset: 0x0091F0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0FF RID: 119039 RVA: 0x00920F54 File Offset: 0x0091F154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogBoxUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D100 RID: 119040 RVA: 0x00920FC0 File Offset: 0x0091F1C0
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
				DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				dialogBoxUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				DialogBoxUIController dialogBoxUIController2 = (DialogBoxUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				dialogBoxUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D101 RID: 119041 RVA: 0x009210D0 File Offset: 0x0091F2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			string s = dialogBoxUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D102 RID: 119042 RVA: 0x0092112C File Offset: 0x0091F32C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WordsSpeed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DialogBoxUIController.LuaExportHelper.WordsSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D103 RID: 119043 RVA: 0x00921174 File Offset: 0x0091F374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D104 RID: 119044 RVA: 0x009211CC File Offset: 0x0091F3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			dialogBoxUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D105 RID: 119045 RVA: 0x00921228 File Offset: 0x0091F428
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D106 RID: 119046 RVA: 0x00921280 File Offset: 0x0091F480
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			DialogText text;
			LuaObject.checkType<DialogText>(l, 2, out text);
			dialogBoxUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D107 RID: 119047 RVA: 0x009212DC File Offset: 0x0091F4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitGameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_waitGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D108 RID: 119048 RVA: 0x00921334 File Offset: 0x0091F534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waitGameObject(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			GameObject waitGameObject;
			LuaObject.checkType<GameObject>(l, 2, out waitGameObject);
			dialogBoxUIController.m_luaExportHelper.m_waitGameObject = waitGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D109 RID: 119049 RVA: 0x00921390 File Offset: 0x0091F590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D10A RID: 119050 RVA: 0x009213E8 File Offset: 0x0091F5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			dialogBoxUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D10B RID: 119051 RVA: 0x00921444 File Offset: 0x0091F644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_time(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D10C RID: 119052 RVA: 0x0092149C File Offset: 0x0091F69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_time(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			dialogBoxUIController.m_luaExportHelper.m_time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D10D RID: 119053 RVA: 0x009214F8 File Offset: 0x0091F6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_voicePlayTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D10E RID: 119054 RVA: 0x00921550 File Offset: 0x0091F750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voicePlayTime(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			float voicePlayTime;
			LuaObject.checkType(l, 2, out voicePlayTime);
			dialogBoxUIController.m_luaExportHelper.m_voicePlayTime = voicePlayTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D10F RID: 119055 RVA: 0x009215AC File Offset: 0x0091F7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsDisplayLength(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_wordsDisplayLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D110 RID: 119056 RVA: 0x00921604 File Offset: 0x0091F804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsDisplayLength(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			int wordsDisplayLength;
			LuaObject.checkType(l, 2, out wordsDisplayLength);
			dialogBoxUIController.m_luaExportHelper.m_wordsDisplayLength = wordsDisplayLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D111 RID: 119057 RVA: 0x00921660 File Offset: 0x0091F860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordsDisplayLengthMax(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_wordsDisplayLengthMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D112 RID: 119058 RVA: 0x009216B8 File Offset: 0x0091F8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordsDisplayLengthMax(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			int wordsDisplayLengthMax;
			LuaObject.checkType(l, 2, out wordsDisplayLengthMax);
			dialogBoxUIController.m_luaExportHelper.m_wordsDisplayLengthMax = wordsDisplayLengthMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D113 RID: 119059 RVA: 0x00921714 File Offset: 0x0091F914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openStateName(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_openStateName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D114 RID: 119060 RVA: 0x0092176C File Offset: 0x0091F96C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_openStateName(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			string openStateName;
			LuaObject.checkType(l, 2, out openStateName);
			dialogBoxUIController.m_luaExportHelper.m_openStateName = openStateName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D115 RID: 119061 RVA: 0x009217C8 File Offset: 0x0091F9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeStateName(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_closeStateName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D116 RID: 119062 RVA: 0x00921820 File Offset: 0x0091FA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeStateName(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			string closeStateName;
			LuaObject.checkType(l, 2, out closeStateName);
			dialogBoxUIController.m_luaExportHelper.m_closeStateName = closeStateName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D117 RID: 119063 RVA: 0x0092187C File Offset: 0x0091FA7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogBoxUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D118 RID: 119064 RVA: 0x009218D4 File Offset: 0x0091FAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			DialogBoxUIController dialogBoxUIController = (DialogBoxUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			dialogBoxUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D119 RID: 119065 RVA: 0x00921930 File Offset: 0x0091FB30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DialogBoxUIController");
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.Show);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.SetStyle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.SetWords);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.SetVoicePlayTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.GetWordsDisplayTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache16);
		string name = "WordsSpeed";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_WordsSpeed);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache17, null, false);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_uiStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache19, true);
		string name3 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_text);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_text);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1B, true);
		string name4 = "m_waitGameObject";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_waitGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_waitGameObject);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1D, true);
		string name5 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_nameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache1F, true);
		string name6 = "m_time";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_time);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_time);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache21, true);
		string name7 = "m_voicePlayTime";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_voicePlayTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_voicePlayTime);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache23, true);
		string name8 = "m_wordsDisplayLength";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_wordsDisplayLength);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_wordsDisplayLength);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache25, true);
		string name9 = "m_wordsDisplayLengthMax";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_wordsDisplayLengthMax);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_wordsDisplayLengthMax);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache27, true);
		string name10 = "m_openStateName";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_openStateName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_openStateName);
		}
		LuaObject.addMember(l, name10, get9, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache29, true);
		string name11 = "m_closeStateName";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_closeStateName);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_closeStateName);
		}
		LuaObject.addMember(l, name11, get10, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2B, true);
		string name12 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.get_m_isOpened);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ProjectL_UI_DialogBoxUIController.<>f__mg$cache2D, true);
		LuaObject.createTypeMetatable(l, null, typeof(DialogBoxUIController), typeof(UIControllerBase));
	}

	// Token: 0x040132A5 RID: 78501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040132A6 RID: 78502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040132A7 RID: 78503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040132A8 RID: 78504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040132A9 RID: 78505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040132AA RID: 78506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040132AB RID: 78507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040132AC RID: 78508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040132AD RID: 78509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040132AE RID: 78510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040132AF RID: 78511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040132B0 RID: 78512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040132B1 RID: 78513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040132B2 RID: 78514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040132B3 RID: 78515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040132B4 RID: 78516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040132B5 RID: 78517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040132B6 RID: 78518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040132B7 RID: 78519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040132B8 RID: 78520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040132B9 RID: 78521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040132BA RID: 78522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040132BB RID: 78523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040132BC RID: 78524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040132BD RID: 78525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040132BE RID: 78526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040132BF RID: 78527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040132C0 RID: 78528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040132C1 RID: 78529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040132C2 RID: 78530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040132C3 RID: 78531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040132C4 RID: 78532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040132C5 RID: 78533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040132C6 RID: 78534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040132C7 RID: 78535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040132C8 RID: 78536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040132C9 RID: 78537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040132CA RID: 78538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040132CB RID: 78539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040132CC RID: 78540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040132CD RID: 78541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040132CE RID: 78542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040132CF RID: 78543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040132D0 RID: 78544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040132D1 RID: 78545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040132D2 RID: 78546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
