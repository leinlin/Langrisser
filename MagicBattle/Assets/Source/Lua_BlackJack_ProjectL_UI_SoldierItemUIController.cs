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

// Token: 0x0200157F RID: 5503
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SoldierItemUIController : LuaObject
{
	// Token: 0x060211CA RID: 135626 RVA: 0x00B24CD8 File Offset: 0x00B22ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSoldierItem(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo si;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out si);
			ConfigDataJobConnectionInfo jci;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 3, out jci);
			bool isSoliderGet;
			LuaObject.checkType(l, 4, out isSoliderGet);
			int soldierSkinId;
			LuaObject.checkType(l, 5, out soldierSkinId);
			soldierItemUIController.InitSoldierItem(si, jci, isSoliderGet, soldierSkinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211CB RID: 135627 RVA: 0x00B24D58 File Offset: 0x00B22F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAttackingPanelActive(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			bool attackingPanelActive;
			LuaObject.checkType(l, 2, out attackingPanelActive);
			soldierItemUIController.SetAttackingPanelActive(attackingPanelActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211CC RID: 135628 RVA: 0x00B24DB0 File Offset: 0x00B22FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAttackButtonActive(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			bool attackButtonActive;
			LuaObject.checkType(l, 2, out attackButtonActive);
			soldierItemUIController.SetAttackButtonActive(attackButtonActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211CD RID: 135629 RVA: 0x00B24E08 File Offset: 0x00B23008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFrameImgActive(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			bool frameImgActive;
			LuaObject.checkType(l, 2, out frameImgActive);
			soldierItemUIController.SetFrameImgActive(frameImgActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211CE RID: 135630 RVA: 0x00B24E60 File Offset: 0x00B23060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			soldierItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211CF RID: 135631 RVA: 0x00B24EB4 File Offset: 0x00B230B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			soldierItemUIController.m_luaExportHelper.OnSoldierItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211D0 RID: 135632 RVA: 0x00B24F08 File Offset: 0x00B23108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			soldierItemUIController.m_luaExportHelper.OnAttackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211D1 RID: 135633 RVA: 0x00B24F5C File Offset: 0x00B2315C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			bool isGet;
			LuaObject.checkType(l, 3, out isGet);
			int soldierSkinId;
			LuaObject.checkType(l, 4, out soldierSkinId);
			soldierItemUIController.m_luaExportHelper.CreateSpineGraphic(soldierInfo, isGet, soldierSkinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211D2 RID: 135634 RVA: 0x00B24FD4 File Offset: 0x00B231D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			soldierItemUIController.m_luaExportHelper.DestroySpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211D3 RID: 135635 RVA: 0x00B25028 File Offset: 0x00B23228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDestroy(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			soldierItemUIController.m_luaExportHelper.OnDestroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211D4 RID: 135636 RVA: 0x00B2507C File Offset: 0x00B2327C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			soldierItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211D5 RID: 135637 RVA: 0x00B250E8 File Offset: 0x00B232E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			soldierItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211D6 RID: 135638 RVA: 0x00B2513C File Offset: 0x00B2333C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			soldierItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211D7 RID: 135639 RVA: 0x00B25190 File Offset: 0x00B23390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = soldierItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060211D8 RID: 135640 RVA: 0x00B25238 File Offset: 0x00B23438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			soldierItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211D9 RID: 135641 RVA: 0x00B2528C File Offset: 0x00B2348C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			soldierItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211DA RID: 135642 RVA: 0x00B252F8 File Offset: 0x00B234F8
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
				SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				soldierItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SoldierItemUIController soldierItemUIController2 = (SoldierItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				soldierItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060211DB RID: 135643 RVA: 0x00B25408 File Offset: 0x00B23608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211DC RID: 135644 RVA: 0x00B25474 File Offset: 0x00B23674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211DD RID: 135645 RVA: 0x00B254E0 File Offset: 0x00B236E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211DE RID: 135646 RVA: 0x00B2554C File Offset: 0x00B2374C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211DF RID: 135647 RVA: 0x00B255B8 File Offset: 0x00B237B8
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
				SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				soldierItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SoldierItemUIController soldierItemUIController2 = (SoldierItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				soldierItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060211E0 RID: 135648 RVA: 0x00B256C8 File Offset: 0x00B238C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			string s = soldierItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060211E1 RID: 135649 RVA: 0x00B25724 File Offset: 0x00B23924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			SoldierItemUIController obj;
			LuaObject.checkType<SoldierItemUIController>(l, 2, out obj);
			soldierItemUIController.m_luaExportHelper.__callDele_EventOnSoldierItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211E2 RID: 135650 RVA: 0x00B25780 File Offset: 0x00B23980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			SoldierItemUIController obj;
			LuaObject.checkType<SoldierItemUIController>(l, 2, out obj);
			soldierItemUIController.m_luaExportHelper.__clearDele_EventOnSoldierItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211E3 RID: 135651 RVA: 0x00B257DC File Offset: 0x00B239DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo obj;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out obj);
			soldierItemUIController.m_luaExportHelper.__callDele_EventOnAttackButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211E4 RID: 135652 RVA: 0x00B25838 File Offset: 0x00B23A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo obj;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out obj);
			soldierItemUIController.m_luaExportHelper.__clearDele_EventOnAttackButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211E5 RID: 135653 RVA: 0x00B25894 File Offset: 0x00B23A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			Action<SoldierItemUIController> value;
			int num = LuaObject.checkDelegate<Action<SoldierItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					soldierItemUIController.EventOnSoldierItemClick += value;
				}
				else if (num == 2)
				{
					soldierItemUIController.EventOnSoldierItemClick -= value;
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

	// Token: 0x060211E6 RID: 135654 RVA: 0x00B25914 File Offset: 0x00B23B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAttackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			Action<ConfigDataSoldierInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataSoldierInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					soldierItemUIController.EventOnAttackButtonClick += value;
				}
				else if (num == 2)
				{
					soldierItemUIController.EventOnAttackButtonClick -= value;
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

	// Token: 0x060211E7 RID: 135655 RVA: 0x00B25994 File Offset: 0x00B23B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.m_luaExportHelper.m_soldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211E8 RID: 135656 RVA: 0x00B259EC File Offset: 0x00B23BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			Text soldierNameText;
			LuaObject.checkType<Text>(l, 2, out soldierNameText);
			soldierItemUIController.m_luaExportHelper.m_soldierNameText = soldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211E9 RID: 135657 RVA: 0x00B25A48 File Offset: 0x00B23C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackButton(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.m_luaExportHelper.m_attackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211EA RID: 135658 RVA: 0x00B25AA0 File Offset: 0x00B23CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackButton(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			Button attackButton;
			LuaObject.checkType<Button>(l, 2, out attackButton);
			soldierItemUIController.m_luaExportHelper.m_attackButton = attackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211EB RID: 135659 RVA: 0x00B25AFC File Offset: 0x00B23CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackingObj(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.m_luaExportHelper.m_attackingObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211EC RID: 135660 RVA: 0x00B25B54 File Offset: 0x00B23D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackingObj(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			GameObject attackingObj;
			LuaObject.checkType<GameObject>(l, 2, out attackingObj);
			soldierItemUIController.m_luaExportHelper.m_attackingObj = attackingObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211ED RID: 135661 RVA: 0x00B25BB0 File Offset: 0x00B23DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dontGetObj(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.m_luaExportHelper.m_dontGetObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211EE RID: 135662 RVA: 0x00B25C08 File Offset: 0x00B23E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dontGetObj(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			GameObject dontGetObj;
			LuaObject.checkType<GameObject>(l, 2, out dontGetObj);
			soldierItemUIController.m_luaExportHelper.m_dontGetObj = dontGetObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211EF RID: 135663 RVA: 0x00B25C64 File Offset: 0x00B23E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGrapgic(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.m_luaExportHelper.m_soldierGrapgic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211F0 RID: 135664 RVA: 0x00B25CBC File Offset: 0x00B23EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGrapgic(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			GameObject soldierGrapgic;
			LuaObject.checkType<GameObject>(l, 2, out soldierGrapgic);
			soldierItemUIController.m_luaExportHelper.m_soldierGrapgic = soldierGrapgic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211F1 RID: 135665 RVA: 0x00B25D18 File Offset: 0x00B23F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frameImage(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.m_luaExportHelper.m_frameImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211F2 RID: 135666 RVA: 0x00B25D70 File Offset: 0x00B23F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameImage(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			GameObject frameImage;
			LuaObject.checkType<GameObject>(l, 2, out frameImage);
			soldierItemUIController.m_luaExportHelper.m_frameImage = frameImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211F3 RID: 135667 RVA: 0x00B25DCC File Offset: 0x00B23FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinIconImage(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.m_luaExportHelper.m_skinIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211F4 RID: 135668 RVA: 0x00B25E24 File Offset: 0x00B24024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinIconImage(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			GameObject skinIconImage;
			LuaObject.checkType<GameObject>(l, 2, out skinIconImage);
			soldierItemUIController.m_luaExportHelper.m_skinIconImage = skinIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211F5 RID: 135669 RVA: 0x00B25E80 File Offset: 0x00B24080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSoldierGet(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.m_luaExportHelper.m_isSoldierGet);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211F6 RID: 135670 RVA: 0x00B25ED8 File Offset: 0x00B240D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSoldierGet(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			bool isSoldierGet;
			LuaObject.checkType(l, 2, out isSoldierGet);
			soldierItemUIController.m_luaExportHelper.m_isSoldierGet = isSoldierGet;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211F7 RID: 135671 RVA: 0x00B25F34 File Offset: 0x00B24134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierSkinId(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.m_luaExportHelper.m_soldierSkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211F8 RID: 135672 RVA: 0x00B25F8C File Offset: 0x00B2418C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierSkinId(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			int soldierSkinId;
			LuaObject.checkType(l, 2, out soldierSkinId);
			soldierItemUIController.m_luaExportHelper.m_soldierSkinId = soldierSkinId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211F9 RID: 135673 RVA: 0x00B25FE8 File Offset: 0x00B241E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211FA RID: 135674 RVA: 0x00B26040 File Offset: 0x00B24240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			soldierItemUIController.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211FB RID: 135675 RVA: 0x00B2609C File Offset: 0x00B2429C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.JobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211FC RID: 135676 RVA: 0x00B260F0 File Offset: 0x00B242F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			soldierItemUIController.JobConnectionInfo = jobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211FD RID: 135677 RVA: 0x00B26148 File Offset: 0x00B24348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierItemUIController.SoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211FE RID: 135678 RVA: 0x00B2619C File Offset: 0x00B2439C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			SoldierItemUIController soldierItemUIController = (SoldierItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			soldierItemUIController.SoldierInfo = soldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211FF RID: 135679 RVA: 0x00B261F4 File Offset: 0x00B243F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SoldierItemUIController");
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.InitSoldierItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.SetAttackingPanelActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.SetAttackButtonActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.SetFrameImgActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.OnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.OnAttackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.OnDestroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callDele_EventOnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__clearDele_EventOnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__callDele_EventOnAttackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.__clearDele_EventOnAttackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1A);
		string name = "EventOnSoldierItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_EventOnSoldierItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1B, true);
		string name2 = "EventOnAttackButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_EventOnAttackButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1C, true);
		string name3 = "m_soldierNameText";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_m_soldierNameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_m_soldierNameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1E, true);
		string name4 = "m_attackButton";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_m_attackButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_m_attackButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache20, true);
		string name5 = "m_attackingObj";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_m_attackingObj);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_m_attackingObj);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache22, true);
		string name6 = "m_dontGetObj";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_m_dontGetObj);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_m_dontGetObj);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache24, true);
		string name7 = "m_soldierGrapgic";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_m_soldierGrapgic);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_m_soldierGrapgic);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache26, true);
		string name8 = "m_frameImage";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_m_frameImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_m_frameImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache28, true);
		string name9 = "m_skinIconImage";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_m_skinIconImage);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_m_skinIconImage);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2A, true);
		string name10 = "m_isSoldierGet";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_m_isSoldierGet);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_m_isSoldierGet);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2C, true);
		string name11 = "m_soldierSkinId";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_m_soldierSkinId);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_m_soldierSkinId);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2E, true);
		string name12 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_m_graphic);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_m_graphic);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache30, true);
		string name13 = "JobConnectionInfo";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_JobConnectionInfo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_JobConnectionInfo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache32, true);
		string name14 = "SoldierInfo";
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.get_SoldierInfo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.set_SoldierInfo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_SoldierItemUIController.<>f__mg$cache34, true);
		LuaObject.createTypeMetatable(l, null, typeof(SoldierItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040170AE RID: 94382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040170AF RID: 94383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040170B0 RID: 94384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040170B1 RID: 94385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040170B2 RID: 94386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040170B3 RID: 94387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040170B4 RID: 94388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040170B5 RID: 94389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040170B6 RID: 94390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040170B7 RID: 94391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040170B8 RID: 94392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040170B9 RID: 94393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040170BA RID: 94394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040170BB RID: 94395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040170BC RID: 94396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040170BD RID: 94397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040170BE RID: 94398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040170BF RID: 94399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040170C0 RID: 94400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040170C1 RID: 94401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040170C2 RID: 94402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040170C3 RID: 94403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040170C4 RID: 94404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040170C5 RID: 94405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040170C6 RID: 94406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040170C7 RID: 94407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040170C8 RID: 94408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040170C9 RID: 94409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040170CA RID: 94410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040170CB RID: 94411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040170CC RID: 94412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040170CD RID: 94413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040170CE RID: 94414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040170CF RID: 94415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040170D0 RID: 94416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040170D1 RID: 94417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040170D2 RID: 94418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040170D3 RID: 94419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040170D4 RID: 94420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040170D5 RID: 94421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040170D6 RID: 94422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040170D7 RID: 94423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040170D8 RID: 94424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040170D9 RID: 94425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040170DA RID: 94426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040170DB RID: 94427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040170DC RID: 94428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040170DD RID: 94429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040170DE RID: 94430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040170DF RID: 94431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040170E0 RID: 94432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040170E1 RID: 94433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040170E2 RID: 94434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
