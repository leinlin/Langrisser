using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001363 RID: 4963
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AppScoreUIController : LuaObject
{
	// Token: 0x0601AC16 RID: 109590 RVA: 0x007FB3B4 File Offset: 0x007F95B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayOpenTween(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.PlayOpenTween();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC17 RID: 109591 RVA: 0x007FB400 File Offset: 0x007F9600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC18 RID: 109592 RVA: 0x007FB454 File Offset: 0x007F9654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScorePanelCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.m_luaExportHelper.OnScorePanelCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC19 RID: 109593 RVA: 0x007FB4A8 File Offset: 0x007F96A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScorePanelScoreButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.m_luaExportHelper.OnScorePanelScoreButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC1A RID: 109594 RVA: 0x007FB4FC File Offset: 0x007F96FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			appScoreUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC1B RID: 109595 RVA: 0x007FB568 File Offset: 0x007F9768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC1C RID: 109596 RVA: 0x007FB5BC File Offset: 0x007F97BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC1D RID: 109597 RVA: 0x007FB610 File Offset: 0x007F9810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = appScoreUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AC1E RID: 109598 RVA: 0x007FB6B8 File Offset: 0x007F98B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC1F RID: 109599 RVA: 0x007FB70C File Offset: 0x007F990C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			appScoreUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC20 RID: 109600 RVA: 0x007FB778 File Offset: 0x007F9978
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
				AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				appScoreUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				AppScoreUIController appScoreUIController2 = (AppScoreUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				appScoreUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601AC21 RID: 109601 RVA: 0x007FB888 File Offset: 0x007F9A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			appScoreUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC22 RID: 109602 RVA: 0x007FB8F4 File Offset: 0x007F9AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			appScoreUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC23 RID: 109603 RVA: 0x007FB960 File Offset: 0x007F9B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			appScoreUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC24 RID: 109604 RVA: 0x007FB9CC File Offset: 0x007F9BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			appScoreUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC25 RID: 109605 RVA: 0x007FBA38 File Offset: 0x007F9C38
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
				AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				appScoreUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				AppScoreUIController appScoreUIController2 = (AppScoreUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				appScoreUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601AC26 RID: 109606 RVA: 0x007FBB48 File Offset: 0x007F9D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			string s = appScoreUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AC27 RID: 109607 RVA: 0x007FBBA4 File Offset: 0x007F9DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC28 RID: 109608 RVA: 0x007FBBF8 File Offset: 0x007F9DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC29 RID: 109609 RVA: 0x007FBC4C File Offset: 0x007F9E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoScore(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.m_luaExportHelper.__callDele_EventOnGoScore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC2A RID: 109610 RVA: 0x007FBCA0 File Offset: 0x007F9EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoScore(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			appScoreUIController.m_luaExportHelper.__clearDele_EventOnGoScore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC2B RID: 109611 RVA: 0x007FBCF4 File Offset: 0x007F9EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					appScoreUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					appScoreUIController.EventOnClose -= value;
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

	// Token: 0x0601AC2C RID: 109612 RVA: 0x007FBD74 File Offset: 0x007F9F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoScore(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					appScoreUIController.EventOnGoScore += value;
				}
				else if (num == 2)
				{
					appScoreUIController.EventOnGoScore -= value;
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

	// Token: 0x0601AC2D RID: 109613 RVA: 0x007FBDF4 File Offset: 0x007F9FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, appScoreUIController.m_luaExportHelper.m_commonUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC2E RID: 109614 RVA: 0x007FBE4C File Offset: 0x007FA04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			CommonUIStateController commonUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out commonUIStateCtrl);
			appScoreUIController.m_luaExportHelper.m_commonUIStateCtrl = commonUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC2F RID: 109615 RVA: 0x007FBEA8 File Offset: 0x007FA0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scorePanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, appScoreUIController.m_luaExportHelper.m_scorePanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC30 RID: 109616 RVA: 0x007FBF00 File Offset: 0x007FA100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scorePanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			Button scorePanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out scorePanelCloseButton);
			appScoreUIController.m_luaExportHelper.m_scorePanelCloseButton = scorePanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC31 RID: 109617 RVA: 0x007FBF5C File Offset: 0x007FA15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scorePanelScoreButton(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, appScoreUIController.m_luaExportHelper.m_scorePanelScoreButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC32 RID: 109618 RVA: 0x007FBFB4 File Offset: 0x007FA1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scorePanelScoreButton(IntPtr l)
	{
		int result;
		try
		{
			AppScoreUIController appScoreUIController = (AppScoreUIController)LuaObject.checkSelf(l);
			Button scorePanelScoreButton;
			LuaObject.checkType<Button>(l, 2, out scorePanelScoreButton);
			appScoreUIController.m_luaExportHelper.m_scorePanelScoreButton = scorePanelScoreButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC33 RID: 109619 RVA: 0x007FC010 File Offset: 0x007FA210
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AppScoreUIController");
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.PlayOpenTween);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.OnScorePanelCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.OnScorePanelScoreButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__callDele_EventOnGoScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.__clearDele_EventOnGoScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache14);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache15, true);
		string name2 = "EventOnGoScore";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.set_EventOnGoScore);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache16, true);
		string name3 = "m_commonUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.get_m_commonUIStateCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.set_m_commonUIStateCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache18, true);
		string name4 = "m_scorePanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.get_m_scorePanelCloseButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.set_m_scorePanelCloseButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1A, true);
		string name5 = "m_scorePanelScoreButton";
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.get_m_scorePanelScoreButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AppScoreUIController.set_m_scorePanelScoreButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_AppScoreUIController.<>f__mg$cache1C, true);
		LuaObject.createTypeMetatable(l, null, typeof(AppScoreUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010F32 RID: 69426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010F33 RID: 69427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010F34 RID: 69428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010F35 RID: 69429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010F36 RID: 69430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010F37 RID: 69431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010F38 RID: 69432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010F39 RID: 69433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010F3A RID: 69434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010F3B RID: 69435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010F3C RID: 69436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010F3D RID: 69437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010F3E RID: 69438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010F3F RID: 69439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010F40 RID: 69440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010F41 RID: 69441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010F42 RID: 69442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010F43 RID: 69443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010F44 RID: 69444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010F45 RID: 69445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010F46 RID: 69446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010F47 RID: 69447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010F48 RID: 69448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010F49 RID: 69449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010F4A RID: 69450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010F4B RID: 69451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010F4C RID: 69452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010F4D RID: 69453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010F4E RID: 69454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
