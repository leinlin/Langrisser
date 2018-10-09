using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001586 RID: 5510
[Preserve]
public class Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController : LuaObject
{
	// Token: 0x06021251 RID: 135761 RVA: 0x00B28D64 File Offset: 0x00B26F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroSkinItemInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			FixedStoreItem heroSkinItemInfo;
			LuaObject.checkType<FixedStoreItem>(l, 2, out heroSkinItemInfo);
			storeHeroSkinItemUIController.SetHeroSkinItemInfo(heroSkinItemInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021252 RID: 135762 RVA: 0x00B28DBC File Offset: 0x00B26FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetItemState(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			storeHeroSkinItemUIController.SetItemState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021253 RID: 135763 RVA: 0x00B28E08 File Offset: 0x00B27008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLimitTime(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			storeHeroSkinItemUIController.SetLimitTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021254 RID: 135764 RVA: 0x00B28E54 File Offset: 0x00B27054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			storeHeroSkinItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021255 RID: 135765 RVA: 0x00B28EA8 File Offset: 0x00B270A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStoreItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			storeHeroSkinItemUIController.m_luaExportHelper.OnStoreItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021256 RID: 135766 RVA: 0x00B28EFC File Offset: 0x00B270FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			storeHeroSkinItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021257 RID: 135767 RVA: 0x00B28F68 File Offset: 0x00B27168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			storeHeroSkinItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021258 RID: 135768 RVA: 0x00B28FBC File Offset: 0x00B271BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			storeHeroSkinItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021259 RID: 135769 RVA: 0x00B29010 File Offset: 0x00B27210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = storeHeroSkinItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602125A RID: 135770 RVA: 0x00B290B8 File Offset: 0x00B272B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			storeHeroSkinItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602125B RID: 135771 RVA: 0x00B2910C File Offset: 0x00B2730C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			storeHeroSkinItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602125C RID: 135772 RVA: 0x00B29178 File Offset: 0x00B27378
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
				StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				storeHeroSkinItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				StoreHeroSkinItemUIController storeHeroSkinItemUIController2 = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				storeHeroSkinItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602125D RID: 135773 RVA: 0x00B29288 File Offset: 0x00B27488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeHeroSkinItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602125E RID: 135774 RVA: 0x00B292F4 File Offset: 0x00B274F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeHeroSkinItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602125F RID: 135775 RVA: 0x00B29360 File Offset: 0x00B27560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeHeroSkinItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021260 RID: 135776 RVA: 0x00B293CC File Offset: 0x00B275CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeHeroSkinItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021261 RID: 135777 RVA: 0x00B29438 File Offset: 0x00B27638
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
				StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				storeHeroSkinItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				StoreHeroSkinItemUIController storeHeroSkinItemUIController2 = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				storeHeroSkinItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021262 RID: 135778 RVA: 0x00B29548 File Offset: 0x00B27748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			string s = storeHeroSkinItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021263 RID: 135779 RVA: 0x00B295A4 File Offset: 0x00B277A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			StoreHeroSkinItemUIController obj;
			LuaObject.checkType<StoreHeroSkinItemUIController>(l, 2, out obj);
			storeHeroSkinItemUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021264 RID: 135780 RVA: 0x00B29600 File Offset: 0x00B27800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			StoreHeroSkinItemUIController obj;
			LuaObject.checkType<StoreHeroSkinItemUIController>(l, 2, out obj);
			storeHeroSkinItemUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021265 RID: 135781 RVA: 0x00B2965C File Offset: 0x00B2785C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkinItemOutOfDate(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			storeHeroSkinItemUIController.m_luaExportHelper.__callDele_EventOnSkinItemOutOfDate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021266 RID: 135782 RVA: 0x00B296B0 File Offset: 0x00B278B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkinItemOutOfDate(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			storeHeroSkinItemUIController.m_luaExportHelper.__clearDele_EventOnSkinItemOutOfDate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021267 RID: 135783 RVA: 0x00B29704 File Offset: 0x00B27904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			Action<StoreHeroSkinItemUIController> value;
			int num = LuaObject.checkDelegate<Action<StoreHeroSkinItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeHeroSkinItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					storeHeroSkinItemUIController.EventOnClick -= value;
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

	// Token: 0x06021268 RID: 135784 RVA: 0x00B29784 File Offset: 0x00B27984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkinItemOutOfDate(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeHeroSkinItemUIController.EventOnSkinItemOutOfDate += value;
				}
				else if (num == 2)
				{
					storeHeroSkinItemUIController.EventOnSkinItemOutOfDate -= value;
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

	// Token: 0x06021269 RID: 135785 RVA: 0x00B29804 File Offset: 0x00B27A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeItemButton(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_storeItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602126A RID: 135786 RVA: 0x00B29858 File Offset: 0x00B27A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeItemButton(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			Button storeItemButton;
			LuaObject.checkType<Button>(l, 2, out storeItemButton);
			storeHeroSkinItemUIController.m_storeItemButton = storeItemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602126B RID: 135787 RVA: 0x00B298B0 File Offset: 0x00B27AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSkinIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_heroSkinIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602126C RID: 135788 RVA: 0x00B29904 File Offset: 0x00B27B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSkinIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			Image heroSkinIcon;
			LuaObject.checkType<Image>(l, 2, out heroSkinIcon);
			storeHeroSkinItemUIController.m_heroSkinIcon = heroSkinIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602126D RID: 135789 RVA: 0x00B2995C File Offset: 0x00B27B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroName(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_heroName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602126E RID: 135790 RVA: 0x00B299B0 File Offset: 0x00B27BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroName(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			Text heroName;
			LuaObject.checkType<Text>(l, 2, out heroName);
			storeHeroSkinItemUIController.m_heroName = heroName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602126F RID: 135791 RVA: 0x00B29A08 File Offset: 0x00B27C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinName(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_skinName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021270 RID: 135792 RVA: 0x00B29A5C File Offset: 0x00B27C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinName(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			Text skinName;
			LuaObject.checkType<Text>(l, 2, out skinName);
			storeHeroSkinItemUIController.m_skinName = skinName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021271 RID: 135793 RVA: 0x00B29AB4 File Offset: 0x00B27CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_priceText(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_priceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021272 RID: 135794 RVA: 0x00B29B08 File Offset: 0x00B27D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_priceText(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			Text priceText;
			LuaObject.checkType<Text>(l, 2, out priceText);
			storeHeroSkinItemUIController.m_priceText = priceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021273 RID: 135795 RVA: 0x00B29B60 File Offset: 0x00B27D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_restTime(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_restTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021274 RID: 135796 RVA: 0x00B29BB4 File Offset: 0x00B27DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_restTime(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			Text restTime;
			LuaObject.checkType<Text>(l, 2, out restTime);
			storeHeroSkinItemUIController.m_restTime = restTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021275 RID: 135797 RVA: 0x00B29C0C File Offset: 0x00B27E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeGo(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_timeGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021276 RID: 135798 RVA: 0x00B29C60 File Offset: 0x00B27E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeGo(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			GameObject timeGo;
			LuaObject.checkType<GameObject>(l, 2, out timeGo);
			storeHeroSkinItemUIController.m_timeGo = timeGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021277 RID: 135799 RVA: 0x00B29CB8 File Offset: 0x00B27EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeValueText(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_timeValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021278 RID: 135800 RVA: 0x00B29D0C File Offset: 0x00B27F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeValueText(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			Text timeValueText;
			LuaObject.checkType<Text>(l, 2, out timeValueText);
			storeHeroSkinItemUIController.m_timeValueText = timeValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021279 RID: 135801 RVA: 0x00B29D64 File Offset: 0x00B27F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_itemStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602127A RID: 135802 RVA: 0x00B29DB8 File Offset: 0x00B27FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController itemStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out itemStateCtrl);
			storeHeroSkinItemUIController.m_itemStateCtrl = itemStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602127B RID: 135803 RVA: 0x00B29E10 File Offset: 0x00B28010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeItemConfig(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_storeItemConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602127C RID: 135804 RVA: 0x00B29E64 File Offset: 0x00B28064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeItemConfig(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo storeItemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out storeItemConfig);
			storeHeroSkinItemUIController.m_storeItemConfig = storeItemConfig;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602127D RID: 135805 RVA: 0x00B29EBC File Offset: 0x00B280BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeType(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeHeroSkinItemUIController.m_storeType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602127E RID: 135806 RVA: 0x00B29F10 File Offset: 0x00B28110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeType(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			StoreType storeType;
			LuaObject.checkEnum<StoreType>(l, 2, out storeType);
			storeHeroSkinItemUIController.m_storeType = storeType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602127F RID: 135807 RVA: 0x00B29F68 File Offset: 0x00B28168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021280 RID: 135808 RVA: 0x00B29FC0 File Offset: 0x00B281C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			storeHeroSkinItemUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021281 RID: 135809 RVA: 0x00B2A01C File Offset: 0x00B2821C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeHeroSkinItemUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021282 RID: 135810 RVA: 0x00B2A074 File Offset: 0x00B28274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreHeroSkinItemUIController storeHeroSkinItemUIController = (StoreHeroSkinItemUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			storeHeroSkinItemUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021283 RID: 135811 RVA: 0x00B2A0D0 File Offset: 0x00B282D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.StoreHeroSkinItemUIController");
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.SetHeroSkinItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.SetItemState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.SetLimitTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.OnStoreItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__callDele_EventOnSkinItemOutOfDate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.__clearDele_EventOnSkinItemOutOfDate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache15);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache16, true);
		string name2 = "EventOnSkinItemOutOfDate";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_EventOnSkinItemOutOfDate);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache17, true);
		string name3 = "m_storeItemButton";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_storeItemButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_storeItemButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache19, true);
		string name4 = "m_heroSkinIcon";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_heroSkinIcon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_heroSkinIcon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_heroName";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_heroName);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_heroName);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1D, true);
		string name6 = "m_skinName";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_skinName);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_skinName);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache1F, true);
		string name7 = "m_priceText";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_priceText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_priceText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache21, true);
		string name8 = "m_restTime";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_restTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_restTime);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache23, true);
		string name9 = "m_timeGo";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_timeGo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_timeGo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache25, true);
		string name10 = "m_timeValueText";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_timeValueText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_timeValueText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache27, true);
		string name11 = "m_itemStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_itemStateCtrl);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_itemStateCtrl);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache29, true);
		string name12 = "m_storeItemConfig";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_storeItemConfig);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_storeItemConfig);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2B, true);
		string name13 = "m_storeType";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_storeType);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_storeType);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2D, true);
		string name14 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_playerContext);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache2F, true);
		string name15 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.get_m_configDataLoader);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.<>f__mg$cache31, true);
		LuaObject.createTypeMetatable(l, null, typeof(StoreHeroSkinItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017127 RID: 94503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017128 RID: 94504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017129 RID: 94505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401712A RID: 94506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401712B RID: 94507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401712C RID: 94508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401712D RID: 94509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401712E RID: 94510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401712F RID: 94511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017130 RID: 94512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017131 RID: 94513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017132 RID: 94514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017133 RID: 94515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017134 RID: 94516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017135 RID: 94517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017136 RID: 94518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017137 RID: 94519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017138 RID: 94520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017139 RID: 94521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401713A RID: 94522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401713B RID: 94523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401713C RID: 94524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401713D RID: 94525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401713E RID: 94526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401713F RID: 94527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017140 RID: 94528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017141 RID: 94529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017142 RID: 94530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017143 RID: 94531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017144 RID: 94532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017145 RID: 94533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017146 RID: 94534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017147 RID: 94535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017148 RID: 94536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017149 RID: 94537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401714A RID: 94538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401714B RID: 94539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401714C RID: 94540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401714D RID: 94541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401714E RID: 94542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401714F RID: 94543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017150 RID: 94544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017151 RID: 94545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017152 RID: 94546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017153 RID: 94547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017154 RID: 94548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017155 RID: 94549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017156 RID: 94550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017157 RID: 94551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017158 RID: 94552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;
}
