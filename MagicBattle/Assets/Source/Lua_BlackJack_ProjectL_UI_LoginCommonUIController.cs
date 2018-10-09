using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014FA RID: 5370
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LoginCommonUIController : LuaObject
{
	// Token: 0x0601FB46 RID: 129862 RVA: 0x00A715B4 File Offset: 0x00A6F7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTouchFx(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			loginCommonUIController.InitTouchFx();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB47 RID: 129863 RVA: 0x00A71600 File Offset: 0x00A6F800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DisposeTouchFx(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			loginCommonUIController.DisposeTouchFx();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB48 RID: 129864 RVA: 0x00A7164C File Offset: 0x00A6F84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableInput(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			loginCommonUIController.EnableInput(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB49 RID: 129865 RVA: 0x00A716A4 File Offset: 0x00A6F8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FadeIn(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			Color color;
			LuaObject.checkType(l, 3, out color);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			loginCommonUIController.FadeIn(time, color, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB4A RID: 129866 RVA: 0x00A71718 File Offset: 0x00A6F918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FadeOut(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			Color color;
			LuaObject.checkType(l, 3, out color);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			loginCommonUIController.FadeOut(time, color, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB4B RID: 129867 RVA: 0x00A7178C File Offset: 0x00A6F98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			loginCommonUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB4C RID: 129868 RVA: 0x00A717E0 File Offset: 0x00A6F9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			loginCommonUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB4D RID: 129869 RVA: 0x00A71834 File Offset: 0x00A6FA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			loginCommonUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB4E RID: 129870 RVA: 0x00A718A0 File Offset: 0x00A6FAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			loginCommonUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB4F RID: 129871 RVA: 0x00A718F4 File Offset: 0x00A6FAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			loginCommonUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB50 RID: 129872 RVA: 0x00A71948 File Offset: 0x00A6FB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = loginCommonUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FB51 RID: 129873 RVA: 0x00A719F0 File Offset: 0x00A6FBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			loginCommonUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB52 RID: 129874 RVA: 0x00A71A44 File Offset: 0x00A6FC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			loginCommonUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB53 RID: 129875 RVA: 0x00A71AB0 File Offset: 0x00A6FCB0
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
				LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				loginCommonUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				LoginCommonUIController loginCommonUIController2 = (LoginCommonUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				loginCommonUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FB54 RID: 129876 RVA: 0x00A71BC0 File Offset: 0x00A6FDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			loginCommonUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB55 RID: 129877 RVA: 0x00A71C2C File Offset: 0x00A6FE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			loginCommonUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB56 RID: 129878 RVA: 0x00A71C98 File Offset: 0x00A6FE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			loginCommonUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB57 RID: 129879 RVA: 0x00A71D04 File Offset: 0x00A6FF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			loginCommonUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB58 RID: 129880 RVA: 0x00A71D70 File Offset: 0x00A6FF70
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
				LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				loginCommonUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				LoginCommonUIController loginCommonUIController2 = (LoginCommonUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				loginCommonUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FB59 RID: 129881 RVA: 0x00A71E80 File Offset: 0x00A70080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			string s = loginCommonUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FB5A RID: 129882 RVA: 0x00A71EDC File Offset: 0x00A700DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeImage(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginCommonUIController.m_luaExportHelper.m_fadeImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB5B RID: 129883 RVA: 0x00A71F34 File Offset: 0x00A70134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeImage(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			Image fadeImage;
			LuaObject.checkType<Image>(l, 2, out fadeImage);
			loginCommonUIController.m_luaExportHelper.m_fadeImage = fadeImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB5C RID: 129884 RVA: 0x00A71F90 File Offset: 0x00A70190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_disableInputGameObject(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginCommonUIController.m_luaExportHelper.m_disableInputGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB5D RID: 129885 RVA: 0x00A71FE8 File Offset: 0x00A701E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_disableInputGameObject(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			GameObject disableInputGameObject;
			LuaObject.checkType<GameObject>(l, 2, out disableInputGameObject);
			loginCommonUIController.m_luaExportHelper.m_disableInputGameObject = disableInputGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB5E RID: 129886 RVA: 0x00A72044 File Offset: 0x00A70244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_screenFade(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginCommonUIController.m_luaExportHelper.m_screenFade);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB5F RID: 129887 RVA: 0x00A7209C File Offset: 0x00A7029C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_screenFade(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			ScreenFade screenFade;
			LuaObject.checkType<ScreenFade>(l, 2, out screenFade);
			loginCommonUIController.m_luaExportHelper.m_screenFade = screenFade;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB60 RID: 129888 RVA: 0x00A720F8 File Offset: 0x00A702F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchFx(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginCommonUIController.m_luaExportHelper.m_touchFx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB61 RID: 129889 RVA: 0x00A72150 File Offset: 0x00A70350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchFx(IntPtr l)
	{
		int result;
		try
		{
			LoginCommonUIController loginCommonUIController = (LoginCommonUIController)LuaObject.checkSelf(l);
			TouchFx touchFx;
			LuaObject.checkType<TouchFx>(l, 2, out touchFx);
			loginCommonUIController.m_luaExportHelper.m_touchFx = touchFx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB62 RID: 129890 RVA: 0x00A721AC File Offset: 0x00A703AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LoginCommonUIController");
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.InitTouchFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.DisposeTouchFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.EnableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.FadeIn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.FadeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache13);
		string name = "m_fadeImage";
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.get_m_fadeImage);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.set_m_fadeImage);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache15, true);
		string name2 = "m_disableInputGameObject";
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.get_m_disableInputGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.set_m_disableInputGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache17, true);
		string name3 = "m_screenFade";
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.get_m_screenFade);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.set_m_screenFade);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache19, true);
		string name4 = "m_touchFx";
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.get_m_touchFx);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.set_m_touchFx);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_LoginCommonUIController.<>f__mg$cache1B, true);
		LuaObject.createTypeMetatable(l, null, typeof(LoginCommonUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015B34 RID: 88884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015B35 RID: 88885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015B36 RID: 88886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015B37 RID: 88887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015B38 RID: 88888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015B39 RID: 88889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015B3A RID: 88890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015B3B RID: 88891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015B3C RID: 88892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015B3D RID: 88893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015B3E RID: 88894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015B3F RID: 88895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015B40 RID: 88896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015B41 RID: 88897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015B42 RID: 88898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015B43 RID: 88899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015B44 RID: 88900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015B45 RID: 88901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015B46 RID: 88902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015B47 RID: 88903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015B48 RID: 88904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015B49 RID: 88905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015B4A RID: 88906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015B4B RID: 88907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015B4C RID: 88908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015B4D RID: 88909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015B4E RID: 88910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015B4F RID: 88911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
