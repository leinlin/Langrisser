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

// Token: 0x0200151B RID: 5403
[Preserve]
public class Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController : LuaObject
{
	// Token: 0x060200C1 RID: 131265 RVA: 0x00A9C694 File Offset: 0x00A9A894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			ArenaBattleReport arenaBattleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out arenaBattleReport);
			offlineArenaBattleReportListItemUIController.SetArenaBattleReport(arenaBattleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200C2 RID: 131266 RVA: 0x00A9C6EC File Offset: 0x00A9A8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			ArenaBattleReport arenaBattleReport = offlineArenaBattleReportListItemUIController.GetArenaBattleReport();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200C3 RID: 131267 RVA: 0x00A9C740 File Offset: 0x00A9A940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200C4 RID: 131268 RVA: 0x00A9C794 File Offset: 0x00A9A994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRevengeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.OnRevengeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200C5 RID: 131269 RVA: 0x00A9C7E8 File Offset: 0x00A9A9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHaveRevengeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.OnHaveRevengeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200C6 RID: 131270 RVA: 0x00A9C83C File Offset: 0x00A9AA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReplayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.OnReplayButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200C7 RID: 131271 RVA: 0x00A9C890 File Offset: 0x00A9AA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200C8 RID: 131272 RVA: 0x00A9C8FC File Offset: 0x00A9AAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200C9 RID: 131273 RVA: 0x00A9C950 File Offset: 0x00A9AB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200CA RID: 131274 RVA: 0x00A9C9A4 File Offset: 0x00A9ABA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060200CB RID: 131275 RVA: 0x00A9CA4C File Offset: 0x00A9AC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200CC RID: 131276 RVA: 0x00A9CAA0 File Offset: 0x00A9ACA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200CD RID: 131277 RVA: 0x00A9CB0C File Offset: 0x00A9AD0C
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
				OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController2 = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				offlineArenaBattleReportListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060200CE RID: 131278 RVA: 0x00A9CC1C File Offset: 0x00A9AE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200CF RID: 131279 RVA: 0x00A9CC88 File Offset: 0x00A9AE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200D0 RID: 131280 RVA: 0x00A9CCF4 File Offset: 0x00A9AEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200D1 RID: 131281 RVA: 0x00A9CD60 File Offset: 0x00A9AF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200D2 RID: 131282 RVA: 0x00A9CDCC File Offset: 0x00A9AFCC
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
				OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController2 = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				offlineArenaBattleReportListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060200D3 RID: 131283 RVA: 0x00A9CEDC File Offset: 0x00A9B0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string s = offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060200D4 RID: 131284 RVA: 0x00A9CF38 File Offset: 0x00A9B138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRevengeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			OfflineArenaBattleReportListItemUIController obj;
			LuaObject.checkType<OfflineArenaBattleReportListItemUIController>(l, 2, out obj);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callDele_EventOnRevengeButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200D5 RID: 131285 RVA: 0x00A9CF94 File Offset: 0x00A9B194
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnRevengeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			OfflineArenaBattleReportListItemUIController obj;
			LuaObject.checkType<OfflineArenaBattleReportListItemUIController>(l, 2, out obj);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__clearDele_EventOnRevengeButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200D6 RID: 131286 RVA: 0x00A9CFF0 File Offset: 0x00A9B1F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReplayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			OfflineArenaBattleReportListItemUIController obj;
			LuaObject.checkType<OfflineArenaBattleReportListItemUIController>(l, 2, out obj);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__callDele_EventOnReplayButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200D7 RID: 131287 RVA: 0x00A9D04C File Offset: 0x00A9B24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReplayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			OfflineArenaBattleReportListItemUIController obj;
			LuaObject.checkType<OfflineArenaBattleReportListItemUIController>(l, 2, out obj);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.__clearDele_EventOnReplayButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200D8 RID: 131288 RVA: 0x00A9D0A8 File Offset: 0x00A9B2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRevengeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Action<OfflineArenaBattleReportListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<OfflineArenaBattleReportListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					offlineArenaBattleReportListItemUIController.EventOnRevengeButtonClick += value;
				}
				else if (num == 2)
				{
					offlineArenaBattleReportListItemUIController.EventOnRevengeButtonClick -= value;
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

	// Token: 0x060200D9 RID: 131289 RVA: 0x00A9D128 File Offset: 0x00A9B328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReplayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Action<OfflineArenaBattleReportListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<OfflineArenaBattleReportListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					offlineArenaBattleReportListItemUIController.EventOnReplayButtonClick += value;
				}
				else if (num == 2)
				{
					offlineArenaBattleReportListItemUIController.EventOnReplayButtonClick -= value;
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

	// Token: 0x060200DA RID: 131290 RVA: 0x00A9D1A8 File Offset: 0x00A9B3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200DB RID: 131291 RVA: 0x00A9D200 File Offset: 0x00A9B400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Image playerIconImage;
			LuaObject.checkType<Image>(l, 2, out playerIconImage);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerIconImage = playerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200DC RID: 131292 RVA: 0x00A9D25C File Offset: 0x00A9B45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200DD RID: 131293 RVA: 0x00A9D2B4 File Offset: 0x00A9B4B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200DE RID: 131294 RVA: 0x00A9D310 File Offset: 0x00A9B510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200DF RID: 131295 RVA: 0x00A9D368 File Offset: 0x00A9B568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200E0 RID: 131296 RVA: 0x00A9D3C4 File Offset: 0x00A9B5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_modeUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_modeUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200E1 RID: 131297 RVA: 0x00A9D41C File Offset: 0x00A9B61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_modeUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController modeUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out modeUIStateCtrl);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_modeUIStateCtrl = modeUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200E2 RID: 131298 RVA: 0x00A9D478 File Offset: 0x00A9B678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_timeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200E3 RID: 131299 RVA: 0x00A9D4D0 File Offset: 0x00A9B6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Text timeText;
			LuaObject.checkType<Text>(l, 2, out timeText);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_timeText = timeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200E4 RID: 131300 RVA: 0x00A9D52C File Offset: 0x00A9B72C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_arenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_arenaPointsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200E5 RID: 131301 RVA: 0x00A9D584 File Offset: 0x00A9B784
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_arenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Text arenaPointsText;
			LuaObject.checkType<Text>(l, 2, out arenaPointsText);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_arenaPointsText = arenaPointsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200E6 RID: 131302 RVA: 0x00A9D5E0 File Offset: 0x00A9B7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_revengeButton(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_revengeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200E7 RID: 131303 RVA: 0x00A9D638 File Offset: 0x00A9B838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_revengeButton(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Button revengeButton;
			LuaObject.checkType<Button>(l, 2, out revengeButton);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_revengeButton = revengeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200E8 RID: 131304 RVA: 0x00A9D694 File Offset: 0x00A9B894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_haveRevengeButton(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_haveRevengeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200E9 RID: 131305 RVA: 0x00A9D6EC File Offset: 0x00A9B8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_haveRevengeButton(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Button haveRevengeButton;
			LuaObject.checkType<Button>(l, 2, out haveRevengeButton);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_haveRevengeButton = haveRevengeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200EA RID: 131306 RVA: 0x00A9D748 File Offset: 0x00A9B948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_replayButton(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_replayButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200EB RID: 131307 RVA: 0x00A9D7A0 File Offset: 0x00A9B9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_replayButton(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Button replayButton;
			LuaObject.checkType<Button>(l, 2, out replayButton);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_replayButton = replayButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200EC RID: 131308 RVA: 0x00A9D7FC File Offset: 0x00A9B9FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleReport(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_battleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200ED RID: 131309 RVA: 0x00A9D854 File Offset: 0x00A9BA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleReport(IntPtr l)
	{
		int result;
		try
		{
			OfflineArenaBattleReportListItemUIController offlineArenaBattleReportListItemUIController = (OfflineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			ArenaBattleReport battleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out battleReport);
			offlineArenaBattleReportListItemUIController.m_luaExportHelper.m_battleReport = battleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200EE RID: 131310 RVA: 0x00A9D8B0 File Offset: 0x00A9BAB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.OfflineArenaBattleReportListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.SetArenaBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.GetArenaBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.OnRevengeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.OnHaveRevengeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.OnReplayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callDele_EventOnRevengeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__clearDele_EventOnRevengeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__callDele_EventOnReplayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.__clearDele_EventOnReplayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache16);
		string name = "EventOnRevengeButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_EventOnRevengeButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache17, true);
		string name2 = "EventOnReplayButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_EventOnReplayButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache18, true);
		string name3 = "m_playerIconImage";
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.get_m_playerIconImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_m_playerIconImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1A, true);
		string name4 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.get_m_playerNameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1C, true);
		string name5 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.get_m_playerLevelText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1E, true);
		string name6 = "m_modeUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.get_m_modeUIStateCtrl);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_m_modeUIStateCtrl);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache20, true);
		string name7 = "m_timeText";
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.get_m_timeText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_m_timeText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache22, true);
		string name8 = "m_arenaPointsText";
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.get_m_arenaPointsText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_m_arenaPointsText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache24, true);
		string name9 = "m_revengeButton";
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.get_m_revengeButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_m_revengeButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache26, true);
		string name10 = "m_haveRevengeButton";
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.get_m_haveRevengeButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_m_haveRevengeButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache28, true);
		string name11 = "m_replayButton";
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.get_m_replayButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_m_replayButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2A, true);
		string name12 = "m_battleReport";
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.get_m_battleReport);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.set_m_battleReport);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.<>f__mg$cache2C, true);
		LuaObject.createTypeMetatable(l, null, typeof(OfflineArenaBattleReportListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401606D RID: 90221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401606E RID: 90222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401606F RID: 90223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016070 RID: 90224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016071 RID: 90225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016072 RID: 90226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016073 RID: 90227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016074 RID: 90228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016075 RID: 90229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016076 RID: 90230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016077 RID: 90231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016078 RID: 90232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016079 RID: 90233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401607A RID: 90234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401607B RID: 90235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401607C RID: 90236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401607D RID: 90237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401607E RID: 90238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401607F RID: 90239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016080 RID: 90240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016081 RID: 90241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016082 RID: 90242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016083 RID: 90243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016084 RID: 90244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016085 RID: 90245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016086 RID: 90246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016087 RID: 90247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016088 RID: 90248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016089 RID: 90249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401608A RID: 90250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401608B RID: 90251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401608C RID: 90252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401608D RID: 90253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401608E RID: 90254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401608F RID: 90255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016090 RID: 90256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016091 RID: 90257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016092 RID: 90258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016093 RID: 90259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016094 RID: 90260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016095 RID: 90261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016096 RID: 90262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016097 RID: 90263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016098 RID: 90264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016099 RID: 90265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;
}
