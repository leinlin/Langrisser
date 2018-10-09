using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200150E RID: 5390
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController : LuaObject
{
	// Token: 0x0601FEF5 RID: 130805 RVA: 0x00A8E408 File Offset: 0x00A8C608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroFragmentItem(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			HeroFragmentBagItem heroFragementBagItem;
			LuaObject.checkType<HeroFragmentBagItem>(l, 2, out heroFragementBagItem);
			memoryStoreHeroFragmentItemUIController.InitHeroFragmentItem(heroFragementBagItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEF6 RID: 130806 RVA: 0x00A8E460 File Offset: 0x00A8C660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEF7 RID: 130807 RVA: 0x00A8E4B4 File Offset: 0x00A8C6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEF8 RID: 130808 RVA: 0x00A8E508 File Offset: 0x00A8C708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEF9 RID: 130809 RVA: 0x00A8E574 File Offset: 0x00A8C774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEFA RID: 130810 RVA: 0x00A8E5C8 File Offset: 0x00A8C7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEFB RID: 130811 RVA: 0x00A8E61C File Offset: 0x00A8C81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FEFC RID: 130812 RVA: 0x00A8E6C4 File Offset: 0x00A8C8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEFD RID: 130813 RVA: 0x00A8E718 File Offset: 0x00A8C918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEFE RID: 130814 RVA: 0x00A8E784 File Offset: 0x00A8C984
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
				MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController2 = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				memoryStoreHeroFragmentItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FEFF RID: 130815 RVA: 0x00A8E894 File Offset: 0x00A8CA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF00 RID: 130816 RVA: 0x00A8E900 File Offset: 0x00A8CB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF01 RID: 130817 RVA: 0x00A8E96C File Offset: 0x00A8CB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF02 RID: 130818 RVA: 0x00A8E9D8 File Offset: 0x00A8CBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF03 RID: 130819 RVA: 0x00A8EA44 File Offset: 0x00A8CC44
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
				MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController2 = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				memoryStoreHeroFragmentItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FF04 RID: 130820 RVA: 0x00A8EB54 File Offset: 0x00A8CD54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			string s = memoryStoreHeroFragmentItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FF05 RID: 130821 RVA: 0x00A8EBB0 File Offset: 0x00A8CDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImg(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryStoreHeroFragmentItemUIController.m_luaExportHelper.m_iconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF06 RID: 130822 RVA: 0x00A8EC08 File Offset: 0x00A8CE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImg(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			Image iconImg;
			LuaObject.checkType<Image>(l, 2, out iconImg);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.m_iconImg = iconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF07 RID: 130823 RVA: 0x00A8EC64 File Offset: 0x00A8CE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_numberText(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryStoreHeroFragmentItemUIController.m_luaExportHelper.m_numberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF08 RID: 130824 RVA: 0x00A8ECBC File Offset: 0x00A8CEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_numberText(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			Text numberText;
			LuaObject.checkType<Text>(l, 2, out numberText);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.m_numberText = numberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF09 RID: 130825 RVA: 0x00A8ED18 File Offset: 0x00A8CF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryStoreHeroFragmentItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF0A RID: 130826 RVA: 0x00A8ED70 File Offset: 0x00A8CF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF0B RID: 130827 RVA: 0x00A8EDCC File Offset: 0x00A8CFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroFragementBagItem(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryStoreHeroFragmentItemUIController.m_luaExportHelper.m_heroFragementBagItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF0C RID: 130828 RVA: 0x00A8EE24 File Offset: 0x00A8D024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroFragementBagItem(IntPtr l)
	{
		int result;
		try
		{
			MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = (MemoryStoreHeroFragmentItemUIController)LuaObject.checkSelf(l);
			HeroFragmentBagItem heroFragementBagItem;
			LuaObject.checkType<HeroFragmentBagItem>(l, 2, out heroFragementBagItem);
			memoryStoreHeroFragmentItemUIController.m_luaExportHelper.m_heroFragementBagItem = heroFragementBagItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF0D RID: 130829 RVA: 0x00A8EE80 File Offset: 0x00A8D080
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MemoryStoreHeroFragmentItemUIController");
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.InitHeroFragmentItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cacheF);
		string name = "m_iconImg";
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.get_m_iconImg);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.set_m_iconImg);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache11, true);
		string name2 = "m_numberText";
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.get_m_numberText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.set_m_numberText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache13, true);
		string name3 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.get_m_nameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache15, true);
		string name4 = "m_heroFragementBagItem";
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.get_m_heroFragementBagItem);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.set_m_heroFragementBagItem);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.<>f__mg$cache17, true);
		LuaObject.createTypeMetatable(l, null, typeof(MemoryStoreHeroFragmentItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015EBB RID: 89787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015EBC RID: 89788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015EBD RID: 89789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015EBE RID: 89790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015EBF RID: 89791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015EC0 RID: 89792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015EC1 RID: 89793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015EC2 RID: 89794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015EC3 RID: 89795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015EC4 RID: 89796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015EC5 RID: 89797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015EC6 RID: 89798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015EC7 RID: 89799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015EC8 RID: 89800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015EC9 RID: 89801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015ECA RID: 89802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015ECB RID: 89803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015ECC RID: 89804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015ECD RID: 89805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015ECE RID: 89806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015ECF RID: 89807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015ED0 RID: 89808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015ED1 RID: 89809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015ED2 RID: 89810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
