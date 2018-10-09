using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001441 RID: 5185
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersUIController : LuaObject
{
	// Token: 0x0601DDAD RID: 122285 RVA: 0x009868F8 File Offset: 0x00984AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInFetters(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUIController.UpdateViewInFetters(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDAE RID: 122286 RVA: 0x00986950 File Offset: 0x00984B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoToInformationPanel(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			bool isGotoOrReturn;
			LuaObject.checkType(l, 2, out isGotoOrReturn);
			fettersUIController.GoToInformationPanel(isGotoOrReturn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDAF RID: 122287 RVA: 0x009869A8 File Offset: 0x00984BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayHeroPerformance(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			fettersUIController.PlayHeroPerformance(heroPerformanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDB0 RID: 122288 RVA: 0x00986A00 File Offset: 0x00984C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDB1 RID: 122289 RVA: 0x00986A54 File Offset: 0x00984C54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDB2 RID: 122290 RVA: 0x00986AA8 File Offset: 0x00984CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnListItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUIController.m_luaExportHelper.OnListItemClick(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDB3 RID: 122291 RVA: 0x00986B04 File Offset: 0x00984D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListItemCompare(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Hero h;
			LuaObject.checkType<Hero>(l, 2, out h);
			Hero h2;
			LuaObject.checkType<Hero>(l, 3, out h2);
			int i = fettersUIController.m_luaExportHelper.HeroListItemCompare(h, h2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDB4 RID: 122292 RVA: 0x00986B78 File Offset: 0x00984D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDB5 RID: 122293 RVA: 0x00986BCC File Offset: 0x00984DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDB6 RID: 122294 RVA: 0x00986C20 File Offset: 0x00984E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInformationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.OnInformationButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDB7 RID: 122295 RVA: 0x00986C74 File Offset: 0x00984E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFettersButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.OnFettersButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDB8 RID: 122296 RVA: 0x00986CC8 File Offset: 0x00984EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewPosition(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.ResetScrollViewPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDB9 RID: 122297 RVA: 0x00986D1C File Offset: 0x00984F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDBA RID: 122298 RVA: 0x00986D88 File Offset: 0x00984F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDBB RID: 122299 RVA: 0x00986DDC File Offset: 0x00984FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDBC RID: 122300 RVA: 0x00986E30 File Offset: 0x00985030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DDBD RID: 122301 RVA: 0x00986ED8 File Offset: 0x009850D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDBE RID: 122302 RVA: 0x00986F2C File Offset: 0x0098512C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDBF RID: 122303 RVA: 0x00986F98 File Offset: 0x00985198
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
				FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersUIController fettersUIController2 = (FettersUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DDC0 RID: 122304 RVA: 0x009870A8 File Offset: 0x009852A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDC1 RID: 122305 RVA: 0x00987114 File Offset: 0x00985314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDC2 RID: 122306 RVA: 0x00987180 File Offset: 0x00985380
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDC3 RID: 122307 RVA: 0x009871EC File Offset: 0x009853EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDC4 RID: 122308 RVA: 0x00987258 File Offset: 0x00985458
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
				FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersUIController fettersUIController2 = (FettersUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DDC5 RID: 122309 RVA: 0x00987368 File Offset: 0x00985568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			string s = fettersUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DDC6 RID: 122310 RVA: 0x009873C4 File Offset: 0x009855C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDC7 RID: 122311 RVA: 0x00987418 File Offset: 0x00985618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDC8 RID: 122312 RVA: 0x0098746C File Offset: 0x0098566C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDC9 RID: 122313 RVA: 0x009874C0 File Offset: 0x009856C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			fettersUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDCA RID: 122314 RVA: 0x00987514 File Offset: 0x00985714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnListItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersUIController.m_luaExportHelper.__callDele_EventOnListItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDCB RID: 122315 RVA: 0x00987570 File Offset: 0x00985770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnListItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersUIController.m_luaExportHelper.__clearDele_EventOnListItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDCC RID: 122316 RVA: 0x009875CC File Offset: 0x009857CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnFettersButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersUIController.m_luaExportHelper.__callDele_EventOnFettersButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDCD RID: 122317 RVA: 0x00987628 File Offset: 0x00985828
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnFettersButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersUIController.m_luaExportHelper.__clearDele_EventOnFettersButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDCE RID: 122318 RVA: 0x00987684 File Offset: 0x00985884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnInformationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersUIController.m_luaExportHelper.__callDele_EventOnInformationButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDCF RID: 122319 RVA: 0x009876E0 File Offset: 0x009858E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnInformationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersUIController.m_luaExportHelper.__clearDele_EventOnInformationButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDD0 RID: 122320 RVA: 0x0098773C File Offset: 0x0098593C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					fettersUIController.EventOnReturn -= value;
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

	// Token: 0x0601DDD1 RID: 122321 RVA: 0x009877BC File Offset: 0x009859BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					fettersUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601DDD2 RID: 122322 RVA: 0x0098783C File Offset: 0x00985A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnListItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Action<Hero> value;
			int num = LuaObject.checkDelegate<Action<Hero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersUIController.EventOnListItemClick += value;
				}
				else if (num == 2)
				{
					fettersUIController.EventOnListItemClick -= value;
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

	// Token: 0x0601DDD3 RID: 122323 RVA: 0x009878BC File Offset: 0x00985ABC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnFettersButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Action<Hero> value;
			int num = LuaObject.checkDelegate<Action<Hero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersUIController.EventOnFettersButtonClick += value;
				}
				else if (num == 2)
				{
					fettersUIController.EventOnFettersButtonClick -= value;
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

	// Token: 0x0601DDD4 RID: 122324 RVA: 0x0098793C File Offset: 0x00985B3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnInformationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Action<Hero> value;
			int num = LuaObject.checkDelegate<Action<Hero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersUIController.EventOnInformationButtonClick += value;
				}
				else if (num == 2)
				{
					fettersUIController.EventOnInformationButtonClick -= value;
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

	// Token: 0x0601DDD5 RID: 122325 RVA: 0x009879BC File Offset: 0x00985BBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDD6 RID: 122326 RVA: 0x00987A14 File Offset: 0x00985C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			fettersUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDD7 RID: 122327 RVA: 0x00987A70 File Offset: 0x00985C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_commonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_commonUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDD8 RID: 122328 RVA: 0x00987AC8 File Offset: 0x00985CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			CommonUIStateController commonUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out commonUIStateCtrl);
			fettersUIController.m_luaExportHelper.m_commonUIStateCtrl = commonUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDD9 RID: 122329 RVA: 0x00987B24 File Offset: 0x00985D24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDDA RID: 122330 RVA: 0x00987B7C File Offset: 0x00985D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			fettersUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDDB RID: 122331 RVA: 0x00987BD8 File Offset: 0x00985DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDDC RID: 122332 RVA: 0x00987C30 File Offset: 0x00985E30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			fettersUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDDD RID: 122333 RVA: 0x00987C8C File Offset: 0x00985E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fettersButton(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_fettersButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDDE RID: 122334 RVA: 0x00987CE4 File Offset: 0x00985EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fettersButton(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Button fettersButton;
			LuaObject.checkType<Button>(l, 2, out fettersButton);
			fettersUIController.m_luaExportHelper.m_fettersButton = fettersButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDDF RID: 122335 RVA: 0x00987D40 File Offset: 0x00985F40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_fettersButtonNewImage(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_fettersButtonNewImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDE0 RID: 122336 RVA: 0x00987D98 File Offset: 0x00985F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fettersButtonNewImage(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			GameObject fettersButtonNewImage;
			LuaObject.checkType<GameObject>(l, 2, out fettersButtonNewImage);
			fettersUIController.m_luaExportHelper.m_fettersButtonNewImage = fettersButtonNewImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDE1 RID: 122337 RVA: 0x00987DF4 File Offset: 0x00985FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fettersButtonPercentText(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_fettersButtonPercentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDE2 RID: 122338 RVA: 0x00987E4C File Offset: 0x0098604C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fettersButtonPercentText(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Text fettersButtonPercentText;
			LuaObject.checkType<Text>(l, 2, out fettersButtonPercentText);
			fettersUIController.m_luaExportHelper.m_fettersButtonPercentText = fettersButtonPercentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDE3 RID: 122339 RVA: 0x00987EA8 File Offset: 0x009860A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_informationButton(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_informationButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDE4 RID: 122340 RVA: 0x00987F00 File Offset: 0x00986100
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_informationButton(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Button informationButton;
			LuaObject.checkType<Button>(l, 2, out informationButton);
			fettersUIController.m_luaExportHelper.m_informationButton = informationButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDE5 RID: 122341 RVA: 0x00987F5C File Offset: 0x0098615C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_informationButtonNewImage(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_informationButtonNewImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDE6 RID: 122342 RVA: 0x00987FB4 File Offset: 0x009861B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_informationButtonNewImage(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			GameObject informationButtonNewImage;
			LuaObject.checkType<GameObject>(l, 2, out informationButtonNewImage);
			fettersUIController.m_luaExportHelper.m_informationButtonNewImage = informationButtonNewImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDE7 RID: 122343 RVA: 0x00988010 File Offset: 0x00986210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_favorabilityTotalValueText(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_favorabilityTotalValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDE8 RID: 122344 RVA: 0x00988068 File Offset: 0x00986268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_favorabilityTotalValueText(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Text favorabilityTotalValueText;
			LuaObject.checkType<Text>(l, 2, out favorabilityTotalValueText);
			fettersUIController.m_luaExportHelper.m_favorabilityTotalValueText = favorabilityTotalValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDE9 RID: 122345 RVA: 0x009880C4 File Offset: 0x009862C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGameObjectRoot(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_charGameObjectRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDEA RID: 122346 RVA: 0x0098811C File Offset: 0x0098631C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGameObjectRoot(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			GameObject charGameObjectRoot;
			LuaObject.checkType<GameObject>(l, 2, out charGameObjectRoot);
			fettersUIController.m_luaExportHelper.m_charGameObjectRoot = charGameObjectRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDEB RID: 122347 RVA: 0x00988178 File Offset: 0x00986378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollRect(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_scrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDEC RID: 122348 RVA: 0x009881D0 File Offset: 0x009863D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollRect(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			ScrollRect scrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out scrollRect);
			fettersUIController.m_luaExportHelper.m_scrollRect = scrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDED RID: 122349 RVA: 0x0098822C File Offset: 0x0098642C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_scrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDEE RID: 122350 RVA: 0x00988284 File Offset: 0x00986484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			GameObject scrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out scrollViewContent);
			fettersUIController.m_luaExportHelper.m_scrollViewContent = scrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDEF RID: 122351 RVA: 0x009882E0 File Offset: 0x009864E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_listItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_listItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDF0 RID: 122352 RVA: 0x00988338 File Offset: 0x00986538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_listItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			GameObject listItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out listItemPrefab);
			fettersUIController.m_luaExportHelper.m_listItemPrefab = listItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDF1 RID: 122353 RVA: 0x00988394 File Offset: 0x00986594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoPanelCommonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_infoPanelCommonUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDF2 RID: 122354 RVA: 0x009883EC File Offset: 0x009865EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_infoPanelCommonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			CommonUIStateController infoPanelCommonUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out infoPanelCommonUIStateCtrl);
			fettersUIController.m_luaExportHelper.m_infoPanelCommonUIStateCtrl = infoPanelCommonUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDF3 RID: 122355 RVA: 0x00988448 File Offset: 0x00986648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCtrlList(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_heroCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDF4 RID: 122356 RVA: 0x009884A0 File Offset: 0x009866A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCtrlList(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			List<FettersHeroListItemUIController> heroCtrlList;
			LuaObject.checkType<List<FettersHeroListItemUIController>>(l, 2, out heroCtrlList);
			fettersUIController.m_luaExportHelper.m_heroCtrlList = heroCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDF5 RID: 122357 RVA: 0x009884FC File Offset: 0x009866FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDF6 RID: 122358 RVA: 0x00988554 File Offset: 0x00986754
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			fettersUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDF7 RID: 122359 RVA: 0x009885B0 File Offset: 0x009867B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDF8 RID: 122360 RVA: 0x00988608 File Offset: 0x00986808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDF9 RID: 122361 RVA: 0x00988664 File Offset: 0x00986864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDFA RID: 122362 RVA: 0x009886BC File Offset: 0x009868BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			fettersUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDFB RID: 122363 RVA: 0x00988718 File Offset: 0x00986918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDFC RID: 122364 RVA: 0x00988770 File Offset: 0x00986970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			fettersUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDFD RID: 122365 RVA: 0x009887CC File Offset: 0x009869CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUIController.m_luaExportHelper.isFirstIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDFE RID: 122366 RVA: 0x00988824 File Offset: 0x00986A24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			FettersUIController fettersUIController = (FettersUIController)LuaObject.checkSelf(l);
			bool isFirstIn;
			LuaObject.checkType(l, 2, out isFirstIn);
			fettersUIController.m_luaExportHelper.isFirstIn = isFirstIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDFF RID: 122367 RVA: 0x00988880 File Offset: 0x00986A80
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.UpdateViewInFetters);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.GoToInformationPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.PlayHeroPerformance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.OnListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.HeroListItemCompare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.OnInformationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.OnFettersButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.ResetScrollViewPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callDele_EventOnListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__clearDele_EventOnListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callDele_EventOnFettersButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__clearDele_EventOnFettersButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__callDele_EventOnInformationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.__clearDele_EventOnInformationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache22);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache23, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache24, true);
		string name3 = "EventOnListItemClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_EventOnListItemClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache25, true);
		string name4 = "EventOnFettersButtonClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_EventOnFettersButtonClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache26, true);
		string name5 = "EventOnInformationButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_EventOnInformationButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache27, true);
		string name6 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_marginTransform);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache29, true);
		string name7 = "m_commonUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_commonUIStateCtrl);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_commonUIStateCtrl);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2B, true);
		string name8 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_returnButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2D, true);
		string name9 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_helpButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache2F, true);
		string name10 = "m_fettersButton";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_fettersButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_fettersButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache31, true);
		string name11 = "m_fettersButtonNewImage";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_fettersButtonNewImage);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_fettersButtonNewImage);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache33, true);
		string name12 = "m_fettersButtonPercentText";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_fettersButtonPercentText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_fettersButtonPercentText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache35, true);
		string name13 = "m_informationButton";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_informationButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_informationButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache37, true);
		string name14 = "m_informationButtonNewImage";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_informationButtonNewImage);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_informationButtonNewImage);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache39, true);
		string name15 = "m_favorabilityTotalValueText";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_favorabilityTotalValueText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_favorabilityTotalValueText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3B, true);
		string name16 = "m_charGameObjectRoot";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_charGameObjectRoot);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_charGameObjectRoot);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3D, true);
		string name17 = "m_scrollRect";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_scrollRect);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_scrollRect);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache3F, true);
		string name18 = "m_scrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_scrollViewContent);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_scrollViewContent);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache41, true);
		string name19 = "m_listItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_listItemPrefab);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_listItemPrefab);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache43, true);
		string name20 = "m_infoPanelCommonUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_infoPanelCommonUIStateCtrl);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_infoPanelCommonUIStateCtrl);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache45, true);
		string name21 = "m_heroCtrlList";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_heroCtrlList);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_heroCtrlList);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache47, true);
		string name22 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache49, true);
		string name23 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_hero);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_hero);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4B, true);
		string name24 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_playerContext);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4D, true);
		string name25 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_m_configDataLoader);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache4F, true);
		string name26 = "isFirstIn";
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.get_isFirstIn);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUIController.set_isFirstIn);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_FettersUIController.<>f__mg$cache51, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013F0D RID: 81677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013F0E RID: 81678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013F0F RID: 81679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013F10 RID: 81680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013F11 RID: 81681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013F12 RID: 81682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013F13 RID: 81683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013F14 RID: 81684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013F15 RID: 81685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013F16 RID: 81686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013F17 RID: 81687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013F18 RID: 81688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013F19 RID: 81689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013F1A RID: 81690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013F1B RID: 81691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013F1C RID: 81692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013F1D RID: 81693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013F1E RID: 81694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013F1F RID: 81695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013F20 RID: 81696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013F21 RID: 81697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013F22 RID: 81698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013F23 RID: 81699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013F24 RID: 81700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013F25 RID: 81701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013F26 RID: 81702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013F27 RID: 81703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013F28 RID: 81704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013F29 RID: 81705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013F2A RID: 81706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013F2B RID: 81707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013F2C RID: 81708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013F2D RID: 81709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013F2E RID: 81710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013F2F RID: 81711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013F30 RID: 81712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013F31 RID: 81713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013F32 RID: 81714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013F33 RID: 81715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013F34 RID: 81716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013F35 RID: 81717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013F36 RID: 81718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013F37 RID: 81719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013F38 RID: 81720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013F39 RID: 81721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013F3A RID: 81722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013F3B RID: 81723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013F3C RID: 81724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013F3D RID: 81725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013F3E RID: 81726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013F3F RID: 81727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013F40 RID: 81728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013F41 RID: 81729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013F42 RID: 81730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013F43 RID: 81731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013F44 RID: 81732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04013F45 RID: 81733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013F46 RID: 81734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013F47 RID: 81735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04013F48 RID: 81736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04013F49 RID: 81737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013F4A RID: 81738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013F4B RID: 81739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013F4C RID: 81740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013F4D RID: 81741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013F4E RID: 81742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013F4F RID: 81743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013F50 RID: 81744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013F51 RID: 81745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013F52 RID: 81746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013F53 RID: 81747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04013F54 RID: 81748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04013F55 RID: 81749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04013F56 RID: 81750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04013F57 RID: 81751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04013F58 RID: 81752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04013F59 RID: 81753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04013F5A RID: 81754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04013F5B RID: 81755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013F5C RID: 81756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04013F5D RID: 81757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04013F5E RID: 81758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;
}
