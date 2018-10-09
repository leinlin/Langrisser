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

// Token: 0x02001371 RID: 4977
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle : LuaObject
{
	// Token: 0x0601ADD1 RID: 110033 RVA: 0x00808EF8 File Offset: 0x008070F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaDefendRuleInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			ConfigDataArenaDefendRuleInfo arenaDefendRuleInfo;
			LuaObject.checkType<ConfigDataArenaDefendRuleInfo>(l, 2, out arenaDefendRuleInfo);
			arenaDefendRuleToggle.SetArenaDefendRuleInfo(arenaDefendRuleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADD2 RID: 110034 RVA: 0x00808F50 File Offset: 0x00807150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelected(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			bool selected;
			LuaObject.checkType(l, 2, out selected);
			arenaDefendRuleToggle.SetSelected(selected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADD3 RID: 110035 RVA: 0x00808FA8 File Offset: 0x008071A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSelected(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			bool b = arenaDefendRuleToggle.IsSelected();
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

	// Token: 0x0601ADD4 RID: 110036 RVA: 0x00808FFC File Offset: 0x008071FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			arenaDefendRuleToggle.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADD5 RID: 110037 RVA: 0x00809050 File Offset: 0x00807250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaDefendRuleToggle.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADD6 RID: 110038 RVA: 0x008090BC File Offset: 0x008072BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			arenaDefendRuleToggle.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADD7 RID: 110039 RVA: 0x00809110 File Offset: 0x00807310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			arenaDefendRuleToggle.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADD8 RID: 110040 RVA: 0x00809164 File Offset: 0x00807364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaDefendRuleToggle.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601ADD9 RID: 110041 RVA: 0x0080920C File Offset: 0x0080740C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			arenaDefendRuleToggle.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADDA RID: 110042 RVA: 0x00809260 File Offset: 0x00807460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaDefendRuleToggle.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADDB RID: 110043 RVA: 0x008092CC File Offset: 0x008074CC
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
				ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaDefendRuleToggle.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaDefendRuleToggle arenaDefendRuleToggle2 = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaDefendRuleToggle2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601ADDC RID: 110044 RVA: 0x008093DC File Offset: 0x008075DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendRuleToggle.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADDD RID: 110045 RVA: 0x00809448 File Offset: 0x00807648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendRuleToggle.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADDE RID: 110046 RVA: 0x008094B4 File Offset: 0x008076B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendRuleToggle.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADDF RID: 110047 RVA: 0x00809520 File Offset: 0x00807720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendRuleToggle.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADE0 RID: 110048 RVA: 0x0080958C File Offset: 0x0080778C
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
				ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaDefendRuleToggle.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaDefendRuleToggle arenaDefendRuleToggle2 = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaDefendRuleToggle2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601ADE1 RID: 110049 RVA: 0x0080969C File Offset: 0x0080789C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			string s = arenaDefendRuleToggle.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601ADE2 RID: 110050 RVA: 0x008096F8 File Offset: 0x008078F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendRuleToggle.m_luaExportHelper.m_toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADE3 RID: 110051 RVA: 0x00809750 File Offset: 0x00807950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			arenaDefendRuleToggle.m_luaExportHelper.m_toggle = toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADE4 RID: 110052 RVA: 0x008097AC File Offset: 0x008079AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendRuleToggle.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADE5 RID: 110053 RVA: 0x00809804 File Offset: 0x00807A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			arenaDefendRuleToggle.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADE6 RID: 110054 RVA: 0x00809860 File Offset: 0x00807A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendRuleToggle.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADE7 RID: 110055 RVA: 0x008098B8 File Offset: 0x00807AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			arenaDefendRuleToggle.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADE8 RID: 110056 RVA: 0x00809914 File Offset: 0x00807B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descText(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendRuleToggle.m_luaExportHelper.m_descText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADE9 RID: 110057 RVA: 0x0080996C File Offset: 0x00807B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descText(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendRuleToggle arenaDefendRuleToggle = (ArenaDefendRuleToggle)LuaObject.checkSelf(l);
			Text descText;
			LuaObject.checkType<Text>(l, 2, out descText);
			arenaDefendRuleToggle.m_luaExportHelper.m_descText = descText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADEA RID: 110058 RVA: 0x008099C8 File Offset: 0x00807BC8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaDefendRuleToggle");
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.SetArenaDefendRuleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.SetSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.IsSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache10);
		string name = "m_toggle";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.get_m_toggle);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.set_m_toggle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache12, true);
		string name2 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.get_m_nameText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.set_m_nameText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache14, true);
		string name3 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.get_m_iconImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.set_m_iconImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache16, true);
		string name4 = "m_descText";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.get_m_descText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.set_m_descText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.<>f__mg$cache18, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaDefendRuleToggle), typeof(UIControllerBase));
	}

	// Token: 0x040110D1 RID: 69841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040110D2 RID: 69842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040110D3 RID: 69843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040110D4 RID: 69844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040110D5 RID: 69845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040110D6 RID: 69846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040110D7 RID: 69847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040110D8 RID: 69848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040110D9 RID: 69849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040110DA RID: 69850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040110DB RID: 69851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040110DC RID: 69852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040110DD RID: 69853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040110DE RID: 69854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040110DF RID: 69855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040110E0 RID: 69856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040110E1 RID: 69857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040110E2 RID: 69858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040110E3 RID: 69859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040110E4 RID: 69860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040110E5 RID: 69861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040110E6 RID: 69862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040110E7 RID: 69863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040110E8 RID: 69864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040110E9 RID: 69865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
