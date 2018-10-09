using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200150C RID: 5388
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController : LuaObject
{
	// Token: 0x0601FE78 RID: 130680 RVA: 0x00A8A5E0 File Offset: 0x00A887E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE79 RID: 130681 RVA: 0x00A8A62C File Offset: 0x00A8882C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMemoryCorridor(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorInfo memoryCorridor;
			LuaObject.checkType<ConfigDataMemoryCorridorInfo>(l, 2, out memoryCorridor);
			memoryCorridorUIController.SetMemoryCorridor(memoryCorridor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE7A RID: 130682 RVA: 0x00A8A684 File Offset: 0x00A88884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAllMemoryCorridorLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			List<ConfigDataMemoryCorridorLevelInfo> levelInfos;
			LuaObject.checkType<List<ConfigDataMemoryCorridorLevelInfo>>(l, 2, out levelInfos);
			memoryCorridorUIController.AddAllMemoryCorridorLevelListItems(levelInfos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE7B RID: 130683 RVA: 0x00A8A6DC File Offset: 0x00A888DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMemoryCorridorLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.ClearMemoryCorridorLevelListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE7C RID: 130684 RVA: 0x00A8A728 File Offset: 0x00A88928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDailyRewardCount(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			int restCount;
			LuaObject.checkType(l, 2, out restCount);
			int allCount;
			LuaObject.checkType(l, 3, out allCount);
			memoryCorridorUIController.SetDailyRewardCount(restCount, allCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE7D RID: 130685 RVA: 0x00A8A78C File Offset: 0x00A8898C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE7E RID: 130686 RVA: 0x00A8A7E0 File Offset: 0x00A889E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE7F RID: 130687 RVA: 0x00A8A834 File Offset: 0x00A88A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMemoryCorridorLevelListItem(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo levelnfo;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out levelnfo);
			bool opened;
			LuaObject.checkType(l, 3, out opened);
			memoryCorridorUIController.m_luaExportHelper.AddMemoryCorridorLevelListItem(levelnfo, opened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE80 RID: 130688 RVA: 0x00A8A8A0 File Offset: 0x00A88AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE81 RID: 130689 RVA: 0x00A8A8F4 File Offset: 0x00A88AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE82 RID: 130690 RVA: 0x00A8A948 File Offset: 0x00A88B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddTicketButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.OnAddTicketButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE83 RID: 130691 RVA: 0x00A8A99C File Offset: 0x00A88B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTeamButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.OnTeamButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE84 RID: 130692 RVA: 0x00A8A9F0 File Offset: 0x00A88BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MemoryCorridorLevelListItem_OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			MemoryCorridorLevelListItemUIController ctrl;
			LuaObject.checkType<MemoryCorridorLevelListItemUIController>(l, 2, out ctrl);
			memoryCorridorUIController.m_luaExportHelper.MemoryCorridorLevelListItem_OnStartButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE85 RID: 130693 RVA: 0x00A8AA4C File Offset: 0x00A88C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorInfo memoryCorridorInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorInfo>(l, 2, out memoryCorridorInfo);
			memoryCorridorUIController.m_luaExportHelper.CreateSpineGraphic(memoryCorridorInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE86 RID: 130694 RVA: 0x00A8AAA8 File Offset: 0x00A88CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.DestroySpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE87 RID: 130695 RVA: 0x00A8AAFC File Offset: 0x00A88CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			memoryCorridorUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE88 RID: 130696 RVA: 0x00A8AB68 File Offset: 0x00A88D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE89 RID: 130697 RVA: 0x00A8ABBC File Offset: 0x00A88DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE8A RID: 130698 RVA: 0x00A8AC10 File Offset: 0x00A88E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = memoryCorridorUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FE8B RID: 130699 RVA: 0x00A8ACB8 File Offset: 0x00A88EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE8C RID: 130700 RVA: 0x00A8AD0C File Offset: 0x00A88F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			memoryCorridorUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE8D RID: 130701 RVA: 0x00A8AD78 File Offset: 0x00A88F78
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
				MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				memoryCorridorUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				MemoryCorridorUIController memoryCorridorUIController2 = (MemoryCorridorUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				memoryCorridorUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FE8E RID: 130702 RVA: 0x00A8AE88 File Offset: 0x00A89088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryCorridorUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE8F RID: 130703 RVA: 0x00A8AEF4 File Offset: 0x00A890F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryCorridorUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE90 RID: 130704 RVA: 0x00A8AF60 File Offset: 0x00A89160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryCorridorUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE91 RID: 130705 RVA: 0x00A8AFCC File Offset: 0x00A891CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryCorridorUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE92 RID: 130706 RVA: 0x00A8B038 File Offset: 0x00A89238
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
				MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				memoryCorridorUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				MemoryCorridorUIController memoryCorridorUIController2 = (MemoryCorridorUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				memoryCorridorUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FE93 RID: 130707 RVA: 0x00A8B148 File Offset: 0x00A89348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			string s = memoryCorridorUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FE94 RID: 130708 RVA: 0x00A8B1A4 File Offset: 0x00A893A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE95 RID: 130709 RVA: 0x00A8B1F8 File Offset: 0x00A893F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE96 RID: 130710 RVA: 0x00A8B24C File Offset: 0x00A8944C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE97 RID: 130711 RVA: 0x00A8B2A0 File Offset: 0x00A894A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE98 RID: 130712 RVA: 0x00A8B2F4 File Offset: 0x00A894F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__callDele_EventOnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE99 RID: 130713 RVA: 0x00A8B348 File Offset: 0x00A89548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__clearDele_EventOnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE9A RID: 130714 RVA: 0x00A8B39C File Offset: 0x00A8959C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__callDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE9B RID: 130715 RVA: 0x00A8B3F0 File Offset: 0x00A895F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			memoryCorridorUIController.m_luaExportHelper.__clearDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE9C RID: 130716 RVA: 0x00A8B444 File Offset: 0x00A89644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo obj;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out obj);
			memoryCorridorUIController.m_luaExportHelper.__callDele_EventOnStartMemoryCorridorLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE9D RID: 130717 RVA: 0x00A8B4A0 File Offset: 0x00A896A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo obj;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out obj);
			memoryCorridorUIController.m_luaExportHelper.__clearDele_EventOnStartMemoryCorridorLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE9E RID: 130718 RVA: 0x00A8B4FC File Offset: 0x00A896FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					memoryCorridorUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					memoryCorridorUIController.EventOnReturn -= value;
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

	// Token: 0x0601FE9F RID: 130719 RVA: 0x00A8B57C File Offset: 0x00A8977C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					memoryCorridorUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					memoryCorridorUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601FEA0 RID: 130720 RVA: 0x00A8B5FC File Offset: 0x00A897FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					memoryCorridorUIController.EventOnAddTicket += value;
				}
				else if (num == 2)
				{
					memoryCorridorUIController.EventOnAddTicket -= value;
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

	// Token: 0x0601FEA1 RID: 130721 RVA: 0x00A8B67C File Offset: 0x00A8987C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					memoryCorridorUIController.EventOnShowTeam += value;
				}
				else if (num == 2)
				{
					memoryCorridorUIController.EventOnShowTeam -= value;
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

	// Token: 0x0601FEA2 RID: 130722 RVA: 0x00A8B6FC File Offset: 0x00A898FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartMemoryCorridorLevel(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Action<ConfigDataMemoryCorridorLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataMemoryCorridorLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					memoryCorridorUIController.EventOnStartMemoryCorridorLevel += value;
				}
				else if (num == 2)
				{
					memoryCorridorUIController.EventOnStartMemoryCorridorLevel -= value;
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

	// Token: 0x0601FEA3 RID: 130723 RVA: 0x00A8B77C File Offset: 0x00A8997C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEA4 RID: 130724 RVA: 0x00A8B7D4 File Offset: 0x00A899D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			memoryCorridorUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEA5 RID: 130725 RVA: 0x00A8B830 File Offset: 0x00A89A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEA6 RID: 130726 RVA: 0x00A8B888 File Offset: 0x00A89A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			memoryCorridorUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEA7 RID: 130727 RVA: 0x00A8B8E4 File Offset: 0x00A89AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEA8 RID: 130728 RVA: 0x00A8B93C File Offset: 0x00A89B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			memoryCorridorUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEA9 RID: 130729 RVA: 0x00A8B998 File Offset: 0x00A89B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_teamButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEAA RID: 130730 RVA: 0x00A8B9F0 File Offset: 0x00A89BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Button teamButton;
			LuaObject.checkType<Button>(l, 2, out teamButton);
			memoryCorridorUIController.m_luaExportHelper.m_teamButton = teamButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEAB RID: 130731 RVA: 0x00A8BA4C File Offset: 0x00A89C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_dailyRewardCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEAC RID: 130732 RVA: 0x00A8BAA4 File Offset: 0x00A89CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Text dailyRewardCountText;
			LuaObject.checkType<Text>(l, 2, out dailyRewardCountText);
			memoryCorridorUIController.m_luaExportHelper.m_dailyRewardCountText = dailyRewardCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEAD RID: 130733 RVA: 0x00A8BB00 File Offset: 0x00A89D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_levelListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEAE RID: 130734 RVA: 0x00A8BB58 File Offset: 0x00A89D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			ScrollRect levelListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out levelListScrollRect);
			memoryCorridorUIController.m_luaExportHelper.m_levelListScrollRect = levelListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEAF RID: 130735 RVA: 0x00A8BBB4 File Offset: 0x00A89DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGo(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_charGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEB0 RID: 130736 RVA: 0x00A8BC0C File Offset: 0x00A89E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGo(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			GameObject charGo;
			LuaObject.checkType<GameObject>(l, 2, out charGo);
			memoryCorridorUIController.m_luaExportHelper.m_charGo = charGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEB1 RID: 130737 RVA: 0x00A8BC68 File Offset: 0x00A89E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundImage(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_backgroundImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEB2 RID: 130738 RVA: 0x00A8BCC0 File Offset: 0x00A89EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundImage(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Image backgroundImage;
			LuaObject.checkType<Image>(l, 2, out backgroundImage);
			memoryCorridorUIController.m_luaExportHelper.m_backgroundImage = backgroundImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEB3 RID: 130739 RVA: 0x00A8BD1C File Offset: 0x00A89F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEB4 RID: 130740 RVA: 0x00A8BD74 File Offset: 0x00A89F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			memoryCorridorUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEB5 RID: 130741 RVA: 0x00A8BDD0 File Offset: 0x00A89FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEB6 RID: 130742 RVA: 0x00A8BE28 File Offset: 0x00A8A028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			memoryCorridorUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEB7 RID: 130743 RVA: 0x00A8BE84 File Offset: 0x00A8A084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryCorridorLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_memoryCorridorLevelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEB8 RID: 130744 RVA: 0x00A8BEDC File Offset: 0x00A8A0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryCorridorLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			GameObject memoryCorridorLevelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out memoryCorridorLevelListItemPrefab);
			memoryCorridorUIController.m_luaExportHelper.m_memoryCorridorLevelListItemPrefab = memoryCorridorLevelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEB9 RID: 130745 RVA: 0x00A8BF38 File Offset: 0x00A8A138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryCorridorLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_memoryCorridorLevelListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEBA RID: 130746 RVA: 0x00A8BF90 File Offset: 0x00A8A190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryCorridorLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			List<MemoryCorridorLevelListItemUIController> memoryCorridorLevelListItems;
			LuaObject.checkType<List<MemoryCorridorLevelListItemUIController>>(l, 2, out memoryCorridorLevelListItems);
			memoryCorridorUIController.m_luaExportHelper.m_memoryCorridorLevelListItems = memoryCorridorLevelListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEBB RID: 130747 RVA: 0x00A8BFEC File Offset: 0x00A8A1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorUIController.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEBC RID: 130748 RVA: 0x00A8C044 File Offset: 0x00A8A244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorUIController memoryCorridorUIController = (MemoryCorridorUIController)LuaObject.checkSelf(l);
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			memoryCorridorUIController.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FEBD RID: 130749 RVA: 0x00A8C0A0 File Offset: 0x00A8A2A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MemoryCorridorUIController");
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.SetMemoryCorridor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.AddAllMemoryCorridorLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.ClearMemoryCorridorLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.SetDailyRewardCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.AddMemoryCorridorLevelListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.OnAddTicketButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.OnTeamButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.MemoryCorridorLevelListItem_OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callDele_EventOnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__clearDele_EventOnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__clearDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__callDele_EventOnStartMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.__clearDele_EventOnStartMemoryCorridorLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache25);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache26, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache27, true);
		string name3 = "EventOnAddTicket";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_EventOnAddTicket);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache28, true);
		string name4 = "EventOnShowTeam";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_EventOnShowTeam);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache29, true);
		string name5 = "EventOnStartMemoryCorridorLevel";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_EventOnStartMemoryCorridorLevel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2A, true);
		string name6 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_uiStateController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2C, true);
		string name7 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_returnButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2E, true);
		string name8 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_helpButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache30, true);
		string name9 = "m_teamButton";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_teamButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_teamButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache32, true);
		string name10 = "m_dailyRewardCountText";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_dailyRewardCountText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_dailyRewardCountText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache34, true);
		string name11 = "m_levelListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_levelListScrollRect);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_levelListScrollRect);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache36, true);
		string name12 = "m_charGo";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_charGo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_charGo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache38, true);
		string name13 = "m_backgroundImage";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_backgroundImage);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_backgroundImage);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3A, true);
		string name14 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_nameText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3C, true);
		string name15 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3E, true);
		string name16 = "m_memoryCorridorLevelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_memoryCorridorLevelListItemPrefab);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_memoryCorridorLevelListItemPrefab);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache40, true);
		string name17 = "m_memoryCorridorLevelListItems";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_memoryCorridorLevelListItems);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_memoryCorridorLevelListItems);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache42, true);
		string name18 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.get_m_graphic);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.set_m_graphic);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.<>f__mg$cache44, true);
		LuaObject.createTypeMetatable(l, null, typeof(MemoryCorridorUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015E42 RID: 89666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015E43 RID: 89667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015E44 RID: 89668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015E45 RID: 89669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015E46 RID: 89670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015E47 RID: 89671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015E48 RID: 89672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015E49 RID: 89673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015E4A RID: 89674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015E4B RID: 89675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015E4C RID: 89676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015E4D RID: 89677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015E4E RID: 89678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015E4F RID: 89679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015E50 RID: 89680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015E51 RID: 89681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015E52 RID: 89682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015E53 RID: 89683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015E54 RID: 89684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015E55 RID: 89685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015E56 RID: 89686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015E57 RID: 89687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015E58 RID: 89688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015E59 RID: 89689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015E5A RID: 89690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015E5B RID: 89691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015E5C RID: 89692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015E5D RID: 89693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015E5E RID: 89694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015E5F RID: 89695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015E60 RID: 89696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015E61 RID: 89697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015E62 RID: 89698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015E63 RID: 89699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015E64 RID: 89700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015E65 RID: 89701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015E66 RID: 89702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015E67 RID: 89703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015E68 RID: 89704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015E69 RID: 89705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015E6A RID: 89706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015E6B RID: 89707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015E6C RID: 89708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015E6D RID: 89709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015E6E RID: 89710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015E6F RID: 89711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015E70 RID: 89712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015E71 RID: 89713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015E72 RID: 89714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015E73 RID: 89715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015E74 RID: 89716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015E75 RID: 89717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015E76 RID: 89718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015E77 RID: 89719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015E78 RID: 89720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015E79 RID: 89721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015E7A RID: 89722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015E7B RID: 89723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015E7C RID: 89724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015E7D RID: 89725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015E7E RID: 89726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04015E7F RID: 89727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04015E80 RID: 89728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015E81 RID: 89729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015E82 RID: 89730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04015E83 RID: 89731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04015E84 RID: 89732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04015E85 RID: 89733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04015E86 RID: 89734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;
}
