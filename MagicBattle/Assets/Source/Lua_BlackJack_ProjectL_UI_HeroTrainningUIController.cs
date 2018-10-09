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

// Token: 0x020014EC RID: 5356
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroTrainningUIController : LuaObject
{
	// Token: 0x0601F97B RID: 129403 RVA: 0x00A634D8 File Offset: 0x00A616D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F97C RID: 129404 RVA: 0x00A63524 File Offset: 0x00A61724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAllHeroTrainningLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			List<ConfigDataHeroTrainningLevelInfo> levelInfos;
			LuaObject.checkType<List<ConfigDataHeroTrainningLevelInfo>>(l, 2, out levelInfos);
			heroTrainningUIController.AddAllHeroTrainningLevelListItems(levelInfos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F97D RID: 129405 RVA: 0x00A6357C File Offset: 0x00A6177C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearHeroTrainningLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.ClearHeroTrainningLevelListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F97E RID: 129406 RVA: 0x00A635C8 File Offset: 0x00A617C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroTrainning(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningInfo heroTrainning;
			LuaObject.checkType<ConfigDataHeroTrainningInfo>(l, 2, out heroTrainning);
			heroTrainningUIController.SetHeroTrainning(heroTrainning);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F97F RID: 129407 RVA: 0x00A63620 File Offset: 0x00A61820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDailyRewardCount(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			int restCount;
			LuaObject.checkType(l, 2, out restCount);
			int allCount;
			LuaObject.checkType(l, 3, out allCount);
			heroTrainningUIController.SetDailyRewardCount(restCount, allCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F980 RID: 129408 RVA: 0x00A63684 File Offset: 0x00A61884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F981 RID: 129409 RVA: 0x00A636D8 File Offset: 0x00A618D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F982 RID: 129410 RVA: 0x00A6372C File Offset: 0x00A6192C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroTrainningLevelListItem(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo levelnfo;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out levelnfo);
			bool opened;
			LuaObject.checkType(l, 3, out opened);
			heroTrainningUIController.m_luaExportHelper.AddHeroTrainningLevelListItem(levelnfo, opened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F983 RID: 129411 RVA: 0x00A63798 File Offset: 0x00A61998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningInfo heroTrainningInfo;
			LuaObject.checkType<ConfigDataHeroTrainningInfo>(l, 2, out heroTrainningInfo);
			heroTrainningUIController.m_luaExportHelper.CreateSpineGraphic(heroTrainningInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F984 RID: 129412 RVA: 0x00A637F4 File Offset: 0x00A619F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.DestroySpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F985 RID: 129413 RVA: 0x00A63848 File Offset: 0x00A61A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F986 RID: 129414 RVA: 0x00A6389C File Offset: 0x00A61A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F987 RID: 129415 RVA: 0x00A638F0 File Offset: 0x00A61AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTeamButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.OnTeamButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F988 RID: 129416 RVA: 0x00A63944 File Offset: 0x00A61B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroTrainningLevelListItem_OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			HeroTrainningLevelListItemUIController ctrl;
			LuaObject.checkType<HeroTrainningLevelListItemUIController>(l, 2, out ctrl);
			heroTrainningUIController.m_luaExportHelper.HeroTrainningLevelListItem_OnStartButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F989 RID: 129417 RVA: 0x00A639A0 File Offset: 0x00A61BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroTrainningUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F98A RID: 129418 RVA: 0x00A63A0C File Offset: 0x00A61C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F98B RID: 129419 RVA: 0x00A63A60 File Offset: 0x00A61C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F98C RID: 129420 RVA: 0x00A63AB4 File Offset: 0x00A61CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroTrainningUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F98D RID: 129421 RVA: 0x00A63B5C File Offset: 0x00A61D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F98E RID: 129422 RVA: 0x00A63BB0 File Offset: 0x00A61DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroTrainningUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F98F RID: 129423 RVA: 0x00A63C1C File Offset: 0x00A61E1C
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
				HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroTrainningUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroTrainningUIController heroTrainningUIController2 = (HeroTrainningUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroTrainningUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F990 RID: 129424 RVA: 0x00A63D2C File Offset: 0x00A61F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroTrainningUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F991 RID: 129425 RVA: 0x00A63D98 File Offset: 0x00A61F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroTrainningUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F992 RID: 129426 RVA: 0x00A63E04 File Offset: 0x00A62004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroTrainningUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F993 RID: 129427 RVA: 0x00A63E70 File Offset: 0x00A62070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroTrainningUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F994 RID: 129428 RVA: 0x00A63EDC File Offset: 0x00A620DC
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
				HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroTrainningUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroTrainningUIController heroTrainningUIController2 = (HeroTrainningUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroTrainningUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F995 RID: 129429 RVA: 0x00A63FEC File Offset: 0x00A621EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			string s = heroTrainningUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F996 RID: 129430 RVA: 0x00A64048 File Offset: 0x00A62248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F997 RID: 129431 RVA: 0x00A6409C File Offset: 0x00A6229C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F998 RID: 129432 RVA: 0x00A640F0 File Offset: 0x00A622F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F999 RID: 129433 RVA: 0x00A64144 File Offset: 0x00A62344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F99A RID: 129434 RVA: 0x00A64198 File Offset: 0x00A62398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.__callDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F99B RID: 129435 RVA: 0x00A641EC File Offset: 0x00A623EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			heroTrainningUIController.m_luaExportHelper.__clearDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F99C RID: 129436 RVA: 0x00A64240 File Offset: 0x00A62440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo obj;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out obj);
			heroTrainningUIController.m_luaExportHelper.__callDele_EventOnStartHeroTrainningLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F99D RID: 129437 RVA: 0x00A6429C File Offset: 0x00A6249C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			ConfigDataHeroTrainningLevelInfo obj;
			LuaObject.checkType<ConfigDataHeroTrainningLevelInfo>(l, 2, out obj);
			heroTrainningUIController.m_luaExportHelper.__clearDele_EventOnStartHeroTrainningLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F99E RID: 129438 RVA: 0x00A642F8 File Offset: 0x00A624F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroTrainningUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroTrainningUIController.EventOnReturn -= value;
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

	// Token: 0x0601F99F RID: 129439 RVA: 0x00A64378 File Offset: 0x00A62578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroTrainningUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					heroTrainningUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601F9A0 RID: 129440 RVA: 0x00A643F8 File Offset: 0x00A625F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroTrainningUIController.EventOnShowTeam += value;
				}
				else if (num == 2)
				{
					heroTrainningUIController.EventOnShowTeam -= value;
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

	// Token: 0x0601F9A1 RID: 129441 RVA: 0x00A64478 File Offset: 0x00A62678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartHeroTrainningLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			Action<ConfigDataHeroTrainningLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataHeroTrainningLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroTrainningUIController.EventOnStartHeroTrainningLevel += value;
				}
				else if (num == 2)
				{
					heroTrainningUIController.EventOnStartHeroTrainningLevel -= value;
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

	// Token: 0x0601F9A2 RID: 129442 RVA: 0x00A644F8 File Offset: 0x00A626F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9A3 RID: 129443 RVA: 0x00A64550 File Offset: 0x00A62750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			heroTrainningUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9A4 RID: 129444 RVA: 0x00A645AC File Offset: 0x00A627AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9A5 RID: 129445 RVA: 0x00A64604 File Offset: 0x00A62804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroTrainningUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9A6 RID: 129446 RVA: 0x00A64660 File Offset: 0x00A62860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9A7 RID: 129447 RVA: 0x00A646B8 File Offset: 0x00A628B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			heroTrainningUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9A8 RID: 129448 RVA: 0x00A64714 File Offset: 0x00A62914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_teamButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9A9 RID: 129449 RVA: 0x00A6476C File Offset: 0x00A6296C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			Button teamButton;
			LuaObject.checkType<Button>(l, 2, out teamButton);
			heroTrainningUIController.m_luaExportHelper.m_teamButton = teamButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9AA RID: 129450 RVA: 0x00A647C8 File Offset: 0x00A629C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGo(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_charGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9AB RID: 129451 RVA: 0x00A64820 File Offset: 0x00A62A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGo(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			GameObject charGo;
			LuaObject.checkType<GameObject>(l, 2, out charGo);
			heroTrainningUIController.m_luaExportHelper.m_charGo = charGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9AC RID: 129452 RVA: 0x00A6487C File Offset: 0x00A62A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_levelListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9AD RID: 129453 RVA: 0x00A648D4 File Offset: 0x00A62AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			ScrollRect levelListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out levelListScrollRect);
			heroTrainningUIController.m_luaExportHelper.m_levelListScrollRect = levelListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9AE RID: 129454 RVA: 0x00A64930 File Offset: 0x00A62B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_dailyRewardCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9AF RID: 129455 RVA: 0x00A64988 File Offset: 0x00A62B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			Text dailyRewardCountText;
			LuaObject.checkType<Text>(l, 2, out dailyRewardCountText);
			heroTrainningUIController.m_luaExportHelper.m_dailyRewardCountText = dailyRewardCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9B0 RID: 129456 RVA: 0x00A649E4 File Offset: 0x00A62BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9B1 RID: 129457 RVA: 0x00A64A3C File Offset: 0x00A62C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			heroTrainningUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9B2 RID: 129458 RVA: 0x00A64A98 File Offset: 0x00A62C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTrainningLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_heroTrainningLevelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9B3 RID: 129459 RVA: 0x00A64AF0 File Offset: 0x00A62CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTrainningLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			GameObject heroTrainningLevelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroTrainningLevelListItemPrefab);
			heroTrainningUIController.m_luaExportHelper.m_heroTrainningLevelListItemPrefab = heroTrainningLevelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9B4 RID: 129460 RVA: 0x00A64B4C File Offset: 0x00A62D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9B5 RID: 129461 RVA: 0x00A64BA4 File Offset: 0x00A62DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			heroTrainningUIController.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9B6 RID: 129462 RVA: 0x00A64C00 File Offset: 0x00A62E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTrainningLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroTrainningUIController.m_luaExportHelper.m_heroTrainningLevelListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9B7 RID: 129463 RVA: 0x00A64C58 File Offset: 0x00A62E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTrainningLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroTrainningUIController heroTrainningUIController = (HeroTrainningUIController)LuaObject.checkSelf(l);
			List<HeroTrainningLevelListItemUIController> heroTrainningLevelListItems;
			LuaObject.checkType<List<HeroTrainningLevelListItemUIController>>(l, 2, out heroTrainningLevelListItems);
			heroTrainningUIController.m_luaExportHelper.m_heroTrainningLevelListItems = heroTrainningLevelListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9B8 RID: 129464 RVA: 0x00A64CB4 File Offset: 0x00A62EB4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroTrainningUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.AddAllHeroTrainningLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.ClearHeroTrainningLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.SetHeroTrainning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.SetDailyRewardCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.AddHeroTrainningLevelListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.OnTeamButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.HeroTrainningLevelListItem_OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__clearDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__callDele_EventOnStartHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.__clearDele_EventOnStartHeroTrainningLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache22);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache23, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache24, true);
		string name3 = "EventOnShowTeam";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_EventOnShowTeam);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache25, true);
		string name4 = "EventOnStartHeroTrainningLevel";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_EventOnStartHeroTrainningLevel);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache26, true);
		string name5 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_uiStateController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache28, true);
		string name6 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_returnButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2A, true);
		string name7 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_helpButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2C, true);
		string name8 = "m_teamButton";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_teamButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_teamButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2E, true);
		string name9 = "m_charGo";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_charGo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_charGo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache30, true);
		string name10 = "m_levelListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_levelListScrollRect);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_levelListScrollRect);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache32, true);
		string name11 = "m_dailyRewardCountText";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_dailyRewardCountText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_dailyRewardCountText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache34, true);
		string name12 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache36, true);
		string name13 = "m_heroTrainningLevelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_heroTrainningLevelListItemPrefab);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_heroTrainningLevelListItemPrefab);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache38, true);
		string name14 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_graphic);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_graphic);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3A, true);
		string name15 = "m_heroTrainningLevelListItems";
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.get_m_heroTrainningLevelListItems);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.set_m_heroTrainningLevelListItems);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.<>f__mg$cache3C, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroTrainningUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015985 RID: 88453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015986 RID: 88454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015987 RID: 88455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015988 RID: 88456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015989 RID: 88457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401598A RID: 88458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401598B RID: 88459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401598C RID: 88460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401598D RID: 88461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401598E RID: 88462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401598F RID: 88463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015990 RID: 88464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015991 RID: 88465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015992 RID: 88466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015993 RID: 88467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015994 RID: 88468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015995 RID: 88469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015996 RID: 88470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015997 RID: 88471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015998 RID: 88472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015999 RID: 88473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401599A RID: 88474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401599B RID: 88475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401599C RID: 88476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401599D RID: 88477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401599E RID: 88478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401599F RID: 88479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040159A0 RID: 88480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040159A1 RID: 88481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040159A2 RID: 88482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040159A3 RID: 88483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040159A4 RID: 88484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040159A5 RID: 88485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040159A6 RID: 88486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040159A7 RID: 88487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040159A8 RID: 88488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040159A9 RID: 88489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040159AA RID: 88490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040159AB RID: 88491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040159AC RID: 88492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040159AD RID: 88493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040159AE RID: 88494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040159AF RID: 88495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040159B0 RID: 88496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040159B1 RID: 88497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040159B2 RID: 88498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040159B3 RID: 88499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040159B4 RID: 88500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040159B5 RID: 88501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040159B6 RID: 88502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040159B7 RID: 88503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040159B8 RID: 88504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040159B9 RID: 88505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040159BA RID: 88506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040159BB RID: 88507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040159BC RID: 88508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040159BD RID: 88509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040159BE RID: 88510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040159BF RID: 88511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040159C0 RID: 88512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040159C1 RID: 88513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;
}
