using System;
using System.Collections.Generic;
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

// Token: 0x02001361 RID: 4961
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AnikiUIController : LuaObject
{
	// Token: 0x0601AB96 RID: 109462 RVA: 0x007F73CC File Offset: 0x007F55CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB97 RID: 109463 RVA: 0x007F7418 File Offset: 0x007F5618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAnikiGymListItem(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo anikiGymInfo;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out anikiGymInfo);
			bool opened;
			LuaObject.checkType(l, 3, out opened);
			anikiUIController.AddAnikiGymListItem(anikiGymInfo, opened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB98 RID: 109464 RVA: 0x007F747C File Offset: 0x007F567C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAnikiGymListItems(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.ClearAnikiGymListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB99 RID: 109465 RVA: 0x007F74C8 File Offset: 0x007F56C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAllAnikiLevelListItem(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			List<ConfigDataAnikiLevelInfo> allAnikiLevelListItem;
			LuaObject.checkType<List<ConfigDataAnikiLevelInfo>>(l, 2, out allAnikiLevelListItem);
			anikiUIController.SetAllAnikiLevelListItem(allAnikiLevelListItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB9A RID: 109466 RVA: 0x007F7520 File Offset: 0x007F5720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelectedAnikiGym(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo selectedAnikiGym;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out selectedAnikiGym);
			anikiUIController.SetSelectedAnikiGym(selectedAnikiGym);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB9B RID: 109467 RVA: 0x007F7578 File Offset: 0x007F5778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDailyRewardCount(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			int restCount;
			LuaObject.checkType(l, 2, out restCount);
			int allCount;
			LuaObject.checkType(l, 3, out allCount);
			anikiUIController.SetDailyRewardCount(restCount, allCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB9C RID: 109468 RVA: 0x007F75DC File Offset: 0x007F57DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB9D RID: 109469 RVA: 0x007F7630 File Offset: 0x007F5830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB9E RID: 109470 RVA: 0x007F7684 File Offset: 0x007F5884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB9F RID: 109471 RVA: 0x007F76D8 File Offset: 0x007F58D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddTicketButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.OnAddTicketButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABA0 RID: 109472 RVA: 0x007F772C File Offset: 0x007F592C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTeamButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.OnTeamButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABA1 RID: 109473 RVA: 0x007F7780 File Offset: 0x007F5980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnikiGymListItem_OnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			AnikiGymListItemUIController ctrl;
			LuaObject.checkType<AnikiGymListItemUIController>(l, 3, out ctrl);
			anikiUIController.m_luaExportHelper.AnikiGymListItem_OnToggleValueChanged(isOn, ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABA2 RID: 109474 RVA: 0x007F77EC File Offset: 0x007F59EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnikiLevelListItem_OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			AnikiLevelListItemUIController ctrl;
			LuaObject.checkType<AnikiLevelListItemUIController>(l, 2, out ctrl);
			anikiUIController.m_luaExportHelper.AnikiLevelListItem_OnStartButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABA3 RID: 109475 RVA: 0x007F7848 File Offset: 0x007F5A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABA4 RID: 109476 RVA: 0x007F789C File Offset: 0x007F5A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			anikiUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABA5 RID: 109477 RVA: 0x007F7908 File Offset: 0x007F5B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABA6 RID: 109478 RVA: 0x007F795C File Offset: 0x007F5B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABA7 RID: 109479 RVA: 0x007F79B0 File Offset: 0x007F5BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = anikiUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601ABA8 RID: 109480 RVA: 0x007F7A58 File Offset: 0x007F5C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABA9 RID: 109481 RVA: 0x007F7AAC File Offset: 0x007F5CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			anikiUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABAA RID: 109482 RVA: 0x007F7B18 File Offset: 0x007F5D18
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
				AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				anikiUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				AnikiUIController anikiUIController2 = (AnikiUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				anikiUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601ABAB RID: 109483 RVA: 0x007F7C28 File Offset: 0x007F5E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABAC RID: 109484 RVA: 0x007F7C94 File Offset: 0x007F5E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABAD RID: 109485 RVA: 0x007F7D00 File Offset: 0x007F5F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABAE RID: 109486 RVA: 0x007F7D6C File Offset: 0x007F5F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABAF RID: 109487 RVA: 0x007F7DD8 File Offset: 0x007F5FD8
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
				AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				anikiUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				AnikiUIController anikiUIController2 = (AnikiUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				anikiUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601ABB0 RID: 109488 RVA: 0x007F7EE8 File Offset: 0x007F60E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			string s = anikiUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601ABB1 RID: 109489 RVA: 0x007F7F44 File Offset: 0x007F6144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABB2 RID: 109490 RVA: 0x007F7F98 File Offset: 0x007F6198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABB3 RID: 109491 RVA: 0x007F7FEC File Offset: 0x007F61EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABB4 RID: 109492 RVA: 0x007F8040 File Offset: 0x007F6240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABB5 RID: 109493 RVA: 0x007F8094 File Offset: 0x007F6294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__callDele_EventOnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABB6 RID: 109494 RVA: 0x007F80E8 File Offset: 0x007F62E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__clearDele_EventOnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABB7 RID: 109495 RVA: 0x007F813C File Offset: 0x007F633C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__callDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABB8 RID: 109496 RVA: 0x007F8190 File Offset: 0x007F6390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			anikiUIController.m_luaExportHelper.__clearDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABB9 RID: 109497 RVA: 0x007F81E4 File Offset: 0x007F63E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectAnikiGym(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo obj;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out obj);
			anikiUIController.m_luaExportHelper.__callDele_EventOnSelectAnikiGym(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABBA RID: 109498 RVA: 0x007F8240 File Offset: 0x007F6440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectAnikiGym(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo obj;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out obj);
			anikiUIController.m_luaExportHelper.__clearDele_EventOnSelectAnikiGym(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABBB RID: 109499 RVA: 0x007F829C File Offset: 0x007F649C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartAnikiLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo obj;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out obj);
			anikiUIController.m_luaExportHelper.__callDele_EventOnStartAnikiLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABBC RID: 109500 RVA: 0x007F82F8 File Offset: 0x007F64F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartAnikiLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo obj;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out obj);
			anikiUIController.m_luaExportHelper.__clearDele_EventOnStartAnikiLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABBD RID: 109501 RVA: 0x007F8354 File Offset: 0x007F6554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					anikiUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					anikiUIController.EventOnReturn -= value;
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

	// Token: 0x0601ABBE RID: 109502 RVA: 0x007F83D4 File Offset: 0x007F65D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					anikiUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					anikiUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601ABBF RID: 109503 RVA: 0x007F8454 File Offset: 0x007F6654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					anikiUIController.EventOnAddTicket += value;
				}
				else if (num == 2)
				{
					anikiUIController.EventOnAddTicket -= value;
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

	// Token: 0x0601ABC0 RID: 109504 RVA: 0x007F84D4 File Offset: 0x007F66D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					anikiUIController.EventOnShowTeam += value;
				}
				else if (num == 2)
				{
					anikiUIController.EventOnShowTeam -= value;
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

	// Token: 0x0601ABC1 RID: 109505 RVA: 0x007F8554 File Offset: 0x007F6754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectAnikiGym(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Action<ConfigDataAnikiGymInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataAnikiGymInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					anikiUIController.EventOnSelectAnikiGym += value;
				}
				else if (num == 2)
				{
					anikiUIController.EventOnSelectAnikiGym -= value;
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

	// Token: 0x0601ABC2 RID: 109506 RVA: 0x007F85D4 File Offset: 0x007F67D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartAnikiLevel(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Action<ConfigDataAnikiLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataAnikiLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					anikiUIController.EventOnStartAnikiLevel += value;
				}
				else if (num == 2)
				{
					anikiUIController.EventOnStartAnikiLevel -= value;
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

	// Token: 0x0601ABC3 RID: 109507 RVA: 0x007F8654 File Offset: 0x007F6854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABC4 RID: 109508 RVA: 0x007F86AC File Offset: 0x007F68AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			anikiUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABC5 RID: 109509 RVA: 0x007F8708 File Offset: 0x007F6908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABC6 RID: 109510 RVA: 0x007F8760 File Offset: 0x007F6960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			anikiUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABC7 RID: 109511 RVA: 0x007F87BC File Offset: 0x007F69BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABC8 RID: 109512 RVA: 0x007F8814 File Offset: 0x007F6A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			anikiUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABC9 RID: 109513 RVA: 0x007F8870 File Offset: 0x007F6A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_teamButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABCA RID: 109514 RVA: 0x007F88C8 File Offset: 0x007F6AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Button teamButton;
			LuaObject.checkType<Button>(l, 2, out teamButton);
			anikiUIController.m_luaExportHelper.m_teamButton = teamButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABCB RID: 109515 RVA: 0x007F8924 File Offset: 0x007F6B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_dailyRewardCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABCC RID: 109516 RVA: 0x007F897C File Offset: 0x007F6B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Text dailyRewardCountText;
			LuaObject.checkType<Text>(l, 2, out dailyRewardCountText);
			anikiUIController.m_luaExportHelper.m_dailyRewardCountText = dailyRewardCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABCD RID: 109517 RVA: 0x007F89D8 File Offset: 0x007F6BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gymListGameObject(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_gymListGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABCE RID: 109518 RVA: 0x007F8A30 File Offset: 0x007F6C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gymListGameObject(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			GameObject gymListGameObject;
			LuaObject.checkType<GameObject>(l, 2, out gymListGameObject);
			anikiUIController.m_luaExportHelper.m_gymListGameObject = gymListGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABCF RID: 109519 RVA: 0x007F8A8C File Offset: 0x007F6C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gymNameText(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_gymNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABD0 RID: 109520 RVA: 0x007F8AE4 File Offset: 0x007F6CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gymNameText(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			Text gymNameText;
			LuaObject.checkType<Text>(l, 2, out gymNameText);
			anikiUIController.m_luaExportHelper.m_gymNameText = gymNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABD1 RID: 109521 RVA: 0x007F8B40 File Offset: 0x007F6D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_levelListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABD2 RID: 109522 RVA: 0x007F8B98 File Offset: 0x007F6D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			ScrollRect levelListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out levelListScrollRect);
			anikiUIController.m_luaExportHelper.m_levelListScrollRect = levelListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABD3 RID: 109523 RVA: 0x007F8BF4 File Offset: 0x007F6DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABD4 RID: 109524 RVA: 0x007F8C4C File Offset: 0x007F6E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			anikiUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABD5 RID: 109525 RVA: 0x007F8CA8 File Offset: 0x007F6EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_anikiGymListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_anikiGymListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABD6 RID: 109526 RVA: 0x007F8D00 File Offset: 0x007F6F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiGymListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			GameObject anikiGymListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out anikiGymListItemPrefab);
			anikiUIController.m_luaExportHelper.m_anikiGymListItemPrefab = anikiGymListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABD7 RID: 109527 RVA: 0x007F8D5C File Offset: 0x007F6F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_anikiLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_anikiLevelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABD8 RID: 109528 RVA: 0x007F8DB4 File Offset: 0x007F6FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			GameObject anikiLevelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out anikiLevelListItemPrefab);
			anikiUIController.m_luaExportHelper.m_anikiLevelListItemPrefab = anikiLevelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABD9 RID: 109529 RVA: 0x007F8E10 File Offset: 0x007F7010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_anikiGymListItems(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_anikiGymListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABDA RID: 109530 RVA: 0x007F8E68 File Offset: 0x007F7068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiGymListItems(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			List<AnikiGymListItemUIController> anikiGymListItems;
			LuaObject.checkType<List<AnikiGymListItemUIController>>(l, 2, out anikiGymListItems);
			anikiUIController.m_luaExportHelper.m_anikiGymListItems = anikiGymListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABDB RID: 109531 RVA: 0x007F8EC4 File Offset: 0x007F70C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABDC RID: 109532 RVA: 0x007F8F1C File Offset: 0x007F711C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			AnikiUIController anikiUIController = (AnikiUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			anikiUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ABDD RID: 109533 RVA: 0x007F8F78 File Offset: 0x007F7178
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AnikiUIController");
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.AddAnikiGymListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.ClearAnikiGymListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.SetAllAnikiLevelListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.SetSelectedAnikiGym);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.SetDailyRewardCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.OnAddTicketButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.OnTeamButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.AnikiGymListItem_OnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.AnikiLevelListItem_OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callDele_EventOnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__clearDele_EventOnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__clearDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callDele_EventOnSelectAnikiGym);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__clearDele_EventOnSelectAnikiGym);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__callDele_EventOnStartAnikiLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.__clearDele_EventOnStartAnikiLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache26);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache27, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache28, true);
		string name3 = "EventOnAddTicket";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_EventOnAddTicket);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache29, true);
		string name4 = "EventOnShowTeam";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_EventOnShowTeam);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2A, true);
		string name5 = "EventOnSelectAnikiGym";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_EventOnSelectAnikiGym);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2B, true);
		string name6 = "EventOnStartAnikiLevel";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_EventOnStartAnikiLevel);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2C, true);
		string name7 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_uiStateController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2E, true);
		string name8 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_returnButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache30, true);
		string name9 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_helpButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache32, true);
		string name10 = "m_teamButton";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_teamButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_teamButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache34, true);
		string name11 = "m_dailyRewardCountText";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_dailyRewardCountText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_dailyRewardCountText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache36, true);
		string name12 = "m_gymListGameObject";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_gymListGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_gymListGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache38, true);
		string name13 = "m_gymNameText";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_gymNameText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_gymNameText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3A, true);
		string name14 = "m_levelListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_levelListScrollRect);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_levelListScrollRect);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3C, true);
		string name15 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3E, true);
		string name16 = "m_anikiGymListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_anikiGymListItemPrefab);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_anikiGymListItemPrefab);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache40, true);
		string name17 = "m_anikiLevelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_anikiLevelListItemPrefab);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_anikiLevelListItemPrefab);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache42, true);
		string name18 = "m_anikiGymListItems";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_anikiGymListItems);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_anikiGymListItems);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache44, true);
		string name19 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.get_m_playerContext);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_AnikiUIController.<>f__mg$cache46, true);
		LuaObject.createTypeMetatable(l, null, typeof(AnikiUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010EB6 RID: 69302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010EB7 RID: 69303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010EB8 RID: 69304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010EB9 RID: 69305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010EBA RID: 69306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010EBB RID: 69307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010EBC RID: 69308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010EBD RID: 69309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010EBE RID: 69310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010EBF RID: 69311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010EC0 RID: 69312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010EC1 RID: 69313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010EC2 RID: 69314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010EC3 RID: 69315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010EC4 RID: 69316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010EC5 RID: 69317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010EC6 RID: 69318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010EC7 RID: 69319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010EC8 RID: 69320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010EC9 RID: 69321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010ECA RID: 69322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010ECB RID: 69323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010ECC RID: 69324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010ECD RID: 69325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010ECE RID: 69326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010ECF RID: 69327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010ED0 RID: 69328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010ED1 RID: 69329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010ED2 RID: 69330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010ED3 RID: 69331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010ED4 RID: 69332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010ED5 RID: 69333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010ED6 RID: 69334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010ED7 RID: 69335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010ED8 RID: 69336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010ED9 RID: 69337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010EDA RID: 69338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010EDB RID: 69339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010EDC RID: 69340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010EDD RID: 69341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010EDE RID: 69342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010EDF RID: 69343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010EE0 RID: 69344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010EE1 RID: 69345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010EE2 RID: 69346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010EE3 RID: 69347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010EE4 RID: 69348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010EE5 RID: 69349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010EE6 RID: 69350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010EE7 RID: 69351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010EE8 RID: 69352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010EE9 RID: 69353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010EEA RID: 69354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010EEB RID: 69355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010EEC RID: 69356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010EED RID: 69357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04010EEE RID: 69358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04010EEF RID: 69359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04010EF0 RID: 69360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04010EF1 RID: 69361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04010EF2 RID: 69362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04010EF3 RID: 69363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04010EF4 RID: 69364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04010EF5 RID: 69365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04010EF6 RID: 69366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04010EF7 RID: 69367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04010EF8 RID: 69368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04010EF9 RID: 69369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04010EFA RID: 69370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04010EFB RID: 69371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04010EFC RID: 69372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;
}
