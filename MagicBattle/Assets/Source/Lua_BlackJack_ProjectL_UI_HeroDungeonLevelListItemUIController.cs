using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014BC RID: 5308
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController : LuaObject
{
	// Token: 0x0601F025 RID: 127013 RVA: 0x00A18698 File Offset: 0x00A16898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDungeonInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo dungeonInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out dungeonInfo);
			heroDungeonLevelListItemUIController.SetDungeonInfo(dungeonInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F026 RID: 127014 RVA: 0x00A186F0 File Offset: 0x00A168F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDungeonInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo dungeonInfo = heroDungeonLevelListItemUIController.GetDungeonInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dungeonInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F027 RID: 127015 RVA: 0x00A18744 File Offset: 0x00A16944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			heroDungeonLevelListItemUIController.SetIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F028 RID: 127016 RVA: 0x00A1879C File Offset: 0x00A1699C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			int index = heroDungeonLevelListItemUIController.GetIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F029 RID: 127017 RVA: 0x00A187F0 File Offset: 0x00A169F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFavorLevelLock(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			bool b = heroDungeonLevelListItemUIController.IsFavorLevelLock();
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

	// Token: 0x0601F02A RID: 127018 RVA: 0x00A18844 File Offset: 0x00A16A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPreLevelLock(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			bool b = heroDungeonLevelListItemUIController.IsPreLevelLock();
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

	// Token: 0x0601F02B RID: 127019 RVA: 0x00A18898 File Offset: 0x00A16A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			heroDungeonLevelListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F02C RID: 127020 RVA: 0x00A188EC File Offset: 0x00A16AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			heroDungeonLevelListItemUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F02D RID: 127021 RVA: 0x00A18940 File Offset: 0x00A16B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F02E RID: 127022 RVA: 0x00A189AC File Offset: 0x00A16BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F02F RID: 127023 RVA: 0x00A18A00 File Offset: 0x00A16C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F030 RID: 127024 RVA: 0x00A18A54 File Offset: 0x00A16C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F031 RID: 127025 RVA: 0x00A18AFC File Offset: 0x00A16CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F032 RID: 127026 RVA: 0x00A18B50 File Offset: 0x00A16D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F033 RID: 127027 RVA: 0x00A18BBC File Offset: 0x00A16DBC
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
				HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController2 = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDungeonLevelListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F034 RID: 127028 RVA: 0x00A18CCC File Offset: 0x00A16ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F035 RID: 127029 RVA: 0x00A18D38 File Offset: 0x00A16F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F036 RID: 127030 RVA: 0x00A18DA4 File Offset: 0x00A16FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F037 RID: 127031 RVA: 0x00A18E10 File Offset: 0x00A17010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F038 RID: 127032 RVA: 0x00A18E7C File Offset: 0x00A1707C
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
				HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController2 = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDungeonLevelListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F039 RID: 127033 RVA: 0x00A18F8C File Offset: 0x00A1718C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			string s = heroDungeonLevelListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F03A RID: 127034 RVA: 0x00A18FE8 File Offset: 0x00A171E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			HeroDungeonLevelListItemUIController obj;
			LuaObject.checkType<HeroDungeonLevelListItemUIController>(l, 2, out obj);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F03B RID: 127035 RVA: 0x00A19044 File Offset: 0x00A17244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			HeroDungeonLevelListItemUIController obj;
			LuaObject.checkType<HeroDungeonLevelListItemUIController>(l, 2, out obj);
			heroDungeonLevelListItemUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F03C RID: 127036 RVA: 0x00A190A0 File Offset: 0x00A172A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			Action<HeroDungeonLevelListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroDungeonLevelListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDungeonLevelListItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					heroDungeonLevelListItemUIController.EventOnClick -= value;
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

	// Token: 0x0601F03D RID: 127037 RVA: 0x00A19120 File Offset: 0x00A17320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F03E RID: 127038 RVA: 0x00A19178 File Offset: 0x00A17378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F03F RID: 127039 RVA: 0x00A191D4 File Offset: 0x00A173D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F040 RID: 127040 RVA: 0x00A1922C File Offset: 0x00A1742C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F041 RID: 127041 RVA: 0x00A19288 File Offset: 0x00A17488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F042 RID: 127042 RVA: 0x00A192E0 File Offset: 0x00A174E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F043 RID: 127043 RVA: 0x00A1933C File Offset: 0x00A1753C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star1GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_star1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F044 RID: 127044 RVA: 0x00A19394 File Offset: 0x00A17594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star1GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject star1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out star1GameObject);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_star1GameObject = star1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F045 RID: 127045 RVA: 0x00A193F0 File Offset: 0x00A175F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star2GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_star2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F046 RID: 127046 RVA: 0x00A19448 File Offset: 0x00A17648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star2GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject star2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out star2GameObject);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_star2GameObject = star2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F047 RID: 127047 RVA: 0x00A194A4 File Offset: 0x00A176A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star3GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_star3GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F048 RID: 127048 RVA: 0x00A194FC File Offset: 0x00A176FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star3GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject star3GameObject;
			LuaObject.checkType<GameObject>(l, 2, out star3GameObject);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_star3GameObject = star3GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F049 RID: 127049 RVA: 0x00A19558 File Offset: 0x00A17758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trophyGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_trophyGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F04A RID: 127050 RVA: 0x00A195B0 File Offset: 0x00A177B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trophyGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject trophyGameObject;
			LuaObject.checkType<GameObject>(l, 2, out trophyGameObject);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_trophyGameObject = trophyGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F04B RID: 127051 RVA: 0x00A1960C File Offset: 0x00A1780C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trophyValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_trophyValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F04C RID: 127052 RVA: 0x00A19664 File Offset: 0x00A17864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trophyValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			Text trophyValueText;
			LuaObject.checkType<Text>(l, 2, out trophyValueText);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_trophyValueText = trophyValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F04D RID: 127053 RVA: 0x00A196C0 File Offset: 0x00A178C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_favorLevelNotEnoughText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_favorLevelNotEnoughText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F04E RID: 127054 RVA: 0x00A19718 File Offset: 0x00A17918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_favorLevelNotEnoughText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			Text favorLevelNotEnoughText;
			LuaObject.checkType<Text>(l, 2, out favorLevelNotEnoughText);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_favorLevelNotEnoughText = favorLevelNotEnoughText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F04F RID: 127055 RVA: 0x00A19774 File Offset: 0x00A17974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_preLevelNotCompleteText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_preLevelNotCompleteText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F050 RID: 127056 RVA: 0x00A197CC File Offset: 0x00A179CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_preLevelNotCompleteText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			Text preLevelNotCompleteText;
			LuaObject.checkType<Text>(l, 2, out preLevelNotCompleteText);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_preLevelNotCompleteText = preLevelNotCompleteText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F051 RID: 127057 RVA: 0x00A19828 File Offset: 0x00A17A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pieceImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_pieceImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F052 RID: 127058 RVA: 0x00A19880 File Offset: 0x00A17A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pieceImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			Image pieceImage;
			LuaObject.checkType<Image>(l, 2, out pieceImage);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_pieceImage = pieceImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F053 RID: 127059 RVA: 0x00A198DC File Offset: 0x00A17ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastCountValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_lastCountValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F054 RID: 127060 RVA: 0x00A19934 File Offset: 0x00A17B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastCountValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			Text lastCountValueText;
			LuaObject.checkType<Text>(l, 2, out lastCountValueText);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_lastCountValueText = lastCountValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F055 RID: 127061 RVA: 0x00A19990 File Offset: 0x00A17B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_levelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F056 RID: 127062 RVA: 0x00A199E8 File Offset: 0x00A17BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_levelInfo = levelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F057 RID: 127063 RVA: 0x00A19A44 File Offset: 0x00A17C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F058 RID: 127064 RVA: 0x00A19A9C File Offset: 0x00A17C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F059 RID: 127065 RVA: 0x00A19AF8 File Offset: 0x00A17CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F05A RID: 127066 RVA: 0x00A19B50 File Offset: 0x00A17D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F05B RID: 127067 RVA: 0x00A19BAC File Offset: 0x00A17DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelListItemUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F05C RID: 127068 RVA: 0x00A19C04 File Offset: 0x00A17E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelListItemUIController heroDungeonLevelListItemUIController = (HeroDungeonLevelListItemUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDungeonLevelListItemUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F05D RID: 127069 RVA: 0x00A19C60 File Offset: 0x00A17E60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDungeonLevelListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.SetDungeonInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.GetDungeonInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.SetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.GetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.IsFavorLevelLock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.IsPreLevelLock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache16);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache17, true);
		string name2 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_button);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache19, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1B, true);
		string name4 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_nameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1D, true);
		string name5 = "m_star1GameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_star1GameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_star1GameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache1F, true);
		string name6 = "m_star2GameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_star2GameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_star2GameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache21, true);
		string name7 = "m_star3GameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_star3GameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_star3GameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache23, true);
		string name8 = "m_trophyGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_trophyGameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_trophyGameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache25, true);
		string name9 = "m_trophyValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_trophyValueText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_trophyValueText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache27, true);
		string name10 = "m_favorLevelNotEnoughText";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_favorLevelNotEnoughText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_favorLevelNotEnoughText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache29, true);
		string name11 = "m_preLevelNotCompleteText";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_preLevelNotCompleteText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_preLevelNotCompleteText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2B, true);
		string name12 = "m_pieceImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_pieceImage);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_pieceImage);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2D, true);
		string name13 = "m_lastCountValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_lastCountValueText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_lastCountValueText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache2F, true);
		string name14 = "m_levelInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_levelInfo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_levelInfo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache31, true);
		string name15 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_index);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_index);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache33, true);
		string name16 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_playerContext);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache35, true);
		string name17 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.get_m_configDataLoader);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.<>f__mg$cache37, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDungeonLevelListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401508F RID: 86159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015090 RID: 86160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015091 RID: 86161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015092 RID: 86162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015093 RID: 86163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015094 RID: 86164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015095 RID: 86165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015096 RID: 86166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015097 RID: 86167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015098 RID: 86168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015099 RID: 86169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401509A RID: 86170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401509B RID: 86171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401509C RID: 86172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401509D RID: 86173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401509E RID: 86174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401509F RID: 86175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040150A0 RID: 86176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040150A1 RID: 86177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040150A2 RID: 86178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040150A3 RID: 86179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040150A4 RID: 86180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040150A5 RID: 86181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040150A6 RID: 86182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040150A7 RID: 86183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040150A8 RID: 86184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040150A9 RID: 86185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040150AA RID: 86186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040150AB RID: 86187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040150AC RID: 86188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040150AD RID: 86189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040150AE RID: 86190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040150AF RID: 86191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040150B0 RID: 86192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040150B1 RID: 86193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040150B2 RID: 86194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040150B3 RID: 86195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040150B4 RID: 86196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040150B5 RID: 86197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040150B6 RID: 86198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040150B7 RID: 86199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040150B8 RID: 86200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040150B9 RID: 86201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040150BA RID: 86202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040150BB RID: 86203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040150BC RID: 86204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040150BD RID: 86205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040150BE RID: 86206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040150BF RID: 86207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040150C0 RID: 86208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040150C1 RID: 86209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040150C2 RID: 86210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040150C3 RID: 86211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040150C4 RID: 86212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040150C5 RID: 86213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040150C6 RID: 86214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
