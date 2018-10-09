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

// Token: 0x020015C7 RID: 5575
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController : LuaObject
{
	// Token: 0x06021EE9 RID: 138985 RVA: 0x00B8CFA8 File Offset: 0x00B8B1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUnchartedScoreLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo unchartedScoreLevelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out unchartedScoreLevelInfo);
			unchartedScoreLevelListItemUIController.SetUnchartedScoreLevelInfo(unchartedScoreLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EEA RID: 138986 RVA: 0x00B8D000 File Offset: 0x00B8B200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUnchartedChallengeLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo unchartedChallengeLevelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 2, out unchartedChallengeLevelInfo);
			unchartedScoreLevelListItemUIController.SetUnchartedChallengeLevelInfo(unchartedChallengeLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EEB RID: 138987 RVA: 0x00B8D058 File Offset: 0x00B8B258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUnchartedScoreLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo unchartedScoreLevelInfo = unchartedScoreLevelListItemUIController.GetUnchartedScoreLevelInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EEC RID: 138988 RVA: 0x00B8D0AC File Offset: 0x00B8B2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUnchartedChallengeLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo unchartedChallengeLevelInfo = unchartedScoreLevelListItemUIController.GetUnchartedChallengeLevelInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedChallengeLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EED RID: 138989 RVA: 0x00B8D100 File Offset: 0x00B8B300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			unchartedScoreLevelListItemUIController.SetLocked(locked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EEE RID: 138990 RVA: 0x00B8D158 File Offset: 0x00B8B358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOpenDayLocked(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			int openDayLocked;
			LuaObject.checkType(l, 2, out openDayLocked);
			unchartedScoreLevelListItemUIController.SetOpenDayLocked(openDayLocked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EEF RID: 138991 RVA: 0x00B8D1B0 File Offset: 0x00B8B3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreLevelListItemUIController.SetCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EF0 RID: 138992 RVA: 0x00B8D1FC File Offset: 0x00B8B3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EF1 RID: 138993 RVA: 0x00B8D250 File Offset: 0x00B8B450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int monsterLevel;
			LuaObject.checkType(l, 3, out monsterLevel);
			int energy;
			LuaObject.checkType(l, 4, out energy);
			List<Goods> rewardList;
			LuaObject.checkType<List<Goods>>(l, 5, out rewardList);
			int rewardDisplayCount;
			LuaObject.checkType(l, 6, out rewardDisplayCount);
			bool showRewardGoodCount;
			LuaObject.checkType(l, 7, out showRewardGoodCount);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.SetLevelInfo(name, monsterLevel, energy, rewardList, rewardDisplayCount, showRewardGoodCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EF2 RID: 138994 RVA: 0x00B8D2EC File Offset: 0x00B8B4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EF3 RID: 138995 RVA: 0x00B8D340 File Offset: 0x00B8B540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLockedButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.OnLockedButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EF4 RID: 138996 RVA: 0x00B8D394 File Offset: 0x00B8B594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EF5 RID: 138997 RVA: 0x00B8D400 File Offset: 0x00B8B600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EF6 RID: 138998 RVA: 0x00B8D454 File Offset: 0x00B8B654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EF7 RID: 138999 RVA: 0x00B8D4A8 File Offset: 0x00B8B6A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021EF8 RID: 139000 RVA: 0x00B8D550 File Offset: 0x00B8B750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EF9 RID: 139001 RVA: 0x00B8D5A4 File Offset: 0x00B8B7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EFA RID: 139002 RVA: 0x00B8D610 File Offset: 0x00B8B810
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
				UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController2 = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				unchartedScoreLevelListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021EFB RID: 139003 RVA: 0x00B8D720 File Offset: 0x00B8B920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EFC RID: 139004 RVA: 0x00B8D78C File Offset: 0x00B8B98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EFD RID: 139005 RVA: 0x00B8D7F8 File Offset: 0x00B8B9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EFE RID: 139006 RVA: 0x00B8D864 File Offset: 0x00B8BA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EFF RID: 139007 RVA: 0x00B8D8D0 File Offset: 0x00B8BAD0
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
				UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController2 = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				unchartedScoreLevelListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021F00 RID: 139008 RVA: 0x00B8D9E0 File Offset: 0x00B8BBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			string s = unchartedScoreLevelListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021F01 RID: 139009 RVA: 0x00B8DA3C File Offset: 0x00B8BC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			UnchartedScoreLevelListItemUIController obj;
			LuaObject.checkType<UnchartedScoreLevelListItemUIController>(l, 2, out obj);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__callDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F02 RID: 139010 RVA: 0x00B8DA98 File Offset: 0x00B8BC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			UnchartedScoreLevelListItemUIController obj;
			LuaObject.checkType<UnchartedScoreLevelListItemUIController>(l, 2, out obj);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.__clearDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F03 RID: 139011 RVA: 0x00B8DAF4 File Offset: 0x00B8BCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			Action<UnchartedScoreLevelListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<UnchartedScoreLevelListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedScoreLevelListItemUIController.EventOnStartButtonClick += value;
				}
				else if (num == 2)
				{
					unchartedScoreLevelListItemUIController.EventOnStartButtonClick -= value;
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

	// Token: 0x06021F04 RID: 139012 RVA: 0x00B8DB74 File Offset: 0x00B8BD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F05 RID: 139013 RVA: 0x00B8DBCC File Offset: 0x00B8BDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F06 RID: 139014 RVA: 0x00B8DC28 File Offset: 0x00B8BE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelNameText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_levelNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F07 RID: 139015 RVA: 0x00B8DC80 File Offset: 0x00B8BE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelNameText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			Text levelNameText;
			LuaObject.checkType<Text>(l, 2, out levelNameText);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_levelNameText = levelNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F08 RID: 139016 RVA: 0x00B8DCDC File Offset: 0x00B8BEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F09 RID: 139017 RVA: 0x00B8DD34 File Offset: 0x00B8BF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F0A RID: 139018 RVA: 0x00B8DD90 File Offset: 0x00B8BF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F0B RID: 139019 RVA: 0x00B8DDE8 File Offset: 0x00B8BFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F0C RID: 139020 RVA: 0x00B8DE44 File Offset: 0x00B8C044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_lockedButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F0D RID: 139021 RVA: 0x00B8DE9C File Offset: 0x00B8C09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			Button lockedButton;
			LuaObject.checkType<Button>(l, 2, out lockedButton);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_lockedButton = lockedButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F0E RID: 139022 RVA: 0x00B8DEF8 File Offset: 0x00B8C0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_lockedText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F0F RID: 139023 RVA: 0x00B8DF50 File Offset: 0x00B8C150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			Text lockedText;
			LuaObject.checkType<Text>(l, 2, out lockedText);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_lockedText = lockedText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F10 RID: 139024 RVA: 0x00B8DFAC File Offset: 0x00B8C1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton1(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_startButton1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F11 RID: 139025 RVA: 0x00B8E004 File Offset: 0x00B8C204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton1(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_startButton1 = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F12 RID: 139026 RVA: 0x00B8E060 File Offset: 0x00B8C260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton2(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_startButton2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F13 RID: 139027 RVA: 0x00B8E0B8 File Offset: 0x00B8C2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton2(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_startButton2 = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F14 RID: 139028 RVA: 0x00B8E114 File Offset: 0x00B8C314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_rewardGroupTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F15 RID: 139029 RVA: 0x00B8E16C File Offset: 0x00B8C36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			Transform rewardGroupTransform;
			LuaObject.checkType<Transform>(l, 2, out rewardGroupTransform);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_rewardGroupTransform = rewardGroupTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F16 RID: 139030 RVA: 0x00B8E1C8 File Offset: 0x00B8C3C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_unchartedScoreLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_unchartedScoreLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F17 RID: 139031 RVA: 0x00B8E220 File Offset: 0x00B8C420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedScoreLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo unchartedScoreLevelInfo;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out unchartedScoreLevelInfo);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_unchartedScoreLevelInfo = unchartedScoreLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F18 RID: 139032 RVA: 0x00B8E27C File Offset: 0x00B8C47C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_unchartedChallengeLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreLevelListItemUIController.m_luaExportHelper.m_unchartedChallengeLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F19 RID: 139033 RVA: 0x00B8E2D4 File Offset: 0x00B8C4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedChallengeLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController = (UnchartedScoreLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo unchartedChallengeLevelInfo;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 2, out unchartedChallengeLevelInfo);
			unchartedScoreLevelListItemUIController.m_luaExportHelper.m_unchartedChallengeLevelInfo = unchartedChallengeLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F1A RID: 139034 RVA: 0x00B8E330 File Offset: 0x00B8C530
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedScoreLevelListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.SetUnchartedScoreLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.SetUnchartedChallengeLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.GetUnchartedScoreLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.GetUnchartedChallengeLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.SetOpenDayLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.SetCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.SetLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.OnLockedButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__callDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.__clearDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache19);
		string name = "EventOnStartButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1A, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1C, true);
		string name3 = "m_levelNameText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_levelNameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_levelNameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1E, true);
		string name4 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_levelText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache20, true);
		string name5 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_energyText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache22, true);
		string name6 = "m_lockedButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_lockedButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_lockedButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache24, true);
		string name7 = "m_lockedText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_lockedText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_lockedText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache26, true);
		string name8 = "m_startButton1";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_startButton1);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_startButton1);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache28, true);
		string name9 = "m_startButton2";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_startButton2);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_startButton2);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2A, true);
		string name10 = "m_rewardGroupTransform";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_rewardGroupTransform);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_rewardGroupTransform);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2C, true);
		string name11 = "m_unchartedScoreLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_unchartedScoreLevelInfo);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_unchartedScoreLevelInfo);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2E, true);
		string name12 = "m_unchartedChallengeLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.get_m_unchartedChallengeLevelInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.set_m_unchartedChallengeLevelInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.<>f__mg$cache30, true);
		LuaObject.createTypeMetatable(l, null, typeof(UnchartedScoreLevelListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017D3D RID: 97597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017D3E RID: 97598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017D3F RID: 97599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017D40 RID: 97600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017D41 RID: 97601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017D42 RID: 97602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017D43 RID: 97603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017D44 RID: 97604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017D45 RID: 97605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017D46 RID: 97606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017D47 RID: 97607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017D48 RID: 97608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017D49 RID: 97609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017D4A RID: 97610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017D4B RID: 97611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017D4C RID: 97612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017D4D RID: 97613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017D4E RID: 97614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017D4F RID: 97615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017D50 RID: 97616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017D51 RID: 97617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017D52 RID: 97618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017D53 RID: 97619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017D54 RID: 97620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017D55 RID: 97621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017D56 RID: 97622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017D57 RID: 97623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017D58 RID: 97624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017D59 RID: 97625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017D5A RID: 97626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017D5B RID: 97627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017D5C RID: 97628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017D5D RID: 97629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017D5E RID: 97630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017D5F RID: 97631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017D60 RID: 97632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017D61 RID: 97633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017D62 RID: 97634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017D63 RID: 97635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017D64 RID: 97636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017D65 RID: 97637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017D66 RID: 97638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017D67 RID: 97639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017D68 RID: 97640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017D69 RID: 97641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017D6A RID: 97642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017D6B RID: 97643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017D6C RID: 97644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017D6D RID: 97645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
