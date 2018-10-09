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

// Token: 0x020013B0 RID: 5040
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleReportEndUIController : LuaObject
{
	// Token: 0x0601BD48 RID: 113992 RVA: 0x00884258 File Offset: 0x00882458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ArenaBattleReport)))
			{
				BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
				ArenaBattleReport battleReport;
				LuaObject.checkType<ArenaBattleReport>(l, 2, out battleReport);
				battleReportEndUIController.Open(battleReport);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(RealTimePVPBattleReport)))
			{
				BattleReportEndUIController battleReportEndUIController2 = (BattleReportEndUIController)LuaObject.checkSelf(l);
				RealTimePVPBattleReport battleReport2;
				LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out battleReport2);
				battleReportEndUIController2.Open(battleReport2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Open to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD49 RID: 113993 RVA: 0x00884330 File Offset: 0x00882530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			battleReportEndUIController.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD4A RID: 113994 RVA: 0x00884388 File Offset: 0x00882588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD4B RID: 113995 RVA: 0x008843DC File Offset: 0x008825DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD4C RID: 113996 RVA: 0x00884430 File Offset: 0x00882630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.OnPlayButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD4D RID: 113997 RVA: 0x00884484 File Offset: 0x00882684
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnExitButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.OnExitButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD4E RID: 113998 RVA: 0x008844D8 File Offset: 0x008826D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleReportEndUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD4F RID: 113999 RVA: 0x00884544 File Offset: 0x00882744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD50 RID: 114000 RVA: 0x00884598 File Offset: 0x00882798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD51 RID: 114001 RVA: 0x008845EC File Offset: 0x008827EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleReportEndUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601BD52 RID: 114002 RVA: 0x00884694 File Offset: 0x00882894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD53 RID: 114003 RVA: 0x008846E8 File Offset: 0x008828E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleReportEndUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD54 RID: 114004 RVA: 0x00884754 File Offset: 0x00882954
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
				BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleReportEndUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleReportEndUIController battleReportEndUIController2 = (BattleReportEndUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleReportEndUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601BD55 RID: 114005 RVA: 0x00884864 File Offset: 0x00882A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleReportEndUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD56 RID: 114006 RVA: 0x008848D0 File Offset: 0x00882AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleReportEndUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD57 RID: 114007 RVA: 0x0088493C File Offset: 0x00882B3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleReportEndUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD58 RID: 114008 RVA: 0x008849A8 File Offset: 0x00882BA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleReportEndUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD59 RID: 114009 RVA: 0x00884A14 File Offset: 0x00882C14
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
				BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleReportEndUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleReportEndUIController battleReportEndUIController2 = (BattleReportEndUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleReportEndUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601BD5A RID: 114010 RVA: 0x00884B24 File Offset: 0x00882D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			string s = battleReportEndUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601BD5B RID: 114011 RVA: 0x00884B80 File Offset: 0x00882D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPlayAgain(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.__callDele_EventOnPlayAgain();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD5C RID: 114012 RVA: 0x00884BD4 File Offset: 0x00882DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPlayAgain(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.__clearDele_EventOnPlayAgain();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD5D RID: 114013 RVA: 0x00884C28 File Offset: 0x00882E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD5E RID: 114014 RVA: 0x00884C7C File Offset: 0x00882E7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			battleReportEndUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD5F RID: 114015 RVA: 0x00884CD0 File Offset: 0x00882ED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnPlayAgain(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleReportEndUIController.EventOnPlayAgain += value;
				}
				else if (num == 2)
				{
					battleReportEndUIController.EventOnPlayAgain -= value;
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

	// Token: 0x0601BD60 RID: 114016 RVA: 0x00884D50 File Offset: 0x00882F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleReportEndUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					battleReportEndUIController.EventOnClose -= value;
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

	// Token: 0x0601BD61 RID: 114017 RVA: 0x00884DD0 File Offset: 0x00882FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD62 RID: 114018 RVA: 0x00884E28 File Offset: 0x00883028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			battleReportEndUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD63 RID: 114019 RVA: 0x00884E84 File Offset: 0x00883084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winPlayerIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUIController.m_luaExportHelper.m_winPlayerIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD64 RID: 114020 RVA: 0x00884EDC File Offset: 0x008830DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_winPlayerIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Image winPlayerIcon;
			LuaObject.checkType<Image>(l, 2, out winPlayerIcon);
			battleReportEndUIController.m_luaExportHelper.m_winPlayerIcon = winPlayerIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD65 RID: 114021 RVA: 0x00884F38 File Offset: 0x00883138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winPlayerLV(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUIController.m_luaExportHelper.m_winPlayerLV);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD66 RID: 114022 RVA: 0x00884F90 File Offset: 0x00883190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winPlayerLV(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Text winPlayerLV;
			LuaObject.checkType<Text>(l, 2, out winPlayerLV);
			battleReportEndUIController.m_luaExportHelper.m_winPlayerLV = winPlayerLV;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD67 RID: 114023 RVA: 0x00884FEC File Offset: 0x008831EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winPlayerName(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUIController.m_luaExportHelper.m_winPlayerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD68 RID: 114024 RVA: 0x00885044 File Offset: 0x00883244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winPlayerName(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Text winPlayerName;
			LuaObject.checkType<Text>(l, 2, out winPlayerName);
			battleReportEndUIController.m_luaExportHelper.m_winPlayerName = winPlayerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD69 RID: 114025 RVA: 0x008850A0 File Offset: 0x008832A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_losePlayerIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUIController.m_luaExportHelper.m_losePlayerIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD6A RID: 114026 RVA: 0x008850F8 File Offset: 0x008832F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_losePlayerIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Image losePlayerIcon;
			LuaObject.checkType<Image>(l, 2, out losePlayerIcon);
			battleReportEndUIController.m_luaExportHelper.m_losePlayerIcon = losePlayerIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD6B RID: 114027 RVA: 0x00885154 File Offset: 0x00883354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_losePlayerLV(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUIController.m_luaExportHelper.m_losePlayerLV);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD6C RID: 114028 RVA: 0x008851AC File Offset: 0x008833AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_losePlayerLV(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Text losePlayerLV;
			LuaObject.checkType<Text>(l, 2, out losePlayerLV);
			battleReportEndUIController.m_luaExportHelper.m_losePlayerLV = losePlayerLV;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD6D RID: 114029 RVA: 0x00885208 File Offset: 0x00883408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_losePlayerName(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUIController.m_luaExportHelper.m_losePlayerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD6E RID: 114030 RVA: 0x00885260 File Offset: 0x00883460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_losePlayerName(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Text losePlayerName;
			LuaObject.checkType<Text>(l, 2, out losePlayerName);
			battleReportEndUIController.m_luaExportHelper.m_losePlayerName = losePlayerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD6F RID: 114031 RVA: 0x008852BC File Offset: 0x008834BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD70 RID: 114032 RVA: 0x00885314 File Offset: 0x00883514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			battleReportEndUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD71 RID: 114033 RVA: 0x00885370 File Offset: 0x00883570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playButtonButton(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUIController.m_luaExportHelper.m_playButtonButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD72 RID: 114034 RVA: 0x008853C8 File Offset: 0x008835C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playButtonButton(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Button playButtonButton;
			LuaObject.checkType<Button>(l, 2, out playButtonButton);
			battleReportEndUIController.m_luaExportHelper.m_playButtonButton = playButtonButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD73 RID: 114035 RVA: 0x00885424 File Offset: 0x00883624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_exitButtonButton(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReportEndUIController.m_luaExportHelper.m_exitButtonButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD74 RID: 114036 RVA: 0x0088547C File Offset: 0x0088367C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_exitButtonButton(IntPtr l)
	{
		int result;
		try
		{
			BattleReportEndUIController battleReportEndUIController = (BattleReportEndUIController)LuaObject.checkSelf(l);
			Button exitButtonButton;
			LuaObject.checkType<Button>(l, 2, out exitButtonButton);
			battleReportEndUIController.m_luaExportHelper.m_exitButtonButton = exitButtonButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BD75 RID: 114037 RVA: 0x008854D8 File Offset: 0x008836D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleReportEndUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.OnPlayButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.OnExitButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callDele_EventOnPlayAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__clearDele_EventOnPlayAgain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache16);
		string name = "EventOnPlayAgain";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_EventOnPlayAgain);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache17, true);
		string name2 = "EventOnClose";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache18, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1A, true);
		string name4 = "m_winPlayerIcon";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.get_m_winPlayerIcon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_m_winPlayerIcon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1C, true);
		string name5 = "m_winPlayerLV";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.get_m_winPlayerLV);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_m_winPlayerLV);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1E, true);
		string name6 = "m_winPlayerName";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.get_m_winPlayerName);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_m_winPlayerName);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache20, true);
		string name7 = "m_losePlayerIcon";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.get_m_losePlayerIcon);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_m_losePlayerIcon);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache22, true);
		string name8 = "m_losePlayerLV";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.get_m_losePlayerLV);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_m_losePlayerLV);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache24, true);
		string name9 = "m_losePlayerName";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.get_m_losePlayerName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_m_losePlayerName);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache26, true);
		string name10 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.get_m_backgroundButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache28, true);
		string name11 = "m_playButtonButton";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.get_m_playButtonButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_m_playButtonButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2A, true);
		string name12 = "m_exitButtonButton";
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.get_m_exitButtonButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.set_m_exitButtonButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.<>f__mg$cache2C, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleReportEndUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011FCA RID: 73674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011FCB RID: 73675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011FCC RID: 73676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011FCD RID: 73677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011FCE RID: 73678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011FCF RID: 73679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011FD0 RID: 73680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011FD1 RID: 73681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011FD2 RID: 73682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011FD3 RID: 73683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011FD4 RID: 73684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011FD5 RID: 73685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011FD6 RID: 73686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011FD7 RID: 73687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011FD8 RID: 73688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011FD9 RID: 73689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011FDA RID: 73690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011FDB RID: 73691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011FDC RID: 73692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011FDD RID: 73693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011FDE RID: 73694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011FDF RID: 73695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011FE0 RID: 73696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011FE1 RID: 73697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011FE2 RID: 73698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011FE3 RID: 73699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011FE4 RID: 73700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011FE5 RID: 73701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011FE6 RID: 73702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011FE7 RID: 73703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011FE8 RID: 73704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011FE9 RID: 73705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011FEA RID: 73706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011FEB RID: 73707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011FEC RID: 73708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011FED RID: 73709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011FEE RID: 73710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011FEF RID: 73711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011FF0 RID: 73712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011FF1 RID: 73713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011FF2 RID: 73714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011FF3 RID: 73715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011FF4 RID: 73716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011FF5 RID: 73717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011FF6 RID: 73718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;
}
