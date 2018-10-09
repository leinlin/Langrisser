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

// Token: 0x0200151D RID: 5405
[Preserve]
public class Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController : LuaObject
{
	// Token: 0x06020123 RID: 131363 RVA: 0x00A9F7F8 File Offset: 0x00A9D9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRealTimePVPBattleReport(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			RealTimePVPBattleReport realTimePVPBattleReport;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out realTimePVPBattleReport);
			onlineArenaBattleReportListItemUIController.SetRealTimePVPBattleReport(realTimePVPBattleReport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020124 RID: 131364 RVA: 0x00A9F850 File Offset: 0x00A9DA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRealTimePVPBattleReport(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			RealTimePVPBattleReport realTimePVPBattleReport = onlineArenaBattleReportListItemUIController.GetRealTimePVPBattleReport();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020125 RID: 131365 RVA: 0x00A9F8A4 File Offset: 0x00A9DAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020126 RID: 131366 RVA: 0x00A9F8F8 File Offset: 0x00A9DAF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReplayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.OnReplayButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020127 RID: 131367 RVA: 0x00A9F94C File Offset: 0x00A9DB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020128 RID: 131368 RVA: 0x00A9F9B8 File Offset: 0x00A9DBB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020129 RID: 131369 RVA: 0x00A9FA0C File Offset: 0x00A9DC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602012A RID: 131370 RVA: 0x00A9FA60 File Offset: 0x00A9DC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602012B RID: 131371 RVA: 0x00A9FB08 File Offset: 0x00A9DD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602012C RID: 131372 RVA: 0x00A9FB5C File Offset: 0x00A9DD5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602012D RID: 131373 RVA: 0x00A9FBC8 File Offset: 0x00A9DDC8
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
				OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController2 = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				onlineArenaBattleReportListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602012E RID: 131374 RVA: 0x00A9FCD8 File Offset: 0x00A9DED8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602012F RID: 131375 RVA: 0x00A9FD44 File Offset: 0x00A9DF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020130 RID: 131376 RVA: 0x00A9FDB0 File Offset: 0x00A9DFB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020131 RID: 131377 RVA: 0x00A9FE1C File Offset: 0x00A9E01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020132 RID: 131378 RVA: 0x00A9FE88 File Offset: 0x00A9E088
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController2 = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				onlineArenaBattleReportListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020133 RID: 131379 RVA: 0x00A9FF98 File Offset: 0x00A9E198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			string s = onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020134 RID: 131380 RVA: 0x00A9FFF4 File Offset: 0x00A9E1F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReplayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			OnlineArenaBattleReportListItemUIController obj;
			LuaObject.checkType<OnlineArenaBattleReportListItemUIController>(l, 2, out obj);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__callDele_EventOnReplayButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020135 RID: 131381 RVA: 0x00AA0050 File Offset: 0x00A9E250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReplayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			OnlineArenaBattleReportListItemUIController obj;
			LuaObject.checkType<OnlineArenaBattleReportListItemUIController>(l, 2, out obj);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.__clearDele_EventOnReplayButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020136 RID: 131382 RVA: 0x00AA00AC File Offset: 0x00A9E2AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnReplayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Action<OnlineArenaBattleReportListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<OnlineArenaBattleReportListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					onlineArenaBattleReportListItemUIController.EventOnReplayButtonClick += value;
				}
				else if (num == 2)
				{
					onlineArenaBattleReportListItemUIController.EventOnReplayButtonClick -= value;
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

	// Token: 0x06020137 RID: 131383 RVA: 0x00AA012C File Offset: 0x00A9E32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020138 RID: 131384 RVA: 0x00AA0184 File Offset: 0x00A9E384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Image playerIconImage;
			LuaObject.checkType<Image>(l, 2, out playerIconImage);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerIconImage = playerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020139 RID: 131385 RVA: 0x00AA01E0 File Offset: 0x00A9E3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602013A RID: 131386 RVA: 0x00AA0238 File Offset: 0x00A9E438
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602013B RID: 131387 RVA: 0x00AA0294 File Offset: 0x00A9E494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602013C RID: 131388 RVA: 0x00AA02EC File Offset: 0x00A9E4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602013D RID: 131389 RVA: 0x00AA0348 File Offset: 0x00A9E548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_modeUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_modeUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602013E RID: 131390 RVA: 0x00AA03A0 File Offset: 0x00A9E5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_modeUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController modeUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out modeUIStateCtrl);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_modeUIStateCtrl = modeUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602013F RID: 131391 RVA: 0x00AA03FC File Offset: 0x00A9E5FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_typeUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_typeUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020140 RID: 131392 RVA: 0x00AA0454 File Offset: 0x00A9E654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_typeUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController typeUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out typeUIStateCtrl);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_typeUIStateCtrl = typeUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020141 RID: 131393 RVA: 0x00AA04B0 File Offset: 0x00A9E6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_timeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020142 RID: 131394 RVA: 0x00AA0508 File Offset: 0x00A9E708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Text timeText;
			LuaObject.checkType<Text>(l, 2, out timeText);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_timeText = timeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020143 RID: 131395 RVA: 0x00AA0564 File Offset: 0x00A9E764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreText(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_scoreText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020144 RID: 131396 RVA: 0x00AA05BC File Offset: 0x00A9E7BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_scoreText(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Text scoreText;
			LuaObject.checkType<Text>(l, 2, out scoreText);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_scoreText = scoreText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020145 RID: 131397 RVA: 0x00AA0618 File Offset: 0x00A9E818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_replayButton(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_replayButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020146 RID: 131398 RVA: 0x00AA0670 File Offset: 0x00A9E870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_replayButton(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			Button replayButton;
			LuaObject.checkType<Button>(l, 2, out replayButton);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_replayButton = replayButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020147 RID: 131399 RVA: 0x00AA06CC File Offset: 0x00A9E8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleReport(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_battleReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020148 RID: 131400 RVA: 0x00AA0724 File Offset: 0x00A9E924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleReport(IntPtr l)
	{
		int result;
		try
		{
			OnlineArenaBattleReportListItemUIController onlineArenaBattleReportListItemUIController = (OnlineArenaBattleReportListItemUIController)LuaObject.checkSelf(l);
			RealTimePVPBattleReport battleReport;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out battleReport);
			onlineArenaBattleReportListItemUIController.m_luaExportHelper.m_battleReport = battleReport;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020149 RID: 131401 RVA: 0x00AA0780 File Offset: 0x00A9E980
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.OnlineArenaBattleReportListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.SetRealTimePVPBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.GetRealTimePVPBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.OnReplayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__callDele_EventOnReplayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.__clearDele_EventOnReplayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache12);
		string name = "EventOnReplayButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.set_EventOnReplayButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache13, true);
		string name2 = "m_playerIconImage";
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.get_m_playerIconImage);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.set_m_playerIconImage);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache15, true);
		string name3 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.get_m_playerNameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache17, true);
		string name4 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.get_m_playerLevelText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache19, true);
		string name5 = "m_modeUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.get_m_modeUIStateCtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.set_m_modeUIStateCtrl);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1B, true);
		string name6 = "m_typeUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.get_m_typeUIStateCtrl);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.set_m_typeUIStateCtrl);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1D, true);
		string name7 = "m_timeText";
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.get_m_timeText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.set_m_timeText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache1F, true);
		string name8 = "m_scoreText";
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.get_m_scoreText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.set_m_scoreText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache21, true);
		string name9 = "m_replayButton";
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.get_m_replayButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.set_m_replayButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache23, true);
		string name10 = "m_battleReport";
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.get_m_battleReport);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.set_m_battleReport);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.<>f__mg$cache25, true);
		LuaObject.createTypeMetatable(l, null, typeof(OnlineArenaBattleReportListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040160CB RID: 90315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040160CC RID: 90316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040160CD RID: 90317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040160CE RID: 90318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040160CF RID: 90319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040160D0 RID: 90320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040160D1 RID: 90321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040160D2 RID: 90322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040160D3 RID: 90323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040160D4 RID: 90324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040160D5 RID: 90325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040160D6 RID: 90326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040160D7 RID: 90327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040160D8 RID: 90328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040160D9 RID: 90329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040160DA RID: 90330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040160DB RID: 90331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040160DC RID: 90332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040160DD RID: 90333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040160DE RID: 90334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040160DF RID: 90335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040160E0 RID: 90336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040160E1 RID: 90337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040160E2 RID: 90338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040160E3 RID: 90339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040160E4 RID: 90340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040160E5 RID: 90341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040160E6 RID: 90342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040160E7 RID: 90343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040160E8 RID: 90344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040160E9 RID: 90345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040160EA RID: 90346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040160EB RID: 90347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040160EC RID: 90348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040160ED RID: 90349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040160EE RID: 90350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040160EF RID: 90351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040160F0 RID: 90352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
