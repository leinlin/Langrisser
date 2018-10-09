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

// Token: 0x020014E4 RID: 5348
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController : LuaObject
{
	// Token: 0x0601F883 RID: 129155 RVA: 0x00A5B940 File Offset: 0x00A59B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroSkinJobItem(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			heroSkinJobUIController.InitHeroSkinJobItem(jobConnectionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F884 RID: 129156 RVA: 0x00A5B998 File Offset: 0x00A59B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			heroSkinJobUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F885 RID: 129157 RVA: 0x00A5B9EC File Offset: 0x00A59BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroSkinJobUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F886 RID: 129158 RVA: 0x00A5BA58 File Offset: 0x00A59C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			heroSkinJobUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F887 RID: 129159 RVA: 0x00A5BAAC File Offset: 0x00A59CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			heroSkinJobUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F888 RID: 129160 RVA: 0x00A5BB00 File Offset: 0x00A59D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroSkinJobUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F889 RID: 129161 RVA: 0x00A5BBA8 File Offset: 0x00A59DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			heroSkinJobUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F88A RID: 129162 RVA: 0x00A5BBFC File Offset: 0x00A59DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroSkinJobUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F88B RID: 129163 RVA: 0x00A5BC68 File Offset: 0x00A59E68
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
				HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroSkinJobUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroSkinJobUIController heroSkinJobUIController2 = (HeroSkinJobUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroSkinJobUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F88C RID: 129164 RVA: 0x00A5BD78 File Offset: 0x00A59F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkinJobUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F88D RID: 129165 RVA: 0x00A5BDE4 File Offset: 0x00A59FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkinJobUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F88E RID: 129166 RVA: 0x00A5BE50 File Offset: 0x00A5A050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkinJobUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F88F RID: 129167 RVA: 0x00A5BEBC File Offset: 0x00A5A0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkinJobUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F890 RID: 129168 RVA: 0x00A5BF28 File Offset: 0x00A5A128
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
				HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroSkinJobUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroSkinJobUIController heroSkinJobUIController2 = (HeroSkinJobUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroSkinJobUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F891 RID: 129169 RVA: 0x00A5C038 File Offset: 0x00A5A238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			string s = heroSkinJobUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F892 RID: 129170 RVA: 0x00A5C094 File Offset: 0x00A5A294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinJobUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F893 RID: 129171 RVA: 0x00A5C0EC File Offset: 0x00A5A2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			heroSkinJobUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F894 RID: 129172 RVA: 0x00A5C148 File Offset: 0x00A5A348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinJobUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F895 RID: 129173 RVA: 0x00A5C1A0 File Offset: 0x00A5A3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinJobUIController heroSkinJobUIController = (HeroSkinJobUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			heroSkinJobUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F896 RID: 129174 RVA: 0x00A5C1FC File Offset: 0x00A5A3FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroSkinJobUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.InitHeroSkinJobItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheE);
		string name = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.get_m_nameText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache10, true);
		string name2 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.get_m_iconImage);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.<>f__mg$cache12, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroSkinJobUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401589D RID: 88221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401589E RID: 88222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401589F RID: 88223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040158A0 RID: 88224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040158A1 RID: 88225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040158A2 RID: 88226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040158A3 RID: 88227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040158A4 RID: 88228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040158A5 RID: 88229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040158A6 RID: 88230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040158A7 RID: 88231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040158A8 RID: 88232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040158A9 RID: 88233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040158AA RID: 88234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040158AB RID: 88235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040158AC RID: 88236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040158AD RID: 88237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040158AE RID: 88238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040158AF RID: 88239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
