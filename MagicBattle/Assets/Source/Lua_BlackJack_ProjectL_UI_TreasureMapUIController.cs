using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015BD RID: 5565
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TreasureMapUIController : LuaObject
{
	// Token: 0x06021D0B RID: 138507 RVA: 0x00B7EB90 File Offset: 0x00B7CD90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D0C RID: 138508 RVA: 0x00B7EBDC File Offset: 0x00B7CDDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTicketCount(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			int haveCount;
			LuaObject.checkType(l, 2, out haveCount);
			int allCount;
			LuaObject.checkType(l, 3, out allCount);
			treasureMapUIController.SetTicketCount(haveCount, allCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D0D RID: 138509 RVA: 0x00B7EC40 File Offset: 0x00B7CE40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddTreasureLevelButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo levelnfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out levelnfo);
			bool opened;
			LuaObject.checkType(l, 3, out opened);
			treasureMapUIController.AddTreasureLevelButton(levelnfo, opened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D0E RID: 138510 RVA: 0x00B7ECA4 File Offset: 0x00B7CEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearTreasureLevelButtons(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.ClearTreasureLevelButtons();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D0F RID: 138511 RVA: 0x00B7ECF0 File Offset: 0x00B7CEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D10 RID: 138512 RVA: 0x00B7ED44 File Offset: 0x00B7CF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D11 RID: 138513 RVA: 0x00B7ED98 File Offset: 0x00B7CF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D12 RID: 138514 RVA: 0x00B7EDEC File Offset: 0x00B7CFEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D13 RID: 138515 RVA: 0x00B7EE40 File Offset: 0x00B7D040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnAddTicketButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.OnAddTicketButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D14 RID: 138516 RVA: 0x00B7EE94 File Offset: 0x00B7D094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ThreasureLevelListItem_OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			TreasureLevelListItemUIController ctrl;
			LuaObject.checkType<TreasureLevelListItemUIController>(l, 2, out ctrl);
			treasureMapUIController.m_luaExportHelper.ThreasureLevelListItem_OnStartButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D15 RID: 138517 RVA: 0x00B7EEF0 File Offset: 0x00B7D0F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			treasureMapUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D16 RID: 138518 RVA: 0x00B7EF5C File Offset: 0x00B7D15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D17 RID: 138519 RVA: 0x00B7EFB0 File Offset: 0x00B7D1B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D18 RID: 138520 RVA: 0x00B7F004 File Offset: 0x00B7D204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = treasureMapUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021D19 RID: 138521 RVA: 0x00B7F0AC File Offset: 0x00B7D2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D1A RID: 138522 RVA: 0x00B7F100 File Offset: 0x00B7D300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			treasureMapUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D1B RID: 138523 RVA: 0x00B7F16C File Offset: 0x00B7D36C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				treasureMapUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TreasureMapUIController treasureMapUIController2 = (TreasureMapUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				treasureMapUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021D1C RID: 138524 RVA: 0x00B7F27C File Offset: 0x00B7D47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			treasureMapUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D1D RID: 138525 RVA: 0x00B7F2E8 File Offset: 0x00B7D4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			treasureMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D1E RID: 138526 RVA: 0x00B7F354 File Offset: 0x00B7D554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			treasureMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D1F RID: 138527 RVA: 0x00B7F3C0 File Offset: 0x00B7D5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			treasureMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D20 RID: 138528 RVA: 0x00B7F42C File Offset: 0x00B7D62C
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
				TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				treasureMapUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TreasureMapUIController treasureMapUIController2 = (TreasureMapUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				treasureMapUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021D21 RID: 138529 RVA: 0x00B7F53C File Offset: 0x00B7D73C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			string s = treasureMapUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021D22 RID: 138530 RVA: 0x00B7F598 File Offset: 0x00B7D798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D23 RID: 138531 RVA: 0x00B7F5EC File Offset: 0x00B7D7EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D24 RID: 138532 RVA: 0x00B7F640 File Offset: 0x00B7D840
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D25 RID: 138533 RVA: 0x00B7F694 File Offset: 0x00B7D894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D26 RID: 138534 RVA: 0x00B7F6E8 File Offset: 0x00B7D8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.__callDele_EventOnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D27 RID: 138535 RVA: 0x00B7F73C File Offset: 0x00B7D93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			treasureMapUIController.m_luaExportHelper.__clearDele_EventOnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D28 RID: 138536 RVA: 0x00B7F790 File Offset: 0x00B7D990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartTreasureLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo obj;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out obj);
			treasureMapUIController.m_luaExportHelper.__callDele_EventOnStartTreasureLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D29 RID: 138537 RVA: 0x00B7F7EC File Offset: 0x00B7D9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartTreasureLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo obj;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out obj);
			treasureMapUIController.m_luaExportHelper.__clearDele_EventOnStartTreasureLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D2A RID: 138538 RVA: 0x00B7F848 File Offset: 0x00B7DA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					treasureMapUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					treasureMapUIController.EventOnReturn -= value;
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

	// Token: 0x06021D2B RID: 138539 RVA: 0x00B7F8C8 File Offset: 0x00B7DAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					treasureMapUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					treasureMapUIController.EventOnShowHelp -= value;
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

	// Token: 0x06021D2C RID: 138540 RVA: 0x00B7F948 File Offset: 0x00B7DB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					treasureMapUIController.EventOnAddTicket += value;
				}
				else if (num == 2)
				{
					treasureMapUIController.EventOnAddTicket -= value;
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

	// Token: 0x06021D2D RID: 138541 RVA: 0x00B7F9C8 File Offset: 0x00B7DBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartTreasureLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			Action<ConfigDataTreasureLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataTreasureLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					treasureMapUIController.EventOnStartTreasureLevel += value;
				}
				else if (num == 2)
				{
					treasureMapUIController.EventOnStartTreasureLevel -= value;
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

	// Token: 0x06021D2E RID: 138542 RVA: 0x00B7FA48 File Offset: 0x00B7DC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D2F RID: 138543 RVA: 0x00B7FAA0 File Offset: 0x00B7DCA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			treasureMapUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D30 RID: 138544 RVA: 0x00B7FAFC File Offset: 0x00B7DCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D31 RID: 138545 RVA: 0x00B7FB54 File Offset: 0x00B7DD54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			treasureMapUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D32 RID: 138546 RVA: 0x00B7FBB0 File Offset: 0x00B7DDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D33 RID: 138547 RVA: 0x00B7FC08 File Offset: 0x00B7DE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			treasureMapUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D34 RID: 138548 RVA: 0x00B7FC64 File Offset: 0x00B7DE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ticketText(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_ticketText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D35 RID: 138549 RVA: 0x00B7FCBC File Offset: 0x00B7DEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ticketText(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			Text ticketText;
			LuaObject.checkType<Text>(l, 2, out ticketText);
			treasureMapUIController.m_luaExportHelper.m_ticketText = ticketText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D36 RID: 138550 RVA: 0x00B7FD18 File Offset: 0x00B7DF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addTicketButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_addTicketButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D37 RID: 138551 RVA: 0x00B7FD70 File Offset: 0x00B7DF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addTicketButton(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			Button addTicketButton;
			LuaObject.checkType<Button>(l, 2, out addTicketButton);
			treasureMapUIController.m_luaExportHelper.m_addTicketButton = addTicketButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D38 RID: 138552 RVA: 0x00B7FDCC File Offset: 0x00B7DFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_levelListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D39 RID: 138553 RVA: 0x00B7FE24 File Offset: 0x00B7E024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			ScrollRect levelListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out levelListScrollRect);
			treasureMapUIController.m_luaExportHelper.m_levelListScrollRect = levelListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D3A RID: 138554 RVA: 0x00B7FE80 File Offset: 0x00B7E080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char0GameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_char0GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D3B RID: 138555 RVA: 0x00B7FED8 File Offset: 0x00B7E0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char0GameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			GameObject char0GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char0GameObject);
			treasureMapUIController.m_luaExportHelper.m_char0GameObject = char0GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D3C RID: 138556 RVA: 0x00B7FF34 File Offset: 0x00B7E134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char1GameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_char1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D3D RID: 138557 RVA: 0x00B7FF8C File Offset: 0x00B7E18C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_char1GameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			GameObject char1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char1GameObject);
			treasureMapUIController.m_luaExportHelper.m_char1GameObject = char1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D3E RID: 138558 RVA: 0x00B7FFE8 File Offset: 0x00B7E1E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_char2GameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_char2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D3F RID: 138559 RVA: 0x00B80040 File Offset: 0x00B7E240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_char2GameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			GameObject char2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char2GameObject);
			treasureMapUIController.m_luaExportHelper.m_char2GameObject = char2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D40 RID: 138560 RVA: 0x00B8009C File Offset: 0x00B7E29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_char3GameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_char3GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D41 RID: 138561 RVA: 0x00B800F4 File Offset: 0x00B7E2F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_char3GameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			GameObject char3GameObject;
			LuaObject.checkType<GameObject>(l, 2, out char3GameObject);
			treasureMapUIController.m_luaExportHelper.m_char3GameObject = char3GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D42 RID: 138562 RVA: 0x00B80150 File Offset: 0x00B7E350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D43 RID: 138563 RVA: 0x00B801A8 File Offset: 0x00B7E3A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			treasureMapUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D44 RID: 138564 RVA: 0x00B80204 File Offset: 0x00B7E404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasureLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_treasureLevelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D45 RID: 138565 RVA: 0x00B8025C File Offset: 0x00B7E45C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_treasureLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			GameObject treasureLevelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out treasureLevelListItemPrefab);
			treasureMapUIController.m_luaExportHelper.m_treasureLevelListItemPrefab = treasureLevelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D46 RID: 138566 RVA: 0x00B802B8 File Offset: 0x00B7E4B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_treasureLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_treasureLevelListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D47 RID: 138567 RVA: 0x00B80310 File Offset: 0x00B7E510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasureLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			List<TreasureLevelListItemUIController> treasureLevelListItems;
			LuaObject.checkType<List<TreasureLevelListItemUIController>>(l, 2, out treasureLevelListItems);
			treasureMapUIController.m_luaExportHelper.m_treasureLevelListItems = treasureLevelListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D48 RID: 138568 RVA: 0x00B8036C File Offset: 0x00B7E56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actors(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapUIController.m_luaExportHelper.m_actors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D49 RID: 138569 RVA: 0x00B803C4 File Offset: 0x00B7E5C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_actors(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapUIController treasureMapUIController = (TreasureMapUIController)LuaObject.checkSelf(l);
			TreasureMapBackgroundActor[] actors;
			LuaObject.checkArray<TreasureMapBackgroundActor>(l, 2, out actors);
			treasureMapUIController.m_luaExportHelper.m_actors = actors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D4A RID: 138570 RVA: 0x00B80420 File Offset: 0x00B7E620
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TreasureMapUIController");
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.SetTicketCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.AddTreasureLevelButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.ClearTreasureLevelButtons);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.OnAddTicketButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.ThreasureLevelListItem_OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callDele_EventOnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__clearDele_EventOnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__callDele_EventOnStartTreasureLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.__clearDele_EventOnStartTreasureLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1E);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache1F, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache20, true);
		string name3 = "EventOnAddTicket";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_EventOnAddTicket);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache21, true);
		string name4 = "EventOnStartTreasureLevel";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_EventOnStartTreasureLevel);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache22, true);
		string name5 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_uiStateController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache24, true);
		string name6 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_returnButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache26, true);
		string name7 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_helpButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache28, true);
		string name8 = "m_ticketText";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_ticketText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_ticketText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2A, true);
		string name9 = "m_addTicketButton";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_addTicketButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_addTicketButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2C, true);
		string name10 = "m_levelListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_levelListScrollRect);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_levelListScrollRect);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2E, true);
		string name11 = "m_char0GameObject";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_char0GameObject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_char0GameObject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache30, true);
		string name12 = "m_char1GameObject";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_char1GameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_char1GameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache32, true);
		string name13 = "m_char2GameObject";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_char2GameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_char2GameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache34, true);
		string name14 = "m_char3GameObject";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_char3GameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_char3GameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache36, true);
		string name15 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache38, true);
		string name16 = "m_treasureLevelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_treasureLevelListItemPrefab);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_treasureLevelListItemPrefab);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3A, true);
		string name17 = "m_treasureLevelListItems";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_treasureLevelListItems);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_treasureLevelListItems);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3C, true);
		string name18 = "m_actors";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.get_m_actors);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.set_m_actors);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_TreasureMapUIController.<>f__mg$cache3E, true);
		LuaObject.createTypeMetatable(l, null, typeof(TreasureMapUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017B73 RID: 97139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017B74 RID: 97140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017B75 RID: 97141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017B76 RID: 97142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017B77 RID: 97143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017B78 RID: 97144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017B79 RID: 97145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017B7A RID: 97146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017B7B RID: 97147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017B7C RID: 97148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017B7D RID: 97149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017B7E RID: 97150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017B7F RID: 97151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017B80 RID: 97152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017B81 RID: 97153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017B82 RID: 97154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017B83 RID: 97155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017B84 RID: 97156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017B85 RID: 97157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017B86 RID: 97158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017B87 RID: 97159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017B88 RID: 97160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017B89 RID: 97161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017B8A RID: 97162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017B8B RID: 97163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017B8C RID: 97164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017B8D RID: 97165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017B8E RID: 97166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017B8F RID: 97167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017B90 RID: 97168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017B91 RID: 97169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017B92 RID: 97170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017B93 RID: 97171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017B94 RID: 97172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017B95 RID: 97173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017B96 RID: 97174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017B97 RID: 97175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017B98 RID: 97176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017B99 RID: 97177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017B9A RID: 97178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017B9B RID: 97179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017B9C RID: 97180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017B9D RID: 97181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017B9E RID: 97182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017B9F RID: 97183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017BA0 RID: 97184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017BA1 RID: 97185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017BA2 RID: 97186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017BA3 RID: 97187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017BA4 RID: 97188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017BA5 RID: 97189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017BA6 RID: 97190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017BA7 RID: 97191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017BA8 RID: 97192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017BA9 RID: 97193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017BAA RID: 97194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017BAB RID: 97195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017BAC RID: 97196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017BAD RID: 97197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017BAE RID: 97198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017BAF RID: 97199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017BB0 RID: 97200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017BB1 RID: 97201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;
}
