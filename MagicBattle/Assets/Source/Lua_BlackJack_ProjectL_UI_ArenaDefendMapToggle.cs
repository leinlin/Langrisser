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

// Token: 0x0200136F RID: 4975
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle : LuaObject
{
	// Token: 0x0601AD96 RID: 109974 RVA: 0x00806F74 File Offset: 0x00805174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			ConfigDataArenaBattleInfo arenaBattleInfo;
			LuaObject.checkType<ConfigDataArenaBattleInfo>(l, 2, out arenaBattleInfo);
			arenaDefendMapToggle.SetArenaBattleInfo(arenaBattleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD97 RID: 109975 RVA: 0x00806FCC File Offset: 0x008051CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelected(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			bool selected;
			LuaObject.checkType(l, 2, out selected);
			arenaDefendMapToggle.SetSelected(selected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD98 RID: 109976 RVA: 0x00807024 File Offset: 0x00805224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSelected(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			bool b = arenaDefendMapToggle.IsSelected();
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

	// Token: 0x0601AD99 RID: 109977 RVA: 0x00807078 File Offset: 0x00805278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			arenaDefendMapToggle.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD9A RID: 109978 RVA: 0x008070CC File Offset: 0x008052CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaDefendMapToggle.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD9B RID: 109979 RVA: 0x00807138 File Offset: 0x00805338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			arenaDefendMapToggle.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD9C RID: 109980 RVA: 0x0080718C File Offset: 0x0080538C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			arenaDefendMapToggle.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD9D RID: 109981 RVA: 0x008071E0 File Offset: 0x008053E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaDefendMapToggle.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AD9E RID: 109982 RVA: 0x00807288 File Offset: 0x00805488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			arenaDefendMapToggle.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD9F RID: 109983 RVA: 0x008072DC File Offset: 0x008054DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaDefendMapToggle.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADA0 RID: 109984 RVA: 0x00807348 File Offset: 0x00805548
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
				ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaDefendMapToggle.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaDefendMapToggle arenaDefendMapToggle2 = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaDefendMapToggle2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601ADA1 RID: 109985 RVA: 0x00807458 File Offset: 0x00805658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendMapToggle.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADA2 RID: 109986 RVA: 0x008074C4 File Offset: 0x008056C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendMapToggle.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADA3 RID: 109987 RVA: 0x00807530 File Offset: 0x00805730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendMapToggle.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADA4 RID: 109988 RVA: 0x0080759C File Offset: 0x0080579C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendMapToggle.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADA5 RID: 109989 RVA: 0x00807608 File Offset: 0x00805808
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
				ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaDefendMapToggle.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaDefendMapToggle arenaDefendMapToggle2 = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaDefendMapToggle2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601ADA6 RID: 109990 RVA: 0x00807718 File Offset: 0x00805918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			string s = arenaDefendMapToggle.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601ADA7 RID: 109991 RVA: 0x00807774 File Offset: 0x00805974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendMapToggle.m_luaExportHelper.m_toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADA8 RID: 109992 RVA: 0x008077CC File Offset: 0x008059CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			arenaDefendMapToggle.m_luaExportHelper.m_toggle = toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADA9 RID: 109993 RVA: 0x00807828 File Offset: 0x00805A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendMapToggle.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADAA RID: 109994 RVA: 0x00807880 File Offset: 0x00805A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			arenaDefendMapToggle.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADAB RID: 109995 RVA: 0x008078DC File Offset: 0x00805ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendMapToggle.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADAC RID: 109996 RVA: 0x00807934 File Offset: 0x00805B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapToggle arenaDefendMapToggle = (ArenaDefendMapToggle)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			arenaDefendMapToggle.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADAD RID: 109997 RVA: 0x00807990 File Offset: 0x00805B90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaDefendMapToggle");
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.SetArenaBattleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.SetSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.IsSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache10);
		string name = "m_toggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.get_m_toggle);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.set_m_toggle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache12, true);
		string name2 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.get_m_image);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.set_m_image);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache14, true);
		string name3 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.get_m_nameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.set_m_nameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.<>f__mg$cache16, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaDefendMapToggle), typeof(UIControllerBase));
	}

	// Token: 0x0401109A RID: 69786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401109B RID: 69787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401109C RID: 69788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401109D RID: 69789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401109E RID: 69790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401109F RID: 69791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040110A0 RID: 69792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040110A1 RID: 69793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040110A2 RID: 69794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040110A3 RID: 69795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040110A4 RID: 69796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040110A5 RID: 69797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040110A6 RID: 69798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040110A7 RID: 69799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040110A8 RID: 69800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040110A9 RID: 69801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040110AA RID: 69802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040110AB RID: 69803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040110AC RID: 69804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040110AD RID: 69805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040110AE RID: 69806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040110AF RID: 69807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040110B0 RID: 69808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
