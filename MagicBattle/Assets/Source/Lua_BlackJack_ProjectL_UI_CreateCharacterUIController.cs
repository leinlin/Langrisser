using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200140C RID: 5132
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CreateCharacterUIController : LuaObject
{
	// Token: 0x0601CFD5 RID: 118741 RVA: 0x009179C4 File Offset: 0x00915BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFD6 RID: 118742 RVA: 0x00917A10 File Offset: 0x00915C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			createCharacterUIController.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFD7 RID: 118743 RVA: 0x00917A68 File Offset: 0x00915C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCharacterNameLimit(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			int characterNameLimit;
			LuaObject.checkType(l, 2, out characterNameLimit);
			createCharacterUIController.SetCharacterNameLimit(characterNameLimit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFD8 RID: 118744 RVA: 0x00917AC0 File Offset: 0x00915CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCharacterName(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			string characterName;
			LuaObject.checkType(l, 2, out characterName);
			createCharacterUIController.SetCharacterName(characterName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFD9 RID: 118745 RVA: 0x00917B18 File Offset: 0x00915D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCharacterName(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			string characterName = createCharacterUIController.GetCharacterName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFDA RID: 118746 RVA: 0x00917B6C File Offset: 0x00915D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMessage(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(StringTableId), typeof(int)))
			{
				CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
				StringTableId id;
				LuaObject.checkEnum<StringTableId>(l, 2, out id);
				int time;
				LuaObject.checkType(l, 3, out time);
				createCharacterUIController.ShowMessage(id, time);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int)))
			{
				CreateCharacterUIController createCharacterUIController2 = (CreateCharacterUIController)LuaObject.checkSelf(l);
				string text;
				LuaObject.checkType(l, 2, out text);
				int time2;
				LuaObject.checkType(l, 3, out time2);
				createCharacterUIController2.ShowMessage(text, time2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowMessage to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFDB RID: 118747 RVA: 0x00917C74 File Offset: 0x00915E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideMessage(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.HideMessage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFDC RID: 118748 RVA: 0x00917CC0 File Offset: 0x00915EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.Start();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFDD RID: 118749 RVA: 0x00917D14 File Offset: 0x00915F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFDE RID: 118750 RVA: 0x00917D68 File Offset: 0x00915F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFDF RID: 118751 RVA: 0x00917DBC File Offset: 0x00915FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCreateButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.OnCreateButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFE0 RID: 118752 RVA: 0x00917E10 File Offset: 0x00916010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAutoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.OnAutoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFE1 RID: 118753 RVA: 0x00917E64 File Offset: 0x00916064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CharacterNameInputField_OnEndEdit(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			string str;
			LuaObject.checkType(l, 2, out str);
			createCharacterUIController.m_luaExportHelper.CharacterNameInputField_OnEndEdit(str);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFE2 RID: 118754 RVA: 0x00917EC0 File Offset: 0x009160C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			createCharacterUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFE3 RID: 118755 RVA: 0x00917F2C File Offset: 0x0091612C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFE4 RID: 118756 RVA: 0x00917F80 File Offset: 0x00916180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFE5 RID: 118757 RVA: 0x00917FD4 File Offset: 0x009161D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = createCharacterUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CFE6 RID: 118758 RVA: 0x0091807C File Offset: 0x0091627C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFE7 RID: 118759 RVA: 0x009180D0 File Offset: 0x009162D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			createCharacterUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFE8 RID: 118760 RVA: 0x0091813C File Offset: 0x0091633C
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
				CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				createCharacterUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CreateCharacterUIController createCharacterUIController2 = (CreateCharacterUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				createCharacterUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CFE9 RID: 118761 RVA: 0x0091824C File Offset: 0x0091644C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createCharacterUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFEA RID: 118762 RVA: 0x009182B8 File Offset: 0x009164B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createCharacterUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFEB RID: 118763 RVA: 0x00918324 File Offset: 0x00916524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createCharacterUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFEC RID: 118764 RVA: 0x00918390 File Offset: 0x00916590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createCharacterUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFED RID: 118765 RVA: 0x009183FC File Offset: 0x009165FC
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
				CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				createCharacterUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CreateCharacterUIController createCharacterUIController2 = (CreateCharacterUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				createCharacterUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CFEE RID: 118766 RVA: 0x0091850C File Offset: 0x0091670C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			string s = createCharacterUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CFEF RID: 118767 RVA: 0x00918568 File Offset: 0x00916768
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnCreate(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.__callDele_EventOnCreate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFF0 RID: 118768 RVA: 0x009185BC File Offset: 0x009167BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCreate(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.__clearDele_EventOnCreate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFF1 RID: 118769 RVA: 0x00918610 File Offset: 0x00916810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAutoName(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.__callDele_EventOnAutoName();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFF2 RID: 118770 RVA: 0x00918664 File Offset: 0x00916864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAutoName(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			createCharacterUIController.m_luaExportHelper.__clearDele_EventOnAutoName();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFF3 RID: 118771 RVA: 0x009186B8 File Offset: 0x009168B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCreate(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					createCharacterUIController.EventOnCreate += value;
				}
				else if (num == 2)
				{
					createCharacterUIController.EventOnCreate -= value;
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

	// Token: 0x0601CFF4 RID: 118772 RVA: 0x00918738 File Offset: 0x00916938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAutoName(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					createCharacterUIController.EventOnAutoName += value;
				}
				else if (num == 2)
				{
					createCharacterUIController.EventOnAutoName -= value;
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

	// Token: 0x0601CFF5 RID: 118773 RVA: 0x009187B8 File Offset: 0x009169B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createCharacterUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFF6 RID: 118774 RVA: 0x00918810 File Offset: 0x00916A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			createCharacterUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFF7 RID: 118775 RVA: 0x0091886C File Offset: 0x00916A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_characterNameInputField(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createCharacterUIController.m_luaExportHelper.m_characterNameInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFF8 RID: 118776 RVA: 0x009188C4 File Offset: 0x00916AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_characterNameInputField(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			InputField characterNameInputField;
			LuaObject.checkType<InputField>(l, 2, out characterNameInputField);
			createCharacterUIController.m_luaExportHelper.m_characterNameInputField = characterNameInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFF9 RID: 118777 RVA: 0x00918920 File Offset: 0x00916B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_createButton(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createCharacterUIController.m_luaExportHelper.m_createButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFFA RID: 118778 RVA: 0x00918978 File Offset: 0x00916B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_createButton(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			Button createButton;
			LuaObject.checkType<Button>(l, 2, out createButton);
			createCharacterUIController.m_luaExportHelper.m_createButton = createButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFFB RID: 118779 RVA: 0x009189D4 File Offset: 0x00916BD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_autoButton(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createCharacterUIController.m_luaExportHelper.m_autoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFFC RID: 118780 RVA: 0x00918A2C File Offset: 0x00916C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoButton(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			Button autoButton;
			LuaObject.checkType<Button>(l, 2, out autoButton);
			createCharacterUIController.m_luaExportHelper.m_autoButton = autoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFFD RID: 118781 RVA: 0x00918A88 File Offset: 0x00916C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageGameObject(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createCharacterUIController.m_luaExportHelper.m_messageGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFFE RID: 118782 RVA: 0x00918AE0 File Offset: 0x00916CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageGameObject(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			GameObject messageGameObject;
			LuaObject.checkType<GameObject>(l, 2, out messageGameObject);
			createCharacterUIController.m_luaExportHelper.m_messageGameObject = messageGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFFF RID: 118783 RVA: 0x00918B3C File Offset: 0x00916D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageText(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createCharacterUIController.m_luaExportHelper.m_messageText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D000 RID: 118784 RVA: 0x00918B94 File Offset: 0x00916D94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_messageText(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			Text messageText;
			LuaObject.checkType<Text>(l, 2, out messageText);
			createCharacterUIController.m_luaExportHelper.m_messageText = messageText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D001 RID: 118785 RVA: 0x00918BF0 File Offset: 0x00916DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_characterNameLimit(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createCharacterUIController.m_luaExportHelper.m_characterNameLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D002 RID: 118786 RVA: 0x00918C48 File Offset: 0x00916E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_characterNameLimit(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			int characterNameLimit;
			LuaObject.checkType(l, 2, out characterNameLimit);
			createCharacterUIController.m_luaExportHelper.m_characterNameLimit = characterNameLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D003 RID: 118787 RVA: 0x00918CA4 File Offset: 0x00916EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hideMessageTime(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createCharacterUIController.m_luaExportHelper.m_hideMessageTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D004 RID: 118788 RVA: 0x00918CFC File Offset: 0x00916EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hideMessageTime(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterUIController createCharacterUIController = (CreateCharacterUIController)LuaObject.checkSelf(l);
			float hideMessageTime;
			LuaObject.checkType(l, 2, out hideMessageTime);
			createCharacterUIController.m_luaExportHelper.m_hideMessageTime = hideMessageTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D005 RID: 118789 RVA: 0x00918D58 File Offset: 0x00916F58
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CreateCharacterUIController");
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.SetCharacterNameLimit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.SetCharacterName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.GetCharacterName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.ShowMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.HideMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.OnCreateButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.OnAutoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.CharacterNameInputField_OnEndEdit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callDele_EventOnCreate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__clearDele_EventOnCreate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__callDele_EventOnAutoName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.__clearDele_EventOnAutoName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1D);
		string name = "EventOnCreate";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.set_EventOnCreate);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1E, true);
		string name2 = "EventOnAutoName";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.set_EventOnAutoName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache1F, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache21, true);
		string name4 = "m_characterNameInputField";
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.get_m_characterNameInputField);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.set_m_characterNameInputField);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache23, true);
		string name5 = "m_createButton";
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.get_m_createButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.set_m_createButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache25, true);
		string name6 = "m_autoButton";
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.get_m_autoButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.set_m_autoButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache27, true);
		string name7 = "m_messageGameObject";
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.get_m_messageGameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.set_m_messageGameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache29, true);
		string name8 = "m_messageText";
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.get_m_messageText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.set_m_messageText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2B, true);
		string name9 = "m_characterNameLimit";
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.get_m_characterNameLimit);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.set_m_characterNameLimit);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2D, true);
		string name10 = "m_hideMessageTime";
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.get_m_hideMessageTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.set_m_hideMessageTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.<>f__mg$cache2F, true);
		LuaObject.createTypeMetatable(l, null, typeof(CreateCharacterUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401319F RID: 78239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040131A0 RID: 78240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040131A1 RID: 78241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040131A2 RID: 78242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040131A3 RID: 78243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040131A4 RID: 78244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040131A5 RID: 78245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040131A6 RID: 78246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040131A7 RID: 78247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040131A8 RID: 78248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040131A9 RID: 78249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040131AA RID: 78250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040131AB RID: 78251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040131AC RID: 78252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040131AD RID: 78253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040131AE RID: 78254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040131AF RID: 78255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040131B0 RID: 78256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040131B1 RID: 78257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040131B2 RID: 78258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040131B3 RID: 78259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040131B4 RID: 78260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040131B5 RID: 78261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040131B6 RID: 78262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040131B7 RID: 78263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040131B8 RID: 78264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040131B9 RID: 78265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040131BA RID: 78266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040131BB RID: 78267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040131BC RID: 78268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040131BD RID: 78269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040131BE RID: 78270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040131BF RID: 78271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040131C0 RID: 78272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040131C1 RID: 78273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040131C2 RID: 78274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040131C3 RID: 78275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040131C4 RID: 78276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040131C5 RID: 78277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040131C6 RID: 78278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040131C7 RID: 78279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040131C8 RID: 78280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040131C9 RID: 78281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040131CA RID: 78282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040131CB RID: 78283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040131CC RID: 78284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040131CD RID: 78285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040131CE RID: 78286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
