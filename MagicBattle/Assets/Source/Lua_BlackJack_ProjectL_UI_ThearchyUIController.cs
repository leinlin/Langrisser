using System;
using System.Collections;
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

// Token: 0x020015B2 RID: 5554
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ThearchyUIController : LuaObject
{
	// Token: 0x06021B8E RID: 138126 RVA: 0x00B72BE0 File Offset: 0x00B70DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B8F RID: 138127 RVA: 0x00B72C2C File Offset: 0x00B70E2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetThearchy(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialInfo thearchy;
			LuaObject.checkType<ConfigDataThearchyTrialInfo>(l, 2, out thearchy);
			thearchyUIController.SetThearchy(thearchy);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B90 RID: 138128 RVA: 0x00B72C84 File Offset: 0x00B70E84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetAllThearchyLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			List<ConfigDataThearchyTrialLevelInfo> allThearchyLevelListItems;
			LuaObject.checkType<List<ConfigDataThearchyTrialLevelInfo>>(l, 2, out allThearchyLevelListItems);
			thearchyUIController.SetAllThearchyLevelListItems(allThearchyLevelListItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B91 RID: 138129 RVA: 0x00B72CDC File Offset: 0x00B70EDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDailyRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			int restCount;
			LuaObject.checkType(l, 2, out restCount);
			int allCount;
			LuaObject.checkType(l, 3, out allCount);
			thearchyUIController.SetDailyRewardCount(restCount, allCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B92 RID: 138130 RVA: 0x00B72D40 File Offset: 0x00B70F40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B93 RID: 138131 RVA: 0x00B72D94 File Offset: 0x00B70F94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B94 RID: 138132 RVA: 0x00B72DE8 File Offset: 0x00B70FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddThearchyLevelListItem(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo levelnfo;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out levelnfo);
			bool opened;
			LuaObject.checkType(l, 3, out opened);
			thearchyUIController.m_luaExportHelper.AddThearchyLevelListItem(levelnfo, opened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B95 RID: 138133 RVA: 0x00B72E54 File Offset: 0x00B71054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearThearchyLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.ClearThearchyLevelListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B96 RID: 138134 RVA: 0x00B72EA8 File Offset: 0x00B710A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B97 RID: 138135 RVA: 0x00B72EFC File Offset: 0x00B710FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B98 RID: 138136 RVA: 0x00B72F50 File Offset: 0x00B71150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddTicketButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.OnAddTicketButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B99 RID: 138137 RVA: 0x00B72FA4 File Offset: 0x00B711A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTeamButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.OnTeamButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B9A RID: 138138 RVA: 0x00B72FF8 File Offset: 0x00B711F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ThearchyLevelListItem_OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			ThearchyLevelListItemUIController b;
			LuaObject.checkType<ThearchyLevelListItemUIController>(l, 2, out b);
			thearchyUIController.m_luaExportHelper.ThearchyLevelListItem_OnStartButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B9B RID: 138139 RVA: 0x00B73054 File Offset: 0x00B71254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayGodModelSingEffect(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			ThearchyLevelListItemUIController b;
			LuaObject.checkType<ThearchyLevelListItemUIController>(l, 2, out b);
			IEnumerator o = thearchyUIController.m_luaExportHelper.PlayGodModelSingEffect(b);
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

	// Token: 0x06021B9C RID: 138140 RVA: 0x00B730BC File Offset: 0x00B712BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialInfo thearchyInfo;
			LuaObject.checkType<ConfigDataThearchyTrialInfo>(l, 2, out thearchyInfo);
			thearchyUIController.m_luaExportHelper.CreateSpineGraphic(thearchyInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B9D RID: 138141 RVA: 0x00B73118 File Offset: 0x00B71318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.DestroySpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B9E RID: 138142 RVA: 0x00B7316C File Offset: 0x00B7136C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateBackgroundFx(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialInfo thearchyInfo;
			LuaObject.checkType<ConfigDataThearchyTrialInfo>(l, 2, out thearchyInfo);
			thearchyUIController.m_luaExportHelper.CreateBackgroundFx(thearchyInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B9F RID: 138143 RVA: 0x00B731C8 File Offset: 0x00B713C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyBackgroundFx(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.DestroyBackgroundFx();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BA0 RID: 138144 RVA: 0x00B7321C File Offset: 0x00B7141C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			thearchyUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BA1 RID: 138145 RVA: 0x00B73288 File Offset: 0x00B71488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BA2 RID: 138146 RVA: 0x00B732DC File Offset: 0x00B714DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BA3 RID: 138147 RVA: 0x00B73330 File Offset: 0x00B71530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = thearchyUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021BA4 RID: 138148 RVA: 0x00B733D8 File Offset: 0x00B715D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BA5 RID: 138149 RVA: 0x00B7342C File Offset: 0x00B7162C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			thearchyUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BA6 RID: 138150 RVA: 0x00B73498 File Offset: 0x00B71698
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
				ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				thearchyUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ThearchyUIController thearchyUIController2 = (ThearchyUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				thearchyUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021BA7 RID: 138151 RVA: 0x00B735A8 File Offset: 0x00B717A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			thearchyUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BA8 RID: 138152 RVA: 0x00B73614 File Offset: 0x00B71814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			thearchyUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BA9 RID: 138153 RVA: 0x00B73680 File Offset: 0x00B71880
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			thearchyUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BAA RID: 138154 RVA: 0x00B736EC File Offset: 0x00B718EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			thearchyUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BAB RID: 138155 RVA: 0x00B73758 File Offset: 0x00B71958
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
				ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				thearchyUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ThearchyUIController thearchyUIController2 = (ThearchyUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				thearchyUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021BAC RID: 138156 RVA: 0x00B73868 File Offset: 0x00B71A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			string s = thearchyUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021BAD RID: 138157 RVA: 0x00B738C4 File Offset: 0x00B71AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BAE RID: 138158 RVA: 0x00B73918 File Offset: 0x00B71B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BAF RID: 138159 RVA: 0x00B7396C File Offset: 0x00B71B6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BB0 RID: 138160 RVA: 0x00B739C0 File Offset: 0x00B71BC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BB1 RID: 138161 RVA: 0x00B73A14 File Offset: 0x00B71C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__callDele_EventOnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BB2 RID: 138162 RVA: 0x00B73A68 File Offset: 0x00B71C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__clearDele_EventOnAddTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BB3 RID: 138163 RVA: 0x00B73ABC File Offset: 0x00B71CBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__callDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BB4 RID: 138164 RVA: 0x00B73B10 File Offset: 0x00B71D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			thearchyUIController.m_luaExportHelper.__clearDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BB5 RID: 138165 RVA: 0x00B73B64 File Offset: 0x00B71D64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnStartThearchyLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo obj;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out obj);
			thearchyUIController.m_luaExportHelper.__callDele_EventOnStartThearchyLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BB6 RID: 138166 RVA: 0x00B73BC0 File Offset: 0x00B71DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartThearchyLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			ConfigDataThearchyTrialLevelInfo obj;
			LuaObject.checkType<ConfigDataThearchyTrialLevelInfo>(l, 2, out obj);
			thearchyUIController.m_luaExportHelper.__clearDele_EventOnStartThearchyLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BB7 RID: 138167 RVA: 0x00B73C1C File Offset: 0x00B71E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					thearchyUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					thearchyUIController.EventOnReturn -= value;
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

	// Token: 0x06021BB8 RID: 138168 RVA: 0x00B73C9C File Offset: 0x00B71E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					thearchyUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					thearchyUIController.EventOnShowHelp -= value;
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

	// Token: 0x06021BB9 RID: 138169 RVA: 0x00B73D1C File Offset: 0x00B71F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddTicket(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					thearchyUIController.EventOnAddTicket += value;
				}
				else if (num == 2)
				{
					thearchyUIController.EventOnAddTicket -= value;
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

	// Token: 0x06021BBA RID: 138170 RVA: 0x00B73D9C File Offset: 0x00B71F9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					thearchyUIController.EventOnShowTeam += value;
				}
				else if (num == 2)
				{
					thearchyUIController.EventOnShowTeam -= value;
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

	// Token: 0x06021BBB RID: 138171 RVA: 0x00B73E1C File Offset: 0x00B7201C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartThearchyLevel(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Action<ConfigDataThearchyTrialLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataThearchyTrialLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					thearchyUIController.EventOnStartThearchyLevel += value;
				}
				else if (num == 2)
				{
					thearchyUIController.EventOnStartThearchyLevel -= value;
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

	// Token: 0x06021BBC RID: 138172 RVA: 0x00B73E9C File Offset: 0x00B7209C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BBD RID: 138173 RVA: 0x00B73EF4 File Offset: 0x00B720F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			thearchyUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BBE RID: 138174 RVA: 0x00B73F50 File Offset: 0x00B72150
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BBF RID: 138175 RVA: 0x00B73FA8 File Offset: 0x00B721A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			thearchyUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BC0 RID: 138176 RVA: 0x00B74004 File Offset: 0x00B72204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BC1 RID: 138177 RVA: 0x00B7405C File Offset: 0x00B7225C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			thearchyUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BC2 RID: 138178 RVA: 0x00B740B8 File Offset: 0x00B722B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_teamButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BC3 RID: 138179 RVA: 0x00B74110 File Offset: 0x00B72310
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Button teamButton;
			LuaObject.checkType<Button>(l, 2, out teamButton);
			thearchyUIController.m_luaExportHelper.m_teamButton = teamButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BC4 RID: 138180 RVA: 0x00B7416C File Offset: 0x00B7236C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_dailyRewardCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BC5 RID: 138181 RVA: 0x00B741C4 File Offset: 0x00B723C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Text dailyRewardCountText;
			LuaObject.checkType<Text>(l, 2, out dailyRewardCountText);
			thearchyUIController.m_luaExportHelper.m_dailyRewardCountText = dailyRewardCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BC6 RID: 138182 RVA: 0x00B74220 File Offset: 0x00B72420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_levelListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BC7 RID: 138183 RVA: 0x00B74278 File Offset: 0x00B72478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			ScrollRect levelListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out levelListScrollRect);
			thearchyUIController.m_luaExportHelper.m_levelListScrollRect = levelListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BC8 RID: 138184 RVA: 0x00B742D4 File Offset: 0x00B724D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_charGo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_charGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BC9 RID: 138185 RVA: 0x00B7432C File Offset: 0x00B7252C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_charGo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			GameObject charGo;
			LuaObject.checkType<GameObject>(l, 2, out charGo);
			thearchyUIController.m_luaExportHelper.m_charGo = charGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BCA RID: 138186 RVA: 0x00B74388 File Offset: 0x00B72588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxGo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_fxGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BCB RID: 138187 RVA: 0x00B743E0 File Offset: 0x00B725E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxGo(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			GameObject fxGo;
			LuaObject.checkType<GameObject>(l, 2, out fxGo);
			thearchyUIController.m_luaExportHelper.m_fxGo = fxGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BCC RID: 138188 RVA: 0x00B7443C File Offset: 0x00B7263C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_armyPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_armyPanelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BCD RID: 138189 RVA: 0x00B74494 File Offset: 0x00B72694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyPanelGameObject(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			GameObject armyPanelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out armyPanelGameObject);
			thearchyUIController.m_luaExportHelper.m_armyPanelGameObject = armyPanelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BCE RID: 138190 RVA: 0x00B744F0 File Offset: 0x00B726F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_armyPanelGroup(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_armyPanelGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BCF RID: 138191 RVA: 0x00B74548 File Offset: 0x00B72748
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_armyPanelGroup(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			Transform armyPanelGroup;
			LuaObject.checkType<Transform>(l, 2, out armyPanelGroup);
			thearchyUIController.m_luaExportHelper.m_armyPanelGroup = armyPanelGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BD0 RID: 138192 RVA: 0x00B745A4 File Offset: 0x00B727A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BD1 RID: 138193 RVA: 0x00B745FC File Offset: 0x00B727FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			thearchyUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BD2 RID: 138194 RVA: 0x00B74658 File Offset: 0x00B72858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ThearchyLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_ThearchyLevelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BD3 RID: 138195 RVA: 0x00B746B0 File Offset: 0x00B728B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ThearchyLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			GameObject thearchyLevelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out thearchyLevelListItemPrefab);
			thearchyUIController.m_luaExportHelper.m_ThearchyLevelListItemPrefab = thearchyLevelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BD4 RID: 138196 RVA: 0x00B7470C File Offset: 0x00B7290C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_thearchyLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_thearchyLevelListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BD5 RID: 138197 RVA: 0x00B74764 File Offset: 0x00B72964
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_thearchyLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			List<ThearchyLevelListItemUIController> thearchyLevelListItems;
			LuaObject.checkType<List<ThearchyLevelListItemUIController>>(l, 2, out thearchyLevelListItems);
			thearchyUIController.m_luaExportHelper.m_thearchyLevelListItems = thearchyLevelListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BD6 RID: 138198 RVA: 0x00B747C0 File Offset: 0x00B729C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BD7 RID: 138199 RVA: 0x00B74818 File Offset: 0x00B72A18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			thearchyUIController.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BD8 RID: 138200 RVA: 0x00B74874 File Offset: 0x00B72A74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_backgroundFxGameObject(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyUIController.m_luaExportHelper.m_backgroundFxGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BD9 RID: 138201 RVA: 0x00B748CC File Offset: 0x00B72ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundFxGameObject(IntPtr l)
	{
		int result;
		try
		{
			ThearchyUIController thearchyUIController = (ThearchyUIController)LuaObject.checkSelf(l);
			GameObject backgroundFxGameObject;
			LuaObject.checkType<GameObject>(l, 2, out backgroundFxGameObject);
			thearchyUIController.m_luaExportHelper.m_backgroundFxGameObject = backgroundFxGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021BDA RID: 138202 RVA: 0x00B74928 File Offset: 0x00B72B28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ThearchyUIController");
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.SetThearchy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.SetAllThearchyLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.SetDailyRewardCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.AddThearchyLevelListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.ClearThearchyLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.OnAddTicketButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.OnTeamButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.ThearchyLevelListItem_OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.PlayGodModelSingEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.CreateBackgroundFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.DestroyBackgroundFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callDele_EventOnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__clearDele_EventOnAddTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__clearDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__callDele_EventOnStartThearchyLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.__clearDele_EventOnStartThearchyLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache28);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache29, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2A, true);
		string name3 = "EventOnAddTicket";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_EventOnAddTicket);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2B, true);
		string name4 = "EventOnShowTeam";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_EventOnShowTeam);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2C, true);
		string name5 = "EventOnStartThearchyLevel";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_EventOnStartThearchyLevel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2D, true);
		string name6 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_uiStateController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache2F, true);
		string name7 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_returnButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache31, true);
		string name8 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_helpButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache33, true);
		string name9 = "m_teamButton";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_teamButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_teamButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache35, true);
		string name10 = "m_dailyRewardCountText";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_dailyRewardCountText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_dailyRewardCountText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache37, true);
		string name11 = "m_levelListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_levelListScrollRect);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_levelListScrollRect);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache39, true);
		string name12 = "m_charGo";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_charGo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_charGo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3B, true);
		string name13 = "m_fxGo";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_fxGo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_fxGo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3D, true);
		string name14 = "m_armyPanelGameObject";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_armyPanelGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_armyPanelGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache3F, true);
		string name15 = "m_armyPanelGroup";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_armyPanelGroup);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_armyPanelGroup);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache41, true);
		string name16 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache43, true);
		string name17 = "m_ThearchyLevelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_ThearchyLevelListItemPrefab);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_ThearchyLevelListItemPrefab);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache45, true);
		string name18 = "m_thearchyLevelListItems";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_thearchyLevelListItems);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_thearchyLevelListItems);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache47, true);
		string name19 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_graphic);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_graphic);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache49, true);
		string name20 = "m_backgroundFxGameObject";
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.get_m_backgroundFxGameObject);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyUIController.set_m_backgroundFxGameObject);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ThearchyUIController.<>f__mg$cache4B, true);
		LuaObject.createTypeMetatable(l, null, typeof(ThearchyUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017A0C RID: 96780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017A0D RID: 96781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017A0E RID: 96782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017A0F RID: 96783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017A10 RID: 96784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017A11 RID: 96785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017A12 RID: 96786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017A13 RID: 96787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017A14 RID: 96788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017A15 RID: 96789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017A16 RID: 96790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017A17 RID: 96791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017A18 RID: 96792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017A19 RID: 96793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017A1A RID: 96794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017A1B RID: 96795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017A1C RID: 96796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017A1D RID: 96797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017A1E RID: 96798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017A1F RID: 96799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017A20 RID: 96800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017A21 RID: 96801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017A22 RID: 96802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017A23 RID: 96803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017A24 RID: 96804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017A25 RID: 96805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017A26 RID: 96806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017A27 RID: 96807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017A28 RID: 96808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017A29 RID: 96809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017A2A RID: 96810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017A2B RID: 96811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017A2C RID: 96812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017A2D RID: 96813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017A2E RID: 96814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017A2F RID: 96815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017A30 RID: 96816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017A31 RID: 96817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017A32 RID: 96818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017A33 RID: 96819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017A34 RID: 96820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017A35 RID: 96821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017A36 RID: 96822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017A37 RID: 96823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017A38 RID: 96824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017A39 RID: 96825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017A3A RID: 96826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017A3B RID: 96827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017A3C RID: 96828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017A3D RID: 96829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017A3E RID: 96830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017A3F RID: 96831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017A40 RID: 96832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017A41 RID: 96833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017A42 RID: 96834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017A43 RID: 96835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017A44 RID: 96836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017A45 RID: 96837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017A46 RID: 96838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017A47 RID: 96839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017A48 RID: 96840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017A49 RID: 96841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017A4A RID: 96842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017A4B RID: 96843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017A4C RID: 96844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017A4D RID: 96845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017A4E RID: 96846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04017A4F RID: 96847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04017A50 RID: 96848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04017A51 RID: 96849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04017A52 RID: 96850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017A53 RID: 96851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017A54 RID: 96852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017A55 RID: 96853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017A56 RID: 96854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017A57 RID: 96855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;
}
