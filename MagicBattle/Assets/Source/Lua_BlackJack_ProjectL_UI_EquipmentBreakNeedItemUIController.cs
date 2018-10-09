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

// Token: 0x02001423 RID: 5155
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController : LuaObject
{
	// Token: 0x0601D5F7 RID: 120311 RVA: 0x00948E48 File Offset: 0x00947048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitEquipmentBreakNeedItem(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			equipmentBreakNeedItemUIController.InitEquipmentBreakNeedItem(goods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5F8 RID: 120312 RVA: 0x00948EA0 File Offset: 0x009470A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			equipmentBreakNeedItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5F9 RID: 120313 RVA: 0x00948EF4 File Offset: 0x009470F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			equipmentBreakNeedItemUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5FA RID: 120314 RVA: 0x00948F48 File Offset: 0x00947148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5FB RID: 120315 RVA: 0x00948FB4 File Offset: 0x009471B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5FC RID: 120316 RVA: 0x00949008 File Offset: 0x00947208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5FD RID: 120317 RVA: 0x0094905C File Offset: 0x0094725C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D5FE RID: 120318 RVA: 0x00949104 File Offset: 0x00947304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5FF RID: 120319 RVA: 0x00949158 File Offset: 0x00947358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D600 RID: 120320 RVA: 0x009491C4 File Offset: 0x009473C4
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
				EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController2 = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				equipmentBreakNeedItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D601 RID: 120321 RVA: 0x009492D4 File Offset: 0x009474D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D602 RID: 120322 RVA: 0x00949340 File Offset: 0x00947540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D603 RID: 120323 RVA: 0x009493AC File Offset: 0x009475AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D604 RID: 120324 RVA: 0x00949418 File Offset: 0x00947618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D605 RID: 120325 RVA: 0x00949484 File Offset: 0x00947684
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
				EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController2 = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				equipmentBreakNeedItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D606 RID: 120326 RVA: 0x00949594 File Offset: 0x00947794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			string s = equipmentBreakNeedItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D607 RID: 120327 RVA: 0x009495F0 File Offset: 0x009477F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__callDele_EventOnClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D608 RID: 120328 RVA: 0x00949668 File Offset: 0x00947868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			equipmentBreakNeedItemUIController.m_luaExportHelper.__clearDele_EventOnClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D609 RID: 120329 RVA: 0x009496E0 File Offset: 0x009478E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					equipmentBreakNeedItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					equipmentBreakNeedItemUIController.EventOnClick -= value;
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

	// Token: 0x0601D60A RID: 120330 RVA: 0x00949760 File Offset: 0x00947960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBreakNeedItemUIController.m_luaExportHelper.m_iconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D60B RID: 120331 RVA: 0x009497B8 File Offset: 0x009479B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconBg(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			Image iconBg;
			LuaObject.checkType<Image>(l, 2, out iconBg);
			equipmentBreakNeedItemUIController.m_luaExportHelper.m_iconBg = iconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D60C RID: 120332 RVA: 0x00949814 File Offset: 0x00947A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBreakNeedItemUIController.m_luaExportHelper.m_iconSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D60D RID: 120333 RVA: 0x0094986C File Offset: 0x00947A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			GameObject iconSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out iconSSREffect);
			equipmentBreakNeedItemUIController.m_luaExportHelper.m_iconSSREffect = iconSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D60E RID: 120334 RVA: 0x009498C8 File Offset: 0x00947AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_icon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBreakNeedItemUIController.m_luaExportHelper.m_icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D60F RID: 120335 RVA: 0x00949920 File Offset: 0x00947B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_icon(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			Image icon;
			LuaObject.checkType<Image>(l, 2, out icon);
			equipmentBreakNeedItemUIController.m_luaExportHelper.m_icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D610 RID: 120336 RVA: 0x0094997C File Offset: 0x00947B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_haveCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBreakNeedItemUIController.m_luaExportHelper.m_haveCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D611 RID: 120337 RVA: 0x009499D4 File Offset: 0x00947BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_haveCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			Text haveCount;
			LuaObject.checkType<Text>(l, 2, out haveCount);
			equipmentBreakNeedItemUIController.m_luaExportHelper.m_haveCount = haveCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D612 RID: 120338 RVA: 0x00949A30 File Offset: 0x00947C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBreakNeedItemUIController.m_luaExportHelper.m_needCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D613 RID: 120339 RVA: 0x00949A88 File Offset: 0x00947C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			Text needCount;
			LuaObject.checkType<Text>(l, 2, out needCount);
			equipmentBreakNeedItemUIController.m_luaExportHelper.m_needCount = needCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D614 RID: 120340 RVA: 0x00949AE4 File Offset: 0x00947CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBreakNeedItemUIController.m_luaExportHelper.m_countStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D615 RID: 120341 RVA: 0x00949B3C File Offset: 0x00947D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController countStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out countStateCtrl);
			equipmentBreakNeedItemUIController.m_luaExportHelper.m_countStateCtrl = countStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D616 RID: 120342 RVA: 0x00949B98 File Offset: 0x00947D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBreakNeedItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D617 RID: 120343 RVA: 0x00949BF0 File Offset: 0x00947DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			equipmentBreakNeedItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D618 RID: 120344 RVA: 0x00949C4C File Offset: 0x00947E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goods(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBreakNeedItemUIController.m_goods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D619 RID: 120345 RVA: 0x00949CA0 File Offset: 0x00947EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goods(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBreakNeedItemUIController equipmentBreakNeedItemUIController = (EquipmentBreakNeedItemUIController)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			equipmentBreakNeedItemUIController.m_goods = goods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D61A RID: 120346 RVA: 0x00949CF8 File Offset: 0x00947EF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentBreakNeedItemUIController");
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.InitEquipmentBreakNeedItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache11);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache12, true);
		string name2 = "m_iconBg";
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.get_m_iconBg);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.set_m_iconBg);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache14, true);
		string name3 = "m_iconSSREffect";
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.get_m_iconSSREffect);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.set_m_iconSSREffect);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache16, true);
		string name4 = "m_icon";
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.get_m_icon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.set_m_icon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache18, true);
		string name5 = "m_haveCount";
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.get_m_haveCount);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.set_m_haveCount);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1A, true);
		string name6 = "m_needCount";
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.get_m_needCount);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.set_m_needCount);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1C, true);
		string name7 = "m_countStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.get_m_countStateCtrl);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.set_m_countStateCtrl);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1E, true);
		string name8 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.get_m_button);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache20, true);
		string name9 = "m_goods";
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.get_m_goods);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.set_m_goods);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.<>f__mg$cache22, true);
		LuaObject.createTypeMetatable(l, null, typeof(EquipmentBreakNeedItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013793 RID: 79763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013794 RID: 79764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013795 RID: 79765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013796 RID: 79766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013797 RID: 79767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013798 RID: 79768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013799 RID: 79769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401379A RID: 79770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401379B RID: 79771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401379C RID: 79772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401379D RID: 79773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401379E RID: 79774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401379F RID: 79775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040137A0 RID: 79776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040137A1 RID: 79777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040137A2 RID: 79778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040137A3 RID: 79779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040137A4 RID: 79780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040137A5 RID: 79781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040137A6 RID: 79782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040137A7 RID: 79783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040137A8 RID: 79784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040137A9 RID: 79785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040137AA RID: 79786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040137AB RID: 79787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040137AC RID: 79788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040137AD RID: 79789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040137AE RID: 79790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040137AF RID: 79791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040137B0 RID: 79792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040137B1 RID: 79793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040137B2 RID: 79794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040137B3 RID: 79795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040137B4 RID: 79796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040137B5 RID: 79797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;
}
