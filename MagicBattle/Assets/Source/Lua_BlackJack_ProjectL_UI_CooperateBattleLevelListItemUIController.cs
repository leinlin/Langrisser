using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001407 RID: 5127
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController : LuaObject
{
	// Token: 0x0601CF08 RID: 118536 RVA: 0x00911268 File Offset: 0x0090F468
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCooperateBattleLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo cooperateBattleLevelInfo;
			LuaObject.checkType<ConfigDataCooperateBattleLevelInfo>(l, 2, out cooperateBattleLevelInfo);
			cooperateBattleLevelListItemUIController.SetCooperateBattleLevelInfo(cooperateBattleLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF09 RID: 118537 RVA: 0x009112C0 File Offset: 0x0090F4C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCooperateBattleLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo cooperateBattleLevelInfo = cooperateBattleLevelListItemUIController.GetCooperateBattleLevelInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF0A RID: 118538 RVA: 0x00911314 File Offset: 0x0090F514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			cooperateBattleLevelListItemUIController.SetLocked(locked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF0B RID: 118539 RVA: 0x0091136C File Offset: 0x0090F56C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF0C RID: 118540 RVA: 0x009113C0 File Offset: 0x0090F5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF0D RID: 118541 RVA: 0x00911414 File Offset: 0x0090F614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnLockedButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.OnLockedButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF0E RID: 118542 RVA: 0x00911468 File Offset: 0x0090F668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF0F RID: 118543 RVA: 0x009114D4 File Offset: 0x0090F6D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF10 RID: 118544 RVA: 0x00911528 File Offset: 0x0090F728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF11 RID: 118545 RVA: 0x0091157C File Offset: 0x0090F77C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CF12 RID: 118546 RVA: 0x00911624 File Offset: 0x0090F824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF13 RID: 118547 RVA: 0x00911678 File Offset: 0x0090F878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF14 RID: 118548 RVA: 0x009116E4 File Offset: 0x0090F8E4
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
				CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController2 = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				cooperateBattleLevelListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CF15 RID: 118549 RVA: 0x009117F4 File Offset: 0x0090F9F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF16 RID: 118550 RVA: 0x00911860 File Offset: 0x0090FA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF17 RID: 118551 RVA: 0x009118CC File Offset: 0x0090FACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF18 RID: 118552 RVA: 0x00911938 File Offset: 0x0090FB38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF19 RID: 118553 RVA: 0x009119A4 File Offset: 0x0090FBA4
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
				CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController2 = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				cooperateBattleLevelListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CF1A RID: 118554 RVA: 0x00911AB4 File Offset: 0x0090FCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			string s = cooperateBattleLevelListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CF1B RID: 118555 RVA: 0x00911B10 File Offset: 0x0090FD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			CooperateBattleLevelListItemUIController obj;
			LuaObject.checkType<CooperateBattleLevelListItemUIController>(l, 2, out obj);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__callDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF1C RID: 118556 RVA: 0x00911B6C File Offset: 0x0090FD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			CooperateBattleLevelListItemUIController obj;
			LuaObject.checkType<CooperateBattleLevelListItemUIController>(l, 2, out obj);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.__clearDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF1D RID: 118557 RVA: 0x00911BC8 File Offset: 0x0090FDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			Action<CooperateBattleLevelListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<CooperateBattleLevelListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					cooperateBattleLevelListItemUIController.EventOnStartButtonClick += value;
				}
				else if (num == 2)
				{
					cooperateBattleLevelListItemUIController.EventOnStartButtonClick -= value;
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

	// Token: 0x0601CF1E RID: 118558 RVA: 0x00911C48 File Offset: 0x0090FE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevelListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF1F RID: 118559 RVA: 0x00911CA0 File Offset: 0x0090FEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF20 RID: 118560 RVA: 0x00911CFC File Offset: 0x0090FEFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevelListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF21 RID: 118561 RVA: 0x00911D54 File Offset: 0x0090FF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF22 RID: 118562 RVA: 0x00911DB0 File Offset: 0x0090FFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevelListItemUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF23 RID: 118563 RVA: 0x00911E08 File Offset: 0x00910008
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF24 RID: 118564 RVA: 0x00911E64 File Offset: 0x00910064
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevelListItemUIController.m_luaExportHelper.m_lockedButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF25 RID: 118565 RVA: 0x00911EBC File Offset: 0x009100BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			Button lockedButton;
			LuaObject.checkType<Button>(l, 2, out lockedButton);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.m_lockedButton = lockedButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF26 RID: 118566 RVA: 0x00911F18 File Offset: 0x00910118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevelListItemUIController.m_luaExportHelper.m_lockedText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF27 RID: 118567 RVA: 0x00911F70 File Offset: 0x00910170
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lockedText(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			Text lockedText;
			LuaObject.checkType<Text>(l, 2, out lockedText);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.m_lockedText = lockedText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF28 RID: 118568 RVA: 0x00911FCC File Offset: 0x009101CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevelListItemUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF29 RID: 118569 RVA: 0x00912024 File Offset: 0x00910224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF2A RID: 118570 RVA: 0x00912080 File Offset: 0x00910280
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF2B RID: 118571 RVA: 0x009120D8 File Offset: 0x009102D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject rewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGroupGameObject);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject = rewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF2C RID: 118572 RVA: 0x00912134 File Offset: 0x00910334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cooperateBattleLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevelListItemUIController.m_luaExportHelper.m_cooperateBattleLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF2D RID: 118573 RVA: 0x0091218C File Offset: 0x0091038C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cooperateBattleLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleLevelListItemUIController cooperateBattleLevelListItemUIController = (CooperateBattleLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleLevelInfo cooperateBattleLevelInfo;
			LuaObject.checkType<ConfigDataCooperateBattleLevelInfo>(l, 2, out cooperateBattleLevelInfo);
			cooperateBattleLevelListItemUIController.m_luaExportHelper.m_cooperateBattleLevelInfo = cooperateBattleLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CF2E RID: 118574 RVA: 0x009121E8 File Offset: 0x009103E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CooperateBattleLevelListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.SetCooperateBattleLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.GetCooperateBattleLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.OnLockedButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__callDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.__clearDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache14);
		string name = "EventOnStartButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.set_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache15, true);
		string name2 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.get_m_levelText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache17, true);
		string name3 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.get_m_nameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache19, true);
		string name4 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.get_m_energyText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_lockedButton";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.get_m_lockedButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.set_m_lockedButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1D, true);
		string name6 = "m_lockedText";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.get_m_lockedText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.set_m_lockedText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache1F, true);
		string name7 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.get_m_startButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache21, true);
		string name8 = "m_rewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.get_m_rewardGroupGameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.set_m_rewardGroupGameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache23, true);
		string name9 = "m_cooperateBattleLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.get_m_cooperateBattleLevelInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.set_m_cooperateBattleLevelInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.<>f__mg$cache25, true);
		LuaObject.createTypeMetatable(l, null, typeof(CooperateBattleLevelListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040130DC RID: 78044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040130DD RID: 78045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040130DE RID: 78046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040130DF RID: 78047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040130E0 RID: 78048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040130E1 RID: 78049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040130E2 RID: 78050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040130E3 RID: 78051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040130E4 RID: 78052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040130E5 RID: 78053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040130E6 RID: 78054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040130E7 RID: 78055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040130E8 RID: 78056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040130E9 RID: 78057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040130EA RID: 78058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040130EB RID: 78059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040130EC RID: 78060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040130ED RID: 78061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040130EE RID: 78062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040130EF RID: 78063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040130F0 RID: 78064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040130F1 RID: 78065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040130F2 RID: 78066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040130F3 RID: 78067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040130F4 RID: 78068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040130F5 RID: 78069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040130F6 RID: 78070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040130F7 RID: 78071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040130F8 RID: 78072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040130F9 RID: 78073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040130FA RID: 78074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040130FB RID: 78075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040130FC RID: 78076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040130FD RID: 78077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040130FE RID: 78078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040130FF RID: 78079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013100 RID: 78080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013101 RID: 78081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
