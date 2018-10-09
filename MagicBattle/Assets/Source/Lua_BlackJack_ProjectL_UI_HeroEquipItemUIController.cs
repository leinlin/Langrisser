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

// Token: 0x020014C1 RID: 5313
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController : LuaObject
{
	// Token: 0x0601F115 RID: 127253 RVA: 0x00A1FDA8 File Offset: 0x00A1DFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroEquipmentItem(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			int heroId;
			LuaObject.checkType(l, 4, out heroId);
			heroEquipItemUIController.InitHeroEquipmentItem(equipment, slot, heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F116 RID: 127254 RVA: 0x00A1FE1C File Offset: 0x00A1E01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			heroEquipItemUIController.ShowSelectImage(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F117 RID: 127255 RVA: 0x00A1FE74 File Offset: 0x00A1E074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			heroEquipItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F118 RID: 127256 RVA: 0x00A1FEC8 File Offset: 0x00A1E0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnIconClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			heroEquipItemUIController.m_luaExportHelper.OnIconClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F119 RID: 127257 RVA: 0x00A1FF1C File Offset: 0x00A1E11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			heroEquipItemUIController.m_luaExportHelper.OnAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F11A RID: 127258 RVA: 0x00A1FF70 File Offset: 0x00A1E170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRuneIconButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			heroEquipItemUIController.m_luaExportHelper.OnRuneIconButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F11B RID: 127259 RVA: 0x00A1FFC4 File Offset: 0x00A1E1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroEquipItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F11C RID: 127260 RVA: 0x00A20030 File Offset: 0x00A1E230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			heroEquipItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F11D RID: 127261 RVA: 0x00A20084 File Offset: 0x00A1E284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			heroEquipItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F11E RID: 127262 RVA: 0x00A200D8 File Offset: 0x00A1E2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroEquipItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F11F RID: 127263 RVA: 0x00A20180 File Offset: 0x00A1E380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			heroEquipItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F120 RID: 127264 RVA: 0x00A201D4 File Offset: 0x00A1E3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroEquipItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F121 RID: 127265 RVA: 0x00A20240 File Offset: 0x00A1E440
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
				HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroEquipItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroEquipItemUIController heroEquipItemUIController2 = (HeroEquipItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroEquipItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F122 RID: 127266 RVA: 0x00A20350 File Offset: 0x00A1E550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroEquipItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F123 RID: 127267 RVA: 0x00A203BC File Offset: 0x00A1E5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroEquipItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F124 RID: 127268 RVA: 0x00A20428 File Offset: 0x00A1E628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroEquipItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F125 RID: 127269 RVA: 0x00A20494 File Offset: 0x00A1E694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroEquipItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F126 RID: 127270 RVA: 0x00A20500 File Offset: 0x00A1E700
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
				HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroEquipItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroEquipItemUIController heroEquipItemUIController2 = (HeroEquipItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroEquipItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F127 RID: 127271 RVA: 0x00A20610 File Offset: 0x00A1E810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			string s = heroEquipItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F128 RID: 127272 RVA: 0x00A2066C File Offset: 0x00A1E86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController obj;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out obj);
			heroEquipItemUIController.m_luaExportHelper.__callDele_EventOnAddButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F129 RID: 127273 RVA: 0x00A206C8 File Offset: 0x00A1E8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController obj;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out obj);
			heroEquipItemUIController.m_luaExportHelper.__clearDele_EventOnAddButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F12A RID: 127274 RVA: 0x00A20724 File Offset: 0x00A1E924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnIconClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController obj;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out obj);
			heroEquipItemUIController.m_luaExportHelper.__callDele_EventOnIconClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F12B RID: 127275 RVA: 0x00A20780 File Offset: 0x00A1E980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnIconClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController obj;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out obj);
			heroEquipItemUIController.m_luaExportHelper.__clearDele_EventOnIconClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F12C RID: 127276 RVA: 0x00A207DC File Offset: 0x00A1E9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRuneIconButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController obj;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out obj);
			heroEquipItemUIController.m_luaExportHelper.__callDele_EventOnRuneIconButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F12D RID: 127277 RVA: 0x00A20838 File Offset: 0x00A1EA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRuneIconButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController obj;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out obj);
			heroEquipItemUIController.m_luaExportHelper.__clearDele_EventOnRuneIconButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F12E RID: 127278 RVA: 0x00A20894 File Offset: 0x00A1EA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Action<HeroEquipItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroEquipItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroEquipItemUIController.EventOnAddButtonClick += value;
				}
				else if (num == 2)
				{
					heroEquipItemUIController.EventOnAddButtonClick -= value;
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

	// Token: 0x0601F12F RID: 127279 RVA: 0x00A20914 File Offset: 0x00A1EB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnIconClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Action<HeroEquipItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroEquipItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroEquipItemUIController.EventOnIconClick += value;
				}
				else if (num == 2)
				{
					heroEquipItemUIController.EventOnIconClick -= value;
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

	// Token: 0x0601F130 RID: 127280 RVA: 0x00A20994 File Offset: 0x00A1EB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRuneIconButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Action<HeroEquipItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroEquipItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroEquipItemUIController.EventOnRuneIconButtonClick += value;
				}
				else if (num == 2)
				{
					heroEquipItemUIController.EventOnRuneIconButtonClick -= value;
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

	// Token: 0x0601F131 RID: 127281 RVA: 0x00A20A14 File Offset: 0x00A1EC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconBg(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_iconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F132 RID: 127282 RVA: 0x00A20A6C File Offset: 0x00A1EC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconBg(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Image iconBg;
			LuaObject.checkType<Image>(l, 2, out iconBg);
			heroEquipItemUIController.m_luaExportHelper.m_iconBg = iconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F133 RID: 127283 RVA: 0x00A20AC8 File Offset: 0x00A1ECC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_iconSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F134 RID: 127284 RVA: 0x00A20B20 File Offset: 0x00A1ED20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconSSREffect(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			GameObject iconSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out iconSSREffect);
			heroEquipItemUIController.m_luaExportHelper.m_iconSSREffect = iconSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F135 RID: 127285 RVA: 0x00A20B7C File Offset: 0x00A1ED7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_iconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F136 RID: 127286 RVA: 0x00A20BD4 File Offset: 0x00A1EDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Image iconImg;
			LuaObject.checkType<Image>(l, 2, out iconImg);
			heroEquipItemUIController.m_luaExportHelper.m_iconImg = iconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F137 RID: 127287 RVA: 0x00A20C30 File Offset: 0x00A1EE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconButton(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_iconButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F138 RID: 127288 RVA: 0x00A20C88 File Offset: 0x00A1EE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconButton(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Button iconButton;
			LuaObject.checkType<Button>(l, 2, out iconButton);
			heroEquipItemUIController.m_luaExportHelper.m_iconButton = iconButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F139 RID: 127289 RVA: 0x00A20CE4 File Offset: 0x00A1EEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F13A RID: 127290 RVA: 0x00A20D3C File Offset: 0x00A1EF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			heroEquipItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F13B RID: 127291 RVA: 0x00A20D98 File Offset: 0x00A1EF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lvText(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_lvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F13C RID: 127292 RVA: 0x00A20DF0 File Offset: 0x00A1EFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lvText(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Text lvText;
			LuaObject.checkType<Text>(l, 2, out lvText);
			heroEquipItemUIController.m_luaExportHelper.m_lvText = lvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F13D RID: 127293 RVA: 0x00A20E4C File Offset: 0x00A1F04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starGroupg(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_starGroupg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F13E RID: 127294 RVA: 0x00A20EA4 File Offset: 0x00A1F0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starGroupg(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			GameObject starGroupg;
			LuaObject.checkType<GameObject>(l, 2, out starGroupg);
			heroEquipItemUIController.m_luaExportHelper.m_starGroupg = starGroupg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F13F RID: 127295 RVA: 0x00A20F00 File Offset: 0x00A1F100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redMarkGo(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_redMarkGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F140 RID: 127296 RVA: 0x00A20F58 File Offset: 0x00A1F158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redMarkGo(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			GameObject redMarkGo;
			LuaObject.checkType<GameObject>(l, 2, out redMarkGo);
			heroEquipItemUIController.m_luaExportHelper.m_redMarkGo = redMarkGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F141 RID: 127297 RVA: 0x00A20FB4 File Offset: 0x00A1F1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addButton(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_addButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F142 RID: 127298 RVA: 0x00A2100C File Offset: 0x00A1F20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addButton(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Button addButton;
			LuaObject.checkType<Button>(l, 2, out addButton);
			heroEquipItemUIController.m_luaExportHelper.m_addButton = addButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F143 RID: 127299 RVA: 0x00A21068 File Offset: 0x00A1F268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_selectImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F144 RID: 127300 RVA: 0x00A210C0 File Offset: 0x00A1F2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			GameObject selectImage;
			LuaObject.checkType<GameObject>(l, 2, out selectImage);
			heroEquipItemUIController.m_luaExportHelper.m_selectImage = selectImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F145 RID: 127301 RVA: 0x00A2111C File Offset: 0x00A1F31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_runeIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_runeIconStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F146 RID: 127302 RVA: 0x00A21174 File Offset: 0x00A1F374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_runeIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController runeIconStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out runeIconStateCtrl);
			heroEquipItemUIController.m_luaExportHelper.m_runeIconStateCtrl = runeIconStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F147 RID: 127303 RVA: 0x00A211D0 File Offset: 0x00A1F3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_runeIconButton(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_runeIconButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F148 RID: 127304 RVA: 0x00A21228 File Offset: 0x00A1F428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_runeIconButton(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Button runeIconButton;
			LuaObject.checkType<Button>(l, 2, out runeIconButton);
			heroEquipItemUIController.m_luaExportHelper.m_runeIconButton = runeIconButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F149 RID: 127305 RVA: 0x00A21284 File Offset: 0x00A1F484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_runeActiveIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_runeActiveIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F14A RID: 127306 RVA: 0x00A212DC File Offset: 0x00A1F4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_runeActiveIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Image runeActiveIcon;
			LuaObject.checkType<Image>(l, 2, out runeActiveIcon);
			heroEquipItemUIController.m_luaExportHelper.m_runeActiveIcon = runeActiveIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F14B RID: 127307 RVA: 0x00A21338 File Offset: 0x00A1F538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_runeInactiveIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.m_luaExportHelper.m_runeInactiveIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F14C RID: 127308 RVA: 0x00A21390 File Offset: 0x00A1F590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_runeInactiveIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			Image runeInactiveIcon;
			LuaObject.checkType<Image>(l, 2, out runeInactiveIcon);
			heroEquipItemUIController.m_luaExportHelper.m_runeInactiveIcon = runeInactiveIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F14D RID: 127309 RVA: 0x00A213EC File Offset: 0x00A1F5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Slot(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.Slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F14E RID: 127310 RVA: 0x00A21440 File Offset: 0x00A1F640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Slot(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			heroEquipItemUIController.Slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F14F RID: 127311 RVA: 0x00A21498 File Offset: 0x00A1F698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Equipment(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroEquipItemUIController.Equipment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F150 RID: 127312 RVA: 0x00A214EC File Offset: 0x00A1F6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Equipment(IntPtr l)
	{
		int result;
		try
		{
			HeroEquipItemUIController heroEquipItemUIController = (HeroEquipItemUIController)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			heroEquipItemUIController.Equipment = equipment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F151 RID: 127313 RVA: 0x00A21544 File Offset: 0x00A1F744
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroEquipItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.InitHeroEquipmentItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.ShowSelectImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.OnIconClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.OnAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.OnRuneIconButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callDele_EventOnAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__clearDele_EventOnAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callDele_EventOnIconClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__clearDele_EventOnIconClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__callDele_EventOnRuneIconButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.__clearDele_EventOnRuneIconButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache18);
		string name = "EventOnAddButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_EventOnAddButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache19, true);
		string name2 = "EventOnIconClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_EventOnIconClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1A, true);
		string name3 = "EventOnRuneIconButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_EventOnRuneIconButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1B, true);
		string name4 = "m_iconBg";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_iconBg);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_iconBg);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1D, true);
		string name5 = "m_iconSSREffect";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_iconSSREffect);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_iconSSREffect);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache1F, true);
		string name6 = "m_iconImg";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_iconImg);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_iconImg);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache21, true);
		string name7 = "m_iconButton";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_iconButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_iconButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache23, true);
		string name8 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_nameText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache25, true);
		string name9 = "m_lvText";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_lvText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_lvText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache27, true);
		string name10 = "m_starGroupg";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_starGroupg);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_starGroupg);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache29, true);
		string name11 = "m_redMarkGo";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_redMarkGo);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_redMarkGo);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2B, true);
		string name12 = "m_addButton";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_addButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_addButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2D, true);
		string name13 = "m_selectImage";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_selectImage);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_selectImage);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache2F, true);
		string name14 = "m_runeIconStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_runeIconStateCtrl);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_runeIconStateCtrl);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache31, true);
		string name15 = "m_runeIconButton";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_runeIconButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_runeIconButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache33, true);
		string name16 = "m_runeActiveIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_runeActiveIcon);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_runeActiveIcon);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache35, true);
		string name17 = "m_runeInactiveIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_m_runeInactiveIcon);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_m_runeInactiveIcon);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache37, true);
		string name18 = "Slot";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_Slot);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_Slot);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache39, true);
		string name19 = "Equipment";
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.get_Equipment);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.set_Equipment);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.<>f__mg$cache3B, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroEquipItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015175 RID: 86389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015176 RID: 86390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015177 RID: 86391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015178 RID: 86392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015179 RID: 86393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401517A RID: 86394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401517B RID: 86395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401517C RID: 86396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401517D RID: 86397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401517E RID: 86398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401517F RID: 86399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015180 RID: 86400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015181 RID: 86401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015182 RID: 86402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015183 RID: 86403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015184 RID: 86404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015185 RID: 86405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015186 RID: 86406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015187 RID: 86407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015188 RID: 86408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015189 RID: 86409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401518A RID: 86410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401518B RID: 86411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401518C RID: 86412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401518D RID: 86413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401518E RID: 86414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401518F RID: 86415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015190 RID: 86416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015191 RID: 86417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015192 RID: 86418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015193 RID: 86419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015194 RID: 86420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015195 RID: 86421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015196 RID: 86422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015197 RID: 86423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015198 RID: 86424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015199 RID: 86425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401519A RID: 86426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401519B RID: 86427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401519C RID: 86428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401519D RID: 86429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401519E RID: 86430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401519F RID: 86431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040151A0 RID: 86432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040151A1 RID: 86433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040151A2 RID: 86434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040151A3 RID: 86435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040151A4 RID: 86436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040151A5 RID: 86437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040151A6 RID: 86438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040151A7 RID: 86439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040151A8 RID: 86440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040151A9 RID: 86441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040151AA RID: 86442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040151AB RID: 86443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040151AC RID: 86444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040151AD RID: 86445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040151AE RID: 86446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040151AF RID: 86447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040151B0 RID: 86448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;
}
