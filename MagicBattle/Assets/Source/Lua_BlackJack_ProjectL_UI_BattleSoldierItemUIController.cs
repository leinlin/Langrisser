using System;
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

// Token: 0x020013C4 RID: 5060
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController : LuaObject
{
	// Token: 0x0601C030 RID: 114736 RVA: 0x0089AF68 File Offset: 0x00899168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSoldierItem(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			ConfigDataModelSkinResourceInfo soldierSkinResInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 3, out soldierSkinResInfo);
			battleSoldierItemUIController.InitSoldierItem(soldierInfo, soldierSkinResInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C031 RID: 114737 RVA: 0x0089AFCC File Offset: 0x008991CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			bool selectPanel;
			LuaObject.checkType(l, 2, out selectPanel);
			battleSoldierItemUIController.SetSelectPanel(selectPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C032 RID: 114738 RVA: 0x0089B024 File Offset: 0x00899224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			battleSoldierItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C033 RID: 114739 RVA: 0x0089B078 File Offset: 0x00899278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			battleSoldierItemUIController.m_luaExportHelper.OnSelectButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C034 RID: 114740 RVA: 0x0089B0CC File Offset: 0x008992CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			battleSoldierItemUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C035 RID: 114741 RVA: 0x0089B120 File Offset: 0x00899320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			battleSoldierItemUIController.m_luaExportHelper.CreateSpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C036 RID: 114742 RVA: 0x0089B174 File Offset: 0x00899374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			battleSoldierItemUIController.m_luaExportHelper.DestroySpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C037 RID: 114743 RVA: 0x0089B1C8 File Offset: 0x008993C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDestroy(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			battleSoldierItemUIController.m_luaExportHelper.OnDestroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C038 RID: 114744 RVA: 0x0089B21C File Offset: 0x0089941C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleSoldierItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C039 RID: 114745 RVA: 0x0089B288 File Offset: 0x00899488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			battleSoldierItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C03A RID: 114746 RVA: 0x0089B2DC File Offset: 0x008994DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			battleSoldierItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C03B RID: 114747 RVA: 0x0089B330 File Offset: 0x00899530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleSoldierItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C03C RID: 114748 RVA: 0x0089B3D8 File Offset: 0x008995D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			battleSoldierItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C03D RID: 114749 RVA: 0x0089B42C File Offset: 0x0089962C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleSoldierItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C03E RID: 114750 RVA: 0x0089B498 File Offset: 0x00899698
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
				BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleSoldierItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleSoldierItemUIController battleSoldierItemUIController2 = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleSoldierItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C03F RID: 114751 RVA: 0x0089B5A8 File Offset: 0x008997A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleSoldierItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C040 RID: 114752 RVA: 0x0089B614 File Offset: 0x00899814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleSoldierItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C041 RID: 114753 RVA: 0x0089B680 File Offset: 0x00899880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleSoldierItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C042 RID: 114754 RVA: 0x0089B6EC File Offset: 0x008998EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleSoldierItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C043 RID: 114755 RVA: 0x0089B758 File Offset: 0x00899958
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
				BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleSoldierItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleSoldierItemUIController battleSoldierItemUIController2 = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleSoldierItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C044 RID: 114756 RVA: 0x0089B868 File Offset: 0x00899A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			string s = battleSoldierItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C045 RID: 114757 RVA: 0x0089B8C4 File Offset: 0x00899AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			BattleSoldierItemUIController obj;
			LuaObject.checkType<BattleSoldierItemUIController>(l, 2, out obj);
			battleSoldierItemUIController.m_luaExportHelper.__callDele_EventOnSoldierItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C046 RID: 114758 RVA: 0x0089B920 File Offset: 0x00899B20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			BattleSoldierItemUIController obj;
			LuaObject.checkType<BattleSoldierItemUIController>(l, 2, out obj);
			battleSoldierItemUIController.m_luaExportHelper.__clearDele_EventOnSoldierItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C047 RID: 114759 RVA: 0x0089B97C File Offset: 0x00899B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			BattleSoldierItemUIController obj;
			LuaObject.checkType<BattleSoldierItemUIController>(l, 2, out obj);
			battleSoldierItemUIController.m_luaExportHelper.__callDele_EventOnSelectButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C048 RID: 114760 RVA: 0x0089B9D8 File Offset: 0x00899BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			BattleSoldierItemUIController obj;
			LuaObject.checkType<BattleSoldierItemUIController>(l, 2, out obj);
			battleSoldierItemUIController.m_luaExportHelper.__clearDele_EventOnSelectButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C049 RID: 114761 RVA: 0x0089BA34 File Offset: 0x00899C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Action<BattleSoldierItemUIController> value;
			int num = LuaObject.checkDelegate<Action<BattleSoldierItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleSoldierItemUIController.EventOnSoldierItemClick += value;
				}
				else if (num == 2)
				{
					battleSoldierItemUIController.EventOnSoldierItemClick -= value;
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

	// Token: 0x0601C04A RID: 114762 RVA: 0x0089BAB4 File Offset: 0x00899CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Action<BattleSoldierItemUIController> value;
			int num = LuaObject.checkDelegate<Action<BattleSoldierItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					battleSoldierItemUIController.EventOnSelectButtonClick += value;
				}
				else if (num == 2)
				{
					battleSoldierItemUIController.EventOnSelectButtonClick -= value;
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

	// Token: 0x0601C04B RID: 114763 RVA: 0x0089BB34 File Offset: 0x00899D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C04C RID: 114764 RVA: 0x0089BB8C File Offset: 0x00899D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			battleSoldierItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C04D RID: 114765 RVA: 0x0089BBE8 File Offset: 0x00899DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierIconImg(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_soldierIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C04E RID: 114766 RVA: 0x0089BC40 File Offset: 0x00899E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierIconImg(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Image soldierIconImg;
			LuaObject.checkType<Image>(l, 2, out soldierIconImg);
			battleSoldierItemUIController.m_luaExportHelper.m_soldierIconImg = soldierIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C04F RID: 114767 RVA: 0x0089BC9C File Offset: 0x00899E9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierRangeText(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_soldierRangeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C050 RID: 114768 RVA: 0x0089BCF4 File Offset: 0x00899EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierRangeText(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Text soldierRangeText;
			LuaObject.checkType<Text>(l, 2, out soldierRangeText);
			battleSoldierItemUIController.m_luaExportHelper.m_soldierRangeText = soldierRangeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C051 RID: 114769 RVA: 0x0089BD50 File Offset: 0x00899F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMoveText(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_soldierMoveText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C052 RID: 114770 RVA: 0x0089BDA8 File Offset: 0x00899FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMoveText(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Text soldierMoveText;
			LuaObject.checkType<Text>(l, 2, out soldierMoveText);
			battleSoldierItemUIController.m_luaExportHelper.m_soldierMoveText = soldierMoveText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C053 RID: 114771 RVA: 0x0089BE04 File Offset: 0x0089A004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_typeBgImage(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_typeBgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C054 RID: 114772 RVA: 0x0089BE5C File Offset: 0x0089A05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_typeBgImage(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Image typeBgImage;
			LuaObject.checkType<Image>(l, 2, out typeBgImage);
			battleSoldierItemUIController.m_luaExportHelper.m_typeBgImage = typeBgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C055 RID: 114773 RVA: 0x0089BEB8 File Offset: 0x0089A0B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_typeBgImage2(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_typeBgImage2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C056 RID: 114774 RVA: 0x0089BF10 File Offset: 0x0089A110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_typeBgImage2(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Image typeBgImage;
			LuaObject.checkType<Image>(l, 2, out typeBgImage);
			battleSoldierItemUIController.m_luaExportHelper.m_typeBgImage2 = typeBgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C057 RID: 114775 RVA: 0x0089BF6C File Offset: 0x0089A16C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_soldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C058 RID: 114776 RVA: 0x0089BFC4 File Offset: 0x0089A1C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Text soldierNameText;
			LuaObject.checkType<Text>(l, 2, out soldierNameText);
			battleSoldierItemUIController.m_luaExportHelper.m_soldierNameText = soldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C059 RID: 114777 RVA: 0x0089C020 File Offset: 0x0089A220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectButton(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_selectButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C05A RID: 114778 RVA: 0x0089C078 File Offset: 0x0089A278
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_selectButton(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			Button selectButton;
			LuaObject.checkType<Button>(l, 2, out selectButton);
			battleSoldierItemUIController.m_luaExportHelper.m_selectButton = selectButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C05B RID: 114779 RVA: 0x0089C0D4 File Offset: 0x0089A2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectPanel(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_selectPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C05C RID: 114780 RVA: 0x0089C12C File Offset: 0x0089A32C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_selectPanel(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			GameObject selectPanel;
			LuaObject.checkType<GameObject>(l, 2, out selectPanel);
			battleSoldierItemUIController.m_luaExportHelper.m_selectPanel = selectPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C05D RID: 114781 RVA: 0x0089C188 File Offset: 0x0089A388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGrapgic(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_soldierGrapgic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C05E RID: 114782 RVA: 0x0089C1E0 File Offset: 0x0089A3E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierGrapgic(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			GameObject soldierGrapgic;
			LuaObject.checkType<GameObject>(l, 2, out soldierGrapgic);
			battleSoldierItemUIController.m_luaExportHelper.m_soldierGrapgic = soldierGrapgic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C05F RID: 114783 RVA: 0x0089C23C File Offset: 0x0089A43C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C060 RID: 114784 RVA: 0x0089C294 File Offset: 0x0089A494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			battleSoldierItemUIController.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C061 RID: 114785 RVA: 0x0089C2F0 File Offset: 0x0089A4F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_solderSkinResInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.m_luaExportHelper.m_solderSkinResInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C062 RID: 114786 RVA: 0x0089C348 File Offset: 0x0089A548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_solderSkinResInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataModelSkinResourceInfo solderSkinResInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 2, out solderSkinResInfo);
			battleSoldierItemUIController.m_luaExportHelper.m_solderSkinResInfo = solderSkinResInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C063 RID: 114787 RVA: 0x0089C3A4 File Offset: 0x0089A5A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleSoldierItemUIController.SoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C064 RID: 114788 RVA: 0x0089C3F8 File Offset: 0x0089A5F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleSoldierItemUIController battleSoldierItemUIController = (BattleSoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			battleSoldierItemUIController.m_luaExportHelper.SoldierInfo = soldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C065 RID: 114789 RVA: 0x0089C454 File Offset: 0x0089A654
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleSoldierItemUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.InitSoldierItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.SetSelectPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.OnSelectButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.OnDestroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callDele_EventOnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__clearDele_EventOnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__callDele_EventOnSelectButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.__clearDele_EventOnSelectButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache18);
		string name = "EventOnSoldierItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_EventOnSoldierItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache19, true);
		string name2 = "EventOnSelectButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_EventOnSelectButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1A, true);
		string name3 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_button);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1C, true);
		string name4 = "m_soldierIconImg";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_soldierIconImg);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_soldierIconImg);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1E, true);
		string name5 = "m_soldierRangeText";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_soldierRangeText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_soldierRangeText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache20, true);
		string name6 = "m_soldierMoveText";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_soldierMoveText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_soldierMoveText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache22, true);
		string name7 = "m_typeBgImage";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_typeBgImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_typeBgImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache24, true);
		string name8 = "m_typeBgImage2";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_typeBgImage2);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_typeBgImage2);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache26, true);
		string name9 = "m_soldierNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_soldierNameText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_soldierNameText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache28, true);
		string name10 = "m_selectButton";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_selectButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_selectButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2A, true);
		string name11 = "m_selectPanel";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_selectPanel);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_selectPanel);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2C, true);
		string name12 = "m_soldierGrapgic";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_soldierGrapgic);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_soldierGrapgic);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2E, true);
		string name13 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_graphic);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_graphic);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache30, true);
		string name14 = "m_solderSkinResInfo";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_m_solderSkinResInfo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_m_solderSkinResInfo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache32, true);
		string name15 = "SoldierInfo";
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.get_SoldierInfo);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.set_SoldierInfo);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.<>f__mg$cache34, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleSoldierItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401228A RID: 74378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401228B RID: 74379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401228C RID: 74380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401228D RID: 74381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401228E RID: 74382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401228F RID: 74383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012290 RID: 74384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012291 RID: 74385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012292 RID: 74386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012293 RID: 74387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012294 RID: 74388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012295 RID: 74389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012296 RID: 74390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012297 RID: 74391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012298 RID: 74392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012299 RID: 74393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401229A RID: 74394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401229B RID: 74395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401229C RID: 74396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401229D RID: 74397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401229E RID: 74398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401229F RID: 74399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040122A0 RID: 74400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040122A1 RID: 74401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040122A2 RID: 74402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040122A3 RID: 74403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040122A4 RID: 74404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040122A5 RID: 74405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040122A6 RID: 74406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040122A7 RID: 74407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040122A8 RID: 74408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040122A9 RID: 74409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040122AA RID: 74410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040122AB RID: 74411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040122AC RID: 74412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040122AD RID: 74413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040122AE RID: 74414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040122AF RID: 74415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040122B0 RID: 74416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040122B1 RID: 74417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040122B2 RID: 74418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040122B3 RID: 74419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040122B4 RID: 74420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040122B5 RID: 74421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040122B6 RID: 74422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040122B7 RID: 74423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040122B8 RID: 74424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040122B9 RID: 74425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040122BA RID: 74426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040122BB RID: 74427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040122BC RID: 74428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040122BD RID: 74429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040122BE RID: 74430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
